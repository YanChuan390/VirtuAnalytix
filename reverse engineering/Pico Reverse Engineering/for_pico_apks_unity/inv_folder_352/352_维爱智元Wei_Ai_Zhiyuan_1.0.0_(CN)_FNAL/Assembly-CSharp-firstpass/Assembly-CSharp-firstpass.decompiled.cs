using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.CrossPlatformInput.PlatformSpecific;
using UnityStandardAssets.Utility;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	protected Image _image;

	public void Start()
	{
		_image = GetComponent<Image>();
		Texture2D texture = _image.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
			}
			catch (UnityException ex)
			{
				UnityEngine.Debug.LogError(ex.Message);
				flag = true;
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			UnityEngine.Debug.LogError("This script need an Image with a readbale Texture2D to work.");
		}
	}

	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		RectTransformUtility.ScreenPointToLocalPointInRectangle(_image.rectTransform, sp, eventCamera, out var localPoint);
		Vector2 pivot = _image.rectTransform.pivot;
		Vector2 vector = new Vector2(pivot.x + localPoint.x / _image.rectTransform.rect.width, pivot.y + localPoint.y / _image.rectTransform.rect.height);
		Vector2 vector2 = new Vector2(_image.sprite.rect.x + vector.x * _image.sprite.rect.width, _image.sprite.rect.y + vector.y * _image.sprite.rect.height);
		vector2.x /= _image.sprite.texture.width;
		vector2.y /= _image.sprite.texture.height;
		return _image.sprite.texture.GetPixelBilinear(vector2.x, vector2.y).a > 0.1f;
	}
}
public class EventSystemChecker : MonoBehaviour
{
	private void Awake()
	{
		if (!UnityEngine.Object.FindObjectOfType<EventSystem>())
		{
			GameObject obj = new GameObject("EventSystem");
			obj.AddComponent<EventSystem>();
			obj.AddComponent<StandaloneInputModule>().forceModuleActive = true;
		}
	}
}
[RequireComponent(typeof(Image))]
public class ForcedReset : MonoBehaviour
{
	private void Update()
	{
		if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
		}
	}
}
namespace UnityStandardAssets.Utility
{
	public class ActivateTrigger : MonoBehaviour
	{
		public enum Mode
		{
			Trigger,
			Replace,
			Activate,
			Enable,
			Animate,
			Deactivate
		}

		public Mode action = Mode.Activate;

		public UnityEngine.Object target;

		public GameObject source;

		public int triggerCount = 1;

		public bool repeatTrigger;

		private void DoActivateTrigger()
		{
			triggerCount--;
			if (triggerCount != 0 && !repeatTrigger)
			{
				return;
			}
			UnityEngine.Object obj = target ?? base.gameObject;
			Behaviour behaviour = obj as Behaviour;
			GameObject gameObject = obj as GameObject;
			if (behaviour != null)
			{
				gameObject = behaviour.gameObject;
			}
			switch (action)
			{
			case Mode.Trigger:
				if (gameObject != null)
				{
					gameObject.BroadcastMessage("DoActivateTrigger");
				}
				break;
			case Mode.Replace:
				if (source != null && gameObject != null)
				{
					UnityEngine.Object.Instantiate(source, gameObject.transform.position, gameObject.transform.rotation);
					UnityEngine.Object.Destroy(gameObject);
				}
				break;
			case Mode.Activate:
				if (gameObject != null)
				{
					gameObject.SetActive(value: true);
				}
				break;
			case Mode.Enable:
				if (behaviour != null)
				{
					behaviour.enabled = true;
				}
				break;
			case Mode.Animate:
				if (gameObject != null)
				{
					gameObject.GetComponent<Animation>().Play();
				}
				break;
			case Mode.Deactivate:
				if (gameObject != null)
				{
					gameObject.SetActive(value: false);
				}
				break;
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			DoActivateTrigger();
		}
	}
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		public class ReplacementDefinition
		{
			public Shader original;

			public Shader replacement;
		}

		[Serializable]
		public class ReplacementList
		{
			public ReplacementDefinition[] items = new ReplacementDefinition[0];
		}

		[SerializeField]
		private ReplacementList m_ReplacementList;

		private void OnEnable()
		{
			Renderer[] array = UnityEngine.Object.FindObjectsOfType<Renderer>();
			UnityEngine.Debug.Log(array.Length + " renderers");
			List<Material> list = new List<Material>();
			List<Material> list2 = new List<Material>();
			int num = 0;
			int num2 = 0;
			ReplacementDefinition[] items = m_ReplacementList.items;
			foreach (ReplacementDefinition replacementDefinition in items)
			{
				Renderer[] array2 = array;
				foreach (Renderer renderer in array2)
				{
					Material[] array3 = null;
					for (int k = 0; k < renderer.sharedMaterials.Length; k++)
					{
						Material material = renderer.sharedMaterials[k];
						if (material.shader == replacementDefinition.original)
						{
							if (array3 == null)
							{
								array3 = renderer.materials;
							}
							if (!list.Contains(material))
							{
								list.Add(material);
								Material material2 = UnityEngine.Object.Instantiate(material);
								material2.shader = replacementDefinition.replacement;
								list2.Add(material2);
								num++;
							}
							UnityEngine.Debug.Log("replacing " + renderer.gameObject.name + " renderer " + k + " with " + list2[list.IndexOf(material)].name);
							array3[k] = list2[list.IndexOf(material)];
							num2++;
						}
					}
					if (array3 != null)
					{
						renderer.materials = array3;
					}
				}
			}
			UnityEngine.Debug.Log(num2 + " material instances replaced");
			UnityEngine.Debug.Log(num + " materials replaced");
			for (int l = 0; l < list.Count; l++)
			{
				UnityEngine.Debug.Log(list[l].name + " (" + list[l].shader.name + ") replaced with " + list2[l].name + " (" + list2[l].shader.name + ")");
			}
		}
	}
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		public class Vector3andSpace
		{
			public Vector3 value;

			public Space space = Space.Self;
		}

		public Vector3andSpace moveUnitsPerSecond;

		public Vector3andSpace rotateDegreesPerSecond;

		public bool ignoreTimescale;

		private float m_LastRealTime;

		private void Start()
		{
			m_LastRealTime = Time.realtimeSinceStartup;
		}

