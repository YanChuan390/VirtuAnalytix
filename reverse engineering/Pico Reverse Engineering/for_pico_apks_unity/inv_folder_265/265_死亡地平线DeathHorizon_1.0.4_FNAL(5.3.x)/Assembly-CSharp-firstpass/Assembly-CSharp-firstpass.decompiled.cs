using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using AOT;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using RootMotion.Dynamics;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public class GooglePlayDownloader
{
	private static AndroidJavaClass detectAndroidJNI;

	private static AndroidJavaClass Environment;

	private const string Environment_MEDIA_MOUNTED = "mounted";

	private static string obb_package;

	private static int obb_version;

	public static bool RunningOnAndroid()
	{
		if (detectAndroidJNI == null)
		{
			detectAndroidJNI = new AndroidJavaClass("android.os.Build");
		}
		return detectAndroidJNI.GetRawClass() != IntPtr.Zero;
	}

	static GooglePlayDownloader()
	{
		if (!RunningOnAndroid())
		{
			return;
		}
		Environment = new AndroidJavaClass("android.os.Environment");
		using AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.plugin.downloader.UnityDownloaderService");
		androidJavaClass.SetStatic("BASE64_PUBLIC_KEY", "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAmtjQs019ieISeod2PR2hWinBIGPs4DrhzY3aHngcTy3NEWwDwi2ECJyRMBNqVcmEk73i1tt1gcwAHW9V8hsdZdF/aLbZeg6/7NwkDWhN5VZ4yiEerYRCeJo3L8GTVpckG3veF2JqOoekyqg9Ur4J6DRHb7FxSzxIUAKtfe8N65/PjyQka/Lg+999g98xwcrTF4fu6ESr66kYrGl8S+IMTNTSGcfXuc2WQm6NEaciMaoZr06Px/zRL5kqyQ013PjMJMgXd9eA1cTwhRgtynq4JpSXLE3b1rP3gMywCYWHPOThcHX5IDrwnVCLcrT80jh9ZLkQi3bxHPFyp09ISuJa2wIDAQAB");
		androidJavaClass.SetStatic("SALT", new byte[20]
		{
			1, 43, 244, 255, 54, 98, 156, 244, 43, 2,
			248, 252, 9, 5, 150, 148, 223, 45, 255, 84
		});
	}

	public static string GetExpansionFilePath()
	{
		populateOBBData();
		if (Environment.CallStatic<string>("getExternalStorageState", Array.Empty<object>()) != "mounted")
		{
			return null;
		}
		using AndroidJavaObject androidJavaObject = Environment.CallStatic<AndroidJavaObject>("getExternalStorageDirectory", Array.Empty<object>());
		string arg = androidJavaObject.Call<string>("getPath", Array.Empty<object>());
		return string.Format("{0}/{1}/{2}", arg, "Android/obb", obb_package);
	}

	public static string GetMainOBBPath(string expansionFilePath)
	{
		populateOBBData();
		if (expansionFilePath == null)
		{
			return null;
		}
		string text = $"{expansionFilePath}/main.{obb_version}.{obb_package}.obb";
		if (!File.Exists(text))
		{
			return null;
		}
		return text;
	}

	public static string GetPatchOBBPath(string expansionFilePath)
	{
		populateOBBData();
		if (expansionFilePath == null)
		{
			return null;
		}
		string text = $"{expansionFilePath}/patch.{obb_version}.{obb_package}.obb";
		if (!File.Exists(text))
		{
			return null;
		}
		return text;
	}

	public static void FetchOBB()
	{
		using AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject @static = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
		AndroidJavaObject androidJavaObject = new AndroidJavaObject("android.content.Intent", @static, new AndroidJavaClass("com.unity3d.plugin.downloader.UnityDownloaderActivity"));
		int num = 65536;
		androidJavaObject.Call<AndroidJavaObject>("addFlags", new object[1] { num });
		androidJavaObject.Call<AndroidJavaObject>("putExtra", new object[2]
		{
			"unityplayer.Activity",
			@static.Call<AndroidJavaObject>("getClass", Array.Empty<object>()).Call<string>("getName", Array.Empty<object>())
		});
		@static.Call("startActivity", androidJavaObject);
		if (AndroidJNI.ExceptionOccurred() != IntPtr.Zero)
		{
			UnityEngine.Debug.LogError("Exception occurred while attempting to start DownloaderActivity - is the AndroidManifest.xml incorrect?");
			AndroidJNI.ExceptionDescribe();
			AndroidJNI.ExceptionClear();
		}
	}

	private static void populateOBBData()
	{
		if (obb_version != 0)
		{
			return;
		}
		using AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject @static = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
		obb_package = @static.Call<string>("getPackageName", Array.Empty<object>());
		obb_version = @static.Call<AndroidJavaObject>("getPackageManager", Array.Empty<object>()).Call<AndroidJavaObject>("getPackageInfo", new object[2] { obb_package, 0 }).Get<int>("versionCode");
	}
}
[AddComponentMenu("")]
public class FMOD_Listener : MonoBehaviour
{
	[Header("This component is obsolete. Use FMODUnity.StudioListener instead")]
	public string[] pluginPaths = new string[0];
}
[AddComponentMenu("")]
public class FMOD_StudioEventEmitter : MonoBehaviour
{
	[Header("This component is obsolete. Use FMODUnity.StudioEventEmitter instead")]
	public FMODAsset asset;

	public string path = "";

	public bool startEventOnAwake = true;
}
public class FMODAsset : ScriptableObject
{
	public string path;

	public string id;
}
[Serializable]
public class FMODEventPlayable : PlayableAsset, ITimelineClipAsset
{
	public FMODEventPlayableBehavior template = new FMODEventPlayableBehavior();

	public float eventLength;

	private FMODEventPlayableBehavior behavior;

	[EventRef]
	[SerializeField]
	public string eventName;

	[SerializeField]
	public STOP_MODE stopType;

	[SerializeField]
	public ParamRef[] parameters = new ParamRef[0];

	public GameObject TrackTargetObject { get; set; }

	public override double duration
	{
		get
		{
			if (eventName == null)
			{
				return base.duration;
			}
			return eventLength;
		}
	}

	public ClipCaps clipCaps => ClipCaps.None;

	public TimelineClip OwningClip { get; set; }

	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		ScriptPlayable<FMODEventPlayableBehavior> scriptPlayable = ScriptPlayable<FMODEventPlayableBehavior>.Create(graph, template);
		behavior = scriptPlayable.GetBehaviour();
		behavior.TrackTargetObject = TrackTargetObject;
		behavior.eventName = eventName;
		behavior.stopType = stopType;
		behavior.parameters = parameters;
		behavior.OwningClip = OwningClip;
		return scriptPlayable;
	}
}
public enum STOP_MODE
{
	AllowFadeout,
	Immediate,
	None
}
public class FMODEventPlayableBehavior : PlayableBehaviour
{
	public string eventName;

	public STOP_MODE stopType;

	public ParamRef[] parameters = new ParamRef[0];

	public GameObject TrackTargetObject;

	public TimelineClip OwningClip;

	private bool isPlayheadInside;

	private FMOD.Studio.EventInstance eventInstance;

	protected void PlayEvent()
	{
		if (eventName == null)
		{
			return;
		}
		if (!eventInstance.isValid())
		{
			eventInstance = RuntimeManager.CreateInstance(eventName);
		}
		if (Application.isPlaying && (bool)TrackTargetObject)
		{
			Rigidbody component = TrackTargetObject.GetComponent<Rigidbody>();
			if ((bool)component)
			{
				RuntimeManager.AttachInstanceToGameObject(eventInstance, TrackTargetObject.transform, component);
			}
			else
			{
				RuntimeManager.AttachInstanceToGameObject(eventInstance, TrackTargetObject.transform, TrackTargetObject.GetComponent<Rigidbody2D>());
			}
		}
		else
		{
			eventInstance.set3DAttributes(Vector3.zero.To3DAttributes());
		}
		ParamRef[] array = parameters;
		foreach (ParamRef paramRef in array)
		{
			eventInstance.setParameterValue(paramRef.Name, paramRef.Value);
		}
		eventInstance.start();
	}

	public void OnEnter()
	{
		if (!isPlayheadInside)
		{
			PlayEvent();
			isPlayheadInside = true;
		}
	}

	public void OnExit()
	{
		if (!isPlayheadInside)
		{
			return;
		}
		if (eventInstance.isValid())
		{
			if (stopType != STOP_MODE.None)
			{
				eventInstance.stop((stopType == STOP_MODE.Immediate) ? FMOD.Studio.STOP_MODE.IMMEDIATE : FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
			}
			eventInstance.release();
		}
		isPlayheadInside = false;
	}

	public void UpdateBehaviour(float time)
	{
		if ((double)time >= OwningClip.start && (double)time < OwningClip.end)
		{
			OnEnter();
		}
		else
		{
			OnExit();
		}
	}

	public override void OnGraphStop(Playable playable)
	{
		isPlayheadInside = false;
		if (eventInstance.isValid())
		{
			eventInstance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
			eventInstance.release();
		}
	}
}
[TrackColor(0.066f, 0.134f, 0.244f)]
[TrackClipType(typeof(FMODEventPlayable))]
[TrackBindingType(typeof(GameObject))]
public class FMODEventTrack : TrackAsset
{
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		GameObject trackTargetObject = go.GetComponent<PlayableDirector>().GetGenericBinding(this) as GameObject;
		foreach (TimelineClip clip in GetClips())
		{
			FMODEventPlayable fMODEventPlayable = clip.asset as FMODEventPlayable;
			if ((bool)fMODEventPlayable)
			{
				fMODEventPlayable.TrackTargetObject = trackTargetObject;
				fMODEventPlayable.OwningClip = clip;
			}
		}
		return ScriptPlayable<FMODEventMixerBehaviour>.Create(graph, inputCount);
	}
}
public class FMODEventMixerBehaviour : PlayableBehaviour
{
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
		int inputCount = playable.GetInputCount();
		float time = (float)playable.GetGraph().GetRootPlayable(0).GetTime();
		for (int i = 0; i < inputCount; i++)
		{
			((ScriptPlayable<FMODEventPlayableBehavior>)playable.GetInput(i)).GetBehaviour().UpdateBehaviour(time);
		}
	}
}
public class Skeleton : MonoBehaviour
{
	public Animator animator;

	public PuppetMaster puppetMaster;

	public ConfigurableJoint[] leftLeg;

	public ConfigurableJoint[] rightLeg;

	private bool leftLegRemoved;

	private bool rightLegRemoved;

	private void Start()
	{
		PuppetMaster obj = puppetMaster;
		obj.OnMuscleRemoved = (PuppetMaster.MuscleDelegate)Delegate.Combine(obj.OnMuscleRemoved, new PuppetMaster.MuscleDelegate(OnMuscleRemoved));
	}

	private void OnMuscleRemoved(Muscle m)
	{
		bool isLeft = false;
		if (IsLegMuscle(m, out isLeft))
		{
			if (isLeft)
			{
				leftLegRemoved = true;
			}
			else
			{
				rightLegRemoved = true;
			}
			if (leftLegRemoved && rightLegRemoved)
			{
				puppetMaster.state = PuppetMaster.State.Dead;
			}
			else
			{
				animator.SetFloat("Legs", 1f);
			}
		}
	}

	private bool IsLegMuscle(Muscle m, out bool isLeft)
	{
		isLeft = false;
		ConfigurableJoint[] array = leftLeg;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == m.joint)
			{
				isLeft = true;
				return true;
			}
		}
		array = rightLeg;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == m.joint)
			{
				isLeft = false;
				return true;
			}
		}
		return false;
	}
}
namespace RootMotion
{
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		public enum UpdateMode
		{
			Update,
			FixedUpdate,
			LateUpdate,
			FixedLateUpdate
		}

		public Transform target;

		public Transform rotationSpace;

		public UpdateMode updateMode = UpdateMode.LateUpdate;

		public bool lockCursor = true;

		[Header("Position")]
		public bool smoothFollow;

		public Vector3 offset = new Vector3(0f, 1.5f, 0.5f);

		public float followSpeed = 10f;

		[Header("Rotation")]
		public float rotationSensitivity = 3.5f;

		public float yMinLimit = -20f;

		public float yMaxLimit = 80f;

		public bool rotateAlways = true;

		public bool rotateOnLeftButton;

		public bool rotateOnRightButton;

		public bool rotateOnMiddleButton;

		[Header("Distance")]
		public float distance = 10f;

		public float minDistance = 4f;

		public float maxDistance = 10f;

		public float zoomSpeed = 10f;

		public float zoomSensitivity = 1f;

		[Header("Blocking")]
		public LayerMask blockingLayers;

		public float blockingRadius = 1f;

		public float blockingSmoothTime = 0.1f;

		[Range(0f, 1f)]
		public float blockedOffset = 0.5f;

		private Vector3 targetDistance;

		private Vector3 position;

		private Quaternion rotation = Quaternion.identity;

		private Vector3 smoothPosition;

		private Camera cam;

		private bool fixedFrame;

		private float fixedDeltaTime;

		private Quaternion r = Quaternion.identity;

		private Vector3 lastUp;

		private float blockedDistance = 10f;

		private float blockedDistanceV;

		public float x { get; private set; }

		public float y { get; private set; }

		public float distanceTarget { get; private set; }

		private float zoomAdd
		{
			get
			{
				float axis = Input.GetAxis("Mouse ScrollWheel");
				if (axis > 0f)
				{
					return 0f - zoomSensitivity;
				}
				if (axis < 0f)
				{
					return zoomSensitivity;
				}
				return 0f;
			}
		}

		protected virtual void Awake()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			x = eulerAngles.y;
			y = eulerAngles.x;
			distanceTarget = distance;
			smoothPosition = base.transform.position;
			cam = GetComponent<Camera>();
			lastUp = ((rotationSpace != null) ? rotationSpace.up : Vector3.up);
		}

		protected virtual void Update()
		{
			if (updateMode == UpdateMode.Update)
			{
				UpdateTransform();
			}
		}

		protected virtual void FixedUpdate()
		{
			fixedFrame = true;
			fixedDeltaTime += Time.deltaTime;
			if (updateMode == UpdateMode.FixedUpdate)
			{
				UpdateTransform();
			}
		}

		protected virtual void LateUpdate()
		{
			UpdateInput();
			if (updateMode == UpdateMode.LateUpdate)
			{
				UpdateTransform();
			}
			if (updateMode == UpdateMode.FixedLateUpdate && fixedFrame)
			{
				UpdateTransform(fixedDeltaTime);
				fixedDeltaTime = 0f;
				fixedFrame = false;
			}
		}

		public void UpdateInput()
		{
			if (cam.enabled)
			{
				Cursor.lockState = (lockCursor ? CursorLockMode.Locked : CursorLockMode.None);
				Cursor.visible = !lockCursor;
				if (rotateAlways || (rotateOnLeftButton && Input.GetMouseButton(0)) || (rotateOnRightButton && Input.GetMouseButton(1)) || (rotateOnMiddleButton && Input.GetMouseButton(2)))
				{
					x += Input.GetAxis("Mouse X") * rotationSensitivity;
					y = ClampAngle(y - Input.GetAxis("Mouse Y") * rotationSensitivity, yMinLimit, yMaxLimit);
				}
				distanceTarget = Mathf.Clamp(distanceTarget + zoomAdd, minDistance, maxDistance);
			}
		}

		public void UpdateTransform()
		{
			UpdateTransform(Time.deltaTime);
		}

		public void UpdateTransform(float deltaTime)
		{
			if (!cam.enabled)
			{
				return;
			}
			rotation = Quaternion.AngleAxis(x, Vector3.up) * Quaternion.AngleAxis(y, Vector3.right);
			if (rotationSpace != null)
			{
				r = Quaternion.FromToRotation(lastUp, rotationSpace.up) * r;
				rotation = r * rotation;
				lastUp = rotationSpace.up;
			}
			if (target != null)
			{
				distance += (distanceTarget - distance) * zoomSpeed * deltaTime;
				if (!smoothFollow)
				{
					smoothPosition = target.position;
				}
				else
				{
					smoothPosition = Vector3.Lerp(smoothPosition, target.position, deltaTime * followSpeed);
				}
				Vector3 vector = smoothPosition + rotation * offset;
				Vector3 vector2 = rotation * -Vector3.forward;
				if ((int)blockingLayers != -1)
				{
					if (Physics.SphereCast(vector, blockingRadius, vector2, out var hitInfo, distanceTarget - blockingRadius, blockingLayers))
					{
						blockedDistance = Mathf.SmoothDamp(blockedDistance, hitInfo.distance + blockingRadius * (1f - blockedOffset), ref blockedDistanceV, blockingSmoothTime);
					}
					else
					{
						blockedDistance = distanceTarget;
					}
					distance = Mathf.Min(distance, blockedDistance);
				}
				position = vector + vector2 * distance;
				base.transform.position = position;
			}
			base.transform.rotation = rotation;
		}

		private float ClampAngle(float angle, float min, float max)
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
	public class CameraControllerFPS : MonoBehaviour
	{
		public float rotationSensitivity = 3f;

		public float yMinLimit = -89f;

		public float yMaxLimit = 89f;

		private float x;

		private float y;

		private void Awake()
		{
			Vector3 eulerAngles = base.transform.eulerAngles;
			x = eulerAngles.y;
			y = eulerAngles.x;
		}

		public void LateUpdate()
		{
			Cursor.lockState = CursorLockMode.Locked;
			x += Input.GetAxis("Mouse X") * rotationSensitivity;
			y = ClampAngle(y - Input.GetAxis("Mouse Y") * rotationSensitivity, yMinLimit, yMaxLimit);
			base.transform.rotation = Quaternion.AngleAxis(x, Vector3.up) * Quaternion.AngleAxis(y, Vector3.right);
		}

		private float ClampAngle(float angle, float min, float max)
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
					array[^1] = transform;
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
					array[^1] = transform;
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
					lastBone = bonesOfTypeAndSide[^1];
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

		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			Quaternion rotation = Quaternion.LookRotation(forwardAxis, upAxis);
			Quaternion quaternion = Quaternion.LookRotation(targetforwardAxis, targetUpAxis);
			return targetRotation * quaternion * Quaternion.Inverse(rotation);
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
	public class SolverManager : MonoBehaviour
	{
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms = true;

		private Animator animator;

		private Animation legacy;

		private bool updateFrame;

		private bool componentInitiated;

		private bool skipSolverUpdate;

		private bool animatePhysics
		{
			get
			{
				if (animator != null)
				{
					return animator.updateMode == AnimatorUpdateMode.AnimatePhysics;
				}
				if (legacy != null)
				{
					return legacy.animatePhysics;
				}
				return false;
			}
		}

		private bool isAnimated
		{
			get
			{
				if (!(animator != null))
				{
					return legacy != null;
				}
				return true;
			}
		}

		public void Disable()
		{
			UnityEngine.Debug.Log("IK.Disable() is deprecated. Use enabled = false instead", base.transform);
			base.enabled = false;
		}

		protected virtual void InitiateSolver()
		{
		}

		protected virtual void UpdateSolver()
		{
		}

		protected virtual void FixTransforms()
		{
		}

		private void OnDisable()
		{
			if (Application.isPlaying)
			{
				Initiate();
			}
		}

		private void Start()
		{
			Initiate();
		}

		private void Initiate()
		{
			if (!componentInitiated)
			{
				FindAnimatorRecursive(base.transform, findInChildren: true);
				InitiateSolver();
				componentInitiated = true;
			}
		}

		private void Update()
		{
			if (!skipSolverUpdate && !animatePhysics && fixTransforms)
			{
				FixTransforms();
			}
		}

		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
			if (isAnimated)
			{
				return;
			}
			animator = t.GetComponent<Animator>();
			legacy = t.GetComponent<Animation>();
			if (!isAnimated)
			{
				if (animator == null && findInChildren)
				{
					animator = t.GetComponentInChildren<Animator>();
				}
				if (legacy == null && findInChildren)
				{
					legacy = t.GetComponentInChildren<Animation>();
				}
				if (!isAnimated && t.parent != null)
				{
					FindAnimatorRecursive(t.parent, findInChildren: false);
				}
			}
		}

		private void FixedUpdate()
		{
			if (skipSolverUpdate)
			{
				skipSolverUpdate = false;
			}
			updateFrame = true;
			if (animatePhysics && fixTransforms)
			{
				FixTransforms();
			}
		}

		private void LateUpdate()
		{
			if (!skipSolverUpdate)
			{
				if (!animatePhysics)
				{
					updateFrame = true;
				}
				if (updateFrame)
				{
					updateFrame = false;
					UpdateSolver();
				}
			}
		}

		public void UpdateSolverExternal()
		{
			if (base.enabled)
			{
				skipSolverUpdate = true;
				UpdateSolver();
			}
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

		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			if (planeNormal == Vector3.up)
			{
				return new Vector3(point.x, planePosition.y, point.z);
			}
			Vector3 tangent = point - planePosition;
			Vector3 normal = planeNormal;
			Vector3.OrthoNormalize(ref normal, ref tangent);
			return planePosition + Vector3.Project(point - planePosition, tangent);
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
	public class InitialVelocity : MonoBehaviour
	{
		public Vector3 initialVelocity;

		private void Start()
		{
			GetComponent<Rigidbody>().velocity = initialVelocity;
		}
	}
	public class AnimationBlocker : MonoBehaviour
	{
		private void LateUpdate()
		{
			base.transform.localPosition = Vector3.zero;
			base.transform.localRotation = Quaternion.identity;
		}
	}
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourAnimatedStagger")]
	public class BehaviourAnimatedStagger : BehaviourBase
	{
		[Serializable]
		public struct FallParams
		{
			public float startPinWeightMlp;

			public float startMuscleWeightMlp;

			public float losePinSpeed;
		}

		[Serializable]
		public struct FallParamsGroup
		{
			public Muscle.Group[] groups;

			public FallParams fallParams;
		}

		[Header("Master Properties")]
		public LayerMask groundLayers;

		public float animationBlendSpeed = 2f;

		public float animationMag = 5f;

		public float momentumMag = 0.1f;

		public float unbalancedMuscleWeightMlp = 0.05f;

		public float unbalancedMuscleDamperAdd = 1f;

		public bool dropProps;

		public float maxGetUpVelocity = 0.3f;

		public float minHipHeight = 0.3f;

		public SubBehaviourCOM centerOfMass;

		[Header("Muscle Group Properties")]
		public FallParams defaults;

		public FallParamsGroup[] groupOverrides;

		[Header("Events")]
		public PuppetEvent onUngrounded;

		public PuppetEvent onFallOver;

		public PuppetEvent onRest;

		[HideInInspector]
		public Vector3 moveVector;

		[HideInInspector]
		public bool isGrounded = true;

		[HideInInspector]
		public Vector3 forward;

		protected override void OnInitiate()
		{
			centerOfMass.Initiate(this, groundLayers);
		}

		protected override void OnActivate()
		{
			StartCoroutine(LoseBalance());
		}

		public override void OnReactivate()
		{
		}

		private IEnumerator LoseBalance()
		{
			Muscle[] muscles = puppetMaster.muscles;
			foreach (Muscle muscle in muscles)
			{
				FallParams fallParams = GetFallParams(muscle.props.group);
				muscle.state.pinWeightMlp = Mathf.Min(muscle.state.pinWeightMlp, fallParams.startPinWeightMlp);
				muscle.state.muscleWeightMlp = Mathf.Min(muscle.state.muscleWeightMlp, fallParams.startMuscleWeightMlp);
				muscle.state.muscleDamperAdd = 0f - puppetMaster.muscleDamper;
			}
			puppetMaster.internalCollisions = true;
			bool done = false;
			while (!done)
			{
				Vector3 b = Quaternion.Inverse(puppetMaster.targetRoot.rotation) * centerOfMass.direction * animationMag;
				moveVector = Vector3.Lerp(moveVector, b, Time.deltaTime * animationBlendSpeed);
				moveVector = Vector3.ClampMagnitude(moveVector, 2f);
				muscles = puppetMaster.muscles;
				foreach (Muscle muscle2 in muscles)
				{
					FallParams fallParams2 = GetFallParams(muscle2.props.group);
					muscle2.state.pinWeightMlp = Mathf.MoveTowards(muscle2.state.pinWeightMlp, 0f, Time.deltaTime * fallParams2.losePinSpeed);
					muscle2.state.mappingWeightMlp = Mathf.MoveTowards(muscle2.state.mappingWeightMlp, 1f, Time.deltaTime * animationBlendSpeed);
				}
				done = true;
				muscles = puppetMaster.muscles;
				foreach (Muscle muscle3 in muscles)
				{
					if (muscle3.state.pinWeightMlp > 0f || muscle3.state.mappingWeightMlp < 1f)
					{
						done = false;
						break;
					}
				}
				if (puppetMaster.muscles[0].rigidbody.position.y - puppetMaster.targetRoot.position.y < minHipHeight)
				{
					done = true;
				}
				yield return null;
			}
			if (dropProps)
			{
				RemoveMusclesOfGroup(Muscle.Group.Prop);
			}
			if (!isGrounded)
			{
				muscles = puppetMaster.muscles;
				foreach (Muscle obj in muscles)
				{
					obj.state.pinWeightMlp = 0f;
					obj.state.muscleWeightMlp = 1f;
				}
				onUngrounded.Trigger(puppetMaster);
				if (onUngrounded.switchBehaviour)
				{
					yield break;
				}
			}
			moveVector = Vector3.zero;
			puppetMaster.mappingWeight = 1f;
			muscles = puppetMaster.muscles;
			foreach (Muscle obj2 in muscles)
			{
				obj2.state.pinWeightMlp = 0f;
				obj2.state.muscleWeightMlp = unbalancedMuscleWeightMlp;
				obj2.state.muscleDamperAdd = unbalancedMuscleDamperAdd;
			}
			onFallOver.Trigger(puppetMaster);
			if (!onFallOver.switchBehaviour)
			{
				yield return new WaitForSeconds(1f);
				while (puppetMaster.muscles[0].rigidbody.velocity.magnitude > maxGetUpVelocity || !isGrounded)
				{
					yield return null;
				}
				onRest.Trigger(puppetMaster);
				_ = onRest.switchBehaviour;
			}
		}

		private FallParams GetFallParams(Muscle.Group group)
		{
			FallParamsGroup[] array = groupOverrides;
			for (int i = 0; i < array.Length; i++)
			{
				FallParamsGroup fallParamsGroup = array[i];
				Muscle.Group[] groups = fallParamsGroup.groups;
				for (int j = 0; j < groups.Length; j++)
				{
					if (groups[j] == group)
					{
						return fallParamsGroup.fallParams;
					}
				}
			}
			return defaults;
		}
	}
	public abstract class BehaviourBase : MonoBehaviour
	{
		public delegate void BehaviourDelegate();

		public delegate void HitDelegate(MuscleHit hit);

		public delegate void CollisionDelegate(MuscleCollision collision);

		[Serializable]
		public struct PuppetEvent
		{
			public string switchToBehaviour;

			public AnimatorEvent[] animations;

			public UnityEvent unityEvent;

			private const string empty = "";

			public bool switchBehaviour
			{
				get
				{
					if (switchToBehaviour != string.Empty)
					{
						return switchToBehaviour != "";
					}
					return false;
				}
			}

			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
				unityEvent.Invoke();
				AnimatorEvent[] array = animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Activate(puppetMaster.targetAnimator, puppetMaster.targetAnimation);
				}
				if (!switchBehaviour)
				{
					return;
				}
				bool flag = false;
				BehaviourBase[] behaviours = puppetMaster.behaviours;
				foreach (BehaviourBase behaviourBase in behaviours)
				{
					if (behaviourBase != null && behaviourBase.GetType().ToString() == "RootMotion.Dynamics." + switchToBehaviour)
					{
						flag = true;
						behaviourBase.enabled = true;
						break;
					}
				}
				if (!flag)
				{
					UnityEngine.Debug.LogWarning("No Puppet Behaviour of type '" + switchToBehaviour + "' was found. Can not switch to the behaviour, please check the spelling (also for empty spaces).");
				}
			}
		}

		[Serializable]
		public class AnimatorEvent
		{
			public string animationState;

			public float crossfadeTime = 0.3f;

			public int layer;

			public bool resetNormalizedTime;

			private const string empty = "";

			public void Activate(Animator animator, Animation animation)
			{
				if (animator != null)
				{
					Activate(animator);
				}
				if (animation != null)
				{
					Activate(animation);
				}
			}

			private void Activate(Animator animator)
			{
				if (animationState == "")
				{
					return;
				}
				if (resetNormalizedTime)
				{
					if (crossfadeTime > 0f)
					{
						animator.CrossFadeInFixedTime(animationState, crossfadeTime, layer, 0f);
					}
					else
					{
						animator.Play(animationState, layer, 0f);
					}
				}
				else if (crossfadeTime > 0f)
				{
					animator.CrossFadeInFixedTime(animationState, crossfadeTime, layer);
				}
				else
				{
					animator.Play(animationState, layer);
				}
			}

			private void Activate(Animation animation)
			{
				if (!(animationState == ""))
				{
					if (resetNormalizedTime)
					{
						animation[animationState].normalizedTime = 0f;
					}
					animation[animationState].layer = layer;
					animation.CrossFade(animationState, crossfadeTime);
				}
			}
		}

		[HideInInspector]
		public PuppetMaster puppetMaster;

		public BehaviourDelegate OnPreActivate;

		public BehaviourDelegate OnPreInitiate;

		public BehaviourDelegate OnPreFixedUpdate;

		public BehaviourDelegate OnPreUpdate;

		public BehaviourDelegate OnPreLateUpdate;

		public BehaviourDelegate OnPreDeactivate;

		public BehaviourDelegate OnPreFixTransforms;

		public BehaviourDelegate OnPreRead;

		public BehaviourDelegate OnPreWrite;

		public HitDelegate OnPreMuscleHit;

		public CollisionDelegate OnPreMuscleCollision;

		public CollisionDelegate OnPreMuscleCollisionExit;

		public BehaviourDelegate OnHierarchyChanged;

		public BehaviourDelegate OnPostActivate;

		public BehaviourDelegate OnPostInitiate;

		public BehaviourDelegate OnPostFixedUpdate;

		public BehaviourDelegate OnPostUpdate;

		public BehaviourDelegate OnPostLateUpdate;

		public BehaviourDelegate OnPostDeactivate;

		public BehaviourDelegate OnPostDrawGizmos;

		public BehaviourDelegate OnPostFixTransforms;

		public BehaviourDelegate OnPostRead;

		public BehaviourDelegate OnPostWrite;

		public HitDelegate OnPostMuscleHit;

		public CollisionDelegate OnPostMuscleCollision;

		public CollisionDelegate OnPostMuscleCollisionExit;

		[HideInInspector]
		public bool deactivated;

		private bool initiated;

		public bool forceActive { get; protected set; }

		public abstract void OnReactivate();

		public virtual void Resurrect()
		{
		}

		public virtual void Freeze()
		{
		}

		public virtual void Unfreeze()
		{
		}

		public virtual void KillStart()
		{
		}

		public virtual void KillEnd()
		{
		}

		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		public virtual void OnMuscleAdded(Muscle m)
		{
			if (OnHierarchyChanged != null)
			{
				OnHierarchyChanged();
			}
		}

		public virtual void OnMuscleRemoved(Muscle m)
		{
			if (OnHierarchyChanged != null)
			{
				OnHierarchyChanged();
			}
		}

		protected virtual void OnActivate()
		{
		}

		protected virtual void OnDeactivate()
		{
		}

		protected virtual void OnInitiate()
		{
		}

		protected virtual void OnFixedUpdate()
		{
		}

		protected virtual void OnUpdate()
		{
		}

		protected virtual void OnLateUpdate()
		{
		}

		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		protected virtual void OnFixTransformsBehaviour()
		{
		}

		protected virtual void OnReadBehaviour()
		{
		}

		protected virtual void OnWriteBehaviour()
		{
		}

		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		public void Initiate()
		{
			initiated = true;
			if (OnPreInitiate != null)
			{
				OnPreInitiate();
			}
			OnInitiate();
			if (OnPostInitiate != null)
			{
				OnPostInitiate();
			}
		}

		public void OnFixTransforms()
		{
			if (initiated && base.enabled)
			{
				if (OnPreFixTransforms != null)
				{
					OnPreFixTransforms();
				}
				OnFixTransformsBehaviour();
				if (OnPostFixTransforms != null)
				{
					OnPostFixTransforms();
				}
			}
		}

		public void OnRead()
		{
			if (initiated && base.enabled)
			{
				if (OnPreRead != null)
				{
					OnPreRead();
				}
				OnReadBehaviour();
				if (OnPostRead != null)
				{
					OnPostRead();
				}
			}
		}

		public void OnWrite()
		{
			if (initiated && base.enabled)
			{
				if (OnPreWrite != null)
				{
					OnPreWrite();
				}
				OnWriteBehaviour();
				if (OnPostWrite != null)
				{
					OnPostWrite();
				}
			}
		}

		public void OnMuscleHit(MuscleHit hit)
		{
			if (initiated)
			{
				if (OnPreMuscleHit != null)
				{
					OnPreMuscleHit(hit);
				}
				OnMuscleHitBehaviour(hit);
				if (OnPostMuscleHit != null)
				{
					OnPostMuscleHit(hit);
				}
			}
		}

		public void OnMuscleCollision(MuscleCollision collision)
		{
			if (initiated)
			{
				if (OnPreMuscleCollision != null)
				{
					OnPreMuscleCollision(collision);
				}
				OnMuscleCollisionBehaviour(collision);
				if (OnPostMuscleCollision != null)
				{
					OnPostMuscleCollision(collision);
				}
			}
		}

		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
			if (initiated)
			{
				if (OnPreMuscleCollisionExit != null)
				{
					OnPreMuscleCollisionExit(collision);
				}
				OnMuscleCollisionExitBehaviour(collision);
				if (OnPostMuscleCollisionExit != null)
				{
					OnPostMuscleCollisionExit(collision);
				}
			}
		}

		private void OnEnable()
		{
			if (initiated)
			{
				Activate();
			}
		}

		public void Activate()
		{
			BehaviourBase[] behaviours = puppetMaster.behaviours;
			foreach (BehaviourBase obj in behaviours)
			{
				obj.enabled = obj == this;
			}
			if (OnPreActivate != null)
			{
				OnPreActivate();
			}
			OnActivate();
			if (OnPostActivate != null)
			{
				OnPostActivate();
			}
		}

		private void OnDisable()
		{
			if (initiated)
			{
				if (OnPreDeactivate != null)
				{
					OnPreDeactivate();
				}
				OnDeactivate();
				if (OnPostDeactivate != null)
				{
					OnPostDeactivate();
				}
			}
		}

		private void FixedUpdate()
		{
			if (initiated && puppetMaster.muscles.Length != 0)
			{
				if (OnPreFixedUpdate != null && base.enabled)
				{
					OnPreFixedUpdate();
				}
				OnFixedUpdate();
				if (OnPostFixedUpdate != null && base.enabled)
				{
					OnPostFixedUpdate();
				}
			}
		}

		private void Update()
		{
			if (initiated && puppetMaster.muscles.Length != 0)
			{
				if (OnPreUpdate != null && base.enabled)
				{
					OnPreUpdate();
				}
				OnUpdate();
				if (OnPostUpdate != null && base.enabled)
				{
					OnPostUpdate();
				}
			}
		}

		private void LateUpdate()
		{
			if (initiated && puppetMaster.muscles.Length != 0)
			{
				if (OnPreLateUpdate != null && base.enabled)
				{
					OnPreLateUpdate();
				}
				OnLateUpdate();
				if (OnPostLateUpdate != null && base.enabled)
				{
					OnPostLateUpdate();
				}
			}
		}

		protected virtual void OnDrawGizmos()
		{
			if (initiated)
			{
				OnDrawGizmosBehaviour();
				if (OnPostDrawGizmos != null)
				{
					OnPostDrawGizmos();
				}
			}
		}

		protected void RotateTargetToRootMuscle()
		{
			Vector3 vector = Quaternion.Inverse(puppetMaster.muscles[0].target.rotation) * puppetMaster.targetRoot.forward;
			Vector3 forward = puppetMaster.muscles[0].rigidbody.rotation * vector;
			forward.y = 0f;
			puppetMaster.targetRoot.rotation = Quaternion.LookRotation(forward);
		}

		protected void TranslateTargetToRootMuscle(float maintainY)
		{
			puppetMaster.muscles[0].target.position = new Vector3(puppetMaster.muscles[0].transform.position.x, Mathf.Lerp(puppetMaster.muscles[0].transform.position.y, puppetMaster.muscles[0].target.position.y, maintainY), puppetMaster.muscles[0].transform.position.z);
		}

		protected void RemoveMusclesOfGroup(Muscle.Group group)
		{
			while (MusclesContainsGroup(group))
			{
				for (int i = 0; i < puppetMaster.muscles.Length; i++)
				{
					if (puppetMaster.muscles[i].props.group == group)
					{
						puppetMaster.RemoveMuscleRecursive(puppetMaster.muscles[i].joint, attachTarget: true);
						break;
					}
				}
			}
		}

		protected virtual void GroundTarget(LayerMask layers)
		{
			if (Physics.Raycast(new Ray(puppetMaster.targetRoot.position + puppetMaster.targetRoot.up, -puppetMaster.targetRoot.up), out var hitInfo, 4f, layers))
			{
				puppetMaster.targetRoot.position = hitInfo.point;
			}
		}

		protected bool MusclesContainsGroup(Muscle.Group group)
		{
			Muscle[] muscles = puppetMaster.muscles;
			for (int i = 0; i < muscles.Length; i++)
			{
				if (muscles[i].props.group == group)
				{
					return true;
				}
			}
			return false;
		}
	}
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourFall")]
	public class BehaviourFall : BehaviourBase
	{
		[LargeHeader("Animation State")]
		[Tooltip("Animation State to crossfade to when this behaviour is activated.")]
		public string stateName = "Falling";

		[Tooltip("The duration of crossfading to 'State Name'. Value is in seconds.")]
		public float transitionDuration = 0.4f;

		[Tooltip("Layer index containing the destination state. If no layer is specified or layer is -1, the first state that is found with the given name or hash will be played.")]
		public int layer;

		[Tooltip("Start time of the current destination state. Value is in seconds. If no explicit fixedTime is specified or fixedTime value is float.NegativeInfinity, the state will either be played from the start if it's not already playing, or will continue playing from its current time and no transition will happen.")]
		public float fixedTime;

		[LargeHeader("Blending")]
		[Tooltip("The layers that will be raycasted against to find colliding objects.")]
		public LayerMask raycastLayers;

		[Tooltip("The parameter in the Animator that blends between catch fall and writhe animations.")]
		public string blendParameter = "FallBlend";

		[Tooltip("The height of the pelvis from the ground at which will blend to writhe animation.")]
		public float writheHeight = 4f;

		[Tooltip("The vertical velocity of the pelvis at which will blend to writhe animation.")]
		public float writheYVelocity = 1f;

		[Tooltip("The speed of blendig between the two falling animations.")]
		public float blendSpeed = 3f;

		[Tooltip("The speed of blending in mapping on activation.")]
		public float blendMappingSpeed = 1f;

		[LargeHeader("Ending")]
		[Tooltip("If false, this behaviour will never end.")]
		public bool canEnd;

		[Tooltip("The minimum time since this behaviour activated before it can end.")]
		public float minTime = 1.5f;

		[Tooltip("If the velocity of the pelvis falls below this value, can end the behaviour.")]
		public float maxEndVelocity = 0.5f;

		[Tooltip("Event triggered when all end conditions are met.")]
		public PuppetEvent onEnd;

		private float timer;

		private bool endTriggered;

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://root-motion.com/puppetmasterdox/html/page11.html");
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://root-motion.com/puppetmasterdox/html/class_root_motion_1_1_dynamics_1_1_behaviour_fall.html");
		}

		protected override void OnActivate()
		{
			base.forceActive = true;
			StopAllCoroutines();
			StartCoroutine(SmoothActivate());
		}

		protected override void OnDeactivate()
		{
			base.forceActive = false;
		}

		public override void OnReactivate()
		{
			timer = 0f;
			endTriggered = false;
		}

		private IEnumerator SmoothActivate()
		{
			timer = 0f;
			endTriggered = false;
			puppetMaster.targetAnimator.CrossFadeInFixedTime(stateName, transitionDuration, layer, fixedTime);
			Muscle[] muscles = puppetMaster.muscles;
			foreach (Muscle muscle in muscles)
			{
				muscle.state.pinWeightMlp = 0f;
				muscle.rigidbody.velocity = muscle.mappedVelocity;
				muscle.rigidbody.angularVelocity = muscle.mappedAngularVelocity;
			}
			float fader = 0f;
			while (fader < 1f)
			{
				fader += Time.deltaTime;
				muscles = puppetMaster.muscles;
				foreach (Muscle obj in muscles)
				{
					obj.state.pinWeightMlp -= Time.deltaTime;
					obj.state.mappingWeightMlp += Time.deltaTime * blendMappingSpeed;
				}
				yield return null;
			}
		}

		protected override void OnFixedUpdate()
		{
			if ((int)raycastLayers == -1)
			{
				UnityEngine.Debug.LogWarning("BehaviourFall has no layers to raycast to.", base.transform);
			}
			float blendTarget = GetBlendTarget(GetGroundHeight());
			float value = Mathf.MoveTowards(puppetMaster.targetAnimator.GetFloat(blendParameter), blendTarget, Time.deltaTime * blendSpeed);
			puppetMaster.targetAnimator.SetFloat(blendParameter, value);
			timer += Time.deltaTime;
			if (!endTriggered && canEnd && timer >= minTime && !puppetMaster.isBlending && puppetMaster.muscles[0].rigidbody.velocity.magnitude < maxEndVelocity)
			{
				endTriggered = true;
				onEnd.Trigger(puppetMaster);
			}
		}

		protected override void OnLateUpdate()
		{
			puppetMaster.targetRoot.position += puppetMaster.muscles[0].transform.position - puppetMaster.muscles[0].target.position;
			GroundTarget(raycastLayers);
		}

		public override void Resurrect()
		{
			Muscle[] muscles = puppetMaster.muscles;
			for (int i = 0; i < muscles.Length; i++)
			{
				muscles[i].state.pinWeightMlp = 0f;
			}
		}

		private float GetBlendTarget(float groundHeight)
		{
			if (groundHeight > writheHeight)
			{
				return 1f;
			}
			Vector3 lhs = V3Tools.ExtractVertical(puppetMaster.muscles[0].rigidbody.velocity, puppetMaster.targetRoot.up, 1f);
			float num = lhs.magnitude;
			if (Vector3.Dot(lhs, puppetMaster.targetRoot.up) < 0f)
			{
				num = 0f - num;
			}
			if (num > writheYVelocity)
			{
				return 1f;
			}
			return 0f;
		}

		private float GetGroundHeight()
		{
			RaycastHit hitInfo = default(RaycastHit);
			if (Physics.Raycast(puppetMaster.muscles[0].rigidbody.position, -puppetMaster.targetRoot.up, out hitInfo, 100f, raycastLayers))
			{
				return hitInfo.distance;
			}
			return float.PositiveInfinity;
		}
	}
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page10.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourPuppet")]
	public class BehaviourPuppet : BehaviourBase
	{
		[Serializable]
		public enum State
		{
			Puppet,
			Unpinned,
			GetUp,
			Knocked
		}

		[Serializable]
		public enum NormalMode
		{
			Active,
			Unmapped,
			Kinematic
		}

		[Serializable]
		public class MasterProps
		{
			public NormalMode normalMode;

			public float mappingBlendSpeed = 10f;

			public bool activateOnStaticCollisions;

			public float activateOnImpulse;
		}

		[Serializable]
		public struct MuscleProps
		{
			[Tooltip("How much will collisions with muscles of this group unpin parent muscles?")]
			[Range(0f, 1f)]
			public float unpinParents;

			[Tooltip("How much will collisions with muscles of this group unpin child muscles?")]
			[Range(0f, 1f)]
			public float unpinChildren;

			[Tooltip("How much will collisions with muscles of this group unpin muscles of the same group?")]
			[Range(0f, 1f)]
			public float unpinGroup;

			[Tooltip("If 1, muscles of this group will always be mapped to the ragdoll.")]
			[Range(0f, 1f)]
			public float minMappingWeight;

			[Tooltip("If 0, muscles of this group will not be mapped to the ragdoll pose even if they are unpinned.")]
			[Range(0f, 1f)]
			public float maxMappingWeight;

			[Tooltip("If true, muscles of this group will have their colliders disabled while in puppet state (not unbalanced nor getting up).")]
			public bool disableColliders;

			[Tooltip("How fast will muscles of this group regain their pin weight (multiplier)?")]
			public float regainPinSpeed;

			[Tooltip("Smaller value means more unpinning from collisions (multiplier).")]
			public float collisionResistance;

			[Tooltip("If the distance from the muscle to it's target is larger than this value, the character will be knocked out.")]
			public float knockOutDistance;

			public PhysicMaterial puppetMaterial;

			public PhysicMaterial unpinnedMaterial;
		}

		[Serializable]
		public struct MusclePropsGroup
		{
			[HideInInspector]
			public string name;

			public Muscle.Group[] groups;

			public MuscleProps props;
		}

		[Serializable]
		public struct CollisionResistanceMultiplier
		{
			public LayerMask layers;

			[Tooltip("Multiplier for the 'Collision Resistance' for these layers.")]
			public float multiplier;

			[Tooltip("Overrides 'Collision Threshold' for these layers.")]
			public float collisionThreshold;
		}

		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);

		[LargeHeader("Collision And Recovery")]
		public MasterProps masterProps = new MasterProps();

		[Tooltip("Will ground the target to those layers when getting up.")]
		public LayerMask groundLayers;

		[Tooltip("Will unpin the muscles that collide with those layers.")]
		public LayerMask collisionLayers;

		[Tooltip("The collision impulse sqrMagnitude threshold under which collisions will be ignored.")]
		public float collisionThreshold;

		public Weight collisionResistance = new Weight(3f, "Smaller value means more unpinning from collisions so the characters get knocked out more easily. If using a curve, the value will be evaluated by each muscle's target velocity magnitude. This can be used to make collision resistance higher while the character moves or animates faster.");

		[Tooltip("Multiplies collision resistance for the specified layers.")]
		public CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		[Tooltip("An optimisation. Will only process up to this number of collisions per physics step.")]
		[Range(1f, 30f)]
		public int maxCollisions = 30;

		[Tooltip("How fast will the muscles of this group regain their pin weight?")]
		[Range(0.001f, 10f)]
		public float regainPinSpeed = 1f;

		[Tooltip("'Boosting' is a term used for making muscles temporarily immune to collisions and/or deal more damage to the muscles of other characters. That is done by increasing Muscle.State.immunity and Muscle.State.impulseMlp. For example when you set muscle.state.immunity to 1, boostFalloff will determine how fast this value will fall back to normal (0). Use BehaviourPuppet.BoostImmunity() and BehaviourPuppet.BoostImpulseMlp() for boosting from your own scripts. It is helpful for making the puppet stronger and deliever more punch while playing a melee hitting/kicking animation.")]
		public float boostFalloff = 1f;

		[LargeHeader("Muscle Group Properties")]
		public MuscleProps defaults;

		public MusclePropsGroup[] groupOverrides;

		[LargeHeader("Losing Balance")]
		[Tooltip("If the distance from the muscle to it's target is larger than this value, the character will be knocked out.")]
		[Range(0.001f, 10f)]
		public float knockOutDistance = 1f;

		[Tooltip("Smaller value makes the muscles weaker when the puppet is knocked out.")]
		[Range(0f, 1f)]
		public float unpinnedMuscleWeightMlp = 0.3f;

		[Tooltip("Most character controllers apply supernatural accelerations to characters when changing running direction or jumping. It will require major pinning forces to be applied on the ragdoll to keep up with that acceleration. When a puppet collides with something at that point and is unpinned, those forces might shoot the puppet off to space. This variable limits the velocity of the ragdoll's Rigidbodies when the puppet is unpinned.")]
		public float maxRigidbodyVelocity = 10f;

		[Tooltip("If a muscle has drifted farther than 'Knock Out Distance', will only unpin the puppet if it's pin weight is less than this value. Lowering this value will make puppets less likely to lose balance on minor collisions.")]
		[Range(0f, 1f)]
		public float pinWeightThreshold = 1f;

		[Tooltip("If false, will not unbalance the puppet by muscles that have their pin weight set to 0 in PuppetMaster muscle settings.")]
		public bool unpinnedMuscleKnockout = true;

		[Tooltip("If true, all muscles of the 'Prop' group will be detached from the puppet when it loses balance.")]
		public bool dropProps;

		[LargeHeader("Getting Up")]
		[Tooltip("If true, GetUp state will be triggerred automatically after 'Get Up Delay' and when the velocity of the hip muscle is less than 'Max Get Up Velocity'.")]
		public bool canGetUp = true;

		[Tooltip("Minimum delay for getting up after loosing balance. After that time has passed, will wait for the velocity of the hip muscle to come down below 'Max Get Up Velocity' and then switch to the GetUp state.")]
		public float getUpDelay = 5f;

		[Tooltip("The duration of blending the animation target from the ragdoll pose to the getting up animation once the GetUp state has been triggered.")]
		public float blendToAnimationTime = 0.2f;

		[Tooltip("Will not get up before the velocity of the hip muscle has come down to this value.")]
		public float maxGetUpVelocity = 0.3f;

		[Tooltip("The duration of the 'GetUp' state after which it switches to the 'Puppetä state.")]
		public float minGetUpDuration = 1f;

		[Tooltip("Collision resistance multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpCollisionResistanceMlp = 2f;

		[Tooltip("Regain pin weight speed multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpRegainPinSpeedMlp = 2f;

		[Tooltip("Knock out distance multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpKnockOutDistanceMlp = 10f;

		[Tooltip("Offset of the target character (in character rotation space) from the hip bone when initiating getting up animation from a prone pose. Tweak this value if your character slides a bit when starting to get up.")]
		public Vector3 getUpOffsetProne;

		[Tooltip("Offset of the target character (in character rotation space) from the hip bone when initiating getting up animation from a supine pose. Tweak this value if your character slides a bit when starting to get up.")]
		public Vector3 getUpOffsetSupine;

		[LargeHeader("Events")]
		public PuppetEvent onGetUpProne;

		public PuppetEvent onGetUpSupine;

		public PuppetEvent onLoseBalance;

		public PuppetEvent onLoseBalanceFromPuppet;

		public PuppetEvent onLoseBalanceFromGetUp;

		public PuppetEvent onRegainBalance;

		public CollisionImpulseDelegate OnCollisionImpulse;

		[HideInInspector]
		public bool canMoveTarget = true;

		private float unpinnedTimer;

		private float getUpTimer;

		private Vector3 hipsForward;

		private Vector3 hipsUp;

		private float getupAnimationBlendWeight;

		private float getupAnimationBlendWeightV;

		protected bool getUpTargetFixed;

		private NormalMode lastNormalMode;

		private int collisions;

		protected bool eventsEnabled;

		protected float lastKnockOutDistance;

		protected float knockOutDistanceSqr;

		private bool getupDisabled;

		protected bool hasCollidedSinceGetUp;

		private bool hasBoosted;

		private MuscleCollisionBroadcaster broadcaster;

		private Vector3 getUpPosition;

		private bool dropPropFlag;

		public State state { get; protected set; }

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://root-motion.com/puppetmasterdox/html/page10.html");
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://root-motion.com/puppetmasterdox/html/class_root_motion_1_1_dynamics_1_1_behaviour_puppet.html");
		}

		public override void OnReactivate()
		{
			state = ((puppetMaster.state != 0) ? State.Unpinned : State.Puppet);
			getUpTimer = 0f;
			unpinnedTimer = 0f;
			getupAnimationBlendWeight = 0f;
			getupAnimationBlendWeightV = 0f;
			getUpTargetFixed = false;
			getupDisabled = puppetMaster.state != PuppetMaster.State.Alive;
			state = ((puppetMaster.state != 0) ? State.Unpinned : State.Puppet);
			Muscle[] muscles = puppetMaster.muscles;
			foreach (Muscle m in muscles)
			{
				SetColliders(m, state == State.Unpinned);
			}
			base.enabled = true;
		}

		public void Reset(Vector3 position, Quaternion rotation)
		{
			UnityEngine.Debug.LogWarning("BehaviourPuppet.Reset has been deprecated, please use PuppetMaster.Teleport instead.");
		}

		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
			getUpPosition = pivot + deltaRotation * (getUpPosition - pivot) + deltaPosition;
			if (moveToTarget)
			{
				getupAnimationBlendWeight = 0f;
				getupAnimationBlendWeightV = 0f;
			}
		}

		protected override void OnInitiate()
		{
			CollisionResistanceMultiplier[] array = collisionResistanceMultipliers;
			for (int i = 0; i < array.Length; i++)
			{
				if ((int)array[i].layers == 0)
				{
					UnityEngine.Debug.LogWarning("BehaviourPuppet has a Collision Resistance Multiplier that's layers is set to Nothing. Please add some layers.", base.transform);
				}
			}
			Muscle[] muscles = puppetMaster.muscles;
			foreach (Muscle muscle in muscles)
			{
				if (muscle.joint.gameObject.layer == puppetMaster.targetRoot.gameObject.layer)
				{
					UnityEngine.Debug.LogWarning("One of the ragdoll bones is on the same layer as the animated character. This might make the ragdoll collide with the character controller.");
				}
				if (!Physics.GetIgnoreLayerCollision(muscle.joint.gameObject.layer, puppetMaster.targetRoot.gameObject.layer))
				{
					UnityEngine.Debug.LogWarning("The ragdoll layer (" + muscle.joint.gameObject.layer + ") and the character controller layer (" + puppetMaster.targetRoot.gameObject.layer + ") are not set to ignore each other in Edit/Project Settings/Physics/Layer Collision Matrix. This might cause the ragdoll bones to collide with the character controller.");
				}
			}
			hipsForward = Quaternion.Inverse(puppetMaster.muscles[0].transform.rotation) * puppetMaster.targetRoot.forward;
			hipsUp = Quaternion.Inverse(puppetMaster.muscles[0].transform.rotation) * puppetMaster.targetRoot.up;
			state = State.Unpinned;
			eventsEnabled = true;
		}

		protected override void OnActivate()
		{
			bool flag = true;
			Muscle[] muscles = puppetMaster.muscles;
			for (int i = 0; i < muscles.Length; i++)
			{
				if (muscles[i].state.pinWeightMlp > 0.5f)
				{
					flag = false;
					break;
				}
			}
			bool flag2 = eventsEnabled;
			eventsEnabled = false;
			if (flag)
			{
				SetState(State.Unpinned);
			}
			else
			{
				SetState(State.Puppet);
			}
			eventsEnabled = flag2;
		}

		public override void KillStart()
		{
			getupDisabled = true;
			Muscle[] muscles = puppetMaster.muscles;
			foreach (Muscle muscle in muscles)
			{
				muscle.state.pinWeightMlp = 0f;
				if (hasBoosted)
				{
					muscle.state.immunity = 0f;
				}
				SetColliders(muscle, unpinned: true);
			}
		}

		public override void KillEnd()
		{
			SetState(State.Unpinned);
		}

		public override void Resurrect()
		{
			getupDisabled = false;
			if (state == State.Unpinned)
			{
				getUpTimer = float.PositiveInfinity;
				unpinnedTimer = float.PositiveInfinity;
				getupAnimationBlendWeight = 0f;
				getupAnimationBlendWeightV = 0f;
				Muscle[] muscles = puppetMaster.muscles;
				for (int i = 0; i < muscles.Length; i++)
				{
					muscles[i].state.pinWeightMlp = 0f;
				}
			}
		}

		protected override void OnDeactivate()
		{
			state = State.Unpinned;
		}

		protected override void OnFixedUpdate()
		{
			collisions = 0;
			if (dropPropFlag)
			{
				RemoveMusclesOfGroup(Muscle.Group.Prop);
				dropPropFlag = false;
			}
			if (!puppetMaster.isActive)
			{
				SetState(State.Puppet);
				return;
			}
			if (!puppetMaster.isAlive)
			{
				Muscle[] muscles = puppetMaster.muscles;
				foreach (Muscle muscle in muscles)
				{
					muscle.state.pinWeightMlp = 0f;
					muscle.state.mappingWeightMlp = Mathf.MoveTowards(muscle.state.mappingWeightMlp, 1f, Time.deltaTime * 5f);
				}
				return;
			}
			if (hasBoosted)
			{
				Muscle[] muscles = puppetMaster.muscles;
				foreach (Muscle muscle2 in muscles)
				{
					muscle2.state.immunity = Mathf.MoveTowards(muscle2.state.immunity, 0f, Time.deltaTime * boostFalloff);
					muscle2.state.impulseMlp = Mathf.Lerp(muscle2.state.impulseMlp, 1f, Time.deltaTime * boostFalloff);
				}
			}
			if (state == State.Unpinned)
			{
				unpinnedTimer += Time.deltaTime;
				if (unpinnedTimer >= getUpDelay && canGetUp && !getupDisabled && puppetMaster.muscles[0].rigidbody.velocity.magnitude < maxGetUpVelocity)
				{
					SetState(State.GetUp);
					return;
				}
				Muscle[] muscles = puppetMaster.muscles;
				foreach (Muscle muscle3 in muscles)
				{
					muscle3.state.pinWeightMlp = 0f;
					muscle3.state.mappingWeightMlp = Mathf.MoveTowards(muscle3.state.mappingWeightMlp, 1f, Time.deltaTime * masterProps.mappingBlendSpeed);
				}
			}
			if (state != State.Unpinned)
			{
				if (knockOutDistance != lastKnockOutDistance)
				{
					knockOutDistanceSqr = Mathf.Sqrt(knockOutDistance);
					lastKnockOutDistance = knockOutDistance;
				}
				Muscle[] muscles = puppetMaster.muscles;
				foreach (Muscle muscle4 in muscles)
				{
					MuscleProps props = GetProps(muscle4.props.group);
					float num = 1f;
					if (state == State.GetUp)
					{
						num = Mathf.Lerp(getUpKnockOutDistanceMlp, num, muscle4.state.pinWeightMlp);
					}
					float num2 = (unpinnedMuscleKnockout ? muscle4.positionOffset.sqrMagnitude : (muscle4.positionOffset.sqrMagnitude * muscle4.props.pinWeight));
					if (hasCollidedSinceGetUp && !puppetMaster.isBlending && num2 > 0f && muscle4.state.pinWeightMlp < pinWeightThreshold && num2 > props.knockOutDistance * knockOutDistanceSqr * num)
					{
						if (state != State.GetUp || getUpTargetFixed)
						{
							SetState(State.Unpinned);
						}
						return;
					}
					muscle4.state.muscleWeightMlp = Mathf.Lerp(unpinnedMuscleWeightMlp, 1f, muscle4.state.pinWeightMlp);
					if (state == State.GetUp)
					{
						muscle4.state.muscleDamperAdd = 0f;
					}
					if (!puppetMaster.isKilling)
					{
						float num3 = 1f;
						if (state == State.GetUp)
						{
							num3 = Mathf.Lerp(getUpRegainPinSpeedMlp, 1f, muscle4.state.pinWeightMlp);
						}
						muscle4.state.pinWeightMlp += Time.deltaTime * props.regainPinSpeed * regainPinSpeed * num3;
					}
				}
				float num4 = 1f;
				muscles = puppetMaster.muscles;
				foreach (Muscle muscle5 in muscles)
				{
					if ((muscle5.props.group == Muscle.Group.Leg || muscle5.props.group == Muscle.Group.Foot) && muscle5.state.pinWeightMlp < num4)
					{
						num4 = muscle5.state.pinWeightMlp;
					}
				}
				muscles = puppetMaster.muscles;
				foreach (Muscle muscle6 in muscles)
				{
					muscle6.state.pinWeightMlp = Mathf.Clamp(muscle6.state.pinWeightMlp, 0f, num4 * 5f);
				}
			}
			if (state == State.GetUp)
			{
				getUpTimer += Time.deltaTime;
				if (getUpTimer > minGetUpDuration)
				{
					getUpTimer = 0f;
					SetState(State.Puppet);
				}
			}
		}

		protected override void OnLateUpdate()
		{
			base.forceActive = state != State.Puppet;
			if (!puppetMaster.isAlive)
			{
				return;
			}
			if (masterProps.normalMode != lastNormalMode)
			{
				if (lastNormalMode == NormalMode.Unmapped)
				{
					Muscle[] muscles = puppetMaster.muscles;
					for (int i = 0; i < muscles.Length; i++)
					{
						muscles[i].state.mappingWeightMlp = 1f;
					}
				}
				if (lastNormalMode == NormalMode.Kinematic && puppetMaster.mode == PuppetMaster.Mode.Kinematic)
				{
					puppetMaster.mode = PuppetMaster.Mode.Active;
				}
				lastNormalMode = masterProps.normalMode;
			}
			switch (masterProps.normalMode)
			{
			case NormalMode.Unmapped:
				if (puppetMaster.isActive)
				{
					bool to = false;
					for (int j = 0; j < puppetMaster.muscles.Length; j++)
					{
						BlendMuscleMapping(j, ref to);
					}
				}
				break;
			case NormalMode.Kinematic:
				if (SetKinematic())
				{
					puppetMaster.mode = PuppetMaster.Mode.Kinematic;
				}
				break;
			}
		}

		private bool SetKinematic()
		{
			if (!puppetMaster.isActive)
			{
				return false;
			}
			if (state != 0)
			{
				return false;
			}
			if (puppetMaster.isBlending)
			{
				return false;
			}
			if (getupAnimationBlendWeight > 0f)
			{
				return false;
			}
			if (!puppetMaster.isAlive)
			{
				return false;
			}
			Muscle[] muscles = puppetMaster.muscles;
			for (int i = 0; i < muscles.Length; i++)
			{
				if (muscles[i].state.pinWeightMlp < 1f)
				{
					return false;
				}
			}
			return true;
		}

		protected override void OnReadBehaviour()
		{
			if (!base.enabled)
			{
				return;
			}
			if (!puppetMaster.isFrozen && state == State.Unpinned && puppetMaster.isActive)
			{
				MoveTarget(puppetMaster.muscles[0].rigidbody.position);
				GroundTarget(groundLayers);
				getUpPosition = puppetMaster.targetRoot.position;
			}
			if (getupAnimationBlendWeight > 0f)
			{
				Vector3 vector = Vector3.Project(puppetMaster.targetRoot.position - getUpPosition, puppetMaster.targetRoot.up);
				getUpPosition += vector;
				MoveTarget(getUpPosition);
				getupAnimationBlendWeight = Mathf.SmoothDamp(getupAnimationBlendWeight, 0f, ref getupAnimationBlendWeightV, blendToAnimationTime);
				if (getupAnimationBlendWeight < 0.01f)
				{
					getupAnimationBlendWeight = 0f;
				}
				puppetMaster.FixTargetToSampledState(getupAnimationBlendWeight);
			}
			getUpTargetFixed = true;
		}

		private void BlendMuscleMapping(int muscleIndex, ref bool to)
		{
			if (puppetMaster.muscles[muscleIndex].state.pinWeightMlp < 1f)
			{
				to = true;
			}
			MuscleProps props = GetProps(puppetMaster.muscles[muscleIndex].props.group);
			float target = ((!to) ? props.minMappingWeight : ((state == State.Puppet) ? props.maxMappingWeight : 1f));
			puppetMaster.muscles[muscleIndex].state.mappingWeightMlp = Mathf.MoveTowards(puppetMaster.muscles[muscleIndex].state.mappingWeightMlp, target, Time.deltaTime * masterProps.mappingBlendSpeed);
		}

		public override void OnMuscleAdded(Muscle m)
		{
			base.OnMuscleAdded(m);
			SetColliders(m, state == State.Unpinned);
		}

		public override void OnMuscleRemoved(Muscle m)
		{
			base.OnMuscleRemoved(m);
			SetColliders(m, unpinned: true);
		}

		protected void MoveTarget(Vector3 position)
		{
			if (canMoveTarget)
			{
				puppetMaster.targetRoot.position = position;
			}
		}

		protected void RotateTarget(Quaternion rotation)
		{
			if (canMoveTarget)
			{
				puppetMaster.targetRoot.rotation = rotation;
			}
		}

		protected override void GroundTarget(LayerMask layers)
		{
			if (canMoveTarget)
			{
				base.GroundTarget(layers);
			}
		}

		private void OnDrawGizmosSelected()
		{
			for (int i = 0; i < groupOverrides.Length; i++)
			{
				groupOverrides[i].name = string.Empty;
				if (groupOverrides[i].groups.Length == 0)
				{
					continue;
				}
				for (int j = 0; j < groupOverrides[i].groups.Length; j++)
				{
					if (j > 0)
					{
						groupOverrides[i].name += ", ";
					}
					groupOverrides[i].name += groupOverrides[i].groups[j];
				}
			}
		}

		public void Boost(float immunity, float impulseMlp)
		{
			hasBoosted = true;
			for (int i = 0; i < puppetMaster.muscles.Length; i++)
			{
				Boost(i, immunity, impulseMlp);
			}
		}

		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
			hasBoosted = true;
			BoostImmunity(muscleIndex, immunity);
			BoostImpulseMlp(muscleIndex, impulseMlp);
		}

		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
			hasBoosted = true;
			if (boostParents <= 0f && boostChildren <= 0f)
			{
				Boost(muscleIndex, immunity, impulseMlp);
				return;
			}
			for (int i = 0; i < puppetMaster.muscles.Length; i++)
			{
				float falloff = GetFalloff(i, muscleIndex, boostParents, boostChildren);
				Boost(i, immunity * falloff, impulseMlp * falloff);
			}
		}

		public void BoostImmunity(float immunity)
		{
			hasBoosted = true;
			if (!(immunity < 0f))
			{
				for (int i = 0; i < puppetMaster.muscles.Length; i++)
				{
					BoostImmunity(i, immunity);
				}
			}
		}

		public void BoostImmunity(int muscleIndex, float immunity)
		{
			hasBoosted = true;
			puppetMaster.muscles[muscleIndex].state.immunity = Mathf.Clamp(immunity, puppetMaster.muscles[muscleIndex].state.immunity, 1f);
		}

		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
			hasBoosted = true;
			for (int i = 0; i < puppetMaster.muscles.Length; i++)
			{
				float falloff = GetFalloff(i, muscleIndex, boostParents, boostChildren);
				BoostImmunity(i, immunity * falloff);
			}
		}

		public void BoostImpulseMlp(float impulseMlp)
		{
			hasBoosted = true;
			for (int i = 0; i < puppetMaster.muscles.Length; i++)
			{
				BoostImpulseMlp(i, impulseMlp);
			}
		}

		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
			hasBoosted = true;
			puppetMaster.muscles[muscleIndex].state.impulseMlp = Mathf.Max(impulseMlp, puppetMaster.muscles[muscleIndex].state.impulseMlp);
		}

		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
			hasBoosted = true;
			for (int i = 0; i < puppetMaster.muscles.Length; i++)
			{
				float falloff = GetFalloff(i, muscleIndex, boostParents, boostChildren);
				BoostImpulseMlp(i, impulseMlp * falloff);
			}
		}

		public void Unpin()
		{
			UnityEngine.Debug.Log("BehaviourPuppet.Unpin() has been deprecated. Use SetState(BehaviourPuppet.State) instead.");
			SetState(State.Unpinned);
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
			if (masterProps.normalMode == NormalMode.Kinematic)
			{
				puppetMaster.mode = PuppetMaster.Mode.Active;
			}
			UnPin(hit.muscleIndex, hit.unPin);
			puppetMaster.muscles[hit.muscleIndex].rigidbody.isKinematic = false;
			puppetMaster.muscles[hit.muscleIndex].rigidbody.AddForceAtPosition(hit.force, hit.position);
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
			if (!base.enabled || state == State.Unpinned || collisions > maxCollisions || !LayerMaskExtensions.Contains(collisionLayers, m.collision.gameObject.layer) || (masterProps.normalMode == NormalMode.Kinematic && !puppetMaster.isActive && !masterProps.activateOnStaticCollisions && m.collision.gameObject.isStatic))
			{
				return;
			}
			float layerThreshold = collisionThreshold;
			float num = GetImpulse(m, ref layerThreshold);
			if (OnCollisionImpulse != null)
			{
				OnCollisionImpulse(m, num);
			}
			float num2 = ((Singleton<PuppetMasterSettings>.instance != null) ? (1f + (float)Singleton<PuppetMasterSettings>.instance.currentlyActivePuppets * Singleton<PuppetMasterSettings>.instance.activePuppetCollisionThresholdMlp) : 1f);
			float num3 = layerThreshold * num2;
			if (num <= num3)
			{
				return;
			}
			collisions++;
			if (m.collision.collider.attachedRigidbody != null)
			{
				broadcaster = m.collision.collider.attachedRigidbody.GetComponent<MuscleCollisionBroadcaster>();
				if (broadcaster != null && broadcaster.muscleIndex < broadcaster.puppetMaster.muscles.Length)
				{
					num *= broadcaster.puppetMaster.muscles[broadcaster.muscleIndex].state.impulseMlp;
				}
			}
			if (Activate(m.collision, num))
			{
				puppetMaster.mode = PuppetMaster.Mode.Active;
			}
			UnPin(m.muscleIndex, num);
		}

		private float GetImpulse(MuscleCollision m, ref float layerThreshold)
		{
			float sqrMagnitude = m.collision.impulse.sqrMagnitude;
			sqrMagnitude /= puppetMaster.muscles[m.muscleIndex].rigidbody.mass;
			sqrMagnitude *= 0.3f;
			CollisionResistanceMultiplier[] array = collisionResistanceMultipliers;
			for (int i = 0; i < array.Length; i++)
			{
				CollisionResistanceMultiplier collisionResistanceMultiplier = array[i];
				if (LayerMaskExtensions.Contains(collisionResistanceMultiplier.layers, m.collision.collider.gameObject.layer))
				{
					sqrMagnitude = ((!(collisionResistanceMultiplier.multiplier <= 0f)) ? (sqrMagnitude / collisionResistanceMultiplier.multiplier) : float.PositiveInfinity);
					layerThreshold = collisionResistanceMultiplier.collisionThreshold;
					break;
				}
			}
			return sqrMagnitude;
		}

		private void UnPin(int muscleIndex, float unpin)
		{
			if (muscleIndex < puppetMaster.muscles.Length)
			{
				MuscleProps props = GetProps(puppetMaster.muscles[muscleIndex].props.group);
				for (int i = 0; i < puppetMaster.muscles.Length; i++)
				{
					UnPinMuscle(i, unpin * GetFalloff(i, muscleIndex, props.unpinParents, props.unpinChildren, props.unpinGroup));
				}
				hasCollidedSinceGetUp = true;
			}
		}

		private void UnPinMuscle(int muscleIndex, float unpin)
		{
			if (!(unpin <= 0f) && !(puppetMaster.muscles[muscleIndex].state.immunity >= 1f))
			{
				MuscleProps props = GetProps(puppetMaster.muscles[muscleIndex].props.group);
				float num = 1f;
				if (state == State.GetUp)
				{
					num = Mathf.Lerp(getUpCollisionResistanceMlp, 1f, puppetMaster.muscles[muscleIndex].state.pinWeightMlp);
				}
				float num2 = ((collisionResistance.mode == Weight.Mode.Float) ? collisionResistance.floatValue : collisionResistance.GetValue(puppetMaster.muscles[muscleIndex].targetVelocity.magnitude));
				float num3 = unpin / (props.collisionResistance * num2 * num);
				num3 *= 1f - puppetMaster.muscles[muscleIndex].state.immunity;
				puppetMaster.muscles[muscleIndex].state.pinWeightMlp -= num3;
			}
		}

		private bool Activate(Collision collision, float impulse)
		{
			if (masterProps.normalMode != NormalMode.Kinematic)
			{
				return false;
			}
			if (puppetMaster.mode != PuppetMaster.Mode.Kinematic)
			{
				return false;
			}
			if (impulse < masterProps.activateOnImpulse)
			{
				return false;
			}
			if (collision.gameObject.isStatic)
			{
				return masterProps.activateOnStaticCollisions;
			}
			return true;
		}

		public bool IsProne()
		{
			return Vector3.Dot(puppetMaster.muscles[0].transform.rotation * hipsForward, puppetMaster.targetRoot.up) < 0f;
		}

		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			if (i == muscleIndex)
			{
				return 1f;
			}
			bool num = puppetMaster.muscles[muscleIndex].childFlags[i];
			return Mathf.Pow(p: puppetMaster.muscles[muscleIndex].kinshipDegrees[i], f: num ? falloffChildren : falloffParents);
		}

		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			float num = GetFalloff(i, muscleIndex, falloffParents, falloffChildren);
			if (falloffGroup > 0f && i != muscleIndex && InGroup(puppetMaster.muscles[i].props.group, puppetMaster.muscles[muscleIndex].props.group))
			{
				num = Mathf.Max(num, falloffGroup);
			}
			return num;
		}

		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			if (group1 == group2)
			{
				return true;
			}
			MusclePropsGroup[] array = groupOverrides;
			for (int i = 0; i < array.Length; i++)
			{
				MusclePropsGroup musclePropsGroup = array[i];
				Muscle.Group[] groups = musclePropsGroup.groups;
				for (int j = 0; j < groups.Length; j++)
				{
					if (groups[j] != group1)
					{
						continue;
					}
					Muscle.Group[] groups2 = musclePropsGroup.groups;
					for (int k = 0; k < groups2.Length; k++)
					{
						if (groups2[k] == group2)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		protected MuscleProps GetProps(Muscle.Group group)
		{
			MusclePropsGroup[] array = groupOverrides;
			for (int i = 0; i < array.Length; i++)
			{
				MusclePropsGroup musclePropsGroup = array[i];
				Muscle.Group[] groups = musclePropsGroup.groups;
				for (int j = 0; j < groups.Length; j++)
				{
					if (groups[j] == group)
					{
						return musclePropsGroup.props;
					}
				}
			}
			return defaults;
		}

		public virtual void SetState(State newState)
		{
			if (state == newState)
			{
				return;
			}
			switch (newState)
			{
			case State.Puppet:
				puppetMaster.SampleTargetMappedState();
				unpinnedTimer = 0f;
				getUpTimer = 0f;
				if (state == State.Unpinned)
				{
					Muscle[] muscles = puppetMaster.muscles;
					foreach (Muscle muscle3 in muscles)
					{
						muscle3.state.pinWeightMlp = 1f;
						muscle3.state.muscleWeightMlp = 1f;
						muscle3.state.muscleDamperAdd = 0f;
						SetColliders(muscle3, unpinned: false);
					}
				}
				state = State.Puppet;
				if (eventsEnabled)
				{
					onRegainBalance.Trigger(puppetMaster);
					if (onRegainBalance.switchBehaviour)
					{
						return;
					}
				}
				break;
			case State.Unpinned:
			{
				unpinnedTimer = 0f;
				getUpTimer = 0f;
				getupAnimationBlendWeight = 0f;
				getupAnimationBlendWeightV = 0f;
				Muscle[] muscles = puppetMaster.muscles;
				foreach (Muscle muscle2 in muscles)
				{
					if (hasBoosted)
					{
						muscle2.state.immunity = 0f;
					}
					if (maxRigidbodyVelocity != float.PositiveInfinity)
					{
						muscle2.rigidbody.velocity = Vector3.ClampMagnitude(muscle2.rigidbody.velocity, maxRigidbodyVelocity);
					}
					SetColliders(muscle2, unpinned: true);
				}
				if (dropProps)
				{
					dropPropFlag = true;
				}
				muscles = puppetMaster.muscles;
				for (int i = 0; i < muscles.Length; i++)
				{
					muscles[i].state.muscleWeightMlp = (puppetMaster.isAlive ? unpinnedMuscleWeightMlp : puppetMaster.stateSettings.deadMuscleWeight);
				}
				onLoseBalance.Trigger(puppetMaster, puppetMaster.isAlive);
				if (onLoseBalance.switchBehaviour)
				{
					state = State.Unpinned;
					return;
				}
				if (state == State.Puppet)
				{
					onLoseBalanceFromPuppet.Trigger(puppetMaster, puppetMaster.isAlive);
					if (onLoseBalanceFromPuppet.switchBehaviour)
					{
						state = State.Unpinned;
						return;
					}
				}
				else
				{
					onLoseBalanceFromGetUp.Trigger(puppetMaster, puppetMaster.isAlive);
					if (onLoseBalanceFromGetUp.switchBehaviour)
					{
						state = State.Unpinned;
						return;
					}
				}
				muscles = puppetMaster.muscles;
				for (int i = 0; i < muscles.Length; i++)
				{
					muscles[i].state.pinWeightMlp = 0f;
				}
				break;
			}
			case State.GetUp:
			{
				unpinnedTimer = 0f;
				getUpTimer = 0f;
				hasCollidedSinceGetUp = false;
				bool flag = IsProne();
				state = State.GetUp;
				if (flag)
				{
					onGetUpProne.Trigger(puppetMaster);
					if (onGetUpProne.switchBehaviour)
					{
						return;
					}
				}
				else
				{
					onGetUpSupine.Trigger(puppetMaster);
					if (onGetUpSupine.switchBehaviour)
					{
						return;
					}
				}
				Muscle[] muscles = puppetMaster.muscles;
				foreach (Muscle muscle in muscles)
				{
					muscle.state.muscleWeightMlp = 0f;
					muscle.state.pinWeightMlp = 0f;
					muscle.state.muscleDamperAdd = 0f;
					SetColliders(muscle, unpinned: false);
				}
				Vector3 tangent = puppetMaster.muscles[0].rigidbody.rotation * hipsUp;
				Vector3 normal = puppetMaster.targetRoot.up;
				Vector3.OrthoNormalize(ref normal, ref tangent);
				RotateTarget(Quaternion.LookRotation(flag ? tangent : (-tangent), puppetMaster.targetRoot.up));
				puppetMaster.SampleTargetMappedState();
				Vector3 vector = (flag ? getUpOffsetProne : getUpOffsetSupine);
				MoveTarget(puppetMaster.muscles[0].rigidbody.position + puppetMaster.targetRoot.rotation * vector);
				GroundTarget(groundLayers);
				getUpPosition = puppetMaster.targetRoot.position;
				getupAnimationBlendWeight = 1f;
				getUpTargetFixed = false;
				break;
			}
			}
			state = newState;
		}

		public void SetColliders(bool unpinned)
		{
			Muscle[] muscles = puppetMaster.muscles;
			foreach (Muscle m in muscles)
			{
				SetColliders(m, unpinned);
			}
		}

		private void SetColliders(Muscle m, bool unpinned)
		{
			MuscleProps props = GetProps(m.props.group);
			Collider[] colliders;
			if (unpinned)
			{
				colliders = m.colliders;
				foreach (Collider collider in colliders)
				{
					collider.material = ((props.unpinnedMaterial != null) ? props.unpinnedMaterial : defaults.unpinnedMaterial);
					if (props.disableColliders)
					{
						collider.enabled = true;
					}
				}
				return;
			}
			colliders = m.colliders;
			foreach (Collider collider2 in colliders)
			{
				collider2.material = ((props.puppetMaterial != null) ? props.puppetMaterial : defaults.puppetMaterial);
				if (props.disableColliders)
				{
					collider2.enabled = false;
				}
			}
		}
	}
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourTemplate")]
	public class BehaviourTemplate : BehaviourBase
	{
		public SubBehaviourCOM centerOfMass;

		public LayerMask groundLayers;

		public PuppetEvent onLoseBalance;

		public float loseBalanceAngle = 60f;

		protected override void OnInitiate()
		{
			centerOfMass.Initiate(this, groundLayers);
		}

		protected override void OnActivate()
		{
		}

		public override void OnReactivate()
		{
		}

		protected override void OnDeactivate()
		{
		}

		protected override void OnFixedUpdate()
		{
			if (centerOfMass.angle > loseBalanceAngle)
			{
				onLoseBalance.Trigger(puppetMaster);
			}
		}

		protected override void OnLateUpdate()
		{
		}

		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
			_ = base.enabled;
		}

		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
			_ = base.enabled;
		}
	}
	[Serializable]
	public class SubBehaviourBalancer : SubBehaviourBase
	{
		[Serializable]
		public class Settings
		{
			[Tooltip("Ankle joint damper / spring. Increase to make the balancing effect softer.")]
			public float damperForSpring = 1f;

			[Tooltip("Multiplier for joint max force.")]
			public float maxForceMlp = 0.05f;

			[Tooltip("Multiplier for the inertia tensor. Increasing this will increase the balancing forces.")]
			public float IMlp = 1f;

			[Tooltip("Velocity-based prediction.")]
			public float velocityF = 0.5f;

			[Tooltip("World space offset for the center of pressure. Can be used to make the characer lean in a certain direction.")]
			public Vector3 copOffset;

			[Tooltip("The amount of torque applied to the lower legs to help keep the puppet balanced. Note that this is an external force (not coming from the joints themselves) and might make the simulation seem unnatural.")]
			public float torqueMlp;

			[Tooltip("Maximum magnitude of the torque applied to the lower legs if 'Torque Mlp' > 0.")]
			public float maxTorqueMag = 45f;
		}

		private Settings settings;

		private Rigidbody[] rigidbodies = new Rigidbody[0];

		private Transform[] copPoints = new Transform[0];

		private PressureSensor pressureSensor;

		private Rigidbody Ibody;

		private Vector3 I;

		private Quaternion toJointSpace = Quaternion.identity;

		public ConfigurableJoint joint { get; private set; }

		public Vector3 dir { get; private set; }

		public Vector3 dirVel { get; private set; }

		public Vector3 cop { get; private set; }

		public Vector3 com { get; private set; }

		public Vector3 comV { get; private set; }

		public void Initiate(BehaviourBase behaviour, Settings settings, Rigidbody Ibody, Rigidbody[] rigidbodies, ConfigurableJoint joint, Transform[] copPoints, PressureSensor pressureSensor)
		{
			base.behaviour = behaviour;
			this.settings = settings;
			this.Ibody = Ibody;
			this.rigidbodies = rigidbodies;
			this.joint = joint;
			this.copPoints = copPoints;
			this.pressureSensor = pressureSensor;
			toJointSpace = PhysXTools.ToJointSpace(joint);
			behaviour.OnPreFixedUpdate = (BehaviourBase.BehaviourDelegate)Delegate.Combine(behaviour.OnPreFixedUpdate, new BehaviourBase.BehaviourDelegate(Solve));
		}

		private void Solve()
		{
			if (copPoints.Length == 0)
			{
				cop = joint.transform.TransformPoint(joint.anchor);
			}
			else
			{
				cop = Vector3.zero;
				Transform[] array = copPoints;
				foreach (Transform transform in array)
				{
					cop += transform.position;
				}
				cop /= (float)copPoints.Length;
			}
			cop += settings.copOffset;
			com = PhysXTools.GetCenterOfMass(rigidbodies);
			comV = PhysXTools.GetCenterOfMassVelocity(rigidbodies);
			dir = com - cop;
			dirVel = com + comV * settings.velocityF - cop;
			Vector3 v = (PhysXTools.GetFromToAcceleration(dirVel, -Physics.gravity) - Ibody.angularVelocity) / Time.fixedDeltaTime;
			PhysXTools.ScaleByInertia(ref v, Ibody.rotation, Ibody.inertiaTensor * settings.IMlp);
			v = Vector3.ClampMagnitude(v, settings.maxTorqueMag);
			if (pressureSensor == null || !pressureSensor.enabled || pressureSensor.inContact)
			{
				Ibody.AddTorque(v * settings.torqueMlp, ForceMode.Force);
				joint.targetAngularVelocity = Quaternion.Inverse(toJointSpace) * Quaternion.Inverse(joint.transform.rotation) * v;
			}
			else
			{
				joint.targetAngularVelocity = Vector3.zero;
			}
		}
	}
	[Serializable]
	public abstract class SubBehaviourBase
	{
		protected BehaviourBase behaviour;

		protected static Vector2 XZ(Vector3 v)
		{
			return new Vector2(v.x, v.z);
		}

		protected static Vector3 XYZ(Vector2 v)
		{
			return new Vector3(v.x, 0f, v.y);
		}

		protected static Vector3 Flatten(Vector3 v)
		{
			return new Vector3(v.x, 0f, v.z);
		}

		protected static Vector3 SetY(Vector3 v, float y)
		{
			return new Vector3(v.x, y, v.z);
		}
	}
	[Serializable]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		public enum Mode
		{
			FeetCentroid,
			CenterOfPressure
		}

		public Mode mode;

		public float velocityDamper = 1f;

		public float velocityLerpSpeed = 5f;

		public float velocityMax = 1f;

		public float centerOfPressureSpeed = 5f;

		public Vector3 offset;

		[HideInInspector]
		public bool[] groundContacts;

		[HideInInspector]
		public Vector3[] groundContactPoints;

		private LayerMask groundLayers;

		public Vector3 position { get; private set; }

		public Vector3 direction { get; private set; }

		public float angle { get; private set; }

		public Vector3 velocity { get; private set; }

		public Vector3 centerOfPressure { get; private set; }

		public Quaternion rotation { get; private set; }

		public Quaternion inverseRotation { get; private set; }

		public bool isGrounded { get; private set; }

		public float lastGroundedTime { get; private set; }

		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
			base.behaviour = behaviour;
			this.groundLayers = groundLayers;
			rotation = Quaternion.identity;
			groundContacts = new bool[behaviour.puppetMaster.muscles.Length];
			groundContactPoints = new Vector3[groundContacts.Length];
			behaviour.OnPreActivate = (BehaviourBase.BehaviourDelegate)Delegate.Combine(behaviour.OnPreActivate, new BehaviourBase.BehaviourDelegate(OnPreActivate));
			behaviour.OnPreLateUpdate = (BehaviourBase.BehaviourDelegate)Delegate.Combine(behaviour.OnPreLateUpdate, new BehaviourBase.BehaviourDelegate(OnPreLateUpdate));
			behaviour.OnPreDeactivate = (BehaviourBase.BehaviourDelegate)Delegate.Combine(behaviour.OnPreDeactivate, new BehaviourBase.BehaviourDelegate(OnPreDeactivate));
			behaviour.OnPreMuscleCollision = (BehaviourBase.CollisionDelegate)Delegate.Combine(behaviour.OnPreMuscleCollision, new BehaviourBase.CollisionDelegate(OnPreMuscleCollision));
			behaviour.OnPreMuscleCollisionExit = (BehaviourBase.CollisionDelegate)Delegate.Combine(behaviour.OnPreMuscleCollisionExit, new BehaviourBase.CollisionDelegate(OnPreMuscleCollisionExit));
			behaviour.OnHierarchyChanged = (BehaviourBase.BehaviourDelegate)Delegate.Combine(behaviour.OnHierarchyChanged, new BehaviourBase.BehaviourDelegate(OnHierarchyChanged));
		}

		private void OnHierarchyChanged()
		{
			Array.Resize(ref groundContacts, behaviour.puppetMaster.muscles.Length);
			Array.Resize(ref groundContactPoints, behaviour.puppetMaster.muscles.Length);
		}

		private void OnPreMuscleCollision(MuscleCollision c)
		{
			if (LayerMaskExtensions.Contains(groundLayers, c.collision.gameObject.layer) && c.collision.contacts.Length != 0)
			{
				lastGroundedTime = Time.time;
				groundContacts[c.muscleIndex] = true;
				if (mode == Mode.CenterOfPressure)
				{
					groundContactPoints[c.muscleIndex] = GetCollisionCOP(c.collision);
				}
			}
		}

		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
			if (LayerMaskExtensions.Contains(groundLayers, c.collision.gameObject.layer))
			{
				groundContacts[c.muscleIndex] = false;
				groundContactPoints[c.muscleIndex] = Vector3.zero;
			}
		}

		private void OnPreActivate()
		{
			position = GetCenterOfMass();
			centerOfPressure = GetFeetCentroid();
			direction = position - centerOfPressure;
			angle = Vector3.Angle(direction, Vector3.up);
			velocity = Vector3.zero;
		}

		private void OnPreLateUpdate()
		{
			isGrounded = IsGrounded();
			if (mode == Mode.FeetCentroid || !isGrounded)
			{
				centerOfPressure = GetFeetCentroid();
			}
			else
			{
				Vector3 vector = (isGrounded ? GetCenterOfPressure() : GetFeetCentroid());
				centerOfPressure = ((centerOfPressureSpeed <= 2f) ? vector : Vector3.Lerp(centerOfPressure, vector, Time.deltaTime * centerOfPressureSpeed));
			}
			position = GetCenterOfMass();
			Vector3 vector2 = GetCenterOfMassVelocity() - position;
			vector2.y = 0f;
			vector2 = Vector3.ClampMagnitude(vector2, velocityMax);
			velocity = ((velocityLerpSpeed <= 0f) ? vector2 : Vector3.Lerp(velocity, vector2, Time.deltaTime * velocityLerpSpeed));
			position += velocity * velocityDamper;
			position += behaviour.puppetMaster.targetRoot.rotation * offset;
			direction = position - centerOfPressure;
			rotation = Quaternion.FromToRotation(Vector3.up, direction);
			inverseRotation = Quaternion.Inverse(rotation);
			angle = Quaternion.Angle(Quaternion.identity, rotation);
		}

		private void OnPreDeactivate()
		{
			velocity = Vector3.zero;
		}

		private Vector3 GetCollisionCOP(Collision collision)
		{
			Vector3 zero = Vector3.zero;
			for (int i = 0; i < collision.contacts.Length; i++)
			{
				zero += collision.contacts[i].point;
			}
			return zero / collision.contacts.Length;
		}

		private bool IsGrounded()
		{
			for (int i = 0; i < groundContacts.Length; i++)
			{
				if (groundContacts[i])
				{
					return true;
				}
			}
			return false;
		}

		private Vector3 GetCenterOfMass()
		{
			Vector3 zero = Vector3.zero;
			float num = 0f;
			Muscle[] muscles = behaviour.puppetMaster.muscles;
			foreach (Muscle muscle in muscles)
			{
				zero += muscle.rigidbody.worldCenterOfMass * muscle.rigidbody.mass;
				num += muscle.rigidbody.mass;
			}
			return zero /= num;
		}

		private Vector3 GetCenterOfMassVelocity()
		{
			Vector3 zero = Vector3.zero;
			float num = 0f;
			Muscle[] muscles = behaviour.puppetMaster.muscles;
			foreach (Muscle muscle in muscles)
			{
				zero += muscle.rigidbody.worldCenterOfMass * muscle.rigidbody.mass;
				zero += muscle.rigidbody.velocity * muscle.rigidbody.mass;
				num += muscle.rigidbody.mass;
			}
			return zero /= num;
		}

		private Vector3 GetMomentum()
		{
			Vector3 zero = Vector3.zero;
			for (int i = 0; i < behaviour.puppetMaster.muscles.Length; i++)
			{
				zero += behaviour.puppetMaster.muscles[i].rigidbody.velocity * behaviour.puppetMaster.muscles[i].rigidbody.mass;
			}
			return zero;
		}

		private Vector3 GetCenterOfPressure()
		{
			Vector3 zero = Vector3.zero;
			int num = 0;
			for (int i = 0; i < groundContacts.Length; i++)
			{
				if (groundContacts[i])
				{
					zero += groundContactPoints[i];
					num++;
				}
			}
			return zero / num;
		}

		private Vector3 GetFeetCentroid()
		{
			Vector3 zero = Vector3.zero;
			int num = 0;
			for (int i = 0; i < behaviour.puppetMaster.muscles.Length; i++)
			{
				if (behaviour.puppetMaster.muscles[i].props.group == Muscle.Group.Foot)
				{
					zero += behaviour.puppetMaster.muscles[i].rigidbody.worldCenterOfMass;
					num++;
				}
			}
			return zero / num;
		}
	}
	[Serializable]
	public class Booster
	{
		[Tooltip("If true, all the muscles will be boosted and the 'Muscles' and 'Groups' properties below will be ignored.")]
		public bool fullBody;

		[Tooltip("Muscles to boost. Used only when 'Full Body' is false.")]
		public ConfigurableJoint[] muscles = new ConfigurableJoint[0];

		[Tooltip("Muscle groups to boost. Used only when 'Full Body' is false.")]
		public Muscle.Group[] groups = new Muscle.Group[0];

		[Tooltip("Immunity to apply to the muscles. If muscle immunity is 1, it can not be damaged.")]
		[Range(0f, 1f)]
		public float immunity;

		[Tooltip("Impulse multiplier to be applied to the muscles. This makes them deal more damage to other puppets.")]
		public float impulseMlp;

		[Tooltip("Falloff for parent muscles (power of kinship degree).")]
		public float boostParents;

		[Tooltip("Falloff for child muscles (power of kinship degree).")]
		public float boostChildren;

		[Tooltip("This does nothing on it's own, you can use it in a 'yield return new WaitForseconds(delay);' call.")]
		public float delay;

		public void Boost(BehaviourPuppet puppet)
		{
			if (fullBody)
			{
				puppet.Boost(immunity, impulseMlp);
				return;
			}
			ConfigurableJoint[] array = muscles;
			foreach (ConfigurableJoint configurableJoint in array)
			{
				for (int j = 0; j < puppet.puppetMaster.muscles.Length; j++)
				{
					if (puppet.puppetMaster.muscles[j].joint == configurableJoint)
					{
						puppet.Boost(j, immunity, impulseMlp, boostParents, boostChildren);
						break;
					}
				}
			}
			Muscle.Group[] array2 = groups;
			foreach (Muscle.Group group in array2)
			{
				for (int k = 0; k < puppet.puppetMaster.muscles.Length; k++)
				{
					if (puppet.puppetMaster.muscles[k].props.group == group)
					{
						puppet.Boost(k, immunity, impulseMlp, boostParents, boostChildren);
					}
				}
			}
		}
	}
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[SerializeField]
		[HideInInspector]
		public int muscleIndex;

		private void OnJointBreak()
		{
			if (base.enabled)
			{
				puppetMaster.RemoveMuscleRecursive(puppetMaster.muscles[muscleIndex].joint, attachTarget: true, blockTargetAnimation: true, MuscleRemoveMode.Numb);
			}
		}
	}
	[Serializable]
	public class Muscle
	{
		[Serializable]
		public enum Group
		{
			Hips,
			Spine,
			Head,
			Arm,
			Hand,
			Leg,
			Foot,
			Tail,
			Prop
		}

		[Serializable]
		public class Props
		{
			[Tooltip("Which body part does this muscle belong to?")]
			public Group group;

			[Tooltip("The weight (multiplier) of mapping this muscle's target to the muscle.")]
			[Range(0f, 1f)]
			public float mappingWeight = 1f;

			[Tooltip("The weight (multiplier) of pinning this muscle to it's target's position using a simple AddForce command.")]
			[Range(0f, 1f)]
			public float pinWeight = 1f;

			[Tooltip("The muscle strength (multiplier).")]
			[Range(0f, 1f)]
			public float muscleWeight = 1f;

			[Tooltip("Multiplier of the positionDamper of the ConfigurableJoints' Slerp Drive.")]
			[Range(0f, 1f)]
			public float muscleDamper = 1f;

			[Tooltip("If true, will map the target to the world space position of the muscle. Normally this should be true for only the root muscle (the hips).")]
			public bool mapPosition;

			public Props()
			{
				mappingWeight = 1f;
				pinWeight = 1f;
				muscleWeight = 1f;
				muscleDamper = 1f;
			}

			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, bool mapPosition, Group group = Group.Hips)
			{
				this.pinWeight = pinWeight;
				this.muscleWeight = muscleWeight;
				this.mappingWeight = mappingWeight;
				this.muscleDamper = muscleDamper;
				this.group = group;
				this.mapPosition = mapPosition;
			}

			public void Clamp()
			{
				mappingWeight = Mathf.Clamp(mappingWeight, 0f, 1f);
				pinWeight = Mathf.Clamp(pinWeight, 0f, 1f);
				muscleWeight = Mathf.Clamp(muscleWeight, 0f, 1f);
				muscleDamper = Mathf.Clamp(muscleDamper, 0f, 1f);
			}
		}

		public struct State
		{
			public float mappingWeightMlp;

			public float pinWeightMlp;

			public float muscleWeightMlp;

			public float maxForceMlp;

			public float muscleDamperMlp;

			public float muscleDamperAdd;

			public float immunity;

			public float impulseMlp;

			public Vector3 velocity;

			public Vector3 angularVelocity;

			public static State Default
			{
				get
				{
					State result = default(State);
					result.mappingWeightMlp = 1f;
					result.pinWeightMlp = 1f;
					result.muscleWeightMlp = 1f;
					result.muscleDamperMlp = 1f;
					result.muscleDamperAdd = 0f;
					result.maxForceMlp = 1f;
					result.immunity = 0f;
					result.impulseMlp = 1f;
					return result;
				}
			}

			public void Clamp()
			{
				mappingWeightMlp = Mathf.Clamp(mappingWeightMlp, 0f, 1f);
				pinWeightMlp = Mathf.Clamp(pinWeightMlp, 0f, 1f);
				muscleWeightMlp = Mathf.Clamp(muscleWeightMlp, 0f, muscleWeightMlp);
				immunity = Mathf.Clamp(immunity, 0f, 1f);
				impulseMlp = Mathf.Max(impulseMlp, 0f);
			}
		}

		[HideInInspector]
		public string name;

		public ConfigurableJoint joint;

		public Transform target;

		public Props props = new Props();

		public State state = State.Default;

		[HideInInspector]
		public int[] parentIndexes = new int[0];

		[HideInInspector]
		public int[] childIndexes = new int[0];

		[HideInInspector]
		public bool[] childFlags = new bool[0];

		[HideInInspector]
		public int[] kinshipDegrees = new int[0];

		[HideInInspector]
		public MuscleCollisionBroadcaster broadcaster;

		[HideInInspector]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[HideInInspector]
		public Vector3 positionOffset;

		private JointDrive slerpDrive;

		private float lastJointDriveRotationWeight = -1f;

		private float lastRotationDamper = -1f;

		private Vector3 defaultPosition;

		private Vector3 defaultTargetLocalPosition;

		private Vector3 lastMappedPosition;

		private Quaternion defaultLocalRotation;

		private Quaternion localRotationConvert;

		private Quaternion toParentSpace;

		private Quaternion toJointSpaceInverse;

		private Quaternion toJointSpaceDefault;

		private Quaternion targetAnimatedRotation;

		private Quaternion targetAnimatedWorldRotation;

		private Quaternion defaultRotation;

		private Quaternion rotationRelativeToTarget;

		private Quaternion defaultTargetLocalRotation;

		private Quaternion lastMappedRotation;

		private Transform targetParent;

		private Transform connectedBodyTransform;

		private ConfigurableJointMotion angularXMotionDefault;

		private ConfigurableJointMotion angularYMotionDefault;

		private ConfigurableJointMotion angularZMotionDefault;

		private bool directTargetParent;

		private bool initiated;

		private Collider[] _colliders = new Collider[0];

		private float lastReadTime;

		private float lastWriteTime;

		private bool[] disabledColliders = new bool[0];

		public Transform transform { get; private set; }

		public Rigidbody rigidbody { get; private set; }

		public Transform connectedBodyTarget { get; private set; }

		public Vector3 targetAnimatedPosition { get; private set; }

		public Collider[] colliders => _colliders;

		public Vector3 targetVelocity { get; private set; }

		public Vector3 targetAngularVelocity { get; private set; }

		public Vector3 mappedVelocity { get; private set; }

		public Vector3 mappedAngularVelocity { get; private set; }

		public Quaternion targetRotationRelative { get; private set; }

		private Quaternion localRotation => Quaternion.Inverse(parentRotation) * transform.rotation;

		private Quaternion parentRotation
		{
			get
			{
				if (joint.connectedBody != null)
				{
					return joint.connectedBody.rotation;
				}
				if (transform.parent == null)
				{
					return Quaternion.identity;
				}
				return transform.parent.rotation;
			}
		}

		private Quaternion targetParentRotation
		{
			get
			{
				if (targetParent == null)
				{
					return Quaternion.identity;
				}
				return targetParent.rotation;
			}
		}

		private Quaternion targetLocalRotation => Quaternion.Inverse(targetParentRotation * toParentSpace) * target.rotation;

		public bool IsValid(bool log)
		{
			if (joint == null)
			{
				if (log)
				{
					UnityEngine.Debug.LogError("Muscle joint is null");
				}
				return false;
			}
			if (target == null)
			{
				if (log)
				{
					UnityEngine.Debug.LogError("Muscle " + joint.name + "target is null, please remove the muscle from PuppetMaster or disable PuppetMaster before destroying a muscle's target.");
				}
				return false;
			}
			if (props == null && log)
			{
				UnityEngine.Debug.LogError("Muscle " + joint.name + "props is null");
			}
			return true;
		}

		public virtual void Initiate(Muscle[] colleagues)
		{
			initiated = false;
			if (!IsValid(log: true))
			{
				return;
			}
			name = joint.name;
			state = State.Default;
			if (joint.connectedBody != null)
			{
				for (int i = 0; i < colleagues.Length; i++)
				{
					if (colleagues[i].joint.GetComponent<Rigidbody>() == joint.connectedBody)
					{
						connectedBodyTarget = colleagues[i].target;
					}
				}
			}
			transform = joint.transform;
			rigidbody = transform.GetComponent<Rigidbody>();
			rigidbody.isKinematic = false;
			UpdateColliders();
			if (_colliders.Length == 0)
			{
				Vector3 size = Vector3.one * 0.1f;
				Renderer component = transform.GetComponent<Renderer>();
				if (component != null)
				{
					size = component.bounds.size;
				}
				rigidbody.inertiaTensor = CalculateInertiaTensorCuboid(size, rigidbody.mass);
			}
			targetParent = ((connectedBodyTarget != null) ? connectedBodyTarget : target.parent);
			defaultLocalRotation = localRotation;
			Vector3 normalized = Vector3.Cross(joint.axis, joint.secondaryAxis).normalized;
			Vector3 normalized2 = Vector3.Cross(normalized, joint.axis).normalized;
			if (normalized == normalized2)
			{
				UnityEngine.Debug.LogError("Joint " + joint.name + " secondaryAxis is in the exact same direction as it's axis. Please make sure they are not aligned.");
				return;
			}
			rotationRelativeToTarget = Quaternion.Inverse(target.rotation) * transform.rotation;
			Quaternion quaternion = Quaternion.LookRotation(normalized, normalized2);
			toJointSpaceInverse = Quaternion.Inverse(quaternion);
			toJointSpaceDefault = defaultLocalRotation * quaternion;
			toParentSpace = Quaternion.Inverse(targetParentRotation) * parentRotation;
			localRotationConvert = Quaternion.Inverse(targetLocalRotation) * localRotation;
			if (joint.connectedBody != null)
			{
				joint.autoConfigureConnectedAnchor = false;
				connectedBodyTransform = joint.connectedBody.transform;
				directTargetParent = target.parent == connectedBodyTarget;
			}
			angularXMotionDefault = joint.angularXMotion;
			angularYMotionDefault = joint.angularYMotion;
			angularZMotionDefault = joint.angularZMotion;
			if (joint.connectedBody == null)
			{
				props.mapPosition = true;
			}
			targetRotationRelative = Quaternion.Inverse(rigidbody.rotation) * target.rotation;
			if (joint.connectedBody == null)
			{
				defaultPosition = transform.localPosition;
				defaultRotation = transform.localRotation;
			}
			else
			{
				defaultPosition = joint.connectedBody.transform.InverseTransformPoint(transform.position);
				defaultRotation = Quaternion.Inverse(joint.connectedBody.transform.rotation) * transform.rotation;
			}
			defaultTargetLocalPosition = target.localPosition;
			defaultTargetLocalRotation = target.localRotation;
			joint.rotationDriveMode = RotationDriveMode.Slerp;
			if (!joint.gameObject.activeInHierarchy)
			{
				UnityEngine.Debug.LogError("Can not initiate a puppet that has deactivated muscles.", joint.transform);
				return;
			}
			joint.configuredInWorldSpace = false;
			joint.projectionMode = JointProjectionMode.None;
			if (joint.anchor != Vector3.zero)
			{
				UnityEngine.Debug.LogError("PuppetMaster joint anchors need to be Vector3.zero. Joint axis on " + transform.name + " is " + joint.anchor, transform);
			}
			else
			{
				targetAnimatedPosition = target.position;
				targetAnimatedWorldRotation = target.rotation;
				targetAnimatedRotation = targetLocalRotation * localRotationConvert;
				Read();
				lastReadTime = Time.time;
				lastWriteTime = Time.time;
				lastMappedPosition = target.position;
				lastMappedRotation = target.rotation;
				initiated = true;
			}
		}

		public void UpdateColliders()
		{
			_colliders = new Collider[0];
			AddColliders(joint.transform, ref _colliders, includeMeshColliders: true);
			int childCount = joint.transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				AddCompoundColliders(joint.transform.GetChild(i), ref _colliders);
			}
			disabledColliders = new bool[_colliders.Length];
		}

		public void DisableColliders()
		{
			for (int i = 0; i < _colliders.Length; i++)
			{
				disabledColliders[i] = _colliders[i].enabled;
				_colliders[i].enabled = false;
			}
		}

		public void EnableColliders()
		{
			for (int i = 0; i < _colliders.Length; i++)
			{
				if (disabledColliders[i])
				{
					_colliders[i].enabled = true;
				}
				disabledColliders[i] = false;
			}
		}

		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
			Collider[] components = t.GetComponents<Collider>();
			int num = 0;
			Collider[] array = components;
			foreach (Collider obj in array)
			{
				bool flag = obj is MeshCollider;
				if (!obj.isTrigger && (!includeMeshColliders || !flag))
				{
					num++;
				}
			}
			if (num == 0)
			{
				return;
			}
			int num2 = C.Length;
			Array.Resize(ref C, num2 + num);
			int num3 = 0;
			for (int j = 0; j < components.Length; j++)
			{
				bool flag2 = components[j] is MeshCollider;
				if (!components[j].isTrigger && (!includeMeshColliders || !flag2))
				{
					C[num2 + num3] = components[j];
					num3++;
				}
			}
		}

		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
			if (!(t.GetComponent<Rigidbody>() != null))
			{
				AddColliders(t, ref colliders, includeMeshColliders: false);
				int childCount = t.childCount;
				for (int i = 0; i < childCount; i++)
				{
					AddCompoundColliders(t.GetChild(i), ref colliders);
				}
			}
		}

		public void IgnoreCollisions(Muscle m, bool ignore)
		{
			Collider[] array = colliders;
			foreach (Collider collider in array)
			{
				Collider[] array2 = m.colliders;
				foreach (Collider collider2 in array2)
				{
					if (collider != null && collider2 != null && collider.enabled && collider2.enabled && collider.gameObject.activeInHierarchy && collider2.gameObject.activeInHierarchy)
					{
						Physics.IgnoreCollision(collider, collider2, ignore);
					}
				}
			}
		}

		public void IgnoreAngularLimits(bool ignore)
		{
			if (initiated)
			{
				joint.angularXMotion = (ignore ? ConfigurableJointMotion.Free : angularXMotionDefault);
				joint.angularYMotion = (ignore ? ConfigurableJointMotion.Free : angularYMotionDefault);
				joint.angularZMotion = (ignore ? ConfigurableJointMotion.Free : angularZMotionDefault);
			}
		}

		public void FixTargetTransforms()
		{
			if (initiated)
			{
				target.localPosition = defaultTargetLocalPosition;
				target.localRotation = defaultTargetLocalRotation;
			}
		}

		public void Reset()
		{
			if (initiated && !(joint == null))
			{
				if (joint.connectedBody == null)
				{
					transform.localPosition = defaultPosition;
					transform.localRotation = defaultRotation;
				}
				else
				{
					transform.position = joint.connectedBody.transform.TransformPoint(defaultPosition);
					transform.rotation = joint.connectedBody.transform.rotation * defaultRotation;
				}
			}
		}

		public void MoveToTarget()
		{
			if (initiated)
			{
				transform.position = target.position;
				transform.rotation = target.rotation * rotationRelativeToTarget;
			}
		}

		public void Read()
		{
			float num = Time.time - lastReadTime;
			lastReadTime = Time.time;
			if (num > 0f)
			{
				targetVelocity = (target.position - targetAnimatedPosition) / num;
				targetAngularVelocity = QuaTools.FromToRotation(targetAnimatedWorldRotation, target.rotation).eulerAngles / num;
			}
			targetAnimatedPosition = target.position;
			targetAnimatedWorldRotation = target.rotation;
			if (joint.connectedBody != null)
			{
				targetAnimatedRotation = targetLocalRotation * localRotationConvert;
			}
		}

		public void ClearVelocities()
		{
			targetVelocity = Vector3.zero;
			targetAngularVelocity = Vector3.zero;
			mappedVelocity = Vector3.zero;
			mappedAngularVelocity = Vector3.zero;
			targetAnimatedPosition = target.position;
			targetAnimatedWorldRotation = target.rotation;
			lastMappedPosition = target.position;
			lastMappedRotation = target.rotation;
		}

		public void UpdateAnchor(bool supportTranslationAnimation)
		{
			if (!(joint.connectedBody == null) && !(connectedBodyTarget == null) && (!directTargetParent || supportTranslationAnimation))
			{
				Vector3 vector2 = (joint.connectedAnchor = InverseTransformPointUnscaled(connectedBodyTarget.position, connectedBodyTarget.rotation * toParentSpace, target.position));
				Vector3 vector3 = vector2;
				float num = 1f / connectedBodyTransform.lossyScale.x;
				joint.connectedAnchor = vector3 * num;
			}
		}

		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged)
		{
			state.velocity = rigidbody.velocity;
			state.angularVelocity = rigidbody.angularVelocity;
			props.Clamp();
			state.Clamp();
			Pin(pinWeightMaster, pinPow, pinDistanceFalloff);
			if (rotationTargetChanged)
			{
				MuscleRotation(muscleWeightMaster, muscleSpring, muscleDamper);
			}
		}

		public void Map(float mappingWeightMaster)
		{
			float num = props.mappingWeight * mappingWeightMaster * state.mappingWeightMlp;
			if (num <= 0f)
			{
				return;
			}
			Vector3 position = transform.position;
			Quaternion rotation = transform.rotation;
			if (num >= 1f)
			{
				target.rotation = rotation * targetRotationRelative;
				if (props.mapPosition)
				{
					if (connectedBodyTransform != null)
					{
						Vector3 position2 = connectedBodyTransform.InverseTransformPoint(position);
						target.position = connectedBodyTarget.TransformPoint(position2);
					}
					else
					{
						target.position = position;
					}
				}
				return;
			}
			target.rotation = Quaternion.Lerp(target.rotation, rotation * targetRotationRelative, num);
			if (props.mapPosition)
			{
				if (connectedBodyTransform != null)
				{
					Vector3 position3 = connectedBodyTransform.InverseTransformPoint(position);
					target.position = Vector3.Lerp(target.position, connectedBodyTarget.TransformPoint(position3), num);
				}
				else
				{
					target.position = Vector3.Lerp(target.position, position, num);
				}
			}
		}

		public void CalculateMappedVelocity()
		{
			float num = Time.time - lastWriteTime;
			if (num > 0f)
			{
				mappedVelocity = (target.position - lastMappedPosition) / num;
				mappedAngularVelocity = QuaTools.FromToRotation(lastMappedRotation, target.rotation).eulerAngles / num;
				lastWriteTime = Time.time;
			}
			lastMappedPosition = target.position;
			lastMappedRotation = target.rotation;
		}

		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff)
		{
			positionOffset = targetAnimatedPosition - rigidbody.position;
			if (float.IsNaN(positionOffset.x))
			{
				positionOffset = Vector3.zero;
			}
			float num = pinWeightMaster * props.pinWeight * state.pinWeightMlp;
			if (!(num <= 0f))
			{
				num = Mathf.Pow(num, pinPow);
				Vector3 vector = positionOffset / Time.fixedDeltaTime;
				Vector3 vector2 = -rigidbody.velocity + targetVelocity + vector;
				vector2 *= num;
				if (pinDistanceFalloff > 0f)
				{
					vector2 /= 1f + positionOffset.sqrMagnitude * pinDistanceFalloff;
				}
				rigidbody.velocity += vector2;
			}
		}

		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
			float num = muscleWeightMaster * props.muscleWeight * muscleSpring * state.muscleWeightMlp * 10f;
			if (joint.connectedBody == null)
			{
				num = 0f;
			}
			else if (num > 0f)
			{
				joint.targetRotation = LocalToJointSpace(targetAnimatedRotation);
			}
			float num2 = props.muscleDamper * muscleDamper * state.muscleDamperMlp + state.muscleDamperAdd;
			if (num != lastJointDriveRotationWeight || num2 != lastRotationDamper)
			{
				lastJointDriveRotationWeight = num;
				lastRotationDamper = num2;
				slerpDrive.positionSpring = num;
				slerpDrive.maximumForce = Mathf.Max(num, num2) * state.maxForceMlp;
				slerpDrive.positionDamper = num2;
				joint.slerpDrive = slerpDrive;
			}
		}

		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return toJointSpaceInverse * Quaternion.Inverse(localRotation) * toJointSpaceDefault;
		}

		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return Quaternion.Inverse(rotation) * (point - position);
		}

		private Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			float num = Mathf.Pow(size.x, 2f);
			float num2 = Mathf.Pow(size.y, 2f);
			float num3 = Mathf.Pow(size.z, 2f);
			float num4 = 1f / 12f * mass;
			return new Vector3(num4 * (num2 + num3), num4 * (num + num3), num4 * (num + num2));
		}
	}
	public struct MuscleCollision
	{
		public int muscleIndex;

		public Collision collision;

		public bool isStay;

		public MuscleCollision(int muscleIndex, Collision collision, bool isStay = false)
		{
			this.muscleIndex = muscleIndex;
			this.collision = collision;
			this.isStay = isStay;
		}
	}
	public struct MuscleHit
	{
		public int muscleIndex;

		public float unPin;

		public Vector3 force;

		public Vector3 position;

		public MuscleHit(int muscleIndex, float unPin, Vector3 force, Vector3 position)
		{
			this.muscleIndex = muscleIndex;
			this.unPin = unPin;
			this.force = force;
			this.position = position;
		}
	}
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Muscle Collision Broadcaster")]
	public class MuscleCollisionBroadcaster : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[SerializeField]
		[HideInInspector]
		public int muscleIndex;

		private const string onMuscleHit = "OnMuscleHit";

		private const string onMuscleCollision = "OnMuscleCollision";

		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		private MuscleCollisionBroadcaster otherBroadcaster;

		public void Hit(float unPin, Vector3 force, Vector3 position)
		{
			if (base.enabled)
			{
				BehaviourBase[] behaviours = puppetMaster.behaviours;
				for (int i = 0; i < behaviours.Length; i++)
				{
					behaviours[i].OnMuscleHit(new MuscleHit(muscleIndex, unPin, force, position));
				}
			}
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (base.enabled && !(puppetMaster == null) && !(collision.collider.transform.root == base.transform.root))
			{
				BehaviourBase[] behaviours = puppetMaster.behaviours;
				for (int i = 0; i < behaviours.Length; i++)
				{
					behaviours[i].OnMuscleCollision(new MuscleCollision(muscleIndex, collision));
				}
			}
		}

		private void OnCollisionStay(Collision collision)
		{
			if (base.enabled && !(puppetMaster == null) && (!(Singleton<PuppetMasterSettings>.instance != null) || Singleton<PuppetMasterSettings>.instance.collisionStayMessages) && !(collision.collider.transform.root == base.transform.root))
			{
				BehaviourBase[] behaviours = puppetMaster.behaviours;
				for (int i = 0; i < behaviours.Length; i++)
				{
					behaviours[i].OnMuscleCollision(new MuscleCollision(muscleIndex, collision, isStay: true));
				}
			}
		}

		private void OnCollisionExit(Collision collision)
		{
			if (base.enabled && !(puppetMaster == null) && (!(Singleton<PuppetMasterSettings>.instance != null) || Singleton<PuppetMasterSettings>.instance.collisionExitMessages) && !(collision.collider.transform.root == base.transform.root))
			{
				BehaviourBase[] behaviours = puppetMaster.behaviours;
				for (int i = 0; i < behaviours.Length; i++)
				{
					behaviours[i].OnMuscleCollisionExit(new MuscleCollision(muscleIndex, collision));
				}
			}
		}
	}
	public static class PhysXTools
	{
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			Vector3 zero = Vector3.zero;
			float num = 0f;
			for (int i = 0; i < rigidbodies.Length; i++)
			{
				if (rigidbodies[i].gameObject.activeInHierarchy)
				{
					zero += rigidbodies[i].worldCenterOfMass * rigidbodies[i].mass;
					num += rigidbodies[i].mass;
				}
			}
			return zero / num;
		}

		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			Vector3 zero = Vector3.zero;
			float num = 0f;
			for (int i = 0; i < rigidbodies.Length; i++)
			{
				if (rigidbodies[i].gameObject.activeInHierarchy)
				{
					zero += rigidbodies[i].velocity * rigidbodies[i].mass;
					num += rigidbodies[i].mass;
				}
			}
			return zero / num;
		}

		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
			v = rotation * Div(Quaternion.Inverse(rotation) * v, inertiaTensor);
		}

		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
			v = rotation * Vector3.Scale(Quaternion.Inverse(rotation) * v, inertiaTensor);
		}

		public static Vector3 GetFromToAcceleration(Vector3 fromV, Vector3 toV)
		{
			Quaternion quaternion = Quaternion.FromToRotation(fromV, toV);
			float angle = 0f;
			Vector3 axis = Vector3.zero;
			quaternion.ToAngleAxis(out angle, out axis);
			return angle * axis * ((float)Math.PI / 180f) / Time.fixedDeltaTime;
		}

		public static Vector3 GetAngularAcceleration(Quaternion fromR, Quaternion toR)
		{
			Vector3 vector = Vector3.Cross(fromR * Vector3.forward, toR * Vector3.forward);
			Vector3 vector2 = Vector3.Cross(fromR * Vector3.up, toR * Vector3.up);
			float num = Quaternion.Angle(fromR, toR);
			return Vector3.Normalize(vector + vector2) * num * ((float)Math.PI / 180f) / Time.fixedDeltaTime;
		}

		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode)
		{
			Vector3 angularAcceleration = GetAngularAcceleration(r.rotation, toR);
			angularAcceleration -= r.angularVelocity;
			switch (forceMode)
			{
			case ForceMode.Acceleration:
				r.AddTorque(angularAcceleration / Time.fixedDeltaTime, forceMode);
				break;
			case ForceMode.Force:
			{
				Vector3 v2 = angularAcceleration / Time.fixedDeltaTime;
				ScaleByInertia(ref v2, r.rotation, r.inertiaTensor);
				r.AddTorque(v2, forceMode);
				break;
			}
			case ForceMode.Impulse:
			{
				Vector3 v = angularAcceleration;
				ScaleByInertia(ref v, r.rotation, r.inertiaTensor);
				r.AddTorque(v, forceMode);
				break;
			}
			case ForceMode.VelocityChange:
				r.AddTorque(angularAcceleration, forceMode);
				break;
			case (ForceMode)3:
			case (ForceMode)4:
				break;
			}
		}

		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
			Vector3 fromToAcceleration = GetFromToAcceleration(fromV, toV);
			fromToAcceleration -= r.angularVelocity;
			switch (forceMode)
			{
			case ForceMode.Acceleration:
				r.AddTorque(fromToAcceleration / Time.fixedDeltaTime, forceMode);
				break;
			case ForceMode.Force:
			{
				Vector3 v2 = fromToAcceleration / Time.fixedDeltaTime;
				ScaleByInertia(ref v2, r.rotation, r.inertiaTensor);
				r.AddTorque(v2, forceMode);
				break;
			}
			case ForceMode.Impulse:
			{
				Vector3 v = fromToAcceleration;
				ScaleByInertia(ref v, r.rotation, r.inertiaTensor);
				r.AddTorque(v, forceMode);
				break;
			}
			case ForceMode.VelocityChange:
				r.AddTorque(fromToAcceleration, forceMode);
				break;
			case (ForceMode)3:
			case (ForceMode)4:
				break;
			}
		}

		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
			Vector3 linearAcceleration = GetLinearAcceleration(fromV, toV);
			linearAcceleration -= r.velocity;
			switch (forceMode)
			{
			case ForceMode.Acceleration:
				r.AddForce(linearAcceleration / Time.fixedDeltaTime, forceMode);
				break;
			case ForceMode.Force:
			{
				Vector3 force2 = linearAcceleration / Time.fixedDeltaTime;
				force2 *= r.mass;
				r.AddForce(force2, forceMode);
				break;
			}
			case ForceMode.Impulse:
			{
				Vector3 force = linearAcceleration;
				force *= r.mass;
				r.AddForce(force, forceMode);
				break;
			}
			case ForceMode.VelocityChange:
				r.AddForce(linearAcceleration, forceMode);
				break;
			case (ForceMode)3:
			case (ForceMode)4:
				break;
			}
		}

		public static Vector3 GetLinearAcceleration(Vector3 fromPoint, Vector3 toPoint)
		{
			return (toPoint - fromPoint) / Time.fixedDeltaTime;
		}

		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			Vector3 vector = Vector3.Cross(joint.axis, joint.secondaryAxis);
			Vector3 upwards = Vector3.Cross(vector, joint.axis);
			return Quaternion.LookRotation(vector, upwards);
		}

		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			float num = size.x * size.x;
			float num2 = size.y * size.y;
			float num3 = size.z * size.z;
			float num4 = 1f / 12f * mass;
			return new Vector3(num4 * (num2 + num3), num4 * (num + num3), num4 * (num + num2));
		}

		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return new Vector3(v.x / v2.x, v.y / v2.y, v.z / v2.z);
		}
	}
	public class PressureSensor : MonoBehaviour
	{
		public bool visualize;

		public LayerMask layers;

		private bool fixedFrame;

		private Vector3 P;

		private int count;

		public Vector3 center { get; private set; }

		public bool inContact { get; private set; }

		public Vector3 bottom { get; private set; }

		public Rigidbody r { get; private set; }

		private void Awake()
		{
			r = GetComponent<Rigidbody>();
			center = base.transform.position;
		}

		private void OnCollisionEnter(Collision c)
		{
			ProcessCollision(c);
		}

		private void OnCollisionStay(Collision c)
		{
			ProcessCollision(c);
		}

		private void OnCollisionExit(Collision c)
		{
			inContact = false;
		}

		private void FixedUpdate()
		{
			fixedFrame = true;
			if (!r.IsSleeping())
			{
				P = Vector3.zero;
				count = 0;
			}
		}

		private void LateUpdate()
		{
			if (fixedFrame)
			{
				if (count > 0)
				{
					center = P / count;
				}
				fixedFrame = false;
			}
		}

		private void ProcessCollision(Collision c)
		{
			if (LayerMaskExtensions.Contains(layers, c.gameObject.layer))
			{
				Vector3 zero = Vector3.zero;
				for (int i = 0; i < c.contacts.Length; i++)
				{
					zero += c.contacts[i].point;
				}
				zero /= (float)c.contacts.Length;
				P += zero;
				count++;
				inContact = true;
			}
		}

		private void OnDrawGizmos()
		{
			if (visualize)
			{
				Gizmos.DrawSphere(center, 0.1f);
			}
		}
	}
	public abstract class Prop : MonoBehaviour
	{
		[Tooltip("This has no other purpose but helping you distinguish props by PropRoot.currentProp.propType.")]
		public int propType;

		[LargeHeader("Muscle")]
		[Tooltip("The Muscle of this prop.")]
		public ConfigurableJoint muscle;

		[Tooltip("The muscle properties that will be applied to the Muscle on pickup.")]
		public Muscle.Props muscleProps = new Muscle.Props();

		[Tooltip("If true, this prop's layer will be forced to PuppetMaster layer and target's layer forced to PuppetMaster's Target Root's layer when the prop is picked up.")]
		public bool forceLayers = true;

		[LargeHeader("Additional Pin")]
		[Tooltip("Optinal additional pin, useful for long melee weapons that would otherwise require a lot of muscle force and solver iterations to be swinged quickly. Should normally be without any colliders attached. The position of the pin, it's mass and the pin weight will effect how the prop will handle.")]
		public ConfigurableJoint additionalPin;

		[Tooltip("Target Transform for the additional pin.")]
		public Transform additionalPinTarget;

		[Tooltip("The pin weight of the additional pin. Increasing this weight will make the prop follow animation better, but will increase jitter when colliding with objects.")]
		[Range(0f, 1f)]
		public float additionalPinWeight = 1f;

		private ConfigurableJointMotion xMotion;

		private ConfigurableJointMotion yMotion;

		private ConfigurableJointMotion zMotion;

		private ConfigurableJointMotion angularXMotion;

		private ConfigurableJointMotion angularYMotion;

		private ConfigurableJointMotion angularZMotion;

		private Collider[] colliders = new Collider[0];

		public bool isPickedUp => propRoot != null;

		public PropRoot propRoot { get; private set; }

		public void PickUp(PropRoot propRoot)
		{
			muscle.xMotion = xMotion;
			muscle.yMotion = yMotion;
			muscle.zMotion = zMotion;
			muscle.angularXMotion = angularXMotion;
			muscle.angularYMotion = angularYMotion;
			muscle.angularZMotion = angularZMotion;
			this.propRoot = propRoot;
			muscle.gameObject.layer = propRoot.puppetMaster.gameObject.layer;
			Collider[] array = colliders;
			foreach (Collider collider in array)
			{
				if (!collider.isTrigger)
				{
					collider.gameObject.layer = muscle.gameObject.layer;
				}
			}
			OnPickUp(propRoot);
		}

		public void Drop()
		{
			propRoot = null;
			OnDrop();
		}

		public void StartPickedUp(PropRoot propRoot)
		{
			this.propRoot = propRoot;
		}

		protected virtual void OnPickUp(PropRoot propRoot)
		{
		}

		protected virtual void OnDrop()
		{
		}

		protected virtual void OnStart()
		{
		}

		protected virtual void Awake()
		{
			if (base.transform.position != muscle.transform.position)
			{
				UnityEngine.Debug.LogError("Prop target position must match exactly with it's muscle's position!", base.transform);
			}
			xMotion = muscle.xMotion;
			yMotion = muscle.yMotion;
			zMotion = muscle.zMotion;
			angularXMotion = muscle.angularXMotion;
			angularYMotion = muscle.angularYMotion;
			angularZMotion = muscle.angularZMotion;
			colliders = muscle.GetComponentsInChildren<Collider>();
		}

		private void Start()
		{
			if (!isPickedUp)
			{
				ReleaseJoint();
			}
			OnStart();
		}

		private void ReleaseJoint()
		{
			muscle.connectedBody = null;
			muscle.targetRotation = Quaternion.identity;
			JointDrive slerpDrive = default(JointDrive);
			slerpDrive.positionSpring = 0f;
			muscle.slerpDrive = slerpDrive;
			muscle.xMotion = ConfigurableJointMotion.Free;
			muscle.yMotion = ConfigurableJointMotion.Free;
			muscle.zMotion = ConfigurableJointMotion.Free;
			muscle.angularXMotion = ConfigurableJointMotion.Free;
			muscle.angularYMotion = ConfigurableJointMotion.Free;
			muscle.angularZMotion = ConfigurableJointMotion.Free;
		}

		private void OnDrawGizmos()
		{
			if (!(muscle == null) && !Application.isPlaying)
			{
				base.transform.position = muscle.transform.position;
				base.transform.rotation = muscle.transform.rotation;
				if (additionalPinTarget != null && additionalPin != null)
				{
					additionalPinTarget.position = additionalPin.transform.position;
				}
				muscleProps.group = Muscle.Group.Prop;
			}
		}
	}
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Prop Root")]
	public class PropRoot : MonoBehaviour
	{
		[Tooltip("Reference to the PuppetMaster component.")]
		public PuppetMaster puppetMaster;

		[Tooltip("If a prop is connected, what will it's joint be connected to?")]
		public Rigidbody connectTo;

		[Tooltip("Is there a Prop connected to this PropRoot? Simply assign this value to connect, replace or drop props.")]
		public Prop currentProp;

		private Prop lastProp;

		private bool fixedUpdateCalled;

		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
			Application.OpenURL("http://root-motion.com/puppetmasterdox/html/page6.html");
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://root-motion.com/puppetmasterdox/html/class_root_motion_1_1_dynamics_1_1_prop_root.html");
		}

		public void DropImmediate()
		{
			if (!(lastProp == null))
			{
				puppetMaster.RemoveMuscleRecursive(lastProp.muscle, attachTarget: true);
				lastProp.Drop();
				currentProp = null;
				lastProp = null;
			}
		}

		private void Awake()
		{
			if (currentProp != null)
			{
				currentProp.StartPickedUp(this);
			}
		}

		private void Update()
		{
			if (fixedUpdateCalled && currentProp != null && lastProp == currentProp && currentProp.muscle.connectedBody == null)
			{
				currentProp.Drop();
				currentProp = null;
				lastProp = null;
			}
		}

		private void FixedUpdate()
		{
			fixedUpdateCalled = true;
			if (!(currentProp == lastProp))
			{
				if (currentProp == null)
				{
					puppetMaster.RemoveMuscleRecursive(lastProp.muscle, attachTarget: true);
					lastProp.Drop();
				}
				if (lastProp == null)
				{
					AttachProp(currentProp);
				}
				if (lastProp != null && currentProp != null)
				{
					puppetMaster.RemoveMuscleRecursive(lastProp.muscle, attachTarget: true);
					AttachProp(currentProp);
				}
				lastProp = currentProp;
			}
		}

		private void AttachProp(Prop prop)
		{
			prop.transform.position = base.transform.position;
			prop.transform.rotation = base.transform.rotation;
			prop.PickUp(this);
			puppetMaster.AddMuscle(prop.muscle, prop.transform, connectTo, base.transform, prop.muscleProps, forceTreeHierarchy: false, prop.forceLayers);
			if (prop.additionalPin != null && prop.additionalPinTarget != null)
			{
				puppetMaster.AddMuscle(prop.additionalPin, prop.additionalPinTarget, prop.muscle.GetComponent<Rigidbody>(), prop.transform, new Muscle.Props(prop.additionalPinWeight, 0f, 0f, 0f, mapPosition: false, Muscle.Group.Prop), forceTreeHierarchy: true, prop.forceLayers);
			}
		}
	}
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Prop Template")]
	public class PropTemplate : Prop
	{
		protected override void OnStart()
		{
		}

		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		protected override void OnDrop()
		{
		}
	}
	[HelpURL("https://www.youtube.com/watch?v=LYusqeqHAUc")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Puppet Master")]
	public class PuppetMaster : MonoBehaviour
	{
		[Serializable]
		public enum Mode
		{
			Active,
			Kinematic,
			Disabled
		}

		public delegate void UpdateDelegate();

		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		public enum UpdateMode
		{
			Normal,
			AnimatePhysics,
			FixedUpdate
		}

		[Serializable]
		public enum State
		{
			Alive,
			Dead,
			Frozen
		}

		[Serializable]
		public struct StateSettings
		{
			[Tooltip("How much does it take to weigh out muscle weight to deadMuscleWeight?")]
			public float killDuration;

			[Tooltip("The muscle weight mlp while the puppet is Dead.")]
			public float deadMuscleWeight;

			[Tooltip("The muscle damper add while the puppet is Dead.")]
			public float deadMuscleDamper;

			[Tooltip("The max square velocity of the ragdoll bones for freezing the puppet.")]
			public float maxFreezeSqrVelocity;

			[Tooltip("If true, PuppetMaster, all it's behaviours and the ragdoll will be destroyed when the puppet is frozen.")]
			public bool freezePermanently;

			[Tooltip("If true, will enable angular limits when killing the puppet.")]
			public bool enableAngularLimitsOnKill;

			[Tooltip("If true, will enable internal collisions when killing the puppet.")]
			public bool enableInternalCollisionsOnKill;

			public static StateSettings Default => new StateSettings(1f);

			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool freezePermanently = false, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
				this.killDuration = killDuration;
				this.deadMuscleWeight = deadMuscleWeight;
				this.deadMuscleDamper = deadMuscleDamper;
				this.maxFreezeSqrVelocity = maxFreezeSqrVelocity;
				this.freezePermanently = freezePermanently;
				this.enableAngularLimitsOnKill = enableAngularLimitsOnKill;
				this.enableInternalCollisionsOnKill = enableInternalCollisionsOnKill;
			}
		}

		[Tooltip("Humanoid Config allows you to easily share PuppetMaster properties, including individual muscle props between Humanoid puppets.")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		public Transform targetRoot;

		[LargeHeader("Simulation")]
		[Tooltip("Sets/sets the state of the puppet (Alive, Dead or Frozen). Frozen means the ragdoll will be deactivated once it comes to stop in dead state.")]
		public State state;

		[ContextMenuItem("Reset To Default", "ResetStateSettings")]
		public StateSettings stateSettings = StateSettings.Default;

		[Tooltip("Active mode means all muscles are active and the character is physically simulated. Kinematic mode sets rigidbody.isKinematic to true for all the muscles and simply updates their position/rotation to match the target's. Disabled mode disables the ragdoll. Switching modes is done by simply changing this value, blending in/out will be handled automatically by the PuppetMaster.")]
		public Mode mode;

		[Tooltip("The time of blending when switching from Active to Kinematic/Disabled or from Kinematic/Disabled to Active. Switching from Kinematic to Disabled or vice versa will be done instantly.")]
		public float blendTime = 0.1f;

		[Tooltip("If true, will fix the target character's Transforms to their default local positions and rotations in each update cycle to avoid drifting from additive reading-writing. Use this only if the target contains unanimated bones.")]
		public bool fixTargetTransforms = true;

		[Tooltip("Rigidbody.solverIterationCount for the muscles of this Puppet.")]
		public int solverIterationCount = 6;

		[Tooltip("If true, will draw the target's pose as green lines in the Scene view. This runs in the Editor only. If you wish to profile PuppetMaster, switch this off.")]
		public bool visualizeTargetPose = true;

		[LargeHeader("Master Weights")]
		[Tooltip("The weight of mapping the animated character to the ragdoll pose.")]
		[Range(0f, 1f)]
		public float mappingWeight = 1f;

		[Tooltip("The weight of pinning the muscles to the position of their animated targets using simple AddForce.")]
		[Range(0f, 1f)]
		public float pinWeight = 1f;

		[Tooltip("The normalized strength of the muscles.")]
		[Range(0f, 1f)]
		public float muscleWeight = 1f;

		[LargeHeader("Joint and Muscle Settings")]
		[Tooltip("The positionSpring of the ConfigurableJoints' Slerp Drive.")]
		public float muscleSpring = 100f;

		[Tooltip("The positionDamper of the ConfigurableJoints' Slerp Drive.")]
		public float muscleDamper;

		[Tooltip("Adjusts the slope of the pinWeight curve. Has effect only while interpolating pinWeight from 0 to 1 and back.")]
		[Range(1f, 8f)]
		public float pinPow = 4f;

		[Tooltip("Reduces pinning force the farther away the target is. Bigger value loosens the pinning, resulting in sloppier behaviour.")]
		[Range(0f, 100f)]
		public float pinDistanceFalloff = 5f;

		[Tooltip("When the target has animated bones between the muscle bones, the joint anchors need to be updated in every update cycle because the muscles' targets move relative to each other in position space. This gives much more accurate results, but is computationally expensive so consider leaving it off.")]
		public bool updateJointAnchors = true;

		[Tooltip("Enable this if any of the target's bones has translation animation.")]
		public bool supportTranslationAnimation;

		[Tooltip("Should the joints use angular limits? If the PuppetMaster fails to match the target's pose, it might be because the joint limits are too stiff and do not allow for such motion. Uncheck this to see if the limits are clamping the range of your puppet's animation. Since the joints are actuated, most PuppetMaster simulations will not actually require using joint limits at all.")]
		public bool angularLimits;

		[Tooltip("Should the muscles collide with each other? Consider leaving this off while the puppet is pinned for performance and better accuracy.  Since the joints are actuated, most PuppetMaster simulations will not actually require internal collisions at all.")]
		public bool internalCollisions;

		[LargeHeader("Individual Muscle Settings")]
		public Muscle[] muscles = new Muscle[0];

		public UpdateDelegate OnPostInitiate;

		public UpdateDelegate OnRead;

		public UpdateDelegate OnWrite;

		public UpdateDelegate OnPostLateUpdate;

		public UpdateDelegate OnFixTransforms;

		public UpdateDelegate OnHierarchyChanged;

		public MuscleDelegate OnMuscleRemoved;

		private Animator _targetAnimator;

		[HideInInspector]
		public List<SolverManager> solvers = new List<SolverManager>();

		private bool internalCollisionsEnabled = true;

		private bool angularLimitsEnabled = true;

		private bool fixedFrame;

		private int lastSolverIterationCount;

		private bool isLegacy;

		private bool animatorDisabled;

		private bool awakeFailed;

		private bool interpolated;

		private bool freezeFlag;

		private bool hasBeenDisabled;

		private bool hierarchyIsFlat;

		private bool teleport;

		private Vector3 teleportPosition;

		private Quaternion teleportRotation = Quaternion.identity;

		private bool teleportMoveToTarget;

		private Mode activeMode;

		private Mode lastMode;

		private float mappingBlend = 1f;

		public UpdateDelegate OnFreeze;

		public UpdateDelegate OnUnfreeze;

		public UpdateDelegate OnDeath;

		public UpdateDelegate OnResurrection;

		private State activeState;

		private State lastState;

		private bool angularLimitsEnabledOnKill;

		private bool internalCollisionsEnabledOnKill;

		private bool animationDisabledbyStates;

		[HideInInspector]
		public bool storeTargetMappedState = true;

		private Transform[] targetChildren = new Transform[0];

		private Vector3[] targetMappedPositions;

		private Quaternion[] targetMappedRotations;

		private Vector3[] targetSampledPositions;

		private Quaternion[] targetSampledRotations;

		private bool targetMappedStateStored;

		private bool targetMappedStateSampled;

		private bool sampleTargetMappedState;

		private bool hasProp;

		public Animator targetAnimator
		{
			get
			{
				if (_targetAnimator == null)
				{
					_targetAnimator = targetRoot.GetComponentInChildren<Animator>();
				}
				if (_targetAnimator == null && targetRoot.parent != null)
				{
					_targetAnimator = targetRoot.parent.GetComponentInChildren<Animator>();
				}
				return _targetAnimator;
			}
			set
			{
				_targetAnimator = value;
			}
		}

		public Animation targetAnimation { get; private set; }

		public BehaviourBase[] behaviours { get; private set; }

		public bool isActive
		{
			get
			{
				if (base.isActiveAndEnabled && initiated)
				{
					if (activeMode != 0)
					{
						return isBlending;
					}
					return true;
				}
				return false;
			}
		}

		public bool initiated { get; private set; }

		public UpdateMode updateMode
		{
			get
			{
				if (targetUpdateMode != AnimatorUpdateMode.AnimatePhysics)
				{
					return UpdateMode.Normal;
				}
				if (!isLegacy)
				{
					return UpdateMode.FixedUpdate;
				}
				return UpdateMode.AnimatePhysics;
			}
		}

		public bool controlsAnimator
		{
			get
			{
				if (base.isActiveAndEnabled && isActive && initiated)
				{
					return updateMode == UpdateMode.FixedUpdate;
				}
				return false;
			}
		}

		public bool isBlending
		{
			get
			{
				if (!isSwitchingMode)
				{
					return isSwitchingState;
				}
				return true;
			}
		}

		private AnimatorUpdateMode targetUpdateMode
		{
			get
			{
				if (targetAnimator != null)
				{
					return targetAnimator.updateMode;
				}
				if (targetAnimation != null)
				{
					if (!targetAnimation.animatePhysics)
					{
						return AnimatorUpdateMode.Normal;
					}
					return AnimatorUpdateMode.AnimatePhysics;
				}
				return AnimatorUpdateMode.Normal;
			}
		}

		public bool isSwitchingMode { get; private set; }

		public bool isSwitchingState => activeState != state;

		public bool isKilling { get; private set; }

		public bool isAlive => activeState == State.Alive;

		public bool isFrozen => activeState == State.Frozen;

		[ContextMenu("User Manual (Setup)")]
		private void OpenUserManualSetup()
		{
			Application.OpenURL("http://root-motion.com/puppetmasterdox/html/page4.html");
		}

		[ContextMenu("User Manual (Component)")]
		private void OpenUserManualComponent()
		{
			Application.OpenURL("http://root-motion.com/puppetmasterdox/html/page5.html");
		}

		[ContextMenu("User Manual (Performance)")]
		private void OpenUserManualPerformance()
		{
			Application.OpenURL("http://root-motion.com/puppetmasterdox/html/page8.html");
		}

		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
			Application.OpenURL("http://root-motion.com/puppetmasterdox/html/class_root_motion_1_1_dynamics_1_1_puppet_master.html");
		}

		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=mIN9bxJgfOU&index=2&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL");
		}

		[ContextMenu("TUTORIAL VIDEO (COMPONENT)")]
		private void OpenComponentTutorial()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=LYusqeqHAUc");
		}

		private void ResetStateSettings()
		{
			stateSettings = StateSettings.Default;
		}

		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
			teleport = true;
			teleportPosition = position;
			teleportRotation = rotation;
			teleportMoveToTarget = moveToTarget;
		}

		private void OnDisable()
		{
			if (!base.gameObject.activeInHierarchy && initiated && Application.isPlaying)
			{
				Muscle[] array = muscles;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Reset();
				}
			}
			hasBeenDisabled = true;
		}

		private void OnEnable()
		{
			if (!base.gameObject.activeInHierarchy || !initiated || !hasBeenDisabled || !Application.isPlaying)
			{
				return;
			}
			isSwitchingMode = false;
			activeMode = mode;
			lastMode = mode;
			mappingBlend = ((mode == Mode.Active) ? 1f : 0f);
			activeState = state;
			lastState = state;
			isKilling = false;
			freezeFlag = false;
			SetAnimationEnabled(state == State.Alive);
			if (state == State.Alive && targetAnimator != null)
			{
				targetAnimator.Update(0.001f);
			}
			Muscle[] array = muscles;
			foreach (Muscle obj in array)
			{
				obj.state.pinWeightMlp = ((state == State.Alive) ? 1f : 0f);
				obj.state.muscleWeightMlp = ((state == State.Alive) ? 1f : stateSettings.deadMuscleWeight);
				obj.state.muscleDamperAdd = 0f;
			}
			BehaviourBase[] array2;
			if (state != State.Frozen && mode != Mode.Disabled)
			{
				ActivateRagdoll(mode == Mode.Kinematic);
				array2 = behaviours;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].gameObject.SetActive(value: true);
				}
			}
			else
			{
				array = muscles;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].joint.gameObject.SetActive(value: false);
				}
				if (state == State.Frozen)
				{
					array2 = behaviours;
					foreach (BehaviourBase behaviourBase in array2)
					{
						if (behaviourBase.gameObject.activeSelf)
						{
							behaviourBase.deactivated = true;
							behaviourBase.gameObject.SetActive(value: false);
						}
					}
					if (stateSettings.freezePermanently)
					{
						if (behaviours.Length != 0 && behaviours[0] != null)
						{
							UnityEngine.Object.Destroy(behaviours[0].transform.parent.gameObject);
						}
						UnityEngine.Object.Destroy(base.gameObject);
						return;
					}
				}
			}
			array2 = behaviours;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].OnReactivate();
			}
		}

		private void Awake()
		{
			if (muscles.Length != 0)
			{
				Initiate();
				if (!initiated)
				{
					awakeFailed = true;
				}
			}
		}

		private void Start()
		{
			if (!initiated && !awakeFailed)
			{
				Initiate();
			}
			if (initiated)
			{
				SolverManager[] componentsInChildren = targetRoot.GetComponentsInChildren<SolverManager>();
				solvers.AddRange(componentsInChildren);
			}
		}

		public Transform FindTargetRootRecursive(Transform t)
		{
			if (t.parent == null)
			{
				return null;
			}
			foreach (Transform item in t.parent)
			{
				if (item == base.transform)
				{
					return t;
				}
			}
			return FindTargetRootRecursive(t.parent);
		}

		private void Initiate()
		{
			initiated = false;
			if (muscles.Length != 0 && muscles[0].target != null && targetRoot == null)
			{
				targetRoot = FindTargetRootRecursive(muscles[0].target);
			}
			if (targetRoot != null && targetAnimator == null)
			{
				targetAnimator = targetRoot.GetComponentInChildren<Animator>();
				if (targetAnimator == null)
				{
					targetAnimation = targetRoot.GetComponentInChildren<Animation>();
				}
			}
			if (!IsValid(log: true))
			{
				return;
			}
			if (humanoidConfig != null && targetAnimator != null && targetAnimator.isHuman)
			{
				humanoidConfig.ApplyTo(this);
			}
			isLegacy = targetAnimator == null && targetAnimation != null;
			behaviours = base.transform.GetComponentsInChildren<BehaviourBase>();
			if (behaviours.Length == 0 && base.transform.parent != null)
			{
				behaviours = base.transform.parent.GetComponentsInChildren<BehaviourBase>();
			}
			for (int i = 0; i < muscles.Length; i++)
			{
				muscles[i].Initiate(muscles);
				if (behaviours.Length != 0)
				{
					muscles[i].broadcaster = muscles[i].joint.gameObject.GetComponent<MuscleCollisionBroadcaster>();
					if (muscles[i].broadcaster == null)
					{
						muscles[i].broadcaster = muscles[i].joint.gameObject.AddComponent<MuscleCollisionBroadcaster>();
					}
					muscles[i].broadcaster.puppetMaster = this;
					muscles[i].broadcaster.muscleIndex = i;
				}
				muscles[i].jointBreakBroadcaster = muscles[i].joint.gameObject.GetComponent<JointBreakBroadcaster>();
				if (muscles[i].jointBreakBroadcaster == null)
				{
					muscles[i].jointBreakBroadcaster = muscles[i].joint.gameObject.AddComponent<JointBreakBroadcaster>();
				}
				muscles[i].jointBreakBroadcaster.puppetMaster = this;
				muscles[i].jointBreakBroadcaster.muscleIndex = i;
			}
			UpdateHierarchies();
			hierarchyIsFlat = HierarchyIsFlat();
			initiated = true;
			BehaviourBase[] array = behaviours;
			for (int j = 0; j < array.Length; j++)
			{
				array[j].puppetMaster = this;
			}
			array = behaviours;
			for (int j = 0; j < array.Length; j++)
			{
				array[j].Initiate();
			}
			SwitchStates();
			SwitchModes();
			Muscle[] array2 = muscles;
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j].Read();
			}
			StoreTargetMappedState();
			if (Singleton<PuppetMasterSettings>.instance != null)
			{
				Singleton<PuppetMasterSettings>.instance.Register(this);
			}
			bool flag = false;
			array = behaviours;
			foreach (BehaviourBase behaviourBase in array)
			{
				if (behaviourBase is BehaviourPuppet && behaviourBase.enabled)
				{
					ActivateBehaviour(behaviourBase);
					flag = true;
					break;
				}
			}
			if (!flag && behaviours.Length != 0)
			{
				array = behaviours;
				foreach (BehaviourBase behaviourBase2 in array)
				{
					if (behaviourBase2.enabled)
					{
						ActivateBehaviour(behaviourBase2);
						break;
					}
				}
			}
			if (OnPostInitiate != null)
			{
				OnPostInitiate();
			}
		}

		private void ActivateBehaviour(BehaviourBase behaviour)
		{
			BehaviourBase[] array = behaviours;
			foreach (BehaviourBase behaviourBase in array)
			{
				behaviourBase.enabled = behaviourBase == behaviour;
				if (behaviourBase.enabled)
				{
					behaviourBase.Activate();
				}
			}
		}

		private void OnDestroy()
		{
			if (Singleton<PuppetMasterSettings>.instance != null)
			{
				Singleton<PuppetMasterSettings>.instance.Unregister(this);
			}
		}

		private bool IsInterpolated()
		{
			if (!initiated)
			{
				return false;
			}
			Muscle[] array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].rigidbody.interpolation != 0)
				{
					return true;
				}
			}
			return false;
		}

		protected virtual void FixedUpdate()
		{
			if (!initiated || muscles.Length == 0)
			{
				return;
			}
			interpolated = IsInterpolated();
			fixedFrame = true;
			if (!isActive)
			{
				return;
			}
			pinWeight = Mathf.Clamp(pinWeight, 0f, 1f);
			muscleWeight = Mathf.Clamp(muscleWeight, 0f, 1f);
			muscleSpring = Mathf.Clamp(muscleSpring, 0f, muscleSpring);
			muscleDamper = Mathf.Clamp(muscleDamper, 0f, muscleDamper);
			pinPow = Mathf.Clamp(pinPow, 1f, 8f);
			pinDistanceFalloff = Mathf.Max(pinDistanceFalloff, 0f);
			if (updateMode == UpdateMode.FixedUpdate)
			{
				FixTargetTransforms();
				if (targetAnimator.enabled || (!targetAnimator.enabled && animatorDisabled))
				{
					targetAnimator.enabled = false;
					animatorDisabled = true;
					targetAnimator.Update(Time.fixedDeltaTime);
				}
				else
				{
					animatorDisabled = false;
					targetAnimator.enabled = false;
				}
				foreach (SolverManager solver in solvers)
				{
					if (solver != null)
					{
						solver.UpdateSolverExternal();
					}
				}
				Read();
			}
			if (!isFrozen)
			{
				SetInternalCollisions(internalCollisions);
				SetAngularLimits(angularLimits);
				if (solverIterationCount != lastSolverIterationCount)
				{
					for (int i = 0; i < muscles.Length; i++)
					{
						muscles[i].rigidbody.solverIterations = solverIterationCount;
					}
					lastSolverIterationCount = solverIterationCount;
				}
				for (int j = 0; j < muscles.Length; j++)
				{
					muscles[j].Update(pinWeight, muscleWeight, muscleSpring, muscleDamper, pinPow, pinDistanceFalloff, rotationTargetChanged: true);
				}
			}
			if (updateMode == UpdateMode.AnimatePhysics)
			{
				FixTargetTransforms();
			}
		}

		protected virtual void Update()
		{
			if (initiated && muscles.Length != 0)
			{
				if (animatorDisabled)
				{
					targetAnimator.enabled = true;
					animatorDisabled = false;
				}
				if (updateMode == UpdateMode.Normal)
				{
					FixTargetTransforms();
				}
			}
		}

		protected virtual void LateUpdate()
		{
			if (muscles.Length != 0)
			{
				OnLateUpdate();
				if (OnPostLateUpdate != null)
				{
					OnPostLateUpdate();
				}
			}
		}

		protected virtual void OnLateUpdate()
		{
			if (!initiated)
			{
				return;
			}
			if (animatorDisabled)
			{
				targetAnimator.enabled = true;
				animatorDisabled = false;
			}
			SwitchStates();
			SwitchModes();
			switch (updateMode)
			{
			case UpdateMode.FixedUpdate:
				if (!fixedFrame && !interpolated)
				{
					return;
				}
				break;
			case UpdateMode.AnimatePhysics:
				if (!fixedFrame && !interpolated)
				{
					return;
				}
				if (isActive && !fixedFrame)
				{
					Read();
				}
				break;
			case UpdateMode.Normal:
				if (isActive)
				{
					Read();
				}
				break;
			}
			fixedFrame = false;
			if (!isFrozen)
			{
				mappingWeight = Mathf.Clamp(mappingWeight, 0f, 1f);
				float num = mappingWeight * mappingBlend;
				if (num > 0f)
				{
					if (isActive)
					{
						for (int i = 0; i < muscles.Length; i++)
						{
							muscles[i].Map(num);
						}
					}
				}
				else if (activeMode == Mode.Kinematic)
				{
					MoveToTarget();
				}
				BehaviourBase[] array = behaviours;
				for (int j = 0; j < array.Length; j++)
				{
					array[j].OnWrite();
				}
				if (OnWrite != null)
				{
					OnWrite();
				}
				StoreTargetMappedState();
				Muscle[] array2 = muscles;
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j].CalculateMappedVelocity();
				}
			}
			if (freezeFlag)
			{
				OnFreezeFlag();
			}
		}

		private void MoveToTarget()
		{
			if (Singleton<PuppetMasterSettings>.instance == null || (Singleton<PuppetMasterSettings>.instance != null && Singleton<PuppetMasterSettings>.instance.UpdateMoveToTarget(this)))
			{
				Muscle[] array = muscles;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].MoveToTarget();
				}
			}
		}

		private void Read()
		{
			BehaviourBase[] array2;
			Muscle[] array;
			if (teleport)
			{
				GameObject gameObject = new GameObject();
				gameObject.transform.position = ((base.transform.parent != null) ? base.transform.parent.position : Vector3.zero);
				gameObject.transform.rotation = ((base.transform.parent != null) ? base.transform.parent.rotation : Quaternion.identity);
				Transform parent = base.transform.parent;
				Transform parent2 = targetRoot.parent;
				base.transform.parent = gameObject.transform;
				targetRoot.parent = gameObject.transform;
				Vector3 position = base.transform.parent.position;
				Quaternion quaternion = QuaTools.FromToRotation(targetRoot.rotation, teleportRotation);
				base.transform.parent.rotation = quaternion * base.transform.parent.rotation;
				Vector3 vector = teleportPosition - targetRoot.position;
				base.transform.parent.position += vector;
				base.transform.parent = parent;
				targetRoot.parent = parent2;
				UnityEngine.Object.Destroy(gameObject);
				targetMappedPositions[0] = position + quaternion * (targetMappedPositions[0] - position) + vector;
				targetSampledPositions[0] = position + quaternion * (targetSampledPositions[0] - position) + vector;
				targetMappedRotations[0] = quaternion * targetMappedRotations[0];
				targetSampledRotations[0] = quaternion * targetSampledRotations[0];
				if (teleportMoveToTarget)
				{
					array = muscles;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].MoveToTarget();
					}
				}
				array = muscles;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].ClearVelocities();
				}
				array2 = behaviours;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].OnTeleport(quaternion, vector, position, teleportMoveToTarget);
				}
				teleport = false;
			}
			if (OnRead != null)
			{
				OnRead();
			}
			array2 = behaviours;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].OnRead();
			}
			if (!isAlive)
			{
				return;
			}
			array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Read();
			}
			if (isAlive && updateJointAnchors)
			{
				for (int j = 0; j < muscles.Length; j++)
				{
					muscles[j].UpdateAnchor(supportTranslationAnimation);
				}
			}
		}

		private void FixTargetTransforms()
		{
			if (!isAlive)
			{
				return;
			}
			if (OnFixTransforms != null)
			{
				OnFixTransforms();
			}
			BehaviourBase[] array = behaviours;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].OnFixTransforms();
			}
			if ((!fixTargetTransforms && !hasProp) || !isActive)
			{
				return;
			}
			mappingWeight = Mathf.Clamp(mappingWeight, 0f, 1f);
			if (mappingWeight * mappingBlend <= 0f)
			{
				return;
			}
			for (int j = 0; j < muscles.Length; j++)
			{
				if (fixTargetTransforms || muscles[j].props.group == Muscle.Group.Prop)
				{
					muscles[j].FixTargetTransforms();
				}
			}
		}

		private void VisualizeTargetPose()
		{
			if (!visualizeTargetPose || !Application.isEditor || !isActive)
			{
				return;
			}
			Muscle[] array = muscles;
			foreach (Muscle muscle in array)
			{
				if (!(muscle.joint.connectedBody != null) || !(muscle.connectedBodyTarget != null))
				{
					continue;
				}
				UnityEngine.Debug.DrawLine(muscle.target.position, muscle.connectedBodyTarget.position, Color.cyan);
				bool flag = true;
				Muscle[] array2 = muscles;
				foreach (Muscle muscle2 in array2)
				{
					if (muscle != muscle2 && muscle2.joint.connectedBody == muscle.rigidbody)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					VisualizeHierarchy(muscle.target, Color.cyan);
				}
			}
		}

		private void VisualizeHierarchy(Transform t, Color color)
		{
			for (int i = 0; i < t.childCount; i++)
			{
				UnityEngine.Debug.DrawLine(t.position, t.GetChild(i).position, color);
				VisualizeHierarchy(t.GetChild(i), color);
			}
		}

		private void SetInternalCollisions(bool collide)
		{
			if (internalCollisionsEnabled == collide)
			{
				return;
			}
			for (int i = 0; i < muscles.Length; i++)
			{
				for (int j = i; j < muscles.Length; j++)
				{
					if (i != j)
					{
						muscles[i].IgnoreCollisions(muscles[j], !collide);
					}
				}
			}
			internalCollisionsEnabled = collide;
		}

		private void SetAngularLimits(bool limited)
		{
			if (angularLimitsEnabled != limited)
			{
				for (int i = 0; i < muscles.Length; i++)
				{
					muscles[i].IgnoreAngularLimits(!limited);
				}
				angularLimitsEnabled = limited;
			}
		}

		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, Muscle.Props muscleProps = null, bool forceTreeHierarchy = false, bool forceLayers = true)
		{
			if (!CheckIfInitiated())
			{
				return;
			}
			if (!initiated)
			{
				UnityEngine.Debug.LogWarning("PuppetMaster has not been initiated.", base.transform);
				return;
			}
			if (ContainsJoint(joint))
			{
				UnityEngine.Debug.LogWarning("Joint " + joint.name + " is already used by a Muscle", base.transform);
				return;
			}
			if (target == null)
			{
				UnityEngine.Debug.LogWarning("AddMuscle was called with a null 'target' reference.", base.transform);
				return;
			}
			if (connectTo == joint.GetComponent<Rigidbody>())
			{
				UnityEngine.Debug.LogWarning("ConnectTo is the joint's own Rigidbody, can not add muscle.", base.transform);
				return;
			}
			if (!isActive)
			{
				UnityEngine.Debug.LogWarning("Adding muscles to inactive PuppetMasters is not currently supported.", base.transform);
				return;
			}
			if (muscleProps == null)
			{
				muscleProps = new Muscle.Props();
			}
			Muscle muscle = new Muscle();
			muscle.props = muscleProps;
			muscle.joint = joint;
			muscle.target = target;
			muscle.joint.transform.parent = (((hierarchyIsFlat || connectTo == null) && !forceTreeHierarchy) ? base.transform : connectTo.transform);
			if (forceLayers)
			{
				joint.gameObject.layer = base.gameObject.layer;
				target.gameObject.layer = targetRoot.gameObject.layer;
			}
			if (connectTo != null)
			{
				muscle.target.parent = targetParent;
				Vector3 position = GetMuscle(connectTo).transform.InverseTransformPoint(muscle.target.position);
				Quaternion quaternion = Quaternion.Inverse(GetMuscle(connectTo).transform.rotation) * muscle.target.rotation;
				joint.transform.position = connectTo.transform.TransformPoint(position);
				joint.transform.rotation = connectTo.transform.rotation * quaternion;
				joint.connectedBody = connectTo;
			}
			muscle.Initiate(muscles);
			if (connectTo != null)
			{
				muscle.rigidbody.velocity = connectTo.velocity;
				muscle.rigidbody.angularVelocity = connectTo.angularVelocity;
			}
			if (!internalCollisions)
			{
				for (int i = 0; i < muscles.Length; i++)
				{
					muscle.IgnoreCollisions(muscles[i], ignore: true);
				}
			}
			Array.Resize(ref muscles, muscles.Length + 1);
			muscles[muscles.Length - 1] = muscle;
			muscle.IgnoreAngularLimits(!angularLimits);
			if (behaviours.Length != 0)
			{
				muscle.broadcaster = muscle.joint.gameObject.AddComponent<MuscleCollisionBroadcaster>();
				muscle.broadcaster.puppetMaster = this;
				muscle.broadcaster.muscleIndex = muscles.Length - 1;
			}
			muscle.jointBreakBroadcaster = muscle.joint.gameObject.AddComponent<JointBreakBroadcaster>();
			muscle.jointBreakBroadcaster.puppetMaster = this;
			muscle.jointBreakBroadcaster.muscleIndex = muscles.Length - 1;
			UpdateHierarchies();
			CheckMassVariation(100f, log: true);
			BehaviourBase[] array = behaviours;
			for (int j = 0; j < array.Length; j++)
			{
				array[j].OnMuscleAdded(muscle);
			}
		}

		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
			if (!CheckIfInitiated())
			{
				return;
			}
			if (joint == null)
			{
				UnityEngine.Debug.LogWarning("RemoveMuscleRecursive was called with a null 'joint' reference.", base.transform);
				return;
			}
			if (!ContainsJoint(joint))
			{
				UnityEngine.Debug.LogWarning("No Muscle with the specified joint was found, can not remove muscle.", base.transform);
				return;
			}
			int muscleIndex = GetMuscleIndex(joint);
			Muscle[] array = new Muscle[muscles.Length - (muscles[muscleIndex].childIndexes.Length + 1)];
			int num = 0;
			for (int i = 0; i < muscles.Length; i++)
			{
				if (i != muscleIndex && !muscles[muscleIndex].childFlags[i])
				{
					array[num] = muscles[i];
					num++;
					continue;
				}
				if (muscles[i].broadcaster != null)
				{
					muscles[i].broadcaster.enabled = false;
					UnityEngine.Object.Destroy(muscles[i].broadcaster);
				}
				if (muscles[i].jointBreakBroadcaster != null)
				{
					muscles[i].jointBreakBroadcaster.enabled = false;
					UnityEngine.Object.Destroy(muscles[i].jointBreakBroadcaster);
				}
			}
			switch (removeMode)
			{
			case MuscleRemoveMode.Sever:
			{
				DisconnectJoint(muscles[muscleIndex].joint);
				for (int k = 0; k < muscles[muscleIndex].childIndexes.Length; k++)
				{
					KillJoint(muscles[muscles[muscleIndex].childIndexes[k]].joint);
				}
				break;
			}
			case MuscleRemoveMode.Explode:
			{
				DisconnectJoint(muscles[muscleIndex].joint);
				for (int l = 0; l < muscles[muscleIndex].childIndexes.Length; l++)
				{
					DisconnectJoint(muscles[muscles[muscleIndex].childIndexes[l]].joint);
				}
				break;
			}
			case MuscleRemoveMode.Numb:
			{
				KillJoint(muscles[muscleIndex].joint);
				for (int j = 0; j < muscles[muscleIndex].childIndexes.Length; j++)
				{
					KillJoint(muscles[muscles[muscleIndex].childIndexes[j]].joint);
				}
				break;
			}
			}
			muscles[muscleIndex].transform.parent = null;
			for (int m = 0; m < muscles[muscleIndex].childIndexes.Length; m++)
			{
				if (removeMode == MuscleRemoveMode.Explode || muscles[muscles[muscleIndex].childIndexes[m]].transform.parent == base.transform)
				{
					muscles[muscles[muscleIndex].childIndexes[m]].transform.parent = null;
				}
			}
			BehaviourBase[] array2 = behaviours;
			foreach (BehaviourBase behaviourBase in array2)
			{
				behaviourBase.OnMuscleRemoved(muscles[muscleIndex]);
				for (int num2 = 0; num2 < muscles[muscleIndex].childIndexes.Length; num2++)
				{
					Muscle m2 = muscles[muscles[muscleIndex].childIndexes[num2]];
					behaviourBase.OnMuscleRemoved(m2);
				}
			}
			if (attachTarget)
			{
				muscles[muscleIndex].target.parent = muscles[muscleIndex].transform;
				muscles[muscleIndex].target.position = muscles[muscleIndex].transform.position;
				muscles[muscleIndex].target.rotation = muscles[muscleIndex].transform.rotation * muscles[muscleIndex].targetRotationRelative;
				for (int num3 = 0; num3 < muscles[muscleIndex].childIndexes.Length; num3++)
				{
					Muscle muscle = muscles[muscles[muscleIndex].childIndexes[num3]];
					muscle.target.parent = muscle.transform;
					muscle.target.position = muscle.transform.position;
					muscle.target.rotation = muscle.transform.rotation;
				}
			}
			if (blockTargetAnimation)
			{
				muscles[muscleIndex].target.gameObject.AddComponent<AnimationBlocker>();
				for (int num4 = 0; num4 < muscles[muscleIndex].childIndexes.Length; num4++)
				{
					muscles[muscles[muscleIndex].childIndexes[num4]].target.gameObject.AddComponent<AnimationBlocker>();
				}
			}
			if (OnMuscleRemoved != null)
			{
				OnMuscleRemoved(muscles[muscleIndex]);
			}
			for (int num5 = 0; num5 < muscles[muscleIndex].childIndexes.Length; num5++)
			{
				Muscle muscle2 = muscles[muscles[muscleIndex].childIndexes[num5]];
				if (OnMuscleRemoved != null)
				{
					OnMuscleRemoved(muscle2);
				}
			}
			if (!internalCollisionsEnabled)
			{
				Muscle[] array3 = array;
				for (int n = 0; n < array3.Length; n++)
				{
					Collider[] colliders = array3[n].colliders;
					foreach (Collider collider in colliders)
					{
						Collider[] colliders2 = muscles[muscleIndex].colliders;
						foreach (Collider collider2 in colliders2)
						{
							Physics.IgnoreCollision(collider, collider2, ignore: false);
						}
						for (int num8 = 0; num8 < muscles[muscleIndex].childIndexes.Length; num8++)
						{
							colliders2 = muscles[num8].colliders;
							foreach (Collider collider3 in colliders2)
							{
								Physics.IgnoreCollision(collider, collider3, ignore: false);
							}
						}
					}
				}
			}
			muscles = array;
			UpdateHierarchies();
		}

		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint)
		{
			if (CheckIfInitiated())
			{
				UnityEngine.Debug.LogWarning("@todo", base.transform);
			}
		}

		public void SetMuscles(Muscle[] newMuscles)
		{
			if (CheckIfInitiated())
			{
				UnityEngine.Debug.LogWarning("@todo", base.transform);
			}
		}

		public void DisableMuscleRecursive(ConfigurableJoint joint)
		{
			if (CheckIfInitiated())
			{
				UnityEngine.Debug.LogWarning("@todo", base.transform);
			}
		}

		public void EnableMuscleRecursive(ConfigurableJoint joint)
		{
			if (CheckIfInitiated())
			{
				UnityEngine.Debug.LogWarning("@todo", base.transform);
			}
		}

		[ContextMenu("Flatten Muscle Hierarchy")]
		public void FlattenHierarchy()
		{
			Muscle[] array = muscles;
			foreach (Muscle muscle in array)
			{
				if (muscle.joint != null)
				{
					muscle.joint.transform.parent = base.transform;
				}
			}
			hierarchyIsFlat = true;
		}

		[ContextMenu("Tree Muscle Hierarchy")]
		public void TreeHierarchy()
		{
			Muscle[] array = muscles;
			foreach (Muscle muscle in array)
			{
				if (muscle.joint != null)
				{
					muscle.joint.transform.parent = ((muscle.joint.connectedBody != null) ? muscle.joint.connectedBody.transform : base.transform);
				}
			}
			hierarchyIsFlat = false;
		}

		[ContextMenu("Fix Muscle Positions")]
		public void FixMusclePositions()
		{
			Muscle[] array = muscles;
			foreach (Muscle muscle in array)
			{
				if (muscle.joint != null && muscle.target != null)
				{
					muscle.joint.transform.position = muscle.target.position;
				}
			}
		}

		private void AddIndexesRecursive(int index, ref int[] indexes)
		{
			int num = indexes.Length;
			Array.Resize(ref indexes, indexes.Length + 1 + muscles[index].childIndexes.Length);
			indexes[num] = index;
			if (muscles[index].childIndexes.Length != 0)
			{
				for (int i = 0; i < muscles[index].childIndexes.Length; i++)
				{
					AddIndexesRecursive(muscles[index].childIndexes[i], ref indexes);
				}
			}
		}

		private bool HierarchyIsFlat()
		{
			Muscle[] array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].joint.transform.parent != base.transform)
				{
					return false;
				}
			}
			return true;
		}

		private void DisconnectJoint(ConfigurableJoint joint)
		{
			joint.connectedBody = null;
			KillJoint(joint);
			joint.xMotion = ConfigurableJointMotion.Free;
			joint.yMotion = ConfigurableJointMotion.Free;
			joint.zMotion = ConfigurableJointMotion.Free;
			joint.angularXMotion = ConfigurableJointMotion.Free;
			joint.angularYMotion = ConfigurableJointMotion.Free;
			joint.angularZMotion = ConfigurableJointMotion.Free;
		}

		private void KillJoint(ConfigurableJoint joint)
		{
			joint.targetRotation = Quaternion.identity;
			JointDrive slerpDrive = default(JointDrive);
			slerpDrive.positionSpring = 0f;
			slerpDrive.positionDamper = 0f;
			joint.slerpDrive = slerpDrive;
		}

		public void DisableImmediately()
		{
			mappingBlend = 0f;
			isSwitchingMode = false;
			mode = Mode.Disabled;
			activeMode = mode;
			lastMode = mode;
			Muscle[] array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].rigidbody.gameObject.SetActive(value: false);
			}
		}

		protected virtual void SwitchModes()
		{
			if (!initiated)
			{
				return;
			}
			if (isKilling)
			{
				mode = Mode.Active;
			}
			if (!isAlive)
			{
				mode = Mode.Active;
			}
			BehaviourBase[] array = behaviours;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].forceActive)
				{
					mode = Mode.Active;
					break;
				}
			}
			if (mode == lastMode || isSwitchingMode || (isKilling && mode != 0) || (state != 0 && mode != 0))
			{
				return;
			}
			isSwitchingMode = true;
			if (lastMode == Mode.Disabled)
			{
				if (mode == Mode.Kinematic)
				{
					DisabledToKinematic();
				}
				else if (mode == Mode.Active)
				{
					StartCoroutine(DisabledToActive());
				}
			}
			else if (lastMode == Mode.Kinematic)
			{
				if (mode == Mode.Disabled)
				{
					KinematicToDisabled();
				}
				else if (mode == Mode.Active)
				{
					StartCoroutine(KinematicToActive());
				}
			}
			else if (lastMode == Mode.Active)
			{
				if (mode == Mode.Disabled)
				{
					StartCoroutine(ActiveToDisabled());
				}
				else if (mode == Mode.Kinematic)
				{
					StartCoroutine(ActiveToKinematic());
				}
			}
			lastMode = mode;
		}

		private void DisabledToKinematic()
		{
			Muscle[] array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Reset();
			}
			array = muscles;
			foreach (Muscle obj in array)
			{
				obj.rigidbody.gameObject.SetActive(value: true);
				obj.rigidbody.isKinematic = true;
			}
			internalCollisionsEnabled = true;
			SetInternalCollisions(internalCollisions);
			array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].MoveToTarget();
			}
			activeMode = Mode.Kinematic;
			isSwitchingMode = false;
		}

		private IEnumerator DisabledToActive()
		{
			Muscle[] array = muscles;
			foreach (Muscle muscle in array)
			{
				if (!muscle.rigidbody.gameObject.activeInHierarchy)
				{
					muscle.Reset();
				}
			}
			array = muscles;
			foreach (Muscle muscle2 in array)
			{
				muscle2.rigidbody.gameObject.SetActive(value: true);
				muscle2.rigidbody.isKinematic = false;
				muscle2.rigidbody.WakeUp();
				muscle2.rigidbody.velocity = muscle2.mappedVelocity;
				muscle2.rigidbody.angularVelocity = muscle2.mappedAngularVelocity;
			}
			internalCollisionsEnabled = true;
			SetInternalCollisions(internalCollisions);
			Read();
			array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].MoveToTarget();
			}
			UpdateInternalCollisions();
			while (mappingBlend < 1f)
			{
				mappingBlend = Mathf.Clamp(mappingBlend + Time.deltaTime / blendTime, 0f, 1f);
				yield return null;
			}
			activeMode = Mode.Active;
			isSwitchingMode = false;
		}

		private void KinematicToDisabled()
		{
			Muscle[] array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].rigidbody.gameObject.SetActive(value: false);
			}
			activeMode = Mode.Disabled;
			isSwitchingMode = false;
		}

		private IEnumerator KinematicToActive()
		{
			Muscle[] array = muscles;
			foreach (Muscle muscle in array)
			{
				muscle.rigidbody.isKinematic = false;
				muscle.rigidbody.WakeUp();
				muscle.rigidbody.velocity = muscle.mappedVelocity;
				muscle.rigidbody.angularVelocity = muscle.mappedAngularVelocity;
			}
			Read();
			array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].MoveToTarget();
			}
			UpdateInternalCollisions();
			while (mappingBlend < 1f)
			{
				mappingBlend = Mathf.Min(mappingBlend + Time.deltaTime / blendTime, 1f);
				yield return null;
			}
			activeMode = Mode.Active;
			isSwitchingMode = false;
		}

		private IEnumerator ActiveToDisabled()
		{
			while (mappingBlend > 0f)
			{
				mappingBlend = Mathf.Max(mappingBlend - Time.deltaTime / blendTime, 0f);
				yield return null;
			}
			Muscle[] array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].rigidbody.gameObject.SetActive(value: false);
			}
			activeMode = Mode.Disabled;
			isSwitchingMode = false;
		}

		private IEnumerator ActiveToKinematic()
		{
			while (mappingBlend > 0f)
			{
				mappingBlend = Mathf.Max(mappingBlend - Time.deltaTime / blendTime, 0f);
				yield return null;
			}
			Muscle[] array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].rigidbody.isKinematic = true;
			}
			array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].MoveToTarget();
			}
			activeMode = Mode.Kinematic;
			isSwitchingMode = false;
		}

		private void UpdateInternalCollisions()
		{
			if (internalCollisions)
			{
				return;
			}
			for (int i = 0; i < muscles.Length; i++)
			{
				for (int j = i; j < muscles.Length; j++)
				{
					if (i != j)
					{
						muscles[i].IgnoreCollisions(muscles[j], ignore: true);
					}
				}
			}
		}

		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
			if (!CheckIfInitiated())
			{
				return;
			}
			Muscle[] array = muscles;
			foreach (Muscle muscle in array)
			{
				if (muscle.props.group == group)
				{
					muscle.props.muscleWeight = muscleWeight;
					muscle.props.pinWeight = pinWeight;
					muscle.props.mappingWeight = mappingWeight;
					muscle.props.muscleDamper = muscleDamper;
				}
			}
		}

		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
			if (CheckIfInitiated())
			{
				int muscleIndex = GetMuscleIndex(target);
				if (muscleIndex != -1)
				{
					SetMuscleWeights(muscleIndex, muscleWeight, pinWeight, mappingWeight, muscleDamper);
				}
			}
		}

		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
			if (CheckIfInitiated())
			{
				int muscleIndex = GetMuscleIndex(humanBodyBone);
				if (muscleIndex != -1)
				{
					SetMuscleWeights(muscleIndex, muscleWeight, pinWeight, mappingWeight, muscleDamper);
				}
			}
		}

		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
			if (!CheckIfInitiated())
			{
				return;
			}
			for (int i = 0; i < muscles.Length; i++)
			{
				if (muscles[i].target == target)
				{
					SetMuscleWeightsRecursive(i, muscleWeight, pinWeight, mappingWeight, muscleDamper);
					break;
				}
			}
		}

		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
			if (CheckIfInitiated())
			{
				SetMuscleWeights(muscleIndex, muscleWeight, pinWeight, mappingWeight, muscleDamper);
				for (int i = 0; i < muscles[muscleIndex].childIndexes.Length; i++)
				{
					int muscleIndex2 = muscles[muscleIndex].childIndexes[i];
					SetMuscleWeights(muscleIndex2, muscleWeight, pinWeight, mappingWeight, muscleDamper);
				}
			}
		}

		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
			if (CheckIfInitiated())
			{
				int muscleIndex = GetMuscleIndex(humanBodyBone);
				if (muscleIndex != -1)
				{
					SetMuscleWeightsRecursive(muscleIndex, muscleWeight, pinWeight, mappingWeight, muscleDamper);
				}
			}
		}

		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
			if (CheckIfInitiated())
			{
				if ((float)muscleIndex < 0f || muscleIndex >= muscles.Length)
				{
					UnityEngine.Debug.LogWarning("Muscle index out of range (" + muscleIndex + ").", base.transform);
					return;
				}
				muscles[muscleIndex].props.muscleWeight = muscleWeight;
				muscles[muscleIndex].props.pinWeight = pinWeight;
				muscles[muscleIndex].props.mappingWeight = mappingWeight;
				muscles[muscleIndex].props.muscleDamper = muscleDamper;
			}
		}

		public Muscle GetMuscle(Transform target)
		{
			int muscleIndex = GetMuscleIndex(target);
			if (muscleIndex == -1)
			{
				return null;
			}
			return muscles[muscleIndex];
		}

		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			int muscleIndex = GetMuscleIndex(rigidbody);
			if (muscleIndex == -1)
			{
				return null;
			}
			return muscles[muscleIndex];
		}

		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			int muscleIndex = GetMuscleIndex(joint);
			if (muscleIndex == -1)
			{
				return null;
			}
			return muscles[muscleIndex];
		}

		public bool ContainsJoint(ConfigurableJoint joint)
		{
			if (!CheckIfInitiated())
			{
				return false;
			}
			Muscle[] array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].joint == joint)
				{
					return true;
				}
			}
			return false;
		}

		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			if (!CheckIfInitiated())
			{
				return -1;
			}
			if (targetAnimator == null)
			{
				UnityEngine.Debug.LogWarning("PuppetMaster 'Target Root' has no Animator component on it nor on it's children.", base.transform);
				return -1;
			}
			if (!targetAnimator.isHuman)
			{
				UnityEngine.Debug.LogWarning("PuppetMaster target's Animator does not belong to a Humanoid, can hot get human muscle index.", base.transform);
				return -1;
			}
			Transform boneTransform = targetAnimator.GetBoneTransform(humanBodyBone);
			if (boneTransform == null)
			{
				UnityEngine.Debug.LogWarning("PuppetMaster target's Avatar does not contain a bone Transform for " + humanBodyBone, base.transform);
				return -1;
			}
			return GetMuscleIndex(boneTransform);
		}

		public int GetMuscleIndex(Transform target)
		{
			if (!CheckIfInitiated())
			{
				return -1;
			}
			if (target == null)
			{
				UnityEngine.Debug.LogWarning("Target is null, can not get muscle index.", base.transform);
				return -1;
			}
			for (int i = 0; i < muscles.Length; i++)
			{
				if (muscles[i].target == target)
				{
					return i;
				}
			}
			UnityEngine.Debug.LogWarning("No muscle with target " + target.name + "found on the PuppetMaster.", base.transform);
			return -1;
		}

		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			if (!CheckIfInitiated())
			{
				return -1;
			}
			if (rigidbody == null)
			{
				UnityEngine.Debug.LogWarning("Rigidbody is null, can not get muscle index.", base.transform);
				return -1;
			}
			for (int i = 0; i < muscles.Length; i++)
			{
				if (muscles[i].rigidbody == rigidbody)
				{
					return i;
				}
			}
			UnityEngine.Debug.LogWarning("No muscle with Rigidbody " + rigidbody.name + "found on the PuppetMaster.", base.transform);
			return -1;
		}

		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			if (!CheckIfInitiated())
			{
				return -1;
			}
			if (joint == null)
			{
				UnityEngine.Debug.LogWarning("Joint is null, can not get muscle index.", base.transform);
				return -1;
			}
			for (int i = 0; i < muscles.Length; i++)
			{
				if (muscles[i].joint == joint)
				{
					return i;
				}
			}
			UnityEngine.Debug.LogWarning("No muscle with Joint " + joint.name + "found on the PuppetMaster.", base.transform);
			return -1;
		}

		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			if (ragdoll != target)
			{
				PuppetMaster puppetMaster = ragdoll.gameObject.AddComponent<PuppetMaster>();
				puppetMaster.SetUpTo(target, characterControllerLayer, ragdollLayer);
				return puppetMaster;
			}
			return SetUp(ragdoll, characterControllerLayer, ragdollLayer);
		}

		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			PuppetMaster puppetMaster = UnityEngine.Object.Instantiate(target.gameObject, target.position, target.rotation).transform.gameObject.AddComponent<PuppetMaster>();
			puppetMaster.SetUpTo(target, characterControllerLayer, ragdollLayer);
			RemoveRagdollComponents(target, characterControllerLayer);
			return puppetMaster;
		}

		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
			if (setUpTo == null)
			{
				UnityEngine.Debug.LogWarning("SetUpTo is null. Can not set the PuppetMaster up to a null Transform.", base.transform);
				return;
			}
			if (setUpTo == base.transform)
			{
				setUpTo = UnityEngine.Object.Instantiate(setUpTo.gameObject, setUpTo.position, setUpTo.rotation).transform;
				setUpTo.name = base.name;
				RemoveRagdollComponents(setUpTo, characterControllerLayer);
			}
			RemoveUnnecessaryBones();
			Component[] componentsInChildren = GetComponentsInChildren<Component>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (!(componentsInChildren[i] is PuppetMaster) && !(componentsInChildren[i] is Transform) && !(componentsInChildren[i] is Rigidbody) && !(componentsInChildren[i] is BoxCollider) && !(componentsInChildren[i] is CapsuleCollider) && !(componentsInChildren[i] is SphereCollider) && !(componentsInChildren[i] is MeshCollider) && !(componentsInChildren[i] is Joint) && !(componentsInChildren[i] is Animator))
				{
					UnityEngine.Object.DestroyImmediate(componentsInChildren[i]);
				}
			}
			Animator[] componentsInChildren2 = GetComponentsInChildren<Animator>();
			for (int j = 0; j < componentsInChildren2.Length; j++)
			{
				UnityEngine.Object.DestroyImmediate(componentsInChildren2[j]);
			}
			componentsInChildren = base.transform.GetComponents<Component>();
			for (int k = 0; k < componentsInChildren.Length; k++)
			{
				if (!(componentsInChildren[k] is PuppetMaster) && !(componentsInChildren[k] is Transform))
				{
					UnityEngine.Object.DestroyImmediate(componentsInChildren[k]);
				}
			}
			Rigidbody[] componentsInChildren3 = base.transform.GetComponentsInChildren<Rigidbody>();
			foreach (Rigidbody rigidbody in componentsInChildren3)
			{
				if (rigidbody.transform != base.transform && rigidbody.GetComponent<ConfigurableJoint>() == null)
				{
					rigidbody.gameObject.AddComponent<ConfigurableJoint>();
				}
			}
			targetRoot = setUpTo;
			SetUpMuscles(setUpTo);
			base.name = "PuppetMaster";
			Transform transform = ((setUpTo.parent == null || setUpTo.parent != base.transform.parent || setUpTo.parent.name != setUpTo.name + " Root") ? new GameObject(setUpTo.name + " Root").transform : setUpTo.parent);
			transform.parent = base.transform.parent;
			Transform transform2 = new GameObject("Behaviours").transform;
			Comments comments = transform2.gameObject.GetComponent<Comments>();
			if (comments == null)
			{
				comments = transform2.gameObject.AddComponent<Comments>();
			}
			comments.text = "All Puppet Behaviours should be parented to this GameObject, the PuppetMaster will automatically find them from here. All Puppet Behaviours have been designed so that they could be simply copied from one character to another without changing any references. It is important because they contain a lot of parameters and would be otherwise tedious to set up and tweak.";
			transform.position = setUpTo.position;
			transform.rotation = setUpTo.rotation;
			transform2.position = setUpTo.position;
			transform2.rotation = setUpTo.rotation;
			base.transform.position = setUpTo.position;
			base.transform.rotation = setUpTo.rotation;
			transform2.parent = transform;
			base.transform.parent = transform;
			setUpTo.parent = transform;
			targetRoot.gameObject.layer = characterControllerLayer;
			base.gameObject.layer = ragdollLayer;
			Muscle[] array = muscles;
			for (int l = 0; l < array.Length; l++)
			{
				array[l].joint.gameObject.layer = ragdollLayer;
			}
			Physics.IgnoreLayerCollision(characterControllerLayer, ragdollLayer);
		}

		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
			if (target == null)
			{
				return;
			}
			Rigidbody[] componentsInChildren = target.GetComponentsInChildren<Rigidbody>();
			Cloth[] componentsInChildren2 = target.GetComponentsInChildren<Cloth>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (!(componentsInChildren[i].gameObject != target.gameObject))
				{
					continue;
				}
				Joint component = componentsInChildren[i].GetComponent<Joint>();
				Collider component2 = componentsInChildren[i].GetComponent<Collider>();
				if (component != null)
				{
					UnityEngine.Object.DestroyImmediate(component);
				}
				if (component2 != null)
				{
					if (!IsClothCollider(component2, componentsInChildren2))
					{
						UnityEngine.Object.DestroyImmediate(component2);
					}
					else
					{
						component2.gameObject.layer = characterControllerLayer;
					}
				}
				UnityEngine.Object.DestroyImmediate(componentsInChildren[i]);
			}
			Collider[] componentsInChildren3 = target.GetComponentsInChildren<Collider>();
			for (int j = 0; j < componentsInChildren3.Length; j++)
			{
				if (componentsInChildren3[j].transform != target && !IsClothCollider(componentsInChildren3[j], componentsInChildren2))
				{
					UnityEngine.Object.DestroyImmediate(componentsInChildren3[j]);
				}
			}
			PuppetMaster component3 = target.GetComponent<PuppetMaster>();
			if (component3 != null)
			{
				UnityEngine.Object.DestroyImmediate(component3);
			}
		}

		private void SetUpMuscles(Transform setUpTo)
		{
			ConfigurableJoint[] componentsInChildren = base.transform.GetComponentsInChildren<ConfigurableJoint>();
			if (componentsInChildren.Length == 0)
			{
				UnityEngine.Debug.LogWarning("No ConfigurableJoints found, can not build PuppetMaster. Please create ConfigurableJoints to connect the ragdoll bones together.", base.transform);
				return;
			}
			Animator componentInChildren = targetRoot.GetComponentInChildren<Animator>();
			Transform[] componentsInChildren2 = setUpTo.GetComponentsInChildren<Transform>();
			muscles = new Muscle[componentsInChildren.Length];
			int num = -1;
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				muscles[i] = new Muscle();
				muscles[i].joint = componentsInChildren[i];
				muscles[i].name = componentsInChildren[i].name;
				muscles[i].props = new Muscle.Props(1f, 1f, 1f, 1f, muscles[i].joint.connectedBody == null);
				if (muscles[i].joint.connectedBody == null && num == -1)
				{
					num = i;
				}
				Transform[] array = componentsInChildren2;
				foreach (Transform transform in array)
				{
					if (!(transform.name == componentsInChildren[i].name))
					{
						continue;
					}
					muscles[i].target = transform;
					if (componentInChildren != null)
					{
						muscles[i].props.group = FindGroup(componentInChildren, muscles[i].target);
						if (muscles[i].props.group == Muscle.Group.Hips || muscles[i].props.group == Muscle.Group.Leg || muscles[i].props.group == Muscle.Group.Foot)
						{
							muscles[i].props.mapPosition = true;
						}
					}
					break;
				}
			}
			if (num != 0)
			{
				Muscle muscle = muscles[0];
				Muscle muscle2 = muscles[num];
				muscles[num] = muscle;
				muscles[0] = muscle2;
			}
			bool flag = true;
			Muscle[] array2 = muscles;
			foreach (Muscle muscle3 in array2)
			{
				if (muscle3.target == null)
				{
					UnityEngine.Debug.LogWarning("No target Transform found for PuppetMaster muscle " + muscle3.joint.name + ". Please assign manually.", base.transform);
				}
				if (muscle3.props.group != muscles[0].props.group)
				{
					flag = false;
				}
			}
			if (flag)
			{
				UnityEngine.Debug.LogWarning("Muscle groups need to be assigned in the PuppetMaster!", base.transform);
			}
		}

		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			if (!animator.isHuman)
			{
				return Muscle.Group.Hips;
			}
			if (t == animator.GetBoneTransform(HumanBodyBones.Chest))
			{
				return Muscle.Group.Spine;
			}
			if (t == animator.GetBoneTransform(HumanBodyBones.Head))
			{
				return Muscle.Group.Head;
			}
			if (t == animator.GetBoneTransform(HumanBodyBones.Hips))
			{
				return Muscle.Group.Hips;
			}
			if (t == animator.GetBoneTransform(HumanBodyBones.LeftFoot))
			{
				return Muscle.Group.Foot;
			}
			if (t == animator.GetBoneTransform(HumanBodyBones.LeftHand))
			{
				return Muscle.Group.Hand;
			}
			if (t == animator.GetBoneTransform(HumanBodyBones.LeftLowerArm))
			{
				return Muscle.Group.Arm;
			}
			if (t == animator.GetBoneTransform(HumanBodyBones.LeftLowerLeg))
			{
				return Muscle.Group.Leg;
			}
			if (t == animator.GetBoneTransform(HumanBodyBones.LeftUpperArm))
			{
				return Muscle.Group.Arm;
			}
			if (t == animator.GetBoneTransform(HumanBodyBones.LeftUpperLeg))
			{
				return Muscle.Group.Leg;
			}
			if (t == animator.GetBoneTransform(HumanBodyBones.RightFoot))
			{
				return Muscle.Group.Foot;
			}
			if (t == animator.GetBoneTransform(HumanBodyBones.RightHand))
			{
				return Muscle.Group.Hand;
			}
			if (t == animator.GetBoneTransform(HumanBodyBones.RightLowerArm))
			{
				return Muscle.Group.Arm;
			}
			if (t == animator.GetBoneTransform(HumanBodyBones.RightLowerLeg))
			{
				return Muscle.Group.Leg;
			}
			if (t == animator.GetBoneTransform(HumanBodyBones.RightUpperArm))
			{
				return Muscle.Group.Arm;
			}
			if (t == animator.GetBoneTransform(HumanBodyBones.RightUpperLeg))
			{
				return Muscle.Group.Leg;
			}
			return Muscle.Group.Spine;
		}

		private void RemoveUnnecessaryBones()
		{
			Transform[] componentsInChildren = GetComponentsInChildren<Transform>();
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				bool flag = false;
				if (componentsInChildren[i].GetComponent<Rigidbody>() != null || componentsInChildren[i].GetComponent<ConfigurableJoint>() != null)
				{
					flag = true;
				}
				if (componentsInChildren[i].GetComponent<Collider>() != null && componentsInChildren[i].GetComponent<Rigidbody>() == null)
				{
					flag = true;
				}
				if (componentsInChildren[i].GetComponent<CharacterController>() != null)
				{
					flag = false;
				}
				if (!flag)
				{
					Transform[] array = new Transform[componentsInChildren[i].childCount];
					for (int j = 0; j < array.Length; j++)
					{
						array[j] = componentsInChildren[i].GetChild(j);
					}
					for (int k = 0; k < array.Length; k++)
					{
						array[k].parent = componentsInChildren[i].parent;
					}
					UnityEngine.Object.DestroyImmediate(componentsInChildren[i].gameObject);
				}
			}
		}

		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			if (cloths == null)
			{
				return false;
			}
			foreach (Cloth cloth in cloths)
			{
				if (cloth == null)
				{
					return false;
				}
				CapsuleCollider[] capsuleColliders = cloth.capsuleColliders;
				foreach (CapsuleCollider capsuleCollider in capsuleColliders)
				{
					if (capsuleCollider != null && capsuleCollider.gameObject == collider.gameObject)
					{
						return true;
					}
				}
				ClothSphereColliderPair[] sphereColliders = cloth.sphereColliders;
				for (int j = 0; j < sphereColliders.Length; j++)
				{
					ClothSphereColliderPair clothSphereColliderPair = sphereColliders[j];
					if (clothSphereColliderPair.first != null && clothSphereColliderPair.first.gameObject == collider.gameObject)
					{
						return true;
					}
					if (clothSphereColliderPair.second != null && clothSphereColliderPair.second.gameObject == collider.gameObject)
					{
						return true;
					}
				}
			}
			return false;
		}

		public void Kill()
		{
			state = State.Dead;
		}

		public void Kill(StateSettings stateSettings)
		{
			this.stateSettings = stateSettings;
			state = State.Dead;
		}

		public void Freeze()
		{
			state = State.Frozen;
		}

		public void Freeze(StateSettings stateSettings)
		{
			this.stateSettings = stateSettings;
			state = State.Frozen;
		}

		public void Resurrect()
		{
			state = State.Alive;
		}

		protected virtual void SwitchStates()
		{
			if (state == lastState || isKilling)
			{
				return;
			}
			if (freezeFlag)
			{
				if (state == State.Alive)
				{
					activeState = State.Dead;
					lastState = State.Dead;
					freezeFlag = false;
				}
				else if (state == State.Dead)
				{
					lastState = State.Dead;
					freezeFlag = false;
					return;
				}
				if (freezeFlag)
				{
					return;
				}
			}
			if (lastState == State.Alive)
			{
				if (state == State.Dead)
				{
					StartCoroutine(AliveToDead(freeze: false));
				}
				else if (state == State.Frozen)
				{
					StartCoroutine(AliveToDead(freeze: true));
				}
			}
			else if (lastState == State.Dead)
			{
				if (state == State.Alive)
				{
					DeadToAlive();
				}
				else if (state == State.Frozen)
				{
					DeadToFrozen();
				}
			}
			else if (lastState == State.Frozen)
			{
				if (state == State.Alive)
				{
					FrozenToAlive();
				}
				else if (state == State.Dead)
				{
					FrozenToDead();
				}
			}
			lastState = state;
		}

		private IEnumerator AliveToDead(bool freeze)
		{
			isKilling = true;
			mode = Mode.Active;
			if (stateSettings.enableAngularLimitsOnKill && !angularLimits)
			{
				angularLimits = true;
				angularLimitsEnabledOnKill = true;
			}
			if (stateSettings.enableInternalCollisionsOnKill && !internalCollisions)
			{
				internalCollisions = true;
				internalCollisionsEnabledOnKill = true;
			}
			Muscle[] array = muscles;
			foreach (Muscle muscle in array)
			{
				muscle.state.pinWeightMlp = 0f;
				muscle.state.muscleDamperAdd = stateSettings.deadMuscleDamper;
				muscle.rigidbody.velocity = muscle.mappedVelocity;
				muscle.rigidbody.angularVelocity = muscle.mappedAngularVelocity;
			}
			float range = muscles[0].state.muscleWeightMlp - stateSettings.deadMuscleWeight;
			BehaviourBase[] array2 = behaviours;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].KillStart();
			}
			if (stateSettings.killDuration > 0f && range > 0f)
			{
				float mW = muscles[0].state.muscleWeightMlp;
				while (mW > stateSettings.deadMuscleWeight)
				{
					mW = Mathf.Max(mW - Time.deltaTime * (range / stateSettings.killDuration), stateSettings.deadMuscleWeight);
					array = muscles;
					for (int i = 0; i < array.Length; i++)
					{
						array[i].state.muscleWeightMlp = mW;
					}
					yield return null;
				}
			}
			array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].state.muscleWeightMlp = stateSettings.deadMuscleWeight;
			}
			SetAnimationEnabled(to: false);
			isKilling = false;
			activeState = State.Dead;
			if (freeze)
			{
				freezeFlag = true;
			}
			array2 = behaviours;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].KillEnd();
			}
			if (OnDeath != null)
			{
				OnDeath();
			}
		}

		private void OnFreezeFlag()
		{
			if (!CanFreeze())
			{
				return;
			}
			SetAnimationEnabled(to: false);
			Muscle[] array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].joint.gameObject.SetActive(value: false);
			}
			BehaviourBase[] array2 = behaviours;
			foreach (BehaviourBase behaviourBase in array2)
			{
				behaviourBase.Freeze();
				if (behaviourBase.gameObject.activeSelf)
				{
					behaviourBase.deactivated = true;
					behaviourBase.gameObject.SetActive(value: false);
				}
			}
			freezeFlag = false;
			activeState = State.Frozen;
			if (OnFreeze != null)
			{
				OnFreeze();
			}
			if (stateSettings.freezePermanently)
			{
				if (behaviours.Length != 0 && behaviours[0] != null)
				{
					UnityEngine.Object.Destroy(behaviours[0].transform.parent.gameObject);
				}
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		private void DeadToAlive()
		{
			Muscle[] array = muscles;
			foreach (Muscle obj in array)
			{
				obj.state.pinWeightMlp = 1f;
				obj.state.muscleWeightMlp = 1f;
				obj.state.muscleDamperAdd = 0f;
			}
			if (angularLimitsEnabledOnKill)
			{
				angularLimits = false;
				angularLimitsEnabledOnKill = false;
			}
			if (internalCollisionsEnabledOnKill)
			{
				internalCollisions = false;
				internalCollisionsEnabledOnKill = false;
			}
			BehaviourBase[] array2 = behaviours;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].Resurrect();
			}
			SetAnimationEnabled(to: true);
			activeState = State.Alive;
			if (OnResurrection != null)
			{
				OnResurrection();
			}
		}

		private void SetAnimationEnabled(bool to)
		{
			animatorDisabled = false;
			if (targetAnimator != null)
			{
				targetAnimator.enabled = to;
			}
			if (targetAnimation != null)
			{
				targetAnimation.enabled = to;
			}
		}

		private void DeadToFrozen()
		{
			freezeFlag = true;
		}

		private void FrozenToAlive()
		{
			freezeFlag = false;
			Muscle[] array = muscles;
			foreach (Muscle obj in array)
			{
				obj.state.pinWeightMlp = 1f;
				obj.state.muscleWeightMlp = 1f;
				obj.state.muscleDamperAdd = 0f;
			}
			if (angularLimitsEnabledOnKill)
			{
				angularLimits = false;
				angularLimitsEnabledOnKill = false;
			}
			if (internalCollisionsEnabledOnKill)
			{
				internalCollisions = false;
				internalCollisionsEnabledOnKill = false;
			}
			ActivateRagdoll();
			BehaviourBase[] array2 = behaviours;
			foreach (BehaviourBase behaviourBase in array2)
			{
				behaviourBase.Unfreeze();
				behaviourBase.Resurrect();
				if (behaviourBase.deactivated)
				{
					behaviourBase.gameObject.SetActive(value: true);
				}
			}
			if (targetAnimator != null)
			{
				targetAnimator.enabled = true;
			}
			if (targetAnimation != null)
			{
				targetAnimation.enabled = true;
			}
			activeState = State.Alive;
			if (OnUnfreeze != null)
			{
				OnUnfreeze();
			}
			if (OnResurrection != null)
			{
				OnResurrection();
			}
		}

		private void FrozenToDead()
		{
			freezeFlag = false;
			ActivateRagdoll();
			BehaviourBase[] array = behaviours;
			foreach (BehaviourBase behaviourBase in array)
			{
				behaviourBase.Unfreeze();
				if (behaviourBase.deactivated)
				{
					behaviourBase.gameObject.SetActive(value: true);
				}
			}
			activeState = State.Dead;
			if (OnUnfreeze != null)
			{
				OnUnfreeze();
			}
		}

		private void ActivateRagdoll(bool kinematic = false)
		{
			Muscle[] array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Reset();
			}
			array = muscles;
			foreach (Muscle obj in array)
			{
				obj.joint.gameObject.SetActive(value: true);
				obj.rigidbody.isKinematic = kinematic;
				obj.rigidbody.velocity = Vector3.zero;
				obj.rigidbody.angularVelocity = Vector3.zero;
			}
			internalCollisionsEnabled = true;
			SetInternalCollisions(internalCollisions);
			Read();
			array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].MoveToTarget();
			}
		}

		private bool CanFreeze()
		{
			Muscle[] array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].rigidbody.velocity.sqrMagnitude > stateSettings.maxFreezeSqrVelocity)
				{
					return false;
				}
			}
			return true;
		}

		public void SampleTargetMappedState()
		{
			if (!CheckIfInitiated())
			{
				return;
			}
			sampleTargetMappedState = true;
			if (!targetMappedStateStored)
			{
				sampleTargetMappedState = true;
				return;
			}
			for (int i = 0; i < targetChildren.Length; i++)
			{
				targetSampledPositions[i] = targetMappedPositions[i];
				targetSampledRotations[i] = targetMappedRotations[i];
			}
			targetMappedStateSampled = true;
		}

		public void FixTargetToSampledState(float weight)
		{
			if (!CheckIfInitiated() || weight <= 0f || !targetMappedStateSampled)
			{
				return;
			}
			for (int i = 0; i < targetChildren.Length; i++)
			{
				if (targetChildren[i] == null)
				{
					UnityEngine.Debug.LogWarning("PuppetMaster.UpdateTargetHierarchy() needs to be called when any of the child Transforms of the targetRoot are unparented or removed.", base.transform);
					return;
				}
				if (i == 0)
				{
					targetChildren[i].position = Vector3.Lerp(targetChildren[i].position, targetSampledPositions[i], weight);
					targetChildren[i].rotation = Quaternion.Lerp(targetChildren[i].rotation, targetSampledRotations[i], weight);
				}
				else
				{
					targetChildren[i].position = Vector3.Lerp(targetChildren[i].position, targetSampledPositions[0] + targetSampledRotations[0] * targetSampledPositions[i], weight);
					targetChildren[i].rotation = Quaternion.Lerp(targetChildren[i].rotation, targetSampledRotations[0] * targetSampledRotations[i], weight);
				}
			}
			Muscle[] array = muscles;
			foreach (Muscle muscle in array)
			{
				muscle.positionOffset = muscle.target.position - muscle.rigidbody.position;
			}
		}

		public void StoreTargetMappedState()
		{
			if (!CheckIfInitiated() || !storeTargetMappedState)
			{
				return;
			}
			for (int i = 0; i < targetChildren.Length; i++)
			{
				if (i == 0)
				{
					targetMappedPositions[i] = targetChildren[i].position;
					targetMappedRotations[i] = targetChildren[i].rotation;
				}
				else
				{
					targetMappedPositions[i] = Quaternion.Inverse(targetChildren[0].rotation) * (targetChildren[i].position - targetChildren[0].position);
					targetMappedRotations[i] = Quaternion.Inverse(targetChildren[0].rotation) * targetChildren[i].rotation;
				}
			}
			targetMappedStateStored = true;
			if (sampleTargetMappedState)
			{
				SampleTargetMappedState();
			}
			sampleTargetMappedState = false;
		}

		private void UpdateHierarchies()
		{
			targetChildren = new Transform[muscles.Length];
			for (int i = 0; i < muscles.Length; i++)
			{
				targetChildren[i] = muscles[i].target;
			}
			targetMappedPositions = new Vector3[targetChildren.Length];
			targetMappedRotations = new Quaternion[targetChildren.Length];
			targetSampledPositions = new Vector3[targetChildren.Length];
			targetSampledRotations = new Quaternion[targetChildren.Length];
			targetMappedStateStored = false;
			targetMappedStateSampled = false;
			AssignParentAndChildIndexes();
			AssignKinshipDegrees();
			UpdateBroadcasterMuscleIndexes();
			internalCollisionsEnabled = !internalCollisions;
			SetInternalCollisions(internalCollisions);
			angularLimitsEnabled = !angularLimits;
			SetAngularLimits(angularLimits);
			hasProp = HasProp();
			if (OnHierarchyChanged != null)
			{
				OnHierarchyChanged();
			}
		}

		private bool HasProp()
		{
			Muscle[] array = muscles;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].props.group == Muscle.Group.Prop)
				{
					return true;
				}
			}
			return false;
		}

		private void UpdateBroadcasterMuscleIndexes()
		{
			for (int i = 0; i < muscles.Length; i++)
			{
				if (muscles[i].broadcaster != null)
				{
					muscles[i].broadcaster.muscleIndex = i;
				}
				if (muscles[i].jointBreakBroadcaster != null)
				{
					muscles[i].jointBreakBroadcaster.muscleIndex = i;
				}
			}
		}

		private void AssignParentAndChildIndexes()
		{
			for (int i = 0; i < muscles.Length; i++)
			{
				muscles[i].parentIndexes = new int[0];
				if (muscles[i].joint.connectedBody != null)
				{
					AddToParentsRecursive(muscles[i].joint.connectedBody.GetComponent<ConfigurableJoint>(), ref muscles[i].parentIndexes);
				}
				muscles[i].childIndexes = new int[0];
				muscles[i].childFlags = new bool[muscles.Length];
				for (int j = 0; j < muscles.Length; j++)
				{
					if (i != j && muscles[j].joint.connectedBody == muscles[i].rigidbody)
					{
						AddToChildrenRecursive(muscles[j].joint, ref muscles[i].childIndexes, ref muscles[i].childFlags);
					}
				}
			}
		}

		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
			if (joint == null)
			{
				return;
			}
			int muscleIndexLowLevel = GetMuscleIndexLowLevel(joint);
			if (muscleIndexLowLevel != -1)
			{
				Array.Resize(ref indexes, indexes.Length + 1);
				indexes[indexes.Length - 1] = muscleIndexLowLevel;
				if (!(joint.connectedBody == null))
				{
					AddToParentsRecursive(joint.connectedBody.GetComponent<ConfigurableJoint>(), ref indexes);
				}
			}
		}

		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
			if (joint == null)
			{
				return;
			}
			int muscleIndexLowLevel = GetMuscleIndexLowLevel(joint);
			if (muscleIndexLowLevel == -1)
			{
				return;
			}
			Array.Resize(ref indexes, indexes.Length + 1);
			indexes[indexes.Length - 1] = muscleIndexLowLevel;
			childFlags[muscleIndexLowLevel] = true;
			for (int i = 0; i < muscles.Length; i++)
			{
				if (i != muscleIndexLowLevel && muscles[i].joint.connectedBody == joint.GetComponent<Rigidbody>())
				{
					AddToChildrenRecursive(muscles[i].joint, ref indexes, ref childFlags);
				}
			}
		}

		private void AssignKinshipDegrees()
		{
			for (int i = 0; i < muscles.Length; i++)
			{
				muscles[i].kinshipDegrees = new int[muscles.Length];
				AssignKinshipsDownRecursive(ref muscles[i].kinshipDegrees, 1, i);
				AssignKinshipsUpRecursive(ref muscles[i].kinshipDegrees, 1, i);
			}
		}

		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
			for (int i = 0; i < muscles.Length; i++)
			{
				if (i != index && muscles[i].joint.connectedBody == muscles[index].rigidbody)
				{
					kinshipDegrees[i] = degree;
					AssignKinshipsDownRecursive(ref kinshipDegrees, degree + 1, i);
				}
			}
		}

		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
			for (int i = 0; i < muscles.Length; i++)
			{
				if (i == index || !(muscles[i].rigidbody == muscles[index].joint.connectedBody))
				{
					continue;
				}
				kinshipDegrees[i] = degree;
				AssignKinshipsUpRecursive(ref kinshipDegrees, degree + 1, i);
				for (int j = 0; j < muscles.Length; j++)
				{
					if (j != i && j != index && muscles[j].joint.connectedBody == muscles[i].rigidbody)
					{
						kinshipDegrees[j] = degree + 1;
						AssignKinshipsDownRecursive(ref kinshipDegrees, degree + 2, j);
					}
				}
			}
		}

		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			for (int i = 0; i < muscles.Length; i++)
			{
				if (muscles[i].joint == joint)
				{
					return i;
				}
			}
			return -1;
		}

		public bool IsValid(bool log)
		{
			if (muscles == null)
			{
				if (log)
				{
					UnityEngine.Debug.LogWarning("PuppetMaster Muscles is null.", base.transform);
				}
				return false;
			}
			if (muscles.Length == 0)
			{
				if (log)
				{
					UnityEngine.Debug.LogWarning("PuppetMaster has no muscles.", base.transform);
				}
				return false;
			}
			for (int i = 0; i < muscles.Length; i++)
			{
				if (muscles[i] == null)
				{
					if (log)
					{
						UnityEngine.Debug.LogWarning("Muscle is null, PuppetMaster muscle setup is invalid.", base.transform);
					}
					return false;
				}
				if (!muscles[i].IsValid(log))
				{
					return false;
				}
			}
			if (targetRoot == null)
			{
				if (log)
				{
					UnityEngine.Debug.LogWarning("'Target Root' of PuppetMaster is null.");
				}
				return false;
			}
			if (targetRoot.position != base.transform.position)
			{
				if (log)
				{
					UnityEngine.Debug.LogWarning("The position of the animated character (Target) must match with the position of the PuppetMaster when initiating PuppetMaster. If you are creating the Puppet in runtime, make sure you don't move the Target to another position immediatelly after instantiation. Move the Root Transform instead.");
				}
				return false;
			}
			if (targetRoot == null)
			{
				if (log)
				{
					UnityEngine.Debug.LogWarning("Invalid PuppetMaster setup. (targetRoot not found)", base.transform);
				}
				return false;
			}
			for (int j = 0; j < muscles.Length; j++)
			{
				for (int k = 0; k < muscles.Length; k++)
				{
					if (j != k && (muscles[j] == muscles[k] || muscles[j].joint == muscles[k].joint))
					{
						if (log)
						{
							UnityEngine.Debug.LogWarning("Joint " + muscles[j].joint.name + " is used by multiple muscles (indexes " + j + " and " + k + "), PuppetMaster muscle setup is invalid.", base.transform);
						}
						return false;
					}
				}
			}
			if (muscles[0].joint.connectedBody != null && muscles.Length > 1)
			{
				for (int l = 1; l < muscles.Length; l++)
				{
					if (muscles[l].joint.GetComponent<Rigidbody>() == muscles[0].joint.connectedBody)
					{
						if (log)
						{
							UnityEngine.Debug.LogWarning("The first muscle needs to be the one that all the others are connected to (the hips).", base.transform);
						}
						return false;
					}
				}
			}
			for (int m = 0; m < muscles.Length; m++)
			{
				if (Vector3.SqrMagnitude(muscles[m].joint.transform.position - muscles[m].target.position) > 0.001f)
				{
					if (log)
					{
						UnityEngine.Debug.LogWarning("The position of each muscle needs to match with the position of it's target. Muscle '" + muscles[m].joint.name + "' position does not match with it's target. Right-click on the PuppetMaster component's header and select 'Fix Muscle Positions' from the context menu.", muscles[m].joint.transform);
					}
					return false;
				}
			}
			CheckMassVariation(100f, log: true);
			return true;
		}

		private bool CheckMassVariation(float threshold, bool log)
		{
			float num = float.PositiveInfinity;
			float num2 = 0f;
			for (int i = 0; i < muscles.Length; i++)
			{
				float mass = muscles[i].joint.GetComponent<Rigidbody>().mass;
				if (mass < num)
				{
					num = mass;
				}
				if (mass > num2)
				{
					num2 = mass;
				}
			}
			if (num2 / num > threshold)
			{
				if (log)
				{
					UnityEngine.Debug.LogWarning("Mass variation between the Rigidbodies in the ragdoll is more than " + threshold.ToString() + " times. This might cause instability and unwanted results with Rigidbodies connected by Joints. Min mass: " + num + ", max mass: " + num2, base.transform);
				}
				return false;
			}
			return true;
		}

		private bool CheckIfInitiated()
		{
			if (!initiated)
			{
				UnityEngine.Debug.LogError("PuppetMaster has not been initiated yet.");
			}
			return initiated;
		}
	}
	[Serializable]
	public enum MuscleRemoveMode
	{
		Sever,
		Explode,
		Numb
	}
	[CreateAssetMenu(fileName = "PuppetMaster Humanoid Config", menuName = "PuppetMaster/Humanoid Config", order = 1)]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		public class HumanoidMuscle
		{
			[SerializeField]
			[HideInInspector]
			public string name;

			public HumanBodyBones bone;

			public Muscle.Props props;
		}

		[LargeHeader("Simulation")]
		public PuppetMaster.State state;

		public PuppetMaster.StateSettings stateSettings = PuppetMaster.StateSettings.Default;

		public PuppetMaster.Mode mode;

		public float blendTime = 0.1f;

		public bool fixTargetTransforms = true;

		public int solverIterationCount = 6;

		public bool visualizeTargetPose = true;

		[LargeHeader("Master Weights")]
		[Range(0f, 1f)]
		public float mappingWeight = 1f;

		[Range(0f, 1f)]
		public float pinWeight = 1f;

		[Range(0f, 1f)]
		public float muscleWeight = 1f;

		[LargeHeader("Joint and Muscle Settings")]
		public float muscleSpring = 100f;

		public float muscleDamper;

		[Range(1f, 8f)]
		public float pinPow = 4f;

		[Range(0f, 100f)]
		public float pinDistanceFalloff = 5f;

		public bool updateJointAnchors = true;

		public bool supportTranslationAnimation;

		public bool angularLimits;

		public bool internalCollisions;

		[LargeHeader("Individual Muscle Settings")]
		public HumanoidMuscle[] muscles = new HumanoidMuscle[0];

		public void ApplyTo(PuppetMaster p)
		{
			if (p.targetRoot == null)
			{
				UnityEngine.Debug.LogWarning("Please assign 'Target Root' for PuppetMaster using a Humanoid Config.", p.transform);
				return;
			}
			if (p.targetAnimator == null)
			{
				UnityEngine.Debug.LogError("PuppetMaster 'Target Root' does not have an Animator component. Can not use Humanoid Config.", p.transform);
				return;
			}
			if (!p.targetAnimator.isHuman)
			{
				UnityEngine.Debug.LogError("PuppetMaster target is not a Humanoid. Can not use Humanoid Config.", p.transform);
				return;
			}
			p.state = state;
			p.stateSettings = stateSettings;
			p.mode = mode;
			p.blendTime = blendTime;
			p.fixTargetTransforms = fixTargetTransforms;
			p.solverIterationCount = solverIterationCount;
			p.visualizeTargetPose = visualizeTargetPose;
			p.mappingWeight = mappingWeight;
			p.pinWeight = pinWeight;
			p.muscleWeight = muscleWeight;
			p.muscleSpring = muscleSpring;
			p.muscleDamper = muscleDamper;
			p.pinPow = pinPow;
			p.pinDistanceFalloff = pinDistanceFalloff;
			p.updateJointAnchors = updateJointAnchors;
			p.supportTranslationAnimation = supportTranslationAnimation;
			p.angularLimits = angularLimits;
			p.internalCollisions = internalCollisions;
			HumanoidMuscle[] array = muscles;
			foreach (HumanoidMuscle humanoidMuscle in array)
			{
				Muscle muscle = GetMuscle(humanoidMuscle.bone, p.targetAnimator, p);
				if (muscle != null)
				{
					muscle.props.group = humanoidMuscle.props.group;
					muscle.props.mappingWeight = humanoidMuscle.props.mappingWeight;
					muscle.props.mapPosition = humanoidMuscle.props.mapPosition;
					muscle.props.muscleDamper = humanoidMuscle.props.muscleDamper;
					muscle.props.muscleWeight = humanoidMuscle.props.muscleWeight;
					muscle.props.pinWeight = humanoidMuscle.props.pinWeight;
				}
			}
		}

		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			Transform boneTransform = animator.GetBoneTransform(boneId);
			if (boneTransform == null)
			{
				return null;
			}
			Muscle[] array = puppetMaster.muscles;
			foreach (Muscle muscle in array)
			{
				if (muscle.target == boneTransform)
				{
					return muscle;
				}
			}
			return null;
		}
	}
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/PuppetMaster Settings")]
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		[Serializable]
		public class PuppetUpdateLimit
		{
			[Range(1f, 100f)]
			public int puppetsPerFrame;

			private int index;

			public PuppetUpdateLimit()
			{
				puppetsPerFrame = 100;
			}

			public void Step(int puppetCount)
			{
				index += puppetsPerFrame;
				if (index >= puppetCount)
				{
					index -= puppetCount;
				}
			}

			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				if (puppetsPerFrame >= puppets.Count)
				{
					return true;
				}
				if (index >= puppets.Count)
				{
					return false;
				}
				for (int i = 0; i < puppetsPerFrame; i++)
				{
					int num = index + i;
					if (num >= puppets.Count)
					{
						num -= puppets.Count;
					}
					if (puppets[num] == puppetMaster)
					{
						return true;
					}
				}
				return false;
			}
		}

		[Header("Optimizations")]
		public PuppetUpdateLimit kinematicCollidersUpdateLimit = new PuppetUpdateLimit();

		public PuppetUpdateLimit freeUpdateLimit = new PuppetUpdateLimit();

		public PuppetUpdateLimit fixedUpdateLimit = new PuppetUpdateLimit();

		public bool collisionStayMessages = true;

		public bool collisionExitMessages = true;

		public float activePuppetCollisionThresholdMlp;

		private List<PuppetMaster> _puppets = new List<PuppetMaster>();

		public int currentlyActivePuppets { get; private set; }

		public int currentlyKinematicPuppets { get; private set; }

		public int currentlyDisabledPuppets { get; private set; }

		public List<PuppetMaster> puppets => _puppets;

		public void Register(PuppetMaster puppetMaster)
		{
			if (!_puppets.Contains(puppetMaster))
			{
				_puppets.Add(puppetMaster);
			}
		}

		public void Unregister(PuppetMaster puppetMaster)
		{
			_puppets.Remove(puppetMaster);
		}

		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return kinematicCollidersUpdateLimit.Update(_puppets, puppetMaster);
		}

		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return freeUpdateLimit.Update(_puppets, puppetMaster);
		}

		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return fixedUpdateLimit.Update(_puppets, puppetMaster);
		}

		private void Update()
		{
			currentlyActivePuppets = 0;
			currentlyKinematicPuppets = 0;
			currentlyDisabledPuppets = 0;
			foreach (PuppetMaster puppet in _puppets)
			{
				if (puppet.isActive && puppet.isActiveAndEnabled)
				{
					currentlyActivePuppets++;
				}
				if (puppet.mode == PuppetMaster.Mode.Kinematic)
				{
					currentlyKinematicPuppets++;
				}
				if ((puppet.mode == PuppetMaster.Mode.Disabled && !puppet.isActive) || !puppet.isActiveAndEnabled)
				{
					currentlyDisabledPuppets++;
				}
			}
			freeUpdateLimit.Step(_puppets.Count);
			kinematicCollidersUpdateLimit.Step(_puppets.Count);
		}

		private void FixedUpdate()
		{
			fixedUpdateLimit.Step(_puppets.Count);
		}
	}
	public static class PuppetMasterTools
	{
		public static void PositionRagdoll(PuppetMaster puppetMaster)
		{
			Rigidbody[] componentsInChildren = puppetMaster.transform.GetComponentsInChildren<Rigidbody>();
			if (componentsInChildren.Length == 0)
			{
				return;
			}
			Muscle[] muscles = puppetMaster.muscles;
			foreach (Muscle muscle in muscles)
			{
				if (muscle.joint == null || muscle.target == null)
				{
					return;
				}
			}
			Vector3[] array = new Vector3[componentsInChildren.Length];
			for (int j = 0; j < componentsInChildren.Length; j++)
			{
				if (componentsInChildren[j].transform.childCount == 1)
				{
					array[j] = componentsInChildren[j].transform.InverseTransformDirection(componentsInChildren[j].transform.GetChild(0).position - componentsInChildren[j].transform.position);
				}
			}
			Rigidbody[] array2 = componentsInChildren;
			foreach (Rigidbody rigidbody in array2)
			{
				muscles = puppetMaster.muscles;
				foreach (Muscle muscle2 in muscles)
				{
					if (muscle2.joint.GetComponent<Rigidbody>() == rigidbody)
					{
						rigidbody.transform.position = muscle2.target.position;
					}
				}
			}
			for (int l = 0; l < componentsInChildren.Length; l++)
			{
				if (componentsInChildren[l].transform.childCount == 1)
				{
					Vector3 position = componentsInChildren[l].transform.GetChild(0).position;
					componentsInChildren[l].transform.rotation = Quaternion.FromToRotation(componentsInChildren[l].transform.rotation * array[l], position - componentsInChildren[l].transform.position) * componentsInChildren[l].transform.rotation;
					componentsInChildren[l].transform.GetChild(0).position = position;
				}
			}
		}

		public static void RealignRagdoll(PuppetMaster puppetMaster)
		{
			Muscle[] muscles = puppetMaster.muscles;
			foreach (Muscle muscle in muscles)
			{
				if (muscle.joint == null || muscle.joint.transform == null || muscle.target == null)
				{
					UnityEngine.Debug.LogWarning("Muscles incomplete, can not realign ragdoll.");
					return;
				}
			}
			muscles = puppetMaster.muscles;
			foreach (Muscle muscle2 in muscles)
			{
				if (muscle2.target != null)
				{
					Transform[] array = new Transform[muscle2.joint.transform.childCount];
					for (int j = 0; j < array.Length; j++)
					{
						array[j] = muscle2.joint.transform.GetChild(j);
					}
					Transform[] array2 = array;
					for (int k = 0; k < array2.Length; k++)
					{
						array2[k].parent = null;
					}
					BoxCollider component = muscle2.joint.GetComponent<BoxCollider>();
					Vector3 vector = Vector3.zero;
					Vector3 vector2 = Vector3.zero;
					if (component != null)
					{
						vector = component.transform.TransformVector(component.size);
						vector2 = component.transform.TransformVector(component.center);
					}
					CapsuleCollider component2 = muscle2.joint.GetComponent<CapsuleCollider>();
					Vector3 vector3 = Vector3.zero;
					Vector3 direction = Vector3.zero;
					if (component2 != null)
					{
						vector3 = component2.transform.TransformVector(component2.center);
						direction = component2.transform.TransformVector(DirectionIntToVector3(component2.direction));
					}
					SphereCollider component3 = muscle2.joint.GetComponent<SphereCollider>();
					Vector3 vector4 = Vector3.zero;
					if (component3 != null)
					{
						vector4 = component3.transform.TransformVector(component3.center);
					}
					Vector3 vector5 = muscle2.joint.transform.TransformVector(muscle2.joint.axis);
					Vector3 vector6 = muscle2.joint.transform.TransformVector(muscle2.joint.secondaryAxis);
					muscle2.joint.transform.rotation = muscle2.target.rotation;
					if (component != null)
					{
						component.size = component.transform.InverseTransformVector(vector);
						component.center = component.transform.InverseTransformVector(vector2);
					}
					if (component2 != null)
					{
						component2.center = component2.transform.InverseTransformVector(vector3);
						Vector3 dir = component2.transform.InverseTransformDirection(direction);
						component2.direction = DirectionVector3ToInt(dir);
					}
					if (component3 != null)
					{
						component3.center = component3.transform.InverseTransformVector(vector4);
					}
					muscle2.joint.axis = muscle2.joint.transform.InverseTransformVector(vector5);
					muscle2.joint.secondaryAxis = muscle2.joint.transform.InverseTransformVector(vector6);
					array2 = array;
					for (int k = 0; k < array2.Length; k++)
					{
						array2[k].parent = muscle2.joint.transform;
					}
				}
			}
		}

		private static Vector3 DirectionIntToVector3(int dir)
		{
			return dir switch
			{
				0 => Vector3.right, 
				1 => Vector3.up, 
				_ => Vector3.forward, 
			};
		}

		private static int DirectionVector3ToInt(Vector3 dir)
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
	}
	[Serializable]
	public class Weight
	{
		[Serializable]
		public enum Mode
		{
			Float,
			Curve
		}

		public Mode mode;

		public float floatValue;

		public AnimationCurve curve;

		public string tooltip = "";

		public Weight(float floatValue)
		{
			this.floatValue = floatValue;
		}

		public Weight(float floatValue, string tooltip)
		{
			this.floatValue = floatValue;
			this.tooltip = tooltip;
		}

		public float GetValue(float param)
		{
			Mode mode = this.mode;
			if (mode == Mode.Curve)
			{
				return curve.Evaluate(param);
			}
			return floatValue;
		}
	}
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
			string msg = string.Empty;
			if (!r.IsValid(ref msg))
			{
				UnityEngine.Debug.LogWarning(msg);
				return;
			}
			RagdollCreator.ClearAll(r.root);
			CreateColliders(r, options);
			MassDistribution(r, options);
			CreateJoints(r, options);
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

		public bool IsValid(ref string msg)
		{
			if (root == null || hips == null || head == null || leftUpperArm == null || leftLowerArm == null || leftHand == null || rightUpperArm == null || rightLowerArm == null || rightHand == null || leftUpperLeg == null || leftLowerLeg == null || leftFoot == null || rightUpperLeg == null || rightLowerLeg == null || rightFoot == null)
			{
				msg = "Invalid References, one or more Transforms missing.";
				return false;
			}
			Transform[] array = new Transform[15]
			{
				root, hips, head, leftUpperArm, leftLowerArm, leftHand, rightUpperArm, rightLowerArm, rightHand, leftUpperLeg,
				leftLowerLeg, leftFoot, rightUpperLeg, rightLowerLeg, rightFoot
			};
			for (int i = 1; i < array.Length; i++)
			{
				if (!IsChildRecursive(array[i], root))
				{
					msg = "Invalid References, " + array[i].name + " is not in the Root's hierarchy.";
					return false;
				}
			}
			for (int j = 0; j < array.Length; j++)
			{
				for (int k = 0; k < array.Length; k++)
				{
					if (j != k && array[j] == array[k])
					{
						msg = "Invalid References, " + array[j].name + " is represented more than once.";
						return false;
					}
				}
			}
			return true;
		}

		private bool IsChildRecursive(Transform t, Transform parent)
		{
			if (t.parent == parent)
			{
				return true;
			}
			if (t.parent != null)
			{
				return IsChildRecursive(t.parent, parent);
			}
			return false;
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
			if (transform == null)
			{
				return;
			}
			Collider[] components = transform.GetComponents<Collider>();
			foreach (Collider collider in components)
			{
				if (collider != null && !collider.isTrigger)
				{
					UnityEngine.Object.DestroyImmediate(collider);
				}
			}
			Joint component = transform.GetComponent<Joint>();
			if (component != null)
			{
				UnityEngine.Object.DestroyImmediate(component);
			}
			Rigidbody component2 = transform.GetComponent<Rigidbody>();
			if (component2 != null)
			{
				UnityEngine.Object.DestroyImmediate(component2);
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
namespace RootMotion.Demos
{
	[RequireComponent(typeof(Animator))]
	public class AnimatorIKDemo : MonoBehaviour
	{
		public Transform leftHandIKTarget;

		private Animator animator;

		private void Start()
		{
			animator = GetComponent<Animator>();
		}

		private void OnAnimatorIK(int layer)
		{
			animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHandIKTarget.position);
			animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1f);
		}
	}
	public class BallShooter : MonoBehaviour
	{
		public KeyCode keyCode = KeyCode.Mouse0;

		public GameObject ball;

		public Vector3 spawnOffset = new Vector3(0f, 0.5f, 0f);

		public Vector3 force = new Vector3(0f, 0f, 7f);

		public float mass = 3f;

		private void Update()
		{
			if (Input.GetKeyDown(keyCode))
			{
				Rigidbody component = UnityEngine.Object.Instantiate(ball, base.transform.position + base.transform.rotation * spawnOffset, base.transform.rotation).GetComponent<Rigidbody>();
				if (component != null)
				{
					component.mass = mass;
					component.AddForce(Quaternion.LookRotation(Camera.main.ScreenPointToRay(Input.mousePosition).direction) * force, ForceMode.VelocityChange);
				}
			}
		}
	}
	public class CharacterAnimationMeleeDemo : CharacterAnimationThirdPerson
	{
		private CharacterMeleeDemo melee => characterController as CharacterMeleeDemo;

		protected override void Update()
		{
			base.Update();
			animator.SetInteger("ActionIndex", -1);
			if (melee.currentAction != null)
			{
				animator.SetInteger("ActionIndex", melee.currentActionIndex);
				CharacterMeleeDemo.Action.Anim anim = melee.currentAction.anim;
				animator.CrossFadeInFixedTime(anim.stateName, anim.transitionDuration, anim.layer, anim.fixedTime);
				melee.currentActionIndex = -1;
			}
		}
	}
	public class CharacterMeleeDemo : CharacterPuppet
	{
		[Serializable]
		public class Action
		{
			[Serializable]
			public class Anim
			{
				public string stateName;

				public int layer;

				public float transitionDuration;

				public float fixedTime;
			}

			public string name;

			public int inputActionIndex = 1;

			public float duration;

			public float minFrequency;

			public Anim anim;

			public int[] requiredPropTypes;

			public Booster[] boosters;
		}

		[Header("Melee")]
		public Action[] actions;

		[HideInInspector]
		public int currentActionIndex = -1;

		[HideInInspector]
		public float lastActionTime;

		private float lastActionMoveMag;

		public Action currentAction
		{
			get
			{
				if (currentActionIndex < 0)
				{
					return null;
				}
				return actions[currentActionIndex];
			}
		}

		protected override void Start()
		{
			currentActionIndex = -1;
			lastActionTime = 0f;
			base.Start();
		}

		protected override void Update()
		{
			if (base.puppet.state == BehaviourPuppet.State.Puppet)
			{
				for (int i = 0; i < actions.Length; i++)
				{
					if (StartAction(actions[i]))
					{
						currentActionIndex = i;
						Booster[] boosters = actions[i].boosters;
						for (int j = 0; j < boosters.Length; j++)
						{
							boosters[j].Boost(base.puppet);
						}
						if (propRoot.currentProp is PropMelee)
						{
							(propRoot.currentProp as PropMelee).StartAction(actions[i].duration);
						}
						lastActionTime = Time.time;
						lastActionMoveMag = moveDirection.magnitude;
					}
				}
			}
			if (Time.time < lastActionTime + 0.5f)
			{
				moveDirection = moveDirection.normalized * Mathf.Max(moveDirection.magnitude, lastActionMoveMag);
			}
			base.Update();
		}

		private bool StartAction(Action action)
		{
			if (Time.time < lastActionTime + action.minFrequency)
			{
				return false;
			}
			if (userControl.state.actionIndex != action.inputActionIndex)
			{
				return false;
			}
			if (action.requiredPropTypes.Length != 0)
			{
				if (propRoot.currentProp == null && action.requiredPropTypes[0] == -1)
				{
					return true;
				}
				if (propRoot.currentProp == null)
				{
					return false;
				}
				bool flag = false;
				for (int i = 0; i < action.requiredPropTypes.Length; i++)
				{
					if (action.requiredPropTypes[i] == propRoot.currentProp.propType)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}
	}
	public class CharacterPuppet : CharacterThirdPerson
	{
		[Header("Puppet")]
		public PropRoot propRoot;

		public BehaviourPuppet puppet { get; private set; }

		protected override void Start()
		{
			base.Start();
			puppet = base.transform.parent.GetComponentInChildren<BehaviourPuppet>();
		}

		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
			if (puppet.state != 0)
			{
				userControl.state.move = Vector3.zero;
			}
			else
			{
				base.Move(deltaPosition, deltaRotation);
			}
		}

		protected override void Rotate()
		{
			if (puppet.state != 0)
			{
				if (gravityTarget != null)
				{
					base.transform.rotation = Quaternion.FromToRotation(base.transform.up, base.transform.position - gravityTarget.position) * base.transform.rotation;
				}
			}
			else
			{
				base.Rotate();
			}
		}

		protected override bool Jump()
		{
			if (puppet.state != 0)
			{
				return false;
			}
			return base.Jump();
		}
	}
	public class CreatePuppetInRuntime : MonoBehaviour
	{
		[Tooltip("Creating a Puppet from a ragdoll character prefab.")]
		public Transform ragdollPrefab;

		[Tooltip("What will the Puppet be named?")]
		public string instanceName = "My Character";

		[Tooltip("The layer to assign the character controller to. Collisions between this layer and the 'Ragdoll Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		public int characterControllerLayer;

		[Tooltip("The layer to assign the PuppetMaster and all it's muscles to. Collisions between this layer and the 'Character Controller Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		public int ragdollLayer;

		private void Start()
		{
			Transform obj = UnityEngine.Object.Instantiate(ragdollPrefab, base.transform.position, base.transform.rotation);
			obj.name = instanceName;
			PuppetMaster.SetUp(obj, characterControllerLayer, ragdollLayer);
			UnityEngine.Debug.Log("A ragdoll was successfully converted to a Puppet.");
		}
	}
	public class CreateRagdollInRuntime : MonoBehaviour
	{
		[Tooltip("The character prefab/FBX.")]
		public GameObject prefab;

		private void Start()
		{
			BipedRagdollReferences r = BipedRagdollReferences.FromAvatar(UnityEngine.Object.Instantiate(prefab).GetComponent<Animator>());
			BipedRagdollCreator.Options options = BipedRagdollCreator.AutodetectOptions(r);
			BipedRagdollCreator.Create(r, options);
			UnityEngine.Debug.Log("A ragdoll was successfully created.");
		}

		private void Update()
		{
		}
	}
	public class Destructor : MonoBehaviour
	{
		public float delay = 5f;

		private void Start()
		{
			StartCoroutine(Destruct());
		}

		private IEnumerator Destruct()
		{
			yield return new WaitForSeconds(delay);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
	public class Dying : MonoBehaviour
	{
		[Tooltip("Reference to the PuppetMaster component.")]
		public PuppetMaster puppetMaster;

		[Tooltip("The speed of fading out PuppetMaster.pinWeight.")]
		public float fadeOutPinWeightSpeed = 5f;

		[Tooltip("The speed of fading out PuppetMaster.muscleWeight.")]
		public float fadeOutMuscleWeightSpeed = 5f;

		[Tooltip("The muscle weight to fade out to.")]
		public float deadMuscleWeight = 0.3f;

		private Animator animator;

		private Vector3 defaultPosition;

		private Quaternion defaultRotation = Quaternion.identity;

		private bool isDead;

		private void Start()
		{
			animator = GetComponent<Animator>();
			defaultPosition = base.transform.position;
			defaultRotation = base.transform.rotation;
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.D) && !isDead)
			{
				animator.CrossFadeInFixedTime("Die Backwards", 0.2f);
				if (puppetMaster != null)
				{
					StopAllCoroutines();
					StartCoroutine(FadeOutPinWeight());
					StartCoroutine(FadeOutMuscleWeight());
				}
				isDead = true;
			}
			if (Input.GetKeyDown(KeyCode.R) && isDead)
			{
				base.transform.position = defaultPosition;
				base.transform.rotation = defaultRotation;
				animator.Play("Idle", 0, 0f);
				if (puppetMaster != null)
				{
					StopAllCoroutines();
					puppetMaster.pinWeight = 1f;
					puppetMaster.muscleWeight = 1f;
				}
				isDead = false;
			}
		}

		private IEnumerator FadeOutPinWeight()
		{
			while (puppetMaster.pinWeight > 0f)
			{
				puppetMaster.pinWeight = Mathf.MoveTowards(puppetMaster.pinWeight, 0f, Time.deltaTime * fadeOutPinWeightSpeed);
				yield return null;
			}
		}

		private IEnumerator FadeOutMuscleWeight()
		{
			while (puppetMaster.muscleWeight > 0f)
			{
				puppetMaster.muscleWeight = Mathf.MoveTowards(puppetMaster.muscleWeight, deadMuscleWeight, Time.deltaTime * fadeOutMuscleWeightSpeed);
				yield return null;
			}
		}
	}
	[RequireComponent(typeof(ParticleSystem))]
	public class FXCollisionBlood : MonoBehaviour
	{
		public BehaviourPuppet puppet;

		public float minCollisionImpulse = 100f;

		public int emission = 2;

		public float emissionImpulseAdd = 0.01f;

		public int maxEmission = 7;

		private ParticleSystem particles;

		private void Start()
		{
			particles = GetComponent<ParticleSystem>();
			BehaviourPuppet behaviourPuppet = puppet;
			behaviourPuppet.OnCollisionImpulse = (BehaviourPuppet.CollisionImpulseDelegate)Delegate.Combine(behaviourPuppet.OnCollisionImpulse, new BehaviourPuppet.CollisionImpulseDelegate(OnCollisionImpulse));
		}

		private void OnCollisionImpulse(MuscleCollision m, float impulse)
		{
			if (m.collision.contacts.Length != 0 && !(impulse < minCollisionImpulse))
			{
				base.transform.position = m.collision.contacts[0].point;
				base.transform.rotation = Quaternion.LookRotation(m.collision.contacts[0].normal);
				particles.Emit(Mathf.Min(emission + (int)(emissionImpulseAdd * impulse), maxEmission));
			}
		}

		private void OnDestroy()
		{
			if (puppet != null)
			{
				BehaviourPuppet behaviourPuppet = puppet;
				behaviourPuppet.OnCollisionImpulse = (BehaviourPuppet.CollisionImpulseDelegate)Delegate.Remove(behaviourPuppet.OnCollisionImpulse, new BehaviourPuppet.CollisionImpulseDelegate(OnCollisionImpulse));
			}
		}
	}
	public class Grab : MonoBehaviour
	{
		[Tooltip("The PuppetMaster this muscle belongs to.")]
		public PuppetMaster puppetMaster;

		[Tooltip("Used for switching walk/run by default.")]
		public UserControlMelee userControl;

		[Tooltip("The layers we wish to grab (optimization).")]
		public int grabLayer;

		private bool grabbed;

		private Rigidbody r;

		private Collider c;

		private BehaviourPuppet otherPuppet;

		private Collider otherCollider;

		private ConfigurableJoint joint;

		private float nextGrabTime;

		private const float massMlp = 5f;

		private const int solverIterationMlp = 10;

		private void Start()
		{
			r = GetComponent<Rigidbody>();
			c = GetComponent<Collider>();
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (grabbed || Time.time < nextGrabTime || collision.gameObject.layer != grabLayer || collision.rigidbody == null)
			{
				return;
			}
			MuscleCollisionBroadcaster component = collision.gameObject.GetComponent<MuscleCollisionBroadcaster>();
			if (component == null || component.puppetMaster == puppetMaster)
			{
				return;
			}
			BehaviourBase[] behaviours = component.puppetMaster.behaviours;
			foreach (BehaviourBase behaviourBase in behaviours)
			{
				if (behaviourBase is BehaviourPuppet)
				{
					otherPuppet = behaviourBase as BehaviourPuppet;
					otherPuppet.SetState(BehaviourPuppet.State.Unpinned);
					otherPuppet.canGetUp = false;
				}
			}
			if (!(otherPuppet == null))
			{
				joint = base.gameObject.AddComponent<ConfigurableJoint>();
				joint.connectedBody = collision.rigidbody;
				joint.anchor = new Vector3(-0.35f, 0f, 0f);
				joint.xMotion = ConfigurableJointMotion.Locked;
				joint.yMotion = ConfigurableJointMotion.Locked;
				joint.zMotion = ConfigurableJointMotion.Locked;
				joint.angularXMotion = ConfigurableJointMotion.Locked;
				joint.angularYMotion = ConfigurableJointMotion.Locked;
				joint.angularZMotion = ConfigurableJointMotion.Locked;
				r.mass *= 5f;
				puppetMaster.solverIterationCount *= 10;
				otherCollider = collision.collider;
				Physics.IgnoreCollision(c, otherCollider, ignore: true);
				userControl.walkByDefault = true;
				grabbed = true;
			}
		}

		private void Update()
		{
			if (grabbed && Input.GetKeyDown(KeyCode.X))
			{
				UnityEngine.Object.Destroy(joint);
				r.mass /= 5f;
				puppetMaster.solverIterationCount /= 10;
				userControl.walkByDefault = false;
				Physics.IgnoreCollision(c, otherCollider, ignore: false);
				otherPuppet.canGetUp = true;
				otherPuppet = null;
				otherCollider = null;
				grabbed = false;
				nextGrabTime = Time.time + 1f;
			}
		}
	}
	public class Killing : MonoBehaviour
	{
		[Tooltip("Reference to the PuppetMaster component.")]
		public PuppetMaster puppetMaster;

		[Tooltip("Settings for killing and freezing the puppet.")]
		public PuppetMaster.StateSettings stateSettings = PuppetMaster.StateSettings.Default;

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.K))
			{
				puppetMaster.Kill(stateSettings);
			}
			if (Input.GetKeyDown(KeyCode.F))
			{
				puppetMaster.Freeze(stateSettings);
			}
			if (Input.GetKeyDown(KeyCode.R))
			{
				puppetMaster.Resurrect();
			}
		}
	}
	[RequireComponent(typeof(PuppetMaster))]
	public class LayerSetup : MonoBehaviour
	{
		[Header("References")]
		[Tooltip("Reference to the character controller gameobject (the one that has the capsule collider/CharacterController.")]
		public Transform characterController;

		[Header("Layers")]
		[Tooltip("The layer to assign the character controller to. Collisions between this layer and the 'Ragdoll Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		public int characterControllerLayer;

		[Tooltip("The layer to assign the PuppetMaster and all it's muscles to. Collisions between this layer and the 'Character Controller Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		public int ragdollLayer;

		[Tooltip("Layers that will be ignored by the character controller")]
		public LayerMask ignoreCollisionWithCharacterController;

		[Tooltip("Layers that will not collide with the Ragdoll layer.")]
		public LayerMask ignoreCollisionWithRagdoll;

		private PuppetMaster puppetMaster;

		private void Awake()
		{
			puppetMaster = GetComponent<PuppetMaster>();
			puppetMaster.gameObject.layer = ragdollLayer;
			Muscle[] muscles = puppetMaster.muscles;
			for (int i = 0; i < muscles.Length; i++)
			{
				muscles[i].joint.gameObject.layer = ragdollLayer;
			}
			characterController.gameObject.layer = characterControllerLayer;
			Physics.IgnoreLayerCollision(characterControllerLayer, ragdollLayer);
			Physics.IgnoreLayerCollision(characterControllerLayer, characterControllerLayer);
			int[] array = ignoreCollisionWithCharacterController.MaskToNumbers();
			foreach (int layer in array)
			{
				Physics.IgnoreLayerCollision(characterControllerLayer, layer);
			}
			array = ignoreCollisionWithRagdoll.MaskToNumbers();
			foreach (int layer2 in array)
			{
				Physics.IgnoreLayerCollision(ragdollLayer, layer2);
			}
			UnityEngine.Object.Destroy(this);
		}
	}
	public class Planet : MonoBehaviour
	{
		public float mass = 1000f;

		public Rigidbody[] rigidbodies;

		private const float G = 6.672E-11f;

		private void Start()
		{
			rigidbodies = UnityEngine.Object.FindObjectsOfType<Rigidbody>();
			Rigidbody[] array = rigidbodies;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].useGravity = false;
			}
		}

		private void FixedUpdate()
		{
			Rigidbody[] array = rigidbodies;
			foreach (Rigidbody rigidbody in array)
			{
				if (!rigidbody.isKinematic)
				{
					ApplyGravity(rigidbody);
				}
			}
		}

		private void ApplyGravity(Rigidbody r)
		{
			Vector3 vector = base.transform.position - r.position;
			float sqrMagnitude = vector.sqrMagnitude;
			float num = Mathf.Sqrt(sqrMagnitude);
			r.velocity += vector / num * 6.672E-11f * (mass / sqrMagnitude) * Time.fixedDeltaTime;
		}
	}
	public class PropDemo : MonoBehaviour
	{
		[Tooltip("The Prop you wish to pick up.")]
		public Prop prop;

		[Tooltip("The PropRoot of the left hand.")]
		public PropRoot propRootLeft;

		[Tooltip("The PropRoot of the right hand.")]
		public PropRoot propRootRight;

		[Tooltip("If true, the prop will be picked up when PuppetMaster initiates")]
		public bool pickUpOnStart;

		private bool right = true;

		private PropRoot connectTo
		{
			get
			{
				if (!right)
				{
					return propRootLeft;
				}
				return propRootRight;
			}
		}

		private void Start()
		{
			if (pickUpOnStart)
			{
				connectTo.currentProp = prop;
			}
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.P))
			{
				connectTo.currentProp = prop;
			}
			if (Input.GetKeyDown(KeyCode.X))
			{
				connectTo.currentProp = null;
			}
			if (Input.GetKeyDown(KeyCode.S))
			{
				connectTo.DropImmediate();
				right = !right;
				connectTo.currentProp = prop;
			}
		}
	}
	public class PropMelee : Prop
	{
		[LargeHeader("Melee")]
		[Tooltip("Switch to a CapsuleCollider when the prop is picked up so it behaves more smoothly when colliding with objects.")]
		public CapsuleCollider capsuleCollider;

		[Tooltip("The default BoxCollider used when this prop is not picked up.")]
		public BoxCollider boxCollider;

		[Tooltip("Temporarily increase the radius of the capsule collider when a hitting action is triggered, so it would not pass colliders too easily.")]
		public float actionColliderRadiusMlp = 1f;

		[Tooltip("Temporarily set (increase) the pin weight of the additional pin when a hitting action is triggered.")]
		[Range(0f, 1f)]
		public float actionAdditionalPinWeight = 1f;

		[Tooltip("Temporarily increase the mass of the Rigidbody when a hitting action is triggered.")]
		[Range(0.1f, 10f)]
		public float actionMassMlp = 1f;

		[Tooltip("Offset to the default center of mass of the Rigidbody (might improve prop handling).")]
		public Vector3 COMOffset;

		private float defaultColliderRadius;

		private float defaultMass;

		private float defaultAddMass;

		private Rigidbody r;

		public void StartAction(float duration)
		{
			StopAllCoroutines();
			StartCoroutine(Action(duration));
		}

		public IEnumerator Action(float duration)
		{
			capsuleCollider.radius = defaultColliderRadius * actionColliderRadiusMlp;
			r.mass = defaultMass * actionMassMlp;
			int additionalPinMuscleIndex = ((additionalPinTarget != null) ? base.propRoot.puppetMaster.GetMuscleIndex(additionalPinTarget) : (-1));
			if (additionalPinMuscleIndex != -1)
			{
				base.propRoot.puppetMaster.muscles[additionalPinMuscleIndex].props.pinWeight = actionAdditionalPinWeight;
			}
			yield return new WaitForSeconds(duration);
			capsuleCollider.radius = defaultColliderRadius;
			r.mass = defaultMass;
			if (additionalPinMuscleIndex != -1)
			{
				base.propRoot.puppetMaster.muscles[additionalPinMuscleIndex].props.pinWeight = additionalPinWeight;
			}
		}

		protected override void OnStart()
		{
			defaultColliderRadius = capsuleCollider.radius;
			r = muscle.GetComponent<Rigidbody>();
			r.centerOfMass += COMOffset;
			defaultMass = r.mass;
		}

		protected override void OnPickUp(PropRoot propRoot)
		{
			capsuleCollider.radius = defaultColliderRadius;
			r.mass = defaultMass;
			capsuleCollider.enabled = true;
			boxCollider.enabled = false;
			StopAllCoroutines();
		}

		protected override void OnDrop()
		{
			capsuleCollider.radius = defaultColliderRadius;
			r.mass = defaultMass;
			capsuleCollider.enabled = false;
			boxCollider.enabled = true;
			StopAllCoroutines();
		}
	}
	public class PropPickUpTrigger : MonoBehaviour
	{
		public Prop prop;

		public LayerMask characterLayers;

		private CharacterPuppet characterPuppet;

		private void OnTriggerEnter(Collider collider)
		{
			if (!prop.isPickedUp && LayerMaskExtensions.Contains(characterLayers, collider.gameObject.layer))
			{
				characterPuppet = collider.GetComponent<CharacterPuppet>();
				if (!(characterPuppet == null) && characterPuppet.puppet.state == BehaviourPuppet.State.Puppet && !(characterPuppet.propRoot == null) && !(characterPuppet.propRoot.currentProp != null))
				{
					characterPuppet.propRoot.currentProp = prop;
				}
			}
		}
	}
	public class PuppetBoard : MonoBehaviour
	{
		[Tooltip("Board target Rigidbody.")]
		public Rigidbody target;

		[Tooltip("Pivot Transform of the body target.")]
		public Transform bodyTargetPivot;

		[Tooltip("The body target keeps the puppet upright by a SpringJoint connected to the body.")]
		public Transform bodyTarget;

		private Rigidbody r;

		private void Start()
		{
			r = GetComponent<Rigidbody>();
			Physics.IgnoreLayerCollision(base.gameObject.layer, target.gameObject.layer, ignore: true);
		}

		private void FixedUpdate()
		{
			r.MovePosition(target.position);
			r.MoveRotation(target.rotation);
			r.velocity = target.velocity;
			r.angularVelocity = target.angularVelocity;
			Quaternion quaternion = Quaternion.FromToRotation(bodyTarget.position - base.transform.position, Vector3.up);
			bodyTargetPivot.rotation = quaternion * bodyTarget.rotation;
		}
	}
	public class PuppetScaling : MonoBehaviour
	{
		public PuppetMaster puppetMaster;

		[Range(0.01f, 10f)]
		public float masterScale = 1f;

		public int muscleIndex;

		[Range(0.01f, 10f)]
		public float muscleScale = 1f;

		private float defaultMuscleSpring;

		private void Start()
		{
			puppetMaster.updateJointAnchors = true;
			puppetMaster.supportTranslationAnimation = true;
			defaultMuscleSpring = puppetMaster.muscleSpring;
		}

		private void Update()
		{
			puppetMaster.transform.parent.localScale = Vector3.one * masterScale;
			puppetMaster.muscleSpring = defaultMuscleSpring * Mathf.Pow(masterScale, 2f);
			muscleIndex = Mathf.Clamp(muscleIndex, 0, puppetMaster.muscles.Length - 1);
			for (int i = 0; i < puppetMaster.muscles.Length; i++)
			{
				if (i == muscleIndex)
				{
					puppetMaster.muscles[i].target.localScale = Vector3.one * muscleScale;
					puppetMaster.muscles[i].transform.localScale = Vector3.one * muscleScale;
				}
				else
				{
					puppetMaster.muscles[i].target.localScale = Vector3.one;
					puppetMaster.muscles[i].transform.localScale = Vector3.one;
				}
			}
			if (puppetMaster.muscles[1].transform.parent == puppetMaster.transform)
			{
				for (int j = 0; j < puppetMaster.muscles[muscleIndex].childIndexes.Length; j++)
				{
					puppetMaster.muscles[puppetMaster.muscles[muscleIndex].childIndexes[j]].transform.localScale = Vector3.one * muscleScale;
				}
			}
		}
	}
	public class RaycastShooter : MonoBehaviour
	{
		public LayerMask layers;

		public float unpin = 10f;

		public float force = 10f;

		public ParticleSystem blood;

		private void Update()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo = default(RaycastHit);
			if (Physics.Raycast(ray, out hitInfo, 100f, layers))
			{
				MuscleCollisionBroadcaster component = hitInfo.collider.attachedRigidbody.GetComponent<MuscleCollisionBroadcaster>();
				if (component != null)
				{
					component.Hit(unpin, ray.direction * force, hitInfo.point);
					blood.transform.position = hitInfo.point;
					blood.transform.rotation = Quaternion.LookRotation(-ray.direction);
					blood.Emit(5);
				}
			}
		}
	}
	public class Respawning : MonoBehaviour
	{
		[Tooltip("Pooled characters will be parented to this deactivated GameObject.")]
		public Transform pool;

		[Tooltip("Reference to the BehaviourPuppet component of the character you wish to respawn.")]
		public BehaviourPuppet puppet;

		[Tooltip("The animation to play on respawn.")]
		public string idleAnimation;

		private Transform puppetRoot;

		private bool isPooled => puppet.transform.root == pool;

		private void Start()
		{
			puppetRoot = puppet.transform.root;
			pool.gameObject.SetActive(value: false);
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				puppet.puppetMaster.state = PuppetMaster.State.Alive;
			}
			if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				puppet.puppetMaster.state = PuppetMaster.State.Dead;
			}
			if (Input.GetKeyDown(KeyCode.Alpha3))
			{
				puppet.puppetMaster.state = PuppetMaster.State.Frozen;
			}
			if (Input.GetKeyDown(KeyCode.P) && !isPooled)
			{
				Pool();
			}
			if (Input.GetKeyDown(KeyCode.R))
			{
				Vector2 vector = UnityEngine.Random.insideUnitCircle * 2f;
				Respawn(new Vector3(vector.x, 0f, vector.y), Quaternion.LookRotation(new Vector3(0f - vector.x, 0f, 0f - vector.y)));
			}
		}

		private void Pool()
		{
			puppetRoot.parent = pool;
		}

		private void Respawn(Vector3 position, Quaternion rotation)
		{
			puppet.puppetMaster.state = PuppetMaster.State.Alive;
			puppet.puppetMaster.targetAnimator.Play(idleAnimation, 0, 0f);
			puppet.SetState(BehaviourPuppet.State.Puppet);
			puppet.puppetMaster.Teleport(position, rotation, moveToTarget: true);
			puppetRoot.parent = null;
		}
	}
	public class RotateShoulderToTarget : MonoBehaviour
	{
		public Transform shoulder;

		public Vector3 euler;

		private void OnPuppetMasterRead()
		{
			shoulder.rotation = Quaternion.Euler(euler) * shoulder.rotation;
		}
	}
	public class SkeletonShooter : MonoBehaviour
	{
		public MuscleRemoveMode removeMuscleMode;

		public LayerMask layers;

		public float unpin = 10f;

		public float force = 10f;

		public ParticleSystem particles;

		private void Update()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo = default(RaycastHit);
			if (!Physics.Raycast(ray, out hitInfo, 100f, layers))
			{
				return;
			}
			MuscleCollisionBroadcaster component = hitInfo.collider.attachedRigidbody.GetComponent<MuscleCollisionBroadcaster>();
			if (component != null)
			{
				component.Hit(unpin, ray.direction * force, hitInfo.point);
				component.puppetMaster.RemoveMuscleRecursive(component.puppetMaster.muscles[component.muscleIndex].joint, attachTarget: true, blockTargetAnimation: true, removeMuscleMode);
			}
			else
			{
				ConfigurableJoint component2 = hitInfo.collider.attachedRigidbody.GetComponent<ConfigurableJoint>();
				if (component2 != null)
				{
					UnityEngine.Object.Destroy(component2);
				}
				hitInfo.collider.attachedRigidbody.AddForceAtPosition(ray.direction * force, hitInfo.point);
			}
			particles.transform.position = hitInfo.point;
			particles.transform.rotation = Quaternion.LookRotation(-ray.direction);
			particles.Emit(5);
		}
	}
	public class UserControlAIMelee : UserControlThirdPerson
	{
		public BehaviourPuppet targetPuppet;

		public float stoppingDistance = 0.5f;

		public float stoppingThreshold = 1.5f;

		private bool isAttacking;

		private float attackTimer;

		private Transform moveTarget => targetPuppet.puppetMaster.muscles[0].joint.transform;

		protected override void Update()
		{
			float num = (walkByDefault ? 0.5f : 1f);
			Vector3 vector = moveTarget.position - base.transform.position;
			vector.y = 0f;
			float num2 = ((state.move != Vector3.zero) ? stoppingDistance : (stoppingDistance * stoppingThreshold));
			state.move = ((vector.magnitude > num2) ? (vector.normalized * num) : Vector3.zero);
			state.lookPos = moveTarget.position + base.transform.right * -0.2f;
			if (CanAttack())
			{
				attackTimer += Time.deltaTime;
			}
			else
			{
				attackTimer = 0f;
			}
			state.actionIndex = ((attackTimer > 0.5f) ? 1 : 0);
		}

		private bool CanAttack()
		{
			if (targetPuppet.state == BehaviourPuppet.State.Unpinned)
			{
				return false;
			}
			Vector3 vector = state.lookPos - base.transform.position;
			vector = Quaternion.Inverse(base.transform.rotation) * vector;
			if (Mathf.Atan2(vector.x, vector.z) * 57.29578f > 20f)
			{
				return false;
			}
			return state.move == Vector3.zero;
		}
	}
	public class UserControlMelee : UserControlThirdPerson
	{
		public KeyCode hitKey;

		protected override void Update()
		{
			base.Update();
			state.actionIndex = (Input.GetKey(hitKey) ? 1 : 0);
		}
	}
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		public bool smoothFollow = true;

		public float smoothFollowSpeed = 20f;

		protected bool animatePhysics;

		private Vector3 lastPosition;

		private Vector3 localPosition;

		private Quaternion localRotation;

		private Quaternion lastRotation;

		public virtual bool animationGrounded => true;

		public virtual Vector3 GetPivotPoint()
		{
			return base.transform.position;
		}

		public float GetAngleFromForward(Vector3 worldDirection)
		{
			Vector3 vector = base.transform.InverseTransformDirection(worldDirection);
			return Mathf.Atan2(vector.x, vector.z) * 57.29578f;
		}

		protected virtual void Start()
		{
			if (base.transform.parent.GetComponent<CharacterBase>() == null)
			{
				UnityEngine.Debug.LogWarning("Animation controllers should be parented to character controllers!", base.transform);
			}
			lastPosition = base.transform.position;
			localPosition = base.transform.parent.InverseTransformPoint(base.transform.position);
			lastRotation = base.transform.rotation;
			localRotation = Quaternion.Inverse(base.transform.parent.rotation) * base.transform.rotation;
		}

		protected virtual void LateUpdate()
		{
			if (!animatePhysics)
			{
				SmoothFollow();
			}
		}

		protected virtual void FixedUpdate()
		{
			if (animatePhysics)
			{
				SmoothFollow();
			}
		}

		private void SmoothFollow()
		{
			if (smoothFollow)
			{
				base.transform.position = Vector3.Lerp(lastPosition, base.transform.parent.TransformPoint(localPosition), Time.deltaTime * smoothFollowSpeed);
				base.transform.rotation = Quaternion.Lerp(lastRotation, base.transform.parent.rotation * localRotation, Time.deltaTime * smoothFollowSpeed);
			}
			lastPosition = base.transform.position;
			lastRotation = base.transform.rotation;
		}
	}
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[SerializeField]
		private CharacterThirdPerson characterController;

		[SerializeField]
		private float pivotOffset;

		[SerializeField]
		private AnimationCurve moveSpeed;

		private Animator animator;

		protected override void Start()
		{
			base.Start();
			animator = GetComponentInChildren<Animator>();
		}

		public override Vector3 GetPivotPoint()
		{
			if (pivotOffset == 0f)
			{
				return base.transform.position;
			}
			return base.transform.position + base.transform.forward * pivotOffset;
		}

		private void Update()
		{
			float num = moveSpeed.Evaluate(characterController.animState.moveDirection.z);
			animator.SetFloat("Speed", num);
			characterController.Move(characterController.transform.forward * Time.deltaTime * num, Quaternion.identity);
		}
	}
	[RequireComponent(typeof(Animator))]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		public CharacterThirdPerson characterController;

		[SerializeField]
		private float turnSensitivity = 0.2f;

		[SerializeField]
		private float turnSpeed = 5f;

		[SerializeField]
		private float runCycleLegOffset = 0.2f;

		[Range(0.1f, 3f)]
		[SerializeField]
		private float animSpeedMultiplier = 1f;

		protected Animator animator;

		private Vector3 lastForward;

		private const string groundedDirectional = "Grounded Directional";

		private const string groundedStrafe = "Grounded Strafe";

		private float deltaAngle;

		public override bool animationGrounded
		{
			get
			{
				if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Grounded Directional"))
				{
					return animator.GetCurrentAnimatorStateInfo(0).IsName("Grounded Strafe");
				}
				return true;
			}
		}

		protected override void Start()
		{
			base.Start();
			animator = GetComponent<Animator>();
			lastForward = base.transform.forward;
		}

		public override Vector3 GetPivotPoint()
		{
			return animator.pivotPosition;
		}

		protected virtual void Update()
		{
			if (Time.deltaTime != 0f)
			{
				animatePhysics = animator.updateMode == AnimatorUpdateMode.AnimatePhysics;
				if (characterController.animState.jump)
				{
					float value = (float)((Mathf.Repeat(animator.GetCurrentAnimatorStateInfo(0).normalizedTime + runCycleLegOffset, 1f) < 0f) ? 1 : (-1)) * characterController.animState.moveDirection.z;
					animator.SetFloat("JumpLeg", value);
				}
				float num = 0f - GetAngleFromForward(lastForward) - deltaAngle;
				deltaAngle = 0f;
				lastForward = base.transform.forward;
				num *= turnSensitivity * 0.01f;
				num = Mathf.Clamp(num / Time.deltaTime, -1f, 1f);
				animator.SetFloat("Turn", Mathf.Lerp(animator.GetFloat("Turn"), num, Time.deltaTime * turnSpeed));
				animator.SetFloat("Forward", characterController.animState.moveDirection.z);
				animator.SetFloat("Right", characterController.animState.moveDirection.x);
				animator.SetBool("Crouch", characterController.animState.crouch);
				animator.SetBool("OnGround", characterController.animState.onGround);
				animator.SetBool("IsStrafing", characterController.animState.isStrafing);
				if (!characterController.animState.onGround)
				{
					animator.SetFloat("Jump", characterController.animState.yVelocity);
				}
				if (characterController.animState.onGround && characterController.animState.moveDirection.z > 0f)
				{
					animator.speed = animSpeedMultiplier;
				}
				else
				{
					animator.speed = 1f;
				}
			}
		}

		private void OnAnimatorMove()
		{
			Vector3 vector = animator.deltaRotation * Vector3.forward;
			deltaAngle += Mathf.Atan2(vector.x, vector.z) * 57.29578f;
			characterController.Move(animator.deltaPosition, animator.deltaRotation);
		}
	}
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		[SerializeField]
		protected float gravityMultiplier = 2f;

		[SerializeField]
		protected float airborneThreshold = 0.6f;

		[SerializeField]
		private float slopeStartAngle = 50f;

		[SerializeField]
		private float slopeEndAngle = 85f;

		[SerializeField]
		private float spherecastRadius = 0.1f;

		[SerializeField]
		private LayerMask groundLayers;

		private PhysicMaterial zeroFrictionMaterial;

		private PhysicMaterial highFrictionMaterial;

		protected Rigidbody r;

		protected const float half = 0.5f;

		protected float originalHeight;

		protected Vector3 originalCenter;

		protected CapsuleCollider capsule;

		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		protected Vector3 GetGravity()
		{
			if (gravityTarget != null)
			{
				return (gravityTarget.position - base.transform.position).normalized * Physics.gravity.magnitude;
			}
			return Physics.gravity;
		}

		protected virtual void Start()
		{
			capsule = GetComponent<Collider>() as CapsuleCollider;
			r = GetComponent<Rigidbody>();
			originalHeight = capsule.height;
			originalCenter = capsule.center;
			zeroFrictionMaterial = new PhysicMaterial();
			zeroFrictionMaterial.dynamicFriction = 0f;
			zeroFrictionMaterial.staticFriction = 0f;
			zeroFrictionMaterial.frictionCombine = PhysicMaterialCombine.Minimum;
			zeroFrictionMaterial.bounciness = 0f;
			zeroFrictionMaterial.bounceCombine = PhysicMaterialCombine.Minimum;
			highFrictionMaterial = new PhysicMaterial();
			r.constraints = RigidbodyConstraints.FreezeRotation;
		}

		protected virtual RaycastHit GetSpherecastHit()
		{
			Vector3 up = base.transform.up;
			Ray ray = new Ray(r.position + up * airborneThreshold, -up);
			RaycastHit hitInfo = new RaycastHit
			{
				point = base.transform.position - base.transform.transform.up * airborneThreshold,
				normal = base.transform.up
			};
			Physics.SphereCast(ray, spherecastRadius, out hitInfo, airborneThreshold * 2f, groundLayers);
			return hitInfo;
		}

		public float GetAngleFromForward(Vector3 worldDirection)
		{
			Vector3 vector = base.transform.InverseTransformDirection(worldDirection);
			return Mathf.Atan2(vector.x, vector.z) * 57.29578f;
		}

		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
			Quaternion quaternion = Quaternion.AngleAxis(angle, axis);
			Vector3 vector = base.transform.position - point;
			r.MovePosition(point + quaternion * vector);
			r.MoveRotation(quaternion * base.transform.rotation);
		}

		protected void ScaleCapsule(float mlp)
		{
			if (capsule.height != originalHeight * mlp)
			{
				capsule.height = Mathf.MoveTowards(capsule.height, originalHeight * mlp, Time.deltaTime * 4f);
				capsule.center = Vector3.MoveTowards(capsule.center, originalCenter * mlp, Time.deltaTime * 2f);
			}
		}

		protected void HighFriction()
		{
			capsule.material = highFrictionMaterial;
		}

		protected void ZeroFriction()
		{
			capsule.material = zeroFrictionMaterial;
		}

		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			float num = 90f - Vector3.Angle(velocity, groundNormal);
			num -= slopeStartAngle;
			float num2 = slopeEndAngle - slopeStartAngle;
			return 1f - Mathf.Clamp(num / num2, 0f, 1f);
		}
	}
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		public enum MoveMode
		{
			Directional,
			Strafe
		}

		public struct AnimState
		{
			public Vector3 moveDirection;

			public bool jump;

			public bool crouch;

			public bool onGround;

			public bool isStrafing;

			public float yVelocity;
		}

		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		public UserControlThirdPerson userControl;

		public CameraController cam;

		[Header("Movement")]
		public MoveMode moveMode;

		public bool smoothPhysics = true;

		public float smoothAccelerationTime = 0.2f;

		public float linearAccelerationSpeed = 3f;

		public float platformFriction = 7f;

		public float groundStickyEffect = 4f;

		public float maxVerticalVelocityOnGround = 3f;

		public float velocityToGroundTangentWeight;

		[Header("Rotation")]
		public bool lookInCameraDirection;

		public float turnSpeed = 5f;

		public float stationaryTurnSpeedMlp = 1f;

		[Header("Jumping and Falling")]
		public float airSpeed = 6f;

		public float airControl = 2f;

		public float jumpPower = 12f;

		public float jumpRepeatDelayTime;

		[Header("Wall Running")]
		[SerializeField]
		private LayerMask wallRunLayers;

		public float wallRunMaxLength = 1f;

		public float wallRunMinMoveMag = 0.6f;

		public float wallRunMinVelocityY = -1f;

		public float wallRunRotationSpeed = 1.5f;

		public float wallRunMaxRotationAngle = 70f;

		public float wallRunWeightSpeed = 5f;

		[Header("Crouching")]
		public float crouchCapsuleScaleMlp = 0.6f;

		public AnimState animState;

		protected Vector3 moveDirection;

		private Animator animator;

		private Vector3 normal;

		private Vector3 platformVelocity;

		private Vector3 platformAngularVelocity;

		private RaycastHit hit;

		private float jumpLeg;

		private float jumpEndTime;

		private float forwardMlp;

		private float groundDistance;

		private float lastAirTime;

		private float stickyForce;

		private Vector3 wallNormal = Vector3.up;

		private Vector3 moveDirectionVelocity;

		private float wallRunWeight;

		private float lastWallRunWeight;

		private Vector3 fixedDeltaPosition;

		private Quaternion fixedDeltaRotation = Quaternion.identity;

		private bool fixedFrame;

		private float wallRunEndTime;

		private Vector3 gravity;

		private Vector3 verticalVelocity;

		private float velocityY;

		public bool onGround { get; private set; }

		protected override void Start()
		{
			base.Start();
			animator = GetComponent<Animator>();
			if (animator == null)
			{
				animator = characterAnimation.GetComponent<Animator>();
			}
			wallNormal = -gravity.normalized;
			onGround = true;
			animState.onGround = true;
			if (cam != null)
			{
				cam.enabled = false;
			}
		}

		private void OnAnimatorMove()
		{
			Move(animator.deltaPosition, animator.deltaRotation);
		}

		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
			fixedDeltaPosition += deltaPosition;
			fixedDeltaRotation *= deltaRotation;
		}

		private void FixedUpdate()
		{
			gravity = GetGravity();
			verticalVelocity = V3Tools.ExtractVertical(r.velocity, gravity, 1f);
			velocityY = verticalVelocity.magnitude;
			if (Vector3.Dot(verticalVelocity, gravity) > 0f)
			{
				velocityY = 0f - velocityY;
			}
			r.interpolation = (smoothPhysics ? RigidbodyInterpolation.Interpolate : RigidbodyInterpolation.None);
			characterAnimation.smoothFollow = smoothPhysics;
			MoveFixed(fixedDeltaPosition);
			fixedDeltaPosition = Vector3.zero;
			r.MoveRotation(base.transform.rotation * fixedDeltaRotation);
			fixedDeltaRotation = Quaternion.identity;
			Rotate();
			GroundCheck();
			if (userControl.state.move == Vector3.zero && groundDistance < airborneThreshold * 0.5f)
			{
				HighFriction();
			}
			else
			{
				ZeroFriction();
			}
			bool flag = onGround && userControl.state.move == Vector3.zero && r.velocity.magnitude < 0.5f && groundDistance < airborneThreshold * 0.5f;
			if (gravityTarget != null)
			{
				r.useGravity = false;
				if (!flag)
				{
					r.AddForce(gravity);
				}
			}
			if (flag)
			{
				r.useGravity = false;
				r.velocity = Vector3.zero;
			}
			else if (gravityTarget == null)
			{
				r.useGravity = true;
			}
			if (onGround)
			{
				animState.jump = Jump();
			}
			else
			{
				r.AddForce(gravity * gravityMultiplier);
			}
			ScaleCapsule(userControl.state.crouch ? crouchCapsuleScaleMlp : 1f);
			fixedFrame = true;
		}

		protected virtual void Update()
		{
			animState.onGround = onGround;
			animState.moveDirection = GetMoveDirection();
			animState.yVelocity = Mathf.Lerp(animState.yVelocity, velocityY, Time.deltaTime * 10f);
			animState.crouch = userControl.state.crouch;
			animState.isStrafing = moveMode == MoveMode.Strafe;
		}

		protected virtual void LateUpdate()
		{
			if (!(cam == null))
			{
				cam.UpdateInput();
				if (fixedFrame || r.interpolation != 0)
				{
					cam.UpdateTransform((r.interpolation == RigidbodyInterpolation.None) ? Time.fixedDeltaTime : Time.deltaTime);
					fixedFrame = false;
				}
			}
		}

		private void MoveFixed(Vector3 deltaPosition)
		{
			WallRun();
			Vector3 vector = deltaPosition / Time.deltaTime;
			vector += V3Tools.ExtractHorizontal(platformVelocity, gravity, 1f);
			if (onGround)
			{
				if (velocityToGroundTangentWeight > 0f)
				{
					Quaternion b = Quaternion.FromToRotation(base.transform.up, normal);
					vector = Quaternion.Lerp(Quaternion.identity, b, velocityToGroundTangentWeight) * vector;
				}
			}
			else
			{
				Vector3 b2 = V3Tools.ExtractHorizontal(userControl.state.move * airSpeed, gravity, 1f);
				vector = Vector3.Lerp(r.velocity, b2, Time.deltaTime * airControl);
			}
			if (onGround && Time.time > jumpEndTime)
			{
				r.velocity -= base.transform.up * stickyForce * Time.deltaTime;
			}
			Vector3 vector2 = V3Tools.ExtractVertical(r.velocity, gravity, 1f);
			Vector3 vector3 = V3Tools.ExtractHorizontal(vector, gravity, 1f);
			if (onGround && Vector3.Dot(vector2, gravity) < 0f)
			{
				vector2 = Vector3.ClampMagnitude(vector2, maxVerticalVelocityOnGround);
			}
			r.velocity = vector3 + vector2;
			float b3 = ((!onGround) ? 1f : GetSlopeDamper(-deltaPosition / Time.deltaTime, normal));
			forwardMlp = Mathf.Lerp(forwardMlp, b3, Time.deltaTime * 5f);
		}

		private void WallRun()
		{
			bool flag = CanWallRun();
			if (wallRunWeight > 0f && !flag)
			{
				wallRunEndTime = Time.time;
			}
			if (Time.time < wallRunEndTime + 0.5f)
			{
				flag = false;
			}
			wallRunWeight = Mathf.MoveTowards(wallRunWeight, flag ? 1f : 0f, Time.deltaTime * wallRunWeightSpeed);
			if (wallRunWeight <= 0f && lastWallRunWeight > 0f)
			{
				Vector3 forward = V3Tools.ExtractHorizontal(base.transform.forward, gravity, 1f);
				base.transform.rotation = Quaternion.LookRotation(forward, -gravity);
				wallNormal = -gravity.normalized;
			}
			lastWallRunWeight = wallRunWeight;
			if (!(wallRunWeight <= 0f))
			{
				if (onGround && velocityY < 0f)
				{
					r.velocity = V3Tools.ExtractHorizontal(r.velocity, gravity, 1f);
				}
				Vector3 vector = V3Tools.ExtractHorizontal(base.transform.forward, gravity, 1f);
				RaycastHit hitInfo = default(RaycastHit);
				hitInfo.normal = -gravity.normalized;
				Physics.Raycast(onGround ? base.transform.position : capsule.bounds.center, vector, out hitInfo, 3f, wallRunLayers);
				wallNormal = Vector3.Lerp(wallNormal, hitInfo.normal, Time.deltaTime * wallRunRotationSpeed);
				wallNormal = Vector3.RotateTowards(-gravity.normalized, wallNormal, wallRunMaxRotationAngle * ((float)Math.PI / 180f), 0f);
				Vector3 tangent = base.transform.forward;
				Vector3 vector2 = wallNormal;
				Vector3.OrthoNormalize(ref vector2, ref tangent);
				base.transform.rotation = Quaternion.Slerp(Quaternion.LookRotation(vector, -gravity), Quaternion.LookRotation(tangent, wallNormal), wallRunWeight);
			}
		}

		private bool CanWallRun()
		{
			if (Time.time < jumpEndTime - 0.1f)
			{
				return false;
			}
			if (Time.time > jumpEndTime - 0.1f + wallRunMaxLength)
			{
				return false;
			}
			if (velocityY < wallRunMinVelocityY)
			{
				return false;
			}
			if (userControl.state.move.magnitude < wallRunMinMoveMag)
			{
				return false;
			}
			return true;
		}

		private Vector3 GetMoveDirection()
		{
			switch (moveMode)
			{
			case MoveMode.Directional:
				moveDirection = Vector3.SmoothDamp(moveDirection, new Vector3(0f, 0f, userControl.state.move.magnitude), ref moveDirectionVelocity, smoothAccelerationTime);
				moveDirection = Vector3.MoveTowards(moveDirection, new Vector3(0f, 0f, userControl.state.move.magnitude), Time.deltaTime * linearAccelerationSpeed);
				return moveDirection * forwardMlp;
			case MoveMode.Strafe:
				moveDirection = Vector3.SmoothDamp(moveDirection, userControl.state.move, ref moveDirectionVelocity, smoothAccelerationTime);
				moveDirection = Vector3.MoveTowards(moveDirection, userControl.state.move, Time.deltaTime * linearAccelerationSpeed);
				return base.transform.InverseTransformDirection(moveDirection);
			default:
				return Vector3.zero;
			}
		}

		protected virtual void Rotate()
		{
			if (gravityTarget != null)
			{
				r.MoveRotation(Quaternion.FromToRotation(base.transform.up, base.transform.position - gravityTarget.position) * base.transform.rotation);
			}
			if (platformAngularVelocity != Vector3.zero)
			{
				r.MoveRotation(Quaternion.Euler(platformAngularVelocity) * base.transform.rotation);
			}
			float num = GetAngleFromForward(GetForwardDirection());
			if (userControl.state.move == Vector3.zero)
			{
				num *= (1.01f - Mathf.Abs(num) / 180f) * stationaryTurnSpeedMlp;
			}
			r.MoveRotation(Quaternion.AngleAxis(num * Time.deltaTime * turnSpeed, base.transform.up) * r.rotation);
		}

		private Vector3 GetForwardDirection()
		{
			bool flag = userControl.state.move != Vector3.zero;
			switch (moveMode)
			{
			case MoveMode.Directional:
				if (flag)
				{
					return userControl.state.move;
				}
				if (!lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return userControl.state.lookPos - r.position;
			case MoveMode.Strafe:
				if (flag)
				{
					return userControl.state.lookPos - r.position;
				}
				if (!lookInCameraDirection)
				{
					return base.transform.forward;
				}
				return userControl.state.lookPos - r.position;
			default:
				return Vector3.zero;
			}
		}

		protected virtual bool Jump()
		{
			if (!userControl.state.jump)
			{
				return false;
			}
			if (userControl.state.crouch)
			{
				return false;
			}
			if (!characterAnimation.animationGrounded)
			{
				return false;
			}
			if (Time.time < lastAirTime + jumpRepeatDelayTime)
			{
				return false;
			}
			onGround = false;
			jumpEndTime = Time.time + 0.1f;
			Vector3 velocity = userControl.state.move * airSpeed;
			r.velocity = velocity;
			r.velocity += base.transform.up * jumpPower;
			return true;
		}

		private void GroundCheck()
		{
			Vector3 b = Vector3.zero;
			platformAngularVelocity = Vector3.zero;
			float num = 0f;
			hit = GetSpherecastHit();
			normal = base.transform.up;
			groundDistance = Vector3.Project(r.position - hit.point, base.transform.up).magnitude;
			if (Time.time > jumpEndTime && velocityY < jumpPower * 0.5f)
			{
				bool num2 = onGround;
				onGround = false;
				float num3 = ((!num2) ? (airborneThreshold * 0.5f) : airborneThreshold);
				float magnitude = V3Tools.ExtractHorizontal(r.velocity, gravity, 1f).magnitude;
				if (groundDistance < num3)
				{
					num = groundStickyEffect * magnitude * num3;
					if (hit.rigidbody != null)
					{
						b = hit.rigidbody.GetPointVelocity(hit.point);
						platformAngularVelocity = Vector3.Project(hit.rigidbody.angularVelocity, base.transform.up);
					}
					onGround = true;
				}
			}
			platformVelocity = Vector3.Lerp(platformVelocity, b, Time.deltaTime * platformFriction);
			stickyForce = num;
			if (!onGround)
			{
				lastAirTime = Time.time;
			}
		}
	}
	[RequireComponent(typeof(Animator))]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		public enum RotationMode
		{
			Smooth,
			Linear
		}

		[Tooltip("The component that updates the camera.")]
		[SerializeField]
		private CameraController cameraController;

		[Tooltip("Acceleration of movement.")]
		[SerializeField]
		private float accelerationTime = 0.2f;

		[Tooltip("Turning speed.")]
		[SerializeField]
		private float turnTime = 0.2f;

		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		[SerializeField]
		private bool walkByDefault = true;

		[Tooltip("Smooth or linear rotation.")]
		[SerializeField]
		private RotationMode rotationMode;

		[Tooltip("Procedural motion speed (if not using root motion).")]
		[SerializeField]
		private float moveSpeed = 3f;

		private Animator animator;

		private float speed;

		private float angleVel;

		private float speedVel;

		private Vector3 linearTargetDirection;

		private CharacterController characterController;

		public bool isGrounded { get; private set; }

		private void Start()
		{
			animator = GetComponent<Animator>();
			characterController = GetComponent<CharacterController>();
			cameraController.enabled = false;
		}

		private void Update()
		{
			isGrounded = base.transform.position.y < 0.1f;
			Rotate();
			Move();
		}

		private void LateUpdate()
		{
			cameraController.UpdateInput();
			cameraController.UpdateTransform();
		}

		private void Rotate()
		{
			if (!isGrounded)
			{
				return;
			}
			Vector3 inputVector = GetInputVector();
			if (inputVector == Vector3.zero)
			{
				return;
			}
			Vector3 forward = base.transform.forward;
			switch (rotationMode)
			{
			case RotationMode.Smooth:
			{
				Vector3 vector = cameraController.transform.rotation * inputVector;
				float current = Mathf.Atan2(forward.x, forward.z) * 57.29578f;
				float target = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
				float angle = Mathf.SmoothDampAngle(current, target, ref angleVel, turnTime);
				base.transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
				break;
			}
			case RotationMode.Linear:
			{
				Vector3 inputVectorRaw = GetInputVectorRaw();
				if (inputVectorRaw != Vector3.zero)
				{
					linearTargetDirection = cameraController.transform.rotation * inputVectorRaw;
				}
				forward = Vector3.RotateTowards(forward, linearTargetDirection, Time.deltaTime * (1f / turnTime), 1f);
				forward.y = 0f;
				base.transform.rotation = Quaternion.LookRotation(forward);
				break;
			}
			}
		}

		private void Move()
		{
			float target = ((!walkByDefault) ? (Input.GetKey(KeyCode.LeftShift) ? 0.5f : 1f) : (Input.GetKey(KeyCode.LeftShift) ? 1f : 0.5f));
			speed = Mathf.SmoothDamp(speed, target, ref speedVel, accelerationTime);
			float num = GetInputVector().magnitude * speed;
			animator.SetFloat("Speed", num);
			if (!animator.hasRootMotion && isGrounded)
			{
				Vector3 vector = base.transform.forward * num * moveSpeed;
				if (characterController != null)
				{
					characterController.SimpleMove(vector);
				}
				else
				{
					base.transform.position += vector * Time.deltaTime;
				}
			}
		}

		private Vector3 GetInputVector()
		{
			Vector3 result = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
			result.z += Mathf.Abs(result.x) * 0.05f;
			result.x -= Mathf.Abs(result.z) * 0.05f;
			return result;
		}

		private Vector3 GetInputVectorRaw()
		{
			return new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
		}
	}
	public class UserControlAI : UserControlThirdPerson
	{
		public Transform moveTarget;

		public float stoppingDistance = 0.5f;

		public float stoppingThreshold = 1.5f;

		protected override void Update()
		{
			float num = (walkByDefault ? 0.5f : 1f);
			Vector3 tangent = moveTarget.position - base.transform.position;
			float magnitude = tangent.magnitude;
			Vector3 normal = base.transform.up;
			Vector3.OrthoNormalize(ref normal, ref tangent);
			float num2 = ((state.move != Vector3.zero) ? stoppingDistance : (stoppingDistance * stoppingThreshold));
			state.move = ((magnitude > num2) ? (tangent * num) : Vector3.zero);
		}
	}
	public class UserControlThirdPerson : MonoBehaviour
	{
		public struct State
		{
			public Vector3 move;

			public Vector3 lookPos;

			public bool crouch;

			public bool jump;

			public int actionIndex;
		}

		public bool walkByDefault;

		public bool canCrouch = true;

		public bool canJump = true;

		public State state;

		protected Transform cam;

		private void Start()
		{
			cam = Camera.main.transform;
		}

		protected virtual void Update()
		{
			state.crouch = canCrouch && Input.GetKey(KeyCode.C);
			state.jump = canJump && Input.GetButton("Jump");
			float axisRaw = Input.GetAxisRaw("Horizontal");
			float axisRaw2 = Input.GetAxisRaw("Vertical");
			Vector3 tangent = cam.rotation * new Vector3(axisRaw, 0f, axisRaw2).normalized;
			if (tangent != Vector3.zero)
			{
				Vector3 normal = base.transform.up;
				Vector3.OrthoNormalize(ref normal, ref tangent);
				state.move = tangent;
			}
			else
			{
				state.move = Vector3.zero;
			}
			bool key = Input.GetKey(KeyCode.LeftShift);
			float num = ((!walkByDefault) ? (key ? 0.5f : 1f) : (key ? 1f : 0.5f));
			state.move *= num;
			state.lookPos = base.transform.position + cam.forward * 100f;
		}
	}
	public class ApplicationQuit : MonoBehaviour
	{
		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Escape))
			{
				Application.Quit();
			}
		}
	}
	public class SlowMo : MonoBehaviour
	{
		[SerializeField]
		private KeyCode[] keyCodes;

		[SerializeField]
		private bool mouse0;

		[SerializeField]
		private bool mouse1;

		[SerializeField]
		private float slowMoTimeScale = 0.3f;

		private void Update()
		{
			Time.timeScale = (IsSlowMotion() ? slowMoTimeScale : 1f);
		}

		private bool IsSlowMotion()
		{
			if (mouse0 && Input.GetMouseButton(0))
			{
				return true;
			}
			if (mouse1 && Input.GetMouseButton(1))
			{
				return true;
			}
			for (int i = 0; i < keyCodes.Length; i++)
			{
				if (Input.GetKey(keyCodes[i]))
				{
					return true;
				}
			}
			return false;
		}
	}
}
namespace FMOD
{
	public class VERSION
	{
		public const int number = 69650;

		public const string dll = "fmod";
	}
	public class CONSTANTS
	{
		public const int MAX_CHANNEL_WIDTH = 32;

		public const int MAX_LISTENERS = 8;

		public const int REVERB_MAXINSTANCES = 4;

		public const int MAX_SYSTEMS = 8;
	}
	public enum RESULT
	{
		OK,
		ERR_BADCOMMAND,
		ERR_CHANNEL_ALLOC,
		ERR_CHANNEL_STOLEN,
		ERR_DMA,
		ERR_DSP_CONNECTION,
		ERR_DSP_DONTPROCESS,
		ERR_DSP_FORMAT,
		ERR_DSP_INUSE,
		ERR_DSP_NOTFOUND,
		ERR_DSP_RESERVED,
		ERR_DSP_SILENCE,
		ERR_DSP_TYPE,
		ERR_FILE_BAD,
		ERR_FILE_COULDNOTSEEK,
		ERR_FILE_DISKEJECTED,
		ERR_FILE_EOF,
		ERR_FILE_ENDOFDATA,
		ERR_FILE_NOTFOUND,
		ERR_FORMAT,
		ERR_HEADER_MISMATCH,
		ERR_HTTP,
		ERR_HTTP_ACCESS,
		ERR_HTTP_PROXY_AUTH,
		ERR_HTTP_SERVER_ERROR,
		ERR_HTTP_TIMEOUT,
		ERR_INITIALIZATION,
		ERR_INITIALIZED,
		ERR_INTERNAL,
		ERR_INVALID_FLOAT,
		ERR_INVALID_HANDLE,
		ERR_INVALID_PARAM,
		ERR_INVALID_POSITION,
		ERR_INVALID_SPEAKER,
		ERR_INVALID_SYNCPOINT,
		ERR_INVALID_THREAD,
		ERR_INVALID_VECTOR,
		ERR_MAXAUDIBLE,
		ERR_MEMORY,
		ERR_MEMORY_CANTPOINT,
		ERR_NEEDS3D,
		ERR_NEEDSHARDWARE,
		ERR_NET_CONNECT,
		ERR_NET_SOCKET_ERROR,
		ERR_NET_URL,
		ERR_NET_WOULD_BLOCK,
		ERR_NOTREADY,
		ERR_OUTPUT_ALLOCATED,
		ERR_OUTPUT_CREATEBUFFER,
		ERR_OUTPUT_DRIVERCALL,
		ERR_OUTPUT_FORMAT,
		ERR_OUTPUT_INIT,
		ERR_OUTPUT_NODRIVERS,
		ERR_PLUGIN,
		ERR_PLUGIN_MISSING,
		ERR_PLUGIN_RESOURCE,
		ERR_PLUGIN_VERSION,
		ERR_RECORD,
		ERR_REVERB_CHANNELGROUP,
		ERR_REVERB_INSTANCE,
		ERR_SUBSOUNDS,
		ERR_SUBSOUND_ALLOCATED,
		ERR_SUBSOUND_CANTMOVE,
		ERR_TAGNOTFOUND,
		ERR_TOOMANYCHANNELS,
		ERR_TRUNCATED,
		ERR_UNIMPLEMENTED,
		ERR_UNINITIALIZED,
		ERR_UNSUPPORTED,
		ERR_VERSION,
		ERR_EVENT_ALREADY_LOADED,
		ERR_EVENT_LIVEUPDATE_BUSY,
		ERR_EVENT_LIVEUPDATE_MISMATCH,
		ERR_EVENT_LIVEUPDATE_TIMEOUT,
		ERR_EVENT_NOTFOUND,
		ERR_STUDIO_UNINITIALIZED,
		ERR_STUDIO_NOT_LOADED,
		ERR_INVALID_STRING,
		ERR_ALREADY_LOCKED,
		ERR_NOT_LOCKED,
		ERR_RECORD_DISCONNECTED,
		ERR_TOOMANYSAMPLES
	}
	public enum CHANNELCONTROL_TYPE
	{
		CHANNEL,
		CHANNELGROUP
	}
	public struct VECTOR
	{
		public float x;

		public float y;

		public float z;
	}
	public struct ATTRIBUTES_3D
	{
		public VECTOR position;

		public VECTOR velocity;

		public VECTOR forward;

		public VECTOR up;
	}
	public struct ASYNCREADINFO
	{
		public IntPtr handle;

		public uint offset;

		public uint sizebytes;

		public int priority;

		public IntPtr userdata;

		public IntPtr buffer;

		public uint bytesread;

		public ASYNCREADINFO_DONE_CALLBACK done;
	}
	public enum OUTPUTTYPE
	{
		AUTODETECT,
		UNKNOWN,
		NOSOUND,
		WAVWRITER,
		NOSOUND_NRT,
		WAVWRITER_NRT,
		DSOUND,
		WINMM,
		WASAPI,
		ASIO,
		PULSEAUDIO,
		ALSA,
		COREAUDIO,
		XAUDIO,
		PS3,
		AUDIOTRACK,
		OPENSL,
		WIIU,
		AUDIOOUT,
		AUDIO3D,
		ATMOS,
		WEBAUDIO,
		NNAUDIO,
		WINSONIC,
		MAX
	}
	public enum DEBUG_MODE
	{
		TTY,
		FILE,
		CALLBACK
	}
	[Flags]
	public enum DEBUG_FLAGS : uint
	{
		NONE = 0u,
		ERROR = 1u,
		WARNING = 2u,
		LOG = 4u,
		TYPE_MEMORY = 0x100u,
		TYPE_FILE = 0x200u,
		TYPE_CODEC = 0x400u,
		TYPE_TRACE = 0x800u,
		DISPLAY_TIMESTAMPS = 0x10000u,
		DISPLAY_LINENUMBERS = 0x20000u,
		DISPLAY_THREAD = 0x40000u
	}
	[Flags]
	public enum MEMORY_TYPE : uint
	{
		NORMAL = 0u,
		STREAM_FILE = 1u,
		STREAM_DECODE = 2u,
		SAMPLEDATA = 4u,
		DSP_BUFFER = 8u,
		PLUGIN = 0x10u,
		XBOX360_PHYSICAL = 0x100000u,
		PERSISTENT = 0x200000u,
		SECONDARY = 0x400000u,
		ALL = uint.MaxValue
	}
	public enum SPEAKERMODE
	{
		DEFAULT,
		RAW,
		MONO,
		STEREO,
		QUAD,
		SURROUND,
		_5POINT1,
		_7POINT1,
		_7POINT1POINT4,
		MAX
	}
	public enum SPEAKER
	{
		FRONT_LEFT,
		FRONT_RIGHT,
		FRONT_CENTER,
		LOW_FREQUENCY,
		SURROUND_LEFT,
		SURROUND_RIGHT,
		BACK_LEFT,
		BACK_RIGHT,
		TOP_FRONT_LEFT,
		TOP_FRONT_RIGHT,
		TOP_BACK_LEFT,
		TOP_BACK_RIGHT,
		MAX
	}
	[Flags]
	public enum CHANNELMASK : uint
	{
		FRONT_LEFT = 1u,
		FRONT_RIGHT = 2u,
		FRONT_CENTER = 4u,
		LOW_FREQUENCY = 8u,
		SURROUND_LEFT = 0x10u,
		SURROUND_RIGHT = 0x20u,
		BACK_LEFT = 0x40u,
		BACK_RIGHT = 0x80u,
		BACK_CENTER = 0x100u,
		MONO = 1u,
		STEREO = 3u,
		LRC = 7u,
		QUAD = 0x33u,
		SURROUND = 0x37u,
		_5POINT1 = 0x3Fu,
		_5POINT1_REARS = 0xCFu,
		_7POINT0 = 0xF7u,
		_7POINT1 = 0xFFu
	}
	public enum CHANNELORDER
	{
		DEFAULT,
		WAVEFORMAT,
		PROTOOLS,
		ALLMONO,
		ALLSTEREO,
		ALSA,
		MAX
	}
	public enum PLUGINTYPE
	{
		OUTPUT,
		CODEC,
		DSP,
		MAX
	}
	public struct PLUGINLIST
	{
		private PLUGINTYPE type;

		private IntPtr description;
	}
	[Flags]
	public enum INITFLAGS : uint
	{
		NORMAL = 0u,
		STREAM_FROM_UPDATE = 1u,
		MIX_FROM_UPDATE = 2u,
		_3D_RIGHTHANDED = 4u,
		CHANNEL_LOWPASS = 0x100u,
		CHANNEL_DISTANCEFILTER = 0x200u,
		PROFILE_ENABLE = 0x10000u,
		VOL0_BECOMES_VIRTUAL = 0x20000u,
		GEOMETRY_USECLOSEST = 0x40000u,
		PREFER_DOLBY_DOWNMIX = 0x80000u,
		THREAD_UNSAFE = 0x100000u,
		PROFILE_METER_ALL = 0x200000u,
		DISABLE_SRS_HIGHPASSFILTER = 0x400000u
	}
	public enum SOUND_TYPE
	{
		UNKNOWN,
		AIFF,
		ASF,
		DLS,
		FLAC,
		FSB,
		IT,
		MIDI,
		MOD,
		MPEG,
		OGGVORBIS,
		PLAYLIST,
		RAW,
		S3M,
		USER,
		WAV,
		XM,
		XMA,
		AUDIOQUEUE,
		AT9,
		VORBIS,
		MEDIA_FOUNDATION,
		MEDIACODEC,
		FADPCM,
		MAX
	}
	public enum SOUND_FORMAT
	{
		NONE,
		PCM8,
		PCM16,
		PCM24,
		PCM32,
		PCMFLOAT,
		BITSTREAM,
		MAX
	}
	[Flags]
	public enum MODE : uint
	{
		DEFAULT = 0u,
		LOOP_OFF = 1u,
		LOOP_NORMAL = 2u,
		LOOP_BIDI = 4u,
		_2D = 8u,
		_3D = 0x10u,
		CREATESTREAM = 0x80u,
		CREATESAMPLE = 0x100u,
		CREATECOMPRESSEDSAMPLE = 0x200u,
		OPENUSER = 0x400u,
		OPENMEMORY = 0x800u,
		OPENMEMORY_POINT = 0x10000000u,
		OPENRAW = 0x1000u,
		OPENONLY = 0x2000u,
		ACCURATETIME = 0x4000u,
		MPEGSEARCH = 0x8000u,
		NONBLOCKING = 0x10000u,
		UNIQUE = 0x20000u,
		_3D_HEADRELATIVE = 0x40000u,
		_3D_WORLDRELATIVE = 0x80000u,
		_3D_INVERSEROLLOFF = 0x100000u,
		_3D_LINEARROLLOFF = 0x200000u,
		_3D_LINEARSQUAREROLLOFF = 0x400000u,
		_3D_INVERSETAPEREDROLLOFF = 0x800000u,
		_3D_CUSTOMROLLOFF = 0x4000000u,
		_3D_IGNOREGEOMETRY = 0x40000000u,
		IGNORETAGS = 0x2000000u,
		LOWMEM = 0x8000000u,
		LOADSECONDARYRAM = 0x20000000u,
		VIRTUAL_PLAYFROMSTART = 0x80000000u
	}
	public enum OPENSTATE
	{
		READY,
		LOADING,
		ERROR,
		CONNECTING,
		BUFFERING,
		SEEKING,
		PLAYING,
		SETPOSITION,
		MAX
	}
	public enum SOUNDGROUP_BEHAVIOR
	{
		BEHAVIOR_FAIL,
		BEHAVIOR_MUTE,
		BEHAVIOR_STEALLOWEST,
		MAX
	}
	public enum CHANNELCONTROL_CALLBACK_TYPE
	{
		END,
		VIRTUALVOICE,
		SYNCPOINT,
		OCCLUSION,
		MAX
	}
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct CHANNELCONTROL_DSP_INDEX
	{
		public const int HEAD = -1;

		public const int FADER = -2;

		public const int TAIL = -3;
	}
	public enum ERRORCALLBACK_INSTANCETYPE
	{
		NONE,
		SYSTEM,
		CHANNEL,
		CHANNELGROUP,
		CHANNELCONTROL,
		SOUND,
		SOUNDGROUP,
		DSP,
		DSPCONNECTION,
		GEOMETRY,
		REVERB3D,
		STUDIO_SYSTEM,
		STUDIO_EVENTDESCRIPTION,
		STUDIO_EVENTINSTANCE,
		STUDIO_PARAMETERINSTANCE,
		STUDIO_BUS,
		STUDIO_VCA,
		STUDIO_BANK,
		STUDIO_COMMANDREPLAY
	}
	public struct ERRORCALLBACK_INFO
	{
		public RESULT result;

		public ERRORCALLBACK_INSTANCETYPE instancetype;

		public IntPtr instance;

		public StringWrapper functionname;

		public StringWrapper functionparams;
	}
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		DEVICELISTCHANGED = 1u,
		DEVICELOST = 2u,
		MEMORYALLOCATIONFAILED = 4u,
		THREADCREATED = 8u,
		BADDSPCONNECTION = 0x10u,
		PREMIX = 0x20u,
		POSTMIX = 0x40u,
		ERROR = 0x80u,
		MIDMIX = 0x100u,
		THREADDESTROYED = 0x200u,
		PREUPDATE = 0x400u,
		POSTUPDATE = 0x800u,
		RECORDLISTCHANGED = 0x1000u,
		ALL = uint.MaxValue
	}
	public delegate RESULT ASYNCREADINFO_DONE_CALLBACK(IntPtr info, RESULT result);
	public delegate RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message);
	public delegate RESULT SYSTEM_CALLBACK(IntPtr systemraw, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata1, IntPtr commanddata2, IntPtr userdata);
	public delegate RESULT CHANNEL_CALLBACK(IntPtr channelraw, CHANNELCONTROL_TYPE controltype, CHANNELCONTROL_CALLBACK_TYPE type, IntPtr commanddata1, IntPtr commanddata2);
	public delegate RESULT SOUND_NONBLOCKCALLBACK(IntPtr soundraw, RESULT result);
	public delegate RESULT SOUND_PCMREADCALLBACK(IntPtr soundraw, IntPtr data, uint datalen);
	public delegate RESULT SOUND_PCMSETPOSCALLBACK(IntPtr soundraw, int subsound, uint position, TIMEUNIT postype);
	public delegate RESULT FILE_OPENCALLBACK(StringWrapper name, ref uint filesize, ref IntPtr handle, IntPtr userdata);
	public delegate RESULT FILE_CLOSECALLBACK(IntPtr handle, IntPtr userdata);
	public delegate RESULT FILE_READCALLBACK(IntPtr handle, IntPtr buffer, uint sizebytes, ref uint bytesread, IntPtr userdata);
	public delegate RESULT FILE_SEEKCALLBACK(IntPtr handle, uint pos, IntPtr userdata);
	public delegate RESULT FILE_ASYNCREADCALLBACK(IntPtr handle, IntPtr info, IntPtr userdata);
	public delegate RESULT FILE_ASYNCCANCELCALLBACK(IntPtr handle, IntPtr userdata);
	public delegate IntPtr MEMORY_ALLOC_CALLBACK(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	public delegate IntPtr MEMORY_REALLOC_CALLBACK(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	public delegate void MEMORY_FREE_CALLBACK(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	public delegate float CB_3D_ROLLOFFCALLBACK(IntPtr channelraw, float distance);
	public enum DSP_RESAMPLER
	{
		DEFAULT,
		NOINTERP,
		LINEAR,
		CUBIC,
		SPLINE,
		MAX
	}
	public enum DSPCONNECTION_TYPE
	{
		STANDARD,
		SIDECHAIN,
		SEND,
		SEND_SIDECHAIN,
		MAX
	}
	public enum TAGTYPE
	{
		UNKNOWN,
		ID3V1,
		ID3V2,
		VORBISCOMMENT,
		SHOUTCAST,
		ICECAST,
		ASF,
		MIDI,
		PLAYLIST,
		FMOD,
		USER,
		MAX
	}
	public enum TAGDATATYPE
	{
		BINARY,
		INT,
		FLOAT,
		STRING,
		STRING_UTF16,
		STRING_UTF16BE,
		STRING_UTF8,
		CDTOC,
		MAX
	}
	public struct TAG
	{
		public TAGTYPE type;

		public TAGDATATYPE datatype;

		public StringWrapper name;

		public IntPtr data;

		public uint datalen;

		public bool updated;
	}
	[Flags]
	public enum TIMEUNIT : uint
	{
		MS = 1u,
		PCM = 2u,
		PCMBYTES = 4u,
		RAWBYTES = 8u,
		PCMFRACTION = 0x10u,
		MODORDER = 0x100u,
		MODROW = 0x200u,
		MODPATTERN = 0x400u
	}
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct PORT_INDEX
	{
		public const ulong NONE = ulong.MaxValue;
	}
	public struct CREATESOUNDEXINFO
	{
		public int cbsize;

		public uint length;

		public uint fileoffset;

		public int numchannels;

		public int defaultfrequency;

		public SOUND_FORMAT format;

		public uint decodebuffersize;

		public int initialsubsound;

		public int numsubsounds;

		public IntPtr inclusionlist;

		public int inclusionlistnum;

		public IntPtr pcmreadcallback_handle;

		public IntPtr pcmsetposcallback_handle;

		public IntPtr nonblockcallback_handle;

		public IntPtr dlsname;

		public IntPtr encryptionkey;

		public int maxpolyphony;

		public IntPtr userdata;

		public SOUND_TYPE suggestedsoundtype;

		public IntPtr fileuseropen_handle;

		public IntPtr fileuserclose_handle;

		public IntPtr fileuserread_handle;

		public IntPtr fileuserseek_handle;

		public IntPtr fileuserasyncread_handle;

		public IntPtr fileuserasynccancel_handle;

		public IntPtr fileuserdata;

		public int filebuffersize;

		public CHANNELORDER channelorder;

		public CHANNELMASK channelmask;

		public IntPtr initialsoundgroup;

		public uint initialseekposition;

		public TIMEUNIT initialseekpostype;

		public int ignoresetfilesystem;

		public uint audioqueuepolicy;

		public uint minmidigranularity;

		public int nonblockthreadid;

		public IntPtr fsbguid;

		public SOUND_PCMREADCALLBACK pcmreadcallback
		{
			set
			{
				pcmreadcallback_handle = ((value == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value));
			}
		}

		public SOUND_PCMSETPOSCALLBACK pcmsetposcallback
		{
			set
			{
				pcmsetposcallback_handle = ((value == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value));
			}
		}

		public SOUND_NONBLOCKCALLBACK nonblockcallback
		{
			set
			{
				nonblockcallback_handle = ((value == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value));
			}
		}

		public FILE_OPENCALLBACK fileuseropen
		{
			set
			{
				fileuseropen_handle = ((value == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value));
			}
		}

		public FILE_CLOSECALLBACK fileuserclose
		{
			set
			{
				fileuserclose_handle = ((value == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value));
			}
		}

		public FILE_READCALLBACK fileuserread
		{
			set
			{
				fileuserread_handle = ((value == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value));
			}
		}

		public FILE_SEEKCALLBACK fileuserseek
		{
			set
			{
				fileuserseek_handle = ((value == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value));
			}
		}

		public FILE_ASYNCREADCALLBACK fileuserasyncread
		{
			set
			{
				fileuserasyncread_handle = ((value == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value));
			}
		}

		public FILE_ASYNCCANCELCALLBACK fileuserasynccancel
		{
			set
			{
				fileuserasynccancel_handle = ((value == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value));
			}
		}
	}
	public struct REVERB_PROPERTIES
	{
		public float DecayTime;

		public float EarlyDelay;

		public float LateDelay;

		public float HFReference;

		public float HFDecayRatio;

		public float Diffusion;

		public float Density;

		public float LowShelfFrequency;

		public float LowShelfGain;

		public float HighCut;

		public float EarlyLateMix;

		public float WetLevel;

		public REVERB_PROPERTIES(float decayTime, float earlyDelay, float lateDelay, float hfReference, float hfDecayRatio, float diffusion, float density, float lowShelfFrequency, float lowShelfGain, float highCut, float earlyLateMix, float wetLevel)
		{
			DecayTime = decayTime;
			EarlyDelay = earlyDelay;
			LateDelay = lateDelay;
			HFReference = hfReference;
			HFDecayRatio = hfDecayRatio;
			Diffusion = diffusion;
			Density = density;
			LowShelfFrequency = lowShelfFrequency;
			LowShelfGain = lowShelfGain;
			HighCut = highCut;
			EarlyLateMix = earlyLateMix;
			WetLevel = wetLevel;
		}
	}
	public class PRESET
	{
		public static REVERB_PROPERTIES OFF()
		{
			return new REVERB_PROPERTIES(1000f, 7f, 11f, 5000f, 100f, 100f, 100f, 250f, 0f, 20f, 96f, -80f);
		}

		public static REVERB_PROPERTIES GENERIC()
		{
			return new REVERB_PROPERTIES(1500f, 7f, 11f, 5000f, 83f, 100f, 100f, 250f, 0f, 14500f, 96f, -8f);
		}

		public static REVERB_PROPERTIES PADDEDCELL()
		{
			return new REVERB_PROPERTIES(170f, 1f, 2f, 5000f, 10f, 100f, 100f, 250f, 0f, 160f, 84f, -7.8f);
		}

		public static REVERB_PROPERTIES ROOM()
		{
			return new REVERB_PROPERTIES(400f, 2f, 3f, 5000f, 83f, 100f, 100f, 250f, 0f, 6050f, 88f, -9.4f);
		}

		public static REVERB_PROPERTIES BATHROOM()
		{
			return new REVERB_PROPERTIES(1500f, 7f, 11f, 5000f, 54f, 100f, 60f, 250f, 0f, 2900f, 83f, 0.5f);
		}

		public static REVERB_PROPERTIES LIVINGROOM()
		{
			return new REVERB_PROPERTIES(500f, 3f, 4f, 5000f, 10f, 100f, 100f, 250f, 0f, 160f, 58f, -19f);
		}

		public static REVERB_PROPERTIES STONEROOM()
		{
			return new REVERB_PROPERTIES(2300f, 12f, 17f, 5000f, 64f, 100f, 100f, 250f, 0f, 7800f, 71f, -8.5f);
		}

		public static REVERB_PROPERTIES AUDITORIUM()
		{
			return new REVERB_PROPERTIES(4300f, 20f, 30f, 5000f, 59f, 100f, 100f, 250f, 0f, 5850f, 64f, -11.7f);
		}

		public static REVERB_PROPERTIES CONCERTHALL()
		{
			return new REVERB_PROPERTIES(3900f, 20f, 29f, 5000f, 70f, 100f, 100f, 250f, 0f, 5650f, 80f, -9.8f);
		}

		public static REVERB_PROPERTIES CAVE()
		{
			return new REVERB_PROPERTIES(2900f, 15f, 22f, 5000f, 100f, 100f, 100f, 250f, 0f, 20000f, 59f, -11.3f);
		}

		public static REVERB_PROPERTIES ARENA()
		{
			return new REVERB_PROPERTIES(7200f, 20f, 30f, 5000f, 33f, 100f, 100f, 250f, 0f, 4500f, 80f, -9.6f);
		}

		public static REVERB_PROPERTIES HANGAR()
		{
			return new REVERB_PROPERTIES(10000f, 20f, 30f, 5000f, 23f, 100f, 100f, 250f, 0f, 3400f, 72f, -7.4f);
		}

		public static REVERB_PROPERTIES CARPETTEDHALLWAY()
		{
			return new REVERB_PROPERTIES(300f, 2f, 30f, 5000f, 10f, 100f, 100f, 250f, 0f, 500f, 56f, -24f);
		}

		public static REVERB_PROPERTIES HALLWAY()
		{
			return new REVERB_PROPERTIES(1500f, 7f, 11f, 5000f, 59f, 100f, 100f, 250f, 0f, 7800f, 87f, -5.5f);
		}

		public static REVERB_PROPERTIES STONECORRIDOR()
		{
			return new REVERB_PROPERTIES(270f, 13f, 20f, 5000f, 79f, 100f, 100f, 250f, 0f, 9000f, 86f, -6f);
		}

		public static REVERB_PROPERTIES ALLEY()
		{
			return new REVERB_PROPERTIES(1500f, 7f, 11f, 5000f, 86f, 100f, 100f, 250f, 0f, 8300f, 80f, -9.8f);
		}

		public static REVERB_PROPERTIES FOREST()
		{
			return new REVERB_PROPERTIES(1500f, 162f, 88f, 5000f, 54f, 79f, 100f, 250f, 0f, 760f, 94f, -12.3f);
		}

		public static REVERB_PROPERTIES CITY()
		{
			return new REVERB_PROPERTIES(1500f, 7f, 11f, 5000f, 67f, 50f, 100f, 250f, 0f, 4050f, 66f, -26f);
		}

		public static REVERB_PROPERTIES MOUNTAINS()
		{
			return new REVERB_PROPERTIES(1500f, 300f, 100f, 5000f, 21f, 27f, 100f, 250f, 0f, 1220f, 82f, -24f);
		}

		public static REVERB_PROPERTIES QUARRY()
		{
			return new REVERB_PROPERTIES(1500f, 61f, 25f, 5000f, 83f, 100f, 100f, 250f, 0f, 3400f, 100f, -5f);
		}

		public static REVERB_PROPERTIES PLAIN()
		{
			return new REVERB_PROPERTIES(1500f, 179f, 100f, 5000f, 50f, 21f, 100f, 250f, 0f, 1670f, 65f, -28f);
		}

		public static REVERB_PROPERTIES PARKINGLOT()
		{
			return new REVERB_PROPERTIES(1700f, 8f, 12f, 5000f, 100f, 100f, 100f, 250f, 0f, 20000f, 56f, -19.5f);
		}

		public static REVERB_PROPERTIES SEWERPIPE()
		{
			return new REVERB_PROPERTIES(2800f, 14f, 21f, 5000f, 14f, 80f, 60f, 250f, 0f, 3400f, 66f, 1.2f);
		}

		public static REVERB_PROPERTIES UNDERWATER()
		{
			return new REVERB_PROPERTIES(1500f, 7f, 11f, 5000f, 10f, 100f, 100f, 250f, 0f, 500f, 92f, 7f);
		}
	}
	public struct ADVANCEDSETTINGS
	{
		public int cbSize;

		public int maxMPEGCodecs;

		public int maxADPCMCodecs;

		public int maxXMACodecs;

		public int maxVorbisCodecs;

		public int maxAT9Codecs;

		public int maxFADPCMCodecs;

		public int maxPCMCodecs;

		public int ASIONumChannels;

		public IntPtr ASIOChannelList;

		public IntPtr ASIOSpeakerList;

		public float HRTFMinAngle;

		public float HRTFMaxAngle;

		public float HRTFFreq;

		public float vol0virtualvol;

		public uint defaultDecodeBufferSize;

		public ushort profilePort;

		public uint geometryMaxFadeTime;

		public float distanceFilterCenterFreq;

		public int reverb3Dinstance;

		public int DSPBufferPoolSize;

		public uint stackSizeStream;

		public uint stackSizeNonBlocking;

		public uint stackSizeMixer;

		public DSP_RESAMPLER resamplerMethod;

		public uint commandQueueSize;

		public uint randomSeed;
	}
	[Flags]
	public enum DRIVER_STATE : uint
	{
		CONNECTED = 1u,
		DEFAULT = 2u
	}
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Factory
	{
		public static RESULT System_Create(out System system)
		{
			return FMOD5_System_Create(out system.handle);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Create(out IntPtr system);
	}
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Memory
	{
		public static RESULT Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags)
		{
			return FMOD5_Memory_Initialize(poolmem, poollen, useralloc, userrealloc, userfree, memtypeflags);
		}

		public static RESULT GetStats(out int currentalloced, out int maxalloced)
		{
			return GetStats(out currentalloced, out maxalloced, blocking: false);
		}

		public static RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking)
		{
			return FMOD5_Memory_GetStats(out currentalloced, out maxalloced, blocking);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Memory_Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking);
	}
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Debug
	{
		public static RESULT Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode, DEBUG_CALLBACK callback, string filename)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD5_Debug_Initialize(flags, mode, callback, threadSafeEncoding.byteFromStringUTF8(filename));
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Debug_Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode, DEBUG_CALLBACK callback, byte[] filename);
	}
	public struct System
	{
		public IntPtr handle;

		public RESULT release()
		{
			return FMOD5_System_Release(handle);
		}

		public RESULT setOutput(OUTPUTTYPE output)
		{
			return FMOD5_System_SetOutput(handle, output);
		}

		public RESULT getOutput(out OUTPUTTYPE output)
		{
			return FMOD5_System_GetOutput(handle, out output);
		}

		public RESULT getNumDrivers(out int numdrivers)
		{
			return FMOD5_System_GetNumDrivers(handle, out numdrivers);
		}

		public RESULT getDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(namelen);
			RESULT result = FMOD5_System_GetDriverInfo(handle, id, intPtr, namelen, out guid, out systemrate, out speakermode, out speakermodechannels);
			using (StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper())
			{
				name = threadSafeEncoding.stringFromNative(intPtr);
			}
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT getDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return FMOD5_System_GetDriverInfo(handle, id, IntPtr.Zero, 0, out guid, out systemrate, out speakermode, out speakermodechannels);
		}

		public RESULT setDriver(int driver)
		{
			return FMOD5_System_SetDriver(handle, driver);
		}

		public RESULT getDriver(out int driver)
		{
			return FMOD5_System_GetDriver(handle, out driver);
		}

		public RESULT setSoftwareChannels(int numsoftwarechannels)
		{
			return FMOD5_System_SetSoftwareChannels(handle, numsoftwarechannels);
		}

		public RESULT getSoftwareChannels(out int numsoftwarechannels)
		{
			return FMOD5_System_GetSoftwareChannels(handle, out numsoftwarechannels);
		}

		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers)
		{
			return FMOD5_System_SetSoftwareFormat(handle, samplerate, speakermode, numrawspeakers);
		}

		public RESULT getSoftwareFormat(out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers)
		{
			return FMOD5_System_GetSoftwareFormat(handle, out samplerate, out speakermode, out numrawspeakers);
		}

		public RESULT setDSPBufferSize(uint bufferlength, int numbuffers)
		{
			return FMOD5_System_SetDSPBufferSize(handle, bufferlength, numbuffers);
		}

		public RESULT getDSPBufferSize(out uint bufferlength, out int numbuffers)
		{
			return FMOD5_System_GetDSPBufferSize(handle, out bufferlength, out numbuffers);
		}

		public RESULT setFileSystem(FILE_OPENCALLBACK useropen, FILE_CLOSECALLBACK userclose, FILE_READCALLBACK userread, FILE_SEEKCALLBACK userseek, FILE_ASYNCREADCALLBACK userasyncread, FILE_ASYNCCANCELCALLBACK userasynccancel, int blockalign)
		{
			return FMOD5_System_SetFileSystem(handle, useropen, userclose, userread, userseek, userasyncread, userasynccancel, blockalign);
		}

		public RESULT attachFileSystem(FILE_OPENCALLBACK useropen, FILE_CLOSECALLBACK userclose, FILE_READCALLBACK userread, FILE_SEEKCALLBACK userseek)
		{
			return FMOD5_System_AttachFileSystem(handle, useropen, userclose, userread, userseek);
		}

		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			settings.cbSize = Marshal.SizeOf(settings);
			return FMOD5_System_SetAdvancedSettings(handle, ref settings);
		}

		public RESULT getAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			settings.cbSize = Marshal.SizeOf(settings);
			return FMOD5_System_GetAdvancedSettings(handle, ref settings);
		}

		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask)
		{
			return FMOD5_System_SetCallback(handle, callback, callbackmask);
		}

		public RESULT setPluginPath(string path)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD5_System_SetPluginPath(handle, threadSafeEncoding.byteFromStringUTF8(path));
		}

		public RESULT loadPlugin(string filename, out uint handle, uint priority = 0u)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD5_System_LoadPlugin(this.handle, threadSafeEncoding.byteFromStringUTF8(filename), out handle, priority);
		}

		public RESULT unloadPlugin(uint handle)
		{
			return FMOD5_System_UnloadPlugin(this.handle, handle);
		}

		public RESULT getNumNestedPlugins(uint handle, out int count)
		{
			return FMOD5_System_GetNumNestedPlugins(this.handle, handle, out count);
		}

		public RESULT getNestedPlugin(uint handle, int index, out uint nestedhandle)
		{
			return FMOD5_System_GetNestedPlugin(this.handle, handle, index, out nestedhandle);
		}

		public RESULT getNumPlugins(PLUGINTYPE plugintype, out int numplugins)
		{
			return FMOD5_System_GetNumPlugins(handle, plugintype, out numplugins);
		}

		public RESULT getPluginHandle(PLUGINTYPE plugintype, int index, out uint handle)
		{
			return FMOD5_System_GetPluginHandle(this.handle, plugintype, index, out handle);
		}

		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out string name, int namelen, out uint version)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(namelen);
			RESULT result = FMOD5_System_GetPluginInfo(this.handle, handle, out plugintype, intPtr, namelen, out version);
			using (StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper())
			{
				name = threadSafeEncoding.stringFromNative(intPtr);
			}
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out uint version)
		{
			return FMOD5_System_GetPluginInfo(this.handle, handle, out plugintype, IntPtr.Zero, 0, out version);
		}

		public RESULT setOutputByPlugin(uint handle)
		{
			return FMOD5_System_SetOutputByPlugin(this.handle, handle);
		}

		public RESULT getOutputByPlugin(out uint handle)
		{
			return FMOD5_System_GetOutputByPlugin(this.handle, out handle);
		}

		public RESULT createDSPByPlugin(uint handle, out DSP dsp)
		{
			return FMOD5_System_CreateDSPByPlugin(this.handle, handle, out dsp.handle);
		}

		public RESULT getDSPInfoByPlugin(uint handle, out IntPtr description)
		{
			return FMOD5_System_GetDSPInfoByPlugin(this.handle, handle, out description);
		}

		public RESULT registerDSP(ref DSP_DESCRIPTION description, out uint handle)
		{
			return FMOD5_System_RegisterDSP(this.handle, ref description, out handle);
		}

		public RESULT init(int maxchannels, INITFLAGS flags, IntPtr extradriverdata)
		{
			return FMOD5_System_Init(handle, maxchannels, flags, extradriverdata);
		}

		public RESULT close()
		{
			return FMOD5_System_Close(handle);
		}

		public RESULT update()
		{
			return FMOD5_System_Update(handle);
		}

		public RESULT setSpeakerPosition(SPEAKER speaker, float x, float y, bool active)
		{
			return FMOD5_System_SetSpeakerPosition(handle, speaker, x, y, active);
		}

		public RESULT getSpeakerPosition(SPEAKER speaker, out float x, out float y, out bool active)
		{
			return FMOD5_System_GetSpeakerPosition(handle, speaker, out x, out y, out active);
		}

		public RESULT setStreamBufferSize(uint filebuffersize, TIMEUNIT filebuffersizetype)
		{
			return FMOD5_System_SetStreamBufferSize(handle, filebuffersize, filebuffersizetype);
		}

		public RESULT getStreamBufferSize(out uint filebuffersize, out TIMEUNIT filebuffersizetype)
		{
			return FMOD5_System_GetStreamBufferSize(handle, out filebuffersize, out filebuffersizetype);
		}

		public RESULT set3DSettings(float dopplerscale, float distancefactor, float rolloffscale)
		{
			return FMOD5_System_Set3DSettings(handle, dopplerscale, distancefactor, rolloffscale);
		}

		public RESULT get3DSettings(out float dopplerscale, out float distancefactor, out float rolloffscale)
		{
			return FMOD5_System_Get3DSettings(handle, out dopplerscale, out distancefactor, out rolloffscale);
		}

		public RESULT set3DNumListeners(int numlisteners)
		{
			return FMOD5_System_Set3DNumListeners(handle, numlisteners);
		}

		public RESULT get3DNumListeners(out int numlisteners)
		{
			return FMOD5_System_Get3DNumListeners(handle, out numlisteners);
		}

		public RESULT set3DListenerAttributes(int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up)
		{
			return FMOD5_System_Set3DListenerAttributes(handle, listener, ref pos, ref vel, ref forward, ref up);
		}

		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up)
		{
			return FMOD5_System_Get3DListenerAttributes(handle, listener, out pos, out vel, out forward, out up);
		}

		public RESULT set3DRolloffCallback(CB_3D_ROLLOFFCALLBACK callback)
		{
			return FMOD5_System_Set3DRolloffCallback(handle, callback);
		}

		public RESULT mixerSuspend()
		{
			return FMOD5_System_MixerSuspend(handle);
		}

		public RESULT mixerResume()
		{
			return FMOD5_System_MixerResume(handle);
		}

		public RESULT getDefaultMixMatrix(SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop)
		{
			return FMOD5_System_GetDefaultMixMatrix(handle, sourcespeakermode, targetspeakermode, matrix, matrixhop);
		}

		public RESULT getSpeakerModeChannels(SPEAKERMODE mode, out int channels)
		{
			return FMOD5_System_GetSpeakerModeChannels(handle, mode, out channels);
		}

		public RESULT getVersion(out uint version)
		{
			return FMOD5_System_GetVersion(handle, out version);
		}

		public RESULT getOutputHandle(out IntPtr handle)
		{
			return FMOD5_System_GetOutputHandle(this.handle, out handle);
		}

		public RESULT getChannelsPlaying(out int channels, out int realchannels)
		{
			return FMOD5_System_GetChannelsPlaying(handle, out channels, out realchannels);
		}

		public RESULT getCPUUsage(out float dsp, out float stream, out float geometry, out float update, out float total)
		{
			return FMOD5_System_GetCPUUsage(handle, out dsp, out stream, out geometry, out update, out total);
		}

		public RESULT getFileUsage(out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead)
		{
			return FMOD5_System_GetFileUsage(handle, out sampleBytesRead, out streamBytesRead, out otherBytesRead);
		}

		public RESULT getSoundRAM(out int currentalloced, out int maxalloced, out int total)
		{
			return FMOD5_System_GetSoundRAM(handle, out currentalloced, out maxalloced, out total);
		}

		public RESULT createSound(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD5_System_CreateSound(handle, threadSafeEncoding.byteFromStringUTF8(name), mode, ref exinfo, out sound.handle);
		}

		public RESULT createSound(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return FMOD5_System_CreateSound(handle, data, mode, ref exinfo, out sound.handle);
		}

		public RESULT createSound(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return FMOD5_System_CreateSound(handle, name_or_data, mode, ref exinfo, out sound.handle);
		}

		public RESULT createSound(string name, MODE mode, out Sound sound)
		{
			CREATESOUNDEXINFO exinfo = default(CREATESOUNDEXINFO);
			exinfo.cbsize = Marshal.SizeOf(exinfo);
			return createSound(name, mode, ref exinfo, out sound);
		}

		public RESULT createStream(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD5_System_CreateStream(handle, threadSafeEncoding.byteFromStringUTF8(name), mode, ref exinfo, out sound.handle);
		}

		public RESULT createStream(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return FMOD5_System_CreateStream(handle, data, mode, ref exinfo, out sound.handle);
		}

		public RESULT createStream(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return FMOD5_System_CreateStream(handle, name_or_data, mode, ref exinfo, out sound.handle);
		}

		public RESULT createStream(string name, MODE mode, out Sound sound)
		{
			CREATESOUNDEXINFO exinfo = default(CREATESOUNDEXINFO);
			exinfo.cbsize = Marshal.SizeOf(exinfo);
			return createStream(name, mode, ref exinfo, out sound);
		}

		public RESULT createDSP(ref DSP_DESCRIPTION description, out DSP dsp)
		{
			return FMOD5_System_CreateDSP(handle, ref description, out dsp.handle);
		}

		public RESULT createDSPByType(DSP_TYPE type, out DSP dsp)
		{
			return FMOD5_System_CreateDSPByType(handle, type, out dsp.handle);
		}

		public RESULT createChannelGroup(string name, out ChannelGroup channelgroup)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD5_System_CreateChannelGroup(handle, threadSafeEncoding.byteFromStringUTF8(name), out channelgroup.handle);
		}

		public RESULT createSoundGroup(string name, out SoundGroup soundgroup)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD5_System_CreateSoundGroup(handle, threadSafeEncoding.byteFromStringUTF8(name), out soundgroup.handle);
		}

		public RESULT createReverb3D(out Reverb3D reverb)
		{
			return FMOD5_System_CreateReverb3D(handle, out reverb.handle);
		}

		public RESULT playSound(Sound sound, ChannelGroup channelGroup, bool paused, out Channel channel)
		{
			return FMOD5_System_PlaySound(handle, sound.handle, channelGroup.handle, paused, out channel.handle);
		}

		public RESULT playDSP(DSP dsp, ChannelGroup channelGroup, bool paused, out Channel channel)
		{
			return FMOD5_System_PlayDSP(handle, dsp.handle, channelGroup.handle, paused, out channel.handle);
		}

		public RESULT getChannel(int channelid, out Channel channel)
		{
			return FMOD5_System_GetChannel(handle, channelid, out channel.handle);
		}

		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup)
		{
			return FMOD5_System_GetMasterChannelGroup(handle, out channelgroup.handle);
		}

		public RESULT getMasterSoundGroup(out SoundGroup soundgroup)
		{
			return FMOD5_System_GetMasterSoundGroup(handle, out soundgroup.handle);
		}

		public RESULT attachChannelGroupToPort(uint portType, ulong portIndex, ChannelGroup channelgroup, bool passThru = false)
		{
			return FMOD5_System_AttachChannelGroupToPort(handle, portType, portIndex, channelgroup.handle, passThru);
		}

		public RESULT detachChannelGroupFromPort(ChannelGroup channelgroup)
		{
			return FMOD5_System_DetachChannelGroupFromPort(handle, channelgroup.handle);
		}

		public RESULT setReverbProperties(int instance, ref REVERB_PROPERTIES prop)
		{
			return FMOD5_System_SetReverbProperties(handle, instance, ref prop);
		}

		public RESULT getReverbProperties(int instance, out REVERB_PROPERTIES prop)
		{
			return FMOD5_System_GetReverbProperties(handle, instance, out prop);
		}

		public RESULT lockDSP()
		{
			return FMOD5_System_LockDSP(handle);
		}

		public RESULT unlockDSP()
		{
			return FMOD5_System_UnlockDSP(handle);
		}

		public RESULT getRecordNumDrivers(out int numdrivers, out int numconnected)
		{
			return FMOD5_System_GetRecordNumDrivers(handle, out numdrivers, out numconnected);
		}

		public RESULT getRecordDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(namelen);
			RESULT result = FMOD5_System_GetRecordDriverInfo(handle, id, intPtr, namelen, out guid, out systemrate, out speakermode, out speakermodechannels, out state);
			using (StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper())
			{
				name = threadSafeEncoding.stringFromNative(intPtr);
			}
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT getRecordDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return FMOD5_System_GetRecordDriverInfo(handle, id, IntPtr.Zero, 0, out guid, out systemrate, out speakermode, out speakermodechannels, out state);
		}

		public RESULT getRecordPosition(int id, out uint position)
		{
			return FMOD5_System_GetRecordPosition(handle, id, out position);
		}

		public RESULT recordStart(int id, Sound sound, bool loop)
		{
			return FMOD5_System_RecordStart(handle, id, sound.handle, loop);
		}

		public RESULT recordStop(int id)
		{
			return FMOD5_System_RecordStop(handle, id);
		}

		public RESULT isRecording(int id, out bool recording)
		{
			return FMOD5_System_IsRecording(handle, id, out recording);
		}

		public RESULT createGeometry(int maxpolygons, int maxvertices, out Geometry geometry)
		{
			return FMOD5_System_CreateGeometry(handle, maxpolygons, maxvertices, out geometry.handle);
		}

		public RESULT setGeometrySettings(float maxworldsize)
		{
			return FMOD5_System_SetGeometrySettings(handle, maxworldsize);
		}

		public RESULT getGeometrySettings(out float maxworldsize)
		{
			return FMOD5_System_GetGeometrySettings(handle, out maxworldsize);
		}

		public RESULT loadGeometry(IntPtr data, int datasize, out Geometry geometry)
		{
			return FMOD5_System_LoadGeometry(handle, data, datasize, out geometry.handle);
		}

		public RESULT getGeometryOcclusion(ref VECTOR listener, ref VECTOR source, out float direct, out float reverb)
		{
			return FMOD5_System_GetGeometryOcclusion(handle, ref listener, ref source, out direct, out reverb);
		}

		public RESULT setNetworkProxy(string proxy)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD5_System_SetNetworkProxy(handle, threadSafeEncoding.byteFromStringUTF8(proxy));
		}

		public RESULT getNetworkProxy(out string proxy, int proxylen)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(proxylen);
			RESULT result = FMOD5_System_GetNetworkProxy(handle, intPtr, proxylen);
			using (StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper())
			{
				proxy = threadSafeEncoding.stringFromNative(intPtr);
			}
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT setNetworkTimeout(int timeout)
		{
			return FMOD5_System_SetNetworkTimeout(handle, timeout);
		}

		public RESULT getNetworkTimeout(out int timeout)
		{
			return FMOD5_System_GetNetworkTimeout(handle, out timeout);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_System_SetUserData(handle, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_System_GetUserData(handle, out userdata);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Release(IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetOutput(IntPtr system, out OUTPUTTYPE output);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetNumDrivers(IntPtr system, out int numdrivers);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetDriver(IntPtr system, int driver);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetDriver(IntPtr system, out int driver);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetSoftwareChannels(IntPtr system, out int numsoftwarechannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetSoftwareFormat(IntPtr system, out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetDSPBufferSize(IntPtr system, uint bufferlength, int numbuffers);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetDSPBufferSize(IntPtr system, out uint bufferlength, out int numbuffers);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetFileSystem(IntPtr system, FILE_OPENCALLBACK useropen, FILE_CLOSECALLBACK userclose, FILE_READCALLBACK userread, FILE_SEEKCALLBACK userseek, FILE_ASYNCREADCALLBACK userasyncread, FILE_ASYNCCANCELCALLBACK userasynccancel, int blockalign);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_AttachFileSystem(IntPtr system, FILE_OPENCALLBACK useropen, FILE_CLOSECALLBACK userclose, FILE_READCALLBACK userread, FILE_SEEKCALLBACK userseek);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetPluginPath(IntPtr system, byte[] path);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_UnloadPlugin(IntPtr system, uint handle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetNumNestedPlugins(IntPtr system, uint handle, out int count);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetNestedPlugin(IntPtr system, uint handle, int index, out uint nestedhandle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetNumPlugins(IntPtr system, PLUGINTYPE plugintype, out int numplugins);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetPluginHandle(IntPtr system, PLUGINTYPE plugintype, int index, out uint handle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetPluginInfo(IntPtr system, uint handle, out PLUGINTYPE plugintype, IntPtr name, int namelen, out uint version);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetOutputByPlugin(IntPtr system, uint handle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetOutputByPlugin(IntPtr system, out uint handle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateDSPByPlugin(IntPtr system, uint handle, out IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetDSPInfoByPlugin(IntPtr system, uint handle, out IntPtr description);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_RegisterDSP(IntPtr system, ref DSP_DESCRIPTION description, out uint handle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Init(IntPtr system, int maxchannels, INITFLAGS flags, IntPtr extradriverdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Close(IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Update(IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetSpeakerPosition(IntPtr system, SPEAKER speaker, float x, float y, bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetSpeakerPosition(IntPtr system, SPEAKER speaker, out float x, out float y, out bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetStreamBufferSize(IntPtr system, uint filebuffersize, TIMEUNIT filebuffersizetype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetStreamBufferSize(IntPtr system, out uint filebuffersize, out TIMEUNIT filebuffersizetype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Set3DSettings(IntPtr system, float dopplerscale, float distancefactor, float rolloffscale);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Get3DSettings(IntPtr system, out float dopplerscale, out float distancefactor, out float rolloffscale);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Set3DNumListeners(IntPtr system, int numlisteners);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Get3DNumListeners(IntPtr system, out int numlisteners);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Set3DListenerAttributes(IntPtr system, int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Set3DRolloffCallback(IntPtr system, CB_3D_ROLLOFFCALLBACK callback);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetDefaultMixMatrix(IntPtr system, SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetSpeakerModeChannels(IntPtr system, SPEAKERMODE mode, out int channels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetVersion(IntPtr system, out uint version);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetOutputHandle(IntPtr system, out IntPtr handle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetCPUUsage(IntPtr system, out float dsp, out float stream, out float geometry, out float update, out float total);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetFileUsage(IntPtr system, out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetSoundRAM(IntPtr system, out int currentalloced, out int maxalloced, out int total);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateDSP(IntPtr system, ref DSP_DESCRIPTION description, out IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateDSPByType(IntPtr system, DSP_TYPE type, out IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateChannelGroup(IntPtr system, byte[] name, out IntPtr channelgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateSoundGroup(IntPtr system, byte[] name, out IntPtr soundgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateReverb3D(IntPtr system, out IntPtr reverb);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_PlaySound(IntPtr system, IntPtr sound, IntPtr channelGroup, bool paused, out IntPtr channel);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_PlayDSP(IntPtr system, IntPtr dsp, IntPtr channelGroup, bool paused, out IntPtr channel);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetChannel(IntPtr system, int channelid, out IntPtr channel);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetMasterSoundGroup(IntPtr system, out IntPtr soundgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_AttachChannelGroupToPort(IntPtr system, uint portType, ulong portIndex, IntPtr channelgroup, bool passThru);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_DetachChannelGroupFromPort(IntPtr system, IntPtr channelgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetReverbProperties(IntPtr system, int instance, ref REVERB_PROPERTIES prop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetReverbProperties(IntPtr system, int instance, out REVERB_PROPERTIES prop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_LockDSP(IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_UnlockDSP(IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetRecordNumDrivers(IntPtr system, out int numdrivers, out int numconnected);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetRecordDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetRecordPosition(IntPtr system, int id, out uint position);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_RecordStart(IntPtr system, int id, IntPtr sound, bool loop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_RecordStop(IntPtr system, int id);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_IsRecording(IntPtr system, int id, out bool recording);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateGeometry(IntPtr system, int maxpolygons, int maxvertices, out IntPtr geometry);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetGeometrySettings(IntPtr system, float maxworldsize);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetGeometrySettings(IntPtr system, out float maxworldsize);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_LoadGeometry(IntPtr system, IntPtr data, int datasize, out IntPtr geometry);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetGeometryOcclusion(IntPtr system, ref VECTOR listener, ref VECTOR source, out float direct, out float reverb);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetNetworkProxy(IntPtr system, byte[] proxy);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetNetworkProxy(IntPtr system, IntPtr proxy, int proxylen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetNetworkTimeout(IntPtr system, int timeout);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetNetworkTimeout(IntPtr system, out int timeout);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetUserData(IntPtr system, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetUserData(IntPtr system, out IntPtr userdata);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}
	}
	public struct Sound
	{
		public IntPtr handle;

		public RESULT release()
		{
			return FMOD5_Sound_Release(handle);
		}

		public RESULT getSystemObject(out System system)
		{
			return FMOD5_Sound_GetSystemObject(handle, out system.handle);
		}

		public RESULT @lock(uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2)
		{
			return FMOD5_Sound_Lock(handle, offset, length, out ptr1, out ptr2, out len1, out len2);
		}

		public RESULT unlock(IntPtr ptr1, IntPtr ptr2, uint len1, uint len2)
		{
			return FMOD5_Sound_Unlock(handle, ptr1, ptr2, len1, len2);
		}

		public RESULT setDefaults(float frequency, int priority)
		{
			return FMOD5_Sound_SetDefaults(handle, frequency, priority);
		}

		public RESULT getDefaults(out float frequency, out int priority)
		{
			return FMOD5_Sound_GetDefaults(handle, out frequency, out priority);
		}

		public RESULT set3DMinMaxDistance(float min, float max)
		{
			return FMOD5_Sound_Set3DMinMaxDistance(handle, min, max);
		}

		public RESULT get3DMinMaxDistance(out float min, out float max)
		{
			return FMOD5_Sound_Get3DMinMaxDistance(handle, out min, out max);
		}

		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return FMOD5_Sound_Set3DConeSettings(handle, insideconeangle, outsideconeangle, outsidevolume);
		}

		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return FMOD5_Sound_Get3DConeSettings(handle, out insideconeangle, out outsideconeangle, out outsidevolume);
		}

		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return FMOD5_Sound_Set3DCustomRolloff(handle, ref points, numpoints);
		}

		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return FMOD5_Sound_Get3DCustomRolloff(handle, out points, out numpoints);
		}

		public RESULT getSubSound(int index, out Sound subsound)
		{
			return FMOD5_Sound_GetSubSound(handle, index, out subsound.handle);
		}

		public RESULT getSubSoundParent(out Sound parentsound)
		{
			return FMOD5_Sound_GetSubSoundParent(handle, out parentsound.handle);
		}

		public RESULT getName(out string name, int namelen)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(namelen);
			RESULT result = FMOD5_Sound_GetName(handle, intPtr, namelen);
			using (StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper())
			{
				name = threadSafeEncoding.stringFromNative(intPtr);
			}
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT getLength(out uint length, TIMEUNIT lengthtype)
		{
			return FMOD5_Sound_GetLength(handle, out length, lengthtype);
		}

		public RESULT getFormat(out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits)
		{
			return FMOD5_Sound_GetFormat(handle, out type, out format, out channels, out bits);
		}

		public RESULT getNumSubSounds(out int numsubsounds)
		{
			return FMOD5_Sound_GetNumSubSounds(handle, out numsubsounds);
		}

		public RESULT getNumTags(out int numtags, out int numtagsupdated)
		{
			return FMOD5_Sound_GetNumTags(handle, out numtags, out numtagsupdated);
		}

		public RESULT getTag(string name, int index, out TAG tag)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD5_Sound_GetTag(handle, threadSafeEncoding.byteFromStringUTF8(name), index, out tag);
		}

		public RESULT getOpenState(out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy)
		{
			return FMOD5_Sound_GetOpenState(handle, out openstate, out percentbuffered, out starving, out diskbusy);
		}

		public RESULT readData(IntPtr buffer, uint lenbytes, out uint read)
		{
			return FMOD5_Sound_ReadData(handle, buffer, lenbytes, out read);
		}

		public RESULT seekData(uint pcm)
		{
			return FMOD5_Sound_SeekData(handle, pcm);
		}

		public RESULT setSoundGroup(SoundGroup soundgroup)
		{
			return FMOD5_Sound_SetSoundGroup(handle, soundgroup.handle);
		}

		public RESULT getSoundGroup(out SoundGroup soundgroup)
		{
			return FMOD5_Sound_GetSoundGroup(handle, out soundgroup.handle);
		}

		public RESULT getNumSyncPoints(out int numsyncpoints)
		{
			return FMOD5_Sound_GetNumSyncPoints(handle, out numsyncpoints);
		}

		public RESULT getSyncPoint(int index, out IntPtr point)
		{
			return FMOD5_Sound_GetSyncPoint(handle, index, out point);
		}

		public RESULT getSyncPointInfo(IntPtr point, out string name, int namelen, out uint offset, TIMEUNIT offsettype)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(namelen);
			RESULT result = FMOD5_Sound_GetSyncPointInfo(handle, point, intPtr, namelen, out offset, offsettype);
			using (StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper())
			{
				name = threadSafeEncoding.stringFromNative(intPtr);
			}
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT getSyncPointInfo(IntPtr point, out uint offset, TIMEUNIT offsettype)
		{
			return FMOD5_Sound_GetSyncPointInfo(handle, point, IntPtr.Zero, 0, out offset, offsettype);
		}

		public RESULT addSyncPoint(uint offset, TIMEUNIT offsettype, string name, out IntPtr point)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD5_Sound_AddSyncPoint(handle, offset, offsettype, threadSafeEncoding.byteFromStringUTF8(name), out point);
		}

		public RESULT deleteSyncPoint(IntPtr point)
		{
			return FMOD5_Sound_DeleteSyncPoint(handle, point);
		}

		public RESULT setMode(MODE mode)
		{
			return FMOD5_Sound_SetMode(handle, mode);
		}

		public RESULT getMode(out MODE mode)
		{
			return FMOD5_Sound_GetMode(handle, out mode);
		}

		public RESULT setLoopCount(int loopcount)
		{
			return FMOD5_Sound_SetLoopCount(handle, loopcount);
		}

		public RESULT getLoopCount(out int loopcount)
		{
			return FMOD5_Sound_GetLoopCount(handle, out loopcount);
		}

		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return FMOD5_Sound_SetLoopPoints(handle, loopstart, loopstarttype, loopend, loopendtype);
		}

		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return FMOD5_Sound_GetLoopPoints(handle, out loopstart, loopstarttype, out loopend, loopendtype);
		}

		public RESULT getMusicNumChannels(out int numchannels)
		{
			return FMOD5_Sound_GetMusicNumChannels(handle, out numchannels);
		}

		public RESULT setMusicChannelVolume(int channel, float volume)
		{
			return FMOD5_Sound_SetMusicChannelVolume(handle, channel, volume);
		}

		public RESULT getMusicChannelVolume(int channel, out float volume)
		{
			return FMOD5_Sound_GetMusicChannelVolume(handle, channel, out volume);
		}

		public RESULT setMusicSpeed(float speed)
		{
			return FMOD5_Sound_SetMusicSpeed(handle, speed);
		}

		public RESULT getMusicSpeed(out float speed)
		{
			return FMOD5_Sound_GetMusicSpeed(handle, out speed);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_Sound_SetUserData(handle, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_Sound_GetUserData(handle, out userdata);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Release(IntPtr sound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetSystemObject(IntPtr sound, out IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Lock(IntPtr sound, uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Unlock(IntPtr sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetDefaults(IntPtr sound, float frequency, int priority);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetDefaults(IntPtr sound, out float frequency, out int priority);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Set3DMinMaxDistance(IntPtr sound, float min, float max);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Get3DMinMaxDistance(IntPtr sound, out float min, out float max);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Set3DConeSettings(IntPtr sound, float insideconeangle, float outsideconeangle, float outsidevolume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Get3DConeSettings(IntPtr sound, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Set3DCustomRolloff(IntPtr sound, ref VECTOR points, int numpoints);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Get3DCustomRolloff(IntPtr sound, out IntPtr points, out int numpoints);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetSubSound(IntPtr sound, int index, out IntPtr subsound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetSubSoundParent(IntPtr sound, out IntPtr parentsound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetName(IntPtr sound, IntPtr name, int namelen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetLength(IntPtr sound, out uint length, TIMEUNIT lengthtype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetFormat(IntPtr sound, out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetNumSubSounds(IntPtr sound, out int numsubsounds);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetNumTags(IntPtr sound, out int numtags, out int numtagsupdated);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetTag(IntPtr sound, byte[] name, int index, out TAG tag);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetOpenState(IntPtr sound, out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, IntPtr buffer, uint lenbytes, out uint read);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SeekData(IntPtr sound, uint pcm);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetSoundGroup(IntPtr sound, IntPtr soundgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetSoundGroup(IntPtr sound, out IntPtr soundgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetNumSyncPoints(IntPtr sound, out int numsyncpoints);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetSyncPoint(IntPtr sound, int index, out IntPtr point);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetSyncPointInfo(IntPtr sound, IntPtr point, IntPtr name, int namelen, out uint offset, TIMEUNIT offsettype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_AddSyncPoint(IntPtr sound, uint offset, TIMEUNIT offsettype, byte[] name, out IntPtr point);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_DeleteSyncPoint(IntPtr sound, IntPtr point);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetMode(IntPtr sound, MODE mode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetMode(IntPtr sound, out MODE mode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetLoopCount(IntPtr sound, int loopcount);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetLoopCount(IntPtr sound, out int loopcount);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetLoopPoints(IntPtr sound, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetLoopPoints(IntPtr sound, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetMusicNumChannels(IntPtr sound, out int numchannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetMusicChannelVolume(IntPtr sound, int channel, float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetMusicChannelVolume(IntPtr sound, int channel, out float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetMusicSpeed(IntPtr sound, float speed);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetMusicSpeed(IntPtr sound, out float speed);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetUserData(IntPtr sound, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetUserData(IntPtr sound, out IntPtr userdata);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}
	}
	internal interface IChannelControl
	{
		RESULT getSystemObject(out System system);

		RESULT stop();

		RESULT setPaused(bool paused);

		RESULT getPaused(out bool paused);

		RESULT setVolume(float volume);

		RESULT getVolume(out float volume);

		RESULT setVolumeRamp(bool ramp);

		RESULT getVolumeRamp(out bool ramp);

		RESULT getAudibility(out float audibility);

		RESULT setPitch(float pitch);

		RESULT getPitch(out float pitch);

		RESULT setMute(bool mute);

		RESULT getMute(out bool mute);

		RESULT setReverbProperties(int instance, float wet);

		RESULT getReverbProperties(int instance, out float wet);

		RESULT setLowPassGain(float gain);

		RESULT getLowPassGain(out float gain);

		RESULT setMode(MODE mode);

		RESULT getMode(out MODE mode);

		RESULT setCallback(CHANNEL_CALLBACK callback);

		RESULT isPlaying(out bool isplaying);

		RESULT setPan(float pan);

		RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		RESULT setMixLevelsInput(float[] levels, int numlevels);

		RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		RESULT getDSPClock(out ulong dspclock, out ulong parentclock);

		RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		RESULT addFadePoint(ulong dspclock, float volume);

		RESULT setFadePointRamp(ulong dspclock, float volume);

		RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end);

		RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		RESULT getDSP(int index, out DSP dsp);

		RESULT addDSP(int index, DSP dsp);

		RESULT removeDSP(DSP dsp);

		RESULT getNumDSPs(out int numdsps);

		RESULT setDSPIndex(DSP dsp, int index);

		RESULT getDSPIndex(DSP dsp, out int index);

		RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel, ref VECTOR alt_pan_pos);

		RESULT get3DAttributes(out VECTOR pos, out VECTOR vel, out VECTOR alt_pan_pos);

		RESULT set3DMinMaxDistance(float mindistance, float maxdistance);

		RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance);

		RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume);

		RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		RESULT set3DConeOrientation(ref VECTOR orientation);

		RESULT get3DConeOrientation(out VECTOR orientation);

		RESULT set3DCustomRolloff(ref VECTOR points, int numpoints);

		RESULT get3DCustomRolloff(out IntPtr points, out int numpoints);

		RESULT set3DOcclusion(float directocclusion, float reverbocclusion);

		RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion);

		RESULT set3DSpread(float angle);

		RESULT get3DSpread(out float angle);

		RESULT set3DLevel(float level);

		RESULT get3DLevel(out float level);

		RESULT set3DDopplerLevel(float level);

		RESULT get3DDopplerLevel(out float level);

		RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq);

		RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq);

		RESULT setUserData(IntPtr userdata);

		RESULT getUserData(out IntPtr userdata);
	}
	public struct Channel : IChannelControl
	{
		public IntPtr handle;

		public RESULT setFrequency(float frequency)
		{
			return FMOD5_Channel_SetFrequency(handle, frequency);
		}

		public RESULT getFrequency(out float frequency)
		{
			return FMOD5_Channel_GetFrequency(handle, out frequency);
		}

		public RESULT setPriority(int priority)
		{
			return FMOD5_Channel_SetPriority(handle, priority);
		}

		public RESULT getPriority(out int priority)
		{
			return FMOD5_Channel_GetPriority(handle, out priority);
		}

		public RESULT setPosition(uint position, TIMEUNIT postype)
		{
			return FMOD5_Channel_SetPosition(handle, position, postype);
		}

		public RESULT getPosition(out uint position, TIMEUNIT postype)
		{
			return FMOD5_Channel_GetPosition(handle, out position, postype);
		}

		public RESULT setChannelGroup(ChannelGroup channelgroup)
		{
			return FMOD5_Channel_SetChannelGroup(handle, channelgroup.handle);
		}

		public RESULT getChannelGroup(out ChannelGroup channelgroup)
		{
			return FMOD5_Channel_GetChannelGroup(handle, out channelgroup.handle);
		}

		public RESULT setLoopCount(int loopcount)
		{
			return FMOD5_Channel_SetLoopCount(handle, loopcount);
		}

		public RESULT getLoopCount(out int loopcount)
		{
			return FMOD5_Channel_GetLoopCount(handle, out loopcount);
		}

		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return FMOD5_Channel_SetLoopPoints(handle, loopstart, loopstarttype, loopend, loopendtype);
		}

		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return FMOD5_Channel_GetLoopPoints(handle, out loopstart, loopstarttype, out loopend, loopendtype);
		}

		public RESULT isVirtual(out bool isvirtual)
		{
			return FMOD5_Channel_IsVirtual(handle, out isvirtual);
		}

		public RESULT getCurrentSound(out Sound sound)
		{
			return FMOD5_Channel_GetCurrentSound(handle, out sound.handle);
		}

		public RESULT getIndex(out int index)
		{
			return FMOD5_Channel_GetIndex(handle, out index);
		}

		public RESULT getSystemObject(out System system)
		{
			return FMOD5_Channel_GetSystemObject(handle, out system.handle);
		}

		public RESULT stop()
		{
			return FMOD5_Channel_Stop(handle);
		}

		public RESULT setPaused(bool paused)
		{
			return FMOD5_Channel_SetPaused(handle, paused);
		}

		public RESULT getPaused(out bool paused)
		{
			return FMOD5_Channel_GetPaused(handle, out paused);
		}

		public RESULT setVolume(float volume)
		{
			return FMOD5_Channel_SetVolume(handle, volume);
		}

		public RESULT getVolume(out float volume)
		{
			return FMOD5_Channel_GetVolume(handle, out volume);
		}

		public RESULT setVolumeRamp(bool ramp)
		{
			return FMOD5_Channel_SetVolumeRamp(handle, ramp);
		}

		public RESULT getVolumeRamp(out bool ramp)
		{
			return FMOD5_Channel_GetVolumeRamp(handle, out ramp);
		}

		public RESULT getAudibility(out float audibility)
		{
			return FMOD5_Channel_GetAudibility(handle, out audibility);
		}

		public RESULT setPitch(float pitch)
		{
			return FMOD5_Channel_SetPitch(handle, pitch);
		}

		public RESULT getPitch(out float pitch)
		{
			return FMOD5_Channel_GetPitch(handle, out pitch);
		}

		public RESULT setMute(bool mute)
		{
			return FMOD5_Channel_SetMute(handle, mute);
		}

		public RESULT getMute(out bool mute)
		{
			return FMOD5_Channel_GetMute(handle, out mute);
		}

		public RESULT setReverbProperties(int instance, float wet)
		{
			return FMOD5_Channel_SetReverbProperties(handle, instance, wet);
		}

		public RESULT getReverbProperties(int instance, out float wet)
		{
			return FMOD5_Channel_GetReverbProperties(handle, instance, out wet);
		}

		public RESULT setLowPassGain(float gain)
		{
			return FMOD5_Channel_SetLowPassGain(handle, gain);
		}

		public RESULT getLowPassGain(out float gain)
		{
			return FMOD5_Channel_GetLowPassGain(handle, out gain);
		}

		public RESULT setMode(MODE mode)
		{
			return FMOD5_Channel_SetMode(handle, mode);
		}

		public RESULT getMode(out MODE mode)
		{
			return FMOD5_Channel_GetMode(handle, out mode);
		}

		public RESULT setCallback(CHANNEL_CALLBACK callback)
		{
			return FMOD5_Channel_SetCallback(handle, callback);
		}

		public RESULT isPlaying(out bool isplaying)
		{
			return FMOD5_Channel_IsPlaying(handle, out isplaying);
		}

		public RESULT setPan(float pan)
		{
			return FMOD5_Channel_SetPan(handle, pan);
		}

		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return FMOD5_Channel_SetMixLevelsOutput(handle, frontleft, frontright, center, lfe, surroundleft, surroundright, backleft, backright);
		}

		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return FMOD5_Channel_SetMixLevelsInput(handle, levels, numlevels);
		}

		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
		{
			return FMOD5_Channel_SetMixMatrix(handle, matrix, outchannels, inchannels, inchannel_hop);
		}

		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
		{
			return FMOD5_Channel_GetMixMatrix(handle, matrix, out outchannels, out inchannels, inchannel_hop);
		}

		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return FMOD5_Channel_GetDSPClock(handle, out dspclock, out parentclock);
		}

		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels)
		{
			return FMOD5_Channel_SetDelay(handle, dspclock_start, dspclock_end, stopchannels);
		}

		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return FMOD5_Channel_GetDelay(handle, out dspclock_start, out dspclock_end, out stopchannels);
		}

		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return FMOD5_Channel_AddFadePoint(handle, dspclock, volume);
		}

		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return FMOD5_Channel_SetFadePointRamp(handle, dspclock, volume);
		}

		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return FMOD5_Channel_RemoveFadePoints(handle, dspclock_start, dspclock_end);
		}

		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return FMOD5_Channel_GetFadePoints(handle, ref numpoints, point_dspclock, point_volume);
		}

		public RESULT getDSP(int index, out DSP dsp)
		{
			return FMOD5_Channel_GetDSP(handle, index, out dsp.handle);
		}

		public RESULT addDSP(int index, DSP dsp)
		{
			return FMOD5_Channel_AddDSP(handle, index, dsp.handle);
		}

		public RESULT removeDSP(DSP dsp)
		{
			return FMOD5_Channel_RemoveDSP(handle, dsp.handle);
		}

		public RESULT getNumDSPs(out int numdsps)
		{
			return FMOD5_Channel_GetNumDSPs(handle, out numdsps);
		}

		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return FMOD5_Channel_SetDSPIndex(handle, dsp.handle, index);
		}

		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return FMOD5_Channel_GetDSPIndex(handle, dsp.handle, out index);
		}

		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel, ref VECTOR alt_pan_pos)
		{
			return FMOD5_Channel_Set3DAttributes(handle, ref pos, ref vel, ref alt_pan_pos);
		}

		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel, out VECTOR alt_pan_pos)
		{
			return FMOD5_Channel_Get3DAttributes(handle, out pos, out vel, out alt_pan_pos);
		}

		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return FMOD5_Channel_Set3DMinMaxDistance(handle, mindistance, maxdistance);
		}

		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return FMOD5_Channel_Get3DMinMaxDistance(handle, out mindistance, out maxdistance);
		}

		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return FMOD5_Channel_Set3DConeSettings(handle, insideconeangle, outsideconeangle, outsidevolume);
		}

		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return FMOD5_Channel_Get3DConeSettings(handle, out insideconeangle, out outsideconeangle, out outsidevolume);
		}

		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return FMOD5_Channel_Set3DConeOrientation(handle, ref orientation);
		}

		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return FMOD5_Channel_Get3DConeOrientation(handle, out orientation);
		}

		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return FMOD5_Channel_Set3DCustomRolloff(handle, ref points, numpoints);
		}

		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return FMOD5_Channel_Get3DCustomRolloff(handle, out points, out numpoints);
		}

		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return FMOD5_Channel_Set3DOcclusion(handle, directocclusion, reverbocclusion);
		}

		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return FMOD5_Channel_Get3DOcclusion(handle, out directocclusion, out reverbocclusion);
		}

		public RESULT set3DSpread(float angle)
		{
			return FMOD5_Channel_Set3DSpread(handle, angle);
		}

		public RESULT get3DSpread(out float angle)
		{
			return FMOD5_Channel_Get3DSpread(handle, out angle);
		}

		public RESULT set3DLevel(float level)
		{
			return FMOD5_Channel_Set3DLevel(handle, level);
		}

		public RESULT get3DLevel(out float level)
		{
			return FMOD5_Channel_Get3DLevel(handle, out level);
		}

		public RESULT set3DDopplerLevel(float level)
		{
			return FMOD5_Channel_Set3DDopplerLevel(handle, level);
		}

		public RESULT get3DDopplerLevel(out float level)
		{
			return FMOD5_Channel_Get3DDopplerLevel(handle, out level);
		}

		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return FMOD5_Channel_Set3DDistanceFilter(handle, custom, customLevel, centerFreq);
		}

		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return FMOD5_Channel_Get3DDistanceFilter(handle, out custom, out customLevel, out centerFreq);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_Channel_SetUserData(handle, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_Channel_GetUserData(handle, out userdata);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetFrequency(IntPtr channel, float frequency);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetFrequency(IntPtr channel, out float frequency);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetPriority(IntPtr channel, int priority);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetPriority(IntPtr channel, out int priority);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetPosition(IntPtr channel, uint position, TIMEUNIT postype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetPosition(IntPtr channel, out uint position, TIMEUNIT postype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetChannelGroup(IntPtr channel, IntPtr channelgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetChannelGroup(IntPtr channel, out IntPtr channelgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetLoopCount(IntPtr channel, int loopcount);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetLoopCount(IntPtr channel, out int loopcount);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetLoopPoints(IntPtr channel, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetLoopPoints(IntPtr channel, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_IsVirtual(IntPtr channel, out bool isvirtual);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetCurrentSound(IntPtr channel, out IntPtr sound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetIndex(IntPtr channel, out int index);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetSystemObject(IntPtr channel, out IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Stop(IntPtr channel);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetPaused(IntPtr channel, bool paused);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetPaused(IntPtr channel, out bool paused);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetVolume(IntPtr channel, float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetVolume(IntPtr channel, out float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetVolumeRamp(IntPtr channel, bool ramp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetVolumeRamp(IntPtr channel, out bool ramp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetAudibility(IntPtr channel, out float audibility);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetPitch(IntPtr channel, float pitch);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetPitch(IntPtr channel, out float pitch);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetMute(IntPtr channel, bool mute);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetMute(IntPtr channel, out bool mute);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetReverbProperties(IntPtr channel, int instance, float wet);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetReverbProperties(IntPtr channel, int instance, out float wet);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetLowPassGain(IntPtr channel, float gain);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetLowPassGain(IntPtr channel, out float gain);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetMode(IntPtr channel, MODE mode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetMode(IntPtr channel, out MODE mode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetCallback(IntPtr channel, CHANNEL_CALLBACK callback);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_IsPlaying(IntPtr channel, out bool isplaying);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetPan(IntPtr channel, float pan);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsOutput(IntPtr channel, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsInput(IntPtr channel, float[] levels, int numlevels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetMixMatrix(IntPtr channel, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetMixMatrix(IntPtr channel, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetDSPClock(IntPtr channel, out ulong dspclock, out ulong parentclock);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetDelay(IntPtr channel, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_AddFadePoint(IntPtr channel, ulong dspclock, float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetFadePointRamp(IntPtr channel, ulong dspclock, float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_RemoveFadePoints(IntPtr channel, ulong dspclock_start, ulong dspclock_end);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetFadePoints(IntPtr channel, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetDSP(IntPtr channel, int index, out IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_AddDSP(IntPtr channel, int index, IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_RemoveDSP(IntPtr channel, IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetNumDSPs(IntPtr channel, out int numdsps);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetDSPIndex(IntPtr channel, IntPtr dsp, int index);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetDSPIndex(IntPtr channel, IntPtr dsp, out int index);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Set3DAttributes(IntPtr channel, ref VECTOR pos, ref VECTOR vel, ref VECTOR alt_pan_pos);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Get3DAttributes(IntPtr channel, out VECTOR pos, out VECTOR vel, out VECTOR alt_pan_pos);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Set3DMinMaxDistance(IntPtr channel, float mindistance, float maxdistance);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Get3DMinMaxDistance(IntPtr channel, out float mindistance, out float maxdistance);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Set3DConeSettings(IntPtr channel, float insideconeangle, float outsideconeangle, float outsidevolume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Get3DConeSettings(IntPtr channel, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Set3DConeOrientation(IntPtr channel, ref VECTOR orientation);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Get3DConeOrientation(IntPtr channel, out VECTOR orientation);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Set3DCustomRolloff(IntPtr channel, ref VECTOR points, int numpoints);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Get3DCustomRolloff(IntPtr channel, out IntPtr points, out int numpoints);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Set3DOcclusion(IntPtr channel, float directocclusion, float reverbocclusion);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Get3DOcclusion(IntPtr channel, out float directocclusion, out float reverbocclusion);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Set3DSpread(IntPtr channel, float angle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Get3DSpread(IntPtr channel, out float angle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Set3DLevel(IntPtr channel, float level);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Get3DLevel(IntPtr channel, out float level);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Set3DDopplerLevel(IntPtr channel, float level);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Get3DDopplerLevel(IntPtr channel, out float level);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Set3DDistanceFilter(IntPtr channel, bool custom, float customLevel, float centerFreq);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_Get3DDistanceFilter(IntPtr channel, out bool custom, out float customLevel, out float centerFreq);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetUserData(IntPtr channel, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetUserData(IntPtr channel, out IntPtr userdata);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}
	}
	public struct ChannelGroup : IChannelControl
	{
		public IntPtr handle;

		public RESULT release()
		{
			return FMOD5_ChannelGroup_Release(handle);
		}

		public RESULT addGroup(ChannelGroup group, bool propagatedspclock, out DSPConnection connection)
		{
			return FMOD5_ChannelGroup_AddGroup(handle, group.handle, propagatedspclock, out connection.handle);
		}

		public RESULT getNumGroups(out int numgroups)
		{
			return FMOD5_ChannelGroup_GetNumGroups(handle, out numgroups);
		}

		public RESULT getGroup(int index, out ChannelGroup group)
		{
			return FMOD5_ChannelGroup_GetGroup(handle, index, out group.handle);
		}

		public RESULT getParentGroup(out ChannelGroup group)
		{
			return FMOD5_ChannelGroup_GetParentGroup(handle, out group.handle);
		}

		public RESULT getName(out string name, int namelen)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(namelen);
			RESULT result = FMOD5_ChannelGroup_GetName(handle, intPtr, namelen);
			using (StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper())
			{
				name = threadSafeEncoding.stringFromNative(intPtr);
			}
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT getNumChannels(out int numchannels)
		{
			return FMOD5_ChannelGroup_GetNumChannels(handle, out numchannels);
		}

		public RESULT getChannel(int index, out Channel channel)
		{
			return FMOD5_ChannelGroup_GetChannel(handle, index, out channel.handle);
		}

		public RESULT getSystemObject(out System system)
		{
			return FMOD5_ChannelGroup_GetSystemObject(handle, out system.handle);
		}

		public RESULT stop()
		{
			return FMOD5_ChannelGroup_Stop(handle);
		}

		public RESULT setPaused(bool paused)
		{
			return FMOD5_ChannelGroup_SetPaused(handle, paused);
		}

		public RESULT getPaused(out bool paused)
		{
			return FMOD5_ChannelGroup_GetPaused(handle, out paused);
		}

		public RESULT setVolume(float volume)
		{
			return FMOD5_ChannelGroup_SetVolume(handle, volume);
		}

		public RESULT getVolume(out float volume)
		{
			return FMOD5_ChannelGroup_GetVolume(handle, out volume);
		}

		public RESULT setVolumeRamp(bool ramp)
		{
			return FMOD5_ChannelGroup_SetVolumeRamp(handle, ramp);
		}

		public RESULT getVolumeRamp(out bool ramp)
		{
			return FMOD5_ChannelGroup_GetVolumeRamp(handle, out ramp);
		}

		public RESULT getAudibility(out float audibility)
		{
			return FMOD5_ChannelGroup_GetAudibility(handle, out audibility);
		}

		public RESULT setPitch(float pitch)
		{
			return FMOD5_ChannelGroup_SetPitch(handle, pitch);
		}

		public RESULT getPitch(out float pitch)
		{
			return FMOD5_ChannelGroup_GetPitch(handle, out pitch);
		}

		public RESULT setMute(bool mute)
		{
			return FMOD5_ChannelGroup_SetMute(handle, mute);
		}

		public RESULT getMute(out bool mute)
		{
			return FMOD5_ChannelGroup_GetMute(handle, out mute);
		}

		public RESULT setReverbProperties(int instance, float wet)
		{
			return FMOD5_ChannelGroup_SetReverbProperties(handle, instance, wet);
		}

		public RESULT getReverbProperties(int instance, out float wet)
		{
			return FMOD5_ChannelGroup_GetReverbProperties(handle, instance, out wet);
		}

		public RESULT setLowPassGain(float gain)
		{
			return FMOD5_ChannelGroup_SetLowPassGain(handle, gain);
		}

		public RESULT getLowPassGain(out float gain)
		{
			return FMOD5_ChannelGroup_GetLowPassGain(handle, out gain);
		}

		public RESULT setMode(MODE mode)
		{
			return FMOD5_ChannelGroup_SetMode(handle, mode);
		}

		public RESULT getMode(out MODE mode)
		{
			return FMOD5_ChannelGroup_GetMode(handle, out mode);
		}

		public RESULT setCallback(CHANNEL_CALLBACK callback)
		{
			return FMOD5_ChannelGroup_SetCallback(handle, callback);
		}

		public RESULT isPlaying(out bool isplaying)
		{
			return FMOD5_ChannelGroup_IsPlaying(handle, out isplaying);
		}

		public RESULT setPan(float pan)
		{
			return FMOD5_ChannelGroup_SetPan(handle, pan);
		}

		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return FMOD5_ChannelGroup_SetMixLevelsOutput(handle, frontleft, frontright, center, lfe, surroundleft, surroundright, backleft, backright);
		}

		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return FMOD5_ChannelGroup_SetMixLevelsInput(handle, levels, numlevels);
		}

		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
		{
			return FMOD5_ChannelGroup_SetMixMatrix(handle, matrix, outchannels, inchannels, inchannel_hop);
		}

		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
		{
			return FMOD5_ChannelGroup_GetMixMatrix(handle, matrix, out outchannels, out inchannels, inchannel_hop);
		}

		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return FMOD5_ChannelGroup_GetDSPClock(handle, out dspclock, out parentclock);
		}

		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels)
		{
			return FMOD5_ChannelGroup_SetDelay(handle, dspclock_start, dspclock_end, stopchannels);
		}

		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return FMOD5_ChannelGroup_GetDelay(handle, out dspclock_start, out dspclock_end, out stopchannels);
		}

		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return FMOD5_ChannelGroup_AddFadePoint(handle, dspclock, volume);
		}

		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return FMOD5_ChannelGroup_SetFadePointRamp(handle, dspclock, volume);
		}

		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return FMOD5_ChannelGroup_RemoveFadePoints(handle, dspclock_start, dspclock_end);
		}

		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return FMOD5_ChannelGroup_GetFadePoints(handle, ref numpoints, point_dspclock, point_volume);
		}

		public RESULT getDSP(int index, out DSP dsp)
		{
			return FMOD5_ChannelGroup_GetDSP(handle, index, out dsp.handle);
		}

		public RESULT addDSP(int index, DSP dsp)
		{
			return FMOD5_ChannelGroup_AddDSP(handle, index, dsp.handle);
		}

		public RESULT removeDSP(DSP dsp)
		{
			return FMOD5_ChannelGroup_RemoveDSP(handle, dsp.handle);
		}

		public RESULT getNumDSPs(out int numdsps)
		{
			return FMOD5_ChannelGroup_GetNumDSPs(handle, out numdsps);
		}

		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return FMOD5_ChannelGroup_SetDSPIndex(handle, dsp.handle, index);
		}

		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return FMOD5_ChannelGroup_GetDSPIndex(handle, dsp.handle, out index);
		}

		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel, ref VECTOR alt_pan_pos)
		{
			return FMOD5_ChannelGroup_Set3DAttributes(handle, ref pos, ref vel, ref alt_pan_pos);
		}

		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel, out VECTOR alt_pan_pos)
		{
			return FMOD5_ChannelGroup_Get3DAttributes(handle, out pos, out vel, out alt_pan_pos);
		}

		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return FMOD5_ChannelGroup_Set3DMinMaxDistance(handle, mindistance, maxdistance);
		}

		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return FMOD5_ChannelGroup_Get3DMinMaxDistance(handle, out mindistance, out maxdistance);
		}

		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return FMOD5_ChannelGroup_Set3DConeSettings(handle, insideconeangle, outsideconeangle, outsidevolume);
		}

		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return FMOD5_ChannelGroup_Get3DConeSettings(handle, out insideconeangle, out outsideconeangle, out outsidevolume);
		}

		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return FMOD5_ChannelGroup_Set3DConeOrientation(handle, ref orientation);
		}

		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return FMOD5_ChannelGroup_Get3DConeOrientation(handle, out orientation);
		}

		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return FMOD5_ChannelGroup_Set3DCustomRolloff(handle, ref points, numpoints);
		}

		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return FMOD5_ChannelGroup_Get3DCustomRolloff(handle, out points, out numpoints);
		}

		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return FMOD5_ChannelGroup_Set3DOcclusion(handle, directocclusion, reverbocclusion);
		}

		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return FMOD5_ChannelGroup_Get3DOcclusion(handle, out directocclusion, out reverbocclusion);
		}

		public RESULT set3DSpread(float angle)
		{
			return FMOD5_ChannelGroup_Set3DSpread(handle, angle);
		}

		public RESULT get3DSpread(out float angle)
		{
			return FMOD5_ChannelGroup_Get3DSpread(handle, out angle);
		}

		public RESULT set3DLevel(float level)
		{
			return FMOD5_ChannelGroup_Set3DLevel(handle, level);
		}

		public RESULT get3DLevel(out float level)
		{
			return FMOD5_ChannelGroup_Get3DLevel(handle, out level);
		}

		public RESULT set3DDopplerLevel(float level)
		{
			return FMOD5_ChannelGroup_Set3DDopplerLevel(handle, level);
		}

		public RESULT get3DDopplerLevel(out float level)
		{
			return FMOD5_ChannelGroup_Get3DDopplerLevel(handle, out level);
		}

		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return FMOD5_ChannelGroup_Set3DDistanceFilter(handle, custom, customLevel, centerFreq);
		}

		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return FMOD5_ChannelGroup_Get3DDistanceFilter(handle, out custom, out customLevel, out centerFreq);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_ChannelGroup_SetUserData(handle, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_ChannelGroup_GetUserData(handle, out userdata);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Release(IntPtr channelgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propogatedspclocks, out IntPtr connection);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumGroups(IntPtr channelgroup, out int numgroups);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetGroup(IntPtr channelgroup, int index, out IntPtr group);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetParentGroup(IntPtr channelgroup, out IntPtr group);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetName(IntPtr channelgroup, IntPtr name, int namelen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumChannels(IntPtr channelgroup, out int numchannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetChannel(IntPtr channelgroup, int index, out IntPtr channel);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetSystemObject(IntPtr channelgroup, out IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Stop(IntPtr channelgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetPaused(IntPtr channelgroup, bool paused);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetPaused(IntPtr channelgroup, out bool paused);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolume(IntPtr channelgroup, float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolume(IntPtr channelgroup, out float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolumeRamp(IntPtr channelgroup, bool ramp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolumeRamp(IntPtr channelgroup, out bool ramp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetAudibility(IntPtr channelgroup, out float audibility);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetPitch(IntPtr channelgroup, float pitch);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetPitch(IntPtr channelgroup, out float pitch);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetMute(IntPtr channelgroup, bool mute);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetMute(IntPtr channelgroup, out bool mute);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetReverbProperties(IntPtr channelgroup, int instance, float wet);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetReverbProperties(IntPtr channelgroup, int instance, out float wet);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetLowPassGain(IntPtr channelgroup, float gain);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetLowPassGain(IntPtr channelgroup, out float gain);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetMode(IntPtr channelgroup, MODE mode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetMode(IntPtr channelgroup, out MODE mode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetCallback(IntPtr channelgroup, CHANNEL_CALLBACK callback);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_IsPlaying(IntPtr channelgroup, out bool isplaying);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetPan(IntPtr channelgroup, float pan);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsOutput(IntPtr channelgroup, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsInput(IntPtr channelgroup, float[] levels, int numlevels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixMatrix(IntPtr channelgroup, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetMixMatrix(IntPtr channelgroup, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPClock(IntPtr channelgroup, out ulong dspclock, out ulong parentclock);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetDelay(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_AddFadePoint(IntPtr channelgroup, ulong dspclock, float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetFadePointRamp(IntPtr channelgroup, ulong dspclock, float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveFadePoints(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetFadePoints(IntPtr channelgroup, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_AddDSP(IntPtr channelgroup, int index, IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveDSP(IntPtr channelgroup, IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetDSPIndex(IntPtr channelgroup, IntPtr dsp, int index);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPIndex(IntPtr channelgroup, IntPtr dsp, out int index);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DAttributes(IntPtr channelgroup, ref VECTOR pos, ref VECTOR vel, ref VECTOR alt_pan_pos);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DAttributes(IntPtr channelgroup, out VECTOR pos, out VECTOR vel, out VECTOR alt_pan_pos);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DMinMaxDistance(IntPtr channelgroup, float mindistance, float maxdistance);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DMinMaxDistance(IntPtr channelgroup, out float mindistance, out float maxdistance);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeSettings(IntPtr channelgroup, float insideconeangle, float outsideconeangle, float outsidevolume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeSettings(IntPtr channelgroup, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeOrientation(IntPtr channelgroup, ref VECTOR orientation);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeOrientation(IntPtr channelgroup, out VECTOR orientation);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DCustomRolloff(IntPtr channelgroup, ref VECTOR points, int numpoints);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DCustomRolloff(IntPtr channelgroup, out IntPtr points, out int numpoints);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DOcclusion(IntPtr channelgroup, float directocclusion, float reverbocclusion);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DOcclusion(IntPtr channelgroup, out float directocclusion, out float reverbocclusion);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DSpread(IntPtr channelgroup, float angle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DSpread(IntPtr channelgroup, out float angle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DLevel(IntPtr channelgroup, float level);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DLevel(IntPtr channelgroup, out float level);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDopplerLevel(IntPtr channelgroup, float level);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDopplerLevel(IntPtr channelgroup, out float level);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDistanceFilter(IntPtr channelgroup, bool custom, float customLevel, float centerFreq);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDistanceFilter(IntPtr channelgroup, out bool custom, out float customLevel, out float centerFreq);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetUserData(IntPtr channelgroup, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetUserData(IntPtr channelgroup, out IntPtr userdata);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}
	}
	public struct SoundGroup
	{
		public IntPtr handle;

		public RESULT release()
		{
			return FMOD5_SoundGroup_Release(handle);
		}

		public RESULT getSystemObject(out System system)
		{
			return FMOD5_SoundGroup_GetSystemObject(handle, out system.handle);
		}

		public RESULT setMaxAudible(int maxaudible)
		{
			return FMOD5_SoundGroup_SetMaxAudible(handle, maxaudible);
		}

		public RESULT getMaxAudible(out int maxaudible)
		{
			return FMOD5_SoundGroup_GetMaxAudible(handle, out maxaudible);
		}

		public RESULT setMaxAudibleBehavior(SOUNDGROUP_BEHAVIOR behavior)
		{
			return FMOD5_SoundGroup_SetMaxAudibleBehavior(handle, behavior);
		}

		public RESULT getMaxAudibleBehavior(out SOUNDGROUP_BEHAVIOR behavior)
		{
			return FMOD5_SoundGroup_GetMaxAudibleBehavior(handle, out behavior);
		}

		public RESULT setMuteFadeSpeed(float speed)
		{
			return FMOD5_SoundGroup_SetMuteFadeSpeed(handle, speed);
		}

		public RESULT getMuteFadeSpeed(out float speed)
		{
			return FMOD5_SoundGroup_GetMuteFadeSpeed(handle, out speed);
		}

		public RESULT setVolume(float volume)
		{
			return FMOD5_SoundGroup_SetVolume(handle, volume);
		}

		public RESULT getVolume(out float volume)
		{
			return FMOD5_SoundGroup_GetVolume(handle, out volume);
		}

		public RESULT stop()
		{
			return FMOD5_SoundGroup_Stop(handle);
		}

		public RESULT getName(out string name, int namelen)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(namelen);
			RESULT result = FMOD5_SoundGroup_GetName(handle, intPtr, namelen);
			using (StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper())
			{
				name = threadSafeEncoding.stringFromNative(intPtr);
			}
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT getNumSounds(out int numsounds)
		{
			return FMOD5_SoundGroup_GetNumSounds(handle, out numsounds);
		}

		public RESULT getSound(int index, out Sound sound)
		{
			return FMOD5_SoundGroup_GetSound(handle, index, out sound.handle);
		}

		public RESULT getNumPlaying(out int numplaying)
		{
			return FMOD5_SoundGroup_GetNumPlaying(handle, out numplaying);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_SoundGroup_SetUserData(handle, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_SoundGroup_GetUserData(handle, out userdata);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_Release(IntPtr soundgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetSystemObject(IntPtr soundgroup, out IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudible(IntPtr soundgroup, int maxaudible);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudible(IntPtr soundgroup, out int maxaudible);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudibleBehavior(IntPtr soundgroup, SOUNDGROUP_BEHAVIOR behavior);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudibleBehavior(IntPtr soundgroup, out SOUNDGROUP_BEHAVIOR behavior);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_SetMuteFadeSpeed(IntPtr soundgroup, float speed);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetMuteFadeSpeed(IntPtr soundgroup, out float speed);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_SetVolume(IntPtr soundgroup, float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetVolume(IntPtr soundgroup, out float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_Stop(IntPtr soundgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetName(IntPtr soundgroup, IntPtr name, int namelen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetNumSounds(IntPtr soundgroup, out int numsounds);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetSound(IntPtr soundgroup, int index, out IntPtr sound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetNumPlaying(IntPtr soundgroup, out int numplaying);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_SetUserData(IntPtr soundgroup, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetUserData(IntPtr soundgroup, out IntPtr userdata);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}
	}
	public struct DSP
	{
		public IntPtr handle;

		public RESULT release()
		{
			return FMOD5_DSP_Release(handle);
		}

		public RESULT getSystemObject(out System system)
		{
			return FMOD5_DSP_GetSystemObject(handle, out system.handle);
		}

		public RESULT addInput(DSP target, out DSPConnection connection, DSPCONNECTION_TYPE type)
		{
			return FMOD5_DSP_AddInput(handle, target.handle, out connection.handle, type);
		}

		public RESULT disconnectFrom(DSP target, DSPConnection connection)
		{
			return FMOD5_DSP_DisconnectFrom(handle, target.handle, connection.handle);
		}

		public RESULT disconnectAll(bool inputs, bool outputs)
		{
			return FMOD5_DSP_DisconnectAll(handle, inputs, outputs);
		}

		public RESULT getNumInputs(out int numinputs)
		{
			return FMOD5_DSP_GetNumInputs(handle, out numinputs);
		}

		public RESULT getNumOutputs(out int numoutputs)
		{
			return FMOD5_DSP_GetNumOutputs(handle, out numoutputs);
		}

		public RESULT getInput(int index, out DSP input, out DSPConnection inputconnection)
		{
			return FMOD5_DSP_GetInput(handle, index, out input.handle, out inputconnection.handle);
		}

		public RESULT getOutput(int index, out DSP output, out DSPConnection outputconnection)
		{
			return FMOD5_DSP_GetOutput(handle, index, out output.handle, out outputconnection.handle);
		}

		public RESULT setActive(bool active)
		{
			return FMOD5_DSP_SetActive(handle, active);
		}

		public RESULT getActive(out bool active)
		{
			return FMOD5_DSP_GetActive(handle, out active);
		}

		public RESULT setBypass(bool bypass)
		{
			return FMOD5_DSP_SetBypass(handle, bypass);
		}

		public RESULT getBypass(out bool bypass)
		{
			return FMOD5_DSP_GetBypass(handle, out bypass);
		}

		public RESULT setWetDryMix(float prewet, float postwet, float dry)
		{
			return FMOD5_DSP_SetWetDryMix(handle, prewet, postwet, dry);
		}

		public RESULT getWetDryMix(out float prewet, out float postwet, out float dry)
		{
			return FMOD5_DSP_GetWetDryMix(handle, out prewet, out postwet, out dry);
		}

		public RESULT setChannelFormat(CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode)
		{
			return FMOD5_DSP_SetChannelFormat(handle, channelmask, numchannels, source_speakermode);
		}

		public RESULT getChannelFormat(out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode)
		{
			return FMOD5_DSP_GetChannelFormat(handle, out channelmask, out numchannels, out source_speakermode);
		}

		public RESULT getOutputChannelFormat(CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode)
		{
			return FMOD5_DSP_GetOutputChannelFormat(handle, inmask, inchannels, inspeakermode, out outmask, out outchannels, out outspeakermode);
		}

		public RESULT reset()
		{
			return FMOD5_DSP_Reset(handle);
		}

		public RESULT setParameterFloat(int index, float value)
		{
			return FMOD5_DSP_SetParameterFloat(handle, index, value);
		}

		public RESULT setParameterInt(int index, int value)
		{
			return FMOD5_DSP_SetParameterInt(handle, index, value);
		}

		public RESULT setParameterBool(int index, bool value)
		{
			return FMOD5_DSP_SetParameterBool(handle, index, value);
		}

		public RESULT setParameterData(int index, byte[] data)
		{
			return FMOD5_DSP_SetParameterData(handle, index, Marshal.UnsafeAddrOfPinnedArrayElement(data, 0), (uint)data.Length);
		}

		public RESULT getParameterFloat(int index, out float value)
		{
			return FMOD5_DSP_GetParameterFloat(handle, index, out value, IntPtr.Zero, 0);
		}

		public RESULT getParameterInt(int index, out int value)
		{
			return FMOD5_DSP_GetParameterInt(handle, index, out value, IntPtr.Zero, 0);
		}

		public RESULT getParameterBool(int index, out bool value)
		{
			return FMOD5_DSP_GetParameterBool(handle, index, out value, IntPtr.Zero, 0);
		}

		public RESULT getParameterData(int index, out IntPtr data, out uint length)
		{
			return FMOD5_DSP_GetParameterData(handle, index, out data, out length, IntPtr.Zero, 0);
		}

		public RESULT getNumParameters(out int numparams)
		{
			return FMOD5_DSP_GetNumParameters(handle, out numparams);
		}

		public RESULT getParameterInfo(int index, out DSP_PARAMETER_DESC desc)
		{
			return FMOD5_DSP_GetParameterInfo(handle, index, out desc);
		}

		public RESULT getDataParameterIndex(int datatype, out int index)
		{
			return FMOD5_DSP_GetDataParameterIndex(handle, datatype, out index);
		}

		public RESULT showConfigDialog(IntPtr hwnd, bool show)
		{
			return FMOD5_DSP_ShowConfigDialog(handle, hwnd, show);
		}

		public RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(32);
			RESULT result = FMOD5_DSP_GetInfo(handle, intPtr, out version, out channels, out configwidth, out configheight);
			using (StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper())
			{
				name = threadSafeEncoding.stringFromNative(intPtr);
			}
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT getInfo(out uint version, out int channels, out int configwidth, out int configheight)
		{
			return FMOD5_DSP_GetInfo(handle, IntPtr.Zero, out version, out channels, out configwidth, out configheight);
		}

		public RESULT getType(out DSP_TYPE type)
		{
			return FMOD5_DSP_GetType(handle, out type);
		}

		public RESULT getIdle(out bool idle)
		{
			return FMOD5_DSP_GetIdle(handle, out idle);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_DSP_SetUserData(handle, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_DSP_GetUserData(handle, out userdata);
		}

		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled)
		{
			return FMOD5_DSP_SetMeteringEnabled(handle, inputEnabled, outputEnabled);
		}

		public RESULT getMeteringEnabled(out bool inputEnabled, out bool outputEnabled)
		{
			return FMOD5_DSP_GetMeteringEnabled(handle, out inputEnabled, out outputEnabled);
		}

		public RESULT getMeteringInfo(IntPtr zero, out DSP_METERING_INFO outputInfo)
		{
			return FMOD5_DSP_GetMeteringInfo(handle, zero, out outputInfo);
		}

		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, IntPtr zero)
		{
			return FMOD5_DSP_GetMeteringInfo(handle, out inputInfo, zero);
		}

		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return FMOD5_DSP_GetCPUUsage(handle, out exclusive, out inclusive);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_Release(IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetSystemObject(IntPtr dsp, out IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr target, out IntPtr connection, DSPCONNECTION_TYPE type);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_DisconnectFrom(IntPtr dsp, IntPtr target, IntPtr connection);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_DisconnectAll(IntPtr dsp, bool inputs, bool outputs);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetNumInputs(IntPtr dsp, out int numinputs);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetNumOutputs(IntPtr dsp, out int numoutputs);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetInput(IntPtr dsp, int index, out IntPtr input, out IntPtr inputconnection);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetOutput(IntPtr dsp, int index, out IntPtr output, out IntPtr outputconnection);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetActive(IntPtr dsp, bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetActive(IntPtr dsp, out bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetBypass(IntPtr dsp, bool bypass);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetBypass(IntPtr dsp, out bool bypass);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetWetDryMix(IntPtr dsp, float prewet, float postwet, float dry);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetWetDryMix(IntPtr dsp, out float prewet, out float postwet, out float dry);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetChannelFormat(IntPtr dsp, CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetChannelFormat(IntPtr dsp, out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetOutputChannelFormat(IntPtr dsp, CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_Reset(IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetParameterFloat(IntPtr dsp, int index, float value);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetParameterInt(IntPtr dsp, int index, int value);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetParameterBool(IntPtr dsp, int index, bool value);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, IntPtr data, uint length);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetParameterFloat(IntPtr dsp, int index, out float value, IntPtr valuestr, int valuestrlen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetParameterInt(IntPtr dsp, int index, out int value, IntPtr valuestr, int valuestrlen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetParameterBool(IntPtr dsp, int index, out bool value, IntPtr valuestr, int valuestrlen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetParameterData(IntPtr dsp, int index, out IntPtr data, out uint length, IntPtr valuestr, int valuestrlen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetNumParameters(IntPtr dsp, out int numparams);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetParameterInfo(IntPtr dsp, int index, out DSP_PARAMETER_DESC desc);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetDataParameterIndex(IntPtr dsp, int datatype, out int index);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_ShowConfigDialog(IntPtr dsp, IntPtr hwnd, bool show);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetType(IntPtr dsp, out DSP_TYPE type);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetIdle(IntPtr dsp, out bool idle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetUserData(IntPtr dsp, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetUserData(IntPtr dsp, out IntPtr userdata);

		[DllImport("fmod")]
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled);

		[DllImport("fmod")]
		public static extern RESULT FMOD5_DSP_GetMeteringEnabled(IntPtr dsp, out bool inputEnabled, out bool outputEnabled);

		[DllImport("fmod")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, IntPtr zero, out DSP_METERING_INFO outputInfo);

		[DllImport("fmod")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, IntPtr zero);

		[DllImport("fmod")]
		public static extern RESULT FMOD5_DSP_GetCPUUsage(IntPtr dsp, out uint exclusive, out uint inclusive);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}
	}
	public struct DSPConnection
	{
		public IntPtr handle;

		public RESULT getInput(out DSP input)
		{
			return FMOD5_DSPConnection_GetInput(handle, out input.handle);
		}

		public RESULT getOutput(out DSP output)
		{
			return FMOD5_DSPConnection_GetOutput(handle, out output.handle);
		}

		public RESULT setMix(float volume)
		{
			return FMOD5_DSPConnection_SetMix(handle, volume);
		}

		public RESULT getMix(out float volume)
		{
			return FMOD5_DSPConnection_GetMix(handle, out volume);
		}

		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
		{
			return FMOD5_DSPConnection_SetMixMatrix(handle, matrix, outchannels, inchannels, inchannel_hop);
		}

		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
		{
			return FMOD5_DSPConnection_GetMixMatrix(handle, matrix, out outchannels, out inchannels, inchannel_hop);
		}

		public RESULT getType(out DSPCONNECTION_TYPE type)
		{
			return FMOD5_DSPConnection_GetType(handle, out type);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_DSPConnection_SetUserData(handle, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_DSPConnection_GetUserData(handle, out userdata);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_SetMix(IntPtr dspconnection, float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_GetMix(IntPtr dspconnection, out float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_GetType(IntPtr dspconnection, out DSPCONNECTION_TYPE type);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}
	}
	public struct Geometry
	{
		public IntPtr handle;

		public RESULT release()
		{
			return FMOD5_Geometry_Release(handle);
		}

		public RESULT addPolygon(float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex)
		{
			return FMOD5_Geometry_AddPolygon(handle, directocclusion, reverbocclusion, doublesided, numvertices, vertices, out polygonindex);
		}

		public RESULT getNumPolygons(out int numpolygons)
		{
			return FMOD5_Geometry_GetNumPolygons(handle, out numpolygons);
		}

		public RESULT getMaxPolygons(out int maxpolygons, out int maxvertices)
		{
			return FMOD5_Geometry_GetMaxPolygons(handle, out maxpolygons, out maxvertices);
		}

		public RESULT getPolygonNumVertices(int index, out int numvertices)
		{
			return FMOD5_Geometry_GetPolygonNumVertices(handle, index, out numvertices);
		}

		public RESULT setPolygonVertex(int index, int vertexindex, ref VECTOR vertex)
		{
			return FMOD5_Geometry_SetPolygonVertex(handle, index, vertexindex, ref vertex);
		}

		public RESULT getPolygonVertex(int index, int vertexindex, out VECTOR vertex)
		{
			return FMOD5_Geometry_GetPolygonVertex(handle, index, vertexindex, out vertex);
		}

		public RESULT setPolygonAttributes(int index, float directocclusion, float reverbocclusion, bool doublesided)
		{
			return FMOD5_Geometry_SetPolygonAttributes(handle, index, directocclusion, reverbocclusion, doublesided);
		}

		public RESULT getPolygonAttributes(int index, out float directocclusion, out float reverbocclusion, out bool doublesided)
		{
			return FMOD5_Geometry_GetPolygonAttributes(handle, index, out directocclusion, out reverbocclusion, out doublesided);
		}

		public RESULT setActive(bool active)
		{
			return FMOD5_Geometry_SetActive(handle, active);
		}

		public RESULT getActive(out bool active)
		{
			return FMOD5_Geometry_GetActive(handle, out active);
		}

		public RESULT setRotation(ref VECTOR forward, ref VECTOR up)
		{
			return FMOD5_Geometry_SetRotation(handle, ref forward, ref up);
		}

		public RESULT getRotation(out VECTOR forward, out VECTOR up)
		{
			return FMOD5_Geometry_GetRotation(handle, out forward, out up);
		}

		public RESULT setPosition(ref VECTOR position)
		{
			return FMOD5_Geometry_SetPosition(handle, ref position);
		}

		public RESULT getPosition(out VECTOR position)
		{
			return FMOD5_Geometry_GetPosition(handle, out position);
		}

		public RESULT setScale(ref VECTOR scale)
		{
			return FMOD5_Geometry_SetScale(handle, ref scale);
		}

		public RESULT getScale(out VECTOR scale)
		{
			return FMOD5_Geometry_GetScale(handle, out scale);
		}

		public RESULT save(IntPtr data, out int datasize)
		{
			return FMOD5_Geometry_Save(handle, data, out datasize);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_Geometry_SetUserData(handle, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_Geometry_GetUserData(handle, out userdata);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_Release(IntPtr geometry);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_AddPolygon(IntPtr geometry, float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetNumPolygons(IntPtr geometry, out int numpolygons);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetMaxPolygons(IntPtr geometry, out int maxpolygons, out int maxvertices);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetPolygonNumVertices(IntPtr geometry, int index, out int numvertices);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_SetPolygonVertex(IntPtr geometry, int index, int vertexindex, ref VECTOR vertex);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetPolygonVertex(IntPtr geometry, int index, int vertexindex, out VECTOR vertex);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_SetPolygonAttributes(IntPtr geometry, int index, float directocclusion, float reverbocclusion, bool doublesided);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetPolygonAttributes(IntPtr geometry, int index, out float directocclusion, out float reverbocclusion, out bool doublesided);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_SetActive(IntPtr geometry, bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetActive(IntPtr geometry, out bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_SetRotation(IntPtr geometry, ref VECTOR forward, ref VECTOR up);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetRotation(IntPtr geometry, out VECTOR forward, out VECTOR up);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_SetPosition(IntPtr geometry, ref VECTOR position);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetPosition(IntPtr geometry, out VECTOR position);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_SetScale(IntPtr geometry, ref VECTOR scale);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetScale(IntPtr geometry, out VECTOR scale);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_Save(IntPtr geometry, IntPtr data, out int datasize);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_SetUserData(IntPtr geometry, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetUserData(IntPtr geometry, out IntPtr userdata);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}
	}
	public struct Reverb3D
	{
		public IntPtr handle;

		public RESULT release()
		{
			return FMOD5_Reverb3D_Release(handle);
		}

		public RESULT set3DAttributes(ref VECTOR position, float mindistance, float maxdistance)
		{
			return FMOD5_Reverb3D_Set3DAttributes(handle, ref position, mindistance, maxdistance);
		}

		public RESULT get3DAttributes(ref VECTOR position, ref float mindistance, ref float maxdistance)
		{
			return FMOD5_Reverb3D_Get3DAttributes(handle, ref position, ref mindistance, ref maxdistance);
		}

		public RESULT setProperties(ref REVERB_PROPERTIES properties)
		{
			return FMOD5_Reverb3D_SetProperties(handle, ref properties);
		}

		public RESULT getProperties(ref REVERB_PROPERTIES properties)
		{
			return FMOD5_Reverb3D_GetProperties(handle, ref properties);
		}

		public RESULT setActive(bool active)
		{
			return FMOD5_Reverb3D_SetActive(handle, active);
		}

		public RESULT getActive(out bool active)
		{
			return FMOD5_Reverb3D_GetActive(handle, out active);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_Reverb3D_SetUserData(handle, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_Reverb3D_GetUserData(handle, out userdata);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_Release(IntPtr reverb);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_Set3DAttributes(IntPtr reverb, ref VECTOR position, float mindistance, float maxdistance);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_Get3DAttributes(IntPtr reverb, ref VECTOR position, ref float mindistance, ref float maxdistance);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_SetProperties(IntPtr reverb, ref REVERB_PROPERTIES properties);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_GetProperties(IntPtr reverb, ref REVERB_PROPERTIES properties);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_SetActive(IntPtr reverb, bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_GetActive(IntPtr reverb, out bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_SetUserData(IntPtr reverb, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_GetUserData(IntPtr reverb, out IntPtr userdata);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}
	}
	public struct StringWrapper
	{
		private IntPtr nativeUtf8Ptr;

		public static implicit operator string(StringWrapper fstring)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return threadSafeEncoding.stringFromNative(fstring.nativeUtf8Ptr);
		}
	}
	internal static class StringHelper
	{
		public class ThreadSafeEncoding : IDisposable
		{
			private UTF8Encoding encoding = new UTF8Encoding();

			private byte[] encodedBuffer = new byte[128];

			private char[] decodedBuffer = new char[128];

			private bool inUse;

			public bool InUse()
			{
				return inUse;
			}

			public void SetInUse()
			{
				inUse = true;
			}

			private int roundUpPowerTwo(int number)
			{
				int num;
				for (num = 1; num <= number; num *= 2)
				{
				}
				return num;
			}

			public byte[] byteFromStringUTF8(string s)
			{
				if (s == null)
				{
					return null;
				}
				if (encoding.GetMaxByteCount(s.Length) + 1 > encodedBuffer.Length)
				{
					int num = encoding.GetByteCount(s) + 1;
					if (num > encodedBuffer.Length)
					{
						encodedBuffer = new byte[roundUpPowerTwo(num)];
					}
				}
				int bytes = encoding.GetBytes(s, 0, s.Length, encodedBuffer, 0);
				encodedBuffer[bytes] = 0;
				return encodedBuffer;
			}

			public string stringFromNative(IntPtr nativePtr)
			{
				if (nativePtr == IntPtr.Zero)
				{
					return "";
				}
				int i;
				for (i = 0; Marshal.ReadByte(nativePtr, i) != 0; i++)
				{
				}
				if (i == 0)
				{
					return "";
				}
				if (i > encodedBuffer.Length)
				{
					encodedBuffer = new byte[roundUpPowerTwo(i)];
				}
				Marshal.Copy(nativePtr, encodedBuffer, 0, i);
				if (encoding.GetMaxCharCount(i) > decodedBuffer.Length)
				{
					int charCount = encoding.GetCharCount(encodedBuffer, 0, i);
					if (charCount > decodedBuffer.Length)
					{
						decodedBuffer = new char[roundUpPowerTwo(charCount)];
					}
				}
				int chars = encoding.GetChars(encodedBuffer, 0, i, decodedBuffer, 0);
				return new string(decodedBuffer, 0, chars);
			}

			public void Dispose()
			{
				lock (encoders)
				{
					inUse = false;
				}
			}
		}

		private static List<ThreadSafeEncoding> encoders = new List<ThreadSafeEncoding>(1);

		public static ThreadSafeEncoding GetFreeHelper()
		{
			lock (encoders)
			{
				ThreadSafeEncoding threadSafeEncoding = null;
				for (int i = 0; i < encoders.Count; i++)
				{
					if (!encoders[i].InUse())
					{
						threadSafeEncoding = encoders[i];
						break;
					}
				}
				if (threadSafeEncoding == null)
				{
					threadSafeEncoding = new ThreadSafeEncoding();
					encoders.Add(threadSafeEncoding);
				}
				threadSafeEncoding.SetInUse();
				return threadSafeEncoding;
			}
		}
	}
	public struct DSP_BUFFER_ARRAY
	{
		public int numbuffers;

		public int[] buffernumchannels;

		public CHANNELMASK[] bufferchannelmask;

		public IntPtr[] buffers;

		public SPEAKERMODE speakermode;
	}
	public enum DSP_PROCESS_OPERATION
	{
		PROCESS_PERFORM,
		PROCESS_QUERY
	}
	public struct COMPLEX
	{
		public float real;

		public float imag;
	}
	public enum DSP_PAN_SURROUND_FLAGS
	{
		DEFAULT,
		ROTATION_NOT_BIASED
	}
	public delegate RESULT DSP_CREATECALLBACK(ref DSP_STATE dsp_state);
	public delegate RESULT DSP_RELEASECALLBACK(ref DSP_STATE dsp_state);
	public delegate RESULT DSP_RESETCALLBACK(ref DSP_STATE dsp_state);
	public delegate RESULT DSP_SETPOSITIONCALLBACK(ref DSP_STATE dsp_state, uint pos);
	public delegate RESULT DSP_READCALLBACK(ref DSP_STATE dsp_state, IntPtr inbuffer, IntPtr outbuffer, uint length, int inchannels, ref int outchannels);
	public delegate RESULT DSP_SHOULDIPROCESS_CALLBACK(ref DSP_STATE dsp_state, bool inputsidle, uint length, CHANNELMASK inmask, int inchannels, SPEAKERMODE speakermode);
	public delegate RESULT DSP_PROCESS_CALLBACK(ref DSP_STATE dsp_state, uint length, ref DSP_BUFFER_ARRAY inbufferarray, ref DSP_BUFFER_ARRAY outbufferarray, bool inputsidle, DSP_PROCESS_OPERATION op);
	public delegate RESULT DSP_SETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, float value);
	public delegate RESULT DSP_SETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, int value);
	public delegate RESULT DSP_SETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, bool value);
	public delegate RESULT DSP_SETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, IntPtr data, uint length);
	public delegate RESULT DSP_GETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, ref float value, IntPtr valuestr);
	public delegate RESULT DSP_GETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, ref int value, IntPtr valuestr);
	public delegate RESULT DSP_GETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, ref bool value, IntPtr valuestr);
	public delegate RESULT DSP_GETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, ref IntPtr data, ref uint length, IntPtr valuestr);
	public delegate RESULT DSP_SYSTEM_REGISTER_CALLBACK(ref DSP_STATE dsp_state);
	public delegate RESULT DSP_SYSTEM_DEREGISTER_CALLBACK(ref DSP_STATE dsp_state);
	public delegate RESULT DSP_SYSTEM_MIX_CALLBACK(ref DSP_STATE dsp_state, int stage);
	public delegate IntPtr DSP_ALLOC_FUNC(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	public delegate IntPtr DSP_REALLOC_FUNC(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	public delegate void DSP_FREE_FUNC(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	public delegate void DSP_LOG_FUNC(DEBUG_FLAGS level, StringWrapper file, int line, StringWrapper function, StringWrapper format);
	public delegate RESULT DSP_GETSAMPLERATE_FUNC(ref DSP_STATE dsp_state, ref int rate);
	public delegate RESULT DSP_GETBLOCKSIZE_FUNC(ref DSP_STATE dsp_state, ref uint blocksize);
	public delegate RESULT DSP_GETSPEAKERMODE_FUNC(ref DSP_STATE dsp_state, ref int speakermode_mixer, ref int speakermode_output);
	public delegate RESULT DSP_GETCLOCK_FUNC(ref DSP_STATE dsp_state, out ulong clock, out uint offset, out uint length);
	public delegate RESULT DSP_GETLISTENERATTRIBUTES_FUNC(ref DSP_STATE dsp_state, ref int numlisteners, IntPtr attributes);
	public delegate RESULT DSP_GETUSERDATA_FUNC(ref DSP_STATE dsp_state, out IntPtr userdata);
	public delegate RESULT DSP_DFT_FFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr signal, IntPtr dft, IntPtr window, int signalhop);
	public delegate RESULT DSP_DFT_IFFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr dft, IntPtr signal, IntPtr window, int signalhop);
	public delegate RESULT DSP_PAN_SUMMONOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float lowFrequencyGain, float overallGain, IntPtr matrix);
	public delegate RESULT DSP_PAN_SUMSTEREOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float pan, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	public delegate RESULT DSP_PAN_SUMSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix, DSP_PAN_SURROUND_FLAGS flags);
	public delegate RESULT DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	public delegate RESULT DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	public delegate RESULT DSP_PAN_GETROLLOFFGAIN_FUNC(ref DSP_STATE dsp_state, DSP_PAN_3D_ROLLOFF_TYPE rolloff, float distance, float mindistance, float maxdistance, out float gain);
	public enum DSP_TYPE
	{
		UNKNOWN,
		MIXER,
		OSCILLATOR,
		LOWPASS,
		ITLOWPASS,
		HIGHPASS,
		ECHO,
		FADER,
		FLANGE,
		DISTORTION,
		NORMALIZE,
		LIMITER,
		PARAMEQ,
		PITCHSHIFT,
		CHORUS,
		VSTPLUGIN,
		WINAMPPLUGIN,
		ITECHO,
		COMPRESSOR,
		SFXREVERB,
		LOWPASS_SIMPLE,
		DELAY,
		TREMOLO,
		LADSPAPLUGIN,
		SEND,
		RETURN,
		HIGHPASS_SIMPLE,
		PAN,
		THREE_EQ,
		FFT,
		LOUDNESS_METER,
		ENVELOPEFOLLOWER,
		CONVOLUTIONREVERB,
		CHANNELMIX,
		TRANSCEIVER,
		OBJECTPAN,
		MULTIBAND_EQ
	}
	public enum DSP_PARAMETER_TYPE
	{
		FLOAT,
		INT,
		BOOL,
		DATA
	}
	public enum DSP_PARAMETER_FLOAT_MAPPING_TYPE
	{
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_LINEAR,
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_AUTO,
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_PIECEWISE_LINEAR
	}
	public struct DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR
	{
		public int numpoints;

		public IntPtr pointparamvalues;

		public IntPtr pointpositions;
	}
	public struct DSP_PARAMETER_FLOAT_MAPPING
	{
		public DSP_PARAMETER_FLOAT_MAPPING_TYPE type;

		public DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR piecewiselinearmapping;
	}
	public struct DSP_PARAMETER_DESC_FLOAT
	{
		public float min;

		public float max;

		public float defaultval;

		public DSP_PARAMETER_FLOAT_MAPPING mapping;
	}
	public struct DSP_PARAMETER_DESC_INT
	{
		public int min;

		public int max;

		public int defaultval;

		public bool goestoinf;

		public IntPtr valuenames;
	}
	public struct DSP_PARAMETER_DESC_BOOL
	{
		public bool defaultval;

		public IntPtr valuenames;
	}
	public struct DSP_PARAMETER_DESC_DATA
	{
		public int datatype;
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct DSP_PARAMETER_DESC_UNION
	{
		[FieldOffset(0)]
		public DSP_PARAMETER_DESC_FLOAT floatdesc;

		[FieldOffset(0)]
		public DSP_PARAMETER_DESC_INT intdesc;

		[FieldOffset(0)]
		public DSP_PARAMETER_DESC_BOOL booldesc;

		[FieldOffset(0)]
		public DSP_PARAMETER_DESC_DATA datadesc;
	}
	public struct DSP_PARAMETER_DESC
	{
		public DSP_PARAMETER_TYPE type;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public char[] name;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public char[] label;

		public string description;

		public DSP_PARAMETER_DESC_UNION desc;
	}
	public enum DSP_PARAMETER_DATA_TYPE
	{
		DSP_PARAMETER_DATA_TYPE_USER = 0,
		DSP_PARAMETER_DATA_TYPE_OVERALLGAIN = -1,
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES = -2,
		DSP_PARAMETER_DATA_TYPE_SIDECHAIN = -3,
		DSP_PARAMETER_DATA_TYPE_FFT = -4,
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES_MULTI = -5
	}
	public struct DSP_PARAMETER_OVERALLGAIN
	{
		public float linear_gain;

		public float linear_gain_additive;
	}
	public struct DSP_PARAMETER_3DATTRIBUTES
	{
		public ATTRIBUTES_3D relative;

		public ATTRIBUTES_3D absolute;
	}
	public struct DSP_PARAMETER_3DATTRIBUTES_MULTI
	{
		public int numlisteners;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public ATTRIBUTES_3D[] relative;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public float[] weight;

		public ATTRIBUTES_3D absolute;
	}
	public struct DSP_PARAMETER_SIDECHAIN
	{
		public int sidechainenable;
	}
	public struct DSP_PARAMETER_FFT
	{
		public int length;

		public int numchannels;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		private IntPtr[] spectrum_internal;

		public float[][] spectrum
		{
			get
			{
				float[][] array = new float[numchannels][];
				for (int i = 0; i < numchannels; i++)
				{
					array[i] = new float[length];
					Marshal.Copy(spectrum_internal[i], array[i], 0, length);
				}
				return array;
			}
		}
	}
	public struct DSP_DESCRIPTION
	{
		public uint pluginsdkversion;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public char[] name;

		public uint version;

		public int numinputbuffers;

		public int numoutputbuffers;

		public DSP_CREATECALLBACK create;

		public DSP_RELEASECALLBACK release;

		public DSP_RESETCALLBACK reset;

		public DSP_READCALLBACK read;

		public DSP_PROCESS_CALLBACK process;

		public DSP_SETPOSITIONCALLBACK setposition;

		public int numparameters;

		public IntPtr paramdesc;

		public DSP_SETPARAM_FLOAT_CALLBACK setparameterfloat;

		public DSP_SETPARAM_INT_CALLBACK setparameterint;

		public DSP_SETPARAM_BOOL_CALLBACK setparameterbool;

		public DSP_SETPARAM_DATA_CALLBACK setparameterdata;

		public DSP_GETPARAM_FLOAT_CALLBACK getparameterfloat;

		public DSP_GETPARAM_INT_CALLBACK getparameterint;

		public DSP_GETPARAM_BOOL_CALLBACK getparameterbool;

		public DSP_GETPARAM_DATA_CALLBACK getparameterdata;

		public DSP_SHOULDIPROCESS_CALLBACK shouldiprocess;

		public IntPtr userdata;

		public DSP_SYSTEM_REGISTER_CALLBACK sys_register;

		public DSP_SYSTEM_DEREGISTER_CALLBACK sys_deregister;

		public DSP_SYSTEM_MIX_CALLBACK sys_mix;
	}
	public struct DSP_STATE_DFT_FUNCTIONS
	{
		public DSP_DFT_FFTREAL_FUNC fftreal;

		public DSP_DFT_IFFTREAL_FUNC inversefftreal;
	}
	public struct DSP_STATE_PAN_FUNCTIONS
	{
		public DSP_PAN_SUMMONOMATRIX_FUNC summonomatrix;

		public DSP_PAN_SUMSTEREOMATRIX_FUNC sumstereomatrix;

		public DSP_PAN_SUMSURROUNDMATRIX_FUNC sumsurroundmatrix;

		public DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC summonotosurroundmatrix;

		public DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC sumstereotosurroundmatrix;

		public DSP_PAN_GETROLLOFFGAIN_FUNC getrolloffgain;
	}
	public struct DSP_STATE_FUNCTIONS
	{
		private DSP_ALLOC_FUNC alloc;

		private DSP_REALLOC_FUNC realloc;

		private DSP_FREE_FUNC free;

		private DSP_GETSAMPLERATE_FUNC getsamplerate;

		private DSP_GETBLOCKSIZE_FUNC getblocksize;

		private IntPtr dft;

		private IntPtr pan;

		private DSP_GETSPEAKERMODE_FUNC getspeakermode;

		private DSP_GETCLOCK_FUNC getclock;

		private DSP_GETLISTENERATTRIBUTES_FUNC getlistenerattributes;

		private DSP_LOG_FUNC log;

		private DSP_GETUSERDATA_FUNC getuserdata;
	}
	public struct DSP_STATE
	{
		public IntPtr instance;

		public IntPtr plugindata;

		public uint channelmask;

		public int source_speakermode;

		public IntPtr sidechaindata;

		public int sidechainchannels;

		public IntPtr functions;

		public int systemobject;
	}
	public struct DSP_METERING_INFO
	{
		public int numsamples;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public float[] peaklevel;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public float[] rmslevel;

		public short numchannels;
	}
	public enum DSP_OSCILLATOR
	{
		TYPE,
		RATE
	}
	public enum DSP_LOWPASS
	{
		CUTOFF,
		RESONANCE
	}
	public enum DSP_ITLOWPASS
	{
		CUTOFF,
		RESONANCE
	}
	public enum DSP_HIGHPASS
	{
		CUTOFF,
		RESONANCE
	}
	public enum DSP_ECHO
	{
		DELAY,
		FEEDBACK,
		DRYLEVEL,
		WETLEVEL
	}
	public enum DSP_FADER
	{
		GAIN,
		OVERALL_GAIN
	}
	public enum DSP_DELAY
	{
		CH0,
		CH1,
		CH2,
		CH3,
		CH4,
		CH5,
		CH6,
		CH7,
		CH8,
		CH9,
		CH10,
		CH11,
		CH12,
		CH13,
		CH14,
		CH15,
		MAXDELAY
	}
	public enum DSP_FLANGE
	{
		MIX,
		DEPTH,
		RATE
	}
	public enum DSP_TREMOLO
	{
		FREQUENCY,
		DEPTH,
		SHAPE,
		SKEW,
		DUTY,
		SQUARE,
		PHASE,
		SPREAD
	}
	public enum DSP_DISTORTION
	{
		LEVEL
	}
	public enum DSP_NORMALIZE
	{
		FADETIME,
		THRESHHOLD,
		MAXAMP
	}
	public enum DSP_LIMITER
	{
		RELEASETIME,
		CEILING,
		MAXIMIZERGAIN,
		MODE
	}
	public enum DSP_PARAMEQ
	{
		CENTER,
		BANDWIDTH,
		GAIN
	}
	public enum DSP_MULTIBAND_EQ
	{
		A_FILTER,
		A_FREQUENCY,
		A_Q,
		A_GAIN,
		B_FILTER,
		B_FREQUENCY,
		B_Q,
		B_GAIN,
		C_FILTER,
		C_FREQUENCY,
		C_Q,
		C_GAIN,
		D_FILTER,
		D_FREQUENCY,
		D_Q,
		D_GAIN,
		E_FILTER,
		E_FREQUENCY,
		E_Q,
		E_GAIN
	}
	public enum DSP_MULTIBAND_EQ_FILTER_TYPE
	{
		DISABLED,
		LOWPASS_12DB,
		LOWPASS_24DB,
		LOWPASS_48DB,
		HIGHPASS_12DB,
		HIGHPASS_24DB,
		HIGHPASS_48DB,
		LOWSHELF,
		HIGHSHELF,
		PEAKING,
		BANDPASS,
		NOTCH,
		ALLPASS
	}
	public enum DSP_PITCHSHIFT
	{
		PITCH,
		FFTSIZE,
		OVERLAP,
		MAXCHANNELS
	}
	public enum DSP_CHORUS
	{
		MIX,
		RATE,
		DEPTH
	}
	public enum DSP_ITECHO
	{
		WETDRYMIX,
		FEEDBACK,
		LEFTDELAY,
		RIGHTDELAY,
		PANDELAY
	}
	public enum DSP_COMPRESSOR
	{
		THRESHOLD,
		RATIO,
		ATTACK,
		RELEASE,
		GAINMAKEUP,
		USESIDECHAIN,
		LINKED
	}
	public enum DSP_SFXREVERB
	{
		DECAYTIME,
		EARLYDELAY,
		LATEDELAY,
		HFREFERENCE,
		HFDECAYRATIO,
		DIFFUSION,
		DENSITY,
		LOWSHELFFREQUENCY,
		LOWSHELFGAIN,
		HIGHCUT,
		EARLYLATEMIX,
		WETLEVEL,
		DRYLEVEL
	}
	public enum DSP_LOWPASS_SIMPLE
	{
		CUTOFF
	}
	public enum DSP_SEND
	{
		RETURNID,
		LEVEL
	}
	public enum DSP_RETURN
	{
		ID,
		INPUT_SPEAKER_MODE
	}
	public enum DSP_HIGHPASS_SIMPLE
	{
		CUTOFF
	}
	public enum DSP_PAN_2D_STEREO_MODE_TYPE
	{
		DISTRIBUTED,
		DISCRETE
	}
	public enum DSP_PAN_MODE_TYPE
	{
		MONO,
		STEREO,
		SURROUND
	}
	public enum DSP_PAN_3D_ROLLOFF_TYPE
	{
		LINEARSQUARED,
		LINEAR,
		INVERSE,
		INVERSETAPERED,
		CUSTOM
	}
	public enum DSP_PAN_3D_EXTENT_MODE_TYPE
	{
		AUTO,
		USER,
		OFF
	}
	public enum DSP_PAN
	{
		MODE,
		_2D_STEREO_POSITION,
		_2D_DIRECTION,
		_2D_EXTENT,
		_2D_ROTATION,
		_2D_LFE_LEVEL,
		_2D_STEREO_MODE,
		_2D_STEREO_SEPARATION,
		_2D_STEREO_AXIS,
		ENABLED_SPEAKERS,
		_3D_POSITION,
		_3D_ROLLOFF,
		_3D_MIN_DISTANCE,
		_3D_MAX_DISTANCE,
		_3D_EXTENT_MODE,
		_3D_SOUND_SIZE,
		_3D_MIN_EXTENT,
		_3D_PAN_BLEND,
		LFE_UPMIX_ENABLED,
		OVERALL_GAIN,
		SURROUND_SPEAKER_MODE,
		_2D_HEIGHT_BLEND
	}
	public enum DSP_THREE_EQ_CROSSOVERSLOPE_TYPE
	{
		_12DB,
		_24DB,
		_48DB
	}
	public enum DSP_THREE_EQ
	{
		LOWGAIN,
		MIDGAIN,
		HIGHGAIN,
		LOWCROSSOVER,
		HIGHCROSSOVER,
		CROSSOVERSLOPE
	}
	public enum DSP_FFT_WINDOW
	{
		RECT,
		TRIANGLE,
		HAMMING,
		HANNING,
		BLACKMAN,
		BLACKMANHARRIS
	}
	public enum DSP_FFT
	{
		WINDOWSIZE,
		WINDOWTYPE,
		SPECTRUMDATA,
		DOMINANT_FREQ
	}
	public enum DSP_ENVELOPEFOLLOWER
	{
		ATTACK,
		RELEASE,
		ENVELOPE,
		USESIDECHAIN
	}
	public enum DSP_CONVOLUTION_REVERB
	{
		IR,
		WET,
		DRY,
		LINKED
	}
	public enum DSP_CHANNELMIX_OUTPUT
	{
		DEFAULT,
		ALLMONO,
		ALLSTEREO,
		ALLQUAD,
		ALL5POINT1,
		ALL7POINT1,
		ALLLFE
	}
	public enum DSP_CHANNELMIX
	{
		OUTPUTGROUPING,
		GAIN_CH0,
		GAIN_CH1,
		GAIN_CH2,
		GAIN_CH3,
		GAIN_CH4,
		GAIN_CH5,
		GAIN_CH6,
		GAIN_CH7,
		GAIN_CH8,
		GAIN_CH9,
		GAIN_CH10,
		GAIN_CH11,
		GAIN_CH12,
		GAIN_CH13,
		GAIN_CH14,
		GAIN_CH15,
		GAIN_CH16,
		GAIN_CH17,
		GAIN_CH18,
		GAIN_CH19,
		GAIN_CH20,
		GAIN_CH21,
		GAIN_CH22,
		GAIN_CH23,
		GAIN_CH24,
		GAIN_CH25,
		GAIN_CH26,
		GAIN_CH27,
		GAIN_CH28,
		GAIN_CH29,
		GAIN_CH30,
		GAIN_CH31
	}
	public enum DSP_TRANSCEIVER_SPEAKERMODE
	{
		AUTO = -1,
		MONO,
		STEREO,
		SURROUND
	}
	public enum DSP_TRANSCEIVER
	{
		TRANSMIT,
		GAIN,
		CHANNEL,
		TRANSMITSPEAKERMODE
	}
	public enum DSP_OBJECTPAN
	{
		_3D_POSITION,
		_3D_ROLLOFF,
		_3D_MIN_DISTANCE,
		_3D_MAX_DISTANCE,
		_3D_EXTENT_MODE,
		_3D_SOUND_SIZE,
		_3D_MIN_EXTENT,
		OVERALL_GAIN,
		OUTPUTGAIN
	}
	public class Error
	{
		public static string String(RESULT errcode)
		{
			return errcode switch
			{
				RESULT.OK => "No errors.", 
				RESULT.ERR_BADCOMMAND => "Tried to call a function on a data type that does not allow this type of functionality (ie calling Sound::lock on a streaming sound).", 
				RESULT.ERR_CHANNEL_ALLOC => "Error trying to allocate a channel.", 
				RESULT.ERR_CHANNEL_STOLEN => "The specified channel has been reused to play another sound.", 
				RESULT.ERR_DMA => "DMA Failure.  See debug output for more information.", 
				RESULT.ERR_DSP_CONNECTION => "DSP connection error.  Connection possibly caused a cyclic dependency or connected dsps with incompatible buffer counts.", 
				RESULT.ERR_DSP_DONTPROCESS => "DSP return code from a DSP process query callback.  Tells mixer not to call the process callback and therefore not consume CPU.  Use this to optimize the DSP graph.", 
				RESULT.ERR_DSP_FORMAT => "DSP Format error.  A DSP unit may have attempted to connect to this network with the wrong format, or a matrix may have been set with the wrong size if the target unit has a specified channel map.", 
				RESULT.ERR_DSP_INUSE => "DSP is already in the mixer's DSP network. It must be removed before being reinserted or released.", 
				RESULT.ERR_DSP_NOTFOUND => "DSP connection error.  Couldn't find the DSP unit specified.", 
				RESULT.ERR_DSP_RESERVED => "DSP operation error.  Cannot perform operation on this DSP as it is reserved by the system.", 
				RESULT.ERR_DSP_SILENCE => "DSP return code from a DSP process query callback.  Tells mixer silence would be produced from read, so go idle and not consume CPU.  Use this to optimize the DSP graph.", 
				RESULT.ERR_DSP_TYPE => "DSP operation cannot be performed on a DSP of this type.", 
				RESULT.ERR_FILE_BAD => "Error loading file.", 
				RESULT.ERR_FILE_COULDNOTSEEK => "Couldn't perform seek operation.  This is a limitation of the medium (ie netstreams) or the file format.", 
				RESULT.ERR_FILE_DISKEJECTED => "Media was ejected while reading.", 
				RESULT.ERR_FILE_EOF => "End of file unexpectedly reached while trying to read essential data (truncated?).", 
				RESULT.ERR_FILE_ENDOFDATA => "End of current chunk reached while trying to read data.", 
				RESULT.ERR_FILE_NOTFOUND => "File not found.", 
				RESULT.ERR_FORMAT => "Unsupported file or audio format.", 
				RESULT.ERR_HEADER_MISMATCH => "There is a version mismatch between the FMOD header and either the FMOD Studio library or the FMOD Low Level library.", 
				RESULT.ERR_HTTP => "A HTTP error occurred. This is a catch-all for HTTP errors not listed elsewhere.", 
				RESULT.ERR_HTTP_ACCESS => "The specified resource requires authentication or is forbidden.", 
				RESULT.ERR_HTTP_PROXY_AUTH => "Proxy authentication is required to access the specified resource.", 
				RESULT.ERR_HTTP_SERVER_ERROR => "A HTTP server error occurred.", 
				RESULT.ERR_HTTP_TIMEOUT => "The HTTP request timed out.", 
				RESULT.ERR_INITIALIZATION => "FMOD was not initialized correctly to support this function.", 
				RESULT.ERR_INITIALIZED => "Cannot call this command after System::init.", 
				RESULT.ERR_INTERNAL => "An error occurred that wasn't supposed to.  Contact support.", 
				RESULT.ERR_INVALID_FLOAT => "Value passed in was a NaN, Inf or denormalized float.", 
				RESULT.ERR_INVALID_HANDLE => "An invalid object handle was used.", 
				RESULT.ERR_INVALID_PARAM => "An invalid parameter was passed to this function.", 
				RESULT.ERR_INVALID_POSITION => "An invalid seek position was passed to this function.", 
				RESULT.ERR_INVALID_SPEAKER => "An invalid speaker was passed to this function based on the current speaker mode.", 
				RESULT.ERR_INVALID_SYNCPOINT => "The syncpoint did not come from this sound handle.", 
				RESULT.ERR_INVALID_THREAD => "Tried to call a function on a thread that is not supported.", 
				RESULT.ERR_INVALID_VECTOR => "The vectors passed in are not unit length, or perpendicular.", 
				RESULT.ERR_MAXAUDIBLE => "Reached maximum audible playback count for this sound's soundgroup.", 
				RESULT.ERR_MEMORY => "Not enough memory or resources.", 
				RESULT.ERR_MEMORY_CANTPOINT => "Can't use FMOD_OPENMEMORY_POINT on non PCM source data, or non mp3/xma/adpcm data if FMOD_CREATECOMPRESSEDSAMPLE was used.", 
				RESULT.ERR_NEEDS3D => "Tried to call a command on a 2d sound when the command was meant for 3d sound.", 
				RESULT.ERR_NEEDSHARDWARE => "Tried to use a feature that requires hardware support.", 
				RESULT.ERR_NET_CONNECT => "Couldn't connect to the specified host.", 
				RESULT.ERR_NET_SOCKET_ERROR => "A socket error occurred.  This is a catch-all for socket-related errors not listed elsewhere.", 
				RESULT.ERR_NET_URL => "The specified URL couldn't be resolved.", 
				RESULT.ERR_NET_WOULD_BLOCK => "Operation on a non-blocking socket could not complete immediately.", 
				RESULT.ERR_NOTREADY => "Operation could not be performed because specified sound/DSP connection is not ready.", 
				RESULT.ERR_OUTPUT_ALLOCATED => "Error initializing output device, but more specifically, the output device is already in use and cannot be reused.", 
				RESULT.ERR_OUTPUT_CREATEBUFFER => "Error creating hardware sound buffer.", 
				RESULT.ERR_OUTPUT_DRIVERCALL => "A call to a standard soundcard driver failed, which could possibly mean a bug in the driver or resources were missing or exhausted.", 
				RESULT.ERR_OUTPUT_FORMAT => "Soundcard does not support the specified format.", 
				RESULT.ERR_OUTPUT_INIT => "Error initializing output device.", 
				RESULT.ERR_OUTPUT_NODRIVERS => "The output device has no drivers installed.  If pre-init, FMOD_OUTPUT_NOSOUND is selected as the output mode.  If post-init, the function just fails.", 
				RESULT.ERR_PLUGIN => "An unspecified error has been returned from a plugin.", 
				RESULT.ERR_PLUGIN_MISSING => "A requested output, dsp unit type or codec was not available.", 
				RESULT.ERR_PLUGIN_RESOURCE => "A resource that the plugin requires cannot be found. (ie the DLS file for MIDI playback)", 
				RESULT.ERR_PLUGIN_VERSION => "A plugin was built with an unsupported SDK version.", 
				RESULT.ERR_RECORD => "An error occurred trying to initialize the recording device.", 
				RESULT.ERR_REVERB_CHANNELGROUP => "Reverb properties cannot be set on this channel because a parent channelgroup owns the reverb connection.", 
				RESULT.ERR_REVERB_INSTANCE => "Specified instance in FMOD_REVERB_PROPERTIES couldn't be set. Most likely because it is an invalid instance number or the reverb doesn't exist.", 
				RESULT.ERR_SUBSOUNDS => "The error occurred because the sound referenced contains subsounds when it shouldn't have, or it doesn't contain subsounds when it should have.  The operation may also not be able to be performed on a parent sound.", 
				RESULT.ERR_SUBSOUND_ALLOCATED => "This subsound is already being used by another sound, you cannot have more than one parent to a sound.  Null out the other parent's entry first.", 
				RESULT.ERR_SUBSOUND_CANTMOVE => "Shared subsounds cannot be replaced or moved from their parent stream, such as when the parent stream is an FSB file.", 
				RESULT.ERR_TAGNOTFOUND => "The specified tag could not be found or there are no tags.", 
				RESULT.ERR_TOOMANYCHANNELS => "The sound created exceeds the allowable input channel count.  This can be increased using the 'maxinputchannels' parameter in System::setSoftwareFormat.", 
				RESULT.ERR_TRUNCATED => "The retrieved string is too long to fit in the supplied buffer and has been truncated.", 
				RESULT.ERR_UNIMPLEMENTED => "Something in FMOD hasn't been implemented when it should be! contact support!", 
				RESULT.ERR_UNINITIALIZED => "This command failed because System::init or System::setDriver was not called.", 
				RESULT.ERR_UNSUPPORTED => "A command issued was not supported by this object.  Possibly a plugin without certain callbacks specified.", 
				RESULT.ERR_VERSION => "The version number of this file format is not supported.", 
				RESULT.ERR_EVENT_ALREADY_LOADED => "The specified bank has already been loaded.", 
				RESULT.ERR_EVENT_LIVEUPDATE_BUSY => "The live update connection failed due to the game already being connected.", 
				RESULT.ERR_EVENT_LIVEUPDATE_MISMATCH => "The live update connection failed due to the game data being out of sync with the tool.", 
				RESULT.ERR_EVENT_LIVEUPDATE_TIMEOUT => "The live update connection timed out.", 
				RESULT.ERR_EVENT_NOTFOUND => "The requested event, bus or vca could not be found.", 
				RESULT.ERR_STUDIO_UNINITIALIZED => "The Studio::System object is not yet initialized.", 
				RESULT.ERR_STUDIO_NOT_LOADED => "The specified resource is not loaded, so it can't be unloaded.", 
				RESULT.ERR_INVALID_STRING => "An invalid string was passed to this function.", 
				RESULT.ERR_ALREADY_LOCKED => "The specified resource is already locked.", 
				RESULT.ERR_NOT_LOCKED => "The specified resource is not locked, so it can't be unlocked.", 
				RESULT.ERR_RECORD_DISCONNECTED => "The specified recording driver has been disconnected.", 
				RESULT.ERR_TOOMANYSAMPLES => "The length provided exceed the allowable limit.", 
				_ => "Unknown error.", 
			};
		}
	}
}
namespace FMOD.Studio
{
	public class STUDIO_VERSION
	{
		public const string dll = "fmodstudio";
	}
	public enum STOP_MODE
	{
		ALLOWFADEOUT,
		IMMEDIATE
	}
	public enum LOADING_STATE
	{
		UNLOADING,
		UNLOADED,
		LOADING,
		LOADED,
		ERROR
	}
	public struct PROGRAMMER_SOUND_PROPERTIES
	{
		public StringWrapper name;

		public IntPtr sound;

		public int subsoundIndex;
	}
	public struct TIMELINE_MARKER_PROPERTIES
	{
		public StringWrapper name;

		public int position;
	}
	public struct TIMELINE_BEAT_PROPERTIES
	{
		public int bar;

		public int beat;

		public int position;

		public float tempo;

		public int timesignatureupper;

		public int timesignaturelower;
	}
	public struct ADVANCEDSETTINGS
	{
		public int cbsize;

		public int commandqueuesize;

		public int handleinitialsize;

		public int studioupdateperiod;

		public int idlesampledatapoolsize;

		public int streamingscheduledelay;
	}
	public struct CPU_USAGE
	{
		public float dspusage;

		public float streamusage;

		public float geometryusage;

		public float updateusage;

		public float studiousage;
	}
	public struct BUFFER_INFO
	{
		public int currentusage;

		public int peakusage;

		public int capacity;

		public int stallcount;

		public float stalltime;
	}
	public struct BUFFER_USAGE
	{
		public BUFFER_INFO studiocommandqueue;

		public BUFFER_INFO studiohandle;
	}
	public struct BANK_INFO
	{
		public int size;

		public IntPtr userdata;

		public int userdatalength;

		public FILE_OPENCALLBACK opencallback;

		public FILE_CLOSECALLBACK closecallback;

		public FILE_READCALLBACK readcallback;

		public FILE_SEEKCALLBACK seekcallback;
	}
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		PREUPDATE = 1u,
		POSTUPDATE = 2u,
		BANK_UNLOAD = 4u,
		ALL = uint.MaxValue
	}
	public delegate RESULT SYSTEM_CALLBACK(IntPtr systemraw, SYSTEM_CALLBACK_TYPE type, IntPtr parameters, IntPtr userdata);
	public enum PARAMETER_TYPE
	{
		GAME_CONTROLLED,
		AUTOMATIC_DISTANCE,
		AUTOMATIC_EVENT_CONE_ANGLE,
		AUTOMATIC_EVENT_ORIENTATION,
		AUTOMATIC_DIRECTION,
		AUTOMATIC_ELEVATION,
		AUTOMATIC_LISTENER_ORIENTATION
	}
	public struct PARAMETER_DESCRIPTION
	{
		public StringWrapper name;

		public int index;

		public float minimum;

		public float maximum;

		public float defaultvalue;

		public PARAMETER_TYPE type;
	}
	internal enum LOAD_MEMORY_MODE
	{
		LOAD_MEMORY,
		LOAD_MEMORY_POINT
	}
	internal enum LOAD_MEMORY_ALIGNMENT
	{
		VALUE = 0x20
	}
	public struct SOUND_INFO
	{
		public IntPtr name_or_data;

		public MODE mode;

		public CREATESOUNDEXINFO exinfo;

		public int subsoundindex;

		public string name
		{
			get
			{
				using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
				return ((mode & (MODE.OPENMEMORY | MODE.OPENMEMORY_POINT)) == 0) ? threadSafeEncoding.stringFromNative(name_or_data) : string.Empty;
			}
		}
	}
	public enum USER_PROPERTY_TYPE
	{
		INTEGER,
		BOOLEAN,
		FLOAT,
		STRING
	}
	public struct USER_PROPERTY
	{
		public StringWrapper name;

		public USER_PROPERTY_TYPE type;

		private Union_IntBoolFloatString value;

		public int intValue()
		{
			if (type != 0)
			{
				return -1;
			}
			return value.intvalue;
		}

		public bool boolValue()
		{
			if (type != USER_PROPERTY_TYPE.BOOLEAN)
			{
				return false;
			}
			return value.boolvalue;
		}

		public float floatValue()
		{
			if (type != USER_PROPERTY_TYPE.FLOAT)
			{
				return -1f;
			}
			return value.floatvalue;
		}

		public string stringValue()
		{
			if (type != USER_PROPERTY_TYPE.STRING)
			{
				return "";
			}
			return value.stringvalue;
		}
	}
	[StructLayout(LayoutKind.Explicit)]
	internal struct Union_IntBoolFloatString
	{
		[FieldOffset(0)]
		public int intvalue;

		[FieldOffset(0)]
		public bool boolvalue;

		[FieldOffset(0)]
		public float floatvalue;

		[FieldOffset(0)]
		public StringWrapper stringvalue;
	}
	[Flags]
	public enum INITFLAGS : uint
	{
		NORMAL = 0u,
		LIVEUPDATE = 1u,
		ALLOW_MISSING_PLUGINS = 2u,
		SYNCHRONOUS_UPDATE = 4u,
		DEFERRED_CALLBACKS = 8u,
		LOAD_FROM_UPDATE = 0x10u
	}
	[Flags]
	public enum LOAD_BANK_FLAGS : uint
	{
		NORMAL = 0u,
		NONBLOCKING = 1u,
		DECOMPRESS_SAMPLES = 2u
	}
	[Flags]
	public enum COMMANDCAPTURE_FLAGS : uint
	{
		NORMAL = 0u,
		FILEFLUSH = 1u,
		SKIP_INITIAL_STATE = 2u
	}
	[Flags]
	public enum COMMANDREPLAY_FLAGS : uint
	{
		NORMAL = 0u,
		SKIP_CLEANUP = 1u,
		FAST_FORWARD = 2u,
		SKIP_BANK_LOAD = 4u
	}
	public enum PLAYBACK_STATE
	{
		PLAYING,
		SUSTAINING,
		STOPPED,
		STARTING,
		STOPPING
	}
	public enum EVENT_PROPERTY
	{
		CHANNELPRIORITY,
		SCHEDULE_DELAY,
		SCHEDULE_LOOKAHEAD,
		MINIMUM_DISTANCE,
		MAXIMUM_DISTANCE
	}
	public struct PLUGIN_INSTANCE_PROPERTIES
	{
		public IntPtr name;

		public IntPtr dsp;
	}
	[Flags]
	public enum EVENT_CALLBACK_TYPE : uint
	{
		CREATED = 1u,
		DESTROYED = 2u,
		STARTING = 4u,
		STARTED = 8u,
		RESTARTED = 0x10u,
		STOPPED = 0x20u,
		START_FAILED = 0x40u,
		CREATE_PROGRAMMER_SOUND = 0x80u,
		DESTROY_PROGRAMMER_SOUND = 0x100u,
		PLUGIN_CREATED = 0x200u,
		PLUGIN_DESTROYED = 0x400u,
		TIMELINE_MARKER = 0x800u,
		TIMELINE_BEAT = 0x1000u,
		SOUND_PLAYED = 0x2000u,
		SOUND_STOPPED = 0x4000u,
		REAL_TO_VIRTUAL = 0x8000u,
		VIRTUAL_TO_REAL = 0x10000u,
		ALL = uint.MaxValue
	}
	public delegate RESULT EVENT_CALLBACK(EVENT_CALLBACK_TYPE type, EventInstance eventInstance, IntPtr parameters);
	public delegate RESULT COMMANDREPLAY_FRAME_CALLBACK(CommandReplay replay, int commandIndex, float currentTime, IntPtr userdata);
	public delegate RESULT COMMANDREPLAY_LOAD_BANK_CALLBACK(CommandReplay replay, Guid guid, StringWrapper bankFilename, LOAD_BANK_FLAGS flags, out Bank bank, IntPtr userdata);
	public delegate RESULT COMMANDREPLAY_CREATE_INSTANCE_CALLBACK(CommandReplay replay, EventDescription eventDescription, IntPtr originalHandle, out EventInstance instance, IntPtr userdata);
	public enum INSTANCETYPE
	{
		NONE,
		SYSTEM,
		EVENTDESCRIPTION,
		EVENTINSTANCE,
		PARAMETERINSTANCE,
		BUS,
		VCA,
		BANK,
		COMMANDREPLAY
	}
	public struct COMMAND_INFO
	{
		private StringWrapper commandname;

		public int parentcommandindex;

		public int framenumber;

		public float frametime;

		public INSTANCETYPE instancetype;

		public INSTANCETYPE outputtype;

		public uint instancehandle;

		public uint outputhandle;
	}
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Util
	{
		public static RESULT ParseID(string idString, out Guid id)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_ParseID(threadSafeEncoding.byteFromStringUTF8(idString), out id);
		}

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_ParseID(byte[] idString, out Guid id);
	}
	public struct System
	{
		public IntPtr handle;

		public static RESULT create(out System studiosystem)
		{
			return FMOD_Studio_System_Create(out studiosystem.handle, 69650u);
		}

		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings)
		{
			settings.cbsize = Marshal.SizeOf(typeof(ADVANCEDSETTINGS));
			return FMOD_Studio_System_SetAdvancedSettings(handle, ref settings);
		}

		public RESULT getAdvancedSettings(out ADVANCEDSETTINGS settings)
		{
			settings.cbsize = Marshal.SizeOf(typeof(ADVANCEDSETTINGS));
			return FMOD_Studio_System_GetAdvancedSettings(handle, out settings);
		}

		public RESULT initialize(int maxchannels, INITFLAGS studioFlags, FMOD.INITFLAGS flags, IntPtr extradriverdata)
		{
			return FMOD_Studio_System_Initialize(handle, maxchannels, studioFlags, flags, extradriverdata);
		}

		public RESULT release()
		{
			return FMOD_Studio_System_Release(handle);
		}

		public RESULT update()
		{
			return FMOD_Studio_System_Update(handle);
		}

		public RESULT getLowLevelSystem(out FMOD.System system)
		{
			return FMOD_Studio_System_GetLowLevelSystem(handle, out system.handle);
		}

		public RESULT getEvent(string path, out EventDescription _event)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_System_GetEvent(handle, threadSafeEncoding.byteFromStringUTF8(path), out _event.handle);
		}

		public RESULT getBus(string path, out Bus bus)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_System_GetBus(handle, threadSafeEncoding.byteFromStringUTF8(path), out bus.handle);
		}

		public RESULT getVCA(string path, out VCA vca)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_System_GetVCA(handle, threadSafeEncoding.byteFromStringUTF8(path), out vca.handle);
		}

		public RESULT getBank(string path, out Bank bank)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_System_GetBank(handle, threadSafeEncoding.byteFromStringUTF8(path), out bank.handle);
		}

		public RESULT getEventByID(Guid guid, out EventDescription _event)
		{
			return FMOD_Studio_System_GetEventByID(handle, ref guid, out _event.handle);
		}

		public RESULT getBusByID(Guid guid, out Bus bus)
		{
			return FMOD_Studio_System_GetBusByID(handle, ref guid, out bus.handle);
		}

		public RESULT getVCAByID(Guid guid, out VCA vca)
		{
			return FMOD_Studio_System_GetVCAByID(handle, ref guid, out vca.handle);
		}

		public RESULT getBankByID(Guid guid, out Bank bank)
		{
			return FMOD_Studio_System_GetBankByID(handle, ref guid, out bank.handle);
		}

		public RESULT getSoundInfo(string key, out SOUND_INFO info)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_System_GetSoundInfo(handle, threadSafeEncoding.byteFromStringUTF8(key), out info);
		}

		public RESULT lookupID(string path, out Guid guid)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_System_LookupID(handle, threadSafeEncoding.byteFromStringUTF8(path), out guid);
		}

		public RESULT lookupPath(Guid guid, out string path)
		{
			path = null;
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			IntPtr intPtr = Marshal.AllocHGlobal(256);
			int retrieved = 0;
			RESULT rESULT = FMOD_Studio_System_LookupPath(handle, ref guid, intPtr, 256, out retrieved);
			if (rESULT == RESULT.ERR_TRUNCATED)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = Marshal.AllocHGlobal(retrieved);
				rESULT = FMOD_Studio_System_LookupPath(handle, ref guid, intPtr, retrieved, out retrieved);
			}
			if (rESULT == RESULT.OK)
			{
				path = threadSafeEncoding.stringFromNative(intPtr);
			}
			Marshal.FreeHGlobal(intPtr);
			return rESULT;
		}

		public RESULT getNumListeners(out int numlisteners)
		{
			return FMOD_Studio_System_GetNumListeners(handle, out numlisteners);
		}

		public RESULT setNumListeners(int numlisteners)
		{
			return FMOD_Studio_System_SetNumListeners(handle, numlisteners);
		}

		public RESULT getListenerAttributes(int listener, out ATTRIBUTES_3D attributes)
		{
			return FMOD_Studio_System_GetListenerAttributes(handle, listener, out attributes);
		}

		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes)
		{
			return FMOD_Studio_System_SetListenerAttributes(handle, listener, ref attributes);
		}

		public RESULT getListenerWeight(int listener, out float weight)
		{
			return FMOD_Studio_System_GetListenerWeight(handle, listener, out weight);
		}

		public RESULT setListenerWeight(int listener, float weight)
		{
			return FMOD_Studio_System_SetListenerWeight(handle, listener, weight);
		}

		public RESULT loadBankFile(string name, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_System_LoadBankFile(handle, threadSafeEncoding.byteFromStringUTF8(name), flags, out bank.handle);
		}

		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			GCHandle gCHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
			IntPtr buffer2 = gCHandle.AddrOfPinnedObject();
			RESULT result = FMOD_Studio_System_LoadBankMemory(handle, buffer2, buffer.Length, LOAD_MEMORY_MODE.LOAD_MEMORY, flags, out bank.handle);
			gCHandle.Free();
			return result;
		}

		public RESULT loadBankCustom(BANK_INFO info, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			info.size = Marshal.SizeOf(info);
			return FMOD_Studio_System_LoadBankCustom(handle, ref info, flags, out bank.handle);
		}

		public RESULT unloadAll()
		{
			return FMOD_Studio_System_UnloadAll(handle);
		}

		public RESULT flushCommands()
		{
			return FMOD_Studio_System_FlushCommands(handle);
		}

		public RESULT flushSampleLoading()
		{
			return FMOD_Studio_System_FlushSampleLoading(handle);
		}

		public RESULT startCommandCapture(string path, COMMANDCAPTURE_FLAGS flags)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_System_StartCommandCapture(handle, threadSafeEncoding.byteFromStringUTF8(path), flags);
		}

		public RESULT stopCommandCapture()
		{
			return FMOD_Studio_System_StopCommandCapture(handle);
		}

		public RESULT loadCommandReplay(string path, COMMANDREPLAY_FLAGS flags, out CommandReplay replay)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_System_LoadCommandReplay(handle, threadSafeEncoding.byteFromStringUTF8(path), flags, out replay.handle);
		}

		public RESULT getBankCount(out int count)
		{
			return FMOD_Studio_System_GetBankCount(handle, out count);
		}

		public RESULT getBankList(out Bank[] array)
		{
			array = null;
			RESULT rESULT = FMOD_Studio_System_GetBankCount(handle, out var count);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count == 0)
			{
				array = new Bank[0];
				return rESULT;
			}
			IntPtr[] array2 = new IntPtr[count];
			rESULT = FMOD_Studio_System_GetBankList(handle, array2, count, out var count2);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count2 > count)
			{
				count2 = count;
			}
			array = new Bank[count2];
			for (int i = 0; i < count2; i++)
			{
				array[i].handle = array2[i];
			}
			return RESULT.OK;
		}

		public RESULT getCPUUsage(out CPU_USAGE usage)
		{
			return FMOD_Studio_System_GetCPUUsage(handle, out usage);
		}

		public RESULT getBufferUsage(out BUFFER_USAGE usage)
		{
			return FMOD_Studio_System_GetBufferUsage(handle, out usage);
		}

		public RESULT resetBufferUsage()
		{
			return FMOD_Studio_System_ResetBufferUsage(handle);
		}

		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return FMOD_Studio_System_SetCallback(handle, callback, callbackmask);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD_Studio_System_GetUserData(handle, out userdata);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD_Studio_System_SetUserData(handle, userdata);
		}

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr studiosystem, uint headerversion);

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_System_IsValid(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr studiosystem, ref ADVANCEDSETTINGS settings);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetAdvancedSettings(IntPtr studiosystem, out ADVANCEDSETTINGS settings);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr studiosystem, int maxchannels, INITFLAGS studioFlags, FMOD.INITFLAGS flags, IntPtr extradriverdata);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_Release(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_Update(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetLowLevelSystem(IntPtr studiosystem, out IntPtr system);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr studiosystem, byte[] path, out IntPtr description);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr studiosystem, byte[] path, out IntPtr bus);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr studiosystem, byte[] path, out IntPtr vca);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetBank(IntPtr studiosystem, byte[] path, out IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr studiosystem, ref Guid guid, out IntPtr description);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetBusByID(IntPtr studiosystem, ref Guid guid, out IntPtr bus);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetVCAByID(IntPtr studiosystem, ref Guid guid, out IntPtr vca);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetBankByID(IntPtr studiosystem, ref Guid guid, out IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetSoundInfo(IntPtr studiosystem, byte[] key, out SOUND_INFO info);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr studiosystem, byte[] path, out Guid guid);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_LookupPath(IntPtr studiosystem, ref Guid guid, IntPtr path, int size, out int retrieved);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetNumListeners(IntPtr studiosystem, out int numlisteners);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr studiosystem, int numlisteners);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetListenerAttributes(IntPtr studiosystem, int listener, out ATTRIBUTES_3D attributes);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr studiosystem, int listener, ref ATTRIBUTES_3D attributes);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetListenerWeight(IntPtr studiosystem, int listener, out float weight);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_SetListenerWeight(IntPtr studiosystem, int listener, float weight);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr studiosystem, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr studiosystem, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_LoadBankCustom(IntPtr studiosystem, ref BANK_INFO info, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_UnloadAll(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_StartCommandCapture(IntPtr studiosystem, byte[] path, COMMANDCAPTURE_FLAGS flags);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_StopCommandCapture(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_LoadCommandReplay(IntPtr studiosystem, byte[] path, COMMANDREPLAY_FLAGS flags, out IntPtr commandReplay);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr studiosystem, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr studiosystem, IntPtr[] array, int capacity, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr studiosystem, out CPU_USAGE usage);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetBufferUsage(IntPtr studiosystem, out BUFFER_USAGE usage);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_ResetBufferUsage(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_SetCallback(IntPtr studiosystem, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetUserData(IntPtr studiosystem, out IntPtr userdata);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_SetUserData(IntPtr studiosystem, IntPtr userdata);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}

		public bool isValid()
		{
			if (hasHandle())
			{
				return FMOD_Studio_System_IsValid(handle);
			}
			return false;
		}
	}
	public struct EventDescription
	{
		public IntPtr handle;

		public RESULT getID(out Guid id)
		{
			return FMOD_Studio_EventDescription_GetID(handle, out id);
		}

		public RESULT getPath(out string path)
		{
			path = null;
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			IntPtr intPtr = Marshal.AllocHGlobal(256);
			int retrieved = 0;
			RESULT rESULT = FMOD_Studio_EventDescription_GetPath(handle, intPtr, 256, out retrieved);
			if (rESULT == RESULT.ERR_TRUNCATED)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = Marshal.AllocHGlobal(retrieved);
				rESULT = FMOD_Studio_EventDescription_GetPath(handle, intPtr, retrieved, out retrieved);
			}
			if (rESULT == RESULT.OK)
			{
				path = threadSafeEncoding.stringFromNative(intPtr);
			}
			Marshal.FreeHGlobal(intPtr);
			return rESULT;
		}

		public RESULT getParameterCount(out int count)
		{
			return FMOD_Studio_EventDescription_GetParameterCount(handle, out count);
		}

		public RESULT getParameterByIndex(int index, out PARAMETER_DESCRIPTION parameter)
		{
			return FMOD_Studio_EventDescription_GetParameterByIndex(handle, index, out parameter);
		}

		public RESULT getParameter(string name, out PARAMETER_DESCRIPTION parameter)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_EventDescription_GetParameter(handle, threadSafeEncoding.byteFromStringUTF8(name), out parameter);
		}

		public RESULT getUserPropertyCount(out int count)
		{
			return FMOD_Studio_EventDescription_GetUserPropertyCount(handle, out count);
		}

		public RESULT getUserPropertyByIndex(int index, out USER_PROPERTY property)
		{
			return FMOD_Studio_EventDescription_GetUserPropertyByIndex(handle, index, out property);
		}

		public RESULT getUserProperty(string name, out USER_PROPERTY property)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_EventDescription_GetUserProperty(handle, threadSafeEncoding.byteFromStringUTF8(name), out property);
		}

		public RESULT getLength(out int length)
		{
			return FMOD_Studio_EventDescription_GetLength(handle, out length);
		}

		public RESULT getMinimumDistance(out float distance)
		{
			return FMOD_Studio_EventDescription_GetMinimumDistance(handle, out distance);
		}

		public RESULT getMaximumDistance(out float distance)
		{
			return FMOD_Studio_EventDescription_GetMaximumDistance(handle, out distance);
		}

		public RESULT getSoundSize(out float size)
		{
			return FMOD_Studio_EventDescription_GetSoundSize(handle, out size);
		}

		public RESULT isSnapshot(out bool snapshot)
		{
			return FMOD_Studio_EventDescription_IsSnapshot(handle, out snapshot);
		}

		public RESULT isOneshot(out bool oneshot)
		{
			return FMOD_Studio_EventDescription_IsOneshot(handle, out oneshot);
		}

		public RESULT isStream(out bool isStream)
		{
			return FMOD_Studio_EventDescription_IsStream(handle, out isStream);
		}

		public RESULT is3D(out bool is3D)
		{
			return FMOD_Studio_EventDescription_Is3D(handle, out is3D);
		}

		public RESULT hasCue(out bool cue)
		{
			return FMOD_Studio_EventDescription_HasCue(handle, out cue);
		}

		public RESULT createInstance(out EventInstance instance)
		{
			return FMOD_Studio_EventDescription_CreateInstance(handle, out instance.handle);
		}

		public RESULT getInstanceCount(out int count)
		{
			return FMOD_Studio_EventDescription_GetInstanceCount(handle, out count);
		}

		public RESULT getInstanceList(out EventInstance[] array)
		{
			array = null;
			RESULT rESULT = FMOD_Studio_EventDescription_GetInstanceCount(handle, out var count);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count == 0)
			{
				array = new EventInstance[0];
				return rESULT;
			}
			IntPtr[] array2 = new IntPtr[count];
			rESULT = FMOD_Studio_EventDescription_GetInstanceList(handle, array2, count, out var count2);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count2 > count)
			{
				count2 = count;
			}
			array = new EventInstance[count2];
			for (int i = 0; i < count2; i++)
			{
				array[i].handle = array2[i];
			}
			return RESULT.OK;
		}

		public RESULT loadSampleData()
		{
			return FMOD_Studio_EventDescription_LoadSampleData(handle);
		}

		public RESULT unloadSampleData()
		{
			return FMOD_Studio_EventDescription_UnloadSampleData(handle);
		}

		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return FMOD_Studio_EventDescription_GetSampleLoadingState(handle, out state);
		}

		public RESULT releaseAllInstances()
		{
			return FMOD_Studio_EventDescription_ReleaseAllInstances(handle);
		}

		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return FMOD_Studio_EventDescription_SetCallback(handle, callback, callbackmask);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD_Studio_EventDescription_GetUserData(handle, out userdata);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD_Studio_EventDescription_SetUserData(handle, userdata);
		}

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetID(IntPtr eventdescription, out Guid id);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetPath(IntPtr eventdescription, IntPtr path, int size, out int retrieved);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterCount(IntPtr eventdescription, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterByIndex(IntPtr eventdescription, int index, out PARAMETER_DESCRIPTION parameter);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameter(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyCount(IntPtr eventdescription, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyByIndex(IntPtr eventdescription, int index, out USER_PROPERTY property);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, byte[] name, out USER_PROPERTY property);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetLength(IntPtr eventdescription, out int length);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMinimumDistance(IntPtr eventdescription, out float distance);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMaximumDistance(IntPtr eventdescription, out float distance);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSoundSize(IntPtr eventdescription, out float size);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_IsSnapshot(IntPtr eventdescription, out bool snapshot);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_IsStream(IntPtr eventdescription, out bool isStream);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_HasCue(IntPtr eventdescription, out bool cue);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceCount(IntPtr eventdescription, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceList(IntPtr eventdescription, IntPtr[] array, int capacity, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_ReleaseAllInstances(IntPtr eventdescription);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_SetCallback(IntPtr eventdescription, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserData(IntPtr eventdescription, out IntPtr userdata);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_SetUserData(IntPtr eventdescription, IntPtr userdata);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}

		public bool isValid()
		{
			if (hasHandle())
			{
				return FMOD_Studio_EventDescription_IsValid(handle);
			}
			return false;
		}
	}
	public struct EventInstance
	{
		public IntPtr handle;

		public RESULT getDescription(out EventDescription description)
		{
			return FMOD_Studio_EventInstance_GetDescription(handle, out description.handle);
		}

		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return FMOD_Studio_EventInstance_GetVolume(handle, out volume, out finalvolume);
		}

		public RESULT setVolume(float volume)
		{
			return FMOD_Studio_EventInstance_SetVolume(handle, volume);
		}

		public RESULT getPitch(out float pitch, out float finalpitch)
		{
			return FMOD_Studio_EventInstance_GetPitch(handle, out pitch, out finalpitch);
		}

		public RESULT setPitch(float pitch)
		{
			return FMOD_Studio_EventInstance_SetPitch(handle, pitch);
		}

		public RESULT get3DAttributes(out ATTRIBUTES_3D attributes)
		{
			return FMOD_Studio_EventInstance_Get3DAttributes(handle, out attributes);
		}

		public RESULT set3DAttributes(ATTRIBUTES_3D attributes)
		{
			return FMOD_Studio_EventInstance_Set3DAttributes(handle, ref attributes);
		}

		public RESULT getListenerMask(out uint mask)
		{
			return FMOD_Studio_EventInstance_GetListenerMask(handle, out mask);
		}

		public RESULT setListenerMask(uint mask)
		{
			return FMOD_Studio_EventInstance_SetListenerMask(handle, mask);
		}

		public RESULT getProperty(EVENT_PROPERTY index, out float value)
		{
			return FMOD_Studio_EventInstance_GetProperty(handle, index, out value);
		}

		public RESULT setProperty(EVENT_PROPERTY index, float value)
		{
			return FMOD_Studio_EventInstance_SetProperty(handle, index, value);
		}

		public RESULT getReverbLevel(int index, out float level)
		{
			return FMOD_Studio_EventInstance_GetReverbLevel(handle, index, out level);
		}

		public RESULT setReverbLevel(int index, float level)
		{
			return FMOD_Studio_EventInstance_SetReverbLevel(handle, index, level);
		}

		public RESULT getPaused(out bool paused)
		{
			return FMOD_Studio_EventInstance_GetPaused(handle, out paused);
		}

		public RESULT setPaused(bool paused)
		{
			return FMOD_Studio_EventInstance_SetPaused(handle, paused);
		}

		public RESULT start()
		{
			return FMOD_Studio_EventInstance_Start(handle);
		}

		public RESULT stop(STOP_MODE mode)
		{
			return FMOD_Studio_EventInstance_Stop(handle, mode);
		}

		public RESULT getTimelinePosition(out int position)
		{
			return FMOD_Studio_EventInstance_GetTimelinePosition(handle, out position);
		}

		public RESULT setTimelinePosition(int position)
		{
			return FMOD_Studio_EventInstance_SetTimelinePosition(handle, position);
		}

		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return FMOD_Studio_EventInstance_GetPlaybackState(handle, out state);
		}

		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return FMOD_Studio_EventInstance_GetChannelGroup(handle, out group.handle);
		}

		public RESULT release()
		{
			return FMOD_Studio_EventInstance_Release(handle);
		}

		public RESULT isVirtual(out bool virtualState)
		{
			return FMOD_Studio_EventInstance_IsVirtual(handle, out virtualState);
		}

		public RESULT getParameter(string name, out ParameterInstance instance)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_EventInstance_GetParameter(handle, threadSafeEncoding.byteFromStringUTF8(name), out instance.handle);
		}

		public RESULT getParameterCount(out int count)
		{
			return FMOD_Studio_EventInstance_GetParameterCount(handle, out count);
		}

		public RESULT getParameterByIndex(int index, out ParameterInstance instance)
		{
			return FMOD_Studio_EventInstance_GetParameterByIndex(handle, index, out instance.handle);
		}

		public RESULT getParameterValue(string name, out float value, out float finalvalue)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_EventInstance_GetParameterValue(handle, threadSafeEncoding.byteFromStringUTF8(name), out value, out finalvalue);
		}

		public RESULT setParameterValue(string name, float value)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_EventInstance_SetParameterValue(handle, threadSafeEncoding.byteFromStringUTF8(name), value);
		}

		public RESULT getParameterValueByIndex(int index, out float value, out float finalvalue)
		{
			return FMOD_Studio_EventInstance_GetParameterValueByIndex(handle, index, out value, out finalvalue);
		}

		public RESULT setParameterValueByIndex(int index, float value)
		{
			return FMOD_Studio_EventInstance_SetParameterValueByIndex(handle, index, value);
		}

		public RESULT setParameterValuesByIndices(int[] indices, float[] values, int count)
		{
			return FMOD_Studio_EventInstance_SetParameterValuesByIndices(handle, indices, values, count);
		}

		public RESULT triggerCue()
		{
			return FMOD_Studio_EventInstance_TriggerCue(handle);
		}

		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return FMOD_Studio_EventInstance_SetCallback(handle, callback, callbackmask);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD_Studio_EventInstance_GetUserData(handle, out userdata);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD_Studio_EventInstance_SetUserData(handle, userdata);
		}

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetDescription(IntPtr _event, out IntPtr description);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetVolume(IntPtr _event, out float volume, out float finalvolume);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetVolume(IntPtr _event, float volume);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPitch(IntPtr _event, out float pitch, out float finalpitch);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPitch(IntPtr _event, float pitch);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_Get3DAttributes(IntPtr _event, out ATTRIBUTES_3D attributes);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetListenerMask(IntPtr _event, out uint mask);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetListenerMask(IntPtr _event, uint mask);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetProperty(IntPtr _event, EVENT_PROPERTY index, out float value);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetReverbLevel(IntPtr _event, int index, out float level);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetReverbLevel(IntPtr _event, int index, float level);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPaused(IntPtr _event, out bool paused);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPaused(IntPtr _event, bool paused);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetTimelinePosition(IntPtr _event, out int position);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetTimelinePosition(IntPtr _event, int position);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetChannelGroup(IntPtr _event, out IntPtr group);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_IsVirtual(IntPtr _event, out bool virtualState);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameter(IntPtr _event, byte[] name, out IntPtr parameter);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByIndex(IntPtr _event, int index, out IntPtr parameter);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterCount(IntPtr _event, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterValue(IntPtr _event, byte[] name, out float value, out float finalvalue);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterValue(IntPtr _event, byte[] name, float value);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterValueByIndex(IntPtr _event, int index, out float value, out float finalvalue);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterValueByIndex(IntPtr _event, int index, float value);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterValuesByIndices(IntPtr _event, int[] indices, float[] values, int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_TriggerCue(IntPtr _event);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetCallback(IntPtr _event, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetUserData(IntPtr _event, out IntPtr userdata);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetUserData(IntPtr _event, IntPtr userdata);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}

		public bool isValid()
		{
			if (hasHandle())
			{
				return FMOD_Studio_EventInstance_IsValid(handle);
			}
			return false;
		}
	}
	public struct ParameterInstance
	{
		public IntPtr handle;

		public RESULT getDescription(out PARAMETER_DESCRIPTION description)
		{
			return FMOD_Studio_ParameterInstance_GetDescription(handle, out description);
		}

		public RESULT getValue(out float value)
		{
			return FMOD_Studio_ParameterInstance_GetValue(handle, out value);
		}

		public RESULT setValue(float value)
		{
			return FMOD_Studio_ParameterInstance_SetValue(handle, value);
		}

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_ParameterInstance_IsValid(IntPtr parameter);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_ParameterInstance_GetDescription(IntPtr parameter, out PARAMETER_DESCRIPTION description);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_ParameterInstance_GetValue(IntPtr parameter, out float value);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_ParameterInstance_SetValue(IntPtr parameter, float value);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}

		public bool isValid()
		{
			if (hasHandle())
			{
				return FMOD_Studio_ParameterInstance_IsValid(handle);
			}
			return false;
		}
	}
	public struct Bus
	{
		public IntPtr handle;

		public RESULT getID(out Guid id)
		{
			return FMOD_Studio_Bus_GetID(handle, out id);
		}

		public RESULT getPath(out string path)
		{
			path = null;
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			IntPtr intPtr = Marshal.AllocHGlobal(256);
			int retrieved = 0;
			RESULT rESULT = FMOD_Studio_Bus_GetPath(handle, intPtr, 256, out retrieved);
			if (rESULT == RESULT.ERR_TRUNCATED)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = Marshal.AllocHGlobal(retrieved);
				rESULT = FMOD_Studio_Bus_GetPath(handle, intPtr, retrieved, out retrieved);
			}
			if (rESULT == RESULT.OK)
			{
				path = threadSafeEncoding.stringFromNative(intPtr);
			}
			Marshal.FreeHGlobal(intPtr);
			return rESULT;
		}

		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return FMOD_Studio_Bus_GetVolume(handle, out volume, out finalvolume);
		}

		public RESULT setVolume(float volume)
		{
			return FMOD_Studio_Bus_SetVolume(handle, volume);
		}

		public RESULT getPaused(out bool paused)
		{
			return FMOD_Studio_Bus_GetPaused(handle, out paused);
		}

		public RESULT setPaused(bool paused)
		{
			return FMOD_Studio_Bus_SetPaused(handle, paused);
		}

		public RESULT getMute(out bool mute)
		{
			return FMOD_Studio_Bus_GetMute(handle, out mute);
		}

		public RESULT setMute(bool mute)
		{
			return FMOD_Studio_Bus_SetMute(handle, mute);
		}

		public RESULT stopAllEvents(STOP_MODE mode)
		{
			return FMOD_Studio_Bus_StopAllEvents(handle, mode);
		}

		public RESULT lockChannelGroup()
		{
			return FMOD_Studio_Bus_LockChannelGroup(handle);
		}

		public RESULT unlockChannelGroup()
		{
			return FMOD_Studio_Bus_UnlockChannelGroup(handle);
		}

		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return FMOD_Studio_Bus_GetChannelGroup(handle, out group.handle);
		}

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_Bus_IsValid(IntPtr bus);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_GetID(IntPtr bus, out Guid id);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_GetVolume(IntPtr bus, out float volume, out float finalvolume);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float value);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_GetPaused(IntPtr bus, out bool paused);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_GetMute(IntPtr bus, out bool mute);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_LockChannelGroup(IntPtr bus);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_UnlockChannelGroup(IntPtr bus);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}

		public bool isValid()
		{
			if (hasHandle())
			{
				return FMOD_Studio_Bus_IsValid(handle);
			}
			return false;
		}
	}
	public struct VCA
	{
		public IntPtr handle;

		public RESULT getID(out Guid id)
		{
			return FMOD_Studio_VCA_GetID(handle, out id);
		}

		public RESULT getPath(out string path)
		{
			path = null;
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			IntPtr intPtr = Marshal.AllocHGlobal(256);
			int retrieved = 0;
			RESULT rESULT = FMOD_Studio_VCA_GetPath(handle, intPtr, 256, out retrieved);
			if (rESULT == RESULT.ERR_TRUNCATED)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = Marshal.AllocHGlobal(retrieved);
				rESULT = FMOD_Studio_VCA_GetPath(handle, intPtr, retrieved, out retrieved);
			}
			if (rESULT == RESULT.OK)
			{
				path = threadSafeEncoding.stringFromNative(intPtr);
			}
			Marshal.FreeHGlobal(intPtr);
			return rESULT;
		}

		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return FMOD_Studio_VCA_GetVolume(handle, out volume, out finalvolume);
		}

		public RESULT setVolume(float volume)
		{
			return FMOD_Studio_VCA_SetVolume(handle, volume);
		}

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_VCA_IsValid(IntPtr vca);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_VCA_GetID(IntPtr vca, out Guid id);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_VCA_GetPath(IntPtr vca, IntPtr path, int size, out int retrieved);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_VCA_GetVolume(IntPtr vca, out float volume, out float finalvolume);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_VCA_SetVolume(IntPtr vca, float value);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}

		public bool isValid()
		{
			if (hasHandle())
			{
				return FMOD_Studio_VCA_IsValid(handle);
			}
			return false;
		}
	}
	public struct Bank
	{
		public IntPtr handle;

		public RESULT getID(out Guid id)
		{
			return FMOD_Studio_Bank_GetID(handle, out id);
		}

		public RESULT getPath(out string path)
		{
			path = null;
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			IntPtr intPtr = Marshal.AllocHGlobal(256);
			int retrieved = 0;
			RESULT rESULT = FMOD_Studio_Bank_GetPath(handle, intPtr, 256, out retrieved);
			if (rESULT == RESULT.ERR_TRUNCATED)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = Marshal.AllocHGlobal(retrieved);
				rESULT = FMOD_Studio_Bank_GetPath(handle, intPtr, retrieved, out retrieved);
			}
			if (rESULT == RESULT.OK)
			{
				path = threadSafeEncoding.stringFromNative(intPtr);
			}
			Marshal.FreeHGlobal(intPtr);
			return rESULT;
		}

		public RESULT unload()
		{
			return FMOD_Studio_Bank_Unload(handle);
		}

		public RESULT loadSampleData()
		{
			return FMOD_Studio_Bank_LoadSampleData(handle);
		}

		public RESULT unloadSampleData()
		{
			return FMOD_Studio_Bank_UnloadSampleData(handle);
		}

		public RESULT getLoadingState(out LOADING_STATE state)
		{
			return FMOD_Studio_Bank_GetLoadingState(handle, out state);
		}

		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return FMOD_Studio_Bank_GetSampleLoadingState(handle, out state);
		}

		public RESULT getStringCount(out int count)
		{
			return FMOD_Studio_Bank_GetStringCount(handle, out count);
		}

		public RESULT getStringInfo(int index, out Guid id, out string path)
		{
			path = null;
			id = Guid.Empty;
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			IntPtr intPtr = Marshal.AllocHGlobal(256);
			int retrieved = 0;
			RESULT rESULT = FMOD_Studio_Bank_GetStringInfo(handle, index, out id, intPtr, 256, out retrieved);
			if (rESULT == RESULT.ERR_TRUNCATED)
			{
				Marshal.FreeHGlobal(intPtr);
				intPtr = Marshal.AllocHGlobal(retrieved);
				rESULT = FMOD_Studio_Bank_GetStringInfo(handle, index, out id, intPtr, retrieved, out retrieved);
			}
			if (rESULT == RESULT.OK)
			{
				path = threadSafeEncoding.stringFromNative(intPtr);
			}
			Marshal.FreeHGlobal(intPtr);
			return rESULT;
		}

		public RESULT getEventCount(out int count)
		{
			return FMOD_Studio_Bank_GetEventCount(handle, out count);
		}

		public RESULT getEventList(out EventDescription[] array)
		{
			array = null;
			RESULT rESULT = FMOD_Studio_Bank_GetEventCount(handle, out var count);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count == 0)
			{
				array = new EventDescription[0];
				return rESULT;
			}
			IntPtr[] array2 = new IntPtr[count];
			rESULT = FMOD_Studio_Bank_GetEventList(handle, array2, count, out var count2);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count2 > count)
			{
				count2 = count;
			}
			array = new EventDescription[count2];
			for (int i = 0; i < count2; i++)
			{
				array[i].handle = array2[i];
			}
			return RESULT.OK;
		}

		public RESULT getBusCount(out int count)
		{
			return FMOD_Studio_Bank_GetBusCount(handle, out count);
		}

		public RESULT getBusList(out Bus[] array)
		{
			array = null;
			RESULT rESULT = FMOD_Studio_Bank_GetBusCount(handle, out var count);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count == 0)
			{
				array = new Bus[0];
				return rESULT;
			}
			IntPtr[] array2 = new IntPtr[count];
			rESULT = FMOD_Studio_Bank_GetBusList(handle, array2, count, out var count2);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count2 > count)
			{
				count2 = count;
			}
			array = new Bus[count2];
			for (int i = 0; i < count2; i++)
			{
				array[i].handle = array2[i];
			}
			return RESULT.OK;
		}

		public RESULT getVCACount(out int count)
		{
			return FMOD_Studio_Bank_GetVCACount(handle, out count);
		}

		public RESULT getVCAList(out VCA[] array)
		{
			array = null;
			RESULT rESULT = FMOD_Studio_Bank_GetVCACount(handle, out var count);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count == 0)
			{
				array = new VCA[0];
				return rESULT;
			}
			IntPtr[] array2 = new IntPtr[count];
			rESULT = FMOD_Studio_Bank_GetVCAList(handle, array2, count, out var count2);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count2 > count)
			{
				count2 = count;
			}
			array = new VCA[count2];
			for (int i = 0; i < count2; i++)
			{
				array[i].handle = array2[i];
			}
			return RESULT.OK;
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD_Studio_Bank_GetUserData(handle, out userdata);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD_Studio_Bank_SetUserData(handle, userdata);
		}

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_Bank_IsValid(IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetID(IntPtr bank, out Guid id);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetPath(IntPtr bank, IntPtr path, int size, out int retrieved);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_UnloadSampleData(IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetLoadingState(IntPtr bank, out LOADING_STATE state);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetStringCount(IntPtr bank, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetStringInfo(IntPtr bank, int index, out Guid id, IntPtr path, int size, out int retrieved);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetEventCount(IntPtr bank, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetEventList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetVCACount(IntPtr bank, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetVCAList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetUserData(IntPtr bank, out IntPtr userdata);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_SetUserData(IntPtr bank, IntPtr userdata);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}

		public bool isValid()
		{
			if (hasHandle())
			{
				return FMOD_Studio_Bank_IsValid(handle);
			}
			return false;
		}
	}
	public struct CommandReplay
	{
		public IntPtr handle;

		public RESULT getSystem(out System system)
		{
			return FMOD_Studio_CommandReplay_GetSystem(handle, out system.handle);
		}

		public RESULT getLength(out float totalTime)
		{
			return FMOD_Studio_CommandReplay_GetLength(handle, out totalTime);
		}

		public RESULT getCommandCount(out int count)
		{
			return FMOD_Studio_CommandReplay_GetCommandCount(handle, out count);
		}

		public RESULT getCommandInfo(int commandIndex, out COMMAND_INFO info)
		{
			return FMOD_Studio_CommandReplay_GetCommandInfo(handle, commandIndex, out info);
		}

		public RESULT getCommandString(int commandIndex, out string description)
		{
			description = null;
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			int num = 256;
			IntPtr intPtr = Marshal.AllocHGlobal(256);
			RESULT rESULT = FMOD_Studio_CommandReplay_GetCommandString(handle, commandIndex, intPtr, num);
			while (true)
			{
				switch (rESULT)
				{
				case RESULT.ERR_TRUNCATED:
					goto IL_002b;
				case RESULT.OK:
					description = threadSafeEncoding.stringFromNative(intPtr);
					break;
				}
				break;
				IL_002b:
				Marshal.FreeHGlobal(intPtr);
				num *= 2;
				intPtr = Marshal.AllocHGlobal(num);
				rESULT = FMOD_Studio_CommandReplay_GetCommandString(handle, commandIndex, intPtr, num);
			}
			Marshal.FreeHGlobal(intPtr);
			return rESULT;
		}

		public RESULT getCommandAtTime(float time, out int commandIndex)
		{
			return FMOD_Studio_CommandReplay_GetCommandAtTime(handle, time, out commandIndex);
		}

		public RESULT setBankPath(string bankPath)
		{
			using StringHelper.ThreadSafeEncoding threadSafeEncoding = StringHelper.GetFreeHelper();
			return FMOD_Studio_CommandReplay_SetBankPath(handle, threadSafeEncoding.byteFromStringUTF8(bankPath));
		}

		public RESULT start()
		{
			return FMOD_Studio_CommandReplay_Start(handle);
		}

		public RESULT stop()
		{
			return FMOD_Studio_CommandReplay_Stop(handle);
		}

		public RESULT seekToTime(float time)
		{
			return FMOD_Studio_CommandReplay_SeekToTime(handle, time);
		}

		public RESULT seekToCommand(int commandIndex)
		{
			return FMOD_Studio_CommandReplay_SeekToCommand(handle, commandIndex);
		}

		public RESULT getPaused(out bool paused)
		{
			return FMOD_Studio_CommandReplay_GetPaused(handle, out paused);
		}

		public RESULT setPaused(bool paused)
		{
			return FMOD_Studio_CommandReplay_SetPaused(handle, paused);
		}

		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return FMOD_Studio_CommandReplay_GetPlaybackState(handle, out state);
		}

		public RESULT getCurrentCommand(out int commandIndex, out float currentTime)
		{
			return FMOD_Studio_CommandReplay_GetCurrentCommand(handle, out commandIndex, out currentTime);
		}

		public RESULT release()
		{
			return FMOD_Studio_CommandReplay_Release(handle);
		}

		public RESULT setFrameCallback(COMMANDREPLAY_FRAME_CALLBACK callback)
		{
			return FMOD_Studio_CommandReplay_SetFrameCallback(handle, callback);
		}

		public RESULT setLoadBankCallback(COMMANDREPLAY_LOAD_BANK_CALLBACK callback)
		{
			return FMOD_Studio_CommandReplay_SetLoadBankCallback(handle, callback);
		}

		public RESULT setCreateInstanceCallback(COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback)
		{
			return FMOD_Studio_CommandReplay_SetCreateInstanceCallback(handle, callback);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD_Studio_CommandReplay_GetUserData(handle, out userdata);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD_Studio_CommandReplay_SetUserData(handle, userdata);
		}

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_CommandReplay_IsValid(IntPtr replay);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetSystem(IntPtr replay, out IntPtr system);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetLength(IntPtr replay, out float totalTime);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandCount(IntPtr replay, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandInfo(IntPtr replay, int commandIndex, out COMMAND_INFO info);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandString(IntPtr replay, int commandIndex, IntPtr description, int capacity);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandAtTime(IntPtr replay, float time, out int commandIndex);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetBankPath(IntPtr replay, byte[] bankPath);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_Start(IntPtr replay);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_Stop(IntPtr replay);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToTime(IntPtr replay, float time);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToCommand(IntPtr replay, int commandIndex);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPaused(IntPtr replay, out bool paused);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetPaused(IntPtr replay, bool paused);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPlaybackState(IntPtr replay, out PLAYBACK_STATE state);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCurrentCommand(IntPtr replay, out int commandIndex, out float currentTime);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_Release(IntPtr replay);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetFrameCallback(IntPtr replay, COMMANDREPLAY_FRAME_CALLBACK callback);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetLoadBankCallback(IntPtr replay, COMMANDREPLAY_LOAD_BANK_CALLBACK callback);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetCreateInstanceCallback(IntPtr replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetUserData(IntPtr replay, out IntPtr userdata);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetUserData(IntPtr replay, IntPtr userdata);

		public bool hasHandle()
		{
			return handle != IntPtr.Zero;
		}

		public void clearHandle()
		{
			handle = IntPtr.Zero;
		}

		public bool isValid()
		{
			if (hasHandle())
			{
				return FMOD_Studio_CommandReplay_IsValid(handle);
			}
			return false;
		}
	}
}
namespace FMODUnity
{
	public class BankRefAttribute : PropertyAttribute
	{
	}
	public class EventRefAttribute : PropertyAttribute
	{
	}
	public class OneshotList
	{
		private List<FMOD.Studio.EventInstance> instances = new List<FMOD.Studio.EventInstance>();

		public void Add(FMOD.Studio.EventInstance instance)
		{
			instances.Add(instance);
		}

		public void Update(ATTRIBUTES_3D attributes)
		{
			PLAYBACK_STATE state;
			foreach (FMOD.Studio.EventInstance item in instances.FindAll(delegate(FMOD.Studio.EventInstance x)
			{
				x.getPlaybackState(out state);
				return state == PLAYBACK_STATE.STOPPED;
			}))
			{
				item.release();
			}
			instances.RemoveAll((FMOD.Studio.EventInstance x) => !x.isValid());
			foreach (FMOD.Studio.EventInstance instance in instances)
			{
				instance.set3DAttributes(attributes);
			}
		}

		public void SetParameterValue(string name, float value)
		{
			foreach (FMOD.Studio.EventInstance instance in instances)
			{
				instance.setParameterValue(name, value);
			}
		}

		public void StopAll(FMOD.Studio.STOP_MODE stopMode)
		{
			foreach (FMOD.Studio.EventInstance instance in instances)
			{
				instance.stop(stopMode);
				instance.release();
			}
			instances.Clear();
		}
	}
	[Serializable]
	public class ParamRef
	{
		public string Name;

		public float Value;
	}
	[AddComponentMenu("")]
	public class RuntimeManager : MonoBehaviour
	{
		private struct LoadedBank
		{
			public Bank Bank;

			public int RefCount;
		}

		private class GuidComparer : IEqualityComparer<Guid>
		{
			bool IEqualityComparer<Guid>.Equals(Guid x, Guid y)
			{
				return x.Equals(y);
			}

			int IEqualityComparer<Guid>.GetHashCode(Guid obj)
			{
				return obj.GetHashCode();
			}
		}

		private class AttachedInstance
		{
			public FMOD.Studio.EventInstance instance;

			public Transform transform;

			public Rigidbody rigidBody;

			public Rigidbody2D rigidBody2D;
		}

		private static SystemNotInitializedException initException = null;

		private static RuntimeManager instance;

		[SerializeField]
		private FMODPlatform fmodPlatform;

		private FMOD.Studio.System studioSystem;

		private FMOD.System lowlevelSystem;

		private DSP mixerHead;

		[SerializeField]
		private long[] cachedPointers = new long[2];

		private Dictionary<string, LoadedBank> loadedBanks = new Dictionary<string, LoadedBank>();

		private Dictionary<string, uint> loadedPlugins = new Dictionary<string, uint>();

		private Dictionary<Guid, EventDescription> cachedDescriptions = new Dictionary<Guid, EventDescription>(new GuidComparer());

		private List<AttachedInstance> attachedInstances = new List<AttachedInstance>(128);

		private bool listenerWarningIssued;

		private string lastDebugText;

		private float lastDebugUpdate;

		public static bool[] HasListener = new bool[8];

		private static RuntimeManager Instance
		{
			get
			{
				if (initException != null)
				{
					throw initException;
				}
				if (instance == null)
				{
					RESULT rESULT = RESULT.OK;
					RuntimeManager[] array = UnityEngine.Object.FindObjectsOfType(typeof(RuntimeManager)) as RuntimeManager[];
					RuntimeManager[] array2 = array;
					foreach (RuntimeManager runtimeManager in array2)
					{
						if (array != null)
						{
							if (runtimeManager.cachedPointers[0] != 0L)
							{
								instance = runtimeManager;
								instance.studioSystem.handle = (IntPtr)instance.cachedPointers[0];
								instance.lowlevelSystem.handle = (IntPtr)instance.cachedPointers[1];
							}
							UnityEngine.Object.DestroyImmediate(runtimeManager);
						}
					}
					GameObject gameObject = new GameObject("FMOD.UnityIntegration.RuntimeManager");
					instance = gameObject.AddComponent<RuntimeManager>();
					if (Application.isPlaying)
					{
						UnityEngine.Object.DontDestroyOnLoad(gameObject);
					}
					gameObject.hideFlags = HideFlags.HideAndDontSave;
					try
					{
						AndroidJavaObject androidJavaObject = null;
						using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
						{
							androidJavaObject = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
						}
						using (AndroidJavaClass androidJavaClass2 = new AndroidJavaClass("org.fmod.FMOD"))
						{
							if (androidJavaClass2 != null)
							{
								androidJavaClass2.CallStatic("init", androidJavaObject);
							}
							else
							{
								UnityEngine.Debug.LogWarning("[FMOD] Cannot initialize Java wrapper");
							}
						}
						RuntimeUtils.EnforceLibraryOrder();
						rESULT = instance.Initialize();
					}
					catch (Exception ex)
					{
						initException = ex as SystemNotInitializedException;
						if (initException == null)
						{
							initException = new SystemNotInitializedException(ex);
						}
						throw initException;
					}
					if (rESULT != 0)
					{
						throw new SystemNotInitializedException(rESULT, "Output forced to NO SOUND mode");
					}
				}
				return instance;
			}
		}

		public static FMOD.Studio.System StudioSystem => Instance.studioSystem;

		public static FMOD.System LowlevelSystem => Instance.lowlevelSystem;

		public static bool IsInitialized
		{
			get
			{
				if (instance != null)
				{
					return instance.studioSystem.isValid();
				}
				return false;
			}
		}

		public static bool HasBanksLoaded => Instance.loadedBanks.Count > 1;

		[MonoPInvokeCallback(typeof(DEBUG_CALLBACK))]
		private static RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message)
		{
			switch (flags)
			{
			case DEBUG_FLAGS.ERROR:
				UnityEngine.Debug.LogError($"[FMOD] {(string)func} : {(string)message}");
				break;
			case DEBUG_FLAGS.WARNING:
				UnityEngine.Debug.LogWarning($"[FMOD] {(string)func} : {(string)message}");
				break;
			case DEBUG_FLAGS.LOG:
				UnityEngine.Debug.Log($"[FMOD] {(string)func} : {(string)message}");
				break;
			}
			return RESULT.OK;
		}

		private void CheckInitResult(RESULT result, string cause)
		{
			if (result != 0)
			{
				if (studioSystem.isValid())
				{
					studioSystem.release();
					studioSystem.clearHandle();
				}
				throw new SystemNotInitializedException(result, cause);
			}
		}

		private RESULT Initialize()
		{
			RESULT rESULT = RESULT.OK;
			RESULT rESULT2 = RESULT.OK;
			Settings settings = Settings.Instance;
			fmodPlatform = RuntimeUtils.GetCurrentPlatform();
			int sampleRate = settings.GetSampleRate(fmodPlatform);
			int num = Math.Min(settings.GetRealChannels(fmodPlatform), 256);
			int virtualChannels = settings.GetVirtualChannels(fmodPlatform);
			SPEAKERMODE speakerMode = (SPEAKERMODE)settings.GetSpeakerMode(fmodPlatform);
			OUTPUTTYPE output = OUTPUTTYPE.AUTODETECT;
			FMOD.ADVANCEDSETTINGS settings2 = default(FMOD.ADVANCEDSETTINGS);
			settings2.randomSeed = (uint)DateTime.Now.Ticks;
			settings2.maxFADPCMCodecs = num;
			SetThreadAffinity();
			FMOD.Studio.INITFLAGS iNITFLAGS = FMOD.Studio.INITFLAGS.DEFERRED_CALLBACKS;
			if (settings.IsLiveUpdateEnabled(fmodPlatform))
			{
				iNITFLAGS |= FMOD.Studio.INITFLAGS.LIVEUPDATE;
				settings2.profilePort = settings.LiveUpdatePort;
			}
			while (true)
			{
				rESULT = FMOD.Studio.System.create(out studioSystem);
				CheckInitResult(rESULT, "FMOD.Studio.System.create");
				rESULT = studioSystem.getLowLevelSystem(out lowlevelSystem);
				CheckInitResult(rESULT, "FMOD.Studio.System.getLowLevelSystem");
				rESULT = lowlevelSystem.setOutput(output);
				CheckInitResult(rESULT, "FMOD.System.setOutput");
				rESULT = lowlevelSystem.setSoftwareChannels(num);
				CheckInitResult(rESULT, "FMOD.System.setSoftwareChannels");
				rESULT = lowlevelSystem.setSoftwareFormat(sampleRate, speakerMode, 0);
				CheckInitResult(rESULT, "FMOD.System.setSoftwareFormat");
				rESULT = lowlevelSystem.setAdvancedSettings(ref settings2);
				CheckInitResult(rESULT, "FMOD.System.setAdvancedSettings");
				rESULT = studioSystem.initialize(virtualChannels, iNITFLAGS, FMOD.INITFLAGS.NORMAL, IntPtr.Zero);
				if (rESULT != 0 && rESULT2 == RESULT.OK)
				{
					rESULT2 = rESULT;
					output = OUTPUTTYPE.NOSOUND;
					UnityEngine.Debug.LogErrorFormat("[FMOD] Studio::System::initialize returned {0}, defaulting to no-sound mode.", rESULT.ToString());
					continue;
				}
				CheckInitResult(rESULT, "Studio::System::initialize");
				if ((iNITFLAGS & FMOD.Studio.INITFLAGS.LIVEUPDATE) == 0)
				{
					break;
				}
				studioSystem.flushCommands();
				rESULT = studioSystem.update();
				if (rESULT != RESULT.ERR_NET_SOCKET_ERROR)
				{
					break;
				}
				iNITFLAGS &= ~FMOD.Studio.INITFLAGS.LIVEUPDATE;
				UnityEngine.Debug.LogWarning("[FMOD] Cannot open network port for Live Update (in-use), restarting with Live Update disabled.");
				rESULT = studioSystem.release();
				CheckInitResult(rESULT, "FMOD.Studio.System.Release");
			}
			LoadPlugins(settings);
			LoadBanks(settings);
			return rESULT2;
		}

		private void Update()
		{
			if (!studioSystem.isValid())
			{
				return;
			}
			bool flag = false;
			bool flag2 = false;
			int numListeners = 0;
			for (int num = 7; num >= 0; num--)
			{
				if (!flag && HasListener[num])
				{
					numListeners = num + 1;
					flag = true;
					flag2 = true;
				}
				if (!HasListener[num] && flag)
				{
					flag2 = false;
				}
			}
			if (flag)
			{
				studioSystem.setNumListeners(numListeners);
			}
			if (!flag2 && !listenerWarningIssued)
			{
				listenerWarningIssued = true;
				UnityEngine.Debug.LogWarning("[FMOD] Please add an 'FMOD Studio Listener' component to your a camera in the scene for correct 3D positioning of sounds");
			}
			for (int i = 0; i < attachedInstances.Count; i++)
			{
				PLAYBACK_STATE state = PLAYBACK_STATE.STOPPED;
				attachedInstances[i].instance.getPlaybackState(out state);
				if (!attachedInstances[i].instance.isValid() || state == PLAYBACK_STATE.STOPPED || attachedInstances[i].transform == null)
				{
					attachedInstances.RemoveAt(i);
					i--;
				}
				else if ((bool)attachedInstances[i].rigidBody)
				{
					attachedInstances[i].instance.set3DAttributes(RuntimeUtils.To3DAttributes(attachedInstances[i].transform, attachedInstances[i].rigidBody));
				}
				else
				{
					attachedInstances[i].instance.set3DAttributes(RuntimeUtils.To3DAttributes(attachedInstances[i].transform, attachedInstances[i].rigidBody2D));
				}
			}
			studioSystem.update();
		}

		public static void AttachInstanceToGameObject(FMOD.Studio.EventInstance instance, Transform transform, Rigidbody rigidBody)
		{
			instance.set3DAttributes(RuntimeUtils.To3DAttributes(transform, rigidBody));
			AttachedInstance attachedInstance = new AttachedInstance();
			attachedInstance.transform = transform;
			attachedInstance.instance = instance;
			attachedInstance.rigidBody = rigidBody;
			Instance.attachedInstances.Add(attachedInstance);
		}

		public static void AttachInstanceToGameObject(FMOD.Studio.EventInstance instance, Transform transform, Rigidbody2D rigidBody2D)
		{
			instance.set3DAttributes(RuntimeUtils.To3DAttributes(transform, rigidBody2D));
			AttachedInstance attachedInstance = new AttachedInstance();
			attachedInstance.transform = transform;
			attachedInstance.instance = instance;
			attachedInstance.rigidBody2D = rigidBody2D;
			attachedInstance.rigidBody = null;
			Instance.attachedInstances.Add(attachedInstance);
		}

		public static void DetachInstanceFromGameObject(FMOD.Studio.EventInstance instance)
		{
			RuntimeManager runtimeManager = Instance;
			for (int i = 0; i < runtimeManager.attachedInstances.Count; i++)
			{
				if (runtimeManager.attachedInstances[i].instance.handle == instance.handle)
				{
					runtimeManager.attachedInstances.RemoveAt(i);
					break;
				}
			}
		}

		private void DrawDebugOverlay(int windowID)
		{
			if (lastDebugUpdate + 0.25f < Time.unscaledTime)
			{
				if (initException != null)
				{
					lastDebugText = initException.Message;
				}
				else
				{
					if (!mixerHead.hasHandle())
					{
						lowlevelSystem.getMasterChannelGroup(out var channelgroup);
						channelgroup.getDSP(0, out mixerHead);
						mixerHead.setMeteringEnabled(inputEnabled: false, outputEnabled: true);
					}
					StringBuilder stringBuilder = new StringBuilder();
					studioSystem.getCPUUsage(out var usage);
					stringBuilder.AppendFormat("CPU: dsp = {0:F1}%, studio = {1:F1}%\n", usage.dspusage, usage.studiousage);
					Memory.GetStats(out var currentalloced, out var maxalloced);
					stringBuilder.AppendFormat("MEMORY: cur = {0}MB, max = {1}MB\n", currentalloced >> 20, maxalloced >> 20);
					lowlevelSystem.getChannelsPlaying(out var channels, out var realchannels);
					stringBuilder.AppendFormat("CHANNELS: real = {0}, total = {1}\n", realchannels, channels);
					mixerHead.getMeteringInfo(IntPtr.Zero, out var outputInfo);
					float num = 0f;
					for (int i = 0; i < outputInfo.numchannels; i++)
					{
						num += outputInfo.rmslevel[i] * outputInfo.rmslevel[i];
					}
					num = Mathf.Sqrt(num / (float)outputInfo.numchannels);
					float num2 = ((num > 0f) ? (20f * Mathf.Log10(num * Mathf.Sqrt(2f))) : (-80f));
					if (num2 > 10f)
					{
						num2 = 10f;
					}
					stringBuilder.AppendFormat("VOLUME: RMS = {0:f2}db\n", num2);
					lastDebugText = stringBuilder.ToString();
					lastDebugUpdate = Time.unscaledTime;
				}
			}
			GUI.Label(new Rect(10f, 20f, 290f, 100f), lastDebugText);
			GUI.DragWindow();
		}

		private void OnDisable()
		{
			cachedPointers[0] = (long)studioSystem.handle;
			cachedPointers[1] = (long)lowlevelSystem.handle;
		}

		private void OnDestroy()
		{
			if (studioSystem.isValid())
			{
				studioSystem.release();
				studioSystem.clearHandle();
			}
			initException = null;
			instance = null;
		}

		private void OnApplicationPause(bool pauseStatus)
		{
			if (studioSystem.isValid())
			{
				PauseAllEvents(pauseStatus);
				if (pauseStatus)
				{
					lowlevelSystem.mixerSuspend();
				}
				else
				{
					lowlevelSystem.mixerResume();
				}
			}
		}

		private void loadedBankRegister(LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, RESULT loadResult)
		{
			switch (loadResult)
			{
			case RESULT.OK:
				loadedBank.RefCount = 1;
				if (loadSamples)
				{
					loadedBank.Bank.loadSampleData();
				}
				Instance.loadedBanks.Add(bankName, loadedBank);
				break;
			case RESULT.ERR_EVENT_ALREADY_LOADED:
				loadedBank.RefCount = 2;
				Instance.loadedBanks.Add(bankName, loadedBank);
				break;
			default:
				throw new BankLoadException(bankPath, loadResult);
			}
		}

		public static void LoadBank(string bankName, bool loadSamples = false)
		{
			if (Instance.loadedBanks.ContainsKey(bankName))
			{
				LoadedBank value = Instance.loadedBanks[bankName];
				value.RefCount++;
				if (loadSamples)
				{
					value.Bank.loadSampleData();
				}
				Instance.loadedBanks[bankName] = value;
				return;
			}
			string bankPath = RuntimeUtils.GetBankPath(bankName);
			RESULT loadResult;
			if (!bankPath.StartsWith("file:///android_asset"))
			{
				using (WWW wWW = new WWW(bankPath))
				{
					while (!wWW.isDone)
					{
					}
					if (!string.IsNullOrEmpty(wWW.error))
					{
						throw new BankLoadException(bankPath, wWW.error);
					}
					LoadedBank loadedBank = default(LoadedBank);
					loadResult = Instance.studioSystem.loadBankMemory(wWW.bytes, LOAD_BANK_FLAGS.NORMAL, out loadedBank.Bank);
					Instance.loadedBankRegister(loadedBank, bankPath, bankName, loadSamples, loadResult);
					return;
				}
			}
			LoadedBank loadedBank2 = default(LoadedBank);
			loadResult = Instance.studioSystem.loadBankFile(bankPath, LOAD_BANK_FLAGS.NORMAL, out loadedBank2.Bank);
			Instance.loadedBankRegister(loadedBank2, bankPath, bankName, loadSamples, loadResult);
		}

		public static void LoadBank(TextAsset asset, bool loadSamples = false)
		{
			string text = asset.name;
			if (Instance.loadedBanks.ContainsKey(text))
			{
				LoadedBank loadedBank = Instance.loadedBanks[text];
				loadedBank.RefCount++;
				if (loadSamples)
				{
					loadedBank.Bank.loadSampleData();
				}
				return;
			}
			LoadedBank value = default(LoadedBank);
			RESULT rESULT = Instance.studioSystem.loadBankMemory(asset.bytes, LOAD_BANK_FLAGS.NORMAL, out value.Bank);
			switch (rESULT)
			{
			case RESULT.OK:
				value.RefCount = 1;
				Instance.loadedBanks.Add(text, value);
				if (loadSamples)
				{
					value.Bank.loadSampleData();
				}
				break;
			case RESULT.ERR_EVENT_ALREADY_LOADED:
				value.RefCount = 2;
				Instance.loadedBanks.Add(text, value);
				break;
			default:
				throw new BankLoadException(text, rESULT);
			}
		}

		private void LoadBanks(Settings fmodSettings)
		{
			if (fmodSettings.ImportType != 0)
			{
				return;
			}
			try
			{
				foreach (string masterBank in fmodSettings.MasterBanks)
				{
					LoadBank(masterBank + ".strings", fmodSettings.AutomaticSampleLoading);
					if (fmodSettings.AutomaticEventLoading)
					{
						LoadBank(masterBank, fmodSettings.AutomaticSampleLoading);
					}
				}
				if (!fmodSettings.AutomaticEventLoading)
				{
					return;
				}
				foreach (string bank in fmodSettings.Banks)
				{
					LoadBank(bank, fmodSettings.AutomaticSampleLoading);
				}
				WaitForAllLoads();
			}
			catch (BankLoadException exception)
			{
				UnityEngine.Debug.LogException(exception);
			}
		}

		public static void UnloadBank(string bankName)
		{
			if (Instance.loadedBanks.TryGetValue(bankName, out var value))
			{
				value.RefCount--;
				if (value.RefCount == 0)
				{
					value.Bank.unload();
					Instance.loadedBanks.Remove(bankName);
				}
				else
				{
					Instance.loadedBanks[bankName] = value;
				}
			}
		}

		public static bool AnyBankLoading()
		{
			bool flag = false;
			foreach (LoadedBank value in Instance.loadedBanks.Values)
			{
				value.Bank.getSampleLoadingState(out var state);
				flag = flag || state == LOADING_STATE.LOADING;
			}
			return flag;
		}

		public static void WaitForAllLoads()
		{
			Instance.studioSystem.flushSampleLoading();
		}

		public static Guid PathToGUID(string path)
		{
			Guid guid = Guid.Empty;
			if (path.StartsWith("{"))
			{
				Util.ParseID(path, out guid);
			}
			else if (Instance.studioSystem.lookupID(path, out guid) == RESULT.ERR_EVENT_NOTFOUND)
			{
				throw new EventNotFoundException(path);
			}
			return guid;
		}

		public static FMOD.Studio.EventInstance CreateInstance(string path)
		{
			try
			{
				return CreateInstance(PathToGUID(path));
			}
			catch (EventNotFoundException)
			{
				throw new EventNotFoundException(path);
			}
		}

		public static FMOD.Studio.EventInstance CreateInstance(Guid guid)
		{
			GetEventDescription(guid).createInstance(out var result);
			return result;
		}

		public static void PlayOneShot(string path, Vector3 position = default(Vector3))
		{
			try
			{
				PlayOneShot(PathToGUID(path), position);
			}
			catch (EventNotFoundException)
			{
				UnityEngine.Debug.LogWarning("[FMOD] Event not found: " + path);
			}
		}

		public static void PlayOneShot(Guid guid, Vector3 position = default(Vector3))
		{
			FMOD.Studio.EventInstance eventInstance = CreateInstance(guid);
			eventInstance.set3DAttributes(position.To3DAttributes());
			eventInstance.start();
			eventInstance.release();
		}

		public static void PlayOneShotAttached(string path, GameObject gameObject)
		{
			try
			{
				PlayOneShotAttached(PathToGUID(path), gameObject);
			}
			catch (EventNotFoundException)
			{
				UnityEngine.Debug.LogWarning("[FMOD] Event not found: " + path);
			}
		}

		public static void PlayOneShotAttached(Guid guid, GameObject gameObject)
		{
			FMOD.Studio.EventInstance eventInstance = CreateInstance(guid);
			AttachInstanceToGameObject(eventInstance, gameObject.transform, gameObject.GetComponent<Rigidbody>());
			eventInstance.start();
			eventInstance.release();
		}

		public static EventDescription GetEventDescription(string path)
		{
			try
			{
				return GetEventDescription(PathToGUID(path));
			}
			catch (EventNotFoundException)
			{
				throw new EventNotFoundException(path);
			}
		}

		public static EventDescription GetEventDescription(Guid guid)
		{
			if (Instance.cachedDescriptions.ContainsKey(guid) && Instance.cachedDescriptions[guid].isValid())
			{
				return Instance.cachedDescriptions[guid];
			}
			if (Instance.studioSystem.getEventByID(guid, out var _event) != 0)
			{
				throw new EventNotFoundException(guid);
			}
			if (_event.isValid())
			{
				Instance.cachedDescriptions[guid] = _event;
			}
			return _event;
		}

		public static void SetListenerLocation(GameObject gameObject, Rigidbody rigidBody = null)
		{
			Instance.studioSystem.setListenerAttributes(0, RuntimeUtils.To3DAttributes(gameObject, rigidBody));
		}

		public static void SetListenerLocation(GameObject gameObject, Rigidbody2D rigidBody2D)
		{
			Instance.studioSystem.setListenerAttributes(0, RuntimeUtils.To3DAttributes(gameObject, rigidBody2D));
		}

		public static void SetListenerLocation(Transform transform)
		{
			Instance.studioSystem.setListenerAttributes(0, transform.To3DAttributes());
		}

		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody rigidBody = null)
		{
			Instance.studioSystem.setListenerAttributes(listenerIndex, RuntimeUtils.To3DAttributes(gameObject, rigidBody));
		}

		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody2D rigidBody2D)
		{
			Instance.studioSystem.setListenerAttributes(listenerIndex, RuntimeUtils.To3DAttributes(gameObject, rigidBody2D));
		}

		public static void SetListenerLocation(int listenerIndex, Transform transform)
		{
			Instance.studioSystem.setListenerAttributes(listenerIndex, transform.To3DAttributes());
		}

		public static Bus GetBus(string path)
		{
			if (StudioSystem.getBus(path, out var bus) != 0)
			{
				throw new BusNotFoundException(path);
			}
			return bus;
		}

		public static VCA GetVCA(string path)
		{
			if (StudioSystem.getVCA(path, out var vca) != 0)
			{
				throw new VCANotFoundException(path);
			}
			return vca;
		}

		public static void PauseAllEvents(bool paused)
		{
			if (HasBanksLoaded && StudioSystem.getBus("bus:/", out var bus) == RESULT.OK)
			{
				bus.setPaused(paused);
			}
		}

		public static void MuteAllEvents(bool muted)
		{
			if (HasBanksLoaded && StudioSystem.getBus("bus:/", out var bus) == RESULT.OK)
			{
				bus.setMute(muted);
			}
		}

		public static bool HasBankLoaded(string loadedBank)
		{
			return instance.loadedBanks.ContainsKey(loadedBank);
		}

		private void LoadPlugins(Settings fmodSettings)
		{
			foreach (string plugin in fmodSettings.Plugins)
			{
				if (!string.IsNullOrEmpty(plugin))
				{
					string pluginPath = RuntimeUtils.GetPluginPath(plugin);
					uint handle;
					RESULT result = lowlevelSystem.loadPlugin(pluginPath, out handle);
					CheckInitResult(result, $"Loading plugin '{plugin}' from '{pluginPath}'");
					loadedPlugins.Add(plugin, handle);
				}
			}
		}

		private void SetThreadAffinity()
		{
		}
	}
	public class EventNotFoundException : Exception
	{
		public Guid Guid;

		public string Path;

		public EventNotFoundException(string path)
			: base("[FMOD] Event not found '" + path + "'")
		{
			Path = path;
		}

		public EventNotFoundException(Guid guid)
			: base(("[FMOD] Event not found " + guid.ToString("b")) ?? "")
		{
			Guid = guid;
		}
	}
	public class BusNotFoundException : Exception
	{
		public string Path;

		public BusNotFoundException(string path)
			: base("[FMOD] Bus not found '" + path + "'")
		{
			Path = path;
		}
	}
	public class VCANotFoundException : Exception
	{
		public string Path;

		public VCANotFoundException(string path)
			: base("[FMOD] VCA not found '" + path + "'")
		{
			Path = path;
		}
	}
	public class BankLoadException : Exception
	{
		public string Path;

		public RESULT Result;

		public BankLoadException(string path, RESULT result)
			: base($"[FMOD] Could not load bank '{path}' : {result.ToString()} : {Error.String(result)}")
		{
			Path = path;
			Result = result;
		}

		public BankLoadException(string path, string error)
			: base($"[FMOD] Could not load bank '{path}' : {error}")
		{
			Path = path;
			Result = RESULT.ERR_INTERNAL;
		}
	}
	public class SystemNotInitializedException : Exception
	{
		public RESULT Result;

		public string Location;

		public SystemNotInitializedException(RESULT result, string location)
			: base(string.Format("[FMOD] Initialization failed : {2} : {0} : {1}", result.ToString(), Error.String(result), location))
		{
			Result = result;
			Location = location;
		}

		public SystemNotInitializedException(Exception inner)
			: base("[FMOD] Initialization failed", inner)
		{
		}
	}
	public enum EmitterGameEvent
	{
		None,
		ObjectStart,
		ObjectDestroy,
		TriggerEnter,
		TriggerExit,
		TriggerEnter2D,
		TriggerExit2D,
		CollisionEnter,
		CollisionExit,
		CollisionEnter2D,
		CollisionExit2D,
		ObjectEnable,
		ObjectDisable
	}
	public enum LoaderGameEvent
	{
		None,
		ObjectStart,
		ObjectDestroy,
		TriggerEnter,
		TriggerExit,
		TriggerEnter2D,
		TriggerExit2D
	}
	public static class RuntimeUtils
	{
		private const string BankExtension = ".bank";

		public static VECTOR ToFMODVector(this Vector3 vec)
		{
			VECTOR result = default(VECTOR);
			result.x = vec.x;
			result.y = vec.y;
			result.z = vec.z;
			return result;
		}

		public static ATTRIBUTES_3D To3DAttributes(this Vector3 pos)
		{
			ATTRIBUTES_3D result = default(ATTRIBUTES_3D);
			result.forward = Vector3.forward.ToFMODVector();
			result.up = Vector3.up.ToFMODVector();
			result.position = pos.ToFMODVector();
			return result;
		}

		public static ATTRIBUTES_3D To3DAttributes(this Transform transform)
		{
			ATTRIBUTES_3D result = default(ATTRIBUTES_3D);
			result.forward = transform.forward.ToFMODVector();
			result.up = transform.up.ToFMODVector();
			result.position = transform.position.ToFMODVector();
			return result;
		}

		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody rigidbody = null)
		{
			ATTRIBUTES_3D result = transform.To3DAttributes();
			if ((bool)rigidbody)
			{
				result.velocity = rigidbody.velocity.ToFMODVector();
			}
			return result;
		}

		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody rigidbody = null)
		{
			ATTRIBUTES_3D result = go.transform.To3DAttributes();
			if ((bool)rigidbody)
			{
				result.velocity = rigidbody.velocity.ToFMODVector();
			}
			return result;
		}

		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody)
		{
			ATTRIBUTES_3D result = transform.To3DAttributes();
			if ((bool)rigidbody)
			{
				VECTOR velocity = default(VECTOR);
				velocity.x = rigidbody.velocity.x;
				velocity.y = rigidbody.velocity.y;
				velocity.z = 0f;
				result.velocity = velocity;
			}
			return result;
		}

		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody)
		{
			ATTRIBUTES_3D result = go.transform.To3DAttributes();
			if ((bool)rigidbody)
			{
				VECTOR velocity = default(VECTOR);
				velocity.x = rigidbody.velocity.x;
				velocity.y = rigidbody.velocity.y;
				velocity.z = 0f;
				result.velocity = velocity;
			}
			return result;
		}

		internal static FMODPlatform GetCurrentPlatform()
		{
			FMODPlatform result;
			if (SystemInfo.processorCount <= 2)
			{
				result = FMODPlatform.MobileLow;
			}
			else if (SystemInfo.processorCount >= 8)
			{
				result = FMODPlatform.MobileHigh;
			}
			else
			{
				string path = "/sys/devices/system/cpu/cpu0/cpufreq/cpuinfo_max_freq";
				try
				{
					using TextReader textReader = new StreamReader(path);
					result = ((int.Parse(textReader.ReadLine()) / 1000 < 1600) ? FMODPlatform.MobileLow : FMODPlatform.MobileHigh);
				}
				catch
				{
					result = FMODPlatform.MobileLow;
				}
			}
			UnityEngine.Debug.Log($"[FMOD] Device {SystemInfo.deviceModel} classed as {result.ToString()}");
			return result;
		}

		internal static string GetBankPath(string bankName)
		{
			string text = null;
			text = ((!(Path.GetExtension(Application.dataPath) == ".apk")) ? $"jar:file://{Application.dataPath}!/assets" : "file:///android_asset");
			if (Path.GetExtension(bankName) != ".bank")
			{
				return $"{text}/{bankName}.bank";
			}
			return $"{text}/{bankName}";
		}

		internal static string GetPluginPath(string pluginName)
		{
			string text = "lib" + pluginName + ".so";
			return "" + text;
		}

		public static void EnforceLibraryOrder()
		{
			Memory.GetStats(out var _, out var _);
			Util.ParseID("", out var _);
		}
	}
	[Serializable]
	public enum FMODPlatform
	{
		None,
		PlayInEditor,
		Default,
		Desktop,
		Mobile,
		MobileHigh,
		MobileLow,
		Console,
		Windows,
		Mac,
		Linux,
		iOS,
		Android,
		WindowsPhone,
		XboxOne,
		PS4,
		WiiU,
		PSVita,
		AppleTV,
		UWP,
		Switch,
		WebGL,
		Count
	}
	[Serializable]
	public enum ImportType
	{
		StreamingAssets,
		AssetBundle
	}
	public class PlatformSettingBase
	{
		public FMODPlatform Platform;
	}
	public class PlatformSetting<T> : PlatformSettingBase
	{
		public T Value;
	}
	[Serializable]
	public class PlatformIntSetting : PlatformSetting<int>
	{
	}
	[Serializable]
	public class PlatformStringSetting : PlatformSetting<string>
	{
	}
	public enum TriStateBool
	{
		Disabled,
		Enabled,
		Development
	}
	[Serializable]
	public class PlatformBoolSetting : PlatformSetting<TriStateBool>
	{
	}
	public class Settings : ScriptableObject
	{
		private const string SettingsAssetName = "FMODStudioSettings";

		private static Settings instance;

		[SerializeField]
		public bool HasSourceProject = true;

		[SerializeField]
		public bool HasPlatforms = true;

		[SerializeField]
		private string sourceProjectPath;

		[SerializeField]
		public string SourceProjectPathUnformatted;

		private string sourceBankPath;

		[SerializeField]
		public string SourceBankPathUnformatted;

		[SerializeField]
		public bool AutomaticEventLoading;

		[SerializeField]
		public bool AutomaticSampleLoading;

		[SerializeField]
		public ImportType ImportType;

		[SerializeField]
		public string TargetAssetPath;

		[SerializeField]
		public DEBUG_FLAGS LoggingLevel = DEBUG_FLAGS.WARNING;

		[SerializeField]
		public List<PlatformIntSetting> SpeakerModeSettings;

		[SerializeField]
		public List<PlatformIntSetting> SampleRateSettings;

		[SerializeField]
		public List<PlatformBoolSetting> LiveUpdateSettings;

		[SerializeField]
		public List<PlatformBoolSetting> OverlaySettings;

		[SerializeField]
		public List<PlatformBoolSetting> LoggingSettings;

		[SerializeField]
		public List<PlatformStringSetting> BankDirectorySettings;

		[SerializeField]
		public List<PlatformIntSetting> VirtualChannelSettings;

		[SerializeField]
		public List<PlatformIntSetting> RealChannelSettings;

		[SerializeField]
		public List<string> Plugins = new List<string>();

		[SerializeField]
		public List<string> MasterBanks;

		[SerializeField]
		public List<string> Banks;

		[SerializeField]
		public ushort LiveUpdatePort = 9264;

		public static Settings Instance
		{
			get
			{
				if (instance == null)
				{
					instance = Resources.Load("FMODStudioSettings") as Settings;
					if (instance == null)
					{
						UnityEngine.Debug.Log("[FMOD] Cannot find integration settings, creating default settings");
						instance = ScriptableObject.CreateInstance<Settings>();
						instance.name = "FMOD Studio Integration Settings";
					}
				}
				return instance;
			}
		}

		public string SourceProjectPath
		{
			get
			{
				if (string.IsNullOrEmpty(sourceProjectPath) && !string.IsNullOrEmpty(SourceProjectPathUnformatted))
				{
					sourceProjectPath = GetPlatformSpecificPath(SourceProjectPathUnformatted);
				}
				return sourceProjectPath;
			}
			set
			{
				sourceProjectPath = GetPlatformSpecificPath(value);
			}
		}

		public string SourceBankPath
		{
			get
			{
				if (string.IsNullOrEmpty(sourceBankPath) && !string.IsNullOrEmpty(SourceBankPathUnformatted))
				{
					sourceBankPath = GetPlatformSpecificPath(SourceBankPathUnformatted);
				}
				return sourceBankPath;
			}
			set
			{
				sourceBankPath = GetPlatformSpecificPath(value);
			}
		}

		public static FMODPlatform GetParent(FMODPlatform platform)
		{
			switch (platform)
			{
			case FMODPlatform.Windows:
			case FMODPlatform.Mac:
			case FMODPlatform.Linux:
			case FMODPlatform.UWP:
				return FMODPlatform.Desktop;
			case FMODPlatform.MobileHigh:
			case FMODPlatform.MobileLow:
			case FMODPlatform.iOS:
			case FMODPlatform.Android:
			case FMODPlatform.WindowsPhone:
			case FMODPlatform.PSVita:
			case FMODPlatform.AppleTV:
			case FMODPlatform.Switch:
				return FMODPlatform.Mobile;
			case FMODPlatform.XboxOne:
			case FMODPlatform.PS4:
			case FMODPlatform.WiiU:
				return FMODPlatform.Console;
			case FMODPlatform.Desktop:
			case FMODPlatform.Mobile:
			case FMODPlatform.Console:
				return FMODPlatform.Default;
			default:
				return FMODPlatform.None;
			}
		}

		public static bool HasSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
			return list.Exists((T x) => x.Platform == platform);
		}

		public static U GetSetting<T, U>(List<T> list, FMODPlatform platform, U def) where T : PlatformSetting<U>
		{
			T val = list.Find((T x) => x.Platform == platform);
			if (val == null)
			{
				FMODPlatform parent = GetParent(platform);
				if (parent != 0)
				{
					return GetSetting(list, parent, def);
				}
				return def;
			}
			return val.Value;
		}

		public static void SetSetting<T, U>(List<T> list, FMODPlatform platform, U value) where T : PlatformSetting<U>, new()
		{
			T val = list.Find((T x) => x.Platform == platform);
			if (val == null)
			{
				val = new T
				{
					Platform = platform
				};
				list.Add(val);
			}
			val.Value = value;
		}

		public static void RemoveSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
			list.RemoveAll((T x) => x.Platform == platform);
		}

		public bool IsLiveUpdateEnabled(FMODPlatform platform)
		{
			return GetSetting(LiveUpdateSettings, platform, TriStateBool.Disabled) == TriStateBool.Enabled;
		}

		public bool IsOverlayEnabled(FMODPlatform platform)
		{
			return GetSetting(OverlaySettings, platform, TriStateBool.Disabled) == TriStateBool.Enabled;
		}

		public int GetRealChannels(FMODPlatform platform)
		{
			return GetSetting(RealChannelSettings, platform, 64);
		}

		public int GetVirtualChannels(FMODPlatform platform)
		{
			return GetSetting(VirtualChannelSettings, platform, 128);
		}

		public int GetSpeakerMode(FMODPlatform platform)
		{
			return GetSetting(SpeakerModeSettings, platform, 3);
		}

		public int GetSampleRate(FMODPlatform platform)
		{
			return GetSetting(SampleRateSettings, platform, 48000);
		}

		public string GetBankPlatform(FMODPlatform platform)
		{
			if (!HasPlatforms)
			{
				return "";
			}
			return GetSetting(BankDirectorySettings, platform, "Desktop");
		}

		private Settings()
		{
			MasterBanks = new List<string>();
			Banks = new List<string>();
			RealChannelSettings = new List<PlatformIntSetting>();
			VirtualChannelSettings = new List<PlatformIntSetting>();
			LoggingSettings = new List<PlatformBoolSetting>();
			LiveUpdateSettings = new List<PlatformBoolSetting>();
			OverlaySettings = new List<PlatformBoolSetting>();
			SampleRateSettings = new List<PlatformIntSetting>();
			SpeakerModeSettings = new List<PlatformIntSetting>();
			BankDirectorySettings = new List<PlatformStringSetting>();
			SetSetting(LoggingSettings, FMODPlatform.PlayInEditor, TriStateBool.Enabled);
			SetSetting(LiveUpdateSettings, FMODPlatform.PlayInEditor, TriStateBool.Enabled);
			SetSetting(OverlaySettings, FMODPlatform.PlayInEditor, TriStateBool.Enabled);
			SetSetting(SampleRateSettings, FMODPlatform.PlayInEditor, 48000);
			SetSetting(RealChannelSettings, FMODPlatform.PlayInEditor, 256);
			SetSetting(VirtualChannelSettings, FMODPlatform.PlayInEditor, 1024);
			SetSetting(LoggingSettings, FMODPlatform.Default, TriStateBool.Disabled);
			SetSetting(LiveUpdateSettings, FMODPlatform.Default, TriStateBool.Disabled);
			SetSetting(OverlaySettings, FMODPlatform.Default, TriStateBool.Disabled);
			SetSetting(RealChannelSettings, FMODPlatform.Default, 32);
			SetSetting(VirtualChannelSettings, FMODPlatform.Default, 128);
			SetSetting(SampleRateSettings, FMODPlatform.Default, 0);
			SetSetting(SpeakerModeSettings, FMODPlatform.Default, 3);
			ImportType = ImportType.StreamingAssets;
			AutomaticEventLoading = true;
			AutomaticSampleLoading = false;
			TargetAssetPath = "";
		}

		private string GetPlatformSpecificPath(string path)
		{
			if (string.IsNullOrEmpty(path))
			{
				return path;
			}
			if (Path.DirectorySeparatorChar == '/')
			{
				return path.Replace('\\', '/');
			}
			return path.Replace('/', '\\');
		}
	}
	[AddComponentMenu("FMOD Studio/FMOD Studio Bank Loader")]
	public class StudioBankLoader : MonoBehaviour
	{
		public LoaderGameEvent LoadEvent;

		public LoaderGameEvent UnloadEvent;

		[BankRef]
		public List<string> Banks;

		public string CollisionTag;

		public bool PreloadSamples;

		private bool isQuitting;

		private void HandleGameEvent(LoaderGameEvent gameEvent)
		{
			if (LoadEvent == gameEvent)
			{
				Load();
			}
			if (UnloadEvent == gameEvent)
			{
				Unload();
			}
		}

		private void Start()
		{
			RuntimeUtils.EnforceLibraryOrder();
			HandleGameEvent(LoaderGameEvent.ObjectStart);
		}

		private void OnApplicationQuit()
		{
			isQuitting = true;
		}

		private void OnDestroy()
		{
			if (!isQuitting)
			{
				HandleGameEvent(LoaderGameEvent.ObjectDestroy);
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			if (string.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
			{
				HandleGameEvent(LoaderGameEvent.TriggerEnter);
			}
		}

		private void OnTriggerExit(Collider other)
		{
			if (string.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
			{
				HandleGameEvent(LoaderGameEvent.TriggerExit);
			}
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (string.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
			{
				HandleGameEvent(LoaderGameEvent.TriggerEnter2D);
			}
		}

		private void OnTriggerExit2D(Collider2D other)
		{
			if (string.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
			{
				HandleGameEvent(LoaderGameEvent.TriggerExit2D);
			}
		}

		public void Load()
		{
			foreach (string bank in Banks)
			{
				try
				{
					RuntimeManager.LoadBank(bank, PreloadSamples);
				}
				catch (BankLoadException exception)
				{
					UnityEngine.Debug.LogException(exception);
				}
			}
			RuntimeManager.WaitForAllLoads();
		}

		public void Unload()
		{
			foreach (string bank in Banks)
			{
				RuntimeManager.UnloadBank(bank);
			}
		}
	}
	[AddComponentMenu("FMOD Studio/FMOD Studio Event Emitter")]
	public class StudioEventEmitter : MonoBehaviour
	{
		[EventRef]
		public string Event = "";

		public EmitterGameEvent PlayEvent;

		public EmitterGameEvent StopEvent;

		public string CollisionTag = "";

		public bool AllowFadeout = true;

		public bool TriggerOnce;

		public bool Preload;

		public ParamRef[] Params = new ParamRef[0];

		public bool OverrideAttenuation;

		public float OverrideMinDistance = -1f;

		public float OverrideMaxDistance = -1f;

		protected EventDescription eventDescription;

		protected FMOD.Studio.EventInstance instance;

		private bool hasTriggered;

		private bool isQuitting;

		public EventDescription EventDescription => eventDescription;

		public FMOD.Studio.EventInstance EventInstance => instance;

		private void Start()
		{
			RuntimeUtils.EnforceLibraryOrder();
			if (Preload)
			{
				Lookup();
				eventDescription.loadSampleData();
				RuntimeManager.StudioSystem.update();
				eventDescription.getSampleLoadingState(out var state);
				while (state == LOADING_STATE.LOADING)
				{
					Thread.Sleep(1);
					eventDescription.getSampleLoadingState(out state);
				}
			}
			HandleGameEvent(EmitterGameEvent.ObjectStart);
		}

		private void OnApplicationQuit()
		{
			isQuitting = true;
		}

		private void OnDestroy()
		{
			if (!isQuitting)
			{
				HandleGameEvent(EmitterGameEvent.ObjectDestroy);
				if (instance.isValid())
				{
					RuntimeManager.DetachInstanceFromGameObject(instance);
				}
				if (Preload)
				{
					eventDescription.unloadSampleData();
				}
			}
		}

		private void OnEnable()
		{
			HandleGameEvent(EmitterGameEvent.ObjectEnable);
		}

		private void OnDisable()
		{
			HandleGameEvent(EmitterGameEvent.ObjectDisable);
		}

		private void OnTriggerEnter(Collider other)
		{
			if (string.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
			{
				HandleGameEvent(EmitterGameEvent.TriggerEnter);
			}
		}

		private void OnTriggerExit(Collider other)
		{
			if (string.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
			{
				HandleGameEvent(EmitterGameEvent.TriggerExit);
			}
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (string.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
			{
				HandleGameEvent(EmitterGameEvent.TriggerEnter2D);
			}
		}

		private void OnTriggerExit2D(Collider2D other)
		{
			if (string.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
			{
				HandleGameEvent(EmitterGameEvent.TriggerExit2D);
			}
		}

		private void OnCollisionEnter()
		{
			HandleGameEvent(EmitterGameEvent.CollisionEnter);
		}

		private void OnCollisionExit()
		{
			HandleGameEvent(EmitterGameEvent.CollisionExit);
		}

		private void OnCollisionEnter2D()
		{
			HandleGameEvent(EmitterGameEvent.CollisionEnter2D);
		}

		private void OnCollisionExit2D()
		{
			HandleGameEvent(EmitterGameEvent.CollisionExit2D);
		}

		private void HandleGameEvent(EmitterGameEvent gameEvent)
		{
			if (PlayEvent == gameEvent)
			{
				Play();
			}
			if (StopEvent == gameEvent)
			{
				Stop();
			}
		}

		private void Lookup()
		{
			eventDescription = RuntimeManager.GetEventDescription(Event);
		}

		public void Play()
		{
			if ((TriggerOnce && hasTriggered) || string.IsNullOrEmpty(Event))
			{
				return;
			}
			if (!eventDescription.isValid())
			{
				Lookup();
			}
			bool oneshot = false;
			if (!Event.StartsWith("snapshot", StringComparison.CurrentCultureIgnoreCase))
			{
				eventDescription.isOneshot(out oneshot);
			}
			eventDescription.is3D(out var is3D);
			if (!instance.isValid())
			{
				instance.clearHandle();
			}
			if (oneshot && instance.isValid())
			{
				instance.release();
				instance.clearHandle();
			}
			if (!instance.isValid())
			{
				eventDescription.createInstance(out instance);
				if (is3D)
				{
					Rigidbody component = GetComponent<Rigidbody>();
					Rigidbody2D component2 = GetComponent<Rigidbody2D>();
					Transform component3 = GetComponent<Transform>();
					if ((bool)component)
					{
						instance.set3DAttributes(RuntimeUtils.To3DAttributes(base.gameObject, component));
						RuntimeManager.AttachInstanceToGameObject(instance, component3, component);
					}
					else
					{
						instance.set3DAttributes(RuntimeUtils.To3DAttributes(base.gameObject, component2));
						RuntimeManager.AttachInstanceToGameObject(instance, component3, component2);
					}
				}
			}
			instance.set3DAttributes(RuntimeUtils.To3DAttributes(base.gameObject));
			ParamRef[] @params = Params;
			foreach (ParamRef paramRef in @params)
			{
				instance.setParameterValue(paramRef.Name, paramRef.Value);
			}
			if (is3D && OverrideAttenuation)
			{
				instance.setProperty(EVENT_PROPERTY.MINIMUM_DISTANCE, OverrideMinDistance);
				instance.setProperty(EVENT_PROPERTY.MAXIMUM_DISTANCE, OverrideMaxDistance);
			}
			instance.start();
			hasTriggered = true;
		}

		public void Stop()
		{
			if (instance.isValid())
			{
				instance.stop((!AllowFadeout) ? FMOD.Studio.STOP_MODE.IMMEDIATE : FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
				instance.release();
				instance.clearHandle();
			}
		}

		public void SetParameter(string name, float value)
		{
			if (instance.isValid())
			{
				instance.setParameterValue(name, value);
			}
		}

		public bool IsPlaying()
		{
			if (instance.isValid() && instance.isValid())
			{
				instance.getPlaybackState(out var state);
				return state != PLAYBACK_STATE.STOPPED;
			}
			return false;
		}
	}
	[AddComponentMenu("FMOD Studio/FMOD Studio Listener")]
	public class StudioListener : MonoBehaviour
	{
		private Rigidbody rigidBody;

		private Rigidbody2D rigidBody2D;

		public int ListenerNumber;

		private void OnEnable()
		{
			RuntimeUtils.EnforceLibraryOrder();
			rigidBody = base.gameObject.GetComponent<Rigidbody>();
			rigidBody2D = base.gameObject.GetComponent<Rigidbody2D>();
			RuntimeManager.HasListener[ListenerNumber] = true;
			SetListenerLocation();
		}

		private void OnDisable()
		{
			RuntimeManager.HasListener[ListenerNumber] = false;
		}

		private void Update()
		{
			SetListenerLocation();
		}

		private void SetListenerLocation()
		{
			if ((bool)rigidBody)
			{
				RuntimeManager.SetListenerLocation(ListenerNumber, base.gameObject, rigidBody);
			}
			else if ((bool)rigidBody2D)
			{
				RuntimeManager.SetListenerLocation(ListenerNumber, base.gameObject, rigidBody2D);
			}
			else
			{
				RuntimeManager.SetListenerLocation(ListenerNumber, base.transform);
			}
		}
	}
	[Serializable]
	public class EmitterRef
	{
		public StudioEventEmitter Target;

		public ParamRef[] Params;
	}
	[AddComponentMenu("FMOD Studio/FMOD Studio Parameter Trigger")]
	public class StudioParameterTrigger : MonoBehaviour
	{
		public EmitterRef[] Emitters;

		public EmitterGameEvent TriggerEvent;

		public string CollisionTag;

		private void Start()
		{
			HandleGameEvent(EmitterGameEvent.ObjectStart);
		}

		private void OnDestroy()
		{
			HandleGameEvent(EmitterGameEvent.ObjectDestroy);
		}

		private void OnEnable()
		{
			HandleGameEvent(EmitterGameEvent.ObjectEnable);
		}

		private void OnDisable()
		{
			HandleGameEvent(EmitterGameEvent.ObjectDisable);
		}

		private void OnTriggerEnter(Collider other)
		{
			if (string.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
			{
				HandleGameEvent(EmitterGameEvent.TriggerEnter);
			}
		}

		private void OnTriggerExit(Collider other)
		{
			if (string.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
			{
				HandleGameEvent(EmitterGameEvent.TriggerExit);
			}
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (string.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
			{
				HandleGameEvent(EmitterGameEvent.TriggerEnter2D);
			}
		}

		private void OnTriggerExit2D(Collider2D other)
		{
			if (string.IsNullOrEmpty(CollisionTag) || other.CompareTag(CollisionTag))
			{
				HandleGameEvent(EmitterGameEvent.TriggerExit2D);
			}
		}

		private void OnCollisionEnter()
		{
			HandleGameEvent(EmitterGameEvent.CollisionEnter);
		}

		private void OnCollisionExit()
		{
			HandleGameEvent(EmitterGameEvent.CollisionExit);
		}

		private void OnCollisionEnter2D()
		{
			HandleGameEvent(EmitterGameEvent.CollisionEnter2D);
		}

		private void OnCollisionExit2D()
		{
			HandleGameEvent(EmitterGameEvent.CollisionExit2D);
		}

		private void HandleGameEvent(EmitterGameEvent gameEvent)
		{
			if (TriggerEvent == gameEvent)
			{
				TriggerParameters();
			}
		}

		public void TriggerParameters()
		{
			for (int i = 0; i < Emitters.Length; i++)
			{
				EmitterRef emitterRef = Emitters[i];
				if (emitterRef.Target != null)
				{
					for (int j = 0; j < Emitters[i].Params.Length; j++)
					{
						emitterRef.Target.SetParameter(Emitters[i].Params[j].Name, Emitters[i].Params[j].Value);
					}
				}
			}
		}
	}
}
