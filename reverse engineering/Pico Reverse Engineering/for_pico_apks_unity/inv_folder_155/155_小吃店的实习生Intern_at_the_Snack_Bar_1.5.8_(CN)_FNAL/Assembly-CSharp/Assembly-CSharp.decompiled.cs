using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using ETModel;
using HurricaneVR.Framework.Components;
using HurricaneVR.Framework.ControllerInput;
using HurricaneVR.Framework.Core;
using HurricaneVR.Framework.Core.Grabbers;
using HurricaneVR.Framework.Core.Player;
using HurricaneVR.Framework.Core.Sockets;
using HurricaneVR.Framework.Core.Utils;
using HurricaneVR.Framework.Shared;
using HurricaneVR.Framework.Weapons;
using TMPro;
using Unity.XR.PXR;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public class MadsonD9 : HVRPistol
{
}
public class MadsonD9Slide : HVRSlide
{
}
public class DemoLeverDisplay : MonoBehaviour
{
	private int _step;

	private float _angle;

	private TextMeshPro _tm;

	private void Awake()
	{
		_tm = GetComponent<TextMeshPro>();
	}

	public void OnStepChanged(int step)
	{
		_step = step;
		_tm.text = $"{_step}/{_angle:f0}";
	}

	public void OnAngleChanged(float angle, float delta)
	{
		_angle = angle;
		_tm.text = $"{_step}/{_angle:f0}";
	}
}
public class DemoUIManager : MonoBehaviour
{
	public HVRPlayerController Player;

	public HVRCameraRig CameraRig;

	public HVRPlayerInputs Inputs;

	public TextMeshProUGUI SitStandText;

	public TextMeshProUGUI ForceGrabText;

	public TextMeshProUGUI LeftForceText;

	public TextMeshProUGUI RightForceText;

	public Slider TurnRateSlider;

	public Slider SnapTurnSlider;

	public TextMeshProUGUI TurnRateText;

	public TextMeshProUGUI SnapRateText;

	public Toggle SmoothTurnToggle;

	public HVRForceGrabber LeftForce;

	public HVRForceGrabber RightForce;

	private void Start()
	{
		UpdateSitStandButton();
		UpdateForceGrabButton();
		TurnRateSlider.value = Player.SmoothTurnSpeed;
		SnapTurnSlider.value = Player.SnapAmount;
		TurnRateText.text = Player.SmoothTurnSpeed.ToString();
		SnapRateText.text = Player.SnapAmount.ToString();
		SmoothTurnToggle.isOn = Player.RotationType == RotationType.Smooth;
		TurnRateSlider.onValueChanged.AddListener(OnTurnRateChanged);
		SnapTurnSlider.onValueChanged.AddListener(OnSnapTurnRateChanged);
		SmoothTurnToggle.onValueChanged.AddListener(OnSmoothTurnChanged);
		LeftForce = Player.transform.root.GetComponentsInChildren<HVRForceGrabber>().FirstOrDefault((HVRForceGrabber e) => e.HandSide == HVRHandSide.Left);
		RightForce = Player.transform.root.GetComponentsInChildren<HVRForceGrabber>().FirstOrDefault((HVRForceGrabber e) => e.HandSide == HVRHandSide.Right);
		UpdateLeftForceButton();
		UpdateRightForceButton();
	}

	public void CalibrateHeight()
	{
		if ((bool)CameraRig)
		{
			CameraRig.Calibrate();
		}
	}

	public void OnSitStandClicked()
	{
		int sitStanding = (int)CameraRig.SitStanding;
		sitStanding++;
		if (sitStanding > 2)
		{
			sitStanding = 0;
		}
		CameraRig.SetSitStandMode((HVRSitStand)sitStanding);
		UpdateSitStandButton();
	}

	public void OnForceGrabClicked()
	{
		int forceGrabActivation = (int)Inputs.ForceGrabActivation;
		forceGrabActivation++;
		if (forceGrabActivation > 1)
		{
			forceGrabActivation = 0;
		}
		Inputs.ForceGrabActivation = (HVRForceGrabActivation)forceGrabActivation;
		UpdateForceGrabButton();
	}

	private void UpdateForceGrabButton()
	{
		ForceGrabText.text = Inputs.ForceGrabActivation.ToString();
	}

	private void UpdateSitStandButton()
	{
		SitStandText.text = CameraRig.SitStanding.ToString();
	}

	public void OnTurnRateChanged(float rate)
	{
		Player.SmoothTurnSpeed = rate;
		TurnRateText.text = Player.SmoothTurnSpeed.ToString();
	}

	public void OnSnapTurnRateChanged(float rate)
	{
		Player.SnapAmount = rate;
		SnapRateText.text = Player.SnapAmount.ToString();
	}

	public void OnSmoothTurnChanged(bool smooth)
	{
		Player.RotationType = ((!smooth) ? RotationType.Snap : RotationType.Smooth);
	}

	public void OnLeftForceGrabModeClicked()
	{
		if ((bool)LeftForce)
		{
			if (LeftForce.GrabStyle == HVRForceGrabMode.ForcePull)
			{
				LeftForce.GrabStyle = HVRForceGrabMode.GravityGloves;
			}
			else
			{
				LeftForce.GrabStyle = HVRForceGrabMode.ForcePull;
			}
			UpdateLeftForceButton();
		}
	}

	public void OnRightForceGrabModeClicked()
	{
		if ((bool)RightForce)
		{
			if (RightForce.GrabStyle == HVRForceGrabMode.ForcePull)
			{
				RightForce.GrabStyle = HVRForceGrabMode.GravityGloves;
			}
			else
			{
				RightForce.GrabStyle = HVRForceGrabMode.ForcePull;
			}
			UpdateRightForceButton();
		}
	}

	private void UpdateLeftForceButton()
	{
		LeftForceText.text = LeftForce.GrabStyle.ToString();
	}

	private void UpdateRightForceButton()
	{
		RightForceText.text = RightForce.GrabStyle.ToString();
	}
}
public class Data
{
	public static string Infos;

	public static string SN;

	public static string Name;

	public static int Gold;

	public static string Time;
}
public class GetName : MonoBehaviour
{
	private void Start()
	{
		LoginSDK.Login();
		LoginSDK.GetUserAPI();
	}

	private void Update()
	{
	}
}
public class Item : MonoBehaviour
{
	public Text RankingText;

	public Text NameText;

	public Text GoldText;

	public Text TimeText;

	public string Ranking;

	public string Name;

	public string Gold;

	public string Time;

	public void Change()
	{
		RankingText.text = Ranking;
		NameText.text = base.name;
		GoldText.text = Gold;
		TimeText.text = Time;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
public interface Ranking
{
	string GetPlayersInfo();

	bool UploadPlayerInfos(string GoldNum, string Time);
}
public class lookboss : MonoBehaviour
{
	public GameObject jineng3;

	public static lookboss Instans;

	public GameObject[] wuti;

	public GameObject[] audios;

	public Text liftText;

	public Text jingbis;

	public GameObject atackTexiao;

	private GameObject Txiao;

	private GameObject A;

	private GameObject C;

	private Vector3 Pos;

	private Quaternion Rote;

	private Vector3 transPos;

	private Quaternion transRote;

	private Animator donghua;

	private bool zhuangtai;

	private bool isLook;

	private bool ismove;

	private bool isatack;

	private bool isatack2;

	private bool ischange = true;

	private bool ischange2 = true;

	private bool atacked;

	private bool isjump;

	private bool isdown;

	private bool isheart;

	private bool isblack;

	private bool istime;

	public static bool isjinbi;

	private bool isSkill;

	private bool Skill1;

	private bool Skill2;

	private bool Skill3;

	private float ii;

	private float atacks;

	private int i;

	private int n;

	private int s = 9;

	private int lf;

	private int jt;

	private int left;

	private int lfss;

	private int timess;

	private int yi;

	private float AAA;

	private int ASSS;

	private Vector3 sss;

	public int k = 5;

	public static float liftNumber = 100f;

	private void Awake()
	{
	}

	private void Start()
	{
		isjinbi = false;
		lfss = UnityEngine.Random.Range(7, 10);
		isblack = false;
		Instans = this;
		lf = UnityEngine.Random.Range(3, 8);
		MonoBehaviour.print("LF:" + lf);
		transRote = base.transform.rotation;
		transPos = base.transform.position;
		donghua = base.transform.GetComponent<Animator>();
		liftNumber = (BoolData.Change.T - 1) * 100;
		Invoke("kaishi", 2f);
	}

	private void kaishi()
	{
		if (!zhuangtai)
		{
			base.transform.GetChild(6).gameObject.SetActive(value: true);
			Invoke("fashe", 2f);
		}
	}

	private void fashe()
	{
		BoolData.Boos.iszhunbei = true;
		base.transform.GetChild(6).gameObject.SetActive(value: false);
		Invoke("kaishi", 2f);
	}

	private void Update()
	{
		jingbis.text = BoolData.jingbi.ToString();
		if (!istime)
		{
			timess++;
		}
		ASSS = BoolData.jingbi;
		if (isblack && AAA < 1f)
		{
			AAA += 0.01f;
		}
		wuti[5].GetComponent<Image>().color = new Color(0f, 0f, 0f, AAA);
		BoolData.Boos.lefts = liftNumber / (float)(BoolData.Change.T - 1) * 100f;
		if (liftNumber <= 0f || BoolData.jingbi <= 0)
		{
			LIkai.fangxia = false;
			BoolData.isPDG = false;
			BoolData.iskuaizi = false;
			BoolData.isyoushao = false;
			BoolData.ismian = false;
			BoolData.isshaozi = false;
			BoolData.isIns = true;
			BoolData.isTrue = true;
			BoolData.isTheer = true;
			BoolData.Change.ists = true;
			BoolData.Change.isgame = true;
			BoolData.Change.ischange = true;
			ismove = false;
			donghua.enabled = false;
			isLook = false;
			atacked = true;
			Invoke("change", 3f);
			isblack = true;
			liftNumber -= 1f;
			if (BoolData.jingbi <= 0)
			{
				BoolData.Boos.shibai = true;
			}
			if (!isjinbi && BoolData.jingbi > 0)
			{
				BoolData.jingbi += 100;
				isjinbi = true;
			}
		}
		if (BoolData.jingbi <= 0)
		{
			BoolData.Boos.shit = false;
			Skill1 = true;
			i = 4;
			atacked = true;
		}
		if (Input.GetKeyDown(KeyCode.Q))
		{
			liftNumber -= 10f;
			MonoBehaviour.print("liftNumber:" + liftNumber);
		}
		MonoBehaviour.print("lfss:" + lfss);
		if (!atacked && timess > lfss * 100)
		{
			istime = true;
			s = -10;
			left = UnityEngine.Random.Range(5, 10);
			lfss += left;
			lf = 9;
			i = UnityEngine.Random.Range(0, 2);
			i = 1;
			if (!isSkill)
			{
				switch (i)
				{
				case 0:
					donghua.SetBool("stand", value: false);
					donghua.SetBool("atack", value: true);
					isSkill = true;
					atacked = true;
					zhuangtai = true;
					Invoke("banck", 2f);
					break;
				case 1:
					atacked = true;
					isSkill = true;
					zhuangtai = true;
					monster.istexiaos = true;
					BoolData.OneSkill = true;
					donghua.SetBool("stand", value: false);
					donghua.SetBool("three", value: true);
					C = UnityEngine.Object.Instantiate(audios[2].gameObject, audios[2].transform.position, audios[2].transform.rotation);
					C.SetActive(value: true);
					UnityEngine.Object.Destroy(C.gameObject, 5f);
					Invoke("banck", 4f);
					break;
				}
			}
		}
		if (Skill1)
		{
			base.transform.position = Vector3.MoveTowards(base.transform.position, transPos, Time.deltaTime * 10f);
		}
		MonoBehaviour.print(BoolData.jingbi);
		if (ismove)
		{
			base.transform.position = Vector3.MoveTowards(base.transform.position, wuti[1].transform.position, Time.deltaTime * 2f);
		}
		if (isLook)
		{
			base.transform.rotation = Quaternion.Slerp(base.transform.rotation, wuti[4].transform.rotation, Time.deltaTime * 1.2f);
		}
		if (isjump)
		{
			base.transform.position = Vector3.MoveTowards(base.transform.position, base.transform.position + Vector3.up * 5f, Time.deltaTime * 5f);
		}
		if (isatack)
		{
			MonoBehaviour.print("atack");
			base.transform.position = Vector3.MoveTowards(base.transform.position, base.transform.position + Vector3.up * 5f, Time.deltaTime * 5f);
			if (ischange)
			{
				Invoke("down", 1f);
				ischange = false;
			}
		}
		if (isatack2)
		{
			int num = 20;
			if (i == 2)
			{
				num = 30;
			}
			base.transform.position = Vector3.MoveTowards(base.transform.position, Pos, Time.deltaTime * (float)num);
			if (ischange2)
			{
				if (i == 2)
				{
					Invoke("moves", 2f);
				}
				else
				{
					C = UnityEngine.Object.Instantiate(audios[0].gameObject, base.transform.position, base.transform.rotation);
					C.SetActive(value: true);
					UnityEngine.Object.Destroy(C.gameObject, 5f);
					Invoke("moves", 1f);
				}
				isheart = true;
				ischange2 = false;
			}
		}
		ii = Vector3.Distance(wuti[0].transform.position, wuti[3].transform.position);
		BoolData.juli = ii;
		if (ii < 8f && !atacked)
		{
			isLook = false;
			ismove = false;
			Invoke("atackss", 0.5f);
			atacked = true;
		}
		if (isheart)
		{
			atacks = Vector3.Distance(Pos, wuti[3].transform.position);
			if (atacks < 4f)
			{
				MonoBehaviour.print("fffffffffffffffffffffffffffff");
				BoolData.jingbi -= 5;
				isheart = false;
			}
		}
	}

	private void banck()
	{
		base.transform.GetComponent<BoxCollider>().enabled = false;
		donghua.SetBool("three", value: false);
		donghua.SetBool("atack", value: false);
		donghua.SetBool("stand", value: true);
		if (i == 1)
		{
			isSkill = false;
			atacked = false;
			istime = false;
			zhuangtai = false;
			Invoke("kaishi", 2f);
		}
		if (i == 0)
		{
			yi++;
			if (yi < 5)
			{
				Invoke("agains", 2f);
				return;
			}
			isSkill = false;
			atacked = false;
			istime = false;
			zhuangtai = false;
			yi = 0;
			Invoke("kaishi", 2f);
		}
	}

	private void agains()
	{
		donghua.SetBool("stand", value: false);
		donghua.SetBool("atack", value: true);
		Invoke("banck", 1f);
	}

	public void boolChange()
	{
		isLook = false;
	}

	private void atack()
	{
		isatack = true;
	}

	private void down()
	{
		MonoBehaviour.print("down");
		isatack = false;
		isatack2 = true;
	}

	private void moves()
	{
		MonoBehaviour.print("End");
		isLook = true;
		ismove = true;
		isatack2 = false;
		atacked = false;
		ischange = true;
		ischange2 = true;
		isheart = false;
	}

	private void jump()
	{
		n++;
		isLook = true;
		Skill1 = false;
		if (n <= 3)
		{
			MonoBehaviour.print("N" + n);
			isjump = true;
			Invoke("jumpNext", 0.5f);
			return;
		}
		n = 0;
		MonoBehaviour.print("SSSS：" + s);
		BoolData.OneSkill = true;
		ismove = true;
		isLook = true;
		isSkill = false;
		atacked = false;
	}

	private void jumpNext()
	{
		isjump = false;
		Skill1 = true;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (i == 0 && Skill1 && other.tag == "技能")
		{
			donghua.SetBool("three", value: true);
			donghua.SetBool("stand", value: false);
			base.transform.LookAt(wuti[1].transform);
			other.transform.GetComponent<BoxCollider>().enabled = false;
			monster.istexiaos = true;
			C = UnityEngine.Object.Instantiate(audios[2].gameObject, audios[2].transform.position, audios[2].transform.rotation);
			C.SetActive(value: true);
			UnityEngine.Object.Destroy(C.gameObject, 5f);
			Invoke("backs", 2f);
		}
		if (i == 1 && Skill1 && other.tag == "技能")
		{
			Invoke("juji", 0.5f);
			base.transform.LookAt(wuti[1].transform);
		}
		if (i == 2 && other.tag == "地点1")
		{
			C = UnityEngine.Object.Instantiate(audios[1].gameObject, base.transform.position, base.transform.rotation);
			C.SetActive(value: true);
			UnityEngine.Object.Destroy(C.gameObject, 5f);
			i = 4;
		}
	}

	private void lookss()
	{
		wuti[0].transform.LookAt(sss);
	}

	private void juji()
	{
		isLook = true;
		Skill1 = false;
		base.transform.GetChild(6).gameObject.SetActive(value: true);
		Invoke("zhunbei", 5f);
	}

	private void zhunbei()
	{
		BoolData.Boos.iszhunbei = true;
		Invoke("gongji", 1f);
		Skill1 = false;
	}

	private void gongji()
	{
		BoolData.Boos.isatack = true;
		base.transform.GetChild(6).gameObject.SetActive(value: false);
		ismove = true;
		isLook = true;
		isSkill = false;
		atacked = false;
		Invoke("chongzhi", 1f);
	}

	private void chongzhi()
	{
		BoolData.Boos.iszhunbei = false;
		BoolData.Boos.isatack = false;
	}

	private void jumps()
	{
		A = UnityEngine.Object.Instantiate(jineng3.gameObject, wuti[3].transform.position, jineng3.transform.rotation);
		A.GetComponent<SphereCollider>().enabled = false;
		A.SetActive(value: true);
		Invoke("shanghai", 1.5f);
	}

	private void shanghai()
	{
		Pos = A.transform.position;
		isatack2 = true;
		A.GetComponent<SphereCollider>().enabled = true;
		isjump = false;
		Invoke("jishuan", 1.5f);
	}

	private void jishuan()
	{
		A.GetComponent<SphereCollider>().enabled = true;
		BoolData.Boos.isShangHai = true;
		Invoke("jiesuan", 1f);
	}

	private void jiesuan()
	{
		UnityEngine.Object.Destroy(A.gameObject);
		isatack2 = false;
		ismove = true;
		isLook = true;
		atacked = false;
		isSkill = false;
		BoolData.Boos.isShangHai = false;
	}

	private void atackss()
	{
		BoolData.Boos.atackedss = true;
		donghua.SetBool("atack", value: true);
		donghua.SetBool("stand", value: false);
		Invoke("gongjis", 0.5f);
		Invoke("gos", 1.5f);
	}

	private void gongjis()
	{
		Txiao = UnityEngine.Object.Instantiate(atackTexiao.gameObject, atackTexiao.transform.position, atackTexiao.transform.rotation, base.transform.GetChild(0));
		Txiao.SetActive(value: true);
		UnityEngine.Object.Destroy(Txiao.gameObject, 2f);
		base.transform.GetComponent<BoxCollider>().enabled = true;
		C = UnityEngine.Object.Instantiate(audios[0].gameObject, base.transform.position, base.transform.rotation);
		C.SetActive(value: true);
		UnityEngine.Object.Destroy(C.gameObject, 5f);
	}

	private void gos()
	{
		base.transform.GetComponent<BoxCollider>().enabled = false;
		donghua.SetBool("atack", value: false);
		donghua.SetBool("stand", value: true);
		Invoke("atackAgain", 0.5f);
	}

	private void atackAgain()
	{
		Invoke("AgainAtack", 1f);
		isLook = true;
		ismove = true;
	}

	private void backs()
	{
		donghua.SetBool("three", value: false);
		donghua.SetBool("stand", value: true);
		Invoke("atackAgains", 1f);
	}

	private void atackAgains()
	{
		isLook = true;
		ismove = true;
		Skill1 = false;
		isSkill = false;
		BoolData.OneSkill = true;
		atacked = false;
	}

	private void AgainAtack()
	{
		atacked = false;
	}

	private void change()
	{
		UnityEngine.Object.Destroy(base.transform.gameObject);
		SceneManager.LoadScene(1);
	}
}
public class BIgTexioa : MonoBehaviour
{
	public GameObject Texiao;

	public GameObject Jiaocheng;

	private bool iskaishi;

	private GameObject A;

	private void Start()
	{
		if (!BoolData.Boos.isfirstBoos)
		{
			Invoke("kaishi", 1f);
		}
		else
		{
			Jiaocheng.SetActive(value: true);
		}
	}

	private void Update()
	{
		if (PlayerAtack.kaihsil)
		{
			Invoke("change", 5f);
			Invoke("kaishi", 1f);
			Jiaocheng.SetActive(value: false);
			PlayerAtack.kaihsil = false;
		}
	}

	private void kaishi()
	{
		Texiao.SetActive(value: true);
		Invoke("end", 5f);
	}

	private void end()
	{
		Texiao.SetActive(value: false);
	}

	private void change()
	{
		BoolData.Boos.NewBoos = true;
	}
}
public class BoosBleed : MonoBehaviour
{
	public GameObject Player;

	private float i = BoolData.Boos.lefts;

	private void Start()
	{
	}

	private void Update()
	{
		i = lookboss.liftNumber / ((float)(BoolData.Change.T - 1) * 100f);
		if (lookboss.liftNumber < (float)(BoolData.Change.T - 1) * 100f)
		{
			base.transform.GetChild(1).transform.GetComponent<Slider>().value = i;
			if (base.transform.GetChild(0).transform.GetComponent<Slider>().value > base.transform.GetChild(1).transform.GetComponent<Slider>().value)
			{
				base.transform.GetChild(0).transform.GetComponent<Slider>().value -= 0.005f;
			}
		}
		base.transform.GetChild(2).GetComponent<Text>().text = (int)lookboss.liftNumber + "/" + (BoolData.Change.T - 1) * 100;
	}
}
public class EyeScript : MonoBehaviour
{
	private float A = 1f;

	private void Start()
	{
	}

	private void Update()
	{
		base.transform.GetComponent<Image>().color = new Color(0f, 0f, 0f, A);
		if (!BoolData.Change.ists)
		{
			A -= 0.01f;
		}
	}
}
public class EyeScript2 : MonoBehaviour
{
	private float A = 1f;

	private void Start()
	{
	}

	private void Update()
	{
		if (BoolData.Change.ists)
		{
			MonoBehaviour.print("BlACK=" + BoolData.Change.ists);
			base.transform.GetComponent<Image>().color = new Color(0f, 0f, 0f, A);
			A -= 0.01f;
		}
	}
}
public class Instenss : MonoBehaviour
{
	public GameObject plepoe;

	private GameObject AA;

	private void Start()
	{
	}

	private void Update()
	{
		if (!BoolData.Boos.isfirstBoos && BoolData.Boos.NewBoos)
		{
			AA = UnityEngine.Object.Instantiate(plepoe.gameObject, plepoe.transform.position, plepoe.transform.rotation);
			AA.SetActive(value: true);
			BoolData.ASA = AA;
			BoolData.Boos.NewBoos = false;
		}
	}
}
public class AllMoves : MonoBehaviour
{
	public GameObject camer;

	private bool isdu;

	private bool isgongji;

	public Image AA;

	private float AS = 1f;

	private Vector3 S;

	private Quaternion H;

	private void Start()
	{
		S = base.transform.position;
		H = base.transform.rotation;
	}

	private void Update()
	{
		base.transform.rotation = H;
		MonoBehaviour.print("BoolData.Change.ists=" + BoolData.Change.ists);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "毒液" && !isdu)
		{
			MonoBehaviour.print("中毒了");
			isdu = true;
			Invoke("changes", 1f);
		}
	}

	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "毒液" && !isdu)
		{
			MonoBehaviour.print("中毒了");
			isdu = true;
			Invoke("changes", 2f);
		}
		if (other.tag == "Boss" && BoolData.Boos.atackedss && !isgongji)
		{
			BoolData.jingbi -= 5;
			BoolData.Boos.atackedss = false;
			isgongji = true;
			Invoke("changes", 2f);
		}
	}

	private void changes()
	{
		isdu = false;
		isgongji = false;
	}
}
public class LeftGun : MonoBehaviour
{
	private GameObject AA;

	private GameObject EE;

	public GameObject BB;

	public GameObject CC;

	public GameObject DD;

	public GameObject GG;

	public GameObject Main;

	private bool isshit;

	private bool isgoto;

	private bool ismove;

	private bool isshits;

	public static bool isjiaocheng;

	private void Start()
	{
	}

	private void Update()
	{
		HVRController leftController = HVRInputManager.Instance.LeftController;
		if (ismove)
		{
			Vector3 force = base.transform.GetChild(0).GetChild(0).transform.TransformDirection(0f, 0f, 100f);
			if (AA != null)
			{
				AA.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
			}
			ismove = false;
		}
		if (Input.GetKey(KeyCode.V) || leftController.TriggerButtonState.Active)
		{
			isshit = true;
		}
		if (isshit && BoolData.Boos.shit && !isgoto)
		{
			MonoBehaviour.print("shits");
			base.transform.GetChild(0).GetComponent<Animator>().enabled = true;
			if (!isshits)
			{
				base.transform.GetChild(0).GetComponent<Animator>().SetBool("kaiqiang", value: true);
				base.transform.GetChild(0).GetChild(1).gameObject.SetActive(value: true);
				isshits = true;
			}
			else
			{
				base.transform.GetChild(0).GetComponent<Animator>().SetBool("kaiqiang", value: false);
				base.transform.GetChild(0).GetChild(1).gameObject.SetActive(value: true);
				isshits = false;
			}
			AA = UnityEngine.Object.Instantiate(BB.gameObject, CC.transform.position, BB.transform.rotation);
			EE = UnityEngine.Object.Instantiate(DD.gameObject, DD.transform.position, DD.transform.rotation);
			EE.SetActive(value: true);
			UnityEngine.Object.Destroy(EE.gameObject, 1f);
			UnityEngine.Object.Destroy(AA.gameObject, 5f);
			AA.SetActive(value: true);
			ismove = true;
			AA.GetComponent<Rigidbody>().isKinematic = false;
			Invoke("Agains", 0.54f);
			isgoto = true;
			Invoke("newss", 0.18f);
			BoolData.Boos.shit = false;
		}
	}

	private void Agains()
	{
		isgoto = false;
		isshit = false;
	}

	private void newss()
	{
		MonoBehaviour.print("ends");
		BoolData.Boos.shit = true;
		base.transform.GetChild(0).GetChild(1).gameObject.SetActive(value: false);
		Invoke("des", 5f);
	}

	private void des()
	{
		if (AA != null)
		{
			UnityEngine.Object.Destroy(AA.gameObject, 5f);
		}
	}
}
public class PlayerAtack : MonoBehaviour
{
	public GameObject shengying;

	public GameObject jizhong;

	public GameObject jizhongtexiao;

	public GameObject guanqiu;

	private GameObject A;

	private GameObject B;

	private GameObject GG;

	public static bool kaihsil;

	private bool isjiaocheng;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boss")
		{
			lookboss.liftNumber -= 1f;
			A = UnityEngine.Object.Instantiate(shengying.gameObject, base.transform.position, base.transform.rotation);
			A.SetActive(value: true);
			UnityEngine.Object.Destroy(A.gameObject, 5f);
			B = UnityEngine.Object.Instantiate(jizhongtexiao.gameObject, base.transform.position + new Vector3(0f, 0f, -2f), base.transform.rotation);
			B.SetActive(value: true);
			UnityEngine.Object.Destroy(B.gameObject, 0.4f);
			UnityEngine.Object.Destroy(base.transform.gameObject);
		}
		if (other.tag == "宝石")
		{
			lookboss.liftNumber -= 2f;
			A = UnityEngine.Object.Instantiate(shengying.gameObject, base.transform.position, base.transform.rotation);
			A.SetActive(value: true);
			UnityEngine.Object.Destroy(A.gameObject, 5f);
			B = UnityEngine.Object.Instantiate(jizhongtexiao.gameObject, base.transform.position + new Vector3(0f, 0f, -2f), base.transform.rotation);
			B.SetActive(value: true);
			UnityEngine.Object.Destroy(B.gameObject, 0.4f);
			UnityEngine.Object.Destroy(base.transform.gameObject);
		}
		if (other.tag == "地点3")
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
		}
		if (!(other.tag == "提示"))
		{
			return;
		}
		MonoBehaviour.print("被打击了啊...........");
		if (BoolData.Boos.isfirstBoos)
		{
			B = UnityEngine.Object.Instantiate(jizhongtexiao.gameObject, base.transform.position + new Vector3(0f, 0f, -0.5f), base.transform.rotation);
			B.SetActive(value: true);
			UnityEngine.Object.Destroy(B.gameObject, 0.4f);
			if (!LeftGun.isjiaocheng)
			{
				other.transform.GetChild(0).GetChild(2).gameObject.SetActive(value: false);
				other.transform.GetChild(0).GetChild(3).gameObject.SetActive(value: true);
				LeftGun.isjiaocheng = true;
			}
			else
			{
				other.transform.GetChild(0).GetChild(3).gameObject.SetActive(value: false);
				LeftGun.isjiaocheng = false;
				kaihsil = true;
				BoolData.Boos.isfirstBoos = false;
			}
		}
	}

	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "小病毒")
		{
			other.transform.parent.parent.GetComponent<OneSkillMove>().diaoxue();
			A = UnityEngine.Object.Instantiate(jizhong.gameObject, base.transform.position, base.transform.rotation);
			A.SetActive(value: true);
			UnityEngine.Object.Destroy(A.gameObject, 5f);
			B = UnityEngine.Object.Instantiate(jizhongtexiao.gameObject, base.transform.position + new Vector3(0f, 0f, -0.5f), base.transform.rotation);
			B.SetActive(value: true);
			UnityEngine.Object.Destroy(B.gameObject, 0.4f);
			UnityEngine.Object.Destroy(base.transform.gameObject);
		}
		if (other.tag == "技能2")
		{
			A = UnityEngine.Object.Instantiate(guanqiu.gameObject, base.transform.position, base.transform.rotation);
			A.SetActive(value: true);
			UnityEngine.Object.Destroy(A.gameObject, 5f);
			UnityEngine.Object.Destroy(other.gameObject);
			B = UnityEngine.Object.Instantiate(jizhongtexiao.gameObject, base.transform.position, base.transform.rotation);
			B.SetActive(value: true);
			UnityEngine.Object.Destroy(B.gameObject, 0.4f);
			UnityEngine.Object.Destroy(base.transform.gameObject);
		}
	}
}
public class PlayerScript : MonoBehaviour
{
	private void Awake()
	{
		base.transform.GetChild(2).GetChild(1).GetChild(6)
			.GetChild(2)
			.transform.GetComponent<TiggerManage>().enabled = false;
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
public class RightGUn : MonoBehaviour
{
	private GameObject AA;

	private GameObject EE;

	public GameObject BB;

	public GameObject CC;

	public GameObject DD;

	public GameObject Main;

	private bool isshit;

	private bool isgoto;

	private bool ismove;

	private bool isshits;

	private void Start()
	{
	}

	private void Update()
	{
		HVRController rightController = HVRInputManager.Instance.RightController;
		if (ismove)
		{
			Vector3 force = base.transform.GetChild(0).GetChild(0).transform.TransformDirection(0f, 0f, 100f);
			if (AA != null)
			{
				AA.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
			}
			ismove = false;
		}
		if (Input.GetKey(KeyCode.V) || rightController.TriggerButtonState.Active)
		{
			isshit = true;
		}
		if (isshit && BoolData.Boos.shit && !isgoto)
		{
			base.transform.GetChild(0).GetComponent<Animator>().enabled = true;
			if (!isshits)
			{
				base.transform.GetChild(0).GetComponent<Animator>().SetBool("kaiqiang", value: true);
				base.transform.GetChild(0).GetChild(1).gameObject.SetActive(value: true);
				isshits = true;
			}
			else
			{
				base.transform.GetChild(0).GetComponent<Animator>().SetBool("kaiqiang", value: false);
				base.transform.GetChild(0).GetChild(1).gameObject.SetActive(value: true);
				isshits = false;
			}
			AA = UnityEngine.Object.Instantiate(BB.gameObject, CC.transform.position, BB.transform.rotation);
			EE = UnityEngine.Object.Instantiate(DD.gameObject, DD.transform.position, DD.transform.rotation);
			EE.SetActive(value: true);
			UnityEngine.Object.Destroy(EE.gameObject, 1f);
			UnityEngine.Object.Destroy(AA.gameObject, 7f);
			AA.SetActive(value: true);
			ismove = true;
			AA.GetComponent<Rigidbody>().isKinematic = false;
			Invoke("Agains", 0.54f);
			Invoke("newss", 0.18f);
			isgoto = true;
			BoolData.Boos.shit = false;
		}
	}

	private void Agains()
	{
		isgoto = false;
		isshit = false;
	}

	private void newss()
	{
		BoolData.Boos.shit = true;
		base.transform.GetChild(0).GetChild(1).gameObject.SetActive(value: false);
		Invoke("des", 5f);
	}

	private void des()
	{
		if (AA != null)
		{
			UnityEngine.Object.Destroy(AA.gameObject, 5f);
		}
	}
}
public class PlayerMove : MonoBehaviour
{
	private int speed = 10;

	private void Start()
	{
		BoolData.Boos.PlayerSpeed = speed;
		BoolData.Boos.isspeed = true;
		MonoBehaviour.print(BoolData.Boos.PlayerSpeed);
	}

	private void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.W))
		{
			base.transform.Translate(Vector3.forward * Time.deltaTime * speed);
		}
		if (Input.GetKey(KeyCode.S))
		{
			base.transform.Translate(Vector3.back * Time.deltaTime * speed);
		}
		if (Input.GetKey(KeyCode.A))
		{
			base.transform.Translate(Vector3.left * Time.deltaTime * speed);
		}
		if (Input.GetKey(KeyCode.D))
		{
			base.transform.Translate(Vector3.right * Time.deltaTime * speed);
		}
		Vector3 forward = base.transform.forward;
		forward.Normalize();
		Vector3 vector = Vector3.Cross(forward, Vector3.right * 1000f);
		base.transform.Rotate(-vector, 0f - Input.GetAxis("Mouse X"), Space.World);
	}

	private void Update()
	{
	}

	private void Change()
	{
	}
}
public class RoteScript : MonoBehaviour
{
	public GameObject wuti;

	public GameObject Player;

	private void Start()
	{
	}

	private void Update()
	{
		if (wuti != null && BoolData.ASA != null)
		{
			base.transform.position = BoolData.ASA.transform.position;
			base.transform.LookAt(Player.transform);
		}
	}
}
public class OneSkillMove : MonoBehaviour
{
	private int lef = 3;

	private float xue;

	private float shen = 100f;

	public GameObject A;

	private GameObject B;

	public GameObject shengying;

	public GameObject texiaos;

	public GameObject yinxiao;

	public GameObject shoushang;

	public GameObject Baozha;

	private GameObject C;

	private bool tack;

	private bool isjuli = true;

	private void Start()
	{
		B = base.transform.GetChild(0).gameObject;
		if (base.transform.tag == "炸弹")
		{
			lef = 2;
		}
		xue = lef;
	}

	private void Update()
	{
		shen = (float)lef / xue;
		MonoBehaviour.print("shen" + shen);
		if (Input.GetKeyDown(KeyCode.E))
		{
			lef--;
			MonoBehaviour.print("lef" + lef);
		}
		B.transform.GetChild(1).transform.GetComponent<Slider>().value = shen;
		if (B.transform.GetChild(0).transform.GetComponent<Slider>().value > B.transform.GetChild(1).transform.GetComponent<Slider>().value)
		{
			B.transform.GetChild(0).transform.GetComponent<Slider>().value -= 0.005f;
		}
		base.transform.LookAt(A.transform);
		float num = Vector3.Distance(base.transform.position, A.transform.position);
		if (base.transform.tag != "炸弹" && num > 4f)
		{
			isjuli = false;
		}
		if (!isjuli)
		{
			base.transform.position = Vector3.MoveTowards(base.transform.position, A.transform.position, Time.deltaTime * 1.5f);
			if (num < 2f)
			{
				tack = true;
				isjuli = true;
			}
		}
		if (tack)
		{
			base.transform.GetComponent<Animator>().SetBool("atack", value: true);
			base.transform.GetComponent<Animator>().SetBool("stand", value: false);
			C = UnityEngine.Object.Instantiate(yinxiao.gameObject, base.transform.position, base.transform.rotation);
			C.SetActive(value: true);
			UnityEngine.Object.Destroy(C.gameObject, 3f);
			Invoke("lifts", 1f);
			Invoke("banck", 2f);
			tack = false;
		}
		if (lef <= 0)
		{
			if (base.transform.tag == "炸弹")
			{
				A = UnityEngine.Object.Instantiate(Baozha.gameObject, base.transform.position + new Vector3(0f, -4f, 0f), Quaternion.identity);
				A.SetActive(value: true);
				UnityEngine.Object.Destroy(A.gameObject, 5f);
			}
			else
			{
				A = UnityEngine.Object.Instantiate(texiaos.gameObject, base.transform.position + new Vector3(0f, -2f, 0f), Quaternion.identity);
				A.SetActive(value: true);
				UnityEngine.Object.Destroy(A.gameObject, 5f);
			}
			C = UnityEngine.Object.Instantiate(shengying.gameObject, base.transform.position, base.transform.rotation);
			C.SetActive(value: true);
			UnityEngine.Object.Destroy(C.gameObject, 5f);
			UnityEngine.Object.Destroy(base.transform.gameObject);
		}
	}

