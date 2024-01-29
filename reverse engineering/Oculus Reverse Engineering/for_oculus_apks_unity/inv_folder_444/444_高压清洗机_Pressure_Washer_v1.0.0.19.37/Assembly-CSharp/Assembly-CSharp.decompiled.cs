using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Es.InkPainter;
using Il2CppDummyDll;
using TEngine;
using TMPro;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.Video;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class URPMaterialSwitcher : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool children;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xE2F814", Offset = "0xE2F814", VA = "0xE2F814")]
	public URPMaterialSwitcher()
	{
	}
}
[Token(Token = "0x2000003")]
public class ArtSceneTest : MonoBehaviour
{
	[Token(Token = "0x6000002")]
	[Address(RVA = "0xE2F81C", Offset = "0xE2F81C", VA = "0xE2F81C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xE2F874", Offset = "0xE2F874", VA = "0xE2F874")]
	public ArtSceneTest()
	{
	}
}
[Token(Token = "0x2000004")]
public sealed class AsyncCapture : MonoBehaviour
{
	[Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class <OnAsyncPhoto>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AsyncCapture <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0xE30034", Offset = "0xE30034", VA = "0xE30034", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0xE3007C", Offset = "0xE3007C", VA = "0xE3007C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xE2FAD4", Offset = "0xE2FAD4", VA = "0xE2FAD4")]
		[DebuggerHidden]
		public <OnAsyncPhoto>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xE2FDE8", Offset = "0xE2FDE8", VA = "0xE2FDE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xE2FDEC", Offset = "0xE2FDEC", VA = "0xE2FDEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xE3003C", Offset = "0xE3003C", VA = "0xE3003C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera CameraPhoto;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private NativeArray<byte> _buffer;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private byte[] _copyByte;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int photoCount;

	[Token(Token = "0x4000006")]
	private const int WIDTH = 1080;

	[Token(Token = "0x4000007")]
	private const int HEIGHT = 600;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RenderTexture Photo_RT;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private WaitForEndOfFrame EndOfFrame;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool isPhotoing;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string filename;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xE2F87C", Offset = "0xE2F87C", VA = "0xE2F87C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE2F9D4", Offset = "0xE2F9D4", VA = "0xE2F9D4")]
	private void OnAsyncCapture(string filename)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE2FA6C", Offset = "0xE2FA6C", VA = "0xE2FA6C")]
	[IteratorStateMachine(typeof(<OnAsyncPhoto>d__12))]
	private IEnumerator OnAsyncPhoto()
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xE2FAFC", Offset = "0xE2FAFC", VA = "0xE2FAFC")]
	private void OnCompleteReadback(AsyncGPUReadbackRequest request)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xE2FD60", Offset = "0xE2FD60", VA = "0xE2FD60")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE2FDE0", Offset = "0xE2FDE0", VA = "0xE2FDE0")]
	public AsyncCapture()
	{
	}
}
[Token(Token = "0x2000006")]
public class ClipManager
{
	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string[] clips;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private SingleClip[] singClip;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xE30084", Offset = "0xE30084", VA = "0xE30084")]
	public ClipManager()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xE3013C", Offset = "0xE3013C", VA = "0xE3013C")]
	public void LoadAuido()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xE30360", Offset = "0xE30360", VA = "0xE30360")]
	public SingleClip FindAudioClip(string clipsname)
	{
		return null;
	}
}
[Token(Token = "0x2000007")]
public class LocalAudioManager : Singleton<LocalAudioManager>
{
	[Token(Token = "0x4000011")]
	private const string A_PressureWasher_Default = "A_PressureWasher_Default";

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string AUTIO_PATH;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string AUTIO_BGM_PATH;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xE30408", Offset = "0xE30408", VA = "0xE30408")]
	public void PlayWaterSound(bool isPlay)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xE3040C", Offset = "0xE3040C", VA = "0xE3040C")]
	public static string GetAudioPath(string name, bool isBgm = false)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xE30488", Offset = "0xE30488", VA = "0xE30488")]
	public LocalAudioManager()
	{
	}
}
[Token(Token = "0x2000008")]
public class SingleClip
{
	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AudioClip audioclip;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xE30290", Offset = "0xE30290", VA = "0xE30290")]
	public SingleClip(AudioClip outauido)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xE3055C", Offset = "0xE3055C", VA = "0xE3055C")]
	public void Play(AudioSource source)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xE3058C", Offset = "0xE3058C", VA = "0xE3058C")]
	public void Stop(AudioSource source)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xE305BC", Offset = "0xE305BC", VA = "0xE305BC")]
	public void pause(AudioSource source)
	{
	}
}
[Token(Token = "0x2000009")]
public class SourceManager
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<AudioSource> allSource;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject m_Ower;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xE305EC", Offset = "0xE305EC", VA = "0xE305EC")]
	public SourceManager(GameObject outower)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xE30618", Offset = "0xE30618", VA = "0xE30618")]
	public void lnitial()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xE30738", Offset = "0xE30738", VA = "0xE30738")]
	public AudioSource GetFreeAudio()
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xE30894", Offset = "0xE30894", VA = "0xE30894")]
	public void ReleaseFreeAudio()
	{
	}
}
[Token(Token = "0x200000A")]
public static class CConstant
{
	[Token(Token = "0x4000017")]
	public const string SELECTED_MODE_TYPE = "SelectedModeType";

	[Token(Token = "0x4000018")]
	public const string SELECTED_LEVEL = "SelectedLevelId";

	[Token(Token = "0x4000019")]
	public const string CAREER_PROGRESS_SAVE = "SaveCareerLevel";

	[Token(Token = "0x400001A")]
	public const string FREE_PROGRESS_SAVE = "SaveFreeLevel";

	[Token(Token = "0x400001B")]
	public const int NULL_LEVEL = -1;

	[Token(Token = "0x400001C")]
	public const int UPDATE_PROGRESS_TIME = 1;

	[Token(Token = "0x400001D")]
	public const string CAREER_PROGRESS = "/CareerProgressTexture";

	[Token(Token = "0x400001E")]
	public const int CAREER_TYPE = 0;

	[Token(Token = "0x400001F")]
	public const string FREE_PROGRESS = "/FreeProgressTexture";

	[Token(Token = "0x4000020")]
	public const int FREE_TYPE = 1;

	[Token(Token = "0x4000021")]
	public const string DIRT_TEXTURE = "DirtTexture/";

	[Token(Token = "0x4000022")]
	public const string COMPUTE_RT = "ComputeRT";

	[Token(Token = "0x4000023")]
	public const string COMPUTE_CLEAN_RT = "ComputeAndClean";

	[Token(Token = "0x4000024")]
	public const string CS_INIT = "CSInit";

	[Token(Token = "0x4000025")]
	public const string CS_MAIN = "CSMain";

	[Token(Token = "0x4000026")]
	public const string MAINTEX = "_MainTex";

	[Token(Token = "0x4000027")]
	public const string ISHIGHLIGHT_OFF = "_ISHIGHLIGHT_OFF";

	[Token(Token = "0x4000028")]
	public const string DIRT_HIGH_LIGHT_PROCESS = "_DirtHighLightProcess";

	[Token(Token = "0x4000029")]
	public const string NEAT_HIGH_LIGHT_PROCESS = "_AllHighLightProcess";

	[Token(Token = "0x400002A")]
	public const string SIGN_All_HIGH_COLOR = "_AllHighLightColor";

	[Token(Token = "0x400002B")]
	public const string NEAT_HIGHT_NEAT_COLOR = "PlayHitSound";

