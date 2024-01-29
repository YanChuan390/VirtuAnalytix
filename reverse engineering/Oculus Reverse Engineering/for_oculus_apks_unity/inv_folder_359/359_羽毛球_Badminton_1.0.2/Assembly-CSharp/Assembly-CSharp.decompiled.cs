using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Oculus.Platform;
using Oculus.Platform.Models;
using Oculus.Spatializer.Propagation;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class AddHapticsUI : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B33C", Offset = "0x52B33C")]
	private sealed class <>c
	{
		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Button, GameObject> <>9__4_0;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<Slider, GameObject> <>9__4_1;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<Dropdown, GameObject> <>9__4_2;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<Toggle, GameObject> <>9__4_3;

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x85D610", Offset = "0x85D610", VA = "0x85D610")]
		public <>c()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x85D618", Offset = "0x85D618", VA = "0x85D618")]
		internal GameObject <Awake>b__4_0(Button x)
		{
			return null;
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x85D634", Offset = "0x85D634", VA = "0x85D634")]
		internal GameObject <Awake>b__4_1(Slider x)
		{
			return null;
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x85D650", Offset = "0x85D650", VA = "0x85D650")]
		internal GameObject <Awake>b__4_2(Dropdown x)
		{
			return null;
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x85D66C", Offset = "0x85D66C", VA = "0x85D66C")]
		internal GameObject <Awake>b__4_3(Toggle x)
		{
			return null;
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ActionBasedController controller1;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ActionBasedController controller2;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private XRRayInteractor interactor1;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private XRRayInteractor interactor2;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x9B3BD0", Offset = "0x9B3BD0", VA = "0x9B3BD0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x9B4324", Offset = "0x9B4324", VA = "0x9B4324")]
	private void GetControllers()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x9B4490", Offset = "0x9B4490", VA = "0x9B4490")]
	private void Hover(BaseEventData arg0)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x9B4568", Offset = "0x9B4568", VA = "0x9B4568")]
	public AddHapticsUI()
	{
	}
}
[Token(Token = "0x2000003")]
public class AINoticeBall : MonoBehaviour
{
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x9B3AA8", Offset = "0x9B3AA8", VA = "0x9B3AA8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x9B3AAC", Offset = "0x9B3AAC", VA = "0x9B3AAC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x9B3AB0", Offset = "0x9B3AB0", VA = "0x9B3AB0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x9B3B3C", Offset = "0x9B3B3C", VA = "0x9B3B3C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x9B3BC8", Offset = "0x9B3BC8", VA = "0x9B3BC8")]
	public AINoticeBall()
	{
	}
}
[Token(Token = "0x2000004")]
public class BallRealism : MonoBehaviour
{
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x9BC0B8", Offset = "0x9BC0B8", VA = "0x9BC0B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x9BC0BC", Offset = "0x9BC0BC", VA = "0x9BC0BC")]
	private void Update()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x9BC0C0", Offset = "0x9BC0C0", VA = "0x9BC0C0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x9BC19C", Offset = "0x9BC19C", VA = "0x9BC19C")]
	public BallRealism()
	{
	}
}
[Token(Token = "0x2000005")]
public class BodyFollowAI : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform BodyLeader;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 targetPosition;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float speed;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x9BDCB4", Offset = "0x9BDCB4", VA = "0x9BDCB4")]
	private void Start()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x9BDCF0", Offset = "0x9BDCF0", VA = "0x9BDCF0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x9BDCF4", Offset = "0x9BDCF4", VA = "0x9BDCF4")]
	public void FollowLeader()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x9BDDC0", Offset = "0x9BDDC0", VA = "0x9BDDC0")]
	public BodyFollowAI()
	{
	}
}
[Token(Token = "0x2000006")]
public class BucketPongManager : MonoBehaviour
{
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] Buckets;

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x9BE450", Offset = "0x9BE450", VA = "0x9BE450")]
	private void Start()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x9BE454", Offset = "0x9BE454", VA = "0x9BE454")]
	private void Update()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x9BE6F0", Offset = "0x9BE6F0", VA = "0x9BE6F0")]
	public BucketPongManager()
	{
	}
}
[Token(Token = "0x2000007")]
public class BucketPongScore : MonoBehaviour
{
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMesh ScoreText;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh HighScoreText;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x9BE6F8", Offset = "0x9BE6F8", VA = "0x9BE6F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x9BE744", Offset = "0x9BE744", VA = "0x9BE744")]
	private void Update()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x9BE83C", Offset = "0x9BE83C", VA = "0x9BE83C")]
	public BucketPongScore()
	{
	}
}
[Token(Token = "0x2000008")]
public class BucketPongTarget : MonoBehaviour
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource enterSound;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Bucket;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject DestroyBall;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ClickSoundControl clickSoundControl;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x9BE844", Offset = "0x9BE844", VA = "0x9BE844")]
	private void Start()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x9BE8F4", Offset = "0x9BE8F4", VA = "0x9BE8F4")]
	private void Update()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x9BE8F8", Offset = "0x9BE8F8", VA = "0x9BE8F8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x9BEB44", Offset = "0x9BEB44", VA = "0x9BEB44")]
	public BucketPongTarget()
	{
	}
}
[Token(Token = "0x2000009")]
public class CharacterSelect : MonoBehaviour
{
	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject MarvinP;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject ClankP;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject AwesomeoP;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject TinTinP;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject MegaManP;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject BishopP;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x9C9960", Offset = "0x9C9960", VA = "0x9C9960")]
	private void Start()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x9C9D04", Offset = "0x9C9D04", VA = "0x9C9D04")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x9C9D08", Offset = "0x9C9D08", VA = "0x9C9D08")]
	public CharacterSelect()
	{
	}
}
[Token(Token = "0x200000A")]
public class CharacterSelectController : MonoBehaviour
{
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button MarvinBTN;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Button ClankBTN;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Button AwesomeoBTN;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Button TinTinBTN;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Button MegaManBTN;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Button BishopBTN;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text CharacterName;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject Marvin;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject Clank;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject Awesomeo;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject TinTin;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject MegaMan;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject Bishop;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject MarvinP;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject ClankP;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject AwesomeoP;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject TinTinP;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject MegaManP;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject BishopP;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x9C9D10", Offset = "0x9C9D10", VA = "0x9C9D10")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x9CA774", Offset = "0x9CA774", VA = "0x9CA774")]
	private void Update()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x9CA778", Offset = "0x9CA778", VA = "0x9CA778")]
	public void MarvinSelect()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x9CA964", Offset = "0x9CA964", VA = "0x9CA964")]
	public void ClankSelect()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x9CAB50", Offset = "0x9CAB50", VA = "0x9CAB50")]
	public void AwesomoSelect()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x9CAD3C", Offset = "0x9CAD3C", VA = "0x9CAD3C")]
	public void TinTinSelect()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x9CAF28", Offset = "0x9CAF28", VA = "0x9CAF28")]
	public void MegaManSelect()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x9CB114", Offset = "0x9CB114", VA = "0x9CB114")]
	public void BishopSelect()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x9CB300", Offset = "0x9CB300", VA = "0x9CB300")]
	public CharacterSelectController()
	{
	}
}
[Token(Token = "0x200000B")]
public class CharacterUnlockedPopUp : MonoBehaviour
{
	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ClankPanel;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject AOPanel;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject TinTinPanel;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject MegaManPanel;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject BishopPanel;

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x9CB308", Offset = "0x9CB308", VA = "0x9CB308")]
	private void Start()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x9CB544", Offset = "0x9CB544", VA = "0x9CB544")]
	private void Update()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x9CB548", Offset = "0x9CB548", VA = "0x9CB548")]
	public void ClankUnlocked()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x9CB5B0", Offset = "0x9CB5B0", VA = "0x9CB5B0")]
	public void AOUnlocked()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x9CB618", Offset = "0x9CB618", VA = "0x9CB618")]
	public void TinTinUnlocked()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x9CB680", Offset = "0x9CB680", VA = "0x9CB680")]
	public void MegaManUnlocked()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x9CB6E8", Offset = "0x9CB6E8", VA = "0x9CB6E8")]
	public void BishopUnlocked()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x9CB750", Offset = "0x9CB750", VA = "0x9CB750")]
	public CharacterUnlockedPopUp()
	{
	}
}
[Token(Token = "0x200000C")]
public class DontGoThroughThings : MonoBehaviour
{
	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool sendTriggerMessage;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public LayerMask layerMask;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float skinWidth;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float minimumExtent;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float partialExtent;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float sqrMinimumExtent;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 previousPosition;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Rigidbody myRigidbody;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Collider myCollider;

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x958874", Offset = "0x958874", VA = "0x958874")]
	private void Start()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x9589FC", Offset = "0x9589FC", VA = "0x9589FC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x958C24", Offset = "0x958C24", VA = "0x958C24")]
	public DontGoThroughThings()
	{
	}
}
[Token(Token = "0x200000D")]
public class Exit : MonoBehaviour
{
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ExitPanel;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x958E70", Offset = "0x958E70", VA = "0x958E70")]
	private void Start()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x958E7C", Offset = "0x958E7C", VA = "0x958E7C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x958E80", Offset = "0x958E80", VA = "0x958E80")]
	public void ShowPanel()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x958EA4", Offset = "0x958EA4", VA = "0x958EA4")]
	public void ClosePanel()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x958EC8", Offset = "0x958EC8", VA = "0x958EC8")]
	public void ExitGame()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x958ED0", Offset = "0x958ED0", VA = "0x958ED0")]
	public Exit()
	{
	}
}
[Token(Token = "0x200000E")]
public class FirstUIController : MonoBehaviour
{
	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject PRTitle;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject PPTitle;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject PRScroll;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject PPScroll;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Button PPBTN;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Button ContinueBTN;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Button BackBTN;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject ProgressBar;

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x95AE34", Offset = "0x95AE34", VA = "0x95AE34")]
	private void Start()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x95AE38", Offset = "0x95AE38", VA = "0x95AE38")]
	private void Update()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x95AE3C", Offset = "0x95AE3C", VA = "0x95AE3C")]
	public void Continue()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x95AEE8", Offset = "0x95AEE8", VA = "0x95AEE8")]
	public void PP()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x95AFB4", Offset = "0x95AFB4", VA = "0x95AFB4")]
	public void Back()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x95B080", Offset = "0x95B080", VA = "0x95B080")]
	public FirstUIController()
	{
	}
}
[Token(Token = "0x200000F")]
public class GetUserNameOculus : MonoBehaviour
{
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Text Username;

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x95C704", Offset = "0x95C704", VA = "0x95C704")]
	private void Start()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x95C708", Offset = "0x95C708", VA = "0x95C708")]
	private void Update()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x95C70C", Offset = "0x95C70C", VA = "0x95C70C")]
	public GetUserNameOculus()
	{
	}
}
[Token(Token = "0x2000010")]
public class HandControl : MonoBehaviour
{
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Toggle HandsSwitch;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource ClickSound;

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x95D740", Offset = "0x95D740", VA = "0x95D740")]
	private void Start()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x95D854", Offset = "0x95D854", VA = "0x95D854")]
	private void Update()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x95D858", Offset = "0x95D858", VA = "0x95D858")]
	public void HandsBool(bool hb)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x95D930", Offset = "0x95D930", VA = "0x95D930")]
	public HandControl()
	{
	}
}
[Token(Token = "0x2000011")]
public class HandControlScript : MonoBehaviour
{
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject RightHand;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject LeftHand;

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x95D938", Offset = "0x95D938", VA = "0x95D938")]
	private void Start()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x95D93C", Offset = "0x95D93C", VA = "0x95D93C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x95DA10", Offset = "0x95DA10", VA = "0x95DA10")]
	public HandControlScript()
	{
	}
}
[Token(Token = "0x2000012")]
public class HapticsControl : MonoBehaviour
{
	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Toggle HapticsSwitch;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource ClickSound;

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x95EE44", Offset = "0x95EE44", VA = "0x95EE44")]
	private void Start()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x95EF58", Offset = "0x95EF58", VA = "0x95EF58")]
	private void Update()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x95EF5C", Offset = "0x95EF5C", VA = "0x95EF5C")]
	public void HapticsBool(bool hb)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x95F034", Offset = "0x95F034", VA = "0x95F034")]
	public HapticsControl()
	{
	}
}
[Token(Token = "0x2000013")]
public class InGameControllerAO : MonoBehaviour
{
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int PlayerScore;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int BotScore;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int PlayerGamesWon;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int BotGamesWon;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject PlayerWonPanel;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject PlayerLosePanel;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject MainRacketL;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject MainRacketR;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject DisplayRacketL;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject DisplayRacketR;

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x95F8A0", Offset = "0x95F8A0", VA = "0x95F8A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x95F8F8", Offset = "0x95F8F8", VA = "0x95F8F8")]
	private void Start()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x95F9F8", Offset = "0x95F9F8", VA = "0x95F9F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x95FA1C", Offset = "0x95FA1C", VA = "0x95FA1C")]
	private void CheckScore()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x95FC88", Offset = "0x95FC88", VA = "0x95FC88")]
	private void GameController()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x95FAEC", Offset = "0x95FAEC", VA = "0x95FAEC")]
	private void CheckWinner()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x95FE88", Offset = "0x95FE88", VA = "0x95FE88")]
	public void Replay()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x95FEFC", Offset = "0x95FEFC", VA = "0x95FEFC")]
	public void MainMenu()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x95FF70", Offset = "0x95FF70", VA = "0x95FF70")]
	public InGameControllerAO()
	{
	}
}
[Token(Token = "0x2000014")]
public class InGameControllerBishop : MonoBehaviour
{
	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int PlayerScore;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int BotScore;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int PlayerGamesWon;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int BotGamesWon;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject PlayerWonPanel;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject PlayerLosePanel;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject MainRacketL;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject MainRacketR;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject DisplayRacketL;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject DisplayRacketR;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x95FF78", Offset = "0x95FF78", VA = "0x95FF78")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x95FFD0", Offset = "0x95FFD0", VA = "0x95FFD0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x9600D0", Offset = "0x9600D0", VA = "0x9600D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x9600F4", Offset = "0x9600F4", VA = "0x9600F4")]
	private void CheckScore()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x960360", Offset = "0x960360", VA = "0x960360")]
	private void GameController()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x9601C4", Offset = "0x9601C4", VA = "0x9601C4")]
	private void CheckWinner()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x960560", Offset = "0x960560", VA = "0x960560")]
	public void Replay()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x9605D4", Offset = "0x9605D4", VA = "0x9605D4")]
	public void MainMenu()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x960648", Offset = "0x960648", VA = "0x960648")]
	public InGameControllerBishop()
	{
	}
}
[Token(Token = "0x2000015")]
public class InGameControllerClank : MonoBehaviour
{
	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int PlayerScore;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int BotScore;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int PlayerGamesWon;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int BotGamesWon;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject PlayerWonPanel;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject PlayerLosePanel;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject MainRacketL;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject MainRacketR;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject DisplayRacketL;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject DisplayRacketR;

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x960650", Offset = "0x960650", VA = "0x960650")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x9606A8", Offset = "0x9606A8", VA = "0x9606A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x9607A8", Offset = "0x9607A8", VA = "0x9607A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x9607CC", Offset = "0x9607CC", VA = "0x9607CC")]
	private void CheckScore()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x960A38", Offset = "0x960A38", VA = "0x960A38")]
	private void GameController()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x96089C", Offset = "0x96089C", VA = "0x96089C")]
	private void CheckWinner()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x960C38", Offset = "0x960C38", VA = "0x960C38")]
	public void Replay()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x960CAC", Offset = "0x960CAC", VA = "0x960CAC")]
	public void MainMenu()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x960D20", Offset = "0x960D20", VA = "0x960D20")]
	public InGameControllerClank()
	{
	}
}
[Token(Token = "0x2000016")]
public class InGameControllerMegaMan : MonoBehaviour
{
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int PlayerScore;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int BotScore;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int PlayerGamesWon;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int BotGamesWon;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject PlayerWonPanel;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject PlayerLosePanel;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject MainRacketL;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject MainRacketR;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject DisplayRacketL;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject DisplayRacketR;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x960D28", Offset = "0x960D28", VA = "0x960D28")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x960D80", Offset = "0x960D80", VA = "0x960D80")]
	private void Start()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x960E80", Offset = "0x960E80", VA = "0x960E80")]
	private void Update()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x960EA4", Offset = "0x960EA4", VA = "0x960EA4")]
	private void CheckScore()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x961110", Offset = "0x961110", VA = "0x961110")]
	private void GameController()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x960F74", Offset = "0x960F74", VA = "0x960F74")]
	private void CheckWinner()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x961310", Offset = "0x961310", VA = "0x961310")]
	public void Replay()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x961384", Offset = "0x961384", VA = "0x961384")]
	public void MainMenu()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x9613F8", Offset = "0x9613F8", VA = "0x9613F8")]
	public InGameControllerMegaMan()
	{
	}
}
[Token(Token = "0x2000017")]
public class InGameControllerTinTin : MonoBehaviour
{
	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int PlayerScore;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int BotScore;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int PlayerGamesWon;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int BotGamesWon;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject PlayerWonPanel;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject PlayerLosePanel;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject MainRacketL;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject MainRacketR;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject DisplayRacketL;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject DisplayRacketR;

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x961400", Offset = "0x961400", VA = "0x961400")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x961458", Offset = "0x961458", VA = "0x961458")]
	private void Start()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x961558", Offset = "0x961558", VA = "0x961558")]
	private void Update()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x96157C", Offset = "0x96157C", VA = "0x96157C")]
	private void CheckScore()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x9617E8", Offset = "0x9617E8", VA = "0x9617E8")]
	private void GameController()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x96164C", Offset = "0x96164C", VA = "0x96164C")]
	private void CheckWinner()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x9619E8", Offset = "0x9619E8", VA = "0x9619E8")]
	public void Replay()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x961A5C", Offset = "0x961A5C", VA = "0x961A5C")]
	public void MainMenu()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x961AD0", Offset = "0x961AD0", VA = "0x961AD0")]
	public InGameControllerTinTin()
	{
	}
}
[Token(Token = "0x2000018")]
public class LangController : MonoBehaviour
{
	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text Menu;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text Restart;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text Continue;

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xC07534", Offset = "0xC07534", VA = "0xC07534")]
	private void Start()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xC07538", Offset = "0xC07538", VA = "0xC07538")]
	private void Update()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xC0753C", Offset = "0xC0753C", VA = "0xC0753C")]
	public void ControllerLanguage()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xC07A00", Offset = "0xC07A00", VA = "0xC07A00")]
	public LangController()
	{
	}
}
[Token(Token = "0x2000019")]
public class LanguageControl : MonoBehaviour
{
	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button EnglishBTN;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Button SpanishBTN;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Button FrenchBTN;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Button PortugueseBTN;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Button RussianBTN;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Button JapaneseBTN;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Button ChineseBTN;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text LangText;

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xC07A08", Offset = "0xC07A08", VA = "0xC07A08")]
	private void Start()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xC08014", Offset = "0xC08014", VA = "0xC08014")]
	private void Update()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xC08018", Offset = "0xC08018", VA = "0xC08018")]
	public void EnglishLang()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xC08128", Offset = "0xC08128", VA = "0xC08128")]
	public void SpanishLang()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xC08238", Offset = "0xC08238", VA = "0xC08238")]
	public void FrenchLang()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xC08348", Offset = "0xC08348", VA = "0xC08348")]
	public void PortugueseLang()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xC08458", Offset = "0xC08458", VA = "0xC08458")]
	public void RussianLang()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xC08568", Offset = "0xC08568", VA = "0xC08568")]
	public void JapaneseLang()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xC08678", Offset = "0xC08678", VA = "0xC08678")]
	public void ChineseLang()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xC08788", Offset = "0xC08788", VA = "0xC08788")]
	public LanguageControl()
	{
	}
}
[Token(Token = "0x200001A")]
public class LockedOpponenets : MonoBehaviour
{
	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject LockedPanel;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Lock2;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Lock3;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject Lock4;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject Lock5;

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xC0912C", Offset = "0xC0912C", VA = "0xC0912C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xC09264", Offset = "0xC09264", VA = "0xC09264")]
	private void Update()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xC09268", Offset = "0xC09268", VA = "0xC09268")]
	public void Clank()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xC092DC", Offset = "0xC092DC", VA = "0xC092DC")]
	public void AO()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xC093A8", Offset = "0xC093A8", VA = "0xC093A8")]
	public void TinTin()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xC09474", Offset = "0xC09474", VA = "0xC09474")]
	public void MegaMan()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xC09540", Offset = "0xC09540", VA = "0xC09540")]
	public void Bishop()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xC0960C", Offset = "0xC0960C", VA = "0xC0960C")]
	public void CloseLockedPanel()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xC09630", Offset = "0xC09630", VA = "0xC09630")]
	public LockedOpponenets()
	{
	}
}
[Token(Token = "0x200001B")]
public class LookAtBall : MonoBehaviour
{
	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject Ball;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float damping;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Player;

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xC0BD30", Offset = "0xC0BD30", VA = "0xC0BD30")]
	private void Start()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xC0BD90", Offset = "0xC0BD90", VA = "0xC0BD90")]
	private void Update()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xC0BFEC", Offset = "0xC0BFEC", VA = "0xC0BFEC")]
	public void FindBall()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xC0C118", Offset = "0xC0C118", VA = "0xC0C118")]
	public void FindBallToFollow()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xC0C174", Offset = "0xC0C174", VA = "0xC0C174")]
	public LookAtBall()
	{
	}
}
[Token(Token = "0x200001C")]
public class MenuLangController : MonoBehaviour
{
	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text Welcome;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text Campaign;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text Training;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text Training2;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text MultiplayerLounge;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text OtherModes;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text ComingSoon;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text TargetPractice;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Text BucketPong;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text FreeHit;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Text Opponents;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Text Chapter1;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Text CampaignNotice;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Text HelpNotice;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Text ItemShopNotice;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Text Settings;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Text Music;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Text Language;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Text Language2;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Text RightHand;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Text Problem;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Text Help;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Text Difficulty;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Text StartGame;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Text ItemShop;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Text QuitGame;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Text QuitNotice;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Text Quit;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Text No;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Text Back;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Text Back2;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Text Customize;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Text Character;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Text CharacterUnlocked;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Text CharacterUnlocked2;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Text CharacterUnlocked3;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public Text CharacterUnlocked4;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Text CharacterUnlocked5;

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xC0D6B8", Offset = "0xC0D6B8", VA = "0xC0D6B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xC0D6BC", Offset = "0xC0D6BC", VA = "0xC0D6BC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xC0D6C0", Offset = "0xC0D6C0", VA = "0xC0D6C0")]
	public void ControllerLanguage()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xC1052C", Offset = "0xC1052C", VA = "0xC1052C")]
	public MenuLangController()
	{
	}
}
[Token(Token = "0x200001D")]
public class MirrorRotation : MonoBehaviour
{
	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform PlayerTransform;

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xC10590", Offset = "0xC10590", VA = "0xC10590")]
	private void Start()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xC10594", Offset = "0xC10594", VA = "0xC10594")]
	private void Update()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xC10608", Offset = "0xC10608", VA = "0xC10608")]
	public MirrorRotation()
	{
	}
}
[Token(Token = "0x200001E")]
public class FirstPersonController : MonoBehaviour
{
	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Rigidbody rb;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera playerCamera;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float fov;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool invertCamera;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool cameraCanMove;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float mouseSensitivity;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float maxLookAngle;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool lockCursor;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool crosshair;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Sprite crosshairImage;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Color crosshairColor;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float yaw;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float pitch;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Image crosshairObject;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool enableZoom;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool holdToZoom;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public KeyCode zoomKey;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float zoomFOV;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float zoomStepTime;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool isZoomed;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	public bool playerCanMove;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float walkSpeed;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float maxVelocityChange;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool isWalking;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
	public bool enableSprint;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
	public bool unlimitedSprint;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public KeyCode sprintKey;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float sprintSpeed;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float sprintDuration;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float sprintCooldown;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float sprintFOV;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float sprintFOVStepTime;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool useSprintBar;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	public bool hideBarWhenFull;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Image sprintBarBG;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Image sprintBar;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float sprintBarWidthPercent;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public float sprintBarHeightPercent;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private CanvasGroup sprintBarCG;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isSprinting;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float sprintRemaining;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float sprintBarWidth;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private float sprintBarHeight;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private bool isSprintCooldown;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float sprintCooldownReset;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public bool enableJump;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public KeyCode jumpKey;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public float jumpPower;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private bool isGrounded;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
	public bool enableCrouch;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEE")]
	public bool holdToCrouch;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public KeyCode crouchKey;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public float crouchHeight;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float speedReduction;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private bool isCrouched;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Vector3 originalScale;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public bool enableHeadBob;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Transform joint;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public float bobSpeed;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public Vector3 bobAmount;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Vector3 jointOriginalPos;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private float timer;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float camRotation;

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x959F24", Offset = "0x959F24", VA = "0x959F24")]
	private void Awake()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x95A014", Offset = "0x95A014", VA = "0x95A014")]
	private void Start()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x95A1FC", Offset = "0x95A1FC", VA = "0x95A1FC")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x95AA6C", Offset = "0x95AA6C", VA = "0x95AA6C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x95A704", Offset = "0x95A704", VA = "0x95A704")]
	private void CheckGround()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x95A610", Offset = "0x95A610", VA = "0x95A610")]
	private void Jump()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x95A67C", Offset = "0x95A67C", VA = "0x95A67C")]
	private void Crouch()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x95A8D8", Offset = "0x95A8D8", VA = "0x95A8D8")]
	private void HeadBob()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x95AD40", Offset = "0x95AD40", VA = "0x95AD40")]
	public FirstPersonController()
	{
	}
}
[Token(Token = "0x200001F")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x52B0B4", Offset = "0x52B0B4")]
public class FastList<T>
{
	[Token(Token = "0x2000164")]
	public delegate int CompareFunc(T left, T right);

	[Token(Token = "0x2000165")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B34C", Offset = "0x52B34C")]
	private sealed class <GetEnumerator>d__25 : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T <>2__current;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FastList<T> <>4__this;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <i>5__2;

		[Token(Token = "0x170000A0")]
		private T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Token(Token = "0x6000849")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x170000A1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600084B")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000846")]
		[DebuggerHidden]
		public <GetEnumerator>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000847")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000848")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600084A")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T[] array;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int size;

	[Token(Token = "0x17000001")]
	public int Count
	{
		[Token(Token = "0x60000A8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000A9")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public T Item
	{
		[Token(Token = "0x60000AA")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x60000AB")]
		set
		{
		}
	}

	[Token(Token = "0x60000A6")]
	public FastList()
	{
	}

	[Token(Token = "0x60000A7")]
	public FastList(int size)
	{
	}

	[Token(Token = "0x60000AC")]
	public void Add(T item)
	{
	}

	[Token(Token = "0x60000AD")]
	public void AddUnique(T item)
	{
	}

	[Token(Token = "0x60000AE")]
	public void AddRange(IEnumerable<T> items)
	{
	}

	[Token(Token = "0x60000AF")]
	public void Insert(int index, T item)
	{
	}

	[Token(Token = "0x60000B0")]
	public bool Remove(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B1")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x60000B2")]
	public bool RemoveFast(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B3")]
	public void RemoveAtFast(int index)
	{
	}

	[Token(Token = "0x60000B4")]
	public bool Contains(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B5")]
	public int IndexOf(T item)
	{
		return default(int);
	}

	[Token(Token = "0x60000B6")]
	public T Pop()
	{
		return (T)null;
	}

	[Token(Token = "0x60000B7")]
	public T[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	public void Sort(CompareFunc comparer)
	{
	}

	[Token(Token = "0x60000B9")]
	public void InsertionSort(CompareFunc comparer)
	{
	}

	[Token(Token = "0x60000BA")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52E7C4", Offset = "0x52E7C4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	public T Find(Predicate<T> match)
	{
		return (T)null;
	}

	[Token(Token = "0x60000BC")]
	private void Allocate()
	{
	}

	[Token(Token = "0x60000BD")]
	private void Trim()
	{
	}

	[Token(Token = "0x60000BE")]
	public void Clear()
	{
	}

	[Token(Token = "0x60000BF")]
	public void Release()
	{
	}
}
[Token(Token = "0x2000020")]
public class InspectorNoteAttribute : PropertyAttribute
{
	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string header;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly string message;

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x961B04", Offset = "0x961B04", VA = "0x961B04")]
	public InspectorNoteAttribute(string header, string message = "")
	{
	}
}
[Token(Token = "0x2000021")]
public class InspectorCommentAttribute : PropertyAttribute
{
	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string message;

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x961AD8", Offset = "0x961AD8", VA = "0x961AD8")]
	public InspectorCommentAttribute(string message = "")
	{
	}
}
[Token(Token = "0x2000022")]
public class OvrAvatarTestDriver : OvrAvatarDriver
{
	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 headPos;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion headRot;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x965FE4", Offset = "0x965FE4", VA = "0x965FE4")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x966148", Offset = "0x966148", VA = "0x966148")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x9664E4", Offset = "0x9664E4", VA = "0x9664E4")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x966688", Offset = "0x966688", VA = "0x966688", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x9666B8", Offset = "0x9666B8", VA = "0x9666B8")]
	public OvrAvatarTestDriver()
	{
	}
}
[Token(Token = "0x2000023")]
public class PoseEditHelper : MonoBehaviour
{
	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform poseRoot;

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x96ADE8", Offset = "0x96ADE8", VA = "0x96ADE8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x96AE7C", Offset = "0x96AE7C", VA = "0x96AE7C")]
	private void DrawJoints(Transform joint)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x96AFF0", Offset = "0x96AFF0", VA = "0x96AFF0")]
	public PoseEditHelper()
	{
	}
}
[Token(Token = "0x2000024")]
public class GazeTargetSpawner : MonoBehaviour
{
	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject GazeTargetPrefab;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int NumberOfDummyTargets;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int RadiusMultiplier;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isVisible;

	[Token(Token = "0x17000003")]
	public bool IsVisible
	{
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x95C3DC", Offset = "0x95C3DC", VA = "0x95C3DC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x95C3E4", Offset = "0x95C3E4", VA = "0x95C3E4")]
		set
		{
		}
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x95C520", Offset = "0x95C520", VA = "0x95C520")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x95C6E8", Offset = "0x95C6E8", VA = "0x95C6E8")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x95C6F0", Offset = "0x95C6F0", VA = "0x95C6F0")]
	public GazeTargetSpawner()
	{
	}
}
[Token(Token = "0x2000025")]
public class RemoteLoopbackManager : MonoBehaviour
{
	[Token(Token = "0x2000166")]
	private class PacketLatencyPair
	{
		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] PacketData;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FakeLatency;

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x866270", Offset = "0x866270", VA = "0x866270")]
		public PacketLatencyPair()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000167")]
	public class SimulatedLatencySettings
	{
		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52E754", Offset = "0x52E754")]
		public float FakeLatencyMax;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52E76C", Offset = "0x52E76C")]
		public float FakeLatencyMin;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52E784", Offset = "0x52E784")]
		public float LatencyWeight;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52E79C", Offset = "0x52E79C")]
		public int MaxSamples;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal float AverageWindow;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float LatencySum;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal LinkedList<float> LatencyValues;

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x866278", Offset = "0x866278", VA = "0x866278")]
		public float NextValue()
		{
			return default(float);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x8663B0", Offset = "0x8663B0", VA = "0x8663B0")]
		public SimulatedLatencySettings()
		{
		}
	}

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OvrAvatar LocalAvatar;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar LoopbackAvatar;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimulatedLatencySettings LatencySettings;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int PacketSequence;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LinkedList<PacketLatencyPair> packetQueue;

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x97008C", Offset = "0x97008C", VA = "0x97008C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x9701D0", Offset = "0x9701D0", VA = "0x9701D0")]
	private void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x9705A0", Offset = "0x9705A0", VA = "0x9705A0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x9704F8", Offset = "0x9704F8", VA = "0x9704F8")]
	private void SendPacketData(byte[] data)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x9708CC", Offset = "0x9708CC", VA = "0x9708CC")]
	private void ReceivePacketData(byte[] data)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x970BAC", Offset = "0x970BAC", VA = "0x970BAC")]
	public RemoteLoopbackManager()
	{
	}
}
[Token(Token = "0x2000026")]
public class P2PManager
{
	[Token(Token = "0x2000168")]
	private enum MessageType : byte
	{
		[Token(Token = "0x40008D4")]
		Update = 1
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x96756C", Offset = "0x96756C", VA = "0x96756C")]
	public P2PManager()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x967654", Offset = "0x967654", VA = "0x967654")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x9678D0", Offset = "0x9678D0", VA = "0x9678D0")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x967A30", Offset = "0x967A30", VA = "0x967A30")]
	private void PeerConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x967B94", Offset = "0x967B94", VA = "0x967B94")]
	private void ConnectionStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x967DD4", Offset = "0x967DD4", VA = "0x967DD4")]
	public void SendAvatarUpdate(ulong userID, Transform rootTransform, uint sequence, byte[] avatarPacket)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x9681D4", Offset = "0x9681D4", VA = "0x9681D4")]
	public void GetRemotePackets()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x968490", Offset = "0x968490", VA = "0x968490")]
	public void processAvatarPacket(RemotePlayer remote, byte[] packet, int offset)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x967FA0", Offset = "0x967FA0", VA = "0x967FA0")]
	private void PackByte(byte b, byte[] buf, int offset)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x9683C4", Offset = "0x9683C4", VA = "0x9683C4")]
	private byte ReadByte(byte[] buf, int offset)
	{
		return default(byte);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x96808C", Offset = "0x96808C", VA = "0x96808C")]
	private void PackFloat(float f, byte[] buf, int offset)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x9686D0", Offset = "0x9686D0", VA = "0x9686D0")]
	private float ReadFloat(byte[] buf, int offset)
	{
		return default(float);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x967FE8", Offset = "0x967FE8", VA = "0x967FE8")]
	private void PackULong(ulong u, byte[] buf, int offset)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x968408", Offset = "0x968408", VA = "0x968408")]
	private ulong ReadULong(byte[] buf, int offset)
	{
		return default(ulong);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x968130", Offset = "0x968130", VA = "0x968130")]
	private void PackUInt32(uint u, byte[] buf, int offset)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x968758", Offset = "0x968758", VA = "0x968758")]
	private uint ReadUInt32(byte[] buf, int offset)
	{
		return default(uint);
	}
}
[Token(Token = "0x2000027")]
public class PlayerController : SocialPlatformManager
{
	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Camera spyCamera;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject cameraRig;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool showUI;

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x96A224", Offset = "0x96A224", VA = "0x96A224", Slot = "5")]
	public override void Awake()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x96A5F8", Offset = "0x96A5F8", VA = "0x96A5F8", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x96A620", Offset = "0x96A620", VA = "0x96A620", Slot = "4")]
	public override void Update()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x96A9C8", Offset = "0x96A9C8", VA = "0x96A9C8")]
	private void checkInput()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x96AB70", Offset = "0x96AB70", VA = "0x96AB70")]
	private void ToggleCamera()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x96ABF0", Offset = "0x96ABF0", VA = "0x96ABF0")]
	private void ToggleUI()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x96AC44", Offset = "0x96AC44", VA = "0x96AC44")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x2000028")]
public class RemotePlayer
{
	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong remoteUserID;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool stillInRoom;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public PeerConnectionState p2pConnectionState;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PeerConnectionState voipConnectionState;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar RemoteAvatar;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 receivedRootPosition;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 receivedRootPositionPrior;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Quaternion receivedRootRotation;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Quaternion receivedRootRotationPrior;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public VoipAudioSourceHiLevel voipSource;

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x970C60", Offset = "0x970C60", VA = "0x970C60")]
	public RemotePlayer()
	{
	}
}
[Token(Token = "0x2000029")]
public class RoomManager
{
	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong roomID;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong invitedRoomID;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool amIServer;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool startupDone;

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x970C68", Offset = "0x970C68", VA = "0x970C68")]
	public RoomManager()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x970D84", Offset = "0x970D84", VA = "0x970D84")]
	private void AcceptingInviteCallback(Message<string> msg)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x970FB4", Offset = "0x970FB4", VA = "0x970FB4")]
	public bool CheckForInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x9710F4", Offset = "0x9710F4", VA = "0x9710F4")]
	public void CreateRoom()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x9711D0", Offset = "0x9711D0", VA = "0x9711D0")]
	private void CreateAndJoinPrivateRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x9716AC", Offset = "0x9716AC", VA = "0x9716AC")]
	private void OnLaunchInviteWorkflowComplete(Message msg)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x970FE4", Offset = "0x970FE4", VA = "0x970FE4")]
	public void JoinExistingRoom(ulong roomID)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x971730", Offset = "0x971730", VA = "0x971730")]
	private void JoinRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x971E28", Offset = "0x971E28", VA = "0x971E28")]
	private void RoomUpdateCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x97211C", Offset = "0x97211C", VA = "0x97211C")]
	public void LeaveCurrentRoom()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x971A08", Offset = "0x971A08", VA = "0x971A08")]
	private void ProcessRoomData(Message<Room> msg)
	{
	}
}
[Token(Token = "0x200002A")]
public class SocialPlatformManager : MonoBehaviour
{
	[Token(Token = "0x2000169")]
	public enum State
	{
		[Token(Token = "0x40008D6")]
		INITIALIZING,
		[Token(Token = "0x40008D7")]
		CHECKING_LAUNCH_STATE,
		[Token(Token = "0x40008D8")]
		CREATING_A_ROOM,
		[Token(Token = "0x40008D9")]
		WAITING_IN_A_ROOM,
		[Token(Token = "0x40008DA")]
		JOINING_A_ROOM,
		[Token(Token = "0x40008DB")]
		CONNECTED_IN_A_ROOM,
		[Token(Token = "0x40008DC")]
		LEAVING_A_ROOM,
		[Token(Token = "0x40008DD")]
		SHUTDOWN
	}

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 START_ROTATION_ONE;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly Vector3 START_POSITION_ONE;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 START_ROTATION_TWO;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly Vector3 START_POSITION_TWO;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Vector3 START_ROTATION_THREE;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly Vector3 START_POSITION_THREE;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly Vector3 START_ROTATION_FOUR;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static readonly Vector3 START_POSITION_FOUR;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly Color BLACK;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static readonly Color WHITE;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static readonly Color CYAN;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static readonly Color BLUE;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static readonly Color GREEN;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float voiceCurrent;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private uint packetSequence;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar localAvatarPrefab;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar remoteAvatarPrefab;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject helpPanel;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected MeshRenderer helpMesh;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material riftMaterial;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material gearMaterial;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected OvrAvatar localAvatar;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected GameObject localTrackingSpace;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject localPlayerHead;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Dictionary<ulong, RemotePlayer> remoteUsers;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject roomSphere;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected MeshRenderer sphereMesh;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject roomFloor;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected MeshRenderer floorMesh;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected State currentState;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected static SocialPlatformManager s_instance;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected RoomManager roomManager;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected P2PManager p2pManager;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected VoipManager voipManager;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected ulong myID;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected string myOculusID;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public static readonly float VOIP_SCALE;

	[Token(Token = "0x17000004")]
	public static State CurrentState
	{
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x9761A4", Offset = "0x9761A4", VA = "0x9761A4")]
		get
		{
			return default(State);
		}
	}

	[Token(Token = "0x17000005")]
	public static ulong MyID
	{
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x967730", Offset = "0x967730", VA = "0x967730")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17000006")]
	public static string MyOculusID
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x976214", Offset = "0x976214", VA = "0x976214")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x96A644", Offset = "0x96A644", VA = "0x96A644", Slot = "4")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x96A25C", Offset = "0x96A25C", VA = "0x96A25C", Slot = "5")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x975000", Offset = "0x975000", VA = "0x975000")]
	private void InitCallback(Message<PlatformInitialize> msg)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x96A61C", Offset = "0x96A61C", VA = "0x96A61C", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x9751B8", Offset = "0x9751B8", VA = "0x9751B8")]
	private void IsEntitledCallback(Message msg)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x9752D8", Offset = "0x9752D8", VA = "0x9752D8")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x9759E8", Offset = "0x9759E8", VA = "0x9759E8")]
	private void GetLoggedInUserFriendsAndRoomsCallback(Message<UserAndRoomList> msg)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x975DBC", Offset = "0x975DBC", VA = "0x975DBC")]
	public void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x975FBC", Offset = "0x975FBC", VA = "0x975FBC")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x976138", Offset = "0x976138", VA = "0x976138")]
	public void AddUser(ulong userID, RemotePlayer remoteUser)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x974F44", Offset = "0x974F44", VA = "0x974F44")]
	public void LogOutputLine(string line)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x970EF4", Offset = "0x970EF4", VA = "0x970EF4")]
	public static void TerminateWithError(Message msg)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x9712EC", Offset = "0x9712EC", VA = "0x9712EC")]
	public static void TransitionToState(State newState)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x97633C", Offset = "0x97633C", VA = "0x97633C")]
	private static void SetSphereColorForState()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x9715A0", Offset = "0x9715A0", VA = "0x9715A0")]
	public static void SetFloorColorForState(bool host)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x972190", Offset = "0x972190", VA = "0x972190")]
	public static void MarkAllRemoteUsersAsNotInRoom()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x972574", Offset = "0x972574", VA = "0x972574")]
	public static void MarkRemoteUserInRoom(ulong userID)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x972660", Offset = "0x972660", VA = "0x972660")]
	public static void ForgetRemoteUsersNotInRoom()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x967810", Offset = "0x967810", VA = "0x967810")]
	public static void LogOutput(string line)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x9722E8", Offset = "0x9722E8", VA = "0x9722E8")]
	public static bool IsUserInRoom(ulong userID)
	{
		return default(bool);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x972384", Offset = "0x972384", VA = "0x972384")]
	public static void AddRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x9764E4", Offset = "0x9764E4", VA = "0x9764E4")]
	public static void RemoveRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x9766FC", Offset = "0x9766FC", VA = "0x9766FC")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x974EC0", Offset = "0x974EC0", VA = "0x974EC0")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x52E82C", Offset = "0x52E82C")]
	public static void MicFilter(short[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x96794C", Offset = "0x96794C", VA = "0x96794C")]
	public static RemotePlayer GetRemoteUser(ulong userID)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x96ACB4", Offset = "0x96ACB4", VA = "0x96ACB4")]
	public SocialPlatformManager()
	{
	}
}
[Token(Token = "0x200002B")]
public class VoipManager
{
	[Token(Token = "0x6000116")]
	[Address(RVA = "0xAEB69C", Offset = "0xAEB69C", VA = "0xAEB69C")]
	public VoipManager()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xAEB784", Offset = "0xAEB784", VA = "0xAEB784")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xAEB868", Offset = "0xAEB868", VA = "0xAEB868")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xAEB8E8", Offset = "0xAEB8E8", VA = "0xAEB8E8")]
	private void VoipConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xAEBA58", Offset = "0xAEBA58", VA = "0xAEBA58")]
	private void VoipStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}
}
[Token(Token = "0x200002C")]
public class GazeTarget : MonoBehaviour
{
	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarGazeTargetType Type;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ovrAvatarGazeTargets RuntimeTargetList;

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x95C098", Offset = "0x95C098", VA = "0x95C098")]
	static GazeTarget()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x95C118", Offset = "0x95C118", VA = "0x95C118")]
	private void Start()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x95C28C", Offset = "0x95C28C", VA = "0x95C28C")]
	private void Update()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x95C2F0", Offset = "0x95C2F0", VA = "0x95C2F0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x95C154", Offset = "0x95C154", VA = "0x95C154")]
	private void UpdateGazeTarget()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x95C3BC", Offset = "0x95C3BC", VA = "0x95C3BC")]
	private ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x95C3D4", Offset = "0x95C3D4", VA = "0x95C3D4")]
	public GazeTarget()
	{
	}
}
[Serializable]
[Token(Token = "0x200002D")]
public class AvatarLayer
{
	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int layerIndex;

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x9BBAC8", Offset = "0x9BBAC8", VA = "0x9BBAC8")]
	public AvatarLayer()
	{
	}
}
[Serializable]
[Token(Token = "0x200002E")]
public class PacketRecordSettings
{
	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal bool RecordingFrames;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float UpdateRate;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal float AccumulatedTime;

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x9687E0", Offset = "0x9687E0", VA = "0x9687E0")]
	public PacketRecordSettings()
	{
	}
}
[Token(Token = "0x200002F")]
public class OvrAvatar : MonoBehaviour
{
	[Token(Token = "0x200016A")]
	public class PacketEventArgs : EventArgs
	{
		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly OvrAvatarPacket Packet;

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x8641E4", Offset = "0x8641E4", VA = "0x8641E4")]
		public PacketEventArgs(OvrAvatarPacket packet)
		{
		}
	}

	[Token(Token = "0x200016B")]
	public enum HandType
	{
		[Token(Token = "0x40008E0")]
		Right,
		[Token(Token = "0x40008E1")]
		Left,
		[Token(Token = "0x40008E2")]
		Max
	}

	[Token(Token = "0x200016C")]
	public enum HandJoint
	{
		[Token(Token = "0x40008E4")]
		HandBase,
		[Token(Token = "0x40008E5")]
		IndexBase,
		[Token(Token = "0x40008E6")]
		IndexTip,
		[Token(Token = "0x40008E7")]
		ThumbBase,
		[Token(Token = "0x40008E8")]
		ThumbTip,
		[Token(Token = "0x40008E9")]
		Max
	}

	[Token(Token = "0x200016D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B35C", Offset = "0x52B35C")]
	private sealed class <WaitForMouthAudioSource>d__137 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatar <>4__this;

		[Token(Token = "0x170000A2")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000853")]
			[Address(RVA = "0x864194", Offset = "0x864194", VA = "0x864194", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000855")]
			[Address(RVA = "0x8641DC", Offset = "0x8641DC", VA = "0x8641DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x863FC4", Offset = "0x863FC4", VA = "0x863FC4")]
		[DebuggerHidden]
		public <WaitForMouthAudioSource>d__137(int <>1__state)
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x863FF0", Offset = "0x863FF0", VA = "0x863FF0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x863FF4", Offset = "0x863FF4", VA = "0x863FF4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x86419C", Offset = "0x86419C", VA = "0x86419C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52B854", Offset = "0x52B854")]
	public IntPtr sdkAvatar;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string oculusUserID;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatarDriver Driver;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52B88C", Offset = "0x52B88C")]
	public bool EnableBody;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool EnableHands;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool EnableBase;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool EnableExpressive;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52B8C4", Offset = "0x52B8C4")]
	public bool RecordPackets;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool UseSDKPackets;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public PacketRecordSettings PacketSettings;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52B8FC", Offset = "0x52B8FC")]
	public bool StartWithControllers;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AvatarLayer FirstPersonLayer;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AvatarLayer ThirdPersonLayer;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool ShowFirstPerson;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool ShowThirdPerson;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	internal ovrAvatarCapabilities Capabilities;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52B934", Offset = "0x52B934")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52B934", Offset = "0x52B934")]
	[SerializeField]
	internal ovrAvatarAssetLevelOfDetail LevelOfDetail;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52B9A4", Offset = "0x52B9A4")]
	private bool CombineMeshes;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52B9DC", Offset = "0x52B9DC")]
	public bool UseTransparentRenderQueue;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52BA14", Offset = "0x52BA14")]
	public Shader Monochrome_SurfaceShader;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Shader Monochrome_SurfaceShader_SelfOccluding;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Shader Monochrome_SurfaceShader_PBS;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Shader Skinshaded_SurfaceShader_SingleComponent;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Shader Skinshaded_VertFrag_SingleComponent;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Shader Skinshaded_VertFrag_CombinedMesh;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Shader Skinshaded_Expressive_SurfaceShader_SingleComponent;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Shader Skinshaded_Expressive_VertFrag_SingleComponent;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Shader Skinshaded_Expressive_VertFrag_CombinedMesh;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Shader Loader_VertFrag_CombinedMesh;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Shader EyeLens;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Shader ControllerShader;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52BA4C", Offset = "0x52BA4C")]
	public bool CanOwnMicrophone;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BA84", Offset = "0x52BA84")]
	public bool EnableLaughter;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject MouthAnchor;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform LeftHandCustomPose;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform RightHandCustomPose;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private HashSet<ulong> assetLoadingIds;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool assetsFinishedLoading;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private OvrAvatarMaterialManager materialManager;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool waitingForCombinedMesh;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool doneExpressiveGlobalInit;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector4 clothingAlphaOffset;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ulong clothingAlphaTexture;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private OVRLipSyncMicInput micInput;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private OVRLipSyncContext lipsyncContext;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private OVRLipSync.Frame currentFrame;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float[] visemes;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private AudioSource audioSource;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ONSPAudioSource spatializedSource;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<float[]> voiceUpdates;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ovrAvatarVisemes RuntimeVisemes;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Transform cachedLeftHandCustomPose;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Transform[] cachedCustomLeftHandJoints;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private ovrAvatarTransform[] cachedLeftHandTransforms;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Transform cachedRightHandCustomPose;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Transform[] cachedCustomRightHandJoints;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ovrAvatarTransform[] cachedRightHandTransforms;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool showLeftController;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
	private bool showRightController;

	[Token(Token = "0x400017A")]
	private const bool USE_MOBILE_TEXTURE_FORMAT = true;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 MOUTH_HEAD_OFFSET;

	[Token(Token = "0x400017C")]
	private const string MOUTH_HELPER_NAME = "MouthAnchor";

	[Token(Token = "0x400017D")]
	private const int VISEME_COUNT = 16;

	[Token(Token = "0x400017E")]
	private const float ACTION_UNIT_ONSET_SPEED = 30f;

	[Token(Token = "0x400017F")]
	private const float ACTION_UNIT_FALLOFF_SPEED = 20f;

	[Token(Token = "0x4000180")]
	private const float VISEME_LEVEL_MULTIPLIER = 1.5f;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	internal ulong oculusUserIDInternal;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	internal OvrAvatarBase Base;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	internal OvrAvatarTouchController ControllerLeft;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	internal OvrAvatarTouchController ControllerRight;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	internal OvrAvatarBody Body;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	internal OvrAvatarHand HandLeft;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	internal OvrAvatarHand HandRight;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	internal ovrAvatarLookAndFeelVersion LookAndFeelVersion;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	internal ovrAvatarLookAndFeelVersion FallbackLookAndFeelVersion;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private OvrAvatarPacket CurrentUnityPacket;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public EventHandler<PacketEventArgs> PacketRecorded;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string[,] HandJoints;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Vector3 MOUTH_POSITION_OFFSET;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static string VOICE_PROPERTY;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static string MOUTH_POSITION_PROPERTY;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static string MOUTH_DIRECTION_PROPERTY;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static string MOUTH_SCALE_PROPERTY;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static float MOUTH_SCALE_GLOBAL;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static float MOUTH_MAX_GLOBAL;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static string NECK_JONT;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public float VoiceAmplitude;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public bool EnableMouthVertexAnimation;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static ovrAvatarLights ovrLights;

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xC8A368", Offset = "0xC8A368", VA = "0xC8A368")]
	static OvrAvatar()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xC8A75C", Offset = "0xC8A75C", VA = "0xC8A75C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xC8A7F0", Offset = "0xC8A7F0", VA = "0xC8A7F0")]
	public void AssetLoadedCallback(OvrAvatarAsset asset)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xC8A858", Offset = "0xC8A858", VA = "0xC8A858")]
	public void CombinedMeshLoadedCallback(IntPtr assetPtr)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xC8A988", Offset = "0xC8A988", VA = "0xC8A988")]
	private OvrAvatarSkinnedMeshRenderComponent AddSkinnedMeshRenderComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xC8AA68", Offset = "0xC8AA68", VA = "0xC8AA68")]
	private OvrAvatarSkinnedMeshRenderPBSComponent AddSkinnedMeshRenderPBSComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xC8AB3C", Offset = "0xC8AB3C", VA = "0xC8AB3C")]
	private OvrAvatarSkinnedMeshPBSV2RenderComponent AddSkinnedMeshRenderPBSV2Component(IntPtr renderPart, GameObject go, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRenderPBSV2, bool isBodyPartZero, bool isControllerModel)
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xC8AD1C", Offset = "0xC8AD1C", VA = "0xC8AD1C")]
	public static IntPtr GetRenderPart(ovrAvatarComponent component, uint renderPartIndex)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xC8AE00", Offset = "0xC8AE00", VA = "0xC8AE00")]
	private static string GetRenderPartName(ovrAvatarComponent component, uint renderPartIndex)
	{
		return null;
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xC8AE80", Offset = "0xC8AE80", VA = "0xC8AE80")]
	internal static void ConvertTransform(float[] transform, ovrAvatarTransform target)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xC8AF68", Offset = "0xC8AF68", VA = "0xC8AF68")]
	internal static void ConvertTransform(ovrAvatarTransform transform, Transform target)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xC8AFF4", Offset = "0xC8AFF4", VA = "0xC8AFF4")]
	public static ovrAvatarTransform CreateOvrAvatarTransform(Vector3 position, Quaternion orientation)
	{
		return default(ovrAvatarTransform);
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xC8B07C", Offset = "0xC8B07C", VA = "0xC8B07C")]
	private static ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xC8B094", Offset = "0xC8B094", VA = "0xC8B094")]
	private void BuildRenderComponents()
	{
	}

	[Token(Token = "0x6000132")]
	private void AddAvatarComponent<T>(T root, ovrAvatarComponent nativeComponent) where T : OvrAvatarComponent
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xC8B500", Offset = "0xC8B500", VA = "0xC8B500")]
	private void UpdateCustomPoses()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xC8B870", Offset = "0xC8B870", VA = "0xC8B870")]
	private static bool UpdatePoseRoot(Transform poseRoot, Transform cachedPoseRoot, Transform[] cachedPoseJoints, ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xC8BA18", Offset = "0xC8BA18", VA = "0xC8BA18")]
	private static bool UpdateTransforms(Transform[] joints, ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xC8BC64", Offset = "0xC8BC64", VA = "0xC8BC64")]
	private static void OrderJoints(Transform transform, List<Transform> joints)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xC8BD58", Offset = "0xC8BD58", VA = "0xC8BD58")]
	private void AvatarSpecificationCallback(IntPtr avatarSpecification)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xC8C838", Offset = "0xC8C838", VA = "0xC8C838")]
	private void Start()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xC8CC44", Offset = "0xC8CC44", VA = "0xC8CC44")]
	private void Update()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xC8D6CC", Offset = "0xC8D6CC", VA = "0xC8D6CC")]
	public static ovrAvatarHandInputState CreateInputState(ovrAvatarTransform transform, OvrAvatarDriver.ControllerPose pose)
	{
		return default(ovrAvatarHandInputState);
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xC8D714", Offset = "0xC8D714", VA = "0xC8D714")]
	public void ShowControllers(bool show)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xC8C000", Offset = "0xC8C000", VA = "0xC8C000")]
	public void ShowLeftController(bool show)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xC8C0A4", Offset = "0xC8C0A4", VA = "0xC8C0A4")]
	public void ShowRightController(bool show)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xC8D744", Offset = "0xC8D744", VA = "0xC8D744")]
	public void UpdateVoiceVisualization(float[] voiceSamples)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xC8D010", Offset = "0xC8D010", VA = "0xC8D010")]
	private void RecordFrame()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xC8D9B8", Offset = "0xC8D9B8", VA = "0xC8D9B8")]
	private void RecordUnityFrame()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xC8D7A8", Offset = "0xC8D7A8", VA = "0xC8D7A8")]
	private void RecordSDKFrame()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xC8E0F4", Offset = "0xC8E0F4", VA = "0xC8E0F4")]
	private void AddRenderParts(OvrAvatarComponent ovrComponent, ovrAvatarComponent component, Transform parent)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xC8E568", Offset = "0xC8E568", VA = "0xC8E568")]
	public void RefreshBodyParts()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xC8E97C", Offset = "0xC8E97C", VA = "0xC8E97C")]
	public ovrAvatarBodyComponent? GetBodyComponent()
	{
		return null;
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xC8EAD0", Offset = "0xC8EAD0", VA = "0xC8EAD0")]
	public Transform GetHandTransform(HandType hand, HandJoint joint)
	{
		return null;
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xC8ECB4", Offset = "0xC8ECB4", VA = "0xC8ECB4")]
	public void GetPointingDirection(HandType hand, Vector3 forward, Vector3 up)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xC8D24C", Offset = "0xC8D24C", VA = "0xC8D24C")]
	private void UpdateVoiceBehavior()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xC8ED88", Offset = "0xC8ED88", VA = "0xC8ED88")]
	private bool IsValidMic()
	{
		return default(bool);
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xC8D020", Offset = "0xC8D020", VA = "0xC8D020")]
	private void InitPostLoad()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xC8EE78", Offset = "0xC8EE78", VA = "0xC8EE78")]
	private static void ExpressiveGlobalInit()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xC8F4E0", Offset = "0xC8F4E0", VA = "0xC8F4E0")]
	private static void InitializeLights()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xC8F9C4", Offset = "0xC8F9C4", VA = "0xC8F9C4")]
	private static ovrAvatarLight CreateLightDirectional(uint id, Vector3 direction, float intensity, ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xC8F9EC", Offset = "0xC8F9EC", VA = "0xC8F9EC")]
	private static ovrAvatarLight CreateLightPoint(uint id, Vector3 position, float range, float intensity, ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xC8FA14", Offset = "0xC8FA14", VA = "0xC8FA14")]
	private static ovrAvatarLight CreateLightSpot(uint id, Vector3 position, Vector3 direction, float spotAngleDeg, float range, float intensity, ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xC8D558", Offset = "0xC8D558", VA = "0xC8D558")]
	private void UpdateExpressive()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xC8EF3C", Offset = "0xC8EF3C", VA = "0xC8EF3C")]
	private void ConfigureHelpers()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xC8FE3C", Offset = "0xC8FE3C", VA = "0xC8FE3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52E894", Offset = "0x52E894")]
	private IEnumerator WaitForMouthAudioSource()
	{
		return null;
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xC8FEB0", Offset = "0xC8FEB0", VA = "0xC8FEB0")]
	public void DestroyHelperObjects()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xC8FCF4", Offset = "0xC8FCF4", VA = "0xC8FCF4")]
	public GameObject CreateHelperObject(Transform parent, Vector3 localPositionOffset, string helperName, string helperTag = "")
	{
		return null;
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xC8FF74", Offset = "0xC8FF74", VA = "0xC8FF74")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xC9005C", Offset = "0xC9005C", VA = "0xC9005C")]
	public void UpdateVoiceData(float[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xC8FA50", Offset = "0xC8FA50", VA = "0xC8FA50")]
	private void UpdateFacewave()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xC90144", Offset = "0xC90144", VA = "0xC90144")]
	public OvrAvatar()
	{
	}
}
[Token(Token = "0x2000030")]
public class OvrAvatarAsset
{
	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong assetID;

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xC90314", Offset = "0xC90314", VA = "0xC90314")]
	public OvrAvatarAsset()
	{
	}
}
[Token(Token = "0x2000031")]
public class OvrAvatarAssetMesh : OvrAvatarAsset
{
	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mesh mesh;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAvatarSkinnedMeshPose skinnedBindPose;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string[] jointNames;

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xC903D8", Offset = "0xC903D8", VA = "0xC903D8")]
	public OvrAvatarAssetMesh(ulong _assetId, IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xC91664", Offset = "0xC91664", VA = "0xC91664")]
	private void LoadSubmeshes(IntPtr asset, IntPtr indexBufferPtr, ulong indexCount)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xC91244", Offset = "0xC91244", VA = "0xC91244")]
	private void LoadBlendShapes(IntPtr asset, long vertexCount)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xC90FC4", Offset = "0xC90FC4", VA = "0xC90FC4")]
	private void SetSkinnedBindPose(IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xC910AC", Offset = "0xC910AC", VA = "0xC910AC")]
	private void GetVertexAndIndexData(IntPtr asset, ovrAvatarAssetType meshType, [Out] long vertexCount, [Out] IntPtr vertexBuffer, [Out] uint indexCount, [Out] IntPtr indexBuffer)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xC918F4", Offset = "0xC918F4", VA = "0xC918F4")]
	public SkinnedMeshRenderer CreateSkinnedMeshRendererOnObject(GameObject target)
	{
		return null;
	}
}
[Token(Token = "0x2000032")]
public class OvrAvatarAssetTexture : OvrAvatarAsset
{
	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D texture;

	[Token(Token = "0x400019D")]
	private const int ASTCHeaderSize = 16;

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xC91E58", Offset = "0xC91E58", VA = "0xC91E58")]
	public OvrAvatarAssetTexture(ulong _assetId, IntPtr asset)
	{
	}
}
[Token(Token = "0x2000033")]
public class OvrAvatarBase : OvrAvatarComponent
{
	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ovrAvatarBaseComponent component;

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xC920C8", Offset = "0xC920C8", VA = "0xC920C8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xC92524", Offset = "0xC92524", VA = "0xC92524")]
	public OvrAvatarBase()
	{
	}
}
[Token(Token = "0x2000034")]
public class OvrAvatarBody : OvrAvatarComponent
{
	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ovrAvatarBodyComponent component;

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xC8E80C", Offset = "0xC8E80C", VA = "0xC8E80C")]
	public ovrAvatarComponent? GetNativeAvatarComponent()
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xC92654", Offset = "0xC92654", VA = "0xC92654")]
	private void Update()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xC92778", Offset = "0xC92778", VA = "0xC92778")]
	public OvrAvatarBody()
	{
	}
}
[Token(Token = "0x2000035")]
public class OvrAvatarComponent : MonoBehaviour
{
	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] LayerKeywords;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string[] LayerSampleModeParameters;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string[] LayerBlendModeParameters;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string[] LayerMaskTypeParameters;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string[] LayerColorParameters;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly string[] LayerSurfaceParameters;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly string[] LayerSampleParametersParameters;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly string[] LayerMaskParametersParameters;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly string[] LayerMaskAxisParameters;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Material, ovrAvatarMaterialState> materialStates;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<OvrAvatarRenderComponent> RenderParts;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected OvrAvatar owner;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected ovrAvatarComponent nativeAvatarComponent;

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xC927E0", Offset = "0xC927E0", VA = "0xC927E0")]
	public void SetOvrAvatarOwner(OvrAvatar ovrAvatarOwner)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xC921EC", Offset = "0xC921EC", VA = "0xC921EC")]
	public void UpdateAvatar(IntPtr nativeComponent)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xC927E8", Offset = "0xC927E8", VA = "0xC927E8")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xC92848", Offset = "0xC92848", VA = "0xC92848")]
	public void UpdateAvatarMaterial(Material mat, ovrAvatarMaterialState matState)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xC92FDC", Offset = "0xC92FDC", VA = "0xC92FDC")]
	public static Texture2D GetLoadedTexture(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xC9258C", Offset = "0xC9258C", VA = "0xC9258C")]
	public OvrAvatarComponent()
	{
	}
}
[Token(Token = "0x2000036")]
public abstract class OvrAvatarDriver : MonoBehaviour
{
	[Token(Token = "0x200016E")]
	public enum PacketMode
	{
		[Token(Token = "0x40008EE")]
		SDK,
		[Token(Token = "0x40008EF")]
		Unity
	}

	[Token(Token = "0x200016F")]
	public struct ControllerPose
	{
		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarButton buttons;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ovrAvatarTouch touches;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 joystickPosition;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float indexTrigger;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float handTrigger;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isActive;

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x86425C", Offset = "0x86425C", VA = "0x86425C")]
		public static ControllerPose Interpolate(ControllerPose a, ControllerPose b, float t)
		{
			return default(ControllerPose);
		}
	}

	[Token(Token = "0x2000170")]
	public struct PoseFrame
	{
		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 headPosition;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Quaternion headRotation;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 handLeftPosition;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Quaternion handLeftRotation;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 handRightPosition;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Quaternion handRightRotation;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float voiceAmplitude;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ControllerPose controllerLeftPose;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public ControllerPose controllerRightPose;

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x864338", Offset = "0x864338", VA = "0x864338")]
		public static PoseFrame Interpolate(PoseFrame a, PoseFrame b, float t)
		{
			return default(PoseFrame);
		}
	}

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PacketMode Mode;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected PoseFrame CurrentPose;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private ovrAvatarControllerType ControllerType;

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xC9441C", Offset = "0xC9441C", VA = "0xC9441C")]
	public PoseFrame GetCurrentPose()
	{
		return default(PoseFrame);
	}

	[Token(Token = "0x600016D")]
	public abstract void UpdateTransforms(IntPtr sdkAvatar);

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xC9442C", Offset = "0xC9442C", VA = "0xC9442C")]
	private void Start()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xC8C148", Offset = "0xC8C148", VA = "0xC8C148")]
	public void UpdateTransformsFromPose(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xC944BC", Offset = "0xC944BC", VA = "0xC944BC")]
	public static bool GetIsTrackedRemote()
	{
		return default(bool);
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xC944C4", Offset = "0xC944C4", VA = "0xC944C4")]
	protected OvrAvatarDriver()
	{
	}
}
[Token(Token = "0x2000037")]
public class OvrAvatarHand : OvrAvatarComponent
{
	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarHandComponent component;

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xC944D4", Offset = "0xC944D4", VA = "0xC944D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xC94638", Offset = "0xC94638", VA = "0xC94638")]
	public OvrAvatarHand()
	{
	}
}
[Token(Token = "0x2000038")]
public class OvrAvatarLocalDriver : OvrAvatarDriver
{
	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 centerEyePosition;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion centerEyeRotation;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xC946A8", Offset = "0xC946A8", VA = "0xC946A8")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xC9480C", Offset = "0xC9480C", VA = "0xC9480C")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xC94BA8", Offset = "0xC94BA8", VA = "0xC94BA8")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xC94DCC", Offset = "0xC94DCC", VA = "0xC94DCC", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xC94DF8", Offset = "0xC94DF8", VA = "0xC94DF8")]
	public OvrAvatarLocalDriver()
	{
	}
}
[Token(Token = "0x2000039")]
public class OvrAvatarMaterialManager : MonoBehaviour
{
	[Token(Token = "0x2000171")]
	public enum TextureType
	{
		[Token(Token = "0x4000900")]
		DiffuseTextures,
		[Token(Token = "0x4000901")]
		NormalMaps,
		[Token(Token = "0x4000902")]
		RoughnessMaps,
		[Token(Token = "0x4000903")]
		Count
	}

	[Token(Token = "0x2000172")]
	public struct AvatarComponentMaterialProperties
	{
		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarBodyPartType TypeIndex;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Color Color;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D[] Textures;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DiffuseIntensity;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RimIntensity;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ReflectionIntensity;
	}

	[Token(Token = "0x2000173")]
	public struct AvatarTextureArrayProperties
	{
		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D[] Textures;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2DArray TextureArray;
	}

	[Token(Token = "0x2000174")]
	public struct AvatarMaterialPropertyBlock
	{
		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4[] Colors;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] DiffuseIntensities;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] RimIntensities;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] ReflectionIntensities;
	}

	[Serializable]
	[Token(Token = "0x2000175")]
	public class AvatarMaterialConfig
	{
		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AvatarComponentMaterialProperties[] ComponentMaterialProperties;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AvatarMaterialPropertyBlock MaterialPropertyBlock;

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x864D38", Offset = "0x864D38", VA = "0x864D38")]
		public AvatarMaterialConfig()
		{
		}
	}

	[Token(Token = "0x2000176")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B36C", Offset = "0x52B36C")]
	private sealed class <RunLoadingAnimation>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatarMaterialManager <>4__this;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callBack;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <srcBlend>5__2;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <dstBlend>5__3;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <lightModeTag>5__4;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <renderTypeTag>5__5;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <renderQueueTag>5__6;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string <ignoreProjectorTag>5__7;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int <renderQueue>5__8;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool <transparentQueue>5__9;

		[Token(Token = "0x170000A4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0x864CE8", Offset = "0x864CE8", VA = "0x864CE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600085E")]
			[Address(RVA = "0x864D30", Offset = "0x864D30", VA = "0x864D30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x86463C", Offset = "0x86463C", VA = "0x86463C")]
		[DebuggerHidden]
		public <RunLoadingAnimation>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x864668", Offset = "0x864668", VA = "0x864668", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x86466C", Offset = "0x86466C", VA = "0x86466C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x864CF0", Offset = "0x864CF0", VA = "0x864CF0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer TargetRenderer;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AvatarTextureArrayProperties[] TextureArrays;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string[] TextureTypeToShaderProperties;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AvatarMaterialConfig LocalAvatarConfig;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ReflectionProbeBlendInfo> ReflectionProbes;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader CombinedShader;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string AVATAR_SHADER_LOADER;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string AVATAR_SHADER_MAINTEX;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string AVATAR_SHADER_NORMALMAP;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string AVATAR_SHADER_ROUGHNESSMAP;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string AVATAR_SHADER_COLOR;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string AVATAR_SHADER_DIFFUSEINTENSITY;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string AVATAR_SHADER_RIMINTENSITY;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string AVATAR_SHADER_REFLECTIONINTENSITY;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string AVATAR_SHADER_CUBEMAP;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string AVATAR_SHADER_ALPHA;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static string AVATAR_SHADER_LOADING_DIMMER;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static string AVATAR_SHADER_IRIS_COLOR;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static string AVATAR_SHADER_LIP_COLOR;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static string AVATAR_SHADER_BROW_COLOR;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static string AVATAR_SHADER_LASH_COLOR;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static string AVATAR_SHADER_SCLERA_COLOR;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static string AVATAR_SHADER_GUM_COLOR;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static string AVATAR_SHADER_TEETH_COLOR;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static string AVATAR_SHADER_LIP_SMOOTHNESS;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static float[] DiffuseIntensities;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static float[] RimIntensities;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static float[] ReflectionIntensities;

	[Token(Token = "0x40001D1")]
	private const float LOADING_ANIMATION_AMPLITUDE = 0.5f;

	[Token(Token = "0x40001D2")]
	private const float LOADING_ANIMATION_PERIOD = 0.35f;

	[Token(Token = "0x40001D3")]
	private const float LOADING_ANIMATION_CURVE_SCALE = 0.25f;

	[Token(Token = "0x40001D4")]
	private const float LOADING_ANIMATION_DIMMER_MIN = 0.3f;

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xC94E44", Offset = "0xC94E44", VA = "0xC94E44")]
	public void CreateTextureArrays()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xC94FD0", Offset = "0xC94FD0", VA = "0xC94FD0")]
	public void SetRenderer(Renderer renderer)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xC94FFC", Offset = "0xC94FFC", VA = "0xC94FFC")]
	public void OnCombinedMeshReady()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xC9575C", Offset = "0xC9575C", VA = "0xC9575C")]
	public void AddTextureIDToTextureManager(ulong assetID, bool isSingleComponent)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xC95848", Offset = "0xC95848", VA = "0xC95848")]
	private void DeleteTextureSet()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xC950A0", Offset = "0xC950A0", VA = "0xC950A0")]
	public void InitTextureArrays()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xC95894", Offset = "0xC95894", VA = "0xC95894")]
	private void ProcessTexturesWithMips(Texture2D[] textures, int texArrayResolution, Texture2DArray texArray)
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xC954D4", Offset = "0xC954D4", VA = "0xC954D4")]
	private void SetMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xC9597C", Offset = "0xC9597C", VA = "0xC9597C")]
	private void ApplyMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xC95C20", Offset = "0xC95C20", VA = "0xC95C20")]
	public static ovrAvatarBodyPartType GetComponentType(string objectName)
	{
		return default(ovrAvatarBodyPartType);
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xC95D48", Offset = "0xC95D48", VA = "0xC95D48")]
	private ulong GetTextureIDForType(ovrAvatarPBSMaterialState materialState, TextureType type)
	{
		return default(ulong);
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xC95D80", Offset = "0xC95D80", VA = "0xC95D80")]
	public void ValidateTextures(ovrAvatarPBSMaterialState[] materialStates)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xC956E4", Offset = "0xC956E4", VA = "0xC956E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52E8FC", Offset = "0x52E8FC")]
	private IEnumerator RunLoadingAnimation(Action callBack)
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xC96BF0", Offset = "0xC96BF0", VA = "0xC96BF0")]
	public OvrAvatarMaterialManager()
	{
	}
}
[Token(Token = "0x200003A")]
public class OvrAvatarPacket
{
	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr ovrNativePacket;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<float> frameTimes;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<OvrAvatarDriver.PoseFrame> frames;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<byte[]> encodedAudioPackets;

	[Token(Token = "0x17000007")]
	public float Duration
	{
		[Token(Token = "0x6000188")]
		[Address(RVA = "0xC8DDF8", Offset = "0xC8DDF8", VA = "0xC8DDF8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000008")]
	public OvrAvatarDriver.PoseFrame FinalFrame
	{
		[Token(Token = "0x6000189")]
		[Address(RVA = "0xC8DF44", Offset = "0xC8DF44", VA = "0xC8DF44")]
		get
		{
			return default(OvrAvatarDriver.PoseFrame);
		}
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xC8DFD4", Offset = "0xC8DFD4", VA = "0xC8DFD4")]
	public OvrAvatarPacket()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xC8DC44", Offset = "0xC8DC44", VA = "0xC8DC44")]
	public OvrAvatarPacket(OvrAvatarDriver.PoseFrame initialPose)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xC971A8", Offset = "0xC971A8", VA = "0xC971A8")]
	private OvrAvatarPacket(List<float> frameTimes, List<OvrAvatarDriver.PoseFrame> frames, List<byte[]> audioPackets)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xC8DE6C", Offset = "0xC8DE6C", VA = "0xC8DE6C")]
	public void AddFrame(OvrAvatarDriver.PoseFrame frame, float deltaSeconds)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xC972E0", Offset = "0xC972E0", VA = "0xC972E0")]
	public OvrAvatarDriver.PoseFrame GetPoseFrame(float seconds)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xC97510", Offset = "0xC97510", VA = "0xC97510")]
	public static OvrAvatarPacket Read(Stream stream)
	{
		return null;
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xC977D8", Offset = "0xC977D8", VA = "0xC977D8")]
	public void Write(Stream stream)
	{
	}
}
[Token(Token = "0x200003B")]
internal static class BinaryWriterExtensions
{
	[Token(Token = "0x6000191")]
	[Address(RVA = "0x9BD9A0", Offset = "0x9BD9A0", VA = "0x9BD9A0")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.PoseFrame frame)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x9BDAB4", Offset = "0x9BDAB4", VA = "0x9BDAB4")]
	public static void Write(this BinaryWriter writer, Vector3 vec3)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x9BDC60", Offset = "0x9BDC60", VA = "0x9BDC60")]
	public static void Write(this BinaryWriter writer, Vector2 vec2)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x9BDB24", Offset = "0x9BDB24", VA = "0x9BDB24")]
	public static void Write(this BinaryWriter writer, Quaternion quat)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x9BDBB8", Offset = "0x9BDBB8", VA = "0x9BDBB8")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.ControllerPose pose)
	{
	}
}
[Token(Token = "0x200003C")]
internal static class BinaryReaderExtensions
{
	[Token(Token = "0x6000196")]
	[Address(RVA = "0x9BD5A0", Offset = "0x9BD5A0", VA = "0x9BD5A0")]
	public static OvrAvatarDriver.PoseFrame ReadPoseFrame(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x9BD944", Offset = "0x9BD944", VA = "0x9BD944")]
	public static Vector2 ReadVector2(this BinaryReader reader)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x9BD740", Offset = "0x9BD740", VA = "0x9BD740")]
	public static Vector3 ReadVector3(this BinaryReader reader)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x9BD7B8", Offset = "0x9BD7B8", VA = "0x9BD7B8")]
	public static Quaternion ReadQuaternion(this BinaryReader reader)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x9BD854", Offset = "0x9BD854", VA = "0x9BD854")]
	public static OvrAvatarDriver.ControllerPose ReadControllerPose(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.ControllerPose);
	}
}
[Token(Token = "0x200003D")]
public class OvrAvatarRemoteDriver : OvrAvatarDriver
{
	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Queue<OvrAvatarPacket> packetQueue;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private IntPtr CurrentSDKPacket;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float CurrentPacketTime;

	[Token(Token = "0x40001DC")]
	private const int MinPacketQueue = 1;

	[Token(Token = "0x40001DD")]
	private const int MaxPacketQueue = 4;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int CurrentSequence;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isStreaming;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private OvrAvatarPacket currentPacket;

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xC97A00", Offset = "0xC97A00", VA = "0xC97A00")]
	public void QueuePacket(int sequence, OvrAvatarPacket packet)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xC97A88", Offset = "0xC97A88", VA = "0xC97A88", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xC97AA4", Offset = "0xC97AA4", VA = "0xC97AA4")]
	private void UpdateFromSDKPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xC97C48", Offset = "0xC97C48", VA = "0xC97C48")]
	private void UpdateFromUnityPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xC97DE8", Offset = "0xC97DE8", VA = "0xC97DE8")]
	public OvrAvatarRemoteDriver()
	{
	}
}
[Token(Token = "0x200003E")]
public class OvrAvatarRenderComponent : MonoBehaviour
{
	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool firstSkinnedUpdate;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SkinnedMeshRenderer mesh;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] bones;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isBodyComponent;

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xC97E84", Offset = "0xC97E84", VA = "0xC97E84")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xC97F70", Offset = "0xC97F70", VA = "0xC97F70")]
	protected SkinnedMeshRenderer CreateSkinnedMesh(ulong assetID, ovrAvatarVisibilityFlags visibilityMask, int thirdPersonLayer, int firstPersonLayer)
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xC9815C", Offset = "0xC9815C", VA = "0xC9815C")]
	protected void UpdateSkinnedMesh(OvrAvatar avatar, Transform[] bones, ovrAvatarTransform localTransform, ovrAvatarVisibilityFlags visibilityMask, IntPtr renderPart)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xC98508", Offset = "0xC98508", VA = "0xC98508")]
	protected Material CreateAvatarMaterial(string name, Shader shader)
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xC98614", Offset = "0xC98614", VA = "0xC98614")]
	public OvrAvatarRenderComponent()
	{
	}
}
[Token(Token = "0x200003F")]
[Flags]
public enum ovrAvatarCapabilities
{
	[Token(Token = "0x40001E6")]
	Body = 1,
	[Token(Token = "0x40001E7")]
	Hands = 2,
	[Token(Token = "0x40001E8")]
	Base = 4,
	[Token(Token = "0x40001E9")]
	BodyTilt = 0x10,
	[Token(Token = "0x40001EA")]
	Expressive = 0x20,
	[Token(Token = "0x40001EB")]
	All = -1
}
[Token(Token = "0x2000040")]
public enum ovrAvatarMessageType
{
	[Token(Token = "0x40001ED")]
	AvatarSpecification,
	[Token(Token = "0x40001EE")]
	AssetLoaded,
	[Token(Token = "0x40001EF")]
	Count
}
[Token(Token = "0x2000041")]
public struct ovrAvatarMessage_AvatarSpecification
{
	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public IntPtr avatarSpec;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ulong oculusUserID;
}
[Token(Token = "0x2000042")]
public struct ovrAvatarMessage_AssetLoaded
{
	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ulong assetID;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr asset;
}
[Token(Token = "0x2000043")]
public enum ovrAvatarAssetType
{
	[Token(Token = "0x40001F5")]
	Mesh,
	[Token(Token = "0x40001F6")]
	Texture,
	[Token(Token = "0x40001F7")]
	Pose,
	[Token(Token = "0x40001F8")]
	Material,
	[Token(Token = "0x40001F9")]
	CombinedMesh,
	[Token(Token = "0x40001FA")]
	PBSMaterial,
	[Token(Token = "0x40001FB")]
	FailedLoad,
	[Token(Token = "0x40001FC")]
	Count
}
[Token(Token = "0x2000044")]
public struct ovrAvatarMeshVertex
{
	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public byte[] blendIndices;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float[] blendWeights;
}
[Token(Token = "0x2000045")]
public struct ovrAvatarMeshVertexV2
{
	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float r;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float g;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float b;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float a;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public byte[] blendIndices;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float[] blendWeights;
}
[Token(Token = "0x2000046")]
public struct ovrAvatarBlendVertex
{
	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;
}
[Token(Token = "0x2000047")]
public struct ovrAvatarMeshAssetData
{
	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x2000048")]
public struct ovrAvatarMeshAssetDataV2
{
	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x2000049")]
public enum ovrAvatarTextureFormat
{
	[Token(Token = "0x4000231")]
	RGB24,
	[Token(Token = "0x4000232")]
	DXT1,
	[Token(Token = "0x4000233")]
	DXT5,
	[Token(Token = "0x4000234")]
	ASTC_RGB_6x6,
	[Token(Token = "0x4000235")]
	ASTC_RGB_6x6_MIPMAPS,
	[Token(Token = "0x4000236")]
	Count
}
[Token(Token = "0x200004A")]
public struct ovrAvatarTextureAssetData
{
	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTextureFormat format;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint sizeX;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public uint sizeY;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public uint mipCount;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong textureDataSize;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr textureData;
}
[Token(Token = "0x200004B")]
public enum ovrAvatarRenderPartType
{
	[Token(Token = "0x400023E")]
	SkinnedMeshRender,
	[Token(Token = "0x400023F")]
	SkinnedMeshRenderPBS,
	[Token(Token = "0x4000240")]
	ProjectorRender,
	[Token(Token = "0x4000241")]
	SkinnedMeshRenderPBS_V2,
	[Token(Token = "0x4000242")]
	Count
}
[Token(Token = "0x200004C")]
public enum ovrAvatarLogLevel
{
	[Token(Token = "0x4000244")]
	Unknown,
	[Token(Token = "0x4000245")]
	Default,
	[Token(Token = "0x4000246")]
	Verbose,
	[Token(Token = "0x4000247")]
	Debug,
	[Token(Token = "0x4000248")]
	Info,
	[Token(Token = "0x4000249")]
	Warn,
	[Token(Token = "0x400024A")]
	Error,
	[Token(Token = "0x400024B")]
	Fatal,
	[Token(Token = "0x400024C")]
	Silent
}
[Token(Token = "0x200004D")]
public struct ovrAvatarTransform
{
	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 position;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Quaternion orientation;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 scale;
}
[Token(Token = "0x200004E")]
[Flags]
public enum ovrAvatarButton
{
	[Token(Token = "0x4000251")]
	One = 1,
	[Token(Token = "0x4000252")]
	Two = 2,
	[Token(Token = "0x4000253")]
	Three = 4,
	[Token(Token = "0x4000254")]
	Joystick = 8
}
[Token(Token = "0x200004F")]
[Flags]
public enum ovrAvatarTouch
{
	[Token(Token = "0x4000256")]
	One = 1,
	[Token(Token = "0x4000257")]
	Two = 2,
	[Token(Token = "0x4000258")]
	Joystick = 4,
	[Token(Token = "0x4000259")]
	ThumbRest = 8,
	[Token(Token = "0x400025A")]
	Index = 0x10,
	[Token(Token = "0x400025B")]
	Pointing = 0x40,
	[Token(Token = "0x400025C")]
	ThumbUp = 0x80
}
[Token(Token = "0x2000050")]
public struct ovrAvatarHandInputState
{
	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarButton buttonMask;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public ovrAvatarTouch touchMask;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float joystickX;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float joystickY;

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float indexTrigger;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float handTrigger;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isActive;
}
[Token(Token = "0x2000051")]
public struct ovrAvatarComponent
{
	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint renderPartCount;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr renderParts;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string name;
}
[Token(Token = "0x2000052")]
internal struct ovrAvatarComponent_Offsets
{
	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long transform;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int renderPartCount;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int renderParts;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int name;
}
[Token(Token = "0x2000053")]
public struct ovrAvatarBaseComponent
{
	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 basePosition;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000054")]
public struct ovrAvatarBodyComponent
{
	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform leftEyeTransform;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarTransform rightEyeTransform;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ovrAvatarTransform centerEyeTransform;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000055")]
public struct ovrAvatarBodyComponent_Offsets
{
	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long leftEyeTransform;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long rightEyeTransform;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long centerEyeTransform;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long renderComponent;
}
[Token(Token = "0x2000056")]
public struct ovrAvatarControllerComponent
{
	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000057")]
public struct ovrAvatarHandComponent
{
	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000058")]
public enum ovrAvatarMaterialLayerBlendMode
{
	[Token(Token = "0x400027C")]
	Add,
	[Token(Token = "0x400027D")]
	Multiply,
	[Token(Token = "0x400027E")]
	Count
}
[Token(Token = "0x2000059")]
public enum ovrAvatarMaterialLayerSampleMode
{
	[Token(Token = "0x4000280")]
	Color,
	[Token(Token = "0x4000281")]
	Texture,
	[Token(Token = "0x4000282")]
	TextureSingleChannel,
	[Token(Token = "0x4000283")]
	Parallax,
	[Token(Token = "0x4000284")]
	Count
}
[Token(Token = "0x200005A")]
public enum ovrAvatarMaterialMaskType
{
	[Token(Token = "0x4000286")]
	None,
	[Token(Token = "0x4000287")]
	Positional,
	[Token(Token = "0x4000288")]
	ViewReflection,
	[Token(Token = "0x4000289")]
	Fresnel,
	[Token(Token = "0x400028A")]
	Pulse,
	[Token(Token = "0x400028B")]
	Count
}
[Token(Token = "0x200005B")]
public enum ovrAvatarControllerType
{
	[Token(Token = "0x400028D")]
	Touch,
	[Token(Token = "0x400028E")]
	Malibu,
	[Token(Token = "0x400028F")]
	Go,
	[Token(Token = "0x4000290")]
	Quest,
	[Token(Token = "0x4000291")]
	Count
}
[Token(Token = "0x200005C")]
public enum ovrAvatarAssetLevelOfDetail
{
	[Token(Token = "0x4000293")]
	Lowest = 1,
	[Token(Token = "0x4000294")]
	Medium = 3,
	[Token(Token = "0x4000295")]
	Highest = 5
}
[Token(Token = "0x200005D")]
public enum ovrAvatarLookAndFeelVersion
{
	[Token(Token = "0x4000297")]
	Unknown = -1,
	[Token(Token = "0x4000298")]
	One,
	[Token(Token = "0x4000299")]
	Two
}
[Token(Token = "0x200005E")]
public struct ovrAvatarMaterialLayerState
{
	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarMaterialLayerBlendMode blendMode;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarMaterialMaskType maskType;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector4 layerColor;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector4 sampleParameters;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong sampleTexture;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector4 sampleScaleOffset;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector4 maskParameters;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 maskAxis;

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x85C5A4", Offset = "0x85C5A4", VA = "0x85C5A4")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x85C5D4", Offset = "0x85C5D4", VA = "0x85C5D4", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x85C7F0", Offset = "0x85C7F0", VA = "0x85C7F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x200005F")]
public struct ovrAvatarMaterialState
{
	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarMaterialMaskType baseMaskType;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector4 baseMaskParameters;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector4 baseMaskAxis;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong alphaMaskTextureID;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 alphaMaskScaleOffset;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong normalMapTextureID;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 normalMapScaleOffset;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong parallaxMapTextureID;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector4 parallaxMapScaleOffset;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ulong roughnessMapTextureID;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector4 roughnessMapScaleOffset;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public uint layerCount;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ovrAvatarMaterialLayerState[] layers;

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x85C8D4", Offset = "0x85C8D4", VA = "0x85C8D4")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x85C904", Offset = "0x85C904", VA = "0x85C904", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x85CCA0", Offset = "0x85CCA0", VA = "0x85CCA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000060")]
public struct ovrAvatarExpressiveParameters
{
	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 irisColor;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector4 scleraColor;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector4 lashColor;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector4 browColor;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 lipColor;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4 teethColor;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector4 gumColor;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float browLashIntensity;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float lipSmoothness;

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xAED2D0", Offset = "0xAED2D0", VA = "0xAED2D0")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xAED300", Offset = "0xAED300", VA = "0xAED300", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xAED590", Offset = "0xAED590", VA = "0xAED590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000061")]
public struct ovrAvatarPBSMaterialState
{
	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong albedoTextureID;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector4 albedoMultiplier;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ulong metallicnessTextureID;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float glossinessScale;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong normalTextureID;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong heightTextureID;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ulong occlusionTextureID;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong emissionTextureID;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 emissionMultiplier;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong detailMaskTextureID;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ulong detailAlbedoTextureID;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ulong detailNormalTextureID;

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x85CE08", Offset = "0x85CE08", VA = "0x85CE08")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x85CE38", Offset = "0x85CE38", VA = "0x85CE38", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x85D028", Offset = "0x85D028", VA = "0x85D028", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000062")]
public class OvrAvatarAssetMaterial : OvrAvatarAsset
{
	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarMaterialState material;

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xC9031C", Offset = "0xC9031C", VA = "0xC9031C")]
	public OvrAvatarAssetMaterial(ulong id, IntPtr mat)
	{
	}
}
[Token(Token = "0x2000063")]
public struct ovrAvatarSkinnedMeshPose
{
	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint jointCount;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarTransform[] jointTransform;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int[] jointParents;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr[] jointNames;
}
[Token(Token = "0x2000064")]
[Flags]
public enum ovrAvatarVisibilityFlags
{
	[Token(Token = "0x40002CE")]
	FirstPerson = 1,
	[Token(Token = "0x40002CF")]
	ThirdPerson = 2,
	[Token(Token = "0x40002D0")]
	SelfOccluding = 4
}
[Token(Token = "0x2000065")]
public struct ovrAvatarRenderPart_SkinnedMeshRender
{
	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarMaterialState materialState;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x2000066")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS
{
	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong albedoTextureAssetID;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong surfaceTextureAssetID;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x2000067")]
public struct ovrAvatarRenderPart_ProjectorRender
{
	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint componentIndex;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public uint renderPartIndex;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ovrAvatarMaterialState materialState;
}
[Token(Token = "0x2000068")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2
{
	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarPBSMaterialState materialState;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x2000069")]
public enum ovrAvatarHandGesture
{
	[Token(Token = "0x40002E6")]
	Default,
	[Token(Token = "0x40002E7")]
	GripSphere,
	[Token(Token = "0x40002E8")]
	GripCube,
	[Token(Token = "0x40002E9")]
	Count
}
[Token(Token = "0x200006A")]
public enum ovrAvatarBodyPartType
{
	[Token(Token = "0x40002EB")]
	Body,
	[Token(Token = "0x40002EC")]
	Clothing,
	[Token(Token = "0x40002ED")]
	Eyewear,
	[Token(Token = "0x40002EE")]
	Hair,
	[Token(Token = "0x40002EF")]
	Beard,
	[Token(Token = "0x40002F0")]
	Count
}
[Token(Token = "0x200006B")]
public struct ovrAvatarBlendShapeParams
{
	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint blendShapeParamCount;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] blendShapeParams;
}
[Token(Token = "0x200006C")]
internal struct ovrAvatarBlendShapeParams_Offsets
{
	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int blendShapeParamCount;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long blendShapeParams;
}
[Token(Token = "0x200006D")]
public struct ovrAvatarVisemes
{
	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint visemeParamCount;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] visemeParams;
}
[Token(Token = "0x200006E")]
internal struct ovrAvatarVisemes_Offsets
{
	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int visemeParamCount;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long visemeParams;
}
[Token(Token = "0x200006F")]
public enum ovrAvatarGazeTargetType
{
	[Token(Token = "0x40002FA")]
	AvatarHead,
	[Token(Token = "0x40002FB")]
	AvatarHand,
	[Token(Token = "0x40002FC")]
	Object,
	[Token(Token = "0x40002FD")]
	ObjectStatic,
	[Token(Token = "0x40002FE")]
	Count
}
[Token(Token = "0x2000070")]
public struct ovrAvatarGazeTarget
{
	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Vector3 worldPosition;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarGazeTargetType type;
}
[Token(Token = "0x2000071")]
internal struct ovrAvatarGazeTarget_Offsets
{
	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int id;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int worldPosition;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int type;
}
[Token(Token = "0x2000072")]
public struct ovrAvatarGazeTargets
{
	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint targetCount;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarGazeTarget[] targets;
}
[Token(Token = "0x2000073")]
internal struct ovrAvatarGazeTargets_Offsets
{
	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int targetCount;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long targets;
}
[Token(Token = "0x2000074")]
public enum ovrAvatarLightType
{
	[Token(Token = "0x400030A")]
	Point,
	[Token(Token = "0x400030B")]
	Direction,
	[Token(Token = "0x400030C")]
	Spot,
	[Token(Token = "0x400030D")]
	Count
}
[Token(Token = "0x2000075")]
public struct ovrAvatarLight
{
	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarLightType type;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float intensity;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 worldDirection;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 worldPosition;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float spotAngleDeg;
}
[Token(Token = "0x2000076")]
internal struct ovrAvatarLight_Offsets
{
	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long id;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long type;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long intensity;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long worldDirection;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static long worldPosition;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static long range;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static long spotAngleDeg;
}
[Token(Token = "0x2000077")]
public struct ovrAvatarLights
{
	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float ambientIntensity;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint lightCount;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarLight[] lights;
}
[Token(Token = "0x2000078")]
internal struct ovrAvatarLights_Offsets
{
	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long ambientIntensity;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long lightCount;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long lights;
}
[Token(Token = "0x2000079")]
[Flags]
public enum ovrAvatarDebugContext : uint
{
	[Token(Token = "0x4000323")]
	None = 0u,
	[Token(Token = "0x4000324")]
	GazeTarget = 1u,
	[Token(Token = "0x4000325")]
	Any = uint.MaxValue
}
[Token(Token = "0x200007A")]
public struct ovrAvatarDebugLine
{
	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 startPoint;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 endPoint;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 color;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public IntPtr text;
}
[Token(Token = "0x200007B")]
public struct ovrAvatarDebugTransform
{
	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr text;
}
[Token(Token = "0x200007C")]
public delegate void specificationCallback(IntPtr specification);
[Token(Token = "0x200007D")]
public delegate void assetLoadedCallback(OvrAvatarAsset asset);
[Token(Token = "0x200007E")]
public delegate void combinedMeshLoadedCallback(IntPtr asset);
[Token(Token = "0x200007F")]
public class OvrAvatarSDKManager : MonoBehaviour
{
	[Token(Token = "0x2000177")]
	public struct AvatarSpecRequestParams
	{
		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong _userId;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public specificationCallback _callback;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool _useCombinedMesh;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ovrAvatarAssetLevelOfDetail _lod;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool _forceMobileTextureFormat;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ovrAvatarLookAndFeelVersion _lookVersion;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ovrAvatarLookAndFeelVersion _fallbackVersion;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool _enableExpressive;

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x864D40", Offset = "0x864D40", VA = "0x864D40")]
		public AvatarSpecRequestParams(ulong userId, specificationCallback callback, bool useCombinedMesh, ovrAvatarAssetLevelOfDetail lod, bool forceMobileTextureFormat, ovrAvatarLookAndFeelVersion lookVersion, ovrAvatarLookAndFeelVersion fallbackVersion, bool enableExpressive)
		{
		}
	}

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSDKManager _instance;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool initialized;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<ulong, HashSet<specificationCallback>> specificationCallbacks;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<ulong, HashSet<assetLoadedCallback>> assetLoadedCallbacks;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<IntPtr, combinedMeshLoadedCallback> combinedMeshLoadedCallbacks;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<ulong, OvrAvatarAsset> assetCache;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OvrAvatarTextureCopyManager textureCopyManager;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarLogLevel LoggingLevel;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Queue<AvatarSpecRequestParams> avatarSpecificationQueue;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> loadingAvatars;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool avatarSpecRequestAvailable;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float lastDispatchedAvatarSpecRequestTime;

	[Token(Token = "0x400033A")]
	private const float AVATAR_SPEC_REQUEST_TIMEOUT = 5f;

	[Token(Token = "0x17000009")]
	public static OvrAvatarSDKManager Instance
	{
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xC8C3A0", Offset = "0xC8C3A0", VA = "0xC8C3A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xC98624", Offset = "0xC98624", VA = "0xC98624")]
	private bool Initialize()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xC98928", Offset = "0xC98928", VA = "0xC98928")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xC98998", Offset = "0xC98998", VA = "0xC98998")]
	private void Update()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xC99358", Offset = "0xC99358", VA = "0xC99358")]
	public bool IsAvatarSpecWaiting()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xC993AC", Offset = "0xC993AC", VA = "0xC993AC")]
	public bool IsAvatarLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xC8CBE0", Offset = "0xC8CBE0", VA = "0xC8CBE0")]
	public void AddLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xC8D1E8", Offset = "0xC8D1E8", VA = "0xC8D1E8")]
	public void RemoveLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xC8CB50", Offset = "0xC8CB50", VA = "0xC8CB50")]
	public void RequestAvatarSpecification(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xC99154", Offset = "0xC99154", VA = "0xC99154")]
	private void DispatchAvatarSpecificationRequest(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xC8C5F0", Offset = "0xC8C5F0", VA = "0xC8C5F0")]
	public void BeginLoadingAsset(ulong assetId, ovrAvatarAssetLevelOfDetail lod, assetLoadedCallback callback)
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xC8C744", Offset = "0xC8C744", VA = "0xC8C744")]
	public void RegisterCombinedMeshCallback(IntPtr sdkAvatar, combinedMeshLoadedCallback callback)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xC8C574", Offset = "0xC8C574", VA = "0xC8C574")]
	public OvrAvatarAsset GetAsset(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xC99400", Offset = "0xC99400", VA = "0xC99400")]
	public void DeleteAssetFromCache(ulong assetId)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xC988F8", Offset = "0xC988F8", VA = "0xC988F8")]
	public string GetAppId()
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xC957C0", Offset = "0xC957C0", VA = "0xC957C0")]
	public OvrAvatarTextureCopyManager GetTextureCopyManager()
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xC994A0", Offset = "0xC994A0", VA = "0xC994A0")]
	public OvrAvatarSDKManager()
	{
	}
}
[Token(Token = "0x2000080")]
public sealed class OvrAvatarSettings : ScriptableObject
{
	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSettings instance;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string ovrAppID;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string ovrGearAppID;

	[Token(Token = "0x1700000A")]
	public static string AppID
	{
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x963A54", Offset = "0x963A54", VA = "0x963A54")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x963BB4", Offset = "0x963BB4", VA = "0x963BB4")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public static string MobileAppID
	{
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x963BE0", Offset = "0x963BE0", VA = "0x963BE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x963C00", Offset = "0x963C00", VA = "0x963C00")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public static OvrAvatarSettings Instance
	{
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x963A74", Offset = "0x963A74", VA = "0x963A74")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x963C2C", Offset = "0x963C2C", VA = "0x963C2C")]
		set
		{
		}
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x963C84", Offset = "0x963C84", VA = "0x963C84")]
	public OvrAvatarSettings()
	{
	}
}
[Token(Token = "0x2000081")]
public class OvrAvatarSkinnedMeshRenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Shader surface;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader surfaceSelfOccluding;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool previouslyActive;

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x965798", Offset = "0x965798", VA = "0x965798")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender, Shader surface, Shader surfaceSelfOccluding, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x965A64", Offset = "0x965A64", VA = "0x965A64")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x9658F4", Offset = "0x9658F4", VA = "0x9658F4")]
	private void UpdateMeshMaterial(ovrAvatarVisibilityFlags visibilityMask, SkinnedMeshRenderer rootMesh)
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x965CA4", Offset = "0x965CA4", VA = "0x965CA4")]
	public OvrAvatarSkinnedMeshRenderComponent()
	{
	}
}
[Token(Token = "0x2000082")]
public class OvrAvatarSkinnedMeshRenderPBSComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isMaterialInitilized;

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x965CAC", Offset = "0x965CAC", VA = "0x965CAC")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS, Shader shader, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x965E04", Offset = "0x965E04", VA = "0x965E04")]
	internal void UpdateSkinnedMeshRenderPBS(OvrAvatar avatar, IntPtr renderPart, Material mat)
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x965FDC", Offset = "0x965FDC", VA = "0x965FDC")]
	public OvrAvatarSkinnedMeshRenderPBSComponent()
	{
	}
}
[Token(Token = "0x2000083")]
public class OvrAvatarSkinnedMeshPBSV2RenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private OvrAvatarMaterialManager avatarMaterialManager;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool previouslyActive;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool isCombinedMaterial;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private ovrAvatarExpressiveParameters ExpressiveParameters;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool EnableExpressive;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int blendShapeCount;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private ovrAvatarBlendShapeParams blendShapeParams;

	[Token(Token = "0x4000349")]
	private const string MAIN_MATERIAL_NAME = "main_material";

	[Token(Token = "0x400034A")]
	private const string EYE_MATERIAL_NAME = "eye_material";

	[Token(Token = "0x400034B")]
	private const string DEFAULT_MATERIAL_NAME = "_material";

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x963CE0", Offset = "0x963CE0", VA = "0x963CE0")]
	internal void Initialize(IntPtr renderPart, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRender, OvrAvatarMaterialManager materialManager, int thirdPersonLayer, int firstPersonLayer, bool combinedMesh, ovrAvatarAssetLevelOfDetail lod, bool assignExpressiveParams, OvrAvatar avatar, bool isControllerModel)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x964CBC", Offset = "0x964CBC", VA = "0x964CBC")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x964EF0", Offset = "0x964EF0", VA = "0x964EF0")]
	private void InitializeSingleComponentMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x9643F8", Offset = "0x9643F8", VA = "0x9643F8")]
	private void InitializeCombinedMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x9640EC", Offset = "0x9640EC", VA = "0x9640EC")]
	private void SetMaterialTransparent(Material mat)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x964268", Offset = "0x964268", VA = "0x964268")]
	private void SetMaterialOpaque(Material mat)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x965790", Offset = "0x965790", VA = "0x965790")]
	public OvrAvatarSkinnedMeshPBSV2RenderComponent()
	{
	}
}
[Token(Token = "0x2000084")]
public class OvrAvatarTextureCopyManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000178")]
	public struct FallbackTextureSet
	{
		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool Initialized;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D DiffuseRoughness;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D Normal;
	}

	[Token(Token = "0x2000179")]
	private struct CopyTextureParams
	{
		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture Src;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture Dst;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Mip;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int SrcSize;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int DstElement;

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x8653D0", Offset = "0x8653D0", VA = "0x8653D0")]
		public CopyTextureParams(Texture src, Texture dst, int mip, int srcSize, int dstElement)
		{
		}
	}

	[Token(Token = "0x200017A")]
	public struct TextureSet
	{
		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<ulong, bool> TextureIDSingleMeshPair;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool IsProcessed;

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x8653E0", Offset = "0x8653E0", VA = "0x8653E0")]
		public TextureSet(Dictionary<ulong, bool> textureIDSingleMeshPair, bool isProcessed)
		{
		}
	}

	[Token(Token = "0x200017B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B37C", Offset = "0x52B37C")]
	private sealed class <DeleteTextureSetCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextureSet textureSetToDelete;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OvrAvatarTextureCopyManager <>4__this;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int gameobjectID;

		[Token(Token = "0x170000A6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x865380", Offset = "0x865380", VA = "0x865380", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x8653C8", Offset = "0x8653C8", VA = "0x8653C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x864D6C", Offset = "0x864D6C", VA = "0x864D6C")]
		[DebuggerHidden]
		public <DeleteTextureSetCoroutine>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x864D98", Offset = "0x864D98", VA = "0x864D98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x864D9C", Offset = "0x864D9C", VA = "0x864D9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x865388", Offset = "0x865388", VA = "0x865388", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FallbackTextureSet[] FallbackTextureSets;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Queue<CopyTextureParams> texturesToCopy;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, TextureSet> textureSets;

	[Token(Token = "0x400034F")]
	private const int TEXTURES_TO_COPY_QUEUE_CAPACITY = 256;

	[Token(Token = "0x4000350")]
	private const int COPIES_PER_FRAME = 8;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_DIFFUSE_ROUGHNESS;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_NORMAL;

	[Token(Token = "0x4000353")]
	private const string PATH_HIGHEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_2048";

	[Token(Token = "0x4000354")]
	private const string PATH_MEDIUM_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_1024";

	[Token(Token = "0x4000355")]
	private const string PATH_LOWEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_256";

	[Token(Token = "0x4000356")]
	private const string PATH_HIGHEST_NORMAL = "FallbackTextures/fallback_normal_2048";

	[Token(Token = "0x4000357")]
	private const string PATH_MEDIUM_NORMAL = "FallbackTextures/fallback_normal_1024";

	[Token(Token = "0x4000358")]
	private const string PATH_LOWEST_NORMAL = "FallbackTextures/fallback_normal_256";

	[Token(Token = "0x4000359")]
	private const int GPU_TEXTURE_COPY_WAIT_TIME = 10;

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x9666FC", Offset = "0x9666FC", VA = "0x9666FC")]
	public OvrAvatarTextureCopyManager()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x966AE0", Offset = "0x966AE0", VA = "0x966AE0")]
	public void Update()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x966CE0", Offset = "0x966CE0", VA = "0x966CE0")]
	public int GetTextureCount()
	{
		return default(int);
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x966D2C", Offset = "0x966D2C", VA = "0x966D2C")]
	public void CopyTexture(Texture src, Texture dst, int mipLevel, int mipSize, int dstElement, bool useQueue = true)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x966C54", Offset = "0x966C54", VA = "0x966C54")]
	private void CopyTexture(CopyTextureParams copyTextureParams)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x966ED8", Offset = "0x966ED8", VA = "0x966ED8")]
	public void AddTextureIDToTextureSet(int gameobjectID, ulong textureID, bool isSingleMesh)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x9670D8", Offset = "0x9670D8", VA = "0x9670D8")]
	public void DeleteTextureSet(int gameobjectID)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x96717C", Offset = "0x96717C", VA = "0x96717C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52EA04", Offset = "0x52EA04")]
	private IEnumerator DeleteTextureSetCoroutine(TextureSet textureSetToDelete, int gameobjectID)
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x96720C", Offset = "0x96720C", VA = "0x96720C")]
	public void CheckFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x967258", Offset = "0x967258", VA = "0x967258")]
	private void InitFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}
}
[Token(Token = "0x2000085")]
public class OvrAvatarTouchController : OvrAvatarComponent
{
	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarControllerComponent component;

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x967390", Offset = "0x967390", VA = "0x967390")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x9674F8", Offset = "0x9674F8", VA = "0x9674F8")]
	public OvrAvatarTouchController()
	{
	}
}
[Token(Token = "0x2000086")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x200017C")]
	public delegate void OnClick();

	[Token(Token = "0x200017D")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x200017E")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x200017F")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x2000180")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B38C", Offset = "0x52B38C")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnClick handler;

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x85E5BC", Offset = "0x85E5BC", VA = "0x85E5BC")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x85E5C4", Offset = "0x85E5C4", VA = "0x85E5C4")]
		internal void <AddButton>b__0()
		{
		}
	}

	[Token(Token = "0x2000181")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B39C", Offset = "0x52B39C")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnSlider onValueChanged;

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x85E688", Offset = "0x85E688", VA = "0x85E688")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x85E690", Offset = "0x85E690", VA = "0x85E690")]
		internal void <AddSlider>b__0(float f)
		{
		}
	}

	[Token(Token = "0x2000182")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B3AC", Offset = "0x52B3AC")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x85E770", Offset = "0x85E770", VA = "0x85E770")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x85E778", Offset = "0x85E778", VA = "0x85E778")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x2000183")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B3BC", Offset = "0x52B3BC")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x85E998", Offset = "0x85E998", VA = "0x85E998")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x85E9A0", Offset = "0x85E9A0", VA = "0x85E9A0")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x2000184")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B3CC", Offset = "0x52B3CC")]
	private sealed class <>c__DisplayClass42_0
	{
		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange handler;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle tb;

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x85E9C4", Offset = "0x85E9C4", VA = "0x85E9C4")]
		public <>c__DisplayClass42_0()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x85E9CC", Offset = "0x85E9CC", VA = "0x85E9CC")]
		internal void <AddRadio>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x400035C")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x400035D")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x400035E")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool[] reEnable;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x400036C")]
	private const float elementSpacing = 16f;

	[Token(Token = "0x400036D")]
	private const float marginH = 16f;

	[Token(Token = "0x400036E")]
	private const float marginV = 16f;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector2[] insertPositions;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 menuOffset;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private OVRCameraRig rig;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private LaserPointer lp;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private LineRenderer lr;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x953FB8", Offset = "0x953FB8", VA = "0x953FB8")]
	public void Awake()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x954474", Offset = "0x954474", VA = "0x954474")]
	public void Show()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x954A2C", Offset = "0x954A2C", VA = "0x954A2C")]
	public void Hide()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x95481C", Offset = "0x95481C", VA = "0x95481C")]
	private void Relayout()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x954BE8", Offset = "0x954BE8", VA = "0x954BE8")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x954EBC", Offset = "0x954EBC", VA = "0x954EBC")]
	public RectTransform AddButton(string label, OnClick handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x95514C", Offset = "0x95514C", VA = "0x95514C")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x955258", Offset = "0x955258", VA = "0x955258")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x955438", Offset = "0x955438", VA = "0x955438")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x9554DC", Offset = "0x9554DC", VA = "0x9554DC")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x9556AC", Offset = "0x9556AC", VA = "0x9556AC")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x95589C", Offset = "0x95589C", VA = "0x95589C")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x955B8C", Offset = "0x955B8C", VA = "0x955B8C")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x955C90", Offset = "0x955C90", VA = "0x955C90")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x955D30", Offset = "0x955D30", VA = "0x955D30")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x2000087")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x95DA38", Offset = "0x95DA38", VA = "0x95DA38")]
	private void Start()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x95DADC", Offset = "0x95DADC", VA = "0x95DADC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x95DB94", Offset = "0x95DB94", VA = "0x95DB94")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x95DBD0", Offset = "0x95DBD0", VA = "0x95DBD0")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x2000088")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x2000185")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x400093E")]
		On,
		[Token(Token = "0x400093F")]
		Off,
		[Token(Token = "0x4000940")]
		OnWhenHitTarget
	}

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x1700000D")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x600020C")]
		[Address(RVA = "0xC087D4", Offset = "0xC087D4", VA = "0xC087D4")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x600020B")]
		[Address(RVA = "0xC08790", Offset = "0xC08790", VA = "0xC08790")]
		set
		{
		}
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xC087DC", Offset = "0xC087DC", VA = "0xC087DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xC08838", Offset = "0xC08838", VA = "0xC08838")]
	private void Start()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xC08984", Offset = "0xC08984", VA = "0xC08984", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xC089A0", Offset = "0xC089A0", VA = "0xC089A0", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xC089F4", Offset = "0xC089F4", VA = "0xC089F4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xC08BA8", Offset = "0xC08BA8", VA = "0xC08BA8")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xC08CBC", Offset = "0xC08CBC", VA = "0xC08CBC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xC08D58", Offset = "0xC08D58", VA = "0xC08D58")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xC08E30", Offset = "0xC08E30", VA = "0xC08E30")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xC08EE4", Offset = "0xC08EE4", VA = "0xC08EE4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xC08FD8", Offset = "0xC08FD8", VA = "0xC08FD8")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x2000089")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x4000382")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x4000383")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x4000384")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BB8C", Offset = "0x52BB8C")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BBC4", Offset = "0x52BBC4")]
	public LayerMask CollideLayers;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BBFC", Offset = "0x52BBFC")]
	public float HeightOffset;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BC34", Offset = "0x52BC34")]
	public float MinimumHeight;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BC6C", Offset = "0x52BC6C")]
	public float MaximumHeight;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x9C8384", Offset = "0x9C8384", VA = "0x9C8384")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x9C838C", Offset = "0x9C838C", VA = "0x9C838C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x9C840C", Offset = "0x9C840C", VA = "0x9C840C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x9C84A0", Offset = "0x9C84A0", VA = "0x9C84A0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x9C8534", Offset = "0x9C8534", VA = "0x9C8534")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x9C885C", Offset = "0x9C885C", VA = "0x9C885C")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x9C8A88", Offset = "0x9C8A88", VA = "0x9C8A88")]
	private bool CheckCameraNearClipping([Out] float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x200008A")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xC09638", Offset = "0xC09638", VA = "0xC09638")]
	private void Start()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xC096EC", Offset = "0xC096EC", VA = "0xC096EC")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x200008B")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x2000186")]
	public enum States
	{
		[Token(Token = "0x4000942")]
		Ready,
		[Token(Token = "0x4000943")]
		Aim,
		[Token(Token = "0x4000944")]
		CancelAim,
		[Token(Token = "0x4000945")]
		PreTeleport,
		[Token(Token = "0x4000946")]
		CancelTeleport,
		[Token(Token = "0x4000947")]
		Teleporting,
		[Token(Token = "0x4000948")]
		PostTeleport
	}

	[Token(Token = "0x2000187")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x400094A")]
		None,
		[Token(Token = "0x400094B")]
		Aim,
		[Token(Token = "0x400094C")]
		PreTeleport,
		[Token(Token = "0x400094D")]
		Teleport
	}

	[Token(Token = "0x2000188")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x400094F")]
		Point,
		[Token(Token = "0x4000950")]
		Sphere,
		[Token(Token = "0x4000951")]
		Capsule
	}

	[Token(Token = "0x2000189")]
	public class AimData
	{
		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52E7B4", Offset = "0x52E7B4")]
		private List<Vector3> <Points>k__BackingField;

		[Token(Token = "0x170000A8")]
		public List<Vector3> Points
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0x8609B8", Offset = "0x8609B8", VA = "0x8609B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530D48", Offset = "0x530D48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000884")]
			[Address(RVA = "0x8609C0", Offset = "0x8609C0", VA = "0x8609C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530D58", Offset = "0x530D58")]
			private set
			{
			}
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x860934", Offset = "0x860934", VA = "0x860934")]
		public AimData()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x8609C8", Offset = "0x8609C8", VA = "0x8609C8")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200018A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B3DC", Offset = "0x52B3DC")]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x170000A9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x86078C", Offset = "0x86078C", VA = "0x86078C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x8607D4", Offset = "0x8607D4", VA = "0x8607D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x86066C", Offset = "0x86066C", VA = "0x86066C")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x860698", Offset = "0x860698", VA = "0x860698", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x86069C", Offset = "0x86069C", VA = "0x86069C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x860794", Offset = "0x860794", VA = "0x860794", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200018B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B3EC", Offset = "0x52B3EC")]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x170000AB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x860114", Offset = "0x860114", VA = "0x860114", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000891")]
			[Address(RVA = "0x86015C", Offset = "0x86015C", VA = "0x86015C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x85FFA4", Offset = "0x85FFA4", VA = "0x85FFA4")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x85FFD0", Offset = "0x85FFD0", VA = "0x85FFD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x85FFD4", Offset = "0x85FFD4", VA = "0x85FFD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x86011C", Offset = "0x86011C", VA = "0x86011C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200018C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B3FC", Offset = "0x52B3FC")]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x170000AD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x860234", Offset = "0x860234", VA = "0x860234", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x86027C", Offset = "0x86027C", VA = "0x86027C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x860164", Offset = "0x860164", VA = "0x860164")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x860190", Offset = "0x860190", VA = "0x860190", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x860194", Offset = "0x860194", VA = "0x860194", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x86023C", Offset = "0x86023C", VA = "0x86023C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200018D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B40C", Offset = "0x52B40C")]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x170000AF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x86061C", Offset = "0x86061C", VA = "0x86061C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x860664", Offset = "0x860664", VA = "0x860664", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x86050C", Offset = "0x86050C", VA = "0x86050C")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x860538", Offset = "0x860538", VA = "0x860538", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x86053C", Offset = "0x86053C", VA = "0x86053C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x860624", Offset = "0x860624", VA = "0x860624", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200018E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B41C", Offset = "0x52B41C")]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x170000B1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x860354", Offset = "0x860354", VA = "0x860354", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x86039C", Offset = "0x86039C", VA = "0x86039C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x860284", Offset = "0x860284", VA = "0x860284")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x8602B0", Offset = "0x8602B0", VA = "0x8602B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x8602B4", Offset = "0x8602B4", VA = "0x8602B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x86035C", Offset = "0x86035C", VA = "0x86035C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200018F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B42C", Offset = "0x52B42C")]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x170000B3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x8608E4", Offset = "0x8608E4", VA = "0x8608E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x86092C", Offset = "0x86092C", VA = "0x86092C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x8607DC", Offset = "0x8607DC", VA = "0x8607DC")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x860808", Offset = "0x860808", VA = "0x860808", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x86080C", Offset = "0x86080C", VA = "0x86080C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x8608EC", Offset = "0x8608EC", VA = "0x8608EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000190")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B43C", Offset = "0x52B43C")]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x170000B5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x8604BC", Offset = "0x8604BC", VA = "0x8604BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x860504", Offset = "0x860504", VA = "0x860504", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x8603A4", Offset = "0x8603A4", VA = "0x8603A4")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x8603D0", Offset = "0x8603D0", VA = "0x8603D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x8603D4", Offset = "0x8603D4", VA = "0x8603D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x8604C4", Offset = "0x8604C4", VA = "0x8604C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BCA4", Offset = "0x52BCA4")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BCDC", Offset = "0x52BCDC")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BD14", Offset = "0x52BD14")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BD4C", Offset = "0x52BD4C")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BD84", Offset = "0x52BD84")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BDBC", Offset = "0x52BDBC")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BDF4", Offset = "0x52BDF4")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BE2C", Offset = "0x52BE2C")]
	public bool EnableRotationDuringPostTeleport;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52BE64", Offset = "0x52BE64")]
	private States <CurrentState>k__BackingField;

	[NonSerialized]
	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BE74", Offset = "0x52BE74")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BEAC", Offset = "0x52BEAC")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52BEF4", Offset = "0x52BEF4")]
	private LocomotionController <LocomotionController>k__BackingField;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BF04", Offset = "0x52BF04")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BF3C", Offset = "0x52BF3C")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BF74", Offset = "0x52BF74")]
	public float AimCollisionRadius;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52BFAC", Offset = "0x52BFAC")]
	public float AimCollisionHeight;

	[Token(Token = "0x1700000E")]
	public States CurrentState
	{
		[Token(Token = "0x6000223")]
		[Address(RVA = "0xC0A1DC", Offset = "0xC0A1DC", VA = "0xC0A1DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EA6C", Offset = "0x52EA6C")]
		get
		{
			return default(States);
		}
		[Token(Token = "0x6000224")]
		[Address(RVA = "0xC0A1E4", Offset = "0xC0A1E4", VA = "0xC0A1E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EA7C", Offset = "0x52EA7C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x6000228")]
		[Address(RVA = "0xC0A3F8", Offset = "0xC0A3F8", VA = "0xC0A3F8")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x17000010")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x6000229")]
		[Address(RVA = "0xC0A420", Offset = "0xC0A420", VA = "0xC0A420")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EAAC", Offset = "0x52EAAC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600022A")]
		[Address(RVA = "0xC0A428", Offset = "0xC0A428", VA = "0xC0A428")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EABC", Offset = "0x52EABC")]
		private set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x6000225")]
		[Address(RVA = "0xC0A1EC", Offset = "0xC0A1EC", VA = "0xC0A1EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EA8C", Offset = "0x52EA8C")]
		add
		{
		}
		[Token(Token = "0x6000226")]
		[Address(RVA = "0xC0A28C", Offset = "0xC0A28C", VA = "0xC0A28C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EA9C", Offset = "0x52EA9C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x6000234")]
		[Address(RVA = "0xC0AA44", Offset = "0xC0AA44", VA = "0xC0AA44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EB04", Offset = "0x52EB04")]
		add
		{
		}
		[Token(Token = "0x6000235")]
		[Address(RVA = "0xC0AAE4", Offset = "0xC0AAE4", VA = "0xC0AAE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EB14", Offset = "0x52EB14")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x6000237")]
		[Address(RVA = "0xC0AB84", Offset = "0xC0AB84", VA = "0xC0AB84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EB8C", Offset = "0x52EB8C")]
		add
		{
		}
		[Token(Token = "0x6000238")]
		[Address(RVA = "0xC0AC24", Offset = "0xC0AC24", VA = "0xC0AC24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EB9C", Offset = "0x52EB9C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x6000239")]
		[Address(RVA = "0xC0ACC4", Offset = "0xC0ACC4", VA = "0xC0ACC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EBAC", Offset = "0x52EBAC")]
		add
		{
		}
		[Token(Token = "0x600023A")]
		[Address(RVA = "0xC0AD64", Offset = "0xC0AD64", VA = "0xC0AD64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EBBC", Offset = "0x52EBBC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x600023C")]
		[Address(RVA = "0xC0AE74", Offset = "0xC0AE74", VA = "0xC0AE74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EBCC", Offset = "0x52EBCC")]
		add
		{
		}
		[Token(Token = "0x600023D")]
		[Address(RVA = "0xC0AF14", Offset = "0xC0AF14", VA = "0xC0AF14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EBDC", Offset = "0x52EBDC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x600023F")]
		[Address(RVA = "0xC0B028", Offset = "0xC0B028", VA = "0xC0B028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EC54", Offset = "0x52EC54")]
		add
		{
		}
		[Token(Token = "0x6000240")]
		[Address(RVA = "0xC0B0C8", Offset = "0xC0B0C8", VA = "0xC0B0C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EC64", Offset = "0x52EC64")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x6000242")]
		[Address(RVA = "0xC0B1DC", Offset = "0xC0B1DC", VA = "0xC0B1DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52ECDC", Offset = "0x52ECDC")]
		add
		{
		}
		[Token(Token = "0x6000243")]
		[Address(RVA = "0xC0B27C", Offset = "0xC0B27C", VA = "0xC0B27C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52ECEC", Offset = "0x52ECEC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x6000245")]
		[Address(RVA = "0xC0B390", Offset = "0xC0B390", VA = "0xC0B390")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52ED64", Offset = "0x52ED64")]
		add
		{
		}
		[Token(Token = "0x6000246")]
		[Address(RVA = "0xC0B430", Offset = "0xC0B430", VA = "0xC0B430")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52ED74", Offset = "0x52ED74")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x6000248")]
		[Address(RVA = "0xC0B544", Offset = "0xC0B544", VA = "0xC0B544")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EDEC", Offset = "0x52EDEC")]
		add
		{
		}
		[Token(Token = "0x6000249")]
		[Address(RVA = "0xC0B5E4", Offset = "0xC0B5E4", VA = "0xC0B5E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EDFC", Offset = "0x52EDFC")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0xC0B6F8", Offset = "0xC0B6F8", VA = "0xC0B6F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EE74", Offset = "0x52EE74")]
		add
		{
		}
		[Token(Token = "0x600024C")]
		[Address(RVA = "0xC0B798", Offset = "0xC0B798", VA = "0xC0B798")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EE84", Offset = "0x52EE84")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x600024E")]
		[Address(RVA = "0xC0B8AC", Offset = "0xC0B8AC", VA = "0xC0B8AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EEFC", Offset = "0x52EEFC")]
		add
		{
		}
		[Token(Token = "0x600024F")]
		[Address(RVA = "0xC0B94C", Offset = "0xC0B94C", VA = "0xC0B94C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EF0C", Offset = "0x52EF0C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xC09E80", Offset = "0xC09E80", VA = "0xC09E80")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xC09EA4", Offset = "0xC09EA4", VA = "0xC09EA4")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xC0A32C", Offset = "0xC0A32C", VA = "0xC0A32C")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xC0A430", Offset = "0xC0A430", VA = "0xC0A430")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, [Out] RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xC0A67C", Offset = "0xC0A67C", VA = "0xC0A67C")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x52EACC", Offset = "0x52EACC")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xC0A738", Offset = "0xC0A738", VA = "0xC0A738")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xC0A810", Offset = "0xC0A810", VA = "0xC0A810")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xC0A830", Offset = "0xC0A830", VA = "0xC0A830")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xC0A8F4", Offset = "0xC0A8F4", VA = "0xC0A8F4")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xC0A938", Offset = "0xC0A938", VA = "0xC0A938")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xC0A998", Offset = "0xC0A998", VA = "0xC0A998", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xC0AA3C", Offset = "0xC0AA3C", VA = "0xC0AA3C", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xC0A9C8", Offset = "0xC0A9C8", VA = "0xC0A9C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52EB24", Offset = "0x52EB24")]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xC0AE04", Offset = "0xC0AE04", VA = "0xC0AE04")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xC0AFB4", Offset = "0xC0AFB4", VA = "0xC0AFB4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52EBEC", Offset = "0x52EBEC")]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xC0B168", Offset = "0xC0B168", VA = "0xC0B168")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52EC74", Offset = "0x52EC74")]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xC0B31C", Offset = "0xC0B31C", VA = "0xC0B31C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52ECFC", Offset = "0x52ECFC")]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xC0B4D0", Offset = "0xC0B4D0", VA = "0xC0B4D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52ED84", Offset = "0x52ED84")]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xC0B684", Offset = "0xC0B684", VA = "0xC0B684")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52EE0C", Offset = "0x52EE0C")]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xC0B838", Offset = "0xC0B838", VA = "0xC0B838")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52EE94", Offset = "0x52EE94")]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xC0B9EC", Offset = "0xC0B9EC", VA = "0xC0B9EC")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xC0BB2C", Offset = "0xC0BB2C", VA = "0xC0BB2C")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xC0BB60", Offset = "0xC0BB60", VA = "0xC0BB60")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xC0BC28", Offset = "0xC0BC28", VA = "0xC0BC28")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xC0BD20", Offset = "0xC0BD20", VA = "0xC0BD20")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x200008C")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000C")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x973E34", Offset = "0x973E34", VA = "0x973E34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EF1C", Offset = "0x52EF1C")]
		add
		{
		}
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x973ED4", Offset = "0x973ED4", VA = "0x973ED4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EF2C", Offset = "0x52EF2C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x973F74", Offset = "0x973F74", VA = "0x973F74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EF3C", Offset = "0x52EF3C")]
		add
		{
		}
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x974014", Offset = "0x974014", VA = "0x974014")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EF4C", Offset = "0x52EF4C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x9740B4", Offset = "0x9740B4", VA = "0x9740B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x974178", Offset = "0x974178", VA = "0x974178")]
	private void Start()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x97417C", Offset = "0x97417C", VA = "0x97417C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x9741F0", Offset = "0x9741F0", VA = "0x9741F0")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x974314", Offset = "0x974314", VA = "0x974314")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x9744FC", Offset = "0x9744FC", VA = "0x9744FC")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x974710", Offset = "0x974710", VA = "0x974710")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x200008D")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x6000260")]
	[Address(RVA = "0xAE0D64", Offset = "0xAE0D64", VA = "0xAE0D64", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xAE0DFC", Offset = "0xAE0DFC", VA = "0xAE0DFC", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000262")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xAE0EC8", Offset = "0xAE0EC8", VA = "0xAE0EC8")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x200008E")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C0A4", Offset = "0x52C0A4")]
	public float Range;

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xAE0ED8", Offset = "0xAE0ED8", VA = "0xAE0ED8", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xAE0FD4", Offset = "0xAE0FD4", VA = "0xAE0FD4")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x200008F")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C0DC", Offset = "0x52C0DC")]
	public float Range;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C114", Offset = "0x52C114")]
	public float MinimumElevation;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C14C", Offset = "0x52C14C")]
	public float Gravity;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C184", Offset = "0x52C184")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52C184", Offset = "0x52C184")]
	public float AimVelocity;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C1E0", Offset = "0x52C1E0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52C1E0", Offset = "0x52C1E0")]
	public float AimStep;

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xAE0FE4", Offset = "0xAE0FE4", VA = "0xAE0FE4", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xAE1174", Offset = "0xAE1174", VA = "0xAE1174")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x2000090")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C238", Offset = "0x52C238")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xAE1188", Offset = "0xAE1188", VA = "0xAE1188")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xAE12B4", Offset = "0xAE12B4", VA = "0xAE12B4")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xAE12E4", Offset = "0xAE12E4", VA = "0xAE12E4")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xAE1314", Offset = "0xAE1314", VA = "0xAE1314")]
	private void Awake()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xAE13C4", Offset = "0xAE13C4", VA = "0xAE13C4", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xAE1430", Offset = "0xAE1430", VA = "0xAE1430", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xAE1498", Offset = "0xAE1498", VA = "0xAE1498")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x2000091")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52C270", Offset = "0x52C270")]
	private bool <IsValidDestination>k__BackingField;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C280", Offset = "0x52C280")]
	public Transform PositionIndicator;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C2B8", Offset = "0x52C2B8")]
	public Transform OrientationIndicator;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C2F0", Offset = "0x52C2F0")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x17000011")]
	public bool IsValidDestination
	{
		[Token(Token = "0x600026F")]
		[Address(RVA = "0xAE15BC", Offset = "0xAE15BC", VA = "0xAE15BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EF5C", Offset = "0x52EF5C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000270")]
		[Address(RVA = "0xAE15C4", Offset = "0xAE15C4", VA = "0xAE15C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EF6C", Offset = "0x52EF6C")]
		private set
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x6000275")]
		[Address(RVA = "0xAE1780", Offset = "0xAE1780", VA = "0xAE1780")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EF7C", Offset = "0x52EF7C")]
		add
		{
		}
		[Token(Token = "0x6000276")]
		[Address(RVA = "0xAE1820", Offset = "0xAE1820", VA = "0xAE1820")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52EF8C", Offset = "0x52EF8C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xAE15D0", Offset = "0xAE15D0", VA = "0xAE15D0")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xAE1668", Offset = "0xAE1668", VA = "0xAE1668")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xAE173C", Offset = "0xAE173C", VA = "0xAE173C")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0xAE177C", Offset = "0xAE177C", VA = "0xAE177C")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0xAE18C0", Offset = "0xAE18C0", VA = "0xAE18C0")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xAE1924", Offset = "0xAE1924", VA = "0xAE1924")]
	public void Recycle()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xAE1948", Offset = "0xAE1948", VA = "0xAE1948", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x2000092")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x2000191")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B44C", Offset = "0x52B44C")]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x170000B7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x867E30", Offset = "0x867E30", VA = "0x867E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x867E78", Offset = "0x867E78", VA = "0x867E78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x867D74", Offset = "0x867D74", VA = "0x867D74")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x867DA0", Offset = "0x867DA0", VA = "0x867DA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x867DA4", Offset = "0x867DA4", VA = "0x867DA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x867E38", Offset = "0x867E38", VA = "0x867E38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000192")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B45C", Offset = "0x52B45C")]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x170000B9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x867D24", Offset = "0x867D24", VA = "0x867D24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x867D6C", Offset = "0x867D6C", VA = "0x867D6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x867C64", Offset = "0x867C64", VA = "0x867C64")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x867C90", Offset = "0x867C90", VA = "0x867C90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x867C94", Offset = "0x867C94", VA = "0x867C94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x867D2C", Offset = "0x867D2C", VA = "0x867D2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x600027A")]
	[Address(RVA = "0xAE1B54", Offset = "0xAE1B54", VA = "0xAE1B54")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xAE1C1C", Offset = "0xAE1C1C", VA = "0xAE1C1C", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xAE1C74", Offset = "0xAE1C74", VA = "0xAE1C74", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xAE1D2C", Offset = "0xAE1D2C", VA = "0xAE1D2C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52EF9C", Offset = "0x52EF9C")]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xAE1DA0", Offset = "0xAE1DA0", VA = "0xAE1DA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F004", Offset = "0x52F004")]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600027F")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x6000280")]
	public abstract void GetAimData([Out] Ray aimRay);

	[Token(Token = "0x6000281")]
	[Address(RVA = "0xAE1E14", Offset = "0xAE1E14", VA = "0xAE1E14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F06C", Offset = "0x52F06C")]
	private void <.ctor>b__2_0()
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0xAE1E40", Offset = "0xAE1E40", VA = "0xAE1E40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F07C", Offset = "0x52F07C")]
	private void <.ctor>b__2_1()
	{
	}
}
[Token(Token = "0x2000093")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52C338", Offset = "0x52C338")]
	private Transform <Pointer>k__BackingField;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C348", Offset = "0x52C348")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C380", Offset = "0x52C380")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C3B8", Offset = "0x52C3B8")]
	public bool FastTeleport;

	[Token(Token = "0x17000012")]
	public Transform Pointer
	{
		[Token(Token = "0x6000283")]
		[Address(RVA = "0xAE1E6C", Offset = "0xAE1E6C", VA = "0xAE1E6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F08C", Offset = "0x52F08C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000284")]
		[Address(RVA = "0xAE1E74", Offset = "0xAE1E74", VA = "0xAE1E74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F09C", Offset = "0x52F09C")]
		private set
		{
		}
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0xAE1E7C", Offset = "0xAE1E7C", VA = "0xAE1E7C", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0xAE1FCC", Offset = "0xAE1FCC", VA = "0xAE1FCC", Slot = "9")]
	public override void GetAimData([Out] Ray aimRay)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xAE2084", Offset = "0xAE2084", VA = "0xAE2084")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x2000094")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x2000193")]
	public enum InputModes
	{
		[Token(Token = "0x4000973")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x4000974")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x4000975")]
		ThumbstickTeleport,
		[Token(Token = "0x4000976")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x2000194")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x4000978")]
		A,
		[Token(Token = "0x4000979")]
		B,
		[Token(Token = "0x400097A")]
		LeftTrigger,
		[Token(Token = "0x400097B")]
		LeftThumbstick,
		[Token(Token = "0x400097C")]
		RightTrigger,
		[Token(Token = "0x400097D")]
		RightThumbstick,
		[Token(Token = "0x400097E")]
		X,
		[Token(Token = "0x400097F")]
		Y
	}

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C3F0", Offset = "0x52C3F0")]
	public InputModes InputMode;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C428", Offset = "0x52C428")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C460", Offset = "0x52C460")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C498", Offset = "0x52C498")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xAE2088", Offset = "0xAE2088", VA = "0xAE2088")]
	private void Start()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xAE208C", Offset = "0xAE208C", VA = "0xAE208C", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xAE245C", Offset = "0xAE245C", VA = "0xAE245C", Slot = "9")]
	public override void GetAimData([Out] Ray aimRay)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xAE251C", Offset = "0xAE251C", VA = "0xAE251C")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x2000095")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x2000195")]
	public enum OrientationModes
	{
		[Token(Token = "0x4000981")]
		HeadRelative,
		[Token(Token = "0x4000982")]
		ForwardFacing
	}

	[Token(Token = "0x2000196")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B46C", Offset = "0x52B46C")]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x170000BB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x867F54", Offset = "0x867F54", VA = "0x867F54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x867F9C", Offset = "0x867F9C", VA = "0x867F9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x867E80", Offset = "0x867E80", VA = "0x867E80")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x867EAC", Offset = "0x867EAC", VA = "0x867EAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x867EB0", Offset = "0x867EB0", VA = "0x867EB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x867F5C", Offset = "0x867F5C", VA = "0x867F5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xAE25F8", Offset = "0xAE25F8", VA = "0xAE25F8")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xAE26F0", Offset = "0xAE26F0", VA = "0xAE26F0")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xAE26F8", Offset = "0xAE26F8", VA = "0xAE26F8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0xAE2744", Offset = "0xAE2744", VA = "0xAE2744", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xAE278C", Offset = "0xAE278C", VA = "0xAE278C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F0AC", Offset = "0x52F0AC")]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000291")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x6000292")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x6000293")]
	[Address(RVA = "0xAE2800", Offset = "0xAE2800", VA = "0xAE2800")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xAE28BC", Offset = "0xAE28BC", VA = "0xAE28BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F114", Offset = "0x52F114")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x2000096")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x6000295")]
	[Address(RVA = "0xAE28E8", Offset = "0xAE28E8", VA = "0xAE28E8", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xAE28EC", Offset = "0xAE28EC", VA = "0xAE28EC", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xAE2968", Offset = "0xAE2968", VA = "0xAE2968")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x2000097")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C4D0", Offset = "0x52C4D0")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C508", Offset = "0x52C508")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C540", Offset = "0x52C540")]
	public float AimDistanceThreshold;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C578", Offset = "0x52C578")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xAE296C", Offset = "0xAE296C", VA = "0xAE296C", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xAE2998", Offset = "0xAE2998", VA = "0xAE2998", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xAE2D40", Offset = "0xAE2D40", VA = "0xAE2D40")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x2000098")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C5B0", Offset = "0x52C5B0")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C5E8", Offset = "0x52C5E8")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C620", Offset = "0x52C620")]
	public float RotateStickThreshold;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xAE2D44", Offset = "0xAE2D44", VA = "0xAE2D44", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0xAE2D88", Offset = "0xAE2D88", VA = "0xAE2D88", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xAE3128", Offset = "0xAE3128", VA = "0xAE3128")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x2000099")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x600029E")]
	[Address(RVA = "0xAE3138", Offset = "0xAE3138", VA = "0xAE3138")]
	private void Start()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xAE313C", Offset = "0xAE313C", VA = "0xAE313C")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xAE3144", Offset = "0xAE3144", VA = "0xAE3144")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xAE3208", Offset = "0xAE3208", VA = "0xAE3208")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xAE3230", Offset = "0xAE3230", VA = "0xAE3230")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x200009A")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52C658", Offset = "0x52C658")]
	private LocomotionTeleport <LocomotionTeleport>k__BackingField;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x17000013")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xAE3248", Offset = "0xAE3248", VA = "0xAE3248")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F124", Offset = "0x52F124")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xAE3250", Offset = "0xAE3250", VA = "0xAE3250")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F134", Offset = "0x52F134")]
		private set
		{
		}
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xAE0D94", Offset = "0xAE0D94", VA = "0xAE0D94", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xAE0E9C", Offset = "0xAE0E9C", VA = "0xAE0E9C", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xAE3258", Offset = "0xAE3258", VA = "0xAE3258")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x52F144", Offset = "0x52F144")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xAE1424", Offset = "0xAE1424", VA = "0xAE1424", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xAE1490", Offset = "0xAE1490", VA = "0xAE1490", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xAE0ED0", Offset = "0xAE0ED0", VA = "0xAE0ED0")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x200009B")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x2000197")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B47C", Offset = "0x52B47C")]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x170000BD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x868268", Offset = "0x868268", VA = "0x868268", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x8682B0", Offset = "0x8682B0", VA = "0x8682B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x867FA4", Offset = "0x867FA4", VA = "0x867FA4")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x867FD0", Offset = "0x867FD0", VA = "0x867FD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x867FD4", Offset = "0x867FD4", VA = "0x867FD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x868270", Offset = "0x868270", VA = "0x868270", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C668", Offset = "0x52C668")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x40003F9")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xAE3334", Offset = "0xAE3334", VA = "0xAE3334")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xAE343C", Offset = "0xAE343C", VA = "0xAE343C", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xAE346C", Offset = "0xAE346C", VA = "0xAE346C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xAE3498", Offset = "0xAE3498", VA = "0xAE3498")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F17C", Offset = "0x52F17C")]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xAE350C", Offset = "0xAE350C", VA = "0xAE350C", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x60002B0")]
	protected abstract bool ConsiderTeleport(Vector3 start, Vector3 end);

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xAE352C", Offset = "0xAE352C", VA = "0xAE352C", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xAE364C", Offset = "0xAE364C", VA = "0xAE364C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F1E4", Offset = "0x52F1E4")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x200009C")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xAE3678", Offset = "0xAE3678", VA = "0xAE3678")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xAE36DC", Offset = "0xAE36DC", VA = "0xAE36DC", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0xAE37D4", Offset = "0xAE37D4", VA = "0xAE37D4", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xAE38CC", Offset = "0xAE38CC", VA = "0xAE38CC")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x52F1F4", Offset = "0x52F1F4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xAE38D0", Offset = "0xAE38D0", VA = "0xAE38D0")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x200009D")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C6A0", Offset = "0x52C6A0")]
	public float LOSOffset;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C6D8", Offset = "0x52C6D8")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xAE38DC", Offset = "0xAE38DC", VA = "0xAE38DC", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xAE3AE8", Offset = "0xAE3AE8", VA = "0xAE3AE8")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x200009E")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xAE3AF4", Offset = "0xAE3AF4", VA = "0xAE3AF4", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xAE3BEC", Offset = "0xAE3BEC", VA = "0xAE3BEC")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x200009F")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xAE3BF0", Offset = "0xAE3BF0", VA = "0xAE3BF0", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xAE3C84", Offset = "0xAE3C84", VA = "0xAE3C84", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002BE")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xAE3D14", Offset = "0xAE3D14", VA = "0xAE3D14")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x20000A0")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x2000198")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B48C", Offset = "0x52B48C")]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x170000BF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x8683E4", Offset = "0x8683E4", VA = "0x8683E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x86842C", Offset = "0x86842C", VA = "0x86842C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x8682B8", Offset = "0x8682B8", VA = "0x8682B8")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x8682E4", Offset = "0x8682E4", VA = "0x8682E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x8682E8", Offset = "0x8682E8", VA = "0x8682E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x8683EC", Offset = "0x8683EC", VA = "0x8683EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C710", Offset = "0x52C710")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52C710", Offset = "0x52C710")]
	public float TransitionDuration;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C768", Offset = "0x52C768")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52C768", Offset = "0x52C768")]
	public float TeleportDelay;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C7BC", Offset = "0x52C7BC")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xAE3D1C", Offset = "0xAE3D1C", VA = "0xAE3D1C", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xAE3D48", Offset = "0xAE3D48", VA = "0xAE3D48")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F22C", Offset = "0x52F22C")]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xAE3DBC", Offset = "0xAE3DBC", VA = "0xAE3DBC")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x20000A1")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xAE3F5C", Offset = "0xAE3F5C", VA = "0xAE3F5C", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xAE3F7C", Offset = "0xAE3F7C", VA = "0xAE3F7C")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x20000A2")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x2000199")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B49C", Offset = "0x52B49C")]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x170000C1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x868584", Offset = "0x868584", VA = "0x868584", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x8685CC", Offset = "0x8685CC", VA = "0x8685CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x868434", Offset = "0x868434", VA = "0x868434")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x868460", Offset = "0x868460", VA = "0x868460", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x868464", Offset = "0x868464", VA = "0x868464", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x86858C", Offset = "0x86858C", VA = "0x86858C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C7F4", Offset = "0x52C7F4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52C7F4", Offset = "0x52C7F4")]
	public float TransitionDuration;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xAE3F84", Offset = "0xAE3F84", VA = "0xAE3F84", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xAE3FB0", Offset = "0xAE3FB0", VA = "0xAE3FB0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F294", Offset = "0x52F294")]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xAE4024", Offset = "0xAE4024", VA = "0xAE4024")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x20000A3")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x200019A")]
	public enum PlabackState
	{
		[Token(Token = "0x4000995")]
		Idle = 1,
		[Token(Token = "0x4000996")]
		Preparing,
		[Token(Token = "0x4000997")]
		Buffering,
		[Token(Token = "0x4000998")]
		Ready,
		[Token(Token = "0x4000999")]
		Ended
	}

	[Token(Token = "0x200019B")]
	public enum StereoMode
	{
		[Token(Token = "0x400099B")]
		Unknown = -1,
		[Token(Token = "0x400099C")]
		Mono,
		[Token(Token = "0x400099D")]
		TopBottom,
		[Token(Token = "0x400099E")]
		LeftRight,
		[Token(Token = "0x400099F")]
		Mesh
	}

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getCurrentPlaybackStateMethodId;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x17000014")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xC13984", Offset = "0xC13984", VA = "0xC13984")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000015")]
	private static IntPtr Activity
	{
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xC13CB4", Offset = "0xC13CB4", VA = "0xC13CB4")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000016")]
	public static bool IsAvailable
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xC10B8C", Offset = "0xC10B8C", VA = "0xC10B8C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000017")]
	public static bool IsPlaying
	{
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xC12304", Offset = "0xC12304", VA = "0xC12304")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000018")]
	public static PlabackState CurrentPlaybackState
	{
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xC13F84", Offset = "0xC13F84", VA = "0xC13F84")]
		get
		{
			return default(PlabackState);
		}
	}

	[Token(Token = "0x17000019")]
	public static long Duration
	{
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xC12538", Offset = "0xC12538", VA = "0xC12538")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700001A")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xC111C4", Offset = "0xC111C4", VA = "0xC111C4")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x1700001B")]
	public static int VideoWidth
	{
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xC10F8C", Offset = "0xC10F8C", VA = "0xC10F8C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001C")]
	public static int VideoHeight
	{
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xC110A8", Offset = "0xC110A8", VA = "0xC110A8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001D")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xC1241C", Offset = "0xC1241C", VA = "0xC1241C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xC11A50", Offset = "0xC11A50", VA = "0xC11A50")]
		set
		{
		}
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xC140A0", Offset = "0xC140A0", VA = "0xC140A0")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xC12910", Offset = "0xC12910", VA = "0xC12910")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xC1168C", Offset = "0xC1168C", VA = "0xC1168C")]
	public static void Play()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xC11834", Offset = "0xC11834", VA = "0xC11834")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xC12708", Offset = "0xC12708", VA = "0xC12708")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xC142C8", Offset = "0xC142C8", VA = "0xC142C8")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xC12114", Offset = "0xC12114", VA = "0xC12114")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x20000A4")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x1400000F")]
	public event Action onButtonDown
	{
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x9BF5D8", Offset = "0x9BF5D8", VA = "0x9BF5D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F2FC", Offset = "0x52F2FC")]
		add
		{
		}
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x9BF678", Offset = "0x9BF678", VA = "0x9BF678")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F30C", Offset = "0x52F30C")]
		remove
		{
		}
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x9BF718", Offset = "0x9BF718", VA = "0x9BF718", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x9BF72C", Offset = "0x9BF72C", VA = "0x9BF72C")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x20000A5")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x200019C")]
	public enum ButtonType
	{
		[Token(Token = "0x40009A1")]
		Play,
		[Token(Token = "0x40009A2")]
		Pause,
		[Token(Token = "0x40009A3")]
		FastForward,
		[Token(Token = "0x40009A4")]
		Rewind,
		[Token(Token = "0x40009A5")]
		SkipForward,
		[Token(Token = "0x40009A6")]
		SkipBack,
		[Token(Token = "0x40009A7")]
		Stop
	}

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x1700001E")]
	public ButtonType buttonType
	{
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xC0C184", Offset = "0xC0C184", VA = "0xC0C184")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xC0C18C", Offset = "0xC0C18C", VA = "0xC0C18C")]
		set
		{
		}
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xC0C1B0", Offset = "0xC0C1B0", VA = "0xC0C1B0", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xC0D64C", Offset = "0xC0D64C", VA = "0xC0D64C")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x20000A6")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x200019D")]
	public enum VideoShape
	{
		[Token(Token = "0x40009A9")]
		_360,
		[Token(Token = "0x40009AA")]
		_180,
		[Token(Token = "0x40009AB")]
		Quad
	}

	[Token(Token = "0x200019E")]
	public enum VideoStereo
	{
		[Token(Token = "0x40009AD")]
		Mono,
		[Token(Token = "0x40009AE")]
		TopBottom,
		[Token(Token = "0x40009AF")]
		LeftRight,
		[Token(Token = "0x40009B0")]
		BottomTop
	}

	[Token(Token = "0x200019F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B4AC", Offset = "0x52B4AC")]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x170000C3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x860D08", Offset = "0x860D08", VA = "0x860D08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x860D50", Offset = "0x860D50", VA = "0x860D50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x860B20", Offset = "0x860B20", VA = "0x860B20")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x860B4C", Offset = "0x860B4C", VA = "0x860B4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x860B50", Offset = "0x860B50", VA = "0x860B50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x860D10", Offset = "0x860D10", VA = "0x860D10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B4BC", Offset = "0x52B4BC")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string moviePath;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string drmLicencesUrl;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x860A28", Offset = "0x860A28", VA = "0x860A28")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x860A30", Offset = "0x860A30", VA = "0x860A30")]
		internal void <Play>b__0()
		{
		}
	}

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52C87C", Offset = "0x52C87C")]
	private bool <IsPlaying>k__BackingField;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52C88C", Offset = "0x52C88C")]
	private long <Duration>k__BackingField;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52C89C", Offset = "0x52C89C")]
	private long <PlaybackPosition>k__BackingField;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x1700001F")]
	public bool IsPlaying
	{
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xC108DC", Offset = "0xC108DC", VA = "0xC108DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F31C", Offset = "0x52F31C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xC108E4", Offset = "0xC108E4", VA = "0xC108E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F32C", Offset = "0x52F32C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public long Duration
	{
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xC108F0", Offset = "0xC108F0", VA = "0xC108F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F33C", Offset = "0x52F33C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xC108F8", Offset = "0xC108F8", VA = "0xC108F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F34C", Offset = "0x52F34C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public long PlaybackPosition
	{
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xC10900", Offset = "0xC10900", VA = "0xC10900")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F35C", Offset = "0x52F35C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xC10908", Offset = "0xC10908", VA = "0xC10908")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F36C", Offset = "0x52F36C")]
		private set
		{
		}
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xC10910", Offset = "0xC10910", VA = "0xC10910")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xC10BFC", Offset = "0xC10BFC", VA = "0xC10BFC")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xC10C60", Offset = "0xC10C60", VA = "0xC10C60")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0xC112E0", Offset = "0xC112E0", VA = "0xC112E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F37C", Offset = "0x52F37C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xC11354", Offset = "0xC11354", VA = "0xC11354")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xC115FC", Offset = "0xC115FC", VA = "0xC115FC")]
	public void Play()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xC117A8", Offset = "0xC117A8", VA = "0xC117A8")]
	public void Pause()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xC11950", Offset = "0xC11950", VA = "0xC11950")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xC11BCC", Offset = "0xC11BCC", VA = "0xC11BCC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xC12654", Offset = "0xC12654", VA = "0xC12654")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xC12884", Offset = "0xC12884", VA = "0xC12884")]
	public void Stop()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xC12A2C", Offset = "0xC12A2C", VA = "0xC12A2C")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xC12B20", Offset = "0xC12B20", VA = "0xC12B20")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x20000A7")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x20001A1")]
	private enum PlaybackState
	{
		[Token(Token = "0x40009B8")]
		Playing,
		[Token(Token = "0x40009B9")]
		Paused,
		[Token(Token = "0x40009BA")]
		Rewinding,
		[Token(Token = "0x40009BB")]
		FastForwarding
	}

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xC12B30", Offset = "0xC12B30", VA = "0xC12B30")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xC12E8C", Offset = "0xC12E8C", VA = "0xC12E8C")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xC1306C", Offset = "0xC1306C", VA = "0xC1306C")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xC131A8", Offset = "0xC131A8", VA = "0xC131A8")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xC132B4", Offset = "0xC132B4", VA = "0xC132B4")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xC13178", Offset = "0xC13178", VA = "0xC13178")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xC13304", Offset = "0xC13304", VA = "0xC13304")]
	private void Update()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xC12D78", Offset = "0xC12D78", VA = "0xC12D78")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xC13644", Offset = "0xC13644", VA = "0xC13644")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x20000A8")]
public static class VectorUtil
{
	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xAE9AF4", Offset = "0xAE9AF4", VA = "0xAE9AF4")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x20000A9")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x4000444")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x4000445")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x9B51B0", Offset = "0x9B51B0", VA = "0x9B51B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x9B5568", Offset = "0x9B5568", VA = "0x9B5568")]
	private void Update()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x9B57F4", Offset = "0x9B57F4", VA = "0x9B57F4")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x9B5964", Offset = "0x9B5964", VA = "0x9B5964")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x9B5AD8", Offset = "0x9B5AD8", VA = "0x9B5AD8")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x9B5C70", Offset = "0x9B5C70", VA = "0x9B5C70")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x20000AA")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x400044E")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x953AC0", Offset = "0x953AC0", VA = "0x953AC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x953B18", Offset = "0x953B18", VA = "0x953B18")]
	private void Start()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x953B1C", Offset = "0x953B1C", VA = "0x953B1C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x953B20", Offset = "0x953B20", VA = "0x953B20")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x953D80", Offset = "0x953D80", VA = "0x953D80")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x953FB0", Offset = "0x953FB0", VA = "0x953FB0")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x20000AB")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x955DB0", Offset = "0x955DB0", VA = "0x955DB0")]
	private void Start()
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x9562B4", Offset = "0x9562B4", VA = "0x9562B4")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x956374", Offset = "0x956374", VA = "0x956374")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x95659C", Offset = "0x95659C", VA = "0x95659C")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x956684", Offset = "0x956684", VA = "0x956684")]
	private void Update()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x956770", Offset = "0x956770", VA = "0x956770")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x9567E4", Offset = "0x9567E4", VA = "0x9567E4")]
	public DebugUISample()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x9567EC", Offset = "0x9567EC", VA = "0x9567EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F3F4", Offset = "0x52F3F4")]
	private void <Start>b__2_0(Toggle t)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x956858", Offset = "0x956858", VA = "0x956858")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F404", Offset = "0x52F404")]
	private void <Start>b__2_1(Toggle t)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x9568C4", Offset = "0x9568C4", VA = "0x9568C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F414", Offset = "0x52F414")]
	private void <Start>b__2_2(Toggle t)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x956930", Offset = "0x956930", VA = "0x956930")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F424", Offset = "0x52F424")]
	private void <Start>b__2_3(Toggle t)
	{
	}
}
[Token(Token = "0x20000AC")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x20001A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B4CC", Offset = "0x52B4CC")]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x170000C5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x85F5C8", Offset = "0x85F5C8", VA = "0x85F5C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x85F610", Offset = "0x85F610", VA = "0x85F610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x85F480", Offset = "0x85F480", VA = "0x85F480")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x85F4AC", Offset = "0x85F4AC", VA = "0x85F4AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x85F4B0", Offset = "0x85F4B0", VA = "0x85F4B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x85F5D0", Offset = "0x85F5D0", VA = "0x85F5D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x95DBD8", Offset = "0x95DBD8", VA = "0x95DBD8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x95DCEC", Offset = "0x95DCEC", VA = "0x95DCEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x95DC78", Offset = "0x95DC78", VA = "0x95DC78")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F434", Offset = "0x52F434")]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x95DEA8", Offset = "0x95DEA8", VA = "0x95DEA8")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x20000AD")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52C8CC", Offset = "0x52C8CC")]
	public int SubdivisionsU;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52C8E8", Offset = "0x52C8E8")]
	public int SubdivisionsV;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x9C8F48", Offset = "0x9C8F48", VA = "0x9C8F48")]
	private void Update()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x9C9958", Offset = "0x9C9958", VA = "0x9C9958")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x20000AE")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x17000022")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x600031D")]
		[Address(RVA = "0xC096F4", Offset = "0xC096F4", VA = "0xC096F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xC09748", Offset = "0xC09748", VA = "0xC09748")]
	public void Start()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xC09B44", Offset = "0xC09B44", VA = "0xC09B44")]
	public void Update()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xC09C38", Offset = "0xC09C38", VA = "0xC09C38")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x52F49C", Offset = "0x52F49C")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x6000321")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000322")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x6000323")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x6000324")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x6000325")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x6000326")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x6000327")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x6000328")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xC09CA4", Offset = "0xC09CA4", VA = "0xC09CA4")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xC09CE8", Offset = "0xC09CE8", VA = "0xC09CE8")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xC09D58", Offset = "0xC09D58", VA = "0xC09D58")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0xC09EC8", Offset = "0xC09EC8", VA = "0xC09EC8")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0xC09FAC", Offset = "0xC09FAC", VA = "0xC09FAC")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0xC09A3C", Offset = "0xC09A3C", VA = "0xC09A3C")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0xC0A074", Offset = "0xC0A074", VA = "0xC0A074")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0xC0A0DC", Offset = "0xC0A0DC", VA = "0xC0A0DC")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xC0A1D4", Offset = "0xC0A1D4", VA = "0xC0A1D4")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x20000AF")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x52B17C", Offset = "0x52B17C")]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x20001A3")]
	public enum DrawMode
	{
		[Token(Token = "0x40009C0")]
		Opaque,
		[Token(Token = "0x40009C1")]
		OpaqueWithClip,
		[Token(Token = "0x40009C2")]
		TransparentDefaultAlpha,
		[Token(Token = "0x40009C3")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[HideInInspector]
	private Shader _transparentShader;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	[HideInInspector]
	private Shader _opaqueShader;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x17000023")]
	public bool overlayEnabled
	{
		[Token(Token = "0x6000338")]
		[Address(RVA = "0xC86254", Offset = "0xC86254", VA = "0xC86254")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000339")]
		[Address(RVA = "0xC862F0", Offset = "0xC862F0", VA = "0xC862F0")]
		set
		{
		}
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0xC84D90", Offset = "0xC84D90", VA = "0xC84D90")]
	private void Start()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xC858A4", Offset = "0xC858A4", VA = "0xC858A4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xC8592C", Offset = "0xC8592C", VA = "0xC8592C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0xC85A1C", Offset = "0xC85A1C", VA = "0xC85A1C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0xC85B0C", Offset = "0xC85B0C", VA = "0xC85B0C", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0xC85D2C", Offset = "0xC85D2C", VA = "0xC85D2C")]
	private void Update()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xC863BC", Offset = "0xC863BC", VA = "0xC863BC")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x20000B0")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x20001A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B4DC", Offset = "0x52B4DC")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int sceneIndex;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StartMenu <>4__this;

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x867850", Offset = "0x867850", VA = "0x867850")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x867858", Offset = "0x867858", VA = "0x867858")]
		internal void <Start>b__0()
		{
		}
	}

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x9795C4", Offset = "0x9795C4", VA = "0x9795C4")]
	private void Start()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x9797C8", Offset = "0x9797C8", VA = "0x9797C8")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x9798E0", Offset = "0x9798E0", VA = "0x9798E0")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x20000B1")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x52B1E4", Offset = "0x52B1E4")]
public class MouseLook : MonoBehaviour
{
	[Token(Token = "0x20001A5")]
	public enum RotationAxes
	{
		[Token(Token = "0x40009C7")]
		MouseXAndY,
		[Token(Token = "0x40009C8")]
		MouseX,
		[Token(Token = "0x40009C9")]
		MouseY
	}

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RotationAxes axes;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sensitivityX;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sensitivityY;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minimumX;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maximumX;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float minimumY;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float maximumY;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float rotationY;

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xC10620", Offset = "0xC10620", VA = "0xC10620")]
	private void Update()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xC107F4", Offset = "0xC107F4", VA = "0xC107F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xC108BC", Offset = "0xC108BC", VA = "0xC108BC")]
	public MouseLook()
	{
	}
}
[Token(Token = "0x20000B2")]
public struct ReflectionSnapshot
{
	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public AudioMixerSnapshot mixerSnapshot;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float fadeTime;
}
[Token(Token = "0x20000B3")]
public class ONSPReflectionZone : MonoBehaviour
{
	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioMixerSnapshot mixerSnapshot;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fadeTime;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Stack<ReflectionSnapshot> snapshotList;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ReflectionSnapshot currentSnapshot;

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xC843E0", Offset = "0xC843E0", VA = "0xC843E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xC843E4", Offset = "0xC843E4", VA = "0xC843E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xC843E8", Offset = "0xC843E8", VA = "0xC843E8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xC84568", Offset = "0xC84568", VA = "0xC84568")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xC84434", Offset = "0xC84434", VA = "0xC84434")]
	private bool CheckForAudioListener(GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xC844CC", Offset = "0xC844CC", VA = "0xC844CC")]
	private void PushCurrentMixerShapshot()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xC845B4", Offset = "0xC845B4", VA = "0xC845B4")]
	private void PopCurrentMixerSnapshot()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xC84654", Offset = "0xC84654", VA = "0xC84654")]
	private void SetReflectionValues()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0xC847EC", Offset = "0xC847EC", VA = "0xC847EC")]
	private void SetReflectionValues(ReflectionSnapshot mss)
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xC84984", Offset = "0xC84984", VA = "0xC84984")]
	public ONSPReflectionZone()
	{
	}
}
[Token(Token = "0x20000B4")]
public class OculusSpatializerUnity : MonoBehaviour
{
	[Token(Token = "0x20001A6")]
	public delegate void AudioRaycastCallback(Vector3 origin, Vector3 direction, [Out] Vector3 point, [Out] Vector3 normal, IntPtr data);

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LayerMask layerMask;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool visualizeRoom;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	private bool roomVisualizationInitialized;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int raysPerSecond;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float roomInterpSpeed;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maxWallDistance;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int rayCacheSize;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool dynamicReflectionsEnabled;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float particleSize;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float particleOffset;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject room;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Renderer[] wallRenderer;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float[] dims;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float[] coefs;

	[Token(Token = "0x4000494")]
	private const int HIT_COUNT = 2048;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3[] points;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] normals;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ParticleSystem sys;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LayerMask gLayerMask;

	[Token(Token = "0x400049A")]
	private const string strOSP = "AudioPluginOculusSpatializer";

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xC884F8", Offset = "0xC884F8", VA = "0xC884F8")]
	private static Vector3 swapHandedness(Vector3 vec)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0xC8838C", Offset = "0xC8838C", VA = "0xC8838C")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x52F4D4", Offset = "0x52F4D4")]
	private static void AudioRaycast(Vector3 origin, Vector3 direction, [Out] Vector3 point, [Out] Vector3 normal, IntPtr data)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xC88500", Offset = "0xC88500", VA = "0xC88500")]
	private void Start()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xC8864C", Offset = "0xC8864C", VA = "0xC8864C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xC88748", Offset = "0xC88748", VA = "0xC88748")]
	private void Update()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xC89048", Offset = "0xC89048", VA = "0xC89048")]
	private void inititalizeRoomVisualization()
	{
	}

	[PreserveSig]
	[Token(Token = "0x6000353")]
	[Address(RVA = "0xC885B8", Offset = "0xC885B8", VA = "0xC885B8")]
	private static extern int OSP_Unity_AssignRaycastCallback(AudioRaycastCallback callback, IntPtr data);

	[PreserveSig]
	[Token(Token = "0x6000354")]
	[Address(RVA = "0xC886B8", Offset = "0xC886B8", VA = "0xC886B8")]
	private static extern int OSP_Unity_AssignRaycastCallback(IntPtr callback, IntPtr data);

	[PreserveSig]
	[Token(Token = "0x6000355")]
	[Address(RVA = "0xC88DB0", Offset = "0xC88DB0", VA = "0xC88DB0")]
	private static extern int OSP_Unity_SetDynamicRoomRaysPerSecond(int RaysPerSecond);

	[PreserveSig]
	[Token(Token = "0x6000356")]
	[Address(RVA = "0xC88E30", Offset = "0xC88E30", VA = "0xC88E30")]
	private static extern int OSP_Unity_SetDynamicRoomInterpSpeed(float InterpSpeed);

	[PreserveSig]
	[Token(Token = "0x6000357")]
	[Address(RVA = "0xC88EB8", Offset = "0xC88EB8", VA = "0xC88EB8")]
	private static extern int OSP_Unity_SetDynamicRoomMaxWallDistance(float MaxWallDistance);

	[PreserveSig]
	[Token(Token = "0x6000358")]
	[Address(RVA = "0xC88F40", Offset = "0xC88F40", VA = "0xC88F40")]
	private static extern int OSP_Unity_SetDynamicRoomRaysRayCacheSize(int RayCacheSize);

	[PreserveSig]
	[Token(Token = "0x6000359")]
	[Address(RVA = "0xC88FC0", Offset = "0xC88FC0", VA = "0xC88FC0")]
	private static extern int OSP_Unity_UpdateRoomModel(float wetLevel);

	[PreserveSig]
	[Token(Token = "0x600035A")]
	[Address(RVA = "0xC89D04", Offset = "0xC89D04", VA = "0xC89D04")]
	private static extern int OSP_Unity_GetRoomDimensions(float[] roomDimensions, float[] reflectionsCoefs, [Out] Vector3 position);

	[PreserveSig]
	[Token(Token = "0x600035B")]
	[Address(RVA = "0xC89DAC", Offset = "0xC89DAC", VA = "0xC89DAC")]
	private static extern int OSP_Unity_GetRaycastHits(Vector3[] points, Vector3[] normals, int length);

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xC89E54", Offset = "0xC89E54", VA = "0xC89E54")]
	public OculusSpatializerUnity()
	{
	}
}
[Token(Token = "0x20000B5")]
public class ONSPAmbisonicsNative : MonoBehaviour
{
	[Token(Token = "0x20001A7")]
	public enum ovrAmbisonicsNativeStatus
	{
		[Token(Token = "0x40009CB")]
		Uninitialized = -1,
		[Token(Token = "0x40009CC")]
		NotEnabled,
		[Token(Token = "0x40009CD")]
		Success,
		[Token(Token = "0x40009CE")]
		StreamError,
		[Token(Token = "0x40009CF")]
		ProcessError,
		[Token(Token = "0x40009D0")]
		MaxStatValue
	}

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource source;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int numFOAChannels;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int paramAmbiStat;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAmbisonicsNativeStatus currentStatus;

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xC144BC", Offset = "0xC144BC", VA = "0xC144BC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xC14728", Offset = "0xC14728", VA = "0xC14728")]
	private void Update()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xC14918", Offset = "0xC14918", VA = "0xC14918")]
	public ONSPAmbisonicsNative()
	{
	}
}
[Token(Token = "0x20000B6")]
public class ONSPAudioSource : MonoBehaviour
{
	[Token(Token = "0x20001A8")]
	private enum Parameters
	{
		[Token(Token = "0x40009D2")]
		P_GAIN,
		[Token(Token = "0x40009D3")]
		P_USEINVSQR,
		[Token(Token = "0x40009D4")]
		P_NEAR,
		[Token(Token = "0x40009D5")]
		P_FAR,
		[Token(Token = "0x40009D6")]
		P_RADIUS,
		[Token(Token = "0x40009D7")]
		P_DISABLE_RFL,
		[Token(Token = "0x40009D8")]
		P_AMBISTAT,
		[Token(Token = "0x40009D9")]
		P_READONLY_GLOBAL_RFL_ENABLED,
		[Token(Token = "0x40009DA")]
		P_READONLY_NUM_VOICES,
		[Token(Token = "0x40009DB")]
		P_SENDLEVEL,
		[Token(Token = "0x40009DC")]
		P_NUM
	}

	[Token(Token = "0x400049F")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool enableSpatialization;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float gain;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool useInvSqr;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float near;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float far;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float volumetricRadius;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float reverbSend;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool enableRfl;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ONSPAudioSource RoomReflectionGizmoAS;

	[Token(Token = "0x17000024")]
	public bool EnableSpatialization
	{
		[Token(Token = "0x6000364")]
		[Address(RVA = "0xC14B5C", Offset = "0xC14B5C", VA = "0xC14B5C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000365")]
		[Address(RVA = "0xC14B64", Offset = "0xC14B64", VA = "0xC14B64")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public float Gain
	{
		[Token(Token = "0x6000366")]
		[Address(RVA = "0xC14B70", Offset = "0xC14B70", VA = "0xC14B70")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000367")]
		[Address(RVA = "0xC14B78", Offset = "0xC14B78", VA = "0xC14B78")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public bool UseInvSqr
	{
		[Token(Token = "0x6000368")]
		[Address(RVA = "0xC14BA8", Offset = "0xC14BA8", VA = "0xC14BA8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000369")]
		[Address(RVA = "0xC14BB0", Offset = "0xC14BB0", VA = "0xC14BB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public float Near
	{
		[Token(Token = "0x600036A")]
		[Address(RVA = "0xC14BBC", Offset = "0xC14BBC", VA = "0xC14BBC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600036B")]
		[Address(RVA = "0xC14BC4", Offset = "0xC14BC4", VA = "0xC14BC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public float Far
	{
		[Token(Token = "0x600036C")]
		[Address(RVA = "0xC14BF8", Offset = "0xC14BF8", VA = "0xC14BF8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600036D")]
		[Address(RVA = "0xC14C00", Offset = "0xC14C00", VA = "0xC14C00")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public float VolumetricRadius
	{
		[Token(Token = "0x600036E")]
		[Address(RVA = "0xC14C34", Offset = "0xC14C34", VA = "0xC14C34")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600036F")]
		[Address(RVA = "0xC14C3C", Offset = "0xC14C3C", VA = "0xC14C3C")]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	public float ReverbSend
	{
		[Token(Token = "0x6000370")]
		[Address(RVA = "0xC14C70", Offset = "0xC14C70", VA = "0xC14C70")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000371")]
		[Address(RVA = "0xC14C78", Offset = "0xC14C78", VA = "0xC14C78")]
		set
		{
		}
	}

	[Token(Token = "0x1700002B")]
	public bool EnableRfl
	{
		[Token(Token = "0x6000372")]
		[Address(RVA = "0xC14CAC", Offset = "0xC14CAC", VA = "0xC14CAC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000373")]
		[Address(RVA = "0xC14CB4", Offset = "0xC14CB4", VA = "0xC14CB4")]
		set
		{
		}
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xC14988", Offset = "0xC14988", VA = "0xC14988")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x52F53C", Offset = "0x52F53C")]
	private static void OnBeforeSceneLoadRuntimeMethod()
	{
	}

	[PreserveSig]
	[Token(Token = "0x6000363")]
	[Address(RVA = "0xC14A7C", Offset = "0xC14A7C", VA = "0xC14A7C")]
	private static extern void ONSP_GetGlobalRoomReflectionValues(bool reflOn, bool reverbOn, float width, float height, float length);

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xC14CC0", Offset = "0xC14CC0", VA = "0xC14CC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xC14E2C", Offset = "0xC14E2C", VA = "0xC14E2C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xC14E30", Offset = "0xC14E30", VA = "0xC14E30")]
	private void Update()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xC14D28", Offset = "0xC14D28", VA = "0xC14D28")]
	public void SetParameters(AudioSource source)
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xC14EF4", Offset = "0xC14EF4", VA = "0xC14EF4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xC152E4", Offset = "0xC152E4", VA = "0xC152E4")]
	private void OnDestroy()
	{
	}

	[PreserveSig]
	[Token(Token = "0x600037A")]
	[Address(RVA = "0xC149FC", Offset = "0xC149FC", VA = "0xC149FC")]
	private static extern int OSP_SetGlobalVoiceLimit(int VoiceLimit);

	[Token(Token = "0x600037B")]
	[Address(RVA = "0xC153BC", Offset = "0xC153BC", VA = "0xC153BC")]
	public ONSPAudioSource()
	{
	}
}
[Token(Token = "0x20000B7")]
public class ONSPProfiler : MonoBehaviour
{
	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool profilerEnabled;

	[Token(Token = "0x40004AA")]
	private const int DEFAULT_PORT = 2121;

	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int port;

	[Token(Token = "0x40004AC")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[Token(Token = "0x600037D")]
	[Address(RVA = "0xC153DC", Offset = "0xC153DC", VA = "0xC153DC")]
	private void Start()
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0xC153E8", Offset = "0xC153E8", VA = "0xC153E8")]
	private void Update()
	{
	}

	[PreserveSig]
	[Token(Token = "0x600037F")]
	[Address(RVA = "0xC154A0", Offset = "0xC154A0", VA = "0xC154A0")]
	private static extern int ONSP_SetProfilerEnabled(bool enabled);

	[PreserveSig]
	[Token(Token = "0x6000380")]
	[Address(RVA = "0xC15420", Offset = "0xC15420", VA = "0xC15420")]
	private static extern int ONSP_SetProfilerPort(int port);

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xC15520", Offset = "0xC15520", VA = "0xC15520")]
	public ONSPProfiler()
	{
	}
}
[Token(Token = "0x20000B8")]
public class ONSPPropagationGeometry : MonoBehaviour
{
	[Token(Token = "0x20001A9")]
	private struct MeshMaterial
	{
		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MeshFilter meshFilter;

		[Token(Token = "0x40009DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ONSPPropagationMaterial[] materials;
	}

	[Token(Token = "0x20001AA")]
	private struct TerrainMaterial
	{
		[Token(Token = "0x40009DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Terrain terrain;

		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ONSPPropagationMaterial[] materials;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh[] treePrototypeMeshes;
	}

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string GeometryAssetDirectory;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string filePathRelative;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool fileEnabled;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool includeChildMeshes;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IntPtr geometryHandle;

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int OSPSuccess;

	[Token(Token = "0x40004B3")]
	public const string GEOMETRY_FILE_EXTENSION = "ovramesh";

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int terrainDecimation;

	[Token(Token = "0x1700002C")]
	public static string GeometryAssetPath
	{
		[Token(Token = "0x6000382")]
		[Address(RVA = "0xC1581C", Offset = "0xC1581C", VA = "0xC1581C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002D")]
	public string filePath
	{
		[Token(Token = "0x6000383")]
		[Address(RVA = "0xC158B8", Offset = "0xC158B8", VA = "0xC158B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xC15940", Offset = "0xC15940", VA = "0xC15940")]
	private static string GetPath(Transform current)
	{
		return null;
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xC15A98", Offset = "0xC15A98", VA = "0xC15A98")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0xC15A9C", Offset = "0xC15A9C", VA = "0xC15A9C")]
	private void CreatePropagationGeometry()
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0xC16070", Offset = "0xC16070", VA = "0xC16070")]
	private void Update()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xC1641C", Offset = "0xC1641C", VA = "0xC1641C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xC16590", Offset = "0xC16590", VA = "0xC16590")]
	private static void traverseMeshHierarchy(GameObject obj, ONSPPropagationMaterial[] currentMaterials, bool includeChildren, List<MeshMaterial> meshMaterials, List<TerrainMaterial> terrainMaterials, bool ignoreStatic, int ignoredMeshCount)
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0xC16D00", Offset = "0xC16D00", VA = "0xC16D00")]
	private int uploadMesh(IntPtr geometryHandle, GameObject meshObject, Matrix4x4 worldToLocal)
	{
		return default(int);
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0xC16D3C", Offset = "0xC16D3C", VA = "0xC16D3C")]
	private int uploadMesh(IntPtr geometryHandle, GameObject meshObject, Matrix4x4 worldToLocal, bool ignoreStatic, int ignoredMeshCount)
	{
		return default(int);
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xC185D8", Offset = "0xC185D8", VA = "0xC185D8")]
	private static void uploadMeshFilter(List<Vector3> tempVertices, List<int> tempIndices, MeshGroup[] groups, float[] vertices, int[] indices, int vertexOffset, int indexOffset, int groupOffset, Mesh mesh, ONSPPropagationMaterial[] materials, Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0xC18318", Offset = "0xC18318", VA = "0xC18318")]
	private static void updateCountsForMesh(int totalVertexCount, uint totalIndexCount, int totalFaceCount, int totalMaterialCount, Mesh mesh)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0xC15E7C", Offset = "0xC15E7C", VA = "0xC15E7C")]
	public void UploadGeometry()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xC15C8C", Offset = "0xC15C8C", VA = "0xC15C8C")]
	public bool ReadFile()
	{
		return default(bool);
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xC18C58", Offset = "0xC18C58", VA = "0xC18C58")]
	public bool WriteToObj()
	{
		return default(bool);
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xC190D0", Offset = "0xC190D0", VA = "0xC190D0")]
	public ONSPPropagationGeometry()
	{
	}
}
[Token(Token = "0x20000B9")]
internal class ONSPPropagation
{
	[Token(Token = "0x20001AB")]
	public enum ovrAudioScalarType : uint
	{
		[Token(Token = "0x40009E3")]
		Int8,
		[Token(Token = "0x40009E4")]
		UInt8,
		[Token(Token = "0x40009E5")]
		Int16,
		[Token(Token = "0x40009E6")]
		UInt16,
		[Token(Token = "0x40009E7")]
		Int32,
		[Token(Token = "0x40009E8")]
		UInt32,
		[Token(Token = "0x40009E9")]
		Int64,
		[Token(Token = "0x40009EA")]
		UInt64,
		[Token(Token = "0x40009EB")]
		Float16,
		[Token(Token = "0x40009EC")]
		Float32,
		[Token(Token = "0x40009ED")]
		Float64
	}

	[Token(Token = "0x20001AC")]
	public class ClientType
	{
		[Token(Token = "0x40009EE")]
		public const uint OVRA_CLIENT_TYPE_NATIVE = 0u;

		[Token(Token = "0x40009EF")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2016 = 1u;

		[Token(Token = "0x40009F0")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2017_1 = 2u;

		[Token(Token = "0x40009F1")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2017_2 = 3u;

		[Token(Token = "0x40009F2")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2018_1 = 4u;

		[Token(Token = "0x40009F3")]
		public const uint OVRA_CLIENT_TYPE_FMOD = 5u;

		[Token(Token = "0x40009F4")]
		public const uint OVRA_CLIENT_TYPE_UNITY = 6u;

		[Token(Token = "0x40009F5")]
		public const uint OVRA_CLIENT_TYPE_UE4 = 7u;

		[Token(Token = "0x40009F6")]
		public const uint OVRA_CLIENT_TYPE_VST = 8u;

		[Token(Token = "0x40009F7")]
		public const uint OVRA_CLIENT_TYPE_AAX = 9u;

		[Token(Token = "0x40009F8")]
		public const uint OVRA_CLIENT_TYPE_TEST = 10u;

		[Token(Token = "0x40009F9")]
		public const uint OVRA_CLIENT_TYPE_OTHER = 11u;

		[Token(Token = "0x40009FA")]
		public const uint OVRA_CLIENT_TYPE_WWISE_UNKNOWN = 12u;

		[Token(Token = "0x40009FB")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2019_1 = 13u;

		[Token(Token = "0x40009FC")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2019_2 = 14u;

		[Token(Token = "0x40009FD")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2021_1 = 15u;

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x860D58", Offset = "0x860D58", VA = "0x860D58")]
		public ClientType()
		{
		}
	}

	[Token(Token = "0x20001AD")]
	public interface PropagationInterface
	{
		[Token(Token = "0x60008E9")]
		int SetPropagationQuality(float quality);

		[Token(Token = "0x60008EA")]
		int SetPropagationThreadAffinity(ulong cpuMask);

		[Token(Token = "0x60008EB")]
		int CreateAudioGeometry([Out] IntPtr geometry);

		[Token(Token = "0x60008EC")]
		int DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x60008ED")]
		int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount);

		[Token(Token = "0x60008EE")]
		int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x60008EF")]
		int AudioGeometryGetTransform(IntPtr geometry, [Out] float[] matrix4x4);

		[Token(Token = "0x60008F0")]
		int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x60008F1")]
		int AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x60008F2")]
		int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x60008F3")]
		int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, [Out] float value);

		[Token(Token = "0x60008F4")]
		int CreateAudioMaterial([Out] IntPtr material);

		[Token(Token = "0x60008F5")]
		int DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x60008F6")]
		int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x60008F7")]
		int AudioMaterialReset(IntPtr material, MaterialProperty property);
	}

	[Token(Token = "0x20001AE")]
	public class UnityNativeInterface : PropagationInterface
	{
		[Token(Token = "0x40009FE")]
		public const string strOSPS = "AudioPluginOculusSpatializer";

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x170000C7")]
		private IntPtr context
		{
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x861A9C", Offset = "0x861A9C", VA = "0x861A9C")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x861AFC", Offset = "0x861AFC", VA = "0x861AFC")]
		public static extern int ovrAudio_GetPluginContext([Out] IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x861B8C", Offset = "0x861B8C", VA = "0x861B8C")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x861C1C", Offset = "0x861C1C", VA = "0x861C1C", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x861C40", Offset = "0x861C40", VA = "0x861C40")]
		private static extern int ovrAudio_SetPropagationThreadAffinity(IntPtr context, ulong cpuMask);

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x861CD0", Offset = "0x861CD0", VA = "0x861CD0", Slot = "5")]
		public int SetPropagationThreadAffinity(ulong cpuMask)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x861CF4", Offset = "0x861CF4", VA = "0x861CF4")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, [Out] IntPtr geometry);

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x861D80", Offset = "0x861D80", VA = "0x861D80", Slot = "6")]
		public int CreateAudioGeometry([Out] IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x861DA4", Offset = "0x861DA4", VA = "0x861DA4")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x861E24", Offset = "0x861E24", VA = "0x861E24", Slot = "7")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x861E2C", Offset = "0x861E2C", VA = "0x861E2C")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x861F4C", Offset = "0x861F4C", VA = "0x861F4C", Slot = "8")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x862048", Offset = "0x862048", VA = "0x862048")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x8620E0", Offset = "0x8620E0", VA = "0x8620E0", Slot = "9")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x8620EC", Offset = "0x8620EC", VA = "0x8620EC")]
		private static extern int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, [Out] float[] matrix4x4);

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x862214", Offset = "0x862214", VA = "0x862214", Slot = "10")]
		public int AudioGeometryGetTransform(IntPtr geometry, [Out] float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x862220", Offset = "0x862220", VA = "0x862220")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x8622CC", Offset = "0x8622CC", VA = "0x8622CC", Slot = "11")]
		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x8622D8", Offset = "0x8622D8", VA = "0x8622D8")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x862384", Offset = "0x862384", VA = "0x862384", Slot = "12")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x862390", Offset = "0x862390", VA = "0x862390")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x86243C", Offset = "0x86243C", VA = "0x86243C", Slot = "13")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x862448", Offset = "0x862448", VA = "0x862448")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, [Out] IntPtr material);

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x8624D4", Offset = "0x8624D4", VA = "0x8624D4", Slot = "15")]
		public int CreateAudioMaterial([Out] IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x8624F8", Offset = "0x8624F8", VA = "0x8624F8")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x862578", Offset = "0x862578", VA = "0x862578", Slot = "16")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x862580", Offset = "0x862580", VA = "0x862580")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x862628", Offset = "0x862628", VA = "0x862628", Slot = "17")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x862634", Offset = "0x862634", VA = "0x862634")]
		private static extern int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, [Out] float value);

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x8626DC", Offset = "0x8626DC", VA = "0x8626DC", Slot = "14")]
		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, [Out] float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x8626EC", Offset = "0x8626EC", VA = "0x8626EC")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x86277C", Offset = "0x86277C", VA = "0x86277C", Slot = "18")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x862788", Offset = "0x862788", VA = "0x862788")]
		public UnityNativeInterface()
		{
		}
	}

	[Token(Token = "0x20001AF")]
	public class WwisePluginInterface : PropagationInterface
	{
		[Token(Token = "0x4000A00")]
		public const string strOSPS = "OculusSpatializerWwise";

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x170000C8")]
		private IntPtr context
		{
			[Token(Token = "0x6000919")]
			[Address(RVA = "0x8627D0", Offset = "0x8627D0", VA = "0x8627D0")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x862830", Offset = "0x862830", VA = "0x862830")]
		public static extern int ovrAudio_GetPluginContext([Out] IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x600091B")]
		[Address(RVA = "0x8628C0", Offset = "0x8628C0", VA = "0x8628C0")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x862950", Offset = "0x862950", VA = "0x862950", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x862974", Offset = "0x862974", VA = "0x862974")]
		private static extern int ovrAudio_SetPropagationThreadAffinity(IntPtr context, ulong cpuMask);

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x862A04", Offset = "0x862A04", VA = "0x862A04", Slot = "5")]
		public int SetPropagationThreadAffinity(ulong cpuMask)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600091F")]
		[Address(RVA = "0x862A28", Offset = "0x862A28", VA = "0x862A28")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, [Out] IntPtr geometry);

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x862AB8", Offset = "0x862AB8", VA = "0x862AB8", Slot = "6")]
		public int CreateAudioGeometry([Out] IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x862ADC", Offset = "0x862ADC", VA = "0x862ADC")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x862B5C", Offset = "0x862B5C", VA = "0x862B5C", Slot = "7")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x862B64", Offset = "0x862B64", VA = "0x862B64")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x862C84", Offset = "0x862C84", VA = "0x862C84", Slot = "8")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x862D80", Offset = "0x862D80", VA = "0x862D80")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x862E18", Offset = "0x862E18", VA = "0x862E18", Slot = "9")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x862E24", Offset = "0x862E24", VA = "0x862E24")]
		private static extern int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, [Out] float[] matrix4x4);

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x862F4C", Offset = "0x862F4C", VA = "0x862F4C", Slot = "10")]
		public int AudioGeometryGetTransform(IntPtr geometry, [Out] float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000929")]
		[Address(RVA = "0x862F58", Offset = "0x862F58", VA = "0x862F58")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x863004", Offset = "0x863004", VA = "0x863004", Slot = "11")]
		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x863010", Offset = "0x863010", VA = "0x863010")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x8630BC", Offset = "0x8630BC", VA = "0x8630BC", Slot = "12")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600092D")]
		[Address(RVA = "0x8630C8", Offset = "0x8630C8", VA = "0x8630C8")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x863174", Offset = "0x863174", VA = "0x863174", Slot = "13")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600092F")]
		[Address(RVA = "0x863180", Offset = "0x863180", VA = "0x863180")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, [Out] IntPtr material);

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x863210", Offset = "0x863210", VA = "0x863210", Slot = "15")]
		public int CreateAudioMaterial([Out] IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x863234", Offset = "0x863234", VA = "0x863234")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x8632B4", Offset = "0x8632B4", VA = "0x8632B4", Slot = "16")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x8632BC", Offset = "0x8632BC", VA = "0x8632BC")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x863364", Offset = "0x863364", VA = "0x863364", Slot = "17")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000935")]
		[Address(RVA = "0x863370", Offset = "0x863370", VA = "0x863370")]
		private static extern int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, [Out] float value);

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x863418", Offset = "0x863418", VA = "0x863418", Slot = "14")]
		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, [Out] float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000937")]
		[Address(RVA = "0x863428", Offset = "0x863428", VA = "0x863428")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x8634B8", Offset = "0x8634B8", VA = "0x8634B8", Slot = "18")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x8634C4", Offset = "0x8634C4", VA = "0x8634C4")]
		public WwisePluginInterface()
		{
		}
	}

	[Token(Token = "0x20001B0")]
	public class FMODPluginInterface : PropagationInterface
	{
		[Token(Token = "0x4000A02")]
		public const string strOSPS = "OculusSpatializerFMOD";

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x170000C9")]
		private IntPtr context
		{
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x860D60", Offset = "0x860D60", VA = "0x860D60")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x600093B")]
		[Address(RVA = "0x860DC0", Offset = "0x860DC0", VA = "0x860DC0")]
		public static extern int ovrAudio_GetPluginContext([Out] IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x860E50", Offset = "0x860E50", VA = "0x860E50")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x860EE0", Offset = "0x860EE0", VA = "0x860EE0", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x860F04", Offset = "0x860F04", VA = "0x860F04")]
		private static extern int ovrAudio_SetPropagationThreadAffinity(IntPtr context, ulong cpuMask);

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x860F94", Offset = "0x860F94", VA = "0x860F94", Slot = "5")]
		public int SetPropagationThreadAffinity(ulong cpuMask)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x860FB8", Offset = "0x860FB8", VA = "0x860FB8")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, [Out] IntPtr geometry);

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x861048", Offset = "0x861048", VA = "0x861048", Slot = "6")]
		public int CreateAudioGeometry([Out] IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x86106C", Offset = "0x86106C", VA = "0x86106C")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x8610EC", Offset = "0x8610EC", VA = "0x8610EC", Slot = "7")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x8610F4", Offset = "0x8610F4", VA = "0x8610F4")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x861214", Offset = "0x861214", VA = "0x861214", Slot = "8")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x861310", Offset = "0x861310", VA = "0x861310")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x8613A8", Offset = "0x8613A8", VA = "0x8613A8", Slot = "9")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x8613B4", Offset = "0x8613B4", VA = "0x8613B4")]
		private static extern int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, [Out] float[] matrix4x4);

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x8614DC", Offset = "0x8614DC", VA = "0x8614DC", Slot = "10")]
		public int AudioGeometryGetTransform(IntPtr geometry, [Out] float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x8614E8", Offset = "0x8614E8", VA = "0x8614E8")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x861594", Offset = "0x861594", VA = "0x861594", Slot = "11")]
		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x8615A0", Offset = "0x8615A0", VA = "0x8615A0")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x86164C", Offset = "0x86164C", VA = "0x86164C", Slot = "12")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x861658", Offset = "0x861658", VA = "0x861658")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x861704", Offset = "0x861704", VA = "0x861704", Slot = "13")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x861710", Offset = "0x861710", VA = "0x861710")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, [Out] IntPtr material);

		[Token(Token = "0x6000951")]
		[Address(RVA = "0x8617A0", Offset = "0x8617A0", VA = "0x8617A0", Slot = "15")]
		public int CreateAudioMaterial([Out] IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x8617C4", Offset = "0x8617C4", VA = "0x8617C4")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x861844", Offset = "0x861844", VA = "0x861844", Slot = "16")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x86184C", Offset = "0x86184C", VA = "0x86184C")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x8618F4", Offset = "0x8618F4", VA = "0x8618F4", Slot = "17")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x861900", Offset = "0x861900", VA = "0x861900")]
		private static extern int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, [Out] float value);

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x8619A8", Offset = "0x8619A8", VA = "0x8619A8", Slot = "14")]
		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, [Out] float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x8619B8", Offset = "0x8619B8", VA = "0x8619B8")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x861A48", Offset = "0x861A48", VA = "0x861A48", Slot = "18")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x861A54", Offset = "0x861A54", VA = "0x861A54")]
		public FMODPluginInterface()
		{
		}
	}

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PropagationInterface CachedInterface;

	[Token(Token = "0x1700002E")]
	public static PropagationInterface Interface
	{
		[Token(Token = "0x6000393")]
		[Address(RVA = "0xC15530", Offset = "0xC15530", VA = "0xC15530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xC1559C", Offset = "0xC1559C", VA = "0xC1559C")]
	private static PropagationInterface FindInterface()
	{
		return null;
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0xC15814", Offset = "0xC15814", VA = "0xC15814")]
	public ONSPPropagation()
	{
	}
}
[Token(Token = "0x20000BA")]
public sealed class ONSPPropagationMaterial : MonoBehaviour
{
	[Token(Token = "0x20001B1")]
	public enum Preset
	{
		[Token(Token = "0x4000A05")]
		Custom,
		[Token(Token = "0x4000A06")]
		AcousticTile,
		[Token(Token = "0x4000A07")]
		Brick,
		[Token(Token = "0x4000A08")]
		BrickPainted,
		[Token(Token = "0x4000A09")]
		Carpet,
		[Token(Token = "0x4000A0A")]
		CarpetHeavy,
		[Token(Token = "0x4000A0B")]
		CarpetHeavyPadded,
		[Token(Token = "0x4000A0C")]
		CeramicTile,
		[Token(Token = "0x4000A0D")]
		Concrete,
		[Token(Token = "0x4000A0E")]
		ConcreteRough,
		[Token(Token = "0x4000A0F")]
		ConcreteBlock,
		[Token(Token = "0x4000A10")]
		ConcreteBlockPainted,
		[Token(Token = "0x4000A11")]
		Curtain,
		[Token(Token = "0x4000A12")]
		Foliage,
		[Token(Token = "0x4000A13")]
		Glass,
		[Token(Token = "0x4000A14")]
		GlassHeavy,
		[Token(Token = "0x4000A15")]
		Grass,
		[Token(Token = "0x4000A16")]
		Gravel,
		[Token(Token = "0x4000A17")]
		GypsumBoard,
		[Token(Token = "0x4000A18")]
		PlasterOnBrick,
		[Token(Token = "0x4000A19")]
		PlasterOnConcreteBlock,
		[Token(Token = "0x4000A1A")]
		Soil,
		[Token(Token = "0x4000A1B")]
		SoundProof,
		[Token(Token = "0x4000A1C")]
		Snow,
		[Token(Token = "0x4000A1D")]
		Steel,
		[Token(Token = "0x4000A1E")]
		Water,
		[Token(Token = "0x4000A1F")]
		WoodThin,
		[Token(Token = "0x4000A20")]
		WoodThick,
		[Token(Token = "0x4000A21")]
		WoodFloor,
		[Token(Token = "0x4000A22")]
		WoodOnConcrete
	}

	[Serializable]
	[Token(Token = "0x20001B2")]
	public sealed class Point
	{
		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float frequency;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float data;

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x86350C", Offset = "0x86350C", VA = "0x86350C")]
		public Point(float frequency = 0f, float data = 0f)
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x863544", Offset = "0x863544", VA = "0x863544")]
		public static implicit operator Point(Vector2 v)
		{
			return null;
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x8635B0", Offset = "0x8635B0", VA = "0x8635B0")]
		public static implicit operator Vector2(Point point)
		{
			return default(Vector2);
		}
	}

	[Serializable]
	[Token(Token = "0x20001B3")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x52B4EC", Offset = "0x52B4EC")]
	public sealed class Spectrum
	{
		[Serializable]
		[Token(Token = "0x2000205")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B834", Offset = "0x52B834")]
		private sealed class <>c
		{
			[Token(Token = "0x4000B68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000B69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Point, float> <>9__3_0;

			[Token(Token = "0x4000B6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Point, float> <>9__3_1;

			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x11A7E68", Offset = "0x11A7E68", VA = "0x11A7E68")]
			public <>c()
			{
			}

			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x11A7E70", Offset = "0x11A7E70", VA = "0x11A7E70")]
			internal float <get_Item>b__3_0(Point p)
			{
				return default(float);
			}

			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x11A7E8C", Offset = "0x11A7E8C", VA = "0x11A7E8C")]
			internal float <get_Item>b__3_1(Point p)
			{
				return default(float);
			}
		}

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int selection;

		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Point> points;

		[Token(Token = "0x170000CA")]
		public float Item
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x8635CC", Offset = "0x8635CC", VA = "0x8635CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x863A28", Offset = "0x863A28", VA = "0x863A28")]
		public Spectrum()
		{
		}
	}

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr materialHandle;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52C9F4", Offset = "0x52C9F4")]
	public Spectrum absorption;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52CA2C", Offset = "0x52CA2C")]
	public Spectrum transmission;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52CA64", Offset = "0x52CA64")]
	public Spectrum scattering;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Preset preset_;

	[Token(Token = "0x1700002F")]
	public Preset preset
	{
		[Token(Token = "0x6000396")]
		[Address(RVA = "0xC191C8", Offset = "0xC191C8", VA = "0xC191C8")]
		get
		{
			return default(Preset);
		}
		[Token(Token = "0x6000397")]
		[Address(RVA = "0xC191D0", Offset = "0xC191D0", VA = "0xC191D0")]
		set
		{
		}
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xC191F8", Offset = "0xC191F8", VA = "0xC191F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xC18AD4", Offset = "0xC18AD4", VA = "0xC18AD4")]
	public void StartInternal()
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0xC1980C", Offset = "0xC1980C", VA = "0xC1980C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xC19810", Offset = "0xC19810", VA = "0xC19810")]
	public void DestroyInternal()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xC191FC", Offset = "0xC191FC", VA = "0xC191FC")]
	public void UploadMaterial()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0xC18440", Offset = "0xC18440", VA = "0xC18440")]
	public void SetPreset(Preset preset)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xC198F4", Offset = "0xC198F4", VA = "0xC198F4")]
	private static void AcousticTile(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xC19DB4", Offset = "0xC19DB4", VA = "0xC19DB4")]
	private static void Brick(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0xC1A280", Offset = "0xC1A280", VA = "0xC1A280")]
	private static void BrickPainted(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0xC1A740", Offset = "0xC1A740", VA = "0xC1A740")]
	private static void Carpet(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0xC1AC14", Offset = "0xC1AC14", VA = "0xC1AC14")]
	private static void CarpetHeavy(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0xC1B0D4", Offset = "0xC1B0D4", VA = "0xC1B0D4")]
	private static void CarpetHeavyPadded(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0xC1B594", Offset = "0xC1B594", VA = "0xC1B594")]
	private static void CeramicTile(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0xC1BA5C", Offset = "0xC1BA5C", VA = "0xC1BA5C")]
	private static void Concrete(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xC1BF24", Offset = "0xC1BF24", VA = "0xC1BF24")]
	private static void ConcreteRough(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0xC1C3F0", Offset = "0xC1C3F0", VA = "0xC1C3F0")]
	private static void ConcreteBlock(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xC1C8B8", Offset = "0xC1C8B8", VA = "0xC1C8B8")]
	private static void ConcreteBlockPainted(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0xC1CD88", Offset = "0xC1CD88", VA = "0xC1CD88")]
	private static void Curtain(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0xC1D248", Offset = "0xC1D248", VA = "0xC1D248")]
	private static void Foliage(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0xC1D714", Offset = "0xC1D714", VA = "0xC1D714")]
	private static void Glass(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0xC1DBC4", Offset = "0xC1DBC4", VA = "0xC1DBC4")]
	private static void GlassHeavy(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xC1E080", Offset = "0xC1E080", VA = "0xC1E080")]
	private static void Grass(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0xC1E410", Offset = "0xC1E410", VA = "0xC1E410")]
	private static void Gravel(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0xC1E798", Offset = "0xC1E798", VA = "0xC1E798")]
	private static void GypsumBoard(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0xC1EC68", Offset = "0xC1EC68", VA = "0xC1EC68")]
	private static void PlasterOnBrick(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0xC1F134", Offset = "0xC1F134", VA = "0xC1F134")]
	private static void PlasterOnConcreteBlock(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0xC1F600", Offset = "0xC1F600", VA = "0xC1F600")]
	private static void Soil(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0xC1F994", Offset = "0xC1F994", VA = "0xC1F994")]
	private static void SoundProof(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0xC1FB10", Offset = "0xC1FB10", VA = "0xC1FB10")]
	private static void Snow(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0xC1FE94", Offset = "0xC1FE94", VA = "0xC1FE94")]
	private static void Steel(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0xC20344", Offset = "0xC20344", VA = "0xC20344")]
	private static void Water(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0xC20804", Offset = "0xC20804", VA = "0xC20804")]
	private static void WoodThin(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0xC20CBC", Offset = "0xC20CBC", VA = "0xC20CBC")]
	private static void WoodThick(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0xC2117C", Offset = "0xC2117C", VA = "0xC2117C")]
	private static void WoodFloor(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xC21644", Offset = "0xC21644", VA = "0xC21644")]
	private static void WoodOnConcrete(ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xC21B08", Offset = "0xC21B08", VA = "0xC21B08")]
	public ONSPPropagationMaterial()
	{
	}
}
[Token(Token = "0x20000BB")]
public class ONSPPropagationSettings : MonoBehaviour
{
	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float quality;

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xC84308", Offset = "0xC84308", VA = "0xC84308")]
	private void Update()
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0xC843D0", Offset = "0xC843D0", VA = "0xC843D0")]
	public ONSPPropagationSettings()
	{
	}
}
[Token(Token = "0x20000BC")]
public sealed class ONSPSettings : ScriptableObject
{
	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int voiceLimit;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ONSPSettings instance;

	[Token(Token = "0x17000030")]
	public static ONSPSettings Instance
	{
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xC84A28", Offset = "0xC84A28", VA = "0xC84A28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0xC84B68", Offset = "0xC84B68", VA = "0xC84B68")]
	public ONSPSettings()
	{
	}
}
[Token(Token = "0x20000BD")]
public class ONSPVersion : MonoBehaviour
{
	[Token(Token = "0x40004BE")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[PreserveSig]
	[Token(Token = "0x60003C0")]
	[Address(RVA = "0xC84B78", Offset = "0xC84B78", VA = "0xC84B78")]
	private static extern void ONSP_GetVersion(int Major, int Minor, int Patch);

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0xC84C10", Offset = "0xC84C10", VA = "0xC84C10")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xC84D34", Offset = "0xC84D34", VA = "0xC84D34")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0xC84D38", Offset = "0xC84D38", VA = "0xC84D38")]
	private void Update()
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xC84D3C", Offset = "0xC84D3C", VA = "0xC84D3C")]
	public ONSPVersion()
	{
	}
}
[Token(Token = "0x20000BE")]
public class OculusHapticsController : MonoBehaviour
{
	[Token(Token = "0x20001B4")]
	public enum VibrationForce
	{
		[Token(Token = "0x4000A28")]
		Light,
		[Token(Token = "0x4000A29")]
		Medium,
		[Token(Token = "0x4000A2A")]
		Hard
	}

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRInput.Controller controllerMask;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRHapticsClip clipLight;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRHapticsClip clipMedium;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private OVRHapticsClip clipHard;

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0xC87B28", Offset = "0xC87B28", VA = "0xC87B28")]
	private void Start()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0xC87B2C", Offset = "0xC87B2C", VA = "0xC87B2C")]
	private void InitializeOVRHaptics()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0xC87D00", Offset = "0xC87D00", VA = "0xC87D00")]
	public void Vibrate(VibrationForce vibrationForce)
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0xC87DF8", Offset = "0xC87DF8", VA = "0xC87DF8")]
	public OculusHapticsController()
	{
	}
}
[Token(Token = "0x20000BF")]
public class OculusPlatformManager : MonoBehaviour
{
	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52CACC", Offset = "0x52CACC")]
	private static string <username>k__BackingField;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text UserNameText;

	[Token(Token = "0x17000031")]
	public static string username
	{
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xC87E00", Offset = "0xC87E00", VA = "0xC87E00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F550", Offset = "0x52F550")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xC87E4C", Offset = "0xC87E4C", VA = "0xC87E4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F560", Offset = "0x52F560")]
		private set
		{
		}
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0xC87EA4", Offset = "0xC87EA4", VA = "0xC87EA4")]
	private void Start()
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0xC87FC8", Offset = "0xC87FC8", VA = "0xC87FC8")]
	private void EntitlementCallback(Message msg)
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0xC881C0", Offset = "0xC881C0", VA = "0xC881C0")]
	public OculusPlatformManager()
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0xC881C8", Offset = "0xC881C8", VA = "0xC881C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52F570", Offset = "0x52F570")]
	private void <EntitlementCallback>b__6_0(Message<User> m)
	{
	}
}
[Token(Token = "0x20000C0")]
public class PauseController : MonoBehaviour
{
	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject PauseCanvas;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject MainRacketL;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject MainRacketR;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject DisplayRacketL;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject DisplayRacketR;

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x968B90", Offset = "0x968B90", VA = "0x968B90")]
	private void Start()
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x968B9C", Offset = "0x968B9C", VA = "0x968B9C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x968CC0", Offset = "0x968CC0", VA = "0x968CC0")]
	public void Menu()
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x968D34", Offset = "0x968D34", VA = "0x968D34")]
	public void Restart()
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x968DA8", Offset = "0x968DA8", VA = "0x968DA8")]
	public void Replay()
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x968E1C", Offset = "0x968E1C", VA = "0x968E1C")]
	public void RestartFreeHit()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x968E90", Offset = "0x968E90", VA = "0x968E90")]
	public void RestartBucketPong()
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x968F04", Offset = "0x968F04", VA = "0x968F04")]
	public void RestartClank()
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x968F78", Offset = "0x968F78", VA = "0x968F78")]
	public void RestartAO()
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x968FEC", Offset = "0x968FEC", VA = "0x968FEC")]
	public void RestartTinTin()
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x969060", Offset = "0x969060", VA = "0x969060")]
	public void RestartMegaMan()
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x9690D4", Offset = "0x9690D4", VA = "0x9690D4")]
	public void RestartBishop()
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x969148", Offset = "0x969148", VA = "0x969148")]
	public void Continue()
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x9691D4", Offset = "0x9691D4", VA = "0x9691D4")]
	public PauseController()
	{
	}
}
[Token(Token = "0x20000C1")]
public class PlayerBotAI : MonoBehaviour
{
	[Token(Token = "0x20001B5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B524", Offset = "0x52B524")]
	private sealed class <CancelSecondHit>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000CB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x865704", Offset = "0x865704", VA = "0x865704", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x86574C", Offset = "0x86574C", VA = "0x86574C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x865620", Offset = "0x865620", VA = "0x865620")]
		[DebuggerHidden]
		public <CancelSecondHit>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x86564C", Offset = "0x86564C", VA = "0x86564C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x865650", Offset = "0x865650", VA = "0x865650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x86570C", Offset = "0x86570C", VA = "0x86570C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B534", Offset = "0x52B534")]
	private sealed class <DetectHitTwice>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000CD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x86583C", Offset = "0x86583C", VA = "0x86583C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x865884", Offset = "0x865884", VA = "0x865884", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x865754", Offset = "0x865754", VA = "0x865754")]
		[DebuggerHidden]
		public <DetectHitTwice>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x865780", Offset = "0x865780", VA = "0x865780", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x865784", Offset = "0x865784", VA = "0x865784", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x865844", Offset = "0x865844", VA = "0x865844", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float speed;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float hitforce;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float hitHeight;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] aimTarget;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject Ball;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ClickSoundControl clickSoundControl;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform AIRacketPosition;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 targetPosition;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject DestroyBall;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ClickSoundControl ScoreSound;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject ShuttleCock;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform BotServePoint;

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x96961C", Offset = "0x96961C", VA = "0x96961C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x9697AC", Offset = "0x9697AC", VA = "0x9697AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x969928", Offset = "0x969928", VA = "0x969928")]
	private void MoveBot()
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x969A04", Offset = "0x969A04", VA = "0x969A04")]
	public void InstantiateBallBot()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x969B68", Offset = "0x969B68", VA = "0x969B68")]
	public void BotServe()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x969C4C", Offset = "0x969C4C", VA = "0x969C4C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x969F28", Offset = "0x969F28", VA = "0x969F28")]
	private void CheckHitDifficulty()
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x96A1C0", Offset = "0x96A1C0", VA = "0x96A1C0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F580", Offset = "0x52F580")]
	private IEnumerator CancelSecondHit()
	{
		return null;
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x96A108", Offset = "0x96A108", VA = "0x96A108")]
	private void DestroyBallE()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x96A0AC", Offset = "0x96A0AC", VA = "0x96A0AC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F5E8", Offset = "0x52F5E8")]
	private IEnumerator DetectHitTwice()
	{
		return null;
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x96A21C", Offset = "0x96A21C", VA = "0x96A21C")]
	public PlayerBotAI()
	{
	}
}
[Token(Token = "0x20000C2")]
public class RacketBox : MonoBehaviour
{
	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Rigidbody rigidbody;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform aimTarget;

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x96C01C", Offset = "0x96C01C", VA = "0x96C01C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x96C078", Offset = "0x96C078", VA = "0x96C078")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x96C07C", Offset = "0x96C07C", VA = "0x96C07C")]
	public Vector3 GetVelocityToHitTargetByTime(Vector3 startPosition, Vector3 targetPosition, Vector3 gravityBase, float timeToTarget)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x96C210", Offset = "0x96C210", VA = "0x96C210")]
	public RacketBox()
	{
	}
}
[Token(Token = "0x20000C3")]
public class RacketCubeFollower : MonoBehaviour
{
	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RacketBox RacketFollower;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 _velocity;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _sensitivity;

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x96C218", Offset = "0x96C218", VA = "0x96C218")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x96C274", Offset = "0x96C274", VA = "0x96C274")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x96C394", Offset = "0x96C394", VA = "0x96C394")]
	public void SetFollowTarget(RacketBox batFollower)
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x96C39C", Offset = "0x96C39C", VA = "0x96C39C")]
	public RacketCubeFollower()
	{
	}
}
[Token(Token = "0x20000C4")]
public class RacketHitAO : MonoBehaviour
{
	[Token(Token = "0x20001B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B544", Offset = "0x52B544")]
	private sealed class <CancelSecondHit>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000CF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x865970", Offset = "0x865970", VA = "0x865970", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x8659B8", Offset = "0x8659B8", VA = "0x8659B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x86588C", Offset = "0x86588C", VA = "0x86588C")]
		[DebuggerHidden]
		public <CancelSecondHit>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x8658B8", Offset = "0x8658B8", VA = "0x8658B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x8658BC", Offset = "0x8658BC", VA = "0x8658BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x865978", Offset = "0x865978", VA = "0x865978", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B554", Offset = "0x52B554")]
	private sealed class <DetectHitTwice>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000D1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000975")]
			[Address(RVA = "0x865AA8", Offset = "0x865AA8", VA = "0x865AA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x865AF0", Offset = "0x865AF0", VA = "0x865AF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x8659C0", Offset = "0x8659C0", VA = "0x8659C0")]
		[DebuggerHidden]
		public <DetectHitTwice>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x8659EC", Offset = "0x8659EC", VA = "0x8659EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x8659F0", Offset = "0x8659F0", VA = "0x8659F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x865AB0", Offset = "0x865AB0", VA = "0x865AB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float speed;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float hitforce;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float hitHeight;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] aimTarget;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject Ball;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ClickSoundControl clickSoundControl;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform AIRacketPosition;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 targetPosition;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject DestroyBall;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ClickSoundControl ScoreSound;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject ShuttleCock;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform BotServePoint;

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x96C3AC", Offset = "0x96C3AC", VA = "0x96C3AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x96C4A4", Offset = "0x96C4A4", VA = "0x96C4A4")]
	private void Update()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x96C620", Offset = "0x96C620", VA = "0x96C620")]
	private void MoveBot()
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x96C6FC", Offset = "0x96C6FC", VA = "0x96C6FC")]
	public void InstantiateBallBot()
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x96C860", Offset = "0x96C860", VA = "0x96C860")]
	public void BotServe()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x96C944", Offset = "0x96C944", VA = "0x96C944")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x96CD64", Offset = "0x96CD64", VA = "0x96CD64")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F650", Offset = "0x52F650")]
	private IEnumerator CancelSecondHit()
	{
		return null;
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x96CCAC", Offset = "0x96CCAC", VA = "0x96CCAC")]
	private void DestroyBallE()
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x96CC50", Offset = "0x96CC50", VA = "0x96CC50")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F6B8", Offset = "0x52F6B8")]
	private IEnumerator DetectHitTwice()
	{
		return null;
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x96CDC0", Offset = "0x96CDC0", VA = "0x96CDC0")]
	public RacketHitAO()
	{
	}
}
[Token(Token = "0x20000C5")]
public class RacketHitClank : MonoBehaviour
{
	[Token(Token = "0x20001B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B564", Offset = "0x52B564")]
	private sealed class <CancelSecondHit>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000D3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600097B")]
			[Address(RVA = "0x865BDC", Offset = "0x865BDC", VA = "0x865BDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x865C24", Offset = "0x865C24", VA = "0x865C24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x865AF8", Offset = "0x865AF8", VA = "0x865AF8")]
		[DebuggerHidden]
		public <CancelSecondHit>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x865B24", Offset = "0x865B24", VA = "0x865B24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x865B28", Offset = "0x865B28", VA = "0x865B28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x865BE4", Offset = "0x865BE4", VA = "0x865BE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001BA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B574", Offset = "0x52B574")]
	private sealed class <DetectHitTwice>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000D5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x865D14", Offset = "0x865D14", VA = "0x865D14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x865D5C", Offset = "0x865D5C", VA = "0x865D5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x865C2C", Offset = "0x865C2C", VA = "0x865C2C")]
		[DebuggerHidden]
		public <DetectHitTwice>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x865C58", Offset = "0x865C58", VA = "0x865C58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x865C5C", Offset = "0x865C5C", VA = "0x865C5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x865D1C", Offset = "0x865D1C", VA = "0x865D1C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float speed;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float hitforce;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float hitHeight;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] aimTarget;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject Ball;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ClickSoundControl clickSoundControl;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform AIRacketPosition;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 targetPosition;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject DestroyBall;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ClickSoundControl ScoreSound;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject ShuttleCock;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform BotServePoint;

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x96CDC8", Offset = "0x96CDC8", VA = "0x96CDC8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x96CEC0", Offset = "0x96CEC0", VA = "0x96CEC0")]
	private void Update()
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x96D03C", Offset = "0x96D03C", VA = "0x96D03C")]
	private void MoveBot()
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x96D118", Offset = "0x96D118", VA = "0x96D118")]
	public void InstantiateBallBot()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x96D27C", Offset = "0x96D27C", VA = "0x96D27C")]
	public void BotServe()
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x96D360", Offset = "0x96D360", VA = "0x96D360")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x96D780", Offset = "0x96D780", VA = "0x96D780")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F720", Offset = "0x52F720")]
	private IEnumerator CancelSecondHit()
	{
		return null;
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x96D6C8", Offset = "0x96D6C8", VA = "0x96D6C8")]
	private void DestroyBallE()
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x96D66C", Offset = "0x96D66C", VA = "0x96D66C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F788", Offset = "0x52F788")]
	private IEnumerator DetectHitTwice()
	{
		return null;
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x96D7DC", Offset = "0x96D7DC", VA = "0x96D7DC")]
	public RacketHitClank()
	{
	}
}
[Token(Token = "0x20000C6")]
public class RacketHitMegaMan : MonoBehaviour
{
	[Token(Token = "0x20001BB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B584", Offset = "0x52B584")]
	private sealed class <CancelSecondHit>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000D7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x865E48", Offset = "0x865E48", VA = "0x865E48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000989")]
			[Address(RVA = "0x865E90", Offset = "0x865E90", VA = "0x865E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x865D64", Offset = "0x865D64", VA = "0x865D64")]
		[DebuggerHidden]
		public <CancelSecondHit>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x865D90", Offset = "0x865D90", VA = "0x865D90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x865D94", Offset = "0x865D94", VA = "0x865D94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x865E50", Offset = "0x865E50", VA = "0x865E50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B594", Offset = "0x52B594")]
	private sealed class <DetectHitTwice>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000D9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600098D")]
			[Address(RVA = "0x865F80", Offset = "0x865F80", VA = "0x865F80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600098F")]
			[Address(RVA = "0x865FC8", Offset = "0x865FC8", VA = "0x865FC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x865E98", Offset = "0x865E98", VA = "0x865E98")]
		[DebuggerHidden]
		public <DetectHitTwice>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x865EC4", Offset = "0x865EC4", VA = "0x865EC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x865EC8", Offset = "0x865EC8", VA = "0x865EC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x865F88", Offset = "0x865F88", VA = "0x865F88", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float speed;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float hitforce;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float hitHeight;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] aimTarget;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject Ball;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private ClickSoundControl clickSoundControl;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform AIRacketPosition;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 targetPosition;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject DestroyBall;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ClickSoundControl ScoreSound;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject ShuttleCock;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform BotServePoint;

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x96D7E4", Offset = "0x96D7E4", VA = "0x96D7E4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x96D8DC", Offset = "0x96D8DC", VA = "0x96D8DC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x96DA58", Offset = "0x96DA58", VA = "0x96DA58")]
	private void MoveBot()
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x96DB34", Offset = "0x96DB34", VA = "0x96DB34")]
	public void InstantiateBallBot()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x96DC98", Offset = "0x96DC98", VA = "0x96DC98")]
	public void BotServe()
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x96DD7C", Offset = "0x96DD7C", VA = "0x96DD7C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x96E1A0", Offset = "0x96E1A0", VA = "0x96E1A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F7F0", Offset = "0x52F7F0")]
	private IEnumerator CancelSecondHit()
	{
		return null;
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x96E0E8", Offset = "0x96E0E8", VA = "0x96E0E8")]
	private void DestroyBallE()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x96E08C", Offset = "0x96E08C", VA = "0x96E08C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F858", Offset = "0x52F858")]
	private IEnumerator DetectHitTwice()
	{
		return null;
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x96E1FC", Offset = "0x96E1FC", VA = "0x96E1FC")]
	public RacketHitMegaMan()
	{
	}
}
[Token(Token = "0x20000C7")]
public class RacketHitOther : MonoBehaviour
{
	[Token(Token = "0x20001BD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B5A4", Offset = "0x52B5A4")]
	private sealed class <Vibrate>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000DB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000993")]
			[Address(RVA = "0x866220", Offset = "0x866220", VA = "0x866220", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000995")]
			[Address(RVA = "0x866268", Offset = "0x866268", VA = "0x866268", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x865FD0", Offset = "0x865FD0", VA = "0x865FD0")]
		[DebuggerHidden]
		public <Vibrate>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x865FFC", Offset = "0x865FFC", VA = "0x865FFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x866000", Offset = "0x866000", VA = "0x866000", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x866228", Offset = "0x866228", VA = "0x866228", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip RacketHitAudio;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject ShuttleCock;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Spawnpoint;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject Ball;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject Ring;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ClickSoundControl clickSoundControl;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ClickSoundControl MissSound;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject DestroyBall;

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x96E204", Offset = "0x96E204", VA = "0x96E204")]
	private void Start()
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x96E2A8", Offset = "0x96E2A8", VA = "0x96E2A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x96E458", Offset = "0x96E458", VA = "0x96E458")]
	public void InstantiateBall()
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x96E5A8", Offset = "0x96E5A8", VA = "0x96E5A8")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x96E650", Offset = "0x96E650", VA = "0x96E650")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F8C0", Offset = "0x52F8C0")]
	private IEnumerator Vibrate()
	{
		return null;
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x96E6AC", Offset = "0x96E6AC", VA = "0x96E6AC")]
	public RacketHitOther()
	{
	}
}
[Token(Token = "0x20000C8")]
public class RotateCharacter : MonoBehaviour
{
	[Token(Token = "0x6000414")]
	[Address(RVA = "0x972998", Offset = "0x972998", VA = "0x972998")]
	private void Start()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x97299C", Offset = "0x97299C", VA = "0x97299C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x972A5C", Offset = "0x972A5C", VA = "0x972A5C")]
	public RotateCharacter()
	{
	}
}
[Token(Token = "0x20000C9")]
public class CircleSlider : MonoBehaviour
{
	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image image;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text progress;

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x951038", Offset = "0x951038", VA = "0x951038")]
	private void Start()
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x951094", Offset = "0x951094", VA = "0x951094")]
	private void Update()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x9511D8", Offset = "0x9511D8", VA = "0x9511D8")]
	public CircleSlider()
	{
	}
}
[Token(Token = "0x20000CA")]
public class JustRotate : MonoBehaviour
{
	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool canRotate;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float speed;

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x96399C", Offset = "0x96399C", VA = "0x96399C")]
	private void Update()
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x963A3C", Offset = "0x963A3C", VA = "0x963A3C")]
	public JustRotate()
	{
	}
}
[Token(Token = "0x20000CB")]
public class PressedBtn : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Button btn;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform myIcon;

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x96AFF8", Offset = "0x96AFF8", VA = "0x96AFF8")]
	private void Start()
	{
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x96B098", Offset = "0x96B098", VA = "0x96B098")]
	public void OnClick()
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x96B140", Offset = "0x96B140", VA = "0x96B140")]
	public void OnPressed()
	{
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x96B1FC", Offset = "0x96B1FC", VA = "0x96B1FC", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x96B200", Offset = "0x96B200", VA = "0x96B200", Slot = "5")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x96B204", Offset = "0x96B204", VA = "0x96B204", Slot = "6")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x96B208", Offset = "0x96B208", VA = "0x96B208", Slot = "7")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x96B20C", Offset = "0x96B20C", VA = "0x96B20C")]
	public PressedBtn()
	{
	}
}
[Token(Token = "0x20000CC")]
public class SliderRunTo1 : MonoBehaviour
{
	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool b;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Slider slider;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float time;

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x974C50", Offset = "0x974C50", VA = "0x974C50")]
	private void Start()
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x974CAC", Offset = "0x974CAC", VA = "0x974CAC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x974D28", Offset = "0x974D28", VA = "0x974D28")]
	public SliderRunTo1()
	{
	}
}
[Token(Token = "0x20000CD")]
public class SliderValuePass : MonoBehaviour
{
	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Text progress;

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x974D40", Offset = "0x974D40", VA = "0x974D40")]
	private void Start()
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x974D9C", Offset = "0x974D9C", VA = "0x974D9C")]
	public void UpdateProgress(float content)
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x974EB8", Offset = "0x974EB8", VA = "0x974EB8")]
	public SliderValuePass()
	{
	}
}
[Token(Token = "0x20000CE")]
public class Scoreboard : MonoBehaviour
{
	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text PlayerScoreText;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Text BotScoreText;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text PlayerGamesWonText;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text BotGamesWonText;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Text NumberOfGamesText;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int PlayerScore;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int BotScore;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int PlayerGamesWon;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int BotGamesWon;

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x972ED4", Offset = "0x972ED4", VA = "0x972ED4")]
	private void Start()
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x972ED8", Offset = "0x972ED8", VA = "0x972ED8")]
	private void Update()
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x972EDC", Offset = "0x972EDC", VA = "0x972EDC")]
	private void CheckScore()
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x973150", Offset = "0x973150", VA = "0x973150")]
	public Scoreboard()
	{
	}
}
[Token(Token = "0x20000CF")]
public class allClear : MonoBehaviour
{
	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject clear;

	[Token(Token = "0x600042E")]
	[Address(RVA = "0xAEC798", Offset = "0xAEC798", VA = "0xAEC798")]
	private void Update()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0xAEC820", Offset = "0xAEC820", VA = "0xAEC820")]
	public allClear()
	{
	}
}
[Token(Token = "0x20000D0")]
public class Ball : MonoBehaviour
{
	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float strength;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxSpeed;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float minVelocity;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float maxVelocity;

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x9BC004", Offset = "0x9BC004", VA = "0x9BC004")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x9BC094", Offset = "0x9BC094", VA = "0x9BC094")]
	public Ball()
	{
	}
}
[Token(Token = "0x20000D1")]
public class BallOwner : MonoBehaviour
{
	[Token(Token = "0x6000432")]
	[Address(RVA = "0x9BC0A8", Offset = "0x9BC0A8", VA = "0x9BC0A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x9BC0AC", Offset = "0x9BC0AC", VA = "0x9BC0AC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x9BC0B0", Offset = "0x9BC0B0", VA = "0x9BC0B0")]
	public BallOwner()
	{
	}
}
[Token(Token = "0x20000D2")]
public class ballSetting : MonoBehaviour
{
	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ball;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Rigidbody rb;

	[Token(Token = "0x6000435")]
	[Address(RVA = "0xAECA64", Offset = "0xAECA64", VA = "0xAECA64")]
	private void Start()
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0xAECAC0", Offset = "0xAECAC0", VA = "0xAECAC0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0xAECB8C", Offset = "0xAECB8C", VA = "0xAECB8C")]
	public ballSetting()
	{
	}
}
[Token(Token = "0x20000D3")]
public class Bat : MonoBehaviour
{
	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float minVelocity;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxVelocity;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float hitThreshold;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float timeThresholdSeconds;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject ball;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public long lastHitInSeconds;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform hitPoint1;

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform hitPoint2;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform centerPoint;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float power;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private DateTime? lastHitAt;

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x9BC1A4", Offset = "0x9BC1A4", VA = "0x9BC1A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x9BC674", Offset = "0x9BC674", VA = "0x9BC674")]
	public Bat()
	{
	}
}
[Token(Token = "0x20000D4")]
public class BGSoundScript : MonoBehaviour
{
	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static BGSoundScript instance;

	[Token(Token = "0x17000032")]
	public static BGSoundScript Instance
	{
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x9BBDEC", Offset = "0x9BBDEC", VA = "0x9BBDEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x9BBDE8", Offset = "0x9BBDE8", VA = "0x9BBDE8")]
	private void Start()
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x9BBE50", Offset = "0x9BBE50", VA = "0x9BBE50")]
	private void Awake()
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x9BBFF4", Offset = "0x9BBFF4", VA = "0x9BBFF4")]
	private void Update()
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x9BBFF8", Offset = "0x9BBFF8", VA = "0x9BBFF8")]
	public BGSoundScript()
	{
	}
}
[Token(Token = "0x20000D5")]
public class blockSetting : MonoBehaviour
{
	[Token(Token = "0x6000440")]
	[Address(RVA = "0xAECB94", Offset = "0xAECB94", VA = "0xAECB94")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0xAECC14", Offset = "0xAECC14", VA = "0xAECC14")]
	public blockSetting()
	{
	}
}
[Token(Token = "0x20000D6")]
public class ClickSoundControl : MonoBehaviour
{
	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource ClickSound;

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x9511F0", Offset = "0x9511F0", VA = "0x9511F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x95124C", Offset = "0x95124C", VA = "0x95124C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x951250", Offset = "0x951250", VA = "0x951250")]
	public void PlaySound()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x9512F4", Offset = "0x9512F4", VA = "0x9512F4")]
	public void PauseSound()
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x951314", Offset = "0x951314", VA = "0x951314")]
	public ClickSoundControl()
	{
	}
}
[Token(Token = "0x20000D7")]
public class ContinuousMovement : MonoBehaviour
{
	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public XRNode inputSource;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private XRRig rig;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 inputAxis;

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x952F3C", Offset = "0x952F3C", VA = "0x952F3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x952F98", Offset = "0x952F98", VA = "0x952F98")]
	private void Update()
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x953034", Offset = "0x953034", VA = "0x953034")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x9530EC", Offset = "0x9530EC", VA = "0x9530EC")]
	public ContinuousMovement()
	{
	}
}
[Token(Token = "0x20000D8")]
public class FloorBlue : MonoBehaviour
{
	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ClickSoundControl ScoreSound;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject DestroyBall;

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x95B088", Offset = "0x95B088", VA = "0x95B088")]
	private void Start()
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x95B108", Offset = "0x95B108", VA = "0x95B108")]
	private void Update()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x95B10C", Offset = "0x95B10C", VA = "0x95B10C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x95B230", Offset = "0x95B230", VA = "0x95B230")]
	private void DestroyBallE()
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x95B2E8", Offset = "0x95B2E8", VA = "0x95B2E8")]
	public FloorBlue()
	{
	}
}
[Token(Token = "0x20000D9")]
public class FloorRed : MonoBehaviour
{
	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject DestroyBall;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ClickSoundControl MissSound;

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x95B2F0", Offset = "0x95B2F0", VA = "0x95B2F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x95B370", Offset = "0x95B370", VA = "0x95B370")]
	private void Update()
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x95B374", Offset = "0x95B374", VA = "0x95B374")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x95B498", Offset = "0x95B498", VA = "0x95B498")]
	private void DestroyBallE()
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x95B550", Offset = "0x95B550", VA = "0x95B550")]
	public FloorRed()
	{
	}
}
[Token(Token = "0x20000DA")]
public class HeadMovementController : MonoBehaviour
{
	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform rootObject;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform followObject;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector3 positionOffset;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Vector3 rotationOffset;

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector3 headBodyOffset;

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x95F03C", Offset = "0x95F03C", VA = "0x95F03C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x95F040", Offset = "0x95F040", VA = "0x95F040")]
	private void Update()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x95F044", Offset = "0x95F044", VA = "0x95F044")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x95F1E4", Offset = "0x95F1E4", VA = "0x95F1E4")]
	public HeadMovementController()
	{
	}
}
[Token(Token = "0x20000DB")]
public class InGameController : MonoBehaviour
{
	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int PlayerScore;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int BotScore;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int PlayerGamesWon;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int BotGamesWon;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject PlayerWonPanel;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject PlayerLosePanel;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject MainRacketL;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject MainRacketR;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject DisplayRacketL;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject DisplayRacketR;

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x95F1EC", Offset = "0x95F1EC", VA = "0x95F1EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x95F244", Offset = "0x95F244", VA = "0x95F244")]
	private void Start()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x95F344", Offset = "0x95F344", VA = "0x95F344")]
	private void Update()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x95F368", Offset = "0x95F368", VA = "0x95F368")]
	private void CheckScore()
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x95F5B0", Offset = "0x95F5B0", VA = "0x95F5B0")]
	private void GameController()
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x95F438", Offset = "0x95F438", VA = "0x95F438")]
	private void CheckWinner()
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x95F7B0", Offset = "0x95F7B0", VA = "0x95F7B0")]
	public void Replay()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x95F824", Offset = "0x95F824", VA = "0x95F824")]
	public void MainMenu()
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x95F898", Offset = "0x95F898", VA = "0x95F898")]
	public InGameController()
	{
	}
}
[Token(Token = "0x20000DC")]
public class LetDetector : MonoBehaviour
{
	[Token(Token = "0x20001BE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B5B4", Offset = "0x52B5B4")]
	private sealed class <LetShow>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LetDetector <>4__this;

		[Token(Token = "0x170000DD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x85FF54", Offset = "0x85FF54", VA = "0x85FF54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600099B")]
			[Address(RVA = "0x85FF9C", Offset = "0x85FF9C", VA = "0x85FF9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x85FE04", Offset = "0x85FE04", VA = "0x85FE04")]
		[DebuggerHidden]
		public <LetShow>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x85FE30", Offset = "0x85FE30", VA = "0x85FE30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x85FE34", Offset = "0x85FE34", VA = "0x85FE34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x85FF5C", Offset = "0x85FF5C", VA = "0x85FF5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject LetText;

	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject LetText2;

	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int Let;

	[Token(Token = "0x6000462")]
	[Address(RVA = "0xC08FE8", Offset = "0xC08FE8", VA = "0xC08FE8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0xC08FEC", Offset = "0xC08FEC", VA = "0xC08FEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0xC08FF0", Offset = "0xC08FF0", VA = "0xC08FF0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0xC090B0", Offset = "0xC090B0", VA = "0xC090B0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F928", Offset = "0x52F928")]
	private IEnumerator LetShow()
	{
		return null;
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0xC09124", Offset = "0xC09124", VA = "0xC09124")]
	public LetDetector()
	{
	}
}
[Token(Token = "0x20000DD")]
public class MusicControl : MonoBehaviour
{
	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Toggle MusicSwitch;

	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource MainSoundtrack;

	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioSource ClickSound;

	[Token(Token = "0x6000467")]
	[Address(RVA = "0xC13654", Offset = "0xC13654", VA = "0xC13654")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0xC13798", Offset = "0xC13798", VA = "0xC13798")]
	private void Start()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0xC1379C", Offset = "0xC1379C", VA = "0xC1379C")]
	private void Update()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0xC137A0", Offset = "0xC137A0", VA = "0xC137A0")]
	public void MusicBool(bool mb)
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0xC138A0", Offset = "0xC138A0", VA = "0xC138A0")]
	public MusicControl()
	{
	}
}
[Token(Token = "0x20000DE")]
public class MusicControlScript : MonoBehaviour
{
	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource MainMusicAudio;

	[Token(Token = "0x600046C")]
	[Address(RVA = "0xC138A8", Offset = "0xC138A8", VA = "0xC138A8")]
	private void Start()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0xC13978", Offset = "0xC13978", VA = "0xC13978")]
	private void Update()
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0xC1397C", Offset = "0xC1397C", VA = "0xC1397C")]
	public MusicControlScript()
	{
	}
}
[Token(Token = "0x20000DF")]
public class OutOfLine : MonoBehaviour
{
	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject DestroyBall;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int GetOwnerShip;

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ClickSoundControl ScoreSound;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ClickSoundControl MissSound;

	[Token(Token = "0x600046F")]
	[Address(RVA = "0xC8A014", Offset = "0xC8A014", VA = "0xC8A014")]
	private void Start()
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0xC8A0C4", Offset = "0xC8A0C4", VA = "0xC8A0C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0xC8A0C8", Offset = "0xC8A0C8", VA = "0xC8A0C8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0xC8A2A8", Offset = "0xC8A2A8", VA = "0xC8A2A8")]
	private void DestroyBallE()
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0xC8A360", Offset = "0xC8A360", VA = "0xC8A360")]
	public OutOfLine()
	{
	}
}
[Token(Token = "0x20000E0")]
public class rackets : MonoBehaviour
{
	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject racket;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 lastPosition;

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x85D2BC", Offset = "0x85D2BC", VA = "0x85D2BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x85D2F8", Offset = "0x85D2F8", VA = "0x85D2F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x85D444", Offset = "0x85D444", VA = "0x85D444")]
	public rackets()
	{
	}
}
[Token(Token = "0x20000E1")]
public class SCController : MonoBehaviour
{
	[Token(Token = "0x6000477")]
	[Address(RVA = "0x972A64", Offset = "0x972A64", VA = "0x972A64")]
	private void Start()
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x972A68", Offset = "0x972A68", VA = "0x972A68")]
	private void Update()
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x972C88", Offset = "0x972C88", VA = "0x972C88")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x972DBC", Offset = "0x972DBC", VA = "0x972DBC")]
	public SCController()
	{
	}
}
[Token(Token = "0x20000E2")]
public class SoundControl : MonoBehaviour
{
	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Toggle SoundSwitch;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource ClickSound;

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x976A2C", Offset = "0x976A2C", VA = "0x976A2C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x976B40", Offset = "0x976B40", VA = "0x976B40")]
	private void Start()
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x976B44", Offset = "0x976B44", VA = "0x976B44")]
	private void Update()
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x976B48", Offset = "0x976B48", VA = "0x976B48")]
	public void SoundBool(bool sb)
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x976BE4", Offset = "0x976BE4", VA = "0x976BE4")]
	public SoundControl()
	{
	}
}
[Token(Token = "0x20000E3")]
public class SplashScreenControl : MonoBehaviour
{
	[Token(Token = "0x20001BF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B5C4", Offset = "0x52B5C4")]
	private sealed class <LoginFBScreen>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000DF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600099F")]
			[Address(RVA = "0x867800", Offset = "0x867800", VA = "0x867800", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x867848", Offset = "0x867848", VA = "0x867848", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x8676F4", Offset = "0x8676F4", VA = "0x8676F4")]
		[DebuggerHidden]
		public <LoginFBScreen>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x867720", Offset = "0x867720", VA = "0x867720", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x867724", Offset = "0x867724", VA = "0x867724", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x867808", Offset = "0x867808", VA = "0x867808", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Image Logo;

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x979470", Offset = "0x979470", VA = "0x979470")]
	private void Start()
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x97955C", Offset = "0x97955C", VA = "0x97955C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x9794E8", Offset = "0x9794E8", VA = "0x9794E8")]
	public void SSplash()
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x979560", Offset = "0x979560", VA = "0x979560")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F990", Offset = "0x52F990")]
	private IEnumerator LoginFBScreen()
	{
		return null;
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x9795BC", Offset = "0x9795BC", VA = "0x9795BC")]
	public SplashScreenControl()
	{
	}
}
[Token(Token = "0x20000E4")]
public class VibrateRacket : MonoBehaviour
{
	[Token(Token = "0x20001C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B5D4", Offset = "0x52B5D4")]
	private sealed class <CancelSecondHit>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000E1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x11A6E68", Offset = "0x11A6E68", VA = "0x11A6E68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x11A6EB0", Offset = "0x11A6EB0", VA = "0x11A6EB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x11A6D84", Offset = "0x11A6D84", VA = "0x11A6D84")]
		[DebuggerHidden]
		public <CancelSecondHit>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x11A6DB0", Offset = "0x11A6DB0", VA = "0x11A6DB0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x11A6DB4", Offset = "0x11A6DB4", VA = "0x11A6DB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x11A6E70", Offset = "0x11A6E70", VA = "0x11A6E70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001C1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B5E4", Offset = "0x52B5E4")]
	private sealed class <DetectHitTwice>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000E3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x11A6FA0", Offset = "0x11A6FA0", VA = "0x11A6FA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x11A6FE8", Offset = "0x11A6FE8", VA = "0x11A6FE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x11A6EB8", Offset = "0x11A6EB8", VA = "0x11A6EB8")]
		[DebuggerHidden]
		public <DetectHitTwice>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x11A6EE4", Offset = "0x11A6EE4", VA = "0x11A6EE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x11A6EE8", Offset = "0x11A6EE8", VA = "0x11A6EE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x11A6FA8", Offset = "0x11A6FA8", VA = "0x11A6FA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B5F4", Offset = "0x52B5F4")]
	private sealed class <Vibrate>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x170000E5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x11A7240", Offset = "0x11A7240", VA = "0x11A7240", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x11A7288", Offset = "0x11A7288", VA = "0x11A7288", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x11A6FF0", Offset = "0x11A6FF0", VA = "0x11A6FF0")]
		[DebuggerHidden]
		public <Vibrate>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x11A701C", Offset = "0x11A701C", VA = "0x11A701C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x11A7020", Offset = "0x11A7020", VA = "0x11A7020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x11A7248", Offset = "0x11A7248", VA = "0x11A7248", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip RacketHitAudio;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource RacketHit;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject ShuttleCock;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject Spawnpoint;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject Ball;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject Ring;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ClickSoundControl clickSoundControl;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ClickSoundControl MissSound;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject DestroyBall;

	[Token(Token = "0x6000485")]
	[Address(RVA = "0xAEAAA4", Offset = "0xAEAAA4", VA = "0xAEAAA4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0xAEAB74", Offset = "0xAEAB74", VA = "0xAEAB74")]
	private void Update()
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0xAEAD60", Offset = "0xAEAD60", VA = "0xAEAD60")]
	public void InstantiateBall()
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0xAEAEB0", Offset = "0xAEAEB0", VA = "0xAEAEB0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0xAEB1C0", Offset = "0xAEB1C0", VA = "0xAEB1C0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52F9F8", Offset = "0x52F9F8")]
	private IEnumerator CancelSecondHit()
	{
		return null;
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0xAEB108", Offset = "0xAEB108", VA = "0xAEB108")]
	private void DestroyBallE()
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0xAEB0AC", Offset = "0xAEB0AC", VA = "0xAEB0AC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52FA60", Offset = "0x52FA60")]
	private IEnumerator DetectHitTwice()
	{
		return null;
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0xAEB050", Offset = "0xAEB050", VA = "0xAEB050")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52FAC8", Offset = "0x52FAC8")]
	private IEnumerator Vibrate()
	{
		return null;
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0xAEB21C", Offset = "0xAEB21C", VA = "0xAEB21C")]
	public VibrateRacket()
	{
	}
}
[Token(Token = "0x20000E5")]
public class VibrateRacket2 : MonoBehaviour
{
	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource RacketHit2;

	[Token(Token = "0x600048E")]
	[Address(RVA = "0xAEB224", Offset = "0xAEB224", VA = "0xAEB224")]
	private void Start()
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0xAEB280", Offset = "0xAEB280", VA = "0xAEB280")]
	private void Update()
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0xAEB284", Offset = "0xAEB284", VA = "0xAEB284")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0xAEB490", Offset = "0xAEB490", VA = "0xAEB490")]
	public VibrateRacket2()
	{
	}
}
[Token(Token = "0x20000E6")]
public class VibrationManager : MonoBehaviour
{
	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static VibrationManager singleton;

	[Token(Token = "0x6000492")]
	[Address(RVA = "0xAEB498", Offset = "0xAEB498", VA = "0xAEB498")]
	private void Start()
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0xAEB5A0", Offset = "0xAEB5A0", VA = "0xAEB5A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0xAEB350", Offset = "0xAEB350", VA = "0xAEB350")]
	public void TriggerVibration(int iteration, int frequency, int strength, OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0xAEB5A4", Offset = "0xAEB5A4", VA = "0xAEB5A4")]
	public void TriggerVibrationSound(AudioClip vibrationAudio, OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0xAEB694", Offset = "0xAEB694", VA = "0xAEB694")]
	public VibrationManager()
	{
	}
}
[Token(Token = "0x20000E7")]
public class SFXControl : MonoBehaviour
{
	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource SFXSound;

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x972DC4", Offset = "0x972DC4", VA = "0x972DC4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x972E24", Offset = "0x972E24", VA = "0x972E24")]
	public void PlaySound()
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x972EC8", Offset = "0x972EC8", VA = "0x972EC8")]
	private void Update()
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x972ECC", Offset = "0x972ECC", VA = "0x972ECC")]
	public SFXControl()
	{
	}
}
[Token(Token = "0x20000E8")]
public class ShowTargetScore : MonoBehaviour
{
	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMesh ScoresText;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh MissesText;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMesh BucketHSText;

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x973724", Offset = "0x973724", VA = "0x973724")]
	private void Start()
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x973728", Offset = "0x973728", VA = "0x973728")]
	private void Update()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x973870", Offset = "0x973870", VA = "0x973870")]
	public ShowTargetScore()
	{
	}
}
[Token(Token = "0x20000E9")]
public class TargetBucket : MonoBehaviour
{
	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource enterSound;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Bucket;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject DestroyBall;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ClickSoundControl clickSoundControl;

	[Token(Token = "0x600049E")]
	[Address(RVA = "0xAE0570", Offset = "0xAE0570", VA = "0xAE0570")]
	private void Start()
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0xAE0620", Offset = "0xAE0620", VA = "0xAE0620")]
	private void Update()
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0xAE0624", Offset = "0xAE0624", VA = "0xAE0624")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0xAE0874", Offset = "0xAE0874", VA = "0xAE0874")]
	public TargetBucket()
	{
	}
}
[Token(Token = "0x20000EA")]
public class TargetManager : MonoBehaviour
{
	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] SpawnPoints;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject SpawnBucket;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Bucket;

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0xAE087C", Offset = "0xAE087C", VA = "0xAE087C")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0xAE08F4", Offset = "0xAE08F4", VA = "0xAE08F4")]
	private void Update()
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0xAE0A90", Offset = "0xAE0A90", VA = "0xAE0A90")]
	public TargetManager()
	{
	}
}
[Token(Token = "0x20000EB")]
public class TargetMiss : MonoBehaviour
{
	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject DestroyBall;

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0xAE0A98", Offset = "0xAE0A98", VA = "0xAE0A98")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0xAE0A9C", Offset = "0xAE0A9C", VA = "0xAE0A9C")]
	private void Update()
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0xAE0AA0", Offset = "0xAE0AA0", VA = "0xAE0AA0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0xAE0B64", Offset = "0xAE0B64", VA = "0xAE0B64")]
	private void DestroyBallE()
	{
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0xAE0BD4", Offset = "0xAE0BD4", VA = "0xAE0BD4")]
	public TargetMiss()
	{
	}
}
[Token(Token = "0x20000EC")]
public class ChatController : MonoBehaviour
{
	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_InputField ChatInputField;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_Text ChatDisplayOutput;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Scrollbar ChatScrollbar;

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x950A80", Offset = "0x950A80", VA = "0x950A80")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x950B44", Offset = "0x950B44", VA = "0x950B44")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x950C08", Offset = "0x950C08", VA = "0x950C08")]
	private void AddToChatOutput(string newText)
	{
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x951030", Offset = "0x951030", VA = "0x951030")]
	public ChatController()
	{
	}
}
[Token(Token = "0x20000ED")]
public class DropdownSample : MonoBehaviour
{
	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI text;

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TMP_Dropdown dropdownWithoutPlaceholder;

	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Dropdown dropdownWithPlaceholder;

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x958C60", Offset = "0x958C60", VA = "0x958C60")]
	public void OnButtonClick()
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x958D74", Offset = "0x958D74", VA = "0x958D74")]
	public DropdownSample()
	{
	}
}
[Token(Token = "0x20000EE")]
public class EnvMapAnimator : MonoBehaviour
{
	[Token(Token = "0x20001C3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B604", Offset = "0x52B604")]
	private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnvMapAnimator <>4__this;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Matrix4x4 <matrix>5__2;

		[Token(Token = "0x170000E7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x85EE1C", Offset = "0x85EE1C", VA = "0x85EE1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x85EE64", Offset = "0x85EE64", VA = "0x85EE64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x85EC40", Offset = "0x85EC40", VA = "0x85EC40")]
		[DebuggerHidden]
		public <Start>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x85EC6C", Offset = "0x85EC6C", VA = "0x85EC6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x85EC70", Offset = "0x85EC70", VA = "0x85EC70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x85EE24", Offset = "0x85EE24", VA = "0x85EE24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 RotationSpeeds;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TMP_Text m_textMeshPro;

	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material m_material;

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x958D7C", Offset = "0x958D7C", VA = "0x958D7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x958DF4", Offset = "0x958DF4", VA = "0x958DF4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52FB30", Offset = "0x52FB30")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x958E68", Offset = "0x958E68", VA = "0x958E68")]
	public EnvMapAnimator()
	{
	}
}
[Token(Token = "0x20000EF")]
public class TrainingDifficulty : MonoBehaviour
{
	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Text DText;

	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Button EasyBTN;

	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Button MediumBTN;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Button HardBTN;

	[Token(Token = "0x400057E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Button ProfessionalBTN;

	[Token(Token = "0x400057F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Button ChampionBTN;

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0xAE8754", Offset = "0xAE8754", VA = "0xAE8754")]
	private void Start()
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0xAE8AF8", Offset = "0xAE8AF8", VA = "0xAE8AF8")]
	private void Update()
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0xAE8AFC", Offset = "0xAE8AFC", VA = "0xAE8AFC")]
	public void EasyMode()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0xAE8BE4", Offset = "0xAE8BE4", VA = "0xAE8BE4")]
	public void MediumMode()
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0xAE8CCC", Offset = "0xAE8CCC", VA = "0xAE8CCC")]
	public void HardMode()
	{
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0xAE8DB4", Offset = "0xAE8DB4", VA = "0xAE8DB4")]
	public void ProfessionalMode()
	{
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0xAE8E9C", Offset = "0xAE8E9C", VA = "0xAE8E9C")]
	public void ChampionMode()
	{
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0xAE8F84", Offset = "0xAE8F84", VA = "0xAE8F84")]
	public void OpenTraining()
	{
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0xAE8FF8", Offset = "0xAE8FF8", VA = "0xAE8FF8")]
	public TrainingDifficulty()
	{
	}
}
[Token(Token = "0x20000F0")]
public class UIActivate : MonoBehaviour
{
	[Token(Token = "0x4000580")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ItemShopCanvas;

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject CustomizeCanvas;

	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject MainCanvas;

	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject SettingsCanvas;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject LanguagePanel;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject HelpCanvas;

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject OtherModesCanvas;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject CampaignCanvas;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject TrainingCanvas;

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0xAE9000", Offset = "0xAE9000", VA = "0xAE9000")]
	private void Start()
	{
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0xAE9004", Offset = "0xAE9004", VA = "0xAE9004")]
	private void Update()
	{
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0xAE9008", Offset = "0xAE9008", VA = "0xAE9008")]
	public void ItemShopCanvasOpen()
	{
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0xAE902C", Offset = "0xAE902C", VA = "0xAE902C")]
	public void ItemShopCanvasClose()
	{
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0xAE9050", Offset = "0xAE9050", VA = "0xAE9050")]
	public void CustomizeCanvasOpen()
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0xAE9074", Offset = "0xAE9074", VA = "0xAE9074")]
	public void CustomizeCanvasClose()
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0xAE9098", Offset = "0xAE9098", VA = "0xAE9098")]
	public void OpenSettings()
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0xAE9104", Offset = "0xAE9104", VA = "0xAE9104")]
	public void CloseSettings()
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0xAE9148", Offset = "0xAE9148", VA = "0xAE9148")]
	public void OpenLanguage()
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0xAE918C", Offset = "0xAE918C", VA = "0xAE918C")]
	public void CloseLanguage()
	{
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0xAE91D0", Offset = "0xAE91D0", VA = "0xAE91D0")]
	public void OpenHelp()
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0xAE923C", Offset = "0xAE923C", VA = "0xAE923C")]
	public void CloseHelp()
	{
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0xAE9280", Offset = "0xAE9280", VA = "0xAE9280")]
	public void OpenOtherModes()
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0xAE92EC", Offset = "0xAE92EC", VA = "0xAE92EC")]
	public void CloseOtherModes()
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0xAE9330", Offset = "0xAE9330", VA = "0xAE9330")]
	public void OpenCampaign()
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0xAE939C", Offset = "0xAE939C", VA = "0xAE939C")]
	public void CloseCampaign()
	{
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0xAE93E0", Offset = "0xAE93E0", VA = "0xAE93E0")]
	public void OpenTraining()
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0xAE944C", Offset = "0xAE944C", VA = "0xAE944C")]
	public void CloseTraining()
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0xAE9490", Offset = "0xAE9490", VA = "0xAE9490")]
	public void TargetPractice()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0xAE9504", Offset = "0xAE9504", VA = "0xAE9504")]
	public void BucketPong()
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0xAE9578", Offset = "0xAE9578", VA = "0xAE9578")]
	public void FreeHit()
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0xAE95EC", Offset = "0xAE95EC", VA = "0xAE95EC")]
	public UIActivate()
	{
	}
}
[Token(Token = "0x20000F1")]
public class UnlockCharacter : MonoBehaviour
{
	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button ClankSelectBTN;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Button AOSelectBTN;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Button TinTinSelectBTN;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Button MegaManSelectBTN;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Button BishopSelectBTN;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject CI;

	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject AOI;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject TTI;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject MMI;

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject BI;

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0xAE95F4", Offset = "0xAE95F4", VA = "0xAE95F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0xAE9870", Offset = "0xAE9870", VA = "0xAE9870")]
	private void Update()
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0xAE9AEC", Offset = "0xAE9AEC", VA = "0xAE9AEC")]
	public UnlockCharacter()
	{
	}
}
namespace TMPro
{
	[Serializable]
	[Token(Token = "0x20000F2")]
	public class TMP_DigitValidator : TMP_InputValidator
	{
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x9798E8", Offset = "0x9798E8", VA = "0x9798E8", Slot = "4")]
		public override char Validate(string text, int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x979960", Offset = "0x979960", VA = "0x979960")]
		public TMP_DigitValidator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F3")]
	public class TMP_PhoneNumberValidator : TMP_InputValidator
	{
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xADBA20", Offset = "0xADBA20", VA = "0xADBA20", Slot = "4")]
		public override char Validate(string text, int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xADBE28", Offset = "0xADBE28", VA = "0xADBE28")]
		public TMP_PhoneNumberValidator()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Serializable]
		[Token(Token = "0x20001C4")]
		public class CharacterSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x867880", Offset = "0x867880", VA = "0x867880")]
			public CharacterSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C5")]
		public class SpriteSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x86797C", Offset = "0x86797C", VA = "0x86797C")]
			public SpriteSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C6")]
		public class WordSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x8679D0", Offset = "0x8679D0", VA = "0x8679D0")]
			public WordSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C7")]
		public class LineSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x8678D4", Offset = "0x8678D4", VA = "0x8678D4")]
			public LineSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001C8")]
		public class LinkSelectionEvent : UnityEvent<string, string, int>
		{
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x867928", Offset = "0x867928", VA = "0x867928")]
			public LinkSelectionEvent()
			{
			}
		}

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterSelectionEvent m_OnCharacterSelection;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpriteSelectionEvent m_OnSpriteSelection;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WordSelectionEvent m_OnWordSelection;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LineSelectionEvent m_OnLineSelection;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LinkSelectionEvent m_OnLinkSelection;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Camera;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas m_Canvas;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_selectedLink;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_lastCharIndex;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_lastWordIndex;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_lastLineIndex;

		[Token(Token = "0x17000033")]
		public CharacterSelectionEvent onCharacterSelection
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xADCF70", Offset = "0xADCF70", VA = "0xADCF70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xADCF78", Offset = "0xADCF78", VA = "0xADCF78")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public SpriteSelectionEvent onSpriteSelection
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xADCF80", Offset = "0xADCF80", VA = "0xADCF80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0xADCF88", Offset = "0xADCF88", VA = "0xADCF88")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public WordSelectionEvent onWordSelection
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xADCF90", Offset = "0xADCF90", VA = "0xADCF90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xADCF98", Offset = "0xADCF98", VA = "0xADCF98")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public LineSelectionEvent onLineSelection
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xADCFA0", Offset = "0xADCFA0", VA = "0xADCFA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0xADCFA8", Offset = "0xADCFA8", VA = "0xADCFA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public LinkSelectionEvent onLinkSelection
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0xADCFB0", Offset = "0xADCFB0", VA = "0xADCFB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0xADCFB8", Offset = "0xADCFB8", VA = "0xADCFB8")]
			set
			{
			}
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xADCFC0", Offset = "0xADCFC0", VA = "0xADCFC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xADD154", Offset = "0xADD154", VA = "0xADD154")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xADD894", Offset = "0xADD894", VA = "0xADD894", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xADD898", Offset = "0xADD898", VA = "0xADD898", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xADD600", Offset = "0xADD600", VA = "0xADD600")]
		private void SendOnCharacterSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xADD678", Offset = "0xADD678", VA = "0xADD678")]
		private void SendOnSpriteSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xADD6F0", Offset = "0xADD6F0", VA = "0xADD6F0")]
		private void SendOnWordSelection(string word, int charIndex, int length)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xADD77C", Offset = "0xADD77C", VA = "0xADD77C")]
		private void SendOnLineSelection(string line, int charIndex, int length)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xADD808", Offset = "0xADD808", VA = "0xADD808")]
		private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xADD89C", Offset = "0xADD89C", VA = "0xADD89C")]
		public TMP_TextEventHandler()
		{
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x20000F5")]
	public class Benchmark01 : MonoBehaviour
	{
		[Token(Token = "0x20001C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B614", Offset = "0x52B614")]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Benchmark01 <>4__this;

			[Token(Token = "0x4000A4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x170000E9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C2")]
				[Address(RVA = "0x85DDC0", Offset = "0x85DDC0", VA = "0x85DDC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009C4")]
				[Address(RVA = "0x85DE08", Offset = "0x85DE08", VA = "0x85DE08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x85D828", Offset = "0x85D828", VA = "0x85D828")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x85D854", Offset = "0x85D854", VA = "0x85D854", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x85D858", Offset = "0x85D858", VA = "0x85D858", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x85DDC8", Offset = "0x85DDC8", VA = "0x85DDC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Font TextMeshFont;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextContainer m_textContainer;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMesh m_textMesh;

		[Token(Token = "0x40005A5")]
		private const string label01 = "The <#0050FF>count is: </color>{0}";

		[Token(Token = "0x40005A6")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x9BC690", Offset = "0x9BC690", VA = "0x9BC690")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52FB98", Offset = "0x52FB98")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x9BC704", Offset = "0x9BC704", VA = "0x9BC704")]
		public Benchmark01()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class Benchmark01_UGUI : MonoBehaviour
	{
		[Token(Token = "0x20001CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B624", Offset = "0x52B624")]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Benchmark01_UGUI <>4__this;

			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x170000EB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C8")]
				[Address(RVA = "0x85E2A4", Offset = "0x85E2A4", VA = "0x85E2A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009CA")]
				[Address(RVA = "0x85E2EC", Offset = "0x85E2EC", VA = "0x85E2EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x85DE10", Offset = "0x85DE10", VA = "0x85DE10")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x85DE3C", Offset = "0x85DE3C", VA = "0x85DE3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x85DE40", Offset = "0x85DE40", VA = "0x85DE40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x85E2AC", Offset = "0x85E2AC", VA = "0x85E2AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Canvas canvas;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Font TextMeshFont;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI m_textMeshPro;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text m_textMesh;

		[Token(Token = "0x40005AF")]
		private const string label01 = "The <#0050FF>count is: </color>";

		[Token(Token = "0x40005B0")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x9BC70C", Offset = "0x9BC70C", VA = "0x9BC70C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52FC00", Offset = "0x52FC00")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x9BC780", Offset = "0x9BC780", VA = "0x9BC780")]
		public Benchmark01_UGUI()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class Benchmark02 : MonoBehaviour
	{
		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x9BC788", Offset = "0x9BC788", VA = "0x9BC788")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x9BCDB8", Offset = "0x9BCDB8", VA = "0x9BCDB8")]
		public Benchmark02()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class Benchmark03 : MonoBehaviour
	{
		[Token(Token = "0x20001CB")]
		public enum BenchmarkType
		{
			[Token(Token = "0x4000A55")]
			TMP_SDF_MOBILE,
			[Token(Token = "0x4000A56")]
			TMP_SDF__MOBILE_SSD,
			[Token(Token = "0x4000A57")]
			TMP_SDF,
			[Token(Token = "0x4000A58")]
			TMP_BITMAP_MOBILE,
			[Token(Token = "0x4000A59")]
			TEXTMESH_BITMAP
		}

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int NumberOfSamples;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BenchmarkType Benchmark;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Font SourceFont;

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x9BCDC8", Offset = "0x9BCDC8", VA = "0x9BCDC8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x9BCDCC", Offset = "0x9BCDCC", VA = "0x9BCDCC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x9BD260", Offset = "0x9BD260", VA = "0x9BD260")]
		public Benchmark03()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class Benchmark04 : MonoBehaviour
	{
		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int MinPointSize;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int MaxPointSize;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int Steps;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform m_Transform;

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x9BD270", Offset = "0x9BD270", VA = "0x9BD270")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x9BD584", Offset = "0x9BD584", VA = "0x9BD584")]
		public Benchmark04()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class CameraController : MonoBehaviour
	{
		[Token(Token = "0x20001CC")]
		public enum CameraModes
		{
			[Token(Token = "0x4000A5B")]
			Follow,
			[Token(Token = "0x4000A5C")]
			Isometric,
			[Token(Token = "0x4000A5D")]
			Free
		}

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform cameraTransform;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform dummyTarget;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform CameraTarget;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float FollowDistance;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float MaxFollowDistance;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float MinFollowDistance;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float ElevationAngle;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MaxElevationAngle;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MinElevationAngle;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OrbitalAngle;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public CameraModes CameraMode;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool MovementSmoothing;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool RotationSmoothing;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool previousSmoothing;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float MovementSmoothingValue;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float RotationSmoothingValue;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float MoveSensitivity;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 currentVelocity;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 desiredPosition;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float mouseX;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float mouseY;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 moveVector;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float mouseWheel;

		[Token(Token = "0x40005D6")]
		private const string event_SmoothingValue = "Slider - Smoothing Value";

		[Token(Token = "0x40005D7")]
		private const string event_FollowDistance = "Slider - Camera Zoom";

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x9C7738", Offset = "0x9C7738", VA = "0x9C7738")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x9C77B4", Offset = "0x9C77B4", VA = "0x9C77B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x9C7888", Offset = "0x9C7888", VA = "0x9C7888")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x9C7BA0", Offset = "0x9C7BA0", VA = "0x9C7BA0")]
		private void GetPlayerInput()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x9C8320", Offset = "0x9C8320", VA = "0x9C8320")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class ObjectSpin : MonoBehaviour
	{
		[Token(Token = "0x20001CD")]
		public enum MotionType
		{
			[Token(Token = "0x4000A5F")]
			Rotation,
			[Token(Token = "0x4000A60")]
			BackAndForth,
			[Token(Token = "0x4000A61")]
			Translation
		}

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float SpinSpeed;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int RotationRange;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_transform;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_time;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_prevPOS;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_initial_Rotation;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_initial_Position;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Color32 m_lightColor;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int frames;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MotionType Motion;

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xC878A0", Offset = "0xC878A0", VA = "0xC878A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xC879C8", Offset = "0xC879C8", VA = "0xC879C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xC87B14", Offset = "0xC87B14", VA = "0xC87B14")]
		public ObjectSpin()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class ShaderPropAnimator : MonoBehaviour
	{
		[Token(Token = "0x20001CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B634", Offset = "0x52B634")]
		private sealed class <AnimateProperties>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShaderPropAnimator <>4__this;

			[Token(Token = "0x170000ED")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009CE")]
				[Address(RVA = "0x8665D8", Offset = "0x8665D8", VA = "0x8665D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D0")]
				[Address(RVA = "0x866620", Offset = "0x866620", VA = "0x866620", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x866448", Offset = "0x866448", VA = "0x866448")]
			[DebuggerHidden]
			public <AnimateProperties>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x866474", Offset = "0x866474", VA = "0x866474", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x866478", Offset = "0x866478", VA = "0x866478", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x8665E0", Offset = "0x8665E0", VA = "0x8665E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer m_Renderer;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve GlowCurve;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_frame;

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x97360C", Offset = "0x97360C", VA = "0x97360C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x97367C", Offset = "0x97367C", VA = "0x97367C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x9736A8", Offset = "0x9736A8", VA = "0x9736A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52FC68", Offset = "0x52FC68")]
		private IEnumerator AnimateProperties()
		{
			return null;
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x97371C", Offset = "0x97371C", VA = "0x97371C")]
		public ShaderPropAnimator()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class SimpleScript : MonoBehaviour
	{
		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x40005E7")]
		private const string label = "The <#0050FF>count is: </color>{0:2}";

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_frame;

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x974730", Offset = "0x974730", VA = "0x974730")]
		private void Start()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x9747E8", Offset = "0x9747E8", VA = "0x9747E8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x974880", Offset = "0x974880", VA = "0x974880")]
		public SimpleScript()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class SkewTextExample : MonoBehaviour
	{
		[Token(Token = "0x20001CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B644", Offset = "0x52B644")]
		private sealed class <WarpText>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkewTextExample <>4__this;

			[Token(Token = "0x4000A68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x4000A69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <old_ShearValue>5__3;

			[Token(Token = "0x4000A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__4;

			[Token(Token = "0x170000EF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009D4")]
				[Address(RVA = "0x8670C4", Offset = "0x8670C4", VA = "0x8670C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D6")]
				[Address(RVA = "0x86710C", Offset = "0x86710C", VA = "0x86710C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x866848", Offset = "0x866848", VA = "0x866848")]
			[DebuggerHidden]
			public <WarpText>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x866874", Offset = "0x866874", VA = "0x866874", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x866878", Offset = "0x866878", VA = "0x866878", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x8670CC", Offset = "0x8670CC", VA = "0x8670CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float CurveScale;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float ShearAmount;

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x974888", Offset = "0x974888", VA = "0x974888")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x9748EC", Offset = "0x9748EC", VA = "0x9748EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x97498C", Offset = "0x97498C", VA = "0x97498C")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x974918", Offset = "0x974918", VA = "0x974918")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52FCD0", Offset = "0x52FCD0")]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x974A18", Offset = "0x974A18", VA = "0x974A18")]
		public SkewTextExample()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class TeleType : MonoBehaviour
	{
		[Token(Token = "0x20001D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B654", Offset = "0x52B654")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TeleType <>4__this;

			[Token(Token = "0x4000A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <totalVisibleCharacters>5__2;

			[Token(Token = "0x4000A6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <counter>5__3;

			[Token(Token = "0x170000F1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009DA")]
				[Address(RVA = "0x867C14", Offset = "0x867C14", VA = "0x867C14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009DC")]
				[Address(RVA = "0x867C5C", Offset = "0x867C5C", VA = "0x867C5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x867A24", Offset = "0x867A24", VA = "0x867A24")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x867A50", Offset = "0x867A50", VA = "0x867A50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x867A54", Offset = "0x867A54", VA = "0x867A54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x867C1C", Offset = "0x867C1C", VA = "0x867C1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string label01;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string label02;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_textMeshPro;

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xAE0BDC", Offset = "0xAE0BDC", VA = "0xAE0BDC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xAE0C78", Offset = "0xAE0C78", VA = "0xAE0C78")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52FD38", Offset = "0x52FD38")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xAE0CEC", Offset = "0xAE0CEC", VA = "0xAE0CEC")]
		public TeleType()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class TextConsoleSimulator : MonoBehaviour
	{
		[Token(Token = "0x20001D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B664", Offset = "0x52B664")]
		private sealed class <RevealCharacters>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x4000A73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TextConsoleSimulator <>4__this;

			[Token(Token = "0x4000A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x4000A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int <visibleCount>5__4;

			[Token(Token = "0x170000F3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009E0")]
				[Address(RVA = "0x868754", Offset = "0x868754", VA = "0x868754", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009E2")]
				[Address(RVA = "0x86879C", Offset = "0x86879C", VA = "0x86879C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x8685D4", Offset = "0x8685D4", VA = "0x8685D4")]
			[DebuggerHidden]
			public <RevealCharacters>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x868600", Offset = "0x868600", VA = "0x868600", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x868604", Offset = "0x868604", VA = "0x868604", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x86875C", Offset = "0x86875C", VA = "0x86875C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B674", Offset = "0x52B674")]
		private sealed class <RevealWords>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x4000A7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <totalWordCount>5__2;

			[Token(Token = "0x4000A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x4000A7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <counter>5__4;

			[Token(Token = "0x4000A7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <visibleCount>5__5;

			[Token(Token = "0x170000F5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009E6")]
				[Address(RVA = "0x8689A8", Offset = "0x8689A8", VA = "0x8689A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009E8")]
				[Address(RVA = "0x8689F0", Offset = "0x8689F0", VA = "0x8689F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x8687A4", Offset = "0x8687A4", VA = "0x8687A4")]
			[DebuggerHidden]
			public <RevealWords>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x8687D0", Offset = "0x8687D0", VA = "0x8687D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x8687D4", Offset = "0x8687D4", VA = "0x8687D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x8689B0", Offset = "0x8689B0", VA = "0x8689B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool hasTextChanged;

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xAE4120", Offset = "0xAE4120", VA = "0xAE4120")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xAE4184", Offset = "0xAE4184", VA = "0xAE4184")]
		private void Start()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xAE422C", Offset = "0xAE422C", VA = "0xAE422C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xAE4324", Offset = "0xAE4324", VA = "0xAE4324")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xAE441C", Offset = "0xAE441C", VA = "0xAE441C")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xAE41B4", Offset = "0xAE41B4", VA = "0xAE41B4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52FDA0", Offset = "0x52FDA0")]
		private IEnumerator RevealCharacters(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xAE4428", Offset = "0xAE4428", VA = "0xAE4428")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52FE08", Offset = "0x52FE08")]
		private IEnumerator RevealWords(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xAE449C", Offset = "0xAE449C", VA = "0xAE449C")]
		public TextConsoleSimulator()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class TextMeshProFloatingText : MonoBehaviour
	{
		[Token(Token = "0x20001D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B684", Offset = "0x52B684")]
		private sealed class <DisplayTextMeshProFloatingText>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x4000A81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x4000A82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x4000A83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x4000A84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x4000A85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x4000A86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x4000A87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x170000F7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009EC")]
				[Address(RVA = "0x8692F8", Offset = "0x8692F8", VA = "0x8692F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009EE")]
				[Address(RVA = "0x869340", Offset = "0x869340", VA = "0x869340", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x868E94", Offset = "0x868E94", VA = "0x868E94")]
			[DebuggerHidden]
			public <DisplayTextMeshProFloatingText>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x868EC0", Offset = "0x868EC0", VA = "0x868EC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x868EC4", Offset = "0x868EC4", VA = "0x868EC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x869300", Offset = "0x869300", VA = "0x869300", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B694", Offset = "0x52B694")]
		private sealed class <DisplayTextMeshFloatingText>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x4000A8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x4000A8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x4000A8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x4000A8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x4000A8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x4000A90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x4000A91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x170000F9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009F2")]
				[Address(RVA = "0x868E44", Offset = "0x868E44", VA = "0x868E44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009F4")]
				[Address(RVA = "0x868E8C", Offset = "0x868E8C", VA = "0x868E8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x8689F8", Offset = "0x8689F8", VA = "0x8689F8")]
			[DebuggerHidden]
			public <DisplayTextMeshFloatingText>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x868A24", Offset = "0x868A24", VA = "0x868A24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x868A28", Offset = "0x868A28", VA = "0x868A28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x868E4C", Offset = "0x868E4C", VA = "0x868E4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Font TheFont;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject m_floatingText;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMesh m_textMesh;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_transform;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_floatingText_Transform;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform m_cameraTransform;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 lastPOS;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion lastRotation;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int SpawnType;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static WaitForEndOfFrame k_WaitForEndOfFrame;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static WaitForSeconds[] k_WaitForSecondsRandom;

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xAE44A4", Offset = "0xAE44A4", VA = "0xAE44A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xAE456C", Offset = "0xAE456C", VA = "0xAE456C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xAE4944", Offset = "0xAE4944", VA = "0xAE4944")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52FE70", Offset = "0x52FE70")]
		public IEnumerator DisplayTextMeshProFloatingText()
		{
			return null;
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xAE49B8", Offset = "0xAE49B8", VA = "0xAE49B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52FED8", Offset = "0x52FED8")]
		public IEnumerator DisplayTextMeshFloatingText()
		{
			return null;
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xAE4A2C", Offset = "0xAE4A2C", VA = "0xAE4A2C")]
		public TextMeshProFloatingText()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class TextMeshSpawner : MonoBehaviour
	{
		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Font TheFont;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xAE5094", Offset = "0xAE5094", VA = "0xAE5094")]
		private void Awake()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xAE5098", Offset = "0xAE5098", VA = "0xAE5098")]
		private void Start()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xAE53AC", Offset = "0xAE53AC", VA = "0xAE53AC")]
		public TextMeshSpawner()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class TMPro_InstructionOverlay : MonoBehaviour
	{
		[Token(Token = "0x20001D5")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x4000A93")]
			TopLeft,
			[Token(Token = "0x4000A94")]
			BottomLeft,
			[Token(Token = "0x4000A95")]
			TopRight,
			[Token(Token = "0x4000A96")]
			BottomRight
		}

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000604")]
		private const string instructions = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextContainer m_textContainer;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Camera m_camera;

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xAE01E4", Offset = "0xAE01E4", VA = "0xAE01E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xAE043C", Offset = "0xAE043C", VA = "0xAE043C")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xAE0560", Offset = "0xAE0560", VA = "0xAE0560")]
		public TMPro_InstructionOverlay()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class TMP_ExampleScript_01 : MonoBehaviour
	{
		[Token(Token = "0x20001D6")]
		public enum objectType
		{
			[Token(Token = "0x4000A98")]
			TextMeshPro,
			[Token(Token = "0x4000A99")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public objectType ObjectType;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isStatic;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_text;

		[Token(Token = "0x400060C")]
		private const string k_label = "The count is <#0080ff>{0}</color>";

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int count;

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x979968", Offset = "0x979968", VA = "0x979968")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x979B88", Offset = "0x979B88", VA = "0x979B88")]
		private void Update()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x979C20", Offset = "0x979C20", VA = "0x979C20")]
		public TMP_ExampleScript_01()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class TMP_FrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x20001D7")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x4000A9B")]
			TopLeft,
			[Token(Token = "0x4000A9C")]
			BottomLeft,
			[Token(Token = "0x4000A9D")]
			TopRight,
			[Token(Token = "0x4000A9E")]
			BottomRight
		}

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x4000613")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera m_camera;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xADB460", Offset = "0xADB460", VA = "0xADB460")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xADB86C", Offset = "0xADB86C", VA = "0xADB86C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xADB898", Offset = "0xADB898", VA = "0xADB898")]
		private void Update()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xADB668", Offset = "0xADB668", VA = "0xADB668")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xADBA08", Offset = "0xADBA08", VA = "0xADBA08")]
		public TMP_FrameRateCounter()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class TMP_TextEventCheck : MonoBehaviour
	{
		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_TextEventHandler TextEventHandler;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xADBE30", Offset = "0xADBE30", VA = "0xADBE30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xADC134", Offset = "0xADC134", VA = "0xADC134")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xADC410", Offset = "0xADC410", VA = "0xADC410")]
		private void OnCharacterSelection(char c, int index)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xADC604", Offset = "0xADC604", VA = "0xADC604")]
		private void OnSpriteSelection(char c, int index)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xADC7F8", Offset = "0xADC7F8", VA = "0xADC7F8")]
		private void OnWordSelection(string word, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xADCA54", Offset = "0xADCA54", VA = "0xADCA54")]
		private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xADCCB0", Offset = "0xADCCB0", VA = "0xADCCB0")]
		private void OnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xADCF68", Offset = "0xADCF68", VA = "0xADCF68")]
		public TMP_TextEventCheck()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class TMP_TextInfoDebugTool : MonoBehaviour
	{
		[Token(Token = "0x6000533")]
		[Address(RVA = "0xADD9D0", Offset = "0xADD9D0", VA = "0xADD9D0")]
		public TMP_TextInfoDebugTool()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Camera m_Camera;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_isHoveringObject;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_selectedLink;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_lastCharIndex;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_lastWordIndex;

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xADD9D8", Offset = "0xADD9D8", VA = "0xADD9D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xADDA68", Offset = "0xADDA68", VA = "0xADDA68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xADE188", Offset = "0xADE188", VA = "0xADE188", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xADE214", Offset = "0xADE214", VA = "0xADE214", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xADE29C", Offset = "0xADE29C", VA = "0xADE29C")]
		public TMP_TextSelector_A()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class TMP_TextSelector_B : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform TextPopup_Prefab_01;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform m_TextPopup_RectTransform;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProUGUI m_TextPopup_TMPComponent;

		[Token(Token = "0x4000623")]
		private const string k_LinkText = "You have selected link <#ffff00>";

		[Token(Token = "0x4000624")]
		private const string k_WordText = "Word Index: <#ffff00>";

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Canvas m_Canvas;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera m_Camera;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool isHoveringObject;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_selectedWord;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_selectedLink;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_lastIndex;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Matrix4x4 m_matrix;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TMP_MeshInfo[] m_cachedMeshInfoVertexData;

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xADE2B4", Offset = "0xADE2B4", VA = "0xADE2B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xADE448", Offset = "0xADE448", VA = "0xADE448")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xADE540", Offset = "0xADE540", VA = "0xADE540")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xADE638", Offset = "0xADE638", VA = "0xADE638")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xADE6D8", Offset = "0xADE6D8", VA = "0xADE6D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xADFBAC", Offset = "0xADFBAC", VA = "0xADFBAC", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xADFBB8", Offset = "0xADFBB8", VA = "0xADFBB8", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xADFBC0", Offset = "0xADFBC0", VA = "0xADFBC0", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xADFBC4", Offset = "0xADFBC4", VA = "0xADFBC4", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xADF31C", Offset = "0xADF31C", VA = "0xADF31C")]
		private void RestoreCachedVertexAttributes(int index)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xADFBC8", Offset = "0xADFBC8", VA = "0xADFBC8")]
		public TMP_TextSelector_B()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class TMP_UiFrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x20001D8")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x4000AA0")]
			TopLeft,
			[Token(Token = "0x4000AA1")]
			BottomLeft,
			[Token(Token = "0x4000AA2")]
			TopRight,
			[Token(Token = "0x4000AA3")]
			BottomRight
		}

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x4000633")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform m_frameCounter_transform;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xADFBE0", Offset = "0xADFBE0", VA = "0xADFBE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xAE0030", Offset = "0xAE0030", VA = "0xAE0030")]
		private void Start()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xAE005C", Offset = "0xAE005C", VA = "0xAE005C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xADFDE8", Offset = "0xADFDE8", VA = "0xADFDE8")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xAE01CC", Offset = "0xAE01CC", VA = "0xAE01CC")]
		public TMP_UiFrameRateCounter()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class VertexColorCycler : MonoBehaviour
	{
		[Token(Token = "0x20001D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B6A4", Offset = "0x52B6A4")]
		private sealed class <AnimateVertexColors>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexColorCycler <>4__this;

			[Token(Token = "0x4000AA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000AA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <currentCharacter>5__3;

			[Token(Token = "0x170000FB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009F8")]
				[Address(RVA = "0x869D54", Offset = "0x869D54", VA = "0x869D54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009FA")]
				[Address(RVA = "0x869D9C", Offset = "0x869D9C", VA = "0x869D9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x869A6C", Offset = "0x869A6C", VA = "0x869A6C")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x869A98", Offset = "0x869A98", VA = "0x869A98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x869A9C", Offset = "0x869A9C", VA = "0x869A9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x869D5C", Offset = "0x869D5C", VA = "0x869D5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xAE9B88", Offset = "0xAE9B88", VA = "0xAE9B88")]
		private void Awake()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xAE9BE4", Offset = "0xAE9BE4", VA = "0xAE9BE4")]
		private void Start()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xAE9C10", Offset = "0xAE9C10", VA = "0xAE9C10")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52FF40", Offset = "0x52FF40")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xAE9C84", Offset = "0xAE9C84", VA = "0xAE9C84")]
		public VertexColorCycler()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class VertexJitter : MonoBehaviour
	{
		[Token(Token = "0x20001DA")]
		private struct VertexAnim
		{
			[Token(Token = "0x4000AA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float angleRange;

			[Token(Token = "0x4000AAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float angle;

			[Token(Token = "0x4000AAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float speed;
		}

		[Token(Token = "0x20001DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B6B4", Offset = "0x52B6B4")]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexJitter <>4__this;

			[Token(Token = "0x4000AAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000AB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <loopCount>5__3;

			[Token(Token = "0x4000AB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private VertexAnim[] <vertexAnim>5__4;

			[Token(Token = "0x4000AB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TMP_MeshInfo[] <cachedMeshInfo>5__5;

			[Token(Token = "0x170000FD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009FE")]
				[Address(RVA = "0x86A610", Offset = "0x86A610", VA = "0x86A610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A00")]
				[Address(RVA = "0x86A658", Offset = "0x86A658", VA = "0x86A658", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x869DA4", Offset = "0x869DA4", VA = "0x869DA4")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x869DD0", Offset = "0x869DD0", VA = "0x869DD0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x869DD4", Offset = "0x869DD4", VA = "0x869DD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x86A618", Offset = "0x86A618", VA = "0x86A618", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xAE9C8C", Offset = "0xAE9C8C", VA = "0xAE9C8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xAE9CE8", Offset = "0xAE9CE8", VA = "0xAE9CE8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xAE9DE0", Offset = "0xAE9DE0", VA = "0xAE9DE0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xAE9ED8", Offset = "0xAE9ED8", VA = "0xAE9ED8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xAE9F78", Offset = "0xAE9F78", VA = "0xAE9F78")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xAE9F04", Offset = "0xAE9F04", VA = "0xAE9F04")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x52FFA8", Offset = "0x52FFA8")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xAEA000", Offset = "0xAEA000", VA = "0xAEA000")]
		public VertexJitter()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class VertexShakeA : MonoBehaviour
	{
		[Token(Token = "0x20001DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B6C4", Offset = "0x52B6C4")]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexShakeA <>4__this;

			[Token(Token = "0x4000AB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000AB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x170000FF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A04")]
				[Address(RVA = "0x86B054", Offset = "0x86B054", VA = "0x86B054", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000100")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A06")]
				[Address(RVA = "0x86B09C", Offset = "0x86B09C", VA = "0x86B09C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x86A660", Offset = "0x86A660", VA = "0x86A660")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x86A68C", Offset = "0x86A68C", VA = "0x86A68C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x86A690", Offset = "0x86A690", VA = "0x86A690", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x86B05C", Offset = "0x86B05C", VA = "0x86B05C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ScaleMultiplier;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RotationMultiplier;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xAEA018", Offset = "0xAEA018", VA = "0xAEA018")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xAEA074", Offset = "0xAEA074", VA = "0xAEA074")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xAEA16C", Offset = "0xAEA16C", VA = "0xAEA16C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xAEA264", Offset = "0xAEA264", VA = "0xAEA264")]
		private void Start()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xAEA304", Offset = "0xAEA304", VA = "0xAEA304")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xAEA290", Offset = "0xAEA290", VA = "0xAEA290")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x530010", Offset = "0x530010")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xAEA384", Offset = "0xAEA384", VA = "0xAEA384")]
		public VertexShakeA()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class VertexShakeB : MonoBehaviour
	{
		[Token(Token = "0x20001DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B6D4", Offset = "0x52B6D4")]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000ABA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexShakeB <>4__this;

			[Token(Token = "0x4000ABB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000ABC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x17000101")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A0A")]
				[Address(RVA = "0x86BF1C", Offset = "0x86BF1C", VA = "0x86BF1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000102")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A0C")]
				[Address(RVA = "0x86BF64", Offset = "0x86BF64", VA = "0x86BF64", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x86B0A4", Offset = "0x86B0A4", VA = "0x86B0A4")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x86B0D0", Offset = "0x86B0D0", VA = "0x86B0D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x86B0D4", Offset = "0x86B0D4", VA = "0x86B0D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x86BF24", Offset = "0x86BF24", VA = "0x86BF24", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xAEA394", Offset = "0xAEA394", VA = "0xAEA394")]
		private void Awake()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xAEA3F0", Offset = "0xAEA3F0", VA = "0xAEA3F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xAEA4E8", Offset = "0xAEA4E8", VA = "0xAEA4E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xAEA5E0", Offset = "0xAEA5E0", VA = "0xAEA5E0")]
		private void Start()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xAEA680", Offset = "0xAEA680", VA = "0xAEA680")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xAEA60C", Offset = "0xAEA60C", VA = "0xAEA60C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x530078", Offset = "0x530078")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xAEA700", Offset = "0xAEA700", VA = "0xAEA700")]
		public VertexShakeB()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class VertexZoom : MonoBehaviour
	{
		[Token(Token = "0x20001DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B6E4", Offset = "0x52B6E4")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000ABD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<float> modifiedCharScale;

			[Token(Token = "0x4000ABE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Comparison<int> <>9__0;

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x86BF6C", Offset = "0x86BF6C", VA = "0x86BF6C")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x86BF74", Offset = "0x86BF74", VA = "0x86BF74")]
			internal int <AnimateVertexColors>b__0(int a, int b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x20001DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B6F4", Offset = "0x52B6F4")]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000ABF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexZoom <>4__this;

			[Token(Token = "0x4000AC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass10_0 <>8__1;

			[Token(Token = "0x4000AC3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000AC4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TMP_MeshInfo[] <cachedMeshInfoVertexData>5__3;

			[Token(Token = "0x4000AC5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<int> <scaleSortingOrder>5__4;

			[Token(Token = "0x17000103")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A12")]
				[Address(RVA = "0x86CBB0", Offset = "0x86CBB0", VA = "0x86CBB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000104")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A14")]
				[Address(RVA = "0x86CBF8", Offset = "0x86CBF8", VA = "0x86CBF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x86C034", Offset = "0x86C034", VA = "0x86C034")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x86C060", Offset = "0x86C060", VA = "0x86C060", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x86C064", Offset = "0x86C064", VA = "0x86C064", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x86CBB8", Offset = "0x86CBB8", VA = "0x86CBB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xAEA718", Offset = "0xAEA718", VA = "0xAEA718")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xAEA774", Offset = "0xAEA774", VA = "0xAEA774")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xAEA86C", Offset = "0xAEA86C", VA = "0xAEA86C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xAEA964", Offset = "0xAEA964", VA = "0xAEA964")]
		private void Start()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xAEAA04", Offset = "0xAEAA04", VA = "0xAEAA04")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xAEA990", Offset = "0xAEA990", VA = "0xAEA990")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5300E0", Offset = "0x5300E0")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xAEAA8C", Offset = "0xAEAA8C", VA = "0xAEAA8C")]
		public VertexZoom()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class WarpTextExample : MonoBehaviour
	{
		[Token(Token = "0x20001E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B704", Offset = "0x52B704")]
		private sealed class <WarpText>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AC6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AC7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AC8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WarpTextExample <>4__this;

			[Token(Token = "0x4000AC9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x4000ACA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__3;

			[Token(Token = "0x17000105")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A18")]
				[Address(RVA = "0x11A7A74", Offset = "0x11A7A74", VA = "0x11A7A74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000106")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A1A")]
				[Address(RVA = "0x11A7ABC", Offset = "0x11A7ABC", VA = "0x11A7ABC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x11A7290", Offset = "0x11A7290", VA = "0x11A7290")]
			[DebuggerHidden]
			public <WarpText>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x11A72BC", Offset = "0x11A72BC", VA = "0x11A72BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x11A72C0", Offset = "0x11A72C0", VA = "0x11A72C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x11A7A7C", Offset = "0x11A7A7C", VA = "0x11A7A7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float AngleMultiplier;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float CurveScale;

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xAEBCA8", Offset = "0xAEBCA8", VA = "0xAEBCA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xAEBD0C", Offset = "0xAEBD0C", VA = "0xAEBD0C")]
		private void Start()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xAEBDAC", Offset = "0xAEBDAC", VA = "0xAEBDAC")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xAEBD38", Offset = "0xAEBD38", VA = "0xAEBD38")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x530148", Offset = "0x530148")]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xAEBE38", Offset = "0xAEBE38", VA = "0xAEBE38")]
		public WarpTextExample()
		{
		}
	}
}
namespace Shapes
{
	[Token(Token = "0x2000111")]
	public class AmmoBar : MonoBehaviour
	{
		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int totalBullets;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int bullets;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52CBBC", Offset = "0x52CBBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CBBC", Offset = "0x52CBBC")]
		public float bulletThicknessScale;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CC10", Offset = "0x52CC10")]
		public float bulletEjectScale;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52CC28", Offset = "0x52CC28")]
		public float bulletDisappearTime;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CC60", Offset = "0x52CC60")]
		public float bulletEjectAngSpeed;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CC7C", Offset = "0x52CC7C")]
		public float ejectRotSpeedVariance;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve bulletEjectX;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve bulletEjectY;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float[] bulletFireTimes;

		[Token(Token = "0x17000038")]
		public bool HasBulletsLeft
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x9B4C6C", Offset = "0x9B4C6C", VA = "0x9B4C6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x9B4BF0", Offset = "0x9B4BF0", VA = "0x9B4BF0")]
		private Vector2 GetBulletEjectPos(Vector2 origin, float t)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x9B4C7C", Offset = "0x9B4C7C", VA = "0x9B4C7C")]
		public void Fire()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x9B4CD4", Offset = "0x9B4CD4", VA = "0x9B4CD4")]
		public void Reload()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x9B4CE0", Offset = "0x9B4CE0", VA = "0x9B4CE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x9B4D3C", Offset = "0x9B4D3C", VA = "0x9B4D3C")]
		public void DrawBar(FpsController fpsController, float barRadius)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x9B5130", Offset = "0x9B5130", VA = "0x9B5130")]
		public AmmoBar()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class ChargeBar : MonoBehaviour
	{
		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52CC98", Offset = "0x52CC98")]
		[SerializeField]
		private float chargeSpeed;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float chargeDecaySpeed;

		[NonSerialized]
		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isCharging;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float charge;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52CCF4", Offset = "0x52CCF4")]
		public Color tickColor;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Gradient chargeFillGradient;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CD2C", Offset = "0x52CD2C")]
		public float tickSizeSmol;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CD48", Offset = "0x52CD48")]
		public float tickSizeLorge;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CD64", Offset = "0x52CD64")]
		public float tickTickness;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CD80", Offset = "0x52CD80")]
		public float fontSize;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CD98", Offset = "0x52CD98")]
		public float fontSizeLorge;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CDB0", Offset = "0x52CDB0")]
		public float percentLabelOffset;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CDCC", Offset = "0x52CDCC")]
		public float fontGrowRangePrev;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CDE8", Offset = "0x52CDE8")]
		public float fontGrowRangeNext;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52CE04", Offset = "0x52CE04")]
		public AnimationCurve chargeFillCurve;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve animChargeShakeMagnitude;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CE3C", Offset = "0x52CE3C")]
		public float chargeShakeMagnitude;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float chargeShakeSpeed;

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x94DFE0", Offset = "0x94DFE0", VA = "0x94DFE0")]
		public void UpdateCharge()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x94E04C", Offset = "0x94E04C", VA = "0x94E04C")]
		public void DrawBar(FpsController fpsController, float barRadius)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x950A00", Offset = "0x950A00", VA = "0x950A00")]
		public ChargeBar()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class Compass : MonoBehaviour
	{
		[StructLayout(3)]
		[Token(Token = "0x20001E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B714", Offset = "0x52B714")]
		private struct <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000ACB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float angWorldMax;

			[Token(Token = "0x4000ACC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float angWorldMin;

			[Token(Token = "0x4000ACD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float angUiMin;

			[Token(Token = "0x4000ACE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float angUiMax;

			[Token(Token = "0x4000ACF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector2 compArcOrigin;

			[Token(Token = "0x4000AD0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Compass <>4__this;
		}

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 position;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float width;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CE58", Offset = "0x52CE58")]
		public float lineThickness;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CE74", Offset = "0x52CE74")]
		public float bendRadius;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CE90", Offset = "0x52CE90")]
		public float fieldOfView;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52CEB0", Offset = "0x52CEB0")]
		public int ticksPerQuarterTurn;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CEE8", Offset = "0x52CEE8")]
		public float tickSize;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CF04", Offset = "0x52CF04")]
		public float tickEdgeFadeFraction;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CF1C", Offset = "0x52CF1C")]
		public float fontSizeTickLabel;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CF3C", Offset = "0x52CF3C")]
		public float tickLabelOffset;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52CF58", Offset = "0x52CF58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CF58", Offset = "0x52CF58")]
		public float fontSizeLookLabel;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector2 lookAngLabelOffset;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CFB4", Offset = "0x52CFB4")]
		public float triangleNootSize;

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x95195C", Offset = "0x95195C", VA = "0x95195C")]
		public void DrawCompass(Vector3 worldDir)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x952F00", Offset = "0x952F00", VA = "0x952F00")]
		public Compass()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x952784", Offset = "0x952784", VA = "0x952784")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5301B0", Offset = "0x5301B0")]
		private void <DrawCompass>g__CompassArcNoot|13_0(float worldAng, float size, string label, <>c__DisplayClass13_0 P_3)
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class Crosshair : MonoBehaviour
	{
		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52CFD0", Offset = "0x52CFD0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52CFD0", Offset = "0x52CFD0")]
		public float crosshairCrossInnerRad;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D028", Offset = "0x52D028")]
		public float crosshairCrossOuterRad;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D044", Offset = "0x52D044")]
		public float crosshairCrossThickness;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D060", Offset = "0x52D060")]
		public float crosshairHitCrossInnerRad;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D07C", Offset = "0x52D07C")]
		public float crosshairHitCrossOuterRad;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D098", Offset = "0x52D098")]
		public float crosshairHitCrossThickness;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52D0B4", Offset = "0x52D0B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D0B4", Offset = "0x52D0B4")]
		public float scaleFire;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Decayer fireDecayer;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Decayer hitDecayer;

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x953468", Offset = "0x953468", VA = "0x953468")]
		public void Fire()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x95348C", Offset = "0x95348C", VA = "0x95348C")]
		public void FireHit()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x9534B0", Offset = "0x9534B0", VA = "0x9534B0")]
		public void UpdateCrosshairDecay()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x953588", Offset = "0x953588", VA = "0x953588")]
		public void DrawCrosshair()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x953A08", Offset = "0x953A08", VA = "0x953A08")]
		public Crosshair()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x953834", Offset = "0x953834", VA = "0x953834")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5301C0", Offset = "0x5301C0")]
		internal static void <DrawCrosshair>g__DrawCross|12_0(Vector2[] dirs, float radInner, float radOuter, float thickness, float radialOffset, Color color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000115")]
	public class Decayer
	{
		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float decaySpeed;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float magnitude;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve curve;

		[NonSerialized]
		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float value;

		[NonSerialized]
		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float valueInv;

		[NonSerialized]
		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float t;

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x95699C", Offset = "0x95699C", VA = "0x95699C")]
		public void SetT(float v)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x9534E4", Offset = "0x9534E4", VA = "0x9534E4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x953AB8", Offset = "0x953AB8", VA = "0x953AB8")]
		public Decayer()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[ExecuteAlways]
	public class FpsController : ImmediateModeShapeDrawer
	{
		[Token(Token = "0x20001E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B724", Offset = "0x52B724")]
		private sealed class <FixedSteps>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AD1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AD2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AD3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FpsController <>4__this;

			[Token(Token = "0x17000107")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A1E")]
				[Address(RVA = "0x85F39C", Offset = "0x85F39C", VA = "0x85F39C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000108")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A20")]
				[Address(RVA = "0x85F3E4", Offset = "0x85F3E4", VA = "0x85F3E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x85F2D0", Offset = "0x85F2D0", VA = "0x85F2D0")]
			[DebuggerHidden]
			public <FixedSteps>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x85F2FC", Offset = "0x85F2FC", VA = "0x85F2FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x85F300", Offset = "0x85F300", VA = "0x85F300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x85F3A4", Offset = "0x85F3A4", VA = "0x85F3A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform head;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Camera cam;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Crosshair crosshair;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ChargeBar chargeBar;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AmmoBar ammoBar;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Compass compass;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform crosshairTransform;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52D108", Offset = "0x52D108")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D108", Offset = "0x52D108")]
		public float smoof;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float moveSpeed;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lookSensitivity;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float yaw;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float pitch;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector2 moveInput;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 moveVel;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52D160", Offset = "0x52D160")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D160", Offset = "0x52D160")]
		public float ammoBarAngularSpanRad;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D1B8", Offset = "0x52D1B8")]
		public float ammoBarOutlineThickness;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D1D4", Offset = "0x52D1D4")]
		public float ammoBarThickness;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D1F0", Offset = "0x52D1F0")]
		public float ammoBarRadius;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52D20C", Offset = "0x52D20C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D20C", Offset = "0x52D20C")]
		public float fireSidebarRadiusPunchAmount;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve shakeAnimX;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AnimationCurve shakeAnimY;

		[Token(Token = "0x17000039")]
		private bool InputFocus
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x95BA70", Offset = "0x95BA70", VA = "0x95BA70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x95B5B8", Offset = "0x95B5B8", VA = "0x95B5B8")]
			set
			{
			}
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x95B558", Offset = "0x95B558", VA = "0x95B558")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x95B660", Offset = "0x95B660", VA = "0x95B660", Slot = "4")]
		public override void DrawShapes(Camera cam)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x95B5EC", Offset = "0x95B5EC", VA = "0x95B5EC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5301D0", Offset = "0x5301D0")]
		private IEnumerator FixedSteps()
		{
			return null;
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x94FBB8", Offset = "0x94FBB8", VA = "0x94FBB8")]
		public static void DrawRoundedArcOutline(Vector2 origin, float radius, float thickness, float outlineThickness, float angStart, float angEnd)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x94FB34", Offset = "0x94FB34", VA = "0x94FB34")]
		public Vector2 GetShake(float speed, float amp)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x95BA90", Offset = "0x95BA90", VA = "0x95BA90")]
		private void FixedUpdateManual()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x95BBEC", Offset = "0x95BBEC", VA = "0x95BBEC")]
		private void Update()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x95BFF8", Offset = "0x95BFF8", VA = "0x95BFF8")]
		public FpsController()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x95BFA8", Offset = "0x95BFA8", VA = "0x95BFA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530238", Offset = "0x530238")]
		private void <Update>g__DoInput|30_0(KeyCode key, Vector2 dir)
		{
		}
	}
	[Token(Token = "0x2000117")]
	[ExecuteAlways]
	public class ProceduralTree : ImmediateModeShapeDrawer
	{
		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52D264", Offset = "0x52D264")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D264", Offset = "0x52D264")]
		public float lineThickness;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color lineColor;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52D2BC", Offset = "0x52D2BC")]
		public int seed;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D2F4", Offset = "0x52D2F4")]
		public int lineCount;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D310", Offset = "0x52D310")]
		public int branchesMin;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D328", Offset = "0x52D328")]
		public int branchesMax;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D340", Offset = "0x52D340")]
		public float branchLengthMin;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D358", Offset = "0x52D358")]
		public float branchLengthMax;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D370", Offset = "0x52D370")]
		public float maxAngDeviation;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool use3D;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int currentLineCount;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly Queue<Matrix4x4> mtxQueue;

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x96B214", Offset = "0x96B214", VA = "0x96B214", Slot = "4")]
		public override void DrawShapes(Camera cam)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x96B5B8", Offset = "0x96B5B8", VA = "0x96B5B8")]
		private void BranchFrom(Matrix4x4 mtx)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x96BF54", Offset = "0x96BF54", VA = "0x96BF54")]
		public ProceduralTree()
		{
		}
	}
	[Token(Token = "0x2000118")]
	[ExecuteAlways]
	public class SpinningColorDiscs : ImmediateModeShapeDrawer
	{
		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D38C", Offset = "0x52D38C")]
		public int discCount;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D3A8", Offset = "0x52D3A8")]
		public float discRadius;

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x978D9C", Offset = "0x978D9C", VA = "0x978D9C", Slot = "4")]
		public override void DrawShapes(Camera cam)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x9793D0", Offset = "0x9793D0", VA = "0x9793D0")]
		private Vector2 GetDiscPosition(float t)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x979458", Offset = "0x979458", VA = "0x979458")]
		public SpinningColorDiscs()
		{
		}
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x2000119")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x1700003A")]
		public bool Highlight
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x9513BC", Offset = "0x9513BC", VA = "0x9513BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x9513C4", Offset = "0x9513C4", VA = "0x9513C4")]
			set
			{
			}
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x9513D0", Offset = "0x9513D0", VA = "0x9513D0")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x951590", Offset = "0x951590", VA = "0x951590", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x9515B8", Offset = "0x9515B8", VA = "0x9515B8", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x9515E0", Offset = "0x9515E0", VA = "0x9515E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x951490", Offset = "0x951490", VA = "0x951490")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x951874", Offset = "0x951874", VA = "0x951874")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x1700003B")]
		public bool InRange
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x9569A4", Offset = "0x9569A4", VA = "0x9569A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x9569AC", Offset = "0x9569AC", VA = "0x9569AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public bool Targeted
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x956B30", Offset = "0x956B30", VA = "0x956B30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x956B38", Offset = "0x956B38", VA = "0x956B38")]
			set
			{
			}
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x956B44", Offset = "0x956B44", VA = "0x956B44", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x9569B8", Offset = "0x9569B8", VA = "0x9569B8")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x956D18", Offset = "0x956D18", VA = "0x956D18")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x52B24C", Offset = "0x52B24C")]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x1700003D")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x956D20", Offset = "0x956D20", VA = "0x956D20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x956D28", Offset = "0x956D28", VA = "0x956D28")]
			set
			{
			}
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x956D44", Offset = "0x956D44", VA = "0x956D44", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x956F74", Offset = "0x956F74", VA = "0x956F74", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x957838", Offset = "0x957838", VA = "0x957838", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x957CB0", Offset = "0x957CB0", VA = "0x957CB0", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x957F74", Offset = "0x957F74", VA = "0x957F74")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x9571C8", Offset = "0x9571C8", VA = "0x9571C8")]
		protected bool FindTarget([Out] DistanceGrabbable dgOut, [Out] Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x958078", Offset = "0x958078", VA = "0x958078")]
		protected bool FindTargetWithSpherecast([Out] DistanceGrabbable dgOut, [Out] Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x95845C", Offset = "0x95845C", VA = "0x95845C", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x958474", Offset = "0x958474", VA = "0x958474", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x95847C", Offset = "0x95847C", VA = "0x95847C")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x20001E3")]
		public enum CrosshairState
		{
			[Token(Token = "0x4000AD5")]
			Disabled,
			[Token(Token = "0x4000AD6")]
			Enabled,
			[Token(Token = "0x4000AD7")]
			Targeted
		}

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x95C888", Offset = "0x95C888", VA = "0x95C888")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x956C7C", Offset = "0x956C7C", VA = "0x956C7C")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x95C8F4", Offset = "0x95C8F4", VA = "0x95C8F4")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x95C93C", Offset = "0x95C93C", VA = "0x95C93C")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x95C714", Offset = "0x95C714", VA = "0x95C714")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x95C7CC", Offset = "0x95C7CC", VA = "0x95C7CC")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x95C880", Offset = "0x95C880", VA = "0x95C880")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x9691DC", Offset = "0x9691DC", VA = "0x9691DC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x9692D0", Offset = "0x9692D0", VA = "0x9692D0")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x9692DC", Offset = "0x9692DC", VA = "0x9692DC")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x9692E8", Offset = "0x9692E8", VA = "0x9692E8")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x9BDDD0", Offset = "0x9BDDD0", VA = "0x9BDDD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x9BDE24", Offset = "0x9BDE24", VA = "0x9BDE24")]
		private void Update()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x9BE180", Offset = "0x9BE180", VA = "0x9BE180")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x9BE284", Offset = "0x9BE284", VA = "0x9BE284")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x9BDE28", Offset = "0x9BDE28", VA = "0x9BDE28")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x9BE388", Offset = "0x9BE388", VA = "0x9BE388")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x20001E4")]
		public enum ContactTest
		{
			[Token(Token = "0x4000AD9")]
			PerpenTest,
			[Token(Token = "0x4000ADA")]
			BackwardsPress
		}

		[Token(Token = "0x40006D1")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x40006D2")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private InteractableState _currentButtonState;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x1700003E")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x9BEB4C", Offset = "0x9BEB4C", VA = "0x9BEB4C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x9BEB54", Offset = "0x9BEB54", VA = "0x9BEB54")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x9BEB60", Offset = "0x9BEB60", VA = "0x9BEB60", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x9BEC4C", Offset = "0x9BEC4C", VA = "0x9BEC4C")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x9BEDA8", Offset = "0x9BEDA8", VA = "0x9BEDA8", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x9BF338", Offset = "0x9BF338", VA = "0x9BF338")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x9BF250", Offset = "0x9BF250", VA = "0x9BF250")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x9BF3E8", Offset = "0x9BF3E8", VA = "0x9BF3E8")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x9BF46C", Offset = "0x9BF46C", VA = "0x9BF46C")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x9BF4F8", Offset = "0x9BF4F8", VA = "0x9BF4F8")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52D4F0", Offset = "0x52D4F0")]
		private Collider <Collider>k__BackingField;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52D500", Offset = "0x52D500")]
		private Interactable <ParentInteractable>k__BackingField;

		[Token(Token = "0x17000040")]
		public Collider Collider
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x9BF734", Offset = "0x9BF734", VA = "0x9BF734", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530248", Offset = "0x530248")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x9BF73C", Offset = "0x9BF73C", VA = "0x9BF73C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530258", Offset = "0x530258")]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x9BF744", Offset = "0x9BF744", VA = "0x9BF744", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530268", Offset = "0x530268")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x9BF74C", Offset = "0x9BF74C", VA = "0x9BF74C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530278", Offset = "0x530278")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x9BF754", Offset = "0x9BF754", VA = "0x9BF754", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x9BF7A8", Offset = "0x9BF7A8", VA = "0x9BF7A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x9BF834", Offset = "0x9BF834", VA = "0x9BF834")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public interface ColliderZone
	{
		[Token(Token = "0x17000043")]
		Collider Collider
		{
			[Token(Token = "0x60005D3")]
			get;
		}

		[Token(Token = "0x17000044")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x60005D4")]
			get;
		}

		[Token(Token = "0x17000045")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x60005D5")]
			get;
		}
	}
	[Token(Token = "0x2000123")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x95131C", Offset = "0x95131C", VA = "0x95131C")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x2000124")]
	public enum InteractionType
	{
		[Token(Token = "0x40006E6")]
		Enter,
		[Token(Token = "0x40006E7")]
		Stay,
		[Token(Token = "0x40006E8")]
		Exit
	}
	[Token(Token = "0x2000125")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x20001E5")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x4000ADC")]
			Mesh,
			[Token(Token = "0x4000ADD")]
			Skeleton,
			[Token(Token = "0x4000ADE")]
			Both
		}

		[Token(Token = "0x20001E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B734", Offset = "0x52B734")]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000ADF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AE0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AE1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x17000109")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A24")]
				[Address(RVA = "0x85F878", Offset = "0x85F878", VA = "0x85F878", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A26")]
				[Address(RVA = "0x85F8C0", Offset = "0x85F8C0", VA = "0x85F8C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x85F618", Offset = "0x85F618", VA = "0x85F618")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x85F644", Offset = "0x85F644", VA = "0x85F644", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x85F648", Offset = "0x85F648", VA = "0x85F648", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x85F880", Offset = "0x85F880", VA = "0x85F880", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006E9")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52D530", Offset = "0x52D530")]
		private static HandsManager <Instance>k__BackingField;

		[Token(Token = "0x17000046")]
		public OVRHand RightHand
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x9596E0", Offset = "0x9596E0", VA = "0x9596E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x95DEB0", Offset = "0x95DEB0", VA = "0x95DEB0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x95DF14", Offset = "0x95DF14", VA = "0x95DF14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x95DF4C", Offset = "0x95DF4C", VA = "0x95DF4C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x95DFB0", Offset = "0x95DFB0", VA = "0x95DFB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x95DFE8", Offset = "0x95DFE8", VA = "0x95DFE8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x95E04C", Offset = "0x95E04C", VA = "0x95E04C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x95E084", Offset = "0x95E084", VA = "0x95E084")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x95E0E8", Offset = "0x95E0E8", VA = "0x95E0E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x95E120", Offset = "0x95E120", VA = "0x95E120")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x9596AC", Offset = "0x9596AC", VA = "0x9596AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x95E184", Offset = "0x95E184", VA = "0x95E184")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x95E1E4", Offset = "0x95E1E4", VA = "0x95E1E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x95E218", Offset = "0x95E218", VA = "0x95E218")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x95E278", Offset = "0x95E278", VA = "0x95E278")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x95E2AC", Offset = "0x95E2AC", VA = "0x95E2AC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x95E30C", Offset = "0x95E30C", VA = "0x95E30C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x95E340", Offset = "0x95E340", VA = "0x95E340")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x95E3A0", Offset = "0x95E3A0", VA = "0x95E3A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x95E3D4", Offset = "0x95E3D4", VA = "0x95E3D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public static HandsManager Instance
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x95E434", Offset = "0x95E434", VA = "0x95E434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530288", Offset = "0x530288")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x95E480", Offset = "0x95E480", VA = "0x95E480")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530298", Offset = "0x530298")]
			private set
			{
			}
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x95E4D8", Offset = "0x95E4D8", VA = "0x95E4D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x95E888", Offset = "0x95E888", VA = "0x95E888")]
		private void Update()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x95E814", Offset = "0x95E814", VA = "0x95E814")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5302A8", Offset = "0x5302A8")]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x9532C0", Offset = "0x9532C0", VA = "0x9532C0")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x95E910", Offset = "0x95E910", VA = "0x95E910")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x95EAF0", Offset = "0x95EAF0", VA = "0x95EAF0")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x959520", Offset = "0x959520", VA = "0x959520")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x95ED14", Offset = "0x95ED14", VA = "0x95ED14")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001E7")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x85F8C8", Offset = "0x85F8C8", VA = "0x85F8C8")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x17000051")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x961B3C", Offset = "0x961B3C", VA = "0x961B3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x961B44", Offset = "0x961B44", VA = "0x961B44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x961B4C", Offset = "0x961B4C", VA = "0x961B4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x961B54", Offset = "0x961B54", VA = "0x961B54", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x961B5C", Offset = "0x961B5C", VA = "0x961B5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530310", Offset = "0x530310")]
			add
			{
			}
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x961BFC", Offset = "0x961BFC", VA = "0x961BFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530320", Offset = "0x530320")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x961D0C", Offset = "0x961D0C", VA = "0x961D0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530330", Offset = "0x530330")]
			add
			{
			}
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x961DAC", Offset = "0x961DAC", VA = "0x961DAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530340", Offset = "0x530340")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x961EBC", Offset = "0x961EBC", VA = "0x961EBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530350", Offset = "0x530350")]
			add
			{
			}
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x961F5C", Offset = "0x961F5C", VA = "0x961F5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530360", Offset = "0x530360")]
			remove
			{
			}
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x961C9C", Offset = "0x961C9C", VA = "0x961C9C", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x961E4C", Offset = "0x961E4C", VA = "0x961E4C", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x961FFC", Offset = "0x961FFC", VA = "0x961FFC", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000602")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x96206C", Offset = "0x96206C", VA = "0x96206C", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x9621A0", Offset = "0x9621A0", VA = "0x9621A0", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x9622D4", Offset = "0x9622D4", VA = "0x9622D4")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x4000701")]
		None,
		[Token(Token = "0x4000702")]
		Proximity,
		[Token(Token = "0x4000703")]
		Contact,
		[Token(Token = "0x4000704")]
		Action
	}
	[Token(Token = "0x2000128")]
	public enum InteractableState
	{
		[Token(Token = "0x4000706")]
		Default,
		[Token(Token = "0x4000707")]
		ProximityState,
		[Token(Token = "0x4000708")]
		ContactState,
		[Token(Token = "0x4000709")]
		ActionState
	}
	[Token(Token = "0x2000129")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x9623D8", Offset = "0x9623D8", VA = "0x9623D8")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x17000055")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x9622DC", Offset = "0x9622DC", VA = "0x9622DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x9620D4", Offset = "0x9620D4", VA = "0x9620D4")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x962208", Offset = "0x962208", VA = "0x962208")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x962340", Offset = "0x962340", VA = "0x962340")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x20001E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B744", Offset = "0x52B744")]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AE2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AE3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AE4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x4000AE5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x4000AE6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x4000AE7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x4000AE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x4000AE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x4000AEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x1700010B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A2C")]
				[Address(RVA = "0x85FDB4", Offset = "0x85FDB4", VA = "0x85FDB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A2E")]
				[Address(RVA = "0x85FDFC", Offset = "0x85FDFC", VA = "0x85FDFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x85F91C", Offset = "0x85F91C", VA = "0x85F91C")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x85F948", Offset = "0x85F948", VA = "0x85F948", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x85F9C0", Offset = "0x85F9C0", VA = "0x85F9C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x85F964", Offset = "0x85F964", VA = "0x85F964")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x85FDBC", Offset = "0x85FDBC", VA = "0x85FDBC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x962F6C", Offset = "0x962F6C", VA = "0x962F6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x962FE8", Offset = "0x962FE8", VA = "0x962FE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x530370", Offset = "0x530370")]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x963078", Offset = "0x963078", VA = "0x963078")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x963160", Offset = "0x963160", VA = "0x963160")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x17000056")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x958FF0", Offset = "0x958FF0", VA = "0x958FF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x95916C", Offset = "0x95916C", VA = "0x95916C")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x963168", Offset = "0x963168", VA = "0x963168")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x963210", Offset = "0x963210", VA = "0x963210")]
		private void Update()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x9634BC", Offset = "0x9634BC", VA = "0x9634BC")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x963504", Offset = "0x963504", VA = "0x963504")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x963790", Offset = "0x963790", VA = "0x963790")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x9638D4", Offset = "0x9638D4", VA = "0x9638D4")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x20001E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B754", Offset = "0x52B754")]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x1700010D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A32")]
				[Address(RVA = "0x85F280", Offset = "0x85F280", VA = "0x85F280", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A34")]
				[Address(RVA = "0x85F2C8", Offset = "0x85F2C8", VA = "0x85F2C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x85EE6C", Offset = "0x85EE6C", VA = "0x85EE6C")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x85EE98", Offset = "0x85EE98", VA = "0x85EE98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x85EE9C", Offset = "0x85EE9C", VA = "0x85EE9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x85F288", Offset = "0x85F288", VA = "0x85F288", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000719")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x17000057")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x958ED8", Offset = "0x958ED8", VA = "0x958ED8", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x17000058")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000619")]
			[Address(RVA = "0x958EE0", Offset = "0x958EE0", VA = "0x958EE0", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x17000059")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x958EE8", Offset = "0x958EE8", VA = "0x958EE8", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005A")]
		public override bool EnableState
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x958EF0", Offset = "0x958EF0", VA = "0x958EF0", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x958F1C", Offset = "0x958F1C", VA = "0x958F1C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x958F58", Offset = "0x958F58", VA = "0x958F58", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x959214", Offset = "0x959214", VA = "0x959214")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5303D8", Offset = "0x5303D8")]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x959288", Offset = "0x959288", VA = "0x959288")]
		private void Update()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x959718", Offset = "0x959718", VA = "0x959718")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x9598A4", Offset = "0x9598A4", VA = "0x9598A4")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x959998", Offset = "0x959998", VA = "0x959998", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x959CE4", Offset = "0x959CE4", VA = "0x959CE4", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x959CE8", Offset = "0x959CE8", VA = "0x959CE8", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x959CEC", Offset = "0x959CEC", VA = "0x959CEC")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class FingerTipPokeToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52D5C0", Offset = "0x52D5C0")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52D5D0", Offset = "0x52D5D0")]
		private bool <ToolActivateState>k__BackingField;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52D5E0", Offset = "0x52D5E0")]
		private float <SphereRadius>k__BackingField;

		[Token(Token = "0x1700005B")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x959E58", Offset = "0x959E58", VA = "0x959E58", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530440", Offset = "0x530440")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x959E60", Offset = "0x959E60", VA = "0x959E60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530450", Offset = "0x530450")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public bool EnableState
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x959E68", Offset = "0x959E68", VA = "0x959E68", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x959E88", Offset = "0x959E88", VA = "0x959E88", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public bool ToolActivateState
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x959EAC", Offset = "0x959EAC", VA = "0x959EAC", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530460", Offset = "0x530460")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x959EB4", Offset = "0x959EB4", VA = "0x959EB4", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530470", Offset = "0x530470")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public float SphereRadius
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x959EC0", Offset = "0x959EC0", VA = "0x959EC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530480", Offset = "0x530480")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x959EC8", Offset = "0x959EC8", VA = "0x959EC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530490", Offset = "0x530490")]
			private set
			{
			}
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x959ED0", Offset = "0x959ED0", VA = "0x959ED0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x959F18", Offset = "0x959F18", VA = "0x959F18", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x959F1C", Offset = "0x959F1C", VA = "0x959F1C")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x200012F")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x4000729")]
		None = 0,
		[Token(Token = "0x400072A")]
		Ray = 1,
		[Token(Token = "0x400072B")]
		Poke = 4,
		[Token(Token = "0x400072C")]
		All = -1
	}
	[Token(Token = "0x2000130")]
	public enum ToolInputState
	{
		[Token(Token = "0x400072E")]
		Inactive,
		[Token(Token = "0x400072F")]
		PrimaryInputDown,
		[Token(Token = "0x4000730")]
		PrimaryInputDownStay,
		[Token(Token = "0x4000731")]
		PrimaryInputUp
	}
	[Token(Token = "0x2000131")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x959CA0", Offset = "0x959CA0", VA = "0x959CA0")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x2000132")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52D5F0", Offset = "0x52D5F0")]
		private bool <IsRightHandedTool>k__BackingField;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52D600", Offset = "0x52D600")]
		private Vector3 <Velocity>k__BackingField;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52D610", Offset = "0x52D610")]
		private Vector3 <InteractionPosition>k__BackingField;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x1700005F")]
		public Transform ToolTransform
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x962478", Offset = "0x962478", VA = "0x962478")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x962480", Offset = "0x962480", VA = "0x962480")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5304A0", Offset = "0x5304A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x962488", Offset = "0x962488", VA = "0x962488")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5304B0", Offset = "0x5304B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000635")]
			get;
		}

		[Token(Token = "0x17000062")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x6000636")]
			get;
		}

		[Token(Token = "0x17000063")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x6000637")]
			get;
		}

		[Token(Token = "0x17000064")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x962494", Offset = "0x962494", VA = "0x962494")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5304C0", Offset = "0x5304C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x9624A0", Offset = "0x9624A0", VA = "0x9624A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5304D0", Offset = "0x5304D0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x9624AC", Offset = "0x9624AC", VA = "0x9624AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5304E0", Offset = "0x5304E0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x9624B8", Offset = "0x9624B8", VA = "0x9624B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5304F0", Offset = "0x5304F0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public abstract bool EnableState
		{
			[Token(Token = "0x6000640")]
			get;
			[Token(Token = "0x6000641")]
			set;
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x9624C4", Offset = "0x9624C4", VA = "0x9624C4")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x600063D")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x600063E")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x600063F")]
		public abstract void DeFocus();

		[Token(Token = "0x6000642")]
		public abstract void Initialize();

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x9624CC", Offset = "0x9624CC", VA = "0x9624CC")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x962520", Offset = "0x962520", VA = "0x962520")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x962574", Offset = "0x962574", VA = "0x962574", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x962800", Offset = "0x962800", VA = "0x962800", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x959D00", Offset = "0x959D00", VA = "0x959D00")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public interface InteractableToolView
	{
		[Token(Token = "0x17000067")]
		InteractableTool InteractableTool
		{
			[Token(Token = "0x6000648")]
			get;
		}

		[Token(Token = "0x17000068")]
		bool EnableState
		{
			[Token(Token = "0x600064A")]
			get;
			[Token(Token = "0x600064B")]
			set;
		}

		[Token(Token = "0x17000069")]
		bool ToolActivateState
		{
			[Token(Token = "0x600064C")]
			get;
			[Token(Token = "0x600064D")]
			set;
		}

		[Token(Token = "0x6000649")]
		void SetFocusedInteractable(Interactable interactable);
	}
	[Token(Token = "0x2000134")]
	public class PinchStateModule
	{
		[Token(Token = "0x20001EA")]
		private enum PinchState
		{
			[Token(Token = "0x4000AEF")]
			None,
			[Token(Token = "0x4000AF0")]
			PinchDown,
			[Token(Token = "0x4000AF1")]
			PinchStay,
			[Token(Token = "0x4000AF2")]
			PinchUp
		}

		[Token(Token = "0x400073E")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x1700006A")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x9692F0", Offset = "0x9692F0", VA = "0x9692F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x969378", Offset = "0x969378", VA = "0x969378")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x969400", Offset = "0x969400", VA = "0x969400")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x969488", Offset = "0x969488", VA = "0x969488")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x9694B4", Offset = "0x9694B4", VA = "0x9694B4")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x4000741")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x4000742")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x4000743")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x4000744")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x4000745")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D630", Offset = "0x52D630")]
		[SerializeField]
		private float _coneAngleDegrees;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x1700006D")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x96E6B4", Offset = "0x96E6B4", VA = "0x96E6B4", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x1700006E")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x96E6BC", Offset = "0x96E6BC", VA = "0x96E6BC", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x1700006F")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x96E724", Offset = "0x96E724", VA = "0x96E724", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		public override bool EnableState
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x96E72C", Offset = "0x96E72C", VA = "0x96E72C", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x96E774", Offset = "0x96E774", VA = "0x96E774", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x96E7EC", Offset = "0x96E7EC", VA = "0x96E7EC", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x96E84C", Offset = "0x96E84C", VA = "0x96E84C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x96E8FC", Offset = "0x96E8FC", VA = "0x96E8FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x96EBB8", Offset = "0x96EBB8", VA = "0x96EBB8")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x96EC40", Offset = "0x96EC40", VA = "0x96EC40", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x96EFD8", Offset = "0x96EFD8", VA = "0x96EFD8")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x96F0E8", Offset = "0x96F0E8", VA = "0x96F0E8")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x96F20C", Offset = "0x96F20C", VA = "0x96F20C")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x96F504", Offset = "0x96F504", VA = "0x96F504")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x96F88C", Offset = "0x96F88C", VA = "0x96F88C", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x96F95C", Offset = "0x96F95C", VA = "0x96F95C", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x96F990", Offset = "0x96F990", VA = "0x96F990")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class RayToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000751")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x4000752")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52D6A4", Offset = "0x52D6A4")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x17000071")]
		public bool EnableState
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x96E754", Offset = "0x96E754", VA = "0x96E754", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x96E794", Offset = "0x96E794", VA = "0x96E794", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public bool ToolActivateState
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x96FA70", Offset = "0x96FA70", VA = "0x96FA70", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x96EB78", Offset = "0x96EB78", VA = "0x96EB78", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x96FCB4", Offset = "0x96FCB4", VA = "0x96FCB4", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530500", Offset = "0x530500")]
			get
			{
				return null;
			}
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x96FCBC", Offset = "0x96FCBC", VA = "0x96FCBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530510", Offset = "0x530510")]
			set
			{
			}
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x96FA78", Offset = "0x96FA78", VA = "0x96FA78")]
		private void Awake()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x96F8C0", Offset = "0x96F8C0", VA = "0x96F8C0", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x96FCC4", Offset = "0x96FCC4", VA = "0x96FCC4")]
		private void Update()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x96FF38", Offset = "0x96FF38", VA = "0x96FF38")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x970028", Offset = "0x970028", VA = "0x970028")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x17000074")]
		public bool UseSpherecast
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x95849C", Offset = "0x95849C", VA = "0x95849C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x9584A4", Offset = "0x9584A4", VA = "0x9584A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x95852C", Offset = "0x95852C", VA = "0x95852C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x958534", Offset = "0x958534", VA = "0x958534")]
			set
			{
			}
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x9585A0", Offset = "0x9585A0", VA = "0x9585A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x95884C", Offset = "0x95884C", VA = "0x95884C")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x95885C", Offset = "0x95885C", VA = "0x95885C")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x95886C", Offset = "0x95886C", VA = "0x95886C")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x9530FC", Offset = "0x9530FC", VA = "0x9530FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x953100", Offset = "0x953100", VA = "0x953100")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x953138", Offset = "0x953138", VA = "0x953138")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x953170", Offset = "0x953170", VA = "0x953170")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x9531A8", Offset = "0x9531A8", VA = "0x9531A8")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x9531E0", Offset = "0x9531E0", VA = "0x9531E0")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x953218", Offset = "0x953218", VA = "0x953218")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x953250", Offset = "0x953250", VA = "0x953250")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x9533A4", Offset = "0x9533A4", VA = "0x9533A4")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x953414", Offset = "0x953414", VA = "0x953414")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x95341C", Offset = "0x95341C", VA = "0x95341C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x953420", Offset = "0x953420", VA = "0x953420")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x9533D8", Offset = "0x9533D8", VA = "0x9533D8")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x953460", Offset = "0x953460", VA = "0x953460")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x20001EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B764", Offset = "0x52B764")]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000AF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000AF4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000AF5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x4000AF6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x4000AF7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x4000AF8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x1700010F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A38")]
				[Address(RVA = "0x8655D0", Offset = "0x8655D0", VA = "0x8655D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000110")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A3A")]
				[Address(RVA = "0x865618", Offset = "0x865618", VA = "0x865618", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x8653F0", Offset = "0x8653F0", VA = "0x8653F0")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x86541C", Offset = "0x86541C", VA = "0x86541C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x865420", Offset = "0x865420", VA = "0x865420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x8655D8", Offset = "0x8655D8", VA = "0x8655D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000762")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x4000763")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x9687F4", Offset = "0x9687F4", VA = "0x9687F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x96889C", Offset = "0x96889C", VA = "0x96889C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x968AD8", Offset = "0x968AD8", VA = "0x968AD8")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x968A64", Offset = "0x968A64", VA = "0x968A64")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x530520", Offset = "0x530520")]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x968B24", Offset = "0x968B24", VA = "0x968B24")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x20001EC")]
		public enum SelectionState
		{
			[Token(Token = "0x4000AFA")]
			Off,
			[Token(Token = "0x4000AFB")]
			Selected,
			[Token(Token = "0x4000AFC")]
			Highlighted
		}

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x17000076")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x973158", Offset = "0x973158", VA = "0x973158")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x973160", Offset = "0x973160", VA = "0x973160")]
			set
			{
			}
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x9732E4", Offset = "0x9732E4", VA = "0x9732E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x9734A4", Offset = "0x9734A4", VA = "0x9734A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x9731E8", Offset = "0x9731E8", VA = "0x9731E8")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x973590", Offset = "0x973590", VA = "0x973590")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x20001ED")]
		public enum SegmentType
		{
			[Token(Token = "0x4000AFE")]
			Straight,
			[Token(Token = "0x4000AFF")]
			LeftTurn,
			[Token(Token = "0x4000B00")]
			RightTurn,
			[Token(Token = "0x4000B01")]
			Switch
		}

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x4000778")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x4000779")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52D784", Offset = "0x52D784")]
		private float <StartDistance>k__BackingField;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x17000077")]
		public float StartDistance
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0xAE5754", Offset = "0xAE5754", VA = "0xAE5754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530588", Offset = "0x530588")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0xAE575C", Offset = "0xAE575C", VA = "0xAE575C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530598", Offset = "0x530598")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public float GridSize
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0xAE5764", Offset = "0xAE5764", VA = "0xAE5764")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000694")]
			[Address(RVA = "0xAE576C", Offset = "0xAE576C", VA = "0xAE576C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public int SubDivCount
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0xAE5774", Offset = "0xAE5774", VA = "0xAE5774")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0xAE577C", Offset = "0xAE577C", VA = "0xAE577C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public SegmentType Type
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0xAE5784", Offset = "0xAE5784", VA = "0xAE5784")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x1700007B")]
		public Pose EndPose
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0xAE578C", Offset = "0xAE578C", VA = "0xAE578C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public float Radius
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0xAE5AA0", Offset = "0xAE5AA0", VA = "0xAE5AA0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700007D")]
		public float SegmentLength
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0xAE57F4", Offset = "0xAE57F4", VA = "0xAE57F4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xAE5AB0", Offset = "0xAE5AB0", VA = "0xAE5AB0")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xAE5AC8", Offset = "0xAE5AC8", VA = "0xAE5AC8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xAE5834", Offset = "0xAE5834", VA = "0xAE5834")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xAE5ACC", Offset = "0xAE5ACC", VA = "0xAE5ACC")]
		private void Update()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xAE5AD0", Offset = "0xAE5AD0", VA = "0xAE5AD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xAE5B40", Offset = "0xAE5B40", VA = "0xAE5B40")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xAE6400", Offset = "0xAE6400", VA = "0xAE6400")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xAE6684", Offset = "0xAE6684", VA = "0xAE6684")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x20001EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B774", Offset = "0x52B774")]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x4000B05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x4000B06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x17000111")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A3E")]
				[Address(RVA = "0x8694DC", Offset = "0x8694DC", VA = "0x8694DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000112")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A40")]
				[Address(RVA = "0x869524", Offset = "0x869524", VA = "0x869524", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x869348", Offset = "0x869348", VA = "0x869348")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x869374", Offset = "0x869374", VA = "0x869374", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x869378", Offset = "0x869378", VA = "0x869378", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x8694E4", Offset = "0x8694E4", VA = "0x8694E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400077F")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x4000780")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xAE6730", Offset = "0xAE6730", VA = "0xAE6730")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xAE67E0", Offset = "0xAE67E0", VA = "0xAE67E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xAE6890", Offset = "0xAE6890", VA = "0xAE6890")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xAE6A08", Offset = "0xAE6A08", VA = "0xAE6A08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xAE6BD0", Offset = "0xAE6BD0", VA = "0xAE6BD0")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xAE6CB8", Offset = "0xAE6CB8", VA = "0xAE6CB8")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xAE6EBC", Offset = "0xAE6EBC", VA = "0xAE6EBC")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xAE6DCC", Offset = "0xAE6DCC", VA = "0xAE6DCC")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xAE6DE0", Offset = "0xAE6DE0", VA = "0xAE6DE0")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xAE6F14", Offset = "0xAE6F14", VA = "0xAE6F14")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5305A8", Offset = "0x5305A8")]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xAE6F88", Offset = "0xAE6F88", VA = "0xAE6F88")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x1700007E")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0xAE7038", Offset = "0xAE7038", VA = "0xAE7038")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xAE7048", Offset = "0xAE7048", VA = "0xAE7048", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xAE7050", Offset = "0xAE7050", VA = "0xAE7050", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xAE7390", Offset = "0xAE7390", VA = "0xAE7390")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x4000793")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x4000794")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52D884", Offset = "0x52D884")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x1700007F")]
		public float Distance
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0xAE7490", Offset = "0xAE7490", VA = "0xAE7490")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530610", Offset = "0x530610")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0xAE7498", Offset = "0xAE7498", VA = "0xAE7498")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530620", Offset = "0x530620")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public float Scale
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0xAE74A0", Offset = "0xAE74A0", VA = "0xAE74A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0xAE74A8", Offset = "0xAE74A8", VA = "0xAE74A8")]
			set
			{
			}
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xAE704C", Offset = "0xAE704C", VA = "0xAE704C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xAE74B0", Offset = "0xAE74B0", VA = "0xAE74B0")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xAE7098", Offset = "0xAE7098", VA = "0xAE7098")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xAE72BC", Offset = "0xAE72BC", VA = "0xAE72BC")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x60006BA")]
		public abstract void UpdatePosition();

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xAE7404", Offset = "0xAE7404", VA = "0xAE7404")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x20001EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B784", Offset = "0x52B784")]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x4000B0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x4000B0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x4000B0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x4000B0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x4000B0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x4000B0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x4000B10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x4000B11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x4000B12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x17000113")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A44")]
				[Address(RVA = "0x86977C", Offset = "0x86977C", VA = "0x86977C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000114")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A46")]
				[Address(RVA = "0x8697C4", Offset = "0x8697C4", VA = "0x8697C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x86952C", Offset = "0x86952C", VA = "0x86952C")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x869558", Offset = "0x869558", VA = "0x869558", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x86955C", Offset = "0x86955C", VA = "0x86955C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x869784", Offset = "0x869784", VA = "0x869784", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xAE763C", Offset = "0xAE763C", VA = "0xAE763C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xAE7688", Offset = "0xAE7688", VA = "0xAE7688")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xAE7790", Offset = "0xAE7790", VA = "0xAE7790")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xAE78D8", Offset = "0xAE78D8", VA = "0xAE78D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xAE77EC", Offset = "0xAE77EC", VA = "0xAE77EC")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xAE79B8", Offset = "0xAE79B8", VA = "0xAE79B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x530630", Offset = "0x530630")]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xAE7A3C", Offset = "0xAE7A3C", VA = "0xAE7A3C")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xAE7AE8", Offset = "0xAE7AE8", VA = "0xAE7AE8")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xAE7B48", Offset = "0xAE7B48", VA = "0xAE7B48")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x20001F0")]
		private enum EngineSoundState
		{
			[Token(Token = "0x4000B14")]
			Start,
			[Token(Token = "0x4000B15")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x4000B16")]
			Stop
		}

		[Token(Token = "0x20001F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B794", Offset = "0x52B794")]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x4000B1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x4000B1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x4000B1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x4000B1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x4000B1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x4000B1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x17000115")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A4A")]
				[Address(RVA = "0x869A1C", Offset = "0x869A1C", VA = "0x869A1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000116")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A4C")]
				[Address(RVA = "0x869A64", Offset = "0x869A64", VA = "0x869A64", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x8697CC", Offset = "0x8697CC", VA = "0x8697CC")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x8697F8", Offset = "0x8697F8", VA = "0x8697F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x8697FC", Offset = "0x8697FC", VA = "0x8697FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x869A24", Offset = "0x869A24", VA = "0x869A24", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007A7")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x40007A8")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x40007A9")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x40007AA")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52D8E4", Offset = "0x52D8E4")]
		protected float _initialSpeed;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xAE7BAC", Offset = "0xAE7BAC", VA = "0xAE7BAC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xAE7D00", Offset = "0xAE7D00", VA = "0xAE7D00")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xAE7D0C", Offset = "0xAE7D0C", VA = "0xAE7D0C", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xAE7E5C", Offset = "0xAE7E5C", VA = "0xAE7E5C")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xAE7C80", Offset = "0xAE7C80", VA = "0xAE7C80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x530698", Offset = "0x530698")]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xAE7EA4", Offset = "0xAE7EA4", VA = "0xAE7EA4")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xAE7DF8", Offset = "0xAE7DF8", VA = "0xAE7DF8")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xAE80A8", Offset = "0xAE80A8", VA = "0xAE80A8")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xAE81CC", Offset = "0xAE81CC", VA = "0xAE81CC")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xAE8114", Offset = "0xAE8114", VA = "0xAE8114")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xAE8238", Offset = "0xAE8238", VA = "0xAE8238")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xAE8258", Offset = "0xAE8258", VA = "0xAE8258")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xAE82E4", Offset = "0xAE82E4", VA = "0xAE82E4")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xAE83A8", Offset = "0xAE83A8", VA = "0xAE83A8")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xAE83B8", Offset = "0xAE83B8", VA = "0xAE83B8")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x17000081")]
		public float TrackLength
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0xAE8428", Offset = "0xAE8428", VA = "0xAE8428")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0xAE8430", Offset = "0xAE8430", VA = "0xAE8430")]
			private set
			{
			}
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xAE8438", Offset = "0xAE8438", VA = "0xAE8438")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xAE751C", Offset = "0xAE751C", VA = "0xAE751C")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xAE843C", Offset = "0xAE843C", VA = "0xAE843C")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xAE863C", Offset = "0xAE863C", VA = "0xAE863C")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xAE8738", Offset = "0xAE8738", VA = "0xAE8738")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class Pose
	{
		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x96AD34", Offset = "0x96AD34", VA = "0x96AD34")]
		public Pose()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x96AD78", Offset = "0x96AD78", VA = "0x96AD78")]
		public Pose(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x20001F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B7A4", Offset = "0x52B7A4")]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000B23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x4000B24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x4000B25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x17000117")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A50")]
				[Address(RVA = "0x11A7C6C", Offset = "0x11A7C6C", VA = "0x11A7C6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000118")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A52")]
				[Address(RVA = "0x11A7CB4", Offset = "0x11A7CB4", VA = "0x11A7CB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x11A7AC4", Offset = "0x11A7AC4", VA = "0x11A7AC4")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x11A7AF0", Offset = "0x11A7AF0", VA = "0x11A7AF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x11A7AF4", Offset = "0x11A7AF4", VA = "0x11A7AF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x11A7C74", Offset = "0x11A7C74", VA = "0x11A7C74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B7B4", Offset = "0x52B7B4")]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000B29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x4000B2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x4000B2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x17000119")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A56")]
				[Address(RVA = "0x11A7DB8", Offset = "0x11A7DB8", VA = "0x11A7DB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A58")]
				[Address(RVA = "0x11A7E00", Offset = "0x11A7E00", VA = "0x11A7E00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x11A7CBC", Offset = "0x11A7CBC", VA = "0x11A7CBC")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x11A7CE8", Offset = "0x11A7CE8", VA = "0x11A7CE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x11A7CEC", Offset = "0x11A7CEC", VA = "0x11A7CEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x11A7DC0", Offset = "0x11A7DC0", VA = "0x11A7DC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007CD")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52DACC", Offset = "0x52DACC")]
		private bool <IsMoving>k__BackingField;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x17000082")]
		public bool IsMoving
		{
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0xAEC078", Offset = "0xAEC078", VA = "0xAEC078")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530700", Offset = "0x530700")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0xAEC080", Offset = "0xAEC080", VA = "0xAEC080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530710", Offset = "0x530710")]
			private set
			{
			}
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xAEC08C", Offset = "0xAEC08C", VA = "0xAEC08C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xAEC0C8", Offset = "0xAEC0C8", VA = "0xAEC0C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xAEC1AC", Offset = "0xAEC1AC", VA = "0xAEC1AC")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xAEC214", Offset = "0xAEC214", VA = "0xAEC214")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x530720", Offset = "0x530720")]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xAEC298", Offset = "0xAEC298", VA = "0xAEC298")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x530788", Offset = "0x530788")]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xAEC330", Offset = "0xAEC330", VA = "0xAEC330")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xAEC39C", Offset = "0xAEC39C", VA = "0xAEC39C")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xAEC3A4", Offset = "0xAEC3A4", VA = "0xAEC3A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xAEC410", Offset = "0xAEC410", VA = "0xAEC410")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xAEC4F4", Offset = "0xAEC4F4", VA = "0xAEC4F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xAEC62C", Offset = "0xAEC62C", VA = "0xAEC62C")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xAEC6A8", Offset = "0xAEC6A8", VA = "0xAEC6A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xAEC788", Offset = "0xAEC788", VA = "0xAEC788")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x2000146")]
	public enum EUiDisplayType
	{
		[Token(Token = "0x40007DE")]
		EUDT_WorldGeoQuad,
		[Token(Token = "0x40007DF")]
		EUDT_OverlayQuad,
		[Token(Token = "0x40007E0")]
		EUDT_None,
		[Token(Token = "0x40007E1")]
		EUDT_MaxDislayTypes
	}
	[Token(Token = "0x2000147")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x20001F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B7C4", Offset = "0x52B7C4")]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x1700011B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A5C")]
				[Address(RVA = "0x863CC4", Offset = "0x863CC4", VA = "0x863CC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A5E")]
				[Address(RVA = "0x863D0C", Offset = "0x863D0C", VA = "0x863D0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x863AB0", Offset = "0x863AB0", VA = "0x863AB0")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x863ADC", Offset = "0x863ADC", VA = "0x863ADC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x863AE0", Offset = "0x863AE0", VA = "0x863AE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x863CCC", Offset = "0x863CCC", VA = "0x863CCC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x40007E3")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x40007E4")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x40007E5")]
		private const string noneID = "NoneID";

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52DB0C", Offset = "0x52DB0C")]
		public GameObject mainCamera;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52DB44", Offset = "0x52DB44")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xC86484", Offset = "0xC86484", VA = "0xC86484")]
		private void Start()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xC86C98", Offset = "0xC86C98", VA = "0xC86C98")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xC86DEC", Offset = "0xC86DEC", VA = "0xC86DEC")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xC86F18", Offset = "0xC86F18", VA = "0xC86F18")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xC87044", Offset = "0xC87044", VA = "0xC87044")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xC86DC0", Offset = "0xC86DC0", VA = "0xC86DC0")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xC87124", Offset = "0xC87124", VA = "0xC87124")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5307F0", Offset = "0x5307F0")]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xC87198", Offset = "0xC87198", VA = "0xC87198")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xC868C4", Offset = "0xC868C4", VA = "0xC868C4")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xC872F4", Offset = "0xC872F4", VA = "0xC872F4")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xC871CC", Offset = "0xC871CC", VA = "0xC871CC")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xC87604", Offset = "0xC87604", VA = "0xC87604")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xC876F4", Offset = "0xC876F4", VA = "0xC876F4")]
		public OVROverlaySample()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xC87780", Offset = "0xC87780", VA = "0xC87780")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530858", Offset = "0x530858")]
		private void <Start>b__24_0(Toggle t)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xC877E0", Offset = "0xC877E0", VA = "0xC877E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530868", Offset = "0x530868")]
		private void <Start>b__24_1(Toggle t)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xC87840", Offset = "0xC87840", VA = "0xC87840")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x530878", Offset = "0x530878")]
		private void <Start>b__24_2(Toggle t)
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x2000148")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x52B2C4", Offset = "0x52B2C4")]
	public class Hand : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B7D4", Offset = "0x52B7D4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000B2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000B30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Collider, bool> <>9__28_0;

			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x85F44C", Offset = "0x85F44C", VA = "0x85F44C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x85F454", Offset = "0x85F454", VA = "0x85F454")]
			internal bool <Start>b__28_0(Collider childCollider)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40007FA")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x40007FB")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x40007FC")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x40007FD")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x40007FE")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x40007FF")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x4000800")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x4000801")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x4000802")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x4000803")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x4000804")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x95C944", Offset = "0x95C944", VA = "0x95C944")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x95C9A0", Offset = "0x95C9A0", VA = "0x95C9A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x95CE24", Offset = "0x95CE24", VA = "0x95CE24")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x95CF18", Offset = "0x95CF18", VA = "0x95CF18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x95D084", Offset = "0x95D084", VA = "0x95D084")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x95D394", Offset = "0x95D394", VA = "0x95D394")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x95D48C", Offset = "0x95D48C", VA = "0x95D48C")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x95D5EC", Offset = "0x95D5EC", VA = "0x95D5EC")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x95D124", Offset = "0x95D124", VA = "0x95D124")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x95D178", Offset = "0x95D178", VA = "0x95D178")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x95CCC8", Offset = "0x95CCC8", VA = "0x95CCC8")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x95D728", Offset = "0x95D728", VA = "0x95D728")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x2000149")]
	public enum HandPoseId
	{
		[Token(Token = "0x4000817")]
		Default,
		[Token(Token = "0x4000818")]
		Generic,
		[Token(Token = "0x4000819")]
		PingPongBall,
		[Token(Token = "0x400081A")]
		Controller
	}
	[Token(Token = "0x200014A")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x17000083")]
		public bool AllowPointing
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x95DA18", Offset = "0x95DA18", VA = "0x95DA18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x95DA20", Offset = "0x95DA20", VA = "0x95DA20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x95DA28", Offset = "0x95DA28", VA = "0x95DA28")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x95DA30", Offset = "0x95DA30", VA = "0x95DA30")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x200014B")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xAE53BC", Offset = "0xAE53BC", VA = "0xAE53BC")]
		private void Update()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xAE56AC", Offset = "0xAE56AC", VA = "0xAE56AC")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xAE5708", Offset = "0xAE5708", VA = "0xAE5708")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xAE574C", Offset = "0xAE574C", VA = "0xAE574C")]
		public TouchController()
		{
		}
	}
}
namespace Oculus.Spatializer.Propagation
{
	[Token(Token = "0x200014C")]
	public enum FaceType : uint
	{
		[Token(Token = "0x4000822")]
		TRIANGLES,
		[Token(Token = "0x4000823")]
		QUADS
	}
	[Token(Token = "0x200014D")]
	public enum MaterialProperty : uint
	{
		[Token(Token = "0x4000825")]
		ABSORPTION,
		[Token(Token = "0x4000826")]
		TRANSMISSION,
		[Token(Token = "0x4000827")]
		SCATTERING
	}
	[Token(Token = "0x200014E")]
	public struct MeshGroup
	{
		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UIntPtr indexOffset;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public UIntPtr faceCount;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FaceType faceType;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public IntPtr material;
	}
}
namespace Oculus.Avatar
{
	[Token(Token = "0x200014F")]
	public static class AvatarLogger
	{
		[Token(Token = "0x400082C")]
		public const string LogAvatar = "[Avatars] - ";

		[Token(Token = "0x400082D")]
		public const string Tab = "    ";

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x9BBAD0", Offset = "0x9BBAD0", VA = "0x9BBAD0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x530888", Offset = "0x530888")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x530888", Offset = "0x530888")]
		public static void Log(string logMsg)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x9BBB68", Offset = "0x9BBB68", VA = "0x9BBB68")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x5308E8", Offset = "0x5308E8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x5308E8", Offset = "0x5308E8")]
		public static void Log(string logMsg, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x9BBC10", Offset = "0x9BBC10", VA = "0x9BBC10")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x530948", Offset = "0x530948")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x530948", Offset = "0x530948")]
		public static void LogWarning(string logMsg)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x9BBCA8", Offset = "0x9BBCA8", VA = "0x9BBCA8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x5309A8", Offset = "0x5309A8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x5309A8", Offset = "0x5309A8")]
		public static void LogError(string logMsg)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x9BBD40", Offset = "0x9BBD40", VA = "0x9BBD40")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x530A08", Offset = "0x530A08")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x530A08", Offset = "0x530A08")]
		public static void LogError(string logMsg, UnityEngine.Object context)
		{
		}
	}
	[Token(Token = "0x2000150")]
	public class CAPI
	{
		[Token(Token = "0x20001F6")]
		public delegate void LoggingDelegate(IntPtr str);

		[Token(Token = "0x20001F7")]
		public enum Result
		{
			[Token(Token = "0x4000B32")]
			Success = 0,
			[Token(Token = "0x4000B33")]
			Failure = -1000,
			[Token(Token = "0x4000B34")]
			Failure_InvalidParameter = -1001,
			[Token(Token = "0x4000B35")]
			Failure_NotInitialized = -1002,
			[Token(Token = "0x4000B36")]
			Failure_InvalidOperation = -1003,
			[Token(Token = "0x4000B37")]
			Failure_Unsupported = -1004,
			[Token(Token = "0x4000B38")]
			Failure_NotYetImplemented = -1005,
			[Token(Token = "0x4000B39")]
			Failure_OperationFailed = -1006,
			[Token(Token = "0x4000B3A")]
			Failure_InsufficientSize = -1007
		}

		[Token(Token = "0x20001F8")]
		private static class OVRP_1_30_0
		{
			[Token(Token = "0x4000B3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Version version;

			[PreserveSig]
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x85E458", Offset = "0x85E458", VA = "0x85E458")]
			public static extern Result ovrp_SendEvent2(string name, string param, string source);
		}

		[Token(Token = "0x400082E")]
		private const string LibFile = "ovravatarloader";

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IntPtr nativeVisemeData;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IntPtr nativeGazeTargetsData;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IntPtr nativeAvatarLightsData;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IntPtr DebugLineCountData;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float[] scratchBufferFloat;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject debugLineGo;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string SDKRuntimePrefix;

		[Token(Token = "0x4000836")]
		private const string ovrPluginDLL = "OVRPlugin";

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Version ovrPluginVersion;

		[PreserveSig]
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x9BF8A8", Offset = "0x9BF8A8", VA = "0x9BF8A8")]
		public static extern void ovrAvatar_InitializeAndroidUnity(string appID);

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x9BF938", Offset = "0x9BF938", VA = "0x9BF938")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x9BFB60", Offset = "0x9BFB60", VA = "0x9BFB60")]
		public static void Shutdown()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x9BFC48", Offset = "0x9BFC48", VA = "0x9BFC48")]
		public static extern void ovrAvatar_Shutdown();

		[PreserveSig]
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x9BFCB8", Offset = "0x9BFCB8", VA = "0x9BFCB8")]
		public static extern IntPtr ovrAvatarMessage_Pop();

		[PreserveSig]
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x9BFD2C", Offset = "0x9BFD2C", VA = "0x9BFD2C")]
		public static extern ovrAvatarMessageType ovrAvatarMessage_GetType(IntPtr msg);

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x9BFDAC", Offset = "0x9BFDAC", VA = "0x9BFDAC")]
		public static ovrAvatarMessage_AvatarSpecification ovrAvatarMessage_GetAvatarSpecification(IntPtr msg)
		{
			return default(ovrAvatarMessage_AvatarSpecification);
		}

		[PreserveSig]
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x9BFEF8", Offset = "0x9BFEF8", VA = "0x9BFEF8")]
		private static extern IntPtr ovrAvatarMessage_GetAvatarSpecification_Native(IntPtr msg);

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x9BFF78", Offset = "0x9BFF78", VA = "0x9BFF78")]
		public static ovrAvatarMessage_AssetLoaded ovrAvatarMessage_GetAssetLoaded(IntPtr msg)
		{
			return default(ovrAvatarMessage_AssetLoaded);
		}

		[PreserveSig]
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x9C00C4", Offset = "0x9C00C4", VA = "0x9C00C4")]
		private static extern IntPtr ovrAvatarMessage_GetAssetLoaded_Native(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x9C0144", Offset = "0x9C0144", VA = "0x9C0144")]
		public static extern void ovrAvatarMessage_Free(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x9C01C4", Offset = "0x9C01C4", VA = "0x9C01C4")]
		public static extern IntPtr ovrAvatarSpecificationRequest_Create(ulong userID);

		[PreserveSig]
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x9C0244", Offset = "0x9C0244", VA = "0x9C0244")]
		public static extern void ovrAvatarSpecificationRequest_Destroy(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x9C02C4", Offset = "0x9C02C4", VA = "0x9C02C4")]
		public static extern void ovrAvatarSpecificationRequest_SetCombineMeshes(IntPtr specificationRequest, bool useCombinedMesh);

		[PreserveSig]
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x9C0354", Offset = "0x9C0354", VA = "0x9C0354")]
		public static extern void ovrAvatarSpecificationRequest_SetLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x9C03E4", Offset = "0x9C03E4", VA = "0x9C03E4")]
		public static extern void ovrAvatarSpecificationRequest_SetLevelOfDetail(IntPtr specificationRequest, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x9C0474", Offset = "0x9C0474", VA = "0x9C0474")]
		public static extern void ovrAvatar_RequestAvatarSpecification(ulong userID);

		[PreserveSig]
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x9C04F4", Offset = "0x9C04F4", VA = "0x9C04F4")]
		public static extern void ovrAvatar_RequestAvatarSpecificationFromSpecRequest(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x9C0574", Offset = "0x9C0574", VA = "0x9C0574")]
		public static extern void ovrAvatarSpecificationRequest_SetFallbackLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x9C0604", Offset = "0x9C0604", VA = "0x9C0604")]
		public static extern void ovrAvatarSpecificationRequest_SetExpressiveFlag(IntPtr specificationRequest, bool enable);

		[PreserveSig]
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x9C0694", Offset = "0x9C0694", VA = "0x9C0694")]
		public static extern IntPtr ovrAvatar_Create(IntPtr avatarSpecification, ovrAvatarCapabilities capabilities);

		[PreserveSig]
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x9C0724", Offset = "0x9C0724", VA = "0x9C0724")]
		public static extern void ovrAvatar_Destroy(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x9C07A4", Offset = "0x9C07A4", VA = "0x9C07A4")]
		public static extern void ovrAvatarPose_UpdateBody(IntPtr avatar, ovrAvatarTransform headPose);

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x9C0844", Offset = "0x9C0844", VA = "0x9C0844")]
		public static void ovrAvatarPose_UpdateVoiceVisualization(IntPtr avatar, float[] pcmData)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x9C08C0", Offset = "0x9C08C0", VA = "0x9C08C0")]
		private static extern void ovrAvatarPose_UpdateVoiceVisualization_Native(IntPtr avatar, uint pcmDataSize, [In] float[] pcmData);

		[PreserveSig]
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x9C0960", Offset = "0x9C0960", VA = "0x9C0960")]
		public static extern void ovrAvatarPose_UpdateHands(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight);

		[PreserveSig]
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x9C0A20", Offset = "0x9C0A20", VA = "0x9C0A20")]
		public static extern void ovrAvatarPose_UpdateHandsWithType(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight, ovrAvatarControllerType type);

		[PreserveSig]
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x9C0AE8", Offset = "0x9C0AE8", VA = "0x9C0AE8")]
		public static extern void ovrAvatarPose_Finalize(IntPtr avatar, float elapsedSeconds);

		[PreserveSig]
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x9C0B78", Offset = "0x9C0B78", VA = "0x9C0B78")]
		public static extern void ovrAvatar_SetLeftControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x9C0C08", Offset = "0x9C0C08", VA = "0x9C0C08")]
		public static extern void ovrAvatar_SetRightControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x9C0C98", Offset = "0x9C0C98", VA = "0x9C0C98")]
		public static extern void ovrAvatar_SetLeftHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x9C0D28", Offset = "0x9C0D28", VA = "0x9C0D28")]
		public static extern void ovrAvatar_SetRightHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x9C0DB8", Offset = "0x9C0DB8", VA = "0x9C0DB8")]
		public static extern uint ovrAvatarComponent_Count(IntPtr avatar);

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x9C0E38", Offset = "0x9C0E38", VA = "0x9C0E38")]
		public static void ovrAvatarComponent_Get(IntPtr avatar, uint index, bool includeName, ovrAvatarComponent component)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x9C0F54", Offset = "0x9C0F54", VA = "0x9C0F54")]
		public static void ovrAvatarComponent_Get(IntPtr componentPtr, bool includeName, ovrAvatarComponent component)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x9C0EC4", Offset = "0x9C0EC4", VA = "0x9C0EC4")]
		public static extern IntPtr ovrAvatarComponent_Get_Native(IntPtr avatar, uint index);

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x9C116C", Offset = "0x9C116C", VA = "0x9C116C")]
		public static bool ovrAvatarPose_GetBaseComponent(IntPtr avatar, ovrAvatarBaseComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x9C12E4", Offset = "0x9C12E4", VA = "0x9C12E4")]
		private static extern IntPtr ovrAvatarPose_GetBaseComponent_Native(IntPtr avatar);

		[Token(Token = "0x600073C")]
		public static IntPtr MarshalRenderComponent<T>(IntPtr ptr) where T : struct
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x9C1364", Offset = "0x9C1364", VA = "0x9C1364")]
		public static bool ovrAvatarPose_GetBodyComponent(IntPtr avatar, ovrAvatarBodyComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x9C1614", Offset = "0x9C1614", VA = "0x9C1614")]
		private static extern IntPtr ovrAvatarPose_GetBodyComponent_Native(IntPtr avatar);

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x9C1694", Offset = "0x9C1694", VA = "0x9C1694")]
		public static bool ovrAvatarPose_GetLeftControllerComponent(IntPtr avatar, ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x9C180C", Offset = "0x9C180C", VA = "0x9C180C")]
		private static extern IntPtr ovrAvatarPose_GetLeftControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x9C188C", Offset = "0x9C188C", VA = "0x9C188C")]
		public static bool ovrAvatarPose_GetRightControllerComponent(IntPtr avatar, ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x9C1A04", Offset = "0x9C1A04", VA = "0x9C1A04")]
		private static extern IntPtr ovrAvatarPose_GetRightControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x9C1A84", Offset = "0x9C1A84", VA = "0x9C1A84")]
		public static bool ovrAvatarPose_GetLeftHandComponent(IntPtr avatar, ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x9C1BFC", Offset = "0x9C1BFC", VA = "0x9C1BFC")]
		private static extern IntPtr ovrAvatarPose_GetLeftHandComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x9C1C7C", Offset = "0x9C1C7C", VA = "0x9C1C7C")]
		public static bool ovrAvatarPose_GetRightHandComponent(IntPtr avatar, ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x9C1DF4", Offset = "0x9C1DF4", VA = "0x9C1DF4")]
		private static extern IntPtr ovrAvatarPose_GetRightHandComponent_Native(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x9C1E74", Offset = "0x9C1E74", VA = "0x9C1E74")]
		public static extern void ovrAvatarAsset_BeginLoading(ulong assetID);

		[PreserveSig]
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x9C1EF4", Offset = "0x9C1EF4", VA = "0x9C1EF4")]
		public static extern bool ovrAvatarAsset_BeginLoadingLOD(ulong assetId, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x9C1F8C", Offset = "0x9C1F8C", VA = "0x9C1F8C")]
		public static extern ovrAvatarAssetType ovrAvatarAsset_GetType(IntPtr assetHandle);

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x9C200C", Offset = "0x9C200C", VA = "0x9C200C")]
		public static ovrAvatarMeshAssetData ovrAvatarAsset_GetMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetData);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x9C21EC", Offset = "0x9C21EC", VA = "0x9C21EC")]
		public static ovrAvatarMeshAssetDataV2 ovrAvatarAsset_GetCombinedMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetDataV2);
		}

		[PreserveSig]
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x9C234C", Offset = "0x9C234C", VA = "0x9C234C")]
		private static extern IntPtr ovrAvatarAsset_GetCombinedMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x9C216C", Offset = "0x9C216C", VA = "0x9C216C")]
		private static extern IntPtr ovrAvatarAsset_GetMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x9C23CC", Offset = "0x9C23CC", VA = "0x9C23CC")]
		public static extern uint ovrAvatarAsset_GetMeshBlendShapeCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x9C244C", Offset = "0x9C244C", VA = "0x9C244C")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeName(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x9C24DC", Offset = "0x9C24DC", VA = "0x9C24DC")]
		public static extern uint ovrAvatarAsset_GetSubmeshCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x9C255C", Offset = "0x9C255C", VA = "0x9C255C")]
		public static extern uint ovrAvatarAsset_GetSubmeshLastIndex(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x9C25EC", Offset = "0x9C25EC", VA = "0x9C25EC")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeVertices(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x9C266C", Offset = "0x9C266C", VA = "0x9C266C")]
		public static extern IntPtr ovrAvatarAsset_GetAvatar(IntPtr assetHandle);

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x9C26EC", Offset = "0x9C26EC", VA = "0x9C26EC")]
		public static ulong[] ovrAvatarAsset_GetCombinedMeshIDs(IntPtr assetHandle)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x9C2978", Offset = "0x9C2978", VA = "0x9C2978")]
		public static extern IntPtr ovrAvatarAsset_GetCombinedMeshIDs_Native(IntPtr assetHandle, IntPtr count);

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x9C2A08", Offset = "0x9C2A08", VA = "0x9C2A08")]
		public static void ovrAvatar_GetCombinedMeshAlphaData(IntPtr avatar, ulong textureID, Vector4 offset)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x9C2C38", Offset = "0x9C2C38", VA = "0x9C2C38")]
		public static extern IntPtr ovrAvatar_GetCombinedMeshAlphaData_Native(IntPtr avatar, IntPtr textureIDPtr, IntPtr offsetPtr);

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x9C2CD0", Offset = "0x9C2CD0", VA = "0x9C2CD0")]
		public static ovrAvatarTextureAssetData ovrAvatarAsset_GetTextureData(IntPtr assetPtr)
		{
			return default(ovrAvatarTextureAssetData);
		}

		[PreserveSig]
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x9C2E28", Offset = "0x9C2E28", VA = "0x9C2E28")]
		private static extern IntPtr ovrAvatarAsset_GetTextureData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x9C2EA8", Offset = "0x9C2EA8", VA = "0x9C2EA8")]
		private static extern IntPtr ovrAvatarAsset_GetMaterialData_Native(IntPtr assetPtr);

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x9C2F28", Offset = "0x9C2F28", VA = "0x9C2F28")]
		public static ovrAvatarMaterialState ovrAvatarAsset_GetMaterialState(IntPtr assetPtr)
		{
			return default(ovrAvatarMaterialState);
		}

		[PreserveSig]
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x9C3084", Offset = "0x9C3084", VA = "0x9C3084")]
		public static extern ovrAvatarRenderPartType ovrAvatarRenderPart_GetType(IntPtr renderPart);

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x9C3104", Offset = "0x9C3104", VA = "0x9C3104")]
		public static ovrAvatarRenderPart_SkinnedMeshRender ovrAvatarRenderPart_GetSkinnedMeshRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRender);
		}

		[PreserveSig]
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x9C3260", Offset = "0x9C3260", VA = "0x9C3260")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x9C32E0", Offset = "0x9C32E0", VA = "0x9C32E0")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x9C3370", Offset = "0x9C3370", VA = "0x9C3370")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x9C3400", Offset = "0x9C3400", VA = "0x9C3400")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x9C3490", Offset = "0x9C3490", VA = "0x9C3490")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRender_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x9C3510", Offset = "0x9C3510", VA = "0x9C3510")]
		public static extern bool ovrAvatarSkinnedMeshRender_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x9C3598", Offset = "0x9C3598", VA = "0x9C3598")]
		public static extern bool ovrAvatarSkinnedMeshRenderPBSV2_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x9C3620", Offset = "0x9C3620", VA = "0x9C3620")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBS_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x9C36A0", Offset = "0x9C36A0", VA = "0x9C36A0")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBSV2_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x9C3720", Offset = "0x9C3720", VA = "0x9C3720")]
		public static extern ovrAvatarMaterialState ovrAvatarSkinnedMeshRender_GetMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x9C37D4", Offset = "0x9C37D4", VA = "0x9C37D4")]
		public static extern ovrAvatarPBSMaterialState ovrAvatarSkinnedMeshRenderPBSV2_GetPBSMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x9C3864", Offset = "0x9C3864", VA = "0x9C3864")]
		public static extern ovrAvatarExpressiveParameters ovrAvatar_GetExpressiveParameters(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x9C38F4", Offset = "0x9C38F4", VA = "0x9C38F4")]
		public static extern ulong ovrAvatarSkinnedMeshRender_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x9C3974", Offset = "0x9C3974", VA = "0x9C3974")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x9C39F4", Offset = "0x9C39F4", VA = "0x9C39F4")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBSV2_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x9C3A74", Offset = "0x9C3A74", VA = "0x9C3A74")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x9C3B0C", Offset = "0x9C3B0C", VA = "0x9C3B0C")]
		public static extern void ovrAvatar_SetActionUnitOnsetSpeed(IntPtr avatar, float onsetSpeed);

		[PreserveSig]
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x9C3B9C", Offset = "0x9C3B9C", VA = "0x9C3B9C")]
		public static extern void ovrAvatar_SetActionUnitFalloffSpeed(IntPtr avatar, float falloffSpeed);

		[PreserveSig]
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x9C3C2C", Offset = "0x9C3C2C", VA = "0x9C3C2C")]
		public static extern void ovrAvatar_SetVisemeMultiplier(IntPtr avatar, float visemeMultiplier);

		[PreserveSig]
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x9C3CBC", Offset = "0x9C3CBC", VA = "0x9C3CBC")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x9C3D54", Offset = "0x9C3D54", VA = "0x9C3D54")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x9C3DEC", Offset = "0x9C3DEC", VA = "0x9C3DEC")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetAlbedoTextureAssetID(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x9C3E6C", Offset = "0x9C3E6C", VA = "0x9C3E6C")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetSurfaceTextureAssetID(IntPtr renderPart);

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x9C3EEC", Offset = "0x9C3EEC", VA = "0x9C3EEC")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS ovrAvatarRenderPart_GetSkinnedMeshRenderPBS(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS);
		}

		[PreserveSig]
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x9C4048", Offset = "0x9C4048", VA = "0x9C4048")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBS_Native(IntPtr renderPart);

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x9C40C8", Offset = "0x9C40C8", VA = "0x9C40C8")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2);
		}

		[PreserveSig]
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x9C4224", Offset = "0x9C4224", VA = "0x9C4224")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2_Native(IntPtr renderPart);

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x9C42A4", Offset = "0x9C42A4", VA = "0x9C42A4")]
		public static void ovrAvatarSkinnedMeshRender_GetBlendShapeParams(IntPtr renderPart, ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x9C43E0", Offset = "0x9C43E0", VA = "0x9C43E0")]
		private static extern IntPtr ovrAvatarSkinnedMeshRender_GetBlendShapeParams_Native(IntPtr renderPart);

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x9C4460", Offset = "0x9C4460", VA = "0x9C4460")]
		public static ovrAvatarRenderPart_ProjectorRender ovrAvatarRenderPart_GetProjectorRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_ProjectorRender);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x9C463C", Offset = "0x9C463C", VA = "0x9C463C")]
		public static ovrAvatarPBSMaterialState[] ovrAvatar_GetBodyPBSMaterialStates(IntPtr renderPart)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x9C491C", Offset = "0x9C491C", VA = "0x9C491C")]
		private static extern IntPtr ovrAvatar_GetBodyPBSMaterialStates_Native(IntPtr avatar, IntPtr count);

		[PreserveSig]
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x9C45BC", Offset = "0x9C45BC", VA = "0x9C45BC")]
		private static extern IntPtr ovrAvatarRenderPart_GetProjectorRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x9C49AC", Offset = "0x9C49AC", VA = "0x9C49AC")]
		public static extern uint ovrAvatar_GetReferencedAssetCount(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x9C4A2C", Offset = "0x9C4A2C", VA = "0x9C4A2C")]
		public static extern ulong ovrAvatar_GetReferencedAsset(IntPtr avatar, uint index);

		[PreserveSig]
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x9C4ABC", Offset = "0x9C4ABC", VA = "0x9C4ABC")]
		public static extern void ovrAvatar_SetLeftHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x9C4B4C", Offset = "0x9C4B4C", VA = "0x9C4B4C")]
		public static extern void ovrAvatar_SetRightHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x9C4BDC", Offset = "0x9C4BDC", VA = "0x9C4BDC")]
		public static extern void ovrAvatar_SetLeftHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x9C4C7C", Offset = "0x9C4C7C", VA = "0x9C4C7C")]
		public static extern void ovrAvatar_SetRightHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x9C4D1C", Offset = "0x9C4D1C", VA = "0x9C4D1C")]
		public static extern void ovrAvatar_UpdatePoseFromPacket(IntPtr avatar, IntPtr packet, float secondsFromStart);

		[PreserveSig]
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x9C4DBC", Offset = "0x9C4DBC", VA = "0x9C4DBC")]
		public static extern void ovrAvatarPacket_BeginRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x9C4E3C", Offset = "0x9C4E3C", VA = "0x9C4E3C")]
		public static extern IntPtr ovrAvatarPacket_EndRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x9C4EBC", Offset = "0x9C4EBC", VA = "0x9C4EBC")]
		public static extern uint ovrAvatarPacket_GetSize(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x9C4F3C", Offset = "0x9C4F3C", VA = "0x9C4F3C")]
		public static extern float ovrAvatarPacket_GetDurationSeconds(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x9C4FBC", Offset = "0x9C4FBC", VA = "0x9C4FBC")]
		public static extern void ovrAvatarPacket_Free(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x9C503C", Offset = "0x9C503C", VA = "0x9C503C")]
		public static extern bool ovrAvatarPacket_Write(IntPtr packet, uint bufferSize, [Out] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x9C5164", Offset = "0x9C5164", VA = "0x9C5164")]
		public static extern IntPtr ovrAvatarPacket_Read(uint bufferSize, [In] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x9C51FC", Offset = "0x9C51FC", VA = "0x9C51FC")]
		private static extern void ovrAvatar_SetInternalForceASTCTextures(bool value);

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x9C527C", Offset = "0x9C527C", VA = "0x9C527C")]
		public static void ovrAvatar_SetForceASTCTextures(bool value)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x9C52E4", Offset = "0x9C52E4", VA = "0x9C52E4")]
		public static void ovrAvatar_OverrideExpressiveLogic(IntPtr avatar, ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x9C543C", Offset = "0x9C543C", VA = "0x9C543C")]
		private static extern void ovrAvatar_OverrideExpressiveLogic_Native(IntPtr avatar, IntPtr state);

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x9C54CC", Offset = "0x9C54CC", VA = "0x9C54CC")]
		public static void ovrAvatar_SetVisemes(IntPtr avatar, ovrAvatarVisemes visemes)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x9C5624", Offset = "0x9C5624", VA = "0x9C5624")]
		private static extern void ovrAvatar_SetVisemes_Native(IntPtr avatar, IntPtr visemes);

		[PreserveSig]
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x9C56B4", Offset = "0x9C56B4", VA = "0x9C56B4")]
		public static extern void ovrAvatar_UpdateWorldTransform(IntPtr avatar, ovrAvatarTransform transform);

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x9C5754", Offset = "0x9C5754", VA = "0x9C5754")]
		public static void ovrAvatar_UpdateGazeTargets(ovrAvatarGazeTargets targets)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x9C5B24", Offset = "0x9C5B24", VA = "0x9C5B24")]
		private static extern void ovrAvatar_UpdateGazeTargets_Native(IntPtr targets);

		[PreserveSig]
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x9C5BA4", Offset = "0x9C5BA4", VA = "0x9C5BA4")]
		public static extern void ovrAvatar_RemoveGazeTargets(uint targetCount, uint[] ids);

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x9C5C3C", Offset = "0x9C5C3C", VA = "0x9C5C3C")]
		public static void ovrAvatar_UpdateLights(ovrAvatarLights lights)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x9C649C", Offset = "0x9C649C", VA = "0x9C649C")]
		private static extern void ovrAvatar_UpdateLights_Native(IntPtr lights);

		[PreserveSig]
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x9C651C", Offset = "0x9C651C", VA = "0x9C651C")]
		public static extern void ovrAvatar_RemoveLights(uint lightCount, uint[] ids);

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x9BF83C", Offset = "0x9BF83C", VA = "0x9BF83C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x530A68", Offset = "0x530A68")]
		public static void LoggingCallback(IntPtr str)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x9C65B4", Offset = "0x9C65B4", VA = "0x9C65B4")]
		public static extern void ovrAvatar_RegisterLoggingCallback(LoggingDelegate callback);

		[PreserveSig]
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x9C6638", Offset = "0x9C6638", VA = "0x9C6638")]
		public static extern void ovrAvatar_SetLoggingLevel(ovrAvatarLogLevel level);

		[PreserveSig]
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x9C66B8", Offset = "0x9C66B8", VA = "0x9C66B8")]
		public static extern IntPtr ovrAvatar_GetDebugTransforms_Native(IntPtr count);

		[PreserveSig]
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x9C6738", Offset = "0x9C6738", VA = "0x9C6738")]
		public static extern IntPtr ovrAvatar_GetDebugLines_Native(IntPtr count);

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x9C67B8", Offset = "0x9C67B8", VA = "0x9C67B8")]
		public static void ovrAvatar_DrawDebugLines()
		{
		}

		[PreserveSig]
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x9C7154", Offset = "0x9C7154", VA = "0x9C7154")]
		public static extern void ovrAvatar_SetDebugDrawContext(uint context);

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x9C71D4", Offset = "0x9C71D4", VA = "0x9C71D4")]
		public static bool SendEvent(string name, string param = "", string source = "")
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x9C75F4", Offset = "0x9C75F4", VA = "0x9C75F4")]
		private static extern IntPtr _ovrp_GetVersion();

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x9C755C", Offset = "0x9C755C", VA = "0x9C755C")]
		public static string ovrp_GetVersion()
		{
			return null;
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x9C7668", Offset = "0x9C7668", VA = "0x9C7668")]
		public CAPI()
		{
		}
	}
}
namespace OVR
{
	[Token(Token = "0x2000151")]
	public class TestScript : MonoBehaviour
	{
		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "InspectorNoteAttribute", RVA = "0x52DBFC", Offset = "0x52DBFC")]
		public SoundFXRef testSound1;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundFXRef testSound2;

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xAE406C", Offset = "0xAE406C", VA = "0xAE406C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xAE4070", Offset = "0xAE4070", VA = "0xAE4070")]
		private void Update()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xAE4118", Offset = "0xAE4118", VA = "0xAE4118")]
		public TestScript()
		{
		}
	}
	[Token(Token = "0x2000152")]
	public class AmbienceEmitter : MonoBehaviour
	{
		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SoundFXRef[] ambientSounds;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool autoActivate;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52DC48", Offset = "0x52DC48")]
		public bool autoRetrigger;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x52DC80", Offset = "0x52DC80")]
		public Vector2 randomRetriggerDelaySecs;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52DCA4", Offset = "0x52DCA4")]
		public Transform[] playPositions;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool activated;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int playingIdx;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float nextPlayTime;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float fadeTime;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int lastPosIdx;

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x9B4570", Offset = "0x9B4570", VA = "0x9B4570")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x9B4724", Offset = "0x9B4724", VA = "0x9B4724")]
		private void Update()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x9B4900", Offset = "0x9B4900", VA = "0x9B4900")]
		public void OnTriggerEnter(Collider col)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x9B4784", Offset = "0x9B4784", VA = "0x9B4784")]
		public void Play()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x9B49C8", Offset = "0x9B49C8", VA = "0x9B49C8")]
		public void EnableEmitter(bool enable)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x9B4B40", Offset = "0x9B4B40", VA = "0x9B4B40")]
		public AmbienceEmitter()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public enum PreloadSounds
	{
		[Token(Token = "0x4000845")]
		Default,
		[Token(Token = "0x4000846")]
		Preload,
		[Token(Token = "0x4000847")]
		ManualPreload
	}
	[Token(Token = "0x2000154")]
	public enum Fade
	{
		[Token(Token = "0x4000849")]
		In,
		[Token(Token = "0x400084A")]
		Out
	}
	[Serializable]
	[Token(Token = "0x2000155")]
	public class SoundGroup
	{
		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SoundFX[] soundList;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioMixerGroup mixerGroup;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52DCDC", Offset = "0x52DCDC")]
		public int maxPlayingSounds;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public PreloadSounds preloadAudio;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float volumeOverride;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public int playingSoundCount;

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x978C5C", Offset = "0x978C5C", VA = "0x978C5C")]
		public SoundGroup(string name)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x978D00", Offset = "0x978D00", VA = "0x978D00")]
		public SoundGroup()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x977084", Offset = "0x977084", VA = "0x977084")]
		public void IncrementPlayCount()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x977394", Offset = "0x977394", VA = "0x977394")]
		public void DecrementPlayCount()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x978224", Offset = "0x978224", VA = "0x978224")]
		public bool CanPlaySound()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000156")]
	public class AudioManager : MonoBehaviour
	{
		[Token(Token = "0x20001F9")]
		public enum Fade
		{
			[Token(Token = "0x4000B3D")]
			In,
			[Token(Token = "0x4000B3E")]
			Out
		}

		[Token(Token = "0x20001FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B7E4", Offset = "0x52B7E4")]
		private sealed class <>c__DisplayClass77_0
		{
			[Token(Token = "0x4000B3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SoundPriority priority;

			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x85D784", Offset = "0x85D784", VA = "0x85D784")]
			public <>c__DisplayClass77_0()
			{
			}

			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x85D78C", Offset = "0x85D78C", VA = "0x85D78C")]
			internal bool <FindFreeEmitter>b__0(SoundEmitter item)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20001FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B7F4", Offset = "0x52B7F4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000B40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000B41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<SoundEmitter> <>9__77_1;

			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x85D6E8", Offset = "0x85D6E8", VA = "0x85D6E8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x85D6F0", Offset = "0x85D6F0", VA = "0x85D6F0")]
			internal bool <FindFreeEmitter>b__77_1(SoundEmitter item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52DD08", Offset = "0x52DD08")]
		public bool makePersistent;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52DD40", Offset = "0x52DD40")]
		public bool enableSpatializedAudio;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52DD78", Offset = "0x52DD78")]
		public bool enableSpatializedFastOverride;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52DDB0", Offset = "0x52DDB0")]
		public AudioMixer audioMixer;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52DDE8", Offset = "0x52DDE8")]
		public AudioMixerGroup defaultMixerGroup;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52DE20", Offset = "0x52DE20")]
		public AudioMixerGroup reservedMixerGroup;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52DE58", Offset = "0x52DE58")]
		public AudioMixerGroup voiceChatMixerGroup;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52DE90", Offset = "0x52DE90")]
		public bool verboseLogging;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52DEC8", Offset = "0x52DEC8")]
		public int maxSoundEmitters;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52DF00", Offset = "0x52DF00")]
		public float volumeSoundFX;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52DF38", Offset = "0x52DF38")]
		public float soundFxFadeSecs;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float audioMinFallOffDistance;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float audioMaxFallOffDistance;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SoundGroup[] soundGroupings;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<string, SoundFX> soundFXCache;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AudioManager theAudioManager;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static FastList<string> names;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string[] defaultSound;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static SoundFX nullSound;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool hideWarnings;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float audioMaxFallOffDistanceSqr;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SoundEmitter[] soundEmitters;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private FastList<SoundEmitter> playingEmitters;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private FastList<SoundEmitter> nextFreeEmitters;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MixerSnapshot currentSnapshot;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject soundEmitterParent;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Transform staticListenerPosition;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static bool showPlayingEmitterCount;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private static bool forceShowEmitterCount;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private static bool soundEnabled;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly AnimationCurve defaultReverbZoneMix;

		[Token(Token = "0x17000086")]
		public static bool enableSpatialization
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x9B5C80", Offset = "0x9B5C80", VA = "0x9B5C80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000087")]
		public static AudioManager Instance
		{
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x9B5D68", Offset = "0x9B5D68", VA = "0x9B5D68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		public static float NearFallOff
		{
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x9B5DCC", Offset = "0x9B5DCC", VA = "0x9B5DCC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000089")]
		public static float FarFallOff
		{
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x9B5E3C", Offset = "0x9B5E3C", VA = "0x9B5E3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008A")]
		public static AudioMixerGroup EmitterGroup
		{
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x9B5EAC", Offset = "0x9B5EAC", VA = "0x9B5EAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		public static AudioMixerGroup ReservedGroup
		{
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x9B5F1C", Offset = "0x9B5F1C", VA = "0x9B5F1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public static AudioMixerGroup VoipGroup
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x9B5F8C", Offset = "0x9B5F8C", VA = "0x9B5F8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public static bool SoundEnabled
		{
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x9B7E10", Offset = "0x9B7E10", VA = "0x9B7E10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x9B5FFC", Offset = "0x9B5FFC", VA = "0x9B5FFC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x9B6238", Offset = "0x9B6238", VA = "0x9B6238")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x9B6000", Offset = "0x9B6000", VA = "0x9B6000")]
		private void Init()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x9B6E70", Offset = "0x9B6E70", VA = "0x9B6E70")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x9B6398", Offset = "0x9B6398", VA = "0x9B6398")]
		private void RebuildSoundFXCache()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x9B750C", Offset = "0x9B750C", VA = "0x9B750C")]
		public static SoundFX FindSoundFX(string name, bool rebuildCache = false)
		{
			return null;
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x9B7698", Offset = "0x9B7698", VA = "0x9B7698")]
		private static bool FindAudioManager()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x9B786C", Offset = "0x9B786C", VA = "0x9B786C")]
		public static GameObject GetGameObject()
		{
			return null;
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x9B7974", Offset = "0x9B7974", VA = "0x9B7974")]
		public static string NameMinusGroup(string name)
		{
			return null;
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x9B7A00", Offset = "0x9B7A00", VA = "0x9B7A00")]
		public static string[] GetSoundFXNames(string currentValue, [Out] int currentIdx)
		{
			return null;
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x9B7E74", Offset = "0x9B7E74", VA = "0x9B7E74")]
		private static int CalculateMaxEmittersSize()
		{
			return default(int);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x9B7EE8", Offset = "0x9B7EE8", VA = "0x9B7EE8")]
		private static bool ValidateEmitterIndex(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x9B6848", Offset = "0x9B6848", VA = "0x9B6848")]
		private void InitializeSoundSystem()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x9B6E74", Offset = "0x9B6E74", VA = "0x9B6E74")]
		private void UpdateFreeEmitters()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x9B8030", Offset = "0x9B8030", VA = "0x9B8030")]
		private string Fmt(int count)
		{
			return null;
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x9B8170", Offset = "0x9B8170", VA = "0x9B8170")]
		private string FmtFree(int count)
		{
			return null;
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x9B82B4", Offset = "0x9B82B4", VA = "0x9B82B4")]
		private void OnPreSceneLoad()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x9B7F5C", Offset = "0x9B7F5C", VA = "0x9B7F5C")]
		private void ResetFreeEmitters()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x9B83FC", Offset = "0x9B83FC", VA = "0x9B83FC")]
		public static void FadeOutSoundChannel(int channel, float delaySecs, float fadeTime)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x9B84BC", Offset = "0x9B84BC", VA = "0x9B84BC")]
		public static bool StopSound(int idx, bool fadeOut = true, bool stopReserved = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x9B85D8", Offset = "0x9B85D8", VA = "0x9B85D8")]
		public static void FadeInSound(int idx, float fadeTime, float volume)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x9B4910", Offset = "0x9B4910", VA = "0x9B4910")]
		public static void FadeInSound(int idx, float fadeTime)
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x9B4A88", Offset = "0x9B4A88", VA = "0x9B4A88")]
		public static void FadeOutSound(int idx, float fadeTime)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x9B8698", Offset = "0x9B8698", VA = "0x9B8698")]
		public static void StopAllSounds(bool fadeOut, bool stopReserved = false)
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x9B8760", Offset = "0x9B8760", VA = "0x9B8760")]
		public void MuteAllSounds(bool mute, bool muteReserved = false)
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x9B87F4", Offset = "0x9B87F4", VA = "0x9B87F4")]
		public void UnMuteAllSounds(bool unmute, bool unmuteReserved = false)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x9B88B8", Offset = "0x9B88B8", VA = "0x9B88B8")]
		public static float GetEmitterEndTime(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x9B8960", Offset = "0x9B8960", VA = "0x9B8960")]
		public static float SetEmitterTime(int idx, float time)
		{
			return default(float);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x9B8A20", Offset = "0x9B8A20", VA = "0x9B8A20")]
		public static int PlaySound(AudioClip clip, float volume, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float pitchVariance = 1f, bool loop = false)
		{
			return default(int);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x9B94AC", Offset = "0x9B94AC", VA = "0x9B94AC")]
		private static int FindFreeEmitter(EmitterChannel src, SoundPriority priority)
		{
			return default(int);
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x9B9B94", Offset = "0x9B9B94", VA = "0x9B9B94")]
		public static int PlaySound(SoundFX soundFX, EmitterChannel src = EmitterChannel.Any, float delay = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x9B9D58", Offset = "0x9B9D58", VA = "0x9B9D58")]
		public static int PlaySoundAt(Vector3 position, SoundFX soundFX, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float volumeOverride = 1f, float pitchMultiplier = 1f)
		{
			return default(int);
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x9BA878", Offset = "0x9BA878", VA = "0x9BA878")]
		public static int PlayRandomSoundAt(Vector3 position, AudioClip[] clips, float volume, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float pitch = 1f, bool loop = false)
		{
			return default(int);
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x9B8C0C", Offset = "0x9B8C0C", VA = "0x9B8C0C")]
		public static int PlaySoundAt(Vector3 position, AudioClip clip, float volume = 1f, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float pitch = 1f, bool loop = false)
		{
			return default(int);
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x9BA994", Offset = "0x9BA994", VA = "0x9BA994")]
		public static void SetOnFinished(int emitterIdx, Action onFinished)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x9BAA64", Offset = "0x9BAA64", VA = "0x9BAA64")]
		public static void SetOnFinished(int emitterIdx, Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x9BAB5C", Offset = "0x9BAB5C", VA = "0x9BAB5C")]
		public static void AttachSoundToParent(int idx, Transform parent)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x9BAD8C", Offset = "0x9BAD8C", VA = "0x9BAD8C")]
		public static void DetachSoundFromParent(int idx)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x9BAEE0", Offset = "0x9BAEE0", VA = "0x9BAEE0")]
		public static void DetachSoundsFromParent(SoundEmitter[] emitters, bool stopSounds = true)
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x9BB004", Offset = "0x9BB004", VA = "0x9BB004")]
		public static void SetEmitterMixerGroup(int idx, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x9BB130", Offset = "0x9BB130", VA = "0x9BB130")]
		public static MixerSnapshot GetActiveSnapshot()
		{
			return null;
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x9BB210", Offset = "0x9BB210", VA = "0x9BB210")]
		public static void SetCurrentSnapshot(MixerSnapshot mixerSnapshot)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x9BB34C", Offset = "0x9BB34C", VA = "0x9BB34C")]
		public static void BlendWithCurrentSnapshot(MixerSnapshot blendSnapshot, float weight, float blendTime = 0f)
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x9BB74C", Offset = "0x9BB74C", VA = "0x9BB74C")]
		public AudioManager()
		{
		}
	}
	[Token(Token = "0x2000157")]
	public enum EmitterChannel
	{
		[Token(Token = "0x4000872")]
		None = -1,
		[Token(Token = "0x4000873")]
		Reserved,
		[Token(Token = "0x4000874")]
		Any
	}
	[Serializable]
	[Token(Token = "0x2000158")]
	public class MixerSnapshot
	{
		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixerSnapshot snapshot;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float transitionTime;

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xC10610", Offset = "0xC10610", VA = "0xC10610")]
		public MixerSnapshot()
		{
		}
	}
	[Token(Token = "0x2000159")]
	public class MinMaxAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minDefaultVal;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maxDefaultVal;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float min;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float max;

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xC10534", Offset = "0xC10534", VA = "0xC10534")]
		public MinMaxAttribute(float minDefaultVal, float maxDefaultVal, float min, float max)
		{
		}
	}
	[Token(Token = "0x200015A")]
	public class SoundEmitter : MonoBehaviour
	{
		[Token(Token = "0x20001FC")]
		public enum FadeState
		{
			[Token(Token = "0x4000B43")]
			Null,
			[Token(Token = "0x4000B44")]
			FadingIn,
			[Token(Token = "0x4000B45")]
			FadingOut,
			[Token(Token = "0x4000B46")]
			Ducking
		}

		[Token(Token = "0x20001FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B804", Offset = "0x52B804")]
		private sealed class <DelayedSyncTo>d__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundEmitter <>4__this;

			[Token(Token = "0x4000B4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundEmitter other;

			[Token(Token = "0x4000B4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float fadeTime;

			[Token(Token = "0x4000B4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float toVolume;

			[Token(Token = "0x1700011D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A70")]
				[Address(RVA = "0x867228", Offset = "0x867228", VA = "0x867228", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A72")]
				[Address(RVA = "0x867270", Offset = "0x867270", VA = "0x867270", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x867114", Offset = "0x867114", VA = "0x867114")]
			[DebuggerHidden]
			public <DelayedSyncTo>d__57(int <>1__state)
			{
			}

			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x867140", Offset = "0x867140", VA = "0x867140", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x867144", Offset = "0x867144", VA = "0x867144", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x867230", Offset = "0x867230", VA = "0x867230", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B814", Offset = "0x52B814")]
		private sealed class <FadeSoundChannelTo>d__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundEmitter <>4__this;

			[Token(Token = "0x4000B50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float toVolume;

			[Token(Token = "0x4000B51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float fadeTime;

			[Token(Token = "0x4000B52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <start>5__2;

			[Token(Token = "0x4000B53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <end>5__3;

			[Token(Token = "0x4000B54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x4000B55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <elapsedTime>5__5;

			[Token(Token = "0x1700011F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A76")]
				[Address(RVA = "0x8676A4", Offset = "0x8676A4", VA = "0x8676A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000120")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A78")]
				[Address(RVA = "0x8676EC", Offset = "0x8676EC", VA = "0x8676EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x867544", Offset = "0x867544", VA = "0x867544")]
			[DebuggerHidden]
			public <FadeSoundChannelTo>d__63(int <>1__state)
			{
			}

			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x867570", Offset = "0x867570", VA = "0x867570", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x867574", Offset = "0x867574", VA = "0x867574", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x8676AC", Offset = "0x8676AC", VA = "0x8676AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x52B824", Offset = "0x52B824")]
		private sealed class <FadeSoundChannel>d__64 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000B57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000B58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delaySecs;

			[Token(Token = "0x4000B59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Fade fadeType;

			[Token(Token = "0x4000B5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float defaultVolume;

			[Token(Token = "0x4000B5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SoundEmitter <>4__this;

			[Token(Token = "0x4000B5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float fadeTime;

			[Token(Token = "0x4000B5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <start>5__2;

			[Token(Token = "0x4000B5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <end>5__3;

			[Token(Token = "0x4000B5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private bool <restartPlay>5__4;

			[Token(Token = "0x4000B60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <startTime>5__5;

			[Token(Token = "0x4000B61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float <elapsedTime>5__6;

			[Token(Token = "0x17000121")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A7C")]
				[Address(RVA = "0x8674F4", Offset = "0x8674F4", VA = "0x8674F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000122")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A7E")]
				[Address(RVA = "0x86753C", Offset = "0x86753C", VA = "0x86753C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x867278", Offset = "0x867278", VA = "0x867278")]
			[DebuggerHidden]
			public <FadeSoundChannel>d__64(int <>1__state)
			{
			}

			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x8672A4", Offset = "0x8672A4", VA = "0x8672A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x8672A8", Offset = "0x8672A8", VA = "0x8672A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0x8674FC", Offset = "0x8674FC", VA = "0x8674FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EmitterChannel channel;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disableSpatialization;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FadeState state;

		[NonSerialized]
		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public AudioSource audioSource;

		[NonSerialized]
		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public SoundPriority priority;

		[NonSerialized]
		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public ONSPAudioSource osp;

		[NonSerialized]
		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float endPlayTime;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform lastParentTransform;

		[NonSerialized]
		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public float defaultVolume;

		[NonSerialized]
		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public Transform defaultParent;

		[NonSerialized]
		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public int originalIdx;

		[NonSerialized]
		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public Action onFinished;

		[NonSerialized]
		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public Action<object> onFinishedObject;

		[NonSerialized]
		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public object onFinishedParam;

		[NonSerialized]
		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public SoundGroup playingSoundGroup;

		[Token(Token = "0x1700008E")]
		public float volume
		{
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x976BEC", Offset = "0x976BEC", VA = "0x976BEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x976C0C", Offset = "0x976C0C", VA = "0x976C0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public float pitch
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x976C2C", Offset = "0x976C2C", VA = "0x976C2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x976C4C", Offset = "0x976C4C", VA = "0x976C4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public AudioClip clip
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x976C6C", Offset = "0x976C6C", VA = "0x976C6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x976C8C", Offset = "0x976C8C", VA = "0x976C8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public float time
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x976CAC", Offset = "0x976CAC", VA = "0x976CAC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x976CCC", Offset = "0x976CCC", VA = "0x976CCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public float length
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x976CEC", Offset = "0x976CEC", VA = "0x976CEC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000093")]
		public bool loop
		{
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x976DA0", Offset = "0x976DA0", VA = "0x976DA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x976DC0", Offset = "0x976DC0", VA = "0x976DC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public bool mute
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x976DE4", Offset = "0x976DE4", VA = "0x976DE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x976E04", Offset = "0x976E04", VA = "0x976E04")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public AudioVelocityUpdateMode velocityUpdateMode
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x976E28", Offset = "0x976E28", VA = "0x976E28")]
			get
			{
				return default(AudioVelocityUpdateMode);
			}
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x976E48", Offset = "0x976E48", VA = "0x976E48")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool isPlaying
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x976E68", Offset = "0x976E68", VA = "0x976E68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x976E88", Offset = "0x976E88", VA = "0x976E88")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x977040", Offset = "0x977040", VA = "0x977040")]
		public void SetPlayingSoundGroup(SoundGroup soundGroup)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x9770C0", Offset = "0x9770C0", VA = "0x9770C0")]
		public void SetOnFinished(Action onFinished)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x9770C8", Offset = "0x9770C8", VA = "0x9770C8")]
		public void SetOnFinished(Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x9770D0", Offset = "0x9770D0", VA = "0x9770D0")]
		public void SetChannel(int _channel)
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x9770D8", Offset = "0x9770D8", VA = "0x9770D8")]
		public void SetDefaultParent(Transform parent)
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x9770E0", Offset = "0x9770E0", VA = "0x9770E0")]
		public void SetAudioMixer(AudioMixerGroup _mixer)
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x977184", Offset = "0x977184", VA = "0x977184")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x9771F0", Offset = "0x9771F0", VA = "0x9771F0")]
		public void Play()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x977250", Offset = "0x977250", VA = "0x977250")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x977288", Offset = "0x977288", VA = "0x977288")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x9773D0", Offset = "0x9773D0", VA = "0x9773D0")]
		private int GetSampleTime()
		{
			return default(int);
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x977428", Offset = "0x977428", VA = "0x977428")]
		public void ParentTo(Transform parent)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x977538", Offset = "0x977538", VA = "0x977538")]
		public void DetachFromParent()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x9775F8", Offset = "0x9775F8", VA = "0x9775F8")]
		public void ResetParent(Transform parent)
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x977638", Offset = "0x977638", VA = "0x977638")]
		public void SyncTo(SoundEmitter other, float fadeTime, float toVolume)
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x977664", Offset = "0x977664", VA = "0x977664")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x530AD0", Offset = "0x530AD0")]
		private IEnumerator DelayedSyncTo(SoundEmitter other, float fadeTime, float toVolume)
		{
			return null;
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x9776F0", Offset = "0x9776F0", VA = "0x9776F0")]
		public void FadeTo(float fadeTime, float toVolume)
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x9777EC", Offset = "0x9777EC", VA = "0x9777EC")]
		public void FadeIn(float fadeTime, float defaultVolume)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x97790C", Offset = "0x97790C", VA = "0x97790C")]
		public void FadeIn(float fadeTime)
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x977984", Offset = "0x977984", VA = "0x977984")]
		public void FadeOut(float fadeTime)
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x977A1C", Offset = "0x977A1C", VA = "0x977A1C")]
		public void FadeOutDelayed(float delayedSecs, float fadeTime)
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x977764", Offset = "0x977764", VA = "0x977764")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x530B38", Offset = "0x530B38")]
		private IEnumerator FadeSoundChannelTo(float fadeTime, float toVolume)
		{
			return null;
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x977868", Offset = "0x977868", VA = "0x977868")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x530BA0", Offset = "0x530BA0")]
		private IEnumerator FadeSoundChannel(float delaySecs, float fadeTime, Fade fadeType, float defaultVolume)
		{
			return null;
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x977AB8", Offset = "0x977AB8", VA = "0x977AB8")]
		public SoundEmitter()
		{
		}
	}
	[Token(Token = "0x200015B")]
	public enum SoundFXNext
	{
		[Token(Token = "0x400088B")]
		Random,
		[Token(Token = "0x400088C")]
		Sequential
	}
	[Token(Token = "0x200015C")]
	public enum FreqHint
	{
		[Token(Token = "0x400088E")]
		None,
		[Token(Token = "0x400088F")]
		Wide,
		[Token(Token = "0x4000890")]
		Narrow
	}
	[Token(Token = "0x200015D")]
	public enum SoundPriority
	{
		[Token(Token = "0x4000892")]
		VeryLow = -2,
		[Token(Token = "0x4000893")]
		Low,
		[Token(Token = "0x4000894")]
		Default,
		[Token(Token = "0x4000895")]
		High,
		[Token(Token = "0x4000896")]
		VeryHigh
	}
	[Serializable]
	[Token(Token = "0x200015E")]
	public class OSPProps
	{
		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E020", Offset = "0x52E020")]
		public bool enableSpatialization;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E058", Offset = "0x52E058")]
		public bool useFastOverride;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E090", Offset = "0x52E090")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52E090", Offset = "0x52E090")]
		public float gain;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E0E4", Offset = "0x52E0E4")]
		public bool enableInvSquare;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E11C", Offset = "0x52E11C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52E11C", Offset = "0x52E11C")]
		public float volumetric;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E174", Offset = "0x52E174")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x52E174", Offset = "0x52E174")]
		public Vector2 invSquareFalloff;

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xC84D44", Offset = "0xC84D44", VA = "0xC84D44")]
		public OSPProps()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015F")]
	public class SoundFX
	{
		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E1D4", Offset = "0x52E1D4")]
		public string name;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E20C", Offset = "0x52E20C")]
		public SoundFXNext playback;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E244", Offset = "0x52E244")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52E244", Offset = "0x52E244")]
		public float volume;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E298", Offset = "0x52E298")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x52E298", Offset = "0x52E298")]
		public Vector2 pitchVariance;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E2F4", Offset = "0x52E2F4")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x52E2F4", Offset = "0x52E2F4")]
		public Vector2 falloffDistance;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E354", Offset = "0x52E354")]
		public AudioRolloffMode falloffCurve;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E38C", Offset = "0x52E38C")]
		public AnimationCurve volumeFalloffCurve;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E3C4", Offset = "0x52E3C4")]
		public AnimationCurve reverbZoneMix;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E3FC", Offset = "0x52E3FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52E3FC", Offset = "0x52E3FC")]
		public float spread;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E454", Offset = "0x52E454")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52E454", Offset = "0x52E454")]
		public float pctChanceToPlay;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E4A8", Offset = "0x52E4A8")]
		public SoundPriority priority;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E4E0", Offset = "0x52E4E0")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x52E4E0", Offset = "0x52E4E0")]
		public Vector2 delay;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E53C", Offset = "0x52E53C")]
		public bool looping;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public OSPProps ospProps;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E574", Offset = "0x52E574")]
		public AudioClip[] soundClips;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool visibilityToggle;

		[NonSerialized]
		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private SoundGroup soundGroup;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int lastIdx;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int playingIdx;

		[Token(Token = "0x17000097")]
		public int Length
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x977F9C", Offset = "0x977F9C", VA = "0x977F9C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000098")]
		public bool IsValid
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x977FBC", Offset = "0x977FBC", VA = "0x977FBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000099")]
		public SoundGroup Group
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x97805C", Offset = "0x97805C", VA = "0x97805C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x978064", Offset = "0x978064", VA = "0x978064")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public float MaxFalloffDistSquared
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x97806C", Offset = "0x97806C", VA = "0x97806C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009B")]
		public float GroupVolumeOverride
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x978078", Offset = "0x978078", VA = "0x978078")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x977AD0", Offset = "0x977AD0", VA = "0x977AD0")]
		public SoundFX()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x978090", Offset = "0x978090", VA = "0x978090")]
		public AudioClip GetClip()
		{
			return null;
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x978160", Offset = "0x978160", VA = "0x978160")]
		public AudioMixerGroup GetMixerGroup(AudioMixerGroup defaultMixerGroup)
		{
			return null;
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x9781FC", Offset = "0x9781FC", VA = "0x9781FC")]
		public bool ReachedGroupPlayLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x978244", Offset = "0x978244", VA = "0x978244")]
		public float GetClipLength(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x97833C", Offset = "0x97833C", VA = "0x97833C")]
		public float GetPitch()
		{
			return default(float);
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x978348", Offset = "0x978348", VA = "0x978348")]
		public int PlaySound(float delaySecs = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x978424", Offset = "0x978424", VA = "0x978424")]
		public int PlaySoundAt(Vector3 pos, float delaySecs = 0f, float volumeOverride = 1f, float pitchMultiplier = 1f)
		{
			return default(int);
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x978538", Offset = "0x978538", VA = "0x978538")]
		public void SetOnFinished(Action onFinished)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x9785C4", Offset = "0x9785C4", VA = "0x9785C4")]
		public void SetOnFinished(Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x978658", Offset = "0x978658", VA = "0x978658")]
		public bool StopSound()
		{
			return default(bool);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x9786E4", Offset = "0x9786E4", VA = "0x9786E4")]
		public void AttachToParent(Transform parent)
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x978770", Offset = "0x978770", VA = "0x978770")]
		public void DetachFromParent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000160")]
	public class SoundFXRef
	{
		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundFXName;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool initialized;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SoundFX soundFXCached;

		[Token(Token = "0x1700009C")]
		public SoundFX soundFX
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x9787E8", Offset = "0x9787E8", VA = "0x9787E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public string name
		{
			[Token(Token = "0x6000829")]
			[Address(RVA = "0x9788EC", Offset = "0x9788EC", VA = "0x9788EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600082A")]
			[Address(RVA = "0x9788F4", Offset = "0x9788F4", VA = "0x9788F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public int Length
		{
			[Token(Token = "0x600082C")]
			[Address(RVA = "0x9788FC", Offset = "0x9788FC", VA = "0x9788FC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009F")]
		public bool IsValid
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x978940", Offset = "0x978940", VA = "0x978940")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x978818", Offset = "0x978818", VA = "0x978818")]
		private void Init()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x978978", Offset = "0x978978", VA = "0x978978")]
		public AudioClip GetClip()
		{
			return null;
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x9789B0", Offset = "0x9789B0", VA = "0x9789B0")]
		public float GetClipLength(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x9789F0", Offset = "0x9789F0", VA = "0x9789F0")]
		public int PlaySound(float delaySecs = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x978A38", Offset = "0x978A38", VA = "0x978A38")]
		public int PlaySoundAt(Vector3 pos, float delaySecs = 0f, float volume = 1f, float pitchMultiplier = 1f)
		{
			return default(int);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x978AB8", Offset = "0x978AB8", VA = "0x978AB8")]
		public void SetOnFinished(Action onFinished)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x978AF8", Offset = "0x978AF8", VA = "0x978AF8")]
		public void SetOnFinished(Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x978B48", Offset = "0x978B48", VA = "0x978B48")]
		public bool StopSound()
		{
			return default(bool);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x978B80", Offset = "0x978B80", VA = "0x978B80")]
		public void AttachToParent(Transform parent)
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x978BC0", Offset = "0x978BC0", VA = "0x978BC0")]
		public void DetachFromParent()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x978BF8", Offset = "0x978BF8", VA = "0x978BF8")]
		public SoundFXRef()
		{
		}
	}
}
namespace UnityTemplateProject
{
	[Token(Token = "0x2000161")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x2000200")]
		private class CameraState
		{
			[Token(Token = "0x4000B62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000B63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000B64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000B65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000B66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000B67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x866628", Offset = "0x866628", VA = "0x866628")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x8666B0", Offset = "0x8666B0", VA = "0x8666B0")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x86672C", Offset = "0x86672C", VA = "0x86672C")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x8667F4", Offset = "0x8667F4", VA = "0x8667F4")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x866840", Offset = "0x866840", VA = "0x866840")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52E5AC", Offset = "0x52E5AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E5AC", Offset = "0x52E5AC")]
		public float boost;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E60C", Offset = "0x52E60C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52E60C", Offset = "0x52E60C")]
		public float positionLerpTime;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x52E664", Offset = "0x52E664")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E664", Offset = "0x52E664")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E6C4", Offset = "0x52E6C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x52E6C4", Offset = "0x52E6C4")]
		public float rotationLerpTime;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x52E71C", Offset = "0x52E71C")]
		public bool invertY;

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x973878", Offset = "0x973878", VA = "0x973878")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x9738D8", Offset = "0x9738D8", VA = "0x9738D8")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x9739EC", Offset = "0x9739EC", VA = "0x9739EC")]
		private void Update()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x973C80", Offset = "0x973C80", VA = "0x973C80")]
		public SimpleCameraController()
		{
		}
	}
}
