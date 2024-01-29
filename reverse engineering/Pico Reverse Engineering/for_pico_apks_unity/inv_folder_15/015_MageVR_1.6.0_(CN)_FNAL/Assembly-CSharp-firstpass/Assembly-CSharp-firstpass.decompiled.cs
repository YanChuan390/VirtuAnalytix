using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class DoNotDestroyOnLoad_perName : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<string> list;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xA09D98", Offset = "0xA09D98", VA = "0xA09D98")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xA09EA0", Offset = "0xA09EA0", VA = "0xA09EA0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xA09F9C", Offset = "0xA09F9C", VA = "0xA09F9C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xA09FA0", Offset = "0xA09FA0", VA = "0xA09FA0")]
	public DoNotDestroyOnLoad_perName()
	{
	}
}
[Token(Token = "0x2000003")]
public class ExampleCam : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public MouseOrbitImproved mouseOrbit;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<MonoBehaviour> ImageEffectsList;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xA0A030", Offset = "0xA0A030", VA = "0xA0A030")]
	private void Start()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xA0A034", Offset = "0xA0A034", VA = "0xA0A034")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xA0A038", Offset = "0xA0A038", VA = "0xA0A038")]
	public ExampleCam()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x53D3CC", Offset = "0x53D3CC")]
public class ExampleUI : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Text displayedName;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private InterfaceAnimManager current;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int indexInterface;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InterfaceAnimManager[] holoInterfaceList;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private ExampleCam currentCam;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string searchTarget;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public string searchCam;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int indexScene;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool allDelaysStatus;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	private static bool allImgEffectsStatus;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public List<string> loadableScenes;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject fullscreenSwith;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public AudioSource audioSource;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xA0A0BC", Offset = "0xA0A0BC", VA = "0xA0A0BC")]
	private void Start()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xA0A694", Offset = "0xA0A694", VA = "0xA0A694")]
	private void playSound()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xA0A760", Offset = "0xA0A760", VA = "0xA0A760")]
	public void DoOutFullscreen()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xA0A794", Offset = "0xA0A794", VA = "0xA0A794")]
	public void DoChangeEnvironment()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xA0A878", Offset = "0xA0A878", VA = "0xA0A878")]
	private void OnLevelWasLoaded()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xA0A318", Offset = "0xA0A318", VA = "0xA0A318")]
	private void InitCam()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xA0A87C", Offset = "0xA0A87C", VA = "0xA0A87C")]
	public void DoSwitchAutoCam()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xA0A8F0", Offset = "0xA0A8F0", VA = "0xA0A8F0")]
	public void DoSwitchCameraEffects()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xA0AB2C", Offset = "0xA0AB2C", VA = "0xA0AB2C")]
	public void DoSwitchAnimDelays()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xA0ACC4", Offset = "0xA0ACC4", VA = "0xA0ACC4")]
	public void DoAppear()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xA0ADB8", Offset = "0xA0ADB8", VA = "0xA0ADB8")]
	public void DoDisappear()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xA0AE70", Offset = "0xA0AE70", VA = "0xA0AE70")]
	public void DoNext()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xA0AEF0", Offset = "0xA0AEF0", VA = "0xA0AEF0")]
	public void DoPrevious()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xA0A1BC", Offset = "0xA0A1BC", VA = "0xA0A1BC")]
	private void CallInterface(InterfaceAnimManager _interface)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xA0AF74", Offset = "0xA0AF74", VA = "0xA0AF74")]
	public void UpdateDisplayedInfo()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xA0B09C", Offset = "0xA0B09C", VA = "0xA0B09C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xA0B0D4", Offset = "0xA0B0D4", VA = "0xA0B0D4")]
	public ExampleUI()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x53D400", Offset = "0x53D400")]
public class ExcelsiorUtils : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GameObject target;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AudioSource audioSource;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public AudioClip audioClip;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text textContent;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Slider slider;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xA0B1E8", Offset = "0xA0B1E8", VA = "0xA0B1E8")]
	private void Start()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xA0B1EC", Offset = "0xA0B1EC", VA = "0xA0B1EC")]
	private void playSound()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xA0B2D8", Offset = "0xA0B2D8", VA = "0xA0B2D8")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xA0B2DC", Offset = "0xA0B2DC", VA = "0xA0B2DC")]
	public void SetPosition(int _scaleValue)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xA0B3D4", Offset = "0xA0B3D4", VA = "0xA0B3D4")]
	public void SetPositionAndScaleTo(GameObject _object)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xA0B570", Offset = "0xA0B570", VA = "0xA0B570")]
	public void SetUniformScale(int _scaleValue)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xA0B668", Offset = "0xA0B668", VA = "0xA0B668")]
	public void SetUniformWidthHeight(int _widthHeightValue)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xA0B7C8", Offset = "0xA0B7C8", VA = "0xA0B7C8")]
	public void SetImageColor(int _colorID)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xA0B8E8", Offset = "0xA0B8E8", VA = "0xA0B8E8")]
	public void OpenWebPage()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xA0B94C", Offset = "0xA0B94C", VA = "0xA0B94C")]
	public void GetSliderValue_ToText()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xA0B9C8", Offset = "0xA0B9C8", VA = "0xA0B9C8")]
	public ExcelsiorUtils()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x53D434", Offset = "0x53D434")]
public class InterfaceAnimManager : MonoBehaviour
{
	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x53D468", Offset = "0x53D468")]
	private sealed class <Disable_OnDisappearEnd>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <>1__state;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private object <>2__current;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InterfaceAnimManager <>4__this;

