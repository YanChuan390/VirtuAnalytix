using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class DoNotDestroyOnLoad_perName : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<string> list;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x10E61E0", Offset = "0x10E61E0", VA = "0x10E61E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x10E62C4", Offset = "0x10E62C4", VA = "0x10E62C4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x10E6398", Offset = "0x10E6398", VA = "0x10E6398")]
	public DoNotDestroyOnLoad_perName()
	{
	}
}
[Token(Token = "0x2000003")]
public class ExampleCam : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MouseOrbitImproved mouseOrbit;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<MonoBehaviour> ImageEffectsList;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x10E766C", Offset = "0x10E766C", VA = "0x10E766C")]
	public ExampleCam()
	{
	}
}
[Token(Token = "0x2000004")]
public class ExampleListener : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InterfaceAnimManager IAM;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x10E76DC", Offset = "0x10E76DC", VA = "0x10E76DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x10E7760", Offset = "0x10E7760", VA = "0x10E7760")]
	private void AddListener()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x10E7B60", Offset = "0x10E7B60", VA = "0x10E7B60")]
	private void RemoveListener()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x10E7F20", Offset = "0x10E7F20", VA = "0x10E7F20")]
	private void HandleOnStartAppear(InterfaceAnimManager _IAM)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x10E7FCC", Offset = "0x10E7FCC", VA = "0x10E7FCC")]
	private void HandleOnStartDisappear(InterfaceAnimManager _IAM)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x10E8078", Offset = "0x10E8078", VA = "0x10E8078")]
	private void HandleOnEndAppear(InterfaceAnimManager _IAM)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x10E8124", Offset = "0x10E8124", VA = "0x10E8124")]
	private void HandleOnEndDisappear(InterfaceAnimManager _IAM)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x10E81D0", Offset = "0x10E81D0", VA = "0x10E81D0")]
	public ExampleListener()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x680D54", Offset = "0x680D54")]
public class ExampleUI : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text displayedName;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private InterfaceAnimManager current;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int indexInterface;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public InterfaceAnimManager[] holoInterfaceList;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ExampleCam currentCam;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string searchTarget;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string searchCam;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int indexScene;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool allDelaysStatus;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	private static bool allImgEffectsStatus;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<string> loadableScenes;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject fullscreenSwith;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AudioSource audioSource;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x10E81D8", Offset = "0x10E81D8", VA = "0x10E81D8")]
	private void Start()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x10E83C0", Offset = "0x10E83C0", VA = "0x10E83C0")]
	private void playSound()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x10E8464", Offset = "0x10E8464", VA = "0x10E8464")]
	public void DoOutFullscreen()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x10E849C", Offset = "0x10E849C", VA = "0x10E849C")]
	public void DoChangeEnvironment()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x10E88C4", Offset = "0x10E88C4", VA = "0x10E88C4")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mod)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x10E8968", Offset = "0x10E8968", VA = "0x10E8968")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x10E8570", Offset = "0x10E8570", VA = "0x10E8570")]
	private void InitCam()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x10E8A0C", Offset = "0x10E8A0C", VA = "0x10E8A0C")]
	public void Update()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x10E8A44", Offset = "0x10E8A44", VA = "0x10E8A44")]
	public void DoSwitchAutoCam()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x10E8A8C", Offset = "0x10E8A8C", VA = "0x10E8A8C")]
	public void DoSwitchCameraEffects()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x10E8C4C", Offset = "0x10E8C4C", VA = "0x10E8C4C")]
	public void DoSwitchAnimDelays()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x10E8DAC", Offset = "0x10E8DAC", VA = "0x10E8DAC")]
	public void DoAppear()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x10E8E60", Offset = "0x10E8E60", VA = "0x10E8E60")]
	public void DoDisappear()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x10E8EF4", Offset = "0x10E8EF4", VA = "0x10E8EF4")]
	public void DoNext()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x10E8F70", Offset = "0x10E8F70", VA = "0x10E8F70")]
	public void DoPrevious()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x10E82AC", Offset = "0x10E82AC", VA = "0x10E82AC")]
	private void CallInterface(InterfaceAnimManager _interface)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x10E8FEC", Offset = "0x10E8FEC", VA = "0x10E8FEC")]
	public void UpdateDisplayedInfo()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x10E90B8", Offset = "0x10E90B8", VA = "0x10E90B8")]
	public ExampleUI()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x680D8C", Offset = "0x680D8C")]
