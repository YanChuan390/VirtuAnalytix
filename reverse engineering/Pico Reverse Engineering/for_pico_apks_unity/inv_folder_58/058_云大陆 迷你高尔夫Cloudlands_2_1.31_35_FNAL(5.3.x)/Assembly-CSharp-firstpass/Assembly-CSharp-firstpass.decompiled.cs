using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.CrossPlatformInput.PlatformSpecific;
using UnityStandardAssets.Utility;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityStandardAssets.Utility
{
	[Serializable]
	public class CurveControlledBob
	{
		public float HorizontalBobRange = 0.33f;

		public float VerticalBobRange = 0.33f;

		public AnimationCurve Bobcurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.5f, 1f), new Keyframe(1f, 0f), new Keyframe(1.5f, -1f), new Keyframe(2f, 0f));

		public float VerticaltoHorizontalRatio = 1f;

		private float m_CyclePositionX;

		private float m_CyclePositionY;

		private float m_BobBaseInterval;

		private Vector3 m_OriginalCameraPosition;

		private float m_Time;

		public void Setup(Camera camera, float bobBaseInterval)
		{
			m_BobBaseInterval = bobBaseInterval;
			m_OriginalCameraPosition = camera.transform.localPosition;
			m_Time = Bobcurve[Bobcurve.length - 1].time;
		}

		public Vector3 DoHeadBob(float speed)
		{
			float x = m_OriginalCameraPosition.x + Bobcurve.Evaluate(m_CyclePositionX) * HorizontalBobRange;
			float y = m_OriginalCameraPosition.y + Bobcurve.Evaluate(m_CyclePositionY) * VerticalBobRange;
			m_CyclePositionX += speed * Time.deltaTime / m_BobBaseInterval;
			m_CyclePositionY += speed * Time.deltaTime / m_BobBaseInterval * VerticaltoHorizontalRatio;
			if (m_CyclePositionX > m_Time)
			{
				m_CyclePositionX -= m_Time;
			}
			if (m_CyclePositionY > m_Time)
			{
				m_CyclePositionY -= m_Time;
			}
			return new Vector3(x, y, 0f);
		}
	}
	[Serializable]
	public class FOVKick
	{
		public Camera Camera;

		[HideInInspector]
		public float originalFov;

		public float FOVIncrease = 3f;

		public float TimeToIncrease = 1f;

		public float TimeToDecrease = 1f;

		public AnimationCurve IncreaseCurve;

		public void Setup(Camera camera)
		{
			CheckStatus(camera);
			Camera = camera;
			originalFov = camera.fieldOfView;
		}

		private void CheckStatus(Camera camera)
		{
			if (camera == null)
			{
				throw new Exception("FOVKick camera is null, please supply the camera to the constructor");
			}
			if (IncreaseCurve == null)
			{
				throw new Exception("FOVKick Increase curve is null, please define the curve for the field of view kicks");
			}
		}

		public void ChangeCamera(Camera camera)
		{
			Camera = camera;
		}

		public IEnumerator FOVKickUp()
		{
			float t = Mathf.Abs((Camera.fieldOfView - originalFov) / FOVIncrease);
			while (t < TimeToIncrease)
			{
				Camera.fieldOfView = originalFov + IncreaseCurve.Evaluate(t / TimeToIncrease) * FOVIncrease;
				t += Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
		}

		public IEnumerator FOVKickDown()
		{
			float t = Mathf.Abs((Camera.fieldOfView - originalFov) / FOVIncrease);
			while (t > 0f)
			{
				Camera.fieldOfView = originalFov + IncreaseCurve.Evaluate(t / TimeToDecrease) * FOVIncrease;
				t -= Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			Camera.fieldOfView = originalFov;
		}
	}
	[RequireComponent(typeof(Text))]
	public class FPSCounter : MonoBehaviour
	{
		private const float fpsMeasurePeriod = 0.5f;

		private int m_FpsAccumulator;

		private float m_FpsNextPeriod;

		private int m_CurrentFps;

		private const string display = "{0} FPS";

		private Text m_Text;

		private void Start()
		{
			m_FpsNextPeriod = Time.realtimeSinceStartup + 0.5f;
			m_Text = GetComponent<Text>();
		}

		private void Update()
		{
			m_FpsAccumulator++;
			if (Time.realtimeSinceStartup > m_FpsNextPeriod)
			{
				m_CurrentFps = (int)((float)m_FpsAccumulator / 0.5f);
				m_FpsAccumulator = 0;
				m_FpsNextPeriod += 0.5f;
				m_Text.text = $"{m_CurrentFps} FPS";
			}
		}
	}
	[Serializable]
	public class LerpControlledBob
	{
		public float BobDuration;

		public float BobAmount;

		private float m_Offset;

		public float Offset()
		{
			return m_Offset;
		}

		public IEnumerator DoBobCycle()
		{
			float t2 = 0f;
			while (t2 < BobDuration)
			{
				m_Offset = Mathf.Lerp(0f, BobAmount, t2 / BobDuration);
				t2 += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			t2 = 0f;
			while (t2 < BobDuration)
			{
				m_Offset = Mathf.Lerp(BobAmount, 0f, t2 / BobDuration);
				t2 += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			m_Offset = 0f;
		}
	}
	public class TimedObjectActivator : MonoBehaviour
	{
		public enum Action
		{
			Activate,
			Deactivate,
			Destroy,
			ReloadLevel,
			Call
		}

		[Serializable]
		public class Entry
		{
			public GameObject target;

			public Action action;

			public float delay;
		}

		[Serializable]
		public class Entries
		{
			public Entry[] entries;
		}

		public Entries entries = new Entries();

		private void Awake()
		{
			Entry[] array = entries.entries;
			foreach (Entry entry in array)
			{
				switch (entry.action)
				{
				case Action.Activate:
					StartCoroutine(Activate(entry));
					break;
				case Action.Deactivate:
					StartCoroutine(Deactivate(entry));
					break;
				case Action.Destroy:
					UnityEngine.Object.Destroy(entry.target, entry.delay);
					break;
				case Action.ReloadLevel:
					StartCoroutine(ReloadLevel(entry));
					break;
				}
			}
		}

		private IEnumerator Activate(Entry entry)
		{
			yield return new WaitForSeconds(entry.delay);
			entry.target.SetActive(value: true);
		}

		private IEnumerator Deactivate(Entry entry)
		{
			yield return new WaitForSeconds(entry.delay);
			entry.target.SetActive(value: false);
		}

		private IEnumerator ReloadLevel(Entry entry)
		{
			yield return new WaitForSeconds(entry.delay);
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	public static class CrossPlatformInputManager
	{
		public enum ActiveInputMethod
		{
			Hardware,
			Touch
		}

		public class VirtualAxis
		{
			private float m_Value;

			public string name { get; private set; }

			public bool matchWithInputManager { get; private set; }

			public float GetValue => m_Value;

			public float GetValueRaw => m_Value;

			public VirtualAxis(string name)
				: this(name, matchToInputSettings: true)
			{
			}

			public VirtualAxis(string name, bool matchToInputSettings)
			{
				this.name = name;
				matchWithInputManager = matchToInputSettings;
			}

			public void Remove()
			{
				UnRegisterVirtualAxis(name);
			}

			public void Update(float value)
			{
				m_Value = value;
			}
		}

		public class VirtualButton
		{
			private int m_LastPressedFrame = -5;

			private int m_ReleasedFrame = -5;

			private bool m_Pressed;

			public string name { get; private set; }

			public bool matchWithInputManager { get; private set; }

			public bool GetButton => m_Pressed;

			public bool GetButtonDown => m_LastPressedFrame - Time.frameCount == -1;

			public bool GetButtonUp => m_ReleasedFrame == Time.frameCount - 1;

			public VirtualButton(string name)
				: this(name, matchToInputSettings: true)
			{
			}

			public VirtualButton(string name, bool matchToInputSettings)
			{
				this.name = name;
				matchWithInputManager = matchToInputSettings;
			}

			public void Pressed()
			{
				if (!m_Pressed)
				{
					m_Pressed = true;
					m_LastPressedFrame = Time.frameCount;
				}
			}

			public void Released()
			{
				m_Pressed = false;
				m_ReleasedFrame = Time.frameCount;
			}

			public void Remove()
			{
				UnRegisterVirtualButton(name);
			}
		}

		private static VirtualInput activeInput;

		private static VirtualInput s_TouchInput;

		private static VirtualInput s_HardwareInput;

		public static Vector3 mousePosition => activeInput.MousePosition();

		static CrossPlatformInputManager()
		{
			s_TouchInput = new MobileInput();
			s_HardwareInput = new StandaloneInput();
			activeInput = s_TouchInput;
		}

		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
			switch (activeInputMethod)
			{
			case ActiveInputMethod.Hardware:
				activeInput = s_HardwareInput;
				break;
			case ActiveInputMethod.Touch:
				activeInput = s_TouchInput;
				break;
			}
		}

		public static bool AxisExists(string name)
		{
			return activeInput.AxisExists(name);
		}

		public static bool ButtonExists(string name)
		{
			return activeInput.ButtonExists(name);
		}

		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
			activeInput.RegisterVirtualAxis(axis);
		}

		public static void RegisterVirtualButton(VirtualButton button)
		{
			activeInput.RegisterVirtualButton(button);
		}

		public static void UnRegisterVirtualAxis(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			activeInput.UnRegisterVirtualAxis(name);
		}

		public static void UnRegisterVirtualButton(string name)
		{
			activeInput.UnRegisterVirtualButton(name);
		}

		public static VirtualAxis VirtualAxisReference(string name)
		{
			return activeInput.VirtualAxisReference(name);
		}

		public static float GetAxis(string name)
		{
			return GetAxis(name, raw: false);
		}

		public static float GetAxisRaw(string name)
		{
			return GetAxis(name, raw: true);
		}

		private static float GetAxis(string name, bool raw)
		{
			return activeInput.GetAxis(name, raw);
		}

		public static bool GetButton(string name)
		{
			return activeInput.GetButton(name);
		}

		public static bool GetButtonDown(string name)
		{
			return activeInput.GetButtonDown(name);
		}

		public static bool GetButtonUp(string name)
		{
			return activeInput.GetButtonUp(name);
		}

		public static void SetButtonDown(string name)
		{
			activeInput.SetButtonDown(name);
		}

		public static void SetButtonUp(string name)
		{
			activeInput.SetButtonUp(name);
		}

		public static void SetAxisPositive(string name)
		{
			activeInput.SetAxisPositive(name);
		}

		public static void SetAxisNegative(string name)
		{
			activeInput.SetAxisNegative(name);
		}

		public static void SetAxisZero(string name)
		{
			activeInput.SetAxisZero(name);
		}

		public static void SetAxis(string name, float value)
		{
			activeInput.SetAxis(name, value);
		}

		public static void SetVirtualMousePositionX(float f)
		{
			activeInput.SetVirtualMousePositionX(f);
		}

		public static void SetVirtualMousePositionY(float f)
		{
			activeInput.SetVirtualMousePositionY(f);
		}

		public static void SetVirtualMousePositionZ(float f)
		{
			activeInput.SetVirtualMousePositionZ(f);
		}
	}
	public abstract class VirtualInput
	{
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes = new Dictionary<string, CrossPlatformInputManager.VirtualAxis>();

		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons = new Dictionary<string, CrossPlatformInputManager.VirtualButton>();

		protected List<string> m_AlwaysUseVirtual = new List<string>();

		public Vector3 virtualMousePosition { get; private set; }

		public bool AxisExists(string name)
		{
			return m_VirtualAxes.ContainsKey(name);
		}

		public bool ButtonExists(string name)
		{
			return m_VirtualButtons.ContainsKey(name);
		}

		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
			if (m_VirtualAxes.ContainsKey(axis.name))
			{
				UnityEngine.Debug.LogError("There is already a virtual axis named " + axis.name + " registered.");
				return;
			}
			m_VirtualAxes.Add(axis.name, axis);
			if (!axis.matchWithInputManager)
			{
				m_AlwaysUseVirtual.Add(axis.name);
			}
		}

		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
			if (m_VirtualButtons.ContainsKey(button.name))
			{
				UnityEngine.Debug.LogError("There is already a virtual button named " + button.name + " registered.");
				return;
			}
			m_VirtualButtons.Add(button.name, button);
			if (!button.matchWithInputManager)
			{
				m_AlwaysUseVirtual.Add(button.name);
			}
		}

		public void UnRegisterVirtualAxis(string name)
		{
			if (m_VirtualAxes.ContainsKey(name))
			{
				m_VirtualAxes.Remove(name);
			}
		}

		public void UnRegisterVirtualButton(string name)
		{
			if (m_VirtualButtons.ContainsKey(name))
			{
				m_VirtualButtons.Remove(name);
			}
		}

		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				return null;
			}
			return m_VirtualAxes[name];
		}

		public void SetVirtualMousePositionX(float f)
		{
			virtualMousePosition = new Vector3(f, virtualMousePosition.y, virtualMousePosition.z);
		}

		public void SetVirtualMousePositionY(float f)
		{
			virtualMousePosition = new Vector3(virtualMousePosition.x, f, virtualMousePosition.z);
		}

		public void SetVirtualMousePositionZ(float f)
		{
			virtualMousePosition = new Vector3(virtualMousePosition.x, virtualMousePosition.y, f);
		}

		public abstract float GetAxis(string name, bool raw);

		public abstract bool GetButton(string name);

		public abstract bool GetButtonDown(string name);

		public abstract bool GetButtonUp(string name);

		public abstract void SetButtonDown(string name);

		public abstract void SetButtonUp(string name);

		public abstract void SetAxisPositive(string name);

		public abstract void SetAxisNegative(string name);

		public abstract void SetAxisZero(string name);

		public abstract void SetAxis(string name, float value);

		public abstract Vector3 MousePosition();
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	public class MobileInput : VirtualInput
	{
		private void AddButton(string name)
		{
			CrossPlatformInputManager.RegisterVirtualButton(new CrossPlatformInputManager.VirtualButton(name));
		}

		private void AddAxes(string name)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(name));
		}

		public override float GetAxis(string name, bool raw)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				AddAxes(name);
			}
			return m_VirtualAxes[name].GetValue;
		}

		public override void SetButtonDown(string name)
		{
			if (!m_VirtualButtons.ContainsKey(name))
			{
				AddButton(name);
			}
			m_VirtualButtons[name].Pressed();
		}

		public override void SetButtonUp(string name)
		{
			if (!m_VirtualButtons.ContainsKey(name))
			{
				AddButton(name);
			}
			m_VirtualButtons[name].Released();
		}

		public override void SetAxisPositive(string name)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				AddAxes(name);
			}
			m_VirtualAxes[name].Update(1f);
		}

		public override void SetAxisNegative(string name)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				AddAxes(name);
			}
			m_VirtualAxes[name].Update(-1f);
		}

		public override void SetAxisZero(string name)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				AddAxes(name);
			}
			m_VirtualAxes[name].Update(0f);
		}

		public override void SetAxis(string name, float value)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				AddAxes(name);
			}
			m_VirtualAxes[name].Update(value);
		}

		public override bool GetButtonDown(string name)
		{
			if (m_VirtualButtons.ContainsKey(name))
			{
				return m_VirtualButtons[name].GetButtonDown;
			}
			AddButton(name);
			return m_VirtualButtons[name].GetButtonDown;
		}

		public override bool GetButtonUp(string name)
		{
			if (m_VirtualButtons.ContainsKey(name))
			{
				return m_VirtualButtons[name].GetButtonUp;
			}
			AddButton(name);
			return m_VirtualButtons[name].GetButtonUp;
		}

		public override bool GetButton(string name)
		{
			if (m_VirtualButtons.ContainsKey(name))
			{
				return m_VirtualButtons[name].GetButton;
			}
			AddButton(name);
			return m_VirtualButtons[name].GetButton;
		}

		public override Vector3 MousePosition()
		{
			return base.virtualMousePosition;
		}
	}
	public class StandaloneInput : VirtualInput
	{
		public override float GetAxis(string name, bool raw)
		{
			if (!raw)
			{
				return Input.GetAxis(name);
			}
			return Input.GetAxisRaw(name);
		}

		public override bool GetButton(string name)
		{
			return Input.GetButton(name);
		}

		public override bool GetButtonDown(string name)
		{
			return Input.GetButtonDown(name);
		}

		public override bool GetButtonUp(string name)
		{
			return Input.GetButtonUp(name);
		}

		public override void SetButtonDown(string name)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override void SetButtonUp(string name)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override void SetAxisPositive(string name)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override void SetAxisNegative(string name)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override void SetAxisZero(string name)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override void SetAxis(string name, float value)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override Vector3 MousePosition()
		{
			return Input.mousePosition;
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[RequireComponent(typeof(CharacterController))]
	[RequireComponent(typeof(AudioSource))]
	public class FirstPersonController : MonoBehaviour
	{
		[SerializeField]
		private bool m_IsWalking;

		[SerializeField]
		private float m_WalkSpeed;

		[SerializeField]
		private float m_RunSpeed;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_RunstepLenghten;

		[SerializeField]
		private float m_JumpSpeed;

		[SerializeField]
		private float m_StickToGroundForce;

		[SerializeField]
		private float m_GravityMultiplier;

		[SerializeField]
		private MouseLook m_MouseLook;

		[SerializeField]
		private bool m_UseFovKick;

		[SerializeField]
		private FOVKick m_FovKick = new FOVKick();

		[SerializeField]
		private bool m_UseHeadBob;

		[SerializeField]
		private CurveControlledBob m_HeadBob = new CurveControlledBob();

		[SerializeField]
		private LerpControlledBob m_JumpBob = new LerpControlledBob();

		[SerializeField]
		private float m_StepInterval;

		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[SerializeField]
		private AudioClip m_JumpSound;

		[SerializeField]
		private AudioClip m_LandSound;

		private Camera m_Camera;

		private bool m_Jump;

		private float m_YRotation;

		private Vector2 m_Input;

		private Vector3 m_MoveDir = Vector3.zero;

		private CharacterController m_CharacterController;

		private CollisionFlags m_CollisionFlags;

		private bool m_PreviouslyGrounded;

		private Vector3 m_OriginalCameraPosition;

		private float m_StepCycle;

		private float m_NextStep;

		private bool m_Jumping;

		private AudioSource m_AudioSource;

		private void Start()
		{
			m_CharacterController = GetComponent<CharacterController>();
			m_Camera = GetComponentInChildren<Camera>();
			m_OriginalCameraPosition = m_Camera.transform.localPosition;
			m_FovKick.Setup(m_Camera);
			m_HeadBob.Setup(m_Camera, m_StepInterval);
			m_StepCycle = 0f;
			m_NextStep = m_StepCycle / 2f;
			m_Jumping = false;
			m_AudioSource = GetComponent<AudioSource>();
			m_MouseLook.Init(base.transform, m_Camera.transform);
			CrossPlatformInputManager.SwitchActiveInputMethod(CrossPlatformInputManager.ActiveInputMethod.Hardware);
		}

		private void Update()
		{
			RotateView();
			if (!m_Jump)
			{
				m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
			}
			if (!m_PreviouslyGrounded && m_CharacterController.isGrounded)
			{
				StartCoroutine(m_JumpBob.DoBobCycle());
				PlayLandingSound();
				m_MoveDir.y = 0f;
				m_Jumping = false;
			}
			if (!m_CharacterController.isGrounded && !m_Jumping && m_PreviouslyGrounded)
			{
				m_MoveDir.y = 0f;
			}
			m_PreviouslyGrounded = m_CharacterController.isGrounded;
		}

		private void PlayLandingSound()
		{
			m_AudioSource.clip = m_LandSound;
			m_AudioSource.Play();
			m_NextStep = m_StepCycle + 0.5f;
		}

		private void FixedUpdate()
		{
			GetInput(out var speed);
			Vector3 vector = base.transform.forward * m_Input.y + base.transform.right * m_Input.x;
			Physics.SphereCast(base.transform.position, m_CharacterController.radius, Vector3.down, out var hitInfo, m_CharacterController.height / 2f, -1, QueryTriggerInteraction.Ignore);
			vector = Vector3.ProjectOnPlane(vector, hitInfo.normal).normalized;
			m_MoveDir.x = vector.x * speed;
			m_MoveDir.z = vector.z * speed;
			if (m_CharacterController.isGrounded)
			{
				m_MoveDir.y = 0f - m_StickToGroundForce;
				if (m_Jump)
				{
					m_MoveDir.y = m_JumpSpeed;
					PlayJumpSound();
					m_Jump = false;
					m_Jumping = true;
				}
			}
			else
			{
				m_MoveDir += Physics.gravity * m_GravityMultiplier * Time.fixedDeltaTime;
			}
			m_CollisionFlags = m_CharacterController.Move(m_MoveDir * Time.fixedDeltaTime);
			ProgressStepCycle(speed);
			UpdateCameraPosition(speed);
			m_MouseLook.UpdateCursorLock();
		}

		private void PlayJumpSound()
		{
			m_AudioSource.clip = m_JumpSound;
			m_AudioSource.Play();
		}

		private void ProgressStepCycle(float speed)
		{
			if (m_CharacterController.velocity.sqrMagnitude > 0f && (m_Input.x != 0f || m_Input.y != 0f))
			{
				m_StepCycle += (m_CharacterController.velocity.magnitude + speed * (m_IsWalking ? 1f : m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (m_StepCycle > m_NextStep)
			{
				m_NextStep = m_StepCycle + m_StepInterval;
				PlayFootStepAudio();
			}
		}

		private void PlayFootStepAudio()
		{
		}

		private void UpdateCameraPosition(float speed)
		{
			if (m_UseHeadBob)
			{
				Vector3 localPosition;
				if (m_CharacterController.velocity.magnitude > 0f && m_CharacterController.isGrounded)
				{
					m_Camera.transform.localPosition = m_HeadBob.DoHeadBob(m_CharacterController.velocity.magnitude + speed * (m_IsWalking ? 1f : m_RunstepLenghten));
					localPosition = m_Camera.transform.localPosition;
					localPosition.y = m_Camera.transform.localPosition.y - m_JumpBob.Offset();
				}
				else
				{
					localPosition = m_Camera.transform.localPosition;
					localPosition.y = m_OriginalCameraPosition.y - m_JumpBob.Offset();
				}
				m_Camera.transform.localPosition = localPosition;
			}
		}

		private void GetInput(out float speed)
		{
			float axis = CrossPlatformInputManager.GetAxis("Horizontal");
			float axis2 = CrossPlatformInputManager.GetAxis("Vertical");
			bool isWalking = m_IsWalking;
			speed = (m_IsWalking ? m_WalkSpeed : m_RunSpeed);
			m_Input = new Vector2(axis, axis2);
			if (m_Input.sqrMagnitude > 1f)
			{
				m_Input.Normalize();
			}
			if (m_IsWalking != isWalking && m_UseFovKick && m_CharacterController.velocity.sqrMagnitude > 0f)
			{
				StopAllCoroutines();
				StartCoroutine((!m_IsWalking) ? m_FovKick.FOVKickUp() : m_FovKick.FOVKickDown());
			}
		}

		private void RotateView()
		{
			m_MouseLook.LookRotation(base.transform, m_Camera.transform);
		}

		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
			Rigidbody attachedRigidbody = hit.collider.attachedRigidbody;
			if (m_CollisionFlags != CollisionFlags.Below && !(attachedRigidbody == null) && !attachedRigidbody.isKinematic)
			{
				attachedRigidbody.AddForceAtPosition(m_CharacterController.velocity * 0.1f, hit.point, ForceMode.Impulse);
			}
		}
	}
	public class HeadBob : MonoBehaviour
	{
		public Camera Camera;

		public CurveControlledBob motionBob = new CurveControlledBob();

		public LerpControlledBob jumpAndLandingBob = new LerpControlledBob();

		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		public float StrideInterval;

		[Range(0f, 1f)]
		public float RunningStrideLengthen;

		private bool m_PreviouslyGrounded;

		private Vector3 m_OriginalCameraPosition;

		private void Start()
		{
			motionBob.Setup(Camera, StrideInterval);
			m_OriginalCameraPosition = Camera.transform.localPosition;
		}

		private void Update()
		{
			Vector3 localPosition;
			if (rigidbodyFirstPersonController.Velocity.magnitude > 0f && rigidbodyFirstPersonController.Grounded)
			{
				Camera.transform.localPosition = motionBob.DoHeadBob(rigidbodyFirstPersonController.Velocity.magnitude * (rigidbodyFirstPersonController.Running ? RunningStrideLengthen : 1f));
				localPosition = Camera.transform.localPosition;
				localPosition.y = Camera.transform.localPosition.y - jumpAndLandingBob.Offset();
			}
			else
			{
				localPosition = Camera.transform.localPosition;
				localPosition.y = m_OriginalCameraPosition.y - jumpAndLandingBob.Offset();
			}
			Camera.transform.localPosition = localPosition;
			if (!m_PreviouslyGrounded && rigidbodyFirstPersonController.Grounded)
			{
				StartCoroutine(jumpAndLandingBob.DoBobCycle());
			}
			m_PreviouslyGrounded = rigidbodyFirstPersonController.Grounded;
		}
	}
	[Serializable]
	public class MouseLook
	{
		public float XSensitivity = 2f;

		public float YSensitivity = 2f;

		public bool clampVerticalRotation = true;

		public float MinimumX = -90f;

		public float MaximumX = 90f;

		public bool smooth;

		public float smoothTime = 5f;

		public bool lockCursor = true;

		private Quaternion m_CharacterTargetRot;

		private Quaternion m_CameraTargetRot;

		private bool m_cursorIsLocked = true;

		public void Init(Transform character, Transform camera)
		{
			m_CharacterTargetRot = character.localRotation;
			m_CameraTargetRot = camera.localRotation;
		}

		public void LookRotation(Transform character, Transform camera)
		{
			float y = CrossPlatformInputManager.GetAxis("Mouse X") * XSensitivity;
			float num = CrossPlatformInputManager.GetAxis("Mouse Y") * YSensitivity;
			m_CharacterTargetRot *= Quaternion.Euler(0f, y, 0f);
			m_CameraTargetRot *= Quaternion.Euler(0f - num, 0f, 0f);
			if (clampVerticalRotation)
			{
				m_CameraTargetRot = ClampRotationAroundXAxis(m_CameraTargetRot);
			}
			if (smooth)
			{
				character.localRotation = Quaternion.Slerp(character.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
				camera.localRotation = Quaternion.Slerp(camera.localRotation, m_CameraTargetRot, smoothTime * Time.deltaTime);
			}
			else
			{
				character.localRotation = m_CharacterTargetRot;
				camera.localRotation = m_CameraTargetRot;
			}
			UpdateCursorLock();
		}

		public void SetCursorLock(bool value)
		{
			lockCursor = value;
			if (!lockCursor)
			{
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}
		}

		public void UpdateCursorLock()
		{
		}

		private void InternalLockUpdate()
		{
			if (Input.GetKeyUp(KeyCode.Escape))
			{
				m_cursorIsLocked = false;
			}
			else if (Input.GetMouseButtonUp(0))
			{
				m_cursorIsLocked = true;
			}
			if (m_cursorIsLocked)
			{
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
			}
			else if (!m_cursorIsLocked)
			{
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}
		}

		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			q.x /= q.w;
			q.y /= q.w;
			q.z /= q.w;
			q.w = 1f;
			float value = 114.59156f * Mathf.Atan(q.x);
			value = Mathf.Clamp(value, MinimumX, MaximumX);
			q.x = Mathf.Tan((float)Math.PI / 360f * value);
			return q;
		}
	}
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		public class MovementSettings
		{
			public float ForwardSpeed = 8f;

			public float BackwardSpeed = 4f;

			public float StrafeSpeed = 4f;

			public float RunMultiplier = 2f;

			public KeyCode RunKey = KeyCode.LeftShift;

			public float JumpForce = 30f;

			public AnimationCurve SlopeCurveModifier = new AnimationCurve(new Keyframe(-90f, 1f), new Keyframe(0f, 1f), new Keyframe(90f, 0f));

			[HideInInspector]
			public float CurrentTargetSpeed = 8f;

			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
				if (!(input == Vector2.zero))
				{
					if (input.x > 0f || input.x < 0f)
					{
						CurrentTargetSpeed = StrafeSpeed;
					}
					if (input.y < 0f)
					{
						CurrentTargetSpeed = BackwardSpeed;
					}
					if (input.y > 0f)
					{
						CurrentTargetSpeed = ForwardSpeed;
					}
				}
			}
		}

		[Serializable]
		public class AdvancedSettings
		{
			public float groundCheckDistance = 0.01f;

			public float stickToGroundHelperDistance = 0.5f;

			public float slowDownRate = 20f;

			public bool airControl;

			[Tooltip("set it to 0.1 or more if you get stuck in wall")]
			public float shellOffset;
		}

		public Camera cam;

		public MovementSettings movementSettings = new MovementSettings();

		public MouseLook mouseLook = new MouseLook();

		public AdvancedSettings advancedSettings = new AdvancedSettings();

		private Rigidbody m_RigidBody;

		private CapsuleCollider m_Capsule;

		private float m_YRotation;

		private Vector3 m_GroundContactNormal;

		private bool m_Jump;

		private bool m_PreviouslyGrounded;

		private bool m_Jumping;

		private bool m_IsGrounded;

		public Vector3 Velocity => m_RigidBody.velocity;

		public bool Grounded => m_IsGrounded;

		public bool Jumping => m_Jumping;

		public bool Running => false;

		private void Start()
		{
			m_RigidBody = GetComponent<Rigidbody>();
			m_Capsule = GetComponent<CapsuleCollider>();
			mouseLook.Init(base.transform, cam.transform);
		}

		private void Update()
		{
			RotateView();
			if (CrossPlatformInputManager.GetButtonDown("Jump") && !m_Jump)
			{
				m_Jump = true;
			}
		}

		private void FixedUpdate()
		{
			GroundCheck();
			Vector2 input = GetInput();
			if ((Mathf.Abs(input.x) > float.Epsilon || Mathf.Abs(input.y) > float.Epsilon) && (advancedSettings.airControl || m_IsGrounded))
			{
				Vector3 vector = cam.transform.forward * input.y + cam.transform.right * input.x;
				vector = Vector3.ProjectOnPlane(vector, m_GroundContactNormal).normalized;
				vector.x *= movementSettings.CurrentTargetSpeed;
				vector.z *= movementSettings.CurrentTargetSpeed;
				vector.y *= movementSettings.CurrentTargetSpeed;
				if (m_RigidBody.velocity.sqrMagnitude < movementSettings.CurrentTargetSpeed * movementSettings.CurrentTargetSpeed)
				{
					m_RigidBody.AddForce(vector * SlopeMultiplier(), ForceMode.Impulse);
				}
			}
			if (m_IsGrounded)
			{
				m_RigidBody.drag = 5f;
				if (m_Jump)
				{
					m_RigidBody.drag = 0f;
					m_RigidBody.velocity = new Vector3(m_RigidBody.velocity.x, 0f, m_RigidBody.velocity.z);
					m_RigidBody.AddForce(new Vector3(0f, movementSettings.JumpForce, 0f), ForceMode.Impulse);
					m_Jumping = true;
				}
				if (!m_Jumping && Mathf.Abs(input.x) < float.Epsilon && Mathf.Abs(input.y) < float.Epsilon && m_RigidBody.velocity.magnitude < 1f)
				{
					m_RigidBody.Sleep();
				}
			}
			else
			{
				m_RigidBody.drag = 0f;
				if (m_PreviouslyGrounded && !m_Jumping)
				{
					StickToGroundHelper();
				}
			}
			m_Jump = false;
		}

		private float SlopeMultiplier()
		{
			float time = Vector3.Angle(m_GroundContactNormal, Vector3.up);
			return movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		private void StickToGroundHelper()
		{
			if (Physics.SphereCast(base.transform.position, m_Capsule.radius * (1f - advancedSettings.shellOffset), Vector3.down, out var hitInfo, m_Capsule.height / 2f - m_Capsule.radius + advancedSettings.stickToGroundHelperDistance, -1, QueryTriggerInteraction.Ignore) && Mathf.Abs(Vector3.Angle(hitInfo.normal, Vector3.up)) < 85f)
			{
				m_RigidBody.velocity = Vector3.ProjectOnPlane(m_RigidBody.velocity, hitInfo.normal);
			}
		}

		private Vector2 GetInput()
		{
			Vector2 vector = default(Vector2);
			vector.x = CrossPlatformInputManager.GetAxis("Horizontal");
			vector.y = CrossPlatformInputManager.GetAxis("Vertical");
			Vector2 vector2 = vector;
			movementSettings.UpdateDesiredTargetSpeed(vector2);
			return vector2;
		}

		private void RotateView()
		{
			if (!(Mathf.Abs(Time.timeScale) < float.Epsilon))
			{
				float y = base.transform.eulerAngles.y;
				mouseLook.LookRotation(base.transform, cam.transform);
				if (m_IsGrounded || advancedSettings.airControl)
				{
					Quaternion quaternion = Quaternion.AngleAxis(base.transform.eulerAngles.y - y, Vector3.up);
					m_RigidBody.velocity = quaternion * m_RigidBody.velocity;
				}
			}
		}

		private void GroundCheck()
		{
			m_PreviouslyGrounded = m_IsGrounded;
			if (Physics.SphereCast(base.transform.position, m_Capsule.radius * (1f - advancedSettings.shellOffset), Vector3.down, out var hitInfo, m_Capsule.height / 2f - m_Capsule.radius + advancedSettings.groundCheckDistance, -1, QueryTriggerInteraction.Ignore))
			{
				m_IsGrounded = true;
				m_GroundContactNormal = hitInfo.normal;
			}
			else
			{
				m_IsGrounded = false;
				m_GroundContactNormal = Vector3.up;
			}
			if (!m_PreviouslyGrounded && m_IsGrounded && m_Jumping)
			{
				m_Jumping = false;
			}
		}
	}
}
