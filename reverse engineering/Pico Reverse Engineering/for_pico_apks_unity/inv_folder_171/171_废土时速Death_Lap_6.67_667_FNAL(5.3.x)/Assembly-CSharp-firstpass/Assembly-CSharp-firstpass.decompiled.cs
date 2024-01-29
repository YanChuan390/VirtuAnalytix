using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Xml.Serialization;
using BezierSplines;
using MEC;
using MagnetRoads;
using RuntimeGizmo;
using TBUnityLib.Generic;
using TBUnityLib.MeshTools;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
[assembly: AssemblyVersion("0.0.0.0")]
[module: UnverifiableCode]
public class CameraOrbit : MonoBehaviour
{
	public Transform orbitTarget;

	protected void Update()
	{
		base.transform.LookAt(orbitTarget);
		base.transform.Translate(Vector3.right / 2f * Time.deltaTime);
	}
}
public class DemoLogic : MonoBehaviour
{
	public List<Camera> cameras;

	public List<string> cameraText;

	public Text textToEdit;

	public Button nextButton;

	private int camIndex;

	protected void Start()
	{
		nextButton.GetComponent<Button>().onClick.AddListener(MoveToNextCamera);
		UpdateCameras();
	}

	private void MoveToNextCamera()
	{
		if (camIndex < cameras.Count - 1)
		{
			camIndex++;
		}
		else
		{
			camIndex = 0;
		}
		UpdateCameras();
	}

	private void UpdateCameras()
	{
		for (int i = 0; i < cameras.Count; i++)
		{
			cameras[camIndex].enabled = true;
			textToEdit.text = cameraText[camIndex];
			if (camIndex != i && cameras[i].enabled)
			{
				cameras[i].enabled = false;
			}
		}
	}
}
public class DemoRacer : MonoBehaviour
{
	public MagnetRoad roadToFollow;

	public int laneToFollow;

	public float speed;

	private int targetPoint;

	private Vector3[] path;

	protected void Start()
	{
		path = roadToFollow.GetLaneWaypoints(laneToFollow);
		base.transform.position = path[path.Length - 1];
		targetPoint = 0;
	}

	protected void Update()
	{
		base.transform.LookAt(path[targetPoint]);
		if (Vector3.Distance(path[targetPoint], base.transform.position) < 0.25f)
		{
			targetPoint += 2;
			if (targetPoint > path.Length - 1)
			{
				targetPoint = 0;
			}
		}
		base.transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}
public static class MECExtensionMethods
{
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, float timeToDelay)
	{
		yield return Timing.WaitForSeconds(timeToDelay);
		while (coroutine.MoveNext())
		{
			yield return coroutine.Current;
		}
	}

	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		while (!condition())
		{
			yield return 0f;
		}
		while (coroutine.MoveNext())
		{
			yield return coroutine.Current;
		}
	}

	public static IEnumerator<float> Delay<T>(this IEnumerator<float> coroutine, T data, Func<T, bool> condition)
	{
		while (!condition(data))
		{
			yield return 0f;
		}
		while (coroutine.MoveNext())
		{
			yield return coroutine.Current;
		}
	}

	public static IEnumerator<float> DelayFrames(this IEnumerator<float> coroutine, int framesToDelay)
	{
		while (framesToDelay-- > 0)
		{
			yield return 0f;
		}
		while (coroutine.MoveNext())
		{
			yield return coroutine.Current;
		}
	}

	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		while (Timing.MainThread != Thread.CurrentThread || ((bool)gameObject && gameObject.activeInHierarchy && coroutine.MoveNext()))
		{
			yield return coroutine.Current;
		}
	}

	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		while (Timing.MainThread != Thread.CurrentThread || ((bool)gameObject1 && gameObject1.activeInHierarchy && (bool)gameObject2 && gameObject2.activeInHierarchy && coroutine.MoveNext()))
		{
			yield return coroutine.Current;
		}
	}

	public static IEnumerator<float> CancelWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		GameObject myGO = script.gameObject;
		while (Timing.MainThread != Thread.CurrentThread || ((bool)myGO && myGO.activeInHierarchy && script != null && coroutine.MoveNext()))
		{
			yield return coroutine.Current;
		}
	}

	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		if (condition != null)
		{
			while (Timing.MainThread != Thread.CurrentThread || (condition() && coroutine.MoveNext()))
			{
				yield return coroutine.Current;
			}
		}
	}

	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		while (Timing.MainThread == Thread.CurrentThread && (bool)gameObject)
		{
			if (gameObject.activeInHierarchy)
			{
				if (!coroutine.MoveNext())
				{
					break;
				}
				yield return coroutine.Current;
			}
			else
			{
				yield return float.NegativeInfinity;
			}
		}
	}

	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		while (Timing.MainThread == Thread.CurrentThread && (bool)gameObject1 && (bool)gameObject2)
		{
			if (gameObject1.activeInHierarchy && gameObject2.activeInHierarchy)
			{
				if (!coroutine.MoveNext())
				{
					break;
				}
				yield return coroutine.Current;
			}
			else
			{
				yield return float.NegativeInfinity;
			}
		}
	}

	public static IEnumerator<float> PauseWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		GameObject myGO = script.gameObject;
		while (Timing.MainThread == Thread.CurrentThread && (bool)myGO && myGO.GetComponent<T>() != null)
		{
			if (myGO.activeInHierarchy && script.enabled)
			{
				if (!coroutine.MoveNext())
				{
					break;
				}
				yield return coroutine.Current;
			}
			else
			{
				yield return float.NegativeInfinity;
			}
		}
	}

	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		if (condition != null)
		{
			while (Timing.MainThread != Thread.CurrentThread || (condition() && coroutine.MoveNext()))
			{
				yield return coroutine.Current;
			}
		}
	}

	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, IEnumerator<float> nextCoroutine)
	{
		while (coroutine.MoveNext())
		{
			yield return coroutine.Current;
		}
		if (nextCoroutine != null)
		{
			while (nextCoroutine.MoveNext())
			{
				yield return nextCoroutine.Current;
			}
		}
	}

	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, Action onDone)
	{
		while (coroutine.MoveNext())
		{
			yield return coroutine.Current;
		}
		onDone?.Invoke();
	}

	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, IEnumerator<float> lastCoroutine)
	{
		if (lastCoroutine != null)
		{
			while (lastCoroutine.MoveNext())
			{
				yield return lastCoroutine.Current;
			}
		}
		while (coroutine.MoveNext())
		{
			yield return coroutine.Current;
		}
	}

	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, Action onStart)
	{
		onStart?.Invoke();
		while (coroutine.MoveNext())
		{
			yield return coroutine.Current;
		}
	}

	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB)
	{
		return coroutineA.Superimpose(coroutineB, Timing.Instance);
	}

	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB, Timing instance)
	{
		while (coroutineA != null || coroutineB != null)
		{
			if (coroutineA != null && !(instance.localTime < coroutineA.Current) && !coroutineA.MoveNext())
			{
				coroutineA = null;
			}
			if (coroutineB != null && !(instance.localTime < coroutineB.Current) && !coroutineB.MoveNext())
			{
				coroutineB = null;
			}
			if ((coroutineA != null && float.IsNaN(coroutineA.Current)) || (coroutineB != null && float.IsNaN(coroutineB.Current)))
			{
				yield return float.NaN;
			}
			else if (coroutineA != null && coroutineB != null)
			{
				yield return (coroutineA.Current < coroutineB.Current) ? coroutineA.Current : coroutineB.Current;
			}
			else if (coroutineA == null && coroutineB != null)
			{
				yield return coroutineB.Current;
			}
			else if (coroutineA != null)
			{
				yield return coroutineA.Current;
			}
		}
	}

	public static IEnumerator<float> Hijack(this IEnumerator<float> coroutine, Func<float, float> newReturn)
	{
		if (newReturn != null)
		{
			while (coroutine.MoveNext())
			{
				yield return newReturn(coroutine.Current);
			}
		}
	}
}
namespace MEC
{
	public class Timing : MonoBehaviour
	{
		private struct ProcessIndex : IEquatable<ProcessIndex>
		{
			public Segment seg;

			public int i;

			public bool Equals(ProcessIndex other)
			{
				if (seg == other.seg)
				{
					return i == other.i;
				}
				return false;
			}

			public override bool Equals(object other)
			{
				if (other is ProcessIndex)
				{
					return Equals((ProcessIndex)other);
				}
				return false;
			}

			public static bool operator ==(ProcessIndex a, ProcessIndex b)
			{
				if (a.seg == b.seg)
				{
					return a.i == b.i;
				}
				return false;
			}

			public static bool operator !=(ProcessIndex a, ProcessIndex b)
			{
				if (a.seg == b.seg)
				{
					return a.i != b.i;
				}
				return true;
			}

			public override int GetHashCode()
			{
				return (int)(seg - 4) * 306783378 + i;
			}
		}

		[Tooltip("How quickly the SlowUpdate segment ticks.")]
		public float TimeBetweenSlowUpdateCalls = 1f / 7f;

		[Tooltip("How much data should be sent to the profiler window when it's open.")]
		public DebugInfoType ProfilerDebugAmount;

		[Tooltip("When using manual timeframe, should it run automatically after the update loop or only when TriggerManualTimframeUpdate is called.")]
		public bool AutoTriggerManualTimeframe = true;

		[Tooltip("A count of the number of Update coroutines that are currently running.")]
		[Space(12f)]
		public int UpdateCoroutines;

		[Tooltip("A count of the number of FixedUpdate coroutines that are currently running.")]
		public int FixedUpdateCoroutines;

		[Tooltip("A count of the number of LateUpdate coroutines that are currently running.")]
		public int LateUpdateCoroutines;

		[Tooltip("A count of the number of SlowUpdate coroutines that are currently running.")]
		public int SlowUpdateCoroutines;

		[Tooltip("A count of the number of RealtimeUpdate coroutines that are currently running.")]
		public int RealtimeUpdateCoroutines;

		[Tooltip("A count of the number of EditorUpdate coroutines that are currently running.")]
		public int EditorUpdateCoroutines;

		[Tooltip("A count of the number of EditorSlowUpdate coroutines that are currently running.")]
		public int EditorSlowUpdateCoroutines;

		[Tooltip("A count of the number of EndOfFrame coroutines that are currently running.")]
		public int EndOfFrameCoroutines;

		[Tooltip("A count of the number of ManualTimeframe coroutines that are currently running.")]
		public int ManualTimeframeCoroutines;

		[NonSerialized]
		public float localTime;

		[NonSerialized]
		public float deltaTime;

		public Func<float, float> SetManualTimeframeTime;

		public static Func<IEnumerator<float>, CoroutineHandle, IEnumerator<float>> ReplacementFunction;

		public const float WaitForOneFrame = float.NegativeInfinity;

		private static object _tmpRef;

		private static int _tmpInt;

		private static bool _tmpBool;

		private static Segment _tmpSegment;

		private static CoroutineHandle _tmpHandle;

		private int _currentUpdateFrame;

		private int _currentLateUpdateFrame;

		private int _currentSlowUpdateFrame;

		private int _currentRealtimeUpdateFrame;

		private int _currentEndOfFrameFrame;

		private int _nextUpdateProcessSlot;

		private int _nextLateUpdateProcessSlot;

		private int _nextFixedUpdateProcessSlot;

		private int _nextSlowUpdateProcessSlot;

		private int _nextRealtimeUpdateProcessSlot;

		private int _nextEditorUpdateProcessSlot;

		private int _nextEditorSlowUpdateProcessSlot;

		private int _nextEndOfFrameProcessSlot;

		private int _nextManualTimeframeProcessSlot;

		private int _lastUpdateProcessSlot;

		private int _lastLateUpdateProcessSlot;

		private int _lastFixedUpdateProcessSlot;

		private int _lastSlowUpdateProcessSlot;

		private int _lastRealtimeUpdateProcessSlot;

		private int _lastEndOfFrameProcessSlot;

		private int _lastManualTimeframeProcessSlot;

		private float _lastUpdateTime;

		private float _lastLateUpdateTime;

		private float _lastFixedUpdateTime;

		private float _lastSlowUpdateTime;

		private float _lastRealtimeUpdateTime;

		private float _lastEndOfFrameTime;

		private float _lastManualTimeframeTime;

		private float _lastSlowUpdateDeltaTime;

		private float _lastEditorUpdateDeltaTime;

		private float _lastEditorSlowUpdateDeltaTime;

		private float _lastManualTimeframeDeltaTime;

		private ushort _framesSinceUpdate;

		private ushort _expansions = 1;

		[SerializeField]
		[HideInInspector]
		private byte _instanceID;

		private bool _EOFPumpRan;

		private static readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> Links = new Dictionary<CoroutineHandle, HashSet<CoroutineHandle>>();

		private static readonly WaitForEndOfFrame EofWaitObject = new WaitForEndOfFrame();

		private readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> _waitingTriggers = new Dictionary<CoroutineHandle, HashSet<CoroutineHandle>>();

		private readonly HashSet<CoroutineHandle> _allWaiting = new HashSet<CoroutineHandle>();

		private readonly Dictionary<CoroutineHandle, ProcessIndex> _handleToIndex = new Dictionary<CoroutineHandle, ProcessIndex>();

		private readonly Dictionary<ProcessIndex, CoroutineHandle> _indexToHandle = new Dictionary<ProcessIndex, CoroutineHandle>();

		private readonly Dictionary<CoroutineHandle, string> _processTags = new Dictionary<CoroutineHandle, string>();

		private readonly Dictionary<string, HashSet<CoroutineHandle>> _taggedProcesses = new Dictionary<string, HashSet<CoroutineHandle>>();

		private readonly Dictionary<CoroutineHandle, int> _processLayers = new Dictionary<CoroutineHandle, int>();

		private readonly Dictionary<int, HashSet<CoroutineHandle>> _layeredProcesses = new Dictionary<int, HashSet<CoroutineHandle>>();

		private IEnumerator<float>[] UpdateProcesses = new IEnumerator<float>[256];

		private IEnumerator<float>[] LateUpdateProcesses = new IEnumerator<float>[8];

		private IEnumerator<float>[] FixedUpdateProcesses = new IEnumerator<float>[64];

		private IEnumerator<float>[] SlowUpdateProcesses = new IEnumerator<float>[64];

		private IEnumerator<float>[] RealtimeUpdateProcesses = new IEnumerator<float>[8];

		private IEnumerator<float>[] EditorUpdateProcesses = new IEnumerator<float>[8];

		private IEnumerator<float>[] EditorSlowUpdateProcesses = new IEnumerator<float>[8];

		private IEnumerator<float>[] EndOfFrameProcesses = new IEnumerator<float>[8];

		private IEnumerator<float>[] ManualTimeframeProcesses = new IEnumerator<float>[8];

		private bool[] UpdatePaused = new bool[256];

		private bool[] LateUpdatePaused = new bool[8];

		private bool[] FixedUpdatePaused = new bool[64];

		private bool[] SlowUpdatePaused = new bool[64];

		private bool[] RealtimeUpdatePaused = new bool[8];

		private bool[] EditorUpdatePaused = new bool[8];

		private bool[] EditorSlowUpdatePaused = new bool[8];

		private bool[] EndOfFramePaused = new bool[8];

		private bool[] ManualTimeframePaused = new bool[8];

		private bool[] UpdateHeld = new bool[256];

		private bool[] LateUpdateHeld = new bool[8];

		private bool[] FixedUpdateHeld = new bool[64];

		private bool[] SlowUpdateHeld = new bool[64];

		private bool[] RealtimeUpdateHeld = new bool[8];

		private bool[] EditorUpdateHeld = new bool[8];

		private bool[] EditorSlowUpdateHeld = new bool[8];

		private bool[] EndOfFrameHeld = new bool[8];

		private bool[] ManualTimeframeHeld = new bool[8];

		private CoroutineHandle _eofWatcherHandle;

		private const ushort FramesUntilMaintenance = 64;

		private const int ProcessArrayChunkSize = 64;

		private const int InitialBufferSizeLarge = 256;

		private const int InitialBufferSizeMedium = 64;

		private const int InitialBufferSizeSmall = 8;

		private static Timing[] ActiveInstances = new Timing[16];

		private static Timing _instance;

		public static float LocalTime => Instance.localTime;

		public static float DeltaTime => Instance.deltaTime;

		public static Thread MainThread { get; private set; }

		public static CoroutineHandle CurrentCoroutine => Instance.currentCoroutine;

		public CoroutineHandle currentCoroutine { get; private set; }

		public static Timing Instance
		{
			get
			{
				if (_instance == null || !_instance.gameObject)
				{
					GameObject gameObject = GameObject.Find("Timing Controller");
					if (gameObject == null)
					{
						gameObject = new GameObject
						{
							name = "Timing Controller"
						};
						UnityEngine.Object.DontDestroyOnLoad(gameObject);
					}
					_instance = gameObject.GetComponent<Timing>() ?? gameObject.AddComponent<Timing>();
					_instance.InitializeInstanceID();
				}
				return _instance;
			}
			set
			{
				_instance = value;
			}
		}

		public static event Action OnPreExecute;

		private void OnDestroy()
		{
			if (_instance == this)
			{
				_instance = null;
			}
		}

		private void OnEnable()
		{
			if (MainThread == null)
			{
				MainThread = Thread.CurrentThread;
			}
			if (_nextEditorUpdateProcessSlot > 0 || _nextEditorSlowUpdateProcessSlot > 0)
			{
				OnEditorStart();
			}
			InitializeInstanceID();
			if (_nextEndOfFrameProcessSlot > 0)
			{
				RunCoroutineSingletonOnInstance(_EOFPumpWatcher(), "MEC_EOFPumpWatcher", SingletonBehavior.Abort);
			}
		}

		private void OnDisable()
		{
			if (_instanceID < ActiveInstances.Length)
			{
				ActiveInstances[_instanceID] = null;
			}
		}

		private void InitializeInstanceID()
		{
			if (!(ActiveInstances[_instanceID] == null))
			{
				return;
			}
			if (_instanceID == 0)
			{
				_instanceID++;
			}
			while (_instanceID <= 16)
			{
				if (_instanceID == 16)
				{
					UnityEngine.Object.Destroy(base.gameObject);
					throw new OverflowException("You are only allowed 15 different contexts for MEC to run inside at one time.");
				}
				if (ActiveInstances[_instanceID] == null)
				{
					ActiveInstances[_instanceID] = this;
					break;
				}
				_instanceID++;
			}
		}

		private void Update()
		{
			if (Timing.OnPreExecute != null)
			{
				Timing.OnPreExecute();
			}
			if (_lastSlowUpdateTime + TimeBetweenSlowUpdateCalls < Time.realtimeSinceStartup && _nextSlowUpdateProcessSlot > 0)
			{
				ProcessIndex processIndex = default(ProcessIndex);
				processIndex.seg = Segment.SlowUpdate;
				ProcessIndex key = processIndex;
				if (UpdateTimeValues(key.seg))
				{
					_lastSlowUpdateProcessSlot = _nextSlowUpdateProcessSlot;
				}
				key.i = 0;
				while (key.i < _lastSlowUpdateProcessSlot)
				{
					try
					{
						if (!SlowUpdatePaused[key.i] && !SlowUpdateHeld[key.i] && SlowUpdateProcesses[key.i] != null && !(localTime < SlowUpdateProcesses[key.i].Current))
						{
							currentCoroutine = _indexToHandle[key];
							if (ProfilerDebugAmount != 0)
							{
								_indexToHandle.ContainsKey(key);
							}
							if (!SlowUpdateProcesses[key.i].MoveNext())
							{
								if (_indexToHandle.ContainsKey(key))
								{
									KillCoroutinesOnInstance(_indexToHandle[key]);
								}
							}
							else if (SlowUpdateProcesses[key.i] != null && float.IsNaN(SlowUpdateProcesses[key.i].Current))
							{
								if (ReplacementFunction != null)
								{
									SlowUpdateProcesses[key.i] = ReplacementFunction(SlowUpdateProcesses[key.i], _indexToHandle[key]);
									ReplacementFunction = null;
								}
								key.i--;
							}
							_ = ProfilerDebugAmount;
						}
					}
					catch (Exception ex)
					{
						Debug.LogException(ex);
						if (ex is MissingReferenceException)
						{
							Debug.LogError("This exception can probably be fixed by adding \"CancelWith(gameObject)\" when you run the coroutine.\nExample: Timing.RunCoroutine(_foo().CancelWith(gameObject), Segment.SlowUpdate);");
						}
					}
					key.i++;
				}
			}
			if (_nextRealtimeUpdateProcessSlot > 0)
			{
				ProcessIndex processIndex = default(ProcessIndex);
				processIndex.seg = Segment.RealtimeUpdate;
				ProcessIndex key2 = processIndex;
				if (UpdateTimeValues(key2.seg))
				{
					_lastRealtimeUpdateProcessSlot = _nextRealtimeUpdateProcessSlot;
				}
				key2.i = 0;
				while (key2.i < _lastRealtimeUpdateProcessSlot)
				{
					try
					{
						if (!RealtimeUpdatePaused[key2.i] && !RealtimeUpdateHeld[key2.i] && RealtimeUpdateProcesses[key2.i] != null && !(localTime < RealtimeUpdateProcesses[key2.i].Current))
						{
							currentCoroutine = _indexToHandle[key2];
							if (ProfilerDebugAmount != 0)
							{
								_indexToHandle.ContainsKey(key2);
							}
							if (!RealtimeUpdateProcesses[key2.i].MoveNext())
							{
								if (_indexToHandle.ContainsKey(key2))
								{
									KillCoroutinesOnInstance(_indexToHandle[key2]);
								}
							}
							else if (RealtimeUpdateProcesses[key2.i] != null && float.IsNaN(RealtimeUpdateProcesses[key2.i].Current))
							{
								if (ReplacementFunction != null)
								{
									RealtimeUpdateProcesses[key2.i] = ReplacementFunction(RealtimeUpdateProcesses[key2.i], _indexToHandle[key2]);
									ReplacementFunction = null;
								}
								key2.i--;
							}
							_ = ProfilerDebugAmount;
						}
					}
					catch (Exception ex2)
					{
						Debug.LogException(ex2);
						if (ex2 is MissingReferenceException)
						{
							Debug.LogError("This exception can probably be fixed by adding \"CancelWith(gameObject)\" when you run the coroutine.\nExample: Timing.RunCoroutine(_foo().CancelWith(gameObject), Segment.RealtimeUpdate);");
						}
					}
					key2.i++;
				}
			}
			if (_nextUpdateProcessSlot > 0)
			{
				ProcessIndex processIndex = default(ProcessIndex);
				processIndex.seg = Segment.Update;
				ProcessIndex key3 = processIndex;
				if (UpdateTimeValues(key3.seg))
				{
					_lastUpdateProcessSlot = _nextUpdateProcessSlot;
				}
				key3.i = 0;
				while (key3.i < _lastUpdateProcessSlot)
				{
					try
					{
						if (!UpdatePaused[key3.i] && !UpdateHeld[key3.i] && UpdateProcesses[key3.i] != null && !(localTime < UpdateProcesses[key3.i].Current))
						{
							currentCoroutine = _indexToHandle[key3];
							if (ProfilerDebugAmount != 0)
							{
								_indexToHandle.ContainsKey(key3);
							}
							if (!UpdateProcesses[key3.i].MoveNext())
							{
								if (_indexToHandle.ContainsKey(key3))
								{
									KillCoroutinesOnInstance(_indexToHandle[key3]);
								}
							}
							else if (UpdateProcesses[key3.i] != null && float.IsNaN(UpdateProcesses[key3.i].Current))
							{
								if (ReplacementFunction != null)
								{
									UpdateProcesses[key3.i] = ReplacementFunction(UpdateProcesses[key3.i], _indexToHandle[key3]);
									ReplacementFunction = null;
								}
								key3.i--;
							}
							_ = ProfilerDebugAmount;
						}
					}
					catch (Exception ex3)
					{
						Debug.LogException(ex3);
						if (ex3 is MissingReferenceException)
						{
							Debug.LogError("This exception can probably be fixed by adding \"CancelWith(gameObject)\" when you run the coroutine.\nExample: Timing.RunCoroutine(_foo().CancelWith(gameObject), Segment.Update);");
						}
					}
					key3.i++;
				}
			}
			if (AutoTriggerManualTimeframe)
			{
				TriggerManualTimeframeUpdate();
			}
			else if (++_framesSinceUpdate > 64)
			{
				_framesSinceUpdate = 0;
				_ = ProfilerDebugAmount;
				RemoveUnused();
				_ = ProfilerDebugAmount;
			}
			currentCoroutine = default(CoroutineHandle);
		}

		private void FixedUpdate()
		{
			if (Timing.OnPreExecute != null)
			{
				Timing.OnPreExecute();
			}
			if (_nextFixedUpdateProcessSlot <= 0)
			{
				return;
			}
			ProcessIndex processIndex = default(ProcessIndex);
			processIndex.seg = Segment.FixedUpdate;
			ProcessIndex key = processIndex;
			if (UpdateTimeValues(key.seg))
			{
				_lastFixedUpdateProcessSlot = _nextFixedUpdateProcessSlot;
			}
			key.i = 0;
			while (key.i < _lastFixedUpdateProcessSlot)
			{
				try
				{
					if (!FixedUpdatePaused[key.i] && !FixedUpdateHeld[key.i] && FixedUpdateProcesses[key.i] != null && !(localTime < FixedUpdateProcesses[key.i].Current))
					{
						currentCoroutine = _indexToHandle[key];
						if (ProfilerDebugAmount != 0)
						{
							_indexToHandle.ContainsKey(key);
						}
						if (!FixedUpdateProcesses[key.i].MoveNext())
						{
							if (_indexToHandle.ContainsKey(key))
							{
								KillCoroutinesOnInstance(_indexToHandle[key]);
							}
						}
						else if (FixedUpdateProcesses[key.i] != null && float.IsNaN(FixedUpdateProcesses[key.i].Current))
						{
							if (ReplacementFunction != null)
							{
								FixedUpdateProcesses[key.i] = ReplacementFunction(FixedUpdateProcesses[key.i], _indexToHandle[key]);
								ReplacementFunction = null;
							}
							key.i--;
						}
						_ = ProfilerDebugAmount;
					}
				}
				catch (Exception ex)
				{
					Debug.LogException(ex);
					if (ex is MissingReferenceException)
					{
						Debug.LogError("This exception can probably be fixed by adding \"CancelWith(gameObject)\" when you run the coroutine.\nExample: Timing.RunCoroutine(_foo().CancelWith(gameObject), Segment.FixedUpdate);");
					}
				}
				key.i++;
			}
			currentCoroutine = default(CoroutineHandle);
		}

		private void LateUpdate()
		{
			if (Timing.OnPreExecute != null)
			{
				Timing.OnPreExecute();
			}
			if (_nextLateUpdateProcessSlot <= 0)
			{
				return;
			}
			ProcessIndex processIndex = default(ProcessIndex);
			processIndex.seg = Segment.LateUpdate;
			ProcessIndex key = processIndex;
			if (UpdateTimeValues(key.seg))
			{
				_lastLateUpdateProcessSlot = _nextLateUpdateProcessSlot;
			}
			key.i = 0;
			while (key.i < _lastLateUpdateProcessSlot)
			{
				try
				{
					if (!LateUpdatePaused[key.i] && !LateUpdateHeld[key.i] && LateUpdateProcesses[key.i] != null && !(localTime < LateUpdateProcesses[key.i].Current))
					{
						currentCoroutine = _indexToHandle[key];
						if (ProfilerDebugAmount != 0)
						{
							_indexToHandle.ContainsKey(key);
						}
						if (!LateUpdateProcesses[key.i].MoveNext())
						{
							if (_indexToHandle.ContainsKey(key))
							{
								KillCoroutinesOnInstance(_indexToHandle[key]);
							}
						}
						else if (LateUpdateProcesses[key.i] != null && float.IsNaN(LateUpdateProcesses[key.i].Current))
						{
							if (ReplacementFunction != null)
							{
								LateUpdateProcesses[key.i] = ReplacementFunction(LateUpdateProcesses[key.i], _indexToHandle[key]);
								ReplacementFunction = null;
							}
							key.i--;
						}
						_ = ProfilerDebugAmount;
					}
				}
				catch (Exception ex)
				{
					Debug.LogException(ex);
					if (ex is MissingReferenceException)
					{
						Debug.LogError("This exception can probably be fixed by adding \"CancelWith(gameObject)\" when you run the coroutine.\nExample: Timing.RunCoroutine(_foo().CancelWith(gameObject), Segment.LateUpdate);");
					}
				}
				key.i++;
			}
			currentCoroutine = default(CoroutineHandle);
		}

		public void TriggerManualTimeframeUpdate()
		{
			if (Timing.OnPreExecute != null)
			{
				Timing.OnPreExecute();
			}
			if (_nextManualTimeframeProcessSlot > 0)
			{
				ProcessIndex processIndex = default(ProcessIndex);
				processIndex.seg = Segment.ManualTimeframe;
				ProcessIndex key = processIndex;
				if (UpdateTimeValues(key.seg))
				{
					_lastManualTimeframeProcessSlot = _nextManualTimeframeProcessSlot;
				}
				key.i = 0;
				while (key.i < _lastManualTimeframeProcessSlot)
				{
					try
					{
						if (!ManualTimeframePaused[key.i] && !ManualTimeframeHeld[key.i] && ManualTimeframeProcesses[key.i] != null && !(localTime < ManualTimeframeProcesses[key.i].Current))
						{
							currentCoroutine = _indexToHandle[key];
							if (ProfilerDebugAmount != 0)
							{
								_indexToHandle.ContainsKey(key);
							}
							if (!ManualTimeframeProcesses[key.i].MoveNext())
							{
								if (_indexToHandle.ContainsKey(key))
								{
									KillCoroutinesOnInstance(_indexToHandle[key]);
								}
							}
							else if (ManualTimeframeProcesses[key.i] != null && float.IsNaN(ManualTimeframeProcesses[key.i].Current))
							{
								if (ReplacementFunction != null)
								{
									ManualTimeframeProcesses[key.i] = ReplacementFunction(ManualTimeframeProcesses[key.i], _indexToHandle[key]);
									ReplacementFunction = null;
								}
								key.i--;
							}
							_ = ProfilerDebugAmount;
						}
					}
					catch (Exception ex)
					{
						Debug.LogException(ex);
						if (ex is MissingReferenceException)
						{
							Debug.LogError("This exception can probably be fixed by adding \"CancelWith(gameObject)\" when you run the coroutine.\nExample: Timing.RunCoroutine(_foo().CancelWith(gameObject), Segment.ManualTimeframe);");
						}
					}
					key.i++;
				}
			}
			if (++_framesSinceUpdate > 64)
			{
				_framesSinceUpdate = 0;
				_ = ProfilerDebugAmount;
				RemoveUnused();
				_ = ProfilerDebugAmount;
			}
			currentCoroutine = default(CoroutineHandle);
		}

		private bool OnEditorStart()
		{
			return false;
		}

		private IEnumerator<float> _EOFPumpWatcher()
		{
			while (_nextEndOfFrameProcessSlot > 0)
			{
				if (!_EOFPumpRan)
				{
					base.StartCoroutine(_EOFPump());
				}
				_EOFPumpRan = false;
				yield return float.NegativeInfinity;
			}
			_EOFPumpRan = false;
		}

		private IEnumerator _EOFPump()
		{
			while (_nextEndOfFrameProcessSlot > 0)
			{
				yield return EofWaitObject;
				if (Timing.OnPreExecute != null)
				{
					Timing.OnPreExecute();
				}
				ProcessIndex processIndex = default(ProcessIndex);
				processIndex.seg = Segment.EndOfFrame;
				ProcessIndex key = processIndex;
				_EOFPumpRan = true;
				if (UpdateTimeValues(key.seg))
				{
					_lastEndOfFrameProcessSlot = _nextEndOfFrameProcessSlot;
				}
				key.i = 0;
				while (key.i < _lastEndOfFrameProcessSlot)
				{
					try
					{
						if (!EndOfFramePaused[key.i] && !EndOfFrameHeld[key.i] && EndOfFrameProcesses[key.i] != null && !(localTime < EndOfFrameProcesses[key.i].Current))
						{
							currentCoroutine = _indexToHandle[key];
							if (ProfilerDebugAmount != 0)
							{
								_indexToHandle.ContainsKey(key);
							}
							if (!EndOfFrameProcesses[key.i].MoveNext())
							{
								if (_indexToHandle.ContainsKey(key))
								{
									KillCoroutinesOnInstance(_indexToHandle[key]);
								}
							}
							else if (EndOfFrameProcesses[key.i] != null && float.IsNaN(EndOfFrameProcesses[key.i].Current))
							{
								if (ReplacementFunction != null)
								{
									EndOfFrameProcesses[key.i] = ReplacementFunction(EndOfFrameProcesses[key.i], _indexToHandle[key]);
									ReplacementFunction = null;
								}
								key.i--;
							}
							_ = ProfilerDebugAmount;
						}
					}
					catch (Exception ex)
					{
						Debug.LogException(ex);
						if (ex is MissingReferenceException)
						{
							Debug.LogError("This exception can probably be fixed by adding \"CancelWith(gameObject)\" when you run the coroutine.\nExample: Timing.RunCoroutine(_foo().CancelWith(gameObject), Segment.EndOfFrame);");
						}
					}
					key.i++;
				}
			}
			currentCoroutine = default(CoroutineHandle);
		}

		private void RemoveUnused()
		{
			Dictionary<CoroutineHandle, HashSet<CoroutineHandle>>.Enumerator enumerator = _waitingTriggers.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Value.Count == 0)
				{
					_waitingTriggers.Remove(enumerator.Current.Key);
					enumerator = _waitingTriggers.GetEnumerator();
				}
				else if (_handleToIndex.ContainsKey(enumerator.Current.Key) && CoindexIsNull(_handleToIndex[enumerator.Current.Key]))
				{
					CloseWaitingProcess(enumerator.Current.Key);
					enumerator = _waitingTriggers.GetEnumerator();
				}
			}
			ProcessIndex key = default(ProcessIndex);
			ProcessIndex processIndex = default(ProcessIndex);
			key.seg = (processIndex.seg = Segment.Update);
			key.i = (processIndex.i = 0);
			while (key.i < _nextUpdateProcessSlot)
			{
				if (UpdateProcesses[key.i] != null)
				{
					if (key.i != processIndex.i)
					{
						UpdateProcesses[processIndex.i] = UpdateProcesses[key.i];
						UpdatePaused[processIndex.i] = UpdatePaused[key.i];
						UpdateHeld[processIndex.i] = UpdateHeld[key.i];
						if (_indexToHandle.ContainsKey(processIndex))
						{
							RemoveGraffiti(_indexToHandle[processIndex]);
							_handleToIndex.Remove(_indexToHandle[processIndex]);
							_indexToHandle.Remove(processIndex);
						}
						_handleToIndex[_indexToHandle[key]] = processIndex;
						_indexToHandle.Add(processIndex, _indexToHandle[key]);
						_indexToHandle.Remove(key);
					}
					processIndex.i++;
				}
				key.i++;
			}
			key.i = processIndex.i;
			while (key.i < _nextUpdateProcessSlot)
			{
				UpdateProcesses[key.i] = null;
				UpdatePaused[key.i] = false;
				UpdateHeld[key.i] = false;
				if (_indexToHandle.ContainsKey(key))
				{
					RemoveGraffiti(_indexToHandle[key]);
					_handleToIndex.Remove(_indexToHandle[key]);
					_indexToHandle.Remove(key);
				}
				key.i++;
			}
			UpdateCoroutines = (_nextUpdateProcessSlot = processIndex.i);
			key.seg = (processIndex.seg = Segment.FixedUpdate);
			key.i = (processIndex.i = 0);
			while (key.i < _nextFixedUpdateProcessSlot)
			{
				if (FixedUpdateProcesses[key.i] != null)
				{
					if (key.i != processIndex.i)
					{
						FixedUpdateProcesses[processIndex.i] = FixedUpdateProcesses[key.i];
						FixedUpdatePaused[processIndex.i] = FixedUpdatePaused[key.i];
						FixedUpdateHeld[processIndex.i] = FixedUpdateHeld[key.i];
						if (_indexToHandle.ContainsKey(processIndex))
						{
							RemoveGraffiti(_indexToHandle[processIndex]);
							_handleToIndex.Remove(_indexToHandle[processIndex]);
							_indexToHandle.Remove(processIndex);
						}
						_handleToIndex[_indexToHandle[key]] = processIndex;
						_indexToHandle.Add(processIndex, _indexToHandle[key]);
						_indexToHandle.Remove(key);
					}
					processIndex.i++;
				}
				key.i++;
			}
			key.i = processIndex.i;
			while (key.i < _nextFixedUpdateProcessSlot)
			{
				FixedUpdateProcesses[key.i] = null;
				FixedUpdatePaused[key.i] = false;
				FixedUpdateHeld[key.i] = false;
				if (_indexToHandle.ContainsKey(key))
				{
					RemoveGraffiti(_indexToHandle[key]);
					_handleToIndex.Remove(_indexToHandle[key]);
					_indexToHandle.Remove(key);
				}
				key.i++;
			}
			FixedUpdateCoroutines = (_nextFixedUpdateProcessSlot = processIndex.i);
			key.seg = (processIndex.seg = Segment.LateUpdate);
			key.i = (processIndex.i = 0);
			while (key.i < _nextLateUpdateProcessSlot)
			{
				if (LateUpdateProcesses[key.i] != null)
				{
					if (key.i != processIndex.i)
					{
						LateUpdateProcesses[processIndex.i] = LateUpdateProcesses[key.i];
						LateUpdatePaused[processIndex.i] = LateUpdatePaused[key.i];
						LateUpdateHeld[processIndex.i] = LateUpdateHeld[key.i];
						if (_indexToHandle.ContainsKey(processIndex))
						{
							RemoveGraffiti(_indexToHandle[processIndex]);
							_handleToIndex.Remove(_indexToHandle[processIndex]);
							_indexToHandle.Remove(processIndex);
						}
						_handleToIndex[_indexToHandle[key]] = processIndex;
						_indexToHandle.Add(processIndex, _indexToHandle[key]);
						_indexToHandle.Remove(key);
					}
					processIndex.i++;
				}
				key.i++;
			}
			key.i = processIndex.i;
			while (key.i < _nextLateUpdateProcessSlot)
			{
				LateUpdateProcesses[key.i] = null;
				LateUpdatePaused[key.i] = false;
				LateUpdateHeld[key.i] = false;
				if (_indexToHandle.ContainsKey(key))
				{
					RemoveGraffiti(_indexToHandle[key]);
					_handleToIndex.Remove(_indexToHandle[key]);
					_indexToHandle.Remove(key);
				}
				key.i++;
			}
			LateUpdateCoroutines = (_nextLateUpdateProcessSlot = processIndex.i);
			key.seg = (processIndex.seg = Segment.SlowUpdate);
			key.i = (processIndex.i = 0);
			while (key.i < _nextSlowUpdateProcessSlot)
			{
				if (SlowUpdateProcesses[key.i] != null)
				{
					if (key.i != processIndex.i)
					{
						SlowUpdateProcesses[processIndex.i] = SlowUpdateProcesses[key.i];
						SlowUpdatePaused[processIndex.i] = SlowUpdatePaused[key.i];
						SlowUpdateHeld[processIndex.i] = SlowUpdateHeld[key.i];
						if (_indexToHandle.ContainsKey(processIndex))
						{
							RemoveGraffiti(_indexToHandle[processIndex]);
							_handleToIndex.Remove(_indexToHandle[processIndex]);
							_indexToHandle.Remove(processIndex);
						}
						_handleToIndex[_indexToHandle[key]] = processIndex;
						_indexToHandle.Add(processIndex, _indexToHandle[key]);
						_indexToHandle.Remove(key);
					}
					processIndex.i++;
				}
				key.i++;
			}
			key.i = processIndex.i;
			while (key.i < _nextSlowUpdateProcessSlot)
			{
				SlowUpdateProcesses[key.i] = null;
				SlowUpdatePaused[key.i] = false;
				SlowUpdateHeld[key.i] = false;
				if (_indexToHandle.ContainsKey(key))
				{
					RemoveGraffiti(_indexToHandle[key]);
					_handleToIndex.Remove(_indexToHandle[key]);
					_indexToHandle.Remove(key);
				}
				key.i++;
			}
			SlowUpdateCoroutines = (_nextSlowUpdateProcessSlot = processIndex.i);
			key.seg = (processIndex.seg = Segment.RealtimeUpdate);
			key.i = (processIndex.i = 0);
			while (key.i < _nextRealtimeUpdateProcessSlot)
			{
				if (RealtimeUpdateProcesses[key.i] != null)
				{
					if (key.i != processIndex.i)
					{
						RealtimeUpdateProcesses[processIndex.i] = RealtimeUpdateProcesses[key.i];
						RealtimeUpdatePaused[processIndex.i] = RealtimeUpdatePaused[key.i];
						RealtimeUpdateHeld[processIndex.i] = RealtimeUpdateHeld[key.i];
						if (_indexToHandle.ContainsKey(processIndex))
						{
							RemoveGraffiti(_indexToHandle[processIndex]);
							_handleToIndex.Remove(_indexToHandle[processIndex]);
							_indexToHandle.Remove(processIndex);
						}
						_handleToIndex[_indexToHandle[key]] = processIndex;
						_indexToHandle.Add(processIndex, _indexToHandle[key]);
						_indexToHandle.Remove(key);
					}
					processIndex.i++;
				}
				key.i++;
			}
			key.i = processIndex.i;
			while (key.i < _nextRealtimeUpdateProcessSlot)
			{
				RealtimeUpdateProcesses[key.i] = null;
				RealtimeUpdatePaused[key.i] = false;
				RealtimeUpdateHeld[key.i] = false;
				if (_indexToHandle.ContainsKey(key))
				{
					RemoveGraffiti(_indexToHandle[key]);
					_handleToIndex.Remove(_indexToHandle[key]);
					_indexToHandle.Remove(key);
				}
				key.i++;
			}
			RealtimeUpdateCoroutines = (_nextRealtimeUpdateProcessSlot = processIndex.i);
			key.seg = (processIndex.seg = Segment.EndOfFrame);
			key.i = (processIndex.i = 0);
			while (key.i < _nextEndOfFrameProcessSlot)
			{
				if (EndOfFrameProcesses[key.i] != null)
				{
					if (key.i != processIndex.i)
					{
						EndOfFrameProcesses[processIndex.i] = EndOfFrameProcesses[key.i];
						EndOfFramePaused[processIndex.i] = EndOfFramePaused[key.i];
						EndOfFrameHeld[processIndex.i] = EndOfFrameHeld[key.i];
						if (_indexToHandle.ContainsKey(processIndex))
						{
							RemoveGraffiti(_indexToHandle[processIndex]);
							_handleToIndex.Remove(_indexToHandle[processIndex]);
							_indexToHandle.Remove(processIndex);
						}
						_handleToIndex[_indexToHandle[key]] = processIndex;
						_indexToHandle.Add(processIndex, _indexToHandle[key]);
						_indexToHandle.Remove(key);
					}
					processIndex.i++;
				}
				key.i++;
			}
			key.i = processIndex.i;
			while (key.i < _nextEndOfFrameProcessSlot)
			{
				EndOfFrameProcesses[key.i] = null;
				EndOfFramePaused[key.i] = false;
				EndOfFrameHeld[key.i] = false;
				if (_indexToHandle.ContainsKey(key))
				{
					RemoveGraffiti(_indexToHandle[key]);
					_handleToIndex.Remove(_indexToHandle[key]);
					_indexToHandle.Remove(key);
				}
				key.i++;
			}
			EndOfFrameCoroutines = (_nextEndOfFrameProcessSlot = processIndex.i);
			key.seg = (processIndex.seg = Segment.ManualTimeframe);
			key.i = (processIndex.i = 0);
			while (key.i < _nextManualTimeframeProcessSlot)
			{
				if (ManualTimeframeProcesses[key.i] != null)
				{
					if (key.i != processIndex.i)
					{
						ManualTimeframeProcesses[processIndex.i] = ManualTimeframeProcesses[key.i];
						ManualTimeframePaused[processIndex.i] = ManualTimeframePaused[key.i];
						ManualTimeframeHeld[processIndex.i] = ManualTimeframeHeld[key.i];
						if (_indexToHandle.ContainsKey(processIndex))
						{
							RemoveGraffiti(_indexToHandle[processIndex]);
							_handleToIndex.Remove(_indexToHandle[processIndex]);
							_indexToHandle.Remove(processIndex);
						}
						_handleToIndex[_indexToHandle[key]] = processIndex;
						_indexToHandle.Add(processIndex, _indexToHandle[key]);
						_indexToHandle.Remove(key);
					}
					processIndex.i++;
				}
				key.i++;
			}
			key.i = processIndex.i;
			while (key.i < _nextManualTimeframeProcessSlot)
			{
				ManualTimeframeProcesses[key.i] = null;
				ManualTimeframePaused[key.i] = false;
				ManualTimeframeHeld[key.i] = false;
				if (_indexToHandle.ContainsKey(key))
				{
					RemoveGraffiti(_indexToHandle[key]);
					_handleToIndex.Remove(_indexToHandle[key]);
					_indexToHandle.Remove(key);
				}
				key.i++;
			}
			ManualTimeframeCoroutines = (_nextManualTimeframeProcessSlot = processIndex.i);
		}

		private void EditorRemoveUnused()
		{
			Dictionary<CoroutineHandle, HashSet<CoroutineHandle>>.Enumerator enumerator = _waitingTriggers.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (_handleToIndex.ContainsKey(enumerator.Current.Key) && CoindexIsNull(_handleToIndex[enumerator.Current.Key]))
				{
					CloseWaitingProcess(enumerator.Current.Key);
					enumerator = _waitingTriggers.GetEnumerator();
				}
			}
			ProcessIndex key = default(ProcessIndex);
			ProcessIndex processIndex = default(ProcessIndex);
			key.seg = (processIndex.seg = Segment.EditorUpdate);
			key.i = (processIndex.i = 0);
			while (key.i < _nextEditorUpdateProcessSlot)
			{
				if (EditorUpdateProcesses[key.i] != null)
				{
					if (key.i != processIndex.i)
					{
						EditorUpdateProcesses[processIndex.i] = EditorUpdateProcesses[key.i];
						EditorUpdatePaused[processIndex.i] = EditorUpdatePaused[key.i];
						EditorUpdateHeld[processIndex.i] = EditorUpdateHeld[key.i];
						if (_indexToHandle.ContainsKey(processIndex))
						{
							RemoveGraffiti(_indexToHandle[processIndex]);
							_handleToIndex.Remove(_indexToHandle[processIndex]);
							_indexToHandle.Remove(processIndex);
						}
						_handleToIndex[_indexToHandle[key]] = processIndex;
						_indexToHandle.Add(processIndex, _indexToHandle[key]);
						_indexToHandle.Remove(key);
					}
					processIndex.i++;
				}
				key.i++;
			}
			key.i = processIndex.i;
			while (key.i < _nextEditorUpdateProcessSlot)
			{
				EditorUpdateProcesses[key.i] = null;
				EditorUpdatePaused[key.i] = false;
				EditorUpdateHeld[key.i] = false;
				if (_indexToHandle.ContainsKey(key))
				{
					RemoveGraffiti(_indexToHandle[key]);
					_handleToIndex.Remove(_indexToHandle[key]);
					_indexToHandle.Remove(key);
				}
				key.i++;
			}
			EditorUpdateCoroutines = (_nextEditorUpdateProcessSlot = processIndex.i);
			key.seg = (processIndex.seg = Segment.EditorSlowUpdate);
			key.i = (processIndex.i = 0);
			while (key.i < _nextEditorSlowUpdateProcessSlot)
			{
				if (EditorSlowUpdateProcesses[key.i] != null)
				{
					if (key.i != processIndex.i)
					{
						EditorSlowUpdateProcesses[processIndex.i] = EditorSlowUpdateProcesses[key.i];
						EditorUpdatePaused[processIndex.i] = EditorUpdatePaused[key.i];
						EditorUpdateHeld[processIndex.i] = EditorUpdateHeld[key.i];
						if (_indexToHandle.ContainsKey(processIndex))
						{
							RemoveGraffiti(_indexToHandle[processIndex]);
							_handleToIndex.Remove(_indexToHandle[processIndex]);
							_indexToHandle.Remove(processIndex);
						}
						_handleToIndex[_indexToHandle[key]] = processIndex;
						_indexToHandle.Add(processIndex, _indexToHandle[key]);
						_indexToHandle.Remove(key);
					}
					processIndex.i++;
				}
				key.i++;
			}
			key.i = processIndex.i;
			while (key.i < _nextEditorSlowUpdateProcessSlot)
			{
				EditorSlowUpdateProcesses[key.i] = null;
				EditorSlowUpdatePaused[key.i] = false;
				EditorSlowUpdateHeld[key.i] = false;
				if (_indexToHandle.ContainsKey(key))
				{
					RemoveGraffiti(_indexToHandle[key]);
					_handleToIndex.Remove(_indexToHandle[key]);
					_indexToHandle.Remove(key);
				}
				key.i++;
			}
			EditorSlowUpdateCoroutines = (_nextEditorSlowUpdateProcessSlot = processIndex.i);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
		{
			if (coroutine != null)
			{
				return Instance.RunCoroutineInternal(coroutine, Segment.Update, null, null, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj)
		{
			if (coroutine != null)
			{
				return Instance.RunCoroutineInternal(coroutine, Segment.Update, (gameObj == null) ? null : new int?(gameObj.GetInstanceID()), null, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer)
		{
			if (coroutine != null)
			{
				return Instance.RunCoroutineInternal(coroutine, Segment.Update, layer, null, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
		{
			if (coroutine != null)
			{
				return Instance.RunCoroutineInternal(coroutine, Segment.Update, null, tag, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			if (coroutine != null)
			{
				return Instance.RunCoroutineInternal(coroutine, Segment.Update, (gameObj == null) ? null : new int?(gameObj.GetInstanceID()), tag, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer, string tag)
		{
			if (coroutine != null)
			{
				return Instance.RunCoroutineInternal(coroutine, Segment.Update, layer, tag, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
		{
			if (coroutine != null)
			{
				return Instance.RunCoroutineInternal(coroutine, segment, null, null, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			if (coroutine != null)
			{
				return Instance.RunCoroutineInternal(coroutine, segment, (gameObj == null) ? null : new int?(gameObj.GetInstanceID()), null, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			if (coroutine != null)
			{
				return Instance.RunCoroutineInternal(coroutine, segment, layer, null, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			if (coroutine != null)
			{
				return Instance.RunCoroutineInternal(coroutine, segment, null, tag, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			if (coroutine != null)
			{
				return Instance.RunCoroutineInternal(coroutine, segment, (gameObj == null) ? null : new int?(gameObj.GetInstanceID()), tag, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			if (coroutine != null)
			{
				return Instance.RunCoroutineInternal(coroutine, segment, layer, tag, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
		{
			if (coroutine != null)
			{
				return RunCoroutineInternal(coroutine, Segment.Update, null, null, new CoroutineHandle(_instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj)
		{
			if (coroutine != null)
			{
				return RunCoroutineInternal(coroutine, Segment.Update, (gameObj == null) ? null : new int?(gameObj.GetInstanceID()), null, new CoroutineHandle(_instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer)
		{
			if (coroutine != null)
			{
				return RunCoroutineInternal(coroutine, Segment.Update, layer, null, new CoroutineHandle(_instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
		{
			if (coroutine != null)
			{
				return RunCoroutineInternal(coroutine, Segment.Update, null, tag, new CoroutineHandle(_instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			if (coroutine != null)
			{
				return RunCoroutineInternal(coroutine, Segment.Update, (gameObj == null) ? null : new int?(gameObj.GetInstanceID()), tag, new CoroutineHandle(_instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer, string tag)
		{
			if (coroutine != null)
			{
				return RunCoroutineInternal(coroutine, Segment.Update, layer, tag, new CoroutineHandle(_instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
		{
			if (coroutine != null)
			{
				return RunCoroutineInternal(coroutine, segment, null, null, new CoroutineHandle(_instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			if (coroutine != null)
			{
				return RunCoroutineInternal(coroutine, segment, (gameObj == null) ? null : new int?(gameObj.GetInstanceID()), null, new CoroutineHandle(_instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			if (coroutine != null)
			{
				return RunCoroutineInternal(coroutine, segment, layer, null, new CoroutineHandle(_instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			if (coroutine != null)
			{
				return RunCoroutineInternal(coroutine, segment, null, tag, new CoroutineHandle(_instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			if (coroutine != null)
			{
				return RunCoroutineInternal(coroutine, segment, (gameObj == null) ? null : new int?(gameObj.GetInstanceID()), tag, new CoroutineHandle(_instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			if (coroutine != null)
			{
				return RunCoroutineInternal(coroutine, segment, layer, tag, new CoroutineHandle(_instanceID), prewarm: true);
			}
			return default(CoroutineHandle);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			if (coroutine == null)
			{
				return default(CoroutineHandle);
			}
			if (behaviorOnCollision == SingletonBehavior.Overwrite)
			{
				KillCoroutines(handle);
			}
			else if (IsRunning(handle))
			{
				switch (behaviorOnCollision)
				{
				case SingletonBehavior.Abort:
					return handle;
				case SingletonBehavior.Wait:
				{
					CoroutineHandle coroutineHandle = Instance.RunCoroutineInternal(coroutine, Segment.Update, null, null, new CoroutineHandle(Instance._instanceID), prewarm: false);
					WaitForOtherHandles(coroutineHandle, handle, warnOnIssue: false);
					return coroutineHandle;
				}
				}
			}
			return Instance.RunCoroutineInternal(coroutine, Segment.Update, null, null, new CoroutineHandle(Instance._instanceID), prewarm: true);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			if (!(gameObj == null))
			{
				return RunCoroutineSingleton(coroutine, gameObj.GetInstanceID(), behaviorOnCollision);
			}
			return RunCoroutine(coroutine);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			if (coroutine == null)
			{
				return default(CoroutineHandle);
			}
			if (behaviorOnCollision == SingletonBehavior.Overwrite)
			{
				KillCoroutines(layer);
			}
			else if (Instance._layeredProcesses.ContainsKey(layer))
			{
				switch (behaviorOnCollision)
				{
				case SingletonBehavior.Abort:
				{
					HashSet<CoroutineHandle>.Enumerator enumerator = Instance._layeredProcesses[layer].GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (IsRunning(enumerator.Current))
						{
							return enumerator.Current;
						}
					}
					break;
				}
				case SingletonBehavior.Wait:
				{
					CoroutineHandle coroutineHandle = Instance.RunCoroutineInternal(coroutine, Segment.Update, layer, null, new CoroutineHandle(Instance._instanceID), prewarm: false);
					WaitForOtherHandles(coroutineHandle, _instance._layeredProcesses[layer], warnOnIssue: false);
					return coroutineHandle;
				}
				}
			}
			return Instance.RunCoroutineInternal(coroutine, Segment.Update, layer, null, new CoroutineHandle(Instance._instanceID), prewarm: true);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			if (coroutine == null)
			{
				return default(CoroutineHandle);
			}
			if (behaviorOnCollision == SingletonBehavior.Overwrite)
			{
				KillCoroutines(tag);
			}
			else if (Instance._taggedProcesses.ContainsKey(tag))
			{
				switch (behaviorOnCollision)
				{
				case SingletonBehavior.Abort:
				{
					HashSet<CoroutineHandle>.Enumerator enumerator = Instance._taggedProcesses[tag].GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (IsRunning(enumerator.Current))
						{
							return enumerator.Current;
						}
					}
					break;
				}
				case SingletonBehavior.Wait:
				{
					CoroutineHandle coroutineHandle = Instance.RunCoroutineInternal(coroutine, Segment.Update, null, tag, new CoroutineHandle(Instance._instanceID), prewarm: false);
					WaitForOtherHandles(coroutineHandle, _instance._taggedProcesses[tag], warnOnIssue: false);
					return coroutineHandle;
				}
				}
			}
			return Instance.RunCoroutineInternal(coroutine, Segment.Update, null, tag, new CoroutineHandle(Instance._instanceID), prewarm: true);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			if (!(gameObj == null))
			{
				return RunCoroutineSingleton(coroutine, gameObj.GetInstanceID(), tag, behaviorOnCollision);
			}
			return RunCoroutineSingleton(coroutine, tag, behaviorOnCollision);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			if (coroutine == null)
			{
				return default(CoroutineHandle);
			}
			if (behaviorOnCollision == SingletonBehavior.Overwrite)
			{
				KillCoroutines(layer, tag);
				return Instance.RunCoroutineInternal(coroutine, Segment.Update, layer, tag, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			if (!Instance._taggedProcesses.ContainsKey(tag) || !Instance._layeredProcesses.ContainsKey(layer))
			{
				return Instance.RunCoroutineInternal(coroutine, Segment.Update, layer, tag, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			if (behaviorOnCollision == SingletonBehavior.Abort)
			{
				HashSet<CoroutineHandle>.Enumerator enumerator = Instance._taggedProcesses[tag].GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (_instance._processLayers.ContainsKey(enumerator.Current) && _instance._processLayers[enumerator.Current] == layer)
					{
						return enumerator.Current;
					}
				}
			}
			if (behaviorOnCollision == SingletonBehavior.Wait)
			{
				List<CoroutineHandle> list = new List<CoroutineHandle>();
				HashSet<CoroutineHandle>.Enumerator enumerator2 = Instance._taggedProcesses[tag].GetEnumerator();
				while (enumerator2.MoveNext())
				{
					if (Instance._processLayers.ContainsKey(enumerator2.Current) && Instance._processLayers[enumerator2.Current] == layer)
					{
						list.Add(enumerator2.Current);
					}
				}
				if (list.Count > 0)
				{
					CoroutineHandle coroutineHandle = _instance.RunCoroutineInternal(coroutine, Segment.Update, layer, tag, new CoroutineHandle(_instance._instanceID), prewarm: false);
					WaitForOtherHandles(coroutineHandle, list, warnOnIssue: false);
					return coroutineHandle;
				}
			}
			return Instance.RunCoroutineInternal(coroutine, Segment.Update, layer, tag, new CoroutineHandle(Instance._instanceID), prewarm: true);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
		{
			if (coroutine == null)
			{
				return default(CoroutineHandle);
			}
			if (behaviorOnCollision == SingletonBehavior.Overwrite)
			{
				KillCoroutines(handle);
			}
			else if (IsRunning(handle))
			{
				switch (behaviorOnCollision)
				{
				case SingletonBehavior.Abort:
					return handle;
				case SingletonBehavior.Wait:
				{
					CoroutineHandle coroutineHandle = Instance.RunCoroutineInternal(coroutine, segment, null, null, new CoroutineHandle(Instance._instanceID), prewarm: false);
					WaitForOtherHandles(coroutineHandle, handle, warnOnIssue: false);
					return coroutineHandle;
				}
				}
			}
			return Instance.RunCoroutineInternal(coroutine, segment, null, null, new CoroutineHandle(Instance._instanceID), prewarm: true);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			if (!(gameObj == null))
			{
				return RunCoroutineSingleton(coroutine, segment, gameObj.GetInstanceID(), behaviorOnCollision);
			}
			return RunCoroutine(coroutine, segment);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			if (coroutine == null)
			{
				return default(CoroutineHandle);
			}
			if (behaviorOnCollision == SingletonBehavior.Overwrite)
			{
				KillCoroutines(layer);
			}
			else if (Instance._layeredProcesses.ContainsKey(layer))
			{
				switch (behaviorOnCollision)
				{
				case SingletonBehavior.Abort:
				{
					HashSet<CoroutineHandle>.Enumerator enumerator = Instance._layeredProcesses[layer].GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (IsRunning(enumerator.Current))
						{
							return enumerator.Current;
						}
					}
					break;
				}
				case SingletonBehavior.Wait:
				{
					CoroutineHandle coroutineHandle = Instance.RunCoroutineInternal(coroutine, segment, layer, null, new CoroutineHandle(Instance._instanceID), prewarm: false);
					WaitForOtherHandles(coroutineHandle, _instance._layeredProcesses[layer], warnOnIssue: false);
					return coroutineHandle;
				}
				}
			}
			return Instance.RunCoroutineInternal(coroutine, segment, layer, null, new CoroutineHandle(Instance._instanceID), prewarm: true);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			if (coroutine == null)
			{
				return default(CoroutineHandle);
			}
			if (behaviorOnCollision == SingletonBehavior.Overwrite)
			{
				KillCoroutines(tag);
			}
			else if (Instance._taggedProcesses.ContainsKey(tag))
			{
				switch (behaviorOnCollision)
				{
				case SingletonBehavior.Abort:
				{
					HashSet<CoroutineHandle>.Enumerator enumerator = Instance._taggedProcesses[tag].GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (IsRunning(enumerator.Current))
						{
							return enumerator.Current;
						}
					}
					break;
				}
				case SingletonBehavior.Wait:
				{
					CoroutineHandle coroutineHandle = Instance.RunCoroutineInternal(coroutine, segment, null, tag, new CoroutineHandle(Instance._instanceID), prewarm: false);
					WaitForOtherHandles(coroutineHandle, _instance._taggedProcesses[tag], warnOnIssue: false);
					return coroutineHandle;
				}
				}
			}
			return Instance.RunCoroutineInternal(coroutine, segment, null, tag, new CoroutineHandle(Instance._instanceID), prewarm: true);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			if (!(gameObj == null))
			{
				return RunCoroutineSingleton(coroutine, segment, gameObj.GetInstanceID(), tag, behaviorOnCollision);
			}
			return RunCoroutineSingleton(coroutine, segment, tag, behaviorOnCollision);
		}

		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			if (coroutine == null)
			{
				return default(CoroutineHandle);
			}
			if (behaviorOnCollision == SingletonBehavior.Overwrite)
			{
				KillCoroutines(layer, tag);
				return Instance.RunCoroutineInternal(coroutine, segment, layer, tag, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			if (!Instance._taggedProcesses.ContainsKey(tag) || !Instance._layeredProcesses.ContainsKey(layer))
			{
				return Instance.RunCoroutineInternal(coroutine, segment, layer, tag, new CoroutineHandle(Instance._instanceID), prewarm: true);
			}
			switch (behaviorOnCollision)
			{
			case SingletonBehavior.Abort:
			{
				HashSet<CoroutineHandle>.Enumerator enumerator2 = Instance._taggedProcesses[tag].GetEnumerator();
				while (enumerator2.MoveNext())
				{
					if (_instance._processLayers.ContainsKey(enumerator2.Current) && _instance._processLayers[enumerator2.Current] == layer)
					{
						return enumerator2.Current;
					}
				}
				break;
			}
			case SingletonBehavior.Wait:
			{
				List<CoroutineHandle> list = new List<CoroutineHandle>();
				HashSet<CoroutineHandle>.Enumerator enumerator = Instance._taggedProcesses[tag].GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (_instance._processLayers.ContainsKey(enumerator.Current) && _instance._processLayers[enumerator.Current] == layer)
					{
						list.Add(enumerator.Current);
					}
				}
				if (list.Count > 0)
				{
					CoroutineHandle coroutineHandle = _instance.RunCoroutineInternal(coroutine, segment, layer, tag, new CoroutineHandle(_instance._instanceID), prewarm: false);
					WaitForOtherHandles(coroutineHandle, list, warnOnIssue: false);
					return coroutineHandle;
				}
				break;
			}
			}
			return Instance.RunCoroutineInternal(coroutine, segment, layer, tag, new CoroutineHandle(Instance._instanceID), prewarm: true);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			if (coroutine == null)
			{
				return default(CoroutineHandle);
			}
			if (behaviorOnCollision == SingletonBehavior.Overwrite)
			{
				KillCoroutinesOnInstance(handle);
			}
			else if (_handleToIndex.ContainsKey(handle) && !CoindexIsNull(_handleToIndex[handle]))
			{
				switch (behaviorOnCollision)
				{
				case SingletonBehavior.Abort:
					return handle;
				case SingletonBehavior.Wait:
				{
					CoroutineHandle coroutineHandle = RunCoroutineInternal(coroutine, Segment.Update, null, null, new CoroutineHandle(_instanceID), prewarm: false);
					WaitForOtherHandles(coroutineHandle, handle, warnOnIssue: false);
					return coroutineHandle;
				}
				}
			}
			return RunCoroutineInternal(coroutine, Segment.Update, null, null, new CoroutineHandle(_instanceID), prewarm: true);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			if (!(gameObj == null))
			{
				return RunCoroutineSingletonOnInstance(coroutine, gameObj.GetInstanceID(), behaviorOnCollision);
			}
			return RunCoroutineOnInstance(coroutine);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			if (coroutine == null)
			{
				return default(CoroutineHandle);
			}
			if (behaviorOnCollision == SingletonBehavior.Overwrite)
			{
				KillCoroutinesOnInstance(layer);
			}
			else if (_layeredProcesses.ContainsKey(layer))
			{
				switch (behaviorOnCollision)
				{
				case SingletonBehavior.Abort:
				{
					HashSet<CoroutineHandle>.Enumerator enumerator = _layeredProcesses[layer].GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (IsRunning(enumerator.Current))
						{
							return enumerator.Current;
						}
					}
					break;
				}
				case SingletonBehavior.Wait:
				{
					CoroutineHandle coroutineHandle = RunCoroutineInternal(coroutine, Segment.Update, layer, null, new CoroutineHandle(_instanceID), prewarm: false);
					WaitForOtherHandles(coroutineHandle, _layeredProcesses[layer], warnOnIssue: false);
					return coroutineHandle;
				}
				}
			}
			return RunCoroutineInternal(coroutine, Segment.Update, layer, null, new CoroutineHandle(_instanceID), prewarm: true);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			if (coroutine == null)
			{
				return default(CoroutineHandle);
			}
			if (behaviorOnCollision == SingletonBehavior.Overwrite)
			{
				KillCoroutinesOnInstance(tag);
			}
			else if (_taggedProcesses.ContainsKey(tag))
			{
				switch (behaviorOnCollision)
				{
				case SingletonBehavior.Abort:
				{
					HashSet<CoroutineHandle>.Enumerator enumerator = _taggedProcesses[tag].GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (IsRunning(enumerator.Current))
						{
							return enumerator.Current;
						}
					}
					break;
				}
				case SingletonBehavior.Wait:
				{
					CoroutineHandle coroutineHandle = RunCoroutineInternal(coroutine, Segment.Update, null, tag, new CoroutineHandle(_instanceID), prewarm: false);
					WaitForOtherHandles(coroutineHandle, _taggedProcesses[tag], warnOnIssue: false);
					return coroutineHandle;
				}
				}
			}
			return RunCoroutineInternal(coroutine, Segment.Update, null, tag, new CoroutineHandle(_instanceID), prewarm: true);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			if (!(gameObj == null))
			{
				return RunCoroutineSingletonOnInstance(coroutine, gameObj.GetInstanceID(), tag, behaviorOnCollision);
			}
			return RunCoroutineSingletonOnInstance(coroutine, tag, behaviorOnCollision);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			if (coroutine == null)
			{
				return default(CoroutineHandle);
			}
			if (behaviorOnCollision == SingletonBehavior.Overwrite)
			{
				KillCoroutinesOnInstance(layer, tag);
				return RunCoroutineInternal(coroutine, Segment.Update, layer, tag, new CoroutineHandle(_instanceID), prewarm: true);
			}
			if (!_taggedProcesses.ContainsKey(tag) || !_layeredProcesses.ContainsKey(layer))
			{
				return RunCoroutineInternal(coroutine, Segment.Update, layer, tag, new CoroutineHandle(_instanceID), prewarm: true);
			}
			if (behaviorOnCollision == SingletonBehavior.Abort)
			{
				HashSet<CoroutineHandle>.Enumerator enumerator = _taggedProcesses[tag].GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (_processLayers.ContainsKey(enumerator.Current) && _processLayers[enumerator.Current] == layer)
					{
						return enumerator.Current;
					}
				}
			}
			if (behaviorOnCollision == SingletonBehavior.Wait)
			{
				List<CoroutineHandle> list = new List<CoroutineHandle>();
				HashSet<CoroutineHandle>.Enumerator enumerator2 = _taggedProcesses[tag].GetEnumerator();
				while (enumerator2.MoveNext())
				{
					if (_processLayers.ContainsKey(enumerator2.Current) && _processLayers[enumerator2.Current] == layer)
					{
						list.Add(enumerator2.Current);
					}
				}
				if (list.Count > 0)
				{
					CoroutineHandle coroutineHandle = RunCoroutineInternal(coroutine, Segment.Update, layer, tag, new CoroutineHandle(_instanceID), prewarm: false);
					WaitForOtherHandles(coroutineHandle, list, warnOnIssue: false);
					return coroutineHandle;
				}
			}
			return RunCoroutineInternal(coroutine, Segment.Update, layer, tag, new CoroutineHandle(_instanceID), prewarm: true);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			if (!(gameObj == null))
			{
				return RunCoroutineSingletonOnInstance(coroutine, segment, gameObj.GetInstanceID(), behaviorOnCollision);
			}
			return RunCoroutineOnInstance(coroutine, segment);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			if (coroutine == null)
			{
				return default(CoroutineHandle);
			}
			if (behaviorOnCollision == SingletonBehavior.Overwrite)
			{
				KillCoroutinesOnInstance(layer);
			}
			else if (_layeredProcesses.ContainsKey(layer))
			{
				switch (behaviorOnCollision)
				{
				case SingletonBehavior.Abort:
				{
					HashSet<CoroutineHandle>.Enumerator enumerator = _layeredProcesses[layer].GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (IsRunning(enumerator.Current))
						{
							return enumerator.Current;
						}
					}
					break;
				}
				case SingletonBehavior.Wait:
				{
					CoroutineHandle coroutineHandle = RunCoroutineInternal(coroutine, segment, layer, null, new CoroutineHandle(_instanceID), prewarm: false);
					WaitForOtherHandles(coroutineHandle, _layeredProcesses[layer], warnOnIssue: false);
					return coroutineHandle;
				}
				}
			}
			return RunCoroutineInternal(coroutine, segment, layer, null, new CoroutineHandle(_instanceID), prewarm: true);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			if (coroutine == null)
			{
				return default(CoroutineHandle);
			}
			if (behaviorOnCollision == SingletonBehavior.Overwrite)
			{
				KillCoroutinesOnInstance(tag);
			}
			else if (_taggedProcesses.ContainsKey(tag))
			{
				switch (behaviorOnCollision)
				{
				case SingletonBehavior.Abort:
				{
					HashSet<CoroutineHandle>.Enumerator enumerator = _taggedProcesses[tag].GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (IsRunning(enumerator.Current))
						{
							return enumerator.Current;
						}
					}
					break;
				}
				case SingletonBehavior.Wait:
				{
					CoroutineHandle coroutineHandle = RunCoroutineInternal(coroutine, segment, null, tag, new CoroutineHandle(_instanceID), prewarm: false);
					WaitForOtherHandles(coroutineHandle, _taggedProcesses[tag], warnOnIssue: false);
					return coroutineHandle;
				}
				}
			}
			return RunCoroutineInternal(coroutine, segment, null, tag, new CoroutineHandle(_instanceID), prewarm: true);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			if (!(gameObj == null))
			{
				return RunCoroutineSingletonOnInstance(coroutine, segment, gameObj.GetInstanceID(), tag, behaviorOnCollision);
			}
			return RunCoroutineSingletonOnInstance(coroutine, segment, tag, behaviorOnCollision);
		}

		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			if (coroutine == null)
			{
				return default(CoroutineHandle);
			}
			if (behaviorOnCollision == SingletonBehavior.Overwrite)
			{
				KillCoroutinesOnInstance(layer, tag);
				return RunCoroutineInternal(coroutine, segment, layer, tag, new CoroutineHandle(_instanceID), prewarm: true);
			}
			if (!_taggedProcesses.ContainsKey(tag) || !_layeredProcesses.ContainsKey(layer))
			{
				return RunCoroutineInternal(coroutine, segment, layer, tag, new CoroutineHandle(_instanceID), prewarm: true);
			}
			switch (behaviorOnCollision)
			{
			case SingletonBehavior.Abort:
			{
				HashSet<CoroutineHandle>.Enumerator enumerator2 = _taggedProcesses[tag].GetEnumerator();
				while (enumerator2.MoveNext())
				{
					if (_processLayers.ContainsKey(enumerator2.Current) && _processLayers[enumerator2.Current] == layer)
					{
						return enumerator2.Current;
					}
				}
				break;
			}
			case SingletonBehavior.Wait:
			{
				List<CoroutineHandle> list = new List<CoroutineHandle>();
				HashSet<CoroutineHandle>.Enumerator enumerator = _taggedProcesses[tag].GetEnumerator();
				while (enumerator.MoveNext())
				{
					if (_processLayers.ContainsKey(enumerator.Current) && _processLayers[enumerator.Current] == layer)
					{
						list.Add(enumerator.Current);
					}
				}
				if (list.Count > 0)
				{
					CoroutineHandle coroutineHandle = RunCoroutineInternal(coroutine, segment, layer, tag, new CoroutineHandle(_instanceID), prewarm: false);
					WaitForOtherHandles(coroutineHandle, list, warnOnIssue: false);
					return coroutineHandle;
				}
				break;
			}
			}
			return RunCoroutineInternal(coroutine, segment, layer, tag, new CoroutineHandle(_instanceID), prewarm: true);
		}

		private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, int? layer, string tag, CoroutineHandle handle, bool prewarm)
		{
			ProcessIndex processIndex = default(ProcessIndex);
			processIndex.seg = segment;
			ProcessIndex processIndex2 = processIndex;
			if (_handleToIndex.ContainsKey(handle))
			{
				_indexToHandle.Remove(_handleToIndex[handle]);
				_handleToIndex.Remove(handle);
			}
			float num = localTime;
			float num2 = deltaTime;
			CoroutineHandle coroutineHandle = currentCoroutine;
			currentCoroutine = handle;
			try
			{
				switch (segment)
				{
				case Segment.Update:
					if (_nextUpdateProcessSlot >= UpdateProcesses.Length)
					{
						IEnumerator<float>[] updateProcesses = UpdateProcesses;
						bool[] updatePaused = UpdatePaused;
						bool[] updateHeld = UpdateHeld;
						UpdateProcesses = new IEnumerator<float>[UpdateProcesses.Length + 64 * _expansions++];
						UpdatePaused = new bool[UpdateProcesses.Length];
						UpdateHeld = new bool[UpdateProcesses.Length];
						for (int j = 0; j < updateProcesses.Length; j++)
						{
							UpdateProcesses[j] = updateProcesses[j];
							UpdatePaused[j] = updatePaused[j];
							UpdateHeld[j] = updateHeld[j];
						}
					}
					if (UpdateTimeValues(processIndex2.seg))
					{
						_lastUpdateProcessSlot = _nextUpdateProcessSlot;
					}
					processIndex2.i = _nextUpdateProcessSlot++;
					UpdateProcesses[processIndex2.i] = coroutine;
					if (tag != null)
					{
						AddTagOnInstance(tag, handle);
					}
					if (layer.HasValue)
					{
						AddLayerOnInstance(layer.Value, handle);
					}
					_indexToHandle.Add(processIndex2, handle);
					_handleToIndex.Add(handle, processIndex2);
					while (prewarm)
					{
						if (!UpdateProcesses[processIndex2.i].MoveNext())
						{
							if (_indexToHandle.ContainsKey(processIndex2))
							{
								KillCoroutinesOnInstance(_indexToHandle[processIndex2]);
							}
							prewarm = false;
						}
						else if (UpdateProcesses[processIndex2.i] != null && float.IsNaN(UpdateProcesses[processIndex2.i].Current))
						{
							if (ReplacementFunction != null)
							{
								UpdateProcesses[processIndex2.i] = ReplacementFunction(UpdateProcesses[processIndex2.i], _indexToHandle[processIndex2]);
								ReplacementFunction = null;
							}
							prewarm = !UpdatePaused[processIndex2.i] && !UpdateHeld[processIndex2.i];
						}
						else
						{
							prewarm = false;
						}
					}
					break;
				case Segment.FixedUpdate:
					if (_nextFixedUpdateProcessSlot >= FixedUpdateProcesses.Length)
					{
						IEnumerator<float>[] fixedUpdateProcesses = FixedUpdateProcesses;
						bool[] fixedUpdatePaused = FixedUpdatePaused;
						bool[] fixedUpdateHeld = FixedUpdateHeld;
						FixedUpdateProcesses = new IEnumerator<float>[FixedUpdateProcesses.Length + 64 * _expansions++];
						FixedUpdatePaused = new bool[FixedUpdateProcesses.Length];
						FixedUpdateHeld = new bool[FixedUpdateProcesses.Length];
						for (int num3 = 0; num3 < fixedUpdateProcesses.Length; num3++)
						{
							FixedUpdateProcesses[num3] = fixedUpdateProcesses[num3];
							FixedUpdatePaused[num3] = fixedUpdatePaused[num3];
							FixedUpdateHeld[num3] = fixedUpdateHeld[num3];
						}
					}
					if (UpdateTimeValues(processIndex2.seg))
					{
						_lastFixedUpdateProcessSlot = _nextFixedUpdateProcessSlot;
					}
					processIndex2.i = _nextFixedUpdateProcessSlot++;
					FixedUpdateProcesses[processIndex2.i] = coroutine;
					if (tag != null)
					{
						AddTagOnInstance(tag, handle);
					}
					if (layer.HasValue)
					{
						AddLayerOnInstance(layer.Value, handle);
					}
					_indexToHandle.Add(processIndex2, handle);
					_handleToIndex.Add(handle, processIndex2);
					while (prewarm)
					{
						if (!FixedUpdateProcesses[processIndex2.i].MoveNext())
						{
							if (_indexToHandle.ContainsKey(processIndex2))
							{
								KillCoroutinesOnInstance(_indexToHandle[processIndex2]);
							}
							prewarm = false;
						}
						else if (FixedUpdateProcesses[processIndex2.i] != null && float.IsNaN(FixedUpdateProcesses[processIndex2.i].Current))
						{
							if (ReplacementFunction != null)
							{
								FixedUpdateProcesses[processIndex2.i] = ReplacementFunction(FixedUpdateProcesses[processIndex2.i], _indexToHandle[processIndex2]);
								ReplacementFunction = null;
							}
							prewarm = !FixedUpdatePaused[processIndex2.i] && !FixedUpdateHeld[processIndex2.i];
						}
						else
						{
							prewarm = false;
						}
					}
					break;
				case Segment.LateUpdate:
					if (_nextLateUpdateProcessSlot >= LateUpdateProcesses.Length)
					{
						IEnumerator<float>[] lateUpdateProcesses = LateUpdateProcesses;
						bool[] lateUpdatePaused = LateUpdatePaused;
						bool[] lateUpdateHeld = LateUpdateHeld;
						LateUpdateProcesses = new IEnumerator<float>[LateUpdateProcesses.Length + 64 * _expansions++];
						LateUpdatePaused = new bool[LateUpdateProcesses.Length];
						LateUpdateHeld = new bool[LateUpdateProcesses.Length];
						for (int l = 0; l < lateUpdateProcesses.Length; l++)
						{
							LateUpdateProcesses[l] = lateUpdateProcesses[l];
							LateUpdatePaused[l] = lateUpdatePaused[l];
							LateUpdateHeld[l] = lateUpdateHeld[l];
						}
					}
					if (UpdateTimeValues(processIndex2.seg))
					{
						_lastLateUpdateProcessSlot = _nextLateUpdateProcessSlot;
					}
					processIndex2.i = _nextLateUpdateProcessSlot++;
					LateUpdateProcesses[processIndex2.i] = coroutine;
					if (tag != null)
					{
						AddTagOnInstance(tag, handle);
					}
					if (layer.HasValue)
					{
						AddLayerOnInstance(layer.Value, handle);
					}
					_indexToHandle.Add(processIndex2, handle);
					_handleToIndex.Add(handle, processIndex2);
					while (prewarm)
					{
						if (!LateUpdateProcesses[processIndex2.i].MoveNext())
						{
							if (_indexToHandle.ContainsKey(processIndex2))
							{
								KillCoroutinesOnInstance(_indexToHandle[processIndex2]);
							}
							prewarm = false;
						}
						else if (LateUpdateProcesses[processIndex2.i] != null && float.IsNaN(LateUpdateProcesses[processIndex2.i].Current))
						{
							if (ReplacementFunction != null)
							{
								LateUpdateProcesses[processIndex2.i] = ReplacementFunction(LateUpdateProcesses[processIndex2.i], _indexToHandle[processIndex2]);
								ReplacementFunction = null;
							}
							prewarm = !LateUpdatePaused[processIndex2.i] && !LateUpdateHeld[processIndex2.i];
						}
						else
						{
							prewarm = false;
						}
					}
					break;
				case Segment.SlowUpdate:
					if (_nextSlowUpdateProcessSlot >= SlowUpdateProcesses.Length)
					{
						IEnumerator<float>[] slowUpdateProcesses = SlowUpdateProcesses;
						bool[] slowUpdatePaused = SlowUpdatePaused;
						bool[] slowUpdateHeld = SlowUpdateHeld;
						SlowUpdateProcesses = new IEnumerator<float>[SlowUpdateProcesses.Length + 64 * _expansions++];
						SlowUpdatePaused = new bool[SlowUpdateProcesses.Length];
						SlowUpdateHeld = new bool[SlowUpdateProcesses.Length];
						for (int m = 0; m < slowUpdateProcesses.Length; m++)
						{
							SlowUpdateProcesses[m] = slowUpdateProcesses[m];
							SlowUpdatePaused[m] = slowUpdatePaused[m];
							SlowUpdateHeld[m] = slowUpdateHeld[m];
						}
					}
					if (UpdateTimeValues(processIndex2.seg))
					{
						_lastSlowUpdateProcessSlot = _nextSlowUpdateProcessSlot;
					}
					processIndex2.i = _nextSlowUpdateProcessSlot++;
					SlowUpdateProcesses[processIndex2.i] = coroutine;
					if (tag != null)
					{
						AddTagOnInstance(tag, handle);
					}
					if (layer.HasValue)
					{
						AddLayerOnInstance(layer.Value, handle);
					}
					_indexToHandle.Add(processIndex2, handle);
					_handleToIndex.Add(handle, processIndex2);
					while (prewarm)
					{
						if (!SlowUpdateProcesses[processIndex2.i].MoveNext())
						{
							if (_indexToHandle.ContainsKey(processIndex2))
							{
								KillCoroutinesOnInstance(_indexToHandle[processIndex2]);
							}
							prewarm = false;
						}
						else if (SlowUpdateProcesses[processIndex2.i] != null && float.IsNaN(SlowUpdateProcesses[processIndex2.i].Current))
						{
							if (ReplacementFunction != null)
							{
								SlowUpdateProcesses[processIndex2.i] = ReplacementFunction(SlowUpdateProcesses[processIndex2.i], _indexToHandle[processIndex2]);
								ReplacementFunction = null;
							}
							prewarm = !SlowUpdatePaused[processIndex2.i] && !SlowUpdateHeld[processIndex2.i];
						}
						else
						{
							prewarm = false;
						}
					}
					break;
				case Segment.RealtimeUpdate:
					if (_nextRealtimeUpdateProcessSlot >= RealtimeUpdateProcesses.Length)
					{
						IEnumerator<float>[] realtimeUpdateProcesses = RealtimeUpdateProcesses;
						bool[] realtimeUpdatePaused = RealtimeUpdatePaused;
						bool[] realtimeUpdateHeld = RealtimeUpdateHeld;
						RealtimeUpdateProcesses = new IEnumerator<float>[RealtimeUpdateProcesses.Length + 64 * _expansions++];
						RealtimeUpdatePaused = new bool[RealtimeUpdateProcesses.Length];
						RealtimeUpdateHeld = new bool[RealtimeUpdateProcesses.Length];
						for (int k = 0; k < realtimeUpdateProcesses.Length; k++)
						{
							RealtimeUpdateProcesses[k] = realtimeUpdateProcesses[k];
							RealtimeUpdatePaused[k] = realtimeUpdatePaused[k];
							RealtimeUpdateHeld[k] = realtimeUpdateHeld[k];
						}
					}
					if (UpdateTimeValues(processIndex2.seg))
					{
						_lastRealtimeUpdateProcessSlot = _nextRealtimeUpdateProcessSlot;
					}
					processIndex2.i = _nextRealtimeUpdateProcessSlot++;
					RealtimeUpdateProcesses[processIndex2.i] = coroutine;
					if (tag != null)
					{
						AddTagOnInstance(tag, handle);
					}
					if (layer.HasValue)
					{
						AddLayerOnInstance(layer.Value, handle);
					}
					_indexToHandle.Add(processIndex2, handle);
					_handleToIndex.Add(handle, processIndex2);
					while (prewarm)
					{
						if (!RealtimeUpdateProcesses[processIndex2.i].MoveNext())
						{
							if (_indexToHandle.ContainsKey(processIndex2))
							{
								KillCoroutinesOnInstance(_indexToHandle[processIndex2]);
							}
							prewarm = false;
						}
						else if (RealtimeUpdateProcesses[processIndex2.i] != null && float.IsNaN(RealtimeUpdateProcesses[processIndex2.i].Current))
						{
							if (ReplacementFunction != null)
							{
								RealtimeUpdateProcesses[processIndex2.i] = ReplacementFunction(RealtimeUpdateProcesses[processIndex2.i], _indexToHandle[processIndex2]);
								ReplacementFunction = null;
							}
							prewarm = !RealtimeUpdatePaused[processIndex2.i] && !RealtimeUpdateHeld[processIndex2.i];
						}
						else
						{
							prewarm = false;
						}
					}
					break;
				case Segment.EndOfFrame:
					if (_nextEndOfFrameProcessSlot >= EndOfFrameProcesses.Length)
					{
						IEnumerator<float>[] endOfFrameProcesses = EndOfFrameProcesses;
						bool[] endOfFramePaused = EndOfFramePaused;
						bool[] endOfFrameHeld = EndOfFrameHeld;
						EndOfFrameProcesses = new IEnumerator<float>[EndOfFrameProcesses.Length + 64 * _expansions++];
						EndOfFramePaused = new bool[EndOfFrameProcesses.Length];
						EndOfFrameHeld = new bool[EndOfFrameProcesses.Length];
						for (int n = 0; n < endOfFrameProcesses.Length; n++)
						{
							EndOfFrameProcesses[n] = endOfFrameProcesses[n];
							EndOfFramePaused[n] = endOfFramePaused[n];
							EndOfFrameHeld[n] = endOfFrameHeld[n];
						}
					}
					if (UpdateTimeValues(processIndex2.seg))
					{
						_lastEndOfFrameProcessSlot = _nextEndOfFrameProcessSlot;
					}
					processIndex2.i = _nextEndOfFrameProcessSlot++;
					EndOfFrameProcesses[processIndex2.i] = coroutine;
					if (tag != null)
					{
						AddTagOnInstance(tag, handle);
					}
					if (layer.HasValue)
					{
						AddLayerOnInstance(layer.Value, handle);
					}
					_indexToHandle.Add(processIndex2, handle);
					_handleToIndex.Add(handle, processIndex2);
					_eofWatcherHandle = RunCoroutineSingletonOnInstance(_EOFPumpWatcher(), _eofWatcherHandle, SingletonBehavior.Abort);
					break;
				case Segment.ManualTimeframe:
					if (_nextManualTimeframeProcessSlot >= ManualTimeframeProcesses.Length)
					{
						IEnumerator<float>[] manualTimeframeProcesses = ManualTimeframeProcesses;
						bool[] manualTimeframePaused = ManualTimeframePaused;
						bool[] manualTimeframeHeld = ManualTimeframeHeld;
						ManualTimeframeProcesses = new IEnumerator<float>[ManualTimeframeProcesses.Length + 64 * _expansions++];
						ManualTimeframePaused = new bool[ManualTimeframeProcesses.Length];
						ManualTimeframeHeld = new bool[ManualTimeframeProcesses.Length];
						for (int i = 0; i < manualTimeframeProcesses.Length; i++)
						{
							ManualTimeframeProcesses[i] = manualTimeframeProcesses[i];
							ManualTimeframePaused[i] = manualTimeframePaused[i];
							ManualTimeframeHeld[i] = manualTimeframeHeld[i];
						}
					}
					if (UpdateTimeValues(processIndex2.seg))
					{
						_lastManualTimeframeProcessSlot = _nextManualTimeframeProcessSlot;
					}
					processIndex2.i = _nextManualTimeframeProcessSlot++;
					ManualTimeframeProcesses[processIndex2.i] = coroutine;
					if (tag != null)
					{
						AddTagOnInstance(tag, handle);
					}
					if (layer.HasValue)
					{
						AddLayerOnInstance(layer.Value, handle);
					}
					_indexToHandle.Add(processIndex2, handle);
					_handleToIndex.Add(handle, processIndex2);
					break;
				default:
					handle = default(CoroutineHandle);
					break;
				}
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
			localTime = num;
			deltaTime = num2;
			currentCoroutine = coroutineHandle;
			return handle;
		}

		public static int KillCoroutines()
		{
			if (!(_instance == null))
			{
				return _instance.KillCoroutinesOnInstance();
			}
			return 0;
		}

		public int KillCoroutinesOnInstance()
		{
			int result = _nextUpdateProcessSlot + _nextLateUpdateProcessSlot + _nextFixedUpdateProcessSlot + _nextSlowUpdateProcessSlot + _nextRealtimeUpdateProcessSlot + _nextEditorUpdateProcessSlot + _nextEditorSlowUpdateProcessSlot + _nextEndOfFrameProcessSlot + _nextManualTimeframeProcessSlot;
			UpdateProcesses = new IEnumerator<float>[256];
			UpdatePaused = new bool[256];
			UpdateHeld = new bool[256];
			UpdateCoroutines = 0;
			_nextUpdateProcessSlot = 0;
			LateUpdateProcesses = new IEnumerator<float>[8];
			LateUpdatePaused = new bool[8];
			LateUpdateHeld = new bool[8];
			LateUpdateCoroutines = 0;
			_nextLateUpdateProcessSlot = 0;
			FixedUpdateProcesses = new IEnumerator<float>[64];
			FixedUpdatePaused = new bool[64];
			FixedUpdateHeld = new bool[64];
			FixedUpdateCoroutines = 0;
			_nextFixedUpdateProcessSlot = 0;
			SlowUpdateProcesses = new IEnumerator<float>[64];
			SlowUpdatePaused = new bool[64];
			SlowUpdateHeld = new bool[64];
			SlowUpdateCoroutines = 0;
			_nextSlowUpdateProcessSlot = 0;
			RealtimeUpdateProcesses = new IEnumerator<float>[8];
			RealtimeUpdatePaused = new bool[8];
			RealtimeUpdateHeld = new bool[8];
			RealtimeUpdateCoroutines = 0;
			_nextRealtimeUpdateProcessSlot = 0;
			EditorUpdateProcesses = new IEnumerator<float>[8];
			EditorUpdatePaused = new bool[8];
			EditorUpdateHeld = new bool[8];
			EditorUpdateCoroutines = 0;
			_nextEditorUpdateProcessSlot = 0;
			EditorSlowUpdateProcesses = new IEnumerator<float>[8];
			EditorSlowUpdatePaused = new bool[8];
			EditorSlowUpdateHeld = new bool[8];
			EditorSlowUpdateCoroutines = 0;
			_nextEditorSlowUpdateProcessSlot = 0;
			EndOfFrameProcesses = new IEnumerator<float>[8];
			EndOfFramePaused = new bool[8];
			EndOfFrameHeld = new bool[8];
			EndOfFrameCoroutines = 0;
			_nextEndOfFrameProcessSlot = 0;
			ManualTimeframeProcesses = new IEnumerator<float>[8];
			ManualTimeframePaused = new bool[8];
			ManualTimeframeHeld = new bool[8];
			ManualTimeframeCoroutines = 0;
			_nextManualTimeframeProcessSlot = 0;
			_processTags.Clear();
			_taggedProcesses.Clear();
			_processLayers.Clear();
			_layeredProcesses.Clear();
			_handleToIndex.Clear();
			_indexToHandle.Clear();
			_waitingTriggers.Clear();
			_expansions = (ushort)(_expansions / 2 + 1);
			Links.Clear();
			return result;
		}

		public static int KillCoroutines(CoroutineHandle handle)
		{
			if (!(ActiveInstances[handle.Key] != null))
			{
				return 0;
			}
			return GetInstance(handle.Key).KillCoroutinesOnInstance(handle);
		}

		public static int KillCoroutines(IEnumerable<CoroutineHandle> handles)
		{
			int num = 0;
			foreach (CoroutineHandle handle in handles)
			{
				num += KillCoroutines(handle);
			}
			return num;
		}

		public int KillCoroutinesOnInstance(CoroutineHandle handle)
		{
			int num = 0;
			if (_handleToIndex.ContainsKey(handle))
			{
				if (_waitingTriggers.ContainsKey(handle))
				{
					CloseWaitingProcess(handle);
				}
				if (Nullify(handle))
				{
					num++;
				}
				RemoveGraffiti(handle);
			}
			if (Links.ContainsKey(handle))
			{
				HashSet<CoroutineHandle>.Enumerator enumerator = Links[handle].GetEnumerator();
				Links.Remove(handle);
				while (enumerator.MoveNext())
				{
					num += KillCoroutines(enumerator.Current);
				}
			}
			return num;
		}

		public static int KillCoroutines(GameObject gameObj)
		{
			if (!(_instance == null))
			{
				return _instance.KillCoroutinesOnInstance(gameObj.GetInstanceID());
			}
			return 0;
		}

		public int KillCoroutinesOnInstance(GameObject gameObj)
		{
			return KillCoroutinesOnInstance(gameObj.GetInstanceID());
		}

		public static int KillCoroutines(int layer)
		{
			if (!(_instance == null))
			{
				return _instance.KillCoroutinesOnInstance(layer);
			}
			return 0;
		}

		public int KillCoroutinesOnInstance(int layer)
		{
			int num = 0;
			while (_layeredProcesses.ContainsKey(layer))
			{
				HashSet<CoroutineHandle>.Enumerator enumerator = _layeredProcesses[layer].GetEnumerator();
				enumerator.MoveNext();
				if (Nullify(enumerator.Current))
				{
					if (_waitingTriggers.ContainsKey(enumerator.Current))
					{
						CloseWaitingProcess(enumerator.Current);
					}
					num++;
				}
				RemoveGraffiti(enumerator.Current);
				if (Links.ContainsKey(enumerator.Current))
				{
					HashSet<CoroutineHandle>.Enumerator enumerator2 = Links[enumerator.Current].GetEnumerator();
					Links.Remove(enumerator.Current);
					while (enumerator2.MoveNext())
					{
						num += KillCoroutines(enumerator2.Current);
					}
				}
			}
			return num;
		}

		public static int KillCoroutines(string tag)
		{
			if (!(_instance == null))
			{
				return _instance.KillCoroutinesOnInstance(tag);
			}
			return 0;
		}

		public int KillCoroutinesOnInstance(string tag)
		{
			if (tag == null)
			{
				return 0;
			}
			int num = 0;
			while (_taggedProcesses.ContainsKey(tag))
			{
				HashSet<CoroutineHandle>.Enumerator enumerator = _taggedProcesses[tag].GetEnumerator();
				enumerator.MoveNext();
				if (Nullify(_handleToIndex[enumerator.Current]))
				{
					if (_waitingTriggers.ContainsKey(enumerator.Current))
					{
						CloseWaitingProcess(enumerator.Current);
					}
					num++;
				}
				RemoveGraffiti(enumerator.Current);
				if (Links.ContainsKey(enumerator.Current))
				{
					HashSet<CoroutineHandle>.Enumerator enumerator2 = Links[enumerator.Current].GetEnumerator();
					Links.Remove(enumerator.Current);
					while (enumerator2.MoveNext())
					{
						num += KillCoroutines(enumerator2.Current);
					}
				}
			}
			return num;
		}

		public static int KillCoroutines(GameObject gameObj, string tag)
		{
			if (!(_instance == null))
			{
				return _instance.KillCoroutinesOnInstance(gameObj.GetInstanceID(), tag);
			}
			return 0;
		}

		public int KillCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return KillCoroutinesOnInstance(gameObj.GetInstanceID(), tag);
		}

		public static int KillCoroutines(int layer, string tag)
		{
			if (!(_instance == null))
			{
				return _instance.KillCoroutinesOnInstance(layer, tag);
			}
			return 0;
		}

		public int KillCoroutinesOnInstance(int layer, string tag)
		{
			if (tag == null)
			{
				return KillCoroutinesOnInstance(layer);
			}
			if (!_layeredProcesses.ContainsKey(layer) || !_taggedProcesses.ContainsKey(tag))
			{
				return 0;
			}
			int num = 0;
			HashSet<CoroutineHandle>.Enumerator enumerator = _taggedProcesses[tag].GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (CoindexIsNull(_handleToIndex[enumerator.Current]) || !_layeredProcesses[layer].Contains(enumerator.Current) || !Nullify(enumerator.Current))
				{
					continue;
				}
				if (_waitingTriggers.ContainsKey(enumerator.Current))
				{
					CloseWaitingProcess(enumerator.Current);
				}
				num++;
				RemoveGraffiti(enumerator.Current);
				if (Links.ContainsKey(enumerator.Current))
				{
					HashSet<CoroutineHandle>.Enumerator enumerator2 = Links[enumerator.Current].GetEnumerator();
					Links.Remove(enumerator.Current);
					while (enumerator2.MoveNext())
					{
						KillCoroutines(enumerator2.Current);
					}
				}
				if (!_taggedProcesses.ContainsKey(tag) || !_layeredProcesses.ContainsKey(layer))
				{
					break;
				}
				enumerator = _taggedProcesses[tag].GetEnumerator();
			}
			return num;
		}

		public static Timing GetInstance(byte ID)
		{
			if (ID >= 16)
			{
				return null;
			}
			return ActiveInstances[ID];
		}

		public static float WaitForSeconds(float waitTime)
		{
			if (float.IsNaN(waitTime))
			{
				waitTime = 0f;
			}
			return LocalTime + waitTime;
		}

		public float WaitForSecondsOnInstance(float waitTime)
		{
			if (float.IsNaN(waitTime))
			{
				waitTime = 0f;
			}
			return localTime + waitTime;
		}

		private bool UpdateTimeValues(Segment segment)
		{
			switch (segment)
			{
			case Segment.Update:
				if (_currentUpdateFrame != Time.frameCount)
				{
					deltaTime = Time.deltaTime;
					_lastUpdateTime += deltaTime;
					localTime = _lastUpdateTime;
					_currentUpdateFrame = Time.frameCount;
					return true;
				}
				deltaTime = Time.deltaTime;
				localTime = _lastUpdateTime;
				return false;
			case Segment.LateUpdate:
				if (_currentLateUpdateFrame != Time.frameCount)
				{
					deltaTime = Time.deltaTime;
					_lastLateUpdateTime += deltaTime;
					localTime = _lastLateUpdateTime;
					_currentLateUpdateFrame = Time.frameCount;
					return true;
				}
				deltaTime = Time.deltaTime;
				localTime = _lastLateUpdateTime;
				return false;
			case Segment.FixedUpdate:
				deltaTime = Time.fixedDeltaTime;
				localTime = Time.fixedTime;
				if (_lastFixedUpdateTime + 0.0001f < Time.fixedTime)
				{
					_lastFixedUpdateTime = Time.fixedTime;
					return true;
				}
				return false;
			case Segment.SlowUpdate:
				if (_currentSlowUpdateFrame != Time.frameCount)
				{
					deltaTime = (_lastSlowUpdateDeltaTime = Time.realtimeSinceStartup - _lastSlowUpdateTime);
					localTime = (_lastSlowUpdateTime = Time.realtimeSinceStartup);
					_currentSlowUpdateFrame = Time.frameCount;
					return true;
				}
				localTime = _lastSlowUpdateTime;
				deltaTime = _lastSlowUpdateDeltaTime;
				return false;
			case Segment.RealtimeUpdate:
				if (_currentRealtimeUpdateFrame != Time.frameCount)
				{
					deltaTime = Time.unscaledDeltaTime;
					_lastRealtimeUpdateTime += deltaTime;
					localTime = _lastRealtimeUpdateTime;
					_currentRealtimeUpdateFrame = Time.frameCount;
					return true;
				}
				deltaTime = Time.unscaledDeltaTime;
				localTime = _lastRealtimeUpdateTime;
				return false;
			case Segment.EndOfFrame:
				if (_currentEndOfFrameFrame != Time.frameCount)
				{
					deltaTime = Time.deltaTime;
					_lastEndOfFrameTime += deltaTime;
					localTime = _lastEndOfFrameTime;
					_currentEndOfFrameFrame = Time.frameCount;
					return true;
				}
				deltaTime = Time.deltaTime;
				localTime = _lastEndOfFrameTime;
				return false;
			case Segment.ManualTimeframe:
			{
				float num = ((SetManualTimeframeTime == null) ? Time.time : SetManualTimeframeTime(_lastManualTimeframeTime));
				if ((double)_lastManualTimeframeTime + 0.0001 < (double)num && (double)_lastManualTimeframeTime - 0.0001 > (double)num)
				{
					localTime = num;
					deltaTime = localTime - _lastManualTimeframeTime;
					if (deltaTime > Time.maximumDeltaTime)
					{
						deltaTime = Time.maximumDeltaTime;
					}
					_lastManualTimeframeDeltaTime = deltaTime;
					_lastManualTimeframeTime = num;
					return true;
				}
				deltaTime = _lastManualTimeframeDeltaTime;
				localTime = _lastManualTimeframeTime;
				return false;
			}
			default:
				return true;
			}
		}

		private float GetSegmentTime(Segment segment)
		{
			switch (segment)
			{
			case Segment.Update:
				if (_currentUpdateFrame == Time.frameCount)
				{
					return _lastUpdateTime;
				}
				return _lastUpdateTime + Time.deltaTime;
			case Segment.LateUpdate:
				if (_currentUpdateFrame == Time.frameCount)
				{
					return _lastLateUpdateTime;
				}
				return _lastLateUpdateTime + Time.deltaTime;
			case Segment.FixedUpdate:
				return Time.fixedTime;
			case Segment.SlowUpdate:
				return Time.realtimeSinceStartup;
			case Segment.RealtimeUpdate:
				if (_currentRealtimeUpdateFrame == Time.frameCount)
				{
					return _lastRealtimeUpdateTime;
				}
				return _lastRealtimeUpdateTime + Time.unscaledDeltaTime;
			case Segment.EndOfFrame:
				if (_currentUpdateFrame == Time.frameCount)
				{
					return _lastEndOfFrameTime;
				}
				return _lastEndOfFrameTime + Time.deltaTime;
			case Segment.ManualTimeframe:
				return _lastManualTimeframeTime;
			default:
				return 0f;
			}
		}

		public static int PauseCoroutines()
		{
			if (!(_instance == null))
			{
				return _instance.PauseCoroutinesOnInstance();
			}
			return 0;
		}

		public int PauseCoroutinesOnInstance()
		{
			int num = 0;
			for (int i = 0; i < _nextUpdateProcessSlot; i++)
			{
				if (!UpdatePaused[i] && UpdateProcesses[i] != null)
				{
					num++;
					UpdatePaused[i] = true;
					if (UpdateProcesses[i].Current > GetSegmentTime(Segment.Update))
					{
						UpdateProcesses[i] = _InjectDelay(UpdateProcesses[i], UpdateProcesses[i].Current - GetSegmentTime(Segment.Update));
					}
				}
			}
			for (int i = 0; i < _nextLateUpdateProcessSlot; i++)
			{
				if (!LateUpdatePaused[i] && LateUpdateProcesses[i] != null)
				{
					num++;
					LateUpdatePaused[i] = true;
					if (LateUpdateProcesses[i].Current > GetSegmentTime(Segment.LateUpdate))
					{
						LateUpdateProcesses[i] = _InjectDelay(LateUpdateProcesses[i], LateUpdateProcesses[i].Current - GetSegmentTime(Segment.LateUpdate));
					}
				}
			}
			for (int i = 0; i < _nextFixedUpdateProcessSlot; i++)
			{
				if (!FixedUpdatePaused[i] && FixedUpdateProcesses[i] != null)
				{
					num++;
					FixedUpdatePaused[i] = true;
					if (FixedUpdateProcesses[i].Current > GetSegmentTime(Segment.FixedUpdate))
					{
						FixedUpdateProcesses[i] = _InjectDelay(FixedUpdateProcesses[i], FixedUpdateProcesses[i].Current - GetSegmentTime(Segment.FixedUpdate));
					}
				}
			}
			for (int i = 0; i < _nextSlowUpdateProcessSlot; i++)
			{
				if (!SlowUpdatePaused[i] && SlowUpdateProcesses[i] != null)
				{
					num++;
					SlowUpdatePaused[i] = true;
					if (SlowUpdateProcesses[i].Current > GetSegmentTime(Segment.SlowUpdate))
					{
						SlowUpdateProcesses[i] = _InjectDelay(SlowUpdateProcesses[i], SlowUpdateProcesses[i].Current - GetSegmentTime(Segment.SlowUpdate));
					}
				}
			}
			for (int i = 0; i < _nextRealtimeUpdateProcessSlot; i++)
			{
				if (!RealtimeUpdatePaused[i] && RealtimeUpdateProcesses[i] != null)
				{
					num++;
					RealtimeUpdatePaused[i] = true;
					if (RealtimeUpdateProcesses[i].Current > GetSegmentTime(Segment.RealtimeUpdate))
					{
						RealtimeUpdateProcesses[i] = _InjectDelay(RealtimeUpdateProcesses[i], RealtimeUpdateProcesses[i].Current - GetSegmentTime(Segment.RealtimeUpdate));
					}
				}
			}
			for (int i = 0; i < _nextEditorUpdateProcessSlot; i++)
			{
				if (!EditorUpdatePaused[i] && EditorUpdateProcesses[i] != null)
				{
					num++;
					EditorUpdatePaused[i] = true;
					if (EditorUpdateProcesses[i].Current > GetSegmentTime(Segment.EditorUpdate))
					{
						EditorUpdateProcesses[i] = _InjectDelay(EditorUpdateProcesses[i], EditorUpdateProcesses[i].Current - GetSegmentTime(Segment.EditorUpdate));
					}
				}
			}
			for (int i = 0; i < _nextEditorSlowUpdateProcessSlot; i++)
			{
				if (!EditorSlowUpdatePaused[i] && EditorSlowUpdateProcesses[i] != null)
				{
					num++;
					EditorSlowUpdatePaused[i] = true;
					if (EditorSlowUpdateProcesses[i].Current > GetSegmentTime(Segment.EditorSlowUpdate))
					{
						EditorSlowUpdateProcesses[i] = _InjectDelay(EditorSlowUpdateProcesses[i], EditorSlowUpdateProcesses[i].Current - GetSegmentTime(Segment.EditorSlowUpdate));
					}
				}
			}
			for (int i = 0; i < _nextEndOfFrameProcessSlot; i++)
			{
				if (!EndOfFramePaused[i] && EndOfFrameProcesses[i] != null)
				{
					num++;
					EndOfFramePaused[i] = true;
					if (EndOfFrameProcesses[i].Current > GetSegmentTime(Segment.EndOfFrame))
					{
						EndOfFrameProcesses[i] = _InjectDelay(EndOfFrameProcesses[i], EndOfFrameProcesses[i].Current - GetSegmentTime(Segment.EndOfFrame));
					}
				}
			}
			for (int i = 0; i < _nextManualTimeframeProcessSlot; i++)
			{
				if (!ManualTimeframePaused[i] && ManualTimeframeProcesses[i] != null)
				{
					num++;
					ManualTimeframePaused[i] = true;
					if (ManualTimeframeProcesses[i].Current > GetSegmentTime(Segment.ManualTimeframe))
					{
						ManualTimeframeProcesses[i] = _InjectDelay(ManualTimeframeProcesses[i], ManualTimeframeProcesses[i].Current - GetSegmentTime(Segment.ManualTimeframe));
					}
				}
			}
			Dictionary<CoroutineHandle, HashSet<CoroutineHandle>>.Enumerator enumerator = Links.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (_handleToIndex.ContainsKey(enumerator.Current.Key))
				{
					HashSet<CoroutineHandle>.Enumerator enumerator2 = enumerator.Current.Value.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						num += PauseCoroutines(enumerator2.Current);
					}
				}
			}
			return num;
		}

		public static int PauseCoroutines(CoroutineHandle handle)
		{
			if (!(ActiveInstances[handle.Key] != null))
			{
				return 0;
			}
			return GetInstance(handle.Key).PauseCoroutinesOnInstance(handle);
		}

		public int PauseCoroutinesOnInstance(CoroutineHandle handle)
		{
			int num = 0;
			if (_handleToIndex.ContainsKey(handle) && !CoindexIsNull(_handleToIndex[handle]) && !SetPause(_handleToIndex[handle], newPausedState: true))
			{
				num++;
			}
			if (Links.ContainsKey(handle))
			{
				HashSet<CoroutineHandle> hashSet = Links[handle];
				Links.Remove(handle);
				HashSet<CoroutineHandle>.Enumerator enumerator = hashSet.GetEnumerator();
				while (enumerator.MoveNext())
				{
					num += PauseCoroutines(enumerator.Current);
				}
				Links.Add(handle, hashSet);
			}
			return num;
		}

		public static int PauseCoroutines(IEnumerable<CoroutineHandle> handles)
		{
			int num = 0;
			IEnumerator<CoroutineHandle> enumerator = handles.GetEnumerator();
			while (!enumerator.MoveNext())
			{
				num += PauseCoroutines(enumerator.Current);
			}
			return num;
		}

		public static int PauseCoroutines(GameObject gameObj)
		{
			if (!(_instance == null))
			{
				return _instance.PauseCoroutinesOnInstance(gameObj);
			}
			return 0;
		}

		public int PauseCoroutinesOnInstance(GameObject gameObj)
		{
			if (!(gameObj == null))
			{
				return PauseCoroutinesOnInstance(gameObj.GetInstanceID());
			}
			return 0;
		}

		public static int PauseCoroutines(int layer)
		{
			if (!(_instance == null))
			{
				return _instance.PauseCoroutinesOnInstance(layer);
			}
			return 0;
		}

		public int PauseCoroutinesOnInstance(int layer)
		{
			if (!_layeredProcesses.ContainsKey(layer))
			{
				return 0;
			}
			int num = 0;
			HashSet<CoroutineHandle>.Enumerator enumerator = _layeredProcesses[layer].GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (!CoindexIsNull(_handleToIndex[enumerator.Current]) && !SetPause(_handleToIndex[enumerator.Current], newPausedState: true))
				{
					num++;
				}
				if (Links.ContainsKey(enumerator.Current))
				{
					HashSet<CoroutineHandle> hashSet = Links[enumerator.Current];
					Links.Remove(enumerator.Current);
					HashSet<CoroutineHandle>.Enumerator enumerator2 = hashSet.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						num += PauseCoroutines(enumerator2.Current);
					}
					Links.Add(enumerator.Current, hashSet);
				}
			}
			return num;
		}

		public static int PauseCoroutines(string tag)
		{
			if (!(_instance == null))
			{
				return _instance.PauseCoroutinesOnInstance(tag);
			}
			return 0;
		}

		public int PauseCoroutinesOnInstance(string tag)
		{
			if (tag == null || !_taggedProcesses.ContainsKey(tag))
			{
				return 0;
			}
			int num = 0;
			HashSet<CoroutineHandle>.Enumerator enumerator = _taggedProcesses[tag].GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (!CoindexIsNull(_handleToIndex[enumerator.Current]) && !SetPause(_handleToIndex[enumerator.Current], newPausedState: true))
				{
					num++;
				}
				if (Links.ContainsKey(enumerator.Current))
				{
					HashSet<CoroutineHandle> hashSet = Links[enumerator.Current];
					Links.Remove(enumerator.Current);
					HashSet<CoroutineHandle>.Enumerator enumerator2 = hashSet.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						num += PauseCoroutines(enumerator2.Current);
					}
					Links.Add(enumerator.Current, hashSet);
				}
			}
			return num;
		}

		public static int PauseCoroutines(GameObject gameObj, string tag)
		{
			if (!(_instance == null))
			{
				return _instance.PauseCoroutinesOnInstance(gameObj.GetInstanceID(), tag);
			}
			return 0;
		}

		public int PauseCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			if (!(gameObj == null))
			{
				return PauseCoroutinesOnInstance(gameObj.GetInstanceID(), tag);
			}
			return 0;
		}

		public static int PauseCoroutines(int layer, string tag)
		{
			if (!(_instance == null))
			{
				return _instance.PauseCoroutinesOnInstance(layer, tag);
			}
			return 0;
		}

		public int PauseCoroutinesOnInstance(int layer, string tag)
		{
			if (tag == null)
			{
				return PauseCoroutinesOnInstance(layer);
			}
			if (!_taggedProcesses.ContainsKey(tag) || !_layeredProcesses.ContainsKey(layer))
			{
				return 0;
			}
			int num = 0;
			HashSet<CoroutineHandle>.Enumerator enumerator = _taggedProcesses[tag].GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (!_processLayers.ContainsKey(enumerator.Current) || _processLayers[enumerator.Current] != layer || CoindexIsNull(_handleToIndex[enumerator.Current]))
				{
					continue;
				}
				if (!SetPause(_handleToIndex[enumerator.Current], newPausedState: true))
				{
					num++;
				}
				if (Links.ContainsKey(enumerator.Current))
				{
					HashSet<CoroutineHandle> hashSet = Links[enumerator.Current];
					Links.Remove(enumerator.Current);
					HashSet<CoroutineHandle>.Enumerator enumerator2 = hashSet.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						num += PauseCoroutines(enumerator2.Current);
					}
					Links.Add(enumerator.Current, hashSet);
				}
			}
			return num;
		}

		public static int ResumeCoroutines()
		{
			if (!(_instance == null))
			{
				return _instance.ResumeCoroutinesOnInstance();
			}
			return 0;
		}

		public int ResumeCoroutinesOnInstance()
		{
			int num = 0;
			ProcessIndex processIndex = default(ProcessIndex);
			processIndex.i = 0;
			processIndex.seg = Segment.Update;
			while (processIndex.i < _nextUpdateProcessSlot)
			{
				if (UpdatePaused[processIndex.i] && UpdateProcesses[processIndex.i] != null)
				{
					UpdatePaused[processIndex.i] = false;
					num++;
				}
				processIndex.i++;
			}
			processIndex.i = 0;
			processIndex.seg = Segment.LateUpdate;
			while (processIndex.i < _nextLateUpdateProcessSlot)
			{
				if (LateUpdatePaused[processIndex.i] && LateUpdateProcesses[processIndex.i] != null)
				{
					LateUpdatePaused[processIndex.i] = false;
					num++;
				}
				processIndex.i++;
			}
			processIndex.i = 0;
			processIndex.seg = Segment.FixedUpdate;
			while (processIndex.i < _nextFixedUpdateProcessSlot)
			{
				if (FixedUpdatePaused[processIndex.i] && FixedUpdateProcesses[processIndex.i] != null)
				{
					FixedUpdatePaused[processIndex.i] = false;
					num++;
				}
				processIndex.i++;
			}
			processIndex.i = 0;
			processIndex.seg = Segment.SlowUpdate;
			while (processIndex.i < _nextSlowUpdateProcessSlot)
			{
				if (SlowUpdatePaused[processIndex.i] && SlowUpdateProcesses[processIndex.i] != null)
				{
					SlowUpdatePaused[processIndex.i] = false;
					num++;
				}
				processIndex.i++;
			}
			processIndex.i = 0;
			processIndex.seg = Segment.RealtimeUpdate;
			while (processIndex.i < _nextRealtimeUpdateProcessSlot)
			{
				if (RealtimeUpdatePaused[processIndex.i] && RealtimeUpdateProcesses[processIndex.i] != null)
				{
					RealtimeUpdatePaused[processIndex.i] = false;
					num++;
				}
				processIndex.i++;
			}
			processIndex.i = 0;
			processIndex.seg = Segment.EditorUpdate;
			while (processIndex.i < _nextEditorUpdateProcessSlot)
			{
				if (EditorUpdatePaused[processIndex.i] && EditorUpdateProcesses[processIndex.i] != null)
				{
					EditorUpdatePaused[processIndex.i] = false;
					num++;
				}
				processIndex.i++;
			}
			processIndex.i = 0;
			processIndex.seg = Segment.EditorSlowUpdate;
			while (processIndex.i < _nextEditorSlowUpdateProcessSlot)
			{
				if (EditorSlowUpdatePaused[processIndex.i] && EditorSlowUpdateProcesses[processIndex.i] != null)
				{
					EditorSlowUpdatePaused[processIndex.i] = false;
					num++;
				}
				processIndex.i++;
			}
			processIndex.i = 0;
			processIndex.seg = Segment.EndOfFrame;
			while (processIndex.i < _nextEndOfFrameProcessSlot)
			{
				if (EndOfFramePaused[processIndex.i] && EndOfFrameProcesses[processIndex.i] != null)
				{
					EndOfFramePaused[processIndex.i] = false;
					num++;
				}
				processIndex.i++;
			}
			processIndex.i = 0;
			processIndex.seg = Segment.ManualTimeframe;
			while (processIndex.i < _nextManualTimeframeProcessSlot)
			{
				if (ManualTimeframePaused[processIndex.i] && ManualTimeframeProcesses[processIndex.i] != null)
				{
					ManualTimeframePaused[processIndex.i] = false;
					num++;
				}
				processIndex.i++;
			}
			Dictionary<CoroutineHandle, HashSet<CoroutineHandle>>.Enumerator enumerator = Links.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (_handleToIndex.ContainsKey(enumerator.Current.Key))
				{
					HashSet<CoroutineHandle>.Enumerator enumerator2 = enumerator.Current.Value.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						num += ResumeCoroutines(enumerator2.Current);
					}
				}
			}
			return num;
		}

		public static int ResumeCoroutines(CoroutineHandle handle)
		{
			if (!(ActiveInstances[handle.Key] != null))
			{
				return 0;
			}
			return GetInstance(handle.Key).ResumeCoroutinesOnInstance(handle);
		}

		public static int ResumeCoroutines(IEnumerable<CoroutineHandle> handles)
		{
			int result = 0;
			IEnumerator<CoroutineHandle> enumerator = handles.GetEnumerator();
			while (!enumerator.MoveNext())
			{
				ResumeCoroutines(enumerator.Current);
			}
			return result;
		}

		public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
		{
			int num = 0;
			if (_handleToIndex.ContainsKey(handle) && !CoindexIsNull(_handleToIndex[handle]) && SetPause(_handleToIndex[handle], newPausedState: false))
			{
				num++;
			}
			if (Links.ContainsKey(handle))
			{
				HashSet<CoroutineHandle> hashSet = Links[handle];
				Links.Remove(handle);
				HashSet<CoroutineHandle>.Enumerator enumerator = hashSet.GetEnumerator();
				while (enumerator.MoveNext())
				{
					num += ResumeCoroutines(enumerator.Current);
				}
				Links.Add(handle, hashSet);
			}
			return num;
		}

		public static int ResumeCoroutines(GameObject gameObj)
		{
			if (!(_instance == null))
			{
				return _instance.ResumeCoroutinesOnInstance(gameObj.GetInstanceID());
			}
			return 0;
		}

		public int ResumeCoroutinesOnInstance(GameObject gameObj)
		{
			if (!(gameObj == null))
			{
				return ResumeCoroutinesOnInstance(gameObj.GetInstanceID());
			}
			return 0;
		}

		public static int ResumeCoroutines(int layer)
		{
			if (!(_instance == null))
			{
				return _instance.ResumeCoroutinesOnInstance(layer);
			}
			return 0;
		}

		public int ResumeCoroutinesOnInstance(int layer)
		{
			if (!_layeredProcesses.ContainsKey(layer))
			{
				return 0;
			}
			int num = 0;
			HashSet<CoroutineHandle>.Enumerator enumerator = _layeredProcesses[layer].GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (!CoindexIsNull(_handleToIndex[enumerator.Current]) && SetPause(_handleToIndex[enumerator.Current], newPausedState: false))
				{
					num++;
				}
				if (Links.ContainsKey(enumerator.Current))
				{
					HashSet<CoroutineHandle> hashSet = Links[enumerator.Current];
					Links.Remove(enumerator.Current);
					HashSet<CoroutineHandle>.Enumerator enumerator2 = hashSet.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						num += ResumeCoroutines(enumerator2.Current);
					}
					Links.Add(enumerator.Current, hashSet);
				}
			}
			return num;
		}

		public static int ResumeCoroutines(string tag)
		{
			if (!(_instance == null))
			{
				return _instance.ResumeCoroutinesOnInstance(tag);
			}
			return 0;
		}

		public int ResumeCoroutinesOnInstance(string tag)
		{
			if (tag == null || !_taggedProcesses.ContainsKey(tag))
			{
				return 0;
			}
			int num = 0;
			HashSet<CoroutineHandle>.Enumerator enumerator = _taggedProcesses[tag].GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (!CoindexIsNull(_handleToIndex[enumerator.Current]) && SetPause(_handleToIndex[enumerator.Current], newPausedState: false))
				{
					num++;
				}
				if (Links.ContainsKey(enumerator.Current))
				{
					HashSet<CoroutineHandle> hashSet = Links[enumerator.Current];
					Links.Remove(enumerator.Current);
					HashSet<CoroutineHandle>.Enumerator enumerator2 = hashSet.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						num += ResumeCoroutines(enumerator2.Current);
					}
					Links.Add(enumerator.Current, hashSet);
				}
			}
			return num;
		}

		public static int ResumeCoroutines(GameObject gameObj, string tag)
		{
			if (!(_instance == null))
			{
				return _instance.ResumeCoroutinesOnInstance(gameObj.GetInstanceID(), tag);
			}
			return 0;
		}

		public int ResumeCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			if (!(gameObj == null))
			{
				return ResumeCoroutinesOnInstance(gameObj.GetInstanceID(), tag);
			}
			return 0;
		}

		public static int ResumeCoroutines(int layer, string tag)
		{
			if (!(_instance == null))
			{
				return _instance.ResumeCoroutinesOnInstance(layer, tag);
			}
			return 0;
		}

		public int ResumeCoroutinesOnInstance(int layer, string tag)
		{
			if (tag == null)
			{
				return ResumeCoroutinesOnInstance(layer);
			}
			if (!_layeredProcesses.ContainsKey(layer) || !_taggedProcesses.ContainsKey(tag))
			{
				return 0;
			}
			int num = 0;
			HashSet<CoroutineHandle>.Enumerator enumerator = _taggedProcesses[tag].GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (CoindexIsNull(_handleToIndex[enumerator.Current]) || !_layeredProcesses[layer].Contains(enumerator.Current))
				{
					continue;
				}
				if (SetPause(_handleToIndex[enumerator.Current], newPausedState: false))
				{
					num++;
				}
				if (Links.ContainsKey(enumerator.Current))
				{
					HashSet<CoroutineHandle> hashSet = Links[enumerator.Current];
					Links.Remove(enumerator.Current);
					HashSet<CoroutineHandle>.Enumerator enumerator2 = hashSet.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						num += ResumeCoroutines(enumerator2.Current);
					}
					Links.Add(enumerator.Current, hashSet);
				}
			}
			return num;
		}

		public static string GetTag(CoroutineHandle handle)
		{
			Timing instance = GetInstance(handle.Key);
			if (!(instance != null) || !instance._handleToIndex.ContainsKey(handle) || !instance._processTags.ContainsKey(handle))
			{
				return null;
			}
			return instance._processTags[handle];
		}

		public static int? GetLayer(CoroutineHandle handle)
		{
			Timing instance = GetInstance(handle.Key);
			if (!(instance != null) || !instance._handleToIndex.ContainsKey(handle) || !instance._processLayers.ContainsKey(handle))
			{
				return null;
			}
			return instance._processLayers[handle];
		}

		public static string GetDebugName(CoroutineHandle handle)
		{
			if (handle.Key == 0)
			{
				return "Uninitialized handle";
			}
			Timing instance = GetInstance(handle.Key);
			if (instance == null)
			{
				return "Invalid handle";
			}
			if (!instance._handleToIndex.ContainsKey(handle))
			{
				return "Expired coroutine";
			}
			return instance.CoindexPeek(instance._handleToIndex[handle]).ToString();
		}

		public static Segment GetSegment(CoroutineHandle handle)
		{
			Timing instance = GetInstance(handle.Key);
			if (!(instance != null) || !instance._handleToIndex.ContainsKey(handle))
			{
				return Segment.Invalid;
			}
			return instance._handleToIndex[handle].seg;
		}

		public static bool SetTag(CoroutineHandle handle, string newTag, bool overwriteExisting = true)
		{
			Timing instance = GetInstance(handle.Key);
			if (instance == null || !instance._handleToIndex.ContainsKey(handle) || instance.CoindexIsNull(instance._handleToIndex[handle]) || (!overwriteExisting && instance._processTags.ContainsKey(handle)))
			{
				return false;
			}
			instance.RemoveTagOnInstance(handle);
			instance.AddTagOnInstance(newTag, handle);
			return true;
		}

		public static bool SetLayer(CoroutineHandle handle, int newLayer, bool overwriteExisting = true)
		{
			Timing instance = GetInstance(handle.Key);
			if (instance == null || !instance._handleToIndex.ContainsKey(handle) || instance.CoindexIsNull(instance._handleToIndex[handle]) || (!overwriteExisting && instance._processLayers.ContainsKey(handle)))
			{
				return false;
			}
			instance.RemoveLayerOnInstance(handle);
			instance.AddLayerOnInstance(newLayer, handle);
			return true;
		}

		public static bool SetSegment(CoroutineHandle handle, Segment newSegment)
		{
			Timing instance = GetInstance(handle.Key);
			if (instance == null || !instance._handleToIndex.ContainsKey(handle) || instance.CoindexIsNull(instance._handleToIndex[handle]))
			{
				return false;
			}
			instance.RunCoroutineInternal(instance.CoindexExtract(instance._handleToIndex[handle]), newSegment, instance._processLayers.ContainsKey(handle) ? new int?(instance._processLayers[handle]) : null, instance._processTags.ContainsKey(handle) ? instance._processTags[handle] : null, handle, prewarm: false);
			return true;
		}

		public static bool RemoveTag(CoroutineHandle handle)
		{
			return SetTag(handle, null);
		}

		public static bool RemoveLayer(CoroutineHandle handle)
		{
			Timing instance = GetInstance(handle.Key);
			if (instance == null || !instance._handleToIndex.ContainsKey(handle) || instance.CoindexIsNull(instance._handleToIndex[handle]))
			{
				return false;
			}
			instance.RemoveLayerOnInstance(handle);
			return true;
		}

		public static bool IsRunning(CoroutineHandle handle)
		{
			Timing instance = GetInstance(handle.Key);
			if (instance != null && instance._handleToIndex.ContainsKey(handle))
			{
				return !instance.CoindexIsNull(instance._handleToIndex[handle]);
			}
			return false;
		}

		[Obsolete("Replaced with isAliveAndPaused.", false)]
		public static bool IsPaused(CoroutineHandle handle)
		{
			Timing instance = GetInstance(handle.Key);
			if (instance != null && instance._handleToIndex.ContainsKey(handle) && !instance.CoindexIsNull(instance._handleToIndex[handle]))
			{
				return !instance.CoindexIsPaused(instance._handleToIndex[handle]);
			}
			return false;
		}

		public static bool IsAliveAndPaused(CoroutineHandle handle)
		{
			Timing instance = GetInstance(handle.Key);
			if (instance != null && instance._handleToIndex.ContainsKey(handle) && !instance.CoindexIsNull(instance._handleToIndex[handle]))
			{
				return instance.CoindexIsPaused(instance._handleToIndex[handle]);
			}
			return false;
		}

		private void AddTagOnInstance(string tag, CoroutineHandle handle)
		{
			_processTags.Add(handle, tag);
			if (_taggedProcesses.ContainsKey(tag))
			{
				_taggedProcesses[tag].Add(handle);
				return;
			}
			_taggedProcesses.Add(tag, new HashSet<CoroutineHandle> { handle });
		}

		private void AddLayerOnInstance(int layer, CoroutineHandle handle)
		{
			_processLayers.Add(handle, layer);
			if (_layeredProcesses.ContainsKey(layer))
			{
				_layeredProcesses[layer].Add(handle);
				return;
			}
			_layeredProcesses.Add(layer, new HashSet<CoroutineHandle> { handle });
		}

		private void RemoveTagOnInstance(CoroutineHandle handle)
		{
			if (_processTags.ContainsKey(handle))
			{
				if (_taggedProcesses[_processTags[handle]].Count > 1)
				{
					_taggedProcesses[_processTags[handle]].Remove(handle);
				}
				else
				{
					_taggedProcesses.Remove(_processTags[handle]);
				}
				_processTags.Remove(handle);
			}
		}

		private void RemoveLayerOnInstance(CoroutineHandle handle)
		{
			if (_processLayers.ContainsKey(handle))
			{
				if (_layeredProcesses[_processLayers[handle]].Count > 1)
				{
					_layeredProcesses[_processLayers[handle]].Remove(handle);
				}
				else
				{
					_layeredProcesses.Remove(_processLayers[handle]);
				}
				_processLayers.Remove(handle);
			}
		}

		private void RemoveGraffiti(CoroutineHandle handle)
		{
			if (_processLayers.ContainsKey(handle))
			{
				if (_layeredProcesses[_processLayers[handle]].Count > 1)
				{
					_layeredProcesses[_processLayers[handle]].Remove(handle);
				}
				else
				{
					_layeredProcesses.Remove(_processLayers[handle]);
				}
				_processLayers.Remove(handle);
			}
			if (_processTags.ContainsKey(handle))
			{
				if (_taggedProcesses[_processTags[handle]].Count > 1)
				{
					_taggedProcesses[_processTags[handle]].Remove(handle);
				}
				else
				{
					_taggedProcesses.Remove(_processTags[handle]);
				}
				_processTags.Remove(handle);
			}
		}

		private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
		{
			switch (coindex.seg)
			{
			case Segment.Update:
			{
				IEnumerator<float> result9 = UpdateProcesses[coindex.i];
				UpdateProcesses[coindex.i] = null;
				return result9;
			}
			case Segment.FixedUpdate:
			{
				IEnumerator<float> result8 = FixedUpdateProcesses[coindex.i];
				FixedUpdateProcesses[coindex.i] = null;
				return result8;
			}
			case Segment.LateUpdate:
			{
				IEnumerator<float> result7 = LateUpdateProcesses[coindex.i];
				LateUpdateProcesses[coindex.i] = null;
				return result7;
			}
			case Segment.SlowUpdate:
			{
				IEnumerator<float> result6 = SlowUpdateProcesses[coindex.i];
				SlowUpdateProcesses[coindex.i] = null;
				return result6;
			}
			case Segment.RealtimeUpdate:
			{
				IEnumerator<float> result5 = RealtimeUpdateProcesses[coindex.i];
				RealtimeUpdateProcesses[coindex.i] = null;
				return result5;
			}
			case Segment.EditorUpdate:
			{
				IEnumerator<float> result4 = EditorUpdateProcesses[coindex.i];
				EditorUpdateProcesses[coindex.i] = null;
				return result4;
			}
			case Segment.EditorSlowUpdate:
			{
				IEnumerator<float> result3 = EditorSlowUpdateProcesses[coindex.i];
				EditorSlowUpdateProcesses[coindex.i] = null;
				return result3;
			}
			case Segment.EndOfFrame:
			{
				IEnumerator<float> result2 = EndOfFrameProcesses[coindex.i];
				EndOfFrameProcesses[coindex.i] = null;
				return result2;
			}
			case Segment.ManualTimeframe:
			{
				IEnumerator<float> result = ManualTimeframeProcesses[coindex.i];
				ManualTimeframeProcesses[coindex.i] = null;
				return result;
			}
			default:
				return null;
			}
		}

		private bool CoindexIsNull(ProcessIndex coindex)
		{
			return coindex.seg switch
			{
				Segment.Update => UpdateProcesses[coindex.i] == null, 
				Segment.FixedUpdate => FixedUpdateProcesses[coindex.i] == null, 
				Segment.LateUpdate => LateUpdateProcesses[coindex.i] == null, 
				Segment.SlowUpdate => SlowUpdateProcesses[coindex.i] == null, 
				Segment.RealtimeUpdate => RealtimeUpdateProcesses[coindex.i] == null, 
				Segment.EditorUpdate => EditorUpdateProcesses[coindex.i] == null, 
				Segment.EditorSlowUpdate => EditorSlowUpdateProcesses[coindex.i] == null, 
				Segment.EndOfFrame => EndOfFrameProcesses[coindex.i] == null, 
				Segment.ManualTimeframe => ManualTimeframeProcesses[coindex.i] == null, 
				_ => true, 
			};
		}

		private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
		{
			return coindex.seg switch
			{
				Segment.Update => UpdateProcesses[coindex.i], 
				Segment.FixedUpdate => FixedUpdateProcesses[coindex.i], 
				Segment.LateUpdate => LateUpdateProcesses[coindex.i], 
				Segment.SlowUpdate => SlowUpdateProcesses[coindex.i], 
				Segment.RealtimeUpdate => RealtimeUpdateProcesses[coindex.i], 
				Segment.EditorUpdate => EditorUpdateProcesses[coindex.i], 
				Segment.EditorSlowUpdate => EditorSlowUpdateProcesses[coindex.i], 
				Segment.EndOfFrame => EndOfFrameProcesses[coindex.i], 
				Segment.ManualTimeframe => ManualTimeframeProcesses[coindex.i], 
				_ => null, 
			};
		}

		private bool Nullify(CoroutineHandle handle)
		{
			return Nullify(_handleToIndex[handle]);
		}

		private bool Nullify(ProcessIndex coindex)
		{
			switch (coindex.seg)
			{
			case Segment.Update:
			{
				bool result9 = UpdateProcesses[coindex.i] != null;
				UpdateProcesses[coindex.i] = null;
				return result9;
			}
			case Segment.FixedUpdate:
			{
				bool result8 = FixedUpdateProcesses[coindex.i] != null;
				FixedUpdateProcesses[coindex.i] = null;
				return result8;
			}
			case Segment.LateUpdate:
			{
				bool result7 = LateUpdateProcesses[coindex.i] != null;
				LateUpdateProcesses[coindex.i] = null;
				return result7;
			}
			case Segment.SlowUpdate:
			{
				bool result6 = SlowUpdateProcesses[coindex.i] != null;
				SlowUpdateProcesses[coindex.i] = null;
				return result6;
			}
			case Segment.RealtimeUpdate:
			{
				bool result5 = RealtimeUpdateProcesses[coindex.i] != null;
				RealtimeUpdateProcesses[coindex.i] = null;
				return result5;
			}
			case Segment.EditorUpdate:
			{
				bool result4 = UpdateProcesses[coindex.i] != null;
				EditorUpdateProcesses[coindex.i] = null;
				return result4;
			}
			case Segment.EditorSlowUpdate:
			{
				bool result3 = EditorSlowUpdateProcesses[coindex.i] != null;
				EditorSlowUpdateProcesses[coindex.i] = null;
				return result3;
			}
			case Segment.EndOfFrame:
			{
				bool result2 = EndOfFrameProcesses[coindex.i] != null;
				EndOfFrameProcesses[coindex.i] = null;
				return result2;
			}
			case Segment.ManualTimeframe:
			{
				bool result = ManualTimeframeProcesses[coindex.i] != null;
				ManualTimeframeProcesses[coindex.i] = null;
				return result;
			}
			default:
				return false;
			}
		}

		private bool SetPause(ProcessIndex coindex, bool newPausedState)
		{
			if (CoindexPeek(coindex) == null)
			{
				return false;
			}
			switch (coindex.seg)
			{
			case Segment.Update:
			{
				bool result2 = UpdatePaused[coindex.i];
				UpdatePaused[coindex.i] = newPausedState;
				if (newPausedState && UpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					UpdateProcesses[coindex.i] = _InjectDelay(UpdateProcesses[coindex.i], UpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result2;
			}
			case Segment.FixedUpdate:
			{
				bool result6 = FixedUpdatePaused[coindex.i];
				FixedUpdatePaused[coindex.i] = newPausedState;
				if (newPausedState && FixedUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					FixedUpdateProcesses[coindex.i] = _InjectDelay(FixedUpdateProcesses[coindex.i], FixedUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result6;
			}
			case Segment.LateUpdate:
			{
				bool result3 = LateUpdatePaused[coindex.i];
				LateUpdatePaused[coindex.i] = newPausedState;
				if (newPausedState && LateUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					LateUpdateProcesses[coindex.i] = _InjectDelay(LateUpdateProcesses[coindex.i], LateUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result3;
			}
			case Segment.SlowUpdate:
			{
				bool result7 = SlowUpdatePaused[coindex.i];
				SlowUpdatePaused[coindex.i] = newPausedState;
				if (newPausedState && SlowUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					SlowUpdateProcesses[coindex.i] = _InjectDelay(SlowUpdateProcesses[coindex.i], SlowUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result7;
			}
			case Segment.RealtimeUpdate:
			{
				bool result4 = RealtimeUpdatePaused[coindex.i];
				RealtimeUpdatePaused[coindex.i] = newPausedState;
				if (newPausedState && RealtimeUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					RealtimeUpdateProcesses[coindex.i] = _InjectDelay(RealtimeUpdateProcesses[coindex.i], RealtimeUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result4;
			}
			case Segment.EditorUpdate:
			{
				bool result8 = EditorUpdatePaused[coindex.i];
				EditorUpdatePaused[coindex.i] = newPausedState;
				if (newPausedState && EditorUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					EditorUpdateProcesses[coindex.i] = _InjectDelay(EditorUpdateProcesses[coindex.i], EditorUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result8;
			}
			case Segment.EditorSlowUpdate:
			{
				bool result9 = EditorSlowUpdatePaused[coindex.i];
				EditorSlowUpdatePaused[coindex.i] = newPausedState;
				if (newPausedState && EditorSlowUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					EditorSlowUpdateProcesses[coindex.i] = _InjectDelay(EditorSlowUpdateProcesses[coindex.i], EditorSlowUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result9;
			}
			case Segment.EndOfFrame:
			{
				bool result5 = EndOfFramePaused[coindex.i];
				EndOfFramePaused[coindex.i] = newPausedState;
				if (newPausedState && EndOfFrameProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					EndOfFrameProcesses[coindex.i] = _InjectDelay(EndOfFrameProcesses[coindex.i], EndOfFrameProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result5;
			}
			case Segment.ManualTimeframe:
			{
				bool result = ManualTimeframePaused[coindex.i];
				ManualTimeframePaused[coindex.i] = newPausedState;
				if (newPausedState && ManualTimeframeProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					ManualTimeframeProcesses[coindex.i] = _InjectDelay(ManualTimeframeProcesses[coindex.i], ManualTimeframeProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result;
			}
			default:
				return false;
			}
		}

		private bool SetHeld(ProcessIndex coindex, bool newHeldState)
		{
			if (CoindexPeek(coindex) == null)
			{
				return false;
			}
			switch (coindex.seg)
			{
			case Segment.Update:
			{
				bool result2 = UpdateHeld[coindex.i];
				UpdateHeld[coindex.i] = newHeldState;
				if (newHeldState && UpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					UpdateProcesses[coindex.i] = _InjectDelay(UpdateProcesses[coindex.i], UpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result2;
			}
			case Segment.FixedUpdate:
			{
				bool result6 = FixedUpdateHeld[coindex.i];
				FixedUpdateHeld[coindex.i] = newHeldState;
				if (newHeldState && FixedUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					FixedUpdateProcesses[coindex.i] = _InjectDelay(FixedUpdateProcesses[coindex.i], FixedUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result6;
			}
			case Segment.LateUpdate:
			{
				bool result3 = LateUpdateHeld[coindex.i];
				LateUpdateHeld[coindex.i] = newHeldState;
				if (newHeldState && LateUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					LateUpdateProcesses[coindex.i] = _InjectDelay(LateUpdateProcesses[coindex.i], LateUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result3;
			}
			case Segment.SlowUpdate:
			{
				bool result7 = SlowUpdateHeld[coindex.i];
				SlowUpdateHeld[coindex.i] = newHeldState;
				if (newHeldState && SlowUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					SlowUpdateProcesses[coindex.i] = _InjectDelay(SlowUpdateProcesses[coindex.i], SlowUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result7;
			}
			case Segment.RealtimeUpdate:
			{
				bool result4 = RealtimeUpdateHeld[coindex.i];
				RealtimeUpdateHeld[coindex.i] = newHeldState;
				if (newHeldState && RealtimeUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					RealtimeUpdateProcesses[coindex.i] = _InjectDelay(RealtimeUpdateProcesses[coindex.i], RealtimeUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result4;
			}
			case Segment.EditorUpdate:
			{
				bool result8 = EditorUpdateHeld[coindex.i];
				EditorUpdateHeld[coindex.i] = newHeldState;
				if (newHeldState && EditorUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					EditorUpdateProcesses[coindex.i] = _InjectDelay(EditorUpdateProcesses[coindex.i], EditorUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result8;
			}
			case Segment.EditorSlowUpdate:
			{
				bool result9 = EditorSlowUpdateHeld[coindex.i];
				EditorSlowUpdateHeld[coindex.i] = newHeldState;
				if (newHeldState && EditorSlowUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					EditorSlowUpdateProcesses[coindex.i] = _InjectDelay(EditorSlowUpdateProcesses[coindex.i], EditorSlowUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result9;
			}
			case Segment.EndOfFrame:
			{
				bool result5 = EndOfFrameHeld[coindex.i];
				EndOfFrameHeld[coindex.i] = newHeldState;
				if (newHeldState && EndOfFrameProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					EndOfFrameProcesses[coindex.i] = _InjectDelay(EndOfFrameProcesses[coindex.i], EndOfFrameProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result5;
			}
			case Segment.ManualTimeframe:
			{
				bool result = ManualTimeframeHeld[coindex.i];
				ManualTimeframeHeld[coindex.i] = newHeldState;
				if (newHeldState && ManualTimeframeProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					ManualTimeframeProcesses[coindex.i] = _InjectDelay(ManualTimeframeProcesses[coindex.i], ManualTimeframeProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return result;
			}
			default:
				return false;
			}
		}

		private IEnumerator<float> CreateHold(ProcessIndex coindex, IEnumerator<float> coptr)
		{
			if (CoindexPeek(coindex) == null)
			{
				return null;
			}
			switch (coindex.seg)
			{
			case Segment.Update:
				UpdateHeld[coindex.i] = true;
				if (UpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					coptr = _InjectDelay(UpdateProcesses[coindex.i], UpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return coptr;
			case Segment.FixedUpdate:
				FixedUpdateHeld[coindex.i] = true;
				if (FixedUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					coptr = _InjectDelay(FixedUpdateProcesses[coindex.i], FixedUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return coptr;
			case Segment.LateUpdate:
				LateUpdateHeld[coindex.i] = true;
				if (LateUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					coptr = _InjectDelay(LateUpdateProcesses[coindex.i], LateUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return coptr;
			case Segment.SlowUpdate:
				SlowUpdateHeld[coindex.i] = true;
				if (SlowUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					coptr = _InjectDelay(SlowUpdateProcesses[coindex.i], SlowUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return coptr;
			case Segment.RealtimeUpdate:
				RealtimeUpdateHeld[coindex.i] = true;
				if (RealtimeUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					coptr = _InjectDelay(RealtimeUpdateProcesses[coindex.i], RealtimeUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return coptr;
			case Segment.EditorUpdate:
				EditorUpdateHeld[coindex.i] = true;
				if (EditorUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					coptr = _InjectDelay(EditorUpdateProcesses[coindex.i], EditorUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return coptr;
			case Segment.EditorSlowUpdate:
				EditorSlowUpdateHeld[coindex.i] = true;
				if (EditorSlowUpdateProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					coptr = _InjectDelay(EditorSlowUpdateProcesses[coindex.i], EditorSlowUpdateProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return coptr;
			case Segment.EndOfFrame:
				EndOfFrameHeld[coindex.i] = true;
				if (EndOfFrameProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					coptr = _InjectDelay(EndOfFrameProcesses[coindex.i], EndOfFrameProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return coptr;
			case Segment.ManualTimeframe:
				ManualTimeframeHeld[coindex.i] = true;
				if (ManualTimeframeProcesses[coindex.i].Current > GetSegmentTime(coindex.seg))
				{
					coptr = _InjectDelay(ManualTimeframeProcesses[coindex.i], ManualTimeframeProcesses[coindex.i].Current - GetSegmentTime(coindex.seg));
				}
				return coptr;
			default:
				return coptr;
			}
		}

		private bool CoindexIsPaused(ProcessIndex coindex)
		{
			return coindex.seg switch
			{
				Segment.Update => UpdatePaused[coindex.i], 
				Segment.FixedUpdate => FixedUpdatePaused[coindex.i], 
				Segment.LateUpdate => LateUpdatePaused[coindex.i], 
				Segment.SlowUpdate => SlowUpdatePaused[coindex.i], 
				Segment.RealtimeUpdate => RealtimeUpdatePaused[coindex.i], 
				Segment.EditorUpdate => EditorUpdatePaused[coindex.i], 
				Segment.EditorSlowUpdate => EditorSlowUpdatePaused[coindex.i], 
				Segment.EndOfFrame => EndOfFramePaused[coindex.i], 
				Segment.ManualTimeframe => ManualTimeframePaused[coindex.i], 
				_ => false, 
			};
		}

		private bool CoindexIsHeld(ProcessIndex coindex)
		{
			return coindex.seg switch
			{
				Segment.Update => UpdateHeld[coindex.i], 
				Segment.FixedUpdate => FixedUpdateHeld[coindex.i], 
				Segment.LateUpdate => LateUpdateHeld[coindex.i], 
				Segment.SlowUpdate => SlowUpdateHeld[coindex.i], 
				Segment.RealtimeUpdate => RealtimeUpdateHeld[coindex.i], 
				Segment.EditorUpdate => EditorUpdateHeld[coindex.i], 
				Segment.EditorSlowUpdate => EditorSlowUpdateHeld[coindex.i], 
				Segment.EndOfFrame => EndOfFrameHeld[coindex.i], 
				Segment.ManualTimeframe => ManualTimeframeHeld[coindex.i], 
				_ => false, 
			};
		}

		private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
		{
			switch (coindex.seg)
			{
			case Segment.Update:
				UpdateProcesses[coindex.i] = replacement;
				break;
			case Segment.FixedUpdate:
				FixedUpdateProcesses[coindex.i] = replacement;
				break;
			case Segment.LateUpdate:
				LateUpdateProcesses[coindex.i] = replacement;
				break;
			case Segment.SlowUpdate:
				SlowUpdateProcesses[coindex.i] = replacement;
				break;
			case Segment.RealtimeUpdate:
				RealtimeUpdateProcesses[coindex.i] = replacement;
				break;
			case Segment.EditorUpdate:
				EditorUpdateProcesses[coindex.i] = replacement;
				break;
			case Segment.EditorSlowUpdate:
				EditorSlowUpdateProcesses[coindex.i] = replacement;
				break;
			case Segment.EndOfFrame:
				EndOfFrameProcesses[coindex.i] = replacement;
				break;
			case Segment.ManualTimeframe:
				ManualTimeframeProcesses[coindex.i] = replacement;
				break;
			}
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine)
		{
			return WaitUntilDone(RunCoroutine(newCoroutine), warnOnIssue: true);
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine, string tag)
		{
			return WaitUntilDone(RunCoroutine(newCoroutine, tag), warnOnIssue: true);
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer)
		{
			return WaitUntilDone(RunCoroutine(newCoroutine, layer), warnOnIssue: true);
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer, string tag)
		{
			return WaitUntilDone(RunCoroutine(newCoroutine, layer, tag), warnOnIssue: true);
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment)
		{
			return WaitUntilDone(RunCoroutine(newCoroutine, segment), warnOnIssue: true);
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, string tag)
		{
			return WaitUntilDone(RunCoroutine(newCoroutine, segment, tag), warnOnIssue: true);
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer)
		{
			return WaitUntilDone(RunCoroutine(newCoroutine, segment, layer), warnOnIssue: true);
		}

		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
		{
			return WaitUntilDone(RunCoroutine(newCoroutine, segment, layer, tag), warnOnIssue: true);
		}

		public static float WaitUntilDone(CoroutineHandle otherCoroutine)
		{
			return WaitUntilDone(otherCoroutine, warnOnIssue: true);
		}

		public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
		{
			Timing instance = GetInstance(otherCoroutine.Key);
			if (instance != null && instance._handleToIndex.ContainsKey(otherCoroutine))
			{
				if (instance.CoindexIsNull(instance._handleToIndex[otherCoroutine]))
				{
					return 0f;
				}
				if (!instance._waitingTriggers.ContainsKey(otherCoroutine))
				{
					instance.CoindexReplace(instance._handleToIndex[otherCoroutine], instance._StartWhenDone(otherCoroutine, instance.CoindexPeek(instance._handleToIndex[otherCoroutine])));
					instance._waitingTriggers.Add(otherCoroutine, new HashSet<CoroutineHandle>());
				}
				if (instance.currentCoroutine == otherCoroutine)
				{
					return float.NegativeInfinity;
				}
				if (!instance.currentCoroutine.IsValid)
				{
					return float.NegativeInfinity;
				}
				instance._waitingTriggers[otherCoroutine].Add(instance.currentCoroutine);
				if (!instance._allWaiting.Contains(instance.currentCoroutine))
				{
					instance._allWaiting.Add(instance.currentCoroutine);
				}
				instance.SetHeld(instance._handleToIndex[instance.currentCoroutine], newHeldState: true);
				instance.SwapToLast(otherCoroutine, instance.currentCoroutine);
				return float.NaN;
			}
			return 0f;
		}

		public static void WaitForOtherHandles(CoroutineHandle handle, CoroutineHandle otherHandle, bool warnOnIssue = true)
		{
			if (!IsRunning(handle) || !IsRunning(otherHandle) || handle == otherHandle || handle.Key != otherHandle.Key)
			{
				return;
			}
			Timing instance = GetInstance(handle.Key);
			if (instance != null && instance._handleToIndex.ContainsKey(handle) && instance._handleToIndex.ContainsKey(otherHandle) && !instance.CoindexIsNull(instance._handleToIndex[otherHandle]))
			{
				if (!instance._waitingTriggers.ContainsKey(otherHandle))
				{
					instance.CoindexReplace(instance._handleToIndex[otherHandle], instance._StartWhenDone(otherHandle, instance.CoindexPeek(instance._handleToIndex[otherHandle])));
					instance._waitingTriggers.Add(otherHandle, new HashSet<CoroutineHandle>());
				}
				instance._waitingTriggers[otherHandle].Add(handle);
				if (!instance._allWaiting.Contains(handle))
				{
					instance._allWaiting.Add(handle);
				}
				instance.SetHeld(instance._handleToIndex[handle], newHeldState: true);
				instance.SwapToLast(otherHandle, handle);
			}
		}

		public static void WaitForOtherHandles(CoroutineHandle handle, IEnumerable<CoroutineHandle> otherHandles, bool warnOnIssue = true)
		{
			if (!IsRunning(handle))
			{
				return;
			}
			Timing instance = GetInstance(handle.Key);
			IEnumerator<CoroutineHandle> enumerator = otherHandles.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (IsRunning(enumerator.Current) && !(handle == enumerator.Current) && handle.Key == enumerator.Current.Key)
				{
					if (!instance._waitingTriggers.ContainsKey(enumerator.Current))
					{
						instance.CoindexReplace(instance._handleToIndex[enumerator.Current], instance._StartWhenDone(enumerator.Current, instance.CoindexPeek(instance._handleToIndex[enumerator.Current])));
						instance._waitingTriggers.Add(enumerator.Current, new HashSet<CoroutineHandle>());
					}
					instance._waitingTriggers[enumerator.Current].Add(handle);
					if (!instance._allWaiting.Contains(handle))
					{
						instance._allWaiting.Add(handle);
					}
					instance.SetHeld(instance._handleToIndex[handle], newHeldState: true);
					instance.SwapToLast(enumerator.Current, handle);
				}
			}
		}

		private void SwapToLast(CoroutineHandle firstHandle, CoroutineHandle lastHandle)
		{
			if (firstHandle.Key != lastHandle.Key)
			{
				return;
			}
			ProcessIndex processIndex = _handleToIndex[firstHandle];
			ProcessIndex processIndex2 = _handleToIndex[lastHandle];
			if (processIndex.seg != processIndex2.seg || processIndex.i <= processIndex2.i)
			{
				return;
			}
			IEnumerator<float> replacement = CoindexPeek(processIndex);
			CoindexReplace(processIndex, CoindexPeek(processIndex2));
			CoindexReplace(processIndex2, replacement);
			_indexToHandle[processIndex] = lastHandle;
			_indexToHandle[processIndex2] = firstHandle;
			_handleToIndex[firstHandle] = processIndex2;
			_handleToIndex[lastHandle] = processIndex;
			bool newPausedState = SetPause(processIndex, CoindexIsPaused(processIndex2));
			SetPause(processIndex2, newPausedState);
			newPausedState = SetHeld(processIndex, CoindexIsHeld(processIndex2));
			SetHeld(processIndex2, newPausedState);
			if (_waitingTriggers.ContainsKey(lastHandle))
			{
				HashSet<CoroutineHandle>.Enumerator enumerator = _waitingTriggers[lastHandle].GetEnumerator();
				while (enumerator.MoveNext())
				{
					SwapToLast(lastHandle, enumerator.Current);
				}
			}
			if (!_allWaiting.Contains(firstHandle))
			{
				return;
			}
			Dictionary<CoroutineHandle, HashSet<CoroutineHandle>>.Enumerator enumerator2 = _waitingTriggers.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				HashSet<CoroutineHandle>.Enumerator enumerator3 = enumerator2.Current.Value.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					if (enumerator3.Current == firstHandle)
					{
						SwapToLast(enumerator2.Current.Key, firstHandle);
					}
				}
			}
		}

		private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
		{
			if (!_waitingTriggers.ContainsKey(handle))
			{
				yield break;
			}
			try
			{
				if (proc.Current > localTime)
				{
					yield return proc.Current;
				}
				while (proc.MoveNext())
				{
					yield return proc.Current;
				}
			}
			finally
			{
				CloseWaitingProcess(handle);
			}
		}

		private void CloseWaitingProcess(CoroutineHandle handle)
		{
			if (!_waitingTriggers.ContainsKey(handle))
			{
				return;
			}
			HashSet<CoroutineHandle>.Enumerator enumerator = _waitingTriggers[handle].GetEnumerator();
			_waitingTriggers.Remove(handle);
			while (enumerator.MoveNext())
			{
				if (_handleToIndex.ContainsKey(enumerator.Current) && !HandleIsInWaitingList(enumerator.Current))
				{
					SetHeld(_handleToIndex[enumerator.Current], newHeldState: false);
					_allWaiting.Remove(enumerator.Current);
				}
			}
		}

		private bool HandleIsInWaitingList(CoroutineHandle handle)
		{
			Dictionary<CoroutineHandle, HashSet<CoroutineHandle>>.Enumerator enumerator = _waitingTriggers.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Value.Contains(handle))
				{
					return true;
				}
			}
			return false;
		}

		private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return _tmpRef as IEnumerator<float>;
		}

		public static float WaitUntilDone(AsyncOperation operation)
		{
			if (operation == null || operation.isDone)
			{
				return float.NaN;
			}
			CoroutineHandle key = CurrentCoroutine;
			Timing instance = GetInstance(CurrentCoroutine.Key);
			if (instance == null)
			{
				return float.NaN;
			}
			_tmpRef = _StartWhenDone(operation, instance.CoindexPeek(instance._handleToIndex[key]));
			ReplacementFunction = ReturnTmpRefForRepFunc;
			return float.NaN;
		}

		private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
		{
			while (!operation.isDone)
			{
				yield return float.NegativeInfinity;
			}
			_tmpRef = pausedProc;
			ReplacementFunction = ReturnTmpRefForRepFunc;
			yield return float.NaN;
		}

		public static float WaitUntilDone(CustomYieldInstruction operation)
		{
			if (operation == null || !operation.keepWaiting)
			{
				return float.NaN;
			}
			CoroutineHandle key = CurrentCoroutine;
			Timing instance = GetInstance(CurrentCoroutine.Key);
			if (instance == null)
			{
				return float.NaN;
			}
			_tmpRef = _StartWhenDone(operation, instance.CoindexPeek(instance._handleToIndex[key]));
			ReplacementFunction = ReturnTmpRefForRepFunc;
			return float.NaN;
		}

		private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
		{
			while (operation.keepWaiting)
			{
				yield return float.NegativeInfinity;
			}
			_tmpRef = pausedProc;
			ReplacementFunction = ReturnTmpRefForRepFunc;
			yield return float.NaN;
		}

		public static float WaitUntilTrue(Func<bool> evaluatorFunc)
		{
			if (evaluatorFunc == null || evaluatorFunc())
			{
				return float.NaN;
			}
			_tmpRef = evaluatorFunc;
			ReplacementFunction = WaitUntilTrueHelper;
			return float.NaN;
		}

		private static IEnumerator<float> WaitUntilTrueHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return _StartWhenDone(_tmpRef as Func<bool>, continueOn: false, coptr);
		}

		public static float WaitUntilFalse(Func<bool> evaluatorFunc)
		{
			if (evaluatorFunc == null || !evaluatorFunc())
			{
				return float.NaN;
			}
			_tmpRef = evaluatorFunc;
			ReplacementFunction = WaitUntilFalseHelper;
			return float.NaN;
		}

		private static IEnumerator<float> WaitUntilFalseHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return _StartWhenDone(_tmpRef as Func<bool>, continueOn: true, coptr);
		}

		private static IEnumerator<float> _StartWhenDone(Func<bool> evaluatorFunc, bool continueOn, IEnumerator<float> pausedProc)
		{
			while (evaluatorFunc() == continueOn)
			{
				yield return float.NegativeInfinity;
			}
			_tmpRef = pausedProc;
			ReplacementFunction = ReturnTmpRefForRepFunc;
			yield return float.NaN;
		}

		private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float waitTime)
		{
			yield return WaitForSecondsOnInstance(waitTime);
			_tmpRef = proc;
			ReplacementFunction = ReturnTmpRefForRepFunc;
			yield return float.NaN;
		}

		public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			if (coroutine.Key != _instanceID || key == default(CoroutineHandle) || key.Key != 0)
			{
				return false;
			}
			if (!_waitingTriggers.ContainsKey(key))
			{
				_waitingTriggers.Add(key, new HashSet<CoroutineHandle> { coroutine });
			}
			else
			{
				_waitingTriggers[key].Add(coroutine);
			}
			_allWaiting.Add(coroutine);
			SetHeld(_handleToIndex[coroutine], newHeldState: true);
			return true;
		}

		public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			if (coroutine.Key != _instanceID || key == default(CoroutineHandle) || !_handleToIndex.ContainsKey(coroutine) || !_waitingTriggers.ContainsKey(key))
			{
				return false;
			}
			if (_waitingTriggers[key].Count == 1)
			{
				_waitingTriggers.Remove(key);
			}
			else
			{
				_waitingTriggers[key].Remove(coroutine);
			}
			if (!HandleIsInWaitingList(coroutine))
			{
				SetHeld(_handleToIndex[coroutine], newHeldState: false);
				_allWaiting.Remove(coroutine);
			}
			return true;
		}

		public static int LinkCoroutines(CoroutineHandle master, CoroutineHandle slave)
		{
			if (!IsRunning(slave) || !master.IsValid)
			{
				return 0;
			}
			if (!IsRunning(master))
			{
				KillCoroutines(slave);
				return 1;
			}
			if (Links.ContainsKey(master))
			{
				if (!Links[master].Contains(slave))
				{
					Links[master].Add(slave);
					return 1;
				}
				return 0;
			}
			Links.Add(master, new HashSet<CoroutineHandle> { slave });
			return 1;
		}

		public static int UnlinkCoroutines(CoroutineHandle master, CoroutineHandle slave, bool twoWay = false)
		{
			int num = 0;
			if (Links.ContainsKey(master) && Links[master].Contains(slave))
			{
				if (Links[master].Count <= 1)
				{
					Links.Remove(master);
				}
				else
				{
					Links[master].Remove(slave);
				}
				num++;
			}
			if (twoWay && Links.ContainsKey(slave) && Links[slave].Contains(master))
			{
				if (Links[slave].Count <= 1)
				{
					Links.Remove(slave);
				}
				else
				{
					Links[slave].Remove(master);
				}
				num++;
			}
			return num;
		}

		public static float GetMyHandle(Action<CoroutineHandle> reciever)
		{
			_tmpRef = reciever;
			ReplacementFunction = GetHandleHelper;
			return float.NaN;
		}

		private static IEnumerator<float> GetHandleHelper(IEnumerator<float> input, CoroutineHandle handle)
		{
			if (_tmpRef is Action<CoroutineHandle> action)
			{
				action(handle);
			}
			return input;
		}

		public static float SwitchCoroutine(Segment newSegment)
		{
			_tmpSegment = newSegment;
			ReplacementFunction = SwitchCoroutineRepS;
			return float.NaN;
		}

		private static IEnumerator<float> SwitchCoroutineRepS(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			Timing instance = GetInstance(handle.Key);
			instance.RunCoroutineInternal(coptr, _tmpSegment, instance._processLayers.ContainsKey(handle) ? new int?(instance._processLayers[handle]) : null, instance._processTags.ContainsKey(handle) ? instance._processTags[handle] : null, handle, prewarm: false);
			return null;
		}

		public static float SwitchCoroutine(Segment newSegment, string newTag)
		{
			_tmpSegment = newSegment;
			_tmpRef = newTag;
			ReplacementFunction = SwitchCoroutineRepST;
			return float.NaN;
		}

		private static IEnumerator<float> SwitchCoroutineRepST(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			Timing instance = GetInstance(handle.Key);
			instance.RunCoroutineInternal(coptr, _tmpSegment, instance._processLayers.ContainsKey(handle) ? new int?(instance._processLayers[handle]) : null, _tmpRef as string, handle, prewarm: false);
			return null;
		}

		public static float SwitchCoroutine(Segment newSegment, int newLayer)
		{
			_tmpSegment = newSegment;
			_tmpInt = newLayer;
			ReplacementFunction = SwitchCoroutineRepSL;
			return float.NaN;
		}

		private static IEnumerator<float> SwitchCoroutineRepSL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			Timing instance = GetInstance(handle.Key);
			instance.RunCoroutineInternal(coptr, _tmpSegment, _tmpInt, instance._processTags.ContainsKey(handle) ? instance._processTags[handle] : null, handle, prewarm: false);
			return null;
		}

		public static float SwitchCoroutine(Segment newSegment, int newLayer, string newTag)
		{
			_tmpSegment = newSegment;
			_tmpInt = newLayer;
			_tmpRef = newTag;
			ReplacementFunction = SwitchCoroutineRepSLT;
			return float.NaN;
		}

		private static IEnumerator<float> SwitchCoroutineRepSLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			GetInstance(handle.Key).RunCoroutineInternal(coptr, _tmpSegment, _tmpInt, _tmpRef as string, handle, prewarm: false);
			return null;
		}

		public static float SwitchCoroutine(string newTag)
		{
			_tmpRef = newTag;
			ReplacementFunction = SwitchCoroutineRepT;
			return float.NaN;
		}

		private static IEnumerator<float> SwitchCoroutineRepT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			Timing instance = GetInstance(handle.Key);
			instance.RemoveTagOnInstance(handle);
			if (_tmpRef is string)
			{
				instance.AddTagOnInstance((string)_tmpRef, handle);
			}
			return coptr;
		}

		public static float SwitchCoroutine(int newLayer)
		{
			_tmpInt = newLayer;
			ReplacementFunction = SwitchCoroutineRepL;
			return float.NaN;
		}

		private static IEnumerator<float> SwitchCoroutineRepL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			RemoveLayer(handle);
			GetInstance(handle.Key).AddLayerOnInstance(_tmpInt, handle);
			return coptr;
		}

		public static float SwitchCoroutine(int newLayer, string newTag)
		{
			_tmpInt = newLayer;
			_tmpRef = newTag;
			ReplacementFunction = SwitchCoroutineRepLT;
			return float.NaN;
		}

		private static IEnumerator<float> SwitchCoroutineRepLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			Timing instance = GetInstance(handle.Key);
			instance.RemoveLayerOnInstance(handle);
			instance.AddLayerOnInstance(_tmpInt, handle);
			instance.RemoveTagOnInstance(handle);
			if (_tmpRef is string)
			{
				instance.AddTagOnInstance((string)_tmpRef, handle);
			}
			return coptr;
		}

		public static CoroutineHandle CallDelayed(float delay, Action action)
		{
			if (action != null)
			{
				return RunCoroutine(Instance._DelayedCall(delay, action, null));
			}
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
		{
			if (action != null)
			{
				return RunCoroutineOnInstance(_DelayedCall(delay, action, null));
			}
			return default(CoroutineHandle);
		}

		public static CoroutineHandle CallDelayed(float delay, Action action, GameObject gameObject)
		{
			if (action != null)
			{
				return RunCoroutine(Instance._DelayedCall(delay, action, gameObject), gameObject);
			}
			return default(CoroutineHandle);
		}

		public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject gameObject)
		{
			if (action != null)
			{
				return RunCoroutineOnInstance(_DelayedCall(delay, action, gameObject), gameObject);
			}
			return default(CoroutineHandle);
		}

		private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
		{
			yield return WaitForSecondsOnInstance(delay);
			if ((object)cancelWith == null || cancelWith != null)
			{
				action();
			}
		}

		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(period, action, null)));
			if (!float.IsPositiveInfinity(timeframe))
			{
				RunCoroutine(Instance._WatchCall(timeframe, coroutineHandle, null, onDone));
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(period, action, null)));
			if (!float.IsPositiveInfinity(timeframe))
			{
				RunCoroutineOnInstance(_WatchCall(timeframe, coroutineHandle, null, onDone));
			}
			return coroutineHandle;
		}

		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, GameObject gameObject, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(period, action, gameObject), gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutine(Instance._WatchCall(timeframe, coroutineHandle, gameObject, onDone), gameObject));
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, GameObject gameObject, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(period, action, gameObject), gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutineOnInstance(_WatchCall(timeframe, coroutineHandle, gameObject, onDone), gameObject));
			}
			return coroutineHandle;
		}

		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(period, action, null), timing));
			if (!float.IsPositiveInfinity(timeframe))
			{
				RunCoroutine(Instance._WatchCall(timeframe, coroutineHandle, null, onDone), timing);
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(period, action, null), timing));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutineOnInstance(_WatchCall(timeframe, coroutineHandle, null, onDone), timing));
			}
			return coroutineHandle;
		}

		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, GameObject gameObject, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(period, action, gameObject), timing, gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutine(Instance._WatchCall(timeframe, coroutineHandle, gameObject, onDone), timing, gameObject));
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, GameObject gameObject, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(period, action, gameObject), timing, gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutineOnInstance(_WatchCall(timeframe, coroutineHandle, gameObject, onDone), timing, gameObject));
			}
			return coroutineHandle;
		}

		public static CoroutineHandle CallContinuously(float timeframe, Action action, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(0f, action, null)));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutine(Instance._WatchCall(timeframe, coroutineHandle, null, onDone)));
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(0f, action, null)));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutineOnInstance(_WatchCall(timeframe, coroutineHandle, null, onDone)));
			}
			return coroutineHandle;
		}

		public static CoroutineHandle CallContinuously(float timeframe, Action action, GameObject gameObject, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(0f, action, gameObject), gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutine(Instance._WatchCall(timeframe, coroutineHandle, gameObject, onDone), gameObject));
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, GameObject gameObject, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(0f, action, gameObject), gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutineOnInstance(_WatchCall(timeframe, coroutineHandle, gameObject, onDone), gameObject));
			}
			return coroutineHandle;
		}

		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(0f, action, null), timing));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutine(Instance._WatchCall(timeframe, coroutineHandle, null, onDone), timing));
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(0f, action, null), timing));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutineOnInstance(_WatchCall(timeframe, coroutineHandle, null, onDone), timing));
			}
			return coroutineHandle;
		}

		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, GameObject gameObject, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(0f, action, gameObject), timing, gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutine(Instance._WatchCall(timeframe, coroutineHandle, gameObject, onDone), timing, gameObject));
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, GameObject gameObject, Action onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(0f, action, gameObject), timing, gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutineOnInstance(_WatchCall(timeframe, coroutineHandle, gameObject, onDone), timing, gameObject));
			}
			return coroutineHandle;
		}

		private IEnumerator<float> _WatchCall(float timeframe, CoroutineHandle handle, GameObject gObject, Action onDone)
		{
			yield return WaitForSecondsOnInstance(timeframe);
			KillCoroutinesOnInstance(handle);
			if (onDone != null && ((object)gObject == null || gObject != null))
			{
				onDone();
			}
		}

		private IEnumerator<float> _CallContinuously(float period, Action action, GameObject gObject)
		{
			while ((object)gObject == null || gObject != null)
			{
				yield return WaitForSecondsOnInstance(period);
				if ((object)gObject == null || (gObject != null && gObject.activeInHierarchy))
				{
					action();
				}
			}
		}

		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(reference, period, action, null)));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutine(Instance._WatchCall(reference, timeframe, coroutineHandle, null, onDone)));
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(reference, period, action, null)));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutineOnInstance(_WatchCall(reference, timeframe, coroutineHandle, null, onDone)));
			}
			return coroutineHandle;
		}

		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(reference, period, action, gameObject), gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutine(Instance._WatchCall(reference, timeframe, coroutineHandle, gameObject, onDone), gameObject));
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(reference, period, action, gameObject), gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutineOnInstance(_WatchCall(reference, timeframe, coroutineHandle, gameObject, onDone), gameObject));
			}
			return coroutineHandle;
		}

		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(reference, period, action, null), timing));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutine(Instance._WatchCall(reference, timeframe, coroutineHandle, null, onDone), timing));
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(reference, period, action, null), timing));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutineOnInstance(_WatchCall(reference, timeframe, coroutineHandle, null, onDone), timing));
			}
			return coroutineHandle;
		}

		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(reference, period, action, gameObject), timing, gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutine(Instance._WatchCall(reference, timeframe, coroutineHandle, gameObject, onDone), timing, gameObject));
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(reference, period, action, gameObject), timing, gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutineOnInstance(_WatchCall(reference, timeframe, coroutineHandle, gameObject, onDone), timing, gameObject));
			}
			return coroutineHandle;
		}

		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(reference, 0f, action, null)));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutine(Instance._WatchCall(reference, timeframe, coroutineHandle, null, onDone)));
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(reference, 0f, action, null)));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutineOnInstance(_WatchCall(reference, timeframe, coroutineHandle, null, onDone)));
			}
			return coroutineHandle;
		}

		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(reference, 0f, action, gameObject), gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutine(Instance._WatchCall(reference, timeframe, coroutineHandle, gameObject, onDone), gameObject));
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(reference, 0f, action, gameObject), gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutineOnInstance(_WatchCall(reference, timeframe, coroutineHandle, gameObject, onDone), gameObject));
			}
			return coroutineHandle;
		}

		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(reference, 0f, action, null), timing));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutine(Instance._WatchCall(reference, timeframe, coroutineHandle, null, onDone), timing));
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(reference, 0f, action, null), timing));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutineOnInstance(_WatchCall(reference, timeframe, coroutineHandle, null, onDone), timing));
			}
			return coroutineHandle;
		}

		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutine(Instance._CallContinuously(reference, 0f, action, gameObject), timing, gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutine(Instance._WatchCall(reference, timeframe, coroutineHandle, gameObject, onDone), timing, gameObject));
			}
			return coroutineHandle;
		}

		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, Action<T> onDone = null)
		{
			CoroutineHandle coroutineHandle = ((action == null) ? default(CoroutineHandle) : RunCoroutineOnInstance(_CallContinuously(reference, 0f, action, gameObject), timing, gameObject));
			if (!float.IsPositiveInfinity(timeframe))
			{
				LinkCoroutines(coroutineHandle, RunCoroutineOnInstance(_WatchCall(reference, timeframe, coroutineHandle, gameObject, onDone), timing, gameObject));
			}
			return coroutineHandle;
		}

		private IEnumerator<float> _WatchCall<T>(T reference, float timeframe, CoroutineHandle handle, GameObject gObject, Action<T> onDone)
		{
			yield return WaitForSecondsOnInstance(timeframe);
			KillCoroutinesOnInstance(handle);
			if (onDone != null && ((object)gObject == null || gObject != null))
			{
				onDone(reference);
			}
		}

		private IEnumerator<float> _CallContinuously<T>(T reference, float period, Action<T> action, GameObject gObject)
		{
			while ((object)gObject == null || gObject != null)
			{
				yield return WaitForSecondsOnInstance(period);
				if ((object)gObject == null || (gObject != null && gObject.activeInHierarchy))
				{
					action(reference);
				}
			}
		}

		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}

		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		[Obsolete("Unity coroutine function, use RunCoroutine instead.", true)]
		public new Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopCoroutine(string methodName)
		{
		}

		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopCoroutine(IEnumerator routine)
		{
		}

		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopCoroutine(Coroutine routine)
		{
		}

		[Obsolete("Unity coroutine function, use KillCoroutines instead.", true)]
		public new void StopAllCoroutines()
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Destroy(UnityEngine.Object obj)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Destroy(UnityEngine.Object obj, float f)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void DestroyObject(UnityEngine.Object obj)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void DestroyObject(UnityEngine.Object obj, float f)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void DestroyImmediate(UnityEngine.Object obj)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Instantiate(UnityEngine.Object obj)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
		{
		}

		[Obsolete("Use your own GameObject for this.", true)]
		public new static void Instantiate<T>(T original) where T : UnityEngine.Object
		{
		}

		[Obsolete("Just.. no.", true)]
		public new static T FindObjectOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Obsolete("Just.. no.", true)]
		public new static UnityEngine.Object FindObjectOfType(Type t)
		{
			return null;
		}

		[Obsolete("Just.. no.", true)]
		public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Obsolete("Just.. no.", true)]
		public new static UnityEngine.Object[] FindObjectsOfType(Type t)
		{
			return null;
		}

		[Obsolete("Just.. no.", true)]
		public new static void print(object message)
		{
		}
	}
	public enum Segment
	{
		Invalid = -1,
		Update,
		FixedUpdate,
		LateUpdate,
		SlowUpdate,
		RealtimeUpdate,
		EditorUpdate,
		EditorSlowUpdate,
		EndOfFrame,
		ManualTimeframe
	}
	public enum DebugInfoType
	{
		None,
		SeperateCoroutines,
		SeperateTags
	}
	public enum SingletonBehavior
	{
		Abort,
		Overwrite,
		Wait
	}
	public struct CoroutineHandle : IEquatable<CoroutineHandle>
	{
		private const byte ReservedSpace = 15;

		private static readonly int[] NextIndex = new int[16]
		{
			16, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0
		};

		private readonly int _id;

		public byte Key => (byte)((uint)_id & 0xFu);

		public string Tag
		{
			get
			{
				return Timing.GetTag(this);
			}
			set
			{
				Timing.SetTag(this, value);
			}
		}

		public int? Layer
		{
			get
			{
				return Timing.GetLayer(this);
			}
			set
			{
				if (!value.HasValue)
				{
					Timing.RemoveLayer(this);
				}
				else
				{
					Timing.SetLayer(this, value.Value);
				}
			}
		}

		public Segment Segment
		{
			get
			{
				return Timing.GetSegment(this);
			}
			set
			{
				Timing.SetSegment(this, value);
			}
		}

		public bool IsRunning
		{
			get
			{
				return Timing.IsRunning(this);
			}
			set
			{
				if (!value)
				{
					Timing.KillCoroutines(this);
				}
			}
		}

		[Obsolete("This value was inverted. Replaced with IsAliveAndPaused which is not inverted.", false)]
		public bool IsPaused
		{
			get
			{
				return Timing.IsPaused(this);
			}
			set
			{
				if (value)
				{
					Timing.PauseCoroutines(this);
				}
				else
				{
					Timing.ResumeCoroutines(this);
				}
			}
		}

		public bool IsAliveAndPaused
		{
			get
			{
				return Timing.IsAliveAndPaused(this);
			}
			set
			{
				if (value)
				{
					Timing.PauseCoroutines(this);
				}
				else
				{
					Timing.ResumeCoroutines(this);
				}
			}
		}

		public bool IsValid => Key != 0;

		public CoroutineHandle(byte ind)
		{
			if (ind > 15)
			{
				ind -= 15;
			}
			_id = NextIndex[ind] + ind;
			NextIndex[ind] += 16;
		}

		public bool Equals(CoroutineHandle other)
		{
			return _id == other._id;
		}

		public override bool Equals(object other)
		{
			if (other is CoroutineHandle)
			{
				return Equals((CoroutineHandle)other);
			}
			return false;
		}

		public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
		{
			return a._id == b._id;
		}

		public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
		{
			return a._id != b._id;
		}

		public override int GetHashCode()
		{
			return _id;
		}

		public override string ToString()
		{
			if (Timing.GetTag(this) == null)
			{
				if (!Timing.GetLayer(this).HasValue)
				{
					return Timing.GetDebugName(this);
				}
				return Timing.GetDebugName(this) + " Layer: " + Timing.GetLayer(this);
			}
			if (!Timing.GetLayer(this).HasValue)
			{
				return Timing.GetDebugName(this) + " Tag: " + Timing.GetTag(this);
			}
			return Timing.GetDebugName(this) + " Tag: " + Timing.GetTag(this) + " Layer: " + Timing.GetLayer(this);
		}
	}
}
namespace TBUnityLib.Generic
{
	public struct Pair<T>
	{
		private T first;

		private T second;

		public T First
		{
			get
			{
				return first;
			}
			set
			{
				first = value;
			}
		}

		public T Second
		{
			get
			{
				return second;
			}
			set
			{
				second = value;
			}
		}

		public Pair(T first, T second)
		{
			this.first = first;
			this.second = second;
		}

		public override string ToString()
		{
			return string.Concat("[", First, ",", Second, "]");
		}
	}
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Helper
	{
		public static void SplitPairArray<T>(Pair<T>[] vector3Pairs, out T[] outFirstVector3, out T[] outSecondVector3)
		{
			T[] array = new T[vector3Pairs.Length];
			T[] array2 = new T[vector3Pairs.Length];
			for (int i = 0; i < vector3Pairs.Length; i++)
			{
				array[i] = vector3Pairs[i].First;
				array2[i] = vector3Pairs[i].Second;
			}
			outFirstVector3 = array;
			outSecondVector3 = array2;
		}

		public static void SetActiveRecursively(GameObject rootObject, bool active)
		{
			rootObject.SetActive(active);
			foreach (Transform item in rootObject.transform)
			{
				SetActiveRecursively(item.gameObject, active);
			}
		}
	}
	public struct FunctionAsParameter
	{
		private readonly string name;

		private readonly MethodInfo methodInfo;

		private readonly object[] methodParameters;

		private readonly object classObject;

		public FunctionAsParameter(object classObject, MethodInfo methodInfo, object[] methodParameters)
		{
			this.classObject = classObject;
			this.methodInfo = methodInfo;
			this.methodParameters = methodParameters;
			name = "";
		}

		public FunctionAsParameter(object classObject, MethodInfo methodInfo, object[] methodParameters, string name)
		{
			this.classObject = classObject;
			this.methodInfo = methodInfo;
			this.methodParameters = methodParameters;
			this.name = name;
		}

		public string GetName()
		{
			return name;
		}

		public object Invoke()
		{
			return methodInfo.Invoke(classObject, methodParameters);
		}
	}
	[Serializable]
	public struct BoundedValue
	{
		[SerializeField]
		private double value;

		[SerializeField]
		private double lowerBound;

		[SerializeField]
		private double upperBound;

		public double UpperBound
		{
			get
			{
				return upperBound;
			}
			set
			{
				upperBound = value;
			}
		}

		public double LowerBound
		{
			get
			{
				return lowerBound;
			}
			set
			{
				lowerBound = value;
			}
		}

		public double Value
		{
			get
			{
				if (value.CompareTo(lowerBound) < 0)
				{
					value = lowerBound;
				}
				else if (value.CompareTo(upperBound) > 0)
				{
					value = upperBound;
				}
				return value;
			}
			set
			{
				if (value.CompareTo(lowerBound) < 0)
				{
					this.value = lowerBound;
				}
				else if (value.CompareTo(upperBound) > 0)
				{
					this.value = upperBound;
				}
				else
				{
					this.value = value;
				}
			}
		}

		public BoundedValue(double value, double lowerBound, double upperBound)
		{
			this.value = value;
			this.lowerBound = lowerBound;
			this.upperBound = upperBound;
		}
	}
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct StringFactory
	{
		public static bool RemoveDirectoriesBefore(string path, string removeThisDirectoryAndAllParentDirectorys, out string trimmedPath)
		{
			string text = "";
			string text2 = "";
			int i = 0;
			int num = 0;
			for (; i < path.Length; i++)
			{
				if (path[i] != removeThisDirectoryAndAllParentDirectorys[num])
				{
					continue;
				}
				text += path[i];
				num++;
				if (!(text != removeThisDirectoryAndAllParentDirectorys))
				{
					for (int j = i + 1; j < path.Length; j++)
					{
						text2 += path[j];
					}
					break;
				}
			}
			trimmedPath = text2;
			return text2 != "";
		}

		public static string RemoveDirectoriesBefore(string path, string removeThisDirectoryAndAllParentDirectorys)
		{
			string trimmedPath = "";
			if (!RemoveDirectoriesBefore(path, removeThisDirectoryAndAllParentDirectorys, out trimmedPath))
			{
				return "";
			}
			return trimmedPath;
		}

		public static string RemoveFileNameExtension(string Path)
		{
			string text = "";
			int num = 0;
			for (int num2 = Path.Length - 1; num2 > 0; num2--)
			{
				if (Path[num2].ToString() == ".")
				{
					num = num2;
				}
			}
			for (int i = 0; i < num; i++)
			{
				text += Path[i];
			}
			if (text == "")
			{
				text = Path;
			}
			return text;
		}
	}
}
namespace TBUnityLib.MeshTools
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Geometry
	{
		public static Mesh GeneratePlaneMesh(int xSegments, int zSegments, float xSize, float zSize)
		{
			Mesh mesh = new Mesh();
			List<Vector3> list = new List<Vector3>();
			List<Vector3> list2 = new List<Vector3>();
			List<Vector2> list3 = new List<Vector2>();
			List<int> list4 = new List<int>();
			for (int i = 0; i <= xSegments; i++)
			{
				for (int j = 0; j <= zSegments; j++)
				{
					float num = 0f + xSize / (float)xSegments * (float)i;
					float num2 = 0f + zSize / (float)zSegments * (float)j;
					float y = 0f;
					num -= xSize / 2f;
					num2 -= zSize / 2f;
					list.Add(new Vector3(num, y, num2));
					float x = 1f - (float)(i / xSegments);
					float y2 = 1f - (float)(j / zSegments);
					list3.Add(new Vector2(x, y2));
					list2.Add(Vector3.up);
				}
			}
			int k = 0;
			int num3 = 0;
			for (; k < xSegments * zSegments; k++)
			{
				list4.Add(k + num3 + 1);
				list4.Add(zSegments + k + num3 + 1);
				list4.Add(k + num3);
				list4.Add(k + num3 + 1);
				list4.Add(zSegments + k + num3 + 2);
				list4.Add(zSegments + k + 1 + num3);
				if (k % zSegments + 1 == zSegments)
				{
					num3++;
				}
			}
			mesh.vertices = list.ToArray();
			mesh.normals = list2.ToArray();
			mesh.uv = list3.ToArray();
			mesh.triangles = list4.ToArray();
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
			return mesh;
		}

		public static Mesh GeneratePlaneMesh(int xSegments, int zSegments, Vector2 planeSize)
		{
			return GeneratePlaneMesh(xSegments, zSegments, planeSize.x, planeSize.y);
		}

		public static Mesh GeneratePlaneMesh(Vector2 planeSize)
		{
			return GeneratePlaneMesh(1, 1, planeSize.x, planeSize.y);
		}

		public static Mesh GeneratePlaneMesh(float xSize, float zSize)
		{
			return GeneratePlaneMesh(1, 1, xSize, zSize);
		}

		public static Mesh GeneratePlaneMesh(Vector3 planeSize)
		{
			return GeneratePlaneMesh(1, 1, planeSize.x, planeSize.z);
		}

		public static Mesh GeneratePlaneMesh(Vector3 topLeft, Vector3 topRight, Vector3 bottomLeft, Vector3 bottomRight, bool flipNormals)
		{
			Mesh mesh = new Mesh();
			List<Vector3> list = new List<Vector3>();
			List<int> list2 = new List<int>();
			List<Vector2> list3 = new List<Vector2>();
			list.Add(topLeft);
			list.Add(topRight);
			list.Add(bottomLeft);
			list.Add(bottomRight);
			list2.Add(0);
			list2.Add(1);
			list2.Add(2);
			list2.Add(2);
			list2.Add(1);
			list2.Add(3);
			list3.Add(new Vector2(1f, 1f));
			list3.Add(new Vector2(1f, 0f));
			list3.Add(new Vector2(0f, 1f));
			list3.Add(new Vector2(0f, 0f));
			if (flipNormals)
			{
				list2.Reverse();
			}
			mesh.vertices = list.ToArray();
			mesh.triangles = list2.ToArray();
			mesh.uv = list3.ToArray();
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
			return mesh;
		}

		public static Mesh GeneratePlaneMesh(Vector3 topLeft, Vector3 topRight, Vector3 bottomLeft, Vector3 bottomRight)
		{
			return GeneratePlaneMesh(topLeft, topRight, bottomLeft, bottomRight, flipNormals: false);
		}

		public static Mesh GeneratePlaneEdge(Vector2 planeSize, float depth)
		{
			return GenerateHalfCube(planeSize.x, planeSize.y, depth, cap: false);
		}

		public static Mesh GeneratePlaneEdge(float planeSizeX, float planeSizeY, float depth)
		{
			return GenerateHalfCube(planeSizeX, planeSizeY, depth, cap: false);
		}

		public static Mesh GenerateTetrahedron(float topPlaneSizeX, float topPlaneSizeZ, float depth, float bottomPlaneSizeX, float bottomPlaneSizeZ, bool capTop = true, bool capBottom = true)
		{
			Mesh mesh = new Mesh();
			List<Vector3> list = new List<Vector3>();
			List<int> list2 = new List<int>();
			List<Vector2> list3 = new List<Vector2>();
			list.Add(new Vector3(topPlaneSizeX / 2f, 0f, topPlaneSizeZ / 2f));
			list.Add(new Vector3(topPlaneSizeX / 2f, 0f, (0f - topPlaneSizeZ) / 2f));
			list.Add(new Vector3(bottomPlaneSizeX / 2f, 0f - depth, bottomPlaneSizeZ / 2f));
			list.Add(new Vector3(bottomPlaneSizeX / 2f, 0f - depth, (0f - bottomPlaneSizeZ) / 2f));
			list3.Add(new Vector2(1f, 1f));
			list3.Add(new Vector2(0f, 1f));
			list3.Add(new Vector2(1f, 0f));
			list3.Add(new Vector2(0f, 0f));
			list2.Add(1);
			list2.Add(0);
			list2.Add(2);
			list2.Add(2);
			list2.Add(3);
			list2.Add(1);
			list.Add(new Vector3(topPlaneSizeX / 2f, 0f, topPlaneSizeZ / 2f));
			list.Add(new Vector3((0f - topPlaneSizeX) / 2f, 0f, topPlaneSizeZ / 2f));
			list.Add(new Vector3(bottomPlaneSizeX / 2f, 0f - depth, bottomPlaneSizeZ / 2f));
			list.Add(new Vector3((0f - bottomPlaneSizeX) / 2f, 0f - depth, bottomPlaneSizeZ / 2f));
			list3.Add(new Vector2(1f, 1f));
			list3.Add(new Vector2(0f, 1f));
			list3.Add(new Vector2(1f, 0f));
			list3.Add(new Vector2(0f, 0f));
			list2.Add(6);
			list2.Add(4);
			list2.Add(5);
			list2.Add(5);
			list2.Add(7);
			list2.Add(6);
			list.Add(new Vector3((0f - topPlaneSizeX) / 2f, 0f, topPlaneSizeZ / 2f));
			list.Add(new Vector3((0f - topPlaneSizeX) / 2f, 0f, (0f - topPlaneSizeZ) / 2f));
			list.Add(new Vector3((0f - bottomPlaneSizeX) / 2f, 0f - depth, bottomPlaneSizeZ / 2f));
			list.Add(new Vector3((0f - bottomPlaneSizeX) / 2f, 0f - depth, (0f - bottomPlaneSizeZ) / 2f));
			list3.Add(new Vector2(1f, 1f));
			list3.Add(new Vector2(0f, 1f));
			list3.Add(new Vector2(1f, 0f));
			list3.Add(new Vector2(0f, 0f));
			list2.Add(10);
			list2.Add(8);
			list2.Add(9);
			list2.Add(9);
			list2.Add(11);
			list2.Add(10);
			list.Add(new Vector3(topPlaneSizeX / 2f, 0f, (0f - topPlaneSizeZ) / 2f));
			list.Add(new Vector3((0f - topPlaneSizeX) / 2f, 0f, (0f - topPlaneSizeZ) / 2f));
			list.Add(new Vector3(bottomPlaneSizeX / 2f, 0f - depth, (0f - bottomPlaneSizeZ) / 2f));
			list.Add(new Vector3((0f - bottomPlaneSizeX) / 2f, 0f - depth, (0f - bottomPlaneSizeZ) / 2f));
			list3.Add(new Vector2(1f, 1f));
			list3.Add(new Vector2(0f, 1f));
			list3.Add(new Vector2(1f, 0f));
			list3.Add(new Vector2(0f, 0f));
			list2.Add(13);
			list2.Add(12);
			list2.Add(14);
			list2.Add(14);
			list2.Add(15);
			list2.Add(13);
			if (capTop)
			{
				list.Add(new Vector3(topPlaneSizeX / 2f, 0f, (0f - topPlaneSizeZ) / 2f));
				list.Add(new Vector3((0f - topPlaneSizeX) / 2f, 0f, (0f - topPlaneSizeZ) / 2f));
				list.Add(new Vector3(topPlaneSizeX / 2f, 0f, topPlaneSizeZ / 2f));
				list.Add(new Vector3((0f - topPlaneSizeX) / 2f, 0f, topPlaneSizeZ / 2f));
				list3.Add(new Vector2(1f, 1f));
				list3.Add(new Vector2(0f, 1f));
				list3.Add(new Vector2(1f, 0f));
				list3.Add(new Vector2(0f, 0f));
				list2.Add(17);
				list2.Add(19);
				list2.Add(18);
				list2.Add(18);
				list2.Add(16);
				list2.Add(17);
			}
			if (capBottom)
			{
				int num = (capTop ? 4 : 0);
				list.Add(new Vector3(bottomPlaneSizeX / 2f, 0f - depth, (0f - bottomPlaneSizeZ) / 2f));
				list.Add(new Vector3((0f - bottomPlaneSizeX) / 2f, 0f - depth, (0f - bottomPlaneSizeZ) / 2f));
				list.Add(new Vector3(bottomPlaneSizeX / 2f, 0f - depth, bottomPlaneSizeZ / 2f));
				list.Add(new Vector3((0f - bottomPlaneSizeX) / 2f, 0f - depth, bottomPlaneSizeZ / 2f));
				list3.Add(new Vector2(1f, 1f));
				list3.Add(new Vector2(0f, 1f));
				list3.Add(new Vector2(1f, 0f));
				list3.Add(new Vector2(0f, 0f));
				list2.Add(19 + num);
				list2.Add(17 + num);
				list2.Add(18 + num);
				list2.Add(17 + num);
				list2.Add(16 + num);
				list2.Add(18 + num);
			}
			mesh.vertices = list.ToArray();
			mesh.triangles = list2.ToArray();
			mesh.uv = list3.ToArray();
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
			return mesh;
		}

		public static Mesh GenerateHalfCube(float planeSizeX, float planeSizeY, float depth, bool cap)
		{
			Mesh mesh = new Mesh();
			List<Vector3> list = new List<Vector3>();
			List<int> list2 = new List<int>();
			List<Vector2> list3 = new List<Vector2>();
			list.Add(new Vector3(planeSizeX / 2f, 0f, planeSizeY / 2f));
			list.Add(new Vector3(planeSizeX / 2f, 0f, (0f - planeSizeY) / 2f));
			list.Add(new Vector3(planeSizeX / 2f, 0f - depth, planeSizeY / 2f));
			list.Add(new Vector3(planeSizeX / 2f, 0f - depth, (0f - planeSizeY) / 2f));
			list3.Add(new Vector2(1f, 1f));
			list3.Add(new Vector2(0f, 1f));
			list3.Add(new Vector2(1f, 0f));
			list3.Add(new Vector2(0f, 0f));
			list2.Add(1);
			list2.Add(0);
			list2.Add(2);
			list2.Add(2);
			list2.Add(3);
			list2.Add(1);
			list.Add(new Vector3(planeSizeX / 2f, 0f, planeSizeY / 2f));
			list.Add(new Vector3((0f - planeSizeX) / 2f, 0f, planeSizeY / 2f));
			list.Add(new Vector3(planeSizeX / 2f, 0f - depth, planeSizeY / 2f));
			list.Add(new Vector3((0f - planeSizeX) / 2f, 0f - depth, planeSizeY / 2f));
			list3.Add(new Vector2(1f, 1f));
			list3.Add(new Vector2(0f, 1f));
			list3.Add(new Vector2(1f, 0f));
			list3.Add(new Vector2(0f, 0f));
			list2.Add(6);
			list2.Add(4);
			list2.Add(5);
			list2.Add(5);
			list2.Add(7);
			list2.Add(6);
			list.Add(new Vector3((0f - planeSizeX) / 2f, 0f, planeSizeY / 2f));
			list.Add(new Vector3((0f - planeSizeX) / 2f, 0f, (0f - planeSizeY) / 2f));
			list.Add(new Vector3((0f - planeSizeX) / 2f, 0f - depth, planeSizeY / 2f));
			list.Add(new Vector3((0f - planeSizeX) / 2f, 0f - depth, (0f - planeSizeY) / 2f));
			list3.Add(new Vector2(1f, 1f));
			list3.Add(new Vector2(0f, 1f));
			list3.Add(new Vector2(1f, 0f));
			list3.Add(new Vector2(0f, 0f));
			list2.Add(10);
			list2.Add(8);
			list2.Add(9);
			list2.Add(9);
			list2.Add(11);
			list2.Add(10);
			list.Add(new Vector3(planeSizeX / 2f, 0f, (0f - planeSizeY) / 2f));
			list.Add(new Vector3((0f - planeSizeX) / 2f, 0f, (0f - planeSizeY) / 2f));
			list.Add(new Vector3(planeSizeX / 2f, 0f - depth, (0f - planeSizeY) / 2f));
			list.Add(new Vector3((0f - planeSizeX) / 2f, 0f - depth, (0f - planeSizeY) / 2f));
			list3.Add(new Vector2(1f, 1f));
			list3.Add(new Vector2(0f, 1f));
			list3.Add(new Vector2(1f, 0f));
			list3.Add(new Vector2(0f, 0f));
			list2.Add(13);
			list2.Add(12);
			list2.Add(14);
			list2.Add(14);
			list2.Add(15);
			list2.Add(13);
			if (cap)
			{
				list.Add(new Vector3(planeSizeX / 2f, 0f, planeSizeY / 2f));
				list.Add(new Vector3(planeSizeX / 2f, 0f, (0f - planeSizeY) / 2f));
				list.Add(new Vector3((0f - planeSizeX) / 2f, 0f, planeSizeY / 2f));
				list.Add(new Vector3((0f - planeSizeX) / 2f, 0f, (0f - planeSizeY) / 2f));
				list3.Add(new Vector2(1f, 1f));
				list3.Add(new Vector2(0f, 1f));
				list3.Add(new Vector2(1f, 0f));
				list3.Add(new Vector2(0f, 0f));
				list2.Add(18);
				list2.Add(16);
				list2.Add(17);
				list2.Add(17);
				list2.Add(19);
				list2.Add(18);
			}
			mesh.vertices = list.ToArray();
			mesh.triangles = list2.ToArray();
			mesh.uv = list3.ToArray();
			mesh.normals = list.ToArray();
			mesh.RecalculateNormals();
			mesh.RecalculateBounds();
			return mesh;
		}

		public static Mesh GenerateHalfCube(Vector2 planeSize, float depth)
		{
			return GenerateHalfCube(planeSize.x, planeSize.y, depth, cap: true);
		}

		public static Mesh GenerateHalfCube(float planeSizeX, float planeSizeY, float depth)
		{
			return GenerateHalfCube(planeSizeX, planeSizeY, depth, cap: true);
		}

		public static Mesh GenerateStrip(Pair<Vector3>[] vertexData, Transform transform, string meshName)
		{
			Vector3[] outFirstVector = new Vector3[vertexData.Length];
			Vector3[] outSecondVector = new Vector3[vertexData.Length];
			Helper.SplitPairArray(vertexData, out outFirstVector, out outSecondVector);
			return GenerateStrip(outFirstVector, outSecondVector, transform, flipNormals: false, null, meshName);
		}

		public static Mesh GenerateStrip(Pair<Vector3>[] vertexData, Transform transform)
		{
			Vector3[] outFirstVector = new Vector3[vertexData.Length];
			Vector3[] outSecondVector = new Vector3[vertexData.Length];
			Helper.SplitPairArray(vertexData, out outFirstVector, out outSecondVector);
			return GenerateStrip(outFirstVector, outSecondVector, transform, flipNormals: false, null, "");
		}

		public static Mesh GenerateStrip(Pair<Vector3>[] vertexData, Transform transform, bool flipNormals, bool? offsetMode, string meshName)
		{
			Vector3[] outFirstVector = new Vector3[vertexData.Length];
			Vector3[] outSecondVector = new Vector3[vertexData.Length];
			Helper.SplitPairArray(vertexData, out outFirstVector, out outSecondVector);
			return GenerateStrip(outFirstVector, outSecondVector, transform, flipNormals, offsetMode, meshName);
		}

		public static Mesh GenerateStrip(Vector3[] vertexDataFirst, Vector3[] vertexDataSecond, Transform transform, bool flipNormals, bool? offsetMode, string meshName)
		{
			Mesh mesh = new Mesh();
			List<Vector3> list = new List<Vector3>();
			List<Vector3> list2 = new List<Vector3>();
			List<Vector2> list3 = new List<Vector2>();
			List<int> list4 = new List<int>();
			for (int i = 0; i < vertexDataFirst.Length; i++)
			{
				int num = i % 2;
				Quaternion quaternion = Quaternion.AngleAxis(transform.rotation.y, Vector3.up);
				Vector3 item = quaternion * vertexDataFirst[i];
				Vector3 item2 = quaternion * vertexDataSecond[i];
				if (offsetMode.HasValue)
				{
					if (offsetMode == false)
					{
						item -= transform.position;
						item2 -= transform.position;
					}
					else if (offsetMode == true)
					{
						item += transform.position;
						item2 += transform.position;
					}
				}
				list.Add(item);
				list2.Add(Vector3.up);
				if (num == 0)
				{
					list3.Add(new Vector2(0f, 0f));
				}
				else
				{
					list3.Add(new Vector2(1f, 0f));
				}
				list.Add(item2);
				list2.Add(Vector3.up);
				if (num == 0)
				{
					list3.Add(new Vector2(0f, 1f));
				}
				else
				{
					list3.Add(new Vector2(1f, 1f));
				}
			}
			int num2 = 0;
			for (int j = 0; j < vertexDataFirst.Length - 1; j++)
			{
				list4.Add(num2);
				list4.Add(num2 + 2);
				list4.Add(num2 + 1);
				list4.Add(num2 + 1);
				list4.Add(num2 + 2);
				list4.Add(num2 + 3);
				num2 += 2;
			}
			if (flipNormals)
			{
				list4.Reverse();
			}
			mesh.vertices = list.ToArray();
			mesh.normals = list2.ToArray();
			mesh.triangles = list4.ToArray();
			mesh.uv = list3.ToArray();
			mesh.name = meshName;
			mesh.RecalculateBounds();
			mesh.RecalculateNormals();
			return mesh;
		}
	}
}
namespace TBUnityLib.TerrainTools
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Coordinates
	{
		public static Vector2 WorldToTerrainCoords(Vector3 nodeLocation, Terrain terrain)
		{
			return WorldToTerrainCoords(nodeLocation, terrain.terrainData.size, terrain.terrainData.alphamapResolution);
		}

		public static Vector2 WorldToTerrainCoords(Vector3 nodeLocation, Vector3 terrainSize, int terrainAlphaMapResolution)
		{
			float num = nodeLocation.z / terrainSize.x * (float)terrainAlphaMapResolution;
			float num2 = nodeLocation.x / terrainSize.z * (float)terrainAlphaMapResolution;
			return new Vector2((int)num, (int)num2);
		}

		public static Vector3 TerrainToWorldCoords(int x, int y, Terrain terrain, bool mapToTerrainHeight)
		{
			float x2 = (float)y / (float)terrain.terrainData.alphamapResolution * terrain.terrainData.size.x;
			float z = (float)x / (float)terrain.terrainData.alphamapResolution * terrain.terrainData.size.z;
			if (!mapToTerrainHeight)
			{
				return new Vector3(x2, 0f, z);
			}
			float height = terrain.terrainData.GetHeight(x, y);
			return new Vector3(x2, height, z);
		}

		public static Vector3 TerrainToWorldCoords(int x, int y, int alphaMapResolution, Vector3 terrainSize)
		{
			float x2 = (float)y / (float)alphaMapResolution * terrainSize.x;
			float z = (float)x / (float)alphaMapResolution * terrainSize.z;
			return new Vector3(x2, 0f, z);
		}

		public static Vector3 TerrainToWorldCoords(int x, int y, Terrain terrain)
		{
			return TerrainToWorldCoords(x, y, terrain, mapToTerrainHeight: false);
		}
	}
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Chunks
	{
		public static float[,,] GetAlphaMapChunk(float[,,] alphaMap, int x, int y, int width, int height)
		{
			float[,,] array = new float[width, height, alphaMap.GetLength(2)];
			int num = 0;
			int num2 = x;
			while (num < width)
			{
				int num3 = 0;
				int num4 = y;
				while (num3 < height)
				{
					for (int i = 0; i < alphaMap.GetLength(2); i++)
					{
						array[num3, num, i] = alphaMap[num4, num2, i];
					}
					num3++;
					num4++;
				}
				num++;
				num2++;
			}
			return array;
		}
	}
}
namespace TBUnityLib.TextureTools
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct TextureGenerator
	{
		public static Texture2D GenerateTexture2D(Color color)
		{
			return GenerateTexture2D(color, 4, 4);
		}

		public static Texture2D GenerateTexture2D(Color color, int width, int height)
		{
			Texture2D texture2D = new Texture2D(width, height);
			for (int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; j++)
				{
					texture2D.SetPixel(i, j, color);
				}
			}
			texture2D.Apply();
			return texture2D;
		}
	}
}
namespace BezierSplines
{
	public static class Bezier
	{
		public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, float t)
		{
			t = Mathf.Clamp01(t);
			float num = 1f - t;
			return num * num * p0 + 2f * num * t * p1 + t * t * p2;
		}

		public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			t = Mathf.Clamp01(t);
			float num = 1f - t;
			return num * num * num * p0 + 3f * num * num * t * p1 + 3f * num * t * t * p2 + t * t * t * p3;
		}

		public static Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, float t)
		{
			return 2f * (1f - t) * (p1 - p0) + 2f * t * (p2 - p1);
		}

		public static Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			t = Mathf.Clamp01(t);
			float num = 1f - t;
			return 3f * num * num * (p1 - p0) + 6f * num * t * (p2 - p1) + 3f * t * t * (p3 - p2);
		}
	}
	public enum BezierControlPointMode
	{
		Free,
		Aligned,
		Mirrored
	}
	[AddComponentMenu("")]
	public class BezierSpline : MonoBehaviour
	{
		[SerializeField]
		private BezierControlPointMode[] modes;

		[SerializeField]
		private Vector3[] points;

		public int CurveCount => (points.Length - 1) / 3;

		public int ControlPointCount => points.Length;

		public Vector3 GetControlPoint(int index)
		{
			return points[index];
		}

		public void Awake()
		{
			if (points == null)
			{
				Reset();
			}
		}

		public void SetControlPoint(int index, Vector3 point)
		{
			try
			{
				points[index].ToString();
			}
			catch (IndexOutOfRangeException exception)
			{
				Debug.LogException(exception);
			}
			if (index % 3 == 0)
			{
				Vector3 vector = point - points[index];
				if (index > 0)
				{
					points[index - 1] += vector;
				}
				if (index + 1 < points.Length)
				{
					points[index + 1] += vector;
				}
			}
			points[index] = point;
			EnforceMode(index);
		}

		public void Reset()
		{
			points = new Vector3[4]
			{
				new Vector3(-1.5f, 0f, 0f),
				new Vector3(-0.5f, 0f, 0f),
				new Vector3(0.5f, 0f, 0f),
				new Vector3(1.5f, 0f, 0f)
			};
			modes = new BezierControlPointMode[2]
			{
				BezierControlPointMode.Aligned,
				BezierControlPointMode.Aligned
			};
		}

		public void AddCurve(int stepsPerCurve, bool atPositive, float distanceBetweenPoints = 1f)
		{
			if (!atPositive)
			{
				Vector3 vector = points[points.Length - 1];
				Vector3 vector2 = base.transform.InverseTransformDirection(GetDirection(points.Length - 1));
				Array.Resize(ref points, points.Length + 3);
				vector += vector2 * distanceBetweenPoints;
				points[points.Length - 3] = vector;
				vector += vector2 * distanceBetweenPoints;
				points[points.Length - 2] = vector;
				vector += vector2 * distanceBetweenPoints;
				points[points.Length - 1] = vector;
			}
			else
			{
				Vector3 vector = points[0];
				Vector3 vector2 = base.transform.InverseTransformDirection(GetDirection(0f));
				Array.Resize(ref points, points.Length + 3);
				for (int num = points.Length - 1; num > 2; num--)
				{
					points[num] = points[num - 3];
				}
				vector -= vector2 * distanceBetweenPoints;
				points[2] = vector;
				vector -= vector2 * distanceBetweenPoints;
				points[1] = vector;
				vector -= vector2 * distanceBetweenPoints;
				points[0] = vector;
			}
			Array.Resize(ref modes, modes.Length + 1);
			modes[modes.Length - 1] = modes[modes.Length - 2];
			EnforceMode(points.Length - 4);
		}

		public void RemoveCurve(bool atPositive)
		{
			if (points.Length <= 4)
			{
				return;
			}
			if (!atPositive)
			{
				Array.Resize(ref points, points.Length - 3);
				return;
			}
			Vector3[] array = new Vector3[points.Length - 3];
			for (int i = 3; i < points.Length; i++)
			{
				array[i - 3] = points[i];
			}
			points = array;
		}

		public Vector3 GetPoint(float t)
		{
			int num;
			if (t >= 1f)
			{
				t = 1f;
				num = points.Length - 4;
			}
			else
			{
				t = Mathf.Clamp01(t) * (float)CurveCount;
				num = (int)t;
				t -= (float)num;
				num *= 3;
			}
			return base.transform.TransformPoint(Bezier.GetPoint(points[num], points[num + 1], points[num + 2], points[num + 3], t));
		}

		public Vector3 GetVelocity(float t)
		{
			int num;
			if (t >= 1f)
			{
				t = 1f;
				num = points.Length - 4;
			}
			else
			{
				t = Mathf.Clamp01(t) * (float)CurveCount;
				num = (int)t;
				t -= (float)num;
				num *= 3;
			}
			return base.transform.TransformPoint(Bezier.GetFirstDerivative(points[num], points[num + 1], points[num + 2], points[num + 3], t)) - base.transform.position;
		}

		public Vector3 GetDirection(float t)
		{
			return GetVelocity(t).normalized;
		}

		public Vector3 GetRotation(float t, Vector3? offset = null)
		{
			return (offset.HasValue ? Quaternion.Euler(offset.Value.x, offset.Value.y, offset.Value.z) : Quaternion.Euler(0f, 0f, 0f)) * base.transform.InverseTransformDirection(GetDirection(t));
		}

		private void EnforceMode(int index)
		{
			int num = (index + 1) / 3;
			BezierControlPointMode bezierControlPointMode = modes[num];
			if (bezierControlPointMode != 0 && num != 0 && num != modes.Length - 1)
			{
				int num2 = num * 3;
				int num3;
				int num4;
				if (index <= num2)
				{
					num3 = num2 - 1;
					num4 = num2 + 1;
				}
				else
				{
					num3 = num2 + 1;
					num4 = num2 - 1;
				}
				Vector3 vector = points[num2];
				Vector3 vector2 = vector - points[num3];
				if (bezierControlPointMode == BezierControlPointMode.Aligned && num4 <= points.Length - 1)
				{
					vector2 = vector2.normalized * Vector3.Distance(vector, points[num4]);
				}
				if (num4 <= points.Length - 1)
				{
					points[num4] = vector + vector2;
				}
			}
		}

		public BezierControlPointMode GetControlPointMode(int index)
		{
			return modes[(index + 1) / 3];
		}

		public void SetControlPointMode(int index, BezierControlPointMode mode)
		{
			modes[(index + 1) / 3] = mode;
			EnforceMode(index);
		}
	}
	[AddComponentMenu("")]
	public class Line : MonoBehaviour
	{
		public Vector3 p0;

		public Vector3 p1;
	}
}
namespace RuntimeGizmo
{
	public enum GizmoTypes
	{
		Position,
		Rotation,
		Scale
	}
	public enum GizmoControl
	{
		Horizontal,
		Vertical,
		Both
	}
	public enum GizmoAxis
	{
		Center,
		X,
		Y,
		Z
	}
	[AddComponentMenu("")]
	public class Gizmo : MonoBehaviour
	{
		public GizmoHandle axisCenter;

		public GizmoHandle axisX;

		public GizmoHandle axisY;

		public GizmoHandle axisZ;

		public GizmoTypes type;

		public List<Transform> selectedObjects;

		public Vector3 center;

		public Camera mainCamera;

		public bool visible;

		public float defaultDistance = 3.2f;

		public float scaleFactor = 0.2f;

		private Vector3 localScale;

		private Transform gizmoTransform;

		protected void Awake()
		{
			visible = false;
			Hide();
			axisCenter.gizmoAxis = GizmoAxis.Center;
			axisCenter.gizmo = this;
			axisX.gizmoAxis = GizmoAxis.X;
			axisX.gizmo = this;
			axisY.gizmoAxis = GizmoAxis.Y;
			axisY.gizmo = this;
			axisZ.gizmoAxis = GizmoAxis.Z;
			axisZ.gizmo = this;
			SetType(GizmoTypes.Position);
			gizmoTransform = base.transform;
			localScale = gizmoTransform.localScale;
			selectedObjects = new List<Transform>();
		}

		protected void Update()
		{
			if (visible)
			{
				if (Input.GetKeyDown(KeyCode.Alpha1))
				{
					SetType(GizmoTypes.Position);
				}
				if (Input.GetKeyDown(KeyCode.Escape))
				{
					ClearSelection();
					Hide();
				}
			}
			if (selectedObjects.Count > 0)
			{
				float num = (Vector3.Distance(gizmoTransform.position, UnityEngine.Object.FindObjectOfType<Camera>().transform.position) - defaultDistance) * scaleFactor;
				gizmoTransform.localScale = new Vector3(localScale.x + num, localScale.y + num, localScale.z + num);
				UpdateCenter();
				gizmoTransform.position = center;
			}
		}

		public void SetType(GizmoTypes gizmoType)
		{
			type = gizmoType;
			axisCenter.SetType(type);
			axisX.SetType(type);
			axisY.SetType(type);
			axisZ.SetType(type);
		}

		public void ClearSelection()
		{
			foreach (Transform selectedObject in selectedObjects)
			{
				selectedObject.gameObject.GetComponent<GizmoSelectable>().Unselect();
			}
			selectedObjects.Clear();
			center = Vector3.zero;
		}

		public void UpdateCenter()
		{
			if (selectedObjects.Count > 1)
			{
				Vector3[] array = new Vector3[selectedObjects.Count];
				for (int i = 0; i < selectedObjects.Count; i++)
				{
					if ((bool)selectedObjects[i].GetComponent<MagnetRoad>())
					{
						array[i] = selectedObjects[i].GetComponent<MagnetRoad>().splineSource.GetPoint(0.5f);
					}
					else
					{
						array[i] = selectedObjects[i].position;
					}
				}
				center = GetCenterOfVectors(array);
			}
			else if ((bool)selectedObjects[0])
			{
				center = (selectedObjects[0].GetComponent<MagnetRoad>() ? selectedObjects[0].GetComponent<MagnetRoad>().splineSource.GetPoint(0.5f) : selectedObjects[0].position);
			}
		}

		public void SelectObject(Transform parent)
		{
			if (!selectedObjects.Contains(parent))
			{
				selectedObjects.Add(parent);
			}
			UpdateCenter();
		}

		public void ActivateAxis(GizmoAxis axis)
		{
			switch (axis)
			{
			case GizmoAxis.Center:
				axisCenter.SetActive(active: true);
				break;
			case GizmoAxis.X:
				axisX.SetActive(active: true);
				break;
			case GizmoAxis.Y:
				axisY.SetActive(active: true);
				break;
			case GizmoAxis.Z:
				axisZ.SetActive(active: true);
				break;
			}
			SetType(type);
		}

		public void DeactivateAxis(GizmoAxis axis)
		{
			switch (axis)
			{
			case GizmoAxis.Center:
				axisCenter.SetActive(active: false);
				break;
			case GizmoAxis.X:
				axisX.SetActive(active: false);
				break;
			case GizmoAxis.Y:
				axisY.SetActive(active: false);
				break;
			case GizmoAxis.Z:
				axisZ.SetActive(active: false);
				break;
			}
			SetType(type);
		}

		public void DeactivateHandles()
		{
			axisCenter.SetActive(active: false);
			axisX.SetActive(active: false);
			axisY.SetActive(active: false);
			axisZ.SetActive(active: false);
		}

		public void Show()
		{
			Helper.SetActiveRecursively(base.gameObject, active: true);
			SetType(type);
			visible = true;
		}

		public void Hide()
		{
			Helper.SetActiveRecursively(base.gameObject, active: false);
			base.gameObject.SetActive(value: true);
			visible = false;
		}

		public Vector3 GetCenterOfVectors(Vector3[] vectors)
		{
			Vector3 zero = Vector3.zero;
			if (vectors == null || vectors.Length == 0)
			{
				return zero;
			}
			zero = vectors.Aggregate(zero, (Vector3 current, Vector3 vec) => current + vec);
			return zero / vectors.Length;
		}
	}
	[AddComponentMenu("")]
	public class GizmoHandle : MonoBehaviour
	{
		public Gizmo gizmo;

		public GizmoControl gizmoController;

		public GizmoTypes gizmoType;

		public GameObject positionCap;

		public GameObject rotationCap;

		public GameObject scaleCap;

		public Material activeMaterial;

		public GizmoAxis gizmoAxis;

		public float mouseSensitivity = 10f;

		public float rotationSensitivity;

		public float scaleSensitivity;

		private Material inactiveMaterial;

		private bool activeHandle;

		private Vector3 gizmoMouseOffset;

		private Vector3 gizmoStartPosition;

		protected void Awake()
		{
			inactiveMaterial = GetComponent<Renderer>().material;
		}

		public void OnMouseDown()
		{
			gizmoMouseOffset = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.WorldToScreenPoint(gizmo.transform.position).z));
			gizmoStartPosition = gizmo.transform.position;
			gizmo.DeactivateHandles();
			SetActive(active: true);
		}

		public void OnMouseDrag()
		{
			float z = Camera.main.WorldToScreenPoint(gizmo.transform.position).z;
			if (!activeHandle)
			{
				return;
			}
			switch (gizmoType)
			{
			case GizmoTypes.Position:
			{
				Vector3 vector = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, z));
				Vector3 vector2 = Vector3.zero;
				switch (gizmoAxis)
				{
				case GizmoAxis.X:
				{
					foreach (Transform selectedObject in gizmo.selectedObjects)
					{
						if ((bool)selectedObject.GetComponent<MagnetRoad>())
						{
							vector2 = selectedObject.transform.position - selectedObject.GetComponent<MagnetRoad>().splineSource.GetPoint(0.5f);
						}
						selectedObject.transform.position = new Vector3(selectedObject.transform.position.x, selectedObject.transform.position.y, vector.z - (gizmoMouseOffset.z - gizmoStartPosition.z - vector2.z));
					}
					break;
				}
				case GizmoAxis.Y:
				{
					foreach (Transform selectedObject2 in gizmo.selectedObjects)
					{
						if ((bool)selectedObject2.GetComponent<MagnetRoad>())
						{
							vector2 = selectedObject2.transform.position - selectedObject2.GetComponent<MagnetRoad>().splineSource.GetPoint(0.5f);
						}
						selectedObject2.transform.position = new Vector3(selectedObject2.transform.position.x, vector.y - (gizmoMouseOffset.y - gizmoStartPosition.y - vector2.y), selectedObject2.transform.position.z);
					}
					break;
				}
				case GizmoAxis.Z:
				{
					foreach (Transform selectedObject3 in gizmo.selectedObjects)
					{
						if ((bool)selectedObject3.GetComponent<MagnetRoad>())
						{
							vector2 = selectedObject3.transform.position - selectedObject3.GetComponent<MagnetRoad>().splineSource.GetPoint(0.5f);
						}
						selectedObject3.transform.position = new Vector3(vector.x - (gizmoMouseOffset.x - gizmoStartPosition.x) + vector2.x, selectedObject3.transform.position.y, selectedObject3.transform.position.z);
					}
					break;
				}
				case GizmoAxis.Center:
				{
					foreach (Transform selectedObject4 in gizmo.selectedObjects)
					{
						if ((bool)selectedObject4.GetComponent<MagnetRoad>())
						{
							vector2 = selectedObject4.transform.position - selectedObject4.GetComponent<MagnetRoad>().splineSource.GetPoint(0.5f);
						}
						selectedObject4.transform.position = new Vector3(vector.x + vector2.x, selectedObject4.transform.position.y, vector.z + vector2.z);
					}
					break;
				}
				}
				break;
			}
			case GizmoTypes.Rotation:
			case GizmoTypes.Scale:
				break;
			}
		}

		public void SetActive(bool active)
		{
			if (active)
			{
				activeHandle = true;
				GetComponent<Renderer>().material = activeMaterial;
			}
			else
			{
				activeHandle = false;
				GetComponent<Renderer>().material = inactiveMaterial;
			}
		}

		public void SetType(GizmoTypes type)
		{
			gizmoType = type;
			if (gizmoAxis != 0)
			{
				Helper.SetActiveRecursively(positionCap, type == GizmoTypes.Position);
				Helper.SetActiveRecursively(rotationCap, type == GizmoTypes.Rotation);
				Helper.SetActiveRecursively(scaleCap, type == GizmoTypes.Scale);
			}
		}
	}
	[AddComponentMenu("")]
	public class GizmoSelectable : MonoBehaviour
	{
		private static Gizmo sGizmoControl;

		private bool shiftDown;

		protected void Start()
		{
			if ((bool)UnityEngine.Object.FindObjectOfType<Gizmo>())
			{
				sGizmoControl = UnityEngine.Object.FindObjectOfType<Gizmo>();
				return;
			}
			if ((bool)GameObject.Find("__RuntimeGizmo"))
			{
				UnityEngine.Object.DestroyImmediate(GameObject.Find("__RuntimeGizmo"));
			}
			sGizmoControl = UnityEngine.Object.Instantiate(Resources.Load("_Base/_RuntimeGizmo/Gizmo") as GameObject).GetComponent<Gizmo>();
			sGizmoControl.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
			sGizmoControl.name = "__RuntimeGizmo";
		}

		protected void OnMouseDown()
		{
			if (!(sGizmoControl == null))
			{
				if (!shiftDown)
				{
					sGizmoControl.ClearSelection();
				}
				sGizmoControl.Show();
				sGizmoControl.SelectObject(base.transform);
				base.gameObject.layer = 2;
			}
		}

		protected void Update()
		{
			shiftDown = Input.GetKey(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift);
		}

		public void Unselect()
		{
			base.gameObject.layer = 0;
		}
	}
}
namespace MagnetRoads
{
	[XmlRoot("MagnetRoadCollection")]
	public class MagnetRoadCollection
	{
		public class MagnetRoadData
		{
			[XmlAttribute("name")]
			public string name;

			public string uniqueId;

			public Vector3 location;

			public Vector3 rotation;

			public Vector3 scale;

			public string surfaceMaterial;

			public string sideMaterial;

			public string sidewalkMaterial;

			public float roadWidth;

			public float sidewalkWidth;

			public float sidewalkHeight;

			public float sideDepth;

			public float slopeWidth;

			public int stepsPerCurve;

			public bool isEditableAtRuntime;

			[XmlArray("HandlePoints")]
			[XmlArrayItem("HPoint")]
			public Vector3[] handlePoints;

			public bool snapToTerrain;

			public float distanceFromTerrain;

			public string positiveConnectionId;

			public string negativeConnectionId;

			public Mesh roadsideFencePanelMesh;

			public Vector2 roadsideFencePanelScaling;

			public Vector3 roadsideFencePanelRotation;

			public float roadsideFenceDistanceFromRoad;

			public string roadsideFencePanelMaterial;

			public Mesh roadsideFencePostMesh;

			public Vector3 roadsideFencePostScaling;

			public Vector3 roadsideFencePostRotation;

			public string roadsideFencePostMaterial;

			public Mesh centerFencePanelMesh;

			public Vector2 centerFencePanelScaling;

			public Vector3 centerFencePanelRotation;

			public float centerFenceDistanceFromRoad;

			public string centerFencePanelMaterial;

			public Mesh centerFencePostMesh;

			public Vector3 centerFencePostScaling;

			public Vector3 centerFencePostRotation;

			public string centerFencePostMaterial;

			public Vector2 reservationDimensions;

			public float reservationSlope;

			public string reservationTopMaterial;

			public string reservationSideMaterial;

			public Mesh centerObjectMesh;

			public int centerObjectsToSpawn;

			public Vector3 centerObjectScaling;

			public Vector3 centerObjectRotation;

			public string centerObjectMaterial;
		}

		public class IntersectionData
		{
			[XmlAttribute("name")]
			public string name;

			public Vector3 location;

			public Vector3 rotation;

			public Vector3 scale;

			public string surfaceMaterial;

			public string sideMaterial;

			public float roadWidth;

			public float sideDepth;

			public float slopeWidth;

			public bool isEditableAtRuntime;

			public Intersection.IntersectionType intersectionType;

			public string connectedUniqueId0;

			public string connectedUniqueId1;

			public string connectedUniqueId2;

			public string connectedUniqueId3;
		}

		[XmlArray("MagnetRoads")]
		[XmlArrayItem("MagnetRoad")]
		public MagnetRoadData[] magnetRoadData;

		[XmlArray("Intersections")]
		[XmlArrayItem("Intersection")]
		public IntersectionData[] intersectionData;

		public void PrepareMagnetRoadData(MagnetRoad[] input)
		{
			magnetRoadData = new MagnetRoadData[input.Length];
			for (int i = 0; i < input.Length; i++)
			{
				magnetRoadData[i] = new MagnetRoadData
				{
					name = input[i].name,
					uniqueId = input[i].uniqueConnectionId,
					location = input[i].transform.position,
					rotation = input[i].transform.rotation.eulerAngles,
					scale = input[i].transform.localScale,
					surfaceMaterial = (input[i].surfaceMaterial ? input[i].surfaceMaterial.name : null),
					sideMaterial = (input[i].sideMaterial ? input[i].sideMaterial.name : null),
					sidewalkMaterial = (input[i].sidewalkMaterial ? input[i].sidewalkMaterial.name : null),
					roadWidth = input[i].roadWidth,
					sidewalkWidth = input[i].sidewalkWidth,
					sidewalkHeight = input[i].sidewalkHeight,
					sideDepth = input[i].sideDepth,
					slopeWidth = input[i].slopeWidth,
					stepsPerCurve = input[i].stepsPerCurve,
					isEditableAtRuntime = input[i].IsEditableAtRuntime,
					handlePoints = new Vector3[input[i].splineSource.ControlPointCount],
					snapToTerrain = input[i].snapRoadToTerrain,
					distanceFromTerrain = input[i].distanceFromTerrain,
					positiveConnectionId = input[i].PositiveConnectionUniqueId,
					negativeConnectionId = input[i].NegativeConnectionUniqueId,
					roadsideFencePanelMesh = (input[i].roadsideFencePanelMesh ? input[i].roadsideFencePanelMesh : null),
					roadsideFencePanelScaling = input[i].roadsideFencePanelScaling,
					roadsideFencePanelRotation = input[i].roadsideFencePostRotation,
					roadsideFencePanelMaterial = (input[i].roadsideFencePanelMaterial ? input[i].roadsideFencePanelMaterial.name : null),
					roadsideFencePostMesh = (input[i].roadsideFencePostMesh ? input[i].roadsideFencePostMesh : null),
					roadsideFencePostScaling = input[i].roadsideFencePostScaling,
					roadsideFencePostRotation = input[i].roadsideFencePostRotation,
					roadsideFencePostMaterial = (input[i].roadsideFencePostMaterial ? input[i].roadsideFencePostMaterial.name : null),
					roadsideFenceDistanceFromRoad = input[i].fenceDistanceFromRoad,
					centerFencePanelMesh = (input[i].centerFencePanelMesh ? input[i].centerFencePanelMesh : null),
					centerFencePanelScaling = input[i].centerFencePanelScaling,
					centerFencePanelRotation = input[i].centerFencePanelRotation,
					centerFencePanelMaterial = (input[i].centerFencePanelMaterial ? input[i].centerFencePanelMaterial.name : null),
					centerFencePostMesh = (input[i].centerFencePostMesh ? input[i].centerFencePostMesh : null),
					centerFencePostScaling = input[i].centerFencePostScaling,
					centerFencePostRotation = input[i].centerFencePostRotation,
					centerFencePostMaterial = (input[i].centerFencePostMaterial ? input[i].centerFencePostMaterial.name : null),
					reservationDimensions = input[i].reservationDimensions,
					reservationSlope = input[i].reservationSlope,
					reservationTopMaterial = (input[i].reservationTopMaterial ? input[i].reservationTopMaterial.name : null),
					reservationSideMaterial = (input[i].reservationSideMaterial ? input[i].reservationSideMaterial.name : null),
					centerObjectMesh = (input[i].centerObjectMesh ? input[i].centerObjectMesh : null),
					centerObjectScaling = input[i].centerObjectScaling,
					centerObjectRotation = input[i].centerObjectRotation,
					centerObjectsToSpawn = input[i].centerObjectsToSpawn,
					centerObjectMaterial = (input[i].centerObjectMaterial ? input[i].centerObjectMaterial.name : null)
				};
				for (int j = 0; j < input[i].splineSource.ControlPointCount; j++)
				{
					magnetRoadData[i].handlePoints[j] = input[i].transform.TransformPoint(input[i].splineSource.GetControlPoint(j));
				}
			}
		}

		public void PrepareIntersectionData(Intersection[] input)
		{
			intersectionData = new IntersectionData[input.Length];
			for (int i = 0; i < input.Length; i++)
			{
				intersectionData[i] = new IntersectionData
				{
					name = input[i].name,
					location = input[i].transform.position,
					rotation = input[i].transform.rotation.eulerAngles,
					scale = input[i].transform.localScale,
					surfaceMaterial = (input[i].surfaceMaterial ? input[i].surfaceMaterial.name : null),
					sideMaterial = (input[i].sideMaterial ? input[i].sideMaterial.name : null),
					roadWidth = input[i].roadWidth,
					sideDepth = input[i].sideDepth,
					slopeWidth = input[i].slopeWidth,
					isEditableAtRuntime = input[i].IsEditableAtRuntime,
					intersectionType = input[i].CurrentIntersectionType,
					connectedUniqueId0 = input[i].GetConnectionUniqueId(0),
					connectedUniqueId1 = input[i].GetConnectionUniqueId(1),
					connectedUniqueId2 = input[i].GetConnectionUniqueId(2),
					connectedUniqueId3 = input[i].GetConnectionUniqueId(3)
				};
			}
		}

		public void Save(string path)
		{
			if (string.IsNullOrEmpty(path.Trim(' ')))
			{
				return;
			}
			Debug.Log("Saving road(s) to " + path);
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(MagnetRoadCollection));
			FileStream fileStream = new FileStream(path, FileMode.Create);
			try
			{
				xmlSerializer.Serialize(fileStream, this);
			}
			finally
			{
				fileStream.Close();
			}
		}

		public static MagnetRoadCollection Load(string path)
		{
			if (string.IsNullOrEmpty(path.Trim(' ')))
			{
				return null;
			}
			Debug.Log("Loading road(s) from " + path);
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(MagnetRoadCollection));
			FileStream fileStream = new FileStream(path, FileMode.Open);
			try
			{
				return xmlSerializer.Deserialize(fileStream) as MagnetRoadCollection;
			}
			finally
			{
				fileStream.Close();
			}
		}
	}
	[AddComponentMenu("")]
	public class MeshGenerator : MonoBehaviour
	{
		public static GameObject GenerateRoadFencePanels(MagnetRoad parentRoad, Mesh fenceMesh, float distanceFromRoad, Vector2 fenceXyScales, Vector3 fenceRotationOffset, Material fenceMaterial, bool isCenterOnly = false)
		{
			if (parentRoad == null)
			{
				throw new NullReferenceException("Invalid MagnetRoad instance provided - road fences will not generate");
			}
			if (fenceMesh == null)
			{
				throw new NullReferenceException("Invalid fence mesh provided - road fences will not generate");
			}
			Vector3 size = fenceMesh.bounds.size;
			Pair<Vector3>[] array = parentRoad.GenerateRoadVertexOutput((!isCenterOnly) ? (parentRoad.roadWidth + distanceFromRoad) : 0f);
			GameObject gameObject = new GameObject(parentRoad.name + " - Fences");
			gameObject.transform.parent = parentRoad.transform;
			for (int i = 0; i < array.Length - 1; i++)
			{
				GameObject gameObject2 = GenerateObjectWithMesh(parentRoad.name + ((!isCenterOnly) ? " Left Fence " : " Center Fence ") + i, fenceMesh, fenceMaterial);
				float num = Vector3.Distance(array[i].First, array[i + 1].First);
				Vector3 localScale = gameObject2.transform.localScale;
				localScale.x = fenceXyScales.x;
				localScale.y = fenceXyScales.y;
				localScale.z = num * localScale.z / size.z;
				gameObject2.transform.localScale = localScale;
				gameObject2.transform.position = Vector3.Lerp(array[i].First, array[i + 1].First, 0.5f);
				gameObject2.transform.LookAt(array[i + 1].First);
				gameObject2.transform.rotation = Quaternion.Euler(gameObject2.transform.rotation.eulerAngles + ((i < array.Length - 1) ? fenceRotationOffset : (-fenceRotationOffset)));
				gameObject2.transform.parent = gameObject.transform;
				if (!isCenterOnly)
				{
					GameObject gameObject3 = GenerateObjectWithMesh(parentRoad.name + " Right Fence " + i, fenceMesh, fenceMaterial);
					float num2 = Vector3.Distance(array[i].Second, array[i + 1].Second);
					Vector3 localScale2 = gameObject3.transform.localScale;
					localScale2.x = fenceXyScales.x;
					localScale2.y = fenceXyScales.y;
					localScale2.z = num2 * localScale2.z / size.z;
					gameObject3.transform.localScale = localScale2;
					gameObject3.transform.position = Vector3.Lerp(array[i].Second, array[i + 1].Second, 0.5f);
					gameObject3.transform.LookAt(array[i + 1].Second);
					gameObject3.transform.rotation = Quaternion.Euler(gameObject3.transform.rotation.eulerAngles + ((i < array.Length - 1) ? fenceRotationOffset : (-fenceRotationOffset)));
					gameObject3.transform.parent = gameObject.transform;
				}
			}
			return gameObject;
		}

		public static GameObject GenerateRoadFencePosts(MagnetRoad parentRoad, Mesh fenceMesh, float distanceFromRoad, Vector3 fencePostScales, Vector3 fenceRotationOffset, Material fenceMaterial, bool isCenterOnly = false)
		{
			if (parentRoad == null)
			{
				throw new NullReferenceException("Invalid MagnetRoad instance provided - road fence posts will not generate");
			}
			if (fenceMesh == null)
			{
				throw new NullReferenceException("Invalid fence post mesh provided - road fence posts will not generate");
			}
			Pair<Vector3>[] array = parentRoad.GenerateRoadVertexOutput((!isCenterOnly) ? (parentRoad.roadWidth + distanceFromRoad) : 0f);
			GameObject gameObject = new GameObject(parentRoad.name + " - Fence Posts");
			gameObject.transform.parent = parentRoad.transform;
			for (int i = 0; i < array.Length; i++)
			{
				GameObject gameObject2 = GenerateObjectWithMesh(parentRoad.name + ((!isCenterOnly) ? " Left Fence Post " : " Center Fence Post ") + i, fenceMesh, fenceMaterial);
				gameObject2.transform.localScale = fencePostScales;
				gameObject2.transform.position = array[i].First;
				gameObject2.transform.LookAt((i < array.Length - 1) ? array[i + 1].First : array[i - 1].First);
				gameObject2.transform.rotation = Quaternion.Euler(gameObject2.transform.rotation.eulerAngles + ((i < array.Length - 1) ? fenceRotationOffset : (-fenceRotationOffset)));
				gameObject2.transform.parent = gameObject.transform;
				if (!isCenterOnly)
				{
					GameObject gameObject3 = GenerateObjectWithMesh(parentRoad.name + " Right Fence Post " + i, fenceMesh, fenceMaterial);
					gameObject3.transform.localScale = fencePostScales;
					gameObject3.transform.position = array[i].Second;
					gameObject3.transform.LookAt((i < array.Length - 1) ? array[i + 1].Second : array[i - 1].Second);
					gameObject3.transform.rotation = Quaternion.Euler(gameObject3.transform.rotation.eulerAngles + ((i < array.Length - 1) ? fenceRotationOffset : (-fenceRotationOffset)));
					gameObject3.transform.parent = gameObject.transform;
				}
			}
			return gameObject;
		}

		public static GameObject GenerateCentralReservation(MagnetRoad parentRoad)
		{
			if (parentRoad == null)
			{
				throw new NullReferenceException("Invalid MagnetRoad instance provided - road central reservation will not generate");
			}
			List<Pair<Vector3>> list = parentRoad.GenerateRoadVertexOutput(parentRoad.reservationDimensions.x).ToList();
			for (int i = 0; i < list.Count; i++)
			{
				Pair<Vector3> pair = list[i];
				list[i] = new Pair<Vector3>(pair.First += new Vector3(0f, parentRoad.reservationDimensions.y, 0f), pair.Second += new Vector3(0f, parentRoad.reservationDimensions.y, 0f));
			}
			GameObject gameObject = new GameObject(parentRoad.name + " - Central Reservation");
			Mesh mesh2 = (gameObject.AddComponent<MeshFilter>().sharedMesh = Geometry.GenerateStrip(list.ToArray(), gameObject.transform, flipNormals: true, null, "Central Reservation Strip"));
			Mesh sharedMesh = mesh2;
			gameObject.AddComponent<MeshCollider>().sharedMesh = sharedMesh;
			gameObject.AddComponent<MeshRenderer>().sharedMaterial = parentRoad.reservationTopMaterial;
			gameObject.transform.parent = parentRoad.transform;
			List<Pair<Vector3>> list2 = new List<Pair<Vector3>>();
			Pair<Vector3>[] array = parentRoad.GenerateRoadVertexOutput(parentRoad.reservationDimensions.x += parentRoad.reservationSlope * 2f);
			for (int j = 0; j < list.Count; j++)
			{
				Pair<Vector3> pair2 = list[j];
				list2.Insert(0, new Pair<Vector3>(pair2.First, array[j].First));
				list2.Insert(list2.Count, new Pair<Vector3>(pair2.Second, array[j].Second));
			}
			list2.Insert(0, list2[list2.Count - 1]);
			GameObject gameObject2 = new GameObject(parentRoad.name + " - Central Reservation Sides");
			mesh2 = (gameObject2.AddComponent<MeshFilter>().sharedMesh = Geometry.GenerateStrip(list2.ToArray(), gameObject2.transform, flipNormals: true, null, "Central Reservation Strip"));
			sharedMesh = mesh2;
			gameObject2.AddComponent<MeshCollider>().sharedMesh = sharedMesh;
			gameObject2.AddComponent<MeshRenderer>().sharedMaterial = parentRoad.reservationSideMaterial;
			gameObject2.transform.parent = gameObject.transform;
			return gameObject;
		}

		public static GameObject GenerateCentralReservationObjects(MagnetRoad parentRoad)
		{
			if (parentRoad == null)
			{
				throw new NullReferenceException("Invalid MagnetRoad instance provided - central reservation objects will not generate");
			}
			if (parentRoad.centerObjectMesh == null)
			{
				throw new NullReferenceException("Invalid central reservation object mesh provided - central reservation objects will not generate");
			}
			Vector3[] centreWaypoints = parentRoad.GetCentreWaypoints();
			GameObject gameObject = new GameObject(parentRoad.name + " - Central Reservation Objects");
			gameObject.transform.parent = parentRoad.transform;
			int num = parentRoad.stepsPerCurve * parentRoad.splineSource.CurveCount;
			int num2 = num / parentRoad.centerObjectsToSpawn;
			int num3 = num2 / 2;
			for (int i = 0; i < parentRoad.centerObjectsToSpawn; i++)
			{
				GameObject gameObject2 = GenerateObjectWithMesh(parentRoad.name + " Center Object " + i, parentRoad.centerObjectMesh, parentRoad.centerObjectMaterial);
				gameObject2.transform.localScale = parentRoad.centerObjectScaling;
				int num4 = num3 + i * num2;
				gameObject2.transform.position = centreWaypoints[num4];
				gameObject2.transform.LookAt((i < num - 1) ? centreWaypoints[num4 + 1] : centreWaypoints[num4 - 1]);
				gameObject2.transform.rotation = Quaternion.Euler(gameObject2.transform.rotation.eulerAngles + ((i < num - 1) ? parentRoad.centerObjectRotation : (-parentRoad.centerObjectRotation)));
				gameObject2.transform.parent = gameObject.transform;
			}
			return gameObject;
		}

		private static GameObject GenerateObjectWithMesh(string objectName, Mesh objectMesh, Material objectMaterial)
		{
			GameObject obj = new GameObject(objectName);
			obj.AddComponent<MeshFilter>().sharedMesh = objectMesh;
			obj.AddComponent<MeshCollider>().sharedMesh = objectMesh;
			obj.AddComponent<MeshRenderer>().sharedMaterial = objectMaterial;
			return obj;
		}
	}
	[ExecuteInEditMode]
	[SelectionBase]
	[AddComponentMenu("")]
	public class SnapPoint : MonoBehaviour
	{
		public enum PointEnd
		{
			Positive,
			Negative,
			Bipolar
		}

		[HideInInspector]
		[SerializeField]
		private PointEnd pointEnd;

		[HideInInspector]
		[SerializeField]
		private float roadWidth;

		private GameObject inEditorMagnetPoint;

		private bool isSetup;

		public bool isEditableAtRuntime;

		public PointEnd PointType => pointEnd;

		public void SetUp(PointEnd pointType, float width)
		{
			pointEnd = pointType;
			roadWidth = width;
		}

		protected void Update()
		{
			if (Application.isPlaying && isEditableAtRuntime)
			{
				if (!isSetup)
				{
					if (!inEditorMagnetPoint)
					{
						inEditorMagnetPoint = GameObject.CreatePrimitive(PrimitiveType.Sphere);
					}
					if (inEditorMagnetPoint.transform.parent != base.transform)
					{
						inEditorMagnetPoint.transform.parent = base.transform;
					}
					inEditorMagnetPoint.transform.position = new Vector3(base.transform.position.x, base.transform.position.y, base.transform.position.z);
					inEditorMagnetPoint.name = "__RuntimeSnapNode";
					if (!inEditorMagnetPoint.GetComponent<Renderer>().enabled)
					{
						inEditorMagnetPoint.GetComponent<Renderer>().enabled = true;
					}
					switch (PointType)
					{
					case PointEnd.Positive:
						inEditorMagnetPoint.transform.localScale = new Vector3(roadWidth / 1.4f, roadWidth / 24f, roadWidth / 1.4f);
						inEditorMagnetPoint.GetComponent<Renderer>().material = Resources.Load<Material>("Materials/_RuntimeGizmo/Positive");
						break;
					case PointEnd.Negative:
						inEditorMagnetPoint.transform.localScale = new Vector3(roadWidth / 1.4f - 0.01f, roadWidth / 24f, roadWidth / 1.4f - 0.01f);
						inEditorMagnetPoint.GetComponent<Renderer>().material = Resources.Load<Material>("Materials/_RuntimeGizmo/Negative");
						break;
					case PointEnd.Bipolar:
						inEditorMagnetPoint.transform.localScale = new Vector3(roadWidth / 1.4f - 0.02f, roadWidth / 24f, roadWidth / 1.4f - 0.02f);
						inEditorMagnetPoint.GetComponent<Renderer>().material = Resources.Load<Material>("Materials/_RuntimeGizmo/Bipolar");
						break;
					}
					isSetup = true;
				}
			}
			else if ((bool)inEditorMagnetPoint)
			{
				UnityEngine.Object.DestroyImmediate(inEditorMagnetPoint);
			}
		}

		protected void OnDrawGizmos()
		{
			switch (PointType)
			{
			case PointEnd.Positive:
			{
				Gizmos.color = new Color(1f, 0.5f, 0f);
				Vector3 vector2 = new Vector3(roadWidth / 3.5f, 0f, 0f);
				Gizmos.DrawLine(base.transform.position - vector2, base.transform.position + vector2);
				vector2 = new Vector3(0f, 0f, roadWidth / 3.5f);
				Gizmos.DrawLine(base.transform.position - vector2, base.transform.position + vector2);
				Gizmos.DrawCube(base.transform.position, new Vector3(0.05f, 0.05f, 0.05f));
				break;
			}
			case PointEnd.Negative:
			{
				Gizmos.color = Color.blue;
				Vector3 vector = new Vector3(roadWidth / 3.5f, 0f, 0f);
				Gizmos.DrawLine(base.transform.position - vector, base.transform.position + vector);
				Gizmos.DrawCube(base.transform.position, new Vector3(0.05f, 0.05f, 0.05f));
				break;
			}
			case PointEnd.Bipolar:
				break;
			}
		}
	}
	[Serializable]
	[ExecuteInEditMode]
	[AddComponentMenu("")]
	[RequireComponent(typeof(MeshFilter))]
	[RequireComponent(typeof(MeshRenderer))]
	[RequireComponent(typeof(MeshCollider))]
	public class Intersection : MonoBehaviour
	{
		public enum IntersectionType
		{
			ThreeLane = 3,
			FourLane
		}

		[Tooltip("Road Material")]
		public Material surfaceMaterial;

		[Tooltip("Roadside Material")]
		public Material sideMaterial;

		[Tooltip("Road width value")]
		public float roadWidth;

		[Tooltip("Depth of the road's sides")]
		public float sideDepth;

		[Tooltip("Slope of the road's sides")]
		public float slopeWidth;

		[HideInInspector]
		public string uniqueConnectionId;

		[SerializeField]
		[HideInInspector]
		protected string connectedUniqueId0;

		[SerializeField]
		[HideInInspector]
		protected string connectedUniqueId1;

		[SerializeField]
		[HideInInspector]
		protected string connectedUniqueId2;

		[SerializeField]
		[HideInInspector]
		protected string connectedUniqueId3;

		private static Material sDefaultRoadMat;

		private static Material sDefaultSideMat;

		private GameObject[] connections = new GameObject[0];

		private Material cachedSideMaterial;

		private Vector3 cachedPosition;

		private Quaternion cachedRotation;

		private float cachedRoadWidth;

		private float cachedSideDepth;

		private float cachedSlopeWidth;

		private Mesh mesh;

		private MeshFilter meshFilter;

		private MeshCollider meshCollider;

		private GameObject snapNodeParent;

		[SerializeField]
		[HideInInspector]
		private IntersectionType intersectionType;

		private Gizmo gizmo;

		private GizmoSelectable gizmoSelect;

		[SerializeField]
		[Tooltip("Set this Intersection to be editable at runtime")]
		private bool isEditableAtRuntime;

		public GameObject[] Connections => connections;

		public SnapPoint[] SnapNodes => base.gameObject.GetComponentsInChildren<SnapPoint>();

		public IntersectionType CurrentIntersectionType => intersectionType;

		public bool IsEditableAtRuntime => isEditableAtRuntime;

		public void SetUp(IntersectionType type)
		{
			intersectionType = type;
			if (roadWidth.Equals(0f))
			{
				roadWidth = 0.5f;
			}
			if (sideDepth.Equals(0f))
			{
				sideDepth = 0.2f;
			}
			cachedPosition = base.transform.position;
			cachedRotation = base.transform.rotation;
			cachedRoadWidth = roadWidth;
			cachedSideDepth = sideDepth;
			cachedSlopeWidth = slopeWidth;
			if (!sDefaultRoadMat)
			{
				sDefaultRoadMat = ((intersectionType == IntersectionType.ThreeLane) ? Resources.Load<Material>("Materials/asphalt_threeway") : Resources.Load<Material>("Materials/asphalt_fourway"));
			}
			if (!sDefaultSideMat)
			{
				sDefaultSideMat = Resources.Load<Material>("Materials/road_sides");
			}
			if ((bool)sDefaultRoadMat && !surfaceMaterial)
			{
				surfaceMaterial = sDefaultRoadMat;
			}
			if ((bool)sDefaultSideMat && !sideMaterial)
			{
				sideMaterial = sDefaultSideMat;
			}
			if (uniqueConnectionId == null)
			{
				uniqueConnectionId = Guid.NewGuid().ToString();
			}
			GenerateIntersectionMesh();
			connections = new GameObject[(int)intersectionType];
		}

		protected void Start()
		{
			if (connections.Length == 0)
			{
				SetUp(intersectionType);
			}
		}

		protected void Update()
		{
			if (connections.Length != 0)
			{
				if (!connections[0] && !string.IsNullOrEmpty(connectedUniqueId0))
				{
					connections[0] = MagnetRoad.FindGameObjectWithUniqueConnectionId(connectedUniqueId0);
					if (!connections[0])
					{
						connectedUniqueId0 = "";
					}
				}
				if (!connections[1] && !string.IsNullOrEmpty(connectedUniqueId1))
				{
					connections[1] = MagnetRoad.FindGameObjectWithUniqueConnectionId(connectedUniqueId1);
					if (!connections[1])
					{
						connectedUniqueId1 = "";
					}
				}
				if (!connections[2] && !string.IsNullOrEmpty(connectedUniqueId2))
				{
					connections[2] = MagnetRoad.FindGameObjectWithUniqueConnectionId(connectedUniqueId2);
					if (!connections[2])
					{
						connectedUniqueId2 = "";
					}
				}
				if (intersectionType > IntersectionType.ThreeLane && !connections[3] && !string.IsNullOrEmpty(connectedUniqueId3))
				{
					connections[3] = MagnetRoad.FindGameObjectWithUniqueConnectionId(connectedUniqueId3);
					if (!connections[3])
					{
						connectedUniqueId3 = "";
					}
				}
			}
			if (isEditableAtRuntime && !gizmo)
			{
				gizmo = UnityEngine.Object.FindObjectOfType<Gizmo>();
			}
			if (isEditableAtRuntime)
			{
				if (base.transform.position != cachedPosition || base.transform.rotation != cachedRotation || !roadWidth.Equals(cachedRoadWidth) || !sideDepth.Equals(cachedSideDepth) || !slopeWidth.Equals(cachedSlopeWidth))
				{
					GenerateIntersectionMesh();
				}
				cachedRoadWidth = roadWidth;
				cachedSideDepth = sideDepth;
				cachedSlopeWidth = slopeWidth;
			}
			if (isEditableAtRuntime && Application.isPlaying)
			{
				gizmoSelect = (GetComponent<GizmoSelectable>() ? GetComponent<GizmoSelectable>() : base.gameObject.AddComponent<GizmoSelectable>());
			}
			else
			{
				if ((bool)gizmo && gizmo.selectedObjects.Any((Transform selectedObj) => selectedObj.gameObject == base.gameObject))
				{
					gizmo.ClearSelection();
					gizmo.Hide();
				}
				UnityEngine.Object.DestroyImmediate(gizmoSelect);
			}
			if (roadWidth < 0f)
			{
				roadWidth = 0.01f;
			}
			if (slopeWidth < 0f)
			{
				slopeWidth = 0f;
			}
			if (base.transform.position != cachedPosition || cachedRotation != base.transform.rotation)
			{
				for (int i = 0; i < Connections.Length; i++)
				{
					CheckForDisconnect(i);
				}
				cachedRotation = base.transform.rotation;
				cachedPosition = base.transform.position;
			}
			SnapPoint[] snapNodes = SnapNodes;
			foreach (SnapPoint snapPoint in snapNodes)
			{
				if (snapPoint.isEditableAtRuntime != IsEditableAtRuntime)
				{
					snapPoint.isEditableAtRuntime = IsEditableAtRuntime;
				}
			}
			if (!gizmo)
			{
				return;
			}
			snapNodes = SnapNodes;
			foreach (SnapPoint snapPoint2 in snapNodes)
			{
				if ((bool)snapPoint2.GetComponent<Renderer>())
				{
					snapPoint2.GetComponent<Renderer>().enabled = !gizmo.selectedObjects.Contains(base.transform);
				}
			}
		}

		protected void OnDrawGizmos()
		{
		}

		public void GenerateIntersectionMesh()
		{
			cachedRotation = base.transform.rotation;
			if ((bool)base.transform.Find("Intersection Sides"))
			{
				cachedSideMaterial = base.transform.Find("Intersection Sides").gameObject.GetComponent<Renderer>().sharedMaterial;
			}
			SnapPoint[] snapNodes = SnapNodes;
			for (int i = 0; i < snapNodes.Length; i++)
			{
				UnityEngine.Object.DestroyImmediate(snapNodes[i].gameObject);
			}
			if ((bool)snapNodeParent)
			{
				UnityEngine.Object.DestroyImmediate(snapNodeParent);
			}
			if ((bool)base.transform.Find("Intersection Underside"))
			{
				UnityEngine.Object.DestroyImmediate(base.transform.Find("Intersection Underside").gameObject);
			}
			if ((bool)base.transform.Find("Intersection Sides"))
			{
				UnityEngine.Object.DestroyImmediate(base.transform.Find("Intersection Sides").gameObject);
			}
			if ((bool)base.transform.Find("Snap Points"))
			{
				UnityEngine.Object.DestroyImmediate(base.transform.Find("Snap Points").gameObject);
			}
			base.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			try
			{
				meshFilter = GetComponent<MeshFilter>();
			}
			catch (NullReferenceException)
			{
				meshFilter = base.gameObject.AddComponent<MeshFilter>();
			}
			try
			{
				GetComponent<MeshRenderer>();
			}
			catch (NullReferenceException)
			{
				base.gameObject.AddComponent<MeshRenderer>();
			}
			try
			{
				meshCollider = GetComponent<MeshCollider>();
			}
			catch (NullReferenceException)
			{
				meshCollider = base.gameObject.AddComponent<MeshCollider>();
			}
			mesh = Geometry.GeneratePlaneMesh(roadWidth, roadWidth);
			mesh.name = "Procedural Intersection";
			meshFilter.mesh = mesh;
			meshCollider.sharedMesh = mesh;
			if ((bool)surfaceMaterial)
			{
				GetComponent<Renderer>().sharedMaterial = surfaceMaterial;
			}
			snapNodeParent = new GameObject();
			snapNodeParent.transform.position = base.transform.position;
			snapNodeParent.transform.parent = base.transform;
			snapNodeParent.name = "Snap Points";
			GameObject obj = new GameObject();
			Mesh sharedMesh = Geometry.GenerateTetrahedron(roadWidth, roadWidth, sideDepth, roadWidth + slopeWidth, roadWidth + slopeWidth, capTop: false, capBottom: false);
			obj.AddComponent<MeshFilter>().mesh = sharedMesh;
			obj.AddComponent<MeshRenderer>();
			obj.AddComponent<MeshCollider>().sharedMesh = sharedMesh;
			obj.GetComponent<Renderer>().sharedMaterial = ((!sideMaterial) ? cachedSideMaterial : sideMaterial);
			obj.transform.position = base.transform.position;
			obj.transform.SetParent(base.transform);
			obj.name = "Intersection Sides";
			GameObject obj2 = new GameObject();
			Mesh sharedMesh2 = Geometry.GeneratePlaneMesh(roadWidth, roadWidth);
			obj2.AddComponent<MeshFilter>().mesh = sharedMesh2;
			obj2.AddComponent<MeshRenderer>();
			obj2.AddComponent<MeshCollider>().sharedMesh = sharedMesh2;
			obj2.GetComponent<Renderer>().sharedMaterial = ((!sideMaterial) ? cachedSideMaterial : sideMaterial);
			obj2.transform.position = new Vector3(base.transform.position.x, base.transform.position.y - sideDepth, base.transform.position.z);
			obj2.transform.Rotate(new Vector3(180f, 0f, 0f));
			obj2.transform.SetParent(base.transform);
			obj2.gameObject.hideFlags = HideFlags.HideInHierarchy;
			obj2.name = "Intersection Underside";
			switch (intersectionType)
			{
			case IntersectionType.ThreeLane:
				CreateSnapPoint(Vector3.left * (roadWidth / 2f), Quaternion.Euler(0f, -90f, 0f), SnapPoint.PointEnd.Bipolar, "SnapPoint1");
				CreateSnapPoint(Vector3.forward * (roadWidth / 2f), Quaternion.Euler(0f, 0f, 0f), SnapPoint.PointEnd.Bipolar, "SnapPoint2");
				CreateSnapPoint(Vector3.right * (roadWidth / 2f), Quaternion.Euler(0f, 90f, 0f), SnapPoint.PointEnd.Bipolar, "SnapPoint3");
				break;
			case IntersectionType.FourLane:
				CreateSnapPoint(Vector3.left * (roadWidth / 2f), Quaternion.Euler(0f, -90f, 0f), SnapPoint.PointEnd.Bipolar, "SnapPoint1");
				CreateSnapPoint(Vector3.forward * (roadWidth / 2f), Quaternion.Euler(0f, 0f, 0f), SnapPoint.PointEnd.Bipolar, "SnapPoint2");
				CreateSnapPoint(Vector3.right * (roadWidth / 2f), Quaternion.Euler(0f, 90f, 0f), SnapPoint.PointEnd.Bipolar, "SnapPoint3");
				CreateSnapPoint(Vector3.back * (roadWidth / 2f), Quaternion.Euler(0f, 180f, 0f), SnapPoint.PointEnd.Bipolar, "SnapPoint4");
				break;
			}
			base.transform.rotation = cachedRotation;
		}

		private void CreateSnapPoint(Vector3 offset, Quaternion rotation, SnapPoint.PointEnd polarity, string pointName)
		{
			GameObject obj = new GameObject();
			obj.AddComponent<SnapPoint>().SetUp(polarity, roadWidth);
			obj.transform.position = base.transform.position + offset;
			obj.transform.rotation = rotation;
			obj.transform.parent = snapNodeParent.transform;
			obj.name = pointName;
		}

		public void AttachMagnetRoad(int entranceNo)
		{
			if (entranceNo < 0 || entranceNo > (int)(intersectionType - 1))
			{
				throw new IndexOutOfRangeException("Entrance number out of range!");
			}
			Vector3[] array = new Vector3[4];
			float num = roadWidth * 2f * 3f;
			Vector3 forward = SnapNodes[entranceNo].transform.forward;
			Vector3 position = SnapNodes[entranceNo].transform.position + forward * (num / 2f);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = SnapNodes[entranceNo].transform.position + forward * (num / 3f * (float)i);
			}
			MagnetRoad component = MagnetRoad.CreateNewSplineRoad().GetComponent<MagnetRoad>();
			component.transform.position = position;
			component.splineSource.SetControlPoint(0, component.splineSource.transform.InverseTransformPoint(array[0]));
			component.splineSource.SetControlPoint(3, component.splineSource.transform.InverseTransformPoint(array[3]));
			component.splineSource.SetControlPoint(1, component.splineSource.transform.InverseTransformPoint(array[1]));
			component.splineSource.SetControlPoint(2, component.splineSource.transform.InverseTransformPoint(array[2]));
			component.roadWidth = roadWidth;
			component.sideDepth = sideDepth;
			component.slopeWidth = slopeWidth;
			component.surfaceMaterial = surfaceMaterial;
			component.sideMaterial = sideMaterial;
			component.GenerateRoadMesh(component.GenerateRoadVertexOutput(component.roadWidth));
			component.uniqueConnectionId = Guid.NewGuid().ToString();
			component.AddConnection(atPositive: true, this, entranceNo);
			AddConnection(entranceNo, component);
		}

		public void CheckForDisconnect(int entranceNo)
		{
			GameObject gameObject = connections[entranceNo];
			if ((bool)gameObject)
			{
				MagnetRoad component = gameObject.GetComponent<MagnetRoad>();
				bool flag = component.GetPositiveConnection() == base.gameObject;
				if (Vector3.Distance(flag ? component.SnapNodePositive.transform.position : component.SnapNodeNegative.transform.position, SnapNodes[entranceNo].transform.position) > roadWidth / 3f)
				{
					RemoveConnection(entranceNo);
					component.RemoveConnection(flag);
				}
			}
		}

		public void AddConnection(int entranceNo, MagnetRoad connection)
		{
			connections[entranceNo] = connection.gameObject;
			SetConnectionUniqueId(entranceNo, connection.uniqueConnectionId);
		}

		public void RemoveConnection(int entranceNo)
		{
			if ((bool)connections[entranceNo])
			{
				connections[entranceNo] = null;
				SetConnectionUniqueId(entranceNo, "");
			}
		}

		public void SetConnectionUniqueId(int entranceNo, string uniqueId)
		{
			if (entranceNo == 0)
			{
				connectedUniqueId0 = uniqueId;
			}
			if (entranceNo == 1)
			{
				connectedUniqueId1 = uniqueId;
			}
			if (entranceNo == 2)
			{
				connectedUniqueId2 = uniqueId;
			}
			if (intersectionType >= IntersectionType.FourLane && entranceNo == 3)
			{
				connectedUniqueId3 = uniqueId;
			}
		}

		public string GetConnectionUniqueId(int connectionIndex)
		{
			connectionIndex = Mathf.Clamp(connectionIndex, 0, (int)(intersectionType - 1));
			return connectionIndex switch
			{
				0 => connectedUniqueId0, 
				1 => connectedUniqueId1, 
				2 => connectedUniqueId2, 
				3 => connectedUniqueId3, 
				_ => null, 
			};
		}

		public void EnableRuntimeEditing()
		{
			isEditableAtRuntime = true;
		}

		public void DisableRuntimeEditing()
		{
			isEditableAtRuntime = false;
		}

		public void SaveIntersectionToXml(string path = "DEFAULT_LOCATION")
		{
			try
			{
				MagnetRoadCollection magnetRoadCollection = new MagnetRoadCollection();
				magnetRoadCollection.PrepareIntersectionData(new Intersection[1] { this });
				magnetRoadCollection.Save((path == "DEFAULT_LOCATION") ? Path.Combine(Application.persistentDataPath, "RoadData.xml") : path);
			}
			catch (IOException)
			{
				Debug.LogWarning("Failed to save the Intersection to a file, check the selected path.");
			}
		}
	}
	[Serializable]
	[ExecuteInEditMode]
	[AddComponentMenu("")]
	[RequireComponent(typeof(MeshFilter))]
	[RequireComponent(typeof(MeshRenderer))]
	[RequireComponent(typeof(BezierSpline))]
	[RequireComponent(typeof(MeshCollider))]
	public class MagnetRoad : MonoBehaviour
	{
		public const string VERSION_NUMBER = "v2.0.3";

		public const string VERSION_DESCRIPTION = "Magnet Roads for Unity 2017";

		[HideInInspector]
		public BezierSpline splineSource;

		[Tooltip("Road Material")]
		public Material surfaceMaterial;

		[Tooltip("Roadside Material")]
		public Material sideMaterial;

		[Tooltip("Sidewalk Material")]
		public Material sidewalkMaterial;

		public float roadWidth = 0.5f;

		public float sidewalkWidth;

		public float sidewalkHeight;

		[Tooltip("Depth of the road's sides")]
		public float sideDepth = 0.2f;

		[Tooltip("The distance from the bottom of the side ramp to the road side")]
		public float slopeWidth;

		[Tooltip("Steps per curve/mesh resolution")]
		public int stepsPerCurve = 20;

		[Tooltip("Show road outline")]
		public bool showRoadOutline = true;

		[Tooltip("Buffer space at edge of road before lanes start")]
		public float roadsideMargin;

		[Tooltip("Total no. of car lanes on this road")]
		public int totalCarLanes = 2;

		[Tooltip("Show car routes")]
		public bool showCarRoutes = true;

		[Tooltip("Toggle road snapping to terrain")]
		public bool snapRoadToTerrain;

		[Tooltip("Terrain to snap road to")]
		public Terrain terrain;

		[Tooltip("Distance road will be from terrain when snapping")]
		public float distanceFromTerrain = 0.05f;

		[HideInInspector]
		public string uniqueConnectionId;

		[HideInInspector]
		public bool shouldShowAdvancedTools;

		[HideInInspector]
		public Mesh roadsideFencePanelMesh;

		[HideInInspector]
		public Vector2 roadsideFencePanelScaling = new Vector2(1f, 1f);

		[HideInInspector]
		public Vector3 roadsideFencePanelRotation;

		[HideInInspector]
		public Material roadsideFencePanelMaterial;

		[HideInInspector]
		public Mesh roadsideFencePostMesh;

		[HideInInspector]
		public Vector3 roadsideFencePostScaling = new Vector3(1f, 1f, 1f);

		[HideInInspector]
		public Vector3 roadsideFencePostRotation;

		[HideInInspector]
		public Material roadsideFencePostMaterial;

		[HideInInspector]
		public float fenceDistanceFromRoad;

		[HideInInspector]
		public Mesh centerFencePanelMesh;

		[HideInInspector]
		public Vector2 centerFencePanelScaling = new Vector2(1f, 1f);

		[HideInInspector]
		public Vector3 centerFencePanelRotation;

		[HideInInspector]
		public Material centerFencePanelMaterial;

		[HideInInspector]
		public Mesh centerFencePostMesh;

		[HideInInspector]
		public Vector3 centerFencePostScaling = new Vector3(1f, 1f, 1f);

		[HideInInspector]
		public Vector3 centerFencePostRotation;

		[HideInInspector]
		public Material centerFencePostMaterial;

		[HideInInspector]
		public Vector2 reservationDimensions = new Vector3(0f, 0f, 0f);

		[HideInInspector]
		public float reservationSlope;

		[HideInInspector]
		public Material reservationTopMaterial;

		[HideInInspector]
		public Material reservationSideMaterial;

		[HideInInspector]
		public Mesh centerObjectMesh;

		[HideInInspector]
		public int centerObjectsToSpawn;

		[HideInInspector]
		public Vector3 centerObjectScaling = new Vector3(0f, 0f, 0f);

		[HideInInspector]
		public Vector3 centerObjectRotation;

		[HideInInspector]
		public Material centerObjectMaterial;

		[SerializeField]
		[HideInInspector]
		private string positiveConnectionUniqueId;

		[SerializeField]
		[HideInInspector]
		private string negativeConnectionUniqueId;

		private static Material sDefaultRoadMat;

		private static Material sDefaultSideMat;

		private GameObject positiveConnection;

		private GameObject negativeConnection;

		private GameObject leftSide;

		private GameObject rightSide;

		private GameObject frontSide;

		private GameObject backSide;

		private GameObject underSide;

		private GameObject leftSidewalk;

		private GameObject rightSidewalk;

		private Material cachedSideMaterial;

		private Mesh mesh;

		private MeshFilter meshFilter;

		private MeshCollider meshCollider;

		private Gizmo gizmo;

		private GizmoSelectable gizmoSelect;

		private LineRenderer runtimeCurveLine;

		private LineRenderer[] runtimeHandleLines;

		private GameObject[] runtimeHandles;

		private Vector3[] cachedPointVectors;

		private Vector3 cachedTransformPosition;

		[SerializeField]
		[Tooltip("Set this Magnet Road to be editable at runtime")]
		private bool editAtRuntime;

		[SerializeField]
		[Tooltip("Show child objects, like road sides etc. in the hierarchy")]
		private bool showChildObjects;

		public string PositiveConnectionUniqueId
		{
			get
			{
				return positiveConnectionUniqueId;
			}
			private set
			{
				if (positiveConnectionUniqueId == null)
				{
					positiveConnectionUniqueId = value;
				}
			}
		}

		public string NegativeConnectionUniqueId
		{
			get
			{
				return negativeConnectionUniqueId;
			}
			private set
			{
				if (negativeConnectionUniqueId == null)
				{
					negativeConnectionUniqueId = value;
				}
			}
		}

		public GameObject SnapNodeNegative { get; private set; }

		public GameObject SnapNodePositive { get; private set; }

		public bool IsEditableAtRuntime => editAtRuntime;

		protected void Awake()
		{
			if (splineSource == null)
			{
				try
				{
					splineSource = GetComponent<BezierSpline>();
				}
				catch (NullReferenceException)
				{
					Debug.LogWarning("Spline Road missing Bezier Spline! Component added automatically.");
					splineSource = base.gameObject.AddComponent<BezierSpline>();
				}
			}
			if (uniqueConnectionId == null)
			{
				uniqueConnectionId = Guid.NewGuid().ToString();
			}
			if (!sDefaultRoadMat)
			{
				sDefaultRoadMat = Resources.Load<Material>("Materials/asphalt_road");
			}
			if (!sDefaultSideMat)
			{
				sDefaultSideMat = Resources.Load<Material>("Materials/road_sides");
			}
			if ((bool)sDefaultRoadMat)
			{
				surfaceMaterial = sDefaultRoadMat;
			}
			if ((bool)sDefaultSideMat)
			{
				sideMaterial = sDefaultSideMat;
			}
			runtimeHandles = new GameObject[0];
			runtimeHandleLines = new LineRenderer[0];
			cachedPointVectors = new Vector3[0];
			cachedTransformPosition = base.transform.position;
		}

		protected void Start()
		{
			CleanupRuntimeHandles();
			InitializeRuntimeHandles();
		}

		protected void OnDrawGizmos()
		{
			if (showCarRoutes)
			{
				DrawCarPaths();
			}
			if (showRoadOutline)
			{
				DrawRoadOutline(GenerateRoadVertexOutput(roadWidth));
				DrawRoadOutline(GenerateLeftRoadSideVectors(GenerateRoadVertexOutput(roadWidth + sidewalkWidth * 2f)));
				DrawRoadOutline(GenerateRightRoadSideVectors(GenerateRoadVertexOutput(roadWidth + sidewalkWidth * 2f)));
			}
		}

		protected void Update()
		{
			if (!Application.isPlaying || IsEditableAtRuntime)
			{
				roadWidth = Mathf.Clamp(roadWidth, 1E-05f, float.MaxValue);
				stepsPerCurve = Mathf.Clamp(stepsPerCurve, 1, int.MaxValue);
				totalCarLanes = Mathf.Clamp(totalCarLanes, 1, int.MaxValue);
				roadsideMargin = Mathf.Clamp(roadsideMargin, 0f, roadWidth / 2f);
			}
			if (!positiveConnection && !string.IsNullOrEmpty(positiveConnectionUniqueId))
			{
				positiveConnection = FindGameObjectWithUniqueConnectionId(positiveConnectionUniqueId);
				if (!positiveConnection)
				{
					positiveConnectionUniqueId = "";
				}
			}
			if (!negativeConnection && !string.IsNullOrEmpty(negativeConnectionUniqueId))
			{
				negativeConnection = FindGameObjectWithUniqueConnectionId(negativeConnectionUniqueId);
				if (!negativeConnection)
				{
					positiveConnectionUniqueId = "";
				}
			}
			if (!SnapNodeNegative || !SnapNodePositive)
			{
				try
				{
					SnapNodeNegative = base.transform.Find("SnapNodeNegative").gameObject;
					SnapNodePositive = base.transform.Find("SnapNodePositive").gameObject;
				}
				catch (NullReferenceException ex)
				{
					Debug.LogError(base.name + " has no Snap Nodes attached! Please regenerate the road mesh! " + ex);
					throw;
				}
			}
			base.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			base.transform.localScale = new Vector3(1f, 1f, 1f);
			if (base.transform.position != cachedTransformPosition)
			{
				cachedTransformPosition = base.transform.position;
				UpdateConnections();
			}
			if (snapRoadToTerrain && (bool)terrain)
			{
				for (int i = 0; i < splineSource.ControlPointCount; i++)
				{
					if ((i > 1 || !(GetPositiveConnection_Intersection() != null)) && (i < splineSource.ControlPointCount - 2 || !(GetNegativeConnection_Intersection() != null)) && i % 3 == 0)
					{
						Vector3 vector = splineSource.transform.TransformPoint(splineSource.GetControlPoint(i));
						vector.y = terrain.SampleHeight(vector) + distanceFromTerrain;
						vector = base.transform.InverseTransformPoint(vector);
						splineSource.SetControlPoint(i, vector);
					}
				}
			}
			if ((bool)SnapNodePositive.GetComponent<SnapPoint>())
			{
				SnapNodePositive.GetComponent<SnapPoint>().isEditableAtRuntime = editAtRuntime;
			}
			if ((bool)SnapNodeNegative.GetComponent<SnapPoint>())
			{
				SnapNodeNegative.GetComponent<SnapPoint>().isEditableAtRuntime = editAtRuntime;
			}
			if (editAtRuntime && Application.isPlaying)
			{
				if (!gizmo && (bool)UnityEngine.Object.FindObjectOfType<Gizmo>())
				{
					gizmo = UnityEngine.Object.FindObjectOfType<Gizmo>();
				}
				if ((bool)runtimeCurveLine && !runtimeCurveLine.enabled)
				{
					runtimeCurveLine.enabled = true;
				}
				if ((bool)GetComponent<GizmoSelectable>())
				{
					gizmoSelect = GetComponent<GizmoSelectable>();
				}
				if (!gizmoSelect || !gizmoSelect.GetComponent<GizmoSelectable>())
				{
					gizmoSelect = base.gameObject.AddComponent<GizmoSelectable>();
				}
				if (runtimeHandles.Length < 1)
				{
					CleanupRuntimeHandles();
					InitializeRuntimeHandles();
				}
				if ((bool)gizmo && gizmo.selectedObjects.Contains(base.transform))
				{
					GenerateRoadMesh(GenerateRoadVertexOutput(roadWidth));
				}
			}
			else
			{
				CleanupRuntimeHandles();
				if ((bool)gizmo)
				{
					UnityEngine.Object.DestroyImmediate(gizmo);
				}
			}
			UpdateRuntimeHandles();
			cachedPointVectors = new Vector3[splineSource.ControlPointCount];
			for (int j = 0; j < splineSource.ControlPointCount; j++)
			{
				cachedPointVectors[j] = splineSource.GetControlPoint(j);
			}
		}

		public Pair<Vector3>[] GenerateRoadVertexOutput(float width)
		{
			Pair<Vector3>[] array = new Pair<Vector3>[stepsPerCurve * splineSource.CurveCount + 1];
			int num = 0;
			float num2 = width / 2f;
			Vector3 point = splineSource.GetPoint(0f);
			Pair<Vector3> pair = default(Pair<Vector3>);
			Vector3 value = new Vector3(0f, 90f, 0f);
			Vector3 vector = point + splineSource.GetRotation(0f, value) * num2;
			pair.First = new Vector3(vector.x, point.y, vector.z);
			Vector3 vector2 = point + splineSource.GetRotation(0f, value) * (0f - num2);
			pair.Second = new Vector3(vector2.x, point.y, vector2.z);
			array[num] = pair;
			int num3 = stepsPerCurve * splineSource.CurveCount;
			int num4 = 0;
			while (num4 <= num3)
			{
				point = splineSource.GetPoint((float)num4 / (float)num3);
				vector = point + splineSource.GetRotation((float)num4 / (float)num3, value) * num2;
				if ((bool)terrain && snapRoadToTerrain)
				{
					vector.y = terrain.SampleHeight(new Vector3(vector.x, point.y, vector.z)) + distanceFromTerrain;
				}
				else
				{
					vector.y = point.y;
				}
				pair.First = new Vector3(vector.x, vector.y, vector.z);
				vector2 = point + splineSource.GetRotation((float)num4 / (float)num3, value) * (0f - num2);
				if ((bool)terrain && snapRoadToTerrain)
				{
					vector2.y = terrain.SampleHeight(new Vector3(vector2.x, point.y, vector2.z)) + distanceFromTerrain;
				}
				else
				{
					vector2.y = point.y;
				}
				pair.Second = new Vector3(vector2.x, vector2.y, vector2.z);
				array[num] = pair;
				num4++;
				num++;
			}
			MagnetRoad negativeConnection_MagnetRoad = GetNegativeConnection_MagnetRoad();
			if ((bool)negativeConnection_MagnetRoad && (negativeConnection_MagnetRoad.snapRoadToTerrain || snapRoadToTerrain))
			{
				MagnetRoad magnetRoad = (snapRoadToTerrain ? this : negativeConnection_MagnetRoad);
				Vector3 first = array[array.Length - 1].First;
				first.y = (vector.y = magnetRoad.terrain.SampleHeight(new Vector3(first.x, first.y, first.z)) + magnetRoad.distanceFromTerrain);
				array[array.Length - 1].First = first;
				Vector3 second = array[array.Length - 1].Second;
				second.y = (vector.y = magnetRoad.terrain.SampleHeight(new Vector3(second.x, second.y, second.z)) + magnetRoad.distanceFromTerrain);
				array[array.Length - 1].Second = second;
			}
			negativeConnection_MagnetRoad = GetPositiveConnection_MagnetRoad();
			if ((bool)negativeConnection_MagnetRoad && (negativeConnection_MagnetRoad.snapRoadToTerrain || snapRoadToTerrain))
			{
				MagnetRoad magnetRoad2 = (snapRoadToTerrain ? this : negativeConnection_MagnetRoad);
				Vector3 first2 = array[0].First;
				first2.y = (vector.y = magnetRoad2.terrain.SampleHeight(new Vector3(first2.x, first2.y, first2.z)) + magnetRoad2.distanceFromTerrain);
				array[0].First = first2;
				Vector3 second2 = array[0].Second;
				second2.y = (vector.y = magnetRoad2.terrain.SampleHeight(new Vector3(second2.x, second2.y, second2.z)) + magnetRoad2.distanceFromTerrain);
				array[0].Second = second2;
			}
			Intersection negativeConnection_Intersection = GetNegativeConnection_Intersection();
			if ((bool)negativeConnection_Intersection)
			{
				for (int i = 0; i < negativeConnection_Intersection.Connections.Length; i++)
				{
					if ((bool)negativeConnection_Intersection.Connections[i] && !(negativeConnection_Intersection.Connections[i] != base.gameObject))
					{
						SnapPoint snapPoint = negativeConnection_Intersection.SnapNodes[i];
						array[array.Length - 1].First = snapPoint.transform.position - snapPoint.transform.right * (width / 2f);
						array[array.Length - 1].Second = snapPoint.transform.position + snapPoint.transform.right * (width / 2f);
					}
				}
			}
			negativeConnection_Intersection = GetPositiveConnection_Intersection();
			if (!negativeConnection_Intersection)
			{
				return array;
			}
			for (int j = 0; j < negativeConnection_Intersection.Connections.Length; j++)
			{
				if ((bool)negativeConnection_Intersection.Connections[j] && !(negativeConnection_Intersection.Connections[j] != base.gameObject))
				{
					SnapPoint snapPoint2 = negativeConnection_Intersection.SnapNodes[j];
					array[0].First = snapPoint2.transform.position + snapPoint2.transform.right * (width / 2f);
					array[0].Second = snapPoint2.transform.position - snapPoint2.transform.right * (width / 2f);
				}
			}
			return array;
		}

		private Pair<Vector3>[] GenerateLeftRoadSideVectors(Pair<Vector3>[] vertexData)
		{
			Pair<Vector3>[] array = GenerateRoadVertexOutput(roadWidth + slopeWidth);
			for (int i = 0; i < vertexData.Length; i++)
			{
				vertexData[i].Second = new Vector3(array[i].First.x, array[i].First.y - sideDepth, array[i].First.z);
			}
			return vertexData;
		}

		private Pair<Vector3>[] GenerateRightRoadSideVectors(Pair<Vector3>[] vertexData)
		{
			Pair<Vector3>[] array = GenerateRoadVertexOutput(roadWidth + slopeWidth);
			for (int i = 0; i < vertexData.Length; i++)
			{
				vertexData[i].First = new Vector3(array[i].Second.x, array[i].Second.y - sideDepth, array[i].Second.z);
			}
			return vertexData;
		}

		private void GenerateSidewalkVectors(out Pair<Vector3>[] leftSideVectors, out Pair<Vector3>[] rightSideVectors)
		{
			Pair<Vector3>[] array = GenerateRoadVertexOutput(roadWidth);
			Pair<Vector3>[] array2 = GenerateRoadVertexOutput(roadWidth + sidewalkWidth * 2f);
			List<Pair<Vector3>> list = new List<Pair<Vector3>>();
			List<Pair<Vector3>> list2 = new List<Pair<Vector3>>();
			for (int i = 0; i < array.Length; i++)
			{
				list.Add(new Pair<Vector3>(array[i].First + Vector3.up * sidewalkHeight, array2[i].First + Vector3.up * (sidewalkHeight - 0.005f)));
				list2.Add(new Pair<Vector3>(array[i].Second + Vector3.up * sidewalkHeight, array2[i].Second + Vector3.up * (sidewalkHeight - 0.005f)));
			}
			list.Add(new Pair<Vector3>(array[array.Length - 1].First, array2[array2.Length - 1].First));
			list2.Add(new Pair<Vector3>(array[array.Length - 1].Second, array2[array2.Length - 1].Second));
			for (int num = array2.Length - 1; num >= 0; num--)
			{
				list.Add(new Pair<Vector3>(array2[num].First, array2[num].First + Vector3.up * (sidewalkHeight - 0.005f)));
				list2.Add(new Pair<Vector3>(array2[num].Second, array2[num].Second + Vector3.up * (sidewalkHeight - 0.005f)));
			}
			Pair<Vector3>[] array3 = array;
			for (int j = 0; j < array3.Length; j++)
			{
				Pair<Vector3> pair = array3[j];
				list.Add(new Pair<Vector3>(pair.First, pair.First + Vector3.up * sidewalkHeight));
				list2.Add(new Pair<Vector3>(pair.Second, pair.Second + Vector3.up * sidewalkHeight));
			}
			leftSideVectors = list.ToArray();
			rightSideVectors = list2.ToArray();
		}

		public void GenerateRoadMesh(Pair<Vector3>[] vertexData)
		{
			try
			{
				meshFilter = GetComponent<MeshFilter>();
			}
			catch (NullReferenceException)
			{
				meshFilter = base.gameObject.AddComponent<MeshFilter>();
			}
			try
			{
				GetComponent<MeshRenderer>();
			}
			catch (NullReferenceException)
			{
				base.gameObject.AddComponent<MeshRenderer>();
			}
			try
			{
				meshCollider = GetComponent<MeshCollider>();
			}
			catch (NullReferenceException)
			{
				meshCollider = base.gameObject.AddComponent<MeshCollider>();
			}
			mesh = new Mesh();
			meshFilter.mesh = Geometry.GenerateStrip(vertexData, base.transform, flipNormals: true, false, "Procedural Road");
			meshCollider.sharedMesh = meshFilter.sharedMesh;
			if ((bool)surfaceMaterial)
			{
				base.gameObject.GetComponent<Renderer>().sharedMaterial = surfaceMaterial;
			}
			if (!SnapNodeNegative || !SnapNodePositive)
			{
				GenerateSnapPoints(splineSource);
			}
			UpdateSnapPoints();
			GenerateSideMeshes(GenerateLeftRoadSideVectors(GenerateRoadVertexOutput(roadWidth + sidewalkWidth * 2f)), GenerateRightRoadSideVectors(GenerateRoadVertexOutput(roadWidth + sidewalkWidth * 2f)));
		}

		private void GenerateSideMeshes(Pair<Vector3>[] leftSideVectors, Pair<Vector3>[] rightSideVectors)
		{
			if ((bool)base.transform.Find("Road Side One"))
			{
				cachedSideMaterial = base.transform.Find("Road Side One").gameObject.GetComponent<Renderer>().sharedMaterial;
				UnityEngine.Object.DestroyImmediate(base.transform.Find("Road Side One").gameObject);
			}
			if ((bool)base.transform.Find("Road Left Sidewalk"))
			{
				UnityEngine.Object.DestroyImmediate(base.transform.Find("Road Left Sidewalk").gameObject);
			}
			if ((bool)base.transform.Find("Road Right Sidewalk"))
			{
				UnityEngine.Object.DestroyImmediate(base.transform.Find("Road Right Sidewalk").gameObject);
			}
			if ((bool)base.transform.Find("Road Side Two"))
			{
				UnityEngine.Object.DestroyImmediate(base.transform.Find("Road Side Two").gameObject);
			}
			if ((bool)base.transform.Find("Road Underside"))
			{
				UnityEngine.Object.DestroyImmediate(base.transform.Find("Road Underside").gameObject);
			}
			if ((bool)base.transform.Find("Road Side Three"))
			{
				UnityEngine.Object.DestroyImmediate(base.transform.Find("Road Side Three").gameObject);
			}
			if ((bool)base.transform.Find("Road Side Four"))
			{
				UnityEngine.Object.DestroyImmediate(base.transform.Find("Road Side Four").gameObject);
			}
			rightSide = new GameObject("Road Side One");
			rightSide.transform.parent = base.gameObject.transform;
			leftSide = new GameObject("Road Side Two");
			leftSide.transform.parent = base.gameObject.transform;
			if (sideDepth >= 0f)
			{
				frontSide = new GameObject("Road Side Three");
				frontSide.transform.parent = base.gameObject.transform;
				backSide = new GameObject("Road Side Four");
				backSide.transform.parent = base.gameObject.transform;
				underSide = new GameObject("Road Underside");
				underSide.transform.parent = base.gameObject.transform;
			}
			if (sidewalkWidth > 0f)
			{
				leftSidewalk = new GameObject("Road Left Sidewalk");
				leftSidewalk.transform.parent = base.gameObject.transform;
				rightSidewalk = new GameObject("Road Right Sidewalk");
				rightSidewalk.transform.parent = base.gameObject.transform;
			}
			if (!showChildObjects)
			{
				if (sideDepth >= 0f)
				{
					underSide.hideFlags = HideFlags.HideInHierarchy;
					backSide.hideFlags = HideFlags.HideInHierarchy;
					frontSide.hideFlags = HideFlags.HideInHierarchy;
				}
				_ = sidewalkWidth;
				_ = 0f;
				leftSide.hideFlags = HideFlags.HideInHierarchy;
				rightSide.hideFlags = HideFlags.HideInHierarchy;
			}
			MeshFilter meshFilter = rightSide.AddComponent<MeshFilter>();
			rightSide.AddComponent<MeshRenderer>();
			meshFilter.mesh = Geometry.GenerateStrip(rightSideVectors, base.transform, flipNormals: false, null, "Road Side One");
			rightSide.AddComponent<MeshCollider>().sharedMesh = meshFilter.sharedMesh;
			rightSide.GetComponent<Renderer>().sharedMaterial = ((!sideMaterial) ? cachedSideMaterial : sideMaterial);
			MeshFilter meshFilter2 = leftSide.AddComponent<MeshFilter>();
			leftSide.AddComponent<MeshRenderer>();
			meshFilter2.mesh = Geometry.GenerateStrip(leftSideVectors, base.transform, flipNormals: false, null, "Road Side Two");
			leftSide.AddComponent<MeshCollider>().sharedMesh = meshFilter2.sharedMesh;
			leftSide.GetComponent<Renderer>().sharedMaterial = ((!sideMaterial) ? cachedSideMaterial : sideMaterial);
			if (sideDepth > 0f)
			{
				MeshFilter meshFilter3 = frontSide.AddComponent<MeshFilter>();
				frontSide.AddComponent<MeshRenderer>();
				meshFilter3.mesh = Geometry.GeneratePlaneMesh(leftSideVectors[0].First, rightSideVectors[0].Second, leftSideVectors[0].Second, rightSideVectors[0].First, flipNormals: true);
				frontSide.AddComponent<MeshCollider>().sharedMesh = meshFilter3.sharedMesh;
				meshFilter3.GetComponent<Renderer>().sharedMaterial = ((!sideMaterial) ? cachedSideMaterial : sideMaterial);
				MeshFilter meshFilter4 = backSide.AddComponent<MeshFilter>();
				backSide.AddComponent<MeshRenderer>();
				meshFilter4.mesh = Geometry.GeneratePlaneMesh(leftSideVectors[leftSideVectors.Length - 1].First, rightSideVectors[rightSideVectors.Length - 1].Second, leftSideVectors[leftSideVectors.Length - 1].Second, rightSideVectors[rightSideVectors.Length - 1].First, flipNormals: false);
				backSide.AddComponent<MeshCollider>().sharedMesh = meshFilter4.sharedMesh;
				meshFilter4.GetComponent<Renderer>().sharedMaterial = ((!sideMaterial) ? cachedSideMaterial : sideMaterial);
				Pair<Vector3>[] array = new Pair<Vector3>[leftSideVectors.Length];
				for (int i = 0; i < leftSideVectors.Length; i++)
				{
					array[i].First = leftSideVectors[i].Second;
					array[i].Second = rightSideVectors[i].First;
				}
				MeshFilter meshFilter5 = underSide.AddComponent<MeshFilter>();
				underSide.AddComponent<MeshRenderer>();
				meshFilter5.mesh = Geometry.GenerateStrip(array, base.transform, flipNormals: false, null, "Road Underside");
				underSide.AddComponent<MeshCollider>().sharedMesh = meshFilter5.sharedMesh;
				underSide.GetComponent<Renderer>().sharedMaterial = ((!sideMaterial) ? cachedSideMaterial : sideMaterial);
				if (!(sidewalkWidth <= 0f))
				{
					GenerateSidewalkVectors(out var leftSideVectors2, out var rightSideVectors2);
					MeshFilter meshFilter6 = leftSidewalk.AddComponent<MeshFilter>();
					leftSidewalk.AddComponent<MeshRenderer>();
					meshFilter6.mesh = Geometry.GenerateStrip(leftSideVectors2, base.transform, flipNormals: false, null, "Road Left Sidewalk");
					leftSidewalk.AddComponent<MeshCollider>().sharedMesh = meshFilter6.sharedMesh;
					leftSidewalk.GetComponent<Renderer>().sharedMaterial = sidewalkMaterial;
					MeshFilter meshFilter7 = rightSidewalk.AddComponent<MeshFilter>();
					rightSidewalk.AddComponent<MeshRenderer>();
					meshFilter7.mesh = Geometry.GenerateStrip(rightSideVectors2, base.transform, flipNormals: true, null, "Road Right Sidewalk");
					rightSidewalk.AddComponent<MeshCollider>().sharedMesh = meshFilter7.sharedMesh;
					rightSidewalk.GetComponent<Renderer>().sharedMaterial = sidewalkMaterial;
				}
			}
		}

		private void GenerateSnapPoints(BezierSpline spline)
		{
			if (((bool)SnapNodeNegative || (bool)SnapNodePositive) && SnapNodeNegative.transform.position == splineSource.GetPoint(stepsPerCurve * spline.CurveCount) && SnapNodePositive.transform.position == splineSource.GetPoint(0f))
			{
				return;
			}
			try
			{
				if ((bool)base.transform.Find("SnapNodeNegative") || (bool)base.transform.Find("SnapNodePositive"))
				{
					if ((bool)base.transform.Find("SnapNodeNegative"))
					{
						UnityEngine.Object.DestroyImmediate(base.transform.Find("SnapNodeNegative").gameObject);
					}
					if ((bool)base.transform.Find("SnapNodePositive"))
					{
						UnityEngine.Object.DestroyImmediate(base.transform.Find("SnapNodePositive").gameObject);
					}
				}
			}
			catch (NullReferenceException)
			{
			}
			Vector3 point = spline.GetPoint(stepsPerCurve * spline.CurveCount);
			Vector3 point2 = spline.GetPoint(0f);
			SnapNodeNegative = new GameObject("SnapNodeNegative");
			SnapNodePositive = new GameObject("SnapNodePositive");
			SnapNodeNegative.transform.parent = base.gameObject.transform;
			SnapNodeNegative.AddComponent<SnapPoint>().SetUp(SnapPoint.PointEnd.Negative, roadWidth);
			SnapNodeNegative.transform.position = point;
			SnapNodePositive.transform.parent = base.gameObject.transform;
			SnapNodePositive.AddComponent<SnapPoint>().SetUp(SnapPoint.PointEnd.Positive, roadWidth);
			SnapNodePositive.transform.position = point2;
		}

		private void UpdateSnapPoints()
		{
			if (!SnapNodeNegative || !SnapNodePositive)
			{
				GenerateSnapPoints(splineSource);
				return;
			}
			Vector3 point = splineSource.GetPoint(stepsPerCurve * splineSource.CurveCount);
			Vector3 point2 = splineSource.GetPoint(0f);
			SnapNodeNegative.GetComponent<SnapPoint>().SetUp(SnapPoint.PointEnd.Negative, roadWidth);
			SnapNodeNegative.transform.position = point;
			SnapNodePositive.GetComponent<SnapPoint>().SetUp(SnapPoint.PointEnd.Positive, roadWidth);
			SnapNodePositive.transform.position = point2;
		}

		public void ClearRoadMesh()
		{
			try
			{
				if ((bool)mesh)
				{
					mesh.Clear();
				}
				meshFilter.sharedMesh.Clear();
				meshCollider.sharedMesh.Clear();
				if ((bool)leftSide)
				{
					UnityEngine.Object.DestroyImmediate(leftSide);
				}
				if ((bool)rightSide)
				{
					UnityEngine.Object.DestroyImmediate(rightSide);
				}
				if ((bool)leftSidewalk)
				{
					UnityEngine.Object.DestroyImmediate(leftSidewalk);
				}
				if ((bool)rightSidewalk)
				{
					UnityEngine.Object.DestroyImmediate(rightSidewalk);
				}
				if ((bool)frontSide)
				{
					UnityEngine.Object.DestroyImmediate(frontSide);
				}
				if ((bool)backSide)
				{
					UnityEngine.Object.DestroyImmediate(backSide);
				}
				if ((bool)underSide)
				{
					UnityEngine.Object.DestroyImmediate(underSide);
				}
			}
			catch (UnassignedReferenceException)
			{
				meshFilter = GetComponent<MeshFilter>();
				meshCollider = GetComponent<MeshCollider>();
				if (base.transform.childCount > 0)
				{
					leftSide = base.transform.Find("Road Side One").gameObject;
					rightSide = base.transform.Find("Road Side Two").gameObject;
					leftSidewalk = base.transform.Find("Road Left Sidewalk").gameObject;
					rightSidewalk = base.transform.Find("Road Right Sidewalk").gameObject;
					frontSide = base.transform.Find("Road Side Three").gameObject;
					backSide = base.transform.Find("Road Side Four").gameObject;
					underSide = base.transform.Find("Road Underside").gameObject;
				}
				ClearRoadMesh();
			}
			catch (Exception ex2)
			{
				Debug.LogWarning("MESH FAILED TO CLEAR: " + ex2);
			}
		}

		public void AddCurve(bool atPositive = false)
		{
			CleanupRuntimeHandles();
			splineSource.AddCurve(stepsPerCurve, atPositive, roadWidth * 2f);
			InitializeRuntimeHandles();
			GenerateRoadMesh(GenerateRoadVertexOutput(roadWidth));
		}

		public void RemoveCurve(bool atPositive)
		{
			CleanupRuntimeHandles();
			splineSource.RemoveCurve(atPositive);
			InitializeRuntimeHandles();
			GenerateRoadMesh(GenerateRoadVertexOutput(roadWidth));
		}

		public void AttachIntersection(bool atPositive, bool threeLane = true)
		{
			Vector3 direction;
			Vector3 position;
			Vector3 vector;
			if (!atPositive)
			{
				direction = splineSource.GetDirection(splineSource.CurveCount * stepsPerCurve);
				position = SnapNodeNegative.transform.position + direction * (roadWidth / 2f);
				vector = SnapNodeNegative.transform.position + direction * roadWidth;
			}
			else
			{
				direction = splineSource.GetDirection(0f);
				position = SnapNodePositive.transform.position - direction * (roadWidth / 2f);
				vector = SnapNodePositive.transform.position - direction * roadWidth;
			}
			direction.y = 0f;
			Intersection intersection = (threeLane ? CreateNewThreeLane().GetComponent<Intersection>() : CreateNewFourLane().GetComponent<Intersection>());
			intersection.roadWidth = roadWidth;
			intersection.transform.position = position;
			intersection.sideDepth = sideDepth;
			intersection.slopeWidth = slopeWidth;
			intersection.uniqueConnectionId = Guid.NewGuid().ToString();
			Quaternion to = Quaternion.LookRotation(vector - intersection.transform.position);
			intersection.transform.rotation = Quaternion.RotateTowards(intersection.transform.rotation, to, 360f);
			if (!atPositive)
			{
				intersection.transform.Rotate(Vector3.up, 90f);
			}
			else
			{
				intersection.transform.Rotate(Vector3.up, -90f);
			}
			intersection.transform.rotation = new Quaternion(0f, intersection.transform.rotation.y, 0f, intersection.transform.rotation.w);
			intersection.GenerateIntersectionMesh();
			if (!atPositive)
			{
				SnapFirstAndLastPoints(splineSource.ControlPointCount - 1);
			}
			else
			{
				SnapFirstAndLastPoints(0);
			}
			SnapFirstAndLastPoints((!atPositive) ? (splineSource.ControlPointCount - 1) : 0);
			GenerateRoadMesh(GenerateRoadVertexOutput(roadWidth));
		}

		public void AttachMagnetRoad(bool atPositive)
		{
			Vector3[] array = new Vector3[4];
			float num = roadWidth * 2f * 3f;
			Vector3 position;
			if (!atPositive)
			{
				Vector3 direction = splineSource.GetDirection(splineSource.CurveCount * stepsPerCurve);
				position = SnapNodeNegative.transform.position + direction * (num / 2f);
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = SnapNodeNegative.transform.position + direction * (num / 3f * (float)i);
				}
			}
			else
			{
				Vector3 direction = splineSource.GetDirection(0f);
				position = SnapNodePositive.transform.position - direction * (num / 2f);
				for (int j = 0; j < array.Length; j++)
				{
					array[j] = SnapNodePositive.transform.position - direction * (num / 3f * (float)j);
				}
			}
			MagnetRoad component = CreateNewSplineRoad().GetComponent<MagnetRoad>();
			component.transform.position = position;
			component.splineSource.SetControlPoint(0, component.splineSource.transform.InverseTransformPoint(array[0]));
			component.splineSource.SetControlPoint(3, component.splineSource.transform.InverseTransformPoint(array[3]));
			component.splineSource.SetControlPoint(1, component.splineSource.transform.InverseTransformPoint(array[1]));
			component.splineSource.SetControlPoint(2, component.splineSource.transform.InverseTransformPoint(array[2]));
			component.roadWidth = roadWidth;
			component.roadsideMargin = roadsideMargin;
			component.totalCarLanes = totalCarLanes;
			component.distanceFromTerrain = distanceFromTerrain;
			component.snapRoadToTerrain = snapRoadToTerrain;
			component.terrain = terrain;
			component.showCarRoutes = showCarRoutes;
			component.showRoadOutline = showRoadOutline;
			component.sideDepth = sideDepth;
			component.slopeWidth = slopeWidth;
			component.GenerateRoadMesh(component.GenerateRoadVertexOutput(component.roadWidth));
			component.uniqueConnectionId = Guid.NewGuid().ToString();
			AddConnection(atPositive, component);
		}

		public void EnableRuntimeEditing()
		{
			editAtRuntime = true;
			CleanupRuntimeHandles();
			InitializeRuntimeHandles();
		}

		public void DisableRuntimeEditing()
		{
			editAtRuntime = false;
			CleanupRuntimeHandles();
		}

		private void InitializeRuntimeHandles()
		{
			if (runtimeHandles.Length != splineSource.ControlPointCount && editAtRuntime)
			{
				runtimeHandles = new GameObject[splineSource.ControlPointCount];
				for (int i = 0; i < splineSource.ControlPointCount; i++)
				{
					Vector3 vector = splineSource.transform.TransformPoint(splineSource.GetControlPoint(i));
					runtimeHandles[i] = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
					runtimeHandles[i].transform.position = new Vector3(vector.x, vector.y + roadWidth / 4f, vector.z);
					runtimeHandles[i].transform.localScale = new Vector3(roadWidth / 15f, roadWidth / 4f, roadWidth / 15f);
					runtimeHandles[i].GetComponent<Renderer>().material = Resources.Load<Material>("Materials/_RuntimeGizmo/HandleColor");
					runtimeHandles[i].GetComponent<Renderer>().sharedMaterial.color = Color.yellow;
					runtimeHandles[i].name = "RuntimeControlPin";
					GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
					gameObject.transform.position = new Vector3(vector.x, vector.y + roadWidth / 2f, vector.z);
					gameObject.transform.localScale = new Vector3(roadWidth / 4f, roadWidth / 4f, roadWidth / 4f);
					gameObject.transform.parent = runtimeHandles[i].transform;
					gameObject.GetComponent<Renderer>().material = Resources.Load<Material>("Materials/_RuntimeGizmo/HandleColor");
					gameObject.GetComponent<Renderer>().sharedMaterial.color = Color.yellow;
					gameObject.AddComponent<GizmoSelectable>();
					gameObject.name = "RuntimeControlHandle" + i;
					gameObject.transform.parent = base.transform;
					runtimeHandles[i].transform.parent = gameObject.transform;
				}
				if (!GetComponent<LineRenderer>())
				{
					runtimeCurveLine = base.gameObject.AddComponent<LineRenderer>();
				}
				runtimeCurveLine = GetComponent<LineRenderer>();
				runtimeCurveLine.positionCount = stepsPerCurve * splineSource.CurveCount + 1;
				Vector3[] centreWaypoints = GetCentreWaypoints();
				for (int j = 0; j < centreWaypoints.Length; j++)
				{
					centreWaypoints[j].y += 0.05f;
				}
				runtimeCurveLine.SetPositions(centreWaypoints);
				runtimeCurveLine.material = Resources.Load<Material>("Materials/_RuntimeGizmo/RoadLineColor");
				runtimeCurveLine.sharedMaterial.color = Color.white;
				runtimeCurveLine.startWidth = roadWidth / 10f;
				runtimeCurveLine.transform.parent = base.transform;
				runtimeHandleLines = null;
				runtimeHandleLines = new LineRenderer[splineSource.ControlPointCount];
				for (int k = 1; k < splineSource.ControlPointCount; k += 3)
				{
					CreateUpdateHandleLine(k - 1, k);
					CreateUpdateHandleLine(k + 1, k + 2);
				}
			}
			else if (runtimeHandles.Length > 1 && !editAtRuntime)
			{
				CleanupRuntimeHandles();
			}
		}

		private void CreateUpdateHandleLine(int startHandleIndex, int lineIndex)
		{
			try
			{
				runtimeHandleLines[lineIndex].positionCount = 2;
			}
			catch (Exception)
			{
				try
				{
					runtimeHandleLines[lineIndex] = runtimeHandles[startHandleIndex].AddComponent<LineRenderer>();
					runtimeHandleLines[lineIndex].positionCount = 2;
				}
				catch (Exception ex)
				{
					if (Application.isPlaying)
					{
						Debug.LogError(string.Concat("ERROR (", ex, ") when creating handle lines!"));
					}
					return;
				}
			}
			Vector3[] array = new Vector3[2];
			Pair<Vector3> pair = default(Pair<Vector3>);
			pair.First = splineSource.transform.TransformPoint(splineSource.GetControlPoint(startHandleIndex));
			pair.Second = splineSource.transform.TransformPoint(splineSource.GetControlPoint(startHandleIndex + 1));
			Pair<Vector3> pair2 = pair;
			array[0] = new Vector3(pair2.First.x, pair2.First.y + 0.05f, pair2.First.z);
			array[1] = new Vector3(pair2.Second.x, pair2.Second.y + 0.05f, pair2.Second.z);
			runtimeHandleLines[lineIndex].SetPositions(array);
			runtimeHandleLines[lineIndex].material = Resources.Load<Material>("Materials/_RuntimeGizmo/HandleColor");
			runtimeHandleLines[lineIndex].sharedMaterial.color = Color.yellow;
			runtimeHandleLines[lineIndex].startWidth = roadWidth / 10f;
		}

		private void UpdateRuntimeHandles()
		{
			if (!editAtRuntime)
			{
				return;
			}
			for (int i = 0; i < splineSource.ControlPointCount; i++)
			{
				RuntimeUpdatePoint(i);
			}
			if (runtimeHandleLines.Length != splineSource.ControlPointCount)
			{
				runtimeHandleLines = new LineRenderer[splineSource.ControlPointCount];
			}
			for (int j = 1; j < splineSource.ControlPointCount; j += 3)
			{
				CreateUpdateHandleLine(j - 1, j);
				CreateUpdateHandleLine(j + 1, j + 2);
			}
			bool flag = false;
			for (int k = 0; k < runtimeHandles.Length; k++)
			{
				if ((bool)gizmo && gizmo.selectedObjects.Contains(base.transform.Find("RuntimeControlHandle" + k)))
				{
					flag = true;
					break;
				}
			}
			if ((bool)runtimeCurveLine && (flag || gizmo.selectedObjects.Contains(base.transform)))
			{
				if (runtimeCurveLine.positionCount != stepsPerCurve * splineSource.CurveCount + 1)
				{
					runtimeCurveLine.positionCount = stepsPerCurve * splineSource.CurveCount + 1;
				}
				Vector3[] centreWaypoints = GetCentreWaypoints();
				for (int l = 0; l < centreWaypoints.Length; l++)
				{
					centreWaypoints[l].y += 0.05f;
				}
				runtimeCurveLine.SetPositions(centreWaypoints);
			}
		}

		private void RuntimeUpdatePoint(int index)
		{
			if (runtimeHandles.Length == 0 || index > runtimeHandles.Length || !runtimeHandles[index])
			{
				return;
			}
			Vector3 position = runtimeHandles[index].transform.position;
			Vector3 point = splineSource.transform.InverseTransformPoint(new Vector3(position.x, position.y - roadWidth / 4f, position.z));
			if (gizmo == null)
			{
				return;
			}
			foreach (Transform selectedObject in gizmo.selectedObjects)
			{
				if (selectedObject == runtimeHandles[index].transform.parent)
				{
					splineSource.SetControlPoint(index, point);
					if (Application.isPlaying)
					{
						SnapFirstAndLastPoints(index);
					}
					GenerateRoadMesh(GenerateRoadVertexOutput(roadWidth));
				}
				runtimeHandles[index].transform.parent.position = splineSource.transform.TransformPoint(splineSource.GetControlPoint(index) + new Vector3(0f, roadWidth / 2f, 0f));
			}
		}

		public void SnapFirstAndLastPoints(int selectedIndex)
		{
			Vector3 controlPoint = splineSource.GetControlPoint(selectedIndex);
			MagnetRoad[] array = UnityEngine.Object.FindObjectsOfType<MagnetRoad>();
			Intersection[] array2 = UnityEngine.Object.FindObjectsOfType<Intersection>();
			if (controlPoint == splineSource.GetControlPoint(splineSource.ControlPointCount - 1) || controlPoint == splineSource.GetControlPoint(0))
			{
				MagnetRoad[] array3 = array;
				foreach (MagnetRoad magnetRoad in array3)
				{
					SnapPoint closestSnapPointFromVector = splineSource.gameObject.GetComponent<MagnetRoad>().GetClosestSnapPointFromVector(base.transform.TransformPoint(controlPoint));
					SnapPoint closestSnapPointFromVector2 = magnetRoad.GetClosestSnapPointFromVector(base.transform.TransformPoint(controlPoint));
					if (!closestSnapPointFromVector || !closestSnapPointFromVector2)
					{
						continue;
					}
					if (closestSnapPointFromVector.PointType != closestSnapPointFromVector2.PointType && magnetRoad.gameObject != splineSource.gameObject)
					{
						if (Vector3.Distance(base.transform.TransformPoint(controlPoint), magnetRoad.SnapNodeNegative.transform.position) <= magnetRoad.roadWidth / 3f)
						{
							splineSource.SetControlPoint(selectedIndex, base.transform.InverseTransformPoint(magnetRoad.SnapNodeNegative.transform.position));
							if (controlPoint == splineSource.GetControlPoint(splineSource.ControlPointCount - 1))
							{
								float num = Vector3.Distance(base.transform.TransformPoint(controlPoint), base.transform.TransformPoint(splineSource.GetControlPoint(splineSource.ControlPointCount - 2)));
								splineSource.SetControlPoint(selectedIndex - 1, base.transform.InverseTransformPoint(magnetRoad.SnapNodeNegative.transform.position + magnetRoad.splineSource.GetDirection(0f) * (0f - num)));
								AddConnection(atPositive: false, magnetRoad);
								magnetRoad.AddConnection(atPositive: true, this);
							}
							if (controlPoint == splineSource.GetControlPoint(0))
							{
								float num2 = Vector3.Distance(base.transform.TransformPoint(controlPoint), base.transform.TransformPoint(splineSource.GetControlPoint(1)));
								splineSource.SetControlPoint(1, base.transform.InverseTransformPoint(magnetRoad.SnapNodeNegative.transform.position + magnetRoad.splineSource.GetDirection(magnetRoad.splineSource.CurveCount * magnetRoad.stepsPerCurve) * num2));
								AddConnection(atPositive: true, magnetRoad);
								magnetRoad.AddConnection(atPositive: false, this);
							}
						}
						if (Vector3.Distance(base.transform.TransformPoint(controlPoint), magnetRoad.SnapNodePositive.transform.position) <= magnetRoad.roadWidth / 3f)
						{
							splineSource.SetControlPoint(selectedIndex, base.transform.InverseTransformPoint(magnetRoad.SnapNodePositive.transform.position));
							if (controlPoint == splineSource.GetControlPoint(splineSource.ControlPointCount - 1))
							{
								float num3 = Vector3.Distance(base.transform.TransformPoint(controlPoint), base.transform.TransformPoint(splineSource.GetControlPoint(splineSource.ControlPointCount - 2)));
								splineSource.SetControlPoint(selectedIndex - 1, base.transform.InverseTransformPoint(magnetRoad.SnapNodePositive.transform.position + magnetRoad.splineSource.GetDirection(0f) * (0f - num3)));
								AddConnection(atPositive: false, magnetRoad);
								magnetRoad.AddConnection(atPositive: true, this);
							}
							if (controlPoint == splineSource.GetControlPoint(0))
							{
								float num4 = Vector3.Distance(base.transform.TransformPoint(controlPoint), base.transform.TransformPoint(splineSource.GetControlPoint(1)));
								splineSource.SetControlPoint(1, base.transform.InverseTransformPoint(magnetRoad.SnapNodePositive.transform.position + magnetRoad.splineSource.GetDirection(magnetRoad.splineSource.CurveCount * magnetRoad.stepsPerCurve) * num4));
								AddConnection(atPositive: true, magnetRoad);
								magnetRoad.AddConnection(atPositive: false, this);
							}
						}
					}
					Intersection[] array4 = array2;
					foreach (Intersection intersection in array4)
					{
						int num5 = 0;
						SnapPoint[] snapNodes = intersection.SnapNodes;
						foreach (SnapPoint snapPoint in snapNodes)
						{
							if (Vector3.Distance(base.transform.TransformPoint(controlPoint), snapPoint.transform.position) < intersection.roadWidth / 3f)
							{
								splineSource.SetControlPoint(selectedIndex, base.transform.InverseTransformPoint(snapPoint.transform.position));
								if (controlPoint == splineSource.GetControlPoint(splineSource.ControlPointCount - 1))
								{
									float num6 = Vector3.Distance(base.transform.TransformPoint(controlPoint), base.transform.TransformPoint(splineSource.GetControlPoint(splineSource.ControlPointCount - 2)));
									splineSource.SetControlPoint(selectedIndex - 1, base.transform.InverseTransformPoint(snapPoint.transform.position + snapPoint.transform.forward * num6));
									AddConnection(atPositive: false, intersection, num5);
								}
								if (controlPoint == splineSource.GetControlPoint(0))
								{
									float num7 = Vector3.Distance(base.transform.TransformPoint(controlPoint), base.transform.TransformPoint(splineSource.GetControlPoint(1)));
									splineSource.SetControlPoint(1, base.transform.InverseTransformPoint(snapPoint.transform.position + snapPoint.transform.forward * num7));
									AddConnection(atPositive: true, intersection, num5);
								}
							}
							num5++;
						}
					}
				}
			}
			UpdateConnections();
		}

		private void CleanupRuntimeHandles()
		{
			if (!Application.isPlaying || !editAtRuntime)
			{
				UnityEngine.Object.DestroyImmediate(runtimeCurveLine);
			}
			if (runtimeHandles == null || runtimeHandles.Length == 0)
			{
				return;
			}
			if ((bool)gizmo)
			{
				gizmo.ClearSelection();
				gizmo.Hide();
			}
			LineRenderer[] array = runtimeHandleLines;
			for (int i = 0; i < array.Length; i++)
			{
				UnityEngine.Object.DestroyImmediate(array[i]);
			}
			GameObject[] array2 = runtimeHandles;
			foreach (GameObject gameObject in array2)
			{
				if ((bool)gameObject && (bool)gameObject.transform.parent.gameObject)
				{
					UnityEngine.Object.DestroyImmediate(gameObject.transform.parent.gameObject);
				}
				if ((bool)gameObject)
				{
					UnityEngine.Object.DestroyImmediate(gameObject);
				}
			}
			runtimeHandles = new GameObject[0];
		}

		public void UpdateConnections()
		{
			CheckForDisconnect(atPositive: true);
			CheckForDisconnect(atPositive: false);
		}

		private void CheckForDisconnect(bool atPositive)
		{
			GameObject gameObject = (atPositive ? positiveConnection : negativeConnection);
			if (!gameObject)
			{
				return;
			}
			Intersection component = gameObject.GetComponent<Intersection>();
			MagnetRoad component2 = gameObject.GetComponent<MagnetRoad>();
			int index = ((!atPositive) ? (splineSource.ControlPointCount - 1) : 0);
			if ((bool)component)
			{
				for (int i = 0; i < component.Connections.Length; i++)
				{
					if ((bool)component.Connections[i] && !(component.Connections[i] != base.gameObject) && Vector3.Distance(component.SnapNodes[i].transform.position, base.transform.TransformPoint(splineSource.GetControlPoint(index))) > roadWidth / 3f)
					{
						RemoveConnection(atPositive);
						component.RemoveConnection(i);
					}
				}
			}
			if ((bool)component2 && Vector3.Distance(atPositive ? component2.SnapNodeNegative.transform.position : component2.SnapNodePositive.transform.position, base.transform.TransformPoint(splineSource.GetControlPoint(index))) > roadWidth / 3f)
			{
				RemoveConnection(atPositive);
				component2.RemoveConnection(!atPositive);
			}
		}

		public void AddConnection(bool atPositive, MagnetRoad connection)
		{
			if (atPositive)
			{
				positiveConnection = connection.gameObject;
				positiveConnectionUniqueId = connection.uniqueConnectionId;
			}
			else
			{
				negativeConnection = connection.gameObject;
				negativeConnectionUniqueId = connection.uniqueConnectionId;
			}
		}

		public void AddConnection(bool atPositive, Intersection connection, int snapNodeNumber)
		{
			if (atPositive)
			{
				positiveConnection = connection.gameObject;
				positiveConnectionUniqueId = connection.uniqueConnectionId;
			}
			else
			{
				negativeConnection = connection.gameObject;
				negativeConnectionUniqueId = connection.uniqueConnectionId;
			}
			connection.AddConnection(snapNodeNumber, this);
		}

		public void RemoveConnection(bool atPositive)
		{
			if (atPositive)
			{
				positiveConnection = null;
				positiveConnectionUniqueId = "";
			}
			else
			{
				negativeConnection = null;
				negativeConnectionUniqueId = "";
			}
		}

		private static void DrawRoadOutline(IList<Pair<Vector3>> vertexData)
		{
			Gizmos.color = Color.grey;
			Pair<Vector3> pair = vertexData[0];
			Gizmos.DrawLine(pair.First, pair.Second);
			Pair<Vector3> pair2 = pair;
			for (int i = 1; i <= vertexData.Count - 1; i++)
			{
				pair = vertexData[i];
				Gizmos.DrawLine(pair.First, pair.Second);
				Gizmos.DrawLine(pair.First, pair2.First);
				Gizmos.DrawLine(pair.Second, pair2.Second);
				pair2 = pair;
			}
		}

		private void DrawCarPaths()
		{
			if (totalCarLanes <= 0)
			{
				return;
			}
			int num = totalCarLanes % 2;
			float num2 = (roadWidth - roadsideMargin * 2f) / (float)totalCarLanes;
			for (int i = num; i < totalCarLanes + 1; i += 2)
			{
				if (i == 1)
				{
					DrawCarPath(GetCentreWaypoints(), Color.blue);
				}
				else if (i > 1)
				{
					float width = num2 * (float)(i - 1);
					Helper.SplitPairArray(GenerateRoadVertexOutput(width), out var outFirstVector, out var outSecondVector);
					DrawCarPath(outFirstVector, Color.blue);
					DrawCarPath(outSecondVector, Color.blue);
				}
			}
		}

		private static void DrawCarPath(ICollection<Vector3> path, Color color)
		{
			Gizmos.color = color;
			for (int i = 0; i < path.Count - 1; i++)
			{
				Gizmos.DrawLine(path.ElementAt(i), path.ElementAt(i + 1));
			}
		}

		public Vector3[] GetLaneWaypoints(int laneNo)
		{
			int num = totalCarLanes % 2;
			float num2 = (roadWidth - roadsideMargin * 2f) / (float)totalCarLanes;
			int num3 = totalCarLanes / 2 + ((num == 0) ? (-1) : 0);
			int num4 = num3;
			int num5 = num3;
			for (int i = num; i < totalCarLanes + 1; i += 2)
			{
				if (num == 0)
				{
					if (i != 0)
					{
						num4--;
					}
					num5++;
				}
				else
				{
					if (laneNo == num3)
					{
						return GetCentreWaypoints();
					}
					num4--;
					num5++;
				}
				float width = num2 * (float)(i + 1);
				Helper.SplitPairArray(GenerateRoadVertexOutput(width), out var outFirstVector, out var outSecondVector);
				if (laneNo == num4)
				{
					return outFirstVector;
				}
				if (laneNo == num5)
				{
					return outSecondVector;
				}
			}
			return GetCentreWaypoints();
		}

		public Vector3[] GetCentreWaypoints()
		{
			Helper.SplitPairArray(GenerateRoadVertexOutput(0f), out var outFirstVector, out outFirstVector);
			return outFirstVector;
		}

		private SnapPoint GetClosestSnapPointFromVector(Vector3 vector)
		{
			if (!SnapNodeNegative || !SnapNodePositive)
			{
				return null;
			}
			float num = Vector3.Distance(vector, SnapNodeNegative.transform.position);
			float num2 = Vector3.Distance(vector, SnapNodePositive.transform.position);
			if (num > num2)
			{
				return SnapNodePositive.gameObject.GetComponent<SnapPoint>();
			}
			if (!(num2 >= num))
			{
				return null;
			}
			return SnapNodeNegative.gameObject.GetComponent<SnapPoint>();
		}

		public GameObject GetPositiveConnection()
		{
			return positiveConnection;
		}

		public MagnetRoad GetPositiveConnection_MagnetRoad()
		{
			if (!positiveConnection || !positiveConnection.GetComponent<MagnetRoad>())
			{
				return null;
			}
			return positiveConnection.GetComponent<MagnetRoad>();
		}

		public Intersection GetPositiveConnection_Intersection()
		{
			if (!positiveConnection || !positiveConnection.GetComponent<Intersection>())
			{
				return null;
			}
			return positiveConnection.GetComponent<Intersection>();
		}

		public GameObject GetNegativeConnection()
		{
			return negativeConnection;
		}

		public MagnetRoad GetNegativeConnection_MagnetRoad()
		{
			if (!negativeConnection || !negativeConnection.GetComponent<MagnetRoad>())
			{
				return null;
			}
			return negativeConnection.GetComponent<MagnetRoad>();
		}

		public Intersection GetNegativeConnection_Intersection()
		{
			if (!negativeConnection || !negativeConnection.GetComponent<Intersection>())
			{
				return null;
			}
			return negativeConnection.GetComponent<Intersection>();
		}

		public static GameObject FindGameObjectWithUniqueConnectionId(string uniqueId)
		{
			MagnetRoad[] array = UnityEngine.Object.FindObjectsOfType<MagnetRoad>();
			foreach (MagnetRoad magnetRoad in array)
			{
				if (magnetRoad.uniqueConnectionId.Equals(uniqueId))
				{
					return magnetRoad.gameObject;
				}
			}
			return (from intersection in UnityEngine.Object.FindObjectsOfType<Intersection>()
				where intersection.uniqueConnectionId.Equals(uniqueId)
				select intersection.gameObject).FirstOrDefault();
		}

		public void SaveRoadToXml(string path = "DEFAULT_LOCATION")
		{
			try
			{
				MagnetRoadCollection magnetRoadCollection = new MagnetRoadCollection();
				magnetRoadCollection.PrepareMagnetRoadData(new MagnetRoad[1] { this });
				magnetRoadCollection.Save((path == "DEFAULT_LOCATION") ? Path.Combine(Application.persistentDataPath, "RoadData.xml") : path);
			}
			catch (IOException)
			{
				Debug.LogWarning("Failed to save the Magnet Road to a file, check the selected path.");
			}
		}

		public static void SaveRoadsToXml(string path = "DEFAULT_LOCATION")
		{
			try
			{
				MagnetRoadCollection magnetRoadCollection = new MagnetRoadCollection();
				magnetRoadCollection.PrepareMagnetRoadData(UnityEngine.Object.FindObjectsOfType<MagnetRoad>());
				magnetRoadCollection.PrepareIntersectionData(UnityEngine.Object.FindObjectsOfType<Intersection>());
				magnetRoadCollection.Save((path == "DEFAULT_LOCATION") ? Path.Combine(Application.persistentDataPath, "RoadData.xml") : path);
			}
			catch (IOException)
			{
				Debug.LogWarning("Failed to save the Magnet Roads to a file, check the selected path.");
			}
		}

		public static void LoadRoadsFromXml(string path)
		{
			List<MagnetRoad> list = new List<MagnetRoad>();
			string[] files = Directory.GetFiles(path);
			if (files.Length != 0)
			{
				string[] array = files;
				for (int i = 0; i < array.Length; i++)
				{
					MagnetRoadCollection magnetRoadCollection = MagnetRoadCollection.Load(array[i]);
					MagnetRoadCollection.MagnetRoadData[] magnetRoadData = magnetRoadCollection.magnetRoadData;
					if (magnetRoadCollection.magnetRoadData != null)
					{
						MagnetRoadCollection.MagnetRoadData[] array2 = magnetRoadData;
						foreach (MagnetRoadCollection.MagnetRoadData magnetRoadData2 in array2)
						{
							MagnetRoad magnetRoad = new GameObject().AddComponent<MagnetRoad>();
							magnetRoad.name = magnetRoadData2.name;
							magnetRoad.transform.position = magnetRoadData2.location;
							magnetRoad.transform.Rotate(Vector3.right, magnetRoadData2.rotation.x);
							magnetRoad.transform.Rotate(Vector3.up, magnetRoadData2.rotation.y);
							magnetRoad.transform.Rotate(Vector3.forward, magnetRoadData2.rotation.z);
							magnetRoad.transform.localScale = new Vector3(1f, 1f, 1f);
							magnetRoad.surfaceMaterial = (Material)Resources.Load("Materials/" + magnetRoadData2.surfaceMaterial, typeof(Material));
							magnetRoad.sideMaterial = (Material)Resources.Load("Materials/" + magnetRoadData2.sideMaterial, typeof(Material));
							magnetRoad.roadWidth = magnetRoadData2.roadWidth;
							magnetRoad.sideDepth = magnetRoadData2.sideDepth;
							magnetRoad.slopeWidth = magnetRoadData2.slopeWidth;
							magnetRoad.stepsPerCurve = magnetRoadData2.stepsPerCurve;
							if (magnetRoadData2.isEditableAtRuntime)
							{
								magnetRoad.EnableRuntimeEditing();
							}
							magnetRoad.NegativeConnectionUniqueId = magnetRoadData2.negativeConnectionId;
							magnetRoad.PositiveConnectionUniqueId = magnetRoadData2.positiveConnectionId;
							while (magnetRoadData2.handlePoints.Length > magnetRoad.splineSource.ControlPointCount)
							{
								magnetRoad.AddCurve();
							}
							for (int k = 0; k < magnetRoadData2.handlePoints.Length; k += 3)
							{
								magnetRoad.splineSource.SetControlPoint(k, magnetRoad.transform.InverseTransformPoint(magnetRoadData2.handlePoints[k]));
							}
							for (int l = 1; l < magnetRoadData2.handlePoints.Length - 1; l += 3)
							{
								magnetRoad.splineSource.SetControlPoint(l, magnetRoad.transform.InverseTransformPoint(magnetRoadData2.handlePoints[l]));
								magnetRoad.splineSource.SetControlPoint(l + 1, magnetRoad.transform.InverseTransformPoint(magnetRoadData2.handlePoints[l + 1]));
							}
							magnetRoad.snapRoadToTerrain = magnetRoadData2.snapToTerrain;
							magnetRoad.terrain = UnityEngine.Object.FindObjectOfType<Terrain>();
							magnetRoad.distanceFromTerrain = magnetRoadData2.distanceFromTerrain;
							magnetRoad.GenerateRoadMesh(magnetRoad.GenerateRoadVertexOutput(magnetRoad.roadWidth));
							list.Add(magnetRoad);
							magnetRoad.fenceDistanceFromRoad = magnetRoadData2.roadsideFenceDistanceFromRoad;
							if ((bool)magnetRoadData2.roadsideFencePanelMesh)
							{
								magnetRoad.roadsideFencePanelMesh = magnetRoadData2.roadsideFencePanelMesh;
								magnetRoad.roadsideFencePanelScaling = magnetRoadData2.roadsideFencePanelScaling;
								magnetRoad.roadsideFencePanelRotation = magnetRoadData2.roadsideFencePanelRotation;
								magnetRoad.roadsideFencePanelMaterial = (Material)Resources.Load("Materials/" + magnetRoadData2.roadsideFencePanelMaterial, typeof(Material));
								MeshGenerator.GenerateRoadFencePanels(magnetRoad, magnetRoad.roadsideFencePanelMesh, magnetRoad.fenceDistanceFromRoad, magnetRoad.roadsideFencePanelScaling, magnetRoad.roadsideFencePanelRotation, magnetRoad.roadsideFencePanelMaterial);
							}
							if ((bool)magnetRoadData2.roadsideFencePostMesh)
							{
								magnetRoad.roadsideFencePostMesh = magnetRoadData2.roadsideFencePostMesh;
								magnetRoad.roadsideFencePostScaling = magnetRoadData2.roadsideFencePostScaling;
								magnetRoad.roadsideFencePostRotation = magnetRoadData2.roadsideFencePostRotation;
								magnetRoad.roadsideFencePostMaterial = (Material)Resources.Load("Materials/" + magnetRoadData2.roadsideFencePostMaterial, typeof(Material));
								MeshGenerator.GenerateRoadFencePosts(magnetRoad, magnetRoad.roadsideFencePostMesh, magnetRoad.fenceDistanceFromRoad, magnetRoad.roadsideFencePostScaling, magnetRoad.roadsideFencePostRotation, magnetRoad.roadsideFencePostMaterial);
							}
							if ((bool)magnetRoadData2.centerFencePanelMesh)
							{
								magnetRoad.centerFencePanelMesh = magnetRoadData2.centerFencePanelMesh;
								magnetRoad.centerFencePanelScaling = magnetRoadData2.centerFencePanelScaling;
								magnetRoad.centerFencePanelRotation = magnetRoadData2.centerFencePanelRotation;
								magnetRoad.centerFencePanelMaterial = (Material)Resources.Load("Materials/" + magnetRoadData2.centerFencePanelMaterial, typeof(Material));
								MeshGenerator.GenerateRoadFencePanels(magnetRoad, magnetRoad.centerFencePanelMesh, magnetRoad.fenceDistanceFromRoad, magnetRoad.centerFencePanelScaling, magnetRoad.centerFencePanelRotation, magnetRoad.centerFencePanelMaterial, isCenterOnly: true);
							}
							if ((bool)magnetRoadData2.centerFencePostMesh)
							{
								magnetRoad.centerFencePostMesh = magnetRoadData2.centerFencePostMesh;
								magnetRoad.centerFencePostScaling = magnetRoadData2.centerFencePostScaling;
								magnetRoad.centerFencePostRotation = magnetRoadData2.centerFencePostRotation;
								magnetRoad.centerFencePostMaterial = (Material)Resources.Load("Materials/" + magnetRoadData2.centerFencePostMaterial, typeof(Material));
								MeshGenerator.GenerateRoadFencePosts(magnetRoad, magnetRoad.centerFencePostMesh, magnetRoad.fenceDistanceFromRoad, magnetRoad.centerFencePostScaling, magnetRoad.centerFencePostRotation, magnetRoad.centerFencePostMaterial, isCenterOnly: true);
							}
							if (magnetRoadData2.reservationDimensions.x > 0f)
							{
								magnetRoad.reservationDimensions = magnetRoadData2.reservationDimensions;
								magnetRoad.reservationSlope = magnetRoadData2.reservationSlope;
								magnetRoad.reservationSideMaterial = (Material)Resources.Load("Materials/" + magnetRoadData2.reservationSideMaterial, typeof(Material));
								magnetRoad.reservationTopMaterial = (Material)Resources.Load("Materials/" + magnetRoadData2.reservationTopMaterial, typeof(Material));
								MeshGenerator.GenerateCentralReservation(magnetRoad);
							}
							if ((bool)magnetRoadData2.centerObjectMesh)
							{
								magnetRoad.centerObjectMesh = magnetRoadData2.centerObjectMesh;
								magnetRoad.centerObjectScaling = magnetRoadData2.centerObjectScaling;
								magnetRoad.centerObjectRotation = magnetRoadData2.centerObjectRotation;
								magnetRoad.centerObjectsToSpawn = magnetRoadData2.centerObjectsToSpawn;
								magnetRoad.centerObjectMaterial = (Material)Resources.Load("Materials/" + magnetRoadData2.centerObjectMaterial, typeof(Material));
								MeshGenerator.GenerateCentralReservationObjects(magnetRoad);
							}
						}
					}
					MagnetRoadCollection.IntersectionData[] intersectionData = magnetRoadCollection.intersectionData;
					if (magnetRoadCollection.intersectionData != null)
					{
						MagnetRoadCollection.IntersectionData[] array3 = intersectionData;
						foreach (MagnetRoadCollection.IntersectionData intersectionData2 in array3)
						{
							Intersection intersection = new GameObject().AddComponent<Intersection>();
							intersection.name = intersectionData2.name;
							intersection.transform.position = intersectionData2.location;
							intersection.transform.Rotate(Vector3.right, intersectionData2.rotation.x);
							intersection.transform.Rotate(Vector3.up, intersectionData2.rotation.y);
							intersection.transform.Rotate(Vector3.forward, intersectionData2.rotation.z);
							intersection.transform.localScale = intersectionData2.scale;
							intersection.surfaceMaterial = (Material)Resources.Load("Materials/" + intersectionData2.surfaceMaterial, typeof(Material));
							intersection.sideMaterial = (Material)Resources.Load("Materials/" + intersectionData2.sideMaterial, typeof(Material));
							intersection.roadWidth = intersectionData2.roadWidth;
							intersection.sideDepth = intersectionData2.sideDepth;
							intersection.slopeWidth = intersectionData2.slopeWidth;
							if (intersectionData2.isEditableAtRuntime)
							{
								intersection.EnableRuntimeEditing();
							}
							intersection.SetUp(intersectionData2.intersectionType);
							intersection.SetConnectionUniqueId(0, intersectionData2.connectedUniqueId0);
							intersection.SetConnectionUniqueId(1, intersectionData2.connectedUniqueId1);
							intersection.SetConnectionUniqueId(2, intersectionData2.connectedUniqueId2);
							intersection.SetConnectionUniqueId(3, intersectionData2.connectedUniqueId3);
						}
					}
					if (list.Count <= 0)
					{
						continue;
					}
					foreach (MagnetRoad item in list)
					{
						item.SnapFirstAndLastPoints(0);
						item.SnapFirstAndLastPoints(item.splineSource.ControlPointCount - 1);
					}
				}
			}
			else
			{
				Debug.LogWarning("No file(s) selected to load!");
			}
		}

		public static void RegenerateAllRoadsAndIntersections()
		{
			MagnetRoad[] array = UnityEngine.Object.FindObjectsOfType<MagnetRoad>();
			foreach (MagnetRoad obj in array)
			{
				obj.GenerateRoadMesh(obj.GenerateRoadVertexOutput(obj.roadWidth));
			}
			Intersection[] array2 = UnityEngine.Object.FindObjectsOfType<Intersection>();
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].GenerateIntersectionMesh();
			}
		}

		public static GameObject CreateNewSplineRoad()
		{
			GameObject obj = new GameObject
			{
				name = "Magnet Road"
			};
			MagnetRoad magnetRoad = obj.AddComponent<MagnetRoad>();
			magnetRoad.GenerateRoadMesh(magnetRoad.GenerateRoadVertexOutput(magnetRoad.roadWidth));
			return obj;
		}

		public static GameObject CreateNewThreeLane()
		{
			GameObject obj = new GameObject();
			obj.name = "Three-lane Intersection";
			obj.AddComponent<Intersection>().SetUp(Intersection.IntersectionType.ThreeLane);
			return obj;
		}

		public static GameObject CreateNewFourLane()
		{
			GameObject obj = new GameObject();
			obj.name = "Four-lane Intersection";
			obj.AddComponent<Intersection>().SetUp(Intersection.IntersectionType.FourLane);
			return obj;
		}
	}
}
namespace BezierSolution
{
	public class BezierPoint : MonoBehaviour
	{
		public enum HandleMode
		{
			Free,
			Aligned,
			Mirrored
		}

		[SerializeField]
		[HideInInspector]
		private Vector3 m_position;

		[SerializeField]
		[HideInInspector]
		private Vector3 m_precedingControlPointLocalPosition = Vector3.left;

		[SerializeField]
		[HideInInspector]
		private Vector3 m_precedingControlPointPosition;

		[SerializeField]
		[HideInInspector]
		private Vector3 m_followingControlPointLocalPosition = Vector3.right;

		[SerializeField]
		[HideInInspector]
		private Vector3 m_followingControlPointPosition;

		[SerializeField]
		[HideInInspector]
		private HandleMode m_handleMode = HandleMode.Mirrored;

		public Vector3 localPosition
		{
			get
			{
				return base.transform.localPosition;
			}
			set
			{
				base.transform.localPosition = value;
			}
		}

		public Vector3 position
		{
			get
			{
				if (base.transform.hasChanged)
				{
					Revalidate();
				}
				return m_position;
			}
			set
			{
				base.transform.position = value;
			}
		}

		public Quaternion localRotation
		{
			get
			{
				return base.transform.localRotation;
			}
			set
			{
				base.transform.localRotation = value;
			}
		}

		public Quaternion rotation
		{
			get
			{
				return base.transform.rotation;
			}
			set
			{
				base.transform.rotation = value;
			}
		}

		public Vector3 localEulerAngles
		{
			get
			{
				return base.transform.localEulerAngles;
			}
			set
			{
				base.transform.localEulerAngles = value;
			}
		}

		public Vector3 eulerAngles
		{
			get
			{
				return base.transform.eulerAngles;
			}
			set
			{
				base.transform.eulerAngles = value;
			}
		}

		public Vector3 localScale
		{
			get
			{
				return base.transform.localScale;
			}
			set
			{
				base.transform.localScale = value;
			}
		}

		public Vector3 precedingControlPointLocalPosition
		{
			get
			{
				return m_precedingControlPointLocalPosition;
			}
			set
			{
				m_precedingControlPointLocalPosition = value;
				m_precedingControlPointPosition = base.transform.TransformPoint(value);
				if (m_handleMode == HandleMode.Aligned)
				{
					m_followingControlPointLocalPosition = -m_precedingControlPointLocalPosition.normalized * m_followingControlPointLocalPosition.magnitude;
					m_followingControlPointPosition = base.transform.TransformPoint(m_followingControlPointLocalPosition);
				}
				else if (m_handleMode == HandleMode.Mirrored)
				{
					m_followingControlPointLocalPosition = -m_precedingControlPointLocalPosition;
					m_followingControlPointPosition = base.transform.TransformPoint(m_followingControlPointLocalPosition);
				}
			}
		}

		public Vector3 precedingControlPointPosition
		{
			get
			{
				if (base.transform.hasChanged)
				{
					Revalidate();
				}
				return m_precedingControlPointPosition;
			}
			set
			{
				m_precedingControlPointPosition = value;
				m_precedingControlPointLocalPosition = base.transform.InverseTransformPoint(value);
				if (base.transform.hasChanged)
				{
					m_position = base.transform.position;
					base.transform.hasChanged = false;
				}
				if (m_handleMode == HandleMode.Aligned)
				{
					m_followingControlPointPosition = m_position - (m_precedingControlPointPosition - m_position).normalized * (m_followingControlPointPosition - m_position).magnitude;
					m_followingControlPointLocalPosition = base.transform.InverseTransformPoint(m_followingControlPointPosition);
				}
				else if (m_handleMode == HandleMode.Mirrored)
				{
					m_followingControlPointPosition = 2f * m_position - m_precedingControlPointPosition;
					m_followingControlPointLocalPosition = base.transform.InverseTransformPoint(m_followingControlPointPosition);
				}
			}
		}

		public Vector3 followingControlPointLocalPosition
		{
			get
			{
				return m_followingControlPointLocalPosition;
			}
			set
			{
				m_followingControlPointLocalPosition = value;
				m_followingControlPointPosition = base.transform.TransformPoint(value);
				if (m_handleMode == HandleMode.Aligned)
				{
					m_precedingControlPointLocalPosition = -m_followingControlPointLocalPosition.normalized * m_precedingControlPointLocalPosition.magnitude;
					m_precedingControlPointPosition = base.transform.TransformPoint(m_precedingControlPointLocalPosition);
				}
				else if (m_handleMode == HandleMode.Mirrored)
				{
					m_precedingControlPointLocalPosition = -m_followingControlPointLocalPosition;
					m_precedingControlPointPosition = base.transform.TransformPoint(m_precedingControlPointLocalPosition);
				}
			}
		}

		public Vector3 followingControlPointPosition
		{
			get
			{
				if (base.transform.hasChanged)
				{
					Revalidate();
				}
				return m_followingControlPointPosition;
			}
			set
			{
				m_followingControlPointPosition = value;
				m_followingControlPointLocalPosition = base.transform.InverseTransformPoint(value);
				if (base.transform.hasChanged)
				{
					m_position = base.transform.position;
					base.transform.hasChanged = false;
				}
				if (m_handleMode == HandleMode.Aligned)
				{
					m_precedingControlPointPosition = m_position - (m_followingControlPointPosition - m_position).normalized * (m_precedingControlPointPosition - m_position).magnitude;
					m_precedingControlPointLocalPosition = base.transform.InverseTransformPoint(m_precedingControlPointPosition);
				}
				else if (m_handleMode == HandleMode.Mirrored)
				{
					m_precedingControlPointPosition = 2f * m_position - m_followingControlPointPosition;
					m_precedingControlPointLocalPosition = base.transform.InverseTransformPoint(m_precedingControlPointPosition);
				}
			}
		}

		public HandleMode handleMode
		{
			get
			{
				return m_handleMode;
			}
			set
			{
				m_handleMode = value;
				if (value == HandleMode.Aligned || value == HandleMode.Mirrored)
				{
					precedingControlPointLocalPosition = m_precedingControlPointLocalPosition;
				}
			}
		}

		private void Awake()
		{
			base.transform.hasChanged = true;
		}

		public void CopyTo(BezierPoint other)
		{
			other.transform.localPosition = base.transform.localPosition;
			other.transform.localRotation = base.transform.localRotation;
			other.transform.localScale = base.transform.localScale;
			other.m_handleMode = m_handleMode;
			other.m_precedingControlPointLocalPosition = m_precedingControlPointLocalPosition;
			other.m_followingControlPointLocalPosition = m_followingControlPointLocalPosition;
		}

		private void Revalidate()
		{
			m_position = base.transform.position;
			m_precedingControlPointPosition = base.transform.TransformPoint(m_precedingControlPointLocalPosition);
			m_followingControlPointPosition = base.transform.TransformPoint(m_followingControlPointLocalPosition);
			base.transform.hasChanged = false;
		}

		public void Reset()
		{
			localPosition = Vector3.zero;
			localRotation = Quaternion.identity;
			localScale = Vector3.one;
			precedingControlPointLocalPosition = Vector3.left;
			followingControlPointLocalPosition = Vector3.right;
			base.transform.hasChanged = true;
		}
	}
	[ExecuteInEditMode]
	public class BezierSpline : MonoBehaviour
	{
		private static Material gizmoMaterial;

		private Color gizmoColor = Color.white;

		private float gizmoStep = 0.05f;

		private List<BezierPoint> endPoints = new List<BezierPoint>();

		public bool loop;

		public bool drawGizmos;

		public int Count => endPoints.Count;

		public float Length => GetLengthApproximately(0f, 1f);

		public BezierPoint this[int index]
		{
			get
			{
				if (index < Count)
				{
					return endPoints[index];
				}
				Debug.LogError("Bezier index " + index + " is out of range: " + Count);
				return null;
			}
		}

		private void Awake()
		{
			Refresh();
		}

		public void Initialize(int endPointsCount)
		{
			if (endPointsCount < 2)
			{
				Debug.LogError("Can't initialize spline with " + endPointsCount + " point(s). At least 2 points are needed");
				return;
			}
			Refresh();
			for (int i = 0; i < endPoints.Count; i++)
			{
				UnityEngine.Object.DestroyImmediate(endPoints[i].gameObject);
			}
			endPoints.Clear();
			for (int j = 0; j < endPointsCount; j++)
			{
				InsertNewPointAt(j);
			}
			Refresh();
		}

		public void Refresh()
		{
			endPoints.Clear();
			GetComponentsInChildren(endPoints);
		}

		public BezierPoint InsertNewPointAt(int index)
		{
			if (index < 0 || index > endPoints.Count)
			{
				Debug.LogError("Index " + index + " is out of range: [0," + endPoints.Count + "]");
				return null;
			}
			int count = endPoints.Count;
			BezierPoint bezierPoint = new GameObject("Point").AddComponent<BezierPoint>();
			bezierPoint.transform.SetParent((endPoints.Count == 0) ? base.transform : ((index == 0) ? endPoints[0].transform.parent : endPoints[index - 1].transform.parent), worldPositionStays: false);
			bezierPoint.transform.SetSiblingIndex((index != 0) ? (endPoints[index - 1].transform.GetSiblingIndex() + 1) : 0);
			if (endPoints.Count == count)
			{
				endPoints.Insert(index, bezierPoint);
			}
			return bezierPoint;
		}

		public BezierPoint DuplicatePointAt(int index)
		{
			if (index < 0 || index >= endPoints.Count)
			{
				Debug.LogError("Index " + index + " is out of range: [0," + (endPoints.Count - 1) + "]");
				return null;
			}
			BezierPoint bezierPoint = InsertNewPointAt(index + 1);
			endPoints[index].CopyTo(bezierPoint);
			return bezierPoint;
		}

		public void RemovePointAt(int index)
		{
			if (endPoints.Count <= 2)
			{
				Debug.LogError("Can't remove point: spline must consist of at least two points!");
			}
			else if (index < 0 || index >= endPoints.Count)
			{
				Debug.LogError("Index " + index + " is out of range: [0," + endPoints.Count + ")");
			}
			else
			{
				BezierPoint bezierPoint = endPoints[index];
				endPoints.RemoveAt(index);
				UnityEngine.Object.DestroyImmediate(bezierPoint.gameObject);
			}
		}

		public void SwapPointsAt(int index1, int index2)
		{
			if (index1 == index2)
			{
				Debug.LogError("Indices can't be equal to each other");
				return;
			}
			if (index1 < 0 || index1 >= endPoints.Count || index2 < 0 || index2 >= endPoints.Count)
			{
				Debug.LogError("Indices must be in range [0," + (endPoints.Count - 1) + "]");
				return;
			}
			BezierPoint bezierPoint = endPoints[index1];
			int siblingIndex = bezierPoint.transform.GetSiblingIndex();
			endPoints[index1] = endPoints[index2];
			endPoints[index2] = bezierPoint;
			bezierPoint.transform.SetSiblingIndex(endPoints[index1].transform.GetSiblingIndex());
			endPoints[index1].transform.SetSiblingIndex(siblingIndex);
		}

		public int IndexOf(BezierPoint point)
		{
			return endPoints.IndexOf(point);
		}

		public void DrawGizmos(Color color, int smoothness = 4)
		{
			drawGizmos = true;
			gizmoColor = color;
			gizmoStep = 1f / (float)(endPoints.Count * Mathf.Clamp(smoothness, 1, 30));
		}

		public void HideGizmos()
		{
			drawGizmos = false;
		}

		public Vector3 GetPoint(float normalizedT)
		{
			if (normalizedT <= 0f)
			{
				return endPoints[0].position;
			}
			if (normalizedT >= 1f)
			{
				if (loop)
				{
					return endPoints[0].position;
				}
				return endPoints[endPoints.Count - 1].position;
			}
			float num = normalizedT * (float)(loop ? endPoints.Count : (endPoints.Count - 1));
			int num2 = (int)num;
			int num3 = num2 + 1;
			if (num3 == endPoints.Count)
			{
				num3 = 0;
			}
			BezierPoint bezierPoint = endPoints[num2];
			BezierPoint bezierPoint2 = endPoints[num3];
			float num4 = num - (float)num2;
			float num5 = 1f - num4;
			return num5 * num5 * num5 * bezierPoint.position + 3f * num5 * num5 * num4 * bezierPoint.followingControlPointPosition + 3f * num5 * num4 * num4 * bezierPoint2.precedingControlPointPosition + num4 * num4 * num4 * bezierPoint2.position;
		}

		public Vector3 GetTangent(float normalizedT)
		{
			if (normalizedT <= 0f)
			{
				return 3f * (endPoints[0].followingControlPointPosition - endPoints[0].position);
			}
			if (normalizedT >= 1f)
			{
				if (loop)
				{
					return 3f * (endPoints[0].position - endPoints[0].precedingControlPointPosition);
				}
				int index = endPoints.Count - 1;
				return 3f * (endPoints[index].position - endPoints[index].precedingControlPointPosition);
			}
			float num = normalizedT * (float)(loop ? endPoints.Count : (endPoints.Count - 1));
			int num2 = (int)num;
			int num3 = num2 + 1;
			if (num3 == endPoints.Count)
			{
				num3 = 0;
			}
			BezierPoint bezierPoint = endPoints[num2];
			BezierPoint bezierPoint2 = endPoints[num3];
			float num4 = num - (float)num2;
			float num5 = 1f - num4;
			return 3f * num5 * num5 * (bezierPoint.followingControlPointPosition - bezierPoint.position) + 6f * num5 * num4 * (bezierPoint2.precedingControlPointPosition - bezierPoint.followingControlPointPosition) + 3f * num4 * num4 * (bezierPoint2.position - bezierPoint2.precedingControlPointPosition);
		}

		public float GetLengthApproximately(float startNormalizedT, float endNormalizedT, float accuracy = 50f)
		{
			if (endNormalizedT < startNormalizedT)
			{
				float num = startNormalizedT;
				startNormalizedT = endNormalizedT;
				endNormalizedT = num;
			}
			if (startNormalizedT < 0f)
			{
				startNormalizedT = 0f;
			}
			if (endNormalizedT > 1f)
			{
				endNormalizedT = 1f;
			}
			float num2 = AccuracyToStepSize(accuracy) * (endNormalizedT - startNormalizedT);
			float num3 = 0f;
			Vector3 vector = GetPoint(startNormalizedT);
			for (float num4 = startNormalizedT + num2; num4 < endNormalizedT; num4 += num2)
			{
				Vector3 point = GetPoint(num4);
				num3 += Vector3.Distance(point, vector);
				vector = point;
			}
			return num3 + Vector3.Distance(vector, GetPoint(endNormalizedT));
		}

		public Vector3 FindNearestPointTo(Vector3 worldPos, float accuracy = 100f)
		{
			float normalizedT;
			return FindNearestPointTo(worldPos, out normalizedT, accuracy);
		}

		public Vector3 FindNearestPointTo(Vector3 worldPos, out float normalizedT, float accuracy = 100f)
		{
			Vector3 result = Vector3.zero;
			normalizedT = -1f;
			float num = AccuracyToStepSize(accuracy);
			float num2 = float.PositiveInfinity;
			for (float num3 = 0f; num3 < 1f; num3 += num)
			{
				Vector3 point = GetPoint(num3);
				float sqrMagnitude = (worldPos - point).sqrMagnitude;
				if (sqrMagnitude < num2)
				{
					num2 = sqrMagnitude;
					result = point;
					normalizedT = num3;
				}
			}
			return result;
		}

		public Vector3 MoveAlongSpline(ref float normalizedT, float deltaMovement, int accuracy = 3)
		{
			float num = 1f / (float)endPoints.Count;
			for (int i = 0; i < accuracy; i++)
			{
				normalizedT += deltaMovement * num / ((float)accuracy * GetTangent(normalizedT).magnitude);
			}
			return GetPoint(normalizedT);
		}

		public void ConstructLinearPath()
		{
			for (int i = 0; i < endPoints.Count; i++)
			{
				endPoints[i].handleMode = BezierPoint.HandleMode.Free;
				if (i < endPoints.Count - 1)
				{
					Vector3 vector = (endPoints[i].position + endPoints[i + 1].position) * 0.5f;
					endPoints[i].followingControlPointPosition = vector;
					endPoints[i + 1].precedingControlPointPosition = vector;
				}
				else
				{
					Vector3 vector2 = (endPoints[i].position + endPoints[0].position) * 0.5f;
					endPoints[i].followingControlPointPosition = vector2;
					endPoints[0].precedingControlPointPosition = vector2;
				}
			}
		}

		public void AutoConstructSpline()
		{
			for (int i = 0; i < endPoints.Count; i++)
			{
				endPoints[i].handleMode = BezierPoint.HandleMode.Mirrored;
			}
			int num = endPoints.Count - 1;
			if (num == 1)
			{
				endPoints[0].followingControlPointPosition = (2f * endPoints[0].position + endPoints[1].position) / 3f;
				endPoints[1].precedingControlPointPosition = 2f * endPoints[0].followingControlPointPosition - endPoints[0].position;
				return;
			}
			Vector3[] array = ((!loop) ? new Vector3[num] : new Vector3[num + 1]);
			for (int j = 1; j < num - 1; j++)
			{
				array[j] = 4f * endPoints[j].position + 2f * endPoints[j + 1].position;
			}
			array[0] = endPoints[0].position + 2f * endPoints[1].position;
			if (!loop)
			{
				array[num - 1] = (8f * endPoints[num - 1].position + endPoints[num].position) * 0.5f;
			}
			else
			{
				array[num - 1] = 4f * endPoints[num - 1].position + 2f * endPoints[num].position;
				array[num] = (8f * endPoints[num].position + endPoints[0].position) * 0.5f;
			}
			Vector3[] firstControlPoints = GetFirstControlPoints(array);
			for (int k = 0; k < num; k++)
			{
				endPoints[k].followingControlPointPosition = firstControlPoints[k];
				if (loop)
				{
					endPoints[k + 1].precedingControlPointPosition = 2f * endPoints[k + 1].position - firstControlPoints[k + 1];
				}
				else if (k < num - 1)
				{
					endPoints[k + 1].precedingControlPointPosition = 2f * endPoints[k + 1].position - firstControlPoints[k + 1];
				}
				else
				{
					endPoints[k + 1].precedingControlPointPosition = (endPoints[num].position + firstControlPoints[num - 1]) * 0.5f;
				}
			}
			if (loop)
			{
				float num2 = Vector3.Distance(endPoints[0].followingControlPointPosition, endPoints[0].position);
				Vector3 vector = Vector3.Normalize(endPoints[num].position - endPoints[1].position);
				endPoints[0].precedingControlPointPosition = endPoints[0].position + vector * num2 * 0.5f;
				endPoints[0].followingControlPointLocalPosition = -endPoints[0].precedingControlPointLocalPosition;
			}
		}

		private static Vector3[] GetFirstControlPoints(Vector3[] rhs)
		{
			int num = rhs.Length;
			Vector3[] array = new Vector3[num];
			float[] array2 = new float[num];
			float num2 = 2f;
			array[0] = rhs[0] / num2;
			for (int i = 1; i < num; i++)
			{
				float num3 = (array2[i] = 1f / num2);
				num2 = ((i < num - 1) ? 4f : 3.5f) - num3;
				array[i] = (rhs[i] - array[i - 1]) / num2;
			}
			for (int j = 1; j < num; j++)
			{
				array[num - j - 1] -= array2[num - j] * array[num - j];
			}
			return array;
		}

		public void AutoConstructSpline2()
		{
			for (int i = 0; i < endPoints.Count; i++)
			{
				Vector3 vector = ((i != 0) ? endPoints[i - 1].position : ((!loop) ? endPoints[0].position : endPoints[endPoints.Count - 1].position));
				Vector3 position;
				Vector3 position2;
				if (loop)
				{
					position = endPoints[(i + 1) % endPoints.Count].position;
					position2 = endPoints[(i + 2) % endPoints.Count].position;
				}
				else if (i < endPoints.Count - 2)
				{
					position = endPoints[i + 1].position;
					position2 = endPoints[i + 2].position;
				}
				else if (i == endPoints.Count - 2)
				{
					position = endPoints[i + 1].position;
					position2 = endPoints[i + 1].position;
				}
				else
				{
					position = endPoints[i].position;
					position2 = endPoints[i].position;
				}
				endPoints[i].followingControlPointPosition = endPoints[i].position + (position - vector) / 6f;
				endPoints[i].handleMode = BezierPoint.HandleMode.Mirrored;
				if (i < endPoints.Count - 1)
				{
					endPoints[i + 1].precedingControlPointPosition = position - (position2 - endPoints[i].position) / 6f;
				}
				else if (loop)
				{
					endPoints[0].precedingControlPointPosition = position - (position2 - endPoints[i].position) / 6f;
				}
			}
		}

		private float AccuracyToStepSize(float accuracy)
		{
			if (accuracy <= 0f)
			{
				return 0.2f;
			}
			return Mathf.Clamp(1f / accuracy, 0.001f, 0.2f);
		}

		private void OnRenderObject()
		{
			if (drawGizmos && endPoints.Count >= 2)
			{
				if (!gizmoMaterial)
				{
					gizmoMaterial = new Material(Shader.Find("Hidden/Internal-Colored"))
					{
						hideFlags = HideFlags.HideAndDontSave
					};
					gizmoMaterial.SetInt("_SrcBlend", 5);
					gizmoMaterial.SetInt("_DstBlend", 10);
					gizmoMaterial.SetInt("_Cull", 0);
					gizmoMaterial.SetInt("_ZWrite", 0);
				}
				gizmoMaterial.SetPass(0);
				GL.Begin(1);
				GL.Color(gizmoColor);
				Vector3 vector = endPoints[0].position;
				for (float num = gizmoStep; num < 1f; num += gizmoStep)
				{
					GL.Vertex3(vector.x, vector.y, vector.z);
					vector = GetPoint(num);
					GL.Vertex3(vector.x, vector.y, vector.z);
				}
				GL.Vertex3(vector.x, vector.y, vector.z);
				vector = GetPoint(1f);
				GL.Vertex3(vector.x, vector.y, vector.z);
				GL.End();
			}
		}
	}
	public class BezierWalkerWithSpeed : MonoBehaviour
	{
		public enum TravelMode
		{
			Once,
			Loop,
			PingPong
		}

		private Transform cachedTransform;

		public BezierSpline spline;

		public TravelMode travelMode;

		public float speed = 5f;

		private float progress;

		[Range(0f, 0.06f)]
		public float relaxationAtEndPoints = 0.01f;

		public float rotationLerpModifier = 10f;

		public bool lookForward = true;

		private bool isGoingForward = true;

		public UnityEvent onPathCompleted = new UnityEvent();

		private bool onPathCompletedCalledAt1;

		private bool onPathCompletedCalledAt0;

		public float NormalizedT
		{
			get
			{
				return progress;
			}
			set
			{
				progress = value;
			}
		}

		private void Awake()
		{
			cachedTransform = base.transform;
		}

		private void Update()
		{
			float num = (isGoingForward ? speed : (0f - speed));
			Vector3 position = spline.MoveAlongSpline(ref progress, num * Time.deltaTime);
			cachedTransform.position = position;
			bool flag = speed > 0f == isGoingForward;
			if (lookForward)
			{
				Quaternion b = ((!flag) ? Quaternion.LookRotation(-spline.GetTangent(progress)) : Quaternion.LookRotation(spline.GetTangent(progress)));
				cachedTransform.rotation = Quaternion.Lerp(cachedTransform.rotation, b, rotationLerpModifier * Time.deltaTime);
			}
			if (flag)
			{
				if (progress >= 1f - relaxationAtEndPoints)
				{
					if (!onPathCompletedCalledAt1)
					{
						onPathCompleted.Invoke();
						onPathCompletedCalledAt1 = true;
					}
					if (travelMode == TravelMode.Once)
					{
						progress = 1f;
						return;
					}
					if (travelMode == TravelMode.Loop)
					{
						progress -= 1f;
						return;
					}
					progress = 2f - progress;
					isGoingForward = !isGoingForward;
				}
				else
				{
					onPathCompletedCalledAt1 = false;
				}
			}
			else if (progress <= relaxationAtEndPoints)
			{
				if (!onPathCompletedCalledAt0)
				{
					onPathCompleted.Invoke();
					onPathCompletedCalledAt0 = true;
				}
				if (travelMode == TravelMode.Once)
				{
					progress = 0f;
					return;
				}
				if (travelMode == TravelMode.Loop)
				{
					progress += 1f;
					return;
				}
				progress = 0f - progress;
				isGoingForward = !isGoingForward;
			}
			else
			{
				onPathCompletedCalledAt0 = false;
			}
		}
	}
	public class BezierWalkerWithTime : MonoBehaviour
	{
		public enum TravelMode
		{
			Once,
			Loop,
			PingPong
		}

		private Transform cachedTransform;

		public BezierSpline spline;

		public TravelMode travelMode;

		public float travelTime = 5f;

		private float progress;

		public float movementLerpModifier = 10f;

		public float rotationLerpModifier = 10f;

		public bool lookForward = true;

		private bool isGoingForward = true;

		public UnityEvent onPathCompleted = new UnityEvent();

		private bool onPathCompletedCalledAt1;

		private bool onPathCompletedCalledAt0;

		public float NormalizedT
		{
			get
			{
				return progress;
			}
			set
			{
				progress = value;
			}
		}

		private void Awake()
		{
			cachedTransform = base.transform;
		}

		private void Update()
		{
			cachedTransform.position = Vector3.Lerp(cachedTransform.position, spline.GetPoint(progress), movementLerpModifier * Time.deltaTime);
			if (lookForward)
			{
				Quaternion b = ((!isGoingForward) ? Quaternion.LookRotation(-spline.GetTangent(progress)) : Quaternion.LookRotation(spline.GetTangent(progress)));
				cachedTransform.rotation = Quaternion.Lerp(cachedTransform.rotation, b, rotationLerpModifier * Time.deltaTime);
			}
			if (isGoingForward)
			{
				progress += Time.deltaTime / travelTime;
				if (progress > 1f)
				{
					if (!onPathCompletedCalledAt1)
					{
						onPathCompleted.Invoke();
						onPathCompletedCalledAt1 = true;
					}
					if (travelMode == TravelMode.Once)
					{
						progress = 1f;
						return;
					}
					if (travelMode == TravelMode.Loop)
					{
						progress -= 1f;
						return;
					}
					progress = 2f - progress;
					isGoingForward = false;
				}
				else
				{
					onPathCompletedCalledAt1 = false;
				}
				return;
			}
			progress -= Time.deltaTime / travelTime;
			if (progress < 0f)
			{
				if (!onPathCompletedCalledAt0)
				{
					onPathCompleted.Invoke();
					onPathCompletedCalledAt0 = true;
				}
				if (travelMode == TravelMode.Once)
				{
					progress = 0f;
					return;
				}
				if (travelMode == TravelMode.Loop)
				{
					progress += 1f;
					return;
				}
				progress = 0f - progress;
				isGoingForward = true;
			}
			else
			{
				onPathCompletedCalledAt0 = false;
			}
		}
	}
	[ExecuteInEditMode]
	public class ParticlesFollowBezier : MonoBehaviour
	{
		public enum FollowMode
		{
			Relaxed,
			Strict
		}

		private const int MAX_PARTICLE_COUNT = 25000;

		public BezierSpline spline;

		public FollowMode followMode;

		private Transform cachedTransform;

		private ParticleSystem cachedPS;

		private ParticleSystem.MainModule cachedMainModule;

		private ParticleSystem.Particle[] particles;

		private List<Vector4> particleData;

		private void Awake()
		{
			cachedTransform = base.transform;
			cachedPS = GetComponent<ParticleSystem>();
			cachedMainModule = cachedPS.main;
			particles = new ParticleSystem.Particle[cachedMainModule.maxParticles];
			if (followMode == FollowMode.Relaxed)
			{
				particleData = new List<Vector4>(particles.Length);
			}
		}

		private void LateUpdate()
		{
			if (spline == null || cachedPS == null)
			{
				return;
			}
			if (particles.Length < cachedMainModule.maxParticles && particles.Length < 25000)
			{
				particles = new ParticleSystem.Particle[Mathf.Min(cachedMainModule.maxParticles, 25000)];
			}
			bool flag = cachedMainModule.simulationSpace != ParticleSystemSimulationSpace.World;
			int num = cachedPS.GetParticles(particles);
			if (followMode == FollowMode.Relaxed)
			{
				if (particleData == null)
				{
					particleData = new List<Vector4>(particles.Length);
				}
				cachedPS.GetCustomParticleData(particleData, ParticleSystemCustomData.Custom1);
				for (int i = 0; i < num; i++)
				{
					Vector4 vector = particleData[i];
					Vector3 vector2 = spline.GetPoint(1f - particles[i].remainingLifetime / particles[i].startLifetime);
					if (flag)
					{
						vector2 = cachedTransform.InverseTransformPoint(vector2);
					}
					if (vector.w != 0f)
					{
						particles[i].position += vector2 - (Vector3)vector;
					}
					vector = vector2;
					vector.w = 1f;
					particleData[i] = vector;
				}
				cachedPS.SetCustomParticleData(particleData, ParticleSystemCustomData.Custom1);
			}
			else
			{
				Vector3 vector3 = cachedTransform.position - spline.GetPoint(0f);
				for (int j = 0; j < num; j++)
				{
					Vector3 position = spline.GetPoint(1f - particles[j].remainingLifetime / particles[j].startLifetime) + vector3;
					if (flag)
					{
						position = cachedTransform.InverseTransformPoint(position);
					}
					particles[j].position = position;
				}
			}
			cachedPS.SetParticles(particles, num);
		}
	}
}