	[Token(Token = "0x400002C")]
	public const int CIRCULAR_COUNT = 12;

	[Token(Token = "0x400002D")]
	public const string ClearProgressCtrl = "HotFix_Project.ClearProgressCtrl";

	[Token(Token = "0x400002E")]
	public const string SetIsAllClearCompleted = "SetIsAllClearCompleted";

	[Token(Token = "0x400002F")]
	public const string SetClearProgress = "SetClearProgress";

	[Token(Token = "0x4000030")]
	public const int WashSoundType = 7;

	[Token(Token = "0x4000031")]
	public const double TimeThreshold = 100.0;

	[Token(Token = "0x4000032")]
	public const string HitSoundCtrl = "HotFix_Project.HitSoundCtrl";

	[Token(Token = "0x4000033")]
	public const string PlayHitSound = "PlayHitSound";
}
[Token(Token = "0x200000B")]
public class CFps : MonoBehaviour
{
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text fpsText;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fpsMeasuringDelta;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_nFrameRate;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float timePassed;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int m_FrameCount;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_fFPS;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<float> m_listFps;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool m_bIsAddUp;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float m_fAddUpTime;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xE30AB4", Offset = "0xE30AB4", VA = "0xE30AB4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xE30AC8", Offset = "0xE30AC8", VA = "0xE30AC8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xE30B98", Offset = "0xE30B98", VA = "0xE30B98")]
	private void HandleResetScene()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xE30BDC", Offset = "0xE30BDC", VA = "0xE30BDC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xE30CF8", Offset = "0xE30CF8", VA = "0xE30CF8")]
	private void CheckFpsState()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xE30E2C", Offset = "0xE30E2C", VA = "0xE30E2C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xE30E30", Offset = "0xE30E30", VA = "0xE30E30")]
	public CFps()
	{
	}
}
[Token(Token = "0x200000C")]
public class GameStart : MonoBehaviour
{
	[Token(Token = "0x6000026")]
	[Address(RVA = "0xE30EBC", Offset = "0xE30EBC", VA = "0xE30EBC")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xE30F98", Offset = "0xE30F98", VA = "0xE30F98")]
	private void Start()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xE313A4", Offset = "0xE313A4", VA = "0xE313A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xE3166C", Offset = "0xE3166C", VA = "0xE3166C")]
	public GameStart()
	{
	}
}
[Token(Token = "0x200000D")]
public class BaseItem : MonoBehaviour
{
	[Token(Token = "0x600002A")]
	[Address(RVA = "0xE31674", Offset = "0xE31674", VA = "0xE31674")]
	public void AddButtonClickListener(Button btn, UnityAction action)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xE31780", Offset = "0xE31780", VA = "0xE31780")]
	public void AddToggleClickListener(Toggle toggle, UnityAction<bool> action)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xE318A0", Offset = "0xE318A0", VA = "0xE318A0")]
	private void BtnPlaySound()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xE318A4", Offset = "0xE318A4", VA = "0xE318A4")]
	private void TogglePlaySound(bool isOn)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xE318A8", Offset = "0xE318A8", VA = "0xE318A8")]
	public BaseItem()
	{
	}
}
[Token(Token = "0x200000E")]
public class Local_CommonConfirm : BaseItem
{
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_Title;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_Des;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Button m_ConfirmBtn;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Button m_CancleBtn;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xE318B0", Offset = "0xE318B0", VA = "0xE318B0")]
	public void Show(string title, string des, UnityAction confirmEvent, UnityAction cancleEvent)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xE31A14", Offset = "0xE31A14", VA = "0xE31A14")]
	private void Start()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xE31A18", Offset = "0xE31A18", VA = "0xE31A18")]
	private void Update()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xE31A1C", Offset = "0xE31A1C", VA = "0xE31A1C")]
	public Local_CommonConfirm()
	{
	}
}
[Token(Token = "0x2000010")]
public class Local_HotFixCtrl : Singleton<Local_HotFixCtrl>
{
	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string HotFixProjectLaunchClass;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string HotFixProjectLaunchMethod;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string prefabPath;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject hotFixPanelObj;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Local_HotFixPanel hotFixPanel;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform hotFixTransform;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 m_position;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion m_rotation;

	[Token(Token = "0x400004C")]
	private const float Speed = 2f;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float m_moveTime;

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xE310C0", Offset = "0xE310C0", VA = "0xE310C0")]
	public void OpenHotFixPanel()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xE313F0", Offset = "0xE313F0", VA = "0xE313F0")]
	public void Update()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xE31B3C", Offset = "0xE31B3C", VA = "0xE31B3C")]
	public void CloseHotFixPanel()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xE31BA4", Offset = "0xE31BA4", VA = "0xE31BA4")]
	public void HotFixProjectLaunch()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xE31C0C", Offset = "0xE31C0C", VA = "0xE31C0C")]
	public Local_HotFixCtrl()
	{
	}
}
[Token(Token = "0x2000011")]
public class Local_HotFixPanel2222 : MonoBehaviour
{
	[Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class <OnFinish>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Local_HotFixPanel2222 <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xE332F4", Offset = "0xE332F4", VA = "0xE332F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0xE3333C", Offset = "0xE3333C", VA = "0xE3333C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xE32748", Offset = "0xE32748", VA = "0xE32748")]
		[DebuggerHidden]
		public <OnFinish>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xE33064", Offset = "0xE33064", VA = "0xE33064", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xE33068", Offset = "0xE33068", VA = "0xE33068", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xE332FC", Offset = "0xE332FC", VA = "0xE332FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class <DelayCallBack>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Local_HotFixPanel2222 <>4__this;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0xE333FC", Offset = "0xE333FC", VA = "0xE333FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0xE33444", Offset = "0xE33444", VA = "0xE33444", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xE327D8", Offset = "0xE327D8", VA = "0xE327D8")]
		[DebuggerHidden]
		public <DelayCallBack>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xE33344", Offset = "0xE33344", VA = "0xE33344", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xE33348", Offset = "0xE33348", VA = "0xE33348", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xE33404", Offset = "0xE33404", VA = "0xE33404", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class <StartGame>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image image;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text text;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0xE336DC", Offset = "0xE336DC", VA = "0xE336DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0xE33724", Offset = "0xE33724", VA = "0xE33724", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xE32874", Offset = "0xE32874", VA = "0xE32874")]
		[DebuggerHidden]
		public <StartGame>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xE3344C", Offset = "0xE3344C", VA = "0xE3344C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xE33450", Offset = "0xE33450", VA = "0xE33450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xE336E4", Offset = "0xE336E4", VA = "0xE336E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Action updateCompleteCallBack;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_SumTime;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CanvasGroup canvasGroup;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_delayShow;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float m_alpha;

