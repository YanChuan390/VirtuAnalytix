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
	[Address(RVA = "0x804198", Offset = "0x804198", VA = "0x804198")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x8042A0", Offset = "0x8042A0", VA = "0x8042A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x80439C", Offset = "0x80439C", VA = "0x80439C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x8043A0", Offset = "0x8043A0", VA = "0x8043A0")]
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
	[Address(RVA = "0x804430", Offset = "0x804430", VA = "0x804430")]
	private void Start()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x804434", Offset = "0x804434", VA = "0x804434")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x804438", Offset = "0x804438", VA = "0x804438")]
	public ExampleCam()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4FF5CC", Offset = "0x4FF5CC")]
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
	[Address(RVA = "0x8044BC", Offset = "0x8044BC", VA = "0x8044BC")]
	private void Start()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x804A94", Offset = "0x804A94", VA = "0x804A94")]
	private void playSound()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x804B60", Offset = "0x804B60", VA = "0x804B60")]
	public void DoOutFullscreen()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x804B94", Offset = "0x804B94", VA = "0x804B94")]
	public void DoChangeEnvironment()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x804C78", Offset = "0x804C78", VA = "0x804C78")]
	private void OnLevelWasLoaded()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x804718", Offset = "0x804718", VA = "0x804718")]
	private void InitCam()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x804C7C", Offset = "0x804C7C", VA = "0x804C7C")]
	public void DoSwitchAutoCam()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x804CF0", Offset = "0x804CF0", VA = "0x804CF0")]
	public void DoSwitchCameraEffects()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x804F2C", Offset = "0x804F2C", VA = "0x804F2C")]
	public void DoSwitchAnimDelays()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x8050C4", Offset = "0x8050C4", VA = "0x8050C4")]
	public void DoAppear()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x8051B8", Offset = "0x8051B8", VA = "0x8051B8")]
	public void DoDisappear()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x805270", Offset = "0x805270", VA = "0x805270")]
	public void DoNext()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x8052F0", Offset = "0x8052F0", VA = "0x8052F0")]
	public void DoPrevious()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x8045BC", Offset = "0x8045BC", VA = "0x8045BC")]
	private void CallInterface(InterfaceAnimManager _interface)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x805374", Offset = "0x805374", VA = "0x805374")]
	public void UpdateDisplayedInfo()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x80549C", Offset = "0x80549C", VA = "0x80549C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x8054D4", Offset = "0x8054D4", VA = "0x8054D4")]
	public ExampleUI()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4FF600", Offset = "0x4FF600")]
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
	[Address(RVA = "0x8055E8", Offset = "0x8055E8", VA = "0x8055E8")]
	private void Start()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x8055EC", Offset = "0x8055EC", VA = "0x8055EC")]
	private void playSound()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x8056D8", Offset = "0x8056D8", VA = "0x8056D8")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x8056DC", Offset = "0x8056DC", VA = "0x8056DC")]
	public void SetPosition(int _scaleValue)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x8057D4", Offset = "0x8057D4", VA = "0x8057D4")]
	public void SetPositionAndScaleTo(GameObject _object)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x805970", Offset = "0x805970", VA = "0x805970")]
	public void SetUniformScale(int _scaleValue)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x805A68", Offset = "0x805A68", VA = "0x805A68")]
	public void SetUniformWidthHeight(int _widthHeightValue)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x805BC8", Offset = "0x805BC8", VA = "0x805BC8")]
	public void SetImageColor(int _colorID)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x805CE8", Offset = "0x805CE8", VA = "0x805CE8")]
	public void OpenWebPage()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x805D4C", Offset = "0x805D4C", VA = "0x805D4C")]
	public void GetSliderValue_ToText()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x805DC8", Offset = "0x805DC8", VA = "0x805DC8")]
	public ExcelsiorUtils()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4FF634", Offset = "0x4FF634")]