		[Token(Token = "0x1700000D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0xA0FAA4", Offset = "0xA0FAA4", VA = "0xA0FAA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0xA0FB24", Offset = "0xA0FB24", VA = "0xA0FB24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xA0E780", Offset = "0xA0E780", VA = "0xA0E780")]
		[DebuggerHidden]
		public <Disable_OnDisappearEnd>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xA0F590", Offset = "0xA0F590", VA = "0xA0F590", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xA0F594", Offset = "0xA0F594", VA = "0xA0F594", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xA0FAAC", Offset = "0xA0FAAC", VA = "0xA0FAAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x53D478", Offset = "0x53D478")]
	private sealed class <>c
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Func<InterfaceAnmElement, int> <>9__27_0;

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xA0F568", Offset = "0xA0F568", VA = "0xA0F568")]
		public <>c()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xA0F570", Offset = "0xA0F570", VA = "0xA0F570")]
		internal int <UpdateAnimClips>b__27_0(InterfaceAnmElement x)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public List<InterfaceAnmElement> elementsList;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool autoStart;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool invertDelays;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool cloneDelays;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float timer;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int timeBetweenLoops;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool testLoop;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool autoLinearAppearDelay;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float appearDelay_SpeedMultiplier;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float disappearDelay_SpeedMultiplier;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public CSFHIAnimableState currentState;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool useDelays;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioSource audioSource;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public AudioClip openSound;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioClip closeSound;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public List<InterfaceAnimManager> nestedIAM;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool waitAppear_Nested;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool waitDisappear_Nested;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private InterfaceAnmElement waitElementFullAnim;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xA0B9D0", Offset = "0xA0B9D0", VA = "0xA0B9D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xA0BA30", Offset = "0xA0BA30", VA = "0xA0BA30")]
	private void Start()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xA0CE70", Offset = "0xA0CE70", VA = "0xA0CE70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xA0E240", Offset = "0xA0E240", VA = "0xA0E240")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x53D4A8", Offset = "0x53D4A8")]
	public IEnumerator Disable_OnDisappearEnd()
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xA0E7A0", Offset = "0xA0E7A0", VA = "0xA0E7A0", Slot = "4")]
	public virtual void startAppear(bool direct = false)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xA0E22C", Offset = "0xA0E22C", VA = "0xA0E22C")]
	private void endAppear()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xA0EC9C", Offset = "0xA0EC9C", VA = "0xA0EC9C", Slot = "5")]
	public virtual void startDisappear(bool direct = false)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xA0E2C0", Offset = "0xA0E2C0", VA = "0xA0E2C0")]
	private void endDisappear()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xA0BA98", Offset = "0xA0BA98", VA = "0xA0BA98")]
	public void UpdateAnimClips()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xA0EEB0", Offset = "0xA0EEB0", VA = "0xA0EEB0")]
	public bool isIAM_Root()
	{
		return default(bool);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xA0F418", Offset = "0xA0F418", VA = "0xA0F418")]
	public InterfaceAnimManager()
	{
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public enum CSFHIAnimableState
{
	[Token(Token = "0x400002A")]
	appearing,
	[Token(Token = "0x400002B")]
	appeared,
	[Token(Token = "0x400002C")]
	disappearing,
	[Token(Token = "0x400002D")]
	disappeared
}
[Serializable]
[Token(Token = "0x2000008")]
public class InterfaceAnmElement : MonoBehaviour
{
	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public GameObject gameObjectRef;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float timeAppear;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float timeDisappear;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool recycling;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int sortID;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator animator;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public AnimationClip[] animClips;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<InterfaceAnmElement> list;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public CSFHIAnimableState currentState;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool isNested_IAM;

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xA0EFF8", Offset = "0xA0EFF8", VA = "0xA0EFF8")]
	public static InterfaceAnmElement Create(GameObject _gameObjectRef, int _newSortID, bool _isNested_IAM)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xA0FB2C", Offset = "0xA0FB2C", VA = "0xA0FB2C", Slot = "4")]
	public virtual InterfaceAnmElement Confirm(GameObject _gameObjectRef, int _newSortID, bool isNested_IAM)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xA0F288", Offset = "0xA0F288", VA = "0xA0F288")]
	public void UpdateProperties()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xA0FC80", Offset = "0xA0FC80", VA = "0xA0FC80", Slot = "5")]
	public virtual void Delete()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xA0FCB0", Offset = "0xA0FCB0", VA = "0xA0FCB0")]
	public void Update()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xA0FD90", Offset = "0xA0FD90", VA = "0xA0FD90")]
	public InterfaceAnmElement()
	{
	}
}
[Token(Token = "0x2000009")]
public class MouseOrbitImproved : MonoBehaviour
{
	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Transform target;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float distance;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float xSpeed;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float ySpeed;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float yMinLimit;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float yMaxLimit;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float distanceMin;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float distanceMax;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float smoothTime;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float rotationYAxis;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float rotationXAxis;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float velocityX;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float velocityY;

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x130E288", Offset = "0x130E288", VA = "0x130E288")]
	private void Start()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x130E394", Offset = "0x130E394", VA = "0x130E394")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x130E890", Offset = "0x130E890", VA = "0x130E890")]
	public static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x130E958", Offset = "0x130E958", VA = "0x130E958")]
	public MouseOrbitImproved()
	{
	}
}
[Token(Token = "0x200000A")]
public enum TweenAction
{
	[Token(Token = "0x4000046")]
	MOVE_X,
	[Token(Token = "0x4000047")]
	MOVE_Y,
	[Token(Token = "0x4000048")]
	MOVE_Z,
	[Token(Token = "0x4000049")]
	MOVE_LOCAL_X,
	[Token(Token = "0x400004A")]
	MOVE_LOCAL_Y,
	[Token(Token = "0x400004B")]
	MOVE_LOCAL_Z,
	[Token(Token = "0x400004C")]
	MOVE_CURVED,
	[Token(Token = "0x400004D")]
	MOVE_CURVED_LOCAL,
	[Token(Token = "0x400004E")]
	MOVE_SPLINE,
	[Token(Token = "0x400004F")]
	MOVE_SPLINE_LOCAL,
	[Token(Token = "0x4000050")]
	SCALE_X,
	[Token(Token = "0x4000051")]
	SCALE_Y,
	[Token(Token = "0x4000052")]
	SCALE_Z,
	[Token(Token = "0x4000053")]
	ROTATE_X,
	[Token(Token = "0x4000054")]
	ROTATE_Y,
	[Token(Token = "0x4000055")]
	ROTATE_Z,
	[Token(Token = "0x4000056")]
	ROTATE_AROUND,
	[Token(Token = "0x4000057")]
	ROTATE_AROUND_LOCAL,
	[Token(Token = "0x4000058")]
	CANVAS_ROTATEAROUND,
	[Token(Token = "0x4000059")]
	CANVAS_ROTATEAROUND_LOCAL,
	[Token(Token = "0x400005A")]
	CANVAS_PLAYSPRITE,
	[Token(Token = "0x400005B")]
	ALPHA,
	[Token(Token = "0x400005C")]
	TEXT_ALPHA,
	[Token(Token = "0x400005D")]
	CANVAS_ALPHA,
	[Token(Token = "0x400005E")]
	ALPHA_VERTEX,
	[Token(Token = "0x400005F")]
	COLOR,
	[Token(Token = "0x4000060")]
	CALLBACK_COLOR,
	[Token(Token = "0x4000061")]
	TEXT_COLOR,
	[Token(Token = "0x4000062")]
	CANVAS_COLOR,
	[Token(Token = "0x4000063")]
	CANVAS_MOVE_X,
	[Token(Token = "0x4000064")]
	CANVAS_MOVE_Y,
	[Token(Token = "0x4000065")]
	CANVAS_MOVE_Z,
	[Token(Token = "0x4000066")]
	CALLBACK,
	[Token(Token = "0x4000067")]
	MOVE,
	[Token(Token = "0x4000068")]
	MOVE_LOCAL,
	[Token(Token = "0x4000069")]
	ROTATE,
	[Token(Token = "0x400006A")]
	ROTATE_LOCAL,
	[Token(Token = "0x400006B")]
	SCALE,
	[Token(Token = "0x400006C")]
	VALUE3,
	[Token(Token = "0x400006D")]
	GUI_MOVE,
	[Token(Token = "0x400006E")]
	GUI_MOVE_MARGIN,
	[Token(Token = "0x400006F")]
	GUI_SCALE,
	[Token(Token = "0x4000070")]
	GUI_ALPHA,
	[Token(Token = "0x4000071")]
	GUI_ROTATE,
	[Token(Token = "0x4000072")]
	DELAYED_SOUND,
	[Token(Token = "0x4000073")]
	CANVAS_MOVE,
	[Token(Token = "0x4000074")]
	CANVAS_SCALE
}
[Token(Token = "0x200000B")]
public enum LeanTweenType
{
	[Token(Token = "0x4000076")]
	notUsed,
	[Token(Token = "0x4000077")]
	linear,
	[Token(Token = "0x4000078")]
	easeOutQuad,
	[Token(Token = "0x4000079")]
	easeInQuad,
	[Token(Token = "0x400007A")]
	easeInOutQuad,
	[Token(Token = "0x400007B")]
	easeInCubic,
	[Token(Token = "0x400007C")]
	easeOutCubic,
	[Token(Token = "0x400007D")]
	easeInOutCubic,
	[Token(Token = "0x400007E")]
	easeInQuart,
	[Token(Token = "0x400007F")]
	easeOutQuart,
	[Token(Token = "0x4000080")]
	easeInOutQuart,
	[Token(Token = "0x4000081")]
	easeInQuint,
	[Token(Token = "0x4000082")]
	easeOutQuint,
	[Token(Token = "0x4000083")]
	easeInOutQuint,
	[Token(Token = "0x4000084")]
	easeInSine,
	[Token(Token = "0x4000085")]
	easeOutSine,
	[Token(Token = "0x4000086")]
	easeInOutSine,
	[Token(Token = "0x4000087")]
	easeInExpo,
	[Token(Token = "0x4000088")]
	easeOutExpo,
	[Token(Token = "0x4000089")]
	easeInOutExpo,
	[Token(Token = "0x400008A")]
	easeInCirc,
	[Token(Token = "0x400008B")]
	easeOutCirc,
	[Token(Token = "0x400008C")]
	easeInOutCirc,
	[Token(Token = "0x400008D")]
	easeInBounce,
	[Token(Token = "0x400008E")]
	easeOutBounce,
	[Token(Token = "0x400008F")]
	easeInOutBounce,
	[Token(Token = "0x4000090")]
	easeInBack,
	[Token(Token = "0x4000091")]
	easeOutBack,
	[Token(Token = "0x4000092")]
	easeInOutBack,
	[Token(Token = "0x4000093")]
	easeInElastic,
	[Token(Token = "0x4000094")]
	easeOutElastic,
	[Token(Token = "0x4000095")]
	easeInOutElastic,
	[Token(Token = "0x4000096")]
	easeSpring,
	[Token(Token = "0x4000097")]
	easeShake,
	[Token(Token = "0x4000098")]
	punch,
	[Token(Token = "0x4000099")]
	once,
	[Token(Token = "0x400009A")]
	clamp,
	[Token(Token = "0x400009B")]
	pingPong,
	[Token(Token = "0x400009C")]
	animationCurve
}
[Token(Token = "0x200000C")]
public class LTDescr
{
	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public bool toggle;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
	public bool useEstimatedTime;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
	public bool useFrames;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
	public bool useManualTime;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool hasInitiliazed;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	public bool hasPhysics;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
	public bool onCompleteOnRepeat;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
	public bool onCompleteOnStart;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float passed;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float delay;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float time;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float lastVal;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private uint _id;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int loopCount;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint counter;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float direction;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float directionLast;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float overshoot;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float period;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool destroyOnComplete;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform trans;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public LTRect ltRect;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 from;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 to;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 diff;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 point;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector3 axis;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public Quaternion origRotation;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public LTBezierPath path;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LTSpline spline;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public TweenAction type;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public LeanTweenType tweenType;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public LeanTweenType loopType;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public bool hasUpdateCallback;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Action<float> onUpdateFloat;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public Action<float, float> onUpdateFloatRatio;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Action<float, object> onUpdateFloatObject;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public Action<Vector2> onUpdateVector2;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Action<Vector3> onUpdateVector3;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public Action<Vector3, object> onUpdateVector3Object;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Action<Color> onUpdateColor;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public Action onComplete;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Action<object> onCompleteObject;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public object onCompleteParam;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public object onUpdateParam;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public Action onStart;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public RectTransform rectTransform;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public Text uiText;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Image uiImage;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	public Sprite[] sprites;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static uint global_counter;

