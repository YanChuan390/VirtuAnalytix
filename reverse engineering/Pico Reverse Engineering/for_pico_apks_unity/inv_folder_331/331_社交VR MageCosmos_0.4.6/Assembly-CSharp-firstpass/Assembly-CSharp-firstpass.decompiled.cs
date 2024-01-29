using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class DoNotDestroyOnLoad_perName : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<string> list;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x752D90", Offset = "0x752D90", VA = "0x752D90")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x752E98", Offset = "0x752E98", VA = "0x752E98")]
	private void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x752F94", Offset = "0x752F94", VA = "0x752F94")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x752F98", Offset = "0x752F98", VA = "0x752F98")]
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
	[Address(RVA = "0x753028", Offset = "0x753028", VA = "0x753028")]
	private void Start()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x75302C", Offset = "0x75302C", VA = "0x75302C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x753030", Offset = "0x753030", VA = "0x753030")]
	public ExampleCam()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5C4524", Offset = "0x5C4524")]
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
	[Address(RVA = "0x7530B4", Offset = "0x7530B4", VA = "0x7530B4")]
	private void Start()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x75368C", Offset = "0x75368C", VA = "0x75368C")]
	private void playSound()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x753758", Offset = "0x753758", VA = "0x753758")]
	public void DoOutFullscreen()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x75378C", Offset = "0x75378C", VA = "0x75378C")]
	public void DoChangeEnvironment()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x753870", Offset = "0x753870", VA = "0x753870")]
	private void OnLevelWasLoaded()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x753310", Offset = "0x753310", VA = "0x753310")]
	private void InitCam()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x753874", Offset = "0x753874", VA = "0x753874")]
	public void DoSwitchAutoCam()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x7538E8", Offset = "0x7538E8", VA = "0x7538E8")]
	public void DoSwitchCameraEffects()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x753B24", Offset = "0x753B24", VA = "0x753B24")]
	public void DoSwitchAnimDelays()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x753CBC", Offset = "0x753CBC", VA = "0x753CBC")]
	public void DoAppear()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x753DB0", Offset = "0x753DB0", VA = "0x753DB0")]
	public void DoDisappear()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x753E68", Offset = "0x753E68", VA = "0x753E68")]
	public void DoNext()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x753EE8", Offset = "0x753EE8", VA = "0x753EE8")]
	public void DoPrevious()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x7531B4", Offset = "0x7531B4", VA = "0x7531B4")]
	private void CallInterface(InterfaceAnimManager _interface)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x753F6C", Offset = "0x753F6C", VA = "0x753F6C")]
	public void UpdateDisplayedInfo()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x754094", Offset = "0x754094", VA = "0x754094")]
	private void Update()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x7540CC", Offset = "0x7540CC", VA = "0x7540CC")]
	public ExampleUI()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5C4558", Offset = "0x5C4558")]
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
	[Address(RVA = "0x7541E0", Offset = "0x7541E0", VA = "0x7541E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x7541E4", Offset = "0x7541E4", VA = "0x7541E4")]
	private void playSound()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x7542D0", Offset = "0x7542D0", VA = "0x7542D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x7542D4", Offset = "0x7542D4", VA = "0x7542D4")]
	public void SetPosition(int _scaleValue)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x7543CC", Offset = "0x7543CC", VA = "0x7543CC")]
	public void SetPositionAndScaleTo(GameObject _object)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x754568", Offset = "0x754568", VA = "0x754568")]
	public void SetUniformScale(int _scaleValue)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x754660", Offset = "0x754660", VA = "0x754660")]
	public void SetUniformWidthHeight(int _widthHeightValue)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x7547C0", Offset = "0x7547C0", VA = "0x7547C0")]
	public void SetImageColor(int _colorID)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x7548E0", Offset = "0x7548E0", VA = "0x7548E0")]
	public void OpenWebPage()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x754944", Offset = "0x754944", VA = "0x754944")]
	public void GetSliderValue_ToText()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x7549C0", Offset = "0x7549C0", VA = "0x7549C0")]
	public ExcelsiorUtils()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5C458C", Offset = "0x5C458C")]
public class InterfaceAnimManager : MonoBehaviour
{
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C483C", Offset = "0x5C483C")]
	private sealed class <Disable_OnDisappearEnd>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <>1__state;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private object <>2__current;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public InterfaceAnimManager <>4__this;