		private void Update()
		{
			float num = Time.deltaTime;
			if (ignoreTimescale)
			{
				num = Time.realtimeSinceStartup - m_LastRealTime;
				m_LastRealTime = Time.realtimeSinceStartup;
			}
			base.transform.Translate(moveUnitsPerSecond.value * num, moveUnitsPerSecond.space);
			base.transform.Rotate(rotateDegreesPerSecond.value * num, moveUnitsPerSecond.space);
		}
	}
	public class CameraRefocus
	{
		public Camera Camera;

		public Vector3 Lookatpoint;

		public Transform Parent;

		private Vector3 m_OrigCameraPos;

		private bool m_Refocus;

		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
			m_OrigCameraPos = origCameraPos;
			Camera = camera;
			Parent = parent;
		}

		public void ChangeCamera(Camera camera)
		{
			Camera = camera;
		}

		public void ChangeParent(Transform parent)
		{
			Parent = parent;
		}

		public void GetFocusPoint()
		{
			if (Physics.Raycast(Parent.transform.position + m_OrigCameraPos, Parent.transform.forward, out var hitInfo, 100f))
			{
				Lookatpoint = hitInfo.point;
				m_Refocus = true;
			}
			else
			{
				m_Refocus = false;
			}
		}

		public void SetFocusPoint()
		{
			if (m_Refocus)
			{
				Camera.transform.LookAt(Lookatpoint);
			}
		}
	}
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
	public class DragRigidbody : MonoBehaviour
	{
		private const float k_Spring = 50f;

		private const float k_Damper = 5f;

		private const float k_Drag = 10f;

		private const float k_AngularDrag = 5f;

		private const float k_Distance = 0.2f;

		private const bool k_AttachToCenterOfMass = false;

		private SpringJoint m_SpringJoint;

		private void Update()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = FindCamera();
			RaycastHit hitInfo = default(RaycastHit);
			if (Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out hitInfo, 100f, -5) && (bool)hitInfo.rigidbody && !hitInfo.rigidbody.isKinematic)
			{
				if (!m_SpringJoint)
				{
					GameObject gameObject = new GameObject("Rigidbody dragger");
					Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
					m_SpringJoint = gameObject.AddComponent<SpringJoint>();
					rigidbody.isKinematic = true;
				}
				m_SpringJoint.transform.position = hitInfo.point;
				m_SpringJoint.anchor = Vector3.zero;
				m_SpringJoint.spring = 50f;
				m_SpringJoint.damper = 5f;
				m_SpringJoint.maxDistance = 0.2f;
				m_SpringJoint.connectedBody = hitInfo.rigidbody;
				StartCoroutine("DragObject", hitInfo.distance);
			}
		}

		private IEnumerator DragObject(float distance)
		{
			float oldDrag = m_SpringJoint.connectedBody.drag;
			float oldAngularDrag = m_SpringJoint.connectedBody.angularDrag;
			m_SpringJoint.connectedBody.drag = 10f;
			m_SpringJoint.connectedBody.angularDrag = 5f;
			Camera mainCamera = FindCamera();
			while (Input.GetMouseButton(0))
			{
				Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
				m_SpringJoint.transform.position = ray.GetPoint(distance);
				yield return null;
			}
			if ((bool)m_SpringJoint.connectedBody)
			{
				m_SpringJoint.connectedBody.drag = oldDrag;
				m_SpringJoint.connectedBody.angularDrag = oldAngularDrag;
				m_SpringJoint.connectedBody = null;
			}
		}

		private Camera FindCamera()
		{
			if ((bool)GetComponent<Camera>())
			{
				return GetComponent<Camera>();
			}
			return Camera.main;
		}
	}
	public class DynamicShadowSettings : MonoBehaviour
	{
		public Light sunLight;

		public float minHeight = 10f;

		public float minShadowDistance = 80f;

		public float minShadowBias = 1f;

		public float maxHeight = 1000f;

		public float maxShadowDistance = 10000f;

		public float maxShadowBias = 0.1f;

		public float adaptTime = 1f;

		private float m_SmoothHeight;

		private float m_ChangeSpeed;

		private float m_OriginalStrength = 1f;

		private void Start()
		{
			m_OriginalStrength = sunLight.shadowStrength;
		}

		private void Update()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			if (Physics.Raycast(ray, out var hitInfo))
			{
				num = hitInfo.distance;
			}
			if (Mathf.Abs(num - m_SmoothHeight) > 1f)
			{
				m_SmoothHeight = Mathf.SmoothDamp(m_SmoothHeight, num, ref m_ChangeSpeed, adaptTime);
			}
			float num2 = Mathf.InverseLerp(minHeight, maxHeight, m_SmoothHeight);
			QualitySettings.shadowDistance = Mathf.Lerp(minShadowDistance, maxShadowDistance, num2);
			sunLight.shadowBias = Mathf.Lerp(minShadowBias, maxShadowBias, 1f - (1f - num2) * (1f - num2));
			sunLight.shadowStrength = Mathf.Lerp(m_OriginalStrength, 0f, num2);
		}
	}
	public class FollowTarget : MonoBehaviour
	{
		public Transform target;

		public Vector3 offset = new Vector3(0f, 7.5f, 0f);

		private void LateUpdate()
		{
			base.transform.position = target.position + offset;
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
	public class ObjectResetter : MonoBehaviour
	{
		private Vector3 originalPosition;

		private Quaternion originalRotation;

		private List<Transform> originalStructure;

		private Rigidbody Rigidbody;

		private void Start()
		{
			originalStructure = new List<Transform>(GetComponentsInChildren<Transform>());
			originalPosition = base.transform.position;
			originalRotation = base.transform.rotation;
			Rigidbody = GetComponent<Rigidbody>();
		}

		public void DelayedReset(float delay)
		{
			StartCoroutine(ResetCoroutine(delay));
		}

		public IEnumerator ResetCoroutine(float delay)
		{
			yield return new WaitForSeconds(delay);
			Transform[] componentsInChildren = GetComponentsInChildren<Transform>();
			foreach (Transform transform in componentsInChildren)
			{
				if (!originalStructure.Contains(transform))
				{
					transform.parent = null;
				}
			}
			base.transform.position = originalPosition;
			base.transform.rotation = originalRotation;
			if ((bool)Rigidbody)
			{
				Rigidbody.velocity = Vector3.zero;
				Rigidbody.angularVelocity = Vector3.zero;
			}
			SendMessage("Reset");
		}
	}
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		public float minDuration = 8f;

		public float maxDuration = 10f;

		private float m_MaxLifetime;

		private bool m_EarlyStop;

		private IEnumerator Start()
		{
			ParticleSystem[] systems = GetComponentsInChildren<ParticleSystem>();
			ParticleSystem[] array = systems;
			foreach (ParticleSystem particleSystem in array)
			{
				m_MaxLifetime = Mathf.Max(particleSystem.main.startLifetime.constant, m_MaxLifetime);
			}
			float stopTime = Time.time + UnityEngine.Random.Range(minDuration, maxDuration);
			while (Time.time < stopTime && !m_EarlyStop)
			{
				yield return null;
			}
			UnityEngine.Debug.Log("stopping " + base.name);
			array = systems;
			for (int i = 0; i < array.Length; i++)
			{
				ParticleSystem.EmissionModule emission = array[i].emission;
				emission.enabled = false;
			}
			BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(m_MaxLifetime);
			UnityEngine.Object.Destroy(base.gameObject);
		}

		public void Stop()
		{
			m_EarlyStop = true;
		}
	}
	public class PlatformSpecificContent : MonoBehaviour
	{
		private enum BuildTargetGroup
		{
			Standalone,
			Mobile
		}

		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[SerializeField]
		private GameObject[] m_Content = new GameObject[0];

		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours = new MonoBehaviour[0];

		[SerializeField]
		private bool m_ChildrenOfThisObject;

		private void OnEnable()
		{
			CheckEnableContent();
		}

		private void CheckEnableContent()
		{
			if (m_BuildTargetGroup == BuildTargetGroup.Mobile)
			{
				EnableContent(enabled: true);
			}
			else
			{
				EnableContent(enabled: false);
			}
		}

		private void EnableContent(bool enabled)
		{
			if (m_Content.Length != 0)
			{
				GameObject[] content = m_Content;
				foreach (GameObject gameObject in content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(enabled);
					}
				}
			}
			if (m_ChildrenOfThisObject)
			{
				foreach (Transform item in base.transform)
				{
					item.gameObject.SetActive(enabled);
				}
			}
			if (m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = enabled;
				}
			}
		}
	}
	public class SimpleActivatorMenu : MonoBehaviour
	{
		public GUIText camSwitchButton;

		public GameObject[] objects;

		private int m_CurrentActiveObject;

		private void OnEnable()
		{
			m_CurrentActiveObject = 0;
			camSwitchButton.text = objects[m_CurrentActiveObject].name;
		}

		public void NextCamera()
		{
			int num = ((m_CurrentActiveObject + 1 < objects.Length) ? (m_CurrentActiveObject + 1) : 0);
			for (int i = 0; i < objects.Length; i++)
			{
				objects[i].SetActive(i == num);
			}
			m_CurrentActiveObject = num;
			camSwitchButton.text = objects[m_CurrentActiveObject].name;
		}
	}
	public class SimpleMouseRotator : MonoBehaviour
	{
		public Vector2 rotationRange = new Vector3(70f, 70f);

		public float rotationSpeed = 10f;

		public float dampingTime = 0.2f;

		public bool autoZeroVerticalOnMobile = true;

		public bool autoZeroHorizontalOnMobile;

		public bool relative = true;

		private Vector3 m_TargetAngles;

		private Vector3 m_FollowAngles;

		private Vector3 m_FollowVelocity;

		private Quaternion m_OriginalRotation;

		private void Start()
		{
			m_OriginalRotation = base.transform.localRotation;
		}

		private void Update()
		{
			base.transform.localRotation = m_OriginalRotation;
			if (relative)
			{
				float axis = CrossPlatformInputManager.GetAxis("Mouse X");
				float axis2 = CrossPlatformInputManager.GetAxis("Mouse Y");
				if (m_TargetAngles.y > 180f)
				{
					m_TargetAngles.y -= 360f;
					m_FollowAngles.y -= 360f;
				}
				if (m_TargetAngles.x > 180f)
				{
					m_TargetAngles.x -= 360f;
					m_FollowAngles.x -= 360f;
				}
				if (m_TargetAngles.y < -180f)
				{
					m_TargetAngles.y += 360f;
					m_FollowAngles.y += 360f;
				}
				if (m_TargetAngles.x < -180f)
				{
					m_TargetAngles.x += 360f;
					m_FollowAngles.x += 360f;
				}
				if (autoZeroHorizontalOnMobile)
				{
					m_TargetAngles.y = Mathf.Lerp((0f - rotationRange.y) * 0.5f, rotationRange.y * 0.5f, axis * 0.5f + 0.5f);
				}
				else
				{
					m_TargetAngles.y += axis * rotationSpeed;
				}
				if (autoZeroVerticalOnMobile)
				{
					m_TargetAngles.x = Mathf.Lerp((0f - rotationRange.x) * 0.5f, rotationRange.x * 0.5f, axis2 * 0.5f + 0.5f);
				}
				else
				{
					m_TargetAngles.x += axis2 * rotationSpeed;
				}
				m_TargetAngles.y = Mathf.Clamp(m_TargetAngles.y, (0f - rotationRange.y) * 0.5f, rotationRange.y * 0.5f);
				m_TargetAngles.x = Mathf.Clamp(m_TargetAngles.x, (0f - rotationRange.x) * 0.5f, rotationRange.x * 0.5f);
			}
			else
			{
				float axis = Input.mousePosition.x;
				float axis2 = Input.mousePosition.y;
				m_TargetAngles.y = Mathf.Lerp((0f - rotationRange.y) * 0.5f, rotationRange.y * 0.5f, axis / (float)Screen.width);
				m_TargetAngles.x = Mathf.Lerp((0f - rotationRange.x) * 0.5f, rotationRange.x * 0.5f, axis2 / (float)Screen.height);
			}
			m_FollowAngles = Vector3.SmoothDamp(m_FollowAngles, m_TargetAngles, ref m_FollowVelocity, dampingTime);
			base.transform.localRotation = m_OriginalRotation * Quaternion.Euler(0f - m_FollowAngles.x, m_FollowAngles.y, 0f);
		}
	}
	public class SmoothFollow : MonoBehaviour
	{
		[SerializeField]
		private Transform target;

		[SerializeField]
		private float distance = 10f;

		[SerializeField]
		private float height = 5f;

		[SerializeField]
		private float rotationDamping;

		[SerializeField]
		private float heightDamping;

		private void Start()
		{
		}

		private void LateUpdate()
		{
			if ((bool)target)
			{
				float y = target.eulerAngles.y;
				float b = target.position.y + height;
				float y2 = base.transform.eulerAngles.y;
				float y3 = base.transform.position.y;
				y2 = Mathf.LerpAngle(y2, y, rotationDamping * Time.deltaTime);
				y3 = Mathf.Lerp(y3, b, heightDamping * Time.deltaTime);
				Quaternion quaternion = Quaternion.Euler(0f, y2, 0f);
				base.transform.position = target.position;
				base.transform.position -= quaternion * Vector3.forward * distance;
				base.transform.position = new Vector3(base.transform.position.x, y3, base.transform.position.z);
				base.transform.LookAt(target);
			}
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
	public class TimedObjectDestructor : MonoBehaviour
	{
		[SerializeField]
		private float m_TimeOut = 1f;

		[SerializeField]
		private bool m_DetachChildren;

		private void Awake()
		{
			Invoke("DestroyNow", m_TimeOut);
		}

		private void DestroyNow()
		{
			if (m_DetachChildren)
			{
				base.transform.DetachChildren();
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		public class WaypointList
		{
			public WaypointCircuit circuit;

			public Transform[] items = new Transform[0];
		}

		public struct RoutePoint
		{
			public Vector3 position;

			public Vector3 direction;

			public RoutePoint(Vector3 position, Vector3 direction)
			{
				this.position = position;
				this.direction = direction;
			}
		}

		public WaypointList waypointList = new WaypointList();

		[SerializeField]
		private bool smoothRoute = true;

		private int numPoints;

		private Vector3[] points;

		private float[] distances;

		public float editorVisualisationSubsteps = 100f;

		private int p0n;

		private int p1n;

		private int p2n;

		private int p3n;

		private float i;

		private Vector3 P0;

		private Vector3 P1;

		private Vector3 P2;

		private Vector3 P3;

		public float Length { get; private set; }

		public Transform[] Waypoints => waypointList.items;

		private void Awake()
		{
			if (Waypoints.Length > 1)
			{
				CachePositionsAndDistances();
			}
			numPoints = Waypoints.Length;
		}

		public RoutePoint GetRoutePoint(float dist)
		{
			Vector3 routePosition = GetRoutePosition(dist);
			return new RoutePoint(routePosition, (GetRoutePosition(dist + 0.1f) - routePosition).normalized);
		}

		public Vector3 GetRoutePosition(float dist)
		{
			int i = 0;
			if (Length == 0f)
			{
				Length = distances[distances.Length - 1];
			}
			for (dist = Mathf.Repeat(dist, Length); distances[i] < dist; i++)
			{
			}
			p1n = (i - 1 + numPoints) % numPoints;
			p2n = i;
			this.i = Mathf.InverseLerp(distances[p1n], distances[p2n], dist);
			if (smoothRoute)
			{
				p0n = (i - 2 + numPoints) % numPoints;
				p3n = (i + 1) % numPoints;
				p2n %= numPoints;
				P0 = points[p0n];
				P1 = points[p1n];
				P2 = points[p2n];
				P3 = points[p3n];
				return CatmullRom(P0, P1, P2, P3, this.i);
			}
			p1n = (i - 1 + numPoints) % numPoints;
			p2n = i;
			return Vector3.Lerp(points[p1n], points[p2n], this.i);
		}

		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return 0.5f * (2f * p1 + (-p0 + p2) * i + (2f * p0 - 5f * p1 + 4f * p2 - p3) * i * i + (-p0 + 3f * p1 - 3f * p2 + p3) * i * i * i);
		}

		private void CachePositionsAndDistances()
		{
			points = new Vector3[Waypoints.Length + 1];
			distances = new float[Waypoints.Length + 1];
			float num = 0f;
			for (int i = 0; i < points.Length; i++)
			{
				Transform transform = Waypoints[i % Waypoints.Length];
				Transform transform2 = Waypoints[(i + 1) % Waypoints.Length];
				if (transform != null && transform2 != null)
				{
					Vector3 position = transform.position;
					Vector3 position2 = transform2.position;
					points[i] = Waypoints[i % Waypoints.Length].position;
					distances[i] = num;
					num += (position - position2).magnitude;
				}
			}
		}

		private void OnDrawGizmos()
		{
			DrawGizmos(selected: false);
		}

		private void OnDrawGizmosSelected()
		{
			DrawGizmos(selected: true);
		}

		private void DrawGizmos(bool selected)
		{
			waypointList.circuit = this;
			if (Waypoints.Length <= 1)
			{
				return;
			}
			numPoints = Waypoints.Length;
			CachePositionsAndDistances();
			Length = distances[distances.Length - 1];
			Gizmos.color = (selected ? Color.yellow : new Color(1f, 1f, 0f, 0.5f));
			Vector3 from = Waypoints[0].position;
			if (smoothRoute)
			{
				for (float num = 0f; num < Length; num += Length / editorVisualisationSubsteps)
				{
					Vector3 routePosition = GetRoutePosition(num + 1f);
					Gizmos.DrawLine(from, routePosition);
					from = routePosition;
				}
				Gizmos.DrawLine(from, Waypoints[0].position);
			}
			else
			{
				for (int i = 0; i < Waypoints.Length; i++)
				{
					Vector3 position = Waypoints[(i + 1) % Waypoints.Length].position;
					Gizmos.DrawLine(from, position);
					from = position;
				}
			}
		}
	}
	public class WaypointProgressTracker : MonoBehaviour
	{
		public enum ProgressStyle
		{
			SmoothAlongRoute,
			PointToPoint
		}

		[SerializeField]
		private WaypointCircuit circuit;

		[SerializeField]
		private float lookAheadForTargetOffset = 5f;

		[SerializeField]
		private float lookAheadForTargetFactor = 0.1f;

		[SerializeField]
		private float lookAheadForSpeedOffset = 10f;

		[SerializeField]
		private float lookAheadForSpeedFactor = 0.2f;

		[SerializeField]
		private ProgressStyle progressStyle;

		[SerializeField]
		private float pointToPointThreshold = 4f;

		public Transform target;

		private float progressDistance;

		private int progressNum;

		private Vector3 lastPosition;

		private float speed;

		public WaypointCircuit.RoutePoint targetPoint { get; private set; }

		public WaypointCircuit.RoutePoint speedPoint { get; private set; }

		public WaypointCircuit.RoutePoint progressPoint { get; private set; }

		private void Start()
		{
			if (target == null)
			{
				target = new GameObject(base.name + " Waypoint Target").transform;
			}
			Reset();
		}

		public void Reset()
		{
			progressDistance = 0f;
			progressNum = 0;
			if (progressStyle == ProgressStyle.PointToPoint)
			{
				target.position = circuit.Waypoints[progressNum].position;
				target.rotation = circuit.Waypoints[progressNum].rotation;
			}
		}

		private void Update()
		{
			if (progressStyle == ProgressStyle.SmoothAlongRoute)
			{
				if (Time.deltaTime > 0f)
				{
					speed = Mathf.Lerp(speed, (lastPosition - base.transform.position).magnitude / Time.deltaTime, Time.deltaTime);
				}
				target.position = circuit.GetRoutePoint(progressDistance + lookAheadForTargetOffset + lookAheadForTargetFactor * speed).position;
				target.rotation = Quaternion.LookRotation(circuit.GetRoutePoint(progressDistance + lookAheadForSpeedOffset + lookAheadForSpeedFactor * speed).direction);
				progressPoint = circuit.GetRoutePoint(progressDistance);
				Vector3 lhs = progressPoint.position - base.transform.position;
				if (Vector3.Dot(lhs, progressPoint.direction) < 0f)
				{
					progressDistance += lhs.magnitude * 0.5f;
				}
				lastPosition = base.transform.position;
			}
			else
			{
				if ((target.position - base.transform.position).magnitude < pointToPointThreshold)
				{
					progressNum = (progressNum + 1) % circuit.Waypoints.Length;
				}
				target.position = circuit.Waypoints[progressNum].position;
				target.rotation = circuit.Waypoints[progressNum].rotation;
				progressPoint = circuit.GetRoutePoint(progressDistance);
				Vector3 lhs2 = progressPoint.position - base.transform.position;
				if (Vector3.Dot(lhs2, progressPoint.direction) < 0f)
				{
					progressDistance += lhs2.magnitude;
				}
				lastPosition = base.transform.position;
			}
		}

		private void OnDrawGizmos()
		{
			if (Application.isPlaying)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawLine(base.transform.position, target.position);
				Gizmos.DrawWireSphere(circuit.GetRoutePosition(progressDistance), 1f);
				Gizmos.color = Color.yellow;
				Gizmos.DrawLine(target.position, target.position + target.forward);
			}
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[RequireComponent(typeof(SphereCollider))]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		public float effectAngle = 15f;

		public float effectWidth = 1f;

		public float effectDistance = 10f;

		public float force = 10f;

		private Collider[] m_Cols;

		private SphereCollider m_Sphere;

		private void OnEnable()
		{
			m_Sphere = GetComponent<Collider>() as SphereCollider;
		}

		private void FixedUpdate()
		{
			m_Cols = Physics.OverlapSphere(base.transform.position + m_Sphere.center, m_Sphere.radius);
			for (int i = 0; i < m_Cols.Length; i++)
			{
				if (m_Cols[i].attachedRigidbody != null)
				{
					Vector3 current = base.transform.InverseTransformPoint(m_Cols[i].transform.position);
					current = Vector3.MoveTowards(current, new Vector3(0f, 0f, current.z), effectWidth * 0.5f);
					float value = Mathf.Abs(Mathf.Atan2(current.x, current.z) * 57.29578f);
					float num = Mathf.InverseLerp(effectDistance, 0f, current.magnitude);
					num *= Mathf.InverseLerp(effectAngle, 0f, value);
					Vector3 vector = m_Cols[i].transform.position - base.transform.position;
					m_Cols[i].attachedRigidbody.AddForceAtPosition(vector.normalized * force * num, Vector3.Lerp(m_Cols[i].transform.position, base.transform.TransformPoint(0f, 0f, current.z), 0.1f));
				}
			}
		}

		private void OnDrawGizmosSelected()
		{
			if (m_Sphere == null)
			{
				m_Sphere = GetComponent<Collider>() as SphereCollider;
			}
			m_Sphere.radius = effectDistance * 0.5f;
			m_Sphere.center = new Vector3(0f, 0f, effectDistance * 0.5f);
			Vector3[] array = new Vector3[4]
			{
				Vector3.up,
				-Vector3.up,
				Vector3.right,
				-Vector3.right
			};
			Vector3[] array2 = new Vector3[4]
			{
				-Vector3.right,
				Vector3.right,
				Vector3.up,
				-Vector3.up
			};
			Gizmos.color = new Color(0f, 1f, 0f, 0.5f);
			for (int i = 0; i < 4; i++)
			{
				Vector3 vector = base.transform.position + base.transform.rotation * array[i] * effectWidth * 0.5f;
				Vector3 vector2 = base.transform.TransformDirection(Quaternion.AngleAxis(effectAngle, array2[i]) * Vector3.forward);
				Gizmos.DrawLine(vector, vector + vector2 * m_Sphere.radius * 2f);
			}
		}
	}
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		public Transform[] debrisPrefabs;

		public Transform firePrefab;

		public int numDebrisPieces;

		public int numFires;

		private IEnumerator Start()
		{
			float multiplier = GetComponent<ParticleSystemMultiplier>().multiplier;
			for (int i = 0; (float)i < (float)numDebrisPieces * multiplier; i++)
			{
				Transform original = debrisPrefabs[UnityEngine.Random.Range(0, debrisPrefabs.Length)];
				Vector3 position = base.transform.position + UnityEngine.Random.insideUnitSphere * 3f * multiplier;
				Quaternion rotation = UnityEngine.Random.rotation;
				UnityEngine.Object.Instantiate(original, position, rotation);
			}
			yield return null;
			float num = 10f * multiplier;
			Collider[] array = Physics.OverlapSphere(base.transform.position, num);
			foreach (Collider collider in array)
			{
				if (numFires > 0)
				{
					Ray ray = new Ray(base.transform.position, collider.transform.position - base.transform.position);
					if (collider.Raycast(ray, out var hitInfo, num))
					{
						AddFire(collider.transform, hitInfo.point, hitInfo.normal);
						numFires--;
					}
				}
			}
			float num2 = 0f;
			while (numFires > 0 && num2 < num)
			{
				if (Physics.Raycast(new Ray(base.transform.position + Vector3.up, UnityEngine.Random.onUnitSphere), out var hitInfo2, num2))
				{
					AddFire(null, hitInfo2.point, hitInfo2.normal);
					numFires--;
				}
				num2 += num * 0.1f;
			}
		}

		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
			pos += normal * 0.5f;
			UnityEngine.Object.Instantiate(firePrefab, pos, Quaternion.identity).parent = t;
		}
	}
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		public float explosionForce = 4f;

		private IEnumerator Start()
		{
			yield return null;
			float multiplier = GetComponent<ParticleSystemMultiplier>().multiplier;
			float num = 10f * multiplier;
			Collider[] array = Physics.OverlapSphere(base.transform.position, num);
			List<Rigidbody> list = new List<Rigidbody>();
			Collider[] array2 = array;
			foreach (Collider collider in array2)
			{
				if (collider.attachedRigidbody != null && !list.Contains(collider.attachedRigidbody))
				{
					list.Add(collider.attachedRigidbody);
				}
			}
			foreach (Rigidbody item in list)
			{
				item.AddExplosionForce(explosionForce * multiplier, base.transform.position, num, 1f * multiplier, ForceMode.Impulse);
			}
		}
	}
	public class Explosive : MonoBehaviour
	{
		public Transform explosionPrefab;

		public float detonationImpactVelocity = 10f;

		public float sizeMultiplier = 1f;

		public bool reset = true;

		public float resetTimeDelay = 10f;

		private bool m_Exploded;

		private ObjectResetter m_ObjectResetter;

		private void Start()
		{
			m_ObjectResetter = GetComponent<ObjectResetter>();
		}

		private IEnumerator OnCollisionEnter(Collision col)
		{
			if (base.enabled && col.contacts.Length != 0 && (Vector3.Project(col.relativeVelocity, col.contacts[0].normal).magnitude > detonationImpactVelocity || m_Exploded) && !m_Exploded)
			{
				UnityEngine.Object.Instantiate(explosionPrefab, col.contacts[0].point, Quaternion.LookRotation(col.contacts[0].normal));
				m_Exploded = true;
				SendMessage("Immobilize");
				if (reset)
				{
					m_ObjectResetter.DelayedReset(resetTimeDelay);
				}
			}
			yield return null;
		}

		public void Reset()
		{
			m_Exploded = false;
		}
	}
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		public float multiplier = 1f;

		private ParticleSystem[] m_Systems;

		private void Start()
		{
			m_Systems = GetComponentsInChildren<ParticleSystem>();
		}

		public void Extinguish()
		{
			ParticleSystem[] systems = m_Systems;
			for (int i = 0; i < systems.Length; i++)
			{
				ParticleSystem.EmissionModule emission = systems[i].emission;
				emission.enabled = false;
			}
		}
	}
	public class FireLight : MonoBehaviour
	{
		private float m_Rnd;

		private bool m_Burning = true;

		private Light m_Light;

		private void Start()
		{
			m_Rnd = UnityEngine.Random.value * 100f;
			m_Light = GetComponent<Light>();
		}

		private void Update()
		{
			if (m_Burning)
			{
				m_Light.intensity = 2f * Mathf.PerlinNoise(m_Rnd + Time.time, m_Rnd + 1f + Time.time * 1f);
				float x = Mathf.PerlinNoise(m_Rnd + 0f + Time.time * 2f, m_Rnd + 1f + Time.time * 2f) - 0.5f;
				float y = Mathf.PerlinNoise(m_Rnd + 2f + Time.time * 2f, m_Rnd + 3f + Time.time * 2f) - 0.5f;
				float z = Mathf.PerlinNoise(m_Rnd + 4f + Time.time * 2f, m_Rnd + 5f + Time.time * 2f) - 0.5f;
				base.transform.localPosition = Vector3.up + new Vector3(x, y, z) * 1f;
			}
		}

		public void Extinguish()
		{
			m_Burning = false;
			m_Light.enabled = false;
		}
	}
	public class Hose : MonoBehaviour
	{
		public float maxPower = 20f;

		public float minPower = 5f;

		public float changeSpeed = 5f;

		public ParticleSystem[] hoseWaterSystems;

		public Renderer systemRenderer;

		private float m_Power;

		private void Update()
		{
			m_Power = Mathf.Lerp(m_Power, Input.GetMouseButton(0) ? maxPower : minPower, Time.deltaTime * changeSpeed);
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				systemRenderer.enabled = !systemRenderer.enabled;
			}
			ParticleSystem[] array = hoseWaterSystems;
			foreach (ParticleSystem obj in array)
			{
				ParticleSystem.MainModule main = obj.main;
				main.startSpeed = m_Power;
				ParticleSystem.EmissionModule emission = obj.emission;
				emission.enabled = m_Power > minPower * 1.1f;
			}
		}
	}
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		public float multiplier = 1f;

		private void Start()
		{
			ParticleSystem[] componentsInChildren = GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem obj in componentsInChildren)
			{
				ParticleSystem.MainModule main = obj.main;
				main.startSizeMultiplier *= multiplier;
				main.startSpeedMultiplier *= multiplier;
				main.startLifetimeMultiplier *= Mathf.Lerp(multiplier, 1f, 0.5f);
				obj.Clear();
				obj.Play();
			}
		}
	}
	public class SmokeParticles : MonoBehaviour
	{
		public AudioClip[] extinguishSounds;

		private void Start()
		{
			GetComponent<AudioSource>().clip = extinguishSounds[UnityEngine.Random.Range(0, extinguishSounds.Length)];
			GetComponent<AudioSource>().Play();
		}
	}
	public class WaterHoseParticles : MonoBehaviour
	{
		public static float lastSoundTime;

		public float force = 1f;

		private List<ParticleCollisionEvent> m_CollisionEvents = new List<ParticleCollisionEvent>();

		private ParticleSystem m_ParticleSystem;

		private void Start()
		{
			m_ParticleSystem = GetComponent<ParticleSystem>();
		}

		private void OnParticleCollision(GameObject other)
		{
			int collisionEvents = m_ParticleSystem.GetCollisionEvents(other, m_CollisionEvents);
			for (int i = 0; i < collisionEvents; i++)
			{
				if (Time.time > lastSoundTime + 0.2f)
				{
					lastSoundTime = Time.time;
				}
				Rigidbody component = m_CollisionEvents[i].colliderComponent.GetComponent<Rigidbody>();
				if (component != null)
				{
					Vector3 velocity = m_CollisionEvents[i].velocity;
					component.AddForce(velocity * force, ForceMode.Impulse);
				}
				other.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		public string axisName = "Horizontal";

		public float axisValue = 1f;

		public float responseSpeed = 3f;

		public float returnToCentreSpeed = 3f;

		private AxisTouchButton m_PairedWith;

		private CrossPlatformInputManager.VirtualAxis m_Axis;

		private void OnEnable()
		{
			if (!CrossPlatformInputManager.AxisExists(axisName))
			{
				m_Axis = new CrossPlatformInputManager.VirtualAxis(axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_Axis);
			}
			else
			{
				m_Axis = CrossPlatformInputManager.VirtualAxisReference(axisName);
			}
			FindPairedButton();
		}

		private void FindPairedButton()
		{
			if (!(UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) is AxisTouchButton[] array))
			{
				return;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].axisName == axisName && array[i] != this)
				{
					m_PairedWith = array[i];
				}
			}
		}

		private void OnDisable()
		{
			m_Axis.Remove();
		}

		public void OnPointerDown(PointerEventData data)
		{
			if (m_PairedWith == null)
			{
				FindPairedButton();
			}
			m_Axis.Update(Mathf.MoveTowards(m_Axis.GetValue, axisValue, responseSpeed * Time.deltaTime));
		}

		public void OnPointerUp(PointerEventData data)
		{
			m_Axis.Update(Mathf.MoveTowards(m_Axis.GetValue, 0f, responseSpeed * Time.deltaTime));
		}
	}
	public class ButtonHandler : MonoBehaviour
	{
		public string Name;

		private void OnEnable()
		{
		}

		public void SetDownState()
		{
			CrossPlatformInputManager.SetButtonDown(Name);
		}

		public void SetUpState()
		{
			CrossPlatformInputManager.SetButtonUp(Name);
		}

		public void SetAxisPositiveState()
		{
			CrossPlatformInputManager.SetAxisPositive(Name);
		}

		public void SetAxisNeutralState()
		{
			CrossPlatformInputManager.SetAxisZero(Name);
		}

		public void SetAxisNegativeState()
		{
			CrossPlatformInputManager.SetAxisNegative(Name);
		}

		public void Update()
		{
		}
	}
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
	public class InputAxisScrollbar : MonoBehaviour
	{
		public string axis;

		private void Update()
		{
		}

		public void HandleInput(float value)
		{
			CrossPlatformInputManager.SetAxis(axis, value * 2f - 1f);
		}
	}
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		public enum AxisOption
		{
			Both,
			OnlyHorizontal,
			OnlyVertical
		}

		public int MovementRange = 100;

		public AxisOption axesToUse;

		public string horizontalAxisName = "Horizontal";

		public string verticalAxisName = "Vertical";

		private Vector3 m_StartPos;

		private bool m_UseX;

		private bool m_UseY;

		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		private void OnEnable()
		{
			CreateVirtualAxes();
		}

		private void Start()
		{
			m_StartPos = base.transform.position;
		}

		private void UpdateVirtualAxes(Vector3 value)
		{
			Vector3 vector = m_StartPos - value;
			vector.y = 0f - vector.y;
			vector /= (float)MovementRange;
			if (m_UseX)
			{
				m_HorizontalVirtualAxis.Update(0f - vector.x);
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis.Update(vector.y);
			}
		}

		private void CreateVirtualAxes()
		{
			m_UseX = axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyHorizontal;
			m_UseY = axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyVertical;
			if (m_UseX)
			{
				m_HorizontalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(horizontalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_HorizontalVirtualAxis);
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(verticalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_VerticalVirtualAxis);
			}
		}

		public void OnDrag(PointerEventData data)
		{
			Vector3 zero = Vector3.zero;
			if (m_UseX)
			{
				int value = (int)(data.position.x - m_StartPos.x);
				value = Mathf.Clamp(value, -MovementRange, MovementRange);
				zero.x = value;
			}
			if (m_UseY)
			{
				int value2 = (int)(data.position.y - m_StartPos.y);
				value2 = Mathf.Clamp(value2, -MovementRange, MovementRange);
				zero.y = value2;
			}
			base.transform.position = new Vector3(m_StartPos.x + zero.x, m_StartPos.y + zero.y, m_StartPos.z + zero.z);
			UpdateVirtualAxes(base.transform.position);
		}

		public void OnPointerUp(PointerEventData data)
		{
			base.transform.position = m_StartPos;
			UpdateVirtualAxes(m_StartPos);
		}

		public void OnPointerDown(PointerEventData data)
		{
		}

		private void OnDisable()
		{
			if (m_UseX)
			{
				m_HorizontalVirtualAxis.Remove();
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis.Remove();
			}
		}
	}
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		private void OnEnable()
		{
			CheckEnableControlRig();
		}

		private void Start()
		{
			if (UnityEngine.Object.FindObjectOfType<EventSystem>() == null)
			{
				GameObject obj = new GameObject("EventSystem");
				obj.AddComponent<EventSystem>();
				obj.AddComponent<StandaloneInputModule>();
			}
		}

		private void CheckEnableControlRig()
		{
			EnableControlRig(enabled: true);
		}

		private void EnableControlRig(bool enabled)
		{
			foreach (Transform item in base.transform)
			{
				item.gameObject.SetActive(enabled);
			}
		}
	}
	public class TiltInput : MonoBehaviour
	{
		public enum AxisOptions
		{
			ForwardAxis,
			SidewaysAxis
		}

		[Serializable]
		public class AxisMapping
		{
			public enum MappingType
			{
				NamedAxis,
				MousePositionX,
				MousePositionY,
				MousePositionZ
			}

			public MappingType type;

			public string axisName;
		}

		public AxisMapping mapping;

		public AxisOptions tiltAroundAxis;

		public float fullTiltAngle = 25f;

		public float centreAngleOffset;

		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		private void OnEnable()
		{
			if (mapping.type == AxisMapping.MappingType.NamedAxis)
			{
				m_SteerAxis = new CrossPlatformInputManager.VirtualAxis(mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_SteerAxis);
			}
		}

		private void Update()
		{
			float value = 0f;
			if (Input.acceleration != Vector3.zero)
			{
				switch (tiltAroundAxis)
				{
				case AxisOptions.ForwardAxis:
					value = Mathf.Atan2(Input.acceleration.x, 0f - Input.acceleration.y) * 57.29578f + centreAngleOffset;
					break;
				case AxisOptions.SidewaysAxis:
					value = Mathf.Atan2(Input.acceleration.z, 0f - Input.acceleration.y) * 57.29578f + centreAngleOffset;
					break;
				}
			}
			float num = Mathf.InverseLerp(0f - fullTiltAngle, fullTiltAngle, value) * 2f - 1f;
			switch (mapping.type)
			{
			case AxisMapping.MappingType.NamedAxis:
				m_SteerAxis.Update(num);
				break;
			case AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		private void OnDisable()
		{
			m_SteerAxis.Remove();
		}
	}
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		public enum AxisOption
		{
			Both,
			OnlyHorizontal,
			OnlyVertical
		}

		public enum ControlStyle
		{
			Absolute,
			Relative,
			Swipe
		}

		public AxisOption axesToUse;

		public ControlStyle controlStyle;

		public string horizontalAxisName = "Horizontal";

		public string verticalAxisName = "Vertical";

		public float Xsensitivity = 1f;

		public float Ysensitivity = 1f;

		private Vector3 m_StartPos;

		private Vector2 m_PreviousDelta;

		private Vector3 m_JoytickOutput;

		private bool m_UseX;

		private bool m_UseY;

		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		private bool m_Dragging;

		private int m_Id = -1;

		private Vector2 m_PreviousTouchPos;

		private Vector3 m_Center;

		private Image m_Image;

		private void OnEnable()
		{
			CreateVirtualAxes();
		}

		private void Start()
		{
			m_Image = GetComponent<Image>();
			m_Center = m_Image.transform.position;
		}

		private void CreateVirtualAxes()
		{
			m_UseX = axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyHorizontal;
			m_UseY = axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyVertical;
			if (m_UseX)
			{
				m_HorizontalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(horizontalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_HorizontalVirtualAxis);
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(verticalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_VerticalVirtualAxis);
			}
		}

		private void UpdateVirtualAxes(Vector3 value)
		{
			value = value.normalized;
			if (m_UseX)
			{
				m_HorizontalVirtualAxis.Update(value.x);
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis.Update(value.y);
			}
		}

		public void OnPointerDown(PointerEventData data)
		{
			m_Dragging = true;
			m_Id = data.pointerId;
			if (controlStyle != 0)
			{
				m_Center = data.position;
			}
		}

		private void Update()
		{
			if (m_Dragging && Input.touchCount >= m_Id + 1 && m_Id != -1)
			{
				if (controlStyle == ControlStyle.Swipe)
				{
					m_Center = m_PreviousTouchPos;
					m_PreviousTouchPos = Input.touches[m_Id].position;
				}
				Vector2 normalized = new Vector2(Input.touches[m_Id].position.x - m_Center.x, Input.touches[m_Id].position.y - m_Center.y).normalized;
				normalized.x *= Xsensitivity;
				normalized.y *= Ysensitivity;
				UpdateVirtualAxes(new Vector3(normalized.x, normalized.y, 0f));
			}
		}

		public void OnPointerUp(PointerEventData data)
		{
			m_Dragging = false;
			m_Id = -1;
			UpdateVirtualAxes(Vector3.zero);
		}

		private void OnDisable()
		{
			if (CrossPlatformInputManager.AxisExists(horizontalAxisName))
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(horizontalAxisName);
			}
			if (CrossPlatformInputManager.AxisExists(verticalAxisName))
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(verticalAxisName);
			}
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
namespace UnityStandardAssets.Vehicles.Car
{
	public class BrakeLight : MonoBehaviour
	{
		public CarController car;

		private Renderer m_Renderer;

		private void Start()
		{
			m_Renderer = GetComponent<Renderer>();
		}

		private void Update()
		{
			m_Renderer.enabled = car.BrakeInput > 0f;
		}
	}
	[RequireComponent(typeof(CarController))]
	public class CarAIControl : MonoBehaviour
	{
		public enum BrakeCondition
		{
			NeverBrake,
			TargetDirectionDifference,
			TargetDistance
		}

		[SerializeField]
		[Range(0f, 1f)]
		private float m_CautiousSpeedFactor = 0.05f;

		[SerializeField]
		[Range(0f, 180f)]
		private float m_CautiousMaxAngle = 50f;

		[SerializeField]
		private float m_CautiousMaxDistance = 100f;

		[SerializeField]
		private float m_CautiousAngularVelocityFactor = 30f;

		[SerializeField]
		private float m_SteerSensitivity = 0.05f;

		[SerializeField]
		private float m_AccelSensitivity = 0.04f;

		[SerializeField]
		private float m_BrakeSensitivity = 1f;

		[SerializeField]
		private float m_LateralWanderDistance = 3f;

		[SerializeField]
		private float m_LateralWanderSpeed = 0.1f;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_AccelWanderAmount = 0.1f;

		[SerializeField]
		private float m_AccelWanderSpeed = 0.1f;

		[SerializeField]
		private BrakeCondition m_BrakeCondition = BrakeCondition.TargetDistance;

		[SerializeField]
		private bool m_Driving;

		[SerializeField]
		private Transform m_Target;

		[SerializeField]
		private bool m_StopWhenTargetReached;

		[SerializeField]
		private float m_ReachTargetThreshold = 2f;

		private float m_RandomPerlin;

		private CarController m_CarController;

		private float m_AvoidOtherCarTime;

		private float m_AvoidOtherCarSlowdown;

		private float m_AvoidPathOffset;

		private Rigidbody m_Rigidbody;

		private void Awake()
		{
			m_CarController = GetComponent<CarController>();
			m_RandomPerlin = UnityEngine.Random.value * 100f;
			m_Rigidbody = GetComponent<Rigidbody>();
		}

		private void FixedUpdate()
		{
			if (m_Target == null || !m_Driving)
			{
				m_CarController.Move(0f, 0f, -1f, 1f);
				return;
			}
			Vector3 to = base.transform.forward;
			if (m_Rigidbody.velocity.magnitude > m_CarController.MaxSpeed * 0.1f)
			{
				to = m_Rigidbody.velocity;
			}
			float num = m_CarController.MaxSpeed;
			switch (m_BrakeCondition)
			{
			case BrakeCondition.TargetDirectionDifference:
			{
				float b2 = Vector3.Angle(m_Target.forward, to);
				float a = m_Rigidbody.angularVelocity.magnitude * m_CautiousAngularVelocityFactor;
				float t2 = Mathf.InverseLerp(0f, m_CautiousMaxAngle, Mathf.Max(a, b2));
				num = Mathf.Lerp(m_CarController.MaxSpeed, m_CarController.MaxSpeed * m_CautiousSpeedFactor, t2);
				break;
			}
			case BrakeCondition.TargetDistance:
			{
				Vector3 vector = m_Target.position - base.transform.position;
				float b = Mathf.InverseLerp(m_CautiousMaxDistance, 0f, vector.magnitude);
				float value = m_Rigidbody.angularVelocity.magnitude * m_CautiousAngularVelocityFactor;
				float t = Mathf.Max(Mathf.InverseLerp(0f, m_CautiousMaxAngle, value), b);
				num = Mathf.Lerp(m_CarController.MaxSpeed, m_CarController.MaxSpeed * m_CautiousSpeedFactor, t);
				break;
			}
			}
			Vector3 position = m_Target.position;
			if (Time.time < m_AvoidOtherCarTime)
			{
				num *= m_AvoidOtherCarSlowdown;
				position += m_Target.right * m_AvoidPathOffset;
			}
			else
			{
				position += m_Target.right * (Mathf.PerlinNoise(Time.time * m_LateralWanderSpeed, m_RandomPerlin) * 2f - 1f) * m_LateralWanderDistance;
			}
			float num2 = ((num < m_CarController.CurrentSpeed) ? m_BrakeSensitivity : m_AccelSensitivity);
			float num3 = Mathf.Clamp((num - m_CarController.CurrentSpeed) * num2, -1f, 1f);
			num3 *= 1f - m_AccelWanderAmount + Mathf.PerlinNoise(Time.time * m_AccelWanderSpeed, m_RandomPerlin) * m_AccelWanderAmount;
			Vector3 vector2 = base.transform.InverseTransformPoint(position);
			float steering = Mathf.Clamp(Mathf.Atan2(vector2.x, vector2.z) * 57.29578f * m_SteerSensitivity, -1f, 1f) * Mathf.Sign(m_CarController.CurrentSpeed);
			m_CarController.Move(steering, num3, num3, 0f);
			if (m_StopWhenTargetReached && vector2.magnitude < m_ReachTargetThreshold)
			{
				m_Driving = false;
			}
		}

		private void OnCollisionStay(Collision col)
		{
			if (!(col.rigidbody != null))
			{
				return;
			}
			CarAIControl component = col.rigidbody.GetComponent<CarAIControl>();
			if (component != null)
			{
				m_AvoidOtherCarTime = Time.time + 1f;
				if (Vector3.Angle(base.transform.forward, component.transform.position - base.transform.position) < 90f)
				{
					m_AvoidOtherCarSlowdown = 0.5f;
				}
				else
				{
					m_AvoidOtherCarSlowdown = 1f;
				}
				Vector3 vector = base.transform.InverseTransformPoint(component.transform.position);
				float f = Mathf.Atan2(vector.x, vector.z);
				m_AvoidPathOffset = m_LateralWanderDistance * (0f - Mathf.Sign(f));
			}
		}

		public void SetTarget(Transform target)
		{
			m_Target = target;
			m_Driving = true;
		}
	}
	[RequireComponent(typeof(CarController))]
	public class CarAudio : MonoBehaviour
	{
		public enum EngineAudioOptions
		{
			Simple,
			FourChannel
		}

		public EngineAudioOptions engineSoundStyle = EngineAudioOptions.FourChannel;

		public AudioClip lowAccelClip;

		public AudioClip lowDecelClip;

		public AudioClip highAccelClip;

		public AudioClip highDecelClip;

		public float pitchMultiplier = 1f;

		public float lowPitchMin = 1f;

		public float lowPitchMax = 6f;

		public float highPitchMultiplier = 0.25f;

		public float maxRolloffDistance = 500f;

		public float dopplerLevel = 1f;

		public bool useDoppler = true;

		private AudioSource m_LowAccel;

		private AudioSource m_LowDecel;

		private AudioSource m_HighAccel;

		private AudioSource m_HighDecel;

		private bool m_StartedSound;

		private CarController m_CarController;

		private void StartSound()
		{
			m_CarController = GetComponent<CarController>();
			m_HighAccel = SetUpEngineAudioSource(highAccelClip);
			if (engineSoundStyle == EngineAudioOptions.FourChannel)
			{
				m_LowAccel = SetUpEngineAudioSource(lowAccelClip);
				m_LowDecel = SetUpEngineAudioSource(lowDecelClip);
				m_HighDecel = SetUpEngineAudioSource(highDecelClip);
			}
			m_StartedSound = true;
		}

		private void StopSound()
		{
			AudioSource[] components = GetComponents<AudioSource>();
			for (int i = 0; i < components.Length; i++)
			{
				UnityEngine.Object.Destroy(components[i]);
			}
			m_StartedSound = false;
		}

		private void Update()
		{
			float sqrMagnitude = (Camera.main.transform.position - base.transform.position).sqrMagnitude;
			if (m_StartedSound && sqrMagnitude > maxRolloffDistance * maxRolloffDistance)
			{
				StopSound();
			}
			if (!m_StartedSound && sqrMagnitude < maxRolloffDistance * maxRolloffDistance)
			{
				StartSound();
			}
			if (m_StartedSound)
			{
				float b = ULerp(lowPitchMin, lowPitchMax, m_CarController.Revs);
				b = Mathf.Min(lowPitchMax, b);
				if (engineSoundStyle == EngineAudioOptions.Simple)
				{
					m_HighAccel.pitch = b * pitchMultiplier * highPitchMultiplier;
					m_HighAccel.dopplerLevel = (useDoppler ? dopplerLevel : 0f);
					m_HighAccel.volume = 1f;
					return;
				}
				m_LowAccel.pitch = b * pitchMultiplier;
				m_LowDecel.pitch = b * pitchMultiplier;
				m_HighAccel.pitch = b * highPitchMultiplier * pitchMultiplier;
				m_HighDecel.pitch = b * highPitchMultiplier * pitchMultiplier;
				float num = Mathf.Abs(m_CarController.AccelInput);
				float num2 = 1f - num;
				float num3 = Mathf.InverseLerp(0.2f, 0.8f, m_CarController.Revs);
				float num4 = 1f - num3;
				num3 = 1f - (1f - num3) * (1f - num3);
				num4 = 1f - (1f - num4) * (1f - num4);
				num = 1f - (1f - num) * (1f - num);
				num2 = 1f - (1f - num2) * (1f - num2);
				m_LowAccel.volume = num4 * num;
				m_LowDecel.volume = num4 * num2;
				m_HighAccel.volume = num3 * num;
				m_HighDecel.volume = num3 * num2;
				m_HighAccel.dopplerLevel = (useDoppler ? dopplerLevel : 0f);
				m_LowAccel.dopplerLevel = (useDoppler ? dopplerLevel : 0f);
				m_HighDecel.dopplerLevel = (useDoppler ? dopplerLevel : 0f);
				m_LowDecel.dopplerLevel = (useDoppler ? dopplerLevel : 0f);
			}
		}

		private AudioSource SetUpEngineAudioSource(AudioClip clip)
		{
			AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
			audioSource.clip = clip;
			audioSource.volume = 0f;
			audioSource.loop = true;
			audioSource.time = UnityEngine.Random.Range(0f, clip.length);
			audioSource.Play();
			audioSource.minDistance = 5f;
			audioSource.maxDistance = maxRolloffDistance;
			audioSource.dopplerLevel = 0f;
			return audioSource;
		}

		private static float ULerp(float from, float to, float value)
		{
			return (1f - value) * from + value * to;
		}
	}
	internal enum CarDriveType
	{
		FrontWheelDrive,
		RearWheelDrive,
		FourWheelDrive,
		SixWheelDrive
	}
	internal enum SpeedType
	{
		MPH,
		KPH
	}
	public class CarController : MonoBehaviour
	{
		[SerializeField]
		private CarDriveType m_CarDriveType = CarDriveType.FourWheelDrive;

		[SerializeField]
		private WheelCollider[] m_WheelColliders = new WheelCollider[4];

		[SerializeField]
		private GameObject[] m_WheelMeshes = new GameObject[4];

		[SerializeField]
		private WheelEffects[] m_WheelEffects = new WheelEffects[4];

		[SerializeField]
		private Vector3 m_CentreOfMassOffset;

		[SerializeField]
		private float m_MaximumSteerAngle;

		[Range(0f, 1f)]
		[SerializeField]
		private float m_SteerHelper;

		[Range(0f, 1f)]
		[SerializeField]
		private float m_TractionControl;

		[SerializeField]
		private float m_FullTorqueOverAllWheels;

		[SerializeField]
		private float m_ReverseTorque;

		[SerializeField]
		private float m_MaxHandbrakeTorque;

		[SerializeField]
		private float m_Downforce = 100f;

		[SerializeField]
		private SpeedType m_SpeedType;

		[SerializeField]
		private float m_Topspeed = 200f;

		[SerializeField]
		private static int NoOfGears = 5;

		[SerializeField]
		private float m_RevRangeBoundary = 1f;

		[SerializeField]
		private float m_SlipLimit;

		[SerializeField]
		private float m_BrakeTorque;

		private Quaternion[] m_WheelMeshLocalRotations;

		private Vector3 m_Prevpos;

		private Vector3 m_Pos;

		private float m_SteerAngle;

		private int m_GearNum;

		private float m_GearFactor;

		private float m_OldRotation;

		private float m_CurrentTorque;

		private Rigidbody m_Rigidbody;

		private const float k_ReversingThreshold = 0.01f;

		public bool Skidding { get; private set; }

		public float BrakeInput { get; private set; }

		public float CurrentSteerAngle => m_SteerAngle;

		public float CurrentSpeed => m_Rigidbody.velocity.magnitude * 2.2369363f;

		public float MaxSpeed => m_Topspeed;

		public float Revs { get; private set; }

		public float AccelInput { get; private set; }

		private void Start()
		{
			m_WheelMeshLocalRotations = new Quaternion[m_WheelColliders.Length];
			for (int i = 0; i < m_WheelColliders.Length; i++)
			{
				m_WheelMeshLocalRotations[i] = m_WheelMeshes[i].transform.localRotation;
			}
			m_WheelColliders[0].attachedRigidbody.centerOfMass = m_CentreOfMassOffset;
			m_MaxHandbrakeTorque = float.MaxValue;
			m_Rigidbody = GetComponent<Rigidbody>();
			m_CurrentTorque = m_FullTorqueOverAllWheels - m_TractionControl * m_FullTorqueOverAllWheels;
		}

		private void GearChanging()
		{
			float num = Mathf.Abs(CurrentSpeed / MaxSpeed);
			float num2 = 1f / (float)NoOfGears * (float)(m_GearNum + 1);
			float num3 = 1f / (float)NoOfGears * (float)m_GearNum;
			if (m_GearNum > 0 && num < num3)
			{
				m_GearNum--;
			}
			if (num > num2 && m_GearNum < NoOfGears - 1)
			{
				m_GearNum++;
			}
		}

		private static float CurveFactor(float factor)
		{
			return 1f - (1f - factor) * (1f - factor);
		}

		private static float ULerp(float from, float to, float value)
		{
			return (1f - value) * from + value * to;
		}

		private void CalculateGearFactor()
		{
			float num = 1f / (float)NoOfGears;
			float b = Mathf.InverseLerp(num * (float)m_GearNum, num * (float)(m_GearNum + 1), Mathf.Abs(CurrentSpeed / MaxSpeed));
			m_GearFactor = Mathf.Lerp(m_GearFactor, b, Time.deltaTime * 5f);
		}

		private void CalculateRevs()
		{
			CalculateGearFactor();
			float num = (float)m_GearNum / (float)NoOfGears;
			float from = ULerp(0f, m_RevRangeBoundary, CurveFactor(num));
			float to = ULerp(m_RevRangeBoundary, 1f, num);
			Revs = ULerp(from, to, m_GearFactor);
		}

		public void Move(float steering, float accel, float footbrake, float handbrake)
		{
			for (int i = 0; i < m_WheelColliders.Length; i++)
			{
				m_WheelColliders[i].GetWorldPose(out var pos, out var quat);
				m_WheelMeshes[i].transform.position = pos;
				m_WheelMeshes[i].transform.rotation = quat;
			}
			steering = Mathf.Clamp(steering, -1f, 1f);
			AccelInput = (accel = Mathf.Clamp(accel, 0f, 1f));
			BrakeInput = (footbrake = -1f * Mathf.Clamp(footbrake, -1f, 0f));
			handbrake = Mathf.Clamp(handbrake, 0f, 1f);
			m_SteerAngle = steering * m_MaximumSteerAngle;
			m_WheelColliders[0].steerAngle = m_SteerAngle;
			m_WheelColliders[1].steerAngle = m_SteerAngle;
			SteerHelper();
			ApplyDrive(accel, footbrake);
			CapSpeed();
			if (handbrake > 0f)
			{
				float brakeTorque = handbrake * m_MaxHandbrakeTorque;
				m_WheelColliders[2].brakeTorque = brakeTorque;
				m_WheelColliders[3].brakeTorque = brakeTorque;
			}
			CalculateRevs();
			GearChanging();
			AddDownForce();
			CheckForWheelSpin();
			TractionControl();
		}

		private void CapSpeed()
		{
			float magnitude = m_Rigidbody.velocity.magnitude;
			switch (m_SpeedType)
			{
			case SpeedType.MPH:
				magnitude *= 2.2369363f;
				if (magnitude > m_Topspeed)
				{
					m_Rigidbody.velocity = m_Topspeed / 2.2369363f * m_Rigidbody.velocity.normalized;
				}
				break;
			case SpeedType.KPH:
				magnitude *= 3.6f;
				if (magnitude > m_Topspeed)
				{
					m_Rigidbody.velocity = m_Topspeed / 3.6f * m_Rigidbody.velocity.normalized;
				}
				break;
			}
		}

		private void ApplyDrive(float accel, float footbrake)
		{
			switch (m_CarDriveType)
			{
			case CarDriveType.SixWheelDrive:
			{
				float num = accel * (m_CurrentTorque / 6f);
				for (int j = 0; j < m_WheelColliders.Length; j++)
				{
					m_WheelColliders[j].motorTorque = num;
				}
				break;
			}
			case CarDriveType.FourWheelDrive:
			{
				float num = accel * (m_CurrentTorque / 4f);
				for (int i = 0; i < m_WheelColliders.Length; i++)
				{
					m_WheelColliders[i].motorTorque = num;
				}
				break;
			}
			case CarDriveType.FrontWheelDrive:
			{
				float num = accel * (m_CurrentTorque / 2f);
				WheelCollider obj2 = m_WheelColliders[0];
				float motorTorque = (m_WheelColliders[1].motorTorque = num);
				obj2.motorTorque = motorTorque;
				break;
			}
			case CarDriveType.RearWheelDrive:
			{
				float num = accel * (m_CurrentTorque / 2f);
				WheelCollider obj = m_WheelColliders[2];
				float motorTorque = (m_WheelColliders[3].motorTorque = num);
				obj.motorTorque = motorTorque;
				break;
			}
			}
			for (int k = 0; k < m_WheelColliders.Length; k++)
			{
				if (CurrentSpeed > 5f && Vector3.Angle(base.transform.forward, m_Rigidbody.velocity) < 50f)
				{
					m_WheelColliders[k].brakeTorque = m_BrakeTorque * footbrake;
				}
				else if (footbrake > 0f)
				{
					m_WheelColliders[k].brakeTorque = 0f;
					m_WheelColliders[k].motorTorque = (0f - m_ReverseTorque) * footbrake;
				}
			}
		}

		private void SteerHelper()
		{
			for (int i = 0; i < m_WheelColliders.Length; i++)
			{
				m_WheelColliders[i].GetGroundHit(out var hit);
				if (hit.normal == Vector3.zero)
				{
					return;
				}
			}
			if (Mathf.Abs(m_OldRotation - base.transform.eulerAngles.y) < 10f)
			{
				Quaternion quaternion = Quaternion.AngleAxis((base.transform.eulerAngles.y - m_OldRotation) * m_SteerHelper, Vector3.up);
				m_Rigidbody.velocity = quaternion * m_Rigidbody.velocity;
			}
			m_OldRotation = base.transform.eulerAngles.y;
		}

		private void AddDownForce()
		{
			m_WheelColliders[0].attachedRigidbody.AddForce(-base.transform.up * m_Downforce * m_WheelColliders[0].attachedRigidbody.velocity.magnitude);
		}

		private void CheckForWheelSpin()
		{
			for (int i = 0; i < m_WheelEffects.Length; i++)
			{
				m_WheelColliders[i].GetGroundHit(out var hit);
				if (Mathf.Abs(hit.forwardSlip) >= m_SlipLimit || Mathf.Abs(hit.sidewaysSlip) >= m_SlipLimit)
				{
					m_WheelEffects[i].EmitTyreSmoke();
					if (!AnySkidSoundPlaying())
					{
						m_WheelEffects[i].PlayAudio();
					}
				}
				else
				{
					if (m_WheelEffects[i].PlayingAudio)
					{
						m_WheelEffects[i].StopAudio();
					}
					m_WheelEffects[i].EndSkidTrail();
				}
			}
		}

		private void TractionControl()
		{
			WheelHit hit;
			switch (m_CarDriveType)
			{
			case CarDriveType.SixWheelDrive:
			{
				for (int j = 0; j < m_WheelColliders.Length; j++)
				{
					m_WheelColliders[j].GetGroundHit(out hit);
					AdjustTorque(hit.forwardSlip);
				}
				break;
			}
			case CarDriveType.FourWheelDrive:
			{
				for (int i = 0; i < m_WheelColliders.Length; i++)
				{
					m_WheelColliders[i].GetGroundHit(out hit);
					AdjustTorque(hit.forwardSlip);
				}
				break;
			}
			case CarDriveType.RearWheelDrive:
				m_WheelColliders[2].GetGroundHit(out hit);
				AdjustTorque(hit.forwardSlip);
				m_WheelColliders[3].GetGroundHit(out hit);
				AdjustTorque(hit.forwardSlip);
				break;
			case CarDriveType.FrontWheelDrive:
				m_WheelColliders[0].GetGroundHit(out hit);
				AdjustTorque(hit.forwardSlip);
				m_WheelColliders[1].GetGroundHit(out hit);
				AdjustTorque(hit.forwardSlip);
				break;
			}
		}

		private void AdjustTorque(float forwardSlip)
		{
			if (forwardSlip >= m_SlipLimit && m_CurrentTorque >= 0f)
			{
				m_CurrentTorque -= 10f * m_TractionControl;
				return;
			}
			m_CurrentTorque += 10f * m_TractionControl;
			if (m_CurrentTorque > m_FullTorqueOverAllWheels)
			{
				m_CurrentTorque = m_FullTorqueOverAllWheels;
			}
		}

		private bool AnySkidSoundPlaying()
		{
			for (int i = 0; i < m_WheelEffects.Length; i++)
			{
				if (m_WheelEffects[i].PlayingAudio)
				{
					return true;
				}
			}
			return false;
		}
	}
	public class CarSelfRighting : MonoBehaviour
	{
		[SerializeField]
		private float m_WaitTime = 3f;

		[SerializeField]
		private float m_VelocityThreshold = 1f;

		private float m_LastOkTime;

		private Rigidbody m_Rigidbody;

		private void Start()
		{
			m_Rigidbody = GetComponent<Rigidbody>();
		}

		private void Update()
		{
			if (base.transform.up.y > 0f || m_Rigidbody.velocity.magnitude > m_VelocityThreshold)
			{
				m_LastOkTime = Time.time;
			}
			if (Time.time > m_LastOkTime + m_WaitTime)
			{
				RightCar();
			}
		}

		private void RightCar()
		{
			base.transform.position += Vector3.up;
			base.transform.rotation = Quaternion.LookRotation(base.transform.forward);
		}
	}
	[RequireComponent(typeof(CarController))]
	public class CarUserControl : MonoBehaviour
	{
		private CarController m_Car;

		private void Awake()
		{
			m_Car = GetComponent<CarController>();
		}

		private void FixedUpdate()
		{
			float axis = CrossPlatformInputManager.GetAxis("Horizontal");
			float axis2 = CrossPlatformInputManager.GetAxis("Vertical");
			m_Car.Move(axis, axis2, axis2, 0f);
		}
	}
	public class Mudguard : MonoBehaviour
	{
		public CarController carController;

		private Quaternion m_OriginalRotation;

		private void Start()
		{
			m_OriginalRotation = base.transform.localRotation;
		}

		private void Update()
		{
			base.transform.localRotation = m_OriginalRotation * Quaternion.Euler(0f, carController.CurrentSteerAngle, 0f);
		}
	}
	public class SkidTrail : MonoBehaviour
	{
		[SerializeField]
		private float m_PersistTime;

		private IEnumerator Start()
		{
			while (true)
			{
				yield return null;
				if (base.transform.parent.parent == null)
				{
					UnityEngine.Object.Destroy(base.gameObject, m_PersistTime);
				}
			}
		}
	}
	public class Suspension : MonoBehaviour
	{
		public GameObject wheel;

		private Vector3 m_TargetOriginalPosition;

		private Vector3 m_Origin;

		private void Start()
		{
			m_TargetOriginalPosition = wheel.transform.localPosition;
			m_Origin = base.transform.localPosition;
		}

		private void Update()
		{
			base.transform.localPosition = m_Origin + (wheel.transform.localPosition - m_TargetOriginalPosition);
		}
	}
	[RequireComponent(typeof(AudioSource))]
	public class WheelEffects : MonoBehaviour
	{
		public Transform SkidTrailPrefab;

		public static Transform skidTrailsDetachedParent;

		public ParticleSystem skidParticles;

		private AudioSource m_AudioSource;

		private Transform m_SkidTrail;

		private WheelCollider m_WheelCollider;

		public bool skidding { get; private set; }

		public bool PlayingAudio { get; private set; }

		private void Start()
		{
			skidParticles = base.transform.root.GetComponentInChildren<ParticleSystem>();
			if (skidParticles == null)
			{
				UnityEngine.Debug.LogWarning(" no particle system found on car to generate smoke particles", base.gameObject);
			}
			else
			{
				skidParticles.Stop();
			}
			m_WheelCollider = GetComponent<WheelCollider>();
			m_AudioSource = GetComponent<AudioSource>();
			PlayingAudio = false;
			if (skidTrailsDetachedParent == null)
			{
				skidTrailsDetachedParent = new GameObject("Skid Trails - Detached").transform;
			}
		}

		public void EmitTyreSmoke()
		{
			skidParticles.transform.position = base.transform.position - base.transform.up * m_WheelCollider.radius;
			skidParticles.Emit(1);
			if (!skidding)
			{
				StartCoroutine(StartSkidTrail());
			}
		}

		public void PlayAudio()
		{
			m_AudioSource.Play();
			PlayingAudio = true;
		}

		public void StopAudio()
		{
			m_AudioSource.Stop();
			PlayingAudio = false;
		}

		public IEnumerator StartSkidTrail()
		{
			skidding = true;
			m_SkidTrail = UnityEngine.Object.Instantiate(SkidTrailPrefab);
			while (m_SkidTrail == null)
			{
				yield return null;
			}
			m_SkidTrail.parent = base.transform;
			m_SkidTrail.localPosition = -Vector3.up * m_WheelCollider.radius;
		}

		public void EndSkidTrail()
		{
			if (skidding)
			{
				skidding = false;
				m_SkidTrail.parent = skidTrailsDetachedParent;
				UnityEngine.Object.Destroy(m_SkidTrail.gameObject, 10f);
			}
		}
	}
}
namespace UnityStandardAssets.Vehicles.Aeroplane
{
	[RequireComponent(typeof(AeroplaneController))]
	public class AeroplaneAiControl : MonoBehaviour
	{
		[SerializeField]
		private float m_RollSensitivity = 0.2f;

		[SerializeField]
		private float m_PitchSensitivity = 0.5f;

		[SerializeField]
		private float m_LateralWanderDistance = 5f;

		[SerializeField]
		private float m_LateralWanderSpeed = 0.11f;

		[SerializeField]
		private float m_MaxClimbAngle = 45f;

		[SerializeField]
		private float m_MaxRollAngle = 45f;

		[SerializeField]
		private float m_SpeedEffect = 0.01f;

		[SerializeField]
		private float m_TakeoffHeight = 20f;

		[SerializeField]
		private Transform m_Target;

		private AeroplaneController m_AeroplaneController;

		private float m_RandomPerlin;

		private bool m_TakenOff;

		private void Awake()
		{
			m_AeroplaneController = GetComponent<AeroplaneController>();
			m_RandomPerlin = UnityEngine.Random.Range(0f, 100f);
		}

		public void Reset()
		{
			m_TakenOff = false;
		}

		private void FixedUpdate()
		{
			if (m_Target != null)
			{
				Vector3 position = m_Target.position + base.transform.right * (Mathf.PerlinNoise(Time.time * m_LateralWanderSpeed, m_RandomPerlin) * 2f - 1f) * m_LateralWanderDistance;
				Vector3 vector = base.transform.InverseTransformPoint(position);
				float num = Mathf.Atan2(vector.x, vector.z);
				float num2 = (Mathf.Clamp(0f - Mathf.Atan2(vector.y, vector.z), (0f - m_MaxClimbAngle) * ((float)Math.PI / 180f), m_MaxClimbAngle * ((float)Math.PI / 180f)) - m_AeroplaneController.PitchAngle) * m_PitchSensitivity;
				float num3 = Mathf.Clamp(num, (0f - m_MaxRollAngle) * ((float)Math.PI / 180f), m_MaxRollAngle * ((float)Math.PI / 180f));
				float num4 = 0f;
				float num5 = 0f;
				if (!m_TakenOff)
				{
					if (m_AeroplaneController.Altitude > m_TakeoffHeight)
					{
						m_TakenOff = true;
					}
				}
				else
				{
					num4 = num;
					num5 = (0f - (m_AeroplaneController.RollAngle - num3)) * m_RollSensitivity;
				}
				float num6 = 1f + m_AeroplaneController.ForwardSpeed * m_SpeedEffect;
				num5 *= num6;
				num2 *= num6;
				num4 *= num6;
				m_AeroplaneController.Move(num5, num2, num4, 0.5f, airBrakes: false);
			}
			else
			{
				m_AeroplaneController.Move(0f, 0f, 0f, 0f, airBrakes: false);
			}
		}

		public void SetTarget(Transform target)
		{
			m_Target = target;
		}
	}
	public class AeroplaneAudio : MonoBehaviour
	{
		[Serializable]
		public class AdvancedSetttings
		{
			public float engineMinDistance = 50f;

			public float engineMaxDistance = 1000f;

			public float engineDopplerLevel = 1f;

			[Range(0f, 1f)]
			public float engineMasterVolume = 0.5f;

			public float windMinDistance = 10f;

			public float windMaxDistance = 100f;

			public float windDopplerLevel = 1f;

			[Range(0f, 1f)]
			public float windMasterVolume = 0.5f;
		}

		[SerializeField]
		private AudioClip m_EngineSound;

		[SerializeField]
		private float m_EngineMinThrottlePitch = 0.4f;

		[SerializeField]
		private float m_EngineMaxThrottlePitch = 2f;

		[SerializeField]
		private float m_EngineFwdSpeedMultiplier = 0.002f;

		[SerializeField]
		private AudioClip m_WindSound;

		[SerializeField]
		private float m_WindBasePitch = 0.2f;

		[SerializeField]
		private float m_WindSpeedPitchFactor = 0.004f;

		[SerializeField]
		private float m_WindMaxSpeedVolume = 100f;

		[SerializeField]
		private AdvancedSetttings m_AdvancedSetttings = new AdvancedSetttings();

		private AudioSource m_EngineSoundSource;

		private AudioSource m_WindSoundSource;

		private AeroplaneController m_Plane;

		private Rigidbody m_Rigidbody;

		private void Awake()
		{
			m_Plane = GetComponent<AeroplaneController>();
			m_Rigidbody = GetComponent<Rigidbody>();
			m_EngineSoundSource = base.gameObject.AddComponent<AudioSource>();
			m_EngineSoundSource.playOnAwake = false;
			m_WindSoundSource = base.gameObject.AddComponent<AudioSource>();
			m_WindSoundSource.playOnAwake = false;
			m_EngineSoundSource.clip = m_EngineSound;
			m_WindSoundSource.clip = m_WindSound;
			m_EngineSoundSource.minDistance = m_AdvancedSetttings.engineMinDistance;
			m_EngineSoundSource.maxDistance = m_AdvancedSetttings.engineMaxDistance;
			m_EngineSoundSource.loop = true;
			m_EngineSoundSource.dopplerLevel = m_AdvancedSetttings.engineDopplerLevel;
			m_WindSoundSource.minDistance = m_AdvancedSetttings.windMinDistance;
			m_WindSoundSource.maxDistance = m_AdvancedSetttings.windMaxDistance;
			m_WindSoundSource.loop = true;
			m_WindSoundSource.dopplerLevel = m_AdvancedSetttings.windDopplerLevel;
			Update();
			m_EngineSoundSource.Play();
			m_WindSoundSource.Play();
		}

		private void Update()
		{
			float t = Mathf.InverseLerp(0f, m_Plane.MaxEnginePower, m_Plane.EnginePower);
			m_EngineSoundSource.pitch = Mathf.Lerp(m_EngineMinThrottlePitch, m_EngineMaxThrottlePitch, t);
			m_EngineSoundSource.pitch += m_Plane.ForwardSpeed * m_EngineFwdSpeedMultiplier;
			m_EngineSoundSource.volume = Mathf.InverseLerp(0f, m_Plane.MaxEnginePower * m_AdvancedSetttings.engineMasterVolume, m_Plane.EnginePower);
			float magnitude = m_Rigidbody.velocity.magnitude;
			m_WindSoundSource.pitch = m_WindBasePitch + magnitude * m_WindSpeedPitchFactor;
			m_WindSoundSource.volume = Mathf.InverseLerp(0f, m_WindMaxSpeedVolume, magnitude) * m_AdvancedSetttings.windMasterVolume;
		}
	}
	[RequireComponent(typeof(Rigidbody))]
	public class AeroplaneController : MonoBehaviour
	{
		[SerializeField]
		private float m_MaxEnginePower = 40f;

		[SerializeField]
		private float m_Lift = 0.002f;

		[SerializeField]
		private float m_ZeroLiftSpeed = 300f;

		[SerializeField]
		private float m_RollEffect = 1f;

		[SerializeField]
		private float m_PitchEffect = 1f;

		[SerializeField]
		private float m_YawEffect = 0.2f;

		[SerializeField]
		private float m_BankedTurnEffect = 0.5f;

		[SerializeField]
		private float m_AerodynamicEffect = 0.02f;

		[SerializeField]
		private float m_AutoTurnPitch = 0.5f;

		[SerializeField]
		private float m_AutoRollLevel = 0.2f;

		[SerializeField]
		private float m_AutoPitchLevel = 0.2f;

		[SerializeField]
		private float m_AirBrakesEffect = 3f;

		[SerializeField]
		private float m_ThrottleChangeSpeed = 0.3f;

		[SerializeField]
		private float m_DragIncreaseFactor = 0.001f;

		private float m_OriginalDrag;

		private float m_OriginalAngularDrag;

		private float m_AeroFactor;

		private bool m_Immobilized;

		private float m_BankedTurnAmount;

		private Rigidbody m_Rigidbody;

		private WheelCollider[] m_WheelColliders;

		public float Altitude { get; private set; }

		public float Throttle { get; private set; }

		public bool AirBrakes { get; private set; }

		public float ForwardSpeed { get; private set; }

		public float EnginePower { get; private set; }

		public float MaxEnginePower => m_MaxEnginePower;

		public float RollAngle { get; private set; }

		public float PitchAngle { get; private set; }

		public float RollInput { get; private set; }

		public float PitchInput { get; private set; }

		public float YawInput { get; private set; }

		public float ThrottleInput { get; private set; }

		private void Start()
		{
			m_Rigidbody = GetComponent<Rigidbody>();
			m_OriginalDrag = m_Rigidbody.drag;
			m_OriginalAngularDrag = m_Rigidbody.angularDrag;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				WheelCollider[] componentsInChildren = base.transform.GetChild(i).GetComponentsInChildren<WheelCollider>();
				for (int j = 0; j < componentsInChildren.Length; j++)
				{
					componentsInChildren[j].motorTorque = 0.18f;
				}
			}
		}

		public void Move(float rollInput, float pitchInput, float yawInput, float throttleInput, bool airBrakes)
		{
			RollInput = rollInput;
			PitchInput = pitchInput;
			YawInput = yawInput;
			ThrottleInput = throttleInput;
			AirBrakes = airBrakes;
			ClampInputs();
			CalculateRollAndPitchAngles();
			AutoLevel();
			CalculateForwardSpeed();
			ControlThrottle();
			CalculateDrag();
			CaluclateAerodynamicEffect();
			CalculateLinearForces();
			CalculateTorque();
			CalculateAltitude();
		}

		private void ClampInputs()
		{
			RollInput = Mathf.Clamp(RollInput, -1f, 1f);
			PitchInput = Mathf.Clamp(PitchInput, -1f, 1f);
			YawInput = Mathf.Clamp(YawInput, -1f, 1f);
			ThrottleInput = Mathf.Clamp(ThrottleInput, -1f, 1f);
		}

		private void CalculateRollAndPitchAngles()
		{
			Vector3 forward = base.transform.forward;
			forward.y = 0f;
			if (forward.sqrMagnitude > 0f)
			{
				forward.Normalize();
				Vector3 vector = base.transform.InverseTransformDirection(forward);
				PitchAngle = Mathf.Atan2(vector.y, vector.z);
				Vector3 direction = Vector3.Cross(Vector3.up, forward);
				Vector3 vector2 = base.transform.InverseTransformDirection(direction);
				RollAngle = Mathf.Atan2(vector2.y, vector2.x);
			}
		}

		private void AutoLevel()
		{
			m_BankedTurnAmount = Mathf.Sin(RollAngle);
			if (RollInput == 0f)
			{
				RollInput = (0f - RollAngle) * m_AutoRollLevel;
			}
			if (PitchInput == 0f)
			{
				PitchInput = (0f - PitchAngle) * m_AutoPitchLevel;
				PitchInput -= Mathf.Abs(m_BankedTurnAmount * m_BankedTurnAmount * m_AutoTurnPitch);
			}
		}

		private void CalculateForwardSpeed()
		{
			ForwardSpeed = Mathf.Max(0f, base.transform.InverseTransformDirection(m_Rigidbody.velocity).z);
		}

		private void ControlThrottle()
		{
			if (m_Immobilized)
			{
				ThrottleInput = -0.5f;
			}
			Throttle = Mathf.Clamp01(Throttle + ThrottleInput * Time.deltaTime * m_ThrottleChangeSpeed);
			EnginePower = Throttle * m_MaxEnginePower;
		}

		private void CalculateDrag()
		{
			float num = m_Rigidbody.velocity.magnitude * m_DragIncreaseFactor;
			m_Rigidbody.drag = (AirBrakes ? ((m_OriginalDrag + num) * m_AirBrakesEffect) : (m_OriginalDrag + num));
			m_Rigidbody.angularDrag = m_OriginalAngularDrag * ForwardSpeed;
		}

		private void CaluclateAerodynamicEffect()
		{
			if (m_Rigidbody.velocity.magnitude > 0f)
			{
				m_AeroFactor = Vector3.Dot(base.transform.forward, m_Rigidbody.velocity.normalized);
				m_AeroFactor *= m_AeroFactor;
				Vector3 velocity = Vector3.Lerp(m_Rigidbody.velocity, base.transform.forward * ForwardSpeed, m_AeroFactor * ForwardSpeed * m_AerodynamicEffect * Time.deltaTime);
				m_Rigidbody.velocity = velocity;
				m_Rigidbody.rotation = Quaternion.Slerp(m_Rigidbody.rotation, Quaternion.LookRotation(m_Rigidbody.velocity, base.transform.up), m_AerodynamicEffect * Time.deltaTime);
			}
		}

		private void CalculateLinearForces()
		{
			Vector3 zero = Vector3.zero;
			zero += EnginePower * base.transform.forward;
			Vector3 normalized = Vector3.Cross(m_Rigidbody.velocity, base.transform.right).normalized;
			float num = Mathf.InverseLerp(m_ZeroLiftSpeed, 0f, ForwardSpeed);
			float num2 = ForwardSpeed * ForwardSpeed * m_Lift * num * m_AeroFactor;
			zero += num2 * normalized;
			m_Rigidbody.AddForce(zero);
		}

		private void CalculateTorque()
		{
			Vector3 zero = Vector3.zero;
			zero += PitchInput * m_PitchEffect * base.transform.right;
			zero += YawInput * m_YawEffect * base.transform.up;
			zero += (0f - RollInput) * m_RollEffect * base.transform.forward;
			zero += m_BankedTurnAmount * m_BankedTurnEffect * base.transform.up;
			m_Rigidbody.AddTorque(zero * ForwardSpeed * m_AeroFactor);
		}

		private void CalculateAltitude()
		{
			Ray ray = new Ray(base.transform.position - Vector3.up * 10f, -Vector3.up);
			Altitude = (Physics.Raycast(ray, out var hitInfo) ? (hitInfo.distance + 10f) : base.transform.position.y);
		}

		public void Immobilize()
		{
			m_Immobilized = true;
		}

		public void Reset()
		{
			m_Immobilized = false;
		}
	}
	public class AeroplaneControlSurfaceAnimator : MonoBehaviour
	{
		[Serializable]
		public class ControlSurface
		{
			public enum Type
			{
				Aileron,
				Elevator,
				Rudder,
				RuddervatorNegative,
				RuddervatorPositive
			}

			public Transform transform;

			public float amount;

			public Type type;

			[HideInInspector]
			public Quaternion originalLocalRotation;
		}

		[SerializeField]
		private float m_Smoothing = 5f;

		[SerializeField]
		private ControlSurface[] m_ControlSurfaces;

		private AeroplaneController m_Plane;

		private void Start()
		{
			m_Plane = GetComponent<AeroplaneController>();
			ControlSurface[] controlSurfaces = m_ControlSurfaces;
			foreach (ControlSurface obj in controlSurfaces)
			{
				obj.originalLocalRotation = obj.transform.localRotation;
			}
		}

		private void Update()
		{
			ControlSurface[] controlSurfaces = m_ControlSurfaces;
			foreach (ControlSurface controlSurface in controlSurfaces)
			{
				switch (controlSurface.type)
				{
				case ControlSurface.Type.Aileron:
				{
					Quaternion rotation5 = Quaternion.Euler(controlSurface.amount * m_Plane.RollInput, 0f, 0f);
					RotateSurface(controlSurface, rotation5);
					break;
				}
				case ControlSurface.Type.Elevator:
				{
					Quaternion rotation4 = Quaternion.Euler(controlSurface.amount * (0f - m_Plane.PitchInput), 0f, 0f);
					RotateSurface(controlSurface, rotation4);
					break;
				}
				case ControlSurface.Type.Rudder:
				{
					Quaternion rotation3 = Quaternion.Euler(0f, controlSurface.amount * m_Plane.YawInput, 0f);
					RotateSurface(controlSurface, rotation3);
					break;
				}
				case ControlSurface.Type.RuddervatorPositive:
				{
					float num2 = m_Plane.YawInput + m_Plane.PitchInput;
					Quaternion rotation2 = Quaternion.Euler(0f, 0f, controlSurface.amount * num2);
					RotateSurface(controlSurface, rotation2);
					break;
				}
				case ControlSurface.Type.RuddervatorNegative:
				{
					float num = m_Plane.YawInput - m_Plane.PitchInput;
					Quaternion rotation = Quaternion.Euler(0f, 0f, controlSurface.amount * num);
					RotateSurface(controlSurface, rotation);
					break;
				}
				}
			}
		}

		private void RotateSurface(ControlSurface surface, Quaternion rotation)
		{
			Quaternion b = surface.originalLocalRotation * rotation;
			surface.transform.localRotation = Quaternion.Slerp(surface.transform.localRotation, b, m_Smoothing * Time.deltaTime);
		}
	}
	public class AeroplanePropellerAnimator : MonoBehaviour
	{
		[SerializeField]
		private Transform m_PropellorModel;

		[SerializeField]
		private Transform m_PropellorBlur;

		[SerializeField]
		private Texture2D[] m_PropellorBlurTextures;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_ThrottleBlurStart = 0.25f;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_ThrottleBlurEnd = 0.5f;

		[SerializeField]
		private float m_MaxRpm = 2000f;

		private AeroplaneController m_Plane;

		private int m_PropellorBlurState = -1;

		private const float k_RpmToDps = 60f;

		private Renderer m_PropellorModelRenderer;

		private Renderer m_PropellorBlurRenderer;

		private void Awake()
		{
			m_Plane = GetComponent<AeroplaneController>();
			m_PropellorModelRenderer = m_PropellorModel.GetComponent<Renderer>();
			m_PropellorBlurRenderer = m_PropellorBlur.GetComponent<Renderer>();
			m_PropellorBlur.parent = m_PropellorModel;
		}

		private void Update()
		{
			m_PropellorModel.Rotate(0f, m_MaxRpm * m_Plane.Throttle * Time.deltaTime * 60f, 0f);
			int num = 0;
			if (m_Plane.Throttle > m_ThrottleBlurStart)
			{
				num = Mathf.FloorToInt(Mathf.InverseLerp(m_ThrottleBlurStart, m_ThrottleBlurEnd, m_Plane.Throttle) * (float)(m_PropellorBlurTextures.Length - 1));
			}
			if (num != m_PropellorBlurState)
			{
				m_PropellorBlurState = num;
				if (m_PropellorBlurState == 0)
				{
					m_PropellorModelRenderer.enabled = true;
					m_PropellorBlurRenderer.enabled = false;
				}
				else
				{
					m_PropellorModelRenderer.enabled = false;
					m_PropellorBlurRenderer.enabled = true;
					m_PropellorBlurRenderer.material.mainTexture = m_PropellorBlurTextures[m_PropellorBlurState];
				}
			}
		}
	}
	[RequireComponent(typeof(AeroplaneController))]
	public class AeroplaneUserControl2Axis : MonoBehaviour
	{
		public float maxRollAngle = 80f;

		public float maxPitchAngle = 80f;

		private AeroplaneController m_Aeroplane;

		private void Awake()
		{
			m_Aeroplane = GetComponent<AeroplaneController>();
		}

		private void FixedUpdate()
		{
			float roll = CrossPlatformInputManager.GetAxis("Horizontal");
			float pitch = CrossPlatformInputManager.GetAxis("Vertical");
			bool button = CrossPlatformInputManager.GetButton("Fire1");
			float throttle = ((!button) ? 1 : (-1));
			AdjustInputForMobileControls(ref roll, ref pitch, ref throttle);
			m_Aeroplane.Move(roll, pitch, 0f, throttle, button);
		}

		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
			float num = roll * maxRollAngle * ((float)Math.PI / 180f);
			float num2 = pitch * maxPitchAngle * ((float)Math.PI / 180f);
			roll = Mathf.Clamp(num - m_Aeroplane.RollAngle, -1f, 1f);
			pitch = Mathf.Clamp(num2 - m_Aeroplane.PitchAngle, -1f, 1f);
			float num3 = throttle * 0.5f + 0.5f;
			throttle = Mathf.Clamp(num3 - m_Aeroplane.Throttle, -1f, 1f);
		}
	}
	[RequireComponent(typeof(AeroplaneController))]
	public class AeroplaneUserControl4Axis : MonoBehaviour
	{
		public float maxRollAngle = 80f;

		public float maxPitchAngle = 80f;

		private AeroplaneController m_Aeroplane;

		private float m_Throttle;

		private bool m_AirBrakes;

		private float m_Yaw;

		private void Awake()
		{
			m_Aeroplane = GetComponent<AeroplaneController>();
		}

		private void FixedUpdate()
		{
			float roll = CrossPlatformInputManager.GetAxis("Mouse X");
			float pitch = CrossPlatformInputManager.GetAxis("Mouse Y");
			m_AirBrakes = CrossPlatformInputManager.GetButton("Fire1");
			m_Yaw = CrossPlatformInputManager.GetAxis("Horizontal");
			m_Throttle = CrossPlatformInputManager.GetAxis("Vertical");
			AdjustInputForMobileControls(ref roll, ref pitch, ref m_Throttle);
			m_Aeroplane.Move(roll, pitch, m_Yaw, m_Throttle, m_AirBrakes);
		}

		private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
		{
			float num = roll * maxRollAngle * ((float)Math.PI / 180f);
			float num2 = pitch * maxPitchAngle * ((float)Math.PI / 180f);
			roll = Mathf.Clamp(num - m_Aeroplane.RollAngle, -1f, 1f);
			pitch = Mathf.Clamp(num2 - m_Aeroplane.PitchAngle, -1f, 1f);
		}
	}
	[RequireComponent(typeof(ParticleSystem))]
	public class JetParticleEffect : MonoBehaviour
	{
		public Color minColour;

		private AeroplaneController m_Jet;

		private ParticleSystem m_System;

		private float m_OriginalStartSize;

		private float m_OriginalLifetime;

		private Color m_OriginalStartColor;

		private void Start()
		{
			m_Jet = FindAeroplaneParent();
			m_System = GetComponent<ParticleSystem>();
			m_OriginalLifetime = m_System.main.startLifetime.constant;
			m_OriginalStartSize = m_System.main.startSize.constant;
			m_OriginalStartColor = m_System.main.startColor.color;
		}

		private void Update()
		{
			ParticleSystem.MainModule main = m_System.main;
			main.startLifetime = Mathf.Lerp(0f, m_OriginalLifetime, m_Jet.Throttle);
			main.startSize = Mathf.Lerp(m_OriginalStartSize * 0.3f, m_OriginalStartSize, m_Jet.Throttle);
			main.startColor = Color.Lerp(minColour, m_OriginalStartColor, m_Jet.Throttle);
		}

		private AeroplaneController FindAeroplaneParent()
		{
			Transform parent = base.transform;
			while (parent != null)
			{
				AeroplaneController component = parent.GetComponent<AeroplaneController>();
				if (component == null)
				{
					parent = parent.parent;
					continue;
				}
				return component;
			}
			throw new Exception(" AeroplaneContoller not found in object hierarchy");
		}
	}
	public class LandingGear : MonoBehaviour
	{
		private enum GearState
		{
			Raised = -1,
			Lowered = 1
		}

		public float raiseAtAltitude = 40f;

		public float lowerAtAltitude = 40f;

		private GearState m_State = GearState.Lowered;

		private Animator m_Animator;

		private Rigidbody m_Rigidbody;

		private AeroplaneController m_Plane;

		private void Start()
		{
			m_Plane = GetComponent<AeroplaneController>();
			m_Animator = GetComponent<Animator>();
			m_Rigidbody = GetComponent<Rigidbody>();
		}

		private void Update()
		{
			if (m_State == GearState.Lowered && m_Plane.Altitude > raiseAtAltitude && m_Rigidbody.velocity.y > 0f)
			{
				m_State = GearState.Raised;
			}
			if (m_State == GearState.Raised && m_Plane.Altitude < lowerAtAltitude && m_Rigidbody.velocity.y < 0f)
			{
				m_State = GearState.Lowered;
			}
			m_Animator.SetInteger("GearState", (int)m_State);
		}
	}
}
namespace UnityStandardAssets.Vehicles.Ball
{
	public class Ball : MonoBehaviour
	{
		[SerializeField]
		private float m_MovePower = 5f;

