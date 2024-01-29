using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using Battlehub.RTHandles;
using Battlehub.SplineEditor;
using Battlehub.UIControls;
using FMOD;
using FMODUnity;
using GameSparks.Api;
using GameSparks.Api.Messages;
using GameSparks.Api.Requests;
using GameSparks.Api.Responses;
using GameSparks.Core;
using GameSparks.Platforms;
using GameSparks.RT;
using SimpleJson2.Reflection;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Sprites;
using UnityEngine.UI;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public class XboxLiveExample : MonoBehaviour
{
	private string debugText = "";

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
		GUI.Label(new Rect(10f, 10f, 300f, 50f), debugText);
	}
}
public class SimpleGPUInstancingExample : MonoBehaviour
{
	public Transform Prefab;

	public Material InstancedMaterial;

	private void Awake()
	{
		InstancedMaterial.enableInstancing = true;
		int num = 5;
		for (int i = 0; i < 1000; i++)
		{
			Transform obj = UnityEngine.Object.Instantiate(Prefab, new Vector3(UnityEngine.Random.Range(-num, num), num + UnityEngine.Random.Range(-num, num), UnityEngine.Random.Range(-num, num)), Quaternion.identity);
			MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
			Color value = new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f));
			materialPropertyBlock.SetColor("_Color", value);
			obj.GetComponent<MeshRenderer>().SetPropertyBlock(materialPropertyBlock);
		}
	}
}
public class SimpleMoveExample : MonoBehaviour
{
	private Vector3 m_previous;

	private Vector3 m_target;

	private Vector3 m_originalPosition;

	public Vector3 BoundingVolume = new Vector3(3f, 1f, 3f);

	public float Speed = 10f;

	private void Start()
	{
		m_originalPosition = base.transform.position;
		m_previous = base.transform.position;
		m_target = base.transform.position;
	}

	private void Update()
	{
		base.transform.position = Vector3.Slerp(m_previous, m_target, Time.deltaTime * Speed);
		m_previous = base.transform.position;
		if (Vector3.Distance(m_target, base.transform.position) < 0.1f)
		{
			m_target = base.transform.position + UnityEngine.Random.onUnitSphere * UnityEngine.Random.Range(0.7f, 4f);
			m_target.Set(Mathf.Clamp(m_target.x, m_originalPosition.x - BoundingVolume.x, m_originalPosition.x + BoundingVolume.x), Mathf.Clamp(m_target.y, m_originalPosition.y - BoundingVolume.y, m_originalPosition.y + BoundingVolume.y), Mathf.Clamp(m_target.z, m_originalPosition.z - BoundingVolume.z, m_originalPosition.z + BoundingVolume.z));
		}
	}
}
public class Smear : MonoBehaviour
{
	private Queue<Vector3> m_recentPositions = new Queue<Vector3>();

	public int FramesBufferSize;

	public Renderer Renderer;

	private Material m_instancedMaterial;

	private Material InstancedMaterial
	{
		get
		{
			return m_instancedMaterial;
		}
		set
		{
			m_instancedMaterial = value;
		}
	}

	private void Start()
	{
		InstancedMaterial = Renderer.material;
	}

	private void LateUpdate()
	{
		if (m_recentPositions.Count > FramesBufferSize)
		{
			InstancedMaterial.SetVector("_PrevPosition", m_recentPositions.Dequeue());
		}
		InstancedMaterial.SetVector("_Position", base.transform.position);
		m_recentPositions.Enqueue(base.transform.position);
	}
}
[ExecuteInEditMode]
public class PostProcessExample : MonoBehaviour
{
	public Material PostProcessMat;

	private void Awake()
	{
		if (PostProcessMat == null)
		{
			base.enabled = false;
		}
		else
		{
			PostProcessMat.mainTexture = PostProcessMat.mainTexture;
		}
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		Graphics.Blit(src, dest, PostProcessMat);
	}
}
[ExecuteInEditMode]
public class SpriteMaskController : MonoBehaviour
{
	private SpriteRenderer m_spriteRenderer;

	private Vector4 m_uvs;

	private void OnEnable()
	{
		m_spriteRenderer = GetComponent<SpriteRenderer>();
		m_uvs = DataUtility.GetInnerUV(m_spriteRenderer.sprite);
		m_spriteRenderer.sharedMaterial.SetVector("_CustomUVS", m_uvs);
	}
}
public class CameraControl : MonoBehaviour
{
	public Transform target;

	public float fastSpeed = 0.3f;

	public float cameraSpeed = 0.08f;

	public GameObject defaultCam;

	public float defaultSpeed = 0.08f;

	public Vector2 clampInDegrees = new Vector2(360f, 180f);

	public bool lockCursor;

	public Vector2 sensitivity = new Vector2(2f, 2f);

	public Vector2 smoothing = new Vector2(3f, 3f);

	public Vector2 targetDirection;

	public float distance = 3f;

	public float height = 3f;

	public float heightOffset = 1f;

	public float damping = 5f;

	public bool smoothRotation = true;

	public float rotationDamping = 10f;

	private Vector2 _mouseAbsolute;

	private Vector2 _smoothMouse;

	private bool cameraSwitch;

	private void Start()
	{
		defaultSpeed = cameraSpeed;
		targetDirection = base.transform.localRotation.eulerAngles;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.H))
		{
			if (!cameraSwitch)
			{
				cameraSwitch = true;
			}
			else
			{
				cameraSwitch = false;
			}
		}
		if (cameraSwitch)
		{
			if (Input.GetKey(KeyCode.W))
			{
				defaultCam.transform.position += cameraSpeed * base.transform.forward;
			}
			if (Input.GetKey(KeyCode.S))
			{
				defaultCam.transform.position += cameraSpeed * -base.transform.forward;
			}
			if (Input.GetKey(KeyCode.A))
			{
				defaultCam.transform.position += cameraSpeed * -base.transform.right;
			}
			if (Input.GetKey(KeyCode.D))
			{
				defaultCam.transform.position += cameraSpeed * base.transform.right;
			}
			if (Input.GetKey(KeyCode.Q))
			{
				defaultCam.transform.position += cameraSpeed * Vector3.up;
			}
			if (Input.GetKey(KeyCode.E))
			{
				defaultCam.transform.position += cameraSpeed * -Vector3.up;
			}
			if (Input.GetKey(KeyCode.LeftShift))
			{
				cameraSpeed = fastSpeed;
			}
			else
			{
				cameraSpeed = defaultSpeed;
			}
			if (Input.GetButton("Fire2"))
			{
				Cursor.lockState = (lockCursor ? CursorLockMode.Locked : CursorLockMode.None);
				Quaternion quaternion = Quaternion.Euler(targetDirection);
				Vector2 a = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
				a = Vector2.Scale(a, new Vector2(sensitivity.x * smoothing.x, sensitivity.y * smoothing.y));
				_smoothMouse.x = Mathf.Lerp(_smoothMouse.x, a.x, 1f / smoothing.x);
				_smoothMouse.y = Mathf.Lerp(_smoothMouse.y, a.y, 1f / smoothing.y);
				_mouseAbsolute += _smoothMouse;
				if (clampInDegrees.x < 360f)
				{
					_mouseAbsolute.x = Mathf.Clamp(_mouseAbsolute.x, (0f - clampInDegrees.x) * 0.5f, clampInDegrees.x * 0.5f);
				}
				Quaternion localRotation = Quaternion.AngleAxis(0f - _mouseAbsolute.y, quaternion * Vector3.right);
				base.transform.localRotation = localRotation;
				if (clampInDegrees.y < 360f)
				{
					_mouseAbsolute.y = Mathf.Clamp(_mouseAbsolute.y, (0f - clampInDegrees.y) * 0.5f, clampInDegrees.y * 0.5f);
				}
				base.transform.localRotation *= quaternion;
				Quaternion quaternion2 = Quaternion.AngleAxis(_mouseAbsolute.x, base.transform.InverseTransformDirection(Vector3.up));
				base.transform.localRotation *= quaternion2;
			}
		}
		else
		{
			Vector3 b = target.TransformPoint(distance, height, 0f);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * damping);
			if (smoothRotation)
			{
				Quaternion b2 = Quaternion.LookRotation(target.position - base.transform.position + new Vector3(0f, heightOffset, 0f), target.up);
				base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b2, Time.deltaTime * rotationDamping);
			}
			else
			{
				base.transform.LookAt(target, target.up);
			}
		}
	}
}
public class IKHands : MonoBehaviour
{
	public Transform leftHandObj;

	public Transform rightHandObj;

	public Transform attachLeft;

	public Transform attachRight;

	public float leftHandPositionWeight;

	public float leftHandRotationWeight;

	public float rightHandPositionWeight;

	public float rightHandRotationWeight;

	private Animator animator;

	private void Start()
	{
		animator = base.gameObject.GetComponent<Animator>();
	}

	private void OnAnimatorIK(int layerIndex)
	{
		if (leftHandObj != null)
		{
			animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, leftHandPositionWeight);
			animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, leftHandRotationWeight);
			animator.SetIKPosition(AvatarIKGoal.LeftHand, attachLeft.position);
			animator.SetIKRotation(AvatarIKGoal.LeftHand, attachLeft.rotation);
		}
		if (rightHandObj != null)
		{
			animator.SetIKPositionWeight(AvatarIKGoal.RightHand, rightHandPositionWeight);
			animator.SetIKRotationWeight(AvatarIKGoal.RightHand, rightHandRotationWeight);
			animator.SetIKPosition(AvatarIKGoal.RightHand, attachRight.position);
			animator.SetIKRotation(AvatarIKGoal.RightHand, attachRight.rotation);
		}
	}
}
public class SmoothFollow : MonoBehaviour
{
	private const float SMOOTH_TIME = 0.3f;

	public bool LockX;

	public float offSetX;

	public float offSetY;

	public float offSetZ;

	public bool LockY;

	public bool LockZ;

	public bool useSmoothing;

	public Transform target;

	public GameObject hudElements;

	private Transform thisTransform;

	private Vector3 velocity;

	private bool hudActive = true;

	private void Awake()
	{
		thisTransform = base.transform;
		velocity = new Vector3(0.5f, 0.5f, 0.5f);
	}

	private void Update()
	{
		if (hudActive)
		{
			if (Input.GetKeyDown(KeyCode.H))
			{
				hudElements.SetActive(value: false);
				hudActive = false;
			}
		}
		else if (Input.GetKeyDown(KeyCode.H))
		{
			hudElements.SetActive(value: true);
			hudActive = true;
		}
	}

	private void LateUpdate()
	{
		Vector3 zero = Vector3.zero;
		if (useSmoothing)
		{
			zero.x = Mathf.SmoothDamp(thisTransform.position.x, target.position.x + offSetX, ref velocity.x, 0.3f);
			zero.y = Mathf.SmoothDamp(thisTransform.position.y, target.position.y + offSetY, ref velocity.y, 0.3f);
			zero.z = Mathf.SmoothDamp(thisTransform.position.z, target.position.z + offSetZ, ref velocity.z, 0.3f);
		}
		else
		{
			zero.x = target.position.x;
			zero.y = target.position.y;
			zero.z = target.position.z;
		}
		if (LockX)
		{
			zero.x = thisTransform.position.x;
		}
		if (LockY)
		{
			zero.y = thisTransform.position.y;
		}
		if (LockZ)
		{
			zero.z = thisTransform.position.z;
		}
		base.transform.position = Vector3.Slerp(base.transform.position, zero, Time.time);
	}
}
public class WarriorAnimationDemo : MonoBehaviour
{
	public enum Warrior
	{
		Karate,
		Ninja,
		Brute,
		Sorceress,
		Knight,
		Mage,
		Archer,
		TwoHanded,
		Swordsman,
		Spearman,
		Hammer,
		Crossbow
	}

	private Animator animator;

	public GameObject target;

	public GameObject weaponModel;

	public GameObject secondaryWeaponModel;

	private float rotationSpeed = 15f;

	public float gravity = -9.83f;

	public float runSpeed = 8f;

	public float walkSpeed = 3f;

	public float strafeSpeed = 3f;

	private bool canMove = true;

	public float jumpSpeed = 8f;

	private bool jumpHold;

	private bool canJump = true;

	private float fallingVelocity = -2f;

	private bool isFalling;

	public float inAirSpeed = 8f;

	private float maxVelocity = 2f;

	private float minVelocity = -2f;

	private Vector3 newVelocity;

	private Vector3 inputVec;

	private Vector3 targetDirection;

	private Vector3 targetDashDirection;

	private bool isDashing;

	private bool isGrounded = true;

	private bool dead;

	private bool isStrafing;

	private bool isBlocking;

	private bool isStunned;

	private bool isSitting;

	private bool inBlock;

	private bool blockGui;

	private bool aimingGui;

	private bool weaponSheathed;

	private bool weaponSheathed2;

	private bool isInAir;

	private bool isStealth;

	public float stealthSpeed;

	private bool isWall;

	private bool ledgeGui;

	private bool ledge;

	public float ledgeSpeed;

	private int attack;

	private bool canChain;

	private bool specialAttack2Bool;

	public Warrior warrior;

	private IKHands ikhands;

	private void Start()
	{
		animator = GetComponent<Animator>();
		if (warrior == Warrior.Archer)
		{
			secondaryWeaponModel.gameObject.SetActive(value: false);
		}
		if ((warrior == Warrior.Archer || warrior == Warrior.Crossbow) && animator.layerCount >= 1)
		{
			animator.SetLayerWeight(1, 0f);
		}
		if (warrior == Warrior.TwoHanded)
		{
			secondaryWeaponModel.GetComponent<Renderer>().enabled = false;
			ikhands = base.gameObject.GetComponent<IKHands>();
		}
	}

	private void FixedUpdate()
	{
		CheckForGrounded();
		GetComponent<Rigidbody>().AddForce(0f, gravity, 0f, ForceMode.Acceleration);
		if (!isGrounded)
		{
			AirControl();
		}
		if (canMove)
		{
			UpdateMovement();
		}
		if (GetComponent<Rigidbody>().velocity.y < fallingVelocity)
		{
			isFalling = true;
		}
		else
		{
			isFalling = false;
		}
	}

	private void LateUpdate()
	{
		float x = base.transform.InverseTransformDirection(GetComponent<Rigidbody>().velocity).x;
		float z = base.transform.InverseTransformDirection(GetComponent<Rigidbody>().velocity).z;
		animator.SetFloat("Input X", x / runSpeed);
		animator.SetFloat("Input Z", z / runSpeed);
	}

	private void Update()
	{
		UpdateMovement();
		InAir();
		JumpingUpdate();
		if (Input.GetKeyDown(KeyCode.P))
		{
			UnityEngine.Debug.Break();
		}
		if (!dead || !blockGui || !isBlocking)
		{
			Vector3 vector = Camera.main.transform.TransformDirection(Vector3.forward);
			vector.y = 0f;
			vector = vector.normalized;
			Vector3 vector2 = new Vector3(vector.z, 0f, vector.x);
			float axisRaw = Input.GetAxisRaw("Vertical");
			float axisRaw2 = Input.GetAxisRaw("Horizontal");
			float axisRaw3 = Input.GetAxisRaw("DashVertical");
			float axisRaw4 = Input.GetAxisRaw("DashHorizontal");
			targetDirection = axisRaw2 * vector2 + axisRaw * vector;
			targetDashDirection = axisRaw4 * vector2 + axisRaw3 * -vector;
			inputVec = new Vector3(axisRaw2, 0f, axisRaw);
			if (!isBlocking)
			{
				if ((double)axisRaw > 0.1 || (double)axisRaw < -0.1 || (double)axisRaw2 > 0.1 || (double)axisRaw2 < -0.1)
				{
					animator.SetBool("Moving", value: true);
					animator.SetBool("Running", value: true);
					if (Input.GetKey(KeyCode.LeftShift) || (double)Input.GetAxisRaw("TargetBlock") > 0.1)
					{
						if (!weaponSheathed)
						{
							isStrafing = true;
							animator.SetBool("Running", value: false);
						}
					}
					else
					{
						isStrafing = false;
						animator.SetBool("Running", value: true);
					}
				}
				else
				{
					animator.SetBool("Moving", value: false);
					animator.SetBool("Running", value: false);
				}
			}
			if (!weaponSheathed)
			{
				if (!blockGui)
				{
					if ((double)Input.GetAxis("TargetBlock") < -0.1 && !inBlock && !isInAir && attack == 0)
					{
						animator.SetBool("Block", value: true);
						isBlocking = true;
						animator.SetBool("Running", value: false);
						animator.SetBool("Moving", value: false);
						newVelocity = new Vector3(0f, 0f, 0f);
					}
					if (Input.GetAxis("TargetBlock") == 0f)
					{
						inBlock = false;
						isBlocking = false;
						animator.SetBool("Block", value: false);
					}
				}
				if (!isBlocking)
				{
					if (Input.GetButtonDown("Fire1") && attack <= 3)
					{
						AttackChain();
					}
					if (!isInAir)
					{
						if (Input.GetButtonDown("Jump") && canJump)
						{
							StartCoroutine(_Jump(0.8f));
						}
						if (attack == 0)
						{
							if (Input.GetButtonDown("Fire0"))
							{
								RangedAttack();
							}
							if (Input.GetButtonDown("Fire2"))
							{
								MoveAttack();
							}
							if (Input.GetButtonDown("Fire3"))
							{
								SpecialAttack();
							}
						}
						if (Input.GetButtonDown("LightHit"))
						{
							StartCoroutine(_GetHit());
						}
					}
				}
				else
				{
					if (Input.GetButtonDown("Jump"))
					{
						StartCoroutine(_BlockHitReact());
					}
					if (Input.GetButtonDown("Fire0"))
					{
						StartCoroutine(_BlockHitReact());
					}
					if (Input.GetButtonDown("Fire1"))
					{
						StartCoroutine(_BlockHitReact());
					}
					if (Input.GetButtonDown("Fire2"))
					{
						StartCoroutine(_BlockHitReact());
					}
					if (Input.GetButtonDown("Fire3"))
					{
						StartCoroutine(_BlockHitReact());
					}
					if (Input.GetButtonDown("LightHit"))
					{
						StartCoroutine(_BlockBreak());
					}
					if (Input.GetButtonDown("Death"))
					{
						StartCoroutine(_BlockBreak());
					}
				}
				if (((double)Input.GetAxis("DashVertical") > 0.5 || (double)Input.GetAxis("DashVertical") < -0.5 || (double)Input.GetAxis("DashHorizontal") > 0.5 || (double)Input.GetAxis("DashHorizontal") < -0.5) && !isDashing && !isInAir)
				{
					StartCoroutine(_DirectionalDash(Input.GetAxis("DashVertical"), Input.GetAxis("DashHorizontal")));
				}
			}
		}
		else
		{
			newVelocity = new Vector3(0f, 0f, 0f);
			inputVec = new Vector3(0f, 0f, 0f);
		}
		if (!dead)
		{
			if (!isBlocking && Input.GetButtonDown("Death"))
			{
				Dead();
			}
		}
		else if (Input.GetButtonDown("Death"))
		{
			StartCoroutine(_Revive());
		}
		if (Input.GetButtonDown("Special") && warrior == Warrior.Ninja)
		{
			if (!isStealth)
			{
				isStealth = true;
				animator.SetBool("Stealth", value: true);
			}
			else
			{
				isStealth = false;
				animator.SetBool("Stealth", value: false);
			}
		}
		if (Input.GetKeyDown(KeyCode.T))
		{
			if (Time.timeScale == 1f)
			{
				Time.timeScale = 0.25f;
			}
			else
			{
				Time.timeScale = 1f;
			}
		}
	}

	private float UpdateMovement()
	{
		Vector3 vector = inputVec;
		if (isGrounded)
		{
			if (!dead && !isBlocking && !blockGui && !isStunned)
			{
				vector *= ((Mathf.Abs(inputVec.x) == 1f && Mathf.Abs(inputVec.z) == 1f) ? 0.7f : 1f);
				if (!isStrafing)
				{
					newVelocity = vector * runSpeed;
				}
				else
				{
					newVelocity = vector * strafeSpeed;
				}
				if (ledge)
				{
					newVelocity = vector * ledgeSpeed;
				}
				if (isStealth)
				{
					newVelocity = vector * stealthSpeed;
				}
			}
			else
			{
				newVelocity = new Vector3(0f, 0f, 0f);
				inputVec = new Vector3(0f, 0f, 0f);
			}
		}
		else
		{
			newVelocity = GetComponent<Rigidbody>().velocity;
		}
		newVelocity.y = GetComponent<Rigidbody>().velocity.y;
		GetComponent<Rigidbody>().velocity = newVelocity;
		if (!isStrafing && !isWall && (!ledgeGui || !ledge))
		{
			RotateTowardMovementDirection();
		}
		if (isStrafing)
		{
			float num = 40f;
			Quaternion quaternion = Quaternion.LookRotation(target.transform.position - new Vector3(base.transform.position.x, 0f, base.transform.position.z));
			base.transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(base.transform.eulerAngles.y, quaternion.eulerAngles.y, num * Time.deltaTime * num);
		}
		return inputVec.magnitude;
	}

	private void RotateTowardMovementDirection()
	{
		if (!dead && !blockGui && !isBlocking && !isStunned && inputVec != Vector3.zero && !isStrafing)
		{
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, Quaternion.LookRotation(targetDirection), Time.deltaTime * rotationSpeed);
		}
	}

	private void CheckForGrounded()
	{
		float num = 0.45f;
		Vector3 vector = new Vector3(0f, 0.4f, 0f);
		if (Physics.Raycast(base.transform.position + vector, -Vector3.up, out var hitInfo, 100f))
		{
			if (hitInfo.distance < num)
			{
				isGrounded = true;
				isInAir = false;
			}
			else
			{
				isGrounded = false;
				isInAir = true;
			}
		}
	}

	private void JumpingUpdate()
	{
		if (!jumpHold)
		{
			if (isGrounded)
			{
				animator.SetInteger("Jumping", 0);
				canJump = true;
			}
			else if (!ledge && isFalling)
			{
				animator.SetInteger("Jumping", 2);
				canJump = false;
			}
		}
	}

	private IEnumerator _Jump(float jumpTime)
	{
		animator.SetTrigger("JumpTrigger");
		canJump = false;
		GetComponent<Rigidbody>().velocity += jumpSpeed * Vector3.up;
		animator.SetInteger("Jumping", 1);
		yield return new WaitForSeconds(jumpTime);
	}

	private void AirControl()
	{
		float axisRaw = Input.GetAxisRaw("Horizontal");
		float axisRaw2 = Input.GetAxisRaw("Vertical");
		Vector3 vector = new Vector3(axisRaw, 0f, axisRaw2);
		Vector3 vector2 = vector;
		vector2 *= ((Mathf.Abs(vector.x) == 1f && Mathf.Abs(vector.z) == 1f) ? 0.7f : 1f);
		GetComponent<Rigidbody>().AddForce(vector2 * inAirSpeed, ForceMode.Acceleration);
		float num = 0f;
		float num2 = 0f;
		if (GetComponent<Rigidbody>().velocity.x > maxVelocity)
		{
			num = GetComponent<Rigidbody>().velocity.x - maxVelocity;
			if (num < 0f)
			{
				num = 0f;
			}
			GetComponent<Rigidbody>().AddForce(new Vector3(0f - num, 0f, 0f), ForceMode.Acceleration);
		}
		if (GetComponent<Rigidbody>().velocity.x < minVelocity)
		{
			num = GetComponent<Rigidbody>().velocity.x - minVelocity;
			if (num > 0f)
			{
				num = 0f;
			}
			GetComponent<Rigidbody>().AddForce(new Vector3(0f - num, 0f, 0f), ForceMode.Acceleration);
		}
		if (GetComponent<Rigidbody>().velocity.z > maxVelocity)
		{
			num2 = GetComponent<Rigidbody>().velocity.z - maxVelocity;
			if (num2 < 0f)
			{
				num2 = 0f;
			}
			GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, 0f - num2), ForceMode.Acceleration);
		}
		if (GetComponent<Rigidbody>().velocity.z < minVelocity)
		{
			num2 = GetComponent<Rigidbody>().velocity.z - minVelocity;
			if (num2 > 0f)
			{
				num2 = 0f;
			}
			GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, 0f - num2), ForceMode.Acceleration);
		}
	}

	private void InAir()
	{
		if (isInAir && ledgeGui)
		{
			animator.SetTrigger("Ledge-Catch");
			ledge = true;
		}
	}

	private void AttackChain()
	{
		if (isInAir)
		{
			StartCoroutine(_JumpAttack1());
		}
		else if (attack == 0)
		{
			StartCoroutine(_Attack1());
		}
		else if (canChain && warrior != Warrior.Archer)
		{
			if (attack == 1)
			{
				StartCoroutine(_Attack2());
			}
			else if (attack == 2)
			{
				StartCoroutine(_Attack3());
			}
		}
	}

	private IEnumerator _Attack1()
	{
		StopAllCoroutines();
		canChain = false;
		animator.SetInteger("Attack", 1);
		attack = 1;
		if (warrior == Warrior.Knight)
		{
			StartCoroutine(_ChainWindow(0.1f, 0.8f));
			StartCoroutine(_LockMovementAndAttack(0.7f));
		}
		else if (warrior == Warrior.TwoHanded)
		{
			StartCoroutine(_ChainWindow(0.6f, 1f));
			StartCoroutine(_LockMovementAndAttack(1f));
		}
		else if (warrior == Warrior.Brute)
		{
			StartCoroutine(_ChainWindow(0.5f, 0.5f));
			StartCoroutine(_LockMovementAndAttack(1.2f));
		}
		else if (warrior == Warrior.Sorceress)
		{
			StartCoroutine(_ChainWindow(0.3f, 1.4f));
			StartCoroutine(_LockMovementAndAttack(1.2f));
		}
		else if (warrior == Warrior.Swordsman)
		{
			StartCoroutine(_ChainWindow(0.6f, 1.1f));
			StartCoroutine(_LockMovementAndAttack(1f));
		}
		else if (warrior == Warrior.Spearman)
		{
			StartCoroutine(_ChainWindow(0.2f, 0.8f));
			StartCoroutine(_LockMovementAndAttack(1.1f));
		}
		else if (warrior == Warrior.Hammer)
		{
			StartCoroutine(_ChainWindow(0.6f, 1.2f));
			StartCoroutine(_LockMovementAndAttack(1.4f));
		}
		else if (warrior == Warrior.Crossbow)
		{
			StartCoroutine(_LockMovementAndAttack(0.7f));
		}
		else if (warrior == Warrior.Mage)
		{
			StartCoroutine(_ChainWindow(0.4f, 1.2f));
			StartCoroutine(_LockMovementAndAttack(1.1f));
		}
		else if (warrior == Warrior.Archer)
		{
			StartCoroutine(_LockMovementAndAttack(0.7f));
		}
		else
		{
			StartCoroutine(_ChainWindow(0.2f, 0.7f));
			StartCoroutine(_LockMovementAndAttack(0.6f));
		}
		yield return null;
	}

	private IEnumerator _Attack2()
	{
		StopAllCoroutines();
		canChain = false;
		animator.SetInteger("Attack", 2);
		attack = 2;
		if (warrior == Warrior.Knight)
		{
			StartCoroutine(_ChainWindow(0.4f, 0.9f));
			StartCoroutine(_LockMovementAndAttack(0.6f));
		}
		else if (warrior == Warrior.TwoHanded)
		{
			StartCoroutine(_ChainWindow(0.5f, 0.8f));
			StartCoroutine(_LockMovementAndAttack(1.1f));
		}
		else if (warrior == Warrior.Brute)
		{
			StartCoroutine(_ChainWindow(0.3f, 0.7f));
			StartCoroutine(_LockMovementAndAttack(1.4f));
		}
		else if (warrior == Warrior.Sorceress)
		{
			StartCoroutine(_ChainWindow(0.6f, 1.2f));
		}
		else if (warrior == Warrior.Karate)
		{
			StartCoroutine(_ChainWindow(0.3f, 0.6f));
			StartCoroutine(_LockMovementAndAttack(0.9f));
		}
		else if (warrior == Warrior.Swordsman)
		{
			StartCoroutine(_ChainWindow(0.6f, 1.1f));
			StartCoroutine(_LockMovementAndAttack(1.1f));
		}
		else if (warrior == Warrior.Spearman)
		{
			StartCoroutine(_ChainWindow(0.6f, 1.1f));
			StartCoroutine(_LockMovementAndAttack(1.1f));
		}
		else if (warrior == Warrior.Hammer)
		{
			StartCoroutine(_ChainWindow(0.6f, 1.2f));
			StartCoroutine(_LockMovementAndAttack(1.4f));
		}
		else if (warrior == Warrior.Mage)
		{
			StartCoroutine(_ChainWindow(0.4f, 1.2f));
			StartCoroutine(_LockMovementAndAttack(1.3f));
		}
		else if (warrior == Warrior.Ninja)
		{
			StartCoroutine(_ChainWindow(0.2f, 0.8f));
			StartCoroutine(_LockMovementAndAttack(0.8f));
		}
		else
		{
			StartCoroutine(_ChainWindow(0.1f, 2f));
			StartCoroutine(_LockMovementAndAttack(1.2f));
		}
		yield return null;
	}

	private IEnumerator _Attack3()
	{
		StopAllCoroutines();
		animator.SetInteger("Attack", 3);
		attack = 3;
		if (warrior == Warrior.Knight)
		{
			StartCoroutine(_LockMovementAndAttack(0.9f));
		}
		if (warrior == Warrior.Swordsman)
		{
			StartCoroutine(_LockMovementAndAttack(1.4f));
		}
		else if (warrior == Warrior.Hammer)
		{
			StartCoroutine(_LockMovementAndAttack(1.5f));
		}
		else if (warrior == Warrior.Karate)
		{
			StartCoroutine(_LockMovementAndAttack(0.8f));
		}
		else if (warrior == Warrior.Brute)
		{
			StartCoroutine(_LockMovementAndAttack(1.7f));
		}
		else if (warrior == Warrior.TwoHanded)
		{
			StartCoroutine(_LockMovementAndAttack(1f));
		}
		else if (warrior == Warrior.Mage)
		{
			StartCoroutine(_LockMovementAndAttack(1f));
		}
		else
		{
			StartCoroutine(_LockMovementAndAttack(1.2f));
		}
		canChain = false;
		yield return null;
	}

	private void RangedAttack()
	{
		StopAllCoroutines();
		animator.SetTrigger("RangeAttack1Trigger");
		attack = 4;
		if (warrior == Warrior.Brute)
		{
			StartCoroutine(_LockMovementAndAttack(2.4f));
		}
		else if (warrior == Warrior.Mage)
		{
			StartCoroutine(_LockMovementAndAttack(1.7f));
		}
		else if (warrior == Warrior.Ninja)
		{
			StartCoroutine(_LockMovementAndAttack(0.9f));
		}
		else if (warrior == Warrior.Archer)
		{
			StartCoroutine(_SetLayerWeight(0.6f));
			StartCoroutine(_ArcherArrow(0.2f));
		}
		else if (warrior == Warrior.Crossbow)
		{
			StartCoroutine(_SetLayerWeight(0.6f));
			StartCoroutine(_ArcherArrow(0.2f));
		}
		else if (warrior == Warrior.TwoHanded)
		{
			StartCoroutine(_LockMovementAndAttack(2.6f));
			StartCoroutine(_SecondaryWeaponVisibility(0.7f, weaponVisiblity: true));
			StartCoroutine(_WeaponVisibility(0.7f, weaponVisiblity: false));
			StartCoroutine(_SecondaryWeaponVisibility(2f, weaponVisiblity: false));
			StartCoroutine(_WeaponVisibility(2f, weaponVisiblity: true));
		}
		else if (warrior == Warrior.Hammer)
		{
			StartCoroutine(_LockMovementAndAttack(1.7f));
		}
		else
		{
			StartCoroutine(_LockMovementAndAttack(1.2f));
		}
	}

	private void MoveAttack()
	{
		StopAllCoroutines();
		attack = 5;
		animator.SetTrigger("MoveAttack1Trigger");
		if (warrior == Warrior.Brute)
		{
			StartCoroutine(_LockMovementAndAttack(1.4f));
		}
		else if (warrior == Warrior.Sorceress)
		{
			StartCoroutine(_LockMovementAndAttack(1.1f));
		}
		else if (warrior == Warrior.Mage)
		{
			StartCoroutine(_LockMovementAndAttack(1.5f));
		}
		else if (warrior == Warrior.TwoHanded)
		{
			StartCoroutine(_LockMovementAndAttack(1.2f));
		}
		else if (warrior == Warrior.Hammer)
		{
			StartCoroutine(_LockMovementAndAttack(2.4f));
		}
		else if (warrior == Warrior.Knight)
		{
			StartCoroutine(_LockMovementAndAttack(1.1f));
		}
		else if (warrior == Warrior.Crossbow)
		{
			StartCoroutine(_LockMovementAndAttack(1f));
		}
		else
		{
			StartCoroutine(_LockMovementAndAttack(0.9f));
		}
	}

	private void SpecialAttack()
	{
		StopAllCoroutines();
		attack = 6;
		animator.SetTrigger("SpecialAttack1Trigger");
		if (warrior == Warrior.Brute)
		{
			StartCoroutine(_LockMovementAndAttack(2f));
		}
		else if (warrior == Warrior.Sorceress)
		{
			StartCoroutine(_LockMovementAndAttack(1.5f));
		}
		else if (warrior == Warrior.Knight)
		{
			StartCoroutine(_LockMovementAndAttack(1.1f));
		}
		else if (warrior == Warrior.Mage)
		{
			StartCoroutine(_LockMovementAndAttack(1.95f));
		}
		else if (warrior == Warrior.TwoHanded)
		{
			StartCoroutine(_LockMovementAndAttack(1.2f));
		}
		else if (warrior == Warrior.Swordsman)
		{
			StartCoroutine(_LockMovementAndAttack(1f));
		}
		else if (warrior == Warrior.Spearman)
		{
			StartCoroutine(_LockMovementAndAttack(0.9f));
		}
		else if (warrior == Warrior.Hammer)
		{
			StartCoroutine(_LockMovementAndAttack(1.6f));
		}
		else if (warrior == Warrior.Crossbow)
		{
			StartCoroutine(_LockMovementAndAttack(1f));
		}
		else
		{
			StartCoroutine(_LockMovementAndAttack(1.7f));
		}
	}

	private IEnumerator _JumpAttack1()
	{
		yield return new WaitForFixedUpdate();
		jumpHold = true;
		GetComponent<Rigidbody>().velocity += jumpSpeed * -Vector3.up;
		animator.SetTrigger("JumpAttack1Trigger");
		if (warrior == Warrior.Knight)
		{
			StartCoroutine(_LockMovementAndAttack(1f));
			yield return new WaitForSeconds(0.5f);
		}
		else if (warrior == Warrior.Hammer)
		{
			StartCoroutine(_LockMovementAndAttack(1.2f));
			yield return new WaitForSeconds(0.7f);
		}
		else if (warrior == Warrior.Spearman)
		{
			StartCoroutine(_LockMovementAndAttack(0.9f));
			yield return new WaitForSeconds(0.7f);
		}
		else
		{
			StartCoroutine(_LockMovementAndAttack(1f));
			yield return new WaitForSeconds(0.8f);
		}
		jumpHold = false;
	}

	private IEnumerator _DirectionalDash(float x, float v)
	{
		float num = Vector3.Angle(targetDashDirection, -base.transform.forward);
		float num2 = Mathf.Sign(Vector3.Dot(base.transform.up, Vector3.Cross(targetDashDirection, base.transform.forward)));
		float num3 = (num * num2 + 180f) % 360f;
		if (num3 > 315f || num3 < 45f)
		{
			StartCoroutine(_Dash(1));
		}
		if (num3 > 45f && num3 < 135f)
		{
			StartCoroutine(_Dash(2));
		}
		if (num3 > 135f && num3 < 225f)
		{
			StartCoroutine(_Dash(3));
		}
		if (num3 > 225f && num3 < 315f)
		{
			StartCoroutine(_Dash(4));
		}
		yield return null;
	}

	private IEnumerator _Dash(int dashDirection)
	{
		isDashing = true;
		animator.SetInteger("Dash", dashDirection);
		if (warrior == Warrior.Brute)
		{
			StartCoroutine(_LockMovementAndAttack(1.2f));
		}
		else if (warrior == Warrior.Karate)
		{
			StartCoroutine(_LockMovementAndAttack(0.6f));
		}
		else if (warrior == Warrior.Brute)
		{
			StartCoroutine(_LockMovementAndAttack(1.2f));
		}
		else if (warrior == Warrior.Knight)
		{
			StartCoroutine(_LockMovementAndAttack(1.15f));
		}
		else if (warrior == Warrior.Archer)
		{
			StartCoroutine(_LockMovementAndAttack(0.5f));
		}
		else if (warrior == Warrior.Mage)
		{
			StartCoroutine(_LockMovementAndAttack(0.8f));
		}
		else if (warrior == Warrior.Crossbow)
		{
			StartCoroutine(_LockMovementAndAttack(0.55f));
		}
		else if (warrior == Warrior.Hammer)
		{
			StartCoroutine(_LockMovementAndAttack(1.2f));
		}
		else
		{
			StartCoroutine(_LockMovementAndAttack(0.65f));
		}
		yield return new WaitForSeconds(0.1f);
		animator.SetInteger("Dash", 0);
		isDashing = false;
	}

	private IEnumerator _Dash2(int dashDirection)
	{
		isDashing = true;
		animator.SetInteger("Dash2", dashDirection);
		yield return new WaitForEndOfFrame();
		animator.SetInteger("Dash2", dashDirection);
		yield return new WaitForEndOfFrame();
		StartCoroutine(_LockMovementAndAttack(0.65f));
		animator.SetInteger("Dash2", 0);
		yield return new WaitForSeconds(0.95f);
		isDashing = false;
	}

	private IEnumerator _SetInAir(float timeToStart, float lenthOfTime)
	{
		yield return new WaitForSeconds(timeToStart);
		isInAir = true;
		yield return new WaitForSeconds(lenthOfTime);
		isInAir = false;
	}

	public IEnumerator _ChainWindow(float timeToWindow, float chainLength)
	{
		yield return new WaitForSeconds(timeToWindow);
		canChain = true;
		animator.SetInteger("Attack", 0);
		yield return new WaitForSeconds(chainLength);
		canChain = false;
	}

	private IEnumerator _LockMovementAndAttack(float pauseTime)
	{
		isStunned = true;
		animator.applyRootMotion = true;
		inputVec = new Vector3(0f, 0f, 0f);
		newVelocity = new Vector3(0f, 0f, 0f);
		animator.SetFloat("Input X", 0f);
		animator.SetFloat("Input Z", 0f);
		animator.SetBool("Moving", value: false);
		yield return new WaitForSeconds(pauseTime);
		animator.SetInteger("Attack", 0);
		canChain = false;
		isStunned = false;
		animator.applyRootMotion = false;
		yield return new WaitForSeconds(0.2f);
		attack = 0;
	}

	private void SheathWeapon()
	{
		animator.SetTrigger("WeaponSheathTrigger");
		if (warrior == Warrior.Archer)
		{
			StartCoroutine(_WeaponVisibility(0.4f, weaponVisiblity: false));
		}
		else if (warrior == Warrior.Swordsman)
		{
			StartCoroutine(_WeaponVisibility(0.4f, weaponVisiblity: false));
			StartCoroutine(_SecondaryWeaponVisibility(0.4f, weaponVisiblity: false));
		}
		else if (warrior == Warrior.Spearman)
		{
			StartCoroutine(_WeaponVisibility(0.26f, weaponVisiblity: false));
		}
		else if (warrior == Warrior.TwoHanded)
		{
			StartCoroutine(_WeaponVisibility(0.5f, weaponVisiblity: false));
			StartCoroutine(_BlendIKHandLeftRot(0f, 0.3f, 0f));
		}
		else if (warrior == Warrior.Crossbow)
		{
			StartCoroutine(_LockMovementAndAttack(1.1f));
		}
		else
		{
			StartCoroutine(_LockMovementAndAttack(1.4f));
			StartCoroutine(_WeaponVisibility(0.5f, weaponVisiblity: false));
		}
		weaponSheathed = true;
	}

	private void UnSheathWeapon()
	{
		animator.SetTrigger("WeaponUnsheathTrigger");
		if (warrior == Warrior.Archer)
		{
			StartCoroutine(_WeaponVisibility(0.4f, weaponVisiblity: true));
		}
		else if (warrior == Warrior.TwoHanded)
		{
			StartCoroutine(_WeaponVisibility(0.35f, weaponVisiblity: true));
		}
		else if (warrior == Warrior.Swordsman)
		{
			StartCoroutine(_WeaponVisibility(0.35f, weaponVisiblity: true));
			StartCoroutine(_SecondaryWeaponVisibility(0.35f, weaponVisiblity: true));
		}
		else if (warrior == Warrior.Spearman)
		{
			StartCoroutine(_WeaponVisibility(0.45f, weaponVisiblity: true));
		}
		else if (warrior == Warrior.Crossbow)
		{
			StartCoroutine(_WeaponVisibility(0.6f, weaponVisiblity: true));
			StartCoroutine(_LockMovementAndAttack(1f));
		}
		else
		{
			StartCoroutine(_WeaponVisibility(0.6f, weaponVisiblity: true));
			StartCoroutine(_LockMovementAndAttack(1.4f));
		}
		weaponSheathed = false;
	}

	private IEnumerator _WeaponVisibility(float waitTime, bool weaponVisiblity)
	{
		yield return new WaitForSeconds(waitTime);
		weaponModel.SetActive(weaponVisiblity);
	}

	private IEnumerator _SecondaryWeaponVisibility(float waitTime, bool weaponVisiblity)
	{
		yield return new WaitForSeconds(waitTime);
		secondaryWeaponModel.GetComponent<Renderer>().enabled = weaponVisiblity;
	}

	private IEnumerator _ArcherArrow(float waitTime)
	{
		if (warrior != Warrior.Crossbow)
		{
			secondaryWeaponModel.gameObject.SetActive(value: true);
		}
		yield return new WaitForSeconds(waitTime);
		if (warrior != Warrior.Crossbow)
		{
			secondaryWeaponModel.gameObject.SetActive(value: false);
		}
		yield return new WaitForSeconds(0.2f);
		animator.SetInteger("Attack", 0);
		attack = 0;
	}

	private IEnumerator _SetLayerWeight(float time)
	{
		animator.SetLayerWeight(1, 1f);
		yield return new WaitForSeconds(time);
		float a = 1f;
		for (int i = 0; i < 20; i++)
		{
			a -= 0.05f;
			animator.SetLayerWeight(1, a);
			yield return new WaitForEndOfFrame();
		}
		animator.SetLayerWeight(1, 0f);
	}

	private IEnumerator _BlockHitReact()
	{
		StartCoroutine(_LockMovementAndAttack(0.5f));
		animator.SetTrigger("BlockHitReactTrigger");
		yield return null;
	}

	private IEnumerator _BlockBreak()
	{
		StartCoroutine(_LockMovementAndAttack(1f));
		animator.SetTrigger("BlockBreakTrigger");
		yield return null;
	}

	private IEnumerator _GetHit()
	{
		animator.SetTrigger("LightHitTrigger");
		if (warrior == Warrior.Ninja)
		{
			StartCoroutine(_LockMovementAndAttack(2.4f));
		}
		else if (warrior == Warrior.Archer)
		{
			StartCoroutine(_LockMovementAndAttack(2.7f));
		}
		else if (warrior == Warrior.Crossbow)
		{
			StartCoroutine(_LockMovementAndAttack(2.5f));
		}
		else
		{
			StartCoroutine(_LockMovementAndAttack(2.8f));
		}
		yield return null;
	}

	private void Dead()
	{
		animator.applyRootMotion = true;
		animator.SetTrigger("DeathTrigger");
		dead = true;
	}

	private IEnumerator _Revive()
	{
		animator.SetTrigger("ReviveTrigger");
		if (warrior == Warrior.Brute)
		{
			StartCoroutine(_LockMovementAndAttack(1.75f));
		}
		else if (warrior == Warrior.Mage)
		{
			StartCoroutine(_LockMovementAndAttack(1.2f));
		}
		else if (warrior == Warrior.Sorceress)
		{
			StartCoroutine(_LockMovementAndAttack(0.7f));
		}
		else if (warrior == Warrior.Ninja)
		{
			StartCoroutine(_LockMovementAndAttack(0.9f));
		}
		else if (warrior == Warrior.Crossbow)
		{
			StartCoroutine(_LockMovementAndAttack(1.3f));
		}
		else
		{
			StartCoroutine(_LockMovementAndAttack(1.1f));
			yield return null;
		}
		dead = false;
	}

	private IEnumerator _BlendIKHandLeftPos(float wait, float timeToBlend, float amount)
	{
		yield return new WaitForSeconds(wait);
		float currentLeftPos = ikhands.leftHandPositionWeight;
		float diffOverTime = (Mathf.Abs(currentLeftPos) - amount) / timeToBlend;
		float time = 0f;
		if (currentLeftPos > amount)
		{
			while (time < timeToBlend)
			{
				time += Time.deltaTime;
				ikhands.leftHandPositionWeight -= diffOverTime;
				yield return null;
			}
		}
		if (currentLeftPos < amount)
		{
			while (time < timeToBlend)
			{
				time += Time.deltaTime;
				ikhands.leftHandPositionWeight += diffOverTime;
				yield return null;
			}
		}
	}

	private IEnumerator _BlendIKHandRightPos(float wait, float timeToBlend, float amount)
	{
		yield return new WaitForSeconds(wait);
		float currentRightPos = ikhands.rightHandPositionWeight;
		float diffOverTime = (Mathf.Abs(currentRightPos) - amount) / timeToBlend;
		float time = 0f;
		if (currentRightPos > amount)
		{
			while (time < timeToBlend)
			{
				time += Time.deltaTime;
				ikhands.rightHandPositionWeight -= diffOverTime;
				yield return null;
			}
		}
		if (currentRightPos < amount)
		{
			while (time < timeToBlend)
			{
				time += Time.deltaTime;
				ikhands.rightHandPositionWeight += diffOverTime;
				yield return null;
			}
		}
	}

	private IEnumerator _BlendIKHandLeftRot(float wait, float timeToBlend, float amount)
	{
		yield return new WaitForSeconds(wait);
		float currentLeftRot = ikhands.leftHandRotationWeight;
		float diffOverTime = (Mathf.Abs(currentLeftRot) - amount) / timeToBlend;
		float time = 0f;
		while (time < timeToBlend)
		{
			if (currentLeftRot > amount)
			{
				ikhands.leftHandRotationWeight -= diffOverTime * Time.deltaTime;
				time += Time.deltaTime;
				yield return null;
			}
			if (currentLeftRot < amount)
			{
				ikhands.leftHandRotationWeight += diffOverTime * Time.deltaTime;
				time += Time.deltaTime;
				yield return null;
			}
		}
	}

	private IEnumerator _BlendIKHandRightRot(float wait, float timeToBlend, float amount)
	{
		yield return new WaitForSeconds(wait);
		float currentRightRot = ikhands.rightHandRotationWeight;
		float diffOverTime = (Mathf.Abs(currentRightRot) - amount) / timeToBlend;
		float time = 0f;
		while (time < timeToBlend)
		{
			if (currentRightRot > amount)
			{
				ikhands.rightHandRotationWeight -= diffOverTime * Time.deltaTime;
				time += Time.deltaTime;
				yield return null;
			}
			if (currentRightRot < amount)
			{
				ikhands.rightHandRotationWeight += diffOverTime * Time.deltaTime;
				time += Time.deltaTime;
				yield return null;
			}
		}
	}

	private IEnumerator _BlendIKHandRight(float time, float amount)
	{
		ikhands.rightHandPositionWeight = amount;
		ikhands.rightHandRotationWeight = amount;
		yield return new WaitForSeconds(time);
	}

	private void OnGUI()
	{
		if (!dead && (warrior == Warrior.Mage || warrior == Warrior.Ninja || warrior == Warrior.Knight || warrior == Warrior.Archer || warrior == Warrior.TwoHanded || warrior == Warrior.Swordsman || warrior == Warrior.Spearman || warrior == Warrior.Hammer || warrior == Warrior.Crossbow))
		{
			if (!dead && (weaponSheathed & !isSitting))
			{
				if (GUI.Button(new Rect(30f, 310f, 100f, 30f), "Unsheath Weapon"))
				{
					UnSheathWeapon();
				}
				if (warrior == Warrior.Ninja && GUI.Button(new Rect(30f, 350f, 100f, 30f), "Sit"))
				{
					isStunned = true;
					isSitting = true;
					animator.SetTrigger("Idle-Relax-ToSitTrigger");
				}
			}
			if (isSitting && GUI.Button(new Rect(30f, 350f, 100f, 30f), "Stand"))
			{
				animator.SetTrigger("Idle-Relax-FromSitTrigger");
				StartCoroutine(_LockMovementAndAttack(1.2f));
				isSitting = false;
			}
		}
		if (!dead && !weaponSheathed)
		{
			if (warrior == Warrior.Ninja)
			{
				if (!isBlocking && !blockGui)
				{
					ledgeGui = GUI.Toggle(new Rect(245f, 60f, 100f, 30f), ledgeGui, "Ledge Jump");
				}
				if (ledge)
				{
					if (GUI.Button(new Rect(245f, 90f, 100f, 30f), "Ledge Drop"))
					{
						animator.SetTrigger("Ledge-Drop");
						ledge = false;
						animator.SetBool("Ledge-Catch", value: false);
					}
					if (GUI.Button(new Rect(245f, 20f, 100f, 30f), "Ledge Climb"))
					{
						animator.SetTrigger("Ledge-Climb-Trigger");
						ledge = false;
						animator.SetBool("Ledge-Catch", value: false);
					}
				}
			}
			if (!ledge)
			{
				blockGui = GUI.Toggle(new Rect(25f, 215f, 50f, 30f), blockGui, "Block");
			}
			if (!ledge)
			{
				if (!isBlocking)
				{
					if (!blockGui)
					{
						animator.SetBool("Block", value: false);
					}
					else
					{
						animator.SetBool("Block", value: true);
						animator.SetFloat("Input X", 0f);
						animator.SetFloat("Input Z", 0f);
						newVelocity = new Vector3(0f, 0f, 0f);
					}
				}
				if (blockGui)
				{
					if (GUI.Button(new Rect(30f, 240f, 100f, 30f), "BlockHitReact"))
					{
						StartCoroutine(_BlockHitReact());
					}
					if (GUI.Button(new Rect(30f, 275f, 100f, 30f), "BlockBreak"))
					{
						StartCoroutine(_BlockBreak());
					}
				}
				else if (!inBlock && !inBlock && GUI.Button(new Rect(30f, 240f, 100f, 30f), "Hit React"))
				{
					StartCoroutine(_GetHit());
				}
			}
			if (!blockGui && !isBlocking && !ledge)
			{
				if (GUI.Button(new Rect(25f, 20f, 100f, 30f), "Dash Forward"))
				{
					StartCoroutine(_Dash(1));
				}
				if (GUI.Button(new Rect(135f, 20f, 100f, 30f), "Dash Right"))
				{
					StartCoroutine(_Dash(2));
				}
				if (!ledge && GUI.Button(new Rect(245f, 20f, 100f, 30f), "Jump") && canJump && isGrounded)
				{
					StartCoroutine(_Jump(0.8f));
				}
				if (GUI.Button(new Rect(25f, 50f, 100f, 30f), "Dash Backward"))
				{
					StartCoroutine(_Dash(3));
				}
				if (GUI.Button(new Rect(135f, 50f, 100f, 30f), "Dash Left"))
				{
					StartCoroutine(_Dash(4));
				}
				if (warrior == Warrior.Knight)
				{
					if (GUI.Button(new Rect(355f, 20f, 100f, 30f), "Roll Forward"))
					{
						StartCoroutine(_Dash2(1));
					}
					if (GUI.Button(new Rect(355f, 50f, 100f, 30f), "Roll Backward"))
					{
						StartCoroutine(_Dash2(3));
					}
					if (GUI.Button(new Rect(460f, 20f, 100f, 30f), "Roll Left"))
					{
						StartCoroutine(_Dash2(4));
					}
					if (GUI.Button(new Rect(460f, 50f, 100f, 30f), "Roll Right"))
					{
						StartCoroutine(_Dash2(2));
					}
				}
				if (GUI.Button(new Rect(25f, 85f, 100f, 30f), "Attack Chain") && attack <= 3)
				{
					AttackChain();
				}
				if ((warrior == Warrior.Sorceress || warrior == Warrior.Karate || warrior == Warrior.Spearman) && GUI.Button(new Rect(135f, 85f, 100f, 30f), "Attack 4"))
				{
					animator.SetInteger("Attack", 4);
					StartCoroutine(_LockMovementAndAttack(0.65f));
				}
				if ((warrior == Warrior.Sorceress || warrior == Warrior.Karate || warrior == Warrior.Spearman) && GUI.Button(new Rect(245f, 85f, 100f, 30f), "Attack 5"))
				{
					animator.SetInteger("Attack", 5);
					if (warrior == Warrior.Spearman)
					{
						StartCoroutine(_LockMovementAndAttack(1.15f));
					}
					else
					{
						StartCoroutine(_LockMovementAndAttack(1f));
					}
				}
				if ((warrior == Warrior.Sorceress || warrior == Warrior.Karate) && GUI.Button(new Rect(355f, 85f, 100f, 30f), "Attack 6"))
				{
					animator.SetInteger("Attack", 6);
					if (warrior == Warrior.Sorceress)
					{
						StartCoroutine(_LockMovementAndAttack(1.25f));
					}
					if (warrior == Warrior.Karate)
					{
						StartCoroutine(_LockMovementAndAttack(0.8f));
					}
				}
				if ((warrior == Warrior.Sorceress || warrior == Warrior.Karate) && GUI.Button(new Rect(465f, 85f, 100f, 30f), "Attack 7"))
				{
					animator.SetInteger("Attack", 7);
					if (warrior == Warrior.Sorceress)
					{
						StartCoroutine(_LockMovementAndAttack(1.25f));
					}
					if (warrior == Warrior.Karate)
					{
						StartCoroutine(_LockMovementAndAttack(1.1f));
					}
				}
				if (warrior == Warrior.Karate)
				{
					if (GUI.Button(new Rect(575f, 85f, 100f, 30f), "Attack 8"))
					{
						animator.SetInteger("Attack", 8);
						StartCoroutine(_LockMovementAndAttack(0.7f));
					}
					if (GUI.Button(new Rect(685f, 85f, 100f, 30f), "Attack 9"))
					{
						animator.SetInteger("Attack", 9);
						StartCoroutine(_LockMovementAndAttack(0.7f));
					}
				}
				if (warrior == Warrior.Sorceress && GUI.Button(new Rect(585f, 85f, 100f, 30f), "Attack 8"))
				{
					animator.SetInteger("Attack", 8);
					StartCoroutine(_LockMovementAndAttack(1.3f));
				}
				if (warrior == Warrior.Crossbow && GUI.Button(new Rect(135f, 85f, 100f, 30f), "Reload"))
				{
					StartCoroutine(_SetLayerWeight(1.2f));
					animator.SetTrigger("Reload1Trigger");
				}
				if (warrior == Warrior.Ninja)
				{
					if (GUI.Button(new Rect(135f, 85f, 100f, 30f), "Attack1_R") && attack == 0)
					{
						animator.SetTrigger("Attack1RTrigger");
						attack = 4;
						StartCoroutine(_LockMovementAndAttack(0.8f));
					}
					if (GUI.Button(new Rect(245f, 85f, 100f, 30f), "Attack2_R") && attack == 0)
					{
						attack = 4;
						animator.SetTrigger("Attack2RTrigger");
						StartCoroutine(_LockMovementAndAttack(0.8f));
					}
				}
				if (!blockGui && !isBlocking)
				{
					if (GUI.Button(new Rect(25f, 115f, 100f, 30f), "RangeAttack1") && attack == 0)
					{
						RangedAttack();
					}
					if ((warrior == Warrior.Ninja || warrior == Warrior.Crossbow || warrior == Warrior.Karate || warrior == Warrior.Mage) && GUI.Button(new Rect(135f, 115f, 100f, 30f), "RangeAttack2"))
					{
						if (warrior != 0)
						{
							if (attack == 0)
							{
								attack = 4;
								animator.SetTrigger("RangeAttack2Trigger");
								if (warrior == Warrior.Crossbow)
								{
									if (animator.GetBool("Moving"))
									{
										StartCoroutine(_SetLayerWeight(0.6f));
									}
									else
									{
										StartCoroutine(_LockMovementAndAttack(0.7f));
									}
									animator.SetInteger("Attack", 0);
									attack = 0;
								}
								else if (warrior == Warrior.Mage)
								{
									StartCoroutine(_LockMovementAndAttack(2f));
								}
								else
								{
									StartCoroutine(_LockMovementAndAttack(0.6f));
								}
							}
						}
						else
						{
							animator.SetTrigger("RangeAttack2Trigger");
							StartCoroutine(_LockMovementAndAttack(1f));
						}
					}
					if (warrior == Warrior.Ninja && GUI.Button(new Rect(245f, 115f, 100f, 30f), "RangeAttack3") && attack == 0)
					{
						attack = 4;
						animator.SetTrigger("RangeAttack3Trigger");
						StartCoroutine(_LockMovementAndAttack(0.9f));
					}
					if (GUI.Button(new Rect(25f, 145f, 100f, 30f), "MoveAttack1") && attack == 0)
					{
						MoveAttack();
					}
					if ((warrior == Warrior.Archer || warrior == Warrior.Sorceress || warrior == Warrior.Karate) && GUI.Button(new Rect(135f, 145f, 100f, 30f), "MoveAttack2"))
					{
						if (warrior == Warrior.Archer && attack == 0)
						{
							attack = 4;
							animator.SetTrigger("MoveAttack2Trigger");
							StartCoroutine(_ArcherArrow(0.6f));
							StartCoroutine(_LockMovementAndAttack(1.1f));
						}
						if (warrior == Warrior.Sorceress)
						{
							animator.SetTrigger("MoveAttack2Trigger");
							StartCoroutine(_LockMovementAndAttack(1.3f));
						}
						if (warrior == Warrior.Karate)
						{
							animator.SetTrigger("MoveAttack2Trigger");
							StartCoroutine(_LockMovementAndAttack(1f));
						}
					}
					if (warrior == Warrior.Sorceress && GUI.Button(new Rect(245f, 145f, 100f, 30f), "MoveAttack3"))
					{
						animator.SetTrigger("MoveAttack3Trigger");
						StartCoroutine(_LockMovementAndAttack(1f));
					}
					if (GUI.Button(new Rect(25f, 175f, 100f, 30f), "SpecialAttack1") && attack == 0)
					{
						SpecialAttack();
					}
					if ((warrior == Warrior.Ninja || warrior == Warrior.Sorceress || warrior == Warrior.Karate || warrior == Warrior.Knight || warrior == Warrior.Mage) && GUI.Button(new Rect(135f, 175f, 100f, 30f), "SpecialAttack2") && attack == 0)
					{
						if (warrior == Warrior.Sorceress)
						{
							if (!specialAttack2Bool)
							{
								attack = 4;
								animator.SetTrigger("SpecialAttack2Trigger");
								animator.SetBool("SpecialAttack2Bool", value: true);
								specialAttack2Bool = true;
							}
							else
							{
								attack = 4;
								specialAttack2Bool = false;
								animator.SetBool("SpecialAttack2Bool", value: false);
								animator.SetBool("SpecialAttack2Trigger", value: false);
							}
						}
						else
						{
							attack = 4;
							animator.SetTrigger("SpecialAttack2Trigger");
							if (warrior == Warrior.Knight)
							{
								StartCoroutine(_LockMovementAndAttack(0.85f));
							}
							else if (warrior == Warrior.Mage)
							{
								StartCoroutine(_LockMovementAndAttack(1.95f));
							}
							else
							{
								StartCoroutine(_LockMovementAndAttack(1.25f));
							}
						}
					}
					if (warrior == Warrior.Sorceress && GUI.Button(new Rect(245f, 175f, 100f, 30f), "SpecialAttack3"))
					{
						animator.SetTrigger("SpecialAttack3Trigger");
						StartCoroutine(_LockMovementAndAttack(1.2f));
					}
					if (GUI.Button(new Rect(30f, 270f, 100f, 30f), "Death"))
					{
						animator.SetTrigger("DeathTrigger");
						dead = true;
					}
					if ((warrior == Warrior.Mage || warrior == Warrior.Ninja || warrior == Warrior.Knight || warrior == Warrior.Archer || warrior == Warrior.TwoHanded || warrior == Warrior.Swordsman || warrior == Warrior.Spearman || warrior == Warrior.Hammer || warrior == Warrior.Crossbow) && !dead && !weaponSheathed && !weaponSheathed2 && GUI.Button(new Rect(30f, 310f, 100f, 30f), "Sheath Wpn"))
					{
						SheathWeapon();
					}
					if (warrior == Warrior.Knight && !weaponSheathed && !dead && !weaponSheathed2 && GUI.Button(new Rect(140f, 310f, 100f, 30f), "Sheath Wpn2"))
					{
						StartCoroutine(_LockMovementAndAttack(1.4f));
						animator.SetTrigger("WeaponSheath2Trigger");
						StartCoroutine(_WeaponVisibility(0.75f, weaponVisiblity: false));
						weaponSheathed2 = true;
					}
					if (warrior == Warrior.Knight && !dead && weaponSheathed2 && GUI.Button(new Rect(140f, 310f, 100f, 30f), "UnSheath Wpn2"))
					{
						StartCoroutine(_LockMovementAndAttack(1.4f));
						animator.SetTrigger("WeaponUnsheath2Trigger");
						StartCoroutine(_WeaponVisibility(0.5f, weaponVisiblity: true));
						weaponSheathed2 = false;
						weaponSheathed = false;
					}
					if (warrior == Warrior.Ninja && !isStealth && !dead && !weaponSheathed && GUI.Button(new Rect(30f, 350f, 100f, 30f), "Stealth"))
					{
						animator.SetBool("Stealth", value: true);
						isStealth = true;
					}
					if (warrior == Warrior.Ninja && isStealth && !isWall && !dead && !weaponSheathed && GUI.Button(new Rect(30f, 350f, 100f, 30f), "UnStealth"))
					{
						animator.SetBool("Stealth", value: false);
						isStealth = false;
					}
					if (warrior == Warrior.Ninja && isStealth && !dead && !weaponSheathed)
					{
						if (!isWall)
						{
							if (GUI.Button(new Rect(140f, 350f, 100f, 30f), "Wall On"))
							{
								animator.applyRootMotion = true;
								animator.SetBool("Stealth-Wall", value: true);
								isWall = true;
							}
						}
						else if (GUI.Button(new Rect(140f, 350f, 100f, 30f), "Wall Off"))
						{
							animator.SetBool("Stealth-Wall", value: false);
							isWall = false;
							StartCoroutine(_LockMovementAndAttack(0.7f));
						}
					}
				}
			}
		}
		if (dead && GUI.Button(new Rect(30f, 270f, 100f, 30f), "Revive"))
		{
			StartCoroutine(_Revive());
		}
	}
}
public class RandomMaterial : MonoBehaviour
{
	public Renderer targetRenderer;

	public Material[] materials;

	public void Start()
	{
		ChangeMaterial();
	}

	public void ChangeMaterial()
	{
		targetRenderer.sharedMaterial = materials[UnityEngine.Random.Range(0, materials.Length)];
	}
}
public class UnluckDistanceDisabler : MonoBehaviour
{
	public int _distanceDisable = 1000;

	public Transform _distanceFrom;

	public bool _distanceFromMainCam;

	public float _disableCheckInterval = 10f;

	public float _enableCheckInterval = 1f;

	public bool _disableOnStart;

	public void Start()
	{
		if (_distanceFromMainCam)
		{
			_distanceFrom = Camera.main.transform;
		}
		InvokeRepeating("CheckDisable", _disableCheckInterval + UnityEngine.Random.value * _disableCheckInterval, _disableCheckInterval);
		InvokeRepeating("CheckEnable", _enableCheckInterval + UnityEngine.Random.value * _enableCheckInterval, _enableCheckInterval);
		Invoke("DisableOnStart", 0.01f);
	}

	public void DisableOnStart()
	{
		if (_disableOnStart)
		{
			base.gameObject.SetActive(value: false);
		}
	}

	public void CheckDisable()
	{
		if (base.gameObject.activeInHierarchy && (base.transform.position - _distanceFrom.position).sqrMagnitude > (float)(_distanceDisable * _distanceDisable))
		{
			base.gameObject.SetActive(value: false);
		}
	}

	public void CheckEnable()
	{
		if (!base.gameObject.activeInHierarchy && (base.transform.position - _distanceFrom.position).sqrMagnitude < (float)(_distanceDisable * _distanceDisable))
		{
			base.gameObject.SetActive(value: true);
		}
	}
}
public class LookAtCamera : MonoBehaviour
{
	public Camera lookAtCamera;

	public bool lookOnlyOnAwake;

	public void Start()
	{
		if (lookAtCamera == null)
		{
			lookAtCamera = Camera.main;
		}
		if (lookOnlyOnAwake)
		{
			LookCam();
		}
	}

	public void Update()
	{
		if (!lookOnlyOnAwake)
		{
			LookCam();
		}
	}

	public void LookCam()
	{
		base.transform.LookAt(lookAtCamera.transform);
	}
}
[AddComponentMenu("Camera-Control/Smooth Mouse Orbit - Unluck Software")]
public class SmoothCameraOrbit : MonoBehaviour
{
	public Transform target;

	public Vector3 targetOffset;

	public float distance = 5f;

	public float maxDistance = 20f;

	public float minDistance = 0.6f;

	public float xSpeed = 200f;

	public float ySpeed = 200f;

	public int yMinLimit = -80;

	public int yMaxLimit = 80;

	public int zoomRate = 40;

	public float panSpeed = 0.3f;

	public float zoomDampening = 5f;

	public float autoRotate = 1f;

	public float autoRotateSpeed = 0.1f;

	private float xDeg;

	private float yDeg;

	private float currentDistance;

	private float desiredDistance;

	private Quaternion currentRotation;

	private Quaternion desiredRotation;

	private Quaternion rotation;

	private Vector3 position;

	private float idleTimer;

	private float idleSmooth;

	private void Start()
	{
		Init();
	}

	private void OnEnable()
	{
		Init();
	}

	public void Init()
	{
		if (!target)
		{
			GameObject gameObject = new GameObject("Cam Target");
			gameObject.transform.position = base.transform.position + base.transform.forward * distance;
			target = gameObject.transform;
		}
		currentDistance = distance;
		desiredDistance = distance;
		position = base.transform.position;
		rotation = base.transform.rotation;
		currentRotation = base.transform.rotation;
		desiredRotation = base.transform.rotation;
		xDeg = Vector3.Angle(Vector3.right, base.transform.right);
		yDeg = Vector3.Angle(Vector3.up, base.transform.up);
		position = target.position - (rotation * Vector3.forward * currentDistance + targetOffset);
	}

	private void LateUpdate()
	{
		if (Input.GetMouseButton(2) && Input.GetKey(KeyCode.LeftAlt) && Input.GetKey(KeyCode.LeftControl))
		{
			desiredDistance -= Input.GetAxis("Mouse Y") * 0.02f * (float)zoomRate * 0.125f * Mathf.Abs(desiredDistance);
		}
		else if (Input.GetMouseButton(0))
		{
			xDeg += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
			yDeg -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
			yDeg = ClampAngle(yDeg, yMinLimit, yMaxLimit);
			desiredRotation = Quaternion.Euler(yDeg, xDeg, 0f);
			currentRotation = base.transform.rotation;
			rotation = Quaternion.Lerp(currentRotation, desiredRotation, 0.02f * zoomDampening);
			base.transform.rotation = rotation;
			idleTimer = 0f;
			idleSmooth = 0f;
		}
		else
		{
			idleTimer += 0.02f;
			if (idleTimer > autoRotate && autoRotate > 0f)
			{
				idleSmooth += (0.02f + idleSmooth) * 0.005f;
				idleSmooth = Mathf.Clamp(idleSmooth, 0f, 1f);
				xDeg += xSpeed * Time.deltaTime * idleSmooth * autoRotateSpeed;
			}
			yDeg = ClampAngle(yDeg, yMinLimit, yMaxLimit);
			desiredRotation = Quaternion.Euler(yDeg, xDeg, 0f);
			currentRotation = base.transform.rotation;
			rotation = Quaternion.Lerp(currentRotation, desiredRotation, 0.02f * zoomDampening * 2f);
			base.transform.rotation = rotation;
		}
		desiredDistance -= Input.GetAxis("Mouse ScrollWheel") * 0.02f * (float)zoomRate * Mathf.Abs(desiredDistance);
		desiredDistance = Mathf.Clamp(desiredDistance, minDistance, maxDistance);
		currentDistance = Mathf.Lerp(currentDistance, desiredDistance, 0.02f * zoomDampening);
		position = target.position - (rotation * Vector3.forward * currentDistance + targetOffset);
		base.transform.position = position;
	}

	private static float ClampAngle(float angle, float min, float max)
	{
		if (angle < -360f)
		{
			angle += 360f;
		}
		if (angle > 360f)
		{
			angle -= 360f;
		}
		return Mathf.Clamp(angle, min, max);
	}
}
public class FlockChild : MonoBehaviour
{
	[HideInInspector]
	public FlockController _spawner;

	[HideInInspector]
	public Vector3 _wayPoint;

	public float _speed;

	[HideInInspector]
	public bool _dived = true;

	[HideInInspector]
	public float _stuckCounter;

	[HideInInspector]
	public float _damping;

	[HideInInspector]
	public bool _soar = true;

	[HideInInspector]
	public bool _landing;

	[HideInInspector]
	public float _targetSpeed;

	[HideInInspector]
	public bool _move = true;

	public GameObject _model;

	public Transform _modelT;

	[HideInInspector]
	public float _avoidValue;

	[HideInInspector]
	public float _avoidDistance;

	private float _soarTimer;

	private bool _instantiated;

	private static int _updateNextSeed;

	private int _updateSeed = -1;

	[HideInInspector]
	public bool _avoid = true;

	public Transform _thisT;

	public Vector3 _landingPosOffset;

	public void Start()
	{
		FindRequiredComponents();
		Wander(0f);
		SetRandomScale();
		_thisT.position = findWaypoint();
		RandomizeStartAnimationFrame();
		InitAvoidanceValues();
		_speed = _spawner._minSpeed;
		_spawner._activeChildren += 1f;
		_instantiated = true;
		if (_spawner._updateDivisor > 1)
		{
			int num = _spawner._updateDivisor - 1;
			_updateNextSeed++;
			_updateSeed = _updateNextSeed;
			_updateNextSeed %= num;
		}
	}

	public void Update()
	{
		if (_spawner._updateDivisor <= 1 || _spawner._updateCounter == _updateSeed)
		{
			SoarTimeLimit();
			CheckForDistanceToWaypoint();
			RotationBasedOnWaypointOrAvoidance();
			LimitRotationOfModel();
		}
	}

	public void OnDisable()
	{
		CancelInvoke();
		_spawner._activeChildren -= 1f;
	}

	public void OnEnable()
	{
		if (_instantiated)
		{
			_spawner._activeChildren += 1f;
			if (_landing)
			{
				_model.GetComponent<Animation>().Play(_spawner._idleAnimation);
			}
			else
			{
				_model.GetComponent<Animation>().Play(_spawner._flapAnimation);
			}
		}
	}

	public void FindRequiredComponents()
	{
		if (_thisT == null)
		{
			_thisT = base.transform;
		}
		if (_model == null)
		{
			_model = _thisT.Find("Model").gameObject;
		}
		if (_modelT == null)
		{
			_modelT = _model.transform;
		}
	}

	public void RandomizeStartAnimationFrame()
	{
		foreach (AnimationState item in _model.GetComponent<Animation>())
		{
			item.time = UnityEngine.Random.value * item.length;
		}
	}

	public void InitAvoidanceValues()
	{
		_avoidValue = UnityEngine.Random.Range(0.3f, 0.1f);
		if (_spawner._birdAvoidDistanceMax != _spawner._birdAvoidDistanceMin)
		{
			_avoidDistance = UnityEngine.Random.Range(_spawner._birdAvoidDistanceMax, _spawner._birdAvoidDistanceMin);
		}
		else
		{
			_avoidDistance = _spawner._birdAvoidDistanceMin;
		}
	}

	public void SetRandomScale()
	{
		float num = UnityEngine.Random.Range(_spawner._minScale, _spawner._maxScale);
		_thisT.localScale = new Vector3(num, num, num);
	}

	public void SoarTimeLimit()
	{
		if (_soar && _spawner._soarMaxTime > 0f)
		{
			if (_soarTimer > _spawner._soarMaxTime)
			{
				Flap();
				_soarTimer = 0f;
			}
			else
			{
				_soarTimer += _spawner._newDelta;
			}
		}
	}

	public void CheckForDistanceToWaypoint()
	{
		if (!_landing && (_thisT.position - _wayPoint).magnitude < _spawner._waypointDistance + _stuckCounter)
		{
			Wander(0f);
			_stuckCounter = 0f;
		}
		else if (!_landing)
		{
			_stuckCounter += _spawner._newDelta;
		}
		else
		{
			_stuckCounter = 0f;
		}
	}

	public void RotationBasedOnWaypointOrAvoidance()
	{
		Vector3 vector = _wayPoint - _thisT.position;
		if (_targetSpeed > -1f && vector != Vector3.zero)
		{
			Quaternion b = Quaternion.LookRotation(vector);
			_thisT.rotation = Quaternion.Slerp(_thisT.rotation, b, _spawner._newDelta * _damping);
		}
		if (_spawner._childTriggerPos && (_thisT.position - _spawner._posBuffer).magnitude < 1f)
		{
			_spawner.SetFlockRandomPosition();
		}
		_speed = Mathf.Lerp(_speed, _targetSpeed, _spawner._newDelta * 2.5f);
		if (_move)
		{
			_thisT.position += _thisT.forward * _speed * _spawner._newDelta;
			if (_avoid && _spawner._birdAvoid)
			{
				Avoidance();
			}
		}
	}

	public bool Avoidance()
	{
		RaycastHit hitInfo = default(RaycastHit);
		Vector3 forward = _modelT.forward;
		bool result = false;
		Quaternion identity = Quaternion.identity;
		Vector3 zero = Vector3.zero;
		Vector3 zero2 = Vector3.zero;
		zero2 = _thisT.position;
		identity = _thisT.rotation;
		zero = _thisT.rotation.eulerAngles;
		if (Physics.Raycast(_thisT.position, forward + _modelT.right * _avoidValue, out hitInfo, _avoidDistance, _spawner._avoidanceMask))
		{
			zero.y -= (float)_spawner._birdAvoidHorizontalForce * _spawner._newDelta * _damping;
			identity.eulerAngles = zero;
			_thisT.rotation = identity;
			result = true;
		}
		else if (Physics.Raycast(_thisT.position, forward + _modelT.right * (0f - _avoidValue), out hitInfo, _avoidDistance, _spawner._avoidanceMask))
		{
			zero.y += (float)_spawner._birdAvoidHorizontalForce * _spawner._newDelta * _damping;
			identity.eulerAngles = zero;
			_thisT.rotation = identity;
			result = true;
		}
		if (_spawner._birdAvoidDown && !_landing && Physics.Raycast(_thisT.position, -Vector3.up, out hitInfo, _avoidDistance, _spawner._avoidanceMask))
		{
			zero.x -= (float)_spawner._birdAvoidVerticalForce * _spawner._newDelta * _damping;
			identity.eulerAngles = zero;
			_thisT.rotation = identity;
			zero2.y += (float)_spawner._birdAvoidVerticalForce * _spawner._newDelta * 0.01f;
			_thisT.position = zero2;
			result = true;
		}
		else if (_spawner._birdAvoidUp && !_landing && Physics.Raycast(_thisT.position, Vector3.up, out hitInfo, _avoidDistance, _spawner._avoidanceMask))
		{
			zero.x += (float)_spawner._birdAvoidVerticalForce * _spawner._newDelta * _damping;
			identity.eulerAngles = zero;
			_thisT.rotation = identity;
			zero2.y -= (float)_spawner._birdAvoidVerticalForce * _spawner._newDelta * 0.01f;
			_thisT.position = zero2;
			result = true;
		}
		return result;
	}

	public void LimitRotationOfModel()
	{
		Quaternion identity = Quaternion.identity;
		Vector3 zero = Vector3.zero;
		identity = _modelT.localRotation;
		zero = identity.eulerAngles;
		if ((((_soar && _spawner._flatSoar) || (_spawner._flatFly && !_soar)) && _wayPoint.y > _thisT.position.y) || _landing)
		{
			zero.x = Mathf.LerpAngle(_modelT.localEulerAngles.x, 0f - _thisT.localEulerAngles.x, _spawner._newDelta * 1.75f);
			identity.eulerAngles = zero;
			_modelT.localRotation = identity;
		}
		else
		{
			zero.x = Mathf.LerpAngle(_modelT.localEulerAngles.x, 0f, _spawner._newDelta * 1.75f);
			identity.eulerAngles = zero;
			_modelT.localRotation = identity;
		}
	}

	public void Wander(float delay)
	{
		if (!_landing)
		{
			_damping = UnityEngine.Random.Range(_spawner._minDamping, _spawner._maxDamping);
			_targetSpeed = UnityEngine.Random.Range(_spawner._minSpeed, _spawner._maxSpeed);
			Invoke("SetRandomMode", delay);
		}
	}

	public void SetRandomMode()
	{
		CancelInvoke("SetRandomMode");
		if (!_dived && UnityEngine.Random.value < _spawner._soarFrequency)
		{
			Soar();
		}
		else if (!_dived && UnityEngine.Random.value < _spawner._diveFrequency)
		{
			Dive();
		}
		else
		{
			Flap();
		}
	}

	public void Flap()
	{
		if (_move)
		{
			if (_model != null)
			{
				_model.GetComponent<Animation>().CrossFade(_spawner._flapAnimation, 0.5f);
			}
			_soar = false;
			animationSpeed();
			_wayPoint = findWaypoint();
			_dived = false;
		}
	}

	public Vector3 findWaypoint()
	{
		Vector3 zero = Vector3.zero;
		zero.x = UnityEngine.Random.Range(0f - _spawner._spawnSphere, _spawner._spawnSphere) + _spawner._posBuffer.x;
		zero.z = UnityEngine.Random.Range(0f - _spawner._spawnSphereDepth, _spawner._spawnSphereDepth) + _spawner._posBuffer.z;
		zero.y = UnityEngine.Random.Range(0f - _spawner._spawnSphereHeight, _spawner._spawnSphereHeight) + _spawner._posBuffer.y;
		return zero;
	}

	public void Soar()
	{
		if (_move)
		{
			_model.GetComponent<Animation>().CrossFade(_spawner._soarAnimation, 1.5f);
			_wayPoint = findWaypoint();
			_soar = true;
		}
	}

	public void Dive()
	{
		if (_spawner._soarAnimation != null)
		{
			_model.GetComponent<Animation>().CrossFade(_spawner._soarAnimation, 1.5f);
		}
		else
		{
			foreach (AnimationState item in _model.GetComponent<Animation>())
			{
				if (_thisT.position.y < _wayPoint.y + 25f)
				{
					item.speed = 0.1f;
				}
			}
		}
		_wayPoint = findWaypoint();
		_wayPoint.y -= _spawner._diveValue;
		_dived = true;
	}

	public void animationSpeed()
	{
		foreach (AnimationState item in _model.GetComponent<Animation>())
		{
			if (!_dived && !_landing)
			{
				item.speed = UnityEngine.Random.Range(_spawner._minAnimationSpeed, _spawner._maxAnimationSpeed);
			}
			else
			{
				item.speed = _spawner._maxAnimationSpeed;
			}
		}
	}
}
[RequireComponent(typeof(AudioSource))]
public class FlockChildSound : MonoBehaviour
{
	public AudioClip[] _idleSounds;

	public float _idleSoundRandomChance = 0.05f;

	public AudioClip[] _flightSounds;

	public float _flightSoundRandomChance = 0.05f;

	public AudioClip[] _scareSounds;

	public float _pitchMin = 0.85f;

	public float _pitchMax = 1f;

	public float _volumeMin = 0.6f;

	public float _volumeMax = 0.8f;

	private FlockChild _flockChild;

	private AudioSource _audio;

	private bool _hasLanded;

	public void Start()
	{
		_flockChild = GetComponent<FlockChild>();
		_audio = GetComponent<AudioSource>();
		InvokeRepeating("PlayRandomSound", UnityEngine.Random.value + 1f, 1f);
		if (_scareSounds.Length != 0)
		{
			InvokeRepeating("ScareSound", 1f, 0.01f);
		}
	}

	public void PlayRandomSound()
	{
		if (base.gameObject.activeInHierarchy)
		{
			if (!_audio.isPlaying && _flightSounds.Length != 0 && _flightSoundRandomChance > UnityEngine.Random.value && !_flockChild._landing)
			{
				_audio.clip = _flightSounds[UnityEngine.Random.Range(0, _flightSounds.Length)];
				_audio.pitch = UnityEngine.Random.Range(_pitchMin, _pitchMax);
				_audio.volume = UnityEngine.Random.Range(_volumeMin, _volumeMax);
				_audio.Play();
			}
			else if (!_audio.isPlaying && _idleSounds.Length != 0 && _idleSoundRandomChance > UnityEngine.Random.value && _flockChild._landing)
			{
				_audio.clip = _idleSounds[UnityEngine.Random.Range(0, _idleSounds.Length)];
				_audio.pitch = UnityEngine.Random.Range(_pitchMin, _pitchMax);
				_audio.volume = UnityEngine.Random.Range(_volumeMin, _volumeMax);
				_audio.Play();
				_hasLanded = true;
			}
		}
	}

	public void ScareSound()
	{
		if (base.gameObject.activeInHierarchy && _hasLanded && !_flockChild._landing && _idleSoundRandomChance * 2f > UnityEngine.Random.value)
		{
			_audio.clip = _scareSounds[UnityEngine.Random.Range(0, _scareSounds.Length)];
			_audio.volume = UnityEngine.Random.Range(_volumeMin, _volumeMax);
			_audio.PlayDelayed(UnityEngine.Random.value * 0.2f);
			_hasLanded = false;
		}
	}
}
public class FlockController : MonoBehaviour
{
	public FlockChild _childPrefab;

	public int _childAmount = 250;

	public bool _slowSpawn;

	public float _spawnSphere = 3f;

	public float _spawnSphereHeight = 3f;

	public float _spawnSphereDepth = -1f;

	public float _minSpeed = 6f;

	public float _maxSpeed = 10f;

	public float _minScale = 0.7f;

	public float _maxScale = 1f;

	public float _soarFrequency;

	public string _soarAnimation = "Soar";

	public string _flapAnimation = "Flap";

	public string _idleAnimation = "Idle";

	public float _diveValue = 7f;

	public float _diveFrequency = 0.5f;

	public float _minDamping = 1f;

	public float _maxDamping = 2f;

	public float _waypointDistance = 1f;

	public float _minAnimationSpeed = 2f;

	public float _maxAnimationSpeed = 4f;

	public float _randomPositionTimer = 10f;

	public float _positionSphere = 25f;

	public float _positionSphereHeight = 25f;

	public float _positionSphereDepth = -1f;

	public bool _childTriggerPos;

	public bool _forceChildWaypoints;

	public float _forcedRandomDelay = 1.5f;

	public bool _flatFly;

	public bool _flatSoar;

	public bool _birdAvoid;

	public int _birdAvoidHorizontalForce = 1000;

	public bool _birdAvoidDown;

	public bool _birdAvoidUp;

	public int _birdAvoidVerticalForce = 300;

	public float _birdAvoidDistanceMax = 4.5f;

	public float _birdAvoidDistanceMin = 5f;

	public float _soarMaxTime;

	public LayerMask _avoidanceMask = -1;

	public List<FlockChild> _roamers;

	public Vector3 _posBuffer;

	public int _updateDivisor = 1;

	public float _newDelta;

	public int _updateCounter;

	public float _activeChildren;

	public bool _groupChildToNewTransform;

	public Transform _groupTransform;

	public string _groupName = "";

	public bool _groupChildToFlock;

	public Vector3 _startPosOffset;

	public Transform _thisT;

	public void Start()
	{
		_thisT = base.transform;
		if (_positionSphereDepth == -1f)
		{
			_positionSphereDepth = _positionSphere;
		}
		if (_spawnSphereDepth == -1f)
		{
			_spawnSphereDepth = _spawnSphere;
		}
		_posBuffer = _thisT.position + _startPosOffset;
		if (!_slowSpawn)
		{
			AddChild(_childAmount);
		}
		if (_randomPositionTimer > 0f)
		{
			InvokeRepeating("SetFlockRandomPosition", _randomPositionTimer, _randomPositionTimer);
		}
	}

	public void AddChild(int amount)
	{
		if (_groupChildToNewTransform)
		{
			InstantiateGroup();
		}
		for (int i = 0; i < amount; i++)
		{
			FlockChild flockChild = UnityEngine.Object.Instantiate(_childPrefab);
			flockChild._spawner = this;
			_roamers.Add(flockChild);
			AddChildToParent(flockChild.transform);
		}
	}

	public void AddChildToParent(Transform obj)
	{
		if (_groupChildToFlock)
		{
			obj.parent = base.transform;
		}
		else if (_groupChildToNewTransform)
		{
			obj.parent = _groupTransform;
		}
	}

	public void RemoveChild(int amount)
	{
		for (int i = 0; i < amount; i++)
		{
			FlockChild flockChild = _roamers[_roamers.Count - 1];
			_roamers.RemoveAt(_roamers.Count - 1);
			UnityEngine.Object.Destroy(flockChild.gameObject);
		}
	}

	public void Update()
	{
		if (_activeChildren > 0f)
		{
			if (_updateDivisor > 1)
			{
				_updateCounter++;
				_updateCounter %= _updateDivisor;
				_newDelta = Time.deltaTime * (float)_updateDivisor;
			}
			else
			{
				_newDelta = Time.deltaTime;
			}
		}
		UpdateChildAmount();
	}

	public void InstantiateGroup()
	{
		if (!(_groupTransform != null))
		{
			GameObject gameObject = new GameObject();
			_groupTransform = gameObject.transform;
			_groupTransform.position = _thisT.position;
			if (_groupName != "")
			{
				gameObject.name = _groupName;
			}
			else
			{
				gameObject.name = _thisT.name + " Fish Container";
			}
		}
	}

	public void UpdateChildAmount()
	{
		if (_childAmount >= 0 && _childAmount < _roamers.Count)
		{
			RemoveChild(1);
		}
		else if (_childAmount > _roamers.Count)
		{
			AddChild(1);
		}
	}

	public void OnDrawGizmos()
	{
		if (_thisT == null)
		{
			_thisT = base.transform;
		}
		if (!Application.isPlaying && _posBuffer != _thisT.position + _startPosOffset)
		{
			_posBuffer = _thisT.position + _startPosOffset;
		}
		if (_positionSphereDepth == -1f)
		{
			_positionSphereDepth = _positionSphere;
		}
		if (_spawnSphereDepth == -1f)
		{
			_spawnSphereDepth = _spawnSphere;
		}
		Gizmos.color = Color.blue;
		Gizmos.DrawWireCube(_posBuffer, new Vector3(_spawnSphere * 2f, _spawnSphereHeight * 2f, _spawnSphereDepth * 2f));
		Gizmos.color = Color.cyan;
		Gizmos.DrawWireCube(_thisT.position, new Vector3(_positionSphere * 2f + _spawnSphere * 2f, _positionSphereHeight * 2f + _spawnSphereHeight * 2f, _positionSphereDepth * 2f + _spawnSphereDepth * 2f));
	}

	public void SetFlockRandomPosition()
	{
		Vector3 zero = Vector3.zero;
		zero.x = UnityEngine.Random.Range(0f - _positionSphere, _positionSphere) + _thisT.position.x;
		zero.z = UnityEngine.Random.Range(0f - _positionSphereDepth, _positionSphereDepth) + _thisT.position.z;
		zero.y = UnityEngine.Random.Range(0f - _positionSphereHeight, _positionSphereHeight) + _thisT.position.y;
		_posBuffer = zero;
		if (_forceChildWaypoints)
		{
			for (int i = 0; i < _roamers.Count; i++)
			{
				_roamers[i].Wander(UnityEngine.Random.value * _forcedRandomDelay);
			}
		}
	}

	public void destroyBirds()
	{
		for (int i = 0; i < _roamers.Count; i++)
		{
			UnityEngine.Object.Destroy(_roamers[i].gameObject);
		}
		_childAmount = 0;
		_roamers.Clear();
	}
}
public class FlockScare : MonoBehaviour
{
	public LandingSpotController[] landingSpotControllers;

	public float scareInterval = 0.1f;

	public float distanceToScare = 2f;

	public int checkEveryNthLandingSpot = 1;

	public int InvokeAmounts = 1;

	private int lsc;

	private int ls;

	private LandingSpotController currentController;

	private void CheckProximityToLandingSpots()
	{
		IterateLandingSpots();
		if (currentController._activeLandingSpots > 0 && CheckDistanceToLandingSpot(landingSpotControllers[lsc]))
		{
			landingSpotControllers[lsc].ScareAll();
		}
		Invoke("CheckProximityToLandingSpots", scareInterval);
	}

	private void IterateLandingSpots()
	{
		ls += checkEveryNthLandingSpot;
		currentController = landingSpotControllers[lsc];
		int childCount = currentController.transform.childCount;
		if (ls > childCount - 1)
		{
			ls -= childCount;
			if (lsc < landingSpotControllers.Length - 1)
			{
				lsc++;
			}
			else
			{
				lsc = 0;
			}
		}
	}

	private bool CheckDistanceToLandingSpot(LandingSpotController lc)
	{
		Transform child = lc.transform.GetChild(ls);
		if (child.GetComponent<LandingSpot>().landingChild != null && (child.position - base.transform.position).sqrMagnitude < distanceToScare * distanceToScare)
		{
			return true;
		}
		return false;
	}

	private void Invoker()
	{
		for (int i = 0; i < InvokeAmounts; i++)
		{
			float num = scareInterval / (float)InvokeAmounts * (float)i;
			Invoke("CheckProximityToLandingSpots", scareInterval + num);
		}
	}

	private void OnEnable()
	{
		CancelInvoke("CheckProximityToLandingSpots");
		if (landingSpotControllers.Length != 0)
		{
			Invoker();
		}
	}

	private void OnDisable()
	{
		CancelInvoke("CheckProximityToLandingSpots");
	}
}
public class FlockWaypointTrigger : MonoBehaviour
{
	public float _timer = 1f;

	public FlockChild _flockChild;

	public void Start()
	{
		if (_flockChild == null)
		{
			_flockChild = base.transform.parent.GetComponent<FlockChild>();
		}
		float num = UnityEngine.Random.Range(_timer, _timer * 3f);
		InvokeRepeating("Trigger", num, num);
	}

	public void Trigger()
	{
		_flockChild.Wander(0f);
	}
}
public class LandingButtons : MonoBehaviour
{
	public LandingSpotController _landingSpotController;

	public FlockController _flockController;

	public float hSliderValue = 250f;

	public void OnGUI()
	{
		GUI.Label(new Rect(20f, 20f, 125f, 18f), "Landing Spots: " + _landingSpotController.transform.childCount);
		if (GUI.Button(new Rect(20f, 40f, 125f, 18f), "Scare All"))
		{
			_landingSpotController.ScareAll();
		}
		if (GUI.Button(new Rect(20f, 60f, 125f, 18f), "Land In Reach"))
		{
			_landingSpotController.LandAll();
		}
		if (GUI.Button(new Rect(20f, 80f, 125f, 18f), "Land Instant"))
		{
			StartCoroutine(_landingSpotController.InstantLand(0.01f));
		}
		if (GUI.Button(new Rect(20f, 100f, 125f, 18f), "Destroy"))
		{
			_flockController.destroyBirds();
		}
		GUI.Label(new Rect(20f, 120f, 125f, 18f), "Bird Amount: " + _flockController._childAmount);
		_flockController._childAmount = (int)GUI.HorizontalSlider(new Rect(20f, 140f, 125f, 18f), _flockController._childAmount, 0f, 250f);
	}
}
public class LandingSpot : MonoBehaviour
{
	[HideInInspector]
	public FlockChild landingChild;

	[HideInInspector]
	public bool landing;

	private int lerpCounter;

	[HideInInspector]
	public LandingSpotController _controller;

	private bool _idle;

	public Transform _thisT;

	public bool _gotcha;

	public void Start()
	{
		if (_thisT == null)
		{
			_thisT = base.transform;
		}
		if (_controller == null)
		{
			_controller = _thisT.parent.GetComponent<LandingSpotController>();
		}
		if (_controller._autoCatchDelay.x > 0f)
		{
			StartCoroutine(GetFlockChild(_controller._autoCatchDelay.x, _controller._autoCatchDelay.y));
		}
	}

	public void OnDrawGizmos()
	{
		if (_thisT == null)
		{
			_thisT = base.transform;
		}
		if (_controller == null)
		{
			_controller = _thisT.parent.GetComponent<LandingSpotController>();
		}
		Gizmos.color = Color.yellow;
		if (landingChild != null && landing)
		{
			Gizmos.DrawLine(_thisT.position, landingChild._thisT.position);
		}
		if (_thisT.rotation.eulerAngles.x != 0f || _thisT.rotation.eulerAngles.z != 0f)
		{
			_thisT.eulerAngles = new Vector3(0f, _thisT.eulerAngles.y, 0f);
		}
		Gizmos.DrawCube(new Vector3(_thisT.position.x, _thisT.position.y, _thisT.position.z), Vector3.one * _controller._gizmoSize);
		Gizmos.DrawCube(_thisT.position + _thisT.forward * _controller._gizmoSize, Vector3.one * _controller._gizmoSize * 0.5f);
		Gizmos.color = new Color(1f, 1f, 0f, 0.05f);
		Gizmos.DrawWireSphere(_thisT.position, _controller._maxBirdDistance);
	}

	public void LateUpdate()
	{
		if (landingChild == null)
		{
			_gotcha = false;
			_idle = false;
			lerpCounter = 0;
			return;
		}
		if (_gotcha)
		{
			landingChild.transform.position = _thisT.position + landingChild._landingPosOffset;
			RotateBird();
			return;
		}
		if (_controller._flock.gameObject.activeInHierarchy && landing && landingChild != null)
		{
			if (!landingChild.gameObject.activeInHierarchy)
			{
				Invoke("ReleaseFlockChild", 0f);
			}
			float num = Vector3.Distance(landingChild._thisT.position, _thisT.position + landingChild._landingPosOffset);
			if (num < 5f && num > 0.5f)
			{
				if (_controller._soarLand)
				{
					landingChild._model.GetComponent<Animation>().CrossFade(landingChild._spawner._soarAnimation, 0.5f);
					if (num < 2f)
					{
						landingChild._model.GetComponent<Animation>().CrossFade(landingChild._spawner._flapAnimation, 0.5f);
					}
				}
				landingChild._targetSpeed = landingChild._spawner._maxSpeed * _controller._landingSpeedModifier;
				landingChild._wayPoint = _thisT.position + landingChild._landingPosOffset;
				landingChild._damping = _controller._landingTurnSpeedModifier;
				landingChild._avoid = false;
			}
			else if (num <= 0.5f)
			{
				landingChild._wayPoint = _thisT.position + landingChild._landingPosOffset;
				if (num < _controller._snapLandDistance && !_idle)
				{
					_idle = true;
					landingChild._model.GetComponent<Animation>().CrossFade(landingChild._spawner._idleAnimation, 0.55f);
				}
				if (num > _controller._snapLandDistance)
				{
					landingChild._targetSpeed = landingChild._spawner._minSpeed * _controller._landingSpeedModifier;
					landingChild._thisT.position += (_thisT.position + landingChild._landingPosOffset - landingChild._thisT.position) * Time.deltaTime * landingChild._speed * _controller._landingSpeedModifier * 2f;
				}
				else
				{
					_gotcha = true;
				}
				landingChild._move = false;
				RotateBird();
			}
			else
			{
				landingChild._wayPoint = _thisT.position + landingChild._landingPosOffset;
			}
			landingChild._damping += 0.01f;
		}
		StraightenBird();
	}

	public void StraightenBird()
	{
		if (landingChild._thisT.eulerAngles.x != 0f)
		{
			Vector3 eulerAngles = landingChild._thisT.eulerAngles;
			eulerAngles.z = 0f;
			landingChild._thisT.eulerAngles = eulerAngles;
		}
	}

	public void RotateBird()
	{
		if (!_controller._randomRotate || !_idle)
		{
			lerpCounter++;
			Quaternion rotation = landingChild._thisT.rotation;
			Vector3 eulerAngles = rotation.eulerAngles;
			eulerAngles.y = Mathf.LerpAngle(landingChild._thisT.rotation.eulerAngles.y, _thisT.rotation.eulerAngles.y, (float)lerpCounter * Time.deltaTime * _controller._landedRotateSpeed);
			rotation.eulerAngles = eulerAngles;
			landingChild._thisT.rotation = rotation;
		}
	}

	public IEnumerator GetFlockChild(float minDelay, float maxDelay)
	{
		yield return new WaitForSeconds(UnityEngine.Random.Range(minDelay, maxDelay));
		if (!_controller._flock.gameObject.activeInHierarchy || !(landingChild == null))
		{
			yield break;
		}
		FlockChild flockChild = null;
		for (int i = 0; i < _controller._flock._roamers.Count; i++)
		{
			FlockChild flockChild2 = _controller._flock._roamers[i];
			if (flockChild2._landing || flockChild2._dived)
			{
				continue;
			}
			if (!_controller._onlyBirdsAbove)
			{
				if (flockChild == null && _controller._maxBirdDistance > Vector3.Distance(flockChild2._thisT.position, _thisT.position) && _controller._minBirdDistance < Vector3.Distance(flockChild2._thisT.position, _thisT.position))
				{
					flockChild = flockChild2;
					if (!_controller._takeClosest)
					{
						break;
					}
				}
				else if (flockChild != null && Vector3.Distance(flockChild._thisT.position, _thisT.position) > Vector3.Distance(flockChild2._thisT.position, _thisT.position))
				{
					flockChild = flockChild2;
				}
			}
			else if (flockChild == null && flockChild2._thisT.position.y > _thisT.position.y && _controller._maxBirdDistance > Vector3.Distance(flockChild2._thisT.position, _thisT.position) && _controller._minBirdDistance < Vector3.Distance(flockChild2._thisT.position, _thisT.position))
			{
				flockChild = flockChild2;
				if (!_controller._takeClosest)
				{
					break;
				}
			}
			else if (flockChild != null && flockChild2._thisT.position.y > _thisT.position.y && Vector3.Distance(flockChild._thisT.position, _thisT.position) > Vector3.Distance(flockChild2._thisT.position, _thisT.position))
			{
				flockChild = flockChild2;
			}
		}
		if (flockChild != null)
		{
			landingChild = flockChild;
			landing = true;
			landingChild._landing = true;
			if (_controller._autoDismountDelay.x > 0f)
			{
				Invoke("ReleaseFlockChild", UnityEngine.Random.Range(_controller._autoDismountDelay.x, _controller._autoDismountDelay.y));
			}
			_controller._activeLandingSpots++;
		}
		else if (_controller._autoCatchDelay.x > 0f)
		{
			StartCoroutine(GetFlockChild(_controller._autoCatchDelay.x, _controller._autoCatchDelay.y));
		}
	}

	public void InstantLand()
	{
		if (!_controller._flock.gameObject.activeInHierarchy || !(landingChild == null))
		{
			return;
		}
		FlockChild flockChild = null;
		for (int i = 0; i < _controller._flock._roamers.Count; i++)
		{
			FlockChild flockChild2 = _controller._flock._roamers[i];
			if (!flockChild2._landing && !flockChild2._dived)
			{
				flockChild = flockChild2;
			}
		}
		if (flockChild != null)
		{
			landingChild = flockChild;
			landing = true;
			_controller._activeLandingSpots++;
			landingChild._landing = true;
			landingChild._thisT.position = _thisT.position + landingChild._landingPosOffset;
			landingChild._model.GetComponent<Animation>().Play(landingChild._spawner._idleAnimation);
			landingChild._thisT.Rotate(Vector3.up, UnityEngine.Random.Range(0f, 360f));
			if (_controller._autoDismountDelay.x > 0f)
			{
				Invoke("ReleaseFlockChild", UnityEngine.Random.Range(_controller._autoDismountDelay.x, _controller._autoDismountDelay.y));
			}
		}
		else if (_controller._autoCatchDelay.x > 0f)
		{
			StartCoroutine(GetFlockChild(_controller._autoCatchDelay.x, _controller._autoCatchDelay.y));
		}
	}

	public void ReleaseFlockChild()
	{
		if (_controller._flock.gameObject.activeInHierarchy && landingChild != null)
		{
			_gotcha = false;
			lerpCounter = 0;
			if (_controller._featherPS != null)
			{
				_controller._featherPS.position = landingChild._thisT.position;
				_controller._featherPS.GetComponent<ParticleSystem>().Emit(UnityEngine.Random.Range(0, 3));
			}
			landing = false;
			_idle = false;
			landingChild._avoid = true;
			landingChild._damping = landingChild._spawner._maxDamping;
			landingChild._model.GetComponent<Animation>().CrossFade(landingChild._spawner._flapAnimation, 0.2f);
			landingChild._dived = true;
			landingChild._speed = 0f;
			landingChild._move = true;
			landingChild._landing = false;
			landingChild.Flap();
			landingChild._wayPoint = new Vector3(landingChild._wayPoint.x, _thisT.position.y + 10f, landingChild._wayPoint.z);
			if (_controller._autoCatchDelay.x > 0f)
			{
				StartCoroutine(GetFlockChild(_controller._autoCatchDelay.x + 0.1f, _controller._autoCatchDelay.y + 0.1f));
			}
			landingChild = null;
			_controller._activeLandingSpots--;
		}
	}
}
public class LandingSpotController : MonoBehaviour
{
	public bool _randomRotate = true;

	public Vector2 _autoCatchDelay = new Vector2(10f, 20f);

	public Vector2 _autoDismountDelay = new Vector2(10f, 20f);

	public float _maxBirdDistance = 20f;

	public float _minBirdDistance = 5f;

	public bool _takeClosest;

	public FlockController _flock;

	public bool _landOnStart;

	public bool _soarLand = true;

	public bool _onlyBirdsAbove;

	public float _landingSpeedModifier = 0.5f;

	public float _landingTurnSpeedModifier = 5f;

	public Transform _featherPS;

	public Transform _thisT;

	public int _activeLandingSpots;

	public float _snapLandDistance = 0.1f;

	public float _landedRotateSpeed = 0.01f;

	public float _gizmoSize = 0.2f;

	public void Start()
	{
		if (_thisT == null)
		{
			_thisT = base.transform;
		}
		if (_flock == null)
		{
			_flock = (FlockController)UnityEngine.Object.FindObjectOfType(typeof(FlockController));
			UnityEngine.Debug.Log(string.Concat(this, " has no assigned FlockController, a random FlockController has been assigned"));
		}
		if (_landOnStart)
		{
			StartCoroutine(InstantLandOnStart(0.1f));
		}
	}

	public void ScareAll()
	{
		ScareAll(0f, 1f);
	}

	public void ScareAll(float minDelay, float maxDelay)
	{
		for (int i = 0; i < _thisT.childCount; i++)
		{
			if (_thisT.GetChild(i).GetComponent<LandingSpot>() != null)
			{
				_thisT.GetChild(i).GetComponent<LandingSpot>().Invoke("ReleaseFlockChild", UnityEngine.Random.Range(minDelay, maxDelay));
			}
		}
	}

	public void LandAll()
	{
		for (int i = 0; i < _thisT.childCount; i++)
		{
			if (_thisT.GetChild(i).GetComponent<LandingSpot>() != null)
			{
				LandingSpot component = _thisT.GetChild(i).GetComponent<LandingSpot>();
				StartCoroutine(component.GetFlockChild(0f, 2f));
			}
		}
	}

	public IEnumerator InstantLandOnStart(float delay)
	{
		yield return new WaitForSeconds(delay);
		for (int i = 0; i < _thisT.childCount; i++)
		{
			if (_thisT.GetChild(i).GetComponent<LandingSpot>() != null)
			{
				_thisT.GetChild(i).GetComponent<LandingSpot>().InstantLand();
			}
		}
	}

	public IEnumerator InstantLand(float delay)
	{
		yield return new WaitForSeconds(delay);
		for (int i = 0; i < _thisT.childCount; i++)
		{
			if (_thisT.GetChild(i).GetComponent<LandingSpot>() != null)
			{
				_thisT.GetChild(i).GetComponent<LandingSpot>().InstantLand();
			}
		}
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Analog TV")]
public class CC_AnalogTV : CC_Base
{
	public bool autoPhase = true;

	public float phase = 0.5f;

	public bool grayscale;

	public float noiseIntensity = 0.5f;

	public float scanlinesIntensity = 2f;

	public float scanlinesCount = 768f;

	public float distortion = 0.2f;

	public float cubicDistortion = 0.6f;

	public float scale = 0.8f;

	private void Update()
	{
		if (autoPhase)
		{
			phase += Time.deltaTime * 0.25f;
		}
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetFloat("_phase", phase);
		base.material.SetFloat("_noiseIntensity", noiseIntensity);
		base.material.SetFloat("_scanlinesIntensity", scanlinesIntensity);
		base.material.SetFloat("_scanlinesCount", (int)scanlinesCount);
		base.material.SetFloat("_distortion", distortion);
		base.material.SetFloat("_cubicDistortion", cubicDistortion);
		base.material.SetFloat("_scale", scale);
		Graphics.Blit(source, destination, base.material, grayscale ? 1 : 0);
	}
}
[RequireComponent(typeof(Camera))]
[AddComponentMenu("")]
public class CC_Base : MonoBehaviour
{
	public Shader shader;

	protected Material _material;

	protected Material material
	{
		get
		{
			if (_material == null)
			{
				_material = new Material(shader);
				_material.hideFlags = HideFlags.HideAndDontSave;
			}
			return _material;
		}
	}

	protected virtual void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!shader || !shader.isSupported)
		{
			base.enabled = false;
		}
	}

	protected virtual void OnDisable()
	{
		if ((bool)_material)
		{
			UnityEngine.Object.DestroyImmediate(_material);
		}
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Bleach Bypass")]
public class CC_BleachBypass : CC_Base
{
	public float amount = 1f;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (amount == 0f)
		{
			Graphics.Blit(source, destination);
			return;
		}
		base.material.SetFloat("_amount", amount);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Blend")]
public class CC_Blend : CC_Base
{
	public Texture texture;

	public float amount = 1f;

	public int mode;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (texture == null || amount == 0f)
		{
			Graphics.Blit(source, destination);
			return;
		}
		base.material.SetTexture("_overlayTex", texture);
		base.material.SetFloat("_amount", amount);
		Graphics.Blit(source, destination, base.material, mode);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Brightness, Contrast, Gamma")]
public class CC_BrightnessContrastGamma : CC_Base
{
	public float redCoeff = 0.5f;

	public float greenCoeff = 0.5f;

	public float blueCoeff = 0.5f;

	public float brightness;

	public float contrast;

	public float gamma = 1f;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (brightness == 0f && contrast == 0f && gamma == 1f)
		{
			Graphics.Blit(source, destination);
			return;
		}
		base.material.SetFloat("_rCoeff", redCoeff);
		base.material.SetFloat("_gCoeff", greenCoeff);
		base.material.SetFloat("_bCoeff", blueCoeff);
		base.material.SetFloat("_brightness", (brightness + 100f) * 0.01f);
		base.material.SetFloat("_contrast", (contrast + 100f) * 0.01f);
		base.material.SetFloat("_gamma", 1f / gamma);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Channel Mixer")]
public class CC_ChannelMixer : CC_Base
{
	public float redR = 100f;

	public float redG;

	public float redB;

	public float greenR;

	public float greenG = 100f;

	public float greenB;

	public float blueR;

	public float blueG;

	public float blueB = 100f;

	public float constantR;

	public float constantG;

	public float constantB;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetVector("_red", new Vector4(redR * 0.01f, greenR * 0.01f, blueR * 0.01f));
		base.material.SetVector("_green", new Vector4(redG * 0.01f, greenG * 0.01f, blueG * 0.01f));
		base.material.SetVector("_blue", new Vector4(redB * 0.01f, greenB * 0.01f, blueB * 0.01f));
		base.material.SetVector("_constant", new Vector4(constantR * 0.01f, constantG * 0.01f, constantB * 0.01f));
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Convolution Matrix 3x3")]
public class CC_Convolution3x3 : CC_Base
{
	public Vector3 kernelTop = Vector3.zero;

	public Vector3 kernelMiddle = Vector3.up;

	public Vector3 kernelBottom = Vector3.zero;

	public float divisor = 1f;

	public float amount = 1f;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetFloat("_px", 1f / (float)Screen.width);
		base.material.SetFloat("_py", 1f / (float)Screen.height);
		base.material.SetFloat("_amount", amount);
		base.material.SetVector("_kernelT", kernelTop / divisor);
		base.material.SetVector("_kernelM", kernelMiddle / divisor);
		base.material.SetVector("_kernelB", kernelBottom / divisor);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Cross Stitch")]
public class CC_CrossStitch : CC_Base
{
	public int size = 8;

	public float brightness = 1.5f;

	public bool invert;

	public bool pixelize = true;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetFloat("_stitchSize", size);
		base.material.SetFloat("_brightness", brightness);
		int num = (invert ? 1 : 0);
		if (pixelize)
		{
			num += 2;
			Camera component = GetComponent<Camera>();
			base.material.SetFloat("_scale", component.pixelWidth / size);
			base.material.SetFloat("_ratio", component.pixelWidth / component.pixelHeight);
		}
		Graphics.Blit(source, destination, base.material, num);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Double Vision")]
public class CC_DoubleVision : CC_Base
{
	public Vector2 displace = new Vector2(0.7f, 0f);

	public float amount = 1f;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (amount == 0f)
		{
			Graphics.Blit(source, destination);
			return;
		}
		base.material.SetVector("_displace", new Vector2(displace.x / (float)Screen.width, displace.y / (float)Screen.height));
		base.material.SetFloat("_amount", amount);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Fast Vignette")]
public class CC_FastVignette : CC_Base
{
	public float sharpness = 10f;

	public float darkness = 30f;

	public bool desaturate;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetFloat("_sharpness", sharpness * 0.01f);
		base.material.SetFloat("_darkness", darkness * 0.02f);
		Graphics.Blit(source, destination, base.material, desaturate ? 1 : 0);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Frost")]
public class CC_Frost : CC_Base
{
	public float scale = 1.2f;

	public float sharpness = 40f;

	public float darkness = 35f;

	public bool enableVignette = true;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (scale == 0f)
		{
			Graphics.Blit(source, destination);
			return;
		}
		base.material.SetFloat("_scale", scale);
		base.material.SetFloat("_sharpness", sharpness * 0.01f);
		base.material.SetFloat("_darkness", darkness * 0.02f);
		Graphics.Blit(source, destination, base.material, enableVignette ? 1 : 0);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Gradient Ramp")]
public class CC_GradientRamp : CC_Base
{
	public Texture rampTexture;

	public float amount = 1f;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (rampTexture == null || amount == 0f)
		{
			Graphics.Blit(source, destination);
			return;
		}
		base.material.SetTexture("_RampTex", rampTexture);
		base.material.SetFloat("_amount", amount);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Grayscale")]
public class CC_Grayscale : CC_Base
{
	public float redLuminance = 0.3f;

	public float greenLuminance = 0.59f;

	public float blueLuminance = 0.11f;

	public float amount = 1f;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (amount == 0f)
		{
			Graphics.Blit(source, destination);
			return;
		}
		base.material.SetVector("_data", new Vector4(redLuminance, greenLuminance, blueLuminance, amount));
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Halftone")]
public class CC_Halftone : CC_Base
{
	public float density = 64f;

	public int mode = 1;

	public bool antialiasing = true;

	public bool showOriginal;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetFloat("_density", density);
		int pass = 0;
		if (mode == 0)
		{
			if (antialiasing && showOriginal)
			{
				pass = 3;
			}
			else if (antialiasing)
			{
				pass = 1;
			}
			else if (showOriginal)
			{
				pass = 2;
			}
		}
		else if (mode == 1)
		{
			pass = (antialiasing ? 5 : 4);
		}
		Graphics.Blit(source, destination, base.material, pass);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Hue, Saturation, Value")]
public class CC_HueSaturationValue : CC_Base
{
	public float hue;

	public float saturation;

	public float value;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (hue == 0f && saturation == 0f && value == 0f)
		{
			Graphics.Blit(source, destination);
			return;
		}
		base.material.SetFloat("_hue", hue / 360f);
		base.material.SetFloat("_saturation", saturation * 0.01f);
		base.material.SetFloat("_value", value * 0.01f);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/LED")]
public class CC_Led : CC_Base
{
	public float scale = 80f;

	public bool automaticRatio;

	public float ratio = 1f;

	public float brightness = 1f;

	public int mode;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		Camera component = GetComponent<Camera>();
		switch (mode)
		{
		case 0:
			base.material.SetFloat("_scale", scale);
			break;
		default:
			base.material.SetFloat("_scale", (float)component.pixelWidth / scale);
			break;
		}
		base.material.SetFloat("_ratio", automaticRatio ? ((float)(component.pixelWidth / component.pixelHeight)) : ratio);
		base.material.SetFloat("_brightness", brightness);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Levels")]
public class CC_Levels : CC_Base
{
	public int mode;

	public float inputMinL;

	public float inputMaxL = 255f;

	public float inputGammaL = 1f;

	public float inputMinR;

	public float inputMaxR = 255f;

	public float inputGammaR = 1f;

	public float inputMinG;

	public float inputMaxG = 255f;

	public float inputGammaG = 1f;

	public float inputMinB;

	public float inputMaxB = 255f;

	public float inputGammaB = 1f;

	public float outputMinL;

	public float outputMaxL = 255f;

	public float outputMinR;

	public float outputMaxR = 255f;

	public float outputMinG;

	public float outputMaxG = 255f;

	public float outputMinB;

	public float outputMaxB = 255f;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (mode == 0)
		{
			base.material.SetVector("_inputMin", new Vector4(inputMinL / 255f, inputMinL / 255f, inputMinL / 255f, 1f));
			base.material.SetVector("_inputMax", new Vector4(inputMaxL / 255f, inputMaxL / 255f, inputMaxL / 255f, 1f));
			base.material.SetVector("_inputGamma", new Vector4(inputGammaL, inputGammaL, inputGammaL, 1f));
			base.material.SetVector("_outputMin", new Vector4(outputMinL / 255f, outputMinL / 255f, outputMinL / 255f, 1f));
			base.material.SetVector("_outputMax", new Vector4(outputMaxL / 255f, outputMaxL / 255f, outputMaxL / 255f, 1f));
		}
		else
		{
			base.material.SetVector("_inputMin", new Vector4(inputMinR / 255f, inputMinG / 255f, inputMinB / 255f, 1f));
			base.material.SetVector("_inputMax", new Vector4(inputMaxR / 255f, inputMaxG / 255f, inputMaxB / 255f, 1f));
			base.material.SetVector("_inputGamma", new Vector4(inputGammaR, inputGammaG, inputGammaB, 1f));
			base.material.SetVector("_outputMin", new Vector4(outputMinR / 255f, outputMinG / 255f, outputMinB / 255f, 1f));
			base.material.SetVector("_outputMax", new Vector4(outputMaxR / 255f, outputMaxG / 255f, outputMaxB / 255f, 1f));
		}
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Lookup Filter (Color Grading)")]
public class CC_LookupFilter : CC_Base
{
	public Texture lookupTexture;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (lookupTexture == null)
		{
			Graphics.Blit(source, destination);
			return;
		}
		base.material.SetTexture("_LookupTex", lookupTexture);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Negative")]
public class CC_Negative : CC_Base
{
	public float amount = 1f;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (amount == 0f)
		{
			Graphics.Blit(source, destination);
			return;
		}
		base.material.SetFloat("_amount", amount);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Photo Filter")]
public class CC_PhotoFilter : CC_Base
{
	public Color color = new Color(1f, 0.5f, 0.2f, 1f);

	public float density = 0.35f;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (density == 0f)
		{
			Graphics.Blit(source, destination);
			return;
		}
		base.material.SetColor("_rgb", color);
		base.material.SetFloat("_density", density);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Pixelate")]
public class CC_Pixelate : CC_Base
{
	public float scale = 80f;

	public bool automaticRatio;

	public float ratio = 1f;

	public int mode;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		Camera component = GetComponent<Camera>();
		switch (mode)
		{
		case 0:
			base.material.SetFloat("_scale", scale);
			break;
		default:
			base.material.SetFloat("_scale", (float)component.pixelWidth / scale);
			break;
		}
		base.material.SetFloat("_ratio", automaticRatio ? ((float)(component.pixelWidth / component.pixelHeight)) : ratio);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Posterize")]
public class CC_Posterize : CC_Base
{
	public int levels = 4;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetFloat("_levels", levels);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/RGB Split")]
public class CC_RGBSplit : CC_Base
{
	public float amount;

	public float angle;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (amount == 0f)
		{
			Graphics.Blit(source, destination);
			return;
		}
		base.material.SetFloat("_rgbShiftAmount", amount * 0.001f);
		base.material.SetFloat("_rgbShiftAngleCos", Mathf.Cos(angle));
		base.material.SetFloat("_rgbShiftAngleSin", Mathf.Sin(angle));
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Radial Blur")]
public class CC_RadialBlur : CC_Base
{
	public float amount = 0.1f;

	public Vector2 center = new Vector2(0.5f, 0.5f);

	public int quality = 1;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetFloat("amount", amount);
		base.material.SetVector("center", center);
		if (amount == 0f)
		{
			Graphics.Blit(source, destination);
		}
		else
		{
			Graphics.Blit(source, destination, base.material, quality);
		}
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Sharpen")]
public class CC_Sharpen : CC_Base
{
	public float strength = 0.6f;

	public float clamp = 0.05f;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (strength == 0f)
		{
			Graphics.Blit(source, destination);
			return;
		}
		base.material.SetFloat("_px", 1f / (float)Screen.width);
		base.material.SetFloat("_py", 1f / (float)Screen.height);
		base.material.SetFloat("_strength", strength);
		base.material.SetFloat("_clamp", clamp);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Threshold")]
public class CC_Threshold : CC_Base
{
	public float threshold = 128f;

	public bool useNoise;

	public float noiseRange = 48f;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetFloat("_threshold", threshold / 255f);
		base.material.SetFloat("_range", noiseRange / 255f);
		Graphics.Blit(source, destination, base.material, useNoise ? 1 : 0);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Vibrance")]
public class CC_Vibrance : CC_Base
{
	public float amount;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (amount == 0f)
		{
			Graphics.Blit(source, destination);
			return;
		}
		base.material.SetFloat("_amount", amount * 0.02f);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Wiggle")]
public class CC_Wiggle : CC_Base
{
	public float timer;

	public float speed = 1f;

	public float scale = 12f;

	public bool autoTimer = true;

	private void Update()
	{
		if (autoTimer)
		{
			timer += speed * Time.deltaTime;
		}
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetFloat("_timer", timer);
		base.material.SetFloat("_scale", scale);
		Graphics.Blit(source, destination, base.material);
	}
}
public class DecalDestroyer : MonoBehaviour
{
	public float lifeTime = 5f;

	private IEnumerator Start()
	{
		yield return new WaitForSeconds(lifeTime);
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
public class GunAim : MonoBehaviour
{
	public int borderLeft;

	public int borderRight;

	public int borderTop;

	public int borderBottom;

	private Camera parentCamera;

	private bool isOutOfBounds;

	private void Start()
	{
		parentCamera = GetComponentInParent<Camera>();
	}

	private void Update()
	{
		float x = Input.mousePosition.x;
		float y = Input.mousePosition.y;
		if (x <= (float)borderLeft || x >= (float)(Screen.width - borderRight) || y <= (float)borderBottom || y >= (float)(Screen.height - borderTop))
		{
			isOutOfBounds = true;
		}
		else
		{
			isOutOfBounds = false;
		}
		if (!isOutOfBounds)
		{
			base.transform.LookAt(parentCamera.ScreenToWorldPoint(new Vector3(x, y, 5f)));
		}
	}

	public bool GetIsOutOfBounds()
	{
		return isOutOfBounds;
	}
}
public class GunShoot : MonoBehaviour
{
	public float fireRate = 0.25f;

	public float weaponRange = 20f;

	public Transform gunEnd;

	public ParticleSystem muzzleFlash;

	public ParticleSystem cartridgeEjection;

	public GameObject metalHitEffect;

	public GameObject sandHitEffect;

	public GameObject stoneHitEffect;

	public GameObject waterLeakEffect;

	public GameObject[] fleshHitEffects;

	public GameObject woodHitEffect;

	private float nextFire;

	private Animator anim;

	private GunAim gunAim;

	private void Start()
	{
		anim = GetComponent<Animator>();
		gunAim = GetComponentInParent<GunAim>();
	}

	private void Update()
	{
		if (Input.GetButtonDown("Fire1") && Time.time > nextFire && !gunAim.GetIsOutOfBounds())
		{
			nextFire = Time.time + fireRate;
			muzzleFlash.Play();
			cartridgeEjection.Play();
			anim.SetTrigger("Fire");
			if (Physics.Raycast(gunEnd.position, gunEnd.forward, out var hitInfo, weaponRange))
			{
				HandleHit(hitInfo);
			}
		}
	}

	private void HandleHit(RaycastHit hit)
	{
		if (hit.collider.sharedMaterial != null)
		{
			switch (hit.collider.sharedMaterial.name)
			{
			case "Metal":
				SpawnDecal(hit, metalHitEffect);
				break;
			case "Sand":
				SpawnDecal(hit, sandHitEffect);
				break;
			case "Stone":
				SpawnDecal(hit, stoneHitEffect);
				break;
			case "WaterFilled":
				SpawnDecal(hit, waterLeakEffect);
				SpawnDecal(hit, metalHitEffect);
				break;
			case "Wood":
				SpawnDecal(hit, woodHitEffect);
				break;
			case "Meat":
				SpawnDecal(hit, fleshHitEffects[UnityEngine.Random.Range(0, fleshHitEffects.Length)]);
				break;
			case "Character":
				SpawnDecal(hit, fleshHitEffects[UnityEngine.Random.Range(0, fleshHitEffects.Length)]);
				break;
			}
		}
	}

	private void SpawnDecal(RaycastHit hit, GameObject prefab)
	{
		UnityEngine.Object.Instantiate(prefab, hit.point, Quaternion.LookRotation(hit.normal)).transform.SetParent(hit.collider.transform);
	}
}
[Serializable]
public class ParticleExamples
{
	public string title;

	[TextArea]
	public string description;

	public bool isWeaponEffect;

	public GameObject particleSystemGO;

	public Vector3 particlePosition;

	public Vector3 particleRotation;
}
public class ParticleMenu : MonoBehaviour
{
	public ParticleExamples[] particleSystems;

	public GameObject gunGameObject;

	private int currentIndex;

	private GameObject currentGO;

	public Transform spawnLocation;

	public Text title;

	public Text description;

	public Text navigationDetails;

	private void Start()
	{
		Navigate(0);
		currentIndex = 0;
	}

	public void Navigate(int i)
	{
		currentIndex = (particleSystems.Length + currentIndex + i) % particleSystems.Length;
		if (currentGO != null)
		{
			UnityEngine.Object.Destroy(currentGO);
		}
		currentGO = UnityEngine.Object.Instantiate(particleSystems[currentIndex].particleSystemGO, spawnLocation.position + particleSystems[currentIndex].particlePosition, Quaternion.Euler(particleSystems[currentIndex].particleRotation));
		gunGameObject.SetActive(particleSystems[currentIndex].isWeaponEffect);
		title.text = particleSystems[currentIndex].title;
		description.text = particleSystems[currentIndex].description;
		navigationDetails.text = currentIndex + 1 + " out of " + particleSystems.Length.ToString();
	}
}
public class GameSparksRTUnity : MonoBehaviour, IRTSessionListener
{
	private IRTSession session;

	private Action<int> m_OnPlayerConnect;

	private Action<int> m_OnPlayerDisconnect;

	private Action<bool> m_OnReady;

	private Action<RTPacket> m_OnPacket;

	private static GameSparksRTUnity instance;

	public static GameSparksRTUnity Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new GameObject("GameSparksRTUnity").AddComponent<GameSparksRTUnity>();
				UnityEngine.Object.DontDestroyOnLoad(instance.gameObject);
			}
			return instance;
		}
		private set
		{
			if (instance != null && instance != value)
			{
				UnityEngine.Object.Destroy(instance.gameObject);
			}
			instance = value;
		}
	}

	public int? PeerId
	{
		get
		{
			if (session != null)
			{
				return session.PeerId;
			}
			return null;
		}
	}

	public List<int> ActivePeers
	{
		get
		{
			if (session != null)
			{
				return session.ActivePeers;
			}
			return null;
		}
	}

	public bool Ready
	{
		get
		{
			if (session != null)
			{
				return session.Ready;
			}
			return false;
		}
	}

	private void Awake()
	{
		instance = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	public void Configure(MatchFoundMessage message, Action<int> OnPlayerConnect, Action<int> OnPlayerDisconnect, Action<bool> OnReady, Action<RTPacket> OnPacket)
	{
		if (!message.Port.HasValue)
		{
			UnityEngine.Debug.Log("Response does not contain a port, exiting.");
		}
		else
		{
			Configure(message.Host, message.Port.Value, message.AccessToken, OnPlayerConnect, OnPlayerDisconnect, OnReady, OnPacket);
		}
	}

	public void Configure(FindMatchResponse response, Action<int> OnPlayerConnect, Action<int> OnPlayerDisconnect, Action<bool> OnReady, Action<RTPacket> OnPacket)
	{
		if (!response.Port.HasValue)
		{
			UnityEngine.Debug.Log("Response does not contain a port, exiting.");
		}
		else
		{
			Configure(response.Host, response.Port.Value, response.AccessToken, OnPlayerConnect, OnPlayerDisconnect, OnReady, OnPacket);
		}
	}

	public void Configure(string host, int port, string accessToken, Action<int> OnPlayerConnect, Action<int> OnPlayerDisconnect, Action<bool> OnReady, Action<RTPacket> OnPacket)
	{
		m_OnPlayerConnect = OnPlayerConnect;
		m_OnPlayerDisconnect = OnPlayerDisconnect;
		m_OnReady = OnReady;
		m_OnPacket = OnPacket;
		if (session != null)
		{
			session.Stop();
		}
		session = GameSparksRT.SessionBuilder().SetHost(host).SetPort(port)
			.SetConnectToken(accessToken)
			.SetListener(this)
			.Build();
	}

	public void Connect()
	{
		if (session != null)
		{
			UnityEngine.Debug.Log("Starting Session");
			session.Start();
		}
		else
		{
			UnityEngine.Debug.Log("Cannot start Session");
		}
	}

	public void Disconnect()
	{
		if (session != null)
		{
			session.Stop();
		}
	}

	public int SendData(int opCode, GameSparksRT.DeliveryIntent deliveryIntent, RTData structuredData, params int[] targetPlayers)
	{
		if (session != null)
		{
			return session.SendRTData(opCode, deliveryIntent, structuredData, targetPlayers);
		}
		return -1;
	}

	public int SendBytes(int opCode, GameSparksRT.DeliveryIntent deliveryIntent, ArraySegment<byte> unstructuredData, params int[] targetPlayers)
	{
		if (session != null)
		{
			return session.SendBytes(opCode, deliveryIntent, unstructuredData, targetPlayers);
		}
		return -1;
	}

	public int SendRTDataAndBytes(int opCode, GameSparksRT.DeliveryIntent deliveryIntent, ArraySegment<byte> unstructuredData, RTData structuredData, params int[] targetPlayers)
	{
		if (session != null)
		{
			return session.SendRTDataAndBytes(opCode, deliveryIntent, unstructuredData, structuredData, targetPlayers);
		}
		return -1;
	}

	private void OnDestroy()
	{
		Disconnect();
	}

	private void Update()
	{
		if (session != null)
		{
			session.Update();
		}
	}

	public void OnPlayerConnect(int peerId)
	{
		if (m_OnPlayerConnect != null)
		{
			m_OnPlayerConnect(peerId);
		}
	}

	public void OnPlayerDisconnect(int peerId)
	{
		if (m_OnPlayerDisconnect != null)
		{
			m_OnPlayerDisconnect(peerId);
		}
	}

	public void OnReady(bool ready)
	{
		if (m_OnReady != null)
		{
			m_OnReady(ready);
		}
	}

	public void OnPacket(RTPacket packet)
	{
		if (m_OnPacket != null)
		{
			m_OnPacket(packet);
		}
	}
}
public static class RTDataExtensions
{
	public static RTData SetVector2(this RTData data, uint index, Vector2 vector2)
	{
		data.SetRTVector(index, new RTVector(vector2.x, vector2.y));
		return data;
	}

	public static Vector2? GetVector2(this RTData data, uint index)
	{
		if (data.GetRTVector(index).HasValue)
		{
			RTVector value = data.GetRTVector(index).Value;
			return new Vector2(value.x.Value, value.y.Value);
		}
		return null;
	}

	public static RTData SetVector3(this RTData data, uint index, Vector3 vector3)
	{
		data.SetRTVector(index, new RTVector(vector3.x, vector3.y, vector3.z));
		return data;
	}

	public static Vector3? GetVector3(this RTData data, uint index)
	{
		if (data.GetRTVector(index).HasValue)
		{
			RTVector value = data.GetRTVector(index).Value;
			if (!value.z.HasValue)
			{
				return null;
			}
			return new Vector3(value.x.Value, value.y.Value, value.z.Value);
		}
		return null;
	}

	public static RTData SetVector4(this RTData data, uint index, Vector4 vector4)
	{
		data.SetRTVector(index, new RTVector(vector4.x, vector4.y, vector4.z, vector4.w));
		return data;
	}

	public static Vector4? GetVector4(this RTData data, uint index)
	{
		if (data.GetRTVector(index).HasValue)
		{
			RTVector value = data.GetRTVector(index).Value;
			if (!value.w.HasValue)
			{
				return null;
			}
			return new Vector4(value.x.Value, value.y.Value, value.z.Value, value.w.Value);
		}
		return null;
	}
}
public class GameSparksSettings : ScriptableObject
{
	public const string gamesparksSettingsAssetName = "GameSparksSettings";

	public const string gamesparksSettingsPath = "Plugins/Third Party/GameSparks/Resources";

	public const string gamesparksSettingsAssetExtension = ".asset";

	private static readonly string liveServiceUrlBase = "wss://live-{0}.ws.gamesparks.net/ws/{1}/{0}";

	private static readonly string previewServiceUrlBase = "wss://preview-{0}.ws.gamesparks.net/ws/{1}/{0}";

	private static GameSparksSettings instance;

	[SerializeField]
	private string sdkVersion;

	[SerializeField]
	private string apiKey = "";

	[SerializeField]
	private string credential = "device";

	[SerializeField]
	private string apiSecret = "";

	[SerializeField]
	private bool previewBuild = true;

	[SerializeField]
	private bool debugBuild;

	public static GameSparksSettings Instance
	{
		get
		{
			if ((object)instance == null)
			{
				instance = Resources.Load("GameSparksSettings") as GameSparksSettings;
				if ((object)instance == null)
				{
					instance = ScriptableObject.CreateInstance<GameSparksSettings>();
				}
			}
			return instance;
		}
	}

	public static bool PreviewBuild
	{
		get
		{
			return Instance.previewBuild;
		}
		set
		{
			Instance.previewBuild = value;
		}
	}

	public static string SdkVersion
	{
		get
		{
			return Instance.sdkVersion;
		}
		set
		{
			Instance.sdkVersion = value;
		}
	}

	public static string ApiSecret
	{
		get
		{
			return Instance.apiSecret;
		}
		set
		{
			Instance.apiSecret = value;
		}
	}

	public static string ApiKey
	{
		get
		{
			return Instance.apiKey;
		}
		set
		{
			Instance.apiKey = value;
		}
	}

	public static string Credential
	{
		get
		{
			if (Instance.credential != null && Instance.credential.Length != 0)
			{
				return Instance.credential;
			}
			return "device";
		}
		set
		{
			Instance.credential = value;
		}
	}

	public static bool DebugBuild
	{
		get
		{
			return Instance.debugBuild;
		}
		set
		{
			Instance.debugBuild = value;
		}
	}

	public static string ServiceUrl
	{
		get
		{
			string text = Instance.apiKey;
			if (Instance.apiSecret.Contains(":"))
			{
				text = Instance.apiSecret.Substring(0, Instance.apiSecret.IndexOf(":")) + "/" + text;
			}
			if (Instance.previewBuild)
			{
				return string.Format(previewServiceUrlBase, text, Instance.credential);
			}
			return string.Format(liveServiceUrlBase, text, Instance.credential);
		}
	}

	public static void SetInstance(GameSparksSettings settings)
	{
		instance = settings;
	}
}
public class GameSparksUnity : MonoBehaviour
{
	public GameSparksSettings settings;

	public Action<Exception> exceptionReporter { get; set; }

	private void Start()
	{
		base.gameObject.AddComponent<DefaultPlatform>().ExceptionReporter = exceptionReporter;
	}
}
public class GameSparksTestUI : MonoBehaviour
{
	private Queue<string> myLogQueue = new Queue<string>();

	private string myLog = "";

	private string fbToken = "accessToken";

	private string dismissMessageId = "messageId";

	private const int itemHeight = 30;

	private const int itemWidth = 200;

	private bool testing;

	private bool working;

	private bool result;

	private int counter;

	private int numTest;

	public Texture cursor;

	private void Awake()
	{
		Application.logMessageReceivedThreaded += HandleLog;
		Screen.orientation = ScreenOrientation.AutoRotation;
	}

	private void Start()
	{
		GSMessageHandler._AllMessages = HandleGameSparksMessageReceived;
	}

	private void HandleGameSparksMessageReceived(GSMessage message)
	{
		HandleLog("MSG:" + message.JSONString);
	}

	private void HandleLog(string logString)
	{
		GS.GSPlatform.ExecuteOnMainThread(delegate
		{
			HandleLog(logString, null, LogType.Log);
		});
	}

	private void HandleLog(string logString, string stackTrace, LogType logType)
	{
		if (myLogQueue.Count > 30)
		{
			myLogQueue.Dequeue();
		}
		myLogQueue.Enqueue(logString);
		myLog = "";
		string[] array = myLogQueue.ToArray();
		foreach (string text in array)
		{
			myLog = myLog + "\n\n" + text;
		}
	}

	private void OnGUI()
	{
		GUI.skin.label.alignment = TextAnchor.MiddleCenter;
		GUI.skin.textField.alignment = TextAnchor.MiddleCenter;
		GUI.skin.textArea.alignment = TextAnchor.LowerLeft;
		GUILayout.BeginHorizontal();
		GUILayout.Label(GS.Available ? "AVAILABLE" : "NOT AVAILABLE", GUILayout.Width(200f), GUILayout.Height(30f));
		GUILayout.Label("SDK Version: " + GS.Version.ToString(), GUILayout.Width(200f), GUILayout.Height(30f));
		GUILayout.EndHorizontal();
		GUILayout.Label(GS.Authenticated ? "AUTHENTICATED" : "NOT AUTHENTICATED", GUILayout.Width(200f), GUILayout.Height(30f));
		if (GUILayout.Button("Clear Log", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			myLog = "";
			myLogQueue.Clear();
		}
		if (GUILayout.Button("Logout", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			GS.Reset();
		}
		if (GUILayout.Button("Disconnect", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			GS.Disconnect();
		}
		if (!GS.Available && GUILayout.Button("Reconnect", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			GS.Reconnect();
		}
		if (GUILayout.Button("DeviceAuthenticationRequest", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			new DeviceAuthenticationRequest().Send(delegate(AuthenticationResponse response)
			{
				HandleLog("DeviceAuthenticationRequest.JSON:" + response.JSONString);
				HandleLog("DeviceAuthenticationRequest.HasErrors:" + response.HasErrors);
				HandleLog("DeviceAuthenticationRequest.UserId:" + response.UserId);
			});
		}
		if (GUILayout.Button("durableAccountDetailsRequest", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			new AccountDetailsRequest().SetDurable(durable: true).Send(null);
		}
		if (GUILayout.Button("accountDetailsRequest", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			new AccountDetailsRequest().Send(delegate(AccountDetailsResponse response)
			{
				HandleLog("AccountDetailsRequest.UserId:" + response.UserId);
			});
		}
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("facebookConnectRequest", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			new FacebookConnectRequest().SetAccessToken(fbToken).Send(delegate(AuthenticationResponse response)
			{
				HandleLog("FacebookConnectRequest.HasErrors:" + response.HasErrors);
				HandleLog("FacebookConnectRequest.UserId:" + response.UserId);
			});
		}
		fbToken = GUILayout.TextField(fbToken, GUILayout.Width(200f), GUILayout.Height(30f));
		GUILayout.EndHorizontal();
		if (GUILayout.Button("listAchievementsRequest", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			new ListAchievementsRequest().Send(delegate(ListAchievementsResponse response)
			{
				foreach (ListAchievementsResponse._Achievement achievement in response.Achievements)
				{
					HandleLog("ListAchievementsRequest:shortCode:" + achievement.ShortCode);
				}
			});
		}
		if (GUILayout.Button("listGameFriendsRequest", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			new ListGameFriendsRequest().Send(delegate(ListGameFriendsResponse response)
			{
				foreach (ListGameFriendsResponse._Player friend in response.Friends)
				{
					HandleLog("ListGameFriendsRequest.DisplayName:" + friend.DisplayName);
				}
			});
		}
		if (GUILayout.Button("listVirtualGoodsRequest", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			new ListVirtualGoodsRequest().Send(delegate(ListVirtualGoodsResponse response)
			{
				foreach (ListVirtualGoodsResponse._VirtualGood virtualGood in response.VirtualGoods)
				{
					HandleLog("ListVirtualGoodsRequest.Description:" + virtualGood.Description);
				}
			});
		}
		if (GUILayout.Button("listChallengeTypeRequest", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			new ListChallengeTypeRequest().Send(delegate(ListChallengeTypeResponse response)
			{
				foreach (ListChallengeTypeResponse._ChallengeType challengeTemplate in response.ChallengeTemplates)
				{
					HandleLog("ListAchievementsRequest.Challenge:" + challengeTemplate.ChallengeShortCode);
				}
			});
		}
		if (GUILayout.Button("authenticationRequest", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			new AuthenticationRequest().SetUserName("gabs").SetPassword("gabs").Send(delegate(AuthenticationResponse AR)
			{
				if (AR.HasErrors)
				{
					UnityEngine.Debug.Log("Didnt Work");
				}
				else
				{
					UnityEngine.Debug.Log("Worked");
				}
			});
		}
		if (GUILayout.Button("leaderboardData", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			new LeaderboardDataRequest().SetLeaderboardShortCode("HSCORE").SetEntryCount(10L).Send(delegate(LeaderboardDataResponse leadResponse)
			{
				if (leadResponse.HasErrors)
				{
					UnityEngine.Debug.Log("Leaderboard data retrieval failed ...");
					return;
				}
				UnityEngine.Debug.Log("Leaderboard data retrieval succeeded ..." + leadResponse);
				foreach (LeaderboardDataResponse._LeaderboardData datum in leadResponse.Data)
				{
					UnityEngine.Debug.Log("Rank: " + datum.Rank + "    UserName: " + datum.UserName + "    Score: " + datum.GetNumberValue("SCORE"));
				}
			});
		}
		if (GUILayout.Button("listMessageRequest", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			new ListMessageRequest().Send(delegate(ListMessageResponse response)
			{
				foreach (GSData message in response.MessageList)
				{
					HandleLog("ListMessageRequest.MessageList:" + message.GetString("messageId"));
				}
			});
		}
		GUILayout.BeginHorizontal();
		if (GUILayout.Button("dismissMessageRequest", GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			new DismissMessageRequest().SetMessageId(dismissMessageId).Send(delegate(DismissMessageResponse response)
			{
				HandleLog("DismissMessageRequest.HasErrors:" + response.HasErrors);
			});
		}
		dismissMessageId = GUILayout.TextField(dismissMessageId, GUILayout.Width(200f), GUILayout.Height(30f));
		GUILayout.EndHorizontal();
		if (GUILayout.Button("TRACE " + (GS.TraceMessages ? "ON" : "OFF"), GUILayout.Width(200f), GUILayout.Height(30f)))
		{
			GS.TraceMessages = !GS.TraceMessages;
		}
		GUI.TextArea(new Rect(420f, 5f, Screen.width - 425, Screen.height - 10), myLog);
	}

	public void Update()
	{
	}
}
public enum OffMeshLinkMoveMethod
{
	Teleport,
	NormalSpeed,
	Parabola,
	Curve
}
[RequireComponent(typeof(NavMeshAgent))]
public class AgentLinkMover : MonoBehaviour
{
	public OffMeshLinkMoveMethod m_Method = OffMeshLinkMoveMethod.Parabola;

	public AnimationCurve m_Curve = new AnimationCurve();

	private IEnumerator Start()
	{
		NavMeshAgent agent = GetComponent<NavMeshAgent>();
		agent.autoTraverseOffMeshLink = false;
		while (true)
		{
			if (agent.isOnOffMeshLink)
			{
				if (m_Method == OffMeshLinkMoveMethod.NormalSpeed)
				{
					yield return StartCoroutine(NormalSpeed(agent));
				}
				else if (m_Method == OffMeshLinkMoveMethod.Parabola)
				{
					yield return StartCoroutine(Parabola(agent, 2f, 0.5f));
				}
				else if (m_Method == OffMeshLinkMoveMethod.Curve)
				{
					yield return StartCoroutine(Curve(agent, 0.5f));
				}
				agent.CompleteOffMeshLink();
			}
			yield return null;
		}
	}

	private IEnumerator NormalSpeed(NavMeshAgent agent)
	{
		Vector3 endPos = agent.currentOffMeshLinkData.endPos + Vector3.up * agent.baseOffset;
		while (agent.transform.position != endPos)
		{
			agent.transform.position = Vector3.MoveTowards(agent.transform.position, endPos, agent.speed * Time.deltaTime);
			yield return null;
		}
	}

	private IEnumerator Parabola(NavMeshAgent agent, float height, float duration)
	{
		OffMeshLinkData currentOffMeshLinkData = agent.currentOffMeshLinkData;
		Vector3 startPos = agent.transform.position;
		Vector3 endPos = currentOffMeshLinkData.endPos + Vector3.up * agent.baseOffset;
		float normalizedTime = 0f;
		while (normalizedTime < 1f)
		{
			float num = height * 4f * (normalizedTime - normalizedTime * normalizedTime);
			agent.transform.position = Vector3.Lerp(startPos, endPos, normalizedTime) + num * Vector3.up;
			normalizedTime += Time.deltaTime / duration;
			yield return null;
		}
	}

	private IEnumerator Curve(NavMeshAgent agent, float duration)
	{
		OffMeshLinkData currentOffMeshLinkData = agent.currentOffMeshLinkData;
		Vector3 startPos = agent.transform.position;
		Vector3 endPos = currentOffMeshLinkData.endPos + Vector3.up * agent.baseOffset;
		float normalizedTime = 0f;
		while (normalizedTime < 1f)
		{
			float num = m_Curve.Evaluate(normalizedTime);
			agent.transform.position = Vector3.Lerp(startPos, endPos, normalizedTime) + num * Vector3.up;
			normalizedTime += Time.deltaTime / duration;
			yield return null;
		}
	}
}
[RequireComponent(typeof(NavMeshAgent))]
public class ClickToMove : MonoBehaviour
{
	private NavMeshAgent m_Agent;

	private RaycastHit m_HitInfo;

	private void Start()
	{
		m_Agent = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0) && !Input.GetKey(KeyCode.LeftShift))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray.origin, ray.direction, out m_HitInfo))
			{
				m_Agent.destination = m_HitInfo.point;
			}
		}
	}
}
public class DestroyOnTrigger : MonoBehaviour
{
	public string m_Tag = "Player";

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == m_Tag)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
[DefaultExecutionOrder(-200)]
public class DungeonManager : MonoBehaviour
{
	public int m_Width = 10;

	public int m_Height = 10;

	public float m_Spacing = 4f;

	public GameObject[] m_Tiles = new GameObject[16];

	private void Awake()
	{
		UnityEngine.Random.InitState(23431);
		int[] array = new int[m_Width * m_Height];
		for (int i = 0; i < m_Height; i++)
		{
			for (int j = 0; j < m_Width; j++)
			{
				bool flag = false;
				bool flag2 = false;
				if (j > 0)
				{
					flag = (array[j - 1 + i * m_Width] & 1) != 0;
				}
				if (i > 0)
				{
					flag2 = (array[j + (i - 1) * m_Width] & 2) != 0;
				}
				int num = 0;
				if (flag)
				{
					num |= 4;
				}
				if (flag2)
				{
					num |= 8;
				}
				if (j + 1 < m_Width && UnityEngine.Random.value > 0.5f)
				{
					num |= 1;
				}
				if (i + 1 < m_Height && UnityEngine.Random.value > 0.5f)
				{
					num |= 2;
				}
				array[j + i * m_Width] = num;
			}
		}
		for (int k = 0; k < m_Height; k++)
		{
			for (int l = 0; l < m_Width; l++)
			{
				Vector3 position = new Vector3((float)l * m_Spacing, 0f, (float)k * m_Spacing);
				if (m_Tiles[array[l + k * m_Width]] != null)
				{
					UnityEngine.Object.Instantiate(m_Tiles[array[l + k * m_Width]], position, Quaternion.identity);
				}
			}
		}
	}
}
public class EnableIffSleeping : MonoBehaviour
{
	public Behaviour m_Behaviour;

	private Rigidbody m_Rigidbody;

	private void Start()
	{
		m_Rigidbody = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		if (!(m_Rigidbody == null) && !(m_Behaviour == null))
		{
			if (m_Rigidbody.IsSleeping() && !m_Behaviour.enabled)
			{
				m_Behaviour.enabled = true;
			}
			if (!m_Rigidbody.IsSleeping() && m_Behaviour.enabled)
			{
				m_Behaviour.enabled = false;
			}
		}
	}
}
public class FreeCam : MonoBehaviour
{
	public enum RotationAxes
	{
		MouseXAndY,
		MouseX,
		MouseY
	}

	public RotationAxes axes;

	public float sensitivityX = 15f;

	public float sensitivityY = 15f;

	public float minimumX = -360f;

	public float maximumX = 360f;

	public float minimumY = -60f;

	public float maximumY = 60f;

	public float moveSpeed = 1f;

	public bool lockHeight;

	private float rotationY;

	private void Update()
	{
		if (axes == RotationAxes.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
			base.transform.localEulerAngles = new Vector3(0f - rotationY, y, 0f);
		}
		else if (axes == RotationAxes.MouseX)
		{
			base.transform.Rotate(0f, Input.GetAxis("Mouse X") * sensitivityX, 0f);
		}
		else
		{
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
			base.transform.localEulerAngles = new Vector3(0f - rotationY, base.transform.localEulerAngles.y, 0f);
		}
		float axis = Input.GetAxis("Horizontal");
		float axis2 = Input.GetAxis("Vertical");
		if (lockHeight)
		{
			Vector3 vector = base.transform.TransformDirection(new Vector3(axis, 0f, axis2) * moveSpeed);
			vector.y = 0f;
			base.transform.position += vector;
		}
		else
		{
			base.transform.Translate(new Vector3(axis, 0f, axis2) * moveSpeed);
		}
	}
}
[DefaultExecutionOrder(-102)]
public class LocalNavMeshBuilder : MonoBehaviour
{
	public Transform m_Tracked;

	public Vector3 m_Size = new Vector3(80f, 20f, 80f);

	private NavMeshData m_NavMesh;

	private UnityEngine.AsyncOperation m_Operation;

	private NavMeshDataInstance m_Instance;

	private List<NavMeshBuildSource> m_Sources = new List<NavMeshBuildSource>();

	private IEnumerator Start()
	{
		while (true)
		{
			UpdateNavMesh(asyncUpdate: true);
			yield return m_Operation;
		}
	}

	private void OnEnable()
	{
		m_NavMesh = new NavMeshData();
		m_Instance = NavMesh.AddNavMeshData(m_NavMesh);
		if (m_Tracked == null)
		{
			m_Tracked = base.transform;
		}
		UpdateNavMesh();
	}

	private void OnDisable()
	{
		m_Instance.Remove();
	}

	private void UpdateNavMesh(bool asyncUpdate = false)
	{
		NavMeshSourceTag.Collect(ref m_Sources);
		NavMeshBuildSettings settingsByID = NavMesh.GetSettingsByID(0);
		Bounds localBounds = QuantizedBounds();
		if (asyncUpdate)
		{
			m_Operation = NavMeshBuilder.UpdateNavMeshDataAsync(m_NavMesh, settingsByID, m_Sources, localBounds);
		}
		else
		{
			NavMeshBuilder.UpdateNavMeshData(m_NavMesh, settingsByID, m_Sources, localBounds);
		}
	}

	private static Vector3 Quantize(Vector3 v, Vector3 quant)
	{
		float x = quant.x * Mathf.Floor(v.x / quant.x);
		float y = quant.y * Mathf.Floor(v.y / quant.y);
		float z = quant.z * Mathf.Floor(v.z / quant.z);
		return new Vector3(x, y, z);
	}

	private Bounds QuantizedBounds()
	{
		return new Bounds(Quantize(m_Tracked ? m_Tracked.position : base.transform.position, 0.1f * m_Size), m_Size);
	}

	private void OnDrawGizmosSelected()
	{
		if ((bool)m_NavMesh)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawWireCube(m_NavMesh.sourceBounds.center, m_NavMesh.sourceBounds.size);
		}
		Gizmos.color = Color.yellow;
		Bounds bounds = QuantizedBounds();
		Gizmos.DrawWireCube(bounds.center, bounds.size);
		Gizmos.color = Color.green;
		Gizmos.DrawWireCube(m_Tracked ? m_Tracked.position : base.transform.position, m_Size);
	}
}
public enum ExtrudeMethod
{
	Vertical,
	MeshNormal
}
public class MeshTool : MonoBehaviour
{
	public List<MeshFilter> m_Filters = new List<MeshFilter>();

	public float m_Radius = 1.5f;

	public float m_Power = 2f;

	public ExtrudeMethod m_Method;

	private RaycastHit m_HitInfo;

	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	private void Update()
	{
		Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
		if (Physics.Raycast(ray.origin, ray.direction, out m_HitInfo))
		{
			UnityEngine.Debug.DrawRay(m_HitInfo.point, m_HitInfo.normal, Color.red);
			Vector3 vector = ((m_Method == ExtrudeMethod.Vertical) ? Vector3.up : m_HitInfo.normal);
			if (Input.GetMouseButton(0) || (Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.LeftShift)))
			{
				ModifyMesh(m_Power * vector, m_HitInfo.point);
			}
			if (Input.GetMouseButton(1) || (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.LeftShift)))
			{
				ModifyMesh((0f - m_Power) * vector, m_HitInfo.point);
			}
		}
	}

	private void ModifyMesh(Vector3 displacement, Vector3 center)
	{
		foreach (MeshFilter filter in m_Filters)
		{
			Mesh mesh = filter.mesh;
			Vector3[] vertices = mesh.vertices;
			for (int i = 0; i < vertices.Length; i++)
			{
				Vector3 pos = filter.transform.TransformPoint(vertices[i]);
				vertices[i] += displacement * Gaussian(pos, center, m_Radius);
			}
			mesh.vertices = vertices;
			mesh.RecalculateBounds();
			MeshCollider component = filter.GetComponent<MeshCollider>();
			if (component != null)
			{
				Mesh mesh2 = new Mesh();
				mesh2.vertices = mesh.vertices;
				mesh2.triangles = mesh.triangles;
				component.sharedMesh = mesh2;
			}
		}
	}

	private static float Gaussian(Vector3 pos, Vector3 mean, float dev)
	{
		float num = pos.x - mean.x;
		float num2 = pos.y - mean.y;
		float num3 = pos.z - mean.z;
		return 1f / ((float)Math.PI * 2f * dev * dev) * Mathf.Pow((float)Math.E, (0f - (num * num + num2 * num2 + num3 * num3)) / (2f * dev * dev));
	}
}
[ExecuteInEditMode]
[DefaultExecutionOrder(-102)]
public class NavMeshPrefabInstance : MonoBehaviour
{
	[SerializeField]
	private NavMeshData m_NavMesh;

	[SerializeField]
	private bool m_FollowTransform;

	private NavMeshDataInstance m_Instance;

	private static readonly List<NavMeshPrefabInstance> s_TrackedInstances = new List<NavMeshPrefabInstance>();

	private Vector3 m_Position;

	private Quaternion m_Rotation;

	public NavMeshData navMeshData
	{
		get
		{
			return m_NavMesh;
		}
		set
		{
			m_NavMesh = value;
		}
	}

	public bool followTransform
	{
		get
		{
			return m_FollowTransform;
		}
		set
		{
			SetFollowTransform(value);
		}
	}

	public static List<NavMeshPrefabInstance> trackedInstances => s_TrackedInstances;

	private void OnEnable()
	{
		AddInstance();
		if (m_Instance.valid && m_FollowTransform)
		{
			AddTracking();
		}
	}

	private void OnDisable()
	{
		m_Instance.Remove();
		RemoveTracking();
	}

	public void UpdateInstance()
	{
		m_Instance.Remove();
		AddInstance();
	}

	private void AddInstance()
	{
		if ((bool)m_NavMesh)
		{
			m_Instance = NavMesh.AddNavMeshData(m_NavMesh, base.transform.position, base.transform.rotation);
		}
		m_Rotation = base.transform.rotation;
		m_Position = base.transform.position;
	}

	private void AddTracking()
	{
		if (s_TrackedInstances.Count == 0)
		{
			NavMesh.onPreUpdate = (NavMesh.OnNavMeshPreUpdate)Delegate.Combine(NavMesh.onPreUpdate, new NavMesh.OnNavMeshPreUpdate(UpdateTrackedInstances));
		}
		s_TrackedInstances.Add(this);
	}

	private void RemoveTracking()
	{
		s_TrackedInstances.Remove(this);
		if (s_TrackedInstances.Count == 0)
		{
			NavMesh.onPreUpdate = (NavMesh.OnNavMeshPreUpdate)Delegate.Remove(NavMesh.onPreUpdate, new NavMesh.OnNavMeshPreUpdate(UpdateTrackedInstances));
		}
	}

	private void SetFollowTransform(bool value)
	{
		if (m_FollowTransform != value)
		{
			m_FollowTransform = value;
			if (value)
			{
				AddTracking();
			}
			else
			{
				RemoveTracking();
			}
		}
	}

	private bool HasMoved()
	{
		if (!(m_Position != base.transform.position))
		{
			return m_Rotation != base.transform.rotation;
		}
		return true;
	}

	private static void UpdateTrackedInstances()
	{
		foreach (NavMeshPrefabInstance s_TrackedInstance in s_TrackedInstances)
		{
			if (s_TrackedInstance.HasMoved())
			{
				s_TrackedInstance.UpdateInstance();
			}
		}
	}
}
[DefaultExecutionOrder(-200)]
public class NavMeshSourceTag : MonoBehaviour
{
	public static List<MeshFilter> m_Meshes = new List<MeshFilter>();

	public static List<Terrain> m_Terrains = new List<Terrain>();

	private void OnEnable()
	{
		MeshFilter component = GetComponent<MeshFilter>();
		if (component != null)
		{
			m_Meshes.Add(component);
		}
		Terrain component2 = GetComponent<Terrain>();
		if (component2 != null)
		{
			m_Terrains.Add(component2);
		}
	}

	private void OnDisable()
	{
		MeshFilter component = GetComponent<MeshFilter>();
		if (component != null)
		{
			m_Meshes.Remove(component);
		}
		Terrain component2 = GetComponent<Terrain>();
		if (component2 != null)
		{
			m_Terrains.Remove(component2);
		}
	}

	public static void Collect(ref List<NavMeshBuildSource> sources)
	{
		sources.Clear();
		for (int i = 0; i < m_Meshes.Count; i++)
		{
			MeshFilter meshFilter = m_Meshes[i];
			if (!(meshFilter == null))
			{
				Mesh sharedMesh = meshFilter.sharedMesh;
				if (!(sharedMesh == null))
				{
					NavMeshBuildSource item = default(NavMeshBuildSource);
					item.shape = NavMeshBuildSourceShape.Mesh;
					item.sourceObject = sharedMesh;
					item.transform = meshFilter.transform.localToWorldMatrix;
					item.area = 0;
					sources.Add(item);
				}
			}
		}
		for (int j = 0; j < m_Terrains.Count; j++)
		{
			Terrain terrain = m_Terrains[j];
			if (!(terrain == null))
			{
				NavMeshBuildSource item2 = default(NavMeshBuildSource);
				item2.shape = NavMeshBuildSourceShape.Terrain;
				item2.sourceObject = terrain.terrainData;
				item2.transform = Matrix4x4.TRS(terrain.transform.position, Quaternion.identity, Vector3.one);
				item2.area = 0;
				sources.Add(item2);
			}
		}
	}
}
public class Oscillator : MonoBehaviour
{
	public float m_Amplitude = 1f;

	public float m_Period = 1f;

	public Vector3 m_Direction = Vector3.up;

	private Vector3 m_StartPosition;

	private void Start()
	{
		m_StartPosition = base.transform.position;
	}

	private void Update()
	{
		Vector3 position = m_StartPosition + m_Direction * m_Amplitude * Mathf.Sin((float)Math.PI * 2f * Time.time / m_Period);
		base.transform.position = position;
	}
}
[DefaultExecutionOrder(-200)]
public class RandomInstancing : MonoBehaviour
{
	public GameObject m_Prefab;

	public int m_PoolSize = 250;

	public int m_InstancesPerTile = 10;

	public bool m_RandomPosition = true;

	public bool m_RandomOrientation = true;

	public float m_Height;

	public int m_BaseHash = 347652783;

	public float m_Size = 100f;

	private List<Transform> m_Instances = new List<Transform>();

	private int m_Seed;

	private int m_Used;

	private int m_LocX;

	private int m_LocZ;

	private void Awake()
	{
		for (int i = 0; i < m_PoolSize; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(m_Prefab, Vector3.zero, Quaternion.identity);
			m_Instances.Add(gameObject.transform);
		}
	}

	private void OnEnable()
	{
		m_LocX = -1;
		m_LocZ = -1;
		UpdateInstances();
	}

	private void OnDestroy()
	{
		for (int i = 0; i < m_Instances.Count; i++)
		{
			if ((bool)m_Instances[i])
			{
				UnityEngine.Object.DestroyObject(m_Instances[i].gameObject);
			}
		}
		m_Instances.Clear();
	}

	private void Update()
	{
		UpdateInstances();
	}

	private void UpdateInstances()
	{
		int num = (int)Mathf.Floor(base.transform.position.x / m_Size);
		int num2 = (int)Mathf.Floor(base.transform.position.z / m_Size);
		if (num == m_LocX && num2 == m_LocZ)
		{
			return;
		}
		m_LocX = num;
		m_LocZ = num2;
		m_Used = 0;
		for (int i = num - 2; i <= num + 2; i++)
		{
			for (int j = num2 - 2; j <= num2 + 2; j++)
			{
				if (m_Used >= m_PoolSize - 1)
				{
					return;
				}
				UpdateTileInstances(i, j);
			}
		}
	}

	private void UpdateTileInstances(int i, int j)
	{
		m_Seed = Hash2(i, j) ^ m_BaseHash;
		for (int k = 0; k < m_InstancesPerTile; k++)
		{
			float num = 0f;
			float num2 = 0f;
			if (m_RandomPosition)
			{
				num = Random();
				num2 = Random();
			}
			Vector3 position = new Vector3(((float)i + num) * m_Size, m_Height, ((float)j + num2) * m_Size);
			if (m_RandomOrientation)
			{
				float angle = 360f * Random();
				m_Instances[m_Used].rotation = Quaternion.AngleAxis(angle, Vector3.up);
			}
			m_Instances[m_Used].position = position;
			m_Used++;
		}
	}

	private static int Hash2(int i, int j)
	{
		return (i * 73856093) ^ (j * 19349663);
	}

	private float Random()
	{
		m_Seed ^= 123459876;
		int num = m_Seed / 127773;
		m_Seed = 16807 * (m_Seed - num * 127773) - 2836 * num;
		if (m_Seed < 0)
		{
			m_Seed += int.MaxValue;
		}
		float result = (float)m_Seed * 1f / 2.1474836E+09f;
		m_Seed ^= 123459876;
		return result;
	}
}
[RequireComponent(typeof(NavMeshAgent))]
public class RandomWalk : MonoBehaviour
{
	public float m_Range = 25f;

	private NavMeshAgent m_agent;

	private void Start()
	{
		m_agent = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		if (!m_agent.pathPending && !(m_agent.remainingDistance > 0.1f))
		{
			m_agent.destination = m_Range * UnityEngine.Random.insideUnitCircle;
		}
	}
}
public class SpawnPrefabOnKeyDown : MonoBehaviour
{
	public GameObject m_Prefab;

	public KeyCode m_KeyCode;

	private void Update()
	{
		if (Input.GetKeyDown(m_KeyCode) && m_Prefab != null)
		{
			UnityEngine.Object.Instantiate(m_Prefab, base.transform.position, base.transform.rotation);
		}
	}
}
public class OvrFMODGlobalSettings : MonoBehaviour
{
	public const string strOSP = "ovrfmod";

	[SerializeField]
	private bool bypass;

	[SerializeField]
	private float globalScale = 1f;

	[SerializeField]
	private float gain;

	private bool dirtyReflection;

	[SerializeField]
	private bool enableReflections = true;

	[SerializeField]
	private bool enableReverb;

	[SerializeField]
	private Vector3 dimensions = new Vector3(8f, 2.5f, 5f);

	[SerializeField]
	private Vector2 reflectionLeftRight = new Vector2(0.75f, 0.75f);

	[SerializeField]
	private Vector2 reflectionUpDown = new Vector2(0.85f, 0.25f);

	[SerializeField]
	private Vector2 reflectionFrontBack = new Vector2(0.75f, 0.75f);

	public bool Bypass
	{
		get
		{
			return bypass;
		}
		set
		{
			bypass = value;
			OSP_FMOD_SetBypass(bypass);
		}
	}

	public float GlobalScale
	{
		get
		{
			return globalScale;
		}
		set
		{
			globalScale = Mathf.Clamp(value, 1E-05f, 10000f);
			OSP_FMOD_SetGlobalScale(globalScale);
		}
	}

	public float Gain
	{
		get
		{
			return gain;
		}
		set
		{
			gain = Mathf.Clamp(value, -24f, 24f);
			OSP_FMOD_SetGain(gain);
		}
	}

	public bool EnableReflections
	{
		get
		{
			return enableReflections;
		}
		set
		{
			enableReflections = value;
			dirtyReflection = true;
		}
	}

	public bool EnableReverb
	{
		get
		{
			return enableReverb;
		}
		set
		{
			enableReverb = value;
			dirtyReflection = true;
		}
	}

	public Vector3 Dimensions
	{
		get
		{
			return dimensions;
		}
		set
		{
			dimensions = value;
			dimensions.x = Mathf.Clamp(dimensions.x, 0f, 230f);
			dimensions.y = Mathf.Clamp(dimensions.y, 0f, 230f);
			dimensions.z = Mathf.Clamp(dimensions.z, 0f, 230f);
			dirtyReflection = true;
		}
	}

	public Vector2 ReflectionLeftRight
	{
		get
		{
			return reflectionLeftRight;
		}
		set
		{
			reflectionLeftRight = value;
			reflectionLeftRight.x = Mathf.Clamp(reflectionLeftRight.x, 0f, 0.95f);
			reflectionLeftRight.y = Mathf.Clamp(reflectionLeftRight.y, 0f, 0.95f);
			dirtyReflection = true;
		}
	}

	public Vector2 ReflectionUpDown
	{
		get
		{
			return reflectionUpDown;
		}
		set
		{
			reflectionUpDown = value;
			reflectionUpDown.x = Mathf.Clamp(reflectionUpDown.x, 0f, 0.95f);
			reflectionUpDown.y = Mathf.Clamp(reflectionUpDown.y, 0f, 0.95f);
			dirtyReflection = true;
		}
	}

	public Vector2 ReflectionFrontBack
	{
		get
		{
			return reflectionFrontBack;
		}
		set
		{
			reflectionFrontBack = value;
			reflectionFrontBack.x = Mathf.Clamp(reflectionFrontBack.x, 0f, 0.95f);
			reflectionFrontBack.y = Mathf.Clamp(reflectionFrontBack.y, 0f, 0.95f);
			dirtyReflection = true;
		}
	}

	[DllImport("ovrfmod")]
	private static extern bool OSP_FMOD_Initialize(int SampleRate, int BufferLength);

	[DllImport("ovrfmod")]
	private static extern bool OSP_FMOD_SetBypass(bool Enabled);

	[DllImport("ovrfmod")]
	private static extern bool OSP_FMOD_SetGain(float Gain_dB);

	[DllImport("ovrfmod")]
	private static extern bool OSP_FMOD_SetGlobalScale(float Scale);

	[DllImport("ovrfmod")]
	private static extern bool OSP_FMOD_SetEarlyReflectionsEnabled(bool Enabled);

	[DllImport("ovrfmod")]
	private static extern bool OSP_FMOD_SetLateReverberationEnabled(bool Enabled);

	[DllImport("ovrfmod")]
	private static extern bool OSP_FMOD_SetSimpleBoxRoomParameters(float Width, float Height, float Depth, float RefLeft, float RefRight, float RefUp, float RefDown, float RefBehind, float RefFront);

	private void Start()
	{
		FMOD.System lowlevelSystem = RuntimeManager.LowlevelSystem;
		RESULT rESULT = RESULT.OK;
		int samplerate = 0;
		int numrawspeakers = 0;
		rESULT = lowlevelSystem.getSoftwareFormat(out samplerate, out var _, out numrawspeakers);
		if (rESULT != 0)
		{
			UnityEngine.Debug.LogError("OVRA FMOD: Error retreiving state from FMOD: " + rESULT);
		}
		uint bufferlength = 0u;
		int numbuffers = 0;
		rESULT = lowlevelSystem.getDSPBufferSize(out bufferlength, out numbuffers);
		if (rESULT != 0)
		{
			UnityEngine.Debug.LogError("OVRA FMOD: Error retreiving state from FMOD: " + rESULT);
		}
		OSP_FMOD_Initialize(samplerate, (int)bufferlength);
		OSP_FMOD_SetBypass(bypass);
		OSP_FMOD_SetGlobalScale(globalScale);
		OSP_FMOD_SetGain(gain);
		UpdateReflections();
	}

	private void Update()
	{
		if (dirtyReflection)
		{
			UpdateReflections();
		}
	}

	private void UpdateReflections()
	{
		OSP_FMOD_SetSimpleBoxRoomParameters(dimensions.x, dimensions.y, dimensions.z, reflectionLeftRight.x, reflectionLeftRight.y, reflectionUpDown.x, reflectionUpDown.y, reflectionFrontBack.x, reflectionFrontBack.y);
		OSP_FMOD_SetLateReverberationEnabled(enableReverb);
		OSP_FMOD_SetEarlyReflectionsEnabled(enableReflections);
		dirtyReflection = false;
	}
}
[RequireComponent(typeof(Camera))]
public class EnableCameraDepthInForward : MonoBehaviour
{
	private void Start()
	{
		Set();
	}

	private void Set()
	{
		if (GetComponent<Camera>().depthTextureMode == DepthTextureMode.None)
		{
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
		}
	}
}
[RequireComponent(typeof(MeshFilter))]
public class SoftNormalsToVertexColor : MonoBehaviour
{
	public enum Method
	{
		Simple,
		AngularDeviation
	}

	public Method method = Method.AngularDeviation;

	public bool generateOnAwake;

	public bool generateNow;

	private void OnDrawGizmos()
	{
		if (generateNow)
		{
			generateNow = false;
			TryGenerate();
		}
	}

	private void Awake()
	{
		if (generateOnAwake)
		{
			TryGenerate();
		}
	}

	private void TryGenerate()
	{
		MeshFilter component = GetComponent<MeshFilter>();
		if (component == null)
		{
			UnityEngine.Debug.LogError("MeshFilter missing on the vertex color generator", base.gameObject);
			return;
		}
		if (component.sharedMesh == null)
		{
			UnityEngine.Debug.LogError("Assign a mesh to the MeshFilter before generating vertex colors", base.gameObject);
			return;
		}
		Generate(component.sharedMesh);
		UnityEngine.Debug.Log("Vertex colors generated", base.gameObject);
	}

	private void Generate(Mesh m)
	{
		Vector3[] normals = m.normals;
		Vector3[] vertices = m.vertices;
		Color[] array = new Color[normals.Length];
		List<List<int>> list = new List<List<int>>();
		for (int i = 0; i < vertices.Length; i++)
		{
			bool flag = false;
			foreach (List<int> item in list)
			{
				if (vertices[item[0]] == vertices[i])
				{
					item.Add(i);
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				List<int> list2 = new List<int>();
				list2.Add(i);
				list.Add(list2);
			}
		}
		foreach (List<int> item2 in list)
		{
			Vector3 zero = Vector3.zero;
			foreach (int item3 in item2)
			{
				zero += normals[item3];
			}
			zero.Normalize();
			if (method == Method.AngularDeviation)
			{
				float num = 0f;
				foreach (int item4 in item2)
				{
					num += Vector3.Dot(normals[item4], zero);
				}
				num /= (float)item2.Count;
				float num2 = Mathf.Acos(num) * 57.29578f;
				float num3 = 180f - num2 - 90f;
				float num4 = 0.5f / Mathf.Sin(num3 * ((float)Math.PI / 180f));
				zero *= num4;
			}
			foreach (int item5 in item2)
			{
				array[item5] = new Color(zero.x, zero.y, zero.z);
			}
		}
		m.colors = array;
	}
}
[ExecuteInEditMode]
public class Water : MonoBehaviour
{
	public enum WaterMode
	{
		Simple,
		Reflective,
		Refractive
	}

	public WaterMode m_WaterMode = WaterMode.Refractive;

	public bool m_DisablePixelLights = true;

	public int m_TextureSize = 256;

	public float m_ClipPlaneOffset = 0.07f;

	public LayerMask m_ReflectLayers = -1;

	public LayerMask m_RefractLayers = -1;

	private Dictionary<Camera, Camera> m_ReflectionCameras = new Dictionary<Camera, Camera>();

	private Dictionary<Camera, Camera> m_RefractionCameras = new Dictionary<Camera, Camera>();

	private RenderTexture m_ReflectionTexture;

	private RenderTexture m_RefractionTexture;

	private WaterMode m_HardwareWaterSupport = WaterMode.Refractive;

	private int m_OldReflectionTextureSize;

	private int m_OldRefractionTextureSize;

	private static bool s_InsideWater;

	public void OnWillRenderObject()
	{
		if (!base.enabled || !GetComponent<Renderer>() || !GetComponent<Renderer>().sharedMaterial || !GetComponent<Renderer>().enabled)
		{
			return;
		}
		Camera current = Camera.current;
		if ((bool)current && !s_InsideWater)
		{
			s_InsideWater = true;
			m_HardwareWaterSupport = FindHardwareWaterSupport();
			WaterMode waterMode = GetWaterMode();
			CreateWaterObjects(current, out var reflectionCamera, out var refractionCamera);
			Vector3 position = base.transform.position;
			Vector3 up = base.transform.up;
			int pixelLightCount = QualitySettings.pixelLightCount;
			if (m_DisablePixelLights)
			{
				QualitySettings.pixelLightCount = 0;
			}
			UpdateCameraModes(current, reflectionCamera);
			UpdateCameraModes(current, refractionCamera);
			if (waterMode >= WaterMode.Reflective)
			{
				float w = 0f - Vector3.Dot(up, position) - m_ClipPlaneOffset;
				Vector4 plane = new Vector4(up.x, up.y, up.z, w);
				Matrix4x4 reflectionMat = Matrix4x4.zero;
				CalculateReflectionMatrix(ref reflectionMat, plane);
				Vector3 position2 = current.transform.position;
				Vector3 position3 = reflectionMat.MultiplyPoint(position2);
				reflectionCamera.worldToCameraMatrix = current.worldToCameraMatrix * reflectionMat;
				Vector4 clipPlane = CameraSpacePlane(reflectionCamera, position, up, 1f);
				reflectionCamera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
				reflectionCamera.cullingMask = -17 & m_ReflectLayers.value;
				reflectionCamera.targetTexture = m_ReflectionTexture;
				GL.SetRevertBackfacing(revertBackFaces: true);
				reflectionCamera.transform.position = position3;
				Vector3 eulerAngles = current.transform.eulerAngles;
				reflectionCamera.transform.eulerAngles = new Vector3(0f - eulerAngles.x, eulerAngles.y, eulerAngles.z);
				reflectionCamera.Render();
				reflectionCamera.transform.position = position2;
				GL.SetRevertBackfacing(revertBackFaces: false);
				GetComponent<Renderer>().sharedMaterial.SetTexture("_ReflectionTex", m_ReflectionTexture);
			}
			if (waterMode >= WaterMode.Refractive)
			{
				refractionCamera.worldToCameraMatrix = current.worldToCameraMatrix;
				Vector4 clipPlane2 = CameraSpacePlane(refractionCamera, position, up, -1f);
				refractionCamera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
				refractionCamera.cullingMask = -17 & m_RefractLayers.value;
				refractionCamera.targetTexture = m_RefractionTexture;
				refractionCamera.transform.position = current.transform.position;
				refractionCamera.transform.rotation = current.transform.rotation;
				refractionCamera.Render();
				GetComponent<Renderer>().sharedMaterial.SetTexture("_RefractionTex", m_RefractionTexture);
			}
			if (m_DisablePixelLights)
			{
				QualitySettings.pixelLightCount = pixelLightCount;
			}
			switch (waterMode)
			{
			case WaterMode.Simple:
				Shader.EnableKeyword("WATER_SIMPLE");
				Shader.DisableKeyword("WATER_REFLECTIVE");
				Shader.DisableKeyword("WATER_REFRACTIVE");
				break;
			case WaterMode.Reflective:
				Shader.DisableKeyword("WATER_SIMPLE");
				Shader.EnableKeyword("WATER_REFLECTIVE");
				Shader.DisableKeyword("WATER_REFRACTIVE");
				break;
			case WaterMode.Refractive:
				Shader.DisableKeyword("WATER_SIMPLE");
				Shader.DisableKeyword("WATER_REFLECTIVE");
				Shader.EnableKeyword("WATER_REFRACTIVE");
				break;
			}
			s_InsideWater = false;
		}
	}

	private void OnDisable()
	{
		if ((bool)m_ReflectionTexture)
		{
			UnityEngine.Object.DestroyImmediate(m_ReflectionTexture);
			m_ReflectionTexture = null;
		}
		if ((bool)m_RefractionTexture)
		{
			UnityEngine.Object.DestroyImmediate(m_RefractionTexture);
			m_RefractionTexture = null;
		}
		foreach (KeyValuePair<Camera, Camera> reflectionCamera in m_ReflectionCameras)
		{
			UnityEngine.Object.DestroyImmediate(reflectionCamera.Value.gameObject);
		}
		m_ReflectionCameras.Clear();
		foreach (KeyValuePair<Camera, Camera> refractionCamera in m_RefractionCameras)
		{
			UnityEngine.Object.DestroyImmediate(refractionCamera.Value.gameObject);
		}
		m_RefractionCameras.Clear();
	}

	private void Update()
	{
		if ((bool)GetComponent<Renderer>())
		{
			Material sharedMaterial = GetComponent<Renderer>().sharedMaterial;
			if ((bool)sharedMaterial)
			{
				Vector4 vector = sharedMaterial.GetVector("WaveSpeed");
				float @float = sharedMaterial.GetFloat("_WaveScale");
				Vector4 value = new Vector4(@float, @float, @float * 0.4f, @float * 0.45f);
				double num = (double)Time.timeSinceLevelLoad / 20.0;
				Vector4 value2 = new Vector4((float)Math.IEEERemainder((double)(vector.x * value.x) * num, 1.0), (float)Math.IEEERemainder((double)(vector.y * value.y) * num, 1.0), (float)Math.IEEERemainder((double)(vector.z * value.z) * num, 1.0), (float)Math.IEEERemainder((double)(vector.w * value.w) * num, 1.0));
				sharedMaterial.SetVector("_WaveOffset", value2);
				sharedMaterial.SetVector("_WaveScale4", value);
				Vector3 size = GetComponent<Renderer>().bounds.size;
				Matrix4x4 value3 = Matrix4x4.TRS(s: new Vector3(size.x * value.x, size.z * value.y, 1f), pos: new Vector3(value2.x, value2.y, 0f), q: Quaternion.identity);
				sharedMaterial.SetMatrix("_WaveMatrix", value3);
				value3 = Matrix4x4.TRS(s: new Vector3(size.x * value.z, size.z * value.w, 1f), pos: new Vector3(value2.z, value2.w, 0f), q: Quaternion.identity);
				sharedMaterial.SetMatrix("_WaveMatrix2", value3);
			}
		}
	}

	private void UpdateCameraModes(Camera src, Camera dest)
	{
		if (dest == null)
		{
			return;
		}
		dest.clearFlags = src.clearFlags;
		dest.backgroundColor = src.backgroundColor;
		if (src.clearFlags == CameraClearFlags.Skybox)
		{
			Skybox skybox = src.GetComponent(typeof(Skybox)) as Skybox;
			Skybox skybox2 = dest.GetComponent(typeof(Skybox)) as Skybox;
			if (!skybox || !skybox.material)
			{
				skybox2.enabled = false;
			}
			else
			{
				skybox2.enabled = true;
				skybox2.material = skybox.material;
			}
		}
		dest.farClipPlane = src.farClipPlane;
		dest.nearClipPlane = src.nearClipPlane;
		dest.orthographic = src.orthographic;
		dest.fieldOfView = src.fieldOfView;
		dest.aspect = src.aspect;
		dest.orthographicSize = src.orthographicSize;
	}

	private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
	{
		WaterMode waterMode = GetWaterMode();
		reflectionCamera = null;
		refractionCamera = null;
		if (waterMode >= WaterMode.Reflective)
		{
			if (!m_ReflectionTexture || m_OldReflectionTextureSize != m_TextureSize)
			{
				if ((bool)m_ReflectionTexture)
				{
					UnityEngine.Object.DestroyImmediate(m_ReflectionTexture);
				}
				m_ReflectionTexture = new RenderTexture(m_TextureSize, m_TextureSize, 16);
				m_ReflectionTexture.name = "__WaterReflection" + GetInstanceID();
				m_ReflectionTexture.isPowerOfTwo = true;
				m_ReflectionTexture.hideFlags = HideFlags.DontSave;
				m_OldReflectionTextureSize = m_TextureSize;
			}
			m_ReflectionCameras.TryGetValue(currentCamera, out reflectionCamera);
			if (!reflectionCamera)
			{
				GameObject gameObject = new GameObject("Water Refl Camera id" + GetInstanceID() + " for " + currentCamera.GetInstanceID(), typeof(Camera), typeof(Skybox));
				reflectionCamera = gameObject.GetComponent<Camera>();
				reflectionCamera.enabled = false;
				reflectionCamera.transform.position = base.transform.position;
				reflectionCamera.transform.rotation = base.transform.rotation;
				gameObject.hideFlags = HideFlags.HideAndDontSave;
				m_ReflectionCameras[currentCamera] = reflectionCamera;
			}
		}
		if (waterMode < WaterMode.Refractive)
		{
			return;
		}
		if (!m_RefractionTexture || m_OldRefractionTextureSize != m_TextureSize)
		{
			if ((bool)m_RefractionTexture)
			{
				UnityEngine.Object.DestroyImmediate(m_RefractionTexture);
			}
			m_RefractionTexture = new RenderTexture(m_TextureSize, m_TextureSize, 16);
			m_RefractionTexture.name = "__WaterRefraction" + GetInstanceID();
			m_RefractionTexture.isPowerOfTwo = true;
			m_RefractionTexture.hideFlags = HideFlags.DontSave;
			m_OldRefractionTextureSize = m_TextureSize;
		}
		m_RefractionCameras.TryGetValue(currentCamera, out refractionCamera);
		if (!refractionCamera)
		{
			GameObject gameObject2 = new GameObject("Water Refr Camera id" + GetInstanceID() + " for " + currentCamera.GetInstanceID(), typeof(Camera), typeof(Skybox));
			refractionCamera = gameObject2.GetComponent<Camera>();
			refractionCamera.enabled = false;
			refractionCamera.transform.position = base.transform.position;
			refractionCamera.transform.rotation = base.transform.rotation;
			gameObject2.hideFlags = HideFlags.HideAndDontSave;
			m_RefractionCameras[currentCamera] = refractionCamera;
		}
	}

	private WaterMode GetWaterMode()
	{
		if (m_HardwareWaterSupport < m_WaterMode)
		{
			return m_HardwareWaterSupport;
		}
		return m_WaterMode;
	}

	private WaterMode FindHardwareWaterSupport()
	{
		if (!GetComponent<Renderer>())
		{
			return WaterMode.Simple;
		}
		Material sharedMaterial = GetComponent<Renderer>().sharedMaterial;
		if (!sharedMaterial)
		{
			return WaterMode.Simple;
		}
		string text = sharedMaterial.GetTag("WATERMODE", searchFallbacks: false);
		if (text == "Refractive")
		{
			return WaterMode.Refractive;
		}
		if (text == "Reflective")
		{
			return WaterMode.Reflective;
		}
		return WaterMode.Simple;
	}

	private static float sgn(float a)
	{
		if (a > 0f)
		{
			return 1f;
		}
		if (a < 0f)
		{
			return -1f;
		}
		return 0f;
	}

	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		Vector3 point = pos + normal * m_ClipPlaneOffset;
		Matrix4x4 worldToCameraMatrix = cam.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(normal).normalized * sideSign;
		return new Vector4(rhs.x, rhs.y, rhs.z, 0f - Vector3.Dot(lhs, rhs));
	}

	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
		reflectionMat.m00 = 1f - 2f * plane[0] * plane[0];
		reflectionMat.m01 = -2f * plane[0] * plane[1];
		reflectionMat.m02 = -2f * plane[0] * plane[2];
		reflectionMat.m03 = -2f * plane[3] * plane[0];
		reflectionMat.m10 = -2f * plane[1] * plane[0];
		reflectionMat.m11 = 1f - 2f * plane[1] * plane[1];
		reflectionMat.m12 = -2f * plane[1] * plane[2];
		reflectionMat.m13 = -2f * plane[3] * plane[1];
		reflectionMat.m20 = -2f * plane[2] * plane[0];
		reflectionMat.m21 = -2f * plane[2] * plane[1];
		reflectionMat.m22 = 1f - 2f * plane[2] * plane[2];
		reflectionMat.m23 = -2f * plane[3] * plane[2];
		reflectionMat.m30 = 0f;
		reflectionMat.m31 = 0f;
		reflectionMat.m32 = 0f;
		reflectionMat.m33 = 1f;
	}
}
[ExecuteInEditMode]
[RequireComponent(typeof(WaterBase))]
public class Displace : MonoBehaviour
{
	public void Awake()
	{
		if (base.enabled)
		{
			OnEnable();
		}
		else
		{
			OnDisable();
		}
	}

	public void OnEnable()
	{
		Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
		Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
	}

	public void OnDisable()
	{
		Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_OFF");
		Shader.DisableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
	}
}
[ExecuteInEditMode]
[RequireComponent(typeof(WaterBase))]
public class GerstnerDisplace : Displace
{
}
public class MeshContainer
{
	public Mesh mesh;

	public Vector3[] vertices;

	public Vector3[] normals;

	public MeshContainer(Mesh m)
	{
		mesh = m;
		vertices = m.vertices;
		normals = m.normals;
	}

	public void Update()
	{
		mesh.vertices = vertices;
		mesh.normals = normals;
	}
}
[ExecuteInEditMode]
[RequireComponent(typeof(WaterBase))]
public class PlanarReflection : MonoBehaviour
{
	public LayerMask reflectionMask;

	public bool reflectSkybox;

	public Color clearColor = Color.grey;

	public string reflectionSampler = "_ReflectionTex";

	public float clipPlaneOffset = 0.07f;

	private Vector3 oldpos = Vector3.zero;

	private Camera reflectionCamera;

	private Material sharedMaterial;

	private Dictionary<Camera, bool> helperCameras;

	public void Start()
	{
		sharedMaterial = ((WaterBase)base.gameObject.GetComponent(typeof(WaterBase))).sharedMaterial;
	}

	private Camera CreateReflectionCameraFor(Camera cam)
	{
		string text = base.gameObject.name + "Reflection" + cam.name;
		GameObject gameObject = GameObject.Find(text);
		if (!gameObject)
		{
			gameObject = new GameObject(text, typeof(Camera));
		}
		if (!gameObject.GetComponent(typeof(Camera)))
		{
			gameObject.AddComponent(typeof(Camera));
		}
		Camera component = gameObject.GetComponent<Camera>();
		component.backgroundColor = clearColor;
		component.clearFlags = (reflectSkybox ? CameraClearFlags.Skybox : CameraClearFlags.Color);
		SetStandardCameraParameter(component, reflectionMask);
		if (!component.targetTexture)
		{
			component.targetTexture = CreateTextureFor(cam);
		}
		return component;
	}

	private void SetStandardCameraParameter(Camera cam, LayerMask mask)
	{
		cam.cullingMask = (int)mask & ~(1 << LayerMask.NameToLayer("Water"));
		cam.backgroundColor = Color.black;
		cam.enabled = false;
	}

	private RenderTexture CreateTextureFor(Camera cam)
	{
		return new RenderTexture(Mathf.FloorToInt((float)cam.pixelWidth * 0.5f), Mathf.FloorToInt((float)cam.pixelHeight * 0.5f), 24)
		{
			hideFlags = HideFlags.DontSave
		};
	}

	public void RenderHelpCameras(Camera currentCam)
	{
		if (helperCameras == null)
		{
			helperCameras = new Dictionary<Camera, bool>();
		}
		if (!helperCameras.ContainsKey(currentCam))
		{
			helperCameras.Add(currentCam, value: false);
		}
		if (!helperCameras[currentCam])
		{
			if (!reflectionCamera)
			{
				reflectionCamera = CreateReflectionCameraFor(currentCam);
			}
			RenderReflectionFor(currentCam, reflectionCamera);
			helperCameras[currentCam] = true;
		}
	}

	public void LateUpdate()
	{
		if (helperCameras != null)
		{
			helperCameras.Clear();
		}
	}

	public void WaterTileBeingRendered(Transform tr, Camera currentCam)
	{
		RenderHelpCameras(currentCam);
		if ((bool)reflectionCamera && (bool)sharedMaterial)
		{
			sharedMaterial.SetTexture(reflectionSampler, reflectionCamera.targetTexture);
		}
	}

	public void OnEnable()
	{
		Shader.EnableKeyword("WATER_REFLECTIVE");
		Shader.DisableKeyword("WATER_SIMPLE");
	}

	public void OnDisable()
	{
		Shader.EnableKeyword("WATER_SIMPLE");
		Shader.DisableKeyword("WATER_REFLECTIVE");
	}

	private void RenderReflectionFor(Camera cam, Camera reflectCamera)
	{
		if (!reflectCamera || ((bool)sharedMaterial && !sharedMaterial.HasProperty(reflectionSampler)))
		{
			return;
		}
		reflectCamera.cullingMask = (int)reflectionMask & ~(1 << LayerMask.NameToLayer("Water"));
		SaneCameraSettings(reflectCamera);
		reflectCamera.backgroundColor = clearColor;
		reflectCamera.clearFlags = (reflectSkybox ? CameraClearFlags.Skybox : CameraClearFlags.Color);
		if (reflectSkybox && (bool)cam.gameObject.GetComponent(typeof(Skybox)))
		{
			Skybox skybox = (Skybox)reflectCamera.gameObject.GetComponent(typeof(Skybox));
			if (!skybox)
			{
				skybox = (Skybox)reflectCamera.gameObject.AddComponent(typeof(Skybox));
			}
			skybox.material = ((Skybox)cam.GetComponent(typeof(Skybox))).material;
		}
		GL.SetRevertBackfacing(revertBackFaces: true);
		Transform transform = base.transform;
		Vector3 eulerAngles = cam.transform.eulerAngles;
		reflectCamera.transform.eulerAngles = new Vector3(0f - eulerAngles.x, eulerAngles.y, eulerAngles.z);
		reflectCamera.transform.position = cam.transform.position;
		Vector3 position = transform.transform.position;
		position.y = transform.position.y;
		Vector3 up = transform.transform.up;
		float w = 0f - Vector3.Dot(up, position) - clipPlaneOffset;
		Vector4 plane = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 zero = Matrix4x4.zero;
		zero = CalculateReflectionMatrix(zero, plane);
		oldpos = cam.transform.position;
		Vector3 position2 = zero.MultiplyPoint(oldpos);
		reflectCamera.worldToCameraMatrix = cam.worldToCameraMatrix * zero;
		Vector4 clipPlane = CameraSpacePlane(reflectCamera, position, up, 1f);
		reflectCamera.projectionMatrix = cam.CalculateObliqueMatrix(clipPlane);
		reflectCamera.transform.position = position2;
		Vector3 eulerAngles2 = cam.transform.eulerAngles;
		reflectCamera.transform.eulerAngles = new Vector3(0f - eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
		reflectCamera.Render();
		GL.SetRevertBackfacing(revertBackFaces: false);
	}

	private void SaneCameraSettings(Camera helperCam)
	{
		helperCam.depthTextureMode = DepthTextureMode.None;
		helperCam.backgroundColor = Color.black;
		helperCam.clearFlags = CameraClearFlags.Color;
		helperCam.renderingPath = RenderingPath.Forward;
	}

	private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
	{
		reflectionMat.m00 = 1f - 2f * plane[0] * plane[0];
		reflectionMat.m01 = -2f * plane[0] * plane[1];
		reflectionMat.m02 = -2f * plane[0] * plane[2];
		reflectionMat.m03 = -2f * plane[3] * plane[0];
		reflectionMat.m10 = -2f * plane[1] * plane[0];
		reflectionMat.m11 = 1f - 2f * plane[1] * plane[1];
		reflectionMat.m12 = -2f * plane[1] * plane[2];
		reflectionMat.m13 = -2f * plane[3] * plane[1];
		reflectionMat.m20 = -2f * plane[2] * plane[0];
		reflectionMat.m21 = -2f * plane[2] * plane[1];
		reflectionMat.m22 = 1f - 2f * plane[2] * plane[2];
		reflectionMat.m23 = -2f * plane[3] * plane[2];
		reflectionMat.m30 = 0f;
		reflectionMat.m31 = 0f;
		reflectionMat.m32 = 0f;
		reflectionMat.m33 = 1f;
		return reflectionMat;
	}

	private static float sgn(float a)
	{
		if (a > 0f)
		{
			return 1f;
		}
		if (a < 0f)
		{
			return -1f;
		}
		return 0f;
	}

	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		Vector3 point = pos + normal * clipPlaneOffset;
		Matrix4x4 worldToCameraMatrix = cam.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 rhs = worldToCameraMatrix.MultiplyVector(normal).normalized * sideSign;
		return new Vector4(rhs.x, rhs.y, rhs.z, 0f - Vector3.Dot(lhs, rhs));
	}
}
[RequireComponent(typeof(WaterBase))]
[ExecuteInEditMode]
public class SpecularLighting : MonoBehaviour
{
	public Transform specularLight;

	private WaterBase waterBase;

	public void Start()
	{
		waterBase = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
	}

	public void Update()
	{
		if (!waterBase)
		{
			waterBase = (WaterBase)base.gameObject.GetComponent(typeof(WaterBase));
		}
		if ((bool)specularLight && (bool)waterBase.sharedMaterial)
		{
			waterBase.sharedMaterial.SetVector("_WorldLightDir", specularLight.transform.forward);
		}
	}
}
public enum WaterQuality
{
	High = 2,
	Medium = 1,
	Low = 0
}
[ExecuteInEditMode]
public class WaterBase : MonoBehaviour
{
	public Material sharedMaterial;

	public WaterQuality waterQuality = WaterQuality.High;

	public bool edgeBlend = true;

	public void UpdateShader()
	{
		if (waterQuality > WaterQuality.Medium)
		{
			sharedMaterial.shader.maximumLOD = 501;
		}
		else if (waterQuality > WaterQuality.Low)
		{
			sharedMaterial.shader.maximumLOD = 301;
		}
		else
		{
			sharedMaterial.shader.maximumLOD = 201;
		}
		if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			edgeBlend = false;
		}
		if (edgeBlend)
		{
			Shader.EnableKeyword("WATER_EDGEBLEND_ON");
			Shader.DisableKeyword("WATER_EDGEBLEND_OFF");
			if ((bool)Camera.main)
			{
				Camera.main.depthTextureMode |= DepthTextureMode.Depth;
			}
		}
		else
		{
			Shader.EnableKeyword("WATER_EDGEBLEND_OFF");
			Shader.DisableKeyword("WATER_EDGEBLEND_ON");
		}
	}

	public void WaterTileBeingRendered(Transform tr, Camera currentCam)
	{
		if ((bool)currentCam && edgeBlend)
		{
			currentCam.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	public void Update()
	{
		if ((bool)sharedMaterial)
		{
			UpdateShader();
		}
	}
}
[ExecuteInEditMode]
public class WaterTile : MonoBehaviour
{
	public PlanarReflection reflection;

	public WaterBase waterBase;

	public void Start()
	{
		AcquireComponents();
	}

	private void AcquireComponents()
	{
		if (!reflection)
		{
			if ((bool)base.transform.parent)
			{
				reflection = base.transform.parent.GetComponent<PlanarReflection>();
			}
			else
			{
				reflection = base.transform.GetComponent<PlanarReflection>();
			}
		}
		if (!waterBase)
		{
			if ((bool)base.transform.parent)
			{
				waterBase = base.transform.parent.GetComponent<WaterBase>();
			}
			else
			{
				waterBase = base.transform.GetComponent<WaterBase>();
			}
		}
	}

	public void OnWillRenderObject()
	{
		if ((bool)reflection)
		{
			reflection.WaterTileBeingRendered(base.transform, Camera.current);
		}
		if ((bool)waterBase)
		{
			waterBase.WaterTileBeingRendered(base.transform, Camera.current);
		}
	}
}
[ExecuteInEditMode]
public class BoxVolume : VolumetricObjectBase
{
	public Vector3 boxSize = Vector3.one * 5f;

	private Vector3 previousBoxSize = Vector3.one;

	protected override void OnEnable()
	{
		if (volumeShader == "")
		{
			PopulateShaderName();
		}
		base.OnEnable();
	}

	public override void PopulateShaderName()
	{
		volumeShader = "Advanced SS/Volumetric/Box Volume";
	}

	public override bool HasChanged()
	{
		if (boxSize != previousBoxSize || base.HasChanged())
		{
			return true;
		}
		return false;
	}

	protected override void SetChangedValues()
	{
		previousBoxSize = boxSize;
		base.SetChangedValues();
	}

	public override void UpdateVolume()
	{
		Vector3 vector = boxSize * 0.5f;
		if ((bool)meshInstance)
		{
			ScaleMesh(meshInstance, boxSize);
			Bounds bounds = default(Bounds);
			bounds.SetMinMax(-vector, vector);
			meshInstance.bounds = bounds;
		}
		if ((bool)materialInstance)
		{
			materialInstance.SetVector("_BoxMin", new Vector4(0f - vector.x, 0f - vector.y, 0f - vector.z, 0f));
			materialInstance.SetVector("_BoxMax", new Vector4(vector.x, vector.y, vector.z, 0f));
			materialInstance.SetVector("_TextureData", new Vector4(0f - textureMovement.x, 0f - textureMovement.y, 0f - textureMovement.z, 1f / textureScale));
			materialInstance.SetFloat("_Visibility", visibility);
			materialInstance.SetColor("_Color", volumeColor);
			materialInstance.SetTexture("_MainTex", texture);
		}
	}
}
[ExecuteInEditMode]
public class ConeVolume : VolumetricObjectBase
{
	public float coneHeight = 2f;

	public float coneAngle = 30f;

	public float startOffset;

	private float previousConeHeight;

	private float previousConeAngle;

	private float previousStartOffset;

	protected override void OnEnable()
	{
		if (volumeShader == "")
		{
			PopulateShaderName();
		}
		base.OnEnable();
	}

	public override void PopulateShaderName()
	{
		volumeShader = "Advanced SS/Volumetric/Cone Volume";
	}

	public override bool HasChanged()
	{
		if (coneHeight != previousConeHeight || coneAngle != previousConeAngle || startOffset != previousStartOffset || base.HasChanged())
		{
			return true;
		}
		return false;
	}

	protected override void SetChangedValues()
	{
		if (coneHeight < 0f)
		{
			coneHeight = 0f;
		}
		if (coneAngle >= 89f)
		{
			coneAngle = 89f;
		}
		previousConeHeight = coneHeight;
		previousConeAngle = coneAngle;
		previousStartOffset = startOffset;
		base.SetChangedValues();
	}

	public override void UpdateVolume()
	{
		float f = coneAngle * ((float)Math.PI / 180f);
		float num = Mathf.Tan(f) * coneHeight;
		float x = num * 0.5f;
		Vector3 vector = new Vector3(num, coneHeight, num);
		if ((bool)meshInstance)
		{
			ScaleMesh(meshInstance, vector, -Vector3.up * coneHeight * 0.5f);
			Bounds bounds = default(Bounds);
			bounds.SetMinMax(-vector, vector);
			meshInstance.bounds = bounds;
		}
		if ((bool)materialInstance)
		{
			materialInstance.SetVector("_ConeData", new Vector4(x, coneHeight, startOffset, Mathf.Cos(f)));
			materialInstance.SetVector("_TextureData", new Vector4(0f - textureMovement.x, 0f - textureMovement.y, 0f - textureMovement.z, 1f / textureScale));
			materialInstance.SetFloat("_Visibility", visibility);
			materialInstance.SetColor("_Color", volumeColor);
			materialInstance.SetTexture("_MainTex", texture);
		}
	}
}
[ExecuteInEditMode]
public class ConeVolumeOcclusion : VolumetricObjectBase
{
	public float coneHeight = 2f;

	public float coneAngle = 30f;

	public float startOffset;

	public int occlusionTextureSize = 128;

	private float previousConeHeight;

	private float previousConeAngle;

	private float previousStartOffset;

	private int previousOcclusionTextureSize = 128;

	private Transform coneCameraTransform;

	private Camera coneCamera;

	private RenderTexture coneCameraRT;

	protected override void OnEnable()
	{
		if (volumeShader == "")
		{
			PopulateShaderName();
		}
		base.OnEnable();
		SetupCamera();
	}

	protected override void CleanUp()
	{
		if ((bool)coneCameraRT)
		{
			UnityEngine.Object.DestroyImmediate(coneCameraRT);
		}
		base.CleanUp();
	}

	public override void PopulateShaderName()
	{
		volumeShader = "Advanced SS/Volumetric/Cone Volume Occlusion";
	}

	public override bool HasChanged()
	{
		if (coneHeight != previousConeHeight || coneAngle != previousConeAngle || startOffset != previousStartOffset || occlusionTextureSize != previousOcclusionTextureSize || base.HasChanged())
		{
			return true;
		}
		return false;
	}

	protected override void SetChangedValues()
	{
		if (coneHeight < 0f)
		{
			coneHeight = 0f;
		}
		if (coneAngle >= 89f)
		{
			coneAngle = 89f;
		}
		if (occlusionTextureSize < 16)
		{
			occlusionTextureSize = 16;
		}
		previousConeHeight = coneHeight;
		previousConeAngle = coneAngle;
		previousStartOffset = startOffset;
		previousOcclusionTextureSize = occlusionTextureSize;
		base.SetChangedValues();
		SetupCamera();
	}

	public override void UpdateVolume()
	{
		float f = coneAngle * 0.5f * ((float)Math.PI / 180f);
		float num = Mathf.Tan(f) * (coneHeight * 2f);
		float x = num * 0.5f;
		Vector3 vector = new Vector3(num, coneHeight, num);
		if ((bool)meshInstance)
		{
			ScaleMesh(meshInstance, vector, -Vector3.up * coneHeight * 0.5f);
			Bounds bounds = default(Bounds);
			bounds.SetMinMax(-vector, vector);
			meshInstance.bounds = bounds;
		}
		if ((bool)materialInstance)
		{
			materialInstance.SetVector("_ConeData", new Vector4(x, coneHeight, startOffset, Mathf.Cos(f)));
			materialInstance.SetVector("_TextureData", new Vector4(0f - textureMovement.x, 0f - textureMovement.y, 0f - textureMovement.z, 1f / textureScale));
			materialInstance.SetFloat("_Visibility", visibility);
			materialInstance.SetColor("_Color", volumeColor);
			materialInstance.SetTexture("_MainTex", texture);
		}
	}

	private void CreateDepthCamera()
	{
		if (!coneCameraTransform)
		{
			coneCameraTransform = base.transform.Find("ConeCamera");
		}
		if (!coneCameraTransform)
		{
			GameObject gameObject = new GameObject("ConeCamera");
			coneCameraTransform = gameObject.transform;
			coneCameraTransform.parent = base.transform;
		}
		if (!coneCamera)
		{
			coneCamera = coneCameraTransform.GetComponent<Camera>();
		}
		if (!coneCamera)
		{
			coneCamera = coneCameraTransform.gameObject.AddComponent<Camera>();
			coneCamera.gameObject.AddComponent<DrawDepth>();
			coneCamera.enabled = false;
		}
	}

	private RenderTexture ConeRenderTexture()
	{
		if ((bool)coneCameraRT)
		{
			if (coneCameraRT.width == occlusionTextureSize && coneCameraRT.height == occlusionTextureSize)
			{
				return coneCameraRT;
			}
			UnityEngine.Object.Destroy(coneCameraRT);
		}
		coneCameraRT = new RenderTexture(occlusionTextureSize, occlusionTextureSize, 0);
		materialInstance.SetTexture("_OcclusionTex", coneCameraRT);
		return coneCameraRT;
	}

	private void SetupCamera()
	{
		CreateDepthCamera();
		coneCameraTransform.position = base.transform.position;
		coneCameraTransform.rotation = Quaternion.LookRotation(-base.transform.up, base.transform.forward);
		coneCamera.farClipPlane = coneHeight;
		coneCamera.nearClipPlane = 0.01f;
		coneCamera.fieldOfView = coneAngle;
		coneCamera.clearFlags = CameraClearFlags.Color;
		coneCamera.backgroundColor = Color.black;
		coneCamera.targetTexture = ConeRenderTexture();
	}
}
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class DrawDepth : MonoBehaviour
{
	protected bool isSupported = true;

	protected bool supportHDRTextures = true;

	public Shader depthShader;

	private Material depthMaterial;

	private void OnEnable()
	{
		if (depthShader == null)
		{
			depthShader = Shader.Find("Hidden/AdvancedSS/DrawDepth");
		}
		isSupported = true;
	}

	private bool CheckSupport()
	{
		return CheckSupport(needDepth: true);
	}

	private void Start()
	{
		CheckResources();
	}

	private void OnDisable()
	{
		if ((bool)depthMaterial)
		{
			UnityEngine.Object.DestroyImmediate(depthMaterial);
		}
	}

	private bool CheckResources()
	{
		CheckSupport(needDepth: false);
		depthMaterial = CheckShaderAndCreateMaterial(depthShader, depthMaterial);
		if (!isSupported)
		{
			ReportAutoDisable();
		}
		return isSupported;
	}

	private bool CheckSupport(bool needDepth)
	{
		isSupported = true;
		supportHDRTextures = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
		if (!SystemInfo.supportsImageEffects)
		{
			NotSupported();
			return false;
		}
		if (needDepth && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			NotSupported();
			return false;
		}
		if (needDepth)
		{
			GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}
		return true;
	}

	private bool CheckSupport(bool needDepth, bool needHdr)
	{
		if (!CheckSupport(needDepth))
		{
			return false;
		}
		if (needHdr && !supportHDRTextures)
		{
			NotSupported();
			return false;
		}
		return true;
	}

	private void ReportAutoDisable()
	{
		UnityEngine.Debug.LogWarning("The image effect " + ToString() + " has been disabled as it's not supported on the current platform.");
	}

	private bool CheckShader(Shader s)
	{
		UnityEngine.Debug.Log("The shader " + s.ToString() + " on effect " + ToString() + " is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.");
		if (!s.isSupported)
		{
			NotSupported();
			return false;
		}
		return false;
	}

	private void NotSupported()
	{
		base.enabled = false;
		isSupported = false;
	}

	private void LateUpdate()
	{
		DoDepthRender();
	}

	public void DoDepthRender()
	{
		GetComponent<Camera>().RenderWithShader(depthShader, "");
	}

	private Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		if (!s)
		{
			UnityEngine.Debug.Log("Missing shader in " + ToString());
			base.enabled = false;
			return null;
		}
		if (s.isSupported && (bool)m2Create && m2Create.shader == s)
		{
			return m2Create;
		}
		if (!s.isSupported)
		{
			NotSupported();
			UnityEngine.Debug.LogError("The shader " + s.ToString() + " on effect " + ToString() + " is not supported on this platform!");
			return null;
		}
		m2Create = new Material(s);
		m2Create.hideFlags = HideFlags.DontSave;
		if ((bool)m2Create)
		{
			return m2Create;
		}
		return null;
	}

	private Material CreateMaterial(Shader s, Material m2Create)
	{
		if (!s)
		{
			UnityEngine.Debug.Log("Missing shader in " + ToString());
			return null;
		}
		if ((bool)m2Create && m2Create.shader == s && s.isSupported)
		{
			return m2Create;
		}
		if (!s.isSupported)
		{
			return null;
		}
		m2Create = new Material(s);
		m2Create.hideFlags = HideFlags.DontSave;
		if ((bool)m2Create)
		{
			return m2Create;
		}
		return null;
	}
}
public class ConeShadowTestRotate : MonoBehaviour
{
	public float rotationSpeed = 1f;

	private void Update()
	{
		base.transform.Rotate(0f, Time.deltaTime * rotationSpeed, 0f);
	}
}
[ExecuteInEditMode]
public class SphereVolume : VolumetricObjectBase
{
	public float radius = 3f;

	private float previousRadius = 1f;

	protected override void OnEnable()
	{
		if (volumeShader == "")
		{
			PopulateShaderName();
		}
		base.OnEnable();
	}

	public override void PopulateShaderName()
	{
		volumeShader = "Advanced SS/Volumetric/Sphere Volume";
	}

	public override bool HasChanged()
	{
		if (radius != previousRadius || base.HasChanged())
		{
			return true;
		}
		return false;
	}

	protected override void SetChangedValues()
	{
		previousRadius = radius;
		base.SetChangedValues();
	}

	public override void UpdateVolume()
	{
		Vector3 vector = Vector3.one * radius * 2f;
		if ((bool)meshInstance)
		{
			ScaleMesh(meshInstance, vector);
			Bounds bounds = default(Bounds);
			bounds.SetMinMax(-vector, vector);
			meshInstance.bounds = bounds;
		}
		if ((bool)materialInstance)
		{
			materialInstance.SetVector("_TextureData", new Vector4(0f - textureMovement.x, 0f - textureMovement.y, 0f - textureMovement.z, 1f / textureScale));
			materialInstance.SetFloat("_RadiusSqr", radius * radius);
			materialInstance.SetFloat("_Visibility", visibility);
			materialInstance.SetColor("_Color", volumeColor);
			materialInstance.SetTexture("_MainTex", texture);
		}
	}
}
[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class VolumetricObjectBase : MonoBehaviour
{
	public string volumeShader = "";

	protected Material volumetricMaterial;

	public float visibility = 3f;

	public Color volumeColor = new Color(1f, 1f, 1f, 1f);

	public Texture2D texture;

	public float textureScale = 1f;

	public Vector3 textureMovement = new Vector3(0f, -0.1f, 0f);

	protected Mesh meshInstance;

	protected Material materialInstance;

	protected Transform thisTransform;

	protected float previousVisibility = 1f;

	protected Color previousVolumeColor = new Color(1f, 1f, 1f, 1f);

	protected Vector3 forcedLocalScale = Vector3.one;

	protected Texture2D previousTexture;

	protected float previousTextureScale = 10f;

	protected Vector3 previousTextureMovement = new Vector3(0f, 0.1f, 0f);

	protected Vector3[] unitVerts = new Vector3[8];

	protected virtual void OnEnable()
	{
		SetupUnitVerts();
		thisTransform = base.transform;
		if (meshInstance != null)
		{
			UnityEngine.Object.Destroy(meshInstance);
		}
		meshInstance = CreateCube();
		GetComponent<MeshFilter>().sharedMesh = meshInstance;
		if (materialInstance != null)
		{
			UnityEngine.Object.Destroy(materialInstance);
		}
		if (volumeShader == "")
		{
			PopulateShaderName();
		}
		volumetricMaterial = new Material(Shader.Find(volumeShader));
		MeshRenderer component = GetComponent<MeshRenderer>();
		component.sharedMaterial = volumetricMaterial;
		materialInstance = component.sharedMaterial;
		component.castShadows = false;
		component.receiveShadows = false;
		if ((bool)Camera.current)
		{
			Camera.current.depthTextureMode |= DepthTextureMode.Depth;
		}
		if ((bool)Camera.main)
		{
			Camera.main.depthTextureMode |= DepthTextureMode.Depth;
		}
		UpdateVolume();
	}

	protected virtual void OnDestroy()
	{
		CleanUp();
	}

	protected virtual void OnDisable()
	{
		CleanUp();
	}

	protected virtual void CleanUp()
	{
		if ((bool)materialInstance)
		{
			UnityEngine.Object.DestroyImmediate(materialInstance);
		}
		if ((bool)meshInstance)
		{
			UnityEngine.Object.DestroyImmediate(meshInstance);
		}
	}

	public virtual void PopulateShaderName()
	{
	}

	private void LateUpdate()
	{
		if (HasChanged())
		{
			SetChangedValues();
			UpdateVolume();
		}
	}

	public virtual bool HasChanged()
	{
		if (visibility != previousVisibility || volumeColor != previousVolumeColor || thisTransform.localScale != forcedLocalScale || texture != previousTexture || textureScale != previousTextureScale || textureMovement != previousTextureMovement)
		{
			return true;
		}
		return false;
	}

	protected virtual void SetChangedValues()
	{
		previousVisibility = visibility;
		previousVolumeColor = volumeColor;
		thisTransform.localScale = forcedLocalScale;
		previousTexture = texture;
		previousTextureScale = textureScale;
		previousTextureMovement = textureMovement;
	}

	public virtual void UpdateVolume()
	{
	}

	public void SetupUnitVerts()
	{
		float num = 0.5f;
		unitVerts[0].x = 0f - num;
		unitVerts[0].y = 0f - num;
		unitVerts[0].z = 0f - num;
		unitVerts[1].x = num;
		unitVerts[1].y = 0f - num;
		unitVerts[1].z = 0f - num;
		unitVerts[2].x = num;
		unitVerts[2].y = num;
		unitVerts[2].z = 0f - num;
		unitVerts[3].x = num;
		unitVerts[3].y = 0f - num;
		unitVerts[3].z = num;
		unitVerts[4].x = num;
		unitVerts[4].y = num;
		unitVerts[4].z = num;
		unitVerts[5].x = 0f - num;
		unitVerts[5].y = num;
		unitVerts[5].z = 0f - num;
		unitVerts[6].x = 0f - num;
		unitVerts[6].y = num;
		unitVerts[6].z = num;
		unitVerts[7].x = 0f - num;
		unitVerts[7].y = 0f - num;
		unitVerts[7].z = num;
	}

	public Mesh CreateCube()
	{
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[unitVerts.Length];
		unitVerts.CopyTo(array, 0);
		mesh.vertices = array;
		int[] array2 = new int[36];
		int num = 0;
		array2[num] = 0;
		num++;
		array2[num] = 2;
		num++;
		array2[num] = 1;
		num++;
		array2[num] = 0;
		num++;
		array2[num] = 5;
		num++;
		array2[num] = 2;
		num++;
		array2[num] = 3;
		num++;
		array2[num] = 6;
		num++;
		array2[num] = 7;
		num++;
		array2[num] = 3;
		num++;
		array2[num] = 4;
		num++;
		array2[num] = 6;
		num++;
		array2[num] = 1;
		num++;
		array2[num] = 4;
		num++;
		array2[num] = 3;
		num++;
		array2[num] = 1;
		num++;
		array2[num] = 2;
		num++;
		array2[num] = 4;
		num++;
		array2[num] = 7;
		num++;
		array2[num] = 5;
		num++;
		array2[num] = 0;
		num++;
		array2[num] = 7;
		num++;
		array2[num] = 6;
		num++;
		array2[num] = 5;
		num++;
		array2[num] = 7;
		num++;
		array2[num] = 1;
		num++;
		array2[num] = 3;
		num++;
		array2[num] = 7;
		num++;
		array2[num] = 0;
		num++;
		array2[num] = 1;
		num++;
		array2[num] = 5;
		num++;
		array2[num] = 4;
		num++;
		array2[num] = 2;
		num++;
		array2[num] = 5;
		num++;
		array2[num] = 6;
		num++;
		array2[num] = 4;
		num++;
		mesh.triangles = array2;
		mesh.RecalculateBounds();
		return mesh;
	}

	public void ScaleMesh(Mesh mesh, Vector3 scaleFactor)
	{
		ScaleMesh(mesh, scaleFactor, Vector3.zero);
	}

	public void ScaleMesh(Mesh mesh, Vector3 scaleFactor, Vector3 addVector)
	{
		Vector3[] array = new Vector3[mesh.vertexCount];
		for (int i = 0; i < mesh.vertexCount; i++)
		{
			array[i] = ScaleVector(unitVerts[i], scaleFactor) + addVector;
		}
		mesh.vertices = array;
	}

	private Vector3 ScaleVector(Vector3 vector, Vector3 scale)
	{
		return new Vector3(vector.x * scale.x, vector.y * scale.y, vector.z * scale.z);
	}

	public Mesh CopyMesh(Mesh original)
	{
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[original.vertices.Length];
		original.vertices.CopyTo(array, 0);
		mesh.vertices = array;
		Vector2[] array2 = new Vector2[original.uv.Length];
		original.uv.CopyTo(array2, 0);
		mesh.uv = array2;
		Vector2[] array3 = new Vector2[original.uv2.Length];
		original.uv2.CopyTo(array3, 0);
		mesh.uv2 = array3;
		Vector2[] array4 = new Vector2[original.uv2.Length];
		original.uv2.CopyTo(array4, 0);
		mesh.uv2 = array4;
		Vector3[] array5 = new Vector3[original.normals.Length];
		original.normals.CopyTo(array5, 0);
		mesh.normals = array5;
		Vector4[] array6 = new Vector4[original.tangents.Length];
		original.tangents.CopyTo(array6, 0);
		mesh.tangents = array6;
		Color[] array7 = new Color[original.colors.Length];
		original.colors.CopyTo(array7, 0);
		mesh.colors = array7;
		mesh.subMeshCount = original.subMeshCount;
		for (int i = 0; i < original.subMeshCount; i++)
		{
			int[] triangles = original.GetTriangles(i);
			int[] array8 = new int[triangles.Length];
			triangles.CopyTo(array8, 0);
			mesh.SetTriangles(triangles, i);
		}
		mesh.RecalculateBounds();
		return mesh;
	}
}
[Serializable]
public class WeekDateField
{
	public DayOfWeek day;

	public int hour;

	public int minute;

	public int second;

	public TimeSpan GetTimeUntil(WeekDateField weekDate)
	{
		int num = (int)weekDate.day;
		int num2 = (int)day;
		int num3 = Enum.GetNames(typeof(DayOfWeek)).Length;
		int num4 = num - num2;
		if (num < num2)
		{
			num4 = num3 - Math.Abs(num - num2);
		}
		else if (num == num2 && (weekDate.hour < hour || (weekDate.hour == hour && weekDate.minute <= minute) || (weekDate.hour == hour && weekDate.minute == minute && weekDate.second <= second)))
		{
			num4 = num3;
		}
		int num5 = 24 - hour + num4 * 24 - (24 - weekDate.hour);
		int num6 = 60 - minute + num5 * 60 - (60 - weekDate.minute);
		return TimeSpan.FromSeconds(60 - second + num6 * 60 - (60 - weekDate.second));
	}

	public static WeekDateField UtcNow()
	{
		return new WeekDateField
		{
			day = DateTime.UtcNow.DayOfWeek,
			hour = DateTime.UtcNow.Hour,
			minute = DateTime.UtcNow.Minute,
			second = DateTime.UtcNow.Second
		};
	}

	public static WeekDateField Now()
	{
		return new WeekDateField
		{
			day = DateTime.Now.DayOfWeek,
			hour = DateTime.Now.Hour,
			minute = DateTime.Now.Minute,
			second = DateTime.Now.Second
		};
	}
}
[Flags]
public enum ETimerState
{
	Stopped = 2,
	Playing = 4,
	Paused = 8
}
public class TimeSpanTimer : VertigoTimer<TimeSpan>
{
	private bool timeScaleIndependent;

	protected override TimeSpan MaxTimeValue => TimeSpan.MaxValue;

	public TimeSpanTimer SetTimeScaleIndependent(bool isTimeScaleIndependent)
	{
		timeScaleIndependent = isTimeScaleIndependent;
		return this;
	}

	protected override TimeSpan AddTime(TimeSpan lhs, TimeSpan rhs)
	{
		return lhs + rhs;
	}

	protected override TimeSpan SubtractTime(TimeSpan lhs, TimeSpan rhs)
	{
		return lhs - rhs;
	}

	protected override void AddUpdateCallback()
	{
		PostExecutionOrderCallback.AddCallback(ECallbackEvent.UPDATE, Update);
	}

	protected override void RemoveUpdateCallback()
	{
		PostExecutionOrderCallback.RemoveCallback(ECallbackEvent.UPDATE, Update);
	}

	private bool Update()
	{
		float num = (timeScaleIndependent ? Time.unscaledDeltaTime : Time.deltaTime);
		UpdateTimer(TimeSpan.FromSeconds(num));
		return true;
	}
}
public struct TimerElapsedArgs<T> where T : IComparable<T>
{
	public T Elapsed;

	public T ElapsedBackwards;
}
internal struct TimerEvent<T> where T : IComparable<T>
{
	internal readonly T Threshold;

	internal readonly Action Action;

	internal readonly bool ConsumeOnExecute;

	internal bool IsConsumed { get; set; }

	internal TimerEvent(T threshold, Action action, bool consumeOnExecute)
	{
		Threshold = threshold;
		Action = action;
		ConsumeOnExecute = consumeOnExecute;
		IsConsumed = false;
	}
}
public abstract class VertigoTimer<T> : IDisposable where T : IComparable<T>
{
	private readonly List<TimerEvent<T>> timerEvents = new List<TimerEvent<T>>();

	private T stopTime;

	private ETimerState state;

	private bool callbackAdded;

	private bool isStopTimeSet;

	public ETimerState State
	{
		get
		{
			return state;
		}
		private set
		{
			if (state != value)
			{
				state = value;
				if (this.OnTimerStateChanged != null)
				{
					this.OnTimerStateChanged(value);
				}
			}
		}
	}

	public T Elapsed { get; set; }

	public T ElapsedBackwards => SubtractTime(StopTime, Elapsed);

	public T StopTime
	{
		get
		{
			if (!isStopTimeSet)
			{
				return MaxTimeValue;
			}
			return stopTime;
		}
	}

	protected abstract T MaxTimeValue { get; }

	public event Action<ETimerState> OnTimerStateChanged;

	public event Action<TimerElapsedArgs<T>> OnElapsed;

	public event Action OnComplete;

	protected VertigoTimer()
	{
		state = ETimerState.Stopped;
	}

	public VertigoTimer<T> SetStopTime(T newStopTime)
	{
		stopTime = newStopTime;
		isStopTimeSet = true;
		return this;
	}

	public VertigoTimer<T> AddTimerEvent(T threshold, Action action, bool consumeOnExecute = true)
	{
		if (State != ETimerState.Stopped)
		{
			throw new Exception("Timer has to be stopped in order to add timer events");
		}
		timerEvents.Add(new TimerEvent<T>(threshold, action, consumeOnExecute));
		return this;
	}

	public VertigoTimer<T> Start()
	{
		StartInternal();
		return this;
	}

	public VertigoTimer<T> Restart(bool clearTimerEvents = false)
	{
		if (State != ETimerState.Playing)
		{
			throw new Exception("Timer cannot be restarted when it isn't playing");
		}
		if (!clearTimerEvents)
		{
			UnconsumeTimerEvents();
		}
		StopInternal(clearTimerEvents, resetElapsed: true);
		StartInternal();
		return this;
	}

	public VertigoTimer<T> Stop(bool clearTimerEvents = true)
	{
		StopInternal(clearTimerEvents, resetElapsed: true);
		return this;
	}

	public VertigoTimer<T> Pause()
	{
		if (State == ETimerState.Playing)
		{
			State = ETimerState.Paused;
		}
		return this;
	}

	public VertigoTimer<T> PlayOrResume()
	{
		if (State == ETimerState.Paused)
		{
			State = ETimerState.Playing;
		}
		else if (State == ETimerState.Stopped)
		{
			StartInternal();
		}
		return this;
	}

	protected abstract T AddTime(T lhs, T rhs);

	protected abstract T SubtractTime(T lhs, T rhs);

	protected abstract void AddUpdateCallback();

	protected abstract void RemoveUpdateCallback();

	private void StartInternal()
	{
		if (!callbackAdded)
		{
			AddUpdateCallback();
			callbackAdded = true;
		}
		State = ETimerState.Playing;
	}

	private void StopInternal(bool clearTimerEvents, bool resetElapsed)
	{
		State = ETimerState.Stopped;
		if (clearTimerEvents)
		{
			timerEvents.Clear();
		}
		else
		{
			UnconsumeTimerEvents();
		}
		if (resetElapsed)
		{
			Elapsed = default(T);
		}
	}

	private void UnconsumeTimerEvents()
	{
		for (int i = 0; i < timerEvents.Count; i++)
		{
			TimerEvent<T> value = timerEvents[i];
			value.IsConsumed = false;
			timerEvents[i] = value;
		}
	}

	protected void UpdateTimer(T deltaSeconds)
	{
		if (State != ETimerState.Playing)
		{
			return;
		}
		Elapsed = AddTime(Elapsed, deltaSeconds);
		if (Elapsed.CompareTo(StopTime) == 1)
		{
			Elapsed = StopTime;
			if (this.OnComplete != null)
			{
				this.OnComplete();
			}
			StopInternal(clearTimerEvents: true, resetElapsed: false);
		}
		for (int num = timerEvents.Count - 1; num >= 0; num--)
		{
			if (Elapsed.CompareTo(timerEvents[num].Threshold) >= 0 && !timerEvents[num].IsConsumed)
			{
				if (timerEvents[num].ConsumeOnExecute)
				{
					TimerEvent<T> value = timerEvents[num];
					value.IsConsumed = true;
					timerEvents[num] = value;
				}
				timerEvents[num].Action();
			}
		}
		if (this.OnElapsed != null)
		{
			this.OnElapsed(new TimerElapsedArgs<T>
			{
				Elapsed = Elapsed,
				ElapsedBackwards = ElapsedBackwards
			});
		}
	}

	public void Dispose()
	{
		RemoveUpdateCallback();
	}
}
namespace UnityStandardAssets.CinematicEffects
{
	public static class ImageEffectHelper
	{
		public static bool supportsDX11
		{
			get
			{
				if (SystemInfo.graphicsShaderLevel >= 50)
				{
					return SystemInfo.supportsComputeShaders;
				}
				return false;
			}
		}

		public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect)
		{
			if (s == null || !s.isSupported)
			{
				UnityEngine.Debug.LogWarningFormat("Missing shader for image effect {0}", effect);
				return false;
			}
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				UnityEngine.Debug.LogWarningFormat("Image effects aren't supported on this device ({0})", effect);
				return false;
			}
			if (needDepth && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				UnityEngine.Debug.LogWarningFormat("Depth textures aren't supported on this device ({0})", effect);
				return false;
			}
			if (needHdr && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
			{
				UnityEngine.Debug.LogWarningFormat("Floating point textures aren't supported on this device ({0})", effect);
				return false;
			}
			return true;
		}

		public static Material CheckShaderAndCreateMaterial(Shader s)
		{
			if (s == null || !s.isSupported)
			{
				return null;
			}
			return new Material(s)
			{
				hideFlags = HideFlags.DontSave
			};
		}
	}
	public sealed class MinAttribute : PropertyAttribute
	{
		public readonly float min;

		public MinAttribute(float min)
		{
			this.min = min;
		}
	}
	public class RenderTextureUtility
	{
		private List<RenderTexture> m_TemporaryRTs = new List<RenderTexture>();

		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, FilterMode filterMode = FilterMode.Bilinear)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, depthBuffer, format);
			temporary.filterMode = filterMode;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary.name = "RenderTextureUtilityTempTexture";
			m_TemporaryRTs.Add(temporary);
			return temporary;
		}

		public void ReleaseTemporaryRenderTexture(RenderTexture rt)
		{
			if (!(rt == null))
			{
				if (!m_TemporaryRTs.Contains(rt))
				{
					UnityEngine.Debug.LogErrorFormat("Attempting to remove texture that was not allocated: {0}", rt);
				}
				else
				{
					m_TemporaryRTs.Remove(rt);
					RenderTexture.ReleaseTemporary(rt);
				}
			}
		}

		public void ReleaseAllTemporaryRenderTextures()
		{
			for (int i = 0; i < m_TemporaryRTs.Count; i++)
			{
				RenderTexture.ReleaseTemporary(m_TemporaryRTs[i]);
			}
			m_TemporaryRTs.Clear();
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Tonemapping and Color Grading")]
	[ImageEffectAllowedInSceneView]
	public class TonemappingColorGrading : MonoBehaviour
	{
		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
		}

		public class IndentedGroup : PropertyAttribute
		{
		}

		public class ChannelMixer : PropertyAttribute
		{
		}

		public class ColorWheelGroup : PropertyAttribute
		{
			public int minSizePerWheel = 60;

			public int maxSizePerWheel = 150;

			public ColorWheelGroup()
			{
			}

			public ColorWheelGroup(int minSizePerWheel, int maxSizePerWheel)
			{
				this.minSizePerWheel = minSizePerWheel;
				this.maxSizePerWheel = maxSizePerWheel;
			}
		}

		public class Curve : PropertyAttribute
		{
			public Color color = Color.white;

			public Curve()
			{
			}

			public Curve(float r, float g, float b, float a)
			{
				color = new Color(r, g, b, a);
			}
		}

		[Serializable]
		public struct EyeAdaptationSettings
		{
			public bool enabled;

			[Min(0f)]
			[Tooltip("Midpoint Adjustment.")]
			public float middleGrey;

			[Tooltip("The lowest possible exposure value; adjust this value to modify the brightest areas of your level.")]
			public float min;

			[Tooltip("The highest possible exposure value; adjust this value to modify the darkest areas of your level.")]
			public float max;

			[Min(0f)]
			[Tooltip("Speed of linear adaptation. Higher is faster.")]
			public float speed;

			[Tooltip("Displays a luminosity helper in the GameView.")]
			public bool showDebug;

			public static EyeAdaptationSettings defaultSettings
			{
				get
				{
					EyeAdaptationSettings result = default(EyeAdaptationSettings);
					result.enabled = false;
					result.showDebug = false;
					result.middleGrey = 0.5f;
					result.min = -3f;
					result.max = 3f;
					result.speed = 1.5f;
					return result;
				}
			}
		}

		public enum Tonemapper
		{
			ACES,
			Curve,
			Hable,
			HejlDawson,
			Photographic,
			Reinhard,
			Neutral
		}

		[Serializable]
		public struct TonemappingSettings
		{
			public bool enabled;

			[Tooltip("Tonemapping technique to use. ACES is the recommended one.")]
			public Tonemapper tonemapper;

			[Min(0f)]
			[Tooltip("Adjusts the overall exposure of the scene.")]
			public float exposure;

			[Tooltip("Custom tonemapping curve.")]
			public AnimationCurve curve;

			[Range(-0.1f, 0.1f)]
			public float neutralBlackIn;

			[Range(1f, 20f)]
			public float neutralWhiteIn;

			[Range(-0.09f, 0.1f)]
			public float neutralBlackOut;

			[Range(1f, 19f)]
			public float neutralWhiteOut;

			[Range(0.1f, 20f)]
			public float neutralWhiteLevel;

			[Range(1f, 10f)]
			public float neutralWhiteClip;

			public static TonemappingSettings defaultSettings
			{
				get
				{
					TonemappingSettings result = default(TonemappingSettings);
					result.enabled = false;
					result.tonemapper = Tonemapper.Neutral;
					result.exposure = 1f;
					result.curve = CurvesSettings.defaultCurve;
					result.neutralBlackIn = 0.02f;
					result.neutralWhiteIn = 10f;
					result.neutralBlackOut = 0f;
					result.neutralWhiteOut = 10f;
					result.neutralWhiteLevel = 5.3f;
					result.neutralWhiteClip = 10f;
					return result;
				}
			}
		}

		[Serializable]
		public struct LUTSettings
		{
			public bool enabled;

			[Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
			public Texture texture;

			[Range(0f, 1f)]
			[Tooltip("Blending factor.")]
			public float contribution;

			public static LUTSettings defaultSettings
			{
				get
				{
					LUTSettings result = default(LUTSettings);
					result.enabled = false;
					result.texture = null;
					result.contribution = 1f;
					return result;
				}
			}
		}

		[Serializable]
		public struct ColorWheelsSettings
		{
			[ColorUsage(false)]
			public Color shadows;

			[ColorUsage(false)]
			public Color midtones;

			[ColorUsage(false)]
			public Color highlights;

			public static ColorWheelsSettings defaultSettings
			{
				get
				{
					ColorWheelsSettings result = default(ColorWheelsSettings);
					result.shadows = Color.white;
					result.midtones = Color.white;
					result.highlights = Color.white;
					return result;
				}
			}
		}

		[Serializable]
		public struct BasicsSettings
		{
			[Range(-2f, 2f)]
			[Tooltip("Sets the white balance to a custom color temperature.")]
			public float temperatureShift;

			[Range(-2f, 2f)]
			[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
			public float tint;

			[Space]
			[Range(-0.5f, 0.5f)]
			[Tooltip("Shift the hue of all colors.")]
			public float hue;

			[Range(0f, 2f)]
			[Tooltip("Pushes the intensity of all colors.")]
			public float saturation;

			[Range(-1f, 1f)]
			[Tooltip("Adjusts the saturation so that clipping is minimized as colors approach full saturation.")]
			public float vibrance;

			[Range(0f, 10f)]
			[Tooltip("Brightens or darkens all colors.")]
			public float value;

			[Space]
			[Range(0f, 2f)]
			[Tooltip("Expands or shrinks the overall range of tonal values.")]
			public float contrast;

			[Range(0.01f, 5f)]
			[Tooltip("Contrast gain curve. Controls the steepness of the curve.")]
			public float gain;

			[Range(0.01f, 5f)]
			[Tooltip("Applies a pow function to the source.")]
			public float gamma;

			public static BasicsSettings defaultSettings
			{
				get
				{
					BasicsSettings result = default(BasicsSettings);
					result.temperatureShift = 0f;
					result.tint = 0f;
					result.contrast = 1f;
					result.hue = 0f;
					result.saturation = 1f;
					result.value = 1f;
					result.vibrance = 0f;
					result.gain = 1f;
					result.gamma = 1f;
					return result;
				}
			}
		}

		[Serializable]
		public struct ChannelMixerSettings
		{
			public int currentChannel;

			public Vector3[] channels;

			public static ChannelMixerSettings defaultSettings
			{
				get
				{
					ChannelMixerSettings result = default(ChannelMixerSettings);
					result.currentChannel = 0;
					result.channels = new Vector3[3]
					{
						new Vector3(1f, 0f, 0f),
						new Vector3(0f, 1f, 0f),
						new Vector3(0f, 0f, 1f)
					};
					return result;
				}
			}
		}

		[Serializable]
		public struct CurvesSettings
		{
			[Curve]
			public AnimationCurve master;

			[Curve(1f, 0f, 0f, 1f)]
			public AnimationCurve red;

			[Curve(0f, 1f, 0f, 1f)]
			public AnimationCurve green;

			[Curve(0f, 1f, 1f, 1f)]
			public AnimationCurve blue;

			public static CurvesSettings defaultSettings
			{
				get
				{
					CurvesSettings result = default(CurvesSettings);
					result.master = defaultCurve;
					result.red = defaultCurve;
					result.green = defaultCurve;
					result.blue = defaultCurve;
					return result;
				}
			}

			public static AnimationCurve defaultCurve => new AnimationCurve(new Keyframe(0f, 0f, 1f, 1f), new Keyframe(1f, 1f, 1f, 1f));
		}

		public enum ColorGradingPrecision
		{
			Normal = 0x10,
			High = 0x20
		}

		[Serializable]
		public struct ColorGradingSettings
		{
			public bool enabled;

			[Tooltip("Internal LUT precision. \"Normal\" is 256x16, \"High\" is 1024x32. Prefer \"Normal\" on mobile devices.")]
			public ColorGradingPrecision precision;

			[Space]
			[ColorWheelGroup]
			public ColorWheelsSettings colorWheels;

			[Space]
			[IndentedGroup]
			public BasicsSettings basics;

			[Space]
			[ChannelMixer]
			public ChannelMixerSettings channelMixer;

			[Space]
			[IndentedGroup]
			public CurvesSettings curves;

			[Space]
			[Tooltip("Use dithering to try and minimize color banding in dark areas.")]
			public bool useDithering;

			[Tooltip("Displays the generated LUT in the top left corner of the GameView.")]
			public bool showDebug;

			public static ColorGradingSettings defaultSettings
			{
				get
				{
					ColorGradingSettings result = default(ColorGradingSettings);
					result.enabled = false;
					result.useDithering = false;
					result.showDebug = false;
					result.precision = ColorGradingPrecision.Normal;
					result.colorWheels = ColorWheelsSettings.defaultSettings;
					result.basics = BasicsSettings.defaultSettings;
					result.channelMixer = ChannelMixerSettings.defaultSettings;
					result.curves = CurvesSettings.defaultSettings;
					return result;
				}
			}

			internal void Reset()
			{
				curves = CurvesSettings.defaultSettings;
			}
		}

		private enum Pass
		{
			LutGen,
			AdaptationLog,
			AdaptationExpBlend,
			AdaptationExp,
			TonemappingOff,
			TonemappingACES,
			TonemappingCurve,
			TonemappingHable,
			TonemappingHejlDawson,
			TonemappingPhotographic,
			TonemappingReinhard,
			TonemappingNeutral,
			AdaptationDebug
		}

		[SerializeField]
		[SettingsGroup]
		private EyeAdaptationSettings m_EyeAdaptation = EyeAdaptationSettings.defaultSettings;

		[SerializeField]
		[SettingsGroup]
		private TonemappingSettings m_Tonemapping = TonemappingSettings.defaultSettings;

		[SerializeField]
		[SettingsGroup]
		private ColorGradingSettings m_ColorGrading = ColorGradingSettings.defaultSettings;

		[SerializeField]
		[SettingsGroup]
		private LUTSettings m_Lut = LUTSettings.defaultSettings;

		private Texture2D m_IdentityLut;

		private RenderTexture m_InternalLut;

		private Texture2D m_CurveTexture;

		private Texture2D m_TonemapperCurve;

		private float m_TonemapperCurveRange;

		[SerializeField]
		private Shader m_Shader;

		private Material m_Material;

		private bool m_Dirty = true;

		private bool m_TonemapperDirty = true;

		private RenderTexture m_SmallAdaptiveRt;

		private RenderTextureFormat m_AdaptiveRtFormat;

		public EyeAdaptationSettings eyeAdaptation
		{
			get
			{
				return m_EyeAdaptation;
			}
			set
			{
				m_EyeAdaptation = value;
			}
		}

		public TonemappingSettings tonemapping
		{
			get
			{
				return m_Tonemapping;
			}
			set
			{
				m_Tonemapping = value;
				SetTonemapperDirty();
			}
		}

		public ColorGradingSettings colorGrading
		{
			get
			{
				return m_ColorGrading;
			}
			set
			{
				m_ColorGrading = value;
				SetDirty();
			}
		}

		public LUTSettings lut
		{
			get
			{
				return m_Lut;
			}
			set
			{
				m_Lut = value;
			}
		}

		private Texture2D identityLut
		{
			get
			{
				if (m_IdentityLut == null || m_IdentityLut.height != lutSize)
				{
					UnityEngine.Object.DestroyImmediate(m_IdentityLut);
					m_IdentityLut = GenerateIdentityLut(lutSize);
				}
				return m_IdentityLut;
			}
		}

		private RenderTexture internalLutRt
		{
			get
			{
				if (m_InternalLut == null || !m_InternalLut.IsCreated() || m_InternalLut.height != lutSize)
				{
					UnityEngine.Object.DestroyImmediate(m_InternalLut);
					m_InternalLut = new RenderTexture(lutSize * lutSize, lutSize, 0, RenderTextureFormat.ARGB32)
					{
						name = "Internal LUT",
						filterMode = FilterMode.Bilinear,
						anisoLevel = 0,
						hideFlags = HideFlags.DontSave
					};
				}
				return m_InternalLut;
			}
		}

		private Texture2D curveTexture
		{
			get
			{
				if (m_CurveTexture == null)
				{
					m_CurveTexture = new Texture2D(256, 1, TextureFormat.ARGB32, mipChain: false, linear: true)
					{
						name = "Curve texture",
						wrapMode = TextureWrapMode.Clamp,
						filterMode = FilterMode.Bilinear,
						anisoLevel = 0,
						hideFlags = HideFlags.DontSave
					};
				}
				return m_CurveTexture;
			}
		}

		private Texture2D tonemapperCurve
		{
			get
			{
				if (m_TonemapperCurve == null)
				{
					TextureFormat textureFormat = TextureFormat.RGB24;
					if (SystemInfo.SupportsTextureFormat(TextureFormat.RFloat))
					{
						textureFormat = TextureFormat.RFloat;
					}
					else if (SystemInfo.SupportsTextureFormat(TextureFormat.RHalf))
					{
						textureFormat = TextureFormat.RHalf;
					}
					m_TonemapperCurve = new Texture2D(256, 1, textureFormat, mipChain: false, linear: true)
					{
						name = "Tonemapper curve texture",
						wrapMode = TextureWrapMode.Clamp,
						filterMode = FilterMode.Bilinear,
						anisoLevel = 0,
						hideFlags = HideFlags.DontSave
					};
				}
				return m_TonemapperCurve;
			}
		}

		public Shader shader
		{
			get
			{
				if (m_Shader == null)
				{
					m_Shader = Shader.Find("Hidden/TonemappingColorGrading");
				}
				return m_Shader;
			}
		}

		public Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(shader);
				}
				return m_Material;
			}
		}

		public bool isGammaColorSpace => QualitySettings.activeColorSpace == ColorSpace.Gamma;

		public int lutSize => (int)colorGrading.precision;

		public bool validRenderTextureFormat { get; private set; }

		public bool validUserLutSize { get; private set; }

		public void SetDirty()
		{
			m_Dirty = true;
		}

		public void SetTonemapperDirty()
		{
			m_TonemapperDirty = true;
		}

		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(shader, needDepth: false, needHdr: true, this))
			{
				base.enabled = false;
				return;
			}
			SetDirty();
			SetTonemapperDirty();
		}

		private void OnDisable()
		{
			if (m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
			if (m_IdentityLut != null)
			{
				UnityEngine.Object.DestroyImmediate(m_IdentityLut);
			}
			if (m_InternalLut != null)
			{
				UnityEngine.Object.DestroyImmediate(internalLutRt);
			}
			if (m_SmallAdaptiveRt != null)
			{
				UnityEngine.Object.DestroyImmediate(m_SmallAdaptiveRt);
			}
			if (m_CurveTexture != null)
			{
				UnityEngine.Object.DestroyImmediate(m_CurveTexture);
			}
			if (m_TonemapperCurve != null)
			{
				UnityEngine.Object.DestroyImmediate(m_TonemapperCurve);
			}
			m_Material = null;
			m_IdentityLut = null;
			m_InternalLut = null;
			m_SmallAdaptiveRt = null;
			m_CurveTexture = null;
			m_TonemapperCurve = null;
		}

		private void OnValidate()
		{
			SetDirty();
			SetTonemapperDirty();
		}

		private static Texture2D GenerateIdentityLut(int dim)
		{
			Color[] array = new Color[dim * dim * dim];
			float num = 1f / ((float)dim - 1f);
			for (int i = 0; i < dim; i++)
			{
				for (int j = 0; j < dim; j++)
				{
					for (int k = 0; k < dim; k++)
					{
						array[i + j * dim + k * dim * dim] = new Color((float)i * num, Mathf.Abs((float)k * num), (float)j * num, 1f);
					}
				}
			}
			Texture2D texture2D = new Texture2D(dim * dim, dim, TextureFormat.RGB24, mipChain: false, linear: true);
			texture2D.name = "Identity LUT";
			texture2D.filterMode = FilterMode.Bilinear;
			texture2D.anisoLevel = 0;
			texture2D.hideFlags = HideFlags.DontSave;
			texture2D.SetPixels(array);
			texture2D.Apply();
			return texture2D;
		}

		private float StandardIlluminantY(float x)
		{
			return 2.87f * x - 3f * x * x - 0.27509508f;
		}

		private Vector3 CIExyToLMS(float x, float y)
		{
			float num = 1f;
			float num2 = num * x / y;
			float num3 = num * (1f - x - y) / y;
			float x2 = 0.7328f * num2 + 0.4296f * num - 0.1624f * num3;
			float y2 = -0.7036f * num2 + 1.6975f * num + 0.0061f * num3;
			float z = 0.003f * num2 + 0.0136f * num + 0.9834f * num3;
			return new Vector3(x2, y2, z);
		}

		private Vector3 GetWhiteBalance()
		{
			float temperatureShift = colorGrading.basics.temperatureShift;
			float tint = colorGrading.basics.tint;
			float x = 0.31271f - temperatureShift * ((temperatureShift < 0f) ? 0.1f : 0.05f);
			float y = StandardIlluminantY(x) + tint * 0.05f;
			Vector3 vector = new Vector3(0.949237f, 1.03542f, 1.08728f);
			Vector3 vector2 = CIExyToLMS(x, y);
			return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
		}

		private static Color NormalizeColor(Color c)
		{
			float num = (c.r + c.g + c.b) / 3f;
			if (Mathf.Approximately(num, 0f))
			{
				return new Color(1f, 1f, 1f, 1f);
			}
			Color result = default(Color);
			result.r = c.r / num;
			result.g = c.g / num;
			result.b = c.b / num;
			result.a = 1f;
			return result;
		}

		private void GenerateLiftGammaGain(out Color lift, out Color gamma, out Color gain)
		{
			Color color = NormalizeColor(colorGrading.colorWheels.shadows);
			Color color2 = NormalizeColor(colorGrading.colorWheels.midtones);
			Color color3 = NormalizeColor(colorGrading.colorWheels.highlights);
			float num = (color.r + color.g + color.b) / 3f;
			float num2 = (color2.r + color2.g + color2.b) / 3f;
			float num3 = (color3.r + color3.g + color3.b) / 3f;
			float r = (color.r - num) * 0.1f;
			float g = (color.g - num) * 0.1f;
			float b = (color.b - num) * 0.1f;
			float b2 = Mathf.Pow(2f, (color2.r - num2) * 0.5f);
			float b3 = Mathf.Pow(2f, (color2.g - num2) * 0.5f);
			float b4 = Mathf.Pow(2f, (color2.b - num2) * 0.5f);
			float r2 = Mathf.Pow(2f, (color3.r - num3) * 0.5f);
			float g2 = Mathf.Pow(2f, (color3.g - num3) * 0.5f);
			float b5 = Mathf.Pow(2f, (color3.b - num3) * 0.5f);
			float r3 = 1f / Mathf.Max(0.01f, b2);
			float g3 = 1f / Mathf.Max(0.01f, b3);
			float b6 = 1f / Mathf.Max(0.01f, b4);
			lift = new Color(r, g, b);
			gamma = new Color(r3, g3, b6);
			gain = new Color(r2, g2, b5);
		}

		private void GenCurveTexture()
		{
			AnimationCurve master = colorGrading.curves.master;
			AnimationCurve red = colorGrading.curves.red;
			AnimationCurve green = colorGrading.curves.green;
			AnimationCurve blue = colorGrading.curves.blue;
			Color[] array = new Color[256];
			for (float num = 0f; num <= 1f; num += 0.003921569f)
			{
				float a = Mathf.Clamp(master.Evaluate(num), 0f, 1f);
				float r = Mathf.Clamp(red.Evaluate(num), 0f, 1f);
				float g = Mathf.Clamp(green.Evaluate(num), 0f, 1f);
				float b = Mathf.Clamp(blue.Evaluate(num), 0f, 1f);
				array[(int)Mathf.Floor(num * 255f)] = new Color(r, g, b, a);
			}
			curveTexture.SetPixels(array);
			curveTexture.Apply();
		}

		private bool CheckUserLut()
		{
			validUserLutSize = lut.texture.height == (int)Mathf.Sqrt(lut.texture.width);
			return validUserLutSize;
		}

		private bool CheckSmallAdaptiveRt()
		{
			if (m_SmallAdaptiveRt != null)
			{
				return false;
			}
			m_AdaptiveRtFormat = RenderTextureFormat.ARGBHalf;
			if (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf))
			{
				m_AdaptiveRtFormat = RenderTextureFormat.RGHalf;
			}
			m_SmallAdaptiveRt = new RenderTexture(1, 1, 0, m_AdaptiveRtFormat);
			m_SmallAdaptiveRt.hideFlags = HideFlags.DontSave;
			return true;
		}

		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			material.shaderKeywords = null;
			RenderTexture renderTexture = null;
			RenderTexture[] array = null;
			if (eyeAdaptation.enabled)
			{
				bool flag = CheckSmallAdaptiveRt();
				int num = ((source.width < source.height) ? source.width : source.height);
				int num2 = num | (num >> 1);
				int num3 = num2 | (num2 >> 2);
				int num4 = num3 | (num3 >> 4);
				int num5 = num4 | (num4 >> 8);
				int num6 = num5 | (num5 >> 16);
				int num7 = num6 - (num6 >> 1);
				renderTexture = RenderTexture.GetTemporary(num7, num7, 0, m_AdaptiveRtFormat);
				Graphics.Blit(source, renderTexture);
				int num8 = (int)Mathf.Log(renderTexture.width, 2f);
				int num9 = 2;
				array = new RenderTexture[num8];
				for (int i = 0; i < num8; i++)
				{
					array[i] = RenderTexture.GetTemporary(renderTexture.width / num9, renderTexture.width / num9, 0, m_AdaptiveRtFormat);
					num9 <<= 1;
				}
				RenderTexture source2 = array[num8 - 1];
				Graphics.Blit(renderTexture, array[0], material, 1);
				for (int j = 0; j < num8 - 1; j++)
				{
					Graphics.Blit(array[j], array[j + 1]);
					source2 = array[j + 1];
				}
				m_SmallAdaptiveRt.MarkRestoreExpected();
				material.SetFloat("_AdaptationSpeed", Mathf.Max(eyeAdaptation.speed, 0.001f));
				Graphics.Blit(source2, m_SmallAdaptiveRt, material, flag ? 3 : 2);
				material.SetFloat("_MiddleGrey", eyeAdaptation.middleGrey);
				material.SetFloat("_AdaptationMin", Mathf.Pow(2f, eyeAdaptation.min));
				material.SetFloat("_AdaptationMax", Mathf.Pow(2f, eyeAdaptation.max));
				material.SetTexture("_LumTex", m_SmallAdaptiveRt);
				material.EnableKeyword("ENABLE_EYE_ADAPTATION");
			}
			int num10 = 4;
			if (tonemapping.enabled)
			{
				if (tonemapping.tonemapper == Tonemapper.Curve)
				{
					if (m_TonemapperDirty)
					{
						float num11 = 1f;
						if (tonemapping.curve.length > 0)
						{
							num11 = tonemapping.curve[tonemapping.curve.length - 1].time;
							for (float num12 = 0f; num12 <= 1f; num12 += 0.003921569f)
							{
								float num13 = tonemapping.curve.Evaluate(num12 * num11);
								tonemapperCurve.SetPixel(Mathf.FloorToInt(num12 * 255f), 0, new Color(num13, num13, num13));
							}
							tonemapperCurve.Apply();
						}
						m_TonemapperCurveRange = 1f / num11;
						m_TonemapperDirty = false;
					}
					material.SetFloat("_ToneCurveRange", m_TonemapperCurveRange);
					Shader.SetGlobalTexture("_ToneCurve", tonemapperCurve);
				}
				else if (tonemapping.tonemapper == Tonemapper.Neutral)
				{
					float num14 = tonemapping.neutralBlackIn * 20f + 1f;
					float num15 = tonemapping.neutralBlackOut * 10f + 1f;
					float num16 = tonemapping.neutralWhiteIn / 20f;
					float num17 = 1f - tonemapping.neutralWhiteOut / 20f;
					float t = num14 / num15;
					float t2 = num16 / num17;
					float y = Mathf.Max(0f, Mathf.LerpUnclamped(0.57f, 0.37f, t));
					float z = Mathf.LerpUnclamped(0.01f, 0.24f, t2);
					float w = Mathf.Max(0f, Mathf.LerpUnclamped(0.02f, 0.2f, t));
					material.SetVector("_NeutralTonemapperParams1", new Vector4(0.2f, y, z, w));
					material.SetVector("_NeutralTonemapperParams2", new Vector4(0.02f, 0.3f, tonemapping.neutralWhiteLevel, tonemapping.neutralWhiteClip / 10f));
				}
				material.SetFloat("_Exposure", tonemapping.exposure);
				num10 = (int)(num10 + (tonemapping.tonemapper + 1));
			}
			if (colorGrading.enabled)
			{
				if (m_Dirty || !m_InternalLut.IsCreated())
				{
					GenerateLiftGammaGain(out var lift, out var gamma, out var gain);
					GenCurveTexture();
					material.SetVector("_WhiteBalance", GetWhiteBalance());
					material.SetVector("_Lift", lift);
					material.SetVector("_Gamma", gamma);
					material.SetVector("_Gain", gain);
					material.SetVector("_ContrastGainGamma", new Vector3(colorGrading.basics.contrast, colorGrading.basics.gain, 1f / colorGrading.basics.gamma));
					material.SetFloat("_Vibrance", colorGrading.basics.vibrance);
					material.SetVector("_HSV", new Vector4(colorGrading.basics.hue, colorGrading.basics.saturation, colorGrading.basics.value));
					material.SetVector("_ChannelMixerRed", colorGrading.channelMixer.channels[0]);
					material.SetVector("_ChannelMixerGreen", colorGrading.channelMixer.channels[1]);
					material.SetVector("_ChannelMixerBlue", colorGrading.channelMixer.channels[2]);
					Shader.SetGlobalTexture("_CurveTex", curveTexture);
					internalLutRt.MarkRestoreExpected();
					Graphics.Blit(identityLut, internalLutRt, material, 0);
					m_Dirty = false;
				}
				material.EnableKeyword("ENABLE_COLOR_GRADING");
				if (colorGrading.useDithering)
				{
					material.EnableKeyword("ENABLE_DITHERING");
				}
				Shader.SetGlobalTexture("_InternalLutTex", internalLutRt);
				material.SetVector("_InternalLutParams", new Vector3(1f / (float)internalLutRt.width, 1f / (float)internalLutRt.height, (float)internalLutRt.height - 1f));
			}
			if (lut.enabled && lut.texture != null && CheckUserLut())
			{
				Shader.SetGlobalTexture("_UserLutTex", lut.texture);
				material.SetVector("_UserLutParams", new Vector4(1f / (float)lut.texture.width, 1f / (float)lut.texture.height, (float)lut.texture.height - 1f, lut.contribution));
				material.EnableKeyword("ENABLE_USER_LUT");
			}
			Graphics.Blit(source, destination, material, num10);
			if (eyeAdaptation.enabled)
			{
				for (int k = 0; k < array.Length; k++)
				{
					RenderTexture.ReleaseTemporary(array[k]);
				}
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		public Texture2D BakeLUT()
		{
			Texture2D texture2D = new Texture2D(internalLutRt.width, internalLutRt.height, TextureFormat.RGB24, mipChain: false, linear: true);
			RenderTexture.active = internalLutRt;
			texture2D.ReadPixels(new Rect(0f, 0f, texture2D.width, texture2D.height), 0, 0);
			RenderTexture.active = null;
			return texture2D;
		}
	}
}
namespace RootMotion
{
	[Serializable]
	public enum Axis
	{
		X,
		Y,
		Z
	}
	public class AxisTools
	{
		public static Vector3 ToVector3(Axis axis)
		{
			return axis switch
			{
				Axis.X => Vector3.right, 
				Axis.Y => Vector3.up, 
				_ => Vector3.forward, 
			};
		}

		public static Axis ToAxis(Vector3 v)
		{
			float num = Mathf.Abs(v.x);
			float num2 = Mathf.Abs(v.y);
			float num3 = Mathf.Abs(v.z);
			Axis result = Axis.X;
			if (num2 > num && num2 > num3)
			{
				result = Axis.Y;
			}
			if (num3 > num && num3 > num2)
			{
				result = Axis.Z;
			}
			return result;
		}

		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			Vector3 axisVectorToPoint = GetAxisVectorToPoint(t, worldPosition);
			if (axisVectorToPoint == Vector3.right)
			{
				return Axis.X;
			}
			if (axisVectorToPoint == Vector3.up)
			{
				return Axis.Y;
			}
			return Axis.Z;
		}

		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			Vector3 axisVectorToDirection = GetAxisVectorToDirection(t, direction);
			if (axisVectorToDirection == Vector3.right)
			{
				return Axis.X;
			}
			if (axisVectorToDirection == Vector3.up)
			{
				return Axis.Y;
			}
			return Axis.Z;
		}

		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return GetAxisVectorToDirection(t, worldPosition - t.position);
		}

		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			direction = direction.normalized;
			Vector3 result = Vector3.right;
			float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(t.right), direction));
			float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(t.up), direction));
			if (num2 > num)
			{
				result = Vector3.up;
			}
			float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(t.forward), direction));
			if (num3 > num && num3 > num2)
			{
				result = Vector3.forward;
			}
			return result;
		}
	}
	[Serializable]
	public class BipedLimbOrientations
	{
		[Serializable]
		public class LimbOrientation
		{
			public Vector3 upperBoneForwardAxis;

			public Vector3 lowerBoneForwardAxis;

			public Vector3 lastBoneLeftAxis;

			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
				this.upperBoneForwardAxis = upperBoneForwardAxis;
				this.lowerBoneForwardAxis = lowerBoneForwardAxis;
				this.lastBoneLeftAxis = lastBoneLeftAxis;
			}
		}

		public LimbOrientation leftArm;

		public LimbOrientation rightArm;

		public LimbOrientation leftLeg;

		public LimbOrientation rightLeg;

		public static BipedLimbOrientations UMA => new BipedLimbOrientations(new LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));

		public static BipedLimbOrientations MaxBiped => new BipedLimbOrientations(new LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new LimbOrientation(Vector3.up, Vector3.up, Vector3.back));

		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
			this.leftArm = leftArm;
			this.rightArm = rightArm;
			this.leftLeg = leftLeg;
			this.rightLeg = rightLeg;
		}
	}
	public static class BipedNaming
	{
		[Serializable]
		public enum BoneType
		{
			Unassigned,
			Spine,
			Head,
			Arm,
			Leg,
			Tail,
			Eye
		}

		[Serializable]
		public enum BoneSide
		{
			Center,
			Left,
			Right
		}

		public static string[] typeLeft = new string[9] { " L ", "_L_", "-L-", " l ", "_l_", "-l-", "Left", "left", "CATRigL" };

		public static string[] typeRight = new string[9] { " R ", "_R_", "-R-", " r ", "_r_", "-r-", "Right", "right", "CATRigR" };

		public static string[] typeSpine = new string[16]
		{
			"Spine", "spine", "Pelvis", "pelvis", "Root", "root", "Torso", "torso", "Body", "body",
			"Hips", "hips", "Neck", "neck", "Chest", "chest"
		};

		public static string[] typeHead = new string[2] { "Head", "head" };

		public static string[] typeArm = new string[10] { "Arm", "arm", "Hand", "hand", "Wrist", "Wrist", "Elbow", "elbow", "Palm", "palm" };

		public static string[] typeLeg = new string[16]
		{
			"Leg", "leg", "Thigh", "thigh", "Calf", "calf", "Femur", "femur", "Knee", "knee",
			"Foot", "foot", "Ankle", "ankle", "Hip", "hip"
		};

		public static string[] typeTail = new string[2] { "Tail", "tail" };

		public static string[] typeEye = new string[2] { "Eye", "eye" };

		public static string[] typeExclude = new string[6] { "Nub", "Dummy", "dummy", "Tip", "IK", "Mesh" };

		public static string[] typeExcludeSpine = new string[2] { "Head", "head" };

		public static string[] typeExcludeHead = new string[2] { "Top", "End" };

		public static string[] typeExcludeArm = new string[19]
		{
			"Collar", "collar", "Clavicle", "clavicle", "Finger", "finger", "Index", "index", "Mid", "mid",
			"Pinky", "pinky", "Ring", "Thumb", "thumb", "Adjust", "adjust", "Twist", "twist"
		};

		public static string[] typeExcludeLeg = new string[7] { "Toe", "toe", "Platform", "Adjust", "adjust", "Twist", "twist" };

		public static string[] typeExcludeTail = new string[0];

		public static string[] typeExcludeEye = new string[6] { "Lid", "lid", "Brow", "brow", "Lash", "lash" };

		public static string[] pelvis = new string[4] { "Pelvis", "pelvis", "Hip", "hip" };

		public static string[] hand = new string[6] { "Hand", "hand", "Wrist", "wrist", "Palm", "palm" };

		public static string[] foot = new string[4] { "Foot", "foot", "Ankle", "ankle" };

		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			Transform[] array = new Transform[0];
			foreach (Transform transform in bones)
			{
				if (transform != null && GetBoneType(transform.name) == boneType)
				{
					Array.Resize(ref array, array.Length + 1);
					array[array.Length - 1] = transform;
				}
			}
			return array;
		}

		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			Transform[] array = new Transform[0];
			foreach (Transform transform in bones)
			{
				if (transform != null && GetBoneSide(transform.name) == boneSide)
				{
					Array.Resize(ref array, array.Length + 1);
					array[array.Length - 1] = transform;
				}
			}
			return array;
		}

		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			Transform[] bonesOfType = GetBonesOfType(boneType, bones);
			return GetBonesOfSide(boneSide, bonesOfType);
		}

		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			Transform[] bonesOfTypeAndSide = GetBonesOfTypeAndSide(boneType, boneSide, bones);
			if (bonesOfTypeAndSide.Length == 0)
			{
				return null;
			}
			return bonesOfTypeAndSide[0];
		}

		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			foreach (Transform transform in transforms)
			{
				bool flag = true;
				foreach (string[] namingConvention in namings)
				{
					if (!matchesNaming(transform.name, namingConvention))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					return transform;
				}
			}
			return null;
		}

		public static BoneType GetBoneType(string boneName)
		{
			if (isSpine(boneName))
			{
				return BoneType.Spine;
			}
			if (isHead(boneName))
			{
				return BoneType.Head;
			}
			if (isArm(boneName))
			{
				return BoneType.Arm;
			}
			if (isLeg(boneName))
			{
				return BoneType.Leg;
			}
			if (isTail(boneName))
			{
				return BoneType.Tail;
			}
			if (isEye(boneName))
			{
				return BoneType.Eye;
			}
			return BoneType.Unassigned;
		}

		public static BoneSide GetBoneSide(string boneName)
		{
			if (isLeft(boneName))
			{
				return BoneSide.Left;
			}
			if (isRight(boneName))
			{
				return BoneSide.Right;
			}
			return BoneSide.Center;
		}

		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return GetNamingMatch(GetBonesOfTypeAndSide(boneType, boneSide, transforms), namings);
		}

		private static bool isLeft(string boneName)
		{
			if (!matchesNaming(boneName, typeLeft) && !(lastLetter(boneName) == "L"))
			{
				return firstLetter(boneName) == "L";
			}
			return true;
		}

		private static bool isRight(string boneName)
		{
			if (!matchesNaming(boneName, typeRight) && !(lastLetter(boneName) == "R"))
			{
				return firstLetter(boneName) == "R";
			}
			return true;
		}

		private static bool isSpine(string boneName)
		{
			if (matchesNaming(boneName, typeSpine))
			{
				return !excludesNaming(boneName, typeExcludeSpine);
			}
			return false;
		}

		private static bool isHead(string boneName)
		{
			if (matchesNaming(boneName, typeHead))
			{
				return !excludesNaming(boneName, typeExcludeHead);
			}
			return false;
		}

		private static bool isArm(string boneName)
		{
			if (matchesNaming(boneName, typeArm))
			{
				return !excludesNaming(boneName, typeExcludeArm);
			}
			return false;
		}

		private static bool isLeg(string boneName)
		{
			if (matchesNaming(boneName, typeLeg))
			{
				return !excludesNaming(boneName, typeExcludeLeg);
			}
			return false;
		}

		private static bool isTail(string boneName)
		{
			if (matchesNaming(boneName, typeTail))
			{
				return !excludesNaming(boneName, typeExcludeTail);
			}
			return false;
		}

		private static bool isEye(string boneName)
		{
			if (matchesNaming(boneName, typeEye))
			{
				return !excludesNaming(boneName, typeExcludeEye);
			}
			return false;
		}

		private static bool isTypeExclude(string boneName)
		{
			return matchesNaming(boneName, typeExclude);
		}

		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			if (excludesNaming(boneName, typeExclude))
			{
				return false;
			}
			foreach (string value in namingConvention)
			{
				if (boneName.Contains(value))
				{
					return true;
				}
			}
			return false;
		}

		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			foreach (string value in namingConvention)
			{
				if (boneName.Contains(value))
				{
					return true;
				}
			}
			return false;
		}

		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			foreach (string letter in namingConvention)
			{
				if (LastLetterIs(boneName, letter))
				{
					return true;
				}
			}
			return false;
		}

		private static bool LastLetterIs(string boneName, string letter)
		{
			return boneName.Substring(boneName.Length - 1, 1) == letter;
		}

		private static string firstLetter(string boneName)
		{
			if (boneName.Length > 0)
			{
				return boneName.Substring(0, 1);
			}
			return "";
		}

		private static string lastLetter(string boneName)
		{
			if (boneName.Length > 0)
			{
				return boneName.Substring(boneName.Length - 1, 1);
			}
			return "";
		}
	}
	[Serializable]
	public class BipedReferences
	{
		public struct AutoDetectParams
		{
			public bool legsParentInSpine;

			public bool includeEyes;

			public static AutoDetectParams Default => new AutoDetectParams(legsParentInSpine: true, includeEyes: true);

			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
				this.legsParentInSpine = legsParentInSpine;
				this.includeEyes = includeEyes;
			}
		}

		public Transform root;

		public Transform pelvis;

		public Transform leftThigh;

		public Transform leftCalf;

		public Transform leftFoot;

		public Transform rightThigh;

		public Transform rightCalf;

		public Transform rightFoot;

		public Transform leftUpperArm;

		public Transform leftForearm;

		public Transform leftHand;

		public Transform rightUpperArm;

		public Transform rightForearm;

		public Transform rightHand;

		public Transform head;

		public Transform[] spine = new Transform[0];

		public Transform[] eyes = new Transform[0];

		public virtual bool isFilled
		{
			get
			{
				if (root == null)
				{
					return false;
				}
				if (pelvis == null)
				{
					return false;
				}
				if (leftThigh == null || leftCalf == null || leftFoot == null)
				{
					return false;
				}
				if (rightThigh == null || rightCalf == null || rightFoot == null)
				{
					return false;
				}
				if (leftUpperArm == null || leftForearm == null || leftHand == null)
				{
					return false;
				}
				if (rightUpperArm == null || rightForearm == null || rightHand == null)
				{
					return false;
				}
				Transform[] array = spine;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == null)
					{
						return false;
					}
				}
				array = eyes;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == null)
					{
						return false;
					}
				}
				return true;
			}
		}

		public bool isEmpty => IsEmpty(includeRoot: true);

		public virtual bool IsEmpty(bool includeRoot)
		{
			if (includeRoot && root != null)
			{
				return false;
			}
			if (pelvis != null || head != null)
			{
				return false;
			}
			if (leftThigh != null || leftCalf != null || leftFoot != null)
			{
				return false;
			}
			if (rightThigh != null || rightCalf != null || rightFoot != null)
			{
				return false;
			}
			if (leftUpperArm != null || leftForearm != null || leftHand != null)
			{
				return false;
			}
			if (rightUpperArm != null || rightForearm != null || rightHand != null)
			{
				return false;
			}
			Transform[] array = spine;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					return false;
				}
			}
			array = eyes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					return false;
				}
			}
			return true;
		}

		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			if (!ignoreRoot && root == t)
			{
				return true;
			}
			if (pelvis == t)
			{
				return true;
			}
			if (leftThigh == t)
			{
				return true;
			}
			if (leftCalf == t)
			{
				return true;
			}
			if (leftFoot == t)
			{
				return true;
			}
			if (rightThigh == t)
			{
				return true;
			}
			if (rightCalf == t)
			{
				return true;
			}
			if (rightFoot == t)
			{
				return true;
			}
			if (leftUpperArm == t)
			{
				return true;
			}
			if (leftForearm == t)
			{
				return true;
			}
			if (leftHand == t)
			{
				return true;
			}
			if (rightUpperArm == t)
			{
				return true;
			}
			if (rightForearm == t)
			{
				return true;
			}
			if (rightHand == t)
			{
				return true;
			}
			if (head == t)
			{
				return true;
			}
			Transform[] array = spine;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == t)
				{
					return true;
				}
			}
			array = eyes;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == t)
				{
					return true;
				}
			}
			return false;
		}

		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			if (references == null)
			{
				references = new BipedReferences();
			}
			references.root = root;
			Animator component = root.GetComponent<Animator>();
			if (component != null && component.isHuman)
			{
				AssignHumanoidReferences(ref references, component, autoDetectParams);
				return true;
			}
			DetectReferencesByNaming(ref references, root, autoDetectParams);
			Warning.logged = false;
			if (!references.isFilled)
			{
				Warning.Log("BipedReferences contains one or more missing Transforms.", root, logInEditMode: true);
				return false;
			}
			string errorMessage = "";
			if (SetupError(references, ref errorMessage))
			{
				Warning.Log(errorMessage, references.root, logInEditMode: true);
				return false;
			}
			if (SetupWarning(references, ref errorMessage))
			{
				Warning.Log(errorMessage, references.root, logInEditMode: true);
			}
			return true;
		}

		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			if (references == null)
			{
				references = new BipedReferences();
			}
			Transform[] componentsInChildren = root.GetComponentsInChildren<Transform>();
			DetectLimb(BipedNaming.BoneType.Arm, BipedNaming.BoneSide.Left, ref references.leftUpperArm, ref references.leftForearm, ref references.leftHand, componentsInChildren);
			DetectLimb(BipedNaming.BoneType.Arm, BipedNaming.BoneSide.Right, ref references.rightUpperArm, ref references.rightForearm, ref references.rightHand, componentsInChildren);
			DetectLimb(BipedNaming.BoneType.Leg, BipedNaming.BoneSide.Left, ref references.leftThigh, ref references.leftCalf, ref references.leftFoot, componentsInChildren);
			DetectLimb(BipedNaming.BoneType.Leg, BipedNaming.BoneSide.Right, ref references.rightThigh, ref references.rightCalf, ref references.rightFoot, componentsInChildren);
			references.head = BipedNaming.GetBone(componentsInChildren, BipedNaming.BoneType.Head, BipedNaming.BoneSide.Center);
			references.pelvis = BipedNaming.GetNamingMatch(componentsInChildren, BipedNaming.pelvis);
			if ((references.pelvis == null || !Hierarchy.IsAncestor(references.leftThigh, references.pelvis)) && references.leftThigh != null)
			{
				references.pelvis = references.leftThigh.parent;
			}
			if (references.leftUpperArm != null && references.rightUpperArm != null && references.pelvis != null && references.leftThigh != null)
			{
				Transform firstCommonAncestor = Hierarchy.GetFirstCommonAncestor(references.leftUpperArm, references.rightUpperArm);
				if (firstCommonAncestor != null)
				{
					Transform[] array = new Transform[1] { firstCommonAncestor };
					Hierarchy.AddAncestors(array[0], references.pelvis, ref array);
					references.spine = new Transform[0];
					for (int num = array.Length - 1; num > -1; num--)
					{
						if (AddBoneToSpine(array[num], ref references, autoDetectParams))
						{
							Array.Resize(ref references.spine, references.spine.Length + 1);
							references.spine[references.spine.Length - 1] = array[num];
						}
					}
					if (references.head == null)
					{
						for (int i = 0; i < firstCommonAncestor.childCount; i++)
						{
							Transform child = firstCommonAncestor.GetChild(i);
							if (!Hierarchy.ContainsChild(child, references.leftUpperArm) && !Hierarchy.ContainsChild(child, references.rightUpperArm))
							{
								references.head = child;
								break;
							}
						}
					}
				}
			}
			Transform[] bonesOfType = BipedNaming.GetBonesOfType(BipedNaming.BoneType.Eye, componentsInChildren);
			references.eyes = new Transform[0];
			if (!autoDetectParams.includeEyes)
			{
				return;
			}
			for (int j = 0; j < bonesOfType.Length; j++)
			{
				if (AddBoneToEyes(bonesOfType[j], ref references, autoDetectParams))
				{
					Array.Resize(ref references.eyes, references.eyes.Length + 1);
					references.eyes[references.eyes.Length - 1] = bonesOfType[j];
				}
			}
		}

		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
			if (references == null)
			{
				references = new BipedReferences();
			}
			if (!(animator == null) && animator.isHuman)
			{
				references.spine = new Transform[0];
				references.eyes = new Transform[0];
				references.head = animator.GetBoneTransform(HumanBodyBones.Head);
				references.leftThigh = animator.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
				references.leftCalf = animator.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
				references.leftFoot = animator.GetBoneTransform(HumanBodyBones.LeftFoot);
				references.rightThigh = animator.GetBoneTransform(HumanBodyBones.RightUpperLeg);
				references.rightCalf = animator.GetBoneTransform(HumanBodyBones.RightLowerLeg);
				references.rightFoot = animator.GetBoneTransform(HumanBodyBones.RightFoot);
				references.leftUpperArm = animator.GetBoneTransform(HumanBodyBones.LeftUpperArm);
				references.leftForearm = animator.GetBoneTransform(HumanBodyBones.LeftLowerArm);
				references.leftHand = animator.GetBoneTransform(HumanBodyBones.LeftHand);
				references.rightUpperArm = animator.GetBoneTransform(HumanBodyBones.RightUpperArm);
				references.rightForearm = animator.GetBoneTransform(HumanBodyBones.RightLowerArm);
				references.rightHand = animator.GetBoneTransform(HumanBodyBones.RightHand);
				references.pelvis = animator.GetBoneTransform(HumanBodyBones.Hips);
				AddBoneToHierarchy(ref references.spine, animator.GetBoneTransform(HumanBodyBones.Spine));
				AddBoneToHierarchy(ref references.spine, animator.GetBoneTransform(HumanBodyBones.Chest));
				if (references.leftUpperArm != null && !IsNeckBone(animator.GetBoneTransform(HumanBodyBones.Neck), references.leftUpperArm))
				{
					AddBoneToHierarchy(ref references.spine, animator.GetBoneTransform(HumanBodyBones.Neck));
				}
				if (autoDetectParams.includeEyes)
				{
					AddBoneToHierarchy(ref references.eyes, animator.GetBoneTransform(HumanBodyBones.LeftEye));
					AddBoneToHierarchy(ref references.eyes, animator.GetBoneTransform(HumanBodyBones.RightEye));
				}
			}
		}

		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			if (!references.isFilled)
			{
				errorMessage = "BipedReferences contains one or more missing Transforms.";
				return true;
			}
			if (LimbError(references.leftThigh, references.leftCalf, references.leftFoot, ref errorMessage))
			{
				return true;
			}
			if (LimbError(references.rightThigh, references.rightCalf, references.rightFoot, ref errorMessage))
			{
				return true;
			}
			if (LimbError(references.leftUpperArm, references.leftForearm, references.leftHand, ref errorMessage))
			{
				return true;
			}
			if (LimbError(references.rightUpperArm, references.rightForearm, references.rightHand, ref errorMessage))
			{
				return true;
			}
			if (SpineError(references, ref errorMessage))
			{
				return true;
			}
			if (EyesError(references, ref errorMessage))
			{
				return true;
			}
			return false;
		}

		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			if (LimbWarning(references.leftThigh, references.leftCalf, references.leftFoot, ref warningMessage))
			{
				return true;
			}
			if (LimbWarning(references.rightThigh, references.rightCalf, references.rightFoot, ref warningMessage))
			{
				return true;
			}
			if (LimbWarning(references.leftUpperArm, references.leftForearm, references.leftHand, ref warningMessage))
			{
				return true;
			}
			if (LimbWarning(references.rightUpperArm, references.rightForearm, references.rightHand, ref warningMessage))
			{
				return true;
			}
			if (SpineWarning(references, ref warningMessage))
			{
				return true;
			}
			if (EyesWarning(references, ref warningMessage))
			{
				return true;
			}
			if (RootHeightWarning(references, ref warningMessage))
			{
				return true;
			}
			if (FacingAxisWarning(references, ref warningMessage))
			{
				return true;
			}
			return false;
		}

		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			if (leftUpperArm.parent != null && leftUpperArm.parent == bone)
			{
				return false;
			}
			if (Hierarchy.IsAncestor(leftUpperArm, bone))
			{
				return false;
			}
			return true;
		}

		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			if (references.head != null && !Hierarchy.IsAncestor(bone, references.head))
			{
				return false;
			}
			if (bone.GetComponent<SkinnedMeshRenderer>() != null)
			{
				return false;
			}
			return true;
		}

		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			if (bone == references.root)
			{
				return false;
			}
			if (bone == references.leftThigh.parent && !autoDetectParams.legsParentInSpine)
			{
				return false;
			}
			if (references.pelvis != null)
			{
				if (bone == references.pelvis)
				{
					return false;
				}
				if (Hierarchy.IsAncestor(references.pelvis, bone))
				{
					return false;
				}
			}
			return true;
		}

		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
			Transform[] bonesOfTypeAndSide = BipedNaming.GetBonesOfTypeAndSide(boneType, boneSide, transforms);
			if (bonesOfTypeAndSide.Length >= 3)
			{
				if (bonesOfTypeAndSide.Length == 3)
				{
					firstBone = bonesOfTypeAndSide[0];
					secondBone = bonesOfTypeAndSide[1];
					lastBone = bonesOfTypeAndSide[2];
				}
				if (bonesOfTypeAndSide.Length > 3)
				{
					firstBone = bonesOfTypeAndSide[0];
					secondBone = bonesOfTypeAndSide[2];
					lastBone = bonesOfTypeAndSide[bonesOfTypeAndSide.Length - 1];
				}
			}
		}

		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
			if (!(transform == null))
			{
				Array.Resize(ref bones, bones.Length + 1);
				bones[bones.Length - 1] = transform;
			}
		}

		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			if (bone1 == null)
			{
				errorMessage = "Bone 1 of a BipedReferences limb is null.";
				return true;
			}
			if (bone2 == null)
			{
				errorMessage = "Bone 2 of a BipedReferences limb is null.";
				return true;
			}
			if (bone3 == null)
			{
				errorMessage = "Bone 3 of a BipedReferences limb is null.";
				return true;
			}
			UnityEngine.Object[] objects = new Transform[3] { bone1, bone2, bone3 };
			Transform transform = (Transform)Hierarchy.ContainsDuplicate(objects);
			if (transform != null)
			{
				errorMessage = transform.name + " is represented multiple times in the same BipedReferences limb.";
				return true;
			}
			if (bone2.position == bone1.position)
			{
				errorMessage = "Second bone's position equals first bone's position in the biped's limb.";
				return true;
			}
			if (bone3.position == bone2.position)
			{
				errorMessage = "Third bone's position equals second bone's position in the biped's limb.";
				return true;
			}
			if (!Hierarchy.HierarchyIsValid(new Transform[3] { bone1, bone2, bone3 }))
			{
				errorMessage = "BipedReferences limb hierarchy is invalid. Bone transforms in a limb do not belong to the same ancestry. Please make sure the bones are parented to each other. Bones: " + bone1.name + ", " + bone2.name + ", " + bone3.name;
				return true;
			}
			return false;
		}

		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			if (Vector3.Cross(bone2.position - bone1.position, bone3.position - bone1.position) == Vector3.zero)
			{
				warningMessage = "BipedReferences limb is completely stretched out in the initial pose. IK solver can not calculate the default bend plane for the limb. Please make sure you character's limbs are at least slightly bent in the initial pose. First bone: " + bone1.name + ", second bone: " + bone2.name + ".";
				return true;
			}
			return false;
		}

		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			if (references.spine.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < references.spine.Length; i++)
			{
				if (references.spine[i] == null)
				{
					errorMessage = "BipedReferences spine bone at index " + i + " is null.";
					return true;
				}
			}
			UnityEngine.Object[] objects = references.spine;
			Transform transform = (Transform)Hierarchy.ContainsDuplicate(objects);
			if (transform != null)
			{
				errorMessage = transform.name + " is represented multiple times in BipedReferences spine.";
				return true;
			}
			if (!Hierarchy.HierarchyIsValid(references.spine))
			{
				errorMessage = "BipedReferences spine hierarchy is invalid. Bone transforms in the spine do not belong to the same ancestry. Please make sure the bones are parented to each other.";
				return true;
			}
			for (int j = 0; j < references.spine.Length; j++)
			{
				bool flag = false;
				if (j == 0 && references.spine[j].position == references.pelvis.position)
				{
					flag = true;
				}
				if (j != 0 && references.spine.Length > 1 && references.spine[j].position == references.spine[j - 1].position)
				{
					flag = true;
				}
				if (flag)
				{
					errorMessage = "Biped's spine bone nr " + j + " position is the same as it's parent spine/pelvis bone's position. Please remove this bone from the spine.";
					return true;
				}
			}
			return false;
		}

		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return false;
		}

		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			if (references.eyes.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < references.eyes.Length; i++)
			{
				if (references.eyes[i] == null)
				{
					errorMessage = "BipedReferences eye bone at index " + i + " is null.";
					return true;
				}
			}
			UnityEngine.Object[] objects = references.eyes;
			Transform transform = (Transform)Hierarchy.ContainsDuplicate(objects);
			if (transform != null)
			{
				errorMessage = transform.name + " is represented multiple times in BipedReferences eyes.";
				return true;
			}
			return false;
		}

		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return false;
		}

		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			if (references.head == null)
			{
				return false;
			}
			float verticalOffset = GetVerticalOffset(references.head.position, references.leftFoot.position, references.root.rotation);
			if (GetVerticalOffset(references.root.position, references.leftFoot.position, references.root.rotation) / verticalOffset > 0.2f)
			{
				warningMessage = "Biped's root Transform's position should be at ground level relative to the character (at the character's feet not at it's pelvis).";
				return true;
			}
			return false;
		}

		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			Vector3 vector = references.rightHand.position - references.leftHand.position;
			Vector3 vector2 = references.rightFoot.position - references.leftFoot.position;
			float num = Vector3.Dot(vector.normalized, references.root.right);
			float num2 = Vector3.Dot(vector2.normalized, references.root.right);
			if (num < 0f || num2 < 0f)
			{
				warningMessage = "Biped does not seem to be facing it's forward axis. Please make sure that in the initial pose the character is facing towards the positive Z axis of the Biped root gameobject.";
				return true;
			}
			return false;
		}

		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return (Quaternion.Inverse(rotation) * (p1 - p2)).y;
		}
	}
	public class Comments : MonoBehaviour
	{
		[Multiline]
		public string text;
	}
	public class DemoGUIMessage : MonoBehaviour
	{
		public string text;

		public Color color = Color.white;

		private void OnGUI()
		{
			GUI.color = color;
			GUILayout.Label(text);
			GUI.color = Color.white;
		}
	}
	public class Hierarchy
	{
		public static bool HierarchyIsValid(Transform[] bones)
		{
			for (int i = 1; i < bones.Length; i++)
			{
				if (!IsAncestor(bones[i], bones[i - 1]))
				{
					return false;
				}
			}
			return true;
		}

		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			for (int i = 0; i < objects.Length; i++)
			{
				for (int j = 0; j < objects.Length; j++)
				{
					if (i != j && objects[i] == objects[j])
					{
						return objects[i];
					}
				}
			}
			return null;
		}

		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			if (transform == null)
			{
				return true;
			}
			if (ancestor == null)
			{
				return true;
			}
			if (transform.parent == null)
			{
				return false;
			}
			if (transform.parent == ancestor)
			{
				return true;
			}
			return IsAncestor(transform.parent, ancestor);
		}

		public static bool ContainsChild(Transform transform, Transform child)
		{
			if (transform == child)
			{
				return true;
			}
			Transform[] componentsInChildren = transform.GetComponentsInChildren<Transform>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (componentsInChildren[i] == child)
				{
					return true;
				}
			}
			return false;
		}

		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
			if (transform.parent != null && transform.parent != blocker)
			{
				if (transform.parent.position != transform.position && transform.parent.position != blocker.position)
				{
					Array.Resize(ref array, array.Length + 1);
					array[array.Length - 1] = transform.parent;
				}
				AddAncestors(transform.parent, blocker, ref array);
			}
		}

		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			if (transform == null)
			{
				return null;
			}
			if (transform.parent != null)
			{
				if (transform.parent.childCount >= minChildCount)
				{
					return transform.parent;
				}
				return GetAncestor(transform.parent, minChildCount);
			}
			return null;
		}

		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			if (t1 == null)
			{
				return null;
			}
			if (t2 == null)
			{
				return null;
			}
			if (t1.parent == null)
			{
				return null;
			}
			if (t2.parent == null)
			{
				return null;
			}
			if (IsAncestor(t2, t1.parent))
			{
				return t1.parent;
			}
			return GetFirstCommonAncestor(t1.parent, t2);
		}

		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			if (transforms == null)
			{
				UnityEngine.Debug.LogWarning("Transforms is null.");
				return null;
			}
			if (transforms.Length == 0)
			{
				UnityEngine.Debug.LogWarning("Transforms.Length is 0.");
				return null;
			}
			for (int i = 0; i < transforms.Length; i++)
			{
				if (transforms[i] == null)
				{
					return null;
				}
				if (IsCommonAncestor(transforms[i], transforms))
				{
					return transforms[i];
				}
			}
			return GetFirstCommonAncestorRecursive(transforms[0], transforms);
		}

		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			if (transform == null)
			{
				UnityEngine.Debug.LogWarning("Transform is null.");
				return null;
			}
			if (transforms == null)
			{
				UnityEngine.Debug.LogWarning("Transforms is null.");
				return null;
			}
			if (transforms.Length == 0)
			{
				UnityEngine.Debug.LogWarning("Transforms.Length is 0.");
				return null;
			}
			if (IsCommonAncestor(transform, transforms))
			{
				return transform;
			}
			if (transform.parent == null)
			{
				return null;
			}
			return GetFirstCommonAncestorRecursive(transform.parent, transforms);
		}

		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			if (transform == null)
			{
				UnityEngine.Debug.LogWarning("Transform is null.");
				return false;
			}
			for (int i = 0; i < transforms.Length; i++)
			{
				if (transforms[i] == null)
				{
					UnityEngine.Debug.Log("Transforms[" + i + "] is null.");
					return false;
				}
				if (!IsAncestor(transforms[i], transform) && transforms[i] != transform)
				{
					return false;
				}
			}
			return true;
		}
	}
	[Serializable]
	public enum InterpolationMode
	{
		None,
		InOutCubic,
		InOutQuintic,
		InOutSine,
		InQuintic,
		InQuartic,
		InCubic,
		InQuadratic,
		InElastic,
		InElasticSmall,
		InElasticBig,
		InSine,
		InBack,
		OutQuintic,
		OutQuartic,
		OutCubic,
		OutInCubic,
		OutInQuartic,
		OutElastic,
		OutElasticSmall,
		OutElasticBig,
		OutSine,
		OutBack,
		OutBackCubic,
		OutBackQuartic,
		BackInCubic,
		BackInQuartic
	}
	public class Interp
	{
		public static float Float(float t, InterpolationMode mode)
		{
			float num = 0f;
			return mode switch
			{
				InterpolationMode.None => None(t, 0f, 1f), 
				InterpolationMode.InOutCubic => InOutCubic(t, 0f, 1f), 
				InterpolationMode.InOutQuintic => InOutQuintic(t, 0f, 1f), 
				InterpolationMode.InQuintic => InQuintic(t, 0f, 1f), 
				InterpolationMode.InQuartic => InQuartic(t, 0f, 1f), 
				InterpolationMode.InCubic => InCubic(t, 0f, 1f), 
				InterpolationMode.InQuadratic => InQuadratic(t, 0f, 1f), 
				InterpolationMode.OutQuintic => OutQuintic(t, 0f, 1f), 
				InterpolationMode.OutQuartic => OutQuartic(t, 0f, 1f), 
				InterpolationMode.OutCubic => OutCubic(t, 0f, 1f), 
				InterpolationMode.OutInCubic => OutInCubic(t, 0f, 1f), 
				InterpolationMode.OutInQuartic => OutInCubic(t, 0f, 1f), 
				InterpolationMode.BackInCubic => BackInCubic(t, 0f, 1f), 
				InterpolationMode.BackInQuartic => BackInQuartic(t, 0f, 1f), 
				InterpolationMode.OutBackCubic => OutBackCubic(t, 0f, 1f), 
				InterpolationMode.OutBackQuartic => OutBackQuartic(t, 0f, 1f), 
				InterpolationMode.OutElasticSmall => OutElasticSmall(t, 0f, 1f), 
				InterpolationMode.OutElasticBig => OutElasticBig(t, 0f, 1f), 
				InterpolationMode.InElasticSmall => InElasticSmall(t, 0f, 1f), 
				InterpolationMode.InElasticBig => InElasticBig(t, 0f, 1f), 
				InterpolationMode.InSine => InSine(t, 0f, 1f), 
				InterpolationMode.OutSine => OutSine(t, 0f, 1f), 
				InterpolationMode.InOutSine => InOutSine(t, 0f, 1f), 
				InterpolationMode.InElastic => OutElastic(t, 0f, 1f), 
				InterpolationMode.OutElastic => OutElastic(t, 0f, 1f), 
				InterpolationMode.InBack => InBack(t, 0f, 1f), 
				InterpolationMode.OutBack => OutBack(t, 0f, 1f), 
				_ => 0f, 
			};
		}

		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			float num = Float(t, mode);
			return (1f - num) * v1 + num * v2;
		}

		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			if (value == target)
			{
				return target;
			}
			if (value < target)
			{
				return Mathf.Clamp(value + Time.deltaTime * increaseSpeed, float.NegativeInfinity, target);
			}
			return Mathf.Clamp(value - Time.deltaTime * decreaseSpeed, target, float.PositiveInfinity);
		}

		private static float None(float t, float b, float c)
		{
			return b + c * t;
		}

		private static float InOutCubic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (-2f * num2 + 3f * num);
		}

		private static float InOutQuintic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (6f * num2 * num + -15f * num * num + 10f * num2);
		}

		private static float InQuintic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (num2 * num);
		}

		private static float InQuartic(float t, float b, float c)
		{
			float num = t * t;
			return b + c * (num * num);
		}

		private static float InCubic(float t, float b, float c)
		{
			float num = t * t * t;
			return b + c * num;
		}

		private static float InQuadratic(float t, float b, float c)
		{
			float num = t * t;
			return b + c * num;
		}

		private static float OutQuintic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (num2 * num + -5f * num * num + 10f * num2 + -10f * num + 5f * t);
		}

		private static float OutQuartic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (-1f * num * num + 4f * num2 + -6f * num + 4f * t);
		}

		private static float OutCubic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (num2 + -3f * num + 3f * t);
		}

		private static float OutInCubic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (4f * num2 + -6f * num + 3f * t);
		}

		private static float OutInQuartic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (6f * num2 + -9f * num + 4f * t);
		}

		private static float BackInCubic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (4f * num2 + -3f * num);
		}

		private static float BackInQuartic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (2f * num * num + 2f * num2 + -3f * num);
		}

		private static float OutBackCubic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (4f * num2 + -9f * num + 6f * t);
		}

		private static float OutBackQuartic(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (-2f * num * num + 10f * num2 + -15f * num + 8f * t);
		}

		private static float OutElasticSmall(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (33f * num2 * num + -106f * num * num + 126f * num2 + -67f * num + 15f * t);
		}

		private static float OutElasticBig(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (56f * num2 * num + -175f * num * num + 200f * num2 + -100f * num + 20f * t);
		}

		private static float InElasticSmall(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (33f * num2 * num + -59f * num * num + 32f * num2 + -5f * num);
		}

		private static float InElasticBig(float t, float b, float c)
		{
			float num = t * t;
			float num2 = num * t;
			return b + c * (56f * num2 * num + -105f * num * num + 60f * num2 + -10f * num);
		}

		private static float InSine(float t, float b, float c)
		{
			c -= b;
			return (0f - c) * Mathf.Cos(t / 1f * ((float)Math.PI / 2f)) + c + b;
		}

		private static float OutSine(float t, float b, float c)
		{
			c -= b;
			return c * Mathf.Sin(t / 1f * ((float)Math.PI / 2f)) + b;
		}

		private static float InOutSine(float t, float b, float c)
		{
			c -= b;
			return (0f - c) / 2f * (Mathf.Cos((float)Math.PI * t / 1f) - 1f) + b;
		}

		private static float InElastic(float t, float b, float c)
		{
			c -= b;
			float num = 1f;
			float num2 = num * 0.3f;
			float num3 = 0f;
			float num4 = 0f;
			if (t == 0f)
			{
				return b;
			}
			if ((t /= num) == 1f)
			{
				return b + c;
			}
			if (num4 == 0f || num4 < Mathf.Abs(c))
			{
				num4 = c;
				num3 = num2 / 4f;
			}
			else
			{
				num3 = num2 / ((float)Math.PI * 2f) * Mathf.Asin(c / num4);
			}
			return 0f - num4 * Mathf.Pow(2f, 10f * (t -= 1f)) * Mathf.Sin((t * num - num3) * ((float)Math.PI * 2f) / num2) + b;
		}

		private static float OutElastic(float t, float b, float c)
		{
			c -= b;
			float num = 1f;
			float num2 = num * 0.3f;
			float num3 = 0f;
			float num4 = 0f;
			if (t == 0f)
			{
				return b;
			}
			if ((t /= num) == 1f)
			{
				return b + c;
			}
			if (num4 == 0f || num4 < Mathf.Abs(c))
			{
				num4 = c;
				num3 = num2 / 4f;
			}
			else
			{
				num3 = num2 / ((float)Math.PI * 2f) * Mathf.Asin(c / num4);
			}
			return num4 * Mathf.Pow(2f, -10f * t) * Mathf.Sin((t * num - num3) * ((float)Math.PI * 2f) / num2) + c + b;
		}

		private static float InBack(float t, float b, float c)
		{
			c -= b;
			t /= 1f;
			float num = 1.70158f;
			return c * t * t * ((num + 1f) * t - num) + b;
		}

		private static float OutBack(float t, float b, float c)
		{
			float num = 1.70158f;
			c -= b;
			t = t / 1f - 1f;
			return c * (t * t * ((num + 1f) * t + num) + 1f) + b;
		}
	}
	public class LargeHeader : PropertyAttribute
	{
		public string name;

		public string color = "white";

		public LargeHeader(string name)
		{
			this.name = name;
			color = "white";
		}

		public LargeHeader(string name, string color)
		{
			this.name = name;
			this.color = color;
		}
	}
	public static class LayerMaskExtensions
	{
		public static bool Contains(LayerMask mask, int layer)
		{
			return (int)mask == ((int)mask | (1 << layer));
		}

		public static LayerMask Create(params string[] layerNames)
		{
			return NamesToMask(layerNames);
		}

		public static LayerMask Create(params int[] layerNumbers)
		{
			return LayerNumbersToMask(layerNumbers);
		}

		public static LayerMask NamesToMask(params string[] layerNames)
		{
			LayerMask layerMask = 0;
			foreach (string layerName in layerNames)
			{
				layerMask = (int)layerMask | (1 << LayerMask.NameToLayer(layerName));
			}
			return layerMask;
		}

		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			LayerMask layerMask = 0;
			foreach (int num in layerNumbers)
			{
				layerMask = (int)layerMask | (1 << num);
			}
			return layerMask;
		}

		public static LayerMask Inverse(this LayerMask original)
		{
			return ~(int)original;
		}

		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return (int)original | (int)NamesToMask(layerNames);
		}

		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return ~((int)(LayerMask)(~(int)original) | (int)NamesToMask(layerNames));
		}

		public static string[] MaskToNames(this LayerMask original)
		{
			List<string> list = new List<string>();
			for (int i = 0; i < 32; i++)
			{
				int num = 1 << i;
				if (((int)original & num) == num)
				{
					string text = LayerMask.LayerToName(i);
					if (!string.IsNullOrEmpty(text))
					{
						list.Add(text);
					}
				}
			}
			return list.ToArray();
		}

		public static int[] MaskToNumbers(this LayerMask original)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < 32; i++)
			{
				int num = 1 << i;
				if (((int)original & num) == num)
				{
					list.Add(i);
				}
			}
			return list.ToArray();
		}

		public static string MaskToString(this LayerMask original)
		{
			return original.MaskToString(", ");
		}

		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return string.Join(delimiter, original.MaskToNames());
		}
	}
	public static class QuaTools
	{
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			if (weight <= 0f)
			{
				return fromRotation;
			}
			if (weight >= 1f)
			{
				return toRotation;
			}
			return Quaternion.Lerp(fromRotation, toRotation, weight);
		}

		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			if (weight <= 0f)
			{
				return fromRotation;
			}
			if (weight >= 1f)
			{
				return toRotation;
			}
			return Quaternion.Slerp(fromRotation, toRotation, weight);
		}

		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			if (weight <= 0f)
			{
				return Quaternion.identity;
			}
			if (weight >= 1f)
			{
				return q;
			}
			return Quaternion.Lerp(Quaternion.identity, q, weight);
		}

		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			if (weight <= 0f)
			{
				return Quaternion.identity;
			}
			if (weight >= 1f)
			{
				return q;
			}
			return Quaternion.Slerp(Quaternion.identity, q, weight);
		}

		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection);
			float angle = 0f;
			Vector3 axis2 = Vector3.zero;
			quaternion.ToAngleAxis(out angle, out axis2);
			if (Vector3.Dot(axis2, axis) < 0f)
			{
				angle = 0f - angle;
			}
			return Quaternion.AngleAxis(angle, axis);
		}

		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return Quaternion.Inverse(Quaternion.Inverse(space) * rotation);
		}

		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			if (to == from)
			{
				return Quaternion.identity;
			}
			return to * Quaternion.Inverse(from);
		}

		public static Vector3 GetAxis(Vector3 v)
		{
			Vector3 vector = Vector3.right;
			bool flag = false;
			float num = Vector3.Dot(v, Vector3.right);
			float num2 = Mathf.Abs(num);
			if (num < 0f)
			{
				flag = true;
			}
			float num3 = Vector3.Dot(v, Vector3.up);
			float num4 = Mathf.Abs(num3);
			if (num4 > num2)
			{
				num2 = num4;
				vector = Vector3.up;
				flag = num3 < 0f;
			}
			float num5 = Vector3.Dot(v, Vector3.forward);
			num4 = Mathf.Abs(num5);
			if (num4 > num2)
			{
				vector = Vector3.forward;
				flag = num5 < 0f;
			}
			if (flag)
			{
				vector = -vector;
			}
			return vector;
		}

		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			if (clampWeight >= 1f)
			{
				return Quaternion.identity;
			}
			if (clampWeight <= 0f)
			{
				return rotation;
			}
			float num = Quaternion.Angle(Quaternion.identity, rotation);
			float num2 = 1f - num / 180f;
			float num3 = Mathf.Clamp(1f - (clampWeight - num2) / (1f - num2), 0f, 1f);
			float num4 = Mathf.Clamp(num2 / clampWeight, 0f, 1f);
			for (int i = 0; i < clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * (float)Math.PI * 0.5f);
			}
			return Quaternion.Slerp(Quaternion.identity, rotation, num4 * num3);
		}

		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			if (clampWeight >= 1f)
			{
				return 0f;
			}
			if (clampWeight <= 0f)
			{
				return angle;
			}
			float num = 1f - Mathf.Abs(angle) / 180f;
			float num2 = Mathf.Clamp(1f - (clampWeight - num) / (1f - num), 0f, 1f);
			float num3 = Mathf.Clamp(num / clampWeight, 0f, 1f);
			for (int i = 0; i < clampSmoothing; i++)
			{
				num3 = Mathf.Sin(num3 * (float)Math.PI * 0.5f);
			}
			return Mathf.Lerp(0f, angle, num3 * num2);
		}
	}
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		private static T sInstance;

		public static T instance => sInstance;

		protected virtual void Awake()
		{
			if (sInstance != null)
			{
				UnityEngine.Debug.LogError(base.name + "error: already initialized", this);
			}
			sInstance = (T)this;
		}
	}
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		public GameObject target;

		private void OnTriggerEnter(Collider collider)
		{
			if (target != null)
			{
				target.SendMessage("OnTriggerEnter", collider, SendMessageOptions.DontRequireReceiver);
			}
		}

		private void OnTriggerStay(Collider collider)
		{
			if (target != null)
			{
				target.SendMessage("OnTriggerStay", collider, SendMessageOptions.DontRequireReceiver);
			}
		}

		private void OnTriggerExit(Collider collider)
		{
			if (target != null)
			{
				target.SendMessage("OnTriggerExit", collider, SendMessageOptions.DontRequireReceiver);
			}
		}
	}
	public static class V3Tools
	{
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			if (weight <= 0f)
			{
				return fromVector;
			}
			if (weight >= 1f)
			{
				return toVector;
			}
			return Vector3.Lerp(fromVector, toVector, weight);
		}

		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			if (weight <= 0f)
			{
				return fromVector;
			}
			if (weight >= 1f)
			{
				return toVector;
			}
			return Vector3.Slerp(fromVector, toVector, weight);
		}

		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			if (weight == 0f)
			{
				return Vector3.zero;
			}
			return Vector3.Project(v, verticalAxis) * weight;
		}

		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			if (weight == 0f)
			{
				return Vector3.zero;
			}
			Vector3 tangent = v;
			Vector3.OrthoNormalize(ref normal, ref tangent);
			return Vector3.Project(v, tangent) * weight;
		}

		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			changed = false;
			if (clampWeight <= 0f)
			{
				return direction;
			}
			if (clampWeight >= 1f)
			{
				changed = true;
				return normalDirection;
			}
			float num = Vector3.Angle(normalDirection, direction);
			float num2 = 1f - num / 180f;
			if (num2 > clampWeight)
			{
				return direction;
			}
			changed = true;
			float num3 = ((clampWeight > 0f) ? Mathf.Clamp(1f - (clampWeight - num2) / (1f - num2), 0f, 1f) : 1f);
			float num4 = ((clampWeight > 0f) ? Mathf.Clamp(num2 / clampWeight, 0f, 1f) : 1f);
			for (int i = 0; i < clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * (float)Math.PI * 0.5f);
			}
			return Vector3.Slerp(normalDirection, direction, num4 * num3);
		}

		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			clampValue = 1f;
			if (clampWeight <= 0f)
			{
				return direction;
			}
			if (clampWeight >= 1f)
			{
				return normalDirection;
			}
			float num = Vector3.Angle(normalDirection, direction);
			float num2 = 1f - num / 180f;
			if (num2 > clampWeight)
			{
				clampValue = 0f;
				return direction;
			}
			float num3 = ((clampWeight > 0f) ? Mathf.Clamp(1f - (clampWeight - num2) / (1f - num2), 0f, 1f) : 1f);
			float num4 = ((clampWeight > 0f) ? Mathf.Clamp(num2 / clampWeight, 0f, 1f) : 1f);
			for (int i = 0; i < clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * (float)Math.PI * 0.5f);
			}
			float num5 = num4 * num3;
			clampValue = 1f - num5;
			return Vector3.Slerp(normalDirection, direction, num5);
		}

		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			float num = Vector3.Dot(planePoint - origin, planeNormal);
			float num2 = Vector3.Dot(direction, planeNormal);
			if (num2 == 0f)
			{
				return Vector3.zero;
			}
			float num3 = num / num2;
			return origin + direction.normalized * num3;
		}
	}
	public static class Warning
	{
		public delegate void Logger(string message);

		public static bool logged;

		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
			if ((logInEditMode || Application.isPlaying) && !logged)
			{
				logger?.Invoke(message);
				logged = true;
			}
		}

		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
			if ((logInEditMode || Application.isPlaying) && !logged)
			{
				UnityEngine.Debug.LogWarning(message, context);
				logged = true;
			}
		}
	}
}
namespace RootMotion.Dynamics
{
	[HelpURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/Ragdoll Manager/Biped Ragdoll Creator")]
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		public struct Options
		{
			public float weight;

			[Header("Optional Bones")]
			public bool spine;

			public bool chest;

			public bool hands;

			public bool feet;

			[Header("Joints")]
			public JointType joints;

			public float jointRange;

			[Header("Colliders")]
			public float colliderLengthOverlap;

			public ColliderType torsoColliders;

			public ColliderType headCollider;

			public ColliderType armColliders;

			public ColliderType handColliders;

			public ColliderType legColliders;

			public ColliderType footColliders;

			public static Options Default
			{
				get
				{
					Options result = default(Options);
					result.weight = 75f;
					result.colliderLengthOverlap = 0.1f;
					result.jointRange = 1f;
					result.chest = true;
					result.headCollider = ColliderType.Capsule;
					result.armColliders = ColliderType.Capsule;
					result.hands = true;
					result.handColliders = ColliderType.Capsule;
					result.legColliders = ColliderType.Capsule;
					result.feet = true;
					return result;
				}
			}
		}

		public bool canBuild;

		public BipedRagdollReferences references;

		public Options options = Options.Default;

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://root-motion.com/puppetmasterdox/html/page1.html");
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://root-motion.com/puppetmasterdox/html/class_root_motion_1_1_dynamics_1_1_biped_ragdoll_creator.html#details");
		}

		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL");
		}

		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			Options @default = Options.Default;
			if (r.spine == null)
			{
				@default.spine = false;
			}
			if (r.chest == null)
			{
				@default.chest = false;
			}
			if (@default.chest && Vector3.Dot(r.root.up, r.chest.position - GetUpperArmCentroid(r)) > 0f)
			{
				@default.chest = false;
				if (r.spine != null)
				{
					@default.spine = true;
				}
			}
			return @default;
		}

		public static void Create(BipedRagdollReferences r, Options options)
		{
			if (r.IsValid())
			{
				RagdollCreator.ClearAll(r.root);
				CreateColliders(r, options);
				MassDistribution(r, options);
				CreateJoints(r, options);
			}
		}

		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
			Vector3 upperArmToHeadCentroid = GetUpperArmToHeadCentroid(r);
			if (r.spine == null)
			{
				options.spine = false;
			}
			if (r.chest == null)
			{
				options.chest = false;
			}
			Vector3 widthDirection = r.rightUpperArm.position - r.leftUpperArm.position;
			float magnitude = widthDirection.magnitude;
			float proportionAspect = 0.6f;
			Vector3 vector = r.hips.position;
			float num = Vector3.Distance(r.head.position, r.root.position);
			if (Vector3.Distance(r.hips.position, r.root.position) < num * 0.2f)
			{
				vector = Vector3.Lerp(r.leftUpperLeg.position, r.rightUpperLeg.position, 0.5f);
			}
			Vector3 vector2 = (options.spine ? r.spine.position : (options.chest ? r.chest.position : upperArmToHeadCentroid));
			vector += (vector - upperArmToHeadCentroid) * 0.1f;
			float width = ((options.spine || options.chest) ? (magnitude * 0.8f) : magnitude);
			RagdollCreator.CreateCollider(r.hips, vector, vector2, options.torsoColliders, options.colliderLengthOverlap, width, proportionAspect, widthDirection);
			if (options.spine)
			{
				Vector3 startPoint = vector2;
				vector2 = (options.chest ? r.chest.position : upperArmToHeadCentroid);
				float width2 = (options.chest ? (magnitude * 0.75f) : magnitude);
				RagdollCreator.CreateCollider(r.spine, startPoint, vector2, options.torsoColliders, options.colliderLengthOverlap, width2, proportionAspect, widthDirection);
			}
			if (options.chest)
			{
				Vector3 startPoint2 = vector2;
				vector2 = upperArmToHeadCentroid;
				RagdollCreator.CreateCollider(r.chest, startPoint2, vector2, options.torsoColliders, options.colliderLengthOverlap, magnitude, proportionAspect, widthDirection);
			}
			Vector3 vector3 = vector2;
			Vector3 vector4 = vector3 + (vector3 - vector) * 0.45f;
			Vector3 onNormal = r.head.TransformVector(AxisTools.GetAxisVectorToDirection(r.head, vector4 - vector3));
			vector4 = vector3 + Vector3.Project(vector4 - vector3, onNormal).normalized * (vector4 - vector3).magnitude;
			RagdollCreator.CreateCollider(r.head, vector3, vector4, options.headCollider, options.colliderLengthOverlap, Vector3.Distance(vector3, vector4) * 0.8f);
			float num2 = 0.4f;
			float num3 = Vector3.Distance(r.leftUpperArm.position, r.leftLowerArm.position) * num2;
			RagdollCreator.CreateCollider(r.leftUpperArm, r.leftUpperArm.position, r.leftLowerArm.position, options.armColliders, options.colliderLengthOverlap, num3);
			RagdollCreator.CreateCollider(r.leftLowerArm, r.leftLowerArm.position, r.leftHand.position, options.armColliders, options.colliderLengthOverlap, num3 * 0.9f);
			float num4 = Vector3.Distance(r.rightUpperArm.position, r.rightLowerArm.position) * num2;
			RagdollCreator.CreateCollider(r.rightUpperArm, r.rightUpperArm.position, r.rightLowerArm.position, options.armColliders, options.colliderLengthOverlap, num4);
			RagdollCreator.CreateCollider(r.rightLowerArm, r.rightLowerArm.position, r.rightHand.position, options.armColliders, options.colliderLengthOverlap, num4 * 0.9f);
			float num5 = 0.3f;
			float num6 = Vector3.Distance(r.leftUpperLeg.position, r.leftLowerLeg.position) * num5;
			RagdollCreator.CreateCollider(r.leftUpperLeg, r.leftUpperLeg.position, r.leftLowerLeg.position, options.legColliders, options.colliderLengthOverlap, num6);
			RagdollCreator.CreateCollider(r.leftLowerLeg, r.leftLowerLeg.position, r.leftFoot.position, options.legColliders, options.colliderLengthOverlap, num6 * 0.9f);
			float num7 = Vector3.Distance(r.rightUpperLeg.position, r.rightLowerLeg.position) * num5;
			RagdollCreator.CreateCollider(r.rightUpperLeg, r.rightUpperLeg.position, r.rightLowerLeg.position, options.legColliders, options.colliderLengthOverlap, num7);
			RagdollCreator.CreateCollider(r.rightLowerLeg, r.rightLowerLeg.position, r.rightFoot.position, options.legColliders, options.colliderLengthOverlap, num7 * 0.9f);
			if (options.hands)
			{
				CreateHandCollider(r.leftHand, r.leftLowerArm, r.root, options);
				CreateHandCollider(r.rightHand, r.rightLowerArm, r.root, options);
			}
			if (options.feet)
			{
				CreateFootCollider(r.leftFoot, r.leftLowerLeg, r.leftUpperLeg, r.root, options);
				CreateFootCollider(r.rightFoot, r.rightLowerLeg, r.rightUpperLeg, r.root, options);
			}
		}

		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
			Vector3 onNormal = hand.TransformVector(AxisTools.GetAxisVectorToPoint(hand, GetChildCentroid(hand, lowerArm.position)));
			Vector3 vector = hand.position - (lowerArm.position - hand.position) * 0.75f;
			vector = hand.position + Vector3.Project(vector - hand.position, onNormal).normalized * (vector - hand.position).magnitude;
			RagdollCreator.CreateCollider(hand, hand.position, vector, options.handColliders, options.colliderLengthOverlap, Vector3.Distance(vector, hand.position) * 0.5f);
		}

		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
			float magnitude = (upperLeg.position - foot.position).magnitude;
			Vector3 onNormal = foot.TransformVector(AxisTools.GetAxisVectorToPoint(foot, GetChildCentroid(foot, foot.position + root.forward) + root.forward * magnitude * 0.2f));
			Vector3 vector = foot.position + root.forward * magnitude * 0.25f;
			vector = foot.position + Vector3.Project(vector - foot.position, onNormal).normalized * (vector - foot.position).magnitude;
			float num = Vector3.Distance(vector, foot.position) * 0.5f;
			Vector3 position = foot.position;
			Vector3 vector2 = ((Vector3.Dot(root.up, foot.position - root.position) < 0f) ? Vector3.zero : Vector3.Project(position - root.up * num * 0.5f - root.position, root.up));
			Vector3 vector3 = vector - position;
			position -= vector3 * 0.2f;
			RagdollCreator.CreateCollider(foot, position - vector2, vector - vector2, options.footColliders, options.colliderLengthOverlap, num);
		}

		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			if (t.childCount == 0)
			{
				return fallback;
			}
			Vector3 zero = Vector3.zero;
			for (int i = 0; i < t.childCount; i++)
			{
				zero += t.GetChild(i).position;
			}
			return zero / t.childCount;
		}

		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
			int num = 3;
			if (r.spine == null)
			{
				o.spine = false;
				num--;
			}
			if (r.chest == null)
			{
				o.chest = false;
				num--;
			}
			float num2 = 0.508f / (float)num;
			float num3 = 0.0732f;
			float num4 = 0.027f;
			float num5 = 0.016f;
			float num6 = 0.0066f;
			float num7 = 0.0988f;
			float num8 = 0.0465f;
			float num9 = 0.0145f;
			r.hips.GetComponent<Rigidbody>().mass = num2 * o.weight;
			if (o.spine)
			{
				r.spine.GetComponent<Rigidbody>().mass = num2 * o.weight;
			}
			if (o.chest)
			{
				r.chest.GetComponent<Rigidbody>().mass = num2 * o.weight;
			}
			r.head.GetComponent<Rigidbody>().mass = num3 * o.weight;
			r.leftUpperArm.GetComponent<Rigidbody>().mass = num4 * o.weight;
			r.rightUpperArm.GetComponent<Rigidbody>().mass = r.leftUpperArm.GetComponent<Rigidbody>().mass;
			r.leftLowerArm.GetComponent<Rigidbody>().mass = num5 * o.weight;
			r.rightLowerArm.GetComponent<Rigidbody>().mass = r.leftLowerArm.GetComponent<Rigidbody>().mass;
			if (o.hands)
			{
				r.leftHand.GetComponent<Rigidbody>().mass = num6 * o.weight;
				r.rightHand.GetComponent<Rigidbody>().mass = r.leftHand.GetComponent<Rigidbody>().mass;
			}
			r.leftUpperLeg.GetComponent<Rigidbody>().mass = num7 * o.weight;
			r.rightUpperLeg.GetComponent<Rigidbody>().mass = r.leftUpperLeg.GetComponent<Rigidbody>().mass;
			r.leftLowerLeg.GetComponent<Rigidbody>().mass = num8 * o.weight;
			r.rightLowerLeg.GetComponent<Rigidbody>().mass = r.leftLowerLeg.GetComponent<Rigidbody>().mass;
			if (o.feet)
			{
				r.leftFoot.GetComponent<Rigidbody>().mass = num9 * o.weight;
				r.rightFoot.GetComponent<Rigidbody>().mass = r.leftFoot.GetComponent<Rigidbody>().mass;
			}
		}

		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
			if (r.spine == null)
			{
				o.spine = false;
			}
			if (r.chest == null)
			{
				o.chest = false;
			}
			float minSwing = -30f * o.jointRange;
			float maxSwing = 10f * o.jointRange;
			float swing = 25f * o.jointRange;
			float twist = 25f * o.jointRange;
			RagdollCreator.CreateJoint(new CreateJointParams(r.hips.GetComponent<Rigidbody>(), null, o.spine ? r.spine : (o.chest ? r.chest : r.head), r.root.right, new CreateJointParams.Limits(0f, 0f, 0f, 0f), o.joints));
			if (o.spine)
			{
				RagdollCreator.CreateJoint(new CreateJointParams(r.spine.GetComponent<Rigidbody>(), r.hips.GetComponent<Rigidbody>(), o.chest ? r.chest : r.head, r.root.right, new CreateJointParams.Limits(minSwing, maxSwing, swing, twist), o.joints));
			}
			if (o.chest)
			{
				RagdollCreator.CreateJoint(new CreateJointParams(r.chest.GetComponent<Rigidbody>(), o.spine ? r.spine.GetComponent<Rigidbody>() : r.hips.GetComponent<Rigidbody>(), r.head, r.root.right, new CreateJointParams.Limits(minSwing, maxSwing, swing, twist), o.joints));
			}
			Transform transform = (o.chest ? r.chest : (o.spine ? r.spine : r.hips));
			RagdollCreator.CreateJoint(new CreateJointParams(r.head.GetComponent<Rigidbody>(), transform.GetComponent<Rigidbody>(), null, r.root.right, new CreateJointParams.Limits(-30f, 30f, 30f, 85f), o.joints));
			CreateJointParams.Limits limits = new CreateJointParams.Limits(-35f * o.jointRange, 120f * o.jointRange, 85f * o.jointRange, 45f * o.jointRange);
			CreateJointParams.Limits limits2 = new CreateJointParams.Limits(0f, 140f * o.jointRange, 10f * o.jointRange, 45f * o.jointRange);
			CreateJointParams.Limits limits3 = new CreateJointParams.Limits(-50f * o.jointRange, 50f * o.jointRange, 50f * o.jointRange, 25f * o.jointRange);
			CreateLimbJoints(transform, r.leftUpperArm, r.leftLowerArm, r.leftHand, r.root, -r.root.right, o.joints, limits, limits2, limits3);
			CreateLimbJoints(transform, r.rightUpperArm, r.rightLowerArm, r.rightHand, r.root, r.root.right, o.joints, limits, limits2, limits3);
			CreateJointParams.Limits limits4 = new CreateJointParams.Limits(-120f * o.jointRange, 35f * o.jointRange, 85f * o.jointRange, 45f * o.jointRange);
			CreateJointParams.Limits limits5 = new CreateJointParams.Limits(0f, 140f * o.jointRange, 10f * o.jointRange, 45f * o.jointRange);
			CreateJointParams.Limits limits6 = new CreateJointParams.Limits(-50f * o.jointRange, 50f * o.jointRange, 50f * o.jointRange, 25f * o.jointRange);
			CreateLimbJoints(r.hips, r.leftUpperLeg, r.leftLowerLeg, r.leftFoot, r.root, -r.root.up, o.joints, limits4, limits5, limits6);
			CreateLimbJoints(r.hips, r.rightUpperLeg, r.rightLowerLeg, r.rightFoot, r.root, -r.root.up, o.joints, limits4, limits5, limits6);
		}

		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
			Quaternion localRotation = bone1.localRotation;
			bone1.rotation = Quaternion.FromToRotation(bone1.rotation * (bone2.position - bone1.position), defaultWorldDirection) * bone1.rotation;
			Vector3 normalized = (bone2.position - bone1.position).normalized;
			Vector3 normalized2 = (bone3.position - bone2.position).normalized;
			Vector3 worldSwingAxis = -Vector3.Cross(normalized, normalized2);
			float num = Vector3.Angle(normalized, normalized2);
			bool flag = Mathf.Abs(Vector3.Dot(normalized, root.up)) > 0.5f;
			float num2 = (flag ? 100f : 1f);
			if (num < 0.01f * num2)
			{
				worldSwingAxis = ((!flag) ? ((Vector3.Dot(normalized, root.right) > 0f) ? root.up : (-root.up)) : ((Vector3.Dot(normalized, root.up) > 0f) ? root.right : (-root.right)));
			}
			RagdollCreator.CreateJoint(new CreateJointParams(bone1.GetComponent<Rigidbody>(), connectedBone.GetComponent<Rigidbody>(), bone2, worldSwingAxis, limits1, jointType));
			RagdollCreator.CreateJoint(new CreateJointParams(bone2.GetComponent<Rigidbody>(), bone1.GetComponent<Rigidbody>(), bone3, worldSwingAxis, new CreateJointParams.Limits(limits2.minSwing - num, limits2.maxSwing - num, limits2.swing2, limits2.twist), jointType));
			if (bone3.GetComponent<Rigidbody>() != null)
			{
				RagdollCreator.CreateJoint(new CreateJointParams(bone3.GetComponent<Rigidbody>(), bone2.GetComponent<Rigidbody>(), null, worldSwingAxis, limits3, jointType));
			}
			bone1.localRotation = localRotation;
		}

		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
			Transform[] ragdollTransforms = r.GetRagdollTransforms();
			for (int i = 0; i < ragdollTransforms.Length; i++)
			{
				RagdollCreator.ClearTransform(ragdollTransforms[i]);
			}
		}

		public static bool IsClear(BipedRagdollReferences r)
		{
			Transform[] ragdollTransforms = r.GetRagdollTransforms();
			for (int i = 0; i < ragdollTransforms.Length; i++)
			{
				if (ragdollTransforms[i].GetComponent<Rigidbody>() != null)
				{
					return false;
				}
			}
			return true;
		}

		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return Vector3.Lerp(GetUpperArmCentroid(r), r.head.position, 0.5f);
		}

		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return Vector3.Lerp(r.leftUpperArm.position, r.rightUpperArm.position, 0.5f);
		}
	}
	[Serializable]
	public struct BipedRagdollReferences
	{
		public Transform root;

		public Transform hips;

		public Transform spine;

		public Transform chest;

		public Transform head;

		public Transform leftUpperLeg;

		public Transform leftLowerLeg;

		public Transform leftFoot;

		public Transform rightUpperLeg;

		public Transform rightLowerLeg;

		public Transform rightFoot;

		public Transform leftUpperArm;

		public Transform leftLowerArm;

		public Transform leftHand;

		public Transform rightUpperArm;

		public Transform rightLowerArm;

		public Transform rightHand;

		public bool IsValid()
		{
			if (root == null || hips == null || head == null || leftUpperArm == null || leftLowerArm == null || leftHand == null || rightUpperArm == null || rightLowerArm == null || rightHand == null || leftUpperLeg == null || leftLowerLeg == null || leftFoot == null || rightUpperLeg == null || rightLowerLeg == null || rightFoot == null)
			{
				return false;
			}
			return true;
		}

		public bool IsEmpty(bool considerRoot)
		{
			if (considerRoot && root != null)
			{
				return false;
			}
			if (hips != null || head != null || spine != null || chest != null || leftUpperArm != null || leftLowerArm != null || leftHand != null || rightUpperArm != null || rightLowerArm != null || rightHand != null || leftUpperLeg != null || leftLowerLeg != null || leftFoot != null || rightUpperLeg != null || rightLowerLeg != null || rightFoot != null)
			{
				return false;
			}
			return true;
		}

		public bool Contains(Transform t, bool ignoreRoot = false)
		{
			if (!ignoreRoot && root == t)
			{
				return true;
			}
			if (hips == t)
			{
				return true;
			}
			if (spine == t)
			{
				return true;
			}
			if (chest == t)
			{
				return true;
			}
			if (leftUpperLeg == t)
			{
				return true;
			}
			if (leftLowerLeg == t)
			{
				return true;
			}
			if (leftFoot == t)
			{
				return true;
			}
			if (rightUpperLeg == t)
			{
				return true;
			}
			if (rightLowerLeg == t)
			{
				return true;
			}
			if (rightFoot == t)
			{
				return true;
			}
			if (leftUpperArm == t)
			{
				return true;
			}
			if (leftLowerArm == t)
			{
				return true;
			}
			if (leftHand == t)
			{
				return true;
			}
			if (rightUpperArm == t)
			{
				return true;
			}
			if (rightLowerArm == t)
			{
				return true;
			}
			if (rightHand == t)
			{
				return true;
			}
			if (head == t)
			{
				return true;
			}
			return false;
		}

		public Transform[] GetRagdollTransforms()
		{
			return new Transform[16]
			{
				hips, spine, chest, head, leftUpperArm, leftLowerArm, leftHand, rightUpperArm, rightLowerArm, rightHand,
				leftUpperLeg, leftLowerLeg, leftFoot, rightUpperLeg, rightLowerLeg, rightFoot
			};
		}

		public static BipedRagdollReferences FromAvatar(Animator animator)
		{
			BipedRagdollReferences result = default(BipedRagdollReferences);
			if (!animator.isHuman)
			{
				return result;
			}
			result.root = animator.transform;
			result.hips = animator.GetBoneTransform(HumanBodyBones.Hips);
			result.spine = animator.GetBoneTransform(HumanBodyBones.Spine);
			result.chest = animator.GetBoneTransform(HumanBodyBones.Chest);
			result.head = animator.GetBoneTransform(HumanBodyBones.Head);
			result.leftUpperArm = animator.GetBoneTransform(HumanBodyBones.LeftUpperArm);
			result.leftLowerArm = animator.GetBoneTransform(HumanBodyBones.LeftLowerArm);
			result.leftHand = animator.GetBoneTransform(HumanBodyBones.LeftHand);
			result.rightUpperArm = animator.GetBoneTransform(HumanBodyBones.RightUpperArm);
			result.rightLowerArm = animator.GetBoneTransform(HumanBodyBones.RightLowerArm);
			result.rightHand = animator.GetBoneTransform(HumanBodyBones.RightHand);
			result.leftUpperLeg = animator.GetBoneTransform(HumanBodyBones.LeftUpperLeg);
			result.leftLowerLeg = animator.GetBoneTransform(HumanBodyBones.LeftLowerLeg);
			result.leftFoot = animator.GetBoneTransform(HumanBodyBones.LeftFoot);
			result.rightUpperLeg = animator.GetBoneTransform(HumanBodyBones.RightUpperLeg);
			result.rightLowerLeg = animator.GetBoneTransform(HumanBodyBones.RightLowerLeg);
			result.rightFoot = animator.GetBoneTransform(HumanBodyBones.RightFoot);
			return result;
		}

		public static BipedRagdollReferences FromBipedReferences(BipedReferences biped)
		{
			BipedRagdollReferences result = default(BipedRagdollReferences);
			result.root = biped.root;
			result.hips = biped.pelvis;
			if (biped.spine != null && biped.spine.Length != 0)
			{
				result.spine = biped.spine[0];
				if (biped.spine.Length > 1)
				{
					result.chest = biped.spine[biped.spine.Length - 1];
				}
			}
			result.head = biped.head;
			result.leftUpperArm = biped.leftUpperArm;
			result.leftLowerArm = biped.leftForearm;
			result.leftHand = biped.leftHand;
			result.rightUpperArm = biped.rightUpperArm;
			result.rightLowerArm = biped.rightForearm;
			result.rightHand = biped.rightHand;
			result.leftUpperLeg = biped.leftThigh;
			result.leftLowerLeg = biped.leftCalf;
			result.leftFoot = biped.leftFoot;
			result.rightUpperLeg = biped.rightThigh;
			result.rightLowerLeg = biped.rightCalf;
			result.rightFoot = biped.rightFoot;
			return result;
		}
	}
	public static class JointConverter
	{
		public static void ToConfigurable(GameObject root)
		{
			int num = 0;
			CharacterJoint[] componentsInChildren = root.GetComponentsInChildren<CharacterJoint>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				CharacterToConfigurable(componentsInChildren[i]);
				num++;
			}
			HingeJoint[] componentsInChildren2 = root.GetComponentsInChildren<HingeJoint>();
			for (int j = 0; j < componentsInChildren2.Length; j++)
			{
				HingeToConfigurable(componentsInChildren2[j]);
				num++;
			}
			FixedJoint[] componentsInChildren3 = root.GetComponentsInChildren<FixedJoint>();
			for (int k = 0; k < componentsInChildren3.Length; k++)
			{
				FixedToConfigurable(componentsInChildren3[k]);
				num++;
			}
			SpringJoint[] componentsInChildren4 = root.GetComponentsInChildren<SpringJoint>();
			for (int l = 0; l < componentsInChildren4.Length; l++)
			{
				SpringToConfigurable(componentsInChildren4[l]);
				num++;
			}
			if (num > 0)
			{
				UnityEngine.Debug.Log(num + " joints were successfully converted to ConfigurableJoints.");
			}
			else
			{
				UnityEngine.Debug.Log("No joints found in the children of " + root.name + " to convert to ConfigurableJoints.");
			}
		}

		public static void HingeToConfigurable(HingeJoint src)
		{
			ConfigurableJoint conf = src.gameObject.AddComponent<ConfigurableJoint>();
			ConvertJoint(ref conf, src);
			conf.secondaryAxis = Vector3.zero;
			conf.xMotion = ConfigurableJointMotion.Locked;
			conf.yMotion = ConfigurableJointMotion.Locked;
			conf.zMotion = ConfigurableJointMotion.Locked;
			conf.angularXMotion = (src.useLimits ? ConfigurableJointMotion.Limited : ConfigurableJointMotion.Free);
			conf.angularYMotion = ConfigurableJointMotion.Locked;
			conf.angularZMotion = ConfigurableJointMotion.Locked;
			conf.highAngularXLimit = ConvertToHighSoftJointLimit(src.limits, src.spring, src.useSpring);
			conf.angularXLimitSpring = ConvertToSoftJointLimitSpring(src.limits, src.spring, src.useSpring);
			conf.lowAngularXLimit = ConvertToLowSoftJointLimit(src.limits, src.spring, src.useSpring);
			if (src.useMotor)
			{
				UnityEngine.Debug.LogWarning("Can not convert HingeJoint Motor to ConfigurableJoint.");
			}
			UnityEngine.Object.DestroyImmediate(src);
		}

		public static void FixedToConfigurable(FixedJoint src)
		{
			ConfigurableJoint conf = src.gameObject.AddComponent<ConfigurableJoint>();
			ConvertJoint(ref conf, src);
			conf.secondaryAxis = Vector3.zero;
			conf.xMotion = ConfigurableJointMotion.Locked;
			conf.yMotion = ConfigurableJointMotion.Locked;
			conf.zMotion = ConfigurableJointMotion.Locked;
			conf.angularXMotion = ConfigurableJointMotion.Locked;
			conf.angularYMotion = ConfigurableJointMotion.Locked;
			conf.angularZMotion = ConfigurableJointMotion.Locked;
			UnityEngine.Object.DestroyImmediate(src);
		}

		public static void SpringToConfigurable(SpringJoint src)
		{
			ConfigurableJoint conf = src.gameObject.AddComponent<ConfigurableJoint>();
			ConvertJoint(ref conf, src);
			conf.xMotion = ConfigurableJointMotion.Limited;
			conf.yMotion = ConfigurableJointMotion.Limited;
			conf.zMotion = ConfigurableJointMotion.Limited;
			conf.angularXMotion = ConfigurableJointMotion.Free;
			conf.angularYMotion = ConfigurableJointMotion.Free;
			conf.angularZMotion = ConfigurableJointMotion.Free;
			SoftJointLimit linearLimit = default(SoftJointLimit);
			linearLimit.bounciness = 0f;
			linearLimit.limit = src.maxDistance;
			conf.linearLimit = linearLimit;
			SoftJointLimitSpring linearLimitSpring = default(SoftJointLimitSpring);
			linearLimitSpring.damper = src.damper;
			linearLimitSpring.spring = src.spring;
			conf.linearLimitSpring = linearLimitSpring;
			UnityEngine.Object.DestroyImmediate(src);
		}

		public static void CharacterToConfigurable(CharacterJoint src)
		{
			ConfigurableJoint conf = src.gameObject.AddComponent<ConfigurableJoint>();
			ConvertJoint(ref conf, src);
			conf.secondaryAxis = src.swingAxis;
			conf.xMotion = ConfigurableJointMotion.Locked;
			conf.yMotion = ConfigurableJointMotion.Locked;
			conf.zMotion = ConfigurableJointMotion.Locked;
			conf.angularXMotion = ConfigurableJointMotion.Limited;
			conf.angularYMotion = ConfigurableJointMotion.Limited;
			conf.angularZMotion = ConfigurableJointMotion.Limited;
			conf.highAngularXLimit = CopyLimit(src.highTwistLimit);
			conf.lowAngularXLimit = CopyLimit(src.lowTwistLimit);
			conf.angularYLimit = CopyLimit(src.swing1Limit);
			conf.angularZLimit = CopyLimit(src.swing2Limit);
			conf.angularXLimitSpring = CopyLimitSpring(src.twistLimitSpring);
			conf.angularYZLimitSpring = CopyLimitSpring(src.swingLimitSpring);
			conf.enableCollision = src.enableCollision;
			conf.projectionMode = (src.enableProjection ? JointProjectionMode.PositionAndRotation : JointProjectionMode.None);
			conf.projectionAngle = src.projectionAngle;
			conf.projectionDistance = src.projectionDistance;
			UnityEngine.Object.DestroyImmediate(src);
		}

		private static void ConvertJoint(ref ConfigurableJoint conf, Joint src)
		{
			conf.anchor = src.anchor;
			conf.autoConfigureConnectedAnchor = src.autoConfigureConnectedAnchor;
			conf.axis = src.axis;
			conf.breakForce = src.breakForce;
			conf.breakTorque = src.breakTorque;
			conf.connectedAnchor = src.connectedAnchor;
			conf.connectedBody = src.connectedBody;
			conf.enableCollision = src.enableCollision;
		}

		private static SoftJointLimit ConvertToHighSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			SoftJointLimit result = default(SoftJointLimit);
			result.limit = 0f - src.max;
			result.bounciness = src.bounciness;
			return result;
		}

		private static SoftJointLimit ConvertToLowSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			SoftJointLimit result = default(SoftJointLimit);
			result.limit = 0f - src.min;
			result.bounciness = src.bounciness;
			return result;
		}

		private static SoftJointLimitSpring ConvertToSoftJointLimitSpring(JointLimits src, JointSpring spring, bool useSpring)
		{
			SoftJointLimitSpring result = default(SoftJointLimitSpring);
			result.damper = (useSpring ? spring.damper : 0f);
			result.spring = (useSpring ? spring.spring : 0f);
			return result;
		}

		private static SoftJointLimit CopyLimit(SoftJointLimit src)
		{
			SoftJointLimit result = default(SoftJointLimit);
			result.limit = src.limit;
			result.bounciness = src.bounciness;
			return result;
		}

		private static SoftJointLimitSpring CopyLimitSpring(SoftJointLimitSpring src)
		{
			SoftJointLimitSpring result = default(SoftJointLimitSpring);
			result.damper = src.damper;
			result.spring = src.spring;
			return result;
		}
	}
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		public enum ColliderType
		{
			Box,
			Capsule
		}

		[Serializable]
		public enum JointType
		{
			Configurable,
			Character
		}

		[Serializable]
		public enum Direction
		{
			X,
			Y,
			Z
		}

		public struct CreateJointParams
		{
			public struct Limits
			{
				public float minSwing;

				public float maxSwing;

				public float swing2;

				public float twist;

				public Limits(float minSwing, float maxSwing, float swing2, float twist)
				{
					this.minSwing = minSwing;
					this.maxSwing = maxSwing;
					this.swing2 = swing2;
					this.twist = twist;
				}
			}

			public Rigidbody rigidbody;

			public Rigidbody connectedBody;

			public Transform child;

			public Vector3 worldSwingAxis;

			public Limits limits;

			public JointType type;

			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type)
			{
				this.rigidbody = rigidbody;
				this.connectedBody = connectedBody;
				this.child = child;
				this.worldSwingAxis = worldSwingAxis;
				this.limits = limits;
				this.type = type;
			}
		}

		public static void ClearAll(Transform root)
		{
			if (root == null)
			{
				return;
			}
			Transform transform = root;
			Animator componentInChildren = root.GetComponentInChildren<Animator>();
			if (componentInChildren != null && componentInChildren.isHuman)
			{
				Transform boneTransform = componentInChildren.GetBoneTransform(HumanBodyBones.Hips);
				if (boneTransform != null && boneTransform.GetComponentsInChildren<Transform>().Length > 2)
				{
					transform = boneTransform;
				}
			}
			Transform[] componentsInChildren = transform.GetComponentsInChildren<Transform>();
			if (componentsInChildren.Length >= 2)
			{
				for (int i = ((!(componentInChildren != null) || !componentInChildren.isHuman) ? 1 : 0); i < componentsInChildren.Length; i++)
				{
					ClearTransform(componentsInChildren[i]);
				}
			}
		}

		protected static void ClearTransform(Transform transform)
		{
			if (!(transform == null))
			{
				Collider component = transform.GetComponent<Collider>();
				if (component != null && !component.isTrigger)
				{
					UnityEngine.Object.DestroyImmediate(component);
				}
				Joint component2 = transform.GetComponent<Joint>();
				if (component2 != null)
				{
					UnityEngine.Object.DestroyImmediate(component2);
				}
				Rigidbody component3 = transform.GetComponent<Rigidbody>();
				if (component3 != null)
				{
					UnityEngine.Object.DestroyImmediate(component3);
				}
			}
		}

		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
			Vector3 direction = endPoint - startPoint;
			float num = direction.magnitude * (1f + lengthOverlap);
			Vector3 axisVectorToDirection = AxisTools.GetAxisVectorToDirection(t, direction);
			t.gameObject.AddComponent<Rigidbody>();
			float scaleF = GetScaleF(t);
			switch (colliderType)
			{
			case ColliderType.Capsule:
			{
				CapsuleCollider capsuleCollider = t.gameObject.AddComponent<CapsuleCollider>();
				capsuleCollider.height = Mathf.Abs(num / scaleF);
				capsuleCollider.radius = Mathf.Abs(width * 0.75f / scaleF);
				capsuleCollider.direction = DirectionVector3ToInt(axisVectorToDirection);
				capsuleCollider.center = t.InverseTransformPoint(Vector3.Lerp(startPoint, endPoint, 0.5f));
				break;
			}
			case ColliderType.Box:
			{
				Vector3 vector = Vector3.Scale(axisVectorToDirection, new Vector3(num, num, num));
				if (vector.x == 0f)
				{
					vector.x = width;
				}
				if (vector.y == 0f)
				{
					vector.y = width;
				}
				if (vector.z == 0f)
				{
					vector.z = width;
				}
				BoxCollider boxCollider = t.gameObject.AddComponent<BoxCollider>();
				boxCollider.size = vector / scaleF;
				boxCollider.size = new Vector3(Mathf.Abs(boxCollider.size.x), Mathf.Abs(boxCollider.size.y), Mathf.Abs(boxCollider.size.z));
				boxCollider.center = t.InverseTransformPoint(Vector3.Lerp(startPoint, endPoint, 0.5f));
				break;
			}
			}
		}

		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
			if (colliderType == ColliderType.Capsule)
			{
				CreateCollider(t, startPoint, endPoint, colliderType, lengthOverlap, width * proportionAspect);
				return;
			}
			Vector3 direction = endPoint - startPoint;
			float num = direction.magnitude * (1f + lengthOverlap);
			Vector3 axisVectorToDirection = AxisTools.GetAxisVectorToDirection(t, direction);
			Vector3 vector = AxisTools.GetAxisVectorToDirection(t, widthDirection);
			if (vector == axisVectorToDirection)
			{
				UnityEngine.Debug.LogWarning("Width axis = height axis on " + t.name, t);
				vector = new Vector3(axisVectorToDirection.y, axisVectorToDirection.z, axisVectorToDirection.x);
			}
			t.gameObject.AddComponent<Rigidbody>();
			Vector3 vector2 = Vector3.Scale(axisVectorToDirection, new Vector3(num, num, num));
			Vector3 vector3 = Vector3.Scale(vector, new Vector3(width, width, width));
			Vector3 vector4 = vector2 + vector3;
			if (vector4.x == 0f)
			{
				vector4.x = width * proportionAspect;
			}
			if (vector4.y == 0f)
			{
				vector4.y = width * proportionAspect;
			}
			if (vector4.z == 0f)
			{
				vector4.z = width * proportionAspect;
			}
			BoxCollider boxCollider = t.gameObject.AddComponent<BoxCollider>();
			boxCollider.size = vector4 / GetScaleF(t);
			boxCollider.center = t.InverseTransformPoint(Vector3.Lerp(startPoint, endPoint, 0.5f));
		}

		protected static float GetScaleF(Transform t)
		{
			Vector3 lossyScale = t.lossyScale;
			return (lossyScale.x + lossyScale.y + lossyScale.z) / 3f;
		}

		protected static Vector3 Abs(Vector3 v)
		{
			Vector3Abs(ref v);
			return v;
		}

		protected static void Vector3Abs(ref Vector3 v)
		{
			v.x = Mathf.Abs(v.x);
			v.y = Mathf.Abs(v.y);
			v.z = Mathf.Abs(v.z);
		}

		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return dir switch
			{
				0 => Vector3.right, 
				1 => Vector3.up, 
				_ => Vector3.forward, 
			};
		}

		protected static Vector3 DirectionToVector3(Direction dir)
		{
			return dir switch
			{
				Direction.X => Vector3.right, 
				Direction.Y => Vector3.up, 
				_ => Vector3.forward, 
			};
		}

		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			float f = Vector3.Dot(dir, Vector3.right);
			float f2 = Vector3.Dot(dir, Vector3.up);
			float f3 = Vector3.Dot(dir, Vector3.forward);
			float num = Mathf.Abs(f);
			float num2 = Mathf.Abs(f2);
			float num3 = Mathf.Abs(f3);
			int result = 0;
			if (num2 > num && num2 > num3)
			{
				result = 1;
			}
			if (num3 > num && num3 > num2)
			{
				result = 2;
			}
			return result;
		}

		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			worldDir = worldDir.normalized;
			float f = Vector3.Dot(worldDir, transform.right);
			float f2 = Vector3.Dot(worldDir, transform.up);
			float f3 = Vector3.Dot(worldDir, transform.forward);
			float num = Mathf.Abs(f);
			float num2 = Mathf.Abs(f2);
			float num3 = Mathf.Abs(f3);
			Vector3 vector = Vector3.right;
			if (num2 > num && num2 > num3)
			{
				vector = Vector3.up;
			}
			if (num3 > num && num3 > num2)
			{
				vector = Vector3.forward;
			}
			if (Vector3.Dot(worldDir, transform.rotation * vector) < 0f)
			{
				vector = -vector;
			}
			return vector;
		}

		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			if (bone.parent == null)
			{
				return null;
			}
			Transform[] array = bones;
			foreach (Transform transform in array)
			{
				if (bone.parent == transform && transform.GetComponent<Rigidbody>() != null)
				{
					return transform.GetComponent<Rigidbody>();
				}
			}
			return GetConnectedBody(bone.parent, ref bones);
		}

		protected static void CreateJoint(CreateJointParams p)
		{
			Vector3 localOrthoDirection = GetLocalOrthoDirection(p.rigidbody.transform, p.worldSwingAxis);
			Vector3 rhs = Vector3.forward;
			if (p.child != null)
			{
				rhs = GetLocalOrthoDirection(p.rigidbody.transform, p.child.position - p.rigidbody.transform.position);
			}
			else if (p.connectedBody != null)
			{
				rhs = GetLocalOrthoDirection(p.rigidbody.transform, p.rigidbody.transform.position - p.connectedBody.transform.position);
			}
			Vector3 vector = Vector3.Cross(localOrthoDirection, rhs);
			if (p.type == JointType.Configurable)
			{
				ConfigurableJoint configurableJoint = p.rigidbody.gameObject.AddComponent<ConfigurableJoint>();
				configurableJoint.connectedBody = p.connectedBody;
				ConfigurableJointMotion configurableJointMotion = ((!(p.connectedBody != null)) ? ConfigurableJointMotion.Free : ConfigurableJointMotion.Locked);
				ConfigurableJointMotion configurableJointMotion2 = ((p.connectedBody != null) ? ConfigurableJointMotion.Limited : ConfigurableJointMotion.Free);
				configurableJoint.xMotion = configurableJointMotion;
				configurableJoint.yMotion = configurableJointMotion;
				configurableJoint.zMotion = configurableJointMotion;
				configurableJoint.angularXMotion = configurableJointMotion2;
				configurableJoint.angularYMotion = configurableJointMotion2;
				configurableJoint.angularZMotion = configurableJointMotion2;
				if (p.connectedBody != null)
				{
					configurableJoint.axis = localOrthoDirection;
					configurableJoint.secondaryAxis = vector;
					configurableJoint.lowAngularXLimit = ToSoftJointLimit(p.limits.minSwing);
					configurableJoint.highAngularXLimit = ToSoftJointLimit(p.limits.maxSwing);
					configurableJoint.angularYLimit = ToSoftJointLimit(p.limits.swing2);
					configurableJoint.angularZLimit = ToSoftJointLimit(p.limits.twist);
				}
				configurableJoint.anchor = Vector3.zero;
			}
			else if (!(p.connectedBody == null))
			{
				CharacterJoint characterJoint = p.rigidbody.gameObject.AddComponent<CharacterJoint>();
				characterJoint.connectedBody = p.connectedBody;
				characterJoint.axis = localOrthoDirection;
				characterJoint.swingAxis = vector;
				characterJoint.lowTwistLimit = ToSoftJointLimit(p.limits.minSwing);
				characterJoint.highTwistLimit = ToSoftJointLimit(p.limits.maxSwing);
				characterJoint.swing1Limit = ToSoftJointLimit(p.limits.swing2);
				characterJoint.swing2Limit = ToSoftJointLimit(p.limits.twist);
				characterJoint.anchor = Vector3.zero;
			}
		}

		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			SoftJointLimit result = default(SoftJointLimit);
			result.limit = limit;
			return result;
		}
	}
	[HelpURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/Ragdoll Manager/Ragdoll Editor")]
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		public enum Mode
		{
			Colliders,
			Joints
		}

		[HideInInspector]
		public Rigidbody selectedRigidbody;

		[HideInInspector]
		public Collider selectedCollider;

		[HideInInspector]
		public bool symmetry = true;

		[HideInInspector]
		public Mode mode;

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://root-motion.com/puppetmasterdox/html/page2.html");
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://root-motion.com/puppetmasterdox/html/class_root_motion_1_1_dynamics_1_1_ragdoll_editor.html");
		}

		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL");
		}
	}
}
namespace UnityEngine.AI
{
	[ExecuteInEditMode]
	[DefaultExecutionOrder(-101)]
	[AddComponentMenu("Navigation/NavMeshLink", 33)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshLink : MonoBehaviour
	{
		[SerializeField]
		private int m_AgentTypeID;

		[SerializeField]
		private Vector3 m_StartPoint = new Vector3(0f, 0f, -2.5f);

		[SerializeField]
		private Vector3 m_EndPoint = new Vector3(0f, 0f, 2.5f);

		[SerializeField]
		private float m_Width;

		[SerializeField]
		private bool m_Bidirectional = true;

		[SerializeField]
		private bool m_AutoUpdatePosition;

		[SerializeField]
		private int m_Area;

		private NavMeshLinkInstance m_LinkInstance;

		private Vector3 m_LastPosition = Vector3.zero;

		private Quaternion m_LastRotation = Quaternion.identity;

		private static readonly List<NavMeshLink> s_Tracked = new List<NavMeshLink>();

		public int agentTypeID
		{
			get
			{
				return m_AgentTypeID;
			}
			set
			{
				m_AgentTypeID = value;
				UpdateLink();
			}
		}

		public Vector3 startPoint
		{
			get
			{
				return m_StartPoint;
			}
			set
			{
				m_StartPoint = value;
				UpdateLink();
			}
		}

		public Vector3 endPoint
		{
			get
			{
				return m_EndPoint;
			}
			set
			{
				m_EndPoint = value;
				UpdateLink();
			}
		}

		public float width
		{
			get
			{
				return m_Width;
			}
			set
			{
				m_Width = value;
				UpdateLink();
			}
		}

		public bool bidirectional
		{
			get
			{
				return m_Bidirectional;
			}
			set
			{
				m_Bidirectional = value;
				UpdateLink();
			}
		}

		public bool autoUpdate
		{
			get
			{
				return m_AutoUpdatePosition;
			}
			set
			{
				SetAutoUpdate(value);
			}
		}

		public int area
		{
			get
			{
				return m_Area;
			}
			set
			{
				m_Area = value;
				UpdateLink();
			}
		}

		private void OnEnable()
		{
			AddLink();
			if (m_AutoUpdatePosition && m_LinkInstance.valid)
			{
				AddTracking(this);
			}
		}

		private void OnDisable()
		{
			RemoveTracking(this);
			m_LinkInstance.Remove();
		}

		public void UpdateLink()
		{
			m_LinkInstance.Remove();
			AddLink();
		}

		private static void AddTracking(NavMeshLink link)
		{
			if (s_Tracked.Count == 0)
			{
				NavMesh.onPreUpdate = (NavMesh.OnNavMeshPreUpdate)Delegate.Combine(NavMesh.onPreUpdate, new NavMesh.OnNavMeshPreUpdate(UpdateTrackedInstances));
			}
			s_Tracked.Add(link);
		}

		private static void RemoveTracking(NavMeshLink link)
		{
			s_Tracked.Remove(link);
			if (s_Tracked.Count == 0)
			{
				NavMesh.onPreUpdate = (NavMesh.OnNavMeshPreUpdate)Delegate.Remove(NavMesh.onPreUpdate, new NavMesh.OnNavMeshPreUpdate(UpdateTrackedInstances));
			}
		}

		private void SetAutoUpdate(bool value)
		{
			if (m_AutoUpdatePosition != value)
			{
				m_AutoUpdatePosition = value;
				if (value)
				{
					AddTracking(this);
				}
				else
				{
					RemoveTracking(this);
				}
			}
		}

		private void AddLink()
		{
			NavMeshLinkData link = default(NavMeshLinkData);
			link.startPosition = m_StartPoint;
			link.endPosition = m_EndPoint;
			link.width = m_Width;
			link.costModifier = -1f;
			link.bidirectional = m_Bidirectional;
			link.area = m_Area;
			link.agentTypeID = m_AgentTypeID;
			m_LinkInstance = NavMesh.AddLink(link, base.transform.position, base.transform.rotation);
			if (m_LinkInstance.valid)
			{
				m_LinkInstance.owner = this;
			}
			m_LastPosition = base.transform.position;
			m_LastRotation = base.transform.rotation;
		}

		private bool HasTransformChanged()
		{
			if (m_LastPosition != base.transform.position)
			{
				return true;
			}
			if (m_LastRotation != base.transform.rotation)
			{
				return true;
			}
			return false;
		}

		private void OnDidApplyAnimationProperties()
		{
			UpdateLink();
		}

		private static void UpdateTrackedInstances()
		{
			foreach (NavMeshLink item in s_Tracked)
			{
				if (item.HasTransformChanged())
				{
					item.UpdateLink();
				}
			}
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Navigation/NavMeshModifier", 32)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshModifier : MonoBehaviour
	{
		[SerializeField]
		private bool m_OverrideArea;

		[SerializeField]
		private int m_Area;

		[SerializeField]
		private bool m_IgnoreFromBuild;

		[SerializeField]
		private List<int> m_AffectedAgents = new List<int>(new int[1] { -1 });

		private static readonly List<NavMeshModifier> s_NavMeshModifiers = new List<NavMeshModifier>();

		public bool overrideArea
		{
			get
			{
				return m_OverrideArea;
			}
			set
			{
				m_OverrideArea = value;
			}
		}

		public int area
		{
			get
			{
				return m_Area;
			}
			set
			{
				m_Area = value;
			}
		}

		public bool ignoreFromBuild
		{
			get
			{
				return m_IgnoreFromBuild;
			}
			set
			{
				m_IgnoreFromBuild = value;
			}
		}

		public static List<NavMeshModifier> activeModifiers => s_NavMeshModifiers;

		private void OnEnable()
		{
			if (!s_NavMeshModifiers.Contains(this))
			{
				s_NavMeshModifiers.Add(this);
			}
		}

		private void OnDisable()
		{
			s_NavMeshModifiers.Remove(this);
		}

		public bool AffectsAgentType(int agentTypeID)
		{
			if (m_AffectedAgents.Count == 0)
			{
				return false;
			}
			if (m_AffectedAgents[0] == -1)
			{
				return true;
			}
			return m_AffectedAgents.IndexOf(agentTypeID) != -1;
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Navigation/NavMeshModifierVolume", 31)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshModifierVolume : MonoBehaviour
	{
		[SerializeField]
		private Vector3 m_Size = new Vector3(4f, 3f, 4f);

		[SerializeField]
		private Vector3 m_Center = new Vector3(0f, 1f, 0f);

		[SerializeField]
		private int m_Area;

		[SerializeField]
		private List<int> m_AffectedAgents = new List<int>(new int[1] { -1 });

		private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers = new List<NavMeshModifierVolume>();

		public Vector3 size
		{
			get
			{
				return m_Size;
			}
			set
			{
				m_Size = value;
			}
		}

		public Vector3 center
		{
			get
			{
				return m_Center;
			}
			set
			{
				m_Center = value;
			}
		}

		public int area
		{
			get
			{
				return m_Area;
			}
			set
			{
				m_Area = value;
			}
		}

		public static List<NavMeshModifierVolume> activeModifiers => s_NavMeshModifiers;

		private void OnEnable()
		{
			if (!s_NavMeshModifiers.Contains(this))
			{
				s_NavMeshModifiers.Add(this);
			}
		}

		private void OnDisable()
		{
			s_NavMeshModifiers.Remove(this);
		}

		public bool AffectsAgentType(int agentTypeID)
		{
			if (m_AffectedAgents.Count == 0)
			{
				return false;
			}
			if (m_AffectedAgents[0] == -1)
			{
				return true;
			}
			return m_AffectedAgents.IndexOf(agentTypeID) != -1;
		}
	}
	public enum CollectObjects
	{
		All,
		Volume,
		Children
	}
	[ExecuteInEditMode]
	[DefaultExecutionOrder(-102)]
	[AddComponentMenu("Navigation/NavMeshSurface", 30)]
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	public class NavMeshSurface : MonoBehaviour
	{
		[SerializeField]
		private int m_AgentTypeID;

		[SerializeField]
		private CollectObjects m_CollectObjects;

		[SerializeField]
		private Vector3 m_Size = new Vector3(10f, 10f, 10f);

		[SerializeField]
		private Vector3 m_Center = new Vector3(0f, 2f, 0f);

		[SerializeField]
		private LayerMask m_LayerMask = -1;

		[SerializeField]
		private NavMeshCollectGeometry m_UseGeometry;

		[SerializeField]
		private int m_DefaultArea;

		[SerializeField]
		private bool m_IgnoreNavMeshAgent = true;

		[SerializeField]
		private bool m_IgnoreNavMeshObstacle = true;

		[SerializeField]
		private bool m_OverrideTileSize;

		[SerializeField]
		private int m_TileSize = 256;

		[SerializeField]
		private bool m_OverrideVoxelSize;

		[SerializeField]
		private float m_VoxelSize;

		[SerializeField]
		private bool m_BuildHeightMesh;

		[SerializeField]
		private NavMeshData m_BakedNavMeshData;

		private NavMeshDataInstance m_NavMeshDataInstance;

		private Vector3 m_LastPosition = Vector3.zero;

		private Quaternion m_LastRotation = Quaternion.identity;

		private static readonly List<NavMeshSurface> s_NavMeshSurfaces = new List<NavMeshSurface>();

		public int agentTypeID
		{
			get
			{
				return m_AgentTypeID;
			}
			set
			{
				m_AgentTypeID = value;
			}
		}

		public CollectObjects collectObjects
		{
			get
			{
				return m_CollectObjects;
			}
			set
			{
				m_CollectObjects = value;
			}
		}

		public Vector3 size
		{
			get
			{
				return m_Size;
			}
			set
			{
				m_Size = value;
			}
		}

		public Vector3 center
		{
			get
			{
				return m_Center;
			}
			set
			{
				m_Center = value;
			}
		}

		public LayerMask layerMask
		{
			get
			{
				return m_LayerMask;
			}
			set
			{
				m_LayerMask = value;
			}
		}

		public NavMeshCollectGeometry useGeometry
		{
			get
			{
				return m_UseGeometry;
			}
			set
			{
				m_UseGeometry = value;
			}
		}

		public int defaultArea
		{
			get
			{
				return m_DefaultArea;
			}
			set
			{
				m_DefaultArea = value;
			}
		}

		public bool ignoreNavMeshAgent
		{
			get
			{
				return m_IgnoreNavMeshAgent;
			}
			set
			{
				m_IgnoreNavMeshAgent = value;
			}
		}

		public bool ignoreNavMeshObstacle
		{
			get
			{
				return m_IgnoreNavMeshObstacle;
			}
			set
			{
				m_IgnoreNavMeshObstacle = value;
			}
		}

		public bool overrideTileSize
		{
			get
			{
				return m_OverrideTileSize;
			}
			set
			{
				m_OverrideTileSize = value;
			}
		}

		public int tileSize
		{
			get
			{
				return m_TileSize;
			}
			set
			{
				m_TileSize = value;
			}
		}

		public bool overrideVoxelSize
		{
			get
			{
				return m_OverrideVoxelSize;
			}
			set
			{
				m_OverrideVoxelSize = value;
			}
		}

		public float voxelSize
		{
			get
			{
				return m_VoxelSize;
			}
			set
			{
				m_VoxelSize = value;
			}
		}

		public bool buildHeightMesh
		{
			get
			{
				return m_BuildHeightMesh;
			}
			set
			{
				m_OverrideTileSize = value;
			}
		}

		public NavMeshData bakedNavMeshData
		{
			get
			{
				return m_BakedNavMeshData;
			}
			set
			{
				m_BakedNavMeshData = value;
			}
		}

		public static List<NavMeshSurface> activeSurfaces => s_NavMeshSurfaces;

		private void OnEnable()
		{
			Register(this);
			AddData();
		}

		private void OnDisable()
		{
			RemoveData();
			Unregister(this);
		}

		public void AddData()
		{
			if (!m_NavMeshDataInstance.valid)
			{
				if (m_BakedNavMeshData != null)
				{
					m_NavMeshDataInstance = NavMesh.AddNavMeshData(m_BakedNavMeshData, base.transform.position, base.transform.rotation);
					m_NavMeshDataInstance.owner = this;
				}
				m_LastPosition = base.transform.position;
				m_LastRotation = base.transform.rotation;
			}
		}

		public void RemoveData()
		{
			m_NavMeshDataInstance.Remove();
			m_NavMeshDataInstance = default(NavMeshDataInstance);
		}

		public NavMeshBuildSettings GetBuildSettings()
		{
			NavMeshBuildSettings settingsByID = NavMesh.GetSettingsByID(m_AgentTypeID);
			if (overrideTileSize)
			{
				settingsByID.overrideTileSize = true;
				settingsByID.tileSize = tileSize;
			}
			if (overrideVoxelSize)
			{
				settingsByID.overrideVoxelSize = true;
				settingsByID.voxelSize = voxelSize;
			}
			return settingsByID;
		}

		public void Bake()
		{
			List<NavMeshBuildSource> sources = CollectSources();
			Bounds localBounds = new Bounds(m_Center, Abs(m_Size));
			if (m_CollectObjects == CollectObjects.All || m_CollectObjects == CollectObjects.Children)
			{
				localBounds = CalculateWorldBounds(sources);
			}
			NavMeshData navMeshData = NavMeshBuilder.BuildNavMeshData(GetBuildSettings(), sources, localBounds, base.transform.position, base.transform.rotation);
			if (navMeshData != null)
			{
				navMeshData.name = base.gameObject.name;
				RemoveData();
				m_BakedNavMeshData = navMeshData;
				if (base.isActiveAndEnabled)
				{
					AddData();
				}
			}
		}

		private static void Register(NavMeshSurface surface)
		{
			if (s_NavMeshSurfaces.Count == 0)
			{
				NavMesh.onPreUpdate = (NavMesh.OnNavMeshPreUpdate)Delegate.Combine(NavMesh.onPreUpdate, new NavMesh.OnNavMeshPreUpdate(UpdateActive));
			}
			if (!s_NavMeshSurfaces.Contains(surface))
			{
				s_NavMeshSurfaces.Add(surface);
			}
		}

		private static void Unregister(NavMeshSurface surface)
		{
			s_NavMeshSurfaces.Remove(surface);
			if (s_NavMeshSurfaces.Count == 0)
			{
				NavMesh.onPreUpdate = (NavMesh.OnNavMeshPreUpdate)Delegate.Remove(NavMesh.onPreUpdate, new NavMesh.OnNavMeshPreUpdate(UpdateActive));
			}
		}

		private static void UpdateActive()
		{
			for (int i = 0; i < s_NavMeshSurfaces.Count; i++)
			{
				s_NavMeshSurfaces[i].UpdateDataIfTransformChanged();
			}
		}

		private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources)
		{
			List<NavMeshModifierVolume> list;
			if (m_CollectObjects == CollectObjects.Children)
			{
				list = new List<NavMeshModifierVolume>(GetComponentsInChildren<NavMeshModifierVolume>());
				list.RemoveAll((NavMeshModifierVolume x) => !x.isActiveAndEnabled);
			}
			else
			{
				list = NavMeshModifierVolume.activeModifiers;
			}
			foreach (NavMeshModifierVolume item2 in list)
			{
				if (((int)m_LayerMask & (1 << item2.gameObject.layer)) != 0 && item2.AffectsAgentType(m_AgentTypeID))
				{
					Vector3 pos = item2.transform.TransformPoint(item2.center);
					Vector3 lossyScale = item2.transform.lossyScale;
					Vector3 vector = new Vector3(item2.size.x * Mathf.Abs(lossyScale.x), item2.size.y * Mathf.Abs(lossyScale.y), item2.size.z * Mathf.Abs(lossyScale.z));
					NavMeshBuildSource item = default(NavMeshBuildSource);
					item.shape = NavMeshBuildSourceShape.ModifierBox;
					item.transform = Matrix4x4.TRS(pos, item2.transform.rotation, Vector3.one);
					item.size = vector;
					item.area = item2.area;
					sources.Add(item);
				}
			}
		}

		private List<NavMeshBuildSource> CollectSources()
		{
			List<NavMeshBuildSource> sources = new List<NavMeshBuildSource>();
			List<NavMeshBuildMarkup> list = new List<NavMeshBuildMarkup>();
			List<NavMeshModifier> list2;
			if (m_CollectObjects == CollectObjects.Children)
			{
				list2 = new List<NavMeshModifier>(GetComponentsInChildren<NavMeshModifier>());
				list2.RemoveAll((NavMeshModifier x) => !x.isActiveAndEnabled);
			}
			else
			{
				list2 = NavMeshModifier.activeModifiers;
			}
			foreach (NavMeshModifier item2 in list2)
			{
				if (((int)m_LayerMask & (1 << item2.gameObject.layer)) != 0 && item2.AffectsAgentType(m_AgentTypeID))
				{
					NavMeshBuildMarkup item = default(NavMeshBuildMarkup);
					item.root = item2.transform;
					item.overrideArea = item2.overrideArea;
					item.area = item2.area;
					item.ignoreFromBuild = item2.ignoreFromBuild;
					list.Add(item);
				}
			}
			if (m_CollectObjects == CollectObjects.All)
			{
				NavMeshBuilder.CollectSources(null, m_LayerMask, m_UseGeometry, m_DefaultArea, list, sources);
			}
			else if (m_CollectObjects == CollectObjects.Children)
			{
				NavMeshBuilder.CollectSources(base.transform, m_LayerMask, m_UseGeometry, m_DefaultArea, list, sources);
			}
			else if (m_CollectObjects == CollectObjects.Volume)
			{
				NavMeshBuilder.CollectSources(GetWorldBounds(Matrix4x4.TRS(base.transform.position, base.transform.rotation, Vector3.one), new Bounds(m_Center, m_Size)), m_LayerMask, m_UseGeometry, m_DefaultArea, list, sources);
			}
			if (m_IgnoreNavMeshAgent)
			{
				sources.RemoveAll((NavMeshBuildSource x) => x.component != null && x.component.gameObject.GetComponent<NavMeshAgent>() != null);
			}
			if (m_IgnoreNavMeshObstacle)
			{
				sources.RemoveAll((NavMeshBuildSource x) => x.component != null && x.component.gameObject.GetComponent<NavMeshObstacle>() != null);
			}
			AppendModifierVolumes(ref sources);
			return sources;
		}

		private static Vector3 Abs(Vector3 v)
		{
			return new Vector3(Mathf.Abs(v.x), Mathf.Abs(v.y), Mathf.Abs(v.z));
		}

		private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds)
		{
			Vector3 vector = Abs(mat.MultiplyVector(Vector3.right));
			Vector3 vector2 = Abs(mat.MultiplyVector(Vector3.up));
			Vector3 vector3 = Abs(mat.MultiplyVector(Vector3.forward));
			Vector3 vector4 = mat.MultiplyPoint(bounds.center);
			Vector3 vector5 = vector * bounds.size.x + vector2 * bounds.size.y + vector3 * bounds.size.z;
			return new Bounds(vector4, vector5);
		}

		private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources)
		{
			Matrix4x4 inverse = Matrix4x4.TRS(base.transform.position, base.transform.rotation, Vector3.one).inverse;
			Bounds result = default(Bounds);
			foreach (NavMeshBuildSource source in sources)
			{
				switch (source.shape)
				{
				case NavMeshBuildSourceShape.Mesh:
				{
					Mesh mesh = source.sourceObject as Mesh;
					result.Encapsulate(GetWorldBounds(inverse * source.transform, mesh.bounds));
					break;
				}
				case NavMeshBuildSourceShape.Terrain:
				{
					TerrainData terrainData = source.sourceObject as TerrainData;
					result.Encapsulate(GetWorldBounds(inverse * source.transform, new Bounds(0.5f * terrainData.size, terrainData.size)));
					break;
				}
				case NavMeshBuildSourceShape.Box:
				case NavMeshBuildSourceShape.Sphere:
				case NavMeshBuildSourceShape.Capsule:
				case NavMeshBuildSourceShape.ModifierBox:
					result.Encapsulate(GetWorldBounds(inverse * source.transform, new Bounds(Vector3.zero, source.size)));
					break;
				}
			}
			result.Expand(0.1f);
			return result;
		}

		private bool HasTransformChanged()
		{
			if (m_LastPosition != base.transform.position)
			{
				return true;
			}
			if (m_LastRotation != base.transform.rotation)
			{
				return true;
			}
			return false;
		}

		private void UpdateDataIfTransformChanged()
		{
			if (HasTransformChanged())
			{
				RemoveData();
				AddData();
			}
		}
	}
}
namespace MeshPainter
{
	[RequireComponent(typeof(MeshRenderer))]
	public class MeshPaint : MonoBehaviour
	{
		[Serializable]
		public class Detail
		{
			[SerializeField]
			private Texture2D _texture;

			public Texture2D Texture
			{
				get
				{
					return _texture;
				}
				set
				{
					_texture = value;
				}
			}
		}
	}
	[Serializable]
	public class UndoManager : ISerializationCallbackReceiver
	{
		private class State
		{
			private List<KeyValuePair<Texture2D, Color[]>> _state;

			public State(List<Texture2D> textures)
			{
				_state = new List<KeyValuePair<Texture2D, Color[]>>();
				Store(textures);
			}

			public State(Texture2D texture)
			{
				_state = new List<KeyValuePair<Texture2D, Color[]>>();
				Store(new List<Texture2D> { texture });
			}

			public void Store(List<Texture2D> textures)
			{
				foreach (Texture2D texture in textures)
				{
					_state.Add(new KeyValuePair<Texture2D, Color[]>(texture, texture.GetPixels(0)));
				}
			}

			public void Restore()
			{
				foreach (KeyValuePair<Texture2D, Color[]> item in _state)
				{
					item.Key.SetPixels(item.Value);
					item.Key.Apply();
				}
			}
		}

		private const int MaxUndo = 20;

		[SerializeField]
		private int _step = -1;

		private List<State> _undoState;

		public int Step
		{
			get
			{
				return _step;
			}
			set
			{
				_step = value;
			}
		}

		public bool Initialized { get; set; }

		public bool HasUndoRedoPerformed { get; set; }

		public UndoManager()
		{
			if (_undoState == null)
			{
				_undoState = new List<State>(20);
			}
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
			if (!Initialized)
			{
				Step = -1;
				Initialized = true;
			}
		}

		public void UndoRedoPerformed()
		{
			HasUndoRedoPerformed = true;
			RestoreTexture(Step);
		}

		private void RestoreTexture(int index)
		{
			if (index > -1 && index < _undoState.Count)
			{
				_undoState[index].Restore();
			}
		}

		public void Record(Texture2D texture)
		{
			State state = new State(texture);
			if (_undoState.Count == 0 || Step > _undoState.Count)
			{
				Step = -1;
			}
			if (++Step == 20)
			{
				Step = 0;
			}
			if (_undoState.Count < 20)
			{
				_undoState.Insert(Step, state);
			}
			else
			{
				_undoState[Step] = state;
			}
		}

		public void Record(List<Texture2D> textures)
		{
			State state = new State(textures);
			if (_undoState.Count == 0 || Step > _undoState.Count)
			{
				Step = -1;
			}
			if (++Step == 20)
			{
				Step = 0;
			}
			if (_undoState.Count < 20)
			{
				_undoState.Insert(Step, state);
			}
			else
			{
				_undoState[Step] = state;
			}
		}
	}
}
namespace Google2u
{
	public interface IGoogle2uRow
	{
		string GetStringData(string in_colID);
	}
	public interface IGoogle2uDB
	{
		IGoogle2uRow GetGenRow(string in_rowString);
	}
	public class Google2uComponentBase : MonoBehaviour
	{
		public virtual void AddRowGeneric(List<string> input)
		{
		}

		public virtual void Clear()
		{
		}
	}
}
namespace SimpleJson2
{
	[GeneratedCode("simple-json", "1.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class JsonArray : List<object>
	{
		public JsonArray()
		{
		}

		public JsonArray(int capacity)
			: base(capacity)
		{
		}

		public override string ToString()
		{
			return SimpleJson2.SerializeObject(this) ?? string.Empty;
		}
	}
	[GeneratedCode("simple-json", "1.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class JsonObject : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		private readonly Dictionary<string, object> _members;

		public object this[int index] => GetAtIndex(_members, index);

		public ICollection<string> Keys => _members.Keys;

		public ICollection<object> Values => _members.Values;

		public object this[string key]
		{
			get
			{
				return _members[key];
			}
			set
			{
				_members[key] = value;
			}
		}

		public int Count => _members.Count;

		public bool IsReadOnly => false;

		public JsonObject()
		{
			_members = new Dictionary<string, object>();
		}

		public JsonObject(IEqualityComparer<string> comparer)
		{
			_members = new Dictionary<string, object>(comparer);
		}

		internal static object GetAtIndex(IDictionary<string, object> obj, int index)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (index >= obj.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int num = 0;
			foreach (KeyValuePair<string, object> item in obj)
			{
				if (num++ == index)
				{
					return item.Value;
				}
			}
			return null;
		}

		public void Add(string key, object value)
		{
			_members.Add(key, value);
		}

		public bool ContainsKey(string key)
		{
			return _members.ContainsKey(key);
		}

		public bool Remove(string key)
		{
			return _members.Remove(key);
		}

		public bool TryGetValue(string key, out object value)
		{
			return _members.TryGetValue(key, out value);
		}

		public void Add(KeyValuePair<string, object> item)
		{
			_members.Add(item.Key, item.Value);
		}

		public void Clear()
		{
			_members.Clear();
		}

		public bool Contains(KeyValuePair<string, object> item)
		{
			if (_members.ContainsKey(item.Key))
			{
				return _members[item.Key] == item.Value;
			}
			return false;
		}

		public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			int num = Count;
			using IEnumerator<KeyValuePair<string, object>> enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, object> current = enumerator.Current;
				array[arrayIndex++] = current;
				if (--num <= 0)
				{
					break;
				}
			}
		}

		public bool Remove(KeyValuePair<string, object> item)
		{
			return _members.Remove(item.Key);
		}

		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return _members.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _members.GetEnumerator();
		}

		public override string ToString()
		{
			return SimpleJson2.SerializeObject(this);
		}
	}
	[GeneratedCode("simple-json", "1.0.0")]
	public static class SimpleJson2
	{
		private const int TOKEN_NONE = 0;

		private const int TOKEN_CURLY_OPEN = 1;

		private const int TOKEN_CURLY_CLOSE = 2;

		private const int TOKEN_SQUARED_OPEN = 3;

		private const int TOKEN_SQUARED_CLOSE = 4;

		private const int TOKEN_COLON = 5;

		private const int TOKEN_COMMA = 6;

		private const int TOKEN_STRING = 7;

		private const int TOKEN_NUMBER = 8;

		private const int TOKEN_TRUE = 9;

		private const int TOKEN_FALSE = 10;

		private const int TOKEN_NULL = 11;

		private const int BUILDER_CAPACITY = 2000;

		private static readonly char[] EscapeTable;

		private static readonly char[] EscapeCharacters;

		private static IJsonSerializerStrategy _currentJsonSerializerStrategy;

		private static PocoJsonSerializerStrategy _pocoJsonSerializerStrategy;

		public static IJsonSerializerStrategy CurrentJsonSerializerStrategy
		{
			get
			{
				return _currentJsonSerializerStrategy ?? (_currentJsonSerializerStrategy = PocoJsonSerializerStrategy);
			}
			set
			{
				_currentJsonSerializerStrategy = value;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static PocoJsonSerializerStrategy PocoJsonSerializerStrategy => _pocoJsonSerializerStrategy ?? (_pocoJsonSerializerStrategy = new PocoJsonSerializerStrategy());

		static SimpleJson2()
		{
			EscapeCharacters = new char[7] { '"', '\\', '\b', '\f', '\n', '\r', '\t' };
			EscapeTable = new char[93];
			EscapeTable[34] = '"';
			EscapeTable[92] = '\\';
			EscapeTable[8] = 'b';
			EscapeTable[12] = 'f';
			EscapeTable[10] = 'n';
			EscapeTable[13] = 'r';
			EscapeTable[9] = 't';
		}

		public static object DeserializeObject(string json)
		{
			if (TryDeserializeObject(json, out var obj))
			{
				return obj;
			}
			throw new SerializationException("Invalid JSON string");
		}

		public static bool TryDeserializeObject(string json, out object obj)
		{
			bool success = true;
			if (json != null)
			{
				char[] json2 = json.ToCharArray();
				int index = 0;
				obj = ParseValue(json2, ref index, ref success);
			}
			else
			{
				obj = null;
			}
			return success;
		}

		public static object DeserializeObject(string json, Type type, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			object obj = DeserializeObject(json);
			if (!(type == null) && (obj == null || !ReflectionUtils.IsAssignableFrom(obj.GetType(), type)))
			{
				return (jsonSerializerStrategy ?? CurrentJsonSerializerStrategy).DeserializeObject(obj, type);
			}
			return obj;
		}

		public static object DeserializeObject(string json, Type type)
		{
			return DeserializeObject(json, type, null);
		}

		public static T DeserializeObject<T>(string json, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			return (T)DeserializeObject(json, typeof(T), jsonSerializerStrategy);
		}

		public static T DeserializeObject<T>(string json)
		{
			return (T)DeserializeObject(json, typeof(T), null);
		}

		public static string SerializeObject(object json, IJsonSerializerStrategy jsonSerializerStrategy)
		{
			StringBuilder stringBuilder = new StringBuilder(2000);
			if (!SerializeValue(jsonSerializerStrategy, json, stringBuilder))
			{
				return null;
			}
			return stringBuilder.ToString();
		}

		public static string SerializeObject(object json)
		{
			return SerializeObject(json, CurrentJsonSerializerStrategy);
		}

		public static string EscapeToJavascriptString(string jsonString)
		{
			if (string.IsNullOrEmpty(jsonString))
			{
				return jsonString;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			while (num < jsonString.Length)
			{
				char c = jsonString[num++];
				if (c == '\\')
				{
					if (jsonString.Length - num >= 2)
					{
						switch (jsonString[num])
						{
						case '\\':
							stringBuilder.Append('\\');
							num++;
							break;
						case '"':
							stringBuilder.Append("\"");
							num++;
							break;
						case 't':
							stringBuilder.Append('\t');
							num++;
							break;
						case 'b':
							stringBuilder.Append('\b');
							num++;
							break;
						case 'n':
							stringBuilder.Append('\n');
							num++;
							break;
						case 'r':
							stringBuilder.Append('\r');
							num++;
							break;
						}
					}
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}

		private static IDictionary<string, object> ParseObject(char[] json, ref int index, ref bool success)
		{
			IDictionary<string, object> dictionary = new JsonObject();
			NextToken(json, ref index);
			bool flag = false;
			while (!flag)
			{
				switch (LookAhead(json, index))
				{
				case 0:
					success = false;
					return null;
				case 6:
					NextToken(json, ref index);
					continue;
				case 2:
					NextToken(json, ref index);
					return dictionary;
				}
				string key = ParseString(json, ref index, ref success);
				if (!success)
				{
					success = false;
					return null;
				}
				int num = NextToken(json, ref index);
				if (num != 5)
				{
					success = false;
					return null;
				}
				object value = ParseValue(json, ref index, ref success);
				if (!success)
				{
					success = false;
					return null;
				}
				dictionary[key] = value;
			}
			return dictionary;
		}

		private static JsonArray ParseArray(char[] json, ref int index, ref bool success)
		{
			JsonArray jsonArray = new JsonArray();
			NextToken(json, ref index);
			bool flag = false;
			while (!flag)
			{
				switch (LookAhead(json, index))
				{
				case 0:
					success = false;
					return null;
				case 6:
					NextToken(json, ref index);
					continue;
				case 4:
					break;
				default:
				{
					object item = ParseValue(json, ref index, ref success);
					if (!success)
					{
						return null;
					}
					jsonArray.Add(item);
					continue;
				}
				}
				NextToken(json, ref index);
				break;
			}
			return jsonArray;
		}

		private static object ParseValue(char[] json, ref int index, ref bool success)
		{
			switch (LookAhead(json, index))
			{
			case 7:
				return ParseString(json, ref index, ref success);
			case 8:
				return ParseNumber(json, ref index, ref success);
			case 1:
				return ParseObject(json, ref index, ref success);
			case 3:
				return ParseArray(json, ref index, ref success);
			case 9:
				NextToken(json, ref index);
				return true;
			case 10:
				NextToken(json, ref index);
				return false;
			case 11:
				NextToken(json, ref index);
				return null;
			default:
				success = false;
				return null;
			}
		}

		private static string ParseString(char[] json, ref int index, ref bool success)
		{
			StringBuilder stringBuilder = new StringBuilder(2000);
			EatWhitespace(json, ref index);
			char c = json[index++];
			bool flag = false;
			while (!flag && index != json.Length)
			{
				c = json[index++];
				switch (c)
				{
				case '"':
					flag = true;
					break;
				case '\\':
				{
					if (index == json.Length)
					{
						break;
					}
					switch (json[index++])
					{
					case '"':
						stringBuilder.Append('"');
						continue;
					case '\\':
						stringBuilder.Append('\\');
						continue;
					case '/':
						stringBuilder.Append('/');
						continue;
					case 'b':
						stringBuilder.Append('\b');
						continue;
					case 'f':
						stringBuilder.Append('\f');
						continue;
					case 'n':
						stringBuilder.Append('\n');
						continue;
					case 'r':
						stringBuilder.Append('\r');
						continue;
					case 't':
						stringBuilder.Append('\t');
						continue;
					case 'u':
						break;
					default:
						continue;
					}
					if (json.Length - index < 4)
					{
						break;
					}
					if (!(success = uint.TryParse(new string(json, index, 4), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var result)))
					{
						return "";
					}
					if (55296 <= result && result <= 56319)
					{
						index += 4;
						if (json.Length - index < 6 || !(new string(json, index, 2) == "\\u") || !uint.TryParse(new string(json, index + 2, 4), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var result2) || 56320 > result2 || result2 > 57343)
						{
							success = false;
							return "";
						}
						stringBuilder.Append((char)result);
						stringBuilder.Append((char)result2);
						index += 6;
					}
					else
					{
						stringBuilder.Append(ConvertFromUtf32((int)result));
						index += 4;
					}
					continue;
				}
				default:
					stringBuilder.Append(c);
					continue;
				}
				break;
			}
			if (!flag)
			{
				success = false;
				return null;
			}
			return stringBuilder.ToString();
		}

		private static string ConvertFromUtf32(int utf32)
		{
			if (utf32 < 0 || utf32 > 1114111)
			{
				throw new ArgumentOutOfRangeException("utf32", "The argument must be from 0 to 0x10FFFF.");
			}
			if (55296 <= utf32 && utf32 <= 57343)
			{
				throw new ArgumentOutOfRangeException("utf32", "The argument must not be in surrogate pair range.");
			}
			if (utf32 < 65536)
			{
				return new string((char)utf32, 1);
			}
			utf32 -= 65536;
			return new string(new char[2]
			{
				(char)((utf32 >> 10) + 55296),
				(char)(utf32 % 1024 + 56320)
			});
		}

		private static object ParseNumber(char[] json, ref int index, ref bool success)
		{
			EatWhitespace(json, ref index);
			int lastIndexOfNumber = GetLastIndexOfNumber(json, index);
			int length = lastIndexOfNumber - index + 1;
			string text = new string(json, index, length);
			object result2;
			if (text.IndexOf(".", StringComparison.OrdinalIgnoreCase) != -1 || text.IndexOf("e", StringComparison.OrdinalIgnoreCase) != -1)
			{
				success = double.TryParse(new string(json, index, length), NumberStyles.Any, CultureInfo.InvariantCulture, out var result);
				result2 = result;
			}
			else
			{
				success = long.TryParse(new string(json, index, length), NumberStyles.Any, CultureInfo.InvariantCulture, out var result3);
				result2 = result3;
			}
			index = lastIndexOfNumber + 1;
			return result2;
		}

		private static int GetLastIndexOfNumber(char[] json, int index)
		{
			int i;
			for (i = index; i < json.Length && "0123456789+-.eE".IndexOf(json[i]) != -1; i++)
			{
			}
			return i - 1;
		}

		private static void EatWhitespace(char[] json, ref int index)
		{
			while (index < json.Length && " \t\n\r\b\f".IndexOf(json[index]) != -1)
			{
				index++;
			}
		}

		private static int LookAhead(char[] json, int index)
		{
			int index2 = index;
			return NextToken(json, ref index2);
		}

		private static int NextToken(char[] json, ref int index)
		{
			EatWhitespace(json, ref index);
			if (index == json.Length)
			{
				return 0;
			}
			char c = json[index];
			index++;
			switch (c)
			{
			case '{':
				return 1;
			case '}':
				return 2;
			case '[':
				return 3;
			case ']':
				return 4;
			case ',':
				return 6;
			case '"':
				return 7;
			case '-':
			case '0':
			case '1':
			case '2':
			case '3':
			case '4':
			case '5':
			case '6':
			case '7':
			case '8':
			case '9':
				return 8;
			case ':':
				return 5;
			default:
			{
				index--;
				int num = json.Length - index;
				if (num >= 5 && json[index] == 'f' && json[index + 1] == 'a' && json[index + 2] == 'l' && json[index + 3] == 's' && json[index + 4] == 'e')
				{
					index += 5;
					return 10;
				}
				if (num >= 4 && json[index] == 't' && json[index + 1] == 'r' && json[index + 2] == 'u' && json[index + 3] == 'e')
				{
					index += 4;
					return 9;
				}
				if (num >= 4 && json[index] == 'n' && json[index + 1] == 'u' && json[index + 2] == 'l' && json[index + 3] == 'l')
				{
					index += 4;
					return 11;
				}
				return 0;
			}
			}
		}

		private static bool SerializeValue(IJsonSerializerStrategy jsonSerializerStrategy, object value, StringBuilder builder)
		{
			bool flag = true;
			if (value is string aString)
			{
				flag = SerializeString(aString, builder);
			}
			else if (value is IDictionary<string, object> dictionary)
			{
				flag = SerializeObject(jsonSerializerStrategy, dictionary.Keys, dictionary.Values, builder);
			}
			else if (value is IDictionary<string, string> dictionary2)
			{
				flag = SerializeObject(jsonSerializerStrategy, dictionary2.Keys, dictionary2.Values, builder);
			}
			else if (value is IEnumerable anArray)
			{
				flag = SerializeArray(jsonSerializerStrategy, anArray, builder);
			}
			else if (IsNumeric(value))
			{
				flag = SerializeNumber(value, builder);
			}
			else if (value is bool)
			{
				builder.Append(((bool)value) ? "true" : "false");
			}
			else if (value == null)
			{
				builder.Append("null");
			}
			else
			{
				flag = jsonSerializerStrategy.TrySerializeNonPrimitiveObject(value, out var output);
				if (flag)
				{
					SerializeValue(jsonSerializerStrategy, output, builder);
				}
			}
			return flag;
		}

		private static bool SerializeObject(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable keys, IEnumerable values, StringBuilder builder)
		{
			builder.Append("{");
			IEnumerator enumerator = keys.GetEnumerator();
			IEnumerator enumerator2 = values.GetEnumerator();
			bool flag = true;
			while (enumerator.MoveNext() && enumerator2.MoveNext())
			{
				object current = enumerator.Current;
				object current2 = enumerator2.Current;
				if (!flag)
				{
					builder.Append(",");
				}
				if (current is string aString)
				{
					SerializeString(aString, builder);
				}
				else if (!SerializeValue(jsonSerializerStrategy, current2, builder))
				{
					return false;
				}
				builder.Append(":");
				if (!SerializeValue(jsonSerializerStrategy, current2, builder))
				{
					return false;
				}
				flag = false;
			}
			builder.Append("}");
			return true;
		}

		private static bool SerializeArray(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable anArray, StringBuilder builder)
		{
			builder.Append("[");
			bool flag = true;
			foreach (object item in anArray)
			{
				if (!flag)
				{
					builder.Append(",");
				}
				if (!SerializeValue(jsonSerializerStrategy, item, builder))
				{
					return false;
				}
				flag = false;
			}
			builder.Append("]");
			return true;
		}

		private static bool SerializeString(string aString, StringBuilder builder)
		{
			if (aString.IndexOfAny(EscapeCharacters) == -1)
			{
				builder.Append('"');
				builder.Append(aString);
				builder.Append('"');
				return true;
			}
			builder.Append('"');
			int num = 0;
			char[] array = aString.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				char c = array[i];
				if (c >= EscapeTable.Length || EscapeTable[(uint)c] == '\0')
				{
					num++;
					continue;
				}
				if (num > 0)
				{
					builder.Append(array, i - num, num);
					num = 0;
				}
				builder.Append('\\');
				builder.Append(EscapeTable[(uint)c]);
			}
			if (num > 0)
			{
				builder.Append(array, array.Length - num, num);
			}
			builder.Append('"');
			return true;
		}

		private static bool SerializeNumber(object number, StringBuilder builder)
		{
			if (number is long)
			{
				builder.Append(((long)number).ToString(CultureInfo.InvariantCulture));
			}
			else if (number is ulong)
			{
				builder.Append(((ulong)number).ToString(CultureInfo.InvariantCulture));
			}
			else if (number is int)
			{
				builder.Append(((int)number).ToString(CultureInfo.InvariantCulture));
			}
			else if (number is uint)
			{
				builder.Append(((uint)number).ToString(CultureInfo.InvariantCulture));
			}
			else if (number is decimal)
			{
				builder.Append(((decimal)number).ToString(CultureInfo.InvariantCulture));
			}
			else if (number is float)
			{
				builder.Append(((float)number).ToString(CultureInfo.InvariantCulture));
			}
			else
			{
				builder.Append(Convert.ToDouble(number, CultureInfo.InvariantCulture).ToString("r", CultureInfo.InvariantCulture));
			}
			return true;
		}

		private static bool IsNumeric(object value)
		{
			if (value is sbyte)
			{
				return true;
			}
			if (value is byte)
			{
				return true;
			}
			if (value is short)
			{
				return true;
			}
			if (value is ushort)
			{
				return true;
			}
			if (value is int)
			{
				return true;
			}
			if (value is uint)
			{
				return true;
			}
			if (value is long)
			{
				return true;
			}
			if (value is ulong)
			{
				return true;
			}
			if (value is float)
			{
				return true;
			}
			if (value is double)
			{
				return true;
			}
			if (value is decimal)
			{
				return true;
			}
			return false;
		}
	}
	[GeneratedCode("simple-json", "1.0.0")]
	public interface IJsonSerializerStrategy
	{
		bool TrySerializeNonPrimitiveObject(object input, out object output);

		object DeserializeObject(object value, Type type);
	}
	[GeneratedCode("simple-json", "1.0.0")]
	public class PocoJsonSerializerStrategy : IJsonSerializerStrategy
	{
		internal IDictionary<Type, ReflectionUtils.ConstructorDelegate> ConstructorCache;

		internal IDictionary<Type, IDictionary<string, ReflectionUtils.GetDelegate>> GetCache;

		internal IDictionary<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>> SetCache;

		internal static readonly Type[] EmptyTypes = new Type[0];

		internal static readonly Type[] ArrayConstructorParameterTypes = new Type[1] { typeof(int) };

		private static readonly string[] Iso8601Format = new string[3] { "yyyy-MM-dd\\THH:mm:ss.FFFFFFF\\Z", "yyyy-MM-dd\\THH:mm:ss\\Z", "yyyy-MM-dd\\THH:mm:ssK" };

		public PocoJsonSerializerStrategy()
		{
			ConstructorCache = new ReflectionUtils.ThreadSafeDictionary<Type, ReflectionUtils.ConstructorDelegate>(ContructorDelegateFactory);
			GetCache = new ReflectionUtils.ThreadSafeDictionary<Type, IDictionary<string, ReflectionUtils.GetDelegate>>(GetterValueFactory);
			SetCache = new ReflectionUtils.ThreadSafeDictionary<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>>(SetterValueFactory);
		}

		protected virtual string MapClrMemberNameToJsonFieldName(string clrPropertyName)
		{
			return clrPropertyName;
		}

		internal virtual ReflectionUtils.ConstructorDelegate ContructorDelegateFactory(Type key)
		{
			return ReflectionUtils.GetContructor(key, key.IsArray ? ArrayConstructorParameterTypes : EmptyTypes);
		}

		internal virtual IDictionary<string, ReflectionUtils.GetDelegate> GetterValueFactory(Type type)
		{
			IDictionary<string, ReflectionUtils.GetDelegate> dictionary = new Dictionary<string, ReflectionUtils.GetDelegate>();
			foreach (PropertyInfo property in ReflectionUtils.GetProperties(type))
			{
				if (property.CanRead)
				{
					MethodInfo getterMethodInfo = ReflectionUtils.GetGetterMethodInfo(property);
					if (!getterMethodInfo.IsStatic && getterMethodInfo.IsPublic)
					{
						dictionary[MapClrMemberNameToJsonFieldName(property.Name)] = ReflectionUtils.GetGetMethod(property);
					}
				}
			}
			foreach (FieldInfo field in ReflectionUtils.GetFields(type))
			{
				if (!field.IsStatic && field.IsPublic)
				{
					dictionary[MapClrMemberNameToJsonFieldName(field.Name)] = ReflectionUtils.GetGetMethod(field);
				}
			}
			return dictionary;
		}

		internal virtual IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> SetterValueFactory(Type type)
		{
			IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> dictionary = new Dictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>();
			foreach (PropertyInfo property in ReflectionUtils.GetProperties(type))
			{
				if (property.CanWrite)
				{
					MethodInfo setterMethodInfo = ReflectionUtils.GetSetterMethodInfo(property);
					if (!setterMethodInfo.IsStatic && setterMethodInfo.IsPublic)
					{
						dictionary[MapClrMemberNameToJsonFieldName(property.Name)] = new KeyValuePair<Type, ReflectionUtils.SetDelegate>(property.PropertyType, ReflectionUtils.GetSetMethod(property));
					}
				}
			}
			foreach (FieldInfo field in ReflectionUtils.GetFields(type))
			{
				if (!field.IsInitOnly && !field.IsStatic && field.IsPublic)
				{
					dictionary[MapClrMemberNameToJsonFieldName(field.Name)] = new KeyValuePair<Type, ReflectionUtils.SetDelegate>(field.FieldType, ReflectionUtils.GetSetMethod(field));
				}
			}
			return dictionary;
		}

		public virtual bool TrySerializeNonPrimitiveObject(object input, out object output)
		{
			if (!TrySerializeKnownTypes(input, out output))
			{
				return TrySerializeUnknownTypes(input, out output);
			}
			return true;
		}

		public virtual object DeserializeObject(object value, Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			string text = value as string;
			if (type == typeof(Guid) && string.IsNullOrEmpty(text))
			{
				return default(Guid);
			}
			if (value == null)
			{
				return null;
			}
			object obj = null;
			if (text != null)
			{
				if (text.Length != 0)
				{
					if (type == typeof(DateTime) || (ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(DateTime)))
					{
						return DateTime.ParseExact(text, Iso8601Format, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);
					}
					if (type == typeof(DateTimeOffset) || (ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(DateTimeOffset)))
					{
						return DateTimeOffset.ParseExact(text, Iso8601Format, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);
					}
					if (type == typeof(Guid) || (ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(Guid)))
					{
						return new Guid(text);
					}
					if (type == typeof(Uri))
					{
						if (Uri.IsWellFormedUriString(text, UriKind.RelativeOrAbsolute) && Uri.TryCreate(text, UriKind.RelativeOrAbsolute, out var result))
						{
							return result;
						}
						return null;
					}
					if (type == typeof(string))
					{
						return text;
					}
					return Convert.ChangeType(text, type, CultureInfo.InvariantCulture);
				}
				obj = ((type == typeof(Guid)) ? ((object)default(Guid)) : ((!ReflectionUtils.IsNullableType(type) || !(Nullable.GetUnderlyingType(type) == typeof(Guid))) ? text : null));
				if (!ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(Guid))
				{
					return text;
				}
			}
			else if (value is bool)
			{
				return value;
			}
			bool flag = value is long;
			bool flag2 = value is double;
			if ((flag && type == typeof(long)) || (flag2 && type == typeof(double)))
			{
				return value;
			}
			if ((flag2 && type != typeof(double)) || (flag && type != typeof(long)))
			{
				obj = ((type == typeof(int) || type == typeof(long) || type == typeof(double) || type == typeof(float) || type == typeof(bool) || type == typeof(decimal) || type == typeof(byte) || type == typeof(short)) ? Convert.ChangeType(value, type, CultureInfo.InvariantCulture) : value);
				if (ReflectionUtils.IsNullableType(type))
				{
					return ReflectionUtils.ToNullableType(obj, type);
				}
				return obj;
			}
			if (value is IDictionary<string, object> dictionary)
			{
				IDictionary<string, object> dictionary2 = dictionary;
				if (ReflectionUtils.IsTypeDictionary(type))
				{
					Type[] genericTypeArguments = ReflectionUtils.GetGenericTypeArguments(type);
					Type type2 = genericTypeArguments[0];
					Type type3 = genericTypeArguments[1];
					Type key = typeof(Dictionary<, >).MakeGenericType(type2, type3);
					IDictionary dictionary3 = (IDictionary)ConstructorCache[key]();
					foreach (KeyValuePair<string, object> item in dictionary2)
					{
						dictionary3.Add(item.Key, DeserializeObject(item.Value, type3));
					}
					obj = dictionary3;
				}
				else if (type == typeof(object))
				{
					obj = value;
				}
				else
				{
					obj = ConstructorCache[type]();
					foreach (KeyValuePair<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> item2 in SetCache[type])
					{
						if (dictionary2.TryGetValue(item2.Key, out var value2))
						{
							value2 = DeserializeObject(value2, item2.Value.Key);
							item2.Value.Value(obj, value2);
						}
					}
				}
			}
			else if (value is IList<object> list)
			{
				IList<object> list2 = list;
				IList list3 = null;
				if (type.IsArray)
				{
					list3 = (IList)ConstructorCache[type](list2.Count);
					int num = 0;
					foreach (object item3 in list2)
					{
						list3[num++] = DeserializeObject(item3, type.GetElementType());
					}
				}
				else if (ReflectionUtils.IsTypeGenericeCollectionInterface(type) || ReflectionUtils.IsAssignableFrom(typeof(IList), type))
				{
					Type genericListElementType = ReflectionUtils.GetGenericListElementType(type);
					list3 = (IList)(ConstructorCache[type] ?? ConstructorCache[typeof(List<>).MakeGenericType(genericListElementType)])(list2.Count);
					foreach (object item4 in list2)
					{
						list3.Add(DeserializeObject(item4, genericListElementType));
					}
				}
				obj = list3;
			}
			return obj;
		}

		protected virtual object SerializeEnum(Enum p)
		{
			return Convert.ToDouble(p, CultureInfo.InvariantCulture);
		}

		protected virtual bool TrySerializeKnownTypes(object input, out object output)
		{
			bool result = true;
			if (input is DateTime)
			{
				output = ((DateTime)input).ToUniversalTime().ToString(Iso8601Format[0], CultureInfo.InvariantCulture);
			}
			else if (input is DateTimeOffset)
			{
				output = ((DateTimeOffset)input).ToUniversalTime().ToString(Iso8601Format[0], CultureInfo.InvariantCulture);
			}
			else if (input is Guid)
			{
				output = ((Guid)input).ToString("D");
			}
			else if (input is Uri)
			{
				output = input.ToString();
			}
			else if (input is Enum p)
			{
				output = SerializeEnum(p);
			}
			else
			{
				result = false;
				output = null;
			}
			return result;
		}

		protected virtual bool TrySerializeUnknownTypes(object input, out object output)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			output = null;
			Type type = input.GetType();
			if (type.FullName == null)
			{
				return false;
			}
			IDictionary<string, object> dictionary = new JsonObject();
			foreach (KeyValuePair<string, ReflectionUtils.GetDelegate> item in GetCache[type])
			{
				if (item.Value != null)
				{
					dictionary.Add(MapClrMemberNameToJsonFieldName(item.Key), item.Value(input));
				}
			}
			output = dictionary;
			return true;
		}
	}
}
namespace SimpleJson2.Reflection
{
	[GeneratedCode("reflection-utils", "1.0.0")]
	internal class ReflectionUtils
	{
		public delegate object GetDelegate(object source);

		public delegate void SetDelegate(object source, object value);

		public delegate object ConstructorDelegate(params object[] args);

		public delegate TValue ThreadSafeDictionaryValueFactory<TKey, TValue>(TKey key);

		private static class Assigner<T>
		{
			public static T Assign(ref T left, T right)
			{
				return left = right;
			}
		}

		public sealed class ThreadSafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
		{
			private readonly object _lock = new object();

			private readonly ThreadSafeDictionaryValueFactory<TKey, TValue> _valueFactory;

			private Dictionary<TKey, TValue> _dictionary;

			public ICollection<TKey> Keys => _dictionary.Keys;

			public ICollection<TValue> Values => _dictionary.Values;

			public TValue this[TKey key]
			{
				get
				{
					return Get(key);
				}
				set
				{
					throw new NotImplementedException();
				}
			}

			public int Count => _dictionary.Count;

			public bool IsReadOnly
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			public ThreadSafeDictionary(ThreadSafeDictionaryValueFactory<TKey, TValue> valueFactory)
			{
				_valueFactory = valueFactory;
			}

			private TValue Get(TKey key)
			{
				if (_dictionary == null)
				{
					return AddValue(key);
				}
				if (!_dictionary.TryGetValue(key, out var value))
				{
					return AddValue(key);
				}
				return value;
			}

			private TValue AddValue(TKey key)
			{
				TValue val = _valueFactory(key);
				lock (_lock)
				{
					if (_dictionary == null)
					{
						_dictionary = new Dictionary<TKey, TValue>();
						_dictionary[key] = val;
					}
					else
					{
						if (_dictionary.TryGetValue(key, out var value))
						{
							return value;
						}
						Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>(_dictionary);
						dictionary[key] = val;
						_dictionary = dictionary;
					}
				}
				return val;
			}

			public void Add(TKey key, TValue value)
			{
				throw new NotImplementedException();
			}

			public bool ContainsKey(TKey key)
			{
				return _dictionary.ContainsKey(key);
			}

			public bool Remove(TKey key)
			{
				throw new NotImplementedException();
			}

			public bool TryGetValue(TKey key, out TValue value)
			{
				value = this[key];
				return true;
			}

			public void Add(KeyValuePair<TKey, TValue> item)
			{
				throw new NotImplementedException();
			}

			public void Clear()
			{
				throw new NotImplementedException();
			}

			public bool Contains(KeyValuePair<TKey, TValue> item)
			{
				throw new NotImplementedException();
			}

			public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
			{
				throw new NotImplementedException();
			}

			public bool Remove(KeyValuePair<TKey, TValue> item)
			{
				throw new NotImplementedException();
			}

			public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
			{
				return _dictionary.GetEnumerator();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return _dictionary.GetEnumerator();
			}
		}

		private static readonly object[] EmptyObjects = new object[0];

		public static Type GetTypeInfo(Type type)
		{
			return type;
		}

		public static Attribute GetAttribute(MemberInfo info, Type type)
		{
			if (info == null || type == null || !Attribute.IsDefined(info, type))
			{
				return null;
			}
			return Attribute.GetCustomAttribute(info, type);
		}

		public static Type GetGenericListElementType(Type type)
		{
			foreach (Type item in (IEnumerable<Type>)type.GetInterfaces())
			{
				if (IsTypeGeneric(item) && item.GetGenericTypeDefinition() == typeof(IList<>))
				{
					return GetGenericTypeArguments(item)[0];
				}
			}
			return GetGenericTypeArguments(type)[0];
		}

		public static Attribute GetAttribute(Type objectType, Type attributeType)
		{
			if (objectType == null || attributeType == null || !Attribute.IsDefined(objectType, attributeType))
			{
				return null;
			}
			return Attribute.GetCustomAttribute(objectType, attributeType);
		}

		public static Type[] GetGenericTypeArguments(Type type)
		{
			return type.GetGenericArguments();
		}

		public static bool IsTypeGeneric(Type type)
		{
			return GetTypeInfo(type).IsGenericType;
		}

		public static bool IsTypeGenericeCollectionInterface(Type type)
		{
			if (!IsTypeGeneric(type))
			{
				return false;
			}
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			if (!(genericTypeDefinition == typeof(IList<>)) && !(genericTypeDefinition == typeof(ICollection<>)))
			{
				return genericTypeDefinition == typeof(IEnumerable<>);
			}
			return true;
		}

		public static bool IsAssignableFrom(Type type1, Type type2)
		{
			return GetTypeInfo(type1).IsAssignableFrom(GetTypeInfo(type2));
		}

		public static bool IsTypeDictionary(Type type)
		{
			if (typeof(IDictionary).IsAssignableFrom(type))
			{
				return true;
			}
			if (!GetTypeInfo(type).IsGenericType)
			{
				return false;
			}
			return type.GetGenericTypeDefinition() == typeof(IDictionary<, >);
		}

		public static bool IsNullableType(Type type)
		{
			if (GetTypeInfo(type).IsGenericType)
			{
				return type.GetGenericTypeDefinition() == typeof(Nullable<>);
			}
			return false;
		}

		public static object ToNullableType(object obj, Type nullableType)
		{
			if (obj != null)
			{
				return Convert.ChangeType(obj, Nullable.GetUnderlyingType(nullableType), CultureInfo.InvariantCulture);
			}
			return null;
		}

		public static bool IsValueType(Type type)
		{
			return GetTypeInfo(type).IsValueType;
		}

		public static IEnumerable<ConstructorInfo> GetConstructors(Type type)
		{
			return type.GetConstructors();
		}

		public static ConstructorInfo GetConstructorInfo(Type type, params Type[] argsType)
		{
			foreach (ConstructorInfo constructor in GetConstructors(type))
			{
				ParameterInfo[] parameters = constructor.GetParameters();
				if (argsType.Length != parameters.Length)
				{
					continue;
				}
				int num = 0;
				bool flag = true;
				ParameterInfo[] parameters2 = constructor.GetParameters();
				for (int i = 0; i < parameters2.Length; i++)
				{
					if (parameters2[i].ParameterType != argsType[num])
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					return constructor;
				}
			}
			return null;
		}

		public static IEnumerable<PropertyInfo> GetProperties(Type type)
		{
			return type.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		public static IEnumerable<FieldInfo> GetFields(Type type)
		{
			return type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		public static MethodInfo GetGetterMethodInfo(PropertyInfo propertyInfo)
		{
			return propertyInfo.GetGetMethod(nonPublic: true);
		}

		public static MethodInfo GetSetterMethodInfo(PropertyInfo propertyInfo)
		{
			return propertyInfo.GetSetMethod(nonPublic: true);
		}

		public static ConstructorDelegate GetContructor(ConstructorInfo constructorInfo)
		{
			return GetConstructorByExpression(constructorInfo);
		}

		public static ConstructorDelegate GetContructor(Type type, params Type[] argsType)
		{
			return GetConstructorByExpression(type, argsType);
		}

		public static ConstructorDelegate GetConstructorByReflection(ConstructorInfo constructorInfo)
		{
			return (object[] args) => constructorInfo.Invoke(args);
		}

		public static ConstructorDelegate GetConstructorByReflection(Type type, params Type[] argsType)
		{
			ConstructorInfo constructorInfo = GetConstructorInfo(type, argsType);
			if (!(constructorInfo == null))
			{
				return GetConstructorByReflection(constructorInfo);
			}
			return null;
		}

		public static ConstructorDelegate GetConstructorByExpression(ConstructorInfo constructorInfo)
		{
			ParameterInfo[] parameters = constructorInfo.GetParameters();
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object[]), "args");
			Expression[] array = new Expression[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				Expression index = Expression.Constant(i);
				Type parameterType = parameters[i].ParameterType;
				Expression expression = Expression.Convert(Expression.ArrayIndex(parameterExpression, index), parameterType);
				array[i] = expression;
			}
			Expression<Func<object[], object>> expression2 = Expression.Lambda<Func<object[], object>>(Expression.New(constructorInfo, array), new ParameterExpression[1] { parameterExpression });
			Func<object[], object> compiledLambda = expression2.Compile();
			return (object[] args) => compiledLambda(args);
		}

		public static ConstructorDelegate GetConstructorByExpression(Type type, params Type[] argsType)
		{
			ConstructorInfo constructorInfo = GetConstructorInfo(type, argsType);
			if (!(constructorInfo == null))
			{
				return GetConstructorByExpression(constructorInfo);
			}
			return null;
		}

		public static GetDelegate GetGetMethod(PropertyInfo propertyInfo)
		{
			return GetGetMethodByExpression(propertyInfo);
		}

		public static GetDelegate GetGetMethod(FieldInfo fieldInfo)
		{
			return GetGetMethodByExpression(fieldInfo);
		}

		public static GetDelegate GetGetMethodByReflection(PropertyInfo propertyInfo)
		{
			MethodInfo methodInfo = GetGetterMethodInfo(propertyInfo);
			return (object source) => methodInfo.Invoke(source, EmptyObjects);
		}

		public static GetDelegate GetGetMethodByReflection(FieldInfo fieldInfo)
		{
			return (object source) => fieldInfo.GetValue(source);
		}

		public static GetDelegate GetGetMethodByExpression(PropertyInfo propertyInfo)
		{
			MethodInfo getterMethodInfo = GetGetterMethodInfo(propertyInfo);
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), "instance");
			UnaryExpression instance = ((!IsValueType(propertyInfo.DeclaringType)) ? Expression.TypeAs(parameterExpression, propertyInfo.DeclaringType) : Expression.Convert(parameterExpression, propertyInfo.DeclaringType));
			Func<object, object> compiled = Expression.Lambda<Func<object, object>>(Expression.TypeAs(Expression.Call(instance, getterMethodInfo), typeof(object)), new ParameterExpression[1] { parameterExpression }).Compile();
			return (object source) => compiled(source);
		}

		public static GetDelegate GetGetMethodByExpression(FieldInfo fieldInfo)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), "instance");
			MemberExpression expression = Expression.Field(Expression.Convert(parameterExpression, fieldInfo.DeclaringType), fieldInfo);
			GetDelegate compiled = Expression.Lambda<GetDelegate>(Expression.Convert(expression, typeof(object)), new ParameterExpression[1] { parameterExpression }).Compile();
			return (object source) => compiled(source);
		}

		public static SetDelegate GetSetMethod(PropertyInfo propertyInfo)
		{
			return GetSetMethodByExpression(propertyInfo);
		}

		public static SetDelegate GetSetMethod(FieldInfo fieldInfo)
		{
			return GetSetMethodByExpression(fieldInfo);
		}

		public static SetDelegate GetSetMethodByReflection(PropertyInfo propertyInfo)
		{
			MethodInfo methodInfo = GetSetterMethodInfo(propertyInfo);
			return delegate(object source, object value)
			{
				methodInfo.Invoke(source, new object[1] { value });
			};
		}

		public static SetDelegate GetSetMethodByReflection(FieldInfo fieldInfo)
		{
			return delegate(object source, object value)
			{
				fieldInfo.SetValue(source, value);
			};
		}

		public static SetDelegate GetSetMethodByExpression(PropertyInfo propertyInfo)
		{
			MethodInfo setterMethodInfo = GetSetterMethodInfo(propertyInfo);
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), "instance");
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object), "value");
			UnaryExpression instance = ((!IsValueType(propertyInfo.DeclaringType)) ? Expression.TypeAs(parameterExpression, propertyInfo.DeclaringType) : Expression.Convert(parameterExpression, propertyInfo.DeclaringType));
			UnaryExpression unaryExpression = ((!IsValueType(propertyInfo.PropertyType)) ? Expression.TypeAs(parameterExpression2, propertyInfo.PropertyType) : Expression.Convert(parameterExpression2, propertyInfo.PropertyType));
			Action<object, object> compiled = Expression.Lambda<Action<object, object>>(Expression.Call(instance, setterMethodInfo, unaryExpression), new ParameterExpression[2] { parameterExpression, parameterExpression2 }).Compile();
			return delegate(object source, object val)
			{
				compiled(source, val);
			};
		}

		public static SetDelegate GetSetMethodByExpression(FieldInfo fieldInfo)
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object), "instance");
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object), "value");
			Action<object, object> compiled = Expression.Lambda<Action<object, object>>(Assign(Expression.Field(Expression.Convert(parameterExpression, fieldInfo.DeclaringType), fieldInfo), Expression.Convert(parameterExpression2, fieldInfo.FieldType)), new ParameterExpression[2] { parameterExpression, parameterExpression2 }).Compile();
			return delegate(object source, object val)
			{
				compiled(source, val);
			};
		}

		public static BinaryExpression Assign(Expression left, Expression right)
		{
			MethodInfo method = typeof(Assigner<>).MakeGenericType(left.Type).GetMethod("Assign");
			return Expression.Add(left, right, method);
		}
	}
}
namespace GameSparks.Platforms
{
	public class DefaultPlatform : PlatformBase
	{
		public override IGameSparksTimer GetTimer()
		{
			return new GameSparksTimer();
		}

		public override string MakeHmac(string stringToHmac, string secret)
		{
			return GameSparksUtil.MakeHmac(stringToHmac, secret);
		}

		public override IGameSparksWebSocket GetSocket(string url, Action<string> messageReceived, Action closed, Action opened, Action<string> error)
		{
			GameSparksWebSocket gameSparksWebSocket = new GameSparksWebSocket();
			gameSparksWebSocket.Initialize(url, messageReceived, closed, opened, error);
			return gameSparksWebSocket;
		}
	}
	public interface IControlledTimer : IGameSparksTimer
	{
		void Update(long ticks);
	}
	public interface IControlledWebSocket : IGameSparksWebSocket
	{
		int SocketId { get; }

		void TriggerOnClose();

		void TriggerOnOpen();

		void TriggerOnError(string message);

		void TriggerOnMessage(string message);

		bool Update();
	}
	public abstract class PlatformBase : MonoBehaviour, IGSPlatform
	{
		private static string PLAYER_PREF_AUTHTOKEN_KEY = "gamesparks.authtoken";

		private static string PLAYER_PREF_USERID_KEY = "gamesparks.userid";

		private static string PLAYER_PREF_DEVICEID_KEY = "gamesparks.deviceid";

		private List<Action> _actions = new List<Action>();

		private List<Action> _currentActions = new List<Action>();

		private bool _allowQuitting;

		private string m_authToken = "0";

		private string m_userId = "";

		public string DeviceOS
		{
			get
			{
				switch (Application.platform)
				{
				case RuntimePlatform.OSXEditor:
				case RuntimePlatform.OSXPlayer:
				case RuntimePlatform.WindowsPlayer:
				case RuntimePlatform.WindowsEditor:
					return "WINDOWS";
				case RuntimePlatform.IPhonePlayer:
					return "IOS";
				case RuntimePlatform.Android:
					return "ANDROID";
				case RuntimePlatform.LinuxPlayer:
					return "LINUX";
				case RuntimePlatform.WebGLPlayer:
					return "WEBGL";
				case RuntimePlatform.MetroPlayerX86:
				case RuntimePlatform.MetroPlayerX64:
				case RuntimePlatform.MetroPlayerARM:
					return "WSA";
				case RuntimePlatform.TizenPlayer:
					return "TIZEN";
				case RuntimePlatform.PS4:
					return "PS4";
				case RuntimePlatform.XboxOne:
					return "XBOXONE";
				case RuntimePlatform.WiiU:
					return "WIIU";
				case RuntimePlatform.tvOS:
					return "TVOS";
				default:
					return "UNKNOWN";
				}
			}
		}

		public string DeviceName { get; private set; }

		public string DeviceType { get; private set; }

		public GSData DeviceStats { get; private set; }

		public virtual string DeviceId { get; private set; }

		public string Platform { get; private set; }

		public bool ExtraDebug { get; private set; }

		public string ApiKey => GameSparksSettings.ApiKey;

		public string ApiSecret => GameSparksSettings.ApiSecret;

		public string ApiCredential => GameSparksSettings.Credential;

		public string ApiStage
		{
			get
			{
				if (!GameSparksSettings.PreviewBuild)
				{
					return "live";
				}
				return "preview";
			}
		}

		public string ApiDomain => null;

		public string PersistentDataPath { get; private set; }

		public string SDK => "Unity";

		public string AuthToken
		{
			get
			{
				return m_authToken;
			}
			set
			{
				m_authToken = value;
			}
		}

		public string UserId
		{
			get
			{
				return m_userId;
			}
			set
			{
				m_userId = value;
			}
		}

		public Action<Exception> ExceptionReporter { get; set; }

		protected virtual void Start()
		{
			DeviceName = SystemInfo.deviceName.ToString();
			DeviceType = SystemInfo.deviceType.ToString();
			if (Application.platform == RuntimePlatform.PS4 || Application.platform == RuntimePlatform.XboxOne || "n/a" == SystemInfo.deviceUniqueIdentifier)
			{
				if ("n/a" == SystemInfo.deviceUniqueIdentifier)
				{
					DeviceId = Guid.NewGuid().ToString();
				}
				else
				{
					DeviceId = SystemInfo.deviceUniqueIdentifier.ToString();
				}
			}
			else
			{
				DeviceId = SystemInfo.deviceUniqueIdentifier.ToString();
			}
			char[] separator = new char[8] { ' ', ',', '.', ':', '-', '_', '(', ')' };
			int processorCount = SystemInfo.processorCount;
			string text = "Unknown";
			string value = SystemInfo.deviceModel;
			string value2 = SystemInfo.systemMemorySize + " MB";
			string text2 = SystemInfo.operatingSystem;
			string value3 = SystemInfo.operatingSystem;
			string text3 = SystemInfo.processorType;
			string value4 = Screen.width + "x" + Screen.height;
			string version = GS.Version;
			string sDK = SDK;
			string unityVersion = Application.unityVersion;
			switch (DeviceOS)
			{
			case "MACOS":
			case "IOS":
			case "TVOS":
			{
				text = "Apple";
				string[] array = SystemInfo.operatingSystem.Split(separator);
				if (DeviceOS.Equals("MACOS"))
				{
					text2 = array[0] + " " + array[1] + " " + array[2];
					value3 = array[3] + "." + array[4] + "." + array[5];
				}
				else
				{
					text2 = array[0];
					value3 = array[1] + "." + array[2];
				}
				break;
			}
			case "WINDOWS":
			case "WSA":
			case "XBOXONE":
			{
				text = "Microsoft";
				if (DeviceOS.Equals("XBOXONE"))
				{
					value = "Xbox One";
					value2 = SystemInfo.systemMemorySize / 1000 + " MB";
					value3 = "Unknown";
				}
				else
				{
					value = "PC";
					string[] array = SystemInfo.operatingSystem.Split(separator, StringSplitOptions.RemoveEmptyEntries);
					text2 = array[0] + " " + array[1];
					value3 = array[2] + "." + array[3] + "." + array[4];
				}
				text3 = text3 + " " + SystemInfo.processorFrequency + "MHz";
				RegexOptions options = RegexOptions.None;
				text3 = new Regex("[ ]{2,}", options).Replace(text3, " ");
				break;
			}
			case "ANDROID":
			{
				string[] array = SystemInfo.deviceModel.Split(separator);
				text = array[0];
				value = SystemInfo.deviceModel.Replace(text, "").Substring(1);
				array = SystemInfo.operatingSystem.Split(separator);
				text2 = array[0] + " " + array[1];
				value3 = array[7];
				text3 = text3 + " " + SystemInfo.processorFrequency + "MHz";
				break;
			}
			case "WIIU":
				text = "Nintendo";
				value = "WiiU";
				break;
			case "SWITCH":
				text = "Nintendo";
				value = "Switch";
				value3 = "Unknown";
				break;
			case "PS4":
			{
				text = "Sony";
				value = "PS4";
				value2 = SystemInfo.systemMemorySize / 1000000 + " MB";
				string[] array = SystemInfo.operatingSystem.Split(separator);
				text2 = array[0];
				value3 = array[1] + "." + array[2] + "." + array[3];
				text3 = text3 + " " + SystemInfo.processorFrequency + "MHz";
				break;
			}
			case "TIZEN":
				text = "Tizen";
				break;
			case "WEBGL":
			{
				string[] array = SystemInfo.deviceModel.Split(separator);
				value = array[0];
				array = SystemInfo.operatingSystem.Split(separator);
				text2 = array[0];
				if (text2.Equals("Mac"))
				{
					text2 = text2 + " " + array[1] + " " + array[2];
					value3 = array[3] + "." + array[4] + "." + array[5];
				}
				else
				{
					value3 = array[1];
				}
				break;
			}
			}
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("manufacturer", text);
			dictionary.Add("model", value);
			dictionary.Add("memory", value2);
			dictionary.Add("os.name", text2);
			dictionary.Add("os.version", value3);
			dictionary.Add("cpu.cores", processorCount.ToString());
			dictionary.Add("cpu.vendor", text3);
			dictionary.Add("resolution", value4);
			dictionary.Add("gssdk", version);
			dictionary.Add("engine", sDK);
			dictionary.Add("engine.version", unityVersion);
			DeviceStats = new GSData(dictionary);
			Platform = Application.platform.ToString();
			GameSparksUnity component = GetComponent<GameSparksUnity>();
			if (component.settings != null)
			{
				GameSparksSettings.SetInstance(component.settings);
			}
			ExtraDebug = GameSparksSettings.DebugBuild;
			PersistentDataPath = Application.persistentDataPath;
			GS.Initialise(this);
			UnityEngine.Object.DontDestroyOnLoad(this);
		}

		public void ExecuteOnMainThread(Action action)
		{
			lock (_actions)
			{
				_actions.Add(action);
			}
		}

		protected virtual void Update()
		{
			lock (_actions)
			{
				if (_actions.Count > 0)
				{
					_currentActions.AddRange(_actions);
					_actions.Clear();
				}
			}
			int count = _currentActions.Count;
			if (count <= 0)
			{
				return;
			}
			for (int i = 0; i < count; i++)
			{
				Action action = _currentActions[i];
				if (action == null)
				{
					continue;
				}
				try
				{
					action();
				}
				catch (Exception ex)
				{
					if (ExceptionReporter != null)
					{
						ExceptionReporter(ex);
					}
					else
					{
						UnityEngine.Debug.Log(ex);
					}
				}
			}
			_currentActions.Clear();
		}

		protected virtual void OnApplicationPause(bool paused)
		{
			if (paused)
			{
				return;
			}
			try
			{
				GS.Reconnect();
			}
			catch (Exception obj)
			{
				if (ExceptionReporter != null)
				{
					ExceptionReporter(obj);
				}
			}
		}

		protected virtual void OnApplicationQuit()
		{
			GS.ShutDown();
			StartCoroutine("DelayedQuit");
			if (!_allowQuitting)
			{
				Application.CancelQuit();
			}
		}

		private IEnumerator DelayedQuit()
		{
			yield return new WaitForSeconds(1f);
			while (GS.Available)
			{
				yield return new WaitForSeconds(0.1f);
			}
			_allowQuitting = true;
			Application.Quit();
		}

		public void DebugMsg(string message)
		{
			ExecuteOnMainThread(delegate
			{
				if (GameSparksSettings.DebugBuild)
				{
					if (message.Length < 1500)
					{
						UnityEngine.Debug.Log("GS: " + message);
					}
					else
					{
						UnityEngine.Debug.Log("GS: " + message.Substring(0, 1500) + "...");
					}
				}
			});
		}

		public abstract IGameSparksTimer GetTimer();

		public abstract string MakeHmac(string stringToHmac, string secret);

		public abstract IGameSparksWebSocket GetSocket(string url, Action<string> messageReceived, Action closed, Action opened, Action<string> error);
	}
	public class TimerController
	{
		private long timeOfLastUpdate;

		private List<IControlledTimer> timers = new List<IControlledTimer>();

		public void Initialize()
		{
			timeOfLastUpdate = DateTime.UtcNow.Ticks;
		}

		public void Update()
		{
			long num = DateTime.UtcNow.Ticks - timeOfLastUpdate;
			timeOfLastUpdate += num;
			foreach (IControlledTimer timer in timers)
			{
				timer.Update(num);
			}
		}

		public void AddTimer(IControlledTimer timer)
		{
			timers.Add(timer);
		}

		public void RemoveTimer(IControlledTimer timer)
		{
			timers.Remove(timer);
		}
	}
	public class UnityTimer : IControlledTimer, IGameSparksTimer
	{
		private Action callback;

		private int interval;

		private long elapsedTicks;

		private bool running;

		private TimerController controller;

		public void SetController(TimerController controller)
		{
			this.controller = controller;
			this.controller.AddTimer(this);
		}

		public void Initialize(int interval, Action callback)
		{
			this.callback = callback;
			this.interval = interval;
			running = true;
		}

		public void Trigger()
		{
		}

		public void Stop()
		{
			running = false;
			callback = null;
			controller.RemoveTimer(this);
		}

		public void Update(long ticks)
		{
			if (!running)
			{
				return;
			}
			elapsedTicks += ticks;
			if (elapsedTicks > interval)
			{
				elapsedTicks -= interval;
				if (callback != null)
				{
					callback();
				}
			}
		}
	}
	public class WebSocketController : MonoBehaviour
	{
		private List<IControlledWebSocket> webSockets = new List<IControlledWebSocket>();

		private bool websocketCollectionModified;

		public string GSName { get; set; }

		private void Awake()
		{
			GSName = base.name;
		}

		public void AddWebSocket(IControlledWebSocket socket)
		{
			webSockets.Add(socket);
			websocketCollectionModified = true;
		}

		public void RemoveWebSocket(IControlledWebSocket socket)
		{
			webSockets.Remove(socket);
			websocketCollectionModified = true;
		}

		private IControlledWebSocket GetSocket(int socketId)
		{
			foreach (IControlledWebSocket webSocket in webSockets)
			{
				if (webSocket.SocketId == socketId)
				{
					return webSocket;
				}
			}
			return null;
		}

		public void GSSocketOnOpen(string data)
		{
			IDictionary<string, object> obj = ((IDictionary<string, object>)GSJson.From(data)) ?? throw new FormatException("parsed json was null. ");
			if (!obj.ContainsKey("socketId"))
			{
				throw new FormatException();
			}
			int socketId = Convert.ToInt32(obj["socketId"]);
			GetSocket(socketId)?.TriggerOnOpen();
		}

		public void GSSocketOnClose(string data)
		{
			int socketId = Convert.ToInt32(((IDictionary<string, object>)GSJson.From(data))["socketId"]);
			GetSocket(socketId)?.TriggerOnClose();
		}

		public void GSSocketOnMessage(string data)
		{
			IDictionary<string, object> dictionary = (IDictionary<string, object>)GSJson.From(data);
			int socketId = Convert.ToInt32(dictionary["socketId"]);
			GetSocket(socketId)?.TriggerOnMessage((string)dictionary["message"]);
		}

		public void GSSocketOnError(string data)
		{
			IDictionary<string, object> obj = (IDictionary<string, object>)GSJson.From(data);
			int socketId = Convert.ToInt32(obj["socketId"]);
			string message = (string)obj["error"];
			GetSocket(socketId)?.TriggerOnError(message);
		}

		public void ServerToClient(string jsonData)
		{
			IDictionary<string, object> dictionary = GSJson.From(jsonData) as IDictionary<string, object>;
			int socketId = int.Parse(dictionary["socketId"].ToString());
			IControlledWebSocket socket = GetSocket(socketId);
			if (socket != null)
			{
				switch (dictionary["functionName"].ToString())
				{
				case "onError":
					socket.TriggerOnError(dictionary["data"].ToString());
					break;
				case "onMessage":
					socket.TriggerOnMessage(dictionary["data"].ToString());
					break;
				case "onOpen":
					socket.TriggerOnOpen();
					break;
				case "onClose":
					socket.TriggerOnClose();
					break;
				}
			}
		}

		private void Update()
		{
			websocketCollectionModified = false;
			foreach (IControlledWebSocket webSocket in webSockets)
			{
				webSocket.Update();
				if (websocketCollectionModified)
				{
					break;
				}
			}
		}
	}
}
namespace Battlehub.UIControls
{
	public class ItemContainer : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		private bool m_isSelected;

		public virtual bool IsSelected
		{
			get
			{
				return m_isSelected;
			}
			set
			{
				if (m_isSelected == value)
				{
					return;
				}
				m_isSelected = value;
				if (m_isSelected)
				{
					if (ItemContainer.Selected != null)
					{
						ItemContainer.Selected(this, EventArgs.Empty);
					}
				}
				else if (ItemContainer.Unselected != null)
				{
					ItemContainer.Unselected(this, EventArgs.Empty);
				}
			}
		}

		public int Index { get; set; }

		public object Item { get; set; }

		public static event EventHandler Selected;

		public static event EventHandler Unselected;

		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
			IsSelected = true;
		}
	}
	public class SelectionChangedEventArgs : EventArgs
	{
		public object[] OldItems { get; private set; }

		public int[] OldIndices { get; private set; }

		public object[] NewItems { get; private set; }

		public int[] NewIndices { get; private set; }

		public object OldItem
		{
			get
			{
				if (OldItems == null)
				{
					return null;
				}
				return OldItems[0];
			}
		}

		public int OldIndex
		{
			get
			{
				if (OldIndices == null)
				{
					return -1;
				}
				return OldIndices[0];
			}
		}

		public object NewItem
		{
			get
			{
				if (NewItems == null)
				{
					return null;
				}
				return NewItems[0];
			}
		}

		public int NewIndex
		{
			get
			{
				if (NewIndices == null)
				{
					return -1;
				}
				return NewIndices[0];
			}
		}

		public SelectionChangedEventArgs(object[] oldItems, int[] oldIndices, object[] newItems, int[] newIndices)
		{
			OldItems = oldItems;
			OldIndices = oldIndices;
			NewItems = newItems;
			NewIndices = newIndices;
		}

		public SelectionChangedEventArgs(object oldItem, int oldIndex, object newItem, int newIndex)
		{
			OldItems = new object[1] { oldItem };
			OldIndices = new int[1] { oldIndex };
			NewItems = new object[1] { newItem };
			NewIndices = new int[1] { newIndex };
		}
	}
	public class ItemAddEventArgs : EventArgs
	{
		public int Index { get; private set; }

		public ItemAddEventArgs(int index)
		{
			Index = index;
		}
	}
	public class ItemRemovedEventArgs : EventArgs
	{
		public object Item { get; private set; }

		public ItemRemovedEventArgs(object item)
		{
			Item = item;
		}
	}
	public class ItemDataBindingEventArgs : EventArgs
	{
		public object Item { get; private set; }

		public GameObject ItemPresenter { get; private set; }

		public ItemDataBindingEventArgs(object item, GameObject itemPresenter)
		{
			Item = item;
			ItemPresenter = itemPresenter;
		}
	}
	public class CancelEventArgs : EventArgs
	{
		public bool Cancel { get; set; }
	}
	public class ItemsControl : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		[SerializeField]
		private GameObject ItemContainerPrefab;

		public Transform Panel;

		private ItemContainer[] m_itemContainers;

		private IList m_items;

		private ItemContainer m_selectedItem;

		public IList Items
		{
			get
			{
				return m_items;
			}
			set
			{
				m_items = value;
				DataBind();
			}
		}

		public object SelectedItem
		{
			get
			{
				if (m_selectedItem == null)
				{
					return null;
				}
				return m_selectedItem.Item;
			}
			set
			{
				SelectedIndex = IndexOf(value);
			}
		}

		public int SelectedIndex
		{
			get
			{
				if (m_selectedItem == null)
				{
					return -1;
				}
				return m_selectedItem.Index;
			}
			set
			{
				if ((!(m_selectedItem == null) || value != -1) && (!(m_selectedItem != null) || m_selectedItem.Index != value))
				{
					ItemContainer selectedItem = m_selectedItem;
					object oldItem = null;
					int oldIndex = -1;
					if (selectedItem != null)
					{
						selectedItem.IsSelected = false;
						oldItem = selectedItem.Item;
						oldIndex = selectedItem.Index;
					}
					m_selectedItem = m_itemContainers.Where((ItemContainer i) => i.Index == value).FirstOrDefault();
					object newItem = null;
					int newIndex = -1;
					if (m_selectedItem != null)
					{
						m_selectedItem.IsSelected = true;
						newItem = m_selectedItem.Item;
						newIndex = m_selectedItem.Index;
					}
					if (this.SelectionChanged != null)
					{
						this.SelectionChanged(this, new SelectionChangedEventArgs(oldItem, oldIndex, newItem, newIndex));
					}
				}
			}
		}

		public event EventHandler<ItemDataBindingEventArgs> ItemDataBinding;

		public event EventHandler<SelectionChangedEventArgs> SelectionChanged;

		private void Awake()
		{
			if (Panel == null)
			{
				Panel = base.transform;
			}
			m_itemContainers = GetComponentsInChildren<ItemContainer>();
		}

		private void OnEnable()
		{
			ItemContainer.Selected += OnItemSelected;
		}

		private void OnDisable()
		{
			ItemContainer.Selected -= OnItemSelected;
		}

		public int IndexOf(object obj)
		{
			if (m_items == null)
			{
				return -1;
			}
			if (obj == null)
			{
				return -1;
			}
			return m_items.IndexOf(obj);
		}

		private void OnItemSelected(object sender, EventArgs e)
		{
			if (CanHandleEvent(sender))
			{
				SelectedIndex = ((ItemContainer)sender).Index;
			}
		}

		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
			SelectedIndex = -1;
		}

		protected bool CanHandleEvent(object sender)
		{
			ItemContainer itemContainer = sender as ItemContainer;
			if (!itemContainer)
			{
				return false;
			}
			return itemContainer.transform.IsChildOf(Panel);
		}

		protected virtual void DataBind()
		{
			m_itemContainers = GetComponentsInChildren<ItemContainer>();
			if (m_items == null)
			{
				for (int i = 0; i < m_itemContainers.Length; i++)
				{
					UnityEngine.Object.Destroy(m_itemContainers[i].gameObject);
				}
				return;
			}
			int num = m_items.Count - m_itemContainers.Length;
			if (num > 0)
			{
				int j = m_itemContainers.Length;
				Array.Resize(ref m_itemContainers, m_itemContainers.Length + num);
				for (; j < m_itemContainers.Length; j++)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate(ItemContainerPrefab);
					gameObject.transform.SetParent(Panel, worldPositionStays: false);
					ItemContainer itemContainer = gameObject.GetComponent<ItemContainer>();
					if (itemContainer == null)
					{
						itemContainer = gameObject.AddComponent<ItemContainer>();
					}
					m_itemContainers[j] = itemContainer;
				}
			}
			else
			{
				int num2 = m_itemContainers.Length + num;
				for (int num3 = m_itemContainers.Length - 1; num3 >= num2; num3--)
				{
					UnityEngine.Object.Destroy(m_itemContainers[num3]);
				}
				Array.Resize(ref m_itemContainers, num2);
			}
			int count = m_items.Count;
			for (int k = 0; k < count; k++)
			{
				object item = m_items[k];
				ItemContainer itemContainer2 = m_itemContainers[k];
				if (itemContainer2 != null)
				{
					itemContainer2.Index = k;
					itemContainer2.Item = item;
					if (this.ItemDataBinding != null)
					{
						ItemDataBindingEventArgs e = new ItemDataBindingEventArgs(item, itemContainer2.gameObject);
						this.ItemDataBinding(this, e);
					}
				}
			}
		}
	}
	public class ListBox : ItemsControl
	{
	}
	public class ListBoxItem : ItemContainer
	{
		private Toggle m_toggle;

		public override bool IsSelected
		{
			get
			{
				return base.IsSelected;
			}
			set
			{
				if (base.IsSelected != value)
				{
					m_toggle.isOn = value;
					base.IsSelected = value;
				}
			}
		}

		private void Awake()
		{
			m_toggle = GetComponent<Toggle>();
			m_toggle.interactable = false;
			m_toggle.isOn = IsSelected;
		}
	}
}
namespace Battlehub.SplineEditor
{
	public static class CurveUtils
	{
		public static float GetT(this SplineBase spline, int curveIndex, Vector3 testPoint, float eps = 0.01f)
		{
			float num = 1f / (float)spline.CurveCount * (float)curveIndex;
			float tEnd = num + 1f / (float)spline.CurveCount;
			return spline.GetT(num, tEnd, testPoint, eps);
		}

		private static float GetT(this SplineBase spline, float tStart, float tEnd, Vector3 testPoint, float eps = 0.01f)
		{
			float num = eps * eps;
			Vector3 point = spline.GetPoint(tStart);
			Vector3 point2 = spline.GetPoint(tEnd);
			Vector3 vector = point - testPoint;
			Vector3 vector2 = point2 - testPoint;
			if (vector.sqrMagnitude < vector2.sqrMagnitude)
			{
				if ((point2 - point).sqrMagnitude <= num)
				{
					return tStart;
				}
				return spline.GetT(tStart, (tStart + tEnd) / 2f, testPoint, eps);
			}
			if ((point2 - point).sqrMagnitude <= num)
			{
				return tEnd;
			}
			return spline.GetT((tStart + tEnd) / 2f, tEnd, testPoint, eps);
		}

		public static float GetTAlongAxis(this SplineBase spline, Vector3 testPoint, Vector3 axis, float eps = 0.01f)
		{
			axis = axis.normalized;
			return spline.GetTAlongAxis(0f, 1f, 0f, 1f, testPoint, axis, eps);
		}

		public static float GetTAlongAxis(this SplineBase spline, int curveIndex, Vector3 testPoint, Vector3 axis, float eps = 0.01f)
		{
			float num = 1f / (float)spline.CurveCount * (float)curveIndex;
			float num2 = num + 1f / (float)spline.CurveCount;
			axis = axis.normalized;
			return spline.GetTAlongAxis(num, num2, num, num2, testPoint, axis, eps);
		}

		private static float GetTAlongAxis(this SplineBase spline, float tStart, float tEnd, float lastTStart, float lastTEnd, Vector3 testPoint, Vector3 axis, float eps = 0.01f)
		{
			float num = eps * eps;
			Vector3 point = spline.GetPoint(tStart);
			Vector3 point2 = spline.GetPoint(tEnd);
			Vector3 lhs = point - testPoint;
			Vector3 lhs2 = point2 - testPoint;
			float num2 = Vector3.Dot(lhs, axis);
			float num3 = Vector3.Dot(lhs2, axis);
			if (Mathf.Abs(num2 - num3) <= eps)
			{
				return tStart;
			}
			if (num3 < 0f)
			{
				return spline.GetTAlongAxis(tEnd, lastTEnd, tStart, tEnd, testPoint, axis, eps);
			}
			if (num2 > 0f)
			{
				return spline.GetTAlongAxis(lastTStart, tStart, tStart, tEnd, testPoint, axis, eps);
			}
			if (Mathf.Abs(num2) < Mathf.Abs(num3))
			{
				if ((point2 - point).sqrMagnitude <= num)
				{
					return tStart;
				}
				return spline.GetTAlongAxis(tStart, (tStart + tEnd) / 2f, tStart, tEnd, testPoint, axis, eps);
			}
			if ((point2 - point).sqrMagnitude <= num)
			{
				return tEnd;
			}
			return spline.GetTAlongAxis((tStart + tEnd) / 2f, tEnd, tStart, tEnd, testPoint, axis, eps);
		}

		public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			t = Mathf.Clamp01(t);
			float num = 1f - t;
			return num * num * num * p0 + 3f * num * num * t * p1 + 3f * num * t * t * p2 + t * t * t * p3;
		}

		public static Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			t = Mathf.Clamp01(t);
			float num = 1f - t;
			return 3f * num * num * (p1 - p0) + 6f * num * t * (p2 - p1) + 3f * t * t * (p3 - p2);
		}
	}
	[ExecuteInEditMode]
	public class Spline : SplineBase
	{
		private const float Mag = 5f;

		protected override void OnCurveChanged()
		{
		}

		protected override float GetMag()
		{
			return 5f;
		}

		private void AppendCurve(float mag, bool enforceNeighbour)
		{
			Vector3 vector = base.transform.InverseTransformDirection(GetDirection(1f));
			Vector3 point = GetPoint(1f);
			point = base.transform.InverseTransformPoint(point);
			int num = 3;
			float num2 = 1f / (float)num;
			float num3 = num2;
			Vector3[] array = new Vector3[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = point + vector * mag * num3;
				num3 += num2;
			}
			AppendCurve(array, enforceNeighbour);
		}

		private void PrependCurve(float mag, int curveIndex, bool enforceNeighbour)
		{
			Vector3 direction = GetDirection(0f, curveIndex);
			Vector3 point = GetPoint(0f, curveIndex);
			direction = base.transform.InverseTransformDirection(direction);
			point = base.transform.InverseTransformPoint(point);
			int num = 3;
			float num2 = 1f / (float)num;
			float num3 = 1f;
			Vector3[] array = new Vector3[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = point - direction * mag * num3;
				num3 -= num2;
			}
			PrependCurve(array, curveIndex, mag, enforceNeighbour);
		}

		public override void Load(SplineSnapshot snapshot)
		{
			LoadSpline(snapshot);
		}

		public void Extend(bool prepend = false)
		{
			if (prepend && !Loop)
			{
				PrependCurve(5f, 0, enforceNeighbour: false);
			}
			else
			{
				AppendCurve(5f, enforceNeighbour: false);
			}
		}

		public bool Remove(int curveIndex)
		{
			return RemoveCurve(curveIndex);
		}
	}
	public enum ControlPointMode
	{
		Free,
		Aligned,
		Mirrored
	}
	[Serializable]
	public struct Vector3Serialziable
	{
		public float X;

		public float Y;

		public float Z;

		public Vector3Serialziable(float x, float y, float z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public static implicit operator Vector3(Vector3Serialziable v)
		{
			return new Vector3(v.X, v.Y, v.Z);
		}

		public static implicit operator Vector3Serialziable(Vector3 v)
		{
			return new Vector3Serialziable(v.x, v.y, v.z);
		}
	}
	[Serializable]
	public class Vector3SerialziableArray : List<Vector3Serialziable>
	{
		public static implicit operator Vector3[](Vector3SerialziableArray v)
		{
			Vector3[] array = new Vector3[v.Count];
			for (int i = 0; i < v.Count; i++)
			{
				array[i] = v[i];
			}
			return array;
		}

		public static implicit operator Vector3SerialziableArray(Vector3[] v)
		{
			Vector3SerialziableArray vector3SerialziableArray = new Vector3SerialziableArray();
			for (int i = 0; i < v.Length; i++)
			{
				vector3SerialziableArray.Add(v[i]);
			}
			return vector3SerialziableArray;
		}
	}
	[Serializable]
	public struct SplineSnapshot
	{
		[SerializeField]
		private Vector3SerialziableArray m_points;

		[SerializeField]
		private ControlPointSetting[] m_controlPointSettings;

		[SerializeField]
		private ControlPointMode[] m_modes;

		[SerializeField]
		private bool m_loop;

		public int CurveCount => (m_points.Count - 1) / 3;

		public Vector3SerialziableArray Points => m_points;

		public ControlPointSetting[] ControlPointSettings => m_controlPointSettings;

		public ControlPointMode[] Modes => m_modes;

		public bool Loop => m_loop;

		public SplineSnapshot(Vector3[] points, ControlPointSetting[] settings, ControlPointMode[] modes, bool loop)
		{
			int num = (points.Length - 1) / 3;
			int num2 = (points.Length - 1) / 2;
			int num3 = num * 3 + 1;
			num++;
			if (num < 1)
			{
				throw new ArgumentException("too few points. at least 4 required");
			}
			m_points = points;
			if (num3 != m_points.Count)
			{
				Array.Resize(ref points, num3);
			}
			m_controlPointSettings = settings;
			if (num2 != m_controlPointSettings.Length)
			{
				Array.Resize(ref settings, num2);
			}
			m_modes = modes;
			if (num != m_modes.Length)
			{
				Array.Resize(ref m_modes, num);
			}
			m_loop = loop;
		}
	}
	public delegate void ControlPointChanged(int pointIndex);
	[Serializable]
	public struct Twist
	{
		public static readonly Twist Null;

		public float Data;

		public float T1;

		public float T2;

		public Twist(float data, float t1, float t2)
		{
			Data = data;
			T1 = t1;
			T2 = t2;
		}
	}
	[Serializable]
	public struct Thickness
	{
		public static readonly Thickness Null;

		public Vector3Serialziable Data;

		public float T1;

		public float T2;

		public Thickness(Vector3 data, float t1, float t2)
		{
			Data = data;
			T1 = t1;
			T2 = t2;
		}
	}
	[Serializable]
	public struct ControlPointSetting
	{
		public Twist Twist;

		public Thickness Thickness;

		public ControlPointSetting(Twist twist, Thickness thickness)
		{
			Twist = twist;
			Thickness = thickness;
		}
	}
	[ExecuteInEditMode]
	public class SplineBase : MonoBehaviour, IGL
	{
		[SerializeField]
		[HideInInspector]
		private ControlPointMode[] m_modes;

		[SerializeField]
		[HideInInspector]
		private Vector3[] m_points;

		[SerializeField]
		[HideInInspector]
		private ControlPointSetting[] m_settings;

		[SerializeField]
		[HideInInspector]
		protected bool m_loop;

		[SerializeField]
		[HideInInspector]
		private bool m_isSelected;

		public bool IsSelected => m_isSelected;

		public virtual bool Loop
		{
			get
			{
				return m_loop;
			}
			set
			{
				m_loop = value;
				if (value)
				{
					m_settings[0] = m_settings[m_settings.Length - 1];
					m_modes[m_modes.Length - 1] = m_modes[0];
					RaiseControlPointModeChanged(m_modes.Length - 1);
					SetControlPointLocal(m_points.Length - 1, m_points[0]);
				}
			}
		}

		public int CurveCount => (m_points.Length - 1) / 3;

		public int ControlPointCount => m_points.Length;

		public event ControlPointChanged ControlPointPositionChanged;

		public event ControlPointChanged ControlPointModeChanged;

		private void RaiseControlPointChanged(int index)
		{
			if (this.ControlPointPositionChanged != null)
			{
				this.ControlPointPositionChanged(index);
			}
		}

		private void RaiseControlPointModeChanged(int modeIndex)
		{
			if (this.ControlPointModeChanged != null)
			{
				int num = modeIndex * 3 - 1;
				this.ControlPointModeChanged(num);
				this.ControlPointModeChanged(num + 1);
				this.ControlPointModeChanged(num + 2);
			}
		}

		private void Awake()
		{
			SplineRuntimeEditor.Created += OnRuntimeEditorCreated;
			SplineRuntimeEditor.Destroyed += OnRuntimeEditorDestroyed;
			SyncArrays();
			AwakeOverride();
		}

		private void OnDestroy()
		{
			SplineRuntimeEditor.Created -= OnRuntimeEditorCreated;
			SplineRuntimeEditor.Destroyed -= OnRuntimeEditorDestroyed;
			OnDestroyOverride();
			if (SplineRuntimeEditor.Instance != null && SplineRuntimeEditor.Instance.SelectedSpline == this)
			{
				SplineRuntimeEditor.Instance.SelectedSpline = null;
			}
		}

		private void Start()
		{
			StartOverride();
			if (m_isSelected)
			{
				Unselect();
			}
		}

		private void OnRuntimeEditorCreated(object sender, EventArgs e)
		{
			if (m_isSelected && GLRenderer.Instance != null)
			{
				GLRenderer.Instance.Add(this);
			}
		}

		private void OnRuntimeEditorDestroyed(object sender, EventArgs e)
		{
			if (GLRenderer.Instance != null)
			{
				GLRenderer.Instance.Remove(this);
			}
		}

		private void OnEnable()
		{
			if (m_isSelected && GLRenderer.Instance != null)
			{
				GLRenderer.Instance.Add(this);
			}
			OnEnableOverride();
		}

		private void OnDisable()
		{
			if (GLRenderer.Instance != null)
			{
				GLRenderer.Instance.Remove(this);
			}
			OnDisableOverride();
		}

		protected virtual void OnEnableOverride()
		{
		}

		protected virtual void OnDisableOverride()
		{
		}

		protected virtual void AwakeOverride()
		{
		}

		protected virtual void StartOverride()
		{
		}

		protected virtual void OnDestroyOverride()
		{
		}

		private void SyncArrays()
		{
			if (m_points == null || m_points.Length == 0)
			{
				return;
			}
			int num = m_points.Length / 3 + 1;
			if (m_modes.Length != num)
			{
				UnityEngine.Debug.Log("Synchronize modes");
				Array.Resize(ref m_modes, num);
			}
			if (m_settings == null)
			{
				m_settings = new ControlPointSetting[0];
			}
			if (m_settings.Length != num)
			{
				UnityEngine.Debug.Log("Synchronize settings");
				int num2 = m_settings.Length;
				Array.Resize(ref m_settings, num);
				for (int i = num2; i < m_settings.Length; i++)
				{
					m_settings[i].Thickness = new Thickness(Vector3.one, 0f, 1f);
					m_settings[i].Twist = new Twist(0f, 0f, 1f);
				}
			}
		}

		public void Select()
		{
			if (GLRenderer.Instance != null)
			{
				GLRenderer.Instance.Add(this);
			}
			SplineControlPoint[] controlPoints = GetControlPoints();
			for (int i = 0; i < controlPoints.Length; i++)
			{
				controlPoints[i].gameObject.SetActive(value: true);
			}
			m_isSelected = true;
			if (SplineRuntimeEditor.Instance != null && SplineRuntimeEditor.Instance.SelectedSpline != this)
			{
				SplineRuntimeEditor.Instance.SelectedSpline = this;
			}
		}

		public void Unselect()
		{
			if (GLRenderer.Instance != null)
			{
				GLRenderer.Instance.Remove(this);
			}
			SplineControlPoint[] controlPoints = GetControlPoints();
			foreach (SplineControlPoint splineControlPoint in controlPoints)
			{
				if ((bool)splineControlPoint)
				{
					splineControlPoint.gameObject.SetActive(value: false);
				}
			}
			m_isSelected = false;
			if (SplineRuntimeEditor.Instance != null && SplineRuntimeEditor.Instance.SelectedSpline == this)
			{
				SplineRuntimeEditor.Instance.SelectedSpline = null;
			}
		}

		public float EvalLength(int curveIndex)
		{
			Vector3 point = GetPoint(0f, curveIndex);
			return (GetPoint(1f, curveIndex) - point).magnitude;
		}

		public float EvalCurveLength(int curveIndex, int steps)
		{
			float num = 0f;
			Vector3 vector = GetPoint(0f, curveIndex);
			for (int i = 1; i < 4; i++)
			{
				float num2 = i;
				num2 /= 3f;
				Vector3 point = GetPoint(num2, curveIndex);
				num += (point - vector).magnitude;
				vector = point;
			}
			return num;
		}

		public Vector3 GetPoint(float t, int curveIndex)
		{
			curveIndex *= 3;
			return base.transform.TransformPoint(CurveUtils.GetPoint(m_points[curveIndex], m_points[curveIndex + 1], m_points[curveIndex + 2], m_points[curveIndex + 3], t));
		}

		public Vector3 GetPointLocal(float t, int curveIndex)
		{
			curveIndex *= 3;
			return CurveUtils.GetPoint(m_points[curveIndex], m_points[curveIndex + 1], m_points[curveIndex + 2], m_points[curveIndex + 3], t);
		}

		public Vector3 GetPoint(float t)
		{
			int num;
			if (t >= 1f)
			{
				t = 1f;
				num = (m_points.Length - 1) / 3 - 1;
			}
			else
			{
				t = Mathf.Clamp01(t) * (float)CurveCount;
				num = (int)t;
				t -= (float)num;
			}
			return GetPoint(t, num);
		}

		public Vector3 GetPointLocal(float t)
		{
			int num;
			if (t >= 1f)
			{
				t = 1f;
				num = (m_points.Length - 1) / 3 - 1;
			}
			else
			{
				t = Mathf.Clamp01(t) * (float)CurveCount;
				num = (int)t;
				t -= (float)num;
			}
			return GetPointLocal(t, num);
		}

		public float GetTwist(float t, int curveIndex)
		{
			Twist twist = m_settings[curveIndex].Twist;
			Twist twist2 = m_settings[curveIndex + 1].Twist;
			float num = Mathf.Clamp01(twist.T1);
			float num2 = Mathf.Clamp01(twist.T2);
			t = ((t <= num) ? 0f : ((!(t >= num2)) ? Mathf.Clamp01((t - num) / (num2 - num)) : 1f));
			return Mathf.Lerp(twist.Data, twist2.Data, t);
		}

		public float GetTwist(float t)
		{
			int num;
			if (t >= 1f)
			{
				t = 1f;
				num = (m_points.Length - 1) / 3 - 1;
			}
			else
			{
				t = Mathf.Clamp01(t) * (float)CurveCount;
				num = (int)t;
				t -= (float)num;
			}
			return GetTwist(t, num);
		}

		public Vector3 GetThickness(float t, int curveIndex)
		{
			Thickness thickness = m_settings[curveIndex].Thickness;
			Thickness thickness2 = m_settings[curveIndex + 1].Thickness;
			float num = Mathf.Clamp01(thickness.T1);
			float num2 = Mathf.Clamp01(thickness.T2);
			t = ((t <= num) ? 0f : ((!(t >= num2)) ? Mathf.Clamp01((t - num) / (num2 - num)) : 1f));
			return Vector3.Lerp(thickness.Data, thickness2.Data, t);
		}

		public Vector3 GetThickness(float t)
		{
			int num;
			if (t >= 1f)
			{
				t = 1f;
				num = (m_points.Length - 1) / 3 - 1;
			}
			else
			{
				t = Mathf.Clamp01(t) * (float)CurveCount;
				num = (int)t;
				t -= (float)num;
			}
			return GetThickness(t, num);
		}

		public Vector3 GetControlPoint(int index)
		{
			return base.transform.TransformPoint(m_points[index]);
		}

		public Vector3 GetControlPointLocal(int index)
		{
			return m_points[index];
		}

		public ControlPointSetting GetSetting(int index)
		{
			return m_settings[(index + 1) / 3];
		}

		public Twist GetTwist(int index)
		{
			return m_settings[(index + 1) / 3].Twist;
		}

		public Thickness GetThickness(int index)
		{
			return m_settings[(index + 1) / 3].Thickness;
		}

		public void SetTwist(int index, Twist twist)
		{
			int num = (index + 1) / 3;
			m_settings[num].Twist = twist;
			if (m_loop)
			{
				if (num == m_settings.Length - 1)
				{
					m_settings[0] = m_settings[m_settings.Length - 1];
				}
				else if (num == 0)
				{
					m_settings[m_settings.Length - 1] = m_settings[0];
				}
			}
			OnCurveChanged(index, Math.Max(0, (index - 1) / 3));
		}

		public void SetThickness(int index, Thickness thickness)
		{
			int num = (index + 1) / 3;
			m_settings[num].Thickness = thickness;
			if (m_loop)
			{
				if (num == m_settings.Length - 1)
				{
					m_settings[0] = m_settings[m_settings.Length - 1];
				}
				else if (num == 0)
				{
					m_settings[m_settings.Length - 1] = m_settings[0];
				}
			}
			OnCurveChanged(index, Math.Max(0, (index - 1) / 3));
		}

		protected void SetPoints(int curveIndex, Vector3[] points, ControlPointMode mode, bool raiseCurveChanged)
		{
			int num = curveIndex * 3;
			for (int i = 0; i < points.Length; i++)
			{
				m_points[num] = points[i];
				RaiseControlPointChanged(num);
				SetControlPointMode(num, mode, raiseCurveChanged);
				num++;
			}
			EnforceMode(num);
			if (raiseCurveChanged)
			{
				OnCurveChanged(num, Math.Max(0, (num - 1) / 3));
			}
		}

		public void SetControlPoint(int index, Vector3 point)
		{
			SetControlPointLocal(index, base.transform.InverseTransformPoint(point));
		}

		public void SetControlPointLocal(int index, Vector3 point)
		{
			if (index % 3 == 0)
			{
				Vector3 vector = point - m_points[index];
				if (m_loop)
				{
					if (index == 0)
					{
						m_points[1] += vector;
						RaiseControlPointChanged(1);
						m_points[m_points.Length - 2] += vector;
						RaiseControlPointChanged(m_points.Length - 2);
						m_points[m_points.Length - 1] = point;
						RaiseControlPointChanged(m_points.Length - 1);
					}
					else if (index == m_points.Length - 1)
					{
						m_points[0] = point;
						RaiseControlPointChanged(0);
						m_points[1] += vector;
						RaiseControlPointChanged(1);
						m_points[index - 1] += vector;
						RaiseControlPointChanged(index - 1);
					}
					else
					{
						m_points[index - 1] += vector;
						RaiseControlPointChanged(index - 1);
						m_points[index + 1] += vector;
						RaiseControlPointChanged(index + 1);
					}
				}
				else
				{
					if (index > 0)
					{
						m_points[index - 1] += vector;
						RaiseControlPointChanged(index - 1);
					}
					if (index + 1 < m_points.Length)
					{
						m_points[index + 1] += vector;
						RaiseControlPointChanged(index + 1);
					}
				}
			}
			m_points[index] = point;
			RaiseControlPointChanged(index);
			EnforceMode(index);
			OnCurveChanged(index, Math.Max(0, (index - 1) / 3));
		}

		public ControlPointMode GetControlPointMode(int index)
		{
			return m_modes[(index + 1) / 3];
		}

		public void SetControlPointMode(ControlPointMode mode)
		{
			for (int i = 0; i <= CurveCount; i++)
			{
				SetControlPointMode(i * 3, mode);
			}
		}

		public void SetControlPointMode(int index, ControlPointMode mode, bool raiseCurveChanged = true)
		{
			int num = (index + 1) / 3;
			m_modes[num] = mode;
			RaiseControlPointModeChanged(num);
			if (m_loop)
			{
				if (num == 0)
				{
					m_modes[m_modes.Length - 1] = mode;
					RaiseControlPointModeChanged(m_modes.Length - 1);
				}
				else if (num == m_modes.Length - 1)
				{
					m_modes[0] = mode;
					RaiseControlPointModeChanged(0);
				}
			}
			EnforceMode(index);
			if (raiseCurveChanged)
			{
				OnCurveChanged(index, Math.Max(0, (index - 1) / 3));
			}
		}

		private void EnforceMode(int index)
		{
			int num = (index + 1) / 3;
			ControlPointMode controlPointMode = m_modes[num];
			if (controlPointMode == ControlPointMode.Free || (!m_loop && (num == 0 || num == m_modes.Length - 1)))
			{
				return;
			}
			int num2 = num * 3;
			int num3;
			int num4;
			if (index <= num2)
			{
				num3 = num2 - 1;
				if (num3 < 0)
				{
					num3 = m_points.Length - 2;
				}
				num4 = num2 + 1;
				if (num4 >= m_points.Length)
				{
					num4 = 1;
				}
			}
			else
			{
				num3 = num2 + 1;
				if (num3 >= m_points.Length)
				{
					num3 = 1;
				}
				num4 = num2 - 1;
				if (num4 < 0)
				{
					num4 = m_points.Length - 2;
				}
			}
			Vector3 vector = m_points[num2];
			Vector3 vector2 = vector - m_points[num3];
			if (controlPointMode == ControlPointMode.Aligned)
			{
				vector2 = vector2.normalized * Vector3.Distance(vector, m_points[num4]);
			}
			m_points[num4] = vector + vector2;
			RaiseControlPointChanged(num4);
		}

		public Vector3 GetVelocity(float t, int curveIndex)
		{
			curveIndex *= 3;
			return base.transform.TransformPoint(CurveUtils.GetFirstDerivative(m_points[curveIndex], m_points[curveIndex + 1], m_points[curveIndex + 2], m_points[curveIndex + 3], t)) - base.transform.position;
		}

		public Vector3 GetVelocity(float t)
		{
			int num;
			if (t >= 1f)
			{
				t = 1f;
				num = (m_points.Length - 1) / 3 - 1;
			}
			else
			{
				t = Mathf.Clamp01(t) * (float)CurveCount;
				num = (int)t;
				t -= (float)num;
			}
			return GetVelocity(t, num);
		}

		public Vector3 GetDirection(float t, int curveIndex)
		{
			return GetVelocity(t, curveIndex).normalized;
		}

		public Vector3 GetDirection(float t)
		{
			return GetVelocity(t).normalized;
		}

		public void Smooth()
		{
			int num = m_points.Length / 3;
			float[] array = new float[num];
			float[] array2 = new float[num];
			float[] array3 = new float[num];
			Vector3[] array4 = new Vector3[num];
			array[0] = 0f;
			array2[0] = 2f;
			array3[0] = 1f;
			array4[0] = m_points[0] + 2f * m_points[3];
			for (int i = 1; i < num - 1; i++)
			{
				array[i] = 1f;
				array2[i] = 4f;
				array3[i] = 1f;
				array4[i] = 4f * m_points[i * 3] + 2f * m_points[(i + 1) * 3];
			}
			array[num - 1] = 2f;
			array2[num - 1] = 7f;
			array3[num - 1] = 0f;
			array4[num - 1] = 8f * m_points[(num - 1) * 3] + m_points[num * 3];
			for (int j = 1; j < num; j++)
			{
				float num2 = array[j] / array2[j - 1];
				array2[j] -= num2 * array3[j - 1];
				array4[j] -= num2 * array4[j - 1];
			}
			m_points[(num - 1) * 3 + 1] = array4[num - 1] / array2[num - 1];
			for (int num3 = num - 2; num3 >= 0; num3--)
			{
				m_points[num3 * 3 + 1] = (array4[num3] - array3[num3] * m_points[(num3 + 1) * 3 + 1]) / array2[num3];
			}
			for (int k = 0; k < num - 1; k++)
			{
				m_points[k * 3 + 2] = 2f * m_points[(k + 1) * 3] - m_points[(k + 1) * 3 + 1];
			}
			m_points[(num - 1) * 3 + 2] = 0.5f * (m_points[num * 3] + m_points[(num - 1) * 3 + 1]);
			if (Loop)
			{
				EnforceMode(m_points.Length - 2);
			}
			SyncCtrlPoints();
			OnCurveChanged();
		}

		protected void LoadSpline(SplineSnapshot settings)
		{
			m_points = settings.Points;
			m_settings = settings.ControlPointSettings;
			m_modes = settings.Modes;
			m_loop = settings.Loop;
			SyncCtrlPoints();
		}

		public virtual SplineSnapshot Save()
		{
			return new SplineSnapshot(m_points, m_settings, m_modes, m_loop);
		}

		public virtual void Load(SplineSnapshot snapshot)
		{
			LoadSpline(snapshot);
		}

		protected void AlignCurve(int curveIndex, float length, bool toLast = true)
		{
			int num = curveIndex * 3;
			int num2 = num + 3;
			Vector3 vector = m_points[num2];
			Vector3 vector2 = m_points[num];
			Vector3 vector3 = ((!toLast) ? base.transform.InverseTransformDirection(GetDirection(0f, curveIndex)) : base.transform.InverseTransformDirection(GetDirection(1f, curveIndex)));
			if (toLast)
			{
				for (int num3 = num2 - 1; num3 >= num; num3--)
				{
					vector -= vector3 * length / 3f;
					m_points[num3] = vector;
					RaiseControlPointChanged(num3);
				}
				Vector3 vector4 = vector2 - m_points[num];
				for (int num4 = num - 1; num4 >= 0; num4--)
				{
					m_points[num4] -= vector4;
					RaiseControlPointChanged(num4);
				}
			}
			else
			{
				for (int i = num + 1; i <= num2; i++)
				{
					vector2 += vector3 * length / 3f;
					m_points[i] = vector2;
					RaiseControlPointChanged(i);
				}
				Vector3 vector5 = vector - m_points[num2];
				for (int j = num2 + 1; j < m_points.Length; j++)
				{
					m_points[j] -= vector5;
					RaiseControlPointChanged(j);
				}
			}
			EnforceMode(num - 1);
			EnforceMode(num2 + 1);
		}

		protected bool RemoveCurve(int curveIndex)
		{
			if (m_points.Length <= 4)
			{
				return false;
			}
			if (curveIndex >= CurveCount || curveIndex < 0)
			{
				throw new ArgumentOutOfRangeException("curveIndex");
			}
			int num = curveIndex * 3;
			bool flag = true;
			if (curveIndex == CurveCount - 1)
			{
				flag = false;
				num++;
			}
			for (int i = num; i < m_points.Length - 3; i++)
			{
				m_points[i] = m_points[i + 3];
			}
			for (int j = (num + 1) / 3; j < m_modes.Length - 1; j++)
			{
				m_settings[j] = m_settings[j + 1];
				m_modes[j] = m_modes[j + 1];
				RaiseControlPointModeChanged(j);
			}
			Array.Resize(ref m_points, m_points.Length - 3);
			Array.Resize(ref m_settings, m_settings.Length - 1);
			Array.Resize(ref m_modes, m_modes.Length - 1);
			if (flag)
			{
				EnforceMode(num + 1);
			}
			if (m_loop)
			{
				m_points[m_points.Length - 1] = m_points[0];
				m_settings[0] = m_settings[m_settings.Length - 1];
				m_modes[m_modes.Length - 1] = m_modes[0];
				RaiseControlPointModeChanged(m_modes.Length - 1);
				EnforceMode(1);
			}
			SyncCtrlPoints();
			return true;
		}

		protected void Subdivide(int firstCurveIndex, int lastCurveIndex, int curveCount)
		{
			int num = firstCurveIndex * 3;
			int num2 = lastCurveIndex * 3 + 3;
			int num3 = m_points.Length;
			int num4 = num2 - num - 1;
			int num5 = curveCount * 3 - 1;
			int num6 = num5 - num4;
			Vector3[] array = new Vector3[num5];
			Vector3 a = m_points[num];
			Vector3 b = m_points[num2];
			ControlPointSetting controlPointSetting = m_settings[(num + 1) / 3];
			ControlPointMode controlPointMode = m_modes[(num + 1) / 3];
			float num7 = 1f / (float)(num5 + 1);
			float num8 = 0f;
			for (int i = 0; i < num5; i++)
			{
				num8 += num7;
				array[i] = Vector3.Lerp(a, b, num8);
			}
			if (num6 > 0)
			{
				Array.Resize(ref m_points, m_points.Length + num6);
				Array.Resize(ref m_settings, m_settings.Length + num6 / 3);
				Array.Resize(ref m_modes, m_modes.Length + num6 / 3);
				for (int num9 = num3 - 1; num9 >= num2; num9--)
				{
					m_points[num9 + num6] = m_points[num9];
				}
				for (int num10 = num3 / 3; num10 >= (num2 + 1) / 3; num10--)
				{
					m_settings[num10 + num6 / 3] = m_settings[num10];
					m_modes[num10 + num6 / 3] = m_modes[num10];
					RaiseControlPointModeChanged(num10 + num6 / 3);
				}
			}
			else if (num6 < 0)
			{
				for (int j = num2; j < num3; j++)
				{
					m_points[j + num6] = m_points[j];
				}
				for (int k = (num2 + 1) / 3; k < (num3 + 1) / 3; k++)
				{
					m_settings[k + num6 / 3] = m_settings[k];
					m_modes[k + num6 / 3] = m_modes[k];
					RaiseControlPointModeChanged(k + num6 / 3);
				}
				Array.Resize(ref m_points, m_points.Length + num6);
				Array.Resize(ref m_settings, m_settings.Length + num6 / 3);
				Array.Resize(ref m_modes, m_modes.Length + num6 / 3);
			}
			for (int l = 0; l < num5; l++)
			{
				m_points[num + l + 1] = array[l];
			}
			for (int m = 0; m < num5 / 3; m++)
			{
				m_settings[(num + 1) / 3 + m + 1] = controlPointSetting;
				m_modes[(num + 1) / 3 + m + 1] = controlPointMode;
				RaiseControlPointModeChanged((num + 1) / 3 + m + 1);
			}
			int num11 = num - 1;
			int num12 = num + num5 + 2;
			if (m_loop)
			{
				if (num11 == -1)
				{
					num11 = m_points.Length - 1;
				}
				if (num12 == m_points.Length)
				{
					num12 = 0;
				}
			}
			if (num12 < m_points.Length)
			{
				EnforceMode(num12);
			}
			if (num11 >= 0)
			{
				EnforceMode(num11);
			}
			SyncCtrlPoints();
		}

		private void InsertCurve(Vector3[] points, ControlPointSetting setting, ControlPointMode mode, int curveIndex, float length, bool enforceNeighbour)
		{
			Array.Resize(ref m_points, m_points.Length + points.Length);
			Array.Resize(ref m_settings, m_settings.Length + points.Length / 3);
			Array.Resize(ref m_modes, m_modes.Length + points.Length / 3);
			int num = curveIndex * 3;
			int num2 = (num + 1) / 3;
			for (int num3 = m_points.Length - 1; num3 >= num + points.Length; num3--)
			{
				m_points[num3] = m_points[num3 - points.Length];
			}
			for (int num4 = m_modes.Length - 1; num4 >= num2 + points.Length / 3; num4--)
			{
				m_settings[num4] = m_settings[num4 - points.Length / 3];
				m_modes[num4] = m_modes[num4 - points.Length / 3];
				RaiseControlPointModeChanged(num4);
			}
			for (int i = num; i < num + points.Length; i++)
			{
				m_points[i] = points[i - num];
			}
			for (int j = num2; j < num2 + points.Length / 3; j++)
			{
				m_settings[j] = setting;
				m_modes[j] = mode;
				RaiseControlPointModeChanged(j);
			}
			Vector3 vector = base.transform.InverseTransformDirection(GetDirection(0f, curveIndex));
			for (int num5 = num - 1; num5 >= 0; num5--)
			{
				m_points[num5] -= vector * length;
			}
			if (enforceNeighbour)
			{
				EnforceMode(num + points.Length + 1);
			}
			else
			{
				EnforceMode(num + points.Length - 1);
			}
			if (m_loop)
			{
				m_points[m_points.Length - 1] = m_points[0];
				m_settings[0] = m_settings[m_settings.Length - 1];
				m_modes[m_modes.Length - 1] = m_modes[0];
				RaiseControlPointModeChanged(m_modes.Length - 1);
				EnforceMode(1);
			}
			SyncCtrlPoints();
		}

		protected void PrependCurve(Vector3[] points, int curveIndex, float length, bool enforceNeighbour)
		{
			InsertCurve(points, GetSetting(curveIndex * 3), GetControlPointMode(curveIndex * 3), curveIndex, length, enforceNeighbour);
		}

		protected void AppendCurve(Vector3[] points, bool enforceNeighbour)
		{
			AppendCurve(points, GetSetting(m_points.Length - 1), GetControlPointMode(m_points.Length - 1), enforceNeighbour);
		}

		protected void AppendCurve(Vector3[] points, ControlPointSetting setting, ControlPointMode mode, bool enforceNeighbour)
		{
			Array.Resize(ref m_points, m_points.Length + points.Length);
			Array.Resize(ref m_settings, m_settings.Length + points.Length / 3);
			Array.Resize(ref m_modes, m_modes.Length + points.Length / 3);
			for (int i = 0; i < points.Length; i++)
			{
				m_points[m_points.Length - points.Length + i] = points[i];
			}
			for (int j = 0; j < points.Length / 3; j++)
			{
				m_settings[m_settings.Length - points.Length / 3 + j] = setting;
				m_modes[m_modes.Length - points.Length / 3 + j] = mode;
				RaiseControlPointModeChanged(m_modes.Length - points.Length / 3 + j);
			}
			if (enforceNeighbour)
			{
				EnforceMode(m_points.Length - points.Length - 2);
			}
			else
			{
				EnforceMode(m_points.Length - points.Length);
			}
			if (m_loop)
			{
				m_points[0] = m_points[m_points.Length - 1];
				m_settings[0] = m_settings[m_settings.Length - 1];
				m_modes[0] = m_modes[m_modes.Length - 1];
				RaiseControlPointModeChanged(0);
				EnforceMode(m_points.Length - 1);
			}
			SyncCtrlPoints();
		}

		protected virtual float GetMag()
		{
			return 1f;
		}

		private void Reset()
		{
			m_points = new Vector3[4]
			{
				new Vector3(0f, 0f, 0f),
				new Vector3(1f / 3f * GetMag(), 0f, 0f),
				new Vector3(2f / 3f * GetMag(), 0f, 0f),
				new Vector3(1f * GetMag(), 0f, 0f)
			};
			m_settings = new ControlPointSetting[2]
			{
				new ControlPointSetting(new Twist(0f, 0f, 1f), new Thickness(Vector3.one, 0f, 1f)),
				new ControlPointSetting(new Twist(0f, 0f, 1f), new Thickness(Vector3.one, 0f, 1f))
			};
			m_modes = new ControlPointMode[2];
			ResetOverride();
			SyncCtrlPoints();
		}

		protected virtual void ResetOverride()
		{
		}

		protected virtual void OnCurveChanged(int pointIndex, int curveIndex)
		{
		}

		protected virtual void OnCurveChanged()
		{
		}

		protected virtual SplineControlPoint[] GetControlPoints()
		{
			return GetComponentsInChildren<SplineControlPoint>(includeInactive: true);
		}

		protected virtual void AddControlPointComponent(GameObject ctrlPoint)
		{
			ctrlPoint.AddComponent<SplineControlPoint>();
		}

		private void SyncCtrlPoints(bool silent = false)
		{
			SplineRuntimeEditor instance = SplineRuntimeEditor.Instance;
			SplineControlPoint[] array = GetControlPoints();
			int num = ControlPointCount - array.Length;
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					GameObject gameObject = new GameObject();
					gameObject.SetActive(m_isSelected);
					gameObject.transform.parent = base.transform;
					gameObject.transform.rotation = Quaternion.identity;
					gameObject.transform.localScale = Vector3.one;
					if (instance != null)
					{
						MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
						gameObject.AddComponent<MeshFilter>().sharedMesh = instance.ControlPointMesh;
						meshRenderer.sharedMaterial = instance.NormalMaterial;
						meshRenderer.enabled = true;
					}
					gameObject.name = "ctrl point";
					AddControlPointComponent(gameObject);
				}
				array = GetControlPoints();
			}
			else if (num < 0)
			{
				num = -num;
				for (int j = 0; j < num; j++)
				{
					SplineControlPoint splineControlPoint = array[j];
					if (splineControlPoint.gameObject != null)
					{
						UnityEngine.Object.DestroyImmediate(splineControlPoint.gameObject);
					}
				}
				array = GetComponentsInChildren<SplineControlPoint>(includeInactive: true);
			}
			for (int k = 0; k < ControlPointCount; k++)
			{
				array[k].Index = k;
				RaiseControlPointChanged(k);
				RaiseControlPointModeChanged(k);
			}
		}

		public void Draw()
		{
			if (m_points.Length < 2)
			{
				return;
			}
			SplineRuntimeEditor instance = SplineRuntimeEditor.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SplineMaterial.SetPass(0);
			GL.PushMatrix();
			GL.MultMatrix(base.transform.localToWorldMatrix);
			GL.Begin(1);
			Vector3 v = m_points[0];
			for (int i = 1; i < m_points.Length; i += 3)
			{
				Vector3 v2 = m_points[i];
				Vector3 v3 = m_points[i + 1];
				Vector3 vector = m_points[i + 2];
				GL.Color(SplineRuntimeEditor.ControlPointLineColor);
				GL.Vertex(v);
				GL.Vertex(v2);
				GL.Color(SplineRuntimeEditor.ControlPointLineColor);
				GL.Vertex(v3);
				GL.Vertex(vector);
				v = vector;
			}
			GL.End();
			GL.Begin(1);
			GL.Color(SplineRuntimeEditor.SplineColor);
			v = m_points[0];
			for (int j = 1; j < m_points.Length; j += 3)
			{
				Vector3 vector2 = m_points[j];
				Vector3 vector3 = m_points[j + 1];
				Vector3 vector4 = m_points[j + 2];
				float num = (v - vector2).magnitude + (vector2 - vector3).magnitude + (vector3 - vector4).magnitude;
				int num2 = Mathf.CeilToInt(instance.Smoothness * num);
				if (num2 <= 0)
				{
					num2 = 1;
				}
				for (int k = 0; k < num2; k++)
				{
					float t = (float)k / (float)num2;
					GL.Vertex(CurveUtils.GetPoint(v, vector2, vector3, vector4, t));
					t = ((float)k + 1f) / (float)num2;
					GL.Vertex(CurveUtils.GetPoint(v, vector2, vector3, vector4, t));
				}
				v = vector4;
			}
			GL.End();
			GL.PopMatrix();
		}
	}
	[ExecuteInEditMode]
	public class SplineControlPoint : MonoBehaviour
	{
		private MeshRenderer m_renderer;

		private Vector3 m_localPosition;

		[SerializeField]
		[HideInInspector]
		private int m_index;

		private SplineBase m_spline;

		public int Index
		{
			get
			{
				return m_index;
			}
			set
			{
				m_index = value;
				UpdateMaterial();
			}
		}

		public SplineBase Spline => m_spline;

		private void UpdateMaterial()
		{
			if (!(m_renderer != null))
			{
				return;
			}
			SplineRuntimeEditor instance = SplineRuntimeEditor.Instance;
			if (!(instance != null))
			{
				return;
			}
			if (m_index % 3 == 0)
			{
				m_renderer.sharedMaterial = instance.NormalMaterial;
			}
			else if (m_index < m_spline.ControlPointCount)
			{
				switch (m_spline.GetControlPointMode(m_index))
				{
				case ControlPointMode.Mirrored:
					m_renderer.sharedMaterial = instance.MirroredModeMaterial;
					break;
				case ControlPointMode.Aligned:
					m_renderer.sharedMaterial = instance.AlignedModeMaterial;
					break;
				default:
					m_renderer.sharedMaterial = instance.FreeModeMaterial;
					break;
				}
			}
		}

		private void CreateRuntimeComponents()
		{
			SplineRuntimeEditor instance = SplineRuntimeEditor.Instance;
			if (instance != null)
			{
				m_renderer = GetComponent<MeshRenderer>();
				if (!m_renderer)
				{
					m_renderer = base.gameObject.AddComponent<MeshRenderer>();
					base.gameObject.AddComponent<MeshFilter>().sharedMesh = instance.ControlPointMesh;
					UpdateMaterial();
				}
			}
		}

		private void DestroyRuntimeComponents()
		{
			if (SplineRuntimeEditor.Instance != null)
			{
				MeshRenderer component = GetComponent<MeshRenderer>();
				if ((bool)component)
				{
					UnityEngine.Object.DestroyImmediate(component);
				}
				MeshFilter component2 = GetComponent<MeshFilter>();
				if ((bool)component2)
				{
					UnityEngine.Object.DestroyImmediate(component2);
				}
			}
		}

		private void OnRuntimeEditorCreated(object sender, EventArgs e)
		{
			CreateRuntimeComponents();
		}

		private void OnRuntimeEditorDestroyed(object sender, EventArgs e)
		{
			DestroyRuntimeComponents();
		}

		private void OnEnable()
		{
			m_spline = GetComponentInParent<SplineBase>();
			if (!(m_spline == null))
			{
				m_spline.ControlPointModeChanged -= OnControlPointModeChanged;
				m_spline.ControlPointModeChanged += OnControlPointModeChanged;
				m_spline.ControlPointPositionChanged -= OnControlPointPositionChanged;
				m_spline.ControlPointPositionChanged += OnControlPointPositionChanged;
				UpdateMaterial();
			}
		}

		private void Start()
		{
			SplineRuntimeEditor.Created += OnRuntimeEditorCreated;
			SplineRuntimeEditor.Destroyed += OnRuntimeEditorDestroyed;
			CreateRuntimeComponents();
			if (m_spline == null)
			{
				m_spline = GetComponentInParent<SplineBase>();
				if (m_spline == null)
				{
					UnityEngine.Debug.LogError("Is not a child of gameobject with Spline or MeshDeformer component", base.gameObject);
					return;
				}
				m_spline.ControlPointModeChanged -= OnControlPointModeChanged;
				m_spline.ControlPointModeChanged += OnControlPointModeChanged;
				m_spline.ControlPointPositionChanged -= OnControlPointPositionChanged;
				m_spline.ControlPointPositionChanged += OnControlPointPositionChanged;
			}
			m_localPosition = m_spline.GetControlPointLocal(m_index);
			base.transform.localPosition = m_localPosition;
			UpdateMaterial();
		}

		private void OnDisable()
		{
			if (!(m_spline == null))
			{
				m_spline.ControlPointModeChanged -= OnControlPointModeChanged;
				m_spline.ControlPointPositionChanged -= OnControlPointPositionChanged;
			}
		}

		protected void OnDestroy()
		{
			if (m_spline != null)
			{
				m_spline.ControlPointModeChanged -= OnControlPointModeChanged;
				m_spline.ControlPointPositionChanged -= OnControlPointPositionChanged;
			}
			SplineRuntimeEditor.Created -= OnRuntimeEditorCreated;
			SplineRuntimeEditor.Destroyed -= OnRuntimeEditorDestroyed;
		}

		private void Update()
		{
			if (base.transform.localPosition != m_localPosition)
			{
				m_localPosition = base.transform.localPosition;
				if (m_spline != null)
				{
					m_spline.SetControlPointLocal(m_index, m_localPosition);
				}
			}
		}

		private void OnControlPointModeChanged(int pointIndex)
		{
			if (pointIndex == m_index)
			{
				UpdateMaterial();
			}
		}

		private void OnControlPointPositionChanged(int pointIndex)
		{
			if (!(m_spline == null) && pointIndex == m_index)
			{
				base.transform.position = m_spline.transform.TransformPoint(m_spline.GetControlPointLocal(pointIndex));
				m_localPosition = base.transform.localPosition;
			}
		}
	}
	public sealed class VersionDeserializationBinder : SerializationBinder
	{
		public override Type BindToType(string assemblyName, string typeName)
		{
			if (!string.IsNullOrEmpty(assemblyName) && !string.IsNullOrEmpty(typeName))
			{
				assemblyName = Assembly.GetExecutingAssembly().FullName;
				return Type.GetType($"{typeName}, {assemblyName}");
			}
			return null;
		}
	}
	public class SplineRuntimeCmd : MonoBehaviour
	{
		public virtual void Append()
		{
			if (SplineRuntimeEditor.Instance != null)
			{
				Spline spline = SplineRuntimeEditor.Instance.SelectedSpline as Spline;
				if (spline != null)
				{
					spline.Extend();
				}
			}
		}

		public virtual void Prepend()
		{
			if (SplineRuntimeEditor.Instance != null)
			{
				Spline spline = SplineRuntimeEditor.Instance.SelectedSpline as Spline;
				if (spline != null)
				{
					spline.Extend(prepend: true);
				}
			}
		}

		public virtual void Remove()
		{
			if (!(SplineRuntimeEditor.Instance != null))
			{
				return;
			}
			Spline spline = SplineRuntimeEditor.Instance.SelectedSpline as Spline;
			if (!(spline != null))
			{
				return;
			}
			GameObject activeGameObject = RuntimeSelection.activeGameObject;
			if (activeGameObject != null)
			{
				SplineControlPoint component = activeGameObject.GetComponent<SplineControlPoint>();
				if (component != null)
				{
					spline.Remove((component.Index - 1) / 3);
				}
				RuntimeSelection.activeGameObject = spline.gameObject;
			}
		}

		public virtual void Smooth()
		{
			if (SplineRuntimeEditor.Instance != null)
			{
				SplineBase selectedSpline = SplineRuntimeEditor.Instance.SelectedSpline;
				if (selectedSpline != null)
				{
					selectedSpline.Smooth();
				}
			}
		}

		public virtual void SetMirroredMode()
		{
			if (SplineRuntimeEditor.Instance != null)
			{
				SplineBase selectedSpline = SplineRuntimeEditor.Instance.SelectedSpline;
				if (selectedSpline != null)
				{
					selectedSpline.SetControlPointMode(ControlPointMode.Mirrored);
				}
			}
		}

		public virtual void SetAlignedMode()
		{
			if (SplineRuntimeEditor.Instance != null)
			{
				SplineBase selectedSpline = SplineRuntimeEditor.Instance.SelectedSpline;
				if (selectedSpline != null)
				{
					selectedSpline.SetControlPointMode(ControlPointMode.Aligned);
				}
			}
		}

		public virtual void SetFreeMode()
		{
			if (SplineRuntimeEditor.Instance != null)
			{
				SplineBase selectedSpline = SplineRuntimeEditor.Instance.SelectedSpline;
				if (selectedSpline != null)
				{
					selectedSpline.SetControlPointMode(ControlPointMode.Free);
				}
			}
		}

		public virtual void Load()
		{
			string @string = PlayerPrefs.GetString("SplineEditorSave");
			if (string.IsNullOrEmpty(@string))
			{
				return;
			}
			SplineBase[] array = UnityEngine.Object.FindObjectsOfType<SplineBase>();
			SplineSnapshot[] array2 = DeserializeFromString<SplineSnapshot[]>(@string);
			if (array.Length != array2.Length)
			{
				UnityEngine.Debug.LogError("Wrong data in save file");
				return;
			}
			for (int i = 0; i < array2.Length; i++)
			{
				array[i].Load(array2[i]);
			}
		}

		public virtual void Save()
		{
			SplineBase[] array = UnityEngine.Object.FindObjectsOfType<SplineBase>();
			SplineSnapshot[] array2 = new SplineSnapshot[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = array[i].Save();
			}
			string value = SerializeToString(array2);
			PlayerPrefs.SetString("SplineEditorSave", value);
			PlayerPrefs.Save();
		}

		private static TData DeserializeFromString<TData>(string settings)
		{
			using MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(settings));
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			memoryStream.Seek(0L, SeekOrigin.Begin);
			return (TData)binaryFormatter.Deserialize(memoryStream);
		}

		private static string SerializeToString<TData>(TData settings)
		{
			using MemoryStream memoryStream = new MemoryStream();
			new BinaryFormatter().Serialize(memoryStream, settings);
			memoryStream.Flush();
			memoryStream.Position = 0L;
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(GLRenderer))]
	public class SplineRuntimeEditor : MonoBehaviour
	{
		public Camera Camera;

		public float SelectionMargin = 10f;

		public float Smoothness = 5f;

		public static readonly Color SplineColor = Color.green;

		public static readonly Color MirroredModeColor = Color.red;

		public static readonly Color AlignedModeColor = Color.blue;

		public static readonly Color FreeModeColor = Color.yellow;

		public static readonly Color ControlPointLineColor = Color.gray;

		private Material m_splineMaterial;

		private Material m_normalMaterial;

		private Material m_mirroredModeMaterial;

		private Material m_alignedModeMaterial;

		private Material m_freeModeMaterial;

		private Mesh m_controlPointMesh;

		private bool m_unselectControlPoint;

		private RuntimeHierarchy m_hierarchy;

		private static SplineRuntimeEditor m_instance;

		private SplineBase m_selectedSpline;

		public Mesh ControlPointMesh => m_controlPointMesh;

		public Material MirroredModeMaterial => m_mirroredModeMaterial;

		public Material AlignedModeMaterial => m_alignedModeMaterial;

		public Material FreeModeMaterial => m_freeModeMaterial;

		public Material NormalMaterial => m_normalMaterial;

		public Material SplineMaterial => m_splineMaterial;

		public static SplineRuntimeEditor Instance => m_instance;

		public SplineBase SelectedSpline
		{
			get
			{
				return m_selectedSpline;
			}
			set
			{
				if (m_selectedSpline != value)
				{
					SplineBase selectedSpline = m_selectedSpline;
					m_selectedSpline = value;
					OnSelectedSplineChanged(selectedSpline, m_selectedSpline);
				}
			}
		}

		public static event EventHandler Created;

		public static event EventHandler Destroyed;

		private void Awake()
		{
			if (m_instance != null)
			{
				UnityEngine.Debug.LogWarning("Another instance of SplineEditorSettings already exist");
			}
			if (m_mirroredModeMaterial == null)
			{
				Shader shader = Shader.Find("Battlehub/SplineEditor/SSBillboard");
				m_mirroredModeMaterial = new Material(shader);
				m_mirroredModeMaterial.name = "MirroredModeMaterial";
				m_mirroredModeMaterial.color = MirroredModeColor;
				m_mirroredModeMaterial.SetInt("_Cull", 0);
				m_mirroredModeMaterial.SetInt("_ZWrite", 1);
				m_mirroredModeMaterial.SetInt("_ZTest", 8);
			}
			if (m_alignedModeMaterial == null)
			{
				m_alignedModeMaterial = UnityEngine.Object.Instantiate(m_mirroredModeMaterial);
				m_alignedModeMaterial.name = "AlignedModeMaterial";
				m_alignedModeMaterial.color = AlignedModeColor;
			}
			if (m_freeModeMaterial == null)
			{
				m_freeModeMaterial = UnityEngine.Object.Instantiate(m_mirroredModeMaterial);
				m_freeModeMaterial.name = "FreeModeMaterial";
				m_freeModeMaterial.color = FreeModeColor;
			}
			if (m_normalMaterial == null)
			{
				m_normalMaterial = UnityEngine.Object.Instantiate(m_mirroredModeMaterial);
				m_normalMaterial.name = "SplineMaterial";
				m_normalMaterial.color = SplineColor;
			}
			if (m_splineMaterial == null)
			{
				Shader shader2 = Shader.Find("Battlehub/SplineEditor/Spline");
				m_splineMaterial = new Material(shader2);
				m_splineMaterial.name = "SplineMaterial";
				m_splineMaterial.color = SplineColor;
			}
			if (m_controlPointMesh == null)
			{
				m_controlPointMesh = new Mesh();
				m_controlPointMesh.name = "control point mesh";
				m_controlPointMesh.vertices = new Vector3[4]
				{
					new Vector3(0f, 0f, 0f),
					new Vector3(0f, 0f, 0f),
					new Vector3(0f, 0f, 0f),
					new Vector3(0f, 0f, 0f)
				};
				m_controlPointMesh.triangles = new int[6] { 0, 1, 2, 0, 2, 3 };
				m_controlPointMesh.uv = new Vector2[4]
				{
					new Vector2(-1f, -1f),
					new Vector2(1f, -1f),
					new Vector2(1f, 1f),
					new Vector2(-1f, 1f)
				};
				m_controlPointMesh.RecalculateBounds();
			}
			m_instance = this;
			EnableRuntimeEditing();
			m_hierarchy = GetComponentInChildren<RuntimeHierarchy>();
			if (m_hierarchy != null)
			{
				m_hierarchy.TypeCriteria = typeof(SplineBase);
				m_hierarchy.SelectionChanged += OnHierarchySelectionChanged;
			}
		}

		private void Start()
		{
			if (SplineRuntimeEditor.Created != null)
			{
				SplineRuntimeEditor.Created(this, EventArgs.Empty);
			}
			if (Camera == null)
			{
				Camera = Camera.main;
			}
		}

		private void OnDestroy()
		{
			if (!Application.isPlaying)
			{
				DisableRuntimeEditing();
			}
			if (SplineRuntimeEditor.Destroyed != null)
			{
				SplineRuntimeEditor.Destroyed(this, EventArgs.Empty);
			}
			if (m_hierarchy != null)
			{
				m_hierarchy.SelectionChanged -= OnHierarchySelectionChanged;
			}
			m_instance = null;
		}

		private void DisableRuntimeEditing()
		{
			Camera[] allCameras = Camera.allCameras;
			for (int i = 0; i < allCameras.Length; i++)
			{
				GLCamera component = allCameras[i].GetComponent<GLCamera>();
				if (component != null)
				{
					UnityEngine.Object.DestroyImmediate(component);
				}
			}
		}

		private void EnableRuntimeEditing()
		{
			Camera[] allCameras = Camera.allCameras;
			foreach (Camera camera in allCameras)
			{
				if (!camera.GetComponent<GLCamera>())
				{
					camera.gameObject.AddComponent<GLCamera>();
				}
			}
		}

		private void LateUpdate()
		{
			if (Application.isPlaying && SelectedSpline != null && Input.GetMouseButtonDown(0) && (EventSystem.current == null || !EventSystem.current.IsPointerOverGameObject()))
			{
				int selectedIndex = HitTest();
				if (selectedIndex != -1)
				{
					RuntimeSelection.activeGameObject = (from p in SelectedSpline.GetComponentsInChildren<SplineControlPoint>()
						where p.Index == selectedIndex
						select p).FirstOrDefault().gameObject;
				}
				else if (RuntimeTools.Current != RuntimeTool.View && RuntimeSelection.activeGameObject != null && PositionHandle.Current != null && !PositionHandle.Current.IsDragging && SelectedSpline != null)
				{
					RuntimeSelection.activeGameObject = SelectedSpline.gameObject;
				}
			}
			if (!(m_instance == null))
			{
				return;
			}
			m_instance = this;
			SplineBase[] array = UnityEngine.Object.FindObjectsOfType<SplineBase>();
			foreach (SplineBase splineBase in array)
			{
				if (splineBase.IsSelected)
				{
					splineBase.Select();
				}
			}
		}

		private void OnHierarchySelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (e.NewItem != null && e.NewItem is SplineBase)
			{
				SplineBase splineBase = (SplineBase)e.NewItem;
				if (!splineBase.IsSelected)
				{
					splineBase.Select();
				}
			}
			else if (e.OldItem != null && e.OldItem is SplineBase)
			{
				SplineBase splineBase2 = (SplineBase)e.OldItem;
				if (splineBase2.IsSelected)
				{
					splineBase2.Unselect();
				}
			}
		}

		private void OnSelectedSplineChanged(SplineBase oldSpline, SplineBase newSpline)
		{
			if (Application.isPlaying)
			{
				if (oldSpline != null)
				{
					oldSpline.Unselect();
					if (RuntimeSelection.activeGameObject != null && RuntimeSelection.activeGameObject.GetComponentInParent<SplineBase>() == oldSpline)
					{
						RuntimeSelection.activeGameObject = null;
					}
				}
				if (newSpline != null)
				{
					RuntimeSelection.activeGameObject = newSpline.gameObject;
				}
				m_hierarchy.SelectedItem = newSpline;
			}
			else if (oldSpline != null)
			{
				oldSpline.Unselect();
			}
		}

		private int HitTest()
		{
			if (Camera == null)
			{
				UnityEngine.Debug.LogError("Camera is null");
				return -1;
			}
			int controlPointCount = SelectedSpline.ControlPointCount;
			Vector3[] array = new Vector3[controlPointCount];
			for (int i = 0; i < controlPointCount; i++)
			{
				array[i] = SelectedSpline.GetControlPoint(i);
			}
			float num = SelectionMargin * SelectionMargin;
			int result = -1;
			Vector2 vector = Input.mousePosition;
			for (int j = 0; j < controlPointCount; j++)
			{
				Vector3 position = array[j];
				float sqrMagnitude = ((Vector2)Camera.WorldToScreenPoint(position) - vector).sqrMagnitude;
				if (sqrMagnitude < num)
				{
					num = sqrMagnitude;
					result = j;
				}
			}
			return result;
		}
	}
}
namespace Battlehub.RTHandles
{
	[ExecuteInEditMode]
	public class GLCamera : MonoBehaviour
	{
		private void OnPostRender()
		{
			if (GLRenderer.Instance != null)
			{
				GLRenderer.Instance.Draw();
			}
		}
	}
	public interface IGL
	{
		void Draw();
	}
	[ExecuteInEditMode]
	public class GLRenderer : MonoBehaviour
	{
		private static GLRenderer m_instance;

		private List<IGL> m_renderObjects;

		public static GLRenderer Instance => m_instance;

		public void Add(IGL gl)
		{
			if (!m_renderObjects.Contains(gl))
			{
				m_renderObjects.Add(gl);
			}
		}

		public void Remove(IGL line)
		{
			m_renderObjects.Remove(line);
		}

		private void Awake()
		{
			if (m_instance != null)
			{
				UnityEngine.Debug.LogWarning("Another instance of GLLinesRenderer aleready exist");
			}
			m_instance = this;
			m_renderObjects = new List<IGL>();
		}

		public void Draw()
		{
			if (m_renderObjects != null)
			{
				for (int i = 0; i < m_renderObjects.Count; i++)
				{
					m_renderObjects[i].Draw();
				}
			}
		}
	}
	[AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]
	public class MouseOrbit : MonoBehaviour
	{
		public Vector3 Target;

		public float Distance = 5f;

		public float XSpeed = 5f;

		public float YSpeed = 5f;

		public float YMinLimit = -360f;

		public float YMaxLimit = 360f;

		public float DistanceMin = 0.5f;

		public float DistanceMax = 5000f;

		private float m_x;

		private float m_y;

		private void Start()
		{
			Init();
		}

		public void Init()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			m_x = eulerAngles.y;
			m_y = eulerAngles.x;
		}

		private void LateUpdate()
		{
			float axis = Input.GetAxis("Mouse X");
			float axis2 = Input.GetAxis("Mouse Y");
			Vector2 vector = new Vector2(axis, axis2);
			axis = vector.x * XSpeed;
			axis2 = vector.y * YSpeed;
			m_x += axis;
			m_y -= axis2;
			m_y = ClampAngle(m_y, YMinLimit, YMaxLimit);
			Zoom();
		}

		public void Zoom()
		{
			Quaternion quaternion = Quaternion.Euler(m_y, m_x, 0f);
			Distance = Mathf.Clamp(Distance - Input.GetAxis("Mouse ScrollWheel") * Distance, DistanceMin, DistanceMax);
			Vector3 vector = new Vector3(0f, 0f, 0f - Distance);
			Vector3 position = quaternion * vector + Target;
			base.transform.rotation = quaternion;
			base.transform.position = position;
		}

		public static float ClampAngle(float angle, float min, float max)
		{
			if (angle < -360f)
			{
				angle += 360f;
			}
			if (angle > 360f)
			{
				angle -= 360f;
			}
			return Mathf.Clamp(angle, min, max);
		}
	}
	public class PositionHandle : MonoBehaviour, IGL
	{
		public Camera Camera;

		public float SelectionMargin = 10f;

		public Transform Target;

		private RuntimeHandleAxis m_selectedAxis;

		private bool m_isDragging;

		private Vector3 m_prevPoint;

		private Plane m_dragPlane;

		public bool IsDragging => m_isDragging;

		public static PositionHandle Current { get; private set; }

		private void Start()
		{
			if (GLRenderer.Instance == null)
			{
				GameObject obj = new GameObject();
				obj.name = "GLRenderer";
				obj.AddComponent<GLRenderer>();
				Camera[] allCameras = Camera.allCameras;
				foreach (Camera camera in allCameras)
				{
					if (!camera.GetComponent<GLCamera>())
					{
						camera.gameObject.AddComponent<GLCamera>();
					}
				}
			}
			if (Camera == null)
			{
				Camera = Camera.main;
			}
			if (GLRenderer.Instance != null)
			{
				GLRenderer.Instance.Add(this);
			}
			if (Target != null && Target.position != base.transform.position)
			{
				base.transform.position = Target.position;
			}
			Current = this;
		}

		private void OnEnable()
		{
			if (GLRenderer.Instance != null)
			{
				GLRenderer.Instance.Add(this);
			}
		}

		private void OnDisable()
		{
			if (GLRenderer.Instance != null)
			{
				GLRenderer.Instance.Remove(this);
			}
		}

		private void OnDestroy()
		{
			if (GLRenderer.Instance != null)
			{
				GLRenderer.Instance.Remove(this);
			}
			if (Current == this)
			{
				Current = null;
			}
		}

		private void Update()
		{
			Vector3 point;
			if (Input.GetMouseButtonDown(0))
			{
				if (RuntimeTools.Current != RuntimeTool.Move && RuntimeTools.Current != 0)
				{
					return;
				}
				if (Camera == null)
				{
					UnityEngine.Debug.LogError("Camera is null");
					return;
				}
				float screenScale = RuntimeHandles.GetScreenScale(base.transform.position, Camera);
				Matrix4x4 matrix = Matrix4x4.TRS(base.transform.position, base.transform.rotation, new Vector3(screenScale, screenScale, screenScale));
				if (HitAxis(Vector3.up, matrix, out var distanceToAxis) | HitAxis(Vector3.forward, matrix, out var distanceToAxis2) | HitAxis(Vector3.right, matrix, out var distanceToAxis3))
				{
					if (distanceToAxis <= distanceToAxis2 && distanceToAxis <= distanceToAxis3)
					{
						m_selectedAxis = RuntimeHandleAxis.Y;
					}
					else if (distanceToAxis3 <= distanceToAxis && distanceToAxis3 <= distanceToAxis2)
					{
						m_selectedAxis = RuntimeHandleAxis.X;
					}
					else
					{
						m_selectedAxis = RuntimeHandleAxis.Z;
					}
					m_dragPlane = GetDragPlane();
					m_isDragging = GetPointOnDragPlane(Input.mousePosition, out m_prevPoint);
				}
				else
				{
					m_selectedAxis = RuntimeHandleAxis.None;
				}
			}
			else if (Input.GetMouseButtonUp(0))
			{
				m_isDragging = false;
			}
			else if (m_isDragging && GetPointOnDragPlane(Input.mousePosition, out point))
			{
				Vector3 vector = base.transform.InverseTransformVector(point - m_prevPoint);
				float magnitude = vector.magnitude;
				if (m_selectedAxis == RuntimeHandleAxis.X)
				{
					vector.y = (vector.z = 0f);
				}
				else if (m_selectedAxis == RuntimeHandleAxis.Y)
				{
					vector.x = (vector.z = 0f);
				}
				else
				{
					vector.x = (vector.y = 0f);
				}
				vector = base.transform.TransformVector(vector).normalized * magnitude;
				base.transform.position += vector;
				m_prevPoint = point;
			}
			if (Target != null && Target.position != base.transform.position)
			{
				if (m_isDragging)
				{
					Target.position = base.transform.position;
				}
				else
				{
					base.transform.position = Target.position;
				}
			}
		}

		private bool HitAxis(Vector3 axis, Matrix4x4 matrix, out float distanceToAxis)
		{
			axis = matrix.MultiplyVector(axis);
			Vector2 vector = Camera.WorldToScreenPoint(base.transform.position);
			Vector3 vector2 = (Vector2)Camera.WorldToScreenPoint(axis + base.transform.position) - vector;
			float magnitude = vector2.magnitude;
			vector2.Normalize();
			if (vector2 != Vector3.zero)
			{
				Vector2 normalized = PerpendicularClockwise(vector2).normalized;
				Vector2 vector3 = (Vector2)Input.mousePosition - vector;
				distanceToAxis = Mathf.Abs(Vector2.Dot(normalized, vector3));
				Vector2 rhs = vector3 - normalized * distanceToAxis;
				float num = Vector2.Dot(vector2, rhs);
				int num2;
				if (num <= magnitude + SelectionMargin && num >= 0f - SelectionMargin)
				{
					num2 = ((distanceToAxis <= SelectionMargin) ? 1 : 0);
					if (num2 != 0)
					{
						if (magnitude < SelectionMargin)
						{
							distanceToAxis = 0f;
						}
						return (byte)num2 != 0;
					}
				}
				else
				{
					num2 = 0;
				}
				distanceToAxis = float.PositiveInfinity;
				return (byte)num2 != 0;
			}
			Vector2 vector4 = Input.mousePosition;
			distanceToAxis = (vector - vector4).magnitude;
			bool num3 = distanceToAxis <= SelectionMargin;
			if (!num3)
			{
				distanceToAxis = float.PositiveInfinity;
				return num3;
			}
			distanceToAxis = 0f;
			return num3;
		}

		private Plane GetDragPlane()
		{
			return new Plane(-(Camera.transform.position - base.transform.position).normalized, base.transform.position);
		}

		private bool GetPointOnDragPlane(Vector3 screenPos, out Vector3 point)
		{
			Ray ray = Camera.ScreenPointToRay(screenPos);
			if (m_dragPlane.Raycast(ray, out var enter))
			{
				point = ray.GetPoint(enter);
				return true;
			}
			point = Vector3.zero;
			return false;
		}

		private static Vector2 PerpendicularClockwise(Vector2 vector2)
		{
			return new Vector2(0f - vector2.y, vector2.x);
		}

		public void Draw()
		{
			RuntimeHandles.DoPositionHandle(base.transform.position, base.transform.rotation, m_selectedAxis);
		}
	}
	public enum RuntimeHandleAxis
	{
		None,
		X,
		Y,
		Z
	}
	public static class RuntimeHandles
	{
		public static readonly Color32 XColor;

		public static readonly Color32 YColor;

		public static readonly Color32 ZColor;

		public static readonly Color32 SelectionColor;

		private static readonly Mesh Arrows;

		private static readonly Mesh ArrowsY;

		private static readonly Mesh ArrowsX;

		private static readonly Mesh ArrowsZ;

		private static readonly Material ArrowsMaterial;

		private static readonly Material LinesMaterial;

		static RuntimeHandles()
		{
			XColor = new Color32(187, 70, 45, byte.MaxValue);
			YColor = new Color32(139, 206, 74, byte.MaxValue);
			ZColor = new Color32(55, 115, 244, byte.MaxValue);
			SelectionColor = new Color32(239, 238, 64, byte.MaxValue);
			LinesMaterial = new Material(Shader.Find("Battlehub/RTHandles/VertexColor"));
			LinesMaterial.color = Color.white;
			ArrowsMaterial = new Material(Shader.Find("Battlehub/RTHandles/Shape"));
			ArrowsMaterial.color = Color.white;
			Mesh mesh = CreateConeMesh(SelectionColor);
			CombineInstance combineInstance = new CombineInstance
			{
				mesh = mesh,
				transform = Matrix4x4.TRS(Vector3.up, Quaternion.identity, Vector3.one)
			};
			ArrowsY = new Mesh();
			ArrowsY.CombineMeshes(new CombineInstance[1] { combineInstance }, mergeSubMeshes: true);
			ArrowsY.RecalculateNormals();
			CombineInstance combineInstance2 = new CombineInstance
			{
				mesh = mesh,
				transform = Matrix4x4.TRS(Vector3.right, Quaternion.AngleAxis(-90f, Vector3.forward), Vector3.one)
			};
			ArrowsX = new Mesh();
			ArrowsX.CombineMeshes(new CombineInstance[1] { combineInstance2 }, mergeSubMeshes: true);
			ArrowsX.RecalculateNormals();
			CombineInstance combineInstance3 = new CombineInstance
			{
				mesh = mesh,
				transform = Matrix4x4.TRS(Vector3.forward, Quaternion.AngleAxis(90f, Vector3.right), Vector3.one)
			};
			ArrowsZ = new Mesh();
			ArrowsZ.CombineMeshes(new CombineInstance[1] { combineInstance3 }, mergeSubMeshes: true);
			ArrowsZ.RecalculateNormals();
			combineInstance.mesh = CreateConeMesh(YColor);
			combineInstance2.mesh = CreateConeMesh(XColor);
			combineInstance3.mesh = CreateConeMesh(ZColor);
			Arrows = new Mesh();
			Arrows.CombineMeshes(new CombineInstance[3] { combineInstance, combineInstance2, combineInstance3 }, mergeSubMeshes: true);
			Arrows.RecalculateNormals();
		}

		private static Mesh CreateConeMesh(Color color)
		{
			int num = 12;
			float num2 = 0.2f;
			Vector3[] array = new Vector3[num * 3 + 1];
			int[] array2 = new int[num * 6];
			Color[] array3 = new Color[array.Length];
			for (int i = 0; i < array3.Length; i++)
			{
				array3[i] = color;
			}
			float num3 = num2 / 2.6f;
			float num4 = num2;
			float num5 = (float)Math.PI * 2f / (float)num;
			float y = 0f - num4;
			array[array.Length - 1] = new Vector3(0f, 0f - num4, 0f);
			for (int j = 0; j < num; j++)
			{
				float f = (float)j * num5;
				float x = Mathf.Cos(f) * num3;
				float z = Mathf.Sin(f) * num3;
				array[j] = new Vector3(x, y, z);
				array[num + j] = new Vector3(0f, 0.01f, 0f);
				array[2 * num + j] = array[j];
			}
			for (int k = 0; k < num; k++)
			{
				array2[k * 6] = k;
				array2[k * 6 + 1] = num + k;
				array2[k * 6 + 2] = (k + 1) % num;
				array2[k * 6 + 3] = array.Length - 1;
				array2[k * 6 + 4] = 2 * num + k;
				array2[k * 6 + 5] = 2 * num + (k + 1) % num;
			}
			return new Mesh
			{
				name = "Cone",
				vertices = array,
				triangles = array2,
				colors = array3
			};
		}

		public static float GetScreenScale(Vector3 position, Camera camera)
		{
			float num = camera.pixelHeight;
			if (camera.orthographic)
			{
				return camera.orthographicSize * 2f / num * 90f;
			}
			Transform transform = camera.transform;
			float num2 = Vector3.Dot(position - transform.position, transform.forward);
			return 2f * num2 * Mathf.Tan(camera.fieldOfView * 0.5f * ((float)Math.PI / 180f)) / num * 90f;
		}

		public static void DoPositionHandle(Vector3 position, Quaternion rotation, RuntimeHandleAxis selectedAxis = RuntimeHandleAxis.None)
		{
			float screenScale = GetScreenScale(position, Camera.current);
			Matrix4x4 matrix = Matrix4x4.TRS(position, rotation, new Vector3(screenScale, screenScale, screenScale));
			LinesMaterial.SetPass(0);
			GL.Begin(1);
			Vector3 right = Vector3.right;
			Vector3 up = Vector3.up;
			Vector3 forward = Vector3.forward;
			right = matrix.MultiplyVector(right);
			up = matrix.MultiplyVector(up);
			forward = matrix.MultiplyVector(forward);
			GL.Color((selectedAxis != RuntimeHandleAxis.X) ? XColor : SelectionColor);
			GL.Vertex(position);
			GL.Vertex(position + right);
			GL.Color((selectedAxis != RuntimeHandleAxis.Y) ? YColor : SelectionColor);
			GL.Vertex(position);
			GL.Vertex(position + up);
			GL.Color((selectedAxis != RuntimeHandleAxis.Z) ? ZColor : SelectionColor);
			GL.Vertex(position);
			GL.Vertex(position + forward);
			GL.End();
			ArrowsMaterial.SetPass(0);
			Graphics.DrawMeshNow(Arrows, matrix);
			switch (selectedAxis)
			{
			case RuntimeHandleAxis.X:
				Graphics.DrawMeshNow(ArrowsX, matrix);
				break;
			case RuntimeHandleAxis.Y:
				Graphics.DrawMeshNow(ArrowsY, matrix);
				break;
			case RuntimeHandleAxis.Z:
				Graphics.DrawMeshNow(ArrowsZ, matrix);
				break;
			}
		}

		private static void DoRotationHandle(Quaternion rotation, Vector3 position)
		{
		}

		private static void DoScaleHandle(Vector3 scale, Vector3 position, Quaternion rotation, float size)
		{
		}
	}
	public class RuntimeHierarchy : MonoBehaviour
	{
		public ItemsControl ItemsControl;

		public Type TypeCriteria = typeof(GameObject);

		private UnityEngine.Object m_selectedItem;

		public UnityEngine.Object SelectedItem
		{
			get
			{
				return m_selectedItem;
			}
			set
			{
				m_selectedItem = value;
				ItemsControl.SelectedItem = value;
			}
		}

		public event EventHandler<SelectionChangedEventArgs> SelectionChanged;

		public static bool IsPrefab(Transform This)
		{
			if (Application.isEditor && !Application.isPlaying)
			{
				throw new InvalidOperationException("Does not work in edit mode");
			}
			return This.gameObject.scene.buildIndex < 0;
		}

		private void Start()
		{
			ItemsControl.ItemDataBinding += OnDataBinding;
			ItemsControl.SelectionChanged += OnSelectionChanged;
			List<UnityEngine.Object> list = new List<UnityEngine.Object>();
			GameObject[] array = Resources.FindObjectsOfTypeAll<GameObject>();
			foreach (GameObject gameObject in array)
			{
				if (gameObject == null || IsPrefab(gameObject.transform))
				{
					continue;
				}
				if (TypeCriteria == typeof(GameObject))
				{
					list.Add(gameObject);
					continue;
				}
				UnityEngine.Component component = gameObject.GetComponent(TypeCriteria);
				if ((bool)component)
				{
					list.Add(component);
				}
			}
			ItemsControl.Items = list;
			ItemsControl.SelectedItem = m_selectedItem;
		}

		private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (this.SelectionChanged != null)
			{
				this.SelectionChanged(this, e);
			}
		}

		private void OnDataBinding(object sender, ItemDataBindingEventArgs e)
		{
			UnityEngine.Object @object = e.Item as UnityEngine.Object;
			if (@object != null)
			{
				e.ItemPresenter.GetComponentInChildren<Text>(includeInactive: true).text = @object.name;
			}
		}

		private void OnDestroy()
		{
			if (ItemsControl != null)
			{
				ItemsControl.ItemDataBinding -= OnDataBinding;
				ItemsControl.SelectionChanged -= OnSelectionChanged;
			}
		}
	}
	public enum RuntimeTool
	{
		None,
		Move,
		View
	}
	public class RuntimeTools
	{
		private static RuntimeTool m_current;

		public static RuntimeTool Current
		{
			get
			{
				return m_current;
			}
			set
			{
				m_current = value;
			}
		}
	}
	public delegate void RuntimeSelectionChanged();
	public static class RuntimeSelection
	{
		private static GameObject m_activeGameObject;

		public static GameObject activeGameObject
		{
			get
			{
				return m_activeGameObject;
			}
			set
			{
				if (m_activeGameObject != value)
				{
					m_activeGameObject = value;
					if (RuntimeSelection.SelectionChanged != null)
					{
						RuntimeSelection.SelectionChanged();
					}
				}
			}
		}

		public static Transform activeTransform
		{
			get
			{
				if (m_activeGameObject == null)
				{
					return null;
				}
				return m_activeGameObject.transform;
			}
			set
			{
				if ((bool)value)
				{
					m_activeGameObject = value.gameObject;
				}
				else
				{
					m_activeGameObject = null;
				}
			}
		}

		public static event RuntimeSelectionChanged SelectionChanged;
	}
	public class RuntimeSceneView : MonoBehaviour
	{
		private bool m_handleInput;

		private Vector3 m_pivot;

		private Vector3 m_lastMousePosition;

		public Camera Camera;

		private MouseOrbit m_mouseOrbit;

		public float RotationSensitivity = 1f;

		public float ZoomSensitivity = 8f;

		public float PanSensitivity = 100f;

		private PositionHandle m_positionHandle;

		public Vector3 Pivot => m_pivot;

		private void Awake()
		{
			RuntimeTools.Current = RuntimeTool.Move;
			GameObject gameObject = new GameObject();
			gameObject.name = "PositionHandle";
			gameObject.transform.SetParent(base.transform, worldPositionStays: false);
			m_positionHandle = gameObject.AddComponent<PositionHandle>();
			gameObject.SetActive(value: false);
			RuntimeSelection.SelectionChanged += OnRuntimeSelectionChanged;
		}

		private void OnDestroy()
		{
			RuntimeTools.Current = RuntimeTool.None;
			RuntimeSelection.SelectionChanged -= OnRuntimeSelectionChanged;
		}

		private void Start()
		{
			if (Camera == null)
			{
				Camera = Camera.main;
			}
			m_mouseOrbit = Camera.gameObject.GetComponent<MouseOrbit>();
			if (m_mouseOrbit == null)
			{
				m_mouseOrbit = Camera.gameObject.AddComponent<MouseOrbit>();
			}
			m_pivot = Camera.transform.position + Camera.transform.forward * m_mouseOrbit.Distance;
			m_mouseOrbit.Target = m_pivot;
			m_mouseOrbit.Init();
			m_mouseOrbit.enabled = false;
		}

		private void Update()
		{
			HandleInput();
		}

		private void OnRuntimeSelectionChanged()
		{
			if (RuntimeSelection.activeGameObject == null)
			{
				if (m_positionHandle != null)
				{
					m_positionHandle.gameObject.SetActive(value: false);
				}
			}
			else if (m_positionHandle != null)
			{
				m_positionHandle.gameObject.SetActive(value: true);
				m_positionHandle.transform.position = RuntimeSelection.activeTransform.position;
				m_positionHandle.Target = RuntimeSelection.activeTransform;
			}
		}

		private void HandleInput()
		{
			if (Input.GetKeyDown(KeyCode.F))
			{
				Focus();
			}
			if (Input.GetKeyUp(KeyCode.AltGr) || Input.GetKeyUp(KeyCode.LeftAlt) || Input.GetKeyUp(KeyCode.RightAlt) || Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(2))
			{
				RuntimeTools.Current = RuntimeTool.Move;
			}
			bool flag = Input.GetMouseButton(2) || Input.GetMouseButton(1);
			bool flag2 = Input.GetKey(KeyCode.AltGr) || Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt);
			bool flag3 = flag2 || flag;
			if (flag3)
			{
				RuntimeTools.Current = RuntimeTool.View;
			}
			if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
			{
				m_handleInput = !m_positionHandle.IsDragging;
				m_lastMousePosition = Input.mousePosition;
				if (flag2)
				{
					m_mouseOrbit.Target = m_pivot;
					m_mouseOrbit.enabled = true;
				}
			}
			if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(2))
			{
				m_handleInput = false;
				m_mouseOrbit.enabled = false;
			}
			if (Input.GetAxis("Mouse ScrollWheel") != 0f)
			{
				m_mouseOrbit.Zoom();
			}
			if (m_handleInput && flag3 && !flag2)
			{
				Pan();
			}
		}

		private void Focus()
		{
			if (!(RuntimeSelection.activeTransform == null))
			{
				Bounds bounds = CalculateBounds(RuntimeSelection.activeTransform);
				Bounds bounds2 = bounds;
				float num = Camera.fieldOfView * ((float)Math.PI / 180f);
				float num2 = Mathf.Max(bounds2.extents.y, bounds2.extents.x, bounds2.extents.z) * 2f;
				float num3 = Math.Max(5f, Math.Abs(num2 / Mathf.Sin(num / 2f)));
				m_pivot = bounds.center;
				Camera.transform.position = m_pivot - num3 * Camera.transform.forward;
				m_mouseOrbit.Distance = num3;
				m_mouseOrbit.Target = m_pivot;
			}
		}

		private Bounds CalculateBounds(Transform t)
		{
			Renderer componentInChildren = t.GetComponentInChildren<Renderer>();
			if ((bool)componentInChildren)
			{
				Bounds totalBounds = componentInChildren.bounds;
				if (totalBounds.size == Vector3.zero && totalBounds.center != componentInChildren.transform.position)
				{
					totalBounds = TransformBounds(componentInChildren.transform.localToWorldMatrix, totalBounds);
				}
				CalculateBounds(t, ref totalBounds);
				return totalBounds;
			}
			return new Bounds(t.position, Vector3.zero);
		}

		private void CalculateBounds(Transform t, ref Bounds totalBounds)
		{
			foreach (Transform item in t)
			{
				Renderer component = item.GetComponent<Renderer>();
				if ((bool)component)
				{
					Bounds bounds = component.bounds;
					if (bounds.size == Vector3.zero && bounds.center != component.transform.position)
					{
						bounds = TransformBounds(component.transform.localToWorldMatrix, bounds);
					}
					totalBounds.Encapsulate(bounds.min);
					totalBounds.Encapsulate(bounds.max);
				}
				CalculateBounds(item, ref totalBounds);
			}
		}

		public static Bounds TransformBounds(Matrix4x4 matrix, Bounds bounds)
		{
			Vector3 center = matrix.MultiplyPoint(bounds.center);
			Vector3 extents = bounds.extents;
			Vector3 vector = matrix.MultiplyVector(new Vector3(extents.x, 0f, 0f));
			Vector3 vector2 = matrix.MultiplyVector(new Vector3(0f, extents.y, 0f));
			Vector3 vector3 = matrix.MultiplyVector(new Vector3(0f, 0f, extents.z));
			extents.x = Mathf.Abs(vector.x) + Mathf.Abs(vector2.x) + Mathf.Abs(vector3.x);
			extents.y = Mathf.Abs(vector.y) + Mathf.Abs(vector2.y) + Mathf.Abs(vector3.y);
			extents.z = Mathf.Abs(vector.z) + Mathf.Abs(vector2.z) + Mathf.Abs(vector3.z);
			Bounds result = default(Bounds);
			result.center = center;
			result.extents = extents;
			return result;
		}

		private void Pan()
		{
			Vector3 vector = m_lastMousePosition - Input.mousePosition;
			vector /= Mathf.Sqrt(Camera.pixelHeight * Camera.pixelHeight + Camera.pixelWidth * Camera.pixelWidth);
			vector *= PanSensitivity;
			vector = Camera.cameraToWorldMatrix.MultiplyVector(vector);
			Camera.transform.position += vector;
			m_pivot += vector;
			m_mouseOrbit.Target = m_pivot;
			m_lastMousePosition = Input.mousePosition;
		}
	}
}
namespace Battlehub.ShowNormals
{
	public class DrawNormals : MonoBehaviour
	{
		public Color Color = Color.cyan;

		public float Length = 0.1f;

		public bool Show = true;
	}
}
namespace Battlehub.MeshDeformer2
{
	[ExecuteInEditMode]
	public class ControlPoint : SplineControlPoint
	{
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(MeshFilter), typeof(Scaffold))]
	public class MeshDeformer : SplineBase
	{
		private const int WRAP_DEFORM_VERSION = 1;

		[HideInInspector]
		public bool Internal_HasChanged;

		[SerializeField]
		[HideInInspector]
		private Mesh m_original;

		[SerializeField]
		[HideInInspector]
		private Mesh m_colliderOriginal;

		[SerializeField]
		[HideInInspector]
		private Contact[] m_contacts;

		[SerializeField]
		[HideInInspector]
		private Contact[] m_colliderContacts;

		[SerializeField]
		[HideInInspector]
		private ScaffoldWrapper[] m_scaffolds;

		[SerializeField]
		[HideInInspector]
		private Axis m_axis = Axis.Z;

		[SerializeField]
		[HideInInspector]
		private int m_sliceCount = 5;

		[SerializeField]
		[HideInInspector]
		private float m_spacing;

		[SerializeField]
		[HideInInspector]
		private int m_curvesPerMesh = 1;

		private MeshFilter m_filter;

		private MeshCollider m_collider;

		public Axis Axis
		{
			get
			{
				return m_axis;
			}
			set
			{
				m_axis = value;
				WrapAndDeformAll();
			}
		}

		public virtual int Approximation
		{
			get
			{
				return m_sliceCount;
			}
			set
			{
				m_sliceCount = value;
				WrapAndDeformAll();
			}
		}

		public virtual float Spacing
		{
			get
			{
				return m_spacing;
			}
			set
			{
				ChangeSpacing(value);
			}
		}

		public virtual int CurvesPerMesh
		{
			get
			{
				return m_curvesPerMesh;
			}
			set
			{
				ChangeCurvesPerMesh(value);
			}
		}

		public override bool Loop
		{
			get
			{
				return base.Loop;
			}
			set
			{
				if (m_spacing <= 0f)
				{
					base.Loop = value;
				}
				else
				{
					ChangeLoop(value);
				}
			}
		}

		public ScaffoldWrapper[] Scaffolds => m_scaffolds;

		public Contact[] Contacts => m_contacts;

		public Mesh Original
		{
			get
			{
				return m_original;
			}
			set
			{
				m_original = value;
				if (m_original == null)
				{
					m_contacts = null;
				}
				else
				{
					m_contacts = m_original.FindContacts(m_axis);
				}
			}
		}

		public Contact[] ColliderContacts => m_colliderContacts;

		public Mesh ColliderOriginal
		{
			get
			{
				return m_colliderOriginal;
			}
			set
			{
				m_colliderOriginal = value;
				if (m_colliderOriginal == null)
				{
					m_colliderContacts = null;
				}
				else
				{
					m_colliderContacts = m_colliderOriginal.FindContacts(m_axis);
				}
			}
		}

		protected override void AwakeOverride()
		{
			base.AwakeOverride();
			m_filter = GetComponent<MeshFilter>();
			m_collider = GetComponent<MeshCollider>();
		}

		public override void Load(SplineSnapshot snapshot)
		{
			if (snapshot.CurveCount < 1)
			{
				throw new ArgumentException("At least one curve required");
			}
			int curveCount = snapshot.CurveCount;
			int num = curveCount / CurvesPerMesh;
			if (curveCount != curveCount * CurvesPerMesh)
			{
				throw new ArgumentException("snapshot.CurveCount should be evenly divisible by CurvesPerMesh");
			}
			int num2 = num - m_scaffolds.Length;
			if (num2 > 0)
			{
				for (int i = 0; i < num2; i++)
				{
					Extend();
				}
			}
			else if (num2 < 0)
			{
				num2 = -num2;
				int num3 = base.CurveCount - 1;
				while (num3 >= 0 && num2 != 0)
				{
					if (Remove(num3))
					{
						num2--;
					}
					num3--;
				}
			}
			base.Load(snapshot);
			WrapAndDeformAll();
		}

		public void ResetDeformer()
		{
			if (m_original == null)
			{
				m_original = m_filter.sharedMesh;
			}
			if (m_original == null)
			{
				m_original = new Mesh();
			}
			if (m_collider != null)
			{
				if (m_colliderOriginal == null)
				{
					m_colliderOriginal = m_collider.sharedMesh;
				}
				if (m_colliderOriginal == null)
				{
					m_colliderOriginal = new Mesh();
				}
			}
			else
			{
				m_colliderOriginal = new Mesh();
			}
			m_original.GetBounds(m_axis, out var from, out var to);
			m_contacts = m_original.FindContacts(m_axis);
			m_colliderContacts = m_colliderOriginal.FindContacts(from, to, m_axis);
			m_filter.sharedMesh = UnityEngine.Object.Instantiate(m_original);
			m_filter.sharedMesh.name = m_original.name + " Deformed";
			if (m_collider != null)
			{
				m_collider.sharedMesh = UnityEngine.Object.Instantiate(m_colliderOriginal);
				m_collider.sharedMesh.name = m_colliderOriginal.name + " Deformed";
			}
			Vector3[] points = new Vector3[4]
			{
				from,
				from + (to - from) * (1f / 3f),
				from + (to - from) * (2f / 3f),
				to
			};
			ControlPointSetting[] settings = new ControlPointSetting[2]
			{
				new ControlPointSetting(new Twist(0f, 0f, 1f), new Thickness(Vector3.one, 0f, 1f)),
				new ControlPointSetting(new Twist(0f, 0f, 1f), new Thickness(Vector3.one, 0f, 1f))
			};
			ControlPointMode[] modes = new ControlPointMode[2]
			{
				ControlPointMode.Mirrored,
				ControlPointMode.Mirrored
			};
			LoadSpline(new SplineSnapshot(points, settings, modes, loop: false));
			ScaffoldWrapper scaffoldWrapper = new ScaffoldWrapper(base.gameObject.GetComponent<Scaffold>(), isRigid: false);
			Mesh colliderMesh = null;
			if (m_collider != null)
			{
				colliderMesh = m_collider.sharedMesh;
			}
			scaffoldWrapper.Wrap(m_filter.sharedMesh, colliderMesh, m_axis, new int[1], m_sliceCount);
			m_scaffolds = new ScaffoldWrapper[1] { scaffoldWrapper };
			scaffoldWrapper.Deform(this, m_original, m_colliderOriginal);
			scaffoldWrapper.RecalculateNormals();
		}

		protected override void OnCurveChanged()
		{
			for (int i = 0; i < m_scaffolds.Length; i++)
			{
				ScaffoldWrapper scaffoldWrapper = m_scaffolds[i];
				if (scaffoldWrapper.IsRigid)
				{
					GetRigidPoints(scaffoldWrapper.CurveIndices.Min() * 3, scaffoldWrapper.CurveIndices.Min(), out var points);
					SetPoints(scaffoldWrapper.CurveIndices.Min(), points, ControlPointMode.Free, raiseCurveChanged: false);
				}
			}
			DeformAll();
		}

		private void DeformAll()
		{
			for (int i = 0; i < m_scaffolds.Length; i++)
			{
				ScaffoldWrapper obj = m_scaffolds[i];
				obj.Deform(this, m_original, m_colliderOriginal);
				obj.RecalculateNormals();
			}
			ScaffoldWrapper prev = null;
			if (Loop)
			{
				prev = m_scaffolds[m_scaffolds.Length - 1];
			}
			for (int j = 0; j < m_scaffolds.Length; j++)
			{
				ScaffoldWrapper obj2 = m_scaffolds[j];
				obj2.SlerpContacts(this, m_original, m_colliderOriginal, prev, null);
				prev = obj2;
			}
		}

		protected override void OnCurveChanged(int pointIndex, int curveIndex)
		{
			ScaffoldWrapper scaffoldWrapper = FindScaffold(curveIndex);
			if (scaffoldWrapper == null)
			{
				return;
			}
			if (scaffoldWrapper.IsRigid)
			{
				if (pointIndex == 0 && curveIndex == 0)
				{
					int num = scaffoldWrapper.CurveIndices.Min() * 3;
					int num2 = scaffoldWrapper.CurveIndices.Max() * 3 + 3;
					int pointIndex2 = (num + num2 + 1) / 2;
					GetRigidPoints(pointIndex2, curveIndex, out var points);
					SetPoints(scaffoldWrapper.CurveIndices.Min(), points, ControlPointMode.Free, raiseCurveChanged: false);
				}
				else
				{
					GetRigidPoints(pointIndex, curveIndex, out var points2);
					SetPoints(scaffoldWrapper.CurveIndices.Min(), points2, ControlPointMode.Free, raiseCurveChanged: false);
				}
			}
			Deform(curveIndex);
		}

		private ScaffoldWrapper Prev(ScaffoldWrapper scaffold)
		{
			if (scaffold == null)
			{
				return null;
			}
			int prevIndex = scaffold.CurveIndices.Min() - 1;
			if (Loop && prevIndex < 0)
			{
				prevIndex = base.CurveCount - 1;
			}
			if (prevIndex >= 0)
			{
				return m_scaffolds.Where((ScaffoldWrapper s) => s?.CurveIndices.Contains(prevIndex) ?? false).FirstOrDefault();
			}
			return null;
		}

		private ScaffoldWrapper Next(ScaffoldWrapper scaffold)
		{
			if (scaffold == null)
			{
				return null;
			}
			int nextIndex = scaffold.CurveIndices.Max() + 1;
			if (Loop && nextIndex >= base.CurveCount)
			{
				nextIndex = 0;
			}
			if (nextIndex < base.CurveCount)
			{
				return m_scaffolds.Where((ScaffoldWrapper s) => s?.CurveIndices.Contains(nextIndex) ?? false).FirstOrDefault();
			}
			return null;
		}

		private void Deform(ScaffoldWrapper scaffold)
		{
			ScaffoldWrapper scaffoldWrapper = Prev(scaffold);
			ScaffoldWrapper scaffoldWrapper2 = Next(scaffold);
			ForceRigid(scaffold);
			ForceRigid(scaffoldWrapper);
			ForceRigid(scaffoldWrapper2);
			if (scaffold != null)
			{
				scaffold.Deform(this, m_original, m_colliderOriginal);
				scaffoldWrapper?.Deform(this, m_original, m_colliderOriginal);
				scaffoldWrapper2?.Deform(this, m_original, m_colliderOriginal);
				for (int i = 0; i < m_scaffolds.Length; i++)
				{
					scaffold = m_scaffolds[i];
					scaffold.RecalculateNormals();
				}
				scaffoldWrapper = null;
				if (Loop)
				{
					scaffoldWrapper = m_scaffolds[m_scaffolds.Length - 1];
				}
				for (int j = 0; j < m_scaffolds.Length; j++)
				{
					scaffold = m_scaffolds[j];
					scaffold.SlerpContacts(this, m_original, m_colliderOriginal, scaffoldWrapper, null);
					scaffoldWrapper = scaffold;
				}
			}
		}

		private void Deform(int curveIndex)
		{
			ScaffoldWrapper scaffold = FindScaffold(curveIndex);
			Deform(scaffold);
		}

		protected override void ResetOverride()
		{
			base.ResetOverride();
			m_filter = GetComponent<MeshFilter>();
			if (m_original != null)
			{
				m_filter.sharedMesh = m_original;
			}
			m_collider = GetComponent<MeshCollider>();
			if (m_collider != null)
			{
				m_collider.sharedMesh = m_colliderOriginal;
			}
			m_original = null;
			m_colliderOriginal = null;
			ResetDeformer();
		}

		public void WrapAndDeformAll()
		{
			for (int i = 0; i < m_scaffolds.Length; i++)
			{
				ScaffoldWrapper scaffold = m_scaffolds[i];
				WrapAndDeform(scaffold);
			}
			ScaffoldWrapper prev = null;
			if (Loop)
			{
				prev = m_scaffolds[m_scaffolds.Length - 1];
			}
			for (int j = 0; j < m_scaffolds.Length; j++)
			{
				ScaffoldWrapper obj = m_scaffolds[j];
				obj.SlerpContacts(this, m_original, m_colliderOriginal, prev, null);
				prev = obj;
			}
		}

		private void WrapAndDeform(ScaffoldWrapper scaffold)
		{
			if (scaffold.Obj != null)
			{
				Mesh colliderMesh = null;
				MeshCollider component = scaffold.Obj.GetComponent<MeshCollider>();
				if (component != null)
				{
					component.sharedMesh = UnityEngine.Object.Instantiate(m_colliderOriginal);
					component.sharedMesh.name = m_colliderOriginal.name + " Deformed";
					colliderMesh = component.sharedMesh;
				}
				MeshFilter component2 = scaffold.Obj.GetComponent<MeshFilter>();
				if (component2 != null && !(m_original == null))
				{
					component2.sharedMesh = UnityEngine.Object.Instantiate(m_original);
					component2.sharedMesh.name = m_original.name + " Deformed";
					scaffold.Wrap(component2.sharedMesh, colliderMesh, m_axis, scaffold.CurveIndices, m_sliceCount);
					scaffold.Deform(this, m_original, m_colliderOriginal);
					scaffold.RecalculateNormals();
				}
			}
		}

		private void ChangeLoop(bool loop)
		{
			if (m_spacing > 0f)
			{
				if (!loop)
				{
					ScaffoldWrapper scaffoldWrapper = FindScaffold(0);
					if (scaffoldWrapper != null && scaffoldWrapper.IsEmptySpace)
					{
						Remove(0, out var _);
					}
				}
				else
				{
					bool isRigid = false;
					ScaffoldWrapper scaffoldWrapper2 = FindScaffold(0);
					if (scaffoldWrapper2 != null)
					{
						isRigid = scaffoldWrapper2.IsRigid;
					}
					if (m_spacing > 0f)
					{
						PrependCurve(m_spacing, 0, enforceNeighbour: true);
						ScaffoldWrapper scaffoldWrapper3 = new ScaffoldWrapper(null, isRigid);
						scaffoldWrapper3.Wrap(null, null, Axis, new int[1], Approximation);
						Array.Resize(ref m_scaffolds, m_scaffolds.Length + 1);
						ShiftAndInsert(0, scaffoldWrapper3);
					}
					ChangeSpacing(m_spacing);
				}
			}
			base.Loop = loop;
		}

		private GameObject[] ChangeSpacing(float spacing)
		{
			GameObject[] result = null;
			if (m_spacing <= 0f)
			{
				if (spacing > 0f)
				{
					float num = spacing;
					List<ScaffoldWrapper> list = new List<ScaffoldWrapper>(m_scaffolds.OrderBy((ScaffoldWrapper s) => s.CurveIndices[0]));
					int num2 = list.Count - 1;
					int num3 = 0;
					if (Loop)
					{
						num2++;
						num3 = -1;
					}
					Vector3 controlPointLocal = GetControlPointLocal(base.ControlPointCount - 1);
					Vector3 controlPointLocal2 = GetControlPointLocal(base.ControlPointCount - 2);
					for (int num4 = list.Count - 1; num4 > num3; num4--)
					{
						ScaffoldWrapper scaffoldWrapper = list[num4];
						int num5 = scaffoldWrapper.CurveIndices.Min();
						scaffoldWrapper.Shift(num2);
						ScaffoldWrapper scaffoldWrapper2 = new ScaffoldWrapper(null, scaffoldWrapper.IsRigid);
						scaffoldWrapper2.Wrap(null, null, Axis, new int[1] { scaffoldWrapper.CurveIndices.Min() - 1 }, Approximation);
						list.Insert(num4, scaffoldWrapper2);
						Vector3 direction = ((num5 == 0) ? GetDirection(1f) : GetDirection(0f, num5));
						Vector3 point = GetPoint(0f, num5);
						point = base.transform.InverseTransformPoint(point);
						direction = base.transform.InverseTransformDirection(direction);
						Vector3[] points = new Vector3[3]
						{
							point - direction * num,
							point - direction * num * (2f / 3f),
							point - direction * num * (1f / 3f)
						};
						PrependCurve(points, num5, num, enforceNeighbour: true);
						num2--;
					}
					m_scaffolds = list.ToArray();
					for (int i = 0; i < m_scaffolds.Length; i++)
					{
						ScaffoldWrapper scaffoldWrapper3 = m_scaffolds[i];
						if (scaffoldWrapper3.IsEmptySpace)
						{
							for (int j = 0; j < scaffoldWrapper3.CurveIndices.Length; j++)
							{
								AlignCurve(scaffoldWrapper3.CurveIndices[j], spacing);
							}
						}
					}
					ScaffoldWrapper prev = null;
					if (Loop)
					{
						prev = m_scaffolds[m_scaffolds.Length - 1];
						SetControlPointLocal(base.ControlPointCount - 1, controlPointLocal);
						SetControlPointLocal(0, controlPointLocal);
						SetControlPointLocal(base.ControlPointCount - 2, controlPointLocal2);
					}
					for (int k = 0; k < m_scaffolds.Length; k++)
					{
						ScaffoldWrapper obj = m_scaffolds[k];
						obj.Deform(this, m_original, m_colliderOriginal);
						obj.RecalculateNormals();
					}
					for (int l = 0; l < m_scaffolds.Length; l++)
					{
						ScaffoldWrapper obj2 = m_scaffolds[l];
						obj2.SlerpContacts(this, m_original, m_colliderOriginal, prev, null);
						prev = obj2;
					}
				}
			}
			else
			{
				if (spacing < 0f)
				{
					spacing = 0f;
				}
				Vector3 controlPointLocal3 = GetControlPointLocal(base.ControlPointCount - 1);
				Vector3 controlPointLocal4 = GetControlPointLocal(base.ControlPointCount - 2);
				for (int m = 0; m < m_scaffolds.Length; m++)
				{
					ScaffoldWrapper scaffoldWrapper4 = m_scaffolds[m];
					if (scaffoldWrapper4.IsEmptySpace)
					{
						for (int n = 0; n < scaffoldWrapper4.CurveIndices.Length; n++)
						{
							AlignCurve(scaffoldWrapper4.CurveIndices[n], spacing);
						}
					}
				}
				if (Loop)
				{
					SetControlPointLocal(base.ControlPointCount - 1, controlPointLocal3);
					SetControlPointLocal(0, controlPointLocal3);
					SetControlPointLocal(base.ControlPointCount - 2, controlPointLocal4);
				}
				if (spacing <= 0f)
				{
					List<ScaffoldWrapper> list2 = new List<ScaffoldWrapper>(m_scaffolds.OrderBy((ScaffoldWrapper s) => s.CurveIndices[0]));
					for (int num6 = list2.Count - 1; num6 >= 0; num6--)
					{
						ScaffoldWrapper scaffoldWrapper5 = list2[num6];
						if (scaffoldWrapper5.IsEmptySpace)
						{
							int num7 = 0;
							for (int num8 = 0; num8 < scaffoldWrapper5.CurveIndices.Length; num8++)
							{
								RemoveCurve(scaffoldWrapper5.CurveIndices[num8]);
								num7--;
							}
							list2.RemoveAt(num6);
							for (int num9 = num6; num9 < list2.Count; num9++)
							{
								list2[num9].Shift(num7);
							}
						}
					}
					m_scaffolds = list2.ToArray();
					if (Loop)
					{
						Deform(base.CurveCount - 1);
					}
				}
				ScaffoldWrapper prev2 = null;
				if (Loop)
				{
					prev2 = m_scaffolds.Last();
				}
				for (int num10 = 0; num10 < m_scaffolds.Length; num10++)
				{
					ScaffoldWrapper obj3 = m_scaffolds[num10];
					obj3.Deform(this, m_original, m_colliderOriginal);
					obj3.RecalculateNormals();
				}
				for (int num11 = 0; num11 < m_scaffolds.Length; num11++)
				{
					ScaffoldWrapper obj4 = m_scaffolds[num11];
					obj4.SlerpContacts(this, m_original, m_colliderOriginal, prev2, null);
					prev2 = obj4;
				}
			}
			m_spacing = spacing;
			return result;
		}

		private void ChangeCurvesPerMesh(int curvesPerMesh)
		{
			curvesPerMesh = Math.Max(1, curvesPerMesh);
			if (m_curvesPerMesh != curvesPerMesh)
			{
				ChangeCurvesPerMeshStep1(0, curvesPerMesh);
				for (int i = 0; i < m_scaffolds.Length; i++)
				{
					ScaffoldWrapper scaffold = m_scaffolds[i];
					ChangeCurvesPerMeshStep2(curvesPerMesh, scaffold);
				}
				m_curvesPerMesh = curvesPerMesh;
				WrapAndDeformAll();
			}
		}

		private void ChangeCurvesPerMeshStep1(int scaffoldIndex, int curvesPerMesh)
		{
			int num = 0;
			for (int i = scaffoldIndex; i < m_scaffolds.Length; i++)
			{
				ScaffoldWrapper scaffoldWrapper = m_scaffolds[i];
				int[] array = scaffoldWrapper.CurveIndices.OrderBy((int c) => c).ToArray();
				for (int j = 0; j < array.Length; j++)
				{
					array[j] += num;
				}
				scaffoldWrapper.CurveIndices = array;
				if (!scaffoldWrapper.IsEmptySpace)
				{
					int num2 = scaffoldWrapper.CurveIndices.Length;
					int num3 = curvesPerMesh - num2;
					num += num3;
				}
			}
		}

		private void ChangeCurvesPerMeshStep2(int curvesPerMesh, ScaffoldWrapper scaffold)
		{
			int[] array = scaffold.CurveIndices;
			if (!scaffold.IsEmptySpace)
			{
				int num = scaffold.CurveIndices.Length;
				Subdivide(scaffold.CurveIndices.Min(), scaffold.CurveIndices.Max(), curvesPerMesh);
				Array.Resize(ref array, curvesPerMesh);
				for (int i = num; i < array.Length; i++)
				{
					array[i] = array[i - 1] + 1;
				}
			}
			scaffold.CurveIndices = array;
		}

		public bool Remove(int curveIndex)
		{
			GameObject objectToRemove;
			bool result = Remove(curveIndex, out objectToRemove);
			if (objectToRemove != null)
			{
				UnityEngine.Object.Destroy(objectToRemove);
			}
			return result;
		}

		public bool Remove(int curveIndex, out GameObject objectToRemove)
		{
			objectToRemove = null;
			ScaffoldWrapper removeScaffold = m_scaffolds.Where((ScaffoldWrapper s) => s?.CurveIndices.Contains(curveIndex) ?? false).FirstOrDefault();
			if (removeScaffold == null)
			{
				return false;
			}
			if (removeScaffold.Obj != null && removeScaffold.CurveIndices.Length <= 1 && removeScaffold.Obj.GetComponent<MeshDeformer>() != null)
			{
				UnityEngine.Debug.LogWarning("Unable to Remove curve attached to MeshDeformer");
				return false;
			}
			if (!RemoveCurve(curveIndex))
			{
				return false;
			}
			int num = -1;
			int[] array;
			int num3;
			if (removeScaffold.Obj != null && removeScaffold.CurveIndices.Length > 1)
			{
				int num2 = Array.IndexOf(removeScaffold.CurveIndices, curveIndex);
				array = removeScaffold.CurveIndices.Where((int index) => index != curveIndex).ToArray();
				for (int i = num2; i < array.Length; i++)
				{
					array[i]--;
				}
				MeshFilter component = removeScaffold.Obj.GetComponent<MeshFilter>();
				component.sharedMesh = UnityEngine.Object.Instantiate(m_original);
				component.sharedMesh.name = m_original.name + " Deformed";
				Mesh colliderMesh = null;
				MeshCollider component2 = removeScaffold.Obj.GetComponent<MeshCollider>();
				if (component2 != null)
				{
					component2.sharedMesh = UnityEngine.Object.Instantiate(m_colliderOriginal);
					component2.sharedMesh.name = m_colliderOriginal.name + " Deformed";
					colliderMesh = component2.sharedMesh;
				}
				removeScaffold.Wrap(component.sharedMesh, colliderMesh, m_axis, array, m_sliceCount);
				num3 = ToScaffoldIndex(removeScaffold.CurveIndices.Max() + 1);
			}
			else
			{
				m_scaffolds = m_scaffolds.Where((ScaffoldWrapper s) => s != removeScaffold).ToArray();
				if (removeScaffold.Obj != null)
				{
					if (Application.isPlaying)
					{
						UnityEngine.Object.Destroy(removeScaffold.Obj.gameObject);
					}
					else
					{
						objectToRemove = removeScaffold.Obj.gameObject;
					}
				}
				if (curveIndex == base.CurveCount)
				{
					ScaffoldWrapper prevScaffold = FindScaffold(curveIndex - 1);
					if (prevScaffold != null && prevScaffold.IsEmptySpace && RemoveCurve(curveIndex - 1))
					{
						num--;
						m_scaffolds = m_scaffolds.Where((ScaffoldWrapper s) => s != prevScaffold).ToArray();
					}
				}
				else
				{
					ScaffoldWrapper nextScaffold = FindScaffold(curveIndex + 1);
					if (nextScaffold != null && nextScaffold.IsEmptySpace && RemoveCurve(curveIndex))
					{
						num--;
						m_scaffolds = m_scaffolds.Where((ScaffoldWrapper s) => s != nextScaffold).ToArray();
					}
				}
				num3 = ToScaffoldIndex(curveIndex);
				array = new int[1] { curveIndex };
			}
			if (num3 > -1)
			{
				for (int j = num3; j < m_scaffolds.Length; j++)
				{
					ScaffoldWrapper scaffoldWrapper = m_scaffolds[j];
					if (scaffoldWrapper != null)
					{
						scaffoldWrapper.Shift(num);
						scaffoldWrapper.Deform(this, m_original, m_colliderOriginal);
					}
				}
			}
			if (array.Length != 0)
			{
				Deform(array.First());
			}
			if (Loop)
			{
				Deform(base.CurveCount - 1);
			}
			return true;
		}

		public GameObject Extend(bool prepend = false)
		{
			int num = 0;
			GameObject gameObject = UnityEngine.Object.Instantiate(base.gameObject);
			gameObject.name = "segment";
			gameObject.transform.parent = base.transform;
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.transform.localRotation = Quaternion.identity;
			gameObject.transform.localScale = Vector3.one;
			for (int num2 = gameObject.transform.childCount - 1; num2 >= 0; num2--)
			{
				UnityEngine.Object.DestroyImmediate(gameObject.transform.GetChild(num2).gameObject);
			}
			UnityEngine.Component[] components = gameObject.GetComponents<UnityEngine.Component>();
			for (int num3 = components.Length - 1; num3 >= 0; num3--)
			{
				UnityEngine.Component component = components[num3];
				if (!(component is Transform) && !(component is MeshFilter) && !(component is MeshRenderer) && !(component is MeshCollider) && !(component is Scaffold))
				{
					UnityEngine.Object.DestroyImmediate(component);
				}
			}
			Scaffold component2 = gameObject.GetComponent<Scaffold>();
			if (component2 != null)
			{
				UnityEngine.Object.DestroyImmediate(component2);
			}
			m_original.GetBounds(m_axis, out var from, out var to);
			ScaffoldWrapper scaffoldWrapper;
			if (prepend && !Loop)
			{
				scaffoldWrapper = FindScaffold(num);
				bool isRigid = false;
				if (scaffoldWrapper != null)
				{
					isRigid = scaffoldWrapper.IsRigid;
				}
				if (m_spacing > 0f)
				{
					PrependCurve(m_spacing, num, enforceNeighbour: true);
					ScaffoldWrapper scaffoldWrapper2 = new ScaffoldWrapper(null, isRigid);
					scaffoldWrapper2.Wrap(null, null, Axis, new int[1] { num }, Approximation);
					Array.Resize(ref m_scaffolds, m_scaffolds.Length + 1);
					ShiftAndInsert(num, scaffoldWrapper2);
				}
				float magnitude = (to - from).magnitude;
				PrependCurve(magnitude, num, enforceNeighbour: false);
				MeshFilter component3 = gameObject.GetComponent<MeshFilter>();
				component3.sharedMesh = UnityEngine.Object.Instantiate(m_original);
				component3.sharedMesh.name = m_original.name + " Deformed";
				Mesh colliderMesh = null;
				MeshCollider component4 = gameObject.GetComponent<MeshCollider>();
				if (component4 != null)
				{
					component4.sharedMesh = UnityEngine.Object.Instantiate(m_colliderOriginal);
					component4.sharedMesh.name = m_colliderOriginal.name + " Deformed";
					colliderMesh = component4.sharedMesh;
				}
				int[] array = new int[CurvesPerMesh];
				for (int i = 0; i < CurvesPerMesh; i++)
				{
					array[i] = num + i;
				}
				ScaffoldWrapper scaffoldWrapper3 = new ScaffoldWrapper(gameObject.AddComponent<Scaffold>(), isRigid);
				scaffoldWrapper3.Wrap(component3.sharedMesh, colliderMesh, m_axis, array, m_sliceCount);
				Array.Resize(ref m_scaffolds, m_scaffolds.Length + 1);
				ShiftAndInsert(num, scaffoldWrapper3);
			}
			else
			{
				scaffoldWrapper = FindScaffold(base.CurveCount - 1);
				bool isRigid2 = false;
				if (scaffoldWrapper != null)
				{
					isRigid2 = scaffoldWrapper.IsRigid;
				}
				if (m_spacing > 0f)
				{
					AppendCurve(m_spacing, enforceNeighbour: true);
					ScaffoldWrapper scaffoldWrapper4 = new ScaffoldWrapper(null, isRigid2);
					scaffoldWrapper4.Wrap(null, null, Axis, new int[1] { base.CurveCount - 1 }, Approximation);
					Array.Resize(ref m_scaffolds, m_scaffolds.Length + 1);
					m_scaffolds[m_scaffolds.Length - 1] = scaffoldWrapper4;
				}
				float magnitude2 = (to - from).magnitude;
				AppendCurve(magnitude2, enforceNeighbour: false);
				MeshFilter component5 = gameObject.GetComponent<MeshFilter>();
				if (m_original != null)
				{
					component5.sharedMesh = UnityEngine.Object.Instantiate(m_original);
					component5.sharedMesh.name = m_original.name + " Deformed";
				}
				Mesh colliderMesh2 = null;
				MeshCollider component6 = gameObject.GetComponent<MeshCollider>();
				if (component6 != null)
				{
					component6.sharedMesh = UnityEngine.Object.Instantiate(m_colliderOriginal);
					component6.sharedMesh.name = m_colliderOriginal.name + " Deformed";
					colliderMesh2 = component6.sharedMesh;
				}
				int[] array2 = new int[CurvesPerMesh];
				for (int j = 0; j < CurvesPerMesh; j++)
				{
					array2[j] = base.CurveCount - CurvesPerMesh + j;
				}
				ScaffoldWrapper scaffoldWrapper5 = new ScaffoldWrapper(gameObject.AddComponent<Scaffold>(), isRigid2);
				scaffoldWrapper5.Wrap(component5.sharedMesh, colliderMesh2, m_axis, array2, m_sliceCount);
				Array.Resize(ref m_scaffolds, m_scaffolds.Length + 1);
				m_scaffolds[m_scaffolds.Length - 1] = scaffoldWrapper5;
				Deform(m_scaffolds.Length - 1);
				if (Loop)
				{
					Deform(0);
				}
			}
			if (scaffoldWrapper != null)
			{
				Deform(scaffoldWrapper);
			}
			return gameObject;
		}

		private void ForceRigid(ScaffoldWrapper scaffold)
		{
			if (scaffold != null && scaffold.IsRigid)
			{
				int curveIndex = scaffold.CurveIndices.Min();
				int pointIndex = scaffold.CurveIndices.Max() * 3 + 3;
				GetRigidPoints(pointIndex, curveIndex, out var points);
				SetPoints(curveIndex, points, ControlPointMode.Free, raiseCurveChanged: false);
			}
		}

		private void ShiftAndInsert(int curveIndex, ScaffoldWrapper newScaffold)
		{
			int delta = newScaffold.CurveIndices.Length;
			int num = ToScaffoldIndex(curveIndex);
			if (num == -1)
			{
				Deform(newScaffold);
				return;
			}
			for (int num2 = m_scaffolds.Length - 1; num2 > num; num2--)
			{
				m_scaffolds[num2] = m_scaffolds[num2 - 1];
			}
			m_scaffolds[num] = newScaffold;
			Deform(newScaffold);
			for (int num3 = m_scaffolds.Length - 1; num3 > num; num3--)
			{
				m_scaffolds[num3]?.Shift(delta);
			}
			for (int i = 0; i <= num; i++)
			{
				m_scaffolds[i]?.Deform(this, m_original, m_colliderOriginal);
			}
			if (Loop)
			{
				Deform(m_scaffolds.Length - 1);
				return;
			}
			for (int j = 0; j < m_scaffolds.Length; j++)
			{
				m_scaffolds[j].RecalculateNormals();
			}
			ScaffoldWrapper prev = null;
			for (int k = 0; k < m_scaffolds.Length; k++)
			{
				ScaffoldWrapper obj = m_scaffolds[k];
				obj.SlerpContacts(this, m_original, m_colliderOriginal, prev, null);
				prev = obj;
			}
		}

		private void AppendCurve(float mag, bool enforceNeighbour)
		{
			Vector3 vector = base.transform.InverseTransformDirection(GetDirection(1f));
			Vector3 point = GetPoint(1f);
			point = base.transform.InverseTransformPoint(point);
			int num = CurvesPerMesh * 3;
			float num2 = 1f / (float)num;
			float num3 = num2;
			Vector3[] array = new Vector3[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = point + vector * mag * num3;
				num3 += num2;
			}
			AppendCurve(array, enforceNeighbour);
		}

		private void PrependCurve(float mag, int curveIndex, bool enforceNeighbour)
		{
			Vector3 direction = GetDirection(0f, curveIndex);
			Vector3 point = GetPoint(0f, curveIndex);
			direction = base.transform.InverseTransformDirection(direction);
			point = base.transform.InverseTransformPoint(point);
			int num = CurvesPerMesh * 3;
			float num2 = 1f / (float)num;
			float num3 = 1f;
			Vector3[] array = new Vector3[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = point - direction * mag * num3;
				num3 -= num2;
			}
			PrependCurve(array, curveIndex, mag, enforceNeighbour);
		}

		public void Straighten(int pointIndex)
		{
			int num = (pointIndex - 1) / 3;
			ScaffoldWrapper scaffoldWrapper = FindScaffold(num);
			if (scaffoldWrapper == null)
			{
				throw new ArgumentOutOfRangeException("pointIndex");
			}
			if (scaffoldWrapper.IsEmptySpace)
			{
				UnityEngine.Debug.LogWarning("Unable to straighten empty space");
				return;
			}
			bool toLast = num == 0;
			float size = m_original.GetSize(m_axis);
			if (scaffoldWrapper != null)
			{
				for (int i = 0; i < scaffoldWrapper.CurveIndices.Length; i++)
				{
					AlignCurve(scaffoldWrapper.CurveIndices[i], size, toLast);
				}
			}
			for (int j = 0; j < m_scaffolds.Length; j++)
			{
				ScaffoldWrapper obj = m_scaffolds[j];
				obj.Deform(this, m_original, m_colliderOriginal);
				obj.RecalculateNormals();
			}
			ScaffoldWrapper prev = null;
			if (Loop)
			{
				prev = m_scaffolds[m_scaffolds.Length - 1];
			}
			for (int k = 0; k < m_scaffolds.Length; k++)
			{
				ScaffoldWrapper obj2 = m_scaffolds[k];
				obj2.SlerpContacts(this, m_original, m_colliderOriginal, prev, null);
				prev = obj2;
			}
		}

		public void SetIsRigid(int pointIndex, bool isRigid)
		{
			int num = pointIndex / 3;
			if (num == base.CurveCount)
			{
				num = ((!Loop) ? (num - 1) : 0);
			}
			ScaffoldWrapper scaffoldWrapper = FindScaffold(num);
			if (scaffoldWrapper == null)
			{
				throw new IndexOutOfRangeException("curveIndex");
			}
			if (isRigid)
			{
				GetRigidPoints(pointIndex, num, out var points);
				SetPoints(scaffoldWrapper.CurveIndices.Min(), points, ControlPointMode.Free, raiseCurveChanged: false);
				if (scaffoldWrapper.Scaffold != null)
				{
					scaffoldWrapper.Scaffold.Deform(this, m_original, m_colliderOriginal, isRigid: true);
					scaffoldWrapper.Scaffold.RecalculateNormals();
				}
			}
			else
			{
				Deform(scaffoldWrapper);
			}
			scaffoldWrapper.IsRigid = isRigid;
		}

		private void GetRigidPoints(int pointIndex, int curveIndex, out Vector3[] points)
		{
			ScaffoldWrapper scaffoldWrapper = FindScaffold(curveIndex);
			int num = scaffoldWrapper.CurveIndices.Min();
			int num2 = scaffoldWrapper.CurveIndices.Max();
			int num3 = num * 3;
			int num4 = num2 * 3 + 3;
			int num5 = (num4 - num3 + 1) / 2;
			bool flag;
			Vector3 normalized;
			Vector3 controlPointLocal;
			if (pointIndex - num3 < num5)
			{
				flag = false;
				normalized = (GetControlPointLocal(num3) - GetControlPointLocal(num4)).normalized;
				controlPointLocal = GetControlPointLocal(num4);
			}
			else
			{
				flag = true;
				normalized = (GetControlPointLocal(num4) - GetControlPointLocal(num3)).normalized;
				controlPointLocal = GetControlPointLocal(num3);
			}
			float magnitude = (GetControlPointLocal(num3) - GetControlPointLocal(num4)).magnitude;
			int num6 = num4 - num3 + 1;
			points = new Vector3[num6];
			float num7 = 1f / (float)(num6 - 1);
			float num8 = 0f;
			if (flag)
			{
				for (int i = 0; i < num6; i++)
				{
					points[i] = controlPointLocal + normalized * magnitude * num8;
					num8 += num7;
				}
				return;
			}
			for (int num9 = num6 - 1; num9 >= 0; num9--)
			{
				points[num9] = controlPointLocal + normalized * magnitude * num8;
				num8 += num7;
			}
		}

		public ScaffoldWrapper FindScaffold(int curveIndex)
		{
			return m_scaffolds.Where((ScaffoldWrapper s) => s?.CurveIndices.Any((int c) => c == curveIndex) ?? false).FirstOrDefault();
		}

		private int ToScaffoldIndex(int curveIndex)
		{
			ScaffoldWrapper scaffoldWrapper = m_scaffolds.Where((ScaffoldWrapper s) => s?.CurveIndices.Any((int c) => c >= curveIndex) ?? false).FirstOrDefault();
			if (scaffoldWrapper == null)
			{
				return -1;
			}
			return Array.IndexOf(m_scaffolds, scaffoldWrapper);
		}

		public static Vector3 Side(Axis axis)
		{
			return axis switch
			{
				Axis.Z => Vector3.forward, 
				Axis.X => Vector3.forward, 
				_ => Vector3.up, 
			};
		}

		public static Vector3 Up(Axis axis)
		{
			return axis switch
			{
				Axis.Z => Vector3.up, 
				Axis.X => Vector3.up, 
				_ => Vector3.back, 
			};
		}

		protected override void AddControlPointComponent(GameObject ctrlPoint)
		{
			ctrlPoint.AddComponent<ControlPoint>();
		}

		protected override SplineControlPoint[] GetControlPoints()
		{
			return GetComponentsInChildren<ControlPoint>(includeInactive: true);
		}
	}
	public class MeshDeformerRuntimeCmd : SplineRuntimeCmd
	{
		public override void Append()
		{
			if (SplineRuntimeEditor.Instance != null)
			{
				MeshDeformer meshDeformer = SplineRuntimeEditor.Instance.SelectedSpline as MeshDeformer;
				if (meshDeformer != null)
				{
					meshDeformer.Extend();
				}
				else
				{
					base.Append();
				}
			}
		}

		public override void Prepend()
		{
			if (SplineRuntimeEditor.Instance != null)
			{
				MeshDeformer meshDeformer = SplineRuntimeEditor.Instance.SelectedSpline as MeshDeformer;
				if (meshDeformer != null)
				{
					meshDeformer.Extend(prepend: true);
				}
				else
				{
					base.Prepend();
				}
			}
		}

		public override void Remove()
		{
			if (!(SplineRuntimeEditor.Instance != null))
			{
				return;
			}
			MeshDeformer meshDeformer = SplineRuntimeEditor.Instance.SelectedSpline as MeshDeformer;
			if (meshDeformer != null)
			{
				GameObject activeGameObject = RuntimeSelection.activeGameObject;
				if (activeGameObject != null)
				{
					SplineControlPoint component = activeGameObject.GetComponent<SplineControlPoint>();
					if (component != null)
					{
						meshDeformer.Remove((component.Index - 1) / 3);
					}
					RuntimeSelection.activeGameObject = meshDeformer.gameObject;
				}
			}
			else
			{
				base.Remove();
			}
		}

		public override void Smooth()
		{
			base.Smooth();
		}

		public override void SetMirroredMode()
		{
			base.SetMirroredMode();
		}

		public override void SetAlignedMode()
		{
			base.SetAlignedMode();
		}

		public override void SetFreeMode()
		{
			base.SetFreeMode();
		}

		public override void Load()
		{
			base.Load();
		}

		public override void Save()
		{
			base.Save();
		}
	}
	public enum Axis
	{
		X,
		Y,
		Z
	}
	[Serializable]
	public struct Contact
	{
		public int Index1;

		public int Index2;

		public Contact(int index1, int index2)
		{
			Index1 = index1;
			Index2 = index2;
		}
	}
	public class Vector3ToHash
	{
		private int m_hashCode;

		private Vector3 m_v;

		public Vector3ToHash(Vector3 v)
		{
			m_v = v;
			m_hashCode = new
			{
				x = Math.Round(v.x, 4),
				y = Math.Round(v.y, 4),
				z = Math.Round(v.z, 4)
			}.GetHashCode();
		}

		public override int GetHashCode()
		{
			return m_hashCode;
		}

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
			{
				return false;
			}
			return ((Vector3ToHash)obj).m_v == m_v;
		}
	}
	public static class MeshExtensions
	{
		public static Contact[] FindContacts(this Mesh mesh, Axis axis, float threshold = 0.999f)
		{
			mesh.GetBounds(axis, out var from, out var to);
			return mesh.FindContacts(from, to, axis, threshold);
		}

		public static Contact[] FindContacts(this Mesh mesh, Vector3 from, Vector3 to, Axis axis, float threshold = 0.999f)
		{
			Vector3[] vertices = mesh.vertices;
			Vector3[] normals = mesh.normals;
			Dictionary<Vector3ToHash, List<int>> dictionary = new Dictionary<Vector3ToHash, List<int>>(vertices.Length);
			for (int i = 0; i < vertices.Length; i++)
			{
				Vector3ToHash key = new Vector3ToHash(vertices[i]);
				if (!dictionary.ContainsKey(key))
				{
					dictionary.Add(key, new List<int>());
				}
				dictionary[key].Add(i);
			}
			List<Contact> list = new List<Contact>();
			Matrix4x4 matrix4x = Matrix4x4.TRS(to - from, Quaternion.identity, Vector3.one);
			for (int j = 0; j < vertices.Length; j++)
			{
				Vector3 lhs = normals[j];
				Vector3ToHash key2 = new Vector3ToHash(matrix4x.MultiplyPoint(vertices[j]));
				if (!dictionary.ContainsKey(key2))
				{
					continue;
				}
				List<int> list2 = dictionary[key2];
				for (int k = 0; k < list2.Count; k++)
				{
					int num = list2[k];
					Vector3 rhs = normals[num];
					if (Vector3.Dot(lhs, rhs) > threshold)
					{
						list.Add(new Contact(j, num));
					}
				}
			}
			return list.ToArray();
		}

		public static float GetSize(this Mesh mesh, Axis axis)
		{
			mesh.GetBounds(axis, out var from, out var to);
			return (to - from).magnitude;
		}

		public static void GetBounds(this Mesh mesh, Axis axis, out Vector3 from, out Vector3 to)
		{
			if (mesh == null)
			{
				from = new Vector3(-0.5f, -0.5f, -0.5f);
				to = new Vector3(0.5f, 0.5f, 0.5f);
			}
			else
			{
				Bounds bounds = mesh.bounds;
				from = bounds.center - bounds.extents;
				to = bounds.center + bounds.extents;
			}
			switch (axis)
			{
			case Axis.X:
				from.y = (to.y = 0f);
				from.z = (to.z = 0f);
				break;
			case Axis.Y:
				from.x = (to.x = 0f);
				from.z = (to.z = 0f);
				break;
			case Axis.Z:
				from.x = (to.x = 0f);
				from.y = (to.y = 0f);
				break;
			}
		}
	}
	public class MeshSubdivider : MonoBehaviour
	{
		private static List<Vector3> vertices;

		private static List<Vector3> normals;

		private static List<Vector4> tangents;

		private static List<Color> colors;

		private static List<Vector2> uv;

		private static List<Vector2> uv2;

		private static List<Vector2> uv3;

		private static List<Vector2> uv4;

		private static List<int> indices;

		private static Dictionary<uint, int> newVectices;

		private static void InitArrays(Mesh mesh)
		{
			vertices = new List<Vector3>(mesh.vertices);
			normals = new List<Vector3>(mesh.normals);
			tangents = new List<Vector4>(mesh.tangents);
			colors = new List<Color>(mesh.colors);
			uv = new List<Vector2>(mesh.uv);
			uv2 = new List<Vector2>(mesh.uv2);
			uv3 = new List<Vector2>(mesh.uv3);
			uv4 = new List<Vector2>(mesh.uv4);
			indices = new List<int>();
		}

		private static void CleanUp()
		{
			vertices = null;
			normals = null;
			colors = null;
			uv = null;
			uv2 = null;
			uv3 = null;
			uv4 = null;
			indices = null;
		}

		private static int GetNewVertex4(int i1, int i2)
		{
			int count = vertices.Count;
			uint key = (uint)((i1 << 16) | i2);
			uint key2 = (uint)((i2 << 16) | i1);
			if (newVectices.ContainsKey(key2))
			{
				return newVectices[key2];
			}
			if (newVectices.ContainsKey(key))
			{
				return newVectices[key];
			}
			newVectices.Add(key, count);
			vertices.Add((vertices[i1] + vertices[i2]) * 0.5f);
			if (normals.Count > 0)
			{
				normals.Add((normals[i1] + normals[i2]).normalized);
			}
			if (tangents.Count > 0)
			{
				Vector4 normalized = Vector4.Lerp(tangents[i1], tangents[i2], 0.5f).normalized;
				normalized.w = Mathf.Lerp(tangents[i1].w, tangents[i2].w, 0.5f);
				tangents.Add(normalized);
			}
			if (colors.Count > 0)
			{
				colors.Add((colors[i1] + colors[i2]) * 0.5f);
			}
			if (uv.Count > 0)
			{
				uv.Add((uv[i1] + uv[i2]) * 0.5f);
			}
			if (uv2.Count > 0)
			{
				uv2.Add((uv2[i1] + uv2[i2]) * 0.5f);
			}
			if (uv3.Count > 0)
			{
				uv3.Add((uv3[i1] + uv3[i2]) * 0.5f);
			}
			if (uv4.Count > 0)
			{
				uv4.Add((uv4[i1] + uv4[i2]) * 0.5f);
			}
			return count;
		}

		private static void Subdivide4Submesh(Mesh mesh)
		{
			newVectices = new Dictionary<uint, int>();
			InitArrays(mesh);
			int[] triangles = mesh.triangles;
			for (int i = 0; i < triangles.Length; i += 3)
			{
				int num = triangles[i];
				int num2 = triangles[i + 1];
				int num3 = triangles[i + 2];
				int newVertex = GetNewVertex4(num, num2);
				int newVertex2 = GetNewVertex4(num2, num3);
				int newVertex3 = GetNewVertex4(num3, num);
				indices.Add(num);
				indices.Add(newVertex);
				indices.Add(newVertex3);
				indices.Add(num2);
				indices.Add(newVertex2);
				indices.Add(newVertex);
				indices.Add(num3);
				indices.Add(newVertex3);
				indices.Add(newVertex2);
				indices.Add(newVertex);
				indices.Add(newVertex2);
				indices.Add(newVertex3);
			}
			mesh.vertices = vertices.ToArray();
			if (normals.Count > 0)
			{
				mesh.normals = normals.ToArray();
			}
			if (tangents.Count > 0)
			{
				mesh.tangents = tangents.ToArray();
			}
			if (colors.Count > 0)
			{
				mesh.colors = colors.ToArray();
			}
			if (uv.Count > 0)
			{
				mesh.uv = uv.ToArray();
			}
			if (uv2.Count > 0)
			{
				mesh.uv2 = uv2.ToArray();
			}
			if (uv3.Count > 0)
			{
				mesh.uv3 = uv3.ToArray();
			}
			if (uv4.Count > 0)
			{
				mesh.uv4 = uv4.ToArray();
			}
			mesh.triangles = indices.ToArray();
			CleanUp();
		}

		private static int GetNewVertex9(int i1, int i2, int i3)
		{
			int count = vertices.Count;
			if (i3 == i1 || i3 == i2)
			{
				uint key = (uint)((i1 << 16) | i2);
				if (newVectices.ContainsKey(key))
				{
					return newVectices[key];
				}
				newVectices.Add(key, count);
			}
			vertices.Add((vertices[i1] + vertices[i2] + vertices[i3]) / 3f);
			if (normals.Count > 0)
			{
				normals.Add((normals[i1] + normals[i2] + normals[i3]).normalized);
			}
			if (tangents.Count > 0)
			{
				Vector4 normalized = Vector4.Lerp(Vector4.Lerp(tangents[i1], tangents[i2], 0.5f), tangents[i3], 0.5f).normalized;
				normalized.w = (tangents[i1].w + tangents[i2].w + tangents[i3].w) / 3f;
				tangents.Add(normalized);
			}
			if (colors.Count > 0)
			{
				colors.Add((colors[i1] + colors[i2] + colors[i3]) / 3f);
			}
			if (uv.Count > 0)
			{
				uv.Add((uv[i1] + uv[i2] + uv[i3]) / 3f);
			}
			if (uv2.Count > 0)
			{
				uv2.Add((uv2[i1] + uv2[i2] + uv2[i3]) / 3f);
			}
			if (uv3.Count > 0)
			{
				uv3.Add((uv3[i1] + uv3[i2] + uv3[i3]) / 3f);
			}
			if (uv4.Count > 0)
			{
				uv4.Add((uv4[i1] + uv4[i2] + uv4[i3]) / 3f);
			}
			return count;
		}

		private static void Subdivide9Submesh(Mesh mesh)
		{
			newVectices = new Dictionary<uint, int>();
			InitArrays(mesh);
			int[] triangles = mesh.triangles;
			for (int i = 0; i < triangles.Length; i += 3)
			{
				int num = triangles[i];
				int num2 = triangles[i + 1];
				int num3 = triangles[i + 2];
				int newVertex = GetNewVertex9(num, num2, num);
				int newVertex2 = GetNewVertex9(num2, num, num2);
				int newVertex3 = GetNewVertex9(num2, num3, num2);
				int newVertex4 = GetNewVertex9(num3, num2, num3);
				int newVertex5 = GetNewVertex9(num3, num, num3);
				int newVertex6 = GetNewVertex9(num, num3, num);
				int newVertex7 = GetNewVertex9(num, num2, num3);
				indices.Add(num);
				indices.Add(newVertex);
				indices.Add(newVertex6);
				indices.Add(num2);
				indices.Add(newVertex3);
				indices.Add(newVertex2);
				indices.Add(num3);
				indices.Add(newVertex5);
				indices.Add(newVertex4);
				indices.Add(newVertex7);
				indices.Add(newVertex);
				indices.Add(newVertex2);
				indices.Add(newVertex7);
				indices.Add(newVertex3);
				indices.Add(newVertex4);
				indices.Add(newVertex7);
				indices.Add(newVertex5);
				indices.Add(newVertex6);
				indices.Add(newVertex7);
				indices.Add(newVertex6);
				indices.Add(newVertex);
				indices.Add(newVertex7);
				indices.Add(newVertex2);
				indices.Add(newVertex3);
				indices.Add(newVertex7);
				indices.Add(newVertex4);
				indices.Add(newVertex5);
			}
			mesh.vertices = vertices.ToArray();
			if (normals.Count > 0)
			{
				mesh.normals = normals.ToArray();
			}
			if (tangents.Count > 0)
			{
				mesh.tangents = tangents.ToArray();
			}
			if (colors.Count > 0)
			{
				mesh.colors = colors.ToArray();
			}
			if (uv.Count > 0)
			{
				mesh.uv = uv.ToArray();
			}
			if (uv2.Count > 0)
			{
				mesh.uv2 = uv2.ToArray();
			}
			if (uv3.Count > 0)
			{
				mesh.uv3 = uv3.ToArray();
			}
			if (uv4.Count > 0)
			{
				mesh.uv4 = uv4.ToArray();
			}
			mesh.triangles = indices.ToArray();
			CleanUp();
		}

		private static void SubdivideSubmesh(Mesh mesh, int level)
		{
			if (level < 2)
			{
				return;
			}
			while (level > 1)
			{
				while (level % 3 == 0)
				{
					Subdivide9Submesh(mesh);
					level /= 3;
				}
				while (level % 2 == 0)
				{
					Subdivide4Submesh(mesh);
					level /= 2;
				}
				if (level > 3)
				{
					level++;
				}
			}
		}

		private static Mesh Subdivide(Mesh originalMesh, Action<Mesh> subdivideAction)
		{
			if (originalMesh.subMeshCount == 1)
			{
				Mesh mesh = DuplicateMesh(originalMesh);
				subdivideAction(mesh);
				return mesh;
			}
			CombineInstance[] array = new CombineInstance[originalMesh.subMeshCount];
			for (int i = 0; i < originalMesh.subMeshCount; i++)
			{
				CombineInstance combineInstance = default(CombineInstance);
				Mesh mesh2 = ExtractSubmesh(originalMesh, i);
				subdivideAction(mesh2);
				combineInstance.mesh = mesh2;
				combineInstance.transform = Matrix4x4.identity;
				combineInstance.subMeshIndex = 0;
				array[i] = combineInstance;
			}
			Mesh mesh3 = new Mesh();
			mesh3.CombineMeshes(array, mergeSubMeshes: false);
			return mesh3;
		}

		public static Mesh Subdivide4(Mesh originalMesh)
		{
			return Subdivide(originalMesh, delegate(Mesh m)
			{
				Subdivide4Submesh(m);
			});
		}

		public static Mesh Subdivide9(Mesh originalMesh)
		{
			return Subdivide(originalMesh, delegate(Mesh m)
			{
				Subdivide9Submesh(m);
			});
		}

		public static Mesh Subdivide(Mesh originalMesh, int level)
		{
			return Subdivide(originalMesh, delegate(Mesh m)
			{
				SubdivideSubmesh(m, level);
			});
		}

		public static Mesh DuplicateMesh(Mesh mesh)
		{
			return UnityEngine.Object.Instantiate(mesh);
		}

		public static Mesh ExtractSubmesh(Mesh mesh, int submeshIndex)
		{
			MeshTopology topology = mesh.GetTopology(submeshIndex);
			if (topology != 0)
			{
				UnityEngine.Debug.LogWarningFormat("Extract Submesh method could handle triangle topology only. Current topology is {0}. Mesh name {1} submeshIndex {2}", topology, mesh, submeshIndex);
				return mesh;
			}
			int[] triangles = mesh.GetTriangles(submeshIndex);
			int[] array = new int[triangles.Length];
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			int num = 0;
			for (int i = 0; i < triangles.Length; i++)
			{
				int key = triangles[i];
				if (!dictionary.ContainsKey(key))
				{
					array[i] = num;
					dictionary.Add(key, num);
					num++;
				}
				else
				{
					array[i] = dictionary[key];
				}
			}
			Vector3[] array2 = mesh.vertices;
			Vector3[] array3 = new Vector3[num];
			foreach (KeyValuePair<int, int> item in dictionary)
			{
				array3[item.Value] = array2[item.Key];
			}
			Mesh mesh2 = new Mesh();
			mesh2.vertices = array3;
			Color[] array4 = mesh.colors;
			if (array4.Length == array2.Length)
			{
				Color[] array5 = new Color[num];
				foreach (KeyValuePair<int, int> item2 in dictionary)
				{
					array5[item2.Value] = array4[item2.Key];
				}
				mesh2.colors = array5;
			}
			else if (array4.Length != 0)
			{
				UnityEngine.Debug.LogWarning("colors.Length != vertices.Length");
			}
			Color32[] colors = mesh.colors32;
			if (colors.Length == array2.Length)
			{
				Color32[] array6 = new Color32[num];
				foreach (KeyValuePair<int, int> item3 in dictionary)
				{
					array6[item3.Value] = colors[item3.Key];
				}
				mesh2.colors32 = array6;
			}
			else if (colors.Length != 0)
			{
				UnityEngine.Debug.LogWarning("colors32.Length != vertices.Length");
			}
			BoneWeight[] boneWeights = mesh.boneWeights;
			if (boneWeights.Length == array2.Length)
			{
				BoneWeight[] array7 = new BoneWeight[num];
				foreach (KeyValuePair<int, int> item4 in dictionary)
				{
					array7[item4.Value] = boneWeights[item4.Key];
				}
				mesh2.boneWeights = array7;
			}
			else if (boneWeights.Length != 0)
			{
				UnityEngine.Debug.LogWarning("boneWeights.Length != vertices.Length");
			}
			Vector3[] array8 = mesh.normals;
			if (array8.Length == array2.Length)
			{
				Vector3[] array9 = new Vector3[num];
				foreach (KeyValuePair<int, int> item5 in dictionary)
				{
					array9[item5.Value] = array8[item5.Key];
				}
				mesh2.normals = array9;
			}
			else if (array8.Length != 0)
			{
				UnityEngine.Debug.LogWarning("normals.Length != vertices.Length");
			}
			Vector4[] array10 = mesh.tangents;
			if (array10.Length == array2.Length)
			{
				Vector4[] array11 = new Vector4[num];
				foreach (KeyValuePair<int, int> item6 in dictionary)
				{
					array11[item6.Value] = array10[item6.Key];
				}
				mesh2.tangents = array11;
			}
			else if (array10.Length != 0)
			{
				UnityEngine.Debug.LogWarning("tangents.Length != vertices.Length");
			}
			Vector2[] array12 = mesh.uv;
			if (array12.Length == array2.Length)
			{
				Vector2[] array13 = new Vector2[num];
				foreach (KeyValuePair<int, int> item7 in dictionary)
				{
					array13[item7.Value] = array12[item7.Key];
				}
				mesh2.uv = array13;
			}
			else if (array12.Length != 0)
			{
				UnityEngine.Debug.LogWarning("uv.Length != vertices.Length");
			}
			Vector2[] array14 = mesh.uv2;
			if (array14.Length == array2.Length)
			{
				Vector2[] array15 = new Vector2[num];
				foreach (KeyValuePair<int, int> item8 in dictionary)
				{
					array15[item8.Value] = array14[item8.Key];
				}
				mesh2.uv2 = array15;
			}
			else if (array14.Length != 0)
			{
				UnityEngine.Debug.LogWarning("uv2.Length != vertices.Length");
			}
			Vector2[] array16 = mesh.uv3;
			if (array16.Length == array2.Length)
			{
				Vector2[] array17 = new Vector2[num];
				foreach (KeyValuePair<int, int> item9 in dictionary)
				{
					array17[item9.Value] = array16[item9.Key];
				}
				mesh2.uv3 = array17;
			}
			else if (array16.Length != 0)
			{
				UnityEngine.Debug.LogWarning("uv3.Length != vertices.Length");
			}
			Vector2[] array18 = mesh.uv4;
			if (array18.Length == array2.Length)
			{
				Vector2[] array19 = new Vector2[num];
				foreach (KeyValuePair<int, int> item10 in dictionary)
				{
					array19[item10.Value] = array18[item10.Key];
				}
				mesh2.uv4 = array19;
			}
			else if (array18.Length != 0)
			{
				UnityEngine.Debug.LogWarning("uv4.Length != vertices.Length");
			}
			mesh2.triangles = array;
			return mesh2;
		}
	}
	[Serializable]
	public class Slice
	{
		[SerializeField]
		private Vector3 m_center;

		[SerializeField]
		private int m_curveIndex;

		[SerializeField]
		private float m_t;

		[SerializeField]
		private int[] m_indices;

		public Vector3 Center => m_center;

		public int CurveIndex
		{
			get
			{
				return m_curveIndex;
			}
			set
			{
				m_curveIndex = value;
			}
		}

		public float T => m_t;

		public int[] Indices => m_indices;

		public Slice(Vector3 center, int curveIndex, float t, int[] vertexIndices)
		{
			m_center = center;
			m_curveIndex = curveIndex;
			m_t = Mathf.Clamp01(t);
			m_indices = vertexIndices;
		}
	}
	[ExecuteInEditMode]
	public class Scaffold : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		private Slice[] m_slices;

		[SerializeField]
		[HideInInspector]
		private Slice[] m_colliderSlices;

		[SerializeField]
		private Mesh m_mesh;

		[SerializeField]
		[HideInInspector]
		private Mesh m_colliderMesh;

		[SerializeField]
		[HideInInspector]
		private Vector3 m_up;

		[SerializeField]
		[HideInInspector]
		private Quaternion m_axisRotation;

		[SerializeField]
		[HideInInspector]
		private MeshDeformer m_deformer;

		[SerializeField]
		[HideInInspector]
		private int m_instanceId;

		[SerializeField]
		[HideInInspector]
		private bool m_initialized;

		[SerializeField]
		[HideInInspector]
		private MeshCollider m_collider;

		public int InstanceId => m_instanceId;

		public int SliceCount
		{
			get
			{
				if (m_slices != null)
				{
					return m_slices.Length;
				}
				return 0;
			}
		}

		private void Awake()
		{
			if (!m_initialized)
			{
				m_instanceId = GetInstanceID();
				m_initialized = true;
			}
			m_deformer = GetComponentInParent<MeshDeformer>();
			m_collider = GetComponent<MeshCollider>();
		}

		private void Start()
		{
			if (m_deformer == null)
			{
				m_deformer = GetComponentInParent<MeshDeformer>();
			}
		}

		public void Shift(int delta)
		{
			for (int i = 0; i < m_slices.Length; i++)
			{
				m_slices[i].CurveIndex += delta;
				m_colliderSlices[i].CurveIndex += delta;
			}
		}

		public void Wrap(Mesh mesh, Mesh colliderMesh, Axis axis, int[] curveIndices, int sliceCount)
		{
			m_collider = GetComponent<MeshCollider>();
			if (curveIndices.Length < 1)
			{
				throw new ArgumentException("at least one curveIndex required", "curveIndices");
			}
			m_up = MeshDeformer.Up(axis);
			switch (axis)
			{
			case Axis.Z:
				m_axisRotation = Quaternion.identity;
				break;
			case Axis.X:
				m_axisRotation = Quaternion.AngleAxis(-90f, Vector3.up);
				break;
			default:
				m_axisRotation = Quaternion.AngleAxis(90f, Vector3.right);
				break;
			}
			if (mesh == null)
			{
				m_mesh = null;
				m_colliderMesh = null;
				m_slices = new Slice[curveIndices.Length * (sliceCount + 1)];
				m_colliderSlices = new Slice[curveIndices.Length * (sliceCount + 1)];
				for (int i = 0; i < m_slices.Length; i++)
				{
					m_slices[i] = new Slice(Vector3.zero, -1, 0f, new int[0]);
					m_colliderSlices[i] = new Slice(Vector3.zero, -1, 0f, new int[0]);
				}
				return;
			}
			sliceCount = Math.Max(sliceCount / curveIndices.Length, 1);
			mesh.GetBounds(axis, out var from, out var to);
			m_mesh = mesh;
			m_slices = CreateSlices(m_mesh, from, to, axis, curveIndices, sliceCount);
			if (colliderMesh == null)
			{
				m_colliderMesh = null;
				m_colliderSlices = new Slice[curveIndices.Length * (sliceCount + 1)];
				for (int j = 0; j < m_colliderSlices.Length; j++)
				{
					m_colliderSlices[j] = new Slice(Vector3.zero, -1, 0f, new int[0]);
				}
			}
			else
			{
				m_colliderMesh = colliderMesh;
				m_colliderSlices = CreateSlices(m_colliderMesh, from, to, axis, curveIndices, sliceCount);
			}
		}

		private Slice[] CreateSlices(Mesh mesh, Vector3 boundsFrom, Vector3 boundsTo, Axis axis, int[] curveIndices, int sliceCount)
		{
			Slice[] array = new Slice[curveIndices.Length * (sliceCount + 1)];
			Vector3[] vertices = mesh.vertices;
			List<int>[,] array2 = new List<int>[curveIndices.Length, sliceCount + 1];
			for (int i = 0; i < curveIndices.Length; i++)
			{
				for (int j = 0; j <= sliceCount; j++)
				{
					array2[i, j] = new List<int>(vertices.Length / array.Length);
				}
			}
			Vector3 vector = (boundsTo - boundsFrom) / curveIndices.Length;
			for (int k = 0; k < vertices.Length; k++)
			{
				Vector3 vector2 = vertices[k];
				int num = -1;
				int num2 = -1;
				float num3 = float.MaxValue;
				Vector3 vector3 = boundsFrom;
				for (int l = 0; l < curveIndices.Length; l++)
				{
					float num4 = 0f;
					for (int m = 0; m <= sliceCount; m++)
					{
						Vector3 vector4 = Vector3.Lerp(vector3, vector3 + vector, num4);
						float sqrMagnitude = (vector2 - vector4).sqrMagnitude;
						if (sqrMagnitude < num3)
						{
							num3 = sqrMagnitude;
							num = l;
							num2 = m;
						}
						num4 += 1f / (float)sliceCount;
					}
					vector3 += vector;
				}
				array2[num, num2].Add(k);
			}
			Vector3 vector5 = boundsFrom;
			for (int n = 0; n < curveIndices.Length; n++)
			{
				int curveIndex = curveIndices[n];
				float num5 = 0f;
				for (int num6 = 0; num6 <= sliceCount; num6++)
				{
					array[n * (sliceCount + 1) + num6] = new Slice(Vector3.Lerp(vector5, vector5 + vector, num5), curveIndex, num5, array2[n, num6].ToArray());
					num5 += 1f / (float)sliceCount;
				}
				vector5 += vector;
			}
			return array;
		}

		public void RecalculateNormals()
		{
			if (m_mesh != null)
			{
				m_mesh.RecalculateNormals();
			}
			if (m_colliderMesh != null && m_collider != null)
			{
				m_colliderMesh.RecalculateNormals();
				m_collider.sharedMesh = null;
				m_collider.sharedMesh = m_colliderMesh;
			}
		}

		public void Deform(MeshDeformer deformer, Mesh original, Mesh colliderOriginal, bool isRigid)
		{
			if (original != null)
			{
				m_mesh.vertices = Deform(m_slices, original, deformer, isRigid);
				m_mesh.RecalculateBounds();
			}
			if (colliderOriginal != null && m_collider != null)
			{
				m_colliderMesh.vertices = Deform(m_colliderSlices, colliderOriginal, deformer, isRigid);
				m_colliderMesh.RecalculateBounds();
				m_collider.sharedMesh = null;
				m_collider.sharedMesh = m_colliderMesh;
			}
		}

		private Vector3[] Deform(Slice[] slices, Mesh mesh, MeshDeformer deformer, bool isRigid)
		{
			Vector3[] vertices = mesh.vertices;
			foreach (Slice slice in slices)
			{
				Vector3 point = deformer.GetPoint(slice.T, slice.CurveIndex);
				point = deformer.transform.InverseTransformPoint(point);
				Vector3 vector = deformer.transform.InverseTransformVector(deformer.GetDirection(slice.T, slice.CurveIndex));
				float t = slice.T;
				if (isRigid)
				{
					t = 1f;
				}
				float twist = deformer.GetTwist(t, slice.CurveIndex);
				Vector3 thickness = deformer.GetThickness(t, slice.CurveIndex);
				if (!(vector == Vector3.zero))
				{
					Quaternion q = Quaternion.AngleAxis(twist, vector) * Quaternion.LookRotation(vector, m_up) * m_axisRotation;
					Matrix4x4 matrix4x = Matrix4x4.TRS(point, q, Vector3.one);
					int[] indices = slice.Indices;
					foreach (int num in indices)
					{
						Vector3 vertex = vertices[num];
						vertex = AxisTransform(deformer, vertex, slice.Center, thickness);
						vertex = matrix4x.MultiplyPoint(vertex);
						vertices[num] = vertex;
					}
				}
			}
			return vertices;
		}

		public void SlerpContacts(MeshDeformer deformer, Mesh original, Mesh colliderOriginal, Scaffold prev, Scaffold next, bool isRigid)
		{
			if (isRigid)
			{
				return;
			}
			Mesh prevMesh = null;
			Mesh nextMesh = null;
			if (prev != null)
			{
				prevMesh = prev.m_mesh;
			}
			if (next != null)
			{
				nextMesh = next.m_mesh;
			}
			SlerpContacts(deformer, m_mesh, deformer.Contacts, prev, prevMesh, next, nextMesh);
			if (!(colliderOriginal == null))
			{
				if (prev != null)
				{
					prevMesh = prev.m_colliderMesh;
				}
				if (next != null)
				{
					nextMesh = next.m_colliderMesh;
				}
				SlerpContacts(deformer, m_colliderMesh, deformer.ColliderContacts, prev, prevMesh, next, nextMesh);
				if (m_collider != null)
				{
					m_collider.sharedMesh = null;
					m_collider.sharedMesh = m_colliderMesh;
				}
			}
		}

		private void SlerpContacts(MeshDeformer deformer, Mesh mesh, Contact[] contacts, Scaffold prev, Mesh prevMesh, Scaffold next, Mesh nextMesh)
		{
			Vector3[] array = null;
			Vector3[] array2 = null;
			Vector3[] array3 = null;
			if (mesh == null)
			{
				return;
			}
			if (prev != null || next != null)
			{
				array = mesh.normals;
			}
			if (prevMesh != null && prev != null && (prev != this || (m_deformer.Scaffolds.Length == 1 && m_deformer.Loop)))
			{
				array2 = prevMesh.normals;
				for (int i = 0; i < contacts.Length; i++)
				{
					Contact contact = contacts[i];
					Vector3 a = array2[contact.Index2];
					Vector3 b = array[contact.Index1];
					Vector3 vector = Vector3.Slerp(a, b, 0.5f);
					array2[contact.Index2] = vector;
					array[contact.Index1] = vector;
				}
			}
			if (nextMesh != null && next != null && (next != this || (m_deformer.Scaffolds.Length == 1 && m_deformer.Loop)))
			{
				array3 = nextMesh.normals;
				for (int j = 0; j < contacts.Length; j++)
				{
					Contact contact2 = contacts[j];
					Vector3 a2 = array[contact2.Index2];
					Vector3 b2 = array3[contact2.Index1];
					Vector3 vector2 = Vector3.Slerp(a2, b2, 0.5f);
					array[contact2.Index2] = vector2;
					array3[contact2.Index1] = vector2;
				}
			}
			if (prev != null)
			{
				if (mesh != null)
				{
					mesh.normals = array;
				}
				if (this != prev && prevMesh != null)
				{
					prevMesh.normals = array2;
				}
				if (next != null && next != prev && nextMesh != null)
				{
					nextMesh.normals = array3;
				}
			}
			else if (next != null)
			{
				if (mesh != null)
				{
					mesh.normals = array;
				}
				if (prev != null && prev != next && prevMesh != null)
				{
					prevMesh.normals = array2;
				}
				if (this != next && nextMesh != null)
				{
					nextMesh.normals = array3;
				}
			}
		}

		private static Vector3 AxisTransform(MeshDeformer deformer, Vector3 vertex, Vector3 center, Vector3 scale)
		{
			Vector3 a = vertex - center;
			if (deformer.Axis == Axis.X)
			{
				a.x = 0f;
				center.x = vertex.x - center.x;
			}
			else if (deformer.Axis == Axis.Y)
			{
				a.y = 0f;
				center.y = vertex.y - center.y;
			}
			else
			{
				a.z = 0f;
				center.z = vertex.z - center.z;
			}
			return center + Vector3.Scale(a, scale);
		}
	}
	[Serializable]
	public class ScaffoldWrapper
	{
		[SerializeField]
		private bool m_isRigid;

		[SerializeField]
		private int[] m_curveIndices;

		[SerializeField]
		private Scaffold m_scaffold;

		[SerializeField]
		private int m_instanceId;

		[SerializeField]
		private bool m_isEmptySpace;

		public Scaffold Scaffold => m_scaffold;

		public bool IsRigid
		{
			get
			{
				return m_isRigid;
			}
			set
			{
				m_isRigid = value;
			}
		}

		public int[] CurveIndices
		{
			get
			{
				return m_curveIndices;
			}
			set
			{
				m_curveIndices = value;
			}
		}

		public int SliceCount
		{
			get
			{
				if (!(m_scaffold == null))
				{
					return m_scaffold.SliceCount;
				}
				return 0;
			}
		}

		public int ObjInstanceId => m_instanceId;

		public Scaffold Obj
		{
			get
			{
				return m_scaffold;
			}
			set
			{
				m_scaffold = value;
			}
		}

		public bool IsEmptySpace => m_isEmptySpace;

		public ScaffoldWrapper()
		{
		}

		public ScaffoldWrapper(Scaffold scaffold, bool isRigid)
		{
			m_isRigid = isRigid;
			if (scaffold == null)
			{
				m_isEmptySpace = true;
				return;
			}
			m_scaffold = scaffold;
			m_instanceId = scaffold.GetInstanceID();
		}

		public void Wrap(Mesh mesh, Mesh colliderMesh, Axis axis, int[] curveIndices, int sliceCount)
		{
			m_curveIndices = curveIndices;
			if (m_scaffold != null)
			{
				m_scaffold.Wrap(mesh, colliderMesh, axis, curveIndices, sliceCount);
			}
		}

		public void Shift(int delta)
		{
			for (int i = 0; i < m_curveIndices.Length; i++)
			{
				m_curveIndices[i] += delta;
			}
			if (m_scaffold != null)
			{
				m_scaffold.Shift(delta);
			}
		}

		public void RecalculateNormals()
		{
			if (m_scaffold != null)
			{
				m_scaffold.RecalculateNormals();
			}
		}

		public void Deform(MeshDeformer deformer, Mesh original, Mesh colliderOriginal)
		{
			if (m_scaffold != null)
			{
				m_scaffold.Deform(deformer, original, colliderOriginal, m_isRigid);
			}
		}

		public void SlerpContacts(MeshDeformer deformer, Mesh original, Mesh colliderOriginal, ScaffoldWrapper prev, ScaffoldWrapper next)
		{
			if (m_isRigid || !(m_scaffold != null))
			{
				return;
			}
			Scaffold prev2 = null;
			if (prev != null)
			{
				int index = prev.CurveIndices.Max() * 3 + 3;
				if (deformer.GetControlPointMode(index) != 0)
				{
					prev2 = prev.Obj;
				}
			}
			Scaffold next2 = null;
			if (next != null)
			{
				int index2 = next.CurveIndices.Min() * 3;
				if (deformer.GetControlPointMode(index2) != 0)
				{
					next2 = next.Obj;
				}
			}
			m_scaffold.SlerpContacts(deformer, original, colliderOriginal, prev2, next2, m_isRigid);
		}
	}
}
namespace Battlehub.MeshTools
{
	public class MeshTransform
	{
		public Mesh Mesh;

		public Matrix4x4 Transform;

		public MeshTransform(Mesh mesh, Matrix4x4 transform)
		{
			Mesh = mesh;
			Transform = transform;
		}
	}
	public class CombineResult
	{
		public GameObject GameObject;

		public Mesh Mesh;

		public CombineResult(GameObject gameObject, Mesh mesh)
		{
			GameObject = gameObject;
			Mesh = mesh;
		}
	}
	public static class MeshUtils
	{
		public static CombineResult Combine(GameObject[] gameObjects, GameObject target = null)
		{
			if (gameObjects == null)
			{
				throw new ArgumentNullException("gameObjects");
			}
			if (gameObjects.Length == 0)
			{
				return null;
			}
			if (target == null)
			{
				target = gameObjects[0];
			}
			Transform[] array = new Transform[gameObjects.Length];
			for (int i = 0; i < gameObjects.Length; i++)
			{
				GameObject gameObject = gameObjects[i];
				array[i] = gameObject.transform.parent;
				gameObject.transform.SetParent(null, worldPositionStays: true);
			}
			GameObject gameObject2 = UnityEngine.Object.Instantiate(target);
			DestroyChildren(gameObject2);
			Collider[] components = gameObject2.GetComponents<Collider>();
			foreach (Collider obj in components)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(obj);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(obj);
				}
			}
			Matrix4x4 matrix4x = Matrix4x4.TRS(Vector3.zero, target.transform.rotation, target.transform.localScale);
			Matrix4x4 worldToLocalMatrix = gameObject2.transform.worldToLocalMatrix;
			List<MeshFilter> list = new List<MeshFilter>();
			List<SkinnedMeshRenderer> list2 = new List<SkinnedMeshRenderer>();
			GameObject[] array2 = gameObjects;
			foreach (GameObject obj2 in array2)
			{
				MeshFilter[] components2 = obj2.GetComponents<MeshFilter>();
				list.AddRange(components2);
				SkinnedMeshRenderer[] components3 = obj2.GetComponents<SkinnedMeshRenderer>();
				list2.AddRange(components3);
			}
			target.SetActive(value: false);
			List<CombineInstance> list3 = new List<CombineInstance>();
			array2 = gameObjects;
			foreach (GameObject gameObject3 in array2)
			{
				List<Mesh> colliderMeshes = GetColliderMeshes(gameObject3);
				for (int k = 0; k < colliderMeshes.Count; k++)
				{
					Mesh mesh = colliderMeshes[k];
					CombineInstance item = default(CombineInstance);
					item.mesh = mesh;
					item.transform = worldToLocalMatrix * gameObject3.transform.localToWorldMatrix;
					list3.Add(item);
				}
			}
			string text = (gameObject2.name = target.name);
			if (list3.Count != 0)
			{
				Mesh mesh2 = new Mesh();
				mesh2.CombineMeshes(list3.ToArray());
				CombineInstance[] array3 = new CombineInstance[1];
				array3[0].mesh = mesh2;
				array3[0].transform = matrix4x;
				Mesh mesh3 = new Mesh();
				mesh3.name = text + "Collider";
				mesh3.CombineMeshes(array3);
				MeshCollider meshCollider = gameObject2.AddComponent<MeshCollider>();
				Rigidbody component = gameObject2.GetComponent<Rigidbody>();
				if (component != null)
				{
					meshCollider.sharedMesh = mesh3;
					if (!component.isKinematic)
					{
						meshCollider.convex = true;
					}
				}
				else
				{
					meshCollider.sharedMesh = mesh3;
				}
			}
			CombineInstance[] combineInstances;
			Material[] materials;
			bool flag = BuildCombineInstance(worldToLocalMatrix, list, list2, out combineInstances, out materials);
			Mesh mesh4 = new Mesh();
			mesh4.name = text;
			mesh4.CombineMeshes(combineInstances, flag);
			Mesh mesh5 = RemoveRotation(mesh4, matrix4x, flag);
			mesh5.name = text;
			gameObject2.transform.rotation = Quaternion.identity;
			gameObject2.transform.localScale = Vector3.one;
			for (int l = 0; l < gameObjects.Length; l++)
			{
				GameObject obj3 = gameObjects[l];
				obj3.transform.SetParent(array[l], worldPositionStays: true);
				obj3.SetActive(value: false);
			}
			if (target.transform.parent != null && target.transform.parent.gameObject.activeInHierarchy)
			{
				gameObject2.transform.SetParent(target.transform.parent);
			}
			SkinnedMeshRenderer component2 = gameObject2.GetComponent<SkinnedMeshRenderer>();
			if (component2 != null)
			{
				if (Application.isPlaying)
				{
					UnityEngine.Object.Destroy(component2);
				}
				else
				{
					UnityEngine.Object.DestroyImmediate(component2);
				}
			}
			MeshFilter meshFilter = gameObject2.GetComponent<MeshFilter>();
			if (meshFilter == null)
			{
				meshFilter = gameObject2.AddComponent<MeshFilter>();
			}
			meshFilter.sharedMesh = mesh5;
			MeshRenderer meshRenderer = gameObject2.GetComponent<MeshRenderer>();
			if (meshRenderer == null)
			{
				meshRenderer = gameObject2.AddComponent<MeshRenderer>();
			}
			meshRenderer.sharedMaterials = materials;
			return new CombineResult(gameObject2, mesh5);
		}

		private static Mesh RemoveRotation(Mesh mesh, Matrix4x4 targetRotationMatrix, bool merge)
		{
			Mesh[] array = Separate(mesh);
			CombineInstance[] array2 = new CombineInstance[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				CombineInstance combineInstance = default(CombineInstance);
				combineInstance.mesh = array[i];
				combineInstance.subMeshIndex = 0;
				combineInstance.transform = targetRotationMatrix;
				array2[i] = combineInstance;
			}
			mesh = new Mesh();
			mesh.CombineMeshes(array2, merge);
			mesh.RecalculateBounds();
			return mesh;
		}

		private static bool BuildCombineInstance(Matrix4x4 targetToLocal, List<MeshFilter> allMeshFilters, List<SkinnedMeshRenderer> allSkinned, out CombineInstance[] combineInstances, out Material[] materials)
		{
			bool flag = true;
			Dictionary<Material, List<MeshTransform>> dictionary = new Dictionary<Material, List<MeshTransform>>();
			for (int i = 0; i < allMeshFilters.Count; i++)
			{
				MeshFilter meshFilter = allMeshFilters[i];
				PopulateMeshGroups(dictionary, meshFilter.gameObject, meshFilter.sharedMesh);
			}
			for (int j = 0; j < allSkinned.Count; j++)
			{
				PopulateMeshGroups(dictionary, allSkinned[j].gameObject, allSkinned[j].sharedMesh);
			}
			List<Material> list = new List<Material>(dictionary.Count);
			List<CombineInstance> list2 = new List<CombineInstance>(allMeshFilters.Count + allSkinned.Count);
			foreach (KeyValuePair<Material, List<MeshTransform>> item2 in dictionary)
			{
				List<MeshTransform> value = item2.Value;
				List<List<CombineInstance>> list3 = new List<List<CombineInstance>>();
				List<CombineInstance> list4 = new List<CombineInstance>();
				int k = 0;
				int num = 0;
				for (; k < value.Count; k++)
				{
					MeshTransform meshTransform = value[k];
					if (meshTransform.Mesh.subMeshCount > 1)
					{
						flag = false;
					}
					num += meshTransform.Mesh.vertexCount;
					if (num > 65534 && list3.Count > 0)
					{
						list3.Add(list4);
						list4 = new List<CombineInstance>();
					}
					CombineInstance item = default(CombineInstance);
					item.mesh = meshTransform.Mesh;
					item.transform = targetToLocal * meshTransform.Transform;
					list4.Add(item);
				}
				list3.Add(list4);
				for (int l = 0; l < list3.Count; l++)
				{
					List<CombineInstance> list5 = list3[l];
					Mesh mesh = new Mesh();
					mesh.CombineMeshes(list5.ToArray(), mergeSubMeshes: true);
					list.Add(item2.Key);
					list2.Add(new CombineInstance
					{
						mesh = mesh,
						transform = Matrix4x4.identity
					});
				}
			}
			combineInstances = list2.ToArray();
			materials = list.ToArray();
			if (flag)
			{
				return materials.Length <= 1;
			}
			return false;
		}

		private static void PopulateMeshGroups(Dictionary<Material, List<MeshTransform>> meshGroups, GameObject go, Mesh mesh)
		{
			Mesh[] array = Separate(mesh);
			Renderer component = go.GetComponent<Renderer>();
			Material[] array2;
			if (component == null)
			{
				array2 = new Material[array.Length];
			}
			else
			{
				array2 = component.sharedMaterials;
				Array.Resize(ref array2, array.Length);
			}
			for (int i = 0; i < array2.Length; i++)
			{
				Material key = array2[i];
				if (!meshGroups.ContainsKey(key))
				{
					meshGroups.Add(key, new List<MeshTransform>());
				}
				meshGroups[key].Add(new MeshTransform(array[i], go.transform.localToWorldMatrix));
			}
		}

		private static void DestroyChildren(GameObject gameObject)
		{
			if (Application.isPlaying)
			{
				foreach (Transform item in gameObject.transform)
				{
					UnityEngine.Object.Destroy(item.gameObject);
				}
				return;
			}
			GameObject[] array = new GameObject[gameObject.transform.childCount];
			int num = 0;
			foreach (Transform item2 in gameObject.transform)
			{
				array[num] = item2.gameObject;
				num++;
			}
			for (int i = 0; i < array.Length; i++)
			{
				UnityEngine.Object.DestroyImmediate(array[i]);
			}
		}

		private static List<Mesh> GetColliderMeshes(GameObject obj)
		{
			List<Mesh> list = new List<Mesh>();
			Collider[] components = obj.GetComponents<Collider>();
			if (components.Length == 0)
			{
				if (!(obj.GetComponent<MeshFilter>() != null))
				{
				}
			}
			else
			{
				for (int i = 0; i < components.Length; i++)
				{
					MeshCollider meshCollider = components[i] as MeshCollider;
					if (meshCollider != null)
					{
						list.AddRange(Separate(meshCollider.sharedMesh));
						continue;
					}
					MeshFilter component = obj.GetComponent<MeshFilter>();
					if (component != null)
					{
						list.AddRange(Separate(component.sharedMesh));
					}
				}
			}
			return list;
		}

		public static Vector3 CenterOfMass(GameObject gameObject)
		{
			Vector3 position = CenterOfMass(gameObject.GetComponent<MeshFilter>().sharedMesh);
			return gameObject.transform.TransformPoint(position);
		}

		public static Vector3 CenterOfMass(Mesh mesh)
		{
			Vector3[] vertices = mesh.vertices;
			int[] triangles = mesh.triangles;
			float num = 0f;
			float num2 = 0f;
			float num3 = 0f;
			float num4 = 0f;
			for (int i = 0; i < triangles.Length; i += 3)
			{
				Vector3 vector = vertices[triangles[i]];
				Vector3 vector2 = vertices[triangles[i + 1]];
				Vector3 vector3 = vertices[triangles[i + 2]];
				float num5;
				num += (num5 = (vector.x * vector2.y * vector3.z - vector.x * vector3.y * vector2.z - vector2.x * vector.y * vector3.z + vector2.x * vector3.y * vector.z + vector3.x * vector.y * vector2.z - vector3.x * vector2.y * vector.z) / 6f);
				num2 += (vector.x + vector2.x + vector3.x) / 4f * num5;
				num3 += (vector.y + vector2.y + vector3.y) / 4f * num5;
				num4 += (vector.z + vector2.z + vector3.z) / 4f * num5;
			}
			if (num == 0f)
			{
				return Vector3.zero;
			}
			return new Vector3(num2 / num, num3 / num, num4 / num);
		}

		public static Vector3 BoundsCenter(GameObject gameObject)
		{
			Vector3 position = BoundsCenter(gameObject.GetComponent<MeshFilter>().sharedMesh);
			return gameObject.transform.TransformPoint(position);
		}

		public static Vector3 BoundsCenter(Mesh mesh)
		{
			mesh.RecalculateBounds();
			return mesh.bounds.center;
		}

		public static Mesh SetPivot(Mesh mesh, Vector3 position)
		{
			Vector3 center = mesh.bounds.center;
			Vector3 offset = position - center;
			return EditPivot(mesh, offset);
		}

		public static Mesh SetPivot(Transform transform, Mesh mesh, Vector3 position)
		{
			Vector3 center = mesh.bounds.center;
			Vector3 vector = position - center;
			transform.position -= vector;
			return EditPivot(mesh, vector);
		}

		public static Mesh EditPivot(Mesh mesh, Vector3 offset)
		{
			Mesh[] array = Separate(mesh);
			CombineInstance[] array2 = new CombineInstance[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				Mesh mesh2 = array[i];
				array2[i].mesh = mesh2;
				array2[i].subMeshIndex = 0;
				array2[i].transform = Matrix4x4.TRS(offset, Quaternion.identity, Vector3.one);
			}
			Mesh mesh3 = new Mesh();
			mesh3.name = mesh.name;
			mesh3.CombineMeshes(array2, mesh.subMeshCount <= 1);
			return mesh3;
		}

		public static Mesh EditPivot(Transform transform, Vector3 worldOffset, Collider[] colliders)
		{
			Vector3 vector = transform.InverseTransformDirection(worldOffset);
			MeshFilter component = transform.gameObject.GetComponent<MeshFilter>();
			component.sharedMesh = EditPivot(component.sharedMesh, vector);
			foreach (Collider collider in colliders)
			{
				if (collider != null)
				{
					if (collider is MeshCollider)
					{
						MeshCollider obj = (MeshCollider)collider;
						obj.sharedMesh = EditPivot(obj.sharedMesh, vector);
					}
					else if (collider is BoxCollider)
					{
						((BoxCollider)collider).center += vector;
					}
					else if (collider is SphereCollider)
					{
						((SphereCollider)collider).center += vector;
					}
					else if (collider is CapsuleCollider)
					{
						((CapsuleCollider)collider).center += vector;
					}
				}
			}
			return component.sharedMesh;
		}

		public static Mesh[] Separate(Mesh mesh)
		{
			if (mesh.subMeshCount < 2)
			{
				return new Mesh[1] { mesh };
			}
			Mesh[] array = new Mesh[mesh.subMeshCount];
			for (int i = 0; i < mesh.subMeshCount; i++)
			{
				array[i] = ExtractSubmesh(mesh, i);
			}
			return array;
		}

		public static Mesh ExtractSubmesh(Mesh mesh, int submeshIndex)
		{
			MeshTopology topology = mesh.GetTopology(submeshIndex);
			if (topology != 0)
			{
				UnityEngine.Debug.LogWarningFormat("Extract Submesh method could handle triangle topology only. Current topology is {0}. Mesh name {1} submeshIndex {2}", topology, mesh, submeshIndex);
				return mesh;
			}
			int[] triangles = mesh.GetTriangles(submeshIndex);
			int[] array = new int[triangles.Length];
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			int num = 0;
			for (int i = 0; i < triangles.Length; i++)
			{
				int key = triangles[i];
				if (!dictionary.ContainsKey(key))
				{
					array[i] = num;
					dictionary.Add(key, num);
					num++;
				}
				else
				{
					array[i] = dictionary[key];
				}
			}
			Vector3[] vertices = mesh.vertices;
			Vector3[] array2 = new Vector3[num];
			foreach (KeyValuePair<int, int> item in dictionary)
			{
				array2[item.Value] = vertices[item.Key];
			}
			Mesh mesh2 = new Mesh();
			mesh2.vertices = array2;
			Color[] colors = mesh.colors;
			if (colors.Length == vertices.Length)
			{
				Color[] array3 = new Color[num];
				foreach (KeyValuePair<int, int> item2 in dictionary)
				{
					array3[item2.Value] = colors[item2.Key];
				}
				mesh2.colors = array3;
			}
			else if (colors.Length != 0)
			{
				UnityEngine.Debug.LogWarning("colors.Length != vertices.Length");
			}
			Color32[] colors2 = mesh.colors32;
			if (colors2.Length == vertices.Length)
			{
				Color32[] array4 = new Color32[num];
				foreach (KeyValuePair<int, int> item3 in dictionary)
				{
					array4[item3.Value] = colors2[item3.Key];
				}
				mesh2.colors32 = array4;
			}
			else if (colors2.Length != 0)
			{
				UnityEngine.Debug.LogWarning("colors32.Length != vertices.Length");
			}
			BoneWeight[] boneWeights = mesh.boneWeights;
			if (boneWeights.Length == vertices.Length)
			{
				BoneWeight[] array5 = new BoneWeight[num];
				foreach (KeyValuePair<int, int> item4 in dictionary)
				{
					array5[item4.Value] = boneWeights[item4.Key];
				}
				mesh2.boneWeights = array5;
			}
			else if (boneWeights.Length != 0)
			{
				UnityEngine.Debug.LogWarning("boneWeights.Length != vertices.Length");
			}
			Vector3[] normals = mesh.normals;
			if (normals.Length == vertices.Length)
			{
				Vector3[] array6 = new Vector3[num];
				foreach (KeyValuePair<int, int> item5 in dictionary)
				{
					array6[item5.Value] = normals[item5.Key];
				}
				mesh2.normals = array6;
			}
			else if (normals.Length != 0)
			{
				UnityEngine.Debug.LogWarning("normals.Length != vertices.Length");
			}
			Vector4[] tangents = mesh.tangents;
			if (tangents.Length == vertices.Length)
			{
				Vector4[] array7 = new Vector4[num];
				foreach (KeyValuePair<int, int> item6 in dictionary)
				{
					array7[item6.Value] = tangents[item6.Key];
				}
				mesh2.tangents = array7;
			}
			else if (tangents.Length != 0)
			{
				UnityEngine.Debug.LogWarning("tangents.Length != vertices.Length");
			}
			Vector2[] uv = mesh.uv;
			if (uv.Length == vertices.Length)
			{
				Vector2[] array8 = new Vector2[num];
				foreach (KeyValuePair<int, int> item7 in dictionary)
				{
					array8[item7.Value] = uv[item7.Key];
				}
				mesh2.uv = array8;
			}
			else if (uv.Length != 0)
			{
				UnityEngine.Debug.LogWarning("uv.Length != vertices.Length");
			}
			Vector2[] uv2 = mesh.uv2;
			if (uv2.Length == vertices.Length)
			{
				Vector2[] array9 = new Vector2[num];
				foreach (KeyValuePair<int, int> item8 in dictionary)
				{
					array9[item8.Value] = uv2[item8.Key];
				}
				mesh2.uv2 = array9;
			}
			else if (uv2.Length != 0)
			{
				UnityEngine.Debug.LogWarning("uv2.Length != vertices.Length");
			}
			Vector2[] uv3 = mesh.uv3;
			if (uv3.Length == vertices.Length)
			{
				Vector2[] array10 = new Vector2[num];
				foreach (KeyValuePair<int, int> item9 in dictionary)
				{
					array10[item9.Value] = uv3[item9.Key];
				}
				mesh2.uv3 = array10;
			}
			else if (uv3.Length != 0)
			{
				UnityEngine.Debug.LogWarning("uv3.Length != vertices.Length");
			}
			Vector2[] uv4 = mesh.uv4;
			if (uv4.Length == vertices.Length)
			{
				Vector2[] array11 = new Vector2[num];
				foreach (KeyValuePair<int, int> item10 in dictionary)
				{
					array11[item10.Value] = uv4[item10.Key];
				}
				mesh2.uv4 = array11;
			}
			else if (uv4.Length != 0)
			{
				UnityEngine.Debug.LogWarning("uv4.Length != vertices.Length");
			}
			mesh2.triangles = array;
			return mesh2;
		}
	}
	[ExecuteInEditMode]
	public class Pivot : MonoBehaviour
	{
		[HideInInspector]
		public Transform Target;

		private void Start()
		{
			if (Application.isEditor && !Application.isPlaying)
			{
				if (base.gameObject.GetComponent<PivotDesignTime>() == null)
				{
					base.gameObject.AddComponent<PivotDesignTime>();
				}
				return;
			}
			PivotDesignTime component = base.gameObject.GetComponent<PivotDesignTime>();
			if (component != null)
			{
				UnityEngine.Object.DestroyImmediate(component);
			}
		}
	}
	[ExecuteInEditMode]
	public class PivotDesignTime : MonoBehaviour
	{
		private Vector3 m_prevPosition;

		private Vector3 m_prevTargetPosition;

		private Pivot m_origin;

		private Collider[] m_colliders;

		private void Start()
		{
			m_origin = GetComponent<Pivot>();
			m_prevTargetPosition = m_origin.Target.transform.position;
			m_prevPosition = base.transform.position;
			if (m_origin.Target != null)
			{
				m_colliders = m_origin.Target.GetComponents<Collider>();
			}
		}

		public void ToBoundsCenter()
		{
			base.transform.position = MeshUtils.BoundsCenter(m_origin.Target.gameObject);
		}

		public void ToCenterOffMass()
		{
			base.transform.position = MeshUtils.CenterOfMass(m_origin.Target.gameObject);
		}

		private void Update()
		{
			if (m_origin.Target == null)
			{
				UnityEngine.Object.DestroyImmediate(base.gameObject);
			}
			else if (m_prevPosition != base.transform.position)
			{
				Vector3 vector = m_origin.Target.position - base.transform.position;
				MeshUtils.EditPivot(m_origin.Target, vector, m_colliders);
				m_origin.Target.position -= vector;
				m_prevPosition = base.transform.position;
				m_prevTargetPosition = m_origin.Target.transform.position;
			}
			else if (m_origin.Target.transform.position != m_prevTargetPosition)
			{
				base.transform.position += m_origin.Target.transform.position - m_prevTargetPosition;
				m_prevTargetPosition = m_origin.Target.transform.position;
				m_prevPosition = base.transform.position;
			}
		}
	}
}
namespace Battlehub.Integration
{
	public class IntegrationArgs
	{
		public GameObject GameObject;

		public Mesh Mesh;

		public bool Cancel;

		public IntegrationArgs()
		{
		}

		public IntegrationArgs(GameObject gameObject)
		{
			GameObject = gameObject;
		}

		public IntegrationArgs(GameObject gameObject, Mesh mesh)
		{
			GameObject = gameObject;
			Mesh = mesh;
		}
	}
	public delegate void IntegrationHandler(IntegrationArgs args);
	public static class MeshCombinerIntegration
	{
		public static event IntegrationHandler Combined;

		public static event IntegrationHandler BeginEditPivot;

		public static void RaiseCombined(GameObject go, Mesh mesh)
		{
			if (MeshCombinerIntegration.Combined != null)
			{
				MeshCombinerIntegration.Combined(new IntegrationArgs(go, mesh));
			}
		}

		public static bool RaiseBeginEditPivot(GameObject go, Mesh mesh)
		{
			if (MeshCombinerIntegration.BeginEditPivot != null)
			{
				IntegrationArgs integrationArgs = new IntegrationArgs(go, mesh);
				MeshCombinerIntegration.BeginEditPivot(integrationArgs);
				return !integrationArgs.Cancel;
			}
			return true;
		}
	}
	public static class MeshDeformerIntegration
	{
		public static event IntegrationHandler BeforeDeform;

		public static bool RaiseBeforeDeform(GameObject gameObject, Mesh mesh)
		{
			if (MeshDeformerIntegration.BeforeDeform != null)
			{
				IntegrationArgs integrationArgs = new IntegrationArgs(gameObject, mesh);
				MeshDeformerIntegration.BeforeDeform(integrationArgs);
				return !integrationArgs.Cancel;
			}
			return true;
		}
	}
	public static class WiresIntegration
	{
		public static event IntegrationHandler WireParamsChanged;

		public static event IntegrationHandler BeforeWireCreated;

		public static bool RaiseBeforeWireCreated(GameObject gameObject, Mesh mesh)
		{
			if (WiresIntegration.BeforeWireCreated != null)
			{
				IntegrationArgs integrationArgs = new IntegrationArgs(gameObject, mesh);
				WiresIntegration.BeforeWireCreated(integrationArgs);
				return !integrationArgs.Cancel;
			}
			return true;
		}

		public static void RaiseWireParamsChanged(GameObject gameObject, Mesh mesh)
		{
			if (WiresIntegration.WireParamsChanged != null)
			{
				WiresIntegration.WireParamsChanged(new IntegrationArgs(gameObject, mesh));
			}
		}
	}
}
namespace TFHC_Shader_Samples
{
	public class highlightAnimated : MonoBehaviour
	{
		private Material mat;

		private void Start()
		{
			mat = GetComponent<Renderer>().material;
		}

		private void OnMouseEnter()
		{
			switchhighlighted(highlighted: true);
		}

		private void OnMouseExit()
		{
			switchhighlighted(highlighted: false);
		}

		private void switchhighlighted(bool highlighted)
		{
			mat.SetFloat("_Highlighted", highlighted ? 1f : 0f);
		}
	}
}
namespace TFHC_ForceShield_Shader_Sample
{
	public class ForceShieldDestroyBall : MonoBehaviour
	{
		public float lifetime = 5f;

		private void Start()
		{
			UnityEngine.Object.Destroy(base.gameObject, lifetime);
		}
	}
	public class ForceShieldImpactDetection : MonoBehaviour
	{
		private float hitTime;

		private Material mat;

		private void Start()
		{
			mat = GetComponent<Renderer>().material;
		}

		private void Update()
		{
			if (hitTime > 0f)
			{
				hitTime -= Time.deltaTime * 1000f;
				if (hitTime < 0f)
				{
					hitTime = 0f;
				}
				mat.SetFloat("_HitTime", hitTime);
			}
		}

		private void OnCollisionEnter(Collision collision)
		{
			ContactPoint[] contacts = collision.contacts;
			foreach (ContactPoint contactPoint in contacts)
			{
				mat.SetVector("_HitPosition", base.transform.InverseTransformPoint(contactPoint.point));
				hitTime = 500f;
				mat.SetFloat("_HitTime", hitTime);
			}
		}
	}
	public class ForceShieldShootBall : MonoBehaviour
	{
		public Rigidbody bullet;

		public Transform origshoot;

		public float speed = 1000f;

		private float distance = 10f;

		private void Update()
		{
			if (Input.GetButtonDown("Fire1"))
			{
				Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
				position = Camera.main.ScreenToWorldPoint(position);
				Rigidbody rigidbody = UnityEngine.Object.Instantiate(bullet, base.transform.position, Quaternion.identity);
				rigidbody.transform.LookAt(position);
				rigidbody.AddForce(rigidbody.transform.forward * speed);
			}
		}
	}
}
