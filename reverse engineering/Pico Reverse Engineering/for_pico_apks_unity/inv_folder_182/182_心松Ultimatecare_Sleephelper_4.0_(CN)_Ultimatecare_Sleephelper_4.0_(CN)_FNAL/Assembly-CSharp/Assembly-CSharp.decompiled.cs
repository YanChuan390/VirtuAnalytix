using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml;
using CurvedUI;
using Mono.Data.Sqlite;
using TMPro;
using Umeng;
using Unity.XR.PXR;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.UI;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: OptionalDependency("Valve.VR.InteractionSystem.Player", "CURVEDUI_STEAMVR_INT")]
[assembly: OptionalDependency("UnityEngine.InputSystem.UI.InputSystemUIInputModule", "CURVEDUI_UNITY_XR")]
[assembly: OptionalDependency("UnityEngine.InputSystem.UI.InputSystemUIInputModule", "CURVEDUI_NEW_INPUT_MODULE")]
[assembly: OptionalDependency("TMPro.TextMeshProUGUI", "CURVEDUI_TMP")]
[assembly: AssemblyVersion("0.0.0.0")]
public class AssetsPathTest : MonoBehaviour
{
	[SerializeField]
	private Text text;

	private void Start()
	{
		text.text = Application.streamingAssetsPath;
		text.text += "\n";
		text.text += Application.dataPath;
		text.text += "\n";
		text.text += Application.persistentDataPath;
		text.text += "\n";
		text.text += Application.temporaryCachePath;
		text.text += "\n";
		string path = MainPath() + "Android/obb/com.Test.SplitobbTest/main.1.com.Test.SplitobbTest.obb!/assets/1.txt";
		StartCoroutine(wwwLoad(path));
	}

	private IEnumerator wwwLoad(string path)
	{
		yield return new WaitForSeconds(0.1f);
		WWW www = new WWW(path);
		yield return www;
		if (string.IsNullOrEmpty(www.error) && www.isDone)
		{
			text.text += www.text;
		}
		else
		{
			text.text += www.error;
		}
		SqliteConnection sqliteConnection = new SqliteConnection("");
		sqliteConnection.Open();
	}

	private void Update()
	{
	}

	public static string MainPath()
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			return "/storage/emulated/0/";
		}
		if (Application.platform == RuntimePlatform.LinuxPlayer)
		{
			return $"/home/{Environment.UserName}";
		}
		return "E://";
	}
}
public class CUI_MoveAlong : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
		(base.transform as RectTransform).anchoredPosition = new Vector2((base.transform as RectTransform).anchoredPosition.x + (base.transform as RectTransform).anchoredPosition.x / 100f, (base.transform as RectTransform).anchoredPosition.y);
		if ((base.transform as RectTransform).anchoredPosition.x > (base.transform.parent as RectTransform).rect.width)
		{
			(base.transform as RectTransform).anchoredPosition = new Vector2(20f, (base.transform as RectTransform).anchoredPosition.y);
		}
	}
}
public class CUI_MoveHeartbeat : MonoBehaviour
{
	public float speed;

	public bool wrapAroundParent = true;

	private RectTransform rectie;

	private RectTransform parentRectie;

	private void Start()
	{
		rectie = base.transform as RectTransform;
		parentRectie = base.transform.parent as RectTransform;
	}

	private void Update()
	{
		rectie.anchoredPosition = new Vector2(rectie.anchoredPosition.x - speed * Time.deltaTime, rectie.anchoredPosition.y);
		if (wrapAroundParent && rectie.anchoredPosition.x + rectie.rect.width < 0f)
		{
			rectie.anchoredPosition = new Vector2(parentRectie.rect.width, rectie.anchoredPosition.y);
		}
	}
}
public class CUI_ShowParentCoordinates : MonoBehaviour
{
	private void Start()
	{
		GetComponent<Text>().text = base.transform.parent.GetComponent<RectTransform>().anchoredPosition.ToString();
	}

	private void Update()
	{
	}
}
public class CUI_rotation_anim : MonoBehaviour
{
	public Vector3 Rotation;

	private void Start()
	{
	}

	private void Update()
	{
		base.transform.RotateAround(base.transform.position, base.transform.up, Rotation.y * Time.deltaTime);
		base.transform.RotateAround(base.transform.position, base.transform.right, Rotation.x * Time.deltaTime);
		base.transform.RotateAround(base.transform.position, base.transform.forward, Rotation.z * Time.deltaTime);
	}
}
public class CUI_touchpad : MonoBehaviour
{
	private RectTransform container;

	[SerializeField]
	private RectTransform dot;

	private void Awake()
	{
		container = base.transform as RectTransform;
	}

	private void MoveDotOnTouchpadAxisChanged(object o, ViveInputArgs args)
	{
		dot.anchoredPosition = new Vector2(args.touchpadAxis.x * container.rect.width * 0.5f, args.touchpadAxis.y * container.rect.width * 0.5f);
	}
}
[ExecuteInEditMode]
public class CurvedUIInputModule : BaseInputModule
{
	public enum CUIControlMethod
	{
		MOUSE = 0,
		GAZE = 1,
		WORLD_MOUSE = 2,
		CUSTOM_RAY = 3,
		STEAMVR_LEGACY = 4,
		OCULUSVR = 5,
		STEAMVR_2 = 8,
		UNITY_XR = 9
	}

	public enum Hand
	{
		Both,
		Right,
		Left
	}

	[SerializeField]
	private CUIControlMethod controlMethod;

	[SerializeField]
	private string submitButtonName = "Fire1";

	[SerializeField]
	private Camera mainEventCamera;

	[SerializeField]
	private LayerMask raycastLayerMask = 32;

	[SerializeField]
	private bool gazeUseTimedClick = false;

	[SerializeField]
	private float gazeClickTimer = 2f;

	[SerializeField]
	private float gazeClickTimerDelay = 1f;

	[SerializeField]
	private Image gazeTimedClickProgressImage;

	[SerializeField]
	private float worldSpaceMouseSensitivity = 1f;

	[SerializeField]
	private Hand usedHand = Hand.Right;

	[SerializeField]
	private Transform pointerTransformOverride;

	private static bool disableOtherInputModulesOnStart = true;

	private static CurvedUIInputModule instance;

	private GameObject currentDragging;

	private GameObject currentPointedAt;

	private GameObject m_rightController;

	private GameObject m_leftController;

	private float gazeTimerProgress;

	private Ray customControllerRay;

	private float dragThreshold = 10f;

	private bool pressedDown = false;

	private bool pressedLastFrame = false;

	private Vector2 lastEventDataPosition;

	private PointerInputModule.MouseButtonEventData storedData;

	private Vector3 lastMouseOnScreenPos = Vector2.zero;

	private Vector2 worldSpaceMouseInCanvasSpace = Vector2.zero;

	private Vector2 lastWorldSpaceMouseOnCanvas = Vector2.zero;

	private Vector2 worldSpaceMouseOnCanvasDelta = Vector2.zero;

	[SerializeField]
	private XRBaseController rightXRController;

	[SerializeField]
	private XRBaseController leftXRController;

	public static CurvedUIInputModule Instance
	{
		get
		{
			if (instance == null)
			{
				instance = EnableInputModule<CurvedUIInputModule>();
			}
			return instance;
		}
		private set
		{
			instance = value;
		}
	}

	public static bool CanInstanceBeAccessed => Instance != null;

	public static CUIControlMethod ControlMethod
	{
		get
		{
			return Instance.controlMethod;
		}
		set
		{
			if (Instance.controlMethod != value)
			{
				Instance.controlMethod = value;
			}
		}
	}

	public LayerMask RaycastLayerMask
	{
		get
		{
			return raycastLayerMask;
		}
		set
		{
			raycastLayerMask = value;
		}
	}

	public Hand UsedHand
	{
		get
		{
			return usedHand;
		}
		set
		{
			usedHand = value;
		}
	}

	public Transform ControllerTransform
	{
		get
		{
			if (PointerTransformOverride != null)
			{
				return PointerTransformOverride;
			}
			return (UsedHand == Hand.Left) ? leftXRController.transform : rightXRController.transform;
		}
	}

	public Vector3 ControllerPointingDirection => ControllerTransform.forward;

	public Vector3 ControllerPointingOrigin => ControllerTransform.position;

	public Transform PointerTransformOverride
	{
		get
		{
			return instance.pointerTransformOverride;
		}
		set
		{
			instance.pointerTransformOverride = value;
		}
	}

	public GameObject CurrentPointedAt => currentPointedAt;

	public Camera EventCamera
	{
		get
		{
			return mainEventCamera;
		}
		set
		{
			mainEventCamera = value;
			if (mainEventCamera != null)
			{
				mainEventCamera.AddComponentIfMissing<CurvedUIPhysicsRaycaster>();
			}
		}
	}

	public static Vector2 MousePosition => Mouse.current.position.ReadValue();

	public static bool LeftMouseButton => Mouse.current.leftButton.isPressed;

	public static Ray CustomControllerRay
	{
		get
		{
			return Instance.customControllerRay;
		}
		set
		{
			Instance.customControllerRay = value;
		}
	}

	public static bool CustomControllerButtonState
	{
		get
		{
			return Instance.pressedDown;
		}
		set
		{
			Instance.pressedDown = value;
		}
	}

	[Obsolete("Use CustomControllerButtonState instead.")]
	public static bool CustomControllerButtonDown
	{
		get
		{
			return CustomControllerButtonState;
		}
		set
		{
			CustomControllerButtonState = value;
		}
	}

	public Vector2 WorldSpaceMouseInCanvasSpace
	{
		get
		{
			return worldSpaceMouseInCanvasSpace;
		}
		set
		{
			worldSpaceMouseInCanvasSpace = value;
			lastWorldSpaceMouseOnCanvas = value;
		}
	}

	public Vector2 WorldSpaceMouseInCanvasSpaceDelta => worldSpaceMouseInCanvasSpace - lastWorldSpaceMouseOnCanvas;

	public float WorldSpaceMouseSensitivity
	{
		get
		{
			return worldSpaceMouseSensitivity;
		}
		set
		{
			worldSpaceMouseSensitivity = value;
		}
	}

	public bool GazeUseTimedClick
	{
		get
		{
			return gazeUseTimedClick;
		}
		set
		{
			gazeUseTimedClick = value;
		}
	}

	public float GazeClickTimer
	{
		get
		{
			return gazeClickTimer;
		}
		set
		{
			gazeClickTimer = Mathf.Max(value, 0f);
		}
	}

	public float GazeClickTimerDelay
	{
		get
		{
			return gazeClickTimerDelay;
		}
		set
		{
			gazeClickTimerDelay = Mathf.Max(value, 0f);
		}
	}

	public float GazeTimerProgress => gazeTimerProgress;

	public Image GazeTimedClickProgressImage
	{
		get
		{
			return gazeTimedClickProgressImage;
		}
		set
		{
			gazeTimedClickProgressImage = value;
		}
	}

	public XRBaseController RightXRController
	{
		get
		{
			return rightXRController;
		}
		set
		{
			rightXRController = value;
		}
	}

	public XRBaseController LeftXRController
	{
		get
		{
			return leftXRController;
		}
		set
		{
			leftXRController = value;
		}
	}

	protected override void Awake()
	{
		if (Application.isPlaying)
		{
			Instance = this;
			base.Awake();
			EventCamera = ((mainEventCamera == null) ? Camera.main : EventCamera);
			if (gazeTimedClickProgressImage != null)
			{
				gazeTimedClickProgressImage.fillAmount = 0f;
			}
			if (ControlMethod == CUIControlMethod.UNITY_XR)
			{
				SetupUnityXrControllers();
			}
		}
	}

	protected override void Start()
	{
		if (Application.isPlaying)
		{
			base.Start();
		}
	}

	protected virtual void Update()
	{
		if (mainEventCamera == null && Application.isPlaying)
		{
			EventCamera = Camera.main;
		}
		if (Time.frameCount % 120 == 0 && EventSystem.current != null && EventSystem.current.gameObject != base.gameObject)
		{
			UnityEngine.Debug.LogError("CURVEDUI: Second EventSystem component detected. This can make UI unusable. Make sure there is only one EventSystem component on the scene. Click on this message to have the extra one selected.", EventSystem.current.gameObject);
		}
	}

	private void SetupUnityXrControllers()
	{
		if (rightXRController != null && leftXRController != null)
		{
			return;
		}
		XRController[] array = UnityEngine.Object.FindObjectsOfType<XRController>();
		foreach (XRController xRController in array)
		{
			if (rightXRController == null && xRController.controllerNode == XRNode.RightHand)
			{
				rightXRController = xRController;
			}
			if (leftXRController == null && xRController.controllerNode == XRNode.LeftHand)
			{
				leftXRController = xRController;
			}
		}
	}

	public override void Process()
	{
		PointerInputModule.MouseButtonEventData eventData = GetEventData();
		base.eventSystem.RaycastAll(eventData.buttonData, m_RaycastResultCache);
		eventData.buttonData.pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(m_RaycastResultCache);
		if (eventData.buttonData.pointerCurrentRaycast.isValid)
		{
			eventData.buttonData.delta = lastEventDataPosition - eventData.buttonData.position;
			lastEventDataPosition = eventData.buttonData.position;
		}
		ProcessMove(eventData.buttonData, eventData.buttonData.pointerCurrentRaycast.gameObject);
		ProcessButton(eventData, eventData.buttonData);
		ProcessDrag(eventData, eventData.buttonData);
		ProcessScroll(eventData, eventData.buttonData);
		pressedLastFrame = pressedDown;
	}

	protected PointerInputModule.MouseButtonEventData GetEventData()
	{
		if (storedData == null)
		{
			storedData = new PointerInputModule.MouseButtonEventData
			{
				buttonData = new PointerEventData(EventSystem.current)
				{
					button = PointerEventData.InputButton.Left
				}
			};
		}
		storedData.buttonData.Reset();
		switch (ControlMethod)
		{
		case CUIControlMethod.MOUSE:
		case CUIControlMethod.WORLD_MOUSE:
			ProcessMouseController();
			break;
		case CUIControlMethod.GAZE:
			ProcessGaze();
			break;
		case CUIControlMethod.UNITY_XR:
			ProcessUnityXrController();
			break;
		case CUIControlMethod.CUSTOM_RAY:
			ProcessCustomRayController();
			break;
		}
		storedData.buttonData.position = Mouse.current.position.ReadValue();
		storedData.buttonState = CustomRayFramePressedState();
		storedData.buttonData.useDragThreshold = true;
		if (storedData.buttonState == PointerEventData.FramePressState.Pressed)
		{
			storedData.buttonData.pressPosition = storedData.buttonData.position;
		}
		return storedData;
	}

	private void ProcessMove(PointerEventData eventData, GameObject currentRaycastTarget)
	{
		if (currentRaycastTarget == null || eventData.pointerEnter == null)
		{
			foreach (GameObject item in eventData.hovered)
			{
				ExecuteEvents.Execute(item, eventData, ExecuteEvents.pointerExitHandler);
			}
			eventData.hovered.Clear();
			if (currentRaycastTarget == null)
			{
				eventData.pointerEnter = null;
				return;
			}
		}
		if (eventData.pointerEnter == currentRaycastTarget && (bool)currentRaycastTarget)
		{
			return;
		}
		Transform transform = BaseInputModule.FindCommonRoot(eventData.pointerEnter, currentRaycastTarget)?.transform;
		if (eventData.pointerEnter != null)
		{
			Transform parent = eventData.pointerEnter.transform;
			while (parent != null && parent != transform)
			{
				ExecuteEvents.Execute(parent.gameObject, eventData, ExecuteEvents.pointerExitHandler);
				eventData.hovered.Remove(parent.gameObject);
				parent = parent.parent;
			}
		}
		eventData.pointerEnter = currentRaycastTarget;
		if (currentRaycastTarget != null)
		{
			Transform parent2 = currentRaycastTarget.transform;
			while (parent2 != null && parent2 != transform)
			{
				ExecuteEvents.Execute(parent2.gameObject, eventData, ExecuteEvents.pointerEnterHandler);
				eventData.hovered.Add(parent2.gameObject);
				parent2 = parent2.parent;
			}
		}
	}

	private void ProcessButton(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
		GameObject gameObject = eventData.pointerCurrentRaycast.gameObject;
		if (button.buttonState == PointerEventData.FramePressState.Pressed)
		{
			eventData.delta = Vector2.zero;
			eventData.dragging = false;
			eventData.pressPosition = eventData.position;
			eventData.pointerPressRaycast = eventData.pointerCurrentRaycast;
			eventData.eligibleForClick = true;
			GameObject eventHandler = ExecuteEvents.GetEventHandler<ISelectHandler>(gameObject);
			if (eventHandler != null && eventHandler != base.eventSystem.currentSelectedGameObject)
			{
				base.eventSystem.SetSelectedGameObject(null, eventData);
			}
			GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy(gameObject, eventData, ExecuteEvents.pointerDownHandler);
			if (gameObject2 == eventData.lastPress && Time.unscaledTime - eventData.clickTime < 0.28f)
			{
				eventData.clickCount++;
			}
			else
			{
				eventData.clickCount = 1;
			}
			eventData.clickTime = Time.unscaledTime;
			if (gameObject2 == null)
			{
				gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
			}
			eventData.pointerPress = gameObject2;
			eventData.rawPointerPress = gameObject;
			eventData.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
			if (eventData.pointerDrag != null)
			{
				ExecuteEvents.Execute(eventData.pointerDrag, eventData, ExecuteEvents.initializePotentialDrag);
			}
		}
		if (button.buttonState == PointerEventData.FramePressState.Released)
		{
			ExecuteEvents.Execute(eventData.pointerPress, eventData, ExecuteEvents.pointerUpHandler);
			GameObject eventHandler2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
			if (eventData.pointerPress == eventHandler2 && eventData.eligibleForClick)
			{
				ExecuteEvents.Execute(eventData.pointerPress, eventData, ExecuteEvents.pointerClickHandler);
			}
			else if (eventData.dragging && eventData.pointerDrag != null)
			{
				ExecuteEvents.ExecuteHierarchy(gameObject, eventData, ExecuteEvents.dropHandler);
			}
			eventData.eligibleForClick = false;
			eventData.pointerPress = null;
			eventData.rawPointerPress = null;
			if (eventData.dragging && eventData.pointerDrag != null)
			{
				ExecuteEvents.Execute(eventData.pointerDrag, eventData, ExecuteEvents.endDragHandler);
			}
			eventData.dragging = false;
			eventData.pointerDrag = null;
		}
	}

	private void ProcessDrag(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
		if (eventData.pointerDrag == null || !eventData.IsPointerMoving())
		{
			return;
		}
		if (!eventData.dragging && (!eventData.useDragThreshold || (double)(eventData.pressPosition - eventData.position).sqrMagnitude >= (double)base.eventSystem.pixelDragThreshold * (double)base.eventSystem.pixelDragThreshold))
		{
			ExecuteEvents.Execute(eventData.pointerDrag, eventData, ExecuteEvents.beginDragHandler);
			eventData.dragging = true;
		}
		if (eventData.dragging)
		{
			if (eventData.pointerPress != eventData.pointerDrag)
			{
				ExecuteEvents.Execute(eventData.pointerPress, eventData, ExecuteEvents.pointerUpHandler);
				eventData.eligibleForClick = false;
				eventData.pointerPress = null;
				eventData.rawPointerPress = null;
			}
			ExecuteEvents.Execute(eventData.pointerDrag, eventData, ExecuteEvents.dragHandler);
		}
	}

	private static void ProcessScroll(PointerInputModule.MouseButtonEventData button, PointerEventData eventData)
	{
		if (!Mathf.Approximately(eventData.scrollDelta.sqrMagnitude, 0f))
		{
			GameObject eventHandler = ExecuteEvents.GetEventHandler<IScrollHandler>(eventData.pointerEnter);
			ExecuteEvents.ExecuteHierarchy(eventHandler, eventData, ExecuteEvents.scrollHandler);
		}
	}

	private void ProcessUnityXrController()
	{
		bool pressed = false;
		GetXrControllerButtonState(ref pressed, usedHand);
		CustomControllerButtonState = pressed;
		CustomControllerRay = new Ray(ControllerTransform.transform.position, ControllerTransform.transform.forward);
		ProcessCustomRayController();
	}

	protected virtual void ProcessMouseController()
	{
		CustomControllerButtonState = Mouse.current.leftButton.isPressed;
		CustomControllerRay = mainEventCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
	}

	protected virtual void ProcessCustomRayController()
	{
	}

	protected virtual void ProcessGaze()
	{
		CustomControllerRay = mainEventCamera.ViewportPointToRay(Vector3.one * 0.5f);
	}

	public void GetXrControllerButtonState(ref bool pressed, Hand checkHand)
	{
		if (checkHand == Hand.Right || checkHand != Hand.Left)
		{
			if (rightXRController is ActionBasedController actionBasedController)
			{
				pressed = actionBasedController.uiPressInteractionState.active;
			}
			else if (rightXRController is XRController xRController)
			{
				xRController.inputDevice.IsPressed(xRController.uiPressUsage, out pressed, xRController.axisToPressThreshold);
			}
		}
		else if (leftXRController is ActionBasedController actionBasedController2)
		{
			pressed = actionBasedController2.uiPressInteractionState.active;
		}
		else if (leftXRController is XRController xRController2)
		{
			xRController2.inputDevice.IsPressed(xRController2.uiPressUsage, out pressed, xRController2.axisToPressThreshold);
		}
	}

	private PointerEventData.FramePressState CustomRayFramePressedState()
	{
		if (pressedDown && !pressedLastFrame)
		{
			return PointerEventData.FramePressState.Pressed;
		}
		if (!pressedDown && pressedLastFrame)
		{
			return PointerEventData.FramePressState.Released;
		}
		return PointerEventData.FramePressState.NotChanged;
	}

	protected virtual void ProcessViveControllers()
	{
	}

	protected virtual void ProcessOculusVRController()
	{
	}

	private void ProcessSteamVR2Controllers()
	{
	}

	private static T EnableInputModule<T>() where T : BaseInputModule
	{
		bool flag = true;
		EventSystem eventSystem = UnityEngine.Object.FindObjectOfType<EventSystem>();
		if (eventSystem == null)
		{
			UnityEngine.Debug.LogError("CurvedUI: Your EventSystem component is missing from the scene! Unity Canvas will not track interactions without it.");
			return null;
		}
		BaseInputModule[] components = eventSystem.GetComponents<BaseInputModule>();
		foreach (BaseInputModule baseInputModule in components)
		{
			if (baseInputModule is T)
			{
				flag = false;
				baseInputModule.enabled = true;
			}
			else if (disableOtherInputModulesOnStart)
			{
				baseInputModule.enabled = false;
			}
		}
		if (flag)
		{
			eventSystem.gameObject.AddComponent<T>();
		}
		return eventSystem.GetComponent<T>();
	}

	public Ray GetEventRay(Camera eventCam = null)
	{
		if (eventCam == null)
		{
			eventCam = mainEventCamera;
		}
		return ControlMethod switch
		{
			CUIControlMethod.MOUSE => eventCam.ScreenPointToRay(MousePosition), 
			CUIControlMethod.GAZE => new Ray(eventCam.transform.position, eventCam.transform.forward), 
			CUIControlMethod.STEAMVR_LEGACY => pointerTransformOverride ? new Ray(pointerTransformOverride.position, pointerTransformOverride.forward) : new Ray(ControllerPointingOrigin, ControllerPointingDirection), 
			_ => pointerTransformOverride ? new Ray(pointerTransformOverride.position, pointerTransformOverride.forward) : CustomControllerRay, 
		};
	}
}
public class Controller_Course : MonoSingleton<Controller_Course>
{
	private PlayModel myPlay;

	private ControlModel myControl = ControlModel.byBackground;

	[SerializeField]
	private Model_MediaPlayer myMediaPlayer;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private Text textcurrent;

	[SerializeField]
	private Text texttotal;

	public PlayModel GetPlayModel => myPlay;

	public ControlModel GetControlModel => myControl;

	public float BackgroundVolume
	{
		get
		{
			return myMediaPlayer.BackgroundAudioVolume;
		}
		set
		{
			myMediaPlayer.BackgroundAudioVolume = value;
		}
	}

	public float CourseVolume
	{
		get
		{
			return myMediaPlayer.CourseAudioVolume;
		}
		set
		{
			myMediaPlayer.CourseAudioVolume = value;
		}
	}

	public void RegisterCourse(VideoPlayer mediaPlayer, VideoPlayer introPlayer, AudioSource classAudio, AudioSource backAudio)
	{
		if (myMediaPlayer == null)
		{
			myMediaPlayer = new Model_MediaPlayer(mediaPlayer, introPlayer, classAudio, backAudio);
		}
		myPlay = PlayModel.None;
		Controller_Interact controller_Interact = MonoSingleton<Controller_Interact>.Instance;
		controller_Interact.OnClickXY = (Action)Delegate.Combine(controller_Interact.OnClickXY, (Action)delegate
		{
			if (!MonoSingleton<View_UI>.Instance.GetCantPlayable && myControl != ControlModel.byBackground)
			{
				PauseMedia(myPlay == PlayModel.Pause);
				float value2 = ((myMediaPlayer.GetClassProgress() < 0f) ? 0f : ((myMediaPlayer.GetClassProgress() > 1f) ? 1f : myMediaPlayer.GetClassProgress()));
				slider.value = value2;
				textcurrent.text = GetCurrentTimeText();
				texttotal.text = GetTotalTimeText();
			}
		});
		View_UI view_UI = MonoSingleton<View_UI>.Instance;
		view_UI.changeCourseProgress = (Action<float>)Delegate.Combine(view_UI.changeCourseProgress, (Action<float>)delegate(float value)
		{
			value = ((value >= 1f) ? 1f : ((value < 0f) ? 0f : value));
			myMediaPlayer.SetClassSeek(value);
			textcurrent.text = GetCurrentTimeText(value);
		});
	}

	public void UnRegisterCourse()
	{
		myMediaPlayer.StopClass();
		myMediaPlayer.CloseClass();
		myMediaPlayer = null;
	}

	public void PlayMediaAsBackground(string videopath, AudioClip clip)
	{
		myPlay = PlayModel.None;
		myControl = ControlModel.byBackground;
		myMediaPlayer.InitMedia(myControl, 0f);
		myMediaPlayer.PlayMediaAsBackground(videopath, clip);
	}

	public void OpenMediaAsCourse(ControlModel control, string videopath, AudioClip clip1, AudioClip clip2, float totalTime, bool autoplay)
	{
		slider.value = 0f;
		myPlay = PlayModel.Ready;
		myControl = control;
		myMediaPlayer.InitMedia(myControl, totalTime);
		myMediaPlayer.PlayMediaAsClass(videopath, clip1, clip2, autoplay);
	}

	public void ChangeScene(string videopath)
	{
		myMediaPlayer.ChangeMedia(videopath);
		StartCoroutine(WaitForTargetFrame());
	}

	private IEnumerator WaitForTargetFrame()
	{
		while (!myMediaPlayer.GetMyVideo.GetMediaPlayer.isPlaying)
		{
			yield return new WaitForEndOfFrame();
		}
		while (myMediaPlayer.GetMyVideo.GetMediaPlayer.frame < 2)
		{
			yield return new WaitForEndOfFrame();
		}
		myMediaPlayer.GetMyVideo.GetMediaPlayer.Pause();
	}

	public void ChangeAudio(AudioClip classaudio, AudioClip backaudio)
	{
		myMediaPlayer.ChangeAudios(classaudio, backaudio);
	}

	public void PlayMediaAsCourse()
	{
		myPlay = PlayModel.Play;
		myMediaPlayer.PlayClass();
	}

	public void PauseMedia(bool pause)
	{
		if (pause)
		{
			myPlay = PlayModel.Play;
			myMediaPlayer.PauseOrUnpauseClass(pause: false);
		}
		else
		{
			myPlay = PlayModel.Pause;
			myMediaPlayer.PauseOrUnpauseClass(pause: true);
		}
	}

	public void ResetMedia()
	{
		myMediaPlayer.GetCurrentTime = 0f;
		myMediaPlayer.Restart();
		myPlay = PlayModel.Play;
	}

	public void StopMedia()
	{
		myPlay = PlayModel.End;
		myMediaPlayer.StopClass();
	}

	private void FixedUpdate()
	{
		if (myControl != ControlModel.byBackground && (myPlay == PlayModel.Play || myPlay == PlayModel.Pause))
		{
			if (myPlay == PlayModel.Play && myControl == ControlModel.byTime)
			{
				myMediaPlayer.GetCurrentTime += Time.deltaTime;
			}
			float num = ((myMediaPlayer.GetClassProgress() < 0f) ? 0f : ((myMediaPlayer.GetClassProgress() > 1f) ? 1f : myMediaPlayer.GetClassProgress()));
			if (num > 0.999f && myPlay == PlayModel.Play)
			{
				StopMedia();
				MonoSingleton<View_UI>.Instance.endofCourse();
			}
		}
	}

	private string GetCurrentTimeText()
	{
		int num = (int)(myMediaPlayer.GetClassCurrentTime % 60f);
		int num2 = (int)(myMediaPlayer.GetClassCurrentTime / 60f);
		return $"{((num2 < 10) ? $"0{num2}" : num2.ToString())}:{((num < 10) ? $"0{num}" : num.ToString())}";
	}

	private string GetCurrentTimeText(float value)
	{
		value = ((value < 0f) ? 0f : ((value > 1f) ? 1f : value));
		float num = myMediaPlayer.GetClassTotalTime * value;
		int num2 = (int)(num % 60f);
		int num3 = (int)(num / 60f);
		return $"{((num3 < 10) ? $"0{num3}" : num3.ToString())}:{((num2 < 10) ? $"0{num2}" : num2.ToString())}";
	}

	private string GetTotalTimeText()
	{
		int num = (int)(myMediaPlayer.GetClassTotalTime % 60f);
		int num2 = (int)(myMediaPlayer.GetClassTotalTime / 60f);
		return $"{((num2 < 10) ? $"0{num2}" : num2.ToString())}:{((num < 10) ? $"0{num}" : num.ToString())}";
	}
}
public enum ControlModel
{
	byAudio,
	byVideo,
	byBackground,
	byTime
}
public enum PlayModel
{
	None,
	Ready,
	Play,
	Pause,
	End
}
public class Controller_Database : MonoSingleton<Controller_Database>
{
	private SqliteTools sqliteTools;

	private int count = 0;

	private Dictionary<string, List<Model_CourseData>> courseDatas = new Dictionary<string, List<Model_CourseData>>();

	private Dictionary<string, List<Model_SubCourseData>> subCourseDatas = new Dictionary<string, List<Model_SubCourseData>>();

	private Dictionary<string, Model_PictureData> pictureDatas = new Dictionary<string, Model_PictureData>();

	public Dictionary<string, List<Model_CourseData>> GetCourseDatas => courseDatas;

	public Dictionary<string, List<Model_SubCourseData>> GetSubCourseDatas => subCourseDatas;

	public Dictionary<string, Model_PictureData> GetPictureDatas => pictureDatas;

	public void RegisterDataBase()
	{
		StartCoroutine(StartGetDataFromDataBase());
	}

	private IEnumerator StartGetDataFromDataBase()
	{
		string path = Application.persistentDataPath + "/ultdb_decompression.db";
		UnityEngine.Debug.Log(path);
		yield return new WaitForSeconds(0.3f);
		WWW loadDB = new WWW(Application.streamingAssetsPath + "/database/ultdb_decompression.db");
		yield return loadDB;
		if (loadDB.error != null)
		{
			UnityEngine.Debug.Log(loadDB.error);
		}
		while (!loadDB.isDone)
		{
			yield return new WaitForEndOfFrame();
		}
		File.WriteAllBytes(path, loadDB.bytes);
		yield return new WaitForSeconds(0.1f);
		sqliteTools = new SqliteTools(path);
		sqliteTools.ConnectDB();
		count = 0;
		GetDataFromDataBase("select * from 课程表", 1);
		GetDataFromDataBase("select * from 子课程表", 2);
		GetDataFromDataBase("select * from 图片表", 3);
	}

	public void GetDataFromDataBase(string sql, int k)
	{
		Loom.RunAsync(delegate
		{
			List<Hashtable> list = sqliteTools.ExcuteCoursesFromDB(sql);
			if (k == 1)
			{
				courseDatas = new Dictionary<string, List<Model_CourseData>>();
				foreach (Hashtable item in list)
				{
					string key = item["目录ID"].ToString();
					Model_CourseData model_CourseData = new Model_CourseData();
					if (!courseDatas.ContainsKey(key))
					{
						courseDatas.Add(key, new List<Model_CourseData>());
					}
					model_CourseData.Course_ID = item["课程ID"].ToString();
					model_CourseData.Course_Name = item["课程名"].ToString();
					model_CourseData.Course_Picture = item["课程图片ID"].ToString();
					model_CourseData.Course_Count = item["子课程数量"].ToString();
					model_CourseData.Course_Duration = item["课程时长"].ToString();
					model_CourseData.Course_CourseVideo = item["课程场景ID"].ToString();
					model_CourseData.Course_CourseAudio = item["课程配音ID"].ToString();
					model_CourseData.Course_BackgroundAudio = item["课程配乐ID"].ToString();
					model_CourseData.Course_IntroVideo = item["课程介绍视频"].ToString();
					model_CourseData.Course_SameCourse = item["相似课程ID"].ToString();
					courseDatas[key].Add(model_CourseData);
				}
			}
			else if (k == 2)
			{
				subCourseDatas = new Dictionary<string, List<Model_SubCourseData>>();
				foreach (Hashtable item2 in list)
				{
					string key2 = item2["课程ID"].ToString();
					Model_SubCourseData model_SubCourseData = new Model_SubCourseData();
					if (!subCourseDatas.ContainsKey(key2))
					{
						subCourseDatas.Add(key2, new List<Model_SubCourseData>());
					}
					model_SubCourseData.SubCourse_ID = item2["子课程ID"].ToString();
					model_SubCourseData.SubCourse_Name = item2["子课程名"].ToString();
					model_SubCourseData.SubCourse_Picture = item2["子课程图片ID"].ToString();
					model_SubCourseData.SubCourse_Duration = item2["子课程时长"].ToString();
					model_SubCourseData.SubCourse_Introduce = item2["子课程介绍"].ToString();
					model_SubCourseData.SubCourse_Pause = item2["子课程暂停面板"].ToString();
					model_SubCourseData.SubCourse_Finish = item2["子课程结束面板"].ToString();
					model_SubCourseData.SubCourse_CourseVideo = item2["子课程场景ID"].ToString();
					model_SubCourseData.SubCourse_CourseAudio = item2["子课程配音ID"].ToString();
					model_SubCourseData.SubCourse_BackgroundAudio = item2["子课程配乐ID"].ToString();
					subCourseDatas[key2].Add(model_SubCourseData);
				}
			}
			else if (k == 3)
			{
				pictureDatas = new Dictionary<string, Model_PictureData>();
				foreach (Hashtable item3 in list)
				{
					string key3 = item3["图片ID"].ToString();
					if (!pictureDatas.ContainsKey(key3))
					{
						Model_PictureData value = new Model_PictureData
						{
							Picture_Name = item3["图片名"].ToString(),
							Picture_byte = (byte[])item3["图片"]
						};
						pictureDatas.Add(key3, value);
					}
				}
			}
			Loom.QueueOnMainThread(delegate
			{
				count++;
				if (count == 3)
				{
					sqliteTools.DisConnectDB();
					UnityEngine.Debug.Log("数据库关闭");
				}
				if (k == 3)
				{
					StartCoroutine(TurnBytes2Texture());
				}
			});
		});
	}

	private IEnumerator TurnBytes2Texture()
	{
		Dictionary<string, Model_PictureData> newDic = new Dictionary<string, Model_PictureData>();
		foreach (KeyValuePair<string, Model_PictureData> kvp in pictureDatas)
		{
			yield return new WaitForSeconds(0.04f);
			Model_PictureData model_Picture = kvp.Value;
			model_Picture.Picture_Pic = Blob2Texture(model_Picture.Picture_byte);
			model_Picture.Picture_byte = null;
			newDic.Add(kvp.Key, model_Picture);
		}
		pictureDatas = newDic;
		GC.Collect();
		Resources.UnloadUnusedAssets();
		UnityEngine.Debug.Log("Finish");
	}

	private Texture2D Blob2Texture(byte[] bytes)
	{
		Texture2D texture2D = new Texture2D(1, 1);
		texture2D.LoadImage(bytes);
		texture2D.Compress(highQuality: false);
		return texture2D;
	}
}
public class Controller_Interact : MonoSingleton<Controller_Interact>
{
	[SerializeField]
	private CurvedUIHandSwitcher handSwitcher;

	private XR_BaseInput leftHandle;

	private XR_BaseInput rightHandle;

	private XRController leftController;

	private XRController rightController;

	public Action OnClickXY;

	private float clicktimer = 0f;

	private float intreval = 0.3f;

	public int mainHand
	{
		get
		{
			return PlayerPrefs.HasKey("mainhand") ? PlayerPrefs.GetInt("mainhand") : (-1);
		}
		set
		{
			PlayerPrefs.SetInt("mainhand", value);
		}
	}

	public bool handleShake
	{
		get
		{
			return !PlayerPrefs.HasKey("handshake") || PlayerPrefs.GetInt("handshake") == 1;
		}
		set
		{
			PlayerPrefs.SetInt("handshake", value ? 1 : 0);
		}
	}

	private void Start()
	{
		GameObject.Find("LeftHand Controller").TryGetComponent<XRController>(out leftController);
		GameObject.Find("RightHand Controller").TryGetComponent<XRController>(out rightController);
		if (leftController != null)
		{
			leftHandle = new XR_BaseInput(leftController);
		}
		if (rightController != null)
		{
			rightHandle = new XR_BaseInput(rightController);
		}
		View_UI view_UI = MonoSingleton<View_UI>.Instance;
		view_UI.changeHandleShake = (Action<bool>)Delegate.Combine(view_UI.changeHandleShake, (Action<bool>)delegate(bool b)
		{
			handleShake = b;
		});
		View_UI view_UI2 = MonoSingleton<View_UI>.Instance;
		view_UI2.onChangeMainHand = (Action<int>)Delegate.Combine(view_UI2.onChangeMainHand, new Action<int>(ChangeMainHandle));
		if (mainHand != -1)
		{
			MonoSingleton<View_UI>.Instance.onChangeMainHand(mainHand);
		}
	}

	private void FixedUpdate()
	{
		if (((leftHandle != null && leftHandle.GetPXR_KeyCodeInput(XR_KeyCodeClick.Y)) || (rightHandle != null && rightHandle.GetPXR_KeyCodeInput(XR_KeyCodeClick.B)) || Input.GetKey(KeyCode.B)) && clicktimer > intreval)
		{
			clicktimer = 0f;
			OnClickXY?.Invoke();
		}
		clicktimer += Time.deltaTime;
	}

	private void Update()
	{
		if (Application.platform == RuntimePlatform.WindowsEditor)
		{
			return;
		}
		if (rightHandle != null)
		{
			if (rightController.inputDevice.isValid)
			{
				if (MonoSingleton<Controller_Course>.Instance.GetPlayModel == PlayModel.Play)
				{
					if (rightHandle.GetController.gameObject.activeInHierarchy)
					{
						rightHandle.GetController.gameObject.SetActive(value: false);
					}
				}
				else if (!rightHandle.GetController.gameObject.activeInHierarchy)
				{
					rightHandle.GetController.gameObject.SetActive(value: true);
				}
				if (!MonoSingleton<View_UI>.Instance.RightHandleInteractable)
				{
					MonoSingleton<View_UI>.Instance.RightHandleInteractable = true;
				}
				if (mainHand == -1)
				{
					MonoSingleton<View_UI>.Instance.onChangeMainHand(0);
				}
			}
			else
			{
				if (rightHandle.GetController.gameObject.activeInHierarchy)
				{
					rightHandle.GetController.gameObject.SetActive(value: false);
				}
				if (MonoSingleton<View_UI>.Instance.RightHandleInteractable)
				{
					MonoSingleton<View_UI>.Instance.RightHandleInteractable = false;
				}
				if (mainHand == 0)
				{
					MonoSingleton<View_UI>.Instance.onChangeMainHand(-1);
				}
			}
		}
		if (leftHandle == null)
		{
			return;
		}
		if (leftController.inputDevice.isValid)
		{
			if (MonoSingleton<Controller_Course>.Instance.GetPlayModel == PlayModel.Play)
			{
				if (leftHandle.GetController.gameObject.activeInHierarchy)
				{
					leftHandle.GetController.gameObject.SetActive(value: false);
				}
			}
			else if (!leftHandle.GetController.gameObject.activeInHierarchy)
			{
				leftHandle.GetController.gameObject.SetActive(value: true);
			}
			if (!MonoSingleton<View_UI>.Instance.LeftHandleInteractable)
			{
				MonoSingleton<View_UI>.Instance.LeftHandleInteractable = true;
			}
			if (mainHand == -1)
			{
				MonoSingleton<View_UI>.Instance.onChangeMainHand(1);
			}
		}
		else
		{
			if (leftHandle.GetController.gameObject.activeInHierarchy)
			{
				leftHandle.GetController.gameObject.SetActive(value: false);
			}
			if (MonoSingleton<View_UI>.Instance.LeftHandleInteractable)
			{
				MonoSingleton<View_UI>.Instance.LeftHandleInteractable = false;
			}
			if (mainHand == 1)
			{
				MonoSingleton<View_UI>.Instance.onChangeMainHand(-1);
			}
		}
	}

	private void ChangeMainHandle(int hand)
	{
		mainHand = hand;
		if (mainHand == 0)
		{
			try
			{
				handSwitcher.SwitchHandTo(CurvedUIInputModule.Hand.Right);
			}
			catch
			{
			}
			if (leftHandle != null)
			{
				leftHandle.GetController.GetComponent<XRRayInteractor>().enabled = false;
			}
			if (rightHandle != null)
			{
				rightHandle.GetController.GetComponent<XRRayInteractor>().enabled = true;
			}
		}
		else if (mainHand == 1)
		{
			try
			{
				handSwitcher.SwitchHandTo(CurvedUIInputModule.Hand.Left);
			}
			catch
			{
			}
			if (leftHandle != null)
			{
				leftHandle.GetController.GetComponent<XRRayInteractor>().enabled = true;
			}
			if (rightHandle != null)
			{
				rightHandle.GetController.GetComponent<XRRayInteractor>().enabled = false;
			}
		}
	}

	public void OnHandleShake(float ampli, int time)
	{
		if (handleShake)
		{
			if (mainHand == 1)
			{
				PXR_Input.SetControllerVibration(ampli, time, PXR_Input.Controller.LeftController);
				UnityEngine.Debug.Log("leftshake");
			}
			else if (mainHand == 0)
			{
				PXR_Input.SetControllerVibration(ampli, time, PXR_Input.Controller.RightController);
				UnityEngine.Debug.Log("rightshake");
			}
		}
	}
}
public class Controller_Loading : MonoSingleton<Controller_Loading>
{
	[SerializeField]
	private AudioSource classAudio;

	[SerializeField]
	private AudioSource backAudio;

	private bool cancontinue = false;

	[SerializeField]
	private Material loadmat;

	[SerializeField]
	private RawImage loadimg;

	public void StartOpening(Action beforedark, Action indark, Action afterdark, string panelname1, Action beforeshow, Action aftershow, Action afterhide, string panelname2)
	{
		loadmat.SetColor("_Color", new Color(0f, 0f, 0f, 1f));
		StartCoroutine(TurnMaterial(1, beforedark, delegate
		{
			indark();
			StartCoroutine(TurnPanel(panelname1, beforeshow, aftershow, afterhide, panelname2));
		}, afterdark, 1.2f));
	}

	public void StartTurnPanel(int turn, Action beforedark, Action indark, Action afterdark, string panelname, Action beforeshow, Action aftershow, Action afterhide, string panel2name)
	{
		cancontinue = false;
		StartCoroutine(TurnMaterial(turn, beforedark, indark, afterdark, 0.8f));
		StartCoroutine(TurnPanel(panelname, beforeshow, aftershow, afterhide, panel2name));
	}

	public void StartBack(int turn, Action beforedark, Action indark, Action afterdark)
	{
		StartCoroutine(TurnMaterial(turn, beforedark, indark, afterdark, 0.8f));
	}

	private IEnumerator TurnPanel(string panelname, Action beforeshow, Action aftershow, Action afterhide, string panel2name, float speed = 1f)
	{
		Transform mainPanel = MonoSingleton<View_UI>.Instance.GetUITransform(panelname);
		Image[] imgs = mainPanel.GetComponentsInChildren<Image>();
		RawImage[] rawimgs = mainPanel.GetComponentsInChildren<RawImage>();
		Text[] texts2 = mainPanel.GetComponentsInChildren<Text>();
		List<Graphic> list2 = new List<Graphic>(imgs);
		list2.AddRange(rawimgs);
		list2.AddRange(texts2);
		beforeshow?.Invoke();
		while (!cancontinue)
		{
			yield return new WaitForEndOfFrame();
		}
		StartCoroutine(RotateLoading(loadimg));
		foreach (Graphic graphic4 in list2)
		{
			graphic4.color = new Color(graphic4.color.r, graphic4.color.g, graphic4.color.b, 1f);
		}
		MonoSingleton<View_UI>.Instance.SetUIActive(panelname, active: true);
		aftershow?.Invoke();
		yield return new WaitForSeconds(4f);
		float t2 = 1f;
		while (t2 > 0f)
		{
			t2 -= Time.deltaTime * speed;
			foreach (Graphic graphic3 in list2)
			{
				graphic3.color = new Color(graphic3.color.r, graphic3.color.g, graphic3.color.b, t2);
			}
			yield return new WaitForEndOfFrame();
		}
		if (!string.IsNullOrEmpty(panel2name))
		{
			mainPanel = MonoSingleton<View_UI>.Instance.GetUITransform(panel2name);
			imgs = mainPanel.GetComponentsInChildren<Image>();
			rawimgs = mainPanel.GetComponentsInChildren<RawImage>();
			texts2 = mainPanel.GetComponentsInChildren<Text>();
			list2 = new List<Graphic>(imgs);
			list2.AddRange(rawimgs);
			list2.AddRange(texts2);
			foreach (Graphic graphic2 in list2)
			{
				graphic2.color = new Color(graphic2.color.r, graphic2.color.g, graphic2.color.b, 0f);
			}
			MonoSingleton<View_UI>.Instance.SetUIActive(panel2name, active: true);
			t2 = 0f;
			while (t2 < 1f)
			{
				t2 += Time.deltaTime * speed;
				foreach (Graphic graphic in list2)
				{
					graphic.color = new Color(graphic.color.r, graphic.color.g, graphic.color.b, t2);
				}
				yield return new WaitForEndOfFrame();
			}
		}
		afterhide?.Invoke();
	}

	private IEnumerator RotateLoading(RawImage loadimg)
	{
		int i = 0;
		float t = 0f;
		while (i < SceneAsyncLoad.GetRotateTexture.Length && t < 5f)
		{
			loadimg.texture = SceneAsyncLoad.GetRotateTexture[i];
			i++;
			t += Time.deltaTime;
			yield return new WaitForSeconds(0.033f);
		}
	}

	public void StartChangeScene(Action beforedark, Action indrak, Action afterdark, Action afterall, GameObject game, RawImage loadimg)
	{
		StartCoroutine(ShowChangeScenePanel(game, beforedark, indrak, afterdark, afterall, loadimg));
	}

	private IEnumerator ShowChangeScenePanel(GameObject game, Action beforedark, Action indrak, Action afterdark, Action afterall, RawImage loadimg)
	{
		Image[] imgs = game.GetComponentsInChildren<Image>();
		RawImage[] rawimgs = game.GetComponentsInChildren<RawImage>();
		Text[] texts = game.GetComponentsInChildren<Text>();
		List<Graphic> list = new List<Graphic>(imgs);
		list.AddRange(rawimgs);
		list.AddRange(texts);
		foreach (Graphic graphic3 in list)
		{
			graphic3.color = new Color(graphic3.color.r, graphic3.color.g, graphic3.color.b, 0f);
		}
		bool start = false;
		StartCoroutine(TurnMaterial(2, beforedark, delegate
		{
			start = true;
			indrak();
		}, afterdark, 5f));
		yield return new WaitUntil(() => start);
		StartCoroutine(RotateLoading(loadimg));
		float t = 0f;
		float speed = 1f;
		while (t < 1f)
		{
			t += Time.deltaTime * speed;
			foreach (Graphic graphic2 in list)
			{
				graphic2.color = new Color(graphic2.color.r, graphic2.color.g, graphic2.color.b, t);
			}
			yield return new WaitForEndOfFrame();
		}
		yield return new WaitForSeconds(3.2f);
		while (t > 0f)
		{
			t -= Time.deltaTime * speed;
			foreach (Graphic graphic in list)
			{
				graphic.color = new Color(graphic.color.r, graphic.color.g, graphic.color.b, t);
			}
			yield return new WaitForEndOfFrame();
		}
		afterall?.Invoke();
	}

	private IEnumerator TurnMaterial(int turn, Action beforedark, Action indrak, Action afterdark, float waitTime)
	{
		float speed = 1f;
		beforedark?.Invoke();
		if (turn != 1)
		{
			float t2 = 0f;
			while (t2 < 1f)
			{
				t2 += Time.deltaTime * speed;
				loadmat.SetColor("_Color", new Color(0f, 0f, 0f, t2));
				backAudio.volume -= ((backAudio.volume > 0f) ? Time.deltaTime : 0f);
				classAudio.volume -= ((classAudio.volume > 0f) ? Time.deltaTime : 0f);
				yield return new WaitForEndOfFrame();
			}
		}
		indrak?.Invoke();
		Resources.UnloadUnusedAssets();
		GC.Collect();
		yield return new WaitForSeconds(waitTime);
		cancontinue = true;
		if (turn != 0)
		{
			float t = 1f;
			while (t > 0f)
			{
				t -= Time.deltaTime * speed;
				loadmat.SetColor("_Color", new Color(0f, 0f, 0f, t));
				yield return new WaitForEndOfFrame();
			}
		}
		afterdark?.Invoke();
	}
}
public class Controller_Main : MonoSingleton<Controller_Main>
{
	[SerializeField]
	private VideoPlayer mediaPlayer;

	[SerializeField]
	private AudioSource classAudio;

	[SerializeField]
	private AudioSource backAudio;

	[SerializeField]
	private Controller_Course courseController;

	private string mainVideoPath;

	private string mainAudioPath;

	private bool cancontinue = false;

	private string[] patchstring = new string[6] { "utslv_ocean12", "utslv_ocean16", "utslv_atree07", "utslv_grassland01", "utslv_river04", "utsnlv_distracted02" };

	[SerializeField]
	private Text txt;

	private float classTime = 0f;

	private bool getBackAudio = false;

	private bool getClassAudio = false;

	private string clip_c = null;

	private string clip_b = null;

	public float mainbackgroundvolume
	{
		get
		{
			return PlayerPrefs.HasKey("mainback") ? PlayerPrefs.GetFloat("mainback") : 0.66f;
		}
		set
		{
			PlayerPrefs.SetFloat("mainback", value);
		}
	}

	public float coursebackgroundvolume
	{
		get
		{
			return PlayerPrefs.HasKey("courseback") ? PlayerPrefs.GetFloat("courseback") : 0.66f;
		}
		set
		{
			PlayerPrefs.SetFloat("courseback", value);
		}
	}

	public float coursevolume
	{
		get
		{
			return PlayerPrefs.HasKey("courseaudio") ? PlayerPrefs.GetFloat("courseaudio") : 0.66f;
		}
		set
		{
			PlayerPrefs.SetFloat("courseaudio", value);
		}
	}

	public void Awake()
	{
		courseController.RegisterCourse(mediaPlayer, null, classAudio, backAudio);
		mainVideoPath = Application.streamingAssetsPath + "/video/utslv/terraces19.mp4";
		mainAudioPath = Application.streamingAssetsPath + "/audio/utsbs/hall01.mp3";
		MonoSingleton<View_UI>.Instance.RegisterUI();
		MonoSingleton<Controller_Database>.Instance.RegisterDataBase();
		StartPlayVideo(0.2f);
		SetUIAction();
	}

	public void StartPlayVideo(float time)
	{
		StartCoroutine(StartPlayer(time));
	}

	private IEnumerator StartPlayer(float time)
	{
		yield return new WaitForSeconds(time);
		PlayMainBackgroundMedia();
	}

	private void PlayMainBackgroundMedia()
	{
		courseController.StopMedia();
		mainVideoPath = mainVideoPath.Replace("patch", "main");
		clip_b = null;
		clip_c = null;
		StartCoroutine(GetAudioClip(mainAudioPath, delegate(AudioClip clip)
		{
			clip_b = mainAudioPath;
			courseController.PlayMediaAsBackground(mainVideoPath, clip);
			courseController.BackgroundVolume = mainbackgroundvolume;
		}));
	}

	private void SetUIAction()
	{
		View_UI view_UI = MonoSingleton<View_UI>.Instance;
		view_UI.mainPanelCourseActionMedia = (Action<int>)Delegate.Combine(view_UI.mainPanelCourseActionMedia, new Action<int>(OnSelectMainCourse));
		View_UI view_UI2 = MonoSingleton<View_UI>.Instance;
		view_UI2.course2SubCourse = (Action<Model_SubCourseData, float, string, string, ControlModel>)Delegate.Combine(view_UI2.course2SubCourse, new Action<Model_SubCourseData, float, string, string, ControlModel>(OnSelectSubCourse));
		View_UI view_UI3 = MonoSingleton<View_UI>.Instance;
		view_UI3.startPlayCourse = (Action)Delegate.Combine(view_UI3.startPlayCourse, new Action(StartPlayCourse));
		View_UI view_UI4 = MonoSingleton<View_UI>.Instance;
		view_UI4.back2Main = (Action)Delegate.Combine(view_UI4.back2Main, new Action(OnClickBack2Mian));
		View_UI view_UI5 = MonoSingleton<View_UI>.Instance;
		view_UI5.onClickRestart = (Action)Delegate.Combine(view_UI5.onClickRestart, (Action)delegate
		{
			courseController.ResetMedia();
		});
		View_UI view_UI6 = MonoSingleton<View_UI>.Instance;
		view_UI6.changeBackgroundVolume = (Action<float>)Delegate.Combine(view_UI6.changeBackgroundVolume, (Action<float>)delegate(float value)
		{
			mainbackgroundvolume = value;
			courseController.BackgroundVolume = mainbackgroundvolume;
		});
		View_UI view_UI7 = MonoSingleton<View_UI>.Instance;
		view_UI7.changeCourseBackgroundVolume = (Action<float>)Delegate.Combine(view_UI7.changeCourseBackgroundVolume, (Action<float>)delegate(float value)
		{
			coursebackgroundvolume = value;
			courseController.BackgroundVolume = coursebackgroundvolume;
		});
		View_UI view_UI8 = MonoSingleton<View_UI>.Instance;
		view_UI8.changeCourseVolume = (Action<float>)Delegate.Combine(view_UI8.changeCourseVolume, (Action<float>)delegate(float value)
		{
			coursevolume = value;
			courseController.CourseVolume = coursevolume;
		});
		View_UI view_UI9 = MonoSingleton<View_UI>.Instance;
		view_UI9.changeVideoScene = (Action<Model_SubCourseData>)Delegate.Combine(view_UI9.changeVideoScene, new Action<Model_SubCourseData>(OnChangeVideoScene));
	}

	private void OnChangeVideoScene(Model_SubCourseData subcourse)
	{
		clip_b = null;
		clip_c = null;
		StartCoroutine(waitForSecond(delegate
		{
			string mediaPath = GetMediaPath("video", subcourse.SubCourse_CourseVideo, "mp4");
			string audiopath1 = GetMediaPath("audio", subcourse.SubCourse_CourseAudio, "mp3");
			string audiopath2 = GetMediaPath("audio", subcourse.SubCourse_BackgroundAudio, "mp3");
			List<string> list = new List<string>(patchstring);
			mediaPath = ((!list.Contains(subcourse.SubCourse_CourseVideo)) ? mediaPath.Replace("patch", "main") : mediaPath.Replace("main", "patch"));
			courseController.ChangeScene(mediaPath);
			StartCoroutine(GetCourseAudioClips(audiopath1, audiopath2, delegate(AudioClip clip1, AudioClip clip2)
			{
				clip_b = audiopath2;
				clip_c = audiopath1;
				courseController.ChangeAudio(clip1, clip2);
			}));
		}));
	}

	private IEnumerator waitForSecond(Action action)
	{
		MonoSingleton<View_UI>.Instance.SetUIActive("MaskPanel", active: true);
		MonoSingleton<View_UI>.Instance.SetUIActive("ChangePanel", active: true);
		action();
		yield return new WaitForSeconds(3f);
		MonoSingleton<View_UI>.Instance.SetUIActive("ChangePanel", active: false);
		MonoSingleton<View_UI>.Instance.SetUIActive("MaskPanel", active: false);
	}

	private void OnClickBack2Mian()
	{
		clip_b = null;
		clip_c = null;
		courseController.StopMedia();
		StartCoroutine(GetAudioClip(mainAudioPath, delegate(AudioClip clip)
		{
			clip_b = mainAudioPath;
			courseController.PlayMediaAsBackground(mainVideoPath, clip);
			courseController.BackgroundVolume = mainbackgroundvolume;
			mediaPlayer.transform.localRotation = Quaternion.Euler(new Vector3(0f, 180f, 0f));
		}));
	}

	private void OnSelectSubCourse(Model_SubCourseData subcourse, float time, string coursevideopath, string courseaudiopath, ControlModel model)
	{
		clip_b = null;
		clip_c = null;
		courseController.StopMedia();
		string videopath = GetMediaPath("video", subcourse.SubCourse_CourseVideo, "mp4");
		string audiopath1 = GetMediaPath("audio", subcourse.SubCourse_CourseAudio, "mp3");
		string audiopath2 = GetMediaPath("audio", subcourse.SubCourse_BackgroundAudio, "mp3");
		List<string> list = new List<string>(patchstring);
		if (list.Contains(subcourse.SubCourse_CourseVideo))
		{
			videopath = videopath.Replace("main", "patch");
		}
		else
		{
			videopath = videopath.Replace("patch", "main");
		}
		StartCoroutine(GetCourseAudioClips(audiopath1, audiopath2, delegate(AudioClip clip1, AudioClip clip2)
		{
			clip_b = audiopath2;
			clip_c = audiopath1;
			courseController.OpenMediaAsCourse(model, videopath, clip1, clip2, time, autoplay: true);
			courseController.BackgroundVolume = coursebackgroundvolume;
			courseController.CourseVolume = coursevolume;
		}));
		coursevideopath = GetMediaPath("video", coursevideopath, "mp4");
		courseaudiopath = GetMediaPath("audio", courseaudiopath, "mp3");
		coursevideopath = coursevideopath.Replace("patch", "main");
		MonoSingleton<View_UI>.Instance.back2Course = delegate
		{
			clip_b = null;
			clip_c = null;
			StartCoroutine(GetAudioClip(courseaudiopath, delegate(AudioClip clip)
			{
				clip_b = courseaudiopath;
				courseController.PlayMediaAsBackground(coursevideopath, clip);
				courseController.BackgroundVolume = mainbackgroundvolume;
			}));
		};
	}

	private void OnSelectMainCourse(int k)
	{
		clip_b = null;
		clip_c = null;
		if (k == 0 || k == 1)
		{
			Model_SubCourseData model_SubCourseData = MonoSingleton<Controller_Database>.Instance.GetSubCourseDatas["str01"][0];
			model_SubCourseData = MonoSingleton<Controller_Database>.Instance.GetSubCourseDatas[(k == 0) ? "str01" : "rel01"][0];
			string videopath2 = GetMediaPath("video", model_SubCourseData.SubCourse_CourseVideo, "mp4");
			string audiopath2 = GetMediaPath("audio", model_SubCourseData.SubCourse_CourseAudio, "mp3");
			List<string> list = new List<string>(patchstring);
			if (list.Contains(model_SubCourseData.SubCourse_CourseVideo))
			{
				videopath2 = videopath2.Replace("main", "patch");
			}
			else
			{
				videopath2 = videopath2.Replace("patch", "main");
			}
			if (k == 0)
			{
				courseController.OpenMediaAsCourse(ControlModel.byVideo, videopath2, null, null, 0f, autoplay: true);
				courseController.BackgroundVolume = coursebackgroundvolume;
				courseController.CourseVolume = coursevolume;
				return;
			}
			StartCoroutine(GetAudioClip(audiopath2, delegate(AudioClip clip)
			{
				clip_c = audiopath2;
				courseController.OpenMediaAsCourse(ControlModel.byAudio, videopath2, clip, null, 0f, autoplay: true);
				courseController.BackgroundVolume = coursebackgroundvolume;
				courseController.CourseVolume = coursevolume;
			}));
			return;
		}
		string videopath = null;
		string audiopath = null;
		Model_CourseData model_CourseData = null;
		switch (k)
		{
		case 2:
			model_CourseData = MonoSingleton<Controller_Database>.Instance.GetCourseDatas["meditation"][0];
			break;
		case 4:
			model_CourseData = MonoSingleton<Controller_Database>.Instance.GetCourseDatas["meditation"][1];
			break;
		case 5:
			model_CourseData = MonoSingleton<Controller_Database>.Instance.GetCourseDatas["nature"][0];
			break;
		case 3:
			model_CourseData = MonoSingleton<Controller_Database>.Instance.GetCourseDatas["sleep"][0];
			break;
		}
		if (model_CourseData != null)
		{
			MonoSingleton<View_UI>.Instance.SetSubCourseUI(model_CourseData, k);
			videopath = GetMediaPath("video", model_CourseData.Course_CourseVideo, "mp4");
			audiopath = GetMediaPath("audio", model_CourseData.Course_CourseAudio, "mp3");
			List<string> list2 = new List<string>(patchstring);
			if (list2.Contains(model_CourseData.Course_CourseVideo))
			{
				videopath = videopath.Replace("main", "patch");
			}
			else
			{
				videopath = videopath.Replace("patch", "main");
			}
			StartCoroutine(GetAudioClip(audiopath, delegate(AudioClip clip)
			{
				clip_b = audiopath;
				courseController.PlayMediaAsBackground(videopath, clip);
				courseController.BackgroundVolume = mainbackgroundvolume;
			}));
		}
	}

	private void StartPlayCourse()
	{
		courseController.PlayMediaAsCourse();
	}

	private IEnumerator GetAudioClip(string path, Action<AudioClip> Next)
	{
		path = ((Application.platform == RuntimePlatform.Android) ? path : ("file://" + path));
		WWW www = new WWW(path);
		float timer = 0f;
		while (!www.isDone && string.IsNullOrEmpty(www.error) && timer < 0.8f)
		{
			timer += Time.deltaTime;
			yield return new WaitForEndOfFrame();
		}
		if (www.isDone && string.IsNullOrEmpty(www.error))
		{
			Next?.Invoke(www.GetAudioClip(threeD: true, stream: true));
		}
		else
		{
			if (!string.IsNullOrEmpty(www.error))
			{
			}
			Next?.Invoke(null);
		}
		www.Dispose();
	}

	private IEnumerator GetCourseAudioClips(string path1, string path2, Action<AudioClip, AudioClip> Next)
	{
		AudioClip clip2 = null;
		AudioClip clip3 = null;
		if (path1 != null)
		{
			StartCoroutine(GetAudioClip(path1, delegate(AudioClip clip)
			{
				clip2 = clip;
			}));
		}
		if (path2 != null)
		{
			StartCoroutine(GetAudioClip(path2, delegate(AudioClip clip)
			{
				clip3 = clip;
			}));
		}
		float time = 1.6f;
		while ((clip2 == null || clip3 == null) && time > 0f)
		{
			time -= Time.deltaTime;
			yield return new WaitForEndOfFrame();
		}
		Next?.Invoke(clip2, clip3);
	}

	private string GetMediaPath(string Dir, string Name, string exn)
	{
		return string.Format("{0}/{1}/{2}.{3}", Application.streamingAssetsPath.Replace("patch", "main"), Dir, Name.Replace("_", "/"), exn);
	}

	private void Update()
	{
		if (clip_b != null && (backAudio.clip == null || backAudio.clip.length == 0f) && !getBackAudio)
		{
			getBackAudio = true;
			StartCoroutine(GetAudioClip(clip_b, delegate(AudioClip clip)
			{
				backAudio.clip = clip;
				getBackAudio = false;
				if (courseController.GetControlModel == ControlModel.byBackground || (courseController.GetControlModel != ControlModel.byBackground && courseController.GetPlayModel == PlayModel.Play))
				{
					backAudio.Play();
				}
			}));
		}
		if (clip_c != null && (classAudio.clip == null || classAudio.clip.length == 0f) && !getClassAudio)
		{
			getClassAudio = true;
			StartCoroutine(GetAudioClip(clip_c, delegate(AudioClip clip)
			{
				classAudio.clip = clip;
				getClassAudio = false;
				if (courseController.GetControlModel != ControlModel.byBackground && courseController.GetPlayModel == PlayModel.Play)
				{
					classAudio.time = classTime;
					classAudio.Play();
				}
			}));
		}
		if (classAudio.clip != null && classAudio.clip.length != 0f && classAudio.isPlaying)
		{
			classTime = classAudio.time;
		}
	}
}
public class CurvedUIFixed : MonoBehaviour
{
	private GameObject eventSystem;

	private void Start()
	{
		eventSystem = GameObject.Find("EventSystem");
	}

	private void OnEnable()
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			StartCoroutine(FixedCurvedUI(b: true));
		}
		else
		{
			StartCoroutine(FixedCurvedUI(b: false));
		}
	}

	private void Update()
	{
		if (eventSystem != null)
		{
			if (!eventSystem.GetComponent<XRUIInputModule>().enabled)
			{
				eventSystem.GetComponent<XRUIInputModule>().enabled = true;
			}
			if (eventSystem.GetComponent<CurvedUIInputModule>().enabled)
			{
				eventSystem.GetComponent<CurvedUIInputModule>().enabled = false;
			}
		}
	}

	private IEnumerator FixedCurvedUI(bool b)
	{
		yield return new WaitForSeconds(1f);
		GetComponent<CurvedUIRaycaster>().enabled = b;
		GetComponent<GraphicRaycaster>().enabled = !b;
		GetComponent<TrackedDeviceGraphicRaycaster>().enabled = !b;
	}
}
public class ExceptionHandler : MonoBehaviour
{
	public bool IsHandler = false;

	public bool IsQuitWhenException = false;

	private string LogPath;

	private void Awake()
	{
		LogPath = Application.persistentDataPath + "/Log";
		UnityEngine.Debug.Log(LogPath);
		if (IsHandler)
		{
			Application.RegisterLogCallback(Handler);
		}
	}

	private void OnDestory()
	{
		Application.RegisterLogCallback(null);
	}

	private void Handler(string logString, string stackTrace, LogType type)
	{
		if (type == LogType.Error || type == LogType.Exception || type == LogType.Assert)
		{
			string path = LogPath + "//" + DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss") + ".log";
			if (!Directory.Exists(LogPath))
			{
				Directory.CreateDirectory(LogPath);
			}
			if (!File.Exists(path))
			{
				File.Create(path).Dispose();
			}
			File.AppendAllText(path, "[time]:" + DateTime.Now.ToString() + "\r\n");
			File.AppendAllText(path, "[type]:" + type.ToString() + "\r\n");
			File.AppendAllText(path, "[exception message]:" + logString + "\r\n");
			File.AppendAllText(path, "[stack trace]:" + stackTrace + "\r\n");
			if (IsQuitWhenException)
			{
				Application.Quit();
			}
		}
	}
}
public class BaseInteract : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerDownHandler, IPointerClickHandler, IPointerUpHandler, IPointerExitHandler
{
	public virtual void OnPointerClick(PointerEventData eventData)
	{
		MonoSingleton<Controller_Interact>.Instance.OnHandleShake(0.5f, 100);
	}

	public virtual void OnPointerDown(PointerEventData eventData)
	{
	}

	public virtual void OnPointerEnter(PointerEventData eventData)
	{
		MonoSingleton<Controller_Interact>.Instance.OnHandleShake(0.3f, 100);
	}

	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	public virtual void OnPointerUp(PointerEventData eventData)
	{
	}
}
public class CourseInteract : BaseInteract
{
	public override void OnPointerEnter(PointerEventData eventData)
	{
		base.OnPointerEnter(eventData);
		base.transform.Find("Enter").GetComponent<RawImage>().enabled = true;
	}

	public override void OnPointerExit(PointerEventData eventData)
	{
		base.OnPointerExit(eventData);
		base.transform.Find("Enter").GetComponent<RawImage>().enabled = false;
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
		base.OnPointerUp(eventData);
		base.transform.Find("Enter").GetComponent<RawImage>().enabled = false;
	}
}
public class FunctionInteract : BaseInteract
{
	[SerializeField]
	private Color colorNormal;

	[SerializeField]
	private Color colorLight;

	[SerializeField]
	private Sprite spriteNormal;

	[SerializeField]
	private Sprite spriteLight;

	public bool isOnce = true;

	[HideInInspector]
	public bool isClick = false;

	public override void OnPointerEnter(PointerEventData eventData)
	{
		base.OnPointerEnter(eventData);
		base.transform.Find("RawImage").GetComponent<RawImage>().color = colorLight;
		base.transform.GetComponent<Image>().sprite = spriteLight;
	}

	public override void OnPointerClick(PointerEventData eventData)
	{
		base.OnPointerClick(eventData);
		if (!isOnce)
		{
			isClick = !isClick;
			base.transform.Find("RawImage").GetComponent<RawImage>().color = colorLight;
			base.transform.GetComponent<Image>().sprite = spriteLight;
		}
	}

	public void InitFunction()
	{
		if (isOnce)
		{
			base.transform.Find("RawImage").GetComponent<RawImage>().color = colorNormal;
			base.transform.GetComponent<Image>().sprite = spriteNormal;
		}
		else if (isClick)
		{
			base.transform.Find("RawImage").GetComponent<RawImage>().color = colorLight;
			base.transform.GetComponent<Image>().sprite = spriteLight;
		}
		else
		{
			base.transform.Find("RawImage").GetComponent<RawImage>().color = colorNormal;
			base.transform.GetComponent<Image>().sprite = spriteNormal;
		}
	}

	public override void OnPointerExit(PointerEventData eventData)
	{
		base.OnPointerExit(eventData);
		if (isOnce)
		{
			base.transform.Find("RawImage").GetComponent<RawImage>().color = colorNormal;
			base.transform.GetComponent<Image>().sprite = spriteNormal;
		}
		else if (isClick)
		{
			base.transform.Find("RawImage").GetComponent<RawImage>().color = colorLight;
			base.transform.GetComponent<Image>().sprite = spriteLight;
		}
		else
		{
			base.transform.Find("RawImage").GetComponent<RawImage>().color = colorNormal;
			base.transform.GetComponent<Image>().sprite = spriteNormal;
		}
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
		base.OnPointerUp(eventData);
		if (isOnce)
		{
			base.transform.Find("RawImage").GetComponent<RawImage>().color = colorNormal;
			base.transform.GetComponent<Image>().sprite = spriteNormal;
		}
	}
}
public class FunctionInteract1 : BaseInteract
{
	[SerializeField]
	private Color colorNormal;

	[SerializeField]
	private Color colorLight;

	[SerializeField]
	private Sprite spriteNormal;

	[SerializeField]
	private Sprite spriteLight;

	public override void OnPointerEnter(PointerEventData eventData)
	{
		base.OnPointerEnter(eventData);
		base.transform.Find("Text").GetComponent<Text>().color = colorLight;
		base.transform.GetComponent<Image>().sprite = spriteLight;
	}

	public override void OnPointerExit(PointerEventData eventData)
	{
		base.OnPointerExit(eventData);
		base.transform.Find("Text").GetComponent<Text>().color = colorNormal;
		base.transform.GetComponent<Image>().sprite = spriteNormal;
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
		base.OnPointerUp(eventData);
		base.transform.Find("Text").GetComponent<Text>().color = colorNormal;
		base.transform.GetComponent<Image>().sprite = spriteNormal;
	}
}
public class HandleInteract : BaseInteract
{
}
public class HandleShakeInteract : BaseInteract
{
}
public class SliderInteract : BaseInteract
{
	[SerializeField]
	private Sprite sliderNormal;

	[SerializeField]
	private Sprite sliderLight;

	[SerializeField]
	private Sprite sliderSelect;

	[SerializeField]
	private Sprite handleNormal;

	[SerializeField]
	private Sprite handleLight;

	[SerializeField]
	private Sprite handleSelect;

	private bool Down = false;

	private bool Enter = false;

	public override void OnPointerEnter(PointerEventData eventData)
	{
		base.OnPointerEnter(eventData);
		Enter = true;
		base.transform.Find("Fill Area/Fill").GetComponent<Image>().sprite = sliderLight;
		base.transform.Find("Handle Slide Area/Handle").GetComponent<Image>().sprite = handleLight;
	}

	public override void OnPointerDown(PointerEventData eventData)
	{
		base.OnPointerDown(eventData);
		Down = true;
		base.transform.Find("Fill Area/Fill").GetComponent<Image>().sprite = sliderSelect;
		base.transform.Find("Handle Slide Area/Handle").GetComponent<Image>().sprite = handleSelect;
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
		base.OnPointerUp(eventData);
		Down = false;
		if (Enter)
		{
			base.transform.Find("Fill Area/Fill").GetComponent<Image>().sprite = sliderLight;
			base.transform.Find("Handle Slide Area/Handle").GetComponent<Image>().sprite = handleLight;
		}
		else
		{
			base.transform.Find("Fill Area/Fill").GetComponent<Image>().sprite = sliderNormal;
			base.transform.Find("Handle Slide Area/Handle").GetComponent<Image>().sprite = handleNormal;
		}
	}

	public override void OnPointerExit(PointerEventData eventData)
	{
		base.OnPointerExit(eventData);
		Enter = false;
		if (!Down)
		{
			base.transform.Find("Fill Area/Fill").GetComponent<Image>().sprite = sliderNormal;
			base.transform.Find("Handle Slide Area/Handle").GetComponent<Image>().sprite = handleNormal;
		}
	}
}
public class ToggleInteract : BaseInteract
{
	[SerializeField]
	private Color colorNormal;

	[SerializeField]
	private Color colorLight;

	[SerializeField]
	private Sprite spriteNormal;

	[SerializeField]
	private Sprite spriteLight;

	[SerializeField]
	private bool useToggle = false;

	private static int k = 0;

	public List<ToggleInteract> list = new List<ToggleInteract>();

	private static bool down = false;

	private void Start()
	{
		if (list.Count == 0)
		{
			list = new List<ToggleInteract>(base.transform.parent.GetComponentsInChildren<ToggleInteract>());
		}
	}

	public override void OnPointerEnter(PointerEventData eventData)
	{
		base.OnPointerEnter(eventData);
		if (colorLight.a != 0f)
		{
			base.transform.GetComponentInChildren<Text>().color = colorLight;
		}
		if (spriteLight != null)
		{
			base.transform.GetComponentInChildren<Image>().sprite = spriteLight;
		}
		if (useToggle)
		{
			base.transform.GetComponent<Toggle>().graphic.CrossFadeAlpha(1f, 0f, ignoreTimeScale: true);
		}
	}

	public override void OnPointerExit(PointerEventData eventData)
	{
		base.OnPointerExit(eventData);
		down = false;
		if (k == base.transform.GetSiblingIndex())
		{
			if (colorLight.a != 0f)
			{
				base.transform.GetComponentInChildren<Text>().color = colorLight;
			}
			if (spriteLight != null)
			{
				base.transform.GetComponent<Image>().sprite = spriteLight;
			}
		}
		else
		{
			if (colorNormal.a != 0f)
			{
				base.transform.GetComponentInChildren<Text>().color = colorNormal;
			}
			if (spriteNormal != null)
			{
				base.transform.GetComponent<Image>().sprite = spriteNormal;
			}
		}
		if (useToggle)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (!list[i].GetComponentInChildren<Toggle>().isOn)
				{
					list[i].GetComponent<Toggle>().graphic.CrossFadeAlpha(0f, 0f, ignoreTimeScale: true);
				}
			}
			return;
		}
		for (int j = 0; j < list.Count; j++)
		{
			if (spriteNormal != null && spriteLight != null && colorLight.a != 0f)
			{
				list[j].GetComponent<Image>().sprite = ((j == k) ? spriteLight : spriteNormal);
				list[j].transform.GetComponentInChildren<Text>().color = ((j == k) ? colorLight : colorNormal);
			}
		}
	}

	public void InitToggle()
	{
		k = base.transform.GetSiblingIndex();
		if (list.Count == 0)
		{
			list = new List<ToggleInteract>(base.transform.parent.GetComponentsInChildren<ToggleInteract>());
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (spriteNormal != null && spriteLight != null && colorLight.a != 0f)
			{
				if ((bool)list[i].GetComponentInChildren<Image>())
				{
					list[i].GetComponentInChildren<Image>().sprite = ((i == k) ? spriteLight : spriteNormal);
				}
				if ((bool)list[i].GetComponentInChildren<Text>())
				{
					list[i].GetComponentInChildren<Text>().color = ((i == k) ? colorLight : colorNormal);
				}
			}
		}
	}

	public override void OnPointerDown(PointerEventData eventData)
	{
		base.OnPointerDown(eventData);
		down = true;
		if (list.Count == 0)
		{
			list = new List<ToggleInteract>(base.transform.parent.GetComponentsInChildren<ToggleInteract>());
		}
		if (useToggle)
		{
			k = base.transform.GetSiblingIndex();
			return;
		}
		base.transform.GetComponent<Image>().sprite = spriteLight;
		base.transform.GetComponentInChildren<Text>().color = colorLight;
	}

	public override void OnPointerClick(PointerEventData eventData)
	{
		base.OnPointerClick(eventData);
		k = base.transform.GetSiblingIndex();
		for (int i = 0; i < list.Count; i++)
		{
			if (spriteNormal != null && spriteLight != null && colorLight.a != 0f)
			{
				list[i].GetComponent<Image>().sprite = ((i == k) ? spriteLight : spriteNormal);
				list[i].transform.GetComponentInChildren<Text>().color = ((i == k) ? colorLight : colorNormal);
			}
		}
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
		base.OnPointerUp(eventData);
		down = false;
		if (list.Count == 0)
		{
			list = new List<ToggleInteract>(base.transform.parent.GetComponentsInChildren<ToggleInteract>());
		}
		for (int i = 0; i < list.Count; i++)
		{
			if ((spriteNormal == null || spriteLight == null) && colorLight.a != 0f)
			{
				list[i].transform.GetComponentInChildren<Text>().color = ((i == k) ? colorLight : colorNormal);
			}
		}
	}

	private void Update()
	{
		if (!useToggle)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].GetComponentInChildren<Toggle>().isOn)
			{
				num = i;
				break;
			}
		}
		if (k == num)
		{
			return;
		}
		if (!down)
		{
			k = num;
		}
		for (int j = 0; j < list.Count; j++)
		{
			if (j == k || j == num)
			{
				list[j].transform.GetComponentInChildren<Text>().color = colorLight;
			}
			else
			{
				list[j].transform.GetComponentInChildren<Text>().color = colorNormal;
			}
		}
	}
}
public class Model_ContentData
{
	public string Content_Name;

	public string Content_ContentVideo;

	public string Content_ContentAudio;

	public string Content_BackgroundAudio;
}
public class Model_CourseData
{
	public string Course_ID;

	public string Course_Name;

	public string Course_Picture;

	public string Course_Count;

	public string Course_Duration;

	public string Course_CourseVideo;

	public string Course_CourseAudio;

	public string Course_BackgroundAudio;

	public string Course_IntroVideo;

	public string Course_SameCourse;
}
public class Model_SubCourseData
{
	public string SubCourse_ID;

	public string SubCourse_Name;

	public string SubCourse_Picture;

	public string SubCourse_Duration;

	public string SubCourse_Introduce;

	public string SubCourse_Pause;

	public string SubCourse_Finish;

	public string SubCourse_CourseVideo;

	public string SubCourse_CourseAudio;

	public string SubCourse_BackgroundAudio;
}
public class Model_PictureData
{
	public string Picture_ID;

	public string Picture_Name;

	public Texture2D Picture_Pic;

	public byte[] Picture_byte;
}
public class Model_MediaPlayer
{
	private Model_VideoPlayer myVideo;

	private Model_VideoPlayer myIntro;

	private Model_AudioPlayer myClassAudio;

	private Model_AudioPlayer myBackAudio;

	private ControlModel myModel;

	private float totalTime = 0f;

	private float currentTime = 0f;

	public Model_VideoPlayer GetMyVideo => myVideo;

	public float GetTotalTime
	{
		get
		{
			return totalTime;
		}
		set
		{
			totalTime = value;
		}
	}

	public float GetCurrentTime
	{
		get
		{
			return currentTime;
		}
		set
		{
			currentTime = value;
		}
	}

	public float BackgroundAudioVolume
	{
		get
		{
			return myBackAudio.AudioVolume;
		}
		set
		{
			myBackAudio.AudioVolume = value;
		}
	}

	public float CourseAudioVolume
	{
		get
		{
			if (myModel == ControlModel.byVideo)
			{
				return myVideo.VideoVolume;
			}
			return myClassAudio.AudioVolume;
		}
		set
		{
			if (myModel == ControlModel.byVideo)
			{
				myVideo.VideoVolume = value;
			}
			else
			{
				myClassAudio.AudioVolume = value;
			}
		}
	}

	public float GetClassTotalTime
	{
		get
		{
			float num = 0f;
			if (myModel == ControlModel.byVideo)
			{
				num = myVideo.GetVideoLength();
			}
			else if (myModel == ControlModel.byAudio)
			{
				num = myClassAudio.GetAudioLength();
			}
			else if (myModel == ControlModel.byTime)
			{
				num = totalTime;
			}
			if (num <= 0f)
			{
				num = 1f;
			}
			return (float)(int)(num * 100f) / 100f;
		}
	}

	public float GetClassCurrentTime
	{
		get
		{
			float num = 0f;
			if (myModel == ControlModel.byVideo)
			{
				num = myVideo.GetVideoCurrent();
			}
			else if (myModel == ControlModel.byAudio)
			{
				num = myClassAudio.GetAudioCurrent();
			}
			else if (myModel == ControlModel.byTime)
			{
				num = currentTime;
			}
			return (float)(int)(num * 100f) / 100f;
		}
	}

	public Model_MediaPlayer(VideoPlayer mediaPlayer, VideoPlayer introPlayer, AudioSource classAudio, AudioSource backAudio)
	{
		myVideo = new Model_VideoPlayer(mediaPlayer);
		myIntro = new Model_VideoPlayer(introPlayer);
		myClassAudio = new Model_AudioPlayer(classAudio);
		myBackAudio = new Model_AudioPlayer(backAudio);
	}

	public void PlayIntro()
	{
	}

	public void InitMedia(ControlModel myModel, float totalTime)
	{
		if (myModel == ControlModel.byTime)
		{
			this.totalTime = totalTime;
		}
		currentTime = 0f;
		this.myModel = myModel;
		myVideo.VideoLoop = false;
		myVideo.VideoVolume = 0.66f;
		myClassAudio.CloseAudio();
		myClassAudio.AudioLoop = myModel == ControlModel.byTime;
		myClassAudio.AudioMute = false;
		myClassAudio.AudioVolume = 0.66f;
		myBackAudio.CloseAudio();
		myBackAudio.AudioLoop = myModel == ControlModel.byTime;
		myBackAudio.AudioMute = false;
		myBackAudio.AudioVolume = 0.66f;
	}

	public void PlayMediaAsBackground(string videopath, AudioClip classpath)
	{
		myVideo.VideoLoop = true;
		myVideo.OpenVideo(videopath, autoplay: true);
		myBackAudio.AudioLoop = true;
		myBackAudio.OpenAudio(classpath, autoplay: true);
	}

	public void PlayMediaAsClass(string videopath, bool autoplay)
	{
		myVideo.VideoLoop = false;
		myVideo.OpenVideo(videopath, autoplay);
	}

	public void PlayMediaAsClass(string videopath, AudioClip backpath, bool autoplay)
	{
		myVideo.VideoLoop = true;
		myVideo.OpenVideo(videopath, autoplay);
		myBackAudio.AudioLoop = true;
		myBackAudio.OpenAudio(backpath, autoplay: false);
	}

	public void PlayMediaAsClass(string videopath, AudioClip classpath, AudioClip backpath, bool autoplay)
	{
		myVideo.VideoLoop = true;
		myVideo.OpenVideo(videopath, autoplay);
		myClassAudio.AudioLoop = myModel == ControlModel.byTime;
		myClassAudio.OpenAudio(classpath, autoplay: false);
		myBackAudio.AudioLoop = true;
		myBackAudio.OpenAudio(backpath, autoplay: false);
	}

	public void ChangeMedia(string videopath)
	{
		myVideo.VideoLoop = true;
		myVideo.OpenVideo(videopath, autoplay: false);
	}

	public void ChangeAudios(AudioClip classpath, AudioClip backpath)
	{
		myClassAudio.AudioLoop = true;
		myBackAudio.AudioLoop = true;
		myClassAudio.OpenAudio(classpath, autoplay: false);
		myBackAudio.OpenAudio(backpath, autoplay: false);
	}

	public bool CanPlay()
	{
		return myVideo.GetVideoPlayable;
	}

	public void PlayClass()
	{
		if (myVideo.GetVideoPlayable && !myVideo.GetMediaPlayer.isPlaying)
		{
			myVideo.PlayVideo();
		}
		if (myBackAudio.GetAudioPlayable)
		{
			myBackAudio.PlayAudio();
		}
		if (myClassAudio.GetAudioPlayable)
		{
			myClassAudio.PlayAudio();
		}
	}

	public void PauseOrUnpauseClass(bool pause)
	{
		if (pause)
		{
			myVideo.PauseVideo();
		}
		else
		{
			myVideo.UnpauseVideo();
		}
		if (myBackAudio.GetAudioPlayable)
		{
			if (pause)
			{
				myBackAudio.PauseAudio();
			}
			else
			{
				myBackAudio.UnpauseAudio();
			}
		}
		if (myClassAudio.GetAudioPlayable)
		{
			if (pause)
			{
				myClassAudio.PauseAudio();
			}
			else
			{
				myClassAudio.UnpauseAudio();
			}
		}
	}

	public void Restart()
	{
		myVideo.GetMediaPlayer.time = 0.0;
		PlayClass();
	}

	public void StopClass()
	{
		if (myVideo.GetVideoPlayable)
		{
			myVideo.PauseVideo();
		}
		if (myBackAudio.GetAudioPlayable)
		{
			myBackAudio.StopAudio();
		}
		if (myClassAudio.GetAudioPlayable)
		{
			myClassAudio.StopAudio();
		}
		if (myIntro.GetVideoPlayable)
		{
			myIntro.StopVideo();
		}
	}

	public void CloseClass()
	{
		if (myVideo.GetVideoPlayable)
		{
			myVideo.CloseVideo();
		}
		if (myBackAudio.GetAudioPlayable)
		{
			myBackAudio.CloseAudio();
		}
		if (myClassAudio.GetAudioPlayable)
		{
			myClassAudio.CloseAudio();
		}
		if (myIntro.GetVideoPlayable)
		{
			myIntro.CloseVideo();
		}
	}

	public float GetClassProgress()
	{
		return GetClassCurrentTime / GetClassTotalTime;
	}

	public void SetClassSeek(float value)
	{
		value = ((value < 0f) ? 0f : ((value > 1f) ? 1f : value));
		value = ((value > 0.98f) ? (value * GetClassTotalTime - 0.5f) : (value * GetClassTotalTime));
		if (myModel == ControlModel.byVideo)
		{
			myVideo.SetVideoSeek(value);
		}
		else if (myModel == ControlModel.byAudio)
		{
			myClassAudio.SetAudioSeek(value);
		}
		else if (myModel == ControlModel.byTime)
		{
			currentTime = value - 0.25f;
		}
	}
}
public class Model_VideoPlayer
{
	private VideoPlayer mediaPlayer;

	public VideoPlayer GetMediaPlayer => mediaPlayer;

	public bool VideoLoop
	{
		get
		{
			return mediaPlayer.isLooping;
		}
		set
		{
			mediaPlayer.isLooping = value;
		}
	}

	public float VideoVolume
	{
		get
		{
			return mediaPlayer.GetTargetAudioSource(0).volume;
		}
		set
		{
			mediaPlayer.GetTargetAudioSource(0).volume = value;
		}
	}

	public bool GetVideoPlayable => mediaPlayer != null && mediaPlayer.isPrepared;

	public Model_VideoPlayer(VideoPlayer mediaPlayer)
	{
		this.mediaPlayer = mediaPlayer;
	}

	public void OpenVideo(string videopath, bool autoplay)
	{
		if (Application.platform == RuntimePlatform.WindowsEditor)
		{
			videopath = "file://" + videopath;
		}
		mediaPlayer.url = videopath;
		mediaPlayer.Play();
	}

	public void CloseVideo()
	{
		mediaPlayer.Stop();
		mediaPlayer.url = null;
	}

	public void PlayVideo()
	{
		if (mediaPlayer.isPrepared && !mediaPlayer.isPlaying)
		{
			mediaPlayer.Play();
		}
	}

	public void PauseVideo()
	{
		mediaPlayer.Pause();
	}

	public void UnpauseVideo()
	{
		mediaPlayer.Play();
	}

	public void StopVideo()
	{
		mediaPlayer.Stop();
	}

	public void SetVideoSeek(float seconds)
	{
		seconds = ((seconds < 0f) ? 0f : ((seconds > GetVideoLength()) ? (GetVideoLength() - 0.2f) : seconds));
		mediaPlayer.time = seconds;
	}

	public float GetVideoCurrent()
	{
		return (float)mediaPlayer.time;
	}

	public float GetVideoLength()
	{
		return (float)mediaPlayer.length;
	}
}
public class Model_AudioPlayer
{
	private AudioSource audioSource;

	public bool AudioLoop
	{
		get
		{
			return audioSource.loop;
		}
		set
		{
			audioSource.loop = value;
		}
	}

	public bool AudioMute
	{
		get
		{
			return audioSource.mute;
		}
		set
		{
			audioSource.mute = value;
		}
	}

	public float AudioVolume
	{
		get
		{
			return audioSource.volume;
		}
		set
		{
			audioSource.volume = value;
		}
	}

	public bool GetAudioPlayable => audioSource.clip != null;

	public Model_AudioPlayer(AudioSource audioSource)
	{
		this.audioSource = audioSource;
	}

	public void OpenAudio(AudioClip clip, bool autoplay)
	{
		audioSource.clip = clip;
		if (autoplay)
		{
			audioSource.Play();
		}
		else
		{
			audioSource.Stop();
		}
	}

	public void CloseAudio()
	{
		audioSource.Stop();
		audioSource.clip = null;
	}

	public void PlayAudio()
	{
		audioSource.time = 0f;
		audioSource.Play();
	}

	public void PauseAudio()
	{
		audioSource.Pause();
	}

	public void UnpauseAudio()
	{
		audioSource.Play();
	}

	public void StopAudio()
	{
		audioSource.Stop();
	}

	public void SetAudioSeek(float seconds)
	{
		seconds -= 0.25f;
		if (audioSource.clip != null)
		{
			audioSource.time = ((seconds < 0f) ? 0f : ((seconds >= GetAudioLength() - 0.25f) ? GetAudioLength() : seconds));
		}
	}

	public float GetAudioCurrent()
	{
		return (audioSource.clip != null) ? audioSource.time : 0f;
	}

	public float GetAudioLength()
	{
		return (audioSource.clip != null) ? audioSource.clip.length : 1f;
	}
}
public class OnApplitionQuit : MonoBehaviour
{
	public void OnClickQuit()
	{
		Application.Quit();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T instance = null;

	private static readonly object locker = new object();

	public static T Instance
	{
		get
		{
			lock (locker)
			{
				if (instance == null)
				{
					instance = UnityEngine.Object.FindObjectOfType<T>();
					if (UnityEngine.Object.FindObjectsOfType<T>().Length > 1)
					{
						UnityEngine.Debug.LogError("不应该存在多个单例！");
						return instance;
					}
					if (instance == null)
					{
						GameObject gameObject = new GameObject();
						instance = gameObject.AddComponent<T>();
						gameObject.name = "(singleton)" + typeof(T);
						gameObject.hideFlags = HideFlags.None;
					}
				}
				instance.hideFlags = HideFlags.None;
				return instance;
			}
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
public class Singleton<T> where T : class, new()
{
	private static T instance = null;

	private static readonly object locker = new object();

	private static T Instance
	{
		get
		{
			lock (locker)
			{
				if (instance == null)
				{
					instance = new T();
				}
				return instance;
			}
		}
	}
}
public class Loom : MonoBehaviour
{
	public struct DelayedQueueItem
	{
		public float time;

		public Action action;
	}

	public static int maxThreads = 8;

	private static int numThreads;

	private static Loom _current;

	private static bool initialized;

	private List<Action> _actions = new List<Action>();

	private List<DelayedQueueItem> _delayed = new List<DelayedQueueItem>();

	private List<DelayedQueueItem> _currentDelayed = new List<DelayedQueueItem>();

	private List<Action> _currentActions = new List<Action>();

	public static Loom Current
	{
		get
		{
			Initialize();
			return _current;
		}
	}

	private void Awake()
	{
		_current = this;
		initialized = true;
	}

	public static void Initialize()
	{
		if (!initialized && Application.isPlaying)
		{
			initialized = true;
			GameObject gameObject = new GameObject("Loom");
			_current = gameObject.AddComponent<Loom>();
		}
	}

	public static void QueueOnMainThread(Action action)
	{
		QueueOnMainThread(action, 0f);
	}

	public static void QueueOnMainThread(Action action, float time)
	{
		if (time != 0f)
		{
			lock (Current._delayed)
			{
				Current._delayed.Add(new DelayedQueueItem
				{
					time = Time.time + time,
					action = action
				});
				return;
			}
		}
		lock (Current._actions)
		{
			Current._actions.Add(action);
		}
	}

	public static Thread RunAsync(Action a)
	{
		Initialize();
		while (numThreads >= maxThreads)
		{
			Thread.Sleep(1);
		}
		Interlocked.Increment(ref numThreads);
		ThreadPool.QueueUserWorkItem(RunAction, a);
		return null;
	}

	private static void RunAction(object action)
	{
		try
		{
			((Action)action)();
		}
		catch
		{
		}
		finally
		{
			Interlocked.Decrement(ref numThreads);
		}
	}

	private void OnDisable()
	{
		if (_current == this)
		{
			initialized = false;
			_current = null;
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
		lock (_actions)
		{
			_currentActions.Clear();
			_currentActions.AddRange(_actions);
			_actions.Clear();
		}
		foreach (Action currentAction in _currentActions)
		{
			currentAction();
		}
		lock (_delayed)
		{
			_currentDelayed.Clear();
			_currentDelayed.AddRange(_delayed.Where((DelayedQueueItem d) => d.time <= Time.time));
			foreach (DelayedQueueItem item in _currentDelayed)
			{
				_delayed.Remove(item);
			}
		}
		foreach (DelayedQueueItem item2 in _currentDelayed)
		{
			item2.action();
		}
	}
}
public class PageLayout : MonoBehaviour
{
	public delegate void RefreshData();

	private int mPageCount;

	private int mCurrentIndex;

	public int mItemCount;

	public int PerCount;

	private RefreshData mRefresh;

	public Text mPageText;

	public Button mNext;

	public Button mLast;

	public void Init(int _itemCount, RefreshData refresh)
	{
		mItemCount = _itemCount;
		PerCount = base.transform.childCount;
		mPageCount = ((mItemCount % PerCount == 0) ? (mItemCount / PerCount) : (mItemCount / PerCount + 1));
		mCurrentIndex = 0;
		mNext.onClick.RemoveAllListeners();
		mNext.onClick.AddListener(delegate
		{
			OnValueChange(1);
		});
		mLast.onClick.RemoveAllListeners();
		mLast.onClick.AddListener(delegate
		{
			OnValueChange(-1);
		});
		mCurrentIndex = 0;
		mRefresh = refresh;
		RefreshPage();
	}

	public int GetItemIndex(int idx)
	{
		return mCurrentIndex * PerCount + idx;
	}

	public int GetChildIdx(int itemIdx)
	{
		return itemIdx - mCurrentIndex * PerCount;
	}

	public void RefreshPage()
	{
		mPageText.text = $"{mCurrentIndex + 1}/{mPageCount}";
		mNext.gameObject.SetActive(value: false);
		mLast.gameObject.SetActive(value: false);
		if (mCurrentIndex > 0)
		{
			mLast.gameObject.SetActive(value: true);
		}
		if (mCurrentIndex < mPageCount - 1)
		{
			mNext.gameObject.SetActive(value: true);
		}
		if (mRefresh != null)
		{
			mRefresh();
		}
	}

	public void RefreshEndPage()
	{
		mCurrentIndex = mPageCount - 1;
		RefreshPage();
	}

	public void OnValueChange(int value)
	{
		mCurrentIndex = Mathf.Clamp(mCurrentIndex + value, 0, mPageCount - 1);
		RefreshPage();
	}
}
public class PublicTools
{
	private static System.Random _random = new System.Random((int)DateTime.Now.Ticks);

	public static int[] GetRandom(int count)
	{
		int[] array = new int[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = i;
		}
		int[] array2 = new int[count];
		int num = 0;
		List<int> list = new List<int>();
		for (int j = 1; j <= count; j++)
		{
			num = _random.Next(array.Length);
			if (!list.Contains(num))
			{
				array2[j - 1] = array[num];
				list.Add(num);
			}
			else
			{
				j--;
			}
		}
		return array2;
	}

	public int[] GetSort(int[] arr)
	{
		for (int i = 0; i < arr.Length - 1; i++)
		{
			for (int j = 0; j < arr.Length - 1 - i; j++)
			{
				if (arr[j] < arr[j + 1])
				{
					int num = arr[j];
					arr[j] = arr[j + 1];
					arr[j + 1] = num;
				}
			}
		}
		return arr;
	}

	public static string MainPath(string myDir)
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			return $"/storage/emulated/0/{myDir}";
		}
		if (Application.platform == RuntimePlatform.LinuxPlayer)
		{
			return $"/home/{Environment.UserName}/{myDir}";
		}
		return $"E://{myDir}";
	}

	public static string MainPath()
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			return "/storage/emulated/0/";
		}
		if (Application.platform == RuntimePlatform.LinuxPlayer)
		{
			return $"/home/{Environment.UserName}";
		}
		return "E://";
	}

	public static bool isExistFile(string path)
	{
		if (File.Exists(path))
		{
			return true;
		}
		return false;
	}

	public static List<string> GetFiles(string path, string imgtype)
	{
		List<string> list = new List<string>();
		string[] array = imgtype.Split('|');
		for (int i = 0; i < array.Length; i++)
		{
			string[] files = Directory.GetFiles(path, array[i]);
			for (int j = 0; j < files.Length; j++)
			{
				list.Add(files[j]);
			}
		}
		return list;
	}

	public static object[] GetRandomObject(object[] original)
	{
		object[] array = new object[original.Length];
		int[] random = GetRandom(array.Length);
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = original[random[i]];
		}
		return array;
	}

	public static string GetNowTime()
	{
		string text = null;
		return string.Format("<size=28>{0}:{1}</size>\n<size=16>{2}月{3}日 {4}</size>", (DateTime.Now.Hour < 10) ? ("0" + DateTime.Now.Hour) : DateTime.Now.Hour.ToString(), (DateTime.Now.Minute < 10) ? ("0" + DateTime.Now.Minute) : DateTime.Now.Minute.ToString(), DateTime.Now.Month, DateTime.Now.Day, GetWeekStr());
	}

	public static string Week()
	{
		string[] array = new string[7] { "周日", "周一", "周二", "周三", "周四", "周五", "周六" };
		return array[Convert.ToInt32(DateTime.Now.DayOfWeek)];
	}

	private static string GetWeekStr()
	{
		string text = DateTime.Now.DayOfWeek.ToString();
		switch (text)
		{
		case "Monday":
			text = "周一";
			break;
		case "Tuesday":
			text = "周二";
			break;
		case "Wednesday":
			text = "周三";
			break;
		case "Thursday":
			text = "周四";
			break;
		case "Friday":
			text = "周五";
			break;
		case "Saturday":
			text = "周六";
			break;
		case "Sunday":
			text = "周日";
			break;
		}
		return text;
	}
}
public class SqliteTools
{
	private string datapath;

	private SqliteConnection sqlconn;

	public SqliteTools(string datapath)
	{
		this.datapath = datapath;
		sqlconn = new SqliteConnection("Data Source=" + datapath);
	}

	public void ConnectDB()
	{
		sqlconn.Open();
	}

	public void DisConnectDB()
	{
		sqlconn.Close();
	}

	public List<Hashtable> ExcuteCoursesFromDB(string sqlcomm_str)
	{
		List<Hashtable> list = new List<Hashtable>();
		Hashtable hashtable = new Hashtable();
		SqliteCommand sqliteCommand = new SqliteCommand(sqlcomm_str, sqlconn);
		SqliteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
		while (sqliteDataReader.Read())
		{
			hashtable = new Hashtable();
			for (int i = 0; i < sqliteDataReader.FieldCount; i++)
			{
				hashtable.Add(sqliteDataReader.GetName(i), sqliteDataReader.GetValue(i));
			}
			list.Add(hashtable);
		}
		sqliteDataReader.Close();
		sqliteCommand.Dispose();
		return list;
	}
}
public class UMengAnalysis : MonoBehaviour
{
	private const string APP_KEY_Android = "61c54469e014255fcbc7ed47";

	private const string CHANNEL_Android = "Pico_Device";

	private static UMengAnalysis analysis = null;

	public static UMengAnalysis GetUMengAnalysis
	{
		get
		{
			if (analysis != null)
			{
				return analysis;
			}
			analysis = new GameObject().AddComponent<UMengAnalysis>();
			return analysis;
		}
	}

	private void Start()
	{
		if (analysis == null)
		{
			analysis = this;
		}
		Invoke("StartCallAnalysis", 2f);
	}

	private void StartCallAnalysis()
	{
		if (Application.platform != RuntimePlatform.WindowsEditor)
		{
			try
			{
				Analytics.StartWithAppKeyAndChannelId("61c54469e014255fcbc7ed47", "Pico_Device");
				return;
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.LogError(ex.Message);
				return;
			}
		}
		UnityEngine.Debug.Log("Analysis");
	}

	public void SendLearningCourseInfo(string courseID, string duration)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("courseID", courseID);
		dictionary.Add("duration", duration);
		UnityEngine.Debug.Log(courseID + ":::::" + duration);
		try
		{
			Analytics.Event("start_lenrning", dictionary);
		}
		catch
		{
		}
	}

	private void OnDestroy()
	{
	}
}
public class View_UI : MonoSingleton<View_UI>
{
	public Action<int> mainPanelCourseActionMedia;

	public Action startPlayCourse;

	public Action back2Main;

	public Action back2Course;

	public Action<Model_SubCourseData, float, string, string, ControlModel> course2SubCourse;

	public Action<Model_SubCourseData> changeVideoScene;

	public Action<float> changeCourseProgress;

	public Action<float> changeBackgroundVolume;

	public Action<float> changeCourseBackgroundVolume;

	public Action<float> changeCourseVolume;

	public Action endofCourse;

	public Action onClickRestart;

	public Action<bool> changeHandleShake;

	public Action<int> onChangeMainHand;

	private static Dictionary<string, GameObject> UIName_Obj = new Dictionary<string, GameObject>();

	private Text timeText;

	private Transform Gloub;

	private int ttime;

	[SerializeField]
	private Texture2D[] InsideTitles;

	[SerializeField]
	private Texture2D[] Titles;

	[SerializeField]
	private Texture2D[] SubTitles;

	[SerializeField]
	private Texture2D[] PauseTitle;

	[SerializeField]
	private Texture2D[] Med01;

	[SerializeField]
	private Texture2D[] Med02;

	private int coursecount;

	private Model_SubCourseData subcourse;

	private Model_CourseData course;

	private GameObject next;

	private bool moveNext = false;

	public bool LeftHandleInteractable
	{
		get
		{
			return GetUITransform("SettingsPanel/Right/Handle/Left").GetComponent<Button>().interactable;
		}
		set
		{
			GetUITransform("SettingsPanel/Right/Handle/Left").GetComponent<Button>().interactable = value;
		}
	}

	public bool RightHandleInteractable
	{
		get
		{
			return GetUITransform("SettingsPanel/Right/Handle/Right").GetComponent<Button>().interactable;
		}
		set
		{
			GetUITransform("SettingsPanel/Right/Handle/Right").GetComponent<Button>().interactable = value;
		}
	}

	public bool GetCantPlayable => GetUIActive("MainPanel") || GetUIActive("SubPanel") || GetUIActive("LoadPanel") || GetUIActive("GuidePanel") || GetUIActive("SettingsPanel") || GetUIActive("MaskPanel") || GetUIActive("ChangePanel") || GetUIActive("PlayerPanel/Next") || GetUIActive("PlayerPanel/Finish");

	public void RegisterUI()
	{
		UIName_Obj.Clear();
		UIName_Obj.Add("MainPanel", base.transform.Find("MainCanvas/MainPanel").gameObject);
		UIName_Obj.Add("SubPanel", base.transform.Find("MainCanvas/SubPanel").gameObject);
		UIName_Obj.Add("PlayerPanel", base.transform.Find("OtherCanvas/PlayerPanel").gameObject);
		UIName_Obj.Add("LoadPanel", base.transform.Find("OtherCanvas/LoadPanel").gameObject);
		UIName_Obj.Add("MaskPanel", base.transform.Find("OtherCanvas/MaskPanel").gameObject);
		UIName_Obj.Add("GuidePanel", base.transform.Find("OtherCanvas/GuidePanel").gameObject);
		UIName_Obj.Add("SettingsPanel", base.transform.Find("OtherCanvas/SettingsPanel").gameObject);
		UIName_Obj.Add("ChangePanel", base.transform.Find("OtherCanvas/ChangePanel").gameObject);
		SetUIActive("SubPanel", active: false);
		Gloub = base.transform.Find("MainCanvas/Gloub");
		timeText = Gloub.Find("Time/Text").GetComponent<Text>();
		Gloub.SetParent(GetUITransform("MainPanel"));
		RegisterMainPanel();
		RegisterSubPanel();
		RegisterPlayerPanel();
		RegisterGuidePanel();
		RegisterSettingsPanel();
		MonoSingleton<Controller_Loading>.Instance.StartOpening(delegate
		{
			SetUIActive("MaskPanel", active: true);
			SetUIActive("MainPanel", active: false);
		}, delegate
		{
			SetUIActive("LoadPanel/Open", active: true);
		}, delegate
		{
		}, "LoadPanel", delegate
		{
		}, delegate
		{
		}, delegate
		{
			SetUIActive("MaskPanel", active: false);
			SetUIActive("LoadPanel/Open", active: false);
			SetUIActive("LoadPanel", active: false);
		}, "MainPanel");
	}

	private void RegisterMainPanel()
	{
		Transform uITransform = GetUITransform("MainPanel/Middle");
		for (int j = 0; j < uITransform.childCount; j++)
		{
			int i = j;
			uITransform.GetChild(j).GetComponent<Button>().onClick.RemoveAllListeners();
			uITransform.GetChild(j).GetComponent<Button>().onClick.AddListener(delegate
			{
				OnClickMainPanelButton(i);
			});
		}
		GetUITransform("MainPanel/Bottom/Guide").GetComponent<Button>().onClick.AddListener(delegate
		{
			SetUIActive("MainPanel", active: false);
			SetUIActive("GuidePanel", active: true);
		});
		GetUITransform("MainPanel/Bottom/Settings").GetComponent<Button>().onClick.AddListener(delegate
		{
			SetUIActive("MainPanel", active: false);
			SetUIActive("SettingsPanel", active: true);
		});
	}

	private void RegisterSubPanel()
	{
		GetUITransform("SubPanel/Style2/Step1/Main").GetComponentInChildren<Button>().onClick.RemoveAllListeners();
		GetUITransform("SubPanel/Style2/Step1/Main").GetComponentInChildren<Button>().onClick.AddListener(delegate
		{
			OnClickBack2Main();
		});
		GetUITransform("SubPanel/Style2/Step2/Return").GetComponentInChildren<Button>().onClick.RemoveAllListeners();
		GetUITransform("SubPanel/Style2/Step2/Return").GetComponentInChildren<Button>().onClick.AddListener(delegate
		{
			SetUIActive("SubPanel/Style2/Step2", active: false);
			SetUIActive("SubPanel/Style2/Step1", active: true);
			GetUITransform("SubPanel/Style2/Text").GetComponent<Text>().text = "选择一个您喜欢的场景";
		});
		GetUITransform("SubPanel/Style1/Bottom/Main").GetComponentInChildren<Button>().onClick.RemoveAllListeners();
		GetUITransform("SubPanel/Style1/Bottom/Main").GetComponentInChildren<Button>().onClick.AddListener(delegate
		{
			OnClickBack2Main();
		});
		GetUITransform("SubPanel/Style1/Bottom/Intro").GetComponentInChildren<Button>().onClick.RemoveAllListeners();
		GetUITransform("SubPanel/Style1/Bottom/Intro").GetComponentInChildren<Button>().onClick.AddListener(delegate
		{
			if (GetUIActive("SubPanel/Introduce"))
			{
				SetUIActive("SubPanel/Introduce", active: false);
			}
			else
			{
				SetUIActive("SubPanel/Introduce", active: true);
				if (GetUIActive("SubPanel/Style1/Professor"))
				{
					SetUIActive("SubPanel/Introduce/Intro2", active: true);
					SetUIActive("SubPanel/Introduce/Intro1", active: false);
					SetUIActive("SubPanel/Introduce/Intro3", active: false);
				}
				else if (GetUITransform("SubPanel/Style1/Title").GetComponent<RawImage>().texture.name == "正面助眠标题")
				{
					SetUIActive("SubPanel/Introduce/Intro3", active: true);
					SetUIActive("SubPanel/Introduce/Intro1", active: false);
					SetUIActive("SubPanel/Introduce/Intro2", active: false);
				}
				else
				{
					SetUIActive("SubPanel/Introduce/Intro1", active: true);
					SetUIActive("SubPanel/Introduce/Intro2", active: false);
					SetUIActive("SubPanel/Introduce/Intro3", active: false);
				}
			}
		});
		GetUITransform("SubPanel/Introduce/Button").GetComponentInChildren<Button>().onClick.RemoveAllListeners();
		GetUITransform("SubPanel/Introduce/Button").GetComponentInChildren<Button>().onClick.AddListener(delegate
		{
			SetUIActive("SubPanel/Introduce", active: false);
			GetUITransform("SubPanel/Style1/Bottom/Intro").GetComponent<FunctionInteract>().isClick = false;
			GetUITransform("SubPanel/Style1/Bottom/Intro").GetComponent<FunctionInteract>().InitFunction();
		});
		SetSubUIAction();
	}

	private void RegisterPlayerPanel()
	{
		Controller_Interact controller_Interact = MonoSingleton<Controller_Interact>.Instance;
		controller_Interact.OnClickXY = (Action)Delegate.Combine(controller_Interact.OnClickXY, new Action(OnClickPauseActive));
		GetUITransform("PlayerPanel/Pause/Slider").GetComponent<Slider>().onValueChanged.RemoveAllListeners();
		GetUITransform("PlayerPanel/Pause/Slider").GetComponent<Slider>().onValueChanged.AddListener(delegate(float value)
		{
			changeCourseProgress(value);
		});
		GetUITransform("PlayerPanel/Finish/Confirm").GetComponent<Button>().onClick.RemoveAllListeners();
		GetUITransform("PlayerPanel/Finish/Confirm").GetComponent<Button>().onClick.AddListener(OnClickVideoBack);
		GetUITransform("PlayerPanel/Pause/Button").GetComponent<Button>().onClick.AddListener(delegate
		{
			MonoSingleton<Controller_Interact>.Instance.OnClickXY();
		});
		GetUITransform("PlayerPanel/Pause/BottomButton/Sound").GetComponent<Button>().onClick.AddListener(delegate
		{
			Transform uITransform4 = GetUITransform("PlayerPanel/Pause/BottomButton/Scene");
			uITransform4.GetComponent<FunctionInteract>().isClick = false;
			uITransform4.GetComponent<FunctionInteract>().InitFunction();
			SetUIActive("PlayerPanel/Sound", !GetUIActive("PlayerPanel/Sound"));
			SetUIActive("PlayerPanel/Scene", active: false);
		});
		GetUITransform("PlayerPanel/Pause/BottomButton/Scene").GetComponent<Button>().onClick.AddListener(delegate
		{
			Transform uITransform3 = GetUITransform("PlayerPanel/Pause/BottomButton/Sound");
			uITransform3.GetComponent<FunctionInteract>().isClick = false;
			uITransform3.GetComponent<FunctionInteract>().InitFunction();
			SetUIActive("PlayerPanel/Scene", !GetUIActive("PlayerPanel/Scene"));
			SetUIActive("PlayerPanel/Sound", active: false);
		});
		GetUITransform("PlayerPanel/Pause/BottomButton/Restart").GetComponent<Button>().onClick.AddListener(delegate
		{
			onClickRestart();
			SetUIActive("PlayerPanel", active: false);
		});
		GetUITransform("PlayerPanel/Pause/BottomButton/Return").GetComponent<Button>().onClick.AddListener(OnClickVideoBack);
		GetUITransform("PlayerPanel/Sound/Guide/Slider").GetComponent<Slider>().onValueChanged.AddListener(delegate(float value)
		{
			changeCourseBackgroundVolume(value);
		});
		GetUITransform("PlayerPanel/Sound/Sound/Slider").GetComponent<Slider>().onValueChanged.AddListener(delegate(float value)
		{
			changeCourseVolume(value);
		});
		GetUITransform("PlayerPanel/Sound/Button").GetComponent<Button>().onClick.AddListener(delegate
		{
			Transform uITransform2 = GetUITransform("PlayerPanel/Pause/BottomButton/Sound");
			uITransform2.GetComponent<FunctionInteract>().isClick = false;
			uITransform2.GetComponent<FunctionInteract>().InitFunction();
			SetUIActive("PlayerPanel/Sound", active: false);
		});
		GetUITransform("PlayerPanel/Scene/Button").GetComponent<Button>().onClick.AddListener(delegate
		{
			Transform uITransform = GetUITransform("PlayerPanel/Pause/BottomButton/Scene");
			uITransform.GetComponent<FunctionInteract>().isClick = false;
			uITransform.GetComponent<FunctionInteract>().InitFunction();
			SetUIActive("PlayerPanel/Scene", active: false);
		});
		GetUITransform("PlayerPanel/Next/Return").GetComponent<Button>().onClick.AddListener(delegate
		{
			StopAllCoroutines();
			OnClickVideoBack();
		});
	}

	private void RegisterGuidePanel()
	{
		Transform partparent = GetUITransform("GuidePanel/Right/PartParent");
		Transform uITransform = GetUITransform("GuidePanel/Left");
		for (int j = 0; j < uITransform.childCount; j++)
		{
			int i = j;
			uITransform.GetChild(j).GetComponent<Toggle>().onValueChanged.AddListener(delegate(bool b)
			{
				if (b)
				{
					for (int k = 0; k < partparent.childCount; k++)
					{
						partparent.GetChild(k).gameObject.SetActive(k == i);
					}
				}
			});
		}
		GetUITransform("GuidePanel/Right/Back").GetComponent<Button>().onClick.AddListener(delegate
		{
			SetUIActive("GuidePanel", active: false);
			SetUIActive("MainPanel", active: true);
		});
	}

	private void RegisterSettingsPanel()
	{
		GetUITransform("SettingsPanel/Left/Confirm").GetComponent<Button>().onClick.AddListener(delegate
		{
			SetUIActive("MainPanel", active: true);
			SetUIActive("SettingsPanel", active: false);
		});
		Transform uITransform = GetUITransform("SettingsPanel/Left/Toggle");
		Transform panelparent = GetUITransform("SettingsPanel/Right");
		for (int j = 0; j < uITransform.childCount; j++)
		{
			int i = j;
			uITransform.GetChild(j).GetComponentInChildren<Toggle>().onValueChanged.AddListener(delegate(bool b)
			{
				if (b)
				{
					for (int k = 0; k < panelparent.childCount; k++)
					{
						panelparent.GetChild(k).gameObject.SetActive(k == i);
					}
				}
			});
		}
		Text text1 = panelparent.Find("Sound/BackgroundVolume/Value").GetComponent<Text>();
		Text text2 = uITransform.Find("Sound/Toggle/Label").GetComponent<Text>();
		panelparent.Find("Sound/BackgroundVolume/Slider").GetComponent<Slider>().onValueChanged.AddListener(delegate(float value)
		{
			int num = (int)(value * 100f);
			text1.text = num.ToString();
			text2.text = num.ToString();
			changeBackgroundVolume?.Invoke(value);
		});
		panelparent.Find("Sound/BackgroundVolume/Slider").GetComponent<Slider>().value = MonoSingleton<Controller_Main>.Instance.mainbackgroundvolume;
		panelparent.Find("Sound/Shake/ShakeButton").GetComponent<Button>().onClick.AddListener(delegate
		{
			panelparent.Find("Sound/Shake/ShakeButton/Button").localPosition *= -1f;
			changeHandleShake(panelparent.Find("Sound/Shake/ShakeButton/Button").localPosition.x > 0f);
		});
		panelparent.Find("Sound/Shake/ShakeButton/Button").localPosition *= (float)(MonoSingleton<Controller_Interact>.Instance.handleShake ? 1 : (-1));
		panelparent.Find("Handle/Left").GetComponent<Button>().onClick.AddListener(delegate
		{
			onChangeMainHand(1);
		});
		panelparent.Find("Handle/Right").GetComponent<Button>().onClick.AddListener(delegate
		{
			onChangeMainHand(0);
		});
		onChangeMainHand = (Action<int>)Delegate.Combine(onChangeMainHand, new Action<int>(OnChangeMain));
	}

	private void OnChangeMain(int hand)
	{
		SetUIActive("SettingsPanel/Right/Handle/Left/Image", active: false);
		SetUIActive("SettingsPanel/Right/Handle/Right/Image", active: false);
		switch (hand)
		{
		case 0:
			SetUIActive("SettingsPanel/Right/Handle/Right/Image", active: true);
			break;
		case 1:
			SetUIActive("SettingsPanel/Right/Handle/Left/Image", active: true);
			break;
		}
	}

	private void OnClickVideoBack()
	{
		SetUIActive("PlayerPanel/Next", active: false);
		SetUIActive("PlayerPanel", active: false);
		if (coursecount == 0 || coursecount == 1)
		{
			OnClickBack2Main();
			return;
		}
		MonoSingleton<Controller_Loading>.Instance.StartBack(4, delegate
		{
			SetUIActive("MaskPanel", active: true);
		}, delegate
		{
			SetUIActive("SubPanel", active: true);
			if (coursecount == 4)
			{
				SetUIActive("SubPanel/Style2/Step1", active: true);
				SetUIActive("SubPanel/Style2/Step2", active: false);
				GetUITransform("SubPanel/Style2/Text").GetComponent<Text>().text = "选择一个您喜欢的场景";
			}
			back2Course();
		}, delegate
		{
			SetUIActive("MaskPanel", active: false);
		});
	}

	private void OnClickPauseActive()
	{
		if (GetCantPlayable)
		{
			return;
		}
		if (!GetUIActive("PlayerPanel"))
		{
			SetUIActive("PlayerPanel", active: true);
			SetUIActive("PlayerPanel/Pause", active: true);
			SetUIActive("PlayerPanel/Sound", active: false);
			SetUIActive("PlayerPanel/Scene", active: false);
			SetUIActive("PlayerPanel/Finish", active: false);
			Transform uITransform = GetUITransform("PlayerPanel/Pause/BottomButton");
			for (int i = 0; i < uITransform.childCount; i++)
			{
				uITransform.GetChild(i).GetComponent<FunctionInteract>().isClick = false;
				uITransform.GetChild(i).GetComponent<FunctionInteract>().InitFunction();
			}
		}
		else
		{
			SetUIActive("PlayerPanel", active: false);
		}
	}

	private void OnClickMainPanelButton(int k)
	{
		moveNext = false;
		coursecount = k;
		if (k == 6)
		{
			SceneAsyncLoad.Instance.LoadDiffScene(1);
			return;
		}
		MonoSingleton<Controller_Loading>.Instance.StartTurnPanel(2, delegate
		{
			SetUIActive("MaskPanel", active: true);
			if (k == 1 || k == 0)
			{
				SetUIActive("LoadPanel/Course", active: true);
				SetUIActive("LoadPanel/Content", active: false);
			}
			else
			{
				SetUIActive("LoadPanel/Course", active: false);
				SetUIActive("LoadPanel/Content", active: true);
			}
		}, delegate
		{
			if (k == 1 || k == 0)
			{
				SetUIActive("PlayerPanel/Pause/BottomButton/Scene", active: false);
				SetUIActive("PlayerPanel/Finish/Style1", active: true);
				SetUIActive("PlayerPanel/Finish/Style2", active: false);
				string key = ((k == 0) ? "str01" : "rel01");
				string subCourse_Name = MonoSingleton<Controller_Database>.Instance.GetSubCourseDatas[key][0].SubCourse_Name;
				GetUITransform("LoadPanel/Course/Title").GetComponent<Text>().text = ((k == 1) ? "深度放松" : "沉浸减压");
				GetUITransform("LoadPanel/Course/Intro").GetComponent<Text>().text = MonoSingleton<Controller_Database>.Instance.GetSubCourseDatas[key][0].SubCourse_Introduce.Replace("\\n", "\n");
				GetUITransform("PlayerPanel/Pause/Title").GetComponent<Text>().text = ((k == 1) ? "深度放松" : "沉浸减压");
				GetUITransform("PlayerPanel/Pause/SubTitle").GetComponent<Text>().text = MonoSingleton<Controller_Database>.Instance.GetSubCourseDatas[key][0].SubCourse_Pause;
				GetUITransform("PlayerPanel/Finish/Style1/RawImage").GetComponent<RawImage>().texture = PauseTitle[k];
				GetUITransform("PlayerPanel/Finish/Style1/Title").GetComponent<Text>().text = ((k == 1) ? "深度放松" : "沉浸减压");
				GetUITransform("PlayerPanel/Finish/Style1/Intro").GetComponent<Text>().text = MonoSingleton<Controller_Database>.Instance.GetSubCourseDatas[key][0].SubCourse_Finish;
			}
			else if (k == 5)
			{
				SetUIActive("PlayerPanel/Pause/BottomButton/Scene", active: true);
				SetUIActive("PlayerPanel/Finish/Style1", active: true);
				SetUIActive("PlayerPanel/Finish/Style2", active: false);
				GetUITransform("SubPanel/Style2/Text").GetComponent<Text>().text = "选择一个您喜欢的场景";
				GetUITransform("SubPanel/Style2/Title").GetComponent<RawImage>().texture = InsideTitles[2];
				GetUITransform("LoadPanel/Content").GetChild(0).GetComponent<RawImage>().texture = Titles[2];
				GetUITransform("LoadPanel/Content").GetChild(1).GetComponent<RawImage>().texture = SubTitles[2];
				string course_Name = MonoSingleton<Controller_Database>.Instance.GetCourseDatas["nature"][0].Course_Name;
				GetUITransform("PlayerPanel/Pause/Title").GetComponent<Text>().text = course_Name;
				GetUITransform("PlayerPanel/Finish/Style1/RawImage").GetComponent<RawImage>().texture = PauseTitle[4];
				GetUITransform("PlayerPanel/Finish/Style1/Title").GetComponent<Text>().text = course_Name;
				Gloub.SetParent(GetUITransform("SubPanel"));
				SetUIActive("SubPanel/Style1", active: false);
				SetUIActive("SubPanel/Style2", active: true);
				SetUIActive("SubPanel/Style2/Step2", active: false);
				SetUIActive("SubPanel/Style2/Step1", active: true);
			}
			else if (k == 4 || k == 2)
			{
				SetUIActive("PlayerPanel/Pause/BottomButton/Scene", active: false);
				SetUIActive("PlayerPanel/Finish/Style2", active: true);
				SetUIActive("PlayerPanel/Finish/Style1", active: false);
				GetUITransform("SubPanel/Style1/Title").GetComponent<RawImage>().texture = InsideTitles[(k - 2) / 2];
				GetUITransform("LoadPanel/Content").GetChild(0).GetComponent<RawImage>().texture = Titles[(k - 2) / 2];
				GetUITransform("LoadPanel/Content").GetChild(1).GetComponent<RawImage>().texture = SubTitles[(k - 2) / 2];
				string course_Name2 = MonoSingleton<Controller_Database>.Instance.GetCourseDatas["meditation"][Math.Abs((k - 2) / 2)].Course_Name;
				GetUITransform("PlayerPanel/Pause/Title").GetComponent<Text>().text = course_Name2;
				GetUITransform("PlayerPanel/Finish/Style2/RawImage").GetComponent<RawImage>().texture = PauseTitle[(k == 2) ? 2 : 3];
				GetUITransform("PlayerPanel/Finish/Style2/SubTitle").GetComponent<Text>().text = course_Name2;
				GetUITransform("PlayerPanel/Finish/Style2/Title").GetComponent<Text>().text = ((k == 2) ? "冥想减压" : "大师减压");
				Gloub.SetParent(GetUITransform("SubPanel"));
				SetUIActive("SubPanel/Style1", active: true);
				SetUIActive("SubPanel/Style2", active: false);
			}
			else if (k == 3)
			{
				SetUIActive("PlayerPanel/Pause/BottomButton/Scene", active: false);
				SetUIActive("PlayerPanel/Finish/Style2", active: true);
				SetUIActive("PlayerPanel/Finish/Style1", active: false);
				GetUITransform("SubPanel/Style1/Title").GetComponent<RawImage>().texture = InsideTitles[3];
				GetUITransform("LoadPanel/Content").GetChild(0).GetComponent<RawImage>().texture = Titles[3];
				GetUITransform("LoadPanel/Content").GetChild(1).GetComponent<RawImage>().texture = SubTitles[3];
				string course_Name3 = MonoSingleton<Controller_Database>.Instance.GetCourseDatas["sleep"][0].Course_Name;
				GetUITransform("PlayerPanel/Pause/Title").GetComponent<Text>().text = course_Name3;
				GetUITransform("PlayerPanel/Finish/Style2/RawImage").GetComponent<RawImage>().texture = PauseTitle[5];
				GetUITransform("PlayerPanel/Finish/Style2/SubTitle").GetComponent<Text>().text = course_Name3;
				Gloub.SetParent(GetUITransform("SubPanel"));
				SetUIActive("SubPanel/Style1", active: true);
				SetUIActive("SubPanel/Style2", active: false);
			}
			SetUIActive("MainPanel", active: false);
			mainPanelCourseActionMedia(coursecount);
		}, null, "LoadPanel", null, null, delegate
		{
			if (k == 0 || k == 1)
			{
				startPlayCourse();
			}
			SetUIActive("MaskPanel", active: false);
			SetUIActive("LoadPanel", active: false);
		}, (k == 0 || k == 1) ? null : "SubPanel");
	}

	private void OnClickBack2Main()
	{
		MonoSingleton<Controller_Loading>.Instance.StartBack(4, delegate
		{
			SetUIActive("MaskPanel", active: true);
		}, delegate
		{
			Gloub.SetParent(GetUITransform("MainPanel"));
			SetUIActive("MainPanel", active: true);
			SetUIActive("SubPanel", active: false);
			SetUIActive("SubPanel/Introduce", active: false);
			GetUITransform("SubPanel/Style1/Bottom/Intro").GetComponent<FunctionInteract>().isClick = false;
			GetUITransform("SubPanel/Style1/Bottom/Intro").GetComponent<FunctionInteract>().InitFunction();
			back2Main();
		}, delegate
		{
			SetUIActive("MaskPanel", active: false);
		});
	}

	private void SetSubUIAction()
	{
		endofCourse = delegate
		{
			if (moveNext)
			{
				SetUIActive("PlayerPanel", active: true);
				SetUIActive("PlayerPanel/Pause", active: false);
				SetUIActive("PlayerPanel/Sound", active: false);
				SetUIActive("PlayerPanel/Scene", active: false);
				SetUIActive("PlayerPanel/Finish", active: false);
				SetUIActive("PlayerPanel/Next", active: true);
				moveNext = false;
				StartCoroutine(Move2NextCourse());
			}
			else
			{
				SetUIActive("PlayerPanel", active: true);
				SetUIActive("PlayerPanel/Pause", active: false);
				SetUIActive("PlayerPanel/Sound", active: false);
				SetUIActive("PlayerPanel/Scene", active: false);
				SetUIActive("PlayerPanel/Finish", active: true);
				SetUIActive("PlayerPanel/Next", active: false);
			}
		};
	}

	private IEnumerator Move2NextCourse()
	{
		Transform parent = GetUITransform("PlayerPanel/Next/NextParent");
		for (int i = 0; i < parent.childCount; i++)
		{
			UnityEngine.Object.Destroy(parent.GetChild(i).gameObject);
		}
		GameObject game = UnityEngine.Object.Instantiate(next, parent);
		game.GetComponent<RectTransform>().anchorMax = Vector2.one * 0.5f;
		game.GetComponent<RectTransform>().anchorMin = Vector2.one * 0.5f;
		game.transform.localPosition = Vector3.zero;
		UnityEngine.Object.Destroy(game.GetComponentInChildren<Button>());
		UnityEngine.Object.Destroy(game.GetComponentInChildren<CourseInteract>());
		Text timeText = GetUITransform("PlayerPanel/Next/Text").GetComponent<Text>();
		timeText.text = "您将于 5 秒后进入下一个课程";
		float time = 5.4f;
		while (time > 0f)
		{
			time -= Time.deltaTime;
			timeText.text = $"您将于 {(int)time} 秒后进入下一个课程";
			yield return new WaitForEndOfFrame();
		}
		OnClickSubCourse(subcourse, 0f, course.Course_CourseVideo, course.Course_CourseAudio, ControlModel.byAudio, course.Course_ID);
	}

	public void SetSubCourseUI(Model_CourseData course, int courseindex)
	{
		List<Model_SubCourseData> list = MonoSingleton<Controller_Database>.Instance.GetSubCourseDatas[course.Course_ID];
		if (courseindex == 5)
		{
			Transform uITransform = GetUITransform("SubPanel/Style2/Step1");
			Transform uITransform2 = GetUITransform("PlayerPanel/Scene/Toggle");
			for (int j = 0; j < 10; j++)
			{
				if (j < list.Count)
				{
					Model_SubCourseData subdata = list[j];
					Texture2D picture_Pic = MonoSingleton<Controller_Database>.Instance.GetPictureDatas[subdata.SubCourse_Picture].Picture_Pic;
					uITransform2.GetChild(j).GetComponent<RawImage>().texture = picture_Pic;
					uITransform.GetChild(j).GetComponent<RawImage>().texture = picture_Pic;
					uITransform.GetChild(j).GetComponentInChildren<Text>().text = subdata.SubCourse_Name;
					uITransform2.GetChild(j).GetComponentInChildren<Text>().text = subdata.SubCourse_Name;
					uITransform.GetChild(j).GetComponent<Button>().onClick.RemoveAllListeners();
					uITransform.GetChild(j).GetComponent<Button>().onClick.AddListener(delegate
					{
						OnClickStep1(subdata, course);
					});
					uITransform2.GetChild(j).GetComponent<Button>().onClick.AddListener(delegate
					{
						OnClickChangeScene(subdata);
					});
					uITransform.GetChild(j).gameObject.SetActive(value: true);
					uITransform2.GetChild(j).gameObject.SetActive(value: true);
				}
				else
				{
					uITransform.GetChild(j).gameObject.SetActive(value: false);
					uITransform2.GetChild(j).gameObject.SetActive(value: false);
				}
			}
		}
		else if (courseindex == 2 || courseindex == 3)
		{
			Transform uITransform3 = GetUITransform("SubPanel/Style1/Toggle");
			SetUIActive("SubPanel/Style1/Professor", active: false);
			SetUIActive("SubPanel/Style1/Toggle", active: true);
			int num = (list.Count - 1) / 2 + 1;
			if (courseindex == 3)
			{
				num = (list.Count - 1) / 7 + 1;
			}
			for (int k = 0; k < uITransform3.childCount; k++)
			{
				if (k < num)
				{
					int i = k;
					if (courseindex == 2)
					{
						uITransform3.GetChild(k).GetComponentInChildren<Text>().text = string.Format("<size=25><b>第 {0} 周</b></size>\n<size=17>{1}</size>", i + 1, list[i * 2].SubCourse_Name.Replace("<b>", "").Replace("</b>", ""));
					}
					else
					{
						uITransform3.GetChild(k).GetComponentInChildren<Text>().text = ((i == 0) ? "<size=25><b>正念助眠</b></size>" : "<size=25><b>睡眠科学</b></size>");
					}
					uITransform3.GetChild(k).GetComponent<Button>().onClick.RemoveAllListeners();
					uITransform3.GetChild(k).GetComponent<Button>().onClick.AddListener(delegate
					{
						OnClickSubToggle(i, list, course, Med01, (courseindex == 2) ? 2 : 7);
					});
					uITransform3.GetChild(k).gameObject.SetActive(value: true);
				}
				else
				{
					uITransform3.GetChild(k).gameObject.SetActive(value: false);
				}
			}
			OnClickSubToggle(0, list, course, Med01, (courseindex == 2) ? 2 : 7);
			uITransform3.GetChild(0).GetComponent<ToggleInteract>().InitToggle();
		}
		else if (courseindex == 4)
		{
			SetUIActive("SubPanel/Style1/Professor", active: true);
			SetUIActive("SubPanel/Style1/Toggle", active: false);
			OnClickSubToggle(0, list, course, Med02);
		}
	}

	private void OnClickChangeScene(Model_SubCourseData subdata)
	{
		GetUITransform("LoadPanel/Course/Intro").GetComponent<Text>().text = subdata.SubCourse_Introduce.Replace("?", ttime.ToString()).Replace("\\n", "\n");
		GetUITransform("PlayerPanel/Pause/SubTitle").GetComponent<Text>().text = subdata.SubCourse_Pause.Replace("?", ttime.ToString());
		GetUITransform("PlayerPanel/Finish/Style1/Intro").GetComponent<Text>().text = subdata.SubCourse_Finish;
		changeVideoScene(subdata);
	}

	private void OnClickStep1(Model_SubCourseData data, Model_CourseData data1)
	{
		SetUIActive("SubPanel/Style2/Step2", active: true);
		SetUIActive("SubPanel/Style2/Step1", active: false);
		GetUITransform("SubPanel/Style2/Text").GetComponent<Text>().text = "选择您停留的时长";
		Transform uITransform = GetUITransform("SubPanel/Style2/Step2");
		for (int j = 0; j < 3; j++)
		{
			int i = j;
			uITransform.GetChild(j).GetComponent<Button>().onClick.RemoveAllListeners();
			uITransform.GetChild(j).GetComponent<Button>().onClick.AddListener(delegate
			{
				ttime = (i + 1) * 5;
				OnClickSubCourse(data, ttime * 60, data1.Course_CourseVideo, data1.Course_CourseAudio, ControlModel.byTime, data1.Course_ID);
			});
		}
	}

	private void OnClickSubToggle(int k, List<Model_SubCourseData> list, Model_CourseData data, Texture2D[] texes, int perCount = 7)
	{
		Transform parent = GetUITransform("SubPanel/Style1/Middle");
		for (int j = 0; j < parent.childCount; j++)
		{
			if (j < perCount && k * perCount + j < list.Count)
			{
				int i = j;
				Model_SubCourseData subdata = list[k * perCount + j];
				parent.GetChild(j).GetComponent<RawImage>().texture = MonoSingleton<Controller_Database>.Instance.GetPictureDatas[subdata.SubCourse_Picture].Picture_Pic;
				parent.GetChild(j).GetChild(0).GetComponent<RawImage>()
					.texture = texes[i];
				parent.GetChild(j).GetChild(1).GetComponent<Text>()
					.text = subdata.SubCourse_Name.Replace("\\n", "\n");
				parent.GetChild(j).GetChild(2).GetComponent<Text>()
					.text = subdata.SubCourse_Duration;
				parent.GetChild(j).GetComponent<Button>().onClick.RemoveAllListeners();
				parent.GetChild(j).GetComponent<Button>().onClick.AddListener(delegate
				{
					OnClickSubCourse(subdata, 0f, data.Course_CourseVideo, data.Course_CourseAudio, ControlModel.byAudio, data.Course_ID);
					if (data.Course_ID.Equals("med01") && i == 0)
					{
						moveNext = true;
						next = parent.GetChild(1).gameObject;
						course = data;
						subcourse = list[k * perCount + i + 1];
					}
					else
					{
						moveNext = false;
					}
				});
				parent.GetChild(j).gameObject.SetActive(value: true);
			}
			else
			{
				parent.GetChild(j).gameObject.SetActive(value: false);
			}
		}
	}

	private void OnClickSubCourse(Model_SubCourseData subdata, float time, string s1, string s2, ControlModel model, string coursename)
	{
		MonoSingleton<Controller_Loading>.Instance.StartTurnPanel(2, delegate
		{
			SetUIActive("MaskPanel", active: true);
			SetUIActive("LoadPanel/Course", active: true);
			SetUIActive("LoadPanel/Content", active: false);
		}, delegate
		{
			string text = "冥想创造生命内心的精彩";
			if (coursename.Equals("na01"))
			{
				text = "自然之旅";
			}
			else if (coursename.Equals("med01"))
			{
				text = "7天静心正念";
			}
			else if (coursename.Equals("med02"))
			{
				text = "冥想创造生命内心的精彩";
			}
			else if (coursename.Equals("sle01"))
			{
				text = "正念助眠";
			}
			SetUIActive("PlayerPanel/Next", active: false);
			SetUIActive("PlayerPanel", active: false);
			GetUITransform("LoadPanel/Course/Title").GetComponent<Text>().text = text;
			GetUITransform("LoadPanel/Course/Intro").GetComponent<Text>().text = subdata.SubCourse_Introduce.Replace("?", ((int)(time / 60f)).ToString()).Replace("\\n", "\n");
			if (coursename.Equals("na01"))
			{
				GetUITransform("PlayerPanel/Pause/SubTitle").GetComponent<Text>().text = subdata.SubCourse_Pause.Replace("?", ((int)(time / 60f)).ToString());
				GetUITransform("PlayerPanel/Finish/Style1/Intro").GetComponent<Text>().text = subdata.SubCourse_Finish;
			}
			else
			{
				if (subdata.SubCourse_CourseAudio.Contains("mindsleep"))
				{
					if (subdata.SubCourse_CourseAudio.Contains("mindsleep08") || subdata.SubCourse_CourseAudio.Contains("mindsleep09") || subdata.SubCourse_CourseAudio.Contains("mindsleep10"))
					{
						GetUITransform("PlayerPanel/Pause/Title").GetComponent<Text>().text = "睡眠科学";
						GetUITransform("PlayerPanel/Finish/Style2/SubTitle").GetComponent<Text>().text = "睡眠科学";
					}
					else
					{
						GetUITransform("PlayerPanel/Pause/Title").GetComponent<Text>().text = "正念助眠";
						GetUITransform("PlayerPanel/Finish/Style2/SubTitle").GetComponent<Text>().text = "正念助眠";
					}
				}
				GetUITransform("PlayerPanel/Finish/Style2/Intro").GetComponent<Text>().text = subdata.SubCourse_Finish;
				GetUITransform("PlayerPanel/Pause/SubTitle").GetComponent<Text>().text = subdata.SubCourse_Pause;
			}
			SetUIActive("SubPanel", active: false);
			course2SubCourse(subdata, time, s1, s2, model);
		}, null, "LoadPanel", null, null, delegate
		{
			SetUIActive("MaskPanel", active: false);
			SetUIActive("LoadPanel", active: false);
			startPlayCourse();
		}, null);
	}

	private void Update()
	{
		ShowTimeText();
	}

	private void ShowTimeText()
	{
		if (timeText != null)
		{
			string[] array = DateTime.Now.ToString("yyyy-MM-dd-HH-mm").Split('-');
			timeText.text = $"<size=40><b>{array[3]} : {array[4]}</b></size>\n<size=18>{array[1]}月{array[2]}日   {PublicTools.Week()}</size>";
		}
	}

	public Transform GetUITransform(string name)
	{
		string[] array = name.Split('/');
		try
		{
			if (array.Length <= 1)
			{
				return UIName_Obj[name].transform;
			}
			string n = name.Substring(array[0].Length + 1, name.Length - (array[0].Length + 1));
			return UIName_Obj[array[0]].transform.Find(n);
		}
		catch
		{
			UnityEngine.Debug.LogError(name);
			return null;
		}
	}

	public void SetUIActive(string name, bool active)
	{
		GetUITransform(name).gameObject.SetActive(active);
	}

	public bool GetUIActive(string name)
	{
		return GetUITransform(name).gameObject.activeInHierarchy;
	}

	public void SetUICommponentEnable<T>(string name, T t, bool enable) where T : Behaviour
	{
		GetUITransform(name).GetComponent<T>().enabled = enable;
	}
}
public class XR_BaseInput
{
	private XRController controller;

	public XRController GetController => controller;

	public XR_BaseInput(XRController controller)
	{
		this.controller = controller;
	}

	public bool GetPXR_KeyCodeInput(XR_KeyCodeClick key_code)
	{
		InputFeatureUsage<bool> usage = UnityEngine.XR.CommonUsages.triggerButton;
		switch (key_code)
		{
		case XR_KeyCodeClick.A:
		case XR_KeyCodeClick.X:
			usage = UnityEngine.XR.CommonUsages.primaryButton;
			break;
		case XR_KeyCodeClick.B:
		case XR_KeyCodeClick.Y:
			usage = UnityEngine.XR.CommonUsages.secondaryButton;
			break;
		case XR_KeyCodeClick.Trigger:
			usage = UnityEngine.XR.CommonUsages.triggerButton;
			break;
		case XR_KeyCodeClick.Grip:
			usage = UnityEngine.XR.CommonUsages.gripButton;
			break;
		case XR_KeyCodeClick.JoystickClick:
			usage = UnityEngine.XR.CommonUsages.primary2DAxisClick;
			break;
		case XR_KeyCodeClick.Menu:
			usage = UnityEngine.XR.CommonUsages.menuButton;
			break;
		}
		controller.inputDevice.TryGetFeatureValue(usage, out var value);
		return value;
	}

	public float GetPXR_KeyCodeInput(XR_KeyCodePressStrength key_code)
	{
		InputFeatureUsage<float> usage = UnityEngine.XR.CommonUsages.trigger;
		switch (key_code)
		{
		case XR_KeyCodePressStrength.Trigger:
			usage = UnityEngine.XR.CommonUsages.trigger;
			break;
		case XR_KeyCodePressStrength.Grip:
			usage = UnityEngine.XR.CommonUsages.grip;
			break;
		}
		controller.inputDevice.TryGetFeatureValue(usage, out var value);
		return value;
	}
}
public enum XR_KeyCodeClick
{
	A,
	B,
	X,
	Y,
	Menu,
	Trigger,
	Grip,
	JoystickClick
}
public enum XR_KeyCodePressStrength
{
	Trigger,
	Grip
}
public class BulletSystem : MonoBehaviour
{
	public static AudioClip hitCorrect;

	public static AudioClip hitIncorrect;

	public float bulletSpeed;

	public float bulletFlyCurrentTime;

	public float bulletFlyMaxTime;

	private bool canfly = false;

	public static int doubleHit = 0;

	public void InitBullet(float bulletSpeed, float bulletFlyMaxTime)
	{
		this.bulletSpeed = bulletSpeed;
		bulletFlyCurrentTime = 0f;
		this.bulletFlyMaxTime = bulletFlyMaxTime;
	}

	public void StartFly()
	{
		base.transform.GetChild(0).gameObject.SetActive(value: true);
		canfly = true;
	}

	public void StopFly()
	{
		canfly = false;
	}

	public void OnExplode()
	{
		canfly = false;
		StartCoroutine(ShowExplodeEffect());
	}

	private void FixedUpdate()
	{
		if (!canfly)
		{
			return;
		}
		float deltaTime = Time.deltaTime;
		if (bulletFlyCurrentTime > bulletFlyMaxTime)
		{
			OnExplode();
			return;
		}
		bulletFlyCurrentTime += deltaTime;
		base.transform.position += base.transform.up * deltaTime * bulletSpeed;
		Collider[] array = Physics.OverlapSphere(base.transform.position, 0.1f, ~(1 << LayerMask.NameToLayer("bullet")));
		if (array.Length == 0)
		{
			return;
		}
		Collider[] array2 = array;
		foreach (Collider collider in array2)
		{
			if (collider.gameObject.layer != LayerMask.NameToLayer("bullet") && collider.gameObject.layer != LayerMask.NameToLayer("UI"))
			{
				OnBulletHittedObject(collider);
			}
		}
	}

	private void OnBulletHittedObject(Collider col)
	{
		OnExplode();
		if (col.tag == "Enemy")
		{
			if (col.name == base.gameObject.name)
			{
				doubleHit++;
				MessageDispatch.GetInstance().DispatchEvent(new MessageTypes(MEventType.SCORE, new object[3]
				{
					col.transform.position,
					base.gameObject.name,
					doubleHit
				}));
				col.gameObject.SetActive(value: false);
				base.transform.GetChild(0).GetChild(0).GetComponent<AudioSource>()
					.clip = hitCorrect;
			}
			else if (col.name == "intermediateball" || col.name == "big")
			{
				if (col.transform.localScale.x > 1f)
				{
					col.transform.localScale -= Vector3.one * 0.2f;
					base.transform.GetChild(0).GetChild(0).GetComponent<AudioSource>()
						.clip = hitIncorrect;
				}
				else
				{
					MessageDispatch.GetInstance().DispatchEvent(new MessageTypes(MEventType.SCORE, new object[3]
					{
						col.transform.position,
						col.name,
						doubleHit
					}));
					col.gameObject.SetActive(value: false);
					col.transform.localScale = Vector3.one * 1.4f;
					base.transform.GetChild(0).GetChild(0).GetComponent<AudioSource>()
						.clip = hitCorrect;
				}
			}
			else if (col.name == "seniorball")
			{
				if (col.transform.localScale.x > 1f)
				{
					col.transform.localScale -= Vector3.one * 0.2f;
					base.transform.GetChild(0).GetChild(0).GetComponent<AudioSource>()
						.clip = hitIncorrect;
				}
				else
				{
					MessageDispatch.GetInstance().DispatchEvent(new MessageTypes(MEventType.SCORE, new object[3]
					{
						col.transform.position,
						col.name,
						doubleHit
					}));
					col.gameObject.SetActive(value: false);
					col.transform.localScale = Vector3.one * 1.8f;
					base.transform.GetChild(0).GetChild(0).GetComponent<AudioSource>()
						.clip = hitCorrect;
				}
			}
			else
			{
				base.transform.GetChild(0).GetChild(0).GetComponent<AudioSource>()
					.clip = hitIncorrect;
				doubleHit = 0;
			}
		}
		else
		{
			base.transform.GetChild(0).GetChild(0).GetComponent<AudioSource>()
				.clip = hitIncorrect;
		}
		if (base.transform.GetChild(0).GetChild(0).GetComponent<AudioSource>()
			.clip != null)
		{
			base.transform.GetChild(0).GetChild(0).GetComponent<AudioSource>()
				.Play();
		}
	}

	private IEnumerator ShowExplodeEffect()
	{
		base.transform.GetChild(0).GetChild(0).gameObject.SetActive(value: true);
		yield return new WaitForSeconds(2f);
		ParticleSystem[] particles = base.transform.GetComponentsInChildren<ParticleSystem>();
		ParticleSystem[] array = particles;
		foreach (ParticleSystem ps in array)
		{
			ps.Stop();
		}
		base.transform.GetChild(0).GetChild(0).gameObject.SetActive(value: false);
		base.transform.GetChild(0).gameObject.SetActive(value: false);
	}

	public void Reset()
	{
		AudioSource[] componentsInChildren = base.transform.GetComponentsInChildren<AudioSource>();
		AudioSource[] array = componentsInChildren;
		foreach (AudioSource audioSource in array)
		{
			audioSource.Stop();
		}
		ParticleSystem[] componentsInChildren2 = base.transform.GetComponentsInChildren<ParticleSystem>();
		ParticleSystem[] array2 = componentsInChildren2;
		foreach (ParticleSystem particleSystem in array2)
		{
			particleSystem.Stop();
		}
		base.transform.GetChild(0).GetChild(0).gameObject.SetActive(value: false);
		base.transform.GetChild(0).gameObject.SetActive(value: false);
	}
}
public class DrawCurvedPath : MonoBehaviour
{
	public List<CurvedDes> curveds = new List<CurvedDes>();

	public int densityCurve = 4000;

	public float radius = 1f;

	private void Awake()
	{
		StartLoomPos();
	}

	private void StartLoomPos()
	{
		List<List<Vector3>> allPos = new List<List<Vector3>>();
		for (int i = 0; i < base.transform.childCount; i++)
		{
			List<Vector3> list = new List<Vector3>();
			for (int j = 0; j < base.transform.GetChild(i).childCount; j++)
			{
				list.Add(base.transform.GetChild(i).GetChild(j).position);
			}
			allPos.Add(list);
		}
		List<List<Vector3>> newAllPos = new List<List<Vector3>>();
		List<List<float>> allRatio = new List<List<float>>();
		Loom.RunAsync(delegate
		{
			for (int k = 0; k < allPos.Count; k++)
			{
				List<float> list2 = new List<float>();
				List<Vector3> drawingPoints = GetDrawingPoints(allPos[k], densityCurve, list2);
				newAllPos.Add(drawingPoints);
				allRatio.Add(list2);
			}
			Loom.QueueOnMainThread(delegate
			{
				for (int l = 0; l < base.transform.childCount; l++)
				{
					curveds.Add(new CurvedDes());
					curveds[l].list_pos.Clear();
					curveds[l].list_ratio.Clear();
					curveds[l].list_control.Clear();
					for (int m = 0; m < base.transform.GetChild(l).childCount; m++)
					{
						curveds[l].list_control.Add(base.transform.GetChild(l).GetChild(m).gameObject);
					}
					curveds[l].list_pos = newAllPos[l];
					curveds[l].list_ratio = allRatio[l];
				}
			});
		});
	}

	public List<Vector3> GetDrawingPoints(List<Vector3> controlPoints, int segmentsPerCurve, List<float> dis)
	{
		List<Vector3> list = new List<Vector3>();
		float num = 0f;
		for (int i = 0; i < controlPoints.Count - 3; i += 3)
		{
			float num2 = 0f;
			Vector3 p = controlPoints[i];
			Vector3 p2 = controlPoints[i + 1];
			Vector3 p3 = controlPoints[i + 2];
			Vector3 p4 = controlPoints[i + 3];
			Vector3 vector = CalculateBezierPoint(0f, p, p2, p3, p4);
			list.Add(vector);
			for (int j = 0; j <= segmentsPerCurve; j++)
			{
				float t = (float)j / (float)segmentsPerCurve;
				Vector3 vector2 = CalculateBezierPoint(t, p, p2, p3, p4);
				list.Add(vector2);
				num2 += Vector3.Distance(vector, vector2);
				vector = vector2;
			}
			if (i == 0)
			{
				num = num2;
			}
			dis.Add((int)(num / num2 * 1000f));
		}
		return list;
	}

	private Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		Vector3 vector = (1f - t) * p0 + t * p1;
		Vector3 vector2 = (1f - t) * p1 + t * p2;
		Vector3 vector3 = (1f - t) * p2 + t * p3;
		Vector3 vector4 = (1f - t) * vector + t * vector2;
		Vector3 vector5 = (1f - t) * vector2 + t * vector3;
		return (1f - t) * vector4 + t * vector5;
	}
}
public class CurvedDes
{
	public List<GameObject> list_control = new List<GameObject>();

	public List<Vector3> list_pos = new List<Vector3>();

	public List<float> list_ratio = new List<float>();

	public List<GameObject> list_ball = new List<GameObject>();

	public List<int> list_index = new List<int>();
}
public class DrawStraightPath : MonoBehaviour
{
	public List<StraightDes> straightDes = new List<StraightDes>();

	private void Awake()
	{
		for (int i = 0; i < base.transform.childCount; i++)
		{
			straightDes.Add(new StraightDes());
			straightDes[i].originPos = base.transform.GetChild(i).GetChild(0).position;
			straightDes[i].targetPos = base.transform.GetChild(i).GetChild(1).position;
		}
	}
}
public class StraightDes
{
	public Vector3 originPos = default(Vector3);

	public Vector3 targetPos = default(Vector3);

	public List<GameObject> list_ball = new List<GameObject>();
}
public struct EnemyConfig
{
	public GameObject enemy;

	public int durable;
}
public class EnemySystem : MonoBehaviour
{
	[SerializeField]
	private DrawCurvedPath drawCurved;

	[SerializeField]
	private DrawStraightPath drawStraightPath;

	[Range(1f, 10f)]
	[SerializeField]
	private float k;

	private System.Random random = new System.Random((int)DateTime.Now.Ticks);

	private List<EnemyConfig> enemyConfigs = new List<EnemyConfig>();

	private GameObject[] enemyPrefabs;

	private int[] enemyColorIndex;

	[SerializeField]
	private float rotateSpeed;

	private Transform enemyParent;

	private Material[] enemyMaterials;

	private int count = 0;

	private int c = 0;

	[SerializeField]
	private float curvedMoveSpeed = 1f;

	[SerializeField]
	private float straightMoveSpeed = 1f;

	public GameObject[] SetEnemyPrefab
	{
		set
		{
			enemyPrefabs = value;
		}
	}

	public Transform SetEnemyParent
	{
		set
		{
			enemyParent = value;
		}
	}

	public Material[] SetEnemyMaterials
	{
		set
		{
			enemyMaterials = value;
		}
	}

	public void InitEnemy()
	{
		enemyConfigs.Clear();
	}

	public void InitStaticEnemy_Level12(int countnormal, float intermediate)
	{
		List<Vector2> list = new List<Vector2>();
		float num = 1.5f;
		if (countnormal % 10 == 9)
		{
			int num2 = (countnormal + 6) / 5;
			int num3 = 5;
			int num4 = num2;
			for (int i = 0; i < (num3 - 1) / 2 + 1; i++)
			{
				for (int j = 0; j < (num4 - 1) / 2 + 1; j++)
				{
					if (i % 2 == 0)
					{
						if (j == 0)
						{
							list.Add(new Vector2(j, i) * num);
							if (i != 0)
							{
								list.Add(new Vector2(j, -i) * num);
							}
							continue;
						}
						list.Add(new Vector2(j, i) * num);
						list.Add(new Vector2(-j, i) * num);
						if (i != 0)
						{
							list.Add(new Vector2(j, -i) * num);
							list.Add(new Vector2(-j, -i) * num);
						}
					}
					else
					{
						list.Add(new Vector2((float)j + 0.5f, i) * num);
						list.Add(new Vector2((float)(-j) - 0.5f, i) * num);
						list.Add(new Vector2((float)j + 0.5f, -i) * num);
						list.Add(new Vector2((float)(-j) - 0.5f, -i) * num);
					}
				}
				num4--;
			}
		}
		else
		{
			int num5 = (countnormal + 2) / 4;
			int num6 = 4;
			int num7 = num5;
			for (int k = 0; k < (num6 - 1) / 2 + 1; k++)
			{
				for (int l = 0; l < (num7 - 1) / 2 + 1; l++)
				{
					if (k % 2 == 0)
					{
						list.Add(new Vector2((float)l + 0.5f, (float)k + 0.5f) * num);
						list.Add(new Vector2((float)(-l) - 0.5f, (float)k + 0.5f) * num);
						list.Add(new Vector2((float)l + 0.5f, (float)(-k) - 0.5f) * num);
						list.Add(new Vector2((float)(-l) - 0.5f, (float)(-k) - 0.5f) * num);
					}
					else if (l == 0)
					{
						list.Add(new Vector2(l, (float)k + 0.5f) * num);
						list.Add(new Vector2(l, (float)(-k) - 0.5f) * num);
					}
					else
					{
						list.Add(new Vector2(l, (float)k + 0.5f) * num);
						list.Add(new Vector2(-l, (float)k + 0.5f) * num);
						list.Add(new Vector2(l, (float)(-k) - 0.5f) * num);
						list.Add(new Vector2(-l, (float)(-k) - 0.5f) * num);
					}
				}
				num7--;
			}
		}
		enemyColorIndex = GetRandomColorIndex(enemyMaterials.Length, countnormal);
		GameSystem.enemyIndex = new List<int>();
		for (int m = 0; m < countnormal; m++)
		{
			GameObject objectFromPool;
			if ((float)random.Next(0, 100) < intermediate)
			{
				objectFromPool = PoolSystem.GetObjectFromPool(ObjectType.intermediateball, enemyPrefabs[1], enemyParent);
				objectFromPool.name = "intermediateball";
				GameSystem.enemyIndex.Add(4);
			}
			else
			{
				GameSystem.enemyIndex.Add(enemyColorIndex[m]);
				objectFromPool = PoolSystem.GetObjectFromPool(ObjectType.normalball, enemyPrefabs[0], enemyParent);
				objectFromPool.name = enemyColorIndex[m].ToString();
				objectFromPool.transform.GetChild(0).GetChild(0).GetComponent<Renderer>()
					.material = enemyMaterials[enemyColorIndex[m]];
			}
			objectFromPool.transform.GetChild(0).localPosition = Vector3.zero;
			objectFromPool.transform.GetChild(0).localRotation = Quaternion.identity;
			objectFromPool.transform.localRotation = Quaternion.identity;
			objectFromPool.transform.localPosition = list[m];
			objectFromPool.transform.GetChild(0).GetChild(0).RotateAround(objectFromPool.transform.GetChild(0).GetChild(0).position, Vector3.up, random.Next(360));
			objectFromPool.SetActive(value: true);
		}
	}

	public void InitDynamicEnemy_Level34(int countnormal, float intermediate, int senior, float interal)
	{
		c = 1;
		enemyColorIndex = GetRandomColorIndex(enemyMaterials.Length, countnormal);
		GameSystem.enemyIndex = new List<int>();
		List<GameObject> list = new List<GameObject>();
		for (int i = 0; i < countnormal; i++)
		{
			GameObject objectFromPool;
			if ((float)random.Next(0, 100) < intermediate)
			{
				objectFromPool = PoolSystem.GetObjectFromPool(ObjectType.intermediateball, enemyPrefabs[1], enemyParent);
				objectFromPool.name = "intermediateball";
				GameSystem.enemyIndex.Add(4);
			}
			else
			{
				GameSystem.enemyIndex.Add(enemyColorIndex[i]);
				objectFromPool = PoolSystem.GetObjectFromPool(ObjectType.normalball, enemyPrefabs[0], enemyParent);
				objectFromPool.name = enemyColorIndex[i].ToString();
				objectFromPool.transform.GetChild(0).GetChild(0).GetComponent<Renderer>()
					.material = enemyMaterials[enemyColorIndex[i]];
			}
			objectFromPool.transform.GetChild(0).localPosition = Vector3.zero;
			objectFromPool.transform.GetChild(0).localRotation = Quaternion.identity;
			objectFromPool.transform.localRotation = Quaternion.identity;
			list.Add(objectFromPool);
			objectFromPool.SetActive(value: true);
		}
		foreach (GameObject item in list)
		{
			item.SetActive(value: false);
		}
		StartCoroutine(StartCurvedMove(list, interal));
		StartCoroutine(SingleCurvedMove());
	}

	private IEnumerator StartCurvedMove(List<GameObject> games, float interal)
	{
		count = games.Count;
		drawCurved.curveds[0].list_ball = new List<GameObject>();
		drawCurved.curveds[0].list_index = new List<int>();
		drawCurved.curveds[1].list_index = new List<int>();
		drawCurved.curveds[1].list_ball = new List<GameObject>();
		k = 3f;
		StartCoroutine(MoveSpeedControllor());
		int i = 0;
		while (i < games.Count)
		{
			yield return new WaitForEndOfFrame();
			if (Time.timeScale != 0f)
			{
				if (i % 2 == 0)
				{
					drawCurved.curveds[0].list_ball.Add(games[i]);
					drawCurved.curveds[0].list_index.Add(0);
					games[i].transform.position = drawCurved.curveds[0].list_pos[0];
				}
				else
				{
					drawCurved.curveds[1].list_ball.Add(games[i]);
					drawCurved.curveds[1].list_index.Add(0);
					games[i].transform.position = drawCurved.curveds[1].list_pos[0];
				}
				games[i].SetActive(value: true);
				EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/TimeText/Text").GetComponent<Text>().text = $"剩余数 {games.Count - i + 1}";
				while (Vector3.Distance(games[i].transform.position, drawCurved.curveds[i % 2].list_pos[0]) < interal)
				{
					yield return null;
				}
				i++;
			}
		}
	}

	private IEnumerator MoveSpeedControllor()
	{
		while (true)
		{
			yield return new WaitForEndOfFrame();
			if (Time.timeScale == 0f)
			{
				continue;
			}
			int count = 0;
			int gocount = 0;
			if (c == 1)
			{
				foreach (GameObject go2 in drawCurved.curveds[0].list_ball)
				{
					if (go2 != null && go2.activeInHierarchy)
					{
						gocount++;
					}
					count++;
				}
				foreach (GameObject go in drawCurved.curveds[1].list_ball)
				{
					if (go != null && go.activeInHierarchy)
					{
						gocount++;
					}
					count++;
				}
			}
			else if (c == 2)
			{
				foreach (GameObject go5 in drawStraightPath.straightDes[0].list_ball)
				{
					if (go5 != null && go5.activeInHierarchy)
					{
						gocount++;
					}
					count++;
				}
				foreach (GameObject go4 in drawStraightPath.straightDes[1].list_ball)
				{
					if (go4 != null && go4.activeInHierarchy)
					{
						gocount++;
					}
					count++;
				}
				foreach (GameObject go3 in drawStraightPath.straightDes[2].list_ball)
				{
					if (go3 != null && go3.activeInHierarchy)
					{
						gocount++;
					}
					count++;
				}
			}
			if (count < this.count)
			{
				if (gocount < 2 && k < 3f)
				{
					k += Time.deltaTime;
				}
				else if (k > 1f && gocount > 4)
				{
					k -= Time.deltaTime;
				}
				else if (k <= 1f)
				{
					k = 1f;
				}
			}
			else if (k > 1f)
			{
				k -= Time.deltaTime;
			}
			else
			{
				k = 1f;
			}
		}
	}

	private IEnumerator SingleCurvedMove()
	{
		while (true)
		{
			yield return new WaitForEndOfFrame();
			if (Time.timeScale == 0f)
			{
				continue;
			}
			for (int i = 0; i < drawCurved.curveds.Count; i++)
			{
				for (int j = 0; j < drawCurved.curveds[i].list_ball.Count; j++)
				{
					if (drawCurved.curveds[i].list_ball[j] == null)
					{
						continue;
					}
					int count = ((drawCurved.curveds[i].list_index[j] / drawCurved.densityCurve < drawCurved.curveds[i].list_ratio.Count) ? (drawCurved.curveds[i].list_index[j] / drawCurved.densityCurve) : (drawCurved.curveds[i].list_ratio.Count - 1));
					int newSpeed = (int)(curvedMoveSpeed * drawCurved.curveds[i].list_ratio[count] / 1000f * k);
					drawCurved.curveds[i].list_index[j] += newSpeed;
					if (drawCurved.curveds[i].list_index[j] >= drawCurved.curveds[i].list_pos.Count)
					{
						if (drawCurved.curveds[i].list_ball[j].name == "intermediateball")
						{
							GameSystem.enemyIndex.Remove(4);
						}
						else
						{
							GameSystem.enemyIndex.Remove(int.Parse(drawCurved.curveds[i].list_ball[j].name));
						}
						drawCurved.curveds[i].list_ball[j].SetActive(value: false);
						drawCurved.curveds[i].list_ball[j] = null;
						continue;
					}
					Vector3 secondPos = drawCurved.curveds[i].list_pos[drawCurved.curveds[i].list_index[j]];
					Vector3 firstPos = drawCurved.curveds[i].list_pos[drawCurved.curveds[i].list_index[j] - newSpeed];
					float radian = ((secondPos.x == firstPos.x) ? 1.57f : Mathf.Atan((secondPos.y - firstPos.y) / (secondPos.x - firstPos.x)));
					float angle2 = radian * 180f / 3.14f;
					if (angle2 > 0f)
					{
						angle2 = 180f - angle2;
					}
					angle2 = Mathf.Abs(angle2);
					drawCurved.curveds[i].list_ball[j].transform.GetChild(0).localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f - angle2));
					if (i == 0)
					{
						drawCurved.curveds[i].list_ball[j].transform.GetChild(0).GetChild(0).Rotate(Vector3.down * rotateSpeed * k, Space.Self);
					}
					else
					{
						drawCurved.curveds[i].list_ball[j].transform.GetChild(0).GetChild(0).Rotate(Vector3.down * rotateSpeed * k, Space.Self);
					}
					drawCurved.curveds[i].list_ball[j].transform.position = secondPos;
				}
			}
			if (GameSystem.enemyIndex.Count == 0)
			{
				FinishWave();
			}
		}
	}

	private void FinishWave()
	{
		StopAllCoroutines();
		UnityEngine.Object.FindObjectOfType<GameSystem>().FinishGame();
	}

	private IEnumerator ShowSeniorBall()
	{
		yield break;
	}

	public void InitDynamicEnemy_Level56(int countnormal, float intermediate, int senior, float interal)
	{
		c = 2;
		enemyColorIndex = GetRandomColorIndex(enemyMaterials.Length, countnormal);
		GameSystem.enemyIndex = new List<int>();
		List<GameObject> list = new List<GameObject>();
		for (int i = 0; i < countnormal; i++)
		{
			GameObject objectFromPool;
			if ((float)random.Next(0, 100) < intermediate)
			{
				objectFromPool = PoolSystem.GetObjectFromPool(ObjectType.intermediateball, enemyPrefabs[1], enemyParent);
				objectFromPool.name = "intermediateball";
				GameSystem.enemyIndex.Add(4);
			}
			else
			{
				GameSystem.enemyIndex.Add(enemyColorIndex[i]);
				objectFromPool = PoolSystem.GetObjectFromPool(ObjectType.normalball, enemyPrefabs[0], enemyParent);
				objectFromPool.name = enemyColorIndex[i].ToString();
				objectFromPool.transform.GetChild(0).GetChild(0).GetComponent<Renderer>()
					.material = enemyMaterials[enemyColorIndex[i]];
			}
			objectFromPool.transform.GetChild(0).localPosition = Vector3.zero;
			objectFromPool.transform.GetChild(0).localRotation = Quaternion.identity;
			objectFromPool.transform.localRotation = Quaternion.identity;
			list.Add(objectFromPool);
			objectFromPool.SetActive(value: true);
		}
		foreach (GameObject item in list)
		{
			item.SetActive(value: false);
		}
		StartCoroutine(StartStraightMove(list, interal));
		StartCoroutine(SingleStraightMove());
	}

	private IEnumerator StartStraightMove(List<GameObject> games, float interal)
	{
		count = games.Count;
		drawStraightPath.straightDes[0].list_ball = new List<GameObject>();
		drawStraightPath.straightDes[1].list_ball = new List<GameObject>();
		drawStraightPath.straightDes[2].list_ball = new List<GameObject>();
		k = 3f;
		StartCoroutine(MoveSpeedControllor());
		int i = 0;
		while (i < games.Count)
		{
			yield return new WaitForEndOfFrame();
			if (Time.timeScale != 0f)
			{
				if (i % 3 == 0)
				{
					drawStraightPath.straightDes[0].list_ball.Add(games[i]);
					games[i].transform.position = drawStraightPath.straightDes[0].originPos;
				}
				else if (i % 3 == 1)
				{
					drawStraightPath.straightDes[1].list_ball.Add(games[i]);
					games[i].transform.position = drawStraightPath.straightDes[1].originPos;
				}
				else
				{
					drawStraightPath.straightDes[2].list_ball.Add(games[i]);
					games[i].transform.position = drawStraightPath.straightDes[2].originPos;
				}
				games[i].SetActive(value: true);
				EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/TimeText/Text").GetComponent<Text>().text = $"剩余数 {games.Count - i + 1}";
				while (Vector3.Distance(games[i].transform.position, drawStraightPath.straightDes[i % 3].originPos) < interal)
				{
					yield return null;
				}
				i++;
			}
		}
	}

	private IEnumerator SingleStraightMove()
	{
		while (true)
		{
			yield return new WaitForEndOfFrame();
			float delT = Time.deltaTime;
			if (Time.timeScale == 0f)
			{
				continue;
			}
			for (int i = 0; i < drawStraightPath.straightDes.Count; i++)
			{
				for (int j = 0; j < drawStraightPath.straightDes[i].list_ball.Count; j++)
				{
					if (drawStraightPath.straightDes[i].list_ball[j] == null)
					{
						continue;
					}
					if (Vector3.Distance(drawStraightPath.straightDes[i].list_ball[j].transform.position, drawStraightPath.straightDes[i].targetPos) < 0.05f)
					{
						if (drawStraightPath.straightDes[i].list_ball[j].name == "intermediateball")
						{
							GameSystem.enemyIndex.Remove(4);
						}
						else
						{
							GameSystem.enemyIndex.Remove(int.Parse(drawStraightPath.straightDes[i].list_ball[j].name));
						}
						drawStraightPath.straightDes[i].list_ball[j].SetActive(value: false);
						drawStraightPath.straightDes[i].list_ball[j] = null;
					}
					else
					{
						if (i == 1)
						{
							drawStraightPath.straightDes[i].list_ball[j].transform.GetChild(0).GetChild(0).Rotate(-Vector3.up * rotateSpeed * k, Space.Self);
						}
						else
						{
							drawStraightPath.straightDes[i].list_ball[j].transform.GetChild(0).GetChild(0).Rotate(Vector3.up * rotateSpeed * k, Space.Self);
						}
						Vector3 Direction = drawStraightPath.straightDes[i].targetPos - drawStraightPath.straightDes[i].originPos;
						drawStraightPath.straightDes[i].list_ball[j].transform.position += delT * Direction * straightMoveSpeed * k;
					}
				}
			}
			if (GameSystem.enemyIndex.Count == 0)
			{
				FinishWave();
			}
		}
	}

	public void InitStaticEnemy_Level7(int countnormal)
	{
		List<Vector2> list = new List<Vector2>();
		float num = 1.5f;
		int num2 = 4;
		int num3 = 4;
		int num4 = num2;
		for (int i = 0; i < (num3 - 1) / 2 + 1; i++)
		{
			for (int j = 0; j < (num4 - 1) / 2 + 1; j++)
			{
				if (i % 2 == 0)
				{
					list.Add(new Vector2((float)j + 0.5f, (float)i + 0.5f) * num);
					list.Add(new Vector2((float)(-j) - 0.5f, (float)i + 0.5f) * num);
					list.Add(new Vector2((float)j + 0.5f, (float)(-i) - 0.5f) * num);
					list.Add(new Vector2((float)(-j) - 0.5f, (float)(-i) - 0.5f) * num);
				}
				else if (j == 0)
				{
					list.Add(new Vector2(j, (float)i + 0.5f) * num);
					list.Add(new Vector2(j, (float)(-i) - 0.5f) * num);
				}
				else
				{
					list.Add(new Vector2(j, (float)i + 0.5f) * num);
					list.Add(new Vector2(-j, (float)i + 0.5f) * num);
					list.Add(new Vector2(j, (float)(-i) - 0.5f) * num);
					list.Add(new Vector2(-j, (float)(-i) - 0.5f) * num);
				}
			}
			num4--;
		}
		enemyColorIndex = GetRandomColorIndex(enemyMaterials.Length, countnormal);
		int[] array = RandomCount(countnormal, list.Count);
		GameSystem.enemyIndex = new List<int>();
		for (int k = 0; k < countnormal; k++)
		{
			GameSystem.enemyIndex.Add(enemyColorIndex[k]);
			GameObject objectFromPool = PoolSystem.GetObjectFromPool(ObjectType.normalball, enemyPrefabs[0], enemyParent);
			objectFromPool.name = enemyColorIndex[k].ToString();
			objectFromPool.transform.GetChild(0).GetChild(0).GetComponent<Renderer>()
				.material = enemyMaterials[enemyColorIndex[k]];
			objectFromPool.transform.GetChild(0).localPosition = Vector3.zero;
			objectFromPool.transform.GetChild(0).localRotation = Quaternion.identity;
			objectFromPool.transform.localRotation = Quaternion.identity;
			objectFromPool.transform.localPosition = list[array[k]];
			objectFromPool.transform.GetChild(0).GetChild(0).RotateAround(objectFromPool.transform.GetChild(0).GetChild(0).position, Vector3.up, random.Next(360));
			objectFromPool.SetActive(value: true);
		}
	}

	public void Reset()
	{
		StopAllCoroutines();
	}

	private int[] GetRandomColorIndex(int colorCount, int randomCount)
	{
		List<int> list = new List<int>();
		int[] array = PublicTools.GetRandom(colorCount);
		int num = 0;
		while (list.Count < randomCount)
		{
			list.Add(array[num]);
			num++;
			if (num >= colorCount)
			{
				array = PublicTools.GetRandom(colorCount);
				num = 0;
			}
		}
		return list.ToArray();
	}

	private int[] RandomCount(int k, int count)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < count; i++)
		{
			list.Add(i);
		}
		List<int> list2 = new List<int>();
		for (int j = 0; j < k; j++)
		{
			int index = random.Next(list.Count);
			list2.Add(list[index]);
			list.Remove(list[index]);
		}
		return list2.ToArray();
	}
}
public class EnergyUISystem : UISystemBased
{
	private static EnergyUISystem energyUI = null;

	[SerializeField]
	private GameSystem gs;

	private object enemyIndex;

	public static EnergyUISystem GetEnergyUISystem
	{
		get
		{
			if (energyUI == null)
			{
				energyUI = GameObject.Find("UIManager").AddComponent<EnergyUISystem>();
			}
			return energyUI;
		}
	}

	private void Awake()
	{
		if (energyUI == null)
		{
			energyUI = this;
		}
	}

	public override void Start()
	{
		base.Start();
		UISystemBased.UIName_Path.Add("GuideCanvas", base.transform.Find("Normal/GuideCanvas").gameObject);
		GetUIGameObject("GuideCanvas/Panel/Step1").GetComponentInChildren<Button>().onClick.AddListener(delegate
		{
			SetUIActive("GuideCanvas/Panel/Step1", isActive: false);
			SetUIActive("GuideCanvas/Panel/Step2", isActive: true);
		});
		GetUIGameObject("GuideCanvas/Panel/Step2").GetComponentInChildren<Button>().onClick.AddListener(delegate
		{
			SetUIActive("GuideCanvas/Panel/Step2", isActive: false);
			SetUIActive("GuideCanvas/Test/GunTest", isActive: true);
			gs.leftShootTime = 0f;
			gs.rightShootTime = 0f;
			GameSystem.GetGameStatus = GameStatus.guide;
			GameSystem.enemyIndex = new List<int>();
			GameSystem.enemyIndex.Add(0);
		});
		GetUIGameObject("GuideCanvas/Panel/Step3").GetComponentInChildren<Button>().onClick.AddListener(delegate
		{
			SetUIActive("GuideCanvas/Panel/Step3", isActive: false);
			SetUIActive("GuideCanvas/Test/RockTest", isActive: true);
			gs.leftShootTime = 0f;
			gs.rightShootTime = 0f;
			GameSystem.GetGameStatus = GameStatus.guide;
			GameSystem.enemyIndex = new List<int>();
			GameSystem.enemyIndex.Add(0);
			GameSystem.enemyIndex.Add(1);
			GameSystem.enemyIndex.Add(2);
			GameSystem.enemyIndex.Add(3);
		});
		GetUIGameObject("GuideCanvas/Panel/Step4").GetComponentInChildren<Button>().onClick.AddListener(delegate
		{
			SetUIActive("GuideCanvas/Panel/Step4", isActive: false);
			SetUIActive("MainCanvas", isActive: true);
			GameSystem.enemyIndex = new List<int>();
			GameSystem.GetGameStatus = GameStatus.none;
			PlayerPrefs.SetString("FinishGuide", "true");
		});
		UISystemBased.UIName_Path.Add("ScoreCanvas", base.transform.Find("Curved/ScoreCanvas").gameObject);
		UISystemBased.UIName_Path.Add("MaskCanvas", base.transform.Find("Normal/MaskCanvas").gameObject);
		SetUIActive("MaskCanvas", isActive: false);
		int level = 1;
		int wave = 1;
		UISystemBased.UIName_Path.Add("MainCanvas", base.transform.Find("Curved/MainCanvas/MainPanel").gameObject);
		UISystemBased.UIName_Path.Add("GameCanvas", base.transform.Find("Normal/GameCanvas").gameObject);
		UISystemBased.UIName_Path.Add("OtherCanvas", base.transform.Find("Normal/OtherCanvas").gameObject);
		SetParama("OtherCanvas/GameObject", new UnityAction<float>[2]
		{
			delegate(float value)
			{
				level = (int)value;
				SetParama("OtherCanvas/GameObject/Text1", new string[1] { $"关卡：{level}" });
			},
			delegate(float value)
			{
				wave = (int)value;
				SetParama("OtherCanvas/GameObject/Text2", new string[1] { $"波次：{wave}" });
			}
		});
		int difficulty = 0;
		SetParama("MainCanvas/MainPanel", new UnityAction[7]
		{
			delegate
			{
				difficulty = 1;
				level = 1;
				wave = 1;
				SetUIActive("MainCanvas", isActive: false);
				SetUIActive("GameCanvas/StartPanel", isActive: true);
				gs.PrepareLevel(level, difficulty, wave);
			},
			delegate
			{
				difficulty = 2;
				level = 1;
				wave = 1;
				SetUIActive("MainCanvas", isActive: false);
				SetUIActive("GameCanvas/StartPanel", isActive: true);
				gs.PrepareLevel(level, difficulty, wave);
			},
			delegate
			{
				difficulty = 3;
				level = 1;
				wave = 1;
				SetUIActive("MainCanvas", isActive: false);
				SetUIActive("GameCanvas/StartPanel", isActive: true);
				gs.PrepareLevel(level, difficulty, wave);
			},
			delegate
			{
				difficulty = 4;
				level = 1;
				wave = 1;
				SetUIActive("MainCanvas", isActive: false);
				SetUIActive("GameCanvas/StartPanel", isActive: true);
				gs.PrepareLevel(level, difficulty, wave);
			},
			delegate
			{
				difficulty = 5;
				level = 1;
				wave = 1;
				SetUIActive("MainCanvas", isActive: false);
				SetUIActive("GameCanvas/StartPanel", isActive: true);
				gs.PrepareLevel(level, difficulty, wave);
			},
			delegate
			{
				difficulty = 6;
				level = 1;
				wave = 1;
				SetUIActive("MainCanvas", isActive: false);
				SetUIActive("GameCanvas/StartPanel", isActive: true);
				gs.PrepareLevel(level, difficulty, wave);
			},
			delegate
			{
				difficulty = 7;
				level = 1;
				wave = 1;
				SetUIActive("MainCanvas", isActive: false);
				SetUIActive("GameCanvas/StartPanel", isActive: true);
				gs.PrepareLevel(level, difficulty, wave);
			}
		});
		SetParama("GameCanvas/StartPanel", new UnityAction[1]
		{
			delegate
			{
				gs.StartLevel();
				SetUIActive("GameCanvas/StartPanel", isActive: false);
				SetUIActive("ScoreCanvas", isActive: true);
			}
		});
		UISystemBased.UIName_Path.Add("SettingsCanvas", base.transform.Find("Normal/SettingsCanvas").gameObject);
		SetParama("MainCanvas/BottomButton", new UnityAction[3]
		{
			delegate
			{
				if (GetUIGameObject("SettingsCanvas/Settings").activeInHierarchy)
				{
					SetUIActive("SettingsCanvas/Settings", isActive: false);
					SetUIActive("MainCanvas/MainPanel", isActive: true);
					SetUIActive("MainCanvas/BottomButton/BtnSettings/Select", isActive: false);
					SetParama("MainCanvas/BottomButton/BtnSettings", new string[1] { "游 戏 设 置" });
				}
				else
				{
					SetUIActive("SettingsCanvas/Settings", isActive: true);
					SetUIActive("SettingsCanvas/Help", isActive: false);
					SetUIActive("MainCanvas/MainPanel", isActive: false);
					SetUIActive("MainCanvas/BottomButton/BtnSettings/Select", isActive: true);
					SetUIActive("MainCanvas/BottomButton/BtnHelp/Select", isActive: false);
					SetParama("MainCanvas/BottomButton/BtnSettings", new string[1] { "关 闭 设 置" });
					SetParama("MainCanvas/BottomButton/BtnHelp", new string[1] { "游 戏 帮 助" });
				}
			},
			delegate
			{
				if (GetUIGameObject("SettingsCanvas/Help").activeInHierarchy)
				{
					SetUIActive("SettingsCanvas/Help", isActive: false);
					SetUIActive("MainCanvas/MainPanel", isActive: true);
					SetUIActive("MainCanvas/BottomButton/BtnHelp/Select", isActive: false);
					SetParama("MainCanvas/BottomButton/BtnHelp", new string[1] { "游 戏 帮 助" });
				}
				else
				{
					SetUIActive("SettingsCanvas/Help", isActive: true);
					SetUIActive("SettingsCanvas/Settings", isActive: false);
					SetUIActive("MainCanvas/MainPanel", isActive: false);
					SetUIActive("MainCanvas/BottomButton/BtnSettings/Select", isActive: false);
					SetUIActive("MainCanvas/BottomButton/BtnHelp/Select", isActive: true);
					SetParama("MainCanvas/BottomButton/BtnSettings", new string[1] { "游 戏 设 置" });
					SetParama("MainCanvas/BottomButton/BtnHelp", new string[1] { "关 闭 帮 助" });
				}
			},
			delegate
			{
				SetUIActive("SettingsCanvas/Help", isActive: false);
				SetUIActive("SettingsCanvas/Settings", isActive: false);
				SetUIActive("MainCanvas/MainPanel", isActive: true);
				SetUIActive("MainCanvas/BottomButton/BtnHelp/Select", isActive: false);
				SetUIActive("MainCanvas/BottomButton/BtnSettings/Select", isActive: false);
				SetParama("MainCanvas/BottomButton/BtnHelp", new string[1] { "游 戏 帮 助" });
				SetParama("MainCanvas/BottomButton/BtnSettings", new string[1] { "游 戏 设 置" });
				SceneAsyncLoad.Instance.LoadDiffScene(0);
			}
		});
		SetParama("SettingsCanvas/Settings/Content", new UnityAction<float>[2]
		{
			delegate(float value)
			{
				MonoSingleton<GameSystem>.Instance.backVolume = value;
				gs.GetComponent<AudioSource>().volume = value;
			},
			delegate(float value)
			{
				MonoSingleton<GameSystem>.Instance.efmVolume = value;
			}
		});
		GetUIGameObject("SettingsCanvas/Settings/Content").transform.GetChild(0).GetComponentInChildren<Slider>().value = MonoSingleton<GameSystem>.Instance.backVolume;
		GetUIGameObject("SettingsCanvas/Settings/Content").transform.GetChild(1).GetComponentInChildren<Slider>().value = MonoSingleton<GameSystem>.Instance.efmVolume;
		gs.GetComponent<AudioSource>().volume = MonoSingleton<GameSystem>.Instance.backVolume;
		SetParama("SettingsCanvas/Settings/Content", new UnityAction<bool>[2]
		{
			delegate(bool value)
			{
				if (value)
				{
					MonoSingleton<GameSystem>.Instance.handShake = true;
				}
			},
			delegate(bool value)
			{
				if (value)
				{
					MonoSingleton<GameSystem>.Instance.handShake = false;
				}
			}
		});
		GetUIGameObject("SettingsCanvas/Settings/Content").transform.GetChild(2).Find("HandleVibration").GetChild(0)
			.GetComponent<Toggle>()
			.isOn = MonoSingleton<GameSystem>.Instance.handShake;
		GetUIGameObject("SettingsCanvas/Settings/Content").transform.GetChild(2).Find("HandleVibration").GetChild(1)
			.GetComponent<Toggle>()
			.isOn = !MonoSingleton<GameSystem>.Instance.handShake;
		RawImage[] rigthRaw = GetUIGameObject("SettingsCanvas/Help/RightImage").transform.GetComponentsInChildren<RawImage>();
		SetParama("SettingsCanvas/Help/LeftGroup", new UnityAction<bool>[4]
		{
			delegate(bool value)
			{
				if (value)
				{
					for (int l = 0; l < rigthRaw.Length; l++)
					{
						rigthRaw[l].enabled = false;
					}
					rigthRaw[0].enabled = true;
				}
			},
			delegate(bool value)
			{
				if (value)
				{
					for (int k = 0; k < rigthRaw.Length; k++)
					{
						rigthRaw[k].enabled = false;
					}
					rigthRaw[1].enabled = true;
				}
			},
			delegate(bool value)
			{
				if (value)
				{
					for (int j = 0; j < rigthRaw.Length; j++)
					{
						rigthRaw[j].enabled = false;
					}
					rigthRaw[2].enabled = true;
				}
			},
			delegate(bool value)
			{
				if (value)
				{
					for (int i = 0; i < rigthRaw.Length; i++)
					{
						rigthRaw[i].enabled = false;
					}
					rigthRaw[3].enabled = true;
				}
			}
		});
		SetParama("GameCanvas/WinPanel", new UnityAction[2]
		{
			delegate
			{
				SetUIActive("GameCanvas/WinPanel", isActive: false);
				SetUIActive("MainCanvas", isActive: true);
				gs.EndGame();
				SetUIActive("ScoreCanvas", isActive: false);
			},
			delegate
			{
				SetUIActive("GameCanvas/WinPanel", isActive: false);
				level++;
				gs.PrepareLevel(level, difficulty, wave);
				SetUIActive("GameCanvas/StartPanel", isActive: true);
			}
		});
		SetParama("GameCanvas/PausePanel", new UnityAction[3]
		{
			delegate
			{
				GameSystem.GetGameStatus = GameStatus.gaming;
				SetUIActive("GameCanvas/PausePanel", isActive: false);
				Time.timeScale = 1f;
			},
			delegate
			{
				SetUIActive("GameCanvas/PausePanel", isActive: false);
				Time.timeScale = 1f;
				GameSystem.GetGameStatus = GameStatus.none;
				SetUIActive("MainCanvas", isActive: true);
				gs.EndGame();
				SetUIActive("ScoreCanvas", isActive: false);
			},
			delegate
			{
				SetUIActive("GameCanvas/PausePanel", isActive: false);
				Time.timeScale = 1f;
				GameSystem.GetGameStatus = GameStatus.ready;
				gs.ReStart();
			}
		});
		SetParama("GameCanvas/FinishPanel", new UnityAction[1]
		{
			delegate
			{
				SetUIActive("GameCanvas/FinishPanel", isActive: false);
				gs.EndGame();
				SetUIActive("ScoreCanvas", isActive: false);
				SetUIActive("MainCanvas", isActive: true);
				SetUIActive("GameCanvas/StartPanel", isActive: false);
				level = 1;
			}
		});
		InitEnergyShooting();
	}

	public void InitEnergyShooting()
	{
		if (PlayerPrefs.HasKey("FinishGuide") || Application.platform == RuntimePlatform.WindowsEditor)
		{
			SetUIActive("GuideCanvas", isActive: false);
			SetUIActive("MainCanvas", isActive: true);
		}
		else
		{
			SetUIActive("MainCanvas", isActive: false);
			SetUIActive("GuideCanvas", isActive: true);
		}
	}
}
public enum GameStatus
{
	none,
	guide,
	ready,
	gaming,
	pause,
	over
}
public class GameSystem : MonoSingleton<GameSystem>
{
	[SerializeField]
	private bool isRestart = false;

	[Range(0f, 30f)]
	[SerializeField]
	private int timescale = 1;

	[SerializeField]
	private XRController leftHandController;

	[SerializeField]
	private XRController rightHandController;

	[SerializeField]
	private GameObject leftGun;

	[SerializeField]
	private GameObject rightGun;

	[SerializeField]
	private GameObject[] bullets;

	[SerializeField]
	private Transform bulletParent;

	[SerializeField]
	private GameObject[] balls;

	[SerializeField]
	private Transform ballParent;

	[SerializeField]
	private Material[] ballMaterials;

	[SerializeField]
	private Renderer[] gunMaterials;

	[SerializeField]
	private Material ballGrayMaterial;

	[SerializeField]
	private GameObject magicPilar;

	[SerializeField]
	private Transform MagicParent;

	[SerializeField]
	private float shootInterval = 0.15f;

	[SerializeField]
	private Text TimerText;

	[SerializeField]
	private AudioClip[] effectClip;

	[SerializeField]
	private AudioClip[] backClip;

	[SerializeField]
	private Color[] gunColors;

	[SerializeField]
	private GameObject gunShootPar;

	[SerializeField]
	private Texture2D[] scoreTexture;

	private Vector3[] recordDes;

	public float rightShootTime = 0f;

	public float leftShootTime = 0f;

	private GunsSystem gunsSystem;

	private EnemySystem enemySystem;

	private static GameStatus status = GameStatus.none;

	public static List<int> enemyIndex;

	private System.Random random = new System.Random((int)DateTime.Now.Ticks);

	private bool canOut = false;

	private int currentTargetScore;

	private int totalTargetScore;

	private int level;

	private int difficulty;

	private int wave;

	private float time;

	private float intermediate;

	private int senior;

	private float interval;

	private float waittime;

	private float realwait;

	private string[] wavecountnormal;

	private Hashtable hashtablelevel1;

	private Hashtable hashtablelevel2;

	private Hashtable hashtablelevel3;

	private Hashtable hashtablelevel4;

	private Hashtable hashtablelevel5;

	private Hashtable hashtablelevel6;

	private Hashtable hashtablelevel7;

	private Hashtable hashtabledescript;

	private int currentScore = 0;

	private float currentTime = 0f;

	private int hitCount = 0;

	private int totalScore = 0;

	private int ticket = 0;

	private int leftBulletIndex;

	private int rightBulletIndex;

	private float intensity = 0.3f;

	public float efmVolume
	{
		get
		{
			return PlayerPrefs.HasKey("efmvolume") ? PlayerPrefs.GetFloat("efmvolume") : 0.3f;
		}
		set
		{
			PlayerPrefs.SetFloat("efmvolume", value);
		}
	}

	public float backVolume
	{
		get
		{
			return PlayerPrefs.HasKey("bavolume") ? PlayerPrefs.GetFloat("bavolume") : 0.3f;
		}
		set
		{
			PlayerPrefs.SetFloat("bavolume", value);
		}
	}

	public bool handShake
	{
		get
		{
			return !PlayerPrefs.HasKey("gamehandshake") || PlayerPrefs.GetInt("gamehandshake") == 1;
		}
		set
		{
			PlayerPrefs.SetInt("gamehandshake", value ? 1 : 0);
		}
	}

	public static GameStatus GetGameStatus
	{
		get
		{
			return status;
		}
		set
		{
			status = value;
		}
	}

	private void Awake()
	{
		if (isRestart && PlayerPrefs.HasKey("FinishGuide"))
		{
			PlayerPrefs.DeleteKey("FinishGuide");
		}
		MessageDispatch.GetInstance().RemoveAll();
		InitBulletObject();
		InitBallObject();
	}

	private void Start()
	{
		recordDes = new Vector3[7];
		StartCoroutine(ReadXmlFile(Application.streamingAssetsPath + "/energyshootingsettings.xml"));
		enemySystem = UnityEngine.Object.FindObjectOfType<EnemySystem>();
		if (enemySystem == null)
		{
			enemySystem = base.gameObject.AddComponent<EnemySystem>().GetComponent<EnemySystem>();
		}
		gunsSystem = new GunsSystem(leftHandController, rightHandController);
		MessageDispatch.GetInstance().AddEventListener(MEventType.SCORE, delegate(MessageTypes mt)
		{
			Vector3 vector = (Vector3)((object[])mt.Sender)[0];
			GameObject gameObject = UnityEngine.Object.Instantiate(magicPilar, MagicParent);
			gameObject.transform.position = vector + new Vector3(0f, 0.3f, 0f);
			int num = int.Parse(((object[])mt.Sender)[2].ToString());
			int num2 = 0;
			UnityEngine.Object.Destroy(gameObject, 2f);
			try
			{
				int item = int.Parse(((object[])mt.Sender)[1].ToString());
				enemyIndex.Remove(item);
				if (status != GameStatus.guide)
				{
					if (num == 1)
					{
						num2 = 20;
					}
					else if (num == 2)
					{
						num2 = 30;
					}
					else if (num > 2)
					{
						num2 = 50;
					}
					hitCount++;
				}
			}
			catch
			{
				string text = ((object[])mt.Sender)[1].ToString();
				if (text == "intermediateball" || text == "big")
				{
					enemyIndex.Remove(4);
					if (status != GameStatus.guide)
					{
						num2 = 40;
					}
				}
				else if (text == "seniorball")
				{
					enemyIndex.Remove(5);
					if (status != GameStatus.guide)
					{
						num2 = 60;
					}
				}
			}
			if (status == GameStatus.guide)
			{
				StartCoroutine(WaitForSeconds(0.8f));
			}
			else
			{
				currentScore += num2;
				totalScore += num2;
				Transform transform = EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/Right/MiddleImage").transform;
				Text component = transform.GetChild(level - 1).transform.GetChild(1).GetComponent<Text>();
				component.text = hitCount.ToString();
				if (enemyIndex.Count == 0)
				{
					FinishGame();
				}
			}
		});
		enemySystem.SetEnemyParent = ballParent;
		enemySystem.SetEnemyPrefab = balls;
		enemySystem.SetEnemyMaterials = ballMaterials;
		BulletSystem.hitCorrect = effectClip[1];
		BulletSystem.hitIncorrect = effectClip[0];
		leftHandController.GetComponentInChildren<LineRenderer>().material.SetColor("_Color", Color.white * Mathf.Pow(2f, intensity));
		leftHandController.GetComponentInChildren<LineRenderer>().material.SetColor("_ColorBlend", Color.white * Mathf.Pow(2f, intensity + 0.5f));
		rightHandController.GetComponentInChildren<LineRenderer>().material.SetColor("_Color", Color.white * Mathf.Pow(2f, intensity));
		rightHandController.GetComponentInChildren<LineRenderer>().material.SetColor("_ColorBlend", Color.white * Mathf.Pow(2f, intensity + 0.5f));
	}

	private IEnumerator WaitForSeconds(float v)
	{
		if (enemyIndex.Count == 0)
		{
			yield return new WaitForSeconds(v);
			if (EnergyUISystem.GetEnergyUISystem.GetUIGameObject("GuideCanvas/Test/GunTest").activeInHierarchy)
			{
				EnergyUISystem.GetEnergyUISystem.SetUIActive("GuideCanvas/Panel/Step3", isActive: true);
				EnergyUISystem.GetEnergyUISystem.SetUIActive("GuideCanvas/Test/GunTest", isActive: false);
				status = GameStatus.none;
			}
			else if (EnergyUISystem.GetEnergyUISystem.GetUIGameObject("GuideCanvas/Test/RockTest/Canvas/Panel/RawImage").activeInHierarchy)
			{
				EnergyUISystem.GetEnergyUISystem.SetUIActive("GuideCanvas/Test/RockTest/big", isActive: true);
				EnergyUISystem.GetEnergyUISystem.SetUIActive("GuideCanvas/Test/RockTest/Canvas/Panel/RawImageBig", isActive: true);
				EnergyUISystem.GetEnergyUISystem.SetUIActive("GuideCanvas/Test/RockTest/Canvas/Panel/RawImage", isActive: false);
				enemyIndex = new List<int>();
				enemyIndex.Add(4);
			}
			else
			{
				EnergyUISystem.GetEnergyUISystem.SetUIActive("GuideCanvas/Test/RockTest/Canvas/Panel/RawImageBig", isActive: false);
				EnergyUISystem.GetEnergyUISystem.SetUIActive("GuideCanvas/Panel/Step4", isActive: true);
				status = GameStatus.none;
			}
		}
	}

	private IEnumerator ScorePlus()
	{
		canOut = false;
		Text leftCurrentScore = EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/ScoreText/Text").GetComponent<Text>();
		Text rightTotalScore = EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/Right/TopImage/Text").GetComponent<Text>();
		Transform middleImg = EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/Right/MiddleImage").transform;
		while (true)
		{
			yield return new WaitForSeconds(0.01f);
			if (currentTargetScore != currentScore)
			{
				currentTargetScore += (currentScore - currentTargetScore) / Mathf.Abs(currentScore - currentTargetScore);
				leftCurrentScore.text = $"能量值 {currentTargetScore}";
				middleImg.GetChild(level - 1).transform.GetChild(2).GetComponent<Text>().text = currentTargetScore.ToString();
			}
			if (totalTargetScore != totalScore)
			{
				totalTargetScore += (totalScore - totalTargetScore) / Mathf.Abs(totalScore - totalTargetScore);
				rightTotalScore.text = $"总能量值 {totalTargetScore}";
			}
			if (currentTargetScore == currentScore && totalTargetScore == totalScore)
			{
				canOut = true;
			}
		}
	}

	private IEnumerator ReadXmlFile(string path)
	{
		if (Application.platform != RuntimePlatform.Android)
		{
			path = "file://" + path;
		}
		WWW www = new WWW(path);
		yield return www;
		if (www.error == null)
		{
			Stream stream = new MemoryStream(www.bytes);
			ReadXmlSettings settings = new ReadXmlSettings(stream);
			ReadXmlLevelsSettings(settings);
			stream.Dispose();
		}
		else
		{
			UnityEngine.Debug.LogError(www.error);
		}
		www.Dispose();
	}

	private void ReadXmlLevelsSettings(ReadXmlSettings settings)
	{
		if (settings.ReadLevel("level1"))
		{
			hashtablelevel1 = settings.GetSettings();
		}
		if (settings.ReadLevel("level2"))
		{
			hashtablelevel2 = settings.GetSettings();
		}
		if (settings.ReadLevel("level3"))
		{
			hashtablelevel3 = settings.GetSettings();
		}
		if (settings.ReadLevel("level4"))
		{
			hashtablelevel4 = settings.GetSettings();
		}
		if (settings.ReadLevel("level5"))
		{
			hashtablelevel5 = settings.GetSettings();
		}
		if (settings.ReadLevel("level6"))
		{
			hashtablelevel6 = settings.GetSettings();
		}
		if (settings.ReadLevel("level7"))
		{
			hashtablelevel7 = settings.GetSettings();
		}
		if (settings.ReadDescript())
		{
			hashtabledescript = settings.GetSettings();
		}
	}

	private void InitBulletObject()
	{
		PoolSystem.InitObjectPool(ObjectType.bullet_b, bullets[0], 10, bulletParent);
		PoolSystem.InitObjectPool(ObjectType.bullet_p, bullets[1], 10, bulletParent);
		PoolSystem.InitObjectPool(ObjectType.bullet_y, bullets[2], 10, bulletParent);
		PoolSystem.InitObjectPool(ObjectType.bullet_r, bullets[3], 10, bulletParent);
	}

	private void InitBallObject()
	{
		PoolSystem.InitObjectPool(ObjectType.normalball, balls[0], 10, ballParent);
		PoolSystem.InitObjectPool(ObjectType.intermediateball, balls[1], 6, ballParent);
		PoolSystem.InitObjectPool(ObjectType.seniorball, balls[2], 2, ballParent);
	}

	public void PrepareLevel(int level, int difficulty, int wave)
	{
		if (level == 8)
		{
			StartCoroutine(ShowTotalScore());
			return;
		}
		currentTime = 0f;
		this.wave = ((wave != 0) ? (wave - 1) : 0);
		this.level = level;
		this.difficulty = difficulty;
		enemySystem.InitEnemy();
		waittime = 0f;
		realwait = 0f;
		EnergyUISystem.GetEnergyUISystem.SetUIActive("ScoreCanvas/WaittimePanel", isActive: false);
		Hashtable hashtable;
		switch (level)
		{
		case 1:
			hashtable = hashtablelevel1;
			time = float.Parse(hashtable["time" + difficulty].ToString());
			intermediate = 0f;
			TimerText.text = ((int)time).ToString();
			StartCoroutine(GameTimer(time, delegate(float time)
			{
				string text6 = ((((int)(time * 10f)).ToString().Length < 2) ? $"0{((int)(time * 10f)).ToString()}" : ((int)(time * 10f)).ToString());
				EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/TimeText/Text").GetComponent<Text>().text = string.Format("倒计时 {0}", text6.Insert(text6.Length - 1, "."));
			}));
			break;
		case 2:
			hashtable = hashtablelevel2;
			time = float.Parse(hashtable["time" + difficulty].ToString());
			intermediate = float.Parse(hashtable["intermediate" + difficulty].ToString());
			TimerText.text = ((int)time).ToString();
			StartCoroutine(GameTimer(time, delegate(float time)
			{
				string text5 = ((((int)(time * 10f)).ToString().Length < 2) ? $"0{((int)(time * 10f)).ToString()}" : ((int)(time * 10f)).ToString());
				EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/TimeText/Text").GetComponent<Text>().text = string.Format("倒计时 {0}", text5.Insert(text5.Length - 1, "."));
			}));
			break;
		case 3:
			hashtable = hashtablelevel3;
			interval = float.Parse(hashtable["interval" + difficulty].ToString());
			intermediate = float.Parse(hashtable["intermediate" + difficulty].ToString());
			senior = 0;
			break;
		case 4:
			hashtable = hashtablelevel4;
			interval = float.Parse(hashtable["interval" + difficulty].ToString());
			intermediate = float.Parse(hashtable["intermediate" + difficulty].ToString());
			senior = int.Parse(hashtable["senior" + difficulty].ToString());
			break;
		case 5:
			hashtable = hashtablelevel5;
			interval = float.Parse(hashtable["interval" + difficulty].ToString());
			intermediate = float.Parse(hashtable["intermediate" + difficulty].ToString());
			senior = 0;
			break;
		case 6:
			hashtable = hashtablelevel6;
			interval = float.Parse(hashtable["interval" + difficulty].ToString());
			intermediate = float.Parse(hashtable["intermediate" + difficulty].ToString());
			senior = int.Parse(hashtable["senior" + difficulty].ToString());
			break;
		case 7:
			hashtable = hashtablelevel7;
			time = float.Parse(hashtable["time" + difficulty].ToString());
			realwait = float.Parse(hashtable["waittime" + difficulty].ToString());
			waittime = realwait;
			intermediate = 0f;
			TimerText.text = ((int)time).ToString();
			StartCoroutine(GameTimer(time, delegate(float time)
			{
				string text7 = ((((int)(time * 10f)).ToString().Length < 2) ? $"0{((int)(time * 10f)).ToString()}" : ((int)(time * 10f)).ToString());
				EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/TimeText/Text").GetComponent<Text>().text = string.Format("倒计时 {0}", text7.Insert(text7.Length - 1, "."));
			}));
			break;
		default:
			hashtable = hashtablelevel1;
			intermediate = 0f;
			TimerText.text = ((int)time).ToString();
			StartCoroutine(GameTimer(time, delegate(float time)
			{
				string text8 = ((int)(time * 10f)).ToString();
				EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/TimeText/Text").GetComponent<Text>().text = string.Format("倒计时 {0}", text8.Insert(text8.Length - 1, "."));
			}));
			break;
		}
		wavecountnormal = hashtable["wave" + difficulty].ToString().Split(',');
		string[] array = hashtabledescript[$"Level{level}"].ToString().Split('^');
		string[] array2 = new string[7] { "一", "二", "三", "四", "五", "六", "七" };
		string text = $"任 务 {array2[level - 1]}";
		string text2 = array[0].Replace("*", ((int)time).ToString()).Replace("#", wavecountnormal.Length.ToString());
		string text3 = array[1];
		string text4 = array[2].Replace("$", "\n<color=#00000000>提示：</color>");
		EnergyUISystem.GetEnergyUISystem.SetParama("GameCanvas/StartPanel", new string[4] { text, text2, text3, text4 });
		status = GameStatus.ready;
		if (base.transform.GetComponent<AudioSource>().clip != backClip[1])
		{
			base.transform.GetComponent<AudioSource>().clip = backClip[1];
			base.transform.GetComponent<AudioSource>().Play();
		}
	}

	private IEnumerator ShowTotalScore()
	{
		status = GameStatus.none;
		EnergyUISystem.GetEnergyUISystem.SetUIActive("GameCanvas/WinPanel", isActive: false);
		EnergyUISystem.GetEnergyUISystem.SetUIActive("GameCanvas/FinishPanel", isActive: true);
		level = 1;
		int _totalScore = 0;
		float _starCount = 0f;
		float startCount2 = 0f;
		float _totalTimer = 0f;
		int totalTimer = 0;
		int _hitCount = 0;
		int hitCount = 0;
		for (int i = 0; i < recordDes.Length; i++)
		{
			startCount2 += recordDes[i].x;
			totalTimer += (int)recordDes[i].y;
			hitCount += (int)recordDes[i].z;
		}
		startCount2 /= (float)recordDes.Length;
		Text[] texts = new Text[3]
		{
			EnergyUISystem.GetEnergyUISystem.GetUIGameObject("GameCanvas/FinishPanel/Description").transform.GetChild(0).GetComponent<Text>(),
			EnergyUISystem.GetEnergyUISystem.GetUIGameObject("GameCanvas/FinishPanel/Description/Introduce").transform.GetChild(0).GetChild(2).GetComponent<Text>(),
			EnergyUISystem.GetEnergyUISystem.GetUIGameObject("GameCanvas/FinishPanel/Description/Introduce").transform.GetChild(1).GetChild(2).GetComponent<Text>()
		};
		Slider[] sliders = EnergyUISystem.GetEnergyUISystem.GetUIGameObject("GameCanvas/FinishPanel/Description/StarScore").GetComponentsInChildren<Slider>();
		while (_totalScore < totalScore || _totalTimer < (float)totalTimer || _starCount < startCount2 || _hitCount < hitCount)
		{
			yield return new WaitForEndOfFrame();
			_totalScore = ((_totalScore >= totalScore) ? totalScore : (_totalScore + 50));
			_totalTimer = ((!(_totalTimer < (float)totalTimer)) ? ((float)totalTimer) : (_totalTimer + Time.deltaTime * 250f));
			_starCount = ((!(_starCount < startCount2)) ? startCount2 : (_starCount + Time.deltaTime));
			_hitCount = ((_hitCount >= hitCount) ? hitCount : (_hitCount + 3));
			texts[0].text = _totalScore.ToString();
			texts[1].text = ((int)_totalTimer).ToString();
			texts[2].text = _hitCount.ToString();
			sliders[(int)_starCount].value = _starCount - (float)(int)_starCount;
		}
	}

	public void StartLevel(bool nextLevel = true)
	{
		leftShootTime = 0f;
		rightShootTime = 0f;
		if (wave > wavecountnormal.Length - 1)
		{
			wave = wavecountnormal.Length - 1;
		}
		if (level == 1 || level == 2)
		{
			enemySystem.InitStaticEnemy_Level12(int.Parse(wavecountnormal[wave]), intermediate);
			if (nextLevel)
			{
				string text = ((int)(time * 10f)).ToString();
				EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/TimeText/Text").GetComponent<Text>().text = string.Format("倒计时 {0}", text.Insert(text.Length - 1, "."));
			}
		}
		else if (level == 3 || level == 4)
		{
			int num = int.Parse(wavecountnormal[wave]);
			enemySystem.InitDynamicEnemy_Level34(num, intermediate, senior, interval);
			EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/TimeText/Text").GetComponent<Text>().text = $"剩余数 {num}";
		}
		else if (level == 5 || level == 6)
		{
			int num2 = int.Parse(wavecountnormal[wave]);
			enemySystem.InitDynamicEnemy_Level56(num2, intermediate, senior, interval);
			EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/TimeText/Text").GetComponent<Text>().text = $"剩余数 {num2}";
		}
		else if (level == 7)
		{
			waittime = realwait;
			EnergyUISystem.GetEnergyUISystem.SetUIActive("ScoreCanvas/WaittimePanel", isActive: true);
			string text2 = ((((int)(waittime * 10f)).ToString().Length < 2) ? $"0{((int)(waittime * 10f)).ToString()}" : ((int)(waittime * 10f)).ToString());
			EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/WaittimePanel/RawImage/MemoryTime").GetComponent<Text>().text = text2.Insert(text2.Length - 1, ".");
			enemySystem.InitStaticEnemy_Level7(int.Parse(wavecountnormal[wave]));
			if (nextLevel)
			{
				string text3 = ((int)(time * 10f)).ToString();
				EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/TimeText/Text").GetComponent<Text>().text = string.Format("倒计时 {0}", text3.Insert(text3.Length - 1, "."));
			}
		}
		status = GameStatus.gaming;
		BulletSystem.doubleHit = 0;
		string message = $"难度：{difficulty}，关卡：{level}，波次：{wave}";
		UnityEngine.Debug.Log(message);
		message = $"任务{level} 波次{wave + 1}";
		EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/IntroduceText/Text").GetComponent<Text>().text = message;
		UnityEngine.Debug.Log(wavecountnormal[wave]);
		GetRandomColor(0);
		GetRandomColor(1);
		if (nextLevel)
		{
			currentTargetScore = 0;
			currentScore = 0;
			hitCount = 0;
			EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/ScoreText/Text").GetComponent<Text>().text = $"能量值 {currentTargetScore}";
			Transform transform = EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/Right/MiddleImage").transform;
			for (int i = 0; i < transform.childCount; i++)
			{
				transform.GetChild(i).gameObject.SetActive(i < level);
				transform.GetChild(i).GetComponent<RawImage>().texture = scoreTexture[(i == level - 1) ? 1 : 0];
			}
			string[] array = new string[3]
			{
				level.ToString(),
				hitCount.ToString(),
				currentScore.ToString()
			};
			Text[] componentsInChildren = transform.GetChild(level - 1).GetComponentsInChildren<Text>();
			for (int j = 0; j < componentsInChildren.Length; j++)
			{
				componentsInChildren[j].text = array[j];
			}
			StartCoroutine(ScorePlus());
		}
	}

	public void ReStart()
	{
		ReSet();
		PrepareLevel(level, difficulty, 0);
		totalScore -= currentScore;
		StartLevel();
	}

	public void ReSet()
	{
		StopAllCoroutines();
		enemySystem.Reset();
		status = GameStatus.over;
		for (int i = 0; i < ballParent.childCount; i++)
		{
			ballParent.GetChild(i).gameObject.SetActive(value: false);
		}
		for (int j = 0; j < bulletParent.childCount; j++)
		{
			if (bulletParent.GetChild(j).GetChild(0).gameObject.activeInHierarchy)
			{
				bulletParent.GetChild(j).GetComponent<BulletSystem>().Reset();
			}
		}
	}

	private IEnumerator OverLevel()
	{
		status = GameStatus.over;
		while (!canOut)
		{
			yield return new WaitForEndOfFrame();
		}
		NextStep();
	}

	private void NextStep()
	{
		StopAllCoroutines();
		StartCoroutine(GameOverPanel());
	}

	private IEnumerator GameOverPanel()
	{
		for (int i = 0; i < ballParent.childCount; i++)
		{
			ballParent.GetChild(i).gameObject.SetActive(value: false);
		}
		for (int j = 0; j < bulletParent.childCount; j++)
		{
			bulletParent.GetChild(j).GetComponent<BulletSystem>().Reset();
		}
		EnergyUISystem.GetEnergyUISystem.SetUIActive("GameCanvas/WinPanel", isActive: true);
		int ballCcount = 0;
		for (int k = 0; k < wavecountnormal.Length; k++)
		{
			ballCcount += int.Parse(wavecountnormal[k]);
		}
		int realTotalScore = 50 + 50 * (ballCcount - 2);
		int score = 0;
		int hit = 0;
		Transform desctrptionTrans = EnergyUISystem.GetEnergyUISystem.GetUIGameObject("GameCanvas/WinPanel/Description").transform;
		Text[] texts = new Text[3]
		{
			desctrptionTrans.Find("Text").GetComponent<Text>(),
			desctrptionTrans.Find("Introduce").GetChild(0).GetChild(2)
				.GetComponent<Text>(),
			desctrptionTrans.Find("Introduce").GetChild(1).GetChild(2)
				.GetComponent<Text>()
		};
		Slider[] sliders = EnergyUISystem.GetEnergyUISystem.GetUIGameObject("GameCanvas/WinPanel/Description").GetComponentsInChildren<Slider>();
		Slider[] array = sliders;
		foreach (Slider slider in array)
		{
			slider.value = 0f;
		}
		Text[] array2 = texts;
		foreach (Text txt in array2)
		{
			txt.text = "0";
		}
		float myEva = (((float)currentScore / (float)realTotalScore * 0.6f > 1f) ? 1f : ((float)currentScore / (float)realTotalScore * 0.6f));
		float startCount = (float)(int)(myEva * 30f) / 10f;
		float currentStart = 0f;
		float _currentStar = 0f;
		float myTotalTime = currentTime;
		if (level == 7)
		{
			myTotalTime -= waittime;
		}
		while (score < currentScore || currentStart < myTotalTime || hit < hitCount || _currentStar < startCount)
		{
			yield return null;
			score = ((score >= totalScore) ? totalScore : (score + 10));
			currentStart = ((!(currentStart < myTotalTime)) ? myTotalTime : (currentStart + Time.deltaTime * 45f));
			hit = ((hit >= hitCount) ? hitCount : (hit + 1));
			_currentStar = ((!(_currentStar < startCount)) ? startCount : (_currentStar + Time.deltaTime));
			texts[0].text = score.ToString();
			texts[1].text = ((int)currentStart).ToString();
			texts[2].text = hit.ToString();
			sliders[(int)_currentStar].value = _currentStar - (float)(int)_currentStar;
		}
		texts[1].text = (((int)currentStart > (int)time) ? ((int)time).ToString() : ((int)currentStart).ToString());
		recordDes[level - 1] = new Vector3(startCount, myTotalTime, hitCount);
	}

	public void EndGame()
	{
		ReSet();
		totalScore = 0;
		totalTargetScore = 0;
		status = GameStatus.none;
		recordDes = new Vector3[7];
		EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/ScorePanel/Right/TopImage/Text").GetComponent<Text>().text = $"总能量值 {totalTargetScore}";
		base.transform.GetComponent<AudioSource>().clip = backClip[0];
		base.transform.GetComponent<AudioSource>().Play();
	}

	private void Update()
	{
		bool flag = leftHandController.inputDevice.isValid || Application.platform == RuntimePlatform.WindowsEditor;
		bool flag2 = rightHandController.inputDevice.isValid || Application.platform == RuntimePlatform.WindowsEditor;
		leftHandController.gameObject.SetActive(flag);
		rightHandController.gameObject.SetActive(flag2);
		if (status == GameStatus.gaming || status == GameStatus.guide)
		{
			if (flag && (!leftGun.activeInHierarchy || leftHandController.modelParent.gameObject.activeInHierarchy))
			{
				if ((bool)leftHandController.modelParent)
				{
					leftHandController.modelParent.gameObject.SetActive(value: false);
				}
				leftGun.SetActive(value: true);
				leftHandController.GetComponentInChildren<LineRenderer>().material.SetColor("_Color", gunColors[leftBulletIndex] * Mathf.Pow(2f, intensity));
				leftHandController.GetComponentInChildren<LineRenderer>().material.SetColor("_ColorBlend", gunColors[leftBulletIndex] * Mathf.Pow(2f, intensity + 0.5f));
			}
			if (flag2 && (!rightGun.activeInHierarchy || rightHandController.modelParent.gameObject.activeInHierarchy))
			{
				if ((bool)rightHandController.modelParent)
				{
					rightHandController.modelParent.gameObject.SetActive(value: false);
				}
				rightGun.SetActive(value: true);
				rightHandController.GetComponentInChildren<LineRenderer>().material.SetColor("_Color", gunColors[rightBulletIndex] * Mathf.Pow(2f, intensity));
				rightHandController.GetComponentInChildren<LineRenderer>().material.SetColor("_ColorBlend", gunColors[rightBulletIndex] * Mathf.Pow(2f, intensity + 0.5f));
			}
			float deltaTime = Time.deltaTime;
			rightShootTime += deltaTime;
			leftShootTime += deltaTime;
			if (waittime == 0f)
			{
				currentTime += deltaTime;
			}
			if (flag2 && gunsSystem.GainRightHandShoot() && rightShootTime > shootInterval && waittime == 0f && rightHandController.GetComponent<LineRenderer>().positionCount > 1)
			{
				OnShootBullet(rightHandController.modelParent.position, rightHandController.GetComponent<LineRenderer>().GetPosition(1) - rightHandController.GetComponent<LineRenderer>().GetPosition(0), rightBulletIndex, 1);
				rightShootTime = 0f;
			}
			if (flag && gunsSystem.GainLeftHandShoot() && leftShootTime > shootInterval && waittime == 0f && leftHandController.GetComponent<LineRenderer>().positionCount > 1)
			{
				OnShootBullet(leftHandController.modelParent.position, leftHandController.GetComponent<LineRenderer>().GetPosition(1) - leftHandController.GetComponent<LineRenderer>().GetPosition(0), leftBulletIndex, 0);
				leftShootTime = 0f;
			}
			leftHandController.transform.GetComponent<XRRayInteractor>().enabled = true;
			rightHandController.transform.GetComponent<XRRayInteractor>().enabled = true;
		}
		else
		{
			if (flag && (leftGun.activeInHierarchy || !leftHandController.modelParent.gameObject.activeInHierarchy))
			{
				if ((bool)leftHandController.modelParent)
				{
					leftHandController.modelParent.gameObject.SetActive(value: true);
				}
				leftGun.SetActive(value: false);
				leftHandController.GetComponentInChildren<LineRenderer>().material.SetColor("_Color", Color.white * Mathf.Pow(2f, intensity));
				leftHandController.GetComponentInChildren<LineRenderer>().material.SetColor("_ColorBlend", Color.white * Mathf.Pow(2f, intensity + 0.5f));
			}
			if (flag2 && (rightGun.activeInHierarchy || !rightHandController.modelParent.gameObject.activeInHierarchy))
			{
				if ((bool)rightHandController.modelParent)
				{
					rightHandController.modelParent.gameObject.SetActive(value: true);
				}
				rightGun.SetActive(value: false);
				rightHandController.GetComponentInChildren<LineRenderer>().material.SetColor("_Color", Color.white * Mathf.Pow(2f, intensity));
				rightHandController.GetComponentInChildren<LineRenderer>().material.SetColor("_ColorBlend", Color.white * Mathf.Pow(2f, intensity + 0.5f));
			}
			if (leftHandController.transform.GetComponent<XRRayInteractor>().enabled != (MonoSingleton<Controller_Interact>.Instance.mainHand == 1))
			{
				leftHandController.transform.GetComponent<XRRayInteractor>().enabled = MonoSingleton<Controller_Interact>.Instance.mainHand == 1;
			}
			if (rightHandController.transform.GetComponent<XRRayInteractor>().enabled != (MonoSingleton<Controller_Interact>.Instance.mainHand == 0))
			{
				rightHandController.transform.GetComponent<XRRayInteractor>().enabled = MonoSingleton<Controller_Interact>.Instance.mainHand == 0;
			}
		}
		OnGamePause();
	}

	private void OnGamePause()
	{
		if (status != GameStatus.pause && Time.timeScale != (float)timescale)
		{
			Time.timeScale = timescale;
		}
		if (ticket > 60 && gunsSystem.GainHandPause())
		{
			if (status == GameStatus.gaming)
			{
				Time.timeScale = 0f;
				status = GameStatus.pause;
				ticket = 0;
				EnergyUISystem.GetEnergyUISystem.SetUIActive("GameCanvas/PausePanel", isActive: true);
			}
			else if (status == GameStatus.pause)
			{
				Time.timeScale = 1f;
				status = GameStatus.gaming;
				ticket = 0;
				EnergyUISystem.GetEnergyUISystem.SetUIActive("GameCanvas/PausePanel", isActive: false);
			}
		}
		ticket += ((ticket < 61) ? 1 : 0);
	}

	public void FinishGame()
	{
		status = GameStatus.ready;
		if (wave + 1 < wavecountnormal.Length)
		{
			wave++;
			StartCoroutine(StartNextWave());
		}
		else
		{
			StartCoroutine(OverLevel());
		}
	}

	private IEnumerator StartNextWave()
	{
		StartLevel(nextLevel: false);
		yield break;
	}

	private IEnumerator GameTimer(float timer, Action<float> action)
	{
		while (status != GameStatus.gaming)
		{
			yield return new WaitForEndOfFrame();
		}
		if (level != 7)
		{
			yield return new WaitForSeconds(0.8f);
		}
		while (timer > 0f)
		{
			yield return new WaitForEndOfFrame();
			if (level == 7 && waittime > 0f)
			{
				yield return new WaitForSeconds(0.5f);
				while (waittime > 0f)
				{
					yield return new WaitForEndOfFrame();
					waittime -= Time.deltaTime;
					string _waitTime = ((((int)(waittime * 10f)).ToString().Length < 2) ? $"0{((int)(waittime * 10f)).ToString()}" : ((int)(waittime * 10f)).ToString());
					EnergyUISystem.GetEnergyUISystem.GetUIGameObject("ScoreCanvas/WaittimePanel/RawImage/MemoryTime").GetComponent<Text>().text = _waitTime.Insert(_waitTime.Length - 1, ".");
				}
				for (int i = 0; i < ballParent.childCount; i++)
				{
					if (ballParent.GetChild(i).gameObject.activeInHierarchy)
					{
						ballParent.GetChild(i).GetComponentInChildren<Renderer>().material = ballGrayMaterial;
					}
				}
				yield return new WaitForSeconds(0.5f);
				EnergyUISystem.GetEnergyUISystem.SetUIActive("ScoreCanvas/WaittimePanel", isActive: false);
				waittime = 0f;
			}
			while (status != GameStatus.gaming)
			{
				yield return new WaitForEndOfFrame();
			}
			timer -= Time.deltaTime;
			action(timer);
		}
		UnityEngine.Debug.Log("finish");
		StartCoroutine(OverLevel());
	}

	private void GetRandomColor(int handIndex)
	{
		List<int> list = new List<int>(enemyIndex);
		List<int> enemyRemoveIndex = new List<int>(new int[2] { 4, 5 });
		list.RemoveAll((int a) => enemyRemoveIndex.Contains(a));
		int num = ((handIndex == 0) ? leftBulletIndex : rightBulletIndex);
		int num2;
		if (list.Count == 0)
		{
			num2 = ((handIndex != 0) ? ((rightBulletIndex != -1) ? rightBulletIndex : 0) : ((leftBulletIndex != -1) ? leftBulletIndex : 0));
		}
		else
		{
			num2 = list[random.Next(list.Count)];
			int num3 = 0;
			while (num == num2 && num3 < 15)
			{
				num2 = list[random.Next(list.Count)];
				num3++;
			}
		}
		if (handIndex == 0)
		{
			leftBulletIndex = num2;
			SetGunColor(gunMaterials[0].material, leftHandController.GetComponentInChildren<LineRenderer>().material, gunColors[leftBulletIndex]);
		}
		else
		{
			rightBulletIndex = num2;
			SetGunColor(gunMaterials[1].material, rightHandController.GetComponentInChildren<LineRenderer>().material, gunColors[rightBulletIndex]);
		}
	}

	private void SetGunColor(Material gunMaterial, Material lineMaterial, Color color)
	{
		gunMaterial.SetColor("_BaseColor", color);
		lineMaterial.SetColor("_Color", color * Mathf.Pow(2f, intensity));
		lineMaterial.SetColor("_ColorBlend", color * Mathf.Pow(2f, intensity + 0.5f));
	}

	private void OnShootBullet(Vector3 bulletStartPos, Vector3 bulletDirection, int index, int handIndex)
	{
		if (handShake)
		{
			PXR_Input.SetControllerVibration(0.4f, 25, (handIndex != 0) ? PXR_Input.Controller.RightController : PXR_Input.Controller.LeftController);
		}
		ObjectType objectType = ObjectType.bullet_b;
		switch (index)
		{
		case 0:
			objectType = ObjectType.bullet_b;
			break;
		case 1:
			objectType = ObjectType.bullet_p;
			break;
		case 2:
			objectType = ObjectType.bullet_y;
			break;
		case 3:
			objectType = ObjectType.bullet_r;
			break;
		}
		int num = (int)objectType;
		BulletSystem component = PoolSystem.GetObjectFromPool(objectType, bullets[num], bulletParent).GetComponent<BulletSystem>();
		component.gameObject.name = index.ToString();
		component.transform.position = bulletStartPos;
		component.transform.up = bulletDirection;
		component.transform.GetChild(0).GetChild(0).GetComponent<AudioSource>()
			.volume = efmVolume;
		component.transform.GetChild(0).GetChild(1).GetComponent<AudioSource>()
			.volume = efmVolume;
		component.InitBullet(25f, 3f);
		component.StartFly();
		GameObject gameObject = UnityEngine.Object.Instantiate(gunShootPar, (handIndex == 0) ? leftGun.transform.Find("BulletStart") : rightGun.transform.Find("BulletStart"));
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = Quaternion.identity;
		gameObject.GetComponent<ParticleSystem>().startColor = gunColors[index];
		gameObject.SetActive(value: true);
		UnityEngine.Object.Destroy(gameObject, 2f);
		GetRandomColor(handIndex);
	}
}
public class GunsSystem : MonoBehaviour
{
	private PXR_BaseInput baseleftinput;

	private PXR_BaseInput baserightinput;

	public GunsSystem(XRController leftController, XRController rightController)
	{
		baseleftinput = new PXR_BaseInput(leftController);
		baserightinput = new PXR_BaseInput(rightController);
	}

	public bool GainRightHandShoot()
	{
		return baserightinput.GetPXR_KeyCodeInput(PXR_KeyCodeClick.Trigger) || Input.GetKey(KeyCode.L);
	}

	public bool GainLeftHandShoot()
	{
		return baseleftinput.GetPXR_KeyCodeInput(PXR_KeyCodeClick.Trigger) || Input.GetKey(KeyCode.A);
	}

	public bool GainHandPause()
	{
		return baseleftinput.GetPXR_KeyCodeInput(PXR_KeyCodeClick.Y) || baserightinput.GetPXR_KeyCodeInput(PXR_KeyCodeClick.B) || Input.GetKeyDown(KeyCode.B);
	}
}
public class InteractiveUIBased : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
	public virtual void OnPointerClick(PointerEventData eventData)
	{
		SetVibration(0.5f);
	}

	public virtual void OnPointerDown(PointerEventData eventData)
	{
	}

	public virtual void OnPointerEnter(PointerEventData eventData)
	{
		SetVibration(0.2f);
	}

	public virtual void OnPointerExit(PointerEventData eventData)
	{
	}

	public virtual void OnPointerUp(PointerEventData eventData)
	{
	}

	public void SetVibration(float strength = 1f, int time = 100)
	{
		MonoSingleton<Controller_Interact>.Instance.OnHandleShake(strength, time);
	}
}
public delegate void MessageDispatchDelegate(MessageTypes mt);
public class MessageDispatch
{
	private static MessageDispatch instance;

	private Hashtable listeners = new Hashtable();

	public static MessageDispatch GetInstance()
	{
		if (instance == null)
		{
			instance = new MessageDispatch();
		}
		return instance;
	}

	public void AddEventListener(MEventType eventType, MessageDispatchDelegate listener)
	{
		MessageDispatchDelegate a = listeners[eventType] as MessageDispatchDelegate;
		a = (MessageDispatchDelegate)Delegate.Combine(a, listener);
		listeners[eventType] = a;
	}

	public void RemoveEventListener(MEventType eventType, MessageDispatchDelegate listener)
	{
		MessageDispatchDelegate messageDispatchDelegate = listeners[eventType] as MessageDispatchDelegate;
		if (messageDispatchDelegate != null)
		{
			messageDispatchDelegate = (MessageDispatchDelegate)Delegate.Remove(messageDispatchDelegate, listener);
		}
		listeners[eventType] = messageDispatchDelegate;
	}

	public void AddEventListener(string eventName, MessageDispatchDelegate listener)
	{
		MessageDispatchDelegate a = listeners[eventName] as MessageDispatchDelegate;
		a = (MessageDispatchDelegate)Delegate.Combine(a, listener);
		listeners[eventName] = a;
	}

	public void RemoveEventListener(string eventName, MessageDispatchDelegate listener)
	{
		MessageDispatchDelegate messageDispatchDelegate = listeners[eventName] as MessageDispatchDelegate;
		if (messageDispatchDelegate != null)
		{
			messageDispatchDelegate = (MessageDispatchDelegate)Delegate.Remove(messageDispatchDelegate, listener);
		}
		listeners[eventName] = messageDispatchDelegate;
	}

	public void DispatchEventOnce(MessageTypes evt)
	{
		MessageDispatchDelegate messageDispatchDelegate = ((!string.IsNullOrEmpty(evt.EventName)) ? (listeners[evt.EventName] as MessageDispatchDelegate) : (listeners[evt.Type] as MessageDispatchDelegate));
		if (messageDispatchDelegate == null)
		{
			return;
		}
		try
		{
			messageDispatchDelegate(evt);
			if (string.IsNullOrEmpty(evt.EventName))
			{
				listeners.Remove(evt.Type);
			}
			else
			{
				listeners.Remove(evt.EventName);
			}
		}
		catch (Exception ex)
		{
			throw new Exception("Error dispatching event " + evt.Type.ToString() + ": " + ex.Message + " " + ex.StackTrace, ex);
		}
	}

	public void DispatchEvent(MessageTypes evt)
	{
		if (listeners[evt.Type] is MessageDispatchDelegate messageDispatchDelegate)
		{
			try
			{
				messageDispatchDelegate(evt);
			}
			catch (Exception ex)
			{
				throw new Exception("Error dispatching event " + evt.Type.ToString() + ": " + ex.Message + " " + ex.StackTrace, ex);
			}
		}
	}

	public void DispatchStringEvent(MessageTypes evt)
	{
		if (listeners[evt.EventName] is MessageDispatchDelegate messageDispatchDelegate)
		{
			try
			{
				messageDispatchDelegate(evt);
			}
			catch (Exception ex)
			{
				throw new Exception("Error dispatching event " + evt.Type.ToString() + ": " + ex.Message + " " + ex.StackTrace, ex);
			}
		}
	}

	public void RemoveAll()
	{
		listeners.Clear();
	}
}
public enum MEventType
{
	GAME_OVER,
	GAME_WIN,
	PAUSE,
	GAME_DATA,
	SCORE
}
public class MessageTypes
{
	protected Hashtable arguments;

	protected MEventType type;

	protected object sender;

	protected string eventName;

	public MEventType Type
	{
		get
		{
			return type;
		}
		set
		{
			type = value;
		}
	}

	public IDictionary Params
	{
		get
		{
			return arguments;
		}
		set
		{
			arguments = value as Hashtable;
		}
	}

	public object Sender
	{
		get
		{
			return sender;
		}
		set
		{
			sender = value;
		}
	}

	public string EventName
	{
		get
		{
			return eventName;
		}
		set
		{
			eventName = value;
		}
	}

	public override string ToString()
	{
		return string.Concat(type, "{", (sender == null) ? "null" : sender.ToString(), "}");
	}

	public MessageTypes Clone()
	{
		return new MessageTypes(type, arguments, Sender);
	}

	public MessageTypes(MEventType type, object sender)
	{
		Type = type;
		Sender = sender;
		if (arguments == null)
		{
			arguments = new Hashtable();
		}
	}

	public MessageTypes(MEventType type, Hashtable args, object sender)
	{
		Type = type;
		arguments = args;
		Sender = sender;
		if (arguments == null)
		{
			arguments = new Hashtable();
		}
	}

	public MessageTypes(string eventName, object sender)
	{
		EventName = eventName;
		Sender = sender;
		if (arguments == null)
		{
			arguments = new Hashtable();
		}
	}
}
public enum ObjectType
{
	bullet_b,
	bullet_p,
	bullet_y,
	bullet_r,
	normalball,
	intermediateball,
	seniorball
}
public struct ObjectSttribute
{
	public GameObject gameobject;

	public float movespeed;

	public Vector3 objectscale;

	public int durable;
}
public class PoolSystem : MonoBehaviour
{
	public static Dictionary<ObjectType, List<GameObject>> mPoolDic = new Dictionary<ObjectType, List<GameObject>>();

	public static void InitObjectPool(ObjectType type, GameObject prefab, int count, Transform parent)
	{
		if (!mPoolDic.ContainsKey(type))
		{
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < count; i++)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(prefab, parent);
				if (prefab.tag == "Missile")
				{
					GameObject obj = gameObject;
					int num = (int)type;
					obj.name = num.ToString();
				}
				else
				{
					gameObject.SetActive(value: false);
				}
				gameObject.transform.localPosition = Vector3.zero;
				list.Add(gameObject);
			}
			mPoolDic.Add(type, list);
			return;
		}
		for (int j = 0; j < count; j++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(prefab, parent);
			if (prefab.tag == "Missile")
			{
				GameObject obj2 = gameObject;
				int num = (int)type;
				obj2.name = num.ToString();
			}
			else
			{
				gameObject.SetActive(value: false);
			}
			mPoolDic[type].Add(gameObject);
		}
	}

	public static GameObject GetObjectFromPool(ObjectType type, GameObject prefab, Transform parent)
	{
		GameObject gameObject = null;
		List<GameObject> value = new List<GameObject>();
		mPoolDic.TryGetValue(type, out value);
		foreach (GameObject item in value)
		{
			if (!item.transform.GetChild(0).gameObject.activeInHierarchy)
			{
				gameObject = item;
				break;
			}
		}
		if (gameObject == null && value.Count > 0)
		{
			gameObject = UnityEngine.Object.Instantiate(prefab, parent);
		}
		return gameObject;
	}
}
public class ReadXmlSettings : MonoBehaviour
{
	private XmlDocument document;

	private Hashtable hashtable;

	public ReadXmlSettings(Stream xmlPath, bool ignoreComments = true)
	{
		document = new XmlDocument();
		XmlReader xmlReader = XmlReader.Create(xmlPath, new XmlReaderSettings
		{
			IgnoreComments = ignoreComments
		});
		document.Load(xmlReader);
		xmlReader.Close();
	}

	public Hashtable GetSettings()
	{
		return hashtable;
	}

	public bool ReadLevel(string path)
	{
		hashtable = new Hashtable();
		XmlNodeList xmlNodeList = document.SelectNodes($"/root/{path}/difficulty/content");
		int num = 0;
		for (int i = 0; i < xmlNodeList.Count; i++)
		{
			if (xmlNodeList[i].Attributes["id"].Value == "index")
			{
				num++;
			}
			else
			{
				hashtable.Add(xmlNodeList[i].Attributes["id"].Value + num, xmlNodeList[i].Attributes["value"].Value);
			}
		}
		return hashtable.Count > 0;
	}

	public bool ReadDescript()
	{
		hashtable = new Hashtable();
		XmlNodeList xmlNodeList = document.SelectNodes("/root/descript/content");
		int num = 0;
		for (int i = 0; i < xmlNodeList.Count; i++)
		{
			hashtable.Add(xmlNodeList[i].Attributes["id"].Value, xmlNodeList[i].Attributes["value"].Value);
		}
		return hashtable.Count > 0;
	}
}
public class EventSystemBased : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler
{
	protected bool isClick;

	public GameObject GetCurrentGameObject()
	{
		return base.gameObject;
	}

	public virtual void OnPointerClick(PointerEventData eventData)
	{
		isClick = true;
	}

	public virtual void OnPointerDown(PointerEventData eventData)
	{
	}

	public virtual void OnPointerEnter(PointerEventData eventData)
	{
	}

	public virtual void OnPointerExit(PointerEventData eventData)
	{
		isClick = false;
	}

	public virtual void OnPointerUp(PointerEventData eventData)
	{
	}
}
public class PXR_BaseInput : MonoBehaviour
{
	private XRController controller;

	public PXR_BaseInput(XRController controller)
	{
		this.controller = controller;
	}

	public bool GetPXR_KeyCodeInput(PXR_KeyCodeClick key_code)
	{
		InputFeatureUsage<bool> usage = UnityEngine.XR.CommonUsages.triggerButton;
		switch (key_code)
		{
		case PXR_KeyCodeClick.A:
		case PXR_KeyCodeClick.X:
			usage = UnityEngine.XR.CommonUsages.primaryButton;
			break;
		case PXR_KeyCodeClick.B:
		case PXR_KeyCodeClick.Y:
			usage = UnityEngine.XR.CommonUsages.secondaryButton;
			break;
		case PXR_KeyCodeClick.Trigger:
			usage = UnityEngine.XR.CommonUsages.triggerButton;
			break;
		case PXR_KeyCodeClick.Grip:
			usage = UnityEngine.XR.CommonUsages.gripButton;
			break;
		case PXR_KeyCodeClick.JoystickClick:
			usage = UnityEngine.XR.CommonUsages.primary2DAxisClick;
			break;
		case PXR_KeyCodeClick.Menu:
			usage = UnityEngine.XR.CommonUsages.menuButton;
			break;
		}
		controller.inputDevice.TryGetFeatureValue(usage, out var value);
		return value;
	}
}
public enum PXR_KeyCodeClick
{
	A,
	B,
	X,
	Y,
	Menu,
	Trigger,
	Grip,
	JoystickClick
}
public class UISystemBased : MonoSingleton<UISystemBased>
{
	protected static Dictionary<string, GameObject> UIName_Path = new Dictionary<string, GameObject>();

	public virtual void Start()
	{
		UIName_Path.Clear();
	}

	public GameObject GetUIGameObject(string Name)
	{
		try
		{
			GameObject value = null;
			if (UIName_Path.ContainsKey(Name))
			{
				UIName_Path.TryGetValue(Name, out value);
			}
			else
			{
				string text = Name.Split('/')[0];
				UIName_Path.TryGetValue(text, out value);
				value = value.transform.Find(Name.Replace(text + "/", "")).gameObject;
			}
			return value;
		}
		catch
		{
			return null;
		}
	}

	public bool SetUIActive(string Name, bool isActive)
	{
		try
		{
			GameObject value = null;
			if (UIName_Path.ContainsKey(Name))
			{
				UIName_Path.TryGetValue(Name, out value);
			}
			else
			{
				string text = Name.Split('/')[0];
				UIName_Path.TryGetValue(text, out value);
				value = value.transform.Find(Name.Replace(text + "/", "")).gameObject;
			}
			value.SetActive(isActive);
			return true;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log(ex.Message + "：" + Name);
			return false;
		}
	}

	public bool SetParama(string Name, UnityAction[] onClickEvent)
	{
		try
		{
			GameObject value = null;
			if (UIName_Path.ContainsKey(Name))
			{
				UIName_Path.TryGetValue(Name, out value);
			}
			else
			{
				string text = Name.Split('/')[0];
				UIName_Path.TryGetValue(text, out value);
				value = value.transform.Find(Name.Replace(text + "/", "")).gameObject;
			}
			Button[] componentsInChildren = value.GetComponentsInChildren<Button>();
			if (componentsInChildren.Length != 0)
			{
				for (int i = 0; i < onClickEvent.Length; i++)
				{
					componentsInChildren[i].onClick.RemoveAllListeners();
					componentsInChildren[i].onClick.AddListener(onClickEvent[i]);
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log(ex.Message + "：" + Name);
			return false;
		}
	}

	public bool SetParama(string Name, UnityAction<bool>[] onClickEvent)
	{
		try
		{
			GameObject value = null;
			if (UIName_Path.ContainsKey(Name))
			{
				UIName_Path.TryGetValue(Name, out value);
			}
			else
			{
				string text = Name.Split('/')[0];
				UIName_Path.TryGetValue(text, out value);
				value = value.transform.Find(Name.Replace(text + "/", "")).gameObject;
			}
			Toggle[] componentsInChildren = value.GetComponentsInChildren<Toggle>();
			if (componentsInChildren.Length != 0)
			{
				for (int i = 0; i < onClickEvent.Length; i++)
				{
					componentsInChildren[i].onValueChanged.RemoveAllListeners();
					componentsInChildren[i].onValueChanged.AddListener(onClickEvent[i]);
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log(ex.Message + "：" + Name);
			return false;
		}
	}

	public bool SetParama(string Name, UnityAction<float>[] onClickEvent)
	{
		try
		{
			GameObject value = null;
			if (UIName_Path.ContainsKey(Name))
			{
				UIName_Path.TryGetValue(Name, out value);
			}
			else
			{
				string text = Name.Split('/')[0];
				UIName_Path.TryGetValue(text, out value);
				value = value.transform.Find(Name.Replace(text + "/", "")).gameObject;
			}
			Slider[] componentsInChildren = value.GetComponentsInChildren<Slider>();
			if (componentsInChildren.Length != 0)
			{
				for (int i = 0; i < onClickEvent.Length; i++)
				{
					componentsInChildren[i].onValueChanged.RemoveAllListeners();
					componentsInChildren[i].onValueChanged.AddListener(onClickEvent[i]);
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log(ex.Message + "：" + Name);
			return false;
		}
	}

	public bool SetParama(string Name, string[] texts)
	{
		try
		{
			GameObject value = null;
			if (UIName_Path.ContainsKey(Name))
			{
				UIName_Path.TryGetValue(Name, out value);
			}
			else
			{
				string text = Name.Split('/')[0];
				UIName_Path.TryGetValue(text, out value);
				value = value.transform.Find(Name.Replace(text + "/", "")).gameObject;
			}
			Text[] componentsInChildren = value.GetComponentsInChildren<Text>();
			if (componentsInChildren.Length != 0)
			{
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					componentsInChildren[i].text = texts[i];
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.Log(ex.Message + "：" + Name);
			return false;
		}
	}
}
public class SceneAsyncLoad : MonoBehaviour
{
	[SerializeField]
	private GameObject SceneEnergy;

	[SerializeField]
	private GameObject SceneDecom;

	[SerializeField]
	private GameObject GlobalUI;

	[SerializeField]
	private RawImage Loadimg;

	private static SceneAsyncLoad instance = null;

	private static List<Texture2D> loadtexturebytes = new List<Texture2D>();

	public static Texture2D[] GetRotateTexture => loadtexturebytes.ToArray();

	public static SceneAsyncLoad Instance
	{
		get
		{
			if (instance == null)
			{
				instance = UnityEngine.Object.FindObjectOfType<SceneAsyncLoad>();
			}
			if (instance == null)
			{
				instance = new GameObject().AddComponent<SceneAsyncLoad>();
			}
			return instance;
		}
	}

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		}
		if (instance != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (loadtexturebytes.Count == 0)
		{
			StartCoroutine(LoadFromAssetsBundle());
		}
	}

	private IEnumerator LoadFromAssetsBundle()
	{
		string url = Application.streamingAssetsPath + "/loadtexture";
		UnityWebRequest request = UnityWebRequestAssetBundle.GetAssetBundle(url);
		yield return request.SendWebRequest();
		AssetBundle ab = DownloadHandlerAssetBundle.GetContent(request);
		string[] names = ab.GetAllAssetNames();
		string[] array = names;
		foreach (string name in array)
		{
			loadtexturebytes.Add(ab.LoadAsset<Texture2D>(name));
		}
	}

	private void Update()
	{
		if (XRSettings.eyeTextureResolutionScale != 1.4f)
		{
			XRSettings.eyeTextureResolutionScale = 1.4f;
		}
	}

	public void LoadDiffScene(int k)
	{
		if (k == 1)
		{
			MonoSingleton<Controller_Loading>.Instance.StartChangeScene(delegate
			{
				GlobalUI.SetActive(value: true);
			}, delegate
			{
				SceneEnergy.SetActive(value: true);
				SceneDecom.SetActive(value: false);
			}, delegate
			{
			}, delegate
			{
				GlobalUI.SetActive(value: false);
			}, GlobalUI.transform.Find("OtherCanvas/LoadPanel").gameObject, Loadimg);
			return;
		}
		MonoSingleton<Controller_Loading>.Instance.StartBack(2, delegate
		{
			GlobalUI.SetActive(value: true);
		}, delegate
		{
			SceneEnergy.SetActive(value: false);
			SceneDecom.SetActive(value: true);
			SceneDecom.GetComponentInChildren<Controller_Main>().StartPlayVideo(0.05f);
		}, delegate
		{
			GlobalUI.SetActive(value: false);
		});
	}
}
public class Entry : MonoBehaviour
{
	private void OnGUI()
	{
		if (GUI.Button(new Rect(150f, 100f, 500f, 100f), "AnalyticsEntry"))
		{
			Application.LoadLevel("AnalyticsEntry");
		}
		if (GUI.Button(new Rect(150f, 300f, 500f, 100f), "Push"))
		{
			Application.LoadLevel("PushDemo");
		}
		if (GUI.Button(new Rect(150f, 500f, 500f, 100f), "Social"))
		{
			Application.LoadLevel("SocialDemo");
		}
	}
}
public class UmengGameExample : MonoBehaviour
{
	private void Start()
	{
		Analytics.StartWithAppKeyAndChannelId("59892f08310c9307b60023d0", "umeng");
		Analytics.SetLogEnabled(UnityEngine.Debug.isDebugBuild);
	}

	private void OnGUI()
	{
		int num = 150;
		int num2 = 50;
		int num3 = 500;
		int num4 = 100;
		int num5 = 150;
		if (GUI.Button(new Rect(num, num2, num3, num4), "StartLevel1"))
		{
			GA.StartLevel("level1");
		}
		num2 += num5;
		if (GUI.Button(new Rect(num, num2, num3, num4), "FinishLevel"))
		{
			GA.FinishLevel("level1");
		}
		num2 += num5;
		if (GUI.Button(new Rect(num, num2, num3, num4), "Bonus"))
		{
			GA.Bonus(10.0, GA.BonusSource.Source10);
		}
		num2 += num5;
		if (GUI.Button(new Rect(num, num2, num3, num4), "Pay"))
		{
			GA.Pay(19.0, GA.PaySource.Source10, 10.0);
		}
		num2 += num5;
		if (GUI.Button(new Rect(num, num2, num3, num4), "Event"))
		{
			Analytics.Event("event1");
		}
		num2 += num5;
		if (GUI.Button(new Rect(num, num2, num3, num4), "EventLabel"))
		{
			Analytics.Event("event1", "label");
		}
		num2 += num5;
		if (GUI.Button(new Rect(num, num2, num3, num4), "EventDict"))
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("key", "value");
			Analytics.Event("event1", dictionary);
		}
		num2 += num5;
	}
}
public class UmengAndroidLifeCycleCallBack : MonoBehaviour
{
	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	private void OnApplicationPause(bool isPause)
	{
		if (isPause)
		{
			Analytics.onPause();
		}
		else
		{
			Analytics.onResume();
		}
	}

	private void OnApplicationQuit()
	{
		Analytics.onKillProcess();
	}
}
namespace Umeng
{
	public class Analytics
	{
		public enum DeviceType
		{
			Phone,
			Box
		}

		private static bool hasInit = false;

		protected static AndroidJavaClass UMConfigure = new AndroidJavaClass("com.umeng.commonsdk.UMConfigure");

		protected static AndroidJavaClass Agent = new AndroidJavaClass("com.umeng.analytics.game.UMGameAgent");

		protected static AndroidJavaObject Context = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");

		private const string Version = "3.2";

		public static void StartWithAppKeyAndChannelId(string appKey, string channelId)
		{
			UMCommonSetAppkeyAndChannel(appKey, channelId);
			Agent.CallStatic("init", Context);
			if (!hasInit)
			{
				onResume();
				AddUmengAndroidLifeCycleCallBack();
				hasInit = true;
			}
		}

		private static void UMCommonSetAppkeyAndChannel(string appkey, string channelId, DeviceType deviceType = DeviceType.Phone, string pushSecret = null)
		{
			UMConfigure.CallStatic("setWraperType", "Unity", "3.2");
			UMConfigure.CallStatic("init", Context, appkey, channelId, (int)deviceType, pushSecret);
		}

		public static void SetLogEnabled(bool value)
		{
			UMConfigure.CallStatic("setLogEnabled", value);
		}

		public static void Event(string eventId)
		{
			Agent.CallStatic("onEvent", Context, eventId);
		}

		public static void Event(string eventId, string label)
		{
			Agent.CallStatic("onEvent", Context, eventId, label);
		}

		public static void Event(string eventId, Dictionary<string, string> attributes)
		{
			Agent.CallStatic("onEvent", Context, eventId, ToJavaHashMap(attributes));
		}

		public static void PageBegin(string pageName)
		{
			Agent.CallStatic("onPageStart", pageName);
		}

		public static void PageEnd(string pageName)
		{
			Agent.CallStatic("onPageEnd", pageName);
		}

		public static void Event(string eventId, Dictionary<string, string> attributes, int value)
		{
			try
			{
				if (attributes == null)
				{
					attributes = new Dictionary<string, string>();
				}
				if (attributes.ContainsKey("__ct__"))
				{
					attributes["__ct__"] = value.ToString();
					Event(eventId, attributes);
				}
				else
				{
					attributes.Add("__ct__", value.ToString());
					Event(eventId, attributes);
					attributes.Remove("__ct__");
				}
			}
			catch (Exception)
			{
			}
		}

		public static string GetTestDeviceInfo()
		{
			UnityEngine.Debug.Log("GetDeviceInfo return ");
			return UMConfigure.CallStatic<string[]>("getTestDeviceInfo", new object[1] { Context })[0];
		}

		public static void SetLogEncryptEnabled(bool value)
		{
			UMConfigure.CallStatic("setEncryptEnabled", value);
		}

		public static void SetLatency(int value)
		{
			Agent.CallStatic("setLatencyWindow", (long)value);
		}

		public static void SetContinueSessionMillis(long milliseconds)
		{
			Agent.CallStatic("setSessionContinueMillis", milliseconds);
		}

		public static void SetCheckDevice(bool value)
		{
			Agent.CallStatic("setCheckDevice", value);
		}

		private static void AddUmengAndroidLifeCycleCallBack()
		{
			GameObject gameObject = new GameObject();
			gameObject.AddComponent<UmengAndroidLifeCycleCallBack>();
			gameObject.name = "UmengManager";
		}

		public static void onResume()
		{
			Agent.CallStatic("onResume", Context);
		}

		public static void onPause()
		{
			Agent.CallStatic("onPause", Context);
		}

		public static void onKillProcess()
		{
			Agent.CallStatic("onKillProcess", Context);
		}

		private static AndroidJavaObject AndroidJavaJsonObject(JSONObject jSONObject)
		{
			return new AndroidJavaObject("org.json.JSONObject", jSONObject.ToString());
		}

		private static JSONObject jsonObjectFromJava(AndroidJavaObject androidJavaJsonObject)
		{
			return (JSONObject)JSONNode.Parse(androidJavaJsonObject.Call<string>("toString", Array.Empty<object>()));
		}

		private static AndroidJavaObject ToJavaObject(object obj)
		{
			if (obj is int)
			{
				return new AndroidJavaObject("java.lang.Integer", obj);
			}
			if (obj is long)
			{
				return new AndroidJavaObject("java.lang.Long", obj);
			}
			if (obj is float)
			{
				return new AndroidJavaObject("java.lang.Float", obj);
			}
			if (obj is double)
			{
				return new AndroidJavaObject("java.lang.Double", obj);
			}
			if (obj is string)
			{
				return new AndroidJavaObject("java.lang.String", obj);
			}
			if (obj is bool)
			{
				return new AndroidJavaObject("java.lang.Integer", Convert.ToInt32((bool)obj));
			}
			UnityEngine.Debug.Log(string.Concat("不支持加入", obj.GetType(), "类型,此kv对被丢弃"));
			return null;
		}

		private static AndroidJavaObject ToJavaHashMap(Dictionary<string, object> dic)
		{
			AndroidJavaObject androidJavaObject = new AndroidJavaObject("java.util.HashMap");
			foreach (KeyValuePair<string, object> item in dic)
			{
				AndroidJavaObject androidJavaObject2 = ToJavaObject(item.Value);
				if (androidJavaObject2 != null)
				{
					androidJavaObject.Call<AndroidJavaObject>("put", new object[2] { item.Key, androidJavaObject2 });
				}
			}
			return androidJavaObject;
		}

		private static AndroidJavaObject ToJavaHashMap(Dictionary<string, string> dic)
		{
			AndroidJavaObject androidJavaObject = new AndroidJavaObject("java.util.HashMap");
			foreach (KeyValuePair<string, string> item in dic)
			{
				androidJavaObject.Call<AndroidJavaObject>("put", new object[2] { item.Key, item.Value });
			}
			return androidJavaObject;
		}

		private static AndroidJavaObject ToJavaList(string[] list)
		{
			AndroidJavaObject androidJavaObject = new AndroidJavaObject("java.util.ArrayList");
			foreach (string text in list)
			{
				androidJavaObject.Call<bool>("add", new object[1] { text });
			}
			return androidJavaObject;
		}

		public static void EventObject(string eventID, Dictionary<string, object> dict)
		{
			Agent.CallStatic("onEventObject", Context, eventID, ToJavaHashMap(dict));
		}

		public static void RegisterPreProperties(JSONObject jsonObject)
		{
			JSONObject jSONObject = new JSONObject();
			foreach (KeyValuePair<string, JSONNode> item in jsonObject)
			{
				if (item.Value.IsObject || item.Value.IsArray)
				{
					UnityEngine.Debug.LogError("不支持加入Object/Array类型,此kv对被丢弃");
				}
				else if (item.Value.IsBoolean)
				{
					jSONObject.Add(item.Key, Convert.ToInt32(item.Value.AsBool));
				}
				else
				{
					jSONObject.Add(item.Key, item.Value);
				}
			}
			Agent.CallStatic("registerPreProperties", Context, AndroidJavaJsonObject(jSONObject));
		}

		public static void UnregisterPreProperty(string propertyName)
		{
			Agent.CallStatic("unregisterPreProperty", Context, propertyName);
		}

		public static JSONObject GetPreProperties()
		{
			return jsonObjectFromJava(Agent.CallStatic<AndroidJavaObject>("getPreProperties", new object[1] { Context }));
		}

		public static void ClearPreProperties()
		{
			Agent.CallStatic("clearPreProperties", Context);
		}

		public static void SetFirstLaunchEvent(string[] trackID)
		{
			Agent.CallStatic("setFirstLaunchEvent", Context, ToJavaList(trackID));
		}
	}
	public class GA : Analytics
	{
		public enum Gender
		{
			Unknown,
			Male,
			Female
		}

		public enum PaySource
		{
			AppStore = 1,
			支付宝,
			网银,
			财付通,
			移动,
			联通,
			电信,
			Paypal,
			Source9,
			Source10,
			Source11,
			Source12,
			Source13,
			Source14,
			Source15,
			Source16,
			Source17,
			Source18,
			Source19,
			Source20,
			Source21,
			Source22,
			Source23,
			Source24,
			Source25,
			Source26,
			Source27,
			Source28,
			Source29,
			Source30
		}

		public enum BonusSource
		{
			玩家赠送 = 1,
			Source2,
			Source3,
			Source4,
			Source5,
			Source6,
			Source7,
			Source8,
			Source9,
			Source10
		}

		public static void SetUserLevel(int level)
		{
			Analytics.Agent.CallStatic("setPlayerLevel", level);
		}

		[Obsolete("SetUserInfo已弃用, 请使用ProfileSignIn")]
		public static void SetUserInfo(string userId, Gender gender, int age, string platform)
		{
			Analytics.Agent.CallStatic("setPlayerInfo", userId, age, (int)gender, platform);
		}

		public static void StartLevel(string level)
		{
			Analytics.Agent.CallStatic("startLevel", level);
		}

		public static void FinishLevel(string level)
		{
			Analytics.Agent.CallStatic("finishLevel", level);
		}

		public static void FailLevel(string level)
		{
			Analytics.Agent.CallStatic("failLevel", level);
		}

		public static void Pay(double cash, PaySource source, double coin)
		{
			Analytics.Agent.CallStatic("pay", cash, coin, (int)source);
		}

		public static void Pay(double cash, int source, double coin)
		{
			if (source < 1 || source > 100)
			{
				throw new ArgumentException();
			}
			Analytics.Agent.CallStatic("pay", cash, coin, source);
		}

		public static void Pay(double cash, PaySource source, string item, int amount, double price)
		{
			Analytics.Agent.CallStatic("pay", cash, item, amount, price, (int)source);
		}

		public static void Buy(string item, int amount, double price)
		{
			Analytics.Agent.CallStatic("buy", item, amount, price);
		}

		public static void Use(string item, int amount, double price)
		{
			Analytics.Agent.CallStatic("use", item, amount, price);
		}

		public static void Bonus(double coin, BonusSource source)
		{
			Analytics.Agent.CallStatic("bonus", coin, (int)source);
		}

		public static void Bonus(string item, int amount, double price, BonusSource source)
		{
			Analytics.Agent.CallStatic("bonus", item, amount, price, (int)source);
		}

		public static void ProfileSignIn(string userId)
		{
			Analytics.Agent.CallStatic("onProfileSignIn", userId);
		}

		public static void ProfileSignIn(string userId, string provider)
		{
			Analytics.Agent.CallStatic("onProfileSignIn", provider, userId);
		}

		public static void ProfileSignOff()
		{
			Analytics.Agent.CallStatic("onProfileSignOff");
		}
	}
	public enum JSONNodeType
	{
		Array = 1,
		Object,
		String,
		Number,
		NullValue,
		Boolean,
		None
	}
	public abstract class JSONNode
	{
		internal static StringBuilder m_EscapeBuilder = new StringBuilder();

		public virtual JSONNode this[int aIndex]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual JSONNode this[string aKey]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string Value
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public virtual int Count => 0;

		public virtual bool IsNumber => false;

		public virtual bool IsString => false;

		public virtual bool IsBoolean => false;

		public virtual bool IsNull => false;

		public virtual bool IsArray => false;

		public virtual bool IsObject => false;

		public virtual IEnumerable<JSONNode> Children
		{
			get
			{
				yield break;
			}
		}

		public IEnumerable<JSONNode> DeepChildren
		{
			get
			{
				foreach (JSONNode C in Children)
				{
					foreach (JSONNode deepChild in C.DeepChildren)
					{
						yield return deepChild;
					}
				}
			}
		}

		public abstract JSONNodeType Tag { get; }

		public virtual double AsDouble
		{
			get
			{
				double result = 0.0;
				if (double.TryParse(Value, out result))
				{
					return result;
				}
				return 0.0;
			}
			set
			{
				Value = value.ToString();
			}
		}

		public virtual int AsInt
		{
			get
			{
				return (int)AsDouble;
			}
			set
			{
				AsDouble = value;
			}
		}

		public virtual float AsFloat
		{
			get
			{
				return (float)AsDouble;
			}
			set
			{
				AsDouble = value;
			}
		}

		public virtual bool AsBool
		{
			get
			{
				bool result = false;
				if (bool.TryParse(Value, out result))
				{
					return result;
				}
				return !string.IsNullOrEmpty(Value);
			}
			set
			{
				Value = (value ? "true" : "false");
			}
		}

		public virtual JSONArray AsArray => this as JSONArray;

		public virtual JSONObject AsObject => this as JSONObject;

		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		public virtual void Add(JSONNode aItem)
		{
			Add("", aItem);
		}

		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		public virtual JSONNode Remove(JSONNode aNode)
		{
			return aNode;
		}

		public override string ToString()
		{
			return "JSONNode";
		}

		public virtual string ToString(string aIndent)
		{
			return ToString(aIndent, "");
		}

		internal abstract string ToString(string aIndent, string aPrefix);

		public static implicit operator JSONNode(string s)
		{
			return new JSONString(s);
		}

		public static implicit operator string(JSONNode d)
		{
			return (d == null) ? null : d.Value;
		}

		public static implicit operator JSONNode(double n)
		{
			return new JSONNumber(n);
		}

		public static implicit operator double(JSONNode d)
		{
			return (d == null) ? 0.0 : d.AsDouble;
		}

		public static implicit operator JSONNode(float n)
		{
			return new JSONNumber(n);
		}

		public static implicit operator float(JSONNode d)
		{
			return (d == null) ? 0f : d.AsFloat;
		}

		public static implicit operator JSONNode(int n)
		{
			return new JSONNumber(n);
		}

		public static implicit operator int(JSONNode d)
		{
			return (!(d == null)) ? d.AsInt : 0;
		}

		public static implicit operator JSONNode(bool b)
		{
			return new JSONBool(b);
		}

		public static implicit operator bool(JSONNode d)
		{
			return !(d == null) && d.AsBool;
		}

		public static bool operator ==(JSONNode a, object b)
		{
			if ((object)a == b)
			{
				return true;
			}
			bool flag = a is JSONNull || (object)a == null || a is JSONLazyCreator;
			bool flag2 = b is JSONNull || b == null || b is JSONLazyCreator;
			return flag && flag2;
		}

		public static bool operator !=(JSONNode a, object b)
		{
			return !(a == b);
		}

		public override bool Equals(object obj)
		{
			return (object)this == obj;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		internal static string Escape(string aText)
		{
			m_EscapeBuilder.Length = 0;
			if (m_EscapeBuilder.Capacity < aText.Length + aText.Length / 10)
			{
				m_EscapeBuilder.Capacity = aText.Length + aText.Length / 10;
			}
			foreach (char c in aText)
			{
				switch (c)
				{
				case '\\':
					m_EscapeBuilder.Append("\\\\");
					break;
				case '"':
					m_EscapeBuilder.Append("\"");
					break;
				case '\n':
					m_EscapeBuilder.Append("\\n");
					break;
				case '\r':
					m_EscapeBuilder.Append("\\r");
					break;
				case '\t':
					m_EscapeBuilder.Append("\\t");
					break;
				case '\b':
					m_EscapeBuilder.Append("\\b");
					break;
				case '\f':
					m_EscapeBuilder.Append("\\f");
					break;
				default:
					m_EscapeBuilder.Append(c);
					break;
				}
			}
			string result = m_EscapeBuilder.ToString();
			m_EscapeBuilder.Length = 0;
			return result;
		}

		private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted)
		{
			if (quoted)
			{
				ctx.Add(tokenName, token);
				return;
			}
			string text = token.ToLower();
			double result;
			if (text == "false" || text == "true")
			{
				ctx.Add(tokenName, text == "true");
			}
			else if (text == "null")
			{
				ctx.Add(tokenName, null);
			}
			else if (double.TryParse(token, out result))
			{
				ctx.Add(tokenName, result);
			}
			else
			{
				ctx.Add(tokenName, token);
			}
		}

		public static JSONNode Parse(string aJSON)
		{
			Stack<JSONNode> stack = new Stack<JSONNode>();
			JSONNode jSONNode = null;
			int i = 0;
			StringBuilder stringBuilder = new StringBuilder();
			string text = "";
			bool flag = false;
			bool flag2 = false;
			for (; i < aJSON.Length; i++)
			{
				switch (aJSON[i])
				{
				case '{':
					if (flag)
					{
						stringBuilder.Append(aJSON[i]);
						break;
					}
					stack.Push(new JSONObject());
					if (jSONNode != null)
					{
						jSONNode.Add(text, stack.Peek());
					}
					text = "";
					stringBuilder.Length = 0;
					jSONNode = stack.Peek();
					break;
				case '[':
					if (flag)
					{
						stringBuilder.Append(aJSON[i]);
						break;
					}
					stack.Push(new JSONArray());
					if (jSONNode != null)
					{
						jSONNode.Add(text, stack.Peek());
					}
					text = "";
					stringBuilder.Length = 0;
					jSONNode = stack.Peek();
					break;
				case ']':
				case '}':
					if (flag)
					{
						stringBuilder.Append(aJSON[i]);
						break;
					}
					if (stack.Count == 0)
					{
						throw new Exception("JSON Parse: Too many closing brackets");
					}
					stack.Pop();
					if (stringBuilder.Length > 0)
					{
						ParseElement(jSONNode, stringBuilder.ToString(), text, flag2);
						flag2 = false;
					}
					text = "";
					stringBuilder.Length = 0;
					if (stack.Count > 0)
					{
						jSONNode = stack.Peek();
					}
					break;
				case ':':
					if (flag)
					{
						stringBuilder.Append(aJSON[i]);
						break;
					}
					text = stringBuilder.ToString().Trim();
					stringBuilder.Length = 0;
					flag2 = false;
					break;
				case '"':
					flag = !flag;
					flag2 = flag2 || flag;
					break;
				case ',':
					if (flag)
					{
						stringBuilder.Append(aJSON[i]);
						break;
					}
					if (stringBuilder.Length > 0)
					{
						ParseElement(jSONNode, stringBuilder.ToString(), text, flag2);
						flag2 = false;
					}
					text = "";
					stringBuilder.Length = 0;
					flag2 = false;
					break;
				case '\t':
				case ' ':
					if (flag)
					{
						stringBuilder.Append(aJSON[i]);
					}
					break;
				case '\\':
					i++;
					if (flag)
					{
						char c = aJSON[i];
						switch (c)
						{
						case 't':
							stringBuilder.Append('\t');
							break;
						case 'r':
							stringBuilder.Append('\r');
							break;
						case 'n':
							stringBuilder.Append('\n');
							break;
						case 'b':
							stringBuilder.Append('\b');
							break;
						case 'f':
							stringBuilder.Append('\f');
							break;
						case 'u':
						{
							string s = aJSON.Substring(i + 1, 4);
							stringBuilder.Append((char)int.Parse(s, NumberStyles.AllowHexSpecifier));
							i += 4;
							break;
						}
						default:
							stringBuilder.Append(c);
							break;
						}
					}
					break;
				default:
					stringBuilder.Append(aJSON[i]);
					break;
				case '\n':
				case '\r':
					break;
				}
			}
			if (flag)
			{
				throw new Exception("JSON Parse: Quotation marks seems to be messed up.");
			}
			return jSONNode;
		}

		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		public void SaveToStream(Stream aData)
		{
			BinaryWriter aWriter = new BinaryWriter(aData);
			Serialize(aWriter);
		}

		public void SaveToCompressedStream(Stream aData)
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		public void SaveToCompressedFile(string aFileName)
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		public string SaveToCompressedBase64()
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		public void SaveToFile(string aFileName)
		{
			Directory.CreateDirectory(new FileInfo(aFileName).Directory.FullName);
			using FileStream aData = File.OpenWrite(aFileName);
			SaveToStream(aData);
		}

		public string SaveToBase64()
		{
			using MemoryStream memoryStream = new MemoryStream();
			SaveToStream(memoryStream);
			memoryStream.Position = 0L;
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		public static JSONNode Deserialize(BinaryReader aReader)
		{
			JSONNodeType jSONNodeType = (JSONNodeType)aReader.ReadByte();
			switch (jSONNodeType)
			{
			case JSONNodeType.Array:
			{
				int num2 = aReader.ReadInt32();
				JSONArray jSONArray = new JSONArray();
				for (int j = 0; j < num2; j++)
				{
					jSONArray.Add(Deserialize(aReader));
				}
				return jSONArray;
			}
			case JSONNodeType.Object:
			{
				int num = aReader.ReadInt32();
				JSONObject jSONObject = new JSONObject();
				for (int i = 0; i < num; i++)
				{
					string aKey = aReader.ReadString();
					JSONNode aItem = Deserialize(aReader);
					jSONObject.Add(aKey, aItem);
				}
				return jSONObject;
			}
			case JSONNodeType.String:
				return new JSONString(aReader.ReadString());
			case JSONNodeType.Number:
				return new JSONNumber(aReader.ReadDouble());
			case JSONNodeType.Boolean:
				return new JSONBool(aReader.ReadBoolean());
			case JSONNodeType.NullValue:
				return new JSONNull();
			default:
				throw new Exception("Error deserializing JSON. Unknown tag: " + jSONNodeType);
			}
		}

		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		}

		public static JSONNode LoadFromStream(Stream aData)
		{
			using BinaryReader aReader = new BinaryReader(aData);
			return Deserialize(aReader);
		}

		public static JSONNode LoadFromFile(string aFileName)
		{
			using FileStream aData = File.OpenRead(aFileName);
			return LoadFromStream(aData);
		}

		public static JSONNode LoadFromBase64(string aBase64)
		{
			byte[] buffer = Convert.FromBase64String(aBase64);
			MemoryStream memoryStream = new MemoryStream(buffer);
			memoryStream.Position = 0L;
			return LoadFromStream(memoryStream);
		}
	}
	public class JSONArray : JSONNode, IEnumerable
	{
		private List<JSONNode> m_List = new List<JSONNode>();

		public override JSONNodeType Tag => JSONNodeType.Array;

		public override bool IsArray => true;

		public override JSONNode this[int aIndex]
		{
			get
			{
				if (aIndex < 0 || aIndex >= m_List.Count)
				{
					return new JSONLazyCreator(this);
				}
				return m_List[aIndex];
			}
			set
			{
				if (value == null)
				{
					value = new JSONNull();
				}
				if (aIndex < 0 || aIndex >= m_List.Count)
				{
					m_List.Add(value);
				}
				else
				{
					m_List[aIndex] = value;
				}
			}
		}

		public override JSONNode this[string aKey]
		{
			get
			{
				return new JSONLazyCreator(this);
			}
			set
			{
				if (value == null)
				{
					value = new JSONNull();
				}
				m_List.Add(value);
			}
		}

		public override int Count => m_List.Count;

		public override IEnumerable<JSONNode> Children
		{
			get
			{
				foreach (JSONNode item in m_List)
				{
					yield return item;
				}
			}
		}

		public override void Add(string aKey, JSONNode aItem)
		{
			if (aItem == null)
			{
				aItem = new JSONNull();
			}
			m_List.Add(aItem);
		}

		public override JSONNode Remove(int aIndex)
		{
			if (aIndex < 0 || aIndex >= m_List.Count)
			{
				return null;
			}
			JSONNode result = m_List[aIndex];
			m_List.RemoveAt(aIndex);
			return result;
		}

		public override JSONNode Remove(JSONNode aNode)
		{
			m_List.Remove(aNode);
			return aNode;
		}

		public IEnumerator GetEnumerator()
		{
			foreach (JSONNode item in m_List)
			{
				yield return item;
			}
		}

		public override string ToString()
		{
			string text = "[ ";
			foreach (JSONNode item in m_List)
			{
				if (text.Length > 2)
				{
					text += ", ";
				}
				text += item.ToString();
			}
			return text + " ]";
		}

		internal override string ToString(string aIndent, string aPrefix)
		{
			string text = "[ ";
			foreach (JSONNode item in m_List)
			{
				if (text.Length > 3)
				{
					text += ", ";
				}
				text = text + "\n" + aPrefix + aIndent + item.ToString(aIndent, aPrefix + aIndent);
			}
			return text + "\n" + aPrefix + "]";
		}

		public override void Serialize(BinaryWriter aWriter)
		{
			aWriter.Write((byte)1);
			aWriter.Write(m_List.Count);
			for (int i = 0; i < m_List.Count; i++)
			{
				m_List[i].Serialize(aWriter);
			}
		}
	}
	public class JSONObject : JSONNode, IEnumerable
	{
		private Dictionary<string, JSONNode> m_Dict = new Dictionary<string, JSONNode>();

		public override JSONNodeType Tag => JSONNodeType.Object;

		public override bool IsObject => true;

		public override JSONNode this[string aKey]
		{
			get
			{
				if (m_Dict.ContainsKey(aKey))
				{
					return m_Dict[aKey];
				}
				return new JSONLazyCreator(this, aKey);
			}
			set
			{
				if (value == null)
				{
					value = new JSONNull();
				}
				if (m_Dict.ContainsKey(aKey))
				{
					m_Dict[aKey] = value;
				}
				else
				{
					m_Dict.Add(aKey, value);
				}
			}
		}

		public override JSONNode this[int aIndex]
		{
			get
			{
				if (aIndex < 0 || aIndex >= m_Dict.Count)
				{
					return null;
				}
				return m_Dict.ElementAt(aIndex).Value;
			}
			set
			{
				if (value == null)
				{
					value = new JSONNull();
				}
				if (aIndex >= 0 && aIndex < m_Dict.Count)
				{
					string key = m_Dict.ElementAt(aIndex).Key;
					m_Dict[key] = value;
				}
			}
		}

		public override int Count => m_Dict.Count;

		public override IEnumerable<JSONNode> Children
		{
			get
			{
				foreach (KeyValuePair<string, JSONNode> item in m_Dict)
				{
					yield return item.Value;
				}
			}
		}

		public override void Add(string aKey, JSONNode aItem)
		{
			if (aItem == null)
			{
				aItem = new JSONNull();
			}
			if (!string.IsNullOrEmpty(aKey))
			{
				if (m_Dict.ContainsKey(aKey))
				{
					m_Dict[aKey] = aItem;
				}
				else
				{
					m_Dict.Add(aKey, aItem);
				}
			}
			else
			{
				m_Dict.Add(Guid.NewGuid().ToString(), aItem);
			}
		}

		public override JSONNode Remove(string aKey)
		{
			if (!m_Dict.ContainsKey(aKey))
			{
				return null;
			}
			JSONNode result = m_Dict[aKey];
			m_Dict.Remove(aKey);
			return result;
		}

		public override JSONNode Remove(int aIndex)
		{
			if (aIndex < 0 || aIndex >= m_Dict.Count)
			{
				return null;
			}
			KeyValuePair<string, JSONNode> keyValuePair = m_Dict.ElementAt(aIndex);
			m_Dict.Remove(keyValuePair.Key);
			return keyValuePair.Value;
		}

		public override JSONNode Remove(JSONNode aNode)
		{
			try
			{
				KeyValuePair<string, JSONNode> keyValuePair = m_Dict.Where((KeyValuePair<string, JSONNode> k) => k.Value == aNode).First();
				m_Dict.Remove(keyValuePair.Key);
				return aNode;
			}
			catch
			{
				return null;
			}
		}

		public IEnumerator GetEnumerator()
		{
			foreach (KeyValuePair<string, JSONNode> N in m_Dict)
			{
				yield return N;
			}
		}

		public override string ToString()
		{
			string text = "{";
			foreach (KeyValuePair<string, JSONNode> item in m_Dict)
			{
				if (text.Length > 2)
				{
					text += ", ";
				}
				text = text + "\"" + JSONNode.Escape(item.Key) + "\":" + item.Value.ToString();
			}
			return text + "}";
		}

		internal override string ToString(string aIndent, string aPrefix)
		{
			string text = "{ ";
			foreach (KeyValuePair<string, JSONNode> item in m_Dict)
			{
				if (text.Length > 3)
				{
					text += ", ";
				}
				text = text + "\n" + aPrefix + aIndent + "\"" + JSONNode.Escape(item.Key) + "\" : ";
				text += item.Value.ToString(aIndent, aPrefix + aIndent);
			}
			return text + "\n" + aPrefix + "}";
		}

		public override void Serialize(BinaryWriter aWriter)
		{
			aWriter.Write((byte)2);
			aWriter.Write(m_Dict.Count);
			foreach (string key in m_Dict.Keys)
			{
				aWriter.Write(key);
				m_Dict[key].Serialize(aWriter);
			}
		}
	}
	public class JSONString : JSONNode
	{
		private string m_Data;

		public override JSONNodeType Tag => JSONNodeType.String;

		public override bool IsString => true;

		public override string Value
		{
			get
			{
				return m_Data;
			}
			set
			{
				m_Data = value;
			}
		}

		public JSONString(string aData)
		{
			m_Data = aData;
		}

		public override string ToString()
		{
			return "\"" + JSONNode.Escape(m_Data) + "\"";
		}

		internal override string ToString(string aIndent, string aPrefix)
		{
			return "\"" + JSONNode.Escape(m_Data) + "\"";
		}

		public override void Serialize(BinaryWriter aWriter)
		{
			aWriter.Write((byte)3);
			aWriter.Write(m_Data);
		}
	}
	public class JSONNumber : JSONNode
	{
		private double m_Data;

		public override JSONNodeType Tag => JSONNodeType.Number;

		public override bool IsNumber => true;

		public override string Value
		{
			get
			{
				return m_Data.ToString();
			}
			set
			{
				if (double.TryParse(value, out var result))
				{
					m_Data = result;
				}
			}
		}

		public override double AsDouble
		{
			get
			{
				return m_Data;
			}
			set
			{
				m_Data = value;
			}
		}

		public JSONNumber(double aData)
		{
			m_Data = aData;
		}

		public JSONNumber(string aData)
		{
			Value = aData;
		}

		public override string ToString()
		{
			return m_Data.ToString();
		}

		internal override string ToString(string aIndent, string aPrefix)
		{
			return m_Data.ToString();
		}

		public override void Serialize(BinaryWriter aWriter)
		{
			aWriter.Write((byte)4);
			aWriter.Write(m_Data);
		}
	}
	public class JSONBool : JSONNode
	{
		private bool m_Data;

		public override JSONNodeType Tag => JSONNodeType.Boolean;

		public override bool IsBoolean => true;

		public override string Value
		{
			get
			{
				return m_Data.ToString();
			}
			set
			{
				if (bool.TryParse(value, out var result))
				{
					m_Data = result;
				}
			}
		}

		public override bool AsBool
		{
			get
			{
				return m_Data;
			}
			set
			{
				m_Data = value;
			}
		}

		public JSONBool(bool aData)
		{
			m_Data = aData;
		}

		public JSONBool(string aData)
		{
			Value = aData;
		}

		public override string ToString()
		{
			return m_Data ? "true" : "false";
		}

		internal override string ToString(string aIndent, string aPrefix)
		{
			return m_Data ? "true" : "false";
		}

		public override void Serialize(BinaryWriter aWriter)
		{
			aWriter.Write((byte)6);
			aWriter.Write(m_Data);
		}
	}
	public class JSONNull : JSONNode
	{
		public override JSONNodeType Tag => JSONNodeType.NullValue;

		public override bool IsNull => true;

		public override string Value
		{
			get
			{
				return "null";
			}
			set
			{
			}
		}

		public override bool AsBool
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return "null";
		}

		internal override string ToString(string aIndent, string aPrefix)
		{
			return "null";
		}

		public override bool Equals(object obj)
		{
			if ((object)this == obj)
			{
				return true;
			}
			return obj is JSONNull;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override void Serialize(BinaryWriter aWriter)
		{
			aWriter.Write((byte)5);
		}
	}
	internal class JSONLazyCreator : JSONNode
	{
		private JSONNode m_Node = null;

		private string m_Key = null;

		public override JSONNodeType Tag => JSONNodeType.None;

		public override JSONNode this[int aIndex]
		{
			get
			{
				return new JSONLazyCreator(this);
			}
			set
			{
				JSONArray jSONArray = new JSONArray();
				jSONArray.Add(value);
				Set(jSONArray);
			}
		}

		public override JSONNode this[string aKey]
		{
			get
			{
				return new JSONLazyCreator(this, aKey);
			}
			set
			{
				JSONObject jSONObject = new JSONObject();
				jSONObject.Add(aKey, value);
				Set(jSONObject);
			}
		}

		public override int AsInt
		{
			get
			{
				JSONNumber aVal = new JSONNumber(0.0);
				Set(aVal);
				return 0;
			}
			set
			{
				JSONNumber aVal = new JSONNumber(value);
				Set(aVal);
			}
		}

		public override float AsFloat
		{
			get
			{
				JSONNumber aVal = new JSONNumber(0.0);
				Set(aVal);
				return 0f;
			}
			set
			{
				JSONNumber aVal = new JSONNumber(value);
				Set(aVal);
			}
		}

		public override double AsDouble
		{
			get
			{
				JSONNumber aVal = new JSONNumber(0.0);
				Set(aVal);
				return 0.0;
			}
			set
			{
				JSONNumber aVal = new JSONNumber(value);
				Set(aVal);
			}
		}

		public override bool AsBool
		{
			get
			{
				JSONBool aVal = new JSONBool(aData: false);
				Set(aVal);
				return false;
			}
			set
			{
				JSONBool aVal = new JSONBool(value);
				Set(aVal);
			}
		}

		public override JSONArray AsArray
		{
			get
			{
				JSONArray jSONArray = new JSONArray();
				Set(jSONArray);
				return jSONArray;
			}
		}

		public override JSONObject AsObject
		{
			get
			{
				JSONObject jSONObject = new JSONObject();
				Set(jSONObject);
				return jSONObject;
			}
		}

		public JSONLazyCreator(JSONNode aNode)
		{
			m_Node = aNode;
			m_Key = null;
		}

		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
			m_Node = aNode;
			m_Key = aKey;
		}

		private void Set(JSONNode aVal)
		{
			if (m_Key == null)
			{
				m_Node.Add(aVal);
			}
			else
			{
				m_Node.Add(m_Key, aVal);
			}
			m_Node = null;
		}

		public override void Add(JSONNode aItem)
		{
			JSONArray jSONArray = new JSONArray();
			jSONArray.Add(aItem);
			Set(jSONArray);
		}

		public override void Add(string aKey, JSONNode aItem)
		{
			JSONObject jSONObject = new JSONObject();
			jSONObject.Add(aKey, aItem);
			Set(jSONObject);
		}

		public static bool operator ==(JSONLazyCreator a, object b)
		{
			if (b == null)
			{
				return true;
			}
			return (object)a == b;
		}

		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return !(a == b);
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return true;
			}
			return (object)this == obj;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return "";
		}

		internal override string ToString(string aIndent, string aPrefix)
		{
			return "";
		}
	}
	public static class JSON
	{
		public static JSONNode Parse(string aJSON)
		{
			return JSONNode.Parse(aJSON);
		}
	}
}
namespace CurvedUI
{
	public class CUI_AnimateCurvedFillOnStart : MonoBehaviour
	{
		private void Update()
		{
			CurvedUISettings component = GetComponent<CurvedUISettings>();
			Text componentInChildren = GetComponentInChildren<Text>();
			if (Time.time < 1.5f)
			{
				component.RingFill = Mathf.PerlinNoise(Time.time * 30.23234f, Time.time * 30.2313f) * 0.15f;
				componentInChildren.text = "Accesing Mainframe...";
			}
			else if (Time.time < 2.5f)
			{
				component.RingFill = Mathf.Clamp(component.RingFill + Time.deltaTime * 3f, 0f, 1f);
				componentInChildren.text = "Mainframe Active";
			}
		}
	}
	public class CUI_CameraController : MonoBehaviour
	{
		[SerializeField]
		private Transform CameraObject;

		[SerializeField]
		private float rotationMargin = 25f;

		[SerializeField]
		private bool runInEditorOnly = true;

		public static CUI_CameraController Instance;

		private void Awake()
		{
			Instance = this;
		}
	}
	public class CUI_CameraRotationOnButtonHeld : MonoBehaviour
	{
		[SerializeField]
		private float Sensitivity = 0.5f;

		private Vector2 _oldMousePos;

		private void Start()
		{
			_oldMousePos = CurvedUIInputModule.MousePosition;
		}
	}
	public class CUI_ChangeColor : MonoBehaviour
	{
		public void ChangeColorToBlue()
		{
			GetComponent<Renderer>().material.color = Color.blue;
		}

		public void ChangeColorToCyan()
		{
			GetComponent<Renderer>().material.color = Color.cyan;
		}

		public void ChangeColorToWhite()
		{
			GetComponent<Renderer>().material.color = Color.white;
		}
	}
	public class CUI_ChangeValueOnHold : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		private bool pressed = false;

		private bool selected = false;

		[SerializeField]
		private Image bg;

		[SerializeField]
		private Color SelectedColor;

		[SerializeField]
		private Color NormalColor;

		[SerializeField]
		private CanvasGroup IntroCG;

		[SerializeField]
		private CanvasGroup MenuCG;

		private void Update()
		{
			pressed = Input.GetKey(KeyCode.Space) || Input.GetButton("Fire1");
			ChangeVal();
		}

		private void ChangeVal()
		{
			if (GetComponent<Slider>().normalizedValue == 1f)
			{
				IntroCG.alpha -= Time.deltaTime;
				MenuCG.alpha += Time.deltaTime;
			}
			else
			{
				GetComponent<Slider>().normalizedValue += ((pressed && selected) ? Time.deltaTime : (0f - Time.deltaTime));
			}
			IntroCG.blocksRaycasts = IntroCG.alpha > 0f;
		}

		public void OnPointerEnter(PointerEventData data)
		{
			bg.color = SelectedColor;
			bg.GetComponent<CurvedUIVertexEffect>().TesselationRequired = true;
			selected = true;
		}

		public void OnPointerExit(PointerEventData data)
		{
			bg.color = NormalColor;
			bg.GetComponent<CurvedUIVertexEffect>().TesselationRequired = true;
			selected = false;
		}
	}
	public class CUI_DragBetweenCanvases : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		private Vector2 dragPoint;

		public void OnBeginDrag(PointerEventData data)
		{
			UnityEngine.Debug.Log("OnBeginDrag");
			Vector2 newPos = Vector2.zero;
			RaycastPosition(out newPos);
			dragPoint = new Vector2((base.transform as RectTransform).localPosition.x, (base.transform as RectTransform).localPosition.y) - newPos;
		}

		public void OnDrag(PointerEventData data)
		{
			CurvedUISettings componentInParent = GetComponentInParent<CurvedUISettings>();
			Ray ray = Camera.main.ScreenPointToRay(new Vector2((float)Screen.width / 2f, (float)Screen.height / 2f));
			if (CurvedUIInputModule.ControlMethod == CurvedUIInputModule.CUIControlMethod.MOUSE)
			{
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			}
			else if (CurvedUIInputModule.ControlMethod == CurvedUIInputModule.CUIControlMethod.GAZE)
			{
				ray = Camera.main.ScreenPointToRay(new Vector2((float)Screen.width / 2f, (float)Screen.height / 2f));
			}
			if (!Physics.Raycast(ray, out var hitInfo))
			{
				return;
			}
			CurvedUISettings componentInParent2 = hitInfo.collider.GetComponentInParent<CurvedUISettings>();
			Vector2 o_positionOnCanvas = Vector2.zero;
			if (!(componentInParent2 != null))
			{
				return;
			}
			if (componentInParent2 != componentInParent)
			{
				base.transform.SetParent(componentInParent2.transform);
				base.transform.ResetTransform();
				CurvedUIVertexEffect[] componentsInChildren = GetComponentsInChildren<CurvedUIVertexEffect>();
				foreach (CurvedUIVertexEffect curvedUIVertexEffect in componentsInChildren)
				{
					curvedUIVertexEffect.FindParentSettings(forceNew: true);
				}
			}
			componentInParent2.RaycastToCanvasSpace(ray, out o_positionOnCanvas);
			(base.transform as RectTransform).localPosition = o_positionOnCanvas + dragPoint;
		}

		public void OnEndDrag(PointerEventData data)
		{
			UnityEngine.Debug.Log("OnEndDrag");
		}

		private void RaycastPosition(out Vector2 newPos)
		{
			if (CurvedUIInputModule.ControlMethod == CurvedUIInputModule.CUIControlMethod.MOUSE)
			{
				GetComponentInParent<CurvedUISettings>().RaycastToCanvasSpace(Camera.main.ScreenPointToRay(Input.mousePosition), out newPos);
			}
			else if (CurvedUIInputModule.ControlMethod == CurvedUIInputModule.CUIControlMethod.GAZE)
			{
				GetComponentInParent<CurvedUISettings>().RaycastToCanvasSpace(Camera.main.ScreenPointToRay(new Vector2((float)Screen.width / 2f, (float)Screen.height / 2f)), out newPos);
			}
			else
			{
				newPos = Vector2.zero;
			}
		}
	}
	public class CUI_GunController : MonoBehaviour
	{
		[SerializeField]
		private CurvedUISettings ControlledCanvas;

		[SerializeField]
		private Transform LaserBeamTransform;

		private void Update()
		{
			Ray ray = new Ray(base.transform.position, base.transform.forward);
			if ((bool)ControlledCanvas)
			{
				CurvedUIInputModule.CustomControllerRay = ray;
			}
			float num = 10000f;
			if (Physics.Raycast(ray, out var hitInfo, num))
			{
				int num2 = 0;
				if (hitInfo.transform.GetComponent<CurvedUIRaycaster>() != null)
				{
					num2 = hitInfo.transform.GetComponent<CurvedUIRaycaster>().GetObjectsUnderPointer().FindAll((GameObject x) => x.GetComponent<Graphic>() != null && x.GetComponent<Graphic>().depth != -1)
						.Count;
				}
				num = ((num2 == 0) ? 10000f : Vector3.Distance(hitInfo.point, base.transform.position));
			}
			LaserBeamTransform.localScale = LaserBeamTransform.localScale.ModifyZ(num);
			if (Input.GetMouseButton(0))
			{
				LaserBeamTransform.localScale = LaserBeamTransform.localScale.ModifyX(0.75f).ModifyY(0.75f);
			}
			else
			{
				LaserBeamTransform.localScale = LaserBeamTransform.localScale.ModifyX(0.2f).ModifyY(0.2f);
			}
		}
	}
	public class CUI_GunMovement : MonoBehaviour
	{
		[SerializeField]
		private CurvedUISettings mySettings;

		[SerializeField]
		private Transform pivot;

		[SerializeField]
		private float sensitivity = 0.1f;

		private Vector2 lastMouse;

		private void Start()
		{
			lastMouse = CurvedUIInputModule.MousePosition;
		}

		private void Update()
		{
			Vector3 vector = CurvedUIInputModule.MousePosition - lastMouse;
			lastMouse = CurvedUIInputModule.MousePosition;
			pivot.localEulerAngles += new Vector3(0f - vector.y, vector.x, 0f) * sensitivity;
			Ray customControllerRay = new Ray(base.transform.position, base.transform.forward);
			CurvedUIInputModule.CustomControllerRay = customControllerRay;
			CurvedUIInputModule.CustomControllerButtonState = CurvedUIInputModule.LeftMouseButton;
		}
	}
	public class CUI_OrientOnCurvedSpace : MonoBehaviour
	{
		public CurvedUISettings mySettings;

		private void Awake()
		{
			mySettings = GetComponentInParent<CurvedUISettings>();
		}

		private void Update()
		{
			Vector3 pos = mySettings.transform.worldToLocalMatrix.MultiplyPoint3x4(base.transform.parent.position);
			base.transform.position = mySettings.CanvasToCurvedCanvas(pos);
			base.transform.rotation = Quaternion.LookRotation(mySettings.CanvasToCurvedCanvasNormal(base.transform.parent.localPosition), base.transform.parent.up);
		}
	}
	public class CUI_PerlinNoisePosition : MonoBehaviour
	{
		public float samplingSpeed = 1f;

		public Vector2 Range;

		private RectTransform rectie;

		private void Start()
		{
			rectie = base.transform as RectTransform;
		}

		private void Update()
		{
			rectie.anchoredPosition = new Vector2(Mathf.PerlinNoise(Time.time * samplingSpeed, Time.time * samplingSpeed).Remap(0f, 1f, 0f - Range.x, Range.x), Mathf.PerlinNoise(Time.time * samplingSpeed * 1.333f, Time.time * samplingSpeed * 0.888f).Remap(0f, 1f, 0f - Range.y, Range.y));
		}
	}
	public class CUI_PerlinNoiseRotation : MonoBehaviour
	{
		public float samplingSpeed = 1f;

		public float maxrotation = 60f;

		private RectTransform rectie;

		private void Start()
		{
			rectie = base.transform as RectTransform;
		}

		private void Update()
		{
			rectie.localEulerAngles = new Vector3(0f, 0f, Mathf.PerlinNoise(Time.time * samplingSpeed, Time.time * samplingSpeed).Remap(0f, 1f, 0f - maxrotation, maxrotation));
		}
	}
	public class CUI_PickImageFromSet : MonoBehaviour
	{
		private static CUI_PickImageFromSet picked = null;

		public void PickThis()
		{
			if (picked != null)
			{
				picked.GetComponent<Button>().targetGraphic.color = Color.white;
			}
			UnityEngine.Debug.Log("Clicked this!", base.gameObject);
			picked = this;
			picked.GetComponent<Button>().targetGraphic.color = Color.red;
		}
	}
	public class CUI_RaycastToCanvas : MonoBehaviour
	{
		private CurvedUISettings mySettings;

		private void Start()
		{
			mySettings = GetComponentInParent<CurvedUISettings>();
		}

		private void Update()
		{
			Vector2 o_positionOnCanvas = Vector2.zero;
			mySettings.RaycastToCanvasSpace(Camera.main.ScreenPointToRay(Input.mousePosition), out o_positionOnCanvas);
			base.transform.localPosition = o_positionOnCanvas;
		}
	}
	public class CUI_RiseChildrenOverTime : MonoBehaviour
	{
		private float current = 0f;

		public float Speed = 10f;

		public float RiseBy = 50f;

		private void Start()
		{
		}

		private void Update()
		{
			current += Speed * Time.deltaTime;
			if (Mathf.RoundToInt(current) >= base.transform.childCount)
			{
				current = 0f;
			}
			if (Mathf.RoundToInt(current) < 0)
			{
				current = base.transform.childCount - 1;
			}
			for (int i = 0; i < base.transform.childCount; i++)
			{
				if (Mathf.RoundToInt(current) == i)
				{
					base.transform.GetChild(i).localPosition = base.transform.GetChild(i).localPosition.ModifyZ(0f - RiseBy);
				}
				else
				{
					base.transform.GetChild(i).localPosition = base.transform.GetChild(i).localPosition.ModifyZ(0f);
				}
			}
		}
	}
	public class CUI_TMPChecker : MonoBehaviour
	{
		[SerializeField]
		private GameObject testMsg;

		[SerializeField]
		private GameObject enabledMsg;

		[SerializeField]
		private GameObject disabledMsg;

		private void Start()
		{
			testMsg.gameObject.SetActive(value: false);
			enabledMsg.gameObject.SetActive(value: true);
			disabledMsg.gameObject.SetActive(value: false);
		}
	}
	public class CUI_ViveButtonState : MonoBehaviour
	{
		private enum ViveButton
		{
			Trigger,
			TouchpadTouch,
			TouchpadPress,
			Grip,
			Menu
		}

		[SerializeField]
		private Color ActiveColor = Color.green;

		[SerializeField]
		private Color InActiveColor = Color.gray;

		[SerializeField]
		private ViveButton ShowStateFor = ViveButton.Trigger;
	}
	public class CUI_ViveHapticPulse : MonoBehaviour
	{
		private float PulseStrength;

		private void Start()
		{
			PulseStrength = 1f;
		}

		public void SetPulseStrength(float newStr)
		{
			PulseStrength = Mathf.Clamp(newStr, 0f, 1f);
		}

		public void TriggerPulse()
		{
		}
	}
	public class CUI_WorldSpaceCursorFollow : MonoBehaviour
	{
		private CurvedUISettings mySettings;

		private void Start()
		{
			mySettings = GetComponentInParent<CurvedUISettings>();
			CurvedUIInputModule.Instance.WorldSpaceMouseInCanvasSpace -= (mySettings.transform as RectTransform).rect.size / 2f;
		}

		private void Update()
		{
			base.transform.localPosition = CurvedUIInputModule.Instance.WorldSpaceMouseInCanvasSpace;
		}
	}
	public class CUI_WorldSpaceMouseMultipleCanvases : MonoBehaviour
	{
		[SerializeField]
		private List<CurvedUISettings> ControlledCanvases;

		[SerializeField]
		private Transform WorldSpaceMouse;

		[SerializeField]
		private CurvedUISettings MouseCanvas;

		private void Update()
		{
			Vector3 vector = MouseCanvas.CanvasToCurvedCanvas(WorldSpaceMouse.localPosition);
			Ray ray2 = (CurvedUIInputModule.CustomControllerRay = new Ray(Camera.main.transform.position, vector - Camera.main.transform.position));
			if (Input.GetButton("Fire2"))
			{
				Vector2 o_positionOnCanvas = Vector2.zero;
				MouseCanvas.RaycastToCanvasSpace(new Ray(Camera.main.transform.position, Camera.main.transform.forward), out o_positionOnCanvas);
				CurvedUIInputModule.Instance.WorldSpaceMouseInCanvasSpace = o_positionOnCanvas;
			}
			UnityEngine.Debug.DrawRay(ray2.GetPoint(0f), ray2.direction * 1000f, Color.cyan);
		}
	}
	public class CUI_draggable : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		private Vector2 savedVector;

		private bool isDragged = false;

		public void OnBeginDrag(PointerEventData data)
		{
			UnityEngine.Debug.Log("OnBeginDrag");
			Vector2 newPos = Vector2.zero;
			RaycastPosition(out newPos);
			savedVector = new Vector2((base.transform as RectTransform).localPosition.x, (base.transform as RectTransform).localPosition.y) - newPos;
			isDragged = true;
		}

		public void OnDrag(PointerEventData data)
		{
		}

		public void OnEndDrag(PointerEventData data)
		{
			UnityEngine.Debug.Log("OnEndDrag");
			isDragged = false;
		}

		private void LateUpdate()
		{
			if (isDragged)
			{
				UnityEngine.Debug.Log("OnDrag");
				Vector2 newPos = Vector2.zero;
				RaycastPosition(out newPos);
				(base.transform as RectTransform).localPosition = newPos + savedVector;
			}
		}

		private void RaycastPosition(out Vector2 newPos)
		{
			if (CurvedUIInputModule.ControlMethod == CurvedUIInputModule.CUIControlMethod.MOUSE)
			{
				GetComponentInParent<CurvedUISettings>().RaycastToCanvasSpace(Camera.main.ScreenPointToRay(Input.mousePosition), out newPos);
			}
			else if (CurvedUIInputModule.ControlMethod == CurvedUIInputModule.CUIControlMethod.GAZE)
			{
				GetComponentInParent<CurvedUISettings>().RaycastToCanvasSpace(Camera.main.ScreenPointToRay(new Vector2((float)Screen.width / 2f, (float)Screen.height / 2f)), out newPos);
			}
			else
			{
				newPos = Vector2.zero;
			}
		}
	}
	public class CUI_inventory_paralax : MonoBehaviour
	{
		[SerializeField]
		private Transform front;

		[SerializeField]
		private Transform back;

		private Vector3 initFG;

		private Vector3 initBG;

		public float change = 50f;

		private void Start()
		{
			initFG = front.position;
			initBG = back.position;
		}

		private void Update()
		{
			front.position = front.position.ModifyX(initFG.x + Input.mousePosition.x.Remap(0f, Screen.width, 0f - change, change));
			back.position = back.position.ModifyX(initBG.x - Input.mousePosition.x.Remap(0f, Screen.width, 0f - change, change));
			front.position = front.position.ModifyY(initFG.y + Input.mousePosition.y.Remap(0f, Screen.height, 0f - change, change) * (float)(Screen.height / Screen.width));
			back.position = back.position.ModifyY(initBG.y - Input.mousePosition.y.Remap(0f, Screen.height, 0f - change, change) * (float)(Screen.height / Screen.width));
		}
	}
	public class CurvedUIEventSystem : EventSystem
	{
		public static CurvedUIEventSystem instance;

		protected override void Awake()
		{
			base.Awake();
			instance = this;
		}
	}
	public static class CurvedUIExtensionMethods
	{
		public static bool AlmostEqual(this Vector3 a, Vector3 b, double accuracy = 0.01)
		{
			return (double)Vector3.SqrMagnitude(a - b) < accuracy;
		}

		public static float Remap(this float value, float from1, float to1, float from2, float to2)
		{
			return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
		}

		public static float RemapAndClamp(this float value, float from1, float to1, float from2, float to2)
		{
			return value.Remap(from1, to1, from2, to2).Clamp(from2, to2);
		}

		public static float Remap(this int value, float from1, float to1, float from2, float to2)
		{
			return ((float)value - from1) / (to1 - from1) * (to2 - from2) + from2;
		}

		public static double Remap(this double value, double from1, double to1, double from2, double to2)
		{
			return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
		}

		public static float Clamp(this float value, float min, float max)
		{
			return Mathf.Clamp(value, min, max);
		}

		public static float Clamp(this int value, int min, int max)
		{
			return Mathf.Clamp(value, min, max);
		}

		public static int Abs(this int value)
		{
			return Mathf.Abs(value);
		}

		public static float Abs(this float value)
		{
			return Mathf.Abs(value);
		}

		public static int ToInt(this float value)
		{
			return Mathf.RoundToInt(value);
		}

		public static int FloorToInt(this float value)
		{
			return Mathf.FloorToInt(value);
		}

		public static int CeilToInt(this float value)
		{
			return Mathf.FloorToInt(value);
		}

		public static Vector3 ModifyX(this Vector3 trans, float newVal)
		{
			trans = new Vector3(newVal, trans.y, trans.z);
			return trans;
		}

		public static Vector3 ModifyY(this Vector3 trans, float newVal)
		{
			trans = new Vector3(trans.x, newVal, trans.z);
			return trans;
		}

		public static Vector3 ModifyZ(this Vector3 trans, float newVal)
		{
			trans = new Vector3(trans.x, trans.y, newVal);
			return trans;
		}

		public static Vector2 ModifyVectorX(this Vector2 trans, float newVal)
		{
			trans = new Vector3(newVal, trans.y);
			return trans;
		}

		public static Vector2 ModifyVectorY(this Vector2 trans, float newVal)
		{
			trans = new Vector3(trans.x, newVal);
			return trans;
		}

		public static void ResetTransform(this Transform trans)
		{
			trans.localPosition = Vector3.zero;
			trans.localRotation = Quaternion.identity;
			trans.localScale = Vector3.one;
		}

		public static T AddComponentIfMissing<T>(this GameObject go) where T : Component
		{
			if (go.GetComponent<T>() == null)
			{
				return go.AddComponent<T>();
			}
			return go.GetComponent<T>();
		}

		public static T AddComponentIfMissing<T>(this Component go) where T : Component
		{
			return go.gameObject.AddComponentIfMissing<T>();
		}
	}
	public class CurvedUIHandSwitcher : MonoBehaviour
	{
		[SerializeField]
		private GameObject LaserBeam;

		[SerializeField]
		[Tooltip("If true, when player clicks the trigger on the other hand, we'll instantly set it as UI controlling hand and move the pointer to it.")]
		private bool autoSwitchHands = true;

		[Header("Optional")]
		[SerializeField]
		[Tooltip("If set, pointer will be placed as a child of this transform, instead of the current VR SDKs Camera Rig.")]
		private Transform leftHandOverride;

		[SerializeField]
		[Tooltip("If set, pointer will be placed as a child of this transform, instead of the current VR SDKs Camera Rig.")]
		private Transform rightHandOverride;

		private void Start()
		{
			SwitchHandTo(CurvedUIInputModule.Instance.UsedHand);
		}

		private void Update()
		{
			if (!autoSwitchHands || CurvedUIInputModule.ControlMethod != CurvedUIInputModule.CUIControlMethod.UNITY_XR)
			{
				return;
			}
			bool pressed = false;
			if (CurvedUIInputModule.Instance.RightXRController != null && CurvedUIInputModule.Instance.UsedHand != CurvedUIInputModule.Hand.Right)
			{
				CurvedUIInputModule.Instance.GetXrControllerButtonState(ref pressed, CurvedUIInputModule.Hand.Right);
				if (pressed)
				{
					SwitchHandTo(CurvedUIInputModule.Hand.Right);
				}
			}
			if (CurvedUIInputModule.Instance.LeftXRController != null && CurvedUIInputModule.Instance.UsedHand != CurvedUIInputModule.Hand.Left)
			{
				CurvedUIInputModule.Instance.GetXrControllerButtonState(ref pressed, CurvedUIInputModule.Hand.Left);
				if (pressed)
				{
					SwitchHandTo(CurvedUIInputModule.Hand.Left);
				}
			}
		}

		public void SwitchHandTo(CurvedUIInputModule.Hand newHand)
		{
			CurvedUIInputModule.Instance.UsedHand = newHand;
			if ((bool)CurvedUIInputModule.Instance.ControllerTransform)
			{
				if (newHand == CurvedUIInputModule.Hand.Left && (bool)leftHandOverride)
				{
					CurvedUIInputModule.Instance.PointerTransformOverride = leftHandOverride;
				}
				if (newHand == CurvedUIInputModule.Hand.Right && (bool)rightHandOverride)
				{
					CurvedUIInputModule.Instance.PointerTransformOverride = rightHandOverride;
				}
				LaserBeam.transform.SetParent(CurvedUIInputModule.Instance.ControllerTransform);
				LaserBeam.transform.ResetTransform();
				LaserBeam.transform.LookAt(LaserBeam.transform.position + CurvedUIInputModule.Instance.ControllerPointingDirection);
			}
			else
			{
				UnityEngine.Debug.LogError("CURVEDUI: No Active controller that can be used as a parent of the pointer. Is the controller gameobject present on the scene and active?");
			}
		}
	}
	public class CurvedUIInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		private InputField myField;

		private RectTransform myCaret;

		private Color origCaretColor;

		private Color origSelectionColor;

		private bool selected = false;

		private bool selectingText = false;

		private int lastCharDist = 2;

		public Color CaretColor
		{
			get
			{
				return origCaretColor;
			}
			set
			{
				origCaretColor = value;
			}
		}

		public Color SelectionColor
		{
			get
			{
				return origSelectionColor;
			}
			set
			{
				origSelectionColor = value;
			}
		}

		public float CaretBlinkRate
		{
			get
			{
				return myField.caretBlinkRate;
			}
			set
			{
				myField.caretBlinkRate = value;
			}
		}

		private void Awake()
		{
			myField = GetComponent<InputField>();
		}

		private void Update()
		{
			if (selected)
			{
				UpdateCaret();
			}
		}

		public void OnSelect(BaseEventData eventData)
		{
			if (myCaret == null)
			{
				CreateCaret();
			}
			selected = true;
			myCaret.gameObject.SetActive(value: true);
			StartCoroutine(CaretBlinker());
		}

		public void OnDeselect(BaseEventData eventData)
		{
			selected = false;
			myCaret.gameObject.SetActive(value: false);
		}

		private IEnumerator CaretBlinker()
		{
			while (selected)
			{
				myCaret.gameObject.SetActive(selectingText || !myCaret.gameObject.activeSelf);
				yield return new WaitForSeconds(0.5f / myField.caretBlinkRate);
			}
		}

		private void CreateCaret()
		{
			GameObject gameObject = new GameObject("CurvedUICaret");
			gameObject.AddComponent<RectTransform>();
			gameObject.AddComponent<Image>();
			gameObject.AddComponent<CurvedUIVertexEffect>();
			gameObject.transform.SetParent(base.transform);
			gameObject.transform.localScale = Vector3.one;
			(gameObject.transform as RectTransform).anchoredPosition3D = Vector3.zero;
			(gameObject.transform as RectTransform).pivot = new Vector2(0f, 1f);
			gameObject.GetComponent<Image>().color = myField.caretColor;
			myCaret = gameObject.transform as RectTransform;
			gameObject.transform.SetAsFirstSibling();
			myField.customCaretColor = true;
			origCaretColor = myField.caretColor;
			myField.caretColor = new Color(0f, 0f, 0f, 0f);
			origSelectionColor = myField.selectionColor;
			myField.selectionColor = new Color(0f, 0f, 0f, 0f);
			gameObject.gameObject.SetActive(value: false);
		}

		private void UpdateCaret()
		{
			if (myCaret == null)
			{
				CreateCaret();
			}
			Vector2 localPositionInText = GetLocalPositionInText(myField.caretPosition);
			if (myField.selectionFocusPosition != myField.selectionAnchorPosition)
			{
				selectingText = true;
				Vector2 vector = new Vector2(GetLocalPositionInText(myField.selectionAnchorPosition).x - GetLocalPositionInText(myField.selectionFocusPosition).x, GetLocalPositionInText(myField.selectionAnchorPosition).y - GetLocalPositionInText(myField.selectionFocusPosition).y);
				localPositionInText = ((vector.x < 0f) ? GetLocalPositionInText(myField.selectionAnchorPosition) : GetLocalPositionInText(myField.selectionFocusPosition));
				vector = new Vector2(Mathf.Abs(vector.x), Mathf.Abs(vector.y) + (float)myField.textComponent.fontSize);
				myCaret.sizeDelta = new Vector2(vector.x, vector.y);
				myCaret.anchoredPosition = localPositionInText;
				myCaret.GetComponent<Image>().color = origSelectionColor;
			}
			else
			{
				selectingText = false;
				myCaret.sizeDelta = new Vector2(myField.caretWidth, myField.textComponent.fontSize);
				myCaret.anchoredPosition = localPositionInText;
				myCaret.GetComponent<Image>().color = origCaretColor;
			}
		}

		private Vector2 GetLocalPositionInText(int charNo)
		{
			if (myField.isFocused)
			{
				TextGenerator cachedTextGenerator = myField.textComponent.cachedTextGenerator;
				if (charNo > cachedTextGenerator.characterCount - 1)
				{
					charNo = cachedTextGenerator.characterCount - 1;
				}
				if (charNo > 0)
				{
					UICharInfo uICharInfo = cachedTextGenerator.characters[charNo - 1];
					float x = (uICharInfo.cursorPos.x + uICharInfo.charWidth) / myField.textComponent.pixelsPerUnit + (float)lastCharDist;
					float y = uICharInfo.cursorPos.y / myField.textComponent.pixelsPerUnit;
					return new Vector2(x, y);
				}
				UICharInfo uICharInfo2 = cachedTextGenerator.characters[charNo];
				float x2 = uICharInfo2.cursorPos.x / myField.textComponent.pixelsPerUnit;
				float y2 = uICharInfo2.cursorPos.y / myField.textComponent.pixelsPerUnit;
				return new Vector2(x2, y2);
			}
			return Vector2.zero;
		}
	}
	public class CurvedUILaserBeam : MonoBehaviour
	{
		[SerializeField]
		private Transform LaserBeamTransform;

		[SerializeField]
		private Transform LaserBeamDot;

		[SerializeField]
		private bool hideWhenNotAimingAtCanvas = false;

		protected void Update()
		{
			Ray ray = new Ray(base.transform.position, base.transform.forward);
			if (!LaserBeamTransform || !LaserBeamDot)
			{
				return;
			}
			float num = 10000f;
			if (Physics.Raycast(ray, out var hitInfo, num, CurvedUIInputModule.Instance.RaycastLayerMask))
			{
				num = Vector3.Distance(hitInfo.point, base.transform.position);
				CurvedUISettings componentInParent = hitInfo.collider.GetComponentInParent<CurvedUISettings>();
				if (componentInParent != null)
				{
					num = ((componentInParent.GetObjectsUnderPointer().FindAll((GameObject x) => x != null && x.GetComponent<Graphic>() != null && x.GetComponent<Graphic>().depth != -1).Count == 0) ? 10000f : Vector3.Distance(hitInfo.point, base.transform.position));
				}
				else if (hideWhenNotAimingAtCanvas)
				{
					num = 0f;
				}
			}
			else if (hideWhenNotAimingAtCanvas)
			{
				num = 0f;
			}
			LaserBeamTransform.localScale = LaserBeamTransform.localScale.ModifyZ(num);
		}
	}
	public class CurvedUIPhysicsRaycaster : BaseRaycaster
	{
		[SerializeField]
		protected int sortOrder = 20;

		private RaycastHit hitInfo;

		private RaycastResult result;

		public int CompoundEventMask => (eventCamera != null) ? (eventCamera.cullingMask & (int)CurvedUIInputModule.Instance.RaycastLayerMask) : (-1);

		public override Camera eventCamera => CurvedUIInputModule.Instance ? CurvedUIInputModule.Instance.EventCamera : null;

		public virtual int Depth => (eventCamera != null) ? ((int)eventCamera.depth) : 16777215;

		public override int sortOrderPriority => sortOrder;

		protected CurvedUIPhysicsRaycaster()
		{
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			if (!(CurvedUIInputModule.Instance == null) && !(CurvedUIInputModule.Instance.EventCamera == null) && Physics.Raycast(CurvedUIInputModule.Instance.GetEventRay(), out hitInfo, float.PositiveInfinity, CompoundEventMask) && !hitInfo.collider.GetComponentInParent<CurvedUISettings>())
			{
				result = new RaycastResult
				{
					gameObject = hitInfo.collider.gameObject,
					module = this,
					distance = hitInfo.distance,
					index = resultAppendList.Count,
					worldPosition = hitInfo.point,
					worldNormal = hitInfo.normal
				};
				resultAppendList.Add(result);
			}
		}
	}
	public class CurvedUIPointerEventData : PointerEventData
	{
		public enum ControllerType
		{
			NONE = -1,
			VIVE
		}

		public GameObject Controller;

		public Vector2 TouchPadAxis = Vector2.zero;

		public CurvedUIPointerEventData(EventSystem eventSystem)
			: base(eventSystem)
		{
		}
	}
	public class CurvedUIRaycaster : GraphicRaycaster
	{
		[SerializeField]
		private bool showDebug = false;

		private bool overrideEventData = true;

		private Canvas myCanvas;

		private CurvedUISettings mySettings;

		private Vector3 cyllinderMidPoint;

		private List<GameObject> objectsUnderPointer = new List<GameObject>();

		private Vector2 lastCanvasPos = Vector2.zero;

		private GameObject colliderContainer;

		private PointerEventData lastFrameEventData;

		private PointerEventData curEventData;

		private PointerEventData eventDataToUse;

		private Ray cachedRay;

		private Graphic gph;

		private List<GameObject> selectablesUnderGaze = new List<GameObject>();

		private List<GameObject> selectablesUnderGazeLastFrame = new List<GameObject>();

		private float objectsUnderGazeLastChangeTime;

		private bool gazeClickExecuted = false;

		private bool pointingAtCanvas = false;

		private bool pointingAtCanvasLastFrame = false;

		[NonSerialized]
		private List<Graphic> m_RaycastResults = new List<Graphic>();

		[NonSerialized]
		private static readonly List<Graphic> s_SortedGraphics = new List<Graphic>();

		private Image GazeProgressImage => CurvedUIInputModule.Instance.GazeTimedClickProgressImage;

		public bool PointingAtCanvas => pointingAtCanvas;

		protected override void Awake()
		{
			base.Awake();
			mySettings = GetComponentInParent<CurvedUISettings>();
			if (!(mySettings == null))
			{
				myCanvas = mySettings.GetComponent<Canvas>();
				cyllinderMidPoint = new Vector3(0f, 0f, 0f - mySettings.GetCyllinderRadiusInCanvasSpace());
				base.ignoreReversedGraphics = false;
			}
		}

		protected override void Start()
		{
			if (!(mySettings == null))
			{
				CheckEventCamera();
				CreateCollider();
			}
		}

		protected virtual void Update()
		{
			if (mySettings == null)
			{
				return;
			}
			if (CurvedUIInputModule.ControlMethod == CurvedUIInputModule.CUIControlMethod.GAZE && CurvedUIInputModule.Instance.GazeUseTimedClick)
			{
				if (pointingAtCanvas)
				{
					if (!pointingAtCanvasLastFrame)
					{
						ResetGazeTimedClick();
					}
					ProcessGazeTimedClick();
					selectablesUnderGazeLastFrame.Clear();
					selectablesUnderGazeLastFrame.AddRange(selectablesUnderGaze);
					selectablesUnderGaze.Clear();
					selectablesUnderGaze.AddRange(objectsUnderPointer);
					selectablesUnderGaze.RemoveAll((GameObject obj) => obj.GetComponent<Selectable>() == null || !obj.GetComponent<Selectable>().interactable);
					if ((bool)GazeProgressImage)
					{
						if (GazeProgressImage.type != Image.Type.Filled)
						{
							GazeProgressImage.type = Image.Type.Filled;
						}
						GazeProgressImage.fillAmount = (Time.time - objectsUnderGazeLastChangeTime).RemapAndClamp(CurvedUIInputModule.Instance.GazeClickTimerDelay, CurvedUIInputModule.Instance.GazeClickTimer + CurvedUIInputModule.Instance.GazeClickTimerDelay, 0f, 1f);
					}
				}
				else if (!pointingAtCanvas && pointingAtCanvasLastFrame)
				{
					ResetGazeTimedClick();
					if ((bool)GazeProgressImage)
					{
						GazeProgressImage.fillAmount = 0f;
					}
				}
			}
			pointingAtCanvasLastFrame = pointingAtCanvas;
			pointingAtCanvas = false;
		}

		private void ProcessGazeTimedClick()
		{
			if (selectablesUnderGazeLastFrame.Count == 0 || selectablesUnderGazeLastFrame.Count != selectablesUnderGaze.Count)
			{
				ResetGazeTimedClick();
				return;
			}
			for (int i = 0; i < selectablesUnderGazeLastFrame.Count && i < selectablesUnderGaze.Count; i++)
			{
				if (selectablesUnderGazeLastFrame[i].GetInstanceID() != selectablesUnderGaze[i].GetInstanceID())
				{
					ResetGazeTimedClick();
					return;
				}
			}
			if (!gazeClickExecuted && Time.time > objectsUnderGazeLastChangeTime + CurvedUIInputModule.Instance.GazeClickTimer + CurvedUIInputModule.Instance.GazeClickTimerDelay)
			{
				Click();
				gazeClickExecuted = true;
			}
		}

		private void ResetGazeTimedClick()
		{
			objectsUnderGazeLastChangeTime = Time.time;
			gazeClickExecuted = false;
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			if (mySettings == null)
			{
				base.Raycast(eventData, resultAppendList);
			}
			else
			{
				if (!mySettings.Interactable)
				{
					return;
				}
				if (!CheckEventCamera())
				{
					UnityEngine.Debug.LogWarning("CurvedUI: No WORLD CAMERA assigned to Canvas " + base.gameObject.name + " to use for event processing!", myCanvas.gameObject);
					return;
				}
				cachedRay = CurvedUIInputModule.Instance.GetEventRay(myCanvas.worldCamera);
				if (CurvedUIInputModule.ControlMethod == CurvedUIInputModule.CUIControlMethod.GAZE)
				{
					UpdateSelectedObjects(eventData);
				}
				else if (CurvedUIInputModule.ControlMethod == CurvedUIInputModule.CUIControlMethod.WORLD_MOUSE)
				{
					cachedRay = new Ray(myCanvas.worldCamera.transform.position, mySettings.CanvasToCurvedCanvas(CurvedUIInputModule.Instance.WorldSpaceMouseInCanvasSpace) - myCanvas.worldCamera.transform.position);
				}
				if (curEventData == null)
				{
					curEventData = new PointerEventData(EventSystem.current);
				}
				if (!overrideEventData)
				{
					curEventData.pointerEnter = eventData.pointerEnter;
					curEventData.rawPointerPress = eventData.rawPointerPress;
					curEventData.pointerDrag = eventData.pointerDrag;
					curEventData.pointerCurrentRaycast = eventData.pointerCurrentRaycast;
					curEventData.pointerPressRaycast = eventData.pointerPressRaycast;
					curEventData.hovered.Clear();
					curEventData.hovered.AddRange(eventData.hovered);
					curEventData.eligibleForClick = eventData.eligibleForClick;
					curEventData.pointerId = eventData.pointerId;
					curEventData.position = eventData.position;
					curEventData.delta = eventData.delta;
					curEventData.pressPosition = eventData.pressPosition;
					curEventData.clickTime = eventData.clickTime;
					curEventData.clickCount = eventData.clickCount;
					curEventData.scrollDelta = eventData.scrollDelta;
					curEventData.useDragThreshold = eventData.useDragThreshold;
					curEventData.dragging = eventData.dragging;
					curEventData.button = eventData.button;
				}
				if (mySettings.Angle != 0 && mySettings.enabled)
				{
					Vector2 o_canvasPos = eventData.position;
					switch (mySettings.Shape)
					{
					case CurvedUISettings.CurvedUIShape.CYLINDER:
						if (!RaycastToCyllinderCanvas(cachedRay, out o_canvasPos))
						{
							return;
						}
						break;
					case CurvedUISettings.CurvedUIShape.CYLINDER_VERTICAL:
						if (!RaycastToCyllinderVerticalCanvas(cachedRay, out o_canvasPos))
						{
							return;
						}
						break;
					case CurvedUISettings.CurvedUIShape.RING:
						if (!RaycastToRingCanvas(cachedRay, out o_canvasPos))
						{
							return;
						}
						break;
					case CurvedUISettings.CurvedUIShape.SPHERE:
						if (!RaycastToSphereCanvas(cachedRay, out o_canvasPos))
						{
							return;
						}
						break;
					}
					pointingAtCanvas = true;
					eventDataToUse = (overrideEventData ? eventData : curEventData);
					if (eventDataToUse.pressPosition == eventDataToUse.position)
					{
						eventDataToUse.pressPosition = o_canvasPos;
					}
					eventDataToUse.position = o_canvasPos;
					if (CurvedUIInputModule.ControlMethod == CurvedUIInputModule.CUIControlMethod.STEAMVR_LEGACY)
					{
						eventDataToUse.delta = o_canvasPos - lastCanvasPos;
						lastCanvasPos = o_canvasPos;
					}
				}
				objectsUnderPointer = eventData.hovered;
				lastFrameEventData = eventData;
				FlatRaycast(overrideEventData ? eventData : curEventData, resultAppendList);
			}
		}

		public virtual bool RaycastToCyllinderCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			if (showDebug)
			{
				UnityEngine.Debug.DrawLine(ray3D.origin, ray3D.GetPoint(1000f), Color.red);
			}
			RaycastHit hitInfo = default(RaycastHit);
			if (Physics.Raycast(ray3D, out hitInfo, float.PositiveInfinity, GetRaycastLayerMask()))
			{
				if (overrideEventData && hitInfo.collider.gameObject != base.gameObject && (colliderContainer == null || hitInfo.collider.transform.parent != colliderContainer.transform))
				{
					o_canvasPos = Vector2.zero;
					return false;
				}
				Vector3 vector = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(hitInfo.point);
				Vector3 normalized = (vector - cyllinderMidPoint).normalized;
				float value = 0f - AngleSigned(normalized.ModifyY(0f), (mySettings.Angle < 0) ? Vector3.back : Vector3.forward, Vector3.up);
				Vector2 size = myCanvas.GetComponent<RectTransform>().rect.size;
				Vector2 vector2 = new Vector3(0f, 0f, 0f);
				vector2.x = value.Remap((float)(-mySettings.Angle) / 2f, (float)mySettings.Angle / 2f, (0f - size.x) / 2f, size.x / 2f);
				vector2.y = vector.y;
				if (OutputInCanvasSpace)
				{
					o_canvasPos = vector2;
				}
				else
				{
					o_canvasPos = myCanvas.worldCamera.WorldToScreenPoint(myCanvas.transform.localToWorldMatrix.MultiplyPoint3x4(vector2));
				}
				if (showDebug)
				{
					UnityEngine.Debug.DrawLine(hitInfo.point, hitInfo.point.ModifyY(hitInfo.point.y + 10f), Color.green);
					UnityEngine.Debug.DrawLine(hitInfo.point, myCanvas.transform.localToWorldMatrix.MultiplyPoint3x4(cyllinderMidPoint), Color.yellow);
				}
				return true;
			}
			o_canvasPos = Vector2.zero;
			return false;
		}

		public virtual bool RaycastToCyllinderVerticalCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			if (showDebug)
			{
				UnityEngine.Debug.DrawLine(ray3D.origin, ray3D.GetPoint(1000f), Color.red);
			}
			RaycastHit hitInfo = default(RaycastHit);
			if (Physics.Raycast(ray3D, out hitInfo, float.PositiveInfinity, GetRaycastLayerMask()))
			{
				if (overrideEventData && hitInfo.collider.gameObject != base.gameObject && (colliderContainer == null || hitInfo.collider.transform.parent != colliderContainer.transform))
				{
					o_canvasPos = Vector2.zero;
					return false;
				}
				Vector3 vector = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(hitInfo.point);
				Vector3 normalized = (vector - cyllinderMidPoint).normalized;
				float value = 0f - AngleSigned(normalized.ModifyX(0f), (mySettings.Angle < 0) ? Vector3.back : Vector3.forward, Vector3.left);
				Vector2 size = myCanvas.GetComponent<RectTransform>().rect.size;
				Vector2 vector2 = new Vector3(0f, 0f, 0f);
				vector2.y = value.Remap((float)(-mySettings.Angle) / 2f, (float)mySettings.Angle / 2f, (0f - size.y) / 2f, size.y / 2f);
				vector2.x = vector.x;
				if (OutputInCanvasSpace)
				{
					o_canvasPos = vector2;
				}
				else
				{
					o_canvasPos = myCanvas.worldCamera.WorldToScreenPoint(myCanvas.transform.localToWorldMatrix.MultiplyPoint3x4(vector2));
				}
				if (showDebug)
				{
					UnityEngine.Debug.DrawLine(hitInfo.point, hitInfo.point.ModifyY(hitInfo.point.y + 10f), Color.green);
					UnityEngine.Debug.DrawLine(hitInfo.point, myCanvas.transform.localToWorldMatrix.MultiplyPoint3x4(cyllinderMidPoint), Color.yellow);
				}
				return true;
			}
			o_canvasPos = Vector2.zero;
			return false;
		}

		public virtual bool RaycastToRingCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			LayerMask raycastLayerMask = GetRaycastLayerMask();
			RaycastHit hitInfo = default(RaycastHit);
			if (Physics.Raycast(ray3D, out hitInfo, float.PositiveInfinity, raycastLayerMask))
			{
				if (overrideEventData && hitInfo.collider.gameObject != base.gameObject && (colliderContainer == null || hitInfo.collider.transform.parent != colliderContainer.transform))
				{
					o_canvasPos = Vector2.zero;
					return false;
				}
				Vector3 trans = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(hitInfo.point);
				Vector3 normalized = trans.ModifyZ(0f).normalized;
				Vector2 size = myCanvas.GetComponent<RectTransform>().rect.size;
				float num = 0f - AngleSigned(normalized.ModifyZ(0f), Vector3.up, Vector3.back);
				Vector2 vector = new Vector2(0f, 0f);
				if (showDebug)
				{
					UnityEngine.Debug.Log("angle: " + num);
				}
				if (num < 0f)
				{
					vector.x = num.Remap(0f, -mySettings.Angle, (0f - size.x) / 2f, size.x / 2f);
				}
				else
				{
					vector.x = num.Remap(360f, 360 - mySettings.Angle, (0f - size.x) / 2f, size.x / 2f);
				}
				vector.y = trans.magnitude.Remap((float)mySettings.RingExternalDiameter * 0.5f * (1f - mySettings.RingFill), (float)mySettings.RingExternalDiameter * 0.5f, (0f - size.y) * 0.5f * (float)((!mySettings.RingFlipVertical) ? 1 : (-1)), size.y * 0.5f * (float)((!mySettings.RingFlipVertical) ? 1 : (-1)));
				if (OutputInCanvasSpace)
				{
					o_canvasPos = vector;
				}
				else
				{
					o_canvasPos = myCanvas.worldCamera.WorldToScreenPoint(myCanvas.transform.localToWorldMatrix.MultiplyPoint3x4(vector));
				}
				return true;
			}
			o_canvasPos = Vector2.zero;
			return false;
		}

		public virtual bool RaycastToSphereCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			RaycastHit hitInfo = default(RaycastHit);
			if (Physics.Raycast(ray3D, out hitInfo, float.PositiveInfinity, GetRaycastLayerMask()))
			{
				if (overrideEventData && hitInfo.collider.gameObject != base.gameObject && (colliderContainer == null || hitInfo.collider.transform.parent != colliderContainer.transform))
				{
					o_canvasPos = Vector2.zero;
					return false;
				}
				Vector2 size = myCanvas.GetComponent<RectTransform>().rect.size;
				float num = (mySettings.PreserveAspect ? mySettings.GetCyllinderRadiusInCanvasSpace() : (size.x / 2f));
				Vector3 vector = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(hitInfo.point);
				Vector3 vector2 = new Vector3(0f, 0f, mySettings.PreserveAspect ? (0f - num) : 0f);
				Vector3 normalized = (vector - vector2).normalized;
				Vector3 vector3 = Vector3.Cross(normalized, normalized.ModifyY(0f)).normalized * ((normalized.y < 0f) ? 1 : (-1));
				float num2 = 0f - AngleSigned(normalized.ModifyY(0f), (mySettings.Angle > 0) ? Vector3.forward : Vector3.back, (mySettings.Angle > 0) ? Vector3.up : Vector3.down);
				float num3 = 0f - AngleSigned(normalized, normalized.ModifyY(0f), vector3);
				float num4 = (float)Mathf.Abs(mySettings.Angle) * 0.5f;
				float num5 = Mathf.Abs(mySettings.PreserveAspect ? (num4 * size.y / size.x) : ((float)mySettings.VerticalAngle * 0.5f));
				Vector2 vector4 = new Vector2(num2.Remap(0f - num4, num4, (0f - size.x) * 0.5f, size.x * 0.5f), num3.Remap(0f - num5, num5, (0f - size.y) * 0.5f, size.y * 0.5f));
				if (showDebug)
				{
					UnityEngine.Debug.Log("h: " + num2 + " / v: " + num3 + " poc: " + vector4);
					UnityEngine.Debug.DrawRay(myCanvas.transform.localToWorldMatrix.MultiplyPoint3x4(vector2), myCanvas.transform.localToWorldMatrix.MultiplyVector(normalized) * Mathf.Abs(num), Color.red);
					UnityEngine.Debug.DrawRay(myCanvas.transform.localToWorldMatrix.MultiplyPoint3x4(vector2), myCanvas.transform.localToWorldMatrix.MultiplyVector(vector3) * 300f, Color.magenta);
				}
				if (OutputInCanvasSpace)
				{
					o_canvasPos = vector4;
				}
				else
				{
					o_canvasPos = myCanvas.worldCamera.WorldToScreenPoint(myCanvas.transform.localToWorldMatrix.MultiplyPoint3x4(vector4));
				}
				return true;
			}
			o_canvasPos = Vector2.zero;
			return false;
		}

		private void FlatRaycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			if (myCanvas == null)
			{
				return;
			}
			IList<Graphic> graphicsForCanvas = GraphicRegistry.GetGraphicsForCanvas(myCanvas);
			if (graphicsForCanvas == null || graphicsForCanvas.Count == 0)
			{
				return;
			}
			Camera camera = eventCamera;
			int num = ((myCanvas.renderMode != 0 && !(camera == null)) ? camera.targetDisplay : myCanvas.targetDisplay);
			Vector3 vector = Display.RelativeMouseAt(eventData.position);
			if (vector != Vector3.zero)
			{
				int num2 = (int)vector.z;
				if (num2 != num)
				{
					return;
				}
			}
			else
			{
				vector = eventData.position;
			}
			m_RaycastResults.Clear();
			FlatRaycastAndSort(myCanvas, camera, vector, graphicsForCanvas, m_RaycastResults);
			Ray ray = default(Ray);
			if (camera != null)
			{
				ray = camera.ScreenPointToRay(vector);
			}
			float num3 = float.MaxValue;
			int count = m_RaycastResults.Count;
			for (int i = 0; i < count; i++)
			{
				GameObject gameObject = m_RaycastResults[i].gameObject;
				Transform transform = gameObject.transform;
				Vector3 forward = transform.forward;
				float num4 = Vector3.Dot(forward, transform.position - ray.origin) / Vector3.Dot(forward, ray.direction);
				if (!(num4 < 0f) && !(num4 >= num3))
				{
					RaycastResult raycastResult = default(RaycastResult);
					raycastResult.gameObject = gameObject;
					raycastResult.module = this;
					raycastResult.distance = num4;
					raycastResult.screenPosition = vector;
					raycastResult.index = resultAppendList.Count;
					raycastResult.depth = m_RaycastResults[i].depth;
					raycastResult.sortingLayer = myCanvas.sortingLayerID;
					raycastResult.sortingOrder = myCanvas.sortingOrder;
					RaycastResult item = raycastResult;
					resultAppendList.Add(item);
				}
			}
		}

		private static void FlatRaycastAndSort(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
			int count = foundGraphics.Count;
			for (int i = 0; i < count; i++)
			{
				Graphic graphic = foundGraphics[i];
				if (graphic.depth != -1 && graphic.raycastTarget && !graphic.canvasRenderer.cull && RectTransformUtility.RectangleContainsScreenPoint(graphic.rectTransform, pointerPosition, eventCamera) && (!(eventCamera != null) || !(eventCamera.WorldToScreenPoint(graphic.rectTransform.position).z > eventCamera.farClipPlane)) && graphic.Raycast(pointerPosition, eventCamera))
				{
					s_SortedGraphics.Add(graphic);
				}
			}
			s_SortedGraphics.Sort((Graphic g1, Graphic g2) => g2.depth.CompareTo(g1.depth));
			count = s_SortedGraphics.Count;
			for (int j = 0; j < count; j++)
			{
				results.Add(s_SortedGraphics[j]);
			}
			s_SortedGraphics.Clear();
		}

		protected void CreateCollider()
		{
			List<Collider> list = new List<Collider>();
			list.AddRange(GetComponents<Collider>());
			for (int i = 0; i < list.Count; i++)
			{
				UnityEngine.Object.Destroy(list[i]);
			}
			if (!mySettings.BlocksRaycasts || (mySettings.Shape == CurvedUISettings.CurvedUIShape.SPHERE && !mySettings.PreserveAspect && mySettings.VerticalAngle == 0))
			{
				return;
			}
			switch (mySettings.Shape)
			{
			case CurvedUISettings.CurvedUIShape.CYLINDER:
				if (mySettings.ForceUseBoxCollider || GetComponent<Rigidbody>() != null || GetComponentInParent<Rigidbody>() != null)
				{
					if (colliderContainer != null)
					{
						UnityEngine.Object.Destroy(colliderContainer);
					}
					colliderContainer = CreateConvexCyllinderCollider();
				}
				else
				{
					SetupMeshColliderUsingMesh(CreateCyllinderColliderMesh());
				}
				break;
			case CurvedUISettings.CurvedUIShape.CYLINDER_VERTICAL:
				if (mySettings.ForceUseBoxCollider || GetComponent<Rigidbody>() != null || GetComponentInParent<Rigidbody>() != null)
				{
					if (colliderContainer != null)
					{
						UnityEngine.Object.Destroy(colliderContainer);
					}
					colliderContainer = CreateConvexCyllinderCollider(vertical: true);
				}
				else
				{
					SetupMeshColliderUsingMesh(CreateCyllinderColliderMesh(vertical: true));
				}
				break;
			case CurvedUISettings.CurvedUIShape.RING:
			{
				BoxCollider boxCollider = base.gameObject.AddComponent<BoxCollider>();
				boxCollider.size = new Vector3(mySettings.RingExternalDiameter, mySettings.RingExternalDiameter, 1f);
				break;
			}
			case CurvedUISettings.CurvedUIShape.SPHERE:
				if (GetComponent<Rigidbody>() != null || GetComponentInParent<Rigidbody>() != null)
				{
					UnityEngine.Debug.LogWarning("CurvedUI: Sphere shape canvases as children of rigidbodies do not support user input. Switch to Cyllinder shape or remove the rigidbody from parent.", base.gameObject);
				}
				SetupMeshColliderUsingMesh(CreateSphereColliderMesh());
				break;
			}
		}

		private void SetupMeshColliderUsingMesh(Mesh meshie)
		{
			MeshFilter meshFilter = this.AddComponentIfMissing<MeshFilter>();
			MeshCollider meshCollider = base.gameObject.AddComponent<MeshCollider>();
			meshFilter.mesh = meshie;
			meshCollider.sharedMesh = meshie;
		}

		private GameObject CreateConvexCyllinderCollider(bool vertical = false)
		{
			GameObject gameObject = new GameObject("_CurvedUIColliders");
			gameObject.layer = base.gameObject.layer;
			gameObject.transform.SetParent(base.transform);
			gameObject.transform.ResetTransform();
			Mesh mesh = new Mesh();
			Vector3[] array = new Vector3[4];
			(myCanvas.transform as RectTransform).GetWorldCorners(array);
			mesh.vertices = array;
			if (vertical)
			{
				array[0] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[1]);
				array[1] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[2]);
				array[2] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[0]);
				array[3] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[3]);
			}
			else
			{
				array[0] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[1]);
				array[1] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[0]);
				array[2] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[2]);
				array[3] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[3]);
			}
			mesh.vertices = array;
			List<Vector3> list = new List<Vector3>();
			int num = Mathf.Max(8, Mathf.RoundToInt((float)(mySettings.BaseCircleSegments * Mathf.Abs(mySettings.Angle)) / 360f));
			for (int i = 0; i < num; i++)
			{
				list.Add(Vector3.Lerp(mesh.vertices[0], mesh.vertices[2], (float)i * 1f / (float)(num - 1)));
			}
			if (mySettings.Angle != 0)
			{
				Rect rect = myCanvas.GetComponent<RectTransform>().rect;
				float cyllinderRadiusInCanvasSpace = mySettings.GetCyllinderRadiusInCanvasSpace();
				for (int j = 0; j < list.Count; j++)
				{
					Vector3 value = list[j];
					if (vertical)
					{
						float f = list[j].y / rect.size.y * (float)mySettings.Angle * ((float)Math.PI / 180f);
						value.y = Mathf.Sin(f) * cyllinderRadiusInCanvasSpace;
						value.z += Mathf.Cos(f) * cyllinderRadiusInCanvasSpace - cyllinderRadiusInCanvasSpace;
						list[j] = value;
					}
					else
					{
						float f2 = list[j].x / rect.size.x * (float)mySettings.Angle * ((float)Math.PI / 180f);
						value.x = Mathf.Sin(f2) * cyllinderRadiusInCanvasSpace;
						value.z += Mathf.Cos(f2) * cyllinderRadiusInCanvasSpace - cyllinderRadiusInCanvasSpace;
						list[j] = value;
					}
				}
			}
			float x = mySettings.GetTesslationSize(modifiedByQuality: false).x / 10f;
			for (int k = 0; k < list.Count - 1; k++)
			{
				GameObject gameObject2 = new GameObject("Box collider");
				gameObject2.layer = base.gameObject.layer;
				gameObject2.transform.SetParent(gameObject.transform);
				gameObject2.transform.ResetTransform();
				gameObject2.AddComponent<BoxCollider>();
				if (vertical)
				{
					gameObject2.transform.localPosition = new Vector3(0f, (list[k + 1].y + list[k].y) * 0.5f, (list[k + 1].z + list[k].z) * 0.5f);
					gameObject2.transform.localScale = new Vector3(x, Vector3.Distance(array[0], array[1]), Vector3.Distance(list[k + 1], list[k]));
					gameObject2.transform.localRotation = Quaternion.LookRotation(list[k + 1] - list[k], array[0] - array[1]);
				}
				else
				{
					gameObject2.transform.localPosition = new Vector3((list[k + 1].x + list[k].x) * 0.5f, 0f, (list[k + 1].z + list[k].z) * 0.5f);
					gameObject2.transform.localScale = new Vector3(x, Vector3.Distance(array[0], array[1]), Vector3.Distance(list[k + 1], list[k]));
					gameObject2.transform.localRotation = Quaternion.LookRotation(list[k + 1] - list[k], array[0] - array[1]);
				}
			}
			return gameObject;
		}

		private Mesh CreateCyllinderColliderMesh(bool vertical = false)
		{
			Mesh mesh = new Mesh();
			Vector3[] array = new Vector3[4];
			(myCanvas.transform as RectTransform).GetWorldCorners(array);
			mesh.vertices = array;
			if (vertical)
			{
				array[0] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[1]);
				array[1] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[2]);
				array[2] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[0]);
				array[3] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[3]);
			}
			else
			{
				array[0] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[1]);
				array[1] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[0]);
				array[2] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[2]);
				array[3] = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(mesh.vertices[3]);
			}
			mesh.vertices = array;
			List<Vector3> list = new List<Vector3>();
			int num = Mathf.Max(8, Mathf.RoundToInt((float)(mySettings.BaseCircleSegments * Mathf.Abs(mySettings.Angle)) / 360f));
			for (int i = 0; i < num; i++)
			{
				list.Add(Vector3.Lerp(mesh.vertices[0], mesh.vertices[2], (float)i * 1f / (float)(num - 1)));
				list.Add(Vector3.Lerp(mesh.vertices[1], mesh.vertices[3], (float)i * 1f / (float)(num - 1)));
			}
			if (mySettings.Angle != 0)
			{
				Rect rect = myCanvas.GetComponent<RectTransform>().rect;
				float cyllinderRadiusInCanvasSpace = mySettings.GetCyllinderRadiusInCanvasSpace();
				for (int j = 0; j < list.Count; j++)
				{
					Vector3 value = list[j];
					if (vertical)
					{
						float f = list[j].y / rect.size.y * (float)mySettings.Angle * ((float)Math.PI / 180f);
						value.y = Mathf.Sin(f) * cyllinderRadiusInCanvasSpace;
						value.z += Mathf.Cos(f) * cyllinderRadiusInCanvasSpace - cyllinderRadiusInCanvasSpace;
						list[j] = value;
					}
					else
					{
						float f2 = list[j].x / rect.size.x * (float)mySettings.Angle * ((float)Math.PI / 180f);
						value.x = Mathf.Sin(f2) * cyllinderRadiusInCanvasSpace;
						value.z += Mathf.Cos(f2) * cyllinderRadiusInCanvasSpace - cyllinderRadiusInCanvasSpace;
						list[j] = value;
					}
				}
			}
			mesh.vertices = list.ToArray();
			List<int> list2 = new List<int>();
			for (int k = 0; k < list.Count / 2 - 1; k++)
			{
				if (vertical)
				{
					list2.Add(k * 2);
					list2.Add(k * 2 + 1);
					list2.Add(k * 2 + 2);
					list2.Add(k * 2 + 1);
					list2.Add(k * 2 + 3);
					list2.Add(k * 2 + 2);
				}
				else
				{
					list2.Add(k * 2 + 2);
					list2.Add(k * 2 + 1);
					list2.Add(k * 2);
					list2.Add(k * 2 + 2);
					list2.Add(k * 2 + 3);
					list2.Add(k * 2 + 1);
				}
			}
			mesh.triangles = list2.ToArray();
			return mesh;
		}

		private Mesh CreateSphereColliderMesh()
		{
			Mesh mesh = new Mesh();
			Vector3[] array = new Vector3[4];
			(myCanvas.transform as RectTransform).GetWorldCorners(array);
			List<Vector3> list = new List<Vector3>(array);
			for (int i = 0; i < list.Count; i++)
			{
				list[i] = mySettings.transform.worldToLocalMatrix.MultiplyPoint3x4(list[i]);
			}
			if (mySettings.Angle != 0)
			{
				int count = list.Count;
				for (int j = 0; j < count; j += 4)
				{
					ModifyQuad(list, j, mySettings.GetTesslationSize(modifiedByQuality: false));
				}
				list.RemoveRange(0, count);
				float num = mySettings.VerticalAngle;
				float num2 = mySettings.Angle;
				Vector2 size = (myCanvas.transform as RectTransform).rect.size;
				float num3 = mySettings.GetCyllinderRadiusInCanvasSpace();
				if (mySettings.PreserveAspect)
				{
					num = (float)mySettings.Angle * (size.y / size.x);
				}
				else
				{
					num3 = size.x / 2f;
				}
				for (int k = 0; k < list.Count; k++)
				{
					float num4 = (list[k].x / size.x).Remap(-0.5f, 0.5f, (180f - num2) / 2f - 90f, 180f - (180f - num2) / 2f - 90f);
					num4 *= (float)Math.PI / 180f;
					float num5 = (list[k].y / size.y).Remap(-0.5f, 0.5f, (180f - num) / 2f, 180f - (180f - num) / 2f);
					num5 *= (float)Math.PI / 180f;
					list[k] = new Vector3(Mathf.Sin(num5) * Mathf.Sin(num4) * num3, (0f - num3) * Mathf.Cos(num5), Mathf.Sin(num5) * Mathf.Cos(num4) * num3 + (mySettings.PreserveAspect ? (0f - num3) : 0f));
				}
			}
			mesh.vertices = list.ToArray();
			List<int> list2 = new List<int>();
			for (int l = 0; l < list.Count; l += 4)
			{
				list2.Add(l);
				list2.Add(l + 1);
				list2.Add(l + 2);
				list2.Add(l + 3);
				list2.Add(l);
				list2.Add(l + 2);
			}
			mesh.triangles = list2.ToArray();
			return mesh;
		}

		private bool IsInLayerMask(int layer, LayerMask layermask)
		{
			return (int)layermask == ((int)layermask | (1 << layer));
		}

		private LayerMask GetRaycastLayerMask()
		{
			return CurvedUIInputModule.Instance.RaycastLayerMask;
		}

		private float AngleSigned(Vector3 v1, Vector3 v2, Vector3 n)
		{
			return Mathf.Atan2(Vector3.Dot(n, Vector3.Cross(v1, v2)), Vector3.Dot(v1, v2)) * 57.29578f;
		}

		private bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			if (!useDragThreshold)
			{
				return true;
			}
			return (pressPos - currentPos).sqrMagnitude >= threshold * threshold;
		}

		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
			GameObject newEnterTarget = pointerEvent.pointerCurrentRaycast.gameObject;
			HandlePointerExitAndEnter(pointerEvent, newEnterTarget);
		}

		protected void UpdateSelectedObjects(PointerEventData eventData)
		{
			bool flag = false;
			foreach (GameObject item in eventData.hovered)
			{
				if (item == eventData.selectedObject)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				eventData.selectedObject = null;
			}
			foreach (GameObject item2 in eventData.hovered)
			{
				if (item2 == null)
				{
					continue;
				}
				gph = item2.GetComponent<Graphic>();
				if (!(item2.GetComponent<Selectable>() != null) || !(gph != null) || gph.depth == -1 || !gph.raycastTarget)
				{
					continue;
				}
				if (eventData.selectedObject != item2)
				{
					eventData.selectedObject = item2;
				}
				break;
			}
			if (mySettings.ControlMethod == CurvedUIInputModule.CUIControlMethod.GAZE && eventData.IsPointerMoving() && eventData.pointerDrag != null && !eventData.dragging && ShouldStartDrag(eventData.pressPosition, eventData.position, EventSystem.current.pixelDragThreshold, eventData.useDragThreshold))
			{
				ExecuteEvents.Execute(eventData.pointerDrag, eventData, ExecuteEvents.beginDragHandler);
				eventData.dragging = true;
			}
		}

		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
			if (newEnterTarget == null || currentPointerData.pointerEnter == null)
			{
				for (int i = 0; i < currentPointerData.hovered.Count; i++)
				{
					ExecuteEvents.Execute(currentPointerData.hovered[i], currentPointerData, ExecuteEvents.pointerExitHandler);
				}
				currentPointerData.hovered.Clear();
				if (newEnterTarget == null)
				{
					currentPointerData.pointerEnter = newEnterTarget;
					return;
				}
			}
			if (currentPointerData.pointerEnter == newEnterTarget && (bool)newEnterTarget)
			{
				return;
			}
			GameObject gameObject = FindCommonRoot(currentPointerData.pointerEnter, newEnterTarget);
			if (currentPointerData.pointerEnter != null)
			{
				Transform parent = currentPointerData.pointerEnter.transform;
				while (parent != null && (!(gameObject != null) || !(gameObject.transform == parent)))
				{
					ExecuteEvents.Execute(parent.gameObject, currentPointerData, ExecuteEvents.pointerExitHandler);
					currentPointerData.hovered.Remove(parent.gameObject);
					parent = parent.parent;
				}
			}
			currentPointerData.pointerEnter = newEnterTarget;
			if (newEnterTarget != null)
			{
				Transform parent2 = newEnterTarget.transform;
				while (parent2 != null && parent2.gameObject != gameObject)
				{
					ExecuteEvents.Execute(parent2.gameObject, currentPointerData, ExecuteEvents.pointerEnterHandler);
					currentPointerData.hovered.Add(parent2.gameObject);
					parent2 = parent2.parent;
				}
			}
		}

		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			if (g1 == null || g2 == null)
			{
				return null;
			}
			Transform parent = g1.transform;
			while (parent != null)
			{
				Transform parent2 = g2.transform;
				while (parent2 != null)
				{
					if (parent == parent2)
					{
						return parent.gameObject;
					}
					parent2 = parent2.parent;
				}
				parent = parent.parent;
			}
			return null;
		}

		private bool GetScreenSpacePointByRay(Ray ray, out Vector2 o_positionOnCanvas)
		{
			switch (mySettings.Shape)
			{
			case CurvedUISettings.CurvedUIShape.CYLINDER:
				return RaycastToCyllinderCanvas(ray, out o_positionOnCanvas);
			case CurvedUISettings.CurvedUIShape.CYLINDER_VERTICAL:
				return RaycastToCyllinderVerticalCanvas(ray, out o_positionOnCanvas);
			case CurvedUISettings.CurvedUIShape.RING:
				return RaycastToRingCanvas(ray, out o_positionOnCanvas);
			case CurvedUISettings.CurvedUIShape.SPHERE:
				return RaycastToSphereCanvas(ray, out o_positionOnCanvas);
			default:
				o_positionOnCanvas = Vector2.zero;
				return false;
			}
		}

		private bool CheckEventCamera()
		{
			if (myCanvas.worldCamera == null)
			{
				if ((bool)CurvedUIInputModule.Instance && (bool)CurvedUIInputModule.Instance.EventCamera)
				{
					myCanvas.worldCamera = CurvedUIInputModule.Instance.EventCamera;
				}
				else if ((bool)Camera.main)
				{
					myCanvas.worldCamera = Camera.main;
				}
			}
			return myCanvas.worldCamera != null;
		}

		public void RebuildCollider()
		{
			cyllinderMidPoint = new Vector3(0f, 0f, 0f - mySettings.GetCyllinderRadiusInCanvasSpace());
			CreateCollider();
		}

		public List<GameObject> GetObjectsUnderPointer()
		{
			if (objectsUnderPointer == null)
			{
				objectsUnderPointer = new List<GameObject>();
			}
			return objectsUnderPointer;
		}

		public List<GameObject> GetObjectsUnderScreenPos(Vector2 screenPos, Camera eventCamera = null)
		{
			if (eventCamera == null)
			{
				eventCamera = myCanvas.worldCamera;
			}
			return GetObjectsHitByRay(eventCamera.ScreenPointToRay(screenPos));
		}

		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			List<GameObject> list = new List<GameObject>();
			if (!GetScreenSpacePointByRay(ray, out var o_positionOnCanvas))
			{
				return list;
			}
			List<Graphic> list2 = new List<Graphic>();
			IList<Graphic> graphicsForCanvas = GraphicRegistry.GetGraphicsForCanvas(myCanvas);
			for (int i = 0; i < graphicsForCanvas.Count; i++)
			{
				Graphic graphic = graphicsForCanvas[i];
				if (graphic.depth != -1 && graphic.raycastTarget && RectTransformUtility.RectangleContainsScreenPoint(graphic.rectTransform, o_positionOnCanvas, eventCamera) && graphic.Raycast(o_positionOnCanvas, eventCamera))
				{
					list2.Add(graphic);
				}
			}
			list2.Sort((Graphic g1, Graphic g2) => g2.depth.CompareTo(g1.depth));
			for (int j = 0; j < list2.Count; j++)
			{
				list.Add(list2[j].gameObject);
			}
			list2.Clear();
			return list;
		}

		public void Click()
		{
			for (int i = 0; i < GetObjectsUnderPointer().Count; i++)
			{
				if ((bool)GetObjectsUnderPointer()[i].GetComponent<Slider>())
				{
					Slider component = GetObjectsUnderPointer()[i].GetComponent<Slider>();
					RectTransformUtility.ScreenPointToLocalPointInRectangle(component.handleRect.parent as RectTransform, lastFrameEventData.position, myCanvas.worldCamera, out var localPoint);
					localPoint -= component.handleRect.parent.GetComponent<RectTransform>().rect.position;
					if (component.direction == Slider.Direction.LeftToRight || component.direction == Slider.Direction.RightToLeft)
					{
						component.normalizedValue = localPoint.x / (component.handleRect.parent as RectTransform).rect.width;
					}
					else
					{
						component.normalizedValue = localPoint.y / (component.handleRect.parent as RectTransform).rect.height;
					}
					GetObjectsUnderPointer()[i].GetComponent<Slider>().fillRect.GetComponent<Graphic>().SetAllDirty();
				}
				else
				{
					ExecuteEvents.Execute(GetObjectsUnderPointer()[i], lastFrameEventData, ExecuteEvents.pointerDownHandler);
					ExecuteEvents.Execute(GetObjectsUnderPointer()[i], lastFrameEventData, ExecuteEvents.pointerClickHandler);
					ExecuteEvents.Execute(GetObjectsUnderPointer()[i], lastFrameEventData, ExecuteEvents.pointerUpHandler);
				}
			}
		}

		private void ModifyQuad(List<Vector3> verts, int vertexIndex, Vector2 requiredSize)
		{
			List<Vector3> list = new List<Vector3>();
			for (int i = 0; i < 4; i++)
			{
				list.Add(verts[vertexIndex + i]);
			}
			Vector3 vector = list[2] - list[1];
			Vector3 vector2 = list[1] - list[0];
			int num = Mathf.CeilToInt(vector.magnitude * (1f / Mathf.Max(1f, requiredSize.x)));
			int num2 = Mathf.CeilToInt(vector2.magnitude * (1f / Mathf.Max(1f, requiredSize.y)));
			float y = 0f;
			for (int j = 0; j < num2; j++)
			{
				float num3 = ((float)j + 1f) / (float)num2;
				float x = 0f;
				for (int k = 0; k < num; k++)
				{
					float num4 = ((float)k + 1f) / (float)num;
					verts.Add(TesselateQuad(list, x, y));
					verts.Add(TesselateQuad(list, x, num3));
					verts.Add(TesselateQuad(list, num4, num3));
					verts.Add(TesselateQuad(list, num4, y));
					x = num4;
				}
				y = num3;
			}
		}

		private Vector3 TesselateQuad(List<Vector3> quad, float x, float y)
		{
			Vector3 zero = Vector3.zero;
			List<float> list = new List<float>
			{
				(1f - x) * (1f - y),
				(1f - x) * y,
				x * y,
				x * (1f - y)
			};
			for (int i = 0; i < 4; i++)
			{
				zero += quad[i] * list[i];
			}
			return zero;
		}
	}
	[AddComponentMenu("CurvedUI/CurvedUISettings")]
	[RequireComponent(typeof(Canvas))]
	public class CurvedUISettings : MonoBehaviour
	{
		public enum CurvedUIShape
		{
			CYLINDER,
			RING,
			SPHERE,
			CYLINDER_VERTICAL
		}

		public const string Version = "3.3";

		[SerializeField]
		private CurvedUIShape shape;

		[SerializeField]
		private float quality = 1f;

		[SerializeField]
		private bool interactable = true;

		[SerializeField]
		private bool blocksRaycasts = true;

		[SerializeField]
		private bool forceUseBoxCollider = false;

		[SerializeField]
		private int angle = 90;

		[SerializeField]
		private bool preserveAspect = true;

		[SerializeField]
		private int vertAngle = 90;

		[SerializeField]
		private float ringFill = 0.5f;

		[SerializeField]
		private int ringExternalDiamater = 1000;

		[SerializeField]
		private bool ringFlipVertical = false;

		private int baseCircleSegments = 16;

		private Vector2 savedRectSize;

		private float savedRadius;

		private Canvas myCanvas;

		private RectTransform m_rectTransform;

		private RectTransform RectTransform
		{
			get
			{
				if (m_rectTransform == null)
				{
					m_rectTransform = base.transform as RectTransform;
				}
				return m_rectTransform;
			}
		}

		public int BaseCircleSegments => baseCircleSegments;

		public int Angle
		{
			get
			{
				return angle;
			}
			set
			{
				if (angle != value)
				{
					SetUIAngle(value);
				}
			}
		}

		public float Quality
		{
			get
			{
				return quality;
			}
			set
			{
				if (quality != value)
				{
					quality = value;
					SetUIAngle(angle);
				}
			}
		}

		public CurvedUIShape Shape
		{
			get
			{
				return shape;
			}
			set
			{
				if (shape != value)
				{
					shape = value;
					SetUIAngle(angle);
				}
			}
		}

		public int VerticalAngle
		{
			get
			{
				return vertAngle;
			}
			set
			{
				if (vertAngle != value)
				{
					vertAngle = value;
					SetUIAngle(angle);
				}
			}
		}

		public float RingFill
		{
			get
			{
				return ringFill;
			}
			set
			{
				if (ringFill != value)
				{
					ringFill = value;
					SetUIAngle(angle);
				}
			}
		}

		public float SavedRadius
		{
			get
			{
				if (savedRadius == 0f)
				{
					savedRadius = GetCyllinderRadiusInCanvasSpace();
				}
				return savedRadius;
			}
		}

		public int RingExternalDiameter
		{
			get
			{
				return ringExternalDiamater;
			}
			set
			{
				if (ringExternalDiamater != value)
				{
					ringExternalDiamater = value;
					SetUIAngle(angle);
				}
			}
		}

		public bool RingFlipVertical
		{
			get
			{
				return ringFlipVertical;
			}
			set
			{
				if (ringFlipVertical != value)
				{
					ringFlipVertical = value;
					SetUIAngle(angle);
				}
			}
		}

		public bool PreserveAspect
		{
			get
			{
				return preserveAspect;
			}
			set
			{
				if (preserveAspect != value)
				{
					preserveAspect = value;
					SetUIAngle(angle);
				}
			}
		}

		public bool Interactable
		{
			get
			{
				return interactable;
			}
			set
			{
				interactable = value;
			}
		}

		public bool ForceUseBoxCollider
		{
			get
			{
				return forceUseBoxCollider;
			}
			set
			{
				forceUseBoxCollider = value;
			}
		}

		public bool BlocksRaycasts
		{
			get
			{
				return blocksRaycasts;
			}
			set
			{
				if (blocksRaycasts != value)
				{
					blocksRaycasts = value;
					if (Application.isPlaying && GetComponent<CurvedUIRaycaster>() != null)
					{
						GetComponent<CurvedUIRaycaster>().RebuildCollider();
					}
				}
			}
		}

		[Obsolete("Use RaycastLayerMask property instead.")]
		public bool RaycastMyLayerOnly
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		public bool PointingAtCanvas
		{
			get
			{
				if (GetComponent<CurvedUIRaycaster>() != null)
				{
					return GetComponent<CurvedUIRaycaster>().PointingAtCanvas;
				}
				UnityEngine.Debug.LogWarning("CURVEDUI: Can't check if user is pointing at this canvas - No CurvedUIRaycaster is added to this canvas.");
				return false;
			}
		}

		public CurvedUIInputModule.CUIControlMethod ControlMethod
		{
			get
			{
				return CurvedUIInputModule.ControlMethod;
			}
			set
			{
				CurvedUIInputModule.ControlMethod = value;
			}
		}

		public bool GazeUseTimedClick
		{
			get
			{
				return CurvedUIInputModule.Instance.GazeUseTimedClick;
			}
			set
			{
				CurvedUIInputModule.Instance.GazeUseTimedClick = value;
			}
		}

		public float GazeClickTimer
		{
			get
			{
				return CurvedUIInputModule.Instance.GazeClickTimer;
			}
			set
			{
				CurvedUIInputModule.Instance.GazeClickTimer = value;
			}
		}

		public float GazeClickTimerDelay
		{
			get
			{
				return CurvedUIInputModule.Instance.GazeClickTimerDelay;
			}
			set
			{
				CurvedUIInputModule.Instance.GazeClickTimerDelay = value;
			}
		}

		public float GazeTimerProgress => CurvedUIInputModule.Instance.GazeTimerProgress;

		private void Awake()
		{
			if (base.gameObject.layer == 0)
			{
				base.gameObject.layer = 5;
			}
			savedRectSize = RectTransform.rect.size;
		}

		private void Start()
		{
			if (Application.isPlaying)
			{
				BaseRaycaster[] components = GetComponents<BaseRaycaster>();
				BaseRaycaster[] array = components;
				foreach (BaseRaycaster baseRaycaster in array)
				{
					if (!(baseRaycaster is CurvedUIRaycaster))
					{
						baseRaycaster.enabled = false;
					}
				}
				base.gameObject.AddComponentIfMissing<CurvedUIRaycaster>();
				Canvas[] componentsInChildren = GetComponentsInChildren<Canvas>();
				Canvas[] array2 = componentsInChildren;
				foreach (Canvas canvas in array2)
				{
					if (canvas.gameObject != base.gameObject)
					{
						Transform parent = canvas.transform;
						string text = parent.name;
						while (parent.parent != null)
						{
							text = parent.parent.name + "/" + text;
							parent = parent.parent;
						}
						UnityEngine.Debug.LogWarning("CURVEDUI: Interactions on nested canvases are not supported. You won't be able to interact with any child object of [" + text + "]", canvas.gameObject);
					}
				}
			}
			if (myCanvas == null)
			{
				myCanvas = GetComponent<Canvas>();
			}
			savedRadius = GetCyllinderRadiusInCanvasSpace();
		}

		private void OnEnable()
		{
			Graphic[] componentsInChildren = GetComponentsInChildren<Graphic>();
			foreach (Graphic graphic in componentsInChildren)
			{
				graphic.SetAllDirty();
			}
		}

		private void OnDisable()
		{
			Graphic[] componentsInChildren = GetComponentsInChildren<Graphic>();
			foreach (Graphic graphic in componentsInChildren)
			{
				graphic.SetAllDirty();
			}
		}

		private void Update()
		{
			if (RectTransform.rect.size != savedRectSize)
			{
				savedRectSize = RectTransform.rect.size;
				SetUIAngle(angle);
			}
			if (savedRectSize.x == 0f || savedRectSize.y == 0f)
			{
				UnityEngine.Debug.LogError("CurvedUI: Your Canvas size must be bigger than 0!");
			}
		}

		private void SetUIAngle(int newAngle)
		{
			if (myCanvas == null)
			{
				myCanvas = GetComponent<Canvas>();
			}
			if (newAngle == 0)
			{
				newAngle = 1;
			}
			angle = newAngle;
			savedRadius = GetCyllinderRadiusInCanvasSpace();
			CurvedUIVertexEffect[] componentsInChildren = GetComponentsInChildren<CurvedUIVertexEffect>();
			foreach (CurvedUIVertexEffect curvedUIVertexEffect in componentsInChildren)
			{
				curvedUIVertexEffect.SetDirty();
			}
			Graphic[] componentsInChildren2 = GetComponentsInChildren<Graphic>();
			foreach (Graphic graphic in componentsInChildren2)
			{
				graphic.SetAllDirty();
			}
			if (Application.isPlaying && GetComponent<CurvedUIRaycaster>() != null)
			{
				GetComponent<CurvedUIRaycaster>().RebuildCollider();
			}
		}

		private Vector3 CanvasToCyllinder(Vector3 pos)
		{
			float f = pos.x / savedRectSize.x * (float)Angle * ((float)Math.PI / 180f);
			pos.x = Mathf.Sin(f) * (SavedRadius + pos.z);
			pos.z += Mathf.Cos(f) * (SavedRadius + pos.z) - (SavedRadius + pos.z);
			return pos;
		}

		private Vector3 CanvasToCyllinderVertical(Vector3 pos)
		{
			float f = pos.y / savedRectSize.y * (float)Angle * ((float)Math.PI / 180f);
			pos.y = Mathf.Sin(f) * (SavedRadius + pos.z);
			pos.z += Mathf.Cos(f) * (SavedRadius + pos.z) - (SavedRadius + pos.z);
			return pos;
		}

		private Vector3 CanvasToRing(Vector3 pos)
		{
			float num = pos.y.Remap(savedRectSize.y * 0.5f * (float)(RingFlipVertical ? 1 : (-1)), (0f - savedRectSize.y) * 0.5f * (float)(RingFlipVertical ? 1 : (-1)), (float)RingExternalDiameter * (1f - RingFill) * 0.5f, (float)RingExternalDiameter * 0.5f);
			float f = (pos.x / savedRectSize.x).Remap(-0.5f, 0.5f, (float)Math.PI / 2f, (float)angle * ((float)Math.PI / 180f) + (float)Math.PI / 2f);
			pos.x = num * Mathf.Cos(f);
			pos.y = num * Mathf.Sin(f);
			return pos;
		}

		private Vector3 CanvasToSphere(Vector3 pos)
		{
			float num = SavedRadius;
			float num2 = VerticalAngle;
			if (PreserveAspect)
			{
				num2 = (float)angle * (savedRectSize.y / savedRectSize.x);
				num += ((Angle > 0) ? (0f - pos.z) : pos.z);
			}
			else
			{
				num = savedRectSize.x / 2f + pos.z;
				if (num2 == 0f)
				{
					return Vector3.zero;
				}
			}
			float num3 = (pos.x / savedRectSize.x).Remap(-0.5f, 0.5f, (float)(180 - angle) / 2f - 90f, 180f - (float)(180 - angle) / 2f - 90f);
			num3 *= (float)Math.PI / 180f;
			float num4 = (pos.y / savedRectSize.y).Remap(-0.5f, 0.5f, (180f - num2) / 2f, 180f - (180f - num2) / 2f);
			num4 *= (float)Math.PI / 180f;
			pos.z = Mathf.Sin(num4) * Mathf.Cos(num3) * num;
			pos.y = (0f - num) * Mathf.Cos(num4);
			pos.x = Mathf.Sin(num4) * Mathf.Sin(num3) * num;
			if (PreserveAspect)
			{
				pos.z -= num;
			}
			return pos;
		}

		public void AddEffectToChildren()
		{
			Graphic[] componentsInChildren = GetComponentsInChildren<Graphic>(includeInactive: true);
			foreach (Graphic graphic in componentsInChildren)
			{
				if (graphic.GetComponent<CurvedUIVertexEffect>() == null)
				{
					graphic.gameObject.AddComponent<CurvedUIVertexEffect>();
					graphic.SetAllDirty();
				}
			}
			InputField[] componentsInChildren2 = GetComponentsInChildren<InputField>(includeInactive: true);
			foreach (InputField inputField in componentsInChildren2)
			{
				if (inputField.GetComponent<CurvedUIInputFieldCaret>() == null)
				{
					inputField.gameObject.AddComponent<CurvedUIInputFieldCaret>();
				}
			}
			TextMeshProUGUI[] componentsInChildren3 = GetComponentsInChildren<TextMeshProUGUI>(includeInactive: true);
			foreach (TextMeshProUGUI textMeshProUGUI in componentsInChildren3)
			{
				if (textMeshProUGUI.GetComponent<CurvedUITMP>() == null)
				{
					textMeshProUGUI.gameObject.AddComponent<CurvedUITMP>();
					textMeshProUGUI.SetAllDirty();
				}
			}
			TMP_InputField[] componentsInChildren4 = GetComponentsInChildren<TMP_InputField>(includeInactive: true);
			foreach (TMP_InputField go in componentsInChildren4)
			{
				go.AddComponentIfMissing<CurvedUITMPInputFieldCaret>();
			}
		}

		public Vector3 VertexPositionToCurvedCanvas(Vector3 pos)
		{
			return Shape switch
			{
				CurvedUIShape.CYLINDER => CanvasToCyllinder(pos), 
				CurvedUIShape.CYLINDER_VERTICAL => CanvasToCyllinderVertical(pos), 
				CurvedUIShape.RING => CanvasToRing(pos), 
				CurvedUIShape.SPHERE => CanvasToSphere(pos), 
				_ => Vector3.zero, 
			};
		}

		public Vector3 CanvasToCurvedCanvas(Vector3 pos)
		{
			pos = VertexPositionToCurvedCanvas(pos);
			if (float.IsNaN(pos.x) || float.IsInfinity(pos.x))
			{
				return Vector3.zero;
			}
			return base.transform.localToWorldMatrix.MultiplyPoint3x4(pos);
		}

		public Vector3 CanvasToCurvedCanvasNormal(Vector3 pos)
		{
			pos = VertexPositionToCurvedCanvas(pos);
			switch (Shape)
			{
			case CurvedUIShape.CYLINDER:
				return base.transform.localToWorldMatrix.MultiplyVector((pos - new Vector3(0f, 0f, 0f - GetCyllinderRadiusInCanvasSpace())).ModifyY(0f)).normalized;
			case CurvedUIShape.CYLINDER_VERTICAL:
				return base.transform.localToWorldMatrix.MultiplyVector((pos - new Vector3(0f, 0f, 0f - GetCyllinderRadiusInCanvasSpace())).ModifyX(0f)).normalized;
			case CurvedUIShape.RING:
				return -base.transform.forward;
			case CurvedUIShape.SPHERE:
			{
				Vector3 vector = (PreserveAspect ? new Vector3(0f, 0f, 0f - GetCyllinderRadiusInCanvasSpace()) : Vector3.zero);
				return base.transform.localToWorldMatrix.MultiplyVector(pos - vector).normalized;
			}
			default:
				return Vector3.zero;
			}
		}

		public bool RaycastToCanvasSpace(Ray ray, out Vector2 o_positionOnCanvas)
		{
			CurvedUIRaycaster component = GetComponent<CurvedUIRaycaster>();
			o_positionOnCanvas = Vector2.zero;
			return Shape switch
			{
				CurvedUIShape.CYLINDER => component.RaycastToCyllinderCanvas(ray, out o_positionOnCanvas, OutputInCanvasSpace: true), 
				CurvedUIShape.CYLINDER_VERTICAL => component.RaycastToCyllinderVerticalCanvas(ray, out o_positionOnCanvas, OutputInCanvasSpace: true), 
				CurvedUIShape.RING => component.RaycastToRingCanvas(ray, out o_positionOnCanvas, OutputInCanvasSpace: true), 
				CurvedUIShape.SPHERE => component.RaycastToSphereCanvas(ray, out o_positionOnCanvas, OutputInCanvasSpace: true), 
				_ => false, 
			};
		}

		public float GetCyllinderRadiusInCanvasSpace()
		{
			float num = ((!PreserveAspect) ? (RectTransform.rect.size.x * 0.5f / Mathf.Sin(Mathf.Clamp(angle, -180f, 180f) * 0.5f * ((float)Math.PI / 180f))) : ((shape != CurvedUIShape.CYLINDER_VERTICAL) ? (RectTransform.rect.size.x / ((float)Math.PI * 2f * ((float)angle / 360f))) : (RectTransform.rect.size.y / ((float)Math.PI * 2f * ((float)angle / 360f)))));
			return (angle == 0) ? 0f : num;
		}

		public Vector2 GetTesslationSize(bool modifiedByQuality = true)
		{
			Vector2 size = RectTransform.rect.size;
			if (Angle != 0 || (!PreserveAspect && vertAngle != 0))
			{
				switch (shape)
				{
				case CurvedUIShape.CYLINDER:
				case CurvedUIShape.RING:
				case CurvedUIShape.CYLINDER_VERTICAL:
					size /= GetSegmentsByAngle(angle);
					break;
				case CurvedUIShape.SPHERE:
					size.x /= GetSegmentsByAngle(angle);
					if (PreserveAspect)
					{
						size.y = size.x * RectTransform.rect.size.y / RectTransform.rect.size.x;
					}
					else
					{
						size.y /= GetSegmentsByAngle(VerticalAngle);
					}
					break;
				}
			}
			return size / (modifiedByQuality ? Mathf.Clamp(Quality, 0.01f, 10f) : 1f);
		}

		private float GetSegmentsByAngle(float angle)
		{
			if (angle.Abs() <= 1f)
			{
				return 1f;
			}
			if (angle.Abs() < 90f)
			{
				return (float)baseCircleSegments * Mathf.Abs(angle).Remap(0f, 90f, 0.01f, 0.5f);
			}
			return (float)baseCircleSegments * Mathf.Abs(angle).Remap(90f, 360f, 0.5f, 1f);
		}

		public void SetAllChildrenDirty(bool recalculateCurveOnly = false)
		{
			CurvedUIVertexEffect[] componentsInChildren = GetComponentsInChildren<CurvedUIVertexEffect>();
			foreach (CurvedUIVertexEffect curvedUIVertexEffect in componentsInChildren)
			{
				if (recalculateCurveOnly)
				{
					curvedUIVertexEffect.SetDirty();
				}
				else
				{
					curvedUIVertexEffect.CurvingRequired = true;
				}
			}
		}

		public void Click()
		{
			if (GetComponent<CurvedUIRaycaster>() != null)
			{
				GetComponent<CurvedUIRaycaster>().Click();
			}
		}

		public List<GameObject> GetObjectsUnderPointer()
		{
			if (GetComponent<CurvedUIRaycaster>() != null)
			{
				return GetComponent<CurvedUIRaycaster>().GetObjectsUnderPointer();
			}
			return new List<GameObject>();
		}

		public List<GameObject> GetObjectsUnderScreenPos(Vector2 pos, Camera eventCamera = null)
		{
			if (eventCamera == null)
			{
				eventCamera = myCanvas.worldCamera;
			}
			if (GetComponent<CurvedUIRaycaster>() != null)
			{
				return GetComponent<CurvedUIRaycaster>().GetObjectsUnderScreenPos(pos, eventCamera);
			}
			return new List<GameObject>();
		}

		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			if (GetComponent<CurvedUIRaycaster>() != null)
			{
				return GetComponent<CurvedUIRaycaster>().GetObjectsHitByRay(ray);
			}
			return new List<GameObject>();
		}
	}
	public class CurvedUIVertexEffect : BaseMeshEffect
	{
		[Tooltip("Check to skip tesselation pass on this object. CurvedUI will not create additional vertices to make this object have a smoother curve. Checking this can solve some issues if you create your own procedural mesh for this object. Default false.")]
		public bool DoNotTesselate = false;

		private Canvas myCanvas;

		private CurvedUISettings mySettings;

		private Graphic myGraphic;

		private Text myText;

		private TextMeshProUGUI myTMP;

		private CurvedUITMPSubmesh myTMPSubMesh;

		private bool m_tesselationRequired = true;

		private bool curvingRequired = true;

		private bool TransformMisaligned = false;

		private Matrix4x4 CanvasToWorld;

		private Matrix4x4 CanvasToLocal;

		private Matrix4x4 MyToWorld;

		private Matrix4x4 MyToLocal;

		private List<UIVertex> m_tesselatedVerts = new List<UIVertex>();

		private List<UIVertex> m_curvedVerts = new List<UIVertex>();

		private List<UIVertex> m_vertsInQuads = new List<UIVertex>();

		private UIVertex m_ret;

		private UIVertex[] m_quad = new UIVertex[4];

		private float[] m_weights = new float[4];

		[SerializeField]
		[HideInInspector]
		private Vector3 savedPos;

		[SerializeField]
		[HideInInspector]
		private Vector3 savedUp;

		[SerializeField]
		[HideInInspector]
		private Vector2 savedRectSize;

		[SerializeField]
		[HideInInspector]
		private Color savedColor;

		[SerializeField]
		[HideInInspector]
		private Vector2 savedTextUV0;

		[SerializeField]
		[HideInInspector]
		private float savedFill;

		private Vector2 _uv0;

		private Vector2 _uv1;

		private Vector3 _pos;

		private bool tesselationRequired
		{
			get
			{
				return m_tesselationRequired;
			}
			set
			{
				m_tesselationRequired = value;
			}
		}

		public bool TesselationRequired
		{
			get
			{
				return tesselationRequired;
			}
			set
			{
				tesselationRequired = value;
			}
		}

		public bool CurvingRequired
		{
			get
			{
				return curvingRequired;
			}
			set
			{
				curvingRequired = value;
			}
		}

		protected override void Awake()
		{
			base.Awake();
			myGraphic = GetComponent<Graphic>();
			myText = GetComponent<Text>();
			myTMP = GetComponent<TextMeshProUGUI>();
			myTMPSubMesh = GetComponent<CurvedUITMPSubmesh>();
		}

		protected override void OnEnable()
		{
			FindParentSettings();
			if ((bool)myGraphic)
			{
				myGraphic.RegisterDirtyMaterialCallback(TesselationRequiredCallback);
				myGraphic.SetVerticesDirty();
			}
			if ((bool)myText)
			{
				myText.RegisterDirtyVerticesCallback(TesselationRequiredCallback);
				Font.textureRebuilt += FontTextureRebuiltCallback;
			}
		}

		protected override void Start()
		{
			base.Start();
			if ((bool)myCanvas && (bool)GetComponent<Selectable>())
			{
				Vector3 vector = myCanvas.transform.worldToLocalMatrix.MultiplyPoint3x4(base.transform.position);
				RectTransform rectTransform = myCanvas.transform as RectTransform;
				if (vector.x.Abs() > rectTransform.rect.width / 2f || vector.y.Abs() > rectTransform.rect.height / 2f)
				{
					UnityEngine.Debug.LogWarning("CurvedUI: " + GetComponent<Selectable>().GetType().Name + " \"" + base.gameObject.name + "\" is outside of the canvas. It will not be interactable. Move it inside the canvas rectangle (white border in scene view) for it to work.", base.gameObject);
				}
				if (vector.z.Abs() > 0.1f)
				{
					UnityEngine.Debug.LogWarning("CurvedUI: The Z position of \"" + base.gameObject.name + "\" " + GetComponent<Selectable>().GetType().Name + ", or one of its parents is not 0 in relation to the canvas. The interactions may not be accurate.", base.gameObject);
				}
			}
		}

		protected override void OnDisable()
		{
			if ((bool)myGraphic)
			{
				myGraphic.UnregisterDirtyMaterialCallback(TesselationRequiredCallback);
			}
			if ((bool)myText)
			{
				myText.UnregisterDirtyVerticesCallback(TesselationRequiredCallback);
				Font.textureRebuilt -= FontTextureRebuiltCallback;
			}
		}

		private void TesselationRequiredCallback()
		{
			tesselationRequired = true;
		}

		private void FontTextureRebuiltCallback(Font fontie)
		{
			if (myText.font == fontie)
			{
				tesselationRequired = true;
			}
		}

		private void LateUpdate()
		{
			if ((bool)myTMP || (bool)myTMPSubMesh)
			{
				return;
			}
			if (!tesselationRequired)
			{
				if ((base.transform as RectTransform).rect.size != savedRectSize)
				{
					tesselationRequired = true;
				}
				else if (myGraphic != null)
				{
					if (myGraphic.color != savedColor)
					{
						tesselationRequired = true;
						savedColor = myGraphic.color;
					}
					else if (myGraphic is Image && (myGraphic as Image).fillAmount != savedFill)
					{
						tesselationRequired = true;
						savedFill = (myGraphic as Image).fillAmount;
					}
				}
			}
			if (!tesselationRequired && !curvingRequired)
			{
				Vector3 a = mySettings.transform.worldToLocalMatrix.MultiplyPoint3x4(base.transform.position);
				if (!a.AlmostEqual(savedPos) && (mySettings.Shape != 0 || (double)Mathf.Pow(a.x - savedPos.x, 2f) > 1E-05 || (double)Mathf.Pow(a.z - savedPos.z, 2f) > 1E-05))
				{
					savedPos = a;
					curvingRequired = true;
				}
				Vector3 normalized = mySettings.transform.worldToLocalMatrix.MultiplyVector(base.transform.up).normalized;
				if (!savedUp.AlmostEqual(normalized, 0.0001))
				{
					bool flag = normalized.AlmostEqual(Vector3.up.normalized);
					bool flag2 = savedUp.AlmostEqual(Vector3.up.normalized);
					if ((!flag && flag2) || (flag && !flag2))
					{
						tesselationRequired = true;
					}
					savedUp = normalized;
					curvingRequired = true;
				}
			}
			if ((bool)myGraphic && (tesselationRequired || curvingRequired))
			{
				myGraphic.SetVerticesDirty();
			}
		}

		public override void ModifyMesh(VertexHelper vh)
		{
			if (!ShouldModify())
			{
				return;
			}
			CheckTextFontMaterial();
			if (tesselationRequired || !Application.isPlaying)
			{
				if (m_tesselatedVerts == null)
				{
					m_tesselatedVerts = new List<UIVertex>();
				}
				else
				{
					m_tesselatedVerts.Clear();
				}
				vh.GetUIVertexStream(m_tesselatedVerts);
				TesselateGeometry(m_tesselatedVerts);
				savedRectSize = (base.transform as RectTransform).rect.size;
				tesselationRequired = false;
				curvingRequired = true;
			}
			if (curvingRequired)
			{
				CanvasToWorld = myCanvas.transform.localToWorldMatrix;
				CanvasToLocal = myCanvas.transform.worldToLocalMatrix;
				MyToWorld = base.transform.localToWorldMatrix;
				MyToLocal = base.transform.worldToLocalMatrix;
				if (m_curvedVerts == null)
				{
					m_curvedVerts = new List<UIVertex>();
				}
				if (m_curvedVerts.Count == m_tesselatedVerts.Count)
				{
					for (int i = 0; i < m_curvedVerts.Count; i++)
					{
						m_curvedVerts[i] = CurveVertex(m_tesselatedVerts[i], mySettings.Angle, mySettings.GetCyllinderRadiusInCanvasSpace(), (myCanvas.transform as RectTransform).rect.size);
					}
				}
				else
				{
					m_curvedVerts.Clear();
					for (int j = 0; j < m_tesselatedVerts.Count; j++)
					{
						m_curvedVerts.Add(CurveVertex(m_tesselatedVerts[j], mySettings.Angle, mySettings.GetCyllinderRadiusInCanvasSpace(), (myCanvas.transform as RectTransform).rect.size));
					}
				}
				curvingRequired = false;
			}
			vh.Clear();
			if (m_curvedVerts.Count % 4 == 0)
			{
				for (int k = 0; k < m_curvedVerts.Count; k += 4)
				{
					int currentVertCount = vh.currentVertCount;
					for (int l = 0; l < 4; l++)
					{
						vh.AddVert(m_curvedVerts[k + l]);
					}
					vh.AddTriangle(currentVertCount, currentVertCount + 1, currentVertCount + 2);
					vh.AddTriangle(currentVertCount + 2, currentVertCount + 3, currentVertCount);
				}
			}
			else
			{
				vh.AddUIVertexTriangleStream(m_curvedVerts);
			}
		}

		public void ModifyTMPMesh(ref List<UIVertex> vertexList)
		{
			if (!ShouldModify())
			{
				return;
			}
			CheckTextFontMaterial();
			tesselationRequired = false;
			curvingRequired = true;
			if (curvingRequired)
			{
				CanvasToWorld = myCanvas.transform.localToWorldMatrix;
				CanvasToLocal = myCanvas.transform.worldToLocalMatrix;
				MyToWorld = base.transform.localToWorldMatrix;
				MyToLocal = base.transform.worldToLocalMatrix;
				for (int i = 0; i < vertexList.Count; i++)
				{
					vertexList[i] = CurveVertex(vertexList[i], mySettings.Angle, mySettings.GetCyllinderRadiusInCanvasSpace(), (myCanvas.transform as RectTransform).rect.size);
				}
				curvingRequired = false;
			}
		}

		private bool ShouldModify()
		{
			if (!IsActive())
			{
				return false;
			}
			if (mySettings == null)
			{
				FindParentSettings();
			}
			if (mySettings == null || !mySettings.enabled || mySettings.Angle == 1)
			{
				return false;
			}
			return true;
		}

		private void CheckTextFontMaterial()
		{
			if ((bool)myText && myText.cachedTextGenerator.verts.Count > 0 && myText.cachedTextGenerator.verts[0].uv0 != savedTextUV0)
			{
				savedTextUV0 = myText.cachedTextGenerator.verts[0].uv0;
				tesselationRequired = true;
			}
		}

		public CurvedUISettings FindParentSettings(bool forceNew = false)
		{
			if (mySettings == null || forceNew)
			{
				mySettings = GetComponentInParent<CurvedUISettings>();
				if (mySettings == null)
				{
					return null;
				}
				myCanvas = mySettings.GetComponent<Canvas>();
			}
			return mySettings;
		}

		private UIVertex CurveVertex(UIVertex input, float cylinder_angle, float radius, Vector2 canvasSize)
		{
			Vector3 position = input.position;
			position = CanvasToLocal.MultiplyPoint3x4(MyToWorld.MultiplyPoint3x4(position));
			if (mySettings.Shape == CurvedUISettings.CurvedUIShape.CYLINDER && mySettings.Angle != 0)
			{
				float f = position.x / canvasSize.x * cylinder_angle * ((float)Math.PI / 180f);
				radius += position.z;
				position.x = Mathf.Sin(f) * radius;
				position.z += Mathf.Cos(f) * radius - radius;
			}
			else if (mySettings.Shape == CurvedUISettings.CurvedUIShape.CYLINDER_VERTICAL && mySettings.Angle != 0)
			{
				float f2 = position.y / canvasSize.y * cylinder_angle * ((float)Math.PI / 180f);
				radius += position.z;
				position.y = Mathf.Sin(f2) * radius;
				position.z += Mathf.Cos(f2) * radius - radius;
			}
			else if (mySettings.Shape == CurvedUISettings.CurvedUIShape.RING)
			{
				float num = 0f;
				float num2 = position.y.Remap(canvasSize.y * 0.5f * (float)(mySettings.RingFlipVertical ? 1 : (-1)), (0f - canvasSize.y) * 0.5f * (float)(mySettings.RingFlipVertical ? 1 : (-1)), (float)mySettings.RingExternalDiameter * (1f - mySettings.RingFill) * 0.5f, (float)mySettings.RingExternalDiameter * 0.5f);
				float f3 = (position.x / canvasSize.x).Remap(-0.5f, 0.5f, (float)Math.PI / 2f, cylinder_angle * ((float)Math.PI / 180f) + (float)Math.PI / 2f) - num;
				position.x = num2 * Mathf.Cos(f3);
				position.y = num2 * Mathf.Sin(f3);
			}
			else if (mySettings.Shape == CurvedUISettings.CurvedUIShape.SPHERE && mySettings.Angle != 0)
			{
				float num3 = mySettings.VerticalAngle;
				float num4 = 0f - position.z;
				if (mySettings.PreserveAspect)
				{
					num3 = cylinder_angle * (canvasSize.y / canvasSize.x);
				}
				else
				{
					radius = canvasSize.x / 2f;
					if (num3 == 0f)
					{
						return input;
					}
				}
				float num5 = (position.x / canvasSize.x).Remap(-0.5f, 0.5f, (180f - cylinder_angle) / 2f - 90f, 180f - (180f - cylinder_angle) / 2f - 90f);
				num5 *= (float)Math.PI / 180f;
				float num6 = (position.y / canvasSize.y).Remap(-0.5f, 0.5f, (180f - num3) / 2f, 180f - (180f - num3) / 2f);
				num6 *= (float)Math.PI / 180f;
				position.z = Mathf.Sin(num6) * Mathf.Cos(num5) * (radius + num4);
				position.y = (0f - (radius + num4)) * Mathf.Cos(num6);
				position.x = Mathf.Sin(num6) * Mathf.Sin(num5) * (radius + num4);
				if (mySettings.PreserveAspect)
				{
					position.z -= radius;
				}
			}
			input.position = MyToLocal.MultiplyPoint3x4(CanvasToWorld.MultiplyPoint3x4(position));
			return input;
		}

		private void TesselateGeometry(List<UIVertex> verts)
		{
			Vector2 tesslationSize = mySettings.GetTesslationSize();
			TransformMisaligned = !savedUp.AlmostEqual(Vector3.up.normalized);
			TrisToQuads(verts);
			if (myText == null && myTMP == null && !DoNotTesselate)
			{
				int count = verts.Count;
				for (int i = 0; i < count; i += 4)
				{
					ModifyQuad(verts, i, tesslationSize);
				}
				verts.RemoveRange(0, count);
			}
		}

		private void ModifyQuad(List<UIVertex> verts, int vertexIndex, Vector2 requiredSize)
		{
			for (int i = 0; i < 4; i++)
			{
				m_quad[i] = verts[vertexIndex + i];
			}
			Vector3 vector = m_quad[2].position - m_quad[1].position;
			Vector3 vector2 = m_quad[1].position - m_quad[0].position;
			if (myGraphic != null && myGraphic is Image && (myGraphic as Image).type == Image.Type.Filled)
			{
				vector = ((vector.x > (m_quad[3].position - m_quad[0].position).x) ? vector : (m_quad[3].position - m_quad[0].position));
				vector2 = ((vector2.y > (m_quad[2].position - m_quad[3].position).y) ? vector2 : (m_quad[2].position - m_quad[3].position));
			}
			int num = 1;
			int num2 = 1;
			if (TransformMisaligned || mySettings.Shape == CurvedUISettings.CurvedUIShape.SPHERE || mySettings.Shape == CurvedUISettings.CurvedUIShape.CYLINDER_VERTICAL)
			{
				num2 = Mathf.CeilToInt(vector2.magnitude * (1f / Mathf.Max(0.0001f, requiredSize.y)));
			}
			if (TransformMisaligned || mySettings.Shape != CurvedUISettings.CurvedUIShape.CYLINDER_VERTICAL)
			{
				num = Mathf.CeilToInt(vector.magnitude * (1f / Mathf.Max(0.0001f, requiredSize.x)));
			}
			bool flag = false;
			bool flag2 = false;
			float y = 0f;
			for (int j = 0; j < num2 || !flag; j++)
			{
				flag = true;
				float num3 = ((float)j + 1f) / (float)num2;
				float x = 0f;
				for (int k = 0; k < num || !flag2; k++)
				{
					flag2 = true;
					float num4 = ((float)k + 1f) / (float)num;
					verts.Add(TesselateQuad(x, y));
					verts.Add(TesselateQuad(x, num3));
					verts.Add(TesselateQuad(num4, num3));
					verts.Add(TesselateQuad(num4, y));
					x = num4;
				}
				y = num3;
			}
		}

		private void TrisToQuads(List<UIVertex> verts)
		{
			int count = verts.Count;
			m_vertsInQuads.Clear();
			for (int i = 0; i < count; i += 6)
			{
				m_vertsInQuads.Add(verts[i]);
				m_vertsInQuads.Add(verts[i + 1]);
				m_vertsInQuads.Add(verts[i + 2]);
				m_vertsInQuads.Add(verts[i + 4]);
			}
			verts.AddRange(m_vertsInQuads);
			verts.RemoveRange(0, count);
		}

		private UIVertex TesselateQuad(float x, float y)
		{
			m_weights[0] = (1f - x) * (1f - y);
			m_weights[1] = (1f - x) * y;
			m_weights[2] = x * y;
			m_weights[3] = x * (1f - y);
			_uv0 = (_uv1 = Vector2.zero);
			_pos = Vector3.zero;
			for (int i = 0; i < 4; i++)
			{
				_uv0 += m_quad[i].uv0 * m_weights[i];
				_uv1 += m_quad[i].uv1 * m_weights[i];
				_pos += m_quad[i].position * m_weights[i];
			}
			m_ret.position = _pos;
			m_ret.color = m_quad[0].color;
			m_ret.uv0 = _uv0;
			m_ret.uv1 = _uv1;
			m_ret.uv2 = m_quad[0].uv2;
			m_ret.uv3 = m_quad[0].uv3;
			m_ret.normal = m_quad[0].normal;
			m_ret.tangent = m_quad[0].tangent;
			return m_ret;
		}

		public void SetDirty()
		{
			TesselationRequired = true;
		}
	}
	public class CurvedUIViveController : MonoBehaviour
	{
	}
	public struct ViveInputArgs
	{
		public uint controllerIndex;

		public float buttonPressure;

		public Vector2 touchpadAxis;
	}
	public delegate void ViveInputEvent(object sender, ViveInputArgs e);
	public delegate void ViveEvent(object sender);
	[ExecuteInEditMode]
	public class CurvedUITMP : MonoBehaviour
	{
		private CurvedUIVertexEffect crvdVE;

		private TextMeshProUGUI tmpText;

		private CurvedUISettings mySettings;

		private List<UIVertex> m_UIVerts = new List<UIVertex>();

		private UIVertex m_tempVertex;

		private CurvedUITMPSubmesh m_tempSubMsh;

		private Vector2 savedSize;

		private Vector3 savedUp;

		private Vector3 savedPos;

		private Vector3 savedLocalScale;

		private Vector3 savedGlobalScale;

		private List<CurvedUITMPSubmesh> subMeshes = new List<CurvedUITMPSubmesh>();

		public bool Dirty = false;

		private bool curvingRequired = false;

		private bool tesselationRequired = false;

		private bool quitting = false;

		private Vector3[] vertices;

		private void Start()
		{
			if (mySettings == null)
			{
				mySettings = GetComponentInParent<CurvedUISettings>();
			}
		}

		private void OnEnable()
		{
			FindTMP();
			if ((bool)tmpText)
			{
				tmpText.RegisterDirtyMaterialCallback(TesselationRequiredCallback);
				TMPro_EventManager.TEXT_CHANGED_EVENT.Add(TMPTextChangedCallback);
				tmpText.SetText(tmpText.text);
			}
		}

		private void OnDisable()
		{
			if ((bool)tmpText)
			{
				tmpText.UnregisterDirtyMaterialCallback(TesselationRequiredCallback);
				TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(TMPTextChangedCallback);
			}
		}

		private void OnDestroy()
		{
			quitting = true;
		}

		private void LateUpdate()
		{
			if (!tmpText)
			{
				FindTMP();
			}
			if (mySettings == null || !tmpText || quitting)
			{
				return;
			}
			if (ShouldTesselate())
			{
				tesselationRequired = true;
			}
			if (Dirty || tesselationRequired || (curvingRequired && !Application.isPlaying))
			{
				if (mySettings == null)
				{
					base.enabled = false;
					return;
				}
				tmpText.renderMode = TextRenderFlags.Render;
				tmpText.ForceMeshUpdate(ignoreActiveState: true);
				CreateUIVertexList(tmpText.mesh);
				crvdVE.ModifyTMPMesh(ref m_UIVerts);
				FillMeshWithUIVertexList(tmpText.mesh, m_UIVerts);
				tmpText.renderMode = TextRenderFlags.DontRender;
				savedLocalScale = mySettings.transform.localScale;
				savedGlobalScale = mySettings.transform.lossyScale;
				savedSize = (base.transform as RectTransform).rect.size;
				savedUp = mySettings.transform.worldToLocalMatrix.MultiplyVector(base.transform.up);
				savedPos = mySettings.transform.worldToLocalMatrix.MultiplyPoint3x4(base.transform.position);
				tesselationRequired = false;
				curvingRequired = false;
				Dirty = false;
				FindSubmeshes();
				foreach (CurvedUITMPSubmesh subMesh in subMeshes)
				{
					subMesh.UpdateSubmesh(tesselate: true, curve: false);
				}
			}
			if (tmpText.text.Length > 0)
			{
				tmpText.canvasRenderer.SetMesh(tmpText.mesh);
			}
			else
			{
				tmpText.canvasRenderer.Clear();
			}
		}

		private void CreateUIVertexList(Mesh mesh)
		{
			if (mesh.vertexCount < m_UIVerts.Count)
			{
				m_UIVerts.RemoveRange(mesh.vertexCount, m_UIVerts.Count - mesh.vertexCount);
			}
			vertices = mesh.vertices;
			for (int i = 0; i < mesh.vertexCount; i++)
			{
				if (m_UIVerts.Count <= i)
				{
					m_tempVertex = default(UIVertex);
					GetUIVertexFromMesh(ref m_tempVertex, i);
					m_UIVerts.Add(m_tempVertex);
				}
				else
				{
					m_tempVertex = m_UIVerts[i];
					GetUIVertexFromMesh(ref m_tempVertex, i);
					m_UIVerts[i] = m_tempVertex;
				}
			}
		}

		private void GetUIVertexFromMesh(ref UIVertex vert, int i)
		{
			vert.position = vertices[i];
		}

		private void FillMeshWithUIVertexList(Mesh mesh, List<UIVertex> list)
		{
			if (list.Count >= 65536)
			{
				UnityEngine.Debug.LogError("CURVEDUI: Unity UI Mesh can not have more than 65536 vertices. Remove some UI elements or lower quality.");
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				vertices[i] = list[i].position;
			}
			mesh.vertices = vertices;
			mesh.RecalculateBounds();
		}

		private void FindTMP()
		{
			if (GetComponent<TextMeshProUGUI>() != null)
			{
				tmpText = base.gameObject.GetComponent<TextMeshProUGUI>();
				crvdVE = base.gameObject.GetComponent<CurvedUIVertexEffect>();
				mySettings = GetComponentInParent<CurvedUISettings>();
				base.transform.hasChanged = false;
				FindSubmeshes();
			}
		}

		private void FindSubmeshes()
		{
			TMP_SubMeshUI[] componentsInChildren = GetComponentsInChildren<TMP_SubMeshUI>();
			foreach (TMP_SubMeshUI tMP_SubMeshUI in componentsInChildren)
			{
				m_tempSubMsh = tMP_SubMeshUI.gameObject.AddComponentIfMissing<CurvedUITMPSubmesh>();
				if (!subMeshes.Contains(m_tempSubMsh))
				{
					subMeshes.Add(m_tempSubMsh);
				}
			}
		}

		private bool ShouldTesselate()
		{
			if (savedSize != (base.transform as RectTransform).rect.size)
			{
				return true;
			}
			if (savedLocalScale != mySettings.transform.localScale)
			{
				return true;
			}
			if (savedGlobalScale != mySettings.transform.lossyScale)
			{
				return true;
			}
			if (!savedUp.AlmostEqual(mySettings.transform.worldToLocalMatrix.MultiplyVector(base.transform.up)))
			{
				return true;
			}
			Vector3 b = mySettings.transform.worldToLocalMatrix.MultiplyPoint3x4(base.transform.position);
			if (!savedPos.AlmostEqual(b) && (mySettings.Shape != 0 || (double)Mathf.Pow(b.x - savedPos.x, 2f) > 1E-05 || (double)Mathf.Pow(b.z - savedPos.z, 2f) > 1E-05))
			{
				return true;
			}
			return false;
		}

		private void TMPTextChangedCallback(object obj)
		{
			if (obj == tmpText)
			{
				tesselationRequired = true;
			}
		}

		private void TesselationRequiredCallback()
		{
			tesselationRequired = true;
			curvingRequired = true;
		}
	}
	[ExecuteInEditMode]
	public class CurvedUITMPInputFieldCaret : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
	{
		private TMP_InputField myField;

		private RectTransform myCaret;

		private Color origCaretColor;

		private Color origSelectionColor;

		private bool selected = false;

		private bool selectingText = false;

		public Color CaretColor
		{
			get
			{
				return origCaretColor;
			}
			set
			{
				origCaretColor = value;
			}
		}

		public Color SelectionColor
		{
			get
			{
				return origSelectionColor;
			}
			set
			{
				origSelectionColor = value;
			}
		}

		public float CaretBlinkRate
		{
			get
			{
				return myField.caretBlinkRate;
			}
			set
			{
				myField.caretBlinkRate = value;
			}
		}

		private void Awake()
		{
			myField = GetComponent<TMP_InputField>();
			if ((bool)myField)
			{
				CheckAndConvertMask();
			}
		}

		private void Update()
		{
			if (selected)
			{
				UpdateCaret();
			}
		}

		public void OnSelect(BaseEventData eventData)
		{
			if (myCaret == null)
			{
				CreateCaret();
			}
			selected = true;
			myCaret.gameObject.SetActive(value: true);
			StartCoroutine(CaretBlinker());
		}

		public void OnDeselect(BaseEventData eventData)
		{
			selected = false;
			myCaret.gameObject.SetActive(value: false);
		}

		private IEnumerator CaretBlinker()
		{
			while (selected)
			{
				myCaret.gameObject.SetActive(selectingText || !myCaret.gameObject.activeSelf);
				yield return new WaitForSeconds(0.5f / myField.caretBlinkRate);
			}
		}

		private void CreateCaret()
		{
			GameObject gameObject = new GameObject("CurvedUI_TMPCaret");
			gameObject.AddComponent<RectTransform>();
			gameObject.AddComponent<Image>();
			gameObject.AddComponent<CurvedUIVertexEffect>();
			gameObject.transform.SetParent(base.transform.GetChild(0).GetChild(0));
			gameObject.transform.localScale = Vector3.one;
			(gameObject.transform as RectTransform).anchoredPosition3D = Vector3.zero;
			(gameObject.transform as RectTransform).pivot = new Vector2(0f, 1f);
			gameObject.GetComponent<Image>().color = myField.caretColor;
			myCaret = gameObject.transform as RectTransform;
			gameObject.transform.SetAsFirstSibling();
			myField.customCaretColor = true;
			origCaretColor = myField.caretColor;
			myField.caretColor = new Color(0f, 0f, 0f, 0f);
			origSelectionColor = myField.selectionColor;
			myField.selectionColor = new Color(0f, 0f, 0f, 0f);
			gameObject.gameObject.SetActive(value: false);
		}

		private void UpdateCaret()
		{
			if (myCaret == null)
			{
				CreateCaret();
			}
			Vector2 localPositionInText = GetLocalPositionInText(myField.caretPosition);
			if (myField.selectionFocusPosition != myField.selectionAnchorPosition)
			{
				selectingText = true;
				Vector2 vector = new Vector2(GetLocalPositionInText(myField.selectionAnchorPosition).x - GetLocalPositionInText(myField.selectionFocusPosition).x, GetLocalPositionInText(myField.selectionAnchorPosition).y - GetLocalPositionInText(myField.selectionFocusPosition).y);
				localPositionInText = ((vector.x < 0f) ? GetLocalPositionInText(myField.selectionAnchorPosition) : GetLocalPositionInText(myField.selectionFocusPosition));
				vector = new Vector2(Mathf.Abs(vector.x), Mathf.Abs(vector.y) + myField.textComponent.fontSize);
				myCaret.sizeDelta = new Vector2(vector.x, vector.y);
				myCaret.anchoredPosition = localPositionInText;
				myCaret.GetComponent<Image>().color = origSelectionColor;
			}
			else
			{
				selectingText = false;
				myCaret.sizeDelta = new Vector2(myField.caretWidth, myField.textComponent.fontSize);
				myCaret.anchoredPosition = localPositionInText;
				myCaret.GetComponent<Image>().color = origCaretColor;
			}
		}

		private Vector2 GetLocalPositionInText(int charNo)
		{
			if (myField.isFocused)
			{
				TMP_TextInfo textInfo = myField.textComponent.textInfo;
				if (charNo > textInfo.characterCount - 1)
				{
					charNo = textInfo.characterCount - 1;
				}
				TMP_CharacterInfo tMP_CharacterInfo = textInfo.characterInfo[charNo];
				return new Vector2(tMP_CharacterInfo.topLeft.x, tMP_CharacterInfo.ascender);
			}
			return Vector2.zero;
		}

		private void CheckAndConvertMask()
		{
			foreach (Transform item in base.transform)
			{
				if (item.GetComponent<RectMask2D>() != null)
				{
					UnityEngine.Object.DestroyImmediate(item.GetComponent<RectMask2D>());
					item.AddComponentIfMissing<Image>();
					item.AddComponentIfMissing<Mask>();
				}
			}
		}
	}
	[ExecuteInEditMode]
	public class CurvedUITMPSubmesh : MonoBehaviour
	{
		private VertexHelper vh;

		private Mesh straightMesh;

		private Mesh curvedMesh;

		private CurvedUIVertexEffect crvdVE;

		private TMP_SubMeshUI TMPsub;

		private TextMeshProUGUI TMPtext;

		public void UpdateSubmesh(bool tesselate, bool curve)
		{
			if (TMPsub == null)
			{
				TMPsub = base.gameObject.GetComponent<TMP_SubMeshUI>();
			}
			if (!(TMPsub == null))
			{
				if (TMPtext == null)
				{
					TMPtext = GetComponentInParent<TextMeshProUGUI>();
				}
				if (crvdVE == null)
				{
					crvdVE = base.gameObject.AddComponentIfMissing<CurvedUIVertexEffect>();
				}
				if (tesselate || straightMesh == null || vh == null || !Application.isPlaying)
				{
					vh = new VertexHelper(TMPsub.mesh);
					straightMesh = new Mesh();
					vh.FillMesh(straightMesh);
					curve = true;
				}
				if (curve)
				{
					vh = new VertexHelper(straightMesh);
					crvdVE.ModifyMesh(vh);
					curvedMesh = new Mesh();
					vh.FillMesh(curvedMesh);
					crvdVE.CurvingRequired = true;
				}
				TMPsub.canvasRenderer.SetMesh(curvedMesh);
				if (TMPtext != null && TMPtext.textInfo.materialCount < 2)
				{
					TMPsub.enabled = false;
					TMPsub.enabled = true;
				}
			}
		}
	}
	[Conditional("UNITY_CCU")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public class OptionalDependencyAttribute : Attribute
	{
		public string dependentClass;

		public string define;

		public OptionalDependencyAttribute(string dependentClass, string define)
		{
			this.dependentClass = dependentClass;
			this.define = define;
		}
	}
}
