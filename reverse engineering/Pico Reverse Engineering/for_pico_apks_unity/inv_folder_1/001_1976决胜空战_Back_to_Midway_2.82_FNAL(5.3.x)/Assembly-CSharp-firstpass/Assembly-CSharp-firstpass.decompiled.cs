using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using AOT;
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
	[Address(RVA = "0x7136B4", Offset = "0x7136B4", VA = "0x7136B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x713798", Offset = "0x713798", VA = "0x713798")]
	private void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x7138BC", Offset = "0x7138BC", VA = "0x7138BC")]
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
	[Address(RVA = "0x71395C", Offset = "0x71395C", VA = "0x71395C")]
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
	[Address(RVA = "0x7139E4", Offset = "0x7139E4", VA = "0x7139E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x713A58", Offset = "0x713A58", VA = "0x713A58")]
	private void AddListener()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x71429C", Offset = "0x71429C", VA = "0x71429C")]
	private void RemoveListener()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x7146A0", Offset = "0x7146A0", VA = "0x7146A0")]
	private void HandleOnStartAppear(InterfaceAnimManager _IAM)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x71475C", Offset = "0x71475C", VA = "0x71475C")]
	private void HandleOnStartDisappear(InterfaceAnimManager _IAM)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x714818", Offset = "0x714818", VA = "0x714818")]
	private void HandleOnEndAppear(InterfaceAnimManager _IAM)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x7148D4", Offset = "0x7148D4", VA = "0x7148D4")]
	private void HandleOnEndDisappear(InterfaceAnimManager _IAM)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x714990", Offset = "0x714990", VA = "0x714990")]
	public ExampleListener()
	{
	}
}
[Token(Token = "0x2000005")]
[AddComponentMenu("Excelsior/CSFHI/Example UI")]
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
	[Address(RVA = "0x714998", Offset = "0x714998", VA = "0x714998")]
	private void Start()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x714B60", Offset = "0x714B60", VA = "0x714B60")]
	private void playSound()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x714BF4", Offset = "0x714BF4", VA = "0x714BF4")]
	public void DoOutFullscreen()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x714C20", Offset = "0x714C20", VA = "0x714C20")]
	public void DoChangeEnvironment()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x7150D0", Offset = "0x7150D0", VA = "0x7150D0")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mod)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x71517C", Offset = "0x71517C", VA = "0x71517C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x714CEC", Offset = "0x714CEC", VA = "0x714CEC")]
	private void InitCam()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x715228", Offset = "0x715228", VA = "0x715228")]
	public void Update()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x715254", Offset = "0x715254", VA = "0x715254")]
	public void DoSwitchAutoCam()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x715290", Offset = "0x715290", VA = "0x715290")]
	public void DoSwitchCameraEffects()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x7154AC", Offset = "0x7154AC", VA = "0x7154AC")]
	public void DoSwitchAnimDelays()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x7155E0", Offset = "0x7155E0", VA = "0x7155E0")]
	public void DoAppear()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x715684", Offset = "0x715684", VA = "0x715684")]
	public void DoDisappear()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x715708", Offset = "0x715708", VA = "0x715708")]
	public void DoNext()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x715770", Offset = "0x715770", VA = "0x715770")]
	public void DoPrevious()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x714A54", Offset = "0x714A54", VA = "0x714A54")]
	private void CallInterface(InterfaceAnimManager _interface)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x7157D8", Offset = "0x7157D8", VA = "0x7157D8")]
	public void UpdateDisplayedInfo()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x7158A0", Offset = "0x7158A0", VA = "0x7158A0")]
	public ExampleUI()
	{
	}
}
[Token(Token = "0x2000006")]
[AddComponentMenu("Excelsior/ExcelsiorUtils")]
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
	[Address(RVA = "0x7159C4", Offset = "0x7159C4", VA = "0x7159C4")]
	private void playSound()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x715A60", Offset = "0x715A60", VA = "0x715A60")]
	public void SetPosition(int _scaleValue)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x715AF8", Offset = "0x715AF8", VA = "0x715AF8")]
	public void SetPositionAndScaleTo(GameObject _object)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x715BA4", Offset = "0x715BA4", VA = "0x715BA4")]
	public void SetUniformScale(int _scaleValue)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x715C3C", Offset = "0x715C3C", VA = "0x715C3C")]
	public void SetUniformWidthHeight(int _widthHeightValue)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x715D00", Offset = "0x715D00", VA = "0x715D00")]
	public void SetImageColor(int _colorID)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x716068", Offset = "0x716068", VA = "0x716068")]
	public void OpenWebPage()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x7160B8", Offset = "0x7160B8", VA = "0x7160B8")]
	public void GetSliderValue_ToText()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x716120", Offset = "0x716120", VA = "0x716120")]
	public ExcelsiorUtils()
	{
	}
}
[Token(Token = "0x2000007")]
[AddComponentMenu("Excelsior/CSFHI/Interface Animation Manager")]
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
	[CompilerGenerated]
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
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x719B20", Offset = "0x719B20", VA = "0x719B20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x719B68", Offset = "0x719B68", VA = "0x719B68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x7189F8", Offset = "0x7189F8", VA = "0x7189F8")]
		[DebuggerHidden]
		public <Disable_OnDisappearEnd>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x71967C", Offset = "0x71967C", VA = "0x71967C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x719680", Offset = "0x719680", VA = "0x719680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x719B28", Offset = "0x719B28", VA = "0x719B28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
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
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x713CFC", Offset = "0x713CFC", VA = "0x713CFC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x714430", Offset = "0x714430", VA = "0x714430")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event IAM_StartDisappear OnStartDisappear
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x713EA8", Offset = "0x713EA8", VA = "0x713EA8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x7144CC", Offset = "0x7144CC", VA = "0x7144CC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event IAM_EndAppear OnEndAppear
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x714054", Offset = "0x714054", VA = "0x714054")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x714568", Offset = "0x714568", VA = "0x714568")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event IAM_EndDisappear OnEndDisappear
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x714200", Offset = "0x714200", VA = "0x714200")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x714604", Offset = "0x714604", VA = "0x714604")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x716178", Offset = "0x716178", VA = "0x716178")]
	private void Awake()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x716254", Offset = "0x716254", VA = "0x716254")]
	private void Start()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x717214", Offset = "0x717214", VA = "0x717214")]
	private void Update()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x71854C", Offset = "0x71854C", VA = "0x71854C")]
	[IteratorStateMachine(typeof(<Disable_OnDisappearEnd>d__35))]
	public IEnumerator Disable_OnDisappearEnd()
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x718A20", Offset = "0x718A20", VA = "0x718A20", Slot = "4")]
	public virtual void startAppear(bool _direct = false)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x718384", Offset = "0x718384", VA = "0x718384")]
	private void EndAppear()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x718E84", Offset = "0x718E84", VA = "0x718E84", Slot = "5")]
	public virtual void startDisappear(bool _direct = false)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x7185C0", Offset = "0x7185C0", VA = "0x7185C0")]
	private void EndDisappear()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x7162AC", Offset = "0x7162AC", VA = "0x7162AC")]
	public void UpdateAnimClips()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x7190CC", Offset = "0x7190CC", VA = "0x7190CC")]
	public bool isIAM_Root()
	{
		return default(bool);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x719570", Offset = "0x719570", VA = "0x719570")]
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

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x7191BC", Offset = "0x7191BC", VA = "0x7191BC")]
	public static InterfaceAnmElement Create(GameObject _gameObjectRef, int _newSortID, bool _isNested_IAM)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x719C00", Offset = "0x719C00", VA = "0x719C00", Slot = "4")]
	public virtual InterfaceAnmElement Confirm(GameObject _gameObjectRef, int _newSortID, bool isNested_IAM)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x719430", Offset = "0x719430", VA = "0x719430")]
	public void UpdateProperties()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x719D98", Offset = "0x719D98", VA = "0x719D98", Slot = "5")]
	public virtual void Delete()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x719DD8", Offset = "0x719DD8", VA = "0x719DD8")]
	public void Update()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x719E90", Offset = "0x719E90", VA = "0x719E90")]
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

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x719F40", Offset = "0x719F40", VA = "0x719F40")]
	private void Start()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x71A00C", Offset = "0x71A00C", VA = "0x71A00C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x71A388", Offset = "0x71A388", VA = "0x71A388")]
	public static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x71A3C4", Offset = "0x71A3C4", VA = "0x71A3C4")]
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

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x71A3E0", Offset = "0x71A3E0", VA = "0x71A3E0")]
	public FMODAsset()
	{
	}
}
[Token(Token = "0x2000012")]
[AddComponentMenu("")]
public class FMOD_Listener : MonoBehaviour
{
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("This component is obsolete. Use FMODUnity.StudioListener instead")]
	public string[] pluginPaths;

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x71A3E8", Offset = "0x71A3E8", VA = "0x71A3E8")]
	public FMOD_Listener()
	{
	}
}
[Token(Token = "0x2000013")]
[AddComponentMenu("")]
public class FMOD_StudioEventEmitter : MonoBehaviour
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("This component is obsolete. Use FMODUnity.StudioEventEmitter instead")]
	public FMODAsset asset;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string path;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool startEventOnAwake;

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x71A44C", Offset = "0x71A44C", VA = "0x71A44C")]
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

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float eventLength;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private FMODEventPlayableBehavior behavior;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[EventRef]
	[SerializeField]
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

	[Token(Token = "0x17000003")]
	public GameObject TrackTargetObject
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x71A4AC", Offset = "0x71A4AC", VA = "0x71A4AC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x71A4B4", Offset = "0x71A4B4", VA = "0x71A4B4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public override double duration
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x71A4BC", Offset = "0x71A4BC", VA = "0x71A4BC", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000005")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x71A4D8", Offset = "0x71A4D8", VA = "0x71A4D8", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x17000006")]
	public TimelineClip OwningClip
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x71A4E0", Offset = "0x71A4E0", VA = "0x71A4E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x71A4E8", Offset = "0x71A4E8", VA = "0x71A4E8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x71A4F0", Offset = "0x71A4F0", VA = "0x71A4F0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x71AB18", Offset = "0x71AB18", VA = "0x71AB18")]
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

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x71AC1C", Offset = "0x71AC1C", VA = "0x71AC1C")]
	protected void PlayEvent()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x71B4E4", Offset = "0x71B4E4", VA = "0x71B4E4")]
	public void OnEnter()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x71B508", Offset = "0x71B508", VA = "0x71B508")]
	public void OnExit()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x71B598", Offset = "0x71B598", VA = "0x71B598")]
	public void UpdateBehaviour(float time)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x71B604", Offset = "0x71B604", VA = "0x71B604", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x71ABB8", Offset = "0x71ABB8", VA = "0x71ABB8")]
	public FMODEventPlayableBehavior()
	{
	}
}
[Token(Token = "0x2000017")]
[TrackClipType(typeof(FMODEventPlayable))]
[TrackColor(0.066f, 0.134f, 0.244f)]
[TrackBindingType(typeof(GameObject))]
public class FMODEventTrack : TrackAsset
{
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x71B694", Offset = "0x71B694", VA = "0x71B694", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x71BB28", Offset = "0x71BB28", VA = "0x71BB28")]
	public FMODEventTrack()
	{
	}
}
[Token(Token = "0x2000018")]
public class FMODEventMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x71BB80", Offset = "0x71BB80", VA = "0x71BB80", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x71BD2C", Offset = "0x71BD2C", VA = "0x71BD2C")]
	public FMODEventMixerBehaviour()
	{
	}
}
namespace FMOD
{
	[Token(Token = "0x2000019")]
	internal static class Android
	{
		[Token(Token = "0x200001A")]
		public struct THREADAFFINITY
		{
			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public THREAD mixer;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public THREAD stream;

			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public THREAD nonblocking;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public THREAD file;

			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public THREAD geometry;

			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public THREAD profiler;

			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public THREAD studioUpdate;

			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public THREAD studioLoadBank;

			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public THREAD studioLoadSample;
		}