	[Token(Token = "0x17000001")]
	public int uniqueId
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0xA12128", Offset = "0xA12128", VA = "0xA12128")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000002")]
	public int id
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0xA1201C", Offset = "0xA1201C", VA = "0xA1201C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xA115DC", Offset = "0xA115DC", VA = "0xA115DC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xA1202C", Offset = "0xA1202C", VA = "0xA1202C")]
	public LTDescr()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xA12034", Offset = "0xA12034", VA = "0xA12034")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x53D518", Offset = "0x53D518")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xA12230", Offset = "0xA12230", VA = "0xA12230")]
	public void reset()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xA123C8", Offset = "0xA123C8", VA = "0xA123C8")]
	public void cleanup()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xA123F8", Offset = "0xA123F8", VA = "0xA123F8")]
	public void init()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xA148C8", Offset = "0xA148C8", VA = "0xA148C8")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xA14990", Offset = "0xA14990", VA = "0xA14990")]
	public LTDescr pause()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xA149AC", Offset = "0xA149AC", VA = "0xA149AC")]
	public LTDescr resume()
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xA149B8", Offset = "0xA149B8", VA = "0xA149B8")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xA149C4", Offset = "0xA149C4", VA = "0xA149C4")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xA149CC", Offset = "0xA149CC", VA = "0xA149CC")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xA149D4", Offset = "0xA149D4", VA = "0xA149D4")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xA149DC", Offset = "0xA149DC", VA = "0xA149DC")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xA149E4", Offset = "0xA149E4", VA = "0xA149E4")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xA149EC", Offset = "0xA149EC", VA = "0xA149EC")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xA14AC4", Offset = "0xA14AC4", VA = "0xA14AC4")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xA14BE0", Offset = "0xA14BE0", VA = "0xA14BE0")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xA14C2C", Offset = "0xA14C2C", VA = "0xA14C2C")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xA14C38", Offset = "0xA14C38", VA = "0xA14C38")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xA14C40", Offset = "0xA14C40", VA = "0xA14C40")]
	public LTDescr setId(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xA14CCC", Offset = "0xA14CCC", VA = "0xA14CCC")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xA14CD4", Offset = "0xA14CD4", VA = "0xA14CD4")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xA14D20", Offset = "0xA14D20", VA = "0xA14D20")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xA14D28", Offset = "0xA14D28", VA = "0xA14D28")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xA14D30", Offset = "0xA14D30", VA = "0xA14D30")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xA14D38", Offset = "0xA14D38", VA = "0xA14D38")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xA14D40", Offset = "0xA14D40", VA = "0xA14D40")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xA14D48", Offset = "0xA14D48", VA = "0xA14D48")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xA14D50", Offset = "0xA14D50", VA = "0xA14D50")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xA14D5C", Offset = "0xA14D5C", VA = "0xA14D5C")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xA14D78", Offset = "0xA14D78", VA = "0xA14D78")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xA14D80", Offset = "0xA14D80", VA = "0xA14D80")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xA14D9C", Offset = "0xA14D9C", VA = "0xA14D9C")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xA14DD4", Offset = "0xA14DD4", VA = "0xA14DD4")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xA14DDC", Offset = "0xA14DDC", VA = "0xA14DDC")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xA14DE4", Offset = "0xA14DE4", VA = "0xA14DE4")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xA14DF4", Offset = "0xA14DF4", VA = "0xA14DF4")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xA14DFC", Offset = "0xA14DFC", VA = "0xA14DFC")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xA14E0C", Offset = "0xA14E0C", VA = "0xA14E0C")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xA14E1C", Offset = "0xA14E1C", VA = "0xA14E1C")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xA14E2C", Offset = "0xA14E2C", VA = "0xA14E2C")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xA14E3C", Offset = "0xA14E3C", VA = "0xA14E3C")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xA14E4C", Offset = "0xA14E4C", VA = "0xA14E4C")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xA14E5C", Offset = "0xA14E5C", VA = "0xA14E5C")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xA14E6C", Offset = "0xA14E6C", VA = "0xA14E6C")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xA14E84", Offset = "0xA14E84", VA = "0xA14E84")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xA14E9C", Offset = "0xA14E9C", VA = "0xA14E9C")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xA14EB4", Offset = "0xA14EB4", VA = "0xA14EB4")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xA14ECC", Offset = "0xA14ECC", VA = "0xA14ECC")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xA14ED4", Offset = "0xA14ED4", VA = "0xA14ED4")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xA14F88", Offset = "0xA14F88", VA = "0xA14F88")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xA14FE0", Offset = "0xA14FE0", VA = "0xA14FE0")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xA14FE8", Offset = "0xA14FE8", VA = "0xA14FE8")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xA15130", Offset = "0xA15130", VA = "0xA15130")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xA15138", Offset = "0xA15138", VA = "0xA15138")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xA15144", Offset = "0xA15144", VA = "0xA15144")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xA1514C", Offset = "0xA1514C", VA = "0xA1514C")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xA14D18", Offset = "0xA14D18", VA = "0xA14D18")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xA15154", Offset = "0xA15154", VA = "0xA15154")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xA1515C", Offset = "0xA1515C", VA = "0xA1515C")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xA15164", Offset = "0xA15164", VA = "0xA15164")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xA1516C", Offset = "0xA1516C", VA = "0xA1516C")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xA151AC", Offset = "0xA151AC", VA = "0xA151AC")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xA151B4", Offset = "0xA151B4", VA = "0xA151B4")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}
}
[Token(Token = "0x200000D")]
public class LTUtility
{
	[Token(Token = "0x6000080")]
	[Address(RVA = "0xA153F4", Offset = "0xA153F4", VA = "0xA153F4")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xA19FB8", Offset = "0xA19FB8", VA = "0xA19FB8")]
	public LTUtility()
	{
	}
}
[Token(Token = "0x200000E")]
public class LeanTween : MonoBehaviour
{
	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool throwErrors;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float tau;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static LTDescr[] tweens;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int[] tweensFinished;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTDescr tween;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static int tweenMaxSearch;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int maxTweens;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static int frameRendered;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static GameObject _tweenEmpty;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static float dtEstimated;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static float dtManual;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static float dt;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static float dtActual;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static int i;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static int j;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static int finishedCnt;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static AnimationCurve punch;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static AnimationCurve shake;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static Transform trans;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private static float timeTotal;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static TweenAction tweenAction;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static float ratioPassed;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static float from;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private static float val;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static bool isTweenFinished;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static int maxTweenReached;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static Vector3 newVect;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private static GameObject target;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static GameObject customTarget;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public static int startSearch;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static LTDescr d;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private static Action<LTEvent>[] eventListeners;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static GameObject[] goListeners;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private static int eventsMaxSearch;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static int EVENTS_MAX;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public static int LISTENERS_MAX;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static int INIT_LISTENERS_MAX;