		[Token(Token = "0x1700003F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x762614", Offset = "0x762614", VA = "0x762614", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x762694", Offset = "0x762694", VA = "0x762694", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x7612F0", Offset = "0x7612F0", VA = "0x7612F0")]
		[DebuggerHidden]
		public <Disable_OnDisappearEnd>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x762100", Offset = "0x762100", VA = "0x762100", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x762104", Offset = "0x762104", VA = "0x762104", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x76261C", Offset = "0x76261C", VA = "0x76261C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C484C", Offset = "0x5C484C")]
	private sealed class <>c
	{
		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Func<InterfaceAnmElement, int> <>9__27_0;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x7620D8", Offset = "0x7620D8", VA = "0x7620D8")]
		public <>c()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x7620E0", Offset = "0x7620E0", VA = "0x7620E0")]
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
	[Address(RVA = "0x75E540", Offset = "0x75E540", VA = "0x75E540")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x75E5A0", Offset = "0x75E5A0", VA = "0x75E5A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x75F9E0", Offset = "0x75F9E0", VA = "0x75F9E0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x760DB0", Offset = "0x760DB0", VA = "0x760DB0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C4BFC", Offset = "0x5C4BFC")]
	public IEnumerator Disable_OnDisappearEnd()
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x761310", Offset = "0x761310", VA = "0x761310", Slot = "4")]
	public virtual void startAppear(bool direct = false)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x760D9C", Offset = "0x760D9C", VA = "0x760D9C")]
	private void endAppear()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x76180C", Offset = "0x76180C", VA = "0x76180C", Slot = "5")]
	public virtual void startDisappear(bool direct = false)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x760E30", Offset = "0x760E30", VA = "0x760E30")]
	private void endDisappear()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x75E608", Offset = "0x75E608", VA = "0x75E608")]
	public void UpdateAnimClips()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x761A20", Offset = "0x761A20", VA = "0x761A20")]
	public bool isIAM_Root()
	{
		return default(bool);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x761F88", Offset = "0x761F88", VA = "0x761F88")]
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
	[Address(RVA = "0x761B68", Offset = "0x761B68", VA = "0x761B68")]
	public static InterfaceAnmElement Create(GameObject _gameObjectRef, int _newSortID, bool _isNested_IAM)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x76269C", Offset = "0x76269C", VA = "0x76269C", Slot = "4")]
	public virtual InterfaceAnmElement Confirm(GameObject _gameObjectRef, int _newSortID, bool isNested_IAM)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x761DF8", Offset = "0x761DF8", VA = "0x761DF8")]
	public void UpdateProperties()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x7627F0", Offset = "0x7627F0", VA = "0x7627F0", Slot = "5")]
	public virtual void Delete()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x762820", Offset = "0x762820", VA = "0x762820")]
	public void Update()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x762900", Offset = "0x762900", VA = "0x762900")]
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
	[Address(RVA = "0x1392C18", Offset = "0x1392C18", VA = "0x1392C18")]
	private void Start()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1392D24", Offset = "0x1392D24", VA = "0x1392D24")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1393220", Offset = "0x1393220", VA = "0x1393220")]
	public static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x13932E8", Offset = "0x13932E8", VA = "0x13932E8")]
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
		[Address(RVA = "0x764C98", Offset = "0x764C98", VA = "0x764C98")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000002")]
	public int id
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x764B8C", Offset = "0x764B8C", VA = "0x764B8C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x76414C", Offset = "0x76414C", VA = "0x76414C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x764B9C", Offset = "0x764B9C", VA = "0x764B9C")]
	public LTDescr()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x764BA4", Offset = "0x764BA4", VA = "0x764BA4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C4C6C", Offset = "0x5C4C6C")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x764DA0", Offset = "0x764DA0", VA = "0x764DA0")]
	public void reset()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x764F38", Offset = "0x764F38", VA = "0x764F38")]
	public void cleanup()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x764F68", Offset = "0x764F68", VA = "0x764F68")]
	public void init()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x767438", Offset = "0x767438", VA = "0x767438")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x767500", Offset = "0x767500", VA = "0x767500")]
	public LTDescr pause()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x76751C", Offset = "0x76751C", VA = "0x76751C")]
	public LTDescr resume()
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x767528", Offset = "0x767528", VA = "0x767528")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x767534", Offset = "0x767534", VA = "0x767534")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x76753C", Offset = "0x76753C", VA = "0x76753C")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x767544", Offset = "0x767544", VA = "0x767544")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x76754C", Offset = "0x76754C", VA = "0x76754C")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x767554", Offset = "0x767554", VA = "0x767554")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x76755C", Offset = "0x76755C", VA = "0x76755C")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x767634", Offset = "0x767634", VA = "0x767634")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x767750", Offset = "0x767750", VA = "0x767750")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x76779C", Offset = "0x76779C", VA = "0x76779C")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x7677A8", Offset = "0x7677A8", VA = "0x7677A8")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x7677B0", Offset = "0x7677B0", VA = "0x7677B0")]
	public LTDescr setId(uint id)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x76783C", Offset = "0x76783C", VA = "0x76783C")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x767844", Offset = "0x767844", VA = "0x767844")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x767890", Offset = "0x767890", VA = "0x767890")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x767898", Offset = "0x767898", VA = "0x767898")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x7678A0", Offset = "0x7678A0", VA = "0x7678A0")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x7678A8", Offset = "0x7678A8", VA = "0x7678A8")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x7678B0", Offset = "0x7678B0", VA = "0x7678B0")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x7678B8", Offset = "0x7678B8", VA = "0x7678B8")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x7678C0", Offset = "0x7678C0", VA = "0x7678C0")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x7678CC", Offset = "0x7678CC", VA = "0x7678CC")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x7678E8", Offset = "0x7678E8", VA = "0x7678E8")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x7678F0", Offset = "0x7678F0", VA = "0x7678F0")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x76790C", Offset = "0x76790C", VA = "0x76790C")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x767944", Offset = "0x767944", VA = "0x767944")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x76794C", Offset = "0x76794C", VA = "0x76794C")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x767954", Offset = "0x767954", VA = "0x767954")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x767964", Offset = "0x767964", VA = "0x767964")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x76796C", Offset = "0x76796C", VA = "0x76796C")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x76797C", Offset = "0x76797C", VA = "0x76797C")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x76798C", Offset = "0x76798C", VA = "0x76798C")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x76799C", Offset = "0x76799C", VA = "0x76799C")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x7679AC", Offset = "0x7679AC", VA = "0x7679AC")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x7679BC", Offset = "0x7679BC", VA = "0x7679BC")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x7679CC", Offset = "0x7679CC", VA = "0x7679CC")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x7679DC", Offset = "0x7679DC", VA = "0x7679DC")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x7679F4", Offset = "0x7679F4", VA = "0x7679F4")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x767A0C", Offset = "0x767A0C", VA = "0x767A0C")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x767A24", Offset = "0x767A24", VA = "0x767A24")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x767A3C", Offset = "0x767A3C", VA = "0x767A3C")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x767A44", Offset = "0x767A44", VA = "0x767A44")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x767AF8", Offset = "0x767AF8", VA = "0x767AF8")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x767B50", Offset = "0x767B50", VA = "0x767B50")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x767B58", Offset = "0x767B58", VA = "0x767B58")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x767CA0", Offset = "0x767CA0", VA = "0x767CA0")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x767CA8", Offset = "0x767CA8", VA = "0x767CA8")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x767CB4", Offset = "0x767CB4", VA = "0x767CB4")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x767CBC", Offset = "0x767CBC", VA = "0x767CBC")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x767888", Offset = "0x767888", VA = "0x767888")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x767CC4", Offset = "0x767CC4", VA = "0x767CC4")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x767CCC", Offset = "0x767CCC", VA = "0x767CCC")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x767CD4", Offset = "0x767CD4", VA = "0x767CD4")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x767CDC", Offset = "0x767CDC", VA = "0x767CDC")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x767D1C", Offset = "0x767D1C", VA = "0x767D1C")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x767D24", Offset = "0x767D24", VA = "0x767D24")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}
}
[Token(Token = "0x200000D")]
public class LTUtility
{
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x767F64", Offset = "0x767F64", VA = "0x767F64")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x76CB28", Offset = "0x76CB28", VA = "0x76CB28")]
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
		[Address(RVA = "0x76CEF0", Offset = "0x76CEF0", VA = "0x76CEF0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000004")]
	public static int tweensRunning
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x76CF68", Offset = "0x76CF68", VA = "0x76CF68")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000005")]
	public static GameObject tweenEmpty
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x77DF8C", Offset = "0x77DF8C", VA = "0x77DF8C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x76CB30", Offset = "0x76CB30", VA = "0x76CB30")]
	public static void init()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x76CBAC", Offset = "0x76CBAC", VA = "0x76CBAC")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x76D064", Offset = "0x76D064", VA = "0x76D064")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x76D1D0", Offset = "0x76D1D0", VA = "0x76D1D0")]
	public void Update()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x778BBC", Offset = "0x778BBC", VA = "0x778BBC")]
	public void OnLevelWasLoaded(int lvl)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x76D240", Offset = "0x76D240", VA = "0x76D240")]
	public static void update()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x77A654", Offset = "0x77A654", VA = "0x77A654")]
	private static void textAlphaRecursive(Transform trans, float val)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x77A508", Offset = "0x77A508", VA = "0x77A508")]
	private static Color tweenColor(LTDescr tween, float val)
	{
		return default(Color);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x764CA8", Offset = "0x764CA8", VA = "0x764CA8")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x778C2C", Offset = "0x778C2C", VA = "0x778C2C")]
	public static void removeTween(int i)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x77AB40", Offset = "0x77AB40", VA = "0x77AB40")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x766CF0", Offset = "0x766CF0", VA = "0x766CF0")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x77AD7C", Offset = "0x77AD7C", VA = "0x77AD7C")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x77ADF0", Offset = "0x77ADF0", VA = "0x77ADF0")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x77B064", Offset = "0x77B064", VA = "0x77B064")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x77B0E0", Offset = "0x77B0E0", VA = "0x77B0E0")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x77B3E8", Offset = "0x77B3E8", VA = "0x77B3E8")]
	public static void cancel(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x77B654", Offset = "0x77B654", VA = "0x77B654")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x77B7C8", Offset = "0x77B7C8", VA = "0x77B7C8")]
	public static void cancel(int uniqueId)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x77B844", Offset = "0x77B844", VA = "0x77B844")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x77BA40", Offset = "0x77BA40", VA = "0x77BA40")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x77BDD0", Offset = "0x77BDD0", VA = "0x77BDD0")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x77BE48", Offset = "0x77BE48", VA = "0x77BE48")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x77C124", Offset = "0x77C124", VA = "0x77C124")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C4CA0", Offset = "0x5C4CA0")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x77C19C", Offset = "0x77C19C", VA = "0x77C19C")]
	public static void pause(int uniqueId)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x77C2E8", Offset = "0x77C2E8", VA = "0x77C2E8")]
	public static void pause(GameObject gameObject)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x77C4BC", Offset = "0x77C4BC", VA = "0x77C4BC")]
	public static void pauseAll()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x77C5E4", Offset = "0x77C5E4", VA = "0x77C5E4")]
	public static void resumeAll()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x77C6FC", Offset = "0x77C6FC", VA = "0x77C6FC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C4CD4", Offset = "0x5C4CD4")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x77C774", Offset = "0x77C774", VA = "0x77C774")]
	public static void resume(int uniqueId)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x77C8B0", Offset = "0x77C8B0", VA = "0x77C8B0")]
	public static void resume(GameObject gameObject)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x77CA6C", Offset = "0x77CA6C", VA = "0x77CA6C")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x77CD28", Offset = "0x77CD28", VA = "0x77CD28")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x77CEAC", Offset = "0x77CEAC", VA = "0x77CEAC")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x77D020", Offset = "0x77D020", VA = "0x77D020")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x7635F0", Offset = "0x7635F0", VA = "0x7635F0")]
	public static object logError(string error)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x77D9DC", Offset = "0x77D9DC", VA = "0x77D9DC")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x77DB10", Offset = "0x77DB10", VA = "0x77DB10")]
	public static LTDescr options()
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x77E014", Offset = "0x77E014", VA = "0x77E014")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, TweenAction tweenAction, LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x77E13C", Offset = "0x77E13C", VA = "0x77E13C")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x77E2A4", Offset = "0x77E2A4", VA = "0x77E2A4")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x77E37C", Offset = "0x77E37C", VA = "0x77E37C")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x77E480", Offset = "0x77E480", VA = "0x77E480")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x77E574", Offset = "0x77E574", VA = "0x77E574")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x77E64C", Offset = "0x77E64C", VA = "0x77E64C")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x77E76C", Offset = "0x77E76C", VA = "0x77E76C")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x77E8B0", Offset = "0x77E8B0", VA = "0x77E8B0")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x77E9AC", Offset = "0x77E9AC", VA = "0x77E9AC")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x77EAA8", Offset = "0x77EAA8", VA = "0x77EAA8")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x77EBA0", Offset = "0x77EBA0", VA = "0x77EBA0")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x77EC98", Offset = "0x77EC98", VA = "0x77EC98")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x77EDAC", Offset = "0x77EDAC", VA = "0x77EDAC")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x77EE64", Offset = "0x77EE64", VA = "0x77EE64")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x77EF78", Offset = "0x77EF78", VA = "0x77EF78")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x77F168", Offset = "0x77F168", VA = "0x77F168")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x77F270", Offset = "0x77F270", VA = "0x77F270")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x77F378", Offset = "0x77F378", VA = "0x77F378")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x77F4A0", Offset = "0x77F4A0", VA = "0x77F4A0")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x77F5C8", Offset = "0x77F5C8", VA = "0x77F5C8")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x77F6D4", Offset = "0x77F6D4", VA = "0x77F6D4")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x77F7E0", Offset = "0x77F7E0", VA = "0x77F7E0")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x77F8B4", Offset = "0x77F8B4", VA = "0x77F8B4")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x77F98C", Offset = "0x77F98C", VA = "0x77F98C")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x77FA64", Offset = "0x77FA64", VA = "0x77FA64")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x77FB1C", Offset = "0x77FB1C", VA = "0x77FB1C")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x77FD0C", Offset = "0x77FD0C", VA = "0x77FD0C")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x77FDE4", Offset = "0x77FDE4", VA = "0x77FDE4")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x77FEBC", Offset = "0x77FEBC", VA = "0x77FEBC")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x77FF94", Offset = "0x77FF94", VA = "0x77FF94")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x78009C", Offset = "0x78009C", VA = "0x78009C")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x7801A4", Offset = "0x7801A4", VA = "0x7801A4")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x78025C", Offset = "0x78025C", VA = "0x78025C")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x78034C", Offset = "0x78034C", VA = "0x78034C")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x780404", Offset = "0x780404", VA = "0x780404")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x7804DC", Offset = "0x7804DC", VA = "0x7804DC")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x7805B4", Offset = "0x7805B4", VA = "0x7805B4")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x78068C", Offset = "0x78068C", VA = "0x78068C")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x780784", Offset = "0x780784", VA = "0x780784")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x78087C", Offset = "0x78087C", VA = "0x78087C")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x780934", Offset = "0x780934", VA = "0x780934")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x780A40", Offset = "0x780A40", VA = "0x780A40")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x780B18", Offset = "0x780B18", VA = "0x780B18")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x780BF0", Offset = "0x780BF0", VA = "0x780BF0")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x780CC8", Offset = "0x780CC8", VA = "0x780CC8")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x780DE4", Offset = "0x780DE4", VA = "0x780DE4")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x780F50", Offset = "0x780F50", VA = "0x780F50")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x781038", Offset = "0x781038", VA = "0x781038")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x7811A4", Offset = "0x7811A4", VA = "0x7811A4")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x78131C", Offset = "0x78131C", VA = "0x78131C")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x781494", Offset = "0x781494", VA = "0x781494")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x781688", Offset = "0x781688", VA = "0x781688")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x781810", Offset = "0x781810", VA = "0x781810")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x781938", Offset = "0x781938", VA = "0x781938")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x781AB0", Offset = "0x781AB0", VA = "0x781AB0")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x781BE8", Offset = "0x781BE8", VA = "0x781BE8")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x781D1C", Offset = "0x781D1C", VA = "0x781D1C")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x781E00", Offset = "0x781E00", VA = "0x781E00")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x781F04", Offset = "0x781F04", VA = "0x781F04")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x782008", Offset = "0x782008", VA = "0x782008")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x78210C", Offset = "0x78210C", VA = "0x78210C")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x782258", Offset = "0x782258", VA = "0x782258")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x782380", Offset = "0x782380", VA = "0x782380")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x7824A8", Offset = "0x7824A8", VA = "0x7824A8")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x78258C", Offset = "0x78258C", VA = "0x78258C")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x782690", Offset = "0x782690", VA = "0x782690")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x77912C", Offset = "0x77912C", VA = "0x77912C")]
	private static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x77AA34", Offset = "0x77AA34", VA = "0x77AA34")]
	private static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x7791A4", Offset = "0x7791A4", VA = "0x7791A4")]
	private static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x7791C8", Offset = "0x7791C8", VA = "0x7791C8")]
	private static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x7791E4", Offset = "0x7791E4", VA = "0x7791E4")]
	private static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x7827E8", Offset = "0x7827E8", VA = "0x7827E8")]
	private static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x782874", Offset = "0x782874", VA = "0x782874")]
	private static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x77A3FC", Offset = "0x77A3FC", VA = "0x77A3FC")]
	private static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x78295C", Offset = "0x78295C", VA = "0x78295C")]
	private static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x78297C", Offset = "0x78297C", VA = "0x78297C")]
	private static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x7829A4", Offset = "0x7829A4", VA = "0x7829A4")]
	private static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x779244", Offset = "0x779244", VA = "0x779244")]
	private static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x779268", Offset = "0x779268", VA = "0x779268")]
	private static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x779298", Offset = "0x779298", VA = "0x779298")]
	private static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x779300", Offset = "0x779300", VA = "0x779300")]
	private static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x779328", Offset = "0x779328", VA = "0x779328")]
	private static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x779358", Offset = "0x779358", VA = "0x779358")]
	private static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x7793C4", Offset = "0x7793C4", VA = "0x7793C4")]
	private static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x7793F0", Offset = "0x7793F0", VA = "0x7793F0")]
	private static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x779428", Offset = "0x779428", VA = "0x779428")]
	private static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x7794A0", Offset = "0x7794A0", VA = "0x7794A0")]
	private static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x77954C", Offset = "0x77954C", VA = "0x77954C")]
	private static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x7795F4", Offset = "0x7795F4", VA = "0x7795F4")]
	private static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x7796AC", Offset = "0x7796AC", VA = "0x7796AC")]
	private static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x779758", Offset = "0x779758", VA = "0x779758")]
	private static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x779804", Offset = "0x779804", VA = "0x779804")]
	private static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x779928", Offset = "0x779928", VA = "0x779928")]
	private static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x7799EC", Offset = "0x7799EC", VA = "0x7799EC")]
	private static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x779AAC", Offset = "0x779AAC", VA = "0x779AAC")]
	private static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x779BCC", Offset = "0x779BCC", VA = "0x779BCC")]
	private static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x779C80", Offset = "0x779C80", VA = "0x779C80")]
	private static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x779D4C", Offset = "0x779D4C", VA = "0x779D4C")]
	private static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x779E4C", Offset = "0x779E4C", VA = "0x779E4C")]
	private static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x779E8C", Offset = "0x779E8C", VA = "0x779E8C")]
	private static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x779ED4", Offset = "0x779ED4", VA = "0x779ED4")]
	private static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x779F6C", Offset = "0x779F6C", VA = "0x779F6C")]
	private static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x77A0C0", Offset = "0x77A0C0", VA = "0x77A0C0")]
	private static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x77A208", Offset = "0x77A208", VA = "0x77A208")]
	private static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x782A08", Offset = "0x782A08", VA = "0x782A08")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x782A8C", Offset = "0x782A8C", VA = "0x782A8C")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x7830D8", Offset = "0x7830D8", VA = "0x7830D8")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x78315C", Offset = "0x78315C", VA = "0x78315C")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x78340C", Offset = "0x78340C", VA = "0x78340C")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x783488", Offset = "0x783488", VA = "0x783488")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x783728", Offset = "0x783728", VA = "0x783728")]
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
	[Address(RVA = "0x7629A4", Offset = "0x7629A4", VA = "0x7629A4")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x762F2C", Offset = "0x762F2C", VA = "0x762F2C")]
	private float map(float u)
	{
		return default(float);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x762DCC", Offset = "0x762DCC", VA = "0x762DCC")]
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x76311C", Offset = "0x76311C", VA = "0x76311C")]
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
	[Address(RVA = "0x76314C", Offset = "0x76314C", VA = "0x76314C")]
	public LTBezierPath()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x763154", Offset = "0x763154", VA = "0x763154")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x76317C", Offset = "0x76317C", VA = "0x76317C")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x76378C", Offset = "0x76378C", VA = "0x76378C")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x763950", Offset = "0x763950", VA = "0x763950")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x763B1C", Offset = "0x763B1C", VA = "0x763B1C")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x763D30", Offset = "0x763D30", VA = "0x763D30")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x763DDC", Offset = "0x763DDC", VA = "0x763DDC")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x763E98", Offset = "0x763E98", VA = "0x763E98")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x763F44", Offset = "0x763F44", VA = "0x763F44")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x764048", Offset = "0x764048", VA = "0x764048")]
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
	[Address(RVA = "0x76809C", Offset = "0x76809C", VA = "0x76809C")]
	public LTSpline(params Vector3[] pts)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x76C088", Offset = "0x76C088", VA = "0x76C088")]
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x76BB58", Offset = "0x76BB58", VA = "0x76BB58")]
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x76C2D0", Offset = "0x76C2D0", VA = "0x76C2D0")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x76C2F0", Offset = "0x76C2F0", VA = "0x76C2F0")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x76C4C0", Offset = "0x76C4C0", VA = "0x76C4C0")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x76C6D8", Offset = "0x76C6D8", VA = "0x76C6D8")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x76C784", Offset = "0x76C784", VA = "0x76C784")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x76C848", Offset = "0x76C848", VA = "0x76C848")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x76C8F4", Offset = "0x76C8F4", VA = "0x76C8F4")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x76CA00", Offset = "0x76CA00", VA = "0x76CA00")]
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
		[Address(RVA = "0x769E0C", Offset = "0x769E0C", VA = "0x769E0C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000007")]
	public int id
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x76A93C", Offset = "0x76A93C", VA = "0x76A93C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000008")]
	public float x
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x76B65C", Offset = "0x76B65C", VA = "0x76B65C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x76B668", Offset = "0x76B668", VA = "0x76B668")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public float y
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x76B674", Offset = "0x76B674", VA = "0x76B674")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x76B680", Offset = "0x76B680", VA = "0x76B680")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public float width
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x76B68C", Offset = "0x76B68C", VA = "0x76B68C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x76B698", Offset = "0x76B698", VA = "0x76B698")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public float height
	{
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x76B6A4", Offset = "0x76B6A4", VA = "0x76B6A4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x76B6B0", Offset = "0x76B6B0", VA = "0x76B6B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public Rect rect
	{
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x766DE0", Offset = "0x766DE0", VA = "0x766DE0")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x76B6BC", Offset = "0x76B6BC", VA = "0x76B6BC")]
		set
		{
		}
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x76B1FC", Offset = "0x76B1FC", VA = "0x76B1FC")]
	public LTRect()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x767BE8", Offset = "0x767BE8", VA = "0x767BE8")]
	public LTRect(Rect rect)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x76B380", Offset = "0x76B380", VA = "0x76B380")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x76B46C", Offset = "0x76B46C", VA = "0x76B46C")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x76B554", Offset = "0x76B554", VA = "0x76B554")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x76A94C", Offset = "0x76A94C", VA = "0x76A94C")]
	public void setId(int id, int counter)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x76B2D0", Offset = "0x76B2D0", VA = "0x76B2D0")]
	public void reset()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x7670C0", Offset = "0x7670C0", VA = "0x7670C0")]
	public void resetForRotation()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x76B6CC", Offset = "0x76B6CC", VA = "0x76B6CC")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x76B6D4", Offset = "0x76B6D4", VA = "0x76B6D4")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x76B6DC", Offset = "0x76B6DC", VA = "0x76B6DC")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x76B6FC", Offset = "0x76B6FC", VA = "0x76B6FC")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x76B704", Offset = "0x76B704", VA = "0x76B704")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x76B70C", Offset = "0x76B70C", VA = "0x76B70C")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x76B730", Offset = "0x76B730", VA = "0x76B730")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x76B7B0", Offset = "0x76B7B0", VA = "0x76B7B0")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x76B7B8", Offset = "0x76B7B8", VA = "0x76B7B8", Slot = "3")]
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
	[Address(RVA = "0x768498", Offset = "0x768498", VA = "0x768498")]
	public LTEvent(int id, object data)
	{
	}
}
[Token(Token = "0x2000014")]
public class LTGUI
{
	[Token(Token = "0x2000028")]
	public enum Element_Type
	{
		[Token(Token = "0x40001D7")]
		Texture,
		[Token(Token = "0x40001D8")]
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
	[Address(RVA = "0x7684C0", Offset = "0x7684C0", VA = "0x7684C0")]
	public static void init()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x7685B4", Offset = "0x7685B4", VA = "0x7685B4")]
	public static void initRectCheck()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x768770", Offset = "0x768770", VA = "0x768770")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x768974", Offset = "0x768974", VA = "0x768974")]
	public static void update(int updateLevel)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x769B0C", Offset = "0x769B0C", VA = "0x769B0C")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x769C10", Offset = "0x769C10", VA = "0x769C10")]
	public static void destroy(int id)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x769E20", Offset = "0x769E20", VA = "0x769E20")]
	public static void destroyAll(int depth)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x769F44", Offset = "0x769F44", VA = "0x769F44")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x76A00C", Offset = "0x76A00C", VA = "0x76A00C")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x76A7C4", Offset = "0x76A7C4", VA = "0x76A7C4")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x76A88C", Offset = "0x76A88C", VA = "0x76A88C")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x76A0BC", Offset = "0x76A0BC", VA = "0x76A0BC")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x76A958", Offset = "0x76A958", VA = "0x76A958")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x76AD88", Offset = "0x76AD88", VA = "0x76AD88")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x76B030", Offset = "0x76B030", VA = "0x76B030")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x76AF00", Offset = "0x76AF00", VA = "0x76AF00")]
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x76B138", Offset = "0x76B138", VA = "0x76B138")]
	public LTGUI()
	{
	}
}
namespace HighlightingSystem;