public class ExcelsiorUtils : MonoBehaviour
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource audioSource;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioClip audioClip;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text textContent;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Slider slider;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x10E91A8", Offset = "0x10E91A8", VA = "0x10E91A8")]
	private void playSound()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x10E9254", Offset = "0x10E9254", VA = "0x10E9254")]
	public void SetPosition(int _scaleValue)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x10E9308", Offset = "0x10E9308", VA = "0x10E9308")]
	public void SetPositionAndScaleTo(GameObject _object)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x10E9420", Offset = "0x10E9420", VA = "0x10E9420")]
	public void SetUniformScale(int _scaleValue)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x10E94D4", Offset = "0x10E94D4", VA = "0x10E94D4")]
	public void SetUniformWidthHeight(int _widthHeightValue)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x10E95C8", Offset = "0x10E95C8", VA = "0x10E95C8")]
	public void SetImageColor(int _colorID)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x10E969C", Offset = "0x10E969C", VA = "0x10E969C")]
	public void OpenWebPage()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x10E96F4", Offset = "0x10E96F4", VA = "0x10E96F4")]
	public void GetSliderValue_ToText()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x10E9760", Offset = "0x10E9760", VA = "0x10E9760")]
	public ExcelsiorUtils()
	{
	}
}
[Token(Token = "0x2000007")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x680DC4", Offset = "0x680DC4")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x680DFC", Offset = "0x680DFC")]
	private sealed class <Disable_OnDisappearEnd>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InterfaceAnimManager <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x173FBB4", Offset = "0x173FBB4", VA = "0x173FBB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x173FC1C", Offset = "0x173FC1C", VA = "0x173FC1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x173F770", Offset = "0x173F770", VA = "0x173F770")]
		[DebuggerHidden]
		public <Disable_OnDisappearEnd>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x173F79C", Offset = "0x173F79C", VA = "0x173F79C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x173F7A0", Offset = "0x173F7A0", VA = "0x173F7A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x173FBBC", Offset = "0x173FBBC", VA = "0x173FBBC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x680E0C", Offset = "0x680E0C")]
	private sealed class <>c
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<InterfaceAnmElement, int> <>9__40_0;

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x173F750", Offset = "0x173F750", VA = "0x173F750")]
		public <>c()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x173F758", Offset = "0x173F758", VA = "0x173F758")]
		internal int <UpdateAnimClips>b__40_0(InterfaceAnmElement x)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<InterfaceAnmElement> elementsList;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool autoStart;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool invertDelays;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool cloneDelays;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float timer;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int timeBetweenLoops;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool testLoop;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool autoLinearAppearDelay;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool forceUnscaledTime;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float appearDelay_SpeedMultiplier;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float disappearDelay_SpeedMultiplier;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CSFHIAnimableState currentState;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool useDelays;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioSource audioSource;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioClip openSound;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AudioClip closeSound;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<InterfaceAnimManager> nestedIAM;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool waitAppear_Nested;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool waitDisappear_Nested;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private InterfaceAnmElement waitElementFullAnim;

	[Token(Token = "0x14000001")]
	public event IAM_StartAppear OnStartAppear
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x10E78A0", Offset = "0x10E78A0", VA = "0x10E78A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681850", Offset = "0x681850")]
		add
		{
		}
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x10E7C90", Offset = "0x10E7C90", VA = "0x10E7C90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681860", Offset = "0x681860")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event IAM_StartDisappear OnStartDisappear
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x10E7954", Offset = "0x10E7954", VA = "0x10E7954")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681870", Offset = "0x681870")]
		add
		{
		}
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x10E7D34", Offset = "0x10E7D34", VA = "0x10E7D34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681880", Offset = "0x681880")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event IAM_EndAppear OnEndAppear
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x10E7A08", Offset = "0x10E7A08", VA = "0x10E7A08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681890", Offset = "0x681890")]
		add
		{
		}
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x10E7DD8", Offset = "0x10E7DD8", VA = "0x10E7DD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6818A0", Offset = "0x6818A0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event IAM_EndDisappear OnEndDisappear
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x10E7ABC", Offset = "0x10E7ABC", VA = "0x10E7ABC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6818B0", Offset = "0x6818B0")]
		add
		{
		}
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x10E7E7C", Offset = "0x10E7E7C", VA = "0x10E7E7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6818C0", Offset = "0x6818C0")]
		remove
		{
		}
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x10EBB54", Offset = "0x10EBB54", VA = "0x10EBB54")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x10EBC24", Offset = "0x10EBC24", VA = "0x10EBC24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x10ECC00", Offset = "0x10ECC00", VA = "0x10ECC00")]
	private void Update()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x10EDED0", Offset = "0x10EDED0", VA = "0x10EDED0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6818D0", Offset = "0x6818D0")]
	public IEnumerator Disable_OnDisappearEnd()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x10EE2FC", Offset = "0x10EE2FC", VA = "0x10EE2FC", Slot = "4")]
	public virtual void startAppear(bool _direct = false)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x10EDD7C", Offset = "0x10EDD7C", VA = "0x10EDD7C")]
	private void EndAppear()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x10EE6E8", Offset = "0x10EE6E8", VA = "0x10EE6E8", Slot = "5")]
	public virtual void startDisappear(bool _direct = false)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x10EDF40", Offset = "0x10EDF40", VA = "0x10EDF40")]
	private void EndDisappear()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x10EBC8C", Offset = "0x10EBC8C", VA = "0x10EBC8C")]
	public void UpdateAnimClips()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x10EE8B8", Offset = "0x10EE8B8", VA = "0x10EE8B8")]
	public bool isIAM_Root()
	{
		return default(bool);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x10EECF0", Offset = "0x10EECF0", VA = "0x10EECF0")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject gameObjectRef;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float timeAppear;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float timeDisappear;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool recycling;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int sortID;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Animator animator;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AnimationClip[] animClips;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<InterfaceAnmElement> list;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public CSFHIAnimableState currentState;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool isNested_IAM;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x10EE9BC", Offset = "0x10EE9BC", VA = "0x10EE9BC")]
	public static InterfaceAnmElement Create(GameObject _gameObjectRef, int _newSortID, bool _isNested_IAM)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x10EEDB0", Offset = "0x10EEDB0", VA = "0x10EEDB0", Slot = "4")]
	public virtual InterfaceAnmElement Confirm(GameObject _gameObjectRef, int _newSortID, bool isNested_IAM)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x10EEBC4", Offset = "0x10EEBC4", VA = "0x10EEBC4")]
	public void UpdateProperties()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x10EEECC", Offset = "0x10EEECC", VA = "0x10EEECC", Slot = "5")]
	public virtual void Delete()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x10EEEF4", Offset = "0x10EEEF4", VA = "0x10EEEF4")]
	public void Update()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x10EEFC4", Offset = "0x10EEFC4", VA = "0x10EEFC4")]
	public InterfaceAnmElement()
	{
	}
}
[Token(Token = "0x2000010")]
public class MouseOrbitImproved : MonoBehaviour
{
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float distance;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float xSpeed;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float ySpeed;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float yMinLimit;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float yMaxLimit;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float distanceMin;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float distanceMax;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float smoothTime;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float rotationYAxis;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float rotationXAxis;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float velocityX;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float velocityY;

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x10EF0F0", Offset = "0x10EF0F0", VA = "0x10EF0F0")]
	private void Start()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x10EF1CC", Offset = "0x10EF1CC", VA = "0x10EF1CC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x10EF584", Offset = "0x10EF584", VA = "0x10EF584")]
	public static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x10EF634", Offset = "0x10EF634", VA = "0x10EF634")]
	public MouseOrbitImproved()
	{
	}
}
[Token(Token = "0x2000011")]
public class FMODAsset : ScriptableObject
{
	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string path;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string id;

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x10E9768", Offset = "0x10E9768", VA = "0x10E9768")]
	public FMODAsset()
	{
	}
}
[Token(Token = "0x2000012")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x680E1C", Offset = "0x680E1C")]
public class FMOD_Listener : MonoBehaviour
{
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6814AC", Offset = "0x6814AC")]
	public string[] pluginPaths;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x10EAB84", Offset = "0x10EAB84", VA = "0x10EAB84")]
	public FMOD_Listener()
	{
	}
}
[Token(Token = "0x2000013")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x680E54", Offset = "0x680E54")]
public class FMOD_StudioEventEmitter : MonoBehaviour
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6814E4", Offset = "0x6814E4")]
	public FMODAsset asset;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string path;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool startEventOnAwake;

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x10EABE4", Offset = "0x10EABE4", VA = "0x10EABE4")]
	public FMOD_StudioEventEmitter()
	{
	}
}
[Serializable]
[Token(Token = "0x2000014")]
public class FMODEventPlayable : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FMODEventPlayableBehavior template;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68151C", Offset = "0x68151C")]
	private GameObject <TrackTargetObject>k__BackingField;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float eventLength;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private FMODEventPlayableBehavior behavior;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[EventRef]
	public string eventName;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public STOP_MODE stopType;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public ParamRef[] parameters;

	[NonSerialized]
	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool cachedParameters;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681584", Offset = "0x681584")]
	private TimelineClip <OwningClip>k__BackingField;

	[Token(Token = "0x17000003")]
	public GameObject TrackTargetObject
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x10E9968", Offset = "0x10E9968", VA = "0x10E9968")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681984", Offset = "0x681984")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x10E9970", Offset = "0x10E9970", VA = "0x10E9970")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681994", Offset = "0x681994")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public override double duration
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x10E9978", Offset = "0x10E9978", VA = "0x10E9978", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000005")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x10E9994", Offset = "0x10E9994", VA = "0x10E9994", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x17000006")]
	public TimelineClip OwningClip
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x10E999C", Offset = "0x10E999C", VA = "0x10E999C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6819A4", Offset = "0x6819A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x10E99A4", Offset = "0x10E99A4", VA = "0x10E99A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6819B4", Offset = "0x6819B4")]
		set
		{
		}
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x10E99AC", Offset = "0x10E99AC", VA = "0x10E99AC", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x10E9C2C", Offset = "0x10E9C2C", VA = "0x10E9C2C")]
	public FMODEventPlayable()
	{
	}
}
[Token(Token = "0x2000015")]
public enum STOP_MODE
{
	[Token(Token = "0x4000060")]
	AllowFadeout,
	[Token(Token = "0x4000061")]
	Immediate,
	[Token(Token = "0x4000062")]
	None
}
[Token(Token = "0x2000016")]
public class FMODEventPlayableBehavior : PlayableBehaviour
{
	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string eventName;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public STOP_MODE stopType;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParamRef[] parameters;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject TrackTargetObject;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TimelineClip OwningClip;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isPlayheadInside;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private EventInstance eventInstance;

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x10E9D08", Offset = "0x10E9D08", VA = "0x10E9D08")]
	protected void PlayEvent()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x10EA470", Offset = "0x10EA470", VA = "0x10EA470")]
	public void OnEnter()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x10EA4A4", Offset = "0x10EA4A4", VA = "0x10EA4A4")]
	public void OnExit()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x10E98E4", Offset = "0x10E98E4", VA = "0x10E98E4")]
	public void UpdateBehaviour(float time)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x10EA500", Offset = "0x10EA500", VA = "0x10EA500", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x10E9CA8", Offset = "0x10E9CA8", VA = "0x10E9CA8")]
	public FMODEventPlayableBehavior()
	{
	}
}
[Token(Token = "0x2000017")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x680E8C", Offset = "0x680E8C")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x680E8C", Offset = "0x680E8C")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x680E8C", Offset = "0x680E8C")]
public class FMODEventTrack : TrackAsset
{
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x10EA5A8", Offset = "0x10EA5A8", VA = "0x10EA5A8", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x10EA97C", Offset = "0x10EA97C", VA = "0x10EA97C")]
	public FMODEventTrack()
	{
	}
}
[Token(Token = "0x2000018")]
public class FMODEventMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x10E9770", Offset = "0x10E9770", VA = "0x10E9770", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x10E9960", Offset = "0x10E9960", VA = "0x10E9960")]
	public FMODEventMixerBehaviour()
	{
	}
}
namespace FMOD
{
	[Token(Token = "0x2000019")]
	public enum RESULT
	{
		[Token(Token = "0x400006B")]
		OK,
		[Token(Token = "0x400006C")]
		ERR_BADCOMMAND,
		[Token(Token = "0x400006D")]
		ERR_CHANNEL_ALLOC,
		[Token(Token = "0x400006E")]
		ERR_CHANNEL_STOLEN,
		[Token(Token = "0x400006F")]
		ERR_DMA,
		[Token(Token = "0x4000070")]
		ERR_DSP_CONNECTION,
		[Token(Token = "0x4000071")]
		ERR_DSP_DONTPROCESS,
		[Token(Token = "0x4000072")]
		ERR_DSP_FORMAT,
		[Token(Token = "0x4000073")]
		ERR_DSP_INUSE,
		[Token(Token = "0x4000074")]
		ERR_DSP_NOTFOUND,
		[Token(Token = "0x4000075")]
		ERR_DSP_RESERVED,
		[Token(Token = "0x4000076")]
		ERR_DSP_SILENCE,
		[Token(Token = "0x4000077")]
		ERR_DSP_TYPE,
		[Token(Token = "0x4000078")]
		ERR_FILE_BAD,
		[Token(Token = "0x4000079")]
		ERR_FILE_COULDNOTSEEK,
		[Token(Token = "0x400007A")]
		ERR_FILE_DISKEJECTED,
		[Token(Token = "0x400007B")]
		ERR_FILE_EOF,
		[Token(Token = "0x400007C")]
		ERR_FILE_ENDOFDATA,
		[Token(Token = "0x400007D")]
		ERR_FILE_NOTFOUND,
		[Token(Token = "0x400007E")]
		ERR_FORMAT,
		[Token(Token = "0x400007F")]
		ERR_HEADER_MISMATCH,
		[Token(Token = "0x4000080")]
		ERR_HTTP,
		[Token(Token = "0x4000081")]
		ERR_HTTP_ACCESS,
		[Token(Token = "0x4000082")]
		ERR_HTTP_PROXY_AUTH,
		[Token(Token = "0x4000083")]
		ERR_HTTP_SERVER_ERROR,
		[Token(Token = "0x4000084")]
		ERR_HTTP_TIMEOUT,
		[Token(Token = "0x4000085")]
		ERR_INITIALIZATION,
		[Token(Token = "0x4000086")]
		ERR_INITIALIZED,
		[Token(Token = "0x4000087")]
		ERR_INTERNAL,
		[Token(Token = "0x4000088")]
		ERR_INVALID_FLOAT,
		[Token(Token = "0x4000089")]
		ERR_INVALID_HANDLE,
		[Token(Token = "0x400008A")]
		ERR_INVALID_PARAM,
		[Token(Token = "0x400008B")]
		ERR_INVALID_POSITION,
		[Token(Token = "0x400008C")]
		ERR_INVALID_SPEAKER,
		[Token(Token = "0x400008D")]
		ERR_INVALID_SYNCPOINT,
		[Token(Token = "0x400008E")]
		ERR_INVALID_THREAD,
		[Token(Token = "0x400008F")]
		ERR_INVALID_VECTOR,
		[Token(Token = "0x4000090")]
		ERR_MAXAUDIBLE,
		[Token(Token = "0x4000091")]
		ERR_MEMORY,
		[Token(Token = "0x4000092")]
		ERR_MEMORY_CANTPOINT,
		[Token(Token = "0x4000093")]
		ERR_NEEDS3D,
		[Token(Token = "0x4000094")]
		ERR_NEEDSHARDWARE,
		[Token(Token = "0x4000095")]
		ERR_NET_CONNECT,
		[Token(Token = "0x4000096")]
		ERR_NET_SOCKET_ERROR,
		[Token(Token = "0x4000097")]
		ERR_NET_URL,
		[Token(Token = "0x4000098")]
		ERR_NET_WOULD_BLOCK,
		[Token(Token = "0x4000099")]
		ERR_NOTREADY,
		[Token(Token = "0x400009A")]
		ERR_OUTPUT_ALLOCATED,
		[Token(Token = "0x400009B")]
		ERR_OUTPUT_CREATEBUFFER,
		[Token(Token = "0x400009C")]
		ERR_OUTPUT_DRIVERCALL,
		[Token(Token = "0x400009D")]
		ERR_OUTPUT_FORMAT,
		[Token(Token = "0x400009E")]
		ERR_OUTPUT_INIT,
		[Token(Token = "0x400009F")]
		ERR_OUTPUT_NODRIVERS,
		[Token(Token = "0x40000A0")]
		ERR_PLUGIN,
		[Token(Token = "0x40000A1")]
		ERR_PLUGIN_MISSING,
		[Token(Token = "0x40000A2")]
		ERR_PLUGIN_RESOURCE,
		[Token(Token = "0x40000A3")]
		ERR_PLUGIN_VERSION,
		[Token(Token = "0x40000A4")]
		ERR_RECORD,
		[Token(Token = "0x40000A5")]
		ERR_REVERB_CHANNELGROUP,
		[Token(Token = "0x40000A6")]
		ERR_REVERB_INSTANCE,
		[Token(Token = "0x40000A7")]
		ERR_SUBSOUNDS,
		[Token(Token = "0x40000A8")]
		ERR_SUBSOUND_ALLOCATED,
		[Token(Token = "0x40000A9")]
		ERR_SUBSOUND_CANTMOVE,
		[Token(Token = "0x40000AA")]
		ERR_TAGNOTFOUND,
		[Token(Token = "0x40000AB")]
		ERR_TOOMANYCHANNELS,
		[Token(Token = "0x40000AC")]
		ERR_TRUNCATED,
		[Token(Token = "0x40000AD")]
		ERR_UNIMPLEMENTED,
		[Token(Token = "0x40000AE")]
		ERR_UNINITIALIZED,
		[Token(Token = "0x40000AF")]
		ERR_UNSUPPORTED,
		[Token(Token = "0x40000B0")]
		ERR_VERSION,
		[Token(Token = "0x40000B1")]
		ERR_EVENT_ALREADY_LOADED,
		[Token(Token = "0x40000B2")]
		ERR_EVENT_LIVEUPDATE_BUSY,
		[Token(Token = "0x40000B3")]
		ERR_EVENT_LIVEUPDATE_MISMATCH,
		[Token(Token = "0x40000B4")]
		ERR_EVENT_LIVEUPDATE_TIMEOUT,
		[Token(Token = "0x40000B5")]
		ERR_EVENT_NOTFOUND,
		[Token(Token = "0x40000B6")]
		ERR_STUDIO_UNINITIALIZED,
		[Token(Token = "0x40000B7")]
		ERR_STUDIO_NOT_LOADED,
		[Token(Token = "0x40000B8")]
		ERR_INVALID_STRING,
		[Token(Token = "0x40000B9")]
		ERR_ALREADY_LOCKED,
		[Token(Token = "0x40000BA")]
		ERR_NOT_LOCKED,
		[Token(Token = "0x40000BB")]
		ERR_RECORD_DISCONNECTED,
		[Token(Token = "0x40000BC")]
		ERR_TOOMANYSAMPLES
	}
	[Token(Token = "0x200001A")]
	public struct VECTOR
	{
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;
	}
	[Token(Token = "0x200001B")]
	public struct ATTRIBUTES_3D
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VECTOR position;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VECTOR velocity;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VECTOR forward;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public VECTOR up;
	}
	[Token(Token = "0x200001C")]
	public enum OUTPUTTYPE
	{
		[Token(Token = "0x40000C5")]
		AUTODETECT,
		[Token(Token = "0x40000C6")]
		UNKNOWN,
		[Token(Token = "0x40000C7")]
		NOSOUND,
		[Token(Token = "0x40000C8")]
		WAVWRITER,
		[Token(Token = "0x40000C9")]
		NOSOUND_NRT,
		[Token(Token = "0x40000CA")]
		WAVWRITER_NRT,
		[Token(Token = "0x40000CB")]
		WASAPI,
		[Token(Token = "0x40000CC")]
		ASIO,
		[Token(Token = "0x40000CD")]
		PULSEAUDIO,
		[Token(Token = "0x40000CE")]
		ALSA,
		[Token(Token = "0x40000CF")]
		COREAUDIO,
		[Token(Token = "0x40000D0")]
		AUDIOTRACK,
		[Token(Token = "0x40000D1")]
		OPENSL,
		[Token(Token = "0x40000D2")]
		AUDIOOUT,
		[Token(Token = "0x40000D3")]
		AUDIO3D,
		[Token(Token = "0x40000D4")]
		WEBAUDIO,
		[Token(Token = "0x40000D5")]
		NNAUDIO,
		[Token(Token = "0x40000D6")]
		WINSONIC,
		[Token(Token = "0x40000D7")]
		AAUDIO,
		[Token(Token = "0x40000D8")]
		MAX
	}
	[Token(Token = "0x200001D")]
	[Flags]
	public enum DEBUG_FLAGS : uint
	{
		[Token(Token = "0x40000DA")]
		NONE = 0u,
		[Token(Token = "0x40000DB")]
		ERROR = 1u,
		[Token(Token = "0x40000DC")]
		WARNING = 2u,
		[Token(Token = "0x40000DD")]
		LOG = 4u,
		[Token(Token = "0x40000DE")]
		TYPE_MEMORY = 0x100u,
		[Token(Token = "0x40000DF")]
		TYPE_FILE = 0x200u,
		[Token(Token = "0x40000E0")]
		TYPE_CODEC = 0x400u,
		[Token(Token = "0x40000E1")]
		TYPE_TRACE = 0x800u,
		[Token(Token = "0x40000E2")]
		DISPLAY_TIMESTAMPS = 0x10000u,
		[Token(Token = "0x40000E3")]
		DISPLAY_LINENUMBERS = 0x20000u,
		[Token(Token = "0x40000E4")]
		DISPLAY_THREAD = 0x40000u
	}
	[Token(Token = "0x200001E")]
	public enum SPEAKERMODE
	{
		[Token(Token = "0x40000E6")]
		DEFAULT,
		[Token(Token = "0x40000E7")]
		RAW,
		[Token(Token = "0x40000E8")]
		MONO,
		[Token(Token = "0x40000E9")]
		STEREO,
		[Token(Token = "0x40000EA")]
		QUAD,
		[Token(Token = "0x40000EB")]
		SURROUND,
		[Token(Token = "0x40000EC")]
		_5POINT1,
		[Token(Token = "0x40000ED")]
		_7POINT1,
		[Token(Token = "0x40000EE")]
		_7POINT1POINT4,
		[Token(Token = "0x40000EF")]
		MAX
	}
	[Token(Token = "0x200001F")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x40000F1")]
		NORMAL = 0u,
		[Token(Token = "0x40000F2")]
		STREAM_FROM_UPDATE = 1u,
		[Token(Token = "0x40000F3")]
		MIX_FROM_UPDATE = 2u,
		[Token(Token = "0x40000F4")]
		_3D_RIGHTHANDED = 4u,
		[Token(Token = "0x40000F5")]
		CHANNEL_LOWPASS = 0x100u,
		[Token(Token = "0x40000F6")]
		CHANNEL_DISTANCEFILTER = 0x200u,
		[Token(Token = "0x40000F7")]
		PROFILE_ENABLE = 0x10000u,
		[Token(Token = "0x40000F8")]
		VOL0_BECOMES_VIRTUAL = 0x20000u,
		[Token(Token = "0x40000F9")]
		GEOMETRY_USECLOSEST = 0x40000u,
		[Token(Token = "0x40000FA")]
		PREFER_DOLBY_DOWNMIX = 0x80000u,
		[Token(Token = "0x40000FB")]
		THREAD_UNSAFE = 0x100000u,
		[Token(Token = "0x40000FC")]
		PROFILE_METER_ALL = 0x200000u,
		[Token(Token = "0x40000FD")]
		MEMORY_TRACKING = 0x400000u
	}
	[Token(Token = "0x2000020")]
	public delegate RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message);
	[Token(Token = "0x2000021")]
	public enum DSP_RESAMPLER
	{
		[Token(Token = "0x40000FF")]
		DEFAULT,
		[Token(Token = "0x4000100")]
		NOINTERP,
		[Token(Token = "0x4000101")]
		LINEAR,
		[Token(Token = "0x4000102")]
		CUBIC,
		[Token(Token = "0x4000103")]
		SPLINE,
		[Token(Token = "0x4000104")]
		MAX
	}
	[Token(Token = "0x2000022")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbSize;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int maxMPEGCodecs;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int maxADPCMCodecs;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int maxXMACodecs;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int maxVorbisCodecs;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int maxAT9Codecs;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int maxFADPCMCodecs;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int maxPCMCodecs;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int ASIONumChannels;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr ASIOChannelList;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr ASIOSpeakerList;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float vol0virtualvol;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public uint defaultDecodeBufferSize;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ushort profilePort;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint geometryMaxFadeTime;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float distanceFilterCenterFreq;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int reverb3Dinstance;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int DSPBufferPoolSize;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public uint stackSizeStream;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public uint stackSizeNonBlocking;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public uint stackSizeMixer;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_RESAMPLER resamplerMethod;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public uint commandQueueSize;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public uint randomSeed;
	}
	[Token(Token = "0x2000023")]
	public struct Memory
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x10EF050", Offset = "0x10EF050", VA = "0x10EF050")]
		public static RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking = true)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x10EF058", Offset = "0x10EF058", VA = "0x10EF058")]
		private static extern RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking);
	}
	[Token(Token = "0x2000024")]
	public struct System
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x750B1C", Offset = "0x750B1C", VA = "0x750B1C")]
		public RESULT setOutput(OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x750B24", Offset = "0x750B24", VA = "0x750B24")]
		public RESULT setSoftwareChannels(int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x750B2C", Offset = "0x750B2C", VA = "0x750B2C")]
		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x750B34", Offset = "0x750B34", VA = "0x750B34")]
		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x750B3C", Offset = "0x750B3C", VA = "0x750B3C")]
		public RESULT loadPlugin(string filename, out uint handle, uint priority = 0u)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x750B44", Offset = "0x750B44", VA = "0x750B44")]
		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x750B4C", Offset = "0x750B4C", VA = "0x750B4C")]
		public RESULT mixerSuspend()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x750B54", Offset = "0x750B54", VA = "0x750B54")]
		public RESULT mixerResume()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x750B5C", Offset = "0x750B5C", VA = "0x750B5C")]
		public RESULT getChannelsPlaying(out int channels, out int realchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x750B64", Offset = "0x750B64", VA = "0x750B64")]
		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x173CD90", Offset = "0x173CD90", VA = "0x173CD90")]
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x173CE28", Offset = "0x173CE28", VA = "0x173CE28")]
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x173CEC0", Offset = "0x173CEC0", VA = "0x173CEC0")]
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x173D024", Offset = "0x173D024", VA = "0x173D024")]
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x173D358", Offset = "0x173D358", VA = "0x173D358")]
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority);

		[PreserveSig]
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x173D410", Offset = "0x173D410", VA = "0x173D410")]
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x173D4D8", Offset = "0x173D4D8", VA = "0x173D4D8")]
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x173D560", Offset = "0x173D560", VA = "0x173D560")]
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x173D5E8", Offset = "0x173D5E8", VA = "0x173D5E8")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels);

		[PreserveSig]
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x173D688", Offset = "0x173D688", VA = "0x173D688")]
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup);
	}
	[Token(Token = "0x2000025")]
	public struct ChannelGroup
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x739564", Offset = "0x739564", VA = "0x739564", Slot = "4")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x73956C", Offset = "0x73956C", VA = "0x73956C", Slot = "5")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x10E46C8", Offset = "0x10E46C8", VA = "0x10E46C8")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x10E4768", Offset = "0x10E4768", VA = "0x10E4768")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps);

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x739574", Offset = "0x739574", VA = "0x739574")]
		public bool hasHandle()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000026")]
	public struct DSP
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x73959C", Offset = "0x73959C", VA = "0x73959C")]
		public RESULT setParameterData(int index, byte[] data)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x7395A4", Offset = "0x7395A4", VA = "0x7395A4")]
		public RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x7395AC", Offset = "0x7395AC", VA = "0x7395AC")]
		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x7395BC", Offset = "0x7395BC", VA = "0x7395BC")]
		public RESULT getMeteringInfo(IntPtr zero, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x10E5CD0", Offset = "0x10E5CD0", VA = "0x10E5CD0")]
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, IntPtr data, uint length);

		[PreserveSig]
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x10E5F48", Offset = "0x10E5F48", VA = "0x10E5F48")]
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight);

		[PreserveSig]
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x10E6018", Offset = "0x10E6018", VA = "0x10E6018")]
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x10E60B8", Offset = "0x10E60B8", VA = "0x10E60B8")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, IntPtr zero, out DSP_METERING_INFO outputInfo);

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x7396A4", Offset = "0x7396A4", VA = "0x7396A4")]
		public bool hasHandle()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000027")]
	public struct StringWrapper
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr nativeUtf8Ptr;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x10F0A78", Offset = "0x10F0A78", VA = "0x10F0A78")]
		public static implicit operator string(StringWrapper fstring)
		{
			return null;
		}
	}
	[Token(Token = "0x2000028")]
	internal static class StringHelper
	{
		[Token(Token = "0x2000029")]
		public class ThreadSafeEncoding : IDisposable
		{
			[Token(Token = "0x4000122")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UTF8Encoding encoding;

			[Token(Token = "0x4000123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private byte[] encodedBuffer;

			[Token(Token = "0x4000124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private char[] decodedBuffer;

			[Token(Token = "0x4000125")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool inUse;

			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private GCHandle gcHandle;

			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x1740024", Offset = "0x1740024", VA = "0x1740024")]
			public bool InUse()
			{
				return default(bool);
			}

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x174002C", Offset = "0x174002C", VA = "0x174002C")]
			public void SetInUse()
			{
			}

			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x1740038", Offset = "0x1740038", VA = "0x1740038")]
			private int roundUpPowerTwo(int number)
			{
				return default(int);
			}

			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x173D218", Offset = "0x173D218", VA = "0x173D218")]
			public byte[] byteFromStringUTF8(string s)
			{
				return null;
			}

			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x173DA78", Offset = "0x173DA78", VA = "0x173DA78")]
			public IntPtr intptrFromStringUTF8(string s)
			{
				return default(IntPtr);
			}

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x1740050", Offset = "0x1740050", VA = "0x1740050")]
			public string stringFromNative(IntPtr nativePtr)
			{
				return null;
			}

			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x1740260", Offset = "0x1740260", VA = "0x1740260", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x1740354", Offset = "0x1740354", VA = "0x1740354")]
			public ThreadSafeEncoding()
			{
			}
		}

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ThreadSafeEncoding> encoders;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x10E3FF4", Offset = "0x10E3FF4", VA = "0x10E3FF4")]
		public static ThreadSafeEncoding GetFreeHelper()
		{
			return null;
		}
	}
	[Token(Token = "0x200002A")]
	public struct DSP_METERING_INFO
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numsamples;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] peaklevel;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] rmslevel;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public short numchannels;
	}
	[Token(Token = "0x200002B")]
	public class Error
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x10E1B00", Offset = "0x10E1B00", VA = "0x10E1B00")]
		public static string String(RESULT errcode)
		{
			return null;
		}
	}
	[Token(Token = "0x200002C")]
	internal static class Android
	{
		[Token(Token = "0x200002D")]
		public struct THREADAFFINITY
		{
			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public THREAD mixer;

			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public THREAD stream;

			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public THREAD nonblocking;

			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public THREAD file;

			[Token(Token = "0x400012F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public THREAD geometry;

			[Token(Token = "0x4000130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public THREAD profiler;

			[Token(Token = "0x4000131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public THREAD studioUpdate;

			[Token(Token = "0x4000132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public THREAD studioLoadBank;

			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public THREAD studioLoadSample;
		}

		[Token(Token = "0x200002E")]
		[Flags]
		public enum THREAD : uint
		{
			[Token(Token = "0x4000135")]
			DEFAULT = 0u,
			[Token(Token = "0x4000136")]
			CORE0 = 1u,
			[Token(Token = "0x4000137")]
			CORE1 = 2u,
			[Token(Token = "0x4000138")]
			CORE2 = 4u,
			[Token(Token = "0x4000139")]
			CORE3 = 8u,
			[Token(Token = "0x400013A")]
			CORE4 = 0x10u,
			[Token(Token = "0x400013B")]
			CORE5 = 0x20u,
			[Token(Token = "0x400013C")]
			CORE6 = 0x40u,
			[Token(Token = "0x400013D")]
			CORE7 = 0x80u
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x10E1538", Offset = "0x10E1538", VA = "0x10E1538")]
		public static RESULT setThreadAffinity(ref THREADAFFINITY affinity)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x10E153C", Offset = "0x10E153C", VA = "0x10E153C")]
		private static extern RESULT FMOD_Android_SetThreadAffinity(ref THREADAFFINITY affinity);
	}
}
namespace FMOD.Studio
{
	[Token(Token = "0x200002F")]
	public enum STOP_MODE
	{
		[Token(Token = "0x400013F")]
		ALLOWFADEOUT,
		[Token(Token = "0x4000140")]
		IMMEDIATE
	}
	[Token(Token = "0x2000030")]
	public enum LOADING_STATE
	{
		[Token(Token = "0x4000142")]
		UNLOADING,
		[Token(Token = "0x4000143")]
		UNLOADED,
		[Token(Token = "0x4000144")]
		LOADING,
		[Token(Token = "0x4000145")]
		LOADED,
		[Token(Token = "0x4000146")]
		ERROR
	}
	[Token(Token = "0x2000031")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int commandqueuesize;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int handleinitialsize;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int studioupdateperiod;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idlesampledatapoolsize;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int streamingscheduledelay;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr encryptionkey;
	}
	[Token(Token = "0x2000032")]
	public struct CPU_USAGE
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float dspusage;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float streamusage;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float geometryusage;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float updateusage;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float studiousage;
	}
	[Token(Token = "0x2000033")]
	public enum PARAMETER_TYPE
	{
		[Token(Token = "0x4000154")]
		GAME_CONTROLLED,
		[Token(Token = "0x4000155")]
		AUTOMATIC_DISTANCE,
		[Token(Token = "0x4000156")]
		AUTOMATIC_EVENT_CONE_ANGLE,
		[Token(Token = "0x4000157")]
		AUTOMATIC_EVENT_ORIENTATION,
		[Token(Token = "0x4000158")]
		AUTOMATIC_DIRECTION,
		[Token(Token = "0x4000159")]
		AUTOMATIC_ELEVATION,
		[Token(Token = "0x400015A")]
		AUTOMATIC_LISTENER_ORIENTATION,
		[Token(Token = "0x400015B")]
		AUTOMATIC_SPEED,
		[Token(Token = "0x400015C")]
		MAX
	}
	[Token(Token = "0x2000034")]
	[Flags]
	public enum PARAMETER_FLAGS : uint
	{
		[Token(Token = "0x400015E")]
		READONLY = 1u,
		[Token(Token = "0x400015F")]
		AUTOMATIC = 2u,
		[Token(Token = "0x4000160")]
		GLOBAL = 4u
	}
	[Token(Token = "0x2000035")]
	public struct PARAMETER_ID
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint data1;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint data2;
	}
	[Token(Token = "0x2000036")]
	public struct PARAMETER_DESCRIPTION
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PARAMETER_ID id;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minimum;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maximum;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float defaultvalue;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_TYPE type;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PARAMETER_FLAGS flags;
	}
	[Token(Token = "0x2000037")]
	internal enum LOAD_MEMORY_MODE
	{
		[Token(Token = "0x400016B")]
		LOAD_MEMORY,
		[Token(Token = "0x400016C")]
		LOAD_MEMORY_POINT
	}
	[Token(Token = "0x2000038")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x400016E")]
		NORMAL = 0u,
		[Token(Token = "0x400016F")]
		LIVEUPDATE = 1u,
		[Token(Token = "0x4000170")]
		ALLOW_MISSING_PLUGINS = 2u,
		[Token(Token = "0x4000171")]
		SYNCHRONOUS_UPDATE = 4u,
		[Token(Token = "0x4000172")]
		DEFERRED_CALLBACKS = 8u,
		[Token(Token = "0x4000173")]
		LOAD_FROM_UPDATE = 0x10u,
		[Token(Token = "0x4000174")]
		MEMORY_TRACKING = 0x20u
	}
	[Token(Token = "0x2000039")]
	[Flags]
	public enum LOAD_BANK_FLAGS : uint
	{
		[Token(Token = "0x4000176")]
		NORMAL = 0u,
		[Token(Token = "0x4000177")]
		NONBLOCKING = 1u,
		[Token(Token = "0x4000178")]
		DECOMPRESS_SAMPLES = 2u,
		[Token(Token = "0x4000179")]
		UNENCRYPTED = 4u
	}
	[Token(Token = "0x200003A")]
	public enum PLAYBACK_STATE
	{
		[Token(Token = "0x400017B")]
		PLAYING,
		[Token(Token = "0x400017C")]
		SUSTAINING,
		[Token(Token = "0x400017D")]
		STOPPED,
		[Token(Token = "0x400017E")]
		STARTING,
		[Token(Token = "0x400017F")]
		STOPPING
	}
	[Token(Token = "0x200003B")]
	public enum EVENT_PROPERTY
	{
		[Token(Token = "0x4000181")]
		CHANNELPRIORITY,
		[Token(Token = "0x4000182")]
		SCHEDULE_DELAY,
		[Token(Token = "0x4000183")]
		SCHEDULE_LOOKAHEAD,
		[Token(Token = "0x4000184")]
		MINIMUM_DISTANCE,
		[Token(Token = "0x4000185")]
		MAXIMUM_DISTANCE,
		[Token(Token = "0x4000186")]
		COOLDOWN,
		[Token(Token = "0x4000187")]
		MAX
	}
	[Token(Token = "0x200003C")]
	public struct Util
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x173F464", Offset = "0x173F464", VA = "0x173F464")]
		public static RESULT parseID(string idString, out Guid id)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x173F5A8", Offset = "0x173F5A8", VA = "0x173F5A8")]
		private static extern RESULT FMOD_Studio_ParseID(byte[] idString, out Guid id);
	}
	[Token(Token = "0x200003D")]
	public struct System
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x173D718", Offset = "0x173D718", VA = "0x173D718")]
		public static RESULT create(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x750B6C", Offset = "0x750B6C", VA = "0x750B6C")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x750B98", Offset = "0x750B98", VA = "0x750B98")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings, string encryptionKey)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x750BC4", Offset = "0x750BC4", VA = "0x750BC4")]
		public RESULT initialize(int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x750BCC", Offset = "0x750BCC", VA = "0x750BCC")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x750BD4", Offset = "0x750BD4", VA = "0x750BD4")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x750BDC", Offset = "0x750BDC", VA = "0x750BDC")]
		public RESULT getCoreSystem(out FMOD.System coresystem)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x750BE4", Offset = "0x750BE4", VA = "0x750BE4")]
		public RESULT getEvent(string path, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x750BEC", Offset = "0x750BEC", VA = "0x750BEC")]
		public RESULT getBus(string path, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x750BF4", Offset = "0x750BF4", VA = "0x750BF4")]
		public RESULT getVCA(string path, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x750BFC", Offset = "0x750BFC", VA = "0x750BFC")]
		public RESULT getEventByID(Guid id, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x750C28", Offset = "0x750C28", VA = "0x750C28")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x750C30", Offset = "0x750C30", VA = "0x750C30")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x750C3C", Offset = "0x750C3C", VA = "0x750C3C")]
		public RESULT lookupID(string path, out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x750C44", Offset = "0x750C44", VA = "0x750C44")]
		public RESULT setNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x750C4C", Offset = "0x750C4C", VA = "0x750C4C")]
		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x750C80", Offset = "0x750C80", VA = "0x750C80")]
		public RESULT loadBankFile(string filename, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x750C88", Offset = "0x750C88", VA = "0x750C88")]
		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x750C90", Offset = "0x750C90", VA = "0x750C90")]
		public RESULT flushCommands()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x750C98", Offset = "0x750C98", VA = "0x750C98")]
		public RESULT flushSampleLoading()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x750CA0", Offset = "0x750CA0", VA = "0x750CA0")]
		public RESULT getBankCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x750CA8", Offset = "0x750CA8", VA = "0x750CA8")]
		public RESULT getBankList(out Bank[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x750CB0", Offset = "0x750CB0", VA = "0x750CB0")]
		public RESULT getCPUUsage(out CPU_USAGE usage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x173D724", Offset = "0x173D724", VA = "0x173D724")]
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr system, uint headerversion);

		[PreserveSig]
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x173F188", Offset = "0x173F188", VA = "0x173F188")]
		private static extern bool FMOD_Studio_System_IsValid(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x173D878", Offset = "0x173D878", VA = "0x173D878")]
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x173DB0C", Offset = "0x173DB0C", VA = "0x173DB0C")]
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr system, int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x173DBC4", Offset = "0x173DBC4", VA = "0x173DBC4")]
		private static extern RESULT FMOD_Studio_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x173DC4C", Offset = "0x173DC4C", VA = "0x173DC4C")]
		private static extern RESULT FMOD_Studio_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x173DCD4", Offset = "0x173DCD4", VA = "0x173DCD4")]
		private static extern RESULT FMOD_Studio_System_GetCoreSystem(IntPtr system, out IntPtr coresystem);

		[PreserveSig]
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x173DEB8", Offset = "0x173DEB8", VA = "0x173DEB8")]
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr system, byte[] path, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x173E0AC", Offset = "0x173E0AC", VA = "0x173E0AC")]
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr system, byte[] path, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x173E2A0", Offset = "0x173E2A0", VA = "0x173E2A0")]
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr system, byte[] path, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x173E36C", Offset = "0x173E36C", VA = "0x173E36C")]
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr system, ref Guid id, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x173E404", Offset = "0x173E404", VA = "0x173E404")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByName(IntPtr system, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x173E608", Offset = "0x173E608", VA = "0x173E608")]
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x173E80C", Offset = "0x173E80C", VA = "0x173E80C")]
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr system, byte[] path, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x173E8B4", Offset = "0x173E8B4", VA = "0x173E8B4")]
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x173E94C", Offset = "0x173E94C", VA = "0x173E94C")]
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr system, int listener, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x173EB48", Offset = "0x173EB48", VA = "0x173EB48")]
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr system, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x173EC88", Offset = "0x173EC88", VA = "0x173EC88")]
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr system, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x173ED50", Offset = "0x173ED50", VA = "0x173ED50")]
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x173EDD8", Offset = "0x173EDD8", VA = "0x173EDD8")]
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x173EE60", Offset = "0x173EE60", VA = "0x173EE60")]
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x173F040", Offset = "0x173F040", VA = "0x173F040")]
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr system, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x173F0F8", Offset = "0x173F0F8", VA = "0x173F0F8")]
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr system, out CPU_USAGE usage);

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x750CB8", Offset = "0x750CB8", VA = "0x750CB8")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x750CC0", Offset = "0x750CC0", VA = "0x750CC0")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x750D04", Offset = "0x750D04", VA = "0x750D04")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200003E")]
	public struct EventDescription
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x739768", Offset = "0x739768", VA = "0x739768")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x739770", Offset = "0x739770", VA = "0x739770")]
		public RESULT isOneshot(out bool oneshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x739778", Offset = "0x739778", VA = "0x739778")]
		public RESULT is3D(out bool is3D)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x739780", Offset = "0x739780", VA = "0x739780")]
		public RESULT createInstance(out EventInstance instance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x739788", Offset = "0x739788", VA = "0x739788")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x739790", Offset = "0x739790", VA = "0x739790")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x739798", Offset = "0x739798", VA = "0x739798")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x10E69A8", Offset = "0x10E69A8", VA = "0x10E69A8")]
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x10E6570", Offset = "0x10E6570", VA = "0x10E6570")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x10E6618", Offset = "0x10E6618", VA = "0x10E6618")]
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot);

		[PreserveSig]
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x10E66C4", Offset = "0x10E66C4", VA = "0x10E66C4")]
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D);

		[PreserveSig]
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x10E6770", Offset = "0x10E6770", VA = "0x10E6770")]
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance);

		[PreserveSig]
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x10E6808", Offset = "0x10E6808", VA = "0x10E6808")]
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x10E6890", Offset = "0x10E6890", VA = "0x10E6890")]
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x10E6918", Offset = "0x10E6918", VA = "0x10E6918")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state);

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x7397A0", Offset = "0x7397A0", VA = "0x7397A0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x7397A8", Offset = "0x7397A8", VA = "0x7397A8")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200003F")]
	public struct EventInstance
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x7397B0", Offset = "0x7397B0", VA = "0x7397B0")]
		public RESULT set3DAttributes(ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x7397E4", Offset = "0x7397E4", VA = "0x7397E4")]
		public RESULT setProperty(EVENT_PROPERTY index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x7397EC", Offset = "0x7397EC", VA = "0x7397EC")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x7397F4", Offset = "0x7397F4", VA = "0x7397F4")]
		public RESULT stop(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x7397FC", Offset = "0x7397FC", VA = "0x7397FC")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x739804", Offset = "0x739804", VA = "0x739804")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x73980C", Offset = "0x73980C", VA = "0x73980C")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x739818", Offset = "0x739818", VA = "0x739818")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x10E7394", Offset = "0x10E7394", VA = "0x10E7394")]
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x10E6D54", Offset = "0x10E6D54", VA = "0x10E6D54")]
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x10E6DEC", Offset = "0x10E6DEC", VA = "0x10E6DEC")]
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value);

		[PreserveSig]
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x10E6E94", Offset = "0x10E6E94", VA = "0x10E6E94")]
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x10E6F1C", Offset = "0x10E6F1C", VA = "0x10E6F1C")]
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x10E6FB4", Offset = "0x10E6FB4", VA = "0x10E6FB4")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x10E704C", Offset = "0x10E704C", VA = "0x10E704C")]
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x10E72E4", Offset = "0x10E72E4", VA = "0x10E72E4")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x10E70D8", Offset = "0x10E70D8", VA = "0x10E70D8")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByID(IntPtr _event, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x739824", Offset = "0x739824", VA = "0x739824")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x73982C", Offset = "0x73982C", VA = "0x73982C")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x739870", Offset = "0x739870", VA = "0x739870")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000040")]
	public struct Bus
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x73952C", Offset = "0x73952C", VA = "0x73952C")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x739534", Offset = "0x739534", VA = "0x739534")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x73953C", Offset = "0x73953C", VA = "0x73953C")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x739548", Offset = "0x739548", VA = "0x739548")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x739554", Offset = "0x739554", VA = "0x739554")]
		public RESULT stopAllEvents(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x73955C", Offset = "0x73955C", VA = "0x73955C")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x10E426C", Offset = "0x10E426C", VA = "0x10E426C")]
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x10E431C", Offset = "0x10E431C", VA = "0x10E431C")]
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float volume);

		[PreserveSig]
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x10E43B8", Offset = "0x10E43B8", VA = "0x10E43B8")]
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused);

		[PreserveSig]
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x10E4454", Offset = "0x10E4454", VA = "0x10E4454")]
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute);

		[PreserveSig]
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x10E44EC", Offset = "0x10E44EC", VA = "0x10E44EC")]
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x10E4584", Offset = "0x10E4584", VA = "0x10E4584")]
		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group);
	}
	[Token(Token = "0x2000041")]
	public struct VCA
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;
	}
	[Token(Token = "0x2000042")]
	public struct Bank
	{
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x739504", Offset = "0x739504", VA = "0x739504")]
		public RESULT unload()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x73950C", Offset = "0x73950C", VA = "0x73950C")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x739514", Offset = "0x739514", VA = "0x739514")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x73951C", Offset = "0x73951C", VA = "0x73951C")]
		public RESULT getBusCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x739524", Offset = "0x739524", VA = "0x739524")]
		public RESULT getBusList(out Bus[] array)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x10E15C4", Offset = "0x10E15C4", VA = "0x10E15C4")]
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x10E164C", Offset = "0x10E164C", VA = "0x10E164C")]
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x10E16D4", Offset = "0x10E16D4", VA = "0x10E16D4")]
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x10E176C", Offset = "0x10E176C", VA = "0x10E176C")]
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x10E194C", Offset = "0x10E194C", VA = "0x10E194C")]
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count);
	}
}
namespace FMODUnity
{
	[Token(Token = "0x2000043")]
	public class BankRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x10E1C14", Offset = "0x10E1C14", VA = "0x10E1C14")]
		public BankRefAttribute()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class EventRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x10E7664", Offset = "0x10E7664", VA = "0x10E7664")]
		public EventRefAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class ParamRef
	{
		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_ID ID;

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x10EF650", Offset = "0x10EF650", VA = "0x10EF650")]
		public ParamRef()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x680FA0", Offset = "0x680FA0")]
	public class RuntimeManager : MonoBehaviour
	{
		[Token(Token = "0x2000047")]
		private struct LoadedBank
		{
			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Bank Bank;

			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int RefCount;
		}

		[Token(Token = "0x2000048")]
		private class GuidComparer : IEqualityComparer<Guid>
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x173FFC0", Offset = "0x173FFC0", VA = "0x173FFC0", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Guid>.Equals(Guid x, Guid y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000152")]
			[Address(RVA = "0x173FFF4", Offset = "0x173FFF4", VA = "0x173FFF4", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Guid>.GetHashCode(Guid obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000153")]
			[Address(RVA = "0x174001C", Offset = "0x174001C", VA = "0x174001C")]
			public GuidComparer()
			{
			}
		}

		[Token(Token = "0x2000049")]
		private class AttachedInstance
		{
			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform transform;

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Rigidbody rigidBody;

			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Rigidbody2D rigidBody2D;

			[Token(Token = "0x6000154")]
			[Address(RVA = "0x173FFB8", Offset = "0x173FFB8", VA = "0x173FFB8")]
			public AttachedInstance()
			{
			}
		}

		[Token(Token = "0x200004A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x680FD8", Offset = "0x680FD8")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x6000155")]
			[Address(RVA = "0x173FC24", Offset = "0x173FC24", VA = "0x173FC24")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000156")]
			[Address(RVA = "0x173FC2C", Offset = "0x173FC2C", VA = "0x173FC2C")]
			internal bool <AttachInstanceToGameObject>b__0(AttachedInstance x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x680FE8", Offset = "0x680FE8")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x6000157")]
			[Address(RVA = "0x173FC50", Offset = "0x173FC50", VA = "0x173FC50")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000158")]
			[Address(RVA = "0x173FC58", Offset = "0x173FC58", VA = "0x173FC58")]
			internal bool <AttachInstanceToGameObject>b__0(AttachedInstance x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x680FF8", Offset = "0x680FF8")]
		private sealed class <loadFromWeb>d__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string bankPath;

			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RuntimeManager <>4__this;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bankName;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool loadSamples;

			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x1700000C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600015C")]
				[Address(RVA = "0x173FF48", Offset = "0x173FF48", VA = "0x173FF48", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600015E")]
				[Address(RVA = "0x173FFB0", Offset = "0x173FFB0", VA = "0x173FFB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000159")]
			[Address(RVA = "0x173FC7C", Offset = "0x173FC7C", VA = "0x173FC7C")]
			[DebuggerHidden]
			public <loadFromWeb>d__43(int <>1__state)
			{
			}

			[Token(Token = "0x600015A")]
			[Address(RVA = "0x173FCA8", Offset = "0x173FCA8", VA = "0x173FCA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600015B")]
			[Address(RVA = "0x173FCAC", Offset = "0x173FCAC", VA = "0x173FCAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600015D")]
			[Address(RVA = "0x173FF50", Offset = "0x173FF50", VA = "0x173FF50", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SystemNotInitializedException initException;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static RuntimeManager instance;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FMODPlatform fmodPlatform;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FMOD.Studio.System studioSystem;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FMOD.System coreSystem;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DSP mixerHead;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private long[] cachedPointers;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, LoadedBank> loadedBanks;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, uint> loadedPlugins;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<Guid, EventDescription> cachedDescriptions;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<AttachedInstance> attachedInstances;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool listenerWarningIssued;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		protected bool isOverlayEnabled;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private FMODRuntimeManagerOnGUIHelper overlayDrawer;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rect windowRect;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string lastDebugText;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float lastDebugUpdate;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static List<StudioListener> Listeners;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int numListeners;

		[Token(Token = "0x17000007")]
		private static RuntimeManager Instance
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x10F0BAC", Offset = "0x10F0BAC", VA = "0x10F0BAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public static FMOD.Studio.System StudioSystem
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x10E9BC0", Offset = "0x10E9BC0", VA = "0x10E9BC0")]
			get
			{
				return default(FMOD.Studio.System);
			}
		}

		[Token(Token = "0x17000009")]
		public static FMOD.System CoreSystem
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x10F1B4C", Offset = "0x10F1B4C", VA = "0x10F1B4C")]
			get
			{
				return default(FMOD.System);
			}
		}

		[Token(Token = "0x1700000A")]
		public static bool IsInitialized
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x10F5E6C", Offset = "0x10F5E6C", VA = "0x10F5E6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public static bool HasBanksLoaded
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x10F5D24", Offset = "0x10F5D24", VA = "0x10F5D24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x10F08CC", Offset = "0x10F08CC", VA = "0x10F08CC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x6819C4", Offset = "0x6819C4")]
		private static RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x10F1BB8", Offset = "0x10F1BB8", VA = "0x10F1BB8")]
		private void CheckInitResult(RESULT result, string cause)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x10F166C", Offset = "0x10F166C", VA = "0x10F166C")]
		private RESULT Initialize()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x10F2948", Offset = "0x10F2948", VA = "0x10F2948")]
		public static int AddListener(StudioListener listener)
		{
			return default(int);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x10F2D50", Offset = "0x10F2D50", VA = "0x10F2D50")]
		public static bool RemoveListener(StudioListener listener)
		{
			return default(bool);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x10F3074", Offset = "0x10F3074", VA = "0x10F3074")]
		private void Update()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x10EA074", Offset = "0x10EA074", VA = "0x10EA074")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x10EA208", Offset = "0x10EA208", VA = "0x10EA208")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x10F3724", Offset = "0x10F3724", VA = "0x10F3724")]
		public static void DetachInstanceFromGameObject(EventInstance instance)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x10EAA70", Offset = "0x10EAA70", VA = "0x10EAA70")]
		public void ExecuteOnGUI()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x10F3820", Offset = "0x10F3820", VA = "0x10F3820")]
		private void Start()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x10F38C8", Offset = "0x10F38C8", VA = "0x10F38C8")]
		private void DrawDebugOverlay(int windowID)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x10F3D14", Offset = "0x10F3D14", VA = "0x10F3D14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x10F3D84", Offset = "0x10F3D84", VA = "0x10F3D84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x10F3E28", Offset = "0x10F3E28", VA = "0x10F3E28")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x10F3F98", Offset = "0x10F3F98", VA = "0x10F3F98")]
		private void loadedBankRegister(LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, RESULT loadResult)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x10F40E0", Offset = "0x10F40E0", VA = "0x10F40E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x681A28", Offset = "0x681A28")]
		private IEnumerator loadFromWeb(string bankPath, string bankName, bool loadSamples)
		{
			return null;
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x10F4178", Offset = "0x10F4178", VA = "0x10F4178")]
		public static void LoadBank(string bankName, bool loadSamples = false)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x10F4684", Offset = "0x10F4684", VA = "0x10F4684")]
		public static void LoadBank(TextAsset asset, bool loadSamples = false)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x10F24D0", Offset = "0x10F24D0", VA = "0x10F24D0")]
		private void LoadBanks(Settings fmodSettings)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x10F492C", Offset = "0x10F492C", VA = "0x10F492C")]
		public static void UnloadBank(string bankName)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x10F4A60", Offset = "0x10F4A60", VA = "0x10F4A60")]
		public static bool AnyBankLoading()
		{
			return default(bool);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x10F48BC", Offset = "0x10F48BC", VA = "0x10F48BC")]
		public static void WaitForAllLoads()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x10F4BA0", Offset = "0x10F4BA0", VA = "0x10F4BA0")]
		public static Guid PathToGUID(string path)
		{
			return default(Guid);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x10E9F64", Offset = "0x10E9F64", VA = "0x10E9F64")]
		public static EventInstance CreateInstance(string path)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x10F4CCC", Offset = "0x10F4CCC", VA = "0x10F4CCC")]
		public static EventInstance CreateInstance(Guid guid)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x10F4F50", Offset = "0x10F4F50", VA = "0x10F4F50")]
		public static void PlayOneShot(string path, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x10F50B4", Offset = "0x10F50B4", VA = "0x10F50B4")]
		public static void PlayOneShot(Guid guid, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x10F5184", Offset = "0x10F5184", VA = "0x10F5184")]
		public static void PlayOneShotAttached(string path, GameObject gameObject)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x10F52CC", Offset = "0x10F52CC", VA = "0x10F52CC")]
		public static void PlayOneShotAttached(Guid guid, GameObject gameObject)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x10F5394", Offset = "0x10F5394", VA = "0x10F5394")]
		public static EventDescription GetEventDescription(string path)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x10F4D54", Offset = "0x10F4D54", VA = "0x10F4D54")]
		public static EventDescription GetEventDescription(Guid guid)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x10F54A4", Offset = "0x10F54A4", VA = "0x10F54A4")]
		public static void SetListenerLocation(GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x10F567C", Offset = "0x10F567C", VA = "0x10F567C")]
		public static void SetListenerLocation(GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x10F5860", Offset = "0x10F5860", VA = "0x10F5860")]
		public static void SetListenerLocation(Transform transform)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x10F59A4", Offset = "0x10F59A4", VA = "0x10F59A4")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x10F5A50", Offset = "0x10F5A50", VA = "0x10F5A50")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x10F5AFC", Offset = "0x10F5AFC", VA = "0x10F5AFC")]
		public static void SetListenerLocation(int listenerIndex, Transform transform)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x10F5BA0", Offset = "0x10F5BA0", VA = "0x10F5BA0")]
		public static Bus GetBus(string path)
		{
			return default(Bus);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x10F5C60", Offset = "0x10F5C60", VA = "0x10F5C60")]
		public static VCA GetVCA(string path)
		{
			return default(VCA);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x10F3ED8", Offset = "0x10F3ED8", VA = "0x10F3ED8")]
		public static void PauseAllEvents(bool paused)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x10F5DAC", Offset = "0x10F5DAC", VA = "0x10F5DAC")]
		public static void MuteAllEvents(bool muted)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x10F5F50", Offset = "0x10F5F50", VA = "0x10F5F50")]
		public static bool HasBankLoaded(string loadedBank)
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x10F2328", Offset = "0x10F2328", VA = "0x10F2328")]
		private void LoadPlugins(Settings fmodSettings)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x10F2240", Offset = "0x10F2240", VA = "0x10F2240")]
		private void SetThreadAffinity()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x10F6058", Offset = "0x10F6058", VA = "0x10F6058")]
		public RuntimeManager()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class EventNotFoundException : Exception
	{
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Guid Guid;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string Path;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x10E74E4", Offset = "0x10E74E4", VA = "0x10E74E4")]
		public EventNotFoundException(string path)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x10E7590", Offset = "0x10E7590", VA = "0x10E7590")]
		public EventNotFoundException(Guid guid)
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class BusNotFoundException : Exception
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x10E4614", Offset = "0x10E4614", VA = "0x10E4614")]
		public BusNotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class VCANotFoundException : Exception
	{
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x173F640", Offset = "0x173F640", VA = "0x173F640")]
		public VCANotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class BankLoadException : Exception
	{
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RESULT Result;

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x10E19FC", Offset = "0x10E19FC", VA = "0x10E19FC")]
		public BankLoadException(string path, RESULT result)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x10E1B64", Offset = "0x10E1B64", VA = "0x10E1B64")]
		public BankLoadException(string path, string error)
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class SystemNotInitializedException : Exception
	{
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public RESULT Result;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Location;

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x173F2D8", Offset = "0x173F2D8", VA = "0x173F2D8")]
		public SystemNotInitializedException(RESULT result, string location)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x173F3E0", Offset = "0x173F3E0", VA = "0x173F3E0")]
		public SystemNotInitializedException(Exception inner)
		{
		}
	}
	[Token(Token = "0x2000052")]
	public enum EmitterGameEvent
	{
		[Token(Token = "0x40001BC")]
		None,
		[Token(Token = "0x40001BD")]
		ObjectStart,
		[Token(Token = "0x40001BE")]
		ObjectDestroy,
		[Token(Token = "0x40001BF")]
		TriggerEnter,
		[Token(Token = "0x40001C0")]
		TriggerExit,
		[Token(Token = "0x40001C1")]
		TriggerEnter2D,
		[Token(Token = "0x40001C2")]
		TriggerExit2D,
		[Token(Token = "0x40001C3")]
		CollisionEnter,
		[Token(Token = "0x40001C4")]
		CollisionExit,
		[Token(Token = "0x40001C5")]
		CollisionEnter2D,
		[Token(Token = "0x40001C6")]
		CollisionExit2D,
		[Token(Token = "0x40001C7")]
		ObjectEnable,
		[Token(Token = "0x40001C8")]
		ObjectDisable,
		[Token(Token = "0x40001C9")]
		MouseEnter,
		[Token(Token = "0x40001CA")]
		MouseExit,
		[Token(Token = "0x40001CB")]
		MouseDown,
		[Token(Token = "0x40001CC")]
		MouseUp
	}
	[Token(Token = "0x2000053")]
	public enum LoaderGameEvent
	{
		[Token(Token = "0x40001CE")]
		None,
		[Token(Token = "0x40001CF")]
		ObjectStart,
		[Token(Token = "0x40001D0")]
		ObjectDestroy,
		[Token(Token = "0x40001D1")]
		TriggerEnter,
		[Token(Token = "0x40001D2")]
		TriggerExit,
		[Token(Token = "0x40001D3")]
		TriggerEnter2D,
		[Token(Token = "0x40001D4")]
		TriggerExit2D
	}
	[Token(Token = "0x2000054")]
	public static class RuntimeUtils
	{
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x10F6248", Offset = "0x10F6248", VA = "0x10F6248")]
		public static VECTOR ToFMODVector(this Vector3 vec)
		{
			return default(VECTOR);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x10EA39C", Offset = "0x10EA39C", VA = "0x10EA39C")]
		public static ATTRIBUTES_3D To3DAttributes(this Vector3 pos)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x10F58F8", Offset = "0x10F58F8", VA = "0x10F58F8")]
		public static ATTRIBUTES_3D To3DAttributes(this Transform transform)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x10F34D0", Offset = "0x10F34D0", VA = "0x10F34D0")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x10F554C", Offset = "0x10F554C", VA = "0x10F554C")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x10F35F4", Offset = "0x10F35F4", VA = "0x10F35F4")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x10F5724", Offset = "0x10F5724", VA = "0x10F5724")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x10F1E0C", Offset = "0x10F1E0C", VA = "0x10F1E0C")]
		internal static FMODPlatform GetCurrentPlatform()
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x10F4550", Offset = "0x10F4550", VA = "0x10F4550")]
		internal static string GetBankPath(string bankName)
		{
			return null;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x10F5FDC", Offset = "0x10F5FDC", VA = "0x10F5FDC")]
		internal static string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x10F14E4", Offset = "0x10F14E4", VA = "0x10F14E4")]
		public static void EnforceLibraryOrder()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x10F13CC", Offset = "0x10F13CC", VA = "0x10F13CC")]
		public static bool VerifyPlatformLibsExist()
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public enum FMODPlatform
	{
		[Token(Token = "0x40001D6")]
		None,
		[Token(Token = "0x40001D7")]
		PlayInEditor,
		[Token(Token = "0x40001D8")]
		Default,
		[Token(Token = "0x40001D9")]
		Desktop,
		[Token(Token = "0x40001DA")]
		Mobile,
		[Token(Token = "0x40001DB")]
		MobileHigh,
		[Token(Token = "0x40001DC")]
		MobileLow,
		[Token(Token = "0x40001DD")]
		Console,
		[Token(Token = "0x40001DE")]
		Windows,
		[Token(Token = "0x40001DF")]
		Mac,
		[Token(Token = "0x40001E0")]
		Linux,
		[Token(Token = "0x40001E1")]
		iOS,
		[Token(Token = "0x40001E2")]
		Android,
		[Token(Token = "0x40001E3")]
		Deprecated_1,
		[Token(Token = "0x40001E4")]
		XboxOne,
		[Token(Token = "0x40001E5")]
		PS4,
		[Token(Token = "0x40001E6")]
		Deprecated_2,
		[Token(Token = "0x40001E7")]
		Deprecated_3,
		[Token(Token = "0x40001E8")]
		AppleTV,
		[Token(Token = "0x40001E9")]
		UWP,
		[Token(Token = "0x40001EA")]
		Switch,
		[Token(Token = "0x40001EB")]
		WebGL,
		[Token(Token = "0x40001EC")]
		Stadia,
		[Token(Token = "0x40001ED")]
		Reserved_1,
		[Token(Token = "0x40001EE")]
		Reserved_2,
		[Token(Token = "0x40001EF")]
		Count
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public enum ImportType
	{
		[Token(Token = "0x40001F1")]
		StreamingAssets,
		[Token(Token = "0x40001F2")]
		AssetBundle
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public enum BankLoadType
	{
		[Token(Token = "0x40001F4")]
		All,
		[Token(Token = "0x40001F5")]
		Specified,
		[Token(Token = "0x40001F6")]
		None
	}
	[Token(Token = "0x2000058")]
	public class PlatformSettingBase
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FMODPlatform Platform;

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x10EF700", Offset = "0x10EF700", VA = "0x10EF700")]
		public PlatformSettingBase()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class PlatformSetting<T> : PlatformSettingBase
	{
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Value;

		[Token(Token = "0x6000174")]
		public PlatformSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class PlatformIntSetting : PlatformSetting<int>
	{
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x10EF6B0", Offset = "0x10EF6B0", VA = "0x10EF6B0")]
		public PlatformIntSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class PlatformStringSetting : PlatformSetting<string>
	{
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x10EF708", Offset = "0x10EF708", VA = "0x10EF708")]
		public PlatformStringSetting()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public enum TriStateBool
	{
		[Token(Token = "0x40001FA")]
		Disabled,
		[Token(Token = "0x40001FB")]
		Enabled,
		[Token(Token = "0x40001FC")]
		Development
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class PlatformBoolSetting : PlatformSetting<TriStateBool>
	{
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x10EF660", Offset = "0x10EF660", VA = "0x10EF660")]
		public PlatformBoolSetting()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class Settings : ScriptableObject
	{
		[Token(Token = "0x200005F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681018", Offset = "0x681018")]
		private sealed class <>c__DisplayClass36_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x600018A")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x600018B")]
			internal bool <HasSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681028", Offset = "0x681028")]
		private sealed class <>c__DisplayClass37_0<T, U> where T : PlatformSetting<U>
		{
			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x600018C")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x600018D")]
			internal bool <GetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681038", Offset = "0x681038")]
		private sealed class <>c__DisplayClass38_0<T, U> where T : PlatformSetting<U>, new()
		{
			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x600018E")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x600018F")]
			internal bool <SetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000062")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x681048", Offset = "0x681048")]
		private sealed class <>c__DisplayClass39_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x6000190")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000191")]
			internal bool <RemoveSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001FD")]
		private const string SettingsAssetName = "FMODStudioSettings";

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Settings instance;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public bool HasSourceProject;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		public bool HasPlatforms;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string sourceProjectPath;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string sourceBankPath;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public string SourceBankPathUnformatted;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public bool AutomaticEventLoading;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		public BankLoadType BankLoadType;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public bool AutomaticSampleLoading;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public string EncryptionKey;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public ImportType ImportType;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public string TargetAssetPath;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		public DEBUG_FLAGS LoggingLevel;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		public List<PlatformIntSetting> SpeakerModeSettings;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		public List<PlatformIntSetting> SampleRateSettings;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		public List<PlatformBoolSetting> LiveUpdateSettings;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		public List<PlatformBoolSetting> OverlaySettings;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		public List<PlatformBoolSetting> LoggingSettings;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		public List<PlatformStringSetting> BankDirectorySettings;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		public List<PlatformIntSetting> VirtualChannelSettings;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		public List<PlatformIntSetting> RealChannelSettings;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		public List<string> Plugins;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		public List<string> MasterBanks;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		public List<string> Banks;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		public List<string> BanksToLoad;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		public ushort LiveUpdatePort;

		[Token(Token = "0x1700000E")]
		public static Settings Instance
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x10F1C70", Offset = "0x10F1C70", VA = "0x10F1C70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public string SourceProjectPath
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x10F6914", Offset = "0x10F6914", VA = "0x10F6914")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x10F691C", Offset = "0x10F691C", VA = "0x10F691C")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public string SourceBankPath
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x10F6924", Offset = "0x10F6924", VA = "0x10F6924")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x10F692C", Offset = "0x10F692C", VA = "0x10F692C")]
			set
			{
			}
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x10F6934", Offset = "0x10F6934", VA = "0x10F6934")]
		public static FMODPlatform GetParent(FMODPlatform platform)
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x600017E")]
		public static bool HasSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
			return default(bool);
		}

		[Token(Token = "0x600017F")]
		public static U GetSetting<T, U>(List<T> list, FMODPlatform platform, U def) where T : PlatformSetting<U>
		{
			return (U)null;
		}

		[Token(Token = "0x6000180")]
		public static void SetSetting<T, U>(List<T> list, FMODPlatform platform, U value) where T : PlatformSetting<U>, new()
		{
		}

		[Token(Token = "0x6000181")]
		public static void RemoveSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x10F22B8", Offset = "0x10F22B8", VA = "0x10F22B8")]
		public bool IsLiveUpdateEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x10F3858", Offset = "0x10F3858", VA = "0x10F3858")]
		public bool IsOverlayEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x10F2114", Offset = "0x10F2114", VA = "0x10F2114")]
		public int GetRealChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x10F2178", Offset = "0x10F2178", VA = "0x10F2178")]
		public int GetVirtualChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x10F21DC", Offset = "0x10F21DC", VA = "0x10F21DC")]
		public int GetSpeakerMode(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x10F20B0", Offset = "0x10F20B0", VA = "0x10F20B0")]
		public int GetSampleRate(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x10F6958", Offset = "0x10F6958", VA = "0x10F6958")]
		public string GetBankPlatform(FMODPlatform platform)
		{
			return null;
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x10F69E0", Offset = "0x10F69E0", VA = "0x10F69E0")]
		private Settings()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681058", Offset = "0x681058")]
	public class StudioBankLoader : MonoBehaviour
	{
		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LoaderGameEvent LoadEvent;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LoaderGameEvent UnloadEvent;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[BankRef]
		public List<string> Banks;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string CollisionTag;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool PreloadSamples;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isQuitting;

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x10F6D60", Offset = "0x10F6D60", VA = "0x10F6D60")]
		private void HandleGameEvent(LoaderGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x10F70F4", Offset = "0x10F70F4", VA = "0x10F70F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x10F711C", Offset = "0x10F711C", VA = "0x10F711C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x10F7128", Offset = "0x10F7128", VA = "0x10F7128")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x10F713C", Offset = "0x10F713C", VA = "0x10F713C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x10F719C", Offset = "0x10F719C", VA = "0x10F719C")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x10F71FC", Offset = "0x10F71FC", VA = "0x10F71FC")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x10F725C", Offset = "0x10F725C", VA = "0x10F725C")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x10F6DB0", Offset = "0x10F6DB0", VA = "0x10F6DB0")]
		public void Load()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x10F6FE0", Offset = "0x10F6FE0", VA = "0x10F6FE0")]
		public void Unload()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x10F72BC", Offset = "0x10F72BC", VA = "0x10F72BC")]
		public StudioBankLoader()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681090", Offset = "0x681090")]
	public class StudioEventEmitter : EventHandler
	{
		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[EventRef]
		public string Event;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent PlayEvent;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public EmitterGameEvent StopEvent;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool AllowFadeout;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool TriggerOnce;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Preload;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParamRef[] Params;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool OverrideAttenuation;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float OverrideMinDistance;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OverrideMaxDistance;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected EventDescription eventDescription;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected EventInstance instance;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasTriggered;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool isQuitting;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool isOneshot;

		[Token(Token = "0x4000231")]
		private const string SnapshotString = "snapshot";

		[Token(Token = "0x17000011")]
		public EventDescription EventDescription
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x10F72C4", Offset = "0x10F72C4", VA = "0x10F72C4")]
			get
			{
				return default(EventDescription);
			}
		}

		[Token(Token = "0x17000012")]
		public EventInstance EventInstance
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x10F72CC", Offset = "0x10F72CC", VA = "0x10F72CC")]
			get
			{
				return default(EventInstance);
			}
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x10F72D4", Offset = "0x10F72D4", VA = "0x10F72D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x10F74CC", Offset = "0x10F74CC", VA = "0x10F74CC")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x10F74D8", Offset = "0x10F74D8", VA = "0x10F74D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x10F75D8", Offset = "0x10F75D8", VA = "0x10F75D8", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x10F73B0", Offset = "0x10F73B0", VA = "0x10F73B0")]
		private void Lookup()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x10F7628", Offset = "0x10F7628", VA = "0x10F7628")]
		public void Play()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x10F795C", Offset = "0x10F795C", VA = "0x10F795C")]
		public void Stop()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x10F79C8", Offset = "0x10F79C8", VA = "0x10F79C8")]
		public void SetParameter(string name, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x10F7A30", Offset = "0x10F7A30", VA = "0x10F7A30")]
		public void SetParameter(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x10F7A98", Offset = "0x10F7A98", VA = "0x10F7A98")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x10F7AE4", Offset = "0x10F7AE4", VA = "0x10F7AE4")]
		public StudioEventEmitter()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6810C8", Offset = "0x6810C8")]
	public class StudioListener : MonoBehaviour
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rigidBody;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody2D rigidBody2D;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int ListenerNumber;

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x173C78C", Offset = "0x173C78C", VA = "0x173C78C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x173C850", Offset = "0x173C850", VA = "0x173C850")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x173C8B8", Offset = "0x173C8B8", VA = "0x173C8B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x173C8CC", Offset = "0x173C8CC", VA = "0x173C8CC")]
		private void SetListenerLocation()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x173C9D0", Offset = "0x173C9D0", VA = "0x173C9D0")]
		public StudioListener()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class EmitterRef
	{
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StudioEventEmitter Target;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParamRef[] Params;

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x10E6414", Offset = "0x10E6414", VA = "0x10E6414")]
		public EmitterRef()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681100", Offset = "0x681100")]
	public class StudioParameterTrigger : EventHandler
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EmitterRef[] Emitters;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x173C9E0", Offset = "0x173C9E0", VA = "0x173C9E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x173CBD4", Offset = "0x173CBD4", VA = "0x173CBD4", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x173CBE8", Offset = "0x173CBE8", VA = "0x173CBE8")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x173CD80", Offset = "0x173CD80", VA = "0x173CD80")]
		public StudioParameterTrigger()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public abstract class EventHandler : MonoBehaviour
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string CollisionTag;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x10E6AB4", Offset = "0x10E6AB4", VA = "0x10E6AB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x10E6AC4", Offset = "0x10E6AC4", VA = "0x10E6AC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x10E6AD4", Offset = "0x10E6AD4", VA = "0x10E6AD4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x10E6B3C", Offset = "0x10E6B3C", VA = "0x10E6B3C")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x10E6BA4", Offset = "0x10E6BA4", VA = "0x10E6BA4")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x10E6C0C", Offset = "0x10E6C0C", VA = "0x10E6C0C")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x10E6C74", Offset = "0x10E6C74", VA = "0x10E6C74")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x10E6C84", Offset = "0x10E6C84", VA = "0x10E6C84")]
		private void OnCollisionExit()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x10E6C94", Offset = "0x10E6C94", VA = "0x10E6C94")]
		private void OnCollisionEnter2D()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x10E6CA4", Offset = "0x10E6CA4", VA = "0x10E6CA4")]
		private void OnCollisionExit2D()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x10E6CB4", Offset = "0x10E6CB4", VA = "0x10E6CB4")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x10E6CC4", Offset = "0x10E6CC4", VA = "0x10E6CC4")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x10E6CD4", Offset = "0x10E6CD4", VA = "0x10E6CD4")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x10E6CE4", Offset = "0x10E6CE4", VA = "0x10E6CE4")]
		private void OnMouseUp()
		{
		}

		[Token(Token = "0x60001C2")]
		protected abstract void HandleGameEvent(EmitterGameEvent gameEvent);

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x10E6CF4", Offset = "0x10E6CF4", VA = "0x10E6CF4")]
		protected EventHandler()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class FMODRuntimeManagerOnGUIHelper : MonoBehaviour
	{
		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RuntimeManager TargetRuntimeManager;

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x10EA9E4", Offset = "0x10EA9E4", VA = "0x10EA9E4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x10EAB7C", Offset = "0x10EAB7C", VA = "0x10EAB7C")]
		public FMODRuntimeManagerOnGUIHelper()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class ParamRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x10EF658", Offset = "0x10EF658", VA = "0x10EF658")]
		public ParamRefAttribute()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681138", Offset = "0x681138")]
	public class StudioGlobalParameterTrigger : EventHandler
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ParamRef]
		public string parameter;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float value;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PARAMETER_DESCRIPTION parameterDescription;

		[Token(Token = "0x17000013")]
		public PARAMETER_DESCRIPTION ParameterDesctription
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x173C528", Offset = "0x173C528", VA = "0x173C528")]
			get
			{
				return default(PARAMETER_DESCRIPTION);
			}
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x173C53C", Offset = "0x173C53C", VA = "0x173C53C")]
		private RESULT Lookup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x173C718", Offset = "0x173C718", VA = "0x173C718")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x173C75C", Offset = "0x173C75C", VA = "0x173C75C", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x173C778", Offset = "0x173C778", VA = "0x173C778")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x173C784", Offset = "0x173C784", VA = "0x173C784")]
		public StudioGlobalParameterTrigger()
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x200006C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x681170", Offset = "0x681170")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681170", Offset = "0x681170")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x200006D")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x400025E")]
			Ghosting,
			[Token(Token = "0x400025F")]
			Anamorphic,
			[Token(Token = "0x4000260")]
			Combined
		}

		[Token(Token = "0x200006E")]
		public enum TweakMode
		{
			[Token(Token = "0x4000262")]
			Basic,
			[Token(Token = "0x4000263")]
			Complex
		}

		[Token(Token = "0x200006F")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x4000265")]
			Auto,
			[Token(Token = "0x4000266")]
			On,
			[Token(Token = "0x4000267")]
			Off
		}

		[Token(Token = "0x2000070")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x4000269")]
			Screen,
			[Token(Token = "0x400026A")]
			Add
		}

		[Token(Token = "0x2000071")]
		public enum BloomQuality
		{
			[Token(Token = "0x400026C")]
			Cheap,
			[Token(Token = "0x400026D")]
			High
		}

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x10E1C1C", Offset = "0x10E1C1C", VA = "0x10E1C1C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x10E21D0", Offset = "0x10E21D0", VA = "0x10E21D0")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x10E3644", Offset = "0x10E3644", VA = "0x10E3644")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x10E33C8", Offset = "0x10E33C8", VA = "0x10E33C8")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x10E30D0", Offset = "0x10E30D0", VA = "0x10E30D0")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x10E2FEC", Offset = "0x10E2FEC", VA = "0x10E2FEC")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x10E31BC", Offset = "0x10E31BC", VA = "0x10E31BC")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x10E370C", Offset = "0x10E370C", VA = "0x10E370C")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x681208", Offset = "0x681208")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681208", Offset = "0x681208")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000073")]
		public enum Resolution
		{
			[Token(Token = "0x4000277")]
			Low,
			[Token(Token = "0x4000278")]
			High
		}

		[Token(Token = "0x2000074")]
		public enum BlurType
		{
			[Token(Token = "0x400027A")]
			Standard,
			[Token(Token = "0x400027B")]
			Sgx
		}

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x681774", Offset = "0x681774")]
		public float threshold;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68178C", Offset = "0x68178C")]
		public float intensity;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6817A4", Offset = "0x6817A4")]
		public float blurSize;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6817BC", Offset = "0x6817BC")]
		public int blurIterations;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x10E38C4", Offset = "0x10E38C4", VA = "0x10E38C4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x10E391C", Offset = "0x10E391C", VA = "0x10E391C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x10E39CC", Offset = "0x10E39CC", VA = "0x10E39CC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x10E3D98", Offset = "0x10E3D98", VA = "0x10E3D98")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6812A0", Offset = "0x6812A0")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x2000076")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x4000295")]
			Simple,
			[Token(Token = "0x4000296")]
			Advanced
		}

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x10E4844", Offset = "0x10E4844", VA = "0x10E4844")]
		private new void Start()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x10E4880", Offset = "0x10E4880", VA = "0x10E4880", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x10E4AE0", Offset = "0x10E4AE0", VA = "0x10E4AE0")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x10E4ED4", Offset = "0x10E4ED4", VA = "0x10E4ED4")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x10E4ED8", Offset = "0x10E4ED8", VA = "0x10E4ED8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x10E51D4", Offset = "0x10E51D4", VA = "0x10E51D4")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6812EC", Offset = "0x6812EC")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x10E1DAC", Offset = "0x10E1DAC", VA = "0x10E1DAC")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x10EF784", Offset = "0x10EF784", VA = "0x10EF784")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x10EF960", Offset = "0x10EF960", VA = "0x10EF960")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x10EF96C", Offset = "0x10EF96C", VA = "0x10EF96C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x10EF970", Offset = "0x10EF970", VA = "0x10EF970")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x10EFA20", Offset = "0x10EFA20", VA = "0x10EFA20")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x10EFA28", Offset = "0x10EFA28", VA = "0x10EFA28", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x10E4874", Offset = "0x10E4874", VA = "0x10E4874")]
		protected void Start()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x10E1CA4", Offset = "0x10E1CA4", VA = "0x10E1CA4")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x10EFAD8", Offset = "0x10EFAD8", VA = "0x10EFAD8")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x10EFB34", Offset = "0x10EFB34", VA = "0x10EFB34")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x10E2128", Offset = "0x10E2128", VA = "0x10E2128")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x10EFB3C", Offset = "0x10EFB3C", VA = "0x10EFB3C")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x10EF758", Offset = "0x10EF758", VA = "0x10EF758")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x10EFD3C", Offset = "0x10EFD3C", VA = "0x10EFD3C")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x10E3848", Offset = "0x10E3848", VA = "0x10E3848")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x681360", Offset = "0x681360")]
	[ExecuteInEditMode]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x10F00B8", Offset = "0x10F00B8", VA = "0x10F00B8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x10F0124", Offset = "0x10F0124", VA = "0x10F0124")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x10F03A0", Offset = "0x10F03A0", VA = "0x10F03A0")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x10F0718", Offset = "0x10F0718", VA = "0x10F0718")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x10F08C4", Offset = "0x10F08C4", VA = "0x10F08C4")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6813D4", Offset = "0x6813D4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6813D4", Offset = "0x6813D4")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6817D4", Offset = "0x6817D4")]
		public float intensity;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6817EC", Offset = "0x6817EC")]
		public float radius;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x681808", Offset = "0x681808")]
		public int blurIterations;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x681820", Offset = "0x681820")]
		public float blurFilterDistance;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x681838", Offset = "0x681838")]
		public int downsample;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x10F624C", Offset = "0x10F624C", VA = "0x10F624C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x10F62A4", Offset = "0x10F62A4", VA = "0x10F62A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x10F634C", Offset = "0x10F634C", VA = "0x10F634C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x10F68F8", Offset = "0x10F68F8", VA = "0x10F68F8")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
}