	[Token(Token = "0x17000003")]
	public static int maxSearch
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0xA1A380", Offset = "0xA1A380", VA = "0xA1A380")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000004")]
	public static int tweensRunning
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0xA1A3F8", Offset = "0xA1A3F8", VA = "0xA1A3F8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000005")]
	public static GameObject tweenEmpty
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xA2B41C", Offset = "0xA2B41C", VA = "0xA2B41C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xA19FC0", Offset = "0xA19FC0", VA = "0xA19FC0")]
	public static void init()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xA1A03C", Offset = "0xA1A03C", VA = "0xA1A03C")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xA1A4F4", Offset = "0xA1A4F4", VA = "0xA1A4F4")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xA1A660", Offset = "0xA1A660", VA = "0xA1A660")]
	public void Update()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xA2604C", Offset = "0xA2604C", VA = "0xA2604C")]
	public void OnLevelWasLoaded(int lvl)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xA1A6D0", Offset = "0xA1A6D0", VA = "0xA1A6D0")]
	public static void update()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xA27AE4", Offset = "0xA27AE4", VA = "0xA27AE4")]
	private static void textAlphaRecursive(Transform trans, float val)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xA27998", Offset = "0xA27998", VA = "0xA27998")]
	private static Color tweenColor(LTDescr tween, float val)
	{
		return default(Color);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xA12138", Offset = "0xA12138", VA = "0xA12138")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xA260BC", Offset = "0xA260BC", VA = "0xA260BC")]
	public static void removeTween(int i)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xA27FD0", Offset = "0xA27FD0", VA = "0xA27FD0")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xA14180", Offset = "0xA14180", VA = "0xA14180")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xA2820C", Offset = "0xA2820C", VA = "0xA2820C")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xA28280", Offset = "0xA28280", VA = "0xA28280")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xA284F4", Offset = "0xA284F4", VA = "0xA284F4")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xA28570", Offset = "0xA28570", VA = "0xA28570")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xA28878", Offset = "0xA28878", VA = "0xA28878")]
	public static void cancel(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xA28AE4", Offset = "0xA28AE4", VA = "0xA28AE4")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xA28C58", Offset = "0xA28C58", VA = "0xA28C58")]
	public static void cancel(int uniqueId)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xA28CD4", Offset = "0xA28CD4", VA = "0xA28CD4")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xA28ED0", Offset = "0xA28ED0", VA = "0xA28ED0")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xA29260", Offset = "0xA29260", VA = "0xA29260")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xA292D8", Offset = "0xA292D8", VA = "0xA292D8")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xA295B4", Offset = "0xA295B4", VA = "0xA295B4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x53D54C", Offset = "0x53D54C")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xA2962C", Offset = "0xA2962C", VA = "0xA2962C")]
	public static void pause(int uniqueId)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xA29778", Offset = "0xA29778", VA = "0xA29778")]
	public static void pause(GameObject gameObject)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xA2994C", Offset = "0xA2994C", VA = "0xA2994C")]
	public static void pauseAll()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xA29A74", Offset = "0xA29A74", VA = "0xA29A74")]
	public static void resumeAll()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xA29B8C", Offset = "0xA29B8C", VA = "0xA29B8C")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x53D580", Offset = "0x53D580")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xA29C04", Offset = "0xA29C04", VA = "0xA29C04")]
	public static void resume(int uniqueId)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xA29D40", Offset = "0xA29D40", VA = "0xA29D40")]
	public static void resume(GameObject gameObject)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xA29EFC", Offset = "0xA29EFC", VA = "0xA29EFC")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xA2A1B8", Offset = "0xA2A1B8", VA = "0xA2A1B8")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xA2A33C", Offset = "0xA2A33C", VA = "0xA2A33C")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xA2A4B0", Offset = "0xA2A4B0", VA = "0xA2A4B0")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xA10A80", Offset = "0xA10A80", VA = "0xA10A80")]
	public static object logError(string error)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xA2AE6C", Offset = "0xA2AE6C", VA = "0xA2AE6C")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xA2AFA0", Offset = "0xA2AFA0", VA = "0xA2AFA0")]
	public static LTDescr options()
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xA2B4A4", Offset = "0xA2B4A4", VA = "0xA2B4A4")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, TweenAction tweenAction, LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xA2B5CC", Offset = "0xA2B5CC", VA = "0xA2B5CC")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xA2B734", Offset = "0xA2B734", VA = "0xA2B734")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xA2B80C", Offset = "0xA2B80C", VA = "0xA2B80C")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xA2B910", Offset = "0xA2B910", VA = "0xA2B910")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xA2BA04", Offset = "0xA2BA04", VA = "0xA2BA04")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xA2BADC", Offset = "0xA2BADC", VA = "0xA2BADC")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xA2BBFC", Offset = "0xA2BBFC", VA = "0xA2BBFC")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xA2BD40", Offset = "0xA2BD40", VA = "0xA2BD40")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xA2BE3C", Offset = "0xA2BE3C", VA = "0xA2BE3C")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xA2BF38", Offset = "0xA2BF38", VA = "0xA2BF38")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xA2C030", Offset = "0xA2C030", VA = "0xA2C030")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xA2C128", Offset = "0xA2C128", VA = "0xA2C128")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xA2C23C", Offset = "0xA2C23C", VA = "0xA2C23C")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xA2C2F4", Offset = "0xA2C2F4", VA = "0xA2C2F4")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xA2C408", Offset = "0xA2C408", VA = "0xA2C408")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xA2C5F8", Offset = "0xA2C5F8", VA = "0xA2C5F8")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xA2C700", Offset = "0xA2C700", VA = "0xA2C700")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xA2C808", Offset = "0xA2C808", VA = "0xA2C808")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xA2C930", Offset = "0xA2C930", VA = "0xA2C930")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xA2CA58", Offset = "0xA2CA58", VA = "0xA2CA58")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xA2CB64", Offset = "0xA2CB64", VA = "0xA2CB64")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xA2CC70", Offset = "0xA2CC70", VA = "0xA2CC70")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xA2CD44", Offset = "0xA2CD44", VA = "0xA2CD44")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xA2CE1C", Offset = "0xA2CE1C", VA = "0xA2CE1C")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xA2CEF4", Offset = "0xA2CEF4", VA = "0xA2CEF4")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xA2CFAC", Offset = "0xA2CFAC", VA = "0xA2CFAC")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xA2D19C", Offset = "0xA2D19C", VA = "0xA2D19C")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xA2D274", Offset = "0xA2D274", VA = "0xA2D274")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xA2D34C", Offset = "0xA2D34C", VA = "0xA2D34C")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xA2D424", Offset = "0xA2D424", VA = "0xA2D424")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xA2D52C", Offset = "0xA2D52C", VA = "0xA2D52C")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xA2D634", Offset = "0xA2D634", VA = "0xA2D634")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xA2D6EC", Offset = "0xA2D6EC", VA = "0xA2D6EC")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xA2D7DC", Offset = "0xA2D7DC", VA = "0xA2D7DC")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xA2D894", Offset = "0xA2D894", VA = "0xA2D894")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xA2D96C", Offset = "0xA2D96C", VA = "0xA2D96C")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xA2DA44", Offset = "0xA2DA44", VA = "0xA2DA44")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xA2DB1C", Offset = "0xA2DB1C", VA = "0xA2DB1C")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xA2DC14", Offset = "0xA2DC14", VA = "0xA2DC14")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xA2DD0C", Offset = "0xA2DD0C", VA = "0xA2DD0C")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xA2DDC4", Offset = "0xA2DDC4", VA = "0xA2DDC4")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xA2DED0", Offset = "0xA2DED0", VA = "0xA2DED0")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xA2DFA8", Offset = "0xA2DFA8", VA = "0xA2DFA8")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xA2E080", Offset = "0xA2E080", VA = "0xA2E080")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xA2E158", Offset = "0xA2E158", VA = "0xA2E158")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xA2E274", Offset = "0xA2E274", VA = "0xA2E274")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xA2E3E0", Offset = "0xA2E3E0", VA = "0xA2E3E0")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xA2E4C8", Offset = "0xA2E4C8", VA = "0xA2E4C8")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xA2E634", Offset = "0xA2E634", VA = "0xA2E634")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xA2E7AC", Offset = "0xA2E7AC", VA = "0xA2E7AC")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xA2E924", Offset = "0xA2E924", VA = "0xA2E924")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xA2EB18", Offset = "0xA2EB18", VA = "0xA2EB18")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xA2ECA0", Offset = "0xA2ECA0", VA = "0xA2ECA0")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xA2EDC8", Offset = "0xA2EDC8", VA = "0xA2EDC8")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xA2EF40", Offset = "0xA2EF40", VA = "0xA2EF40")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xA2F078", Offset = "0xA2F078", VA = "0xA2F078")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xA2F1AC", Offset = "0xA2F1AC", VA = "0xA2F1AC")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xA2F290", Offset = "0xA2F290", VA = "0xA2F290")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xA2F394", Offset = "0xA2F394", VA = "0xA2F394")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xA2F498", Offset = "0xA2F498", VA = "0xA2F498")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xA2F59C", Offset = "0xA2F59C", VA = "0xA2F59C")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xA2F6E8", Offset = "0xA2F6E8", VA = "0xA2F6E8")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xA2F810", Offset = "0xA2F810", VA = "0xA2F810")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xA2F938", Offset = "0xA2F938", VA = "0xA2F938")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xA2FA1C", Offset = "0xA2FA1C", VA = "0xA2FA1C")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xA2FB20", Offset = "0xA2FB20", VA = "0xA2FB20")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xA265BC", Offset = "0xA265BC", VA = "0xA265BC")]
	private static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xA27EC4", Offset = "0xA27EC4", VA = "0xA27EC4")]
	private static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xA26634", Offset = "0xA26634", VA = "0xA26634")]
	private static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xA26658", Offset = "0xA26658", VA = "0xA26658")]
	private static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xA26674", Offset = "0xA26674", VA = "0xA26674")]
	private static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xA2FC78", Offset = "0xA2FC78", VA = "0xA2FC78")]
	private static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xA2FD04", Offset = "0xA2FD04", VA = "0xA2FD04")]
	private static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xA2788C", Offset = "0xA2788C", VA = "0xA2788C")]
	private static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xA2FDEC", Offset = "0xA2FDEC", VA = "0xA2FDEC")]
	private static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xA2FE0C", Offset = "0xA2FE0C", VA = "0xA2FE0C")]
	private static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xA2FE34", Offset = "0xA2FE34", VA = "0xA2FE34")]
	private static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xA266D4", Offset = "0xA266D4", VA = "0xA266D4")]
	private static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xA266F8", Offset = "0xA266F8", VA = "0xA266F8")]
	private static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xA26728", Offset = "0xA26728", VA = "0xA26728")]
	private static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xA26790", Offset = "0xA26790", VA = "0xA26790")]
	private static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xA267B8", Offset = "0xA267B8", VA = "0xA267B8")]
	private static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xA267E8", Offset = "0xA267E8", VA = "0xA267E8")]
	private static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xA26854", Offset = "0xA26854", VA = "0xA26854")]
	private static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xA26880", Offset = "0xA26880", VA = "0xA26880")]
	private static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xA268B8", Offset = "0xA268B8", VA = "0xA268B8")]
	private static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xA26930", Offset = "0xA26930", VA = "0xA26930")]
	private static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xA269DC", Offset = "0xA269DC", VA = "0xA269DC")]
	private static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xA26A84", Offset = "0xA26A84", VA = "0xA26A84")]
	private static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xA26B3C", Offset = "0xA26B3C", VA = "0xA26B3C")]
	private static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xA26BE8", Offset = "0xA26BE8", VA = "0xA26BE8")]
	private static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xA26C94", Offset = "0xA26C94", VA = "0xA26C94")]
	private static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xA26DB8", Offset = "0xA26DB8", VA = "0xA26DB8")]
	private static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xA26E7C", Offset = "0xA26E7C", VA = "0xA26E7C")]
	private static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xA26F3C", Offset = "0xA26F3C", VA = "0xA26F3C")]
	private static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xA2705C", Offset = "0xA2705C", VA = "0xA2705C")]
	private static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xA27110", Offset = "0xA27110", VA = "0xA27110")]
	private static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xA271DC", Offset = "0xA271DC", VA = "0xA271DC")]
	private static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xA272DC", Offset = "0xA272DC", VA = "0xA272DC")]
	private static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xA2731C", Offset = "0xA2731C", VA = "0xA2731C")]
	private static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xA27364", Offset = "0xA27364", VA = "0xA27364")]
	private static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xA273FC", Offset = "0xA273FC", VA = "0xA273FC")]
	private static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xA27550", Offset = "0xA27550", VA = "0xA27550")]
	private static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xA27698", Offset = "0xA27698", VA = "0xA27698")]
	private static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xA2FE98", Offset = "0xA2FE98", VA = "0xA2FE98")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xA2FF1C", Offset = "0xA2FF1C", VA = "0xA2FF1C")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xA30568", Offset = "0xA30568", VA = "0xA30568")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xA305EC", Offset = "0xA305EC", VA = "0xA305EC")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xA3089C", Offset = "0xA3089C", VA = "0xA3089C")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xA30918", Offset = "0xA30918", VA = "0xA30918")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xA30BB8", Offset = "0xA30BB8", VA = "0xA30BB8")]
	public LeanTween()
	{
	}
}
[Token(Token = "0x200000F")]
public class LTBezier
{
	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float length;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Vector3 a;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 aa;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 bb;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 cc;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float len;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float[] arcLengths;

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xA0FE34", Offset = "0xA0FE34", VA = "0xA0FE34")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xA103BC", Offset = "0xA103BC", VA = "0xA103BC")]
	private float map(float u)
	{
		return default(float);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xA1025C", Offset = "0xA1025C", VA = "0xA1025C")]
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xA105AC", Offset = "0xA105AC", VA = "0xA105AC")]
	public Vector3 point(float t)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000010")]
public class LTBezierPath
{
	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Vector3[] pts;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float length;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool orientToPath;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool orientToPath2d;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private LTBezier[] beziers;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float[] lengthRatio;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int currentBezier;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int previousBezier;

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xA105DC", Offset = "0xA105DC", VA = "0xA105DC")]
	public LTBezierPath()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xA105E4", Offset = "0xA105E4", VA = "0xA105E4")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xA1060C", Offset = "0xA1060C", VA = "0xA1060C")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xA10C1C", Offset = "0xA10C1C", VA = "0xA10C1C")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xA10DE0", Offset = "0xA10DE0", VA = "0xA10DE0")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xA10FAC", Offset = "0xA10FAC", VA = "0xA10FAC")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xA111C0", Offset = "0xA111C0", VA = "0xA111C0")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xA1126C", Offset = "0xA1126C", VA = "0xA1126C")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xA11328", Offset = "0xA11328", VA = "0xA11328")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xA113D4", Offset = "0xA113D4", VA = "0xA113D4")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xA114D8", Offset = "0xA114D8", VA = "0xA114D8")]
	public void gizmoDraw(float t = -1f)
	{
	}
}
[Serializable]
[Token(Token = "0x2000011")]
public class LTSpline
{
	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int DISTANCE_COUNT;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int SUBLINE_COUNT;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Vector3[] pts;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3[] ptsAdj;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int ptsAdjLength;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool orientToPath;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool orientToPath2d;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int numSections;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int currPt;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float totalLength;

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xA1552C", Offset = "0xA1552C", VA = "0xA1552C")]
	public LTSpline(params Vector3[] pts)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xA19518", Offset = "0xA19518", VA = "0xA19518")]
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xA18FE8", Offset = "0xA18FE8", VA = "0xA18FE8")]
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xA19760", Offset = "0xA19760", VA = "0xA19760")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xA19780", Offset = "0xA19780", VA = "0xA19780")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xA19950", Offset = "0xA19950", VA = "0xA19950")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xA19B68", Offset = "0xA19B68", VA = "0xA19B68")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xA19C14", Offset = "0xA19C14", VA = "0xA19C14")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xA19CD8", Offset = "0xA19CD8", VA = "0xA19CD8")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xA19D84", Offset = "0xA19D84", VA = "0xA19D84")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xA19E90", Offset = "0xA19E90", VA = "0xA19E90")]
	public void gizmoDraw(float t = -1f)
	{
	}
}
[Serializable]
[Token(Token = "0x2000012")]
public class LTRect
{
	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Rect _rect;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float alpha;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float rotation;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 pivot;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 margin;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Rect relativeRect;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool rotateEnabled;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[HideInInspector]
	public bool rotateFinished;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	public bool alphaEnabled;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public string labelStr;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LTGUI.Element_Type type;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public GUIStyle style;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool useColor;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Color color;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool fontScaleToFit;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	public bool useSimpleScale;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
	public bool sizeByHeight;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture texture;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int _id;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public int counter;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool colorTouched;