		[Token(Token = "0x200001B")]
		[Flags]
		public enum THREAD : uint
		{
			[Token(Token = "0x4000074")]
			DEFAULT = 0u,
			[Token(Token = "0x4000075")]
			CORE0 = 1u,
			[Token(Token = "0x4000076")]
			CORE1 = 2u,
			[Token(Token = "0x4000077")]
			CORE2 = 4u,
			[Token(Token = "0x4000078")]
			CORE3 = 8u,
			[Token(Token = "0x4000079")]
			CORE4 = 0x10u,
			[Token(Token = "0x400007A")]
			CORE5 = 0x20u,
			[Token(Token = "0x400007B")]
			CORE6 = 0x40u,
			[Token(Token = "0x400007C")]
			CORE7 = 0x80u
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x71BD34", Offset = "0x71BD34", VA = "0x71BD34")]
		public static RESULT setThreadAffinity(ref THREADAFFINITY affinity)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x71BD38", Offset = "0x71BD38", VA = "0x71BD38")]
		private static extern RESULT FMOD_Android_SetThreadAffinity(ref THREADAFFINITY affinity);
	}
	[Token(Token = "0x200001C")]
	public enum RESULT
	{
		[Token(Token = "0x400007E")]
		OK,
		[Token(Token = "0x400007F")]
		ERR_BADCOMMAND,
		[Token(Token = "0x4000080")]
		ERR_CHANNEL_ALLOC,
		[Token(Token = "0x4000081")]
		ERR_CHANNEL_STOLEN,
		[Token(Token = "0x4000082")]
		ERR_DMA,
		[Token(Token = "0x4000083")]
		ERR_DSP_CONNECTION,
		[Token(Token = "0x4000084")]
		ERR_DSP_DONTPROCESS,
		[Token(Token = "0x4000085")]
		ERR_DSP_FORMAT,
		[Token(Token = "0x4000086")]
		ERR_DSP_INUSE,
		[Token(Token = "0x4000087")]
		ERR_DSP_NOTFOUND,
		[Token(Token = "0x4000088")]
		ERR_DSP_RESERVED,
		[Token(Token = "0x4000089")]
		ERR_DSP_SILENCE,
		[Token(Token = "0x400008A")]
		ERR_DSP_TYPE,
		[Token(Token = "0x400008B")]
		ERR_FILE_BAD,
		[Token(Token = "0x400008C")]
		ERR_FILE_COULDNOTSEEK,
		[Token(Token = "0x400008D")]
		ERR_FILE_DISKEJECTED,
		[Token(Token = "0x400008E")]
		ERR_FILE_EOF,
		[Token(Token = "0x400008F")]
		ERR_FILE_ENDOFDATA,
		[Token(Token = "0x4000090")]
		ERR_FILE_NOTFOUND,
		[Token(Token = "0x4000091")]
		ERR_FORMAT,
		[Token(Token = "0x4000092")]
		ERR_HEADER_MISMATCH,
		[Token(Token = "0x4000093")]
		ERR_HTTP,
		[Token(Token = "0x4000094")]
		ERR_HTTP_ACCESS,
		[Token(Token = "0x4000095")]
		ERR_HTTP_PROXY_AUTH,
		[Token(Token = "0x4000096")]
		ERR_HTTP_SERVER_ERROR,
		[Token(Token = "0x4000097")]
		ERR_HTTP_TIMEOUT,
		[Token(Token = "0x4000098")]
		ERR_INITIALIZATION,
		[Token(Token = "0x4000099")]
		ERR_INITIALIZED,
		[Token(Token = "0x400009A")]
		ERR_INTERNAL,
		[Token(Token = "0x400009B")]
		ERR_INVALID_FLOAT,
		[Token(Token = "0x400009C")]
		ERR_INVALID_HANDLE,
		[Token(Token = "0x400009D")]
		ERR_INVALID_PARAM,
		[Token(Token = "0x400009E")]
		ERR_INVALID_POSITION,
		[Token(Token = "0x400009F")]
		ERR_INVALID_SPEAKER,
		[Token(Token = "0x40000A0")]
		ERR_INVALID_SYNCPOINT,
		[Token(Token = "0x40000A1")]
		ERR_INVALID_THREAD,
		[Token(Token = "0x40000A2")]
		ERR_INVALID_VECTOR,
		[Token(Token = "0x40000A3")]
		ERR_MAXAUDIBLE,
		[Token(Token = "0x40000A4")]
		ERR_MEMORY,
		[Token(Token = "0x40000A5")]
		ERR_MEMORY_CANTPOINT,
		[Token(Token = "0x40000A6")]
		ERR_NEEDS3D,
		[Token(Token = "0x40000A7")]
		ERR_NEEDSHARDWARE,
		[Token(Token = "0x40000A8")]
		ERR_NET_CONNECT,
		[Token(Token = "0x40000A9")]
		ERR_NET_SOCKET_ERROR,
		[Token(Token = "0x40000AA")]
		ERR_NET_URL,
		[Token(Token = "0x40000AB")]
		ERR_NET_WOULD_BLOCK,
		[Token(Token = "0x40000AC")]
		ERR_NOTREADY,
		[Token(Token = "0x40000AD")]
		ERR_OUTPUT_ALLOCATED,
		[Token(Token = "0x40000AE")]
		ERR_OUTPUT_CREATEBUFFER,
		[Token(Token = "0x40000AF")]
		ERR_OUTPUT_DRIVERCALL,
		[Token(Token = "0x40000B0")]
		ERR_OUTPUT_FORMAT,
		[Token(Token = "0x40000B1")]
		ERR_OUTPUT_INIT,
		[Token(Token = "0x40000B2")]
		ERR_OUTPUT_NODRIVERS,
		[Token(Token = "0x40000B3")]
		ERR_PLUGIN,
		[Token(Token = "0x40000B4")]
		ERR_PLUGIN_MISSING,
		[Token(Token = "0x40000B5")]
		ERR_PLUGIN_RESOURCE,
		[Token(Token = "0x40000B6")]
		ERR_PLUGIN_VERSION,
		[Token(Token = "0x40000B7")]
		ERR_RECORD,
		[Token(Token = "0x40000B8")]
		ERR_REVERB_CHANNELGROUP,
		[Token(Token = "0x40000B9")]
		ERR_REVERB_INSTANCE,
		[Token(Token = "0x40000BA")]
		ERR_SUBSOUNDS,
		[Token(Token = "0x40000BB")]
		ERR_SUBSOUND_ALLOCATED,
		[Token(Token = "0x40000BC")]
		ERR_SUBSOUND_CANTMOVE,
		[Token(Token = "0x40000BD")]
		ERR_TAGNOTFOUND,
		[Token(Token = "0x40000BE")]
		ERR_TOOMANYCHANNELS,
		[Token(Token = "0x40000BF")]
		ERR_TRUNCATED,
		[Token(Token = "0x40000C0")]
		ERR_UNIMPLEMENTED,
		[Token(Token = "0x40000C1")]
		ERR_UNINITIALIZED,
		[Token(Token = "0x40000C2")]
		ERR_UNSUPPORTED,
		[Token(Token = "0x40000C3")]
		ERR_VERSION,
		[Token(Token = "0x40000C4")]
		ERR_EVENT_ALREADY_LOADED,
		[Token(Token = "0x40000C5")]
		ERR_EVENT_LIVEUPDATE_BUSY,
		[Token(Token = "0x40000C6")]
		ERR_EVENT_LIVEUPDATE_MISMATCH,
		[Token(Token = "0x40000C7")]
		ERR_EVENT_LIVEUPDATE_TIMEOUT,
		[Token(Token = "0x40000C8")]
		ERR_EVENT_NOTFOUND,
		[Token(Token = "0x40000C9")]
		ERR_STUDIO_UNINITIALIZED,
		[Token(Token = "0x40000CA")]
		ERR_STUDIO_NOT_LOADED,
		[Token(Token = "0x40000CB")]
		ERR_INVALID_STRING,
		[Token(Token = "0x40000CC")]
		ERR_ALREADY_LOCKED,
		[Token(Token = "0x40000CD")]
		ERR_NOT_LOCKED,
		[Token(Token = "0x40000CE")]
		ERR_RECORD_DISCONNECTED,
		[Token(Token = "0x40000CF")]
		ERR_TOOMANYSAMPLES
	}
	[Token(Token = "0x200001D")]
	public struct VECTOR
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;
	}
	[Token(Token = "0x200001E")]
	public struct ATTRIBUTES_3D
	{
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VECTOR position;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VECTOR velocity;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VECTOR forward;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public VECTOR up;
	}
	[Token(Token = "0x200001F")]
	public enum OUTPUTTYPE
	{
		[Token(Token = "0x40000D8")]
		AUTODETECT,
		[Token(Token = "0x40000D9")]
		UNKNOWN,
		[Token(Token = "0x40000DA")]
		NOSOUND,
		[Token(Token = "0x40000DB")]
		WAVWRITER,
		[Token(Token = "0x40000DC")]
		NOSOUND_NRT,
		[Token(Token = "0x40000DD")]
		WAVWRITER_NRT,
		[Token(Token = "0x40000DE")]
		WASAPI,
		[Token(Token = "0x40000DF")]
		ASIO,
		[Token(Token = "0x40000E0")]
		PULSEAUDIO,
		[Token(Token = "0x40000E1")]
		ALSA,
		[Token(Token = "0x40000E2")]
		COREAUDIO,
		[Token(Token = "0x40000E3")]
		AUDIOTRACK,
		[Token(Token = "0x40000E4")]
		OPENSL,
		[Token(Token = "0x40000E5")]
		AUDIOOUT,
		[Token(Token = "0x40000E6")]
		AUDIO3D,
		[Token(Token = "0x40000E7")]
		WEBAUDIO,
		[Token(Token = "0x40000E8")]
		NNAUDIO,
		[Token(Token = "0x40000E9")]
		WINSONIC,
		[Token(Token = "0x40000EA")]
		AAUDIO,
		[Token(Token = "0x40000EB")]
		MAX
	}
	[Token(Token = "0x2000020")]
	[Flags]
	public enum DEBUG_FLAGS : uint
	{
		[Token(Token = "0x40000ED")]
		NONE = 0u,
		[Token(Token = "0x40000EE")]
		ERROR = 1u,
		[Token(Token = "0x40000EF")]
		WARNING = 2u,
		[Token(Token = "0x40000F0")]
		LOG = 4u,
		[Token(Token = "0x40000F1")]
		TYPE_MEMORY = 0x100u,
		[Token(Token = "0x40000F2")]
		TYPE_FILE = 0x200u,
		[Token(Token = "0x40000F3")]
		TYPE_CODEC = 0x400u,
		[Token(Token = "0x40000F4")]
		TYPE_TRACE = 0x800u,
		[Token(Token = "0x40000F5")]
		DISPLAY_TIMESTAMPS = 0x10000u,
		[Token(Token = "0x40000F6")]
		DISPLAY_LINENUMBERS = 0x20000u,
		[Token(Token = "0x40000F7")]
		DISPLAY_THREAD = 0x40000u
	}
	[Token(Token = "0x2000021")]
	public enum SPEAKERMODE
	{
		[Token(Token = "0x40000F9")]
		DEFAULT,
		[Token(Token = "0x40000FA")]
		RAW,
		[Token(Token = "0x40000FB")]
		MONO,
		[Token(Token = "0x40000FC")]
		STEREO,
		[Token(Token = "0x40000FD")]
		QUAD,
		[Token(Token = "0x40000FE")]
		SURROUND,
		[Token(Token = "0x40000FF")]
		_5POINT1,
		[Token(Token = "0x4000100")]
		_7POINT1,
		[Token(Token = "0x4000101")]
		_7POINT1POINT4,
		[Token(Token = "0x4000102")]
		MAX
	}
	[Token(Token = "0x2000022")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x4000104")]
		NORMAL = 0u,
		[Token(Token = "0x4000105")]
		STREAM_FROM_UPDATE = 1u,
		[Token(Token = "0x4000106")]
		MIX_FROM_UPDATE = 2u,
		[Token(Token = "0x4000107")]
		_3D_RIGHTHANDED = 4u,
		[Token(Token = "0x4000108")]
		CHANNEL_LOWPASS = 0x100u,
		[Token(Token = "0x4000109")]
		CHANNEL_DISTANCEFILTER = 0x200u,
		[Token(Token = "0x400010A")]
		PROFILE_ENABLE = 0x10000u,
		[Token(Token = "0x400010B")]
		VOL0_BECOMES_VIRTUAL = 0x20000u,
		[Token(Token = "0x400010C")]
		GEOMETRY_USECLOSEST = 0x40000u,
		[Token(Token = "0x400010D")]
		PREFER_DOLBY_DOWNMIX = 0x80000u,
		[Token(Token = "0x400010E")]
		THREAD_UNSAFE = 0x100000u,
		[Token(Token = "0x400010F")]
		PROFILE_METER_ALL = 0x200000u,
		[Token(Token = "0x4000110")]
		MEMORY_TRACKING = 0x400000u
	}
	[Token(Token = "0x2000023")]
	public delegate RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message);
	[Token(Token = "0x2000024")]
	public enum DSP_RESAMPLER
	{
		[Token(Token = "0x4000112")]
		DEFAULT,
		[Token(Token = "0x4000113")]
		NOINTERP,
		[Token(Token = "0x4000114")]
		LINEAR,
		[Token(Token = "0x4000115")]
		CUBIC,
		[Token(Token = "0x4000116")]
		SPLINE,
		[Token(Token = "0x4000117")]
		MAX
	}
	[Token(Token = "0x2000025")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbSize;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int maxMPEGCodecs;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int maxADPCMCodecs;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int maxXMACodecs;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int maxVorbisCodecs;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int maxAT9Codecs;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int maxFADPCMCodecs;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int maxPCMCodecs;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int ASIONumChannels;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr ASIOChannelList;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr ASIOSpeakerList;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float vol0virtualvol;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public uint defaultDecodeBufferSize;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ushort profilePort;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint geometryMaxFadeTime;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float distanceFilterCenterFreq;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int reverb3Dinstance;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int DSPBufferPoolSize;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public uint stackSizeStream;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public uint stackSizeNonBlocking;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public uint stackSizeMixer;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_RESAMPLER resamplerMethod;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public uint commandQueueSize;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public uint randomSeed;
	}
	[Token(Token = "0x2000026")]
	public struct Memory
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x71BE78", Offset = "0x71BE78", VA = "0x71BE78")]
		public static RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking = true)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x71BE80", Offset = "0x71BE80", VA = "0x71BE80")]
		private static extern RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking);
	}
	[Token(Token = "0x2000027")]
	public struct System
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x71BF14", Offset = "0x71BF14", VA = "0x71BF14")]
		public RESULT setOutput(OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x71BFA0", Offset = "0x71BFA0", VA = "0x71BFA0")]
		public RESULT setSoftwareChannels(int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x71C02C", Offset = "0x71C02C", VA = "0x71C02C")]
		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x71C0D0", Offset = "0x71C0D0", VA = "0x71C0D0")]
		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x71C20C", Offset = "0x71C20C", VA = "0x71C20C")]
		public RESULT loadPlugin(string filename, out uint handle, uint priority = 0u)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x71C8AC", Offset = "0x71C8AC", VA = "0x71C8AC")]
		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x71C968", Offset = "0x71C968", VA = "0x71C968")]
		public RESULT mixerSuspend()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x71C9EC", Offset = "0x71C9EC", VA = "0x71C9EC")]
		public RESULT mixerResume()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x71CA70", Offset = "0x71CA70", VA = "0x71CA70")]
		public RESULT getChannelsPlaying(out int channels, out int realchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x71CB0C", Offset = "0x71CB0C", VA = "0x71CB0C")]
		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x71BF1C", Offset = "0x71BF1C", VA = "0x71BF1C")]
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x71BFA8", Offset = "0x71BFA8", VA = "0x71BFA8")]
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x71C034", Offset = "0x71C034", VA = "0x71C034")]
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x71C188", Offset = "0x71C188", VA = "0x71C188")]
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x71C808", Offset = "0x71C808", VA = "0x71C808")]
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority);

		[PreserveSig]
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x71C8B4", Offset = "0x71C8B4", VA = "0x71C8B4")]
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x71C970", Offset = "0x71C970", VA = "0x71C970")]
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x71C9F4", Offset = "0x71C9F4", VA = "0x71C9F4")]
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x71CA78", Offset = "0x71CA78", VA = "0x71CA78")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels);

		[PreserveSig]
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x71CB14", Offset = "0x71CB14", VA = "0x71CB14")]
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup);
	}
	[Token(Token = "0x2000028")]
	public struct ChannelGroup
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x71CB98", Offset = "0x71CB98", VA = "0x71CB98", Slot = "4")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x71CC34", Offset = "0x71CC34", VA = "0x71CC34", Slot = "5")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x71CBA0", Offset = "0x71CBA0", VA = "0x71CBA0")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x71CC3C", Offset = "0x71CC3C", VA = "0x71CC3C")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps);

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x71CCC0", Offset = "0x71CCC0", VA = "0x71CCC0")]
		public bool hasHandle()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000029")]
	public struct DSP
	{
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x71CD04", Offset = "0x71CD04", VA = "0x71CD04")]
		public RESULT setParameterData(int index, byte[] data)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x71CE40", Offset = "0x71CE40", VA = "0x71CE40")]
		public RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x71D394", Offset = "0x71D394", VA = "0x71D394")]
		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x71D438", Offset = "0x71D438", VA = "0x71D438")]
		public RESULT getMeteringInfo(IntPtr zero, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x71CDA4", Offset = "0x71CDA4", VA = "0x71CDA4")]
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, IntPtr data, uint length);

		[PreserveSig]
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x71D08C", Offset = "0x71D08C", VA = "0x71D08C")]
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight);

		[PreserveSig]
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x71D3A4", Offset = "0x71D3A4", VA = "0x71D3A4")]
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x71D440", Offset = "0x71D440", VA = "0x71D440")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, IntPtr zero, out DSP_METERING_INFO outputInfo);

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x71D51C", Offset = "0x71D51C", VA = "0x71D51C")]
		public bool hasHandle()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002A")]
	public struct StringWrapper
	{
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr nativeUtf8Ptr;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x71D560", Offset = "0x71D560", VA = "0x71D560")]
		public static implicit operator string(StringWrapper fstring)
		{
			return null;
		}
	}
	[Token(Token = "0x200002B")]
	internal static class StringHelper
	{
		[Token(Token = "0x200002C")]
		public class ThreadSafeEncoding : IDisposable
		{
			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UTF8Encoding encoding;

			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private byte[] encodedBuffer;

			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private char[] decodedBuffer;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool inUse;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GCHandle gcHandle;

			[Token(Token = "0x6000099")]
			[Address(RVA = "0x71D88C", Offset = "0x71D88C", VA = "0x71D88C")]
			public bool InUse()
			{
				return default(bool);
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x71D7E4", Offset = "0x71D7E4", VA = "0x71D7E4")]
			public void SetInUse()
			{
			}

			[Token(Token = "0x600009B")]
			[Address(RVA = "0x71D894", Offset = "0x71D894", VA = "0x71D894")]
			private int roundUpPowerTwo(int number)
			{
				return default(int);
			}

			[Token(Token = "0x600009C")]
			[Address(RVA = "0x71C6D0", Offset = "0x71C6D0", VA = "0x71C6D0")]
			public byte[] byteFromStringUTF8(string s)
			{
				return null;
			}

			[Token(Token = "0x600009D")]
			[Address(RVA = "0x71D8AC", Offset = "0x71D8AC", VA = "0x71D8AC")]
			public IntPtr intptrFromStringUTF8(string s)
			{
				return default(IntPtr);
			}

			[Token(Token = "0x600009E")]
			[Address(RVA = "0x71D140", Offset = "0x71D140", VA = "0x71D140")]
			public string stringFromNative(IntPtr nativePtr)
			{
				return null;
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0x71D920", Offset = "0x71D920", VA = "0x71D920", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x71D708", Offset = "0x71D708", VA = "0x71D708")]
			public ThreadSafeEncoding()
			{
			}
		}

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ThreadSafeEncoding> encoders;

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x71C3E4", Offset = "0x71C3E4", VA = "0x71C3E4")]
		public static ThreadSafeEncoding GetFreeHelper()
		{
			return null;
		}
	}
	[Token(Token = "0x200002D")]
	public struct DSP_METERING_INFO
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numsamples;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] peaklevel;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] rmslevel;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public short numchannels;
	}
	[Token(Token = "0x200002E")]
	public class Error
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x71DA3C", Offset = "0x71DA3C", VA = "0x71DA3C")]
		public static string String(RESULT errcode)
		{
			return null;
		}
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
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x71DE70", Offset = "0x71DE70", VA = "0x71DE70")]
		public static RESULT parseID(string idString, out Guid id)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x71E028", Offset = "0x71E028", VA = "0x71E028")]
		private static extern RESULT FMOD_Studio_ParseID(byte[] idString, out Guid id);
	}
	[Token(Token = "0x200003D")]
	public struct System
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x71E0B4", Offset = "0x71E0B4", VA = "0x71E0B4")]
		public static RESULT create(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x71E144", Offset = "0x71E144", VA = "0x71E144")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x71E28C", Offset = "0x71E28C", VA = "0x71E28C")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings, string encryptionKey)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x71E470", Offset = "0x71E470", VA = "0x71E470")]
		public RESULT initialize(int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x71E524", Offset = "0x71E524", VA = "0x71E524")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x71B68C", Offset = "0x71B68C", VA = "0x71B68C")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x71E624", Offset = "0x71E624", VA = "0x71E624")]
		public RESULT getCoreSystem(out FMOD.System coresystem)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x71A788", Offset = "0x71A788", VA = "0x71A788")]
		public RESULT getEvent(string path, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x71E74C", Offset = "0x71E74C", VA = "0x71E74C")]
		public RESULT getBus(string path, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x71E9B0", Offset = "0x71E9B0", VA = "0x71E9B0")]
		public RESULT getVCA(string path, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x71EC14", Offset = "0x71EC14", VA = "0x71EC14")]
		public RESULT getEventByID(Guid id, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x71ECD0", Offset = "0x71ECD0", VA = "0x71ECD0")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x71EF34", Offset = "0x71EF34", VA = "0x71EF34")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x71F1B8", Offset = "0x71F1B8", VA = "0x71F1B8")]
		public RESULT lookupID(string path, out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x71F41C", Offset = "0x71F41C", VA = "0x71F41C")]
		public RESULT setNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x71F4A8", Offset = "0x71F4A8", VA = "0x71F4A8")]
		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x71F544", Offset = "0x71F544", VA = "0x71F544")]
		public RESULT loadBankFile(string filename, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x71F7C0", Offset = "0x71F7C0", VA = "0x71F7C0")]
		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x71F8F8", Offset = "0x71F8F8", VA = "0x71F8F8")]
		public RESULT flushCommands()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x71F97C", Offset = "0x71F97C", VA = "0x71F97C")]
		public RESULT flushSampleLoading()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x71FA00", Offset = "0x71FA00", VA = "0x71FA00")]
		public RESULT getBankCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x71FA8C", Offset = "0x71FA8C", VA = "0x71FA8C")]
		public RESULT getBankList(out Bank[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x71FC88", Offset = "0x71FC88", VA = "0x71FC88")]
		public RESULT getCPUUsage(out CPU_USAGE usage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x71E0C0", Offset = "0x71E0C0", VA = "0x71E0C0")]
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr system, uint headerversion);

		[PreserveSig]
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x71FD14", Offset = "0x71FD14", VA = "0x71FD14")]
		private static extern bool FMOD_Studio_System_IsValid(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x71E208", Offset = "0x71E208", VA = "0x71E208")]
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x71E478", Offset = "0x71E478", VA = "0x71E478")]
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr system, int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x71E52C", Offset = "0x71E52C", VA = "0x71E52C")]
		private static extern RESULT FMOD_Studio_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x71E5A8", Offset = "0x71E5A8", VA = "0x71E5A8")]
		private static extern RESULT FMOD_Studio_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x71E62C", Offset = "0x71E62C", VA = "0x71E62C")]
		private static extern RESULT FMOD_Studio_System_GetCoreSystem(IntPtr system, out IntPtr coresystem);

		[PreserveSig]
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x71E6B0", Offset = "0x71E6B0", VA = "0x71E6B0")]
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr system, byte[] path, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x71E914", Offset = "0x71E914", VA = "0x71E914")]
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr system, byte[] path, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x71EB78", Offset = "0x71EB78", VA = "0x71EB78")]
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr system, byte[] path, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x71EC3C", Offset = "0x71EC3C", VA = "0x71EC3C")]
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr system, ref Guid id, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x71EE98", Offset = "0x71EE98", VA = "0x71EE98")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByName(IntPtr system, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x71F10C", Offset = "0x71F10C", VA = "0x71F10C")]
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x71F380", Offset = "0x71F380", VA = "0x71F380")]
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr system, byte[] path, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x71F424", Offset = "0x71F424", VA = "0x71F424")]
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x71F4B0", Offset = "0x71F4B0", VA = "0x71F4B0")]
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr system, int listener, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x71F71C", Offset = "0x71F71C", VA = "0x71F71C")]
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr system, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x71F844", Offset = "0x71F844", VA = "0x71F844")]
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr system, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x71F900", Offset = "0x71F900", VA = "0x71F900")]
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x71F984", Offset = "0x71F984", VA = "0x71F984")]
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x71FA08", Offset = "0x71FA08", VA = "0x71FA08")]
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x71FBE4", Offset = "0x71FBE4", VA = "0x71FBE4")]
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr system, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x71FC90", Offset = "0x71FC90", VA = "0x71FC90")]
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr system, out CPU_USAGE usage);

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x71FD98", Offset = "0x71FD98", VA = "0x71FD98")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x71FDDC", Offset = "0x71FDDC", VA = "0x71FDDC")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x71FE18", Offset = "0x71FE18", VA = "0x71FE18")]
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

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x71A950", Offset = "0x71A950", VA = "0x71A950")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x71FEDC", Offset = "0x71FEDC", VA = "0x71FEDC")]
		public RESULT isOneshot(out bool oneshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x71FF7C", Offset = "0x71FF7C", VA = "0x71FF7C")]
		public RESULT is3D(out bool is3D)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x72001C", Offset = "0x72001C", VA = "0x72001C")]
		public RESULT createInstance(out EventInstance instance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x7200A8", Offset = "0x7200A8", VA = "0x7200A8")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x72012C", Offset = "0x72012C", VA = "0x72012C")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x7201B0", Offset = "0x7201B0", VA = "0x7201B0")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x72023C", Offset = "0x72023C", VA = "0x72023C")]
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x71FE40", Offset = "0x71FE40", VA = "0x71FE40")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x71FEE4", Offset = "0x71FEE4", VA = "0x71FEE4")]
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot);

		[PreserveSig]
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x71FF84", Offset = "0x71FF84", VA = "0x71FF84")]
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D);

		[PreserveSig]
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x720024", Offset = "0x720024", VA = "0x720024")]
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance);

		[PreserveSig]
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x7200B0", Offset = "0x7200B0", VA = "0x7200B0")]
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x720134", Offset = "0x720134", VA = "0x720134")]
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x7201B8", Offset = "0x7201B8", VA = "0x7201B8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state);

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x7202C0", Offset = "0x7202C0", VA = "0x7202C0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x720304", Offset = "0x720304", VA = "0x720304")]
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

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x71B4C8", Offset = "0x71B4C8", VA = "0x71B4C8")]
		public RESULT set3DAttributes(ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x7203B0", Offset = "0x7203B0", VA = "0x7203B0")]
		public RESULT setProperty(EVENT_PROPERTY index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x71B4DC", Offset = "0x71B4DC", VA = "0x71B4DC")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x71B588", Offset = "0x71B588", VA = "0x71B588")]
		public RESULT stop(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x72054C", Offset = "0x72054C", VA = "0x72054C")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x71B590", Offset = "0x71B590", VA = "0x71B590")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x71B4D0", Offset = "0x71B4D0", VA = "0x71B4D0")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x7206F8", Offset = "0x7206F8", VA = "0x7206F8")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x72097C", Offset = "0x72097C", VA = "0x72097C")]
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x72032C", Offset = "0x72032C", VA = "0x72032C")]
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x7203B8", Offset = "0x7203B8", VA = "0x7203B8")]
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value);

		[PreserveSig]
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x72044C", Offset = "0x72044C", VA = "0x72044C")]
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x7204C8", Offset = "0x7204C8", VA = "0x7204C8")]
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x720554", Offset = "0x720554", VA = "0x720554")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x7205D8", Offset = "0x7205D8", VA = "0x7205D8")]
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x7208D0", Offset = "0x7208D0", VA = "0x7208D0")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x720654", Offset = "0x720654", VA = "0x720654")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByID(IntPtr _event, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x720A00", Offset = "0x720A00", VA = "0x720A00")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x720A44", Offset = "0x720A44", VA = "0x720A44")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x71B560", Offset = "0x71B560", VA = "0x71B560")]
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

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x720A80", Offset = "0x720A80", VA = "0x720A80")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x720DD8", Offset = "0x720DD8", VA = "0x720DD8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x720E6C", Offset = "0x720E6C", VA = "0x720E6C")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x720EFC", Offset = "0x720EFC", VA = "0x720EFC")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x720F8C", Offset = "0x720F8C", VA = "0x720F8C")]
		public RESULT stopAllEvents(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x721018", Offset = "0x721018", VA = "0x721018")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x720D3C", Offset = "0x720D3C", VA = "0x720D3C")]
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x720DE0", Offset = "0x720DE0", VA = "0x720DE0")]
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float volume);

		[PreserveSig]
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x720E78", Offset = "0x720E78", VA = "0x720E78")]
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x720F08", Offset = "0x720F08", VA = "0x720F08")]
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute);

		[PreserveSig]
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x720F94", Offset = "0x720F94", VA = "0x720F94")]
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x721020", Offset = "0x721020", VA = "0x721020")]
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

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x7210A4", Offset = "0x7210A4", VA = "0x7210A4")]
		public RESULT unload()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x721128", Offset = "0x721128", VA = "0x721128")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x7211AC", Offset = "0x7211AC", VA = "0x7211AC")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x721238", Offset = "0x721238", VA = "0x721238")]
		public RESULT getBusCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x7212C4", Offset = "0x7212C4", VA = "0x7212C4")]
		public RESULT getBusList(out Bus[] array)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x7210AC", Offset = "0x7210AC", VA = "0x7210AC")]
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x721130", Offset = "0x721130", VA = "0x721130")]
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x7211B4", Offset = "0x7211B4", VA = "0x7211B4")]
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x721240", Offset = "0x721240", VA = "0x721240")]
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x72141C", Offset = "0x72141C", VA = "0x72141C")]
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count);
	}
}
namespace FMODUnity
{
	[Token(Token = "0x2000043")]
	public class BankRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x7214C0", Offset = "0x7214C0", VA = "0x7214C0")]
		public BankRefAttribute()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class EventRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x7214C8", Offset = "0x7214C8", VA = "0x7214C8")]
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

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x7214D0", Offset = "0x7214D0", VA = "0x7214D0")]
		public ParamRef()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AddComponentMenu("")]
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
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x727748", Offset = "0x727748", VA = "0x727748", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Guid>.Equals(Guid x, Guid y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000148")]
			[Address(RVA = "0x727778", Offset = "0x727778", VA = "0x727778", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Guid>.GetHashCode(Guid obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000149")]
			[Address(RVA = "0x727684", Offset = "0x727684", VA = "0x727684")]
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

			[Token(Token = "0x600014A")]
			[Address(RVA = "0x724568", Offset = "0x724568", VA = "0x724568")]
			public AttachedInstance()
			{
			}
		}

		[Token(Token = "0x200004C")]
		[CompilerGenerated]
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
				[Token(Token = "0x6000152")]
				[Address(RVA = "0x727AC8", Offset = "0x727AC8", VA = "0x727AC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000154")]
				[Address(RVA = "0x727B10", Offset = "0x727B10", VA = "0x727B10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600014F")]
			[Address(RVA = "0x7251D0", Offset = "0x7251D0", VA = "0x7251D0")]
			[DebuggerHidden]
			public <loadFromWeb>d__43(int <>1__state)
			{
			}

			[Token(Token = "0x6000150")]
			[Address(RVA = "0x7277E4", Offset = "0x7277E4", VA = "0x7277E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000151")]
			[Address(RVA = "0x7277E8", Offset = "0x7277E8", VA = "0x7277E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000153")]
			[Address(RVA = "0x727AD0", Offset = "0x727AD0", VA = "0x727AD0", Slot = "8")]
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
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x721650", Offset = "0x721650", VA = "0x721650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public static FMOD.Studio.System StudioSystem
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x71A72C", Offset = "0x71A72C", VA = "0x71A72C")]
			get
			{
				return default(FMOD.Studio.System);
			}
		}

		[Token(Token = "0x17000009")]
		public static FMOD.System CoreSystem
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x72299C", Offset = "0x72299C", VA = "0x72299C")]
			get
			{
				return default(FMOD.System);
			}
		}

		[Token(Token = "0x1700000A")]
		public static bool IsInitialized
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x72727C", Offset = "0x72727C", VA = "0x72727C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public static bool HasBanksLoaded
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x727148", Offset = "0x727148", VA = "0x727148")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x7214D8", Offset = "0x7214D8", VA = "0x7214D8")]
		[MonoPInvokeCallback(typeof(DEBUG_CALLBACK))]
		private static RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x7229F8", Offset = "0x7229F8", VA = "0x7229F8")]
		private void CheckInitResult(RESULT result, string cause)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x722300", Offset = "0x722300", VA = "0x722300")]
		private RESULT Initialize()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x7238F0", Offset = "0x7238F0", VA = "0x7238F0")]
		public static int AddListener(StudioListener listener)
		{
			return default(int);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x723CCC", Offset = "0x723CCC", VA = "0x723CCC")]
		public static bool RemoveListener(StudioListener listener)
		{
			return default(bool);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x723F48", Offset = "0x723F48", VA = "0x723F48")]
		private void Update()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x71AF80", Offset = "0x71AF80", VA = "0x71AF80")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x71B1B0", Offset = "0x71B1B0", VA = "0x71B1B0")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x724578", Offset = "0x724578", VA = "0x724578")]
		public static void DetachInstanceFromGameObject(EventInstance instance)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x724680", Offset = "0x724680", VA = "0x724680")]
		public void ExecuteOnGUI()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x7247A4", Offset = "0x7247A4", VA = "0x7247A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x724838", Offset = "0x724838", VA = "0x724838")]
		private void DrawDebugOverlay(int windowID)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x724C88", Offset = "0x724C88", VA = "0x724C88")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x724CEC", Offset = "0x724CEC", VA = "0x724CEC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x724DA4", Offset = "0x724DA4", VA = "0x724DA4")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x724EDC", Offset = "0x724EDC", VA = "0x724EDC")]
		private void loadedBankRegister(LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, RESULT loadResult)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x725118", Offset = "0x725118", VA = "0x725118")]
		[IteratorStateMachine(typeof(<loadFromWeb>d__43))]
		private IEnumerator loadFromWeb(string bankPath, string bankName, bool loadSamples)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x7251F8", Offset = "0x7251F8", VA = "0x7251F8")]
		public static void LoadBank(string bankName, bool loadSamples = false)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x725864", Offset = "0x725864", VA = "0x725864")]
		public static void LoadBank(TextAsset asset, bool loadSamples = false)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x723430", Offset = "0x723430", VA = "0x723430")]
		private void LoadBanks(Settings fmodSettings)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x725AEC", Offset = "0x725AEC", VA = "0x725AEC")]
		public static void UnloadBank(string bankName)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x725C24", Offset = "0x725C24", VA = "0x725C24")]
		public static bool AnyBankLoading()
		{
			return default(bool);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x725A90", Offset = "0x725A90", VA = "0x725A90")]
		public static void WaitForAllLoads()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x725DC8", Offset = "0x725DC8", VA = "0x725DC8")]
		public static Guid PathToGUID(string path)
		{
			return default(Guid);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x71AE74", Offset = "0x71AE74", VA = "0x71AE74")]
		public static EventInstance CreateInstance(string path)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x725FAC", Offset = "0x725FAC", VA = "0x725FAC")]
		public static EventInstance CreateInstance(Guid guid)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x72621C", Offset = "0x72621C", VA = "0x72621C")]
		public static void PlayOneShot(string path, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x726364", Offset = "0x726364", VA = "0x726364")]
		public static void PlayOneShot(Guid guid, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x726424", Offset = "0x726424", VA = "0x726424")]
		public static void PlayOneShotAttached(string path, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x726550", Offset = "0x726550", VA = "0x726550")]
		public static void PlayOneShotAttached(Guid guid, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x726614", Offset = "0x726614", VA = "0x726614")]
		public static EventDescription GetEventDescription(string path)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x726024", Offset = "0x726024", VA = "0x726024")]
		public static EventDescription GetEventDescription(Guid guid)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x7267F0", Offset = "0x7267F0", VA = "0x7267F0")]
		public static void SetListenerLocation(GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x7269A4", Offset = "0x7269A4", VA = "0x7269A4")]
		public static void SetListenerLocation(GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x726B64", Offset = "0x726B64", VA = "0x726B64")]
		public static void SetListenerLocation(Transform transform)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x726C90", Offset = "0x726C90", VA = "0x726C90")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x726D28", Offset = "0x726D28", VA = "0x726D28")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x726DC0", Offset = "0x726DC0", VA = "0x726DC0")]
		public static void SetListenerLocation(int listenerIndex, Transform transform)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x726E50", Offset = "0x726E50", VA = "0x726E50")]
		public static Bus GetBus(string path)
		{
			return default(Bus);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x726FCC", Offset = "0x726FCC", VA = "0x726FCC")]
		public static VCA GetVCA(string path)
		{
			return default(VCA);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x724E2C", Offset = "0x724E2C", VA = "0x724E2C")]
		public static void PauseAllEvents(bool paused)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x7271CC", Offset = "0x7271CC", VA = "0x7271CC")]
		public static void MuteAllEvents(bool muted)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x727348", Offset = "0x727348", VA = "0x727348")]
		public static bool HasBankLoaded(string loadedBank)
		{
			return default(bool);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x723220", Offset = "0x723220", VA = "0x723220")]
		private void LoadPlugins(Settings fmodSettings)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x72314C", Offset = "0x72314C", VA = "0x72314C")]
		private void SetThreadAffinity()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x727464", Offset = "0x727464", VA = "0x727464")]
		public RuntimeManager()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class EventNotFoundException : Exception
	{
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Guid Guid;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string Path;

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x725EE8", Offset = "0x725EE8", VA = "0x725EE8")]
		public EventNotFoundException(string path)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x726720", Offset = "0x726720", VA = "0x726720")]
		public EventNotFoundException(Guid guid)
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class BusNotFoundException : Exception
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Path;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x726F08", Offset = "0x726F08", VA = "0x726F08")]
		public BusNotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class VCANotFoundException : Exception
	{
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Path;

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x727084", Offset = "0x727084", VA = "0x727084")]
		public VCANotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class BankLoadException : Exception
	{
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Path;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public RESULT Result;

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x725010", Offset = "0x725010", VA = "0x725010")]
		public BankLoadException(string path, RESULT result)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x7257A4", Offset = "0x7257A4", VA = "0x7257A4")]
		public BankLoadException(string path, string error)
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class SystemNotInitializedException : Exception
	{
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public RESULT Result;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Location;

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x722894", Offset = "0x722894", VA = "0x722894")]
		public SystemNotInitializedException(RESULT result, string location)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x722814", Offset = "0x722814", VA = "0x722814")]
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
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x727B18", Offset = "0x727B18", VA = "0x727B18")]
		public static VECTOR ToFMODVector(this Vector3 vec)
		{
			return default(VECTOR);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x71B3F0", Offset = "0x71B3F0", VA = "0x71B3F0")]
		public static ATTRIBUTES_3D To3DAttributes(this Vector3 pos)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x726BE8", Offset = "0x726BE8", VA = "0x726BE8")]
		public static ATTRIBUTES_3D To3DAttributes(this Transform transform)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x72432C", Offset = "0x72432C", VA = "0x72432C")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x726884", Offset = "0x726884", VA = "0x726884")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x724440", Offset = "0x724440", VA = "0x724440")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x726A38", Offset = "0x726A38", VA = "0x726A38")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x722CAC", Offset = "0x722CAC", VA = "0x722CAC")]
		internal static FMODPlatform GetCurrentPlatform()
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x725640", Offset = "0x725640", VA = "0x725640")]
		internal static string GetBankPath(string bankName)
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x7273D0", Offset = "0x7273D0", VA = "0x7273D0")]
		internal static string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x722110", Offset = "0x722110", VA = "0x722110")]
		public static void EnforceLibraryOrder()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x721FD4", Offset = "0x721FD4", VA = "0x721FD4")]
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

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x727B1C", Offset = "0x727B1C", VA = "0x727B1C")]
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

		[Token(Token = "0x600016A")]
		public PlatformSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class PlatformIntSetting : PlatformSetting<int>
	{
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x727B24", Offset = "0x727B24", VA = "0x727B24")]
		public PlatformIntSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class PlatformStringSetting : PlatformSetting<string>
	{
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x727B6C", Offset = "0x727B6C", VA = "0x727B6C")]
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
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x727BB4", Offset = "0x727BB4", VA = "0x727BB4")]
		public PlatformBoolSetting()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class Settings : ScriptableObject
	{
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
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x722A8C", Offset = "0x722A8C", VA = "0x722A8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public string SourceProjectPath
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x727BFC", Offset = "0x727BFC", VA = "0x727BFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x727C04", Offset = "0x727C04", VA = "0x727C04")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public string SourceBankPath
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x727C0C", Offset = "0x727C0C", VA = "0x727C0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x727C14", Offset = "0x727C14", VA = "0x727C14")]
			set
			{
			}
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x727C1C", Offset = "0x727C1C", VA = "0x727C1C")]
		public static FMODPlatform GetParent(FMODPlatform platform)
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x6000174")]
		public static bool HasSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		public static U GetSetting<T, U>(List<T> list, FMODPlatform platform, U def) where T : PlatformSetting<U>
		{
			return (U)null;
		}

		[Token(Token = "0x6000176")]
		public static void SetSetting<T, U>(List<T> list, FMODPlatform platform, U value) where T : PlatformSetting<U>, new()
		{
		}

		[Token(Token = "0x6000177")]
		public static void RemoveSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x7231B8", Offset = "0x7231B8", VA = "0x7231B8")]
		public bool IsLiveUpdateEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x7247D0", Offset = "0x7247D0", VA = "0x7247D0")]
		public bool IsOverlayEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x723038", Offset = "0x723038", VA = "0x723038")]
		public int GetRealChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x723094", Offset = "0x723094", VA = "0x723094")]
		public int GetVirtualChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x7230F0", Offset = "0x7230F0", VA = "0x7230F0")]
		public int GetSpeakerMode(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x722FDC", Offset = "0x722FDC", VA = "0x722FDC")]
		public int GetSampleRate(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x727C40", Offset = "0x727C40", VA = "0x727C40")]
		public string GetBankPlatform(FMODPlatform platform)
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x727CD4", Offset = "0x727CD4", VA = "0x727CD4")]
		private Settings()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public abstract class EventHandler : MonoBehaviour
	{
		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string CollisionTag;

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x72811C", Offset = "0x72811C", VA = "0x72811C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x72812C", Offset = "0x72812C", VA = "0x72812C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x72813C", Offset = "0x72813C", VA = "0x72813C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x7281A0", Offset = "0x7281A0", VA = "0x7281A0")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x728204", Offset = "0x728204", VA = "0x728204")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x728268", Offset = "0x728268", VA = "0x728268")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x7282CC", Offset = "0x7282CC", VA = "0x7282CC")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x7282DC", Offset = "0x7282DC", VA = "0x7282DC")]
		private void OnCollisionExit()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x7282EC", Offset = "0x7282EC", VA = "0x7282EC")]
		private void OnCollisionEnter2D()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x7282FC", Offset = "0x7282FC", VA = "0x7282FC")]
		private void OnCollisionExit2D()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x72830C", Offset = "0x72830C", VA = "0x72830C")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x72831C", Offset = "0x72831C", VA = "0x72831C")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x72832C", Offset = "0x72832C", VA = "0x72832C")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x72833C", Offset = "0x72833C", VA = "0x72833C")]
		private void OnMouseUp()
		{
		}

		[Token(Token = "0x6000196")]
		protected abstract void HandleGameEvent(EmitterGameEvent gameEvent);

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x72834C", Offset = "0x72834C", VA = "0x72834C")]
		protected EventHandler()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class FMODRuntimeManagerOnGUIHelper : MonoBehaviour
	{
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RuntimeManager TargetRuntimeManager;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x7283A4", Offset = "0x7283A4", VA = "0x7283A4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x728420", Offset = "0x728420", VA = "0x728420")]
		public FMODRuntimeManagerOnGUIHelper()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class ParamRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x728428", Offset = "0x728428", VA = "0x728428")]
		public ParamRefAttribute()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AddComponentMenu("FMOD Studio/FMOD Studio Global Parameter Trigger")]
	public class StudioGlobalParameterTrigger : EventHandler
	{
		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ParamRef]
		public string parameter;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float value;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PARAMETER_DESCRIPTION parameterDescription;

		[Token(Token = "0x17000011")]
		public PARAMETER_DESCRIPTION ParameterDesctription
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x728430", Offset = "0x728430", VA = "0x728430")]
			get
			{
				return default(PARAMETER_DESCRIPTION);
			}
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x728444", Offset = "0x728444", VA = "0x728444")]
		private RESULT Lookup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x7284B8", Offset = "0x7284B8", VA = "0x7284B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x7284E8", Offset = "0x7284E8", VA = "0x7284E8", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x728504", Offset = "0x728504", VA = "0x728504")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x728510", Offset = "0x728510", VA = "0x728510")]
		public StudioGlobalParameterTrigger()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AddComponentMenu("FMOD Studio/FMOD Studio Bank Loader")]
	public class StudioBankLoader : MonoBehaviour
	{
		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LoaderGameEvent LoadEvent;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LoaderGameEvent UnloadEvent;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[BankRef]
		public List<string> Banks;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string CollisionTag;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool PreloadSamples;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isQuitting;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x728514", Offset = "0x728514", VA = "0x728514")]
		private void HandleGameEvent(LoaderGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x728914", Offset = "0x728914", VA = "0x728914")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x728930", Offset = "0x728930", VA = "0x728930")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x72893C", Offset = "0x72893C", VA = "0x72893C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x728950", Offset = "0x728950", VA = "0x728950")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x7289AC", Offset = "0x7289AC", VA = "0x7289AC")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x728A08", Offset = "0x728A08", VA = "0x728A08")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x728A64", Offset = "0x728A64", VA = "0x728A64")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x728560", Offset = "0x728560", VA = "0x728560")]
		public void Load()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x7287B8", Offset = "0x7287B8", VA = "0x7287B8")]
		public void Unload()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x728AC0", Offset = "0x728AC0", VA = "0x728AC0")]
		public StudioBankLoader()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AddComponentMenu("FMOD Studio/FMOD Studio Event Emitter")]
	public class StudioEventEmitter : EventHandler
	{
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[EventRef]
		public string Event;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent PlayEvent;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public EmitterGameEvent StopEvent;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool AllowFadeout;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool TriggerOnce;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Preload;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParamRef[] Params;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool OverrideAttenuation;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float OverrideMinDistance;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OverrideMaxDistance;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected EventDescription eventDescription;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected EventInstance instance;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasTriggered;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool isQuitting;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool isOneshot;

		[Token(Token = "0x4000237")]
		private const string SnapshotString = "snapshot";

		[Token(Token = "0x17000012")]
		public EventDescription EventDescription
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x728AC8", Offset = "0x728AC8", VA = "0x728AC8")]
			get
			{
				return default(EventDescription);
			}
		}

		[Token(Token = "0x17000013")]
		public EventInstance EventInstance
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x728AD0", Offset = "0x728AD0", VA = "0x728AD0")]
			get
			{
				return default(EventInstance);
			}
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x728AD8", Offset = "0x728AD8", VA = "0x728AD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x728C8C", Offset = "0x728C8C", VA = "0x728C8C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x728C98", Offset = "0x728C98", VA = "0x728C98")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x728D78", Offset = "0x728D78", VA = "0x728D78", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x728B8C", Offset = "0x728B8C", VA = "0x728B8C")]
		private void Lookup()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x728DC4", Offset = "0x728DC4", VA = "0x728DC4")]
		public void Play()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x7290F8", Offset = "0x7290F8", VA = "0x7290F8")]
		public void Stop()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x72915C", Offset = "0x72915C", VA = "0x72915C")]
		public void SetParameter(string name, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x7291B4", Offset = "0x7291B4", VA = "0x7291B4")]
		public void SetParameter(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x72920C", Offset = "0x72920C", VA = "0x72920C")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x729254", Offset = "0x729254", VA = "0x729254")]
		public StudioEventEmitter()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AddComponentMenu("FMOD Studio/FMOD Studio Listener")]
	public class StudioListener : MonoBehaviour
	{
		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rigidBody;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody2D rigidBody2D;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int ListenerNumber;

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x7292F0", Offset = "0x7292F0", VA = "0x7292F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x7293CC", Offset = "0x7293CC", VA = "0x7293CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x729420", Offset = "0x729420", VA = "0x729420")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x729434", Offset = "0x729434", VA = "0x729434")]
		private void SetListenerLocation()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x72951C", Offset = "0x72951C", VA = "0x72951C")]
		public StudioListener()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class EmitterRef
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StudioEventEmitter Target;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParamRef[] Params;

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x72952C", Offset = "0x72952C", VA = "0x72952C")]
		public EmitterRef()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[AddComponentMenu("FMOD Studio/FMOD Studio Parameter Trigger")]
	public class StudioParameterTrigger : EventHandler
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EmitterRef[] Emitters;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x729534", Offset = "0x729534", VA = "0x729534")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x72970C", Offset = "0x72970C", VA = "0x72970C", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x729720", Offset = "0x729720", VA = "0x729720")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x72988C", Offset = "0x72988C", VA = "0x72988C")]
		public StudioParameterTrigger()
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x200006C")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
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

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x729890", Offset = "0x729890", VA = "0x729890", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x72997C", Offset = "0x72997C", VA = "0x72997C")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x72AAEC", Offset = "0x72AAEC", VA = "0x72AAEC")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x72A954", Offset = "0x72A954", VA = "0x72A954")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x72A6A8", Offset = "0x72A6A8", VA = "0x72A6A8")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x72A5D4", Offset = "0x72A5D4", VA = "0x72A5D4")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x72A768", Offset = "0x72A768", VA = "0x72A768")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x72ABB0", Offset = "0x72ABB0", VA = "0x72ABB0")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
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
		[Range(0f, 1.5f)]
		public float threshold;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 2.5f)]
		public float intensity;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0.25f, 5.5f)]
		public float blurSize;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 4f)]
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

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x72AC3C", Offset = "0x72AC3C", VA = "0x72AC3C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x72ACB0", Offset = "0x72ACB0", VA = "0x72ACB0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x72AD3C", Offset = "0x72AD3C", VA = "0x72AD3C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x72B0AC", Offset = "0x72B0AC", VA = "0x72B0AC")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	[ExecuteInEditMode]
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

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x72B0D0", Offset = "0x72B0D0", VA = "0x72B0D0")]
		private new void Start()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x72B0F0", Offset = "0x72B0F0", VA = "0x72B0F0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x72B3B4", Offset = "0x72B3B4", VA = "0x72B3B4")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x72B6A8", Offset = "0x72B6A8", VA = "0x72B6A8")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x72B6AC", Offset = "0x72B6AC", VA = "0x72B6AC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x72B9B8", Offset = "0x72B9B8", VA = "0x72B9B8")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
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

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x72C044", Offset = "0x72C044", VA = "0x72C044")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x72C4C0", Offset = "0x72C4C0", VA = "0x72C4C0")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x72C6F8", Offset = "0x72C6F8", VA = "0x72C6F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x72C704", Offset = "0x72C704", VA = "0x72C704")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x72C708", Offset = "0x72C708", VA = "0x72C708")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x72C7E8", Offset = "0x72C7E8", VA = "0x72C7E8")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x72C8E8", Offset = "0x72C8E8", VA = "0x72C8E8", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x72C9A8", Offset = "0x72C9A8", VA = "0x72C9A8")]
		protected void Start()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x72C7F0", Offset = "0x72C7F0", VA = "0x72C7F0")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x72C9B4", Offset = "0x72C9B4", VA = "0x72C9B4")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x72CA0C", Offset = "0x72CA0C", VA = "0x72CA0C")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x72CA14", Offset = "0x72CA14", VA = "0x72CA14")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x72CACC", Offset = "0x72CACC", VA = "0x72CACC")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x72C4A0", Offset = "0x72C4A0", VA = "0x72C4A0")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x72CD50", Offset = "0x72CD50", VA = "0x72CD50")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x72D0C8", Offset = "0x72D0C8", VA = "0x72D0C8")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x72D15C", Offset = "0x72D15C", VA = "0x72D15C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x72D1C4", Offset = "0x72D1C4", VA = "0x72D1C4")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x72D410", Offset = "0x72D410", VA = "0x72D410")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x72D784", Offset = "0x72D784", VA = "0x72D784")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x72D928", Offset = "0x72D928", VA = "0x72D928")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 3f)]
		public float intensity;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0.1f, 3f)]
		public float radius;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 3f)]
		public int blurIterations;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 5f)]
		public float blurFilterDistance;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
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

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x72D930", Offset = "0x72D930", VA = "0x72D930", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x72D998", Offset = "0x72D998", VA = "0x72D998")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x72DA28", Offset = "0x72DA28", VA = "0x72DA28")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x72DFD8", Offset = "0x72DFD8", VA = "0x72DFD8")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
}
