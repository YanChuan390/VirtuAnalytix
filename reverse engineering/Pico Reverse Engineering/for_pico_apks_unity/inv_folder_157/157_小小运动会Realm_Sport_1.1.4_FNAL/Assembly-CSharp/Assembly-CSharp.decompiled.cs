using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pico.Platform;
using Pico.Platform.Models;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public enum SlimeAnimationState
{
	[Token(Token = "0x4000002")]
	Idle,
	[Token(Token = "0x4000003")]
	Walk,
	[Token(Token = "0x4000004")]
	Jump,
	[Token(Token = "0x4000005")]
	Attack,
	[Token(Token = "0x4000006")]
	Damage
}
[Token(Token = "0x2000003")]
public class EnemyAi : MonoBehaviour
{
	[Token(Token = "0x2000004")]
	public enum WalkType
	{
		[Token(Token = "0x4000014")]
		Patroll,
		[Token(Token = "0x4000015")]
		ToOrigin
	}

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x18")]
	public Face faces;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SmileBody;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x28")]
	public SlimeAnimationState currentState;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x30")]
	public Animator animator;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x38")]
	public NavMeshAgent agent;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x40")]
	public Transform[] waypoints;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x48")]
	public int damType;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x4C")]
	private int m_CurrentWaypointIndex;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x50")]
	private bool move;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x58")]
	private Material faceMaterial;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 originPos;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x6C")]
	private WalkType walkType;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x8C304C", Offset = "0x8C304C", VA = "0x8C304C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x8C30F4", Offset = "0x8C30F4", VA = "0x8C30F4")]
	public void WalkToNextDestination()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x8C31D8", Offset = "0x8C31D8", VA = "0x8C31D8")]
	public void CancelGoNextDestination()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x8C317C", Offset = "0x8C317C", VA = "0x8C317C")]
	private void SetFace(Texture tex)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x8C3224", Offset = "0x8C3224", VA = "0x8C3224")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x8C3830", Offset = "0x8C3830", VA = "0x8C3830")]
	private void StopAgent()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x8C38B0", Offset = "0x8C38B0", VA = "0x8C38B0")]
	public void AlertObservers(string message)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x8C3A28", Offset = "0x8C3A28", VA = "0x8C3A28")]
	private void OnAnimatorMove()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x8C3ACC", Offset = "0x8C3ACC", VA = "0x8C3ACC")]
	public EnemyAi()
	{
	}
}
[Token(Token = "0x2000005")]
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Face", order = 1)]
public class Face : ScriptableObject
{
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x18")]
	public Texture Idleface;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x20")]
	public Texture WalkFace;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x28")]
	public Texture jumpFace;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x30")]
	public Texture attackFace;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x38")]
	public Texture damageFace;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x8C3AD4", Offset = "0x8C3AD4", VA = "0x8C3AD4")]
	public Face()
	{
	}
}
[Token(Token = "0x2000006")]
public class GameManager : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject mainSlime;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x20")]
	public Button idleBut;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x28")]
	public Button walkBut;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x30")]
	public Button jumpBut;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x38")]
	public Button attackBut;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x40")]
	public Button damageBut0;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x48")]
	public Button damageBut1;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x50")]
	public Button damageBut2;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x58")]
	public Camera cam;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x8C3ADC", Offset = "0x8C3ADC", VA = "0x8C3ADC")]
	private void Start()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x8C3D70", Offset = "0x8C3D70", VA = "0x8C3D70")]
	private void Idle()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x8C3E9C", Offset = "0x8C3E9C", VA = "0x8C3E9C")]
	public void ChangeStateTo(SlimeAnimationState state)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x8C3DDC", Offset = "0x8C3DDC", VA = "0x8C3DDC")]
	private void LookAtCamera()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x8C3F60", Offset = "0x8C3F60", VA = "0x8C3F60")]
	public GameManager()
	{
	}
}
[Token(Token = "0x2000007")]
public class RingMoveScript : MonoBehaviour
{
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x18")]
	public GameObject explosionPrefab;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x20")]
	private bool isCollisionPlayGround;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x28")]
	private List<GameObject> prizes;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> prizeTables;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x38")]
	private GameObject goaledPrize;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x40")]
	private float maxGoaledDis;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x48")]
	private DateTime expStartPlayTime;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x50")]
	private bool hasResult;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x51")]
	private bool isExpPlay;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x58")]
	private GameObject explosion;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x60")]
	private TMP_Text scoreNumText;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x8C4104", Offset = "0x8C4104", VA = "0x8C4104")]
	private void Start()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x8C4180", Offset = "0x8C4180", VA = "0x8C4180")]
	private void Update()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x8C4184", Offset = "0x8C4184", VA = "0x8C4184")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x8C4520", Offset = "0x8C4520", VA = "0x8C4520")]
	private void GoldedPrize()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x8C4928", Offset = "0x8C4928", VA = "0x8C4928")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x8C492C", Offset = "0x8C492C", VA = "0x8C492C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x8C4BE4", Offset = "0x8C4BE4", VA = "0x8C4BE4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x8C4E9C", Offset = "0x8C4E9C", VA = "0x8C4E9C")]
	public RingMoveScript()
	{
	}
}
[Token(Token = "0x2000008")]
public class PicoServiceInit : MonoBehaviour
{
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x8C4F60", Offset = "0x8C4F60", VA = "0x8C4F60")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x8C5174", Offset = "0x8C5174", VA = "0x8C5174")]
	private void Update()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x8C5004", Offset = "0x8C5004", VA = "0x8C5004")]
	private void InitPicoService()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x8C5178", Offset = "0x8C5178", VA = "0x8C5178")]
	private void GetLoggedInUser()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x8C528C", Offset = "0x8C528C", VA = "0x8C528C")]
	private void GetAccessToken()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x8C53A0", Offset = "0x8C53A0", VA = "0x8C53A0")]
	private string User2String(User user)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x8C55AC", Offset = "0x8C55AC", VA = "0x8C55AC")]
	private void GetLassoLeaderboardData()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x8C5678", Offset = "0x8C5678", VA = "0x8C5678")]
	private void OnLeaderboardGet(Message<LeaderboardList> message)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x8C5728", Offset = "0x8C5728", VA = "0x8C5728")]
	private void GetLassoLeaderboardEntryListData()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x8C57F8", Offset = "0x8C57F8", VA = "0x8C57F8")]
	private void GetPrickBalloonLeaderboardEntryListData()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x8C58C8", Offset = "0x8C58C8", VA = "0x8C58C8")]
	private void GetSquashLeaderboardEntryListData()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x8C5998", Offset = "0x8C5998", VA = "0x8C5998")]
	private void GetFPSGameLeaderboardEntryListData()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x8C5A68", Offset = "0x8C5A68", VA = "0x8C5A68")]
	public PicoServiceInit()
	{
	}
}
[Token(Token = "0x200000A")]
public class ArrowMove : MonoBehaviour
{
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x18")]
	public GameObject explosionPrefab;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x20")]
	private bool hasGoalBalloon;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x21")]
	private bool isExpPlay;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x28")]
	private DateTime expStartPlayTime;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x30")]
	private TMP_Text scoreNumText;

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x8C67A8", Offset = "0x8C67A8", VA = "0x8C67A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x8C6824", Offset = "0x8C6824", VA = "0x8C6824")]
	private void Update()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x8C68C4", Offset = "0x8C68C4", VA = "0x8C68C4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x8C69D0", Offset = "0x8C69D0", VA = "0x8C69D0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x8C69D4", Offset = "0x8C69D4", VA = "0x8C69D4")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x8C6D34", Offset = "0x8C6D34", VA = "0x8C6D34")]
	public ArrowMove()
	{
	}
}
[Token(Token = "0x200000B")]
public class BalloonCollisionScript : MonoBehaviour
{
	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x18")]
	private TMP_Text log;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x20")]
	public GameObject explosionPrefab;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x28")]
	private bool hasResult;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x29")]
	private bool isExpPlay;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x30")]
	private GameObject explosion;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x38")]
	private DateTime expStartPlayTime;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x40")]
	private TMP_Text scoreNumText;

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x8C6D3C", Offset = "0x8C6D3C", VA = "0x8C6D3C")]
	private void Start()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x8C6D40", Offset = "0x8C6D40", VA = "0x8C6D40")]
	private void Update()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x8C6D44", Offset = "0x8C6D44", VA = "0x8C6D44")]
	public BalloonCollisionScript()
	{
	}
}
[Token(Token = "0x200000C")]
public class FillValueNumber : MonoBehaviour
{
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x18")]
	public Image TargetImage;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x8C6D4C", Offset = "0x8C6D4C", VA = "0x8C6D4C")]
	private void Update()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x8C6E0C", Offset = "0x8C6E0C", VA = "0x8C6E0C")]
	public FillValueNumber()
	{
	}
}
[Token(Token = "0x200000D")]
public class SceneSwitch : MonoBehaviour
{
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x8C6E14", Offset = "0x8C6E14", VA = "0x8C6E14")]
	private void Start()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x8C6E18", Offset = "0x8C6E18", VA = "0x8C6E18")]
	private void Update()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x8C6E1C", Offset = "0x8C6E1C", VA = "0x8C6E1C")]
	public void SceneSwitchBtnClick(string sceneName)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x8C6E74", Offset = "0x8C6E74", VA = "0x8C6E74")]
	public SceneSwitch()
	{
	}
}
[Token(Token = "0x200000E")]
public class TestPico : MonoBehaviour
{
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x18")]
	private TMP_Text log;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x8C6E7C", Offset = "0x8C6E7C", VA = "0x8C6E7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x8C6EF8", Offset = "0x8C6EF8", VA = "0x8C6EF8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x8C6EFC", Offset = "0x8C6EFC", VA = "0x8C6EFC")]
	private void InitPicoService()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x8C706C", Offset = "0x8C706C", VA = "0x8C706C")]
	private void GetLoggedInUser()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x8C7180", Offset = "0x8C7180", VA = "0x8C7180")]
	private void GetAccessToken()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x8C722C", Offset = "0x8C722C", VA = "0x8C722C")]
	private string User2String(User user)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x8C7438", Offset = "0x8C7438", VA = "0x8C7438")]
	private void GetLassoLeaderboardEntryListData()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x8C7514", Offset = "0x8C7514", VA = "0x8C7514")]
	private void GetPrickBalloonLeaderboardEntryListData()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x8C75F0", Offset = "0x8C75F0", VA = "0x8C75F0")]
	private void GetSquashLeaderboardEntryListData()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x8C76CC", Offset = "0x8C76CC", VA = "0x8C76CC")]
	private void GetFPSGameLeaderboardEntryListData()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x8C77A8", Offset = "0x8C77A8", VA = "0x8C77A8")]
	public TestPico()
	{
	}
}
[Token(Token = "0x2000010")]
public class ChatController : MonoBehaviour
{
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x18")]
	public TMP_InputField ChatInputField;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x20")]
	public TMP_Text ChatDisplayOutput;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x28")]
	public Scrollbar ChatScrollbar;

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x8C8604", Offset = "0x8C8604", VA = "0x8C8604")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x8C86AC", Offset = "0x8C86AC", VA = "0x8C86AC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x8C8754", Offset = "0x8C8754", VA = "0x8C8754")]
	private void AddToChatOutput(string newText)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x8C8BFC", Offset = "0x8C8BFC", VA = "0x8C8BFC")]
	public ChatController()
	{
	}
}
[Token(Token = "0x2000011")]
public class DropdownSample : MonoBehaviour
{
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI text;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TMP_Dropdown dropdownWithoutPlaceholder;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Dropdown dropdownWithPlaceholder;

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x8C8C04", Offset = "0x8C8C04", VA = "0x8C8C04")]
	public void OnButtonClick()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x8C8D0C", Offset = "0x8C8D0C", VA = "0x8C8D0C")]
	public DropdownSample()
	{
	}
}
[Token(Token = "0x2000012")]
public class EnvMapAnimator : MonoBehaviour
{
	[Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x20")]
		public EnvMapAnimator <>4__this;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x28")]
		private Matrix4x4 <matrix>5__2;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x8C9054", Offset = "0x8C9054", VA = "0x8C9054", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x8C909C", Offset = "0x8C909C", VA = "0x8C909C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x8C8E10", Offset = "0x8C8E10", VA = "0x8C8E10")]
		[DebuggerHidden]
		public <Start>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x8C8E40", Offset = "0x8C8E40", VA = "0x8C8E40", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x8C8E44", Offset = "0x8C8E44", VA = "0x8C8E44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x8C905C", Offset = "0x8C905C", VA = "0x8C905C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 RotationSpeeds;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x28")]
	private TMP_Text m_textMeshPro;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x30")]
	private Material m_material;

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x8C8D14", Offset = "0x8C8D14", VA = "0x8C8D14")]
	private void Awake()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x8C8D9C", Offset = "0x8C8D9C", VA = "0x8C8D9C")]
	[IteratorStateMachine(typeof(<Start>d__4))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x8C8E38", Offset = "0x8C8E38", VA = "0x8C8E38")]
	public EnvMapAnimator()
	{
	}
}
[Token(Token = "0x2000014")]
public class rotation : MonoBehaviour
{
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x8C90A4", Offset = "0x8C90A4", VA = "0x8C90A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x8C90A8", Offset = "0x8C90A8", VA = "0x8C90A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x8C90F0", Offset = "0x8C90F0", VA = "0x8C90F0")]
	public rotation()
	{
	}
}
[Token(Token = "0x2000015")]
public enum BulletType
{
	[Token(Token = "0x4000050")]
	Player_Bullet,
	[Token(Token = "0x4000051")]
	Enemy_Bullet
}
[Token(Token = "0x2000016")]
public class Ryunm_Bullet : MonoBehaviour
{
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x18")]
	public BulletType bulletType;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x1C")]
	public float damageValue;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x20")]
	public GameObject bulletExplossion;

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x8C90F8", Offset = "0x8C90F8", VA = "0x8C90F8")]
	private void Start()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x8C90FC", Offset = "0x8C90FC", VA = "0x8C90FC")]
	private void Update()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x8C9100", Offset = "0x8C9100", VA = "0x8C9100")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x8C9A08", Offset = "0x8C9A08", VA = "0x8C9A08")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x8C9A0C", Offset = "0x8C9A0C", VA = "0x8C9A0C")]
	public Ryunm_Bullet()
	{
	}
}
[Token(Token = "0x2000017")]
public class CreaterEm : MonoBehaviour
{
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x18")]
	public GameObject emPrefab;

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x8C9A1C", Offset = "0x8C9A1C", VA = "0x8C9A1C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x8C9AEC", Offset = "0x8C9AEC", VA = "0x8C9AEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x8C9A20", Offset = "0x8C9A20", VA = "0x8C9A20")]
	private void CreateEm()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x8C9AF0", Offset = "0x8C9AF0", VA = "0x8C9AF0")]
	public CreaterEm()
	{
	}
}
[Token(Token = "0x2000018")]
public class cubdestory : MonoBehaviour
{
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x8C9AF8", Offset = "0x8C9AF8", VA = "0x8C9AF8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x8C9AFC", Offset = "0x8C9AFC", VA = "0x8C9AFC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x8C9B00", Offset = "0x8C9B00", VA = "0x8C9B00")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x8C9B6C", Offset = "0x8C9B6C", VA = "0x8C9B6C")]
	public cubdestory()
	{
	}
}
[Token(Token = "0x2000019")]
public class Cusjs : MonoBehaviour
{
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x18")]
	public XRController leftController;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x20")]
	public Text enemyCountTxt;

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x8C9B74", Offset = "0x8C9B74", VA = "0x8C9B74")]
	private void Start()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x8C9B78", Offset = "0x8C9B78", VA = "0x8C9B78")]
	private void Update()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x8C9D20", Offset = "0x8C9D20", VA = "0x8C9D20")]
	public Cusjs()
	{
	}
}
[Token(Token = "0x200001A")]
public class DestonrObeser : MonoBehaviour
{
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x8C9D28", Offset = "0x8C9D28", VA = "0x8C9D28")]
	private void Start()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x8C9D2C", Offset = "0x8C9D2C", VA = "0x8C9D2C")]
	private void Update()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x8C9D30", Offset = "0x8C9D30", VA = "0x8C9D30")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x8C9D34", Offset = "0x8C9D34", VA = "0x8C9D34")]
	public DestonrObeser()
	{
	}
}
[Token(Token = "0x200001B")]
public class DogDestory : MonoBehaviour
{
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x8C9D3C", Offset = "0x8C9D3C", VA = "0x8C9D3C")]
	private void Start()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x8C9D40", Offset = "0x8C9D40", VA = "0x8C9D40")]
	private void Update()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x8C9D44", Offset = "0x8C9D44", VA = "0x8C9D44")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x8C9E20", Offset = "0x8C9E20", VA = "0x8C9E20")]
	public DogDestory()
	{
	}
}
[Token(Token = "0x200001C")]
public class Ryunm_Enemy : MonoBehaviour
{
	[Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class <Fire>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x20")]
		public Ryunm_Enemy <>4__this;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x2C")]
		private float <intervalTime>5__3;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x8CA4B8", Offset = "0x8CA4B8", VA = "0x8CA4B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x8CA500", Offset = "0x8CA500", VA = "0x8CA500", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x8CA220", Offset = "0x8CA220", VA = "0x8CA220")]
		[DebuggerHidden]
		public <Fire>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x8CA274", Offset = "0x8CA274", VA = "0x8CA274", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x8CA278", Offset = "0x8CA278", VA = "0x8CA278", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x8CA4C0", Offset = "0x8CA4C0", VA = "0x8CA4C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x18")]
	public float PH;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x20")]
	public Slider ph_Slider;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject enemyExplossion;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x30")]
	public NavMeshAgent _EnmeyAgent;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x38")]
	public Transform wayPointParent;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x40")]
	public Transform[] points;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x48")]
	private int destPoint;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x4C")]
	public float minDistance;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x50")]
	public float minIntervalTime;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x54")]
	public float maxIntervalTime;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x58")]
	public float minDamge;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x5C")]
	public float maxDamge;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x60")]
	public Transform bulletStartPoint;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x68")]
	public GameObject bulletPrefab;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x70")]
	public float bulletSpeed;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x74")]
	public bool isFireOpen;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x78")]
	public GameObject healthPrefab;

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x8C9E28", Offset = "0x8C9E28", VA = "0x8C9E28")]
	private void Start()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x8C9F60", Offset = "0x8C9F60", VA = "0x8C9F60")]
	private void Update()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x8CA108", Offset = "0x8CA108", VA = "0x8CA108")]
	private void GotoNextPoint()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x8C94B4", Offset = "0x8C94B4", VA = "0x8C94B4")]
	public void OnDamage(float damage)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x8CA1AC", Offset = "0x8CA1AC", VA = "0x8CA1AC")]
	[IteratorStateMachine(typeof(<Fire>d__21))]
	private IEnumerator Fire()
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x8CA248", Offset = "0x8CA248", VA = "0x8CA248")]
	public Ryunm_Enemy()
	{
	}
}
[Token(Token = "0x200001E")]
public class enmy_trans : MonoBehaviour
{
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x8CA508", Offset = "0x8CA508", VA = "0x8CA508")]
	private void Start()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x8CA540", Offset = "0x8CA540", VA = "0x8CA540")]
	private void Update()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x8CA6F0", Offset = "0x8CA6F0", VA = "0x8CA6F0")]
	public enmy_trans()
	{
	}
}
[Token(Token = "0x200001F")]
public class GameCenter : MonoBehaviour
{
	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x18")]
	public int maxCount;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x1C")]
	public int currentCount;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x0")]
	public static GameCenter _instance;

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x8CA6F8", Offset = "0x8CA6F8", VA = "0x8CA6F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x8CA750", Offset = "0x8CA750", VA = "0x8CA750")]
	private void Start()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x8CA7BC", Offset = "0x8CA7BC", VA = "0x8CA7BC")]
	public int maxEnemyCounts()
	{
		return default(int);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x8CA7C4", Offset = "0x8CA7C4", VA = "0x8CA7C4")]
	public void ReloadCount(int maxCounts)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x8CA7CC", Offset = "0x8CA7CC", VA = "0x8CA7CC")]
	public void ReloadCurCount(int curCounts)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x8CA7D4", Offset = "0x8CA7D4", VA = "0x8CA7D4")]
	public int currentMaxEnemyCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x8CA7DC", Offset = "0x8CA7DC", VA = "0x8CA7DC")]
	public GameCenter()
	{
	}
}
[Token(Token = "0x2000020")]
public class GlobManager : MonoBehaviour
{
	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x0")]
	public static GlobManager Instance;

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x8CA7EC", Offset = "0x8CA7EC", VA = "0x8CA7EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x8CA844", Offset = "0x8CA844", VA = "0x8CA844")]
	private void Update()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x8CA848", Offset = "0x8CA848", VA = "0x8CA848")]
	public void LoadGameV1()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x8CA8B0", Offset = "0x8CA8B0", VA = "0x8CA8B0")]
	public GlobManager()
	{
	}
}
[Token(Token = "0x2000021")]
public class PlaneClickToNext : MonoBehaviour
{
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x8CA8B8", Offset = "0x8CA8B8", VA = "0x8CA8B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x8CA8BC", Offset = "0x8CA8BC", VA = "0x8CA8BC")]
	private void Update()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x8CA8C0", Offset = "0x8CA8C0", VA = "0x8CA8C0")]
	public PlaneClickToNext()
	{
	}
}
[Token(Token = "0x2000022")]
public class Ryunm_FPS_PlayerController : MonoBehaviour
{
	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x18")]
	[Header("\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\u05b5")]
	public float mouseOffset_x;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x1C")]
	public float mouseOffset_y;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x20")]
	public float h_InputValue;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x24")]
	public float v_InputValue;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x28")]
	[Header("ת\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd\ufffd")]
	public float rotateSpeed;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x30")]
	public Transform playerTransform;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x38")]
	public Transform eyesTransform;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x40")]
	public float x_rotateLimit;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x44")]
	public float x_angleValue;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x48")]
	[Header("Playerˮƽ\ufffdƶ\ufffd\ufffd봹\u05b1\ufffd\ufffd\ufffd\ufffd")]
	public CharacterController _player_CC;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x50")]
	public float moveSpeed;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x54")]
	public Vector3 motionVlaue;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x60")]
	public float GravityValue;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x64")]
	public float Volecity_y;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x68")]
	public bool isFloor;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x70")]
	public Transform checkPoint;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x78")]
	public float checkRaius;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x7C")]
	public LayerMask floorLayer;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x80")]
	public float jumpHight;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x88")]
	public Ryunm_AnimatorController playerAni;

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x90")]
	public XRController leftController;

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x8CA8C8", Offset = "0x8CA8C8", VA = "0x8CA8C8")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x8CA988", Offset = "0x8CA988", VA = "0x8CA988")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x8CA98C", Offset = "0x8CA98C", VA = "0x8CA98C")]
	private void PlayerViewChange()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x8CAB1C", Offset = "0x8CAB1C", VA = "0x8CAB1C")]
	private void PlayerMove()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x8CAE28", Offset = "0x8CAE28", VA = "0x8CAE28")]
	public Ryunm_FPS_PlayerController()
	{
	}
}
[Token(Token = "0x2000023")]
public class Ryunm_PlayerHealth : MonoBehaviour
{
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x18")]
	public float maxPH;

	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x1C")]
	public float PH;

	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x20")]
	public Slider ph_Slider;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject enemyExplossion;

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x8CAEB4", Offset = "0x8CAEB4", VA = "0x8CAEB4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x8CAEF8", Offset = "0x8CAEF8", VA = "0x8CAEF8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x8C9714", Offset = "0x8C9714", VA = "0x8C9714")]
	public void OnDamage(float damage)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x8CAF00", Offset = "0x8CAF00", VA = "0x8CAF00")]
	public void AddHealth(float value)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x8CAF48", Offset = "0x8CAF48", VA = "0x8CAF48")]
	public Ryunm_PlayerHealth()
	{
	}
}
[Token(Token = "0x2000024")]
public class ReloadNextManager : MonoBehaviour
{
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x8CAF5C", Offset = "0x8CAF5C", VA = "0x8CAF5C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x8CAF60", Offset = "0x8CAF60", VA = "0x8CAF60")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x8CAF64", Offset = "0x8CAF64", VA = "0x8CAF64")]
	public void reloadNextGame()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x8CAFCC", Offset = "0x8CAFCC", VA = "0x8CAFCC")]
	public ReloadNextManager()
	{
	}
}
[Token(Token = "0x2000025")]
public class Ryunm_AnimatorController : MonoBehaviour
{
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x18")]
	public Animator ani;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x20")]
	public float MoveSpeed;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x24")]
	public bool Alerted;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x25")]
	public bool Death;

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x8CAFD4", Offset = "0x8CAFD4", VA = "0x8CAFD4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x8CAFD8", Offset = "0x8CAFD8", VA = "0x8CAFD8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x8CAFDC", Offset = "0x8CAFDC", VA = "0x8CAFDC")]
	public void Attack()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x8CAEFC", Offset = "0x8CAEFC", VA = "0x8CAEFC")]
	public void OnDamaged()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x8CAFE0", Offset = "0x8CAFE0", VA = "0x8CAFE0")]
	public Ryunm_AnimatorController()
	{
	}
}
[Token(Token = "0x2000026")]
public class Ryunm_FloorLayout : MonoBehaviour
{
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject basicFloor;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 cellSet;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 floorSize;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 StartPos;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x48")]
	public List<Transform> floorList;

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x8CAFE8", Offset = "0x8CAFE8", VA = "0x8CAFE8")]
	[ContextMenu("LayoutFloor")]
	public void LayoutFloors()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x8CB2B4", Offset = "0x8CB2B4", VA = "0x8CB2B4")]
	public Ryunm_FloorLayout()
	{
	}
}
[Token(Token = "0x2000027")]
public class Ryunm_GameManager : MonoBehaviour
{
	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x0")]
	public static Ryunm_GameManager _instance;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x18")]
	public Slider bulletCountSlider;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x20")]
	public Ryunm_FPS_PlayerController _player;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x28")]
	private int maxEnemyCount;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x2C")]
	public int remainingEnemyCount;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x30")]
	private int currentMaxEnemyCount;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x34")]
	public int currentEnemyCount;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x38")]
	public int currentDestoryEnmeyCount;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x40")]
	public Text enemyCountTxt;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x48")]
	public Text currentCountTxt;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x50")]
	public Transform wayPointList;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x58")]
	public Transform[] wayPoints;

	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x60")]
	public GameObject sjRed;

	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x68")]
	public GameObject sjBlue;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x70")]
	public GameObject sjYellow;

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x78")]
	public GameObject zRed;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x80")]
	public GameObject zBlue;

	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x88")]
	public GameObject zYellow;

	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x90")]
	public GameObject rRed;

	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x98")]
	public GameObject rBlue;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject rYellow;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject rightController;

	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject planeEnd;

	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject planStart;

	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0xC0")]
	public bool isFinish;

	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0xC8")]
	public Text sheetTimeText;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0xD0")]
	public Text sheetCountText;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0xD8")]
	public Text sheetScoreText;

	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0xE0")]
	private InputDevice rightHandDevice;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0xF0")]
	private InputDevice leftHandDevice;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x100")]
	private XRRayInteractor leftInteractor;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x108")]
	private XRRayInteractor rightInteractor;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x110")]
	private XRInteractorLineVisual leftRayLine;

	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x118")]
	private XRInteractorLineVisual rightRayLine;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x120")]
	private int originIndex;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x124")]
	private int count;

	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x128")]
	private float esaeTime;

	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x12C")]
	private bool isPause;

	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x130")]
	private GameObject pauseWin;

	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x138")]
	private DateTime lastPressTime;

	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x140")]
	private GameObject handTips;

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x8CB35C", Offset = "0x8CB35C", VA = "0x8CB35C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x8CB3B4", Offset = "0x8CB3B4", VA = "0x8CB3B4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x8CB788", Offset = "0x8CB788", VA = "0x8CB788")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x8CBDAC", Offset = "0x8CBDAC", VA = "0x8CBDAC")]
	public static string FormatTime(float seconds)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x8CC164", Offset = "0x8CC164", VA = "0x8CC164")]
	public void EenmyUIReset()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x8CC228", Offset = "0x8CC228", VA = "0x8CC228")]
	private void BornEnmey()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x8C98D8", Offset = "0x8C98D8", VA = "0x8C98D8")]
	public void EnmeyBeDestory()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x8CB9D4", Offset = "0x8CB9D4", VA = "0x8CB9D4")]
	private void finishGame()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x8CC6C0", Offset = "0x8CC6C0", VA = "0x8CC6C0")]
	public void ReloadGlame()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x8CC73C", Offset = "0x8CC73C", VA = "0x8CC73C")]
	public void ContinueBtnClick()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x8CC744", Offset = "0x8CC744", VA = "0x8CC744")]
	public void QuitGame()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x8CC7C0", Offset = "0x8CC7C0", VA = "0x8CC7C0")]
	public void StartGame()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x8CB938", Offset = "0x8CB938", VA = "0x8CB938")]
	private void ShowPauseWin(bool isShow)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x8CB5A4", Offset = "0x8CB5A4", VA = "0x8CB5A4")]
	private void InitPicoService()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x8CC5E8", Offset = "0x8CC5E8", VA = "0x8CC5E8")]
	private void UpLoadLeaderboardData(int score)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x8CC84C", Offset = "0x8CC84C", VA = "0x8CC84C")]
	public Ryunm_GameManager()
	{
	}
}
[Token(Token = "0x2000029")]
public class Ryunm_Health : MonoBehaviour
{
	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x18")]
	public float phValue;

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x8CC910", Offset = "0x8CC910", VA = "0x8CC910")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x8CCA00", Offset = "0x8CCA00", VA = "0x8CCA00")]
	public Ryunm_Health()
	{
	}
}
[Token(Token = "0x200002A")]
public class Ryunm_SelfDestory : MonoBehaviour
{
	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x18")]
	public float delayTime;

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x8CCA10", Offset = "0x8CCA10", VA = "0x8CCA10")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x8CCA8C", Offset = "0x8CCA8C", VA = "0x8CCA8C")]
	public Ryunm_SelfDestory()
	{
	}
}
[Token(Token = "0x200002B")]
public class Ryunm_Weapon2Controller : MonoBehaviour
{
	[Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class <WeaponBack>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x20")]
		public Ryunm_Weapon2Controller <>4__this;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x8CD394", Offset = "0x8CD394", VA = "0x8CD394", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x8CD3DC", Offset = "0x8CD3DC", VA = "0x8CD3DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x8CCEE8", Offset = "0x8CCEE8", VA = "0x8CCEE8")]
		[DebuggerHidden]
		public <WeaponBack>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x8CD19C", Offset = "0x8CD19C", VA = "0x8CD19C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x8CD1A0", Offset = "0x8CD1A0", VA = "0x8CD1A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x8CD39C", Offset = "0x8CD39C", VA = "0x8CD39C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class <ToCenter>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x20")]
		public Ryunm_Weapon2Controller <>4__this;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 <currentVeloCity>5__2;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x34")]
		private float <currentFloat>5__3;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x8CD668", Offset = "0x8CD668", VA = "0x8CD668", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x8CD6B0", Offset = "0x8CD6B0", VA = "0x8CD6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x8CCF84", Offset = "0x8CCF84", VA = "0x8CCF84")]
		[DebuggerHidden]
		public <ToCenter>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x8CD3E4", Offset = "0x8CD3E4", VA = "0x8CD3E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x8CD3E8", Offset = "0x8CD3E8", VA = "0x8CD3E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x8CD670", Offset = "0x8CD670", VA = "0x8CD670", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class <ToStart>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x20")]
		public Ryunm_Weapon2Controller <>4__this;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 <currentVeloCity>5__2;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x34")]
		private float <currentFloat>5__3;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x8CD940", Offset = "0x8CD940", VA = "0x8CD940", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x8CD988", Offset = "0x8CD988", VA = "0x8CD988", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x8CD020", Offset = "0x8CD020", VA = "0x8CD020")]
		[DebuggerHidden]
		public <ToStart>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x8CD6B8", Offset = "0x8CD6B8", VA = "0x8CD6B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x8CD6BC", Offset = "0x8CD6BC", VA = "0x8CD6BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x8CD948", Offset = "0x8CD948", VA = "0x8CD948", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class <RealoadBullet>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x20")]
		public Ryunm_Weapon2Controller <>4__this;

		[Token(Token = "0x1700000B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x8CDAAC", Offset = "0x8CDAAC", VA = "0x8CDAAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x8CDAF4", Offset = "0x8CDAF4", VA = "0x8CDAF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x8CD12C", Offset = "0x8CD12C", VA = "0x8CD12C")]
		[DebuggerHidden]
		public <RealoadBullet>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x8CD990", Offset = "0x8CD990", VA = "0x8CD990", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x8CD994", Offset = "0x8CD994", VA = "0x8CD994", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x8CDAB4", Offset = "0x8CDAB4", VA = "0x8CDAB4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x18")]
	public Transform bulletStartPoint;

	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x20")]
	public GameObject bulletPrefabs;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x28")]
	public float bulletSpeed;

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x30")]
	public AudioSource fireAudio;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x38")]
	public float intervalTime;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x3C")]
	public float fireTimer;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x40")]
	[Header("\ufffd\ufffd\ufffd\ufffdĺ\ufffd\ufffd\ufffd\ufffd\ufffd")]
	public Transform weaponBody;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x48")]
	public Transform startPoint;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x50")]
	public Transform backPoint;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x58")]
	public float lerpValue;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x60")]
	[Header("\ufffdӿڵ\ufffd\ufffd\ufffd")]
	public Camera mainCamera;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x68")]
	public Camera weaponCamera;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x70")]
	public float startFieldView;

	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x74")]
	public float endFieldView;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 weaponCameraStartPoint;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x84")]
	public Vector3 weaponCameraCenterPoint;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x90")]
	public float smoothTime;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x98")]
	public Ryunm_AnimatorController playerAni;

	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0xA0")]
	[Header("\ufffd\ufffdϻ\ufffd\ufffd\ufffd\ufffd")]
	public Slider bulletCountSlider;

	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0xA8")]
	public float maxBulletCount;

	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0xAC")]
	public float currentBulletCount;

	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0xB0")]
	public float reloadSpeed;

	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0xB4")]
	public float reloadWaitTime;

	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0xB8")]
	public XRController leftController;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0xC0")]
	private bool rTriggerBtnState;

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x8CCA9C", Offset = "0x8CCA9C", VA = "0x8CCA9C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x8CCB38", Offset = "0x8CCB38", VA = "0x8CCB38")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x8CCC1C", Offset = "0x8CCC1C", VA = "0x8CCC1C")]
	public void OpenFire()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x8CCE74", Offset = "0x8CCE74", VA = "0x8CCE74")]
	[IteratorStateMachine(typeof(<WeaponBack>d__28))]
	private IEnumerator WeaponBack()
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x8CCF10", Offset = "0x8CCF10", VA = "0x8CCF10")]
	[IteratorStateMachine(typeof(<ToCenter>d__29))]
	private IEnumerator ToCenter()
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x8CCFAC", Offset = "0x8CCFAC", VA = "0x8CCFAC")]
	[IteratorStateMachine(typeof(<ToStart>d__30))]
	private IEnumerator ToStart()
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x8CD048", Offset = "0x8CD048", VA = "0x8CD048")]
	[ContextMenu("Set Start point")]
	public void SetWeaponCameraStartPoint()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x8CD080", Offset = "0x8CD080", VA = "0x8CD080")]
	[ContextMenu("Set Center point")]
	public void SetWeaponCameraCenterPoint()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x8CD0B8", Offset = "0x8CD0B8", VA = "0x8CD0B8")]
	[IteratorStateMachine(typeof(<RealoadBullet>d__33))]
	private IEnumerator RealoadBullet()
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x8CD154", Offset = "0x8CD154", VA = "0x8CD154")]
	public Ryunm_Weapon2Controller()
	{
	}
}
[Token(Token = "0x2000030")]
public class sanjiao : MonoBehaviour
{
	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject player;

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x8CDAFC", Offset = "0x8CDAFC", VA = "0x8CDAFC")]
	private void Start()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x8CDB34", Offset = "0x8CDB34", VA = "0x8CDB34")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x8CDCB0", Offset = "0x8CDCB0", VA = "0x8CDCB0")]
	public sanjiao()
	{
	}
}
[Token(Token = "0x2000031")]
public class SimpleLogic : MonoBehaviour
{
	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x8CDCB8", Offset = "0x8CDCB8", VA = "0x8CDCB8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x8CDCD8", Offset = "0x8CDCD8", VA = "0x8CDCD8")]
	public SimpleLogic()
	{
	}
}
[Token(Token = "0x2000032")]
public class Ryunm_WeaponController : MonoBehaviour
{
	[Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class <WeaponBack>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x20")]
		public Ryunm_WeaponController <>4__this;

		[Token(Token = "0x1700000D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x8CE5D8", Offset = "0x8CE5D8", VA = "0x8CE5D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x8CE620", Offset = "0x8CE620", VA = "0x8CE620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x8CE12C", Offset = "0x8CE12C", VA = "0x8CE12C")]
		[DebuggerHidden]
		public <WeaponBack>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x8CE3E0", Offset = "0x8CE3E0", VA = "0x8CE3E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x8CE3E4", Offset = "0x8CE3E4", VA = "0x8CE3E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x8CE5E0", Offset = "0x8CE5E0", VA = "0x8CE5E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class <ToCenter>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x20")]
		public Ryunm_WeaponController <>4__this;

		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 <currentVeloCity>5__2;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x34")]
		private float <currentFloat>5__3;

		[Token(Token = "0x1700000F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x8CE8AC", Offset = "0x8CE8AC", VA = "0x8CE8AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x8CE8F4", Offset = "0x8CE8F4", VA = "0x8CE8F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x8CE1C8", Offset = "0x8CE1C8", VA = "0x8CE1C8")]
		[DebuggerHidden]
		public <ToCenter>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x8CE628", Offset = "0x8CE628", VA = "0x8CE628", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x8CE62C", Offset = "0x8CE62C", VA = "0x8CE62C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x8CE8B4", Offset = "0x8CE8B4", VA = "0x8CE8B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class <ToStart>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x20")]
		public Ryunm_WeaponController <>4__this;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 <currentVeloCity>5__2;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x34")]
		private float <currentFloat>5__3;

		[Token(Token = "0x17000011")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x8CEB84", Offset = "0x8CEB84", VA = "0x8CEB84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x8CEBCC", Offset = "0x8CEBCC", VA = "0x8CEBCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x8CE264", Offset = "0x8CE264", VA = "0x8CE264")]
		[DebuggerHidden]
		public <ToStart>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x8CE8FC", Offset = "0x8CE8FC", VA = "0x8CE8FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x8CE900", Offset = "0x8CE900", VA = "0x8CE900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x8CEB8C", Offset = "0x8CEB8C", VA = "0x8CEB8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class <RealoadBullet>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x20")]
		public Ryunm_WeaponController <>4__this;

		[Token(Token = "0x17000013")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x8CECF0", Offset = "0x8CECF0", VA = "0x8CECF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x8CED38", Offset = "0x8CED38", VA = "0x8CED38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x8CE370", Offset = "0x8CE370", VA = "0x8CE370")]
		[DebuggerHidden]
		public <RealoadBullet>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x8CEBD4", Offset = "0x8CEBD4", VA = "0x8CEBD4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x8CEBD8", Offset = "0x8CEBD8", VA = "0x8CEBD8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x8CECF8", Offset = "0x8CECF8", VA = "0x8CECF8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x18")]
	public Transform bulletStartPoint;

	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject bulletPrefabs;

	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x28")]
	public float bulletSpeed;

	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x30")]
	public AudioSource fireAudio;

	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x38")]
	public float intervalTime;

	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x3C")]
	public float fireTimer;

	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x40")]
	[Header("\ufffd\ufffd\ufffd\ufffdĺ\ufffd\ufffd\ufffd\ufffd\ufffd")]
	public Transform weaponBody;

	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x48")]
	public Transform startPoint;

	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x50")]
	public Transform backPoint;

	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x58")]
	public float lerpValue;

	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x60")]
	[Header("\ufffdӿڵ\ufffd\ufffd\ufffd")]
	public Camera mainCamera;

	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x68")]
	public Camera weaponCamera;

	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x70")]
	public float startFieldView;

	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x74")]
	public float endFieldView;

	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 weaponCameraStartPoint;

	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x84")]
	public Vector3 weaponCameraCenterPoint;

	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x90")]
	public float smoothTime;

	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x98")]
	public Ryunm_AnimatorController playerAni;

	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0xA0")]
	[Header("\ufffd\ufffdϻ\ufffd\ufffd\ufffd\ufffd")]
	public Slider bulletCountSlider;

	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0xA8")]
	public float maxBulletCount;

	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0xAC")]
	public float currentBulletCount;

	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0xB0")]
	public float reloadSpeed;

	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0xB4")]
	public float reloadWaitTime;

	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0xB8")]
	public XRController leftController;

	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0xC0")]
	private bool rTriggerBtnState;

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x8CDCE0", Offset = "0x8CDCE0", VA = "0x8CDCE0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x8CDD7C", Offset = "0x8CDD7C", VA = "0x8CDD7C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x8CDE60", Offset = "0x8CDE60", VA = "0x8CDE60")]
	public void OpenFire()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x8CE0B8", Offset = "0x8CE0B8", VA = "0x8CE0B8")]
	[IteratorStateMachine(typeof(<WeaponBack>d__28))]
	private IEnumerator WeaponBack()
	{
		return null;
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x8CE154", Offset = "0x8CE154", VA = "0x8CE154")]
	[IteratorStateMachine(typeof(<ToCenter>d__29))]
	private IEnumerator ToCenter()
	{
		return null;
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x8CE1F0", Offset = "0x8CE1F0", VA = "0x8CE1F0")]
	[IteratorStateMachine(typeof(<ToStart>d__30))]
	private IEnumerator ToStart()
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x8CE28C", Offset = "0x8CE28C", VA = "0x8CE28C")]
	[ContextMenu("Set Start point")]
	public void SetWeaponCameraStartPoint()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x8CE2C4", Offset = "0x8CE2C4", VA = "0x8CE2C4")]
	[ContextMenu("Set Center point")]
	public void SetWeaponCameraCenterPoint()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x8CE2FC", Offset = "0x8CE2FC", VA = "0x8CE2FC")]
	[IteratorStateMachine(typeof(<RealoadBullet>d__33))]
	private IEnumerator RealoadBullet()
	{
		return null;
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x8CE398", Offset = "0x8CE398", VA = "0x8CE398")]
	public Ryunm_WeaponController()
	{
	}
}
[Token(Token = "0x2000037")]
public class XrContrller : XRController
{
	[Token(Token = "0x6000115")]
	[Address(RVA = "0x8CED40", Offset = "0x8CED40", VA = "0x8CED40")]
	public XrContrller()
	{
	}
}
[Token(Token = "0x2000038")]
public class zhuxin : MonoBehaviour
{
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x8CED48", Offset = "0x8CED48", VA = "0x8CED48")]
	private void Start()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x8CED80", Offset = "0x8CED80", VA = "0x8CED80")]
	private void Update()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x8CEE24", Offset = "0x8CEE24", VA = "0x8CEE24")]
	public zhuxin()
	{
	}
}
namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000039")]
	public class TMP_DigitValidator : TMP_InputValidator
	{
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x8CEE2C", Offset = "0x8CEE2C", VA = "0x8CEE2C", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x8CEEAC", Offset = "0x8CEEAC", VA = "0x8CEEAC")]
		public TMP_DigitValidator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	public class TMP_PhoneNumberValidator : TMP_InputValidator
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x8CEEB4", Offset = "0x8CEEB4", VA = "0x8CEEB4", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x8CF328", Offset = "0x8CF328", VA = "0x8CF328")]
		public TMP_PhoneNumberValidator()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Serializable]
		[Token(Token = "0x200003C")]
		public class CharacterSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x8CFD6C", Offset = "0x8CFD6C", VA = "0x8CFD6C")]
			public CharacterSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200003D")]
		public class SpriteSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x8CFDB4", Offset = "0x8CFDB4", VA = "0x8CFDB4")]
			public SpriteSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200003E")]
		public class WordSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x8CFDFC", Offset = "0x8CFDFC", VA = "0x8CFDFC")]
			public WordSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200003F")]
		public class LineSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x8CFE44", Offset = "0x8CFE44", VA = "0x8CFE44")]
			public LineSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000040")]
		public class LinkSelectionEvent : UnityEvent<string, string, int>
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x8CFE8C", Offset = "0x8CFE8C", VA = "0x8CFE8C")]
			public LinkSelectionEvent()
			{
			}
		}

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterSelectionEvent m_OnCharacterSelection;

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpriteSelectionEvent m_OnSpriteSelection;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WordSelectionEvent m_OnWordSelection;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LineSelectionEvent m_OnLineSelection;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LinkSelectionEvent m_OnLinkSelection;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x40")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_Camera;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x50")]
		private Canvas m_Canvas;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x58")]
		private int m_selectedLink;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x5C")]
		private int m_lastCharIndex;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x60")]
		private int m_lastWordIndex;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x64")]
		private int m_lastLineIndex;

		[Token(Token = "0x17000015")]
		public CharacterSelectionEvent onCharacterSelection
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x8CF330", Offset = "0x8CF330", VA = "0x8CF330")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x8CF338", Offset = "0x8CF338", VA = "0x8CF338")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public SpriteSelectionEvent onSpriteSelection
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x8CF340", Offset = "0x8CF340", VA = "0x8CF340")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x8CF348", Offset = "0x8CF348", VA = "0x8CF348")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public WordSelectionEvent onWordSelection
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x8CF350", Offset = "0x8CF350", VA = "0x8CF350")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x8CF358", Offset = "0x8CF358", VA = "0x8CF358")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public LineSelectionEvent onLineSelection
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x8CF360", Offset = "0x8CF360", VA = "0x8CF360")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x8CF368", Offset = "0x8CF368", VA = "0x8CF368")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public LinkSelectionEvent onLinkSelection
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x8CF370", Offset = "0x8CF370", VA = "0x8CF370")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x8CF378", Offset = "0x8CF378", VA = "0x8CF378")]
			set
			{
			}
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x8CF380", Offset = "0x8CF380", VA = "0x8CF380")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x8CF538", Offset = "0x8CF538", VA = "0x8CF538")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x8CFC0C", Offset = "0x8CFC0C", VA = "0x8CFC0C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x8CFC10", Offset = "0x8CFC10", VA = "0x8CFC10", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x8CF9B0", Offset = "0x8CF9B0", VA = "0x8CF9B0")]
		private void SendOnCharacterSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x8CFA24", Offset = "0x8CFA24", VA = "0x8CFA24")]
		private void SendOnSpriteSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x8CFA98", Offset = "0x8CFA98", VA = "0x8CFA98")]
		private void SendOnWordSelection(string word, int charIndex, int length)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x8CFB14", Offset = "0x8CFB14", VA = "0x8CFB14")]
		private void SendOnLineSelection(string line, int charIndex, int length)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x8CFB90", Offset = "0x8CFB90", VA = "0x8CFB90")]
		private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x8CFC14", Offset = "0x8CFC14", VA = "0x8CFC14")]
		public TMP_TextEventHandler()
		{
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x2000041")]
	public class Benchmark01 : MonoBehaviour
	{
		[Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400012A")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400012B")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400012C")]
			[FieldOffset(Offset = "0x20")]
			public Benchmark01 <>4__this;

			[Token(Token = "0x400012D")]
			[FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700001A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600013B")]
				[Address(RVA = "0x8D052C", Offset = "0x8D052C", VA = "0x8D052C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600013D")]
				[Address(RVA = "0x8D0574", Offset = "0x8D0574", VA = "0x8D0574", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0x8CFF48", Offset = "0x8CFF48", VA = "0x8CFF48")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000139")]
			[Address(RVA = "0x8CFF78", Offset = "0x8CFF78", VA = "0x8CFF78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600013A")]
			[Address(RVA = "0x8CFF7C", Offset = "0x8CFF7C", VA = "0x8CFF7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600013C")]
			[Address(RVA = "0x8D0534", Offset = "0x8D0534", VA = "0x8D0534", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x20")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x28")]
		public Font TextMeshFont;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x30")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x38")]
		private TextContainer m_textContainer;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x40")]
		private TextMesh m_textMesh;

		[Token(Token = "0x4000126")]
		private const string label01 = "The <#0050FF>count is: </color>{0}";

		[Token(Token = "0x4000127")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x8CFED4", Offset = "0x8CFED4", VA = "0x8CFED4")]
		[IteratorStateMachine(typeof(<Start>d__10))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x8CFF70", Offset = "0x8CFF70", VA = "0x8CFF70")]
		public Benchmark01()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class Benchmark01_UGUI : MonoBehaviour
	{
		[Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000138")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000139")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400013A")]
			[FieldOffset(Offset = "0x20")]
			public Benchmark01_UGUI <>4__this;

			[Token(Token = "0x400013B")]
			[FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700001C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000143")]
				[Address(RVA = "0x8D0AB8", Offset = "0x8D0AB8", VA = "0x8D0AB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000145")]
				[Address(RVA = "0x8D0B00", Offset = "0x8D0B00", VA = "0x8D0B00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000140")]
			[Address(RVA = "0x8D05F0", Offset = "0x8D05F0", VA = "0x8D05F0")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000141")]
			[Address(RVA = "0x8D0620", Offset = "0x8D0620", VA = "0x8D0620", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000142")]
			[Address(RVA = "0x8D0624", Offset = "0x8D0624", VA = "0x8D0624", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000144")]
			[Address(RVA = "0x8D0AC0", Offset = "0x8D0AC0", VA = "0x8D0AC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x20")]
		public Canvas canvas;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x28")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x30")]
		public Font TextMeshFont;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI m_textMeshPro;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x40")]
		private Text m_textMesh;

		[Token(Token = "0x4000134")]
		private const string label01 = "The <#0050FF>count is: </color>";

		[Token(Token = "0x4000135")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x8D057C", Offset = "0x8D057C", VA = "0x8D057C")]
		[IteratorStateMachine(typeof(<Start>d__10))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x8D0618", Offset = "0x8D0618", VA = "0x8D0618")]
		public Benchmark01_UGUI()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class Benchmark02 : MonoBehaviour
	{
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x20")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x8D0B08", Offset = "0x8D0B08", VA = "0x8D0B08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x8D1108", Offset = "0x8D1108", VA = "0x8D1108")]
		public Benchmark02()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class Benchmark03 : MonoBehaviour
	{
		[Token(Token = "0x2000047")]
		public enum BenchmarkType
		{
			[Token(Token = "0x4000144")]
			TMP_SDF_MOBILE,
			[Token(Token = "0x4000145")]
			TMP_SDF__MOBILE_SSD,
			[Token(Token = "0x4000146")]
			TMP_SDF,
			[Token(Token = "0x4000147")]
			TMP_BITMAP_MOBILE,
			[Token(Token = "0x4000148")]
			TEXTMESH_BITMAP
		}

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x18")]
		public int NumberOfSamples;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x1C")]
		public BenchmarkType Benchmark;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x20")]
		public Font SourceFont;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x8D1118", Offset = "0x8D1118", VA = "0x8D1118")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x8D111C", Offset = "0x8D111C", VA = "0x8D111C")]
		private void Start()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x8D1558", Offset = "0x8D1558", VA = "0x8D1558")]
		public Benchmark03()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class Benchmark04 : MonoBehaviour
	{
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x1C")]
		public int MinPointSize;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x20")]
		public int MaxPointSize;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x24")]
		public int Steps;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x28")]
		private Transform m_Transform;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x8D1568", Offset = "0x8D1568", VA = "0x8D1568")]
		private void Start()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x8D1870", Offset = "0x8D1870", VA = "0x8D1870")]
		public Benchmark04()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class CameraController : MonoBehaviour
	{
		[Token(Token = "0x200004A")]
		public enum CameraModes
		{
			[Token(Token = "0x4000168")]
			Follow,
			[Token(Token = "0x4000169")]
			Isometric,
			[Token(Token = "0x400016A")]
			Free
		}

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x18")]
		private Transform cameraTransform;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x20")]
		private Transform dummyTarget;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x28")]
		public Transform CameraTarget;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x30")]
		public float FollowDistance;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x34")]
		public float MaxFollowDistance;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x38")]
		public float MinFollowDistance;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x3C")]
		public float ElevationAngle;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x40")]
		public float MaxElevationAngle;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x44")]
		public float MinElevationAngle;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x48")]
		public float OrbitalAngle;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x4C")]
		public CameraModes CameraMode;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x50")]
		public bool MovementSmoothing;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x51")]
		public bool RotationSmoothing;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x52")]
		private bool previousSmoothing;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x54")]
		public float MovementSmoothingValue;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x58")]
		public float RotationSmoothingValue;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x5C")]
		public float MoveSensitivity;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 currentVelocity;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 desiredPosition;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x78")]
		private float mouseX;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x7C")]
		private float mouseY;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 moveVector;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x8C")]
		private float mouseWheel;

		[Token(Token = "0x4000165")]
		private const string event_SmoothingValue = "Slider - Smoothing Value";

		[Token(Token = "0x4000166")]
		private const string event_FollowDistance = "Slider - Camera Zoom";

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x8D188C", Offset = "0x8D188C", VA = "0x8D188C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x8D1908", Offset = "0x8D1908", VA = "0x8D1908")]
		private void Start()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x8D19FC", Offset = "0x8D19FC", VA = "0x8D19FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x8D1D30", Offset = "0x8D1D30", VA = "0x8D1D30")]
		private void GetPlayerInput()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x8D2558", Offset = "0x8D2558", VA = "0x8D2558")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class ObjectSpin : MonoBehaviour
	{
		[Token(Token = "0x200004C")]
		public enum MotionType
		{
			[Token(Token = "0x4000176")]
			Rotation,
			[Token(Token = "0x4000177")]
			BackAndForth,
			[Token(Token = "0x4000178")]
			Translation
		}

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x18")]
		public float SpinSpeed;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x1C")]
		public int RotationRange;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x20")]
		private Transform m_transform;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x28")]
		private float m_time;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 m_prevPOS;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_initial_Rotation;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_initial_Position;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x50")]
		private Color32 m_lightColor;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x54")]
		private int frames;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x58")]
		public MotionType Motion;

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x8D25E4", Offset = "0x8D25E4", VA = "0x8D25E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x8D29CC", Offset = "0x8D29CC", VA = "0x8D29CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x8D2B14", Offset = "0x8D2B14", VA = "0x8D2B14")]
		public ObjectSpin()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class ShaderPropAnimator : MonoBehaviour
	{
		[Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class <AnimateProperties>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400017D")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400017E")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400017F")]
			[FieldOffset(Offset = "0x20")]
			public ShaderPropAnimator <>4__this;

			[Token(Token = "0x1700001E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600015C")]
				[Address(RVA = "0x8D2DD4", Offset = "0x8D2DD4", VA = "0x8D2DD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600015E")]
				[Address(RVA = "0x8D2E1C", Offset = "0x8D2E1C", VA = "0x8D2E1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000159")]
			[Address(RVA = "0x8D2C3C", Offset = "0x8D2C3C", VA = "0x8D2C3C")]
			[DebuggerHidden]
			public <AnimateProperties>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600015A")]
			[Address(RVA = "0x8D2C6C", Offset = "0x8D2C6C", VA = "0x8D2C6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600015B")]
			[Address(RVA = "0x8D2C70", Offset = "0x8D2C70", VA = "0x8D2C70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600015D")]
			[Address(RVA = "0x8D2DDC", Offset = "0x8D2DDC", VA = "0x8D2DDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x18")]
		private Renderer m_Renderer;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve GlowCurve;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x30")]
		public float m_frame;

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x8D2B28", Offset = "0x8D2B28", VA = "0x8D2B28")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x8D2BA8", Offset = "0x8D2BA8", VA = "0x8D2BA8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x8D2BC8", Offset = "0x8D2BC8", VA = "0x8D2BC8")]
		[IteratorStateMachine(typeof(<AnimateProperties>d__6))]
		private IEnumerator AnimateProperties()
		{
			return null;
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x8D2C64", Offset = "0x8D2C64", VA = "0x8D2C64")]
		public ShaderPropAnimator()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class SimpleScript : MonoBehaviour
	{
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x18")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x4000181")]
		private const string label = "The <#0050FF>count is: </color>{0:2}";

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x20")]
		private float m_frame;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x8D2E24", Offset = "0x8D2E24", VA = "0x8D2E24")]
		private void Start()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x8D2EE8", Offset = "0x8D2EE8", VA = "0x8D2EE8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x8D2F74", Offset = "0x8D2F74", VA = "0x8D2F74")]
		public SimpleScript()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class SkewTextExample : MonoBehaviour
	{
		[Token(Token = "0x2000051")]
		[CompilerGenerated]
		private sealed class <WarpText>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000187")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000188")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000189")]
			[FieldOffset(Offset = "0x20")]
			public SkewTextExample <>4__this;

			[Token(Token = "0x400018A")]
			[FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x400018B")]
			[FieldOffset(Offset = "0x2C")]
			private float <old_ShearValue>5__3;

			[Token(Token = "0x400018C")]
			[FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__4;

			[Token(Token = "0x17000020")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600016A")]
				[Address(RVA = "0x8D3C94", Offset = "0x8D3C94", VA = "0x8D3C94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000021")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600016C")]
				[Address(RVA = "0x8D3CDC", Offset = "0x8D3CDC", VA = "0x8D3CDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000167")]
			[Address(RVA = "0x8D30F8", Offset = "0x8D30F8", VA = "0x8D30F8")]
			[DebuggerHidden]
			public <WarpText>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000168")]
			[Address(RVA = "0x8D335C", Offset = "0x8D335C", VA = "0x8D335C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000169")]
			[Address(RVA = "0x8D3360", Offset = "0x8D3360", VA = "0x8D3360", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600016B")]
			[Address(RVA = "0x8D3C9C", Offset = "0x8D3C9C", VA = "0x8D3C9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x28")]
		public float CurveScale;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x2C")]
		public float ShearAmount;

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x8D2F7C", Offset = "0x8D2F7C", VA = "0x8D2F7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x8D2FE4", Offset = "0x8D2FE4", VA = "0x8D2FE4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x8D3078", Offset = "0x8D3078", VA = "0x8D3078")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x8D3004", Offset = "0x8D3004", VA = "0x8D3004")]
		[IteratorStateMachine(typeof(<WarpText>d__7))]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x8D3120", Offset = "0x8D3120", VA = "0x8D3120")]
		public SkewTextExample()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class TeleType : MonoBehaviour
	{
		[Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000190")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000191")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000192")]
			[FieldOffset(Offset = "0x20")]
			public TeleType <>4__this;

			[Token(Token = "0x4000193")]
			[FieldOffset(Offset = "0x28")]
			private int <totalVisibleCharacters>5__2;

			[Token(Token = "0x4000194")]
			[FieldOffset(Offset = "0x2C")]
			private int <counter>5__3;

			[Token(Token = "0x17000022")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000173")]
				[Address(RVA = "0x8D40D4", Offset = "0x8D40D4", VA = "0x8D40D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000023")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000175")]
				[Address(RVA = "0x8D411C", Offset = "0x8D411C", VA = "0x8D411C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000170")]
			[Address(RVA = "0x8D3DFC", Offset = "0x8D3DFC", VA = "0x8D3DFC")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000171")]
			[Address(RVA = "0x8D3EA8", Offset = "0x8D3EA8", VA = "0x8D3EA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000172")]
			[Address(RVA = "0x8D3EAC", Offset = "0x8D3EAC", VA = "0x8D3EAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000174")]
			[Address(RVA = "0x8D40DC", Offset = "0x8D40DC", VA = "0x8D40DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x18")]
		private string label01;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x20")]
		private string label02;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x28")]
		private TMP_Text m_textMeshPro;

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x8D3CE4", Offset = "0x8D3CE4", VA = "0x8D3CE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x8D3D88", Offset = "0x8D3D88", VA = "0x8D3D88")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x8D3E24", Offset = "0x8D3E24", VA = "0x8D3E24")]
		public TeleType()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class TextConsoleSimulator : MonoBehaviour
	{
		[Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class <RevealCharacters>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000197")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000198")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000199")]
			[FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x400019A")]
			[FieldOffset(Offset = "0x28")]
			public TextConsoleSimulator <>4__this;

			[Token(Token = "0x400019B")]
			[FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x400019C")]
			[FieldOffset(Offset = "0x38")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x400019D")]
			[FieldOffset(Offset = "0x3C")]
			private int <visibleCount>5__4;

			[Token(Token = "0x17000024")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000181")]
				[Address(RVA = "0x8D460C", Offset = "0x8D460C", VA = "0x8D460C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000025")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000183")]
				[Address(RVA = "0x8D4654", Offset = "0x8D4654", VA = "0x8D4654", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600017E")]
			[Address(RVA = "0x8D43E4", Offset = "0x8D43E4", VA = "0x8D43E4")]
			[DebuggerHidden]
			public <RevealCharacters>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600017F")]
			[Address(RVA = "0x8D4488", Offset = "0x8D4488", VA = "0x8D4488", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000180")]
			[Address(RVA = "0x8D448C", Offset = "0x8D448C", VA = "0x8D448C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000182")]
			[Address(RVA = "0x8D4614", Offset = "0x8D4614", VA = "0x8D4614", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class <RevealWords>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400019E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400019F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001A0")]
			[FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x40001A1")]
			[FieldOffset(Offset = "0x28")]
			private int <totalWordCount>5__2;

			[Token(Token = "0x40001A2")]
			[FieldOffset(Offset = "0x2C")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x40001A3")]
			[FieldOffset(Offset = "0x30")]
			private int <counter>5__4;

			[Token(Token = "0x40001A4")]
			[FieldOffset(Offset = "0x34")]
			private int <visibleCount>5__5;

			[Token(Token = "0x17000026")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000187")]
				[Address(RVA = "0xDC20B8", Offset = "0xDC20B8", VA = "0xDC20B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000027")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000189")]
				[Address(RVA = "0xDC2100", Offset = "0xDC2100", VA = "0xDC2100", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000184")]
			[Address(RVA = "0xDC1EB8", Offset = "0xDC1EB8", VA = "0xDC1EB8")]
			[DebuggerHidden]
			public <RevealWords>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000185")]
			[Address(RVA = "0xDC1EE0", Offset = "0xDC1EE0", VA = "0xDC1EE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000186")]
			[Address(RVA = "0xDC1EE4", Offset = "0xDC1EE4", VA = "0xDC1EE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000188")]
			[Address(RVA = "0xDC20C0", Offset = "0xDC20C0", VA = "0xDC20C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x20")]
		private bool hasTextChanged;

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x8D4124", Offset = "0x8D4124", VA = "0x8D4124")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x8D418C", Offset = "0x8D418C", VA = "0x8D418C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x8D4240", Offset = "0x8D4240", VA = "0x8D4240")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x8D430C", Offset = "0x8D430C", VA = "0x8D430C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x8D43D8", Offset = "0x8D43D8", VA = "0x8D43D8")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x8D41B0", Offset = "0x8D41B0", VA = "0x8D41B0")]
		[IteratorStateMachine(typeof(<RevealCharacters>d__7))]
		private IEnumerator RevealCharacters(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x8D440C", Offset = "0x8D440C", VA = "0x8D440C")]
		[IteratorStateMachine(typeof(<RevealWords>d__8))]
		private IEnumerator RevealWords(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x8D4480", Offset = "0x8D4480", VA = "0x8D4480")]
		public TextConsoleSimulator()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class TextMeshProFloatingText : MonoBehaviour
	{
		[Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class <DisplayTextMeshProFloatingText>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001B2")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001B3")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001B4")]
			[FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x40001B5")]
			[FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x40001B6")]
			[FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x40001B7")]
			[FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x40001B8")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x40001B9")]
			[FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x40001BA")]
			[FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x40001BB")]
			[FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x17000028")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000193")]
				[Address(RVA = "0xDC35EC", Offset = "0xDC35EC", VA = "0xDC35EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000029")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000195")]
				[Address(RVA = "0xDC3634", Offset = "0xDC3634", VA = "0xDC3634", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000190")]
			[Address(RVA = "0xDC26F4", Offset = "0xDC26F4", VA = "0xDC26F4")]
			[DebuggerHidden]
			public <DisplayTextMeshProFloatingText>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000191")]
			[Address(RVA = "0xDC2EF8", Offset = "0xDC2EF8", VA = "0xDC2EF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000192")]
			[Address(RVA = "0xDC2EFC", Offset = "0xDC2EFC", VA = "0xDC2EFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000194")]
			[Address(RVA = "0xDC35F4", Offset = "0xDC35F4", VA = "0xDC35F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000059")]
		[CompilerGenerated]
		private sealed class <DisplayTextMeshFloatingText>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001BC")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001BD")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001BE")]
			[FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x40001BF")]
			[FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x40001C0")]
			[FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x40001C1")]
			[FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x40001C2")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x40001C3")]
			[FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x40001C4")]
			[FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x40001C5")]
			[FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x1700002A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000199")]
				[Address(RVA = "0xDC3D18", Offset = "0xDC3D18", VA = "0xDC3D18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600019B")]
				[Address(RVA = "0xDC3D60", Offset = "0xDC3D60", VA = "0xDC3D60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000196")]
			[Address(RVA = "0xDC271C", Offset = "0xDC271C", VA = "0xDC271C")]
			[DebuggerHidden]
			public <DisplayTextMeshFloatingText>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0xDC363C", Offset = "0xDC363C", VA = "0xDC363C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000198")]
			[Address(RVA = "0xDC3640", Offset = "0xDC3640", VA = "0xDC3640", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600019A")]
			[Address(RVA = "0xDC3D20", Offset = "0xDC3D20", VA = "0xDC3D20", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x18")]
		public Font TheFont;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_floatingText;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x28")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x30")]
		private TextMesh m_textMesh;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_transform;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x40")]
		private Transform m_floatingText_Transform;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x48")]
		private Transform m_cameraTransform;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 lastPOS;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x5C")]
		private Quaternion lastRotation;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x6C")]
		public int SpawnType;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x70")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x0")]
		private static WaitForEndOfFrame k_WaitForEndOfFrame;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x8")]
		private static WaitForSeconds[] k_WaitForSecondsRandom;

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xDC2108", Offset = "0xDC2108", VA = "0xDC2108")]
		private void Awake()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xDC21F0", Offset = "0xDC21F0", VA = "0xDC21F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xDC260C", Offset = "0xDC260C", VA = "0xDC260C")]
		[IteratorStateMachine(typeof(<DisplayTextMeshProFloatingText>d__15))]
		public IEnumerator DisplayTextMeshProFloatingText()
		{
			return null;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xDC2680", Offset = "0xDC2680", VA = "0xDC2680")]
		[IteratorStateMachine(typeof(<DisplayTextMeshFloatingText>d__16))]
		public IEnumerator DisplayTextMeshFloatingText()
		{
			return null;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xDC2744", Offset = "0xDC2744", VA = "0xDC2744")]
		public TextMeshProFloatingText()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class TextMeshSpawner : MonoBehaviour
	{
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x20")]
		public Font TheFont;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xDC3D68", Offset = "0xDC3D68", VA = "0xDC3D68")]
		private void Awake()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xDC3D6C", Offset = "0xDC3D6C", VA = "0xDC3D6C")]
		private void Start()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xDC406C", Offset = "0xDC406C", VA = "0xDC406C")]
		public TextMeshSpawner()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class TMPro_InstructionOverlay : MonoBehaviour
	{
		[Token(Token = "0x200005C")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x40001D1")]
			TopLeft,
			[Token(Token = "0x40001D2")]
			BottomLeft,
			[Token(Token = "0x40001D3")]
			TopRight,
			[Token(Token = "0x40001D4")]
			BottomRight
		}

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x18")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x40001CB")]
		private const string instructions = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x20")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x28")]
		private TextContainer m_textContainer;

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x30")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x38")]
		private Camera m_camera;

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xDC407C", Offset = "0xDC407C", VA = "0xDC407C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xDC4334", Offset = "0xDC4334", VA = "0xDC4334")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xDC4448", Offset = "0xDC4448", VA = "0xDC4448")]
		public TMPro_InstructionOverlay()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class TMP_ExampleScript_01 : MonoBehaviour
	{
		[Token(Token = "0x200005E")]
		public enum objectType
		{
			[Token(Token = "0x40001DB")]
			TextMeshPro,
			[Token(Token = "0x40001DC")]
			TextMeshProUGUI
		}

		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x18")]
		public objectType ObjectType;

		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x1C")]
		public bool isStatic;

		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x20")]
		private TMP_Text m_text;

		[Token(Token = "0x40001D8")]
		private const string k_label = "The count is <#0080ff>{0}</color>";

		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x28")]
		private int count;

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xDC4458", Offset = "0xDC4458", VA = "0xDC4458")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xDC467C", Offset = "0xDC467C", VA = "0xDC467C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xDC4710", Offset = "0xDC4710", VA = "0xDC4710")]
		public TMP_ExampleScript_01()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class TMP_FrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x2000060")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x40001E8")]
			TopLeft,
			[Token(Token = "0x40001E9")]
			BottomLeft,
			[Token(Token = "0x40001EA")]
			TopRight,
			[Token(Token = "0x40001EB")]
			BottomRight
		}

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x40001E2")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x30")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x40")]
		private Camera m_camera;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x48")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xDC4718", Offset = "0xDC4718", VA = "0xDC4718")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xDC4B50", Offset = "0xDC4B50", VA = "0xDC4B50")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xDC4B70", Offset = "0xDC4B70", VA = "0xDC4B70")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xDC4974", Offset = "0xDC4974", VA = "0xDC4974")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xDC4CC4", Offset = "0xDC4CC4", VA = "0xDC4CC4")]
		public TMP_FrameRateCounter()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class TMP_TextEventCheck : MonoBehaviour
	{
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x18")]
		public TMP_TextEventHandler TextEventHandler;

		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x20")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xDC4CDC", Offset = "0xDC4CDC", VA = "0xDC4CDC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xDC4FB0", Offset = "0xDC4FB0", VA = "0xDC4FB0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xDC524C", Offset = "0xDC524C", VA = "0xDC524C")]
		private void OnCharacterSelection(char c, int index)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xDC549C", Offset = "0xDC549C", VA = "0xDC549C")]
		private void OnSpriteSelection(char c, int index)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xDC56EC", Offset = "0xDC56EC", VA = "0xDC56EC")]
		private void OnWordSelection(string word, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xDC59CC", Offset = "0xDC59CC", VA = "0xDC59CC")]
		private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xDC5CAC", Offset = "0xDC5CAC", VA = "0xDC5CAC")]
		private void OnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xDC5FE0", Offset = "0xDC5FE0", VA = "0xDC5FE0")]
		public TMP_TextEventCheck()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class TMP_TextInfoDebugTool : MonoBehaviour
	{
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xDC5FE8", Offset = "0xDC5FE8", VA = "0xDC5FE8")]
		public TMP_TextInfoDebugTool()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x18")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x20")]
		private Camera m_Camera;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isHoveringObject;

		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x2C")]
		private int m_selectedLink;

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x30")]
		private int m_lastCharIndex;

		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x34")]
		private int m_lastWordIndex;

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xDC5FF0", Offset = "0xDC5FF0", VA = "0xDC5FF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xDC6094", Offset = "0xDC6094", VA = "0xDC6094")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xDC6738", Offset = "0xDC6738", VA = "0xDC6738", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xDC67B0", Offset = "0xDC67B0", VA = "0xDC67B0", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xDC6824", Offset = "0xDC6824", VA = "0xDC6824")]
		public TMP_TextSelector_A()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class TMP_TextSelector_B : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler
	{
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x18")]
		public RectTransform TextPopup_Prefab_01;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform m_TextPopup_RectTransform;

		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x28")]
		private TextMeshProUGUI m_TextPopup_TMPComponent;

		[Token(Token = "0x40001F7")]
		private const string k_LinkText = "You have selected link <#ffff00>";

		[Token(Token = "0x40001F8")]
		private const string k_WordText = "Word Index: <#ffff00>";

		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x38")]
		private Canvas m_Canvas;

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x40")]
		private Camera m_Camera;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x48")]
		private bool isHoveringObject;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x4C")]
		private int m_selectedWord;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x50")]
		private int m_selectedLink;

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x54")]
		private int m_lastIndex;

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x58")]
		private Matrix4x4 m_matrix;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x98")]
		private TMP_MeshInfo[] m_cachedMeshInfoVertexData;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xDC683C", Offset = "0xDC683C", VA = "0xDC683C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xDC6A04", Offset = "0xDC6A04", VA = "0xDC6A04")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xDC6AD0", Offset = "0xDC6AD0", VA = "0xDC6AD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xDC6B9C", Offset = "0xDC6B9C", VA = "0xDC6B9C")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xDC6C48", Offset = "0xDC6C48", VA = "0xDC6C48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xDC811C", Offset = "0xDC811C", VA = "0xDC811C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xDC8128", Offset = "0xDC8128", VA = "0xDC8128", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xDC8130", Offset = "0xDC8130", VA = "0xDC8130", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xDC8134", Offset = "0xDC8134", VA = "0xDC8134", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xDC7898", Offset = "0xDC7898", VA = "0xDC7898")]
		private void RestoreCachedVertexAttributes(int index)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xDC8138", Offset = "0xDC8138", VA = "0xDC8138")]
		public TMP_TextSelector_B()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class TMP_UiFrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x2000066")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x400020C")]
			TopLeft,
			[Token(Token = "0x400020D")]
			BottomLeft,
			[Token(Token = "0x400020E")]
			TopRight,
			[Token(Token = "0x400020F")]
			BottomRight
		}

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x4000207")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform m_frameCounter_transform;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x40")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xDC8150", Offset = "0xDC8150", VA = "0xDC8150")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xDC85AC", Offset = "0xDC85AC", VA = "0xDC85AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xDC85CC", Offset = "0xDC85CC", VA = "0xDC85CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xDC8374", Offset = "0xDC8374", VA = "0xDC8374")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xDC8720", Offset = "0xDC8720", VA = "0xDC8720")]
		public TMP_UiFrameRateCounter()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class VertexColorCycler : MonoBehaviour
	{
		[Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class <AnimateVertexColors>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000211")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000212")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000213")]
			[FieldOffset(Offset = "0x20")]
			public VertexColorCycler <>4__this;

			[Token(Token = "0x4000214")]
			[FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000215")]
			[FieldOffset(Offset = "0x30")]
			private int <currentCharacter>5__3;

			[Token(Token = "0x1700002C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0xDC8B9C", Offset = "0xDC8B9C", VA = "0xDC8B9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0xDC8BE4", Offset = "0xDC8BE4", VA = "0xDC8BE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xDC8824", Offset = "0xDC8824", VA = "0xDC8824")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60001CD")]
			[Address(RVA = "0xDC8854", Offset = "0xDC8854", VA = "0xDC8854", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0xDC8858", Offset = "0xDC8858", VA = "0xDC8858", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0xDC8BA4", Offset = "0xDC8BA4", VA = "0xDC8BA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xDC8738", Offset = "0xDC8738", VA = "0xDC8738")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xDC8790", Offset = "0xDC8790", VA = "0xDC8790")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xDC87B0", Offset = "0xDC87B0", VA = "0xDC87B0")]
		[IteratorStateMachine(typeof(<AnimateVertexColors>d__3))]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xDC884C", Offset = "0xDC884C", VA = "0xDC884C")]
		public VertexColorCycler()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class VertexJitter : MonoBehaviour
	{
		[Token(Token = "0x200006A")]
		private struct VertexAnim
		{
			[Token(Token = "0x400021B")]
			[FieldOffset(Offset = "0x0")]
			public float angleRange;

			[Token(Token = "0x400021C")]
			[FieldOffset(Offset = "0x4")]
			public float angle;

			[Token(Token = "0x400021D")]
			[FieldOffset(Offset = "0x8")]
			public float speed;
		}

		[Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400021E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400021F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000220")]
			[FieldOffset(Offset = "0x20")]
			public VertexJitter <>4__this;

			[Token(Token = "0x4000221")]
			[FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000222")]
			[FieldOffset(Offset = "0x30")]
			private int <loopCount>5__3;

			[Token(Token = "0x4000223")]
			[FieldOffset(Offset = "0x38")]
			private VertexAnim[] <vertexAnim>5__4;

			[Token(Token = "0x4000224")]
			[FieldOffset(Offset = "0x40")]
			private TMP_MeshInfo[] <cachedMeshInfo>5__5;

			[Token(Token = "0x1700002E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001DC")]
				[Address(RVA = "0xDC984C", Offset = "0xDC984C", VA = "0xDC984C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0xDC9894", Offset = "0xDC9894", VA = "0xDC9894", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xDC8EEC", Offset = "0xDC8EEC", VA = "0xDC8EEC")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xDC8F2C", Offset = "0xDC8F2C", VA = "0xDC8F2C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xDC8F30", Offset = "0xDC8F30", VA = "0xDC8F30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xDC9854", Offset = "0xDC9854", VA = "0xDC9854", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xDC8BEC", Offset = "0xDC8BEC", VA = "0xDC8BEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xDC8C44", Offset = "0xDC8C44", VA = "0xDC8C44")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xDC8D10", Offset = "0xDC8D10", VA = "0xDC8D10")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xDC8DDC", Offset = "0xDC8DDC", VA = "0xDC8DDC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xDC8E70", Offset = "0xDC8E70", VA = "0xDC8E70")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xDC8DFC", Offset = "0xDC8DFC", VA = "0xDC8DFC")]
		[IteratorStateMachine(typeof(<AnimateVertexColors>d__11))]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xDC8F14", Offset = "0xDC8F14", VA = "0xDC8F14")]
		public VertexJitter()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class VertexShakeA : MonoBehaviour
	{
		[Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400022B")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400022C")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400022D")]
			[FieldOffset(Offset = "0x20")]
			public VertexShakeA <>4__this;

			[Token(Token = "0x400022E")]
			[FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x400022F")]
			[FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x17000030")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0xDCA600", Offset = "0xDCA600", VA = "0xDCA600", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000031")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0xDCA648", Offset = "0xDCA648", VA = "0xDCA648", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xDC9B8C", Offset = "0xDC9B8C", VA = "0xDC9B8C")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xDC9BC4", Offset = "0xDC9BC4", VA = "0xDC9BC4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xDC9BC8", Offset = "0xDC9BC8", VA = "0xDC9BC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xDCA608", Offset = "0xDCA608", VA = "0xDCA608", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x20")]
		public float ScaleMultiplier;

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x24")]
		public float RotationMultiplier;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xDC989C", Offset = "0xDC989C", VA = "0xDC989C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xDC98F4", Offset = "0xDC98F4", VA = "0xDC98F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xDC99C0", Offset = "0xDC99C0", VA = "0xDC99C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xDC9A8C", Offset = "0xDC9A8C", VA = "0xDC9A8C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xDC9B20", Offset = "0xDC9B20", VA = "0xDC9B20")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xDC9AAC", Offset = "0xDC9AAC", VA = "0xDC9AAC")]
		[IteratorStateMachine(typeof(<AnimateVertexColors>d__11))]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xDC9BB4", Offset = "0xDC9BB4", VA = "0xDC9BB4")]
		public VertexShakeA()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class VertexShakeB : MonoBehaviour
	{
		[Token(Token = "0x200006F")]
		[CompilerGenerated]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000235")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000236")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000237")]
			[FieldOffset(Offset = "0x20")]
			public VertexShakeB <>4__this;

			[Token(Token = "0x4000238")]
			[FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000239")]
			[FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x17000032")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001F6")]
				[Address(RVA = "0xDCB8A4", Offset = "0xDCB8A4", VA = "0xDCB8A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000033")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001F8")]
				[Address(RVA = "0xDCB8EC", Offset = "0xDCB8EC", VA = "0xDCB8EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xDCA940", Offset = "0xDCA940", VA = "0xDCA940")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xDCA980", Offset = "0xDCA980", VA = "0xDCA980", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xDCA984", Offset = "0xDCA984", VA = "0xDCA984", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0xDCB8AC", Offset = "0xDCB8AC", VA = "0xDCB8AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xDCA650", Offset = "0xDCA650", VA = "0xDCA650")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xDCA6A8", Offset = "0xDCA6A8", VA = "0xDCA6A8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xDCA774", Offset = "0xDCA774", VA = "0xDCA774")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xDCA840", Offset = "0xDCA840", VA = "0xDCA840")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xDCA8D4", Offset = "0xDCA8D4", VA = "0xDCA8D4")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xDCA860", Offset = "0xDCA860", VA = "0xDCA860")]
		[IteratorStateMachine(typeof(<AnimateVertexColors>d__10))]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xDCA968", Offset = "0xDCA968", VA = "0xDCA968")]
		public VertexShakeB()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class VertexZoom : MonoBehaviour
	{
		[Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x400023F")]
			[FieldOffset(Offset = "0x10")]
			public List<float> modifiedCharScale;

			[Token(Token = "0x4000240")]
			[FieldOffset(Offset = "0x18")]
			public Comparison<int> <>9__0;

			[Token(Token = "0x6000200")]
			[Address(RVA = "0xDCBC34", Offset = "0xDCBC34", VA = "0xDCBC34")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000201")]
			[Address(RVA = "0xDCBC3C", Offset = "0xDCBC3C", VA = "0xDCBC3C")]
			internal int <AnimateVertexColors>b__0(int a, int b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000241")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000242")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000243")]
			[FieldOffset(Offset = "0x20")]
			public VertexZoom <>4__this;

			[Token(Token = "0x4000244")]
			[FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass10_0 <>8__1;

			[Token(Token = "0x4000245")]
			[FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000246")]
			[FieldOffset(Offset = "0x38")]
			private TMP_MeshInfo[] <cachedMeshInfoVertexData>5__3;

			[Token(Token = "0x4000247")]
			[FieldOffset(Offset = "0x40")]
			private List<int> <scaleSortingOrder>5__4;

			[Token(Token = "0x17000034")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000205")]
				[Address(RVA = "0xDCC96C", Offset = "0xDCC96C", VA = "0xDCC96C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000035")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000207")]
				[Address(RVA = "0xDCC9B4", Offset = "0xDCC9B4", VA = "0xDCC9B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000202")]
			[Address(RVA = "0xDCBBF4", Offset = "0xDCBBF4", VA = "0xDCBBF4")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0xDCBCCC", Offset = "0xDCBCCC", VA = "0xDCBCCC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0xDCBCD0", Offset = "0xDCBCD0", VA = "0xDCBCD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0xDCC974", Offset = "0xDCC974", VA = "0xDCC974", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xDCB8F4", Offset = "0xDCB8F4", VA = "0xDCB8F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xDCB94C", Offset = "0xDCB94C", VA = "0xDCB94C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xDCBA18", Offset = "0xDCBA18", VA = "0xDCBA18")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xDCBAE4", Offset = "0xDCBAE4", VA = "0xDCBAE4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xDCBB78", Offset = "0xDCBB78", VA = "0xDCBB78")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xDCBB04", Offset = "0xDCBB04", VA = "0xDCBB04")]
		[IteratorStateMachine(typeof(<AnimateVertexColors>d__10))]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xDCBC1C", Offset = "0xDCBC1C", VA = "0xDCBC1C")]
		public VertexZoom()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class WarpTextExample : MonoBehaviour
	{
		[Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class <WarpText>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400024D")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400024E")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400024F")]
			[FieldOffset(Offset = "0x20")]
			public WarpTextExample <>4__this;

			[Token(Token = "0x4000250")]
			[FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x4000251")]
			[FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__3;

			[Token(Token = "0x17000036")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000210")]
				[Address(RVA = "0xDCD614", Offset = "0xDCD614", VA = "0xDCD614", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000037")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000212")]
				[Address(RVA = "0xDCD65C", Offset = "0xDCD65C", VA = "0xDCD65C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600020D")]
			[Address(RVA = "0xDCCB38", Offset = "0xDCCB38", VA = "0xDCCB38")]
			[DebuggerHidden]
			public <WarpText>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600020E")]
			[Address(RVA = "0xDCCDA4", Offset = "0xDCCDA4", VA = "0xDCCDA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600020F")]
			[Address(RVA = "0xDCCDA8", Offset = "0xDCCDA8", VA = "0xDCCDA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000211")]
			[Address(RVA = "0xDCD61C", Offset = "0xDCD61C", VA = "0xDCD61C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x28")]
		public float AngleMultiplier;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x2C")]
		public float SpeedMultiplier;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x30")]
		public float CurveScale;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xDCC9BC", Offset = "0xDCC9BC", VA = "0xDCC9BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xDCCA24", Offset = "0xDCCA24", VA = "0xDCCA24")]
		private void Start()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xDCCAB8", Offset = "0xDCCAB8", VA = "0xDCCAB8")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xDCCA44", Offset = "0xDCCA44", VA = "0xDCCA44")]
		[IteratorStateMachine(typeof(<WarpText>d__8))]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xDCCB60", Offset = "0xDCCB60", VA = "0xDCCB60")]
		public WarpTextExample()
		{
		}
	}
}
namespace Global
{
	[Token(Token = "0x2000075")]
	public class GlobalDataManager
	{
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x0")]
		private static GlobalDataManager sharedInstance;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object sLock;

		[Token(Token = "0x17000038")]
		public string userDisplayName
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0xDCD7E8", Offset = "0xDCD7E8", VA = "0xDCD7E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000216")]
			[Address(RVA = "0xDCD7F0", Offset = "0xDCD7F0", VA = "0xDCD7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public string userID
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0xDCD7F8", Offset = "0xDCD7F8", VA = "0xDCD7F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000218")]
			[Address(RVA = "0xDCD800", Offset = "0xDCD800", VA = "0xDCD800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public string userImageUrl
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0xDCD808", Offset = "0xDCD808", VA = "0xDCD808")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600021A")]
			[Address(RVA = "0xDCD810", Offset = "0xDCD810", VA = "0xDCD810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public string userGender
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0xDCD818", Offset = "0xDCD818", VA = "0xDCD818")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600021C")]
			[Address(RVA = "0xDCD820", Offset = "0xDCD820", VA = "0xDCD820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public string accessToken
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0xDCD828", Offset = "0xDCD828", VA = "0xDCD828")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600021E")]
			[Address(RVA = "0xDCD830", Offset = "0xDCD830", VA = "0xDCD830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public string deviceSN
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0xDCD838", Offset = "0xDCD838", VA = "0xDCD838")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000220")]
			[Address(RVA = "0xDCD840", Offset = "0xDCD840", VA = "0xDCD840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xDCD664", Offset = "0xDCD664", VA = "0xDCD664")]
		private GlobalDataManager()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xDCD66C", Offset = "0xDCD66C", VA = "0xDCD66C")]
		public static GlobalDataManager GetInstance()
		{
			return null;
		}
	}
}
namespace Andtech.StarPack
{
	[Token(Token = "0x2000076")]
	public class ActivateDepthRendering : MonoBehaviour
	{
		[Token(Token = "0x6000222")]
		[Address(RVA = "0xDCD8C4", Offset = "0xDCD8C4", VA = "0xDCD8C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xDCD8E8", Offset = "0xDCD8E8", VA = "0xDCD8E8")]
		public ActivateDepthRendering()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class Spin : MonoBehaviour
	{
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float speed;

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xDCD8F0", Offset = "0xDCD8F0", VA = "0xDCD8F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xDCD970", Offset = "0xDCD970", VA = "0xDCD970")]
		public Spin()
		{
		}
	}
}
namespace PrickBalloon
{
	[Token(Token = "0x2000078")]
	public class DataManager
	{
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x0")]
		private static DataManager sharedInstance;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object sLock;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x18")]
		public List<GameObject> goaledBalloons;

		[Token(Token = "0x1700003E")]
		public int scoreNum
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0xDCDB80", Offset = "0xDCDB80", VA = "0xDCDB80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0xDCDB88", Offset = "0xDCDB88", VA = "0xDCDB88")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xDCD980", Offset = "0xDCD980", VA = "0xDCD980")]
		private DataManager()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xDCDA08", Offset = "0xDCDA08", VA = "0xDCDA08")]
		public static DataManager GetInstance()
		{
			return null;
		}
	}
	[Token(Token = "0x2000079")]
	public class PlayScript : MonoBehaviour
	{
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x18")]
		public GameObject arrowPrefab;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x20")]
		private bool rTriggerBtnState;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x21")]
		private bool hasArrowNeedToThrow;

		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x28")]
		private List<GameObject> newArrows;

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x30")]
		private GameObject currentArrow;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x38")]
		private GameObject fixedArrow;

		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x40")]
		private InputDevice rightHandDevice;

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x50")]
		private InputDevice leftHandDevice;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x60")]
		private bool isStartRecongnize;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x68")]
		private DateTime startTime;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x70")]
		private DateTime endTime;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x78")]
		private float RecongnizeMinStepDistance;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x7C")]
		private float addListMinStepDist;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x80")]
		private int linkListMaxLength;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x88")]
		private List<Vector3> recordPosList;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x90")]
		private Vector3[] SamplePos;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x98")]
		private bool isPause;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0xA0")]
		private GameObject pauseWin;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0xA8")]
		private int scoreNum;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0xB0")]
		private TMP_Text scoreNumText;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0xB8")]
		private int arrowCount;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0xC0")]
		private TMP_Text arrowCountText;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0xC8")]
		private int timerNum;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0xD0")]
		private TMP_Text timerNumText;

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0xD8")]
		private DateTime lastPressTime;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0xE0")]
		private GameObject handTips;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0xE8")]
		private bool isGameStart;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xDCDC0C", Offset = "0xDCDC0C", VA = "0xDCDC0C")]
		private void Start()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xDCE194", Offset = "0xDCE194", VA = "0xDCE194")]
		private void Update()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xDCE198", Offset = "0xDCE198", VA = "0xDCE198")]
		public void ContinueBtnClick()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xDCE2B0", Offset = "0xDCE2B0", VA = "0xDCE2B0")]
		public void RetryBtnClick()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xDCE544", Offset = "0xDCE544", VA = "0xDCE544")]
		public void QuitBtnClick()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xDCE65C", Offset = "0xDCE65C", VA = "0xDCE65C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xDCDF6C", Offset = "0xDCDF6C", VA = "0xDCDF6C")]
		private void InitParams()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xDCF010", Offset = "0xDCF010", VA = "0xDCF010")]
		private void CountDownFun()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xDCE1A0", Offset = "0xDCE1A0", VA = "0xDCE1A0")]
		private void ShowPauseWin(bool isShow)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xDCED6C", Offset = "0xDCED6C", VA = "0xDCED6C")]
		private void ThrowArrow()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xDCF0E0", Offset = "0xDCF0E0", VA = "0xDCF0E0")]
		private Vector3 CalcuolateDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xDCEC74", Offset = "0xDCEC74", VA = "0xDCEC74")]
		private void UpLoadLeaderboardData()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xDCE024", Offset = "0xDCE024", VA = "0xDCE024")]
		private void InitPicoService()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xDCF2BC", Offset = "0xDCF2BC", VA = "0xDCF2BC")]
		private void GetPrickBalloonLeaderboardEntryListData()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xDCF38C", Offset = "0xDCF38C", VA = "0xDCF38C")]
		public PlayScript()
		{
		}
	}
}
namespace Lasso
{
	[Token(Token = "0x200007A")]
	public class DataManager
	{
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x0")]
		private static DataManager sharedInstance;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object sLock;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x18")]
		public List<GameObject> goaledPrizes;

		[Token(Token = "0x1700003F")]
		public int scoreNum
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0xDCF968", Offset = "0xDCF968", VA = "0xDCF968")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000240")]
			[Address(RVA = "0xDCF970", Offset = "0xDCF970", VA = "0xDCF970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xDCF768", Offset = "0xDCF768", VA = "0xDCF768")]
		private DataManager()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xDCF7F0", Offset = "0xDCF7F0", VA = "0xDCF7F0")]
		public static DataManager GetInstance()
		{
			return null;
		}
	}
	[Token(Token = "0x200007B")]
	public class PlayScript : MonoBehaviour
	{
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x18")]
		public GameObject ringPrefab;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x20")]
		private bool rTriggerBtnState;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x21")]
		private bool hasRingNeedToThrow;

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x28")]
		private List<GameObject> newRings;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x30")]
		private GameObject currentRing;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x38")]
		private GameObject fixedRing;

		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x40")]
		private InputDevice rightHandDevice;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x50")]
		private InputDevice leftHandDevice;

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x60")]
		private bool isStartRecongnize;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x68")]
		private DateTime startTime;

		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x70")]
		private DateTime endTime;

		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x78")]
		private float RecongnizeMinStepDistance;

		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x7C")]
		private float addListMinStepDist;

		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x80")]
		private float stepTime;

		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x84")]
		private float MaxAnlgeToConfirm;

		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x88")]
		private int linkListMaxLength;

		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x90")]
		private List<Vector3> recordPosList;

		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x98")]
		private Vector3[] SamplePos;

		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0xA0")]
		private bool isPause;

		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0xA8")]
		private GameObject pauseWin;

		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0xB0")]
		private int scoreNum;

		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0xB8")]
		private TMP_Text scoreNumText;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0xC0")]
		private int ringCount;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0xC8")]
		private TMP_Text ringCountText;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0xD0")]
		private int timerNum;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0xD8")]
		private TMP_Text timerNumText;

		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0xE0")]
		private DateTime lastPressTime;

		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0xE8")]
		private GameObject handTips;

		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0xF0")]
		private bool isGameStart;

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xDCF9F4", Offset = "0xDCF9F4", VA = "0xDCF9F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xDCFFAC", Offset = "0xDCFFAC", VA = "0xDCFFAC")]
		public void ContinueBtnClick()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xDD00C4", Offset = "0xDD00C4", VA = "0xDD00C4")]
		public void RetryBtnClick()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xDD0358", Offset = "0xDD0358", VA = "0xDD0358")]
		public void QuitBtnClick()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xDD0470", Offset = "0xDD0470", VA = "0xDD0470")]
		private void Update()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xDD0474", Offset = "0xDD0474", VA = "0xDD0474")]
		private void CountDownFun()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xDD063C", Offset = "0xDD063C", VA = "0xDD063C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xDD0C54", Offset = "0xDD0C54", VA = "0xDD0C54")]
		private void ThrowRing()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xDCFD84", Offset = "0xDCFD84", VA = "0xDCFD84")]
		private void InitParams()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xDCFFB4", Offset = "0xDCFFB4", VA = "0xDCFFB4")]
		private void ShowPauseWin(bool isShow)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xDD0EB4", Offset = "0xDD0EB4", VA = "0xDD0EB4")]
		private Vector3 CalcuolateDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xDD1090", Offset = "0xDD1090", VA = "0xDD1090")]
		private float GetAngleWithX(Vector3 pos3D)
		{
			return default(float);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xDD0544", Offset = "0xDD0544", VA = "0xDD0544")]
		private void UpLoadLeaderboardData()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xDCFE3C", Offset = "0xDCFE3C", VA = "0xDCFE3C")]
		private void InitPicoService()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xDD11C8", Offset = "0xDD11C8", VA = "0xDD11C8")]
		private void GetLassoLeaderboardEntryListData()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xDD1298", Offset = "0xDD1298", VA = "0xDD1298")]
		public PlayScript()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x200007C")]
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		[Token(Token = "0x200007D")]
		public enum UpdateType
		{
			[Token(Token = "0x40002A0")]
			FixedUpdate,
			[Token(Token = "0x40002A1")]
			LateUpdate,
			[Token(Token = "0x40002A2")]
			ManualUpdate
		}

		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform m_Target;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoTargetPlayer;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UpdateType m_UpdateType;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x28")]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x17000040")]
		public Transform Target
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0xDD1A4C", Offset = "0xDD1A4C", VA = "0xDD1A4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xDD1674", Offset = "0xDD1674", VA = "0xDD1674", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xDD17F0", Offset = "0xDD17F0", VA = "0xDD17F0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xDD18B4", Offset = "0xDD18B4", VA = "0xDD18B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xDD197C", Offset = "0xDD197C", VA = "0xDD197C")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x6000259")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xDD172C", Offset = "0xDD172C", VA = "0xDD172C")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xDD1A44", Offset = "0xDD1A44", VA = "0xDD1A44", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xDD1A54", Offset = "0xDD1A54", VA = "0xDD1A54")]
		protected AbstractTargetFollower()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class FreeLookCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Range(0f, 10f)]
		private float m_TurnSpeed;

		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_TurnSmoothing;

		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_TiltMax;

		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_TiltMin;

		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_LockCursor;

		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_VerticalAutoReturn;

		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x64")]
		private float m_LookAngle;

		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x68")]
		private float m_TiltAngle;

		[Token(Token = "0x40002AC")]
		private const float k_LookDistance = 100f;

		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 m_PivotEulers;

		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x78")]
		private Quaternion m_PivotTargetRot;

		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x88")]
		private Quaternion m_TransformTargetRot;

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xDD1A64", Offset = "0xDD1A64", VA = "0xDD1A64", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xDD1BA8", Offset = "0xDD1BA8", VA = "0xDD1BA8")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xDD1EDC", Offset = "0xDD1EDC", VA = "0xDD1EDC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xDD1EFC", Offset = "0xDD1EFC", VA = "0xDD1EFC", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xDD1BF8", Offset = "0xDD1BF8", VA = "0xDD1BF8")]
		private void HandleRotationMovement()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xDD2020", Offset = "0xDD2020", VA = "0xDD2020")]
		public FreeLookCam()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x30")]
		protected Transform m_Cam;

		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x38")]
		protected Transform m_Pivot;

		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x40")]
		protected Vector3 m_LastTargetPosition;

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xDD1B1C", Offset = "0xDD1B1C", VA = "0xDD1B1C", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xDD2048", Offset = "0xDD2048", VA = "0xDD2048")]
		protected PivotBasedCameraRig()
		{
		}
	}
}