		[SerializeField]
		private bool m_UseTorque = true;

		[SerializeField]
		private float m_MaxAngularVelocity = 25f;

		[SerializeField]
		private float m_JumpPower = 2f;

		private const float k_GroundRayLength = 1f;

		private Rigidbody m_Rigidbody;

		private void Start()
		{
			m_Rigidbody = GetComponent<Rigidbody>();
			GetComponent<Rigidbody>().maxAngularVelocity = m_MaxAngularVelocity;
		}

		public void Move(Vector3 moveDirection, bool jump)
		{
			if (m_UseTorque)
			{
				m_Rigidbody.AddTorque(new Vector3(moveDirection.z, 0f, 0f - moveDirection.x) * m_MovePower);
			}
			else
			{
				m_Rigidbody.AddForce(moveDirection * m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1f) && jump)
			{
				m_Rigidbody.AddForce(Vector3.up * m_JumpPower, ForceMode.Impulse);
			}
		}
	}
	public class BallUserControl : MonoBehaviour
	{
		private Ball ball;

		private Vector3 move;

		private Transform cam;

		private Vector3 camForward;

		private bool jump;

		private void Awake()
		{
			ball = GetComponent<Ball>();
			if (Camera.main != null)
			{
				cam = Camera.main.transform;
			}
			else
			{
				UnityEngine.Debug.LogWarning("Warning: no main camera found. Ball needs a Camera tagged \"MainCamera\", for camera-relative controls.");
			}
		}

