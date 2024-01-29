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
	[Address(RVA = "0xE285C0", Offset = "0xE285C0", VA = "0xE285C0")]
	public URPMaterialSwitcher()
	{
	}
}
[Token(Token = "0x2000003")]
public class ArtSceneTest : MonoBehaviour
{
	[Token(Token = "0x6000002")]
	[Address(RVA = "0xE285C8", Offset = "0xE285C8", VA = "0xE285C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xE28620", Offset = "0xE28620", VA = "0xE28620")]
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
			[Address(RVA = "0xE28DE0", Offset = "0xE28DE0", VA = "0xE28DE0", Slot = "4")]
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
			[Address(RVA = "0xE28E28", Offset = "0xE28E28", VA = "0xE28E28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xE28880", Offset = "0xE28880", VA = "0xE28880")]
		[DebuggerHidden]
		public <OnAsyncPhoto>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xE28B94", Offset = "0xE28B94", VA = "0xE28B94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xE28B98", Offset = "0xE28B98", VA = "0xE28B98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xE28DE8", Offset = "0xE28DE8", VA = "0xE28DE8", Slot = "8")]
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
	[Address(RVA = "0xE28628", Offset = "0xE28628", VA = "0xE28628")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE28780", Offset = "0xE28780", VA = "0xE28780")]
	private void OnAsyncCapture(string filename)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE28818", Offset = "0xE28818", VA = "0xE28818")]
	[IteratorStateMachine(typeof(<OnAsyncPhoto>d__12))]
	private IEnumerator OnAsyncPhoto()
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xE288A8", Offset = "0xE288A8", VA = "0xE288A8")]
	private void OnCompleteReadback(AsyncGPUReadbackRequest request)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xE28B0C", Offset = "0xE28B0C", VA = "0xE28B0C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE28B8C", Offset = "0xE28B8C", VA = "0xE28B8C")]
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
	[Address(RVA = "0xE28E30", Offset = "0xE28E30", VA = "0xE28E30")]
	public ClipManager()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xE28EE8", Offset = "0xE28EE8", VA = "0xE28EE8")]
	public void LoadAuido()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xE2910C", Offset = "0xE2910C", VA = "0xE2910C")]
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
	[Address(RVA = "0xE291B4", Offset = "0xE291B4", VA = "0xE291B4")]
	public void PlayWaterSound(bool isPlay)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xE291B8", Offset = "0xE291B8", VA = "0xE291B8")]
	public static string GetAudioPath(string name, bool isBgm = false)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xE29234", Offset = "0xE29234", VA = "0xE29234")]
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
	[Address(RVA = "0xE2903C", Offset = "0xE2903C", VA = "0xE2903C")]
	public SingleClip(AudioClip outauido)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xE29308", Offset = "0xE29308", VA = "0xE29308")]
	public void Play(AudioSource source)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xE29338", Offset = "0xE29338", VA = "0xE29338")]
	public void Stop(AudioSource source)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xE29368", Offset = "0xE29368", VA = "0xE29368")]
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
	[Address(RVA = "0xE29398", Offset = "0xE29398", VA = "0xE29398")]
	public SourceManager(GameObject outower)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xE293C4", Offset = "0xE293C4", VA = "0xE293C4")]
	public void lnitial()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xE294E4", Offset = "0xE294E4", VA = "0xE294E4")]
	public AudioSource GetFreeAudio()
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xE29640", Offset = "0xE29640", VA = "0xE29640")]
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
	public const string CS_INIT = "CSInit";

	[Token(Token = "0x4000024")]
	public const string CS_MAIN = "CSMain";

	[Token(Token = "0x4000025")]
	public const string MAINTEX = "_MainTex";

	[Token(Token = "0x4000026")]
	public const string ISHIGHLIGHT_OFF = "_ISHIGHLIGHT_OFF";

	[Token(Token = "0x4000027")]
	public const string DIRT_HIGH_LIGHT_PROCESS = "_DirtHighLightProcess";

	[Token(Token = "0x4000028")]
	public const string NEAT_HIGH_LIGHT_PROCESS = "_AllHighLightProcess";

	[Token(Token = "0x4000029")]
	public const string SIGN_All_HIGH_COLOR = "_AllHighLightColor";

	[Token(Token = "0x400002A")]
	public const string NEAT_HIGHT_NEAT_COLOR = "PlayHitSound";

	[Token(Token = "0x400002B")]
	public const int CIRCULAR_COUNT = 12;

	[Token(Token = "0x400002C")]
	public const string ClearProgressCtrl = "HotFix_Project.ClearProgressCtrl";

	[Token(Token = "0x400002D")]
	public const string SetIsAllClearCompleted = "SetIsAllClearCompleted";

	[Token(Token = "0x400002E")]
	public const string SetClearProgress = "SetClearProgress";

	[Token(Token = "0x400002F")]
	public const int WashSoundType = 7;

	[Token(Token = "0x4000030")]
	public const double TimeThreshold = 100.0;

	[Token(Token = "0x4000031")]
	public const string HitSoundCtrl = "HotFix_Project.HitSoundCtrl";

	[Token(Token = "0x4000032")]
	public const string PlayHitSound = "PlayHitSound";
}
[Token(Token = "0x200000B")]
public class CFps : MonoBehaviour
{
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text fpsText;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fpsMeasuringDelta;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_nFrameRate;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float timePassed;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int m_FrameCount;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_fFPS;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<float> m_listFps;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool m_bIsAddUp;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float m_fAddUpTime;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xE29860", Offset = "0xE29860", VA = "0xE29860")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xE29874", Offset = "0xE29874", VA = "0xE29874")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xE29944", Offset = "0xE29944", VA = "0xE29944")]
	private void HandleResetScene()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xE29988", Offset = "0xE29988", VA = "0xE29988")]
	private void Update()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xE29AA4", Offset = "0xE29AA4", VA = "0xE29AA4")]
	private void CheckFpsState()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xE29BD8", Offset = "0xE29BD8", VA = "0xE29BD8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xE29BDC", Offset = "0xE29BDC", VA = "0xE29BDC")]
	public CFps()
	{
	}
}
[Token(Token = "0x200000C")]
public class GameStart : MonoBehaviour
{
	[Token(Token = "0x6000026")]
	[Address(RVA = "0xE29C68", Offset = "0xE29C68", VA = "0xE29C68")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xE29CB8", Offset = "0xE29CB8", VA = "0xE29CB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xE2A0C4", Offset = "0xE2A0C4", VA = "0xE2A0C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xE2A38C", Offset = "0xE2A38C", VA = "0xE2A38C")]
	public GameStart()
	{
	}
}
[Token(Token = "0x200000D")]
public class BaseItem : MonoBehaviour
{
	[Token(Token = "0x600002A")]
	[Address(RVA = "0xE2A394", Offset = "0xE2A394", VA = "0xE2A394")]
	public void AddButtonClickListener(Button btn, UnityAction action)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xE2A4A0", Offset = "0xE2A4A0", VA = "0xE2A4A0")]
	public void AddToggleClickListener(Toggle toggle, UnityAction<bool> action)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xE2A5C0", Offset = "0xE2A5C0", VA = "0xE2A5C0")]
	private void BtnPlaySound()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xE2A5C4", Offset = "0xE2A5C4", VA = "0xE2A5C4")]
	private void TogglePlaySound(bool isOn)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xE2A5C8", Offset = "0xE2A5C8", VA = "0xE2A5C8")]
	public BaseItem()
	{
	}
}
[Token(Token = "0x200000E")]
public class Local_CommonConfirm : BaseItem
{
	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text m_Title;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text m_Des;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Button m_ConfirmBtn;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Button m_CancleBtn;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xE2A5D0", Offset = "0xE2A5D0", VA = "0xE2A5D0")]
	public void Show(string title, string des, UnityAction confirmEvent, UnityAction cancleEvent)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xE2A734", Offset = "0xE2A734", VA = "0xE2A734")]
	private void Start()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xE2A738", Offset = "0xE2A738", VA = "0xE2A738")]
	private void Update()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xE2A73C", Offset = "0xE2A73C", VA = "0xE2A73C")]
	public Local_CommonConfirm()
	{
	}
}
[Token(Token = "0x2000010")]
public class Local_HotFixCtrl : Singleton<Local_HotFixCtrl>
{
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string HotFixProjectLaunchClass;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string HotFixProjectLaunchMethod;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string prefabPath;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject hotFixPanelObj;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Local_HotFixPanel hotFixPanel;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform hotFixTransform;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 m_position;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion m_rotation;