[Token(Token = "0x2000015")]
public enum LoopMode
{
	[Token(Token = "0x4000133")]
	Once,
	[Token(Token = "0x4000134")]
	Loop,
	[Token(Token = "0x4000135")]
	PingPong,
	[Token(Token = "0x4000136")]
	ClampForever
}
[Token(Token = "0x2000016")]
public enum Easing
{
	[Token(Token = "0x4000138")]
	Linear,
	[Token(Token = "0x4000139")]
	QuadIn,
	[Token(Token = "0x400013A")]
	QuadOut,
	[Token(Token = "0x400013B")]
	QuadInOut,
	[Token(Token = "0x400013C")]
	CubicIn,
	[Token(Token = "0x400013D")]
	CubicOut,
	[Token(Token = "0x400013E")]
	CubicInOut,
	[Token(Token = "0x400013F")]
	SineIn,
	[Token(Token = "0x4000140")]
	SineOut,
	[Token(Token = "0x4000141")]
	SineInOut
}
[Token(Token = "0x2000017")]
public enum RendererFilterMode
{
	[Token(Token = "0x4000143")]
	None,
	[Token(Token = "0x4000144")]
	Include,
	[Token(Token = "0x4000145")]
	Exclude
}
[Token(Token = "0x2000018")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5C45C0", Offset = "0x5C45C0")]
public class Highlighter : HighlighterCore
{
	[Token(Token = "0x4000146")]
	protected const float HALFPI = (float)Math.PI / 2f;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected bool _overlay;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	[SerializeField]
	protected bool _occluder;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	protected Color _hoverColor;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	protected int _hoverFrame;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	protected bool _tween;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	protected Gradient _tweenGradient;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	protected float _tweenDuration;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	protected bool _tweenReverse;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	protected LoopMode _tweenLoop;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[SerializeField]
	protected Easing _tweenEasing;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	protected float _tweenDelay;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[SerializeField]
	protected int _tweenRepeatCount;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	protected bool _tweenUseUnscaledTime;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	[SerializeField]
	protected bool _constant;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[SerializeField]
	protected Color _constantColor;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[SerializeField]
	protected float _constantFadeInTime;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	protected float _constantFadeOutTime;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[SerializeField]
	protected Easing _constantEasing;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	protected bool _constantUseUnscaledTime;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	[SerializeField]
	protected RendererFilterMode _filterMode;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	protected List<Transform> _filterList;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	protected bool _tweenEnabled;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected float _tweenStart;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	protected bool _constantEnabled;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected float _constantStart;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	protected float _constantDuration;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private GradientColorKey[] flashingColorKeys;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private GradientAlphaKey[] flashingAlphaKeys;

	[Token(Token = "0x1700000D")]
	public bool overlay
	{
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x755248", Offset = "0x755248", VA = "0x755248")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x755250", Offset = "0x755250", VA = "0x755250")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public bool occluder
	{
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x755258", Offset = "0x755258", VA = "0x755258")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x755260", Offset = "0x755260", VA = "0x755260")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public bool tween
	{
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x755268", Offset = "0x755268", VA = "0x755268")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x755270", Offset = "0x755270", VA = "0x755270")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public Gradient tweenGradient
	{
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x7552CC", Offset = "0x7552CC", VA = "0x7552CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x7552D4", Offset = "0x7552D4", VA = "0x7552D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public float tweenDuration
	{
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x7552DC", Offset = "0x7552DC", VA = "0x7552DC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x7552E4", Offset = "0x7552E4", VA = "0x7552E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public float tweenDelay
	{
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x755364", Offset = "0x755364", VA = "0x755364")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x75536C", Offset = "0x75536C", VA = "0x75536C")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public bool tweenUseUnscaledTime
	{
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x755374", Offset = "0x755374", VA = "0x755374")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x75537C", Offset = "0x75537C", VA = "0x75537C")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public LoopMode tweenLoop
	{
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x755420", Offset = "0x755420", VA = "0x755420")]
		get
		{
			return default(LoopMode);
		}
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x755428", Offset = "0x755428", VA = "0x755428")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public Easing tweenEasing
	{
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x755430", Offset = "0x755430", VA = "0x755430")]
		get
		{
			return default(Easing);
		}
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x755438", Offset = "0x755438", VA = "0x755438")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public bool tweenReverse
	{
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x755440", Offset = "0x755440", VA = "0x755440")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x755448", Offset = "0x755448", VA = "0x755448")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public int tweenRepeatCount
	{
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x755450", Offset = "0x755450", VA = "0x755450")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x755458", Offset = "0x755458", VA = "0x755458")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public bool constant
	{
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x755460", Offset = "0x755460", VA = "0x755460")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x755468", Offset = "0x755468", VA = "0x755468")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public Color constantColor
	{
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x7554B8", Offset = "0x7554B8", VA = "0x7554B8")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x7554C8", Offset = "0x7554C8", VA = "0x7554C8")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public float constantFadeTime
	{
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x7554D8", Offset = "0x7554D8", VA = "0x7554D8")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public float constantFadeInTime
	{
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x755518", Offset = "0x755518", VA = "0x755518")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x755520", Offset = "0x755520", VA = "0x755520")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public float constantFadeOutTime
	{
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x755574", Offset = "0x755574", VA = "0x755574")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x75557C", Offset = "0x75557C", VA = "0x75557C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public bool constantUseUnscaledTime
	{
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x7555CC", Offset = "0x7555CC", VA = "0x7555CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x7555D4", Offset = "0x7555D4", VA = "0x7555D4")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public Easing constantEasing
	{
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x755678", Offset = "0x755678", VA = "0x755678")]
		get
		{
			return default(Easing);
		}
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x755680", Offset = "0x755680", VA = "0x755680")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public RendererFilterMode filterMode
	{
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x755688", Offset = "0x755688", VA = "0x755688")]
		get
		{
			return default(RendererFilterMode);
		}
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x755690", Offset = "0x755690", VA = "0x755690")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public List<Transform> filterList
	{
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x7556B4", Offset = "0x7556B4", VA = "0x7556B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000021")]
	protected override RendererFilter rendererFilterToUse
	{
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x7556BC", Offset = "0x7556BC", VA = "0x7556BC", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000022")]
	protected bool hover
	{
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x7558D4", Offset = "0x7558D4", VA = "0x7558D4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x7558F8", Offset = "0x7558F8", VA = "0x7558F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	protected float constantValue
	{
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x755930", Offset = "0x755930", VA = "0x755930")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x755A04", Offset = "0x755A04", VA = "0x755A04", Slot = "10")]
	protected virtual void OnDidApplyAnimationProperties()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x755A74", Offset = "0x755A74", VA = "0x755A74", Slot = "6")]
	protected override void OnEnableSafe()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x755A78", Offset = "0x755A78", VA = "0x755A78", Slot = "7")]
	protected override void OnDisableSafe()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x755A08", Offset = "0x755A08", VA = "0x755A08")]
	protected void ValidateAll()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x755324", Offset = "0x755324", VA = "0x755324")]
	protected void ValidateRanges()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x755ACC", Offset = "0x755ACC", VA = "0x755ACC")]
	public void Hover(Color color)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x755B08", Offset = "0x755B08", VA = "0x755B08")]
	public void ConstantOn(float fadeTime = 0.25f)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x755C04", Offset = "0x755C04", VA = "0x755C04")]
	public void ConstantOn(Color color, float fadeTime = 0.25f)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x755C34", Offset = "0x755C34", VA = "0x755C34")]
	public void ConstantOff(float fadeTime = 0.25f)
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x755C3C", Offset = "0x755C3C", VA = "0x755C3C")]
	public void ConstantSwitch(float fadeTime = 0.25f)
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x755C4C", Offset = "0x755C4C", VA = "0x755C4C")]
	public void ConstantOnImmediate()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x755C58", Offset = "0x755C58", VA = "0x755C58")]
	public void ConstantOnImmediate(Color color)
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x755C78", Offset = "0x755C78", VA = "0x755C78")]
	public void ConstantOffImmediate()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x755C84", Offset = "0x755C84", VA = "0x755C84")]
	public void ConstantSwitchImmediate()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x755C98", Offset = "0x755C98", VA = "0x755C98")]
	public void Off()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x755CD8", Offset = "0x755CD8", VA = "0x755CD8")]
	public void TweenStart()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x755CE0", Offset = "0x755CE0", VA = "0x755CE0")]
	public void TweenStop()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x755274", Offset = "0x755274", VA = "0x755274")]
	public void TweenSet(bool value)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x755B10", Offset = "0x755B10", VA = "0x755B10")]
	public void ConstantSet(float fadeTime, bool value)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x755AC4", Offset = "0x755AC4", VA = "0x755AC4")]
	protected void TweenSet()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x755510", Offset = "0x755510", VA = "0x755510")]
	protected void ConstantSet()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x75546C", Offset = "0x75546C", VA = "0x75546C")]
	protected void ConstantSet(bool value)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x755CE8", Offset = "0x755CE8", VA = "0x755CE8", Slot = "9")]
	protected override void UpdateHighlighting()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x7562AC", Offset = "0x7562AC", VA = "0x7562AC")]
	protected bool TransformFilterInclude(Renderer renderer, List<int> submeshIndices)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x756408", Offset = "0x756408", VA = "0x756408")]
	protected bool TransformFilterExclude(Renderer renderer, List<int> submeshIndices)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x755E88", Offset = "0x755E88", VA = "0x755E88")]
	protected float Loop(float x, LoopMode loop, bool reverse = false, int repeatCount = -1)
	{
		return default(float);
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x75607C", Offset = "0x75607C", VA = "0x75607C")]
	protected float Ease(float x, Easing easing)
	{
		return default(float);
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x755404", Offset = "0x755404", VA = "0x755404")]
	protected float GetTweenTime()
	{
		return default(float);
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x75565C", Offset = "0x75565C", VA = "0x75565C")]
	protected float GetConstantTime()
	{
		return default(float);
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x75656C", Offset = "0x75656C", VA = "0x75656C")]
	public static Color HSVToRGB(float hue, float saturation, float value)
	{
		return default(Color);
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x756714", Offset = "0x756714", VA = "0x756714")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C4D08", Offset = "0x5C4D08")]
	public void On()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x756740", Offset = "0x756740", VA = "0x756740")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C4D18", Offset = "0x5C4D18")]
	public void On(Color color)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x756760", Offset = "0x756760", VA = "0x756760")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C4D28", Offset = "0x5C4D28")]
	public void OnParams(Color color)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x756770", Offset = "0x756770", VA = "0x756770")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C4D38", Offset = "0x5C4D38")]
	public void ConstantParams(Color color)
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x756780", Offset = "0x756780", VA = "0x756780")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C4D48", Offset = "0x5C4D48")]
	public void FlashingParams(Color color1, Color color2, float freq)
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x756860", Offset = "0x756860", VA = "0x756860")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C4D58", Offset = "0x5C4D58")]
	public void FlashingOn()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x756868", Offset = "0x756868", VA = "0x756868")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C4D68", Offset = "0x5C4D68")]
	public void FlashingOn(Color color1, Color color2)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x756960", Offset = "0x756960", VA = "0x756960")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C4D78", Offset = "0x5C4D78")]
	public void FlashingOn(Color color1, Color color2, float freq)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x756A78", Offset = "0x756A78", VA = "0x756A78")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C4D88", Offset = "0x5C4D88")]
	public void FlashingOn(float freq)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x756A90", Offset = "0x756A90", VA = "0x756A90")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C4D98", Offset = "0x5C4D98")]
	public void FlashingOff()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x756A98", Offset = "0x756A98", VA = "0x756A98")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C4DA8", Offset = "0x5C4DA8")]
	public void FlashingSwitch()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x756AA8", Offset = "0x756AA8", VA = "0x756AA8")]
	public Highlighter()
	{
	}
}
[Token(Token = "0x2000019")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5C45F8", Offset = "0x5C45F8")]
public class HighlighterBlocker : MonoBehaviour
{
	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x757120", Offset = "0x757120", VA = "0x757120")]
	public HighlighterBlocker()
	{
	}
}
[Token(Token = "0x200001A")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x5C4630", Offset = "0x5C4630")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5C4630", Offset = "0x5C4630")]
public class HighlightingBlitter : MonoBehaviour
{
	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	protected List<HighlightingBase> renderers;

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x75D554", Offset = "0x75D554", VA = "0x75D554", Slot = "4")]
	protected virtual void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x75D690", Offset = "0x75D690", VA = "0x75D690", Slot = "5")]
	[ExcludeFromDocs]
	public virtual void Register(HighlightingBase renderer)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x75D764", Offset = "0x75D764", VA = "0x75D764", Slot = "6")]
	[ExcludeFromDocs]
	public virtual void Unregister(HighlightingBase renderer)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x75D83C", Offset = "0x75D83C", VA = "0x75D83C")]
	public HighlightingBlitter()
	{
	}
}
[Token(Token = "0x200001B")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5C46CC", Offset = "0x5C46CC")]
public class HighlightingRenderer : HighlightingBase
{
	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly List<HighlightingPreset> defaultPresets;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private List<HighlightingPreset> _presets;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private ReadOnlyCollection<HighlightingPreset> _presetsReadonly;

	[Token(Token = "0x17000024")]
	public ReadOnlyCollection<HighlightingPreset> presets
	{
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x75D9FC", Offset = "0x75D9FC", VA = "0x75D9FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x75DA78", Offset = "0x75DA78", VA = "0x75DA78")]
	public bool GetPreset(string name, out HighlightingPreset preset)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x75DBA0", Offset = "0x75DBA0", VA = "0x75DBA0")]
	public bool AddPreset(HighlightingPreset preset, bool overwrite)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x75DD40", Offset = "0x75DD40", VA = "0x75DD40")]
	public bool RemovePreset(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x75DE2C", Offset = "0x75DE2C", VA = "0x75DE2C")]
	public bool LoadPreset(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x75DE98", Offset = "0x75DE98", VA = "0x75DE98")]
	public void ApplyPreset(HighlightingPreset preset)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x75DF08", Offset = "0x75DF08", VA = "0x75DF08")]
	public void ClearPresets()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x75DF74", Offset = "0x75DF74", VA = "0x75DF74")]
	public HighlightingRenderer()
	{
	}
}
[Token(Token = "0x200001C")]
[ExcludeFromDocs]
public class EndOfFrame : MonoBehaviour
{
	[Token(Token = "0x2000029")]
	[ExcludeFromDocs]
	public delegate void OnEndOfFrame();

	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C486C", Offset = "0x5C486C")]
	private sealed class <EndOfFrameRoutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <>1__state;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private object <>2__current;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EndOfFrame <>4__this;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x755174", Offset = "0x755174", VA = "0x755174", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x7551F4", Offset = "0x7551F4", VA = "0x7551F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x754D30", Offset = "0x754D30", VA = "0x754D30")]
		[DebuggerHidden]
		public <EndOfFrameRoutine>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x754DF8", Offset = "0x754DF8", VA = "0x754DF8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x754DFC", Offset = "0x754DFC", VA = "0x754DFC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x75517C", Offset = "0x75517C", VA = "0x75517C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static EndOfFrame _singleton;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private WaitForEndOfFrame waitForEndOfFrame;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Coroutine coroutine;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private List<OnEndOfFrame> listeners;

	[Token(Token = "0x17000025")]
	private static EndOfFrame singleton
	{
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x7549C8", Offset = "0x7549C8", VA = "0x7549C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x754AFC", Offset = "0x754AFC", VA = "0x754AFC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x754BA4", Offset = "0x754BA4", VA = "0x754BA4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x754BB8", Offset = "0x754BB8", VA = "0x754BB8")]
	public static void AddListener(OnEndOfFrame listener)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x754C48", Offset = "0x754C48", VA = "0x754C48")]
	public static void RemoveListener(OnEndOfFrame listener)
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x754B24", Offset = "0x754B24", VA = "0x754B24")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5C4DD8", Offset = "0x5C4DD8")]
	private IEnumerator EndOfFrameRoutine()
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x754D50", Offset = "0x754D50", VA = "0x754D50")]
	public EndOfFrame()
	{
	}
}
[Token(Token = "0x200001D")]
public enum HighlighterMode
{
	[Token(Token = "0x400016C")]
	Disabled = -1,
	[Token(Token = "0x400016D")]
	Default,
	[Token(Token = "0x400016E")]
	Overlay,
	[Token(Token = "0x400016F")]
	Occluder
}
[Token(Token = "0x200001E")]
[DisallowMultipleComponent]
public class HighlighterCore : MonoBehaviour
{
	[Token(Token = "0x200002B")]
	[ExcludeFromDocs]
	private class RendererData
	{
		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Renderer renderer;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public List<int> submeshIndices;

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x759E84", Offset = "0x759E84", VA = "0x759E84")]
		public RendererData()
		{
		}
	}

	[Token(Token = "0x200002C")]
	public delegate bool RendererFilter(Renderer renderer, List<int> submeshIndices);

	[Token(Token = "0x4000170")]
	[ExcludeFromDocs]
	public const string keywordOverlay = "HIGHLIGHTING_OVERLAY";

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private readonly Color occluderColor;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly HighlighterMode[] renderingOrder;

	[Token(Token = "0x4000173")]
	private const int poolChunkSize = 4;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly List<Renderer> sRenderers;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly Stack<RendererData> sRendererDataPool;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly List<RendererData> sRendererData;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly List<int> sSubmeshIndices;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static readonly List<HighlighterCore> sHighlighters;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static ReadOnlyCollection<HighlighterCore> sHighlightersReadonly;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public HighlighterMode mode;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool forceRender;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color color;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Transform tr;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<HighlighterRenderer> highlightableRenderers;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool isDirty;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	private bool cachedOverlay;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Color cachedColor;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static Shader _opaqueShader;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Shader _transparentShader;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material _opaqueMaterial;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static RendererFilter _globalRendererFilter;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private RendererFilter _rendererFilter;

	[Token(Token = "0x17000026")]
	public static ReadOnlyCollection<HighlighterCore> highlighters
	{
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x757128", Offset = "0x757128", VA = "0x757128")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000027")]
	[ExcludeFromDocs]
	public static Shader opaqueShader
	{
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x75722C", Offset = "0x75722C", VA = "0x75722C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000028")]
	[ExcludeFromDocs]
	public static Shader transparentShader
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x757364", Offset = "0x757364", VA = "0x757364")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000029")]
	private Material opaqueMaterial
	{
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x75749C", Offset = "0x75749C", VA = "0x75749C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	public static RendererFilter globalRendererFilter
	{
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x75766C", Offset = "0x75766C", VA = "0x75766C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x7576E4", Offset = "0x7576E4", VA = "0x7576E4")]
		set
		{
		}
	}

	[Token(Token = "0x1700002B")]
	public RendererFilter rendererFilter
	{
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x7578F4", Offset = "0x7578F4", VA = "0x7578F4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x7578FC", Offset = "0x7578FC", VA = "0x7578FC")]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	protected virtual RendererFilter rendererFilterToUse
	{
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x75792C", Offset = "0x75792C", VA = "0x75792C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x757A2C", Offset = "0x757A2C", VA = "0x757A2C")]
	public static bool DefaultRendererFilter(Renderer renderer, List<int> submeshIndices)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x757BB0", Offset = "0x757BB0", VA = "0x757BB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x757C24", Offset = "0x757C24", VA = "0x757C24")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x757D38", Offset = "0x757D38", VA = "0x757D38")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x757EC8", Offset = "0x757EC8", VA = "0x757EC8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x757F98", Offset = "0x757F98", VA = "0x757F98", Slot = "5")]
	protected virtual void AwakeSafe()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x757F9C", Offset = "0x757F9C", VA = "0x757F9C", Slot = "6")]
	protected virtual void OnEnableSafe()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x757FA0", Offset = "0x757FA0", VA = "0x757FA0", Slot = "7")]
	protected virtual void OnDisableSafe()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x757FA4", Offset = "0x757FA4", VA = "0x757FA4", Slot = "8")]
	protected virtual void OnDestroySafe()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x7556A8", Offset = "0x7556A8", VA = "0x7556A8")]
	public void SetDirty()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x757FA8", Offset = "0x757FA8", VA = "0x757FA8", Slot = "9")]
	protected virtual void UpdateHighlighting()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x757E00", Offset = "0x757E00", VA = "0x757E00")]
	private void ClearRenderers()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x757FAC", Offset = "0x757FAC", VA = "0x757FAC")]
	private void UpdateRenderers()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x758340", Offset = "0x758340", VA = "0x758340")]
	private void GrabRenderers(Transform t)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x759728", Offset = "0x759728", VA = "0x759728")]
	private void FillBufferInternal(CommandBuffer buffer)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x759DB4", Offset = "0x759DB4", VA = "0x759DB4")]
	private static void ExpandRendererDataPool(int count)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x759620", Offset = "0x759620", VA = "0x759620")]
	private static RendererData GetRendererDataInstance()
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x759038", Offset = "0x759038", VA = "0x759038")]
	private static void ReleaseRendererDataInstance(RendererData instance)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x759F08", Offset = "0x759F08", VA = "0x759F08")]
	[ExcludeFromDocs]
	public static void FillBuffer(CommandBuffer buffer)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x757018", Offset = "0x757018", VA = "0x757018")]
	public HighlighterCore()
	{
	}
}
[Token(Token = "0x200001F")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5C4724", Offset = "0x5C4724")]
[ExcludeFromDocs]
public class HighlighterRenderer : MonoBehaviour
{
	[Token(Token = "0x200002D")]
	[ExcludeFromDocs]
	private struct Data
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Material material;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int submeshIndex;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool transparent;
	}

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float transparentCutoff;

	[Token(Token = "0x4000188")]
	private const HideFlags flags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;

	[Token(Token = "0x4000189")]
	private const int cullOff = 0;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly string sRenderType;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly string sOpaque;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly string sTransparent;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly string sTransparentCutout;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static readonly string sMainTex;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool isAlive;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Renderer r;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private List<Data> data;

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x75A4E8", Offset = "0x75A4E8", VA = "0x75A4E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x75A4F4", Offset = "0x75A4F4", VA = "0x75A4F4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x75A570", Offset = "0x75A570", VA = "0x75A570")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x75A5EC", Offset = "0x75A5EC", VA = "0x75A5EC")]
	private void OnWillRenderObject()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x75A788", Offset = "0x75A788", VA = "0x75A788")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x758764", Offset = "0x758764", VA = "0x758764")]
	public void Initialize(Material sharedOpaqueMaterial, Shader transparentShader, List<int> submeshIndices)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x758E1C", Offset = "0x758E1C", VA = "0x758E1C")]
	public void SetOverlay(bool overlay)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x758EF4", Offset = "0x758EF4", VA = "0x758EF4")]
	public void SetColor(Color clr)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x759CC8", Offset = "0x759CC8", VA = "0x759CC8")]
	public void FillBuffer(CommandBuffer buffer)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x759BA0", Offset = "0x759BA0", VA = "0x759BA0")]
	public bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x75A878", Offset = "0x75A878", VA = "0x75A878")]
	private void OnEndOfFrame()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x75A900", Offset = "0x75A900", VA = "0x75A900")]
	public HighlighterRenderer()
	{
	}
}
[Token(Token = "0x2000020")]
public enum BlurDirections
{
	[Token(Token = "0x4000193")]
	Diagonal,
	[Token(Token = "0x4000194")]
	Straight,
	[Token(Token = "0x4000195")]
	All
}
[Token(Token = "0x2000021")]
public enum AntiAliasing
{
	[Token(Token = "0x4000197")]
	QualitySettings,
	[Token(Token = "0x4000198")]
	Disabled,
	[Token(Token = "0x4000199")]
	MSAA2x,
	[Token(Token = "0x400019A")]
	MSAA4x,
	[Token(Token = "0x400019B")]
	MSAA8x
}
[Token(Token = "0x2000022")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x5C477C", Offset = "0x5C477C")]
public class HighlightingBase : MonoBehaviour
{
	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static readonly Color colorClear;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected static readonly string renderBufferName;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	protected static readonly Matrix4x4 identityMatrix;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	protected static readonly string keywordStraightDirections;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected static readonly string keywordAllDirections;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	protected static readonly string profileHighlightingSystem;

	[Token(Token = "0x40001A2")]
	protected const CameraEvent queue = CameraEvent.BeforeImageEffectsOpaque;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected static Camera currentCamera;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	protected static HashSet<HighlighterRenderer> visibleRenderers;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	protected CommandBuffer renderBuffer;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected RenderTextureDescriptor cachedDescriptor;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	protected float _fillAlpha;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5C4A1C", Offset = "0x5C4A1C")]
	[SerializeField]
	protected int _downsampleFactor;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5C4A64", Offset = "0x5C4A64")]
	[SerializeField]
	protected int _iterations;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5C4AAC", Offset = "0x5C4AAC")]
	[SerializeField]
	protected float _blurMinSpread;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5C4AF4", Offset = "0x5C4AF4")]
	[SerializeField]
	protected float _blurSpread;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected float _blurIntensity;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	protected BlurDirections _blurDirections;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected HighlightingBlitter _blitter;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	protected AntiAliasing _antiAliasing;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected RenderTargetIdentifier highlightingBufferID;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	protected RenderTargetIdentifier blur1ID;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected RenderTargetIdentifier blur2ID;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	protected RenderTexture highlightingBuffer;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected Camera cam;

	[Token(Token = "0x40001B5")]
	protected const int BLUR = 0;

	[Token(Token = "0x40001B6")]
	protected const int CUT = 1;

	[Token(Token = "0x40001B7")]
	protected const int COMP = 2;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected static readonly string[] shaderPaths;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	protected static Shader[] shaders;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected static Material[] materials;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	protected Material blurMaterial;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected Material cutMaterial;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	protected Material compMaterial;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	protected static bool initialized;

	[Token(Token = "0x1700002D")]
	public bool isSupported
	{
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x75AA5C", Offset = "0x75AA5C", VA = "0x75AA5C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002E")]
	public float fillAlpha
	{
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x75AA70", Offset = "0x75AA70", VA = "0x75AA70")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x75AA78", Offset = "0x75AA78", VA = "0x75AA78")]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public int downsampleFactor
	{
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x75AB88", Offset = "0x75AB88", VA = "0x75AB88")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x75AB90", Offset = "0x75AB90", VA = "0x75AB90")]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public int iterations
	{
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x75AC48", Offset = "0x75AC48", VA = "0x75AC48")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x75AC50", Offset = "0x75AC50", VA = "0x75AC50")]
		set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public float blurMinSpread
	{
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x75AC60", Offset = "0x75AC60", VA = "0x75AC60")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x75AC68", Offset = "0x75AC68", VA = "0x75AC68")]
		set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public float blurSpread
	{
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x75AC80", Offset = "0x75AC80", VA = "0x75AC80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x75AC88", Offset = "0x75AC88", VA = "0x75AC88")]
		set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public float blurIntensity
	{
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x75ACA0", Offset = "0x75ACA0", VA = "0x75ACA0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x75ACA8", Offset = "0x75ACA8", VA = "0x75ACA8")]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public BlurDirections blurDirections
	{
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x75AD84", Offset = "0x75AD84", VA = "0x75AD84")]
		get
		{
			return default(BlurDirections);
		}
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x75AD8C", Offset = "0x75AD8C", VA = "0x75AD8C")]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public HighlightingBlitter blitter
	{
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x75AE70", Offset = "0x75AE70", VA = "0x75AE70")]
		get
		{
			return null;
		}
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x75AE78", Offset = "0x75AE78", VA = "0x75AE78")]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public AntiAliasing antiAliasing
	{
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x75AFD4", Offset = "0x75AFD4", VA = "0x75AFD4")]
		get
		{
			return default(AntiAliasing);
		}
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x75AFDC", Offset = "0x75AFDC", VA = "0x75AFDC")]
		set
		{
		}
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x75AFEC", Offset = "0x75AFEC", VA = "0x75AFEC", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x75B7C0", Offset = "0x75B7C0", VA = "0x75B7C0", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x75B960", Offset = "0x75B960", VA = "0x75B960", Slot = "6")]
	protected virtual void OnPreCull()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x75BA0C", Offset = "0x75BA0C", VA = "0x75BA0C", Slot = "7")]
	protected virtual void OnPreRender()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x75BEF0", Offset = "0x75BEF0", VA = "0x75BEF0", Slot = "8")]
	protected virtual void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x75BFE0", Offset = "0x75BFE0", VA = "0x75BFE0", Slot = "9")]
	protected virtual void OnEndOfFrame()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x75A664", Offset = "0x75A664", VA = "0x75A664")]
	[ExcludeFromDocs]
	public static void SetVisible(HighlighterRenderer renderer)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x759C24", Offset = "0x759C24", VA = "0x759C24")]
	[ExcludeFromDocs]
	public static bool GetVisible(HighlighterRenderer renderer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x75B518", Offset = "0x75B518", VA = "0x75B518")]
	protected static void Initialize()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x75C088", Offset = "0x75C088", VA = "0x75C088", Slot = "10")]
	protected virtual RenderTextureDescriptor GetDescriptor()
	{
		return default(RenderTextureDescriptor);
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x75C29C", Offset = "0x75C29C", VA = "0x75C29C", Slot = "11")]
	protected virtual bool Equals(RenderTextureDescriptor x, RenderTextureDescriptor y)
	{
		return default(bool);
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x75C2CC", Offset = "0x75C2CC", VA = "0x75C2CC", Slot = "12")]
	protected virtual int GetAA(RenderTexture targetTexture)
	{
		return default(int);
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x75C418", Offset = "0x75C418", VA = "0x75C418", Slot = "13")]
	protected virtual bool CheckSupported(bool verbose)
	{
		return default(bool);
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x75C7CC", Offset = "0x75C7CC", VA = "0x75C7CC", Slot = "14")]
	protected virtual void RebuildCommandBuffer()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x75D18C", Offset = "0x75D18C", VA = "0x75D18C", Slot = "15")]
	public virtual void Blit(RenderTexture src, RenderTexture dst)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x75D21C", Offset = "0x75D21C", VA = "0x75D21C")]
	public HighlightingBase()
	{
	}
}
[Serializable]
[Token(Token = "0x2000023")]
public struct HighlightingPreset : IEquatable<HighlightingPreset>
{
	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	private string _name;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	[SerializeField]
	private float _fillAlpha;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[SerializeField]
	private int _downsampleFactor;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[SerializeField]
	private int _iterations;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private float _blurMinSpread;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	private float _blurSpread;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _blurIntensity;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private BlurDirections _blurDirections;

	[Token(Token = "0x17000037")]
	public string name
	{
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x4380CC", Offset = "0x4380CC", VA = "0x4380CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x4380D4", Offset = "0x4380D4", VA = "0x4380D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public float fillAlpha
	{
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x4380DC", Offset = "0x4380DC", VA = "0x4380DC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x4380E4", Offset = "0x4380E4", VA = "0x4380E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public int downsampleFactor
	{
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x4380EC", Offset = "0x4380EC", VA = "0x4380EC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x4380F4", Offset = "0x4380F4", VA = "0x4380F4")]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public int iterations
	{
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x4380FC", Offset = "0x4380FC", VA = "0x4380FC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x438104", Offset = "0x438104", VA = "0x438104")]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public float blurMinSpread
	{
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x43810C", Offset = "0x43810C", VA = "0x43810C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x438114", Offset = "0x438114", VA = "0x438114")]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	public float blurSpread
	{
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x43811C", Offset = "0x43811C", VA = "0x43811C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x438124", Offset = "0x438124", VA = "0x438124")]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public float blurIntensity
	{
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x43812C", Offset = "0x43812C", VA = "0x43812C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x438134", Offset = "0x438134", VA = "0x438134")]
		set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public BlurDirections blurDirections
	{
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x43813C", Offset = "0x43813C", VA = "0x43813C")]
		get
		{
			return default(BlurDirections);
		}
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x438144", Offset = "0x438144", VA = "0x438144")]
		set
		{
		}
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x43814C", Offset = "0x43814C", VA = "0x43814C", Slot = "4")]
	private bool System.IEquatable<HighlightingSystem.HighlightingPreset>.Equals(HighlightingPreset other)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000024")]
[ExcludeFromDocs]
public static class MaterialExtensions
{
	[Token(Token = "0x6000230")]
	[Address(RVA = "0x757628", Offset = "0x757628", VA = "0x757628")]
	public static void SetKeyword(this Material material, string keyword, bool state)
	{
	}
}
[Token(Token = "0x2000025")]
[ExcludeFromDocs]
public class ShaderPropertyID
{
	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly int _MainTex;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static readonly int _Cutoff;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly int _HighlightingIntensity;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static readonly int _HighlightingCull;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly int _HighlightingColor;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static readonly int _HighlightingBlurOffset;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly int _HighlightingFillAlpha;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public static readonly int _HighlightingBuffer;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly int _HighlightingBlur1;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public static readonly int _HighlightingBlur2;

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x75E384", Offset = "0x75E384", VA = "0x75E384")]
	public ShaderPropertyID()
	{
	}
}