	[Token(Token = "0x4000053")]
	private const float TweenTime = 2f;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_tweenSpeed;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool m_isLoaded;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Image m_img_Logo;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Image m_img_Slider;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Text m_text_SpeedText;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Text m_text_SliderTopText;

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xE31CF0", Offset = "0xE31CF0", VA = "0xE31CF0")]
	protected void ScriptGenerator()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xE31E3C", Offset = "0xE31E3C", VA = "0xE31E3C")]
	public Transform FindChild(Transform _transform, string path)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	public T FindChildComponent<T>(Transform _transform, string path) where T : Component
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xE31E4C", Offset = "0xE31E4C", VA = "0xE31E4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xE31EF8", Offset = "0xE31EF8", VA = "0xE31EF8")]
	public void Init()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xE3221C", Offset = "0xE3221C", VA = "0xE3221C")]
	private void HotFix()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xE32318", Offset = "0xE32318", VA = "0xE32318")]
	private void OnClickStartDownload()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xE326B8", Offset = "0xE326B8", VA = "0xE326B8")]
	private void OnClickCancelDownload()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xE325C8", Offset = "0xE325C8", VA = "0xE325C8")]
	private void StartDownload()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xE326C0", Offset = "0xE326C0", VA = "0xE326C0")]
	private void StartOnFinish()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xE326E0", Offset = "0xE326E0", VA = "0xE326E0")]
	[IteratorStateMachine(typeof(<OnFinish>d__22))]
	private IEnumerator OnFinish()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xE32770", Offset = "0xE32770", VA = "0xE32770")]
	[IteratorStateMachine(typeof(<DelayCallBack>d__23))]
	private IEnumerator DelayCallBack()
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xE32800", Offset = "0xE32800", VA = "0xE32800")]
	[IteratorStateMachine(typeof(<StartGame>d__24))]
	public IEnumerator StartGame(Image image, Text text)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xE3289C", Offset = "0xE3289C", VA = "0xE3289C")]
	public void Update()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xE32A9C", Offset = "0xE32A9C", VA = "0xE32A9C")]
	private void DoAnimtionShow()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xE32B0C", Offset = "0xE32B0C", VA = "0xE32B0C")]
	private void DoAnimtionHide()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xE32220", Offset = "0xE32220", VA = "0xE32220")]
	private void CheckVersion()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xE32B4C", Offset = "0xE32B4C", VA = "0xE32B4C")]
	private void ANewDownload()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xE32C00", Offset = "0xE32C00", VA = "0xE32C00")]
	private void ServerInfoError()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xE32CF0", Offset = "0xE32CF0", VA = "0xE32CF0")]
	private void ItemError(string all)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xE3244C", Offset = "0xE3244C", VA = "0xE3244C")]
	private void OpenCommonConfirm(string title, string des, UnityAction confirmAction, UnityAction cancleAction)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xE32DFC", Offset = "0xE32DFC", VA = "0xE32DFC")]
	public Local_HotFixPanel2222()
	{
	}
}
[Token(Token = "0x2000015")]
public class Local_HotFixPanel : MonoBehaviour
{
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Action updateCompleteCallBack;

	[Token(Token = "0x4000065")]
	private const float LogoTime = 4f;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoplayer;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject videoRawImage;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject loadingContainer;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isPlayLoading;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float loadRate;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Slider m_slider;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private TMP_Text m_tmp_text_rate;

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xE3372C", Offset = "0xE3372C", VA = "0xE3372C")]
	protected void ScriptGenerator()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xE33830", Offset = "0xE33830", VA = "0xE33830")]
	public Transform FindChild(Transform _transform, string path)
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	public T FindChildComponent<T>(string path) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xE33840", Offset = "0xE33840", VA = "0xE33840")]
	private void Awake()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xE33844", Offset = "0xE33844", VA = "0xE33844")]
	private void Start()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xE33848", Offset = "0xE33848", VA = "0xE33848")]
	private void Init()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xE33AF4", Offset = "0xE33AF4", VA = "0xE33AF4")]
	private void PlayVideo()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xE33BE4", Offset = "0xE33BE4", VA = "0xE33BE4")]
	private void OnPlayOver(VideoPlayer source)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xE33E4C", Offset = "0xE33E4C", VA = "0xE33E4C")]
	private void Prepared(VideoPlayer source)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xE33C98", Offset = "0xE33C98", VA = "0xE33C98")]
	private void CheckHotDown()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xE33F84", Offset = "0xE33F84", VA = "0xE33F84")]
	private void Update()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xE33F0C", Offset = "0xE33F0C", VA = "0xE33F0C")]
	private void StartOnFinish()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xE34090", Offset = "0xE34090", VA = "0xE34090")]
	private void OnFinish()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xE341C8", Offset = "0xE341C8", VA = "0xE341C8")]
	public Local_HotFixPanel()
	{
	}
}
[Token(Token = "0x2000016")]
public class CParticlesHit : MonoBehaviour
{
	[Token(Token = "0x2000017")]
	public enum EmitType
	{
		[Token(Token = "0x4000089")]
		RaycastHitInfo,
		[Token(Token = "0x400008A")]
		WorldPoint,
		[Token(Token = "0x400008B")]
		NearestSurfacePoint,
		[Token(Token = "0x400008C")]
		DirectUV
	}

	[Token(Token = "0x2000018")]
	public enum OrientationType
	{
		[Token(Token = "0x400008E")]
		WorldUp,
		[Token(Token = "0x400008F")]
		CameraUp
	}

	[Token(Token = "0x2000019")]
	public enum NormalType
	{
		[Token(Token = "0x4000091")]
		ParticleVelocity,
		[Token(Token = "0x4000092")]
		CollisionNormal
	}

	[Token(Token = "0x200001A")]
	public enum PressureType
	{
		[Token(Token = "0x4000094")]
		Constant,
		[Token(Token = "0x4000095")]
		Distance,
		[Token(Token = "0x4000096")]
		Speed
	}

	[Token(Token = "0x200001B")]
	public class WashTime
	{
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DateTime washTime;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int washType;

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xE356C0", Offset = "0xE356C0", VA = "0xE356C0")]
		public WashTime()
		{
		}
	}

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Brush brush;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private EmitType emit;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float raycastDistance;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private LayerMask layers;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private OrientationType orientation;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Camera _camera;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private NormalType normal;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float offset;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int skip;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool preview;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private PressureType pressureMode;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float pressureMin;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float pressureMax;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[Range(0f, 1f)]
	[SerializeField]
	private float pressureConstant;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float pressureMultiplier;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject root;

	[NonSerialized]
	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ParticleSystem cachedParticleSystem;

	[NonSerialized]
	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool cachedParticleSystemSet;

	[NonSerialized]
	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<ParticleCollisionEvent> particleCollisionEvents;

	[NonSerialized]
	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int skipCounter;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float ClearRange;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float ClearEfficiency;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float ClearDistance;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private WashProperty washProperty;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int index;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Transform InitialPoint;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private List<WashTime> WashInfo;