	private void banck()
	{
		base.transform.GetComponent<Animator>().SetBool("atack", value: false);
		base.transform.GetComponent<Animator>().SetBool("stand", value: true);
		Invoke("again", 1f);
	}

	private void again()
	{
		isjuli = false;
	}

	private void lifts()
	{
		BoolData.jingbi -= 5;
		C = UnityEngine.Object.Instantiate(shoushang.gameObject, base.transform.position, base.transform.rotation);
		C.SetActive(value: true);
		UnityEngine.Object.Destroy(C.gameObject, 3f);
	}

	public void diaoxue()
	{
		lef--;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (base.transform.tag == "炸弹" && other.tag == "Player")
		{
			A = UnityEngine.Object.Instantiate(Baozha.gameObject, base.transform.position + new Vector3(0f, -3f, 0f), Quaternion.identity);
			A.SetActive(value: true);
			UnityEngine.Object.Destroy(A.gameObject, 5f);
			C = UnityEngine.Object.Instantiate(shengying.gameObject, base.transform.position, base.transform.rotation);
			C.SetActive(value: true);
			UnityEngine.Object.Destroy(C.gameObject, 5f);
			UnityEngine.Object.Destroy(base.transform.gameObject);
			BoolData.jingbi -= 5;
		}
	}
}
public class monster : MonoBehaviour
{
	public GameObject mosters;

	public GameObject texiao;

	public static bool istexiaos;

	private GameObject A;

	private void Start()
	{
	}

	private void Update()
	{
		if (istexiaos)
		{
			for (int i = 0; i < base.transform.childCount; i++)
			{
				if (base.transform.GetChild(i).childCount == 0)
				{
					A = UnityEngine.Object.Instantiate(texiao, base.transform.GetChild(i).transform.position, base.transform.GetChild(i).transform.rotation, base.transform.GetChild(i));
					A.transform.SetParent(null);
					UnityEngine.Object.Destroy(A.gameObject, 4f);
				}
			}
			istexiaos = false;
		}
		if (!BoolData.OneSkill)
		{
			return;
		}
		for (int j = 0; j < base.transform.childCount; j++)
		{
			if (base.transform.GetChild(j).childCount == 0)
			{
				A = UnityEngine.Object.Instantiate(mosters, base.transform.GetChild(j).transform.position, base.transform.GetChild(j).transform.rotation, base.transform.GetChild(j));
				A.transform.GetComponent<OneSkillMove>().enabled = true;
				A.transform.SetParent(null);
			}
		}
		BoolData.OneSkill = false;
	}
}
public class HeatScript : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerStay(Collider other)
	{
		if (BoolData.Boos.isShangHai && other.tag == "Player")
		{
			MonoBehaviour.print("vvvvvvvvvvvvvvvvvvvvvvvvvvvvv");
			BoolData.Boos.isShangHai = false;
			UnityEngine.Object.Destroy(base.transform.gameObject);
		}
	}
}
public class Look : MonoBehaviour
{
	public GameObject player;

	private void Start()
	{
	}

	private void Update()
	{
		base.transform.LookAt(player.transform);
	}
}
public class PlaneScript : MonoBehaviour
{
	private GameObject dus;

	public GameObject du;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "技能2")
		{
			dus = UnityEngine.Object.Instantiate(du.gameObject, other.transform.position, Quaternion.identity);
			UnityEngine.Object.Destroy(other.gameObject);
			UnityEngine.Object.Destroy(dus.gameObject, 10f);
			Invoke("xiaoshi", 5f);
		}
	}

	private void xiaoshi()
	{
		UnityEngine.Object.Destroy(dus.gameObject);
	}
}
public class Test : MonoBehaviour
{
	private int k;

	public GameObject du;

	private GameObject cube;

	private GameObject cubes;

	private void Start()
	{
		cubes = GameObject.Find("待机");
	}

	private void Update()
	{
		if (BoolData.Boos.iszhunbei && base.transform.childCount == 0 && !BoolData.Boos.isatack)
		{
			cube = UnityEngine.Object.Instantiate(cubes.gameObject, cubes.transform.position, cubes.transform.rotation);
			cube.tag = "炸弹";
			cube.GetComponent<OneSkillMove>().enabled = true;
			cube.GetComponent<SphereCollider>().isTrigger = true;
			cube.transform.position = base.transform.TransformPoint(0f, 0f, 2f);
			cube.transform.parent = base.transform;
			cube.GetComponent<Rigidbody>().isKinematic = true;
			BoolData.Boos.isatack = true;
		}
		if (Input.GetKeyDown(KeyCode.L))
		{
			cube = UnityEngine.Object.Instantiate(cubes.gameObject, cubes.transform.position, cubes.transform.rotation);
			cube.transform.position = base.transform.TransformPoint(0f, 0f, 2f);
			cube.transform.parent = base.transform;
			cube.GetComponent<Rigidbody>().isKinematic = true;
		}
		if (BoolData.Boos.iszhunbei && BoolData.Boos.isatack && base.transform.childCount == 1 && cube.transform.parent == base.transform)
		{
			cube.GetComponent<Rigidbody>().isKinematic = false;
			base.transform.DetachChildren();
			Vector3 force = base.transform.TransformDirection(0f, 0f, 5f);
			MonoBehaviour.print(k);
			cube.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
			BoolData.Boos.iszhunbei = false;
			BoolData.Boos.isatack = false;
		}
		if (Input.GetKey(KeyCode.G) && cube.transform.parent == base.transform)
		{
			cube.GetComponent<Rigidbody>().isKinematic = false;
			base.transform.DetachChildren();
			int num = UnityEngine.Random.Range(-1, 1);
			int num2 = UnityEngine.Random.Range(-1, 1);
			if (BoolData.juli < 3f)
			{
				k = -10;
			}
			if (BoolData.juli > 3f && BoolData.juli < 5f)
			{
				k = -12;
			}
			if (BoolData.juli > 5f)
			{
				k = -14;
			}
			Vector3 force2 = base.transform.TransformDirection(num, num2, k);
			MonoBehaviour.print(k);
			cube.GetComponent<Rigidbody>().AddForce(force2, ForceMode.Impulse);
		}
	}
}
public class TwoSkill : MonoBehaviour
{
	public GameObject texiao;

	private GameObject A;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnParticleCollision(GameObject other)
	{
		if (other.tag == "地点3")
		{
			A = UnityEngine.Object.Instantiate(texiao.gameObject);
			Invoke("xiaoshi", 4f);
		}
	}

	private void xiaoshi()
	{
		UnityEngine.Object.Destroy(A.gameObject);
	}
}
public class Testss : MonoBehaviour
{
	private Animator self;

	private void Start()
	{
		self = base.transform.GetComponent<Animator>();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.U))
		{
			self.SetBool("one", value: true);
			self.SetBool("stand", value: false);
		}
		if (Input.GetKeyDown(KeyCode.J))
		{
			self.SetBool("tow", value: true);
			self.SetBool("stand", value: false);
		}
		if (Input.GetKeyDown(KeyCode.H))
		{
			self.SetBool("three", value: true);
			self.SetBool("stand", value: false);
		}
		if (Input.GetKeyDown(KeyCode.K))
		{
			self.SetBool("atack", value: true);
			self.SetBool("stand", value: false);
		}
		if (Input.GetKeyDown(KeyCode.B))
		{
			self.SetBool("atack", value: false);
			self.SetBool("stand", value: true);
			self.SetBool("three", value: false);
			self.SetBool("tow", value: false);
			self.SetBool("one", value: false);
		}
	}
}
public class tishiss : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
public class MoshiScript : MonoBehaviour
{
	public GameObject Dr;

	private bool iscous;

	private bool isgame;

	private void Start()
	{
	}

	private void Update()
	{
		if (BoolData.Course == 5)
		{
			MonoBehaviour.print(BoolData.Course);
			Invoke("xiaoshi", 6f);
			MonoBehaviour.print("刷新了");
			BoolData.Course = 0;
			BoolData.istrues = true;
			if (BoolData.IsGame)
			{
				BoolData.IsCaster = true;
			}
			BoolData.Course = 0;
		}
		if (BoolData.IsCourse && !iscous)
		{
			base.transform.GetChild(2).transform.gameObject.SetActive(value: true);
			iscous = true;
		}
		if (BoolData.IsGame && !isgame)
		{
			base.transform.GetChild(0).transform.gameObject.SetActive(value: true);
			isgame = true;
		}
	}

	private void xiaoshi()
	{
		Dr.SetActive(value: true);
		base.transform.GetChild(2).transform.gameObject.SetActive(value: false);
	}
}
public class course : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
	}
}
public class shadowMove : MonoBehaviour
{
	public GameObject A;

	private int speed;

	private void Start()
	{
		speed = BoolData.Boos.PlayerSpeed;
	}

	private void Update()
	{
		if (BoolData.Boos.isspeed)
		{
			speed = BoolData.Boos.PlayerSpeed;
			BoolData.Boos.isspeed = false;
		}
		MonoBehaviour.print(speed);
		float num = Vector3.Distance(base.transform.position, A.transform.position);
		if (num < 1f && num > 0f)
		{
			base.transform.position = Vector3.MoveTowards(base.transform.position, A.transform.position, Time.deltaTime * (float)(speed - 3));
		}
		if (num > 1f && num < 3f)
		{
			base.transform.position = Vector3.MoveTowards(base.transform.position, A.transform.position, Time.deltaTime * (float)speed);
		}
		if (num > 3f)
		{
			base.transform.position = Vector3.MoveTowards(base.transform.position, A.transform.position, Time.deltaTime * (float)(speed + 3));
		}
	}
}
public class AllProp : MonoBehaviour
{
	public GameObject[] Prop;

	public GameObject[] CloneProp;

	public bool[] IsTrue;

	private void Start()
	{
		CloneProp = new GameObject[8];
		IsTrue = new bool[8];
	}

	private void Update()
	{
		for (int i = 0; i < base.transform.childCount; i++)
		{
			CloneProp[i] = base.transform.GetChild(i).gameObject;
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			RenewAllProp();
		}
		if (Input.GetKeyDown(KeyCode.F))
		{
			RegressionAllProp();
		}
	}

	public void RenewAllProp()
	{
		for (int i = 0; i < CloneProp.Length; i++)
		{
			UnityEngine.Object.Destroy(CloneProp[i].gameObject);
		}
		BoolData.isIns = true;
		BoolData.isTheer = true;
		BoolData.isTrue = true;
		BoolData.isshaozi = false;
		BoolData.iskuaizi = false;
		BoolData.ismian = false;
		BoolData.isPDG = false;
		BoolData.isyoushao = false;
	}

	public void RegressionAllProp()
	{
		for (int i = 0; i < Prop.Length; i++)
		{
			for (int j = 0; j < CloneProp.Length; j++)
			{
				if (Prop[i].name + "(Clone)" == CloneProp[j].name)
				{
					CloneProp[j].transform.position = Prop[i].transform.position;
					CloneProp[j].transform.rotation = Prop[i].transform.rotation;
				}
			}
		}
	}
}
public class AllTalk : MonoBehaviour
{
	private Vector3 pos;

	private Quaternion Rote;

	private bool ischange;

	private GameObject B;

	private GameObject s;

	public int i;

	private void Start()
	{
		pos = base.transform.position;
		Rote = base.transform.rotation;
		B = base.transform.parent.gameObject;
		s = base.transform.parent.GetChild(0).gameObject;
	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
		if ((other.transform.tag == "地面" || other.transform.tag == "内地面") && (base.transform.tag == "香肠3" || base.transform.tag == "糖油粑粑3" || base.transform.tag == "豆腐3"))
		{
			base.transform.parent = null;
			if (other.transform.tag == "内地面")
			{
				UnityEngine.Object.Destroy(base.transform.gameObject);
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (!ischange && (other.tag == "香肠" || other.tag == "糖油粑粑" || other.tag == "臭豆腐") && base.transform.parent.childCount <= i)
		{
			GameObject obj = UnityEngine.Object.Instantiate(s, pos, Rote);
			obj.transform.gameObject.isStatic = false;
			obj.transform.GetComponent<Rigidbody>().isKinematic = false;
			obj.transform.GetComponent<Rigidbody>().useGravity = true;
			obj.transform.SetParent(B.transform);
			Invoke("change", 0.5f);
			ischange = true;
		}
	}

	private void change()
	{
		ischange = false;
	}
}
public class AudioScript : MonoBehaviour
{
	public GameObject Audio;

	private void Start()
	{
	}

	private void Update()
	{
		if (!Audio.GetComponent<AudioSource>().isPlaying)
		{
			Audio.GetComponent<AudioSource>().Play();
		}
		if (!Audio.activeSelf)
		{
			Audio.SetActive(value: true);
		}
	}
}
public class LeftHand : MonoBehaviour
{
	public GameObject HandUI;

	private bool ischange;

	private void Start()
	{
	}

	private void Update()
	{
		if (HVRInputManager.Instance.RightController.TriggerButtonState.Active)
		{
			if (!ischange)
			{
				HandUI.SetActive(value: false);
				ischange = true;
			}
			else
			{
				HandUI.SetActive(value: true);
				ischange = true;
			}
		}
	}
}
public class CarScript : MonoBehaviour
{
	public GameObject[] Car;

	private int i;

	private float j;

	private GameObject A;

	private bool ismove;

	private float s;

	private void Start()
	{
		j = UnityEngine.Random.Range(800, 1000);
		j /= 100f;
		s = j;
	}

	private void Update()
	{
		if (!LIkai.fangxia)
		{
			j = s;
		}
		else
		{
			j = 0f;
		}
		if (base.transform.childCount == 1 && BoolData.AllIns)
		{
			i = UnityEngine.Random.Range(0, 6);
			A = UnityEngine.Object.Instantiate(Car[i].gameObject, base.transform.position, base.transform.rotation, base.transform);
		}
		if (A.transform.gameObject.activeSelf && A != null)
		{
			A.transform.position = Vector3.MoveTowards(A.transform.position, base.transform.GetChild(0).transform.position, Time.deltaTime * j);
		}
	}

	private void shengcheng()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "车")
		{
			UnityEngine.Object.Destroy(other.transform.gameObject);
		}
	}
}
public class Daojishi : MonoBehaviour
{
	public static int i = 6000;

	private void Start()
	{
	}

	private void Update()
	{
		i--;
		base.transform.GetComponent<Text>().text = i / 100 + "s";
		if (i <= 0)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
		}
	}

	private IEnumerator Times()
	{
		while (i >= 0)
		{
			base.transform.GetComponent<Text>().text = i / 100 + "s";
			yield return new WaitForSeconds(1f);
			i--;
		}
	}
}
public class EatingExit : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
		switch (other.tag)
		{
		case "Player":
			UnityEngine.Object.Destroy(other.gameObject);
			break;
		case "eating":
			UnityEngine.Object.Destroy(other.gameObject);
			break;
		case "路人":
			UnityEngine.Object.Destroy(other.gameObject);
			break;
		}
	}
}
public class Mischief : MonoBehaviour
{
	public GameObject Mischiefs;

	private GameObject A;

	private Text timess;

	private float i;

	private void Start()
	{
	}

	private void Update()
	{
		if (BoolData.ischuxian && base.transform.childCount == 1)
		{
			A = UnityEngine.Object.Instantiate(Mischiefs, Mischiefs.transform.position, Mischiefs.transform.rotation, base.transform);
			A.SetActive(value: true);
			MonoBehaviour.print("捣蛋猫出现。");
			BoolData.ischuxian = false;
			BoolData.istrues = false;
		}
		if (BoolData.istrues)
		{
			if (BoolData.IsCourse)
			{
				i = 4f;
			}
			if (BoolData.IsGame)
			{
				i = UnityEngine.Random.Range(80, 120);
			}
			MonoBehaviour.print("i=" + i);
			Invoke("shengcheng", i);
			BoolData.istrues = false;
		}
	}

	private void shengcheng()
	{
		BoolData.ischuxian = true;
	}
}
public class MoveScript : MonoBehaviour
{
	private bool ismove;

	private bool move = true;

	private bool istur;

	private GameObject A;

	private void Update()
	{
		if (!BoolData.OneBox && base.transform.tag == "地点1")
		{
			base.transform.GetComponent<BoxCollider>().enabled = true;
		}
		if (!BoolData.TwoBox && base.transform.tag == "地点2")
		{
			base.transform.GetComponent<BoxCollider>().enabled = true;
		}
		if (!BoolData.TherrBox && base.transform.tag == "地点3")
		{
			base.transform.GetComponent<BoxCollider>().enabled = true;
		}
		if (A != null)
		{
			if (A.tag == "人物" && ismove)
			{
				A.transform.position = Vector3.MoveTowards(A.transform.position, base.transform.GetChild(0).transform.position, Time.deltaTime);
			}
			if (A.tag == "eating")
			{
				ismove = false;
				if (move)
				{
					A.transform.position = Vector3.MoveTowards(A.transform.position, base.transform.position, Time.deltaTime);
					if (!istur)
					{
						Invoke("endmove", 1f);
						istur = true;
					}
				}
			}
		}
		if (BoolData.j >= 5)
		{
			BoolData.isone = true;
			BoolData.isture = true;
			BoolData.issan = true;
			base.transform.GetComponent<BoxCollider>().enabled = false;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "人物")
		{
			ismove = true;
			A = other.gameObject;
		}
	}

	private void endmove()
	{
		move = false;
	}
}
public class RayScript : MonoBehaviour
{
	public GameObject A;

	public GameObject yingxiao;

	public GameObject Content;

	public GameObject Item;

	private GameObject zongdidian;

	private GameObject shenying;

	private GameObject caidan;

	public GameObject zanting;

	public static GameObject gongkaiznating;

	private GameObject didians;

	private GameObject naiq;

	private GameObject As;

	private GameObject PH;

	private bool istigger;

	private bool isna;

	private bool isxuanzhe;

	private Vector3 poss;

	private void Start()
	{
		didians = GameObject.FindWithTag("总人物").gameObject;
		zongdidian = GameObject.FindWithTag("总地点").gameObject;
		caidan = GameObject.FindWithTag("总菜单").gameObject;
		gongkaiznating = zanting;
	}

	private void Update()
	{
		HVRController rightController = HVRInputManager.Instance.RightController;
		if (Input.GetKeyDown(KeyCode.P))
		{
			Time.timeScale = 1f;
			Times.istime = false;
			A.SetActive(value: false);
		}
		if (istigger && isxuanzhe)
		{
			As.transform.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
		}
		if (rightController.TriggerButtonState.Active)
		{
			istigger = true;
		}
		new Ray(base.transform.position, base.transform.forward);
		if (Physics.Raycast(base.transform.position, base.transform.forward, out var hitInfo, 150f))
		{
			if (hitInfo.transform.tag == "排行")
			{
				if (rightController.TriggerButtonState.Active)
				{
					poss = base.transform.parent.transform.position;
				}
				if (rightController.TriggerButtonState.Active)
				{
					Vector3 vector = new Vector3(0f, base.transform.parent.transform.position.y - poss.y, 0f);
					hitInfo.transform.GetChild(0).transform.position += vector;
				}
			}
			if (hitInfo.transform.tag == "教程" || hitInfo.transform.tag == "开始" || hitInfo.transform.tag == "排行榜" || hitInfo.transform.tag == "退出" || hitInfo.transform.tag == "继续游戏" || hitInfo.transform.tag == "返回主菜单")
			{
				hitInfo.transform.GetComponent<Image>().color = new Color(0.8f, 0.8f, 0.8f);
			}
			else if (!istigger)
			{
				for (int i = 0; i < caidan.transform.GetChild(0).GetChild(0).childCount; i++)
				{
					caidan.transform.GetChild(0).GetChild(0).GetChild(i)
						.GetComponent<Image>()
						.color = new Color(1f, 1f, 1f);
				}
				for (int j = 0; j < zanting.transform.GetChild(0).GetChild(0).childCount; j++)
				{
					caidan.transform.GetChild(0).GetChild(0).GetChild(j)
						.GetComponent<Image>()
						.color = new Color(1f, 1f, 1f);
				}
			}
			if (rightController.TriggerButtonState.Active)
			{
				if (hitInfo.transform.tag == "教程" || hitInfo.transform.tag == "开始" || hitInfo.transform.tag == "排行榜" || hitInfo.transform.tag == "退出" || hitInfo.transform.tag == "继续游戏" || hitInfo.transform.tag == "返回主菜单")
				{
					hitInfo.transform.GetComponent<Image>().color = new Color(0.6f, 0.6f, 0.6f);
				}
				else if (istigger)
				{
					for (int k = 0; k < caidan.transform.GetChild(0).GetChild(0).childCount; k++)
					{
						caidan.transform.GetChild(0).GetChild(0).GetChild(k)
							.GetComponent<Image>()
							.color = new Color(1f, 1f, 1f);
					}
					for (int l = 0; l < zanting.transform.GetChild(0).GetChild(0).childCount; l++)
					{
						caidan.transform.GetChild(0).GetChild(0).GetChild(l)
							.GetComponent<Image>()
							.color = new Color(1f, 1f, 1f);
					}
				}
			}
			UnityEngine.Debug.DrawLine(base.transform.transform.position, hitInfo.point, Color.green);
			if (rightController.TriggerButtonState.Active)
			{
				istigger = false;
				if (hitInfo.transform.tag == "教程" || hitInfo.transform.tag == "开始")
				{
					shenying = UnityEngine.Object.Instantiate(yingxiao.transform.GetChild(5).gameObject, yingxiao.transform.GetChild(5).transform.position, yingxiao.transform.GetChild(5).transform.rotation, yingxiao.transform);
					shenying.SetActive(value: true);
					UnityEngine.Object.Destroy(shenying.gameObject, 2f);
					hitInfo.transform.parent.transform.parent.parent.gameObject.SetActive(value: false);
					hitInfo.transform.GetComponent<Image>().color = new Color(255f, 255f, 255f);
					for (int m = 0; m < zongdidian.transform.childCount; m++)
					{
						zongdidian.transform.GetChild(m).GetComponent<BoxCollider>().enabled = true;
					}
					BoolData.j = 0;
					BoolData.n = 0;
					BoolData.jingbi = 0;
					BoolData.Change.T = 1;
					BoolData.Course = 0;
					Times.S = 0;
					Times.M = 0f;
					TiggerManage.fanhui = true;
					BoolData.OneBox = false;
					BoolData.TwoBox = false;
					BoolData.TherrBox = false;
					BoolData.OneWeizhi = false;
					BoolData.TowWeizhi = false;
					BoolData.ThreeWeizhi = false;
					if (hitInfo.transform.tag == "教程")
					{
						tishi.kaishi = 380f;
						ButtonScript.gongkaiUI[2].transform.GetChild(5).transform.gameObject.SetActive(value: true);
						ButtonScript.gongkaiUI[2].transform.GetChild(5).GetChild(0).GetChild(1)
							.transform.GetComponent<BoxCollider>().enabled = true;
					}
					if (hitInfo.transform.tag == "开始")
					{
						BoolData.isshangchuan = false;
						BoolData.istimes = false;
						BoolData.shengli = true;
						Rote.tingzhi = true;
						BoolData.Boos.shit = true;
						BoolData.Boos.shibai = false;
						Times.istime = false;
						BoolData.IsGame = true;
						for (int n = 0; n <= 2; n++)
						{
							if (didians.transform.GetChild(0).GetChild(0).GetChild(n)
								.GetChild(1)
								.gameObject != null)
							{
								UnityEngine.Object.Destroy(didians.transform.GetChild(0).GetChild(0).GetChild(n)
									.GetChild(1)
									.gameObject);
									didians.transform.GetChild(0).GetChild(0).GetChild(n)
										.gameObject.SetActive(value: false);
								}
								if (didians.transform.GetChild(0).GetChild(0).GetChild(n)
									.GetChild(1)
									.gameObject != null)
								{
									UnityEngine.Object.Destroy(didians.transform.GetChild(0).GetChild(1).GetChild(n)
										.GetChild(1)
										.gameObject);
										didians.transform.GetChild(0).GetChild(1).GetChild(n)
											.gameObject.SetActive(value: false);
									}
									BoolData.AllIns = true;
								}
							}
						}
						if (hitInfo.transform.tag == "排行榜")
						{
							shenying = UnityEngine.Object.Instantiate(yingxiao.transform.GetChild(5).gameObject, yingxiao.transform.GetChild(5).transform.position, yingxiao.transform.GetChild(5).transform.rotation, yingxiao.transform);
							shenying.SetActive(value: true);
							UnityEngine.Object.Destroy(shenying.gameObject, 2f);
							hitInfo.transform.parent.transform.parent.parent.gameObject.SetActive(value: false);
							hitInfo.transform.GetComponent<Image>().color = new Color(255f, 255f, 255f);
							BoolData.isphb = false;
							chakan();
						}
						if (hitInfo.transform.tag == "返回主菜单")
						{
							BoolData.isphb = false;
							BoolData.istimes = false;
							ButtonScript.gongkaiUI[2].transform.parent.GetChild(3).GetChild(1).transform.gameObject.SetActive(value: false);
							shenying = UnityEngine.Object.Instantiate(yingxiao.transform.GetChild(5).gameObject, yingxiao.transform.GetChild(5).transform.position, yingxiao.transform.GetChild(5).transform.rotation, yingxiao.transform);
							shenying.SetActive(value: true);
							zanting.SetActive(value: false);
							UnityEngine.Object.Destroy(shenying.gameObject, 2f);
							hitInfo.transform.GetComponent<Image>().color = new Color(1f, 1f, 1f);
							Time.timeScale = 1f;
							TiggerManage.isstop = false;
							base.transform.parent.GetChild(6).GetChild(8).GetComponent<TiggerManage>()
								.fanhuizhu();
							A.SetActive(value: true);
							hitInfo.transform.parent.gameObject.SetActive(value: false);
							ButtonScript.gongkaiUI[2].transform.GetChild(6).transform.gameObject.SetActive(value: false);
							base.transform.parent.parent.GetChild(0).GetChild(6).GetChild(0)
								.GetChild(1)
								.GetChild(0)
								.GetChild(0)
								.GetComponent<Text>()
								.text = "按下-键暂停游戏";
							if (BoolData.jingbi > BoolData.jing)
							{
								BoolData.jing = BoolData.jingbi;
							}
							if (BoolData.timess > BoolData.shijian)
							{
								BoolData.shijian = BoolData.timess;
							}
							if (BoolData.timess == BoolData.shijian && BoolData.miaos > BoolData.miao)
							{
								BoolData.miao = BoolData.miaos;
							}
							Data1.Gold = BoolData.jingbi;
							Data1.Time = $"{BoolData.timess:00}" + ":" + $"{BoolData.miaos:00}";
							new Server().UploadPlayerInfos().Coroutine();
							TiggerManage.Canevas.transform.GetChild(6).GetComponent<Text>().text = "返回主菜单了";
							CancelInvoke();
						}
						if (hitInfo.transform.tag == "继续游戏")
						{
							shenying = UnityEngine.Object.Instantiate(yingxiao.transform.GetChild(5).gameObject, yingxiao.transform.GetChild(5).transform.position, yingxiao.transform.GetChild(5).transform.rotation, yingxiao.transform);
							shenying.SetActive(value: true);
							UnityEngine.Object.Destroy(shenying.gameObject, 2f);
							base.transform.parent.parent.GetChild(0).GetChild(6).GetChild(0)
								.GetChild(1)
								.GetChild(0)
								.GetChild(0)
								.GetComponent<Text>()
								.text = "按下-键暂停游戏";
							zanting.SetActive(value: false);
							hitInfo.transform.GetComponent<Image>().color = new Color(1f, 1f, 1f);
							Time.timeScale = 1f;
							TiggerManage.isstop = false;
							if (BoolData.IsGame)
							{
								Rote.tingzhi = true;
								BoolData.istimes = false;
							}
							Times.istime = false;
							TiggerManage.isstop = false;
							Times.istime = false;
							A.SetActive(value: false);
						}
						if (hitInfo.transform.tag == "返回游戏")
						{
							shenying = UnityEngine.Object.Instantiate(yingxiao.transform.GetChild(5).gameObject, yingxiao.transform.GetChild(5).transform.position, yingxiao.transform.GetChild(5).transform.rotation, yingxiao.transform);
							shenying.SetActive(value: true);
							UnityEngine.Object.Destroy(shenying.gameObject, 2f);
							BoolData.IsCourse = true;
							TiggerManage.iscouse = true;
							tishi.kaishi = -1f;
							didians.transform.GetChild(2).gameObject.SetActive(value: true);
							ButtonScript.gongkaiUI[2].transform.GetChild(5).GetChild(0).GetChild(1)
								.transform.GetComponent<BoxCollider>().enabled = false;
							Invoke("xiaoshisas", 4f);
						}
						if (hitInfo.transform.tag == "退出")
						{
							hitInfo.transform.GetComponent<Image>().color = new Color(255f, 255f, 255f);
							shenying = UnityEngine.Object.Instantiate(yingxiao.transform.GetChild(5).gameObject, yingxiao.transform.GetChild(5).transform.position, yingxiao.transform.GetChild(5).transform.rotation, yingxiao.transform);
							shenying.SetActive(value: true);
							UnityEngine.Object.Destroy(shenying.gameObject, 2f);
							Application.Quit();
						}
					}
				}
				if (rightController.TriggerButtonState.Active && isna)
				{
					base.transform.parent.GetChild(6).GetChild(8).GetComponent<MeshCollider>()
						.enabled = true;
					naiq.transform.GetComponent<Rigidbody>().useGravity = true;
					naiq.transform.GetComponent<Rigidbody>().isKinematic = false;
					naiq.transform.SetParent(null);
					isna = false;
				}
			}

			private void xiaoshisas()
			{
				ButtonScript.gongkaiUI[2].transform.GetChild(5).transform.gameObject.SetActive(value: false);
			}

			public async void chakan()
			{
				if (await new Server().GetPlayerInfos() == "获取成功")
				{
					paixu();
				}
			}

