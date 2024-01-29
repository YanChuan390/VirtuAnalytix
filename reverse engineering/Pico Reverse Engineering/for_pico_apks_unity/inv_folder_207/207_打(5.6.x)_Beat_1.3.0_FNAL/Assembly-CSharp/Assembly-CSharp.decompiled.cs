using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Game.General.Navigation;
using Il2CppDummyDll;
using Unity.XR.PXR;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;
using UnityStandardAssets.Effects;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class AppEntitlementHelper : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CEB28", Offset = "0x5CEB28")]
	private sealed class <>c
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x8")]
		public static PXR_Manager.EntitlementCheckResult <>9__0_0;

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1282ED4", Offset = "0x1282ED4", VA = "0x1282ED4")]
		public <>c()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1282EDC", Offset = "0x1282EDC", VA = "0x1282EDC")]
		internal void <Awake>b__0_0(int errorCode)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x12739F4", Offset = "0x12739F4", VA = "0x12739F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1273B10", Offset = "0x1273B10", VA = "0x1273B10")]
	public AppEntitlementHelper()
	{
	}
}
[Token(Token = "0x2000004")]
public class MenuSceneLoader : MonoBehaviour
{
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x18")]
	public GameObject menuUI;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_Go;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x127E290", Offset = "0x127E290", VA = "0x127E290")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x127E368", Offset = "0x127E368", VA = "0x127E368")]
	public MenuSceneLoader()
	{
	}
}
[Token(Token = "0x2000005")]
public class PauseMenu : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x18")]
	private Toggle m_MenuToggle;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x20")]
	private float m_TimeScaleRef;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x24")]
	private float m_VolumeRef;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x28")]
	private bool m_Paused;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x127FF74", Offset = "0x127FF74", VA = "0x127FF74")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x127FFD0", Offset = "0x127FFD0", VA = "0x127FFD0")]
	private void MenuOn()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1280024", Offset = "0x1280024", VA = "0x1280024")]
	public void MenuOff()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x128005C", Offset = "0x128005C", VA = "0x128005C")]
	public void OnMenuStatusChange()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x12800C4", Offset = "0x12800C4", VA = "0x12800C4")]
	public PauseMenu()
	{
	}
}
[Token(Token = "0x2000006")]
public class SceneAndURLLoader : MonoBehaviour
{
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x18")]
	private PauseMenu m_PauseMenu;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1281630", Offset = "0x1281630", VA = "0x1281630")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x128168C", Offset = "0x128168C", VA = "0x128168C")]
	public void SceneLoad(string sceneName)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1281724", Offset = "0x1281724", VA = "0x1281724")]
	public void LoadURL(string url)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1281730", Offset = "0x1281730", VA = "0x1281730")]
	public SceneAndURLLoader()
	{
	}
}
[Token(Token = "0x2000007")]
public class CameraSwitch : MonoBehaviour
{
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] objects;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x20")]
	public Text text;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x28")]
	private int m_CurrentActiveObject;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x127440C", Offset = "0x127440C", VA = "0x127440C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1274480", Offset = "0x1274480", VA = "0x1274480")]
	public void NextCamera()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1274558", Offset = "0x1274558", VA = "0x1274558")]
	public CameraSwitch()
	{
	}
}
[Token(Token = "0x2000008")]
public class LevelReset : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x127DBE8", Offset = "0x127DBE8", VA = "0x127DBE8", Slot = "4")]
	public void OnPointerClick(PointerEventData data)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x127DC68", Offset = "0x127DC68", VA = "0x127DC68")]
	public LevelReset()
	{
	}
}
[Token(Token = "0x2000009")]
public enum UIType
{
	[Token(Token = "0x400000E")]
	None,
	[Token(Token = "0x400000F")]
	Welcome,
	[Token(Token = "0x4000010")]
	Invocation,
	[Token(Token = "0x4000011")]
	Finish
}
[Token(Token = "0x200000A")]
public class FpsCounter : MonoBehaviour
{
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x18")]
	private float UpdateInterval;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x1C")]
	private int Flames;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x20")]
	private float TimeLeft;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x24")]
	private float Fps;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x28")]
	private float Accum;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x127AE30", Offset = "0x127AE30", VA = "0x127AE30")]
	private void Update()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x127AF70", Offset = "0x127AF70", VA = "0x127AF70")]
	public FpsCounter()
	{
	}
}
[Token(Token = "0x200000B")]
public class LogMessageManager : MonoBehaviour
{
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5CEC2C", Offset = "0x5CEC2C")]
	[SerializeField]
	private GameObject p_TargetDebugPanelObject;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x20")]
	private TextMesh p_Text;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool doesStacktraceInclude;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int p_LineNum;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int p_letterNum;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x38")]
	private string p_TextMessage;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x40")]
	private string newline;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x127DEA8", Offset = "0x127DEA8", VA = "0x127DEA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x127DF24", Offset = "0x127DF24", VA = "0x127DF24")]
	private void Start()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x127DFA4", Offset = "0x127DFA4", VA = "0x127DFA4")]
	private void LogMessageOutput(string condition, string stackTrace, LogType type)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x127E1C0", Offset = "0x127E1C0", VA = "0x127E1C0")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x127E23C", Offset = "0x127E23C", VA = "0x127E23C")]
	public LogMessageManager()
	{
	}
}
[Token(Token = "0x200000C")]
public class CylinderRandom : MonoBehaviour
{
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x127456C", Offset = "0x127456C", VA = "0x127456C")]
	private void Start()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x12745F8", Offset = "0x12745F8", VA = "0x12745F8")]
	private void Update()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x12745FC", Offset = "0x12745FC", VA = "0x12745FC")]
	public CylinderRandom()
	{
	}
}
[Token(Token = "0x200000D")]
public class DestroyFireFlower : MonoBehaviour
{
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x18")]
	public float delay;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x127460C", Offset = "0x127460C", VA = "0x127460C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1274694", Offset = "0x1274694", VA = "0x1274694")]
	private void Update()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1274698", Offset = "0x1274698", VA = "0x1274698")]
	public DestroyFireFlower()
	{
	}
}
[Token(Token = "0x200000E")]
public class FireFlowerTowerManager : MonoBehaviour
{
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject fireFlower1;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x20")]
	public GameObject fireFlower2;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x28")]
	public GameObject fireFlower3;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x30")]
	public Transform spawnPos;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x38")]
	private int lastnumber;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x3C")]
	private int number;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x127A9D4", Offset = "0x127A9D4", VA = "0x127A9D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x127A9D8", Offset = "0x127A9D8", VA = "0x127A9D8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x127A9DC", Offset = "0x127A9DC", VA = "0x127A9DC")]
	public void OnFire()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x127AC4C", Offset = "0x127AC4C", VA = "0x127AC4C")]
	public FireFlowerTowerManager()
	{
	}
}
[Token(Token = "0x200000F")]
public class KirakiraDelay : MonoBehaviour
{
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x18")]
	private AudioSource kirakiraSound;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x20")]
	public float deley;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x28")]
	public Animator fireflowerLight;

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x127DA6C", Offset = "0x127DA6C", VA = "0x127DA6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x127DAD0", Offset = "0x127DAD0", VA = "0x127DAD0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x127DAD4", Offset = "0x127DAD4", VA = "0x127DAD4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x127DB80", Offset = "0x127DB80", VA = "0x127DB80")]
	public void OnFireflowerLight()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x127DBD8", Offset = "0x127DBD8", VA = "0x127DBD8")]
	public KirakiraDelay()
	{
	}
}
[Token(Token = "0x2000010")]
public class RobotBDoorSwitch : MonoBehaviour
{
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x18")]
	public Animator robotBdoorAnim;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1281564", Offset = "0x1281564", VA = "0x1281564")]
	private void Start()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x12815C8", Offset = "0x12815C8", VA = "0x12815C8")]
	private void Update()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x12815CC", Offset = "0x12815CC", VA = "0x12815CC")]
	public void OnRobotBDoorLight()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x127A3C8", Offset = "0x127A3C8", VA = "0x127A3C8")]
	public void OffRobotBDoorLight()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1281628", Offset = "0x1281628", VA = "0x1281628")]
	public RobotBDoorSwitch()
	{
	}
}
[Token(Token = "0x2000011")]
public class TestCube : MonoBehaviour
{
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x18")]
	private Animator testCubeAnim;

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1281DF8", Offset = "0x1281DF8", VA = "0x1281DF8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1281E54", Offset = "0x1281E54", VA = "0x1281E54")]
	private void Update()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1281E58", Offset = "0x1281E58", VA = "0x1281E58")]
	public void OnTestCubeExpload()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1281EB0", Offset = "0x1281EB0", VA = "0x1281EB0")]
	public TestCube()
	{
	}
}
[Token(Token = "0x2000012")]
public class TestCubeAnim : MonoBehaviour
{
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x18")]
	public PlayableDirector timeline2;

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1281EB8", Offset = "0x1281EB8", VA = "0x1281EB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1281F1C", Offset = "0x1281F1C", VA = "0x1281F1C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1281F20", Offset = "0x1281F20", VA = "0x1281F20")]
	public void OnTimeline2()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1281FAC", Offset = "0x1281FAC", VA = "0x1281FAC")]
	public TestCubeAnim()
	{
	}
}
[Token(Token = "0x2000013")]
public class SwapMaterial : MonoBehaviour
{
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Material enMaterial;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material zhMaterial;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Renderer targetRenderer;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x30")]
	private Material m_material;

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1281CB4", Offset = "0x1281CB4", VA = "0x1281CB4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1281D1C", Offset = "0x1281D1C", VA = "0x1281D1C")]
	private void Start()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1281DF0", Offset = "0x1281DF0", VA = "0x1281DF0")]
	public SwapMaterial()
	{
	}
}
[Token(Token = "0x2000014")]
public class NewBehaviourScript : MonoBehaviour
{
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x127E5A4", Offset = "0x127E5A4", VA = "0x127E5A4")]
	private void Start()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x127E5A8", Offset = "0x127E5A8", VA = "0x127E5A8")]
	private void Update()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x127E5AC", Offset = "0x127E5AC", VA = "0x127E5AC")]
	public NewBehaviourScript()
	{
	}
}
[Token(Token = "0x2000015")]
public class PlayableDirecterEventA : MonoBehaviour
{
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x18")]
	private SphereCollider sCollider;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x20")]
	private GameObject embers;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x28")]
	private Transform emberTransform;

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x128027C", Offset = "0x128027C", VA = "0x128027C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x12803B4", Offset = "0x12803B4", VA = "0x12803B4")]
	public void ONCollider()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1280404", Offset = "0x1280404", VA = "0x1280404")]
	public void OFFCollider()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1280454", Offset = "0x1280454", VA = "0x1280454")]
	public PlayableDirecterEventA()
	{
	}
}
[Token(Token = "0x2000016")]
public class PlayableDirecterEventB : MonoBehaviour
{
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x18")]
	private SphereCollider sCollider;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x20")]
	private AudioSource bgm;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x128045C", Offset = "0x128045C", VA = "0x128045C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x12804F0", Offset = "0x12804F0", VA = "0x12804F0")]
	public void ONCollider()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1280540", Offset = "0x1280540", VA = "0x1280540")]
	public void OFFCollider()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1280590", Offset = "0x1280590", VA = "0x1280590")]
	public PlayableDirecterEventB()
	{
	}
}
[Token(Token = "0x2000017")]
public class PlayableDirecterEventC : MonoBehaviour
{
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x18")]
	private SphereCollider sCollider;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x20")]
	public MeshRenderer breakHeartL;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x28")]
	public MeshRenderer breakHeartR;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x30")]
	private GameObject embers;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x38")]
	private Transform emberTransform;

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1280598", Offset = "0x1280598", VA = "0x1280598")]
	private void Start()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1280734", Offset = "0x1280734", VA = "0x1280734")]
	public void OnBreakHeart()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1280778", Offset = "0x1280778", VA = "0x1280778")]
	public void ONCollider()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x12807C8", Offset = "0x12807C8", VA = "0x12807C8")]
	public void OFFCollider()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1280818", Offset = "0x1280818", VA = "0x1280818")]
	public PlayableDirecterEventC()
	{
	}
}
[Token(Token = "0x2000018")]
public class PlayableDirecterEventD : MonoBehaviour
{
	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x18")]
	private SphereCollider sCollider;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x20")]
	private AudioSource bgm;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x28")]
	private GameObject embers;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x30")]
	private Transform emberTransform;

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1280820", Offset = "0x1280820", VA = "0x1280820")]
	private void Start()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1280958", Offset = "0x1280958", VA = "0x1280958")]
	public void PlayBGM()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1280974", Offset = "0x1280974", VA = "0x1280974")]
	public void ONCollider()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x12809C4", Offset = "0x12809C4", VA = "0x12809C4")]
	public void OFFCollider()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1280A14", Offset = "0x1280A14", VA = "0x1280A14")]
	public PlayableDirecterEventD()
	{
	}
}
[Token(Token = "0x2000019")]
public class PlayableDirecterEventE : MonoBehaviour
{
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x18")]
	private SphereCollider sCollider;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1280A1C", Offset = "0x1280A1C", VA = "0x1280A1C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1280AB0", Offset = "0x1280AB0", VA = "0x1280AB0")]
	public void ONCollider()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1280B00", Offset = "0x1280B00", VA = "0x1280B00")]
	public void OFFCollider()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1280B50", Offset = "0x1280B50", VA = "0x1280B50")]
	public PlayableDirecterEventE()
	{
	}
}
[Token(Token = "0x200001A")]
public class PlayableDirecterEventF : MonoBehaviour
{
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x18")]
	private SphereCollider sCollider;

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1280B58", Offset = "0x1280B58", VA = "0x1280B58")]
	private void Start()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1280BEC", Offset = "0x1280BEC", VA = "0x1280BEC")]
	public void ONCollider()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1280C3C", Offset = "0x1280C3C", VA = "0x1280C3C")]
	public void OFFCollider()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1280C8C", Offset = "0x1280C8C", VA = "0x1280C8C")]
	public PlayableDirecterEventF()
	{
	}
}
[Token(Token = "0x200001B")]
public class AirPlaneModel : MonoBehaviour
{
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject airPlaneBurstPrefab;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x20")]
	public GameObject airPlaneLightPrefab;

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1273844", Offset = "0x1273844", VA = "0x1273844")]
	private void Start()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1273848", Offset = "0x1273848", VA = "0x1273848")]
	private void Update()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x127384C", Offset = "0x127384C", VA = "0x127384C")]
	public void OnHeartLight()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x12739EC", Offset = "0x12739EC", VA = "0x12739EC")]
	public AirPlaneModel()
	{
	}
}
[Token(Token = "0x200001C")]
public class Attacher : MonoBehaviour
{
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x18")]
	public string targetName;

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1273B18", Offset = "0x1273B18", VA = "0x1273B18")]
	private void Awake()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1273BB4", Offset = "0x1273BB4", VA = "0x1273BB4")]
	private void Start()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1273BB8", Offset = "0x1273BB8", VA = "0x1273BB8")]
	public Attacher()
	{
	}
}
[Token(Token = "0x200001D")]
public class BGMManager : MonoBehaviour
{
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x18")]
	public AudioSource[] bgm;

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1273BC0", Offset = "0x1273BC0", VA = "0x1273BC0")]
	public void OnBGM(int number)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1273CBC", Offset = "0x1273CBC", VA = "0x1273CBC")]
	public void OffBGM(int number)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1273DB8", Offset = "0x1273DB8", VA = "0x1273DB8")]
	public BGMManager()
	{
	}
}
[Token(Token = "0x200001E")]
public class BeamLength : MonoBehaviour
{
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x18")]
	public Transform sColliderA_Bpos;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x20")]
	public Transform sColliderB_Cpos;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x28")]
	public Transform sColliderC_Dpos;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x30")]
	public Transform sColliderD_Epos;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x38")]
	public Transform sColliderE_Fpos;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x40")]
	public bool sColliderA_B;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x41")]
	public bool sColliderB_C;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x42")]
	public bool sColliderC_D;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x43")]
	public bool sColliderD_E;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x44")]
	public bool sColliderE_F;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x48")]
	private ParticleSystem ps;

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1273DC0", Offset = "0x1273DC0", VA = "0x1273DC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1273E1C", Offset = "0x1273E1C", VA = "0x1273E1C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x12740F4", Offset = "0x12740F4", VA = "0x12740F4")]
	public BeamLength()
	{
	}
}
[Token(Token = "0x200001F")]
public class BeamLength_Others : MonoBehaviour
{
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x18")]
	public Transform subA_HeartPos;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x20")]
	public Transform subB_HeartPos;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x28")]
	public Transform player_HeartPos;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x30")]
	public Transform robotA_Revival_HeartPos;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x38")]
	public Transform robotB_HeartPos;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x40")]
	public bool subAtoSubB;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x41")]
	public bool subBtoSubA;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x42")]
	public bool robotAtoB;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x43")]
	public bool robotBtoA;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x44")]
	public bool playerToStaff;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x48")]
	public ParticleSystem subA_PS;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x50")]
	public ParticleSystem subB_PS;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x58")]
	public ParticleSystem robotA_PS;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x60")]
	public ParticleSystem robotB_PS;

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x12740FC", Offset = "0x12740FC", VA = "0x12740FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x12741D4", Offset = "0x12741D4", VA = "0x12741D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1274404", Offset = "0x1274404", VA = "0x1274404")]
	public BeamLength_Others()
	{
	}
}
[Token(Token = "0x2000020")]
public class ConfigSettings
{
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x0")]
	public static bool isChineseVersion;

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1274560", Offset = "0x1274560", VA = "0x1274560")]
	public ConfigSettings()
	{
	}
}
[Token(Token = "0x2000021")]
public class DashbordDisable : MonoBehaviour
{
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x18")]
	private bool dashbordFlag;

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1274604", Offset = "0x1274604", VA = "0x1274604")]
	public DashbordDisable()
	{
	}
}
[Token(Token = "0x2000022")]
public class DestroyObj : MonoBehaviour
{
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x18")]
	public float time;

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x12746A8", Offset = "0x12746A8", VA = "0x12746A8")]
	private void Start()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1274730", Offset = "0x1274730", VA = "0x1274730")]
	private void Update()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1274734", Offset = "0x1274734", VA = "0x1274734")]
	public DestroyObj()
	{
	}
}
[Token(Token = "0x2000023")]
public class DummyMyHeart : MonoBehaviour
{
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject heartLight;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x20")]
	public GameObject playerBurstPrefab;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x28")]
	public Transform heartLightPos;

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1274F8C", Offset = "0x1274F8C", VA = "0x1274F8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1274FB4", Offset = "0x1274FB4", VA = "0x1274FB4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1274FB8", Offset = "0x1274FB8", VA = "0x1274FB8")]
	public void OnHeartLight()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1275130", Offset = "0x1275130", VA = "0x1275130")]
	public void DestoryDummyHeart()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x12751A8", Offset = "0x12751A8", VA = "0x12751A8")]
	public DummyMyHeart()
	{
	}
}
[Token(Token = "0x2000024")]
public class EventManager : MonoBehaviour
{
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x18")]
	private GameManager gameManager;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x20")]
	private Animator signalAnim;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x28")]
	private Animator airPlaneAnim;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x30")]
	private HeartModel heartModelComp;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x38")]
	private ParticleSystemBurst psSystemBurst;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x40")]
	private Animator breakHeartRAnim;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x48")]
	private Animator breakHeartLAnim;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x50")]
	private Animator s00WaitLight;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x58")]
	private Animator s01WaitLight;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x60")]
	private Animator s02WaitLight;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x68")]
	private Animator s03WaitLight;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x70")]
	private Animator robotA_revival_Heart_Anim;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x78")]
	private Animator robotB_Heart_Anim;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x80")]
	private Animator subA_Heart_Anim;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x88")]
	private Animator subB_Heart_Anim;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x90")]
	private Animator e_Itoh_Anim;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x98")]
	private Animator e_Hashimoto_Anim;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0xA0")]
	private Animator e_Morishita_Anim;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0xA8")]
	private Animator e_Machiba_Anim;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0xB0")]
	private Animator e_Ohashi_Anim;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0xB8")]
	private Animator e_Fujioka_Anim;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0xC0")]
	private Animator fireFlowerTower_L1;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0xC8")]
	private Animator fireFlowerTower_L2;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0xD0")]
	private Animator fireFlowerTower_L3;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0xD8")]
	private Animator fireFlowerTower_S1;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0xE0")]
	private Animator fireFlowerTower_S2;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0xE8")]
	private Animator fireFlowerTower_S3;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0xF0")]
	private Animator fireFlowerTower_S4;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0xF8")]
	private Animator fireFlowerTower_S5;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x100")]
	private Animator factoryLight1;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x108")]
	private Animator factoryLight2;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x110")]
	private Animator factoryLight3;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x118")]
	private Animator factoryLight4;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x120")]
	private ParticleSystem airPlanePS;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x128")]
	private ParticleSystem heartBreakPS;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x130")]
	private Animator titleLogoAnim;

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x138")]
	public GameObject changeMiniLightBurst;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x140")]
	public Transform changeMiniLightBurst1Pos;

	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x148")]
	public Transform changeMiniLightBurst2Pos;

	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x150")]
	public GameObject changeSwitchPS;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x158")]
	public Transform changeSwitchPos;

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x160")]
	private GameObject titleHeart;

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1276140", Offset = "0x1276140", VA = "0x1276140")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x127693C", Offset = "0x127693C", VA = "0x127693C")]
	public void OnTitleLogo()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1276ACC", Offset = "0x1276ACC", VA = "0x1276ACC")]
	public void OffTitleLogo()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1276B6C", Offset = "0x1276B6C", VA = "0x1276B6C")]
	public void OnHeartBreakPS()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1276B88", Offset = "0x1276B88", VA = "0x1276B88")]
	public void OnAirPlaneFlyingPS()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1276BEC", Offset = "0x1276BEC", VA = "0x1276BEC")]
	public void OffAirPlaneFlyingPS()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1276C4C", Offset = "0x1276C4C", VA = "0x1276C4C")]
	public void OnRobotHeart()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1276C6C", Offset = "0x1276C6C", VA = "0x1276C6C")]
	public void OffRobotHeart()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1276C88", Offset = "0x1276C88", VA = "0x1276C88")]
	public void OnRobotHeartBurst()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1276CA8", Offset = "0x1276CA8", VA = "0x1276CA8")]
	public void OffRobotHeartBurst()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1276CC4", Offset = "0x1276CC4", VA = "0x1276CC4")]
	public void OnAirPlaneBurst()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1276CE4", Offset = "0x1276CE4", VA = "0x1276CE4")]
	public void OffAirPlaneBurst()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1276D00", Offset = "0x1276D00", VA = "0x1276D00")]
	public void OnFireFlowerTowerL1()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1276D5C", Offset = "0x1276D5C", VA = "0x1276D5C")]
	public void OffFireFlowerTowerL1()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1276DB8", Offset = "0x1276DB8", VA = "0x1276DB8")]
	public void OnFireFlowerTowerL2()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1276E14", Offset = "0x1276E14", VA = "0x1276E14")]
	public void OffFireFlowerTowerL2()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1276E70", Offset = "0x1276E70", VA = "0x1276E70")]
	public void OnFireFlowerTowerL3()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1276ECC", Offset = "0x1276ECC", VA = "0x1276ECC")]
	public void OffFireFlowerTowerL3()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1276F28", Offset = "0x1276F28", VA = "0x1276F28")]
	public void OnFireFlowerTowerS1()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1276F84", Offset = "0x1276F84", VA = "0x1276F84")]
	public void OffFireFlowerTowerS1()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1276FE0", Offset = "0x1276FE0", VA = "0x1276FE0")]
	public void OnFireFlowerTowerS2()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x127703C", Offset = "0x127703C", VA = "0x127703C")]
	public void OffFireFlowerTowerS2()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1277098", Offset = "0x1277098", VA = "0x1277098")]
	public void OnFireFlowerTowerS3()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x12770F4", Offset = "0x12770F4", VA = "0x12770F4")]
	public void OffFireFlowerTowerS3()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1277150", Offset = "0x1277150", VA = "0x1277150")]
	public void OnFireFlowerTowerS4()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x12771AC", Offset = "0x12771AC", VA = "0x12771AC")]
	public void OffFireFlowerTowerS4()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1277208", Offset = "0x1277208", VA = "0x1277208")]
	public void OnFireFlowerTowerS5()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1277264", Offset = "0x1277264", VA = "0x1277264")]
	public void OffFireFlowerTowerS5()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x12772C0", Offset = "0x12772C0", VA = "0x12772C0")]
	public void OnEndingHeartDokiDoki_RobotA_Revival()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x127731C", Offset = "0x127731C", VA = "0x127731C")]
	public void OnEndingHeartDokiDoki_RobotB()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1277378", Offset = "0x1277378", VA = "0x1277378")]
	public void OnEndingHeartDokiDoki_SubA()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x12773D4", Offset = "0x12773D4", VA = "0x12773D4")]
	public void OnEndingHeartDokiDoki_SubB()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1277430", Offset = "0x1277430", VA = "0x1277430")]
	public void OffEndingHeartDokiDoki_RobotA_Revival()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x127748C", Offset = "0x127748C", VA = "0x127748C")]
	public void OffEndingHeartDokiDoki_RobotB()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x12774E8", Offset = "0x12774E8", VA = "0x12774E8")]
	public void OffEndingHeartDokiDoki_SubA()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1277544", Offset = "0x1277544", VA = "0x1277544")]
	public void OffEndingHeartDokiDoki_SubB()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x12775A0", Offset = "0x12775A0", VA = "0x12775A0")]
	public void OnEndingHeartDokiDoki_Itoh()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x12775FC", Offset = "0x12775FC", VA = "0x12775FC")]
	public void OnEndingHeartDokiDoki_Hashimoto()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1277658", Offset = "0x1277658", VA = "0x1277658")]
	public void OnEndingHeartDokiDoki_Morishita()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x12776B4", Offset = "0x12776B4", VA = "0x12776B4")]
	public void OnEndingHeartDokiDoki_Machiba()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1277710", Offset = "0x1277710", VA = "0x1277710")]
	public void OnEndingHeartDokiDoki_Ohashi()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x127776C", Offset = "0x127776C", VA = "0x127776C")]
	public void OnEndingHeartDokiDoki_Fujioka()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x12777C8", Offset = "0x12777C8", VA = "0x12777C8")]
	public void OffAllEndingHearts()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x127789C", Offset = "0x127789C", VA = "0x127789C")]
	public void OnS00WaitLight()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x12778F8", Offset = "0x12778F8", VA = "0x12778F8")]
	public void OffS00WaitLight()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1277954", Offset = "0x1277954", VA = "0x1277954")]
	public void OnS01WaitLight()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x12779B0", Offset = "0x12779B0", VA = "0x12779B0")]
	public void OffS01WaitLight()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1277A0C", Offset = "0x1277A0C", VA = "0x1277A0C")]
	public void OnS02WaitLight()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1277A68", Offset = "0x1277A68", VA = "0x1277A68")]
	public void OffS02WaitLight()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1277AC4", Offset = "0x1277AC4", VA = "0x1277AC4")]
	public void OnS03WaitLight()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1277B20", Offset = "0x1277B20", VA = "0x1277B20")]
	public void OffS03WaitLight()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1277B7C", Offset = "0x1277B7C", VA = "0x1277B7C")]
	public void OnTitleHeartLight()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1277B9C", Offset = "0x1277B9C", VA = "0x1277B9C")]
	public void OffTitleHeartLight()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1277BB8", Offset = "0x1277BB8", VA = "0x1277BB8")]
	public void OnRobotDoor()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1277C44", Offset = "0x1277C44", VA = "0x1277C44")]
	public void OffRobotDoor()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1277C60", Offset = "0x1277C60", VA = "0x1277C60")]
	public void OnRobotDoorBlue()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1277C80", Offset = "0x1277C80", VA = "0x1277C80")]
	public void OffRobotDoorBlue()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1277C9C", Offset = "0x1277C9C", VA = "0x1277C9C")]
	public void ChangeSignal(int number)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1277D6C", Offset = "0x1277D6C", VA = "0x1277D6C")]
	public void ChangeSwitch()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1277E7C", Offset = "0x1277E7C", VA = "0x1277E7C")]
	public void AirPlaneLightOn()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1277ED8", Offset = "0x1277ED8", VA = "0x1277ED8")]
	public void AirPlaneLightOff()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1277F34", Offset = "0x1277F34", VA = "0x1277F34")]
	public void BreakHeartLightOn()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1277FA8", Offset = "0x1277FA8", VA = "0x1277FA8")]
	public void BreakHeartLightOff()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x127801C", Offset = "0x127801C", VA = "0x127801C")]
	public void OnChangeMiniLightBurst1()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x127811C", Offset = "0x127811C", VA = "0x127811C")]
	public void OnChangeMiniLightBurst2()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x127821C", Offset = "0x127821C", VA = "0x127821C")]
	public EventManager()
	{
	}
}
[Token(Token = "0x2000025")]
public class EventManager_2 : MonoBehaviour
{
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject connectBurstPrefab_Robot;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject connectBurstPrefab_RobotRevival;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject connectBurstPrefab_SubA;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject connectBurstPrefab_SubB;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x38")]
	public GameObject connectBurstPrefab_RobotB;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x40")]
	public GameObject connectBurstPrefab_final;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x48")]
	public Transform burstPos_AtoB;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x50")]
	public Transform burstPos_BtoC;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x58")]
	public Transform burstPos_CtoD;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x60")]
	public Transform burstPos_DtoE;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x68")]
	public Transform burstPos_EtoF;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x70")]
	public Transform robotRevival_burstPos;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x78")]
	public Transform subA_burstPos;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x80")]
	public Transform subB_burstPos;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x88")]
	public Transform robotB_burstPos;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x90")]
	private Animator robotHeartAnim;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x98")]
	private Animator robotHeartRevivalAnim;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0xA0")]
	private Animator subAHeartAnim;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0xA8")]
	private Animator subBHeartAnim;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0xB0")]
	private Animator robotBHeartAnim;

	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0xB8")]
	private ParticleSystem robotHeartPS;

	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0xC0")]
	private ParticleSystem subAHeartPS;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0xC8")]
	private ParticleSystem subBHeartPS;

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0xD0")]
	private ParticleSystem robotBHeartPS;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0xD8")]
	private ParticleSystem staffHeartPS;

	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject breakFallPS_Prefab;

	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0xE8")]
	public Transform breakFallPS_Pos;

	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0xF0")]
	private Animator belt1;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0xF8")]
	private Animator belt2;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x100")]
	private HeartModel heartModel;

	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x108")]
	public GameObject playerBurst_sound;

	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x110")]
	public GameObject playerBurst_nosound;

	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x118")]
	private AudioSource heartBeatSound;

	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x120")]
	private HeartModel heartModelComp;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x128")]
	public GameObject dummyHeartLight;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x130")]
	public Animator placeYourHeartA_B;

	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x138")]
	public Animator placeYourHeartB_C;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x140")]
	public Animator placeYourHeartC_D;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x148")]
	public Animator placeYourHeartD_E;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x150")]
	public Animator placeYourHeartE_F;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x158")]
	private Animator lightBelt1;

	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x160")]
	private Animator lightBelt2;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x168")]
	private Animator lightBelt3;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x170")]
	private Animator rotateLight1;

	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x178")]
	private Animator rotateLight2;

	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x180")]
	public Animator cylinderAnim01;

	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x188")]
	public Animator cylinderAnim02;

	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x190")]
	public Animator cylinderAnim03;

	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x198")]
	public Animator cylinderAnim04;

	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x1A0")]
	public Animator cylinderAnim05;

	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x1A8")]
	public Animator cylinderAnim06;

	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x1B0")]
	public Animator cylinderAnim07;

	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x1B8")]
	public Animator cylinderAnim08;

	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x1C0")]
	public Animator cylinderAnim09;

	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x1C8")]
	public Animator cylinderAnim10;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x1D0")]
	public Animator cylinderAnim11;

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x1D8")]
	public Animator cylinderAnim12;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x1E0")]
	private Animator[] cylinderAnim;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x1E8")]
	private Animator darkPlane;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x1F0")]
	private Animator pressSpaceText;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x1F8")]
	public GameObject dummyMyHeart;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x200")]
	public GameObject endDummyMyHeart;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x208")]
	public Transform dummyMyHeartPos;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x210")]
	public GameObject dummyMyHeartBurstPrefab;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x218")]
	public Animator dummyMyHeartAnim;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x220")]
	public Animator endDummyMyHeartAnim;

	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x228")]
	public ParticleSystem smokeAps;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x230")]
	public ParticleSystem smokeBps;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x238")]
	public RobotBDoorSwitch robotBDoorSwitch;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x240")]
	public MeshRenderer gear1;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x248")]
	public MeshRenderer gear2;

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1278224", Offset = "0x1278224", VA = "0x1278224")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1278B78", Offset = "0x1278B78", VA = "0x1278B78")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1278B7C", Offset = "0x1278B7C", VA = "0x1278B7C")]
	public void OnPressSpaceText()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1278BEC", Offset = "0x1278BEC", VA = "0x1278BEC")]
	public void OnDarkPlane()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1278C48", Offset = "0x1278C48", VA = "0x1278C48")]
	public void OffDarkPlane()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1278CA4", Offset = "0x1278CA4", VA = "0x1278CA4")]
	public void OnLightBelt()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1278E80", Offset = "0x1278E80", VA = "0x1278E80")]
	public void OnPlaceYourHeartA_B()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1278EDC", Offset = "0x1278EDC", VA = "0x1278EDC")]
	public void OnPlaceYourHeartB_C()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1278F38", Offset = "0x1278F38", VA = "0x1278F38")]
	public void OnPlaceYourHeartC_D()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1278F94", Offset = "0x1278F94", VA = "0x1278F94")]
	public void OnPlaceYourHeartD_E()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1278FF0", Offset = "0x1278FF0", VA = "0x1278FF0")]
	public void OnPlaceYourHeartE_F()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x127904C", Offset = "0x127904C", VA = "0x127904C")]
	public void ChangeNoLight()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1279050", Offset = "0x1279050", VA = "0x1279050")]
	public void OnHeartSound()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1279094", Offset = "0x1279094", VA = "0x1279094")]
	public void OffHeartSound()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x12790D8", Offset = "0x12790D8", VA = "0x12790D8")]
	public void OnBreakFallPS()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x12791D8", Offset = "0x12791D8", VA = "0x12791D8")]
	public void OnBelt1()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1279234", Offset = "0x1279234", VA = "0x1279234")]
	public void OnBelt2()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1279290", Offset = "0x1279290", VA = "0x1279290")]
	public void OnRobotConnectHeartPS()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x12792F4", Offset = "0x12792F4", VA = "0x12792F4")]
	public void OffRobotConnectHeartPS()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1279354", Offset = "0x1279354", VA = "0x1279354")]
	public void OnSubAConnectHeartPS()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x12793B8", Offset = "0x12793B8", VA = "0x12793B8")]
	public void OffSubAConnectHeartPS()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1279418", Offset = "0x1279418", VA = "0x1279418")]
	public void OnSubBConnectHeartPS()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x127947C", Offset = "0x127947C", VA = "0x127947C")]
	public void OffSubBConnectHeartPS()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x12794DC", Offset = "0x12794DC", VA = "0x12794DC")]
	public void OnRobotBConnectHeartPS()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1279540", Offset = "0x1279540", VA = "0x1279540")]
	public void OffRobotBConnectHeartPS()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x12795A0", Offset = "0x12795A0", VA = "0x12795A0")]
	public void OnStaffConnectHeartPS()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x12795BC", Offset = "0x12795BC", VA = "0x12795BC")]
	public void OffStaffConnectHeartPS()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x127961C", Offset = "0x127961C", VA = "0x127961C")]
	public void OnConnectBurst_AtoB()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1279744", Offset = "0x1279744", VA = "0x1279744")]
	public void OnConnectBurst_BtoC()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x127986C", Offset = "0x127986C", VA = "0x127986C")]
	public void OnConnectBurst_CtoD()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1279994", Offset = "0x1279994", VA = "0x1279994")]
	public void OnConnectBurst_DtoE()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1279ABC", Offset = "0x1279ABC", VA = "0x1279ABC")]
	public void OnConnectBurst_EtoF()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1279BE4", Offset = "0x1279BE4", VA = "0x1279BE4")]
	public void OnConnectBurst_RobotRevival()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1279D0C", Offset = "0x1279D0C", VA = "0x1279D0C")]
	public void OnConnectBurst_SubA()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1279E34", Offset = "0x1279E34", VA = "0x1279E34")]
	public void OnConnectBurst_SubB()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1279F5C", Offset = "0x1279F5C", VA = "0x1279F5C")]
	public void OnConnectBurst_RobotB()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x127A084", Offset = "0x127A084", VA = "0x127A084")]
	public void DummyMyHeartBurst()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x127A1D8", Offset = "0x127A1D8", VA = "0x127A1D8")]
	public void OffHeart()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x127A210", Offset = "0x127A210", VA = "0x127A210")]
	public void OnEndDummyHeart()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x127A230", Offset = "0x127A230", VA = "0x127A230")]
	public void OnSmokeA()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x127A290", Offset = "0x127A290", VA = "0x127A290")]
	public void OffSmokeA()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x127A2F0", Offset = "0x127A2F0", VA = "0x127A2F0")]
	public void OnSmokeB()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x127A350", Offset = "0x127A350", VA = "0x127A350")]
	public void OffSmokeB()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x127A3B0", Offset = "0x127A3B0", VA = "0x127A3B0")]
	public void OffRobotBDoorLight()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x127A424", Offset = "0x127A424", VA = "0x127A424")]
	public void OnGearMeshRenderer()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x127A468", Offset = "0x127A468", VA = "0x127A468")]
	public EventManager_2()
	{
	}
}
[Token(Token = "0x2000026")]
public class ExchangeSystem : MonoBehaviour
{
	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x18")]
	public Animator robotAnim;

	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x20")]
	public Animator trueHeartAnim;

	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x28")]
	public MeshRenderer heartMeshRenderer;

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x127A470", Offset = "0x127A470", VA = "0x127A470")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x127A634", Offset = "0x127A634", VA = "0x127A634")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x127A638", Offset = "0x127A638", VA = "0x127A638")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x127A750", Offset = "0x127A750", VA = "0x127A750")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x127A890", Offset = "0x127A890", VA = "0x127A890")]
	public ExchangeSystem()
	{
	}
}
[Token(Token = "0x2000027")]
public class FireFlowerTower : MonoBehaviour
{
	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem fireworksPs;

	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem fireworksStartPs;

	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x28")]
	public Animator light;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x30")]
	public AudioSource SoundKirakira;

	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x38")]
	public AudioSource SoundStart;

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x127A898", Offset = "0x127A898", VA = "0x127A898")]
	private void Start()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x127A9BC", Offset = "0x127A9BC", VA = "0x127A9BC")]
	public void OnFire()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x127A9CC", Offset = "0x127A9CC", VA = "0x127A9CC")]
	public FireFlowerTower()
	{
	}
}
[Token(Token = "0x2000028")]
public class FireworksManager : MonoBehaviour
{
	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem[] fireworks;

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x127AC54", Offset = "0x127AC54", VA = "0x127AC54")]
	public void OnFireworks(int number)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x127AD50", Offset = "0x127AD50", VA = "0x127AD50")]
	public FireworksManager()
	{
	}
}
[Token(Token = "0x2000029")]
public class Follow : MonoBehaviour
{
	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x18")]
	public Transform playerMarker;

	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x20")]
	public float damping;

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x127AD58", Offset = "0x127AD58", VA = "0x127AD58")]
	private void Start()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x127AD5C", Offset = "0x127AD5C", VA = "0x127AD5C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x127AE28", Offset = "0x127AE28", VA = "0x127AE28")]
	public Follow()
	{
	}
}
[Token(Token = "0x200002A")]
public class GameManager : MonoBehaviour
{
	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x18")]
	private bool spacePushed;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x19")]
	private bool onPlayableDirectorA;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x20")]
	public PlayableDirector playableDirectorA;

	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x28")]
	public PlayableDirector playableDirectorB;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x30")]
	public PlayableDirector playableDirectorC;

	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x38")]
	public PlayableDirector playableDirectorD;

	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x40")]
	public PlayableDirector playableDirectorE;

	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x48")]
	public PlayableDirector playableDirectorF;

	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x50")]
	public Transform heartSet;

	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x58")]
	public Transform mainControllerTrans;

	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x60")]
	public Transform mainCameraTrans;

	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x68")]
	private Animator footLightAnim;

	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x70")]
	private Animator rightHandAnim;

	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x78")]
	private Animator leftHandAnim;

	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x80")]
	public bool isRightConSelected;

	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x81")]
	public bool rightCon;

	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x82")]
	public bool leftCon;

	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x88")]
	private Transform leftConPos;

	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x90")]
	private Transform rightConPos;

	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x98")]
	public SphereCollider leftCollider;

	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0xA0")]
	public SphereCollider rightCollider;

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x127B21C", Offset = "0x127B21C", VA = "0x127B21C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x127B408", Offset = "0x127B408", VA = "0x127B408")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x127B49C", Offset = "0x127B49C", VA = "0x127B49C")]
	public void StartAction()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x127B6BC", Offset = "0x127B6BC", VA = "0x127B6BC")]
	public void PlayTimelineA()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x127B6D8", Offset = "0x127B6D8", VA = "0x127B6D8")]
	public void PlayTimelineB()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x127B6F4", Offset = "0x127B6F4", VA = "0x127B6F4")]
	public void PlayTimelineC()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x127B710", Offset = "0x127B710", VA = "0x127B710")]
	public void PlayTimelineD()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x127B72C", Offset = "0x127B72C", VA = "0x127B72C")]
	public void PlayTimelineE()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x127B748", Offset = "0x127B748", VA = "0x127B748")]
	public void PlayTimelineF()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x127B764", Offset = "0x127B764", VA = "0x127B764")]
	public void Reset()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x127B7C4", Offset = "0x127B7C4", VA = "0x127B7C4")]
	public GameManager()
	{
	}
}
[Token(Token = "0x200002B")]
public class HeartModel : MonoBehaviour
{
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CEB38", Offset = "0x5CEB38")]
	private sealed class <HapticSwitchR>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x12831C0", Offset = "0x12831C0", VA = "0x12831C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x1283208", Offset = "0x1283208", VA = "0x1283208", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x127B828", Offset = "0x127B828", VA = "0x127B828")]
		[DebuggerHidden]
		public <HapticSwitchR>d__40(int <>1__state)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x12830E8", Offset = "0x12830E8", VA = "0x12830E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x12830EC", Offset = "0x12830EC", VA = "0x12830EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x12831C8", Offset = "0x12831C8", VA = "0x12831C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CEB48", Offset = "0x5CEB48")]
	private sealed class <HapticSwitchL>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1283098", Offset = "0x1283098", VA = "0x1283098", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x12830E0", Offset = "0x12830E0", VA = "0x12830E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x127B8B0", Offset = "0x127B8B0", VA = "0x127B8B0")]
		[DebuggerHidden]
		public <HapticSwitchL>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1282FCC", Offset = "0x1282FCC", VA = "0x1282FCC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1282FD0", Offset = "0x1282FD0", VA = "0x1282FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x12830A0", Offset = "0x12830A0", VA = "0x12830A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x18")]
	public bool beating;

	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x20")]
	public GameObject heartLight;

	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x28")]
	public GameObject playerBurstPrefab;

	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x30")]
	public Transform heartLightPos;

	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x38")]
	public bool sColliderA_B;

	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x39")]
	public bool sColliderB_C;

	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x3A")]
	public bool sColliderC_D;

	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x3B")]
	public bool sColliderD_E;

	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x3C")]
	public bool sColliderE_F;

	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x40")]
	public Transform sColliderA_Btrans;

	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x48")]
	public Transform sColliderB_Ctrans;

	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x50")]
	public Transform sColliderC_Dtrans;

	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x58")]
	public Transform sColliderD_Etrans;

	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x60")]
	public bool doorLight;

	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x61")]
	public bool doorLight_blue;

	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x62")]
	public bool titleHeartLight;

	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x68")]
	private Transform titleHeartPos;

	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x70")]
	public bool airPlaneLight;

	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x78")]
	private Transform airPlanePos;

	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x80")]
	public bool switchLight;

	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x88")]
	private Animator switchAnim;

	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x90")]
	private Animator doorLightAnim;

	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x98")]
	public bool airPlaneCharging;

	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0xA0")]
	private Animator airPlaneAnim;

	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0xA8")]
	private Animator breakHeartRAnim;

	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0xB0")]
	private Animator breakHeartLAnim;

	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0xB8")]
	private Animator heartAnim;

	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0xC0")]
	public Animator robotHeartAnim;

	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0xC8")]
	private Animator robotRevivalHeartAnim;

	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0xD0")]
	public bool onRobotHeart;

	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0xD1")]
	public bool onRobotHeartBurst;

	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0xD2")]
	public bool onAirPlaneHeart;

	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject robotBurst;

	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0xE0")]
	public Transform robotBurstPos;

	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject titleBurstPrefab;

	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0xF0")]
	public Transform breakHeartPos;

	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0xF8")]
	private Animator playerStageLightAnim;

	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x100")]
	private Animator titleHeartBeat;

	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x108")]
	public MeshRenderer heartMesh;

	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0x110")]
	public GameManager gameManager;

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x127B7CC", Offset = "0x127B7CC", VA = "0x127B7CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5CED88", Offset = "0x5CED88")]
	private IEnumerator HapticSwitchR()
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x127B854", Offset = "0x127B854", VA = "0x127B854")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5CEDE8", Offset = "0x5CEDE8")]
	private IEnumerator HapticSwitchL()
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x127B8DC", Offset = "0x127B8DC", VA = "0x127B8DC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x127B8E0", Offset = "0x127B8E0", VA = "0x127B8E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x127BC78", Offset = "0x127BC78", VA = "0x127BC78")]
	public void OnHeartLight()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x127C270", Offset = "0x127C270", VA = "0x127C270")]
	public HeartModel()
	{
	}
}
[Token(Token = "0x200002E")]
public class KeepOnManager : MonoBehaviour
{
	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x18")]
	private GameManager gameManager;

	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x20")]
	public bool counting;

	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x24")]
	public float countup;

	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x28")]
	public float timeLimit;

	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x2C")]
	public bool A_B;

	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x2D")]
	public bool B_C;

	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x2E")]
	public bool C_D;

	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x2F")]
	public bool D_E;

	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x30")]
	public bool E_F;

	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x38")]
	private Animator mainAnim;

	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x40")]
	private SphereCollider sColliderA_B;

	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x48")]
	private SphereCollider sColliderB_C;

	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x50")]
	private SphereCollider sColliderC_D;

	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x58")]
	private SphereCollider sColliderD_E;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x60")]
	private SphereCollider sColliderE_F;

	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x68")]
	private PlayableDirecterEventA pDE_A;

	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x70")]
	private PlayableDirecterEventB pDE_B;

	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x78")]
	private PlayableDirecterEventC pDE_C;

	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x80")]
	private PlayableDirecterEventD pDE_D;

	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x88")]
	private PlayableDirecterEventE pDE_E;

	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x90")]
	private PlayableDirecterEventE pDE_F;

	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x98")]
	private Transform EmberTranslateA_B;

	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0xA0")]
	private Transform EmberTranslateB_C;

	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0xA8")]
	private Transform EmberTranslateC_D;

	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0xB0")]
	private Transform EmberTranslateD_E;

	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0xB8")]
	private Transform EmberTranslateE_F;

	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0xC0")]
	private LookAt playerHeartLookAt;

	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0xC8")]
	private ParticleSystem heartLookAtEmbers;

	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0xD0")]
	private ParticleSystem heartLookAtEmbers_toStaff;

	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0xD8")]
	private AudioSource m01_B;

	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0xE0")]
	private HeartModel heartModel;

	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0xE8")]
	private BeamLength heartLookAtEmbers_Player;

	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0xF0")]
	private AudioSource connectSound;

	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0xF8")]
	public AudioSource airPlaneSound;