	[Token(Token = "0x17000006")]
	public bool hasInitiliazed
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0xA1729C", Offset = "0xA1729C", VA = "0xA1729C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000007")]
	public int id
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0xA17DCC", Offset = "0xA17DCC", VA = "0xA17DCC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000008")]
	public float x
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0xA18AEC", Offset = "0xA18AEC", VA = "0xA18AEC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000142")]
		[Address(RVA = "0xA18AF8", Offset = "0xA18AF8", VA = "0xA18AF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public float y
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0xA18B04", Offset = "0xA18B04", VA = "0xA18B04")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000144")]
		[Address(RVA = "0xA18B10", Offset = "0xA18B10", VA = "0xA18B10")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public float width
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0xA18B1C", Offset = "0xA18B1C", VA = "0xA18B1C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000146")]
		[Address(RVA = "0xA18B28", Offset = "0xA18B28", VA = "0xA18B28")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public float height
	{
		[Token(Token = "0x6000147")]
		[Address(RVA = "0xA18B34", Offset = "0xA18B34", VA = "0xA18B34")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000148")]
		[Address(RVA = "0xA18B40", Offset = "0xA18B40", VA = "0xA18B40")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public Rect rect
	{
		[Token(Token = "0x6000149")]
		[Address(RVA = "0xA14270", Offset = "0xA14270", VA = "0xA14270")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x600014A")]
		[Address(RVA = "0xA18B4C", Offset = "0xA18B4C", VA = "0xA18B4C")]
		set
		{
		}
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xA1868C", Offset = "0xA1868C", VA = "0xA1868C")]
	public LTRect()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xA15078", Offset = "0xA15078", VA = "0xA15078")]
	public LTRect(Rect rect)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xA18810", Offset = "0xA18810", VA = "0xA18810")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xA188FC", Offset = "0xA188FC", VA = "0xA188FC")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xA189E4", Offset = "0xA189E4", VA = "0xA189E4")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xA17DDC", Offset = "0xA17DDC", VA = "0xA17DDC")]
	public void setId(int id, int counter)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xA18760", Offset = "0xA18760", VA = "0xA18760")]
	public void reset()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xA14550", Offset = "0xA14550", VA = "0xA14550")]
	public void resetForRotation()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xA18B5C", Offset = "0xA18B5C", VA = "0xA18B5C")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xA18B64", Offset = "0xA18B64", VA = "0xA18B64")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xA18B6C", Offset = "0xA18B6C", VA = "0xA18B6C")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xA18B8C", Offset = "0xA18B8C", VA = "0xA18B8C")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xA18B94", Offset = "0xA18B94", VA = "0xA18B94")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xA18B9C", Offset = "0xA18B9C", VA = "0xA18B9C")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xA18BC0", Offset = "0xA18BC0", VA = "0xA18BC0")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xA18C40", Offset = "0xA18C40", VA = "0xA18C40")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xA18C48", Offset = "0xA18C48", VA = "0xA18C48", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000013")]