		private void Update()
		{
			float axis = CrossPlatformInputManager.GetAxis("Horizontal");
			float axis2 = CrossPlatformInputManager.GetAxis("Vertical");
			jump = CrossPlatformInputManager.GetButton("Jump");
			if (cam != null)
			{
				camForward = Vector3.Scale(cam.forward, new Vector3(1f, 0f, 1f)).normalized;
				move = (axis2 * camForward + axis * cam.right).normalized;
			}
			else
			{
				move = (axis2 * Vector3.forward + axis * Vector3.right).normalized;
			}
		}

		private void FixedUpdate()
		{
			ball.Move(move, jump);
			jump = false;
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[RequireComponent(typeof(NavMeshAgent))]
	[RequireComponent(typeof(ThirdPersonCharacter))]
	public class AICharacterControl : MonoBehaviour
	{
		public Transform target;

		public NavMeshAgent agent { get; private set; }

		public ThirdPersonCharacter character { get; private set; }

		private void Start()
		{
			agent = GetComponentInChildren<NavMeshAgent>();
			character = GetComponent<ThirdPersonCharacter>();
			agent.updateRotation = false;
			agent.updatePosition = true;
		}

		private void Update()
		{
			if (target != null)
			{
				agent.SetDestination(target.position);
			}
			if (agent.remainingDistance > agent.stoppingDistance)
			{
				character.Move(agent.desiredVelocity, crouch: false, jump: false);
			}
			else
			{
				character.Move(Vector3.zero, crouch: false, jump: false);
			}
		}

		public void SetTarget(Transform target)
		{
			this.target = target;
		}
	}
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Animator))]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[SerializeField]
		private float m_MovingTurnSpeed = 360f;

		[SerializeField]
		private float m_StationaryTurnSpeed = 180f;

		[SerializeField]
		private float m_JumpPower = 12f;

		[Range(1f, 4f)]
		[SerializeField]
		private float m_GravityMultiplier = 2f;

		[SerializeField]
		private float m_RunCycleLegOffset = 0.2f;

		[SerializeField]
		private float m_MoveSpeedMultiplier = 1f;

		[SerializeField]
		private float m_AnimSpeedMultiplier = 1f;

		[SerializeField]
		private float m_GroundCheckDistance = 0.1f;

		private Rigidbody m_Rigidbody;

		private Animator m_Animator;

		private bool m_IsGrounded;

		private float m_OrigGroundCheckDistance;

		private const float k_Half = 0.5f;

		private float m_TurnAmount;

		private float m_ForwardAmount;

		private Vector3 m_GroundNormal;

		private float m_CapsuleHeight;

		private Vector3 m_CapsuleCenter;

		private CapsuleCollider m_Capsule;

		private bool m_Crouching;

		private void Start()
		{
			m_Animator = GetComponent<Animator>();
			m_Rigidbody = GetComponent<Rigidbody>();
			m_Capsule = GetComponent<CapsuleCollider>();
			m_CapsuleHeight = m_Capsule.height;
			m_CapsuleCenter = m_Capsule.center;
			m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
			m_OrigGroundCheckDistance = m_GroundCheckDistance;
		}

		public void Move(Vector3 move, bool crouch, bool jump)
		{
			if (move.magnitude > 1f)
			{
				move.Normalize();
			}
			move = base.transform.InverseTransformDirection(move);
			CheckGroundStatus();
			move = Vector3.ProjectOnPlane(move, m_GroundNormal);
			m_TurnAmount = Mathf.Atan2(move.x, move.z);
			m_ForwardAmount = move.z;
			ApplyExtraTurnRotation();
			if (m_IsGrounded)
			{
				HandleGroundedMovement(crouch, jump);
			}
			else
			{
				HandleAirborneMovement();
			}
			ScaleCapsuleForCrouching(crouch);
			PreventStandingInLowHeadroom();
			UpdateAnimator(move);
		}

		private void ScaleCapsuleForCrouching(bool crouch)
		{
			if (m_IsGrounded && crouch)
			{
				if (!m_Crouching)
				{
					m_Capsule.height /= 2f;
					m_Capsule.center /= 2f;
					m_Crouching = true;
				}
			}
			else if (Physics.SphereCast(new Ray(m_Rigidbody.position + Vector3.up * m_Capsule.radius * 0.5f, Vector3.up), maxDistance: m_CapsuleHeight - m_Capsule.radius * 0.5f, radius: m_Capsule.radius * 0.5f, layerMask: -1, queryTriggerInteraction: QueryTriggerInteraction.Ignore))
			{
				m_Crouching = true;
			}
			else
			{
				m_Capsule.height = m_CapsuleHeight;
				m_Capsule.center = m_CapsuleCenter;
				m_Crouching = false;
			}
		}

		private void PreventStandingInLowHeadroom()
		{
			if (!m_Crouching && Physics.SphereCast(new Ray(m_Rigidbody.position + Vector3.up * m_Capsule.radius * 0.5f, Vector3.up), maxDistance: m_CapsuleHeight - m_Capsule.radius * 0.5f, radius: m_Capsule.radius * 0.5f, layerMask: -1, queryTriggerInteraction: QueryTriggerInteraction.Ignore))
			{
				m_Crouching = true;
			}
		}

		private void UpdateAnimator(Vector3 move)
		{
			m_Animator.SetFloat("Forward", m_ForwardAmount, 0.1f, Time.deltaTime);
			m_Animator.SetFloat("Turn", m_TurnAmount, 0.1f, Time.deltaTime);
			m_Animator.SetBool("Crouch", m_Crouching);
			m_Animator.SetBool("OnGround", m_IsGrounded);
			if (!m_IsGrounded)
			{
				m_Animator.SetFloat("Jump", m_Rigidbody.velocity.y);
			}
			float value = (float)((Mathf.Repeat(m_Animator.GetCurrentAnimatorStateInfo(0).normalizedTime + m_RunCycleLegOffset, 1f) < 0.5f) ? 1 : (-1)) * m_ForwardAmount;
			if (m_IsGrounded)
			{
				m_Animator.SetFloat("JumpLeg", value);
			}
			if (m_IsGrounded && move.magnitude > 0f)
			{
				m_Animator.speed = m_AnimSpeedMultiplier;
			}
			else
			{
				m_Animator.speed = 1f;
			}
		}

		private void HandleAirborneMovement()
		{
			Vector3 force = Physics.gravity * m_GravityMultiplier - Physics.gravity;
			m_Rigidbody.AddForce(force);
			m_GroundCheckDistance = ((m_Rigidbody.velocity.y < 0f) ? m_OrigGroundCheckDistance : 0.01f);
		}

		private void HandleGroundedMovement(bool crouch, bool jump)
		{
			if (jump && !crouch && m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Grounded"))
			{
				m_Rigidbody.velocity = new Vector3(m_Rigidbody.velocity.x, m_JumpPower, m_Rigidbody.velocity.z);
				m_IsGrounded = false;
				m_Animator.applyRootMotion = false;
				m_GroundCheckDistance = 0.1f;
			}
		}

		private void ApplyExtraTurnRotation()
		{
			float num = Mathf.Lerp(m_StationaryTurnSpeed, m_MovingTurnSpeed, m_ForwardAmount);
			base.transform.Rotate(0f, m_TurnAmount * num * Time.deltaTime, 0f);
		}

		public void OnAnimatorMove()
		{
			if (m_IsGrounded && Time.deltaTime > 0f)
			{
				Vector3 velocity = m_Animator.deltaPosition * m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = m_Rigidbody.velocity.y;
				m_Rigidbody.velocity = velocity;
			}
		}

		private void CheckGroundStatus()
		{
			if (Physics.Raycast(base.transform.position + Vector3.up * 0.1f, Vector3.down, out var hitInfo, m_GroundCheckDistance))
			{
				m_GroundNormal = hitInfo.normal;
				m_IsGrounded = true;
				m_Animator.applyRootMotion = true;
			}
			else
			{
				m_IsGrounded = false;
				m_GroundNormal = Vector3.up;
				m_Animator.applyRootMotion = false;
			}
		}
	}
	[RequireComponent(typeof(ThirdPersonCharacter))]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		private ThirdPersonCharacter m_Character;

		private Transform m_Cam;

		private Vector3 m_CamForward;

		private Vector3 m_Move;

		private bool m_Jump;

		private void Start()
		{
			if (Camera.main != null)
			{
				m_Cam = Camera.main.transform;
			}
			else
			{
				UnityEngine.Debug.LogWarning("Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.", base.gameObject);
			}
			m_Character = GetComponent<ThirdPersonCharacter>();
		}

		private void Update()
		{
			if (!m_Jump)
			{
				m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
			}
		}

		private void FixedUpdate()
		{
			float axis = CrossPlatformInputManager.GetAxis("Horizontal");
			float axis2 = CrossPlatformInputManager.GetAxis("Vertical");
			bool key = Input.GetKey(KeyCode.C);
			if (m_Cam != null)
			{
				m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1f, 0f, 1f)).normalized;
				m_Move = axis2 * m_CamForward + axis * m_Cam.right;
			}
			else
			{
				m_Move = axis2 * Vector3.forward + axis * Vector3.right;
			}
			m_Character.Move(m_Move, key, m_Jump);
			m_Jump = false;
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
			m_Camera = Camera.main;
			m_OriginalCameraPosition = m_Camera.transform.localPosition;
			m_FovKick.Setup(m_Camera);
			m_HeadBob.Setup(m_Camera, m_StepInterval);
			m_StepCycle = 0f;
			m_NextStep = m_StepCycle / 2f;
			m_Jumping = false;
			m_AudioSource = GetComponent<AudioSource>();
			m_MouseLook.Init(base.transform, m_Camera.transform);
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
			if (m_CharacterController.isGrounded)
			{
				int num = UnityEngine.Random.Range(1, m_FootstepSounds.Length);
				m_AudioSource.clip = m_FootstepSounds[num];
				m_AudioSource.PlayOneShot(m_AudioSource.clip);
				m_FootstepSounds[num] = m_FootstepSounds[0];
				m_FootstepSounds[0] = m_AudioSource.clip;
			}
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
			if (lockCursor)
			{
				InternalLockUpdate();
			}
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
namespace UnityStandardAssets.Cameras
{
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		public enum UpdateType
		{
			FixedUpdate,
			LateUpdate,
			ManualUpdate
		}