	[Token(Token = "0x4000141")]
	[FieldOffset(Offset = "0x100")]
	public Animator placeYourHeartA_B;

	[Token(Token = "0x4000142")]
	[FieldOffset(Offset = "0x108")]
	public Animator placeYourHeartB_C;

	[Token(Token = "0x4000143")]
	[FieldOffset(Offset = "0x110")]
	public Animator placeYourHeartC_D;

	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0x118")]
	public Animator placeYourHeartD_E;

	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0x120")]
	public Animator placeYourHeartE_F;

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x127C278", Offset = "0x127C278", VA = "0x127C278")]
	private void Awake()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x127C2F8", Offset = "0x127C2F8", VA = "0x127C2F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x127CA78", Offset = "0x127CA78", VA = "0x127CA78")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x127CFD8", Offset = "0x127CFD8", VA = "0x127CFD8")]
	private void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x127D4C8", Offset = "0x127D4C8", VA = "0x127D4C8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x127CEC0", Offset = "0x127CEC0", VA = "0x127CEC0")]
	public void CountupStart()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x127D3B0", Offset = "0x127D3B0", VA = "0x127D3B0")]
	public void CountupReset()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x127D8C8", Offset = "0x127D8C8", VA = "0x127D8C8")]
	private void MainAnimatorReset()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x127DA5C", Offset = "0x127DA5C", VA = "0x127DA5C")]
	public KeepOnManager()
	{
	}
}
[Token(Token = "0x200002F")]
public class LightManager : MonoBehaviour
{
	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x18")]
	public Animator[] lights;

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x127DC70", Offset = "0x127DC70", VA = "0x127DC70")]
	public void OnLight(int number)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x127DD88", Offset = "0x127DD88", VA = "0x127DD88")]
	public void OffLight(int number)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x127DEA0", Offset = "0x127DEA0", VA = "0x127DEA0")]
	public LightManager()
	{
	}
}
[Token(Token = "0x2000030")]
public class LookAt : MonoBehaviour
{
	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x127E250", Offset = "0x127E250", VA = "0x127E250")]
	private void Start()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x127E254", Offset = "0x127E254", VA = "0x127E254")]
	private void Update()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x127E288", Offset = "0x127E288", VA = "0x127E288")]
	public LookAt()
	{
	}
}
[Token(Token = "0x2000031")]
public class Offsetter : MonoBehaviour
{
	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x18")]
	public GameObject player;

	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 offset;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x127E5B4", Offset = "0x127E5B4", VA = "0x127E5B4")]
	private void Start()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x127E634", Offset = "0x127E634", VA = "0x127E634")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x127E6A0", Offset = "0x127E6A0", VA = "0x127E6A0")]
	public Offsetter()
	{
	}
}
[Token(Token = "0x2000032")]
public class OnTitleHeart : MonoBehaviour
{
	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x18")]
	public MeshRenderer titleHeart;

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x127E6A8", Offset = "0x127E6A8", VA = "0x127E6A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x127E720", Offset = "0x127E720", VA = "0x127E720")]
	private void Update()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x127E724", Offset = "0x127E724", VA = "0x127E724")]
	public void OnTitleHeart_UP()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x127E744", Offset = "0x127E744", VA = "0x127E744")]
	public void OffTitleHeart_DOWN()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x127E764", Offset = "0x127E764", VA = "0x127E764")]
	public OnTitleHeart()
	{
	}
}
[Token(Token = "0x2000033")]
public class OnTriggerSender : MonoBehaviour
{
	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x18")]
	private KeepOnManager keepOnManager;

	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x20")]
	private SphereCollider RobotHeartCol;

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x127E76C", Offset = "0x127E76C", VA = "0x127E76C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x127E7EC", Offset = "0x127E7EC", VA = "0x127E7EC")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x127E8D0", Offset = "0x127E8D0", VA = "0x127E8D0")]
	private void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x127E9B4", Offset = "0x127E9B4", VA = "0x127E9B4")]
	public OnTriggerSender()
	{
	}
}
[Token(Token = "0x2000034")]
public class ParticleManager : MonoBehaviour
{
	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem[] particle;

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x127E9BC", Offset = "0x127E9BC", VA = "0x127E9BC")]
	public void OnParticle(int number)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x127EAB8", Offset = "0x127EAB8", VA = "0x127EAB8")]
	public void OffParticle(int number)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x127EBB4", Offset = "0x127EBB4", VA = "0x127EBB4")]
	public ParticleManager()
	{
	}
}
[Token(Token = "0x2000035")]
public class PlayableDirectorConnecter : MonoBehaviour
{
	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x18")]
	public PlayableDirector targetPlayDirector;

	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x20")]
	public PlayableDirector targetStopDirector;

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1280C94", Offset = "0x1280C94", VA = "0x1280C94")]
	private void Start()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x1280D24", Offset = "0x1280D24", VA = "0x1280D24")]
	private void Update()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1280D28", Offset = "0x1280D28", VA = "0x1280D28")]
	public void PlayDirector()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x1280DC4", Offset = "0x1280DC4", VA = "0x1280DC4")]
	public PlayableDirectorConnecter()
	{
	}
}
[Token(Token = "0x2000036")]
public class PlayableDirectorConnecterToAnimator : MonoBehaviour
{
	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x18")]
	private Animator targetPlayAnim;

	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x20")]
	private PlayableDirector targetStopDirector;

	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x28")]
	public string setBoolName;

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1280DCC", Offset = "0x1280DCC", VA = "0x1280DCC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1280E7C", Offset = "0x1280E7C", VA = "0x1280E7C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x1280E80", Offset = "0x1280E80", VA = "0x1280E80")]
	public void PlayDirector()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1280EC4", Offset = "0x1280EC4", VA = "0x1280EC4")]
	public PlayableDirectorConnecterToAnimator()
	{
	}
}
[Token(Token = "0x2000037")]
public class SetActiveFalseStart : MonoBehaviour
{
	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1281738", Offset = "0x1281738", VA = "0x1281738")]
	private void Start()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x1281760", Offset = "0x1281760", VA = "0x1281760")]
	private void Update()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x1281764", Offset = "0x1281764", VA = "0x1281764")]
	public SetActiveFalseStart()
	{
	}
}
[Token(Token = "0x2000038")]
public class SetindexKeyManager : MonoBehaviour
{
	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x18")]
	private string renderModelName;

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x128176C", Offset = "0x128176C", VA = "0x128176C")]
	public SetindexKeyManager()
	{
	}
}
[Token(Token = "0x2000039")]
public class SoundRandamizer : MonoBehaviour
{
	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x18")]
	private AudioSource audioSource;

	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip[] shoot;

	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x28")]
	private AudioClip shootClip;

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x12818CC", Offset = "0x12818CC", VA = "0x12818CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x12819C0", Offset = "0x12819C0", VA = "0x12819C0")]
	public SoundRandamizer()
	{
	}
}
[Token(Token = "0x200003A")]
public class StartButton : MonoBehaviour
{
	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x18")]
	public GameManager gameManager;

