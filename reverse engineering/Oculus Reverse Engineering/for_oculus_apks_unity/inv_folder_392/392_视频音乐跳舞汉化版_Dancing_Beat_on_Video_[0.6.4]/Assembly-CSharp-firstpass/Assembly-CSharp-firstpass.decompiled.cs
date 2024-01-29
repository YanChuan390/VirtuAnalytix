using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("3.7.1.6")]
[Token(Token = "0x2000002")]
public class DoNotDestroyOnLoad_perName : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	public static List<string> list;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1B0EBC4", Offset = "0x1B0EBC4", VA = "0x1B0EBC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1B0ECBC", Offset = "0x1B0ECBC", VA = "0x1B0ECBC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1B0EDA4", Offset = "0x1B0EDA4", VA = "0x1B0EDA4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1B0EDA8", Offset = "0x1B0EDA8", VA = "0x1B0EDA8")]
	public DoNotDestroyOnLoad_perName()
	{
	}
}
[Token(Token = "0x2000003")]
public class ExampleCam : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	public MouseOrbitImproved mouseOrbit;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	public List<MonoBehaviour> ImageEffectsList;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1B0EE3C", Offset = "0x1B0EE3C", VA = "0x1B0EE3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1B0EE40", Offset = "0x1B0EE40", VA = "0x1B0EE40")]
	private void Update()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1B0EE44", Offset = "0x1B0EE44", VA = "0x1B0EE44")]
	public ExampleCam()
	{
	}
}
[Token(Token = "0x2000004")]
public class ExampleListener : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x18")]
	public InterfaceAnimManager IAM;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1B0EEC8", Offset = "0x1B0EEC8", VA = "0x1B0EEC8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1B0EF48", Offset = "0x1B0EF48", VA = "0x1B0EF48")]
	private void AddListener()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1B0F3E0", Offset = "0x1B0F3E0", VA = "0x1B0F3E0")]
	private void RemoveListener()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1B0F828", Offset = "0x1B0F828", VA = "0x1B0F828")]
	private void HandleOnStartAppear(InterfaceAnimManager _IAM)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1B0F8E8", Offset = "0x1B0F8E8", VA = "0x1B0F8E8")]
	private void HandleOnStartDisappear(InterfaceAnimManager _IAM)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1B0F9A8", Offset = "0x1B0F9A8", VA = "0x1B0F9A8")]
	private void HandleOnEndAppear(InterfaceAnimManager _IAM)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1B0FA68", Offset = "0x1B0FA68", VA = "0x1B0FA68")]
	private void HandleOnEndDisappear(InterfaceAnimManager _IAM)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1B0FB28", Offset = "0x1B0FB28", VA = "0x1B0FB28")]
	public ExampleListener()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7AAF94", Offset = "0x7AAF94")]
public class ExampleUI : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x18")]
	public Text displayedName;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x20")]
	private InterfaceAnimManager current;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x28")]
	private int indexInterface;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x30")]
	public InterfaceAnimManager[] holoInterfaceList;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x38")]
	public ExampleCam currentCam;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x40")]
	public string searchTarget;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x48")]
	public string searchCam;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x50")]
	private int indexScene;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x0")]
	private static bool allDelaysStatus;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x1")]
	private static bool allImgEffectsStatus;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x58")]
	public List<string> loadableScenes;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x60")]
	public GameObject fullscreenSwith;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x68")]
	public AudioSource audioSource;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1B0FB30", Offset = "0x1B0FB30", VA = "0x1B0FB30")]
	private void Start()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1B0FD2C", Offset = "0x1B0FD2C", VA = "0x1B0FD2C")]
	private void playSound()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1B0FDCC", Offset = "0x1B0FDCC", VA = "0x1B0FDCC")]
	public void DoOutFullscreen()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1B0FE04", Offset = "0x1B0FE04", VA = "0x1B0FE04")]
	public void DoChangeEnvironment()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1B102D8", Offset = "0x1B102D8", VA = "0x1B102D8")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mod)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1B1039C", Offset = "0x1B1039C", VA = "0x1B1039C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1B0FEEC", Offset = "0x1B0FEEC", VA = "0x1B0FEEC")]
	private void InitCam()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1B10460", Offset = "0x1B10460", VA = "0x1B10460")]
	public void Update()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1B10498", Offset = "0x1B10498", VA = "0x1B10498")]
	public void DoSwitchAutoCam()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1B104E0", Offset = "0x1B104E0", VA = "0x1B104E0")]
	public void DoSwitchCameraEffects()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1B106E8", Offset = "0x1B106E8", VA = "0x1B106E8")]
	public void DoSwitchAnimDelays()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1B10850", Offset = "0x1B10850", VA = "0x1B10850")]
	public void DoAppear()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1B10900", Offset = "0x1B10900", VA = "0x1B10900")]
	public void DoDisappear()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1B10990", Offset = "0x1B10990", VA = "0x1B10990")]
	public void DoNext()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1B10A0C", Offset = "0x1B10A0C", VA = "0x1B10A0C")]
	public void DoPrevious()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1B0FC00", Offset = "0x1B0FC00", VA = "0x1B0FC00")]
	private void CallInterface(InterfaceAnimManager _interface)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1B10A88", Offset = "0x1B10A88", VA = "0x1B10A88")]
	public void UpdateDisplayedInfo()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1B10B5C", Offset = "0x1B10B5C", VA = "0x1B10B5C")]
	public ExampleUI()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7AAFCC", Offset = "0x7AAFCC")]
