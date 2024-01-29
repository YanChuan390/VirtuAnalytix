using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using CodeStage.AdvancedFPSCounter.CountersData;
using CodeStage.AdvancedFPSCounter.Labels;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class GooglePlayDownloader
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass detectAndroidJNI;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x8")]
	private static AndroidJavaClass Environment;

	[Token(Token = "0x4000003")]
	private const string Environment_MEDIA_MOUNTED = "mounted";

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x10")]
	private static string obb_package;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x18")]
	private static int obb_version;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1F16510", Offset = "0x1F16510", VA = "0x1F16510")]
	public static bool RunningOnAndroid()
	{
		return default(bool);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1F16624", Offset = "0x1F16624", VA = "0x1F16624")]
	static GooglePlayDownloader()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1F168A8", Offset = "0x1F168A8", VA = "0x1F168A8")]
	public static string GetExpansionFilePath()
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1F17244", Offset = "0x1F17244", VA = "0x1F17244")]
	public static string GetMainOBBPath(string expansionFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1F1734C", Offset = "0x1F1734C", VA = "0x1F1734C")]
	public static string GetPatchOBBPath(string expansionFilePath)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1F17454", Offset = "0x1F17454", VA = "0x1F17454")]
	public static void FetchOBB()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1F16D24", Offset = "0x1F16D24", VA = "0x1F16D24")]
	private static void populateOBBData()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1F17B94", Offset = "0x1F17B94", VA = "0x1F17B94")]
	public GooglePlayDownloader()
	{
	}
}
[Token(Token = "0x2000003")]
public enum ContinuousGesturePhase
{
	[Token(Token = "0x4000007")]
	None,
	[Token(Token = "0x4000008")]
	Started,
	[Token(Token = "0x4000009")]
	Updated,
	[Token(Token = "0x400000A")]
	Ended
}
[Token(Token = "0x2000004")]
public abstract class ContinuousGesture : Gesture
{
	[Token(Token = "0x17000001")]
	public ContinuousGesturePhase Phase
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x231FEEC", Offset = "0x231FEEC", VA = "0x231FEEC")]
		get
		{
			return default(ContinuousGesturePhase);
		}
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x231FF14", Offset = "0x231FF14", VA = "0x231FF14")]
	protected ContinuousGesture()
	{
	}
}
[Token(Token = "0x2000005")]
public abstract class ContinuousGestureRecognizer<T> : GestureRecognizerTS<T> where T : ContinuousGesture, new()
{
	[Token(Token = "0x600000B")]
	protected override void Reset(T gesture)
	{
	}

	[Token(Token = "0x600000C")]
	protected override void OnStateChanged(Gesture sender)
	{
	}

	[Token(Token = "0x600000D")]
	protected ContinuousGestureRecognizer()
	{
	}
}
[Token(Token = "0x2000006")]
public class DiscreteGesture : Gesture
{
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x232644C", Offset = "0x232644C", VA = "0x232644C")]
	public DiscreteGesture()
	{
	}
}
[Token(Token = "0x2000007")]
public abstract class DiscreteGestureRecognizer<T> : GestureRecognizerTS<T> where T : DiscreteGesture, new()
{
	[Token(Token = "0x600000F")]
	protected override void OnStateChanged(Gesture sender)
	{
	}

	[Token(Token = "0x6000010")]
	protected DiscreteGestureRecognizer()
	{
	}
}
[Token(Token = "0x2000008")]
public class FingerEvent
{
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x10")]
	private FingerEventDetector detector;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x18")]
	private FingerGestures.Finger finger;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x20")]
	private string name;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x28")]
	private GameObject selection;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x30")]
	private ScreenRaycastData raycast;

	[Token(Token = "0x17000002")]
	public string Name
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1F11010", Offset = "0x1F11010", VA = "0x1F11010")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1F11018", Offset = "0x1F11018", VA = "0x1F11018")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public FingerEventDetector Detector
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1F11020", Offset = "0x1F11020", VA = "0x1F11020")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1F11028", Offset = "0x1F11028", VA = "0x1F11028")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public FingerGestures.Finger Finger
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1F11030", Offset = "0x1F11030", VA = "0x1F11030")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1F11038", Offset = "0x1F11038", VA = "0x1F11038")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public virtual Vector2 Position
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1F11040", Offset = "0x1F11040", VA = "0x1F11040", Slot = "4")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1F1105C", Offset = "0x1F1105C", VA = "0x1F1105C", Slot = "5")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public GameObject Selection
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1F110FC", Offset = "0x1F110FC", VA = "0x1F110FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1F11104", Offset = "0x1F11104", VA = "0x1F11104")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public ScreenRaycastData Raycast
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1F1110C", Offset = "0x1F1110C", VA = "0x1F1110C")]
		get
		{
			return default(ScreenRaycastData);
		}
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1F1111C", Offset = "0x1F1111C", VA = "0x1F1111C")]
		internal set
		{
		}
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1F10FB4", Offset = "0x1F10FB4", VA = "0x1F10FB4")]
	public FingerEvent()
	{
	}
}
[Token(Token = "0x2000009")]
public abstract class FingerEventDetector<T> : FingerEventDetector where T : FingerEvent, new()
{
	[Token(Token = "0x200000A")]
	public delegate void FingerEventHandler(T eventData);

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x0")]
	private List<T> fingerEventsList;

	[Token(Token = "0x600001E")]
	protected virtual T CreateFingerEvent()
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	public override Type GetEventType()
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000021")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000022")]
	private void FingerGestures_OnInputProviderChanged()
	{
	}

	[Token(Token = "0x6000023")]
	protected virtual void Init()
	{
	}

	[Token(Token = "0x6000024")]
	protected virtual void Init(int fingersCount)
	{
	}

	[Token(Token = "0x6000025")]
	protected T GetEvent(FingerGestures.Finger finger)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	protected virtual T GetEvent(int fingerIndex)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	protected FingerEventDetector()
	{
	}
}
[Token(Token = "0x200000B")]
public abstract class FingerEventDetector : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x18")]
	public int FingerIndexFilter;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x20")]
	public ScreenRaycaster Raycaster;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x28")]
	public bool UseSendMessage;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x29")]
	public bool SendMessageToSelection;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x30")]
	public GameObject MessageTarget;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x38")]
	private FingerGestures.Finger activeFinger;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x40")]
	private ScreenRaycastData lastRaycast;

	[Token(Token = "0x17000008")]
	internal ScreenRaycastData Raycast
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1F114C4", Offset = "0x1F114C4", VA = "0x1F114C4")]
		get
		{
			return default(ScreenRaycastData);
		}
	}

	[Token(Token = "0x600002C")]
	protected abstract void ProcessFinger(FingerGestures.Finger finger);

	[Token(Token = "0x600002D")]
	public abstract Type GetEventType();

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1F11138", Offset = "0x1F11138", VA = "0x1F11138", Slot = "6")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1F11210", Offset = "0x1F11210", VA = "0x1F11210", Slot = "7")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1F11214", Offset = "0x1F11214", VA = "0x1F11214", Slot = "8")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1F11220", Offset = "0x1F11220", VA = "0x1F11220", Slot = "9")]
	protected virtual void ProcessFingers()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1F10E08", Offset = "0x1F10E08", VA = "0x1F10E08")]
	protected void TrySendMessage(FingerEvent eventData)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1F114D4", Offset = "0x1F114D4", VA = "0x1F114D4")]
	public GameObject PickObject(Vector2 screenPos)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1F10DB4", Offset = "0x1F10DB4", VA = "0x1F10DB4")]
	protected void UpdateSelection(FingerEvent e)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1F117EC", Offset = "0x1F117EC", VA = "0x1F117EC")]
	protected FingerEventDetector()
	{
	}
}
[Token(Token = "0x200000C")]
public enum GestureRecognitionState
{
	[Token(Token = "0x4000019")]
	Ready = 0,
	[Token(Token = "0x400001A")]
	Started = 1,
	[Token(Token = "0x400001B")]
	InProgress = 2,
	[Token(Token = "0x400001C")]
	Failed = 3,
	[Token(Token = "0x400001D")]
	Ended = 4,
	[Token(Token = "0x400001E")]
	Recognized = 4,
	[Token(Token = "0x400001F")]
	FailAndRetry = 5
}
[Token(Token = "0x200000D")]
public enum GestureResetMode
{
	[Token(Token = "0x4000021")]
	Default,
	[Token(Token = "0x4000022")]
	NextFrame,
	[Token(Token = "0x4000023")]
	EndOfTouchSequence
}
[Token(Token = "0x200000E")]
public abstract class Gesture
{
	[Token(Token = "0x200000F")]
	public delegate void EventHandler(Gesture gesture);

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x18")]
	internal int ClusterId;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x20")]
	private GestureRecognizer recognizer;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x28")]
	private float startTime;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x2C")]
	private Vector2 startPosition;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x34")]
	private Vector2 position;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x3C")]
	private GestureRecognitionState state;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x40")]
	private GestureRecognitionState prevState;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x48")]
	private FingerGestures.FingerList fingers;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x50")]
	private GameObject startSelection;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x58")]
	private GameObject selection;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x60")]
	private ScreenRaycastData lastRaycast;

	[Token(Token = "0x17000009")]
	public FingerGestures.FingerList Fingers
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1F150BC", Offset = "0x1F150BC", VA = "0x1F150BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1F150C4", Offset = "0x1F150C4", VA = "0x1F150C4")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public GestureRecognizer Recognizer
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1F150CC", Offset = "0x1F150CC", VA = "0x1F150CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1F150D4", Offset = "0x1F150D4", VA = "0x1F150D4")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public float StartTime
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1F150DC", Offset = "0x1F150DC", VA = "0x1F150DC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1F150E4", Offset = "0x1F150E4", VA = "0x1F150E4")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public Vector2 StartPosition
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1F150EC", Offset = "0x1F150EC", VA = "0x1F150EC")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1F150F4", Offset = "0x1F150F4", VA = "0x1F150F4")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public Vector2 Position
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1F150FC", Offset = "0x1F150FC", VA = "0x1F150FC")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1F15104", Offset = "0x1F15104", VA = "0x1F15104")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public GestureRecognitionState State
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1F1510C", Offset = "0x1F1510C", VA = "0x1F1510C")]
		get
		{
			return default(GestureRecognitionState);
		}
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1F15114", Offset = "0x1F15114", VA = "0x1F15114")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public GestureRecognitionState PreviousState
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1F15140", Offset = "0x1F15140", VA = "0x1F15140")]
		get
		{
			return default(GestureRecognitionState);
		}
	}

	[Token(Token = "0x17000010")]
	public float ElapsedTime
	{
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1F15148", Offset = "0x1F15148", VA = "0x1F15148")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000011")]
	public GameObject StartSelection
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1F15174", Offset = "0x1F15174", VA = "0x1F15174")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1F1517C", Offset = "0x1F1517C", VA = "0x1F1517C")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public GameObject Selection
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1F15184", Offset = "0x1F15184", VA = "0x1F15184")]
		get
		{
			return null;
		}
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1F1518C", Offset = "0x1F1518C", VA = "0x1F1518C")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public ScreenRaycastData Raycast
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1F15194", Offset = "0x1F15194", VA = "0x1F15194")]
		get
		{
			return default(ScreenRaycastData);
		}
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1F151A4", Offset = "0x1F151A4", VA = "0x1F151A4")]
		internal set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event EventHandler OnStateChanged
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1F14F70", Offset = "0x1F14F70", VA = "0x1F14F70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24C88", Offset = "0xA24C88")]
		add
		{
		}
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1F15010", Offset = "0x1F15010", VA = "0x1F15010")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24C98", Offset = "0xA24C98")]
		remove
		{
		}
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1F150B0", Offset = "0x1F150B0", VA = "0x1F150B0")]
	public static implicit operator bool(Gesture gesture)
	{
		return default(bool);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1F151C0", Offset = "0x1F151C0", VA = "0x1F151C0")]
	internal GameObject PickObject(ScreenRaycaster raycaster, Vector2 screenPos)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1F15298", Offset = "0x1F15298", VA = "0x1F15298")]
	internal void PickStartSelection(ScreenRaycaster raycaster)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1F152C0", Offset = "0x1F152C0", VA = "0x1F152C0")]
	internal void PickSelection(ScreenRaycaster raycaster)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1F152E8", Offset = "0x1F152E8", VA = "0x1F152E8")]
	protected Gesture()
	{
	}
}
[Token(Token = "0x2000010")]
public abstract class GestureRecognizerTS<T> : GestureRecognizer where T : Gesture, new()
{
	[Token(Token = "0x2000011")]
	public delegate void GestureEventHandler(T gesture);

	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA21710", Offset = "0xA21710")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x0")]
		public FingerClusterManager.Cluster cluster;

		[Token(Token = "0x6000078")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x6000079")]
		internal bool <FindGestureByCluster>b__0(T g)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA21720", Offset = "0xA21720")]
	private sealed class <>c
	{
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x0")]
		public static Predicate<T> <>9__20_0;

		[Token(Token = "0x600007B")]
		public <>c()
		{
		}

		[Token(Token = "0x600007C")]
		internal bool <FindFreeGesture>b__20_0(T g)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x0")]
	private List<T> gestures;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x0")]
	private static FingerGestures.FingerList tempTouchList;

	[Token(Token = "0x17000014")]
	public List<T> Gestures
	{
		[Token(Token = "0x600005C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000002")]
	public event GestureEventHandler OnGesture
	{
		[Token(Token = "0x6000056")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24CA8", Offset = "0xA24CA8")]
		add
		{
		}
		[Token(Token = "0x6000057")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24CB8", Offset = "0xA24CB8")]
		remove
		{
		}
	}

	[Token(Token = "0x6000058")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000059")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600005A")]
	private void InitGestures()
	{
	}

	[Token(Token = "0x600005B")]
	protected T AddGesture()
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	protected virtual bool CanBegin(T gesture, FingerGestures.IFingerList touches)
	{
		return default(bool);
	}

	[Token(Token = "0x600005E")]
	protected abstract void OnBegin(T gesture, FingerGestures.IFingerList touches);

	[Token(Token = "0x600005F")]
	protected abstract GestureRecognitionState OnRecognize(T gesture, FingerGestures.IFingerList touches);

	[Token(Token = "0x6000060")]
	protected virtual GameObject GetDefaultSelectionForSendMessage(T gesture)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	protected virtual T CreateGesture()
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	public override Type GetGestureType()
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	protected virtual void OnStateChanged(Gesture gesture)
	{
	}

	[Token(Token = "0x6000064")]
	protected virtual T FindGestureByCluster(FingerClusterManager.Cluster cluster)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	protected virtual T MatchActiveGestureToCluster(FingerClusterManager.Cluster cluster)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	protected virtual T FindFreeGesture()
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	protected virtual void Reset(T gesture)
	{
	}

	[Token(Token = "0x6000068")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000069")]
	private void UpdateExclusive()
	{
	}

	[Token(Token = "0x600006A")]
	private void UpdatePerFinger()
	{
	}

	[Token(Token = "0x600006B")]
	private void UpdateUsingClusters()
	{
	}

	[Token(Token = "0x600006C")]
	protected virtual void ProcessCluster(FingerClusterManager.Cluster cluster)
	{
	}

	[Token(Token = "0x600006D")]
	private void ReleaseFingers(T gesture)
	{
	}

	[Token(Token = "0x600006E")]
	private void Begin(T gesture, int clusterId, FingerGestures.IFingerList touches)
	{
	}

	[Token(Token = "0x600006F")]
	protected virtual FingerGestures.IFingerList GetTouches(T gesture)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	protected virtual void UpdateGesture(T gesture, FingerGestures.IFingerList touches)
	{
	}

	[Token(Token = "0x6000071")]
	protected void RaiseEvent(T gesture)
	{
	}

	[Token(Token = "0x6000072")]
	protected GestureRecognizerTS()
	{
	}
}
[Token(Token = "0x2000014")]
public abstract class GestureRecognizer : MonoBehaviour
{
	[Token(Token = "0x2000015")]
	public enum SelectionType
	{
		[Token(Token = "0x4000044")]
		Default,
		[Token(Token = "0x4000045")]
		StartSelection,
		[Token(Token = "0x4000046")]
		CurrentSelection,
		[Token(Token = "0x4000047")]
		None
	}

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x0")]
	protected static readonly FingerGestures.IFingerList EmptyFingerList;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private int requiredFingerCount;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x1C")]
	public DistanceUnit DistanceUnit;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x20")]
	public int MaxSimultaneousGestures;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x24")]
	public GestureResetMode ResetMode;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x28")]
	public ScreenRaycaster Raycaster;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x30")]
	public FingerClusterManager ClusterManager;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x38")]
	public GestureRecognizerDelegate Delegate;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x40")]
	public bool UseSendMessage;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x48")]
	public string EventMessageName;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x50")]
	public GameObject EventMessageTarget;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x58")]
	public SelectionType SendMessageToSelection;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x5C")]
	public bool IsExclusive;

	[Token(Token = "0x17000015")]
	public virtual int RequiredFingerCount
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1F15364", Offset = "0x1F15364", VA = "0x1F15364", Slot = "4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1F1536C", Offset = "0x1F1536C", VA = "0x1F1536C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public virtual bool SupportFingerClustering
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1F15374", Offset = "0x1F15374", VA = "0x1F15374", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1F1537C", Offset = "0x1F1537C", VA = "0x1F1537C", Slot = "7")]
	public virtual GestureResetMode GetDefaultResetMode()
	{
		return default(GestureResetMode);
	}

	[Token(Token = "0x6000081")]
	public abstract string GetDefaultEventMessageName();

	[Token(Token = "0x6000082")]
	public abstract Type GetGestureType();

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1F15384", Offset = "0x1F15384", VA = "0x1F15384", Slot = "10")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1F1549C", Offset = "0x1F1549C", VA = "0x1F1549C", Slot = "11")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1F15648", Offset = "0x1F15648", VA = "0x1F15648", Slot = "12")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1F1575C", Offset = "0x1F1575C", VA = "0x1F1575C")]
	protected void Acquire(FingerGestures.Finger finger)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1F15800", Offset = "0x1F15800", VA = "0x1F15800")]
	protected bool Release(FingerGestures.Finger finger)
	{
		return default(bool);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1F15868", Offset = "0x1F15868", VA = "0x1F15868", Slot = "13")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1F15AA0", Offset = "0x1F15AA0", VA = "0x1F15AA0")]
	protected bool Young(FingerGestures.IFingerList touches)
	{
		return default(bool);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1F15B74", Offset = "0x1F15B74", VA = "0x1F15B74")]
	public float ToPixels(float distance)
	{
		return default(float);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1F15B80", Offset = "0x1F15B80", VA = "0x1F15B80")]
	public float ToSqrPixels(float distance)
	{
		return default(float);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1F15BA0", Offset = "0x1F15BA0", VA = "0x1F15BA0")]
	protected GestureRecognizer()
	{
	}
}
[Token(Token = "0x2000016")]
public abstract class GestureRecognizerDelegate : MonoBehaviour
{
	[Token(Token = "0x600008E")]
	public abstract bool CanBegin(Gesture gesture, FingerGestures.IFingerList touches);

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1F15C34", Offset = "0x1F15C34", VA = "0x1F15C34")]
	protected GestureRecognizerDelegate()
	{
	}
}
[Token(Token = "0x2000017")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21730", Offset = "0xA21730")]
public class FingerClusterManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000018")]
	public class Cluster
	{
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x10")]
		public int Id;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x14")]
		public float StartTime;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x18")]
		public FingerGestures.FingerList Fingers;

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x24E1110", Offset = "0x24E1110", VA = "0x24E1110")]
		public void Reset()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x24E117C", Offset = "0x24E117C", VA = "0x24E117C")]
		public Cluster()
		{
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA21768", Offset = "0xA21768")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x10")]
		public int clusterId;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x24E10E4", Offset = "0x24E10E4", VA = "0x24E10E4")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x24E10EC", Offset = "0x24E10EC", VA = "0x24E10EC")]
		internal bool <FindClusterById>b__0(Cluster c)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x18")]
	public DistanceUnit DistanceUnit;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x1C")]
	public float ClusterRadius;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x20")]
	public float TimeTolerance;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x24")]
	private int lastUpdateFrame;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x28")]
	private int nextClusterId;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x30")]
	private List<Cluster> clusters;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x38")]
	private List<Cluster> clusterPool;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x40")]
	private FingerGestures.FingerList fingersAdded;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x48")]
	private FingerGestures.FingerList fingersRemoved;

	[Token(Token = "0x17000017")]
	public FingerGestures.IFingerList FingersAdded
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1F10254", Offset = "0x1F10254", VA = "0x1F10254")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000018")]
	public FingerGestures.IFingerList FingersRemoved
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1F1025C", Offset = "0x1F1025C", VA = "0x1F1025C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000019")]
	public List<Cluster> Clusters
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1F10264", Offset = "0x1F10264", VA = "0x1F10264")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1F1026C", Offset = "0x1F1026C", VA = "0x1F1026C")]
	public List<Cluster> GetClustersPool()
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1F10274", Offset = "0x1F10274", VA = "0x1F10274")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1F10348", Offset = "0x1F10348", VA = "0x1F10348")]
	public void Update()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1F109C0", Offset = "0x1F109C0", VA = "0x1F109C0")]
	public Cluster FindClusterById(int clusterId)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1F1089C", Offset = "0x1F1089C", VA = "0x1F1089C")]
	private Cluster NewCluster()
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1F1073C", Offset = "0x1F1073C", VA = "0x1F1073C")]
	private Cluster FindExistingCluster(FingerGestures.Finger finger)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1F10B7C", Offset = "0x1F10B7C", VA = "0x1F10B7C")]
	public FingerClusterManager()
	{
	}
}
[Token(Token = "0x200001A")]
public struct ScreenRaycastData
{
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x0")]
	public bool Is2D;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x4")]
	public RaycastHit Hit3D;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x30")]
	public RaycastHit2D Hit2D;

	[Token(Token = "0x1700001A")]
	public GameObject GameObject
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1F116E0", Offset = "0x1F116E0", VA = "0x1F116E0")]
		get
		{
			return null;
		}
	}
}
[Token(Token = "0x200001B")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21778", Offset = "0xA21778")]
public class ScreenRaycaster : MonoBehaviour
{
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x18")]
	public Camera[] Cameras;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask IgnoreLayerMask;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x24")]
	public float RayThickness;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x28")]
	public bool VisualizeRaycasts;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x29")]
	public bool UsePhysics2D;

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1F1EA3C", Offset = "0x1F1EA3C", VA = "0x1F1EA3C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1F115A4", Offset = "0x1F115A4", VA = "0x1F115A4")]
	public bool Raycast(Vector2 screenPos, out ScreenRaycastData hitData)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1F1EAFC", Offset = "0x1F1EAFC", VA = "0x1F1EAFC")]
	private bool Raycast(Camera cam, Vector2 screenPos, out ScreenRaycastData hitData)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1F1ED88", Offset = "0x1F1ED88", VA = "0x1F1ED88")]
	public ScreenRaycaster()
	{
	}
}
[Token(Token = "0x200001C")]
public class FingerDownEvent : FingerEvent
{
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1F10FB0", Offset = "0x1F10FB0", VA = "0x1F10FB0")]
	public FingerDownEvent()
	{
	}
}
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA217B0", Offset = "0xA217B0")]
public class FingerDownDetector : FingerEventDetector<FingerDownEvent>
{
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0xA8")]
	public string MessageName;

	[Token(Token = "0x14000003")]
	public event FingerEventHandler OnFingerDown
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1F10B9C", Offset = "0x1F10B9C", VA = "0x1F10B9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24CC8", Offset = "0xA24CC8")]
		add
		{
		}
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1F10C3C", Offset = "0x1F10C3C", VA = "0x1F10C3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24CD8", Offset = "0xA24CD8")]
		remove
		{
		}
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1F10CDC", Offset = "0x1F10CDC", VA = "0x1F10CDC", Slot = "4")]
	protected override void ProcessFinger(FingerGestures.Finger finger)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1F10F48", Offset = "0x1F10F48", VA = "0x1F10F48")]
	public FingerDownDetector()
	{
	}
}
[Token(Token = "0x200001E")]
public enum FingerHoverPhase
{
	[Token(Token = "0x4000060")]
	None,
	[Token(Token = "0x4000061")]
	Enter,
	[Token(Token = "0x4000062")]
	Exit
}
[Token(Token = "0x200001F")]
public class FingerHoverEvent : FingerEvent
{
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x84")]
	private FingerHoverPhase phase;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x88")]
	internal GameObject PreviousSelection;

	[Token(Token = "0x1700001B")]
	public FingerHoverPhase Phase
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1F13DE0", Offset = "0x1F13DE0", VA = "0x1F13DE0")]
		get
		{
			return default(FingerHoverPhase);
		}
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1F13DE8", Offset = "0x1F13DE8", VA = "0x1F13DE8")]
		internal set
		{
		}
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1F13DF0", Offset = "0x1F13DF0", VA = "0x1F13DF0")]
	public FingerHoverEvent()
	{
	}
}
[Token(Token = "0x2000020")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA217E8", Offset = "0xA217E8")]
public class FingerHoverDetector : FingerEventDetector<FingerHoverEvent>
{
	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0xA8")]
	public string MessageName;

	[Token(Token = "0x14000004")]
	public event FingerEventHandler OnFingerHover
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1F13920", Offset = "0x1F13920", VA = "0x1F13920")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24CE8", Offset = "0xA24CE8")]
		add
		{
		}
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1F139C0", Offset = "0x1F139C0", VA = "0x1F139C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24CF8", Offset = "0xA24CF8")]
		remove
		{
		}
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1F13A60", Offset = "0x1F13A60", VA = "0x1F13A60", Slot = "7")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1F13B84", Offset = "0x1F13B84", VA = "0x1F13B84")]
	private bool FireEvent(FingerHoverEvent e, FingerHoverPhase phase)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1F13C10", Offset = "0x1F13C10", VA = "0x1F13C10", Slot = "4")]
	protected override void ProcessFinger(FingerGestures.Finger finger)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1F13D78", Offset = "0x1F13D78", VA = "0x1F13D78")]
	public FingerHoverDetector()
	{
	}
}
[Token(Token = "0x2000021")]
public enum FingerMotionPhase
{
	[Token(Token = "0x4000068")]
	None,
	[Token(Token = "0x4000069")]
	Started,
	[Token(Token = "0x400006A")]
	Updated,
	[Token(Token = "0x400006B")]
	Ended
}
[Token(Token = "0x2000022")]
public class FingerMotionEvent : FingerEvent
{
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x84")]
	private FingerMotionPhase phase;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x88")]
	private Vector2 position;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x90")]
	internal float StartTime;