		[SerializeField]
		protected Transform m_Target;

		[SerializeField]
		private bool m_AutoTargetPlayer = true;

		[SerializeField]
		private UpdateType m_UpdateType;

		protected Rigidbody targetRigidbody;

		public Transform Target => m_Target;

		protected virtual void Start()
		{
			if (m_AutoTargetPlayer)
			{
				FindAndTargetPlayer();
			}
			if (!(m_Target == null))
			{
				targetRigidbody = m_Target.GetComponent<Rigidbody>();
			}
		}

		private void FixedUpdate()
		{
			if (m_AutoTargetPlayer && (m_Target == null || !m_Target.gameObject.activeSelf))
			{
				FindAndTargetPlayer();
			}
			if (m_UpdateType == UpdateType.FixedUpdate)
			{
				FollowTarget(Time.deltaTime);
			}
		}

		private void LateUpdate()
		{
			if (m_AutoTargetPlayer && (m_Target == null || !m_Target.gameObject.activeSelf))
			{
				FindAndTargetPlayer();
			}
			if (m_UpdateType == UpdateType.LateUpdate)
			{
				FollowTarget(Time.deltaTime);
			}
		}

		public void ManualUpdate()
		{
			if (m_AutoTargetPlayer && (m_Target == null || !m_Target.gameObject.activeSelf))
			{
				FindAndTargetPlayer();
			}
			if (m_UpdateType == UpdateType.ManualUpdate)
			{
				FollowTarget(Time.deltaTime);
			}
		}