public class ExcelsiorUtils : MonoBehaviour
{
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x20")]
	public AudioSource audioSource;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip audioClip;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x30")]
	public Text textContent;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x38")]
	public Slider slider;

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1B10C84", Offset = "0x1B10C84", VA = "0x1B10C84")]
	private void Start()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1B10C88", Offset = "0x1B10C88", VA = "0x1B10C88")]
	private void playSound()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1B10D30", Offset = "0x1B10D30", VA = "0x1B10D30")]
	private void Update()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1B10D34", Offset = "0x1B10D34", VA = "0x1B10D34")]
	public void SetPosition(int _scaleValue)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1B10DA0", Offset = "0x1B10DA0", VA = "0x1B10DA0")]
	public void SetPositionAndScaleTo(GameObject _object)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1B10E58", Offset = "0x1B10E58", VA = "0x1B10E58")]
	public void SetUniformScale(int _scaleValue)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1B10EC4", Offset = "0x1B10EC4", VA = "0x1B10EC4")]
	public void SetUniformWidthHeight(int _widthHeightValue)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1B10F60", Offset = "0x1B10F60", VA = "0x1B10F60")]
	public void SetImageColor(int _colorID)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1B11030", Offset = "0x1B11030", VA = "0x1B11030")]
	public void OpenWebPage()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1B11084", Offset = "0x1B11084", VA = "0x1B11084")]
	public void GetSliderValue_ToText()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1B110F0", Offset = "0x1B110F0", VA = "0x1B110F0")]
	public ExcelsiorUtils()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7AB004", Offset = "0x7AB004")]
public delegate void IAM_StartAppear(InterfaceAnimManager _IAM);
[Token(Token = "0x2000008")]
public delegate void IAM_StartDisappear(InterfaceAnimManager _IAM);
[Token(Token = "0x2000009")]
public delegate void IAM_EndAppear(InterfaceAnimManager _IAM);
[Token(Token = "0x200000A")]
public delegate void IAM_EndDisappear(InterfaceAnimManager _IAM);
[Token(Token = "0x200000B")]
public class InterfaceAnimManager : MonoBehaviour
{
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB03C", Offset = "0x7AB03C")]
	private sealed class <Disable_OnDisappearEnd>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x20")]
		public InterfaceAnimManager <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x1B17CF8", Offset = "0x1B17CF8", VA = "0x1B17CF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x1B17D40", Offset = "0x1B17D40", VA = "0x1B17D40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1B14A8C", Offset = "0x1B14A8C", VA = "0x1B14A8C")]
		[DebuggerHidden]
		public <Disable_OnDisappearEnd>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1B17878", Offset = "0x1B17878", VA = "0x1B17878", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1B1787C", Offset = "0x1B1787C", VA = "0x1B1787C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1B17D00", Offset = "0x1B17D00", VA = "0x1B17D00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB04C", Offset = "0x7AB04C")]
	private sealed class <>c
	{
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x8")]
		public static Func<InterfaceAnmElement, int> <>9__40_0;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1B17858", Offset = "0x1B17858", VA = "0x1B17858")]
		public <>c()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1B17860", Offset = "0x1B17860", VA = "0x1B17860")]
		internal int <UpdateAnimClips>b__40_0(InterfaceAnmElement x)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x18")]
	public List<InterfaceAnmElement> elementsList;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x20")]
	public bool autoStart;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x21")]
	public bool invertDelays;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x22")]
	public bool cloneDelays;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x24")]
	public float timer;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x28")]
	public int timeBetweenLoops;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x2C")]
	public bool testLoop;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x2D")]
	public bool autoLinearAppearDelay;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x2E")]
	public bool forceUnscaledTime;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x30")]
	public float appearDelay_SpeedMultiplier;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x34")]
	public float disappearDelay_SpeedMultiplier;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x38")]
	public CSFHIAnimableState currentState;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x3C")]
	public bool useDelays;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x40")]
	public AudioSource audioSource;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x48")]
	public AudioClip openSound;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x50")]
	public AudioClip closeSound;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x58")]
	public List<InterfaceAnimManager> nestedIAM;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x60")]
	public bool waitAppear_Nested;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x61")]
	public bool waitDisappear_Nested;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x68")]
	private InterfaceAnmElement waitElementFullAnim;

	[Token(Token = "0x14000001")]
	public event IAM_StartAppear OnStartAppear
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1B0F124", Offset = "0x1B0F124", VA = "0x1B0F124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB460", Offset = "0x7AB460")]
		add
		{
		}
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1B0F5A8", Offset = "0x1B0F5A8", VA = "0x1B0F5A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB470", Offset = "0x7AB470")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event IAM_StartDisappear OnStartDisappear
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1B0F1D8", Offset = "0x1B0F1D8", VA = "0x1B0F1D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB480", Offset = "0x7AB480")]
		add
		{
		}
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1B0F648", Offset = "0x1B0F648", VA = "0x1B0F648")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB490", Offset = "0x7AB490")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event IAM_EndAppear OnEndAppear
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1B0F28C", Offset = "0x1B0F28C", VA = "0x1B0F28C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB4A0", Offset = "0x7AB4A0")]
		add
		{
		}
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1B0F6E8", Offset = "0x1B0F6E8", VA = "0x1B0F6E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB4B0", Offset = "0x7AB4B0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event IAM_EndDisappear OnEndDisappear
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1B0F340", Offset = "0x1B0F340", VA = "0x1B0F340")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB4C0", Offset = "0x7AB4C0")]
		add
		{
		}
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1B0F788", Offset = "0x1B0F788", VA = "0x1B0F788")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7AB4D0", Offset = "0x7AB4D0")]
		remove
		{
		}
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1B11F88", Offset = "0x1B11F88", VA = "0x1B11F88")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1B1206C", Offset = "0x1B1206C", VA = "0x1B1206C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1B13194", Offset = "0x1B13194", VA = "0x1B13194")]
	private void Update()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1B145C0", Offset = "0x1B145C0", VA = "0x1B145C0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7AB4E0", Offset = "0x7AB4E0")]
	public IEnumerator Disable_OnDisappearEnd()
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1B14AB8", Offset = "0x1B14AB8", VA = "0x1B14AB8", Slot = "4")]
	public virtual void startAppear(bool _direct = false)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1B14430", Offset = "0x1B14430", VA = "0x1B14430")]
	private void EndAppear()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1B14F3C", Offset = "0x1B14F3C", VA = "0x1B14F3C", Slot = "5")]
	public virtual void startDisappear(bool _direct = false)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1B14638", Offset = "0x1B14638", VA = "0x1B14638")]
	private void EndDisappear()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1B120D4", Offset = "0x1B120D4", VA = "0x1B120D4")]
	public void UpdateAnimClips()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1B15144", Offset = "0x1B15144", VA = "0x1B15144")]
	public bool isIAM_Root()
	{
		return default(bool);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1B15604", Offset = "0x1B15604", VA = "0x1B15604")]
	public InterfaceAnimManager()
	{
	}
}
[Serializable]
[Token(Token = "0x200000E")]
public enum CSFHIAnimableState
{
	[Token(Token = "0x4000035")]
	appearing,
	[Token(Token = "0x4000036")]
	appeared,
	[Token(Token = "0x4000037")]
	disappearing,
	[Token(Token = "0x4000038")]
	disappeared
}
[Serializable]
[Token(Token = "0x200000F")]
public class InterfaceAnmElement : MonoBehaviour
{
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x18")]
	public GameObject gameObjectRef;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x20")]
	public float timeAppear;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x24")]
	public float timeDisappear;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x28")]
	public bool recycling;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x2C")]
	public int sortID;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x30")]
	public Animator animator;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x38")]
	public AnimationClip[] animClips;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x0")]
	public static List<InterfaceAnmElement> list;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x40")]
	public CSFHIAnimableState currentState;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x44")]
	public bool isNested_IAM;

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1B15250", Offset = "0x1B15250", VA = "0x1B15250")]
	public static InterfaceAnmElement Create(GameObject _gameObjectRef, int _newSortID, bool _isNested_IAM)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1B156FC", Offset = "0x1B156FC", VA = "0x1B156FC", Slot = "4")]
	public virtual InterfaceAnmElement Confirm(GameObject _gameObjectRef, int _newSortID, bool isNested_IAM)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1B154A8", Offset = "0x1B154A8", VA = "0x1B154A8")]
	public void UpdateProperties()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1B15854", Offset = "0x1B15854", VA = "0x1B15854", Slot = "5")]
	public virtual void Delete()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1B158A0", Offset = "0x1B158A0", VA = "0x1B158A0")]
	public void Update()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1B15978", Offset = "0x1B15978", VA = "0x1B15978")]
	public InterfaceAnmElement()
	{
	}
}
[Token(Token = "0x2000010")]
public class MouseOrbitImproved : MonoBehaviour
{
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x20")]
	public float distance;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x24")]
	public float xSpeed;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x28")]
	public float ySpeed;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x2C")]
	public float yMinLimit;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x30")]
	public float yMaxLimit;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x34")]
	public float distanceMin;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x38")]
	public float distanceMax;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x3C")]
	public float smoothTime;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x40")]
	private float rotationYAxis;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x44")]
	private float rotationXAxis;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x48")]
	private float velocityX;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x4C")]
	private float velocityY;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1B15A1C", Offset = "0x1B15A1C", VA = "0x1B15A1C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1B15B00", Offset = "0x1B15B00", VA = "0x1B15B00")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1B15E54", Offset = "0x1B15E54", VA = "0x1B15E54")]
	public static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1B15E84", Offset = "0x1B15E84", VA = "0x1B15E84")]
	public MouseOrbitImproved()
	{
	}
}
namespace UnityStandardAssets.ImageEffects;