			private void paixu()
			{
				ButtonScript.gongkaiUI[2].transform.parent.GetChild(3).GetChild(1).transform.gameObject.SetActive(value: true);
				int Num = 1;
				for (int i = 0; i < Content.transform.childCount; i++)
				{
					UnityEngine.Object.Destroy(Content.transform.GetChild(i).gameObject);
				}
				string[] array = Data1.Infos.Split('|');
				Content.GetComponent<RectTransform>().sizeDelta = new Vector2(0f, 58f * (float)(array.Length - 1));
				List<string> list = new List<string>();
				for (int j = 1; j < array.Length; j++)
				{
					list.Add(array[j]);
				}
				list.OrderByDescending((string L) => float.Parse(L.Split('/')[1].Split('*')[1].Split('?')[0])).ToList().ForEach(delegate(string a)
				{
					string[] array2 = a.Split('/')[1].Split('*');
					string text = array2[0];
					string[] array3 = array2[1].Split('?');
					string text2 = array3[0];
					string text3 = array3[1];
					GameObject obj = UnityEngine.Object.Instantiate(Item);
					obj.transform.SetParent(Content.transform, worldPositionStays: false);
					obj.GetComponent<Item>().Ranking = Num.ToString();
					obj.GetComponent<Item>().name = text;
					obj.GetComponent<Item>().Name = text;
					obj.GetComponent<Item>().Gold = text2;
					obj.GetComponent<Item>().Time = text3;
					obj.GetComponent<Item>().Change();
					UnityEngine.Debug.Log("玩家信息：Name:" + text + "    Gold:" + text2 + "     Score:" + text3);
					Num++;
				});
			}
		}
		public class Rote : MonoBehaviour
		{
			public Material[] biaoqing;

			private Material lian;

			private Animator donghua;

			private Quaternion Rotes;

			public static GameObject A;

			private GameObject xianshi;

			private GameObject xianshi2;

			private GameObject yinxiao;

			private GameObject shenying;

			private GameObject didian;

			private GameObject shiwu1;

			private GameObject shiwu2;

			private GameObject panzi;

			public Sprite[] tu;

			public static int suiji;

			public static bool tingzhi;

			private int i;

			private int j;

			private int t;

			private float l = 60f;

			private int g;

			private int cus;

			private int gailv;

			private float k;

			private float S;

			private bool isshiwuzhuanhuan1;

			private bool isshiwuzhuanhuan2;

			private bool ispengzhuang;

			private bool issanmu;

			private bool isnobox;

			private bool zhuangtai;

			private bool ismove;

			private bool isend;

			private bool istime;

			private bool isone;

			private bool istrue;

			public static bool ismove2;

			public static bool ones;

			public static bool twos;

			public static bool threes;

			private bool peoplemove = true;

			private bool iszhuanhuan = true;

			private int h;

			private void Start()
			{
				didian = GameObject.FindWithTag("总地点").gameObject;
				if (cus < 3)
				{
					cus = BoolData.Course;
				}
				yinxiao = GameObject.FindWithTag("声音").gameObject;
				for (int i = 0; i < base.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().materials.Length; i++)
				{
					if (base.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().materials[i].name == "3 (Instance)")
					{
						lian = base.transform.GetChild(1).GetComponent<SkinnedMeshRenderer>().materials[i];
					}
				}
				lian.CopyPropertiesFromMaterial(biaoqing[4]);
				j = UnityEngine.Random.Range(0, 4);
				t = UnityEngine.Random.Range(0, 4);
				this.i = UnityEngine.Random.Range(1, 4);
				if (BoolData.IsCaster)
				{
					k = UnityEngine.Random.Range(10, 25);
					k /= 10f;
				}
				else
				{
					k = UnityEngine.Random.Range(3, 5);
				}
				donghua = base.transform.GetComponent<Animator>();
				panzi = GameObject.FindWithTag("盘子" + this.i);
				if (BoolData.IsCourse && !BoolData.IsCaster)
				{
					if (BoolData.Course < 4)
					{
						suiji = 0;
						j = cus;
					}
					else
					{
						suiji = 1;
						h = 1;
					}
					MonoBehaviour.print(BoolData.Course);
					MonoBehaviour.print(j);
				}
				if (BoolData.IsGame && !BoolData.IsCaster)
				{
					if (BoolData.Course < 4)
					{
						suiji = 0;
						j = cus;
					}
					else
					{
						suiji = 1;
						h = 1;
					}
					istime = true;
					tingzhi = true;
				}
				S = k;
			}

			private void Update()
			{
				if (!LIkai.fangxia)
				{
					this.k = S;
				}
				else
				{
					this.k = 0f;
				}
				if (BoolData.OneWeizhi)
				{
					didian.transform.GetChild(2).transform.GetComponent<BoxCollider>().enabled = false;
					if (this.i == 1)
					{
						ispengzhuang = true;
						Invoke("pengzhuang", 0.2f);
					}
				}
				if (BoolData.TowWeizhi)
				{
					didian.transform.GetChild(1).transform.GetComponent<BoxCollider>().enabled = false;
					if (this.i == 2)
					{
						ispengzhuang = true;
						Invoke("pengzhuang", 0.2f);
					}
				}
				if (BoolData.ThreeWeizhi)
				{
					didian.transform.GetChild(0).transform.GetComponent<BoxCollider>().enabled = false;
					if (this.i == 3)
					{
						ispengzhuang = true;
						Invoke("pengzhuang", 0.2f);
					}
				}
				if (BoolData.OneBox)
				{
					didian.transform.GetChild(2).transform.GetComponent<BoxCollider>().enabled = false;
				}
				else
				{
					didian.transform.GetChild(2).transform.GetComponent<BoxCollider>().enabled = true;
				}
				if (BoolData.TwoBox)
				{
					didian.transform.GetChild(1).transform.GetComponent<BoxCollider>().enabled = false;
				}
				else
				{
					didian.transform.GetChild(1).transform.GetComponent<BoxCollider>().enabled = true;
				}
				if (BoolData.TherrBox)
				{
					didian.transform.GetChild(0).transform.GetComponent<BoxCollider>().enabled = false;
				}
				else
				{
					didian.transform.GetChild(0).transform.GetComponent<BoxCollider>().enabled = true;
				}
				if (BoolData.istimes)
				{
					istime = false;
				}
				else
				{
					istime = true;
				}
				if (TiggerManage.iscouse)
				{
					BoolData.IsCourse = true;
				}
				MonoBehaviour.print("BoolData.IsGame" + BoolData.IsGame);
				MonoBehaviour.print("BoolData.IsCourse" + BoolData.IsCourse);
				if (base.transform.parent.transform.parent.name == "LuRen")
				{
					this.i = 4;
				}
				if (t == this.j)
				{
					t = UnityEngine.Random.Range(0, 4);
				}
				if (!istime)
				{
					base.transform.GetChild(2).transform.GetChild(0).transform.GetComponent<Text>().text = "  ";
				}
				if (this.l < (float)g && this.l > 0f)
				{
					lian.CopyPropertiesFromMaterial(biaoqing[0]);
				}
				base.transform.rotation = Quaternion.Slerp(base.transform.rotation, Rotes, Time.deltaTime * 2f);
				if (peoplemove)
				{
					base.transform.position = Vector3.MoveTowards(base.transform.position, base.transform.parent.transform.GetChild(0).transform.position, Time.deltaTime * this.k);
				}
				if (ismove)
				{
					switch (base.transform.tag)
					{
					case "人物1":
						base.transform.position = Vector3.MoveTowards(base.transform.position, didian.transform.GetChild(2).transform.GetChild(0).transform.position, Time.deltaTime);
						break;
					case "人物2":
						base.transform.position = Vector3.MoveTowards(base.transform.position, didian.transform.GetChild(1).transform.GetChild(0).transform.position, Time.deltaTime);
						break;
					case "人物3":
						base.transform.position = Vector3.MoveTowards(base.transform.position, didian.transform.GetChild(0).transform.GetChild(0).transform.position, Time.deltaTime);
						break;
					}
				}
				if ((BoolData.j >= 5 || BoolData.n >= 5) && BoolData.Ends && !BoolData.isshangchuan)
				{
					ButtonScript.isluren = true;
					Data1.Gold = BoolData.jingbi;
					Data1.Time = $"{Times.S:00}" + ":" + $"{(int)Times.M:00}";
					new Server().UploadPlayerInfos().Coroutine();
					MonoBehaviour.print("结束了");
					BoolData.isshangchuan = true;
					BoolData.Ends = false;
				}
				if (base.transform.tag == "人物" || base.transform.tag == "路人")
				{
					suiji = h;
					if (BoolData.IsGame && istime)
					{
						if (tingzhi && this.l > 0f)
						{
							this.l -= Time.deltaTime;
						}
						if (this.l == 0f)
						{
							base.transform.GetChild(2).transform.GetChild(0).transform.GetComponent<Text>().text = " ";
						}
						else
						{
							base.transform.GetChild(2).transform.GetChild(0).transform.GetComponent<Text>().text = ((int)this.l).ToString();
						}
					}
					switch (this.i)
					{
					case 1:
					{
						int num2;
						if (suiji != 0)
						{
							if (!Panzi.panzi1[this.j])
							{
								goto IL_07e5;
							}
							num2 = (Panzi.panzi1[t] ? 1 : 0);
						}
						else
						{
							num2 = (Panzi.panzi1[this.j] ? 1 : 0);
						}
						if (num2 != 0 && iszhuanhuan)
						{
							for (int j = 0; j < panzi.transform.childCount; j++)
							{
								panzi.transform.GetChild(j).GetComponent<HVRGrabbable>().enabled = false;
							}
							istrue = true;
							lian.CopyPropertiesFromMaterial(biaoqing[1]);
							MonoBehaviour.print("cccccccccc");
							if (suiji == 0)
							{
								if (this.l >= (float)g)
								{
									BoolData.jingbi += 30;
								}
								if (this.l < (float)g)
								{
									BoolData.jingbi += 20;
								}
							}
							if (suiji == 1)
							{
								if (this.l >= (float)g)
								{
									BoolData.jingbi += 80;
								}
								if (this.l < (float)g)
								{
									BoolData.jingbi += 40;
								}
							}
							this.l = 0f;
							shenying = UnityEngine.Object.Instantiate(yinxiao.transform.GetChild(1).gameObject, yinxiao.transform.GetChild(1).transform.position, yinxiao.transform.GetChild(1).transform.rotation, yinxiao.transform);
							shenying.SetActive(value: true);
							Invoke("xiaoshi", 1f);
							donghua.SetBool("IsStanded", value: false);
							donghua.SetBool("IsFun", value: true);
							Invoke("Eat", 1f);
							iszhuanhuan = false;
						}
						goto IL_07e5;
					}
					case 2:
					{
						int num3;
						if (suiji != 0)
						{
							if (!Panzi.panzi2[this.j])
							{
								goto IL_0a4b;
							}
							num3 = (Panzi.panzi2[t] ? 1 : 0);
						}
						else
						{
							num3 = (Panzi.panzi2[this.j] ? 1 : 0);
						}
						if (num3 != 0 && iszhuanhuan)
						{
							for (int k = 0; k < panzi.transform.childCount; k++)
							{
								panzi.transform.GetChild(k).GetComponent<HVRGrabbable>().enabled = false;
							}
							istrue = true;
							lian.CopyPropertiesFromMaterial(biaoqing[1]);
							MonoBehaviour.print("cccccccccc");
							if (suiji == 0)
							{
								if (this.l >= (float)g)
								{
									BoolData.jingbi += 30;
								}
								if (this.l < (float)g)
								{
									BoolData.jingbi += 20;
								}
							}
							if (suiji == 1)
							{
								if (this.l >= (float)g)
								{
									BoolData.jingbi += 80;
								}
								if (this.l < (float)g)
								{
									BoolData.jingbi += 40;
								}
							}
							this.l = 0f;
							shenying = UnityEngine.Object.Instantiate(yinxiao.transform.GetChild(1).gameObject, yinxiao.transform.GetChild(1).transform.position, yinxiao.transform.GetChild(1).transform.rotation, yinxiao.transform);
							shenying.SetActive(value: true);
							Invoke("xiaoshi", 1f);
							donghua.SetBool("IsStanded", value: false);
							donghua.SetBool("IsFun", value: true);
							Invoke("Eat", 1f);
							iszhuanhuan = false;
						}
						goto IL_0a4b;
					}
					case 3:
						{
							int num;
							if (suiji != 0)
							{
								if (!Panzi.panzi3[this.j])
								{
									goto IL_0cb1;
								}
								num = (Panzi.panzi3[t] ? 1 : 0);
							}
							else
							{
								num = (Panzi.panzi3[this.j] ? 1 : 0);
							}
							if (num != 0 && iszhuanhuan)
							{
								for (int i = 0; i < panzi.transform.childCount; i++)
								{
									panzi.transform.GetChild(i).GetComponent<HVRGrabbable>().enabled = false;
								}
								istrue = true;
								lian.CopyPropertiesFromMaterial(biaoqing[1]);
								MonoBehaviour.print("cccccccccc");
								if (suiji == 0)
								{
									if (this.l >= (float)g)
									{
										BoolData.jingbi += 30;
									}
									if (this.l < (float)g)
									{
										BoolData.jingbi += 20;
									}
								}
								if (suiji == 1)
								{
									if (this.l >= (float)g)
									{
										BoolData.jingbi += 80;
									}
									if (this.l < (float)g)
									{
										BoolData.jingbi += 40;
									}
								}
								this.l = 0f;
								shenying = UnityEngine.Object.Instantiate(yinxiao.transform.GetChild(1).gameObject, yinxiao.transform.GetChild(1).transform.position, yinxiao.transform.GetChild(1).transform.rotation, yinxiao.transform);
								shenying.SetActive(value: true);
								Invoke("xiaoshi", 1f);
								donghua.SetBool("IsStanded", value: false);
								donghua.SetBool("IsFun", value: true);
								Invoke("Eat", 1f);
								iszhuanhuan = false;
							}
							goto IL_0cb1;
						}
						IL_0cb1:
						if (suiji == 0)
						{
							if (Panzi.panzi1[this.j])
							{
								shiwu1 = BoolData.TYBB;
							}
							break;
						}
						if (!isshiwuzhuanhuan1 && Panzi.panzi1[this.j])
						{
							shiwu1 = BoolData.TYBB;
							isshiwuzhuanhuan1 = true;
						}
						if (!isshiwuzhuanhuan2 && Panzi.panzi1[t])
						{
							shiwu2 = BoolData.TYBB;
							isshiwuzhuanhuan2 = true;
						}
						break;
						IL_0a4b:
						if (suiji == 0)
						{
							if (Panzi.panzi1[this.j])
							{
								shiwu1 = BoolData.TYBB;
							}
							break;
						}
						if (!isshiwuzhuanhuan1 && Panzi.panzi1[this.j])
						{
							shiwu1 = BoolData.TYBB;
							isshiwuzhuanhuan1 = true;
						}
						if (!isshiwuzhuanhuan2 && Panzi.panzi1[t])
						{
							shiwu2 = BoolData.TYBB;
							isshiwuzhuanhuan2 = true;
						}
						break;
						IL_07e5:
						if (suiji == 0)
						{
							if (Panzi.panzi1[this.j])
							{
								shiwu1 = BoolData.TYBB;
							}
							break;
						}
						if (!isshiwuzhuanhuan1 && Panzi.panzi1[this.j])
						{
							shiwu1 = BoolData.TYBB;
							isshiwuzhuanhuan1 = true;
						}
						if (!isshiwuzhuanhuan2 && Panzi.panzi1[t])
						{
							shiwu2 = BoolData.TYBB;
							isshiwuzhuanhuan2 = true;
						}
						break;
					}
					switch (this.i)
					{
					case 1:
						if (suiji == 0 && !Panzi.panzi1[this.j])
						{
							switch (this.j)
							{
							case 0:
								if (Panzi.panzi1[1] || Panzi.panzi1[2] || Panzi.panzi1[3])
								{
									jieshu();
									shiwu1 = BoolData.TYBB;
								}
								break;
							case 1:
								if (Panzi.panzi1[0] || Panzi.panzi1[2] || Panzi.panzi1[3])
								{
									jieshu();
									shiwu1 = BoolData.TYBB;
								}
								break;
							case 2:
								if (Panzi.panzi1[1] || Panzi.panzi1[0] || Panzi.panzi1[3])
								{
									jieshu();
									shiwu1 = BoolData.TYBB;
								}
								break;
							case 3:
								if (Panzi.panzi1[1] || Panzi.panzi1[2] || Panzi.panzi1[0])
								{
									jieshu();
									shiwu1 = BoolData.TYBB;
								}
								break;
							}
						}
						if (suiji != 1 || (Panzi.panzi1[this.j] && Panzi.panzi1[t]))
						{
							break;
						}
						if (((this.j == 0 && t == 1) || (this.j == 1 && t == 0)) && (Panzi.panzi1[2] || Panzi.panzi1[3]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						if (((this.j == 0 && t == 2) || (this.j == 2 && t == 0)) && (Panzi.panzi1[1] || Panzi.panzi1[3]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						if (((this.j == 0 && t == 3) || (this.j == 3 && t == 0)) && (Panzi.panzi1[1] || Panzi.panzi1[2]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						if (((this.j == 1 && t == 2) || (this.j == 2 && t == 1)) && (Panzi.panzi1[0] || Panzi.panzi1[3]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						if (((this.j == 1 && t == 3) || (this.j == 3 && t == 1)) && (Panzi.panzi1[2] || Panzi.panzi1[0]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						if (((this.j == 3 && t == 2) || (this.j == 2 && t == 3)) && (Panzi.panzi1[1] || Panzi.panzi1[0]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						break;
					case 2:
						if (suiji == 0 && !Panzi.panzi2[this.j])
						{
							switch (this.j)
							{
							case 0:
								if (Panzi.panzi2[1] || Panzi.panzi2[2] || Panzi.panzi2[3])
								{
									jieshu();
									shiwu1 = BoolData.TYBB;
								}
								break;
							case 1:
								if (Panzi.panzi2[0] || Panzi.panzi2[2] || Panzi.panzi2[3])
								{
									jieshu();
									shiwu1 = BoolData.TYBB;
								}
								break;
							case 2:
								if (Panzi.panzi2[1] || Panzi.panzi2[0] || Panzi.panzi2[3])
								{
									jieshu();
									shiwu1 = BoolData.TYBB;
								}
								break;
							case 3:
								if (Panzi.panzi2[1] || Panzi.panzi2[2] || Panzi.panzi2[0])
								{
									jieshu();
									shiwu1 = BoolData.TYBB;
								}
								break;
							}
						}
						if (suiji != 1 || (Panzi.panzi2[this.j] && Panzi.panzi2[t]))
						{
							break;
						}
						if (((this.j == 0 && t == 1) || (this.j == 1 && t == 0)) && (Panzi.panzi2[2] || Panzi.panzi2[3]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						if (((this.j == 0 && t == 2) || (this.j == 2 && t == 0)) && (Panzi.panzi2[1] || Panzi.panzi2[3]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						if (((this.j == 0 && t == 3) || (this.j == 3 && t == 0)) && (Panzi.panzi2[1] || Panzi.panzi2[2]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						if (((this.j == 1 && t == 2) || (this.j == 2 && t == 1)) && (Panzi.panzi2[0] || Panzi.panzi2[3]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						if (((this.j == 1 && t == 3) || (this.j == 3 && t == 1)) && (Panzi.panzi2[2] || Panzi.panzi2[0]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						if (((this.j == 3 && t == 2) || (this.j == 2 && t == 3)) && (Panzi.panzi2[1] || Panzi.panzi2[0]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						break;
					case 3:
						if (suiji == 0 && !Panzi.panzi3[this.j])
						{
							switch (this.j)
							{
							case 0:
								if (Panzi.panzi3[1] || Panzi.panzi3[2] || Panzi.panzi3[3])
								{
									jieshu();
									shiwu1 = BoolData.TYBB;
								}
								break;
							case 1:
								if (Panzi.panzi3[0] || Panzi.panzi3[2] || Panzi.panzi3[3])
								{
									jieshu();
									shiwu1 = BoolData.TYBB;
								}
								break;
							case 2:
								if (Panzi.panzi3[1] || Panzi.panzi3[0] || Panzi.panzi3[3])
								{
									jieshu();
									shiwu1 = BoolData.TYBB;
								}
								break;
							case 3:
								if (Panzi.panzi3[1] || Panzi.panzi3[2] || Panzi.panzi3[0])
								{
									jieshu();
									shiwu1 = BoolData.TYBB;
								}
								break;
							}
						}
						if (suiji != 1 || (Panzi.panzi3[this.j] && Panzi.panzi3[t]))
						{
							break;
						}
						if (((this.j == 0 && t == 1) || (this.j == 1 && t == 0)) && (Panzi.panzi3[2] || Panzi.panzi3[3]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						if (((this.j == 0 && t == 2) || (this.j == 2 && t == 0)) && (Panzi.panzi3[1] || Panzi.panzi3[3]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						if (((this.j == 0 && t == 3) || (this.j == 3 && t == 0)) && (Panzi.panzi3[1] || Panzi.panzi3[2]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						if (((this.j == 1 && t == 2) || (this.j == 2 && t == 1)) && (Panzi.panzi3[0] || Panzi.panzi3[3]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						if (((this.j == 1 && t == 3) || (this.j == 3 && t == 1)) && (Panzi.panzi3[2] || Panzi.panzi3[0]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						if (((this.j == 3 && t == 2) || (this.j == 2 && t == 3)) && (Panzi.panzi3[1] || Panzi.panzi3[0]))
						{
							jieshu();
							if (shiwu1 != null)
							{
								shiwu1 = BoolData.TYBB;
							}
							else
							{
								shiwu2 = BoolData.TYBB;
							}
						}
						break;
					}
					if (this.l <= 0f)
					{
						jieshu();
					}
					if ((BoolData.j >= 5 || BoolData.n >= 5) && iszhuanhuan && A != null)
					{
						this.l = 0f;
						Invoke("zhuansheng", 1f);
						iszhuanhuan = false;
						BoolData.OneBox = true;
						BoolData.TwoBox = true;
						BoolData.TherrBox = true;
						if (BoolData.jingbi > BoolData.jing)
						{
							BoolData.jing = BoolData.jingbi;
						}
						if (BoolData.timess > BoolData.shijian)
						{
							BoolData.shijian = BoolData.timess;
						}
						if (BoolData.timess == BoolData.shijian && BoolData.miaos > BoolData.miao)
						{
							BoolData.miao = BoolData.miaos;
						}
					}
				}
				if (isnobox)
				{
					A.GetComponent<BoxCollider>().enabled = false;
				}
				if (BoolData.IsCourse && suiji == 1 && BoolData.zhuanhaun)
				{
					ButtonScript.gongkaiUI[2].transform.GetChild(this.j).gameObject.SetActive(value: false);
					for (int l = 0; l < ButtonScript.gongkaiUI[2].transform.GetChild(this.j).childCount; l++)
					{
						ButtonScript.gongkaiUI[2].transform.GetChild(this.j).GetChild(l).gameObject.SetActive(value: false);
					}
					for (int m = 0; m < ButtonScript.gongkaiUI[2].transform.GetChild(t).childCount; m++)
					{
						ButtonScript.gongkaiUI[2].transform.GetChild(t).GetChild(m).gameObject.SetActive(value: false);
					}
					ButtonScript.gongkaiUI[2].transform.GetChild(t).gameObject.SetActive(value: true);
					ButtonScript.gongkaiUI[2].transform.GetChild(t).GetChild(0).gameObject.SetActive(value: true);
					BoolData.zhuanhaun = false;
				}
			}

			private void xiaoshi()
			{
				UnityEngine.Object.Destroy(shenying.gameObject);
			}

			private void OnTriggerEnter(Collider other)
			{
				if ((base.transform.tag == "人物1" || base.transform.tag == "人物2" || base.transform.tag == "人物3") && other.tag == "暂停盒子")
				{
					ismove = true;
					base.transform.tag = "人物";
				}
				if (!isend)
				{
					if (!zhuangtai && !ispengzhuang && other.tag == "地点" + i)
					{
						switch (i)
						{
						case 1:
							if (!ones)
							{
								ones = true;
							}
							break;
						case 2:
							if (!twos)
							{
								twos = true;
							}
							break;
						case 3:
							if (!threes)
							{
								threes = true;
							}
							break;
						}
						g = (int)l / 2;
						base.transform.tag = "人物";
						isnobox = true;
						peoplemove = false;
						ismove = true;
						Rotes = Quaternion.Euler(0f, 0f, 0f);
						A = other.gameObject;
						Invoke("bofang", 1.5f);
						zhuangtai = true;
						switch (i)
						{
						case 1:
							BoolData.OneBox = true;
							BoolData.OneWeizhi = true;
							base.transform.tag = "人物1";
							break;
						case 2:
							BoolData.TwoBox = true;
							BoolData.TowWeizhi = true;
							base.transform.tag = "人物2";
							break;
						case 3:
							BoolData.TherrBox = true;
							BoolData.ThreeWeizhi = true;
							base.transform.tag = "人物3";
							break;
						}
						if (BoolData.IsGame && BoolData.IsCaster)
						{
							if (Times.S >= 20)
							{
								gailv = UnityEngine.Random.Range(0, 100);
								if (gailv <= 50 - (BoolData.Change.T - 2) * 5)
								{
									suiji = 0;
								}
								else
								{
									suiji = 1;
								}
								if (BoolData.Change.T <= 12)
								{
									l -= BoolData.Change.T - 2;
								}
								else
								{
									l = 40f;
								}
								g = (int)l / 2;
								MonoBehaviour.print("地点" + i + ":" + l + ":" + g);
							}
							if (Times.S >= 10 && Times.S < 20)
							{
								suiji = UnityEngine.Random.Range(0, 2);
							}
							if (Times.S < 10)
							{
								suiji = 0;
							}
							h = suiji;
						}
						if (suiji == 0)
						{
							base.transform.GetChild(2).transform.GetChild(1).transform.gameObject.SetActive(value: true);
							base.transform.GetChild(2).transform.GetChild(1).transform.GetComponent<Image>().sprite = tu[j];
						}
						if (suiji == 1 && t != j)
						{
							base.transform.GetChild(2).transform.GetChild(2).transform.gameObject.SetActive(value: true);
							base.transform.GetChild(2).transform.GetChild(3).transform.gameObject.SetActive(value: true);
							base.transform.GetChild(2).transform.GetChild(2).transform.GetComponent<Image>().sprite = tu[j];
							base.transform.GetChild(2).transform.GetChild(3).transform.GetComponent<Image>().sprite = tu[t];
						}
					}
					if (other.tag == "消失")
					{
						isone = false;
						UnityEngine.Object.Destroy(base.transform.gameObject);
					}
				}
				if (base.transform.tag == "人物" && other.tag == "平底锅")
				{
					l = 0f;
				}
			}

			private void OnTriggerExit(Collider other)
			{
				if (other.tag == "总地点" && isnobox && BoolData.j < 5 && BoolData.n < 5)
				{
					switch (i)
					{
					case 1:
						BoolData.OneBox = false;
						ones = false;
						break;
					case 2:
						BoolData.TwoBox = false;
						twos = false;
						break;
					case 3:
						BoolData.TherrBox = false;
						threes = false;
						break;
					}
					isnobox = false;
					GameObject.FindWithTag("地点" + i).transform.GetComponent<BoxCollider>().enabled = true;
					A.GetComponent<BoxCollider>().enabled = true;
					isone = false;
				}
			}

			private void bofang()
			{
				base.transform.tag = "人物";
				donghua.SetBool("IsOrder", value: true);
				Invoke("Stand", 1f);
			}

			private void Stand()
			{
				if (BoolData.IsCourse)
				{
					ButtonScript.gongkaiUI[2].transform.GetChild(j).gameObject.SetActive(value: true);
					for (int i = 0; i < ButtonScript.gongkaiUI[2].transform.GetChild(j).childCount - 1; i++)
					{
						ButtonScript.gongkaiUI[2].transform.GetChild(j).GetChild(i).gameObject.SetActive(value: false);
					}
					ButtonScript.gongkaiUI[2].transform.GetChild(j).GetChild(0).gameObject.SetActive(value: true);
					ButtonScript.gongkaiUI[2].transform.GetChild(j).GetChild(0).GetChild(ButtonScript.gongkaiUI[2].transform.GetChild(j).GetChild(0).childCount - 1)
						.gameObject.SetActive(value: true);
					ButtonScript.isjiaocheng = true;
					BoolData.istimes = true;
					LIkai.fangxia = true;
					fanqie.istime = false;
					tingzhi = false;
					Times.istime = true;
				}
				if (BoolData.IsGame)
				{
					istime = true;
				}
				donghua.SetBool("IsOrder", value: false);
				donghua.SetBool("IsStanded", value: true);
			}

			private void Eat()
			{
				donghua.SetBool("IsEat", value: true);
				donghua.SetBool("IsFun", value: false);
				lian.CopyPropertiesFromMaterial(biaoqing[3]);
				Invoke("zhuansheng", 1f);
			}

			private void zhuansheng()
			{
				if (BoolData.j < 5 && BoolData.n < 5)
				{
					for (int i = 0; i < panzi.transform.childCount; i++)
					{
						UnityEngine.Object.Destroy(panzi.transform.GetChild(i).gameObject);
					}
					switch (this.i)
					{
					case 1:
						BoolData.end1 = true;
						break;
					case 2:
						BoolData.end2 = true;
						break;
					case 3:
						BoolData.end3 = true;
						break;
					}
				}
				ismove = false;
				if (istrue)
				{
					if (suiji == 1)
					{
						UnityEngine.Object.Destroy(shiwu1);
						UnityEngine.Object.Destroy(shiwu2);
						base.transform.GetChild(2).transform.GetChild(2).transform.gameObject.SetActive(value: false);
						base.transform.GetChild(2).transform.GetChild(3).transform.gameObject.SetActive(value: false);
					}
					if (suiji == 0)
					{
						UnityEngine.Object.Destroy(shiwu1);
						base.transform.GetChild(2).transform.GetChild(1).transform.gameObject.SetActive(value: false);
					}
					istrue = false;
				}
				if ((BoolData.IsCourse || BoolData.IsGame) && !BoolData.IsCaster)
				{
					BoolData.Course++;
					for (int j = 0; j <= 4; j++)
					{
						ButtonScript.gongkaiUI[2].transform.GetChild(j).gameObject.SetActive(value: false);
						ButtonScript.gongkaiUI[2].transform.GetChild(j).GetChild(ButtonScript.gongkaiUI[2].transform.GetChild(j).childCount - 1).gameObject.SetActive(value: true);
						BoolData.sx = 0;
					}
					MonoBehaviour.print(BoolData.Course);
				}
				for (int k = 0; k < 2; k++)
				{
					base.transform.GetComponentsInChildren<Collider>();
				}
				base.transform.tag = "路人";
				isend = true;
				Rotes = Quaternion.Euler(0f, 179f, 0f);
				istime = false;
				base.transform.GetChild(2).transform.GetChild(0).transform.GetComponent<Text>().text = " ";
				donghua.SetBool("IsEat", value: false);
				donghua.SetBool("IsNoFun", value: false);
				donghua.SetBool("IsStanded", value: false);
				donghua.SetBool("IsWalk", value: true);
				if (lian == biaoqing[3])
				{
					lian.CopyPropertiesFromMaterial(biaoqing[1]);
				}
				Invoke("zou", 1f);
			}

			private void zou()
			{
				ismove2 = true;
				Invoke("xuanzhuan2", 1f);
			}

			private void xuanzhuan2()
			{
				ismove2 = false;
				if (base.transform.parent.transform.parent.name == "R")
				{
					Rotes = Quaternion.Euler(0f, 90f, 0f);
				}
				if (base.transform.parent.transform.parent.name == "L")
				{
					Rotes = Quaternion.Euler(0f, -90f, 0f);
				}
				Invoke("move2", 1f);
			}

			private void move2()
			{
				peoplemove = true;
			}

			private void pengzhuang()
			{
				ispengzhuang = false;
				switch (i)
				{
				case 1:
					BoolData.OneWeizhi = false;
					break;
				case 2:
					BoolData.TowWeizhi = false;
					break;
				case 3:
					BoolData.ThreeWeizhi = false;
					break;
				}
			}

			private void jieshu()
			{
				if (iszhuanhuan)
				{
					for (int i = 0; i < panzi.transform.childCount; i++)
					{
						panzi.transform.GetChild(i).GetComponent<HVRGrabbable>().enabled = false;
					}
					istrue = true;
					Invoke("zhuansheng", 1f);
					BoolData.j++;
					lian.CopyPropertiesFromMaterial(biaoqing[2]);
					l = 0f;
					donghua.SetBool("IsStanded", value: false);
					donghua.SetBool("IsNoFun", value: true);
					MonoBehaviour.print("sdsdsdsdsdsd");
					iszhuanhuan = false;
				}
			}
		}
		public class people : MonoBehaviour
		{
			public GameObject[] renwu;

			public GameObject diren;

			private GameObject A;

			private int i;

			private int j;

			private float speed;

			private Quaternion Rotes;

			public bool games;

			public static bool ismove = true;

			private bool ismove2;

			private bool isluren;

			private void Start()
			{
			}

			private void Update()
			{
				if (base.transform.childCount == 1 && BoolData.AllIns && !isluren)
				{
					i = UnityEngine.Random.Range(0, renwu.Length - 1);
					A = UnityEngine.Object.Instantiate(renwu[i].gameObject, base.transform.position, base.transform.rotation, base.transform);
				}
				if (ButtonScript.isluren)
				{
					isluren = true;
				}
				if (isluren)
				{
					if (base.transform.parent.name != "LuRen" && A != null)
					{
						UnityEngine.Object.Destroy(A);
					}
					isluren = false;
				}
			}

			private void OnTriggerEnter(Collider other)
			{
				if (other.tag == "Player")
				{
					ismove = false;
					MonoBehaviour.print(other.transform.name);
				}
			}
		}
		public class Pingdiguo : MonoBehaviour
		{
			public GameObject BUT;

			public GameObject yinxiao;

			private GameObject shenying;

			private GameObject shenying2;

			private GameObject A;

			private GameObject AllProp;

			private bool ischange;

			private bool ischang;

			private void Start()
			{
				AllProp = GameObject.Find("AllProp");
			}

			private void Update()
			{
				if (!BoolData.isPDG && base.transform.name == "平底锅")
				{
					A = UnityEngine.Object.Instantiate(base.transform.gameObject, base.transform.position, base.transform.rotation);
					A.transform.GetComponent<MeshCollider>().enabled = true;
					A.transform.GetComponent<MeshRenderer>().enabled = true;
					A.GetComponent<Rigidbody>().isKinematic = false;
					A.GetComponent<Rigidbody>().useGravity = true;
					A.transform.GetComponent<HVRGrabbable>().enabled = true;
					A.transform.gameObject.isStatic = false;
					BoolData.DD = A;
					BoolData.isPDG = true;
					A.transform.SetParent(AllProp.transform);
				}
			}

			private void OnTriggerEnter(Collider other)
			{
				if (base.transform.tag == "平底锅" && other.tag == "番茄")
				{
					UnityEngine.Object.Destroy(other.gameObject);
					BoolData.jingbi++;
					shenying = UnityEngine.Object.Instantiate(yinxiao.transform.GetChild(2).gameObject, yinxiao.transform.GetChild(2).transform.position, yinxiao.transform.GetChild(2).transform.rotation, yinxiao.transform);
					shenying.SetActive(value: true);
					Invoke("xiaoshi", 1f);
				}
				if (other.tag == "人物" && base.transform.tag == "平底锅" && !ischange)
				{
					UnityEngine.Object.Destroy(base.transform.gameObject);
					MonoBehaviour.print("被打了");
					Invoke("change", 0.1f);
					ischange = true;
				}
				if (BoolData.IsGame && other.tag == "捣乱")
				{
					UnityEngine.Object.Destroy(base.transform.gameObject);
					UnityEngine.Object.Destroy(other.gameObject, 3f);
					shenying2 = UnityEngine.Object.Instantiate(yinxiao.transform.GetChild(3).gameObject, yinxiao.transform.GetChild(3).transform.position, yinxiao.transform.GetChild(3).transform.rotation, yinxiao.transform);
					shenying2.SetActive(value: true);
					daodi(other.gameObject);
					BoolData.jingbi += 5;
					BoolData.istrues = true;
					BoolData.IsCaster = true;
					Invoke("xiaoshiss", 1f);
					fanqie.istime = false;
				}
				if (BoolData.IsCourse && other.tag == "捣乱")
				{
					A = other.transform.parent.transform.gameObject;
					ButtonScript.gongkaiUI[2].transform.GetChild(4).gameObject.SetActive(value: false);
					UnityEngine.Object.Destroy(base.transform.gameObject);
					UnityEngine.Object.Destroy(other.gameObject, 3f);
					BoolData.jingbi = 0;
					BoolData.j = 0;
					Invoke("daos", 3f);
					BoolData.IsCourse = false;
					BUT.SetActive(value: true);
					shenying2 = UnityEngine.Object.Instantiate(yinxiao.transform.GetChild(3).gameObject, yinxiao.transform.GetChild(3).transform.position, yinxiao.transform.GetChild(3).transform.rotation, yinxiao.transform);
					shenying2.SetActive(value: true);
					Invoke("xiaoshiss", 1f);
					daodi(other.gameObject);
					fanqie.istime = false;
					ButtonScript.iscouse = false;
				}
			}

			private void xiaoshi()
			{
				UnityEngine.Object.Destroy(shenying.gameObject);
			}

			private void xiaoshiss()
			{
				UnityEngine.Object.Destroy(shenying2.gameObject);
			}

			private void OnTriggerExit(Collider other)
			{
				if (base.transform.tag == "平底锅" && base.transform.name != "OUT" && other.tag == "碰撞盒子1")
				{
					if (!ischang)
					{
						base.transform.parent = null;
						base.transform.name = "OUT";
						UnityEngine.Object.Destroy(base.transform.gameObject, 5f);
						base.transform.GetComponent<HVRGrabbable>().enabled = false;
						BoolData.isPDG = false;
						ischang = true;
					}
					Invoke("pengzhuang", 0.2f);
				}
			}

			private void OnCollisionEnter(Collision collision)
			{
				if (base.transform.tag == "平底锅" && collision.gameObject.tag == "内地面")
				{
					UnityEngine.Object.Destroy(base.transform.gameObject);
					BoolData.isPDG = false;
				}
			}

			private void pengzhuang()
			{
				ischang = false;
			}

			private void daodi(GameObject D)
			{
				if (BoolData.IsCourse)
				{
					D.transform.parent.transform.gameObject.SetActive(value: false);
				}
				D.transform.GetComponent<Animator>().enabled = false;
				D.transform.GetChild(0).GetChild(1).GetComponent<Rigidbody>()
					.isKinematic = false;
				D.transform.GetChild(0).GetChild(1).GetChild(0)
					.GetChild(0)
					.GetComponent<Rigidbody>()
					.isKinematic = false;
				D.transform.GetChild(0).GetChild(1).GetChild(0)
					.GetChild(0)
					.GetChild(0)
					.GetComponent<Rigidbody>()
					.isKinematic = false;
				D.transform.GetChild(0).GetChild(1).GetChild(0)
					.GetChild(1)
					.GetComponent<Rigidbody>()
					.isKinematic = false;
				D.transform.GetChild(0).GetChild(1).GetChild(0)
					.GetChild(1)
					.GetChild(0)
					.GetComponent<Rigidbody>()
					.isKinematic = false;
				D.transform.GetChild(0).GetChild(1).GetChild(0)
					.GetChild(2)
					.GetComponent<Rigidbody>()
					.isKinematic = false;
				D.transform.GetChild(0).GetChild(1).GetChild(0)
					.GetChild(2)
					.GetChild(0)
					.GetChild(0)
					.GetComponent<Rigidbody>()
					.isKinematic = false;
				D.transform.GetChild(0).GetChild(1).GetChild(0)
					.GetChild(2)
					.GetChild(0)
					.GetChild(1)
					.GetChild(0)
					.GetComponent<Rigidbody>()
					.isKinematic = false;
				D.transform.GetChild(0).GetChild(1).GetChild(0)
					.GetChild(2)
					.GetChild(0)
					.GetChild(1)
					.GetChild(0)
					.GetChild(0)
					.GetComponent<Rigidbody>()
					.isKinematic = false;
				D.transform.GetChild(0).GetChild(1).GetChild(0)
					.GetChild(2)
					.GetChild(0)
					.GetChild(2)
					.GetChild(0)
					.GetComponent<Rigidbody>()
					.isKinematic = false;
				D.transform.GetChild(0).GetChild(1).GetChild(0)
					.GetChild(2)
					.GetChild(0)
					.GetChild(2)
					.GetChild(0)
					.GetChild(0)
					.GetComponent<Rigidbody>()
					.isKinematic = false;
			}

			private void daos()
			{
				A.SetActive(value: false);
			}

			private void change()
			{
				ischange = false;
			}
		}
		public class Bowl : MonoBehaviour
		{
			private GameObject A;

			private GameObject AllProp;

			private GameObject B;

			private GameObject C;

			private BoxCollider AS;

			public GameObject[] bwols;

			private bool istrigger;

			private bool isgo;

			private int i;

			private int j;

			private void Start()
			{
				AllProp = GameObject.Find("AllProp");
			}

			private void Update()
			{
				if (BoolData.isIns)
				{
					A = UnityEngine.Object.Instantiate(base.transform.gameObject, base.transform.position, base.transform.rotation);
					A.GetComponent<MeshRenderer>().enabled = true;
					A.GetComponent<BoxCollider>().enabled = true;
					A.GetComponent<MeshCollider>().enabled = true;
					A.GetComponent<Rigidbody>().useGravity = true;
					A.GetComponent<Rigidbody>().isKinematic = false;
					A.transform.GetComponent<HVRGrabbable>().enabled = true;
					A.transform.GetComponent<DestoryGame>().IsDes = true;
					BoolData.AA = A;
					BoolData.isIns = false;
					A.transform.SetParent(AllProp.transform);
				}
				if (BoolData.isTrue)
				{
					A = UnityEngine.Object.Instantiate(bwols[0].transform.gameObject, bwols[0].transform.position, bwols[0].transform.rotation);
					A.GetComponent<MeshRenderer>().enabled = true;
					A.GetComponent<BoxCollider>().enabled = true;
					A.GetComponent<MeshCollider>().enabled = true;
					A.GetComponent<Rigidbody>().useGravity = true;
					A.GetComponent<Rigidbody>().isKinematic = false;
					A.transform.GetComponent<HVRGrabbable>().enabled = true;
					A.transform.GetComponent<DestoryGame>().IsDes = true;
					BoolData.BB = A;
					BoolData.isTrue = false;
					A.transform.SetParent(AllProp.transform);
				}
				if (BoolData.isTheer)
				{
					A = UnityEngine.Object.Instantiate(bwols[1].transform.gameObject, bwols[1].transform.position, bwols[1].transform.rotation);
					A.GetComponent<MeshRenderer>().enabled = true;
					A.GetComponent<BoxCollider>().enabled = true;
					A.GetComponent<MeshCollider>().enabled = true;
					A.GetComponent<Rigidbody>().useGravity = true;
					A.GetComponent<Rigidbody>().isKinematic = false;
					A.transform.GetComponent<HVRGrabbable>().enabled = true;
					A.transform.GetComponent<DestoryGame>().IsDes = true;
					BoolData.CC = A;
					BoolData.isTheer = false;
					A.transform.SetParent(AllProp.transform);
				}
				if (BoolData.AA == null)
				{
					BoolData.isIns = true;
				}
				if (BoolData.BB == null)
				{
					BoolData.isTrue = true;
				}
				if (BoolData.CC == null)
				{
					BoolData.isTheer = true;
				}
			}
		}
		public class Bowl2 : MonoBehaviour
		{
			public GameObject B;

			private GameObject A;

			private void Start()
			{
			}

			private void Update()
			{
				if (BoolData.isTrue)
				{
					A = UnityEngine.Object.Instantiate(base.transform.gameObject, B.transform.position, base.transform.rotation);
					A.GetComponent<MeshRenderer>().enabled = true;
					A.GetComponent<BoxCollider>().enabled = true;
					BoolData.isTrue = false;
				}
				if (BoolData.isTrue)
				{
					A = UnityEngine.Object.Instantiate(base.transform.gameObject, B.transform.position, base.transform.rotation);
					A.GetComponent<MeshRenderer>().enabled = true;
					A.GetComponent<BoxCollider>().enabled = true;
					BoolData.isTrue = false;
				}
			}
		}
		public class Bowl3 : MonoBehaviour
		{
			public GameObject C;

			private GameObject A;

			private void Update()
			{
				if (BoolData.isTheer)
				{
					A = UnityEngine.Object.Instantiate(base.transform.gameObject, C.transform.position, base.transform.rotation);
					A.GetComponent<MeshRenderer>().enabled = true;
					A.GetComponent<BoxCollider>().enabled = true;
					BoolData.isTheer = false;
				}
			}
		}
		public class Change : MonoBehaviour
		{
			private void Start()
			{
			}

			private void Update()
			{
			}

			private void OnTriggerEnter(Collider other)
			{
			}
		}
		public class ChopsticksScript : MonoBehaviour
		{
			private bool A;

			private bool B;

			private bool C;

			private bool A1;

			private bool B1;

			private bool C1;

			private int i;

			private bool zb;

			public static bool naqi;

			private bool istrigger;

			public static bool isagain;

			private GameObject As;

			private GameObject Bs;

			private GameObject Cs;

			private GameObject Ds;

			private GameObject Es;

			private void Start()
			{
			}

			private void Update()
			{
				if (zb)
				{
					i++;
				}
				HVRController leftController = HVRInputManager.Instance.LeftController;
				HVRController rightController = HVRInputManager.Instance.RightController;
				if (leftController.TriggerButtonState.Active || rightController.TriggerButtonState.Active)
				{
					istrigger = true;
				}
				if (!leftController.TriggerButtonState.Active || !rightController.TriggerButtonState.Active)
				{
					istrigger = false;
					isagain = false;
				}
				if (A && istrigger)
				{
					if (BoolData.IsCourse && (BoolData.Course == 3 || BoolData.Course == 4))
					{
						ButtonScript.gongkaiUI[2].transform.GetChild(3).GetChild(2).gameObject.SetActive(value: false);
						ButtonScript.gongkaiUI[2].transform.GetChild(3).GetChild(3).gameObject.SetActive(value: true);
					}
					As.transform.SetParent(base.transform);
					As.transform.GetComponent<Rigidbody>().useGravity = false;
					As.tag = "豆腐2";
					As.transform.GetComponent<MeshCollider>().isTrigger = true;
					As.transform.GetComponent<Rigidbody>().isKinematic = true;
					A = false;
					Ds = As;
					if (PotManage.s > 0)
					{
						PotManage.s--;
					}
				}
				if (B && istrigger)
				{
					if (BoolData.IsCourse && (BoolData.Course == 1 || BoolData.Course == 4))
					{
						ButtonScript.gongkaiUI[2].transform.GetChild(1).GetChild(2).gameObject.SetActive(value: false);
						ButtonScript.gongkaiUI[2].transform.GetChild(1).GetChild(3).gameObject.SetActive(value: true);
					}
					Bs.transform.SetParent(base.transform);
					Bs.transform.GetComponent<Rigidbody>().useGravity = false;
					Bs.tag = "香肠2";
					Bs.transform.GetComponent<MeshCollider>().isTrigger = true;
					Bs.transform.GetComponent<Rigidbody>().isKinematic = true;
					B = false;
					Ds = Bs;
					if (PotManage.s >= 0)
					{
						PotManage.s--;
					}
				}
				if (C && istrigger)
				{
					if (BoolData.IsCourse && (BoolData.Course == 2 || BoolData.Course == 4))
					{
						ButtonScript.gongkaiUI[2].transform.GetChild(2).GetChild(2).gameObject.SetActive(value: false);
						ButtonScript.gongkaiUI[2].transform.GetChild(2).GetChild(3).gameObject.SetActive(value: true);
					}
					Cs.transform.SetParent(base.transform);
					Cs.transform.GetComponent<Rigidbody>().useGravity = false;
					Cs.tag = "糖油粑粑2";
					Cs.transform.GetComponent<MeshCollider>().isTrigger = true;
					Cs.transform.GetComponent<Rigidbody>().isKinematic = true;
					C = false;
					Ds = Cs;
					if (PotManage.s > 0)
					{
						PotManage.s--;
					}
				}
				if (!istrigger)
				{
					Ds.transform.GetComponent<Rigidbody>().useGravity = true;
					Ds.transform.GetComponent<Rigidbody>().isKinematic = false;
					Ds.transform.GetComponent<MeshCollider>().isTrigger = false;
					Ds.transform.SetParent(null);
					naqi = false;
					zb = true;
					Ds = null;
				}
				if (A1 && istrigger && !naqi)
				{
					A1 = false;
					Ds.transform.SetParent(base.transform);
					Ds.transform.GetComponent<MeshCollider>().isTrigger = true;
					Ds.transform.GetComponent<Rigidbody>().useGravity = false;
					Ds.transform.GetComponent<Rigidbody>().isKinematic = true;
					naqi = true;
				}
				if (B1 && istrigger && !naqi)
				{
					Ds.transform.SetParent(base.transform);
					Ds.transform.GetComponent<MeshCollider>().isTrigger = true;
					Ds.transform.GetComponent<Rigidbody>().useGravity = false;
					B1 = false;
					Ds.transform.GetComponent<Rigidbody>().isKinematic = true;
					naqi = true;
				}
				if (C1 && istrigger && !naqi)
				{
					C1 = false;
					Ds.transform.SetParent(base.transform);
					Ds.transform.GetComponent<MeshCollider>().isTrigger = true;
					Ds.transform.GetComponent<Rigidbody>().useGravity = false;
					Ds.transform.GetComponent<Rigidbody>().isKinematic = true;
					naqi = true;
				}
			}

			private void OnCollisionEnter(Collision other)
			{
				if (!isagain)
				{
					if ((other.transform.tag == "豆腐2" || other.transform.tag == "香肠2" || other.transform.tag == "糖油粑粑2") && !A1)
					{
						A1 = true;
						Ds = other.gameObject;
					}
					if ((other.transform.tag == "豆腐3" || other.transform.tag == "香肠3" || other.transform.tag == "糖油粑粑3") && !A1)
					{
						A1 = true;
						Ds = other.gameObject;
					}
				}
			}

			private void OnCollisionStay(Collision other)
			{
				if (!isagain && (other.transform.tag == "豆腐2" || other.transform.tag == "香肠2" || other.transform.tag == "糖油粑粑2") && !A1)
				{
					A1 = true;
					Ds = other.gameObject;
				}
			}

			private void OnCollisionExit(Collision other)
			{
				if (!isagain)
				{
					switch (other.gameObject.tag)
					{
					case "油炸臭豆腐":
						if (A)
						{
							A = false;
						}
						break;
					case "炸香肠":
						if (B)
						{
							B = false;
						}
						break;
					case "油炸糖油粑粑":
						if (C)
						{
							C = false;
						}
						break;
					}
				}
				if (istrigger)
				{
					return;
				}
				switch (other.gameObject.name)
				{
				case "豆腐":
					if (A1)
					{
						A1 = false;
					}
					break;
				case "红肠":
					if (B1)
					{
						B1 = false;
					}
					break;
				case "糍粑":
					if (C1)
					{
						C1 = false;
						Es = other.gameObject;
					}
					break;
				}
			}
		}
		public class AddManage : MonoBehaviour
		{
			private MeshCollider A;

			private GameObject childs;

			private Vector3[] pos;

			private void Start()
			{
				pos = new Vector3[8];
				if (base.transform.childCount != 0)
				{
					childs = base.transform.GetChild(8).gameObject;
				}
			}

			private void Update()
			{
			}
		}
		public class BoolData : MonoBehaviour
		{
			public class Boos
			{
				public static bool istexiao;

				public static bool isspeed;

				public static int PlayerSpeed = 0;

				public static bool iszhunbei;

				public static bool isatack;

				public static bool isShangHai;

				public static float lefts;

				public static bool shit = true;

				public static bool isfirstBoos;

				public static bool NewBoos;

				public static bool atackedss;

				public static bool shibai;

				public static int times = 0;
			}

			public class Change
			{
				public static bool isgame;

				public static int T;

				public static int M;

				public static bool ists;

				public static bool ischange;
			}

			public static bool PaiHB;

			public static bool Ends;

			public static float Hight = 0f;

			public static bool isIns = true;

			public static bool isTrue = true;

			public static bool isTheer = true;

			public static bool iskuaizi;

			public static bool ismians;

			public static bool isones = false;

			public static bool isture = false;

			public static bool isThreed = false;

			public static bool PHB;

			public static bool AllIns = true;

			public static GameObject AA;

			public static GameObject BB;

			public static GameObject CC;

			public static GameObject DD;

			public static GameObject CDF;

			public static GameObject TYBB;

			public static GameObject MIAN;

			public static GameObject XC;

			public static bool end1;

			public static bool end2;

			public static bool end3;

			public static int i = 0;

			public static int j = 0;

			public static int n = 0;

			public static int jingbi;

			public static Text CANVA;

			public static bool Again;

			public static bool fanqie;

			public static bool isMischief;

			public static bool ismat = true;

			public static bool isPDG;

			public static bool isGuoPan = true;

			public static bool isyoushao;

			public static bool isshaozi;

			public static bool ismian;

			public static bool isshangchuan;

			public static bool isone;

			public static bool OneSkill;

			public static bool OneWeizhi;

			public static bool TowWeizhi;

			public static bool ThreeWeizhi;

			public static bool isyi;

			public static bool iser;

			public static bool issan;

			public static bool Ischeshi;

			public static bool IsGame;

			public static bool IsCourse;

			public static bool IsCaster;

			public static int Course = 0;

			public static bool istrues;

			public static bool ischuxian;

			public static bool isStop;

			public static GameObject ASA;

			public static int sx = 0;

			public static Text endtime;

			public static int jing = 0;

			public static int shijian = 0;

			public static int miao = 0;

			public static bool shengli;

			public static bool OneBox;

			public static bool TwoBox;

			public static bool TherrBox;

			public static bool istimes;

			public static int timess;

			public static int miaos;

			public static bool isphb;

			public static float juli;

			public static bool zhuanhaun;
		}
		public class playmoves : MonoBehaviour
		{
			public GameObject camer;

			private void Start()
			{
			}

			private void Update()
			{
			}
		}
		public class DestoryGame : MonoBehaviour
		{
			public bool IsDes;

			private void Start()
			{
			}

			private void Update()
			{
				if (!base.transform.GetComponent<HVRGrabbable>().enabled && IsDes)
				{
					UnityEngine.Object.Destroy(base.transform.gameObject, 5f);
				}
			}
		}
		public class FinishedPlateScript : MonoBehaviour
		{
			private GameObject A;

			private GameObject B;

			private GameObject C;

			private GameObject D;

			private string ii;

			private bool changes;

			private bool gaibian;

			private bool ischangess;

			private int i;

			private void Start()
			{
			}

			private void Update()
			{
				for (int i = 0; i < base.transform.childCount - 1; i++)
				{
					if (base.transform.GetChild(i).gameObject.activeSelf)
					{
						D = base.transform.GetChild(i).gameObject;
						ischangess = true;
					}
				}
				if (ischangess && !D.activeSelf)
				{
					changes = false;
					ischangess = false;
				}
			}

			private void OnTriggerEnter(Collider other)
			{
				switch (other.tag)
				{
				case "成品臭豆腐":
					if (!gaibian)
					{
						A = BoolData.AA;
						B = BoolData.BB;
						C = BoolData.CC;
						ii = A.transform.name;
						UnityEngine.Object.Destroy(other.gameObject);
						if (changes)
						{
							base.transform.GetChild(7).gameObject.SetActive(value: true);
							changes = false;
						}
						else
						{
							base.transform.GetChild(3).gameObject.SetActive(value: true);
							changes = true;
						}
						switch (other.transform.GetChild(0).tag)
						{
						case "碗":
							BoolData.isIns = true;
							break;
						case "大碗":
							BoolData.isTrue = true;
							break;
						case "小碗":
							BoolData.isTheer = true;
							break;
						}
						gaibian = true;
						Invoke("xiaoshi", 0.1f);
					}
					break;
				case "成品糖油粑粑":
					if (!gaibian)
					{
						UnityEngine.Object.Destroy(other.gameObject);
						if (changes)
						{
							base.transform.GetChild(6).gameObject.SetActive(value: true);
							changes = false;
						}
						else
						{
							base.transform.GetChild(2).gameObject.SetActive(value: true);
							changes = true;
						}
						switch (other.transform.GetChild(0).tag)
						{
						case "碗":
							BoolData.isIns = true;
							break;
						case "大碗":
							BoolData.isTrue = true;
							break;
						case "小碗":
							BoolData.isTheer = true;
							break;
						}
						Invoke("xiaoshi", 0.1f);
						gaibian = true;
					}
					break;
				case "成品炸香肠":
					if (!gaibian)
					{
						UnityEngine.Object.Destroy(other.gameObject);
						if (changes)
						{
							base.transform.GetChild(5).gameObject.SetActive(value: true);
							changes = false;
						}
						else
						{
							base.transform.GetChild(1).gameObject.SetActive(value: true);
							changes = true;
						}
						switch (other.transform.GetChild(0).tag)
						{
						case "碗":
							BoolData.isIns = true;
							break;
						case "大碗":
							BoolData.isTrue = true;
							break;
						case "小碗":
							BoolData.isTheer = true;
							break;
						}
						Invoke("xiaoshi", 0.1f);
						gaibian = true;
					}
					break;
				case "成品拌面":
					if (!gaibian)
					{
						UnityEngine.Object.Destroy(other.gameObject);
						if (changes)
						{
							base.transform.GetChild(4).gameObject.SetActive(value: true);
							changes = false;
						}
						else
						{
							base.transform.GetChild(0).gameObject.SetActive(value: true);
							changes = true;
						}
						switch (other.transform.GetChild(0).tag)
						{
						case "碗":
							BoolData.isIns = true;
							break;
						case "大碗":
							BoolData.isTrue = true;
							break;
						case "小碗":
							BoolData.isTheer = true;
							break;
						}
						Invoke("xiaoshi", 0.1f);
						gaibian = true;
					}
					break;
				}
			}

			private void xiaoshi()
			{
				gaibian = false;
			}
		}
		public class Doufu : MonoBehaviour
		{
			public static bool ischange;

			public GameObject chengping;

			public GameObject baozha;

			public GameObject tishi;

			private GameObject A;

			private GameObject B;

			private float shuzi = 1f;

			private bool ischanges;

			private bool daoshu;

			private bool ishu;

			private bool iszha;

			private int i;

			private int j;

			private int s;

			private void Update()
			{
				if (iszha)
				{
					i++;
				}
				if (base.transform.parent == null && !iszha)
				{
					j++;
				}
				if (base.transform.parent != null)
				{
					j = 0;
				}
				if (i >= 500)
				{
					change();
				}
				if (j > 2000 || i > 2500)
				{
					baozhas();
				}
				if (daoshu && iszha)
				{
					shuzi -= 0.01f;
					B.transform.GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, shuzi);
					MonoBehaviour.print(shuzi);
				}
			}

			private void change()
			{
				base.transform.GetComponent<MeshRenderer>().material = chengping.transform.GetComponent<MeshRenderer>().material;
				base.transform.tag = "豆腐2";
			}

			private void OnTriggerEnter(Collider other)
			{
				if (other.name == "触发器")
				{
					iszha = true;
					if (!ischanges)
					{
						ischanges = true;
						Invoke("zhuanhuan", 0.1f);
					}
					j = 0;
				}
			}

			private void hu()
			{
				if (!ishu)
				{
					base.transform.GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f);
					Invoke("baozhas", 5f);
				}
			}

			private void baozhas()
			{
				if (iszha)
				{
					B = UnityEngine.Object.Instantiate(tishi.gameObject, base.transform.position + new Vector3(0f, 0.1f, 0f), base.transform.rotation);
					B.SetActive(value: true);
					UnityEngine.Object.Destroy(B.gameObject, 5f);
					PotManage.s--;
				}
				UnityEngine.Object.Destroy(base.transform.gameObject);
				A = UnityEngine.Object.Instantiate(baozha.gameObject, base.transform.position + new Vector3(0f, 0.1f, 0f), base.transform.rotation);
				A.SetActive(value: true);
				UnityEngine.Object.Destroy(A.gameObject, 5f);
				daoshu = true;
			}

			private void OnTriggerExit(Collider other)
			{
				if (other.name == "触发器")
				{
					iszha = false;
					ishu = true;
					if (!ischanges)
					{
						ischanges = true;
						Invoke("zhuanhuan", 0.1f);
					}
				}
			}

			private void zhuanhuan()
			{
				ischanges = false;
			}
		}
		public class FoodBox : MonoBehaviour
		{
			private void Start()
			{
			}

			private void Update()
			{
				base.transform.GetComponent<BoxCollider>().enabled = true;
			}
		}
		public class FoodEnd : MonoBehaviour
		{
			private GameObject Player;

			private float shuzi = 1f;

			private void Start()
			{
				Player = GameObject.FindWithTag("Player").gameObject;
			}

			private void Update()
			{
				shuzi -= 0.01f;
				base.transform.GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, shuzi);
				base.transform.GetChild(0).LookAt(Player.transform);
				base.transform.position += new Vector3(0f, 0.001f, 0f);
			}
		}
		public class TangYouBaBa : MonoBehaviour
		{
			public static bool ischange;

			public GameObject chengping;

			public GameObject baozha;

			public GameObject tishi;

			private GameObject A;

			private GameObject B;

			private float shuzi = 1f;

			private bool ischanges;

			private bool daoshu;

			private bool ishu;

			private bool iszha;

			private int i;

			private int j;

			private void Update()
			{
				if (iszha)
				{
					i++;
				}
				if (base.transform.parent == null && !iszha)
				{
					j++;
				}
				if (base.transform.parent != null)
				{
					j = 0;
				}
				if (i >= 500)
				{
					change();
				}
				if (j > 2000 || i > 2500)
				{
					baozhas();
				}
				if (daoshu && iszha)
				{
					shuzi -= 0.01f;
					B.transform.GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, shuzi);
					MonoBehaviour.print(shuzi);
				}
			}

			private void change()
			{
				base.transform.GetComponent<MeshRenderer>().material = chengping.transform.GetComponent<MeshRenderer>().material;
				base.transform.tag = "糖油粑粑2";
			}

			private void OnTriggerEnter(Collider other)
			{
				if (other.name == "触发器")
				{
					iszha = true;
					if (!ischanges)
					{
						ischanges = true;
						Invoke("zhuanhuan", 0.1f);
					}
					j = 0;
				}
			}

			private void hu()
			{
				if (!ishu)
				{
					base.transform.GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f);
					Invoke("baozhas", 5f);
				}
			}

			private void baozhas()
			{
				if (iszha)
				{
					B = UnityEngine.Object.Instantiate(tishi.gameObject, base.transform.position + new Vector3(0f, 0.1f, 0f), base.transform.rotation);
					B.SetActive(value: true);
					UnityEngine.Object.Destroy(B.gameObject, 5f);
					PotManage.s--;
				}
				UnityEngine.Object.Destroy(base.transform.gameObject);
				A = UnityEngine.Object.Instantiate(baozha.gameObject, base.transform.position + new Vector3(0f, 0.1f, 0f), base.transform.rotation);
				A.SetActive(value: true);
				UnityEngine.Object.Destroy(A.gameObject, 5f);
				daoshu = true;
			}

			private void OnTriggerExit(Collider other)
			{
				if (other.name == "触发器")
				{
					iszha = false;
					ishu = true;
					if (!ischanges)
					{
						ischanges = true;
						Invoke("zhuanhuan", 0.1f);
					}
				}
			}

			private void zhuanhuan()
			{
				ischanges = false;
			}
		}
		public class XiangChang : MonoBehaviour
		{
			public static bool ischange;

			public GameObject chengping;

			public GameObject baozha;

			public GameObject tishi;

			private GameObject A;

			private GameObject B;

			private float shuzi = 1f;

			private bool ischanges;

			private bool daoshu;

			private bool ishu;

			private bool iszha;

			private int i;

			private int j;

			private void Update()
			{
				if (iszha)
				{
					i++;
				}
				if (base.transform.parent == null && !iszha)
				{
					j++;
				}
				if (base.transform.parent != null)
				{
					j = 0;
				}
				if (i >= 500)
				{
					change();
				}
				if (j > 2000 || i > 2500)
				{
					baozhas();
				}
				if (daoshu && iszha)
				{
					shuzi -= 0.01f;
					B.transform.GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, shuzi);
					MonoBehaviour.print(shuzi);
				}
			}

			private void change()
			{
				base.transform.GetComponent<MeshRenderer>().enabled = false;
				base.transform.GetChild(0).transform.gameObject.SetActive(value: true);
				base.transform.tag = "香肠2";
			}

			private void OnTriggerEnter(Collider other)
			{
				if (other.name == "触发器")
				{
					iszha = true;
					if (!ischanges)
					{
						ischanges = true;
						Invoke("zhuanhuan", 0.1f);
					}
					j = 0;
				}
			}

			private void hu()
			{
				if (!ishu)
				{
					base.transform.GetComponent<MeshRenderer>().material.color = new Color(0f, 0f, 0f);
					Invoke("baozhas", 5f);
				}
			}

			private void baozhas()
			{
				if (iszha)
				{
					B = UnityEngine.Object.Instantiate(tishi.gameObject, base.transform.position + new Vector3(0f, 0.1f, 0f), base.transform.rotation);
					B.SetActive(value: true);
					UnityEngine.Object.Destroy(B.gameObject, 5f);
					PotManage.s--;
				}
				UnityEngine.Object.Destroy(base.transform.gameObject);
				A = UnityEngine.Object.Instantiate(baozha.gameObject, base.transform.position + new Vector3(0f, 0.1f, 0f), base.transform.rotation);
				A.SetActive(value: true);
				UnityEngine.Object.Destroy(A.gameObject, 5f);
				daoshu = true;
			}

			private void OnTriggerExit(Collider other)
			{
				if (other.name == "触发器")
				{
					iszha = false;
					ishu = true;
					if (!ischanges)
					{
						ischanges = true;
						Invoke("zhuanhuan", 0.1f);
					}
				}
			}

			private void zhuanhuan()
			{
				ischanges = false;
			}
		}
		public class HeadScript : MonoBehaviour
		{
			public GameObject yingxiao;

			private GameObject shenying;

			private GameObject A;

			private void Start()
			{
			}

			private void Update()
			{
			}

			private void OnTriggerExit(Collider other)
			{
				if (other.tag == "人物盒子")
				{
					base.transform.GetChild(5).gameObject.SetActive(value: true);
				}
			}

			private void OnTriggerEnter(Collider other)
			{
				if (other.tag == "人物盒子")
				{
					base.transform.GetChild(5).gameObject.SetActive(value: false);
				}
				if (other.tag == "番茄")
				{
					shenying = UnityEngine.Object.Instantiate(yingxiao.transform.GetChild(4).gameObject, yingxiao.transform.GetChild(4).transform.position, yingxiao.transform.GetChild(4).transform.rotation, yingxiao.transform);
					shenying.SetActive(value: true);
					Invoke("xiaoshis", 0.5f);
					UnityEngine.Object.Destroy(other.gameObject);
					A = UnityEngine.Object.Instantiate(base.transform.GetChild(4).gameObject, base.transform.GetChild(4).transform.position, base.transform.GetChild(4).transform.rotation, base.transform);
					A.SetActive(value: true);
					Invoke("xiaoshi", 4f);
				}
				if (other.tag == "传送")
				{
					SceneManager.LoadScene(1);
				}
			}

			private void xiaoshi()
			{
				UnityEngine.Object.Destroy(A);
			}

			private void xiaoshis()
			{
				UnityEngine.Object.Destroy(shenying.gameObject);
			}
		}
		public class ChildPos : MonoBehaviour
		{
			private void Start()
			{
			}

			private void Update()
			{
				base.transform.position = Vector3.zero;
			}
		}
		public class ToolAndFoodPos : MonoBehaviour
		{
			private Vector3 Pos;

			private Quaternion Rote;

			private void Start()
			{
				Pos = base.transform.position;
				Rote = base.transform.rotation;
			}

			private void Update()
			{
				if (BoolData.Again)
				{
					base.transform.position = Pos;
					base.transform.rotation = Rote;
					BoolData.Again = false;
				}
			}
		}
		public class PotManage : MonoBehaviour
		{
			public GameObject[] chengping;

			public GameObject yingxiao;

			private GameObject A;

			private GameObject B;

			private GameObject C;

			private bool pengzhuang;

			public static int g;

			public static int s;

			private bool istrgger;

			private int jishu;

			private void Start()
			{
			}

			private void Update()
			{
				MonoBehaviour.print("进入数量：" + s);
				istrgger = TiggerManage.istrigger;
				if (s > 0)
				{
					yingxiao.SetActive(value: true);
				}
				else
				{
					yingxiao.SetActive(value: false);
				}
				if (s < 0)
				{
					s = 0;
				}
			}

			private void OnTriggerEnter(Collider other)
			{
				switch (other.tag)
				{
				case "臭豆腐块":
					if (BoolData.IsCourse && (BoolData.Course == 3 || BoolData.Course == 4))
					{
						jishu++;
						if (jishu < 3)
						{
							ButtonScript.gongkaiUI[2].transform.GetChild(3).GetChild(1).gameObject.SetActive(value: false);
							ButtonScript.gongkaiUI[2].transform.GetChild(3).GetChild(0).gameObject.SetActive(value: true);
						}
						else
						{
							ButtonScript.gongkaiUI[2].transform.GetChild(3).GetChild(0).gameObject.SetActive(value: false);
							ButtonScript.gongkaiUI[2].transform.GetChild(3).GetChild(1).gameObject.SetActive(value: false);
							ButtonScript.gongkaiUI[2].transform.GetChild(3).GetChild(2).gameObject.SetActive(value: true);
							jishu = 0;
						}
					}
					other.transform.GetComponent<Rigidbody>().useGravity = true;
					other.transform.GetComponent<MeshCollider>().isTrigger = false;
					other.transform.parent = null;
					TiggerManage.istrigger = false;
					TiggerManage.IsPeng = false;
					TiggerManage.ishand = false;
					TiggerManage.Instans.transform.GetComponent<MeshRenderer>().enabled = true;
					if (!pengzhuang)
					{
						s++;
						pengzhuang = true;
					}
					Invoke("xiaoshi", 0.1f);
					break;
				case "香肠条":
					if (BoolData.IsCourse && (BoolData.Course == 1 || BoolData.Course == 4))
					{
						ButtonScript.gongkaiUI[2].transform.GetChild(1).GetChild(1).gameObject.SetActive(value: false);
						ButtonScript.gongkaiUI[2].transform.GetChild(1).GetChild(2).gameObject.SetActive(value: true);
					}
					other.transform.GetComponent<Rigidbody>().useGravity = true;
					other.transform.GetComponent<MeshCollider>().isTrigger = false;
					other.transform.parent = null;
					TiggerManage.istrigger = false;
					TiggerManage.IsPeng = false;
					TiggerManage.ishand = false;
					TiggerManage.Instans.transform.GetComponent<MeshRenderer>().enabled = true;
					if (!pengzhuang)
					{
						s++;
						pengzhuang = true;
					}
					Invoke("xiaoshi", 0.1f);
					break;
				case "糖油粑粑1":
					if (BoolData.IsCourse && (BoolData.Course == 2 || BoolData.Course == 4))
					{
						jishu++;
						if (jishu < 3)
						{
							ButtonScript.gongkaiUI[2].transform.GetChild(2).GetChild(1).gameObject.SetActive(value: false);
							ButtonScript.gongkaiUI[2].transform.GetChild(2).GetChild(0).gameObject.SetActive(value: true);
						}
						else
						{
							ButtonScript.gongkaiUI[2].transform.GetChild(2).GetChild(0).gameObject.SetActive(value: false);
							ButtonScript.gongkaiUI[2].transform.GetChild(2).GetChild(1).gameObject.SetActive(value: false);
							ButtonScript.gongkaiUI[2].transform.GetChild(2).GetChild(2).gameObject.SetActive(value: true);
							jishu = 0;
						}
					}
					other.transform.GetComponent<Rigidbody>().useGravity = true;
					other.transform.GetComponent<MeshCollider>().isTrigger = false;
					other.transform.parent = null;
					TiggerManage.istrigger = false;
					TiggerManage.IsPeng = false;
					TiggerManage.ishand = false;
					TiggerManage.Instans.transform.GetComponent<MeshRenderer>().enabled = true;
					if (!pengzhuang)
					{
						s++;
						pengzhuang = true;
					}
					Invoke("xiaoshi", 0.1f);
					break;
				case "豆腐3":
					if (BoolData.IsCourse && (BoolData.Course == 3 || BoolData.Course == 4))
					{
						jishu++;
						if (jishu < 3)
						{
							ButtonScript.gongkaiUI[2].transform.GetChild(3).GetChild(1).gameObject.SetActive(value: false);
							ButtonScript.gongkaiUI[2].transform.GetChild(3).GetChild(0).gameObject.SetActive(value: true);
						}
						else
						{
							ButtonScript.gongkaiUI[2].transform.GetChild(3).GetChild(0).gameObject.SetActive(value: false);
							ButtonScript.gongkaiUI[2].transform.GetChild(3).GetChild(1).gameObject.SetActive(value: false);
							ButtonScript.gongkaiUI[2].transform.GetChild(3).GetChild(2).gameObject.SetActive(value: true);
							jishu = 0;
						}
					}
					other.transform.GetComponent<HVRGrabbable>().enabled = false;
					other.transform.GetComponent<Rigidbody>().useGravity = true;
					other.transform.GetComponent<Rigidbody>().isKinematic = false;
					other.transform.parent = null;
					kuaizijiaoben.zhuangtai = false;
					if (!pengzhuang)
					{
						s++;
						pengzhuang = true;
					}
					Invoke("xiaoshi", 0.1f);
					break;
				case "香肠3":
					if (BoolData.IsCourse && (BoolData.Course == 1 || BoolData.Course == 4))
					{
						ButtonScript.gongkaiUI[2].transform.GetChild(1).GetChild(1).gameObject.SetActive(value: false);
						ButtonScript.gongkaiUI[2].transform.GetChild(1).GetChild(2).gameObject.SetActive(value: true);
					}
					other.transform.GetComponent<HVRGrabbable>().enabled = false;
					other.transform.GetComponent<Rigidbody>().useGravity = true;
					other.transform.GetComponent<Rigidbody>().isKinematic = false;
					other.transform.parent = null;
					kuaizijiaoben.zhuangtai = false;
					if (!pengzhuang)
					{
						s++;
						pengzhuang = true;
					}
					Invoke("xiaoshi", 0.1f);
					break;
				case "糖油粑粑3":
					if (BoolData.IsCourse && (BoolData.Course == 2 || BoolData.Course == 4))
					{
						jishu++;
						if (jishu < 3)
						{
							ButtonScript.gongkaiUI[2].transform.GetChild(2).GetChild(1).gameObject.SetActive(value: false);
							ButtonScript.gongkaiUI[2].transform.GetChild(2).GetChild(0).gameObject.SetActive(value: true);
						}
						else
						{
							ButtonScript.gongkaiUI[2].transform.GetChild(2).GetChild(0).gameObject.SetActive(value: false);
							ButtonScript.gongkaiUI[2].transform.GetChild(2).GetChild(1).gameObject.SetActive(value: false);
							ButtonScript.gongkaiUI[2].transform.GetChild(2).GetChild(2).gameObject.SetActive(value: true);
							jishu = 0;
						}
					}
					other.transform.GetComponent<HVRGrabbable>().enabled = false;
					other.transform.GetComponent<Rigidbody>().useGravity = true;
					other.transform.GetComponent<Rigidbody>().isKinematic = false;
					other.transform.parent = null;
					kuaizijiaoben.zhuangtai = false;
					if (!pengzhuang)
					{
						s++;
						pengzhuang = true;
					}
					Invoke("xiaoshi", 0.1f);
					break;
				case "":
					other.transform.GetComponent<Rigidbody>().useGravity = true;
					other.transform.parent = null;
					break;
				}
			}

			private void OnTriggerExit(Collider other)
			{
				if (!pengzhuang && other.name != "出锅")
				{
					if (other.tag == "豆腐2" || other.tag == "香肠2" || other.tag == "糖油粑粑2")
					{
						s--;
					}
					other.name = "出锅";
					pengzhuang = true;
					Invoke("xiaoshi", 0.5f);
				}
			}

			private void cdfWC()
			{
				A.tag = "油炸臭豆腐";
				A.transform.GetComponent<MeshRenderer>().material = chengping[0].transform.GetComponent<MeshRenderer>().material;
			}

			private void XCWC()
			{
				B.tag = "炸香肠";
				B.transform.GetComponent<MeshRenderer>().material = chengping[2].transform.GetComponent<MeshRenderer>().material;
			}

			private void TYBBWC()
			{
				C.tag = "油炸糖油粑粑";
				C.transform.GetComponent<MeshRenderer>().material = chengping[3].transform.GetComponent<MeshRenderer>().material;
			}

			private void xiaoshi()
			{
				pengzhuang = false;
			}
		}
		public class ShaoZi : MonoBehaviour
		{
			public GameObject kuaizi;

			public GameObject mian;

			private GameObject A;

			private GameObject AllProp;

			private bool ischang;

			public static GameObject C;

			private void Start()
			{
				AllProp = GameObject.Find("AllProp");
			}

			private void Update()
			{
				_ = HVRInputManager.Instance.LeftController;
				_ = HVRInputManager.Instance.RightController;
				C = mian;
				if (!BoolData.isshaozi && base.transform.name == "勺子")
				{
					A = UnityEngine.Object.Instantiate(base.transform.gameObject, base.transform.position, base.transform.rotation);
					A.transform.GetComponent<MeshCollider>().enabled = true;
					A.transform.GetComponent<MeshRenderer>().enabled = true;
					A.transform.GetComponent<Rigidbody>().isKinematic = false;
					A.transform.GetComponent<Rigidbody>().useGravity = true;
					A.transform.GetComponent<HVRGrabbable>().enabled = true;
					A.transform.gameObject.isStatic = false;
					A.transform.GetChild(0).gameObject.SetActive(value: true);
					BoolData.DD = A;
					BoolData.isshaozi = true;
					A.transform.SetParent(AllProp.transform);
				}
				if (!BoolData.iskuaizi && kuaizi.transform.name == "筷子")
				{
					A = UnityEngine.Object.Instantiate(kuaizi.transform.gameObject, kuaizi.transform.position, kuaizi.transform.rotation);
					A.transform.GetComponent<MeshCollider>().enabled = true;
					A.transform.GetChild(0).GetComponent<MeshCollider>().enabled = true;
					A.transform.GetComponent<MeshRenderer>().enabled = true;
					A.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
					A.transform.GetComponent<Rigidbody>().isKinematic = false;
					A.transform.GetComponent<Rigidbody>().useGravity = true;
					A.transform.GetComponent<HVRGrabbable>().enabled = true;
					BoolData.DD = A;
					BoolData.iskuaizi = true;
					A.transform.SetParent(AllProp.transform);
				}
			}

			private void OnTriggerExit(Collider other)
			{
				if (other.tag == "碰撞盒子" && base.transform.name != "OUT")
				{
					base.transform.name = "OUT";
					base.transform.parent = null;
					if (!ischang)
					{
						UnityEngine.Object.Destroy(base.transform.gameObject, 5f);
						base.transform.GetComponent<HVRGrabbable>().enabled = false;
						BoolData.isshaozi = false;
						ischang = true;
					}
					Invoke("pengzhuang", 0.1f);
				}
			}

			private void OnCollisionEnter(Collision collision)
			{
				if (collision.gameObject.tag == "内地面")
				{
					UnityEngine.Object.Destroy(base.transform.gameObject);
					BoolData.isshaozi = false;
				}
			}

			private void pengzhuang()
			{
				ischang = false;
			}
		}
		public class LIkai : MonoBehaviour
		{
			public GameObject shenying;

			private bool istrigger;

			private bool isnull;

			private int i;

			private int j;

			private int n;

			private bool isgo;

			private bool istig;

			private bool isdoufu;

			private bool istangyoubb;

			private bool ismian;

			private bool istangyou;

			public bool isones;

			public static bool fangxia;

			private GameObject A;

			private bool ischang;

			private void Start()
			{
			}

			private void Update()
			{
				if (base.transform.tag == "装盘面" || base.transform.tag == "成品拌面")
				{
					ismian = true;
				}
				for (int i = 0; i < n; i++)
				{
					if (n <= 3)
					{
						if (isdoufu)
						{
							base.transform.GetChild(0).transform.GetChild(i).gameObject.SetActive(value: true);
						}
						else
						{
							base.transform.GetChild(3).transform.GetChild(i).gameObject.SetActive(value: true);
						}
					}
				}
				if (n <= 2 || isgo)
				{
					return;
				}
				if (isdoufu)
				{
					if (BoolData.IsCourse && (BoolData.Course == 3 || BoolData.Course == 4))
					{
						ButtonScript.gongkaiUI[2].transform.GetChild(3).GetChild(2).gameObject.SetActive(value: false);
						ButtonScript.gongkaiUI[2].transform.GetChild(3).GetChild(3).gameObject.SetActive(value: true);
					}
					if (isdoufu)
					{
						base.transform.tag = "装盘豆腐";
					}
					Invoke("changes", 0.2f);
					isgo = true;
					return;
				}
				for (int j = 0; j < base.transform.GetChild(2).childCount - 1; j++)
				{
					base.transform.GetChild(2).GetChild(j).gameObject.SetActive(value: true);
				}
				base.transform.GetChild(4).transform.gameObject.SetActive(value: true);
				base.transform.GetComponent<BoxCollider>().enabled = false;
				base.transform.tag = "成品糖油粑粑";
				A = UnityEngine.Object.Instantiate(shenying.gameObject, shenying.transform.position, shenying.transform.rotation);
				A.SetActive(value: true);
				UnityEngine.Object.Destroy(A.gameObject, 3f);
				Invoke("changes", 0.2f);
				isgo = true;
				if (BoolData.IsCourse && Rote.suiji == 1)
				{
					BoolData.zhuanhaun = true;
				}
			}

			private void OnTriggerExit(Collider other)
			{
				if (other.tag == "成品糖油粑粑")
				{
					isnull = false;
				}
				if (other.tag == "碰撞盒子" && base.transform.name != "OUT")
				{
					if (!ischang)
					{
						UnityEngine.Object.Destroy(base.transform.gameObject, 5f);
						base.transform.GetComponent<HVRGrabbable>().enabled = false;
						shencheng();
						ischang = true;
						base.transform.name = "OUT";
					}
					Invoke("pengzhuang", 0.1f);
				}
			}

			private void shencheng()
			{
				switch (base.transform.GetChild(0).tag)
				{
				case "碗":
					BoolData.isIns = true;
					break;
				case "大碗":
					BoolData.isTrue = true;
					break;
				case "小碗":
					BoolData.isTheer = true;
					break;
				}
			}

			private void OnTriggerEnter(Collider other)
			{
				if (other.tag == "碰撞盒子")
				{
					i = 999;
				}
				if (fangxia || ismian || istig)
				{
					return;
				}
				if (!istangyou && other.tag == "豆腐2" && !isones)
				{
					n++;
					base.transform.GetChild(0).transform.gameObject.SetActive(value: true);
					base.transform.GetComponent<MeshRenderer>().enabled = false;
					UnityEngine.Object.Destroy(other.gameObject);
					isnull = true;
					base.transform.tag = "装盘臭豆腐";
					isdoufu = true;
					MonoBehaviour.print("sssssssssssssssssssswwww=" + j);
					ChopsticksScript.naqi = false;
					Invoke("changess", 0.2f);
					isones = true;
				}
				if (isdoufu)
				{
					return;
				}
				if (!istangyou && other.tag == "香肠2" && !isones)
				{
					if (BoolData.IsCourse && (BoolData.Course == 1 || BoolData.Course == 4))
					{
						ButtonScript.gongkaiUI[2].transform.GetChild(1).GetChild(2).gameObject.SetActive(value: false);
						ButtonScript.gongkaiUI[2].transform.GetChild(1).GetChild(3).gameObject.SetActive(value: true);
					}
					base.transform.GetComponent<MeshRenderer>().enabled = false;
					base.transform.GetChild(1).transform.gameObject.SetActive(value: true);
					base.transform.tag = "装盘香肠";
					UnityEngine.Object.Destroy(other.gameObject);
					istig = true;
					isnull = true;
					ChopsticksScript.naqi = false;
					Invoke("changess", 0.2f);
					isones = true;
				}
				if (other.tag == "糖油粑粑2" && !isones)
				{
					UnityEngine.Object.Destroy(other.gameObject);
					base.transform.GetComponent<MeshRenderer>().enabled = false;
					base.transform.GetChild(3).transform.gameObject.SetActive(value: true);
					isnull = true;
					base.transform.tag = "装盘糖油粑粑";
					istangyou = true;
					istig = true;
					Invoke("change", 0.1f);
					n++;
					MonoBehaviour.print("sssssss=" + n);
					ChopsticksScript.naqi = false;
					Invoke("changess", 0.2f);
					isones = true;
				}
			}

			private void OnTriggerStay(Collider other)
			{
				if (fangxia || ismian || istig)
				{
					return;
				}
				if (!istangyou && other.tag == "豆腐2" && !isones)
				{
					n++;
					base.transform.GetChild(0).transform.gameObject.SetActive(value: true);
					base.transform.GetComponent<MeshRenderer>().enabled = false;
					UnityEngine.Object.Destroy(other.gameObject);
					isnull = true;
					base.transform.tag = "装盘臭豆腐";
					isdoufu = true;
					MonoBehaviour.print("sssssssssssssssssssswwww=" + j);
					ChopsticksScript.naqi = false;
					Invoke("changess", 0.2f);
					isones = true;
				}
				if (isdoufu)
				{
					return;
				}
				if (!istangyou && other.tag == "香肠2" && !isones)
				{
					if (BoolData.IsCourse && (BoolData.Course == 1 || BoolData.Course == 4))
					{
						ButtonScript.gongkaiUI[2].transform.GetChild(1).GetChild(2).gameObject.SetActive(value: false);
						ButtonScript.gongkaiUI[2].transform.GetChild(1).GetChild(3).gameObject.SetActive(value: true);
					}
					base.transform.GetComponent<MeshRenderer>().enabled = false;
					base.transform.GetChild(1).transform.gameObject.SetActive(value: true);
					base.transform.tag = "装盘香肠";
					UnityEngine.Object.Destroy(other.gameObject);
					istig = true;
					isnull = true;
					ChopsticksScript.naqi = false;
					Invoke("changess", 0.2f);
					isones = true;
				}
				if (other.tag == "糖油粑粑2" && !isones)
				{
					UnityEngine.Object.Destroy(other.gameObject);
					base.transform.GetComponent<MeshRenderer>().enabled = false;
					base.transform.GetChild(3).transform.gameObject.SetActive(value: true);
					isnull = true;
					base.transform.tag = "装盘糖油粑粑";
					istangyou = true;
					istig = true;
					Invoke("change", 0.1f);
					n++;
					MonoBehaviour.print("sssssss=" + n);
					ChopsticksScript.naqi = false;
					Invoke("changess", 0.2f);
					isones = true;
				}
			}

			private void OnCollisionEnter(Collision collision)
			{
				if (collision.gameObject.tag == "内地面")
				{
					UnityEngine.Object.Destroy(base.transform.gameObject);
					switch (base.transform.GetChild(0).tag)
					{
					case "碗":
						BoolData.isIns = true;
						break;
					case "大碗":
						BoolData.isTrue = true;
						break;
					case "小碗":
						BoolData.isTheer = true;
						break;
					}
				}
			}

			private void pengzhuang()
			{
				ischang = false;
			}

			private void change()
			{
				istig = false;
			}

			private void changes()
			{
				istig = true;
			}

			private void changess()
			{
				isones = false;
			}
		}
		public class SoupPot : MonoBehaviour
		{
			private void Start()
			{
			}

			private void Update()
			{
			}

			private void OnTriggerEnter(Collider other)
			{
				if (other.tag == "蘸料1" && base.transform.tag == "酱料")
				{
					MonoBehaviour.print(111111111111L);
					other.transform.GetChild(0).gameObject.SetActive(value: true);
				}
				if (other.tag == "油勺" && base.transform.tag == "汤料")
				{
					MonoBehaviour.print(111111111111L);
					other.transform.GetChild(0).gameObject.SetActive(value: true);
				}
			}
		}
		public class SoupSpoon : MonoBehaviour
		{
			public GameObject shenying;

			private GameObject A;

			private void Start()
			{
			}

			private void Update()
			{
			}

			private void OnTriggerEnter(Collider other)
			{
				if (other.tag == "汤盘")
				{
					base.transform.GetChild(0).gameObject.SetActive(value: true);
				}
				if (!base.transform.GetChild(0).gameObject.activeSelf)
				{
					return;
				}
				if (other.tag == "装盘面")
				{
					base.transform.GetChild(0).gameObject.SetActive(value: false);
					other.transform.GetChild(2).transform.GetComponent<MeshRenderer>().enabled = false;
					other.transform.GetChild(2).transform.GetChild(0).transform.gameObject.SetActive(value: true);
					other.gameObject.tag = "成品拌面";
					other.transform.GetChild(4).transform.gameObject.SetActive(value: true);
					other.transform.GetComponent<BoxCollider>().enabled = false;
					A = UnityEngine.Object.Instantiate(shenying.transform.GetChild(6).gameObject, base.transform.position, base.transform.rotation);
					A.SetActive(value: true);
					UnityEngine.Object.Destroy(A.gameObject, 5f);
					if (BoolData.IsCourse && Rote.suiji == 1)
					{
						BoolData.zhuanhaun = true;
					}
				}
				if (other.tag == "装盘豆腐")
				{
					base.transform.GetChild(0).gameObject.SetActive(value: false);
					other.transform.GetComponent<BoxCollider>().enabled = false;
					other.transform.GetChild(2).transform.GetComponent<MeshRenderer>().enabled = false;
					for (int i = 0; i < other.transform.GetChild(0).transform.childCount; i++)
					{
						other.transform.GetChild(0).transform.GetChild(i).gameObject.SetActive(value: false);
					}
					other.transform.GetChild(0).transform.GetChild(6).transform.gameObject.SetActive(value: true);
					other.gameObject.tag = "成品臭豆腐";
					other.transform.GetChild(4).transform.gameObject.SetActive(value: true);
					A = UnityEngine.Object.Instantiate(shenying.transform.GetChild(6).gameObject, base.transform.position, base.transform.rotation);
					A.SetActive(value: true);
					UnityEngine.Object.Destroy(A.gameObject, 5f);
					if (BoolData.IsCourse && Rote.suiji == 1)
					{
						BoolData.zhuanhaun = true;
					}
				}
			}
		}
		public class SpoonScript : MonoBehaviour
		{
			public GameObject shengying;

			private GameObject A;

			private void Start()
			{
			}

			private void Update()
			{
			}

			private void OnCollisionEnter(Collision other)
			{
				if (other.gameObject.tag == "酱料")
				{
					base.transform.GetChild(0).gameObject.SetActive(value: true);
				}
				if (!base.transform.GetChild(0).gameObject.activeSelf)
				{
					return;
				}
				string text = other.gameObject.tag;
				if (text == "装盘香肠")
				{
					base.transform.GetChild(0).gameObject.SetActive(value: false);
					other.transform.GetChild(1).transform.GetComponent<MeshRenderer>().enabled = false;
					other.transform.GetComponent<BoxCollider>().enabled = false;
					other.transform.GetChild(1).transform.GetChild(0).transform.gameObject.SetActive(value: true);
					other.gameObject.tag = "成品炸香肠";
					other.transform.GetChild(4).transform.gameObject.SetActive(value: true);
					A = UnityEngine.Object.Instantiate(shengying.transform.GetChild(6).gameObject, base.transform.position, base.transform.rotation);
					A.SetActive(value: true);
					UnityEngine.Object.Destroy(A.gameObject, 5f);
					if (BoolData.IsCourse && Rote.suiji == 1)
					{
						BoolData.zhuanhaun = true;
					}
				}
			}
		}
		public class TiggerManage : MonoBehaviour
		{
			public static TiggerManage Instans;

			public GameObject Content;

			public GameObject Item;

			private GameObject shaozi;

			private GameObject shaozi1;

			private GameObject youshao;

			private GameObject youshao1;

			private GameObject doufu;

			private GameObject tangyou;

			private GameObject xiangchang;

			private GameObject mian;

			public static GameObject Canavs;

			public static GameObject Canevas;

			public GameObject Canver;

			private GameObject pingdiguo;

			private GameObject pingdiguo1;

			private GameObject kuaizi1;

			private GameObject kuaizi;

			private GameObject Kuaiziss;

			private GameObject kuaizisss;

			private GameObject yingxiao;

			private GameObject shenying;

			public static float jingbi;

			private GameObject A;

			private GameObject B;

			private GameObject C;

			private GameObject D;

			private GameObject didians;

			private GameObject j;

			private GameObject zongdidian;

			private GameObject zongcaidan;

			private GameObject zantingcaidan;

			private int doufusss;

			public static bool istrigger;

			public static bool IsPeng;

			public static bool isfang;

			private bool naqi;

			private bool fangxia;

			private bool kuaizis;

			private bool isPDG;

			private bool isMain;

			private bool isting;

			public static bool jiaocheng;

			public static bool isstop;

			private bool UIxianshi = true;

			public static bool ishand;

			public static bool iscouse;

			public static bool fanhui;

			private Vector3 mianPos;

			private Quaternion mianRote;

			private Vector3 PDGPos;

			private Quaternion PDGRote;

			private Vector3 SZPos;

			private Quaternion SZRote;

			private Vector3 HandPos;

			private Quaternion HandRote;

			private Vector3 youshaoPos;

			private Vector3 shaoziPos;

			private Quaternion youshaoRote;

			private Quaternion shaoziRote;

			private Vector3 kuaizi1Pos;

			private Vector3 kuaizi2Pos;

			private Quaternion Rotes;

			private void Start()
			{
				Instans = this;
				Canevas = GameObject.FindWithTag("text2").gameObject;
				Canavs = GameObject.FindWithTag("TextController").gameObject;
				C = Canavs.transform.parent.transform.gameObject.transform.GetChild(2).transform.GetChild(1).transform.gameObject;
				tangyou = base.transform.parent.GetChild(1).transform.gameObject;
				doufu = base.transform.parent.GetChild(2).transform.gameObject;
				xiangchang = base.transform.parent.GetChild(3).transform.gameObject;
				shaozi = base.transform.parent.GetChild(0).transform.gameObject;
				kuaizi1 = base.transform.parent.GetChild(5).transform.gameObject;
				pingdiguo1 = base.transform.parent.GetChild(4).transform.gameObject;
				youshao = base.transform.parent.GetChild(6).transform.gameObject;
				youshao1 = GameObject.FindWithTag("油勺").gameObject;
				mian = GameObject.FindWithTag("面").gameObject;
				kuaizi = GameObject.FindWithTag("筷子").gameObject;
				pingdiguo = GameObject.FindWithTag("平底锅").gameObject;
				yingxiao = GameObject.FindWithTag("声音").gameObject;
				didians = GameObject.FindWithTag("总人物").gameObject;
				zongdidian = GameObject.FindWithTag("总地点").gameObject;
				zongcaidan = GameObject.FindWithTag("总菜单").gameObject;
				BoolData.CANVA = Canavs.transform.parent.transform.gameObject.transform.GetChild(2).transform.GetChild(0).transform.GetChild(0).transform.GetComponent<Text>();
				Kuaiziss = kuaizi.transform.GetChild(0).gameObject;
				kuaizisss = kuaizi.transform.GetChild(1).gameObject;
				MonoBehaviour.print(kuaizi.transform.childCount);
				mianPos = mian.transform.position;
				mianRote = mian.transform.rotation;
				HandPos = doufu.transform.position;
				HandRote = doufu.transform.rotation;
				kuaizi1Pos = Kuaiziss.transform.position;
				kuaizi2Pos = kuaizisss.transform.position;
				Rotes = Kuaiziss.transform.rotation;
			}

			private void Update()
			{
				HVRController rightController = HVRInputManager.Instance.RightController;
				Canevas.transform.GetChild(2).GetComponent<Text>().text = "J的数量为：" + BoolData.j;
				Canevas.transform.GetChild(3).GetComponent<Text>().text = "N的数量为：" + BoolData.n;
				zantingcaidan = RayScript.gongkaiznating;
				HandPos = doufu.transform.position;
				if (isMain)
				{
					shenying = UnityEngine.Object.Instantiate(yingxiao.transform.GetChild(5).gameObject, yingxiao.transform.GetChild(5).transform.position, yingxiao.transform.GetChild(5).transform.rotation, yingxiao.transform);
					shenying.SetActive(value: true);
					Invoke("des", 1f);
					if (A.tag == "教程" || A.tag == "开始")
					{
						A.transform.parent.transform.parent.parent.gameObject.SetActive(value: false);
						A.transform.GetComponent<Image>().color = new Color(255f, 255f, 255f);
						for (int i = 0; i < zongdidian.transform.childCount; i++)
						{
							zongdidian.transform.GetChild(i).GetComponent<BoxCollider>().enabled = true;
						}
						BoolData.j = 0;
						BoolData.jingbi = 0;
						BoolData.Change.T = 1;
						BoolData.Course = 0;
						BoolData.n = 0;
						fanhui = true;
						if (A.tag == "教程")
						{
							Rote.tingzhi = false;
							tishi.kaishi = 380f;
							iscouse = true;
							BoolData.IsCourse = true;
							Canavs.transform.GetChild(5).transform.gameObject.SetActive(value: true);
						}
						if (A.tag == "开始")
						{
							BoolData.shengli = true;
							Rote.tingzhi = true;
							BoolData.Boos.shit = true;
							BoolData.Boos.shibai = false;
							Times.istime = false;
							BoolData.IsGame = true;
							Times.S = 0;
							Times.M = 0f;
						}
					}
					if (A.tag == "排行榜")
					{
						A.transform.parent.transform.parent.parent.gameObject.SetActive(value: false);
					}
					if (A.tag == " 返回主菜单")
					{
						zongcaidan.SetActive(value: true);
						Canavs.transform.parent.GetChild(3).GetChild(1).transform.gameObject.SetActive(value: false);
					}
					if (A.tag == "继续游戏")
					{
						Time.timeScale = 1f;
						A.SetActive(value: false);
					}
					if (A.tag == "返回游戏")
					{
						tishi.kaishi = -1f;
						didians.transform.GetChild(2).gameObject.SetActive(value: true);
						Invoke("xiaoshisas", 4f);
					}
					if (A.tag == "退出")
					{
						Application.Quit();
					}
					isMain = false;
				}
				MonoBehaviour.print("iscouse= " + iscouse);
				if (iscouse)
				{
					BoolData.IsCourse = true;
				}
				if (!IsPeng && !istrigger)
				{
					kuaizi1.SetActive(value: false);
					kuaizi.SetActive(value: true);
				}
				if (Input.GetKey(KeyCode.O))
				{
					BoolData.jingbi += 100;
				}
				if (Input.GetKey(KeyCode.H))
				{
					BoolData.jingbi -= 10;
				}
				if (Input.GetKey(KeyCode.Q))
				{
					BoolData.DD.transform.position = base.transform.TransformPoint(0f, 0f, 2f);
					BoolData.DD.transform.parent = base.transform.parent.transform.GetChild(4).transform.GetChild(0).transform;
					BoolData.DD.transform.GetComponent<Rigidbody>().isKinematic = true;
				}
				if (Input.GetKey(KeyCode.G) && BoolData.DD.transform.parent == base.transform.parent.transform.GetChild(4).transform.GetChild(0).transform)
				{
					BoolData.DD.GetComponent<Rigidbody>().isKinematic = false;
					BoolData.DD.transform.SetParent(null);
					Vector3 force = base.transform.parent.transform.GetChild(4).transform.GetChild(0).transform.TransformDirection(0f, 0f, -10f);
					BoolData.DD.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
					BoolData.isPDG = false;
				}
				if (rightController.TriggerButtonState.Active)
				{
					if (!isstop)
					{
						BoolData.istimes = true;
						Time.timeScale = 0f;
						fanqie.istime = false;
						Rote.tingzhi = true;
						Times.istime = true;
						base.transform.parent.parent.parent.GetChild(0).GetChild(6).GetChild(0)
							.GetChild(1)
							.GetChild(0)
							.GetChild(0)
							.GetComponent<Text>()
							.text = "按下-键继续游戏";
						if (BoolData.IsGame || BoolData.IsCourse)
						{
							isting = true;
							zantingcaidan.SetActive(value: true);
							zantingcaidan.transform.GetChild(0).GetChild(0).gameObject.SetActive(value: true);
						}
						if (BoolData.jingbi > BoolData.jing)
						{
							BoolData.jing = BoolData.jingbi;
						}
						if (BoolData.timess > BoolData.shijian)
						{
							BoolData.shijian = BoolData.timess;
						}
						if (BoolData.timess == BoolData.shijian && BoolData.miaos > BoolData.miao)
						{
							BoolData.miao = BoolData.miaos;
						}
						isstop = true;
					}
					else
					{
						isting = false;
						fanqie.istime = true;
						base.transform.parent.parent.parent.GetChild(0).GetChild(6).GetChild(0)
							.GetChild(1)
							.GetChild(0)
							.GetChild(0)
							.GetComponent<Text>()
							.text = "按下-键暂停游戏";
						Time.timeScale = 1f;
						if (BoolData.IsGame)
						{
							Rote.tingzhi = false;
							BoolData.istimes = false;
						}
						Times.istime = false;
						zantingcaidan.SetActive(value: false);
						isstop = false;
					}
				}
				if (Input.GetKeyDown(KeyCode.O))
				{
					if (!UIxianshi)
					{
						base.transform.parent.transform.GetChild(7).gameObject.SetActive(value: true);
						base.transform.parent.transform.GetChild(7).GetChild(1).gameObject.SetActive(value: true);
						UIxianshi = true;
					}
					else
					{
						for (int j = 0; j < base.transform.parent.transform.GetChild(7).childCount; j++)
						{
							base.transform.parent.transform.GetChild(7).GetChild(j).gameObject.SetActive(value: false);
						}
						base.transform.parent.transform.GetChild(7).GetChild(1).gameObject.SetActive(value: true);
						base.transform.parent.parent.parent.GetChild(0).GetChild(6).GetChild(0)
							.gameObject.SetActive(value: false);
						UIxianshi = false;
					}
				}
				MonoBehaviour.print("UIxianshi=" + UIxianshi);
				if (ishand)
				{
					A.transform.position = HandPos;
				}
				if (istrigger)
				{
					if (!IsPeng && rightController.TriggerButtonState.Active)
					{
						if (A.tag == "臭豆腐块" || A.tag == "香肠条" || A.tag == "糖油粑粑1")
						{
							A.transform.SetParent(base.transform);
							A.transform.GetComponent<BoxCollider>().enabled = false;
							base.transform.GetComponent<MeshRenderer>().enabled = false;
							A.transform.GetComponent<Rigidbody>().useGravity = false;
							A.transform.GetComponent<MeshCollider>().isTrigger = true;
							ishand = true;
							IsPeng = true;
							BoolData.Again = true;
						}
						if (A.tag == "臭豆腐" || A.tag == "香肠" || A.tag == "糖油粑粑")
						{
							if (A.tag == "臭豆腐")
							{
								if (BoolData.IsCourse && BoolData.Course == 3)
								{
									Canavs.transform.GetChild(3).GetChild(0).gameObject.SetActive(value: false);
									Canavs.transform.GetChild(3).GetChild(1).gameObject.SetActive(value: true);
								}
								A = UnityEngine.Object.Instantiate(doufu, doufu.transform.position, doufu.transform.rotation);
								A.transform.GetComponent<MeshCollider>().isTrigger = true;
							}
							if (A.tag == "香肠")
							{
								if (BoolData.IsCourse && BoolData.Course == 1)
								{
									Canavs.transform.GetChild(1).GetChild(0).gameObject.SetActive(value: false);
									Canavs.transform.GetChild(1).GetChild(1).gameObject.SetActive(value: true);
								}
								A = UnityEngine.Object.Instantiate(xiangchang, xiangchang.transform.position, xiangchang.transform.rotation);
								A.transform.GetComponent<MeshCollider>().isTrigger = true;
							}
							if (A.tag == "糖油粑粑")
							{
								if (BoolData.IsCourse && BoolData.Course == 2)
								{
									Canavs.transform.GetChild(2).GetChild(0).gameObject.SetActive(value: false);
									Canavs.transform.GetChild(2).GetChild(1).gameObject.SetActive(value: true);
								}
								A = UnityEngine.Object.Instantiate(tangyou, tangyou.transform.position, tangyou.transform.rotation);
								A.transform.GetComponent<MeshCollider>().isTrigger = true;
							}
							ishand = true;
							A.SetActive(value: true);
							A.transform.SetParent(base.transform.parent.transform);
							base.transform.GetComponent<MeshRenderer>().enabled = false;
							BoolData.Again = true;
							IsPeng = true;
						}
						if (A.tag == "成品糖油粑粑" || A.tag == "成品臭豆腐" || A.tag == "成品拌面" || A.tag == "成品炸香肠" || A.tag == "装盘豆腐" || A.tag == "装盘面" || A.tag == "装盘香肠" || A.tag == "装盘糖油粑粑" || A.tag == "碗" || A.tag == "碗2" || A.tag == "碗3")
						{
							A.transform.GetComponent<BoxCollider>().isTrigger = true;
							A.transform.GetComponent<MeshCollider>().isTrigger = true;
							A.transform.GetComponent<Rigidbody>().useGravity = false;
							A.transform.GetComponent<Rigidbody>().isKinematic = true;
							A.transform.SetParent(base.transform);
							base.transform.GetComponent<MeshRenderer>().enabled = false;
							BoolData.Again = true;
							IsPeng = true;
						}
						if (A.tag == "灭火器" || A.tag == "平底锅" || A.tag == "煤气灶" || A.tag == "果盘" || A.tag == "蘸料1" || A.tag == "油勺" || A.tag == "面")
						{
							A.transform.SetParent(base.transform.parent.transform.GetChild(4).transform.GetChild(0).transform);
							base.transform.GetComponent<MeshRenderer>().enabled = false;
							A.transform.GetComponent<Rigidbody>().useGravity = false;
							A.transform.GetComponent<Rigidbody>().isKinematic = true;
							BoolData.Again = true;
							IsPeng = true;
							isPDG = true;
							kuaizis = true;
						}
						string text = A.tag;
						if (text == "筷子")
						{
							kuaizi1.SetActive(value: true);
							kuaizi.SetActive(value: false);
							base.transform.GetComponent<MeshRenderer>().enabled = false;
							BoolData.Again = true;
							kuaizis = true;
							IsPeng = true;
							ChopsticksScript.naqi = false;
							if (!UIxianshi)
							{
								base.transform.parent.transform.GetChild(7).gameObject.SetActive(value: true);
								base.transform.parent.transform.GetChild(7).GetChild(1).gameObject.SetActive(value: true);
								UIxianshi = true;
							}
							else
							{
								for (int k = 0; k < base.transform.parent.transform.GetChild(7).childCount; k++)
								{
									base.transform.parent.transform.GetChild(7).GetChild(k).gameObject.SetActive(value: false);
								}
								base.transform.parent.transform.GetChild(7).GetChild(1).gameObject.SetActive(value: true);
								base.transform.parent.parent.parent.GetChild(0).GetChild(6).GetChild(0)
									.gameObject.SetActive(value: false);
								UIxianshi = false;
							}
						}
					}
					if (IsPeng)
					{
						if (!kuaizis && (rightController.TriggerButtonState.Active || Input.GetKeyDown(KeyCode.Z)))
						{
							ishand = false;
							if (A.tag == "臭豆腐块" || A.tag == "香肠条" || A.tag == "糖油粑粑1")
							{
								A.transform.SetParent(null);
								A.transform.GetComponent<BoxCollider>().enabled = true;
								base.transform.GetComponent<MeshRenderer>().enabled = true;
								A.transform.GetComponent<Rigidbody>().useGravity = true;
								A.transform.GetComponent<MeshCollider>().isTrigger = false;
								IsPeng = false;
								istrigger = false;
							}
							if (A.tag == "臭豆腐" || A.tag == "香肠" || A.tag == "糖油粑粑")
							{
								base.transform.GetComponent<MeshRenderer>().enabled = true;
								A.transform.SetParent(null);
								A.transform.GetComponent<Rigidbody>().useGravity = true;
								A.transform.GetComponent<MeshCollider>().isTrigger = false;
								UnityEngine.Object.Destroy(A.transform.gameObject, 30f);
								IsPeng = false;
								istrigger = false;
							}
							if (A.tag == "成品糖油粑粑" || A.tag == "成品臭豆腐" || A.tag == "成品拌面" || A.tag == "成品炸香肠" || A.tag == "装盘豆腐" || A.tag == "装盘面" || A.tag == "装盘香肠" || A.tag == "装盘糖油粑粑" || A.tag == "碗" || A.tag == "碗2" || A.tag == "碗3")
							{
								base.transform.GetComponent<MeshRenderer>().enabled = true;
								A.transform.GetComponent<MeshCollider>().isTrigger = false;
								A.transform.GetComponent<Rigidbody>().useGravity = true;
								A.transform.GetComponent<Rigidbody>().isKinematic = false;
								A.transform.SetParent(null);
								IsPeng = false;
								istrigger = false;
							}
							_ = A.tag;
						}
						if (kuaizis)
						{
							if (isPDG && rightController.TriggerButtonState.Active)
							{
								if (A.tag == "平底锅" || A.tag == "果盘")
								{
									if (A.tag == "平底锅")
									{
										BoolData.isPDG = false;
									}
									if (A.tag == "果盘")
									{
										BoolData.isGuoPan = false;
									}
									A.GetComponent<Rigidbody>().isKinematic = false;
									A.transform.SetParent(null);
									Vector3 force2 = base.transform.parent.transform.GetChild(4).transform.GetChild(0).transform.TransformDirection(0f, 0f, -10f);
									A.GetComponent<Rigidbody>().AddForce(force2, ForceMode.Impulse);
									A.transform.GetComponent<Rigidbody>().useGravity = true;
									A.transform.GetComponent<MeshCollider>().isTrigger = true;
									base.transform.GetComponent<MeshRenderer>().enabled = true;
									IsPeng = false;
									istrigger = false;
									kuaizis = false;
									isPDG = false;
									ishand = false;
									shenying = UnityEngine.Object.Instantiate(yingxiao.transform.GetChild(2).gameObject, yingxiao.transform.GetChild(2).transform.position, yingxiao.transform.GetChild(2).transform.rotation, yingxiao.transform);
									shenying.SetActive(value: true);
									Invoke("xiaoshi", 1f);
								}
								if (A.tag == "油勺" || A.tag == "蘸料1" || A.tag == "面")
								{
									if (A.tag == "油勺")
									{
										BoolData.isyoushao = false;
									}
									if (A.tag == "蘸料1")
									{
										BoolData.isshaozi = false;
									}
									if (A.tag == "面")
									{
										BoolData.ismian = false;
									}
									UnityEngine.Object.Destroy(A.gameObject);
									base.transform.GetComponent<MeshRenderer>().enabled = true;
									IsPeng = false;
									istrigger = false;
									kuaizis = false;
									isPDG = false;
									ishand = false;
								}
							}
							if (rightController.TriggerButtonState.Active)
							{
								IsPeng = false;
								istrigger = false;
								kuaizis = false;
								ishand = false;
								base.transform.GetComponent<MeshRenderer>().enabled = true;
								kuaizi1.SetActive(value: false);
								kuaizi.SetActive(value: true);
								base.transform.parent.transform.GetChild(7).gameObject.SetActive(value: true);
								base.transform.parent.transform.GetChild(7).GetChild(1).gameObject.SetActive(value: true);
								ChopsticksScript.naqi = false;
								if (!UIxianshi)
								{
									base.transform.parent.transform.GetChild(7).gameObject.SetActive(value: true);
									for (int l = 0; l < base.transform.parent.transform.GetChild(7).childCount; l++)
									{
										base.transform.parent.transform.GetChild(7).GetChild(l).gameObject.SetActive(value: true);
									}
									base.transform.parent.parent.parent.GetChild(0).GetChild(6).GetChild(0)
										.gameObject.SetActive(value: true);
									UIxianshi = !UIxianshi;
								}
								Kuaiziss.transform.position = kuaizi1Pos;
								kuaizisss.transform.position = kuaizi2Pos;
								Kuaiziss.transform.rotation = Rotes;
								kuaizisss.transform.rotation = Rotes;
							}
						}
					}
				}
				if (BoolData.j != 0)
				{
					for (int m = 0; m < BoolData.j; m++)
					{
						C.transform.GetChild(m).gameObject.SetActive(value: true);
					}
				}
				else
				{
					for (int n = 0; n < 5; n++)
					{
						C.transform.GetChild(n).gameObject.SetActive(value: false);
					}
				}
			}

			private void des()
			{
				UnityEngine.Object.Destroy(shenying.gameObject);
			}

			private void xiaoshi()
			{
				UnityEngine.Object.Destroy(shenying.gameObject);
			}

			private void IsFangs()
			{
				isfang = false;
			}

			private void OnTriggerEnter(Collider other)
			{
				if (other.tag == "教程" || other.tag == "开始" || other.tag == "排行榜" || other.tag == "退出" || other.tag == "返回游戏" || other.tag == "返回主菜单" || other.tag == "继续游戏")
				{
					MonoBehaviour.print("1111111111111111111111111111111111");
					isMain = true;
					A = other.gameObject;
					other.transform.GetComponent<Image>().color = new Color(100f, 100f, 100f);
				}
				if (!istrigger && !IsPeng)
				{
					if (other.tag == "臭豆腐" || other.tag == "香肠" || other.tag == "糖油粑粑" || other.tag == "蘸料1" || other.tag == "油勺" || other.tag == "灭火器" || other.tag == "平底锅" || other.tag == "平底锅" || other.tag == "筷子" || other.tag == "面" || other.tag == "成品臭豆腐" || other.tag == "成品炸香肠" || other.tag == "成品糖油粑粑" || other.tag == "成品拌面" || other.tag == "臭豆腐块" || other.tag == "香肠条" || other.tag == "糖油粑粑1" || other.tag == "果盘" || other.tag == "装盘豆腐" || other.tag == "装盘面" || other.tag == "装盘香肠" || other.tag == "装盘糖油粑粑" || other.tag == "碗" || other.tag == "碗2" || other.tag == "碗3")
					{
						A = other.gameObject;
						istrigger = true;
					}
					_ = other.tag;
				}
			}

			private void OnTriggerExit(Collider other)
			{
				if (other.tag == "教程" || other.tag == "开始" || other.tag == "排行榜" || other.tag == "退出")
				{
					isMain = false;
					A = null;
					other.transform.GetComponent<Image>().color = new Color(255f, 255f, 255f);
				}
				if (istrigger && !IsPeng)
				{
					if (other.tag == "臭豆腐" || other.tag == "香肠" || other.tag == "糖油粑粑" || other.tag == "蘸料1" || other.tag == "油勺" || other.tag == "灭火器" || other.tag == "平底锅" || other.tag == "平底锅" || other.tag == "筷子" || other.tag == "面" || other.tag == "成品臭豆腐" || other.tag == "成品炸香肠" || other.tag == "成品糖油粑粑" || other.tag == "成品拌面" || other.tag == "臭豆腐块" || other.tag == "香肠条" || other.tag == "糖油粑粑1" || other.tag == "果盘" || other.tag == "装盘豆腐" || other.tag == "装盘面" || other.tag == "装盘香肠" || other.tag == "装盘糖油粑粑" || other.tag == "碗" || other.tag == "碗2" || other.tag == "碗3")
					{
						A = null;
						istrigger = false;
					}
					_ = other.tag;
				}
			}

			public static void endtrigger()
			{
				istrigger = false;
			}

			private void xiaoshias()
			{
				didians.transform.GetChild(2).gameObject.SetActive(value: false);
			}

			private void xiaoshisas()
			{
				Canavs.transform.GetChild(5).transform.gameObject.SetActive(value: false);
			}

			private void xiaoshissss()
			{
				didians.transform.GetChild(2).gameObject.SetActive(value: false);
			}

			public void fanhuizhu()
			{
				BoolData.IsGame = false;
				BoolData.IsCourse = false;
				iscouse = false;
				Times.S = 0;
				Times.M = 0f;
				Times.istime = true;
				BoolData.IsCaster = false;
				BoolData.n = 5;
				BoolData.Course = 0;
				BoolData.Boos.times = 0;
				zongcaidan.SetActive(value: true);
				for (int i = 0; i < Canavs.transform.childCount; i++)
				{
					Canavs.transform.GetChild(i).transform.gameObject.SetActive(value: false);
				}
				for (int j = 0; j < zongdidian.transform.childCount; j++)
				{
					zongdidian.transform.GetChild(j).GetComponent<BoxCollider>().enabled = false;
				}
				Invoke("xiaoshissss", 4f);
				fanhui = false;
			}
		}
		public class Textss : MonoBehaviour
		{
			private float ASS;

			private bool istimesss;

			private void Start()
			{
			}

			private void Update()
			{
				base.transform.GetComponent<Text>().color = new Color(1f, 1f, 1f, ASS);
				if (ASS >= 0.99f)
				{
					istimesss = false;
				}
				if (ASS <= 0.01f)
				{
					istimesss = true;
				}
				if (!istimesss)
				{
					ASS -= 0.01f;
				}
				else
				{
					ASS += 0.01f;
				}
			}
		}
		public class UImobe : MonoBehaviour
		{
			private Vector3 Pos1;

			private Vector3 Pos2;

			private bool ismove = true;

			private void Start()
			{
				kaishi();
				Pos1 = base.transform.position;
				Pos2 = base.transform.position + Vector3.down;
			}

			private void Update()
			{
				if (ismove)
				{
					if (base.transform.tag == "箭头")
					{
						base.transform.position += Vector3.right * Time.deltaTime * 0.2f;
					}
					else
					{
						base.transform.position += Vector3.down * Time.deltaTime * 0.2f;
					}
				}
				else if (base.transform.tag == "箭头")
				{
					base.transform.position += Vector3.left * Time.deltaTime * 0.2f;
				}
				else
				{
					base.transform.position += Vector3.up * Time.deltaTime * 0.2f;
				}
			}

			private void kaishi()
			{
				ismove = true;
				Invoke("end", 0.8f);
			}

			private void end()
			{
				ismove = false;
				Invoke("kaishi", 0.8f);
			}
		}
		public class tishi : MonoBehaviour
		{
			public GameObject[] hua;

			public static float kaishi = -1f;

			private float width = -1f;

			private float hight = 144f;

			private Vector3 Pos1;

			private Vector3 Pos2;

			private Vector3 zhou1;

			private Vector3 zhou2;

			private void Start()
			{
			}

			private void Update()
			{
				if (width < kaishi)
				{
					width += 3f;
				}
				if (width > kaishi)
				{
					width -= 3f;
				}
				base.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(width, hight);
			}
		}
		public class kuaizijiaoben : MonoBehaviour
		{
			public static GameObject Ds;

			private bool ispengzhuang;

			private bool isnaqi;

			public static bool zhuangtai;

			private bool ischang;

			private GameObject AllProp;

			private void Start()
			{
				AllProp = GameObject.Find("AllProp");
			}

			private void Update()
			{
				HVRController leftController = HVRInputManager.Instance.LeftController;
				HVRController rightController = HVRInputManager.Instance.RightController;
				if (!leftController.TriggerButtonState.Active && !rightController.TriggerButtonState.Active)
				{
					zhuangtai = false;
				}
				if ((leftController.TriggerButtonState.Active || rightController.TriggerButtonState.Active) && !isnaqi && ispengzhuang)
				{
					Ds.transform.SetParent(base.transform);
					Ds.transform.GetComponent<Rigidbody>().isKinematic = true;
					Ds.transform.GetComponent<Rigidbody>().useGravity = false;
					Ds.transform.GetComponent<MeshCollider>().isTrigger = true;
					zhuangtai = true;
					isnaqi = true;
				}
				if (isnaqi && !leftController.TriggerButtonState.Active && !rightController.TriggerButtonState.Active && ispengzhuang)
				{
					Ds.transform.SetParent(null);
					Ds.transform.GetComponent<Rigidbody>().isKinematic = false;
					Ds.transform.GetComponent<Rigidbody>().useGravity = true;
					Ds.transform.GetComponent<MeshCollider>().isTrigger = false;
					zhuangtai = false;
					ispengzhuang = false;
					isnaqi = false;
				}
			}

			private void OnCollisionEnter(Collision collision)
			{
				if (collision.gameObject.tag == "内地面")
				{
					UnityEngine.Object.Destroy(base.transform.gameObject);
					BoolData.iskuaizi = false;
				}
			}

			private void OnCollisionStay(Collision collision)
			{
				if (!zhuangtai)
				{
					if (collision.transform.tag == "香肠2" || collision.transform.tag == "豆腐2" || collision.transform.tag == "糖油粑粑2")
					{
						Ds = collision.transform.gameObject;
						ispengzhuang = true;
					}
					else
					{
						ispengzhuang = false;
					}
				}
			}

			private void OnTriggerExit(Collider other)
			{
				if (other.tag == "碰撞盒子" && base.transform.name != "OUT")
				{
					base.transform.name = "OUT";
					if (!ischang)
					{
						UnityEngine.Object.Destroy(base.transform.gameObject, 5f);
						base.transform.GetComponent<HVRGrabbable>().enabled = false;
						BoolData.iskuaizi = false;
						ischang = true;
						base.transform.parent = null;
					}
					Invoke("pengzhuang", 0.1f);
				}
			}

			private void pengzhuang()
			{
				ischang = false;
			}
		}
		public class RightHand : MonoBehaviour
		{
			public GameObject HandUI;

			private bool ischange;

			private void Start()
			{
			}

			private void Update()
			{
				if (HVRInputManager.Instance.LeftController.TriggerButtonState.Active)
				{
					if (!ischange)
					{
						HandUI.SetActive(value: false);
						ischange = true;
					}
					else
					{
						HandUI.SetActive(value: true);
						ischange = true;
					}
				}
			}
		}
		public class Shuiguopan : MonoBehaviour
		{
			public GameObject BUT;

			public GameObject yinxiao;

			private GameObject shenying;

			private GameObject shenying2;

			private GameObject A;

			private void Start()
			{
			}

			private void Update()
			{
				if (!BoolData.isGuoPan && base.transform.name == "果盘")
				{
					A = UnityEngine.Object.Instantiate(base.transform.gameObject, base.transform.position, base.transform.rotation);
					A.transform.GetComponent<MeshCollider>().enabled = true;
					A.transform.GetComponent<MeshRenderer>().enabled = true;
					A.transform.gameObject.isStatic = false;
					BoolData.DD = A;
					BoolData.isGuoPan = true;
				}
			}

			private void OnTriggerEnter(Collider other)
			{
				if (other.tag == "番茄")
				{
					UnityEngine.Object.Destroy(other.gameObject);
					BoolData.jingbi++;
					shenying = UnityEngine.Object.Instantiate(yinxiao.transform.GetChild(2).gameObject, yinxiao.transform.GetChild(2).transform.position, yinxiao.transform.GetChild(2).transform.rotation, yinxiao.transform);
					shenying.SetActive(value: true);
					Invoke("xiaoshi", 1f);
				}
				if (other.tag == "eating")
				{
					UnityEngine.Object.Destroy(base.transform.gameObject);
					BoolData.j++;
				}
				if (BoolData.IsGame && other.tag == "捣乱")
				{
					UnityEngine.Object.Destroy(base.transform.gameObject);
					UnityEngine.Object.Destroy(other.gameObject);
					shenying2 = UnityEngine.Object.Instantiate(yinxiao.transform.GetChild(3).gameObject, yinxiao.transform.GetChild(3).transform.position, yinxiao.transform.GetChild(3).transform.rotation, yinxiao.transform);
					shenying2.SetActive(value: true);
					BoolData.jingbi += 5;
					BoolData.istrues = true;
					BoolData.IsCaster = true;
					Invoke("xiaoshiss", 1f);
				}
				if (BoolData.IsCourse && other.tag == "捣乱")
				{
					other.transform.parent.transform.gameObject.SetActive(value: false);
					ButtonScript.gongkaiUI[2].transform.GetChild(4).gameObject.SetActive(value: false);
					UnityEngine.Object.Destroy(base.transform.gameObject);
					UnityEngine.Object.Destroy(other.gameObject);
					BoolData.jingbi = 0;
					BoolData.j = 0;
					BoolData.IsCourse = false;
					BUT.SetActive(value: true);
					shenying2 = UnityEngine.Object.Instantiate(yinxiao.transform.GetChild(3).gameObject, yinxiao.transform.GetChild(3).transform.position, yinxiao.transform.GetChild(3).transform.rotation, yinxiao.transform);
					shenying2.SetActive(value: true);
					Invoke("xiaoshiss", 1f);
					TiggerManage.iscouse = false;
				}
			}

			private void xiaoshi()
			{
				UnityEngine.Object.Destroy(shenying.gameObject);
			}

			private void xiaoshiss()
			{
				UnityEngine.Object.Destroy(shenying2.gameObject);
			}
		}
		public class Times : MonoBehaviour
		{
			public static int F;

			public static float M;

			public static int S;

			public GameObject jinbis;

			private int T = 1;

			private float tou;

			private float jing;

			public GameObject peoples;

			public GameObject diren;

			public GameObject chuansong;

			public GameObject caidan;

			public GameObject texiao;

			private GameObject didian;

			public static Text TImesses;

			public Image tu;

			public static bool istime;

			private bool IsCusres;

			private bool IsGame;

			private bool Backs;

			private bool iswhilt;

			public GameObject BOX;

			public static bool kaishi;

			private void Start()
			{
				didian = GameObject.FindWithTag("总地点");
			}

			private void Update()
			{
				MonoBehaviour.print((int)M);
				jing = BoolData.jingbi;
				jinbis.GetComponent<Text>().text = jing.ToString();
				if (jing <= (float)BoolData.jingbi)
				{
					jing += 0.4f;
					if ((int)jing == BoolData.jingbi - 1)
					{
						jing = BoolData.jingbi;
					}
				}
				if (jing > (float)BoolData.jingbi)
				{
					jing -= 0.4f;
				}
				if (BoolData.IsGame || BoolData.IsCourse || BoolData.isphb || BoolData.PaiHB)
				{
					caidan.SetActive(value: false);
				}
				else
				{
					caidan.SetActive(value: true);
				}
				MonoBehaviour.print("s=" + S);
				if (iswhilt)
				{
					MonoBehaviour.print("WHILT=" + iswhilt);
					tou += 0.01f;
					tu.color = new Color(0f, 0f, 0f, tou);
				}
				if (BoolData.Change.ischange)
				{
					MonoBehaviour.print("SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS");
					BoolData.Change.ischange = false;
				}
				if ((BoolData.j >= 5 || BoolData.n >= 5) && !kaishi)
				{
					peoples.transform.GetChild(2).gameObject.SetActive(value: true);
					caidan.transform.GetChild(0).GetChild(5).gameObject.SetActive(value: true);
					BoolData.IsGame = false;
					BoolData.IsCaster = false;
					T = 1;
					caidan.SetActive(value: true);
					BoolData.Change.isgame = false;
					kaishi = true;
				}
				if (BoolData.Change.isgame)
				{
					if (!BoolData.Boos.shibai)
					{
						MonoBehaviour.print("赢了");
						if (BoolData.Boos.times == 1)
						{
							S = 10;
						}
						if (BoolData.Boos.times == 2)
						{
							S = 20;
						}
						Rote.tingzhi = true;
						BoolData.Boos.shit = true;
						T = BoolData.Change.T;
						BoolData.IsGame = true;
						BoolData.IsCaster = true;
						BoolData.istrues = true;
						for (int i = 0; i < BOX.transform.childCount; i++)
						{
							BOX.transform.GetChild(i).GetComponent<BoxCollider>().enabled = true;
						}
						BoolData.OneBox = false;
						BoolData.TwoBox = false;
						BoolData.TherrBox = false;
						istime = false;
						iswhilt = false;
						MonoBehaviour.print("q111");
						caidan.SetActive(value: false);
						noVEC();
						BoolData.shengli = true;
						BoolData.Change.isgame = false;
						BoolData.istrues = true;
						tu.transform.parent.GetChild(1).gameObject.SetActive(value: false);
					}
					else
					{
						peoples.transform.GetChild(2).gameObject.SetActive(value: true);
						BoolData.IsGame = false;
						BoolData.IsCaster = false;
						caidan.transform.GetChild(0).GetChild(5).gameObject.SetActive(value: true);
						iswhilt = true;
						BoolData.Boos.times = 0;
						noVEC();
						CancelInvoke();
						caidan.SetActive(value: true);
						BoolData.shengli = false;
						BoolData.Change.isgame = false;
						if (BoolData.jingbi > BoolData.jing)
						{
							BoolData.jing = BoolData.jingbi;
						}
						if (S > BoolData.shijian)
						{
							BoolData.shijian = T * 10;
						}
						if (S == BoolData.shijian && (int)M > BoolData.miao)
						{
							BoolData.miao = (int)M;
						}
						Data1.Gold = BoolData.jingbi;
						Data1.Time = $"{S:00}" + ":" + $"{(int)M:00}";
						new Server().UploadPlayerInfos().Coroutine();
						T = 1;
					}
				}
				if (BoolData.j > 0)
				{
					for (int j = 0; j < BoolData.j && j < 5; j++)
					{
						base.transform.parent.GetChild(1).GetChild(j).gameObject.SetActive(value: true);
					}
				}
				else
				{
					for (int k = 0; k < 5; k++)
					{
						base.transform.parent.GetChild(1).GetChild(k).gameObject.SetActive(value: false);
					}
				}
				if (Input.GetKeyDown(KeyCode.T))
				{
					S++;
				}
				if (Input.GetKeyDown(KeyCode.M))
				{
					M += 10f;
					MonoBehaviour.print("面的状态:" + BoolData.ismian);
				}
				if (Input.GetKeyDown(KeyCode.K))
				{
					BoolData.j++;
				}
				if (TiggerManage.iscouse)
				{
					BoolData.IsCourse = true;
				}
				if (BoolData.IsGame)
				{
					BoolData.IsCourse = false;
				}
				if (BoolData.IsCourse)
				{
					BoolData.IsGame = false;
				}
				if (BoolData.IsGame && BoolData.shengli)
				{
					peoples.transform.GetChild(0).transform.GetChild(0).gameObject.SetActive(value: true);
					if (BoolData.IsCaster)
					{
						peoples.transform.GetChild(1).transform.GetChild(0).gameObject.SetActive(value: true);
					}
					if (S % 10 <= 4 && BoolData.IsCaster && S % 10 >= 2)
					{
						peoples.transform.GetChild(2).gameObject.SetActive(value: false);
						peoples.transform.GetChild(0).transform.GetChild(1).gameObject.SetActive(value: true);
						peoples.transform.GetChild(1).transform.GetChild(1).gameObject.SetActive(value: true);
					}
					if (S % 10 >= 4 && BoolData.IsCaster)
					{
						peoples.transform.GetChild(0).transform.GetChild(2).gameObject.SetActive(value: true);
						peoples.transform.GetChild(1).transform.GetChild(2).gameObject.SetActive(value: true);
					}
					diren.SetActive(value: true);
					if (S < 10)
					{
						if ((int)M < 10)
						{
							base.transform.GetChild(0).transform.GetComponent<Text>().text = "0" + S + ":0" + (int)M;
						}
						if ((int)M > 10)
						{
							base.transform.GetChild(0).transform.GetComponent<Text>().text = "0" + S + ":" + (int)M;
						}
					}
					if (S >= 10)
					{
						if ((int)M < 10)
						{
							base.transform.GetChild(0).transform.GetComponent<Text>().text = S + ":0" + (int)M;
						}
						if ((int)M > 10)
						{
							base.transform.GetChild(0).transform.GetComponent<Text>().text = S + ":" + (int)M;
						}
					}
					if (!istime)
					{
						if ((int)M < 60)
						{
							F++;
							M += Time.deltaTime;
						}
						if ((int)M >= 60)
						{
							S++;
							F = 0;
							M = 0f;
						}
						BoolData.timess = S;
						BoolData.miaos = (int)M;
					}
					if (BoolData.IsGame && S >= T * 10)
					{
						if (T == 1)
						{
							BoolData.Boos.isfirstBoos = true;
						}
						else
						{
							BoolData.Boos.isfirstBoos = false;
							PlayerAtack.kaihsil = true;
						}
						T++;
						istime = true;
						iswhilt = true;
						BoolData.Boos.times++;
						BoolData.shengli = false;
						BoolData.Change.T = T;
						BoolData.Change.ists = false;
						Invoke("change", 3f);
						lookboss.isjinbi = false;
					}
					if (S % 10 == 9 && (int)M > 55)
					{
						tu.transform.parent.GetChild(1).gameObject.SetActive(value: true);
						texiao.SetActive(value: true);
					}
					if (S % 10 == 0 && S != 0)
					{
						texiao.SetActive(value: false);
						tu.transform.parent.GetChild(1).gameObject.SetActive(value: false);
					}
				}
				if ((BoolData.j == 5 || BoolData.n == 5) && !Backs)
				{
					Invoke("noVEC", 8f);
				}
			}

			private void noVEC()
			{
				for (int i = 0; i < 3; i++)
				{
					peoples.transform.GetChild(0).transform.GetChild(i).gameObject.SetActive(value: false);
					peoples.transform.GetChild(1).transform.GetChild(i).gameObject.SetActive(value: false);
				}
			}

			private void change()
			{
				SceneManager.LoadScene(2);
			}

			private void xiaoshisas()
			{
				ButtonScript.gongkaiUI[2].transform.GetChild(5).transform.gameObject.SetActive(value: false);
			}
		}
		public class youshao : MonoBehaviour
		{
			public GameObject BUT;

			public GameObject yinxiao;

			private GameObject shenying;

			private GameObject shenying2;

			private GameObject A;

			private GameObject AllProp;

			private bool ischang;

			private void Start()
			{
				AllProp = GameObject.Find("AllProp");
			}

			private void Update()
			{
				if (!BoolData.isyoushao && base.transform.name == "汤匙")
				{
					A = UnityEngine.Object.Instantiate(base.transform.gameObject, base.transform.position, base.transform.rotation);
					A.transform.GetChild(1).GetComponent<MeshRenderer>().enabled = true;
					A.transform.GetChild(1).GetComponent<MeshCollider>().enabled = true;
					A.transform.GetComponent<BoxCollider>().enabled = true;
					A.transform.GetComponent<Rigidbody>().isKinematic = false;
					A.transform.GetComponent<Rigidbody>().useGravity = true;
					A.transform.GetComponent<HVRGrabbable>().enabled = true;
					A.transform.gameObject.isStatic = false;
					BoolData.DD = A;
					BoolData.isyoushao = true;
					A.transform.SetParent(AllProp.transform);
				}
			}

			private void OnTriggerExit(Collider other)
			{
				if (other.tag == "碰撞盒子")
				{
					if (!ischang)
					{
						UnityEngine.Object.Destroy(base.transform.gameObject, 5f);
						base.transform.GetComponent<HVRGrabbable>().enabled = false;
						BoolData.isyoushao = false;
						ischang = true;
						base.transform.parent = null;
					}
					Invoke("pengzhuang", 0.2f);
				}
			}

			private void OnCollisionEnter(Collision collision)
			{
				if (collision.gameObject.tag == "内地面")
				{
					UnityEngine.Object.Destroy(base.transform.gameObject);
					BoolData.isyoushao = false;
				}
			}

			private void pengzhuang()
			{
				ischang = false;
			}
		}
		public class FriedDoufu : MonoBehaviour
		{
			private GameObject A;

			private void OnTriggerEnter(Collider other)
			{
				if (other.tag == "碗")
				{
					A = other.gameObject;
					other.transform.GetComponent<MeshRenderer>().enabled = false;
					other.transform.GetChild(0).transform.gameObject.SetActive(value: true);
					other.tag = "装盘豆腐";
					UnityEngine.Object.Destroy(base.transform.gameObject);
				}
				if (other.tag == "碗2")
				{
					other.transform.GetComponent<MeshRenderer>().enabled = false;
					other.transform.GetChild(0).transform.gameObject.SetActive(value: true);
					other.tag = "装盘豆腐";
					UnityEngine.Object.Destroy(base.transform.gameObject);
				}
				if (other.tag == "碗3")
				{
					other.transform.GetComponent<MeshRenderer>().enabled = false;
					other.transform.GetChild(0).transform.gameObject.SetActive(value: true);
					other.tag = "装盘豆腐";
					UnityEngine.Object.Destroy(base.transform.gameObject);
				}
			}
		}
		public class FriedMian : MonoBehaviour
		{
			private Vector3 pos;

			private Quaternion Rote;

			private GameObject A;

			private GameObject AllProp;

			private GameObject B;

			private bool ischang;

			public void Start()
			{
				pos = base.transform.position;
				Rote = base.transform.rotation;
				AllProp = GameObject.Find("AllProp");
			}

			private void Update()
			{
				if (Input.GetKeyDown(KeyCode.M))
				{
					BoolData.ismian = false;
				}
				if (!BoolData.ismian && base.transform.name == "锅中米粉")
				{
					A = UnityEngine.Object.Instantiate(base.transform.gameObject, base.transform.position, base.transform.rotation, base.transform.parent);
					A.transform.GetComponent<MeshRenderer>().enabled = true;
					A.transform.GetComponent<MeshCollider>().enabled = true;
					A.transform.GetComponent<BoxCollider>().enabled = true;
					A.transform.GetComponent<HVRGrabbable>().enabled = true;
					A.transform.GetComponent<Rigidbody>().isKinematic = false;
					A.transform.GetComponent<Rigidbody>().useGravity = true;
					A.transform.gameObject.isStatic = false;
					BoolData.ismian = true;
					A.transform.SetParent(AllProp.transform);
				}
			}

			private void OnTriggerEnter(Collider other)
			{
				if (other.tag == "碗" && !other.transform.GetComponent<LIkai>().isones)
				{
					if (BoolData.IsCourse && (BoolData.Course == 0 || BoolData.Course == 4))
					{
						ButtonScript.gongkaiUI[2].transform.GetChild(0).GetChild(0).gameObject.SetActive(value: false);
						ButtonScript.gongkaiUI[2].transform.GetChild(0).GetChild(1).gameObject.SetActive(value: true);
					}
					other.transform.GetComponent<MeshRenderer>().enabled = false;
					other.transform.GetChild(2).transform.gameObject.SetActive(value: true);
					UnityEngine.Object.Destroy(base.transform.gameObject);
					BoolData.ismian = false;
					other.tag = "装盘面";
					Invoke("changess", 0.2f);
					other.transform.GetComponent<LIkai>().isones = true;
					B = other.gameObject;
				}
				if (other.tag == "碗2" && !other.transform.GetComponent<LIkai>().isones)
				{
					if (BoolData.IsCourse && (BoolData.Course == 0 || BoolData.Course == 4))
					{
						ButtonScript.gongkaiUI[2].transform.GetChild(0).GetChild(0).gameObject.SetActive(value: false);
						ButtonScript.gongkaiUI[2].transform.GetChild(0).GetChild(1).gameObject.SetActive(value: true);
					}
					other.transform.GetComponent<MeshRenderer>().enabled = false;
					other.transform.GetChild(2).transform.gameObject.SetActive(value: true);
					UnityEngine.Object.Destroy(base.transform.gameObject);
					BoolData.ismian = false;
					other.tag = "装盘面";
					Invoke("changess", 0.2f);
					other.transform.GetComponent<LIkai>().isones = true;
					B = other.gameObject;
				}
				if (other.tag == "碗3" && !other.transform.GetComponent<LIkai>().isones)
				{
					if (BoolData.IsCourse && (BoolData.Course == 0 || BoolData.Course == 4))
					{
						ButtonScript.gongkaiUI[2].transform.GetChild(0).GetChild(0).gameObject.SetActive(value: false);
						ButtonScript.gongkaiUI[2].transform.GetChild(0).GetChild(1).gameObject.SetActive(value: true);
					}
					other.transform.GetComponent<MeshRenderer>().enabled = false;
					other.transform.GetChild(2).transform.gameObject.SetActive(value: true);
					UnityEngine.Object.Destroy(base.transform.gameObject);
					BoolData.ismian = false;
					other.tag = "装盘面";
					Invoke("changess", 0.2f);
					other.transform.GetComponent<LIkai>().isones = true;
					B = other.gameObject;
				}
			}

			private void changess()
			{
				B.transform.GetComponent<LIkai>().isones = false;
			}

			private void OnCollisionEnter(Collision collision)
			{
				if (collision.gameObject.tag == "内地面")
				{
					UnityEngine.Object.Destroy(base.transform.gameObject);
					BoolData.ismian = false;
				}
			}

			private void OnTriggerExit(Collider other)
			{
				if (other.tag == "碰撞盒子")
				{
					if (!ischang && base.transform.name != "OUT")
					{
						base.transform.name = "OUT";
						UnityEngine.Object.Destroy(base.transform.gameObject, 5f);
						base.transform.GetComponent<HVRGrabbable>().enabled = false;
						BoolData.ismian = false;
						ischang = true;
					}
					Invoke("pengzhuang", 0.2f);
				}
			}

			private void pengzhuang()
			{
				ischang = false;
			}
		}
		public class FriedTangyouBaBa : MonoBehaviour
		{
			private void OnTriggerEnter(Collider other)
			{
				if (other.tag == "碗")
				{
					other.transform.GetComponent<MeshRenderer>().enabled = false;
					other.transform.GetChild(3).transform.gameObject.SetActive(value: true);
					other.tag = "成品糖油粑粑";
					UnityEngine.Object.Destroy(base.transform.gameObject);
					other.transform.GetChild(4).transform.gameObject.SetActive(value: true);
				}
				if (other.tag == "碗2")
				{
					other.transform.GetComponent<MeshRenderer>().enabled = false;
					other.transform.GetChild(3).transform.gameObject.SetActive(value: true);
					other.tag = "成品糖油粑粑";
					UnityEngine.Object.Destroy(base.transform.gameObject);
					other.transform.GetChild(4).transform.gameObject.SetActive(value: true);
				}
				if (other.tag == "碗3")
				{
					other.transform.GetComponent<MeshRenderer>().enabled = false;
					other.transform.GetChild(3).transform.gameObject.SetActive(value: true);
					other.tag = "成品糖油粑粑";
					UnityEngine.Object.Destroy(base.transform.gameObject);
					other.transform.GetChild(4).transform.gameObject.SetActive(value: true);
				}
			}
		}
		public class FriedXiangChang : MonoBehaviour
		{
			private void OnTriggerEnter(Collider other)
			{
				if (other.tag == "碗")
				{
					other.transform.GetComponent<MeshRenderer>().enabled = false;
					other.transform.GetChild(1).transform.gameObject.SetActive(value: true);
					other.tag = "装盘香肠";
					UnityEngine.Object.Destroy(base.transform.gameObject);
				}
				if (other.tag == "碗2")
				{
					other.transform.GetComponent<MeshRenderer>().enabled = false;
					other.transform.GetChild(1).transform.gameObject.SetActive(value: true);
					other.tag = "装盘香肠";
					UnityEngine.Object.Destroy(base.transform.gameObject);
				}
				if (other.tag == "碗3")
				{
					other.transform.GetComponent<MeshRenderer>().enabled = false;
					other.transform.GetChild(1).transform.gameObject.SetActive(value: true);
					other.tag = "装盘香肠";
					UnityEngine.Object.Destroy(base.transform.gameObject);
				}
			}
		}
		public class Hand : MonoBehaviour
		{
			public Transform follow;

			public Rigidbody body;

			public Vector3[] velocityOverTime = new Vector3[5];

			protected float startDrag;

			internal Transform moveTo;

			public float maxFollowDistance = 0.75f;

			public float maxVelocity = 4f;

			public float followPositionStrength = 30f;

			public bool left;

			public Vector3 followPositionOffset;

			public float followRotationStrength = 30f;

			private void Start()
			{
				startDrag = body.drag;
				moveTo = new GameObject().transform;
				moveTo.transform.parent = base.transform.parent;
				moveTo.name = "HAND FOLLOW POINT";
			}

			public void FixedUpdate()
			{
				UpdateMoveTo();
				MoveTo();
				TorqueTo();
				for (int i = 1; i < velocityOverTime.Length; i++)
				{
					velocityOverTime[i] = velocityOverTime[i - 1];
				}
				velocityOverTime[0] = body.velocity;
			}

			internal virtual void MoveTo()
			{
				Vector3 position = moveTo.position;
				float num = Vector3.Distance(position, base.transform.position);
				float fixedDeltaTime = Time.fixedDeltaTime;
				if (num <= fixedDeltaTime)
				{
					body.drag = Mathf.Lerp(startDrag, startDrag * 2f, 1f - num / fixedDeltaTime);
				}
				else
				{
					body.drag = startDrag;
				}
				if (num > maxFollowDistance)
				{
					base.transform.position = position;
				}
				float num2 = maxVelocity;
				Vector3 velocity = (position - base.transform.position).normalized * followPositionStrength * num;
				velocity.x = Mathf.Clamp(velocity.x, 0f - num2, num2);
				velocity.y = Mathf.Clamp(velocity.y, 0f - num2, num2);
				velocity.z = Mathf.Clamp(velocity.z, 0f - num2, num2);
				body.velocity = velocity;
			}

			internal virtual void TorqueTo()
			{
				Quaternion rotation = moveTo.rotation;
				float value = Quaternion.Angle(body.rotation, rotation);
				Quaternion quaternion = Quaternion.Lerp(body.rotation, rotation, Mathf.Clamp(value, 0f, 2f) / 4f);
				float num = 90f * followRotationStrength;
				float num2 = 60f;
				(quaternion * Quaternion.Inverse(base.transform.rotation)).ToAngleAxis(out var angle, out var axis);
				axis.Normalize();
				axis *= (float)Math.PI / 180f;
				Vector3 vector = num * axis * angle - num2 * body.angularVelocity;
				Quaternion quaternion2 = body.inertiaTensorRotation * base.transform.rotation;
				vector = Quaternion.Inverse(quaternion2) * vector;
				vector.Scale(body.inertiaTensor);
				vector = quaternion2 * vector;
				body.AddTorque(vector);
			}

			protected virtual void UpdateMoveTo()
			{
				moveTo.position = follow.position + base.transform.rotation * followPositionOffset;
				moveTo.rotation = follow.rotation;
			}

			public virtual Vector3 ThrowVelocity()
			{
				Vector3 zero = Vector3.zero;
				for (int i = 0; i < velocityOverTime.Length; i++)
				{
					zero += velocityOverTime[i];
				}
				return zero / velocityOverTime.Length;
			}
		}
		public class Hezi : MonoBehaviour
		{
			private bool ischu;

			private void Start()
			{
			}

			private void Update()
			{
			}

			private void OnTriggerExit(Collider other)
			{
				if (ischu)
				{
					return;
				}
				if (other.transform.childCount != 0)
				{
					if (other.transform.GetChild(0).tag == "碗")
					{
						UnityEngine.Object.Destroy(other.gameObject, 5f);
						other.transform.GetComponent<HVRGrabbable>().enabled = false;
						BoolData.isIns = true;
					}
					if (other.transform.GetChild(0).tag == "大碗")
					{
						BoolData.isTrue = true;
						other.transform.GetComponent<HVRGrabbable>().enabled = false;
						UnityEngine.Object.Destroy(other.gameObject, 5f);
					}
					if (other.transform.GetChild(0).tag == "小碗")
					{
						other.transform.GetComponent<HVRGrabbable>().enabled = false;
						BoolData.isTheer = true;
						UnityEngine.Object.Destroy(other.gameObject, 5f);
					}
				}
				if (other.transform.tag == "面")
				{
					other.transform.GetComponent<HVRGrabbable>().enabled = false;
					BoolData.ismian = false;
					UnityEngine.Object.Destroy(other.gameObject, 5f);
				}
				ischu = true;
				Invoke("xiaoshi", 0.1f);
			}

			private void xiaoshi()
			{
				ischu = false;
			}
		}
		public class BoosScript : MonoBehaviour
		{
			private bool zhuangtai;

			private bool ischange;

			private void Start()
			{
				BoolData.Change.ists = false;
				Invoke("kaishi", 5f);
			}

			private void Update()
			{
			}

			private void kaishi()
			{
				if (!zhuangtai)
				{
					base.transform.GetChild(6).gameObject.SetActive(value: true);
					Invoke("fashe", 3f);
				}
			}

			private void fashe()
			{
				BoolData.Boos.iszhunbei = true;
				base.transform.GetChild(6).gameObject.SetActive(value: false);
				Invoke("kaishi", 2f);
			}
		}
		public class Du : MonoBehaviour
		{
			public GameObject yinxiao;

			private GameObject A;

			private void Start()
			{
			}

			private void Update()
			{
			}

			private void OnTriggerEnter(Collider other)
			{
				if (other.tag == "子弹")
				{
					UnityEngine.Object.Destroy(base.transform.gameObject);
				}
				if (other.tag == "地点3")
				{
					UnityEngine.Object.Destroy(base.transform.gameObject);
				}
				if (other.tag == "Player")
				{
					A = UnityEngine.Object.Instantiate(yinxiao.gameObject, base.transform.position, base.transform.rotation);
					A.SetActive(value: true);
					UnityEngine.Object.Destroy(A.gameObject, 5f);
					MonoBehaviour.print("被打到了");
					UnityEngine.Object.Destroy(base.transform.gameObject);
					BoolData.jingbi -= 5;
				}
			}
		}
		public class ButtonScript : MonoBehaviour
		{
			public GameObject[] UI;

			public static GameObject[] gongkaiUI;

			public GameObject Content;

			public GameObject Item;

			private GameObject didians;

			private GameObject zongdidian;

			public GameObject zanting;

			public static bool iscouse;

			private bool isstop;

			private bool isting;

			public static bool isjiaocheng;

			private bool istime;

			private Vector3 UIPos;

			public static bool isluren;

			private void Start()
			{
				UIPos = UI[0].transform.GetChild(0).GetChild(5).transform.position;
				gongkaiUI = new GameObject[10];
				for (int i = 0; i < UI.Length; i++)
				{
					gongkaiUI[i] = UI[i];
				}
				didians = GameObject.FindWithTag("总人物").gameObject;
				zongdidian = GameObject.FindWithTag("总地点").gameObject;
			}

			private void Update()
			{
				HVRController leftController = HVRInputManager.Instance.LeftController;
				HVRController rightController = HVRInputManager.Instance.RightController;
				if (isjiaocheng && (leftController.TriggerButtonState.Active || rightController.TriggerButtonState.Active || Input.GetKeyDown(KeyCode.P)))
				{
					BoolData.istimes = false;
					LIkai.fangxia = false;
					fanqie.istime = true;
					Rote.tingzhi = true;
					Times.istime = false;
					Times.istime = false;
					isjiaocheng = false;
					for (int i = 0; i < 5; i++)
					{
						if (UI[2].transform.GetChild(i).gameObject.activeSelf)
						{
							UI[2].transform.GetChild(i).GetChild(UI[2].transform.GetChild(i).childCount - 1).gameObject.SetActive(value: false);
						}
					}
				}
				if (isting)
				{
					didians.transform.GetChild(2).gameObject.SetActive(value: false);
				}
				if (!UI[0].transform.GetChild(0).GetChild(5).gameObject.activeSelf)
				{
					UI[0].transform.GetChild(0).GetChild(5).transform.position = UIPos;
				}
				if (Input.GetKeyDown(KeyCode.J))
				{
					kaishi();
				}
				if (Input.GetKeyDown(KeyCode.H))
				{
					fanhuizhucaidan();
				}
				if (Input.GetKeyDown(KeyCode.Q))
				{
					fanhui();
				}
				if (Input.GetKeyDown(KeyCode.A))
				{
					paihangbang();
				}
				if (Input.GetKeyDown(KeyCode.B))
				{
					jiaocheng();
				}
				if (Input.GetKeyDown(KeyCode.C))
				{
					jixu();
				}
				if (Input.GetKeyDown(KeyCode.D))
				{
					jixuyouxi();
				}
				if (Input.GetKey(KeyCode.V))
				{
					BoolData.jingbi += 100;
				}
				if (Input.GetKey(KeyCode.K))
				{
					BoolData.j++;
				}
				if (iscouse)
				{
					BoolData.IsCourse = true;
				}
				if (BoolData.PHB)
				{
					UI[0].transform.gameObject.SetActive(value: false);
				}
				if ((rightController.SecondaryButtonState.Active || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.Escape)) && !istime)
				{
					if (!isstop)
					{
						fanqie.k = 0f;
						istime = true;
						BoolData.istimes = true;
						LIkai.fangxia = true;
						fanqie.istime = false;
						Rote.tingzhi = false;
						Times.istime = true;
						if (BoolData.IsGame || BoolData.IsCourse)
						{
							zanting.SetActive(value: true);
						}
						isstop = true;
					}
					else
					{
						fanqie.k = 1f;
						LIkai.fangxia = false;
						istime = true;
						fanqie.istime = true;
						Time.timeScale = 1f;
						if (BoolData.IsGame)
						{
							Rote.tingzhi = true;
							BoolData.istimes = false;
						}
						Times.istime = false;
						zanting.SetActive(value: false);
						isstop = false;
					}
					Invoke("jieshu", 1f);
				}
				if ((BoolData.j >= 5 || BoolData.n >= 5) && BoolData.IsCourse)
				{
					MonoBehaviour.print("删除");
					for (int j = 0; j < UI[2].transform.childCount; j++)
					{
						UI[2].transform.GetChild(j).gameObject.SetActive(value: false);
					}
					isluren = true;
					BoolData.IsCourse = false;
				}
			}

			public void jiaocheng()
			{
				isluren = true;
				UI[0].transform.GetChild(0).GetChild(5).gameObject.SetActive(value: false);
				istime = false;
				isting = true;
				tishi.kaishi = 380f;
				UI[2].transform.GetChild(5).transform.gameObject.SetActive(value: true);
				UI[2].transform.GetChild(5).transform.GetComponent<TextEmerge>().forth();
				gongkai();
				for (int i = 0; i < 5; i++)
				{
					UI[2].transform.GetChild(i).GetChild(UI[2].transform.GetChild(i).childCount - 1).gameObject.SetActive(value: true);
				}
			}

			public void kaishi()
			{
				isting = true;
				UI[0].transform.GetChild(0).GetChild(5).gameObject.SetActive(value: false);
				istime = false;
				BoolData.isshangchuan = false;
				BoolData.istimes = false;
				BoolData.shengli = true;
				Rote.tingzhi = true;
				BoolData.Boos.shit = true;
				BoolData.Boos.shibai = false;
				Times.istime = false;
				BoolData.IsGame = true;
				BoolData.Ends = true;
				gongkai();
			}

			public void jixu()
			{
				isluren = false;
				isting = false;
				BoolData.IsCourse = true;
				iscouse = true;
				tishi.kaishi = -1f;
				didians.transform.GetChild(2).gameObject.SetActive(value: true);
				Invoke("xiaoshisas", 4f);
			}

			private void xiaoshisas()
			{
				UI[2].transform.GetChild(5).transform.gameObject.SetActive(value: false);
			}

			public void jixuyouxi()
			{
				zanting.SetActive(value: false);
				LIkai.fangxia = false;
				istime = true;
				fanqie.istime = true;
				if (BoolData.IsGame)
				{
					Rote.tingzhi = true;
					BoolData.istimes = false;
				}
				Times.istime = false;
				zanting.SetActive(value: false);
				isstop = false;
				Invoke("jieshu", 1f);
			}

			public void fanhuizhucaidan()
			{
				CancelInvoke();
				isluren = true;
				UI[2].transform.GetChild(5).transform.gameObject.SetActive(value: false);
				TextEmerge.TextInder = -1;
				BoolData.n = 5;
				fanqie.k = 1f;
				LIkai.fangxia = false;
				istime = true;
				fanqie.istime = true;
				Time.timeScale = 1f;
				if (BoolData.IsGame)
				{
					Rote.tingzhi = true;
					BoolData.istimes = false;
				}
				Times.istime = false;
				zanting.SetActive(value: false);
				isstop = false;
				UI[0].SetActive(value: true);
			}

			public void zhucaidan()
			{
				CancelInvoke();
				UI[2].transform.GetChild(5).transform.gameObject.SetActive(value: false);
				TextEmerge.TextInder = -1;
				BoolData.n = 5;
				BoolData.j = 5;
				istime = false;
				BoolData.isphb = false;
				BoolData.istimes = false;
				zanting.SetActive(value: false);
				LIkai.fangxia = false;
				istime = true;
				fanqie.istime = true;
				if (BoolData.IsGame)
				{
					Rote.tingzhi = true;
					BoolData.istimes = false;
				}
				Times.istime = false;
				zanting.SetActive(value: false);
				isstop = false;
				MonoBehaviour.print("111111111");
				BoolData.IsGame = false;
				iscouse = false;
				Times.S = 0;
				Times.M = 0f;
				Times.istime = true;
				BoolData.IsCaster = false;
				MonoBehaviour.print("222222");
				BoolData.Course = 0;
				BoolData.Boos.times = 0;
				for (int i = 0; i < UI[2].transform.childCount; i++)
				{
					UI[2].transform.GetChild(i).transform.gameObject.SetActive(value: false);
				}
				for (int j = 0; j < zongdidian.transform.childCount; j++)
				{
					zongdidian.transform.GetChild(j).GetComponent<BoxCollider>().enabled = false;
				}
				didians.transform.GetChild(2).gameObject.SetActive(value: false);
				UI[0].SetActive(value: true);
				zanting.SetActive(value: false);
				if (BoolData.jingbi > BoolData.jing)
				{
					BoolData.jing = BoolData.jingbi;
				}
				if (BoolData.timess > BoolData.shijian)
				{
					BoolData.shijian = BoolData.timess;
				}
				if (BoolData.timess == BoolData.shijian && BoolData.miaos > BoolData.miao)
				{
					BoolData.miao = BoolData.miaos;
				}
			}

			public void tuichu()
			{
				Application.Quit();
			}

			public void gongkai()
			{
				isluren = false;
				UI[0].transform.gameObject.SetActive(value: false);
				BoolData.end1 = true;
				BoolData.end2 = true;
				BoolData.end3 = true;
				BoolData.IsCourse = true;
				BoolData.j = 0;
				BoolData.n = 0;
				Times.kaishi = false;
				BoolData.jingbi = 0;
				BoolData.Change.T = 1;
				BoolData.Course = 0;
				Times.S = 0;
				Times.M = 0f;
				BoolData.OneBox = false;
				BoolData.TwoBox = false;
				BoolData.TherrBox = false;
				BoolData.OneWeizhi = false;
				BoolData.TowWeizhi = false;
				BoolData.ThreeWeizhi = false;
				didians.transform.GetChild(2).gameObject.SetActive(value: false);
				for (int i = 0; i < zongdidian.transform.childCount; i++)
				{
					zongdidian.transform.GetChild(i).GetComponent<BoxCollider>().enabled = true;
				}
				MonoBehaviour.print("开始了！！！！！！！！！！！！！");
			}

			public void paihangbang()
			{
				BoolData.PaiHB = true;
				BoolData.isphb = true;
				BoolData.PHB = true;
				UI[0].transform.gameObject.SetActive(value: false);
				UI[0].transform.GetChild(0).GetChild(5).gameObject.SetActive(value: false);
				UI[1].transform.GetChild(0).gameObject.SetActive(value: true);
				chakan();
			}

			public void fanhui()
			{
				BoolData.PaiHB = false;
				BoolData.isphb = false;
				BoolData.PHB = false;
				UI[0].transform.gameObject.SetActive(value: true);
				UI[1].transform.GetChild(0).gameObject.SetActive(value: false);
			}

			private void xiaoshissss()
			{
				didians.transform.GetChild(2).gameObject.SetActive(value: false);
				Invoke("luren", 0.5f);
			}

			private void jieshu()
			{
				istime = false;
			}

			private void luren()
			{
				isluren = false;
			}

			public async void chakan()
			{
				if (await new Server().GetPlayerInfos() == "获取成功")
				{
					paixu();
				}
			}

			private void paixu()
			{
				int Num = 1;
				for (int i = 0; i < Content.transform.childCount; i++)
				{
					UnityEngine.Object.Destroy(Content.transform.GetChild(i).gameObject);
				}
				string[] array = Data1.Infos.Split('|');
				Content.GetComponent<RectTransform>().sizeDelta = new Vector2(0f, 58f * (float)(array.Length - 1));
				List<string> list = new List<string>();
				for (int j = 1; j < array.Length; j++)
				{
					list.Add(array[j]);
				}
				list.OrderByDescending((string L) => float.Parse(L.Split('/')[1].Split('*')[1].Split('?')[0])).ToList().ForEach(delegate(string a)
				{
					string[] array2 = a.Split('/')[1].Split('*');
					string text = array2[0];
					string[] array3 = array2[1].Split('?');
					string text2 = array3[0];
					string text3 = array3[1];
					if (GameObject.FindGameObjectsWithTag("排行版子物体").Length <= 100)
					{
						GameObject obj = UnityEngine.Object.Instantiate(Item);
						obj.transform.SetParent(Content.transform, worldPositionStays: false);
						obj.GetComponent<Item>().Ranking = Num.ToString();
						obj.GetComponent<Item>().name = text;
						obj.GetComponent<Item>().Name = text;
						obj.GetComponent<Item>().Gold = text2;
						obj.GetComponent<Item>().Time = text3;
						obj.GetComponent<Item>().Change();
						UnityEngine.Debug.Log("玩家信息：Name:" + text + "    Gold:" + text2 + "     Score:" + text3);
					}
					Num++;
				});
			}
		}
		public class FoodBoxs : MonoBehaviour
		{
			public int i;

			private void Start()
			{
			}

			private void Update()
			{
				if (base.transform.childCount > this.i + 3)
				{
					for (int i = this.i + 3; i < base.transform.childCount; i++)
					{
						UnityEngine.Object.Destroy(base.transform.GetChild(i).gameObject);
					}
				}
			}
		}
		public class Panzi : MonoBehaviour
		{
			public static bool[] panzi1;

			public static bool[] panzi2;

			public static bool[] panzi3;

			public GameObject Prop;

			private void Start()
			{
				panzi1 = new bool[4];
				panzi2 = new bool[4];
				panzi3 = new bool[4];
			}

			private void Update()
			{
				if (BoolData.end1)
				{
					for (int i = 0; i < 4; i++)
					{
						panzi1[i] = false;
					}
					BoolData.end1 = false;
				}
				if (BoolData.end2)
				{
					for (int j = 0; j < 4; j++)
					{
						panzi2[j] = false;
					}
					BoolData.end2 = false;
				}
				if (BoolData.end3)
				{
					for (int k = 0; k < 4; k++)
					{
						panzi3[k] = false;
					}
					BoolData.end3 = false;
				}
			}

			private void OnTriggerEnter(Collider other)
			{
				for (int i = 1; i < 4; i++)
				{
					if (!(base.transform.tag == "盘子" + i))
					{
						continue;
					}
					if (other.tag == "成品糖油粑粑")
					{
						switch (i)
						{
						case 1:
							panzi1[2] = true;
							MonoBehaviour.print("panzi12" + panzi1[2]);
							break;
						case 2:
							panzi2[2] = true;
							MonoBehaviour.print("panzi22" + panzi2[2]);
							break;
						case 3:
							panzi3[2] = true;
							MonoBehaviour.print("panzi32" + panzi3[2]);
							break;
						}
						other.transform.SetParent(base.transform);
					}
					if (other.tag == "成品臭豆腐")
					{
						switch (i)
						{
						case 1:
							panzi1[3] = true;
							MonoBehaviour.print("panzi13" + panzi1[3]);
							break;
						case 2:
							panzi2[3] = true;
							MonoBehaviour.print("panzi23" + panzi2[3]);
							break;
						case 3:
							panzi3[3] = true;
							MonoBehaviour.print("panzi33" + panzi3[3]);
							break;
						}
						other.transform.SetParent(base.transform);
					}
					if (other.tag == "成品炸香肠")
					{
						switch (i)
						{
						case 1:
							panzi1[1] = true;
							MonoBehaviour.print("panzi11" + panzi1[1]);
							break;
						case 2:
							panzi2[1] = true;
							MonoBehaviour.print("panzi21" + panzi2[1]);
							break;
						case 3:
							panzi3[1] = true;
							MonoBehaviour.print("panzi31" + panzi3[1]);
							break;
						}
						other.transform.SetParent(base.transform);
					}
					if (other.tag == "成品拌面")
					{
						switch (i)
						{
						case 1:
							panzi1[0] = true;
							MonoBehaviour.print("panzi10" + panzi1[0]);
							break;
						case 2:
							panzi2[0] = true;
							MonoBehaviour.print("panzi20" + panzi2[0]);
							break;
						case 3:
							panzi3[0] = true;
							MonoBehaviour.print("panzi30" + panzi3[0]);
							break;
						}
						other.transform.SetParent(base.transform);
					}
				}
			}

			private void OnTriggerExit(Collider other)
			{
				for (int i = 1; i < 4; i++)
				{
					if (!(base.transform.tag == "盘子" + i))
					{
						continue;
					}
					if (other.tag == "成品糖油粑粑")
					{
						other.transform.SetParent(Prop.transform);
						switch (i)
						{
						case 1:
							panzi1[2] = false;
							MonoBehaviour.print("panzi12" + panzi1[2]);
							break;
						case 2:
							panzi2[2] = false;
							MonoBehaviour.print("panzi22" + panzi2[2]);
							break;
						case 3:
							panzi3[2] = false;
							MonoBehaviour.print("panzi32" + panzi3[2]);
							break;
						}
					}
					if (other.tag == "成品臭豆腐")
					{
						other.transform.SetParent(Prop.transform);
						switch (i)
						{
						case 1:
							panzi1[3] = false;
							MonoBehaviour.print("panzi13" + panzi1[3]);
							break;
						case 2:
							panzi2[3] = false;
							MonoBehaviour.print("panzi23" + panzi2[3]);
							break;
						case 3:
							panzi3[3] = false;
							MonoBehaviour.print("panzi33" + panzi3[3]);
							break;
						}
					}
					if (other.tag == "成品炸香肠")
					{
						other.transform.SetParent(Prop.transform);
						switch (i)
						{
						case 1:
							panzi1[1] = false;
							MonoBehaviour.print("panzi11" + panzi1[1]);
							break;
						case 2:
							panzi2[1] = false;
							MonoBehaviour.print("panzi21" + panzi2[1]);
							break;
						case 3:
							panzi3[1] = false;
							MonoBehaviour.print("panzi31" + panzi3[1]);
							break;
						}
					}
					if (other.tag == "成品拌面")
					{
						other.transform.SetParent(Prop.transform);
						switch (i)
						{
						case 1:
							panzi1[0] = false;
							MonoBehaviour.print("panzi10" + panzi1[0]);
							break;
						case 2:
							panzi2[0] = false;
							MonoBehaviour.print("panzi20" + panzi2[0]);
							break;
						case 3:
							panzi3[0] = false;
							MonoBehaviour.print("panzi30" + panzi3[0]);
							break;
						}
					}
					if (!other.transform.GetComponent<HVRGrabbable>().enabled)
					{
						UnityEngine.Object.Destroy(other.transform.gameObject);
					}
				}
			}
		}
		public class RayCast : MonoBehaviour
		{
			private void Start()
			{
			}

			private void Update()
			{
				new Ray(base.transform.position, base.transform.forward);
				if (Physics.Raycast(base.transform.position, base.transform.forward, out var hitInfo, 100f))
				{
					UnityEngine.Debug.DrawLine(base.transform.transform.position, hitInfo.point, Color.blue);
					UnityEngine.Debug.DrawLine(base.transform.position, base.transform.parent.forward, Color.red);
				}
				else
				{
					UnityEngine.Debug.DrawLine(base.transform.position, base.transform.parent.forward, Color.red);
				}
			}
		}
		public class TextEmerge : MonoBehaviour
		{
			public Text obj;

			[TextArea]
			public string[] text;

			public float dt = 0.05f;

			public float showingTime = 2f;

			public static int TextInder = -1;

			public AudioClip[] sound;

			public UnityEvent SessionEnd = new UnityEvent();

			private void Start()
			{
			}

			private void Update()
			{
				if (Input.GetKeyDown(KeyCode.E))
				{
					forth();
				}
				if (Input.GetKeyDown(KeyCode.F))
				{
					rear();
				}
			}

			public void forth()
			{
				if (TextInder < text.Length - 1)
				{
					StopAllCoroutines();
					TextInder++;
					Play(text[TextInder]);
				}
				else
				{
					TextInder = -1;
					SessionEnd.Invoke();
					base.gameObject.SetActive(value: false);
				}
			}

			public void rear()
			{
				if (TextInder > 0)
				{
					StopAllCoroutines();
					TextInder--;
					Play(text[TextInder]);
				}
			}

			public void Play(string text)
			{
				StartCoroutine(Typing(text));
			}

			private IEnumerator Typing(string text)
			{
				float Startime = Time.time;
				float dTime = Time.time;
				int index = 0;
				int a2 = 0;
				bool start = false;
				if (!this.obj)
				{
					yield break;
				}
				while (index < text.Length || a2 < 255)
				{
					this.obj.text = "";
					float num = 256f / ((float)index * showingTime);
					float num2 = (Time.time - Startime) * num;
					for (int i = 0; i <= index && i < text.Length; i++)
					{
						a2 = (int)(num2 * (float)(index - i));
						a2 = Mathf.Clamp(a2, 0, 255);
						if (a2 == 255 && i == 0 && !start)
						{
							Text obj = this.obj;
							obj.text = obj.text + "<color=#" + ColorToHex(this.obj.color) + "ff>";
							start = true;
						}
						if (a2 == 255 && start)
						{
							this.obj.text += text[i];
							continue;
						}
						if (a2 != 255 && start)
						{
							start = false;
							this.obj.text += "</color>";
						}
						string text2 = Convert.ToString(a2, 16);
						text2 = ((text2.Length == 1) ? "0" : "") + text2;
						Text text3 = this.obj;
						text3.text = text3.text + "<color=#" + ColorToHex(this.obj.color) + text2 + ">" + text[i] + "</color>";
					}
					if (a2 == 255 && start)
					{
						this.obj.text += "</color>";
					}
					if (Time.time - dTime >= dt)
					{
						dTime = Time.time;
						index++;
					}
					yield return 0;
				}
			}

			private string ColorToHex(Color color)
			{
				int num = Mathf.RoundToInt(color.r * 255f);
				int num2 = Mathf.RoundToInt(color.g * 255f);
				int num3 = Mathf.RoundToInt(color.b * 255f);
				Mathf.RoundToInt(color.a * 255f);
				return $"{num:X2}{num2:X2}{num3:X2}";
			}
		}
		public class UIScript : MonoBehaviour
		{
			private bool isxiao;

			private float s = 1f;

			public GameObject shengying;

			public GameObject shexian;

			private void Start()
			{
				Invoke("xiaoshi", 6f);
			}

			private void Update()
			{
				if (isxiao)
				{
					s -= 0.01f;
					base.transform.GetChild(1).GetComponent<RawImage>().color = new Color(0f, 0f, 0f, s);
				}
			}

			private void ends()
			{
				isxiao = true;
				Invoke("bofang", 2f);
				Invoke("xiaoshi", 5f);
			}

			private void xiaoshi()
			{
				SceneManager.LoadScene("城市街道");
			}

			private void bofang()
			{
				shexian.SetActive(value: true);
				shengying.SetActive(value: true);
			}
		}
		public class aaaa : MonoBehaviour
		{
			public float time = 3f;

			public Transform pointA;

			public Transform pointB;

			public float g = -10f;

			private Vector3 speed;

			private Vector3 Gravity;

			private GameObject A;

			private GameObject B;

			private GameObject M;

			private bool iskaishi;

			private int i;

			private float dTime;

			private void Start()
			{
				B = GameObject.FindWithTag("Player").gameObject;
				MonoBehaviour.print("B" + B.name);
				pointB = B.transform.GetChild(0).GetChild(0).GetChild(0)
					.GetChild(0)
					.GetChild(0)
					.transform;
				pointA = base.transform;
				base.transform.position = pointA.position;
				speed = new Vector3((pointB.position.x - pointA.position.x) / time, (pointB.position.y - pointA.position.y) / time - 0.5f * g * time, (pointB.position.z - pointA.position.z) / time);
				Gravity = Vector3.zero;
			}

			private void FixedUpdate()
			{
				Gravity.y = g * (dTime += Time.fixedDeltaTime);
				base.transform.Translate(speed * Time.fixedDeltaTime);
				base.transform.Translate(Gravity * Time.fixedDeltaTime);
			}

			private void Update()
			{
			}

			private void OnTriggerEnter(Collider other)
			{
				if (other.tag == "MainCamera")
				{
					GameObject obj = UnityEngine.Object.Instantiate(other.transform.GetChild(6).gameObject, other.transform.position, other.transform.rotation, other.transform);
					obj.SetActive(value: true);
					UnityEngine.Object.Destroy(base.transform.gameObject);
					UnityEngine.Object.Destroy(obj, 3f);
				}
			}
		}
		public class bbbb : MonoBehaviour
		{
			public float time = 3f;

			public Transform pointA;

			public Transform pointB;

			public float g = -10f;

			private Vector3 speed;

			private Vector3 Gravity;

			private GameObject A;

			private GameObject B;

			private float dTime;

			private void Start()
			{
				B = GameObject.FindWithTag("Player").transform.GetChild(1).transform.GetChild(6).gameObject;
				MonoBehaviour.print("B" + B.name);
				pointB = B.transform;
				pointA = base.transform;
				base.transform.position = pointA.position;
				speed = new Vector3((pointB.position.x - pointA.position.x) / time, (pointB.position.y - pointA.position.y) / time - 0.5f * g * time, (pointB.position.z - pointA.position.z) / time);
				Gravity = Vector3.zero;
			}

			private void FixedUpdate()
			{
				Gravity.y = g * (dTime += Time.fixedDeltaTime);
				base.transform.Translate(speed * Time.fixedDeltaTime);
				base.transform.Translate(Gravity * Time.fixedDeltaTime);
			}
		}
		public class fanqie : MonoBehaviour
		{
			public GameObject A;

			public GameObject C;

			public GameObject UIs;

			public GameObject MainUI;

			private Text timess;

			private GameObject B;

			private bool ismove = true;

			private bool ischange;

			private bool change2;

			public static bool istime;

			private Quaternion Rote;

			private float i = 60f;

			public static float k = 1f;

			private void Start()
			{
				timess = base.transform.parent.GetChild(3).GetChild(0).GetComponent<Text>();
			}

			private void Update()
			{
				if (BoolData.IsGame)
				{
					if (istime)
					{
						i -= Time.deltaTime;
						if (i > 0f)
						{
							timess.text = ((int)i).ToString();
						}
					}
				}
				else
				{
					timess.text = " ";
				}
				if (i == 0f)
				{
					if (BoolData.IsCourse)
					{
						BoolData.jingbi = 0;
						BoolData.j = 0;
						BoolData.IsCourse = false;
						TiggerManage.iscouse = false;
						UIs.SetActive(value: false);
						MainUI.SetActive(value: true);
					}
					if (BoolData.IsGame)
					{
						BoolData.jingbi -= 50;
						BoolData.istrues = true;
					}
					UnityEngine.Object.Destroy(base.transform.parent.transform.gameObject);
				}
				if (BoolData.fanqie)
				{
					istime = true;
					B = UnityEngine.Object.Instantiate(A, base.transform.position, Quaternion.identity, base.transform);
					BoolData.fanqie = false;
				}
				_ = Rote;
				base.transform.parent.transform.rotation = Quaternion.Slerp(base.transform.parent.transform.rotation, Rote, Time.deltaTime);
				if (ismove)
				{
					base.transform.parent.transform.position = Vector3.MoveTowards(base.transform.parent.transform.position, C.transform.position, Time.deltaTime * k);
				}
				if (!(base.transform.parent.transform.position == C.transform.position))
				{
					return;
				}
				if (!ischange && BoolData.IsCourse)
				{
					UIs.SetActive(value: true);
					ButtonScript.isjiaocheng = true;
					ischange = true;
				}
				if (!change2 && BoolData.IsCourse && !ButtonScript.isjiaocheng)
				{
					ismove = false;
					Rote = Quaternion.Euler(0f, 45f, 0f);
					Invoke("shencheng", 1f);
					change2 = true;
				}
				if (!ischange && i > 0f)
				{
					if (BoolData.IsCourse)
					{
						UIs.SetActive(value: true);
						ButtonScript.isjiaocheng = true;
					}
					ismove = false;
					Rote = Quaternion.Euler(0f, 45f, 0f);
					Invoke("shencheng", 1f);
					ischange = true;
				}
			}

			private void shencheng()
			{
				base.transform.parent.transform.GetComponent<Animator>().SetBool("IsGo", value: true);
				MonoBehaviour.print("famqiefamqiefmaqie");
				Invoke("DIU", 1f);
			}

			private void DIU()
			{
				base.transform.parent.transform.GetComponent<Animator>().SetBool("IsGo", value: false);
				base.transform.parent.transform.GetComponent<Animator>().SetBool("isAtack", value: true);
				Invoke("fanqies", 0.5f);
			}

			private void fanqies()
			{
				BoolData.fanqie = true;
				Invoke("changes", 1f);
			}

			private void changes()
			{
				base.transform.parent.transform.GetComponent<Animator>().SetBool("IsGo", value: true);
				base.transform.parent.transform.GetComponent<Animator>().SetBool("isAtack", value: false);
				Invoke("DIU", 6f);
			}
		}
		public class kuaizi : MonoBehaviour
		{
			private void Start()
			{
			}

			private void Update()
			{
			}
		}
		public class li : MonoBehaviour
		{
			private void Start()
			{
				Vector3 force = new Vector3(100f, 0f, 100f);
				base.transform.GetComponent<Rigidbody>().AddForce(force);
			}

			private void Update()
			{
			}
		}
		public class speed : MonoBehaviour
		{
			public GameObject[] texiao;

			private void Start()
			{
				Invoke("ends", 0.1f);
			}

			private void Update()
			{
			}

			private void ends()
			{
				texiao[0].SetActive(value: true);
				texiao[2].SetActive(value: true);
				Invoke("kaishi", 1f);
				Invoke("end", 1.5f);
			}

			private void kaishi()
			{
				texiao[3].SetActive(value: true);
			}

			private void end()
			{
				texiao[1].SetActive(value: true);
			}

			private void again()
			{
				for (int i = 0; i < texiao.Length; i++)
				{
					texiao[i].SetActive(value: false);
				}
				Invoke("ends", 1f);
			}
		}
		public class FTEM_AnimationScrollTexture : MonoBehaviour
		{
			private void Start()
			{
			}

			private void Update()
			{
			}
		}
		public class FTEM_AnimationSpriteSheet : MonoBehaviour
		{
			private void Start()
			{
			}

			private void Update()
			{
			}
		}
		public class FTEM_DeadTime : MonoBehaviour
		{
			public float deadTime;

			private void Awake()
			{
				UnityEngine.Object.Destroy(base.gameObject, deadTime);
			}

			private void Update()
			{
			}
		}
		public class FTEM_SampleSceneGUI : MonoBehaviour
		{
			public Text prefabName;

			public GameObject[] particlePrefab;

			public int particleNum;

			private GameObject effectPrefab;

			private void Start()
			{
			}

			private void Update()
			{
				if (Input.GetMouseButtonDown(0))
				{
					RaycastHit hitInfo2;
					if (particleNum < 3)
					{
						if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out var hitInfo, 1000f))
						{
							effectPrefab = UnityEngine.Object.Instantiate(particlePrefab[particleNum], new Vector3(hitInfo.point.x, hitInfo.point.y + 3f, hitInfo.point.z), Quaternion.Euler(0f, 0f, 0f));
						}
					}
					else if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo2, 1000f))
					{
						effectPrefab = UnityEngine.Object.Instantiate(particlePrefab[particleNum], new Vector3(hitInfo2.point.x, hitInfo2.point.y, hitInfo2.point.z), Quaternion.Euler(0f, 0f, 0f));
					}
				}
				if (Input.GetKeyDown(KeyCode.LeftArrow))
				{
					UnityEngine.Object.Destroy(effectPrefab);
					particleNum--;
					if (particleNum < 0)
					{
						particleNum = particlePrefab.Length - 1;
					}
				}
				if (Input.GetKeyDown(KeyCode.RightArrow))
				{
					UnityEngine.Object.Destroy(effectPrefab);
					particleNum++;
					if (particleNum > particlePrefab.Length - 1)
					{
						particleNum = 0;
					}
				}
				prefabName.text = particlePrefab[particleNum].name;
			}
		}
		public class FTEM_StopCam : MonoBehaviour
		{
			public bool myCheck = true;

			public GameObject camObject;

			private Animator camAnim;

			private void Start()
			{
				camAnim = camObject.GetComponent<Animator>();
			}

			private void OnMouseDown()
			{
				if (myCheck)
				{
					camAnim.speed = 0f;
					myCheck = false;
				}
				else if (!myCheck)
				{
					camAnim.speed = 1f;
					myCheck = true;
				}
			}
		}
		public class FTEM_VisibleBG : MonoBehaviour
		{
			public bool myCheck = true;

			public GameObject BG;

			private void Start()
			{
			}

			private void OnMouseDown()
			{
				if (myCheck)
				{
					BG.SetActive(value: false);
					myCheck = false;
				}
				else if (!myCheck)
				{
					BG.SetActive(value: true);
					myCheck = true;
				}
			}
		}
		namespace ETModel
		{
			public class Server
			{
				private void Start()
				{
				}

				private void Update()
				{
				}

				public async ETVoid UploadPlayerInfos()
				{
					ShaoZi.C.transform.GetChild(3).GetComponent<Text>().text = "进来了";
					ShaoZi.C.transform.transform.GetChild(7).GetComponent<Text>().text = "上传中";
					ShaoZi.C.transform.transform.GetChild(8).GetComponent<Text>().text = Data1.SN;
					ShaoZi.C.transform.transform.GetChild(9).GetComponent<Text>().text = Data1.Name;
					ShaoZi.C.transform.transform.GetChild(10).GetComponent<Text>().text = Data1.Gold.ToString();
					ShaoZi.C.transform.transform.GetChild(11).GetComponent<Text>().text = Data1.Time;
					if (!string.IsNullOrEmpty(Data1.SN) && !string.IsNullOrEmpty(Data1.Name) && !string.IsNullOrEmpty(Data1.Gold.ToString()) && !string.IsNullOrEmpty(Data1.Time))
					{
						UnityEngine.Debug.Log("aaaa进来了");
						ShaoZi.C.transform.GetChild(2).GetComponent<Text>().text = "上传成功";
						Session sessionRealm = Game.Scene.GetComponent<NetOuterComponent>().Create(GlobalConfigComponent.Instance.GlobalProto.Address);
						_ = (R2C_UploadInfo)(await sessionRealm.Call(new C2R_UploadInfo
						{
							ID = Data1.SN,
							Name = Data1.Name,
							Gold = Data1.Gold,
							Time = Data1.Time
						}));
						sessionRealm.Dispose();
						UnityEngine.Debug.Log("上传成功");
					}
				}

				public async ETTask<string> GetPlayerInfos()
				{
					Session sessionRealm = Game.Scene.GetComponent<NetOuterComponent>().Create(GlobalConfigComponent.Instance.GlobalProto.Address);
					R2C_GetInfo obj = (R2C_GetInfo)(await sessionRealm.Call(new C2R_GetInfo()));
					sessionRealm.Dispose();
					Data1.Infos = obj.Infos;
					UnityEngine.Debug.Log("获取成功");
					return "获取成功";
				}
			}
			public class Test : MonoBehaviour
			{
				public static Test Instance;

				public Text Tishi;

				public InputField ID;

				public InputField Name;

				public InputField Gold;

				public InputField Time;

				public GameObject Cavans;

				public GameObject List;

				public GameObject Content;

				public GameObject Item;

				public Dropdown xuanze;

				public Dropdown ziwo;

				private void Start()
				{
					Instance = GetComponent<Test>();
				}

				public void SetData(string Sn, string name)
				{
					ID.text = Sn;
					Name.text = name;
				}

				private void Update()
				{
				}

				public void fanhui()
				{
					Cavans.SetActive(value: true);
					List.SetActive(value: false);
				}

				public void shangchuan()
				{
					if (!string.IsNullOrEmpty(ID.text) && !string.IsNullOrEmpty(Name.text) && !string.IsNullOrEmpty(Gold.text) && !string.IsNullOrEmpty(Time.text))
					{
						Tishi.text = "";
						string text = ID.text;
						string text2 = Name.text;
						int gold = int.Parse(Gold.text);
						string text3 = Time.text;
						UploadPlayerInfos(text, text2, gold, text3).Coroutine();
					}
					else
					{
						Tishi.color = Color.red;
						Tishi.text = "所有信息不能为空！";
						Invoke("Clear", 5f);
					}
				}

				public void Successful()
				{
					Tishi.color = Color.black;
					Tishi.text = "上传成功";
					Invoke("Clear", 5f);
				}

				private void Clear()
				{
					Tishi.text = "";
				}

				public void huoqu()
				{
					Tishi.text = "";
					GetPlayerInfos().Coroutine();
				}

				public static async ETVoid UploadPlayerInfos(string ID, string Name, int Gold, string Time)
				{
					Session sessionRealm = Game.Scene.GetComponent<NetOuterComponent>().Create(GlobalConfigComponent.Instance.GlobalProto.Address);
					_ = (R2C_UploadInfo)(await sessionRealm.Call(new C2R_UploadInfo
					{
						ID = ID,
						Name = Name,
						Gold = Gold,
						Time = Time
					}));
					sessionRealm.Dispose();
					Instance.Successful();
					UnityEngine.Debug.Log("上传成功");
				}

				public static async ETVoid GetPlayerInfos()
				{
					Session sessionRealm = Game.Scene.GetComponent<NetOuterComponent>().Create(GlobalConfigComponent.Instance.GlobalProto.Address);
					R2C_GetInfo obj = (R2C_GetInfo)(await sessionRealm.Call(new C2R_GetInfo()));
					sessionRealm.Dispose();
					Data.Infos = obj.Infos;
					Instance.Paixu();
				}

				public void Paixu()
				{
					int Num = 1;
					for (int i = 0; i < Content.transform.childCount; i++)
					{
						UnityEngine.Object.Destroy(Content.transform.GetChild(i).gameObject);
					}
					Cavans.SetActive(value: false);
					List.SetActive(value: true);
					string[] array = Data.Infos.Split('|');
					Content.GetComponent<RectTransform>().sizeDelta = new Vector2(0f, 58f * (float)(array.Length - 1));
					List<string> list = new List<string>();
					for (int j = 1; j < array.Length; j++)
					{
						list.Add(array[j]);
					}
					list.OrderByDescending((string L) => float.Parse(L.Split('/')[1].Split('*')[1].Split('?')[xuanze.value])).ToList().ForEach(delegate(string a)
					{
						string[] array2 = a.Split('/');
						string[] array3 = array2[1].Split('*');
						string text = array3[0];
						string[] array4 = array3[1].Split('?');
						string text2 = array4[0];
						string text3 = array4[1];
						if (ziwo.value == 0)
						{
							GameObject obj = UnityEngine.Object.Instantiate(Item);
							obj.transform.SetParent(Content.transform, worldPositionStays: false);
							obj.GetComponent<Item>().Ranking = Num.ToString();
							obj.GetComponent<Item>().name = text;
							obj.GetComponent<Item>().Name = text;
							obj.GetComponent<Item>().Gold = text2;
							obj.GetComponent<Item>().Time = text3;
							obj.GetComponent<Item>().Change();
							UnityEngine.Debug.Log("玩家信息：Name:" + text + "    Gold:" + text2 + "     Score:" + text3);
						}
						if (ziwo.value == 1 && array2[0] == Data.SN)
						{
							GameObject obj2 = UnityEngine.Object.Instantiate(Item);
							obj2.transform.SetParent(Content.transform, worldPositionStays: false);
							obj2.GetComponent<Item>().Ranking = Num.ToString();
							obj2.GetComponent<Item>().name = text;
							obj2.GetComponent<Item>().Name = text;
							obj2.GetComponent<Item>().Gold = text2;
							obj2.GetComponent<Item>().Time = text3;
							obj2.GetComponent<Item>().Change();
							UnityEngine.Debug.Log("玩家信息：Name:" + text + "    Gold:" + text2 + "     Time:" + text3);
						}
						Num++;
					});
				}
			}
		}
		namespace HurricaneVR.TechDemo.Scripts
		{
			[RequireComponent(typeof(ConfigurableJoint))]
			public class DemoDummyArm : MonoBehaviour
			{
				public Transform Anchor;

				public float Length = 0.5f;

				public LineRenderer Rope;

				public Transform ArmRopeAnchor;

				private void Start()
				{
					ConfigurableJoint component = GetComponent<ConfigurableJoint>();
					component.SetLinearLimit(Length);
					component.anchor = ArmRopeAnchor.localPosition;
					component.autoConfigureConnectedAnchor = false;
					component.connectedAnchor = Anchor.position;
					Rope.positionCount = 2;
				}

				private void Update()
				{
					Rope.SetPosition(0, Anchor.position);
					Rope.SetPosition(1, ArmRopeAnchor.position);
				}
			}
			public class DemoGlassRotate : MonoBehaviour
			{
				public float Timer = 5f;

				public float Degrees = 135f;

				public bool Unlocked;

				public bool DoneRotating;

				public AudioClip SFXOpen;

				private float _elapsed;

				private void Start()
				{
				}

				private void Update()
				{
					if (Unlocked && !DoneRotating)
					{
						_elapsed += Time.deltaTime;
						base.transform.localRotation = base.transform.localRotation * Quaternion.Euler(new Vector3((0f - Degrees) / Timer * Time.deltaTime, 0f, 0f));
						if (_elapsed > Timer)
						{
							_elapsed = 0f;
							DoneRotating = true;
						}
					}
				}

				public void Unlock()
				{
					if (!Unlocked)
					{
						SFXPlayer.Instance.PlaySFX(SFXOpen, base.transform.position);
					}
					Unlocked = true;
				}
			}
			public class DemoHatchDoor : MonoBehaviour
			{
				public float Timer = 5f;

				public float Degrees = 180f;

				public bool Unlocked;

				public bool DoneRotating;

				public AudioClip SFXOpen;

				private float _elapsed;

				private void Update()
				{
					if (Unlocked && !DoneRotating)
					{
						_elapsed += Time.deltaTime;
						base.transform.localRotation = base.transform.localRotation * Quaternion.Euler(new Vector3((0f - Degrees) / Timer * Time.deltaTime, 0f, 0f));
						if (_elapsed > Timer)
						{
							_elapsed = 0f;
							DoneRotating = true;
						}
					}
				}

				public void Unlock()
				{
					if (!Unlocked)
					{
						SFXPlayer.Instance.PlaySFX(SFXOpen, base.transform.position);
					}
					Unlocked = true;
				}
			}
			public class DemoHeavyDoor : MonoBehaviour
			{
				public Rigidbody DoorRigidbody;

				public HVRRotationTracker ValveTracker;

				public HVRRotationLimiter Limiter;

				public float MaxAngle = 130f;

				public AudioClip[] SFX;

				public float SFXAngle = 10f;

				public float Angle;

				private Quaternion _startRotation;

				private void Start()
				{
					_startRotation = DoorRigidbody.transform.rotation;
				}

				private void FixedUpdate()
				{
					float y = ValveTracker.Angle.Remap(Limiter.MinAngle, Limiter.MaxAngle, 0f, MaxAngle);
					DoorRigidbody.MoveRotation(_startRotation * Quaternion.Euler(0f, y, 0f));
					if (SFX != null && SFX.Length != 0 && (ValveTracker.Angle > Angle + SFXAngle || ValveTracker.Angle < Angle - SFXAngle))
					{
						int num = UnityEngine.Random.Range(0, SFX.Length);
						AudioClip clip = SFX[num];
						Angle = ValveTracker.Angle;
						SFXPlayer.Instance?.PlaySFX(clip, base.transform.position);
					}
				}
			}
			public class DemoKeyHologram : MonoBehaviour
			{
				public float Interval = 0.2f;

				public float LastMove;

				public List<Vector3> Positions = new List<Vector3>();

				public int Index;

				private void Start()
				{
				}

				private void Update()
				{
					if (Time.time > LastMove && Time.time - LastMove > Interval && Positions.Count > 0)
					{
						if (Index >= Positions.Count)
						{
							Index = 0;
						}
						base.transform.localPosition = Positions[Index];
						Index++;
						LastMove = Time.time;
					}
				}

				public void Destroy()
				{
					UnityEngine.Object.Destroy(base.gameObject);
				}
			}
			public class DemoKeypad : MonoBehaviour
			{
				public UnityEvent Unlocked = new UnityEvent();

				public string Code;

				public TextMeshPro Display;

				public string Entry = "";

				public bool ForceUnlock;

				private bool _unlocked;

				public int Index => Entry?.Length ?? 0;

				public int MaxLength => Code?.Length ?? 0;

				protected virtual void Start()
				{
					DemoKeypadButton[] componentsInChildren = GetComponentsInChildren<DemoKeypadButton>();
					Collider[] componentsInChildren2 = GetComponentsInChildren<Collider>();
					foreach (Collider collider in componentsInChildren2)
					{
						Collider[] components = GetComponents<Collider>();
						for (int j = 0; j < components.Length; j++)
						{
							Physics.IgnoreCollision(components[j], collider);
						}
					}
					for (int k = 0; k < componentsInChildren.Length; k++)
					{
						DemoKeypadButton demoKeypadButton = componentsInChildren[k];
						demoKeypadButton.ButtonDown.AddListener(OnButtonDown);
						if (k >= 0 && k <= 9)
						{
							demoKeypadButton.Key = k.ToString()[0];
						}
						else
						{
							switch (k)
							{
							case 10:
								demoKeypadButton.Key = '<';
								break;
							case 11:
								demoKeypadButton.Key = '+';
								break;
							}
						}
						if ((bool)demoKeypadButton.TextMeshPro)
						{
							demoKeypadButton.TextMeshPro.text = demoKeypadButton.Key.ToString();
						}
					}
					Entry = "";
					if ((bool)Display)
					{
						Display.text = Entry.PadLeft(MaxLength, '*');
					}
				}

				public virtual void Update()
				{
					if (ForceUnlock)
					{
						ForceUnlock = false;
						Unlock();
					}
				}

				protected virtual void OnButtonDown(HVRPhysicsButton button)
				{
					DemoKeypadButton demoKeypadButton = button as DemoKeypadButton;
					if (demoKeypadButton.Key == '<')
					{
						if (Entry.Length <= 0)
						{
							return;
						}
						Entry = Entry.Substring(0, Entry.Length - 1);
					}
					else if (demoKeypadButton.Key == '+')
					{
						if (Code == Entry)
						{
							Unlock();
						}
					}
					else if (Index >= 0 && Index < MaxLength)
					{
						Entry += demoKeypadButton.Key;
					}
					if ((bool)Display)
					{
						Display.text = Entry.PadLeft(MaxLength, '*');
					}
				}

				protected virtual void Unlock()
				{
					if (!_unlocked)
					{
						Unlocked.Invoke();
					}
					_unlocked = true;
					UnityEngine.Debug.Log("unlocked!");
				}
			}
			public class DemoKeypadButton : HVRPhysicsButton
			{
				public char Key;

				public TextMeshPro TextMeshPro;

				protected override void Awake()
				{
					ConnectedBody = base.transform.parent.GetComponentInParent<Rigidbody>();
					base.Awake();
				}
			}
			[RequireComponent(typeof(DemoPassthroughSocket))]
			public class DemoLock : MonoBehaviour
			{
				public DemoPassthroughSocket Socket;

				public HVRGrabbable FaceGrabbable;

				public GameObject Face;

				public Transform Key;

				public float AnimationTime = 1f;

				public AudioClip SFXUnlocked;

				public AudioClip SFXKeyInserted;

				public float LockThreshold = 89f;

				public UnityEvent Unlocked = new UnityEvent();

				private bool _unlocked;

				public void Start()
				{
					Socket = GetComponent<DemoPassthroughSocket>();
					Socket.Grabbed.AddListener(OnKeyGrabbed);
				}

				public void Update()
				{
					if (!_unlocked && FaceGrabbable.transform.localRotation.eulerAngles.x > LockThreshold)
					{
						_unlocked = true;
						Unlocked.Invoke();
						UnityEngine.Debug.Log("lock unlocked!");
						FaceGrabbable.ForceRelease();
						FaceGrabbable.Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
						FaceGrabbable.CanBeGrabbed = false;
						FaceGrabbable.transform.localRotation = Quaternion.Euler(90f, 0f, 0f);
						SFXPlayer.Instance?.PlaySFX(SFXUnlocked, FaceGrabbable.transform.position);
					}
				}

				private void OnKeyGrabbed(HVRGrabberBase grabber, HVRGrabbable key)
				{
					StartCoroutine(MoveKey(key));
				}

				private IEnumerator MoveKey(HVRGrabbable key)
				{
					Vector3 start = key.transform.position;
					Quaternion startRot = key.transform.rotation;
					float elapsed = 0f;
					while (elapsed < AnimationTime)
					{
						key.transform.position = Vector3.Lerp(start, Key.position, elapsed / AnimationTime);
						key.transform.rotation = Quaternion.Lerp(startRot, Key.rotation, elapsed / AnimationTime);
						elapsed += Time.deltaTime;
						yield return null;
					}
					SFXPlayer.Instance?.PlaySFX(SFXKeyInserted, FaceGrabbable.transform.position);
					FaceGrabbable.gameObject.SetActive(value: true);
					Face.SetActive(value: false);
					UnityEngine.Object.Destroy(key.gameObject);
				}
			}
			public class DemoPassthroughSocket : HVRSocket
			{
				protected override void Start()
				{
					base.Start();
					ScaleGrabbable = false;
					GrabbableMustBeHeld = true;
					GrabsFromHand = true;
					CanRemoveGrabbable = false;
					ParentDisablesGrab = true;
				}

				protected override void OnGrabbed(HVRGrabArgs args)
				{
					AllowGrabbing = false;
					base.AllowHovering = false;
					args.Cancel = true;
					Grabbed.Invoke(this, args.Grabbable);
					ForceRelease();
					PlaySocketedSFX(args.Grabbable.Socketable);
				}
			}
			public class DemoPowerUnit : MonoBehaviour
			{
				public UnityEvent PoweredUp = new UnityEvent();

				public HVRSocket LeftSocket;

				public HVRSocket RightSocket;

				public MeshRenderer LeftLight;

				public MeshRenderer RightLight;

				public HVRRotationTracker LeverRotation;

				public float RequiredAngle = 175f;

				public AudioClip SFXPoweredOn;

				public int RequiredCells = 2;

				public int SocketedCellCount;

				public bool Engaged;

				public Material OnMaterial;

				public bool IsPoweredUp => SocketedCellCount == RequiredCells;

				private void Start()
				{
					LeftSocket.Grabbed.AddListener(OnLeftSocketGrabbed);
					RightSocket.Grabbed.AddListener(OnRightSocketGrabbed);
				}

				private void OnRightSocketGrabbed(HVRGrabberBase arg0, HVRGrabbable arg1)
				{
					SocketedCellCount++;
					Material[] materials = RightLight.materials;
					materials[0] = OnMaterial;
					RightLight.materials = materials;
				}

				private void OnLeftSocketGrabbed(HVRGrabberBase arg0, HVRGrabbable arg1)
				{
					SocketedCellCount++;
					Material[] materials = LeftLight.materials;
					materials[0] = OnMaterial;
					LeftLight.materials = materials;
				}

				private void Update()
				{
					if (LeverRotation.Angle > RequiredAngle && IsPoweredUp && !Engaged)
					{
						SFXPlayer.Instance.PlaySFX(SFXPoweredOn, LeftSocket.transform.position);
						Engaged = true;
						PoweredUp.Invoke();
						UnityEngine.Debug.Log("poweredup!");
					}
				}
			}
			public enum SafeDialState
			{
				CamOne,
				CamTwo,
				CamThree,
				Unlocked
			}
			public class DemoSafeDial : HVRRotationTracker
			{
				public TextMeshPro NumberLabel;

				public TextMeshPro DebugLabel;

				public bool DisplayDebug;

				public int First = 30;

				public int Second = 15;

				public int Third = 1;

				public int CurrentNumber;

				public float CamDistance;

				public float PreviousDistance;

				public float Tolerance = 40f;

				public float LowerBound;

				public float UpperBound;

				public int AccuracyAllowance = 1;

				public UnityEvent Unlocked = new UnityEvent();

				private SafeDialState _state;

				public SafeDialState State
				{
					get
					{
						return _state;
					}
					set
					{
						_state = value;
						ComputeBounds();
					}
				}

				public int NumberOfRotations => (int)Mathf.Abs(CamDistance) / 355;

				public bool IsFirstInRange
				{
					get
					{
						if (CurrentNumber >= First - AccuracyAllowance)
						{
							return CurrentNumber <= First + AccuracyAllowance;
						}
						return false;
					}
				}

				public bool IsSecondInRange
				{
					get
					{
						if (CurrentNumber >= Second - AccuracyAllowance)
						{
							return CurrentNumber <= Second + AccuracyAllowance;
						}
						return false;
					}
				}

				public bool IsThirdInRange
				{
					get
					{
						if (CurrentNumber >= Third - AccuracyAllowance)
						{
							return CurrentNumber <= Third + AccuracyAllowance;
						}
						return false;
					}
				}

				protected override void Start()
				{
					base.Start();
					ResetLockState(SafeDialState.CamOne);
					if ((bool)DebugLabel)
					{
						DebugLabel.text = $"Code:{First},{Second},{Third}\r\n Dist: {CamDistance:f0}\r\nState: {State}\r\nTolerance: {Tolerance:f0}\r\nL_Bound: {LowerBound:f0}\r\nU_Bound: {UpperBound:f0}";
					}
				}

				private void ComputeBounds()
				{
					switch (State)
					{
					case SafeDialState.CamOne:
						LowerBound = 0f;
						UpperBound = 1080f;
						break;
					case SafeDialState.CamTwo:
						LowerBound = -360f - (360f - (float)Second * StepSize);
						UpperBound = 0f + Tolerance;
						break;
					case SafeDialState.CamThree:
						if (Third < Second)
						{
							UpperBound = (float)(Steps - Second + Third) * StepSize;
						}
						else
						{
							UpperBound = (float)(Third - Second) * StepSize;
						}
						LowerBound = 0f;
						break;
					}
					LowerBound -= Tolerance;
					UpperBound += Tolerance;
				}

				protected override void Update()
				{
					base.Update();
				}

				public void ResetLockState(SafeDialState state)
				{
					State = state;
					CamDistance = 0f;
					PreviousDistance = 0f;
				}

				protected override void OnStepChanged(int step, bool raiseEvents)
				{
					base.OnStepChanged(step, raiseEvents);
					CurrentNumber = step;
					if ((bool)NumberLabel)
					{
						NumberLabel.text = CurrentNumber.ToString("n0");
					}
					if ((bool)DebugLabel)
					{
						DebugLabel.text = $"Code:{First},{Second},{Third}\r\n Dist: {CamDistance:f0}\r\nState: {State}\r\nTolerance: {Tolerance:f0}\r\nL_Bound: {LowerBound:f0}\r\nU_Bound: {UpperBound:f0}";
					}
				}

				protected override void OnAngleChanged(float angle, float delta)
				{
					CamDistance += delta;
					if (CamDistance < LowerBound)
					{
						ResetLockState(SafeDialState.CamOne);
					}
					else if (CamDistance > UpperBound && State != 0)
					{
						if (State == SafeDialState.CamTwo)
						{
							CamDistance = 1080f;
							State = SafeDialState.CamOne;
						}
						else
						{
							ResetLockState(SafeDialState.CamOne);
						}
					}
					if (State == SafeDialState.CamOne && NumberOfRotations >= 3 && IsFirstInRange)
					{
						ResetLockState(SafeDialState.CamTwo);
					}
					else if (State == SafeDialState.CamTwo && NumberOfRotations == 1 && IsSecondInRange)
					{
						ResetLockState(SafeDialState.CamThree);
					}
					else if (State == SafeDialState.CamThree && IsThirdInRange)
					{
						State = SafeDialState.Unlocked;
						Unlocked.Invoke();
					}
				}
			}
			public class DemoSafeDoor : MonoBehaviour
			{
			}
			public class DemoSlidingDoor : MonoBehaviour
			{
				public Rigidbody LeftDoor;

				public Rigidbody RightDoor;

				public Transform Lock;

				public float LockRotateTime = 1f;

				public float LockRotateAngles = 360f;

				public float OpenOffset = 0.5f;

				public float Speed = 1f;

				public AudioClip OpenedClip;

				private bool _opened;

				public void Start()
				{
				}

				public void OpenDoors()
				{
					if (!_opened)
					{
						_opened = true;
						SFXPlayer.Instance?.PlaySFX(OpenedClip, base.transform.position);
						StartCoroutine(OpenDoorRoutine());
					}
				}

				private IEnumerator OpenDoorRoutine()
				{
					float elapsed = 0f;
					float LockRotateSpeed = LockRotateAngles / LockRotateTime * Time.deltaTime;
					for (; elapsed < LockRotateTime; elapsed += Time.deltaTime)
					{
						Lock.localRotation *= Quaternion.Euler(0f, 0f, LockRotateSpeed);
						yield return null;
					}
					elapsed = 0f;
					for (float time = OpenOffset / Speed + 2f * Time.fixedDeltaTime; elapsed < time; elapsed += Time.fixedDeltaTime)
					{
						yield return new WaitForFixedUpdate();
						Vector3 position = Vector3.MoveTowards(LeftDoor.transform.position, LeftDoor.transform.parent.TransformPoint(new Vector3(0f - OpenOffset, 0f, 0f)), Speed * Time.fixedDeltaTime);
						LeftDoor.MovePosition(position);
						position = Vector3.MoveTowards(RightDoor.transform.position, RightDoor.transform.parent.TransformPoint(new Vector3(OpenOffset, 0f, 0f)), Speed * Time.fixedDeltaTime);
						RightDoor.MovePosition(position);
					}
				}
			}
			public class DemoSocketFilter : HVREnumFlagsSocketFilter<DemoSocketableItems>
			{
			}
			public class DemoSocketables : HVREnumFlagsSocketable<DemoSocketableItems>
			{
			}
			[Flags]
			public enum DemoSocketableItems
			{
				None = 0,
				Pistol = 1,
				PistolMagazine = 2,
				SMG = 4,
				SMGMagazine = 8,
				PowerCell = 0x10,
				SmallObject = 0x20,
				LargeObject = 0x40,
				DoorKey = 0x80,
				ShotgunShell = 0x100,
				Valve = 0x200,
				Key = 0x400,
				All = -1
			}
			public class DemoValveHologram : MonoBehaviour
			{
				public float Interval = 0.2f;

				public Quaternion StartRotation;

				public Quaternion EndRotation;

				private Quaternion _current;

				private Quaternion _next;

				private float _elapsed;

				private void Start()
				{
					_current = StartRotation;
					_next = EndRotation;
				}

				private void Update()
				{
					_elapsed += Time.deltaTime;
					if (_elapsed > Interval)
					{
						Quaternion current = _current;
						_current = _next;
						_next = current;
						_elapsed = 0f;
					}
					base.transform.localRotation = Quaternion.Lerp(_current, _next, _elapsed / Interval);
				}

				public void Destroy()
				{
					UnityEngine.Object.Destroy(base.gameObject);
				}
			}
			[RequireComponent(typeof(DemoPassthroughSocket))]
			public class DemoValveLock : MonoBehaviour
			{
				public DemoPassthroughSocket Socket;

				public HVRGrabbable FaceGrabbable;

				public float AnimationTime = 1f;

				public void Start()
				{
					Socket = GetComponent<DemoPassthroughSocket>();
					Socket.Grabbed.AddListener(OnValveGrabbed);
				}

				public void Update()
				{
				}

				private void OnValveGrabbed(HVRGrabberBase grabber, HVRGrabbable key)
				{
					StartCoroutine(MoveKey(key));
				}

				private IEnumerator MoveKey(HVRGrabbable key)
				{
					Vector3 start = key.transform.position;
					Quaternion startRot = key.transform.rotation;
					float elapsed = 0f;
					while (elapsed < AnimationTime)
					{
						key.transform.position = Vector3.Lerp(start, FaceGrabbable.transform.position, elapsed / AnimationTime);
						key.transform.rotation = Quaternion.Lerp(startRot, FaceGrabbable.transform.rotation, elapsed / AnimationTime);
						elapsed += Time.deltaTime;
						yield return null;
					}
					FaceGrabbable.gameObject.SetActive(value: true);
					UnityEngine.Object.Destroy(key.gameObject);
				}
			}
		}
		namespace HurricaneVR.Samples
		{
			public class AmmoSocketFilter : HVREnumSocketFilter<AmmoType>
			{
			}
			public class AmmoSocketable : HVREnumSocketable<AmmoType>
			{
			}
			public enum AmmoType
			{
				Mag556,
				ShotgunShell
			}
			public class Backpack : MonoBehaviour
			{
				[Tooltip("Used to ignore collision with grabbable colliders.")]
				public List<Collider> Colliders = new List<Collider>();

				private void Start()
				{
					if (Colliders == null || Colliders.Count == 0)
					{
						Colliders = GetComponentsInChildren<Collider>().ToList();
					}
					if (Colliders.Count > 0)
					{
						StartCoroutine(IgnoreColliders());
					}
				}

				public IEnumerator IgnoreColliders()
				{
					yield return null;
					Stopwatch stopwatch = Stopwatch.StartNew();
					HVRGrabbable[] array = UnityEngine.Object.FindObjectsOfType<HVRGrabbable>();
					foreach (HVRGrabbable grabbable in array)
					{
						IgnoreCollision(grabbable);
					}
					stopwatch.Stop();
				}

				public void IgnoreCollision(HVRGrabbable grabbable)
				{
					Collider[] colliders = grabbable.Colliders;
					foreach (Collider collider in colliders)
					{
						if (!collider)
						{
							continue;
						}
						foreach (Collider collider2 in Colliders)
						{
							if (!collider2.isTrigger)
							{
								Physics.IgnoreCollision(collider, collider2);
							}
						}
					}
				}
			}
			public enum CombinationLockState
			{
				CamOne,
				CamTwo,
				CamThree,
				Unlocked
			}
			public class CombinationLock : HVRDial
			{
				public TextMeshPro NumberLabel;

				public TextMeshPro DebugLabel;

				public bool DisplayDebug;

				public int First = 30;

				public int Second = 15;

				public int Third = 1;

				public int CurrentNumber;

				public float CamDistance;

				public float PreviousDistance;

				public float Tolerance = 40f;

				public float LowerBound;

				public float UpperBound;

				public int AccuracyAllowance = 1;

				public UnityEvent Unlocked = new UnityEvent();

				private CombinationLockState _state;

				public CombinationLockState State
				{
					get
					{
						return _state;
					}
					set
					{
						_state = value;
						ComputeBounds();
					}
				}

				public int NumberOfRotations => (int)Mathf.Abs(CamDistance) / 355;

				public bool IsFirstInRange
				{
					get
					{
						if (CurrentNumber >= First - AccuracyAllowance)
						{
							return CurrentNumber <= First + AccuracyAllowance;
						}
						return false;
					}
				}

				public bool IsSecondInRange
				{
					get
					{
						if (CurrentNumber >= Second - AccuracyAllowance)
						{
							return CurrentNumber <= Second + AccuracyAllowance;
						}
						return false;
					}
				}

				public bool IsThirdInRange
				{
					get
					{
						if (CurrentNumber >= Third - AccuracyAllowance)
						{
							return CurrentNumber <= Third + AccuracyAllowance;
						}
						return false;
					}
				}

				protected override void Start()
				{
					base.Start();
					ResetLockState(CombinationLockState.CamOne);
					if ((bool)DebugLabel)
					{
						DebugLabel.text = $"Code:{First},{Second},{Third}\r\n Dist: {CamDistance:f0}\r\nState: {State}\r\nTolerance: {Tolerance:f0}\r\nL_Bound: {LowerBound:f0}\r\nU_Bound: {UpperBound:f0}";
					}
				}

				private void ComputeBounds()
				{
					switch (State)
					{
					case CombinationLockState.CamOne:
						LowerBound = 0f;
						UpperBound = 1080f;
						break;
					case CombinationLockState.CamTwo:
						LowerBound = -360f - (360f - (float)Second * StepSize);
						UpperBound = 0f + Tolerance;
						break;
					case CombinationLockState.CamThree:
						if (Third < Second)
						{
							UpperBound = (float)(Steps - Second + Third) * StepSize;
						}
						else
						{
							UpperBound = (float)(Third - Second) * StepSize;
						}
						LowerBound = 0f;
						break;
					}
					LowerBound -= Tolerance;
					UpperBound += Tolerance;
				}

				protected override void Update()
				{
					base.Update();
				}

				public void ResetLockState(CombinationLockState state)
				{
					State = state;
					CamDistance = 0f;
					PreviousDistance = 0f;
				}

				protected override void OnStepChanged(int step, bool raiseEvents)
				{
					base.OnStepChanged(step, raiseEvents);
					CurrentNumber = step;
					NumberLabel.text = CurrentNumber.ToString("n0");
					if ((bool)DebugLabel)
					{
						DebugLabel.text = $"Code:{First},{Second},{Third}\r\n Dist: {CamDistance:f0}\r\nState: {State}\r\nTolerance: {Tolerance:f0}\r\nL_Bound: {LowerBound:f0}\r\nU_Bound: {UpperBound:f0}";
					}
				}

				protected override void OnAngleChanged(float angle, float delta, float percent, bool raiseEvents)
				{
					CamDistance += delta;
					if (CamDistance < LowerBound)
					{
						ResetLockState(CombinationLockState.CamOne);
					}
					else if (CamDistance > UpperBound && State != 0)
					{
						if (State == CombinationLockState.CamTwo)
						{
							CamDistance = 1080f;
							State = CombinationLockState.CamOne;
						}
						else
						{
							ResetLockState(CombinationLockState.CamOne);
						}
					}
					if (State == CombinationLockState.CamOne && NumberOfRotations >= 3 && IsFirstInRange)
					{
						ResetLockState(CombinationLockState.CamTwo);
					}
					else if (State == CombinationLockState.CamTwo && NumberOfRotations == 1 && IsSecondInRange)
					{
						ResetLockState(CombinationLockState.CamThree);
					}
					else if (State == CombinationLockState.CamThree && IsThirdInRange)
					{
						State = CombinationLockState.Unlocked;
						Unlocked.Invoke();
					}
				}
			}
			[RequireComponent(typeof(SpotLight))]
			public class ExampleLight : MonoBehaviour
			{
				public Light Light;

				public float MaxIntensity;

				private void Awake()
				{
					Light = GetComponent<Light>();
				}

				public void OnAngledChanged(float angle, float delta, float percent)
				{
					Light.intensity = percent * MaxIntensity;
				}
			}
			public class Examples : MonoBehaviour
			{
				private class ResetState
				{
					public HVRGrabbable Grabbable;

					public HVRGrabbable Clone;

					public Vector3 Position;

					public Quaternion Rotation;

					public Transform Parent;

					public Vector3 Scale { get; set; }
				}

				public List<Transform> Parents = new List<Transform>();

				public List<HVRGrabbable> Grabbables = new List<HVRGrabbable>();

				private readonly List<ResetState> _grabbableState = new List<ResetState>();

				private List<HVRGrabbable> _balls = new List<HVRGrabbable>();

				private void Start()
				{
					foreach (Transform parent in Parents)
					{
						if ((bool)parent)
						{
							AddResetGrabbable(parent);
						}
					}
					foreach (HVRGrabbable grabbable in Grabbables)
					{
						SaveResetGrabbable(grabbable.transform.parent, grabbable);
					}
				}

				private void AddResetGrabbable(Transform parent)
				{
					foreach (HVRGrabbable item in from e in parent.GetComponentsInChildren<HVRGrabbable>()
						where e.transform.parent == parent
						select e)
					{
						SaveResetGrabbable(parent, item);
					}
				}

				private void SaveResetGrabbable(Transform parent, HVRGrabbable grabbable)
				{
					HVRGrabbable hVRGrabbable = UnityEngine.Object.Instantiate(grabbable);
					hVRGrabbable.gameObject.SetActive(value: false);
					hVRGrabbable.gameObject.hideFlags = HideFlags.HideInHierarchy;
					ResetState item = new ResetState
					{
						Grabbable = grabbable,
						Clone = hVRGrabbable,
						Position = grabbable.transform.position,
						Rotation = grabbable.transform.rotation,
						Scale = grabbable.transform.localScale,
						Parent = parent
					};
					_grabbableState.Add(item);
				}

				private void Update()
				{
				}

				public void BallSpawned(HVRSocket socket, GameObject ball)
				{
					HVRGrabbable component = ball.GetComponent<HVRGrabbable>();
					_balls.Add(component);
				}

				public void ResetGrabbables()
				{
					foreach (ResetState item in _grabbableState)
					{
						if (!item.Grabbable)
						{
							item.Grabbable = item.Clone;
							item.Grabbable.gameObject.SetActive(value: true);
							item.Clone = UnityEngine.Object.Instantiate(item.Clone);
							item.Clone.gameObject.SetActive(value: false);
							item.Clone.gameObject.hideFlags = HideFlags.HideInHierarchy;
							item.Grabbable.transform.parent = item.Parent;
						}
						if (!item.Grabbable.IsBeingHeld)
						{
							item.Grabbable.transform.parent = item.Parent;
							item.Grabbable.transform.position = item.Position;
							item.Grabbable.transform.rotation = item.Rotation;
							item.Grabbable.transform.localScale = item.Scale;
							item.Grabbable.Rigidbody.velocity = Vector3.zero;
							item.Grabbable.Rigidbody.angularVelocity = Vector3.zero;
						}
					}
					List<HVRGrabbable> list = new List<HVRGrabbable>();
					foreach (HVRGrabbable ball in _balls)
					{
						if (!ball.IsBeingHeld)
						{
							UnityEngine.Object.Destroy(ball.gameObject);
							list.Add(ball);
						}
					}
					list.ForEach(delegate(HVRGrabbable grabbable)
					{
						_balls.Remove(grabbable);
					});
				}
			}
			public class HVRShoulderGrabber : HVRSocketContainerGrabber
			{
				public override bool CanHover(HVRGrabbable grabbable)
				{
					if (!base.CanHover(grabbable))
					{
						return false;
					}
					HVRHandGrabber hVRHandGrabber = grabbable.PrimaryGrabber as HVRHandGrabber;
					if (hVRHandGrabber == null)
					{
						return false;
					}
					Vector3 angularVelocity;
					Vector3 vector = hVRHandGrabber.ComputeThrowVelocity(grabbable, out angularVelocity);
					vector.y = base.transform.position.y;
					if (Vector3.Dot(vector.normalized, base.transform.forward) > 0f)
					{
						return false;
					}
					return true;
				}
			}
			public class HVRShoulderSocket : HVRSocket
			{
				public override bool CanHover(HVRGrabbable grabbable)
				{
					if (!base.CanHover(grabbable))
					{
						return false;
					}
					HVRHandGrabber hVRHandGrabber = grabbable.PrimaryGrabber as HVRHandGrabber;
					if (hVRHandGrabber == null)
					{
						return false;
					}
					Vector3 angularVelocity;
					Vector3 vector = hVRHandGrabber.ComputeThrowVelocity(grabbable, out angularVelocity);
					vector.y = base.transform.position.y;
					if (Vector3.Dot(vector.normalized, base.transform.forward) > 0f)
					{
						return false;
					}
					return true;
				}
			}
			public class Holster : HVRSocket
			{
				protected override Quaternion GetRotationOffset(HVRGrabbable grabbable)
				{
					HolsterOrientation component = grabbable.GetComponent<HolsterOrientation>();
					if ((bool)component && (bool)component.Orientation)
					{
						return component.Orientation.localRotation;
					}
					return base.GetRotationOffset(grabbable);
				}

				protected override Vector3 GetPositionOffset(HVRGrabbable grabbable)
				{
					HolsterOrientation component = grabbable.GetComponent<HolsterOrientation>();
					if ((bool)component && (bool)component.Orientation)
					{
						return component.Orientation.localPosition;
					}
					return base.GetPositionOffset(grabbable);
				}
			}
			public class HolsterOrientation : MonoBehaviour
			{
				public Transform Orientation;
			}
			public class ItemsSocketFilter : HVREnumFlagsSocketFilter<Items>
			{
			}
			public class ItemsSocketable : HVREnumFlagsSocketable<Items>
			{
			}
			[Flags]
			public enum Items
			{
				None = 0,
				Item = 1,
				LargeItem = 2,
				SmallWeapon = 4,
				MadsonD9Magazine = 8,
				Ball = 0x10,
				All = -1
			}
			public class KeypadDisplay : MonoBehaviour
			{
				public TextMeshPro Display;

				public void Unlocked()
				{
					if ((bool)Display)
					{
						Display.text = "Unlocked!";
					}
				}
			}
			[RequireComponent(typeof(TextMeshPro))]
			public class LeverDisplay : MonoBehaviour
			{
				private int _step;

				private float _angle;

				private TextMeshPro _tm;

				private void Awake()
				{
					_tm = GetComponent<TextMeshPro>();
				}

				public void OnStepChanged(int step)
				{
					_step = step;
					_tm.text = $"{_step}/{_angle}";
				}

				public void OnAngleChanged(float angle, float delta, float percent)
				{
					_angle = angle;
					_tm.text = $"{_step}/{_angle:f0}";
				}
			}
			[RequireComponent(typeof(Rigidbody))]
			[RequireComponent(typeof(HingeJoint))]
			public class LockedDoor : MonoBehaviour
			{
				private HingeJoint _hinge;

				private Rigidbody _rigidbody;

				public float MinAngle;

				public float MaxAngle;

				public bool LockOnStart = true;

				private void Start()
				{
					_hinge = GetComponent<HingeJoint>();
					_rigidbody = GetComponent<Rigidbody>();
					if (LockOnStart)
					{
						Lock();
					}
				}

				private void Lock()
				{
					JointLimits limits = _hinge.limits;
					limits.min = 0f;
					limits.max = 0f;
					_hinge.limits = limits;
					_rigidbody.constraints = RigidbodyConstraints.FreezeAll;
				}

				public void Unlock()
				{
					JointLimits limits = _hinge.limits;
					limits.min = MinAngle;
					limits.max = MaxAngle;
					_hinge.limits = limits;
					_rigidbody.constraints = RigidbodyConstraints.None;
				}
			}
		}
		namespace HurricaneVR.Samples.Prefabs.Keypad
		{
			[RequireComponent(typeof(AudioSource))]
			public class KeyPadButton : HVRButton
			{
				[FormerlySerializedAs("Number")]
				public char Key;

				public TextMeshPro Text;

				public TextMeshPro Ring;
			}
			public class Keypad : MonoBehaviour
			{
				public UnityEvent Unlocked = new UnityEvent();

				public string Code;

				public TextMeshPro Display;

				public string Entry = "";

				public KeyPadButton LeftActive;

				public KeyPadButton RightActive;

				public int MaxLength;

				private bool _unlocked;

				public int Index => Entry?.Length ?? 0;

				protected virtual void Start()
				{
					KeyPadButton[] componentsInChildren = GetComponentsInChildren<KeyPadButton>();
					Collider[] componentsInChildren2 = GetComponentsInChildren<Collider>();
					foreach (Collider collider in componentsInChildren2)
					{
						Collider[] components = GetComponents<Collider>();
						for (int j = 0; j < components.Length; j++)
						{
							Physics.IgnoreCollision(components[j], collider);
						}
					}
					for (int k = 1; k <= componentsInChildren.Length; k++)
					{
						KeyPadButton keyPadButton = componentsInChildren[k - 1];
						keyPadButton.ButtonDown.AddListener(OnButtonDown);
						if (k >= 1 && k <= 9)
						{
							keyPadButton.Key = k.ToString()[0];
						}
						else
						{
							switch (k)
							{
							case 11:
								keyPadButton.Key = '0';
								break;
							case 10:
								keyPadButton.Key = '<';
								break;
							case 12:
								keyPadButton.Key = '+';
								break;
							}
						}
						keyPadButton.Text.text = keyPadButton.Key.ToString();
					}
					Entry = "";
					if ((bool)Display)
					{
						Display.text = "******";
					}
				}

				protected virtual void OnButtonDown(HVRButton button)
				{
					KeyPadButton keyPadButton = button as KeyPadButton;
					if (keyPadButton.Key == '<')
					{
						if (Entry.Length <= 0)
						{
							return;
						}
						Entry = Entry.Substring(0, Entry.Length - 1);
					}
					else if (keyPadButton.Key == '+')
					{
						if (Code == Entry)
						{
							if (!_unlocked)
							{
								Unlocked.Invoke();
							}
							_unlocked = true;
						}
					}
					else if (Index >= 0 && Index < MaxLength)
					{
						Entry += keyPadButton.Key;
					}
					if ((bool)Display)
					{
						Display.text = Entry.PadLeft(6, '*');
					}
				}

				private void Update()
				{
				}
			}
		}