public class LTEvent
{
	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int id;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public object data;

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xA15928", Offset = "0xA15928", VA = "0xA15928")]
	public LTEvent(int id, object data)
	{
	}
}
[Token(Token = "0x2000014")]
public class LTGUI
{
	[Token(Token = "0x2000017")]
	public enum Element_Type
	{
		[Token(Token = "0x4000138")]
		Texture,
		[Token(Token = "0x4000139")]
		Label
	}

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int RECT_LEVELS;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int RECTS_PER_LEVEL;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int BUTTONS_MAX;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static LTRect[] levels;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int[] levelDepths;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static Rect[] buttons;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int[] buttonLevels;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static int[] buttonLastFrame;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static LTRect r;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static Color color;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static bool isGUIEnabled;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static int global_counter;

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xA15950", Offset = "0xA15950", VA = "0xA15950")]
	public static void init()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xA15A44", Offset = "0xA15A44", VA = "0xA15A44")]
	public static void initRectCheck()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xA15C00", Offset = "0xA15C00", VA = "0xA15C00")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xA15E04", Offset = "0xA15E04", VA = "0xA15E04")]
	public static void update(int updateLevel)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xA16F9C", Offset = "0xA16F9C", VA = "0xA16F9C")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xA170A0", Offset = "0xA170A0", VA = "0xA170A0")]
	public static void destroy(int id)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xA172B0", Offset = "0xA172B0", VA = "0xA172B0")]
	public static void destroyAll(int depth)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xA173D4", Offset = "0xA173D4", VA = "0xA173D4")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xA1749C", Offset = "0xA1749C", VA = "0xA1749C")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xA17C54", Offset = "0xA17C54", VA = "0xA17C54")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xA17D1C", Offset = "0xA17D1C", VA = "0xA17D1C")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xA1754C", Offset = "0xA1754C", VA = "0xA1754C")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xA17DE8", Offset = "0xA17DE8", VA = "0xA17DE8")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xA18218", Offset = "0xA18218", VA = "0xA18218")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xA184C0", Offset = "0xA184C0", VA = "0xA184C0")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xA18390", Offset = "0xA18390", VA = "0xA18390")]
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xA185C8", Offset = "0xA185C8", VA = "0xA185C8")]
	public LTGUI()
	{
	}
}