[Token(Token = "0x2000011")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7AB05C", Offset = "0x7AB05C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7AB05C", Offset = "0x7AB05C")]
[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x7AB05C", Offset = "0x7AB05C")]
public class Bloom : PostEffectsBase
{
	[Token(Token = "0x2000012")]
	public enum LensFlareStyle
	{
		[Token(Token = "0x400006F")]
		Ghosting,
		[Token(Token = "0x4000070")]
		Anamorphic,
		[Token(Token = "0x4000071")]
		Combined
	}

	[Token(Token = "0x2000013")]
	public enum TweakMode
	{
		[Token(Token = "0x4000073")]
		Basic,
		[Token(Token = "0x4000074")]
		Complex
	}

	[Token(Token = "0x2000014")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x4000076")]
		Auto,
		[Token(Token = "0x4000077")]
		On,
		[Token(Token = "0x4000078")]
		Off
	}

	[Token(Token = "0x2000015")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x400007A")]
		Screen,
		[Token(Token = "0x400007B")]
		Add
	}

	[Token(Token = "0x2000016")]
	public enum BloomQuality
	{
		[Token(Token = "0x400007D")]
		Cheap,
		[Token(Token = "0x400007E")]
		High
	}

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x28")]
	public TweakMode tweakMode;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x2C")]
	public BloomScreenBlendMode screenBlendMode;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x30")]
	public HDRBloomMode hdr;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x34")]
	private bool doHdr;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x38")]
	public float sepBlurSpread;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x3C")]
	public BloomQuality quality;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x40")]
	public float bloomIntensity;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x44")]
	public float bloomThreshold;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x48")]
	public Color bloomThresholdColor;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x58")]
	public int bloomBlurIterations;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x5C")]
	public int hollywoodFlareBlurIterations;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x60")]
	public float flareRotation;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x64")]
	public LensFlareStyle lensflareMode;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x68")]
	public float hollyStretchWidth;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x6C")]
	public float lensflareIntensity;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x70")]
	public float lensflareThreshold;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x74")]
	public float lensFlareSaturation;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x78")]
	public Color flareColorA;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x88")]
	public Color flareColorB;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x98")]
	public Color flareColorC;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0xA8")]
	public Color flareColorD;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0xB8")]
	public Texture2D lensFlareVignetteMask;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0xC0")]
	public Shader lensFlareShader;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0xC8")]
	private Material lensFlareMaterial;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0xD0")]
	public Shader screenBlendShader;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0xD8")]
	private Material screenBlend;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0xE0")]
	public Shader blurAndFlaresShader;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0xE8")]
	private Material blurAndFlaresMaterial;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0xF0")]
	public Shader brightPassFilterShader;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0xF8")]
	private Material brightPassFilterMaterial;

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1B0B7FC", Offset = "0x1B0B7FC", VA = "0x1B0B7FC", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1B0BEB4", Offset = "0x1B0BEB4", VA = "0x1B0BEB4")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1B0D364", Offset = "0x1B0D364", VA = "0x1B0D364")]
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1B0D0E4", Offset = "0x1B0D0E4", VA = "0x1B0D0E4")]
	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1B0CDD0", Offset = "0x1B0CDD0", VA = "0x1B0CDD0")]
	private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1B0CCE4", Offset = "0x1B0CCE4", VA = "0x1B0CCE4")]
	private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1B0CEC4", Offset = "0x1B0CEC4", VA = "0x1B0CEC4")]
	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1B0D434", Offset = "0x1B0D434", VA = "0x1B0D434")]
	public Bloom()
	{
	}
}
[Token(Token = "0x2000017")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7AB0F0", Offset = "0x7AB0F0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7AB0F0", Offset = "0x7AB0F0")]
[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x7AB0F0", Offset = "0x7AB0F0")]
public class BloomOptimized : PostEffectsBase
{
	[Token(Token = "0x2000018")]
	public enum Resolution
	{
		[Token(Token = "0x4000088")]
		Low,
		[Token(Token = "0x4000089")]
		High
	}

	[Token(Token = "0x2000019")]
	public enum BlurType
	{
		[Token(Token = "0x400008B")]
		Standard,
		[Token(Token = "0x400008C")]
		Sgx
	}

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB384", Offset = "0x7AB384")]
	public float threshold;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB39C", Offset = "0x7AB39C")]
	public float intensity;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB3B4", Offset = "0x7AB3B4")]
	public float blurSize;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x34")]
	private Resolution resolution;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB3CC", Offset = "0x7AB3CC")]
	public int blurIterations;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x3C")]
	public BlurType blurType;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x40")]
	public Shader fastBloomShader;

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x48")]
	private Material fastBloomMaterial;

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1B0D600", Offset = "0x1B0D600", VA = "0x1B0D600", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1B0D66C", Offset = "0x1B0D66C", VA = "0x1B0D66C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1B0D718", Offset = "0x1B0D718", VA = "0x1B0D718")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1B0DAF8", Offset = "0x1B0DAF8", VA = "0x1B0DAF8")]
	public BloomOptimized()
	{
	}
}
[Token(Token = "0x200001A")]
[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x7AB184", Offset = "0x7AB184")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7AB184", Offset = "0x7AB184")]
public class ColorCorrectionCurves : PostEffectsBase
{
	[Token(Token = "0x200001B")]
	public enum ColorCorrectionMode
	{
		[Token(Token = "0x40000A6")]
		Simple,
		[Token(Token = "0x40000A7")]
		Advanced
	}

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve redChannel;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve greenChannel;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve blueChannel;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x40")]
	public bool useDepthCorrection;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve zCurve;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve depthRedChannel;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve depthGreenChannel;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x60")]
	public AnimationCurve depthBlueChannel;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x68")]
	private Material ccMaterial;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x70")]
	private Material ccDepthMaterial;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x78")]
	private Material selectiveCcMaterial;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x80")]
	private Texture2D rgbChannelTex;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x88")]
	private Texture2D rgbDepthChannelTex;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x90")]
	private Texture2D zCurveTex;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x98")]
	public float saturation;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x9C")]
	public bool selectiveCc;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0xA0")]
	public Color selectiveFromColor;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0xB0")]
	public Color selectiveToColor;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0xC0")]
	public ColorCorrectionMode mode;

	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0xC4")]
	public bool updateTextures;

	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0xC8")]
	public Shader colorCorrectionCurvesShader;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0xD0")]
	public Shader simpleColorCorrectionCurvesShader;

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0xD8")]
	public Shader colorCorrectionSelectiveShader;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0xE0")]
	private bool updateTexturesOnStartup;

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1B0DB18", Offset = "0x1B0DB18", VA = "0x1B0DB18")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1B0DB54", Offset = "0x1B0DB54", VA = "0x1B0DB54")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1B0DB58", Offset = "0x1B0DB58", VA = "0x1B0DB58", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1B0DE28", Offset = "0x1B0DE28", VA = "0x1B0DE28")]
	public void UpdateParameters()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1B0E1E8", Offset = "0x1B0E1E8", VA = "0x1B0E1E8")]
	private void UpdateTextures()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1B0E1EC", Offset = "0x1B0E1EC", VA = "0x1B0E1EC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1B0E538", Offset = "0x1B0E538", VA = "0x1B0E538")]
	public ColorCorrectionCurves()
	{
	}
}
[Token(Token = "0x200001C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7AB1D0", Offset = "0x7AB1D0")]
[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x7AB1D0", Offset = "0x7AB1D0")]
public class PostEffectsBase : MonoBehaviour
{
	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x18")]
	protected bool supportHDRTextures;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x19")]
	protected bool supportDX11;

	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x1A")]
	protected bool isSupported;

	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x20")]
	private List<Material> createdMaterials;

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1B0B9D8", Offset = "0x1B0B9D8", VA = "0x1B0B9D8")]
	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1B15ECC", Offset = "0x1B15ECC", VA = "0x1B15ECC")]
	protected Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1B160D4", Offset = "0x1B160D4", VA = "0x1B160D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1B160E0", Offset = "0x1B160E0", VA = "0x1B160E0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1B160E4", Offset = "0x1B160E4", VA = "0x1B160E4")]
	private void RemoveCreatedMaterials()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1B161B4", Offset = "0x1B161B4", VA = "0x1B161B4")]
	protected bool CheckSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1B161BC", Offset = "0x1B161BC", VA = "0x1B161BC", Slot = "4")]
	public virtual bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1B0DB48", Offset = "0x1B0DB48", VA = "0x1B0DB48")]
	protected void Start()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1B0B8D4", Offset = "0x1B0B8D4", VA = "0x1B0B8D4")]
	protected bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1B16280", Offset = "0x1B16280", VA = "0x1B16280")]
	protected bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1B162DC", Offset = "0x1B162DC", VA = "0x1B162DC")]
	public bool Dx11Support()
	{
		return default(bool);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1B0BDF8", Offset = "0x1B0BDF8", VA = "0x1B0BDF8")]
	protected void ReportAutoDisable()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1B162E4", Offset = "0x1B162E4", VA = "0x1B162E4")]
	private bool CheckShader(Shader s)
	{
		return default(bool);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1B15EA0", Offset = "0x1B15EA0", VA = "0x1B15EA0")]
	protected void NotSupported()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1B16558", Offset = "0x1B16558", VA = "0x1B16558")]
	protected void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1B0D570", Offset = "0x1B0D570", VA = "0x1B0D570")]
	public PostEffectsBase()
	{
	}
}
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7AB240", Offset = "0x7AB240")]
[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x7AB240", Offset = "0x7AB240")]
internal class PostEffectsHelper : MonoBehaviour
{
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1B168D4", Offset = "0x1B168D4", VA = "0x1B168D4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1B16948", Offset = "0x1B16948", VA = "0x1B16948")]
	private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1B16BA0", Offset = "0x1B16BA0", VA = "0x1B16BA0")]
	private static void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1B16F18", Offset = "0x1B16F18", VA = "0x1B16F18")]
	private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1B170C0", Offset = "0x1B170C0", VA = "0x1B170C0")]
	public PostEffectsHelper()
	{
	}
}
[Token(Token = "0x200001E")]
[AttributeAttribute(Name = "ExecuteInEditMode", RVA = "0x7AB2B0", Offset = "0x7AB2B0")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x7AB2B0", Offset = "0x7AB2B0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x7AB2B0", Offset = "0x7AB2B0")]
internal class ScreenSpaceAmbientObscurance : PostEffectsBase
{
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB3E4", Offset = "0x7AB3E4")]
	public float intensity;

	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB3FC", Offset = "0x7AB3FC")]
	public float radius;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB418", Offset = "0x7AB418")]
	public int blurIterations;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB430", Offset = "0x7AB430")]
	public float blurFilterDistance;

	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7AB448", Offset = "0x7AB448")]
	public int downsample;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x40")]
	public Texture2D rand;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x48")]
	public Shader aoShader;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x50")]
	private Material aoMaterial;

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1B170C8", Offset = "0x1B170C8", VA = "0x1B170C8", Slot = "4")]
	public override bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1B1713C", Offset = "0x1B1713C", VA = "0x1B1713C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1B171E8", Offset = "0x1B171E8", VA = "0x1B171E8")]
	[AttributeAttribute(Name = "ImageEffectOpaque", RVA = "0x7AB590", Offset = "0x7AB590")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1B177D8", Offset = "0x1B177D8", VA = "0x1B177D8")]
	public ScreenSpaceAmbientObscurance()
	{
	}
}