public class InterfaceAnimManager : MonoBehaviour
{
	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF668", Offset = "0x4FF668")]
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
			[Address(RVA = "0x809EA4", Offset = "0x809EA4", VA = "0x809EA4", Slot = "4")]
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
			[Address(RVA = "0x809F24", Offset = "0x809F24", VA = "0x809F24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x808B80", Offset = "0x808B80", VA = "0x808B80")]
		[DebuggerHidden]
		public <Disable_OnDisappearEnd>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x809990", Offset = "0x809990", VA = "0x809990", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x809994", Offset = "0x809994", VA = "0x809994", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x809EAC", Offset = "0x809EAC", VA = "0x809EAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FF678", Offset = "0x4FF678")]
	private sealed class <>c
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Func<InterfaceAnmElement, int> <>9__27_0;

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x809968", Offset = "0x809968", VA = "0x809968")]
		public <>c()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x809970", Offset = "0x809970", VA = "0x809970")]
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
	[Address(RVA = "0x805DD0", Offset = "0x805DD0", VA = "0x805DD0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x805E30", Offset = "0x805E30", VA = "0x805E30")]
	private void Start()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x807270", Offset = "0x807270", VA = "0x807270")]
	private void Update()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x808640", Offset = "0x808640", VA = "0x808640")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4FF6A8", Offset = "0x4FF6A8")]
	public IEnumerator Disable_OnDisappearEnd()
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x808BA0", Offset = "0x808BA0", VA = "0x808BA0", Slot = "4")]
	public virtual void startAppear(bool direct = false)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x80862C", Offset = "0x80862C", VA = "0x80862C")]
	private void endAppear()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x80909C", Offset = "0x80909C", VA = "0x80909C", Slot = "5")]
	public virtual void startDisappear(bool direct = false)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x8086C0", Offset = "0x8086C0", VA = "0x8086C0")]
	private void endDisappear()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x805E98", Offset = "0x805E98", VA = "0x805E98")]
	public void UpdateAnimClips()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x8092B0", Offset = "0x8092B0", VA = "0x8092B0")]
	public bool isIAM_Root()
	{
		return default(bool);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x809818", Offset = "0x809818", VA = "0x809818")]
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
	[Address(RVA = "0x8093F8", Offset = "0x8093F8", VA = "0x8093F8")]
	public static InterfaceAnmElement Create(GameObject _gameObjectRef, int _newSortID, bool _isNested_IAM)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x809F2C", Offset = "0x809F2C", VA = "0x809F2C", Slot = "4")]
	public virtual InterfaceAnmElement Confirm(GameObject _gameObjectRef, int _newSortID, bool isNested_IAM)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x809688", Offset = "0x809688", VA = "0x809688")]
	public void UpdateProperties()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x80A080", Offset = "0x80A080", VA = "0x80A080", Slot = "5")]
	public virtual void Delete()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x80A0B0", Offset = "0x80A0B0", VA = "0x80A0B0")]
	public void Update()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x80A190", Offset = "0x80A190", VA = "0x80A190")]
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
	[Address(RVA = "0xB2E418", Offset = "0xB2E418", VA = "0xB2E418")]
	private void Start()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xB2E524", Offset = "0xB2E524", VA = "0xB2E524")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xB2EA20", Offset = "0xB2EA20", VA = "0xB2EA20")]
	public static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xB2EAE8", Offset = "0xB2EAE8", VA = "0xB2EAE8")]
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
		[Address(RVA = "0x80C528", Offset = "0x80C528", VA = "0x80C528")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000002")]
	public int id
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x80C41C", Offset = "0x80C41C", VA = "0x80C41C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x80B9DC", Offset = "0x80B9DC", VA = "0x80B9DC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x80C42C", Offset = "0x80C42C", VA = "0x80C42C")]
	public LTDescr()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x80C434", Offset = "0x80C434", VA = "0x80C434")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4FF718", Offset = "0x4FF718")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x80C630", Offset = "0x80C630", VA = "0x80C630")]
	public void reset()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x80C7C8", Offset = "0x80C7C8", VA = "0x80C7C8")]
	public void cleanup()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x80C7F8", Offset = "0x80C7F8", VA = "0x80C7F8")]
	public void init()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x80ECC8", Offset = "0x80ECC8", VA = "0x80ECC8")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x80ED90", Offset = "0x80ED90", VA = "0x80ED90")]
	public LTDescr pause()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x80EDAC", Offset = "0x80EDAC", VA = "0x80EDAC")]
	public LTDescr resume()
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x80EDB8", Offset = "0x80EDB8", VA = "0x80EDB8")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x80EDC4", Offset = "0x80EDC4", VA = "0x80EDC4")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x80EDCC", Offset = "0x80EDCC", VA = "0x80EDCC")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x80EDD4", Offset = "0x80EDD4", VA = "0x80EDD4")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x80EDDC", Offset = "0x80EDDC", VA = "0x80EDDC")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x80EDE4", Offset = "0x80EDE4", VA = "0x80EDE4")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x80EDEC", Offset = "0x80EDEC", VA = "0x80EDEC")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x80EEC4", Offset = "0x80EEC4", VA = "0x80EEC4")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x80EFE0", Offset = "0x80EFE0", VA = "0x80EFE0")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x80F02C", Offset = "0x80F02C", VA = "0x80F02C")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x80F038", Offset = "0x80F038", VA = "0x80F038")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x80F040", Offset = "0x80F040", VA = "0x80F040")]
	public LTDescr setId(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x80F0CC", Offset = "0x80F0CC", VA = "0x80F0CC")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x80F0D4", Offset = "0x80F0D4", VA = "0x80F0D4")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x80F120", Offset = "0x80F120", VA = "0x80F120")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x80F128", Offset = "0x80F128", VA = "0x80F128")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x80F130", Offset = "0x80F130", VA = "0x80F130")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x80F138", Offset = "0x80F138", VA = "0x80F138")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x80F140", Offset = "0x80F140", VA = "0x80F140")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x80F148", Offset = "0x80F148", VA = "0x80F148")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x80F150", Offset = "0x80F150", VA = "0x80F150")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x80F15C", Offset = "0x80F15C", VA = "0x80F15C")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x80F178", Offset = "0x80F178", VA = "0x80F178")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x80F180", Offset = "0x80F180", VA = "0x80F180")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x80F19C", Offset = "0x80F19C", VA = "0x80F19C")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x80F1D4", Offset = "0x80F1D4", VA = "0x80F1D4")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x80F1DC", Offset = "0x80F1DC", VA = "0x80F1DC")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x80F1E4", Offset = "0x80F1E4", VA = "0x80F1E4")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x80F1F4", Offset = "0x80F1F4", VA = "0x80F1F4")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x80F1FC", Offset = "0x80F1FC", VA = "0x80F1FC")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x80F20C", Offset = "0x80F20C", VA = "0x80F20C")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x80F21C", Offset = "0x80F21C", VA = "0x80F21C")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x80F22C", Offset = "0x80F22C", VA = "0x80F22C")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x80F23C", Offset = "0x80F23C", VA = "0x80F23C")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x80F24C", Offset = "0x80F24C", VA = "0x80F24C")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x80F25C", Offset = "0x80F25C", VA = "0x80F25C")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x80F26C", Offset = "0x80F26C", VA = "0x80F26C")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x80F284", Offset = "0x80F284", VA = "0x80F284")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x80F29C", Offset = "0x80F29C", VA = "0x80F29C")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x80F2B4", Offset = "0x80F2B4", VA = "0x80F2B4")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x80F2CC", Offset = "0x80F2CC", VA = "0x80F2CC")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x80F2D4", Offset = "0x80F2D4", VA = "0x80F2D4")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x80F388", Offset = "0x80F388", VA = "0x80F388")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x80F3E0", Offset = "0x80F3E0", VA = "0x80F3E0")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x80F3E8", Offset = "0x80F3E8", VA = "0x80F3E8")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x80F530", Offset = "0x80F530", VA = "0x80F530")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x80F538", Offset = "0x80F538", VA = "0x80F538")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x80F544", Offset = "0x80F544", VA = "0x80F544")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x80F54C", Offset = "0x80F54C", VA = "0x80F54C")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x80F118", Offset = "0x80F118", VA = "0x80F118")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x80F554", Offset = "0x80F554", VA = "0x80F554")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x80F55C", Offset = "0x80F55C", VA = "0x80F55C")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x80F564", Offset = "0x80F564", VA = "0x80F564")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x80F56C", Offset = "0x80F56C", VA = "0x80F56C")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x80F5AC", Offset = "0x80F5AC", VA = "0x80F5AC")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x80F5B4", Offset = "0x80F5B4", VA = "0x80F5B4")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}
}
[Token(Token = "0x200000D")]
public class LTUtility
{
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x80F7F4", Offset = "0x80F7F4", VA = "0x80F7F4")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x8143B8", Offset = "0x8143B8", VA = "0x8143B8")]
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
		[Address(RVA = "0x814780", Offset = "0x814780", VA = "0x814780")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000004")]
	public static int tweensRunning
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x8147F8", Offset = "0x8147F8", VA = "0x8147F8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000005")]
	public static GameObject tweenEmpty
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x82581C", Offset = "0x82581C", VA = "0x82581C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x8143C0", Offset = "0x8143C0", VA = "0x8143C0")]
	public static void init()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x81443C", Offset = "0x81443C", VA = "0x81443C")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x8148F4", Offset = "0x8148F4", VA = "0x8148F4")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x814A60", Offset = "0x814A60", VA = "0x814A60")]
	public void Update()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x82044C", Offset = "0x82044C", VA = "0x82044C")]
	public void OnLevelWasLoaded(int lvl)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x814AD0", Offset = "0x814AD0", VA = "0x814AD0")]
	public static void update()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x821EE4", Offset = "0x821EE4", VA = "0x821EE4")]
	private static void textAlphaRecursive(Transform trans, float val)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x821D98", Offset = "0x821D98", VA = "0x821D98")]
	private static Color tweenColor(LTDescr tween, float val)
	{
		return default(Color);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x80C538", Offset = "0x80C538", VA = "0x80C538")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x8204BC", Offset = "0x8204BC", VA = "0x8204BC")]
	public static void removeTween(int i)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x8223D0", Offset = "0x8223D0", VA = "0x8223D0")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x80E580", Offset = "0x80E580", VA = "0x80E580")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x82260C", Offset = "0x82260C", VA = "0x82260C")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x822680", Offset = "0x822680", VA = "0x822680")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x8228F4", Offset = "0x8228F4", VA = "0x8228F4")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x822970", Offset = "0x822970", VA = "0x822970")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x822C78", Offset = "0x822C78", VA = "0x822C78")]
	public static void cancel(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x822EE4", Offset = "0x822EE4", VA = "0x822EE4")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x823058", Offset = "0x823058", VA = "0x823058")]
	public static void cancel(int uniqueId)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x8230D4", Offset = "0x8230D4", VA = "0x8230D4")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x8232D0", Offset = "0x8232D0", VA = "0x8232D0")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x823660", Offset = "0x823660", VA = "0x823660")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x8236D8", Offset = "0x8236D8", VA = "0x8236D8")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x8239B4", Offset = "0x8239B4", VA = "0x8239B4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4FF74C", Offset = "0x4FF74C")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x823A2C", Offset = "0x823A2C", VA = "0x823A2C")]
	public static void pause(int uniqueId)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x823B78", Offset = "0x823B78", VA = "0x823B78")]
	public static void pause(GameObject gameObject)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x823D4C", Offset = "0x823D4C", VA = "0x823D4C")]
	public static void pauseAll()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x823E74", Offset = "0x823E74", VA = "0x823E74")]
	public static void resumeAll()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x823F8C", Offset = "0x823F8C", VA = "0x823F8C")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4FF780", Offset = "0x4FF780")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x824004", Offset = "0x824004", VA = "0x824004")]
	public static void resume(int uniqueId)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x824140", Offset = "0x824140", VA = "0x824140")]
	public static void resume(GameObject gameObject)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x8242FC", Offset = "0x8242FC", VA = "0x8242FC")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x8245B8", Offset = "0x8245B8", VA = "0x8245B8")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x82473C", Offset = "0x82473C", VA = "0x82473C")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x8248B0", Offset = "0x8248B0", VA = "0x8248B0")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x80AE80", Offset = "0x80AE80", VA = "0x80AE80")]
	public static object logError(string error)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x82526C", Offset = "0x82526C", VA = "0x82526C")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x8253A0", Offset = "0x8253A0", VA = "0x8253A0")]
	public static LTDescr options()
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x8258A4", Offset = "0x8258A4", VA = "0x8258A4")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, TweenAction tweenAction, LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x8259CC", Offset = "0x8259CC", VA = "0x8259CC")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x825B34", Offset = "0x825B34", VA = "0x825B34")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x825C0C", Offset = "0x825C0C", VA = "0x825C0C")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x825D10", Offset = "0x825D10", VA = "0x825D10")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x825E04", Offset = "0x825E04", VA = "0x825E04")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x825EDC", Offset = "0x825EDC", VA = "0x825EDC")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x825FFC", Offset = "0x825FFC", VA = "0x825FFC")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x826140", Offset = "0x826140", VA = "0x826140")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x82623C", Offset = "0x82623C", VA = "0x82623C")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x826338", Offset = "0x826338", VA = "0x826338")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x826430", Offset = "0x826430", VA = "0x826430")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x826528", Offset = "0x826528", VA = "0x826528")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x82663C", Offset = "0x82663C", VA = "0x82663C")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x8266F4", Offset = "0x8266F4", VA = "0x8266F4")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x826808", Offset = "0x826808", VA = "0x826808")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x8269F8", Offset = "0x8269F8", VA = "0x8269F8")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x826B00", Offset = "0x826B00", VA = "0x826B00")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x826C08", Offset = "0x826C08", VA = "0x826C08")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x826D30", Offset = "0x826D30", VA = "0x826D30")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x826E58", Offset = "0x826E58", VA = "0x826E58")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x826F64", Offset = "0x826F64", VA = "0x826F64")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x827070", Offset = "0x827070", VA = "0x827070")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x827144", Offset = "0x827144", VA = "0x827144")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x82721C", Offset = "0x82721C", VA = "0x82721C")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x8272F4", Offset = "0x8272F4", VA = "0x8272F4")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x8273AC", Offset = "0x8273AC", VA = "0x8273AC")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x82759C", Offset = "0x82759C", VA = "0x82759C")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x827674", Offset = "0x827674", VA = "0x827674")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x82774C", Offset = "0x82774C", VA = "0x82774C")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x827824", Offset = "0x827824", VA = "0x827824")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x82792C", Offset = "0x82792C", VA = "0x82792C")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x827A34", Offset = "0x827A34", VA = "0x827A34")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x827AEC", Offset = "0x827AEC", VA = "0x827AEC")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x827BDC", Offset = "0x827BDC", VA = "0x827BDC")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x827C94", Offset = "0x827C94", VA = "0x827C94")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x827D6C", Offset = "0x827D6C", VA = "0x827D6C")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x827E44", Offset = "0x827E44", VA = "0x827E44")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x827F1C", Offset = "0x827F1C", VA = "0x827F1C")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x828014", Offset = "0x828014", VA = "0x828014")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x82810C", Offset = "0x82810C", VA = "0x82810C")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x8281C4", Offset = "0x8281C4", VA = "0x8281C4")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x8282D0", Offset = "0x8282D0", VA = "0x8282D0")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x8283A8", Offset = "0x8283A8", VA = "0x8283A8")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x828480", Offset = "0x828480", VA = "0x828480")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x828558", Offset = "0x828558", VA = "0x828558")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x828674", Offset = "0x828674", VA = "0x828674")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x8287E0", Offset = "0x8287E0", VA = "0x8287E0")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x8288C8", Offset = "0x8288C8", VA = "0x8288C8")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x828A34", Offset = "0x828A34", VA = "0x828A34")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x828BAC", Offset = "0x828BAC", VA = "0x828BAC")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x828D24", Offset = "0x828D24", VA = "0x828D24")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x828F18", Offset = "0x828F18", VA = "0x828F18")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x8290A0", Offset = "0x8290A0", VA = "0x8290A0")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x8291C8", Offset = "0x8291C8", VA = "0x8291C8")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x829340", Offset = "0x829340", VA = "0x829340")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x829478", Offset = "0x829478", VA = "0x829478")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x8295AC", Offset = "0x8295AC", VA = "0x8295AC")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x829690", Offset = "0x829690", VA = "0x829690")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x829794", Offset = "0x829794", VA = "0x829794")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x829898", Offset = "0x829898", VA = "0x829898")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x82999C", Offset = "0x82999C", VA = "0x82999C")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x829AE8", Offset = "0x829AE8", VA = "0x829AE8")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x829C10", Offset = "0x829C10", VA = "0x829C10")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x829D38", Offset = "0x829D38", VA = "0x829D38")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x829E1C", Offset = "0x829E1C", VA = "0x829E1C")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x829F20", Offset = "0x829F20", VA = "0x829F20")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x8209BC", Offset = "0x8209BC", VA = "0x8209BC")]
	private static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x8222C4", Offset = "0x8222C4", VA = "0x8222C4")]
	private static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x820A34", Offset = "0x820A34", VA = "0x820A34")]
	private static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x820A58", Offset = "0x820A58", VA = "0x820A58")]
	private static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x820A74", Offset = "0x820A74", VA = "0x820A74")]
	private static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x82A078", Offset = "0x82A078", VA = "0x82A078")]
	private static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x82A104", Offset = "0x82A104", VA = "0x82A104")]
	private static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x821C8C", Offset = "0x821C8C", VA = "0x821C8C")]
	private static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x82A1EC", Offset = "0x82A1EC", VA = "0x82A1EC")]
	private static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x82A20C", Offset = "0x82A20C", VA = "0x82A20C")]
	private static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x82A234", Offset = "0x82A234", VA = "0x82A234")]
	private static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x820AD4", Offset = "0x820AD4", VA = "0x820AD4")]
	private static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x820AF8", Offset = "0x820AF8", VA = "0x820AF8")]
	private static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x820B28", Offset = "0x820B28", VA = "0x820B28")]
	private static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x820B90", Offset = "0x820B90", VA = "0x820B90")]
	private static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x820BB8", Offset = "0x820BB8", VA = "0x820BB8")]
	private static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x820BE8", Offset = "0x820BE8", VA = "0x820BE8")]
	private static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x820C54", Offset = "0x820C54", VA = "0x820C54")]
	private static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x820C80", Offset = "0x820C80", VA = "0x820C80")]
	private static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x820CB8", Offset = "0x820CB8", VA = "0x820CB8")]
	private static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x820D30", Offset = "0x820D30", VA = "0x820D30")]
	private static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x820DDC", Offset = "0x820DDC", VA = "0x820DDC")]
	private static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x820E84", Offset = "0x820E84", VA = "0x820E84")]
	private static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x820F3C", Offset = "0x820F3C", VA = "0x820F3C")]
	private static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x820FE8", Offset = "0x820FE8", VA = "0x820FE8")]
	private static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x821094", Offset = "0x821094", VA = "0x821094")]
	private static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x8211B8", Offset = "0x8211B8", VA = "0x8211B8")]
	private static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x82127C", Offset = "0x82127C", VA = "0x82127C")]
	private static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x82133C", Offset = "0x82133C", VA = "0x82133C")]
	private static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x82145C", Offset = "0x82145C", VA = "0x82145C")]
	private static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x821510", Offset = "0x821510", VA = "0x821510")]
	private static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x8215DC", Offset = "0x8215DC", VA = "0x8215DC")]
	private static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x8216DC", Offset = "0x8216DC", VA = "0x8216DC")]
	private static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x82171C", Offset = "0x82171C", VA = "0x82171C")]
	private static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x821764", Offset = "0x821764", VA = "0x821764")]
	private static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x8217FC", Offset = "0x8217FC", VA = "0x8217FC")]
	private static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x821950", Offset = "0x821950", VA = "0x821950")]
	private static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x821A98", Offset = "0x821A98", VA = "0x821A98")]
	private static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x82A298", Offset = "0x82A298", VA = "0x82A298")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x82A31C", Offset = "0x82A31C", VA = "0x82A31C")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x82A968", Offset = "0x82A968", VA = "0x82A968")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x82A9EC", Offset = "0x82A9EC", VA = "0x82A9EC")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x82AC9C", Offset = "0x82AC9C", VA = "0x82AC9C")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x82AD18", Offset = "0x82AD18", VA = "0x82AD18")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x82AFB8", Offset = "0x82AFB8", VA = "0x82AFB8")]
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
	[Address(RVA = "0x80A234", Offset = "0x80A234", VA = "0x80A234")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x80A7BC", Offset = "0x80A7BC", VA = "0x80A7BC")]
	private float map(float u)
	{
		return default(float);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x80A65C", Offset = "0x80A65C", VA = "0x80A65C")]
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x80A9AC", Offset = "0x80A9AC", VA = "0x80A9AC")]
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
	[Address(RVA = "0x80A9DC", Offset = "0x80A9DC", VA = "0x80A9DC")]
	public LTBezierPath()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x80A9E4", Offset = "0x80A9E4", VA = "0x80A9E4")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x80AA0C", Offset = "0x80AA0C", VA = "0x80AA0C")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x80B01C", Offset = "0x80B01C", VA = "0x80B01C")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x80B1E0", Offset = "0x80B1E0", VA = "0x80B1E0")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x80B3AC", Offset = "0x80B3AC", VA = "0x80B3AC")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x80B5C0", Offset = "0x80B5C0", VA = "0x80B5C0")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x80B66C", Offset = "0x80B66C", VA = "0x80B66C")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x80B728", Offset = "0x80B728", VA = "0x80B728")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x80B7D4", Offset = "0x80B7D4", VA = "0x80B7D4")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x80B8D8", Offset = "0x80B8D8", VA = "0x80B8D8")]
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
	[Address(RVA = "0x80F92C", Offset = "0x80F92C", VA = "0x80F92C")]
	public LTSpline(params Vector3[] pts)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x813918", Offset = "0x813918", VA = "0x813918")]
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x8133E8", Offset = "0x8133E8", VA = "0x8133E8")]
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x813B60", Offset = "0x813B60", VA = "0x813B60")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x813B80", Offset = "0x813B80", VA = "0x813B80")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x813D50", Offset = "0x813D50", VA = "0x813D50")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x813F68", Offset = "0x813F68", VA = "0x813F68")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x814014", Offset = "0x814014", VA = "0x814014")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x8140D8", Offset = "0x8140D8", VA = "0x8140D8")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x814184", Offset = "0x814184", VA = "0x814184")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x814290", Offset = "0x814290", VA = "0x814290")]
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
		[Address(RVA = "0x81169C", Offset = "0x81169C", VA = "0x81169C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000007")]
	public int id
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x8121CC", Offset = "0x8121CC", VA = "0x8121CC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000008")]
	public float x
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x812EEC", Offset = "0x812EEC", VA = "0x812EEC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x812EF8", Offset = "0x812EF8", VA = "0x812EF8")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public float y
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x812F04", Offset = "0x812F04", VA = "0x812F04")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x812F10", Offset = "0x812F10", VA = "0x812F10")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public float width
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x812F1C", Offset = "0x812F1C", VA = "0x812F1C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x812F28", Offset = "0x812F28", VA = "0x812F28")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public float height
	{
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x812F34", Offset = "0x812F34", VA = "0x812F34")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x812F40", Offset = "0x812F40", VA = "0x812F40")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public Rect rect
	{
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x80E670", Offset = "0x80E670", VA = "0x80E670")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x812F4C", Offset = "0x812F4C", VA = "0x812F4C")]
		set
		{
		}
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x812A8C", Offset = "0x812A8C", VA = "0x812A8C")]
	public LTRect()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x80F478", Offset = "0x80F478", VA = "0x80F478")]
	public LTRect(Rect rect)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x812C10", Offset = "0x812C10", VA = "0x812C10")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x812CFC", Offset = "0x812CFC", VA = "0x812CFC")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x812DE4", Offset = "0x812DE4", VA = "0x812DE4")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x8121DC", Offset = "0x8121DC", VA = "0x8121DC")]
	public void setId(int id, int counter)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x812B60", Offset = "0x812B60", VA = "0x812B60")]
	public void reset()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x80E950", Offset = "0x80E950", VA = "0x80E950")]
	public void resetForRotation()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x812F5C", Offset = "0x812F5C", VA = "0x812F5C")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x812F64", Offset = "0x812F64", VA = "0x812F64")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x812F6C", Offset = "0x812F6C", VA = "0x812F6C")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x812F8C", Offset = "0x812F8C", VA = "0x812F8C")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x812F94", Offset = "0x812F94", VA = "0x812F94")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x812F9C", Offset = "0x812F9C", VA = "0x812F9C")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x812FC0", Offset = "0x812FC0", VA = "0x812FC0")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x813040", Offset = "0x813040", VA = "0x813040")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x813048", Offset = "0x813048", VA = "0x813048", Slot = "3")]
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
	[Address(RVA = "0x80FD28", Offset = "0x80FD28", VA = "0x80FD28")]
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
	[Address(RVA = "0x80FD50", Offset = "0x80FD50", VA = "0x80FD50")]
	public static void init()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x80FE44", Offset = "0x80FE44", VA = "0x80FE44")]
	public static void initRectCheck()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x810000", Offset = "0x810000", VA = "0x810000")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x810204", Offset = "0x810204", VA = "0x810204")]
	public static void update(int updateLevel)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x81139C", Offset = "0x81139C", VA = "0x81139C")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x8114A0", Offset = "0x8114A0", VA = "0x8114A0")]
	public static void destroy(int id)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x8116B0", Offset = "0x8116B0", VA = "0x8116B0")]
	public static void destroyAll(int depth)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x8117D4", Offset = "0x8117D4", VA = "0x8117D4")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x81189C", Offset = "0x81189C", VA = "0x81189C")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x812054", Offset = "0x812054", VA = "0x812054")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x81211C", Offset = "0x81211C", VA = "0x81211C")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x81194C", Offset = "0x81194C", VA = "0x81194C")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x8121E8", Offset = "0x8121E8", VA = "0x8121E8")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x812618", Offset = "0x812618", VA = "0x812618")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x8128C0", Offset = "0x8128C0", VA = "0x8128C0")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x812790", Offset = "0x812790", VA = "0x812790")]
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x8129C8", Offset = "0x8129C8", VA = "0x8129C8")]
	public LTGUI()
	{
	}
}