	[Token(Token = "0x1700001C")]
	public override Vector2 Position
	{
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1F14490", Offset = "0x1F14490", VA = "0x1F14490", Slot = "4")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1F14498", Offset = "0x1F14498", VA = "0x1F14498", Slot = "5")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public FingerMotionPhase Phase
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1F144A0", Offset = "0x1F144A0", VA = "0x1F144A0")]
		get
		{
			return default(FingerMotionPhase);
		}
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1F144A8", Offset = "0x1F144A8", VA = "0x1F144A8")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public float ElapsedTime
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1F144B0", Offset = "0x1F144B0", VA = "0x1F144B0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1F144E4", Offset = "0x1F144E4", VA = "0x1F144E4")]
	public FingerMotionEvent()
	{
	}
}
[Token(Token = "0x2000023")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21820", Offset = "0xA21820")]
public class FingerMotionDetector : FingerEventDetector<FingerMotionEvent>
{
	[Token(Token = "0x2000024")]
	private enum EventType
	{
		[Token(Token = "0x4000076")]
		Move,
		[Token(Token = "0x4000077")]
		Stationary
	}

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0xB0")]
	public string MoveMessageName;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0xB8")]
	public string StationaryMessageName;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0xC0")]
	public bool TrackMove;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0xC1")]
	public bool TrackStationary;

	[Token(Token = "0x14000005")]
	public event FingerEventHandler OnFingerMove
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1F13DF4", Offset = "0x1F13DF4", VA = "0x1F13DF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24D08", Offset = "0xA24D08")]
		add
		{
		}
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1F13E94", Offset = "0x1F13E94", VA = "0x1F13E94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24D18", Offset = "0xA24D18")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event FingerEventHandler OnFingerStationary
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1F13F34", Offset = "0x1F13F34", VA = "0x1F13F34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24D28", Offset = "0xA24D28")]
		add
		{
		}
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1F13FD4", Offset = "0x1F13FD4", VA = "0x1F13FD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24D38", Offset = "0xA24D38")]
		remove
		{
		}
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1F14074", Offset = "0x1F14074", VA = "0x1F14074")]
	private bool FireEvent(FingerMotionEvent e, EventType eventType, FingerMotionPhase phase, Vector2 position, bool updateSelection)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1F1425C", Offset = "0x1F1425C", VA = "0x1F1425C", Slot = "4")]
	protected override void ProcessFinger(FingerGestures.Finger finger)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1F14404", Offset = "0x1F14404", VA = "0x1F14404")]
	public FingerMotionDetector()
	{
	}
}
[Token(Token = "0x2000025")]
public class FingerUpEvent : FingerEvent
{
	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x84")]
	private float timeHeldDown;

	[Token(Token = "0x1700001F")]
	public float TimeHeldDown
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1F147BC", Offset = "0x1F147BC", VA = "0x1F147BC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1F147C4", Offset = "0x1F147C4", VA = "0x1F147C4")]
		internal set
		{
		}
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1F147CC", Offset = "0x1F147CC", VA = "0x1F147CC")]
	public FingerUpEvent()
	{
	}
}
[Token(Token = "0x2000026")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21858", Offset = "0xA21858")]
public class FingerUpDetector : FingerEventDetector<FingerUpEvent>
{
	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0xA8")]
	public string MessageName;

	[Token(Token = "0x14000007")]
	public event FingerEventHandler OnFingerUp
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1F14510", Offset = "0x1F14510", VA = "0x1F14510")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24D48", Offset = "0xA24D48")]
		add
		{
		}
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1F145B0", Offset = "0x1F145B0", VA = "0x1F145B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24D58", Offset = "0xA24D58")]
		remove
		{
		}
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1F14650", Offset = "0x1F14650", VA = "0x1F14650", Slot = "4")]
	protected override void ProcessFinger(FingerGestures.Finger finger)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1F14754", Offset = "0x1F14754", VA = "0x1F14754")]
	public FingerUpDetector()
	{
	}
}
[Token(Token = "0x2000027")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21890", Offset = "0xA21890")]
public class FingerGestures : MonoBehaviour
{
	[Token(Token = "0x2000028")]
	public enum FingerPhase
	{
		[Token(Token = "0x4000091")]
		None,
		[Token(Token = "0x4000092")]
		Begin,
		[Token(Token = "0x4000093")]
		Moving,
		[Token(Token = "0x4000094")]
		Stationary
	}

	[Token(Token = "0x2000029")]
	public delegate void EventHandler();

	[Token(Token = "0x200002A")]
	public class InputProviderEvent
	{
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x10")]
		public FGInputProvider inputProviderPrefab;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x24E27F4", Offset = "0x24E27F4", VA = "0x24E27F4")]
		public InputProviderEvent()
		{
		}
	}

	[Token(Token = "0x200002B")]
	public class Finger
	{
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x10")]
		private int index;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x14")]
		private FingerPhase phase;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x18")]
		private FingerPhase prevPhase;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x1C")]
		private Vector2 pos;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x24")]
		private Vector2 startPos;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x2C")]
		private Vector2 prevPos;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x34")]
		private Vector2 deltaPos;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x3C")]
		private float startTime;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x40")]
		private float lastMoveTime;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x44")]
		private float distFromStart;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x48")]
		private bool moved;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x49")]
		private bool filteredOut;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x50")]
		private Collider collider;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x58")]
		private Collider prevCollider;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x60")]
		private float elapsedTimeStationary;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x68")]
		private List<GestureRecognizer> gestureRecognizers;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<string, object> extendedProperties;

		[Token(Token = "0x17000028")]
		public int Index
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x24E14AC", Offset = "0x24E14AC", VA = "0x24E14AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		public bool IsDown
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x24E14B4", Offset = "0x24E14B4", VA = "0x24E14B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public FingerPhase Phase
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x24E14C4", Offset = "0x24E14C4", VA = "0x24E14C4")]
			get
			{
				return default(FingerPhase);
			}
		}

		[Token(Token = "0x1700002B")]
		public FingerPhase PreviousPhase
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x24E14CC", Offset = "0x24E14CC", VA = "0x24E14CC")]
			get
			{
				return default(FingerPhase);
			}
		}

		[Token(Token = "0x1700002C")]
		public bool WasDown
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x24E14D4", Offset = "0x24E14D4", VA = "0x24E14D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002D")]
		public bool IsMoving
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x24DFD04", Offset = "0x24DFD04", VA = "0x24DFD04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002E")]
		public bool WasMoving
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x24E14E4", Offset = "0x24E14E4", VA = "0x24E14E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public bool IsStationary
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x24E14F4", Offset = "0x24E14F4", VA = "0x24E14F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000030")]
		public bool WasStationary
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x24E1504", Offset = "0x24E1504", VA = "0x24E1504")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000031")]
		public bool Moved
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x24E1514", Offset = "0x24E1514", VA = "0x24E1514")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000032")]
		public float StarTime
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x24E151C", Offset = "0x24E151C", VA = "0x24E151C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000033")]
		public Vector2 StartPosition
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x24E1524", Offset = "0x24E1524", VA = "0x24E1524")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000034")]
		public Vector2 Position
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x24E152C", Offset = "0x24E152C", VA = "0x24E152C")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000035")]
		public Vector2 PreviousPosition
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x24E1534", Offset = "0x24E1534", VA = "0x24E1534")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000036")]
		public Vector2 DeltaPosition
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x24E153C", Offset = "0x24E153C", VA = "0x24E153C")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000037")]
		public float DistanceFromStart
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x24E1544", Offset = "0x24E1544", VA = "0x24E1544")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000038")]
		public bool IsFiltered
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x24E154C", Offset = "0x24E154C", VA = "0x24E154C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public float TimeStationary
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x24E1554", Offset = "0x24E1554", VA = "0x24E1554")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003A")]
		public List<GestureRecognizer> GestureRecognizers
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x24E155C", Offset = "0x24E155C", VA = "0x24E155C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public Dictionary<string, object> ExtendedProperties
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x24E1564", Offset = "0x24E1564", VA = "0x24E1564")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x24E156C", Offset = "0x24E156C", VA = "0x24E156C")]
		public Finger(int index)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x24E1670", Offset = "0x24E1670", VA = "0x24E1670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x24DFF14", Offset = "0x24DFF14", VA = "0x24DFF14")]
		public static implicit operator bool(Finger finger)
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x24E16D0", Offset = "0x24E16D0", VA = "0x24E16D0")]
		internal void Update(bool newDownState, Vector2 newPos)
		{
		}
	}

	[Token(Token = "0x200002C")]
	public delegate bool GlobalTouchFilterDelegate(int fingerIndex, Vector2 position);

	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA218C8", Offset = "0xA218C8")]
	public interface IFingerList : IEnumerable<Finger>, IEnumerable
	{
		[Token(Token = "0x1700003C")]
		Finger Item
		{
			[Token(Token = "0x6000114")]
			get;
		}

		[Token(Token = "0x1700003D")]
		int Count
		{
			[Token(Token = "0x6000115")]
			get;
		}

		[Token(Token = "0x6000116")]
		Vector2 GetAverageStartPosition();

		[Token(Token = "0x6000117")]
		Vector2 GetAveragePosition();

		[Token(Token = "0x6000118")]
		Vector2 GetAveragePreviousPosition();

		[Token(Token = "0x6000119")]
		float GetAverageDistanceFromStart();

		[Token(Token = "0x600011A")]
		Finger GetOldest();

		[Token(Token = "0x600011B")]
		bool AllMoving();

		[Token(Token = "0x600011C")]
		bool MovingInSameDirection(float tolerance);
	}

	[Serializable]
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xA21900", Offset = "0xA21900")]
	public class FingerList : IFingerList, IEnumerable<Finger>, IEnumerable
	{
		[Token(Token = "0x200002F")]
		public delegate T FingerPropertyGetterDelegate<T>(Finger finger);

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<Finger> list;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x0")]
		private static FingerPropertyGetterDelegate<Vector2> delGetFingerStartPosition;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x8")]
		private static FingerPropertyGetterDelegate<Vector2> delGetFingerPosition;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x10")]
		private static FingerPropertyGetterDelegate<Vector2> delGetFingerPreviousPosition;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x18")]
		private static FingerPropertyGetterDelegate<float> delGetFingerDistanceFromStart;

		[Token(Token = "0x1700003E")]
		public Finger Item
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x24E1900", Offset = "0x24E1900", VA = "0x24E1900", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public int Count
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x24E1974", Offset = "0x24E1974", VA = "0x24E1974", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x24E11DC", Offset = "0x24E11DC", VA = "0x24E11DC")]
		public FingerList()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x24E18D4", Offset = "0x24E18D4", VA = "0x24E18D4")]
		public FingerList(List<Finger> list)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x24E19C0", Offset = "0x24E19C0", VA = "0x24E19C0", Slot = "13")]
		public IEnumerator<Finger> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x24E1A54", Offset = "0x24E1A54", VA = "0x24E1A54", Slot = "14")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x24E1A58", Offset = "0x24E1A58", VA = "0x24E1A58")]
		public void Add(Finger touch)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x24E1ABC", Offset = "0x24E1ABC", VA = "0x24E1ABC")]
		public bool Remove(Finger touch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x24E1B20", Offset = "0x24E1B20", VA = "0x24E1B20")]
		public bool Contains(Finger touch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x24E1B84", Offset = "0x24E1B84", VA = "0x24E1B84")]
		public void AddRange(IEnumerable<Finger> touches)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x24E1128", Offset = "0x24E1128", VA = "0x24E1128")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x24E1BE8", Offset = "0x24E1BE8", VA = "0x24E1BE8")]
		public Vector2 AverageVector(FingerPropertyGetterDelegate<Vector2> getProperty)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x24E1CFC", Offset = "0x24E1CFC", VA = "0x24E1CFC")]
		public float AverageFloat(FingerPropertyGetterDelegate<float> getProperty)
		{
			return default(float);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x24E1DFC", Offset = "0x24E1DFC", VA = "0x24E1DFC")]
		private static Vector2 GetFingerStartPosition(Finger finger)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x24E1E14", Offset = "0x24E1E14", VA = "0x24E1E14")]
		private static Vector2 GetFingerPosition(Finger finger)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x24E1E2C", Offset = "0x24E1E2C", VA = "0x24E1E2C")]
		private static Vector2 GetFingerPreviousPosition(Finger finger)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x24E1E44", Offset = "0x24E1E44", VA = "0x24E1E44")]
		private static float GetFingerDistanceFromStart(Finger finger)
		{
			return default(float);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x24E1E5C", Offset = "0x24E1E5C", VA = "0x24E1E5C", Slot = "6")]
		public Vector2 GetAverageStartPosition()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x24E1EC8", Offset = "0x24E1EC8", VA = "0x24E1EC8", Slot = "7")]
		public Vector2 GetAveragePosition()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x24E1F34", Offset = "0x24E1F34", VA = "0x24E1F34", Slot = "8")]
		public Vector2 GetAveragePreviousPosition()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x24E1FA0", Offset = "0x24E1FA0", VA = "0x24E1FA0", Slot = "9")]
		public float GetAverageDistanceFromStart()
		{
			return default(float);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x24E200C", Offset = "0x24E200C", VA = "0x24E200C", Slot = "10")]
		public Finger GetOldest()
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x24E2138", Offset = "0x24E2138", VA = "0x24E2138", Slot = "12")]
		public bool MovingInSameDirection(float tolerance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x24E2258", Offset = "0x24E2258", VA = "0x24E2258", Slot = "11")]
		public bool AllMoving()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000030")]
	[Flags]
	public enum SwipeDirection
	{
		[Token(Token = "0x40000AD")]
		Right = 1,
		[Token(Token = "0x40000AE")]
		Left = 2,
		[Token(Token = "0x40000AF")]
		Up = 4,
		[Token(Token = "0x40000B0")]
		Down = 8,
		[Token(Token = "0x40000B1")]
		UpperLeftDiagonal = 0x10,
		[Token(Token = "0x40000B2")]
		UpperRightDiagonal = 0x20,
		[Token(Token = "0x40000B3")]
		LowerRightDiagonal = 0x40,
		[Token(Token = "0x40000B4")]
		LowerLeftDiagonal = 0x80,
		[Token(Token = "0x40000B5")]
		None = 0,
		[Token(Token = "0x40000B6")]
		Vertical = 0xC,
		[Token(Token = "0x40000B7")]
		Horizontal = 3,
		[Token(Token = "0x40000B8")]
		Cross = 0xF,
		[Token(Token = "0x40000B9")]
		UpperDiagonals = 0x30,
		[Token(Token = "0x40000BA")]
		LowerDiagonals = 0xC0,
		[Token(Token = "0x40000BB")]
		Diagonals = 0xF0,
		[Token(Token = "0x40000BC")]
		All = 0xFF
	}

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x0")]
	public static readonly RuntimePlatform[] TouchScreenPlatforms;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x18")]
	public bool makePersistent;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x19")]
	public bool detectUnityRemote;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x20")]
	public FGInputProvider mouseInputProviderPrefab;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x28")]
	public FGInputProvider touchInputProviderPrefab;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x30")]
	private FingerClusterManager fingerClusterManager;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x38")]
	private FGInputProvider inputProvider;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x20")]
	private static List<GestureRecognizer> gestureRecognizers;

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x28")]
	private static FingerGestures instance;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x40")]
	private Finger[] fingers;

	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x48")]
	private FingerList touches;

	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x50")]
	private GlobalTouchFilterDelegate globalTouchFilterFunc;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x58")]
	private Transform[] fingerNodes;

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x30")]
	private static readonly SwipeDirection[] AngleToDirectionMap;

	[Token(Token = "0x400008C")]
	private const float DESKTOP_SCREEN_STANDARD_DPI = 96f;

	[Token(Token = "0x400008D")]
	private const float INCHES_TO_CENTIMETERS = 2.54f;

	[Token(Token = "0x400008E")]
	private const float CENTIMETERS_TO_INCHES = 0.39370078f;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x38")]
	private static float screenDPI;

	[Token(Token = "0x17000020")]
	public static FingerClusterManager DefaultClusterManager
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1F11E80", Offset = "0x1F11E80", VA = "0x1F11E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000021")]
	public static FingerGestures Instance
	{
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1F11F28", Offset = "0x1F11F28", VA = "0x1F11F28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000022")]
	public FGInputProvider InputProvider
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1F12164", Offset = "0x1F12164", VA = "0x1F12164")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000023")]
	public int MaxFingers
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1F1071C", Offset = "0x1F1071C", VA = "0x1F1071C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000024")]
	public static IFingerList Touches
	{
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1F12674", Offset = "0x1F12674", VA = "0x1F12674")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000025")]
	public static List<GestureRecognizer> RegisteredGestureRecognizers
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1F126E4", Offset = "0x1F126E4", VA = "0x1F126E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000026")]
	public static GlobalTouchFilterDelegate GlobalTouchFilter
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1F12CF0", Offset = "0x1F12CF0", VA = "0x1F12CF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1F12D60", Offset = "0x1F12D60", VA = "0x1F12D60")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public static float ScreenDPI
	{
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1F13384", Offset = "0x1F13384", VA = "0x1F13384")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1F13480", Offset = "0x1F13480", VA = "0x1F13480")]
		set
		{
		}
	}

	[Token(Token = "0x14000008")]
	public static event Gesture.EventHandler OnGestureEvent
	{
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1F11804", Offset = "0x1F11804", VA = "0x1F11804")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24D68", Offset = "0xA24D68")]
		add
		{
		}
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1F118FC", Offset = "0x1F118FC", VA = "0x1F118FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24D78", Offset = "0xA24D78")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public static event FingerEventDetector<FingerEvent>.FingerEventHandler OnFingerEvent
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1F119F4", Offset = "0x1F119F4", VA = "0x1F119F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24D88", Offset = "0xA24D88")]
		add
		{
		}
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1F11AEC", Offset = "0x1F11AEC", VA = "0x1F11AEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24D98", Offset = "0xA24D98")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public static event EventHandler OnInputProviderChanged
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1F11BE4", Offset = "0x1F11BE4", VA = "0x1F11BE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24DA8", Offset = "0xA24DA8")]
		add
		{
		}
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1F11CDC", Offset = "0x1F11CDC", VA = "0x1F11CDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24DB8", Offset = "0xA24DB8")]
		remove
		{
		}
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1F11DD4", Offset = "0x1F11DD4", VA = "0x1F11DD4")]
	internal static void FireEvent(Gesture gesture)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1F11404", Offset = "0x1F11404", VA = "0x1F11404")]
	internal static void FireEvent(FingerEvent eventData)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1F11F8C", Offset = "0x1F11F8C", VA = "0x1F11F8C")]
	private void Init()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1F1216C", Offset = "0x1F1216C", VA = "0x1F1216C")]
	public static bool IsTouchScreenPlatform(RuntimePlatform platform)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1F1205C", Offset = "0x1F1205C", VA = "0x1F1205C")]
	private void InitInputProvider()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1F12250", Offset = "0x1F12250", VA = "0x1F12250")]
	public void InstallInputProvider(FGInputProvider inputProviderPrefab)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1F10684", Offset = "0x1F10684", VA = "0x1F10684")]
	public static Finger GetFinger(int index)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1F12748", Offset = "0x1F12748", VA = "0x1F12748")]
	public static void Register(GestureRecognizer recognizer)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1F1282C", Offset = "0x1F1282C", VA = "0x1F1282C")]
	public static void Unregister(GestureRecognizer recognizer)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1F128B8", Offset = "0x1F128B8", VA = "0x1F128B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1F12AF0", Offset = "0x1F12AF0", VA = "0x1F12AF0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1F12B7C", Offset = "0x1F12B7C", VA = "0x1F12B7C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1F128BC", Offset = "0x1F128BC", VA = "0x1F128BC")]
	private void CheckInit()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1F12B80", Offset = "0x1F12B80", VA = "0x1F12B80")]
	private void Update()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1F12524", Offset = "0x1F12524", VA = "0x1F12524")]
	private void InitFingers(int count)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1F12C00", Offset = "0x1F12C00", VA = "0x1F12C00")]
	private void UpdateFingers()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x1F12DD4", Offset = "0x1F12DD4", VA = "0x1F12DD4")]
	protected bool ShouldProcessTouch(int fingerIndex, Vector2 position)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1F12DEC", Offset = "0x1F12DEC", VA = "0x1F12DEC")]
	private Transform CreateNode(string name, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1F12E80", Offset = "0x1F12E80", VA = "0x1F12E80")]
	private void InitNodes()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1F1304C", Offset = "0x1F1304C", VA = "0x1F1304C")]
	public static SwipeDirection GetSwipeDirection(Vector2 dir, float tolerance)
	{
		return default(SwipeDirection);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1F13214", Offset = "0x1F13214", VA = "0x1F13214")]
	public static SwipeDirection GetSwipeDirection(Vector2 dir)
	{
		return default(SwipeDirection);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x1F13288", Offset = "0x1F13288", VA = "0x1F13288")]
	public static bool UsingUnityRemote()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1F13290", Offset = "0x1F13290", VA = "0x1F13290")]
	public static bool AllFingersMoving(Finger finger0, Finger finger1)
	{
		return default(bool);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1F132DC", Offset = "0x1F132DC", VA = "0x1F132DC")]
	public static bool FingersMovedInOppositeDirections(Finger finger0, Finger finger1, float minDOT)
	{
		return default(bool);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1F13368", Offset = "0x1F13368", VA = "0x1F13368")]
	public static float SignedAngle(Vector2 from, Vector2 to)
	{
		return default(float);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x1F131E0", Offset = "0x1F131E0", VA = "0x1F131E0")]
	public static float NormalizeAngle360(float angleInDegrees)
	{
		return default(float);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1F10AB0", Offset = "0x1F10AB0", VA = "0x1F10AB0")]
	public static float Convert(float distance, DistanceUnit fromUnit, DistanceUnit toUnit)
	{
		return default(float);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1F134F0", Offset = "0x1F134F0", VA = "0x1F134F0")]
	public static Vector2 Convert(Vector2 v, DistanceUnit fromUnit, DistanceUnit toUnit)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1F13594", Offset = "0x1F13594", VA = "0x1F13594")]
	public FingerGestures()
	{
	}
}
[Token(Token = "0x2000031")]
public enum DistanceUnit
{
	[Token(Token = "0x40000BE")]
	Pixels,
	[Token(Token = "0x40000BF")]
	Inches,
	[Token(Token = "0x40000C0")]
	Centimeters
}
[Token(Token = "0x2000032")]
public static class FingerGesturesExtensions
{
	[Token(Token = "0x600013A")]
	[Address(RVA = "0x1F136E4", Offset = "0x1F136E4", VA = "0x1F136E4")]
	public static string Abreviation(this DistanceUnit unit)
	{
		return null;
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x1F137D0", Offset = "0x1F137D0", VA = "0x1F137D0")]
	public static float Convert(this float value, DistanceUnit fromUnit, DistanceUnit toUnit)
	{
		return default(float);
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1F13850", Offset = "0x1F13850", VA = "0x1F13850")]
	public static float In(this float valueInPixels, DistanceUnit toUnit)
	{
		return default(float);
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x1F1385C", Offset = "0x1F1385C", VA = "0x1F1385C")]
	public static float Centimeters(this float valueInPixels)
	{
		return default(float);
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x1F13868", Offset = "0x1F13868", VA = "0x1F13868")]
	public static float Inches(this float valueInPixels)
	{
		return default(float);
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x1F13874", Offset = "0x1F13874", VA = "0x1F13874")]
	public static Vector2 Convert(this Vector2 v, DistanceUnit fromUnit, DistanceUnit toUnit)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x1F138FC", Offset = "0x1F138FC", VA = "0x1F138FC")]
	public static Vector2 In(this Vector2 vecInPixels, DistanceUnit toUnit)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x1F13908", Offset = "0x1F13908", VA = "0x1F13908")]
	public static Vector2 Centimeters(this Vector2 vecInPixels)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x1F13914", Offset = "0x1F13914", VA = "0x1F13914")]
	public static Vector2 Inches(this Vector2 vecInPixels)
	{
		return default(Vector2);
	}
}
[Token(Token = "0x2000033")]
public class DragGesture : ContinuousGesture
{
	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0xB4")]
	private Vector2 deltaMove;

	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0xBC")]
	internal Vector2 LastPos;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0xC4")]
	internal Vector2 LastDelta;

	[Token(Token = "0x17000040")]
	public Vector2 DeltaMove
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2326454", Offset = "0x2326454", VA = "0x2326454")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x232645C", Offset = "0x232645C", VA = "0x232645C")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000041")]
	public Vector2 TotalMove
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2326464", Offset = "0x2326464", VA = "0x2326464")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x2326478", Offset = "0x2326478", VA = "0x2326478")]
	public DragGesture()
	{
	}
}
[Token(Token = "0x2000034")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21958", Offset = "0xA21958")]
public class DragRecognizer : ContinuousGestureRecognizer<DragGesture>
{
	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x70")]
	public float MoveTolerance;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x74")]
	public bool ApplySameDirectionConstraint;

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x23264C0", Offset = "0x23264C0", VA = "0x23264C0", Slot = "8")]
	public override string GetDefaultEventMessageName()
	{
		return null;
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x2326504", Offset = "0x2326504", VA = "0x2326504", Slot = "17")]
	protected override GameObject GetDefaultSelectionForSendMessage(DragGesture gesture)
	{
		return null;
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x232651C", Offset = "0x232651C", VA = "0x232651C", Slot = "14")]
	protected override bool CanBegin(DragGesture gesture, FingerGestures.IFingerList touches)
	{
		return default(bool);
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x2326734", Offset = "0x2326734", VA = "0x2326734", Slot = "15")]
	protected override void OnBegin(DragGesture gesture, FingerGestures.IFingerList touches)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x2326884", Offset = "0x2326884", VA = "0x2326884", Slot = "16")]
	protected override GestureRecognitionState OnRecognize(DragGesture gesture, FingerGestures.IFingerList touches)
	{
		return default(GestureRecognitionState);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x2326BD4", Offset = "0x2326BD4", VA = "0x2326BD4")]
	public DragRecognizer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000035")]
public class LongPressGesture : DiscreteGesture
{
	[Token(Token = "0x600014D")]
	[Address(RVA = "0x1F182EC", Offset = "0x1F182EC", VA = "0x1F182EC")]
	public LongPressGesture()
	{
	}
}
[Token(Token = "0x2000036")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21990", Offset = "0xA21990")]
public class LongPressRecognizer : DiscreteGestureRecognizer<LongPressGesture>
{
	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x70")]
	public float Duration;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x74")]
	public float MoveTolerance;

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1F182F4", Offset = "0x1F182F4", VA = "0x1F182F4", Slot = "8")]
	public override string GetDefaultEventMessageName()
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x1F18338", Offset = "0x1F18338", VA = "0x1F18338", Slot = "15")]
	protected override void OnBegin(LongPressGesture gesture, FingerGestures.IFingerList touches)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x1F18400", Offset = "0x1F18400", VA = "0x1F18400", Slot = "16")]
	protected override GestureRecognitionState OnRecognize(LongPressGesture gesture, FingerGestures.IFingerList touches)
	{
		return default(GestureRecognitionState);
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x1F185A8", Offset = "0x1F185A8", VA = "0x1F185A8")]
	public LongPressRecognizer()
	{
	}
}
[Token(Token = "0x2000037")]
public class PinchGesture : ContinuousGesture
{
	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0xB4")]
	private float delta;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0xB8")]
	private float gap;

	[Token(Token = "0x17000042")]
	public float Delta
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1F1AAF8", Offset = "0x1F1AAF8", VA = "0x1F1AAF8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1F1AB00", Offset = "0x1F1AB00", VA = "0x1F1AB00")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public float Gap
	{
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1F1AB08", Offset = "0x1F1AB08", VA = "0x1F1AB08")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1F1AB10", Offset = "0x1F1AB10", VA = "0x1F1AB10")]
		internal set
		{
		}
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1F1AB18", Offset = "0x1F1AB18", VA = "0x1F1AB18")]
	public PinchGesture()
	{
	}
}
[Token(Token = "0x2000038")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA219C8", Offset = "0xA219C8")]
public class PinchRecognizer : ContinuousGestureRecognizer<PinchGesture>
{
	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x70")]
	public float MinDOT;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x74")]
	public float MinDistance;

	[Token(Token = "0x17000044")]
	public override int RequiredFingerCount
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1F1AB64", Offset = "0x1F1AB64", VA = "0x1F1AB64", Slot = "4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1F1AB6C", Offset = "0x1F1AB6C", VA = "0x1F1AB6C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public override bool SupportFingerClustering
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1F1ABF8", Offset = "0x1F1ABF8", VA = "0x1F1ABF8", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1F1AB20", Offset = "0x1F1AB20", VA = "0x1F1AB20", Slot = "8")]
	public override string GetDefaultEventMessageName()
	{
		return null;
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1F1AC00", Offset = "0x1F1AC00", VA = "0x1F1AC00", Slot = "17")]
	protected override GameObject GetDefaultSelectionForSendMessage(PinchGesture gesture)
	{
		return null;
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1F1AC18", Offset = "0x1F1AC18", VA = "0x1F1AC18", Slot = "7")]
	public override GestureResetMode GetDefaultResetMode()
	{
		return default(GestureResetMode);
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1F1AC20", Offset = "0x1F1AC20", VA = "0x1F1AC20", Slot = "14")]
	protected override bool CanBegin(PinchGesture gesture, FingerGestures.IFingerList touches)
	{
		return default(bool);
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1F1ADE8", Offset = "0x1F1ADE8", VA = "0x1F1ADE8", Slot = "15")]
	protected override void OnBegin(PinchGesture gesture, FingerGestures.IFingerList touches)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1F1AF80", Offset = "0x1F1AF80", VA = "0x1F1AF80", Slot = "16")]
	protected override GestureRecognitionState OnRecognize(PinchGesture gesture, FingerGestures.IFingerList touches)
	{
		return default(GestureRecognitionState);
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x1F1B240", Offset = "0x1F1B240", VA = "0x1F1B240")]
	private bool FingersMovedInOppositeDirections(FingerGestures.Finger finger0, FingerGestures.Finger finger1)
	{
		return default(bool);
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x1F1B2C4", Offset = "0x1F1B2C4", VA = "0x1F1B2C4")]
	public PinchRecognizer()
	{
	}
}
[Token(Token = "0x2000039")]
public class PointCloudGestureTemplate : ScriptableObject
{
	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<int> strokeIds;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Vector2> positions;

	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int strokeCount;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Vector2 size;

	[Token(Token = "0x17000046")]
	public Vector2 Size
	{
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1F1B3BC", Offset = "0x1F1B3BC", VA = "0x1F1B3BC")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000047")]
	public float Width
	{
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1F1B3C4", Offset = "0x1F1B3C4", VA = "0x1F1B3C4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000048")]
	public float Height
	{
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1F1B3CC", Offset = "0x1F1B3CC", VA = "0x1F1B3CC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000049")]
	public int PointCount
	{
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1F1B9E0", Offset = "0x1F1B9E0", VA = "0x1F1B9E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700004A")]
	public int StrokeCount
	{
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1F1BA2C", Offset = "0x1F1BA2C", VA = "0x1F1BA2C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1F1B3D4", Offset = "0x1F1B3D4", VA = "0x1F1B3D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1F1B494", Offset = "0x1F1B494", VA = "0x1F1B494")]
	public void BeginPoints()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x1F1B520", Offset = "0x1F1B520", VA = "0x1F1B520")]
	public void AddPoint(int stroke, Vector2 p)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1F1B5C0", Offset = "0x1F1B5C0", VA = "0x1F1B5C0")]
	public void AddPoint(int stroke, float x, float y)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1F1B5C4", Offset = "0x1F1B5C4", VA = "0x1F1B5C4")]
	public void EndPoints()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1F1B8F8", Offset = "0x1F1B8F8", VA = "0x1F1B8F8")]
	public Vector2 GetPosition(int pointIndex)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1F1B96C", Offset = "0x1F1B96C", VA = "0x1F1B96C")]
	public int GetStrokeId(int pointIndex)
	{
		return default(int);
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1F1B708", Offset = "0x1F1B708", VA = "0x1F1B708")]
	public void Normalize()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1F1B8F4", Offset = "0x1F1B8F4", VA = "0x1F1B8F4")]
	private void MakeDirty()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1F1BA34", Offset = "0x1F1BA34", VA = "0x1F1BA34")]
	public PointCloudGestureTemplate()
	{
	}
}
[Token(Token = "0x200003A")]
public class PointCloudGesture : DiscreteGesture
{
	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0xB8")]
	public List<PointCloudRegognizer.Point> RawPoints;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0xC0")]
	public List<PointCloudRegognizer.Point> NormalizedPoints;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0xC8")]
	public PointCloudGestureTemplate RecognizedTemplate;

	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0xD0")]
	public float MatchDistance;

	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0xD4")]
	public float MatchScore;

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1F1B31C", Offset = "0x1F1B31C", VA = "0x1F1B31C")]
	public PointCloudGesture()
	{
	}
}
[Token(Token = "0x200003B")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21A00", Offset = "0xA21A00")]
public class PointCloudRegognizer : DiscreteGestureRecognizer<PointCloudGesture>
{
	[Serializable]
	[Token(Token = "0x200003C")]
	public struct Point
	{
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x0")]
		public int StrokeId;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x4")]
		public Vector2 Position;

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x24E3628", Offset = "0x24E3628", VA = "0x24E3628")]
		public Point(int strokeId, Vector2 pos)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x24E3634", Offset = "0x24E3634", VA = "0x24E3634")]
		public Point(int strokeId, float x, float y)
		{
		}
	}

	[Token(Token = "0x200003D")]
	private class NormalizedTemplate
	{
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x10")]
		public PointCloudGestureTemplate Source;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x18")]
		public List<Point> Points;

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x24E3620", Offset = "0x24E3620", VA = "0x24E3620")]
		public NormalizedTemplate()
		{
		}
	}

	[Token(Token = "0x200003E")]
	private class GestureNormalizer
	{
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x10")]
		private List<Point> normalizedPoints;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x18")]
		private List<Point> pointBuffer;

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x24E2D74", Offset = "0x24E2D74", VA = "0x24E2D74")]
		public GestureNormalizer()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x24E2E10", Offset = "0x24E2E10", VA = "0x24E2E10")]
		public List<Point> Apply(List<Point> inputPoints, int normalizedPointsCount)
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x24E2E44", Offset = "0x24E2E44", VA = "0x24E2E44")]
		private List<Point> Resample(List<Point> points, int normalizedPointsCount)
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x24E3400", Offset = "0x24E3400", VA = "0x24E3400")]
		private static float PathLength(List<Point> points)
		{
			return default(float);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x24E3130", Offset = "0x24E3130", VA = "0x24E3130")]
		private static void Scale(List<Point> points)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x24E3308", Offset = "0x24E3308", VA = "0x24E3308")]
		private static void TranslateToOrigin(List<Point> points)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x24E3558", Offset = "0x24E3558", VA = "0x24E3558")]
		private static Vector2 Centroid(List<Point> points)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA21A38", Offset = "0xA21A38")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x10")]
		public PointCloudGestureTemplate template;

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x24E2CE8", Offset = "0x24E2CE8", VA = "0x24E2CE8")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x24E2CF0", Offset = "0x24E2CF0", VA = "0x24E2CF0")]
		internal bool <FindNormalizedTemplate>b__0(NormalizedTemplate t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x70")]
	public float MinDistanceBetweenSamples;

	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x74")]
	public float MaxMatchDistance;

	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x78")]
	public List<PointCloudGestureTemplate> Templates;

	[Token(Token = "0x40000D8")]
	private const int NormalizedPointCount = 32;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x80")]
	private GestureNormalizer normalizer;

	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x88")]
	private List<NormalizedTemplate> normalizedTemplates;

	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x0")]
	private static bool[] matched;

	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x90")]
	private PointCloudGesture debugLastGesture;

	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x98")]
	private NormalizedTemplate debugLastMatchedTemplate;

	[Token(Token = "0x40000DE")]
	private const float gizmoSphereRadius = 0.01f;

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x1F1BA64", Offset = "0x1F1BA64", VA = "0x1F1BA64", Slot = "10")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x1F1BE10", Offset = "0x1F1BE10", VA = "0x1F1BE10")]
	private NormalizedTemplate FindNormalizedTemplate(PointCloudGestureTemplate template)
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1F1BF00", Offset = "0x1F1BF00", VA = "0x1F1BF00")]
	private List<Point> Normalize(List<Point> points)
	{
		return null;
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1F1BBE4", Offset = "0x1F1BBE4", VA = "0x1F1BBE4")]
	public bool AddTemplate(PointCloudGestureTemplate template)
	{
		return default(bool);
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x1F1BFA4", Offset = "0x1F1BFA4", VA = "0x1F1BFA4", Slot = "15")]
	protected override void OnBegin(PointCloudGesture gesture, FingerGestures.IFingerList touches)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1F1C148", Offset = "0x1F1C148", VA = "0x1F1C148")]
	private bool RecognizePointCloud(PointCloudGesture gesture)
	{
		return default(bool);
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1F1C334", Offset = "0x1F1C334", VA = "0x1F1C334")]
	private float GreedyCloudMatch(List<Point> points, List<Point> refPoints)
	{
		return default(float);
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1F1C4B0", Offset = "0x1F1C4B0", VA = "0x1F1C4B0")]
	private static float CloudDistance(List<Point> points1, List<Point> points2, int startIndex)
	{
		return default(float);
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1F1C6E8", Offset = "0x1F1C6E8", VA = "0x1F1C6E8")]
	private static void ResetMatched(int count)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1F1C824", Offset = "0x1F1C824", VA = "0x1F1C824", Slot = "16")]
	protected override GestureRecognitionState OnRecognize(PointCloudGesture gesture, FingerGestures.IFingerList touches)
	{
		return default(GestureRecognitionState);
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1F1CACC", Offset = "0x1F1CACC", VA = "0x1F1CACC", Slot = "8")]
	public override string GetDefaultEventMessageName()
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1F1CB10", Offset = "0x1F1CB10", VA = "0x1F1CB10")]
	public void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1F1CB90", Offset = "0x1F1CB90", VA = "0x1F1CB90")]
	private void DrawNormalizedPointCloud(List<Point> points, float scale)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1F1CD00", Offset = "0x1F1CD00", VA = "0x1F1CD00")]
	public PointCloudRegognizer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000040")]
public class SwipeGesture : DiscreteGesture
{
	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0xB4")]
	private Vector2 move;

	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0xBC")]
	private float velocity;

	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0xC0")]
	private FingerGestures.SwipeDirection direction;

	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0xC4")]
	internal int MoveCounter;

	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0xC8")]
	internal float Deviation;

	[Token(Token = "0x1700004B")]
	public Vector2 Move
	{
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1F2082C", Offset = "0x1F2082C", VA = "0x1F2082C")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1F20834", Offset = "0x1F20834", VA = "0x1F20834")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700004C")]
	public float Velocity
	{
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1F2083C", Offset = "0x1F2083C", VA = "0x1F2083C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1F20844", Offset = "0x1F20844", VA = "0x1F20844")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	public FingerGestures.SwipeDirection Direction
	{
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1F2084C", Offset = "0x1F2084C", VA = "0x1F2084C")]
		get
		{
			return default(FingerGestures.SwipeDirection);
		}
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1F20854", Offset = "0x1F20854", VA = "0x1F20854")]
		internal set
		{
		}
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1F2085C", Offset = "0x1F2085C", VA = "0x1F2085C")]
	public SwipeGesture()
	{
	}
}
[Token(Token = "0x2000041")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21A48", Offset = "0xA21A48")]
public class SwipeRecognizer : DiscreteGestureRecognizer<SwipeGesture>
{
	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x70")]
	private FingerGestures.SwipeDirection ValidDirections;

	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x74")]
	public float MinDistance;

	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x78")]
	public float MaxDistance;

	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x7C")]
	public float MinVelocity;

	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x80")]
	public float MaxDeviation;

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x1F2088C", Offset = "0x1F2088C", VA = "0x1F2088C", Slot = "8")]
	public override string GetDefaultEventMessageName()
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1F208D0", Offset = "0x1F208D0", VA = "0x1F208D0", Slot = "14")]
	protected override bool CanBegin(SwipeGesture gesture, FingerGestures.IFingerList touches)
	{
		return default(bool);
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1F20AAC", Offset = "0x1F20AAC", VA = "0x1F20AAC", Slot = "15")]
	protected override void OnBegin(SwipeGesture gesture, FingerGestures.IFingerList touches)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x1F20BEC", Offset = "0x1F20BEC", VA = "0x1F20BEC", Slot = "16")]
	protected override GestureRecognitionState OnRecognize(SwipeGesture gesture, FingerGestures.IFingerList touches)
	{
		return default(GestureRecognitionState);
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1F20FB4", Offset = "0x1F20FB4", VA = "0x1F20FB4")]
	public bool IsValidDirection(FingerGestures.SwipeDirection dir)
	{
		return default(bool);
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x1F20FD0", Offset = "0x1F20FD0", VA = "0x1F20FD0")]
	public SwipeRecognizer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000042")]
public class TapGesture : DiscreteGesture
{
	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0xB4")]
	private int taps;

	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0xB8")]
	internal bool Down;

	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0xB9")]
	internal bool WasDown;

	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0xBC")]
	internal float LastDownTime;

	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0xC0")]
	internal float LastTapTime;

	[Token(Token = "0x1700004E")]
	public int Taps
	{
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x24DD6B4", Offset = "0x24DD6B4", VA = "0x24DD6B4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x24DD6BC", Offset = "0x24DD6BC", VA = "0x24DD6BC")]
		internal set
		{
		}
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x24DD6C4", Offset = "0x24DD6C4", VA = "0x24DD6C4")]
	public TapGesture()
	{
	}
}
[Token(Token = "0x2000043")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21A80", Offset = "0xA21A80")]
public class TapRecognizer : DiscreteGestureRecognizer<TapGesture>
{
	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x70")]
	public int RequiredTaps;

	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x74")]
	public float MoveTolerance;

	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x78")]
	public float MaxDuration;

	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x7C")]
	public float MaxDelayBetweenTaps;

	[Token(Token = "0x1700004F")]
	private bool IsMultiTap
	{
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x24DD6CC", Offset = "0x24DD6CC", VA = "0x24DD6CC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000050")]
	public override bool SupportFingerClustering
	{
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x24DD7D8", Offset = "0x24DD7D8", VA = "0x24DD7D8", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x24DD6DC", Offset = "0x24DD6DC", VA = "0x24DD6DC")]
	private bool HasTimedOut(TapGesture gesture)
	{
		return default(bool);
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x24DD76C", Offset = "0x24DD76C", VA = "0x24DD76C", Slot = "23")]
	protected override void Reset(TapGesture gesture)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x24DD7F4", Offset = "0x24DD7F4", VA = "0x24DD7F4")]
	private GestureRecognitionState RecognizeSingleTap(TapGesture gesture, FingerGestures.IFingerList touches)
	{
		return default(GestureRecognitionState);
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x24DDA18", Offset = "0x24DDA18", VA = "0x24DDA18")]
	private GestureRecognitionState RecognizeMultiTap(TapGesture gesture, FingerGestures.IFingerList touches)
	{
		return default(GestureRecognitionState);
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x24DDD5C", Offset = "0x24DDD5C", VA = "0x24DDD5C", Slot = "8")]
	public override string GetDefaultEventMessageName()
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x24DDDA0", Offset = "0x24DDDA0", VA = "0x24DDDA0", Slot = "15")]
	protected override void OnBegin(TapGesture gesture, FingerGestures.IFingerList touches)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x24DDE74", Offset = "0x24DDE74", VA = "0x24DDE74", Slot = "16")]
	protected override GestureRecognitionState OnRecognize(TapGesture gesture, FingerGestures.IFingerList touches)
	{
		return default(GestureRecognitionState);
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x24DDE88", Offset = "0x24DDE88", VA = "0x24DDE88")]
	public TapRecognizer()
	{
	}
}
[Token(Token = "0x2000044")]
public class TwistGesture : ContinuousGesture
{
	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0xB4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23270", Offset = "0xA23270")]
	private float <DeltaRotation>k__BackingField;

	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23280", Offset = "0xA23280")]
	private float <TotalRotation>k__BackingField;

	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23290", Offset = "0xA23290")]
	private FingerGestures.Finger <Pivot>k__BackingField;

	[Token(Token = "0x17000051")]
	public float DeltaRotation
	{
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x24DFAEC", Offset = "0x24DFAEC", VA = "0x24DFAEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24E58", Offset = "0xA24E58")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x24DFAF4", Offset = "0x24DFAF4", VA = "0x24DFAF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24E68", Offset = "0xA24E68")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public float TotalRotation
	{
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x24DFAFC", Offset = "0x24DFAFC", VA = "0x24DFAFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24E78", Offset = "0xA24E78")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x24DFB04", Offset = "0x24DFB04", VA = "0x24DFB04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24E88", Offset = "0xA24E88")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000053")]
	public FingerGestures.Finger Pivot
	{
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x24DFB0C", Offset = "0x24DFB0C", VA = "0x24DFB0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24E98", Offset = "0xA24E98")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x24DFB14", Offset = "0x24DFB14", VA = "0x24DFB14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24EA8", Offset = "0xA24EA8")]
		internal set
		{
		}
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x24DFB1C", Offset = "0x24DFB1C", VA = "0x24DFB1C")]
	public TwistGesture()
	{
	}
}
[Token(Token = "0x2000045")]
public enum TwistMethod
{
	[Token(Token = "0x40000FD")]
	Standard,
	[Token(Token = "0x40000FE")]
	Pivot
}
[Token(Token = "0x2000046")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21AB8", Offset = "0xA21AB8")]
public class TwistRecognizer : ContinuousGestureRecognizer<TwistGesture>
{
	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x70")]
	public TwistMethod Method;

	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x74")]
	public float MinDOT;

	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x78")]
	public float MinRotation;

	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x7C")]
	public float PivotMoveTolerance;

	[Token(Token = "0x17000054")]
	public override int RequiredFingerCount
	{
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x24DFB68", Offset = "0x24DFB68", VA = "0x24DFB68", Slot = "4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x24DFB70", Offset = "0x24DFB70", VA = "0x24DFB70", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	public override bool SupportFingerClustering
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x24DFBFC", Offset = "0x24DFBFC", VA = "0x24DFBFC", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x24DFB24", Offset = "0x24DFB24", VA = "0x24DFB24", Slot = "8")]
	public override string GetDefaultEventMessageName()
	{
		return null;
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x24DFC04", Offset = "0x24DFC04", VA = "0x24DFC04", Slot = "7")]
	public override GestureResetMode GetDefaultResetMode()
	{
		return default(GestureResetMode);
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x24DFC0C", Offset = "0x24DFC0C", VA = "0x24DFC0C", Slot = "17")]
	protected override GameObject GetDefaultSelectionForSendMessage(TwistGesture gesture)
	{
		return null;
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x24DFC24", Offset = "0x24DFC24", VA = "0x24DFC24", Slot = "23")]
	protected override void Reset(TwistGesture gesture)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x24DFC90", Offset = "0x24DFC90", VA = "0x24DFC90")]
	private FingerGestures.Finger GetTwistPivot(FingerGestures.Finger finger0, FingerGestures.Finger finger1)
	{
		return null;
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x24DFD14", Offset = "0x24DFD14", VA = "0x24DFD14", Slot = "14")]
	protected override bool CanBegin(TwistGesture gesture, FingerGestures.IFingerList touches)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x24E00B0", Offset = "0x24E00B0", VA = "0x24E00B0", Slot = "15")]
	protected override void OnBegin(TwistGesture gesture, FingerGestures.IFingerList touches)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x24E0238", Offset = "0x24E0238", VA = "0x24E0238", Slot = "16")]
	protected override GestureRecognitionState OnRecognize(TwistGesture gesture, FingerGestures.IFingerList touches)
	{
		return default(GestureRecognitionState);
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x24DFF20", Offset = "0x24DFF20", VA = "0x24DFF20")]
	private bool FingersMovedInOppositeDirections(FingerGestures.Finger finger0, FingerGestures.Finger finger1)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x24DFFA8", Offset = "0x24DFFA8", VA = "0x24DFFA8")]
	private static float SignedAngularGap(FingerGestures.Finger finger0, FingerGestures.Finger finger1, Vector2 refPos0, Vector2 refPos1)
	{
		return default(float);
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x24E05E0", Offset = "0x24E05E0", VA = "0x24E05E0")]
	public TwistRecognizer()
	{
	}
}
[Token(Token = "0x2000047")]
public abstract class FGInputProvider : MonoBehaviour
{
	[Token(Token = "0x17000056")]
	public abstract int MaxSimultaneousFingers
	{
		[Token(Token = "0x60001BC")]
		get;
	}

	[Token(Token = "0x60001BD")]
	public abstract void GetInputState(int fingerIndex, out bool down, out Vector2 position);

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x232859C", Offset = "0x232859C", VA = "0x232859C")]
	protected FGInputProvider()
	{
	}
}
[Token(Token = "0x2000048")]
public class FGMouseInputProvider : FGInputProvider
{
	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x18")]
	public int maxButtons;

	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x20")]
	public string pinchAxis;

	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x28")]
	public float pinchAxisScale;

	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x2C")]
	public float pinchResetTimeDelay;

	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x30")]
	public float initialPinchDistance;

	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x38")]
	public string twistAxis;

	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x40")]
	public float twistAxisScale;

	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x44")]
	public KeyCode twistKey;

	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x48")]
	public float twistResetTimeDelay;

	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x4C")]
	public KeyCode pivotKey;

	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x50")]
	private bool pivoting;

	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x54")]
	public KeyCode twistAndPinchKey;

	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x58")]
	private Vector2 pivot;

	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x60")]
	private Vector2[] pos;

	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x68")]
	private bool pinching;

	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x6C")]
	private float pinchResetTime;

	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x70")]
	private float pinchDistance;

	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x74")]
	private bool twisting;

	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x78")]
	private float twistAngle;

	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x7C")]
	private float twistResetTime;

	[Token(Token = "0x17000057")]
	public override int MaxSimultaneousFingers
	{
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2328964", Offset = "0x2328964", VA = "0x2328964", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x23285A4", Offset = "0x23285A4", VA = "0x23285A4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x23285B0", Offset = "0x23285B0", VA = "0x23285B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x2328800", Offset = "0x2328800", VA = "0x2328800")]
	private void UpdatePinchEmulation()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x23288B4", Offset = "0x23288B4", VA = "0x23288B4")]
	private void UpdateTwistEmulation()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x232896C", Offset = "0x232896C", VA = "0x232896C", Slot = "5")]
	public override void GetInputState(int fingerIndex, out bool down, out Vector2 position)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x2328A20", Offset = "0x2328A20", VA = "0x2328A20")]
	public FGMouseInputProvider()
	{
	}
}
[Token(Token = "0x2000049")]
public class FGTouchInputProvider : FGInputProvider
{
	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x18")]
	public int maxTouches;

	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x1C")]
	public bool fixAndroidTouchIdBug;

	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x20")]
	private int touchIdOffset;

	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0x24")]
	private Touch nullTouch;

	[Token(Token = "0x400011B")]
	[FieldOffset(Offset = "0x68")]
	private int[] finger2touchMap;

	[Token(Token = "0x17000058")]
	public override int MaxSimultaneousFingers
	{
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2328D94", Offset = "0x2328D94", VA = "0x2328D94", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x2328B28", Offset = "0x2328B28", VA = "0x2328B28")]
	private void Start()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x2328B7C", Offset = "0x2328B7C", VA = "0x2328B7C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x2328B80", Offset = "0x2328B80", VA = "0x2328B80")]
	private void UpdateFingerTouchMap()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x2328CCC", Offset = "0x2328CCC", VA = "0x2328CCC")]
	private bool HasValidTouch(int fingerIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x2328D10", Offset = "0x2328D10", VA = "0x2328D10")]
	private Touch GetTouch(int fingerIndex)
	{
		return default(Touch);
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x2328D9C", Offset = "0x2328D9C", VA = "0x2328D9C", Slot = "5")]
	public override void GetInputState(int fingerIndex, out bool down, out Vector2 position)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x2328E5C", Offset = "0x2328E5C", VA = "0x2328E5C")]
	public FGTouchInputProvider()
	{
	}
}
[Token(Token = "0x200004A")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xA21AF0", Offset = "0xA21AF0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21AF0", Offset = "0xA21AF0")]
public class TBDragView : MonoBehaviour
{
	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0x18")]
	public bool allowUserInput;

	[Token(Token = "0x400011D")]
	[FieldOffset(Offset = "0x1C")]
	public float sensitivity;

	[Token(Token = "0x400011E")]
	[FieldOffset(Offset = "0x20")]
	public float dragAcceleration;

	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x24")]
	public float dragDeceleration;

	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x28")]
	public bool reverseControls;

	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x2C")]
	public float minPitchAngle;

	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x30")]
	public float maxPitchAngle;

	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x34")]
	public float idealRotationSmoothingSpeed;

	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x38")]
	private Transform cachedTransform;

	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 angularVelocity;

	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x48")]
	private Quaternion idealRotation;

	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x58")]
	private bool useAngularVelocity;

	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x60")]
	private DragGesture dragGesture;

	[Token(Token = "0x17000059")]
	public bool Dragging
	{
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1F21A44", Offset = "0x1F21A44", VA = "0x1F21A44")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700005A")]
	public Quaternion IdealRotation
	{
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1F21CE8", Offset = "0x1F21CE8", VA = "0x1F21CE8")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1F21A34", Offset = "0x1F21A34", VA = "0x1F21A34")]
		set
		{
		}
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x1F218B4", Offset = "0x1F218B4", VA = "0x1F218B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x1F218DC", Offset = "0x1F218DC", VA = "0x1F218DC")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x1F21A54", Offset = "0x1F21A54", VA = "0x1F21A54")]
	private void OnDrag(DragGesture gesture)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x1F21A94", Offset = "0x1F21A94", VA = "0x1F21A94")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x1F21CC8", Offset = "0x1F21CC8", VA = "0x1F21CC8")]
	private static float NormalizePitch(float angle)
	{
		return default(float);
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x1F21CF4", Offset = "0x1F21CF4", VA = "0x1F21CF4")]
	public void LookAt(Vector3 pos)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x1F21D60", Offset = "0x1F21D60", VA = "0x1F21D60")]
	public TBDragView()
	{
	}
}
[Token(Token = "0x200004B")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xA21B74", Offset = "0xA21B74")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21B74", Offset = "0xA21B74")]
public class TBLookAtTap : MonoBehaviour
{
	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x18")]
	private TBDragView dragView;

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x1F21F90", Offset = "0x1F21F90", VA = "0x1F21F90")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x1F21FE4", Offset = "0x1F21FE4", VA = "0x1F21FE4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1F2211C", Offset = "0x1F2211C", VA = "0x1F2211C")]
	private void OnTap(TapGesture gesture)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x1F22248", Offset = "0x1F22248", VA = "0x1F22248")]
	public TBLookAtTap()
	{
	}
}
[Token(Token = "0x200004C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21BF8", Offset = "0xA21BF8")]
public class TBOrbit : MonoBehaviour
{
	[Token(Token = "0x200004D")]
	public enum PanMode
	{
		[Token(Token = "0x400014E")]
		Disabled,
		[Token(Token = "0x400014F")]
		OneFinger,
		[Token(Token = "0x4000150")]
		TwoFingers
	}

	[Serializable]
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA21C30", Offset = "0xA21C30")]
	private sealed class <>c
	{
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<GestureRecognizer> <>9__54_0;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<GestureRecognizer> <>9__54_1;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x18")]
		public static Predicate<GestureRecognizer> <>9__54_2;

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x24E36A0", Offset = "0x24E36A0", VA = "0x24E36A0")]
		public <>c()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x24E36A8", Offset = "0x24E36A8", VA = "0x24E36A8")]
		internal bool <InstallGestureRecognizers>b__54_0(GestureRecognizer r)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x24E3700", Offset = "0x24E3700", VA = "0x24E3700")]
		internal bool <InstallGestureRecognizers>b__54_1(GestureRecognizer r)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x24E3758", Offset = "0x24E3758", VA = "0x24E3758")]
		internal bool <InstallGestureRecognizers>b__54_2(GestureRecognizer r)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x20")]
	public float initialDistance;

	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x24")]
	public float minDistance;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x28")]
	public float maxDistance;

	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x2C")]
	public float yawSensitivity;

	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x30")]
	public float pitchSensitivity;

	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x34")]
	public bool clampYawAngle;

	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x38")]
	public float minYaw;

	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x3C")]
	public float maxYaw;

	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x40")]
	public bool clampPitchAngle;

	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x44")]
	public float minPitch;

	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x48")]
	public float maxPitch;

	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x4C")]
	public bool allowPinchZoom;

	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x50")]
	public float pinchZoomSensitivity;

	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0x54")]
	public bool smoothMotion;

	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0x58")]
	public float smoothZoomSpeed;

	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x5C")]
	public float smoothOrbitSpeed;

	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x60")]
	public bool allowPanning;

	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x61")]
	public bool invertPanningDirections;

	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x64")]
	public float panningSensitivity;

	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x68")]
	public Transform panningPlane;

	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x70")]
	public bool smoothPanning;

	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0x74")]
	public float smoothPanningSpeed;

	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0x78")]
	public LayerMask collisionLayerMask;

	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0x7C")]
	private float distance;

	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0x80")]
	private float yaw;

	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0x84")]
	private float pitch;

	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0x88")]
	private float idealDistance;

	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x8C")]
	private float idealYaw;

	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x90")]
	private float idealPitch;

	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 idealPanOffset;

	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 panOffset;

	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0xB0")]
	private PinchRecognizer pinchRecognizer;

	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0xB8")]
	private float nextDragTime;

	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0xBC")]
	public bool OnlyRotateWhenDragStartsOnObject;

	[Token(Token = "0x1700005B")]
	public float Distance
	{
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1F22250", Offset = "0x1F22250", VA = "0x1F22250")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700005C")]
	public float IdealDistance
	{
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1F22258", Offset = "0x1F22258", VA = "0x1F22258")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1F22260", Offset = "0x1F22260", VA = "0x1F22260")]
		set
		{
		}
	}

	[Token(Token = "0x1700005D")]
	public float Yaw
	{
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1F2228C", Offset = "0x1F2228C", VA = "0x1F2228C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700005E")]
	public float IdealYaw
	{
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1F22294", Offset = "0x1F22294", VA = "0x1F22294")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1F2229C", Offset = "0x1F2229C", VA = "0x1F2229C")]
		set
		{
		}
	}

	[Token(Token = "0x1700005F")]
	public float Pitch
	{
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1F22328", Offset = "0x1F22328", VA = "0x1F22328")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000060")]
	public float IdealPitch
	{
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1F22330", Offset = "0x1F22330", VA = "0x1F22330")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1F22338", Offset = "0x1F22338", VA = "0x1F22338")]
		set
		{
		}
	}

	[Token(Token = "0x17000061")]
	public Vector3 IdealPanOffset
	{
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1F22394", Offset = "0x1F22394", VA = "0x1F22394")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1F223A0", Offset = "0x1F223A0", VA = "0x1F223A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000062")]
	public Vector3 PanOffset
	{
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1F223AC", Offset = "0x1F223AC", VA = "0x1F223AC")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x1F223B8", Offset = "0x1F223B8", VA = "0x1F223B8")]
	private void InstallGestureRecognizers()
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x1F229B0", Offset = "0x1F229B0", VA = "0x1F229B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x1F22E1C", Offset = "0x1F22E1C", VA = "0x1F22E1C")]
	private void OnDrag(DragGesture gesture)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x1F23158", Offset = "0x1F23158", VA = "0x1F23158")]
	private void OnPinch(PinchGesture gesture)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x1F231D0", Offset = "0x1F231D0", VA = "0x1F231D0")]
	private void OnTwoFingerDrag(DragGesture gesture)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x1F22B24", Offset = "0x1F22B24", VA = "0x1F22B24")]
	private void Apply()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x1F232FC", Offset = "0x1F232FC", VA = "0x1F232FC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x1F222F8", Offset = "0x1F222F8", VA = "0x1F222F8")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x1F23300", Offset = "0x1F23300", VA = "0x1F23300")]
	public void ResetPanning()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x1F2332C", Offset = "0x1F2332C", VA = "0x1F2332C")]
	public TBOrbit()
	{
	}
}
[Token(Token = "0x200004F")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xA21C40", Offset = "0xA21C40")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21C40", Offset = "0xA21C40")]
public class TBPan : MonoBehaviour
{
	[Token(Token = "0x2000050")]
	public delegate void PanEventHandler(TBPan source, Vector3 move);

	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x18")]
	private Transform cachedTransform;

	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x20")]
	public float sensitivity;

	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x24")]
	public float smoothSpeed;

	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x28")]
	public BoxCollider moveArea;

	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 idealPos;

	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x40")]
	private DragGesture dragGesture;

	[Token(Token = "0x1400000B")]
	public event PanEventHandler OnPan
	{
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1F233DC", Offset = "0x1F233DC", VA = "0x1F233DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24EB8", Offset = "0xA24EB8")]
		add
		{
		}
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1F2347C", Offset = "0x1F2347C", VA = "0x1F2347C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24EC8", Offset = "0xA24EC8")]
		remove
		{
		}
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x1F2351C", Offset = "0x1F2351C", VA = "0x1F2351C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x1F23544", Offset = "0x1F23544", VA = "0x1F23544")]
	private void Start()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x1F23698", Offset = "0x1F23698", VA = "0x1F23698")]
	private void OnDrag(DragGesture gesture)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x1F236C4", Offset = "0x1F236C4", VA = "0x1F236C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x1F239D0", Offset = "0x1F239D0", VA = "0x1F239D0")]
	public Vector3 ConstrainToPanningPlane(Vector3 p)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x1F23A10", Offset = "0x1F23A10", VA = "0x1F23A10")]
	public void TeleportTo(Vector3 worldPos)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x1F23A4C", Offset = "0x1F23A4C", VA = "0x1F23A4C")]
	public void FlyTo(Vector3 worldPos)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x1F23854", Offset = "0x1F23854", VA = "0x1F23854")]
	public Vector3 ConstrainToMoveArea(Vector3 p)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x1F23A74", Offset = "0x1F23A74", VA = "0x1F23A74")]
	public TBPan()
	{
	}
}
[Token(Token = "0x2000051")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xA21CC4", Offset = "0xA21CC4")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21CC4", Offset = "0xA21CC4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xA21CC4", Offset = "0xA21CC4")]
public class TBPinchZoom : MonoBehaviour
{
	[Token(Token = "0x2000052")]
	public enum ZoomMethod
	{
		[Token(Token = "0x4000167")]
		Position,
		[Token(Token = "0x4000168")]
		FOV
	}

	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x18")]
	public ZoomMethod zoomMethod;

	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x1C")]
	public float zoomSpeed;

	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x20")]
	public float minZoomAmount;

	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x24")]
	public float maxZoomAmount;

	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x28")]
	public float SmoothSpeed;

	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 defaultPos;

	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0x38")]
	private float defaultFov;

	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x3C")]
	private float defaultOrthoSize;

	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x40")]
	private float idealZoomAmount;

	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x44")]
	private float zoomAmount;

	[Token(Token = "0x17000063")]
	public Vector3 DefaultPos
	{
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x24DC720", Offset = "0x24DC720", VA = "0x24DC720")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x24DC72C", Offset = "0x24DC72C", VA = "0x24DC72C")]
		set
		{
		}
	}

	[Token(Token = "0x17000064")]
	public float DefaultFov
	{
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x24DC738", Offset = "0x24DC738", VA = "0x24DC738")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x24DC740", Offset = "0x24DC740", VA = "0x24DC740")]
		set
		{
		}
	}

	[Token(Token = "0x17000065")]
	public float DefaultOrthoSize
	{
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x24DC748", Offset = "0x24DC748", VA = "0x24DC748")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x24DC750", Offset = "0x24DC750", VA = "0x24DC750")]
		set
		{
		}
	}

	[Token(Token = "0x17000066")]
	public float IdealZoomAmount
	{
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x24DC758", Offset = "0x24DC758", VA = "0x24DC758")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x24DC760", Offset = "0x24DC760", VA = "0x24DC760")]
		set
		{
		}
	}

	[Token(Token = "0x17000067")]
	public float ZoomAmount
	{
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x24DC78C", Offset = "0x24DC78C", VA = "0x24DC78C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x24DC794", Offset = "0x24DC794", VA = "0x24DC794")]
		set
		{
		}
	}

	[Token(Token = "0x17000068")]
	private float CameraFov
	{
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x24DC988", Offset = "0x24DC988", VA = "0x24DC988")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x24DC91C", Offset = "0x24DC91C", VA = "0x24DC91C")]
		set
		{
		}
	}

	[Token(Token = "0x17000069")]
	public float ZoomPercent
	{
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x24DC9E4", Offset = "0x24DC9E4", VA = "0x24DC9E4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x24DC9FC", Offset = "0x24DC9FC", VA = "0x24DC9FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x24DCBC0", Offset = "0x24DCBC0", VA = "0x24DCBC0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x24DCB30", Offset = "0x24DCB30", VA = "0x24DCB30")]
	public void SetDefaults()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x24DCC0C", Offset = "0x24DCC0C", VA = "0x24DCC0C")]
	private void OnPinch(PinchGesture gesture)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x24DCC64", Offset = "0x24DCC64", VA = "0x24DCC64")]
	public TBPinchZoom()
	{
	}
}
[Token(Token = "0x2000053")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21D7C", Offset = "0xA21D7C")]
public class TBDragToMove : MonoBehaviour
{
	[Token(Token = "0x2000054")]
	public enum DragPlaneType
	{
		[Token(Token = "0x4000174")]
		Camera,
		[Token(Token = "0x4000175")]
		UseCollider
	}

	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x18")]
	public Collider DragPlaneCollider;

	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x20")]
	public float DragPlaneOffset;

	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x28")]
	public Camera RaycastCamera;

	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x30")]
	public bool DragFromObjectCenter;

	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x31")]
	private bool dragging;

	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x38")]
	private FingerGestures.Finger draggingFinger;

	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x40")]
	private GestureRecognizer gestureRecognizer;

	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x48")]
	private bool oldUseGravity;

	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x49")]
	private bool oldIsKinematic;

	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 physxDragMove;

	[Token(Token = "0x1700006A")]
	public bool Dragging
	{
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1F21034", Offset = "0x1F21034", VA = "0x1F21034")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1F2103C", Offset = "0x1F2103C", VA = "0x1F2103C")]
		private set
		{
		}
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x1F211E8", Offset = "0x1F211E8", VA = "0x1F211E8")]
	private void Start()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x1F21264", Offset = "0x1F21264", VA = "0x1F21264")]
	public bool ProjectScreenPointOnDragPlane(Vector3 refPos, Vector2 screenPos, out Vector3 worldPos)
	{
		return default(bool);
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x1F214C4", Offset = "0x1F214C4", VA = "0x1F214C4")]
	private void HandleDrag(DragGesture gesture)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x1F21764", Offset = "0x1F21764", VA = "0x1F21764")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x1F21868", Offset = "0x1F21868", VA = "0x1F21868")]
	private void OnDrag(DragGesture gesture)
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x1F2186C", Offset = "0x1F2186C", VA = "0x1F2186C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x1F21880", Offset = "0x1F21880", VA = "0x1F21880")]
	public TBDragToMove()
	{
	}
}
[Token(Token = "0x2000055")]
public class TBHoverChangeMaterial : MonoBehaviour
{
	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x18")]
	public Material hoverMaterial;

	[Token(Token = "0x4000177")]
	[FieldOffset(Offset = "0x20")]
	private Material normalMaterial;

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x1F21DC0", Offset = "0x1F21DC0", VA = "0x1F21DC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x1F21E24", Offset = "0x1F21E24", VA = "0x1F21E24")]
	private void OnFingerHover(FingerHoverEvent e)
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x1F21EAC", Offset = "0x1F21EAC", VA = "0x1F21EAC")]
	public TBHoverChangeMaterial()
	{
	}
}
[Token(Token = "0x2000056")]
public class TBHoverChangeScale : MonoBehaviour
{
	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0x18")]
	public float hoverScaleFactor;

	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 originalScale;

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x1F21EB4", Offset = "0x1F21EB4", VA = "0x1F21EB4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x1F21EF0", Offset = "0x1F21EF0", VA = "0x1F21EF0")]
	private void OnFingerHover(FingerHoverEvent e)
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x1F21F54", Offset = "0x1F21F54", VA = "0x1F21F54")]
	public TBHoverChangeScale()
	{
	}
}
[Token(Token = "0x2000057")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21DB4", Offset = "0xA21DB4")]
public class TBPinchToScale : MonoBehaviour
{
	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 scaleWeights;

	[Token(Token = "0x400017B")]
	[FieldOffset(Offset = "0x24")]
	public float minScaleAmount;

	[Token(Token = "0x400017C")]
	[FieldOffset(Offset = "0x28")]
	public float maxScaleAmount;

	[Token(Token = "0x400017D")]
	[FieldOffset(Offset = "0x2C")]
	public float sensitivity;

	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0x30")]
	public float smoothingSpeed;

	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0x34")]
	private float idealScaleAmount;

	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0x38")]
	private float scaleAmount;

	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 baseScale;

	[Token(Token = "0x1700006B")]
	public float ScaleAmount
	{
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x24DC4CC", Offset = "0x24DC4CC", VA = "0x24DC4CC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x24DC4D4", Offset = "0x24DC4D4", VA = "0x24DC4D4")]
		set
		{
		}
	}

	[Token(Token = "0x1700006C")]
	public float IdealScaleAmount
	{
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x24DC580", Offset = "0x24DC580", VA = "0x24DC580")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x24DC588", Offset = "0x24DC588", VA = "0x24DC588")]
		set
		{
		}
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x24DC5B4", Offset = "0x24DC5B4", VA = "0x24DC5B4")]
	private void Start()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x24DC610", Offset = "0x24DC610", VA = "0x24DC610")]
	private void Update()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x24DC670", Offset = "0x24DC670", VA = "0x24DC670")]
	private void OnPinch(PinchGesture gesture)
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x24DC6C8", Offset = "0x24DC6C8", VA = "0x24DC6C8")]
	public TBPinchToScale()
	{
	}
}
[Token(Token = "0x2000058")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21DEC", Offset = "0xA21DEC")]
public class TBQuickSetup : MonoBehaviour
{
	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x18")]
	public GameObject MessageTarget;

	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x20")]
	public int MaxSimultaneousGestures;

	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x28")]
	private ScreenRaycaster screenRaycaster;

	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA232B0", Offset = "0xA232B0")]
	private FingerDownDetector <FingerDown>k__BackingField;

	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA232C0", Offset = "0xA232C0")]
	private FingerUpDetector <FingerUp>k__BackingField;

	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA232D0", Offset = "0xA232D0")]
	private FingerHoverDetector <FingerHover>k__BackingField;

	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA232E0", Offset = "0xA232E0")]
	private FingerMotionDetector <FingerMotion>k__BackingField;

	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA232F0", Offset = "0xA232F0")]
	private DragRecognizer <Drag>k__BackingField;

	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23300", Offset = "0xA23300")]
	private LongPressRecognizer <LongPress>k__BackingField;

	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23310", Offset = "0xA23310")]
	private SwipeRecognizer <Swipe>k__BackingField;

	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23320", Offset = "0xA23320")]
	private TapRecognizer <Tap>k__BackingField;

	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23330", Offset = "0xA23330")]
	private TapRecognizer <DoubleTap>k__BackingField;

	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23340", Offset = "0xA23340")]
	private PinchRecognizer <Pinch>k__BackingField;

	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23350", Offset = "0xA23350")]
	private TwistRecognizer <Twist>k__BackingField;

	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23360", Offset = "0xA23360")]
	private DragRecognizer <TwoFingerDrag>k__BackingField;

	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23370", Offset = "0xA23370")]
	private TapRecognizer <TwoFingerTap>k__BackingField;

	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23380", Offset = "0xA23380")]
	private SwipeRecognizer <TwoFingerSwipe>k__BackingField;

	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23390", Offset = "0xA23390")]
	private LongPressRecognizer <TwoFingerLongPress>k__BackingField;

	[Token(Token = "0x1700006D")]
	public FingerDownDetector FingerDown
	{
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x24DCCAC", Offset = "0x24DCCAC", VA = "0x24DCCAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24ED8", Offset = "0xA24ED8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x24DCCB4", Offset = "0x24DCCB4", VA = "0x24DCCB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24EE8", Offset = "0xA24EE8")]
		set
		{
		}
	}

	[Token(Token = "0x1700006E")]
	public FingerUpDetector FingerUp
	{
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x24DCCBC", Offset = "0x24DCCBC", VA = "0x24DCCBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24EF8", Offset = "0xA24EF8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x24DCCC4", Offset = "0x24DCCC4", VA = "0x24DCCC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24F08", Offset = "0xA24F08")]
		set
		{
		}
	}

	[Token(Token = "0x1700006F")]
	public FingerHoverDetector FingerHover
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x24DCCCC", Offset = "0x24DCCCC", VA = "0x24DCCCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24F18", Offset = "0xA24F18")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x24DCCD4", Offset = "0x24DCCD4", VA = "0x24DCCD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24F28", Offset = "0xA24F28")]
		set
		{
		}
	}

	[Token(Token = "0x17000070")]
	public FingerMotionDetector FingerMotion
	{
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x24DCCDC", Offset = "0x24DCCDC", VA = "0x24DCCDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24F38", Offset = "0xA24F38")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x24DCCE4", Offset = "0x24DCCE4", VA = "0x24DCCE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24F48", Offset = "0xA24F48")]
		set
		{
		}
	}

	[Token(Token = "0x17000071")]
	public DragRecognizer Drag
	{
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x24DCCEC", Offset = "0x24DCCEC", VA = "0x24DCCEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24F58", Offset = "0xA24F58")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x24DCCF4", Offset = "0x24DCCF4", VA = "0x24DCCF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24F68", Offset = "0xA24F68")]
		set
		{
		}
	}

	[Token(Token = "0x17000072")]
	public LongPressRecognizer LongPress
	{
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x24DCCFC", Offset = "0x24DCCFC", VA = "0x24DCCFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24F78", Offset = "0xA24F78")]
		get
		{
			return null;
		}
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x24DCD04", Offset = "0x24DCD04", VA = "0x24DCD04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24F88", Offset = "0xA24F88")]
		set
		{
		}
	}

	[Token(Token = "0x17000073")]
	public SwipeRecognizer Swipe
	{
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x24DCD0C", Offset = "0x24DCD0C", VA = "0x24DCD0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24F98", Offset = "0xA24F98")]
		get
		{
			return null;
		}
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x24DCD14", Offset = "0x24DCD14", VA = "0x24DCD14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24FA8", Offset = "0xA24FA8")]
		set
		{
		}
	}

	[Token(Token = "0x17000074")]
	public TapRecognizer Tap
	{
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x24DCD1C", Offset = "0x24DCD1C", VA = "0x24DCD1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24FB8", Offset = "0xA24FB8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x24DCD24", Offset = "0x24DCD24", VA = "0x24DCD24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24FC8", Offset = "0xA24FC8")]
		set
		{
		}
	}

	[Token(Token = "0x17000075")]
	public TapRecognizer DoubleTap
	{
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x24DCD2C", Offset = "0x24DCD2C", VA = "0x24DCD2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24FD8", Offset = "0xA24FD8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x24DCD34", Offset = "0x24DCD34", VA = "0x24DCD34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24FE8", Offset = "0xA24FE8")]
		set
		{
		}
	}

	[Token(Token = "0x17000076")]
	public PinchRecognizer Pinch
	{
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x24DCD3C", Offset = "0x24DCD3C", VA = "0x24DCD3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24FF8", Offset = "0xA24FF8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x24DCD44", Offset = "0x24DCD44", VA = "0x24DCD44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25008", Offset = "0xA25008")]
		set
		{
		}
	}

	[Token(Token = "0x17000077")]
	public TwistRecognizer Twist
	{
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x24DCD4C", Offset = "0x24DCD4C", VA = "0x24DCD4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25018", Offset = "0xA25018")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x24DCD54", Offset = "0x24DCD54", VA = "0x24DCD54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25028", Offset = "0xA25028")]
		set
		{
		}
	}

	[Token(Token = "0x17000078")]
	public DragRecognizer TwoFingerDrag
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x24DCD5C", Offset = "0x24DCD5C", VA = "0x24DCD5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25038", Offset = "0xA25038")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x24DCD64", Offset = "0x24DCD64", VA = "0x24DCD64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25048", Offset = "0xA25048")]
		set
		{
		}
	}

	[Token(Token = "0x17000079")]
	public TapRecognizer TwoFingerTap
	{
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x24DCD6C", Offset = "0x24DCD6C", VA = "0x24DCD6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25058", Offset = "0xA25058")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x24DCD74", Offset = "0x24DCD74", VA = "0x24DCD74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25068", Offset = "0xA25068")]
		set
		{
		}
	}

	[Token(Token = "0x1700007A")]
	public SwipeRecognizer TwoFingerSwipe
	{
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x24DCD7C", Offset = "0x24DCD7C", VA = "0x24DCD7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25078", Offset = "0xA25078")]
		get
		{
			return null;
		}
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x24DCD84", Offset = "0x24DCD84", VA = "0x24DCD84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25088", Offset = "0xA25088")]
		set
		{
		}
	}

	[Token(Token = "0x1700007B")]
	public LongPressRecognizer TwoFingerLongPress
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x24DCD8C", Offset = "0x24DCD8C", VA = "0x24DCD8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25098", Offset = "0xA25098")]
		get
		{
			return null;
		}
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x24DCD94", Offset = "0x24DCD94", VA = "0x24DCD94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA250A8", Offset = "0xA250A8")]
		set
		{
		}
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x24DCD9C", Offset = "0x24DCD9C", VA = "0x24DCD9C")]
	private GameObject CreateChildNode(string name)
	{
		return null;
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x24DCE68", Offset = "0x24DCE68", VA = "0x24DCE68")]
	private void Start()
	{
	}

	[Token(Token = "0x600024F")]
	private T AddFingerEventDetector<T>(GameObject node) where T : FingerEventDetector
	{
		return null;
	}

	[Token(Token = "0x6000250")]
	private T AddGesture<T>(GameObject node) where T : GestureRecognizer
	{
		return null;
	}

	[Token(Token = "0x6000251")]
	private T AddSingleFingerGesture<T>(GameObject node) where T : GestureRecognizer
	{
		return null;
	}

	[Token(Token = "0x6000252")]
	private T AddTwoFingerGesture<T>(GameObject node) where T : GestureRecognizer
	{
		return null;
	}

	[Token(Token = "0x6000253")]
	private T AddTwoFingerGesture<T>(GameObject node, string eventName) where T : GestureRecognizer
	{
		return null;
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x24DD37C", Offset = "0x24DD37C", VA = "0x24DD37C")]
	public TBQuickSetup()
	{
	}
}
[Token(Token = "0x2000059")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21E24", Offset = "0xA21E24")]
public class TBTwistToRotate : MonoBehaviour
{
	[Token(Token = "0x200005A")]
	public enum RotationAxis
	{
		[Token(Token = "0x4000198")]
		WorldX,
		[Token(Token = "0x4000199")]
		WorldY,
		[Token(Token = "0x400019A")]
		WorldZ,
		[Token(Token = "0x400019B")]
		ObjectX,
		[Token(Token = "0x400019C")]
		ObjectY,
		[Token(Token = "0x400019D")]
		ObjectZ,
		[Token(Token = "0x400019E")]
		CameraX,
		[Token(Token = "0x400019F")]
		CameraY,
		[Token(Token = "0x40001A0")]
		CameraZ
	}

	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x18")]
	public float Sensitivity;

	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x1C")]
	public RotationAxis Axis;

	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x20")]
	public Camera ReferenceCamera;

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x24DD38C", Offset = "0x24DD38C", VA = "0x24DD38C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x24DD408", Offset = "0x24DD408", VA = "0x24DD408")]
	public Vector3 GetRotationAxis()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x24DD5D0", Offset = "0x24DD5D0", VA = "0x24DD5D0")]
	private void OnTwist(TwistGesture gesture)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x24DD6A0", Offset = "0x24DD6A0", VA = "0x24DD6A0")]
	public TBTwistToRotate()
	{
	}
}
[Token(Token = "0x200005B")]
public class ThrowMeAnException : MonoBehaviour
{
	[Token(Token = "0x6000259")]
	[Address(RVA = "0x24DDEE8", Offset = "0x24DDEE8", VA = "0x24DDEE8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x24DDF4C", Offset = "0x24DDF4C", VA = "0x24DDF4C")]
	public void CrashForMe()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x24DDFA0", Offset = "0x24DDFA0", VA = "0x24DDFA0")]
	public ThrowMeAnException()
	{
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x200005C")]
	public enum AAMode
	{
		[Token(Token = "0x40001A2")]
		FXAA2,
		[Token(Token = "0x40001A3")]
		FXAA3Console,
		[Token(Token = "0x40001A4")]
		FXAA1PresetA,
		[Token(Token = "0x40001A5")]
		FXAA1PresetB,
		[Token(Token = "0x40001A6")]
		NFAA,
		[Token(Token = "0x40001A7")]
		SSAA,
		[Token(Token = "0x40001A8")]
		DLAA
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA21E5C", Offset = "0xA21E5C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21E5C", Offset = "0xA21E5C")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x1C")]
		public AAMode mode;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x20")]
		public bool showGeneratedNormals;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x24")]
		public float offsetScale;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x28")]
		public float blurRadius;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x2C")]
		public float edgeThresholdMin;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x30")]
		public float edgeThreshold;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x34")]
		public float edgeSharpness;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x38")]
		public bool dlaaSharp;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x40")]
		public Shader ssaaShader;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x48")]
		private Material ssaa;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x50")]
		public Shader dlaaShader;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x58")]
		private Material dlaa;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x60")]
		public Shader nfaaShader;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x68")]
		private Material nfaa;

		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x70")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x78")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x80")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x88")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x90")]
		public Shader shaderFXAAII;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x98")]
		private Material materialFXAAII;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0xA0")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0xA8")]
		private Material materialFXAAIII;

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1ECAA34", Offset = "0x1ECAA34", VA = "0x1ECAA34")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1ECAA98", Offset = "0x1ECAA98", VA = "0x1ECAA98", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1ECAB84", Offset = "0x1ECAB84", VA = "0x1ECAB84")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1ECAE28", Offset = "0x1ECAE28", VA = "0x1ECAE28")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1ECB3B4", Offset = "0x1ECB3B4", VA = "0x1ECB3B4")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21EE0", Offset = "0xA21EE0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA21EE0", Offset = "0xA21EE0")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x200005F")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x40001DE")]
			Ghosting,
			[Token(Token = "0x40001DF")]
			Anamorphic,
			[Token(Token = "0x40001E0")]
			Combined
		}

		[Token(Token = "0x2000060")]
		public enum TweakMode
		{
			[Token(Token = "0x40001E2")]
			Basic,
			[Token(Token = "0x40001E3")]
			Complex
		}

		[Token(Token = "0x2000061")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x40001E5")]
			Auto,
			[Token(Token = "0x40001E6")]
			On,
			[Token(Token = "0x40001E7")]
			Off
		}

		[Token(Token = "0x2000062")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x40001E9")]
			Screen,
			[Token(Token = "0x40001EA")]
			Add
		}

		[Token(Token = "0x2000063")]
		public enum BloomQuality
		{
			[Token(Token = "0x40001EC")]
			Cheap,
			[Token(Token = "0x40001ED")]
			High
		}

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x1C")]
		public TweakMode tweakMode;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x20")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x24")]
		public HDRBloomMode hdr;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x28")]
		private bool doHdr;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x2C")]
		public float sepBlurSpread;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x30")]
		public BloomQuality quality;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x34")]
		public float bloomIntensity;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x38")]
		public float bloomThreshold;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x3C")]
		public Color bloomThresholdColor;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x4C")]
		public int bloomBlurIterations;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x54")]
		public float flareRotation;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x58")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x5C")]
		public float hollyStretchWidth;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x60")]
		public float lensflareIntensity;

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x64")]
		public float lensflareThreshold;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x68")]
		public float lensFlareSaturation;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x6C")]
		public Color flareColorA;

		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x7C")]
		public Color flareColorB;

		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x8C")]
		public Color flareColorC;

		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x9C")]
		public Color flareColorD;

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0xB0")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0xB8")]
		public Shader lensFlareShader;

		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0xC0")]
		private Material lensFlareMaterial;

		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0xC8")]
		public Shader screenBlendShader;

		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0xD0")]
		private Material screenBlend;

		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0xD8")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0xE0")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0xE8")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0xF0")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1ECB870", Offset = "0x1ECB870", VA = "0x1ECB870", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1ECB910", Offset = "0x1ECB910", VA = "0x1ECB910")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1ECCDC0", Offset = "0x1ECCDC0", VA = "0x1ECCDC0")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1ECCB40", Offset = "0x1ECCB40", VA = "0x1ECCB40")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1ECC82C", Offset = "0x1ECC82C", VA = "0x1ECC82C")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1ECC740", Offset = "0x1ECC740", VA = "0x1ECC740")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1ECC920", Offset = "0x1ECC920", VA = "0x1ECC920")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1ECCE90", Offset = "0x1ECCE90", VA = "0x1ECCE90")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x40001EF")]
		Ghosting,
		[Token(Token = "0x40001F0")]
		Anamorphic,
		[Token(Token = "0x40001F1")]
		Combined
	}
	[Token(Token = "0x2000065")]
	public enum TweakMode34
	{
		[Token(Token = "0x40001F3")]
		Basic,
		[Token(Token = "0x40001F4")]
		Complex
	}
	[Token(Token = "0x2000066")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x40001F6")]
		Auto,
		[Token(Token = "0x40001F7")]
		On,
		[Token(Token = "0x40001F8")]
		Off
	}
	[Token(Token = "0x2000067")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x40001FA")]
		Screen,
		[Token(Token = "0x40001FB")]
		Add
	}
	[Token(Token = "0x2000068")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA21F74", Offset = "0xA21F74")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA21F74", Offset = "0xA21F74")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x1C")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x20")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x24")]
		public HDRBloomMode hdr;

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x28")]
		private bool doHdr;

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x2C")]
		public float sepBlurSpread;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x30")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x34")]
		public float bloomIntensity;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x38")]
		public float bloomThreshold;

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x3C")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x40")]
		public bool lensflares;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x44")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x48")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x4C")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x50")]
		public float lensflareIntensity;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x54")]
		public float lensflareThreshold;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x58")]
		public Color flareColorA;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x68")]
		public Color flareColorB;

		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x78")]
		public Color flareColorC;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x88")]
		public Color flareColorD;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x98")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0xA0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0xA8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0xB0")]
		public Shader vignetteShader;

		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0xB8")]
		private Material vignetteMaterial;

		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0xC0")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0xC8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0xD0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0xD8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0xE0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0xE8")]
		private Material screenBlend;

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0xF0")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0xF8")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x100")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x108")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1ECCFD0", Offset = "0x1ECCFD0", VA = "0x1ECCFD0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1ECD0AC", Offset = "0x1ECD0AC", VA = "0x1ECD0AC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1ECE118", Offset = "0x1ECE118", VA = "0x1ECE118")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1ECDEA8", Offset = "0x1ECDEA8", VA = "0x1ECDEA8")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1ECDBF8", Offset = "0x1ECDBF8", VA = "0x1ECDBF8")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1ECDD34", Offset = "0x1ECDD34", VA = "0x1ECDD34")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1ECE1D4", Offset = "0x1ECE1D4", VA = "0x1ECE1D4")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA22008", Offset = "0xA22008")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22008", Offset = "0xA22008")]
	[ExecuteInEditMode]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x200006A")]
		public enum Resolution
		{
			[Token(Token = "0x4000227")]
			Low,
			[Token(Token = "0x4000228")]
			High
		}

		[Token(Token = "0x200006B")]
		public enum BlurType
		{
			[Token(Token = "0x400022A")]
			Standard,
			[Token(Token = "0x400022B")]
			Sgx
		}

		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA233A0", Offset = "0xA233A0")]
		public float threshold;

		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA233B8", Offset = "0xA233B8")]
		public float intensity;

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA233D0", Offset = "0xA233D0")]
		public float blurSize;

		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x28")]
		private Resolution resolution;

		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA233E8", Offset = "0xA233E8")]
		public int blurIterations;

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x30")]
		public BlurType blurType;

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x38")]
		public Shader fastBloomShader;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x40")]
		private Material fastBloomMaterial;

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1ECE308", Offset = "0x1ECE308", VA = "0x1ECE308", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1ECE36C", Offset = "0x1ECE36C", VA = "0x1ECE36C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1ECE418", Offset = "0x1ECE418", VA = "0x1ECE418")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1ECE7F8", Offset = "0x1ECE7F8", VA = "0x1ECE7F8")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA2209C", Offset = "0xA2209C")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x18")]
		public int iterations;

		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x1C")]
		public float blurSpread;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x1700007C")]
		protected Material material
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x1ECE81C", Offset = "0x1ECE81C", VA = "0x1ECE81C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1ECE968", Offset = "0x1ECE968", VA = "0x1ECE968")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1ECEA6C", Offset = "0x1ECEA6C", VA = "0x1ECEA6C")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1ECEB1C", Offset = "0x1ECEB1C", VA = "0x1ECEB1C")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1ECEC40", Offset = "0x1ECEC40", VA = "0x1ECEC40")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1ECED50", Offset = "0x1ECED50", VA = "0x1ECED50")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1ECEEB8", Offset = "0x1ECEEB8", VA = "0x1ECEEB8")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA220E8", Offset = "0xA220E8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA220E8", Offset = "0xA220E8")]
	[ExecuteInEditMode]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x200006E")]
		public enum BlurType
		{
			[Token(Token = "0x4000237")]
			StandardGauss,
			[Token(Token = "0x4000238")]
			SgxGauss
		}

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA23400", Offset = "0xA23400")]
		public int downsample;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA23418", Offset = "0xA23418")]
		public float blurSize;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA23430", Offset = "0xA23430")]
		public int blurIterations;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x28")]
		public BlurType blurType;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x30")]
		public Shader blurShader;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x38")]
		private Material blurMaterial;

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1ECEED4", Offset = "0x1ECEED4", VA = "0x1ECEED4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1ECEF38", Offset = "0x1ECEF38", VA = "0x1ECEF38")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1ECEFE4", Offset = "0x1ECEFE4", VA = "0x1ECEFE4")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1ECF390", Offset = "0x1ECF390", VA = "0x1ECF390")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA2217C", Offset = "0xA2217C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA2217C", Offset = "0xA2217C")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x2000070")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x4000258")]
			CameraMotion,
			[Token(Token = "0x4000259")]
			LocalBlur,
			[Token(Token = "0x400025A")]
			Reconstruction,
			[Token(Token = "0x400025B")]
			ReconstructionDX11,
			[Token(Token = "0x400025C")]
			ReconstructionDisc
		}

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x1C")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x20")]
		public bool preview;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 previewScale;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x30")]
		public float movementScale;

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x34")]
		public float rotationScale;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x38")]
		public float maxVelocity;

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x3C")]
		public float minVelocity;

		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x40")]
		public float velocityScale;

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x44")]
		public float softZDistance;

		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x48")]
		public int velocityDownsample;

		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x4C")]
		public LayerMask excludeLayers;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x50")]
		private GameObject tmpCam;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x58")]
		public Shader shader;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x60")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x68")]
		public Shader replacementClear;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x70")]
		private Material motionBlurMaterial;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x78")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x80")]
		public Texture2D noiseTexture;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x88")]
		public float jitter;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x8C")]
		public bool showVelocity;

		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x90")]
		public float showVelocityScale;

		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x94")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0xD4")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x114")]
		private int prevFrameCount;

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x118")]
		private bool wasActive;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x11C")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x128")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x134")]
		private Vector3 prevFramePos;

		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x140")]
		private Camera _camera;

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x231C410", Offset = "0x231C410", VA = "0x231C410")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x231C51C", Offset = "0x231C51C", VA = "0x231C51C")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x231C6A8", Offset = "0x231C6A8", VA = "0x231C6A8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x231C770", Offset = "0x231C770", VA = "0x231C770")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x231C8D0", Offset = "0x231C8D0", VA = "0x231C8D0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x231C968", Offset = "0x231C968", VA = "0x231C968")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x231C5FC", Offset = "0x231C5FC", VA = "0x231C5FC")]
		private void Remember()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x231DF3C", Offset = "0x231DF3C", VA = "0x231DF3C")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x231DEAC", Offset = "0x231DEAC", VA = "0x231DEAC")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x231DF2C", Offset = "0x231DF2C", VA = "0x231DF2C")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x231E2C8", Offset = "0x231E2C8", VA = "0x231E2C8")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22210", Offset = "0xA22210")]
	[ExecuteInEditMode]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x2000072")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x4000276")]
			Simple,
			[Token(Token = "0x4000277")]
			Advanced
		}

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve redChannel;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x38")]
		public bool useDepthCorrection;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x40")]
		public AnimationCurve zCurve;

		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x50")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x60")]
		private Material ccMaterial;

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x68")]
		private Material ccDepthMaterial;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x70")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x78")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x80")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x88")]
		private Texture2D zCurveTex;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x90")]
		public float saturation;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x94")]
		public bool selectiveCc;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x98")]
		public Color selectiveFromColor;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0xA8")]
		public Color selectiveToColor;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0xB8")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0xBC")]
		public bool updateTextures;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0xC0")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0xC8")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0xD0")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0xD8")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x231E3D0", Offset = "0x231E3D0", VA = "0x231E3D0")]
		private new void Start()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x231E3FC", Offset = "0x231E3FC", VA = "0x231E3FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x231E400", Offset = "0x231E400", VA = "0x231E400", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x231E67C", Offset = "0x231E67C", VA = "0x231E67C")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x231EA3C", Offset = "0x231EA3C", VA = "0x231EA3C")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x231EA40", Offset = "0x231EA40", VA = "0x231EA40")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x231ED8C", Offset = "0x231ED8C", VA = "0x231ED8C")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA2225C", Offset = "0xA2225C")]
	[ExecuteInEditMode]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x20")]
		public Shader shader;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x28")]
		private Material material;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x30")]
		public Texture3D converted3DLut;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x38")]
		public string basedOnTempTex;

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x231F3C8", Offset = "0x231F3C8", VA = "0x231F3C8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x231F428", Offset = "0x231F428", VA = "0x231F428")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x231F4CC", Offset = "0x231F4CC", VA = "0x231F4CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x231F570", Offset = "0x231F570", VA = "0x231F570")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x231F78C", Offset = "0x231F78C", VA = "0x231F78C")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x231F854", Offset = "0x231F854", VA = "0x231F854")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x231FBB0", Offset = "0x231FBB0", VA = "0x231FBB0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x231FDC8", Offset = "0x231FDC8", VA = "0x231FDC8")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA222A8", Offset = "0xA222A8")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x231FE1C", Offset = "0x231FE1C", VA = "0x231FE1C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x231FEE4", Offset = "0x231FEE4", VA = "0x231FEE4")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA222F4", Offset = "0xA222F4")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA222F4", Offset = "0xA222F4")]
	internal class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x1C")]
		public float intensity;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x20")]
		public float threshold;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x28")]
		private Material separableBlurMaterial;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x30")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x38")]
		public float blurSpread;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x40")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x48")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x231FF1C", Offset = "0x231FF1C", VA = "0x231FF1C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x231FF9C", Offset = "0x231FF9C", VA = "0x231FF9C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x2320330", Offset = "0x2320330", VA = "0x2320330")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22388", Offset = "0xA22388")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x18")]
		public float adaptationSpeed;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x1C")]
		public float limitMinimum;

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x20")]
		public float limitMaximum;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x1700007D")]
		protected Material materialLum
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x2320348", Offset = "0x2320348", VA = "0x2320348")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		protected Material materialReduce
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x2320414", Offset = "0x2320414", VA = "0x2320414")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		protected Material materialAdapt
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x23204E0", Offset = "0x23204E0", VA = "0x23204E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		protected Material materialApply
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x23205AC", Offset = "0x23205AC", VA = "0x23205AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2320678", Offset = "0x2320678", VA = "0x2320678")]
		private void Start()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2320700", Offset = "0x2320700", VA = "0x2320700")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2320858", Offset = "0x2320858", VA = "0x2320858")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2320A7C", Offset = "0x2320A7C", VA = "0x2320A7C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2320CE0", Offset = "0x2320CE0", VA = "0x2320CE0")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2320EDC", Offset = "0x2320EDC", VA = "0x2320EDC")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA223D4", Offset = "0xA223D4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA223D4", Offset = "0xA223D4")]
	[ExecuteInEditMode]
	internal class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x1C")]
		public float intensity;

		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x20")]
		public int softness;

		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x24")]
		public float spread;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x28")]
		public Shader blurShader;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x30")]
		private Material blurMaterial;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x38")]
		public Shader depthFetchShader;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x40")]
		private Material depthFetchMaterial;

		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x48")]
		public Shader creaseApplyShader;

		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x50")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2320F50", Offset = "0x2320F50", VA = "0x2320F50", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2320FDC", Offset = "0x2320FDC", VA = "0x2320FDC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x23213B0", Offset = "0x23213B0", VA = "0x23213B0")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA22468", Offset = "0xA22468")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22468", Offset = "0xA22468")]
	[ExecuteInEditMode]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x2000079")]
		public enum BlurType
		{
			[Token(Token = "0x40002B3")]
			DiscBlur,
			[Token(Token = "0x40002B4")]
			DX11
		}

		[Token(Token = "0x200007A")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x40002B6")]
			Low,
			[Token(Token = "0x40002B7")]
			Medium,
			[Token(Token = "0x40002B8")]
			High
		}

		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x1B")]
		public bool visualizeFocus;

		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x1C")]
		public float focalLength;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x20")]
		public float focalSize;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x24")]
		public float aperture;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x28")]
		public Transform focalTransform;

		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x30")]
		public float maxBlurSize;

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x34")]
		public bool highResolution;

		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x38")]
		public BlurType blurType;

		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x3C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x40")]
		public bool nearBlur;

		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x44")]
		public float foregroundOverlap;

		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x48")]
		public Shader dofHdrShader;

		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x50")]
		private Material dofHdrMaterial;

		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x58")]
		public Shader dx11BokehShader;

		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x60")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x68")]
		public float dx11BokehThreshold;

		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x6C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x70")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x78")]
		public float dx11BokehScale;

		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x7C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x80")]
		private float focalDistance01;

		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x88")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x90")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x98")]
		private float internalBlurWidth;

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x23213CC", Offset = "0x23213CC", VA = "0x23213CC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x2321584", Offset = "0x2321584", VA = "0x2321584")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x23215F4", Offset = "0x23215F4", VA = "0x23215F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x23216F8", Offset = "0x23216F8", VA = "0x23216F8")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x2321460", Offset = "0x2321460", VA = "0x2321460")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x232173C", Offset = "0x232173C", VA = "0x232173C")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2321894", Offset = "0x2321894", VA = "0x2321894")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2321BC8", Offset = "0x2321BC8", VA = "0x2321BC8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x232320C", Offset = "0x232320C", VA = "0x232320C")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA224FC", Offset = "0xA224FC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA224FC", Offset = "0xA224FC")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x200007C")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x40002E5")]
			OnlyBackground = 1,
			[Token(Token = "0x40002E6")]
			BackgroundAndForeground
		}

		[Token(Token = "0x200007D")]
		public enum DofResolution
		{
			[Token(Token = "0x40002E8")]
			High = 2,
			[Token(Token = "0x40002E9")]
			Medium,
			[Token(Token = "0x40002EA")]
			Low
		}

		[Token(Token = "0x200007E")]
		public enum DofBlurriness
		{
			[Token(Token = "0x40002EC")]
			Low = 1,
			[Token(Token = "0x40002ED")]
			High = 2,
			[Token(Token = "0x40002EE")]
			VeryHigh = 4
		}

		[Token(Token = "0x200007F")]
		public enum BokehDestination
		{
			[Token(Token = "0x40002F0")]
			Background = 1,
			[Token(Token = "0x40002F1")]
			Foreground,
			[Token(Token = "0x40002F2")]
			BackgroundAndForeground
		}

		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x1C")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x20")]
		public DofResolution resolution;

		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x24")]
		public bool simpleTweakMode;

		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x28")]
		public float focalPoint;

		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x2C")]
		public float smoothness;

		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x30")]
		public float focalZDistance;

		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x34")]
		public float focalZStartCurve;

		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x38")]
		public float focalZEndCurve;

		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x3C")]
		private float focalStartCurve;

		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x40")]
		private float focalEndCurve;

		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x44")]
		private float focalDistance01;

		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x48")]
		public Transform objectFocus;

		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x50")]
		public float focalSize;

		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x54")]
		public DofBlurriness bluriness;

		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x58")]
		public float maxBlurSpread;

		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x5C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x60")]
		public Shader dofBlurShader;

		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x68")]
		private Material dofBlurMaterial;

		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x70")]
		public Shader dofShader;

		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x78")]
		private Material dofMaterial;

		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x80")]
		public bool visualize;

		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x84")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x88")]
		private float widthOverHeight;

		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x8C")]
		private float oneOverBaseSize;

		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x90")]
		public bool bokeh;

		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x91")]
		public bool bokehSupport;

		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x98")]
		public Shader bokehShader;

		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0xA0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0xA8")]
		public float bokehScale;

		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0xAC")]
		public float bokehIntensity;

		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0xB0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0xB4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0xB8")]
		public int bokehDownsample;

		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0xC0")]
		private Material bokehMaterial;

		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0xC8")]
		private Camera _camera;

		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0xD0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0xD8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0xE0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0xE8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0xF0")]
		private RenderTexture bokehSource;

		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0xF8")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2323264", Offset = "0x2323264", VA = "0x2323264")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2323340", Offset = "0x2323340", VA = "0x2323340", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2323454", Offset = "0x2323454", VA = "0x2323454")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x23234B0", Offset = "0x23234B0", VA = "0x23234B0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2323524", Offset = "0x2323524", VA = "0x2323524")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2323614", Offset = "0x2323614", VA = "0x2323614")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2323638", Offset = "0x2323638", VA = "0x2323638")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x232365C", Offset = "0x232365C", VA = "0x232365C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2324498", Offset = "0x2324498", VA = "0x2324498")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2324B8C", Offset = "0x2324B8C", VA = "0x2324B8C")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2325004", Offset = "0x2325004", VA = "0x2325004")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2324338", Offset = "0x2324338", VA = "0x2324338")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x232473C", Offset = "0x232473C", VA = "0x232473C")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x2324E5C", Offset = "0x2324E5C", VA = "0x2324E5C")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x2324008", Offset = "0x2324008", VA = "0x2324008")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x2325234", Offset = "0x2325234", VA = "0x2325234")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x2000080")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA22590", Offset = "0xA22590")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22590", Offset = "0xA22590")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x2000081")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x40002FF")]
			TriangleDepthNormals,
			[Token(Token = "0x4000300")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x4000301")]
			SobelDepth,
			[Token(Token = "0x4000302")]
			SobelDepthThin,
			[Token(Token = "0x4000303")]
			TriangleLuminance
		}

		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x1C")]
		public EdgeDetectMode mode;

		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x20")]
		public float sensitivityDepth;

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x24")]
		public float sensitivityNormals;

		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x28")]
		public float lumThreshold;

		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x2C")]
		public float edgeExp;

		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x30")]
		public float sampleDist;

		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x34")]
		public float edgesOnly;

		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x38")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x48")]
		public Shader edgeDetectShader;

		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x50")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x58")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x23281D0", Offset = "0x23281D0", VA = "0x23281D0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2328310", Offset = "0x2328310", VA = "0x2328310")]
		private new void Start()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x2328254", Offset = "0x2328254", VA = "0x2328254")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x232831C", Offset = "0x232831C", VA = "0x232831C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x2328320", Offset = "0x2328320", VA = "0x2328320")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x2328548", Offset = "0x2328548", VA = "0x2328548")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x2000082")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22624", Offset = "0xA22624")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA22624", Offset = "0xA22624")]
	internal class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x1C")]
		public float strengthX;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x20")]
		public float strengthY;

		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x28")]
		public Shader fishEyeShader;

		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x30")]
		private Material fisheyeMaterial;

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1F147D0", Offset = "0x1F147D0", VA = "0x1F147D0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1F14DC0", Offset = "0x1F14DC0", VA = "0x1F14DC0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1F14F38", Offset = "0x1F14F38", VA = "0x1F14F38")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA226B8", Offset = "0xA226B8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA226B8", Offset = "0xA226B8")]
	[ExecuteInEditMode]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x1B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23448", Offset = "0xA23448")]
		public bool distanceFog;

		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23480", Offset = "0xA23480")]
		public bool useRadialDistance;

		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x1D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA234B8", Offset = "0xA234B8")]
		public bool heightFog;

		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA234F0", Offset = "0xA234F0")]
		public float height;

		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA23528", Offset = "0xA23528")]
		public float heightDensity;

		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23544", Offset = "0xA23544")]
		public float startDistance;

		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x30")]
		public Shader fogShader;

		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x38")]
		private Material fogMaterial;

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1F15C3C", Offset = "0x1F15C3C", VA = "0x1F15C3C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1F15C94", Offset = "0x1F15C94", VA = "0x1F15C94")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1F1637C", Offset = "0x1F1637C", VA = "0x1F1637C")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1F164E8", Offset = "0x1F164E8", VA = "0x1F164E8")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA2274C", Offset = "0xA2274C")]
	[ExecuteInEditMode]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x30")]
		public float rampOffset;

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1F17B9C", Offset = "0x1F17B9C", VA = "0x1F17B9C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1F17D58", Offset = "0x1F17D58", VA = "0x1F17D58")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA22798", Offset = "0xA22798")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22798", Offset = "0xA22798")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000081")]
		protected Material material
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x1F17C8C", Offset = "0x1F17C8C", VA = "0x1F17C8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1F17D68", Offset = "0x1F17D68", VA = "0x1F17D68", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1F17E08", Offset = "0x1F17E08", VA = "0x1F17E08", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1F17D60", Offset = "0x1F17D60", VA = "0x1F17D60")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA2281C", Offset = "0xA2281C")]
	public class ImageEffects
	{
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1F17EB4", Offset = "0x1F17EB4", VA = "0x1F17EB4")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1F18100", Offset = "0x1F18100", VA = "0x1F18100")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xA250D8", Offset = "0xA250D8")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1F18174", Offset = "0x1F18174", VA = "0x1F18174")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xA25110", Offset = "0xA25110")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1F181F0", Offset = "0x1F181F0", VA = "0x1F181F0")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22854", Offset = "0xA22854")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA22854", Offset = "0xA22854")]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x28")]
		public float blurAmount;

		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1F1922C", Offset = "0x1F1922C", VA = "0x1F1922C", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1F1929C", Offset = "0x1F1929C", VA = "0x1F1929C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1F19620", Offset = "0x1F19620", VA = "0x1F19620")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA228E8", Offset = "0xA228E8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA228E8", Offset = "0xA228E8")]
	[ExecuteInEditMode]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x1C")]
		public float intensityMultiplier;

		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x20")]
		public float generalIntensity;

		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x24")]
		public float blackIntensity;

		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x28")]
		public float whiteIntensity;

		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x2C")]
		public float midGrey;

		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x30")]
		public bool dx11Grain;

		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x34")]
		public float softness;

		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x38")]
		public bool monochrome;

		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 intensities;

		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 tiling;

		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x54")]
		public float monochromeTiling;

		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x58")]
		public FilterMode filterMode;

		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x60")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x68")]
		public Shader noiseShader;

		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x70")]
		private Material noiseMaterial;

		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x78")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x80")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1F19634", Offset = "0x1F19634", VA = "0x1F19634", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1F196AC", Offset = "0x1F196AC", VA = "0x1F196AC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1F19EB0", Offset = "0x1F19EB0", VA = "0x1F19EB0")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1F1A204", Offset = "0x1F1A204", VA = "0x1F1A204")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA2297C", Offset = "0xA2297C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA2297C", Offset = "0xA2297C")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x1C")]
		public float grainIntensityMin;

		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x20")]
		public float grainIntensityMax;

		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x24")]
		public float grainSize;

		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x28")]
		public float scratchIntensityMin;

		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x2C")]
		public float scratchIntensityMax;

		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x30")]
		public float scratchFPS;

		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x34")]
		public float scratchJitter;

		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x17000082")]
		protected Material material
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x1F1A3EC", Offset = "0x1F1A3EC", VA = "0x1F1A3EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1F1A2A4", Offset = "0x1F1A2A4", VA = "0x1F1A2A4")]
		protected void Start()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1F1A550", Offset = "0x1F1A550", VA = "0x1F1A550")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1F1A650", Offset = "0x1F1A650", VA = "0x1F1A650")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1F1A744", Offset = "0x1F1A744", VA = "0x1F1A744")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1F1AAC4", Offset = "0x1F1AAC4", VA = "0x1F1AAC4")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA22A10", Offset = "0xA22A10")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1F14920", Offset = "0x1F14920", VA = "0x1F14920")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1F1CDF0", Offset = "0x1F1CDF0", VA = "0x1F1CDF0")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1F1D000", Offset = "0x1F1D000", VA = "0x1F1D000")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1F1D00C", Offset = "0x1F1D00C", VA = "0x1F1D00C")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1F1D014", Offset = "0x1F1D014", VA = "0x1F1D014", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1F1D0D8", Offset = "0x1F1D0D8", VA = "0x1F1D0D8")]
		protected void Start()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1F14828", Offset = "0x1F14828", VA = "0x1F14828")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1F1D0E4", Offset = "0x1F1D0E4", VA = "0x1F1D0E4")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1F1D140", Offset = "0x1F1D140", VA = "0x1F1D140")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1F14D04", Offset = "0x1F14D04", VA = "0x1F14D04")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1F1D148", Offset = "0x1F1D148", VA = "0x1F1D148")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1F1CDC4", Offset = "0x1F1CDC4", VA = "0x1F1CDC4")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1F1D374", Offset = "0x1F1D374", VA = "0x1F1D374")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1F14F5C", Offset = "0x1F14F5C", VA = "0x1F14F5C")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA22A80", Offset = "0xA22A80")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1F1D6F0", Offset = "0x1F1D6F0", VA = "0x1F1D6F0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1F1D764", Offset = "0x1F1D764", VA = "0x1F1D764")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1F1D9BC", Offset = "0x1F1D9BC", VA = "0x1F1D9BC")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1F1DD34", Offset = "0x1F1DD34", VA = "0x1F1DD34")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1F1DEDC", Offset = "0x1F1DEDC", VA = "0x1F1DEDC")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x200008C")]
	internal class Quads
	{
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1F1DEE4", Offset = "0x1F1DEE4", VA = "0x1F1DEE4")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1F1E010", Offset = "0x1F1E010", VA = "0x1F1E010")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1F1E1E8", Offset = "0x1F1E1E8", VA = "0x1F1E1E8")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1F1E470", Offset = "0x1F1E470", VA = "0x1F1E470")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1F1E830", Offset = "0x1F1E830", VA = "0x1F1E830")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA22AF0", Offset = "0xA22AF0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22AF0", Offset = "0xA22AF0")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x200008E")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x4000346")]
			Additive,
			[Token(Token = "0x4000347")]
			ScreenBlend,
			[Token(Token = "0x4000348")]
			Multiply,
			[Token(Token = "0x4000349")]
			Overlay,
			[Token(Token = "0x400034A")]
			AlphaBlend
		}

		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x1C")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x20")]
		public float intensity;

		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x28")]
		public Texture2D texture;

		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0x30")]
		public Shader overlayShader;

		[Token(Token = "0x4000344")]
		[FieldOffset(Offset = "0x38")]
		private Material overlayMaterial;

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1F1E83C", Offset = "0x1F1E83C", VA = "0x1F1E83C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1F1E894", Offset = "0x1F1E894", VA = "0x1F1E894")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1F1EA1C", Offset = "0x1F1EA1C", VA = "0x1F1EA1C")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22B84", Offset = "0xA22B84")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA22B84", Offset = "0xA22B84")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA2357C", Offset = "0xA2357C")]
		public float intensity;

		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA23594", Offset = "0xA23594")]
		public float radius;

		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA235B0", Offset = "0xA235B0")]
		public int blurIterations;

		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA235C8", Offset = "0xA235C8")]
		public float blurFilterDistance;

		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA235E0", Offset = "0xA235E0")]
		public int downsample;

		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D rand;

		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0x38")]
		public Shader aoShader;

		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x40")]
		private Material aoMaterial;

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1F1ED98", Offset = "0x1F1ED98", VA = "0x1F1ED98", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1F1EDF0", Offset = "0x1F1EDF0", VA = "0x1F1EDF0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1F1EE94", Offset = "0x1F1EE94", VA = "0x1F1EE94")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1F1F484", Offset = "0x1F1F484", VA = "0x1F1F484")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA22C18", Offset = "0xA22C18")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22C18", Offset = "0xA22C18")]
	[ExecuteInEditMode]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000091")]
		public enum SSAOSamples
		{
			[Token(Token = "0x400035F")]
			Low,
			[Token(Token = "0x4000360")]
			Medium,
			[Token(Token = "0x4000361")]
			High
		}

		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x18")]
		public float m_Radius;

		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x20")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x24")]
		public int m_Blur;

		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x28")]
		public int m_Downsampling;

		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x2C")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x30")]
		public float m_MinZ;

		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1F1F4B0", Offset = "0x1F1F4B0", VA = "0x1F1F4B0")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1F1F568", Offset = "0x1F1F568", VA = "0x1F1F568")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1F1F600", Offset = "0x1F1F600", VA = "0x1F1F600")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1F1F608", Offset = "0x1F1F608", VA = "0x1F1F608")]
		private void Start()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1F1F794", Offset = "0x1F1F794", VA = "0x1F1F794")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1F1F6D0", Offset = "0x1F1F6D0", VA = "0x1F1F6D0")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1F1F804", Offset = "0x1F1F804", VA = "0x1F1F804")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1F1FE7C", Offset = "0x1F1FE7C", VA = "0x1F1FE7C")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22CAC", Offset = "0xA22CAC")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1F1FEB0", Offset = "0x1F1FEB0", VA = "0x1F1FEB0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1F1FF3C", Offset = "0x1F1FF3C", VA = "0x1F1FF3C")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22CF8", Offset = "0xA22CF8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA22CF8", Offset = "0xA22CF8")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x2000094")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x4000371")]
			Low,
			[Token(Token = "0x4000372")]
			Normal,
			[Token(Token = "0x4000373")]
			High
		}

		[Token(Token = "0x2000095")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x4000375")]
			Screen,
			[Token(Token = "0x4000376")]
			Add
		}

		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x1C")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x20")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x28")]
		public Transform sunTransform;

		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x30")]
		public int radialBlurIterations;

		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x34")]
		public Color sunColor;

		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x44")]
		public Color sunThreshold;

		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x54")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x58")]
		public float sunShaftIntensity;

		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x5C")]
		public float maxRadius;

		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x60")]
		public bool useDepthTexture;

		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x68")]
		public Shader sunShaftsShader;

		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x70")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x78")]
		public Shader simpleClearShader;

		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x80")]
		private Material simpleClearMaterial;

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1F1FF44", Offset = "0x1F1FF44", VA = "0x1F1FF44", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1F1FFAC", Offset = "0x1F1FFAC", VA = "0x1F1FFAC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1F2078C", Offset = "0x1F2078C", VA = "0x1F2078C")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22D8C", Offset = "0xA22D8C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA22D8C", Offset = "0xA22D8C")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x2000097")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x400037F")]
			TiltShiftMode,
			[Token(Token = "0x4000380")]
			IrisMode
		}

		[Token(Token = "0x2000098")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x4000382")]
			Preview,
			[Token(Token = "0x4000383")]
			Normal,
			[Token(Token = "0x4000384")]
			High
		}

		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x1C")]
		public TiltShiftMode mode;

		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x20")]
		public TiltShiftQuality quality;

		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA235F8", Offset = "0xA235F8")]
		public float blurArea;

		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA23610", Offset = "0xA23610")]
		public float maxBlurSize;

		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA23628", Offset = "0xA23628")]
		public int downsample;

		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x30")]
		public Shader tiltShiftShader;

		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x38")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x24DDFA8", Offset = "0x24DDFA8", VA = "0x24DDFA8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x24DE00C", Offset = "0x24DE00C", VA = "0x24DE00C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x24DE2C8", Offset = "0x24DE2C8", VA = "0x24DE2C8")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000099")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA22E10", Offset = "0xA22E10")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22E10", Offset = "0xA22E10")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x200009A")]
		public enum TonemapperType
		{
			[Token(Token = "0x4000393")]
			SimpleReinhard,
			[Token(Token = "0x4000394")]
			UserCurve,
			[Token(Token = "0x4000395")]
			Hable,
			[Token(Token = "0x4000396")]
			Photographic,
			[Token(Token = "0x4000397")]
			OptimizedHejiDawson,
			[Token(Token = "0x4000398")]
			AdaptiveReinhard,
			[Token(Token = "0x4000399")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x200009B")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x400039B")]
			Square16 = 0x10,
			[Token(Token = "0x400039C")]
			Square32 = 0x20,
			[Token(Token = "0x400039D")]
			Square64 = 0x40,
			[Token(Token = "0x400039E")]
			Square128 = 0x80,
			[Token(Token = "0x400039F")]
			Square256 = 0x100,
			[Token(Token = "0x40003A0")]
			Square512 = 0x200,
			[Token(Token = "0x40003A1")]
			Square1024 = 0x400
		}

		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x1C")]
		public TonemapperType type;

		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x20")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x30")]
		private Texture2D curveTex;

		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x38")]
		public float exposureAdjustment;

		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x3C")]
		public float middleGrey;

		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x40")]
		public float white;

		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x44")]
		public float adaptionSpeed;

		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x48")]
		public Shader tonemapper;

		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0x50")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x400038F")]
		[FieldOffset(Offset = "0x58")]
		private Material tonemapMaterial;

		[Token(Token = "0x4000390")]
		[FieldOffset(Offset = "0x60")]
		private RenderTexture rt;

		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x68")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x24DE2E4", Offset = "0x24DE2E4", VA = "0x24DE2E4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x24DE434", Offset = "0x24DE434", VA = "0x24DE434")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x24DE6D8", Offset = "0x24DE6D8", VA = "0x24DE6D8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x24DE82C", Offset = "0x24DE82C", VA = "0x24DE82C")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x24DE924", Offset = "0x24DE924", VA = "0x24DE924")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x24DF188", Offset = "0x24DF188", VA = "0x24DF188")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x200009C")]
	internal class Triangles
	{
		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x24DF1B8", Offset = "0x24DF1B8", VA = "0x24DF1B8")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x24DF2FC", Offset = "0x24DF2FC", VA = "0x24DF2FC")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x24DF4D4", Offset = "0x24DF4D4", VA = "0x24DF4D4")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x24DF75C", Offset = "0x24DF75C", VA = "0x24DF75C")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x24DFA78", Offset = "0x24DFA78", VA = "0x24DFA78")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22EA4", Offset = "0xA22EA4")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x24DFA84", Offset = "0x24DFA84", VA = "0x24DFA84")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x24DFAD0", Offset = "0x24DFAD0", VA = "0x24DFAD0")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xA22EF0", Offset = "0xA22EF0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22EF0", Offset = "0xA22EF0")]
	[ExecuteInEditMode]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x200009F")]
		public enum AberrationMode
		{
			[Token(Token = "0x40003B6")]
			Simple,
			[Token(Token = "0x40003B7")]
			Advanced
		}

		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x1C")]
		public AberrationMode mode;

		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x20")]
		public float intensity;

		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x24")]
		public float chromaticAberration;

		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x28")]
		public float axialAberration;

		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x2C")]
		public float blur;

		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x30")]
		public float blurSpread;

		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x34")]
		public float luminanceDependency;

		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x38")]
		public float blurDistance;

		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x40")]
		public Shader vignetteShader;

		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x50")]
		public Shader chromAberrationShader;

		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x58")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x60")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0x68")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x24E0870", Offset = "0x24E0870", VA = "0x24E0870", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x24E0908", Offset = "0x24E0908", VA = "0x24E0908")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x24E0ED8", Offset = "0x24E0ED8", VA = "0x24E0ED8")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22F84", Offset = "0xA22F84")]
	[ExecuteInEditMode]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x24E0F08", Offset = "0x24E0F08", VA = "0x24E0F08")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x24E0F54", Offset = "0x24E0F54", VA = "0x24E0F54")]
		public Vortex()
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter
{
	[Token(Token = "0x20000A1")]
	public class APITester : MonoBehaviour
	{
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x18")]
		private int selectedTab;

		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x20")]
		private readonly string[] tabs;

		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0x28")]
		private FPSLevel currentFPSLevel;

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1EC1868", Offset = "0x1EC1868", VA = "0x1EC1868")]
		private void Start()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1EC191C", Offset = "0x1EC191C", VA = "0x1EC191C")]
		private void OnFPSLevelChanged(FPSLevel newLevel)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1EC1924", Offset = "0x1EC1924", VA = "0x1EC1924")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1EC2FDC", Offset = "0x1EC2FDC", VA = "0x1EC2FDC")]
		private void DrawCommonTab()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1EC3DAC", Offset = "0x1EC3DAC", VA = "0x1EC3DAC")]
		private void DrawLookFeelTab()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1EC4B58", Offset = "0x1EC4B58", VA = "0x1EC4B58")]
		private void DrawFPSCounterTab()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1EC64F0", Offset = "0x1EC64F0", VA = "0x1EC64F0")]
		private void DrawMemoryCounterTab()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1EC75C4", Offset = "0x1EC75C4", VA = "0x1EC75C4")]
		private void DrawDeviceInfoTab()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1EC9D98", Offset = "0x1EC9D98", VA = "0x1EC9D98")]
		private static float SliderLabel(float sliderValue, float sliderMinValue, float sliderMaxValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1ECA398", Offset = "0x1ECA398", VA = "0x1ECA398")]
		private Color ColorSliders(string caption, Color color)
		{
			return default(Color);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1ECA0C0", Offset = "0x1ECA0C0", VA = "0x1ECA0C0")]
		private Vector2 Vector2Slider(Vector2 input, string label)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1ECA870", Offset = "0x1ECA870", VA = "0x1ECA870")]
		public APITester()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xA22FD0", Offset = "0xA22FD0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA22FD0", Offset = "0xA22FD0")]
	public class AFPSCounter : MonoBehaviour
	{
		[Token(Token = "0x40003BE")]
		private const string MenuPath = "Code Stage/\ud83d\ude80 Advanced FPS Counter";

		[Token(Token = "0x40003BF")]
		private const string ComponentName = "Advanced FPS Counter";

		[Token(Token = "0x40003C0")]
		internal const string LogPrefix = "[AFPSCounter]: ";

		[Token(Token = "0x40003C1")]
		internal const char NewLine = '\n';

		[Token(Token = "0x40003C2")]
		internal const char Space = ' ';

		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x18")]
		public FPSCounterData fpsCounter;

		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x20")]
		public MemoryCounterData memoryCounter;

		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x28")]
		public DeviceInfoCounterData deviceInfoCounter;

		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23640", Offset = "0xA23640")]
		public KeyCode hotKey;

		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23678", Offset = "0xA23678")]
		public bool circleGesture;

		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x35")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA236B0", Offset = "0xA236B0")]
		public bool hotKeyCtrl;

		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x36")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA236E8", Offset = "0xA236E8")]
		public bool hotKeyShift;

		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x37")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23720", Offset = "0xA23720")]
		public bool hotKeyAlt;

		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23758", Offset = "0xA23758")]
		[SerializeField]
		private bool keepAlive;

		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x40")]
		private Canvas canvas;

		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x48")]
		private CanvasScaler canvasScaler;

		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x50")]
		private bool externalCanvas;

		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x58")]
		private DrawableLabel[] labels;

		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x60")]
		private int anchorsCount;

		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x64")]
		private int cachedVSync;

		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x68")]
		private int cachedFrameRate;

		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x6C")]
		private bool inited;

		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x70")]
		private readonly List<Vector2> gesturePoints;

		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x78")]
		private int gestureCount;

		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA237A4", Offset = "0xA237A4")]
		[SerializeField]
		private OperationMode operationMode;

		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x7D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA237F0", Offset = "0xA237F0")]
		[SerializeField]
		private bool forceFrameRate;

		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA2383C", Offset = "0xA2383C")]
		[SerializeField]
		private int forcedFrameRate;

		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23880", Offset = "0xA23880")]
		[SerializeField]
		private bool background;

		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA238CC", Offset = "0xA238CC")]
		[SerializeField]
		private Color backgroundColor;

		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA23918", Offset = "0xA23918")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23918", Offset = "0xA23918")]
		private int backgroundPadding;

		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA2397C", Offset = "0xA2397C")]
		[SerializeField]
		private bool shadow;

		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA239C8", Offset = "0xA239C8")]
		[SerializeField]
		private Color shadowColor;

		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23A14", Offset = "0xA23A14")]
		[SerializeField]
		private Vector2 shadowDistance;

		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23A60", Offset = "0xA23A60")]
		[SerializeField]
		private bool outline;

		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23AAC", Offset = "0xA23AAC")]
		[SerializeField]
		private Color outlineColor;

		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23AF8", Offset = "0xA23AF8")]
		[SerializeField]
		private Vector2 outlineDistance;

		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23B44", Offset = "0xA23B44")]
		[SerializeField]
		private bool autoScale;

		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23B90", Offset = "0xA23B90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA23B90", Offset = "0xA23B90")]
		[SerializeField]
		private float scaleFactor;

		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23BF4", Offset = "0xA23BF4")]
		[SerializeField]
		private Font labelsFont;

		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA23C40", Offset = "0xA23C40")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23C40", Offset = "0xA23C40")]
		private int fontSize;

		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23CA8", Offset = "0xA23CA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA23CA8", Offset = "0xA23CA8")]
		[SerializeField]
		private float lineSpacing;

		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23D0C", Offset = "0xA23D0C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA23D0C", Offset = "0xA23D0C")]
		[SerializeField]
		private int countersSpacing;

		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23D70", Offset = "0xA23D70")]
		[SerializeField]
		private Vector2 paddingOffset;

		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23DBC", Offset = "0xA23DBC")]
		[SerializeField]
		private bool pixelPerfect;

		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23E08", Offset = "0xA23E08")]
		private int sortingOrder;

		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23E54", Offset = "0xA23E54")]
		private static AFPSCounter <Instance>k__BackingField;

		[Token(Token = "0x17000083")]
		public bool KeepAlive
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x1EBE648", Offset = "0x1EBE648", VA = "0x1EBE648")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		public OperationMode OperationMode
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x1EBE650", Offset = "0x1EBE650", VA = "0x1EBE650")]
			get
			{
				return default(OperationMode);
			}
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x1EBE658", Offset = "0x1EBE658", VA = "0x1EBE658")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public bool ForceFrameRate
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x1EBEBD4", Offset = "0x1EBEBD4", VA = "0x1EBEBD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x1EBEBDC", Offset = "0x1EBEBDC", VA = "0x1EBEBDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public int ForcedFrameRate
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x1EBEC48", Offset = "0x1EBEC48", VA = "0x1EBEC48")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x1EBEC50", Offset = "0x1EBEC50", VA = "0x1EBEC50")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public bool Background
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x1EBECA8", Offset = "0x1EBECA8", VA = "0x1EBECA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x1EBECB0", Offset = "0x1EBECB0", VA = "0x1EBECB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Color BackgroundColor
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x1EBED64", Offset = "0x1EBED64", VA = "0x1EBED64")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x1EBED70", Offset = "0x1EBED70", VA = "0x1EBED70")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public int BackgroundPadding
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x1EBEE58", Offset = "0x1EBEE58", VA = "0x1EBEE58")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x1EBEE60", Offset = "0x1EBEE60", VA = "0x1EBEE60")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public bool Shadow
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x1EBEF08", Offset = "0x1EBEF08", VA = "0x1EBEF08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x1EBEF10", Offset = "0x1EBEF10", VA = "0x1EBEF10")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public Color ShadowColor
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x1EBEFC4", Offset = "0x1EBEFC4", VA = "0x1EBEFC4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x1EBEFD0", Offset = "0x1EBEFD0", VA = "0x1EBEFD0")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public Vector2 ShadowDistance
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x1EBF0B8", Offset = "0x1EBF0B8", VA = "0x1EBF0B8")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x1EBF0C0", Offset = "0x1EBF0C0", VA = "0x1EBF0C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool Outline
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x1EBF190", Offset = "0x1EBF190", VA = "0x1EBF190")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x1EBF198", Offset = "0x1EBF198", VA = "0x1EBF198")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public Color OutlineColor
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x1EBF24C", Offset = "0x1EBF24C", VA = "0x1EBF24C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x1EBF258", Offset = "0x1EBF258", VA = "0x1EBF258")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public Vector2 OutlineDistance
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x1EBF340", Offset = "0x1EBF340", VA = "0x1EBF340")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x1EBF348", Offset = "0x1EBF348", VA = "0x1EBF348")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool AutoScale
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x1EBF418", Offset = "0x1EBF418", VA = "0x1EBF418")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x1EBF420", Offset = "0x1EBF420", VA = "0x1EBF420")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public float ScaleFactor
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x1EBF4EC", Offset = "0x1EBF4EC", VA = "0x1EBF4EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x1EBF4F4", Offset = "0x1EBF4F4", VA = "0x1EBF4F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public Font LabelsFont
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x1EBF5F4", Offset = "0x1EBF5F4", VA = "0x1EBF5F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x1EBF5FC", Offset = "0x1EBF5FC", VA = "0x1EBF5FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public int FontSize
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x1EBF6F8", Offset = "0x1EBF6F8", VA = "0x1EBF6F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x1EBF700", Offset = "0x1EBF700", VA = "0x1EBF700")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public float LineSpacing
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x1EBF7A8", Offset = "0x1EBF7A8", VA = "0x1EBF7A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x1EBF7B0", Offset = "0x1EBF7B0", VA = "0x1EBF7B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public int CountersSpacing
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x1EBF8AC", Offset = "0x1EBF8AC", VA = "0x1EBF8AC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x1EBF8B4", Offset = "0x1EBF8B4", VA = "0x1EBF8B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public Vector2 PaddingOffset
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x1EBF960", Offset = "0x1EBF960", VA = "0x1EBF960")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x1EBF968", Offset = "0x1EBF968", VA = "0x1EBF968")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public bool PixelPerfect
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x1EBFA38", Offset = "0x1EBFA38", VA = "0x1EBFA38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x1EBFA40", Offset = "0x1EBFA40", VA = "0x1EBFA40")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public int SortingOrder
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x1EBFAB8", Offset = "0x1EBFAB8", VA = "0x1EBFAB8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x1EBFAC0", Offset = "0x1EBFAC0", VA = "0x1EBFAC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public static AFPSCounter Instance
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x1EBFDAC", Offset = "0x1EBFDAC", VA = "0x1EBFDAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25178", Offset = "0xA25178")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x1EBFDF8", Offset = "0x1EBFDF8", VA = "0x1EBFDF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25188", Offset = "0xA25188")]
			private set
			{
			}
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1EBFB88", Offset = "0x1EBFB88", VA = "0x1EBFB88")]
		private AFPSCounter()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1EBFE48", Offset = "0x1EBFE48", VA = "0x1EBFE48")]
		private static AFPSCounter GetOrCreateInstance(bool keepAlive)
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1EC00E0", Offset = "0x1EC00E0", VA = "0x1EC00E0")]
		public static AFPSCounter AddToScene()
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1EC00E8", Offset = "0x1EC00E8", VA = "0x1EC00E8")]
		public static AFPSCounter AddToScene(bool keepAlive)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1EC00F0", Offset = "0x1EC00F0", VA = "0x1EC00F0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xA25198", Offset = "0xA25198")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1EC00F4", Offset = "0x1EC00F4", VA = "0x1EC00F4")]
		public static void SelfDestroy()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1EC02B4", Offset = "0x1EC02B4", VA = "0x1EC02B4")]
		internal static string Color32ToHex(Color32 color)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1EBFFB4", Offset = "0x1EBFFB4", VA = "0x1EBFFB4")]
		private static AFPSCounter CreateInScene(bool lookForExistingContainer = true)
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1EC0370", Offset = "0x1EC0370", VA = "0x1EC0370")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1EC0B94", Offset = "0x1EC0B94", VA = "0x1EC0B94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1EC0CCC", Offset = "0x1EC0CCC", VA = "0x1EC0CCC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1EC114C", Offset = "0x1EC114C", VA = "0x1EC114C")]
		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1EC1150", Offset = "0x1EC1150", VA = "0x1EC1150")]
		private void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1EBE760", Offset = "0x1EBE760", VA = "0x1EBE760")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1EBEAF8", Offset = "0x1EBEAF8", VA = "0x1EBEAF8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1EC1398", Offset = "0x1EC1398", VA = "0x1EC1398")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1EC1620", Offset = "0x1EC1620", VA = "0x1EC1620")]
		internal void MakeDrawableLabelDirty(LabelAnchor anchor)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1EBE7D8", Offset = "0x1EBE7D8", VA = "0x1EBE7D8")]
		internal void UpdateTexts()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1EC04F8", Offset = "0x1EC04F8", VA = "0x1EC04F8")]
		private void ConfigureCanvas()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1EC08A0", Offset = "0x1EC08A0", VA = "0x1EC08A0")]
		private void ConfigureLabels()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1EC01DC", Offset = "0x1EC01DC", VA = "0x1EC01DC")]
		private void DisposeInternal()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1EC0D18", Offset = "0x1EC0D18", VA = "0x1EC0D18")]
		private void ProcessHotKey()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1EC0E1C", Offset = "0x1EC0E1C", VA = "0x1EC0E1C")]
		private bool CircleGestureMade()
		{
			return default(bool);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1EC1128", Offset = "0x1EC1128", VA = "0x1EC1128")]
		private void SwitchCounter()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1EC1180", Offset = "0x1EC1180", VA = "0x1EC1180")]
		private void ActivateCounters()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1EC121C", Offset = "0x1EC121C", VA = "0x1EC121C")]
		private void DeactivateCounters()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1EBEC40", Offset = "0x1EBEC40", VA = "0x1EBEC40")]
		private void RefreshForcedFrameRate()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1EC1308", Offset = "0x1EC1308", VA = "0x1EC1308")]
		private void RefreshForcedFrameRate(bool disabling)
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public enum FPSLevel : byte
	{
		[Token(Token = "0x40003ED")]
		Normal,
		[Token(Token = "0x40003EE")]
		Warning,
		[Token(Token = "0x40003EF")]
		Critical
	}
	[Token(Token = "0x20000A4")]
	public enum OperationMode : byte
	{
		[Token(Token = "0x40003F1")]
		Disabled,
		[Token(Token = "0x40003F2")]
		Background,
		[Token(Token = "0x40003F3")]
		Normal
	}
}
namespace CodeStage.AdvancedFPSCounter.Utils
{
	[Token(Token = "0x20000A5")]
	[DisallowMultipleComponent]
	public class AFPSRenderRecorder : MonoBehaviour
	{
		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x18")]
		private bool recording;

		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x1C")]
		private float renderTime;

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1EC1678", Offset = "0x1EC1678", VA = "0x1EC1678")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1EC1738", Offset = "0x1EC1738", VA = "0x1EC1738")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1EC1860", Offset = "0x1EC1860", VA = "0x1EC1860")]
		public AFPSRenderRecorder()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	internal static class CachedNumbers
	{
		[Token(Token = "0x40003F6")]
		private const int IntMax = 1000;

		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] cachedFloatDigits;

		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] cachedIntegers;

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1ECF3AC", Offset = "0x1ECF3AC", VA = "0x1ECF3AC")]
		private static string ToStringLookup(long value, bool useFloatDigits = false)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1ECF4D4", Offset = "0x1ECF4D4", VA = "0x1ECF4D4")]
		internal static StringBuilder AppendLookup(this StringBuilder text, int value)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1ECF55C", Offset = "0x1ECF55C", VA = "0x1ECF55C")]
		internal static StringBuilder AppendLookup(this StringBuilder text, long value)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1ECF5E4", Offset = "0x1ECF5E4", VA = "0x1ECF5E4")]
		internal static StringBuilder AppendLookup(this StringBuilder text, float value)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A7")]
	internal class UIUtils
	{
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x24E0640", Offset = "0x24E0640", VA = "0x24E0640")]
		internal static void ResetRectTransform(RectTransform rectTransform)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x24E0700", Offset = "0x24E0700", VA = "0x24E0700")]
		public UIUtils()
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter.Labels
{
	[Token(Token = "0x20000A8")]
	internal class DrawableLabel
	{
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x10")]
		internal GameObject container;

		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x18")]
		internal LabelAnchor anchor;

		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x20")]
		internal StringBuilder newText;

		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x28")]
		internal bool dirty;

		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x30")]
		private GameObject labelGameObject;

		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform labelTransform;

		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x40")]
		private ContentSizeFitter labelFitter;

		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x48")]
		private HorizontalLayoutGroup labelGroup;

		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x50")]
		private GameObject uiTextGameObject;

		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x58")]
		private Text uiText;

		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x60")]
		private Font font;

		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x68")]
		private int fontSize;

		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x6C")]
		private float lineSpacing;

		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x70")]
		private Vector2 pixelOffset;

		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0x78")]
		private readonly LabelEffect background;

		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x80")]
		private Image backgroundImage;

		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x88")]
		private readonly LabelEffect shadow;

		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x90")]
		private Shadow shadowComponent;

		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x98")]
		private readonly LabelEffect outline;

		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0xA0")]
		private Outline outlineComponent;

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x2326C28", Offset = "0x2326C28", VA = "0x2326C28")]
		internal DrawableLabel(GameObject container, LabelAnchor anchor, LabelEffect background, LabelEffect shadow, LabelEffect outline, Font font, int fontSize, float lineSpacing, Vector2 pixelOffset)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x2326D7C", Offset = "0x2326D7C", VA = "0x2326D7C")]
		internal void CheckAndUpdate()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x2327D60", Offset = "0x2327D60", VA = "0x2327D60")]
		internal void Clear()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x2327E84", Offset = "0x2327E84", VA = "0x2327E84")]
		internal void Destroy()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x2327EA8", Offset = "0x2327EA8", VA = "0x2327EA8")]
		internal void ChangeFont(Font labelsFont)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2327ED0", Offset = "0x2327ED0", VA = "0x2327ED0")]
		internal void ChangeFontSize(int newSize)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x2327F70", Offset = "0x2327F70", VA = "0x2327F70")]
		internal void ChangeOffset(Vector2 newPixelOffset)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x232801C", Offset = "0x232801C", VA = "0x232801C")]
		internal void ChangeLineSpacing(float newValueLineSpacing)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x23280BC", Offset = "0x23280BC", VA = "0x23280BC")]
		internal void ChangeBackground(bool enabled)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x23280DC", Offset = "0x23280DC", VA = "0x23280DC")]
		internal void ChangeBackgroundColor(Color color)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x23280FC", Offset = "0x23280FC", VA = "0x23280FC")]
		public void ChangeBackgroundPadding(int backgroundPadding)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2328118", Offset = "0x2328118", VA = "0x2328118")]
		internal void ChangeShadow(bool enabled)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x2328138", Offset = "0x2328138", VA = "0x2328138")]
		internal void ChangeShadowColor(Color color)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2328158", Offset = "0x2328158", VA = "0x2328158")]
		internal void ChangeShadowDistance(Vector2 distance)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x2328174", Offset = "0x2328174", VA = "0x2328174")]
		internal void ChangeOutline(bool enabled)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x2328194", Offset = "0x2328194", VA = "0x2328194")]
		internal void ChangeOutlineColor(Color color)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x23281B4", Offset = "0x23281B4", VA = "0x23281B4")]
		internal void ChangeOutlineDistance(Vector2 distance)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x2327734", Offset = "0x2327734", VA = "0x2327734")]
		private void UpdateTextPosition()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x2326D18", Offset = "0x2326D18", VA = "0x2326D18")]
		private void NormalizeOffset()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x2327AB4", Offset = "0x2327AB4", VA = "0x2327AB4")]
		private void ApplyBackground()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x23272AC", Offset = "0x23272AC", VA = "0x23272AC")]
		private void ApplyShadow()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x232746C", Offset = "0x232746C", VA = "0x232746C")]
		private void ApplyOutline()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x232762C", Offset = "0x232762C", VA = "0x232762C")]
		private void ApplyFont()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public enum LabelAnchor : byte
	{
		[Token(Token = "0x400040E")]
		UpperLeft,
		[Token(Token = "0x400040F")]
		UpperRight,
		[Token(Token = "0x4000410")]
		LowerLeft,
		[Token(Token = "0x4000411")]
		LowerRight,
		[Token(Token = "0x4000412")]
		UpperCenter,
		[Token(Token = "0x4000413")]
		LowerCenter
	}
	[Token(Token = "0x20000AA")]
	internal class LabelEffect
	{
		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x10")]
		public bool enabled;

		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x14")]
		public Color color;

		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 distance;

		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x2C")]
		public int padding;

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1F181F8", Offset = "0x1F181F8", VA = "0x1F181F8")]
		internal LabelEffect(bool enabled, Color color, int padding)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1F18280", Offset = "0x1F18280", VA = "0x1F18280")]
		internal LabelEffect(bool enabled, Color color, Vector2 distance)
		{
		}
	}
}
namespace CodeStage.AdvancedFPSCounter.CountersData
{
	[Serializable]
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA23060", Offset = "0xA23060")]
	public abstract class BaseCounterData
	{
		[Token(Token = "0x4000418")]
		protected const string BoldStart = "<b>";

		[Token(Token = "0x4000419")]
		protected const string BoldEnd = "</b>";

		[Token(Token = "0x400041A")]
		protected const string ItalicStart = "<i>";

		[Token(Token = "0x400041B")]
		protected const string ItalicEnd = "</i>";

		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x10")]
		internal StringBuilder text;

		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x18")]
		internal bool dirty;

		[NonSerialized]
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x20")]
		protected AFPSCounter main;

		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x28")]
		protected string colorCached;

		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x30")]
		protected bool inited;

		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		protected bool enabled;

		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23E74", Offset = "0xA23E74")]
		protected LabelAnchor anchor;

		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23EC0", Offset = "0xA23EC0")]
		[SerializeField]
		protected Color color;

		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23F0C", Offset = "0xA23F0C")]
		[SerializeField]
		protected FontStyle style;

		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23F58", Offset = "0xA23F58")]
		protected string extraText;

		[Token(Token = "0x1700009A")]
		public bool Enabled
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x1ECB3D8", Offset = "0x1ECB3D8", VA = "0x1ECB3D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x1ECA6D4", Offset = "0x1ECA6D4", VA = "0x1ECA6D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public LabelAnchor Anchor
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x1ECB3E0", Offset = "0x1ECB3E0", VA = "0x1ECB3E0")]
			get
			{
				return default(LabelAnchor);
			}
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x1ECA7FC", Offset = "0x1ECA7FC", VA = "0x1ECA7FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public Color Color
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x1ECB3E8", Offset = "0x1ECB3E8", VA = "0x1ECB3E8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x1ECB3F4", Offset = "0x1ECB3F4", VA = "0x1ECB3F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public FontStyle Style
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x1ECB4F8", Offset = "0x1ECB4F8", VA = "0x1ECB4F8")]
			get
			{
				return default(FontStyle);
			}
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x1ECA750", Offset = "0x1ECA750", VA = "0x1ECA750")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public string ExtraText
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x1ECB500", Offset = "0x1ECB500", VA = "0x1ECB500")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x1ECA7A4", Offset = "0x1ECA7A4", VA = "0x1ECA7A4")]
			set
			{
			}
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1ECB49C", Offset = "0x1ECB49C", VA = "0x1ECB49C")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1ECB508", Offset = "0x1ECB508", VA = "0x1ECB508", Slot = "4")]
		internal virtual void UpdateValue()
		{
		}

		[Token(Token = "0x60003B3")]
		internal abstract void UpdateValue(bool force);

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1ECB518", Offset = "0x1ECB518", VA = "0x1ECB518")]
		internal void Init(AFPSCounter reference)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1EC15D4", Offset = "0x1EC15D4", VA = "0x1EC15D4")]
		internal void Destroy()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1ECB520", Offset = "0x1ECB520", VA = "0x1ECB520", Slot = "6")]
		internal virtual void Activate()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1ECB63C", Offset = "0x1ECB63C", VA = "0x1ECB63C", Slot = "7")]
		internal virtual void Deactivate()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1ECB69C", Offset = "0x1ECB69C", VA = "0x1ECB69C", Slot = "8")]
		protected virtual void PerformInitActions()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1ECB6A0", Offset = "0x1ECB6A0", VA = "0x1ECB6A0", Slot = "9")]
		protected virtual void PerformActivationActions()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1ECB6A4", Offset = "0x1ECB6A4", VA = "0x1ECB6A4", Slot = "10")]
		protected virtual void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x60003BB")]
		protected abstract bool HasData();

		[Token(Token = "0x60003BC")]
		protected abstract void CacheCurrentColor();

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1ECB6A8", Offset = "0x1ECB6A8", VA = "0x1ECB6A8")]
		protected void ApplyTextStyles()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1ECB860", Offset = "0x1ECB860", VA = "0x1ECB860")]
		protected BaseCounterData()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public abstract class UpdatableCounterData : BaseCounterData
	{
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x50")]
		protected Coroutine updateCoroutine;

		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23F90", Offset = "0xA23F90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA23F90", Offset = "0xA23F90")]
		[SerializeField]
		protected float updateInterval;

		[Token(Token = "0x1700009F")]
		public float UpdateInterval
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x24E0708", Offset = "0x24E0708", VA = "0x24E0708")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x24E0710", Offset = "0x24E0710", VA = "0x24E0710")]
			set
			{
			}
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x24E07A0", Offset = "0x24E07A0", VA = "0x24E07A0", Slot = "8")]
		protected override void PerformInitActions()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x24E0814", Offset = "0x24E0814", VA = "0x24E0814", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x60003C3")]
		protected abstract IEnumerator UpdateCounter();

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x24E07C8", Offset = "0x24E07C8", VA = "0x24E07C8")]
		private void StartUpdateCoroutine()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x24E083C", Offset = "0x24E083C", VA = "0x24E083C")]
		private void StopUpdateCoroutine()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x24E0860", Offset = "0x24E0860", VA = "0x24E0860")]
		protected UpdatableCounterData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA23098", Offset = "0xA23098")]
	public class DeviceInfoCounterData : BaseCounterData
	{
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA23FF8", Offset = "0xA23FF8")]
		private bool platform;

		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24044", Offset = "0xA24044")]
		private bool cpuModel;

		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x52")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24090", Offset = "0xA24090")]
		private bool cpuModelNewLine;

		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x53")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA240DC", Offset = "0xA240DC")]
		private bool gpuModel;

		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24128", Offset = "0xA24128")]
		private bool gpuModelNewLine;

		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x55")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24174", Offset = "0xA24174")]
		[SerializeField]
		private bool gpuApi;

		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x56")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA241C0", Offset = "0xA241C0")]
		private bool gpuApiNewLine;

		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x57")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA2420C", Offset = "0xA2420C")]
		[SerializeField]
		private bool gpuSpec;

		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24258", Offset = "0xA24258")]
		[SerializeField]
		private bool gpuSpecNewLine;

		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x59")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA242A4", Offset = "0xA242A4")]
		[SerializeField]
		private bool ramSize;

		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x5A")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA242F0", Offset = "0xA242F0")]
		private bool ramSizeNewLine;

		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x5B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA2433C", Offset = "0xA2433C")]
		[SerializeField]
		private bool screenData;

		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24388", Offset = "0xA24388")]
		[SerializeField]
		private bool screenDataNewLine;

		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x5D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA243D4", Offset = "0xA243D4")]
		[SerializeField]
		private bool deviceModel;

		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x5E")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24420", Offset = "0xA24420")]
		private bool deviceModelNewLine;

		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA2446C", Offset = "0xA2446C")]
		private string <LastValue>k__BackingField;

		[Token(Token = "0x170000A0")]
		public bool Platform
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x232530C", Offset = "0x232530C", VA = "0x232530C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x2325314", Offset = "0x2325314", VA = "0x2325314")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public bool CpuModel
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x2325378", Offset = "0x2325378", VA = "0x2325378")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x2325380", Offset = "0x2325380", VA = "0x2325380")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public bool CpuModelNewLine
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x23253E4", Offset = "0x23253E4", VA = "0x23253E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x23253EC", Offset = "0x23253EC", VA = "0x23253EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public bool GpuModel
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x2325450", Offset = "0x2325450", VA = "0x2325450")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x2325458", Offset = "0x2325458", VA = "0x2325458")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public bool GpuModelNewLine
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x23254BC", Offset = "0x23254BC", VA = "0x23254BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x23254C4", Offset = "0x23254C4", VA = "0x23254C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool GpuApi
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x2325528", Offset = "0x2325528", VA = "0x2325528")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x2325530", Offset = "0x2325530", VA = "0x2325530")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public bool GpuApiNewLine
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x2325594", Offset = "0x2325594", VA = "0x2325594")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x232559C", Offset = "0x232559C", VA = "0x232559C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public bool GpuSpec
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x2325600", Offset = "0x2325600", VA = "0x2325600")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x2325608", Offset = "0x2325608", VA = "0x2325608")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public bool GpuSpecNewLine
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x232566C", Offset = "0x232566C", VA = "0x232566C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x2325674", Offset = "0x2325674", VA = "0x2325674")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public bool RamSize
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x23256D8", Offset = "0x23256D8", VA = "0x23256D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x23256E0", Offset = "0x23256E0", VA = "0x23256E0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public bool RamSizeNewLine
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x2325744", Offset = "0x2325744", VA = "0x2325744")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x232574C", Offset = "0x232574C", VA = "0x232574C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public bool ScreenData
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x23257B0", Offset = "0x23257B0", VA = "0x23257B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x23257B8", Offset = "0x23257B8", VA = "0x23257B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public bool ScreenDataNewLine
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x232581C", Offset = "0x232581C", VA = "0x232581C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x2325824", Offset = "0x2325824", VA = "0x2325824")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public bool DeviceModel
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x2325888", Offset = "0x2325888", VA = "0x2325888")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x2325890", Offset = "0x2325890", VA = "0x2325890")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public bool DeviceModelNewLine
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x23258F4", Offset = "0x23258F4", VA = "0x23258F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x23258FC", Offset = "0x23258FC", VA = "0x23258FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public string LastValue
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x2325960", Offset = "0x2325960", VA = "0x2325960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25200", Offset = "0xA25200")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x2325968", Offset = "0x2325968", VA = "0x2325968")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25210", Offset = "0xA25210")]
			private set
			{
			}
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x2325970", Offset = "0x2325970", VA = "0x2325970")]
		internal DeviceInfoCounterData()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x23259E4", Offset = "0x23259E4", VA = "0x23259E4", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x232638C", Offset = "0x232638C", VA = "0x232638C", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x23263BC", Offset = "0x23263BC", VA = "0x23263BC", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA230D0", Offset = "0xA230D0")]
	public class FPSCounterData : UpdatableCounterData
	{
		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23108", Offset = "0xA23108")]
		private sealed class <UpdateCounter>d__151 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000477")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000478")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000479")]
			[FieldOffset(Offset = "0x20")]
			public FPSCounterData <>4__this;

			[Token(Token = "0x400047A")]
			[FieldOffset(Offset = "0x28")]
			private float <previousUpdateTime>5__2;

			[Token(Token = "0x400047B")]
			[FieldOffset(Offset = "0x2C")]
			private int <previousUpdateFrames>5__3;

			[Token(Token = "0x170000CA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000434")]
				[Address(RVA = "0x24E1094", Offset = "0x24E1094", VA = "0x24E1094", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000436")]
				[Address(RVA = "0x24E10DC", Offset = "0x24E10DC", VA = "0x24E10DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000431")]
			[Address(RVA = "0x24E0F70", Offset = "0x24E0F70", VA = "0x24E0F70")]
			[DebuggerHidden]
			public <UpdateCounter>d__151(int <>1__state)
			{
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x24E0F9C", Offset = "0x24E0F9C", VA = "0x24E0F9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x24E0FA0", Offset = "0x24E0FA0", VA = "0x24E0FA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x24E109C", Offset = "0x24E109C", VA = "0x24E109C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000438")]
		private const string ColorTextStart = "<color=#{0}>";

		[Token(Token = "0x4000439")]
		private const string ColorTextEnd = "</color>";

		[Token(Token = "0x400043A")]
		private const string FPSTextStart = "<color=#{0}>FPS: ";

		[Token(Token = "0x400043B")]
		private const string MsTextStart = " <color=#{0}>[";

		[Token(Token = "0x400043C")]
		private const string MsTextEnd = " MS]</color>";

		[Token(Token = "0x400043D")]
		private const string MinTextStart = "<color=#{0}>MIN: ";

		[Token(Token = "0x400043E")]
		private const string MaxTextStart = "<color=#{0}>MAX: ";

		[Token(Token = "0x400043F")]
		private const string AvgTextStart = "<color=#{0}>AVG: ";

		[Token(Token = "0x4000440")]
		private const string RenderTextStart = "<color=#{0}>REN: ";

		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x5C")]
		public int warningLevelValue;

		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x60")]
		public int criticalLevelValue;

		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA2447C", Offset = "0xA2447C")]
		public bool resetAverageOnNewScene;

		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x65")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA244B4", Offset = "0xA244B4")]
		public bool resetMinMaxOnNewScene;

		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA244EC", Offset = "0xA244EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA244EC", Offset = "0xA244EC")]
		public int minMaxIntervalsToSkip;

		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x78")]
		internal float newValue;

		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x80")]
		private string colorCachedMs;

		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x88")]
		private string colorCachedMin;

		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x90")]
		private string colorCachedMax;

		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x98")]
		private string colorCachedAvg;

		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0xA0")]
		private string colorCachedRender;

		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0xA8")]
		private string colorWarningCached;

		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0xB0")]
		private string colorWarningCachedMs;

		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0xB8")]
		private string colorWarningCachedMin;

		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0xC0")]
		private string colorWarningCachedMax;

		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0xC8")]
		private string colorWarningCachedAvg;

		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0xD0")]
		private string colorCriticalCached;

		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0xD8")]
		private string colorCriticalCachedMs;

		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0xE0")]
		private string colorCriticalCachedMin;

		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0xE8")]
		private string colorCriticalCachedMax;

		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0xF0")]
		private string colorCriticalCachedAvg;

		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0xF8")]
		private int currentAverageSamples;

		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0xFC")]
		private float currentAverageRaw;

		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x100")]
		private float[] accumulatedAverageSamples;

		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x108")]
		private int minMaxIntervalsSkipped;

		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x10C")]
		private float renderTimeBank;

		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x110")]
		private int previousFrameCount;

		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x114")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24550", Offset = "0xA24550")]
		[SerializeField]
		private bool realtimeFPS;

		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x115")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA2459C", Offset = "0xA2459C")]
		[SerializeField]
		private bool milliseconds;

		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x116")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA245E8", Offset = "0xA245E8")]
		[SerializeField]
		private bool average;

		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x117")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24634", Offset = "0xA24634")]
		[SerializeField]
		private bool averageMilliseconds;

		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24680", Offset = "0xA24680")]
		[SerializeField]
		private bool averageNewLine;

		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xA246CC", Offset = "0xA246CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA246CC", Offset = "0xA246CC")]
		private int averageSamples;

		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24734", Offset = "0xA24734")]
		private bool minMax;

		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x121")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24780", Offset = "0xA24780")]
		private bool minMaxMilliseconds;

		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x122")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA247CC", Offset = "0xA247CC")]
		[SerializeField]
		private bool minMaxNewLine;

		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x123")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24818", Offset = "0xA24818")]
		[SerializeField]
		private bool minMaxTwoLines;

		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x124")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24864", Offset = "0xA24864")]
		[SerializeField]
		private bool render;

		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x125")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA248B0", Offset = "0xA248B0")]
		private bool renderNewLine;

		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x126")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA248FC", Offset = "0xA248FC")]
		private bool renderAutoAdd;

		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24948", Offset = "0xA24948")]
		[SerializeField]
		private Color colorWarning;

		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24994", Offset = "0xA24994")]
		[SerializeField]
		private Color colorCritical;

		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA249E0", Offset = "0xA249E0")]
		[SerializeField]
		protected Color colorRender;

		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24A2C", Offset = "0xA24A2C")]
		private int <LastValue>k__BackingField;

		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x15C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24A3C", Offset = "0xA24A3C")]
		private float <LastMillisecondsValue>k__BackingField;

		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24A4C", Offset = "0xA24A4C")]
		private float <LastRenderValue>k__BackingField;

		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24A5C", Offset = "0xA24A5C")]
		private int <LastAverageValue>k__BackingField;

		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24A6C", Offset = "0xA24A6C")]
		private float <LastAverageMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x16C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24A7C", Offset = "0xA24A7C")]
		private int <LastMinimumValue>k__BackingField;

		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24A8C", Offset = "0xA24A8C")]
		private int <LastMaximumValue>k__BackingField;

		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24A9C", Offset = "0xA24A9C")]
		private float <LastMinMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24AAC", Offset = "0xA24AAC")]
		private float <LastMaxMillisecondsValue>k__BackingField;

		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x17C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24ABC", Offset = "0xA24ABC")]
		private FPSLevel <CurrentFpsLevel>k__BackingField;

		[Token(Token = "0x170000B0")]
		public bool RealtimeFPS
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x2328FB4", Offset = "0x2328FB4", VA = "0x2328FB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x2328FBC", Offset = "0x2328FBC", VA = "0x2328FBC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public bool Milliseconds
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x2329028", Offset = "0x2329028", VA = "0x2329028")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x2329030", Offset = "0x2329030", VA = "0x2329030")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public bool Average
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x232909C", Offset = "0x232909C", VA = "0x232909C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x23290A4", Offset = "0x23290A4", VA = "0x23290A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public bool AverageMilliseconds
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x2329170", Offset = "0x2329170", VA = "0x2329170")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x2329178", Offset = "0x2329178", VA = "0x2329178")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public bool AverageNewLine
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x23291E4", Offset = "0x23291E4", VA = "0x23291E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x23291EC", Offset = "0x23291EC", VA = "0x23291EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public int AverageSamples
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x2329250", Offset = "0x2329250", VA = "0x2329250")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x2329258", Offset = "0x2329258", VA = "0x2329258")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public bool MinMax
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x232934C", Offset = "0x232934C", VA = "0x232934C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x2329354", Offset = "0x2329354", VA = "0x2329354")]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public bool MinMaxMilliseconds
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x232941C", Offset = "0x232941C", VA = "0x232941C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x2329424", Offset = "0x2329424", VA = "0x2329424")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public bool MinMaxNewLine
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x23294B0", Offset = "0x23294B0", VA = "0x23294B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x23294B8", Offset = "0x23294B8", VA = "0x23294B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public bool MinMaxTwoLines
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x232951C", Offset = "0x232951C", VA = "0x232951C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x2329524", Offset = "0x2329524", VA = "0x2329524")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public bool Render
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x2329588", Offset = "0x2329588", VA = "0x2329588")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x2329590", Offset = "0x2329590", VA = "0x2329590")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public bool RenderNewLine
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x232982C", Offset = "0x232982C", VA = "0x232982C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x2329834", Offset = "0x2329834", VA = "0x2329834")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public bool RenderAutoAdd
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x2329898", Offset = "0x2329898", VA = "0x2329898")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x23298A0", Offset = "0x23298A0", VA = "0x23298A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public Color ColorWarning
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x2329908", Offset = "0x2329908", VA = "0x2329908")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x232991C", Offset = "0x232991C", VA = "0x232991C")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public Color ColorCritical
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x2329AF4", Offset = "0x2329AF4", VA = "0x2329AF4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x2329B08", Offset = "0x2329B08", VA = "0x2329B08")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public Color ColorRender
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x2329CE0", Offset = "0x2329CE0", VA = "0x2329CE0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x2329CF4", Offset = "0x2329CF4", VA = "0x2329CF4")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public int LastValue
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x2329DB0", Offset = "0x2329DB0", VA = "0x2329DB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25240", Offset = "0xA25240")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x2329DB8", Offset = "0x2329DB8", VA = "0x2329DB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25250", Offset = "0xA25250")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public float LastMillisecondsValue
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x2329DC0", Offset = "0x2329DC0", VA = "0x2329DC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25260", Offset = "0xA25260")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x2329DC8", Offset = "0x2329DC8", VA = "0x2329DC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25270", Offset = "0xA25270")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public float LastRenderValue
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x2329DD0", Offset = "0x2329DD0", VA = "0x2329DD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25280", Offset = "0xA25280")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x2329DD8", Offset = "0x2329DD8", VA = "0x2329DD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25290", Offset = "0xA25290")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public int LastAverageValue
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x2329DE0", Offset = "0x2329DE0", VA = "0x2329DE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA252A0", Offset = "0xA252A0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x2329DE8", Offset = "0x2329DE8", VA = "0x2329DE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA252B0", Offset = "0xA252B0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public float LastAverageMillisecondsValue
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x2329DF0", Offset = "0x2329DF0", VA = "0x2329DF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA252C0", Offset = "0xA252C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x2329DF8", Offset = "0x2329DF8", VA = "0x2329DF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA252D0", Offset = "0xA252D0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public int LastMinimumValue
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x2329E00", Offset = "0x2329E00", VA = "0x2329E00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA252E0", Offset = "0xA252E0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x2329E08", Offset = "0x2329E08", VA = "0x2329E08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA252F0", Offset = "0xA252F0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public int LastMaximumValue
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x2329E10", Offset = "0x2329E10", VA = "0x2329E10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25300", Offset = "0xA25300")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x2329E18", Offset = "0x2329E18", VA = "0x2329E18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25310", Offset = "0xA25310")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public float LastMinMillisecondsValue
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x2329E20", Offset = "0x2329E20", VA = "0x2329E20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25320", Offset = "0xA25320")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x2329E28", Offset = "0x2329E28", VA = "0x2329E28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25330", Offset = "0xA25330")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public float LastMaxMillisecondsValue
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x2329E30", Offset = "0x2329E30", VA = "0x2329E30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25340", Offset = "0xA25340")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x2329E38", Offset = "0x2329E38", VA = "0x2329E38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25350", Offset = "0xA25350")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public FPSLevel CurrentFpsLevel
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x2329E40", Offset = "0x2329E40", VA = "0x2329E40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25360", Offset = "0xA25360")]
			get
			{
				return default(FPSLevel);
			}
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x2329E48", Offset = "0x2329E48", VA = "0x2329E48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25370", Offset = "0xA25370")]
			private set
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event Action<FPSLevel> OnFPSLevelChange
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x2328E74", Offset = "0x2328E74", VA = "0x2328E74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25220", Offset = "0xA25220")]
			add
			{
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x2328F14", Offset = "0x2328F14", VA = "0x2328F14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25230", Offset = "0xA25230")]
			remove
			{
			}
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x2329E50", Offset = "0x2329E50", VA = "0x2329E50")]
		internal FPSCounterData()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x2329114", Offset = "0x2329114", VA = "0x2329114")]
		public void ResetAverage()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x23293C8", Offset = "0x23293C8", VA = "0x23293C8")]
		public void ResetMinMax(bool withoutUpdate = false)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x2329FB4", Offset = "0x2329FB4", VA = "0x2329FB4")]
		internal void OnLevelLoadedCallback()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x232A020", Offset = "0x232A020", VA = "0x232A020")]
		internal void AddRenderTime(float time)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x232A040", Offset = "0x232A040", VA = "0x232A040", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x232AB14", Offset = "0x232AB14", VA = "0x232AB14", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x232AC24", Offset = "0x232AC24", VA = "0x232AC24", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x232AC64", Offset = "0x232AC64", VA = "0x232AC64", Slot = "13")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA25380", Offset = "0xA25380")]
		protected override IEnumerator UpdateCounter()
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x232ACD0", Offset = "0x232ACD0", VA = "0x232ACD0", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x232ACD8", Offset = "0x232ACD8", VA = "0x232ACD8", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x23299D0", Offset = "0x23299D0", VA = "0x23299D0")]
		protected void CacheWarningColor()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x2329BBC", Offset = "0x2329BBC", VA = "0x2329BBC")]
		protected void CacheCriticalColor()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x232AA98", Offset = "0x232AA98", VA = "0x232AA98")]
		private float GetAverageFromAccumulatedSamples()
		{
			return default(float);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x2329720", Offset = "0x2329720", VA = "0x2329720")]
		private static void TryToAddRenderRecorder()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x232961C", Offset = "0x232961C", VA = "0x232961C")]
		private static void TryToRemoveRenderRecorder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xA23118", Offset = "0xA23118")]
	public class MemoryCounterData : UpdatableCounterData
	{
		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA23150", Offset = "0xA23150")]
		private sealed class <UpdateCounter>d__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400048C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400048D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400048E")]
			[FieldOffset(Offset = "0x20")]
			public MemoryCounterData <>4__this;

			[Token(Token = "0x400048F")]
			[FieldOffset(Offset = "0x28")]
			private float <previousUpdateTime>5__2;

			[Token(Token = "0x170000D5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000453")]
				[Address(RVA = "0x24E2C98", Offset = "0x24E2C98", VA = "0x24E2C98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000455")]
				[Address(RVA = "0x24E2CE0", Offset = "0x24E2CE0", VA = "0x24E2CE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0x24E2BB0", Offset = "0x24E2BB0", VA = "0x24E2BB0")]
			[DebuggerHidden]
			public <UpdateCounter>d__47(int <>1__state)
			{
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0x24E2BDC", Offset = "0x24E2BDC", VA = "0x24E2BDC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000452")]
			[Address(RVA = "0x24E2BE0", Offset = "0x24E2BE0", VA = "0x24E2BE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x24E2CA0", Offset = "0x24E2CA0", VA = "0x24E2CA0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400047C")]
		public const long MemoryDivider = 1048576L;

		[Token(Token = "0x400047D")]
		private const string TextStart = "<color=#{0}>";

		[Token(Token = "0x400047E")]
		private const string LineStartTotal = "MEM TOTAL: ";

		[Token(Token = "0x400047F")]
		private const string LineStartAllocated = "MEM ALLOC: ";

		[Token(Token = "0x4000480")]
		private const string LineStartMono = "MEM MONO: ";

		[Token(Token = "0x4000481")]
		private const string LineEnd = " MB";

		[Token(Token = "0x4000482")]
		private const string TextEnd = "</color>";

		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24ACC", Offset = "0xA24ACC")]
		private bool precise;

		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x5D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24B18", Offset = "0xA24B18")]
		[SerializeField]
		private bool total;

		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x5E")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24B64", Offset = "0xA24B64")]
		private bool allocated;

		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x5F")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24BB0", Offset = "0xA24BB0")]
		private bool monoUsage;

		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xA24BFC", Offset = "0xA24BFC")]
		private bool gfx;

		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24C48", Offset = "0xA24C48")]
		private long <LastTotalValue>k__BackingField;

		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24C58", Offset = "0xA24C58")]
		private long <LastAllocatedValue>k__BackingField;

		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24C68", Offset = "0xA24C68")]
		private long <LastMonoValue>k__BackingField;

		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA24C78", Offset = "0xA24C78")]
		private long <LastGfxValue>k__BackingField;

		[Token(Token = "0x170000CC")]
		public bool Precise
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x1F18600", Offset = "0x1F18600", VA = "0x1F18600")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x1F18608", Offset = "0x1F18608", VA = "0x1F18608")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public bool Total
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x1F1866C", Offset = "0x1F1866C", VA = "0x1F1866C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x1F18674", Offset = "0x1F18674", VA = "0x1F18674")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public bool Allocated
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x1F186E0", Offset = "0x1F186E0", VA = "0x1F186E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x1F186E8", Offset = "0x1F186E8", VA = "0x1F186E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public bool MonoUsage
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x1F18754", Offset = "0x1F18754", VA = "0x1F18754")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x1F1875C", Offset = "0x1F1875C", VA = "0x1F1875C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public bool Gfx
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x1F187C8", Offset = "0x1F187C8", VA = "0x1F187C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x1F187D0", Offset = "0x1F187D0", VA = "0x1F187D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public long LastTotalValue
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x1F1883C", Offset = "0x1F1883C", VA = "0x1F1883C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25430", Offset = "0xA25430")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x1F18844", Offset = "0x1F18844", VA = "0x1F18844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25440", Offset = "0xA25440")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public long LastAllocatedValue
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x1F1884C", Offset = "0x1F1884C", VA = "0x1F1884C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25450", Offset = "0xA25450")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x1F18854", Offset = "0x1F18854", VA = "0x1F18854")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25460", Offset = "0xA25460")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public long LastMonoValue
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x1F1885C", Offset = "0x1F1885C", VA = "0x1F1885C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25470", Offset = "0xA25470")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x1F18864", Offset = "0x1F18864", VA = "0x1F18864")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25480", Offset = "0xA25480")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public long LastGfxValue
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x1F1886C", Offset = "0x1F1886C", VA = "0x1F1886C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA25490", Offset = "0xA25490")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x1F18874", Offset = "0x1F18874", VA = "0x1F18874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xA254A0", Offset = "0xA254A0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1F1887C", Offset = "0x1F1887C", VA = "0x1F1887C")]
		internal MemoryCounterData()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1F188F4", Offset = "0x1F188F4", VA = "0x1F188F4", Slot = "5")]
		internal override void UpdateValue(bool force)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1F18DD8", Offset = "0x1F18DD8", VA = "0x1F18DD8", Slot = "9")]
		protected override void PerformActivationActions()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1F190CC", Offset = "0x1F190CC", VA = "0x1F190CC", Slot = "10")]
		protected override void PerformDeActivationActions()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1F19118", Offset = "0x1F19118", VA = "0x1F19118", Slot = "13")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xA254B0", Offset = "0xA254B0")]
		protected override IEnumerator UpdateCounter()
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1F19184", Offset = "0x1F19184", VA = "0x1F19184", Slot = "11")]
		protected override bool HasData()
		{
			return default(bool);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1F191B4", Offset = "0x1F191B4", VA = "0x1F191B4", Slot = "12")]
		protected override void CacheCurrentColor()
		{
		}
	}
}