		protected abstract void FollowTarget(float deltaTime);

		public void FindAndTargetPlayer()
		{
			GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
			if ((bool)gameObject)
			{
				SetTarget(gameObject.transform);
			}
		}

		public virtual void SetTarget(Transform newTransform)
		{
			m_Target = newTransform;
		}
	}
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[SerializeField]
		private float m_MoveSpeed = 3f;

		[SerializeField]
		private float m_TurnSpeed = 1f;

		[SerializeField]
		private float m_RollSpeed = 0.2f;

		[SerializeField]
		private bool m_FollowVelocity;

		[SerializeField]
		private bool m_FollowTilt = true;

		[SerializeField]
		private float m_SpinTurnLimit = 90f;

		[SerializeField]
		private float m_TargetVelocityLowerLimit = 4f;

		[SerializeField]
		private float m_SmoothTurnTime = 0.2f;

		private float m_LastFlatAngle;

		private float m_CurrentTurnAmount;

		private float m_TurnSpeedVelocityChange;

		private Vector3 m_RollUp = Vector3.up;

		protected override void FollowTarget(float deltaTime)
		{
			if (!(deltaTime > 0f) || m_Target == null)
			{
				return;
			}
			Vector3 forward = m_Target.forward;
			Vector3 up = m_Target.up;
			if (m_FollowVelocity && Application.isPlaying)
			{
				if (targetRigidbody.velocity.magnitude > m_TargetVelocityLowerLimit)
				{
					forward = targetRigidbody.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				m_CurrentTurnAmount = Mathf.SmoothDamp(m_CurrentTurnAmount, 1f, ref m_TurnSpeedVelocityChange, m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(forward.x, forward.z) * 57.29578f;
				if (m_SpinTurnLimit > 0f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(m_LastFlatAngle, num)) / deltaTime;
					float num2 = Mathf.InverseLerp(m_SpinTurnLimit, m_SpinTurnLimit * 0.75f, value);
					float smoothTime = ((m_CurrentTurnAmount > num2) ? 0.1f : 1f);
					if (Application.isPlaying)
					{
						m_CurrentTurnAmount = Mathf.SmoothDamp(m_CurrentTurnAmount, num2, ref m_TurnSpeedVelocityChange, smoothTime);
					}
					else
					{
						m_CurrentTurnAmount = num2;
					}
				}
				else
				{
					m_CurrentTurnAmount = 1f;
				}
				m_LastFlatAngle = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, m_Target.position, deltaTime * m_MoveSpeed);
			if (!m_FollowTilt)
			{
				forward.y = 0f;
				if (forward.sqrMagnitude < float.Epsilon)
				{
					forward = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(forward, m_RollUp);
			m_RollUp = ((m_RollSpeed > 0f) ? Vector3.Slerp(m_RollUp, up, m_RollSpeed * deltaTime) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, m_TurnSpeed * m_CurrentTurnAmount * deltaTime);
		}
	}
	public class FreeLookCam : PivotBasedCameraRig
	{
		[SerializeField]
		private float m_MoveSpeed = 1f;

		[Range(0f, 10f)]
		[SerializeField]
		private float m_TurnSpeed = 1.5f;

		[SerializeField]
		private float m_TurnSmoothing;

		[SerializeField]
		private float m_TiltMax = 75f;

		[SerializeField]
		private float m_TiltMin = 45f;

		[SerializeField]
		private bool m_LockCursor;

		[SerializeField]
		private bool m_VerticalAutoReturn;

		private float m_LookAngle;

		private float m_TiltAngle;

		private const float k_LookDistance = 100f;

		private Vector3 m_PivotEulers;

		private Quaternion m_PivotTargetRot;

		private Quaternion m_TransformTargetRot;

		protected override void Awake()
		{
			base.Awake();
			Cursor.lockState = (m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
			Cursor.visible = !m_LockCursor;
			m_PivotEulers = m_Pivot.rotation.eulerAngles;
			m_PivotTargetRot = m_Pivot.transform.localRotation;
			m_TransformTargetRot = base.transform.localRotation;
		}

		protected void Update()
		{
			HandleRotationMovement();
			if (m_LockCursor && Input.GetMouseButtonUp(0))
			{
				Cursor.lockState = (m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
				Cursor.visible = !m_LockCursor;
			}
		}

		private void OnDisable()
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}

		protected override void FollowTarget(float deltaTime)
		{
			if (!(m_Target == null))
			{
				base.transform.position = Vector3.Lerp(base.transform.position, m_Target.position, deltaTime * m_MoveSpeed);
			}
		}

		private void HandleRotationMovement()
		{
			if (!(Time.timeScale < float.Epsilon))
			{
				float axis = CrossPlatformInputManager.GetAxis("Mouse X");
				float axis2 = CrossPlatformInputManager.GetAxis("Mouse Y");
				m_LookAngle += axis * m_TurnSpeed;
				m_TransformTargetRot = Quaternion.Euler(0f, m_LookAngle, 0f);
				if (m_VerticalAutoReturn)
				{
					m_TiltAngle = ((axis2 > 0f) ? Mathf.Lerp(0f, 0f - m_TiltMin, axis2) : Mathf.Lerp(0f, m_TiltMax, 0f - axis2));
				}
				else
				{
					m_TiltAngle -= axis2 * m_TurnSpeed;
					m_TiltAngle = Mathf.Clamp(m_TiltAngle, 0f - m_TiltMin, m_TiltMax);
				}
				m_PivotTargetRot = Quaternion.Euler(m_TiltAngle, m_PivotEulers.y, m_PivotEulers.z);
				if (m_TurnSmoothing > 0f)
				{
					m_Pivot.localRotation = Quaternion.Slerp(m_Pivot.localRotation, m_PivotTargetRot, m_TurnSmoothing * Time.deltaTime);
					base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, m_TransformTargetRot, m_TurnSmoothing * Time.deltaTime);
				}
				else
				{
					m_Pivot.localRotation = m_PivotTargetRot;
					base.transform.localRotation = m_TransformTargetRot;
				}
			}
		}
	}
	public class HandHeldCam : LookatTarget
	{
		[SerializeField]
		private float m_SwaySpeed = 0.5f;

		[SerializeField]
		private float m_BaseSwayAmount = 0.5f;

		[SerializeField]
		private float m_TrackingSwayAmount = 0.5f;

		[Range(-1f, 1f)]
		[SerializeField]
		private float m_TrackingBias;

		protected override void FollowTarget(float deltaTime)
		{
			base.FollowTarget(deltaTime);
			float num = Mathf.PerlinNoise(0f, Time.time * m_SwaySpeed) - 0.5f;
			float num2 = Mathf.PerlinNoise(0f, Time.time * m_SwaySpeed + 100f) - 0.5f;
			num *= m_BaseSwayAmount;
			num2 *= m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(0f, Time.time * m_SwaySpeed) - 0.5f + m_TrackingBias;
			float num4 = Mathf.PerlinNoise(0f, Time.time * m_SwaySpeed + 100f) - 0.5f + m_TrackingBias;
			num3 *= (0f - m_TrackingSwayAmount) * m_FollowVelocity.x;
			num4 *= m_TrackingSwayAmount * m_FollowVelocity.y;
			base.transform.Rotate(num + num3, num2 + num4, 0f);
		}
	}
	public class LookatTarget : AbstractTargetFollower
	{
		[SerializeField]
		private Vector2 m_RotationRange;

		[SerializeField]
		private float m_FollowSpeed = 1f;

		private Vector3 m_FollowAngles;

		private Quaternion m_OriginalRotation;

		protected Vector3 m_FollowVelocity;

		protected override void Start()
		{
			base.Start();
			m_OriginalRotation = base.transform.localRotation;
		}

		protected override void FollowTarget(float deltaTime)
		{
			base.transform.localRotation = m_OriginalRotation;
			Vector3 vector = base.transform.InverseTransformPoint(m_Target.position);
			float value = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
			value = Mathf.Clamp(value, (0f - m_RotationRange.y) * 0.5f, m_RotationRange.y * 0.5f);
			base.transform.localRotation = m_OriginalRotation * Quaternion.Euler(0f, value, 0f);
			vector = base.transform.InverseTransformPoint(m_Target.position);
			float value2 = Mathf.Atan2(vector.y, vector.z) * 57.29578f;
			value2 = Mathf.Clamp(value2, (0f - m_RotationRange.x) * 0.5f, m_RotationRange.x * 0.5f);
			m_FollowAngles = Vector3.SmoothDamp(target: new Vector3(m_FollowAngles.x + Mathf.DeltaAngle(m_FollowAngles.x, value2), m_FollowAngles.y + Mathf.DeltaAngle(m_FollowAngles.y, value)), current: m_FollowAngles, currentVelocity: ref m_FollowVelocity, smoothTime: m_FollowSpeed);
			base.transform.localRotation = m_OriginalRotation * Quaternion.Euler(0f - m_FollowAngles.x, m_FollowAngles.y, 0f);
		}
	}
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		protected Transform m_Cam;

		protected Transform m_Pivot;

		protected Vector3 m_LastTargetPosition;

		protected virtual void Awake()
		{
			m_Cam = GetComponentInChildren<Camera>().transform;
			m_Pivot = m_Cam.parent;
		}
	}
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		public class RayHitComparer : IComparer
		{
			public int Compare(object x, object y)
			{
				return ((RaycastHit)x).distance.CompareTo(((RaycastHit)y).distance);
			}
		}

		public float clipMoveTime = 0.05f;

		public float returnTime = 0.4f;

		public float sphereCastRadius = 0.1f;

		public bool visualiseInEditor;

		public float closestDistance = 0.5f;

		public string dontClipTag = "Player";

		private Transform m_Cam;

		private Transform m_Pivot;

		private float m_OriginalDist;

		private float m_MoveVelocity;

		private float m_CurrentDist;

		private Ray m_Ray;

		private RaycastHit[] m_Hits;

		private RayHitComparer m_RayHitComparer;

		public bool protecting { get; private set; }

		private void Start()
		{
			m_Cam = GetComponentInChildren<Camera>().transform;
			m_Pivot = m_Cam.parent;
			m_OriginalDist = m_Cam.localPosition.magnitude;
			m_CurrentDist = m_OriginalDist;
			m_RayHitComparer = new RayHitComparer();
		}

		private void LateUpdate()
		{
			float num = m_OriginalDist;
			m_Ray.origin = m_Pivot.position + m_Pivot.forward * sphereCastRadius;
			m_Ray.direction = -m_Pivot.forward;
			Collider[] array = Physics.OverlapSphere(m_Ray.origin, sphereCastRadius);
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(dontClipTag)))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				m_Ray.origin += m_Pivot.forward * sphereCastRadius;
				m_Hits = Physics.RaycastAll(m_Ray, m_OriginalDist - sphereCastRadius);
			}
			else
			{
				m_Hits = Physics.SphereCastAll(m_Ray, sphereCastRadius, m_OriginalDist + sphereCastRadius);
			}
			Array.Sort(m_Hits, m_RayHitComparer);
			float num2 = float.PositiveInfinity;
			for (int j = 0; j < m_Hits.Length; j++)
			{
				if (m_Hits[j].distance < num2 && !m_Hits[j].collider.isTrigger && (!(m_Hits[j].collider.attachedRigidbody != null) || !m_Hits[j].collider.attachedRigidbody.CompareTag(dontClipTag)))
				{
					num2 = m_Hits[j].distance;
					num = 0f - m_Pivot.InverseTransformPoint(m_Hits[j].point).z;
					flag2 = true;
				}
			}
			if (flag2)
			{
				UnityEngine.Debug.DrawRay(m_Ray.origin, -m_Pivot.forward * (num + sphereCastRadius), Color.red);
			}
			protecting = flag2;
			m_CurrentDist = Mathf.SmoothDamp(m_CurrentDist, num, ref m_MoveVelocity, (m_CurrentDist > num) ? clipMoveTime : returnTime);
			m_CurrentDist = Mathf.Clamp(m_CurrentDist, closestDistance, m_OriginalDist);
			m_Cam.localPosition = -Vector3.forward * m_CurrentDist;
		}
	}
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[SerializeField]
		private float m_FovAdjustTime = 1f;

		[SerializeField]
		private float m_ZoomAmountMultiplier = 2f;

		[SerializeField]
		private bool m_IncludeEffectsInSize;

		private float m_BoundSize;

		private float m_FovAdjustVelocity;

		private Camera m_Cam;

		private Transform m_LastTarget;

		protected override void Start()
		{
			base.Start();
			m_BoundSize = MaxBoundsExtent(m_Target, m_IncludeEffectsInSize);
			m_Cam = GetComponentInChildren<Camera>();
		}

		protected override void FollowTarget(float deltaTime)
		{
			float magnitude = (m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(m_BoundSize, magnitude) * 57.29578f * m_ZoomAmountMultiplier;
			m_Cam.fieldOfView = Mathf.SmoothDamp(m_Cam.fieldOfView, target, ref m_FovAdjustVelocity, m_FovAdjustTime);
		}

		public override void SetTarget(Transform newTransform)
		{
			base.SetTarget(newTransform);
			m_BoundSize = MaxBoundsExtent(newTransform, m_IncludeEffectsInSize);
		}

		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			Renderer[] componentsInChildren = obj.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			bool flag = false;
			Renderer[] array = componentsInChildren;
			foreach (Renderer renderer in array)
			{
				if (!(renderer is TrailRenderer) && !(renderer is ParticleSystemRenderer))
				{
					if (!flag)
					{
						flag = true;
						bounds = renderer.bounds;
					}
					else
					{
						bounds.Encapsulate(renderer.bounds);
					}
				}
			}
			return Mathf.Max(bounds.extents.x, bounds.extents.y, bounds.extents.z);
		}
	}
}
namespace UnityStandardAssets._2D
{
	public class Camera2DFollow : MonoBehaviour
	{
		public Transform target;