	[Token(Token = "0x4000158")]
	[FieldOffset(Offset = "0x20")]
	private SphereCollider sphereColider;

	[Token(Token = "0x4000159")]
	[FieldOffset(Offset = "0x28")]
	private Animator anim;

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x12819C8", Offset = "0x12819C8", VA = "0x12819C8")]
	private void Start()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x1281A54", Offset = "0x1281A54", VA = "0x1281A54")]
	private void Update()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1281AFC", Offset = "0x1281AFC", VA = "0x1281AFC")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x1281C80", Offset = "0x1281C80", VA = "0x1281C80")]
	public StartButton()
	{
	}
}
[Token(Token = "0x200003B")]
public class StartErase : MonoBehaviour
{
	[Token(Token = "0x400015A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject targetObj;

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x1281C88", Offset = "0x1281C88", VA = "0x1281C88")]
	private void Start()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x1281CA8", Offset = "0x1281CA8", VA = "0x1281CA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x1281CAC", Offset = "0x1281CAC", VA = "0x1281CAC")]
	public StartErase()
	{
	}
}
[Token(Token = "0x200003C")]
public class gravityController : MonoBehaviour
{
	[Token(Token = "0x400015B")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 localGravity;

	[Token(Token = "0x400015C")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rb;

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x1282DC4", Offset = "0x1282DC4", VA = "0x1282DC4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x1282E38", Offset = "0x1282E38", VA = "0x1282E38")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x1282E3C", Offset = "0x1282E3C", VA = "0x1282E3C")]
	private void setLocalGravity()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x1282E68", Offset = "0x1282E68", VA = "0x1282E68")]
	public gravityController()
	{
	}
}
[Token(Token = "0x200003D")]
public class DokiDokiOn : MonoBehaviour
{
	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject dokidokiPrefub;

	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject burstPS;

	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x28")]
	public Transform dokidokiPos;

	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x30")]
	private Animator robotB_doorAnim;

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x1274744", Offset = "0x1274744", VA = "0x1274744")]
	private void Start()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x1274820", Offset = "0x1274820", VA = "0x1274820")]
	public void OnDokiDoki()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x1274948", Offset = "0x1274948", VA = "0x1274948")]
	public void OnFlash()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x1274A48", Offset = "0x1274A48", VA = "0x1274A48")]
	public void OnDokiDoki2()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x1274B48", Offset = "0x1274B48", VA = "0x1274B48")]
	public void OnRobotBDoorLight()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x1274BA0", Offset = "0x1274BA0", VA = "0x1274BA0")]
	public DokiDokiOn()
	{
	}
}
[Token(Token = "0x200003E")]
public class DokiDokiOn_Senyou : MonoBehaviour
{
	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x18")]
	public GameObject dokidokiPrefub;

	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0x20")]
	public GameObject burstPS;

	[Token(Token = "0x4000163")]
	[FieldOffset(Offset = "0x28")]
	public Transform dokidokiPos;

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x1274BA8", Offset = "0x1274BA8", VA = "0x1274BA8")]
	private void Start()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x1274C34", Offset = "0x1274C34", VA = "0x1274C34")]
	private void Update()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x1274C38", Offset = "0x1274C38", VA = "0x1274C38")]
	public void OnDokiDoki()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1274D38", Offset = "0x1274D38", VA = "0x1274D38")]
	public void OnFlash()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x1274E38", Offset = "0x1274E38", VA = "0x1274E38")]
	public void OnDokiDoki_Senyou()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x1274F84", Offset = "0x1274F84", VA = "0x1274F84")]
	public DokiDokiOn_Senyou()
	{
	}
}
[Token(Token = "0x200003F")]
public class ParticleSystemBurst : MonoBehaviour
{
	[Token(Token = "0x4000164")]
	[FieldOffset(Offset = "0x18")]
	public bool trackerMode;

	[Token(Token = "0x4000165")]
	[FieldOffset(Offset = "0x1C")]
	public float baseRatio;

	[Token(Token = "0x4000166")]
	[FieldOffset(Offset = "0x20")]
	public float intensity;

	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x24")]
	private float targetValue;

	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x28")]
	private bool mixerFlag;

	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x2C")]
	private float lastBurstTime;

	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x30")]
	public bool sColliderA_B;

	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x31")]
	public bool sColliderB_C;

	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x32")]
	public bool sColliderC_D;

	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x33")]
	public bool sColliderD_E;

	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x34")]
	public bool sColliderE_F;

	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x38")]
	public Transform sColliderA_Btrans;

	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x40")]
	public Transform sColliderB_Ctrans;

	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x48")]
	public Transform sColliderC_Dtrans;

	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x50")]
	public Transform sColliderD_Etrans;

	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x58")]
	public bool doorLight;

	[Token(Token = "0x4000174")]
	[FieldOffset(Offset = "0x59")]
	public bool doorLight_blue;

	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x5A")]
	public bool titleHeartLight;

	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x60")]
	private Transform titleHeartPos;

	[Token(Token = "0x4000177")]
	[FieldOffset(Offset = "0x68")]
	public bool airPlaneLight;

	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0x70")]
	private Transform airPlanePos;

	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x78")]
	public bool switchLight;

	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x80")]
	private Animator switchAnim;

	[Token(Token = "0x400017B")]
	[FieldOffset(Offset = "0x88")]
	private Animator doorLightAnim;

	[Token(Token = "0x400017C")]
	[FieldOffset(Offset = "0x90")]
	public bool airPlaneCharging;

	[Token(Token = "0x400017D")]
	[FieldOffset(Offset = "0x98")]
	private Animator airPlaneAnim;

	[Token(Token = "0x400017E")]
	[FieldOffset(Offset = "0xA0")]
	private Animator breakHeartRAnim;

	[Token(Token = "0x400017F")]
	[FieldOffset(Offset = "0xA8")]
	private Animator breakHeartLAnim;

	[Token(Token = "0x4000180")]
	[FieldOffset(Offset = "0xB0")]
	private Animator heartAnim;

	[Token(Token = "0x4000181")]
	[FieldOffset(Offset = "0xB8")]
	private Animator robotHeartAnim;

	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0xC0")]
	private Animator robotRevivalHeartAnim;

	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0xC8")]
	public bool onRobotHeart;

	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0xC9")]
	public bool onRobotHeartBurst;

	[Token(Token = "0x4000185")]
	[FieldOffset(Offset = "0xCA")]
	public bool onAirPlaneHeart;

	[Token(Token = "0x4000186")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject robotBurst;

	[Token(Token = "0x4000187")]
	[FieldOffset(Offset = "0xD8")]
	public Transform robotBurstPos;

	[Token(Token = "0x4000188")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject titleBurstPrefab;

	[Token(Token = "0x4000189")]
	[FieldOffset(Offset = "0xE8")]
	public Transform breakHeartPos;

	[Token(Token = "0x400018A")]
	[FieldOffset(Offset = "0xF0")]
	private Animator playerStageLightAnim;

	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0xF8")]
	private Animator titleHeartBeat;

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x127FC00", Offset = "0x127FC00", VA = "0x127FC00")]
	private void Start()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x127FE9C", Offset = "0x127FE9C", VA = "0x127FE9C")]
	public ParticleSystemBurst()
	{
	}
}
[Token(Token = "0x2000040")]
public class ParticleSystemTest : MonoBehaviour
{
	[Token(Token = "0x400018C")]
	[FieldOffset(Offset = "0x18")]
	public float baseRatio;

	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ParticleSystem targetPS;

	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem.EmissionModule emissionModule;

	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x30")]
	public float intensity;

	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x34")]
	private float targetValue;

	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x38")]
	private bool mixerFlag;

	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float volumeConvertA;

	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float volumeConvertB;

	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float minValue;

	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float maxValue;

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x127FEC0", Offset = "0x127FEC0", VA = "0x127FEC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x127FEFC", Offset = "0x127FEFC", VA = "0x127FEFC")]
	public void ChangeIntensity(float newIntensity)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x127FF4C", Offset = "0x127FF4C", VA = "0x127FF4C")]
	public ParticleSystemTest()
	{
	}
}
[Token(Token = "0x2000041")]
public class TimeToDie : MonoBehaviour
{
	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float timeToDie;

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1281FB4", Offset = "0x1281FB4", VA = "0x1281FB4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x128203C", Offset = "0x128203C", VA = "0x128203C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1282040", Offset = "0x1282040", VA = "0x1282040")]
	public TimeToDie()
	{
	}
}
[Token(Token = "0x2000042")]
public class GITest : MonoBehaviour
{
	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x18")]
	public float baseRatio;

	[Token(Token = "0x4000198")]
	[FieldOffset(Offset = "0x20")]
	public Renderer targetRenderer;

	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x28")]
	public float intensity;

	[Token(Token = "0x400019A")]
	[FieldOffset(Offset = "0x2C")]
	public Color color;

	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x3C")]
	private float targetValue;

	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x40")]
	private bool mixerFlag;

	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float volumeConvertFactor;

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x127AF80", Offset = "0x127AF80", VA = "0x127AF80")]
	private void Start()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x127AFDC", Offset = "0x127AFDC", VA = "0x127AFDC")]
	private void Update()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x127AFE0", Offset = "0x127AFE0", VA = "0x127AFE0")]
	public void ChangeIntensity(float newIntensity)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x127B07C", Offset = "0x127B07C", VA = "0x127B07C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x127B138", Offset = "0x127B138", VA = "0x127B138")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x127B1F4", Offset = "0x127B1F4", VA = "0x127B1F4")]
	public GITest()
	{
	}
}
namespace Tantawowa.TimelineEvents
{
	[Token(Token = "0x2000043")]
	public class EventInvocationInfo
	{
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x10")]
		public Behaviour TargetBehaviour;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x18")]
		public MethodInfo MethodInfo;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x0")]
		public static Type[] SupportedTypes;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x20")]
		public string Key;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x12751B0", Offset = "0x12751B0", VA = "0x12751B0")]
		public EventInvocationInfo(string key, Behaviour targetBehaviour, MethodInfo methodInfo)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1275214", Offset = "0x1275214", VA = "0x1275214")]
		public void Invoke(object value)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1275300", Offset = "0x1275300", VA = "0x1275300")]
		public void InvokEnum(int value)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1275470", Offset = "0x1275470", VA = "0x1275470")]
		public void InvokeNoArgs()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x12754C4", Offset = "0x12754C4", VA = "0x12754C4")]
		public void Invoke(bool isSingleArg, string value)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class TimelineEventBehaviour : PlayableBehaviour
	{
		[Token(Token = "0x2000045")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CEB58", Offset = "0x5CEB58")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40001A8")]
			[FieldOffset(Offset = "0x10")]
			public string methodName;

			[Token(Token = "0x40001A9")]
			[FieldOffset(Offset = "0x18")]
			public bool methodWitharg;

			[Token(Token = "0x600016A")]
			[Address(RVA = "0x1282364", Offset = "0x1282364", VA = "0x1282364")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600016B")]
			[Address(RVA = "0x1283228", Offset = "0x1283228", VA = "0x1283228")]
			internal bool <GetInvocationInfo>b__0(MethodInfo m)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x10")]
		public string HandlerKey;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x18")]
		public bool IsMethodWithParam;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x19")]
		public bool InvokeEventsInEditMode;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x20")]
		public GameObject TargetObject;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x28")]
		public string ArgValue;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x30")]
		private EventInvocationInfo invocationInfo;

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1282048", Offset = "0x1282048", VA = "0x1282048", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x12820B0", Offset = "0x12820B0", VA = "0x12820B0")]
		private void UpdateDelegates()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1282110", Offset = "0x1282110", VA = "0x1282110")]
		private EventInvocationInfo GetInvocationInfo(bool isEnabled, string methodKey, EventInvocationInfo currentInfo, bool methodWitharg)
		{
			return null;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x128236C", Offset = "0x128236C", VA = "0x128236C")]
		private void GetBehaviourAndMethod(bool isEnabled, string key, ref Behaviour targetBehaviour, ref string methodName)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1282660", Offset = "0x1282660", VA = "0x1282660")]
		public TimelineEventBehaviour()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class TimelineEventClip : PlayableAsset, ITimelineClipAsset
	{
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x18")]
		public TimelineEventBehaviour template;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CED48", Offset = "0x5CED48")]
		private GameObject <TrackTargetObject>k__BackingField;

		[Token(Token = "0x17000005")]
		public GameObject TrackTargetObject
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x1282668", Offset = "0x1282668", VA = "0x1282668")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CEEE8", Offset = "0x5CEEE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x1282670", Offset = "0x1282670", VA = "0x1282670")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CEEF8", Offset = "0x5CEEF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x1282678", Offset = "0x1282678", VA = "0x1282678", Slot = "9")]
			get
			{
				return default(ClipCaps);
			}
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1282680", Offset = "0x1282680", VA = "0x1282680", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1282784", Offset = "0x1282784", VA = "0x1282784")]
		public TimelineEventClip()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class TimelineEventMixerBehaviour : PlayableBehaviour
	{
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x12827F4", Offset = "0x12827F4", VA = "0x12827F4")]
		public TimelineEventMixerBehaviour()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x5CEB68", Offset = "0x5CEB68")]
	[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x5CEB68", Offset = "0x5CEB68")]
	[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x5CEB68", Offset = "0x5CEB68")]
	public class TimelineEventTrack : TrackAsset
	{
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x12827FC", Offset = "0x12827FC", VA = "0x12827FC", Slot = "24")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1282C98", Offset = "0x1282C98", VA = "0x1282C98")]
		public TimelineEventTrack()
		{
		}
	}
}
namespace Tantawowa.Extensions
{
	[Token(Token = "0x2000049")]
	public static class PrimitiveExtensions
	{
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1280ECC", Offset = "0x1280ECC", VA = "0x1280ECC")]
		public static int ClampIndex(this int value, int min, int max)
		{
			return default(int);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1280EE8", Offset = "0x1280EE8", VA = "0x1280EE8")]
		public static bool IsValidAsType(this string input, Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		public static T ConvertToType<T>(this string input)
		{
			return (T)null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1281104", Offset = "0x1281104", VA = "0x1281104")]
		public static double RoundUpToNearest(this double passednumber, double roundto)
		{
			return default(double);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1281184", Offset = "0x1281184", VA = "0x1281184")]
		public static double RoundDownToNearest(this double passednumber, double roundto)
		{
			return default(double);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1281204", Offset = "0x1281204", VA = "0x1281204")]
		public static float RoundUpToNearest(this float passednumber, float roundto)
		{
			return default(float);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x128121C", Offset = "0x128121C", VA = "0x128121C")]
		public static float RoundDownToNearest(this float passednumber, float roundto)
		{
			return default(float);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1281234", Offset = "0x1281234", VA = "0x1281234")]
		public static int RoundUpToNearest(this int passednumber, int roundto)
		{
			return default(int);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1281274", Offset = "0x1281274", VA = "0x1281274")]
		public static int RoundDownToNearest(this int passednumber, int roundto)
		{
			return default(int);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x12812B4", Offset = "0x12812B4", VA = "0x12812B4")]
		public static int Flip(this int value)
		{
			return default(int);
		}
	}
}
namespace Tantawowa.Demo.DemoScripts
{
	[Token(Token = "0x200004A")]
	public enum RobotState
	{
		[Token(Token = "0x40001AD")]
		Sleeping,
		[Token(Token = "0x40001AE")]
		GoToWork,
		[Token(Token = "0x40001AF")]
		GoHome
	}
	[Token(Token = "0x200004B")]
	public class Robot : MonoBehaviour
	{
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int points;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RobotState currentState;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x20")]
		public TextMesh Message;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x28")]
		public NavMeshAgent Agent;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x30")]
		public NavMeshFollower NavMeshFollower;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x38")]
		public Transform Work;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x40")]
		public Transform Home;

		[Token(Token = "0x17000007")]
		public int Points
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x12812C0", Offset = "0x12812C0", VA = "0x12812C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x12812C8", Offset = "0x12812C8", VA = "0x12812C8")]
			set
			{
			}
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1281350", Offset = "0x1281350", VA = "0x1281350")]
		public void AddScore(int points)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x128135C", Offset = "0x128135C", VA = "0x128135C")]
		public void ResetScore()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1281364", Offset = "0x1281364", VA = "0x1281364")]
		public void SetState(RobotState state)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1281480", Offset = "0x1281480", VA = "0x1281480")]
		private void Update()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x128155C", Offset = "0x128155C", VA = "0x128155C")]
		public Robot()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class UIManager : MonoBehaviour
	{
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x18")]
		public List<GameObject> UIElements;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Light;

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1282CFC", Offset = "0x1282CFC", VA = "0x1282CFC")]
		public void ChangeUI(UIType type)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1282D9C", Offset = "0x1282D9C", VA = "0x1282D9C")]
		public void ToggleLight(bool isOn)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1282DBC", Offset = "0x1282DBC", VA = "0x1282DBC")]
		public UIManager()
		{
		}
	}
}
namespace Game.General.Navigation
{
	[Token(Token = "0x200004D")]
	public class NavMeshFollower : MonoBehaviour
	{
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x18")]
		public Action<NavMeshFollower> OnArrive;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x20")]
		public NavMeshAgent Agent;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x17000008")]
		public Transform Target
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x127E370", Offset = "0x127E370", VA = "0x127E370")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x127E378", Offset = "0x127E378", VA = "0x127E378")]
			set
			{
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x127E4D8", Offset = "0x127E4D8", VA = "0x127E4D8")]
		private void Update()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x127E59C", Offset = "0x127E59C", VA = "0x127E59C")]
		public NavMeshFollower()
		{
		}
	}
}
namespace UnityStandardAssets.SceneUtils
{
	[Token(Token = "0x200004E")]
	public class ParticleSceneControls : MonoBehaviour
	{
		[Token(Token = "0x200004F")]
		public enum Mode
		{
			[Token(Token = "0x40001CF")]
			Activate,
			[Token(Token = "0x40001D0")]
			Instantiate,
			[Token(Token = "0x40001D1")]
			Trail
		}

		[Token(Token = "0x2000050")]
		public enum AlignMode
		{
			[Token(Token = "0x40001D3")]
			Normal,
			[Token(Token = "0x40001D4")]
			Up
		}

		[Serializable]
		[Token(Token = "0x2000051")]
		public class DemoParticleSystem
		{
			[Token(Token = "0x40001D5")]
			[FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40001D6")]
			[FieldOffset(Offset = "0x18")]
			public Mode mode;

			[Token(Token = "0x40001D7")]
			[FieldOffset(Offset = "0x1C")]
			public AlignMode align;

			[Token(Token = "0x40001D8")]
			[FieldOffset(Offset = "0x20")]
			public int maxCount;

			[Token(Token = "0x40001D9")]
			[FieldOffset(Offset = "0x24")]
			public float minDist;

			[Token(Token = "0x40001DA")]
			[FieldOffset(Offset = "0x28")]
			public int camOffset;

			[Token(Token = "0x40001DB")]
			[FieldOffset(Offset = "0x30")]
			public string instructionText;

			[Token(Token = "0x6000195")]
			[Address(RVA = "0x1283210", Offset = "0x1283210", VA = "0x1283210")]
			public DemoParticleSystem()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000052")]
		public class DemoParticleSystemList
		{
			[Token(Token = "0x40001DC")]
			[FieldOffset(Offset = "0x10")]
			public DemoParticleSystem[] items;

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1283220", Offset = "0x1283220", VA = "0x1283220")]
			public DemoParticleSystemList()
			{
			}
		}

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x18")]
		public DemoParticleSystemList demoParticles;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x20")]
		public float spawnOffset;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x24")]
		public float multiply;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x28")]
		public bool clearOnChange;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x30")]
		public Text titleText;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x38")]
		public Transform sceneCamera;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x40")]
		public Text instructionText;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x48")]
		public Button previousButton;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x50")]
		public Button nextButton;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x58")]
		public GraphicRaycaster graphicRaycaster;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x60")]
		public EventSystem eventSystem;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x68")]
		private ParticleSystemMultiplier m_ParticleMultiplier;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x70")]
		private List<Transform> m_CurrentParticleList;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x78")]
		private Transform m_Instance;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x0")]
		private static int s_SelectedIndex;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 m_CamOffsetVelocity;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x8C")]
		private Vector3 m_LastPos;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x8")]
		private static DemoParticleSystem s_Selected;

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x127EBBC", Offset = "0x127EBBC", VA = "0x127EBBC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x127F068", Offset = "0x127F068", VA = "0x127F068")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x127F154", Offset = "0x127F154", VA = "0x127F154")]
		private void Previous()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x127F244", Offset = "0x127F244", VA = "0x127F244")]
		public void Next()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x127F328", Offset = "0x127F328", VA = "0x127F328")]
		private void Update()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x127FA58", Offset = "0x127FA58", VA = "0x127FA58")]
		private bool CheckForGuiCollision()
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x127ECE8", Offset = "0x127ECE8", VA = "0x127ECE8")]
		private void Select(int i)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x127FB5C", Offset = "0x127FB5C", VA = "0x127FB5C")]
		public ParticleSceneControls()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class PlaceTargetWithMouse : MonoBehaviour
	{
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x18")]
		public float surfaceOffset;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x20")]
		public GameObject setTargetOn;

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x12800D4", Offset = "0x12800D4", VA = "0x12800D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x128026C", Offset = "0x128026C", VA = "0x128026C")]
		public PlaceTargetWithMouse()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class SlowMoButton : MonoBehaviour
	{
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x18")]
		public Sprite FullSpeedTex;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x20")]
		public Sprite SlowSpeedTex;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x28")]
		public float fullSpeed;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x2C")]
		public float slowSpeed;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x30")]
		public Button button;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x38")]
		private bool m_SlowMo;

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1281774", Offset = "0x1281774", VA = "0x1281774")]
		private void Start()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x128177C", Offset = "0x128177C", VA = "0x128177C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1281788", Offset = "0x1281788", VA = "0x1281788")]
		public void ChangeSpeed()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x12818B8", Offset = "0x12818B8", VA = "0x12818B8")]
		public SlowMoButton()
		{
		}
	}
}