	[Token(Token = "0x400004B")]
	private const float Speed = 2f;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float m_moveTime;

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xE29DE0", Offset = "0xE29DE0", VA = "0xE29DE0")]
	public void OpenHotFixPanel()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xE2A110", Offset = "0xE2A110", VA = "0xE2A110")]
	public void Update()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xE2A85C", Offset = "0xE2A85C", VA = "0xE2A85C")]
	public void CloseHotFixPanel()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xE2A8C4", Offset = "0xE2A8C4", VA = "0xE2A8C4")]
	public void HotFixProjectLaunch()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xE2A92C", Offset = "0xE2A92C", VA = "0xE2A92C")]
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
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Local_HotFixPanel2222 <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xE2C014", Offset = "0xE2C014", VA = "0xE2C014", Slot = "4")]
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
			[Address(RVA = "0xE2C05C", Offset = "0xE2C05C", VA = "0xE2C05C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xE2B468", Offset = "0xE2B468", VA = "0xE2B468")]
		[DebuggerHidden]
		public <OnFinish>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xE2BD84", Offset = "0xE2BD84", VA = "0xE2BD84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xE2BD88", Offset = "0xE2BD88", VA = "0xE2BD88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xE2C01C", Offset = "0xE2C01C", VA = "0xE2C01C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class <DelayCallBack>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Local_HotFixPanel2222 <>4__this;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0xE2C11C", Offset = "0xE2C11C", VA = "0xE2C11C", Slot = "4")]
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
			[Address(RVA = "0xE2C164", Offset = "0xE2C164", VA = "0xE2C164", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xE2B4F8", Offset = "0xE2B4F8", VA = "0xE2B4F8")]
		[DebuggerHidden]
		public <DelayCallBack>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xE2C064", Offset = "0xE2C064", VA = "0xE2C064", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xE2C068", Offset = "0xE2C068", VA = "0xE2C068", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xE2C124", Offset = "0xE2C124", VA = "0xE2C124", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class <StartGame>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image image;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Text text;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0xE2C3FC", Offset = "0xE2C3FC", VA = "0xE2C3FC", Slot = "4")]
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
			[Address(RVA = "0xE2C444", Offset = "0xE2C444", VA = "0xE2C444", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xE2B594", Offset = "0xE2B594", VA = "0xE2B594")]
		[DebuggerHidden]
		public <StartGame>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xE2C16C", Offset = "0xE2C16C", VA = "0xE2C16C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xE2C170", Offset = "0xE2C170", VA = "0xE2C170", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xE2C404", Offset = "0xE2C404", VA = "0xE2C404", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Action updateCompleteCallBack;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float m_SumTime;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CanvasGroup canvasGroup;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float m_delayShow;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float m_alpha;

	[Token(Token = "0x4000052")]
	private const float TweenTime = 2f;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float m_tweenSpeed;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool m_isLoaded;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Image m_img_Logo;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Image m_img_Slider;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Text m_text_SpeedText;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Text m_text_SliderTopText;

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xE2AA10", Offset = "0xE2AA10", VA = "0xE2AA10")]
	protected void ScriptGenerator()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xE2AB5C", Offset = "0xE2AB5C", VA = "0xE2AB5C")]
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
	[Address(RVA = "0xE2AB6C", Offset = "0xE2AB6C", VA = "0xE2AB6C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xE2AC18", Offset = "0xE2AC18", VA = "0xE2AC18")]
	public void Init()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xE2AF3C", Offset = "0xE2AF3C", VA = "0xE2AF3C")]
	private void HotFix()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xE2B038", Offset = "0xE2B038", VA = "0xE2B038")]
	private void OnClickStartDownload()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xE2B3D8", Offset = "0xE2B3D8", VA = "0xE2B3D8")]
	private void OnClickCancelDownload()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xE2B2E8", Offset = "0xE2B2E8", VA = "0xE2B2E8")]
	private void StartDownload()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xE2B3E0", Offset = "0xE2B3E0", VA = "0xE2B3E0")]
	private void StartOnFinish()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xE2B400", Offset = "0xE2B400", VA = "0xE2B400")]
	[IteratorStateMachine(typeof(<OnFinish>d__22))]
	private IEnumerator OnFinish()
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xE2B490", Offset = "0xE2B490", VA = "0xE2B490")]
	[IteratorStateMachine(typeof(<DelayCallBack>d__23))]
	private IEnumerator DelayCallBack()
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xE2B520", Offset = "0xE2B520", VA = "0xE2B520")]
	[IteratorStateMachine(typeof(<StartGame>d__24))]
	public IEnumerator StartGame(Image image, Text text)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xE2B5BC", Offset = "0xE2B5BC", VA = "0xE2B5BC")]
	public void Update()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xE2B7BC", Offset = "0xE2B7BC", VA = "0xE2B7BC")]
	private void DoAnimtionShow()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xE2B82C", Offset = "0xE2B82C", VA = "0xE2B82C")]
	private void DoAnimtionHide()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xE2AF40", Offset = "0xE2AF40", VA = "0xE2AF40")]
	private void CheckVersion()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xE2B86C", Offset = "0xE2B86C", VA = "0xE2B86C")]
	private void ANewDownload()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xE2B920", Offset = "0xE2B920", VA = "0xE2B920")]
	private void ServerInfoError()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xE2BA10", Offset = "0xE2BA10", VA = "0xE2BA10")]
	private void ItemError(string all)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xE2B16C", Offset = "0xE2B16C", VA = "0xE2B16C")]
	private void OpenCommonConfirm(string title, string des, UnityAction confirmAction, UnityAction cancleAction)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xE2BB1C", Offset = "0xE2BB1C", VA = "0xE2BB1C")]
	public Local_HotFixPanel2222()
	{
	}
}
[Token(Token = "0x2000015")]
public class Local_HotFixPanel : MonoBehaviour
{
	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Action updateCompleteCallBack;

	[Token(Token = "0x4000064")]
	private const float LogoTime = 4f;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoplayer;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject videoRawImage;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject loadingContainer;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isPlayLoading;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float loadRate;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Slider m_slider;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private TMP_Text m_tmp_text_rate;

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xE2C44C", Offset = "0xE2C44C", VA = "0xE2C44C")]
	protected void ScriptGenerator()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xE2C550", Offset = "0xE2C550", VA = "0xE2C550")]
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
	[Address(RVA = "0xE2C560", Offset = "0xE2C560", VA = "0xE2C560")]
	private void Awake()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xE2C564", Offset = "0xE2C564", VA = "0xE2C564")]
	private void Start()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xE2C568", Offset = "0xE2C568", VA = "0xE2C568")]
	private void Init()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xE2C814", Offset = "0xE2C814", VA = "0xE2C814")]
	private void PlayVideo()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xE2C904", Offset = "0xE2C904", VA = "0xE2C904")]
	private void OnPlayOver(VideoPlayer source)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xE2CB6C", Offset = "0xE2CB6C", VA = "0xE2CB6C")]
	private void Prepared(VideoPlayer source)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xE2C9B8", Offset = "0xE2C9B8", VA = "0xE2C9B8")]
	private void CheckHotDown()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xE2CCA4", Offset = "0xE2CCA4", VA = "0xE2CCA4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xE2CC2C", Offset = "0xE2CC2C", VA = "0xE2CC2C")]
	private void StartOnFinish()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xE2CDB0", Offset = "0xE2CDB0", VA = "0xE2CDB0")]
	private void OnFinish()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xE2CEE8", Offset = "0xE2CEE8", VA = "0xE2CEE8")]
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
		[Token(Token = "0x4000088")]
		RaycastHitInfo,
		[Token(Token = "0x4000089")]
		WorldPoint,
		[Token(Token = "0x400008A")]
		NearestSurfacePoint,
		[Token(Token = "0x400008B")]
		DirectUV
	}

	[Token(Token = "0x2000018")]
	public enum OrientationType
	{
		[Token(Token = "0x400008D")]
		WorldUp,
		[Token(Token = "0x400008E")]
		CameraUp
	}

	[Token(Token = "0x2000019")]
	public enum NormalType
	{
		[Token(Token = "0x4000090")]
		ParticleVelocity,
		[Token(Token = "0x4000091")]
		CollisionNormal
	}

	[Token(Token = "0x200001A")]
	public enum PressureType
	{
		[Token(Token = "0x4000093")]
		Constant,
		[Token(Token = "0x4000094")]
		Distance,
		[Token(Token = "0x4000095")]
		Speed
	}

	[Token(Token = "0x200001B")]
	public class WashTime
	{
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DateTime washTime;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int washType;

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xE2E3E0", Offset = "0xE2E3E0", VA = "0xE2E3E0")]
		public WashTime()
		{
		}
	}

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Brush brush;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private EmitType emit;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float raycastDistance;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private LayerMask layers;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private OrientationType orientation;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Camera _camera;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private NormalType normal;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float offset;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int skip;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool preview;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private PressureType pressureMode;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float pressureMin;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float pressureMax;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[Range(0f, 1f)]
	[SerializeField]
	private float pressureConstant;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float pressureMultiplier;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject root;

	[NonSerialized]
	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ParticleSystem cachedParticleSystem;

	[NonSerialized]
	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool cachedParticleSystemSet;

	[NonSerialized]
	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<ParticleCollisionEvent> particleCollisionEvents;

	[NonSerialized]
	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int skipCounter;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float ClearRange;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float ClearEfficiency;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float ClearDistance;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private WashProperty washProperty;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int index;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Transform InitialPoint;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private List<WashTime> WashInfo;

	[Token(Token = "0x17000009")]
	public EmitType Emit
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0xE2CF64", Offset = "0xE2CF64", VA = "0xE2CF64")]
		get
		{
			return default(EmitType);
		}
		[Token(Token = "0x6000075")]
		[Address(RVA = "0xE2CF5C", Offset = "0xE2CF5C", VA = "0xE2CF5C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public float RaycastDistance
	{
		[Token(Token = "0x6000078")]
		[Address(RVA = "0xE2CF74", Offset = "0xE2CF74", VA = "0xE2CF74")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000077")]
		[Address(RVA = "0xE2CF6C", Offset = "0xE2CF6C", VA = "0xE2CF6C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public LayerMask Layers
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0xE2CF84", Offset = "0xE2CF84", VA = "0xE2CF84")]
		get
		{
			return default(LayerMask);
		}
		[Token(Token = "0x6000079")]
		[Address(RVA = "0xE2CF7C", Offset = "0xE2CF7C", VA = "0xE2CF7C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public OrientationType Orientation
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0xE2CF94", Offset = "0xE2CF94", VA = "0xE2CF94")]
		get
		{
			return default(OrientationType);
		}
		[Token(Token = "0x600007B")]
		[Address(RVA = "0xE2CF8C", Offset = "0xE2CF8C", VA = "0xE2CF8C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public Camera Camera
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0xE2CFA4", Offset = "0xE2CFA4", VA = "0xE2CFA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600007D")]
		[Address(RVA = "0xE2CF9C", Offset = "0xE2CF9C", VA = "0xE2CF9C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public NormalType Normal
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0xE2CFB4", Offset = "0xE2CFB4", VA = "0xE2CFB4")]
		get
		{
			return default(NormalType);
		}
		[Token(Token = "0x600007F")]
		[Address(RVA = "0xE2CFAC", Offset = "0xE2CFAC", VA = "0xE2CFAC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public float Offset
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0xE2CFC4", Offset = "0xE2CFC4", VA = "0xE2CFC4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000081")]
		[Address(RVA = "0xE2CFBC", Offset = "0xE2CFBC", VA = "0xE2CFBC")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public int Skip
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0xE2CFD4", Offset = "0xE2CFD4", VA = "0xE2CFD4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000083")]
		[Address(RVA = "0xE2CFCC", Offset = "0xE2CFCC", VA = "0xE2CFCC")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public bool Preview
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0xE2CFE8", Offset = "0xE2CFE8", VA = "0xE2CFE8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000085")]
		[Address(RVA = "0xE2CFDC", Offset = "0xE2CFDC", VA = "0xE2CFDC")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public PressureType PressureMode
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0xE2CFF8", Offset = "0xE2CFF8", VA = "0xE2CFF8")]
		get
		{
			return default(PressureType);
		}
		[Token(Token = "0x6000087")]
		[Address(RVA = "0xE2CFF0", Offset = "0xE2CFF0", VA = "0xE2CFF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public float PressureMin
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0xE2D008", Offset = "0xE2D008", VA = "0xE2D008")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000089")]
		[Address(RVA = "0xE2D000", Offset = "0xE2D000", VA = "0xE2D000")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public float PressureMax
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0xE2D018", Offset = "0xE2D018", VA = "0xE2D018")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600008B")]
		[Address(RVA = "0xE2D010", Offset = "0xE2D010", VA = "0xE2D010")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public float PressureConstant
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0xE2D028", Offset = "0xE2D028", VA = "0xE2D028")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600008D")]
		[Address(RVA = "0xE2D020", Offset = "0xE2D020", VA = "0xE2D020")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public float PressureMultiplier
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0xE2D038", Offset = "0xE2D038", VA = "0xE2D038")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600008F")]
		[Address(RVA = "0xE2D030", Offset = "0xE2D030", VA = "0xE2D030")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public GameObject Root
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0xE2D048", Offset = "0xE2D048", VA = "0xE2D048")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000091")]
		[Address(RVA = "0xE2D040", Offset = "0xE2D040", VA = "0xE2D040")]
		set
		{
		}
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xE2D050", Offset = "0xE2D050", VA = "0xE2D050")]
	private void Start()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xE2D0C8", Offset = "0xE2D0C8", VA = "0xE2D0C8")]
	private bool TryGetRaycastHit(ParticleCollisionEvent collision, ref RaycastHit hit)
	{
		return default(bool);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xE2D284", Offset = "0xE2D284", VA = "0xE2D284", Slot = "4")]
	protected virtual void OnParticleCollision(GameObject hitGameObject)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xE2DEC0", Offset = "0xE2DEC0", VA = "0xE2DEC0")]
	private void PlayHitSoundToHotfix(int hitType, Vector3 position)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xE2DD40", Offset = "0xE2DD40", VA = "0xE2DD40")]
	public static Vector3 GetCameraUp([Optional] Camera camera, [Optional] GameObject gameObject)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xE2DEAC", Offset = "0xE2DEAC", VA = "0xE2DEAC")]
	public static bool IndexInMask(int index, int mask)
	{
		return default(bool);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xE2E3E8", Offset = "0xE2E3E8", VA = "0xE2E3E8")]
	public CParticlesHit()
	{
	}
}
[Token(Token = "0x200001C")]
public class CRecovery : MonoBehaviour
{
	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button m_RecoveryButton;

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xE2E520", Offset = "0xE2E520", VA = "0xE2E520")]
	private void Start()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xE2E5FC", Offset = "0xE2E5FC", VA = "0xE2E5FC")]
	public void Recovery()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xE2E6B0", Offset = "0xE2E6B0", VA = "0xE2E6B0")]
	public CRecovery()
	{
	}
}
[Token(Token = "0x200001D")]
public class WashClass
{
	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public WashInfo[] washInfos;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool classWashStatus;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float classProgress;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string Name;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool signHighLightState;

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xE2E6BC", Offset = "0xE2E6BC", VA = "0xE2E6BC")]
	public WashClass()
	{
	}
}
[Token(Token = "0x200001E")]
public class WashInfo
{
	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int washIndex;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int washInfoIndex;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InkCanvas inkCanvas;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material[] materials;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float neatHighLightTimeCount;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int washType;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int washSubType;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int materialType;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ProgressInfo> progressInfos;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float groupProgress;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool washStatus;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float progressThreshold;

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xE2E6C4", Offset = "0xE2E6C4", VA = "0xE2E6C4")]
	public WashInfo()
	{
	}
}
[Token(Token = "0x200001F")]
public class ProgressInfo
{
	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Material material;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float allDirtPixel;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float materialProgress;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture dirtTexture;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool calculateProgressState;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ComputeBuffer computeBuffer;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AsyncGPUReadbackRequest asyncGPUReadbackRequest;

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xE2E74C", Offset = "0xE2E74C", VA = "0xE2E74C")]
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
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CWashMgr <>4__this;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xE334F0", Offset = "0xE334F0", VA = "0xE334F0", Slot = "4")]
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
			[Address(RVA = "0xE33538", Offset = "0xE33538", VA = "0xE33538", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xE3172C", Offset = "0xE3172C", VA = "0xE3172C")]
		[DebuggerHidden]
		public <IUpdateProgres>d__56(int <>1__state)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xE332A8", Offset = "0xE332A8", VA = "0xE332A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xE332AC", Offset = "0xE332AC", VA = "0xE332AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xE334F8", Offset = "0xE334F8", VA = "0xE334F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<WashClass> allNeatHighLightInfo;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<int, WashClass> allWashClass;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve dirtHighLightCurve;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float dirtHighLightTimeCount;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float dirtHighLightTime;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GlobalKeyword dirtHighLightFeatureKeyword;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool bDirtHighLight;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve neatHighLightInfo;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float neatHighLightCurveCount;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float neatHighLightTime;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool bNeatHighLight;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector4 neatHighLightColor;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private WaitForSeconds wfs;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float updateMaterialProgress;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float updateAllMaterialProgress;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int washMaterialCount;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private int washSubCount;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int washCound;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private ComputeShader computeTextureCS;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool isSave;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float saveTimeInterval;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float saveEndTime;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private bool ApplicationFocus;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float AllProgress;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float saveProgress;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private uint allDirtPixel;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private ComputeBuffer cbAllPixel;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private int kernelResize;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private int kernelResizeInit;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private int kernelInit;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private int kernelMain;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int kernelClear;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private RenderTexture clearRenderTexture;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject TestGameObject;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private RenderTexture dirtRenderTexture;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float highLightObjCount;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private byte XRInputIndex;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int washInfoIndex;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private bool isFinish;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float progress;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private WashInfo washInfo;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ProgressInfo progressInfos;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool isAsyncGPUCalculation;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private ComputeBuffer compute_buffer;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private uint[] data;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private WashInfo neatInfo;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private WashInfo dirtHighLightInfo;

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xE2E754", Offset = "0xE2E754", VA = "0xE2E754")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xE2EBAC", Offset = "0xE2EBAC", VA = "0xE2EBAC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xE2F818", Offset = "0xE2F818", VA = "0xE2F818")]
	private void OnWashGameObjectLoadCompleted(Dictionary<string, double> saveClearProgressDatas)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xE2F88C", Offset = "0xE2F88C", VA = "0xE2F88C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xE2FD5C", Offset = "0xE2FD5C", VA = "0xE2FD5C")]
	private void Button1DownEvent(XRControllerSide side)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xE2FF28", Offset = "0xE2FF28", VA = "0xE2FF28")]
	private void SecondaryButtonStarted(InputAction.CallbackContext obj)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xE2FF38", Offset = "0xE2FF38", VA = "0xE2FF38")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xE30010", Offset = "0xE30010", VA = "0xE30010")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xE3063C", Offset = "0xE3063C", VA = "0xE3063C")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xE30D04", Offset = "0xE30D04", VA = "0xE30D04")]
	private void FocusStateAcquired()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xE30DB8", Offset = "0xE30DB8", VA = "0xE30DB8")]
	private void FocusStateLost()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xE30E60", Offset = "0xE30E60", VA = "0xE30E60")]
	private void Button2DownEvent(XRControllerSide side)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xE2EBB0", Offset = "0xE2EBB0", VA = "0xE2EBB0")]
	private void Init()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xE31728", Offset = "0xE31728", VA = "0xE31728")]
	private void SetProgressInfo(ref WashInfo dirtInfo)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xE2EAE4", Offset = "0xE2EAE4", VA = "0xE2EAE4")]
	private void InitComputeShader()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xE30E70", Offset = "0xE30E70", VA = "0xE30E70")]
	private void ShowAllProgress()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xE2FCF4", Offset = "0xE2FCF4", VA = "0xE2FCF4")]
	[IteratorStateMachine(typeof(<IUpdateProgres>d__56))]
	private IEnumerator IUpdateProgres()
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xE2FF48", Offset = "0xE2FF48", VA = "0xE2FF48")]
	public void UpdateProgres()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xE31964", Offset = "0xE31964", VA = "0xE31964")]
	private bool UpdateWashIonfo(WashClass washClass)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xE31754", Offset = "0xE31754", VA = "0xE31754")]
	private bool UpdateWashIonfoDate(WashClass washClass)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xE31614", Offset = "0xE31614", VA = "0xE31614")]
	private void UpdateWashProgressToHotfix(int washType, int mainid, int subinfoid, int subid, float progress)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xE31354", Offset = "0xE31354", VA = "0xE31354")]
	public float ComputeRT(Texture rt, Texture dirtTexture, float allDirtPixel)
	{
		return default(float);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xE307B8", Offset = "0xE307B8", VA = "0xE307B8")]
	[ContextMenu("保存进度和删除进度")]
	public void SaveProgress()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xE32ACC", Offset = "0xE32ACC", VA = "0xE32ACC")]
	public void RemoveProgress(int modetype)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xE326E4", Offset = "0xE326E4", VA = "0xE326E4")]
	private bool SetSaveLeve(int modetype, string progresspath)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xE31218", Offset = "0xE31218", VA = "0xE31218")]
	private string GetProgressPath(int modetype, int level)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xE3261C", Offset = "0xE3261C", VA = "0xE3261C")]
	private string GetProgressPath(int modetype)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xE32E0C", Offset = "0xE32E0C", VA = "0xE32E0C")]
	public void MarkHighLightObj(int[] list, bool isbool)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xE32F24", Offset = "0xE32F24", VA = "0xE32F24")]
	public void SetObjHighLight(WashClass highLightWashClass, bool isbool)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xE322B0", Offset = "0xE322B0", VA = "0xE322B0")]
	public bool NeatHighLight(int key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xE302DC", Offset = "0xE302DC", VA = "0xE302DC")]
	private void UpdateNeatHighLight()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xE2FE1C", Offset = "0xE2FE1C", VA = "0xE2FE1C")]
	public void DirtHighLight()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xE33114", Offset = "0xE33114", VA = "0xE33114")]
	public static void Recovery()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xE30044", Offset = "0xE30044", VA = "0xE30044")]
	private void UpdateDirtHighLight()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xE32814", Offset = "0xE32814", VA = "0xE32814")]
	public bool SaveTextureToPNG(Texture texture, string contents, string pngName)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xE32B94", Offset = "0xE32B94", VA = "0xE32B94")]
	public bool DeleteFile(string file)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xE331C8", Offset = "0xE331C8", VA = "0xE331C8")]
	public CWashMgr()
	{
	}
}
[Token(Token = "0x2000022")]
public enum GunHeadType
{
	[Token(Token = "0x40000E4")]
	ShouShu,
	[Token(Token = "0x40000E5")]
	YaZui,
	[Token(Token = "0x40000E6")]
	KuoSan
}
[Token(Token = "0x2000023")]
public enum SkillType
{
	[Token(Token = "0x40000E8")]
	ClearEfficiency = 1,
	[Token(Token = "0x40000E9")]
	ClearRange,
	[Token(Token = "0x40000EA")]
	ClearDistance
}
[Token(Token = "0x2000024")]
public class LogoWash : MonoBehaviour
{
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xE33540", Offset = "0xE33540", VA = "0xE33540")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xE335C8", Offset = "0xE335C8", VA = "0xE335C8")]
	public LogoWash()
	{
	}
}
[Token(Token = "0x2000025")]
public class CNozzle45New : CWaterEffectBase
{
	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private bool m_CurrMode;

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xE335D0", Offset = "0xE335D0", VA = "0xE335D0", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xE33990", Offset = "0xE33990", VA = "0xE33990")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xE33A54", Offset = "0xE33A54", VA = "0xE33A54")]
	private void SetRayCastCommand(int index, Vector3 rayFrom)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xE33AE4", Offset = "0xE33AE4", VA = "0xE33AE4", Slot = "6")]
	protected override void Shoot()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xE346F0", Offset = "0xE346F0", VA = "0xE346F0")]
	private void SetShooting(bool isPlay)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xE348FC", Offset = "0xE348FC", VA = "0xE348FC", Slot = "9")]
	protected override void AddLimitedField()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xE34A4C", Offset = "0xE34A4C", VA = "0xE34A4C", Slot = "10")]
	protected override void GetPoint(ref Vector3 point)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xE34A90", Offset = "0xE34A90", VA = "0xE34A90", Slot = "7")]
	protected override void ModifySkillPropery(string headType, string skillType, double skillValue)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xE34BFC", Offset = "0xE34BFC", VA = "0xE34BFC", Slot = "8")]
	protected override void ChangeNowMaxHitDistance()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xE34C14", Offset = "0xE34C14", VA = "0xE34C14")]
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
		[Token(Token = "0x40000F2")]
		RaycastHitInfo,
		[Token(Token = "0x40000F3")]
		WorldPoint,
		[Token(Token = "0x40000F4")]
		NearestSurfacePoint,
		[Token(Token = "0x40000F5")]
		DirectUV
	}

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	[SerializeField]
	private bool erase;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x221")]
	private bool m_CurrMode;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
	private Ray ray;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
	private RaycastHit hitInfo;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	private bool isShootSuccessed;

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xE34DF0", Offset = "0xE34DF0", VA = "0xE34DF0", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xE34E14", Offset = "0xE34E14", VA = "0xE34E14")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xE34E18", Offset = "0xE34E18", VA = "0xE34E18", Slot = "6")]
	protected override void Shoot()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xE353AC", Offset = "0xE353AC", VA = "0xE353AC")]
	private void HitEmptySound()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xE35360", Offset = "0xE35360", VA = "0xE35360")]
	private void SetShooting(bool isPlay)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xE35404", Offset = "0xE35404", VA = "0xE35404", Slot = "7")]
	protected override void ModifySkillPropery(string headType, string skillType, double skillValue)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xE35570", Offset = "0xE35570", VA = "0xE35570", Slot = "8")]
	protected override void ChangeNowMaxHitDistance()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xE35584", Offset = "0xE35584", VA = "0xE35584")]
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
		[Token(Token = "0x40000F9")]
		RaycastHitInfo,
		[Token(Token = "0x40000FA")]
		WorldPoint,
		[Token(Token = "0x40000FB")]
		NearestSurfacePoint,
		[Token(Token = "0x40000FC")]
		DirectUV
	}

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private bool m_CurrMode;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public GameObject spherePrefab;

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xE35588", Offset = "0xE35588", VA = "0xE35588", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xE35990", Offset = "0xE35990", VA = "0xE35990")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xE35A54", Offset = "0xE35A54", VA = "0xE35A54", Slot = "7")]
	protected override void ModifySkillPropery(string headType, string skillType, double skillValue)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xE35BC4", Offset = "0xE35BC4", VA = "0xE35BC4", Slot = "8")]
	protected override void ChangeNowMaxHitDistance()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xE35BDC", Offset = "0xE35BDC", VA = "0xE35BDC")]
	private void SetRayCastCommand(int index, Vector3 rayFrom)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xE35C6C", Offset = "0xE35C6C", VA = "0xE35C6C", Slot = "6")]
	protected override void Shoot()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xE36318", Offset = "0xE36318", VA = "0xE36318")]
	private void SetShooting(bool isPlay)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xE36334", Offset = "0xE36334", VA = "0xE36334", Slot = "10")]
	protected override void GetPoint(ref Vector3 point)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xE36364", Offset = "0xE36364", VA = "0xE36364")]
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
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DateTime washTime;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int washType;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xE3698C", Offset = "0xE3698C", VA = "0xE3698C")]
		public WashTime()
		{
		}
	}

	[Token(Token = "0x40000FD")]
	public const float Defult_Water_Distance_Painter = 5f;

	[Token(Token = "0x40000FE")]
	public const float Defult_Water_Distance_Nozzle45 = 4.34f;

	[Token(Token = "0x40000FF")]
	public const float Defult_Water_Distance_Umbrella = 3.48f;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("水枪枪头类型 1-收束 2-鸭嘴 3-扩散")]
	public int waterGunType;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Header("清洗物体层级")]
	public LayerMask layerMask;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("需要动态修改Size的水注模型")]
	public Transform waterModel;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("水雾特效")]
	public ParticleSystem shuiWuEffect;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Header("水花特效模板")]
	public ParticleSystem sprayEffect;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("水注模型比例(0表示对应的轴不需要改变)")]
	public Vector3 modelScaleRatio;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Header("水注烟雾粒子数比例曲线")]
	public AnimationCurve shuiWuEffectAnimationCurve;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Header("最大水注烟雾粒子数量")]
	public int maxShuiWuEffectCount;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[Header("当前最大射中距离")]
	public float nowMaxHitDistance;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Header("当前最小射中距离")]
	public float nowMinHitDistance;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[Header("当前射中距离")]
	public float nowHitDistance;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Header("需要生成的水花数量")]
	public int sprayCount;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[Header("当前最大水花数量")]
	public int nowMaxSprayCount;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Header("清洗效率倍数")]
	public float clearEfficiencyMultiple;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Header("清洗范围倍数")]
	public float clearRangeMultiple;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Header("清洗距离倍数")]
	public float clearDistanceMultiple;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Header("更新频率")]
	public float updateFrameTime;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float update_frame;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected List<ParticleSystem> sprayParticle;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 localScale;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private ParticleSystem sprayParticleSystem;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Transform sprayTransform;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int sprayIndex;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[Header("模拟清洗点的个数")]
	[Header("-----散型 扩散 计算-----")]
	public int pointCount;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected int pointCountIndex;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[Header("生成随机点的圆的半径")]
	public float radius;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[Header("圆形比例")]
	public float xb;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public float yb;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected float xScale;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	protected float yScale;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[Header("椭圆横向长度比例系数")]
	public double widthFactor;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[Header("限制范围")]
	public float calculationDeviation;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[Tooltip("压力常数：使用时的压力值")]
	[Range(0f, 1f)]
	[Header("清洗属性")]
	public float pressureConstant;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	protected float finalPressure;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[Tooltip("笔刷属性")]
	public Brush brush;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	protected NativeArray<RaycastCommand> rayCommands;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	protected NativeArray<RaycastHit> rayCastHits;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	protected RaycastHit raycastHit;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	protected float finalDic;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	protected JobHandle jobHandle;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	protected Vector3 rayFrom;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	protected Vector3 rayDirection;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	protected InkCanvas hitInkCanvas;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	protected Transform hitTransform;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	protected WashBaseInteractable washInteractable;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	protected int materialType;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	protected List<Vector3> RandomPoint;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	protected Vector3 Point;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private double randomValue;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private double r;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private double theta;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	protected double x;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	protected double y;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	protected WashProperty washProperty;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	protected float centerDistance;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private System.Random random;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	protected RaycastCommand raycastCommand;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	protected List<WashTime> WashInfo;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public int[] washCount;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private int max;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
	private int washCountIndex;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	protected int HitIndex;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
	protected bool HitBool;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private float nowDateTime;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
	private float timeDifference;

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xE36368", Offset = "0xE36368", VA = "0xE36368")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xE33750", Offset = "0xE33750", VA = "0xE33750", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xE3643C", Offset = "0xE3643C", VA = "0xE3643C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xE36444", Offset = "0xE36444", VA = "0xE36444")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xE36518", Offset = "0xE36518", VA = "0xE36518", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xE365AC", Offset = "0xE365AC", VA = "0xE365AC", Slot = "6")]
	protected virtual void Shoot()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xE365B0", Offset = "0xE365B0", VA = "0xE365B0", Slot = "7")]
	protected virtual void ModifySkillPropery(string headType, string skillType, double skillValue)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xE365B4", Offset = "0xE365B4", VA = "0xE365B4", Slot = "8")]
	protected virtual void ChangeNowMaxHitDistance()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xE3470C", Offset = "0xE3470C", VA = "0xE3470C")]
	protected void ChangeEffectStartSize()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xE34824", Offset = "0xE34824", VA = "0xE34824")]
	public void PlayWaterFX(bool isPlay)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xE34318", Offset = "0xE34318", VA = "0xE34318")]
	public void PlaySpray(RaycastHit hitInfo)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xE3537C", Offset = "0xE3537C", VA = "0xE3537C")]
	public void PlaySprayPainter(RaycastHit hitInfo)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xE342D0", Offset = "0xE342D0", VA = "0xE342D0")]
	protected void FinalPressure(float distance)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xE34190", Offset = "0xE34190", VA = "0xE34190")]
	protected void Random()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xE34954", Offset = "0xE34954", VA = "0xE34954")]
	protected void AddRandomPoint(int index)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xE365B8", Offset = "0xE365B8", VA = "0xE365B8", Slot = "9")]
	protected virtual void AddLimitedField()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xE365BC", Offset = "0xE365BC", VA = "0xE365BC", Slot = "10")]
	protected virtual void GetPoint(ref Vector3 point)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xE36614", Offset = "0xE36614", VA = "0xE36614")]
	protected float RandomGaussian(float minValue = 0f, float maxValue = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xE357D4", Offset = "0xE357D4", VA = "0xE357D4")]
	protected void CalculationRadian(int count)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xE366C8", Offset = "0xE366C8", VA = "0xE366C8")]
	public void PlayHitSoundToHotfix(int hitType, Vector3 position)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xE344F0", Offset = "0xE344F0", VA = "0xE344F0")]
	public void PlayHitSound(int hitType, Vector3 position)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xE34450", Offset = "0xE34450", VA = "0xE34450")]
	public int MostWashCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xE36994", Offset = "0xE36994", VA = "0xE36994")]
	public void SteHitType(int hitType, Vector3 position)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xE34C18", Offset = "0xE34C18", VA = "0xE34C18")]
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
		[Token(Token = "0x400014A")]
		Metal,
		[Token(Token = "0x400014B")]
		Glass,
		[Token(Token = "0x400014C")]
		Plastic,
		[Token(Token = "0x400014D")]
		Wood,
		[Token(Token = "0x400014E")]
		Stone,
		[Token(Token = "0x400014F")]
		Fibre
	}

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int SelfId;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int WashType;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MaterialType materialType;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float WashScale;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<float> dirtCount;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float progressThreshold;

	[Token(Token = "0x1700001A")]
	public float ProgressThreshold
	{
		[Token(Token = "0x6000104")]
		[Address(RVA = "0xE36A40", Offset = "0xE36A40", VA = "0xE36A40")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000105")]
		[Address(RVA = "0xE36A48", Offset = "0xE36A48", VA = "0xE36A48")]
		set
		{
		}
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xE36A50", Offset = "0xE36A50", VA = "0xE36A50")]
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
		[Token(Token = "0x400015C")]
		Full,
		[Token(Token = "0x400015D")]
		Half,
		[Token(Token = "0x400015E")]
		Third,
		[Token(Token = "0x400015F")]
		Quarter
	}

	[Serializable]
	[Token(Token = "0x2000030")]
	public class PlanarReflectionSettings
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ResolutionMulltiplier m_ResolutionMultiplier;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m_ClipPlaneOffset;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask m_ReflectLayers;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool m_shadows;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool _blurOn;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 5f)]
		public float _blurSize;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 10f)]
		public int _blurIterations;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(1f, 4f)]
		public float _downsample;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xE38608", Offset = "0xE38608", VA = "0xE38608")]
		public PlanarReflectionSettings()
		{
		}
	}

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public PlanarReflectionSettings m_settings;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject target;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("camOffset")]
	public float m_planeOffset;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Camera m_ReflectionCamera;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector2Int m_TextureSize;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RenderTexture m_ReflectionTexture;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RenderTexture m_BlurReflectionTexture;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int planarReflectionTextureID;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private ResolutionMulltiplier m_OldRes;

	[Token(Token = "0x4000159")]
	private const string k_BlurShader = "Hidden/KawaseBlur";

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material _blurMaterial;

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xE36AF4", Offset = "0xE36AF4", VA = "0xE36AF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xE36AF8", Offset = "0xE36AF8", VA = "0xE36AF8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xE36B9C", Offset = "0xE36B9C", VA = "0xE36B9C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xE36D44", Offset = "0xE36D44", VA = "0xE36D44")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xE36BA0", Offset = "0xE36BA0", VA = "0xE36BA0")]
	private void Cleanup()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xE36D48", Offset = "0xE36D48", VA = "0xE36D48")]
	private void SafeDestroy(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xE36DC0", Offset = "0xE36DC0", VA = "0xE36DC0")]
	private void UpdateCamera(Camera src, Camera dest)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xE36E74", Offset = "0xE36E74", VA = "0xE36E74")]
	private void UpdateReflectionCamera(Camera realCamera)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xE377A0", Offset = "0xE377A0", VA = "0xE377A0")]
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xE37834", Offset = "0xE37834", VA = "0xE37834")]
	private static Vector3 ReflectPosition(Vector3 pos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xE379F4", Offset = "0xE379F4", VA = "0xE379F4")]
	private float GetScaleValue()
	{
		return default(float);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xE37A2C", Offset = "0xE37A2C", VA = "0xE37A2C")]
	private static bool Int2Compare(Vector2Int a, Vector2Int b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xE3783C", Offset = "0xE3783C", VA = "0xE3783C")]
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xE37400", Offset = "0xE37400", VA = "0xE37400")]
	private Camera CreateMirrorObjects(Camera currentCamera)
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xE37A54", Offset = "0xE37A54", VA = "0xE37A54")]
	private Vector2Int ReflectionResolution(Camera cam, float scale)
	{
		return default(Vector2Int);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xE37B38", Offset = "0xE37B38", VA = "0xE37B38")]
	public void ExecuteBeforeCameraRender(ScriptableRenderContext context, Camera camera)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xE38538", Offset = "0xE38538", VA = "0xE38538")]
	public PlanarReflections()
	{
	}
}
[Token(Token = "0x2000031")]
public class AnimationWashInteractable : WashBaseInteractable
{
	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator animator;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float hideTime;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int animIDIdle;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private BoxCollider boxCollider;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool runBool;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public BoxCollider boxColliders;

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xE38654", Offset = "0xE38654", VA = "0xE38654")]
	private void Start()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xE3876C", Offset = "0xE3876C", VA = "0xE3876C", Slot = "4")]
	public override void AnimationPlay()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xE38880", Offset = "0xE38880", VA = "0xE38880")]
	public void SetObject()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xE388EC", Offset = "0xE388EC", VA = "0xE388EC")]
	public AnimationWashInteractable()
	{
	}
}
[Token(Token = "0x2000032")]
public class PhysicsWashInteractable : WashBaseInteractable
{
	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource Music;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Collider Colliders;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float Force;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xE3890C", Offset = "0xE3890C", VA = "0xE3890C")]
	private void Start()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xE38A00", Offset = "0xE38A00", VA = "0xE38A00", Slot = "5")]
	public override void AddForce(Vector3 direction, Vector3 point)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xE38B5C", Offset = "0xE38B5C", VA = "0xE38B5C")]
	public PhysicsWashInteractable()
	{
	}
}
[Token(Token = "0x2000033")]
public enum InteractableType
{
	[Token(Token = "0x4000172")]
	Animation,
	[Token(Token = "0x4000173")]
	Physics
}
[Token(Token = "0x2000034")]
public class WashBaseInteractable : MonoBehaviour
{
	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InteractableType WashInteractableType;

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xE38B6C", Offset = "0xE38B6C", VA = "0xE38B6C", Slot = "4")]
	public virtual void AnimationPlay()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xE38B70", Offset = "0xE38B70", VA = "0xE38B70", Slot = "5")]
	public virtual void AddForce(Vector3 direction, Vector3 point)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xE38904", Offset = "0xE38904", VA = "0xE38904")]
	public WashBaseInteractable()
	{
	}
}
[Token(Token = "0x2000035")]
public class ActionBasedController : MonoBehaviour
{
	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ActionBasedControllerManager leftActionBasedController;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ActionBasedControllerManager rightActionBasedController;

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xE38B74", Offset = "0xE38B74", VA = "0xE38B74")]
	private void Start()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xE38D14", Offset = "0xE38D14", VA = "0xE38D14")]
	private void OnLeftEnterTeleportState(ActionBasedControllerManager.StateId previousStateId)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xE38D68", Offset = "0xE38D68", VA = "0xE38D68")]
	private void OnRightEnterTeleportState(ActionBasedControllerManager.StateId previousStateId)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xE38DBC", Offset = "0xE38DBC", VA = "0xE38DBC")]
	private void OnExitTeleportState(ActionBasedControllerManager.StateId nextStateId)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xE38E0C", Offset = "0xE38E0C", VA = "0xE38E0C")]
	public ActionBasedController()
	{
	}
}
[Token(Token = "0x2000036")]
public class TestRay : MonoBehaviour
{
	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Force;

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xE38E14", Offset = "0xE38E14", VA = "0xE38E14")]
	private void Start()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xE38E18", Offset = "0xE38E18", VA = "0xE38E18")]
	private void Update()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xE38E1C", Offset = "0xE38E1C", VA = "0xE38E1C")]
	private void InstanseRay()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xE390FC", Offset = "0xE390FC", VA = "0xE390FC")]
	public TestRay()
	{
	}
}
[Token(Token = "0x2000037")]
public class CSetFoveaTionLevel : MonoBehaviour
{
	[Token(Token = "0x600012C")]
	[Address(RVA = "0xE3910C", Offset = "0xE3910C", VA = "0xE3910C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xE39118", Offset = "0xE39118", VA = "0xE39118")]
	public CSetFoveaTionLevel()
	{
	}
}
namespace Es.InkPainter.Sample
{
	[Token(Token = "0x2000038")]
	public class CWaterGun : MonoBehaviour
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference m_ActiveReference;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InputActionReference m_SecondaryButtonReference;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InputActionReference m_PrimaryButtonReference;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<GameObject> m_ParticleLists;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_nParticIndex;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int m_nIsPlayParticle;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_ShootMode;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool m_ShootingMode;

		[Token(Token = "0x1700001B")]
		public bool ShootMode
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0xE39120", Offset = "0xE39120", VA = "0xE39120")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0xE39128", Offset = "0xE39128", VA = "0xE39128")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool ShootingMode
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xE39134", Offset = "0xE39134", VA = "0xE39134")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0xE3913C", Offset = "0xE3913C", VA = "0xE3913C")]
			set
			{
			}
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE39148", Offset = "0xE39148", VA = "0xE39148")]
		private void Start()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xE393AC", Offset = "0xE393AC", VA = "0xE393AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xE39668", Offset = "0xE39668", VA = "0xE39668")]
		private void ActionStarted(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xE396DC", Offset = "0xE396DC", VA = "0xE396DC")]
		private void CanceledStarted(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE39430", Offset = "0xE39430", VA = "0xE39430")]
		private void SecondaryButtonStarted(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xE395B4", Offset = "0xE395B4", VA = "0xE395B4")]
		private void PrimaryButtonStarted(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xE396E4", Offset = "0xE396E4", VA = "0xE396E4")]
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
			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x6000145")]
			[Address(RVA = "0xE39F08", Offset = "0xE39F08", VA = "0xE39F08")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x6000146")]
			[Address(RVA = "0xE3A65C", Offset = "0xE3A65C", VA = "0xE3A65C")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x6000147")]
			[Address(RVA = "0xE3A6DC", Offset = "0xE3A6DC", VA = "0xE3A6DC")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x6000148")]
			[Address(RVA = "0xE3A764", Offset = "0xE3A764", VA = "0xE3A764")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x6000149")]
			[Address(RVA = "0xE3A960", Offset = "0xE3A960", VA = "0xE3A960")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x4000180")]
		private const float k_MouseSensitivityMultiplier = 0.01f;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Movement Settings")]
		[Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		public float boost;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0.001f, 1f)]
		[Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
		public float positionLerpTime;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Rotation Settings")]
		[Tooltip("Multiplier for the sensitivity of the rotation.")]
		public float mouseSensitivity;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private InputAction movementAction;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InputAction verticalMovementAction;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InputAction lookAction;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InputAction boostFactorAction;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool mouseRightButtonPressed;

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xE39760", Offset = "0xE39760", VA = "0xE39760")]
		private void Start()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE39EB4", Offset = "0xE39EB4", VA = "0xE39EB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xE39F8C", Offset = "0xE39F8C", VA = "0xE39F8C")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE3A028", Offset = "0xE3A028", VA = "0xE3A028")]
		private void Update()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xE3A5FC", Offset = "0xE3A5FC", VA = "0xE3A5FC")]
		private float GetBoostFactor()
		{
			return default(float);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE3A4C0", Offset = "0xE3A4C0", VA = "0xE3A4C0")]
		private Vector2 GetInputLookRotation()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xE3A530", Offset = "0xE3A530", VA = "0xE3A530")]
		private bool IsBoostPressed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xE3A260", Offset = "0xE3A260", VA = "0xE3A260")]
		private bool IsEscapePressed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xE3A380", Offset = "0xE3A380", VA = "0xE3A380")]
		private bool IsCameraRotationAllowed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xE3A2C0", Offset = "0xE3A2C0", VA = "0xE3A2C0")]
		private bool IsRightMouseButtonDown()
		{
			return default(bool);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xE3A320", Offset = "0xE3A320", VA = "0xE3A320")]
		private bool IsRightMouseButtonUp()
		{
			return default(bool);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xE3A7AC", Offset = "0xE3A7AC", VA = "0xE3A7AC")]
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
		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, IManager> modules;

		[Token(Token = "0x1700001D")]
		public static GameObject Root
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xE3A968", Offset = "0xE3A968", VA = "0xE3A968")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xE3A9B8", Offset = "0xE3A9B8", VA = "0xE3A9B8")]
		public static void Init()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xE3AF70", Offset = "0xE3AF70", VA = "0xE3AF70")]
		public static void Start()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xE3B0E8", Offset = "0xE3B0E8", VA = "0xE3B0E8")]
		private static void onApplicationFocus(bool isFocus)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xE3B19C", Offset = "0xE3B19C", VA = "0xE3B19C")]
		public static void Dispose()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xE3B14C", Offset = "0xE3B14C", VA = "0xE3B14C")]
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
		[Token(Token = "0x4000195")]
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