		public float damping = 1f;

		public float lookAheadFactor = 3f;

		public float lookAheadReturnSpeed = 0.5f;

		public float lookAheadMoveThreshold = 0.1f;

		private float m_OffsetZ;

		private Vector3 m_LastTargetPosition;

		private Vector3 m_CurrentVelocity;

		private Vector3 m_LookAheadPos;

		private void Start()
		{
			m_LastTargetPosition = target.position;
			m_OffsetZ = (base.transform.position - target.position).z;
			base.transform.parent = null;
		}

		private void Update()
		{
			float x = (target.position - m_LastTargetPosition).x;
			if (Mathf.Abs(x) > lookAheadMoveThreshold)
			{
				m_LookAheadPos = lookAheadFactor * Vector3.right * Mathf.Sign(x);
			}
			else
			{
				m_LookAheadPos = Vector3.MoveTowards(m_LookAheadPos, Vector3.zero, Time.deltaTime * lookAheadReturnSpeed);
			}
			Vector3 vector = target.position + m_LookAheadPos + Vector3.forward * m_OffsetZ;
			Vector3 position = Vector3.SmoothDamp(base.transform.position, vector, ref m_CurrentVelocity, damping);
			base.transform.position = position;
			m_LastTargetPosition = target.position;
		}
	}
	public class CameraFollow : MonoBehaviour
	{
		public float xMargin = 1f;