	[Token(Token = "0x17000009")]
	public EmitType Emit
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0xE34244", Offset = "0xE34244", VA = "0xE34244")]
		get
		{
			return default(EmitType);
		}
		[Token(Token = "0x6000075")]
		[Address(RVA = "0xE3423C", Offset = "0xE3423C", VA = "0xE3423C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public float RaycastDistance
	{
		[Token(Token = "0x6000078")]
		[Address(RVA = "0xE34254", Offset = "0xE34254", VA = "0xE34254")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000077")]
		[Address(RVA = "0xE3424C", Offset = "0xE3424C", VA = "0xE3424C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public LayerMask Layers
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0xE34264", Offset = "0xE34264", VA = "0xE34264")]
		get
		{
			return default(LayerMask);
		}
		[Token(Token = "0x6000079")]
		[Address(RVA = "0xE3425C", Offset = "0xE3425C", VA = "0xE3425C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public OrientationType Orientation
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0xE34274", Offset = "0xE34274", VA = "0xE34274")]
		get
		{
			return default(OrientationType);
		}
		[Token(Token = "0x600007B")]
		[Address(RVA = "0xE3426C", Offset = "0xE3426C", VA = "0xE3426C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public Camera Camera
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0xE34284", Offset = "0xE34284", VA = "0xE34284")]
		get
		{
			return null;
		}
		[Token(Token = "0x600007D")]
		[Address(RVA = "0xE3427C", Offset = "0xE3427C", VA = "0xE3427C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public NormalType Normal
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0xE34294", Offset = "0xE34294", VA = "0xE34294")]
		get
		{
			return default(NormalType);
		}
		[Token(Token = "0x600007F")]
		[Address(RVA = "0xE3428C", Offset = "0xE3428C", VA = "0xE3428C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public float Offset
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0xE342A4", Offset = "0xE342A4", VA = "0xE342A4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000081")]
		[Address(RVA = "0xE3429C", Offset = "0xE3429C", VA = "0xE3429C")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public int Skip
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0xE342B4", Offset = "0xE342B4", VA = "0xE342B4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000083")]
		[Address(RVA = "0xE342AC", Offset = "0xE342AC", VA = "0xE342AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public bool Preview
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0xE342C8", Offset = "0xE342C8", VA = "0xE342C8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000085")]
		[Address(RVA = "0xE342BC", Offset = "0xE342BC", VA = "0xE342BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public PressureType PressureMode
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0xE342D8", Offset = "0xE342D8", VA = "0xE342D8")]
		get
		{
			return default(PressureType);
		}
		[Token(Token = "0x6000087")]
		[Address(RVA = "0xE342D0", Offset = "0xE342D0", VA = "0xE342D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public float PressureMin
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0xE342E8", Offset = "0xE342E8", VA = "0xE342E8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000089")]
		[Address(RVA = "0xE342E0", Offset = "0xE342E0", VA = "0xE342E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public float PressureMax
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0xE342F8", Offset = "0xE342F8", VA = "0xE342F8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600008B")]
		[Address(RVA = "0xE342F0", Offset = "0xE342F0", VA = "0xE342F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public float PressureConstant
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0xE34308", Offset = "0xE34308", VA = "0xE34308")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600008D")]
		[Address(RVA = "0xE34300", Offset = "0xE34300", VA = "0xE34300")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public float PressureMultiplier
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0xE34318", Offset = "0xE34318", VA = "0xE34318")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600008F")]
		[Address(RVA = "0xE34310", Offset = "0xE34310", VA = "0xE34310")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public GameObject Root
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0xE34328", Offset = "0xE34328", VA = "0xE34328")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000091")]
		[Address(RVA = "0xE34320", Offset = "0xE34320", VA = "0xE34320")]
		set
		{
		}
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xE34330", Offset = "0xE34330", VA = "0xE34330")]
	private void Start()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xE343A8", Offset = "0xE343A8", VA = "0xE343A8")]
	private bool TryGetRaycastHit(ParticleCollisionEvent collision, ref RaycastHit hit)
	{
		return default(bool);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xE34564", Offset = "0xE34564", VA = "0xE34564", Slot = "4")]
	protected virtual void OnParticleCollision(GameObject hitGameObject)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xE351A0", Offset = "0xE351A0", VA = "0xE351A0")]
	private void PlayHitSoundToHotfix(int hitType, Vector3 position)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xE35020", Offset = "0xE35020", VA = "0xE35020")]
	public static Vector3 GetCameraUp([Optional] Camera camera, [Optional] GameObject gameObject)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xE3518C", Offset = "0xE3518C", VA = "0xE3518C")]
	public static bool IndexInMask(int index, int mask)
	{
		return default(bool);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xE356C8", Offset = "0xE356C8", VA = "0xE356C8")]
	public CParticlesHit()
	{
	}
}
[Token(Token = "0x200001C")]
public class CRecovery : MonoBehaviour
{
	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button m_RecoveryButton;

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xE35800", Offset = "0xE35800", VA = "0xE35800")]
	private void Start()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xE358DC", Offset = "0xE358DC", VA = "0xE358DC")]
	public void Recovery()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xE35990", Offset = "0xE35990", VA = "0xE35990")]
	public CRecovery()
	{
	}
}
[Token(Token = "0x200001D")]
public class WashClass
{
	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public WashInfo[] washInfos;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool classWashStatus;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float classProgress;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string Name;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool signHighLightState;

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xE3599C", Offset = "0xE3599C", VA = "0xE3599C")]
	public WashClass()
	{
	}
}
[Token(Token = "0x200001E")]
public class WashInfo
{
	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int washIndex;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int washInfoIndex;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InkCanvas inkCanvas;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material[] materials;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float neatHighLightTimeCount;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int washType;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int washSubType;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int materialType;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ProgressInfo> progressInfos;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float groupProgress;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float saveGroupProgress;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool washStatus;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float progressThreshold;

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xE359A4", Offset = "0xE359A4", VA = "0xE359A4")]
	public WashInfo()
	{
	}
}
[Token(Token = "0x200001F")]
public class ProgressInfo
{
	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Material material;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float allDirtPixel;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float materialProgress;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture dirtTexture;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool calculateProgressState;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ComputeBuffer computeBuffer;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AsyncGPUReadbackRequest asyncGPUReadbackRequest;

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xE35A2C", Offset = "0xE35A2C", VA = "0xE35A2C")]
	public ProgressInfo()
	{
	}
}
[Token(Token = "0x2000020")]
public class CWashMgr : MonoBehaviour
{
	[Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class <IUpdateProgres>d__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CWashMgr <>4__this;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xE3A818", Offset = "0xE3A818", VA = "0xE3A818", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xE3A860", Offset = "0xE3A860", VA = "0xE3A860", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xE38A3C", Offset = "0xE38A3C", VA = "0xE38A3C")]
		[DebuggerHidden]
		public <IUpdateProgres>d__56(int <>1__state)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xE3A5D0", Offset = "0xE3A5D0", VA = "0xE3A5D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xE3A5D4", Offset = "0xE3A5D4", VA = "0xE3A5D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xE3A820", Offset = "0xE3A820", VA = "0xE3A820", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<WashClass> allNeatHighLightInfo;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<int, WashClass> allWashClass;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve dirtHighLightCurve;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float dirtHighLightTimeCount;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float dirtHighLightTime;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GlobalKeyword dirtHighLightFeatureKeyword;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool bDirtHighLight;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve neatHighLightInfo;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float neatHighLightCurveCount;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float neatHighLightTime;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool bNeatHighLight;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector4 neatHighLightColor;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private WaitForSeconds wfs;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float updateMaterialProgress;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float updateAllMaterialProgress;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int washMaterialCount;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int washSubCount;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int washCound;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private ComputeShader computeTextureCS;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool isSave;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float saveTimeInterval;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float saveEndTime;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private bool ApplicationFocus;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float AllProgress;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float saveProgress;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private uint allDirtPixel;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private ComputeBuffer cbAllPixel;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private int kernelResize;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private int kernelResizeInit;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private int kernelInit;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private int kernelMain;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int kernelClear;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private RenderTexture clearRenderTexture;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject TestGameObject;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private RenderTexture dirtRenderTexture;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float highLightObjCount;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private byte XRInputIndex;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int washInfoIndex;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private bool isFinish;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float progress;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private WashInfo washInfo;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ProgressInfo progressInfos;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool isAsyncGPUCalculation;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private ComputeBuffer compute_buffer;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private uint[] data;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private WashInfo neatInfo;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private WashInfo dirtHighLightInfo;

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xE35A34", Offset = "0xE35A34", VA = "0xE35A34")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xE35E8C", Offset = "0xE35E8C", VA = "0xE35E8C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xE36AFC", Offset = "0xE36AFC", VA = "0xE36AFC")]
	private void OnWashGameObjectLoadCompleted(Dictionary<string, double> saveClearProgressDatas)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xE36B70", Offset = "0xE36B70", VA = "0xE36B70")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xE37040", Offset = "0xE37040", VA = "0xE37040")]
	private void Button1DownEvent(XRControllerSide side)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xE3720C", Offset = "0xE3720C", VA = "0xE3720C")]
	private void SecondaryButtonStarted(InputAction.CallbackContext obj)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xE3721C", Offset = "0xE3721C", VA = "0xE3721C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xE372F4", Offset = "0xE372F4", VA = "0xE372F4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xE37920", Offset = "0xE37920", VA = "0xE37920")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xE38014", Offset = "0xE38014", VA = "0xE38014")]
	private void FocusStateAcquired()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xE380C8", Offset = "0xE380C8", VA = "0xE380C8")]
	private void FocusStateLost()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xE38170", Offset = "0xE38170", VA = "0xE38170")]
	private void Button2DownEvent(XRControllerSide side)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xE35E90", Offset = "0xE35E90", VA = "0xE35E90")]
	private void Init()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xE38A38", Offset = "0xE38A38", VA = "0xE38A38")]
	private void SetProgressInfo(ref WashInfo dirtInfo)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xE35DC4", Offset = "0xE35DC4", VA = "0xE35DC4")]
	private void InitComputeShader()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xE38180", Offset = "0xE38180", VA = "0xE38180")]
	private void ShowAllProgress()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xE36FD8", Offset = "0xE36FD8", VA = "0xE36FD8")]
	[IteratorStateMachine(typeof(<IUpdateProgres>d__56))]
	private IEnumerator IUpdateProgres()
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xE3722C", Offset = "0xE3722C", VA = "0xE3722C")]
	public void UpdateProgres()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xE38C74", Offset = "0xE38C74", VA = "0xE38C74")]
	private bool UpdateWashIonfo(WashClass washClass)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xE38A64", Offset = "0xE38A64", VA = "0xE38A64")]
	private bool UpdateWashIonfoDate(WashClass washClass)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xE38924", Offset = "0xE38924", VA = "0xE38924")]
	private void UpdateWashProgressToHotfix(int washType, int mainid, int subinfoid, int subid, float progress)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xE38664", Offset = "0xE38664", VA = "0xE38664")]
	public float ComputeRT(Texture rt, Texture dirtTexture, float allDirtPixel)
	{
		return default(float);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xE37A80", Offset = "0xE37A80", VA = "0xE37A80")]
	[ContextMenu("保存进度和删除进度")]
	public void SaveProgress()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xE39DF4", Offset = "0xE39DF4", VA = "0xE39DF4")]
	public void RemoveProgress(int modetype)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xE399F4", Offset = "0xE399F4", VA = "0xE399F4")]
	private bool SetSaveLeve(int modetype, string progresspath)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xE38528", Offset = "0xE38528", VA = "0xE38528")]
	private string GetProgressPath(int modetype, int level)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xE3992C", Offset = "0xE3992C", VA = "0xE3992C")]
	private string GetProgressPath(int modetype)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xE3A134", Offset = "0xE3A134", VA = "0xE3A134")]
	public void MarkHighLightObj(int[] list, bool isbool)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xE3A24C", Offset = "0xE3A24C", VA = "0xE3A24C")]
	public void SetObjHighLight(WashClass highLightWashClass, bool isbool)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xE395C0", Offset = "0xE395C0", VA = "0xE395C0")]
	public bool NeatHighLight(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xE375C0", Offset = "0xE375C0", VA = "0xE375C0")]
	private void UpdateNeatHighLight()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xE37100", Offset = "0xE37100", VA = "0xE37100")]
	public void DirtHighLight()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xE3A43C", Offset = "0xE3A43C", VA = "0xE3A43C")]
	public static void Recovery()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xE37328", Offset = "0xE37328", VA = "0xE37328")]
	private void UpdateDirtHighLight()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xE39B24", Offset = "0xE39B24", VA = "0xE39B24")]
	public bool SaveTextureToPNG(Texture texture, string contents, string pngName)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xE39EBC", Offset = "0xE39EBC", VA = "0xE39EBC")]
	public bool DeleteFile(string file)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xE3A4F0", Offset = "0xE3A4F0", VA = "0xE3A4F0")]
	public CWashMgr()
	{
	}
}
[Token(Token = "0x2000022")]
public enum GunHeadType
{
	[Token(Token = "0x40000E6")]
	ShouShu,
	[Token(Token = "0x40000E7")]
	YaZui,
	[Token(Token = "0x40000E8")]
	KuoSan
}
[Token(Token = "0x2000023")]
public enum SkillType
{
	[Token(Token = "0x40000EA")]
	ClearEfficiency = 1,
	[Token(Token = "0x40000EB")]
	ClearRange,
	[Token(Token = "0x40000EC")]
	ClearDistance
}
[Token(Token = "0x2000024")]
public class LogoWash : MonoBehaviour
{
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xE3A868", Offset = "0xE3A868", VA = "0xE3A868")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xE3A8F0", Offset = "0xE3A8F0", VA = "0xE3A8F0")]
	public LogoWash()
	{
	}
}
[Token(Token = "0x2000025")]
public class CNozzle45New : CWaterEffectBase
{
	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private bool m_CurrMode;

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xE3A8F8", Offset = "0xE3A8F8", VA = "0xE3A8F8", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xE3ACB8", Offset = "0xE3ACB8", VA = "0xE3ACB8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xE3AD7C", Offset = "0xE3AD7C", VA = "0xE3AD7C")]
	private void SetRayCastCommand(int index, Vector3 rayFrom)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xE3AE0C", Offset = "0xE3AE0C", VA = "0xE3AE0C", Slot = "6")]
	protected override void Shoot()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xE3B914", Offset = "0xE3B914", VA = "0xE3B914")]
	private void SetShooting(bool isPlay)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xE3BB20", Offset = "0xE3BB20", VA = "0xE3BB20", Slot = "9")]
	protected override void AddLimitedField()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xE3BC70", Offset = "0xE3BC70", VA = "0xE3BC70", Slot = "10")]
	protected override void GetPoint(ref Vector3 point)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xE3BCB4", Offset = "0xE3BCB4", VA = "0xE3BCB4", Slot = "7")]
	protected override void ModifySkillPropery(string headType, string skillType, double skillValue)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xE3BE20", Offset = "0xE3BE20", VA = "0xE3BE20", Slot = "8")]
	protected override void ChangeNowMaxHitDistance()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xE3BE38", Offset = "0xE3BE38", VA = "0xE3BE38")]
	public CNozzle45New()
	{
	}
}
[Token(Token = "0x2000026")]
public class CPainterNew : CWaterEffectBase
{
	[Serializable]
	[Token(Token = "0x2000027")]
	private enum UseMethodType
	{
		[Token(Token = "0x40000F4")]
		RaycastHitInfo,
		[Token(Token = "0x40000F5")]
		WorldPoint,
		[Token(Token = "0x40000F6")]
		NearestSurfacePoint,
		[Token(Token = "0x40000F7")]
		DirectUV
	}

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	[SerializeField]
	private bool erase;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x221")]
	private bool m_CurrMode;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	private Ray ray;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	private RaycastHit hitInfo;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private bool isShootSuccessed;

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xE3C014", Offset = "0xE3C014", VA = "0xE3C014", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xE3C038", Offset = "0xE3C038", VA = "0xE3C038")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xE3C03C", Offset = "0xE3C03C", VA = "0xE3C03C", Slot = "6")]
	protected override void Shoot()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xE3C5D0", Offset = "0xE3C5D0", VA = "0xE3C5D0")]
	private void HitEmptySound()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xE3C584", Offset = "0xE3C584", VA = "0xE3C584")]
	private void SetShooting(bool isPlay)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xE3C628", Offset = "0xE3C628", VA = "0xE3C628", Slot = "7")]
	protected override void ModifySkillPropery(string headType, string skillType, double skillValue)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xE3C794", Offset = "0xE3C794", VA = "0xE3C794", Slot = "8")]
	protected override void ChangeNowMaxHitDistance()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xE3C7A8", Offset = "0xE3C7A8", VA = "0xE3C7A8")]
	public CPainterNew()
	{
	}
}
[Token(Token = "0x2000028")]
public class CUmbrellaNew : CWaterEffectBase
{
	[Serializable]
	[Token(Token = "0x2000029")]
	private enum UseMethodType
	{
		[Token(Token = "0x40000FB")]
		RaycastHitInfo,
		[Token(Token = "0x40000FC")]
		WorldPoint,
		[Token(Token = "0x40000FD")]
		NearestSurfacePoint,
		[Token(Token = "0x40000FE")]
		DirectUV
	}

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private bool m_CurrMode;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public GameObject spherePrefab;

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xE3C7AC", Offset = "0xE3C7AC", VA = "0xE3C7AC", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xE3CBB4", Offset = "0xE3CBB4", VA = "0xE3CBB4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xE3CC78", Offset = "0xE3CC78", VA = "0xE3CC78", Slot = "7")]
	protected override void ModifySkillPropery(string headType, string skillType, double skillValue)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xE3CDE8", Offset = "0xE3CDE8", VA = "0xE3CDE8", Slot = "8")]
	protected override void ChangeNowMaxHitDistance()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xE3CE00", Offset = "0xE3CE00", VA = "0xE3CE00")]
	private void SetRayCastCommand(int index, Vector3 rayFrom)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xE3CE90", Offset = "0xE3CE90", VA = "0xE3CE90", Slot = "6")]
	protected override void Shoot()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xE3D53C", Offset = "0xE3D53C", VA = "0xE3D53C")]
	private void SetShooting(bool isPlay)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xE3D558", Offset = "0xE3D558", VA = "0xE3D558", Slot = "10")]
	protected override void GetPoint(ref Vector3 point)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xE3D588", Offset = "0xE3D588", VA = "0xE3D588")]
	public CUmbrellaNew()
	{
	}
}
[Token(Token = "0x200002A")]
public class CWaterEffectBase : MonoBehaviour
{
	[Token(Token = "0x200002B")]
	public class WashTime
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DateTime washTime;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int washType;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xE3DBB0", Offset = "0xE3DBB0", VA = "0xE3DBB0")]
		public WashTime()
		{
		}
	}

	[Token(Token = "0x40000FF")]
	public const float Defult_Water_Distance_Painter = 5f;

	[Token(Token = "0x4000100")]
	public const float Defult_Water_Distance_Nozzle45 = 4.34f;

	[Token(Token = "0x4000101")]
	public const float Defult_Water_Distance_Umbrella = 3.48f;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("水枪枪头类型 1-收束 2-鸭嘴 3-扩散")]
	public int waterGunType;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Header("清洗物体层级")]
	public LayerMask layerMask;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("需要动态修改Size的水注模型")]
	public Transform waterModel;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("水雾特效")]
	public ParticleSystem shuiWuEffect;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Header("水花特效模板")]
	public ParticleSystem sprayEffect;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("水注模型比例(0表示对应的轴不需要改变)")]
	public Vector3 modelScaleRatio;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Header("水注烟雾粒子数比例曲线")]
	public AnimationCurve shuiWuEffectAnimationCurve;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Header("最大水注烟雾粒子数量")]
	public int maxShuiWuEffectCount;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[Header("当前最大射中距离")]
	public float nowMaxHitDistance;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Header("当前最小射中距离")]
	public float nowMinHitDistance;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[Header("当前射中距离")]
	public float nowHitDistance;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Header("需要生成的水花数量")]
	public int sprayCount;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[Header("当前最大水花数量")]
	public int nowMaxSprayCount;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Header("清洗效率倍数")]
	public float clearEfficiencyMultiple;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Header("清洗范围倍数")]
	public float clearRangeMultiple;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Header("清洗距离倍数")]
	public float clearDistanceMultiple;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Header("更新频率")]
	public float updateFrameTime;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float update_frame;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected List<ParticleSystem> sprayParticle;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 localScale;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private ParticleSystem sprayParticleSystem;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Transform sprayTransform;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int sprayIndex;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[Header("模拟清洗点的个数")]
	[Header("-----散型 扩散 计算-----")]
	public int pointCount;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected int pointCountIndex;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[Header("生成随机点的圆的半径")]
	public float radius;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[Header("圆形比例")]
	public float xb;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public float yb;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected float xScale;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	protected float yScale;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[Header("椭圆横向长度比例系数")]
	public double widthFactor;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[Header("限制范围")]
	public float calculationDeviation;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[Tooltip("压力常数：使用时的压力值")]
	[Range(0f, 1f)]
	[Header("清洗属性")]
	public float pressureConstant;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	protected float finalPressure;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[Tooltip("笔刷属性")]
	public Brush brush;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	protected NativeArray<RaycastCommand> rayCommands;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	protected NativeArray<RaycastHit> rayCastHits;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	protected RaycastHit raycastHit;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	protected float finalDic;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	protected JobHandle jobHandle;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	protected Vector3 rayFrom;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	protected Vector3 rayDirection;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	protected InkCanvas hitInkCanvas;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	protected Transform hitTransform;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	protected WashBaseInteractable washInteractable;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	protected int materialType;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	protected List<Vector3> RandomPoint;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	protected Vector3 Point;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private double randomValue;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private double r;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private double theta;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	protected double x;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	protected double y;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	protected WashProperty washProperty;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	protected float centerDistance;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private System.Random random;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	protected RaycastCommand raycastCommand;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	protected List<WashTime> WashInfo;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public int[] washCount;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private int max;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	private int washCountIndex;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	protected int HitIndex;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	protected bool HitBool;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private float nowDateTime;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	private float timeDifference;

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xE3D58C", Offset = "0xE3D58C", VA = "0xE3D58C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xE3AA78", Offset = "0xE3AA78", VA = "0xE3AA78", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xE3D660", Offset = "0xE3D660", VA = "0xE3D660")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xE3D668", Offset = "0xE3D668", VA = "0xE3D668")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xE3D73C", Offset = "0xE3D73C", VA = "0xE3D73C", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xE3D7D0", Offset = "0xE3D7D0", VA = "0xE3D7D0", Slot = "6")]
	protected virtual void Shoot()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xE3D7D4", Offset = "0xE3D7D4", VA = "0xE3D7D4", Slot = "7")]
	protected virtual void ModifySkillPropery(string headType, string skillType, double skillValue)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xE3D7D8", Offset = "0xE3D7D8", VA = "0xE3D7D8", Slot = "8")]
	protected virtual void ChangeNowMaxHitDistance()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xE3B930", Offset = "0xE3B930", VA = "0xE3B930")]
	protected void ChangeEffectStartSize()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xE3BA48", Offset = "0xE3BA48", VA = "0xE3BA48")]
	public void PlayWaterFX(bool isPlay)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xE3B640", Offset = "0xE3B640", VA = "0xE3B640")]
	public void PlaySpray(RaycastHit hitInfo)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xE3C5A0", Offset = "0xE3C5A0", VA = "0xE3C5A0")]
	public void PlaySprayPainter(RaycastHit hitInfo)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xE3B5F8", Offset = "0xE3B5F8", VA = "0xE3B5F8")]
	protected void FinalPressure(float distance)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xE3B4B8", Offset = "0xE3B4B8", VA = "0xE3B4B8")]
	protected void Random()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xE3BB78", Offset = "0xE3BB78", VA = "0xE3BB78")]
	protected void AddRandomPoint(int index)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xE3D7DC", Offset = "0xE3D7DC", VA = "0xE3D7DC", Slot = "9")]
	protected virtual void AddLimitedField()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xE3D7E0", Offset = "0xE3D7E0", VA = "0xE3D7E0", Slot = "10")]
	protected virtual void GetPoint(ref Vector3 point)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xE3D838", Offset = "0xE3D838", VA = "0xE3D838")]
	protected float RandomGaussian(float minValue = 0f, float maxValue = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xE3C9F8", Offset = "0xE3C9F8", VA = "0xE3C9F8")]
	protected void CalculationRadian(int count)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xE3D8EC", Offset = "0xE3D8EC", VA = "0xE3D8EC")]
	public void PlayHitSoundToHotfix(int hitType, Vector3 position)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xE3B818", Offset = "0xE3B818", VA = "0xE3B818")]
	public void PlayHitSound(int hitType, Vector3 position)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xE3B778", Offset = "0xE3B778", VA = "0xE3B778")]
	public int MostWashCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xE3DBB8", Offset = "0xE3DBB8", VA = "0xE3DBB8")]
	public void SteHitType(int hitType, Vector3 position)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xE3BE3C", Offset = "0xE3BE3C", VA = "0xE3BE3C")]
	public CWaterEffectBase()
	{
	}
}
[Token(Token = "0x200002C")]
public class WashProperty : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200002D")]
	public enum MaterialType
	{
		[Token(Token = "0x400014C")]
		Metal,
		[Token(Token = "0x400014D")]
		Glass,
		[Token(Token = "0x400014E")]
		Plastic,
		[Token(Token = "0x400014F")]
		Wood,
		[Token(Token = "0x4000150")]
		Stone,
		[Token(Token = "0x4000151")]
		Fibre
	}

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int SelfId;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int WashType;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MaterialType materialType;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float WashScale;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<float> dirtCount;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float progressThreshold;

	[Token(Token = "0x1700001A")]
	public float ProgressThreshold
	{
		[Token(Token = "0x6000104")]
		[Address(RVA = "0xE3DC64", Offset = "0xE3DC64", VA = "0xE3DC64")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000105")]
		[Address(RVA = "0xE3DC6C", Offset = "0xE3DC6C", VA = "0xE3DC6C")]
		set
		{
		}
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xE3DC74", Offset = "0xE3DC74", VA = "0xE3DC74")]
	public WashProperty()
	{
	}
}
[Token(Token = "0x200002E")]
[ExecuteAlways]
public class PlanarReflections : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200002F")]
	public enum ResolutionMulltiplier
	{
		[Token(Token = "0x400015E")]
		Full,
		[Token(Token = "0x400015F")]
		Half,
		[Token(Token = "0x4000160")]
		Third,
		[Token(Token = "0x4000161")]
		Quarter
	}

	[Serializable]
	[Token(Token = "0x2000030")]
	public class PlanarReflectionSettings
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ResolutionMulltiplier m_ResolutionMultiplier;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m_ClipPlaneOffset;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask m_ReflectLayers;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool m_shadows;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool _blurOn;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 5f)]
		public float _blurSize;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 10f)]
		public int _blurIterations;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(1f, 4f)]
		public float _downsample;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xE3F82C", Offset = "0xE3F82C", VA = "0xE3F82C")]
		public PlanarReflectionSettings()
		{
		}
	}

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public PlanarReflectionSettings m_settings;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject target;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("camOffset")]
	public float m_planeOffset;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Camera m_ReflectionCamera;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector2Int m_TextureSize;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RenderTexture m_ReflectionTexture;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RenderTexture m_BlurReflectionTexture;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int planarReflectionTextureID;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private ResolutionMulltiplier m_OldRes;

	[Token(Token = "0x400015B")]
	private const string k_BlurShader = "Hidden/KawaseBlur";

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material _blurMaterial;

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xE3DD18", Offset = "0xE3DD18", VA = "0xE3DD18")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xE3DD1C", Offset = "0xE3DD1C", VA = "0xE3DD1C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xE3DDC0", Offset = "0xE3DDC0", VA = "0xE3DDC0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xE3DF68", Offset = "0xE3DF68", VA = "0xE3DF68")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xE3DDC4", Offset = "0xE3DDC4", VA = "0xE3DDC4")]
	private void Cleanup()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xE3DF6C", Offset = "0xE3DF6C", VA = "0xE3DF6C")]
	private void SafeDestroy(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xE3DFE4", Offset = "0xE3DFE4", VA = "0xE3DFE4")]
	private void UpdateCamera(Camera src, Camera dest)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xE3E098", Offset = "0xE3E098", VA = "0xE3E098")]
	private void UpdateReflectionCamera(Camera realCamera)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xE3E9C4", Offset = "0xE3E9C4", VA = "0xE3E9C4")]
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xE3EA58", Offset = "0xE3EA58", VA = "0xE3EA58")]
	private static Vector3 ReflectPosition(Vector3 pos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xE3EC18", Offset = "0xE3EC18", VA = "0xE3EC18")]
	private float GetScaleValue()
	{
		return default(float);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xE3EC50", Offset = "0xE3EC50", VA = "0xE3EC50")]
	private static bool Int2Compare(Vector2Int a, Vector2Int b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xE3EA60", Offset = "0xE3EA60", VA = "0xE3EA60")]
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xE3E624", Offset = "0xE3E624", VA = "0xE3E624")]
	private Camera CreateMirrorObjects(Camera currentCamera)
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xE3EC78", Offset = "0xE3EC78", VA = "0xE3EC78")]
	private Vector2Int ReflectionResolution(Camera cam, float scale)
	{
		return default(Vector2Int);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xE3ED5C", Offset = "0xE3ED5C", VA = "0xE3ED5C")]
	public void ExecuteBeforeCameraRender(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xE3F75C", Offset = "0xE3F75C", VA = "0xE3F75C")]
	public PlanarReflections()
	{
	}
}
[Token(Token = "0x2000031")]
public class AnimationWashInteractable : WashBaseInteractable
{
	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator animator;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float hideTime;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int animIDIdle;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private BoxCollider boxCollider;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool runBool;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public BoxCollider boxColliders;

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xE3F878", Offset = "0xE3F878", VA = "0xE3F878")]
	private void Start()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xE3F990", Offset = "0xE3F990", VA = "0xE3F990", Slot = "4")]
	public override void AnimationPlay()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xE3FAA4", Offset = "0xE3FAA4", VA = "0xE3FAA4")]
	public void SetObject()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xE3FB10", Offset = "0xE3FB10", VA = "0xE3FB10")]
	public AnimationWashInteractable()
	{
	}
}
[Token(Token = "0x2000032")]
public class PhysicsWashInteractable : WashBaseInteractable
{
	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource Music;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Collider Colliders;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float Force;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xE3FB30", Offset = "0xE3FB30", VA = "0xE3FB30")]
	private void Start()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xE3FC24", Offset = "0xE3FC24", VA = "0xE3FC24", Slot = "5")]
	public override void AddForce(Vector3 direction, Vector3 point)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xE3FD80", Offset = "0xE3FD80", VA = "0xE3FD80")]
	public PhysicsWashInteractable()
	{
	}
}
[Token(Token = "0x2000033")]
public enum InteractableType
{
	[Token(Token = "0x4000174")]
	Animation,
	[Token(Token = "0x4000175")]
	Physics
}
[Token(Token = "0x2000034")]
public class WashBaseInteractable : MonoBehaviour
{
	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InteractableType WashInteractableType;

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xE3FD90", Offset = "0xE3FD90", VA = "0xE3FD90", Slot = "4")]
	public virtual void AnimationPlay()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xE3FD94", Offset = "0xE3FD94", VA = "0xE3FD94", Slot = "5")]
	public virtual void AddForce(Vector3 direction, Vector3 point)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xE3FB28", Offset = "0xE3FB28", VA = "0xE3FB28")]
	public WashBaseInteractable()
	{
	}
}
[Token(Token = "0x2000035")]
public class ActionBasedController : MonoBehaviour
{
	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ActionBasedControllerManager leftActionBasedController;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ActionBasedControllerManager rightActionBasedController;

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xE3FD98", Offset = "0xE3FD98", VA = "0xE3FD98")]
	private void Start()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xE3FF38", Offset = "0xE3FF38", VA = "0xE3FF38")]
	private void OnLeftEnterTeleportState(ActionBasedControllerManager.StateId previousStateId)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xE3FF8C", Offset = "0xE3FF8C", VA = "0xE3FF8C")]
	private void OnRightEnterTeleportState(ActionBasedControllerManager.StateId previousStateId)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xE3FFE0", Offset = "0xE3FFE0", VA = "0xE3FFE0")]
	private void OnExitTeleportState(ActionBasedControllerManager.StateId nextStateId)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xE40030", Offset = "0xE40030", VA = "0xE40030")]
	public ActionBasedController()
	{
	}
}
[Token(Token = "0x2000036")]
public class TestRay : MonoBehaviour
{
	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Force;

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xE40038", Offset = "0xE40038", VA = "0xE40038")]
	private void Start()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xE4003C", Offset = "0xE4003C", VA = "0xE4003C")]
	private void Update()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xE40040", Offset = "0xE40040", VA = "0xE40040")]
	private void InstanseRay()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xE40320", Offset = "0xE40320", VA = "0xE40320")]
	public TestRay()
	{
	}
}
[Token(Token = "0x2000037")]
public class CSetFoveaTionLevel : MonoBehaviour
{
	[Token(Token = "0x600012C")]
	[Address(RVA = "0xE40330", Offset = "0xE40330", VA = "0xE40330")]
	private void Awake()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xE4033C", Offset = "0xE4033C", VA = "0xE4033C")]
	public CSetFoveaTionLevel()
	{
	}
}
namespace Es.InkPainter.Sample
{
	[Token(Token = "0x2000038")]
	public class CWaterGun : MonoBehaviour
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference m_ActiveReference;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputActionReference m_SecondaryButtonReference;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InputActionReference m_PrimaryButtonReference;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<GameObject> m_ParticleLists;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_nParticIndex;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int m_nIsPlayParticle;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_ShootMode;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool m_ShootingMode;

		[Token(Token = "0x1700001B")]
		public bool ShootMode
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0xE40344", Offset = "0xE40344", VA = "0xE40344")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0xE4034C", Offset = "0xE4034C", VA = "0xE4034C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool ShootingMode
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xE40358", Offset = "0xE40358", VA = "0xE40358")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0xE40360", Offset = "0xE40360", VA = "0xE40360")]
			set
			{
			}
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE4036C", Offset = "0xE4036C", VA = "0xE4036C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xE405D0", Offset = "0xE405D0", VA = "0xE405D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xE4088C", Offset = "0xE4088C", VA = "0xE4088C")]
		private void ActionStarted(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xE40900", Offset = "0xE40900", VA = "0xE40900")]
		private void CanceledStarted(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE40654", Offset = "0xE40654", VA = "0xE40654")]
		private void SecondaryButtonStarted(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xE407D8", Offset = "0xE407D8", VA = "0xE407D8")]
		private void PrimaryButtonStarted(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xE40908", Offset = "0xE40908", VA = "0xE40908")]
		public CWaterGun()
		{
		}
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x2000039")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x200003A")]
		private class CameraState
		{
			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x6000145")]
			[Address(RVA = "0xE4112C", Offset = "0xE4112C", VA = "0xE4112C")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x6000146")]
			[Address(RVA = "0xE41880", Offset = "0xE41880", VA = "0xE41880")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x6000147")]
			[Address(RVA = "0xE41900", Offset = "0xE41900", VA = "0xE41900")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x6000148")]
			[Address(RVA = "0xE41988", Offset = "0xE41988", VA = "0xE41988")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x6000149")]
			[Address(RVA = "0xE41B84", Offset = "0xE41B84", VA = "0xE41B84")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x4000182")]
		private const float k_MouseSensitivityMultiplier = 0.01f;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Movement Settings")]
		[Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		public float boost;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0.001f, 1f)]
		[Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
		public float positionLerpTime;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Rotation Settings")]
		[Tooltip("Multiplier for the sensitivity of the rotation.")]
		public float mouseSensitivity;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private InputAction movementAction;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InputAction verticalMovementAction;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InputAction lookAction;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InputAction boostFactorAction;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool mouseRightButtonPressed;

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xE40984", Offset = "0xE40984", VA = "0xE40984")]
		private void Start()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE410D8", Offset = "0xE410D8", VA = "0xE410D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xE411B0", Offset = "0xE411B0", VA = "0xE411B0")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE4124C", Offset = "0xE4124C", VA = "0xE4124C")]
		private void Update()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xE41820", Offset = "0xE41820", VA = "0xE41820")]
		private float GetBoostFactor()
		{
			return default(float);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE416E4", Offset = "0xE416E4", VA = "0xE416E4")]
		private Vector2 GetInputLookRotation()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xE41754", Offset = "0xE41754", VA = "0xE41754")]
		private bool IsBoostPressed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xE41484", Offset = "0xE41484", VA = "0xE41484")]
		private bool IsEscapePressed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xE415A4", Offset = "0xE415A4", VA = "0xE415A4")]
		private bool IsCameraRotationAllowed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xE414E4", Offset = "0xE414E4", VA = "0xE414E4")]
		private bool IsRightMouseButtonDown()
		{
			return default(bool);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xE41544", Offset = "0xE41544", VA = "0xE41544")]
		private bool IsRightMouseButtonUp()
		{
			return default(bool);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xE419D0", Offset = "0xE419D0", VA = "0xE419D0")]
		public SimpleCameraController()
		{
		}
	}
}
namespace TEngine
{
	[Token(Token = "0x200003B")]
	public static class Frame
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, IManager> modules;

		[Token(Token = "0x1700001D")]
		public static GameObject Root
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xE41B8C", Offset = "0xE41B8C", VA = "0xE41B8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xE41BDC", Offset = "0xE41BDC", VA = "0xE41BDC")]
		public static void Init()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xE42194", Offset = "0xE42194", VA = "0xE42194")]
		public static void Start()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xE4230C", Offset = "0xE4230C", VA = "0xE4230C")]
		private static void onApplicationFocus(bool isFocus)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xE423C0", Offset = "0xE423C0", VA = "0xE423C0")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xE42370", Offset = "0xE42370", VA = "0xE42370")]
		private static void OnApplicationQuit()
		{
		}
	}
}
namespace Base.Common
{
	[Token(Token = "0x200003C")]
	public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
	{
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T mInstance;

		[Token(Token = "0x1700001E")]
		public static T Ins
		{
			[Token(Token = "0x6000151")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000152")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000153")]
		public void Destroy()
		{
		}

		[Token(Token = "0x6000154")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6000155")]
		public MonoSingleton()
		{
		}
	}
}