		public float yMargin = 1f;

		public float xSmooth = 8f;

		public float ySmooth = 8f;

		public Vector2 maxXAndY;

		public Vector2 minXAndY;

		private Transform m_Player;

		private void Awake()
		{
			m_Player = GameObject.FindGameObjectWithTag("Player").transform;
		}

		private bool CheckXMargin()
		{
			return Mathf.Abs(base.transform.position.x - m_Player.position.x) > xMargin;
		}

		private bool CheckYMargin()
		{
			return Mathf.Abs(base.transform.position.y - m_Player.position.y) > yMargin;
		}

		private void Update()
		{
			TrackPlayer();
		}

		private void TrackPlayer()
		{
			float value = base.transform.position.x;
			float value2 = base.transform.position.y;
			if (CheckXMargin())
			{
				value = Mathf.Lerp(base.transform.position.x, m_Player.position.x, xSmooth * Time.deltaTime);
			}
			if (CheckYMargin())
			{
				value2 = Mathf.Lerp(base.transform.position.y, m_Player.position.y, ySmooth * Time.deltaTime);
			}
			value = Mathf.Clamp(value, minXAndY.x, maxXAndY.x);
			value2 = Mathf.Clamp(value2, minXAndY.y, maxXAndY.y);
			base.transform.position = new Vector3(value, value2, base.transform.position.z);
		}
	}
	[RequireComponent(typeof(PlatformerCharacter2D))]
	public class Platformer2DUserControl : MonoBehaviour
	{
		private PlatformerCharacter2D m_Character;

		private bool m_Jump;

		private void Awake()
		{
			m_Character = GetComponent<PlatformerCharacter2D>();
		}

		private void Update()
		{
			if (!m_Jump)
			{
				m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
			}
		}

		private void FixedUpdate()
		{
			bool key = Input.GetKey(KeyCode.LeftControl);
			float axis = CrossPlatformInputManager.GetAxis("Horizontal");
			m_Character.Move(axis, key, m_Jump);
			m_Jump = false;
		}
	}
	public class PlatformerCharacter2D : MonoBehaviour
	{
		[SerializeField]
		private float m_MaxSpeed = 10f;

		[SerializeField]
		private float m_JumpForce = 400f;

		[Range(0f, 1f)]
		[SerializeField]
		private float m_CrouchSpeed = 0.36f;

		[SerializeField]
		private bool m_AirControl;

		[SerializeField]
		private LayerMask m_WhatIsGround;

		private Transform m_GroundCheck;

		private const float k_GroundedRadius = 0.2f;

		private bool m_Grounded;

		private Transform m_CeilingCheck;

		private const float k_CeilingRadius = 0.01f;

		private Animator m_Anim;

		private Rigidbody2D m_Rigidbody2D;

		private bool m_FacingRight = true;

		private void Awake()
		{
			m_GroundCheck = base.transform.Find("GroundCheck");
			m_CeilingCheck = base.transform.Find("CeilingCheck");
			m_Anim = GetComponent<Animator>();
			m_Rigidbody2D = GetComponent<Rigidbody2D>();
		}

		private void FixedUpdate()
		{
			m_Grounded = false;
			Collider2D[] array = Physics2D.OverlapCircleAll(m_GroundCheck.position, 0.2f, m_WhatIsGround);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].gameObject != base.gameObject)
				{
					m_Grounded = true;
				}
			}
			m_Anim.SetBool("Ground", m_Grounded);
			m_Anim.SetFloat("vSpeed", m_Rigidbody2D.velocity.y);
		}

		public void Move(float move, bool crouch, bool jump)
		{
			if (!crouch && m_Anim.GetBool("Crouch") && (bool)Physics2D.OverlapCircle(m_CeilingCheck.position, 0.01f, m_WhatIsGround))
			{
				crouch = true;
			}
			m_Anim.SetBool("Crouch", crouch);
			if (m_Grounded || m_AirControl)
			{
				move = (crouch ? (move * m_CrouchSpeed) : move);
				m_Anim.SetFloat("Speed", Mathf.Abs(move));
				m_Rigidbody2D.velocity = new Vector2(move * m_MaxSpeed, m_Rigidbody2D.velocity.y);
				if (move > 0f && !m_FacingRight)
				{
					Flip();
				}
				else if (move < 0f && m_FacingRight)
				{
					Flip();
				}
			}
			if (m_Grounded && jump && m_Anim.GetBool("Ground"))
			{
				m_Grounded = false;
				m_Anim.SetBool("Ground", value: false);
				m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
			}
		}

		private void Flip()
		{
			m_FacingRight = !m_FacingRight;
			Vector3 localScale = base.transform.localScale;
			localScale.x *= -1f;
			base.transform.localScale = localScale;
		}
	}
	public class Restarter : MonoBehaviour
	{
		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player")
			{
				SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
			}
		}
	}
}
