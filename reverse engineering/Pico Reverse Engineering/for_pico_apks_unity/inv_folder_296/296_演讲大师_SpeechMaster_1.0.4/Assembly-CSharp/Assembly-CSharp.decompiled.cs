using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using AOT;
using BoundarySystem_Ext;
using LitJson;
using Newtonsoft.Json.Linq;
using PolyPerfect;
using Pvr_UnitySDKAPI;
using Pvr_UnitySDKAPI.Achievement;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Android;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;
using com.unity.cloudbase;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public class Version_Checking : MonoBehaviour
{
	public static List<VersionChecking> dataObj;

	public Text tips;

	public Text title;

	public AudioSource music;

	public AudioClip succeed;

	public AudioClip failure;

	public Transform headSet;

	public Pvr_UnitySDKHeadTrack headTrack;

	public CalibrationTouch touch;

	private int try_time;

	private bool version_checking;

	private void Start()
	{
		RunCloudbase();
		InvokeRepeating("Run_Version_Checking", 5f, 2f);
	}

	private void Update()
	{
	}

	private IEnumerator Wait_To_Quit()
	{
		yield return new WaitForSeconds(3f);
		Application.Quit();
		Application.Quit();
	}

	public async void RunCloudbase()
	{
		CloudBaseApp app = CloudBaseApp.Init("critical-fusion-9giwb3nj1337a5b1", 3000);
		if (await app.Auth.GetAuthStateAsync() == null)
		{
			await app.Auth.SignInAnonymouslyAsync();
		}
		await app.Auth.GetUserInfoAsync();
		dataObj = JArray.Parse(Convert.ToString((await app.Db.Collection("version_checking").Doc("speech_master").GetAsync()).Data)).ToObject<List<VersionChecking>>();
	}

	private void Run_Version_Checking()
	{
		try_time++;
		if (try_time <= 3 && dataObj != null)
		{
			for (int i = 0; i < dataObj[0].build_number.Length; i++)
			{
				if (Score_System.Version == dataObj[0].build_number[i])
				{
					tips.text = "版本验证成功";
					Play_Music(0);
					CancelInvoke();
					Invoke("Load_Set_Scene", 12f);
					break;
				}
				tips.text = "网络验证中……";
			}
			return;
		}
		if (try_time > 3 && try_time <= 5 && dataObj != null)
		{
			bool flag = true;
			for (int j = 0; j < dataObj[0].build_number.Length; j++)
			{
				if (Score_System.Version == dataObj[0].build_number[j])
				{
					tips.text = "版本验证成功";
					Play_Music(0);
					CancelInvoke();
					Invoke("Load_Set_Scene", 12f);
					flag = false;
				}
				else
				{
					tips.text = "网络验证中……";
				}
			}
			if (flag)
			{
				RunCloudbase();
			}
			return;
		}
		bool flag2 = true;
		if (try_time >= 7 && dataObj == null)
		{
			tips.text = "网络连接失败";
			Play_Music(1);
			title.color = new Color(255f, 255f, 255f);
			StartCoroutine(Wait_To_Quit());
			flag2 = false;
		}
		else if (try_time >= 7 && dataObj != null)
		{
			for (int k = 0; k < dataObj[0].build_number.Length; k++)
			{
				if (Score_System.Version == dataObj[0].build_number[k])
				{
					tips.text = "版本验证成功";
					Play_Music(0);
					CancelInvoke();
					Invoke("Load_Set_Scene", 12f);
					flag2 = false;
				}
				else
				{
					tips.text = "网络验证中……";
				}
			}
		}
		if (try_time >= 7 && flag2 && dataObj != null)
		{
			tips.text = "应用版本过低，请升级到最新版本";
			Play_Music(1);
			title.color = new Color(0f, 0f, 0f);
			StartCoroutine(Wait_To_Quit());
		}
	}

	private void Play_Music(int code)
	{
		switch (code)
		{
		case 0:
			music.clip = succeed;
			break;
		case 1:
			music.clip = failure;
			break;
		}
		music.Play();
	}

	private void Load_Set_Scene()
	{
		RenderSettings.skybox = null;
		touch.gameObject.SetActive(value: true);
		Score_System.next_Scence = 1;
		touch.Go_To_Next_Scence();
	}
}
public class VersionChecking
{
	public float[] build_number;
}
public class Article_Button : MonoBehaviour
{
	private Button btn;

	private int evaluate_Time;

	private Audio_System audio_System;

	private void Start()
	{
		audio_System = base.transform.parent.parent.parent.parent.GetChild(5).GetComponent<Audio_System>();
		btn = GetComponent<Button>();
		btn.onClick.AddListener(OnClick);
	}

	private void Update()
	{
	}

	private void OnClick()
	{
		audio_System.Button_Sound(3);
		int index = Convert.ToInt32(base.gameObject.name);
		base.transform.parent.parent.parent.GetChild(1).GetChild(0).GetComponent<Text>()
			.text = Tencent_Cloudbase.dataObj[index].name;
		base.transform.parent.parent.parent.GetChild(1).GetChild(2).GetComponent<Text>()
			.text = "文章介绍：" + Tencent_Cloudbase.dataObj[index].brief + "。";
		int num = Evaluate_Time(Tencent_Cloudbase.dataObj[index].article);
		if (num <= 60 && num >= 1)
		{
			base.transform.parent.parent.parent.GetChild(1).GetChild(1).GetComponent<Text>()
				.text = "建议时长：" + num + "分钟。";
			base.transform.parent.parent.parent.GetChild(2).gameObject.SetActive(value: true);
			base.transform.parent.parent.parent.GetChild(2).GetChild(0).GetComponent<Slider>()
				.value = num;
			Score_System.Current_Articles = Tencent_Cloudbase.dataObj[index].article;
			Score_System.Image_List = Tencent_Cloudbase.dataObj[index].imgList;
			Score_System.time_Seconds = num * 60;
			if (Score_System.Current_Articles != null)
			{
				base.transform.parent.parent.parent.GetChild(3).GetChild(1).gameObject.SetActive(value: true);
			}
			else
			{
				base.transform.parent.parent.parent.GetChild(3).GetChild(1).gameObject.SetActive(value: false);
			}
		}
		else if (num > 60)
		{
			base.transform.parent.parent.parent.GetChild(1).GetChild(1).GetComponent<Text>()
				.text = "此文章篇幅过长，预估演讲时间将超过1小时，建议缩减内容后重新上传。";
			base.transform.parent.parent.parent.GetChild(3).GetChild(1).gameObject.SetActive(value: false);
			base.transform.parent.parent.parent.GetChild(2).gameObject.SetActive(value: false);
		}
		else
		{
			base.transform.parent.parent.parent.GetChild(1).GetChild(1).GetComponent<Text>()
				.text = "此文章篇幅过短，预估演讲时间不到1分钟，建议增加内容后重新上传。";
			base.transform.parent.parent.parent.GetChild(3).GetChild(1).gameObject.SetActive(value: false);
			base.transform.parent.parent.parent.GetChild(2).gameObject.SetActive(value: false);
		}
	}

	private int Evaluate_Time(string[] article)
	{
		int num = 0;
		for (int i = 0; i < article.Length; i++)
		{
			int length = Regex.Replace(article[i], "[ \\[ \\] \\^ \\-_*×――(^)（^）$%~!@#$…&%￥—+=<>《》!！??？:：•`·、。，；,.;\"‘’“”-]", "").Length;
			num += length;
		}
		evaluate_Time = Convert.ToInt32(num / 100);
		return evaluate_Time;
	}
}
public class Audience_Generator : MonoBehaviour
{
	public GameObject[] audience_List;

	public Transform door_Dir;

	public Transform Toilet;

	public GameObject light_1;

	public GameObject light_2;

	public Audio_System audio_System;

	private int current_difficulty_level;

	private int current_seat_num;

	private int Audience_Headcount;

	private List<int> Audience_Information;

	private void Start()
	{
		current_difficulty_level = Score_System.difficulty_level;
		Initialize_Seat();
	}

	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.A))
		{
			Generate_A_Audience();
		}
		if (Input.GetKeyUp(KeyCode.S))
		{
			Choose_One_Leave();
		}
		if (Input.GetKeyUp(KeyCode.D))
		{
			Choose_One_Anxiety();
		}
	}

	public void Initialize_Seat()
	{
		if (Score_System.time_Seconds >= 900f)
		{
			current_seat_num = 63;
			light_1.SetActive(value: true);
			light_2.SetActive(value: true);
			for (int i = 0; i <= 63; i++)
			{
				Score_System.seat_Num[i] = true;
			}
		}
		else
		{
			current_seat_num = 32;
			light_1.SetActive(value: true);
			light_2.SetActive(value: false);
			for (int j = 0; j < 32; j++)
			{
				Score_System.seat_Num[j] = true;
			}
		}
	}

	public void Generate_A_Audience()
	{
		audio_System.When_A_Audience_Came(Audience_Headcount);
		switch (current_difficulty_level)
		{
		case 1:
		{
			int num5 = UnityEngine.Random.Range(0, 4);
			UnityEngine.Object.Instantiate(audience_List[num5], door_Dir).GetComponent<Navigation_AI>().character_Code = num5;
			break;
		}
		case 2:
		{
			int num4 = UnityEngine.Random.Range(0, 6);
			UnityEngine.Object.Instantiate(audience_List[num4], door_Dir).GetComponent<Navigation_AI>().character_Code = num4;
			break;
		}
		case 3:
		{
			int num3 = UnityEngine.Random.Range(0, 8);
			UnityEngine.Object.Instantiate(audience_List[num3], door_Dir).GetComponent<Navigation_AI>().character_Code = num3;
			break;
		}
		case 4:
		{
			int num2 = UnityEngine.Random.Range(0, 10);
			UnityEngine.Object.Instantiate(audience_List[num2], door_Dir).GetComponent<Navigation_AI>().character_Code = num2;
			break;
		}
		case 5:
		{
			int num = UnityEngine.Random.Range(0, 10);
			UnityEngine.Object.Instantiate(audience_List[num], door_Dir).GetComponent<Navigation_AI>().character_Code = num;
			break;
		}
		}
	}

	public void Initial_Audience()
	{
		switch (Score_System.difficulty_level)
		{
		case 1:
		{
			int num4 = UnityEngine.Random.Range(6, 10);
			for (int l = 0; l <= num4; l++)
			{
				Generate_A_Audience();
			}
			break;
		}
		case 2:
		{
			int num2 = UnityEngine.Random.Range(5, 8);
			for (int j = 0; j <= num2; j++)
			{
				Generate_A_Audience();
			}
			break;
		}
		case 3:
		{
			int num3 = UnityEngine.Random.Range(3, 6);
			for (int k = 0; k <= num3; k++)
			{
				Generate_A_Audience();
			}
			break;
		}
		case 4:
		{
			int num = UnityEngine.Random.Range(1, 4);
			for (int i = 0; i <= num; i++)
			{
				Generate_A_Audience();
			}
			break;
		}
		case 5:
			Generate_A_Audience();
			break;
		}
	}

	public void Clean_Audience()
	{
		Initialize_Seat();
		for (int i = 0; i < door_Dir.childCount; i++)
		{
			UnityEngine.Object.Destroy(door_Dir.GetChild(i).gameObject);
		}
	}

	public void Piss_And_Return(int code)
	{
		UnityEngine.Object.Instantiate(audience_List[code], Toilet.position, Toilet.rotation, door_Dir).GetComponent<Navigation_AI>().character_Code = code;
	}

	public void Choose_One_Leave()
	{
		audio_System.When_A_Audience_Leave(Audience_Headcount);
		if (door_Dir.childCount != 0)
		{
			int index = UnityEngine.Random.Range(0, door_Dir.childCount);
			door_Dir.GetChild(index).GetComponent<Navigation_AI>().Leave_The_Auditorium();
		}
	}

	public void Choose_One_Anxiety()
	{
		Audience_Information = new List<int>();
		for (int i = 0; i < door_Dir.childCount; i++)
		{
			if (door_Dir.GetChild(i).GetComponent<Navigation_AI>().Can_Anxiety)
			{
				Audience_Information.Add(i);
			}
		}
		if (Audience_Information.Count != 0)
		{
			int index = UnityEngine.Random.Range(0, Audience_Information.Count);
			door_Dir.GetChild(Audience_Information[index]).GetComponent<Navigation_AI>().Anxious_In_The_Hall();
			int num = Audience_Headcount - Audience_Information.Count;
			audio_System.When_A_Audience_Anxiety(num);
		}
	}

	public void Event_Listeners(float sim, float rhythm)
	{
		Audience_Information = new List<int>();
		int num = Convert.ToInt32(sim * 100f);
		int num2 = Convert.ToInt32(rhythm * 100f);
		Audience_Headcount = 0;
		for (int i = 0; i < door_Dir.childCount; i++)
		{
			Audience_Headcount++;
		}
		if (Audience_Information != null || Audience_Information.Count != 0)
		{
			audio_System.Is_Environment_Noisy(Audience_Headcount, Audience_Information.Count);
		}
		switch (current_difficulty_level)
		{
		case 1:
			if (num >= 80 && Audience_Headcount < current_seat_num)
			{
				Generate_A_Audience();
			}
			else if (num < 80 && Audience_Headcount > 0)
			{
				Choose_One_Leave();
			}
			else if ((num < 80 || Audience_Headcount < current_seat_num) && num < 80)
			{
				_ = Audience_Headcount;
			}
			break;
		case 2:
			if (num >= 90 && Audience_Headcount < current_seat_num)
			{
				Generate_A_Audience();
			}
			else if (num < 90 && Audience_Headcount > 0)
			{
				Choose_One_Leave();
			}
			else if (num2 < 70 && Audience_Headcount > 0)
			{
				Choose_One_Anxiety();
			}
			else if ((num < 90 || Audience_Headcount < current_seat_num) && num < 90)
			{
				_ = Audience_Headcount;
			}
			break;
		case 3:
			if (num >= 95 && Audience_Headcount < current_seat_num)
			{
				Generate_A_Audience();
			}
			else if ((num < 80 || num2 < 50) && Audience_Headcount > 0)
			{
				Choose_One_Leave();
			}
			else if ((num < 95 || (70 <= num2 && rhythm < 80f)) && Audience_Headcount > 0)
			{
				Choose_One_Anxiety();
			}
			else if ((num < 95 || Audience_Headcount < current_seat_num) && num < 95)
			{
				_ = Audience_Headcount;
			}
			break;
		case 4:
			if (num >= 95 && num2 >= 80 && Audience_Headcount < current_seat_num)
			{
				Generate_A_Audience();
			}
			else if ((num < 95 || num2 < 80) && Audience_Headcount > 0)
			{
				Choose_One_Leave();
			}
			else if ((num < 95 || (80 <= num2 && rhythm < 90f)) && Audience_Headcount > 0)
			{
				Choose_One_Anxiety();
			}
			else if ((num < 95 || Audience_Headcount < current_seat_num) && num < 95)
			{
				_ = Audience_Headcount;
			}
			break;
		case 5:
			if (num >= 95 && num2 >= 90 && Audience_Headcount < current_seat_num)
			{
				Generate_A_Audience();
			}
			else if ((num < 95 || num2 < 90) && Audience_Headcount > 0)
			{
				Choose_One_Leave();
			}
			else if ((num < 95 || (90 <= num2 && rhythm < 95f)) && Audience_Headcount > 0)
			{
				Choose_One_Anxiety();
			}
			else if ((num < 95 || Audience_Headcount < current_seat_num) && num < 95)
			{
				_ = Audience_Headcount;
			}
			break;
		}
	}
}
public class Audio_System : MonoBehaviour
{
	public AudioClip[] audience_Sound;

	public AudioClip[] button_Sound;

	public Transform balloon;

	private List<int> player_Information;

	private bool isRotate;

	private void Start()
	{
	}

	private void Update()
	{
		if (balloon.gameObject.activeSelf && isRotate)
		{
			balloon.Rotate(Vector3.up * 1f * Time.deltaTime, Space.World);
		}
	}

	private IEnumerator Wait_In_Play(int num)
	{
		int num2 = UnityEngine.Random.Range(1, 3);
		yield return new WaitForSeconds(num2);
		base.transform.GetChild(num).GetComponent<AudioSource>().Play();
	}

	private List<int> Searching_Player_Information()
	{
		player_Information = new List<int>();
		for (int i = 0; i < 4; i++)
		{
			if (!base.transform.GetChild(i).GetComponent<AudioSource>().isPlaying)
			{
				player_Information.Add(i);
			}
		}
		return player_Information;
	}

	public void When_A_Audience_Came(int num)
	{
		base.transform.GetChild(3).GetComponent<AudioSource>().clip = audience_Sound[12];
		base.transform.GetChild(3).GetComponent<AudioSource>().Play();
		if (num < 10 && num > 1)
		{
			player_Information = Searching_Player_Information();
			if (player_Information.Count != 0)
			{
				int num2 = UnityEngine.Random.Range(0, player_Information.Count);
				base.transform.GetChild(player_Information[num2]).GetComponent<AudioSource>().clip = audience_Sound[0];
				StartCoroutine(Wait_In_Play(num2));
			}
		}
		else if (num >= 10)
		{
			player_Information = Searching_Player_Information();
			if (player_Information.Count != 0)
			{
				int num3 = UnityEngine.Random.Range(0, player_Information.Count);
				base.transform.GetChild(player_Information[num3]).GetComponent<AudioSource>().clip = audience_Sound[1];
				StartCoroutine(Wait_In_Play(num3));
			}
		}
	}

	public void When_A_Audience_Anxiety(int num)
	{
		if (num < 10 && num > 3)
		{
			player_Information = Searching_Player_Information();
			if (player_Information.Count != 0)
			{
				int num2 = UnityEngine.Random.Range(0, player_Information.Count);
				base.transform.GetChild(player_Information[num2]).GetComponent<AudioSource>().clip = audience_Sound[2];
				StartCoroutine(Wait_In_Play(num2));
			}
		}
		else if (num >= 10)
		{
			player_Information = Searching_Player_Information();
			if (player_Information.Count != 0)
			{
				int num3 = UnityEngine.Random.Range(0, player_Information.Count);
				base.transform.GetChild(player_Information[num3]).GetComponent<AudioSource>().clip = audience_Sound[3];
				StartCoroutine(Wait_In_Play(num3));
			}
		}
	}

	public void When_A_Audience_Leave(int num)
	{
		if (num < 10 && num > 1)
		{
			player_Information = Searching_Player_Information();
			if (player_Information.Count != 0)
			{
				int num2 = UnityEngine.Random.Range(0, player_Information.Count);
				base.transform.GetChild(player_Information[num2]).GetComponent<AudioSource>().clip = audience_Sound[4];
				StartCoroutine(Wait_In_Play(num2));
			}
		}
		else if (num >= 10)
		{
			player_Information = Searching_Player_Information();
			if (player_Information.Count != 0)
			{
				int num3 = UnityEngine.Random.Range(0, player_Information.Count);
				base.transform.GetChild(player_Information[num3]).GetComponent<AudioSource>().clip = audience_Sound[5];
				StartCoroutine(Wait_In_Play(num3));
			}
		}
	}

	public void Is_Environment_Noisy(int all, int gen)
	{
		float num = gen / all;
		if (all >= 15)
		{
			if ((double)num >= 0.6 && num <= 1f)
			{
				base.transform.GetChild(5).GetComponent<AudioSource>().Stop();
				player_Information = Searching_Player_Information();
				if (player_Information.Count != 0)
				{
					int num2 = UnityEngine.Random.Range(0, player_Information.Count);
					base.transform.GetChild(player_Information[num2]).GetComponent<AudioSource>().clip = audience_Sound[11];
					StartCoroutine(Wait_In_Play(num2));
				}
			}
			else if ((double)num < 0.6 && (double)num >= 0.4)
			{
				if (!base.transform.GetChild(5).GetComponent<AudioSource>().isPlaying)
				{
					base.transform.GetChild(5).GetComponent<AudioSource>().clip = audience_Sound[10];
					base.transform.GetChild(5).GetComponent<AudioSource>().volume = 0.02f;
					base.transform.GetChild(5).GetComponent<AudioSource>().Play();
				}
				else
				{
					base.transform.GetChild(5).GetComponent<AudioSource>().volume = 0.02f;
				}
			}
			else if ((double)num < 0.4 && (double)num >= 0.2)
			{
				player_Information = Searching_Player_Information();
				if (player_Information.Count != 0)
				{
					int num3 = UnityEngine.Random.Range(0, player_Information.Count);
					base.transform.GetChild(player_Information[num3]).GetComponent<AudioSource>().clip = audience_Sound[3];
					StartCoroutine(Wait_In_Play(num3));
				}
				if (!base.transform.GetChild(5).GetComponent<AudioSource>().isPlaying)
				{
					base.transform.GetChild(5).GetComponent<AudioSource>().clip = audience_Sound[10];
					base.transform.GetChild(5).GetComponent<AudioSource>().volume = 0.06f;
					base.transform.GetChild(5).GetComponent<AudioSource>().Play();
				}
				else
				{
					base.transform.GetChild(5).GetComponent<AudioSource>().volume = 0.06f;
				}
			}
			else if ((double)num < 0.2 && num > 0f)
			{
				player_Information = Searching_Player_Information();
				if (player_Information.Count != 0)
				{
					int num4 = UnityEngine.Random.Range(0, player_Information.Count);
					base.transform.GetChild(player_Information[num4]).GetComponent<AudioSource>().clip = audience_Sound[3];
					StartCoroutine(Wait_In_Play(num4));
				}
				player_Information = Searching_Player_Information();
				if (player_Information.Count != 0)
				{
					int num5 = UnityEngine.Random.Range(0, player_Information.Count);
					base.transform.GetChild(player_Information[num5]).GetComponent<AudioSource>().clip = audience_Sound[2];
					StartCoroutine(Wait_In_Play(num5));
				}
				if (!base.transform.GetChild(5).GetComponent<AudioSource>().isPlaying)
				{
					base.transform.GetChild(5).GetComponent<AudioSource>().clip = audience_Sound[10];
					base.transform.GetChild(5).GetComponent<AudioSource>().volume = 0.14f;
					base.transform.GetChild(5).GetComponent<AudioSource>().Play();
				}
				else
				{
					base.transform.GetChild(5).GetComponent<AudioSource>().volume = 0.14f;
				}
			}
		}
		else if (all < 15 && all > 7)
		{
			if ((double)num >= 0.6 && num <= 1f)
			{
				base.transform.GetChild(5).GetComponent<AudioSource>().Stop();
				player_Information = Searching_Player_Information();
				if (player_Information.Count != 0)
				{
					int num6 = UnityEngine.Random.Range(0, player_Information.Count);
					base.transform.GetChild(player_Information[num6]).GetComponent<AudioSource>().clip = audience_Sound[11];
					StartCoroutine(Wait_In_Play(num6));
				}
			}
			else if ((double)num < 0.6 && (double)num >= 0.4)
			{
				if (!base.transform.GetChild(5).GetComponent<AudioSource>().isPlaying)
				{
					base.transform.GetChild(5).GetComponent<AudioSource>().clip = audience_Sound[9];
					base.transform.GetChild(5).GetComponent<AudioSource>().volume = 0.02f;
					base.transform.GetChild(5).GetComponent<AudioSource>().Play();
				}
				else
				{
					base.transform.GetChild(5).GetComponent<AudioSource>().volume = 0.02f;
				}
			}
			else if ((double)num < 0.4 && (double)num >= 0.2)
			{
				player_Information = Searching_Player_Information();
				if (player_Information.Count != 0)
				{
					int num7 = UnityEngine.Random.Range(0, player_Information.Count);
					base.transform.GetChild(player_Information[num7]).GetComponent<AudioSource>().clip = audience_Sound[3];
					StartCoroutine(Wait_In_Play(num7));
				}
				if (!base.transform.GetChild(5).GetComponent<AudioSource>().isPlaying)
				{
					base.transform.GetChild(5).GetComponent<AudioSource>().clip = audience_Sound[9];
					base.transform.GetChild(5).GetComponent<AudioSource>().volume = 0.06f;
					base.transform.GetChild(5).GetComponent<AudioSource>().Play();
				}
				else
				{
					base.transform.GetChild(5).GetComponent<AudioSource>().volume = 0.06f;
				}
			}
			else if ((double)num < 0.2 && num > 0f)
			{
				player_Information = Searching_Player_Information();
				if (player_Information.Count != 0)
				{
					int num8 = UnityEngine.Random.Range(0, player_Information.Count);
					base.transform.GetChild(player_Information[num8]).GetComponent<AudioSource>().clip = audience_Sound[3];
					StartCoroutine(Wait_In_Play(num8));
				}
				player_Information = Searching_Player_Information();
				if (player_Information.Count != 0)
				{
					int num9 = UnityEngine.Random.Range(0, player_Information.Count);
					base.transform.GetChild(player_Information[num9]).GetComponent<AudioSource>().clip = audience_Sound[2];
					StartCoroutine(Wait_In_Play(num9));
				}
				if (!base.transform.GetChild(5).GetComponent<AudioSource>().isPlaying)
				{
					base.transform.GetChild(5).GetComponent<AudioSource>().clip = audience_Sound[9];
					base.transform.GetChild(5).GetComponent<AudioSource>().volume = 0.14f;
					base.transform.GetChild(5).GetComponent<AudioSource>().Play();
				}
				else
				{
					base.transform.GetChild(5).GetComponent<AudioSource>().volume = 0.14f;
				}
			}
		}
		else
		{
			if (all > 7)
			{
				return;
			}
			if ((double)num >= 0.6 && num <= 1f)
			{
				base.transform.GetChild(5).GetComponent<AudioSource>().Stop();
			}
			else if ((!((double)num < 0.6) || !((double)num >= 0.2)) && (double)num < 0.2 && num > 0f)
			{
				player_Information = Searching_Player_Information();
				if (player_Information.Count != 0)
				{
					int num10 = UnityEngine.Random.Range(0, player_Information.Count);
					base.transform.GetChild(player_Information[num10]).GetComponent<AudioSource>().clip = audience_Sound[2];
					StartCoroutine(Wait_In_Play(num10));
				}
			}
		}
	}

	public void Button_Sound(int code)
	{
		switch (code)
		{
		case 1:
			base.transform.GetChild(4).GetComponent<AudioSource>().clip = button_Sound[0];
			base.transform.GetChild(4).GetComponent<AudioSource>().Play();
			break;
		case 2:
			base.transform.GetChild(4).GetComponent<AudioSource>().clip = button_Sound[1];
			base.transform.GetChild(4).GetComponent<AudioSource>().Play();
			break;
		case 3:
			base.transform.GetChild(4).GetComponent<AudioSource>().clip = button_Sound[2];
			base.transform.GetChild(4).GetComponent<AudioSource>().Play();
			break;
		}
	}

	public void Play_End_Music()
	{
		AudioClip clip = audience_Sound[14];
		base.transform.GetChild(5).GetComponent<AudioSource>().clip = clip;
		base.transform.GetChild(5).GetComponent<AudioSource>().Play();
		balloon.gameObject.SetActive(value: true);
		isRotate = true;
		GameObject.Find("灯光系统").transform.GetChild(0).gameObject.SetActive(value: true);
		GameObject.Find("灯光系统").transform.GetChild(1).gameObject.SetActive(value: true);
		GameObject.Find("灯光系统").transform.GetChild(0).GetComponent<Light>().intensity = 20f;
		GameObject.Find("灯光系统").transform.GetChild(1).GetComponent<Light>().intensity = 20f;
	}
}
[RequireComponent(typeof(AudioListener))]
[RequireComponent(typeof(AudioSource))]
public class BaiduASR : MonoBehaviour
{
	public xunfeiTest xunfei;

	private bool canRec = true;

	private string original_Text;

	private string compound_Text;

	private float sim_Para = float.NaN;

	private string appId_1 = "23093271";

	private string apiKey_1 = "qYIyGPlWp0lKlpQDYG81OeAs";

	private string secretKey_1 = "csIB97iesyjZd1enGRsi4w0vzveriwso";

	private string appId_2 = "23293288";

	private string apiKey_2 = "SYSrBHxxazw72scOnIs7IzVc";

	private string secretKey_2 = "An0iPNG9dzDN6Md44qKWGB3WzqlGRKmg";

	private string accessToken_1 = string.Empty;

	private string accessToken_2 = string.Empty;

	private string asrResult = string.Empty;

	private string simResult = string.Empty;

	private bool isHaveMic;

	private string currentDeviceName = string.Empty;

	private int recordFrequency = 8000;

	private double lastPressTimestamp;

	private int recordMaxLength = 60;

	private int trueLength;

	[HideInInspector]
	public AudioClip saveAudioClip;

	private Text textTips;

	private Text textResult;

	private Text simText;

	private AudioSource audioSource;

	private void Start()
	{
		xunfei = GameObject.Find("讯飞语音").GetComponent<xunfeiTest>();
		xunfei.进入测试演讲场景的准备();
		textTips = base.transform.GetChild(0).GetComponent<Text>();
		audioSource = GetComponent<AudioSource>();
		textResult = base.transform.GetChild(1).GetComponent<Text>();
		simText = base.transform.GetChild(3).GetComponent<Text>();
	}

	private void Update()
	{
		if ((Controller.UPvr_GetKeyDown(0, Pvr_KeyCode.TRIGGER) || Controller.UPvr_GetKeyDown(1, Pvr_KeyCode.TRIGGER) || Input.GetKeyDown(KeyCode.R)) && canRec && canRec)
		{
			textResult.text = "";
			simText.text = "";
			OnPointerDown();
			canRec = false;
		}
		if ((Controller.UPvr_GetKeyUp(0, Pvr_KeyCode.TRIGGER) || Controller.UPvr_GetKeyUp(1, Pvr_KeyCode.TRIGGER) || Input.GetKeyUp(KeyCode.R)) && !canRec)
		{
			OnPointerUp();
		}
	}

	private IEnumerator Wait_10_minute()
	{
		yield return new WaitForSeconds(8f);
		if (!canRec)
		{
			语音识别失败处理();
		}
	}

	public bool StartRecording(bool isLoop = false)
	{
		if (!isHaveMic || Microphone.IsRecording(currentDeviceName))
		{
			return false;
		}
		lastPressTimestamp = GetTimestampOfNowWithMillisecond();
		saveAudioClip = Microphone.Start(currentDeviceName, isLoop, recordMaxLength, recordFrequency);
		return true;
	}

	public int EndRecording()
	{
		if (!isHaveMic || !Microphone.IsRecording(currentDeviceName))
		{
			return 0;
		}
		Microphone.End(currentDeviceName);
		return Mathf.CeilToInt((float)(GetTimestampOfNowWithMillisecond() - lastPressTimestamp) / 1000f);
	}

	public double GetTimestampOfNowWithMillisecond()
	{
		return (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000L) / 10000;
	}

	public void OnPointerDown()
	{
		textTips.text = "请在完成阅读后，松开手柄扳机键，并等待分析结果";
		xunfei.开始语音识别();
		xunfei.切换场景开关(code: true);
	}

	public void OnPointerUp()
	{
		xunfei.停止语音识别();
		textTips.text = "";
		StartCoroutine(Wait_10_minute());
		original_Text = base.transform.GetChild(2).GetComponent<Text>().text;
		base.transform.GetChild(2).GetComponent<Text>().text = "网络传输中，请停止任何手柄操作等待分析结果";
	}

	private IEnumerator _GetAccessToken_1()
	{
		string uri = $"https://openapi.baidu.com/oauth/2.0/token?grant_type=client_credentials&client_id={apiKey_1}&client_secret={secretKey_1}";
		UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri);
		yield return unityWebRequest.SendWebRequest();
		if (unityWebRequest.isDone)
		{
			Match match = Regex.Match(unityWebRequest.downloadHandler.text, "access_token.:.(.*?).,");
			if (match.Success)
			{
				accessToken_1 = match.Groups[1].ToString();
			}
			else
			{
				textResult.text = "验证错误,获取AccessToken失败!!!";
			}
		}
	}

	private IEnumerator _GetAccessToken_2()
	{
		string uri = $"https://openapi.baidu.com/oauth/2.0/token?grant_type=client_credentials&client_id={apiKey_2}&client_secret={secretKey_2}";
		UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri);
		yield return unityWebRequest.SendWebRequest();
		if (unityWebRequest.isDone)
		{
			Match match = Regex.Match(unityWebRequest.downloadHandler.text, "access_token.:.(.*?).,");
			if (match.Success)
			{
				accessToken_2 = match.Groups[1].ToString();
			}
			else
			{
				textResult.text = "验证错误,获取AccessToken失败!!!";
			}
		}
	}

	private IEnumerator _StartBaiduYuYin()
	{
		if (string.IsNullOrEmpty(accessToken_1))
		{
			yield return _GetAccessToken_1();
		}
		asrResult = string.Empty;
		float[] array = new float[recordFrequency * trueLength * saveAudioClip.channels];
		saveAudioClip.GetData(array, 0);
		short[] array2 = new short[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = (short)(array[i] * 32767f);
		}
		byte[] array3 = new byte[array2.Length * 2];
		Buffer.BlockCopy(array2, 0, array3, 0, array3.Length);
		string uri = string.Format("{0}?cuid={1}&token={2}", "https://vop.baidu.com/server_api", SystemInfo.deviceUniqueIdentifier, accessToken_1);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddBinaryData("audio", array3);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		unityWebRequest.SetRequestHeader("Content-Type", "audio/pcm;rate=" + recordFrequency);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			yield break;
		}
		asrResult = unityWebRequest.downloadHandler.text;
		if (Regex.IsMatch(asrResult, "err_msg.:.success"))
		{
			Match match = Regex.Match(asrResult, "result.:..(.*?)..]");
			if (match.Success)
			{
				asrResult = "<color=#000000>对您的语音识别结果为：</color>" + match.Groups[1].ToString();
				compound_Text = match.Groups[1].ToString();
				StartCoroutine(_StartBaiduSimilarity());
			}
		}
		else
		{
			asrResult = "识别结果为空";
		}
		textResult.text = asrResult;
	}

	private IEnumerator _StartBaiduSimilarity()
	{
		if (string.IsNullOrEmpty(accessToken_2))
		{
			yield return _GetAccessToken_2();
		}
		simResult = string.Empty;
		string uri = "https://aip.baidubce.com/rpc/2.0/nlp/v2/simnet?charset=UTF-8&access_token=" + accessToken_2;
		string s = "{\"text_1\":\"" + original_Text + "\",\"text_2\":\"" + compound_Text + "\"}";
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, "POST");
		unityWebRequest.uploadHandler = new UploadHandlerRaw(bytes);
		unityWebRequest.SetRequestHeader("Content-Type", "application/json;charset=utf-8");
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			yield break;
		}
		simResult = unityWebRequest.downloadHandler.text;
		if (Regex.IsMatch(simResult, "texts"))
		{
			Match match = Regex.Match(simResult, "score.:(.*),");
			UnityEngine.Debug.Log(match);
			if (match.Success)
			{
				simResult = match.Groups[1].ToString();
				sim_Para = Convert.ToSingle(simResult);
				simText.text = "相似度：" + Convert.ToInt32(sim_Para * 100f) + "%";
				textTips.text = "请在按住手柄的扳机键后，清晰的念出以下的红字";
				Similarity_Conclusion();
				Random_Statement();
			}
		}
		else
		{
			textTips.text = "录音识别错误，请按住手柄扳机键重新演讲此句";
			simText.text = "识别结果为空";
		}
	}

	private void Similarity_Conclusion()
	{
		if ((double)sim_Para >= 0.8)
		{
			base.transform.GetChild(4).GetChild(0).gameObject.SetActive(value: true);
		}
		else
		{
			base.transform.GetChild(4).GetChild(0).gameObject.SetActive(value: false);
		}
	}

	public void Random_Statement()
	{
		switch (UnityEngine.Random.Range(1, 6))
		{
		case 1:
			base.transform.GetChild(2).GetComponent<Text>().text = "黑化肥发黑不发灰,灰化肥发灰不发黑";
			break;
		case 2:
			base.transform.GetChild(2).GetComponent<Text>().text = "吃葡萄不吐葡萄皮，不吃葡萄倒吐葡萄皮";
			break;
		case 3:
			base.transform.GetChild(2).GetComponent<Text>().text = "刘奶奶说牛奶奶的牛奶不如柳奶奶的牛奶";
			break;
		case 4:
			base.transform.GetChild(2).GetComponent<Text>().text = "有个小孩叫小杜, 上街打醋又买布";
			break;
		case 5:
			base.transform.GetChild(2).GetComponent<Text>().text = "老虎遇老鼠，老鼠遇老虎，老虎咬老鼠，老鼠躲老虎";
			break;
		}
	}

	public void 语音识别结果返回处理(string compoundText)
	{
		canRec = true;
		asrResult = "<color=#000000>对您的语音识别结果为：</color>" + compoundText;
		textResult.text = asrResult;
		Similarity_Calculation(original_Text, compoundText);
	}

	public void 语音识别失败处理()
	{
		canRec = true;
		simText.text = "识别结果为空";
		textTips.text = "请在按住手柄的扳机键后，清晰的念出以下的红字";
	}

	public void Similarity_Calculation(string txt1, string txt2)
	{
		List<char> list = txt1.ToCharArray().ToList();
		List<char> list2 = txt2.ToCharArray().ToList();
		List<char> list3 = list.Union(list2).ToList();
		List<int> list4 = new List<int>();
		List<int> list5 = new List<int>();
		foreach (char str in list3)
		{
			list4.Add(list.Where((char x) => x == str).Count());
			list5.Add(list2.Where((char x) => x == str).Count());
		}
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		for (int i = 0; i < list3.Count; i++)
		{
			num += (double)(list4[i] * list5[i]);
			num2 += Math.Pow(list4[i], 2.0);
			num3 += Math.Pow(list5[i], 2.0);
		}
		double num4 = num / (Math.Sqrt(num2) * Math.Sqrt(num3));
		sim_Para = Convert.ToSingle(num4);
		simText.text = "相似度：" + Convert.ToInt32(num4 * 100.0) + "%";
		textTips.text = "请在按住手柄的扳机键后，清晰的念出以下的红字";
		Similarity_Conclusion();
		Random_Statement();
	}
}
[RequireComponent(typeof(AudioListener))]
[RequireComponent(typeof(AudioSource))]
public class Baidu_ASR_Self : MonoBehaviour
{
	public Game_Control game_Control;

	public GameObject TimeLine;

	public RectTransform hasGo;

	public xunfeiTest xunfei;

	public int hasTime;

	private bool canRec;

	private bool onRec;

	private string appId = "23093271";

	private string apiKey = "qYIyGPlWp0lKlpQDYG81OeAs";

	private string secretKey = "csIB97iesyjZd1enGRsi4w0vzveriwso";

	private string accessToken = string.Empty;

	private string asrResult = string.Empty;

	private bool isHaveMic;

	private string currentDeviceName = string.Empty;

	private int recordFrequency = 8000;

	private double lastPressTimestamp;

	private int recordMaxLength = 60;

	private int trueLength;

	[HideInInspector]
	public AudioClip saveAudioClip;

	private Text textBtn;

	private Text textResult;

	private string tempSpeech;

	private AudioSource audioSource;

	private void Start()
	{
		canRec = true;
		if (Microphone.devices.Length != 0)
		{
			isHaveMic = true;
			currentDeviceName = Microphone.devices[0];
		}
		xunfei = GameObject.Find("讯飞语音").GetComponent<xunfeiTest>();
		xunfei.进入正式演讲场景的准备();
		textBtn = TimeLine.transform.GetChild(3).GetComponent<Text>();
		audioSource = GetComponent<AudioSource>();
		textResult = base.transform.GetChild(1).GetComponent<Text>();
	}

	private void Update()
	{
		if (Game_Control.Speach_Is_Start)
		{
			if (onRec)
			{
				hasTime = Mathf.CeilToInt((float)(GetTimestampOfNowWithMillisecond() - lastPressTimestamp) / 1000f);
				hasGo.sizeDelta = new Vector2(hasTime, 8f);
			}
			if ((Controller.UPvr_GetKeyDown(0, Pvr_KeyCode.TRIGGER) || Controller.UPvr_GetKeyDown(1, Pvr_KeyCode.TRIGGER) || Input.GetKeyDown(KeyCode.R)) && canRec && canRec)
			{
				OnPointerDown();
				game_Control.Press_And_Display();
				canRec = false;
				onRec = true;
			}
			if ((Controller.UPvr_GetKeyUp(0, Pvr_KeyCode.TRIGGER) || Controller.UPvr_GetKeyUp(1, Pvr_KeyCode.TRIGGER) || Input.GetKeyUp(KeyCode.R)) && !canRec)
			{
				OnPointerUp();
				hasGo.sizeDelta = new Vector2(0f, 8f);
				onRec = false;
			}
		}
		else
		{
			textBtn.text = "您的演讲仍未开始";
		}
	}

	private IEnumerator Wait_10_minute()
	{
		yield return new WaitForSeconds(8f);
		if (!canRec && !onRec)
		{
			语音识别失败处理();
		}
	}

	public bool StartRecording(bool isLoop = false)
	{
		lastPressTimestamp = GetTimestampOfNowWithMillisecond();
		return true;
	}

	public int EndRecording()
	{
		if (!isHaveMic || !Microphone.IsRecording(currentDeviceName))
		{
			return 0;
		}
		Microphone.End(currentDeviceName);
		return Mathf.CeilToInt((float)(GetTimestampOfNowWithMillisecond() - lastPressTimestamp) / 1000f);
	}

	public double GetTimestampOfNowWithMillisecond()
	{
		return (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000L) / 10000;
	}

	public void OnPointerDown()
	{
		textBtn.text = "讲话中…";
		xunfei.切换场景开关(code: false);
		xunfei.开始语音识别();
		StartRecording();
	}

	public void OnPointerUp()
	{
		textBtn.text = "处理中…";
		TimeLine.transform.parent.GetChild(0).GetChild(2).GetComponent<Text>()
			.text = "请等待……";
		xunfei.停止语音识别();
		StartCoroutine("Wait_10_minute");
		tempSpeech = TimeLine.transform.parent.GetChild(0).GetChild(2).GetComponent<Text>()
			.text;
	}

	private IEnumerator _GetAccessToken()
	{
		string uri = $"https://openapi.baidu.com/oauth/2.0/token?grant_type=client_credentials&client_id={apiKey}&client_secret={secretKey}";
		UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri);
		yield return unityWebRequest.SendWebRequest();
		if (unityWebRequest.isDone)
		{
			Match match = Regex.Match(unityWebRequest.downloadHandler.text, "access_token.:.(.*?).,");
			if (match.Success)
			{
				accessToken = match.Groups[1].ToString();
				yield break;
			}
			textBtn.text = "网络错误,请调试后重新尝试…";
			textResult.text = "验证错误,获取AccessToken失败!!!";
		}
	}

	private IEnumerator _StartBaiduYuYin()
	{
		if (string.IsNullOrEmpty(accessToken))
		{
			yield return _GetAccessToken();
		}
		asrResult = string.Empty;
		float[] array = new float[recordFrequency * trueLength * saveAudioClip.channels];
		saveAudioClip.GetData(array, 0);
		short[] array2 = new short[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = (short)(array[i] * 32767f);
		}
		byte[] array3 = new byte[array2.Length * 2];
		Buffer.BlockCopy(array2, 0, array3, 0, array3.Length);
		string uri = string.Format("{0}?cuid={1}&token={2}", "https://vop.baidu.com/server_api", SystemInfo.deviceUniqueIdentifier, accessToken);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddBinaryData("audio", array3);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		unityWebRequest.SetRequestHeader("Content-Type", "audio/pcm;rate=" + recordFrequency);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			yield break;
		}
		asrResult = unityWebRequest.downloadHandler.text;
		if (Regex.IsMatch(asrResult, "err_msg.:.success"))
		{
			Match match = Regex.Match(asrResult, "result.:..(.*?)..]");
			if (match.Success)
			{
				asrResult = match.Groups[1].ToString();
				game_Control.Strat_Baidu_Similarity(asrResult);
			}
		}
		else
		{
			textBtn.text = "录音识别错误，请重新演讲此句…";
			asrResult = "识别结果为空";
		}
		textResult.text = asrResult;
	}

	public void 语音识别结果返回处理(string compoundText)
	{
		StopCoroutine("Wait_10_minute");
		if (!canRec)
		{
			canRec = true;
			asrResult = compoundText;
			textResult.text = asrResult;
			game_Control.Strat_Baidu_Similarity(asrResult);
		}
	}

	public void 语音识别失败处理()
	{
		canRec = true;
		textBtn.text = "录音识别错误，请重新演讲此句…";
		TimeLine.transform.parent.GetChild(0).GetChild(2).GetComponent<Text>()
			.text = "按下扳机键重新演讲此句…";
	}

	public void 讯飞语音错误阶段提示(string TXT)
	{
		TimeLine.transform.parent.GetChild(0).GetChild(2).GetComponent<Text>()
			.text = TXT;
	}
}
public class Baidu_Similarity : MonoBehaviour
{
	public Game_Control game_Control;

	public Text textBtn;

	public Text textResult;

	private string appId = "23293288";

	private string apiKey = "SYSrBHxxazw72scOnIs7IzVc";

	private string secretKey = "An0iPNG9dzDN6Md44qKWGB3WzqlGRKmg";

	private string accessToken = string.Empty;

	private string original_Text;

	private string compound_Text;

	private string asrResult = string.Empty;

	private float sim_Para = float.NaN;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private IEnumerator _GetAccessToken()
	{
		string uri = $"https://openapi.baidu.com/oauth/2.0/token?grant_type=client_credentials&client_id={apiKey}&client_secret={secretKey}";
		UnityWebRequest unityWebRequest = UnityWebRequest.Get(uri);
		yield return unityWebRequest.SendWebRequest();
		if (unityWebRequest.isDone)
		{
			Match match = Regex.Match(unityWebRequest.downloadHandler.text, "access_token.:.(.*?).,");
			if (match.Success)
			{
				accessToken = match.Groups[1].ToString();
				yield break;
			}
			textBtn.text = "网络错误,请调试后重新尝试…";
			textResult.text = "验证错误,获取AccessToken失败!!!";
		}
	}

	private IEnumerator _StartBaiduYuYin()
	{
		if (string.IsNullOrEmpty(accessToken))
		{
			yield return _GetAccessToken();
		}
		asrResult = string.Empty;
		string uri = "https://aip.baidubce.com/rpc/2.0/nlp/v2/simnet?charset=UTF-8&access_token=" + accessToken;
		string s = "{\"text_1\":\"" + original_Text + "\",\"text_2\":\"" + compound_Text + "\"}";
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, "POST");
		unityWebRequest.uploadHandler = new UploadHandlerRaw(bytes);
		unityWebRequest.SetRequestHeader("Content-Type", "application/json;charset=utf-8");
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			yield break;
		}
		asrResult = unityWebRequest.downloadHandler.text;
		if (Regex.IsMatch(asrResult, "texts"))
		{
			Match match = Regex.Match(asrResult, "score.:(.*),");
			if (match.Success)
			{
				asrResult = match.Groups[1].ToString();
				sim_Para = Convert.ToSingle(asrResult);
				game_Control.Score_Assessment_System(sim_Para);
			}
		}
		else
		{
			textBtn.text = "录音识别错误，请重新演讲此句…";
			asrResult = "识别结果为空";
		}
	}

	public void Compare_Two_Sentences(string original, string compound)
	{
		original_Text = original;
		compound_Text = compound;
		sim_Para = Convert.ToSingle(Similarity_Calculation(original_Text, compound_Text));
		game_Control.Score_Assessment_System(sim_Para);
	}

	public double Similarity_Calculation(string txt1, string txt2)
	{
		List<char> list = txt1.ToCharArray().ToList();
		List<char> list2 = txt2.ToCharArray().ToList();
		List<char> list3 = list.Union(list2).ToList();
		List<int> list4 = new List<int>();
		List<int> list5 = new List<int>();
		foreach (char str in list3)
		{
			list4.Add(list.Where((char x) => x == str).Count());
			list5.Add(list2.Where((char x) => x == str).Count());
		}
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		for (int i = 0; i < list3.Count; i++)
		{
			num += (double)(list4[i] * list5[i]);
			num2 += Math.Pow(list4[i], 2.0);
			num3 += Math.Pow(list5[i], 2.0);
		}
		return num / (Math.Sqrt(num2) * Math.Sqrt(num3));
	}
}
public class CalibrationTouch : MonoBehaviour
{
	public GameObject sightLine;

	public GameObject tips;

	public GameObject obj_1;

	public GameObject obj_2;

	public GameObject obj_3;

	public GameObject obj_4;

	private bool isTrigger;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerStay(Collider other)
	{
		if (!isTrigger)
		{
			isTrigger = true;
			SceneManager.LoadScene(Score_System.next_Scence);
		}
	}

	public void Go_To_Next_Scence()
	{
		obj_1.SetActive(value: false);
		obj_2.SetActive(value: false);
		obj_3.SetActive(value: false);
		obj_4.SetActive(value: false);
		tips.SetActive(value: true);
		sightLine.SetActive(value: true);
	}
}
public class Sample_Article
{
	public static string[] springIsComing = new string[2] { "盼望着，盼望着，东风来了，春天的脚步近了。", "一切都像刚睡醒的样子，欣欣然张开了眼。山朗润起来了，水涨起来了，太阳的脸红起来了。" };
}
public class Score_System
{
	private static float version = 1.04f;

	private static float expend = 1f;

	private static string user_id = null;

	private static string role_id = null;

	public static string coin = null;

	public static string[] Current_Articles = null;

	public static string[] Image_List = null;

	public static float time_Seconds = 300f;

	public static float[] sim_Para;

	public static float[] read_Rhythm;

	public static int final_Sim = 0;

	public static int final_Rhythm = 0;

	public static int final_Score = 0;

	public static int difficulty_level = 1;

	public static int sim_Para_Weight = 7;

	public static int read_Rhythm_Weight = 3;

	public static bool[] seat_Num = new bool[64];

	public static int next_Scence = 2;

	public static bool show_Score = false;

	public static float Version => version;

	public static float Expend => expend;

	public static string User_id
	{
		get
		{
			return user_id;
		}
		set
		{
			user_id = value;
		}
	}

	public static string Role_id
	{
		get
		{
			return role_id;
		}
		set
		{
			role_id = value;
		}
	}
}
public class Game_Control : MonoBehaviour
{
	public static bool Speach_Is_Start;

	public GameObject My_Pico;

	public GameObject Start_Button;

	public GameObject Quit_Button;

	public Baidu_Similarity Baidu_Sim;

	public ImageDownload Img_Download;

	public Audience_Generator Generator;

	public Light score_Light;

	public Text shouldSpeech;

	public Text buttonText;

	public Text hint_Text;

	public Text sim_Para_Text;

	public Text read_Rhythm_Text;

	public Text final_Score_Text;

	public GameObject affirm_Button;

	public GameObject cancel_Button;

	public Transform headSet;

	public Pvr_UnitySDKHeadTrack headTrack;

	public CalibrationTouch touch;

	private float timeSpend;

	private string[] current_Article;

	private int current_Sentence_Num;

	private bool hasEnd;

	private int hasTimes = 3;

	public int sentence_Count;

	public int total_Words_Num;

	public int current_Words_Num;

	private void Start()
	{
		Current_Article_Analysis();
		Article_Total_Words_Count();
	}

	private void Update()
	{
	}

	public void Current_Article_Analysis()
	{
		if (Score_System.Current_Articles != null)
		{
			current_Article = Score_System.Current_Articles;
		}
		else
		{
			current_Article = Sample_Article.springIsComing;
		}
		sentence_Count = current_Article.Length;
		Score_System.sim_Para = new float[sentence_Count];
		Score_System.read_Rhythm = new float[sentence_Count];
	}

	public void StartOrStop_Speech()
	{
		if (!Speach_Is_Start)
		{
			Speach_Is_Start = true;
			shouldSpeech.alignment = TextAnchor.MiddleCenter;
			shouldSpeech.fontSize = 120;
			shouldSpeech.text = "<color=#B62F2C>按住扳机键开始显示第一段段讲稿</color>";
			buttonText.text = "结束演讲";
			hint_Text.text = "演讲开始";
			Img_Download.RunCloudbase(0);
			Generator.Clean_Audience();
			Generator.Initial_Audience();
			Quit_Button.SetActive(value: false);
			hasTimes--;
			if (hasTimes == 0)
			{
				hasEnd = true;
			}
		}
		else
		{
			Speach_Is_Start = false;
			shouldSpeech.alignment = TextAnchor.MiddleCenter;
			shouldSpeech.fontSize = 120;
			shouldSpeech.text = "--您还有" + hasTimes + "次重新开始的机会--";
			buttonText.text = "开始演讲";
			current_Sentence_Num = 0;
			hint_Text.text = "演讲结束";
			Generator.Clean_Audience();
			base.gameObject.GetComponent<GetTime>().TimeSpend = 0f;
			Quit_Button.SetActive(value: true);
			if (hasEnd)
			{
				Start_Button.SetActive(value: false);
			}
		}
	}

	public void Quit_This_Speech()
	{
		SceneManager.LoadScene(0);
	}

	public void Reading_Schedule_Control()
	{
		if (Controller.UPvr_GetTouchPadPosition(0) == new Vector2(255f, 128f) || Input.GetKeyUp(KeyCode.S))
		{
			if (current_Sentence_Num < current_Article.Length - 1)
			{
				current_Sentence_Num++;
				shouldSpeech.text = current_Article[current_Sentence_Num];
			}
			else
			{
				current_Sentence_Num = 0;
				shouldSpeech.text = current_Article[current_Sentence_Num];
			}
		}
		if (Controller.UPvr_GetTouchPadPosition(0) == new Vector2(0f, 128f) || Input.GetKeyUp(KeyCode.A))
		{
			if (current_Sentence_Num >= 1)
			{
				current_Sentence_Num--;
				shouldSpeech.text = current_Article[current_Sentence_Num];
			}
			else
			{
				current_Sentence_Num = 0;
				shouldSpeech.text = current_Article[current_Sentence_Num];
			}
		}
	}

	public void Strat_Baidu_Similarity(string compound)
	{
		Baidu_Sim.Compare_Two_Sentences(current_Article[current_Sentence_Num], compound);
	}

	public void AutoSchedule_Control()
	{
		if (current_Sentence_Num < current_Article.Length - 1)
		{
			if (timeSpend <= Score_System.time_Seconds)
			{
				current_Sentence_Num++;
				Img_Download.RunCloudbase(current_Sentence_Num);
				shouldSpeech.alignment = TextAnchor.MiddleCenter;
				shouldSpeech.fontSize = 120;
				shouldSpeech.text = "<color=#B62F2C>请继续，按住扳机键再次显示下一段讲稿</color>";
				return;
			}
			shouldSpeech.alignment = TextAnchor.MiddleCenter;
			shouldSpeech.fontSize = 120;
			shouldSpeech.text = "<color=#B62F2C>抱歉，您在规定的时间内没有能够完成此次演讲。</color>";
			Speach_Is_Start = false;
			buttonText.text = "开始演讲";
			if (hasTimes == 0)
			{
				hasEnd = true;
				Start_Button.SetActive(value: false);
			}
			Quit_Button.SetActive(value: true);
			Generator.Clean_Audience();
			current_Sentence_Num = 0;
			base.gameObject.GetComponent<GetTime>().TimeSpend = 0f;
		}
		else if (current_Sentence_Num == current_Article.Length - 1)
		{
			shouldSpeech.alignment = TextAnchor.MiddleCenter;
			shouldSpeech.fontSize = 120;
			shouldSpeech.text = "<color=#B62F2C>恭喜你完成了此次演讲的所有内容</color>";
			Speach_Is_Start = false;
			buttonText.text = "开始演讲";
			hasEnd = true;
			Score_System.show_Score = true;
			Start_Button.SetActive(value: false);
			Quit_Button.transform.GetChild(0).GetChild(0).GetComponent<Text>()
				.text = "查看成绩";
			Quit_Button.SetActive(value: true);
			Generator.Clean_Audience();
			current_Sentence_Num = 0;
			base.gameObject.GetComponent<GetTime>().TimeSpend = 0f;
			GameObject.Find("音源模块").GetComponent<Audio_System>().Play_End_Music();
		}
		else
		{
			current_Sentence_Num = 0;
		}
	}

	public void Press_And_Display()
	{
		shouldSpeech.alignment = TextAnchor.UpperLeft;
		shouldSpeech.fontSize = 90;
		shouldSpeech.text = current_Article[current_Sentence_Num];
	}

	public void Article_Total_Words_Count()
	{
		total_Words_Num = 0;
		for (int i = 0; i < current_Article.Length; i++)
		{
			int length = Regex.Replace(current_Article[i], "[ \\[ \\] \\^ \\-_*×――(^)（^）$%~!@#$…&%￥—+=<>《》!！??？:：•`·、。，；,.;\"‘’“”-]", "").Length;
			total_Words_Num += length;
		}
	}

	public void has_Read_Words_Count()
	{
		int length = Regex.Replace(current_Article[current_Sentence_Num], "[ \\[ \\] \\^ \\-_*×――(^)（^）$%~!@#$…&%￥—+=<>《》!！??？:：•`·、。，；,.;\"‘’“”-]", "").Length;
		current_Words_Num += length;
	}

	public void Score_Assessment_System(float sim_Para)
	{
		Score_System.sim_Para[current_Sentence_Num] = sim_Para;
		has_Read_Words_Count();
		timeSpend = base.gameObject.GetComponent<GetTime>().TimeSpend;
		float num = (float)current_Words_Num / (float)total_Words_Num;
		float num2 = timeSpend / Score_System.time_Seconds;
		if (num >= num2)
		{
			Score_System.read_Rhythm[current_Sentence_Num] = num2 / num;
			hint_Text.text = "快节奏";
		}
		else
		{
			Score_System.read_Rhythm[current_Sentence_Num] = num / num2;
			hint_Text.text = "慢节奏";
		}
		read_Rhythm_Text.text = $"{Score_System.read_Rhythm[current_Sentence_Num]:f2}";
		sim_Para_Text.text = $"{Score_System.sim_Para[current_Sentence_Num]:f2}";
		float num3 = 0f;
		float num4 = 0f;
		for (int i = 0; i <= current_Sentence_Num; i++)
		{
			num3 += Score_System.read_Rhythm[i];
			num4 += Score_System.sim_Para[i];
		}
		float num5 = num4 / (float)(current_Sentence_Num + 1);
		float num6 = num3 / (float)(current_Sentence_Num + 1);
		float num7 = num3 / (float)(current_Sentence_Num + 1) * ((float)Score_System.read_Rhythm_Weight / 10f) + num4 / (float)(current_Sentence_Num + 1) * ((float)Score_System.sim_Para_Weight / 10f);
		Generator.Event_Listeners(num5, num6);
		final_Score_Text.text = "得分：" + Convert.ToString((int)(num7 * 100f));
		Score_System.final_Sim = (int)(num5 * 100f);
		Score_System.final_Rhythm = (int)(num6 * 100f);
		Score_System.final_Score = (int)(num7 * 100f);
		Control_Lighting();
		AutoSchedule_Control();
	}

	public void Prepare_Exit_Speech()
	{
		Start_Button.SetActive(value: false);
		Quit_Button.SetActive(value: false);
		affirm_Button.SetActive(value: true);
		cancel_Button.SetActive(value: true);
	}

	public void Cancel_Exit_Speech()
	{
		if (!hasEnd)
		{
			Start_Button.SetActive(value: true);
		}
		else
		{
			Start_Button.SetActive(value: false);
		}
		Quit_Button.SetActive(value: true);
		affirm_Button.SetActive(value: false);
		cancel_Button.SetActive(value: false);
	}

	public void Confirm_Exit_Speech()
	{
		RenderSettings.skybox = null;
		touch.gameObject.SetActive(value: true);
		Score_System.next_Scence = 1;
		touch.Go_To_Next_Scence();
	}

	public void Control_Lighting()
	{
		score_Light.intensity = 3f;
		StartCoroutine(Turned_Off_The_Light());
	}

	private IEnumerator Turned_Off_The_Light()
	{
		yield return new WaitForSeconds(3f);
		score_Light.intensity = 0f;
	}
}
public class GetTime : MonoBehaviour
{
	public GameObject displayTimeText;

	private int hour;

	private int minute;

	private int second;

	private int millisecond;

	private float timeSpend;

	private Text text_timeSpend;

	public float TimeSpend
	{
		get
		{
			return timeSpend;
		}
		set
		{
			timeSpend = value;
		}
	}

	private void Start()
	{
		text_timeSpend = displayTimeText.GetComponent<Text>();
	}

	private void Update()
	{
		if (Game_Control.Speach_Is_Start)
		{
			timeSpend += Time.deltaTime;
			hour = (int)timeSpend / 3600;
			minute = ((int)timeSpend - hour * 3600) / 60;
			second = (int)timeSpend - hour * 3600 - minute * 60;
			millisecond = (int)((timeSpend - (float)(int)timeSpend) * 1000f);
			text_timeSpend.text = $"{hour:D2}:{minute:D2}:{second:D2}";
		}
		else
		{
			timeSpend = 0f;
			text_timeSpend.text = "00:00:00";
		}
	}
}
public class ImageDownload : MonoBehaviour
{
	private string url = "https://6372-critical-fusion-1g9aot1xb90c1147-1304498052.tcb.qcloud.la/new/go.png?sign=5d0ebef2538790f8d708d34fad7c5cf5&t=1610885837";

	private string img_Id = "cloud://critical-fusion-1g9aot1xb90c1147.6372-critical-fusion-1g9aot1xb90c1147-1304498052/new/adimg_01.jpg";

	private void Start()
	{
	}

	private void Update()
	{
	}

	private IEnumerator DownSprite()
	{
		UnityWebRequest wr = new UnityWebRequest(url);
		DownloadHandlerTexture texDl = (DownloadHandlerTexture)(wr.downloadHandler = new DownloadHandlerTexture(readable: true));
		yield return wr.SendWebRequest();
		int width = 1920;
		int height = 1080;
		if (!wr.isNetworkError)
		{
			new Texture2D(width, height);
			Texture2D texture = texDl.texture;
			Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(0.5f, 0.5f));
			base.transform.GetChild(0).GetComponent<Image>().sprite = sprite;
		}
	}

	public async void RunCloudbase(int num)
	{
		if (Score_System.Image_List != null && Score_System.Image_List.Length > num && Score_System.Image_List[num] != "null")
		{
			CloudBaseApp app = CloudBaseApp.Init("critical-fusion-9giwb3nj1337a5b1", 3000);
			if (await app.Auth.GetAuthStateAsync() == null)
			{
				await app.Auth.SignInAnonymouslyAsync();
			}
			List<string> fileIdList = new List<string> { Score_System.Image_List[num] };
			List<DownloadMetadata> fileList = (await app.Storage.GetFileDownloadUrlAsync(fileIdList)).FileList;
			url = fileList[0].DownloadUrl;
			StartCoroutine(DownSprite());
		}
	}
}
public class Navigation_AI : MonoBehaviour
{
	public int character_Code;

	private Transform seat_System;

	private Transform face_Direction;

	private Transform audience_Generator;

	private Transform Toilet;

	private Transform Outside;

	private Audience_Generator generator;

	protected NavMeshAgent agent;

	protected Animator animator;

	private bool want_Piss;

	private bool can_Anxiety;

	private bool start_NavMeshAgent;

	private bool stop_NavMeshAgent;

	private Transform current_Seat;

	private int current_Seat_Num;

	private List<int> seat_Information;

	private AudioSource audience_Source;

	private AudioClip sit_Sound;

	public bool Can_Anxiety => can_Anxiety;

	private void Start()
	{
		sit_Sound = GameObject.Find("音源模块").transform.GetComponent<Audio_System>().audience_Sound[13];
		audience_Source = base.gameObject.AddComponent<AudioSource>();
		audience_Source.spatialBlend = 1f;
		audience_Source.spatialize = true;
		audience_Source.spatializePostEffects = true;
		audience_Source.volume = 0.5f;
		audience_Source.clip = sit_Sound;
		face_Direction = GameObject.Find("My_Pico").transform;
		seat_System = base.transform.parent.parent.GetChild(1).GetChild(0);
		audience_Generator = base.transform.parent.parent.GetChild(2);
		Toilet = base.transform.parent.parent.GetChild(3);
		Outside = base.transform.parent.parent.GetChild(4);
		generator = base.transform.parent.parent.GetChild(0).GetChild(4).GetComponent<Audience_Generator>();
		agent = GetComponent<NavMeshAgent>();
		animator = GetComponent<Animator>();
		current_Seat_Num = -1;
		start_NavMeshAgent = false;
		stop_NavMeshAgent = false;
		can_Anxiety = false;
		want_Piss = false;
		Take_A_Seat();
	}

	private void Update()
	{
		if (start_NavMeshAgent && !stop_NavMeshAgent)
		{
			if (Vector3.Distance(current_Seat.position, base.transform.position) >= 1f)
			{
				animator.SetBool("isWaving", value: false);
				animator.SetBool("isWalking", value: true);
				animator.SetBool("isSit", value: false);
				animator.SetBool("isTexting", value: false);
				agent.destination = current_Seat.position;
			}
			else
			{
				StartCoroutine(wait_And_Sit());
				base.gameObject.transform.Translate(current_Seat.position * 0.005f);
				animator.SetBool("isWaving", value: false);
				animator.SetBool("isTexting", value: true);
				animator.SetBool("isWalking", value: false);
				animator.SetBool("isSit", value: false);
			}
		}
		if (start_NavMeshAgent || !stop_NavMeshAgent)
		{
			return;
		}
		if (!want_Piss)
		{
			if ((double)Vector3.Distance(audience_Generator.position, base.transform.position) >= 1.5)
			{
				animator.SetBool("isWalking", value: true);
				animator.SetBool("isTexting", value: false);
				animator.SetBool("isWaving", value: false);
				animator.SetBool("isSit", value: false);
				agent.destination = audience_Generator.position;
			}
			else
			{
				base.transform.GetComponent<People_WanderScript>().enabled = false;
				UnityEngine.Object.Destroy(base.transform.GetComponent<People_WanderManager>());
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else if ((double)Vector3.Distance(Toilet.position, base.transform.position) >= 1.5)
		{
			animator.SetBool("isWalking", value: true);
			animator.SetBool("isTexting", value: false);
			animator.SetBool("isWaving", value: false);
			animator.SetBool("isSit", value: false);
			agent.destination = Toilet.position;
		}
		else
		{
			agent.destination = base.transform.position;
			base.transform.GetComponent<People_WanderScript>().enabled = false;
			UnityEngine.Object.Destroy(base.transform.GetComponent<People_WanderManager>());
			base.transform.GetChild(0).gameObject.SetActive(value: false);
			StartCoroutine(Piss_Different_Time());
		}
	}

	private IEnumerator wait_And_Sit()
	{
		start_NavMeshAgent = false;
		yield return new WaitForSeconds(1f);
		audience_Source.Play();
		base.transform.position = current_Seat.position;
		animator.SetBool("isTexting", value: false);
		animator.SetBool("isWalking", value: false);
		animator.SetBool("isWaving", value: false);
		animator.SetBool("isSit", value: true);
		base.gameObject.transform.LookAt(face_Direction);
		can_Anxiety = true;
	}

	private IEnumerator wait_And_Stand()
	{
		yield return new WaitForSeconds(1f);
		start_NavMeshAgent = false;
		stop_NavMeshAgent = true;
	}

	private IEnumerator be_Anxious_And_Piss()
	{
		yield return new WaitForSeconds(30f);
		base.transform.GetComponent<People_WanderScript>().enabled = false;
		current_Seat_Num = -1;
		animator.SetBool("isTexting", value: false);
		animator.SetBool("isWalking", value: true);
		animator.SetBool("isWaving", value: false);
		animator.SetBool("isSit", value: false);
		start_NavMeshAgent = false;
		stop_NavMeshAgent = false;
		want_Piss = true;
		Leave_The_Auditorium();
	}

	private IEnumerator Piss_Different_Time()
	{
		yield return new WaitForSeconds(character_Code * 3 + 10);
		generator.Piss_And_Return(character_Code);
		UnityEngine.Object.Destroy(base.gameObject);
	}

	public void Take_A_Seat()
	{
		seat_Information = new List<int>();
		for (int i = 0; i <= 63; i++)
		{
			if (Score_System.seat_Num[i])
			{
				seat_Information.Add(i);
			}
		}
		if (seat_Information.Count != 0)
		{
			int index = UnityEngine.Random.Range(0, seat_Information.Count);
			Score_System.seat_Num[seat_Information[index]] = false;
			current_Seat_Num = seat_Information[index];
			current_Seat = seat_System.GetChild(seat_Information[index]);
			UnityEngine.Debug.Log(seat_System.GetChild(seat_Information[index]).name);
			agent.destination = current_Seat.position;
			start_NavMeshAgent = true;
			stop_NavMeshAgent = false;
		}
		else
		{
			Anxious_In_The_Hall();
		}
	}

	public void Leave_The_Auditorium()
	{
		if (!can_Anxiety)
		{
			base.transform.GetComponent<People_WanderScript>().enabled = false;
			animator.SetBool("isTexting", value: false);
			animator.SetBool("isWalking", value: false);
			animator.SetBool("isWaving", value: false);
			animator.SetBool("isSit", value: false);
		}
		else
		{
			can_Anxiety = false;
			Score_System.seat_Num[current_Seat_Num] = true;
			animator.SetBool("isTexting", value: true);
			animator.SetBool("isWalking", value: false);
			animator.SetBool("isWaving", value: false);
			animator.SetBool("isSit", value: false);
		}
		StartCoroutine(wait_And_Stand());
	}

	public void Anxious_In_The_Hall()
	{
		can_Anxiety = false;
		if (current_Seat_Num != -1)
		{
			Score_System.seat_Num[current_Seat_Num] = true;
		}
		animator.SetBool("isWaving", value: false);
		animator.SetBool("isTexting", value: false);
		animator.SetBool("isWalking", value: false);
		animator.SetBool("isSit", value: false);
		base.transform.GetComponent<People_WanderScript>().enabled = true;
		StartCoroutine(be_Anxious_And_Piss());
	}
}
public class Tencent_Cloudbase : MonoBehaviour
{
	public static List<DataClass> dataObj;

	public Transform article_nav;

	public Transform custom_time;

	public GameObject article_title;

	public Audio_System audio_System;

	public CalibrationTouch touch;

	public Text showPhone;

	public Text showCode;

	public Text wrongCode;

	public Text userCoin;

	public Image phoneImage;

	public Image codeImage;

	public Transform headSet;

	public Pvr_UnitySDKHeadTrack headTrack;

	private int currentInput;

	private string myCode;

	private bool use_myCode;

	private bool isPrivate;

	private void Start()
	{
		if (Score_System.show_Score)
		{
			base.transform.GetChild(5).gameObject.SetActive(value: true);
			base.transform.GetChild(5).GetChild(0).GetComponent<Text>()
				.text = "准确性得分：" + Score_System.final_Sim;
			base.transform.GetChild(5).GetChild(1).GetComponent<Text>()
				.text = "节奏性得分：" + Score_System.final_Rhythm;
			base.transform.GetChild(5).GetChild(2).GetComponent<Text>()
				.text = "综合得分：" + Score_System.final_Score;
			base.transform.GetChild(0).gameObject.SetActive(value: false);
		}
		else
		{
			base.transform.GetChild(0).gameObject.SetActive(value: true);
			base.transform.GetChild(5).gameObject.SetActive(value: false);
		}
	}

	private void Update()
	{
	}

	private IEnumerator Step_1_Button_Wait_Show()
	{
		yield return new WaitForSeconds(7f);
		base.transform.GetChild(1).GetChild(2).gameObject.SetActive(value: true);
		wrongCode.text = "登陆失败";
	}

	public void Switching_login_status()
	{
		if (base.transform.GetChild(1).GetChild(1).GetChild(0)
			.GetComponent<Toggle>()
			.isOn)
		{
			isPrivate = true;
			base.transform.GetChild(1).GetChild(1).GetChild(2)
				.gameObject.SetActive(value: true);
			base.transform.GetChild(1).GetChild(1).GetChild(3)
				.gameObject.SetActive(value: true);
			base.transform.GetChild(1).GetChild(1).GetChild(4)
				.gameObject.SetActive(value: true);
		}
		else
		{
			isPrivate = false;
			showPhone.text = "";
			showCode.text = "";
			base.transform.GetChild(1).GetChild(1).GetChild(2)
				.gameObject.SetActive(value: false);
			base.transform.GetChild(1).GetChild(1).GetChild(3)
				.gameObject.SetActive(value: false);
			base.transform.GetChild(1).GetChild(1).GetChild(4)
				.gameObject.SetActive(value: false);
		}
	}

	private void Avoid_secret_landing()
	{
		wrongCode.text = "登陆成功";
		base.transform.GetChild(1).gameObject.SetActive(value: false);
		base.transform.GetChild(2).gameObject.SetActive(value: true);
		dataObj = null;
		RunCloudbase_2();
		base.transform.GetChild(2).GetChild(1).GetChild(0)
			.GetComponent<Text>()
			.text = "";
		base.transform.GetChild(2).GetChild(1).GetChild(1)
			.GetComponent<Text>()
			.text = "";
		base.transform.GetChild(2).GetChild(1).GetChild(2)
			.GetComponent<Text>()
			.text = "";
		base.transform.GetChild(2).GetChild(2).gameObject.SetActive(value: false);
	}

	public async void Register_to_check()
	{
		CloudBaseApp app = CloudBaseApp.Init("critical-fusion-9giwb3nj1337a5b1", 3000);
		if (await app.Auth.GetAuthStateAsync() == null)
		{
			await app.Auth.SignInAnonymouslyAsync();
		}
		await app.Auth.GetUserInfoAsync();
		Dictionary<string, object> param = new Dictionary<string, object>
		{
			{ "code", 3 },
			{ "phone", showPhone.text },
			{ "password", showCode.text },
			{
				"expend",
				Score_System.Expend
			}
		};
		FunctionResponse obj = await app.Function.CallFunctionAsync("binding", param);
		UnityEngine.Debug.Log(obj.Data);
		Match match = Regex.Match(obj.Data.ToString(), "user_id.:..(.*.).,");
		Match match2 = Regex.Match(obj.Data.ToString(), "role_id.:..(.*.).,");
		Match match3 = Regex.Match(obj.Data.ToString(), "answer.:..(.*.)..");
		Match match4 = Regex.Match(obj.Data.ToString(), "coin.:.(.*.),");
		Score_System.User_id = match.Groups[1].ToString();
		Score_System.Role_id = match2.Groups[1].ToString();
		Score_System.coin = match4.Groups[1].ToString();
		base.transform.GetChild(1).GetChild(2).gameObject.SetActive(value: true);
		if (match3.Groups[1].ToString() == "完成登录" || match3.Groups[1].ToString() == "完成登")
		{
			wrongCode.text = "登陆成功";
			userCoin.text = match4.Groups[1].ToString();
			base.transform.GetChild(1).gameObject.SetActive(value: false);
			base.transform.GetChild(2).gameObject.SetActive(value: true);
			dataObj = null;
			RunCloudbase_2();
			base.transform.GetChild(2).GetChild(1).GetChild(0)
				.GetComponent<Text>()
				.text = "";
			base.transform.GetChild(2).GetChild(1).GetChild(1)
				.GetComponent<Text>()
				.text = "";
			base.transform.GetChild(2).GetChild(1).GetChild(2)
				.GetComponent<Text>()
				.text = "";
			base.transform.GetChild(2).GetChild(2).gameObject.SetActive(value: false);
		}
		else if (match3.Groups[1].ToString() == "使用币不足，请充值使用币后再次登录")
		{
			wrongCode.text = "使用币不足，请充值";
		}
		else
		{
			wrongCode.text = "登陆失败";
		}
		Invoke("No_Response_To_Login_Failure", 5f);
	}

	public void No_Response_To_Login_Failure()
	{
		if (wrongCode.text != "使用币不足，请充值" && wrongCode.text != "登陆成功" && wrongCode.text != "登陆失败")
		{
			wrongCode.text = "登陆失败";
		}
	}

	public async void RunCloudbase_1()
	{
		CloudBaseApp app = CloudBaseApp.Init("critical-fusion-9giwb3nj1337a5b1", 3000);
		if (await app.Auth.GetAuthStateAsync() == null)
		{
			await app.Auth.SignInAnonymouslyAsync();
		}
		await app.Auth.GetUserInfoAsync();
		dataObj = JArray.Parse(Convert.ToString((await app.Db.Collection("article_resources").Where(new
		{
			type = 0
		}).GetAsync()).Data)).ToObject<List<DataClass>>();
		for (int i = 0; i < article_nav.childCount; i++)
		{
			UnityEngine.Object.Destroy(article_nav.GetChild(i).gameObject);
		}
		for (int j = 0; j < dataObj.Count; j++)
		{
			string text = dataObj[j].name;
			GameObject obj = UnityEngine.Object.Instantiate(article_title, article_nav);
			obj.GetComponent<Text>().text = text;
			obj.name = Convert.ToString(j);
		}
		article_nav.GetComponent<RectTransform>().sizeDelta = new Vector2(230f, article_nav.childCount * 40);
	}

	public async void RunCloudbase_2()
	{
		CloudBaseApp app = CloudBaseApp.Init("critical-fusion-9giwb3nj1337a5b1", 3000);
		if (await app.Auth.GetAuthStateAsync() == null)
		{
			await app.Auth.SignInAnonymouslyAsync();
		}
		await app.Auth.GetUserInfoAsync();
		Database db = app.Db;
		Command command = db.Command;
		Collection collection = db.Collection("article_resources");
		LogicCommand[] expressions = new QueryCommand[2]
		{
			command.Eq("0"),
			command.Eq(showPhone.text)
		};
		dataObj = JArray.Parse(Convert.ToString((await collection.Where(new
		{
			type = 0,
			code = command.Or(expressions)
		}).GetAsync()).Data)).ToObject<List<DataClass>>();
		for (int i = 0; i < article_nav.childCount; i++)
		{
			UnityEngine.Object.Destroy(article_nav.GetChild(i).gameObject);
		}
		for (int j = 0; j < dataObj.Count; j++)
		{
			string text = dataObj[j].name;
			GameObject obj = UnityEngine.Object.Instantiate(article_title, article_nav);
			obj.GetComponent<Text>().text = text;
			obj.name = Convert.ToString(j);
		}
		article_nav.GetComponent<RectTransform>().sizeDelta = new Vector2(230f, article_nav.childCount * 40);
	}

	public void Custom_Time()
	{
		Score_System.time_Seconds = custom_time.GetChild(0).GetComponent<Slider>().value * 60f;
		custom_time.GetChild(1).GetComponent<Text>().text = custom_time.GetChild(0).GetComponent<Slider>().value + "分钟";
	}

	public void Step_Button(int code)
	{
		switch (code)
		{
		case 0:
			base.transform.GetChild(1).GetChild(2).gameObject.SetActive(value: false);
			audio_System.Button_Sound(1);
			if (isPrivate)
			{
				StartCoroutine(Step_1_Button_Wait_Show());
				Register_to_check();
			}
			else
			{
				Avoid_secret_landing();
			}
			wrongCode.text = "";
			break;
		case 1:
			showPhone.text = "";
			showCode.text = "";
			base.transform.GetChild(1).GetChild(1).GetChild(0)
				.GetComponent<Toggle>()
				.isOn = false;
			audio_System.Button_Sound(1);
			base.transform.GetChild(1).gameObject.SetActive(value: true);
			base.transform.GetChild(2).gameObject.SetActive(value: false);
			base.transform.GetChild(1).GetChild(2).gameObject.SetActive(value: true);
			base.transform.GetChild(2).GetChild(3).GetChild(1)
				.gameObject.SetActive(value: false);
			wrongCode.text = "";
			break;
		case 2:
			audio_System.Button_Sound(1);
			base.transform.GetChild(2).gameObject.SetActive(value: false);
			base.transform.GetChild(3).gameObject.SetActive(value: true);
			break;
		case 3:
			audio_System.Button_Sound(1);
			base.transform.GetChild(2).gameObject.SetActive(value: true);
			dataObj = null;
			RunCloudbase_2();
			base.transform.GetChild(3).gameObject.SetActive(value: false);
			break;
		case 4:
			audio_System.transform.GetChild(4).GetComponent<AudioListener>().enabled = false;
			base.transform.GetChild(3).gameObject.SetActive(value: false);
			base.transform.GetChild(4).gameObject.SetActive(value: true);
			base.transform.GetChild(4).GetComponent<BaiduASR>().Random_Statement();
			base.transform.GetChild(4).GetChild(4).GetChild(0)
				.gameObject.SetActive(value: false);
			base.transform.GetChild(4).GetChild(1).GetComponent<Text>()
				.text = "";
			base.transform.GetChild(4).GetChild(3).GetComponent<Text>()
				.text = "";
			audio_System.Button_Sound(1);
			break;
		case 5:
			base.transform.GetChild(3).gameObject.SetActive(value: true);
			base.transform.GetChild(4).gameObject.SetActive(value: false);
			audio_System.transform.GetChild(4).GetComponent<AudioListener>().enabled = true;
			audio_System.Button_Sound(1);
			break;
		case 6:
			audio_System.Button_Sound(1);
			LoadScene_Speech();
			break;
		case 7:
			Application.Quit();
			Application.Quit();
			break;
		}
	}

	public void LoadScene_Speech()
	{
		RenderSettings.skybox = null;
		touch.gameObject.SetActive(value: true);
		Score_System.next_Scence = 2;
		touch.Go_To_Next_Scence();
	}

	public void Speech_Settings()
	{
		audio_System.Button_Sound(2);
		Score_System.difficulty_level = (int)base.transform.GetChild(3).GetChild(0).GetChild(0)
			.GetComponent<Slider>()
			.value;
		Score_System.sim_Para_Weight = (int)base.transform.GetChild(3).GetChild(1).GetChild(0)
			.GetComponent<Slider>()
			.value;
		Score_System.read_Rhythm_Weight = 10 - (int)base.transform.GetChild(3).GetChild(1).GetChild(0)
			.GetComponent<Slider>()
			.value;
	}

	public void Back_And_Start_Again()
	{
		base.transform.GetChild(1).gameObject.SetActive(value: true);
		base.transform.GetChild(6).gameObject.SetActive(value: false);
		Score_System.final_Sim = 0;
		Score_System.final_Rhythm = 0;
		Score_System.final_Score = 0;
		Score_System.show_Score = false;
	}

	public void Input_Code_Num(int num)
	{
		audio_System.Button_Sound(2);
		switch (num)
		{
		case 99:
			if (currentInput == 0)
			{
				myCode = showPhone.text;
				if (myCode.Length > 0)
				{
					myCode = myCode.Substring(0, myCode.Length - 1);
					showPhone.text = myCode;
				}
			}
			else if (currentInput == 1)
			{
				myCode = showCode.text;
				if (myCode.Length > 0)
				{
					myCode = myCode.Substring(0, myCode.Length - 1);
					showCode.text = myCode;
				}
			}
			break;
		case 100:
			if (currentInput == 0)
			{
				showPhone.text = "";
			}
			else if (currentInput == 1)
			{
				showCode.text = "";
			}
			break;
		default:
			if (currentInput == 0)
			{
				myCode = showPhone.text;
				myCode += num;
				showPhone.text = myCode;
			}
			else if (currentInput == 1)
			{
				myCode = showCode.text;
				myCode += num;
				showCode.text = myCode;
			}
			break;
		}
	}

	public void Current_Input_Item(int code)
	{
		audio_System.Button_Sound(3);
		currentInput = code;
		if (currentInput == 0)
		{
			phoneImage.color = new Color(1f, 1f, 1f);
			codeImage.color = new Color(0.23529412f, 0.23529412f, 0.23529412f);
		}
		else if (currentInput == 1)
		{
			codeImage.color = new Color(1f, 1f, 1f);
			phoneImage.color = new Color(0.23529412f, 0.23529412f, 0.23529412f);
		}
	}
}
public class DataClass
{
	public string name;

	public string brief;

	public string code;

	public int time;

	public int type;

	public string[] article;

	public string[] imgList;
}
public class XunFeiYuYin : MonoBehaviour
{
	public enum Voice
	{
		xiaoyan,
		aisjiuxu,
		aisxping,
		aisjinger,
		aisbabyxu,
		catherine,
		john
	}

	[Serializable]
	public class 识别data
	{
		[Serializable]
		public class Data
		{
			[Serializable]
			public class Result
			{
				[Serializable]
				public class Ws
				{
					[Serializable]
					public class Cw
					{
						public string w;
					}

					public Cw[] cw;
				}

				public Ws[] ws;
			}

			public int status;

			public Result result;
		}

		public Data data;
	}

	[Serializable]
	public class 合成data
	{
		[Serializable]
		public class Data
		{
			public int status;

			public string audio;
		}

		public Data data;
	}

	private string APPID = "5c81de59";

	private string APISecret = "ea4d5e9b06f8cfb0deae4d5360e7f8a7";

	private string APIKey = "94348d7a6d5f3807176cb1f4923efa5c";

	public string 语音评测APIKey = "c6ea43c9e7b14d163bdeb4e51d2e564d";

	public XunFeiYuYin yuyin;

	public AudioClip RecordedClip;

	private ClientWebSocket 语音识别WebSocket;

	public AudioSource 语音合成流播放器;

	private ClientWebSocket 语音合成WebSocket;

	private int 语音流总长度;

	private Queue<float> 播放队列 = new Queue<float>();

	private AudioClip 语音评测录音;

	public event Action<string> 语音识别完成事件;

	private void Awake()
	{
	}

	public XunFeiYuYin Init(string appkey, string APISecret, string APIKey, string 语音评测APIKey)
	{
		string text = "讯飞语音";
		if (yuyin == null)
		{
			new GameObject(text).AddComponent<XunFeiYuYin>();
		}
		if (!Permission.HasUserAuthorizedPermission("android.permission.RECORD_AUDIO"))
		{
			Permission.RequestUserPermission("android.permission.RECORD_AUDIO");
		}
		yuyin.APPID = appkey;
		yuyin.APISecret = APISecret;
		yuyin.APIKey = APIKey;
		yuyin.语音评测APIKey = 语音评测APIKey;
		return yuyin;
	}

	private string GetUrl(string uriStr)
	{
		Uri uri = new Uri(uriStr);
		string text = DateTime.Now.ToString("r");
		string s = string.Format("host: " + uri.Host + "\ndate: " + text + "\nGET " + uri.AbsolutePath + " HTTP/1.1");
		string arg = Convert.ToBase64String(new HMACSHA256(Encoding.UTF8.GetBytes(APISecret)).ComputeHash(Encoding.UTF8.GetBytes(s)));
		string s2 = $"api_key=\"{APIKey}\",algorithm=\"hmac-sha256\",headers=\"host date request-line\",signature=\"{arg}\"";
		string text2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(s2));
		return $"{uri}?authorization={text2}&date={text}&host={uri.Host}";
	}

	public void 开始语音识别()
	{
		if (语音识别WebSocket != null && 语音识别WebSocket.State == WebSocketState.Open)
		{
			UnityEngine.Debug.LogWarning("开始语音识别失败！，等待上次识别连接结束");
			return;
		}
		连接语音识别WebSocket();
		RecordedClip = Microphone.Start(null, loop: false, 60, 16000);
	}

	public IEnumerator 停止语音识别()
	{
		Microphone.End(null);
		yield return new WaitUntil(() => 语音识别WebSocket.State != WebSocketState.Open);
		UnityEngine.Debug.Log("识别结束，停止录音");
	}

	private async void 连接语音识别WebSocket()
	{
		using (语音识别WebSocket = new ClientWebSocket())
		{
			CancellationToken ct = default(CancellationToken);
			Uri uri = new Uri(GetUrl("wss://iat-api.xfyun.cn/v2/iat"));
			await 语音识别WebSocket.ConnectAsync(uri, ct);
			UnityEngine.Debug.Log("连接成功");
			StartCoroutine(发送录音数据流(语音识别WebSocket));
			StringBuilder stringBuilder = new StringBuilder();
			while (语音识别WebSocket.State == WebSocketState.Open)
			{
				byte[] result = new byte[4096];
				await 语音识别WebSocket.ReceiveAsync(new ArraySegment<byte>(result), ct);
				List<byte> list = new List<byte>(result);
				while (list[list.Count - 1] == 0)
				{
					list.RemoveAt(list.Count - 1);
				}
				string @string = Encoding.UTF8.GetString(list.ToArray());
				UnityEngine.Debug.Log("接收消息：" + @string);
				if (string.IsNullOrEmpty(@string))
				{
					return;
				}
				识别data 识别data = JsonUtility.FromJson<识别data>(@string);
				stringBuilder.Append(获取识别单词(识别data));
				if (识别data.data.status == 2)
				{
					语音识别WebSocket.Abort();
				}
			}
			UnityEngine.Debug.LogWarning("断开连接");
			string text = stringBuilder.ToString();
			if (!string.IsNullOrEmpty(text))
			{
				this.语音识别完成事件?.Invoke(text);
				UnityEngine.Debug.LogWarning("识别到声音：" + text);
			}
		}
	}

	private string 获取识别单词(识别data data)
	{
		StringBuilder stringBuilder = new StringBuilder();
		识别data.Data.Result.Ws[] ws = data.data.result.ws;
		for (int i = 0; i < ws.Length; i++)
		{
			识别data.Data.Result.Ws.Cw[] cw = ws[i].cw;
			foreach (识别data.Data.Result.Ws.Cw cw2 in cw)
			{
				stringBuilder.Append(cw2.w);
			}
		}
		return stringBuilder.ToString();
	}

	private void 发送数据(byte[] audio, int status, ClientWebSocket socket)
	{
		if (socket.State == WebSocketState.Open)
		{
			string text = ((audio == null) ? "" : Convert.ToBase64String(audio));
			string s = "{\"common\":{\"app_id\":\"" + APPID + "\"},\"business\":{\"language\":\"zh_cn\",\"domain\":\"iat\",\"accent\":\"mandarin\",\"vad_eos\":2000},\"data\":{\"status\":" + status + ",\"encoding\":\"raw\",\"format\":\"audio/L16;rate=16000\",\"audio\":\"" + text + "\"}}";
			socket.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(s)), WebSocketMessageType.Binary, endOfMessage: true, default(CancellationToken));
		}
	}

	private IEnumerator 发送录音数据流(ClientWebSocket socket)
	{
		yield return new WaitWhile(() => Microphone.GetPosition(null) <= 0);
		float t = 0f;
		int position = Microphone.GetPosition(null);
		int status = 0;
		int lastPosition = 0;
		while (position < RecordedClip.samples && socket.State == WebSocketState.Open)
		{
			t += 0.04f;
			yield return new WaitForSecondsRealtime(0.04f);
			if (Microphone.IsRecording(null))
			{
				position = Microphone.GetPosition(null);
			}
			if (position <= lastPosition)
			{
				UnityEngine.Debug.LogWarning("字节流发送完毕！强制结束！");
				break;
			}
			int num = ((position - lastPosition > 640) ? 640 : (position - lastPosition));
			byte[] audio = 获取音频流片段(lastPosition, num, RecordedClip);
			发送数据(audio, status, socket);
			lastPosition += num;
			status = 1;
		}
		发送数据(null, 2, socket);
		Microphone.End(null);
	}

	public static byte[] 获取音频流片段(int star, int length, AudioClip recordedClip)
	{
		float[] array = new float[length];
		recordedClip.GetData(array, star);
		int num = 32767;
		byte[] array2 = new byte[array.Length * 2];
		for (int i = 0; i < array.Length; i++)
		{
			byte[] bytes = BitConverter.GetBytes((short)(array[i] * (float)num));
			array2[i * 2] = bytes[0];
			array2[i * 2 + 1] = bytes[1];
		}
		return array2;
	}

	public IEnumerator 开始语音合成(string text, Voice voice = Voice.xiaoyan, int speed = 50, int volume = 50)
	{
		if (语音合成WebSocket != null)
		{
			语音合成WebSocket.Abort();
		}
		if (语音合成流播放器 == null)
		{
			语音合成流播放器 = base.gameObject.AddComponent<AudioSource>();
		}
		语音合成流播放器.Stop();
		连接语音合成WebSocket(GetUrl("wss://tts-api.xfyun.cn/v2/tts"), text, voice.ToString(), speed, volume);
		语音合成流播放器.clip = AudioClip.Create("语音合成流", 960000, 1, 16000, stream: true, OnAudioRead);
		语音合成流播放器.Play();
		do
		{
			yield return null;
		}
		while (语音合成流播放器.isPlaying && (语音合成WebSocket.State != WebSocketState.Aborted || 语音合成流播放器.timeSamples < 语音流总长度));
		UnityEngine.Debug.Log(text + "语音流播放完毕！");
		语音合成流播放器.Stop();
	}

	private void OnAudioRead(float[] data)
	{
		for (int i = 0; i < data.Length; i++)
		{
			if (播放队列.Count > 0)
			{
				data[i] = 播放队列.Dequeue();
				continue;
			}
			if (语音合成WebSocket == null || 语音合成WebSocket.State != WebSocketState.Aborted)
			{
				语音流总长度++;
			}
			data[i] = 0f;
		}
	}

	public async void 连接语音合成WebSocket(string urlStr, string text, string voice, int speed, int volume)
	{
		using (语音合成WebSocket = new ClientWebSocket())
		{
			CancellationToken ct = default(CancellationToken);
			Uri uri = new Uri(urlStr);
			await 语音合成WebSocket.ConnectAsync(uri, ct);
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
			string text2 = "{\"common\":{\"app_id\":\"" + APPID + "\"},\"business\":{\"vcn\":\"" + voice + "\",\"aue\":\"raw\",\"speed\":" + speed + ",\"volume\":" + volume + ",\"tte\":\"UTF8\"},\"data\":{\"status\":2,\"text\":\"" + text + "\"}}";
			UnityEngine.Debug.Log("发送消息:" + text2);
			UnityEngine.Debug.Log("连接成功");
			await 语音合成WebSocket.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(text2)), WebSocketMessageType.Binary, endOfMessage: true, ct);
			StringBuilder sb = new StringBuilder();
			播放队列.Clear();
			while (语音合成WebSocket.State == WebSocketState.Open)
			{
				byte[] result = new byte[4096];
				await 语音合成WebSocket.ReceiveAsync(new ArraySegment<byte>(result), ct);
				List<byte> list = new List<byte>(result);
				while (list[list.Count - 1] == 0)
				{
					list.RemoveAt(list.Count - 1);
				}
				string @string = Encoding.UTF8.GetString(list.ToArray());
				UnityEngine.Debug.Log(@string);
				sb.Append(@string);
				if (@string.EndsWith("}}"))
				{
					合成data.Data data = JsonUtility.FromJson<合成data>(sb.ToString()).data;
					UnityEngine.Debug.Log("收到完整json数据：" + sb);
					sb.Clear();
					int status = data.status;
					float[] array = bytesToFloat(Convert.FromBase64String(data.audio));
					语音流总长度 += array.Length;
					float[] array2 = array;
					foreach (float item in array2)
					{
						播放队列.Enqueue(item);
					}
					if (status == 2)
					{
						语音合成WebSocket.Abort();
						break;
					}
				}
			}
		}
	}

	public static float[] bytesToFloat(byte[] byteArray)
	{
		float[] array = new float[byteArray.Length / 2];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = bytesToFloat(byteArray[i * 2], byteArray[i * 2 + 1]);
		}
		return array;
	}

	private static float bytesToFloat(byte firstByte, byte secondByte)
	{
		short num = ((!BitConverter.IsLittleEndian) ? ((short)((firstByte << 8) | secondByte)) : ((short)((secondByte << 8) | firstByte)));
		return (float)num / 32768f;
	}

	public AudioClip 开始语音评测录音()
	{
		语音评测录音 = Microphone.Start(null, loop: false, 30, 16000);
		return 语音评测录音;
	}

	public void 停止语音评测查看结果(string txet, Action<string> 评测结果回调, AudioClip clip = null)
	{
		if (clip == null)
		{
			clip = 语音评测录音;
		}
		byte[] audioData = 获取真实大小录音(clip);
		Microphone.End(null);
		StartCoroutine(语音评测(audioData, txet, 评测结果回调));
	}

	public IEnumerator 语音评测(byte[] audioData, string 评测文本, Action<string> 评测结果回调)
	{
		string s = "{\"aue\":\"raw\",\"result_level\":\"entirety\",\"language\":\"en_us\",\"category\":\"read_sentence\"}";
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string text2 = Convert.ToInt64((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds).ToString();
		string value = Md5($"{语音评测APIKey}{text2}{text}");
		string value2 = Convert.ToBase64String(audioData);
		string uri = "https://api.xfyun.cn/v1/service/v1/ise";
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("audio", value2);
		wWWForm.AddField("text", 评测文本);
		UnityWebRequest request = UnityWebRequest.Post(uri, wWWForm);
		request.SetRequestHeader("X-Appid", APPID);
		request.SetRequestHeader("X-CurTime", text2);
		request.SetRequestHeader("X-Param", text);
		request.SetRequestHeader("X-Checksum", value);
		yield return request.SendWebRequest();
		if (request.isNetworkError || request.isHttpError)
		{
			UnityEngine.Debug.LogError("网络出错请检查网络连接, err: " + request.error);
		}
		else
		{
			评测结果回调(request.downloadHandler.text);
		}
	}

	public static byte[] 获取真实大小录音(ref AudioClip recordedClip)
	{
		int num = Microphone.GetPosition(null);
		if (num <= 0 || num > recordedClip.samples)
		{
			num = recordedClip.samples;
		}
		float[] data = new float[num * recordedClip.channels];
		recordedClip.GetData(data, 0);
		recordedClip = AudioClip.Create(recordedClip.name, num, recordedClip.channels, recordedClip.frequency, stream: false);
		recordedClip.SetData(data, 0);
		return 获取音频流片段(0, num * recordedClip.channels, recordedClip);
	}

	public static byte[] 获取真实大小录音(AudioClip recordedClip)
	{
		int num = Microphone.GetPosition(null);
		if (num <= 0 || num > recordedClip.samples)
		{
			num = recordedClip.samples;
		}
		return 获取音频流片段(0, num * recordedClip.channels, recordedClip);
	}

	public static string Md5(string s)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		mD5CryptoServiceProvider.Clear();
		string text = "";
		for (int i = 0; i < bytes.Length; i++)
		{
			text += Convert.ToString(bytes[i], 16).PadLeft(2, '0');
		}
		return text.PadLeft(32, '0');
	}
}
public class xunfeiShibie : MonoBehaviour
{
	public Baidu_ASR_Self baiduASRSelf;

	private XunFeiYuYin xunfei;

	private bool isTest;

	private void Start()
	{
		xunfei = GameObject.Find("讯飞语音").GetComponent<XunFeiYuYin>().Init("5c81de59", "ea4d5e9b06f8cfb0deae4d5360e7f8a7", "94348d7a6d5f3807176cb1f4923efa5c", "c6ea43c9e7b14d163bdeb4e51d2e564d");
		xunfei.语音识别完成事件 += 语音识别结果;
	}

	public void 切换场景开关(bool code)
	{
		isTest = code;
	}

	public void 开始语音识别()
	{
		xunfei.开始语音识别();
	}

	public void 停止语音识别()
	{
		StartCoroutine(xunfei.停止语音识别());
	}

	public void 语音识别结果(string result)
	{
		baiduASRSelf.语音识别结果返回处理(result);
	}

	public void 语音识别失败()
	{
		UnityEngine.Debug.Log("语音识别失败");
		if (!isTest)
		{
			baiduASRSelf.语音识别失败处理();
		}
	}
}
public class xunfeiTest : MonoBehaviour
{
	public BaiduASR baiduASR;

	public Baidu_ASR_Self baiduASRSelf;

	private XunFeiYuYin xunfei;

	private bool isTest = true;

	private void Start()
	{
		xunfei = GameObject.Find("讯飞语音").GetComponent<XunFeiYuYin>().Init("5c81de59", "ea4d5e9b06f8cfb0deae4d5360e7f8a7", "94348d7a6d5f3807176cb1f4923efa5c", "c6ea43c9e7b14d163bdeb4e51d2e564d");
		xunfei.语音识别完成事件 += 语音识别结果;
	}

	public void 进入正式演讲场景的准备()
	{
		xunfei = GameObject.Find("讯飞语音").GetComponent<XunFeiYuYin>().Init("5c81de59", "ea4d5e9b06f8cfb0deae4d5360e7f8a7", "94348d7a6d5f3807176cb1f4923efa5c", "c6ea43c9e7b14d163bdeb4e51d2e564d");
		baiduASRSelf = GameObject.Find("All").transform.GetChild(0).GetChild(0).GetComponent<Baidu_ASR_Self>();
		xunfei.语音识别完成事件 += 语音识别结果;
	}

	public void 进入测试演讲场景的准备()
	{
		xunfei = GameObject.Find("讯飞语音").GetComponent<XunFeiYuYin>().Init("5c81de59", "ea4d5e9b06f8cfb0deae4d5360e7f8a7", "94348d7a6d5f3807176cb1f4923efa5c", "c6ea43c9e7b14d163bdeb4e51d2e564d");
		baiduASR = GameObject.Find("设置面板").transform.GetChild(4).GetComponent<BaiduASR>();
		xunfei.语音识别完成事件 += 语音识别结果;
	}

	public void 切换场景开关(bool code)
	{
		isTest = code;
	}

	public void 开始语音识别()
	{
		xunfei.开始语音识别();
	}

	public void 停止语音识别()
	{
		StartCoroutine(xunfei.停止语音识别());
	}

	public void 语音识别结果(string result)
	{
		if (isTest)
		{
			baiduASR.语音识别结果返回处理(result);
		}
		else
		{
			baiduASRSelf.语音识别结果返回处理(result);
		}
	}

	public void 语音识别失败()
	{
		UnityEngine.Debug.Log("语音识别失败");
		if (!isTest)
		{
			baiduASRSelf.语音识别失败处理();
		}
	}
}
[AddComponentMenu("Camera-Control/Mouse Look")]
public class MouseLook : MonoBehaviour
{
	public enum RotationAxes
	{
		MouseXAndY,
		MouseX,
		MouseY
	}

	public RotationAxes axes;

	public float sensitivityX = 15f;

	public float sensitivityY = 15f;

	public float minimumX = -360f;

	public float maximumX = 360f;

	public float minimumY = -60f;

	public float maximumY = 60f;

	private float rotationY;

	private void Update()
	{
		if (axes == RotationAxes.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
			base.transform.localEulerAngles = new Vector3(0f - rotationY, y, 0f);
		}
		else if (axes == RotationAxes.MouseX)
		{
			base.transform.Rotate(0f, Input.GetAxis("Mouse X") * sensitivityX, 0f);
		}
		else
		{
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
			base.transform.localEulerAngles = new Vector3(0f - rotationY, base.transform.localEulerAngles.y, 0f);
		}
	}

	private void Start()
	{
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = true;
		}
	}
}
public class Common_RandomInt : StateMachineBehaviour
{
	public string intparameterName;

	public Vector2 minMax;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		animator.SetInteger(intparameterName, 0);
		animator.SetInteger(intparameterName, (int)UnityEngine.Random.Range(minMax.x, minMax.y));
	}
}
public class CustomPeople : MonoBehaviour
{
	[Serializable]
	public class CustomBodyElement
	{
		public string name;

		public Transform bodyElement;
	}

	public AvatarMask mask;

	public GameObject slider;

	public Transform sliderParent;

	public List<Slider> sliders = new List<Slider>(0);

	public List<CustomBodyElement> customBodyElement = new List<CustomBodyElement>();

	private void Start()
	{
		for (int i = 0; i < mask.transformCount; i++)
		{
			if (mask.GetTransformActive(i))
			{
				CustomBodyElement customBodyElement = new CustomBodyElement();
				customBodyElement.name = mask.GetTransformPath(i);
				customBodyElement.bodyElement = base.transform.Find(mask.GetTransformPath(i));
				if (!customBodyElement.bodyElement.GetComponent<SkinnedMeshRenderer>())
				{
					this.customBodyElement.Add(customBodyElement);
				}
			}
		}
		for (int j = 0; j < this.customBodyElement.Count; j++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(slider, sliderParent);
			sliders.Add(gameObject.GetComponent<Slider>());
		}
	}

	private void Update()
	{
		for (int i = 0; i < customBodyElement.Count; i++)
		{
			if (customBodyElement[i].bodyElement != null)
			{
				customBodyElement[i].bodyElement.transform.localScale = Vector3.one * (sliders[i].value + 1f);
			}
		}
	}
}
[Serializable]
public class HumanBoneOffset
{
	public HumanBodyBones bone;

	public Vector3 rotationOffset;

	public bool active;
}
[ExecuteInEditMode]
public class PolyIk : MonoBehaviour
{
	public List<HumanBoneOffset> rotationOffsets = new List<HumanBoneOffset>();

	public Transform leftFootTarget;

	public Transform rightFootTarget;

	public Transform LeftHandTarget;

	public Transform rightHandTarget;

	public Transform lookAtTarget;

	public Transform leftFootPole;

	public Transform rightFootPole;

	public Transform LeftHandPole;

	public Transform rightHandPole;

	[Range(0f, 1f)]
	public float rotationWeightLeftFoot;

	[Range(0f, 1f)]
	public float rotationWeightRightFoot;

	[Range(0f, 1f)]
	public float rotationWeightLeftHand;

	[Range(0f, 1f)]
	public float rotationWeightRightHand;

	[Range(0f, 1f)]
	public float lookAtWeight;

	[Range(0f, 1f)]
	public float lookAtHeadWeight;

	[Range(0f, 1f)]
	public float LookAtEyesWeight;

	[Range(0f, 1f)]
	public float rightHandWeight;

	[Range(0f, 1f)]
	public float leftHandWeight;

	[Range(0f, 1f)]
	public float rightFootWeight;

	[Range(0f, 1f)]
	public float leftFootWeight;

	public bool leftFootIk;

	public bool lookAtIk;

	public bool rightHandIk;

	public bool leftHandIk;

	public bool rightFootIk;

	public Animator animator;

	private void Start()
	{
		animator = GetComponent<Animator>();
		if (!animator.isHuman)
		{
			base.enabled = false;
			UnityEngine.Debug.Log("The rig needs to be humanoid for this script to work");
		}
	}

	private void Update()
	{
		if (Application.isEditor)
		{
			animator.Update(0f);
		}
	}

	private void OnAnimatorIK(int layerIndex)
	{
		SetIkTargetsAndWeights();
		foreach (HumanBoneOffset rotationOffset in rotationOffsets)
		{
			if (rotationOffset.active)
			{
				OffsetSpine(rotationOffset.bone, rotationOffset.rotationOffset);
			}
		}
	}

	private void SetIkTargetsAndWeights()
	{
		if (leftFootTarget != null && leftFootIk)
		{
			animator.SetIKPositionWeight(AvatarIKGoal.LeftFoot, leftFootWeight);
			animator.SetIKPosition(AvatarIKGoal.LeftFoot, leftFootTarget.position);
			animator.SetIKRotation(AvatarIKGoal.LeftFoot, leftFootTarget.rotation);
			animator.SetIKRotationWeight(AvatarIKGoal.LeftFoot, rotationWeightLeftFoot);
			animator.SetIKHintPosition(AvatarIKHint.LeftKnee, leftFootPole.position);
			animator.SetIKHintPositionWeight(AvatarIKHint.LeftKnee, leftFootWeight);
		}
		if (rightFootTarget != null && rightFootIk)
		{
			animator.SetIKPositionWeight(AvatarIKGoal.RightFoot, rightFootWeight);
			animator.SetIKPosition(AvatarIKGoal.RightFoot, rightFootTarget.position);
			animator.SetIKRotation(AvatarIKGoal.RightFoot, rightFootTarget.rotation);
			animator.SetIKRotationWeight(AvatarIKGoal.RightFoot, rotationWeightRightFoot);
			animator.SetIKHintPosition(AvatarIKHint.RightKnee, rightFootPole.position);
			animator.SetIKHintPositionWeight(AvatarIKHint.RightKnee, rightFootWeight);
		}
		if (LeftHandTarget != null && leftHandIk)
		{
			animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, leftHandWeight);
			animator.SetIKPosition(AvatarIKGoal.LeftHand, LeftHandTarget.position);
			animator.SetIKRotation(AvatarIKGoal.LeftHand, LeftHandTarget.rotation);
			animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, rotationWeightLeftHand);
			animator.SetIKHintPosition(AvatarIKHint.LeftElbow, LeftHandPole.position);
			animator.SetIKHintPositionWeight(AvatarIKHint.LeftElbow, leftHandWeight);
		}
		if (rightHandTarget != null && rightHandIk)
		{
			animator.SetIKPositionWeight(AvatarIKGoal.RightHand, rightHandWeight);
			animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandTarget.position);
			animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandTarget.rotation);
			animator.SetIKRotationWeight(AvatarIKGoal.RightHand, rotationWeightRightHand);
			animator.SetIKHintPosition(AvatarIKHint.RightElbow, rightHandPole.position);
			animator.SetIKHintPositionWeight(AvatarIKHint.RightElbow, rightHandWeight);
		}
		if (lookAtTarget != null && lookAtIk)
		{
			animator.SetLookAtWeight(lookAtWeight, 0f, lookAtHeadWeight, LookAtEyesWeight, 0f);
			animator.SetLookAtPosition(lookAtTarget.position);
		}
	}

	public void OffsetSpine(HumanBodyBones bone, Vector3 target)
	{
		Quaternion localRotation = animator.GetBoneTransform(bone).localRotation;
		Quaternion quaternion = Quaternion.Euler(target);
		animator.SetBoneLocalRotation(bone, Quaternion.Inverse(localRotation) * quaternion);
	}
}
public class PolyMorpher : MonoBehaviour
{
	[Serializable]
	public class CustomBodyElement
	{
		public string name;

		public Transform bodyElement;

		[HideInInspector]
		public Vector3 startScale;
	}

	public AvatarMask customPartMask;

	public Vector2 minMax = new Vector2(0.9f, 1.1f);

	public bool MorphOnStart = true;

	private List<CustomBodyElement> customBodyElement = new List<CustomBodyElement>();

	[ContextMenu("Get Body Parts")]
	private void GetBodyParts()
	{
		this.customBodyElement.Clear();
		for (int i = 0; i < customPartMask.transformCount; i++)
		{
			if (customPartMask.GetTransformActive(i))
			{
				CustomBodyElement customBodyElement = new CustomBodyElement();
				customBodyElement.name = customPartMask.GetTransformPath(i);
				customBodyElement.bodyElement = base.transform.Find(customPartMask.GetTransformPath(i));
				customBodyElement.startScale = Vector3.one;
				if (!customBodyElement.bodyElement.GetComponent<SkinnedMeshRenderer>())
				{
					this.customBodyElement.Add(customBodyElement);
				}
			}
		}
	}

	[ContextMenu("Random Size")]
	private void RandomSize()
	{
		for (int i = 0; i < customBodyElement.Count; i++)
		{
			if (customBodyElement[i].bodyElement != null)
			{
				float num = UnityEngine.Random.Range(minMax.x, minMax.y);
				customBodyElement[i].bodyElement.localScale = Vector3.one * num;
			}
		}
	}

	[ContextMenu("Reset Size")]
	private void ResetSize()
	{
		for (int i = 0; i < customBodyElement.Count; i++)
		{
			if (customBodyElement[i].bodyElement != null)
			{
				customBodyElement[i].bodyElement.localScale = customBodyElement[i].startScale;
			}
		}
	}

	private void Start()
	{
		if (MorphOnStart)
		{
			GetBodyParts();
			if (customBodyElement.Count > 0)
			{
				RandomSize();
			}
		}
	}
}
[ExecuteInEditMode]
public class WizardParticles : MonoBehaviour
{
	private Animator animator;

	public Transform leftHand;

	public Transform rightHand;

	public Vector3 direction;

	public Vector3 midPoint;

	public Quaternion rotation;

	public float scale;

	public ParticleSystem particleSystem;

	public Vector3 sizeMultiplier = Vector3.right;

	private void Start()
	{
		animator = GetComponentInParent<Animator>();
		leftHand = animator.GetBoneTransform(HumanBodyBones.LeftHand);
		rightHand = animator.GetBoneTransform(HumanBodyBones.RightHand);
		particleSystem = GetComponent<ParticleSystem>();
	}

	private void Update()
	{
		direction = leftHand.position - rightHand.position;
		midPoint = (rightHand.position + leftHand.position) / 2f;
		scale = direction.magnitude / 2f;
		midPoint -= base.transform.position;
	}

	private void OnDrawGizmos()
	{
	}
}
public class Readme : ScriptableObject
{
	[Serializable]
	public class Section
	{
		public string heading;

		public string text;

		public string linkText;

		public string url;
	}

	public Texture2D icon;

	public string title;

	public Section[] sections;

	public bool loadedLayout;
}
public class AchievementSample : MonoBehaviour
{
	public Text dataOutput;

	public InputField getDefinitionsByNameInputField;

	public InputField getProgressByNameInputField;

	public InputField unLockInputField;

	public InputField addCountInputField;

	public InputField addFieldsInputField;

	private void Start()
	{
		AchievementCore.RegisterNetwork();
	}

	private void OnDestroy()
	{
		AchievementCore.UnRegisterNetwork();
	}

	private void OnApplicationPause(bool pause)
	{
		if (!pause)
		{
			printOutputLine("Achievement Init");
			achievementInit();
		}
	}

	private void Update()
	{
		Pvr_UnitySDKAPI.Achievement.Request.RunCallbacks();
	}

	public void AsyncInitialize()
	{
		dataOutput.text = "> ";
		printOutputLine("AsyncInitialize");
		achievementInit();
	}

	public void GetDefinitionsByName()
	{
		dataOutput.text = "> ";
		printOutputLine("GetDefinitionsByName");
		string text = getDefinitionsByNameInputField.text;
		if (text != "")
		{
			string[] achievementNames = text.Split(',');
			getAchievementDefinition(achievementNames);
			getDefinitionsByNameInputField.text = "";
		}
		else
		{
			printOutputLine("Invalid Command");
		}
	}

	public void GetProgressByName()
	{
		dataOutput.text = "> ";
		printOutputLine("GetProgressByName");
		string text = getProgressByNameInputField.text;
		if (text != "")
		{
			string[] achievementNames = text.Split(',');
			getAchievementProgress(achievementNames);
			getProgressByNameInputField.text = "";
		}
		else
		{
			printOutputLine("Invalid Command");
		}
	}

	public void GetAllDefinitions()
	{
		dataOutput.text = "> ";
		printOutputLine("GetAllDefinitions");
		getAchievementAllDefinition();
	}

	public void GetAllProgress()
	{
		dataOutput.text = "> ";
		printOutputLine("GetAllProgress");
		getAchievementAllProgress();
	}

	public void UnLock()
	{
		dataOutput.text = "> ";
		printOutputLine("UnLock");
		string text = unLockInputField.text;
		if (text != "")
		{
			unlockAchievement(text);
			unLockInputField.text = "";
		}
		else
		{
			printOutputLine("Invalid Command");
		}
	}

	public void AddCount()
	{
		dataOutput.text = "> ";
		printOutputLine("AddCount");
		string text = addCountInputField.text;
		if (text != "")
		{
			string[] array = text.Split(',');
			if (array.Length > 1)
			{
				try
				{
					Convert.ToInt64(array[1]);
				}
				catch (Exception)
				{
					printOutputLine("Invalid Command");
					throw;
				}
				addCountAchievement(array[0], array[1]);
				addCountInputField.text = "";
			}
			else
			{
				printOutputLine("Invalid Command");
			}
		}
		else
		{
			printOutputLine("Invalid Command");
		}
	}

	public void AddFields()
	{
		dataOutput.text = "> ";
		printOutputLine("AddFields");
		string text = addFieldsInputField.text;
		if (text != "")
		{
			string[] array = text.Split(',');
			if (array.Length > 1)
			{
				addFieldsAchievement(array[0], array[1]);
				addFieldsInputField.text = "";
			}
			else
			{
				printOutputLine("Invalid Command");
			}
		}
		else
		{
			printOutputLine("Invalid Command");
		}
	}

	private void achievementInit()
	{
		Achievements.Init().OnComplete(initAchievementCallback);
	}

	private void getAchievementAllDefinition()
	{
		Achievements.GetAllDefinitions().OnComplete(achievementAllDefinitionCallback);
	}

	private void getAchievementAllProgress()
	{
		Achievements.GetAllProgress().OnComplete(achievementAllProgressCallback);
	}

	private void addFieldsAchievement(string achievementName, string fields)
	{
		Achievements.AddFields(achievementName, fields).OnComplete(achievementFieldsCallback);
	}

	private void addCountAchievement(string achievementName, string count)
	{
		Achievements.AddCount(achievementName, Convert.ToInt64(count)).OnComplete(achievementCountCallback);
	}

	private void unlockAchievement(string achievementName)
	{
		Achievements.Unlock(achievementName).OnComplete(achievementUnlockCallback);
	}

	private void getAchievementProgress(string[] achievementNames)
	{
		Achievements.GetProgressByName(achievementNames).OnComplete(achievementProgressCallback);
	}

	private void getAchievementDefinition(string[] achievementNames)
	{
		Achievements.GetDefinitionsByName(achievementNames).OnComplete(achievementDefinitionCallback);
	}

	private void printOutputLine(string newLine)
	{
		dataOutput.text = "> " + newLine + Environment.NewLine + dataOutput.text;
	}

	private void achievementAllDefinitionCallback(Pvr_Message<Pvr_AchievementDefinitionList> msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Received achievement definitions success");
			Pvr_AchievementDefinitionList achievementDefinitions = msg.GetAchievementDefinitions();
			if (achievementDefinitions.HasNextPage)
			{
				Achievements.GetNextAchievementDefinitionListPage(achievementDefinitions).OnComplete(achievementAllDefinitionCallback);
			}
			{
				foreach (Pvr_AchievementDefinition item in achievementDefinitions)
				{
					printOutputLine("Bitfield Name: " + item.Name.ToString());
					switch (item.Type)
					{
					case AchievementType.Simple:
						printOutputLine("Achievement Type: Simple");
						break;
					case AchievementType.Bitfield:
						printOutputLine("Achievement Type: Bitfield");
						printOutputLine("Bitfield Length: " + item.BitfieldLength);
						printOutputLine("Target: " + item.Target);
						break;
					case AchievementType.Count:
						printOutputLine("Achievement Type: Count");
						printOutputLine("Target: " + item.Target);
						break;
					default:
						printOutputLine("Achievement Type: Unknown");
						break;
					}
					printOutputLine("Bitfield Title: " + item.Title.ToString());
					printOutputLine("Bitfield Description: " + item.Description.ToString());
					printOutputLine("Bitfield UnlockedDescription: " + item.UnlockedDescription.ToString());
					printOutputLine("Bitfield UnlockedIcon: " + item.UnlockedIcon.ToString());
					printOutputLine("Bitfield LockedIcon: " + item.LockedIcon.ToString());
					printOutputLine("Bitfield IsSecrect: " + item.IsSecrect);
				}
				return;
			}
		}
		printOutputLine("Received achievement definitions error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void achievementAllProgressCallback(Pvr_Message<Pvr_AchievementProgressList> msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Received achievement progress success");
			Pvr_AchievementProgressList achievementProgressList = msg.GetAchievementProgressList();
			if (achievementProgressList.HasNextPage)
			{
				Achievements.GetNextAchievementProgressListPage(achievementProgressList).OnComplete(achievementAllProgressCallback);
			}
			{
				foreach (Pvr_AchievementProgress item in achievementProgressList)
				{
					printOutputLine("Current Name: " + item.Name.ToString());
					if (item.IsUnlocked)
					{
						printOutputLine("Achievement Unlocked");
					}
					else
					{
						printOutputLine("Achievement Locked");
					}
					printOutputLine("Current Bitfield: " + item.Bitfield.ToString());
					printOutputLine("Current Count: " + item.Count);
					printOutputLine("Current UnlockTime: " + item.UnlockTime.ToString());
				}
				return;
			}
		}
		printOutputLine("Received achievement progress error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void achievementFieldsCallback(Pvr_Message msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Achievement fields added.");
			return;
		}
		printOutputLine("Received achievement fields add error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void achievementCountCallback(Pvr_Message msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Achievement count added.");
			return;
		}
		printOutputLine("Received achievement count add error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void achievementUnlockCallback(Pvr_Message msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Achievement unlocked");
			return;
		}
		printOutputLine("Received achievement unlock error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void achievementProgressCallback(Pvr_Message<Pvr_AchievementProgressList> msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Received achievement progress success");
			{
				foreach (Pvr_AchievementProgress achievementProgress in msg.GetAchievementProgressList())
				{
					if (achievementProgress.IsUnlocked)
					{
						printOutputLine("Achievement Unlocked");
					}
					else
					{
						printOutputLine("Achievement Locked");
					}
					printOutputLine("Current Bitfield: " + achievementProgress.Bitfield.ToString());
					printOutputLine("Current Count: " + achievementProgress.Count);
				}
				return;
			}
		}
		printOutputLine("Received achievement progress error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void achievementDefinitionCallback(Pvr_Message<Pvr_AchievementDefinitionList> msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Received achievement definitions success");
			{
				foreach (Pvr_AchievementDefinition achievementDefinition in msg.GetAchievementDefinitions())
				{
					switch (achievementDefinition.Type)
					{
					case AchievementType.Simple:
						printOutputLine("Achievement Type: Simple");
						break;
					case AchievementType.Bitfield:
						printOutputLine("Achievement Type: Bitfield");
						printOutputLine("Bitfield Length: " + achievementDefinition.BitfieldLength);
						printOutputLine("Target: " + achievementDefinition.Target);
						break;
					case AchievementType.Count:
						printOutputLine("Achievement Type: Count");
						printOutputLine("Target: " + achievementDefinition.Target);
						break;
					default:
						printOutputLine("Achievement Type: Unknown");
						break;
					}
				}
				return;
			}
		}
		printOutputLine("Received achievement definitions error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void initAchievementCallback(Pvr_Message msg)
	{
		if (!msg.IsError)
		{
			printOutputLine("Received init success");
			return;
		}
		printOutputLine("Received init error");
		Error error = msg.GetError();
		printOutputLine("Error: Message:" + error.Message + " Code: " + error.Code + " HttpCode: " + error.HttpCode);
	}

	private void LoginCallback(string LoginInfo)
	{
		UnityEngine.Debug.Log("Received loginCallback:" + LoginInfo);
		printOutputLine("Received loginCallback: " + LoginInfo);
	}
}
public class Pvr_Controller : MonoBehaviour
{
	public enum UserHandNess
	{
		Right,
		Left
	}

	public enum GazeType
	{
		Never,
		DuringMotion,
		Always
	}

	public enum ControllerAxis
	{
		Controller,
		Wrist,
		Elbow,
		Shoulder
	}

	public GameObject controller0;

	public GameObject controller1;

	private static UserHandNess handness;

	public ControllerAxis Axis;

	public GazeType Gazetype;

	[Range(0f, 0.2f)]
	public float ElbowHeight;

	[Range(0f, 0.2f)]
	public float ElbowDepth;

	[Range(0f, 30f)]
	public float PointerTiltAngle = 15f;

	private float mouseX;

	private float mouseY;

	private float mouseZ;

	private Vector3[] inputDirection = new Vector3[2];

	public static Vector3 pointerPosition { get; set; }

	public static Quaternion pointerRotation { get; set; }

	public static Vector3 elbowPosition { get; set; }

	public static Quaternion elbowRotation { get; set; }

	public static Vector3 wristPosition { get; set; }

	public static Quaternion wristRotation { get; set; }

	public static Vector3 shoulderPosition { get; set; }

	public static Quaternion shoulderRotation { get; set; }

	public static Vector3 originOffsetL { get; set; }

	public static Vector3 originOffsetR { get; set; }

	private void Awake()
	{
		Pvr_ControllerManager.PvrServiceStartSuccessEvent += ServiceStartSuccess;
		Pvr_ControllerManager.SetControllerAbilityEvent += CheckControllerState;
		Pvr_ControllerManager.ChangeMainControllerCallBackEvent += MainControllerChanged;
		Pvr_ControllerManager.ChangeHandNessCallBackEvent += HandnessChanged;
	}

	private void Start()
	{
		handness = Controller.UPvr_GetHandNess();
		if (handness == (UserHandNess)(-1))
		{
			handness = UserHandNess.Right;
		}
	}

	private void OnDestroy()
	{
		Pvr_ControllerManager.PvrServiceStartSuccessEvent -= ServiceStartSuccess;
		Pvr_ControllerManager.SetControllerAbilityEvent -= CheckControllerState;
		Pvr_ControllerManager.ChangeMainControllerCallBackEvent -= MainControllerChanged;
		Pvr_ControllerManager.ChangeHandNessCallBackEvent -= HandnessChanged;
	}

	private void MainControllerChanged(string index)
	{
		RefreshHandness();
	}

	private void HandnessChanged(string index)
	{
		RefreshHandness();
	}

	private void ServiceStartSuccess()
	{
		RefreshHandness();
	}

	private void RefreshHandness()
	{
		handness = Controller.UPvr_GetHandNess();
		if (Controller.UPvr_GetMainHandNess() == 1)
		{
			ChangeHandNess();
		}
	}

	private void OnApplicationPause(bool pause)
	{
		if (!pause)
		{
			if (controller0 != null)
			{
				controller0.transform.localScale = Vector3.zero;
			}
			if (controller1 != null)
			{
				controller1.transform.localScale = Vector3.zero;
			}
		}
		Invoke("ShowController", 0.1f * Time.timeScale);
	}

	private void ShowController()
	{
		if (controller0 != null)
		{
			controller0.transform.localScale = Vector3.one;
		}
		if (controller1 != null)
		{
			controller1.transform.localScale = Vector3.one;
		}
	}

	private void CheckControllerState(string data)
	{
		bool num = Convert.ToBoolean(Convert.ToInt16(data.Substring(4, 1)));
		short num2 = Convert.ToInt16(data.Substring(0, 1));
		if (num && num2 == 1)
		{
			RefreshHandness();
		}
	}

	private void Update()
	{
		if (Pvr_UnitySDKManager.SDK.ControllerOnlyrot)
		{
			DoUpdateControler0();
			DoUpdateControler1();
			UpdateControlloerRay();
			return;
		}
		if (Controller.UPvr_GetPreferenceDevice() == 1)
		{
			DoUpdateControler0();
			DoUpdateControler1();
			UpdateControlloerRay();
			return;
		}
		if (controller0 != null)
		{
			controller0.transform.localRotation = Controller.UPvr_GetControllerQUA(0);
			controller0.transform.localPosition = Controller.UPvr_GetControllerPOS(0) + Controller.UPvr_GetControllerQUA(0) * originOffsetL;
			UpdateControlloerRay(update0: true, update1: false);
		}
		if (controller1 != null)
		{
			controller1.transform.localRotation = Controller.UPvr_GetControllerQUA(1);
			controller1.transform.localPosition = Controller.UPvr_GetControllerPOS(1) + Controller.UPvr_GetControllerQUA(1) * originOffsetR;
			UpdateControlloerRay(update0: false);
		}
	}

	public static void ChangeHandNess()
	{
		handness = ((handness == UserHandNess.Right) ? UserHandNess.Left : UserHandNess.Right);
	}

	private void DoUpdateControler0()
	{
		SetArmParaToSo((int)handness, (int)Gazetype, ElbowHeight, ElbowDepth, PointerTiltAngle);
		CalcArmModelfromSo(0);
		UpdateControllerDataSO(0);
	}

	private void DoUpdateControler1()
	{
		int hand = ((handness != UserHandNess.Left) ? 1 : 0);
		SetArmParaToSo(hand, (int)Gazetype, ElbowHeight, ElbowDepth, PointerTiltAngle);
		CalcArmModelfromSo(1);
		UpdateControllerDataSO(1);
	}

	private void UpdateControlloerRay(bool update0 = true, bool update1 = true)
	{
		if (Pvr_ControllerManager.Instance.LengthAdaptiveRay)
		{
			if (update0 && controller0 != null)
			{
				controller0.GetComponent<Pvr_ControllerModuleInit>().UpdateRay();
			}
			if (update1 && controller1 != null)
			{
				controller1.GetComponent<Pvr_ControllerModuleInit>().UpdateRay();
			}
		}
	}

	private Quaternion UpdateSimulatedFrameParams()
	{
		if (Input.GetKey(KeyCode.LeftShift))
		{
			mouseX += Input.GetAxis("Mouse X") * 5f;
			if (mouseX <= -180f)
			{
				mouseX += 360f;
			}
			else if (mouseX > 180f)
			{
				mouseX -= 360f;
			}
			mouseY -= Input.GetAxis("Mouse Y") * 2.4f;
			mouseY = Mathf.Clamp(mouseY, -80f, 80f);
		}
		else if (Input.GetKey(KeyCode.RightShift))
		{
			mouseZ += Input.GetAxis("Mouse X") * 5f;
			mouseZ = Mathf.Clamp(mouseZ, -80f, 80f);
		}
		return Quaternion.Euler(mouseY, mouseX, mouseZ);
	}

	private void SetArmParaToSo(int hand, int gazeType, float elbowHeight, float elbowDepth, float pointerTiltAngle)
	{
		Controller.UPvr_SetArmModelParameters(hand, gazeType, elbowHeight, elbowDepth, pointerTiltAngle);
	}

	private void CalcArmModelfromSo(int hand)
	{
		float[] array = new float[4];
		float[] array2 = new float[4];
		float[] array3 = new float[3];
		Quaternion quaternion = default(Quaternion);
		quaternion = Controller.UPvr_GetControllerQUA(hand);
		Vector3 vector = Controller.UPvr_GetAngularVelocity(hand);
		array2[0] = quaternion.x;
		array2[1] = quaternion.y;
		array2[2] = quaternion.z;
		array2[3] = quaternion.w;
		array3[0] = vector.x;
		array3[1] = vector.y;
		array3[2] = vector.z;
		if (Gazetype == GazeType.DuringMotion)
		{
			Vector3 b = Pvr_UnitySDKSensor.Instance.HeadPose.Orientation * Vector3.forward;
			b.y = 0f;
			b.Normalize();
			float t = Mathf.Clamp((vector.magnitude - 0.2f) / 45f, 0f, 0.1f);
			inputDirection[hand] = Vector3.Slerp(inputDirection[hand], b, t);
			if (Controller.UPvr_GetKeyLongPressed(hand, Pvr_KeyCode.HOME))
			{
				inputDirection[hand] = default(Vector3);
			}
			Quaternion quaternion2 = Quaternion.FromToRotation(Vector3.forward, inputDirection[hand]);
			array[0] = quaternion2.x;
			array[1] = quaternion2.y;
			array[2] = quaternion2.z;
			array[3] = quaternion2.w;
		}
		else
		{
			array[0] = Pvr_UnitySDKSensor.Instance.HeadPose.Orientation.x;
			array[1] = Pvr_UnitySDKSensor.Instance.HeadPose.Orientation.y;
			array[2] = Pvr_UnitySDKSensor.Instance.HeadPose.Orientation.z;
			array[3] = Pvr_UnitySDKSensor.Instance.HeadPose.Orientation.w;
		}
		Controller.UPvr_CalcArmModelParameters(array, array2, array3);
	}

	public void UpdateControllerDataSO(int hand)
	{
		float[] array = new float[4];
		float[] array2 = new float[3];
		Vector3 vector;
		Quaternion localRotation;
		switch (Axis)
		{
		case ControllerAxis.Controller:
			Controller.UPvr_GetPointerPose(array, array2);
			pointerPosition = new Vector3(array2[0], array2[1], array2[2]);
			pointerRotation = new Quaternion(array[0], array[1], array[2], array[3]);
			vector = pointerPosition;
			localRotation = pointerRotation;
			break;
		case ControllerAxis.Wrist:
			Controller.UPvr_GetWristPose(array, array2);
			wristPosition = new Vector3(array2[0], array2[1], array2[2]);
			wristRotation = new Quaternion(array[0], array[1], array[2], array[3]);
			vector = wristPosition;
			localRotation = wristRotation;
			break;
		case ControllerAxis.Elbow:
			Controller.UPvr_GetElbowPose(array, array2);
			elbowPosition = new Vector3(array2[0], array2[1], array2[2]);
			elbowRotation = new Quaternion(array[0], array[1], array[2], array[3]);
			vector = elbowPosition;
			localRotation = elbowRotation;
			break;
		case ControllerAxis.Shoulder:
			Controller.UPvr_GetShoulderPose(array, array2);
			shoulderPosition = new Vector3(array2[0], array2[1], array2[2]);
			shoulderRotation = new Quaternion(array[0], array[1], array[2], array[3]);
			vector = shoulderPosition;
			localRotation = shoulderRotation;
			break;
		default:
			throw new Exception("Invalid FromJoint.");
		}
		if (hand == 0)
		{
			if (controller0 != null)
			{
				if (!Pvr_UnitySDKManager.SDK.HmdOnlyrot)
				{
					controller0.transform.localPosition = vector + Pvr_UnitySDKSensor.Instance.HeadPose.Position;
				}
				else if (Pvr_UnitySDKManager.SDK.TrackingOrigin == TrackingOrigin.FloorLevel)
				{
					controller0.transform.localPosition = vector + Pvr_UnitySDKSensor.Instance.HeadPose.Position;
				}
				else
				{
					controller0.transform.localPosition = vector;
				}
				controller0.transform.localRotation = localRotation;
			}
		}
		else if (controller1 != null)
		{
			if (!Pvr_UnitySDKManager.SDK.HmdOnlyrot)
			{
				controller1.transform.localPosition = vector + Pvr_UnitySDKSensor.Instance.HeadPose.Position;
			}
			else if (Pvr_UnitySDKManager.SDK.TrackingOrigin == TrackingOrigin.FloorLevel)
			{
				controller1.transform.localPosition = vector + Pvr_UnitySDKSensor.Instance.HeadPose.Position;
			}
			else
			{
				controller1.transform.localPosition = vector;
			}
			controller1.transform.localRotation = localRotation;
		}
	}
}
public class Pvr_ControllerDemo : MonoBehaviour
{
	public GameObject HeadSetController;

	public GameObject controller0;

	public GameObject controller1;

	public GameObject cube;

	private Ray ray;

	private GameObject currentController;

	private Transform lastHit;

	private Transform currentHit;

	[SerializeField]
	private Material normat;

	[SerializeField]
	private Material gazemat;

	[SerializeField]
	private Material clickmat;

	private bool noClick;

	private GameObject referenceObj;

	public float rayDefaultLength = 4f;

	private bool isHasController;

	private bool headcontrolmode;

	private RaycastHit hit;

	private GameObject rayLine;

	private GameObject dot;

	private Transform dragObj;

	private float disX;

	private float disY;

	private float disZ;

	private void Start()
	{
		ray = default(Ray);
		hit = default(RaycastHit);
		if (Pvr_UnitySDKManager.SDK.isHasController)
		{
			Pvr_ControllerManager.PvrServiceStartSuccessEvent += ServiceStartSuccess;
			Pvr_ControllerManager.SetControllerStateChangedEvent += ControllerStateListener;
			Pvr_ControllerManager.ControllerStatusChangeEvent += CheckControllerStateForGoblin;
			isHasController = true;
		}
		referenceObj = new GameObject("ReferenceObj");
	}

	private void OnDestroy()
	{
		if (isHasController)
		{
			Pvr_ControllerManager.PvrServiceStartSuccessEvent -= ServiceStartSuccess;
			Pvr_ControllerManager.SetControllerStateChangedEvent -= ControllerStateListener;
			Pvr_ControllerManager.ControllerStatusChangeEvent -= CheckControllerStateForGoblin;
		}
	}

	private void Update()
	{
		if (HeadSetController.activeSelf)
		{
			HeadSetController.transform.parent.localRotation = Quaternion.Euler(Pvr_UnitySDKSensor.Instance.HeadPose.Orientation.eulerAngles.x, Pvr_UnitySDKSensor.Instance.HeadPose.Orientation.eulerAngles.y, 0f);
			HeadSetController.transform.parent.localPosition = Pvr_UnitySDKSensor.Instance.HeadPose.Position;
			ray.direction = HeadSetController.transform.position - HeadSetController.transform.parent.parent.Find("Head").position;
			ray.origin = HeadSetController.transform.parent.parent.Find("Head").position;
			if (Physics.Raycast(ray, out hit))
			{
				if (HeadSetController.name == "SightPointer")
				{
					HeadSetController.transform.localScale = new Vector3(0.09f, 0.09f, 0.09f);
				}
				currentHit = hit.transform;
				if (currentHit != null && lastHit != null && currentHit != lastHit && (bool)lastHit.GetComponent<Pvr_UIGraphicRaycaster>() && lastHit.transform.gameObject.activeInHierarchy && lastHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled)
				{
					lastHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled = false;
				}
				if (currentHit != null && lastHit != null && currentHit == lastHit && (bool)currentHit.GetComponent<Pvr_UIGraphicRaycaster>() && !currentHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled)
				{
					currentHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled = true;
				}
				if (1 << hit.transform.gameObject.layer == LayerMask.GetMask("Water") && !noClick)
				{
					hit.transform.GetComponent<Renderer>().material = gazemat;
				}
				lastHit = hit.transform;
				if (Pvr_ControllerManager.Instance.LengthAdaptiveRay)
				{
					HeadSetController.transform.position = hit.point;
					HeadSetController.transform.position -= (hit.point - HeadSetController.transform.parent.parent.Find("Head").position).normalized * 0.02f;
					float num = 0.008f * hit.distance / 4f;
					Mathf.Clamp(num, 0.002f, 0.008f);
					HeadSetController.transform.localScale = new Vector3(num, num, 1f);
				}
			}
			else
			{
				if (HeadSetController.name == "SightPointer")
				{
					HeadSetController.transform.localScale = Vector3.zero;
				}
				if (lastHit != null && 1 << lastHit.transform.gameObject.layer == LayerMask.GetMask("Water"))
				{
					lastHit.transform.GetComponent<Renderer>().material = normat;
				}
				currentHit = null;
				noClick = false;
				if (Pvr_ControllerManager.Instance.LengthAdaptiveRay)
				{
					HeadSetController.transform.position = HeadSetController.transform.parent.parent.Find("Head").position + ray.direction.normalized * (0.5f + rayDefaultLength);
					HeadSetController.transform.localScale = new Vector3(0.008f, 0.008f, 1f);
				}
			}
			if ((Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetMouseButtonDown(0)) && lastHit != null && 1 << lastHit.transform.gameObject.layer == LayerMask.GetMask("Water") && currentHit != null)
			{
				lastHit.transform.GetComponent<Renderer>().material = clickmat;
				noClick = true;
			}
			return;
		}
		if (currentController != null)
		{
			ray.direction = currentController.transform.forward - currentController.transform.up * 0.25f;
			ray.origin = currentController.transform.Find("start").position;
			if ((Controller.UPvr_GetKey(1, Pvr_KeyCode.A) || Controller.UPvr_GetKey(1, Pvr_KeyCode.B) || Controller.UPvr_GetKey(1, Pvr_KeyCode.APP) || Controller.UPvr_GetKey(1, Pvr_KeyCode.TOUCHPAD)) && currentController != controller1)
			{
				Controller.UPvr_SetMainHandNess(1);
				currentController = controller1;
				Controller.UPvr_VibrateNeo2Controller(1f, 100, 1);
			}
			if ((Controller.UPvr_GetKey(0, Pvr_KeyCode.X) || Controller.UPvr_GetKey(0, Pvr_KeyCode.Y) || Controller.UPvr_GetKey(0, Pvr_KeyCode.APP) || Controller.UPvr_GetKey(0, Pvr_KeyCode.TOUCHPAD)) && currentController != controller0)
			{
				Controller.UPvr_SetMainHandNess(0);
				currentController = controller0;
				Controller.UPvr_VibrateNeo2Controller(1f, 100, 0);
			}
			if (Physics.Raycast(ray, out hit))
			{
				currentHit = hit.transform;
				if (currentHit != null && lastHit != null && currentHit != lastHit && (bool)lastHit.GetComponent<Pvr_UIGraphicRaycaster>() && lastHit.transform.gameObject.activeInHierarchy && lastHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled)
				{
					lastHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled = false;
				}
				if (currentHit != null && lastHit != null && currentHit == lastHit && (bool)currentHit.GetComponent<Pvr_UIGraphicRaycaster>() && !currentHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled)
				{
					currentHit.GetComponent<Pvr_UIGraphicRaycaster>().enabled = true;
				}
				if (1 << hit.transform.gameObject.layer == LayerMask.GetMask("Button_1"))
				{
					if (!noClick)
					{
						hit.transform.GetComponent<ParticleSystem>().Play();
					}
					if (Controller.UPvr_GetKeyUp(0, Pvr_KeyCode.TRIGGER) || Controller.UPvr_GetKeyUp(1, Pvr_KeyCode.TRIGGER) || Input.GetMouseButtonDown(0))
					{
						hit.transform.parent.parent.GetComponent<Game_Control>().StartOrStop_Speech();
					}
				}
				if (1 << hit.transform.gameObject.layer == LayerMask.GetMask("Button_2"))
				{
					if (!noClick)
					{
						hit.transform.GetComponent<ParticleSystem>().Play();
					}
					if (Controller.UPvr_GetKeyUp(0, Pvr_KeyCode.TRIGGER) || Controller.UPvr_GetKeyUp(1, Pvr_KeyCode.TRIGGER) || Input.GetMouseButtonDown(0))
					{
						hit.transform.parent.parent.GetComponent<Game_Control>().Prepare_Exit_Speech();
					}
				}
				if (1 << hit.transform.gameObject.layer == LayerMask.GetMask("Button_3"))
				{
					if (!noClick)
					{
						hit.transform.GetComponent<ParticleSystem>().Play();
					}
					if (Controller.UPvr_GetKeyUp(0, Pvr_KeyCode.TRIGGER) || Controller.UPvr_GetKeyUp(1, Pvr_KeyCode.TRIGGER) || Input.GetMouseButtonDown(0))
					{
						hit.transform.parent.parent.GetComponent<Game_Control>().Confirm_Exit_Speech();
					}
				}
				if (1 << hit.transform.gameObject.layer == LayerMask.GetMask("Button_4"))
				{
					if (!noClick)
					{
						hit.transform.GetComponent<ParticleSystem>().Play();
					}
					if (Controller.UPvr_GetKeyUp(0, Pvr_KeyCode.TRIGGER) || Controller.UPvr_GetKeyUp(1, Pvr_KeyCode.TRIGGER) || Input.GetMouseButtonDown(0))
					{
						hit.transform.parent.parent.GetComponent<Game_Control>().Cancel_Exit_Speech();
					}
				}
				if (1 << hit.transform.gameObject.layer == LayerMask.GetMask("Water"))
				{
					if (!noClick)
					{
						hit.transform.GetComponent<Renderer>().material = gazemat;
					}
					if (Controller.UPvr_GetKeyDown(0, Pvr_KeyCode.TOUCHPAD) || Controller.UPvr_GetKeyDown(1, Pvr_KeyCode.TOUCHPAD) || Input.GetMouseButtonDown(0))
					{
						referenceObj.transform.position = hit.point;
						disX = hit.transform.position.x - referenceObj.transform.position.x;
						disY = hit.transform.position.y - referenceObj.transform.position.y;
						dragObj = hit.transform;
					}
					if ((Controller.UPvr_GetKey(0, Pvr_KeyCode.TOUCHPAD) || Controller.UPvr_GetKey(1, Pvr_KeyCode.TOUCHPAD) || Input.GetMouseButton(0)) && hit.transform == dragObj.transform)
					{
						referenceObj.transform.position = new Vector3(hit.point.x, hit.point.y, hit.transform.position.z);
						dragObj.position = new Vector3(referenceObj.transform.position.x + disX, referenceObj.transform.position.y + disY, hit.transform.position.z);
					}
				}
				lastHit = hit.transform;
				currentController.transform.Find("dot").position = hit.point;
				if (Pvr_ControllerManager.Instance.LengthAdaptiveRay)
				{
					float num2 = 0.178f * currentController.transform.Find("dot").localPosition.z / 3.3f;
					Mathf.Clamp(num2, 0.05f, 0.178f);
					currentController.transform.Find("dot").localScale = new Vector3(num2, num2, 1f);
				}
			}
			else
			{
				if (lastHit != null && 1 << lastHit.transform.gameObject.layer == LayerMask.GetMask("Water"))
				{
					lastHit.transform.GetComponent<Renderer>().material = normat;
				}
				currentHit = null;
				noClick = false;
				if (Pvr_ControllerManager.Instance.LengthAdaptiveRay)
				{
					currentController.transform.Find("dot").localScale = new Vector3(0.178f, 0.178f, 1f);
				}
			}
		}
		if ((Controller.UPvr_GetKeyDown(0, Pvr_KeyCode.TOUCHPAD) || Controller.UPvr_GetKeyDown(1, Pvr_KeyCode.TOUCHPAD) || Input.GetMouseButtonDown(0)) && lastHit != null && 1 << lastHit.transform.gameObject.layer == LayerMask.GetMask("Water") && currentHit != null)
		{
			lastHit.transform.GetComponent<Renderer>().material = clickmat;
			noClick = true;
		}
	}

	private void ServiceStartSuccess()
	{
		if (Controller.UPvr_GetControllerState(0) == ControllerState.Connected || Controller.UPvr_GetControllerState(1) == ControllerState.Connected)
		{
			HeadSetController.SetActive(value: false);
		}
		else
		{
			HeadSetController.SetActive(value: true);
		}
		if (Controller.UPvr_GetMainHandNess() == 0)
		{
			currentController = controller0;
		}
		if (Controller.UPvr_GetMainHandNess() == 1)
		{
			currentController = controller1;
		}
	}

	private void ControllerStateListener(string data)
	{
		if (Controller.UPvr_GetControllerState(0) == ControllerState.Connected || Controller.UPvr_GetControllerState(1) == ControllerState.Connected)
		{
			HeadSetController.SetActive(value: false);
		}
		else
		{
			HeadSetController.SetActive(value: true);
		}
		if (Controller.UPvr_GetMainHandNess() == 0)
		{
			currentController = controller0;
		}
		if (Controller.UPvr_GetMainHandNess() == 1)
		{
			currentController = controller1;
		}
	}

	private void CheckControllerStateForGoblin(string state)
	{
		HeadSetController.SetActive(Convert.ToInt16(state) != 1);
	}

	public void SwitchControlMode()
	{
	}
}
public class Pvr_ControllerEventsExamples : MonoBehaviour
{
	private void Start()
	{
		if (!(GetComponent<Pvr_UIPointer>() == null))
		{
			GetComponent<Pvr_UIPointer>().UIPointerElementEnter += UIPointerElementEnter;
			GetComponent<Pvr_UIPointer>().UIPointerElementExit += UIPointerElementExit;
			GetComponent<Pvr_UIPointer>().UIPointerElementClick += UIPointerElementClick;
			GetComponent<Pvr_UIPointer>().UIPointerElementDragStart += UIPointerElementDragStart;
			GetComponent<Pvr_UIPointer>().UIPointerElementDragEnd += UIPointerElementDragEnd;
		}
	}

	private void UIPointerElementEnter(object sender, UIPointerEventArgs e)
	{
		PLOG.I("UI Pointer entered" + e.currentTarget.name);
	}

	private void UIPointerElementExit(object sender, UIPointerEventArgs e)
	{
		PLOG.I("UI Pointer exited" + e.currentTarget.name);
	}

	private void UIPointerElementClick(object sender, UIPointerEventArgs e)
	{
		PLOG.I("UI Pointer clicked" + e.currentTarget.name);
	}

	private void UIPointerElementDragStart(object sender, UIPointerEventArgs e)
	{
		PLOG.I("UI Pointer started dragging" + e.currentTarget.name);
	}

	private void UIPointerElementDragEnd(object sender, UIPointerEventArgs e)
	{
		PLOG.I("UI Pointer stopped dragging" + e.currentTarget.name);
	}
}
public class Pvr_ControllerInit : MonoBehaviour
{
	private ControllerVariety Variety;

	private bool isCustomModel;

	[SerializeField]
	private GameObject goblin;

	[SerializeField]
	private GameObject g2;

	[SerializeField]
	private GameObject neo2L;

	[SerializeField]
	private GameObject neo2R;

	[SerializeField]
	private GameObject neo3L;

	[SerializeField]
	private GameObject neo3R;

	[SerializeField]
	private Material standardMat;

	[SerializeField]
	private Material unlitMat;

	private int controllerType = -1;

	[HideInInspector]
	public bool loadModelSuccess;

	private int systemOrUnity;

	private JsonData curControllerData;

	private string modelName = "";

	private string texFormat = "";

	private string prePath = "";

	private string modelFilePath = "/system/media/PvrRes/controller/";

	private const string goblinTexbasePath = "Controller/controller1/controller1";

	private const string g2TexbasePath = "Controller/controller3/controller3";

	private const string neo2TexbasePath = "Controller/controller4/controller4";

	private const string neo3TexbasePath = "Controller/controller5/controller5";

	private void Awake()
	{
		Render.UPvr_GetIntConfig(15, ref systemOrUnity);
		Variety = base.transform.GetComponentInParent<Pvr_ControllerModuleInit>().Variety;
		isCustomModel = base.transform.GetComponentInParent<Pvr_ControllerModuleInit>().IsCustomModel;
		if (!isCustomModel)
		{
			Pvr_ControllerManager.PvrServiceStartSuccessEvent += ServiceStartSuccess;
			Pvr_ControllerManager.SetControllerAbilityEvent += CheckControllerStateOfAbility;
			Pvr_ControllerManager.ControllerStatusChangeEvent += CheckControllerStateForGoblin;
		}
	}

	private void OnDestroy()
	{
		Pvr_ControllerManager.PvrServiceStartSuccessEvent -= ServiceStartSuccess;
		Pvr_ControllerManager.SetControllerAbilityEvent -= CheckControllerStateOfAbility;
		Pvr_ControllerManager.ControllerStatusChangeEvent -= CheckControllerStateForGoblin;
	}

	private void OnApplicationPause(bool pause)
	{
		if (pause)
		{
			DestroyLocalController();
		}
	}

	private void ServiceStartSuccess()
	{
		int num = Controller.UPvr_GetDeviceType();
		if (controllerType != num && num != 0)
		{
			controllerType = num;
		}
		LoadResFromJson();
		if (Pvr_ControllerManager.controllerlink.neoserviceStarted)
		{
			if (Variety == ControllerVariety.Controller0)
			{
				if (Pvr_ControllerManager.controllerlink.controller0Connected)
				{
					StartCoroutine(RefreshController(0));
				}
				else
				{
					DestroyLocalController();
				}
			}
			if (Variety == ControllerVariety.Controller1)
			{
				if (Pvr_ControllerManager.controllerlink.controller1Connected)
				{
					StartCoroutine(RefreshController(1));
				}
				else
				{
					DestroyLocalController();
				}
			}
		}
		if (Pvr_ControllerManager.controllerlink.goblinserviceStarted && Variety == ControllerVariety.Controller0)
		{
			if (Pvr_ControllerManager.controllerlink.controller0Connected)
			{
				StartCoroutine(RefreshController(0));
			}
			else
			{
				DestroyLocalController();
			}
		}
	}

	private void LoadResFromJson()
	{
		string text = Pvr_UnitySDKAPI.System.UPvr_GetObjectOrArray("config.controller", 7);
		if (text != null)
		{
			JsonData jsonData = JsonMapper.ToObject(text);
			if (controllerType >= 0 && jsonData.Count >= controllerType)
			{
				curControllerData = jsonData[controllerType - 1];
				modelFilePath = (string)curControllerData["base_path"];
				modelName = (string)curControllerData["model_name"] + "_sys";
			}
		}
		else
		{
			PLOG.E("PvrLog LoadJsonFromSystem Error");
		}
	}

	private void CheckControllerStateForGoblin(string state)
	{
		int num = Controller.UPvr_GetDeviceType();
		if (Variety != 0)
		{
			return;
		}
		if (Convert.ToInt16(state) == 1)
		{
			if (controllerType != num)
			{
				DestroySysController();
				controllerType = num;
			}
			StartCoroutine(RefreshController(0));
		}
		else
		{
			DestroyLocalController();
		}
	}

	private void CheckControllerStateOfAbility(string data)
	{
		bool num = Convert.ToBoolean(Convert.ToInt16(data.Substring(4, 1)));
		short num2 = Convert.ToInt16(data.Substring(0, 1));
		int num3 = Controller.UPvr_GetDeviceType();
		if (num)
		{
			controllerType = num3;
			switch (num2)
			{
			case 0:
				if (Variety == ControllerVariety.Controller0)
				{
					StartCoroutine(RefreshController(0));
				}
				break;
			case 1:
				if (Variety == ControllerVariety.Controller1)
				{
					StartCoroutine(RefreshController(1));
				}
				break;
			}
			return;
		}
		switch (num2)
		{
		case 0:
			if (Variety == ControllerVariety.Controller0)
			{
				DestroyLocalController();
			}
			break;
		case 1:
			if (Variety == ControllerVariety.Controller1)
			{
				DestroyLocalController();
			}
			break;
		}
	}

	private void DestroyLocalController()
	{
		foreach (Transform item in base.transform)
		{
			UnityEngine.Object.Destroy(item.gameObject);
			loadModelSuccess = false;
		}
	}

	private void DestroySysController()
	{
		foreach (Transform item in base.transform)
		{
			if (item.name == modelName)
			{
				UnityEngine.Object.Destroy(item.gameObject);
				loadModelSuccess = false;
			}
		}
	}

	private IEnumerator RefreshController(int id)
	{
		yield return null;
		yield return null;
		if (Controller.UPvr_GetControllerState(id) != ControllerState.Connected)
		{
			yield break;
		}
		if (systemOrUnity == 0)
		{
			LoadControllerFromPrefab();
			if (!loadModelSuccess)
			{
				LoadControllerFromSystem(id);
			}
		}
		else
		{
			bool flag = false;
			foreach (Transform item in base.transform)
			{
				if (item.name == modelName)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				LoadControllerFromSystem(id);
				if (!loadModelSuccess)
				{
					LoadControllerFromPrefab();
				}
			}
			else
			{
				base.transform.Find(modelName).gameObject.SetActive(value: true);
			}
		}
		Pvr_ToolTips.RefreshTips();
		PLOG.I("PvrLog Controller Refresh Success");
	}

	private void LoadControllerFromPrefab()
	{
		switch (controllerType)
		{
		case 1:
		{
			Pvr_ControllerVisual pvr_ControllerVisual3 = UnityEngine.Object.Instantiate(goblin, base.transform, worldPositionStays: false).AddComponent<Pvr_ControllerVisual>();
			pvr_ControllerVisual3.currentDevice = ControllerDevice.Goblin;
			LoadTexture(pvr_ControllerVisual3, "Controller/controller1/controller1", fromRes: true);
			loadModelSuccess = true;
			break;
		}
		case 3:
		{
			Pvr_ControllerVisual pvr_ControllerVisual2 = UnityEngine.Object.Instantiate(g2, base.transform, worldPositionStays: false).AddComponent<Pvr_ControllerVisual>();
			pvr_ControllerVisual2.currentDevice = ControllerDevice.G2;
			LoadTexture(pvr_ControllerVisual2, "Controller/controller3/controller3", fromRes: true);
			loadModelSuccess = true;
			break;
		}
		case 4:
		{
			Pvr_ControllerVisual pvr_ControllerVisual4 = UnityEngine.Object.Instantiate((Variety == ControllerVariety.Controller0) ? neo2L : neo2R, base.transform, worldPositionStays: false).AddComponent<Pvr_ControllerVisual>();
			pvr_ControllerVisual4.currentDevice = ControllerDevice.Neo2;
			LoadTexture(pvr_ControllerVisual4, "Controller/controller4/controller4", fromRes: true);
			loadModelSuccess = true;
			break;
		}
		case 5:
		{
			Pvr_ControllerVisual pvr_ControllerVisual = UnityEngine.Object.Instantiate((Variety == ControllerVariety.Controller0) ? neo3L : neo3R, base.transform, worldPositionStays: false).AddComponent<Pvr_ControllerVisual>();
			pvr_ControllerVisual.currentDevice = ControllerDevice.Neo3;
			LoadTexture(pvr_ControllerVisual, "Controller/controller5/controller5", fromRes: true);
			loadModelSuccess = true;
			break;
		}
		default:
			loadModelSuccess = false;
			break;
		}
	}

	private void LoadControllerFromSystem(int id)
	{
		string text = controllerType.ToString() + id + ".obj";
		string text2 = modelFilePath + text;
		if (!File.Exists(text2))
		{
			PLOG.I("PvrLog Obj File does not exist==" + text2);
			return;
		}
		GameObject gameObject = new GameObject();
		gameObject.name = modelName;
		gameObject.AddComponent<MeshFilter>().mesh = Pvr_ObjImporter.Instance.ImportFile(text2);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.AddComponent<MeshRenderer>().material = (((int)curControllerData["material_type"] == 0) ? standardMat : unlitMat);
		loadModelSuccess = true;
		Pvr_ControllerVisual pvr_ControllerVisual = gameObject.AddComponent<Pvr_ControllerVisual>();
		switch (controllerType)
		{
		case 1:
			pvr_ControllerVisual.currentDevice = ControllerDevice.Goblin;
			break;
		case 3:
			pvr_ControllerVisual.currentDevice = ControllerDevice.G2;
			break;
		case 4:
			pvr_ControllerVisual.currentDevice = ControllerDevice.Neo2;
			break;
		case 5:
			pvr_ControllerVisual.currentDevice = ControllerDevice.Neo3;
			break;
		default:
			pvr_ControllerVisual.currentDevice = ControllerDevice.NewController;
			break;
		}
		pvr_ControllerVisual.variety = Variety;
		LoadTexture(pvr_ControllerVisual, controllerType.ToString() + id, fromRes: false);
		gameObject.transform.localRotation = Quaternion.Euler(new Vector3(0f, 180f, 0f));
		gameObject.transform.localScale = new Vector3(-0.01f, 0.01f, 0.01f);
	}

	private void LoadTexture(Pvr_ControllerVisual visual, string controllerName, bool fromRes)
	{
		if (fromRes)
		{
			texFormat = "";
			prePath = controllerName;
		}
		else
		{
			texFormat = "." + (string)curControllerData["tex_format"];
			prePath = modelFilePath + controllerName;
		}
		string filepath = prePath + "_idle" + texFormat;
		visual.m_idle = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_app" + texFormat;
		visual.m_app = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_home" + texFormat;
		visual.m_home = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_touch" + texFormat;
		visual.m_touchpad = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_volume_down" + texFormat;
		visual.m_volDn = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_volume_up" + texFormat;
		visual.m_volUp = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_trigger" + texFormat;
		visual.m_trigger = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_a" + texFormat;
		visual.m_a = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_b" + texFormat;
		visual.m_b = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_x" + texFormat;
		visual.m_x = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_y" + texFormat;
		visual.m_y = LoadOneTexture(filepath, fromRes);
		filepath = prePath + "_grip" + texFormat;
		visual.m_grip = LoadOneTexture(filepath, fromRes);
	}

	private Texture2D LoadOneTexture(string filepath, bool fromRes)
	{
		if (fromRes)
		{
			return Resources.Load<Texture2D>(filepath);
		}
		int width = (int)curControllerData["tex_width"];
		int height = (int)curControllerData["tex_height"];
		Texture2D texture2D = new Texture2D(width, height);
		texture2D.LoadImage(ReadPNG(filepath));
		return texture2D;
	}

	private byte[] ReadPNG(string path)
	{
		FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
		fileStream.Seek(0L, SeekOrigin.Begin);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, (int)fileStream.Length);
		fileStream.Close();
		fileStream.Dispose();
		fileStream = null;
		return array;
	}
}
public class Pvr_ControllerLink
{
	public AndroidJavaClass javaHummingbirdClass;

	public AndroidJavaClass javaPico2ReceiverClass;

	public AndroidJavaClass javaserviceClass;

	public AndroidJavaClass javavractivityclass;

	public AndroidJavaClass javaCVClass;

	public AndroidJavaObject activity;

	public string gameobjname = "";

	public bool picoDevice;

	public string hummingBirdMac;

	public int hummingBirdRSSI;

	public bool goblinserviceStarted;

	public bool neoserviceStarted;

	public bool controller0Connected;

	public bool controller1Connected;

	public int mainHandID;

	public Pvr_Controller.UserHandNess handness;

	public int controllerType;

	public ControllerHand Controller0;

	public ControllerHand Controller1;

	public int platFormType = -1;

	public int trackingmode = -1;

	public int systemProp = -1;

	public int enablehand6dofbyhead = -1;

	public bool switchHomeKey = true;

	private const float SWITCH_METER = 1000f;

	private int iPhoneHMDModeEnabled;

	private float[] hbPoseData = new float[4];

	private float[] sensorData = new float[28];

	private int[] keyData = new int[134];

	private int[] neo3TouchValue = new int[15];

	private float[] fixedState = new float[7] { 0f, 0f, 0f, 1f, 0f, 0f, 0f };

	private float[] neoposeData = new float[7] { 0f, 0f, 0f, 1f, 0f, 0f, 0f };

	private int[] goblinKeyArray = new int[47];

	private int[] neoKeyArray = new int[67];

	private int[] neotriggerV = new int[9];

	private float[] velocity = new float[3];

	private float[] angularVelocity = new float[3];

	private float[] angularAcce = new float[3];

	private float[] acceData = new float[3];

	private float[] predictData = new float[7];

	public Pvr_ControllerLink(string name)
	{
		gameobjname = name;
		hummingBirdMac = "";
		hummingBirdRSSI = 0;
		UnityEngine.Debug.Log("PvrLog Controller GameObject:" + gameobjname);
		StartHummingBirdService();
		Controller0 = new ControllerHand();
		Controller0.Position = new Vector3(0f, Pvr_UnitySDKSensor.Instance.HeadPose.Position.y, 0f) + new Vector3(-0.1f, -0.3f, 0.3f);
		Controller1 = new ControllerHand();
		Controller1.Position = new Vector3(0f, Pvr_UnitySDKSensor.Instance.HeadPose.Position.y, 0f) + new Vector3(0.1f, -0.3f, 0.3f);
	}

	private void StartHummingBirdService()
	{
		try
		{
			AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			activity = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
			javaHummingbirdClass = new AndroidJavaClass("com.picovr.picovrlib.hummingbirdclient.HbClientActivity");
			javaCVClass = new AndroidJavaClass("com.picovr.picovrlib.cvcontrollerclient.ControllerClient");
			javavractivityclass = new AndroidJavaClass("com.psmart.vrlib.VrActivity");
			javaserviceClass = new AndroidJavaClass("com.picovr.picovrlib.hummingbirdclient.UnityClient");
			Pvr_UnitySDKAPI.System.Pvr_SetInitActivity(activity.GetRawObject(), javaHummingbirdClass.GetRawClass());
			Render.UPvr_GetIntConfig(4, ref platFormType);
			UnityEngine.Debug.Log("PvrLog platform" + platFormType);
			Render.UPvr_GetIntConfig(5, ref trackingmode);
			UnityEngine.Debug.Log("PvrLog trackingmode" + trackingmode);
			systemProp = GetSysproc();
			UnityEngine.Debug.Log("PvrLog systemProp" + systemProp);
			Render.UPvr_GetIntConfig(7, ref enablehand6dofbyhead);
			UnityEngine.Debug.Log("PvrLog enablehand6dofbyhead" + enablehand6dofbyhead);
			if (trackingmode == 0 || trackingmode == 1 || ((trackingmode == 3 || trackingmode == 5 || trackingmode == 6) && (systemProp == 1 || systemProp == 3)))
			{
				picoDevice = platFormType != 0;
				javaPico2ReceiverClass = new AndroidJavaClass("com.picovr.picovrlib.hummingbirdclient.HbClientReceiver");
				Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaPico2ReceiverClass, "startReceiver", activity, gameobjname);
				Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "setPlatformType", platFormType);
			}
			else
			{
				picoDevice = true;
				SetGameObjectToJar(gameobjname);
			}
			Render.UPvr_GetIntConfig(16, ref iPhoneHMDModeEnabled);
			if (iPhoneHMDModeEnabled == 1)
			{
				BindService();
			}
			else if (IsServiceExisted())
			{
				BindService();
			}
		}
		catch (AndroidJavaException ex)
		{
			PLOG.E("ConnectToAndriod--catch" + ex.Message);
		}
	}

	public bool IsServiceExisted()
	{
		bool result = false;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaserviceClass, "isServiceExisted", activity, trackingmode);
		UnityEngine.Debug.Log("PvrLog ServiceExisted ?" + result);
		return result;
	}

	public void SetGameObjectToJar(string name)
	{
		UnityEngine.Debug.Log("PvrLog SetGameObjectToJar " + name);
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "setGameObjectCallback", name);
	}

	public void BindService()
	{
		UnityEngine.Debug.Log("PvrLog Bind Service");
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaserviceClass, "bindService", activity, trackingmode);
	}

	public void UnBindService()
	{
		UnityEngine.Debug.Log("PvrLog UnBind Service");
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaserviceClass, "unbindService", activity, trackingmode);
	}

	public void StopReceiver()
	{
		UnityEngine.Debug.Log("PvrLog StopReceiver");
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaPico2ReceiverClass, "stopReceiver", activity);
	}

	public void StartReceiver()
	{
		UnityEngine.Debug.Log("PvrLog StartReceiver");
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaPico2ReceiverClass, "startReceiver", activity, gameobjname);
	}

	public int getHandness()
	{
		int result = -1;
		if (iPhoneHMDModeEnabled == 0)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javavractivityclass, "getPvrHandness", activity);
		}
		else
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getHbHandednessInSP");
		}
		PLOG.I("PvrLog GetHandness =" + result);
		return result;
	}

	public void setHandness(int hand)
	{
		PLOG.I("PvrLog SetHandness =" + hand);
		if (iPhoneHMDModeEnabled == 1)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "setHbHandednessInSP", hand);
		}
	}

	public void StartScan()
	{
		PLOG.I("PvrLog ScanHBController");
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "scanHbDevice", true);
	}

	public void StopScan()
	{
		PLOG.I("PvrLog StopScanHBController");
		if (iPhoneHMDModeEnabled == 0)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "scanHbDevice", false);
		}
	}

	public int GetSysproc()
	{
		int result = -1;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaserviceClass, "getSysproc");
		PLOG.I("PvrLog GetSysproc" + result);
		return result;
	}

	public void ResetController(int num)
	{
		UnityEngine.Debug.Log("PvrLog ResetController" + num);
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "resetControllerSensorState", num);
		}
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "resetHbSensorState");
		}
	}

	public void ConnectBLE()
	{
		UnityEngine.Debug.Log("PvrLog ConnectHBController" + hummingBirdMac);
		if (hummingBirdMac != "")
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "connectHbController", hummingBirdMac);
		}
	}

	public void DisConnectBLE()
	{
		UnityEngine.Debug.Log("PvrLog DisConnectHBController");
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "disconnectHbController");
	}

	public bool StartUpgrade()
	{
		UnityEngine.Debug.Log("PvrLog StartUpgradeHBController");
		bool result = false;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "startUpgrade");
		return result;
	}

	public void setBinPath(string path, bool isasset)
	{
		UnityEngine.Debug.Log("PvrLog setBinPath" + path + isasset);
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "setBinPath", path, isasset);
	}

	public string GetBLEImageType()
	{
		string result = "";
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getBLEImageType");
		}
		UnityEngine.Debug.Log("PvrLog GetBLEImageType" + result);
		return result;
	}

	public long GetBLEVersion()
	{
		long result = 0L;
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getBLEVersion");
		}
		UnityEngine.Debug.Log("PvrLog GetBLEVersion" + result);
		return result;
	}

	public string GetFileImageType()
	{
		string result = "";
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getFileImageType");
		}
		UnityEngine.Debug.Log("PvrLog GetFileImageType" + result);
		return result;
	}

	public long GetFileVersion()
	{
		long result = 0L;
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getFileVersion");
		}
		UnityEngine.Debug.Log("PvrLog GetFileVersion" + result);
		return result;
	}

	public int GetControllerConnectionState(int num)
	{
		int result = -1;
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getControllerConnectionState", num);
		}
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getHbConnectionState");
		}
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog GetControllerState:" + num + "state:" + result);
		}
		return result;
	}

	public void RebackToLauncher()
	{
		UnityEngine.Debug.Log("PvrLog RebackToLauncher");
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "startLauncher");
		}
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "startLauncher");
		}
	}

	public void TurnUpVolume()
	{
		UnityEngine.Debug.Log("PvrLog TurnUpVolume");
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "turnUpVolume", activity);
		}
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "turnUpVolume", activity);
		}
	}

	public void TurnDownVolume()
	{
		UnityEngine.Debug.Log("PvrLog TurnDownVolume");
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "turnDownVolume", activity);
		}
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "turnDownVolume", activity);
		}
	}

	public float[] GetHBControllerPoseData()
	{
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref hbPoseData, javaHummingbirdClass, "getHBSensorPose");
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog HBControllerData" + hbPoseData[0] + "," + hbPoseData[1] + "," + hbPoseData[2] + "," + hbPoseData[3]);
		}
		return hbPoseData;
	}

	public float[] GetControllerSensorData()
	{
		if (enablehand6dofbyhead == 1)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref sensorData, javaCVClass, "getControllerDataInfoBySharmem", Pvr_UnitySDKManager.SDK.headData);
		}
		else
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref sensorData, javaCVClass, "getControllerDataInfoBySharmem");
		}
		return sensorData;
	}

	public int[] GetControllerKeyData()
	{
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref keyData, javaCVClass, "getDoubleControllerKeyEventUnityExtBySharmem");
		return keyData;
	}

	public int[] GetNeo3TouchData(int hand)
	{
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref neo3TouchValue, javaCVClass, "getControllerTouchEvent", hand);
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog Neo3Touch hand:" + hand + "-" + neo3TouchValue[0] + neo3TouchValue[1] + neo3TouchValue[2] + neo3TouchValue[3] + neo3TouchValue[4] + "," + neo3TouchValue[5] + neo3TouchValue[6] + neo3TouchValue[7] + neo3TouchValue[8] + neo3TouchValue[9] + "," + neo3TouchValue[10] + neo3TouchValue[11] + neo3TouchValue[12] + neo3TouchValue[13] + neo3TouchValue[14]);
		}
		return neo3TouchValue;
	}

	public int GetNeo3GripValue(int hand)
	{
		int result = 0;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getControllerGripValue", hand);
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog Neo3GripValue:" + result);
		}
		return result;
	}

	public float[] GetControllerFixedSensorState(int hand)
	{
		if (trackingmode == 2 || trackingmode == 3)
		{
			return fixedState;
		}
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref fixedState, javaCVClass, "getControllerFixedSensorState", hand);
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog GetControllerFixedSensorState " + hand + "Rotation:" + fixedState[0] + "," + fixedState[1] + "," + fixedState[2] + "," + fixedState[3] + "Position:" + fixedState[4] + "," + fixedState[5] + "," + fixedState[6]);
		}
		return fixedState;
	}

	public float[] GetCvControllerPoseData(int hand)
	{
		if (enablehand6dofbyhead == 1)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref neoposeData, javaCVClass, "getControllerSensorState", hand, Pvr_UnitySDKManager.SDK.headData);
		}
		else
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref neoposeData, javaCVClass, "getControllerSensorState", hand);
		}
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog CVControllerData :" + neoposeData[0] + "," + neoposeData[1] + "," + neoposeData[2] + "," + neoposeData[3] + "," + neoposeData[4] + "," + neoposeData[5] + "," + neoposeData[6]);
		}
		return neoposeData;
	}

	public int[] GetHBControllerKeyData()
	{
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref goblinKeyArray, javaHummingbirdClass, "getHBKeyEventUnityExt");
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog HBControllerKey" + goblinKeyArray[0] + goblinKeyArray[1] + goblinKeyArray[2] + goblinKeyArray[3] + goblinKeyArray[4] + "," + goblinKeyArray[5] + goblinKeyArray[6] + goblinKeyArray[7] + goblinKeyArray[8] + goblinKeyArray[9] + "," + goblinKeyArray[10] + goblinKeyArray[11] + goblinKeyArray[12] + goblinKeyArray[13] + goblinKeyArray[14] + "," + goblinKeyArray[15] + goblinKeyArray[16] + goblinKeyArray[17] + goblinKeyArray[18] + goblinKeyArray[19] + "," + goblinKeyArray[20] + goblinKeyArray[21] + goblinKeyArray[22] + goblinKeyArray[23] + goblinKeyArray[24] + "," + goblinKeyArray[25] + goblinKeyArray[26] + goblinKeyArray[27] + goblinKeyArray[28] + goblinKeyArray[29] + "," + goblinKeyArray[30] + goblinKeyArray[31] + goblinKeyArray[32] + goblinKeyArray[33] + goblinKeyArray[34] + "," + goblinKeyArray[35] + goblinKeyArray[36] + goblinKeyArray[37] + goblinKeyArray[38] + goblinKeyArray[39] + "," + goblinKeyArray[40] + goblinKeyArray[41] + goblinKeyArray[42] + goblinKeyArray[43] + goblinKeyArray[44] + "," + goblinKeyArray[45] + goblinKeyArray[46]);
		}
		return goblinKeyArray;
	}

	public int GetHBKeyValue()
	{
		int result = -1;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getTriggerKeyEvent");
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog GoblinControllerTriggerKey:" + result);
		}
		return result;
	}

	public int[] GetCvControllerKeyData(int hand)
	{
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref neoKeyArray, javaCVClass, "getControllerKeyEventUnityExt", hand);
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog CVControllerKey hand:" + hand + "-" + neoKeyArray[0] + neoKeyArray[1] + neoKeyArray[2] + neoKeyArray[3] + neoKeyArray[4] + "," + neoKeyArray[5] + neoKeyArray[6] + neoKeyArray[7] + neoKeyArray[8] + neoKeyArray[9] + "," + neoKeyArray[10] + neoKeyArray[11] + neoKeyArray[12] + neoKeyArray[13] + neoKeyArray[14] + "," + neoKeyArray[15] + neoKeyArray[16] + neoKeyArray[17] + neoKeyArray[18] + neoKeyArray[19] + "," + neoKeyArray[20] + neoKeyArray[21] + neoKeyArray[22] + neoKeyArray[23] + neoKeyArray[24] + "," + neoKeyArray[25] + neoKeyArray[26] + neoKeyArray[27] + neoKeyArray[28] + neoKeyArray[29] + "," + neoKeyArray[30] + neoKeyArray[31] + neoKeyArray[32] + neoKeyArray[33] + neoKeyArray[34] + "," + neoKeyArray[35] + neoKeyArray[36] + neoKeyArray[37] + neoKeyArray[38] + neoKeyArray[39] + "," + neoKeyArray[40] + neoKeyArray[41] + neoKeyArray[42] + neoKeyArray[43] + neoKeyArray[44] + "," + neoKeyArray[45] + neoKeyArray[46] + neoKeyArray[47] + neoKeyArray[48] + neoKeyArray[49] + "," + neoKeyArray[50] + neoKeyArray[51] + neoKeyArray[52] + neoKeyArray[53] + neoKeyArray[54] + "," + neoKeyArray[55] + neoKeyArray[56] + neoKeyArray[57] + neoKeyArray[58] + neoKeyArray[59] + "," + neoKeyArray[60] + neoKeyArray[61] + neoKeyArray[62] + neoKeyArray[63] + neoKeyArray[64] + "," + neoKeyArray[65] + neoKeyArray[66]);
		}
		return neoKeyArray;
	}

	public int GetCVTriggerValue(int hand)
	{
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref neotriggerV, javaCVClass, "getControllerKeyEvent", hand);
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog CVTriggerValue " + neotriggerV[7]);
		}
		return neotriggerV[7];
	}

	public void AutoConnectHbController(int scanTimeMs)
	{
		PLOG.I("PvrLog AutoConnectHbController" + scanTimeMs);
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "autoConnectHbController", scanTimeMs, gameobjname);
	}

	public void StartControllerThread(int headSensorState, int handSensorState)
	{
		if (BoundarySystem.UPvr_IsBoundaryEnable())
		{
			headSensorState = 1;
			handSensorState = 1;
		}
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "startControllerThread", headSensorState, handSensorState);
		UnityEngine.Debug.Log("PvrLog StartControllerThread" + headSensorState + handSensorState);
	}

	public void StopControllerThread(int headSensorState, int handSensorState)
	{
		if (BoundarySystem.UPvr_IsBoundaryEnable())
		{
			headSensorState = 1;
			handSensorState = 1;
		}
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "stopControllerThread", headSensorState, handSensorState);
		UnityEngine.Debug.Log("PvrLog StopControllerThread" + headSensorState + handSensorState);
	}

	public void SetUnityVersionToJar(string version)
	{
		if (trackingmode == 4 || trackingmode == 5 || trackingmode == 6)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "setUnityVersion", version);
		}
		UnityEngine.Debug.Log("PvrLog SetUnityVersionToJar" + version);
	}

	public Vector3 GetVelocity(int num)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref velocity, javaCVClass, "getControllerLinearVelocity", num);
		}
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog Velocity" + velocity[0] / 1000f + "," + velocity[1] / 1000f + "," + velocity[2] / 1000f);
		}
		return new Vector3(velocity[0] / 1000f, velocity[1] / 1000f, (0f - velocity[2]) / 1000f);
	}

	public Vector3 GetAngularVelocity(int num)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref angularVelocity, javaCVClass, "getControllerAngularVelocity", num);
		}
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref angularVelocity, javaHummingbirdClass, "getHbAngularVelocity");
		}
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog Gyro:" + angularVelocity[0] + "," + angularVelocity[1] + "," + angularVelocity[2]);
		}
		if (!float.IsNaN(angularVelocity[0]) && !float.IsNaN(angularVelocity[1]) && !float.IsNaN(angularVelocity[2]))
		{
			if (neoserviceStarted)
			{
				return new Vector3(0f - angularVelocity[0], 0f - angularVelocity[1], angularVelocity[2]);
			}
			if (goblinserviceStarted)
			{
				return new Vector3(0f - angularVelocity[0], 0f - angularVelocity[1], 0f - angularVelocity[2]);
			}
		}
		return new Vector3(0f, 0f, 0f);
	}

	public Vector3 GetAngularAcceleration(int num)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref angularAcce, javaCVClass, "getControllerAngularAcceleration", num);
		}
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog angularAcce:" + angularAcce[0] + "," + angularAcce[1] + "," + angularAcce[2]);
		}
		if (!float.IsNaN(angularAcce[0]) && !float.IsNaN(angularAcce[1]) && !float.IsNaN(angularAcce[2]))
		{
			return new Vector3(0f - angularAcce[0], 0f - angularAcce[1], angularAcce[2]);
		}
		return new Vector3(0f, 0f, 0f);
	}

	public Vector3 GetAcceleration(int num)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref acceData, javaCVClass, "getControllerAcceleration", num);
		}
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref acceData, javaHummingbirdClass, "getHbAcceleration");
		}
		if (PLOG.logLevel > 2)
		{
			PLOG.D("PvrLog Acce:" + acceData[0] / 1000f + acceData[1] / 1000f + acceData[2] / 1000f);
		}
		if (!float.IsNaN(acceData[0]) && !float.IsNaN(acceData[1]) && !float.IsNaN(acceData[2]))
		{
			return new Vector3(acceData[0] / 1000f, acceData[1] / 1000f, (0f - acceData[2]) / 1000f);
		}
		return new Vector3(0f, 0f, 0f);
	}

	public string GetConnectedDeviceMac()
	{
		string result = "";
		if (goblinserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getConnectedDeviceMac");
		}
		PLOG.I("PvrLog ConnectedDeviceMac:" + result);
		return result;
	}

	public void VibrateNeo2Controller(float strength, int time, int hand)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "vibrateCV2ControllerStrength", strength, time, hand);
		}
		PLOG.I("PvrLog VibrateNeo2Controller:" + strength + time + hand);
	}

	public void VibrateController(float strength, int time, int hand)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "vibrateCV2ControllerStrength", strength, time, hand);
		}
		PLOG.I("PvrLog VibrateController:" + strength + time + hand);
	}

	public int GetMainControllerIndex()
	{
		int result = 0;
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getMainControllerIndex");
		}
		PLOG.I("PvrLog GetMainControllerIndex:" + result);
		return result;
	}

	public void SetMainController(int index)
	{
		PLOG.I("PvrLog SetMainController:" + index);
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "setMainController", index);
		}
	}

	public void ResetHeadSensorForController()
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "resetHeadSensorForController");
		}
		PLOG.I("PvrLog ResetHeadSensorForController:");
	}

	public void GetDeviceVersion(int deviceType)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "getDeviceVersion", deviceType);
		}
		PLOG.I("PvrLog GetDeviceVersion:" + deviceType);
	}

	public void GetControllerSnCode(int controllerSerialNum)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "getControllerSnCode", controllerSerialNum);
		}
		PLOG.I("PvrLog GetControllerSnCode:" + controllerSerialNum);
	}

	public void SetControllerUnbind(int controllerSerialNum)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "setControllerUnbind", controllerSerialNum);
		}
		PLOG.I("PvrLog SetControllerUnbind:" + controllerSerialNum);
	}

	public void SetStationRestart()
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "setStationRestart");
		}
		PLOG.I("PvrLog SetStationRestart");
	}

	public void StartStationOtaUpdate()
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "startStationOtaUpdate");
		}
		PLOG.I("PvrLog StartStationOtaUpdate");
	}

	public void StartControllerOtaUpdate(int mode, int controllerSerialNum)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "startControllerOtaUpdate", mode, controllerSerialNum);
		}
		PLOG.I("PvrLog StartControllerOtaUpdate" + mode + controllerSerialNum);
	}

	public void EnterPairMode(int controllerSerialNum)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "enterPairMode", controllerSerialNum);
		}
		PLOG.I("PvrLog EnterPairMode" + controllerSerialNum);
	}

	public void SetControllerShutdown(int controllerSerialNum)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "setControllerShutdown", controllerSerialNum);
		}
		PLOG.I("PvrLog SetControllerShutdown" + controllerSerialNum);
	}

	public int GetStationPairState()
	{
		int result = -1;
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getStationPairState");
		}
		PLOG.I("PvrLog StationPairState" + result);
		return result;
	}

	public int GetStationOtaUpdateProgress()
	{
		int result = -1;
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getStationOtaUpdateProgress");
		}
		PLOG.I("PvrLog StationOtaUpdateProgress" + result);
		return result;
	}

	public int GetControllerOtaUpdateProgress()
	{
		int result = -1;
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getControllerOtaUpdateProgress");
		}
		PLOG.I("PvrLog ControllerOtaUpdateProgress" + result);
		return result;
	}

	public void GetControllerVersionAndSN(int controllerSerialNum)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "getControllerVersionAndSN", controllerSerialNum);
		}
		PLOG.I("PvrLog GetControllerVersionAndSN" + controllerSerialNum);
	}

	public void GetControllerUniqueID()
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "getControllerUniqueID");
		}
		PLOG.I("PvrLog GetControllerUniqueID");
	}

	public void InterruptStationPairMode()
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "interruptStationPairMode");
		}
		PLOG.I("PvrLog InterruptStationPairMode");
	}

	public int GetControllerAbility(int controllerSerialNum)
	{
		int result = -1;
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getControllerAbility", controllerSerialNum);
		}
		PLOG.I("PvrLog ControllerAbility:" + result);
		return result;
	}

	public void SwitchHomeKey(bool state)
	{
		PLOG.I("PvrLog SwitchHomeKey:" + state);
		switchHomeKey = state;
	}

	public void SetBootReconnect()
	{
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaHummingbirdClass, "setBootReconnect");
		PLOG.I("PvrLog SetBootReconnect");
	}

	public int GetTemperature()
	{
		int result = -1;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getTemperature");
		PLOG.I("PvrLog Temperature:" + result);
		return result;
	}

	public int GetDeviceType()
	{
		int result = -1;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getDeviceType");
		PLOG.I("PvrLog DeviceType:" + result);
		return result;
	}

	public int GetControllerType()
	{
		int result = -1;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getControllerType");
		return result;
	}

	public string GetHummingBird2SN()
	{
		string result = "";
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getHummingBird2SN");
		PLOG.I("PvrLog HummingBird2SN:" + result);
		return result;
	}

	public string GetControllerVersion()
	{
		string result = "";
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "getControllerVersion");
		PLOG.I("PvrLog ControllerVersion:" + result);
		return result;
	}

	public bool IsEnbleTrigger()
	{
		bool result = false;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaHummingbirdClass, "isEnbleTrigger");
		PLOG.I("PvrLog IsEnbleTrigger:" + result);
		return result;
	}

	public void StartCV2PairingMode(int devicetype)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "startCV2PairingMode", devicetype);
		}
		PLOG.I("PvrLog StartCV2PairingMode:" + devicetype);
	}

	public void StopCV2PairingMode(int devicetype)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "stopCV2PairingMode", devicetype);
		}
		PLOG.I("PvrLog StopCV2PairingMode:" + devicetype);
	}

	public int GetControllerBindingState(int id)
	{
		int result = -1;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getControllerBindingState", id);
		PLOG.I("PvrLog getControllerBindingState:" + result);
		return result;
	}

	public void setIsEnbleHomeKey(bool state)
	{
		if (neoserviceStarted)
		{
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "setIsEnbleHomeKey", state);
		}
		PLOG.I("PvrLog setIsEnbleHomeKey:" + state);
	}

	public int getControllerSensorStatus(int id)
	{
		int result = -1;
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaCVClass, "getControllerSensorStatus", id);
		PLOG.I("PvrLog getControllerSensorStatus:" + result);
		return result;
	}

	public float[] GetControllerPredictSensorData(int controllerID, float predictTime)
	{
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(javaCVClass, "SetHeadDataAndPreTime", Pvr_UnitySDKManager.SDK.headData, predictTime);
		Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref predictData, javaCVClass, "getControllerSensorStateWithHeadDataAndPreTime", controllerID);
		return predictData;
	}
}
public class Pvr_ControllerManager : MonoBehaviour
{
	public delegate void PvrServiceStartSuccess();

	public delegate void PvrControllerStateChanged(string data);

	public delegate void ChangeMainControllerCallBack(string index);

	public delegate void ChangeHandNessCallBack(string index);

	public delegate void SetHbServiceBindState();

	public delegate void ControllerThreadStartedCallback();

	public delegate void SetControllerServiceBindState();

	public delegate void ControllerStatusChange(string isconnect);

	public delegate void SetControllerAbility(string data);

	public delegate void SetControllerStateChanged(string data);

	public delegate void SetHbControllerMac(string mac);

	public delegate void ControllerDeviceVersionCallback(string data);

	public delegate void ControllerSnCodeCallback(string data);

	public delegate void ControllerUnbindCallback(string status);

	public delegate void ControllerStationStatusCallback(string status);

	public delegate void ControllerStationBusyCallback(string status);

	public delegate void ControllerOtaStartCodeCallback(string data);

	public delegate void ControllerDeviceVersionAndSNCallback(string data);

	public delegate void ControllerUniqueIDCallback(string data);

	public delegate void ControllerCombinedKeyUnbindCallback(string data);

	private static Pvr_ControllerManager instance;

	public static Pvr_ControllerLink controllerlink;

	private float cTime = 1f;

	private bool stopConnect;

	public Text toast;

	private bool controllerServicestate;

	private float disConnectTime;

	public bool LengthAdaptiveRay;

	private float[] sensorData = new float[28];

	private int[] keyData = new int[134];

	private float[] g2SensorData = new float[4];

	private int[] g2KeyData = new int[47];

	private int keyOffset;

	private int rotControllerMode = 1;

	public static Pvr_ControllerManager Instance
	{
		get
		{
			if (instance == null)
			{
				instance = UnityEngine.Object.FindObjectOfType<Pvr_ControllerManager>();
			}
			if (instance == null)
			{
				GameObject obj = new GameObject("GameObject");
				instance = obj.AddComponent<Pvr_ControllerManager>();
				obj.transform.localPosition = Vector3.zero;
			}
			return instance;
		}
	}

	public static event PvrServiceStartSuccess PvrServiceStartSuccessEvent;

	public static event PvrControllerStateChanged PvrControllerStateChangedEvent;

	public static event ChangeMainControllerCallBack ChangeMainControllerCallBackEvent;

	public static event ChangeHandNessCallBack ChangeHandNessCallBackEvent;

	public static event SetHbServiceBindState SetHbServiceBindStateEvent;

	public static event ControllerThreadStartedCallback ControllerThreadStartedCallbackEvent;

	public static event SetControllerServiceBindState SetControllerServiceBindStateEvent;

	public static event ControllerStatusChange ControllerStatusChangeEvent;

	public static event SetControllerAbility SetControllerAbilityEvent;

	public static event SetControllerStateChanged SetControllerStateChangedEvent;

	public static event SetHbControllerMac SetHbControllerMacEvent;

	public static event ControllerDeviceVersionCallback ControllerDeviceVersionCallbackEvent;

	public static event ControllerSnCodeCallback ControllerSnCodeCallbackEvent;

	public static event ControllerUnbindCallback ControllerUnbindCallbackEvent;

	public static event ControllerStationStatusCallback ControllerStationStatusCallbackEvent;

	public static event ControllerStationBusyCallback ControllerStationBusyCallbackEvent;

	public static event ControllerOtaStartCodeCallback ControllerOtaStartCodeCallbackEvent;

	public static event ControllerDeviceVersionAndSNCallback ControllerDeviceVersionAndSNCallbackEvent;

	public static event ControllerUniqueIDCallback ControllerUniqueIDCallbackEvent;

	public static event ControllerCombinedKeyUnbindCallback ControllerCombinedKeyUnbindCallbackEvent;

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		if (instance != this)
		{
			PLOG.E("instance object should be a singleton.");
			return;
		}
		if (controllerlink == null)
		{
			controllerlink = new Pvr_ControllerLink(base.gameObject.name);
			return;
		}
		controllerlink.SetGameObjectToJar(base.gameObject.name);
		BindService();
	}

	private void Start()
	{
		if (controllerlink.trackingmode < 2)
		{
			Invoke("CheckControllerService", 10f);
		}
		Render.UPvr_GetIntConfig(23, ref rotControllerMode);
	}

	private void Update()
	{
		if (controllerlink.neoserviceStarted)
		{
			sensorData = controllerlink.GetControllerSensorData();
			keyData = controllerlink.GetControllerKeyData();
			if (controllerlink.controller0Connected)
			{
				if (Pvr_UnitySDKManager.SDK.ShowVideoSeethrough)
				{
					sensorData[2] = 0f - sensorData[2];
					sensorData[3] = 0f - sensorData[3];
					controllerlink.Controller0.Rotation.Set(sensorData[0], sensorData[1], sensorData[2], sensorData[3]);
					if (rotControllerMode == 0)
					{
						controllerlink.Controller0.Rotation *= Quaternion.Euler(34f, 0f, 0f);
					}
					controllerlink.Controller0.Position.Set(sensorData[4] / 1000f, sensorData[5] / 1000f, (0f - sensorData[6]) / 1000f);
				}
				else
				{
					controllerlink.Controller0.Rotation.Set(sensorData[7], sensorData[8], sensorData[9], sensorData[10]);
					if (rotControllerMode == 0)
					{
						controllerlink.Controller0.Rotation *= Quaternion.Euler(34f, 0f, 0f);
					}
					controllerlink.Controller0.Position.Set(sensorData[11] / 1000f, sensorData[12] / 1000f, (0f - sensorData[13]) / 1000f);
				}
				if (!controllerlink.Controller0.isShowBoundary)
				{
					if (controllerlink.getControllerSensorStatus(0) == 0)
					{
						Sensor.UPvr_SetReinPosition(sensorData[0], sensorData[1], sensorData[2], sensorData[3], sensorData[4], sensorData[5], sensorData[6], 0, valid: false, 0);
					}
					else
					{
						controllerlink.Controller0.isShowBoundary = true;
						Sensor.UPvr_SetReinPosition(sensorData[0], sensorData[1], sensorData[2], sensorData[3], sensorData[4], sensorData[5], sensorData[6], 0, valid: true, Convert.ToInt32(Convert.ToString(keyData[35]) + Convert.ToString(keyData[15]) + "00", 2));
					}
				}
				else
				{
					Sensor.UPvr_SetReinPosition(sensorData[0], sensorData[1], sensorData[2], sensorData[3], sensorData[4], sensorData[5], sensorData[6], 0, valid: true, Convert.ToInt32(Convert.ToString(keyData[35]) + Convert.ToString(keyData[15]) + "00", 2));
				}
				TransformData(controllerlink.Controller0, 0, keyData);
			}
			else
			{
				Sensor.UPvr_SetReinPosition(sensorData[0], sensorData[1], sensorData[2], sensorData[3], sensorData[4], sensorData[5], sensorData[6], 0, valid: false, 0);
			}
			if (controllerlink.controller1Connected)
			{
				if (Pvr_UnitySDKManager.SDK.ShowVideoSeethrough)
				{
					sensorData[16] = 0f - sensorData[16];
					sensorData[17] = 0f - sensorData[17];
					controllerlink.Controller1.Rotation.Set(sensorData[14], sensorData[15], sensorData[16], sensorData[17]);
					if (rotControllerMode == 0)
					{
						controllerlink.Controller1.Rotation *= Quaternion.Euler(34f, 0f, 0f);
					}
					controllerlink.Controller1.Position.Set(sensorData[18] / 1000f, sensorData[19] / 1000f, (0f - sensorData[20]) / 1000f);
				}
				else
				{
					controllerlink.Controller1.Rotation.Set(sensorData[21], sensorData[22], sensorData[23], sensorData[24]);
					if (rotControllerMode == 0)
					{
						controllerlink.Controller1.Rotation *= Quaternion.Euler(34f, 0f, 0f);
					}
					controllerlink.Controller1.Position.Set(sensorData[25] / 1000f, sensorData[26] / 1000f, (0f - sensorData[27]) / 1000f);
				}
				if (!controllerlink.Controller1.isShowBoundary)
				{
					if (controllerlink.getControllerSensorStatus(1) == 0)
					{
						Sensor.UPvr_SetReinPosition(sensorData[14], sensorData[15], sensorData[16], sensorData[17], sensorData[18], sensorData[19], sensorData[20], 1, valid: false, 0);
					}
					else
					{
						controllerlink.Controller1.isShowBoundary = true;
						Sensor.UPvr_SetReinPosition(sensorData[14], sensorData[15], sensorData[16], sensorData[17], sensorData[18], sensorData[19], sensorData[20], 1, valid: true, Convert.ToInt32(Convert.ToString(keyData[102]) + Convert.ToString(keyData[82]) + "00", 2));
					}
				}
				else
				{
					Sensor.UPvr_SetReinPosition(sensorData[14], sensorData[15], sensorData[16], sensorData[17], sensorData[18], sensorData[19], sensorData[20], 1, valid: true, Convert.ToInt32(Convert.ToString(keyData[102]) + Convert.ToString(keyData[82]) + "00", 2));
				}
				TransformData(controllerlink.Controller1, 1, keyData);
			}
			else
			{
				Sensor.UPvr_SetReinPosition(sensorData[14], sensorData[15], sensorData[16], sensorData[17], sensorData[18], sensorData[19], sensorData[20], 1, valid: false, 0);
			}
		}
		if (controllerlink.goblinserviceStarted && controllerlink.controller0Connected)
		{
			g2SensorData = controllerlink.GetHBControllerPoseData();
			controllerlink.Controller0.Rotation.Set(g2SensorData[0], g2SensorData[1], g2SensorData[2], g2SensorData[3]);
			g2KeyData = controllerlink.GetHBControllerKeyData();
			TransformData(controllerlink.Controller0, 0, g2KeyData);
		}
		SetSystemKey();
	}

	private void OnApplicationPause(bool pause)
	{
		int headSensorState = ((!Pvr_UnitySDKManager.SDK.HmdOnlyrot) ? 1 : 0);
		int handSensorState = ((!Pvr_UnitySDKManager.SDK.ControllerOnlyrot) ? 1 : 0);
		if (pause)
		{
			if (controllerlink.neoserviceStarted)
			{
				controllerlink.SetGameObjectToJar("");
				controllerlink.StopControllerThread(headSensorState, handSensorState);
			}
			if (controllerlink.goblinserviceStarted)
			{
				controllerlink.StopReceiver();
			}
			return;
		}
		controllerlink.Controller0 = new ControllerHand();
		controllerlink.Controller1 = new ControllerHand();
		if (controllerlink.neoserviceStarted)
		{
			controllerlink.SetGameObjectToJar(base.gameObject.name);
			controllerlink.SetUnityVersionToJar("2.8.11.5");
			controllerlink.StartControllerThread(headSensorState, handSensorState);
		}
		if (controllerlink.goblinserviceStarted)
		{
			controllerlink.StartReceiver();
			controllerlink.controller0Connected = GetControllerConnectionState(0) == 1;
			controllerlink.controllerType = controllerlink.GetControllerType();
			controllerlink.handness = (Pvr_Controller.UserHandNess)controllerlink.getHandness();
			if (Pvr_ControllerManager.PvrServiceStartSuccessEvent != null)
			{
				Pvr_ControllerManager.PvrServiceStartSuccessEvent();
			}
		}
	}

	private void OnDestroy()
	{
		controllerlink.UnBindService();
		Sensor.UPvr_SetReinPosition(0f, 0f, 0f, 1f, 0f, 0f, 0f, 0, valid: false, 0);
		Sensor.UPvr_SetReinPosition(0f, 0f, 0f, 1f, 0f, 0f, 0f, 1, valid: false, 0);
	}

	private void OnApplicationQuit()
	{
		int headSensorState = ((!Pvr_UnitySDKManager.SDK.HmdOnlyrot) ? 1 : 0);
		int handSensorState = ((!Pvr_UnitySDKManager.SDK.ControllerOnlyrot) ? 1 : 0);
		if (controllerlink.neoserviceStarted)
		{
			controllerlink.SetGameObjectToJar("");
			controllerlink.StopControllerThread(headSensorState, handSensorState);
		}
	}

	public Vector3 GetAngularVelocity(int num)
	{
		if (controllerlink != null)
		{
			return controllerlink.GetAngularVelocity(num);
		}
		return new Vector3(0f, 0f, 0f);
	}

	public Vector3 GetAcceleration(int num)
	{
		if (controllerlink != null)
		{
			return controllerlink.GetAcceleration(num);
		}
		return new Vector3(0f, 0f, 0f);
	}

	public void BindService()
	{
		if (controllerlink != null)
		{
			controllerlink.BindService();
		}
	}

	public void StartScan()
	{
		if (controllerlink != null)
		{
			controllerlink.StartScan();
		}
	}

	public void StopScan()
	{
		if (controllerlink != null)
		{
			controllerlink.StopScan();
		}
	}

	public void ResetController(int num)
	{
		if (controllerlink != null)
		{
			controllerlink.ResetController(num);
		}
	}

	public static int GetControllerConnectionState(int num)
	{
		return controllerlink.GetControllerConnectionState(num);
	}

	public void ConnectBLE()
	{
		if (controllerlink != null)
		{
			controllerlink.ConnectBLE();
		}
	}

	public void DisConnectBLE()
	{
		if (controllerlink != null)
		{
			controllerlink.DisConnectBLE();
		}
	}

	public void SetBinPath(string path, bool isAsset)
	{
		if (controllerlink != null)
		{
			controllerlink.setBinPath(path, isAsset);
		}
	}

	public void StartUpgrade()
	{
		if (controllerlink != null)
		{
			controllerlink.StartUpgrade();
		}
	}

	public static string GetBLEImageType()
	{
		return controllerlink.GetBLEImageType();
	}

	public static long GetBLEVersion()
	{
		return controllerlink.GetBLEVersion();
	}

	public static string GetFileImageType()
	{
		return controllerlink.GetFileImageType();
	}

	public static long GetFileVersion()
	{
		return controllerlink.GetFileVersion();
	}

	public static void AutoConnectHbController(int scans)
	{
		if (controllerlink != null)
		{
			controllerlink.AutoConnectHbController(scans);
		}
	}

	public static string GetConnectedDeviceMac()
	{
		string result = "";
		if (controllerlink != null)
		{
			result = controllerlink.GetConnectedDeviceMac();
		}
		return result;
	}

	public void setHbControllerMac(string mac)
	{
		PLOG.I("PvrLog HBMacRSSI" + mac);
		controllerlink.hummingBirdMac = mac.Substring(0, 17);
		controllerlink.hummingBirdRSSI = Convert.ToInt16(mac.Remove(0, 18));
		if (Pvr_ControllerManager.SetHbControllerMacEvent != null)
		{
			Pvr_ControllerManager.SetHbControllerMacEvent(mac.Substring(0, 17));
		}
	}

	public int GetControllerRSSI()
	{
		return controllerlink.hummingBirdRSSI;
	}

	public void setHbServiceBindState(string state)
	{
		PLOG.I("PvrLog HBBindCallBack" + state);
		controllerServicestate = true;
		if (Convert.ToInt16(state) == 0)
		{
			Invoke("BindService", 0.5f);
			controllerlink.goblinserviceStarted = false;
		}
		else if (Convert.ToInt16(state) == 1)
		{
			controllerlink.goblinserviceStarted = true;
			controllerlink.controller0Connected = GetControllerConnectionState(0) == 1;
			controllerlink.controllerType = controllerlink.GetControllerType();
			controllerlink.handness = (Pvr_Controller.UserHandNess)controllerlink.getHandness();
			if (Pvr_ControllerManager.SetHbServiceBindStateEvent != null)
			{
				Pvr_ControllerManager.SetHbServiceBindStateEvent();
			}
			if (Pvr_ControllerManager.PvrServiceStartSuccessEvent != null)
			{
				Pvr_ControllerManager.PvrServiceStartSuccessEvent();
			}
		}
	}

	public void setControllerServiceBindState(string state)
	{
		PLOG.I("PvrLog CVBindCallBack" + state);
		if (Convert.ToInt16(state) == 0)
		{
			Invoke("BindService", 0.5f);
			controllerlink.neoserviceStarted = false;
		}
		else if (Convert.ToInt16(state) == 1)
		{
			controllerlink.SetUnityVersionToJar("2.8.11.5");
			controllerlink.neoserviceStarted = true;
			int headSensorState = ((!Pvr_UnitySDKManager.SDK.HmdOnlyrot) ? 1 : 0);
			int handSensorState = ((!Pvr_UnitySDKManager.SDK.ControllerOnlyrot) ? 1 : 0);
			controllerlink.StartControllerThread(headSensorState, handSensorState);
			if (Pvr_ControllerManager.SetControllerServiceBindStateEvent != null)
			{
				Pvr_ControllerManager.SetControllerServiceBindStateEvent();
			}
		}
	}

	public void setHbControllerConnectState(string isconnect)
	{
		PLOG.I("PvrLog HBControllerConnect" + isconnect);
		controllerlink.controller0Connected = Convert.ToInt16(isconnect) == 1;
		if (!controllerlink.controller0Connected)
		{
			controllerlink.Controller0 = new ControllerHand();
		}
		else
		{
			ResetController(0);
			controllerlink.controllerType = controllerlink.GetControllerType();
			controllerlink.handness = (Pvr_Controller.UserHandNess)controllerlink.getHandness();
		}
		stopConnect = false;
		if (Pvr_ControllerManager.ControllerStatusChangeEvent != null)
		{
			Pvr_ControllerManager.ControllerStatusChangeEvent(isconnect);
		}
		if (Pvr_ControllerManager.PvrControllerStateChangedEvent != null)
		{
			Pvr_ControllerManager.PvrControllerStateChangedEvent(isconnect);
		}
	}

	public void setControllerStateChanged(string state)
	{
		PLOG.I("PvrLog CVControllerStateChanged" + state);
		int num = Convert.ToInt16(state.Substring(0, 1));
		if (num == 0)
		{
			controllerlink.controller0Connected = Convert.ToBoolean(Convert.ToInt16(state.Substring(2, 1)));
			if (!controllerlink.controller0Connected)
			{
				controllerlink.Controller0 = new ControllerHand();
				controllerlink.Controller0.Position = new Vector3(0f, Pvr_UnitySDKSensor.Instance.HeadPose.Position.y, 0f) + new Vector3(-0.1f, -0.3f, 0.3f);
			}
		}
		else
		{
			controllerlink.controller1Connected = Convert.ToBoolean(Convert.ToInt16(state.Substring(2, 1)));
			if (!controllerlink.controller1Connected)
			{
				controllerlink.Controller1 = new ControllerHand();
				controllerlink.Controller1.Position = new Vector3(0f, Pvr_UnitySDKSensor.Instance.HeadPose.Position.y, 0f) + new Vector3(0.1f, -0.3f, 0.3f);
			}
		}
		if (Convert.ToBoolean(Convert.ToInt16(state.Substring(2, 1))))
		{
			controllerlink.controllerType = controllerlink.GetControllerType();
			controllerlink.ResetController(num);
		}
		controllerlink.handness = (Pvr_Controller.UserHandNess)controllerlink.getHandness();
		controllerlink.mainHandID = controllerlink.GetMainControllerIndex();
		if (Pvr_ControllerManager.SetControllerStateChangedEvent != null)
		{
			Pvr_ControllerManager.SetControllerStateChangedEvent(state);
		}
		if (Pvr_ControllerManager.PvrControllerStateChangedEvent != null)
		{
			Pvr_ControllerManager.PvrControllerStateChangedEvent(state);
		}
	}

	public void setControllerAbility(string data)
	{
		PLOG.I("PvrLog setControllerAbility" + data);
		if (Pvr_ControllerManager.SetControllerAbilityEvent != null)
		{
			Pvr_ControllerManager.SetControllerAbilityEvent(data);
		}
	}

	public void controllerThreadStartedCallback()
	{
		PLOG.I("PvrLog ThreadStartSuccess");
		GetCVControllerState();
		if (Pvr_ControllerManager.ControllerThreadStartedCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerThreadStartedCallbackEvent();
		}
		if (Pvr_ControllerManager.PvrServiceStartSuccessEvent != null)
		{
			Pvr_ControllerManager.PvrServiceStartSuccessEvent();
		}
	}

	public void controllerDeviceVersionCallback(string data)
	{
		PLOG.I("PvrLog VersionCallBack" + data);
		if (Pvr_ControllerManager.ControllerDeviceVersionCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerDeviceVersionCallbackEvent(data);
		}
	}

	public void controllerSnCodeCallback(string data)
	{
		PLOG.I("PvrLog SNCodeCallBack" + data);
		if (Pvr_ControllerManager.ControllerSnCodeCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerSnCodeCallbackEvent(data);
		}
	}

	public void controllerUnbindCallback(string status)
	{
		PLOG.I("PvrLog ControllerUnBindCallBack" + status);
		if (Pvr_ControllerManager.ControllerUnbindCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerUnbindCallbackEvent(status);
		}
	}

	public void controllerStationStatusCallback(string status)
	{
		PLOG.I("PvrLog StationStatusCallBack" + status);
		if (Pvr_ControllerManager.ControllerStationStatusCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerStationStatusCallbackEvent(status);
		}
	}

	public void controllerStationBusyCallback(string status)
	{
		PLOG.I("PvrLog StationBusyCallBack" + status);
		if (Pvr_ControllerManager.ControllerStationBusyCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerStationBusyCallbackEvent(status);
		}
	}

	public void controllerOTAStartCodeCallback(string data)
	{
		PLOG.I("PvrLog OTAUpdateCallBack" + data);
		if (Pvr_ControllerManager.ControllerOtaStartCodeCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerOtaStartCodeCallbackEvent(data);
		}
	}

	public void controllerDeviceVersionAndSNCallback(string data)
	{
		PLOG.I("PvrLog DeviceVersionAndSNCallback" + data);
		if (Pvr_ControllerManager.ControllerDeviceVersionAndSNCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerDeviceVersionAndSNCallbackEvent(data);
		}
	}

	public void controllerUniqueIDCallback(string data)
	{
		PLOG.I("PvrLog controllerUniqueIDCallback" + data);
		if (Pvr_ControllerManager.ControllerUniqueIDCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerUniqueIDCallbackEvent(data);
		}
	}

	public void controllerCombinedKeyUnbindCallback(string controllerSerialNum)
	{
		if (Pvr_ControllerManager.ControllerCombinedKeyUnbindCallbackEvent != null)
		{
			Pvr_ControllerManager.ControllerCombinedKeyUnbindCallbackEvent(controllerSerialNum);
		}
	}

	public void setupdateFailed()
	{
	}

	public void setupdateSuccess()
	{
	}

	public void setupdateProgress(string progress)
	{
	}

	public void setHbAutoConnectState(string state)
	{
		PLOG.I("PvrLog HBAutoConnectState" + state);
		controllerServicestate = true;
		if (Convert.ToInt16(state) == 0 && GetControllerConnectionState(0) == 0)
		{
			ShowToast(2);
		}
		if (Convert.ToInt16(state) == 2)
		{
			ShowToast(3);
		}
	}

	public void callbackControllerServiceState(string state)
	{
		PLOG.I("PvrLog HBServiceState" + state);
		controllerServicestate = true;
		if (Convert.ToInt16(state) == 0)
		{
			ShowToast(0);
		}
		if (Convert.ToInt16(state) == 1)
		{
			BindService();
		}
		if (Convert.ToInt16(state) == 2)
		{
			ShowToast(1);
		}
	}

	public void changeMainControllerCallback(string index)
	{
		PLOG.I("PvrLog MainControllerCallBack" + index);
		controllerlink.mainHandID = Convert.ToInt16(index);
		if (Pvr_ControllerManager.ChangeMainControllerCallBackEvent != null)
		{
			Pvr_ControllerManager.ChangeMainControllerCallBackEvent(index);
		}
	}

	public void changeHandnessCallback(string index)
	{
		PLOG.I("PvrLog changeHandnessCallback" + index);
		controllerlink.handness = (Pvr_Controller.UserHandNess)Convert.ToInt16(index);
		if (Pvr_ControllerManager.ChangeHandNessCallBackEvent != null)
		{
			Pvr_ControllerManager.ChangeHandNessCallBackEvent(index);
		}
	}

	private void ShowToast(int type)
	{
		if (toast != null)
		{
			switch (type)
			{
			case 0:
				toast.text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("servicetip0");
				Invoke("HideToast", 5f);
				break;
			case 1:
				toast.text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("servicetip1");
				Invoke("HideToast", 5f);
				break;
			case 2:
				toast.text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("servicetip2");
				AutoConnectHbController(6000);
				Invoke("HideToast", 5f);
				break;
			case 3:
				toast.text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("servicetip3");
				AutoConnectHbController(6000);
				Invoke("HideToast", 5f);
				break;
			case 4:
				toast.text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("servicetip4");
				Invoke("HideToast", 10f);
				break;
			}
		}
	}

	private void HideToast()
	{
		if (toast != null)
		{
			toast.text = "";
		}
	}

	private void CheckControllerService()
	{
		if (!controllerServicestate)
		{
			ShowToast(4);
		}
	}

	private void GetCVControllerState()
	{
		int controllerConnectionState = GetControllerConnectionState(0);
		int controllerConnectionState2 = GetControllerConnectionState(1);
		PLOG.I("PvrLog CVconnect" + controllerConnectionState + controllerConnectionState2);
		if (controllerConnectionState == -1 && controllerConnectionState2 == -1)
		{
			Invoke("GetCVControllerState", 0.02f);
		}
		if (controllerConnectionState != -1 && controllerConnectionState2 != -1)
		{
			controllerlink.controller0Connected = controllerConnectionState == 1;
			controllerlink.controller1Connected = controllerConnectionState2 == 1;
			if (!controllerlink.controller0Connected && controllerlink.controller1Connected && controllerlink.GetMainControllerIndex() == 0)
			{
				Controller.UPvr_SetMainHandNess(1);
			}
			if (controllerlink.controller0Connected || controllerlink.controller1Connected)
			{
				controllerlink.controllerType = controllerlink.GetControllerType();
			}
			controllerlink.mainHandID = controllerlink.GetMainControllerIndex();
			controllerlink.handness = (Pvr_Controller.UserHandNess)controllerlink.getHandness();
		}
	}

	private void SetSystemKey()
	{
		if (controllerlink.switchHomeKey && (Controller.UPvr_GetKeyLongPressed(0, Pvr_KeyCode.HOME) || Controller.UPvr_GetKeyLongPressed(1, Pvr_KeyCode.HOME)))
		{
			if (Pvr_UnitySDKManager.SDK.HmdOnlyrot)
			{
				Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 0);
			}
			else if (controllerlink.trackingmode == 0 || controllerlink.trackingmode == 1)
			{
				Pvr_UnitySDKSensor.Instance.ResetUnitySDKSensor();
			}
			else
			{
				Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 1);
			}
			if (Pvr_UnitySDKManager.SDK.ControllerOnlyrot || (controllerlink.controller0Connected && Controller.UPvr_GetControllerPOS(0).Equals(Vector3.zero)) || (controllerlink.controller1Connected && Controller.UPvr_GetControllerPOS(1).Equals(Vector3.zero)))
			{
				if (Controller.UPvr_GetKeyLongPressed(0, Pvr_KeyCode.HOME))
				{
					ResetController(0);
				}
				if (Controller.UPvr_GetKeyLongPressed(1, Pvr_KeyCode.HOME))
				{
					ResetController(1);
				}
			}
		}
		if (controllerlink.picoDevice)
		{
			if (controllerlink.switchHomeKey && (Controller.UPvr_GetKeyClick(0, Pvr_KeyCode.HOME) || (Controller.UPvr_GetKeyClick(1, Pvr_KeyCode.HOME) && !stopConnect)))
			{
				controllerlink.RebackToLauncher();
			}
			if (Controller.UPvr_GetKeyClick(0, Pvr_KeyCode.VOLUMEUP) || Controller.UPvr_GetKeyClick(1, Pvr_KeyCode.VOLUMEUP))
			{
				controllerlink.TurnUpVolume();
			}
			if (Controller.UPvr_GetKeyClick(0, Pvr_KeyCode.VOLUMEDOWN) || Controller.UPvr_GetKeyClick(1, Pvr_KeyCode.VOLUMEDOWN))
			{
				controllerlink.TurnDownVolume();
			}
			if (!Controller.UPvr_GetKey(0, Pvr_KeyCode.VOLUMEUP) && !Controller.UPvr_GetKey(0, Pvr_KeyCode.VOLUMEDOWN) && !Controller.UPvr_GetKey(1, Pvr_KeyCode.VOLUMEUP) && !Controller.UPvr_GetKey(1, Pvr_KeyCode.VOLUMEDOWN))
			{
				cTime = 1f;
			}
			if (Controller.UPvr_GetKey(0, Pvr_KeyCode.VOLUMEUP) || Controller.UPvr_GetKey(1, Pvr_KeyCode.VOLUMEUP))
			{
				cTime -= Time.deltaTime;
				if (cTime <= 0f)
				{
					cTime = 0.2f;
					controllerlink.TurnUpVolume();
				}
			}
			if (!Controller.UPvr_GetKey(0, Pvr_KeyCode.HOME) && !Controller.UPvr_GetKey(1, Pvr_KeyCode.HOME) && (Controller.UPvr_GetKey(0, Pvr_KeyCode.VOLUMEDOWN) || Controller.UPvr_GetKey(1, Pvr_KeyCode.VOLUMEDOWN)))
			{
				cTime -= Time.deltaTime;
				if (cTime <= 0f)
				{
					cTime = 0.2f;
					controllerlink.TurnDownVolume();
				}
			}
		}
		if (controllerlink.goblinserviceStarted && Controller.UPvr_GetKey(0, Pvr_KeyCode.HOME) && Controller.UPvr_GetKey(0, Pvr_KeyCode.VOLUMEDOWN) && !stopConnect)
		{
			disConnectTime += Time.deltaTime;
			if ((double)disConnectTime > 1.0)
			{
				DisConnectBLE();
				controllerlink.hummingBirdMac = "";
				stopConnect = true;
				disConnectTime = 0f;
			}
		}
	}

	private void TransformData(ControllerHand hand, int handId, int[] data)
	{
		keyOffset = ((handId == 1) ? 67 : 0);
		hand.TouchPadPosition.x = data[keyOffset];
		hand.TouchPadPosition.y = data[5 + keyOffset];
		TransSingleKey(hand.Home, 10 + keyOffset, data);
		TransSingleKey(hand.App, 15 + keyOffset, data);
		TransSingleKey(hand.Touch, 20 + keyOffset, data);
		TransSingleKey(hand.VolumeUp, 25 + keyOffset, data);
		TransSingleKey(hand.VolumeDown, 30 + keyOffset, data);
		TransSingleKey(hand.Trigger, 35 + keyOffset, data);
		if (controllerlink.goblinserviceStarted && !controllerlink.neoserviceStarted)
		{
			hand.TriggerNum = controllerlink.GetHBKeyValue();
		}
		if (!controllerlink.goblinserviceStarted && controllerlink.neoserviceStarted)
		{
			hand.TriggerNum = controllerlink.GetCVTriggerValue(handId);
		}
		hand.Battery = data[40 + keyOffset];
		if (data.Length == 47)
		{
			hand.SwipeDirection = (SwipeDirection)data[45];
			hand.TouchPadClick = (TouchPadClick)data[46];
		}
		else
		{
			switch (handId)
			{
			case 0:
				TransSingleKey(hand.X, 45 + keyOffset, data);
				TransSingleKey(hand.Y, 50 + keyOffset, data);
				TransSingleKey(hand.Left, 60 + keyOffset, data);
				break;
			case 1:
				TransSingleKey(hand.A, 45 + keyOffset, data);
				TransSingleKey(hand.B, 50 + keyOffset, data);
				TransSingleKey(hand.Right, 55 + keyOffset, data);
				break;
			}
			hand.SwipeDirection = (SwipeDirection)data[65 + keyOffset];
			hand.TouchPadClick = (TouchPadClick)data[66 + keyOffset];
		}
		hand.GripValue = controllerlink.GetNeo3GripValue(handId);
		TransformTouchData(hand, handId, controllerlink.GetNeo3TouchData(handId));
	}

	private void TransSingleKey(PvrControllerKey key, int beginIndex, int[] data)
	{
		key.State = Convert.ToBoolean(data[beginIndex]);
		key.PressedDown = Convert.ToBoolean(data[beginIndex + 1]);
		key.PressedUp = Convert.ToBoolean(data[beginIndex + 2]);
		key.LongPressed = Convert.ToBoolean(data[beginIndex + 3]);
		key.Click = Convert.ToBoolean(data[beginIndex + 4]);
	}

	private void TransformTouchData(ControllerHand hand, int handId, int[] data)
	{
		switch (handId)
		{
		case 0:
			TransSingleTouchValue(hand.X, 0, data);
			TransSingleTouchValue(hand.Y, 3, data);
			break;
		case 1:
			TransSingleTouchValue(hand.A, 0, data);
			TransSingleTouchValue(hand.B, 3, data);
			break;
		}
		TransSingleTouchValue(hand.Touch, 6, data);
		TransSingleTouchValue(hand.Trigger, 9, data);
		TransSingleTouchValue(hand.Thumbrest, 12, data);
	}

	private void TransSingleTouchValue(PvrControllerKey key, int beginIndex, int[] data)
	{
		key.Touch = Convert.ToBoolean(data[beginIndex]);
		key.TouchDown = Convert.ToBoolean(data[beginIndex + 1]);
		key.TouchUp = Convert.ToBoolean(data[beginIndex + 2]);
	}
}
public class Pvr_ControllerModuleInit : MonoBehaviour
{
	public ControllerVariety Variety;

	public bool IsCustomModel;

	[SerializeField]
	private GameObject dot;

	[SerializeField]
	private GameObject rayLine;

	[SerializeField]
	private GameObject controller;

	private bool moduleState = true;

	private void Awake()
	{
		Pvr_ControllerManager.PvrServiceStartSuccessEvent += ServiceStartSuccess;
		Pvr_ControllerManager.PvrControllerStateChangedEvent += ControllerStateChanged;
		Pvr_ControllerManager.ChangeMainControllerCallBackEvent += MainControllerIDChanged;
		if (Pvr_ControllerManager.Instance.LengthAdaptiveRay)
		{
			rayLine = base.transform.GetComponentInChildren<LineRenderer>(includeInactive: true).gameObject;
			rayLine.GetComponent<LineRenderer>().startWidth = 0.003f;
			rayLine.GetComponent<LineRenderer>().endWidth = 0.0015f;
		}
	}

	private void OnDestroy()
	{
		Pvr_ControllerManager.PvrServiceStartSuccessEvent -= ServiceStartSuccess;
		Pvr_ControllerManager.PvrControllerStateChangedEvent -= ControllerStateChanged;
		Pvr_ControllerManager.ChangeMainControllerCallBackEvent -= MainControllerIDChanged;
	}

	private void ServiceStartSuccess()
	{
		RefreshRay();
	}

	private void ControllerStateChanged(string data)
	{
		if (Pvr_ControllerManager.controllerlink.controller0Connected || Pvr_ControllerManager.controllerlink.controller1Connected)
		{
			moduleState = true;
			controller.transform.localScale = Vector3.one;
		}
		RefreshRay();
	}

	private void MainControllerIDChanged(string data)
	{
		RefreshRay();
	}

	private void RefreshRay()
	{
		if (Variety == ControllerVariety.Controller0)
		{
			StartCoroutine(ShowOrHideRay(0));
		}
		if (Variety == ControllerVariety.Controller1)
		{
			StartCoroutine(ShowOrHideRay(1));
		}
	}

	private IEnumerator ShowOrHideRay(int id)
	{
		yield return null;
		yield return null;
		if (moduleState)
		{
			bool active = Controller.UPvr_GetMainHandNess() == id && Controller.UPvr_GetControllerState(id) == ControllerState.Connected;
			dot.SetActive(active);
			rayLine.SetActive(active);
		}
	}

	public void ForceHideOrShow(bool state)
	{
		dot.SetActive(state);
		rayLine.SetActive(state);
		controller.transform.localScale = (state ? Vector3.one : Vector3.zero);
		moduleState = state;
	}

	public void UpdateRay()
	{
		if (!Pvr_ControllerManager.Instance.LengthAdaptiveRay)
		{
			return;
		}
		bool flag = false;
		flag = ((Pvr_ControllerManager.controllerlink.controller0Connected || Pvr_ControllerManager.controllerlink.controller1Connected) ? true : false);
		if (flag && rayLine != null && rayLine.gameObject.activeSelf)
		{
			if (Controller.UPvr_GetDeviceType() == 1)
			{
				rayLine.GetComponent<LineRenderer>().SetPosition(0, base.transform.TransformPoint(0f, 0f, 0.058f));
			}
			else
			{
				rayLine.GetComponent<LineRenderer>().SetPosition(0, base.transform.TransformPoint(0f, 0.009f, 0.055f));
			}
			rayLine.GetComponent<LineRenderer>().SetPosition(1, dot.transform.position);
		}
	}
}
public class Pvr_ControllerPower : MonoBehaviour
{
	[SerializeField]
	private Sprite power1;

	[SerializeField]
	private Sprite power2;

	[SerializeField]
	private Sprite power3;

	[SerializeField]
	private Sprite power4;

	[SerializeField]
	private Sprite power5;

	[HideInInspector]
	public ControllerVariety variety;

	[HideInInspector]
	public ControllerDevice currentDevice;

	private Image powerImage;

	private int powerValue;

	private float power;

	private void Start()
	{
		powerImage = base.transform.GetComponent<Image>();
		powerValue = -1;
		variety = base.transform.GetComponentInParent<Pvr_ControllerModuleInit>().Variety;
		currentDevice = base.transform.GetComponentInParent<Pvr_ControllerVisual>().currentDevice;
	}

	private void Update()
	{
		RefreshPower((variety != 0) ? 1 : 0);
	}

	private void RefreshPower(int hand)
	{
		if (powerValue != Controller.UPvr_GetControllerPower(hand))
		{
			switch (Controller.UPvr_GetControllerPower(hand))
			{
			case 1:
				powerImage.sprite = power1;
				powerImage.color = Color.red;
				break;
			case 2:
				powerImage.sprite = power2;
				powerImage.color = Color.white;
				break;
			case 3:
				powerImage.sprite = power3;
				powerImage.color = Color.white;
				break;
			case 4:
				powerImage.sprite = power4;
				powerImage.color = Color.white;
				break;
			case 5:
				powerImage.sprite = power5;
				powerImage.color = Color.white;
				break;
			default:
				powerImage.sprite = power1;
				powerImage.color = Color.white;
				break;
			}
			powerValue = Controller.UPvr_GetControllerPower(hand);
		}
	}
}
public class Pvr_ControllerVisual : MonoBehaviour
{
	public ControllerDevice currentDevice;

	public Texture2D m_idle;

	public Texture2D m_app;

	public Texture2D m_home;

	public Texture2D m_touchpad;

	public Texture2D m_volUp;

	public Texture2D m_volDn;

	public Texture2D m_trigger;

	public Texture2D m_a;

	public Texture2D m_b;

	public Texture2D m_x;

	public Texture2D m_y;

	public Texture2D m_grip;

	private Renderer controllerRenderMat;

	[HideInInspector]
	public ControllerVariety variety;

	private void Awake()
	{
		controllerRenderMat = GetComponent<Renderer>();
	}

	private void Start()
	{
		variety = base.transform.GetComponentInParent<Pvr_ControllerModuleInit>().Variety;
	}

	private void Update()
	{
		ChangeKeyEffects((variety != 0) ? 1 : 0);
	}

	private void ChangeKeyEffects(int hand)
	{
		if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.TOUCHPAD))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_touchpad);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.APP))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_app);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.HOME))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_home);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.VOLUMEUP))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_volUp);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.VOLUMEDOWN))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_volDn);
		}
		else if (Controller.UPvr_GetControllerTriggerValue(hand) > 0 || Controller.UPvr_GetKey(hand, Pvr_KeyCode.TRIGGER))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_trigger);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.X))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_x);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.Y))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_y);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.A))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_a);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.B))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_b);
		}
		else if (Controller.UPvr_GetKey(hand, Pvr_KeyCode.Left) || Controller.UPvr_GetKey(hand, Pvr_KeyCode.Right))
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_grip);
		}
		else if (controllerRenderMat.material.GetTexture("_MainTex") != m_idle)
		{
			controllerRenderMat.material.SetTexture("_MainTex", m_idle);
		}
	}
}
public class Pvr_ToolTips : MonoBehaviour
{
	public enum TipBtn
	{
		app,
		touchpad,
		home,
		volup,
		voldown,
		trigger,
		grip
	}

	private ControllerDevice currentDevice;

	private float tipsAlpha;

	public static Pvr_ToolTips tooltips;

	public void ChangeTipsText(TipBtn tip, string key)
	{
		switch (tip)
		{
		case TipBtn.app:
			base.transform.Find("apptip/btn/Text").GetComponent<Text>().text = key;
			break;
		case TipBtn.touchpad:
			base.transform.Find("touchtip/btn/Text").GetComponent<Text>().text = key;
			break;
		case TipBtn.home:
			base.transform.Find("hometip/btn/Text").GetComponent<Text>().text = key;
			break;
		case TipBtn.volup:
			base.transform.Find("volup/btn/Text").GetComponent<Text>().text = key;
			break;
		case TipBtn.voldown:
			base.transform.Find("voldown/btn/Text").GetComponent<Text>().text = key;
			break;
		case TipBtn.trigger:
			base.transform.Find("triggertip/btn/Text").GetComponent<Text>().text = key;
			break;
		case TipBtn.grip:
			base.transform.Find("grip/btn/Text").GetComponent<Text>().text = key;
			break;
		}
	}

	private void Awake()
	{
		tooltips = base.transform.GetComponent<Pvr_ToolTips>();
	}

	private void Update()
	{
		switch (currentDevice)
		{
		case ControllerDevice.Goblin:
		case ControllerDevice.G2:
			tipsAlpha = (330f - base.transform.parent.parent.parent.localRotation.eulerAngles.x) / 45f;
			if (base.transform.parent.parent.parent.localRotation.eulerAngles.x >= 270f && base.transform.parent.parent.parent.localRotation.eulerAngles.x <= 330f)
			{
				tipsAlpha = Mathf.Max(0f, tipsAlpha);
				tipsAlpha = ((tipsAlpha > 1f) ? 1f : tipsAlpha);
			}
			else
			{
				tipsAlpha = 0f;
			}
			GetComponent<CanvasGroup>().alpha = tipsAlpha;
			break;
		case ControllerDevice.Neo2:
		case ControllerDevice.Neo3:
			tipsAlpha = (330f - base.transform.parent.parent.parent.localRotation.eulerAngles.x) / 45f;
			if (base.transform.parent.parent.parent.localRotation.eulerAngles.x >= 270f && base.transform.parent.parent.parent.localRotation.eulerAngles.x <= 330f)
			{
				tipsAlpha = Mathf.Max(0f, tipsAlpha);
				tipsAlpha = ((tipsAlpha > 1f) ? 1f : tipsAlpha);
			}
			else
			{
				tipsAlpha = 0f;
			}
			GetComponent<CanvasGroup>().alpha = tipsAlpha;
			break;
		case ControllerDevice.Neo:
			break;
		}
	}

	private void LoadTextFromJson()
	{
		currentDevice = base.transform.GetComponentInParent<Pvr_ControllerVisual>().currentDevice;
		base.transform.Find("apptip/btn/Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("apptip");
		base.transform.Find("touchtip/btn/Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("touchtip");
		base.transform.Find("hometip/btn/Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("hometip");
		Transform transform = base.transform.Find("volup/btn/Text");
		if (transform != null)
		{
			transform.GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("voluptip");
		}
		Transform transform2 = base.transform.Find("voldown/btn/Text");
		if (transform2 != null)
		{
			transform2.GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("voldowntip");
		}
		Transform transform3 = base.transform.Find("triggertip/btn/Text");
		if (transform3 != null)
		{
			transform3.GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("triggertip");
		}
		Transform transform4 = base.transform.Find("grip/btn/Text");
		if (transform4 != null)
		{
			transform4.GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("griptip");
		}
	}

	public static void RefreshTips()
	{
		if (tooltips != null)
		{
			tooltips.LoadTextFromJson();
		}
	}
}
public class Pvr_TouchPadScroll : MonoBehaviour
{
	private ScrollRect scrollRect;

	private bool isHoving;

	private int mainHand;

	private SwipeDirection direction;

	private Vector2 currPos;

	private Vector2 tarPos;

	private float lerpSpeed = 10f;

	private Transform tranViewport;

	private float ignoreDis = 3f;

	private Vector2 lastTouchDownPos;

	private Vector2 lastTouchUpPos;

	private bool isTouching;

	private bool isClosed = true;

	private Vector2 vecOrigin = Vector2.zero;

	private Vector2 vecOriginNeo2 = new Vector2(128f, 128f);

	private void Awake()
	{
		scrollRect = base.gameObject.GetComponent<ScrollRect>();
		tranViewport = base.transform.Find("Viewport");
	}

	private void Update()
	{
		Process();
		UpdateTargetPos();
		UpdatePos();
	}

	private bool IsControllerConnect()
	{
		mainHand = Controller.UPvr_GetMainHandNess();
		if (mainHand == 0 && Pvr_ControllerManager.controllerlink.controller0Connected)
		{
			return true;
		}
		if (mainHand == 1 && Pvr_ControllerManager.controllerlink.controller1Connected)
		{
			return true;
		}
		return false;
	}

	private void UpdateTargetPos()
	{
		if (Controller.UPvr_GetKey(0, Pvr_KeyCode.TOUCHPAD) || Controller.UPvr_GetKeyDown(1, Pvr_KeyCode.TOUCHPAD))
		{
			ResetParameter();
		}
		else if (isHoving)
		{
			if (Pvr_ControllerManager.controllerlink.GetControllerType() == 3)
			{
				ComputeTouchPos();
			}
			else
			{
				ComputeRockerPos();
			}
			if ((currPos - tarPos).sqrMagnitude <= 10f)
			{
				isClosed = true;
			}
		}
	}

	private void ComputeTouchPos()
	{
		mainHand = Controller.UPvr_GetMainHandNess();
		currPos = scrollRect.content.localPosition;
		Vector2 vector = vecOrigin;
		if (mainHand == 0 && Pvr_ControllerManager.controllerlink.controller0Connected)
		{
			vector = Controller.UPvr_GetTouchPadPosition(mainHand);
		}
		if (mainHand == 1 && Pvr_ControllerManager.controllerlink.controller1Connected)
		{
			vector = Controller.UPvr_GetTouchPadPosition(mainHand);
		}
		if ((vector - vecOrigin).sqrMagnitude >= 1f)
		{
			if (!isTouching)
			{
				lastTouchDownPos = vector;
				isTouching = true;
			}
			lastTouchUpPos.x = vector.x;
			if (Mathf.Abs(lastTouchUpPos.x - lastTouchDownPos.x) > ignoreDis)
			{
				Vector2 vector2 = new Vector2((lastTouchUpPos.x - lastTouchDownPos.x) * 10f, 0f);
				lastTouchDownPos.x = lastTouchUpPos.x;
				if (isClosed)
				{
					tarPos = currPos + vector2;
					isClosed = false;
				}
				else
				{
					tarPos += vector2;
				}
			}
		}
		else
		{
			lastTouchDownPos = vecOrigin;
			lastTouchUpPos = vecOrigin;
			isTouching = false;
			if ((double)scrollRect.horizontalScrollbar.value >= 0.999 || (double)scrollRect.horizontalScrollbar.value <= 0.0001)
			{
				isClosed = true;
			}
		}
	}

	private void ComputeRockerPos()
	{
		mainHand = Controller.UPvr_GetMainHandNess();
		currPos = scrollRect.content.localPosition;
		Vector2 vector = vecOriginNeo2;
		if (mainHand == 0 && Pvr_ControllerManager.controllerlink.controller0Connected)
		{
			vector = Controller.UPvr_GetTouchPadPosition(mainHand);
		}
		if (mainHand == 1 && Pvr_ControllerManager.controllerlink.controller1Connected)
		{
			vector = Controller.UPvr_GetTouchPadPosition(mainHand);
		}
		if (VerifyNeo2TouchValid(vector) && (vector - vecOriginNeo2).sqrMagnitude >= 1f)
		{
			if (!isTouching)
			{
				lastTouchDownPos = vector;
				isTouching = true;
			}
			lastTouchUpPos.x = vector.x;
			if (Mathf.Abs(lastTouchUpPos.x - lastTouchDownPos.x) > ignoreDis)
			{
				Vector2 vector2 = new Vector2((lastTouchUpPos.x - lastTouchDownPos.x) * 10f, 0f);
				lastTouchDownPos.x = lastTouchUpPos.x;
				if (isClosed)
				{
					tarPos = currPos + vector2;
					isClosed = false;
				}
				else
				{
					tarPos += vector2;
				}
			}
		}
		else
		{
			lastTouchDownPos = vecOriginNeo2;
			lastTouchUpPos = vecOriginNeo2;
			isTouching = false;
			if ((double)scrollRect.horizontalScrollbar.value >= 0.999 || (double)scrollRect.horizontalScrollbar.value <= 0.0001)
			{
				isClosed = true;
			}
		}
	}

	private bool VerifyNeo2TouchValid(Vector2 nowTouchPos)
	{
		if (nowTouchPos.x > vecOriginNeo2.x && nowTouchPos.x > lastTouchDownPos.x)
		{
			return true;
		}
		if (nowTouchPos.x < vecOriginNeo2.x && nowTouchPos.x < lastTouchDownPos.x)
		{
			return true;
		}
		return false;
	}

	private void UpdatePos()
	{
		if (Controller.UPvr_GetKey(0, Pvr_KeyCode.TOUCHPAD) || Controller.UPvr_GetKeyDown(1, Pvr_KeyCode.TOUCHPAD))
		{
			ResetParameter();
		}
		else if (!isClosed && IsControllerConnect())
		{
			if ((double)scrollRect.horizontalScrollbar.value >= 0.9999 && tarPos.x <= currPos.x)
			{
				isClosed = true;
				return;
			}
			if ((double)scrollRect.horizontalScrollbar.value <= 0.0001 && tarPos.x >= currPos.x)
			{
				isClosed = true;
				return;
			}
			currPos.x = Mathf.Lerp(currPos.x, tarPos.x, lerpSpeed * Time.deltaTime);
			currPos.y = Mathf.Lerp(currPos.y, tarPos.y, lerpSpeed * Time.deltaTime);
			scrollRect.content.localPosition = currPos;
		}
	}

	private void ResetParameter()
	{
		currPos = scrollRect.content.localPosition;
		tarPos = scrollRect.content.localPosition;
		isClosed = true;
	}

	private void Process()
	{
		for (int i = 0; i < Pvr_InputModule.pointers.Count; i++)
		{
			Pvr_UIPointer pvr_UIPointer = Pvr_InputModule.pointers[i];
			if (pvr_UIPointer.gameObject.activeInHierarchy && pvr_UIPointer.enabled)
			{
				isHoving = IsHovering(pvr_UIPointer);
			}
		}
	}

	private bool IsHovering(Pvr_UIPointer pointer)
	{
		if (!IsControllerConnect())
		{
			return false;
		}
		foreach (GameObject item in pointer.pointerEventData.hovered)
		{
			if (FindTree(item.transform))
			{
				mainHand = Controller.UPvr_GetMainHandNess();
				if (mainHand == 0 && Pvr_ControllerManager.controllerlink.controller0Connected)
				{
					return true;
				}
				if (mainHand == 1 && Pvr_ControllerManager.controllerlink.controller1Connected)
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool FindTree(Transform tran)
	{
		if (tran == base.transform || tran == tranViewport)
		{
			return true;
		}
		if (tran.IsChildOf(tranViewport))
		{
			return true;
		}
		return false;
	}
}
public class Pvr_TouchVisual : MonoBehaviour
{
	[HideInInspector]
	public ControllerDevice currentDevice;

	[HideInInspector]
	public ControllerVariety variety;

	private MeshRenderer touchRenderer;

	private void Start()
	{
		variety = base.transform.GetComponentInParent<Pvr_ControllerModuleInit>().Variety;
		currentDevice = GetComponentInParent<Pvr_ControllerVisual>().currentDevice;
		touchRenderer = GetComponent<MeshRenderer>();
	}

	private void Update()
	{
		ChangeEffects((variety != 0) ? 1 : 0);
	}

	private void ChangeEffects(int hand)
	{
		ControllerDevice controllerDevice = currentDevice;
		if (controllerDevice == ControllerDevice.G2)
		{
			if (Controller.UPvr_IsTouching(0))
			{
				touchRenderer.enabled = true;
				base.transform.localPosition = new Vector3(1.3f - Controller.UPvr_GetTouchPadPosition(hand).x * 0.01f, 1.6f, -1.7f - Controller.UPvr_GetTouchPadPosition(hand).y * 0.01f);
			}
			else
			{
				touchRenderer.enabled = false;
			}
		}
	}
}
public class DemoController : MonoBehaviour
{
	public delegate void showLoadingEventHandler();

	private Callback callback;

	private GameObject msg;

	private Pvr_UnitySDKManager picoVrManager;

	private string currentOrderID;

	public GameObject loading;

	public GameObject BG;

	public GameObject InputPanel;

	public static showLoadingEventHandler showLoading;

	private void Awake()
	{
		UnityEngine.Debug.Log(loading.name);
		UnityEngine.Debug.Log(BG.name);
		showLoading = (showLoadingEventHandler)Delegate.Combine(showLoading, new showLoadingEventHandler(StopLoading));
		InputManager.doEnter = (InputManager.doEnterEventHandler)Delegate.Combine(InputManager.doEnter, new InputManager.doEnterEventHandler(DoPayByCode));
		currentOrderID = "";
	}

	private void Start()
	{
		msg = GameObject.Find("MassageInfo");
		InitDelegate();
		callback = new Callback();
		picoVrManager = GameObject.Find("Pvr_UnitySDK").GetComponent<Pvr_UnitySDKManager>();
		InputPanel.SetActive(value: false);
	}

	private void Update()
	{
		if (picoVrManager != null && (Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.Joystick1Button2)))
		{
			UnityEngine.Debug.Log("update");
			Pvr_UnitySDKSensor.Instance.ResetUnitySDKSensor();
		}
		if (Input.GetKeyDown(KeyCode.Joystick1Button1) || Input.GetKeyDown(KeyCode.Escape))
		{
			if (InputPanel.activeInHierarchy)
			{
				InputPanel.SetActive(value: false);
			}
			else
			{
				Application.Quit();
			}
		}
	}

	private void InitDelegate()
	{
		foreach (string item in new ArrayList { "Login", "GetUserAPI", "PayOne", "PayCode", "QueryOrder" })
		{
			GameObject btnObj = GameObject.Find(item);
			btnObj.GetComponent<Button>().onClick.AddListener(delegate
			{
				OnClick(btnObj);
			});
		}
	}

	private void OnClick(GameObject btnObj)
	{
		switch (btnObj.name)
		{
		case "Login":
			StartLoading();
			LoginSDK.Login();
			break;
		case "PayOne":
			CommonDic.getInstance().setParameters("subject", "game");
			CommonDic.getInstance().setParameters("body", "gamePay");
			CommonDic.getInstance().setParameters("order_id", getRamdomTestOrderID());
			CommonDic.getInstance().setParameters("total", "1");
			CommonDic.getInstance().setParameters("goods_tag", "game");
			CommonDic.getInstance().setParameters("notify_url", "www.picovr.com");
			CommonDic.getInstance().setParameters("pay_code", "");
			StartLoading();
			PicoPaymentSDK.Pay(CommonDic.getInstance().PayOrderString());
			break;
		case "PayCode":
			InputPanel.SetActive(value: true);
			break;
		case "QueryOrder":
			StartLoading();
			PicoPaymentSDK.QueryOrder(currentOrderID);
			break;
		case "GetUserAPI":
			StartLoading();
			LoginSDK.GetUserAPI();
			break;
		}
	}

	public string getRamdomTestOrderID()
	{
		currentOrderID = (UnityEngine.Random.value * 65535f).ToString();
		return currentOrderID;
	}

	private void StartLoading()
	{
		loading.SetActive(value: true);
		BG.SetActive(value: true);
	}

	public void StopLoading()
	{
		if ((bool)loading && (bool)BG)
		{
			loading.SetActive(value: false);
			BG.SetActive(value: false);
		}
		else
		{
			UnityEngine.Debug.LogError("用户自定义，非演示demo");
		}
	}

	public void DoPayByCode()
	{
		CommonDic.getInstance().setParameters("subject", "game");
		CommonDic.getInstance().setParameters("body", "gamePay");
		CommonDic.getInstance().setParameters("order_id", getRamdomTestOrderID());
		CommonDic.getInstance().setParameters("total", "0");
		CommonDic.getInstance().setParameters("goods_tag", "game");
		CommonDic.getInstance().setParameters("notify_url", "www.picovr.com");
		CommonDic.getInstance().setParameters("pay_code", GameObject.Find("CodeText").GetComponent<Text>().text);
		UnityEngine.Debug.Log("商品码支付" + GameObject.Find("CodeText").GetComponent<Text>().text);
		StartLoading();
		GameObject.Find("CodeText").GetComponent<Text>().text = "";
		InputPanel.SetActive(value: false);
		PicoPaymentSDK.Pay(CommonDic.getInstance().PayOrderString());
	}

	private bool VerifyLocalToken()
	{
		if (CommonDic.getInstance().access_token.Equals(""))
		{
			GameObject.Find("MassageInfo").GetComponent<Text>().text = "{code:exception,msg:请先登录}";
			currentOrderID = "";
			StopLoading();
			return false;
		}
		return true;
	}
}
public class LoadingRatation : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
		base.gameObject.transform.Rotate(new Vector3(0f, 0f, -4f));
	}
}
public class InputManager : MonoBehaviour
{
	public delegate void doEnterEventHandler();

	public static doEnterEventHandler doEnter;

	private StringBuilder sb = new StringBuilder();

	private ArrayList btnsName = new ArrayList();

	private GameObject enter;

	private void Awake()
	{
		InitKeyBoard();
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void InitKeyBoard()
	{
		btnsName.Add("1");
		btnsName.Add("2");
		btnsName.Add("3");
		btnsName.Add("4");
		btnsName.Add("5");
		btnsName.Add("6");
		btnsName.Add("7");
		btnsName.Add("8");
		btnsName.Add("9");
		btnsName.Add("0");
		btnsName.Add("Q");
		btnsName.Add("W");
		btnsName.Add("E");
		btnsName.Add("R");
		btnsName.Add("T");
		btnsName.Add("Y");
		btnsName.Add("U");
		btnsName.Add("I");
		btnsName.Add("O");
		btnsName.Add("P");
		btnsName.Add("A");
		btnsName.Add("S");
		btnsName.Add("D");
		btnsName.Add("F");
		btnsName.Add("G");
		btnsName.Add("H");
		btnsName.Add("J");
		btnsName.Add("K");
		btnsName.Add("L");
		btnsName.Add("Z");
		btnsName.Add("X");
		btnsName.Add("C");
		btnsName.Add("V");
		btnsName.Add("B");
		btnsName.Add("N");
		btnsName.Add("M");
		btnsName.Add("Clear");
		btnsName.Add("Capslock");
		btnsName.Add("Enter");
		foreach (string item in btnsName)
		{
			GameObject btnObj = GameObject.Find(item);
			btnObj.GetComponent<Button>().onClick.AddListener(delegate
			{
				OnClick(btnObj);
			});
		}
		enter = GameObject.Find("Enter");
		enter.SetActive(sb.Length > 0);
	}

	private void OnClick(GameObject btnObj)
	{
		if (btnObj.name.Equals("Capslock"))
		{
			if (GameObject.Find("Q").transform.GetChild(0).GetComponent<Text>().text.Equals("Q"))
			{
				DoCapslock(IsUpper: true);
			}
			else
			{
				DoCapslock(IsUpper: false);
			}
		}
		else if (btnObj.name.Equals("Clear"))
		{
			GameObject.Find("CodeText").GetComponent<Text>().text = "";
			ClearBuffer();
		}
		else if (btnObj.name.Equals("Enter"))
		{
			ClearBuffer();
			doEnter();
		}
		else
		{
			EnterChar(btnObj.transform.GetChild(0).GetComponent<Text>().text);
		}
	}

	private void EnterChar(string s)
	{
		sb.Append(s);
		GameObject.Find("CodeText").GetComponent<Text>().text = sb.ToString();
		enter.SetActive(sb.Length > 0);
	}

	private void DoCapslock(bool IsUpper)
	{
		if (IsUpper)
		{
			foreach (string item in btnsName)
			{
				Text component = GameObject.Find(item).transform.GetChild(0).GetComponent<Text>();
				component.text = component.text.ToLower();
			}
			return;
		}
		foreach (string item2 in btnsName)
		{
			Text component2 = GameObject.Find(item2).transform.GetChild(0).GetComponent<Text>();
			component2.text = component2.text.ToUpper();
		}
	}

	private void ClearBuffer()
	{
		sb.Remove(0, sb.Length);
		enter.SetActive(sb.Length > 0);
	}
}
public class Callback : MonoBehaviour
{
	private static string IS_SUCCESS = "isSuccess";

	private static string MSG = "msg";

	private static string CODE = "code";

	public void LoginCallback(string LoginInfo)
	{
		JsonData jsonData = JsonMapper.ToObject(LoginInfo);
		SetMassage(LoginInfo);
		DemoController.showLoading();
		if (jsonData[IS_SUCCESS] != null)
		{
			CommonDic.getInstance().isSuccess = jsonData[IS_SUCCESS].ToString();
		}
		if (jsonData[MSG] != null)
		{
			CommonDic.getInstance().loginMsg = jsonData[MSG].ToString();
		}
		UnityEngine.Debug.Log("调用login回调:" + LoginInfo);
	}

	public void QueryOrPayCallback(string queryOrPayInfo)
	{
		JsonData jsonData = JsonMapper.ToObject(queryOrPayInfo);
		if (jsonData[CODE] != null)
		{
			CommonDic.getInstance().code = jsonData["code"].ToString();
		}
		if (jsonData[MSG] != null)
		{
			CommonDic.getInstance().msg = jsonData["msg"].ToString();
		}
		if (jsonData != null)
		{
			CommonDic.getInstance().order_info = jsonData[1].ToString();
		}
		SetMassage(queryOrPayInfo);
		DemoController.showLoading();
		UnityEngine.Debug.Log("调用pay回调:" + queryOrPayInfo);
	}

	public void UserInfoCallback(string userInfo)
	{
		CommonDic.getInstance().user_info = userInfo;
		SetMassage(userInfo);
		DemoController.showLoading();
		UnityEngine.Debug.Log("调用userInfo回调:" + userInfo);
	}

	public void SetMassage(string massage)
	{
		if (!GetCurrentGameObject().Equals(null))
		{
			GetCurrentGameObject().GetComponent<Text>().text = massage;
		}
		else
		{
			UnityEngine.Debug.LogError("无接收该Message的控件");
		}
	}

	public GameObject GetCurrentGameObject()
	{
		return GameObject.Find("MassageInfo");
	}

	public void ActivityForResultCallback(string activity)
	{
		PicoPaymentSDK.jo.Call("authCallback", activity);
	}
}
public class CommonDic
{
	private static CommonDic dic;

	private static Dictionary<string, string> mydic;

	private string _app_ID;

	private string _app_Key;

	private string _user_token;

	private string _access_token = "";

	private string _open_id;

	private string _refresh_token;

	private string _expires_in;

	private string _user_info;

	private string _subject;

	private string _body;

	private string _order_id;

	private string _total;

	private string _goods_tag;

	private string _notify_url;

	private string _trade_type;

	private string _pay_code = "";

	private string _order_info;

	private string _code;

	private string _msg = "null";

	private string _merchant_ID;

	private string _payKey;

	private string _isSuucess;

	private string _loginMsg;

	public string subject
	{
		get
		{
			return _subject;
		}
		set
		{
			_subject = value;
		}
	}

	public string body
	{
		get
		{
			return _body;
		}
		set
		{
			_body = value;
		}
	}

	public string order_id
	{
		get
		{
			return _order_id;
		}
		set
		{
			_order_id = value;
		}
	}

	public string total
	{
		get
		{
			return _total;
		}
		set
		{
			_total = value;
		}
	}

	public string goods_tag
	{
		get
		{
			return _goods_tag;
		}
		set
		{
			_goods_tag = value;
		}
	}

	public string notify_url
	{
		get
		{
			return _notify_url;
		}
		set
		{
			_notify_url = value;
		}
	}

	public string pay_code
	{
		get
		{
			return _pay_code;
		}
		set
		{
			_pay_code = value;
		}
	}

	public string trade_type
	{
		get
		{
			return _trade_type;
		}
		set
		{
			_trade_type = value;
		}
	}

	public string user_token
	{
		get
		{
			return _user_token;
		}
		set
		{
			_user_token = value;
		}
	}

	public string access_token
	{
		get
		{
			return _access_token;
		}
		set
		{
			_access_token = value;
		}
	}

	public string open_id
	{
		get
		{
			return _open_id;
		}
		set
		{
			_open_id = value;
		}
	}

	public string refresh_token
	{
		get
		{
			return _refresh_token;
		}
		set
		{
			_refresh_token = value;
		}
	}

	public string expires_in
	{
		get
		{
			return _expires_in;
		}
		set
		{
			_expires_in = value;
		}
	}

	public string isSuccess
	{
		get
		{
			return _isSuucess;
		}
		set
		{
			_isSuucess = value;
		}
	}

	public string loginMsg
	{
		get
		{
			return _loginMsg;
		}
		set
		{
			_loginMsg = value;
		}
	}

	public string user_info
	{
		get
		{
			return _user_info;
		}
		set
		{
			_user_info = value;
		}
	}

	public string order_info
	{
		get
		{
			return _order_info;
		}
		set
		{
			_order_info = value;
		}
	}

	public string code
	{
		get
		{
			return _code;
		}
		set
		{
			_code = value;
		}
	}

	public string msg
	{
		get
		{
			return _msg;
		}
		set
		{
			_msg = value;
		}
	}

	public string app_ID
	{
		get
		{
			return _app_ID;
		}
		set
		{
			_app_ID = value;
		}
	}

	public string app_Key
	{
		get
		{
			return _app_Key;
		}
		set
		{
			_app_Key = value;
		}
	}

	public string merchant_ID
	{
		get
		{
			return _merchant_ID;
		}
		set
		{
			_merchant_ID = value;
		}
	}

	public string paykey
	{
		get
		{
			return _payKey;
		}
		set
		{
			_payKey = value;
		}
	}

	public static CommonDic getInstance()
	{
		if (dic == null)
		{
			dic = new CommonDic();
		}
		if (mydic == null)
		{
			mydic = new Dictionary<string, string>();
			InitDicData(mydic);
		}
		return dic;
	}

	public Dictionary<string, string> getDic()
	{
		return mydic;
	}

	public void setParameters(string name, string value)
	{
		if (name.Equals("subject"))
		{
			subject = value;
		}
		if (name.Equals("body"))
		{
			body = value;
		}
		if (name.Equals("order_id"))
		{
			order_id = value;
		}
		if (name.Equals("total"))
		{
			total = value;
		}
		if (name.Equals("goods_tag"))
		{
			goods_tag = value;
		}
		if (name.Equals("notify_url"))
		{
			notify_url = value;
		}
		if (name.Equals("trade_type"))
		{
			trade_type = value;
		}
		if (name.Equals("pay_code"))
		{
			pay_code = value;
		}
	}

	public string PayOrderString()
	{
		return JsonMapper.ToJson(getInstance());
	}

	public static void InitDicData(Dictionary<string, string> mydic)
	{
		mydic.Add("00000", "网络异常");
		mydic.Add("10000", "登录成功");
		mydic.Add("10001", "用户未登陆");
		mydic.Add("10002", "请输入正确金额");
		mydic.Add("10003", "登陆过期，请重新登陆");
		mydic.Add("11000", "商户验证成功");
		mydic.Add("11001", "商户验证失败");
		mydic.Add("11002", "用户验证参数错误或请求过期");
		mydic.Add("11003", "商户未验证");
		mydic.Add("12000", "支付成功");
		mydic.Add("12001", "支付失败");
		mydic.Add("12003", "P币不足");
		mydic.Add("12004", "余额可用");
		mydic.Add("13000", "生成订单");
		mydic.Add("13001", "获取数据失败");
		mydic.Add("13002", "生成订单失败");
		mydic.Add("14000", "查询订单成功");
		mydic.Add("14001", "订单不存在/有误");
		mydic.Add("14002", "用户取消支付操作");
		mydic.Add("15000", "未输入商品信息");
		mydic.Add("15001", "未输入预付ID");
		mydic.Add("15002", "请输入Pico支付订单号或商户订单号");
		mydic.Add("NOAUTH", "商户无此接口权限");
		mydic.Add("SYSTEMERROR", "系统错误");
		mydic.Add("APP_ID_NOT_EXIST", "APP_ID不存在");
		mydic.Add("MCHID_NOT_EXIST", "MCHID不存在");
		mydic.Add("APP_ID_MCHID_NOT_MATCH", "app_id和mch_id不匹配ID");
		mydic.Add("LACK_PARAMS", "缺少参数");
		mydic.Add("SIGNERROR", "签名错误");
		mydic.Add("NO_DATA", "没有查询到数据");
	}
}
public class LoginSDK
{
	public static void Login()
	{
		PicoPaymentSDK.Login();
	}

	public static void GetUserAPI()
	{
		PicoPaymentSDK.GetUserAPI();
	}
}
public class PicoPaymentSDK
{
	private static AndroidJavaObject _jo = new AndroidJavaObject("com.pico.loginpaysdk.UnityInterface");

	public static AndroidJavaObject jo
	{
		get
		{
			return _jo;
		}
		set
		{
			_jo = value;
		}
	}

	public static void Login()
	{
		AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		jo.Call("init", @static);
		jo.Call("authSSO");
	}

	public static void Pay(string payOrderJson)
	{
		AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		jo.Call("init", @static);
		jo.Call("pay", payOrderJson);
	}

	public static void QueryOrder(string orderId)
	{
		AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		jo.Call("init", @static);
		jo.Call("queryOrder", orderId);
	}

	public static void GetUserAPI()
	{
		AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		jo.Call("init", @static);
		jo.Call("getUserAPI");
	}
}
public class Pvr_ToBService : MonoBehaviour
{
	public Text deviceInfoText;

	private void Awake()
	{
		InitToBService();
	}

	private void Start()
	{
		BindToBService();
	}

	private void OnDestory()
	{
		UnBindToBService();
	}

	private void InitToBService()
	{
		ToBService.UPvr_InitToBService();
		ToBService.UPvr_SetUnityObjectName(base.name);
	}

	private void BindToBService()
	{
		ToBService.UPvr_BindToBService();
	}

	private void UnBindToBService()
	{
		ToBService.UPvr_UnBindToBService();
	}

	private void BoolCallback(string value)
	{
		if (ToBService.BoolCallback != null)
		{
			ToBService.BoolCallback(bool.Parse(value));
		}
		ToBService.BoolCallback = null;
	}

	private void IntCallback(string value)
	{
		if (ToBService.IntCallback != null)
		{
			ToBService.IntCallback(int.Parse(value));
		}
		ToBService.IntCallback = null;
	}

	private void LongCallback(string value)
	{
		if (ToBService.LongCallback != null)
		{
			ToBService.LongCallback(int.Parse(value));
		}
		ToBService.LongCallback = null;
	}

	private void StringCallback(string value)
	{
		if (ToBService.StringCallback != null)
		{
			ToBService.StringCallback(value);
		}
		ToBService.StringCallback = null;
	}

	public void StateGetDeviceInfo()
	{
		string text = ToBService.UPvr_StateGetDeviceInfo(PBS_SystemInfoEnum.PUI_VERSION);
		deviceInfoText.text = "PUI_VERSION:" + text;
	}

	public void ControlSetDeviceAction()
	{
		ToBService.UPvr_ControlSetDeviceAction(PBS_DeviceControlEnum.DEVICE_CONTROL_SHUTDOWN, ControlSetDeviceActionCallBack);
	}

	private void ControlSetDeviceActionCallBack(int value)
	{
		UnityEngine.Debug.Log("ControlSetDeviceActionCallBack : " + value);
	}

	public void AppManager()
	{
		ToBService.UPvr_ControlAPPManger(PBS_PackageControlEnum.PACKAGE_SILENCE_UNINSTALL, "com.pico.ipd.test", AppManagerCallBack);
	}

	private void AppManagerCallBack(int value)
	{
		UnityEngine.Debug.Log("AppManagerCallBack : " + value);
	}
}
public class PLOG : MonoBehaviour
{
	public static int logLevel;

	public static void getConfigTraceLevel()
	{
		Render.UPvr_GetIntConfig(6, ref logLevel);
	}

	public static void D(string msg)
	{
		if (logLevel > 2)
		{
			UnityEngine.Debug.Log(msg);
		}
	}

	public static void I(string msg)
	{
		if (logLevel > 1)
		{
			UnityEngine.Debug.Log(msg);
		}
	}

	public static void W(string msg)
	{
		if (logLevel > 0)
		{
			UnityEngine.Debug.LogWarning(msg);
		}
	}

	public static void E(string msg)
	{
		UnityEngine.Debug.LogError(msg);
	}
}
public class PicoDevice : MonoBehaviour
{
	public enum DeviceType
	{
		HMD,
		LeftController,
		RightController
	}

	public DeviceType deviceType;

	private Vector3 devicePos;

	private Quaternion deviceRot;

	private void Awake()
	{
		if (deviceType == DeviceType.HMD)
		{
			base.gameObject.AddComponent<Camera>();
			GameObject obj = new GameObject();
			obj.name = "LeftEye";
			obj.transform.parent = base.transform;
			obj.AddComponent<Pvr_UnitySDKEye>().eyeSide = Eye.LeftEye;
			GameObject obj2 = new GameObject();
			obj2.name = "RightEye";
			obj2.transform.parent = base.transform;
			obj2.AddComponent<Pvr_UnitySDKEye>().eyeSide = Eye.RightEye;
			GameObject obj3 = new GameObject();
			obj3.name = "BothEye";
			obj3.transform.parent = base.transform;
			obj3.AddComponent<Pvr_UnitySDKEye>().eyeSide = Eye.BothEye;
			base.gameObject.AddComponent<Pvr_UnitySDKEyeManager>();
		}
	}

	private void Update()
	{
		switch (deviceType)
		{
		case DeviceType.HMD:
			devicePos = Pvr_UnitySDKSensor.Instance.HeadPose.Position;
			deviceRot = Pvr_UnitySDKSensor.Instance.HeadPose.Orientation;
			break;
		case DeviceType.LeftController:
			devicePos = Pvr_ControllerManager.controllerlink.Controller0.Position;
			deviceRot = Pvr_ControllerManager.controllerlink.Controller0.Rotation;
			break;
		case DeviceType.RightController:
			devicePos = Pvr_ControllerManager.controllerlink.Controller1.Position;
			deviceRot = Pvr_ControllerManager.controllerlink.Controller1.Rotation;
			break;
		}
		base.transform.localPosition = devicePos;
		base.transform.localRotation = deviceRot;
	}
}
public class CPicoSDKSettingAsset : ScriptableObject
{
	public bool IgnoreSDKSetting;

	public bool DontshowBuildWaring;

	public bool AppIDChecked;
}
[Serializable]
public class Pvr_UnitySDKProjectSetting : ScriptableObject
{
	public RenderTextureAntiAliasing rtAntiAlising;

	public RenderTextureDepth rtBitDepth;

	public RenderTextureFormat rtFormat;

	public bool usedefaultRenderTexture;

	public Vector2 customRTSize;

	public bool usedefaultfps;

	public int customfps;

	public bool usesinglepass;

	public bool usecontentprotect;

	public static Pvr_UnitySDKProjectSetting GetProjectConfig()
	{
		return Resources.Load<Pvr_UnitySDKProjectSetting>("ProjectSetting");
	}
}
public sealed class Pvr_UnitySDKPlatformSetting : ScriptableObject
{
	public enum simulationType
	{
		Null,
		Invalid,
		Valid
	}

	[SerializeField]
	private bool entitlementchecksimulation;

	[SerializeField]
	private bool startTimeEntitlementCheck;

	[SerializeField]
	public string appID;

	public List<string> deviceSN = new List<string>();

	private static Pvr_UnitySDKPlatformSetting instance;

	public static bool Entitlementchecksimulation
	{
		get
		{
			return Instance.entitlementchecksimulation;
		}
		set
		{
			if (Instance.entitlementchecksimulation != value)
			{
				Instance.entitlementchecksimulation = value;
			}
		}
	}

	public static bool StartTimeEntitlementCheck
	{
		get
		{
			return Instance.startTimeEntitlementCheck;
		}
		set
		{
			if (Instance.startTimeEntitlementCheck != value)
			{
				Instance.startTimeEntitlementCheck = value;
			}
		}
	}

	public static Pvr_UnitySDKPlatformSetting Instance
	{
		get
		{
			if (instance == null)
			{
				instance = Resources.Load<Pvr_UnitySDKPlatformSetting>("PlatformSettings");
			}
			return instance;
		}
		set
		{
			instance = value;
		}
	}
}
public class Pvr_UnitySDKManager : MonoBehaviour
{
	public delegate void EntitlementCheckResult(int ReturnValue);

	public static PlatForm platform;

	private static Pvr_UnitySDKManager sdk;

	[HideInInspector]
	public float EyesAspect = 1f;

	[HideInInspector]
	public int posStatus;

	[HideInInspector]
	public bool ismirroring;

	[HideInInspector]
	public Vector3 resetBasePos;

	[HideInInspector]
	public int trackingmode = -1;

	[HideInInspector]
	public int systemprop = -1;

	[HideInInspector]
	public bool systemFPS;

	[HideInInspector]
	public float[] headData = new float[7];

	[SerializeField]
	private bool rotfoldout;

	[SerializeField]
	private bool hmdOnlyrot;

	[SerializeField]
	private bool controllerOnlyrot;

	[SerializeField]
	private TrackingOrigin trackingOrigin;

	public bool ResetTrackerOnLoad;

	[HideInInspector]
	public Vector3 leftEyeOffset;

	[HideInInspector]
	public Vector3 rightEyeOffset;

	[HideInInspector]
	public Rect leftEyeRect;

	[HideInInspector]
	public Rect rightEyeRect;

	[HideInInspector]
	public Matrix4x4 leftEyeView;

	[HideInInspector]
	public Matrix4x4 rightEyeView;

	[HideInInspector]
	public Pvr_UnitySDKEditor pvr_UnitySDKEditor;

	[SerializeField]
	private bool vrModeEnabled = true;

	[HideInInspector]
	public Material Eyematerial;

	[HideInInspector]
	public Material Middlematerial;

	[HideInInspector]
	public bool newPicovrTriggered;

	[SerializeField]
	private bool showFPS;

	[HideInInspector]
	public Vector3 neckOffset = new Vector3(0f, 0.075f, 0.0805f);

	[SerializeField]
	private bool pVRNeck = true;

	[HideInInspector]
	public bool UseCustomNeckPara;

	[HideInInspector]
	public bool onResume;

	[HideInInspector]
	public bool isEnterVRMode;

	public bool isHasController;

	public Pvr_UnitySDKConfigProfile pvr_UnitySDKConfig;

	private GameObject calltoast;

	private GameObject msgtoast;

	private GameObject lowhmdBatterytoast;

	private GameObject lowphoneBatterytoast;

	private GameObject LowPhoneHealthtoast;

	private GameObject LowcontrollerBatterytoast;

	private bool lowControllerpowerstate;

	private float controllerpowershowtime;

	private bool UseToast = true;

	private int iPhoneHMDModeEnabled;

	private GameObject G3LiteTips;

	[SerializeField]
	private bool monoscopic;

	private bool mIsAndroid7;

	public static Func<bool> eventEnterVRMode;

	[HideInInspector]
	public bool ShowVideoSeethrough;

	public int SystemDebugFFRLevel = -1;

	public int SystemFFRLevel = -1;

	public int AppCheckResult = 100;

	public SystemDisplayFrequency displayFrequency;

	public Action<float> DisplayRefreshRateChanged;

	public Action longPressHomeKeyAction;

	public static Pvr_UnitySDKManager SDK
	{
		get
		{
			if (sdk == null)
			{
				sdk = UnityEngine.Object.FindObjectOfType<Pvr_UnitySDKManager>();
			}
			return sdk;
		}
	}

	public bool Rotfoldout
	{
		get
		{
			return rotfoldout;
		}
		set
		{
			if (value != rotfoldout)
			{
				rotfoldout = value;
			}
		}
	}

	public bool HmdOnlyrot
	{
		get
		{
			return hmdOnlyrot;
		}
		set
		{
			if (value != hmdOnlyrot)
			{
				hmdOnlyrot = value;
			}
		}
	}

	public bool ControllerOnlyrot
	{
		get
		{
			return controllerOnlyrot;
		}
		set
		{
			if (value != controllerOnlyrot)
			{
				controllerOnlyrot = value;
			}
		}
	}

	public TrackingOrigin TrackingOrigin
	{
		get
		{
			return trackingOrigin;
		}
		set
		{
			if (value != trackingOrigin)
			{
				trackingOrigin = value;
				Sensor.UPvr_SetTrackingOriginType(value);
			}
		}
	}

	[HideInInspector]
	public bool VRModeEnabled
	{
		get
		{
			return vrModeEnabled;
		}
		set
		{
			if (value != vrModeEnabled)
			{
				vrModeEnabled = value;
			}
		}
	}

	[HideInInspector]
	public bool picovrTriggered { get; set; }

	public bool ShowFPS
	{
		get
		{
			return showFPS;
		}
		set
		{
			if (value != showFPS)
			{
				showFPS = value;
			}
		}
	}

	public bool PVRNeck
	{
		get
		{
			return pVRNeck;
		}
		set
		{
			if (value != pVRNeck)
			{
				pVRNeck = value;
			}
		}
	}

	[HideInInspector]
	public bool Monoscopic
	{
		get
		{
			return monoscopic;
		}
		set
		{
			if (value != monoscopic)
			{
				monoscopic = value;
				Render.UPvr_SetMonoMode(monoscopic);
			}
		}
	}

	public static event EntitlementCheckResult EntitlementCheckResultEvent;

	public void ChangeDefaultCustomRtSize(int w, int h)
	{
		Pvr_UnitySDKProjectSetting.GetProjectConfig().customRTSize = new Vector2(w, h);
	}

	public Vector3 EyeOffset(Eye eye)
	{
		if (eye != 0)
		{
			return rightEyeOffset;
		}
		return leftEyeOffset;
	}

	public Rect EyeRect(Eye eye)
	{
		if (eye != 0)
		{
			return rightEyeRect;
		}
		return leftEyeRect;
	}

	private bool SDKManagerInit()
	{
		if (SDKManagerInitConfigProfile())
		{
			mIsAndroid7 = SystemInfo.operatingSystem.Contains("Android OS 7.");
			PLOG.I("Android 7 = " + mIsAndroid7);
			if (SDKManagerInitCoreAbility())
			{
				return true;
			}
			return false;
		}
		return false;
	}

	private bool SDKManagerInitCoreAbility()
	{
		Sensor.UPvr_SetTrackingOriginType(trackingOrigin);
		Render.UPvr_SetMonoMode(monoscopic);
		if (Pvr_UnitySDKRender.Instance == null)
		{
			PLOG.I("pvr_UnitySDKRender init failed");
		}
		if (Pvr_UnitySDKSensor.Instance == null)
		{
			PLOG.I("pvr_UnitySDKSensor init failed");
		}
		Pvr_UnitySDKAPI.System.UPvr_StartHomeKeyReceiver(base.gameObject.name);
		return true;
	}

	public void smsReceivedCallback(string msg)
	{
		PLOG.I("PvrLog MSG" + msg);
		JsonData jsonData = JsonMapper.ToObject(msg);
		string text = "";
		if (msg.Contains("messageSender"))
		{
			text = (string)jsonData["messageSender"];
		}
		string text2 = "";
		if (msg.Contains("messageAdr"))
		{
			text2 = (string)jsonData["messageAdr"];
			if (text2.Substring(0, 3) == "+82")
			{
				text2 = "0" + text2.Remove(0, 3);
				text2 = TransformNumber(text2);
			}
			else if (text2.Substring(0, 1) != "+")
			{
				text2 = TransformNumber(text2);
			}
		}
		if (UseToast)
		{
			msgtoast.transform.Find("number").GetComponent<Text>().text = text2;
			msgtoast.transform.Find("name").GetComponent<Text>().text = text;
			if (text.Length == 0)
			{
				msgtoast.transform.Find("number").transform.localPosition = new Vector3(0f, 0f, 0f);
			}
			else
			{
				msgtoast.transform.Find("number").transform.localPosition = new Vector3(60f, 0f, 0f);
			}
			StartCoroutine(ToastManager(2, state: true, 0f));
			StartCoroutine(ToastManager(2, state: false, 5f));
		}
	}

	public void phoneStateCallback(string state)
	{
		PLOG.I("PvrLog phone" + state);
		JsonData jsonData = JsonMapper.ToObject(state);
		string text = "";
		if (state.Contains("phoneNumber"))
		{
			text = (string)jsonData["phoneNumber"];
			if (text.Substring(0, 3) == "+82")
			{
				text = "0" + text.Remove(0, 3);
				text = TransformNumber(text);
			}
			else if (text.Substring(0, 1) != "+")
			{
				text = TransformNumber(text);
			}
		}
		string text2 = "";
		if (state.Contains("contactName"))
		{
			text2 = (string)jsonData["contactName"];
		}
		if (UseToast)
		{
			calltoast.transform.Find("number").GetComponent<Text>().text = text;
			calltoast.transform.Find("name").GetComponent<Text>().text = text2;
			if (text2.Length == 0)
			{
				calltoast.transform.Find("number").transform.localPosition = new Vector3(0f, 0f, 0f);
			}
			else
			{
				calltoast.transform.Find("number").transform.localPosition = new Vector3(60f, 0f, 0f);
			}
			StartCoroutine(ToastManager(1, state: true, 0f));
			StartCoroutine(ToastManager(1, state: false, 5f));
		}
	}

	public void phoneBatteryStateCallback(string state)
	{
		PLOG.I("PvrLog phoneBatteryState" + state);
		JsonData jsonData = JsonMapper.ToObject(state);
		string value = "";
		if (state.Contains("phoneBatteryLevel"))
		{
			value = (string)jsonData["phoneBatteryLevel"];
		}
		string value2 = "";
		if (state.Contains("phoneBatteryHealth"))
		{
			value2 = (string)jsonData["phoneBatteryHealth"];
		}
		if (!UseToast)
		{
			return;
		}
		if (Convert.ToInt16(value) <= 5)
		{
			if (!lowhmdBatterytoast.activeSelf)
			{
				StartCoroutine(ToastManager(4, state: true, 0f));
				StartCoroutine(ToastManager(4, state: false, 3f));
			}
			else
			{
				StartCoroutine(ToastManager(4, state: true, 5f));
				StartCoroutine(ToastManager(4, state: false, 8f));
			}
		}
		if (Convert.ToInt16(value2) == 3)
		{
			StartCoroutine(ToastManager(5, state: true, 0f));
			StartCoroutine(ToastManager(5, state: false, 5f));
		}
	}

	public void hmdLowBatteryCallback(string level)
	{
		PLOG.I("PvrLog hmdLowBatteryCallback" + level);
		if (UseToast)
		{
			if (!lowphoneBatterytoast.activeSelf)
			{
				StartCoroutine(ToastManager(3, state: true, 0f));
				StartCoroutine(ToastManager(3, state: false, 3f));
			}
			else
			{
				StartCoroutine(ToastManager(3, state: true, 5f));
				StartCoroutine(ToastManager(3, state: false, 8f));
			}
		}
	}

	private string TransformNumber(string number)
	{
		if (number.Length == 11)
		{
			string text = number.Substring(0, 3);
			string text2 = number.Substring(3, 4);
			string text3 = number.Substring(7, 4);
			number = text + "-" + text2 + "-" + text3;
		}
		else if (number.Length == 10)
		{
			if (number.Substring(1, 1) == "1")
			{
				string text4 = number.Substring(0, 3);
				string text5 = number.Substring(3, 3);
				string text6 = number.Substring(6, 4);
				number = text4 + "-" + text5 + "-" + text6;
			}
			else
			{
				string text7 = number.Substring(0, 2);
				string text8 = number.Substring(2, 4);
				string text9 = number.Substring(6, 4);
				number = text7 + "-" + text8 + "-" + text9;
			}
		}
		else if (number.Length == 9)
		{
			if (number.Substring(1, 1) == "2")
			{
				string text10 = number.Substring(0, 2);
				string text11 = number.Substring(2, 3);
				string text12 = number.Substring(5, 4);
				number = text10 + "-" + text11 + "-" + text12;
			}
			else
			{
				number = "+82" + number.Remove(0, 1);
			}
		}
		return number;
	}

	public void onHmdOrientationReseted()
	{
	}

	private IEnumerator ToastManager(int type, bool state, float time)
	{
		yield return new WaitForSeconds(time);
		switch (type)
		{
		case 1:
			calltoast.SetActive(state);
			break;
		case 2:
			msgtoast.SetActive(state);
			break;
		case 3:
			lowhmdBatterytoast.SetActive(state);
			break;
		case 4:
			lowphoneBatterytoast.SetActive(state);
			break;
		case 5:
			LowPhoneHealthtoast.SetActive(state);
			break;
		case 6:
			LowcontrollerBatterytoast.SetActive(state);
			break;
		}
	}

	private void CheckControllerStateForG2(string state)
	{
		if (iPhoneHMDModeEnabled == 1 && Convert.ToBoolean(Convert.ToInt16(state)) && Controller.UPvr_GetControllerPower(0) == 0 && Pvr_ControllerManager.controllerlink.Controller0.Rotation.eulerAngles != Vector3.zero)
		{
			StartCoroutine(ToastManager(6, state: true, 0f));
			StartCoroutine(ToastManager(6, state: false, 3f));
		}
	}

	public void notificationCallback(string data)
	{
		JsonData jsonData = JsonMapper.ToObject(data);
		if (G3LiteTips == null)
		{
			G3LiteTips = UnityEngine.Object.Instantiate(Resources.Load("Prefabs/G3LiteTips") as GameObject, base.transform.Find("Head"), worldPositionStays: false);
		}
		JsonData jsonData2 = JsonMapper.ToObject(jsonData["str"].ToString());
		switch ((int)jsonData["type"])
		{
		case 0:
			SetProperty(0, jsonData2, "Sms");
			break;
		case 1:
			SetProperty(1, jsonData2, "Call");
			break;
		case 2:
			SetProperty(2, jsonData2, "Warnning");
			break;
		case 3:
			SetProperty(3, jsonData2, "Warnning");
			break;
		case 4:
			SetProperty(4, jsonData2, "Warnning");
			break;
		case 5:
		{
			Transform transform = G3LiteTips.transform.Find("Onlyimage");
			SetBaseProperty(transform, jsonData2["General"], "");
			SetImageProperty(transform, jsonData2["General"], "");
			transform.gameObject.SetActive(value: true);
			StartCoroutine(G3TipsManager(transform.gameObject, (int)jsonData2["General"]["time"]));
			break;
		}
		case -1:
			break;
		}
	}

	private Sprite LoadSprite(Vector2 size, string filepath)
	{
		int width = (int)size.x;
		int height = (int)size.y;
		Texture2D texture2D = new Texture2D(width, height);
		texture2D.LoadImage(ReadTex(filepath));
		return Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));
	}

	private byte[] ReadTex(string path)
	{
		if (path == "")
		{
			return new byte[0];
		}
		FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
		fileStream.Seek(0L, SeekOrigin.Begin);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, (int)fileStream.Length);
		fileStream.Close();
		fileStream.Dispose();
		fileStream = null;
		return array;
	}

	private void SetProperty(int type, JsonData data, string value)
	{
		Transform trans = G3LiteTips.transform.Find(value);
		SetBaseProperty(trans, data, "");
		SetImageProperty(trans, data, "");
		trans.gameObject.SetActive(value: true);
		StartCoroutine(G3TipsManager(trans.gameObject, (int)data["time"]));
		Transform transform = trans.transform.Find("icon");
		SetBaseProperty(transform, data, "icon_");
		SetImageProperty(transform, data, "icon_");
		Transform transform2 = trans.transform.Find("title");
		SetBaseProperty(transform2, data, "title_");
		SetTextProperty(transform2, data, "title_");
		if (type != 1)
		{
			Transform transform3 = trans.transform.Find("details");
			SetBaseProperty(transform3, data, "details_");
			SetTextProperty(transform3, data, "details_");
			Transform transform4 = trans.transform.Find("image1");
			SetBaseProperty(transform4, data, "image1_");
			SetImageProperty(transform4, data, "image1_");
		}
		if (type == 0 || type == 1)
		{
			Transform transform5 = trans.transform.Find("explain");
			SetBaseProperty(transform5, data, "explain_");
			SetTextProperty(transform5, data, "explain_");
			Transform transform6 = trans.transform.Find("source");
			SetBaseProperty(transform6, data, "source_");
			SetTextProperty(transform6, data, "source_");
		}
		if (type == 0)
		{
			Transform transform7 = trans.transform.Find("time");
			SetBaseProperty(transform7, data, "system_time_");
			SetTextProperty(transform7, data, "system_time_");
		}
		Transform transform8 = trans.transform.Find("Button");
		SetBaseProperty(transform8, data, "button_");
		SetImageProperty(transform8, data, "button_");
		transform8.GetComponent<Button>().onClick.AddListener(delegate
		{
			StartCoroutine(G3TipsManager(trans.gameObject, 0f));
		});
		Transform transform9 = transform8.transform.Find("Text");
		SetBaseProperty(transform9, data, "button_text_");
		SetTextProperty(transform9, data, "button_text_");
	}

	private void SetBaseProperty(Transform trans, JsonData data, string value)
	{
		string prop_name = value + "pos";
		string prop_name2 = value + "angles";
		string prop_name3 = value + "size";
		string prop_name4 = value + "scale";
		trans.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(JsonToFloat(data[prop_name][0]), JsonToFloat(data[prop_name][1]), JsonToFloat(data[prop_name][2]));
		trans.GetComponent<RectTransform>().eulerAngles = new Vector3(JsonToFloat(data[prop_name2][0]), JsonToFloat(data[prop_name2][1]), JsonToFloat(data[prop_name2][2]));
		trans.GetComponent<RectTransform>().sizeDelta = new Vector2(JsonToFloat(data[prop_name3][0]), JsonToFloat(data[prop_name3][1]));
		trans.GetComponent<RectTransform>().localScale = new Vector3(JsonToFloat(data[prop_name4][0]), JsonToFloat(data[prop_name4][1]), JsonToFloat(data[prop_name4][2]));
	}

	private void SetImageProperty(Transform image, JsonData data, string value)
	{
		string prop_name = value + "sprite";
		string prop_name2 = value + "color";
		string prop_name3 = value + "size";
		image.GetComponent<Image>().sprite = LoadSprite(new Vector2(JsonToFloat(data[prop_name3][0]), JsonToFloat(data[prop_name3][1])), (string)data[prop_name]);
		image.GetComponent<Image>().color = new Color(JsonToFloat(data[prop_name2][0]), JsonToFloat(data[prop_name2][1]), JsonToFloat(data[prop_name2][2]), JsonToFloat(data[prop_name2][3]));
	}

	private void SetTextProperty(Transform text, JsonData data, string value)
	{
		string prop_name = value + "color";
		string prop_name2 = value + "font_size";
		string prop_name3 = value + "font_style";
		string prop_name4 = value + "text";
		text.GetComponent<Text>().text = (string)data[prop_name4];
		text.GetComponent<Text>().color = new Color(JsonToFloat(data[prop_name][0]), JsonToFloat(data[prop_name][1]), JsonToFloat(data[prop_name][2]), JsonToFloat(data[prop_name][3]));
		text.GetComponent<Text>().fontSize = (int)data[prop_name2];
		text.GetComponent<Text>().fontStyle = (FontStyle)(int)data[prop_name3];
	}

	private IEnumerator G3TipsManager(GameObject tip, float time)
	{
		yield return new WaitForSeconds(time);
		tip.SetActive(value: false);
	}

	private float JsonToFloat(JsonData data)
	{
		return Convert.ToSingle((string)data);
	}

	private bool SDKManagerInitFPS()
	{
		Transform[] componentsInChildren = GetComponentsInChildren<Transform>(includeInactive: true);
		GameObject gameObject = null;
		Transform[] array = componentsInChildren;
		foreach (Transform transform in array)
		{
			if (transform.gameObject.name == "FPS")
			{
				gameObject = transform.gameObject;
			}
		}
		if (gameObject != null)
		{
			if (systemFPS)
			{
				gameObject.SetActive(value: true);
				return true;
			}
			int res = 0;
			Render.UPvr_GetIntConfig(10, ref res);
			if (Convert.ToBoolean(res))
			{
				gameObject.SetActive(value: true);
				return true;
			}
			if (ShowFPS)
			{
				gameObject.SetActive(value: true);
				return true;
			}
			return false;
		}
		return false;
	}

	private bool SDKManagerInitConfigProfile()
	{
		pvr_UnitySDKConfig = Pvr_UnitySDKConfigProfile.Default;
		return true;
	}

	private bool SDKManagerInitEditor()
	{
		if (pvr_UnitySDKEditor == null)
		{
			pvr_UnitySDKEditor = base.gameObject.AddComponent<Pvr_UnitySDKEditor>();
		}
		else
		{
			pvr_UnitySDKEditor = null;
			pvr_UnitySDKEditor = base.gameObject.AddComponent<Pvr_UnitySDKEditor>();
		}
		return true;
	}

	private bool SDKManagerInitPara()
	{
		return true;
	}

	public void SDKManagerLongHomeKey()
	{
		if (Pvr_UnitySDKSensor.Instance == null)
		{
			return;
		}
		if (isHasController)
		{
			if (Controller.UPvr_GetControllerState(0) == ControllerState.Connected || Controller.UPvr_GetControllerState(1) == ControllerState.Connected)
			{
				Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(0, 1);
			}
			else
			{
				Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 1);
			}
		}
		else
		{
			Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 1);
		}
	}

	private void setLongHomeKey()
	{
		if (sdk.HmdOnlyrot)
		{
			if (Pvr_UnitySDKSensor.Instance != null)
			{
				PLOG.I(Pvr_UnitySDKSensor.Instance.ResetUnitySDKSensor() ? "Long Home Key to Reset Sensor Success!" : "Long Home Key to Reset Sensor Failed!");
			}
			return;
		}
		if (trackingmode == 4 || trackingmode == 5 || trackingmode == 6)
		{
			Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 1);
		}
		else
		{
			if (trackingmode == 2 || trackingmode == 3)
			{
				if (isHasController && (Controller.UPvr_GetControllerState(0) == ControllerState.Connected || Controller.UPvr_GetControllerState(1) == ControllerState.Connected))
				{
					Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(0, 1);
				}
				else
				{
					Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 1);
				}
			}
			if (trackingmode == 0 || trackingmode == 1)
			{
				Pvr_UnitySDKSensor.Instance.ResetUnitySDKSensor();
			}
		}
		if (longPressHomeKeyAction != null)
		{
			longPressHomeKeyAction();
		}
	}

	public void verifyAPPCallback(string code)
	{
		UnityEngine.Debug.Log("PvrLog verifyAPPCallback" + code);
		AppCheckResult = Convert.ToInt32(code);
		if (Pvr_UnitySDKManager.EntitlementCheckResultEvent != null)
		{
			Pvr_UnitySDKManager.EntitlementCheckResultEvent(AppCheckResult);
		}
	}

	public void IpdRefreshCallBack(string ipd)
	{
		UnityEngine.Debug.Log("PvrLog IpdRefreshCallBack");
		Pvr_UnitySDKEye[] eyes = Pvr_UnitySDKEyeManager.Instance.Eyes;
		for (int i = 0; i < eyes.Length; i++)
		{
			eyes[i].RefreshCameraPosition(Convert.ToSingle(ipd));
		}
	}

	public void DisplayRefreshRateCallBack(string rate)
	{
		UnityEngine.Debug.Log("PvrLog DisplayRefreshRateCallBack" + rate);
		if (DisplayRefreshRateChanged != null)
		{
			DisplayRefreshRateChanged(Convert.ToSingle(rate));
		}
	}

	private void Awake()
	{
		UnityEngine.Debug.Log("DISFT Unity Version:" + Application.unityVersion);
		UnityEngine.Debug.Log("DISFT Customize NeckOffset:" + neckOffset);
		UnityEngine.Debug.Log("DISFT MSAA :" + Pvr_UnitySDKProjectSetting.GetProjectConfig().rtAntiAlising);
		if (GraphicsSettings.renderPipelineAsset != null)
		{
			UnityEngine.Debug.Log("DISFT LWRP = Enable");
		}
		UnityEngine.Debug.Log("DISFT Content Proctect :" + Pvr_UnitySDKProjectSetting.GetProjectConfig().usecontentprotect);
		int res = 0;
		LoadIsMirroringValue();
		if (!ismirroring)
		{
			Render.UPvr_GetIntConfig(18, ref res);
			if (res == 1)
			{
				UnityEngine.Debug.Log("DISFT ScreenOrientation.Portrait = Enable");
				Screen.orientation = ScreenOrientation.Portrait;
			}
		}
		else
		{
			Render.UPvr_GetIntConfig(19, ref res);
			Screen.orientation = ((res == 0) ? ScreenOrientation.Portrait : ScreenOrientation.LandscapeLeft);
		}
		new AndroidJavaClass("com.psmart.vrlib.VrActivity");
		new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		Pvr_ControllerManager pvr_ControllerManager = UnityEngine.Object.FindObjectOfType<Pvr_ControllerManager>();
		isHasController = pvr_ControllerManager != null;
		PLOG.getConfigTraceLevel();
		Render.UPvr_GetIntConfig(5, ref trackingmode);
		Application.targetFrameRate = 61;
		int res2 = 0;
		Render.UPvr_GetIntConfig(3, ref res2);
		if (res2 == 0)
		{
			SDK.HmdOnlyrot = true;
		}
		int res3 = -1;
		Render.UPvr_GetIntConfig(9, ref res3);
		float res4 = 0f;
		Render.UPvr_GetFloatConfig(6, ref res4);
		Application.targetFrameRate = ((res3 > 0) ? res3 : ((int)res4));
		if (!Pvr_UnitySDKProjectSetting.GetProjectConfig().usedefaultfps)
		{
			if ((float)Pvr_UnitySDKProjectSetting.GetProjectConfig().customfps <= res4)
			{
				Application.targetFrameRate = Pvr_UnitySDKProjectSetting.GetProjectConfig().customfps;
			}
			else
			{
				Application.targetFrameRate = (int)res4;
			}
		}
		UnityEngine.Debug.Log("DISFT Customize FPS :" + Application.targetFrameRate);
		if (!UseCustomNeckPara)
		{
			float res5 = 0f;
			float res6 = 0f;
			float res7 = 0f;
			int configsenum = 4;
			int configsenum2 = 5;
			Render.UPvr_GetFloatConfig(3, ref res5);
			Render.UPvr_GetFloatConfig(configsenum, ref res6);
			Render.UPvr_GetFloatConfig(configsenum2, ref res7);
			if (res5 != 0f || res6 != 0f || res7 != 0f)
			{
				neckOffset = new Vector3(res5, res6, res7);
			}
		}
		Render.UPvr_GetIntConfig(16, ref iPhoneHMDModeEnabled);
		Pvr_ControllerManager.ControllerStatusChangeEvent += CheckControllerStateForG2;
		InitUI();
		RefreshTextByLanguage();
	}

	private IEnumerator Start()
	{
		if (SDKManagerInit())
		{
			PLOG.I("SDK Init success.");
		}
		else
		{
			PLOG.E("SDK Init Failed.");
			Application.Quit();
		}
		if (Pvr_UnitySDKRender.Instance != null)
		{
			Pvr_UnitySDKRender.Instance.ReInit();
		}
		SDKManagerInitFPS();
		if (Pvr_UnitySDKPlatformSetting.StartTimeEntitlementCheck)
		{
			if (PlatformSettings.UPvr_IsCurrentDeviceValid() != Pvr_UnitySDKPlatformSetting.simulationType.Valid)
			{
				UnityEngine.Debug.Log("DISFT Entitlement Check Simulation DO NOT PASS");
				string appID = Pvr_UnitySDKPlatformSetting.Instance.appID;
				UnityEngine.Debug.Log("DISFT Start-time Entitlement Check Enable");
				PLOG.I("DISFT Start-time Entitlement Check APPID :" + appID);
				PlatformSettings.UPvr_AppEntitlementCheckExtra(appID);
			}
			else
			{
				UnityEngine.Debug.Log("DISFT Entitlement Check Simulation PASS");
			}
		}
		yield return StartCoroutine(InitRenderThreadRoutine());
	}

	private IEnumerator InitRenderThreadRoutine()
	{
		PLOG.I("InitRenderThreadRoutine begin");
		int i = 0;
		while (i < 2)
		{
			yield return null;
			int num = i + 1;
			i = num;
		}
		UnityEngine.Debug.Log("InitRenderThreadRoutine after a wait");
		if (Pvr_UnitySDKRender.Instance != null)
		{
			Pvr_UnitySDKRender.Instance.IssueRenderThread();
		}
		else
		{
			UnityEngine.Debug.Log("InitRenderThreadRoutine pvr_UnitySDKRender == null");
		}
		UnityEngine.Debug.Log("InitRenderThreadRoutine end");
	}

	private void Update()
	{
		if (isHasController && iPhoneHMDModeEnabled == 1 && Controller.UPvr_GetControllerPower(0) == 0 && Pvr_ControllerManager.controllerlink.controller0Connected && Pvr_ControllerManager.controllerlink.Controller0.Rotation.eulerAngles != Vector3.zero)
		{
			if (!lowControllerpowerstate)
			{
				StartCoroutine(ToastManager(6, state: true, 0f));
				StartCoroutine(ToastManager(6, state: false, 3f));
				lowControllerpowerstate = true;
			}
			controllerpowershowtime += Time.deltaTime;
			if (controllerpowershowtime >= 3600f)
			{
				lowControllerpowerstate = false;
				controllerpowershowtime = 0f;
			}
		}
		if (Input.touchCount == 1 && Input.touches[0].phase == TouchPhase.Began)
		{
			newPicovrTriggered = true;
		}
		if (Input.GetKeyDown(KeyCode.JoystickButton0))
		{
			newPicovrTriggered = true;
		}
		if (Pvr_UnitySDKSensor.Instance != null)
		{
			Pvr_UnitySDKSensor.Instance.SensorUpdate();
		}
		picovrTriggered = newPicovrTriggered;
		newPicovrTriggered = false;
	}

	private void OnDestroy()
	{
		if (sdk == this)
		{
			sdk = null;
		}
		RenderTexture.active = null;
		Resources.UnloadUnusedAssets();
		GC.Collect();
		Pvr_ControllerManager.ControllerStatusChangeEvent -= CheckControllerStateForG2;
	}

	private void OnEnable()
	{
		if (sdk == null)
		{
			sdk = this;
		}
		else if (sdk != this)
		{
			sdk = this;
		}
	}

	private void OnDisable()
	{
		StopAllCoroutines();
	}

	private void OnPause()
	{
		Pvr_UnitySDKAPI.System.UPvr_StopHomeKeyReceiver();
		LeaveVRMode();
		if (Pvr_UnitySDKSensor.Instance != null)
		{
			Pvr_UnitySDKSensor.Instance.StopUnitySDKSensor();
		}
	}

	private void OnApplicationPause(bool pause)
	{
		bool flag = pause;
		UnityEngine.Debug.Log("OnApplicationPause-------------------------" + (flag ? "true" : "false"));
		if (Pvr_UnitySDKAPI.System.UPvr_IsPicoActivity() && !Pvr_UnitySDKRender.Instance.isShellMode)
		{
			bool flag2 = Pvr_UnitySDKAPI.System.UPvr_GetMainActivityPauseStatus();
			UnityEngine.Debug.Log("OnApplicationPause-------------------------Activity Pause State:" + flag2);
			pause = flag2;
		}
		if (flag == pause)
		{
			if (pause)
			{
				onResume = false;
				OnPause();
			}
			else
			{
				onResume = true;
				GL.InvalidateState();
				StartCoroutine(OnResume());
			}
		}
		else if (pause)
		{
			UnityEngine.Debug.Log("OnApplicationPause-------------------------Activity pause Unity resume");
			GL.InvalidateState();
			StartCoroutine(OnResume());
			onResume = false;
			OnPause();
		}
		else
		{
			UnityEngine.Debug.Log("OnApplicationPause-------------------------Activity resume Unity pause");
			OnPause();
			onResume = true;
			GL.InvalidateState();
			StartCoroutine(OnResume());
		}
	}

	public void EnterVRMode()
	{
		Pvr_UnitySDKPluginEvent.Issue(RenderEventType.Resume);
		isEnterVRMode = true;
		if (eventEnterVRMode != null)
		{
			eventEnterVRMode();
		}
	}

	public void LeaveVRMode()
	{
		Pvr_UnitySDKPluginEvent.Issue(RenderEventType.Pause);
		isEnterVRMode = false;
	}

	public void SixDofForceQuit()
	{
		Application.Quit();
	}

	private void InitUI()
	{
		if (iPhoneHMDModeEnabled == 1)
		{
			Transform transform = UnityEngine.Object.Instantiate(Resources.Load("Prefabs/flamingo2Tips") as GameObject, base.transform.Find("Head"), worldPositionStays: false).transform;
			calltoast = transform.Find("Call").gameObject;
			msgtoast = transform.Find("Msg").gameObject;
			lowhmdBatterytoast = transform.Find("LowHmdBattery").gameObject;
			lowphoneBatterytoast = transform.Find("LowPhoneBattery").gameObject;
			LowPhoneHealthtoast = transform.Find("LowPhoneHealth").gameObject;
			LowcontrollerBatterytoast = transform.Find("LowControllerBattery").gameObject;
		}
	}

	private void RefreshTextByLanguage()
	{
		if (msgtoast != null)
		{
			msgtoast.transform.Find("Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("msgtoast0");
			msgtoast.transform.Find("string").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("msgtoast1");
			calltoast.transform.Find("Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("calltoast0");
			calltoast.transform.Find("Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("calltoast1");
			lowhmdBatterytoast.transform.Find("Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("lowhmdBatterytoast");
			lowphoneBatterytoast.transform.Find("Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("lowphoneBatterytoast");
			LowPhoneHealthtoast.transform.Find("Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("LowPhoneHealthtoast");
			LowcontrollerBatterytoast.transform.Find("Text").GetComponent<Text>().text = Pvr_UnitySDKAPI.System.UPvr_GetLangString("LowcontrollerBatterytoast");
		}
	}

	private void LoadIsMirroringValue()
	{
		AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		AndroidJavaObject androidJavaObject = @static.Call<AndroidJavaObject>("getPackageManager", Array.Empty<object>());
		string text = @static.Call<string>("getPackageName", Array.Empty<object>());
		AndroidJavaObject androidJavaObject2 = androidJavaObject.Call<AndroidJavaObject>("getApplicationInfo", new object[2] { text, 128 }).Get<AndroidJavaObject>("metaData");
		ismirroring = Convert.ToBoolean(androidJavaObject2.Call<int>("getInt", new object[2] { "bypass_presentation", 0 }));
	}

	private IEnumerator OnResume()
	{
		switch (displayFrequency)
		{
		case SystemDisplayFrequency.Default:
			Render.UPvr_SetDisplayFrequency(-1f);
			break;
		case SystemDisplayFrequency.RefreshRate72:
			Render.UPvr_SetDisplayFrequency(72f);
			break;
		case SystemDisplayFrequency.RefreshRate90:
			Render.UPvr_SetDisplayFrequency(90f);
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
		int ability6dof = 0;
		Render.UPvr_GetIntConfig(3, ref ability6dof);
		RefreshTextByLanguage();
		if (Pvr_UnitySDKSensor.Instance != null)
		{
			Pvr_UnitySDKSensor.Instance.StartUnitySDKSensor();
			int res = -1;
			Render.UPvr_GetIntConfig(8, ref res);
			if (res != 1)
			{
				int res2 = -1;
				Render.UPvr_GetIntConfig(11, ref res2);
				if (res2 != 8)
				{
					Pvr_UnitySDKSensor.Instance.ResetUnitySDKSensor();
				}
			}
		}
		if (Pvr_UnitySDKAPI.System.UPvr_IsPicoActivity())
		{
			PLOG.I("onresume set monoPresentation success ?-------------" + Pvr_UnitySDKAPI.System.UPvr_SetMonoPresentation());
			PLOG.I("onresume presentation existed ?-------------" + Pvr_UnitySDKAPI.System.UPvr_IsPresentationExisted());
		}
		for (int j = 0; j < Pvr_UnitySDKEyeManager.Instance.Eyes.Length; j++)
		{
			Pvr_UnitySDKEyeManager.Instance.Eyes[j].RefreshCameraPosition(Pvr_UnitySDKAPI.System.UPvr_GetIPD());
		}
		int waitNum = 15;
		Render.UPvr_GetIntConfig(20, ref waitNum);
		int resetNum = 10;
		Render.UPvr_GetIntConfig(21, ref resetNum);
		for (int i = 0; i < waitNum; i++)
		{
			if (i == resetNum && ResetTrackerOnLoad && ability6dof == 1)
			{
				UnityEngine.Debug.Log("Reset Tracker OnLoad");
				Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 1);
			}
			yield return null;
		}
		EnterVRMode();
		Pvr_UnitySDKAPI.System.UPvr_StartHomeKeyReceiver(base.gameObject.name);
		Pvr_UnitySDKEye.setLevel = false;
		if (longPressHomeKeyAction != null)
		{
			longPressHomeKeyAction();
		}
		if (Render.UPvr_GetIntSysProc("pvrsist.foveation.level", ref SystemDebugFFRLevel))
		{
			Render.SetFoveatedRenderingLevel((EFoveationLevel)SystemDebugFFRLevel);
			UnityEngine.Debug.Log("DISFT OnResume Get System Debug ffr level is : " + SystemDebugFFRLevel);
		}
		else
		{
			UnityEngine.Debug.Log("DISFT OnResume Get System Debug ffr level Error,ffr level is : " + SystemDebugFFRLevel);
		}
		if (SystemDebugFFRLevel == -1)
		{
			Render.UPvr_GetIntConfig(22, ref SystemFFRLevel);
			if (SystemFFRLevel != -1 && SystemFFRLevel >= (int)Pvr_UnitySDKEyeManager.Instance.FoveationLevel)
			{
				Render.SetFoveatedRenderingLevel((EFoveationLevel)SystemFFRLevel);
				UnityEngine.Debug.Log("DISFT OnResume Get System ffr level is : " + SystemFFRLevel);
			}
		}
	}
}
public class QuitGame : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
public class Pvr_UnityEyeMask : MonoBehaviour
{
	private class EyeMaskData
	{
		public Eye eyeSide;

		public Camera camera;

		public CommandBuffer cmdBuf;
	}

	private Shader eyeMaskShader;

	private Material eyeMaskMaterial;

	private Mesh eyeMaskMeshLeft;

	private Mesh eyeMaskMeshRight;

	private Mesh eyeMaskMeshBoth;

	private float zDir = -1f;

	private Color eyeMaskColor = Color.black;

	private List<EyeMaskData> cameraDataList = new List<EyeMaskData>();

	private void Awake()
	{
		UnityEngine.Debug.Log("DISFT EyeMask = Enable");
		if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGLES3 || SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGLES2)
		{
			zDir = -1f;
		}
		else if (SystemInfo.usesReversedZBuffer)
		{
			zDir = 1f;
		}
		else
		{
			zDir = 0f;
		}
	}

	private void OnEnable()
	{
		if (eyeMaskShader == null)
		{
			eyeMaskShader = Shader.Find("Pvr_UnitySDK/Pvr_EyeMask");
		}
		if (eyeMaskMaterial == null && eyeMaskShader != null)
		{
			eyeMaskMaterial = new Material(eyeMaskShader);
			eyeMaskMaterial.SetColor("_Color", eyeMaskColor);
		}
		if (eyeMaskMaterial == null)
		{
			base.enabled = false;
			UnityEngine.Debug.LogWarning("EyeMask materil is null or EyeMask shader not found!");
		}
		else
		{
			PrepareCameras();
			Camera.onPreRender = (Camera.CameraCallback)Delegate.Combine(Camera.onPreRender, new Camera.CameraCallback(OnCustomPreRender));
			CreateCommandBuffer();
		}
	}

	private void OnDisable()
	{
		Camera.onPreRender = (Camera.CameraCallback)Delegate.Remove(Camera.onPreRender, new Camera.CameraCallback(OnCustomPreRender));
		foreach (EyeMaskData cameraData in cameraDataList)
		{
			if (cameraData.camera != null && cameraData.cmdBuf != null)
			{
				RemoveCameraCommandBuffer(cameraData);
			}
		}
		CleanEyeMask();
	}

	private void CreateCommandBuffer()
	{
		if (VerifyCommadBuffer())
		{
			return;
		}
		if (eyeMaskMeshLeft == null || eyeMaskMeshRight == null)
		{
			eyeMaskMeshLeft = GetStencilMesh(Eye.LeftEye);
			eyeMaskMeshRight = GetStencilMesh(Eye.RightEye);
			if (eyeMaskMeshLeft == null || eyeMaskMeshRight == null)
			{
				UnityEngine.Debug.LogWarning("Stencil Mesh is not exist, disable EyeMask.");
				base.enabled = false;
				return;
			}
		}
		foreach (EyeMaskData cameraData in cameraDataList)
		{
			if (cameraData.eyeSide == Eye.LeftEye)
			{
				CommandBuffer commandBuffer = new CommandBuffer();
				commandBuffer.name = "EyeMaskLeft";
				commandBuffer.DrawMesh(eyeMaskMeshLeft, Matrix4x4.identity, eyeMaskMaterial, 0, 0);
				cameraData.cmdBuf = commandBuffer;
			}
			else if (cameraData.eyeSide == Eye.RightEye)
			{
				CommandBuffer commandBuffer2 = new CommandBuffer();
				commandBuffer2.name = "EyeMaskRight";
				commandBuffer2.DrawMesh(eyeMaskMeshRight, Matrix4x4.identity, eyeMaskMaterial, 0, 0);
				cameraData.cmdBuf = commandBuffer2;
			}
			else if (cameraData.eyeSide == Eye.BothEye)
			{
				if (eyeMaskMeshBoth == null)
				{
					eyeMaskMeshBoth = GetStencilMeshBoth(eyeMaskMeshLeft, eyeMaskMeshRight);
					float value = Mathf.Max(Mathf.Abs(eyeMaskMeshLeft.bounds.max.x), Mathf.Abs(eyeMaskMeshRight.bounds.min.x));
					eyeMaskMaterial.SetFloat("_MeshOffsetX", value);
				}
				CommandBuffer commandBuffer3 = new CommandBuffer();
				commandBuffer3.name = "EyeMaskBoth";
				commandBuffer3.DrawMesh(eyeMaskMeshBoth, Matrix4x4.identity, eyeMaskMaterial, 0, 1);
				cameraData.cmdBuf = commandBuffer3;
			}
		}
	}

	private void OnCustomPreRender(Camera cam)
	{
		if (!VerifyCommadBuffer())
		{
			UnityEngine.Debug.LogWarning("Verify CommandBuffer failed!");
			return;
		}
		foreach (EyeMaskData cameraData in cameraDataList)
		{
			if (!(cameraData.camera != cam))
			{
				RemoveCameraCommandBuffer(cameraData);
				AddCameraCommandBuffer(cameraData);
			}
		}
	}

	private Mesh GetStencilMesh(Eye eyeSide)
	{
		int vertexCount = 0;
		int triangleCount = 0;
		IntPtr vertexDataPtr = IntPtr.Zero;
		IntPtr indexDataPtr = IntPtr.Zero;
		Render.UPvr_GetStencilMesh((int)eyeSide, ref vertexCount, ref triangleCount, ref vertexDataPtr, ref indexDataPtr);
		if (vertexCount <= 0 || triangleCount <= 0 || vertexDataPtr == IntPtr.Zero || indexDataPtr == IntPtr.Zero)
		{
			return null;
		}
		Vector3[] array = new Vector3[vertexCount];
		int[] array2 = new int[triangleCount * 3];
		float[] array3 = new float[vertexCount * 3];
		int[] array4 = new int[triangleCount * 3];
		Marshal.Copy(vertexDataPtr, array3, 0, vertexCount * 3);
		Marshal.Copy(indexDataPtr, array4, 0, triangleCount * 3);
		for (int i = 0; i < vertexCount; i++)
		{
			array[i] = new Vector3(array3[3 * i], array3[3 * i + 1], zDir);
		}
		for (int j = 0; j < triangleCount; j++)
		{
			array2[3 * j] = array4[3 * j + 2];
			array2[3 * j + 1] = array4[3 * j + 1];
			array2[3 * j + 2] = array4[3 * j];
		}
		Mesh mesh = new Mesh();
		mesh.name = "EyeMaskMesh";
		mesh.vertices = array;
		mesh.SetIndices(array2, MeshTopology.Triangles, 0);
		return mesh;
	}

	private Mesh GetStencilMeshBoth(Mesh leftMesh, Mesh rightMesh)
	{
		float num = Mathf.Max(Mathf.Abs(leftMesh.bounds.max.x), Mathf.Abs(rightMesh.bounds.min.x));
		Mesh mesh = new Mesh();
		mesh.name = "EyeMaskBoth";
		CombineInstance combineInstance = default(CombineInstance);
		combineInstance.mesh = leftMesh;
		Matrix4x4 identity = Matrix4x4.identity;
		identity.SetTRS(Vector3.left * num, Quaternion.identity, Vector3.one);
		combineInstance.transform = identity;
		CombineInstance combineInstance2 = default(CombineInstance);
		combineInstance2.mesh = rightMesh;
		Matrix4x4 identity2 = Matrix4x4.identity;
		identity2.SetTRS(Vector3.right * num, Quaternion.identity, Vector3.one);
		combineInstance2.transform = identity2;
		CombineInstance[] combine = new CombineInstance[2] { combineInstance, combineInstance2 };
		mesh.CombineMeshes(combine);
		return mesh;
	}

	private bool VerifyCommadBuffer()
	{
		if (cameraDataList == null || cameraDataList.Count <= 0)
		{
			return false;
		}
		foreach (EyeMaskData cameraData in cameraDataList)
		{
			if (cameraData == null || cameraData.cmdBuf == null)
			{
				return false;
			}
		}
		return true;
	}

	private void PrepareCameras()
	{
		cameraDataList.Clear();
		if (Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.SinglePass)
		{
			if (Pvr_UnitySDKEyeManager.Instance.BothEyeCamera == null)
			{
				UnityEngine.Debug.LogWarning("BothEye Camera is null!");
				return;
			}
			EyeMaskData eyeMaskData = new EyeMaskData();
			eyeMaskData.eyeSide = Eye.BothEye;
			eyeMaskData.camera = Pvr_UnitySDKEyeManager.Instance.BothEyeCamera;
			cameraDataList.Add(eyeMaskData);
		}
		else if (Pvr_UnitySDKEyeManager.Instance.LeftEyeCamera == null || Pvr_UnitySDKEyeManager.Instance.RightEyeCamera == null)
		{
			UnityEngine.Debug.LogWarning("LeftEye or RightEye Camera is null!");
		}
		else
		{
			EyeMaskData eyeMaskData2 = new EyeMaskData();
			eyeMaskData2.eyeSide = Eye.LeftEye;
			eyeMaskData2.camera = Pvr_UnitySDKEyeManager.Instance.LeftEyeCamera;
			eyeMaskData2.cmdBuf = null;
			cameraDataList.Add(eyeMaskData2);
			EyeMaskData eyeMaskData3 = new EyeMaskData();
			eyeMaskData3.eyeSide = Eye.RightEye;
			eyeMaskData3.camera = Pvr_UnitySDKEyeManager.Instance.RightEyeCamera;
			eyeMaskData3.cmdBuf = null;
			cameraDataList.Add(eyeMaskData3);
		}
	}

	private void AddCameraCommandBuffer(EyeMaskData data)
	{
		data.camera.AddCommandBuffer(CameraEvent.BeforeForwardOpaque, data.cmdBuf);
	}

	private void RemoveCameraCommandBuffer(EyeMaskData data)
	{
		data.camera.RemoveCommandBuffer(CameraEvent.BeforeForwardOpaque, data.cmdBuf);
	}

	private void CleanEyeMask()
	{
		cameraDataList.Clear();
		eyeMaskMeshLeft = null;
		eyeMaskMeshRight = null;
		eyeMaskMeshBoth = null;
		eyeMaskShader = null;
		eyeMaskMaterial = null;
	}
}
[RequireComponent(typeof(Camera))]
public class Pvr_UnitySDKEye : MonoBehaviour
{
	public static List<Pvr_UnitySDKEye> Instances = new List<Pvr_UnitySDKEye>();

	public Eye eyeSide;

	private int eyeCameraOriginCullingMask;

	private CameraClearFlags eyeCameraOriginClearFlag;

	private Color eyeCameraOriginBackgroundColor;

	private int lastBoundaryState;

	private Matrix4x4 realProj = Matrix4x4.identity;

	private const int bufferSize = 3;

	private int IDIndex;

	private RenderEventType eventType;

	private int previousId;

	public static bool setLevel = false;

	private Material mat_Vignette;

	public Camera eyecamera { get; private set; }

	private void Awake()
	{
		Instances.Add(this);
		eyecamera = GetComponent<Camera>();
	}

	private void Start()
	{
		Setup(eyeSide);
		SetupUpdate();
		if (eyecamera != null)
		{
			eyeCameraOriginCullingMask = eyecamera.cullingMask;
			eyeCameraOriginClearFlag = eyecamera.clearFlags;
			eyeCameraOriginBackgroundColor = eyecamera.backgroundColor;
		}
	}

	private void Update()
	{
		if (!(eyecamera != null) || !eyecamera.enabled)
		{
			return;
		}
		int num = BoundarySystem.UPvr_GetSeeThroughState();
		if (num == lastBoundaryState)
		{
			return;
		}
		switch (num)
		{
		case 2:
			eyeCameraOriginCullingMask = eyecamera.cullingMask;
			eyeCameraOriginClearFlag = eyecamera.clearFlags;
			eyeCameraOriginBackgroundColor = eyecamera.backgroundColor;
			eyecamera.cullingMask = 0;
			eyecamera.clearFlags = CameraClearFlags.Color;
			eyecamera.backgroundColor = Color.black;
			break;
		case 1:
			if (lastBoundaryState == 2)
			{
				if (eyecamera.cullingMask == 0)
				{
					eyecamera.cullingMask = eyeCameraOriginCullingMask;
				}
				if (eyecamera.clearFlags == CameraClearFlags.Color)
				{
					eyecamera.clearFlags = eyeCameraOriginClearFlag;
				}
				if (eyecamera.backgroundColor == Color.black)
				{
					eyecamera.backgroundColor = eyeCameraOriginBackgroundColor;
				}
			}
			break;
		default:
			if (lastBoundaryState == 2 || lastBoundaryState == 1)
			{
				if (eyecamera.cullingMask == 0)
				{
					eyecamera.cullingMask = eyeCameraOriginCullingMask;
				}
				if (eyecamera.clearFlags == CameraClearFlags.Color)
				{
					eyecamera.clearFlags = eyeCameraOriginClearFlag;
				}
				if (eyecamera.backgroundColor == Color.black)
				{
					eyecamera.backgroundColor = eyeCameraOriginBackgroundColor;
				}
			}
			break;
		}
		lastBoundaryState = num;
	}

	private void OnEnable()
	{
		if (GraphicsSettings.renderPipelineAsset != null)
		{
			RenderPipelineManager.beginCameraRendering += MyPreRender;
			RenderPipelineManager.endCameraRendering += MyPostRender;
		}
	}

	private void OnDisable()
	{
		if (GraphicsSettings.renderPipelineAsset != null)
		{
			RenderPipelineManager.beginCameraRendering -= MyPreRender;
			RenderPipelineManager.endCameraRendering -= MyPostRender;
		}
	}

	private void OnDestroy()
	{
		Instances.Remove(this);
	}

	public void MyPreRender(Camera camera)
	{
		if (!(camera.gameObject != base.gameObject))
		{
			OnPreRender();
		}
	}

	public void MyPreRender(ScriptableRenderContext context, Camera camera)
	{
		if (!(camera.gameObject != base.gameObject))
		{
			OnPreRender();
		}
	}

	public void MyPostRender(ScriptableRenderContext context, Camera camera)
	{
		if (!(camera.gameObject != base.gameObject))
		{
			OnPostRender();
		}
	}

	private void OnPreRender()
	{
		if (!eyecamera.enabled)
		{
			return;
		}
		if (Pvr_UnitySDKRender.Instance.StereoRendering != null)
		{
			if (Pvr_UnitySDKRender.Instance.isSwitchSDK)
			{
				return;
			}
			Pvr_UnitySDKRender.Instance.StereoRendering.OnSDKPreRender();
		}
		SetFFRParameter();
		Pvr_UnitySDKPluginEvent.Issue(RenderEventType.BeginEye);
	}

	private void OnPostRender()
	{
		if (!eyecamera.enabled)
		{
			return;
		}
		Pvr_UnitySDKAPI.System.UPvr_UnityEventData(Pvr_UnitySDKAPI.System.UPvr_GetEyeBufferData(Pvr_UnitySDKRender.Instance.eyeTextureIds[IDIndex]));
		Pvr_UnitySDKPluginEvent.Issue(eventType);
		if (Pvr_UnitySDKRender.Instance.StereoRendering != null)
		{
			if (Pvr_UnitySDKRender.Instance.isSwitchSDK)
			{
				return;
			}
			Pvr_UnitySDKRender.Instance.StereoRendering.OnSDKPostRender();
		}
		Pvr_UnitySDKPluginEvent.Issue(RenderEventType.EndEye);
	}

	public void EyeRender()
	{
		SetupUpdate();
		if (Pvr_UnitySDKRender.Instance.eyeTextures[IDIndex] != null)
		{
			Pvr_UnitySDKRender.Instance.eyeTextures[IDIndex].DiscardContents();
			eyecamera.targetTexture = Pvr_UnitySDKRender.Instance.eyeTextures[IDIndex];
		}
	}

	private void Setup(Eye eyeSide)
	{
		eyecamera = GetComponent<Camera>();
		switch (eyeSide)
		{
		case Eye.LeftEye:
		case Eye.RightEye:
			base.transform.localPosition = Pvr_UnitySDKManager.SDK.EyeOffset(eyeSide);
			break;
		case Eye.BothEye:
			base.transform.localPosition = Vector3.zero;
			break;
		}
		eyecamera.aspect = Pvr_UnitySDKManager.SDK.EyesAspect;
		eyecamera.rect = new Rect(0f, 0f, 1f, 1f);
		if (Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.MultiPass)
		{
			eventType = ((eyeSide == Eye.LeftEye) ? RenderEventType.LeftEyeEndFrame : RenderEventType.RightEyeEndFrame);
		}
		else
		{
			eventType = RenderEventType.BothEyeEndFrame;
		}
	}

	private void SetupUpdate()
	{
		if (eyeSide == Eye.LeftEye || eyeSide == Eye.RightEye)
		{
			eyecamera.enabled = !Pvr_UnitySDKManager.SDK.Monoscopic && Pvr_UnitySDKRender.Instance.StereoRenderPath != StereoRenderingPathPico.SinglePass;
		}
		else if (eyeSide == Eye.BothEye)
		{
			eyecamera.enabled = Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.SinglePass;
		}
		eyecamera.fieldOfView = Pvr_UnitySDKRender.Instance.EyeVFoV;
		eyecamera.aspect = Pvr_UnitySDKManager.SDK.EyesAspect;
		if (eyeSide == Eye.LeftEye || eyeSide == Eye.RightEye)
		{
			IDIndex = Pvr_UnitySDKRender.Instance.currEyeTextureIdx + (int)eyeSide * 3;
		}
		else if (eyeSide == Eye.BothEye)
		{
			IDIndex = Pvr_UnitySDKRender.Instance.currEyeTextureIdx;
			Pvr_UnitySDKRender.Instance.isSwitchSDK = Pvr_UnitySDKRender.Instance.lastEyeTextureIdx == Pvr_UnitySDKRender.Instance.currEyeTextureIdx;
			Pvr_UnitySDKRender.Instance.lastEyeTextureIdx = Pvr_UnitySDKRender.Instance.currEyeTextureIdx;
		}
	}

	public void RefreshCameraPosition(float ipd)
	{
		Pvr_UnitySDKManager.SDK.leftEyeOffset = new Vector3((0f - ipd) / 2f, 0f, 0f);
		Pvr_UnitySDKManager.SDK.rightEyeOffset = new Vector3(ipd / 2f, 0f, 0f);
		if (eyeSide == Eye.LeftEye || eyeSide == Eye.RightEye)
		{
			base.transform.localPosition = Pvr_UnitySDKManager.SDK.EyeOffset(eyeSide);
		}
		else if (eyeSide == Eye.BothEye)
		{
			eyecamera.stereoSeparation = ipd;
		}
	}

	private void DrawVignetteLine()
	{
		if (null == mat_Vignette)
		{
			mat_Vignette = new Material(Shader.Find("Diffuse"));
			if (null == mat_Vignette)
			{
				return;
			}
		}
		GL.PushMatrix();
		mat_Vignette.SetPass(0);
		GL.LoadOrtho();
		vignette();
		GL.PopMatrix();
	}

	private void vignette()
	{
		GL.Begin(7);
		GL.Color(Color.black);
		GL.Vertex3(0f, 1f, 0f);
		GL.Vertex3(1f, 1f, 0f);
		GL.Vertex3(1f, 0.995f, 0f);
		GL.Vertex3(0f, 0.995f, 0f);
		GL.Vertex3(0f, 0f, 0f);
		GL.Vertex3(0f, 0.005f, 0f);
		GL.Vertex3(1f, 0.005f, 0f);
		GL.Vertex3(1f, 0f, 0f);
		GL.Vertex(new Vector3(0f, 1f, 0f));
		GL.Vertex(new Vector3(0.005f, 1f, 0f));
		GL.Vertex(new Vector3(0.005f, 0f, 0f));
		GL.Vertex(new Vector3(0f, 0f, 0f));
		GL.Vertex(new Vector3(0.995f, 1f, 0f));
		GL.Vertex(new Vector3(1f, 1f, 0f));
		GL.Vertex(new Vector3(1f, 0f, 0f));
		GL.Vertex(new Vector3(0.995f, 0f, 0f));
		GL.End();
	}

	private void SetFFRParameter()
	{
		Vector3 vector = Vector3.zero;
		if (Pvr_UnitySDKManager.SDK.isEnterVRMode && Pvr_UnitySDKEyeManager.supportEyeTracking && Pvr_UnitySDKEyeManager.Instance.EyeTracking)
		{
			vector = Pvr_UnitySDKAPI.System.UPvr_getEyeTrackingPos();
		}
		int textureId = Pvr_UnitySDKRender.Instance.eyeTextureIds[IDIndex];
		Render.UPvr_SetFoveationResource(textureId, previousId, vector.x, vector.y);
		previousId = textureId;
	}
}
public class Pvr_UnitySDKEyeManager : MonoBehaviour
{
	private static Pvr_UnitySDKEyeManager instance;

	private Pvr_UnitySDKEye[] eyes;

	[HideInInspector]
	public Camera LeftEyeCamera;

	[HideInInspector]
	public Camera RightEyeCamera;

	[HideInInspector]
	public Camera MonoEyeCamera;

	[HideInInspector]
	public Camera BothEyeCamera;

	private int MonoEyeTextureID;

	private readonly int WaitSplashScreenFrames = 3;

	private int frameNum;

	[SerializeField]
	[HideInInspector]
	private bool foveatedRendering;

	[SerializeField]
	[HideInInspector]
	private EFoveationLevel foveationLevel;

	private int eyeTextureId;

	private RenderEventType eventType = RenderEventType.LeftEyeEndFrame;

	private Pvr_UnitySDKEyeOverlay compositeLayer;

	private int overlayLayerDepth = 1;

	private int underlayLayerDepth;

	private bool isHeadLocked;

	private int layerFlags;

	[HideInInspector]
	public bool EyeTracking;

	[HideInInspector]
	public Vector3 eyePoint;

	private EyeTrackingData eyePoseData;

	[HideInInspector]
	public static bool supportEyeTracking;

	[Tooltip("If true, specific color gradient when switching scenes.")]
	public bool screenFade;

	[Tooltip("Define the duration of screen fade.")]
	public float fadeTime = 5f;

	[Tooltip("Define the color of screen fade.")]
	public Color fadeColor = new Color(0f, 0f, 0f, 1f);

	public int renderQueue = 5000;

	private MeshRenderer fadeMeshRenderer;

	private MeshFilter fadeMeshFilter;

	private Material fadeMaterial;

	private float elapsedTime;

	private bool isFading;

	private float currentAlpha;

	private float nowFadeAlpha;

	public static Pvr_UnitySDKEyeManager Instance
	{
		get
		{
			if (instance == null)
			{
				PLOG.E("Pvr_UnitySDKEyeManager instance is not init yet...");
			}
			return instance;
		}
	}

	public Pvr_UnitySDKEye[] Eyes
	{
		get
		{
			if (eyes == null)
			{
				eyes = Pvr_UnitySDKEye.Instances.ToArray();
			}
			return eyes;
		}
	}

	[HideInInspector]
	public bool FoveatedRendering
	{
		get
		{
			return foveatedRendering;
		}
		set
		{
			if (value == foveatedRendering)
			{
				return;
			}
			foveatedRendering = value;
			if (Application.isPlaying)
			{
				Render.UPvr_EnableFoveation(enable: true);
				if (!foveatedRendering)
				{
					Render.SetFoveatedRenderingLevel((EFoveationLevel)(-1));
				}
			}
		}
	}

	[HideInInspector]
	public EFoveationLevel FoveationLevel
	{
		get
		{
			return foveationLevel;
		}
		set
		{
			if (value != foveationLevel)
			{
				foveationLevel = value;
			}
		}
	}

	private void SetCameraEnableEditor()
	{
		MonoEyeCamera.enabled = !Pvr_UnitySDKManager.SDK.VRModeEnabled || Pvr_UnitySDKManager.SDK.Monoscopic;
		for (int i = 0; i < Eyes.Length; i++)
		{
			if (Eyes[i].eyeSide == Eye.LeftEye || Eyes[i].eyeSide == Eye.RightEye)
			{
				Eyes[i].eyecamera.enabled = Pvr_UnitySDKManager.SDK.VRModeEnabled;
			}
			else if (Eyes[i].eyeSide == Eye.BothEye)
			{
				Eyes[i].eyecamera.enabled = false;
			}
		}
	}

	private void SetCamerasEnableByStereoRendering()
	{
		MonoEyeCamera.enabled = Pvr_UnitySDKManager.SDK.Monoscopic && Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.MultiPass;
	}

	private void SetupMonoCamera()
	{
		base.transform.localPosition = Vector3.zero;
		MonoEyeCamera.aspect = Pvr_UnitySDKManager.SDK.EyesAspect;
		MonoEyeCamera.rect = new Rect(0f, 0f, 1f, 1f);
	}

	private void SetupUpdate()
	{
		MonoEyeCamera.fieldOfView = Pvr_UnitySDKRender.Instance.EyeVFoV;
		MonoEyeCamera.aspect = Pvr_UnitySDKManager.SDK.EyesAspect;
		MonoEyeTextureID = Pvr_UnitySDKRender.Instance.currEyeTextureIdx;
	}

	private void MonoEyeRender()
	{
		SetupUpdate();
		if (Pvr_UnitySDKRender.Instance.eyeTextures[MonoEyeTextureID] != null)
		{
			Pvr_UnitySDKRender.Instance.eyeTextures[MonoEyeTextureID].DiscardContents();
			MonoEyeCamera.targetTexture = Pvr_UnitySDKRender.Instance.eyeTextures[MonoEyeTextureID];
		}
	}

	private void Awake()
	{
		if (MonoEyeCamera == null)
		{
			MonoEyeCamera = GetComponent<Camera>();
		}
		if (LeftEyeCamera == null)
		{
			LeftEyeCamera = base.gameObject.transform.Find("LeftEye").GetComponent<Camera>();
		}
		if (RightEyeCamera == null)
		{
			RightEyeCamera = base.gameObject.transform.Find("RightEye").GetComponent<Camera>();
		}
		if (BothEyeCamera == null)
		{
			BothEyeCamera = base.gameObject.transform.Find("BothEye").GetComponent<Camera>();
		}
		if (BothEyeCamera != null)
		{
			BothEyeCamera.transform.GetComponent<Pvr_UnitySDKEye>().eyeSide = Eye.BothEye;
		}
		CreateFadeMesh();
		SetCurrentAlpha(0f);
		Render.UPvr_EnableFoveation(enable: true);
		if (foveatedRendering)
		{
			Render.SetFoveatedRenderingLevel(foveationLevel);
		}
		else
		{
			Render.SetFoveatedRenderingLevel((EFoveationLevel)(-1));
		}
		Pvr_UnitySDKManager.eventEnterVRMode = (Func<bool>)Delegate.Combine(Pvr_UnitySDKManager.eventEnterVRMode, new Func<bool>(SetEyeTrackingMode));
	}

	private void OnEnable()
	{
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != this)
		{
			instance = this;
		}
		if (Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.SinglePass)
		{
			Pvr_UnitySDKRender.Instance.StereoRendering.InitEye(BothEyeCamera);
		}
		foreach (Pvr_UnitySDKEyeOverlay instance in Pvr_UnitySDKEyeOverlay.Instances)
		{
			instance.RefreshCamera();
			if (instance.overlayType == Pvr_UnitySDKEyeOverlay.OverlayType.Overlay)
			{
				if (instance.overlayShape == Pvr_UnitySDKEyeOverlay.OverlayShape.Cylinder)
				{
					UnityEngine.Debug.Log("DISFT Cylinder OverLay = Enable");
				}
				if (instance.overlayShape == Pvr_UnitySDKEyeOverlay.OverlayShape.Equirect)
				{
					UnityEngine.Debug.Log("DISFT 360 OverLay= Enable");
				}
				if (instance.overlayShape == Pvr_UnitySDKEyeOverlay.OverlayShape.Quad)
				{
					UnityEngine.Debug.Log("DISFT 2D OverLay= Enable");
				}
			}
			if (instance.overlayType == Pvr_UnitySDKEyeOverlay.OverlayType.Underlay)
			{
				UnityEngine.Debug.Log("DISFT UnderLay= Enable");
			}
		}
		GfxDeviceAdvanceFrameGLES();
		StartCoroutine("EndOfFrame");
		if (screenFade)
		{
			StartCoroutine(ScreenFade(1f, 0f));
		}
		if (GraphicsSettings.renderPipelineAsset != null)
		{
			RenderPipelineManager.endCameraRendering += MyPostRender;
		}
	}

	private void Start()
	{
		SetCamerasEnableByStereoRendering();
		SetupMonoCamera();
	}

	private void Update()
	{
		if (Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.SinglePass)
		{
			for (int i = 0; i < Eyes.Length; i++)
			{
				if (Eyes[i].isActiveAndEnabled && Eyes[i].eyeSide == Eye.BothEye)
				{
					Eyes[i].EyeRender();
				}
			}
		}
		if (Pvr_UnitySDKRender.Instance.StereoRenderPath != 0)
		{
			return;
		}
		if (!Pvr_UnitySDKManager.SDK.Monoscopic)
		{
			for (int j = 0; j < Eyes.Length; j++)
			{
				if (Eyes[j].isActiveAndEnabled && Eyes[j].eyeSide != Eye.BothEye)
				{
					Eyes[j].EyeRender();
				}
			}
		}
		else
		{
			MonoEyeRender();
		}
	}

	private void OnPause()
	{
		Pvr_UnitySDKManager.eventEnterVRMode = (Func<bool>)Delegate.Remove(Pvr_UnitySDKManager.eventEnterVRMode, new Func<bool>(SetEyeTrackingMode));
	}

	public void MyPostRender(ScriptableRenderContext context, Camera camera)
	{
		if (!(camera.gameObject != base.gameObject))
		{
			OnPostRender();
		}
	}

	private void OnDisable()
	{
		StopAllCoroutines();
		if (GraphicsSettings.renderPipelineAsset != null)
		{
			RenderPipelineManager.endCameraRendering -= MyPostRender;
		}
	}

	private void OnDestroy()
	{
		DestoryFadeMesh();
	}

	private void OnPostRender()
	{
		long data = Pvr_UnitySDKAPI.System.UPvr_GetEyeBufferData(Pvr_UnitySDKRender.Instance.eyeTextureIds[Pvr_UnitySDKRender.Instance.currEyeTextureIdx]);
		Pvr_UnitySDKAPI.System.UPvr_UnityEventData(data);
		Pvr_UnitySDKPluginEvent.Issue(RenderEventType.LeftEyeEndFrame);
		Pvr_UnitySDKAPI.System.UPvr_UnityEventData(data);
		Pvr_UnitySDKPluginEvent.Issue(RenderEventType.RightEyeEndFrame);
	}

	private IEnumerator EndOfFrame()
	{
		while (true)
		{
			yield return new WaitForEndOfFrame();
			if (!Pvr_UnitySDKManager.SDK.isEnterVRMode)
			{
				GL.Clear(clearDepth: false, clearColor: true, Color.black);
			}
			if (Pvr_UnitySDKRender.Instance.isFirstStartup && frameNum == WaitSplashScreenFrames)
			{
				Pvr_UnitySDKAPI.System.UPvr_RemovePlatformLogo();
				if (Pvr_UnitySDKManager.SDK.ResetTrackerOnLoad)
				{
					UnityEngine.Debug.Log("Reset Tracker OnLoad");
					Pvr_UnitySDKSensor.Instance.OptionalResetUnitySDKSensor(1, 1);
				}
				Pvr_UnitySDKAPI.System.UPvr_StartVRModel();
				Pvr_UnitySDKRender.Instance.isFirstStartup = false;
			}
			else if (Pvr_UnitySDKRender.Instance.isFirstStartup && frameNum < WaitSplashScreenFrames)
			{
				PLOG.I("frameNum:" + frameNum);
				frameNum++;
			}
			int num = BoundarySystem.UPvr_GetSeeThroughState();
			if (Pvr_UnitySDKEyeOverlay.Instances.Count > 0 && num != 2)
			{
				overlayLayerDepth = 1;
				underlayLayerDepth = 0;
				Pvr_UnitySDKEyeOverlay.Instances.Sort();
				for (int i = 0; i < Pvr_UnitySDKEyeOverlay.Instances.Count; i++)
				{
					compositeLayer = Pvr_UnitySDKEyeOverlay.Instances[i];
					if (!compositeLayer.isActiveAndEnabled || (compositeLayer.layerTextures[0] == null && compositeLayer.layerTextures[1] == null && !compositeLayer.isExternalAndroidSurface) || (compositeLayer.layerTransform != null && !compositeLayer.layerTransform.gameObject.activeSelf))
					{
						continue;
					}
					layerFlags = 0;
					if (compositeLayer.overlayShape == Pvr_UnitySDKEyeOverlay.OverlayShape.Quad || compositeLayer.overlayShape == Pvr_UnitySDKEyeOverlay.OverlayShape.Cylinder)
					{
						if (compositeLayer.overlayType == Pvr_UnitySDKEyeOverlay.OverlayType.Overlay)
						{
							isHeadLocked = false;
							if (compositeLayer.layerTransform != null && compositeLayer.layerTransform.parent == base.transform)
							{
								isHeadLocked = true;
							}
							if (compositeLayer.isExternalAndroidSurface)
							{
								layerFlags |= 1;
								CreateExternalSurface(compositeLayer, overlayLayerDepth);
							}
							Render.UPvr_SetOverlayModelViewMatrix((int)compositeLayer.overlayType, (int)compositeLayer.overlayShape, compositeLayer.layerTextureIds[0], 0, overlayLayerDepth, isHeadLocked, layerFlags, compositeLayer.MVMatrixs[0], compositeLayer.ModelScales[0], compositeLayer.ModelRotations[0], compositeLayer.ModelTranslations[0], compositeLayer.CameraRotations[0], compositeLayer.CameraTranslations[0], compositeLayer.GetLayerColorScale(), compositeLayer.GetLayerColorOffset());
							Render.UPvr_SetOverlayModelViewMatrix((int)compositeLayer.overlayType, (int)compositeLayer.overlayShape, compositeLayer.layerTextureIds[1], 1, overlayLayerDepth, isHeadLocked, layerFlags, compositeLayer.MVMatrixs[1], compositeLayer.ModelScales[1], compositeLayer.ModelRotations[1], compositeLayer.ModelTranslations[1], compositeLayer.CameraRotations[1], compositeLayer.CameraTranslations[1], compositeLayer.GetLayerColorScale(), compositeLayer.GetLayerColorOffset());
							overlayLayerDepth++;
						}
						else if (compositeLayer.overlayType == Pvr_UnitySDKEyeOverlay.OverlayType.Underlay)
						{
							if (compositeLayer.isExternalAndroidSurface)
							{
								layerFlags |= 1;
								CreateExternalSurface(compositeLayer, underlayLayerDepth);
							}
							Render.UPvr_SetOverlayModelViewMatrix((int)compositeLayer.overlayType, (int)compositeLayer.overlayShape, compositeLayer.layerTextureIds[0], 0, underlayLayerDepth, isHeadLocked: false, layerFlags, compositeLayer.MVMatrixs[0], compositeLayer.ModelScales[0], compositeLayer.ModelRotations[0], compositeLayer.ModelTranslations[0], compositeLayer.CameraRotations[0], compositeLayer.CameraTranslations[0], compositeLayer.GetLayerColorScale(), compositeLayer.GetLayerColorOffset());
							Render.UPvr_SetOverlayModelViewMatrix((int)compositeLayer.overlayType, (int)compositeLayer.overlayShape, compositeLayer.layerTextureIds[1], 1, underlayLayerDepth, isHeadLocked: false, layerFlags, compositeLayer.MVMatrixs[1], compositeLayer.ModelScales[1], compositeLayer.ModelRotations[1], compositeLayer.ModelTranslations[1], compositeLayer.CameraRotations[1], compositeLayer.CameraTranslations[1], compositeLayer.GetLayerColorScale(), compositeLayer.GetLayerColorOffset());
							underlayLayerDepth++;
						}
					}
					else if (compositeLayer.overlayShape == Pvr_UnitySDKEyeOverlay.OverlayShape.Equirect)
					{
						if (compositeLayer.isExternalAndroidSurface)
						{
							layerFlags |= 1;
							CreateExternalSurface(compositeLayer, 0);
						}
						Render.UPvr_SetupLayerData(0, 0, compositeLayer.layerTextureIds[0], (int)compositeLayer.overlayShape, layerFlags, compositeLayer.GetLayerColorScale(), compositeLayer.GetLayerColorOffset());
						Render.UPvr_SetupLayerData(0, 1, compositeLayer.layerTextureIds[1], (int)compositeLayer.overlayShape, layerFlags, compositeLayer.GetLayerColorScale(), compositeLayer.GetLayerColorOffset());
					}
				}
			}
			Pvr_UnitySDKAPI.System.UPvr_UnityEventData(Pvr_UnitySDKAPI.System.UPvr_GetEyeBufferData(0));
			Pvr_UnitySDKPluginEvent.Issue(RenderEventType.TimeWarp);
			Pvr_UnitySDKRender.Instance.currEyeTextureIdx = Pvr_UnitySDKRender.Instance.nextEyeTextureIdx;
			Pvr_UnitySDKRender.Instance.nextEyeTextureIdx = (Pvr_UnitySDKRender.Instance.nextEyeTextureIdx + 1) % 3;
		}
	}

	private void CreateExternalSurface(Pvr_UnitySDKEyeOverlay overlayInstance, int layerDepth)
	{
		if (overlayInstance.externalAndroidSurfaceObject == IntPtr.Zero)
		{
			overlayInstance.externalAndroidSurfaceObject = Render.UPvr_CreateLayerAndroidSurface((int)overlayInstance.overlayType, layerDepth);
			UnityEngine.Debug.LogFormat("CreateExternalSurface: Overlay Type:{0}, LayerDepth:{1}, SurfaceObject:{2}", overlayInstance.overlayType, layerDepth, overlayInstance.externalAndroidSurfaceObject);
			if (overlayInstance.externalAndroidSurfaceObject != IntPtr.Zero && overlayInstance.externalAndroidSurfaceObjectCreated != null)
			{
				overlayInstance.externalAndroidSurfaceObjectCreated();
			}
		}
	}

	public bool SetEyeTrackingMode()
	{
		supportEyeTracking = (Pvr_UnitySDKAPI.System.UPvr_GetTrackingMode() & 4) != 0;
		bool result = false;
		if (EyeTracking && supportEyeTracking)
		{
			result = Pvr_UnitySDKAPI.System.UPvr_setTrackingMode(6);
		}
		UnityEngine.Debug.Log("SetEyeTrackingMode EyeTracking " + EyeTracking + " supportEyeTracking " + supportEyeTracking + " result " + result);
		return result;
	}

	public Vector3 GetEyeTrackingPos()
	{
		if (!Instance.EyeTracking)
		{
			return Vector3.zero;
		}
		bool flag = Pvr_UnitySDKAPI.System.UPvr_getEyeTrackingData(ref eyePoseData);
		if (!flag)
		{
			PLOG.E("UPvr_getEyeTrackingData failed " + flag);
			return Vector3.zero;
		}
		EyeDeviceInfo deviceInfo = GetDeviceInfo();
		Vector3 zero = Vector3.zero;
		zero.x = 0.5f * (deviceInfo.targetFrustumLeft.right - deviceInfo.targetFrustumLeft.left);
		zero.y = 0.5f * (deviceInfo.targetFrustumLeft.top - deviceInfo.targetFrustumLeft.bottom);
		zero.z = deviceInfo.targetFrustumLeft.near;
		Vector3 foveatedGazeDirection = eyePoseData.foveatedGazeDirection;
		float num = Vector3.Dot(foveatedGazeDirection, Vector3.forward);
		if (num > float.Epsilon)
		{
			eyePoint = foveatedGazeDirection * (zero.z / num);
			eyePoint.x /= zero.x;
			eyePoint.y /= zero.y;
		}
		return eyePoint;
	}

	private EyeDeviceInfo GetDeviceInfo()
	{
		float num = Mathf.Tan(Pvr_UnitySDKRender.Instance.EyeVFoV / 2f * ((float)Math.PI / 180f));
		float num2 = Mathf.Tan(Pvr_UnitySDKRender.Instance.EyeHFoV / 2f * ((float)Math.PI / 180f));
		EyeDeviceInfo result = default(EyeDeviceInfo);
		result.targetFrustumLeft.left = 0f - LeftEyeCamera.nearClipPlane * num2;
		result.targetFrustumLeft.right = LeftEyeCamera.nearClipPlane * num2;
		result.targetFrustumLeft.top = LeftEyeCamera.nearClipPlane * num;
		result.targetFrustumLeft.bottom = 0f - LeftEyeCamera.nearClipPlane * num;
		result.targetFrustumLeft.near = LeftEyeCamera.nearClipPlane;
		result.targetFrustumLeft.far = LeftEyeCamera.farClipPlane;
		result.targetFrustumRight.left = 0f - RightEyeCamera.nearClipPlane * num2;
		result.targetFrustumRight.right = RightEyeCamera.nearClipPlane * num2;
		result.targetFrustumRight.top = RightEyeCamera.nearClipPlane * num;
		result.targetFrustumRight.bottom = 0f - RightEyeCamera.nearClipPlane * num;
		result.targetFrustumRight.near = RightEyeCamera.nearClipPlane;
		result.targetFrustumRight.far = RightEyeCamera.farClipPlane;
		return result;
	}

	private void CreateFadeMesh()
	{
		fadeMaterial = new Material(Shader.Find("Pvr_UnitySDK/Fade"));
		fadeMeshFilter = base.gameObject.AddComponent<MeshFilter>();
		fadeMeshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		fadeMeshFilter.mesh = mesh;
		Vector3[] array = new Vector3[4];
		float num = 2f;
		float num2 = 2f;
		float z = 1f;
		array[0] = new Vector3(0f - num, 0f - num2, z);
		array[1] = new Vector3(num, 0f - num2, z);
		array[2] = new Vector3(0f - num, num2, z);
		array[3] = new Vector3(num, num2, z);
		mesh.vertices = array;
		mesh.triangles = new int[6] { 0, 2, 1, 2, 3, 1 };
		mesh.normals = new Vector3[4]
		{
			-Vector3.forward,
			-Vector3.forward,
			-Vector3.forward,
			-Vector3.forward
		};
		mesh.uv = new Vector2[4]
		{
			new Vector2(0f, 0f),
			new Vector2(1f, 0f),
			new Vector2(0f, 1f),
			new Vector2(1f, 1f)
		};
	}

	private void DestoryFadeMesh()
	{
		if (fadeMeshRenderer != null)
		{
			UnityEngine.Object.Destroy(fadeMeshRenderer);
		}
		if (fadeMaterial != null)
		{
			UnityEngine.Object.Destroy(fadeMaterial);
		}
		if (fadeMeshFilter != null)
		{
			UnityEngine.Object.Destroy(fadeMeshFilter);
		}
	}

	public void SetCurrentAlpha(float alpha)
	{
		currentAlpha = alpha;
		SetMaterialAlpha();
	}

	private IEnumerator ScreenFade(float startAlpha, float endAlpha)
	{
		float elapsedTime = 0f;
		while (elapsedTime < fadeTime)
		{
			elapsedTime += Time.deltaTime;
			nowFadeAlpha = Mathf.Lerp(startAlpha, endAlpha, Mathf.Clamp01(elapsedTime / fadeTime));
			SetMaterialAlpha();
			yield return new WaitForEndOfFrame();
		}
	}

	private void SetMaterialAlpha()
	{
		Color color = fadeColor;
		color.a = Mathf.Max(currentAlpha, nowFadeAlpha);
		isFading = color.a > 0f;
		if (fadeMaterial != null)
		{
			fadeMaterial.color = color;
			fadeMaterial.renderQueue = renderQueue;
			fadeMeshRenderer.material = fadeMaterial;
			fadeMeshRenderer.enabled = isFading;
		}
	}

	public bool GfxDeviceAdvanceFrameGLES()
	{
		MethodInfo[] methods = typeof(AndroidDevice).GetMethods();
		foreach (MethodInfo methodInfo in methods)
		{
			if (methodInfo.Name == "VRDeviceUseOwnSurface")
			{
				PLOG.I("Use VRDeviceUseOwnSurface");
				methodInfo.Invoke(null, null);
				return true;
			}
		}
		return false;
	}
}
public class Pvr_UnitySDKEyeOverlay : MonoBehaviour, IComparable<Pvr_UnitySDKEyeOverlay>
{
	public delegate void ExternalAndroidSurfaceObjectCreated();

	public enum OverlayShape
	{
		Quad,
		Cylinder,
		Equirect
	}

	public enum OverlayType
	{
		Overlay,
		Underlay
	}

	public enum OverlayTexFilterMode
	{
		NotCare,
		Nearest,
		Linear,
		Nearest_Mipmap_Nearest,
		Linear_Mipmap_Nearest,
		Nearest_Mipmap_Linear,
		Linear_Mipmap_Linear
	}

	public static List<Pvr_UnitySDKEyeOverlay> Instances = new List<Pvr_UnitySDKEyeOverlay>();

	public int layerIndex;

	public OverlayType overlayType;

	public OverlayShape overlayShape;

	public Transform layerTransform;

	public Texture[] layerTextures = new Texture[2];

	public int[] layerTextureIds = new int[2];

	public Matrix4x4[] MVMatrixs = new Matrix4x4[2];

	public Vector3[] ModelScales = new Vector3[2];

	public Quaternion[] ModelRotations = new Quaternion[2];

	public Vector3[] ModelTranslations = new Vector3[2];

	public Quaternion[] CameraRotations = new Quaternion[2];

	public Vector3[] CameraTranslations = new Vector3[2];

	public Camera[] layerEyeCamera = new Camera[2];

	public bool overrideColorScaleAndOffset;

	public Vector4 colorScale = Vector4.one;

	public Vector4 colorOffset = Vector4.zero;

	private Vector4 overlayLayerColorScaleDefault = Vector4.one;

	private Vector4 overlayLayerColorOffsetDefault = Vector4.zero;

	public bool isExternalAndroidSurface;

	public IntPtr externalAndroidSurfaceObject = IntPtr.Zero;

	public ExternalAndroidSurfaceObjectCreated externalAndroidSurfaceObjectCreated;

	public int CompareTo(Pvr_UnitySDKEyeOverlay other)
	{
		return layerIndex.CompareTo(other.layerIndex);
	}

	private void Awake()
	{
		Instances.Add(this);
		if (Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.SinglePass)
		{
			layerEyeCamera[0] = Pvr_UnitySDKEyeManager.Instance.BothEyeCamera;
			layerEyeCamera[1] = Pvr_UnitySDKEyeManager.Instance.BothEyeCamera;
		}
		else if (Pvr_UnitySDKManager.SDK.Monoscopic)
		{
			layerEyeCamera[0] = Pvr_UnitySDKEyeManager.Instance.MonoEyeCamera;
			layerEyeCamera[1] = Pvr_UnitySDKEyeManager.Instance.MonoEyeCamera;
		}
		else
		{
			layerEyeCamera[0] = Pvr_UnitySDKEyeManager.Instance.LeftEyeCamera;
			layerEyeCamera[1] = Pvr_UnitySDKEyeManager.Instance.RightEyeCamera;
		}
		layerTransform = GetComponent<Transform>();
		if (layerTransform != null)
		{
			MeshRenderer component = layerTransform.GetComponent<MeshRenderer>();
			if (component != null)
			{
				component.enabled = false;
			}
		}
		InitializeBuffer();
	}

	private void LateUpdate()
	{
		UpdateCoords();
	}

	private void OnDestroy()
	{
		Instances.Remove(this);
	}

	public void RefreshCamera()
	{
		if (Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.SinglePass)
		{
			layerEyeCamera[0] = Pvr_UnitySDKEyeManager.Instance.BothEyeCamera;
			layerEyeCamera[1] = Pvr_UnitySDKEyeManager.Instance.BothEyeCamera;
		}
		else if (Pvr_UnitySDKManager.SDK.Monoscopic)
		{
			layerEyeCamera[0] = Pvr_UnitySDKEyeManager.Instance.MonoEyeCamera;
			layerEyeCamera[1] = Pvr_UnitySDKEyeManager.Instance.MonoEyeCamera;
		}
		else
		{
			layerEyeCamera[0] = Pvr_UnitySDKEyeManager.Instance.LeftEyeCamera;
			layerEyeCamera[1] = Pvr_UnitySDKEyeManager.Instance.RightEyeCamera;
		}
	}

	private void InitializeBuffer()
	{
		OverlayShape overlayShape = this.overlayShape;
		if ((uint)overlayShape > 2u)
		{
			return;
		}
		for (int i = 0; i < layerTextureIds.Length; i++)
		{
			if (layerTextures[i] != null)
			{
				layerTextureIds[i] = layerTextures[i].GetNativeTexturePtr().ToInt32();
			}
			else
			{
				UnityEngine.Debug.LogWarning($"{(Eye)i} Texture is null!");
			}
		}
	}

	private void UpdateCoords()
	{
		if (layerTransform == null || !layerTransform.gameObject.activeSelf || layerEyeCamera[0] == null || layerEyeCamera[1] == null)
		{
			return;
		}
		for (int i = 0; i < MVMatrixs.Length; i++)
		{
			if (Pvr_UnitySDKRender.Instance.StereoRenderPath == StereoRenderingPathPico.SinglePass)
			{
				Matrix4x4[] stereoWorldToCameraMat = Pvr_UnitySDKSinglePass.GetStereoWorldToCameraMat();
				MVMatrixs[i] = stereoWorldToCameraMat[i] * layerTransform.localToWorldMatrix;
			}
			else
			{
				MVMatrixs[i] = layerEyeCamera[i].worldToCameraMatrix * layerTransform.localToWorldMatrix;
			}
			ModelScales[i] = layerTransform.localScale;
			ModelRotations[i] = layerTransform.rotation;
			ModelTranslations[i] = layerTransform.position;
			CameraRotations[i] = layerEyeCamera[i].transform.rotation;
			CameraTranslations[i] = layerEyeCamera[i].transform.position;
		}
	}

	public void SetTexture(Texture texture)
	{
		for (int i = 0; i < layerTextures.Length; i++)
		{
			layerTextures[i] = texture;
		}
		InitializeBuffer();
	}

	public void SetLayerColorScaleAndOffset(Vector4 scale, Vector4 offset)
	{
		colorScale = scale;
		colorOffset = offset;
	}

	public Vector4 GetLayerColorScale()
	{
		if (!overrideColorScaleAndOffset)
		{
			return overlayLayerColorScaleDefault;
		}
		return colorScale;
	}

	public Vector4 GetLayerColorOffset()
	{
		if (!overrideColorScaleAndOffset)
		{
			return overlayLayerColorOffsetDefault;
		}
		return colorOffset;
	}
}
public class Pvr_UnitySDKRender
{
	private static Pvr_UnitySDKRender instance;

	public AndroidJavaObject activity;

	public static AndroidJavaClass javaVrActivityClass;

	public static AndroidJavaClass javaSysActivityClass;

	public static AndroidJavaClass javaserviceClass;

	public static AndroidJavaClass javaVrActivityLongReceiver;

	public static AndroidJavaClass javaVrActivityClientClass;

	private bool canConnecttoActivity;

	private bool isInitrenderThread = true;

	private string model;

	private Vector2 prefinger1 = new Vector2(0f, 0f);

	private Vector2 prefinger2 = new Vector2(0f, 0f);

	public int eyeTextureCount = 6;

	public RenderTexture[] eyeTextures;

	public int[] eyeTextureIds;

	public int currEyeTextureIdx;

	public int nextEyeTextureIdx = 1;

	public int lastEyeTextureIdx;

	public bool isSwitchSDK;

	public int RenderviewNumber;

	public bool isFirstStartup = true;

	public bool isShellMode;

	private StereoRenderingPathPico stereoRenderPath;

	private float rtScaleFactor = 1f;

	private float eyeVFov = 90f;

	private float eyeHFov = 90f;

	public static Pvr_UnitySDKRender Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new Pvr_UnitySDKRender();
			}
			return instance;
		}
		set
		{
			instance = value;
		}
	}

	public StereoRenderingPathPico StereoRenderPath => stereoRenderPath;

	public SDKStereoRendering StereoRendering { get; private set; }

	public float RtScaleFactor
	{
		get
		{
			return rtScaleFactor;
		}
		set
		{
			if (value != rtScaleFactor)
			{
				rtScaleFactor = value;
				ReCreateEyeBuffer();
			}
		}
	}

	public float EyeVFoV
	{
		get
		{
			return eyeVFov;
		}
		set
		{
			if (value != eyeVFov)
			{
				eyeVFov = value;
			}
		}
	}

	public float EyeHFoV
	{
		get
		{
			return eyeHFov;
		}
		set
		{
			if (value != eyeHFov)
			{
				eyeHFov = value;
			}
		}
	}

	public Pvr_UnitySDKRender()
	{
		if (!canConnecttoActivity)
		{
			ConnectToAndriod();
			PLOG.I("PvrLog Init Render Ability Success!");
			isInitrenderThread = false;
		}
		Init();
	}

	public void ConnectToAndriod()
	{
		try
		{
			UnityEngine.Debug.Log("PvrLog SDK Version :  " + Pvr_UnitySDKAPI.System.UPvr_GetSDKVersion().ToString() + "  Unity Script Version :" + Pvr_UnitySDKAPI.System.UPvr_GetUnitySDKVersion().ToString());
			AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			activity = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
			javaVrActivityClass = new AndroidJavaClass("com.psmart.vrlib.VrActivity");
			javaserviceClass = new AndroidJavaClass("com.picovr.picovrlib.hummingbirdclient.UnityClient");
			javaVrActivityLongReceiver = new AndroidJavaClass("com.psmart.vrlib.HomeKeyReceiver");
			javaSysActivityClass = new AndroidJavaClass("com.psmart.aosoperation.SysActivity");
			javaVrActivityClientClass = new AndroidJavaClass("com.psmart.vrlib.PvrClient");
			Pvr_UnitySDKAPI.System.Pvr_SetInitActivity(activity.GetRawObject(), javaVrActivityClass.GetRawClass());
			model = javaVrActivityClass.CallStatic<string>("Pvr_GetBuildModel", Array.Empty<object>());
			double[] result = new double[5];
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, javaVrActivityClass, "getDPIParameters", activity);
			int res = -1;
			Render.UPvr_GetIntConfig(4, ref res);
			string result2 = "";
			Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result2, javaserviceClass, "getSysproc", "persist.pvr.debug.appfps");
			if (result2 != "")
			{
				Pvr_UnitySDKManager.SDK.systemFPS = Convert.ToBoolean(Convert.ToInt16(result2));
			}
			if (res == 0)
			{
				Render.UPvr_ChangeScreenParameters(model, (int)result[0], (int)result[1], result[2], result[3], result[4]);
				Screen.sleepTimeout = -1;
			}
			if (Pvr_UnitySDKAPI.System.UPvr_IsPicoActivity())
			{
				UnityEngine.Debug.Log("ConnectToAndriod set monoPresentation success ?-------------" + Pvr_UnitySDKAPI.System.UPvr_SetMonoPresentation());
				UnityEngine.Debug.Log("ConnectToAndriod presentation existed ?-------------" + Pvr_UnitySDKAPI.System.UPvr_IsPresentationExisted());
			}
			isShellMode = GetIsShellMode();
			UnityEngine.Debug.Log("ConnectToAndriod isShellMode ?-------------" + isShellMode);
		}
		catch (AndroidJavaException ex)
		{
			PLOG.E("ConnectToAndriod--catch" + ex.Message);
		}
		canConnecttoActivity = true;
	}

	public void Init()
	{
		if (InitRenderAbility())
		{
			UnityEngine.Debug.Log("PvrLog Init Render Ability Success!");
			isInitrenderThread = false;
		}
		else
		{
			UnityEngine.Debug.Log("PvrLog Init Render Ability Failed!");
		}
	}

	private bool InitRenderAbility()
	{
		if (UpdateRenderParaFrame() && CreateEyeBuffer())
		{
			float num = Pvr_UnitySDKAPI.System.UPvr_GetIPD();
			Pvr_UnitySDKManager.SDK.leftEyeOffset = new Vector3((0f - num) / 2f, 0f, 0f);
			Pvr_UnitySDKManager.SDK.rightEyeOffset = new Vector3(num / 2f, 0f, 0f);
			return true;
		}
		return false;
	}

	private bool UpdateRenderParaFrame()
	{
		EyeVFoV = GetEyeVFOV();
		EyeHFoV = GetEyeHFOV();
		Pvr_UnitySDKManager.SDK.EyesAspect = EyeHFoV / EyeVFoV;
		return true;
	}

	private bool CreateEyeBuffer()
	{
		Vector2 eyeBufferResolution = GetEyeBufferResolution();
		if (isFirstStartup)
		{
			InitSinglePass();
			Pvr_UnitySDKAPI.System.UPvr_SetSinglePassDepthBufferWidthHeight((int)eyeBufferResolution.x, (int)eyeBufferResolution.y);
		}
		eyeTextures = new RenderTexture[eyeTextureCount];
		eyeTextureIds = new int[eyeTextureCount];
		for (int i = 0; i < eyeTextureCount; i++)
		{
			if (null == eyeTextures[i])
			{
				try
				{
					ConfigureEyeBuffer(i, eyeBufferResolution);
				}
				catch (Exception ex)
				{
					PLOG.E("ConfigureEyeBuffer ERROR " + ex.Message);
					throw;
				}
			}
			if (!eyeTextures[i].IsCreated())
			{
				eyeTextures[i].Create();
				eyeTextureIds[i] = eyeTextures[i].GetNativeTexturePtr().ToInt32();
			}
			eyeTextureIds[i] = eyeTextures[i].GetNativeTexturePtr().ToInt32();
		}
		return true;
	}

	private void InitSinglePass()
	{
		bool flag = true;
		if (GraphicsSettings.renderPipelineAsset != null)
		{
			flag = false;
			if (!BoundarySystem.UPvr_EnableLWRP(enable: true))
			{
				UnityEngine.Debug.Log("UPvr_EnableLWRP return false");
			}
			Vector2 eyeBufferResolution = GetEyeBufferResolution();
			if (!BoundarySystem.UPvr_SetViewportSize((int)eyeBufferResolution.x, (int)eyeBufferResolution.y))
			{
				UnityEngine.Debug.Log("UPvr_SetViewportSize return false");
			}
		}
		if (Pvr_UnitySDKProjectSetting.GetProjectConfig().usesinglepass)
		{
			bool flag2 = false;
			if (flag)
			{
				flag2 = Pvr_UnitySDKAPI.System.UPvr_EnableSinglePass(enable: true);
			}
			if (flag2)
			{
				StereoRendering = new Pvr_UnitySDKSinglePass();
				stereoRenderPath = StereoRenderingPathPico.SinglePass;
				eyeTextureCount = 3;
			}
			UnityEngine.Debug.Log("EnableSinglePass supportSinglePass " + flag + " result " + flag2);
		}
	}

	public float GetEyeVFOV()
	{
		float res = 102f;
		try
		{
			Render.UPvr_GetFloatConfig(1, ref res);
			if (res <= 0f)
			{
				res = 102f;
			}
		}
		catch (Exception ex)
		{
			PLOG.E("GetEyeVFOV ERROR! " + ex.Message);
			throw;
		}
		return res;
	}

	public float GetEyeHFOV()
	{
		float res = 102f;
		try
		{
			Render.UPvr_GetFloatConfig(2, ref res);
			if (res <= 0f)
			{
				res = 102f;
			}
		}
		catch (Exception ex)
		{
			PLOG.E("GetEyeHFOV ERROR! " + ex.Message);
			throw;
		}
		return res;
	}

	private void ConfigureEyeBuffer(int eyeTextureIndex, Vector2 resolution)
	{
		int width = (int)resolution.x;
		int height = (int)resolution.y;
		eyeTextures[eyeTextureIndex] = new RenderTexture(width, height, (int)Pvr_UnitySDKProjectSetting.GetProjectConfig().rtBitDepth, Pvr_UnitySDKProjectSetting.GetProjectConfig().rtFormat);
		if (StereoRenderPath == StereoRenderingPathPico.MultiPass)
		{
			eyeTextures[eyeTextureIndex].anisoLevel = 0;
			eyeTextures[eyeTextureIndex].antiAliasing = Mathf.Max(QualitySettings.antiAliasing, (int)Pvr_UnitySDKProjectSetting.GetProjectConfig().rtAntiAlising);
			UnityEngine.Debug.Log("MultiPass ConfigureEyeBuffer eyeTextureIndex " + eyeTextureIndex);
		}
		else if (StereoRenderPath == StereoRenderingPathPico.SinglePass)
		{
			eyeTextures[eyeTextureIndex].useMipMap = false;
			eyeTextures[eyeTextureIndex].wrapMode = TextureWrapMode.Clamp;
			eyeTextures[eyeTextureIndex].filterMode = FilterMode.Bilinear;
			eyeTextures[eyeTextureIndex].anisoLevel = 1;
			eyeTextures[eyeTextureIndex].dimension = TextureDimension.Tex2DArray;
			eyeTextures[eyeTextureIndex].volumeDepth = 2;
			UnityEngine.Debug.Log("SinglePass ConfigureEyeBuffer eyeTextureIndex " + eyeTextureIndex);
		}
		eyeTextures[eyeTextureIndex].Create();
		if (eyeTextures[eyeTextureIndex].IsCreated())
		{
			eyeTextureIds[eyeTextureIndex] = eyeTextures[eyeTextureIndex].GetNativeTexturePtr().ToInt32();
			UnityEngine.Debug.Log("eyeTextureIndex : " + eyeTextureIndex);
		}
	}

	public bool ReCreateEyeBuffer()
	{
		if (!Pvr_UnitySDKProjectSetting.GetProjectConfig().usedefaultRenderTexture)
		{
			for (int i = 0; i < eyeTextureCount; i++)
			{
				if (eyeTextures[i] != null)
				{
					eyeTextures[i].Release();
				}
			}
			Array.Clear(eyeTextures, 0, eyeTextures.Length);
			return CreateEyeBuffer();
		}
		return false;
	}

	public void ReInit()
	{
		if (canConnecttoActivity && isInitrenderThread)
		{
			Init();
		}
	}

	public void IssueRenderThread()
	{
		if (canConnecttoActivity && !isInitrenderThread)
		{
			switch (QualitySettings.activeColorSpace)
			{
			case ColorSpace.Gamma:
				Render.UPvr_SetColorspaceType(0);
				break;
			case ColorSpace.Linear:
				Render.UPvr_SetColorspaceType(1);
				break;
			}
			Pvr_UnitySDKPluginEvent.Issue(RenderEventType.InitRenderThread);
			isInitrenderThread = true;
			if (StereoRendering != null)
			{
				StereoRendering.OnSDKRenderInited();
			}
			UnityEngine.Debug.Log("PvrLog IssueRenderThread end");
		}
		else
		{
			PLOG.I("PvrLog IssueRenderThread  canConnecttoActivity = " + canConnecttoActivity);
		}
	}

	private void AutoAdpatForPico1s()
	{
		Vector2 position = Input.touches[0].position;
		Vector2 position2 = Input.touches[1].position;
		if (Vector2.Distance(prefinger1, position) > 2f && Vector2.Distance(prefinger2, position2) > 2f)
		{
			float midH = (Input.touches[0].position.x + Input.touches[1].position.x) / (float)Screen.width - 1f;
			float midV = (Input.touches[0].position.y + Input.touches[1].position.y) / (float)Screen.height - 1f;
			Render.UPvr_SetRatio(midH, midV);
		}
		prefinger1 = position;
		prefinger2 = position2;
	}

	public Vector2 GetEyeBufferResolution()
	{
		int res = 1024;
		int res2 = 1024;
		if (Pvr_UnitySDKProjectSetting.GetProjectConfig().usedefaultRenderTexture)
		{
			try
			{
				Render.UPvr_GetIntConfig(0, ref res);
				Render.UPvr_GetIntConfig(1, ref res2);
			}
			catch (Exception ex)
			{
				PLOG.E("GetEyeBufferResolution ERROR! " + ex.Message);
				throw;
			}
		}
		else
		{
			res = (int)(Pvr_UnitySDKProjectSetting.GetProjectConfig().customRTSize.x * RtScaleFactor);
			res2 = (int)(Pvr_UnitySDKProjectSetting.GetProjectConfig().customRTSize.y * RtScaleFactor);
		}
		Vector2 vector = new Vector2(res, res2);
		UnityEngine.Debug.Log(string.Concat("DISFT Customize RenderTexture:", vector, ", scaleFactor: ", RtScaleFactor));
		return vector;
	}

	public bool GetUsePredictedMatrix()
	{
		return true;
	}

	public bool GetIsShellMode()
	{
		if (activity == null)
		{
			return false;
		}
		using (AndroidJavaObject androidJavaObject = activity.Call<AndroidJavaObject>("getPackageManager", Array.Empty<object>()).Call<AndroidJavaObject>("getApplicationInfo", new object[2]
		{
			activity.Call<string>("getPackageName", Array.Empty<object>()),
			128
		}))
		{
			AndroidJavaObject androidJavaObject2 = androidJavaObject.Get<AndroidJavaObject>("metaData");
			if (androidJavaObject2 != null)
			{
				if (androidJavaObject2.Call<int>("getInt", new object[1] { "shell_mode" }) == 1)
				{
					return true;
				}
				return false;
			}
		}
		return false;
	}
}
public class Pvr_UnitySDKSinglePass : SDKStereoRendering
{
	private static Camera bothCamera;

	private Matrix4x4[] unity_StereoMatrixP = new Matrix4x4[2];

	private Matrix4x4[] unity_StereoMatrixInvP = new Matrix4x4[2];

	private static Matrix4x4[] unity_StereoWorldToCamera = new Matrix4x4[2];

	private Matrix4x4[] unity_StereoCameraToWorld = new Matrix4x4[2];

	private Matrix4x4[] unity_StereoMatrixVP = new Matrix4x4[2];

	private Vector3[] eyesOffset = new Vector3[2];

	private static Matrix4x4[] eyesOffsetMatrix = new Matrix4x4[2];

	private CommandBuffer commandBufferBeforeForwardOpaque;

	private CommandBuffer commandBufferBeforeSkybox;

	private CommandBuffer commandBufferAfterSkybox;

	public override void InitEye(Camera eye)
	{
		bothCamera = eye;
		bothCamera.stereoSeparation = 0.0625f;
		bothCamera.stereoConvergence = 0f;
		bothCamera.allowHDR = false;
		bothCamera.allowDynamicResolution = false;
		SetEyesPosition();
		SetEyeProjection();
		Pvr_UnitySDKSensor.EyeFovChanged = (Action)Delegate.Combine(Pvr_UnitySDKSensor.EyeFovChanged, new Action(SetEyeProjection));
		UnityEngine.Debug.Log("SinglePass Init success! CameraName = " + eye.transform.name + " eye.eyeSide " + eye.GetComponent<Pvr_UnitySDKEye>().eyeSide);
	}

	public override void OnSDKRenderInited()
	{
		OnSDKRenderInited_SinglePass();
	}

	public override void OnSDKPreRender()
	{
		SinglePassPreRender();
	}

	public override void OnSDKPostRender()
	{
		SwitchKeywordAndDeviceView(enable: false);
	}

	public void OnSDKRenderInited_SinglePass()
	{
		Shader.SetGlobalVectorArray("unity_StereoScaleOffset", new Vector4[2]
		{
			new Vector4(1f, 1f, 0f, 0f),
			new Vector4(1f, 1f, 0.5f, 0f)
		});
		SetAntiAliasing();
		UnityEngine.Debug.Log("OnSDKRenderInited_SinglePass");
	}

	private void SetAntiAliasing()
	{
		int num = Mathf.Max(QualitySettings.antiAliasing, (int)Pvr_UnitySDKProjectSetting.GetProjectConfig().rtAntiAlising);
		Pvr_UnitySDKAPI.System.UPvr_SetAntiAliasing(num);
		UnityEngine.Debug.Log("SetAntiAliasing  antiAliasing = " + num);
	}

	public void SetEyesPosition()
	{
		float res = 0.0625f;
		int configsenum = 0;
		if (Render.UPvr_GetFloatConfig(configsenum, ref res) != 0)
		{
			PLOG.E("Cannot get ipd");
			res = 0.0625f;
		}
		bothCamera.stereoSeparation = res;
		Vector3 vector = new Vector3((0f - res) / 2f, 0f, 0f);
		Vector3 vector2 = new Vector3(res / 2f, 0f, 0f);
		Vector3 vector3 = (vector + vector2) / 2f;
		bothCamera.transform.localPosition = vector3;
		bothCamera.transform.localRotation = Quaternion.identity;
		Vector3 vector4 = vector - vector3;
		Vector3 vector5 = vector2 - vector3;
		eyesOffset[0] = vector4;
		eyesOffset[1] = vector5;
		eyesOffsetMatrix[0] = Matrix4x4.TRS(vector4, Quaternion.identity, Vector3.one);
		eyesOffsetMatrix[1] = Matrix4x4.TRS(vector5, Quaternion.identity, Vector3.one);
	}

	public void SetEyeProjection()
	{
		Matrix4x4 projection = GetProjection(bothCamera.nearClipPlane, bothCamera.farClipPlane);
		Matrix4x4 projection2 = GetProjection(bothCamera.nearClipPlane, bothCamera.farClipPlane);
		SetStereoProjectionMatrix(projection, projection2);
	}

	private static Matrix4x4 GetProjection(float near, float far)
	{
		if (near < 0.01f)
		{
			near = 0.01f;
		}
		if (far < 0.02f)
		{
			far = 0.02f;
		}
		_ = Matrix4x4.identity;
		return MakeProjection(near, far);
	}

	public static Matrix4x4 MakeProjection(float n, float f)
	{
		Vector2 eyeBufferResolution = Pvr_UnitySDKRender.Instance.GetEyeBufferResolution();
		float num = Mathf.Tan(Pvr_UnitySDKRender.Instance.EyeVFoV / 2f * ((float)Math.PI / 180f));
		float num2 = 1f / num;
		Matrix4x4 zero = Matrix4x4.zero;
		zero[0, 0] = num2 / (eyeBufferResolution.x / eyeBufferResolution.y);
		zero[1, 1] = num2;
		zero[2, 2] = (0f - (f + n)) / (f - n);
		zero[2, 3] = -2f * f * n / (f - n);
		zero[3, 2] = -1f;
		return zero;
	}

	public void SetStereoProjectionMatrix(Matrix4x4 left, Matrix4x4 right)
	{
		unity_StereoMatrixP[0] = left;
		unity_StereoMatrixInvP[0] = left.inverse;
		unity_StereoMatrixP[1] = right;
		unity_StereoMatrixInvP[1] = right.inverse;
	}

	private void SwitchKeywordAndDeviceView(bool enable)
	{
		if (enable)
		{
			Shader.EnableKeyword("STEREO_MULTIVIEW_ON");
			Shader.EnableKeyword("UNITY_SINGLE_PASS_STEREO");
			XRSettings.showDeviceView = false;
		}
		else
		{
			XRSettings.showDeviceView = true;
			Shader.DisableKeyword("UNITY_SINGLE_PASS_STEREO");
			Shader.DisableKeyword("STEREO_MULTIVIEW_ON");
		}
	}

	public static Matrix4x4[] GetStereoWorldToCameraMat()
	{
		Matrix4x4 worldToCameraMatrix = bothCamera.worldToCameraMatrix;
		unity_StereoWorldToCamera[0] = eyesOffsetMatrix[0].inverse * worldToCameraMatrix;
		unity_StereoWorldToCamera[1] = eyesOffsetMatrix[1].inverse * worldToCameraMatrix;
		return unity_StereoWorldToCamera;
	}

	public void SinglePassPreRender()
	{
		SwitchKeywordAndDeviceView(enable: true);
		Shader.SetGlobalMatrixArray("unity_StereoCameraProjection", unity_StereoMatrixP);
		Shader.SetGlobalMatrixArray("unity_StereoCameraInvProjection", unity_StereoMatrixInvP);
		Shader.SetGlobalMatrixArray("unity_StereoMatrixP", unity_StereoMatrixP);
		Matrix4x4 worldToCameraMatrix = bothCamera.worldToCameraMatrix;
		Matrix4x4 cameraToWorldMatrix = bothCamera.cameraToWorldMatrix;
		unity_StereoCameraToWorld[0] = cameraToWorldMatrix * eyesOffsetMatrix[0];
		unity_StereoCameraToWorld[1] = cameraToWorldMatrix * eyesOffsetMatrix[1];
		Shader.SetGlobalMatrixArray("unity_StereoCameraToWorld", unity_StereoCameraToWorld);
		unity_StereoWorldToCamera[0] = eyesOffsetMatrix[0].inverse * worldToCameraMatrix;
		unity_StereoWorldToCamera[1] = eyesOffsetMatrix[1].inverse * worldToCameraMatrix;
		Shader.SetGlobalMatrixArray("unity_StereoWorldToCamera", unity_StereoWorldToCamera);
		Vector4[] values = new Vector4[2]
		{
			bothCamera.transform.position + eyesOffset[0],
			bothCamera.transform.position + eyesOffset[1]
		};
		Shader.SetGlobalVectorArray("unity_StereoWorldSpaceCameraPos", values);
		Shader.SetGlobalMatrixArray("unity_StereoMatrixV", unity_StereoWorldToCamera);
		Shader.SetGlobalMatrixArray("unity_StereoMatrixInvV", unity_StereoCameraToWorld);
		unity_StereoMatrixVP[0] = unity_StereoMatrixP[0] * unity_StereoWorldToCamera[0];
		unity_StereoMatrixVP[1] = unity_StereoMatrixP[1] * unity_StereoWorldToCamera[1];
		Shader.SetGlobalMatrixArray("unity_StereoMatrixVP", unity_StereoMatrixVP);
		SetRenderTextureWithDepth();
		SetCommandBuffers();
	}

	private void SetCommandBuffers()
	{
		if (commandBufferBeforeForwardOpaque == null)
		{
			commandBufferBeforeForwardOpaque = new CommandBuffer();
			Pvr_UnitySDKPluginEvent.SetSinglePassBeforeForwardOpaque(commandBufferBeforeForwardOpaque);
			commandBufferBeforeForwardOpaque.ClearRenderTarget(clearDepth: true, clearColor: true, bothCamera.backgroundColor);
			commandBufferBeforeForwardOpaque.name = "SinglePassPrepare";
		}
		bothCamera.RemoveCommandBuffer(CameraEvent.BeforeForwardOpaque, commandBufferBeforeForwardOpaque);
		bothCamera.AddCommandBuffer(CameraEvent.BeforeForwardOpaque, commandBufferBeforeForwardOpaque);
		if (commandBufferAfterSkybox == null)
		{
			commandBufferAfterSkybox = new CommandBuffer();
		}
		bothCamera.RemoveCommandBuffer(CameraEvent.AfterSkybox, commandBufferAfterSkybox);
		commandBufferAfterSkybox.Clear();
		commandBufferAfterSkybox.SetGlobalMatrixArray("unity_StereoMatrixVP", unity_StereoMatrixVP);
		commandBufferAfterSkybox.name = "SinglePassAfterSkyBox";
		bothCamera.AddCommandBuffer(CameraEvent.AfterSkybox, commandBufferAfterSkybox);
		if (commandBufferBeforeSkybox == null)
		{
			commandBufferBeforeSkybox = new CommandBuffer();
		}
		Matrix4x4 transpose = (Matrix4x4.LookAt(Vector3.zero, bothCamera.transform.forward, bothCamera.transform.up) * Matrix4x4.Scale(new Vector3(1f, 1f, -1f))).transpose;
		Matrix4x4 matrix4x = unity_StereoMatrixP[0];
		Matrix4x4 matrix4x2 = unity_StereoMatrixP[1];
		matrix4x.m22 = -1f;
		matrix4x2.m22 = -1f;
		Matrix4x4[] values = new Matrix4x4[2]
		{
			matrix4x * transpose,
			matrix4x2 * transpose
		};
		bothCamera.RemoveCommandBuffer(CameraEvent.BeforeSkybox, commandBufferBeforeSkybox);
		commandBufferBeforeSkybox.Clear();
		commandBufferBeforeSkybox.SetGlobalMatrixArray("unity_StereoMatrixVP", values);
		commandBufferBeforeSkybox.name = "SinglePassAfterSkybox";
		bothCamera.AddCommandBuffer(CameraEvent.BeforeSkybox, commandBufferBeforeSkybox);
	}

	private void SetRenderTextureWithDepth()
	{
		Pvr_UnitySDKAPI.System.UPvr_SetCurrentRenderTexture((uint)Pvr_UnitySDKRender.Instance.eyeTextureIds[Pvr_UnitySDKRender.Instance.currEyeTextureIdx]);
	}
}
public abstract class SDKStereoRendering
{
	public abstract void InitEye(Camera eye);

	public abstract void OnSDKRenderInited();

	public abstract void OnSDKPreRender();

	public abstract void OnSDKPostRender();
}
public class HighlightAtGaze : MonoBehaviour
{
	public Color HighlightColor = Color.red;

	public float AnimationTime = 0.1f;

	private Renderer myRenderer;

	private Color originalColor;

	private Color targetColor;

	private EyeTrackingGazeRay gazeRay;

	private void Start()
	{
		myRenderer = GetComponent<Renderer>();
		originalColor = myRenderer.material.color;
		targetColor = originalColor;
	}

	private void Update()
	{
		Pvr_UnitySDKAPI.System.UPvr_getEyeTrackingGazeRay(ref gazeRay);
		if (Physics.Raycast(new Ray(gazeRay.Origin, gazeRay.Direction), out var hitInfo))
		{
			if (hitInfo.transform.name == base.transform.name)
			{
				if (targetColor != HighlightColor)
				{
					targetColor = HighlightColor;
				}
			}
			else if (targetColor != originalColor)
			{
				targetColor = originalColor;
			}
		}
		else if (targetColor != originalColor)
		{
			targetColor = originalColor;
		}
		myRenderer.material.color = Color.Lerp(myRenderer.material.color, targetColor, Time.deltaTime * (1f / AnimationTime));
	}
}
public class RayVisualizer : MonoBehaviour
{
	private LineRenderer _line;

	private EyeTrackingGazeRay gazeRay;

	private void Start()
	{
		_line = base.gameObject.GetComponent<LineRenderer>();
		_line.startWidth = 0.002f;
		_line.endWidth = 0.002f;
	}

	private void Update()
	{
		Matrix4x4 matrix = Pvr_UnitySDKSensor.Instance.HeadPose.Matrix;
		Pvr_UnitySDKAPI.System.UPvr_getEyeTrackingGazeRay(ref gazeRay);
		_line.SetPosition(0, matrix.MultiplyPoint(new Vector3(0f, -0.05f, 0.2f)));
		_line.SetPosition(1, gazeRay.Origin + gazeRay.Direction * 20f);
	}
}
public class GetSeeThroughImage : MonoBehaviour
{
	public RawImage viewImage_left;

	public RawImage viewImage_right;

	private int width;

	private int height;

	private RenderTexture cameraTex_left;

	private RenderTexture cameraTex_right;

	private bool cameraPreview;

	private void Start()
	{
		CreateTexture();
	}

	private void Update()
	{
		if (Input.GetKey(KeyCode.JoystickButton0))
		{
			DrawTexture();
		}
	}

	private void OnDestory()
	{
		if (cameraPreview)
		{
			cameraPreview = false;
			BoundarySystem.UPvr_StopCameraFrame();
		}
	}

	private void CreateTexture()
	{
		width = 600;
		height = 600;
		BoundarySystem.UPvr_BoundarySetCameraImageRect(width, height);
		cameraTex_left = new RenderTexture(width, height, 24, RenderTextureFormat.Default);
		cameraTex_right = new RenderTexture(width, height, 24, RenderTextureFormat.Default);
		cameraTex_left.Create();
		cameraTex_right.Create();
		viewImage_left.texture = cameraTex_left;
		viewImage_right.texture = cameraTex_right;
	}

	private void DrawTexture()
	{
		if (!cameraPreview)
		{
			cameraPreview = true;
			BoundarySystem.UPvr_StartCameraFrame();
		}
		BoundarySystem.UPvr_BoundaryGetSeeThroughData(0, cameraTex_left);
		BoundarySystem.UPvr_BoundaryGetSeeThroughData(1, cameraTex_right);
	}
}
public class OverlayExternalSurfaceDemo : MonoBehaviour
{
	public string movieName;

	public Pvr_UnitySDKEyeOverlay.OverlayType overlayType;

	public Pvr_UnitySDKEyeOverlay.OverlayShape overlayShape;

	private Pvr_UnitySDKEyeOverlay overlay;

	private const string TAG = "[ExternalSurface]>>>>>>";

	private void Awake()
	{
		overlay = GetComponent<Pvr_UnitySDKEyeOverlay>();
		if (overlay == null)
		{
			UnityEngine.Debug.LogError("[ExternalSurface]>>>>>>Overlay is null!");
			overlay = base.gameObject.AddComponent<Pvr_UnitySDKEyeOverlay>();
		}
		overlay.overlayType = overlayType;
		overlay.overlayShape = overlayShape;
		overlay.isExternalAndroidSurface = true;
	}

	private void Start()
	{
		if (!string.IsNullOrEmpty(movieName))
		{
			StartPlay(Application.streamingAssetsPath + "/" + movieName, null);
		}
	}

	private void StartPlay(string moviePath, string licenceUrl)
	{
		if (moviePath != string.Empty)
		{
			if (overlay.isExternalAndroidSurface)
			{
				Pvr_UnitySDKEyeOverlay.ExternalAndroidSurfaceObjectCreated externalAndroidSurfaceObjectCreated = delegate
				{
					UnityEngine.Debug.Log("[ExternalSurface]>>>>>>SurfaceObject created callback is Invoke().");
				};
				if (overlay.externalAndroidSurfaceObject == IntPtr.Zero)
				{
					UnityEngine.Debug.Log("[ExternalSurface]>>>>>>Register surfaceObject crreated callback");
					overlay.externalAndroidSurfaceObjectCreated = externalAndroidSurfaceObjectCreated;
				}
				else
				{
					UnityEngine.Debug.Log("[ExternalSurface]>>>>>>SurfaceObject is already created! Invoke callback");
					externalAndroidSurfaceObjectCreated();
				}
			}
		}
		else
		{
			UnityEngine.Debug.LogError("[ExternalSurface]>>>>>>Movie path is null!");
		}
	}
}
public class MoveCylinder : MonoBehaviour
{
	private Vector3 startingPosition;

	private Quaternion startingRotation;

	private void Start()
	{
		startingPosition = base.transform.localPosition;
		startingRotation = base.transform.rotation;
	}

	public void Reset()
	{
		base.transform.localPosition = startingPosition;
		base.transform.rotation = startingRotation;
	}
}
[RequireComponent(typeof(Collider))]
public class MoveSphere : MonoBehaviour
{
	private Vector3 startingPosition;

	private void Start()
	{
		startingPosition = base.transform.localPosition;
		SetGazedAt(gazedAt: false);
		base.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 120f);
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void SetGazedAt(bool gazedAt)
	{
		GetComponent<Renderer>().material.color = (gazedAt ? Color.yellow : Color.blue);
	}

	public void Reset()
	{
		base.transform.localPosition = startingPosition;
		SetGazedAt(gazedAt: false);
		base.gameObject.GetComponent<Rigidbody>().Sleep();
		base.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 120f);
	}

	public void TeleportRandomly()
	{
		Vector3 onUnitSphere = UnityEngine.Random.onUnitSphere;
		onUnitSphere.y = Mathf.Clamp(onUnitSphere.y, 0.5f, 1f);
		float num = 2f * UnityEngine.Random.value + 1.5f;
		base.transform.localPosition = onUnitSphere * num;
	}
}
public class Resetbutton : MonoBehaviour
{
	public void DemoResetTracking()
	{
		if (Pvr_UnitySDKSensor.Instance != null)
		{
			Pvr_UnitySDKSensor.Instance.ResetUnitySDKSensor();
		}
	}
}
public class UserEntitlementCheck : MonoBehaviour
{
	private void OnEnable()
	{
		Pvr_UnitySDKManager.EntitlementCheckResultEvent += HandelEntitlementCheckResult;
	}

	private void OnDisable()
	{
		Pvr_UnitySDKManager.EntitlementCheckResultEvent -= HandelEntitlementCheckResult;
	}

	private void HandelEntitlementCheckResult(int resultCode)
	{
		UnityEngine.Debug.Log("The User Entitlement Check Result is :" + resultCode);
		switch (resultCode)
		{
		case 0:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: success");
			break;
		case -1:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: invalid params");
			break;
		case -2:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: service not exist");
			break;
		case -3:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: bind failed");
			break;
		case -4:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: exception");
			break;
		case -5:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: timeout");
			break;
		case 10:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: missing package name");
			break;
		case 11:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: missing appid");
			break;
		case 13:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: appid and package name not match");
			break;
		case 20:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: not login");
			break;
		case 21:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: not pay");
			break;
		case 31:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: invalid sn");
			break;
		default:
			UnityEngine.Debug.Log("The User Entitlement Check Result is: unknown");
			break;
		}
	}
}
public class Pvr_SQPLoader : MonoBehaviour
{
	private struct SceneInfo
	{
		public List<string> scenes;

		public long version;

		public SceneInfo(List<string> sceneList, long currentSceneEpochVersion)
		{
			scenes = sceneList;
			version = currentSceneEpochVersion;
		}
	}

	public const string RESOURCE_BUNDLE_NAME = "asset_resources";

	public const string EXTERNAL_STORAGE_PATH = "/sdcard/Android/data";

	public const string SCENE_LOAD_DATA_NAME = "SceneLoadData.txt";

	private const string SQP_INDEX_NAME = "PvrSQPIndex";

	private const string CACHE_SCENES_PATH = "cache/scenes";

	private UnityEngine.AsyncOperation loadSceneOperation;

	private string scenePath = "";

	private string sceneLoadDataPath = "";

	private List<AssetBundle> loadedAssetBundles = new List<AssetBundle>();

	private SceneInfo currentSceneInfo;

	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	private void Start()
	{
		string path = Path.Combine("/sdcard/Android/data", Application.identifier);
		scenePath = Path.Combine(path, "cache/scenes");
		sceneLoadDataPath = Path.Combine(scenePath, "SceneLoadData.txt");
		currentSceneInfo = GetSceneInfo();
		if (currentSceneInfo.version != 0L && !string.IsNullOrEmpty(currentSceneInfo.scenes[0]))
		{
			LoadScene(currentSceneInfo);
		}
	}

	public void Update()
	{
	}

	private SceneInfo GetSceneInfo()
	{
		SceneInfo result = default(SceneInfo);
		try
		{
			StreamReader streamReader = new StreamReader(sceneLoadDataPath);
			result.version = Convert.ToInt64(streamReader.ReadLine());
			List<string> list = new List<string>();
			while (!streamReader.EndOfStream)
			{
				list.Add(streamReader.ReadLine());
			}
			result.scenes = list;
		}
		catch
		{
		}
		return result;
	}

	private void LoadScene(SceneInfo sceneInfo)
	{
		AssetBundle assetBundle = null;
		string[] files = Directory.GetFiles(scenePath, "*_*");
		string text = "scene_" + sceneInfo.scenes[0].ToLower();
		try
		{
			string[] array = files;
			for (int i = 0; i < array.Length; i++)
			{
				AssetBundle assetBundle2 = AssetBundle.LoadFromFile(array[i]);
				if (assetBundle2 != null)
				{
					UnityEngine.Debug.Log(("[PVRSceneLoader] Loading file bundle: " + assetBundle2.name == null) ? "null" : assetBundle2.name);
					loadedAssetBundles.Add(assetBundle2);
				}
				else
				{
					UnityEngine.Debug.LogError("[PVRSceneLoader] Loading file bundle failed");
				}
				if (assetBundle2.name == text)
				{
					assetBundle = assetBundle2;
				}
				_ = assetBundle2.name == "asset_resources";
			}
		}
		catch (Exception)
		{
			return;
		}
		if (assetBundle != null)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(assetBundle.GetAllScenePaths()[0]);
			loadSceneOperation = SceneManager.LoadSceneAsync(fileNameWithoutExtension);
			loadSceneOperation.completed += LoadSceneOperation_completed;
		}
	}

	private void LoadSceneOperation_completed(UnityEngine.AsyncOperation obj)
	{
		StartCoroutine(onCheckNewSceneCoroutine());
	}

	private IEnumerator onCheckNewSceneCoroutine()
	{
		while (GetSceneInfo().version == currentSceneInfo.version)
		{
			yield return new WaitForSeconds(0f);
		}
		UnityEngine.Debug.Log("Scene change detected.");
		foreach (AssetBundle loadedAssetBundle in loadedAssetBundles)
		{
			if (loadedAssetBundle != null)
			{
				loadedAssetBundle.Unload(unloadAllLoadedObjects: true);
			}
		}
		loadedAssetBundles.Clear();
		int sceneCount = SceneManager.sceneCount;
		for (int i = 0; i < sceneCount; i++)
		{
			SceneManager.UnloadSceneAsync(SceneManager.GetSceneAt(i));
		}
		GameObject[] array = Resources.FindObjectsOfTypeAll(typeof(GameObject)) as GameObject[];
		for (int j = 0; j < array.Length; j++)
		{
			UnityEngine.Object.Destroy(array[j]);
		}
		SceneManager.LoadSceneAsync("PvrSQPIndex");
	}
}
public class Pvr_UnitySDKHeadTrack : MonoBehaviour
{
	[Tooltip("If true, head tracking will affect the rotation of each Pvr_UnitySDK's cameras.")]
	public bool trackRotation = true;

	[Tooltip("If true, head tracking will affect the position of each Pvr_UnitySDK's cameras.")]
	public bool trackPosition = true;

	public Transform target;

	private bool updated;

	private bool dataClock;

	public Ray Gaze
	{
		get
		{
			UpdateHead();
			return new Ray(base.transform.position, base.transform.forward);
		}
	}

	private void Update()
	{
		updated = false;
		UpdateHead();
	}

	private void UpdateHead()
	{
		if (updated)
		{
			return;
		}
		updated = true;
		if (Pvr_UnitySDKManager.SDK == null)
		{
			return;
		}
		if (trackRotation)
		{
			Quaternion orientation = Pvr_UnitySDKSensor.Instance.HeadPose.Orientation;
			if (target == null)
			{
				base.transform.localRotation = orientation;
			}
			else
			{
				base.transform.rotation = orientation * target.rotation;
			}
		}
		else
		{
			Quaternion orientation2 = Pvr_UnitySDKSensor.Instance.HeadPose.Orientation;
			if (target == null)
			{
				base.transform.localRotation = Quaternion.identity;
			}
			else
			{
				base.transform.rotation = orientation2 * target.rotation;
			}
		}
		if (trackPosition)
		{
			Vector3 position = Pvr_UnitySDKSensor.Instance.HeadPose.Position;
			if (target == null)
			{
				base.transform.localPosition = position;
			}
			else
			{
				base.transform.position = target.position + target.rotation * position;
			}
		}
	}
}
public class Pvr_UnitySDKPose
{
	protected static readonly Matrix4x4 flipZ = Matrix4x4.Scale(new Vector3(1f, 1f, -1f));

	public Matrix4x4 RightHandedMatrix => flipZ * Matrix * flipZ;

	public Vector3 Position { get; protected set; }

	public Quaternion Orientation { get; protected set; }

	public Matrix4x4 Matrix { get; protected set; }

	public Pvr_UnitySDKPose(Matrix4x4 matrix)
	{
		Set(matrix);
	}

	public Pvr_UnitySDKPose(Vector3 position, Quaternion orientation)
	{
		Set(position, orientation);
	}

	public void Set(Vector3 position, Quaternion orientation)
	{
		Position = position;
		Orientation = orientation;
		Matrix = Matrix4x4.TRS(position, orientation, Vector3.one);
	}

	protected void Set(Matrix4x4 matrix)
	{
		Matrix = matrix;
		Position = matrix.GetColumn(3);
		Orientation = Quaternion.LookRotation(matrix.GetColumn(2), matrix.GetColumn(1));
	}

	private Quaternion NormalizeQuaternion(ref Quaternion q)
	{
		float num = 0f;
		for (int i = 0; i < 4; i++)
		{
			num += q[i] * q[i];
		}
		float num2 = 1f / Mathf.Sqrt(num);
		for (int j = 0; j < 4; j++)
		{
			q[j] *= num2;
		}
		return q;
	}
}
public class Pvr_UnitySDKSensor
{
	public delegate void Enter3DofModel();

	public delegate void Exit3DofModel();

	private static Pvr_UnitySDKSensor instance;

	private bool SensorStart;

	private bool SensorInit;

	private Quaternion UnityQuaternion = Quaternion.identity;

	private Vector3 UnityPosition = Vector3.zero;

	private Sensorindex sensorIndex;

	private bool dofClock;

	public static Action EyeFovChanged;

	public Pvr_UnitySDKPose HeadPose;

	private float vfov = 102f;

	private float hfov = 102f;

	private float w;

	private float x;

	private float y;

	private float z;

	private float px;

	private float py;

	private float pz;

	public static Pvr_UnitySDKSensor Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new Pvr_UnitySDKSensor();
			}
			return instance;
		}
		set
		{
			instance = value;
		}
	}

	public static event Enter3DofModel Enter3DofModelEvent;

	public static event Exit3DofModel Exit3DofModelEvent;

	public Pvr_UnitySDKSensor()
	{
		Init();
	}

	public void Init()
	{
		InitUnitySDK6DofSensor();
		SensorInit = InitUnitySDKSensor();
		SensorStart = StartUnitySDKSensor();
		HeadPose = new Pvr_UnitySDKPose(Vector3.zero, Quaternion.identity);
	}

	public void SensorUpdate()
	{
		if (GetUnitySDKSensorState())
		{
			HeadPose.Set(UnityPosition, UnityQuaternion);
		}
	}

	public bool InitUnitySDKSensor()
	{
		bool result = false;
		try
		{
			if (Sensor.UPvr_Init((int)sensorIndex) == 0)
			{
				result = true;
			}
		}
		catch (Exception ex)
		{
			PLOG.E("InitUnitySDKSensor ERROR! " + ex.Message);
			throw;
		}
		return result;
	}

	public bool InitUnitySDK6DofSensor()
	{
		bool result = false;
		try
		{
			int res = 0;
			Render.UPvr_GetIntConfig(3, ref res);
			if (res == 1)
			{
				if (Sensor.UPvr_Enable6DofModule(!Pvr_UnitySDKManager.SDK.HmdOnlyrot) == 0 && !Pvr_UnitySDKManager.SDK.HmdOnlyrot)
				{
					result = true;
					Pvr_UnitySDKManager.SDK.PVRNeck = false;
				}
			}
			else
			{
				UnityEngine.Debug.LogWarning("This platform does not support 6 Dof !");
			}
		}
		catch (Exception ex)
		{
			PLOG.E("InitUnity6DofSDKSensor ERROR! " + ex.Message);
			throw;
		}
		return result;
	}

	public bool StartUnitySDKSensor()
	{
		bool result = false;
		try
		{
			if (Sensor.UPvr_StartSensor((int)sensorIndex) == 0)
			{
				result = true;
			}
		}
		catch (Exception ex)
		{
			PLOG.E("StartUnitySDKSensor ERROR! " + ex.Message);
			throw;
		}
		return result;
	}

	public bool StopUnitySDKSensor()
	{
		bool result = false;
		try
		{
			if (Sensor.UPvr_StopSensor((int)sensorIndex) == 0)
			{
				result = true;
			}
		}
		catch (Exception ex)
		{
			PLOG.E("StopUnitySDKSensor ERROR! " + ex.Message);
			throw;
		}
		return result;
	}

	public bool ResetUnitySDKSensor()
	{
		bool result = false;
		try
		{
			if (Sensor.UPvr_ResetSensor((int)sensorIndex) == 0)
			{
				result = true;
				PLOG.E("ResetUnitySDKSensor OK! ");
			}
		}
		catch (Exception ex)
		{
			PLOG.E("ResetUnitySDKSensor ERROR! " + ex.Message);
			throw;
		}
		return result;
	}

	public bool OptionalResetUnitySDKSensor(int resetRot, int resetPos)
	{
		bool result = false;
		try
		{
			if (Sensor.UPvr_OptionalResetSensor((int)sensorIndex, resetRot, resetPos) == 0)
			{
				result = true;
				UnityEngine.Debug.Log("PvrLog OptionalResetUnitySDKSensor OK!" + resetRot + resetPos);
			}
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.LogError("OptionalResetUnitySDKSensor ERROR! " + ex.Message);
			throw;
		}
		return result;
	}

	public bool GetUnitySDKSensorState()
	{
		bool result = false;
		if (SensorInit && SensorStart)
		{
			try
			{
				int num = -1;
				if (Pvr_UnitySDKManager.SDK.ShowVideoSeethrough)
				{
					Pvr_BoundarySystem.Instance.CameraFramePtr = Pvr_BoundaryAPI.UPvr_GetCameraData_Ext();
					num = Pvr_BoundaryAPI.UPvr_GetMainSensorStateExt(ref x, ref y, ref z, ref w, ref px, ref py, ref pz, ref vfov, ref hfov, ref Pvr_UnitySDKRender.Instance.RenderviewNumber);
				}
				else
				{
					num = Sensor.UPvr_GetMainSensorState(ref x, ref y, ref z, ref w, ref px, ref py, ref pz, ref vfov, ref hfov, ref Pvr_UnitySDKRender.Instance.RenderviewNumber);
				}
				Pvr_UnitySDKManager.SDK.posStatus = Sensor.UPvr_Get6DofSensorQualityStatus();
				if (num == 0)
				{
					if (!Convert.ToBoolean(Pvr_UnitySDKManager.SDK.posStatus & 2))
					{
						if (!dofClock)
						{
							if (Pvr_UnitySDKSensor.Enter3DofModelEvent != null)
							{
								Pvr_UnitySDKSensor.Enter3DofModelEvent();
							}
							dofClock = true;
						}
					}
					else if (dofClock)
					{
						if (Pvr_UnitySDKSensor.Exit3DofModelEvent != null)
						{
							Pvr_UnitySDKSensor.Exit3DofModelEvent();
						}
						dofClock = false;
					}
					RefreshHeadData(x, y, z, w, px, py, pz);
					UnityQuaternion.Set(x, y, 0f - z, 0f - w);
					if (Pvr_UnitySDKRender.Instance.EyeVFoV != vfov)
					{
						Pvr_UnitySDKRender.Instance.EyeVFoV = vfov;
						if (EyeFovChanged != null)
						{
							EyeFovChanged();
						}
					}
					Pvr_UnitySDKRender.Instance.EyeHFoV = hfov;
					Pvr_UnitySDKManager.SDK.EyesAspect = hfov / vfov;
					result = true;
					if (Pvr_UnitySDKManager.SDK.HmdOnlyrot)
					{
						if (Pvr_UnitySDKManager.SDK.PVRNeck)
						{
							if (Pvr_UnitySDKManager.SDK.TrackingOrigin == TrackingOrigin.FloorLevel)
							{
								UnityPosition.Set(0f, py, 0f);
								UnityPosition += UnityQuaternion * Pvr_UnitySDKManager.SDK.neckOffset - Pvr_UnitySDKManager.SDK.neckOffset.y * Vector3.up;
							}
							else
							{
								UnityPosition = UnityQuaternion * Pvr_UnitySDKManager.SDK.neckOffset - Pvr_UnitySDKManager.SDK.neckOffset.y * Vector3.up;
							}
						}
					}
					else
					{
						UnityPosition.Set(px, py, 0f - pz);
					}
					if (PLOG.logLevel > 2)
					{
						PLOG.D("posStatus=" + Pvr_UnitySDKManager.SDK.posStatus);
						PLOG.D("PvrLog 6DoFHeadRotation:" + x + "," + y + "," + (0f - z) + "," + (0f - w) + ",Position:" + px + "," + py + "," + (0f - pz) + ",eulerAngles:" + UnityQuaternion.eulerAngles);
					}
				}
				if (num == -1)
				{
					PLOG.I("PvrLog Sensor update --- GetUnitySDKSensorState  -1 ");
				}
			}
			catch (Exception ex)
			{
				PLOG.E("GetUnitySDKSensorState ERROR! " + ex.Message);
				throw;
			}
		}
		return result;
	}

	public bool GetUnitySDKPSensorState()
	{
		bool result = false;
		try
		{
			if (Sensor.UPvr_ResetSensor((int)sensorIndex) == 0)
			{
				result = true;
			}
		}
		catch (Exception ex)
		{
			PLOG.E("GetUnitySDKPSensorState ERROR! " + ex.Message);
			throw;
		}
		return result;
	}

	private void RefreshHeadData(float x, float y, float z, float w, float px, float py, float pz)
	{
		Pvr_UnitySDKManager.SDK.headData[0] = x;
		Pvr_UnitySDKManager.SDK.headData[1] = y;
		Pvr_UnitySDKManager.SDK.headData[2] = z;
		Pvr_UnitySDKManager.SDK.headData[3] = w;
		Pvr_UnitySDKManager.SDK.headData[4] = px;
		Pvr_UnitySDKManager.SDK.headData[5] = py;
		Pvr_UnitySDKManager.SDK.headData[6] = pz;
	}
}
public class CLoadingAsset : ScriptableObject
{
	public int SplashScreenType;

	public List<Texture2D> splashImage = new List<Texture2D>();

	public Texture2D Inside_background;

	public bool UseSplashText;

	public string DefaultText;

	public string ChineseText;

	public string EnglishText;

	public string JapaneseText;

	public string KoreanText;

	public string FontSize;

	public Color FontColor;

	public string TextHeight;

	public bool UseCarousel;

	public int SplashTextAlignment;
}
[Serializable]
public class Pvr_UnitySDKConfigProfile
{
	public struct Lenses
	{
		public float separation;

		public float offset;

		public float distance;

		public int alignment;

		public const int AlignTop = -1;

		public const int AlignCenter = 0;

		public const int AlignBottom = 1;
	}

	public struct MaxFOV
	{
		public float upper;

		public float lower;

		public float inner;

		public float outer;
	}

	public struct Distortion
	{
		public float k1;

		public float k2;

		public float k3;

		public float k4;

		public float k5;

		public float k6;

		public float distort(float r)
		{
			return 0f;
		}

		public float distort(float r, float dist)
		{
			float num = r * dist * 1000f;
			return (k1 * Mathf.Pow(num, 5f) + k2 * Mathf.Pow(num, 4f) + k3 * Mathf.Pow(num, 3f) + k4 * Mathf.Pow(num, 2f) + k5 * num + k6) / 1000f / dist;
		}

		public float diatortInv(float radious)
		{
			return 0f;
		}
	}

	public struct Device
	{
		public Lenses devLenses;

		public MaxFOV devMaxFov;

		public Distortion devDistortion;

		public Distortion devDistortionInv;
	}

	public static readonly Device SimulateDevice = new Device
	{
		devLenses = 
		{
			separation = 0.062f,
			offset = 0f,
			distance = 0.0403196f,
			alignment = 0
		},
		devMaxFov = 
		{
			upper = 40f,
			lower = 40f,
			inner = 40f,
			outer = 40f
		},
		devDistortion = 
		{
			k1 = 2.333E-06f,
			k2 = -0.000126f,
			k3 = 0.002978f,
			k4 = -0.02615f,
			k5 = 1.089f,
			k6 = -0.0337f
		},
		devDistortionInv = 
		{
			k1 = 1.342E-08f,
			k2 = 1.665E-06f,
			k3 = -0.0002797f,
			k4 = 0.001166f,
			k5 = 0.9945f,
			k6 = 0.004805f
		}
	};

	public Device device;

	public static readonly Pvr_UnitySDKConfigProfile Default = new Pvr_UnitySDKConfigProfile
	{
		device = SimulateDevice
	};

	public Pvr_UnitySDKConfigProfile Clone()
	{
		return new Pvr_UnitySDKConfigProfile
		{
			device = device
		};
	}

	public static Pvr_UnitySDKConfigProfile GetPicoProfile()
	{
		return new Pvr_UnitySDKConfigProfile
		{
			device = SimulateDevice
		};
	}

	public float[] GetLeftEyeVisibleTanAngles(float width, float height)
	{
		float val = (float)Math.Tan((double)(0f - device.devMaxFov.outer) * Math.PI / 180.0);
		float val2 = (float)Math.Tan((double)device.devMaxFov.upper * Math.PI / 180.0);
		float val3 = (float)Math.Tan((double)device.devMaxFov.inner * Math.PI / 180.0);
		float val4 = (float)Math.Tan((double)(0f - device.devMaxFov.lower) * Math.PI / 180.0);
		float num = width / 4f;
		float num2 = height / 2f;
		float num3 = device.devLenses.separation / 2f - num;
		float num4 = 0f;
		float distance = device.devLenses.distance;
		float val5 = device.devDistortion.distort((num3 - num) / distance, device.devLenses.distance);
		float val6 = device.devDistortion.distort((num4 + num2) / distance, device.devLenses.distance);
		float val7 = device.devDistortion.distort((num3 + num) / distance, device.devLenses.distance);
		float val8 = device.devDistortion.distort((num4 - num) / distance, device.devLenses.distance);
		float num5 = Math.Max(val, val5);
		float num6 = Math.Min(val2, val6);
		float num7 = Math.Min(val3, val7);
		float num8 = Math.Max(val4, val8);
		return new float[4] { num5, num6, num7, num8 };
	}

	public float[] GetLeftEyeNoLensTanAngles(float width, float height)
	{
		float val = device.devDistortionInv.distort((float)Math.Tan((double)(0f - device.devMaxFov.outer) * Math.PI / 180.0), device.devLenses.distance);
		float val2 = device.devDistortionInv.distort((float)Math.Tan((double)device.devMaxFov.upper * Math.PI / 180.0), device.devLenses.distance);
		float val3 = device.devDistortionInv.distort((float)Math.Tan((double)device.devMaxFov.inner * Math.PI / 180.0), device.devLenses.distance);
		float val4 = device.devDistortionInv.distort((float)Math.Tan((double)(0f - device.devMaxFov.lower) * Math.PI / 180.0), device.devLenses.distance);
		float num = width / 4f;
		float num2 = height / 2f;
		float num3 = device.devLenses.separation / 2f - num;
		float num4 = 0f;
		float distance = device.devLenses.distance;
		float val5 = (num3 - num) / distance;
		float val6 = (num4 + num2) / distance;
		float val7 = (num3 + num) / distance;
		float val8 = (num4 - num) / distance;
		float num5 = Math.Min(val, val5);
		float num6 = Math.Min(val2, val6);
		float num7 = Math.Min(val3, val7);
		float num8 = Math.Max(val4, val8);
		return new float[4] { num5, num6, num7, num8 };
	}

	public Rect GetLeftEyeVisibleScreenRect(float[] undistortedFrustum, float width, float height)
	{
		float distance = device.devLenses.distance;
		float num = (width - device.devLenses.separation) / 2f;
		float num2 = height / 2f;
		float num3 = (undistortedFrustum[0] * distance + num) / width;
		float num4 = (undistortedFrustum[1] * distance + num2) / height;
		float num5 = (undistortedFrustum[2] * distance + num) / width;
		float num6 = (undistortedFrustum[3] * distance + num2) / height;
		return new Rect(num3, num6, num5 - num3, num4 - num6);
	}
}
[RequireComponent(typeof(Text))]
public class Pvr_UnitySDKFPS : MonoBehaviour
{
	public Text fpsText;

	private float updateInterval = 0.5f;

	private float accum;

	private int frames;

	private float timeLeft;

	private string strFps;

	private void Update()
	{
		if (fpsText != null)
		{
			ShowFps();
		}
	}

	private void ShowFps()
	{
		timeLeft -= Time.unscaledDeltaTime;
		accum += Time.unscaledDeltaTime;
		frames++;
		if ((double)timeLeft <= 0.0)
		{
			float num = (float)frames / accum;
			strFps = $"FPS: {num:f0}";
			fpsText.text = strFps;
			timeLeft += updateInterval;
			accum = 0f;
			frames = 0;
		}
	}
}
public class Pvr_GazeFuse : MonoBehaviour
{
	public GameObject gazeGameObject;

	private Image image;

	private void Start()
	{
		image = GetComponent<Image>();
	}

	private void Update()
	{
		if (gazeGameObject == null || Pvr_GazeInputModule.gazeGameObject == gazeGameObject)
		{
			FuseAmountChanged(Pvr_GazeInputModule.gazeFraction);
		}
	}

	private void FuseAmountChanged(float fuseAmount)
	{
		if (image != null)
		{
			image.fillAmount = fuseAmount;
		}
	}
}
public class Pvr_GazeInputModule : PointerInputModule
{
	public enum Mode
	{
		Click,
		Gaze
	}

	public Mode mode;

	[Header("Click Settings")]
	public string ClickInputName = "Submit";

	[Header("Gaze Settings")]
	public float GazeTimeInSeconds = 2f;

	public RaycastResult CurrentRaycast;

	private PointerEventData pointerEventData;

	private GameObject currentLookAtHandler;

	private float currentLookAtHandlerClickTime;

	public static float gazeFraction { get; private set; }

	public static GameObject gazeGameObject { get; private set; }

	public override void Process()
	{
		HandleLook();
		HandleSelection();
	}

	private void HandleLook()
	{
		if (pointerEventData == null)
		{
			pointerEventData = new PointerEventData(base.eventSystem);
		}
		pointerEventData.position = new Vector2(Screen.width / 2, Screen.height / 2);
		pointerEventData.delta = Vector2.zero;
		List<RaycastResult> list = new List<RaycastResult>();
		base.eventSystem.RaycastAll(pointerEventData, list);
		RaycastResult currentRaycast = (pointerEventData.pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(list));
		CurrentRaycast = currentRaycast;
		ProcessMove(pointerEventData);
	}

	private void HandleSelection()
	{
		gazeFraction = 0f;
		if (pointerEventData.pointerEnter != null)
		{
			GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(pointerEventData.pointerEnter);
			if (currentLookAtHandler != eventHandler)
			{
				gazeGameObject = (currentLookAtHandler = eventHandler);
				currentLookAtHandlerClickTime = Time.realtimeSinceStartup + GazeTimeInSeconds;
			}
			if (mode == Mode.Gaze && currentLookAtHandler != null)
			{
				gazeFraction = Mathf.Clamp01(1f - (currentLookAtHandlerClickTime - Time.realtimeSinceStartup) / GazeTimeInSeconds);
			}
			if ((currentLookAtHandler != null && mode == Mode.Gaze && Time.realtimeSinceStartup > currentLookAtHandlerClickTime) || (mode == Mode.Click && Input.GetButtonDown(ClickInputName)))
			{
				_ = EventSystem.current.currentSelectedGameObject != null;
				EventSystem.current.SetSelectedGameObject(currentLookAtHandler);
				gazeFraction = 0f;
				ExecuteEvents.ExecuteHierarchy(currentLookAtHandler, pointerEventData, ExecuteEvents.pointerClickHandler);
				currentLookAtHandlerClickTime = float.MaxValue;
				ExecuteEvents.ExecuteHierarchy(EventSystem.current.currentSelectedGameObject, pointerEventData, ExecuteEvents.deselectHandler);
			}
		}
		else
		{
			gazeGameObject = (currentLookAtHandler = null);
		}
	}
}
[RequireComponent(typeof(Pvr_GazeInputModule))]
public class Pvr_GazeInputModuleCrosshair : MonoBehaviour
{
	public static bool DisplayCrosshair = true;

	[Tooltip("Crosshair GameObject attached to your VR Camera")]
	public Transform Crosshair;

	private Pvr_GazeInputModule gazeInputModule;

	private Vector3 CrosshairOriginalScale;

	private float CrosshairOriginalDistance;

	private void Awake()
	{
		gazeInputModule = GetComponent<Pvr_GazeInputModule>();
	}

	private void Start()
	{
		CrosshairOriginalScale = Crosshair.localScale;
		CrosshairOriginalDistance = Crosshair.localPosition.z;
		Crosshair.gameObject.SetActive(value: false);
	}

	private void Update()
	{
		Crosshair.gameObject.SetActive(DisplayCrosshair);
		if (DisplayCrosshair)
		{
			float crossHairAtDistance = CrosshairOriginalDistance;
			if (gazeInputModule.CurrentRaycast.isValid)
			{
				crossHairAtDistance = gazeInputModule.CurrentRaycast.distance * 0.8f - 0.5f;
			}
			SetCrossHairAtDistance(crossHairAtDistance);
		}
	}

	private void SetCrossHairAtDistance(float dist)
	{
		Vector3 localPosition = Crosshair.localPosition;
		Crosshair.localPosition = new Vector3(localPosition.x, localPosition.y, dist);
		Crosshair.localScale = CrosshairOriginalScale * dist;
	}
}
public enum RenderEventType
{
	InitRenderThread = 1024,
	Pause,
	Resume,
	LeftEyeEndFrame,
	RightEyeEndFrame,
	TimeWarp,
	ResetVrModeParms,
	ShutdownRenderThread,
	BeginEye,
	EndEye,
	BoundaryRenderLeft,
	BoundaryRenderRight,
	BothEyeEndFrame,
	CameraFrameLeft,
	CameraFrameRight,
	StartCameraFrame,
	StopCameraFrame
}
public static class Pvr_UnitySDKPluginEvent
{
	private delegate void RenderEventDelegate(int eventId);

	private const uint IS_DATA_FLAG = 2147483648u;

	private const uint DATA_POS_MASK = 1073741824u;

	private const int DATA_POS_SHIFT = 30;

	private const uint EVENT_TYPE_MASK = 1056899072u;

	private const int EVENT_TYPE_SHIFT = 17;

	private const uint PAYLOAD_MASK = 65535u;

	private const int PAYLOAD_SHIFT = 16;

	private static RenderEventDelegate SetSinglePassBeforeForwardOpaqueHandle = SetSinglePassBeforeForwardOpaque;

	private static IntPtr SetSinglePassBeforeForwardOpaquePtr = Marshal.GetFunctionPointerForDelegate(SetSinglePassBeforeForwardOpaqueHandle);

	public static void Issue(RenderEventType eventType)
	{
		GL.IssuePluginEvent(Pvr_UnitySDKAPI.System.GetRenderEventFunc(), (int)eventType);
	}

	private static int EncodeType(int eventType)
	{
		return eventType & 0x7FFFFFFF;
	}

	private static int EncodeData(int eventId, int eventData, int pos)
	{
		return int.MinValue | ((pos << 30) & 0x40000000) | ((eventId << 17) & 0x3EFF0000) | ((eventData >>> pos * 16) & 0xFFFF);
	}

	private static int DecodeData(int eventData)
	{
		uint num = (uint)(eventData & 0x40000000) >> 30;
		return (eventData & 0xFFFF) << (int)(16 * num);
	}

	[MonoPInvokeCallback(typeof(RenderEventDelegate))]
	private static void SetSinglePassBeforeForwardOpaque(int eventId)
	{
		Pvr_UnitySDKAPI.System.UPvr_SinglePassBeforeForwardOpaque();
	}

	public static void SetSinglePassBeforeForwardOpaque(CommandBuffer cmd)
	{
		cmd.IssuePluginEvent(SetSinglePassBeforeForwardOpaquePtr, 0);
	}
}
public class Pvr_UnitySDKSightInputModule : BaseInputModule
{
	[Tooltip("Optional object to place at raycast intersections as a 3D cursor. Be sure it is on a layer that raycasts will ignore.")]
	public GameObject cursor;

	public int trigger;

	[HideInInspector]
	public float clickTime = 0.1f;

	[HideInInspector]
	public Vector2 hotspot = new Vector2(0.5f, 0.5f);

	private PointerEventData pointerData;

	public override bool ShouldActivateModule()
	{
		if (!base.ShouldActivateModule())
		{
			return false;
		}
		return Pvr_UnitySDKManager.SDK.VRModeEnabled;
	}

	public override void DeactivateModule()
	{
		base.DeactivateModule();
		if (pointerData != null)
		{
			HandlePendingClick();
			HandlePointerExitAndEnter(pointerData, null);
			pointerData = null;
		}
		base.eventSystem.SetSelectedGameObject(null, GetBaseEventData());
		if (cursor != null)
		{
			cursor.SetActive(value: false);
		}
	}

	public override bool IsPointerOverGameObject(int pointerId)
	{
		if (pointerData != null)
		{
			return pointerData.pointerEnter != null;
		}
		return false;
	}

	public override void Process()
	{
		CastRayFromGaze();
		UpdateCurrentObject();
		PlaceCursor();
		HandlePendingClick();
		HandleTrigger();
	}

	private void CastRayFromGaze()
	{
		if (pointerData == null)
		{
			pointerData = new PointerEventData(base.eventSystem);
		}
		pointerData.Reset();
		pointerData.position = new Vector2(hotspot.x * (float)Screen.width, hotspot.y * (float)Screen.height);
		base.eventSystem.RaycastAll(pointerData, m_RaycastResultCache);
		pointerData.pointerCurrentRaycast = BaseInputModule.FindFirstRaycast(m_RaycastResultCache);
		m_RaycastResultCache.Clear();
	}

	private void UpdateCurrentObject()
	{
		GameObject gameObject = pointerData.pointerCurrentRaycast.gameObject;
		HandlePointerExitAndEnter(pointerData, gameObject);
		if (ExecuteEvents.GetEventHandler<ISelectHandler>(gameObject) == base.eventSystem.currentSelectedGameObject)
		{
			ExecuteEvents.Execute(base.eventSystem.currentSelectedGameObject, GetBaseEventData(), ExecuteEvents.updateSelectedHandler);
		}
		else
		{
			base.eventSystem.SetSelectedGameObject(null, pointerData);
		}
	}

	private void PlaceCursor()
	{
		if (!(cursor == null))
		{
			GameObject gameObject = pointerData.pointerCurrentRaycast.gameObject;
			cursor.SetActive(gameObject != null);
			if (cursor.activeInHierarchy)
			{
				Camera enterEventCamera = pointerData.enterEventCamera;
				float num = pointerData.pointerCurrentRaycast.distance + enterEventCamera.nearClipPlane - 0.1f;
				cursor.transform.position = enterEventCamera.transform.position + enterEventCamera.transform.forward * num;
			}
		}
	}

	private void HandlePendingClick()
	{
		if (pointerData.eligibleForClick && (Pvr_UnitySDKManager.SDK.picovrTriggered || !(Time.unscaledTime - pointerData.clickTime < clickTime)))
		{
			ExecuteEvents.Execute(pointerData.pointerPress, pointerData, ExecuteEvents.pointerUpHandler);
			ExecuteEvents.Execute(pointerData.pointerPress, pointerData, ExecuteEvents.pointerClickHandler);
			pointerData.pointerPress = null;
			pointerData.rawPointerPress = null;
			pointerData.eligibleForClick = false;
			pointerData.clickCount = 0;
		}
	}

	private void HandleTrigger()
	{
		if (Pvr_UnitySDKManager.SDK.picovrTriggered)
		{
			GameObject gameObject = pointerData.pointerCurrentRaycast.gameObject;
			if (!(gameObject == null) && !(ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject) == null))
			{
				pointerData.pointerPress = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				pointerData.pressPosition = pointerData.position;
				pointerData.pointerPressRaycast = pointerData.pointerCurrentRaycast;
				pointerData.pointerPress = ExecuteEvents.ExecuteHierarchy(gameObject, pointerData, ExecuteEvents.pointerDownHandler) ?? ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				pointerData.rawPointerPress = gameObject;
				pointerData.eligibleForClick = true;
				pointerData.clickCount = 1;
				pointerData.clickTime = Time.unscaledTime;
			}
		}
	}
}
public class Pvr_ObjImporter
{
	private static Pvr_ObjImporter _instance;

	private List<int> triangles;

	private List<Vector3> vertices;

	private List<Vector2> uv;

	private List<Vector3> normals;

	private List<PvrVector3Int> faceData;

	private List<int> intArray;

	private const int MIN_POW_10 = -16;

	private const int MAX_POW_10 = 16;

	private const int NUM_POWS_10 = 33;

	private static readonly float[] pow10 = GenerateLookupTable();

	public static Pvr_ObjImporter Instance => _instance ?? (_instance = new Pvr_ObjImporter());

	public Mesh ImportFile(string filePath)
	{
		triangles = new List<int>();
		vertices = new List<Vector3>();
		uv = new List<Vector2>();
		normals = new List<Vector3>();
		faceData = new List<PvrVector3Int>();
		intArray = new List<int>();
		LoadMeshData(filePath);
		Vector3[] array = new Vector3[faceData.Count];
		Vector2[] array2 = new Vector2[faceData.Count];
		Vector3[] array3 = new Vector3[faceData.Count];
		for (int i = 0; i < faceData.Count; i++)
		{
			array[i] = vertices[faceData[i].x - 1];
			if (faceData[i].y >= 1)
			{
				array2[i] = uv[faceData[i].y - 1];
			}
			if (faceData[i].z >= 1)
			{
				array3[i] = normals[faceData[i].z - 1];
			}
		}
		Mesh mesh = new Mesh();
		mesh.vertices = array;
		mesh.uv = array2;
		mesh.normals = array3;
		mesh.triangles = triangles.ToArray();
		mesh.RecalculateBounds();
		return mesh;
	}

	private void LoadMeshData(string fileName)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = File.ReadAllText(fileName);
		int num = 0;
		string text2 = null;
		int num2 = 0;
		StringBuilder sbInt = new StringBuilder();
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] != '\n')
			{
				continue;
			}
			stringBuilder.Remove(0, stringBuilder.Length);
			stringBuilder.Append(text, num + 1, i - num);
			num = i;
			if (stringBuilder[0] == 'o' && stringBuilder[1] == ' ')
			{
				sbInt.Remove(0, sbInt.Length);
				for (int j = 2; j < stringBuilder.Length; j++)
				{
					text2 += stringBuilder[j];
				}
			}
			else if (stringBuilder[0] == 'v' && stringBuilder[1] == ' ')
			{
				int start = 2;
				vertices.Add(new Vector3(GetFloat(stringBuilder, ref start, ref sbInt), GetFloat(stringBuilder, ref start, ref sbInt), GetFloat(stringBuilder, ref start, ref sbInt)));
			}
			else if (stringBuilder[0] == 'v' && stringBuilder[1] == 't' && stringBuilder[2] == ' ')
			{
				int start2 = 3;
				uv.Add(new Vector2(GetFloat(stringBuilder, ref start2, ref sbInt), GetFloat(stringBuilder, ref start2, ref sbInt)));
			}
			else if (stringBuilder[0] == 'v' && stringBuilder[1] == 'n' && stringBuilder[2] == ' ')
			{
				int start3 = 3;
				normals.Add(new Vector3(GetFloat(stringBuilder, ref start3, ref sbInt), GetFloat(stringBuilder, ref start3, ref sbInt), GetFloat(stringBuilder, ref start3, ref sbInt)));
			}
			else if (stringBuilder[0] == 'f' && stringBuilder[1] == ' ')
			{
				int start4 = 2;
				int num3 = 1;
				intArray.Clear();
				int num4 = 0;
				while (start4 < stringBuilder.Length && char.IsDigit(stringBuilder[start4]))
				{
					faceData.Add(new PvrVector3Int(GetInt(stringBuilder, ref start4, ref sbInt), GetInt(stringBuilder, ref start4, ref sbInt), GetInt(stringBuilder, ref start4, ref sbInt)));
					num3++;
					intArray.Add(num2);
					num2++;
				}
				num4 += num3;
				for (num3 = 1; num3 + 2 < num4; num3++)
				{
					triangles.Add(intArray[0]);
					triangles.Add(intArray[num3]);
					triangles.Add(intArray[num3 + 1]);
				}
			}
		}
	}

	private float GetFloat(StringBuilder sb, ref int start, ref StringBuilder sbFloat)
	{
		sbFloat.Remove(0, sbFloat.Length);
		while (start < sb.Length && (char.IsDigit(sb[start]) || sb[start] == '-' || sb[start] == '.'))
		{
			sbFloat.Append(sb[start]);
			start++;
		}
		start++;
		return ParseFloat(sbFloat);
	}

	private int GetInt(StringBuilder sb, ref int start, ref StringBuilder sbInt)
	{
		sbInt.Remove(0, sbInt.Length);
		while (start < sb.Length && char.IsDigit(sb[start]))
		{
			sbInt.Append(sb[start]);
			start++;
		}
		start++;
		return IntParseFast(sbInt);
	}

	private static float[] GenerateLookupTable()
	{
		float[] array = new float[320];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (float)(i / 33) * Mathf.Pow(10f, i % 33 + -16);
		}
		return array;
	}

	private float ParseFloat(StringBuilder value)
	{
		float num = 0f;
		bool flag = false;
		int length = value.Length;
		int num2 = value.Length;
		for (int num3 = length - 1; num3 >= 0; num3--)
		{
			if (value[num3] == '.')
			{
				num2 = num3;
				break;
			}
		}
		int num4 = 16 + num2;
		for (int i = 0; i < num2; i++)
		{
			if (i != num2 && value[i] != '-')
			{
				num += pow10[(value[i] - 48) * 33 + num4 - i - 1];
			}
			else if (value[i] == '-')
			{
				flag = true;
			}
		}
		for (int j = num2 + 1; j < length; j++)
		{
			if (j != num2)
			{
				num += pow10[(value[j] - 48) * 33 + num4 - j];
			}
		}
		if (flag)
		{
			num = 0f - num;
		}
		return num;
	}

	private int IntParseFast(StringBuilder value)
	{
		int num = 0;
		for (int i = 0; i < value.Length; i++)
		{
			num = 10 * num + (value[i] - 48);
		}
		return num;
	}
}
public sealed class PvrVector3Int
{
	public int x { get; set; }

	public int y { get; set; }

	public int z { get; set; }

	public PvrVector3Int()
	{
	}

	public PvrVector3Int(int x, int y, int z)
	{
		this.x = x;
		this.y = y;
		this.z = z;
	}
}
public class Pvr_EnumFlags : PropertyAttribute
{
}
public enum ConfirmBtn
{
	App = 1,
	TouchPad = 2,
	Trigger = 4
}
public class Pvr_InputModule : PointerInputModule
{
	public static List<Pvr_UIPointer> pointers = new List<Pvr_UIPointer>();

	[Pvr_EnumFlags]
	public ConfirmBtn confirmBtn = ConfirmBtn.TouchPad;

	private List<RaycastResult> rayCasts = new List<RaycastResult>();

	private RaycastResult rayCastResult;

	public virtual void Initialise()
	{
		pointers.Clear();
	}

	public static void AddPoint(Pvr_UIPointer point)
	{
		if (!pointers.Contains(point))
		{
			pointers.Add(point);
		}
	}

	public static void RemovePoint(Pvr_UIPointer point)
	{
		if (pointers.Contains(point))
		{
			pointers.Remove(point);
		}
	}

	public override void Process()
	{
		if (Pvr_UnitySDKManager.SDK.isHasController)
		{
			if ((confirmBtn & ConfirmBtn.App) == ConfirmBtn.App)
			{
				Pvr_UIPointer.AppBtnValue = Controller.UPvr_GetKey(Pvr_ControllerManager.controllerlink.mainHandID, Pvr_KeyCode.APP);
			}
			if ((confirmBtn & ConfirmBtn.TouchPad) == ConfirmBtn.TouchPad)
			{
				Pvr_UIPointer.TouchBtnValue = Controller.UPvr_GetKey(Pvr_ControllerManager.controllerlink.mainHandID, Pvr_KeyCode.TRIGGER);
			}
			if ((confirmBtn & ConfirmBtn.Trigger) == ConfirmBtn.Trigger)
			{
				Pvr_UIPointer.TriggerBtnValue = Controller.UPvr_GetKey(Pvr_ControllerManager.controllerlink.mainHandID, Pvr_KeyCode.TRIGGER);
			}
		}
		for (int i = 0; i < pointers.Count; i++)
		{
			Pvr_UIPointer pvr_UIPointer = pointers[i];
			if (pvr_UIPointer.gameObject.activeInHierarchy && pvr_UIPointer.enabled)
			{
				List<RaycastResult> results = new List<RaycastResult>();
				if (pvr_UIPointer.PointerActive())
				{
					results = CheckRaycasts(pvr_UIPointer);
				}
				Hover(pvr_UIPointer, results);
				Click(pvr_UIPointer, results);
				Drag(pvr_UIPointer, results);
			}
		}
	}

	protected virtual List<RaycastResult> CheckRaycasts(Pvr_UIPointer pointer)
	{
		rayCastResult.worldPosition = pointer.GetOriginPosition();
		rayCastResult.worldNormal = pointer.GetOriginForward();
		pointer.pointerEventData.pointerCurrentRaycast = rayCastResult;
		base.eventSystem.RaycastAll(pointer.pointerEventData, rayCasts);
		return rayCasts;
	}

	protected virtual bool CheckTransformTree(Transform target, Transform source)
	{
		if (target == null)
		{
			return false;
		}
		if (target.Equals(source))
		{
			return true;
		}
		return CheckTransformTree(target.transform.parent, source);
	}

	protected virtual bool NoValidCollision(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		if (results.Count != 0)
		{
			return !CheckTransformTree(results[0].gameObject.transform, pointer.pointerEventData.pointerEnter.transform);
		}
		return true;
	}

	protected virtual bool IsHovering(Pvr_UIPointer pointer)
	{
		foreach (GameObject item in pointer.pointerEventData.hovered)
		{
			if ((bool)pointer.pointerEventData.pointerEnter && (bool)item && CheckTransformTree(item.transform, pointer.pointerEventData.pointerEnter.transform))
			{
				return true;
			}
		}
		return false;
	}

	protected virtual bool ValidElement(GameObject obj)
	{
		Pvr_UICanvas componentInParent = obj.GetComponentInParent<Pvr_UICanvas>();
		if (!componentInParent || !componentInParent.enabled)
		{
			return false;
		}
		return true;
	}

	protected virtual void CheckPointerHoverClick(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		if (pointer.hoverDurationTimer > 0f)
		{
			pointer.hoverDurationTimer -= Time.deltaTime;
		}
		if (pointer.canClickOnHover && pointer.hoverDurationTimer <= 0f)
		{
			pointer.canClickOnHover = false;
			ClickOnDown(pointer, results, forceClick: true);
		}
	}

	protected virtual void Hover(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		if ((bool)pointer.pointerEventData.pointerEnter)
		{
			CheckPointerHoverClick(pointer, results);
			if (!ValidElement(pointer.pointerEventData.pointerEnter))
			{
				pointer.pointerEventData.pointerEnter = null;
				return;
			}
			if (NoValidCollision(pointer, results))
			{
				ExecuteEvents.ExecuteHierarchy(pointer.pointerEventData.pointerEnter, pointer.pointerEventData, ExecuteEvents.pointerExitHandler);
				pointer.pointerEventData.hovered.Remove(pointer.pointerEventData.pointerEnter);
				pointer.pointerEventData.pointerEnter = null;
			}
			if (results.Count <= 0 || !(pointer.pointerEventData.pointerEnter != results[0].gameObject))
			{
				return;
			}
			{
				foreach (RaycastResult result in results)
				{
					if (!ValidElement(result.gameObject))
					{
						continue;
					}
					GameObject gameObject = ExecuteEvents.ExecuteHierarchy(result.gameObject, pointer.pointerEventData, ExecuteEvents.pointerEnterHandler);
					if (gameObject != null)
					{
						Selectable component = gameObject.GetComponent<Selectable>();
						if ((bool)component)
						{
							Navigation navigation = default(Navigation);
							navigation.mode = Navigation.Mode.None;
							component.navigation = navigation;
						}
						pointer.pointerEventData.hovered.Remove(pointer.pointerEventData.pointerEnter);
						pointer.OnUIPointerElementEnter(pointer.SetUIPointerEvent(result, gameObject, pointer.hoveringElement));
						pointer.hoveringElement = gameObject;
						pointer.pointerEventData.pointerCurrentRaycast = result;
						pointer.pointerEventData.pointerEnter = gameObject;
						pointer.pointerEventData.hovered.Add(pointer.pointerEventData.pointerEnter);
						break;
					}
					if (result.gameObject != pointer.hoveringElement)
					{
						pointer.OnUIPointerElementEnter(pointer.SetUIPointerEvent(result, result.gameObject, pointer.hoveringElement));
					}
					pointer.hoveringElement = result.gameObject;
				}
				return;
			}
		}
		foreach (RaycastResult result2 in results)
		{
			if (!ValidElement(result2.gameObject))
			{
				continue;
			}
			GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy(result2.gameObject, pointer.pointerEventData, ExecuteEvents.pointerEnterHandler);
			if (gameObject2 != null)
			{
				Selectable component2 = gameObject2.GetComponent<Selectable>();
				if ((bool)component2)
				{
					Navigation navigation2 = default(Navigation);
					navigation2.mode = Navigation.Mode.None;
					component2.navigation = navigation2;
				}
				pointer.OnUIPointerElementEnter(pointer.SetUIPointerEvent(result2, gameObject2, pointer.hoveringElement));
				pointer.hoveringElement = gameObject2;
				pointer.pointerEventData.pointerCurrentRaycast = result2;
				pointer.pointerEventData.pointerEnter = gameObject2;
				pointer.pointerEventData.hovered.Add(pointer.pointerEventData.pointerEnter);
				break;
			}
			if (result2.gameObject != pointer.hoveringElement)
			{
				pointer.OnUIPointerElementEnter(pointer.SetUIPointerEvent(result2, result2.gameObject, pointer.hoveringElement));
			}
			pointer.hoveringElement = result2.gameObject;
		}
		if ((bool)pointer.hoveringElement && results.Count == 0)
		{
			pointer.OnUIPointerElementExit(pointer.SetUIPointerEvent(default(RaycastResult), null, pointer.hoveringElement));
			pointer.hoveringElement = null;
		}
	}

	protected virtual void Click(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		switch (pointer.clickMethod)
		{
		case Pvr_UIPointer.ClickMethods.ClickOnButtonUp:
			ClickOnUp(pointer, results);
			break;
		case Pvr_UIPointer.ClickMethods.ClickOnButtonDown:
			ClickOnDown(pointer, results);
			break;
		}
	}

	protected virtual void ClickOnUp(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		pointer.pointerEventData.eligibleForClick = pointer.ValidClick(checkLastClick: false);
		if (!AttemptClick(pointer))
		{
			IsEligibleClick(pointer, results);
		}
	}

	protected virtual void ClickOnDown(Pvr_UIPointer pointer, List<RaycastResult> results, bool forceClick = false)
	{
		pointer.pointerEventData.eligibleForClick = forceClick || pointer.ValidClick(checkLastClick: true);
		if (IsEligibleClick(pointer, results))
		{
			pointer.pointerEventData.eligibleForClick = false;
			AttemptClick(pointer);
		}
	}

	protected virtual bool IsEligibleClick(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		if (pointer.pointerEventData.eligibleForClick)
		{
			foreach (RaycastResult result in results)
			{
				if (ValidElement(result.gameObject))
				{
					GameObject gameObject = ExecuteEvents.ExecuteHierarchy(result.gameObject, pointer.pointerEventData, ExecuteEvents.pointerDownHandler);
					if (gameObject != null)
					{
						pointer.pointerEventData.pressPosition = pointer.pointerEventData.position;
						pointer.pointerEventData.pointerPressRaycast = result;
						pointer.pointerEventData.pointerPress = gameObject;
						return true;
					}
				}
			}
		}
		return false;
	}

	protected virtual bool AttemptClick(Pvr_UIPointer pointer)
	{
		if ((bool)pointer.pointerEventData.pointerPress)
		{
			if (!ValidElement(pointer.pointerEventData.pointerPress))
			{
				pointer.pointerEventData.pointerPress = null;
				return true;
			}
			if (pointer.pointerEventData.eligibleForClick)
			{
				if (!IsHovering(pointer))
				{
					ExecuteEvents.ExecuteHierarchy(pointer.pointerEventData.pointerPress, pointer.pointerEventData, ExecuteEvents.pointerUpHandler);
					pointer.pointerEventData.pointerPress = null;
				}
			}
			else
			{
				pointer.OnUIPointerElementClick(pointer.SetUIPointerEvent(pointer.pointerEventData.pointerPressRaycast, pointer.pointerEventData.pointerPress));
				ExecuteEvents.ExecuteHierarchy(pointer.pointerEventData.pointerPress, pointer.pointerEventData, ExecuteEvents.pointerClickHandler);
				ExecuteEvents.ExecuteHierarchy(pointer.pointerEventData.pointerPress, pointer.pointerEventData, ExecuteEvents.pointerUpHandler);
				pointer.pointerEventData.pointerPress = null;
			}
			return true;
		}
		return false;
	}

	protected virtual void Drag(Pvr_UIPointer pointer, List<RaycastResult> results)
	{
		pointer.pointerEventData.dragging = pointer.IsSelectionButtonPressed() && pointer.pointerEventData.delta != Vector2.zero;
		if ((bool)pointer.pointerEventData.pointerDrag)
		{
			if (!ValidElement(pointer.pointerEventData.pointerDrag))
			{
				pointer.pointerEventData.pointerDrag = null;
				return;
			}
			if (pointer.pointerEventData.dragging)
			{
				if (IsHovering(pointer))
				{
					ExecuteEvents.ExecuteHierarchy(pointer.pointerEventData.pointerDrag, pointer.pointerEventData, ExecuteEvents.dragHandler);
				}
				return;
			}
			ExecuteEvents.ExecuteHierarchy(pointer.pointerEventData.pointerDrag, pointer.pointerEventData, ExecuteEvents.dragHandler);
			ExecuteEvents.ExecuteHierarchy(pointer.pointerEventData.pointerDrag, pointer.pointerEventData, ExecuteEvents.endDragHandler);
			foreach (RaycastResult result in results)
			{
				ExecuteEvents.ExecuteHierarchy(result.gameObject, pointer.pointerEventData, ExecuteEvents.dropHandler);
			}
			pointer.pointerEventData.pointerDrag = null;
		}
		else
		{
			if (!pointer.pointerEventData.dragging)
			{
				return;
			}
			foreach (RaycastResult result2 in results)
			{
				if (ValidElement(result2.gameObject))
				{
					ExecuteEvents.ExecuteHierarchy(result2.gameObject, pointer.pointerEventData, ExecuteEvents.initializePotentialDrag);
					ExecuteEvents.ExecuteHierarchy(result2.gameObject, pointer.pointerEventData, ExecuteEvents.beginDragHandler);
					GameObject gameObject = ExecuteEvents.ExecuteHierarchy(result2.gameObject, pointer.pointerEventData, ExecuteEvents.dragHandler);
					if (gameObject != null)
					{
						pointer.pointerEventData.pointerDrag = gameObject;
						break;
					}
				}
			}
		}
	}
}
public class Pvr_UICanvas : MonoBehaviour
{
	public bool clickOnPointerCollision;

	public float autoActivateWithinDistance;

	protected BoxCollider canvasBoxCollider;

	protected Rigidbody canvasRigidBody;

	protected Coroutine draggablePanelCreation;

	protected const string CANVAS_DRAGGABLE_PANEL = "UICANVAS_DRAGGABLE_PANEL";

	protected virtual void OnEnable()
	{
		SetupCanvas();
	}

	protected virtual void OnDisable()
	{
		RemoveCanvas();
	}

	protected virtual void OnDestroy()
	{
		RemoveCanvas();
	}

	protected virtual void SetupCanvas()
	{
		Canvas component = GetComponent<Canvas>();
		if ((bool)component && component.renderMode == RenderMode.WorldSpace)
		{
			RectTransform component2 = component.GetComponent<RectTransform>();
			Vector2 sizeDelta = component2.sizeDelta;
			GraphicRaycaster component3 = component.gameObject.GetComponent<GraphicRaycaster>();
			Pvr_UIGraphicRaycaster pvr_UIGraphicRaycaster = component.gameObject.GetComponent<Pvr_UIGraphicRaycaster>();
			if (!pvr_UIGraphicRaycaster)
			{
				pvr_UIGraphicRaycaster = component.gameObject.AddComponent<Pvr_UIGraphicRaycaster>();
			}
			if ((bool)component3 && component3.enabled)
			{
				pvr_UIGraphicRaycaster.ignoreReversedGraphics = component3.ignoreReversedGraphics;
				pvr_UIGraphicRaycaster.blockingObjects = component3.blockingObjects;
				component3.enabled = false;
			}
			if (!component.gameObject.GetComponent<BoxCollider>())
			{
				float z = 0.1f / component2.localScale.z;
				canvasBoxCollider = component.gameObject.AddComponent<BoxCollider>();
				canvasBoxCollider.size = new Vector3(sizeDelta.x, sizeDelta.y, z);
				canvasBoxCollider.isTrigger = true;
			}
			if (!component.gameObject.GetComponent<Rigidbody>())
			{
				canvasRigidBody = component.gameObject.AddComponent<Rigidbody>();
				canvasRigidBody.isKinematic = true;
			}
			draggablePanelCreation = StartCoroutine(CreateDraggablePanel(component, sizeDelta));
		}
	}

	protected virtual IEnumerator CreateDraggablePanel(Canvas canvas, Vector2 canvasSize)
	{
		if ((bool)canvas && !canvas.transform.Find("UICANVAS_DRAGGABLE_PANEL"))
		{
			yield return null;
			GameObject obj = new GameObject("UICANVAS_DRAGGABLE_PANEL", typeof(RectTransform));
			obj.AddComponent<LayoutElement>().ignoreLayout = true;
			obj.AddComponent<Image>().color = Color.clear;
			obj.AddComponent<EventTrigger>();
			obj.transform.SetParent(canvas.transform);
			obj.GetComponent<RectTransform>().sizeDelta = canvasSize;
			obj.transform.localPosition = Vector3.zero;
			obj.transform.localRotation = Quaternion.identity;
			obj.transform.localScale = Vector3.one;
			obj.transform.SetAsFirstSibling();
		}
	}

	protected virtual void RemoveCanvas()
	{
		Canvas component = GetComponent<Canvas>();
		if ((bool)component)
		{
			GraphicRaycaster component2 = component.gameObject.GetComponent<GraphicRaycaster>();
			Pvr_UIGraphicRaycaster component3 = component.gameObject.GetComponent<Pvr_UIGraphicRaycaster>();
			if ((bool)component3)
			{
				UnityEngine.Object.Destroy(component3);
			}
			if ((bool)component2 && !component2.enabled)
			{
				component2.enabled = true;
			}
			if ((bool)canvasBoxCollider)
			{
				UnityEngine.Object.Destroy(canvasBoxCollider);
			}
			if ((bool)canvasRigidBody)
			{
				UnityEngine.Object.Destroy(canvasRigidBody);
			}
			StopCoroutine(draggablePanelCreation);
			Transform transform = component.transform.Find("UICANVAS_DRAGGABLE_PANEL");
			if ((bool)transform)
			{
				UnityEngine.Object.Destroy(transform.gameObject);
			}
		}
	}
}
public struct UIDraggableItemEventArgs
{
	public GameObject target;
}
public delegate void UIDraggableItemEventHandler(object sender, UIDraggableItemEventArgs e);
public class Pvr_UIDraggableItem : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	public bool restrictToDropZone;

	public bool restrictToOriginalCanvas;

	public float moveOffset = 0.1f;

	[HideInInspector]
	public GameObject validDropZone;

	protected RectTransform dragTransform;

	protected Vector3 startPosition;

	protected Quaternion startRotation;

	protected GameObject startDropZone;

	protected Transform startParent;

	protected Canvas startCanvas;

	protected CanvasGroup canvasGroup;

	protected Pvr_InputModule currentInputmodule;

	public event UIDraggableItemEventHandler DraggableItemDropped;

	public event UIDraggableItemEventHandler DraggableItemReset;

	public virtual void OnDraggableItemDropped(UIDraggableItemEventArgs e)
	{
		if (this.DraggableItemDropped != null)
		{
			this.DraggableItemDropped(this, e);
		}
	}

	public virtual void OnDraggableItemReset(UIDraggableItemEventArgs e)
	{
		if (this.DraggableItemReset != null)
		{
			this.DraggableItemReset(this, e);
		}
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		startPosition = base.transform.position;
		startRotation = base.transform.rotation;
		startParent = base.transform.parent;
		startCanvas = GetComponentInParent<Canvas>();
		canvasGroup.blocksRaycasts = false;
		if (restrictToDropZone)
		{
			startDropZone = GetComponentInParent<Pvr_UIDropZone>().gameObject;
			validDropZone = startDropZone;
		}
		SetDragPosition(eventData);
		Pvr_UIPointer pointer = GetPointer();
		if (pointer != null)
		{
			pointer.OnUIPointerElementDragStart(pointer.SetUIPointerEvent(pointer.pointerEventData.pointerPressRaycast, base.gameObject));
		}
	}

	public void OnDrag(PointerEventData eventData)
	{
		SetDragPosition(eventData);
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		canvasGroup.blocksRaycasts = true;
		dragTransform = null;
		base.transform.position += base.transform.forward * moveOffset;
		bool flag = true;
		if (restrictToDropZone)
		{
			if (validDropZone != null && validDropZone != startDropZone)
			{
				base.transform.SetParent(validDropZone.transform);
			}
			else
			{
				ResetElement();
				flag = false;
			}
		}
		Canvas canvas = ((eventData.pointerEnter != null) ? eventData.pointerEnter.GetComponentInParent<Canvas>() : null);
		if (restrictToOriginalCanvas && canvas != null && canvas != startCanvas)
		{
			ResetElement();
			flag = false;
		}
		if (canvas == null)
		{
			ResetElement();
			flag = false;
		}
		if (flag)
		{
			Pvr_UIPointer pointer = GetPointer();
			if (pointer != null)
			{
				pointer.OnUIPointerElementDragEnd(pointer.SetUIPointerEvent(pointer.pointerEventData.pointerPressRaycast, base.gameObject));
			}
			OnDraggableItemDropped(SetEventPayload(validDropZone));
		}
		validDropZone = null;
		startParent = null;
		startCanvas = null;
	}

	protected virtual void OnEnable()
	{
		canvasGroup = GetComponent<CanvasGroup>();
		if (restrictToDropZone && GetComponentInParent<Pvr_UIDropZone>() == null)
		{
			base.enabled = false;
		}
		currentInputmodule = UnityEngine.Object.FindObjectOfType<Pvr_InputModule>();
	}

	protected virtual Pvr_UIPointer GetPointer()
	{
		foreach (Pvr_UIPointer pointer in Pvr_InputModule.pointers)
		{
			if (pointer.gameObject.activeInHierarchy && (bool)pointer)
			{
				return pointer;
			}
		}
		return null;
	}

	protected virtual void SetDragPosition(PointerEventData eventData)
	{
		if (eventData.pointerEnter != null && eventData.pointerEnter.transform as RectTransform != null)
		{
			dragTransform = eventData.pointerEnter.transform as RectTransform;
		}
		if (dragTransform != null && RectTransformUtility.ScreenPointToWorldPointInRectangle(dragTransform, eventData.position, eventData.pressEventCamera, out var worldPoint))
		{
			base.transform.position = worldPoint - base.transform.forward * moveOffset;
			base.transform.rotation = dragTransform.rotation;
		}
	}

	protected virtual void ResetElement()
	{
		base.transform.position = startPosition;
		base.transform.rotation = startRotation;
		base.transform.SetParent(startParent);
		OnDraggableItemReset(SetEventPayload(startParent.gameObject));
	}

	protected virtual UIDraggableItemEventArgs SetEventPayload(GameObject target)
	{
		UIDraggableItemEventArgs result = default(UIDraggableItemEventArgs);
		result.target = target;
		return result;
	}
}
public class Pvr_UIDropZone : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	protected Pvr_UIDraggableItem droppableItem;

	public void OnPointerEnter(PointerEventData eventData)
	{
		if ((bool)eventData.pointerDrag)
		{
			Pvr_UIDraggableItem component = eventData.pointerDrag.GetComponent<Pvr_UIDraggableItem>();
			if ((bool)component && component.restrictToDropZone)
			{
				component.validDropZone = base.gameObject;
				droppableItem = component;
			}
		}
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		if ((bool)droppableItem)
		{
			droppableItem.validDropZone = null;
		}
		droppableItem = null;
	}
}
public class Pvr_UIGraphicRaycaster : GraphicRaycaster
{
	protected Canvas currentCanvas;

	protected Vector2 lastKnownPosition;

	protected const float UI_CONTROL_OFFSET = 1E-05f;

	[NonSerialized]
	private static List<RaycastResult> s_RaycastResults = new List<RaycastResult>();

	protected virtual Canvas canvas
	{
		get
		{
			if (currentCanvas != null)
			{
				return currentCanvas;
			}
			currentCanvas = base.gameObject.GetComponent<Canvas>();
			return currentCanvas;
		}
	}

	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
		if (!(canvas == null))
		{
			Raycast(ray: new Ray(eventData.pointerCurrentRaycast.worldPosition, eventData.pointerCurrentRaycast.worldNormal), canvas: canvas, eventCamera: eventCamera, results: ref s_RaycastResults);
			SetNearestRaycast(ref eventData, ref resultAppendList, ref s_RaycastResults);
			s_RaycastResults.Clear();
		}
	}

	protected virtual void SetNearestRaycast(ref PointerEventData eventData, ref List<RaycastResult> resultAppendList, ref List<RaycastResult> raycastResults)
	{
		RaycastResult? raycastResult = null;
		for (int i = 0; i < raycastResults.Count; i++)
		{
			RaycastResult raycastResult2 = raycastResults[i];
			raycastResult2.index = resultAppendList.Count;
			if (!raycastResult.HasValue || raycastResult2.distance < raycastResult.Value.distance)
			{
				raycastResult = raycastResult2;
			}
			resultAppendList.Add(raycastResult2);
		}
		if (raycastResult.HasValue)
		{
			eventData.position = raycastResult.Value.screenPosition;
			eventData.delta = eventData.position - lastKnownPosition;
			lastKnownPosition = eventData.position;
			eventData.pointerCurrentRaycast = raycastResult.Value;
		}
	}

	protected virtual float GetHitDistance(Ray ray)
	{
		float result = float.MaxValue;
		if (canvas.renderMode != 0 && base.blockingObjects != 0)
		{
			float num = Vector3.Distance(ray.origin, canvas.transform.position);
			if (base.blockingObjects == BlockingObjects.ThreeD || base.blockingObjects == BlockingObjects.All)
			{
				Physics.Raycast(ray, out var hitInfo, num);
				if ((bool)hitInfo.collider)
				{
					result = hitInfo.distance;
				}
			}
			if (base.blockingObjects == BlockingObjects.TwoD || base.blockingObjects == BlockingObjects.All)
			{
				RaycastHit2D raycastHit2D = Physics2D.Raycast(ray.origin, ray.direction, num);
				if (raycastHit2D.collider != null)
				{
					result = raycastHit2D.fraction * num;
				}
			}
		}
		return result;
	}

	protected virtual void Raycast(Canvas canvas, Camera eventCamera, Ray ray, ref List<RaycastResult> results)
	{
		float hitDistance = GetHitDistance(ray);
		IList<Graphic> graphicsForCanvas = GraphicRegistry.GetGraphicsForCanvas(canvas);
		for (int i = 0; i < graphicsForCanvas.Count; i++)
		{
			Graphic graphic = graphicsForCanvas[i];
			if (graphic.depth == -1 || !graphic.raycastTarget)
			{
				continue;
			}
			Transform transform = graphic.transform;
			Vector3 forward = transform.forward;
			float num = Vector3.Dot(forward, transform.position - ray.origin) / Vector3.Dot(forward, ray.direction);
			if (!(num < 0f) && !(num - 1E-05f > hitDistance))
			{
				Vector3 point = ray.GetPoint(num);
				Vector2 vector = eventCamera.WorldToScreenPoint(point);
				if (RectTransformUtility.RectangleContainsScreenPoint(graphic.rectTransform, vector, eventCamera) && graphic.Raycast(vector, eventCamera))
				{
					RaycastResult raycastResult = default(RaycastResult);
					raycastResult.gameObject = graphic.gameObject;
					raycastResult.module = this;
					raycastResult.distance = num;
					raycastResult.screenPosition = vector;
					raycastResult.worldPosition = point;
					raycastResult.depth = graphic.depth;
					raycastResult.sortingLayer = canvas.sortingLayerID;
					raycastResult.sortingOrder = canvas.sortingOrder;
					RaycastResult item = raycastResult;
					results.Add(item);
				}
			}
		}
		results.Sort((RaycastResult g1, RaycastResult g2) => g2.depth.CompareTo(g1.depth));
	}
}
public struct UIPointerEventArgs
{
	public bool isActive;

	public GameObject currentTarget;

	public GameObject previousTarget;

	public RaycastResult raycastResult;
}
public delegate void UIPointerEventHandler(object sender, UIPointerEventArgs e);
public class Pvr_UIPointer : MonoBehaviour
{
	public enum ClickMethods
	{
		ClickOnButtonUp,
		ClickOnButtonDown
	}

	public ClickMethods clickMethod;

	[HideInInspector]
	public bool collisionClick;

	[HideInInspector]
	public bool pressToDrag;

	[HideInInspector]
	public GameObject autoActivatingCanvas;

	[HideInInspector]
	public PointerEventData pointerEventData;

	[HideInInspector]
	public GameObject hoveringElement;

	[HideInInspector]
	public float hoverDurationTimer;

	[HideInInspector]
	public bool canClickOnHover;

	public Transform pointerOriginTransform;

	protected bool pointerClicked;

	protected bool beamEnabledState;

	protected bool lastPointerPressState;

	protected bool lastPointerClickState;

	protected GameObject currentTarget;

	protected EventSystem cachedEventSystem;

	protected Pvr_InputModule cachedVRInputModule;

	protected Transform originalPointerOriginTransform;

	public static bool TouchBtnValue;

	public static bool AppBtnValue;

	public static bool TriggerBtnValue;

	public event UIPointerEventHandler UIPointerElementEnter;

	public event UIPointerEventHandler UIPointerElementExit;

	public event UIPointerEventHandler UIPointerElementClick;

	public event UIPointerEventHandler UIPointerElementDragStart;

	public event UIPointerEventHandler UIPointerElementDragEnd;

	public virtual bool PointerActive()
	{
		return true;
	}

	public virtual bool IsSelectionButtonPressed()
	{
		if (!Input.GetMouseButton(0) && !Input.GetKey(KeyCode.JoystickButton0) && !TouchBtnValue && !AppBtnValue)
		{
			return TriggerBtnValue;
		}
		return true;
	}

	public virtual Vector3 GetOriginPosition()
	{
		if (!pointerOriginTransform)
		{
			return base.transform.position;
		}
		return pointerOriginTransform.position;
	}

	public virtual Vector3 GetOriginForward()
	{
		if (!pointerOriginTransform)
		{
			return base.transform.forward;
		}
		return pointerOriginTransform.forward;
	}

	public virtual bool ValidClick(bool checkLastClick, bool lastClickState = false)
	{
		bool result = (collisionClick ? collisionClick : IsSelectionButtonPressed());
		if (!checkLastClick)
		{
			return result;
		}
		return result;
	}

	protected virtual void ResetHoverTimer()
	{
		hoverDurationTimer = 0f;
		canClickOnHover = false;
	}

	public virtual void OnUIPointerElementEnter(UIPointerEventArgs e)
	{
		if (e.currentTarget != currentTarget)
		{
			ResetHoverTimer();
		}
		currentTarget = e.currentTarget;
		if (this.UIPointerElementEnter != null)
		{
			this.UIPointerElementEnter(this, e);
		}
	}

	public virtual void OnUIPointerElementExit(UIPointerEventArgs e)
	{
		if (e.previousTarget == currentTarget)
		{
			ResetHoverTimer();
		}
		if (this.UIPointerElementExit != null)
		{
			this.UIPointerElementExit(this, e);
		}
	}

	public virtual void OnUIPointerElementClick(UIPointerEventArgs e)
	{
		if (e.currentTarget == currentTarget)
		{
			ResetHoverTimer();
		}
		if (this.UIPointerElementClick != null)
		{
			this.UIPointerElementClick(this, e);
		}
	}

	public virtual void OnUIPointerElementDragStart(UIPointerEventArgs e)
	{
		if (this.UIPointerElementDragStart != null)
		{
			this.UIPointerElementDragStart(this, e);
		}
	}

	public virtual void OnUIPointerElementDragEnd(UIPointerEventArgs e)
	{
		if (this.UIPointerElementDragEnd != null)
		{
			this.UIPointerElementDragEnd(this, e);
		}
	}

	public virtual UIPointerEventArgs SetUIPointerEvent(RaycastResult currentRaycastResult, GameObject currentTarget, GameObject lastTarget = null)
	{
		UIPointerEventArgs result = default(UIPointerEventArgs);
		result.isActive = PointerActive();
		result.currentTarget = currentTarget;
		result.previousTarget = lastTarget;
		result.raycastResult = currentRaycastResult;
		return result;
	}

	protected virtual void Awake()
	{
		originalPointerOriginTransform = pointerOriginTransform;
	}

	protected virtual void OnEnable()
	{
		pointerOriginTransform = originalPointerOriginTransform;
		ConfigureEventSystem();
		pointerClicked = false;
		lastPointerPressState = false;
		lastPointerClickState = false;
		beamEnabledState = false;
	}

	protected virtual void OnDisable()
	{
		Pvr_InputModule.RemovePoint(this);
	}

	protected virtual void ConfigureEventSystem()
	{
		if (!cachedEventSystem)
		{
			cachedEventSystem = UnityEngine.Object.FindObjectOfType<EventSystem>();
		}
		if (!cachedVRInputModule)
		{
			cachedVRInputModule = cachedEventSystem.GetComponent<Pvr_InputModule>();
		}
		if ((bool)cachedEventSystem && (bool)cachedVRInputModule && pointerEventData == null)
		{
			pointerEventData = new PointerEventData(cachedEventSystem);
		}
		Pvr_InputModule.AddPoint(this);
	}
}
[ExecuteInEditMode]
public class Pvr_UnitySDKEditor : MonoBehaviour
{
	private bool vrModeEnabled = true;

	private float mouseX;

	private float mouseY;

	private float mouseZ;

	private float neckModelScale;

	private bool autoUntiltHead;

	private static readonly Vector3 neckOffset = new Vector3(0f, 0.075f, 0.0805f);

	[HideInInspector]
	public Matrix4x4 headView;

	[HideInInspector]
	public Matrix4x4 leftEyeUndistortedProj;

	[HideInInspector]
	public Matrix4x4 rightEyeUndistortedProj;

	[HideInInspector]
	public Matrix4x4 leftEyeProj;

	[HideInInspector]
	public Matrix4x4 rightEyeProj;

	private const float TOUCH_TIME_LIMIT = 0.2f;

	private float touchStartTime;

	public Matrix4x4 UndistortedProjection(Eye eye)
	{
		if (eye != 0)
		{
			return rightEyeUndistortedProj;
		}
		return leftEyeUndistortedProj;
	}

	public Matrix4x4 Projection(Eye eye)
	{
		if (eye != 0)
		{
			return rightEyeProj;
		}
		return leftEyeProj;
	}

	private void Awake()
	{
		InitEyePara();
		InitEditorSensorPara();
	}

	private void Update()
	{
		SimulateInput();
		Pvr_UnitySDKManager.SDK.picovrTriggered = Pvr_UnitySDKManager.SDK.newPicovrTriggered;
		Pvr_UnitySDKManager.SDK.newPicovrTriggered = false;
	}

	public void InitEyePara()
	{
		ComputeEyesFromProfile();
		InitForEye(ref Pvr_UnitySDKManager.SDK.Eyematerial, ref Pvr_UnitySDKManager.SDK.Middlematerial);
		if (Pvr_UnitySDKRender.Instance == null)
		{
			PLOG.I("pvr_UnitySDKRender init failed");
		}
		if (Pvr_UnitySDKSensor.Instance == null)
		{
			PLOG.I("pvr_UnitySDKSensor init failed");
		}
		FovAdjust();
	}

	private void InitEditorSensorPara()
	{
		Pvr_UnitySDKManager.SDK.picovrTriggered = Pvr_UnitySDKManager.SDK.newPicovrTriggered;
		Pvr_UnitySDKManager.SDK.newPicovrTriggered = false;
	}

	public static Matrix4x4 MakeProjection(float l, float t, float r, float b, float n, float f)
	{
		Matrix4x4 zero = Matrix4x4.zero;
		zero[0, 0] = 2f * n / (r - l);
		zero[1, 1] = 2f * n / (t - b);
		zero[0, 2] = (r + l) / (r - l);
		zero[1, 2] = (t + b) / (t - b);
		zero[2, 2] = (n + f) / (n - f);
		zero[2, 3] = 2f * n * f / (n - f);
		zero[3, 2] = -1f;
		return zero;
	}

	public bool UpdateStatesensor()
	{
		UpdateSimulatedSensor();
		return true;
	}

	public void ComputeEyesFromProfile()
	{
		Vector2 vector = new Vector2(0.11f, 0.062f);
		Pvr_UnitySDKManager.SDK.leftEyeView = Matrix4x4.identity;
		Pvr_UnitySDKManager.SDK.leftEyeView[0, 3] = (0f - Pvr_UnitySDKManager.SDK.pvr_UnitySDKConfig.device.devLenses.separation) / 2f;
		float[] leftEyeVisibleTanAngles = Pvr_UnitySDKManager.SDK.pvr_UnitySDKConfig.GetLeftEyeVisibleTanAngles(vector.x, vector.y);
		leftEyeProj = MakeProjection(leftEyeVisibleTanAngles[0], leftEyeVisibleTanAngles[1], leftEyeVisibleTanAngles[2], leftEyeVisibleTanAngles[3], 1f, 1000f);
		leftEyeVisibleTanAngles = Pvr_UnitySDKManager.SDK.pvr_UnitySDKConfig.GetLeftEyeNoLensTanAngles(vector.x, vector.y);
		leftEyeUndistortedProj = MakeProjection(leftEyeVisibleTanAngles[0], leftEyeVisibleTanAngles[1], leftEyeVisibleTanAngles[2], leftEyeVisibleTanAngles[3], 1f, 1000f);
		Pvr_UnitySDKManager.SDK.leftEyeRect = Pvr_UnitySDKManager.SDK.pvr_UnitySDKConfig.GetLeftEyeVisibleScreenRect(leftEyeVisibleTanAngles, vector.x, vector.y);
		Pvr_UnitySDKManager.SDK.rightEyeView = Pvr_UnitySDKManager.SDK.leftEyeView;
		Pvr_UnitySDKManager.SDK.rightEyeView[0, 3] *= -1f;
		rightEyeProj = leftEyeProj;
		rightEyeProj[0, 2] *= -1f;
		rightEyeUndistortedProj = leftEyeUndistortedProj;
		rightEyeUndistortedProj[0, 2] *= -1f;
		Rect leftEyeRect = new Rect(0f, 0f, 0.5f, 1f);
		Rect rightEyeRect = new Rect(0.5f, 0f, 0.5f, 1f);
		Pvr_UnitySDKManager.SDK.leftEyeRect = leftEyeRect;
		Pvr_UnitySDKManager.SDK.rightEyeRect = rightEyeRect;
		Pvr_UnitySDKManager.SDK.leftEyeOffset = new Vector3((0f - Pvr_UnitySDKManager.SDK.pvr_UnitySDKConfig.device.devLenses.separation) / 2f, 0f, 0f);
		Pvr_UnitySDKManager.SDK.rightEyeOffset = new Vector3(Pvr_UnitySDKManager.SDK.pvr_UnitySDKConfig.device.devLenses.separation / 2f, 0f, 0f);
	}

	public bool ResetUnitySDKSensor()
	{
		mouseX = (mouseY = (mouseZ = 0f));
		return true;
	}

	private void SimulateInput()
	{
		if (Input.GetMouseButtonDown(0) && (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt)))
		{
			EnableVEmodel();
		}
		if (Input.GetMouseButtonDown(0))
		{
			touchStartTime = Time.time;
		}
		else if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - touchStartTime <= 0.2f)
			{
				Pvr_UnitySDKManager.SDK.newPicovrTriggered = true;
			}
			touchStartTime = 0f;
		}
		UpdateSimulatedSensor();
	}

	private void FovAdjust()
	{
		Pvr_UnitySDKRender.Instance.EyeVFoV = 2f * Pvr_UnitySDKManager.SDK.pvr_UnitySDKConfig.device.devMaxFov.upper;
	}

	private Rect RectAdjust(Rect eyeRect)
	{
		Rect result = new Rect(0f, 0f, 0.5f, 1f);
		result.width *= 2f * eyeRect.width;
		result.x = eyeRect.x + 2f * result.x * eyeRect.width;
		result.height *= eyeRect.height;
		result.y = eyeRect.y + result.y * eyeRect.height;
		return result;
	}

	private void UpdateSimulatedSensor()
	{
		bool flag = false;
		if (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt))
		{
			mouseX += Input.GetAxis("Mouse X") * 5f;
			if (mouseX <= -180f)
			{
				mouseX += 360f;
			}
			else if (mouseX > 180f)
			{
				mouseX -= 360f;
			}
			mouseY -= Input.GetAxis("Mouse Y") * 2.4f;
			mouseY = Mathf.Clamp(mouseY, -91f, 91f);
		}
		else if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
		{
			flag = true;
			mouseZ += Input.GetAxis("Mouse X") * 5f;
			mouseZ = Mathf.Clamp(mouseZ, -91f, 91f);
		}
		if (!flag && autoUntiltHead)
		{
			mouseZ = Mathf.Lerp(mouseZ, 0f, Time.deltaTime / (Time.deltaTime + 0.1f));
		}
		Quaternion quaternion = Quaternion.Euler(mouseY, mouseX, mouseZ);
		Matrix4x4 matrix = Matrix4x4.TRS((quaternion * neckOffset - neckOffset.y * Vector3.up) * neckModelScale, quaternion, Vector3.one);
		Pvr_UnitySDKSensor.Instance.HeadPose = new Pvr_UnitySDKPose(matrix);
	}

	private void InitForEye(ref Material mat, ref Material mat1)
	{
		Shader shader = Shader.Find("Pvr_UnitySDK/Undistortion");
		Shader shader2 = Shader.Find("Pvr_UnitySDK/FillColor");
		if (shader == null || shader2 == null)
		{
			PLOG.E("Ths Shader Missing ！");
			return;
		}
		mat = new Material(shader);
		mat1 = new Material(shader2);
	}

	private void EnableVEmodel()
	{
		vrModeEnabled = !vrModeEnabled;
		Pvr_UnitySDKManager.SDK.VRModeEnabled = vrModeEnabled;
	}
}
public class Pvr_VolumePowerBrightness : MonoBehaviour
{
	private bool VolEnable;

	private bool BattEnable;

	public Text showResult;

	public Text setVolumnum;

	public Text setBrightnum;

	public string MusicPath;

	private void Awake()
	{
		InitBatteryVolClass();
		string startreceivre = base.gameObject.name;
		StartBatteryReceiver(startreceivre);
		StartAudioReceiver(startreceivre);
	}

	private void OnDisable()
	{
		if (VolEnable)
		{
			StopAudioReceiver();
		}
		if (BattEnable)
		{
			StopBatteryReceiver();
		}
	}

	public void GetMaxVolumeNumber()
	{
		int num = 0;
		num = VolumePowerBrightness.UPvr_GetMaxVolumeNumber();
		showResult.text = "Maximum volume: " + num;
	}

	public void GetCurrentVolumeNumber()
	{
		int num = 0;
		num = VolumePowerBrightness.UPvr_GetCurrentVolumeNumber();
		showResult.text = "Current volume：" + num;
	}

	public void VolumeUp()
	{
		if (!VolumePowerBrightness.UPvr_VolumeUp())
		{
			PLOG.E("VolumeUp Error");
		}
	}

	public void VolumeDown()
	{
		if (!VolumePowerBrightness.UPvr_VolumeDown())
		{
			PLOG.E("VolumeDown Error");
		}
	}

	public void SetVolumeNum()
	{
		int volume = new System.Random().Next(0, 15);
		setVolumnum.text = "Random number：" + volume;
		if (!VolumePowerBrightness.UPvr_SetVolumeNum(volume))
		{
			PLOG.E("SetVolumeNum Error");
		}
	}

	public void SetBrightness()
	{
		int brightness = new System.Random().Next(0, 255);
		setBrightnum.text = "Random number：" + brightness;
		if (!VolumePowerBrightness.UPvr_SetCommonBrightness(brightness))
		{
			PLOG.E("SetBrightness Error");
		}
	}

	public void GetCurrentBrightness()
	{
		int num = 0;
		num = VolumePowerBrightness.UPvr_GetCommonBrightness();
		showResult.text = "Current brightness：" + num;
	}

	public bool setAudio(string s)
	{
		PLOG.I(s.ToString());
		return true;
	}

	public bool setBattery(string s)
	{
		PLOG.I(s.ToString());
		return true;
	}

	private bool InitBatteryVolClass()
	{
		return VolumePowerBrightness.UPvr_InitBatteryVolClass();
	}

	private bool StartBatteryReceiver(string startreceivre)
	{
		BattEnable = VolumePowerBrightness.UPvr_StartBatteryReceiver(startreceivre);
		return BattEnable;
	}

	private bool StopBatteryReceiver()
	{
		return VolumePowerBrightness.UPvr_StopBatteryReceiver();
	}

	private bool StartAudioReceiver(string startreceivre)
	{
		VolEnable = VolumePowerBrightness.UPvr_StartAudioReceiver(startreceivre);
		return VolEnable;
	}

	private bool StopAudioReceiver()
	{
		return VolumePowerBrightness.UPvr_StopAudioReceiver();
	}
}
namespace BoundarySystem_Ext
{
	internal static class Pvr_BoundaryAPI
	{
		private const string LibFileName = "Pvr_UnitySDK";

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_StartSDKBoundary();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_ShutdownSDKBoundary();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetMainSensorStateExt(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr Pvr_GetCameraData_Ext();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_ResetVrModebyForce();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_ResumeBoundaryForSTS();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_PauseBoundaryForSTS();

		public static int UPvr_GetMainSensorStateExt(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber)
		{
			return Pvr_GetMainSensorStateExt(ref x, ref y, ref z, ref w, ref px, ref py, ref pz, ref vfov, ref hfov, ref viewNumber);
		}

		public static IntPtr UPvr_GetCameraData_Ext()
		{
			_ = IntPtr.Zero;
			return Pvr_GetCameraData_Ext();
		}

		public static bool UPvr_ResumeBoundaryForSTS()
		{
			return Pvr_ResumeBoundaryForSTS();
		}

		public static void UPvr_PauseBoundaryForSTS()
		{
			Pvr_PauseBoundaryForSTS();
		}

		public static IntPtr StructToIntPtr<T>(T info)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(info));
			Marshal.StructureToPtr(info, intPtr, fDeleteOld: true);
			return intPtr;
		}

		public static T IntPtrToStruct<T>(IntPtr info)
		{
			return (T)Marshal.PtrToStructure(info, typeof(T));
		}
	}
	internal static class Pvr_SafeAreaAlgoAPI
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SafeAreaCallback(IntPtr lineCollectionPtr, IntPtr safeAreaRectPtr);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void SafeAreaCallbackShrink(IntPtr lineCollectionPtr, IntPtr safeAreaDetailRectPtr);

		public struct GSAPoint3i
		{
			public int x;

			public int y;

			public int z;
		}

		public struct GSALine
		{
			public IntPtr pointArray;

			public int pointCount;
		}

		public struct GSALineCollection
		{
			public IntPtr lineArray;

			public int lineCount;
		}

		public struct GSALegalData
		{
			public int overMaxRange;

			public int includeBigGrap;

			public int bigGapNum;

			public int centerOut;

			public int removeNarrow;

			public int overMaxRange_more;

			public int validShrinkArea;
		}

		public struct GSARect
		{
			public GSAPoint3i leftup;

			public GSAPoint3i leftdown;

			public GSAPoint3i rightup;

			public GSAPoint3i rightdown;

			public GSAPoint3i center;

			public uint width;

			public uint height;

			public int isLegal;

			public GSALegalData legalData;
		}

		private const string LibFileName = "SafetyArea";

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSAInit(int width, int height);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSAShutDown();

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSASetCallback(SafeAreaCallback cb);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSASetCallbackShrink(SafeAreaCallbackShrink cb);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSAUpDateData(IntPtr lineCollectionPtr);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSASetConfigFilePath(IntPtr configPath);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool GSAGetClosedAreaUpdateFlag();

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSALoadSafetyArea(IntPtr lineCollectionPtr);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern double GSABoundaryDetector(ref GSAPoint3i pointPtr);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern int GSALoadSafetyArea2(IntPtr lineCollectionPtr, bool isPlayArea);

		[DllImport("SafetyArea", CallingConvention = CallingConvention.Cdecl)]
		private static extern double GSABoundaryDetector2(ref GSAPoint3i point, bool isPlayArea, ref GSAPoint3i closestPoint, ref GSAPoint3i normalDir);

		public static int Pvr_GSAInit(int width, int height)
		{
			return GSAInit(width, height);
		}

		public static int Pvr_GSASetCallback(SafeAreaCallback cb)
		{
			return GSASetCallback(cb);
		}

		public static int Pvr_GSASetCallbackShrink(SafeAreaCallbackShrink cb)
		{
			return GSASetCallbackShrink(cb);
		}

		public static int Pvr_GSAUpDateData(IntPtr lineCollectionPtr)
		{
			return GSAUpDateData(lineCollectionPtr);
		}

		public static bool Pvr_GSAGetClosedAreaUpdateFlag()
		{
			return GSAGetClosedAreaUpdateFlag();
		}

		public static int Pvr_GSASetConfigFilePath(string configPath)
		{
			int num = -1;
			IntPtr intPtr = Marshal.StringToHGlobalAnsi(configPath);
			num = GSASetConfigFilePath(intPtr);
			Marshal.FreeHGlobal(intPtr);
			return num;
		}

		public static int Pvr_GSALoadSafetyArea(IntPtr lineCollectionPtr)
		{
			return GSALoadSafetyArea(lineCollectionPtr);
		}

		public static double Pvr_GSABoundaryDetector(ref GSAPoint3i point)
		{
			return GSABoundaryDetector(ref point);
		}

		public static int Pvr_GSAShutDown()
		{
			return GSAShutDown();
		}

		public static int Pvr_GSALoadSafetyArea2(IntPtr lineCollectionPtr, bool isPlayArea)
		{
			return GSALoadSafetyArea2(lineCollectionPtr, isPlayArea);
		}

		public static double Pvr_GSABoundaryDetector2(ref GSAPoint3i point, bool isPlayArea, ref GSAPoint3i closestPoint, ref GSAPoint3i normalDir)
		{
			return GSABoundaryDetector2(ref point, isPlayArea, ref closestPoint, ref normalDir);
		}
	}
	public class Pvr_BoundarySystem
	{
		private static Pvr_BoundarySystem instance;

		public const int CameraImageWidth = 1280;

		public const int CameraImageHeight = 400;

		public IntPtr CameraFramePtr = IntPtr.Zero;

		public static Pvr_BoundarySystem Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Pvr_BoundarySystem();
				}
				return instance;
			}
		}

		public void OpenBoundary()
		{
			Pvr_BoundaryAPI.Pvr_StartSDKBoundary();
		}

		public void CloseBoundary()
		{
			Pvr_BoundaryAPI.Pvr_ShutdownSDKBoundary();
		}

		public void Reset6Dof()
		{
			Pvr_BoundaryAPI.Pvr_ResetVrModebyForce();
		}

		public float[] GetControllerFixedPoseData(int hand)
		{
			float[] result = new float[7] { 0f, 0f, 0f, 1f, 0f, 0f, 0f };
			if (Pvr_ControllerManager.controllerlink != null)
			{
				Pvr_UnitySDKAPI.System.UPvr_CallStaticMethod(ref result, Pvr_ControllerManager.controllerlink.javaCVClass, "getControllerFixedSensorState", hand);
			}
			result[2] = 0f - result[2];
			result[3] = 0f - result[3];
			return result;
		}
	}
	public class Pvr_SafeAreaAlgoModule
	{
		public struct ExtraInfo
		{
			public bool overMaxRange;

			public bool includeBigGap;

			public int bigGapNum;

			public bool centerOut;

			public bool removeNarrow;

			public bool overMaxRange_more;

			public int validShrinkArea;
		}

		public struct BoundaryPlayerArea
		{
			public Vector3 lowerleft;

			public Vector3 upperleft;

			public Vector3 upperRight;

			public Vector3 lowerRight;

			public Vector3 center;

			public uint width;

			public uint height;

			public bool isLegal;

			public ExtraInfo extraInfo;
		}

		public delegate void BoundarySystemCallback(BoundaryPlayerArea playAreaInfo, List<Vector3> boundaryPoints, List<List<Vector3>> unusedLines);

		public delegate void BoundarySystemCallbackShrink(List<Vector3> rectPoints, List<Vector3> boundaryPoints, List<List<Vector3>> unusedLines);

		private static Pvr_SafeAreaAlgoModule instance;

		private BoundarySystemCallback boundarySystemCallback;

		private BoundarySystemCallbackShrink boundarySystemCallbackShrink;

		public static Pvr_SafeAreaAlgoModule Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Pvr_SafeAreaAlgoModule();
				}
				return instance;
			}
		}

		public void RegisterCallBack(BoundarySystemCallback callback)
		{
			boundarySystemCallback = callback;
		}

		public void RegisterCallBackShrink(BoundarySystemCallbackShrink callback)
		{
			boundarySystemCallbackShrink = callback;
		}

		public bool Start()
		{
			int num = Pvr_SafeAreaAlgoAPI.Pvr_GSASetCallback(_SafeAreaCallback);
			int num2 = Pvr_SafeAreaAlgoAPI.Pvr_GSASetCallbackShrink(_SafeAreaCallbackShrink);
			if (num != 0 || num2 != 0)
			{
				UnityEngine.Debug.LogError("BoundarySystem register callback failed!");
				return false;
			}
			if (Pvr_SafeAreaAlgoAPI.Pvr_GSAInit(300, 300) != 0)
			{
				UnityEngine.Debug.LogError("BoundarySystem init failed!");
				return false;
			}
			return true;
		}

		public bool CommitNewLineData(bool isFistLine, Vector3[] points)
		{
			Pvr_SafeAreaAlgoAPI.GSALineCollection info = default(Pvr_SafeAreaAlgoAPI.GSALineCollection);
			info.lineCount = 2;
			Pvr_SafeAreaAlgoAPI.GSALine[] array = new Pvr_SafeAreaAlgoAPI.GSALine[2];
			if (isFistLine)
			{
				array[0].pointArray = IntPtr.Zero;
				array[0].pointCount = 0;
			}
			else
			{
				Pvr_SafeAreaAlgoAPI.GSAPoint3i[] arr = new Pvr_SafeAreaAlgoAPI.GSAPoint3i[1]
				{
					new Pvr_SafeAreaAlgoAPI.GSAPoint3i
					{
						x = 0,
						y = 0,
						z = 0
					}
				};
				array[0].pointArray = Marshal.UnsafeAddrOfPinnedArrayElement(arr, 0);
				array[0].pointCount = 1;
			}
			Pvr_SafeAreaAlgoAPI.GSAPoint3i[] array2 = new Pvr_SafeAreaAlgoAPI.GSAPoint3i[points.Length];
			for (int i = 0; i < points.Length; i++)
			{
				Pvr_SafeAreaAlgoAPI.GSAPoint3i gSAPoint3i = default(Pvr_SafeAreaAlgoAPI.GSAPoint3i);
				gSAPoint3i.x = (int)(points[i].x * 1000f);
				gSAPoint3i.y = (int)(points[i].y * 1000f);
				gSAPoint3i.z = (int)(points[i].z * 1000f);
				array2[i] = gSAPoint3i;
			}
			array[1].pointArray = Marshal.UnsafeAddrOfPinnedArrayElement(array2, 0);
			array[1].pointCount = array2.Length;
			info.lineArray = Marshal.UnsafeAddrOfPinnedArrayElement(array, 0);
			IntPtr intPtr = Pvr_BoundaryAPI.StructToIntPtr(info);
			int num = Pvr_SafeAreaAlgoAPI.Pvr_GSAUpDateData(intPtr);
			Marshal.FreeHGlobal(intPtr);
			if (num != 0)
			{
				UnityEngine.Debug.LogError("BoundarySystem commit new line data failed!");
				return false;
			}
			return true;
		}

		public bool Shutdown()
		{
			if (Pvr_SafeAreaAlgoAPI.Pvr_GSAShutDown() != 0)
			{
				UnityEngine.Debug.LogError("BoundarySystem shutdown failed!");
				return false;
			}
			return true;
		}

		public double QueryDistanceOfPoint(Vector3 point)
		{
			Pvr_SafeAreaAlgoAPI.GSAPoint3i point2 = default(Pvr_SafeAreaAlgoAPI.GSAPoint3i);
			point2.x = (int)(point.x * 1000f);
			point2.y = (int)(point.y * 1000f);
			point2.z = (int)(point.z * 1000f);
			return Pvr_SafeAreaAlgoAPI.Pvr_GSABoundaryDetector(ref point2) / 1000.0;
		}

		public double QueryDistanceOfPoint(Vector3 point, bool isPlayArea, ref Vector3 closestPoint, ref Vector3 normalDir)
		{
			Pvr_SafeAreaAlgoAPI.GSAPoint3i point2 = default(Pvr_SafeAreaAlgoAPI.GSAPoint3i);
			point2.x = (int)(point.x * 1000f);
			point2.y = (int)(point.y * 1000f);
			point2.z = (int)(point.z * 1000f);
			Pvr_SafeAreaAlgoAPI.GSAPoint3i closestPoint2 = default(Pvr_SafeAreaAlgoAPI.GSAPoint3i);
			Pvr_SafeAreaAlgoAPI.GSAPoint3i normalDir2 = default(Pvr_SafeAreaAlgoAPI.GSAPoint3i);
			double num = Pvr_SafeAreaAlgoAPI.Pvr_GSABoundaryDetector2(ref point2, isPlayArea, ref closestPoint2, ref normalDir2);
			closestPoint.x = (float)closestPoint2.x / 1000f;
			closestPoint.y = (float)closestPoint2.y / 1000f;
			closestPoint.z = (float)closestPoint2.z / 1000f;
			normalDir.x = (float)normalDir2.x / 1000f;
			normalDir.y = (float)normalDir2.y / 1000f;
			normalDir.z = (float)normalDir2.z / 1000f;
			return num / 1000.0;
		}

		[MonoPInvokeCallback(typeof(Pvr_SafeAreaAlgoAPI.SafeAreaCallback))]
		private static void _SafeAreaCallback(IntPtr lineCollectionPtr, IntPtr safeAreaRectPtr)
		{
			if (lineCollectionPtr == IntPtr.Zero || safeAreaRectPtr == IntPtr.Zero)
			{
				UnityEngine.Debug.LogError("BoundarySystem callback is inValid!");
			}
			else
			{
				if (instance.boundarySystemCallback == null)
				{
					return;
				}
				List<Vector3> boundaryPoints = new List<Vector3>();
				List<List<Vector3>> list = new List<List<Vector3>>();
				int num = Marshal.SizeOf(typeof(Pvr_SafeAreaAlgoAPI.GSALine));
				int num2 = Marshal.SizeOf(typeof(Pvr_SafeAreaAlgoAPI.GSAPoint3i));
				Pvr_SafeAreaAlgoAPI.GSALineCollection gSALineCollection = Pvr_BoundaryAPI.IntPtrToStruct<Pvr_SafeAreaAlgoAPI.GSALineCollection>(lineCollectionPtr);
				for (int i = 0; i < gSALineCollection.lineCount; i++)
				{
					Pvr_SafeAreaAlgoAPI.GSALine gSALine = (Pvr_SafeAreaAlgoAPI.GSALine)Marshal.PtrToStructure(new IntPtr(gSALineCollection.lineArray.ToInt64() + num * i), typeof(Pvr_SafeAreaAlgoAPI.GSALine));
					List<Vector3> list2 = new List<Vector3>();
					for (int j = 0; j < gSALine.pointCount; j++)
					{
						Pvr_SafeAreaAlgoAPI.GSAPoint3i gSAPoint3i = (Pvr_SafeAreaAlgoAPI.GSAPoint3i)Marshal.PtrToStructure(new IntPtr(gSALine.pointArray.ToInt64() + num2 * j), typeof(Pvr_SafeAreaAlgoAPI.GSAPoint3i));
						list2.Add(new Vector3((float)gSAPoint3i.x / 1000f, (float)gSAPoint3i.y / 1000f, (float)gSAPoint3i.z / 1000f));
					}
					if (i == 0)
					{
						boundaryPoints = list2;
					}
					else
					{
						list.Add(list2);
					}
				}
				Pvr_SafeAreaAlgoAPI.GSARect gSARect = Pvr_BoundaryAPI.IntPtrToStruct<Pvr_SafeAreaAlgoAPI.GSARect>(safeAreaRectPtr);
				BoundaryPlayerArea playAreaInfo = default(BoundaryPlayerArea);
				playAreaInfo.lowerleft = new Vector3((float)gSARect.leftup.x / 1000f, (float)gSARect.leftup.y / 1000f, (float)gSARect.leftup.z / 1000f);
				playAreaInfo.upperleft = new Vector3((float)gSARect.leftdown.x / 1000f, (float)gSARect.leftdown.y / 1000f, (float)gSARect.leftdown.z / 1000f);
				playAreaInfo.upperRight = new Vector3((float)gSARect.rightdown.x / 1000f, (float)gSARect.rightdown.y / 1000f, (float)gSARect.rightdown.z / 1000f);
				playAreaInfo.lowerRight = new Vector3((float)gSARect.rightup.x / 1000f, (float)gSARect.rightup.y / 1000f, (float)gSARect.rightup.z / 1000f);
				playAreaInfo.center = new Vector3((float)gSARect.center.x / 1000f, (float)gSARect.center.y / 1000f, (float)gSARect.center.z / 1000f);
				playAreaInfo.width = gSARect.width;
				playAreaInfo.height = gSARect.height;
				playAreaInfo.isLegal = ((gSARect.isLegal != 0) ? true : false);
				playAreaInfo.extraInfo.overMaxRange = ((gSARect.legalData.overMaxRange != 0) ? true : false);
				playAreaInfo.extraInfo.includeBigGap = ((gSARect.legalData.includeBigGrap != 0) ? true : false);
				playAreaInfo.extraInfo.bigGapNum = gSARect.legalData.bigGapNum;
				playAreaInfo.extraInfo.centerOut = ((gSARect.legalData.centerOut != 0) ? true : false);
				playAreaInfo.extraInfo.removeNarrow = ((gSARect.legalData.removeNarrow != 0) ? true : false);
				playAreaInfo.extraInfo.overMaxRange_more = ((gSARect.legalData.overMaxRange_more != 0) ? true : false);
				playAreaInfo.extraInfo.validShrinkArea = gSARect.legalData.validShrinkArea;
				instance.boundarySystemCallback(playAreaInfo, boundaryPoints, list);
			}
		}

		[MonoPInvokeCallback(typeof(Pvr_SafeAreaAlgoAPI.SafeAreaCallbackShrink))]
		private static void _SafeAreaCallbackShrink(IntPtr lineCollectionPtr, IntPtr safeAreaDetailRectPtr)
		{
			if (lineCollectionPtr == IntPtr.Zero || safeAreaDetailRectPtr == IntPtr.Zero)
			{
				UnityEngine.Debug.LogError("BoundarySystem callback is inValid!");
			}
			else
			{
				if (instance.boundarySystemCallbackShrink == null)
				{
					return;
				}
				List<Vector3> boundaryPoints = new List<Vector3>();
				List<List<Vector3>> list = new List<List<Vector3>>();
				int num = Marshal.SizeOf(typeof(Pvr_SafeAreaAlgoAPI.GSALine));
				int num2 = Marshal.SizeOf(typeof(Pvr_SafeAreaAlgoAPI.GSAPoint3i));
				Pvr_SafeAreaAlgoAPI.GSALineCollection gSALineCollection = Pvr_BoundaryAPI.IntPtrToStruct<Pvr_SafeAreaAlgoAPI.GSALineCollection>(lineCollectionPtr);
				for (int i = 0; i < gSALineCollection.lineCount; i++)
				{
					Pvr_SafeAreaAlgoAPI.GSALine gSALine = (Pvr_SafeAreaAlgoAPI.GSALine)Marshal.PtrToStructure(new IntPtr(gSALineCollection.lineArray.ToInt64() + num * i), typeof(Pvr_SafeAreaAlgoAPI.GSALine));
					List<Vector3> list2 = new List<Vector3>();
					for (int j = 0; j < gSALine.pointCount; j++)
					{
						Pvr_SafeAreaAlgoAPI.GSAPoint3i gSAPoint3i = (Pvr_SafeAreaAlgoAPI.GSAPoint3i)Marshal.PtrToStructure(new IntPtr(gSALine.pointArray.ToInt64() + num2 * j), typeof(Pvr_SafeAreaAlgoAPI.GSAPoint3i));
						list2.Add(new Vector3((float)gSAPoint3i.x / 1000f, (float)gSAPoint3i.y / 1000f, (float)gSAPoint3i.z / 1000f));
					}
					if (i == 0)
					{
						boundaryPoints = list2;
					}
					else
					{
						list.Add(list2);
					}
				}
				List<Vector3> list3 = new List<Vector3>();
				Pvr_SafeAreaAlgoAPI.GSALineCollection gSALineCollection2 = Pvr_BoundaryAPI.IntPtrToStruct<Pvr_SafeAreaAlgoAPI.GSALineCollection>(safeAreaDetailRectPtr);
				for (int k = 0; k < gSALineCollection2.lineCount; k++)
				{
					Pvr_SafeAreaAlgoAPI.GSALine gSALine2 = (Pvr_SafeAreaAlgoAPI.GSALine)Marshal.PtrToStructure(new IntPtr(gSALineCollection2.lineArray.ToInt64() + num * k), typeof(Pvr_SafeAreaAlgoAPI.GSALine));
					for (int l = 0; l < gSALine2.pointCount; l++)
					{
						Pvr_SafeAreaAlgoAPI.GSAPoint3i gSAPoint3i2 = (Pvr_SafeAreaAlgoAPI.GSAPoint3i)Marshal.PtrToStructure(new IntPtr(gSALine2.pointArray.ToInt64() + num2 * l), typeof(Pvr_SafeAreaAlgoAPI.GSAPoint3i));
						list3.Add(new Vector3((float)gSAPoint3i2.x / 1000f, (float)gSAPoint3i2.y / 1000f, (float)gSAPoint3i2.z / 1000f));
					}
				}
				instance.boundarySystemCallbackShrink(list3, boundaryPoints, list);
			}
		}
	}
}
namespace Pvr_UnitySDKAPI
{
	public class PvrControllerKey
	{
		public bool State;

		public bool PressedDown;

		public bool PressedUp;

		public bool LongPressed;

		public bool Click;

		public bool Touch;

		public bool TouchDown;

		public bool TouchUp;

		public PvrControllerKey()
		{
			State = false;
			PressedDown = false;
			PressedUp = false;
			LongPressed = false;
			Click = false;
			Touch = false;
			TouchDown = false;
			TouchUp = false;
		}
	}
	public class ControllerHand
	{
		public PvrControllerKey App;

		public PvrControllerKey Touch;

		public PvrControllerKey Home;

		public PvrControllerKey VolumeDown;

		public PvrControllerKey VolumeUp;

		public PvrControllerKey Trigger;

		public PvrControllerKey X;

		public PvrControllerKey Y;

		public PvrControllerKey A;

		public PvrControllerKey B;

		public PvrControllerKey Left;

		public PvrControllerKey Right;

		public PvrControllerKey Thumbrest;

		public Vector2 TouchPadPosition;

		public int TriggerNum;

		public int GripValue;

		public Quaternion Rotation;

		public Vector3 Position;

		public int Battery;

		public ControllerState ConnectState;

		public SwipeDirection SwipeDirection;

		public TouchPadClick TouchPadClick;

		public bool isShowBoundary;

		public ControllerHand()
		{
			App = new PvrControllerKey();
			Touch = new PvrControllerKey();
			Home = new PvrControllerKey();
			VolumeDown = new PvrControllerKey();
			VolumeUp = new PvrControllerKey();
			Trigger = new PvrControllerKey();
			A = new PvrControllerKey();
			B = new PvrControllerKey();
			X = new PvrControllerKey();
			Y = new PvrControllerKey();
			Left = new PvrControllerKey();
			Right = new PvrControllerKey();
			Thumbrest = new PvrControllerKey();
			TouchPadPosition = default(Vector2);
			Rotation = default(Quaternion);
			Position = default(Vector3);
			Battery = 0;
			TriggerNum = 0;
			GripValue = 0;
			ConnectState = ControllerState.Error;
			SwipeDirection = SwipeDirection.No;
			TouchPadClick = TouchPadClick.No;
			isShowBoundary = false;
		}
	}
	public enum ControllerState
	{
		Error = -1,
		DisConnected,
		Connected
	}
	public enum Pvr_KeyCode
	{
		None = 0,
		APP = 1,
		TOUCHPAD = 2,
		HOME = 4,
		VOLUMEUP = 8,
		VOLUMEDOWN = 16,
		TRIGGER = 32,
		A = 64,
		B = 128,
		X = 256,
		Y = 512,
		Left = 1024,
		Right = 2048,
		Thumbrest = 4096,
		Any = -1
	}
	public enum SwipeDirection
	{
		No,
		SwipeUp,
		SwipeDown,
		SwipeLeft,
		SwipeRight
	}
	public enum TouchPadClick
	{
		No,
		ClickUp,
		ClickDown,
		ClickLeft,
		ClickRight
	}
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Controller
	{
		private const float JOYSTICK_THRESHOLD = 0.4f;

		public const string LibFileName = "Pvr_UnitySDK";

		public static Vector2 UPvr_GetTouchPadPosition(int hand)
		{
			return hand switch
			{
				0 => Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition, 
				1 => Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition, 
				_ => new Vector2(0f, 0f), 
			};
		}

		public static float UPvr_GetAxis1D(int hand, Pvr_KeyCode key)
		{
			return hand switch
			{
				0 => key switch
				{
					Pvr_KeyCode.TRIGGER => (float)Pvr_ControllerManager.controllerlink.Controller0.TriggerNum / 255f, 
					Pvr_KeyCode.Left => (float)Pvr_ControllerManager.controllerlink.Controller0.GripValue / 255f, 
					_ => 0f, 
				}, 
				1 => key switch
				{
					Pvr_KeyCode.TRIGGER => (float)Pvr_ControllerManager.controllerlink.Controller1.TriggerNum / 255f, 
					Pvr_KeyCode.Right => (float)Pvr_ControllerManager.controllerlink.Controller1.GripValue / 255f, 
					_ => 0f, 
				}, 
				_ => 0f, 
			};
		}

		public static Vector2 UPvr_GetAxis2D(int hand)
		{
			switch (hand)
			{
			case 0:
				if (Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition != Vector2.zero)
				{
					Vector2 result2 = new Vector2(Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.x / 128f - 1f, Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.y / 128f - 1f);
					if (result2.x > 1f || result2.x < -1f || result2.y > 1f || result2.y < -1f)
					{
						return Vector2.zero;
					}
					return result2;
				}
				return Vector2.zero;
			case 1:
				if (Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition != Vector2.zero)
				{
					Vector2 result = new Vector2(Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.x / 128f - 1f, Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.y / 128f - 1f);
					if (result.x > 1f || result.x < -1f || result.y > 1f || result.y < -1f)
					{
						return Vector2.zero;
					}
					return result;
				}
				return Vector2.zero;
			default:
				return Vector2.zero;
			}
		}

		public static bool UPvr_GetJoystickUp(int hand)
		{
			switch (hand)
			{
			case 0:
				if (Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition != Vector2.zero)
				{
					float value2 = Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.x / 128f - 1f;
					float num2 = Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.y / 128f - 1f;
					if (num2 > 0.4f && num2 > Math.Abs(value2))
					{
						return true;
					}
				}
				return false;
			case 1:
				if (Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition != Vector2.zero)
				{
					float value = Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.x / 128f - 1f;
					float num = Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.y / 128f - 1f;
					if (num > 0.4f && num > Math.Abs(value))
					{
						return true;
					}
				}
				return false;
			default:
				return false;
			}
		}

		public static bool UPvr_GetJoystickDown(int hand)
		{
			switch (hand)
			{
			case 0:
				if (Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition != Vector2.zero)
				{
					float value2 = Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.x / 128f - 1f;
					float num2 = Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.y / 128f - 1f;
					if (0f - num2 > 0.4f && 0f - num2 > Math.Abs(value2))
					{
						return true;
					}
				}
				return false;
			case 1:
				if (Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition != Vector2.zero)
				{
					float value = Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.x / 128f - 1f;
					float num = Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.y / 128f - 1f;
					if (0f - num > 0.4f && 0f - num > Math.Abs(value))
					{
						return true;
					}
				}
				return false;
			default:
				return false;
			}
		}

		public static bool UPvr_GetJoystickLeft(int hand)
		{
			switch (hand)
			{
			case 0:
				if (Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition != Vector2.zero)
				{
					float num2 = Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.x / 128f - 1f;
					float value2 = Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.y / 128f - 1f;
					if (0f - num2 > 0.4f && 0f - num2 > Math.Abs(value2))
					{
						return true;
					}
				}
				return false;
			case 1:
				if (Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition != Vector2.zero)
				{
					float num = Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.x / 128f - 1f;
					float value = Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.y / 128f - 1f;
					if (0f - num > 0.4f && 0f - num > Math.Abs(value))
					{
						return true;
					}
				}
				return false;
			default:
				return false;
			}
		}

		public static bool UPvr_GetJoystickRight(int hand)
		{
			switch (hand)
			{
			case 0:
				if (Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition != Vector2.zero)
				{
					float num2 = Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.x / 128f - 1f;
					float value2 = Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.y / 128f - 1f;
					if (num2 > 0.4f && num2 > Math.Abs(value2))
					{
						return true;
					}
				}
				return false;
			case 1:
				if (Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition != Vector2.zero)
				{
					float num = Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.x / 128f - 1f;
					float value = Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.y / 128f - 1f;
					if (num > 0.4f && num > Math.Abs(value))
					{
						return true;
					}
				}
				return false;
			default:
				return false;
			}
		}

		public static ControllerState UPvr_GetControllerState(int hand)
		{
			return hand switch
			{
				0 => (ControllerState)Convert.ToInt16(Pvr_ControllerManager.controllerlink.controller0Connected), 
				1 => (ControllerState)Convert.ToInt16(Pvr_ControllerManager.controllerlink.controller1Connected), 
				_ => ControllerState.Error, 
			};
		}

		public static Quaternion UPvr_GetControllerQUA(int hand)
		{
			return hand switch
			{
				0 => Pvr_ControllerManager.controllerlink.Controller0.Rotation, 
				1 => Pvr_ControllerManager.controllerlink.Controller1.Rotation, 
				_ => new Quaternion(0f, 0f, 0f, 1f), 
			};
		}

		public static Vector3 UPvr_GetControllerPOS(int hand)
		{
			return hand switch
			{
				0 => Pvr_ControllerManager.controllerlink.Controller0.Position, 
				1 => Pvr_ControllerManager.controllerlink.Controller1.Position, 
				_ => new Vector3(0f, 0f, 0f), 
			};
		}

		public static Quaternion UPvr_GetControllerPredictRotation(int hand, float predictTime)
		{
			float[] controllerPredictSensorData = Pvr_ControllerManager.controllerlink.GetControllerPredictSensorData(hand, predictTime);
			return new Quaternion(controllerPredictSensorData[0], controllerPredictSensorData[1], controllerPredictSensorData[2], controllerPredictSensorData[3]);
		}

		public static Vector3 UPvr_GetControllerPredictPosition(int hand, float predictTime)
		{
			float[] controllerPredictSensorData = Pvr_ControllerManager.controllerlink.GetControllerPredictSensorData(hand, predictTime);
			return new Vector3(controllerPredictSensorData[4] / 1000f, controllerPredictSensorData[5] / 1000f, (0f - controllerPredictSensorData[6]) / 1000f);
		}

		public static int UPvr_GetControllerTriggerValue(int hand)
		{
			return hand switch
			{
				0 => Pvr_ControllerManager.controllerlink.Controller0.TriggerNum, 
				1 => Pvr_ControllerManager.controllerlink.Controller1.TriggerNum, 
				_ => 0, 
			};
		}

		public static int UPvr_GetControllerPower(int hand)
		{
			return hand switch
			{
				0 => Pvr_ControllerManager.controllerlink.Controller0.Battery, 
				1 => Pvr_ControllerManager.controllerlink.Controller1.Battery, 
				_ => 0, 
			};
		}

		public static int UPvr_GetControllerPowerByPercent(int hand)
		{
			return hand switch
			{
				0 => Pvr_ControllerManager.controllerlink.Controller0.Battery * 20, 
				1 => Pvr_ControllerManager.controllerlink.Controller1.Battery * 20, 
				_ => 0, 
			};
		}

		public static SwipeDirection UPvr_GetSwipeDirection(int hand)
		{
			return hand switch
			{
				0 => Pvr_ControllerManager.controllerlink.Controller0.SwipeDirection, 
				1 => Pvr_ControllerManager.controllerlink.Controller1.SwipeDirection, 
				_ => SwipeDirection.No, 
			};
		}

		public static TouchPadClick UPvr_GetTouchPadClick(int hand)
		{
			return hand switch
			{
				0 => Pvr_ControllerManager.controllerlink.Controller0.TouchPadClick, 
				1 => Pvr_ControllerManager.controllerlink.Controller1.TouchPadClick, 
				_ => TouchPadClick.No, 
			};
		}

		public static bool UPvr_GetKey(int hand, Pvr_KeyCode key)
		{
			bool flag = false;
			if (hand == 0)
			{
				if ((Pvr_KeyCode.APP & key) == Pvr_KeyCode.APP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.App.State;
				}
				if ((Pvr_KeyCode.HOME & key) == Pvr_KeyCode.HOME)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Home.State;
				}
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Touch.State;
				}
				if ((Pvr_KeyCode.VOLUMEUP & key) == Pvr_KeyCode.VOLUMEUP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.VolumeUp.State;
				}
				if ((Pvr_KeyCode.VOLUMEDOWN & key) == Pvr_KeyCode.VOLUMEDOWN)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.VolumeDown.State;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Trigger.State;
				}
				if ((Pvr_KeyCode.X & key) == Pvr_KeyCode.X)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.X.State;
				}
				if ((Pvr_KeyCode.Y & key) == Pvr_KeyCode.Y)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Y.State;
				}
				if ((Pvr_KeyCode.Left & key) == Pvr_KeyCode.Left)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Left.State;
				}
			}
			if (hand == 1)
			{
				if ((Pvr_KeyCode.APP & key) == Pvr_KeyCode.APP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.App.State;
				}
				if ((Pvr_KeyCode.HOME & key) == Pvr_KeyCode.HOME)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Home.State;
				}
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Touch.State;
				}
				if ((Pvr_KeyCode.VOLUMEUP & key) == Pvr_KeyCode.VOLUMEUP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.VolumeUp.State;
				}
				if ((Pvr_KeyCode.VOLUMEDOWN & key) == Pvr_KeyCode.VOLUMEDOWN)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.VolumeDown.State;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Trigger.State;
				}
				if ((Pvr_KeyCode.A & key) == Pvr_KeyCode.A)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.A.State;
				}
				if ((Pvr_KeyCode.B & key) == Pvr_KeyCode.B)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.B.State;
				}
				if ((Pvr_KeyCode.Right & key) == Pvr_KeyCode.Right)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Right.State;
				}
			}
			return flag;
		}

		public static bool UPvr_GetKeyDown(int hand, Pvr_KeyCode key)
		{
			bool flag = false;
			if (hand == 0)
			{
				if ((Pvr_KeyCode.APP & key) == Pvr_KeyCode.APP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.App.PressedDown;
				}
				if ((Pvr_KeyCode.HOME & key) == Pvr_KeyCode.HOME)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Home.PressedDown;
				}
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Touch.PressedDown;
				}
				if ((Pvr_KeyCode.VOLUMEUP & key) == Pvr_KeyCode.VOLUMEUP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.VolumeUp.PressedDown;
				}
				if ((Pvr_KeyCode.VOLUMEDOWN & key) == Pvr_KeyCode.VOLUMEDOWN)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.VolumeDown.PressedDown;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Trigger.PressedDown;
				}
				if ((Pvr_KeyCode.X & key) == Pvr_KeyCode.X)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.X.PressedDown;
				}
				if ((Pvr_KeyCode.Y & key) == Pvr_KeyCode.Y)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Y.PressedDown;
				}
				if ((Pvr_KeyCode.Left & key) == Pvr_KeyCode.Left)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Left.PressedDown;
				}
			}
			if (hand == 1)
			{
				if ((Pvr_KeyCode.APP & key) == Pvr_KeyCode.APP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.App.PressedDown;
				}
				if ((Pvr_KeyCode.HOME & key) == Pvr_KeyCode.HOME)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Home.PressedDown;
				}
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Touch.PressedDown;
				}
				if ((Pvr_KeyCode.VOLUMEUP & key) == Pvr_KeyCode.VOLUMEUP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.VolumeUp.PressedDown;
				}
				if ((Pvr_KeyCode.VOLUMEDOWN & key) == Pvr_KeyCode.VOLUMEDOWN)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.VolumeDown.PressedDown;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Trigger.PressedDown;
				}
				if ((Pvr_KeyCode.A & key) == Pvr_KeyCode.A)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.A.PressedDown;
				}
				if ((Pvr_KeyCode.B & key) == Pvr_KeyCode.B)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.B.PressedDown;
				}
				if ((Pvr_KeyCode.Right & key) == Pvr_KeyCode.Right)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Right.PressedDown;
				}
			}
			return flag;
		}

		public static bool UPvr_GetKeyUp(int hand, Pvr_KeyCode key)
		{
			bool flag = false;
			if (hand == 0)
			{
				if ((Pvr_KeyCode.APP & key) == Pvr_KeyCode.APP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.App.PressedUp;
				}
				if ((Pvr_KeyCode.HOME & key) == Pvr_KeyCode.HOME)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Home.PressedUp;
				}
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Touch.PressedUp;
				}
				if ((Pvr_KeyCode.VOLUMEUP & key) == Pvr_KeyCode.VOLUMEUP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.VolumeUp.PressedUp;
				}
				if ((Pvr_KeyCode.VOLUMEDOWN & key) == Pvr_KeyCode.VOLUMEDOWN)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.VolumeDown.PressedUp;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Trigger.PressedUp;
				}
				if ((Pvr_KeyCode.X & key) == Pvr_KeyCode.X)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.X.PressedUp;
				}
				if ((Pvr_KeyCode.Y & key) == Pvr_KeyCode.Y)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Y.PressedUp;
				}
				if ((Pvr_KeyCode.Left & key) == Pvr_KeyCode.Left)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Left.PressedUp;
				}
			}
			if (hand == 1)
			{
				if ((Pvr_KeyCode.APP & key) == Pvr_KeyCode.APP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.App.PressedUp;
				}
				if ((Pvr_KeyCode.HOME & key) == Pvr_KeyCode.HOME)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Home.PressedUp;
				}
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Touch.PressedUp;
				}
				if ((Pvr_KeyCode.VOLUMEUP & key) == Pvr_KeyCode.VOLUMEUP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.VolumeUp.PressedUp;
				}
				if ((Pvr_KeyCode.VOLUMEDOWN & key) == Pvr_KeyCode.VOLUMEDOWN)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.VolumeDown.PressedUp;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Trigger.PressedUp;
				}
				if ((Pvr_KeyCode.A & key) == Pvr_KeyCode.A)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.A.PressedUp;
				}
				if ((Pvr_KeyCode.B & key) == Pvr_KeyCode.B)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.B.PressedUp;
				}
				if ((Pvr_KeyCode.Right & key) == Pvr_KeyCode.Right)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Right.PressedUp;
				}
			}
			return flag;
		}

		public static bool UPvr_GetTouch(int hand, Pvr_KeyCode key)
		{
			bool flag = false;
			if (hand == 0)
			{
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Touch.Touch;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Trigger.Touch;
				}
				if ((Pvr_KeyCode.X & key) == Pvr_KeyCode.X)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.X.Touch;
				}
				if ((Pvr_KeyCode.Y & key) == Pvr_KeyCode.Y)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Y.Touch;
				}
				if ((Pvr_KeyCode.Thumbrest & key) == Pvr_KeyCode.Thumbrest)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Thumbrest.Touch;
				}
			}
			if (hand == 1)
			{
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Touch.Touch;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Trigger.Touch;
				}
				if ((Pvr_KeyCode.A & key) == Pvr_KeyCode.A)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.A.Touch;
				}
				if ((Pvr_KeyCode.B & key) == Pvr_KeyCode.B)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.B.Touch;
				}
				if ((Pvr_KeyCode.Thumbrest & key) == Pvr_KeyCode.Thumbrest)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Thumbrest.Touch;
				}
			}
			return flag;
		}

		public static bool UPvr_GetTouchDown(int hand, Pvr_KeyCode key)
		{
			bool flag = false;
			if (hand == 0)
			{
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Touch.TouchDown;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Trigger.TouchDown;
				}
				if ((Pvr_KeyCode.X & key) == Pvr_KeyCode.X)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.X.TouchDown;
				}
				if ((Pvr_KeyCode.Y & key) == Pvr_KeyCode.Y)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Y.TouchDown;
				}
				if ((Pvr_KeyCode.Thumbrest & key) == Pvr_KeyCode.Thumbrest)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Thumbrest.TouchDown;
				}
			}
			if (hand == 1)
			{
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Touch.TouchDown;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Trigger.TouchDown;
				}
				if ((Pvr_KeyCode.A & key) == Pvr_KeyCode.A)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.A.TouchDown;
				}
				if ((Pvr_KeyCode.B & key) == Pvr_KeyCode.B)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.B.TouchDown;
				}
				if ((Pvr_KeyCode.Thumbrest & key) == Pvr_KeyCode.Thumbrest)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Thumbrest.TouchDown;
				}
			}
			return flag;
		}

		public static bool UPvr_GetTouchUp(int hand, Pvr_KeyCode key)
		{
			bool flag = false;
			if (hand == 0)
			{
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Touch.TouchUp;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Trigger.TouchUp;
				}
				if ((Pvr_KeyCode.X & key) == Pvr_KeyCode.X)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.X.TouchUp;
				}
				if ((Pvr_KeyCode.Y & key) == Pvr_KeyCode.Y)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Y.TouchUp;
				}
				if ((Pvr_KeyCode.Thumbrest & key) == Pvr_KeyCode.Thumbrest)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Thumbrest.TouchUp;
				}
			}
			if (hand == 1)
			{
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Touch.TouchUp;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Trigger.TouchUp;
				}
				if ((Pvr_KeyCode.A & key) == Pvr_KeyCode.A)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.A.TouchUp;
				}
				if ((Pvr_KeyCode.B & key) == Pvr_KeyCode.B)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.B.TouchUp;
				}
				if ((Pvr_KeyCode.Thumbrest & key) == Pvr_KeyCode.Thumbrest)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Thumbrest.TouchUp;
				}
			}
			return flag;
		}

		public static bool UPvr_GetKeyClick(int hand, Pvr_KeyCode key)
		{
			bool flag = false;
			if (hand == 0)
			{
				if ((Pvr_KeyCode.APP & key) == Pvr_KeyCode.APP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.App.Click;
				}
				if ((Pvr_KeyCode.HOME & key) == Pvr_KeyCode.HOME)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Home.Click;
				}
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Touch.Click;
				}
				if ((Pvr_KeyCode.VOLUMEUP & key) == Pvr_KeyCode.VOLUMEUP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.VolumeUp.Click;
				}
				if ((Pvr_KeyCode.VOLUMEDOWN & key) == Pvr_KeyCode.VOLUMEDOWN)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.VolumeDown.Click;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Trigger.Click;
				}
				if ((Pvr_KeyCode.X & key) == Pvr_KeyCode.X)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.X.Click;
				}
				if ((Pvr_KeyCode.Y & key) == Pvr_KeyCode.Y)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Y.Click;
				}
				if ((Pvr_KeyCode.Left & key) == Pvr_KeyCode.Left)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Left.Click;
				}
			}
			if (hand == 1)
			{
				if ((Pvr_KeyCode.APP & key) == Pvr_KeyCode.APP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.App.Click;
				}
				if ((Pvr_KeyCode.HOME & key) == Pvr_KeyCode.HOME)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Home.Click;
				}
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Touch.Click;
				}
				if ((Pvr_KeyCode.VOLUMEUP & key) == Pvr_KeyCode.VOLUMEUP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.VolumeUp.Click;
				}
				if ((Pvr_KeyCode.VOLUMEDOWN & key) == Pvr_KeyCode.VOLUMEDOWN)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.VolumeDown.Click;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Trigger.Click;
				}
				if ((Pvr_KeyCode.A & key) == Pvr_KeyCode.A)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.A.Click;
				}
				if ((Pvr_KeyCode.B & key) == Pvr_KeyCode.B)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.B.Click;
				}
				if ((Pvr_KeyCode.Right & key) == Pvr_KeyCode.Right)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Right.Click;
				}
			}
			return flag;
		}

		public static bool UPvr_GetKeyLongPressed(int hand, Pvr_KeyCode key)
		{
			bool flag = false;
			if (hand == 0)
			{
				if ((Pvr_KeyCode.APP & key) == Pvr_KeyCode.APP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.App.LongPressed;
				}
				if ((Pvr_KeyCode.HOME & key) == Pvr_KeyCode.HOME)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Home.LongPressed;
				}
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Touch.LongPressed;
				}
				if ((Pvr_KeyCode.VOLUMEUP & key) == Pvr_KeyCode.VOLUMEUP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.VolumeUp.LongPressed;
				}
				if ((Pvr_KeyCode.VOLUMEDOWN & key) == Pvr_KeyCode.VOLUMEDOWN)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.VolumeDown.LongPressed;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Trigger.LongPressed;
				}
				if ((Pvr_KeyCode.X & key) == Pvr_KeyCode.X)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.X.LongPressed;
				}
				if ((Pvr_KeyCode.Y & key) == Pvr_KeyCode.Y)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Y.LongPressed;
				}
				if ((Pvr_KeyCode.Left & key) == Pvr_KeyCode.Left)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller0.Left.LongPressed;
				}
			}
			if (hand == 1)
			{
				if ((Pvr_KeyCode.APP & key) == Pvr_KeyCode.APP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.App.LongPressed;
				}
				if ((Pvr_KeyCode.HOME & key) == Pvr_KeyCode.HOME)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Home.LongPressed;
				}
				if ((Pvr_KeyCode.TOUCHPAD & key) == Pvr_KeyCode.TOUCHPAD)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Touch.LongPressed;
				}
				if ((Pvr_KeyCode.VOLUMEUP & key) == Pvr_KeyCode.VOLUMEUP)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.VolumeUp.LongPressed;
				}
				if ((Pvr_KeyCode.VOLUMEDOWN & key) == Pvr_KeyCode.VOLUMEDOWN)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.VolumeDown.LongPressed;
				}
				if ((Pvr_KeyCode.TRIGGER & key) == Pvr_KeyCode.TRIGGER)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Trigger.LongPressed;
				}
				if ((Pvr_KeyCode.A & key) == Pvr_KeyCode.A)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.A.LongPressed;
				}
				if ((Pvr_KeyCode.B & key) == Pvr_KeyCode.B)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.B.LongPressed;
				}
				if ((Pvr_KeyCode.Right & key) == Pvr_KeyCode.Right)
				{
					flag |= Pvr_ControllerManager.controllerlink.Controller1.Right.LongPressed;
				}
			}
			return flag;
		}

		public static bool UPvr_IsTouching(int hand)
		{
			switch (hand)
			{
			case 0:
				if (!(Math.Abs(Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.x) > 0f))
				{
					return Math.Abs(Pvr_ControllerManager.controllerlink.Controller0.TouchPadPosition.y) > 0f;
				}
				return true;
			case 1:
				if (!(Math.Abs(Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.x) > 0f))
				{
					return Math.Abs(Pvr_ControllerManager.controllerlink.Controller1.TouchPadPosition.y) > 0f;
				}
				return true;
			default:
				return false;
			}
		}

		public static void UPvr_SetHandNess(Pvr_Controller.UserHandNess hand)
		{
			if (Pvr_ControllerManager.controllerlink.getHandness() != (int)hand)
			{
				Pvr_ControllerManager.controllerlink.setHandness((int)hand);
			}
		}

		public static Pvr_Controller.UserHandNess UPvr_GetHandNess()
		{
			return Pvr_ControllerManager.controllerlink.handness;
		}

		public static int UPvr_GetPreferenceDevice()
		{
			int trackingmode = Pvr_ControllerManager.controllerlink.trackingmode;
			int systemProp = Pvr_ControllerManager.controllerlink.systemProp;
			if (trackingmode == 0 || trackingmode == 1 || ((trackingmode == 3 || trackingmode == 5 || trackingmode == 6) && (systemProp == 1 || systemProp == 3)))
			{
				return 1;
			}
			return 2;
		}

		public static bool UPvr_IsEnbleTrigger()
		{
			return Pvr_ControllerManager.controllerlink.IsEnbleTrigger();
		}

		public static int UPvr_GetDeviceType()
		{
			return Pvr_ControllerManager.controllerlink.controllerType;
		}

		public static int UPvr_GetMainHandNess()
		{
			return Pvr_ControllerManager.controllerlink.mainHandID;
		}

		public static void UPvr_SetMainHandNess(int hand)
		{
			Pvr_ControllerManager.controllerlink.SetMainController(hand);
		}

		public static int UPvr_GetControllerAbility(int hand)
		{
			return Pvr_ControllerManager.controllerlink.GetControllerAbility(hand);
		}

		public static void UPvr_VibrateNeo2Controller(float strength, int time, int hand)
		{
			Pvr_ControllerManager.controllerlink.VibrateNeo2Controller(strength, time, hand);
		}

		public static void UPvr_VibrateController(float strength, int time, int hand)
		{
			Pvr_ControllerManager.controllerlink.VibrateController(strength, time, hand);
		}

		public static int UPvr_GetControllerBindingState(int hand)
		{
			return Pvr_ControllerManager.controllerlink.GetControllerBindingState(hand);
		}

		public static Vector3 UPvr_GetVelocity(int hand)
		{
			return Pvr_ControllerManager.controllerlink.GetVelocity(hand);
		}

		public static Vector3 UPvr_GetAngularVelocity(int hand)
		{
			return Pvr_ControllerManager.controllerlink.GetAngularVelocity(hand);
		}

		public static Vector3 UPvr_GetAcceleration(int hand)
		{
			return Pvr_ControllerManager.controllerlink.GetAcceleration(hand);
		}

		public static Vector3 UPvr_GetAngularAcceleration(int hand)
		{
			return Pvr_ControllerManager.controllerlink.GetAngularAcceleration(hand);
		}

		public static void UPvr_ScanController()
		{
			Pvr_ControllerManager.controllerlink.StartScan();
		}

		public static void UPvr_StopScanController()
		{
			Pvr_ControllerManager.controllerlink.StopScan();
		}

		public static void UPvr_ConnectController(string mac)
		{
			if (mac != "")
			{
				Pvr_ControllerManager.controllerlink.hummingBirdMac = mac;
			}
			Pvr_ControllerManager.controllerlink.ConnectBLE();
		}

		public static void UPvr_DisConnectController()
		{
			Pvr_ControllerManager.controllerlink.DisConnectBLE();
		}

		public static void UPvr_ResetController(int hand)
		{
			Pvr_ControllerManager.controllerlink.ResetController(hand);
		}

		public static string UPvr_GetControllerVersion()
		{
			return Pvr_ControllerManager.controllerlink.GetControllerVersion();
		}

		public static void UPvr_GetDeviceVersion(int deviceType)
		{
			Pvr_ControllerManager.controllerlink.GetDeviceVersion(deviceType);
		}

		public static void UPvr_GetControllerSnCode(int controllerSerialNum)
		{
			Pvr_ControllerManager.controllerlink.GetControllerSnCode(controllerSerialNum);
		}

		public static void UPvr_SetControllerUnbind(int controllerSerialNum)
		{
			Pvr_ControllerManager.controllerlink.SetControllerUnbind(controllerSerialNum);
		}

		public static void UPvr_SetStationRestart()
		{
			Pvr_ControllerManager.controllerlink.SetStationRestart();
		}

		public static void UPvr_StartStationOtaUpdate()
		{
			Pvr_ControllerManager.controllerlink.StartStationOtaUpdate();
		}

		public static void UPvr_StartControllerOtaUpdate(int mode, int controllerSerialNum)
		{
			Pvr_ControllerManager.controllerlink.StartControllerOtaUpdate(mode, controllerSerialNum);
		}

		public static void UPvr_EnterPairMode(int controllerSerialNum)
		{
			Pvr_ControllerManager.controllerlink.EnterPairMode(controllerSerialNum);
		}

		public static void UPvr_SetControllerShutdown(int controllerSerialNum)
		{
			Pvr_ControllerManager.controllerlink.SetControllerShutdown(controllerSerialNum);
		}

		public static int UPvr_GetStationPairState()
		{
			return Pvr_ControllerManager.controllerlink.GetStationPairState();
		}

		public static int UPvr_GetStationOtaUpdateProgress()
		{
			return Pvr_ControllerManager.controllerlink.GetStationOtaUpdateProgress();
		}

		public static int UPvr_GetControllerOtaUpdateProgress()
		{
			return Pvr_ControllerManager.controllerlink.GetControllerOtaUpdateProgress();
		}

		public static void UPvr_GetControllerVersionAndSN(int controllerSerialNum)
		{
			Pvr_ControllerManager.controllerlink.GetControllerVersionAndSN(controllerSerialNum);
		}

		public static void UPvr_GetControllerUniqueID()
		{
			Pvr_ControllerManager.controllerlink.GetControllerUniqueID();
		}

		public void UPvr_InterruptStationPairMode()
		{
			Pvr_ControllerManager.controllerlink.InterruptStationPairMode();
		}

		public void UPvr_StartCV2PairingMode(int deviceType)
		{
			Pvr_ControllerManager.controllerlink.StartCV2PairingMode(deviceType);
		}

		public void UPvr_StopCV2PairingMode(int deviceType)
		{
			Pvr_ControllerManager.controllerlink.StopCV2PairingMode(deviceType);
		}

		public static void UPvr_SetArmModelParameters(int hand, int gazeType, float elbowHeight, float elbowDepth, float pointerTiltAngle)
		{
			Pvr_SetArmModelParameters(hand, gazeType, elbowHeight, elbowDepth, pointerTiltAngle);
		}

		public static void UPvr_CalcArmModelParameters(float[] headOrientation, float[] controllerOrientation, float[] controllerPrimary)
		{
			Pvr_CalcArmModelParameters(headOrientation, controllerOrientation, controllerPrimary);
		}

		public static void UPvr_GetPointerPose(float[] rotation, float[] position)
		{
			Pvr_GetPointerPose(rotation, position);
		}

		public static void UPvr_GetElbowPose(float[] rotation, float[] position)
		{
			Pvr_GetElbowPose(rotation, position);
		}

		public static void UPvr_GetWristPose(float[] rotation, float[] position)
		{
			Pvr_GetWristPose(rotation, position);
		}

		public static void UPvr_GetShoulderPose(float[] rotation, float[] position)
		{
			Pvr_GetShoulderPose(rotation, position);
		}

		public static void UPvr_IsEnbleHomeKey(bool state)
		{
			Pvr_ControllerManager.controllerlink.setIsEnbleHomeKey(state);
		}

		public static void UPvr_SwitchHomeKey(bool state)
		{
			Pvr_ControllerManager.controllerlink.SwitchHomeKey(state);
		}

		public static int UPvr_GetControllerSensorStatus(int id)
		{
			return Pvr_ControllerManager.controllerlink.getControllerSensorStatus(id);
		}

		public static void UPvr_SetControllerOriginOffset(int hand, Vector3 offset)
		{
			switch (hand)
			{
			case 0:
				Pvr_Controller.originOffsetL = offset;
				break;
			case 1:
				Pvr_Controller.originOffsetR = offset;
				break;
			}
		}

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_CalcArmModelParameters(float[] headOrientation, float[] controllerOrientation, float[] gyro);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_GetPointerPose(float[] rotation, float[] position);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_GetElbowPose(float[] rotation, float[] position);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_GetWristPose(float[] rotation, float[] position);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_GetShoulderPose(float[] rotation, float[] position);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetArmModelParameters(int hand, int gazeType, float elbowHeight, float elbowDepth, float pointerTiltAngle);
	}
	public enum ControllerVariety
	{
		Controller0,
		Controller1
	}
	public enum ControllerDevice
	{
		Goblin,
		Neo,
		G2,
		Neo2,
		Neo3,
		NewController
	}
	public enum PBS_SystemInfoEnum
	{
		ELECTRIC_QUANTITY,
		PUI_VERSION,
		EQUIPMENT_MODEL,
		EQUIPMENT_SN,
		CUSTOMER_SN,
		INTERNAL_STORAGE_SPACE_OF_THE_DEVICE,
		DEVICE_BLUETOOTH_STATUS,
		BLUETOOTH_NAME_CONNECTED,
		BLUETOOTH_MAC_ADDRESS,
		DEVICE_WIFI_STATUS,
		WIFI_NAME_CONNECTED,
		WLAN_MAC_ADDRESS,
		DEVICE_IP
	}
	public enum PBS_DeviceControlEnum
	{
		DEVICE_CONTROL_REBOOT,
		DEVICE_CONTROL_SHUTDOWN
	}
	public enum PBS_PackageControlEnum
	{
		PACKAGE_SILENCE_INSTALL,
		PACKAGE_SILENCE_UNINSTALL
	}
	public enum PBS_SwitchEnum
	{
		S_ON,
		S_OFF
	}
	public enum PBS_HomeEventEnum
	{
		SINGLE_CLICK,
		DOUBLE_CLICK,
		LONG_PRESS
	}
	public enum PBS_HomeFunctionEnum
	{
		VALUE_HOME_GO_TO_SETTING,
		VALUE_HOME_BACK,
		VALUE_HOME_RECENTER,
		VALUE_HOME_OPEN_APP,
		VALUE_HOME_DISABLE,
		VALUE_HOME_GO_TO_HOME,
		VALUE_HOME_SEND_BROADCAST,
		VALUE_HOME_CLEAN_MEMORY
	}
	public enum PBS_ScreenOffDelayTimeEnum
	{
		THREE = 3,
		TEN = 10,
		THIRTY = 30,
		SIXTY = 60,
		THREE_HUNDRED = 300,
		SIX_HUNDRED = 600,
		NEVER = -1
	}
	public enum PBS_SleepDelayTimeEnum
	{
		FIFTEEN = 15,
		THIRTY = 30,
		SIXTY = 60,
		THREE_HUNDRED = 300,
		SIX_HUNDRED = 600,
		ONE_THOUSAND_AND_EIGHT_HUNDRED = 1800,
		NEVER = -1
	}
	public enum PBS_SystemFunctionSwitchEnum
	{
		SFS_USB,
		SFS_AUTOSLEEP,
		SFS_SCREENON_CHARGING,
		SFS_OTG_CHARGING,
		SFS_RETURN_MENU_IN_2DMODE,
		SFS_COMBINATION_KEY,
		SFS_CALIBRATION_WITH_POWER_ON,
		SFS_SYSTEM_UPDATE,
		SFS_CAST_SERVICE,
		SFS_EYE_PROTECTION,
		SFS_SECURITY_ZONE_PERMANENTLY,
		SFS_GLOBAL_CALIBRATION,
		SFS_Auto_Calibration,
		SFS_USB_BOOT,
		SFS_VOLUME_UI,
		SFS_CONTROLLER_UI,
		SFS_NAVGATION_SWITCH
	}
	public enum PBS_USBConfigModeEnum
	{
		MTP,
		CHARGE
	}
	public struct ToBService
	{
		public static Action<bool> BoolCallback;

		public static Action<int> IntCallback;

		public static Action<long> LongCallback;

		public static Action<string> StringCallback;

		private static AndroidJavaClass unityPlayer;

		private static AndroidJavaObject currentActivity;

		private static AndroidJavaObject tobHelper;

		private static AndroidJavaClass tobHelperClass;

		public static void UPvr_InitToBService()
		{
			tobHelperClass = new AndroidJavaClass("com.pvr.tobservice.ToBServiceHelper");
			tobHelper = tobHelperClass.CallStatic<AndroidJavaObject>("getInstance", Array.Empty<object>());
			unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
		}

		public static void UPvr_SetUnityObjectName(string obj)
		{
			System.UPvr_CallMethod(tobHelper, "setUnityObjectName", obj);
		}

		public static void UPvr_BindToBService()
		{
			System.UPvr_CallMethod(tobHelper, "bindTobService", currentActivity);
		}

		public static void UPvr_UnBindToBService()
		{
			System.UPvr_CallMethod(tobHelper, "unBindTobService", currentActivity);
		}

		private static AndroidJavaObject GetEnumType(Enum enumType)
		{
			return new AndroidJavaClass("com.pvr.tobservice.enums" + enumType.GetType().ToString().Replace("Pvr_UnitySDKAPI", "")).GetStatic<AndroidJavaObject>(enumType.ToString());
		}

		public static string UPvr_StateGetDeviceInfo(PBS_SystemInfoEnum type)
		{
			string result = "";
			System.UPvr_CallMethod(ref result, tobHelper, "pbsStateGetDeviceInfo", GetEnumType(type), 0);
			return result;
		}

		public static void UPvr_ControlSetDeviceAction(PBS_DeviceControlEnum deviceControl, Action<int> callback)
		{
			if (callback != null)
			{
				IntCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsControlSetDeviceAction", GetEnumType(deviceControl), null);
		}

		public static void UPvr_ControlAPPManger(PBS_PackageControlEnum packageControl, string path, Action<int> callback)
		{
			if (callback != null)
			{
				IntCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsControlAPPManger", GetEnumType(packageControl), path, 0, null);
		}

		public static void UPvr_ControlSetAutoConnectWIFI(string ssid, string pwd, Action<bool> callback)
		{
			if (callback != null)
			{
				BoolCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsControlSetAutoConnectWIFI", ssid, pwd, 0, null);
		}

		public static void UPvr_ControlClearAutoConnectWIFI(Action<bool> callback)
		{
			if (callback != null)
			{
				BoolCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsControlClearAutoConnectWIFI", null);
		}

		public static void UPvr_PropertySetHomeKey(PBS_HomeEventEnum eventEnum, PBS_HomeFunctionEnum function, Action<bool> callback)
		{
			if (callback != null)
			{
				BoolCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsPropertySetHomeKey", GetEnumType(eventEnum), GetEnumType(function), null);
		}

		public static void UPvr_PropertySetHomeKeyAll(PBS_HomeEventEnum eventEnum, PBS_HomeFunctionEnum function, int timesetup, string pkg, string className, Action<bool> callback)
		{
			if (callback != null)
			{
				BoolCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsPropertySetHomeKeyAll", GetEnumType(eventEnum), GetEnumType(function), timesetup, pkg, className, null);
		}

		public static void UPvr_PropertyDisablePowerKey(bool isSingleTap, bool enable, Action<int> callback)
		{
			if (callback != null)
			{
				IntCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsPropertyDisablePowerKey", isSingleTap, enable, null);
		}

		public static void UPvr_PropertySetScreenOffDelay(PBS_ScreenOffDelayTimeEnum timeEnum, Action<int> callback)
		{
			if (callback != null)
			{
				IntCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsPropertySetScreenOffDelay", GetEnumType(timeEnum), null);
		}

		public static void UPvr_PropertySetSleepDelay(PBS_SleepDelayTimeEnum timeEnum)
		{
			System.UPvr_CallMethod(tobHelper, "pbsPropertySetSleepDelay", GetEnumType(timeEnum));
		}

		public static void UPvr_SwitchSystemFunction(PBS_SystemFunctionSwitchEnum systemFunction, PBS_SwitchEnum switchEnum)
		{
			System.UPvr_CallMethod(tobHelper, "pbsSwitchSystemFunction", GetEnumType(systemFunction), GetEnumType(switchEnum), 0);
		}

		public static void UPvr_SwitchSetUsbConfigurationOption(PBS_USBConfigModeEnum uSBConfigModeEnum)
		{
			System.UPvr_CallMethod(tobHelper, "pbsSwitchSetUsbConfigurationOption", GetEnumType(uSBConfigModeEnum), 0);
		}

		public static void UPvr_ScreenOn()
		{
			System.UPvr_CallMethod(tobHelper, "pbsScreenOn");
		}

		public static void UPvr_ScreenOff()
		{
			System.UPvr_CallMethod(tobHelper, "pbsScreenOff");
		}

		public static void UPvr_AcquireWakeLock()
		{
			System.UPvr_CallMethod(tobHelper, "pbsAcquireWakeLock");
		}

		public static void UPvr_ReleaseWakeLock()
		{
			System.UPvr_CallMethod(tobHelper, "pbsReleaseWakeLock");
		}

		public static void UPvr_EnableEnterKey()
		{
			System.UPvr_CallMethod(tobHelper, "pbsEnableEnterKey");
		}

		public static void UPvr_DisableEnterKey()
		{
			System.UPvr_CallMethod(tobHelper, "pbsDisableEnterKey");
		}

		public static void UPvr_EnableVolumeKey()
		{
			System.UPvr_CallMethod(tobHelper, "pbsEnableVolumeKey");
		}

		public static void UPvr_DisableVolumeKey()
		{
			System.UPvr_CallMethod(tobHelper, "pbsDisableVolumeKey");
		}

		public static void UPvr_EnableBackKey()
		{
			System.UPvr_CallMethod(tobHelper, "pbsEnableBackKey");
		}

		public static void UPvr_DisableBackKey()
		{
			System.UPvr_CallMethod(tobHelper, "pbsDisableBackKey");
		}

		public static void UPvr_WriteConfigFileToDataLocal(string path, string content, Action<bool> callback)
		{
			if (callback != null)
			{
				BoolCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsWriteConfigFileToDataLocal", path, content, null);
		}

		public static void UPvr_ResetAllKeyToDefault(Action<bool> callback)
		{
			if (callback != null)
			{
				BoolCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsResetAllKeyToDefault", null);
		}

		public static void UPvr_SetAPPAsHome(PBS_SwitchEnum switchEnum, string packageName)
		{
			System.UPvr_CallMethod(tobHelper, "pbsAppSetAPPAsHomeTwo", GetEnumType(switchEnum), packageName);
		}

		public static void UPvr_KillAppsByPidOrPackageName(int[] pids, string[] packageNames)
		{
			System.UPvr_CallMethod(tobHelper, "pbsKillAppsByPidOrPackageName", pids, packageNames, 0);
		}

		public static void UPvr_FreezeScreen(bool freeze)
		{
			System.UPvr_CallMethod(tobHelper, "pbsFreezeScreen", freeze);
		}

		public static void UPvr_OpenMiracast()
		{
			System.UPvr_CallMethod(tobHelper, "pbsOpenMiracast");
		}

		public static bool UPvr_IsMiracastOn()
		{
			bool result = false;
			System.UPvr_CallMethod(ref result, tobHelper, "pbsIsMiracastOn");
			return result;
		}

		public static void UPvr_CloseMiracast()
		{
			System.UPvr_CallMethod(tobHelper, "pbsCloseMiracast");
		}

		public static void UPvr_StartScan()
		{
			System.UPvr_CallMethod(tobHelper, "pbsStartScan");
		}

		public static void UPvr_StopScan()
		{
			System.UPvr_CallMethod(tobHelper, "pbsStopScan");
		}

		public static void UPvr_ConnectWifiDisplay(string modelJson)
		{
			System.UPvr_CallMethod(tobHelper, "pbsUnityConnectWifiDisplay", modelJson);
		}

		public static void UPvr_DisConnectWifiDisplay()
		{
			System.UPvr_CallMethod(tobHelper, "pbsDisConnectWifiDisplay");
		}

		public static void UPvr_ForgetWifiDisplay(string address)
		{
			System.UPvr_CallMethod(tobHelper, "pbsForgetWifiDisplay", address);
		}

		public static void UPvr_RenameWifiDisplay(string address, string newName)
		{
			System.UPvr_CallMethod(tobHelper, "pbsRenameWifiDisplay", address, newName);
		}

		public static void UPvr_SetWDModelsCallback()
		{
			System.UPvr_CallMethod(tobHelper, "pbsSetWDModelsCallback", null);
		}

		public static void UPvr_SetWDJsonCallback()
		{
			System.UPvr_CallMethod(tobHelper, "pbsSetWDJsonCallback", null);
		}

		public static void UPvr_UpdateWifiDisplays(Action<string> callback)
		{
			if (callback != null)
			{
				StringCallback = callback;
			}
			System.UPvr_CallMethod(tobHelper, "pbsUpdateWifiDisplays");
		}

		public static string UPvr_GetConnectedWD()
		{
			string result = "";
			System.UPvr_CallMethod(ref result, tobHelper, "pbsUnityGetConnectedWD");
			return result;
		}
	}
	public enum GlobalIntConfigs
	{
		EYE_TEXTURE_RESOLUTION0,
		EYE_TEXTURE_RESOLUTION1,
		SEENSOR_COUNT,
		ABILITY6DOF,
		PLATFORM_TYPE,
		TRACKING_MODE,
		LOG_LEVEL,
		ENBLE_HAND6DOF_BY_HEAD,
		ENBLE_6DOF_GLOBAL_TRACKING,
		TARGET_FRAME_RATE,
		iShowFPS,
		SensorMode,
		LOGICFLOW,
		EYE_TEXTURE_RES_HIGH,
		EYE_TEXTURE_RES_NORMAL,
		iCtrlModelLoadingPri,
		iPhoneHMDModeEnabled,
		isEnableBoundary,
		Enable_Activity_Rotation,
		GetDisplay_Orientation,
		GetWaitFrameNum,
		GetResetFrameNum,
		EnableFFRBYSYS,
		RotControllerMode
	}
	public enum GlobalFloatConfigs
	{
		IPD,
		VFOV,
		HFOV,
		NECK_MODEL_X,
		NECK_MODEL_Y,
		NECK_MODEL_Z,
		DISPLAY_REFRESH_RATE
	}
	public enum RenderTextureAntiAliasing
	{
		X_1 = 1,
		X_2 = 2,
		X_4 = 4,
		X_8 = 8
	}
	public enum PlatForm
	{
		Android = 1,
		IOS,
		Win,
		Notsupport
	}
	public enum RenderTextureDepth
	{
		BD_0 = 0,
		BD_16 = 16,
		BD_24 = 24
	}
	public enum RenderTextureLevel
	{
		Normal,
		High
	}
	public enum Sensorindex
	{
		Default,
		FirstSensor,
		SecondSensor
	}
	public enum Eye
	{
		LeftEye,
		RightEye,
		BothEye
	}
	public enum ResUtilsType
	{
		TYPE_TEXTSIZE,
		TYPE_COLOR,
		TYPE_TEXT,
		TYPE_FONT,
		TYPE_VALUE,
		TYPE_DRAWABLE,
		TYPE_OBJECT,
		TYPR_OBJECTARRAY
	}
	public enum TrackingOrigin
	{
		EyeLevel,
		FloorLevel,
		StageLevel
	}
	public enum EFoveationLevel
	{
		Low,
		Med,
		High,
		Top_High
	}
	public enum StereoRenderingPathPico
	{
		MultiPass,
		SinglePass
	}
	public enum ExtraLatencyMode
	{
		ExtraLatencyModeOff,
		ExtraLatencyModeOn,
		ExtraLatencyModeDynamic
	}
	public enum pvrEyePoseStatus
	{
		kGazePointValid = 1,
		kGazeVectorValid = 2,
		kEyeOpennessValid = 4,
		kEyePupilDilationValid = 8,
		kEyePositionGuideValid = 0x10
	}
	public enum TrackingMode
	{
		PVR_TRACKING_MODE_ROTATION = 1,
		PVR_TRACKING_MODE_POSITION = 2,
		PVR_TRACKING_MODE_EYE = 4
	}
	public enum SystemDisplayFrequency
	{
		Default,
		RefreshRate72,
		RefreshRate90
	}
	public struct EyeTrackingData
	{
		public int leftEyePoseStatus;

		public int rightEyePoseStatus;

		public int combinedEyePoseStatus;

		public Vector3 leftEyeGazePoint;

		public Vector3 rightEyeGazePoint;

		public Vector3 combinedEyeGazePoint;

		public Vector3 leftEyeGazeVector;

		public Vector3 rightEyeGazeVector;

		public Vector3 combinedEyeGazeVector;

		public float leftEyeOpenness;

		public float rightEyeOpenness;

		public float leftEyePupilDilation;

		public float rightEyePupilDilation;

		public Vector3 leftEyePositionGuide;

		public Vector3 rightEyePositionGuide;

		public Vector3 foveatedGazeDirection;

		public int foveatedGazeTrackingState;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] reserved;
	}
	public struct EyeTrackingGazeRay
	{
		public Vector3 Direction;

		public bool IsValid;

		public Vector3 Origin;
	}
	public struct EyeDeviceInfo
	{
		public ViewFrustum targetFrustumLeft;

		public ViewFrustum targetFrustumRight;
	}
	public struct ViewFrustum
	{
		public float left;

		public float right;

		public float top;

		public float bottom;

		public float near;

		public float far;
	}
	public struct EyeSetting
	{
		public Transform eyelocalPosition;

		public Rect eyeRect;

		public float eyeFov;

		public float eyeAspect;

		public Matrix4x4 eyeProjectionMatrix;

		public Shader eyeShader;
	}
	public struct Sensor
	{
		public const string LibFileName = "Pvr_UnitySDK";

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_Enable6DofModule(bool enable);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_OptionalResetSensor(int index, int resetRot, int resetPos);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_Init(int index);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_StartSensor(int index);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_StopSensor(int index);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_ResetSensor(int index);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_ResetSensorAll(int index);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetSensorState(int index, ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetMainSensorState(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetPsensorState();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetHmdPSensorStatus();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetSensorGyroscope(int index, ref float x, ref float y, ref float z);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetSensorMagnet(int index, ref float x, ref float y, ref float z);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_Get6DofSensorQualityStatus();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_Get6DofSafePanelFlag();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetReinPosition(float x, float y, float z, float w, float px, float py, float pz, int hand, bool valid, int key);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_SetTrackingOriginType(TrackingOrigin trackingOriginType);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_GetAcceleration(ref float x, ref float y, ref float z);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_GetAngularVelocity(ref float x, ref float y, ref float z);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_GetVelocity(ref float x, ref float y, ref float z);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_GetAngularAcceleration(ref float x, ref float y, ref float z);

		public static bool UPvr_Pvr_Get6DofSafePanelFlag()
		{
			return Pvr_Get6DofSafePanelFlag();
		}

		public static int UPvr_Init(int index)
		{
			return Pvr_Init(index);
		}

		public static void UPvr_InitPsensor()
		{
			Pvr_InitPsensor();
		}

		public static int UPvr_GetPsensorState()
		{
			int res = -1;
			Render.UPvr_GetIntConfig(4, ref res);
			if (res == 1)
			{
				return Pvr_GetPsensorState();
			}
			int num = Pvr_GetAndroidPsensorState();
			if (num != 0 && num != -1)
			{
				num = 1;
			}
			return num;
		}

		public static int UPvr_GetPSensorStatus()
		{
			return Pvr_GetHmdPSensorStatus();
		}

		public static void UPvr_UnregisterPsensor()
		{
			Pvr_UnregisterPsensor();
		}

		public static int UPvr_StartSensor(int index)
		{
			return Pvr_StartSensor(index);
		}

		public static int UPvr_StopSensor(int index)
		{
			return Pvr_StopSensor(index);
		}

		public static int UPvr_ResetSensor(int index)
		{
			Pvr_UnitySDKManager.SDK.resetBasePos = default(Vector3);
			return Pvr_ResetSensor(index);
		}

		public static int UPvr_OptionalResetSensor(int index, int resetRot, int resetPos)
		{
			return Pvr_OptionalResetSensor(index, resetRot, resetPos);
		}

		public static int UPvr_GetSensorState(int index, ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz)
		{
			return Pvr_GetSensorState(index, ref x, ref y, ref z, ref w, ref px, ref py, ref pz);
		}

		public static int UPvr_GetMainSensorState(ref float x, ref float y, ref float z, ref float w, ref float px, ref float py, ref float pz, ref float vfov, ref float hfov, ref int viewNumber)
		{
			return Pvr_GetMainSensorState(ref x, ref y, ref z, ref w, ref px, ref py, ref pz, ref vfov, ref hfov, ref viewNumber);
		}

		public static int UPvr_GetSensorGyroscope(int index, ref float x, ref float y, ref float z)
		{
			return Pvr_GetSensorGyroscope(index, ref x, ref y, ref z);
		}

		public static int UPvr_GetSensorMagnet(int index, ref float x, ref float y, ref float z)
		{
			return Pvr_GetSensorMagnet(index, ref x, ref y, ref z);
		}

		public static int UPvr_Get6DofSensorQualityStatus()
		{
			return Pvr_Get6DofSensorQualityStatus();
		}

		public static int UPvr_Enable6DofModule(bool enable)
		{
			return Pvr_Enable6DofModule(enable);
		}

		public static void Pvr_InitPsensor()
		{
			try
			{
				System.UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaSysActivityClass, "initPsensor", Pvr_UnitySDKRender.Instance.activity);
			}
			catch (Exception ex)
			{
				PLOG.E("Error :" + ex.ToString());
			}
		}

		public static bool Pvr_IsHead6dofReset()
		{
			int res = 0;
			Render.UPvr_GetIntConfig(17, ref res);
			if (res > 0)
			{
				return false;
			}
			bool result = false;
			try
			{
				System.UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaSysActivityClass, "isHead6dofReset", Pvr_UnitySDKRender.Instance.activity);
			}
			catch (Exception ex)
			{
				PLOG.E("Error :" + ex.ToString());
			}
			return result;
		}

		public static int Pvr_GetAndroidPsensorState()
		{
			int result = -1;
			try
			{
				System.UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaSysActivityClass, "getPsensorState");
			}
			catch (Exception ex)
			{
				PLOG.E("Error :" + ex.ToString());
			}
			return result;
		}

		public static void Pvr_UnregisterPsensor()
		{
			try
			{
				System.UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaSysActivityClass, "unregisterListener");
			}
			catch (Exception ex)
			{
				PLOG.E("Error :" + ex.ToString());
			}
		}

		public static int UPvr_ResetSensorAll(int index)
		{
			return Pvr_ResetSensorAll(index);
		}

		public static void UPvr_SetReinPosition(float x, float y, float z, float w, float px, float py, float pz, int hand, bool valid, int key)
		{
			if (PLOG.logLevel > 2)
			{
				PLOG.D("PvrLog UPvr_SetReinPosition" + x + y + z + w + px + py + pz + hand + valid.ToString() + key);
			}
			Pvr_SetReinPosition(x, y, z, w, px, py, pz, hand, valid, key);
		}

		public static bool UPvr_SetTrackingOriginType(TrackingOrigin trackingOriginType)
		{
			return Pvr_SetTrackingOriginType(trackingOriginType);
		}

		public static Vector3 UPvr_GetAcceleration()
		{
			float x = 0f;
			float y = 0f;
			float z = 0f;
			Pvr_GetAcceleration(ref x, ref y, ref z);
			return new Vector3(x, y, 0f - z);
		}

		public static Vector3 UPvr_AngularVelocity()
		{
			float x = 0f;
			float y = 0f;
			float z = 0f;
			Pvr_GetAngularVelocity(ref x, ref y, ref z);
			return new Vector3(0f - x, 0f - y, z);
		}

		public static Vector3 UPvr_GetVelocity()
		{
			float x = 0f;
			float y = 0f;
			float z = 0f;
			Pvr_GetVelocity(ref x, ref y, ref z);
			return new Vector3(x, y, 0f - z);
		}

		public static Vector3 UPvr_GetAngularAcceleration()
		{
			float x = 0f;
			float y = 0f;
			float z = 0f;
			Pvr_GetAngularAcceleration(ref x, ref y, ref z);
			return new Vector3(0f - x, 0f - y, z);
		}
	}
	public struct Render
	{
		public const string LibFileName = "Pvr_UnitySDK";

		public static float[] SystemDisplayFrequenciesAvailable => UPvr_GetDisplayFrequenciesAvailable();

		public static float systemDisplayFrequency
		{
			get
			{
				return UPvr_GetSystemDisplayFrequency();
			}
			set
			{
				UPvr_SetSystemDisplayFrequency(value);
			}
		}

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_ChangeScreenParameters(string model, int width, int height, double xppi, double yppi, double densityDpi);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_SetRatio(float midH, float midV);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_SetPupillaryPoint(bool enable);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr Pvr_GetSupportHMDTypes();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetCurrentHMDType([MarshalAs(UnmanagedType.LPStr)] string type);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetIntConfig(int configsenum, ref int res);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetFloatConfig(int configsenum, ref float res);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetupLayerData(int layerIndex, int sideMask, int textureId, int textureType, int layerFlags, float[] colorScaleAndOffset);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetupLayerCoords(int layerIndex, int sideMask, float[] lowerLeft, float[] lowerRight, float[] upperLeft, float[] upperRight);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetOverlayModelViewMatrix(int overlayType, int overlayShape, int texId, int eyeSide, int layerIndex, bool isHeadLocked, int layerFlags, float[] mvMatrix, float[] modelS, float[] modelR, float[] modelT, float[] cameraR, float[] cameraT, float[] colorScaleAndOffset);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_EnableFoveation(bool enable);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetFoveationParameters(int textureId, int previousId, float focalPointX, float focalPointY, float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetFoveationResource(int textureId, int previousId, float focalPointX, float focalPointY);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetFoveationParameters2(float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetFoveationLevel(EFoveationLevel level);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern EFoveationLevel Pvr_GetFoveationLevel();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_GetIntSysProc(string property, ref int res);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetColorspaceType(int colorspaceType);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetCastingColorspaceType(int colorspaceType);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr Pvr_CreateLayerAndroidSurface(int layerType, int layerIndex);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr Pvr_GetLayerAndroidSurface(int layerType, int layerIndex);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetMonoMode(bool openMono);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_GetStencilMesh(int eye, ref int vertexCount, ref int triangleCount, ref IntPtr vertexData, ref IntPtr indexData);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetRefreshRate(ref float rate);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_SetRefreshRate(float rate);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_GetRawCameraFrame(byte[] buffer, ref uint width, ref uint height, ref uint count);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetDisplayFrequenciesAvailable(float[] rate, int length);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_SetDisplayFrequency(float rate);

		public static float[] UPvr_GetDisplayFrequenciesAvailable()
		{
			float[] array = new float[2];
			int length = 0;
			Pvr_GetDisplayFrequenciesAvailable(array, length);
			return array;
		}

		public static void UPvr_SetDisplayFrequency(float rate)
		{
			Pvr_SetDisplayFrequency(rate);
		}

		public static void UPvr_GetRawCameraData(byte[] buffer, ref uint width, ref uint height, ref uint count)
		{
			Pvr_GetRawCameraFrame(buffer, ref width, ref height, ref count);
		}

		public static void UPvr_ChangeScreenParameters(string model, int width, int height, double xppi, double yppi, double densityDpi)
		{
			Pvr_ChangeScreenParameters(model, width, height, xppi, yppi, densityDpi);
		}

		public static int UPvr_SetRatio(float midH, float midV)
		{
			return Pvr_SetRatio(midH, midV);
		}

		public static void UPvr_EnableFoveation(bool enable)
		{
			if (Pvr_UnitySDKManager.SDK.SystemFFRLevel != -1 || Pvr_UnitySDKManager.SDK.SystemDebugFFRLevel != -1)
			{
				enable = true;
			}
			Pvr_EnableFoveation(enable);
		}

		[Obsolete("This API will be removed in later versions")]
		public static void UPvr_SetFoveationParameters(int textureId, int previousId, float focalPointX, float focalPointY, float foveationGainX, float foveationGainY, float foveationArea, float foveationMinimum)
		{
			Pvr_SetFoveationParameters(textureId, previousId, focalPointX, focalPointY, foveationGainX, foveationGainY, foveationArea, foveationMinimum);
		}

		public static void UPvr_SetFoveationResource(int textureId, int previousId, float focalPointX, float focalPointY)
		{
			Pvr_SetFoveationResource(textureId, previousId, focalPointX, focalPointY);
		}

		public static void SetFoveatedRenderingLevel(EFoveationLevel level)
		{
			if (Pvr_UnitySDKManager.SDK.SystemDebugFFRLevel != -1)
			{
				Pvr_SetFoveationLevel((EFoveationLevel)Pvr_UnitySDKManager.SDK.SystemDebugFFRLevel);
			}
			else if (Pvr_UnitySDKManager.SDK.SystemFFRLevel != -1)
			{
				Pvr_SetFoveationLevel((EFoveationLevel)Pvr_UnitySDKManager.SDK.SystemFFRLevel);
			}
			else
			{
				Pvr_SetFoveationLevel(level);
			}
		}

		public static EFoveationLevel GetFoveatedRenderingLevel()
		{
			return Pvr_GetFoveationLevel();
		}

		public static void SetFoveatedRenderingParameters(Vector2 ffrGainValue, float ffrAreaValue, float ffrMinimumValue)
		{
			if (Pvr_UnitySDKManager.SDK.SystemDebugFFRLevel != -1)
			{
				Pvr_SetFoveationLevel((EFoveationLevel)Pvr_UnitySDKManager.SDK.SystemDebugFFRLevel);
			}
			else if (Pvr_UnitySDKManager.SDK.SystemFFRLevel != -1)
			{
				Pvr_SetFoveationLevel((EFoveationLevel)Pvr_UnitySDKManager.SDK.SystemFFRLevel);
			}
			else
			{
				Pvr_SetFoveationParameters2(ffrGainValue.x, ffrGainValue.y, ffrAreaValue, ffrMinimumValue);
			}
		}

		public static bool UPvr_GetIntSysProc(string property, ref int res)
		{
			return Pvr_GetIntSysProc(property, ref res);
		}

		public static int UPvr_GetIntConfig(int configsenum, ref int res)
		{
			return Pvr_GetIntConfig(configsenum, ref res);
		}

		public static int UPvr_GetFloatConfig(int configsenum, ref float res)
		{
			return Pvr_GetFloatConfig(configsenum, ref res);
		}

		public static string UPvr_GetSupportHMDTypes()
		{
			IntPtr intPtr = Pvr_GetSupportHMDTypes();
			if (intPtr != IntPtr.Zero)
			{
				return Marshal.PtrToStringAnsi(intPtr);
			}
			return null;
		}

		public static void UPvr_SetCurrentHMDType(string type)
		{
			Pvr_SetCurrentHMDType(type);
		}

		public static void UPvr_SetupLayerData(int layerIndex, int sideMask, int textureId, int textureType, int layerFlags, Vector4 colorScale, Vector4 colorOffset)
		{
			Pvr_SetupLayerData(layerIndex, sideMask, textureId, textureType, layerFlags, new float[8] { colorScale.x, colorScale.y, colorScale.z, colorScale.w, colorOffset.x, colorOffset.y, colorOffset.z, colorOffset.w });
		}

		public static void UPvr_SetupLayerCoords(int layerIndex, int sideMask, float[] lowerLeft, float[] lowerRight, float[] upperLeft, float[] upperRight)
		{
			Pvr_SetupLayerCoords(layerIndex, sideMask, lowerLeft, lowerRight, upperLeft, upperRight);
		}

		public static void UPvr_SetOverlayModelViewMatrix(int overlayType, int overlayShape, int texId, int eyeSide, int layerIndex, bool isHeadLocked, int layerFlags, Matrix4x4 mvMatrix, Vector3 modelS, Quaternion modelR, Vector3 modelT, Quaternion cameraR, Vector3 cameraT, Vector4 colorScale, Vector4 colorOffset)
		{
			Pvr_SetOverlayModelViewMatrix(overlayType, overlayShape, texId, eyeSide, layerIndex, isHeadLocked, layerFlags, new float[16]
			{
				mvMatrix.m00, mvMatrix.m01, mvMatrix.m02, mvMatrix.m03, mvMatrix.m10, mvMatrix.m11, mvMatrix.m12, mvMatrix.m13, mvMatrix.m20, mvMatrix.m21,
				mvMatrix.m22, mvMatrix.m23, mvMatrix.m30, mvMatrix.m31, mvMatrix.m32, mvMatrix.m33
			}, new float[3] { modelS.x, modelS.y, modelS.z }, new float[4] { modelR.x, modelR.y, modelR.z, modelR.w }, new float[3] { modelT.x, modelT.y, modelT.z }, new float[4] { cameraR.x, cameraR.y, cameraR.z, cameraR.w }, new float[3] { cameraT.x, cameraT.y, cameraT.z }, new float[8] { colorScale.x, colorScale.y, colorScale.z, colorScale.w, colorOffset.x, colorOffset.y, colorOffset.z, colorOffset.w });
		}

		public static void UPvr_SetColorspaceType(int colorspaceType)
		{
			Pvr_SetColorspaceType(colorspaceType);
		}

		public static void UPvr_SetCastingColorspaceType(int colorspaceType)
		{
			Pvr_SetCastingColorspaceType(colorspaceType);
		}

		public static IntPtr UPvr_CreateLayerAndroidSurface(int layerType, int layerIndex)
		{
			return Pvr_CreateLayerAndroidSurface(layerType, layerIndex);
		}

		public static IntPtr UPvr_GetLayerAndroidSurface(int layerType, int layerIndex)
		{
			return Pvr_GetLayerAndroidSurface(layerType, layerIndex);
		}

		public static void UPvr_SetMonoMode(bool openMono)
		{
			PLOG.I("PvrLog SetMonoMode : " + openMono);
			Pvr_SetMonoMode(openMono);
		}

		public static void UPvr_GetStencilMesh(int eye, ref int vertexCount, ref int triangleCount, ref IntPtr vertexDataPtr, ref IntPtr indexDataPtr)
		{
			Pvr_GetStencilMesh(eye, ref vertexCount, ref triangleCount, ref vertexDataPtr, ref indexDataPtr);
		}

		public static float UPvr_GetSystemDisplayFrequency()
		{
			float rate = 0f;
			Pvr_GetRefreshRate(ref rate);
			return rate;
		}

		public static void UPvr_SetSystemDisplayFrequency(float rate)
		{
			Pvr_SetRefreshRate(rate);
		}
	}
	public struct System
	{
		public const string LibFileName = "Pvr_UnitySDK";

		public const string UnitySDKVersion = "2.8.11.5";

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_SetInitActivity(IntPtr activity, IntPtr vrActivityClass);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr Pvr_GetSDKVersion();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pvr_GetHmdHardwareVersion();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr Pvr_GetHmdFirmwareVersion();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr Pvr_GetHmdSerialNumber();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern int PVR_GetHmdBatteryStatus();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern float PVR_GetHmdBatteryTemperature();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern int PVR_SetHmdAudioStatus(bool enable);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_GetEyeTrackingData(ref int leftEyePoseStatus, ref int rightEyePoseStatus, ref int combinedEyePoseStatus, ref float leftEyeGazePointX, ref float leftEyeGazePointY, ref float leftEyeGazePointZ, ref float rightEyeGazePointX, ref float rightEyeGazePointY, ref float rightEyeGazePointZ, ref float combinedEyeGazePointX, ref float combinedEyeGazePointY, ref float combinedEyeGazePointZ, ref float leftEyeGazeVectorX, ref float leftEyeGazeVectorY, ref float leftEyeGazeVectorZ, ref float rightEyeGazeVectorX, ref float rightEyeGazeVectorY, ref float rightEyeGazeVectorZ, ref float combinedEyeGazeVectorX, ref float combinedEyeGazeVectorY, ref float combinedEyeGazeVectorZ, ref float leftEyeOpenness, ref float rightEyeOpenness, ref float leftEyePupilDilation, ref float rightEyePupilDilation, ref float leftEyePositionGuideX, ref float leftEyePositionGuideY, ref float leftEyePositionGuideZ, ref float rightEyePositionGuideX, ref float rightEyePositionGuideY, ref float rightEyePositionGuideZ, ref float foveatedGazeDirectionX, ref float foveatedGazeDirectionY, ref float foveatedGazeDirectionZ, ref int foveatedGazeTrackingState);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_SetTrackingMode(int trackingMode);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern int Pvr_GetTrackingMode();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr GetRenderEventFunc();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UnityEventData(long data);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_EnableSinglePass(bool enable);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_SetAntiAliasing(int antiAliasing);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_SinglePassBeforeForwardOpaque();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_SetCurrentRenderTexture(uint textureId);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_SetSinglePassDepthBufferWidthHeight(int width, int height);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern int PVR_setPerformanceLevels(int cpuLevel, int gpuLevel);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_SetIPD(float distance);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern float Pvr_GetIPD();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_SetTrackingIPDEnabled(bool enable);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_GetTrackingIPDEnabled();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_GetEyeTrackingAutoIPD(ref float autoIPD);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern int PVR_GetHmdAudioStatus();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern float Pvr_GetPredictedDisplayTime();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool Pvr_SetExtraLatencyMode(int mode);

		public static bool UPvr_CallStaticMethod<T>(ref T result, AndroidJavaClass jclass, string name, params object[] args)
		{
			try
			{
				result = jclass.CallStatic<T>(name, args);
				return true;
			}
			catch (AndroidJavaException ex)
			{
				PLOG.E("Exception calling static method " + name + ": " + ex);
				return false;
			}
		}

		public static bool UPvr_CallStaticMethod(AndroidJavaObject jobj, string name, params object[] args)
		{
			try
			{
				jobj.CallStatic(name, args);
				return true;
			}
			catch (AndroidJavaException ex)
			{
				PLOG.E("CallStaticMethod  Exception calling activity method " + name + ": " + ex);
				return false;
			}
		}

		public static bool UPvr_CallMethod<T>(ref T result, AndroidJavaObject jobj, string name, params object[] args)
		{
			try
			{
				result = jobj.Call<T>(name, args);
				return true;
			}
			catch (AndroidJavaException ex)
			{
				PLOG.E("Exception calling activity method " + name + ": " + ex);
				return false;
			}
		}

		public static bool UPvr_CallMethod(AndroidJavaObject jobj, string name, params object[] args)
		{
			try
			{
				jobj.Call(name, args);
				return true;
			}
			catch (AndroidJavaException ex)
			{
				PLOG.E(" Exception calling activity method " + name + ": " + ex);
				return false;
			}
		}

		public static string UPvr_GetSDKVersion()
		{
			IntPtr intPtr = Pvr_GetSDKVersion();
			if (intPtr != IntPtr.Zero)
			{
				return Marshal.PtrToStringAnsi(intPtr);
			}
			return "";
		}

		public static string UPvr_GetUnitySDKVersion()
		{
			return "2.8.11.5";
		}

		public static string UPvr_GetDeviceMode()
		{
			return SystemInfo.deviceModel;
		}

		public static string UPvr_GetDeviceModel()
		{
			return SystemInfo.deviceModel;
		}

		public static string UPvr_GetDeviceSN()
		{
			string result = "UNKONWN";
			UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaSysActivityClass, "getDeviceSN");
			return result;
		}

		public static AndroidJavaObject UPvr_GetCurrentActivity()
		{
			return new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		}

		public static bool UPvr_SetMonoPresentation()
		{
			return UPvr_CallMethod(UPvr_GetCurrentActivity(), "Pvr_setMonoPresentation");
		}

		public static bool UPvr_IsPresentationExisted()
		{
			bool result = false;
			return UPvr_CallMethod(ref result, UPvr_GetCurrentActivity(), "Pvr_isPresentationExisted") && result;
		}

		public static bool UPvr_GetMainActivityPauseStatus()
		{
			bool result = false;
			return UPvr_CallMethod(ref result, UPvr_GetCurrentActivity(), "Pvr_getMainActivityPauseStatus") && result;
		}

		public static void UPvr_Sleep()
		{
			UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaSysActivityClass, "Pvr_Sleep");
		}

		public static bool UPvr_StartHomeKeyReceiver(string startreceivre)
		{
			try
			{
				if (Pvr_UnitySDKRender.Instance != null)
				{
					UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaVrActivityLongReceiver, "Pvr_StartReceiver", Pvr_UnitySDKRender.Instance.activity, startreceivre);
					PLOG.I("Start home key Receiver");
					return true;
				}
			}
			catch (Exception ex)
			{
				PLOG.E("Start home key  Receiver  Error :" + ex.ToString());
				return false;
			}
			return true;
		}

		public static bool UPvr_StopHomeKeyReceiver()
		{
			try
			{
				if (Pvr_UnitySDKRender.Instance != null)
				{
					UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaVrActivityLongReceiver, "Pvr_StopReceiver", Pvr_UnitySDKRender.Instance.activity);
					PLOG.I("Stop home key Receiver");
					return true;
				}
			}
			catch (Exception ex)
			{
				PLOG.E("Stop home key Receiver Error :" + ex.ToString());
				return false;
			}
			return true;
		}

		public static void UPvr_StartVRModel()
		{
			UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaVrActivityClass, "startVRModel");
		}

		public static void UPvr_RemovePlatformLogo()
		{
			UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaVrActivityClass, "removePlatformLogo");
		}

		public static void UPvr_ShowPlatformLogo()
		{
			UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaVrActivityClass, "showPlatformLogo");
		}

		public static bool UPvr_IsPicoActivity()
		{
			bool result = false;
			return UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "isPicoActivity", UPvr_GetCurrentActivity()) && result;
		}

		public static void UPvr_StopVRModel()
		{
			UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaVrActivityClass, "stopVRModel");
		}

		public static string UPvr_GetCountryCode()
		{
			string result = "";
			UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getCountryCode", UPvr_GetCurrentActivity());
			return result;
		}

		public static bool UPvr_SetIPD(float distance)
		{
			bool flag = false;
			flag = Pvr_SetIPD(distance);
			if (flag)
			{
				for (int i = 0; i < Pvr_UnitySDKEyeManager.Instance.Eyes.Length; i++)
				{
					Pvr_UnitySDKEyeManager.Instance.Eyes[i].RefreshCameraPosition(distance);
				}
			}
			return flag;
		}

		public static float UPvr_GetIPD()
		{
			float num = Pvr_GetIPD();
			UnityEngine.Debug.Log("DISFT IPD:" + num);
			return num;
		}

		public static bool UPvr_SetTrackingIPDEnabled(bool enable)
		{
			return Pvr_SetTrackingIPDEnabled(enable);
		}

		public static bool UPvr_GetTrackingIPDEnabled()
		{
			return Pvr_GetTrackingIPDEnabled();
		}

		public static bool UPvr_GetEyeTrackingAutoIPD(ref float autoipd)
		{
			return Pvr_GetEyeTrackingAutoIPD(ref autoipd);
		}

		public static void UPvr_UnityEventData(long data)
		{
			UnityEventData(data);
		}

		public static long UPvr_GetEyeBufferData(int id)
		{
			return ((long)Pvr_UnitySDKRender.Instance.RenderviewNumber << 32) | id;
		}

		public static bool UPvr_checkDevice(string packagename)
		{
			bool result = false;
			UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "checkDevice", packagename, UPvr_GetCurrentActivity());
			return result;
		}

		public static int UPvr_GetHmdHardwareVersion()
		{
			return Pvr_GetHmdHardwareVersion();
		}

		public static string UPvr_GetHmdFirmwareVersion()
		{
			IntPtr intPtr = Pvr_GetHmdFirmwareVersion();
			if (intPtr != IntPtr.Zero)
			{
				return Marshal.PtrToStringAnsi(intPtr);
			}
			return "";
		}

		public static string UPvr_GetHmdSerialNumber()
		{
			IntPtr intPtr = Pvr_GetHmdSerialNumber();
			if (intPtr != IntPtr.Zero)
			{
				return Marshal.PtrToStringAnsi(intPtr);
			}
			return "";
		}

		public static int UPvr_GetHmdBatteryStatus()
		{
			return PVR_GetHmdBatteryStatus();
		}

		public static float UPvr_GetHmdBatteryTemperature()
		{
			return PVR_GetHmdBatteryTemperature();
		}

		public static int UPvr_SetHmdAudioStatus(bool enable)
		{
			return PVR_SetHmdAudioStatus(enable);
		}

		public static int UPvr_GetTrackingMode()
		{
			return Pvr_GetTrackingMode();
		}

		public static bool UPvr_setTrackingMode(int trackingMode)
		{
			return Pvr_SetTrackingMode(trackingMode);
		}

		public static bool UPvr_getEyeTrackingData(ref EyeTrackingData trackingData)
		{
			if (!Pvr_UnitySDKEyeManager.supportEyeTracking)
			{
				PLOG.E("The device is not supported");
				return false;
			}
			if (!Pvr_UnitySDKEyeManager.Instance.EyeTracking)
			{
				PLOG.E("Please Enable \"Pvr_UnitySDK/Head/Pvr_UnitySDKEyeManager.cs/EyeTracking\"option first.");
				return false;
			}
			bool result = Pvr_GetEyeTrackingData(ref trackingData.leftEyePoseStatus, ref trackingData.rightEyePoseStatus, ref trackingData.combinedEyePoseStatus, ref trackingData.leftEyeGazePoint.x, ref trackingData.leftEyeGazePoint.y, ref trackingData.leftEyeGazePoint.z, ref trackingData.rightEyeGazePoint.x, ref trackingData.rightEyeGazePoint.y, ref trackingData.rightEyeGazePoint.z, ref trackingData.combinedEyeGazePoint.x, ref trackingData.combinedEyeGazePoint.y, ref trackingData.combinedEyeGazePoint.z, ref trackingData.leftEyeGazeVector.x, ref trackingData.leftEyeGazeVector.y, ref trackingData.leftEyeGazeVector.z, ref trackingData.rightEyeGazeVector.x, ref trackingData.rightEyeGazeVector.y, ref trackingData.rightEyeGazeVector.z, ref trackingData.combinedEyeGazeVector.x, ref trackingData.combinedEyeGazeVector.y, ref trackingData.combinedEyeGazeVector.z, ref trackingData.leftEyeOpenness, ref trackingData.rightEyeOpenness, ref trackingData.leftEyePupilDilation, ref trackingData.rightEyePupilDilation, ref trackingData.leftEyePositionGuide.x, ref trackingData.leftEyePositionGuide.y, ref trackingData.leftEyePositionGuide.z, ref trackingData.rightEyePositionGuide.x, ref trackingData.rightEyePositionGuide.y, ref trackingData.rightEyePositionGuide.z, ref trackingData.foveatedGazeDirection.x, ref trackingData.foveatedGazeDirection.y, ref trackingData.foveatedGazeDirection.z, ref trackingData.foveatedGazeTrackingState);
			trackingData.leftEyeGazeVector.z = 0f - trackingData.leftEyeGazeVector.z;
			trackingData.rightEyeGazeVector.z = 0f - trackingData.rightEyeGazeVector.z;
			trackingData.combinedEyeGazeVector.z = 0f - trackingData.combinedEyeGazeVector.z;
			trackingData.leftEyeGazePoint.z = 0f - trackingData.leftEyeGazePoint.z;
			trackingData.rightEyeGazePoint.z = 0f - trackingData.rightEyeGazePoint.z;
			trackingData.combinedEyeGazePoint.z = 0f - trackingData.combinedEyeGazePoint.z;
			trackingData.foveatedGazeDirection.z = 0f - trackingData.foveatedGazeDirection.z;
			return result;
		}

		public static bool UPvr_getEyeTrackingGazeRay(ref EyeTrackingGazeRay gazeRay)
		{
			if (!Pvr_UnitySDKEyeManager.supportEyeTracking)
			{
				PLOG.E("The device is not supported");
				return false;
			}
			if (!Pvr_UnitySDKEyeManager.Instance.EyeTracking)
			{
				PLOG.E("Please Enable \"Pvr_UnitySDK/Head/Pvr_UnitySDKEyeManager.cs/EyeTracking\"option first.");
				return false;
			}
			EyeTrackingData trackingData = default(EyeTrackingData);
			UPvr_getEyeTrackingData(ref trackingData);
			gazeRay.IsValid = ((uint)trackingData.combinedEyePoseStatus & (true ? 1u : 0u)) != 0 && (trackingData.combinedEyePoseStatus & 2) != 0;
			if (gazeRay.IsValid)
			{
				gazeRay.Direction = trackingData.combinedEyeGazeVector;
				gazeRay.Origin = trackingData.combinedEyeGazePoint;
				gazeRay.Origin = Pvr_UnitySDKSensor.Instance.HeadPose.Matrix.MultiplyPoint(gazeRay.Origin);
				gazeRay.Direction = Pvr_UnitySDKSensor.Instance.HeadPose.Matrix.MultiplyVector(gazeRay.Direction);
				return true;
			}
			return false;
		}

		public static bool UPvr_getEyeTrackingGazeRayWorld(ref EyeTrackingGazeRay gazeRay)
		{
			if (!Pvr_UnitySDKEyeManager.supportEyeTracking)
			{
				PLOG.E("The device is not supported");
				return false;
			}
			if (!Pvr_UnitySDKEyeManager.Instance.EyeTracking)
			{
				PLOG.E("Please Enable \"Pvr_UnitySDK/Head/Pvr_UnitySDKEyeManager.cs/EyeTracking\"option first.");
				return false;
			}
			Transform transform = Pvr_UnitySDKEyeManager.Instance.transform;
			Matrix4x4 matrix4x = Matrix4x4.TRS(transform.position, transform.rotation, Vector3.one);
			EyeTrackingData trackingData = default(EyeTrackingData);
			UPvr_getEyeTrackingData(ref trackingData);
			gazeRay.IsValid = ((uint)trackingData.combinedEyePoseStatus & (true ? 1u : 0u)) != 0 && (trackingData.combinedEyePoseStatus & 2) != 0;
			if (gazeRay.IsValid)
			{
				gazeRay.Direction = trackingData.combinedEyeGazeVector;
				gazeRay.Origin = trackingData.combinedEyeGazePoint;
				gazeRay.Origin = matrix4x.MultiplyPoint(gazeRay.Origin);
				gazeRay.Direction = matrix4x.MultiplyVector(gazeRay.Direction);
				return true;
			}
			return false;
		}

		public static Vector3 UPvr_getEyeTrackingPos()
		{
			if (!Pvr_UnitySDKEyeManager.supportEyeTracking)
			{
				PLOG.E("The device is not supported");
				return Vector3.zero;
			}
			if (!Pvr_UnitySDKEyeManager.Instance.EyeTracking)
			{
				PLOG.E("Please Enable \"Pvr_UnitySDK/Head/Pvr_UnitySDKEyeManager.cs/EyeTracking\"option first.");
				return Vector3.zero;
			}
			return Pvr_UnitySDKEyeManager.Instance.GetEyeTrackingPos();
		}

		public static int UPvr_GetPhoneScreenBrightness()
		{
			int result = 0;
			UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClientClass, "Pvr_GetScreen_Brightness", UPvr_GetCurrentActivity());
			return result;
		}

		public static void UPvr_SetPhoneScreenBrightness(int level)
		{
			UPvr_CallStaticMethod(Pvr_UnitySDKRender.javaVrActivityClientClass, "Pvr_setAPPScreen_Brightness", UPvr_GetCurrentActivity(), level);
		}

		public static bool UPvr_IsPicoDefaultActivity()
		{
			using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
			{
				using AndroidJavaObject androidJavaObject = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
				if (androidJavaObject.Call<string>("getLocalClassName", Array.Empty<object>()) == "com.unity3d.player.UnityPlayerNativeActivityPico")
				{
					return true;
				}
			}
			return false;
		}

		public static bool UPvr_EnableSinglePass(bool enable)
		{
			return Pvr_EnableSinglePass(enable);
		}

		public static void UPvr_SetAntiAliasing(int antiAliasing)
		{
			Pvr_SetAntiAliasing(antiAliasing);
		}

		public static void UPvr_SinglePassBeforeForwardOpaque()
		{
			Pvr_SinglePassBeforeForwardOpaque();
		}

		public static void UPvr_SetCurrentRenderTexture(uint textureId)
		{
			Pvr_SetCurrentRenderTexture(textureId);
		}

		public static bool UPvr_SetSinglePassDepthBufferWidthHeight(int width, int height)
		{
			return Pvr_SetSinglePassDepthBufferWidthHeight(width, height);
		}

		public static int UPVR_setPerformanceLevels(int cpuLevel, int gpuLevel)
		{
			return PVR_setPerformanceLevels(cpuLevel, gpuLevel);
		}

		public static int UPvr_GetColorRes(string name)
		{
			int result = -1;
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getColorRes", name);
			}
			catch (Exception ex)
			{
				PLOG.E("GetColorResError :" + ex.ToString());
			}
			return result;
		}

		public static int UPvr_GetConfigInt(string name)
		{
			int result = -1;
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getConfigInt", name);
			}
			catch (Exception ex)
			{
				PLOG.E("GetConfigIntError :" + ex.ToString());
			}
			return result;
		}

		public static string UPvr_GetConfigString(string name)
		{
			string result = "";
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getConfigString", name);
			}
			catch (Exception ex)
			{
				PLOG.E("GetConfigStringError :" + ex.ToString());
			}
			return result;
		}

		public static string UPvr_GetDrawableLocation(string name)
		{
			string result = "";
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getDrawableLocation", name);
			}
			catch (Exception ex)
			{
				PLOG.E("GetDrawableLocationError :" + ex.ToString());
			}
			return result;
		}

		public static int UPvr_GetTextSize(string name)
		{
			int result = -1;
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getTextSize", name);
			}
			catch (Exception ex)
			{
				PLOG.E("GetTextSizeError :" + ex.ToString());
			}
			return result;
		}

		public static string UPvr_GetLangString(string name)
		{
			string result = "";
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getLangString", name);
			}
			catch (Exception ex)
			{
				PLOG.E("GetLangStringError :" + ex.ToString());
			}
			return result;
		}

		public static string UPvr_GetStringValue(string id, int type)
		{
			string result = "";
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getStringValue", id, type);
			}
			catch (Exception ex)
			{
				PLOG.E("GetStringValueError :" + ex.ToString());
			}
			return result;
		}

		public static int UPvr_GetIntValue(string id, int type)
		{
			int result = -1;
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getIntValue", id, type);
			}
			catch (Exception ex)
			{
				PLOG.E("GetIntValueError :" + ex.ToString());
			}
			return result;
		}

		public static float UPvr_GetFloatValue(string id)
		{
			float result = -1f;
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getFloatValue", id);
			}
			catch (Exception ex)
			{
				PLOG.E("GetFloatValueError :" + ex.ToString());
			}
			return result;
		}

		public static string UPvr_GetObjectOrArray(string id, int type)
		{
			string result = "";
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getObjectOrArray", id, type);
			}
			catch (Exception ex)
			{
				PLOG.E("GetObjectOrArrayError :" + ex.ToString());
			}
			return result;
		}

		public static int UPvr_GetCharSpace(string id)
		{
			int result = -1;
			try
			{
				UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getCharSpace", id);
			}
			catch (Exception ex)
			{
				PLOG.E("GetCharSpaceError :" + ex.ToString());
			}
			return result;
		}

		public static bool UPvr_SetExtraLatencyMode(ExtraLatencyMode mode)
		{
			return Pvr_SetExtraLatencyMode((int)mode);
		}

		public static float UPvr_GetPredictedDisplayTime()
		{
			float result = 0f;
			try
			{
				result = Pvr_GetPredictedDisplayTime();
			}
			catch (Exception ex)
			{
				UnityEngine.Debug.Log("UPvr_GetPredictedDisplayTime :" + ex.ToString());
			}
			return result;
		}
	}
	public struct BoundarySystem
	{
		public enum BoundaryType
		{
			OuterBoundary,
			PlayArea
		}

		public struct BoundaryTestResult
		{
			public bool IsTriggering;

			public float ClosestDistance;

			public Vector3 ClosestPoint;

			public Vector3 ClosestPointNormal;
		}

		public enum BoundaryTrackingNode
		{
			HandLeft,
			HandRight,
			Head
		}

		public enum BoundaryTrackingState
		{
			LostNoReason = 3,
			LostCamera,
			LostHighLight,
			LostLowLight,
			LostLowFeatureCount,
			LostReLocation,
			LostInitialization,
			LostNoCamera,
			LostNoIMU,
			LostIMUJitter,
			LostUnknown
		}

		public const string LibFileName = "Pvr_UnitySDK";

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern float Pvr_GetFloorHeight();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetSeeThroughState();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_BoundarySetSTBackground(bool value);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetTrackingState();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_GetFrameRateLimit();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_IsBoundaryEnable();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_BoundaryGetConfigured();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_BoundaryTestNode(int node, bool isPlayArea, ref bool isTriggering, ref float closestDistance, ref float px, ref float py, ref float pz, ref float nx, ref float ny, ref float nz);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_BoundaryTestPoint(float x, float y, float z, bool isPlayArea, ref bool isTriggering, ref float closestDistance, ref float px, ref float py, ref float pz, ref float nx, ref float ny, ref float nz);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_BoundaryGetGeometry(out IntPtr handle, bool isPlayArea);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_BoundaryGetDimensions(ref float x, ref float y, ref float z, bool isPlayArea);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_BoundaryGetEnabled();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_BoundarySetVisible(bool value);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_BoundaryGetVisible();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_EnableLWRP(bool enable);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_SetViewportSize(int w, int h);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_BoundarySetSeeThroughVisible(bool value);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void PVR_SetCameraImageRect(int width, int height);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern void Pvr_SetGuardianSystemDisable(bool value);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetDialogState();

		public static float UPvr_GetFloorHeight()
		{
			return Pvr_GetFloorHeight();
		}

		public static int UPvr_GetSeeThroughState()
		{
			return Pvr_GetSeeThroughState();
		}

		public static void UPvr_EnableSeeThroughManual(bool enable)
		{
			Pvr_BoundarySetSTBackground(enable);
		}

		public static BoundaryTrackingState UPvr_GetTrackingState()
		{
			return (BoundaryTrackingState)Pvr_GetTrackingState();
		}

		public static bool UPvr_GetFrameRateLimit()
		{
			return Pvr_GetFrameRateLimit();
		}

		public static bool UPvr_IsBoundaryEnable()
		{
			return Pvr_IsBoundaryEnable();
		}

		public static bool UPvr_BoundaryGetConfigured()
		{
			return Pvr_BoundaryGetConfigured();
		}

		public static BoundaryTestResult UPvr_BoundaryTestNode(BoundaryTrackingNode node, BoundaryType boundaryType)
		{
			BoundaryTestResult result = default(BoundaryTestResult);
			bool num = Pvr_BoundaryTestNode((int)node, boundaryType == BoundaryType.PlayArea, ref result.IsTriggering, ref result.ClosestDistance, ref result.ClosestPoint.x, ref result.ClosestPoint.y, ref result.ClosestPoint.z, ref result.ClosestPointNormal.x, ref result.ClosestPointNormal.y, ref result.ClosestPointNormal.z);
			result.ClosestPoint.z = 0f - result.ClosestPoint.z;
			result.ClosestPointNormal.z = 0f - result.ClosestPointNormal.z;
			if (!num)
			{
				UnityEngine.Debug.LogError($"UPvr_BoundaryTestNode({node}, {boundaryType}) API call failed!");
			}
			return result;
		}

		public static BoundaryTestResult UPvr_BoundaryTestPoint(Vector3 point, BoundaryType boundaryType)
		{
			BoundaryTestResult result = default(BoundaryTestResult);
			if (!Pvr_BoundaryTestPoint(point.x, point.y, 0f - point.z, boundaryType == BoundaryType.PlayArea, ref result.IsTriggering, ref result.ClosestDistance, ref result.ClosestPoint.x, ref result.ClosestPoint.y, ref result.ClosestPoint.z, ref result.ClosestPointNormal.x, ref result.ClosestPointNormal.y, ref result.ClosestPointNormal.z))
			{
				UnityEngine.Debug.LogError($"UPvr_BoundaryTestPoint({point}, {boundaryType}) API call failed!");
			}
			return result;
		}

		public static Vector3[] UPvr_BoundaryGetGeometry(BoundaryType boundaryType)
		{
			IntPtr handle = IntPtr.Zero;
			int num = Pvr_BoundaryGetGeometry(out handle, boundaryType == BoundaryType.PlayArea);
			if (num <= 0)
			{
				UnityEngine.Debug.LogError("Boundary geometry point count is " + num);
				return null;
			}
			int num2 = num * 3;
			float[] array = new float[num2];
			Marshal.Copy(handle, array, 0, num2);
			Vector3[] array2 = new Vector3[num];
			for (int i = 0; i < num; i++)
			{
				array2[i] = new Vector3
				{
					x = array[3 * i],
					y = array[3 * i + 1],
					z = 0f - array[3 * i + 2]
				};
			}
			return array2;
		}

		public static Vector3 UPvr_BoundaryGetDimensions(BoundaryType boundaryType)
		{
			float x = 0f;
			float y = 0f;
			float z = 0f;
			Pvr_BoundaryGetDimensions(ref x, ref y, ref z, boundaryType == BoundaryType.PlayArea);
			return new Vector3(x, y, z);
		}

		public static bool UPvr_BoundaryGetEnabled()
		{
			return Pvr_BoundaryGetEnabled();
		}

		public static void UPvr_BoundarySetVisible(bool value)
		{
			Pvr_BoundarySetVisible(value);
		}

		public static bool UPvr_BoundaryGetVisible()
		{
			return Pvr_BoundaryGetVisible();
		}

		public static bool UPvr_EnableLWRP(bool enable)
		{
			return Pvr_EnableLWRP(enable);
		}

		public static bool UPvr_SetViewportSize(int width, int height)
		{
			return Pvr_SetViewportSize(width, height);
		}

		public static void UPvr_StartCameraFrame()
		{
			try
			{
				Pvr_UnitySDKPluginEvent.Issue(RenderEventType.StartCameraFrame);
			}
			catch (Exception ex)
			{
				PLOG.E("UPvr_StartCameraFrame :" + ex.ToString());
			}
		}

		public static void UPvr_StopCameraFrame()
		{
			try
			{
				Pvr_UnitySDKPluginEvent.Issue(RenderEventType.StopCameraFrame);
			}
			catch (Exception ex)
			{
				PLOG.E("UPvr_StopCameraFrame :" + ex.ToString());
			}
		}

		public static void UPvr_BoundaryGetSeeThroughData(int cameraIndex, RenderTexture renderTexture)
		{
			try
			{
				if (renderTexture.IsCreated())
				{
					System.UPvr_UnityEventData(renderTexture.GetNativeTexturePtr().ToInt32());
					switch (cameraIndex)
					{
					case 0:
						Pvr_UnitySDKPluginEvent.Issue(RenderEventType.CameraFrameLeft);
						break;
					case 1:
						Pvr_UnitySDKPluginEvent.Issue(RenderEventType.CameraFrameRight);
						break;
					}
				}
			}
			catch (Exception ex)
			{
				PLOG.E("UPvr_BoundaryGetSeeThroughDataError :" + ex.ToString());
			}
		}

		public static void UPvr_BoundarySetCameraImageRect(int width, int height)
		{
			try
			{
				PVR_SetCameraImageRect(width, height);
			}
			catch (Exception ex)
			{
				PLOG.E("UPvr_BoundarySetCameraImageRectError :" + ex.ToString());
			}
		}

		public static void UPvr_BoundarySetSeeThroughVisible(bool value)
		{
			try
			{
				Pvr_BoundarySetSeeThroughVisible(value);
			}
			catch (Exception ex)
			{
				PLOG.E("UPvr_BoundarySetSeeThroughVisibleError :" + ex.ToString());
			}
		}

		public static void UPvr_SetGuardianSystemDisable(bool value)
		{
			try
			{
				Pvr_SetGuardianSystemDisable(value);
			}
			catch (Exception ex)
			{
				PLOG.E("UPvr_SetGuardianSystemDisableError :" + ex.ToString());
			}
		}

		public static int UPvr_GetDialogState()
		{
			int result = 0;
			try
			{
				result = Pvr_GetDialogState();
			}
			catch (Exception ex)
			{
				PLOG.E("UPvr_GetDialogStateError :" + ex.ToString());
			}
			return result;
		}
	}
	public struct PlatformSettings
	{
		public static Pvr_UnitySDKPlatformSetting.simulationType UPvr_IsCurrentDeviceValid()
		{
			if (Pvr_UnitySDKPlatformSetting.Entitlementchecksimulation)
			{
				if (Pvr_UnitySDKPlatformSetting.Instance.deviceSN.Count <= 0)
				{
					UnityEngine.Debug.Log("DISFT Entitlement Check Simulation deviceSN is Null");
					return Pvr_UnitySDKPlatformSetting.simulationType.Null;
				}
				foreach (string item in Pvr_UnitySDKPlatformSetting.Instance.deviceSN)
				{
					if (System.UPvr_GetDeviceSN() == item)
					{
						return Pvr_UnitySDKPlatformSetting.simulationType.Valid;
					}
				}
				UnityEngine.Debug.Log("DISFT Entitlement Check Simulation deviceSN is Invalid");
				return Pvr_UnitySDKPlatformSetting.simulationType.Invalid;
			}
			UnityEngine.Debug.Log("DISFT Entitlement Check Simulation DO NOT Enable");
			return Pvr_UnitySDKPlatformSetting.simulationType.Invalid;
		}

		public static bool UPvr_AppEntitlementCheck(string appid)
		{
			bool result = false;
			try
			{
				System.UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "verifyAPP", System.UPvr_GetCurrentActivity(), appid, "");
			}
			catch (Exception ex)
			{
				PLOG.E("Error :" + ex.ToString());
			}
			UnityEngine.Debug.Log("PvrLog UPvr_AppEntitlementCheck" + result);
			return result;
		}

		[Obsolete("This API will be removed in later versions")]
		public static bool UPvr_KeyEntitlementCheck(string publicKey)
		{
			bool result = false;
			try
			{
				System.UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "verifyAPP", System.UPvr_GetCurrentActivity(), "", publicKey);
			}
			catch (Exception ex)
			{
				PLOG.E("Error :" + ex.ToString());
			}
			UnityEngine.Debug.Log("PvrLog UPvr_KeyEntitlementCheck" + result);
			return result;
		}

		public static int UPvr_AppEntitlementCheckExtra(string appid)
		{
			int result = 100;
			try
			{
				System.UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "verifyAPPExt", System.UPvr_GetCurrentActivity(), appid, "");
			}
			catch (Exception ex)
			{
				PLOG.E("Error :" + ex.ToString());
			}
			UnityEngine.Debug.Log("PvrLog UPvr_AppEntitlementCheckExtra " + result);
			return result;
		}

		public static int UPvr_KeyEntitlementCheckExtra(string publicKey)
		{
			int result = -1;
			try
			{
				System.UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "verifyAPPExt", System.UPvr_GetCurrentActivity(), "", publicKey);
			}
			catch (Exception ex)
			{
				PLOG.E("Error :" + ex.ToString());
			}
			UnityEngine.Debug.Log("PvrLog UPvr_KeyEntitlementCheck" + result);
			return result;
		}

		public static int UPvr_GetHmdAudioStatus()
		{
			return System.PVR_GetHmdAudioStatus();
		}
	}
	public enum DeviceCommand
	{
		SET_PICO_NEO_HMD_BRIGHTNESS = 12,
		SET_PICO_NEO_HMD_SLEEPDELAY
	}
	public enum BrightnessLevel
	{
		VR_BRIGHTNESS_LEVEL_MIN = 1,
		VR_BRIGHTNESS_LEVEL_MAX = 100,
		VR_BRIGHTNESS_LEVEL_DOWN = 1000,
		VR_BRIGHTNESS_LEVEL_UP = 1001,
		VR_BRIGHTNESS_LEVEL_SCREEN_OFF = -100
	}
	public struct VolumePowerBrightness
	{
		public const string LibFileName = "Pvr_UnitySDK";

		public AndroidJavaObject activity;

		public static AndroidJavaClass javaSysActivityClass;

		private static AndroidJavaClass batteryjavaVrActivityClass;

		private static AndroidJavaClass volumejavaVrActivityClass;

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Pvr_SetInitActivity(IntPtr activity, IntPtr vrActivityClass);

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_IsHmdExist();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern int Pvr_GetHmdScreenBrightness();

		[DllImport("Pvr_UnitySDK", CallingConvention = CallingConvention.Cdecl)]
		private static extern bool Pvr_SetHmdScreenBrightness(int brightness);

		public static bool UPvr_IsHmdExist()
		{
			return Pvr_IsHmdExist();
		}

		public static int UPvr_GetHmdScreenBrightness()
		{
			return Pvr_GetHmdScreenBrightness();
		}

		public static bool UPvr_SetHmdScreenBrightness(int brightness)
		{
			return Pvr_SetHmdScreenBrightness(brightness);
		}

		public static bool UPvr_SetCommonBrightness(int brightness)
		{
			bool flag = false;
			if (UPvr_IsHmdExist())
			{
				return UPvr_SetHmdScreenBrightness(brightness);
			}
			return UPvr_SetBrightness(brightness);
		}

		public static int UPvr_GetCommonBrightness()
		{
			int num = 0;
			if (UPvr_IsHmdExist())
			{
				return UPvr_GetHmdScreenBrightness();
			}
			return UPvr_GetCurrentBrightness();
		}

		public static int[] UPvr_GetScreenBrightnessLevel()
		{
			return Pvr_GetScreenBrightnessLevel();
		}

		public static void UPvr_SetScreenBrightnessLevel(int vrBrightness, int level)
		{
			Pvr_SetScreenBrightnessLevel(vrBrightness, level);
		}

		public static bool UPvr_SetDevicePropForUser(DeviceCommand deviceid, string number)
		{
			return setDevicePropForUser(deviceid, number);
		}

		public static string UPvr_GetDevicePropForUser(DeviceCommand deviceid)
		{
			return getDevicePropForUser(deviceid);
		}

		public static bool UPvr_InitBatteryClass()
		{
			try
			{
				if (javaSysActivityClass == null)
				{
					javaSysActivityClass = new AndroidJavaClass("com.psmart.aosoperation.SysActivity");
				}
				if (javaSysActivityClass != null && Pvr_UnitySDKRender.Instance.activity != null)
				{
					if (batteryjavaVrActivityClass == null)
					{
						batteryjavaVrActivityClass = new AndroidJavaClass("com.psmart.aosoperation.BatteryReceiver");
					}
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				PLOG.E("startReceiver Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_InitBatteryVolClass()
		{
			try
			{
				javaSysActivityClass = new AndroidJavaClass("com.psmart.aosoperation.SysActivity");
				if (javaSysActivityClass != null && Pvr_UnitySDKRender.Instance.activity != null)
				{
					batteryjavaVrActivityClass = new AndroidJavaClass("com.psmart.aosoperation.BatteryReceiver");
					volumejavaVrActivityClass = new AndroidJavaClass("com.psmart.aosoperation.AudioReceiver");
					System.UPvr_CallStaticMethod(javaSysActivityClass, "Pvr_InitAudioDevice", Pvr_UnitySDKRender.Instance.activity);
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				PLOG.E("startReceiver Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_StartBatteryReceiver(string startreceivre)
		{
			try
			{
				System.UPvr_CallStaticMethod(batteryjavaVrActivityClass, "Pvr_StartReceiver", Pvr_UnitySDKRender.Instance.activity, startreceivre);
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E("startReceiver Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_StopBatteryReceiver()
		{
			try
			{
				System.UPvr_CallStaticMethod(batteryjavaVrActivityClass, "Pvr_StopReceiver", Pvr_UnitySDKRender.Instance.activity);
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E("startReceiver Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_SetBrightness(int brightness)
		{
			try
			{
				System.UPvr_CallStaticMethod(javaSysActivityClass, "Pvr_SetScreen_Brightness", brightness, Pvr_UnitySDKRender.Instance.activity);
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
				return false;
			}
		}

		public static int UPvr_GetCurrentBrightness()
		{
			int result = 0;
			try
			{
				System.UPvr_CallStaticMethod(ref result, javaSysActivityClass, "Pvr_GetScreen_Brightness", Pvr_UnitySDKRender.Instance.activity);
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
			}
			return result;
		}

		public static int[] Pvr_GetScreenBrightnessLevel()
		{
			int[] result = new int[1];
			try
			{
				System.UPvr_CallStaticMethod(ref result, javaSysActivityClass, "getScreenBrightnessLevel");
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
			}
			return result;
		}

		public static void Pvr_SetScreenBrightnessLevel(int vrBrightness, int level)
		{
			try
			{
				System.UPvr_CallStaticMethod(javaSysActivityClass, "setScreenBrightnessLevel", vrBrightness, level);
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
			}
		}

		public static bool UPvr_StartAudioReceiver(string startreceivre)
		{
			try
			{
				System.UPvr_CallStaticMethod(volumejavaVrActivityClass, "Pvr_StartReceiver", Pvr_UnitySDKRender.Instance.activity, startreceivre);
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E("startReceiver Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_StopAudioReceiver()
		{
			try
			{
				System.UPvr_CallStaticMethod(volumejavaVrActivityClass, "Pvr_StopReceiver", Pvr_UnitySDKRender.Instance.activity);
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E("startReceiver Error :" + ex.ToString());
				return false;
			}
		}

		public static int UPvr_GetMaxVolumeNumber()
		{
			int result = 0;
			try
			{
				System.UPvr_CallStaticMethod(ref result, javaSysActivityClass, "Pvr_GetMaxAudionumber");
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
			}
			return result;
		}

		public static int UPvr_GetCurrentVolumeNumber()
		{
			int result = 0;
			try
			{
				System.UPvr_CallStaticMethod(ref result, javaSysActivityClass, "Pvr_GetAudionumber");
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
			}
			return result;
		}

		public static bool UPvr_VolumeUp()
		{
			try
			{
				System.UPvr_CallStaticMethod(javaSysActivityClass, "Pvr_UpAudio");
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_VolumeDown()
		{
			try
			{
				System.UPvr_CallStaticMethod(javaSysActivityClass, "Pvr_DownAudio");
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_SetVolumeNum(int volume)
		{
			try
			{
				System.UPvr_CallStaticMethod(javaSysActivityClass, "Pvr_ChangeAudio", volume);
				return true;
			}
			catch (Exception ex)
			{
				PLOG.E(" Error :" + ex.ToString());
				return false;
			}
		}

		public static bool UPvr_SetAudio(string s)
		{
			return false;
		}

		public static bool UPvr_SetBattery(string s)
		{
			return false;
		}

		private static string getDevicePropForUser(DeviceCommand deviceid)
		{
			string result = "0";
			System.UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "getDevicePropForUser", (int)deviceid);
			return result;
		}

		private static bool setDevicePropForUser(DeviceCommand deviceid, string number)
		{
			bool result = false;
			System.UPvr_CallStaticMethod(ref result, Pvr_UnitySDKRender.javaVrActivityClass, "setDevicePropForUser", (int)deviceid, number);
			return result;
		}
	}
}
namespace Pvr_UnitySDKAPI.Achievement
{
	public sealed class AchievementCore
	{
		private static bool IsPlatformInitialized = true;

		public static bool LogMessages = false;

		public static bool IsInitialized()
		{
			return IsPlatformInitialized;
		}

		public static void Initialize()
		{
		}

		public static void RegisterNetwork()
		{
			Pvr_AchievementAPI.RegisterNetwork();
		}

		public static void UnRegisterNetwork()
		{
			Pvr_AchievementAPI.UnRegisterNetwork();
		}
	}
	public static class Achievements
	{
		public static Pvr_Request<Pvr_AchievementUpdate> Init()
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementUpdate>(Pvr_AchievementAPI.Init());
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementUpdate> AddCount(string name, long count)
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementUpdate>(Pvr_AchievementAPI.pvr_Achievements_AddCount(name, count));
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementUpdate> AddFields(string name, string fields)
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementUpdate>(Pvr_AchievementAPI.pvr_Achievements_AddFields(name, fields));
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementDefinitionList> GetAllDefinitions()
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementDefinitionList>(Pvr_AchievementAPI.pvr_Achievements_GetAllDefinitions());
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementProgressList> GetAllProgress()
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementProgressList>(Pvr_AchievementAPI.pvr_Achievements_GetAllProgress());
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementDefinitionList> GetDefinitionsByName(string[] names)
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementDefinitionList>(Pvr_AchievementAPI.pvr_Achievements_GetDefinitionsByName(names, (names != null) ? names.Length : 0));
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementProgressList> GetProgressByName(string[] names)
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementProgressList>(Pvr_AchievementAPI.pvr_Achievements_GetProgressByName(names, (names != null) ? names.Length : 0));
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementUpdate> Unlock(string name)
		{
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementUpdate>(Pvr_AchievementAPI.pvr_Achievements_Unlock(name));
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementDefinitionList> GetNextAchievementDefinitionListPage(Pvr_AchievementDefinitionList list)
		{
			if (!list.HasNextPage)
			{
				UnityEngine.Debug.LogWarning("Platform.GetNextAchievementDefinitionListPage: List has no next page");
				return null;
			}
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementDefinitionList>(Pvr_AchievementAPI.pvr_HTTP_GetWithMessageType(list.NextUrl, Pvr_Message.MessageType.Achievements_GetNextAchievementDefinitionArrayPage));
			}
			return null;
		}

		public static Pvr_Request<Pvr_AchievementProgressList> GetNextAchievementProgressListPage(Pvr_AchievementProgressList list)
		{
			if (!list.HasNextPage)
			{
				UnityEngine.Debug.LogWarning("Platform.GetNextAchievementProgressListPage: List has no next page");
				return null;
			}
			if (AchievementCore.IsInitialized())
			{
				return new Pvr_Request<Pvr_AchievementProgressList>(Pvr_AchievementAPI.pvr_HTTP_GetWithMessageType(list.NextUrl, Pvr_Message.MessageType.Achievements_GetNextAchievementProgressArrayPage));
			}
			return null;
		}
	}
	public enum AchievementType
	{
		[Description("UNKNOWN")]
		Unknown,
		[Description("SIMPLE")]
		Simple,
		[Description("BITFIELD")]
		Bitfield,
		[Description("COUNT")]
		Count
	}
	public class Pvr_AchievementAPI
	{
		private static AndroidJavaClass achievementAPI = new AndroidJavaClass("com.pico.achievement.AchievementAPI");

		private static AndroidJavaClass definitionArrayHandle = new AndroidJavaClass("com.picovr.achievement.utils.pvrAchievementDefinitionArrayHandle");

		private static AndroidJavaClass definitionHandle = new AndroidJavaClass("com.picovr.achievement.utils.pvrAchievementDefinitionHandle");

		private static AndroidJavaClass progressArrayHandle = new AndroidJavaClass("com.picovr.achievement.utils.pvrAchievementProgressArrayHandle");

		private static AndroidJavaClass progressHandle = new AndroidJavaClass("com.picovr.achievement.utils.pvrAchievementProgressHandle");

		private static AndroidJavaClass updateHandle = new AndroidJavaClass("com.picovr.achievement.utils.pvrAchievementUpdateHandle");

		private static AndroidJavaObject errorHandle = new AndroidJavaObject("com.picovr.achievement.utils.pvrAchievementErrorHandle");

		private static AndroidJavaObject unityInterface = new AndroidJavaObject("com.pico.loginpaysdk.UnityInterface");

		private static string openId;

		private static string accessToken;

		private static string appId = Pvr_UnitySDKPlatformSetting.Instance.appID;

		internal static long Init()
		{
			AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
			unityInterface.Call("init", @static);
			unityInterface.Call("authSSO");
			AndroidJavaObject androidJavaObject = new AndroidJavaClass("com.pico.loginpaysdk.utils.PicoAccessTokenKeeper").CallStatic<AndroidJavaObject>("readAccessToken", new object[1] { @static });
			accessToken = androidJavaObject.Call<string>("getAccessToken", Array.Empty<object>());
			openId = androidJavaObject.Call<string>("getOpenId", Array.Empty<object>());
			return achievementAPI.CallStatic<long>("init", new object[3] { accessToken, openId, @static });
		}

		internal static void RegisterNetwork()
		{
			AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
			achievementAPI.CallStatic("registerNetwork", @static);
		}

		internal static void UnRegisterNetwork()
		{
			achievementAPI.CallStatic("unregisterNetwork");
		}

		internal static AndroidJavaObject PopMessage()
		{
			return achievementAPI.CallStatic<AndroidJavaObject>("pvr_PopMessage", Array.Empty<object>());
		}

		internal static string pvr_Error_GetMessage(AndroidJavaObject popMessage)
		{
			return errorHandle.CallStatic<string>("pvr_Error_GetMessage", new object[1] { popMessage });
		}

		internal static int pvr_Error_GetHttpCode(AndroidJavaObject popMessage)
		{
			return errorHandle.CallStatic<int>("pvr_Error_GetHttpCode", new object[1] { popMessage });
		}

		internal static int pvr_Error_GetCode(AndroidJavaObject popMessage)
		{
			return errorHandle.CallStatic<int>("pvr_Error_GetCode", new object[1] { popMessage });
		}

		internal static long pvr_Achievements_AddCount(string name, long count)
		{
			return achievementAPI.CallStatic<long>("pvr_Achievements_AddCount", new object[3] { name, count, accessToken });
		}

		internal static long pvr_Achievements_AddFields(string name, string fields)
		{
			return achievementAPI.CallStatic<long>("pvr_Achievements_AddFields", new object[3] { name, fields, accessToken });
		}

		internal static long pvr_Achievements_GetAllDefinitions()
		{
			AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
			return achievementAPI.CallStatic<long>("pvr_Achievements_GetAllDefinitions", new object[2] { appId, @static });
		}

		internal static long pvr_Achievements_GetAllProgress()
		{
			return achievementAPI.CallStatic<long>("pvr_Achievements_GetAllProgress", new object[1] { accessToken });
		}

		internal static long pvr_Achievements_GetDefinitionsByName(string[] names, int v)
		{
			AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
			return achievementAPI.CallStatic<long>("pvr_Achievements_GetDefinitionsByName", new object[2] { names, @static });
		}

		internal static long pvr_Achievements_GetProgressByName(string[] names, int v)
		{
			return achievementAPI.CallStatic<long>("pvr_Achievements_GetProgressByName", new object[2] { names, accessToken });
		}

		internal static long pvr_Achievements_Unlock(string name)
		{
			return achievementAPI.CallStatic<long>("pvr_Achievements_Unlock", new object[2] { name, accessToken });
		}

		internal static long pvr_HTTP_GetWithMessageType(string nextUrl, Pvr_Message.MessageType messageType)
		{
			long result = 0L;
			switch (messageType)
			{
			case Pvr_Message.MessageType.Achievements_GetNextAchievementDefinitionArrayPage:
			{
				AndroidJavaObject @static = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
				result = achievementAPI.CallStatic<long>("pvr_Achievements_GetAllDefinitionsByUrl", new object[2] { nextUrl, @static });
				break;
			}
			case Pvr_Message.MessageType.Achievements_GetNextAchievementProgressArrayPage:
				result = achievementAPI.CallStatic<long>("pvr_Achievements_GetAllProgressByUrl", new object[1] { nextUrl });
				break;
			}
			return result;
		}

		internal static long pvr_Message_GetType(AndroidJavaObject popMessage)
		{
			return popMessage.Call<AndroidJavaObject>("getHandleType", Array.Empty<object>()).Call<long>("getIndex", Array.Empty<object>());
		}

		internal static bool pvr_Message_IsError(AndroidJavaObject popMessage)
		{
			return popMessage.Call<bool>("isMessage_IsError", Array.Empty<object>());
		}

		internal static long pvr_Message_GetRequestID(AndroidJavaObject popMessage)
		{
			return popMessage.Call<long>("getId", Array.Empty<object>());
		}

		internal static string pvr_Message_GetString(AndroidJavaObject popMessage)
		{
			return popMessage.Call<string>("getContent", Array.Empty<object>());
		}

		internal static bool pvr_AchievementUpdate_GetJustUnlocked(AndroidJavaObject popMessage)
		{
			return updateHandle.CallStatic<bool>("pvr_AchievementUpdate_GetJustUnlocked", new object[1] { popMessage });
		}

		internal static string pvr_AchievementUpdate_GetName(AndroidJavaObject popMessage)
		{
			return updateHandle.CallStatic<string>("pvr_AchievementUpdate_GetName", new object[1] { popMessage });
		}

		internal static int pvr_AchievementProgressArray_GetSize(AndroidJavaObject msg)
		{
			return progressArrayHandle.CallStatic<int>("pvr_AchievementProgressArray_GetSize", new object[1] { msg });
		}

		internal static AndroidJavaObject pvr_AchievementProgressArray_GetElement(AndroidJavaObject msg, int index)
		{
			return progressArrayHandle.CallStatic<AndroidJavaObject>("pvr_AchievementProgressArray_GetElement", new object[2] { msg, index });
		}

		internal static string pvr_AchievementProgressArray_GetNextUrl(AndroidJavaObject msg)
		{
			return progressArrayHandle.CallStatic<string>("pvr_AchievementProgressArray_GetNextUrl", new object[1] { msg });
		}

		internal static string pvr_AchievementProgress_GetBitfield(AndroidJavaObject msg)
		{
			return progressHandle.CallStatic<string>("pvr_AchievementProgress_GetBitfield", new object[1] { msg });
		}

		internal static long pvr_AchievementProgress_GetCount(AndroidJavaObject msg)
		{
			return progressHandle.CallStatic<long>("pvr_AchievementProgress_GetCount", new object[1] { msg });
		}

		internal static bool pvr_AchievementProgress_GetIsUnlocked(AndroidJavaObject msg)
		{
			return progressHandle.CallStatic<bool>("pvr_AchievementProgress_GetIsUnlocked", new object[1] { msg });
		}

		internal static string pvr_AchievementProgress_GetName(AndroidJavaObject msg)
		{
			return progressHandle.CallStatic<string>("pvr_AchievementProgress_GetName", new object[1] { msg });
		}

		internal static DateTime pvr_AchievementProgress_GetUnlockTime(AndroidJavaObject msg)
		{
			new DateTime(1970, 1, 1, 0, 0, 0, 0);
			return DateTimeFromNative(progressHandle.CallStatic<long>("pvr_AchievementProgress_GetUnlockTime", new object[1] { msg }));
		}

		internal static DateTime DateTimeFromNative(long seconds_since_the_one_true_epoch)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(seconds_since_the_one_true_epoch).ToLocalTime();
		}

		internal static int pvr_AchievementDefinitionArray_GetSize(AndroidJavaObject msg)
		{
			return definitionArrayHandle.CallStatic<int>("pvr_AchievementDefinitionArray_GetSize", new object[1] { msg });
		}

		internal static AndroidJavaObject pvr_AchievementDefinitionArray_GetElement(AndroidJavaObject msg, int index)
		{
			return definitionArrayHandle.CallStatic<AndroidJavaObject>("pvr_AchievementDefinitionArray_GetElement", new object[2] { msg, index });
		}

		internal static string pvr_AchievementDefinitionArray_GetNextUrl(AndroidJavaObject msg)
		{
			return definitionArrayHandle.CallStatic<string>("pvr_AchievementDefinitionArray_GetNextUrl", new object[1] { msg });
		}

		internal static AchievementType pvr_AchievementDefinition_GetType(AndroidJavaObject msg)
		{
			return (AchievementType)definitionHandle.CallStatic<AndroidJavaObject>("pvr_AchievementDefinition_GetType", new object[1] { msg }).Call<int>("getIndex", Array.Empty<object>());
		}

		internal static string pvr_AchievementDefinition_GetName(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<string>("pvr_AchievementDefinition_GetName", new object[1] { msg });
		}

		internal static int pvr_AchievementDefinition_GetBitfieldLength(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<int>("pvr_AchievementDefinition_GetBitfieldLength", new object[1] { msg });
		}

		internal static long pvr_AchievementDefinition_GetTarget(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<long>("pvr_AchievementDefinition_GetTarget", new object[1] { msg });
		}

		internal static string pvr_AchievementDefinition_GetTitle(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<string>("pvr_AchievementDefinition_GetTitle", new object[1] { msg });
		}

		internal static string pvr_AchievementDefinition_GetUnlockedDescription(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<string>("pvr_AchievementDefinition_GetUnlocked_description", new object[1] { msg });
		}

		internal static string pvr_AchievementDefinition_GetLockedIcon(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<string>("pvr_AchievementDefinition_GetLocked_image", new object[1] { msg });
		}

		internal static bool pvr_AchievementDefinition_GetIsSecrect(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<bool>("pvr_AchievementDefinition_GetIs_secret", new object[1] { msg });
		}

		internal static string pvr_AchievementDefinition_GetUnlockedIcon(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<string>("pvr_AchievementDefinition_GetUnlocked_image", new object[1] { msg });
		}

		internal static string pvr_AchievementDefinition_GetDescription(AndroidJavaObject msg)
		{
			return definitionHandle.CallStatic<string>("pvr_AchievementDefinition_GetDescription", new object[1] { msg });
		}
	}
	public class Pvr_AchievementDefinition
	{
		public readonly AchievementType Type;

		public readonly string Name;

		public readonly int BitfieldLength;

		public readonly long Target;

		public readonly string Title;

		public readonly string Description;

		public readonly string UnlockedDescription;

		public readonly string UnlockedIcon;

		public readonly string LockedIcon;

		public readonly bool IsSecrect;

		public Pvr_AchievementDefinition(AndroidJavaObject msg)
		{
			Type = Pvr_AchievementAPI.pvr_AchievementDefinition_GetType(msg);
			Name = Pvr_AchievementAPI.pvr_AchievementDefinition_GetName(msg);
			BitfieldLength = Pvr_AchievementAPI.pvr_AchievementDefinition_GetBitfieldLength(msg);
			Target = Pvr_AchievementAPI.pvr_AchievementDefinition_GetTarget(msg);
			Title = Pvr_AchievementAPI.pvr_AchievementDefinition_GetTitle(msg);
			Description = Pvr_AchievementAPI.pvr_AchievementDefinition_GetDescription(msg);
			UnlockedDescription = Pvr_AchievementAPI.pvr_AchievementDefinition_GetUnlockedDescription(msg);
			UnlockedIcon = Pvr_AchievementAPI.pvr_AchievementDefinition_GetUnlockedIcon(msg);
			LockedIcon = Pvr_AchievementAPI.pvr_AchievementDefinition_GetLockedIcon(msg);
			IsSecrect = Pvr_AchievementAPI.pvr_AchievementDefinition_GetIsSecrect(msg);
		}
	}
	public class Pvr_AchievementDefinitionList : Pvr_DeserializableList<Pvr_AchievementDefinition>
	{
		public Pvr_AchievementDefinitionList(AndroidJavaObject msg)
		{
			int num = Pvr_AchievementAPI.pvr_AchievementDefinitionArray_GetSize(msg);
			data = new List<Pvr_AchievementDefinition>(num);
			for (int i = 0; i < num; i++)
			{
				data.Add(new Pvr_AchievementDefinition(Pvr_AchievementAPI.pvr_AchievementDefinitionArray_GetElement(msg, i)));
			}
			nextUrl = Pvr_AchievementAPI.pvr_AchievementDefinitionArray_GetNextUrl(msg);
		}
	}
	public class Pvr_AchievementProgress
	{
		public readonly string Bitfield;

		public readonly long Count;

		public readonly bool IsUnlocked;

		public readonly string Name;

		public readonly DateTime UnlockTime;

		public Pvr_AchievementProgress(AndroidJavaObject msg)
		{
			Bitfield = Pvr_AchievementAPI.pvr_AchievementProgress_GetBitfield(msg);
			Count = Pvr_AchievementAPI.pvr_AchievementProgress_GetCount(msg);
			IsUnlocked = Pvr_AchievementAPI.pvr_AchievementProgress_GetIsUnlocked(msg);
			Name = Pvr_AchievementAPI.pvr_AchievementProgress_GetName(msg);
			UnlockTime = Pvr_AchievementAPI.pvr_AchievementProgress_GetUnlockTime(msg);
		}
	}
	public class Pvr_AchievementProgressList : Pvr_DeserializableList<Pvr_AchievementProgress>
	{
		public Pvr_AchievementProgressList(AndroidJavaObject msg)
		{
			int num = Pvr_AchievementAPI.pvr_AchievementProgressArray_GetSize(msg);
			data = new List<Pvr_AchievementProgress>(num);
			for (int i = 0; i < num; i++)
			{
				data.Add(new Pvr_AchievementProgress(Pvr_AchievementAPI.pvr_AchievementProgressArray_GetElement(msg, i)));
			}
			nextUrl = Pvr_AchievementAPI.pvr_AchievementProgressArray_GetNextUrl(msg);
		}
	}
	public class Pvr_AchievementUpdate
	{
		public readonly bool JustUnlocked;

		public readonly string Name;

		public Pvr_AchievementUpdate(AndroidJavaObject msg)
		{
			JustUnlocked = Pvr_AchievementAPI.pvr_AchievementUpdate_GetJustUnlocked(msg);
			Name = Pvr_AchievementAPI.pvr_AchievementUpdate_GetName(msg);
		}
	}
	public class Pvr_DeserializableList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		protected List<T> data;

		protected string nextUrl;

		protected string previousUrl;

		public int Count => data.Count;

		bool ICollection<T>.IsReadOnly => ((ICollection<T>)data).IsReadOnly;

		public T this[int index]
		{
			get
			{
				return data[index];
			}
			set
			{
				data[index] = value;
			}
		}

		public bool HasNextPage => !string.IsNullOrEmpty(NextUrl);

		public bool HasPreviousPage => !string.IsNullOrEmpty(PreviousUrl);

		public string NextUrl => nextUrl;

		public string PreviousUrl => previousUrl;

		public int IndexOf(T obj)
		{
			return data.IndexOf(obj);
		}

		public void Add(T item)
		{
			data.Add(item);
		}

		public void Clear()
		{
			data.Clear();
		}

		public bool Contains(T item)
		{
			return data.Contains(item);
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			data.CopyTo(array, arrayIndex);
		}

		public IEnumerator<T> GetEnumerator()
		{
			return data.GetEnumerator();
		}

		public void Insert(int index, T item)
		{
			data.Insert(index, item);
		}

		public bool Remove(T item)
		{
			return data.Remove(item);
		}

		public void RemoveAt(int index)
		{
			data.RemoveAt(index);
		}

		private IEnumerator GetEnumerator1()
		{
			return GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator1();
		}
	}
	public static class Pvr_Callback
	{
		private class RequestCallback
		{
			private Pvr_Message.Callback messageCallback;

			public RequestCallback()
			{
			}

			public RequestCallback(Pvr_Message.Callback callback)
			{
				messageCallback = callback;
			}

			public virtual void HandleMessage(Pvr_Message msg)
			{
				if (messageCallback != null)
				{
					messageCallback(msg);
				}
			}
		}

		private sealed class RequestCallback<T> : RequestCallback
		{
			private Pvr_Message<T>.Callback callback;

			public RequestCallback(Pvr_Message<T>.Callback callback)
			{
				this.callback = callback;
			}

			public override void HandleMessage(Pvr_Message msg)
			{
				if (callback != null)
				{
					if (msg is Pvr_Message<T>)
					{
						callback((Pvr_Message<T>)msg);
					}
					else
					{
						UnityEngine.Debug.LogError("Unable to handle message: " + msg.GetType());
					}
				}
			}
		}

		private static Dictionary<long, Request> requestIDsToRequests = new Dictionary<long, Request>();

		private static Dictionary<Pvr_Message.MessageType, RequestCallback> notificationCallbacks = new Dictionary<Pvr_Message.MessageType, RequestCallback>();

		internal static void AddRequest(Request request)
		{
			if (request.RequestID <= 2)
			{
				long requestID = request.RequestID;
				if ((ulong)requestID <= 2uL)
				{
					switch (requestID)
					{
					case 0L:
						UnityEngine.Debug.LogError("An PARAM_INVALIDE error occurred. Request failed.");
						return;
					case 1L:
						UnityEngine.Debug.LogError("An NETWORK_INVALIDE error occurred. Request failed.");
						return;
					case 2L:
						UnityEngine.Debug.LogError("An NOT_INTIALIZE error occurred. Request failed.");
						return;
					}
				}
				UnityEngine.Debug.LogError("An unknown error occurred. Request failed.");
			}
			else
			{
				requestIDsToRequests[request.RequestID] = request;
			}
		}

		internal static void RunCallbacks()
		{
			while (true)
			{
				Pvr_Message pvr_Message = Pvr_Message.PopMessage();
				if (pvr_Message != null)
				{
					HandleMessage(pvr_Message);
					continue;
				}
				break;
			}
		}

		internal static void RunLimitedCallbacks(uint limit)
		{
			for (int i = 0; i < limit; i++)
			{
				Pvr_Message pvr_Message = Pvr_Message.PopMessage();
				if (pvr_Message != null)
				{
					HandleMessage(pvr_Message);
					continue;
				}
				break;
			}
		}

		internal static void OnApplicationQuit()
		{
			requestIDsToRequests.Clear();
			notificationCallbacks.Clear();
		}

		internal static void HandleMessage(Pvr_Message msg)
		{
			if (msg.RequestID != 0L && requestIDsToRequests.TryGetValue(msg.RequestID, out var value))
			{
				try
				{
					value.HandleMessage(msg);
					return;
				}
				finally
				{
					requestIDsToRequests.Remove(msg.RequestID);
				}
			}
			if (notificationCallbacks.TryGetValue(msg.Type, out var value2))
			{
				value2.HandleMessage(msg);
			}
		}
	}
	public class Pvr_CallbackRunner : MonoBehaviour
	{
		public bool IsPersistantBetweenSceneLoads = true;

		private void Awake()
		{
			if (UnityEngine.Object.FindObjectOfType<Pvr_CallbackRunner>() != this)
			{
				UnityEngine.Debug.LogWarning("You only need one instance of CallbackRunner");
			}
			if (IsPersistantBetweenSceneLoads)
			{
				UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			}
		}

		private void Update()
		{
			Request.RunCallbacks();
		}

		private void OnApplicationQuit()
		{
			Pvr_Callback.OnApplicationQuit();
		}
	}
	public abstract class Pvr_Message<T> : Pvr_Message
	{
		public new delegate void Callback(Pvr_Message<T> message);

		private T data;

		public T Data => data;

		public Pvr_Message(AndroidJavaObject msg)
			: base(msg)
		{
			if (!base.IsError)
			{
				data = GetDataFromMessage(msg);
			}
		}

		protected abstract T GetDataFromMessage(AndroidJavaObject msg);
	}
	public class Pvr_Message
	{
		public delegate void Callback(Pvr_Message message);

		public enum MessageType : uint
		{
			Unknown = 0u,
			Achievements_AddCount = 65495601u,
			Achievements_AddFields = 346693929u,
			Achievements_GetAllDefinitions = 64177549u,
			Achievements_GetAllProgress = 1335877149u,
			Achievements_GetDefinitionsByName = 1653670332u,
			Achievements_GetNextAchievementDefinitionArrayPage = 712888917u,
			Achievements_GetNextAchievementProgressArrayPage = 792913703u,
			Achievements_GetProgressByName = 354837425u,
			Achievements_Unlock = 1497156573u,
			Achievements_WriteAchievementProgress = 121027549u,
			Achievements_VerifyAccessToken = 53284924u
		}

		internal delegate Pvr_Message ExtraMessageTypesHandler(AndroidJavaObject messageHandle, MessageType message_type);

		private MessageType type;

		private long requestID;

		private Error error;

		public MessageType Type => type;

		public bool IsError => error != null;

		public long RequestID => requestID;

		internal static ExtraMessageTypesHandler HandleExtraMessageTypes { private get; set; }

		public Pvr_Message(AndroidJavaObject msg)
		{
			type = (MessageType)Pvr_AchievementAPI.pvr_Message_GetType(msg);
			bool num = Pvr_AchievementAPI.pvr_Message_IsError(msg);
			requestID = Pvr_AchievementAPI.pvr_Message_GetRequestID(msg);
			if (num)
			{
				error = new Error(Pvr_AchievementAPI.pvr_Error_GetCode(msg), Pvr_AchievementAPI.pvr_Error_GetMessage(msg), Pvr_AchievementAPI.pvr_Error_GetHttpCode(msg));
			}
			else if (AchievementCore.LogMessages)
			{
				string text = Pvr_AchievementAPI.pvr_Message_GetString(msg);
				if (text != null)
				{
					UnityEngine.Debug.Log(text);
				}
				else
				{
					UnityEngine.Debug.Log($"null message string {msg}");
				}
			}
		}

		public virtual Error GetError()
		{
			return error;
		}

		public virtual Pvr_AchievementDefinitionList GetAchievementDefinitions()
		{
			return null;
		}

		public virtual Pvr_AchievementProgressList GetAchievementProgressList()
		{
			return null;
		}

		public virtual Pvr_AchievementUpdate GetAchievementUpdate()
		{
			return null;
		}

		public virtual string GetString()
		{
			return null;
		}

		internal static Pvr_Message ParseMessageHandle(AndroidJavaObject messageHandle)
		{
			if (messageHandle == null)
			{
				return null;
			}
			Pvr_Message result = null;
			switch ((MessageType)Pvr_AchievementAPI.pvr_Message_GetType(messageHandle))
			{
			case MessageType.Achievements_GetAllDefinitions:
			case MessageType.Achievements_GetNextAchievementDefinitionArrayPage:
			case MessageType.Achievements_GetDefinitionsByName:
				result = new MessageWithAchievementDefinitions(messageHandle);
				break;
			case MessageType.Achievements_GetProgressByName:
			case MessageType.Achievements_GetNextAchievementProgressArrayPage:
			case MessageType.Achievements_GetAllProgress:
				result = new MessageWithAchievementProgressList(messageHandle);
				break;
			case MessageType.Achievements_VerifyAccessToken:
			case MessageType.Achievements_AddCount:
			case MessageType.Achievements_AddFields:
			case MessageType.Achievements_Unlock:
				result = new MessageWithAchievementUpdate(messageHandle);
				break;
			}
			return result;
		}

		public static Pvr_Message PopMessage()
		{
			return ParseMessageHandle(Pvr_AchievementAPI.PopMessage());
		}
	}
	public class MessageWithAchievementDefinitions : Pvr_Message<Pvr_AchievementDefinitionList>
	{
		public MessageWithAchievementDefinitions(AndroidJavaObject msg)
			: base(msg)
		{
		}

		public override Pvr_AchievementDefinitionList GetAchievementDefinitions()
		{
			return base.Data;
		}

		protected override Pvr_AchievementDefinitionList GetDataFromMessage(AndroidJavaObject msg)
		{
			return new Pvr_AchievementDefinitionList(msg);
		}
	}
	public class MessageWithAchievementProgressList : Pvr_Message<Pvr_AchievementProgressList>
	{
		public MessageWithAchievementProgressList(AndroidJavaObject msg)
			: base(msg)
		{
		}

		public override Pvr_AchievementProgressList GetAchievementProgressList()
		{
			return base.Data;
		}

		protected override Pvr_AchievementProgressList GetDataFromMessage(AndroidJavaObject msg)
		{
			return new Pvr_AchievementProgressList(msg);
		}
	}
	public class MessageWithAchievementUpdate : Pvr_Message<Pvr_AchievementUpdate>
	{
		public MessageWithAchievementUpdate(AndroidJavaObject msg)
			: base(msg)
		{
		}

		public override Pvr_AchievementUpdate GetAchievementUpdate()
		{
			return base.Data;
		}

		protected override Pvr_AchievementUpdate GetDataFromMessage(AndroidJavaObject msg)
		{
			return new Pvr_AchievementUpdate(msg);
		}
	}
	public class MessageWithString : Pvr_Message<string>
	{
		public MessageWithString(AndroidJavaObject msg)
			: base(msg)
		{
		}

		public override string GetString()
		{
			return base.Data;
		}

		protected override string GetDataFromMessage(AndroidJavaObject msg)
		{
			return Pvr_AchievementAPI.pvr_Message_GetString(msg);
		}
	}
	public class Error
	{
		public readonly int Code;

		public readonly int HttpCode;

		public readonly string Message;

		public Error(int code, string message, int httpCode)
		{
			Message = message;
			Code = code;
			HttpCode = httpCode;
		}
	}
	public sealed class Pvr_Request<T> : Request
	{
		private Pvr_Message<T>.Callback callback_;

		public Pvr_Request(long requestID)
			: base(requestID)
		{
		}

		public Pvr_Request<T> OnComplete(Pvr_Message<T>.Callback callback)
		{
			if (callback_ != null)
			{
				throw new UnityException("Attempted to attach multiple handlers to a Request.  This is not allowed.");
			}
			callback_ = callback;
			Pvr_Callback.AddRequest(this);
			return this;
		}

		public override void HandleMessage(Pvr_Message msg)
		{
			if (!(msg is Pvr_Message<T>))
			{
				UnityEngine.Debug.LogError("Unable to handle message: " + msg.GetType());
				return;
			}
			if (callback_ != null)
			{
				callback_((Pvr_Message<T>)msg);
				return;
			}
			throw new UnityException("Request with no handler.  This should never happen.");
		}
	}
	public class Request
	{
		private Pvr_Message.Callback callback_;

		public long RequestID { get; set; }

		public Request(long requestID)
		{
			RequestID = requestID;
		}

		public Request OnComplete(Pvr_Message.Callback callback)
		{
			callback_ = callback;
			Pvr_Callback.AddRequest(this);
			return this;
		}

		public virtual void HandleMessage(Pvr_Message msg)
		{
			if (callback_ != null)
			{
				callback_(msg);
				return;
			}
			throw new UnityException("Request with no handler.  This should never happen.");
		}

		public static void RunCallbacks(uint limit = 0u)
		{
			if (limit == 0)
			{
				Pvr_Callback.RunCallbacks();
			}
			else
			{
				Pvr_Callback.RunLimitedCallbacks(limit);
			}
		}
	}
}
namespace PolyPerfect
{
	public class Common_AnimSpeed : MonoBehaviour
	{
		private Animator anim;

		private float Speed;

		private void Start()
		{
			Speed = UnityEngine.Random.Range(0.85f, 1.25f);
			anim = GetComponent<Animator>();
		}

		private void Update()
		{
			anim.speed = Speed;
		}
	}
	public class Common_AnimationControl : MonoBehaviour
	{
		private string currentAnimation = "";

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void SetAnimation(string animationName)
		{
			if (currentAnimation != "")
			{
				GetComponent<Animator>().SetBool(currentAnimation, value: false);
			}
			GetComponent<Animator>().SetBool(animationName, value: true);
			currentAnimation = animationName;
		}

		public void SetAnimationIdle()
		{
			if (currentAnimation != "")
			{
				GetComponent<Animator>().SetBool(currentAnimation, value: false);
			}
		}

		public void SetDeathAnimation(int numOfClips)
		{
			int num = UnityEngine.Random.Range(0, numOfClips);
			string text = "Death";
			UnityEngine.Debug.Log(num);
			GetComponent<Animator>().SetInteger(text, num);
		}
	}
	public class Common_KillSwitch : MonoBehaviour
	{
		private Animator anim;

		private void Start()
		{
			anim = GetComponent<Animator>();
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				anim.SetBool("isDead", value: true);
			}
		}
	}
	public class Common_PlaySound : MonoBehaviour
	{
		[SerializeField]
		private AudioClip animalSound;

		[SerializeField]
		private AudioClip walking;

		[SerializeField]
		private AudioClip eating;

		[SerializeField]
		private AudioClip running;

		[SerializeField]
		private AudioClip attacking;

		[SerializeField]
		private AudioClip death;

		[SerializeField]
		private AudioClip sleeping;

		private void AnimalSound()
		{
			if ((bool)animalSound)
			{
				Common_AudioManager.PlaySound(animalSound, base.transform.position);
			}
		}

		private void Walking()
		{
			if ((bool)walking)
			{
				Common_AudioManager.PlaySound(walking, base.transform.position);
			}
		}

		private void Eating()
		{
			if ((bool)eating)
			{
				Common_AudioManager.PlaySound(eating, base.transform.position);
			}
		}

		private void Running()
		{
			if ((bool)running)
			{
				Common_AudioManager.PlaySound(running, base.transform.position);
			}
		}

		private void Attacking()
		{
			if ((bool)attacking)
			{
				Common_AudioManager.PlaySound(attacking, base.transform.position);
			}
		}

		private void Death()
		{
			if ((bool)death)
			{
				Common_AudioManager.PlaySound(death, base.transform.position);
			}
		}

		private void Sleeping()
		{
			if ((bool)sleeping)
			{
				Common_AudioManager.PlaySound(sleeping, base.transform.position);
			}
		}
	}
	[ExecuteInEditMode]
	public class RandomCharacterPlacer : MonoBehaviour
	{
		[SerializeField]
		private float spawnSize;

		[SerializeField]
		private int spawnAmmount;

		[SerializeField]
		private GameObject[] characters;

		[ContextMenu("Spawn Characters")]
		private void SpawnAnimals()
		{
			GameObject gameObject = new GameObject("SpawnedCharacters");
			for (int i = 0; i < spawnAmmount; i++)
			{
				int num = UnityEngine.Random.Range(0, characters.Length);
				UnityEngine.Object.Instantiate(characters[num], RandomNavmeshLocation(spawnSize), Quaternion.identity, gameObject.transform);
			}
		}

		public Vector3 RandomNavmeshLocation(float radius)
		{
			Vector3 sourcePosition = UnityEngine.Random.insideUnitSphere * radius + base.transform.position;
			Vector3 result = Vector3.zero;
			if (NavMesh.SamplePosition(sourcePosition, out var hit, radius, 1))
			{
				result = hit.position;
			}
			return result;
		}

		private void OnDrawGizmosSelected()
		{
			Gizmos.DrawWireSphere(base.transform.position, spawnSize);
		}
	}
	[Serializable]
	public class AIState
	{
		public string stateName = "New State";

		public string animationBool = string.Empty;
	}
	[CreateAssetMenu(fileName = "New Wander Stats", menuName = "PolyPerfect/New Wander Stats", order = 1)]
	public class AIStats : ScriptableObject
	{
		[SerializeField]
		[Tooltip("How dominent this is in the food chain, more agressive will attack less dominant.")]
		public int dominance = 1;

		[SerializeField]
		[Tooltip("How many seconds this can run for before it gets tired.")]
		public float stamina = 10f;

		[SerializeField]
		[Tooltip("How much this damage this does to another.")]
		public float power = 10f;

		[SerializeField]
		[Tooltip("How much health this has.")]
		public float toughness = 5f;

		[SerializeField]
		[Tooltip("Chance of this attacking another.")]
		[Range(0f, 100f)]
		public float agression;

		[SerializeField]
		[Tooltip("How quickly this does damage to another (every 'attackSpeed' seconds will cause 'power' amount of damage).")]
		public float attackSpeed = 0.5f;

		[SerializeField]
		[Tooltip("If true, this will attack other of the same specices.")]
		public bool territorial;

		[SerializeField]
		[Tooltip("Stealthy can't be detected by others.")]
		public bool stealthy;
	}
	public class Common_AudioManager : MonoBehaviour
	{
		private static Common_AudioManager instance;

		[SerializeField]
		private bool muteSound;

		[SerializeField]
		private int objectPoolLength = 20;

		[SerializeField]
		private float soundDistance = 7f;

		[SerializeField]
		private bool logSounds;

		private List<AudioSource> pool = new List<AudioSource>();

		private void Awake()
		{
			instance = this;
			for (int i = 0; i < objectPoolLength; i++)
			{
				GameObject obj = new GameObject();
				obj.transform.SetParent(instance.transform);
				obj.name = "Sound Effect";
				AudioSource audioSource = obj.AddComponent<AudioSource>();
				audioSource.spatialBlend = 1f;
				audioSource.minDistance = instance.soundDistance;
				audioSource.gameObject.SetActive(value: false);
				pool.Add(audioSource);
			}
		}

		public static void PlaySound(AudioClip clip, Vector3 pos)
		{
			if (!instance)
			{
				UnityEngine.Debug.LogError("No Audio Manager found in the scene.");
			}
			else
			{
				if (instance.muteSound)
				{
					return;
				}
				if (!clip)
				{
					UnityEngine.Debug.LogError("Clip is null");
					return;
				}
				if (instance.logSounds)
				{
					UnityEngine.Debug.Log("Playing Audio: " + clip.name);
				}
				for (int i = 0; i < instance.pool.Count; i++)
				{
					if (!instance.pool[i].gameObject.activeInHierarchy)
					{
						instance.pool[i].clip = clip;
						instance.pool[i].transform.position = pos;
						instance.pool[i].gameObject.SetActive(value: true);
						instance.pool[i].Play();
						instance.StartCoroutine(instance.ReturnToPool(instance.pool[i].gameObject, clip.length));
						return;
					}
				}
				GameObject gameObject = new GameObject();
				gameObject.transform.SetParent(instance.transform);
				gameObject.name = "Sound Effect";
				AudioSource audioSource = gameObject.AddComponent<AudioSource>();
				audioSource.spatialBlend = 1f;
				audioSource.minDistance = instance.soundDistance;
				instance.pool.Add(audioSource);
				audioSource.clip = clip;
				gameObject.transform.position = pos;
				audioSource.Play();
				instance.StartCoroutine(instance.ReturnToPool(gameObject, clip.length));
			}
		}

		private IEnumerator ReturnToPool(GameObject obj, float delay)
		{
			yield return new WaitForSeconds(delay);
			obj.SetActive(value: false);
		}
	}
	public class Common_SurfaceRotation : MonoBehaviour
	{
		private string terrainLayer = "Terrain";

		private int layer;

		private bool rotate = true;

		private Quaternion targetRotation;

		private float rotationSpeed = 2f;

		private void Awake()
		{
			layer = LayerMask.GetMask(terrainLayer);
		}

		private void Start()
		{
			Vector3 direction = base.transform.parent.TransformDirection(Vector3.down);
			if (Physics.Raycast(base.transform.parent.position, direction, out var hitInfo, 50f, layer))
			{
				_ = hitInfo.distance;
				Quaternion quaternion = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
				base.transform.rotation = quaternion * base.transform.parent.rotation;
			}
		}

		private void Update()
		{
			if (rotate)
			{
				Vector3 direction = base.transform.parent.TransformDirection(Vector3.down);
				if (Physics.Raycast(base.transform.parent.position, direction, out var hitInfo, 50f, layer))
				{
					_ = hitInfo.distance;
					Quaternion quaternion = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
					targetRotation = quaternion * base.transform.parent.rotation;
				}
				base.transform.rotation = Quaternion.Lerp(base.transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
			}
		}

		public void SetRotationSpeed(float speed)
		{
			if (speed > 0f)
			{
				rotationSpeed = speed;
			}
		}

		private void OnBecameVisible()
		{
			rotate = true;
		}

		private void OnBecameInvisible()
		{
			rotate = false;
		}
	}
	public class Common_WanderManager : MonoBehaviour
	{
		[SerializeField]
		private bool peaceTime;

		private static Common_WanderManager instance;

		public bool PeaceTime
		{
			get
			{
				return peaceTime;
			}
			set
			{
				SwitchPeaceTime(value);
			}
		}

		public static Common_WanderManager Instance => instance;

		private void Awake()
		{
			if (instance != null && instance != this)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			else
			{
				instance = this;
			}
		}

		private void Start()
		{
			if (peaceTime)
			{
				UnityEngine.Debug.Log("AnimalManager: Peacetime is enabled, all animals are non-agressive.");
				SwitchPeaceTime(enabled: true);
			}
		}

		public void SwitchPeaceTime(bool enabled)
		{
			if (enabled == peaceTime)
			{
				return;
			}
			peaceTime = enabled;
			UnityEngine.Debug.Log(string.Format("AnimalManager: Peace time is now {0}.", enabled ? "On" : "Off"));
			foreach (Common_WanderScript allAnimal in Common_WanderScript.AllAnimals)
			{
				allAnimal.SetPeaceTime(enabled);
			}
		}

		public void Nuke()
		{
			foreach (Common_WanderScript allAnimal in Common_WanderScript.AllAnimals)
			{
				allAnimal.Die();
			}
		}
	}
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(CharacterController))]
	public class Common_WanderScript : MonoBehaviour
	{
		private const float contingencyDistance = 1f;

		[SerializeField]
		public IdleState[] idleStates;

		[SerializeField]
		private MovementState[] movementStates;

		[SerializeField]
		private AIState[] attackingStates;

		[SerializeField]
		private AIState[] deathStates;

		[SerializeField]
		public string species = "NA";

		[SerializeField]
		[Tooltip("This specific animal stats asset, create a new one from the asset menu under (LowPolyAnimals/NewAnimalStats)")]
		public AIStats stats;

		[SerializeField]
		[Tooltip("How far away from it's origin this animal will wander by itself.")]
		private float wanderZone = 10f;

		private int dominance = 1;

		private int originalDominance;

		[SerializeField]
		[Tooltip("How far this animal can sense a predator.")]
		private float awareness = 30f;

		[SerializeField]
		[Tooltip("How far this animal can sense it's prey.")]
		private float scent = 30f;

		private float originalScent;

		private float stamina = 10f;

		private float power = 10f;

		private float toughness = 5f;

		private float agression;

		private float originalAgression;

		private float attackSpeed = 0.5f;

		private bool territorial;

		private bool stealthy;

		[SerializeField]
		[Tooltip("If true, this animal will never leave it's zone, even if it's chasing or running away from another animal.")]
		private bool constainedToWanderZone;

		[SerializeField]
		[Tooltip("This animal will be peaceful towards species in this list.")]
		private string[] nonAgressiveTowards;

		private static List<Common_WanderScript> allAnimals = new List<Common_WanderScript>();

		[SerializeField]
		[Tooltip("If true, this animal will rotate to match the terrain. Ensure you have set the layer of the terrain as 'Terrain'.")]
		private bool matchSurfaceRotation;

		[SerializeField]
		[Tooltip("How fast the animnal rotates to match the surface rotation.")]
		private float surfaceRotationSpeed = 2f;

		[SerializeField]
		[Tooltip("If true, AI changes to this animal will be logged in the console.")]
		private bool logChanges;

		[SerializeField]
		[Tooltip("If true, gizmos will be drawn in the editor.")]
		private bool showGizmos;

		[SerializeField]
		private bool drawWanderRange = true;

		[SerializeField]
		private bool drawScentRange = true;

		[SerializeField]
		private bool drawAwarenessRange = true;

		public UnityEvent deathEvent;

		public UnityEvent attackingEvent;

		public UnityEvent idleEvent;

		public UnityEvent movementEvent;

		private Color distanceColor = new Color(0f, 0f, 205f);

		private Color awarnessColor = new Color(1f, 0f, 1f, 1f);

		private Color scentColor = new Color(1f, 0f, 0f, 1f);

		private Animator animator;

		private CharacterController characterController;

		private NavMeshAgent navMeshAgent;

		private Vector3 origin;

		private int totalIdleStateWeight;

		private int currentState;

		private bool dead;

		private bool moving;

		private bool useNavMesh;

		private Vector3 targetLocation = Vector3.zero;

		private float currentTurnSpeed;

		private bool attacking;

		public float MaxDistance
		{
			get
			{
				return wanderZone;
			}
			set
			{
				wanderZone = value;
			}
		}

		public static List<Common_WanderScript> AllAnimals => allAnimals;

		public void OnDrawGizmosSelected()
		{
			if (!showGizmos)
			{
				return;
			}
			if (drawWanderRange)
			{
				Gizmos.color = distanceColor;
				Gizmos.DrawWireSphere((origin == Vector3.zero) ? base.transform.position : origin, wanderZone);
				Gizmos.DrawIcon(new Vector3(base.transform.position.x, base.transform.position.y + wanderZone, base.transform.position.z), "ico-wander", allowScaling: true);
			}
			if (drawAwarenessRange)
			{
				Gizmos.color = awarnessColor;
				Gizmos.DrawWireSphere(base.transform.position, awareness);
				Gizmos.DrawIcon(new Vector3(base.transform.position.x, base.transform.position.y + awareness, base.transform.position.z), "ico-awareness", allowScaling: true);
			}
			if (drawScentRange)
			{
				Gizmos.color = scentColor;
				Gizmos.DrawWireSphere(base.transform.position, scent);
				Gizmos.DrawIcon(new Vector3(base.transform.position.x, base.transform.position.y + scent, base.transform.position.z), "ico-scent", allowScaling: true);
			}
			if (!Application.isPlaying)
			{
				return;
			}
			if (useNavMesh)
			{
				if (navMeshAgent.remainingDistance > 1f)
				{
					Gizmos.DrawSphere(navMeshAgent.destination + new Vector3(0f, 0.1f, 0f), 0.2f);
					Gizmos.DrawLine(base.transform.position, navMeshAgent.destination);
				}
			}
			else if (targetLocation != Vector3.zero)
			{
				Gizmos.DrawSphere(targetLocation + new Vector3(0f, 0.1f, 0f), 0.2f);
				Gizmos.DrawLine(base.transform.position, targetLocation);
			}
		}

		private void Awake()
		{
			animator = GetComponent<Animator>();
			RuntimeAnimatorController runtimeAnimatorController = animator.runtimeAnimatorController;
			if (logChanges)
			{
				if (runtimeAnimatorController == null)
				{
					UnityEngine.Debug.LogError($"{base.gameObject.name} has no animator controller, make sure you put one in to allow the character to walk. See documentation for more details (1)");
					base.enabled = false;
					return;
				}
				if (animator.avatar == null)
				{
					UnityEngine.Debug.LogError($"{base.gameObject.name} has no avatar, make sure you put one in to allow the character to animate. See documentation for more details (2)");
					base.enabled = false;
					return;
				}
				if (animator.hasRootMotion)
				{
					UnityEngine.Debug.LogError($"{base.gameObject.name} has root motion applied, consider turning this off as our script will deactivate this on play as we do not use it (3)");
					animator.applyRootMotion = false;
				}
				if (idleStates.Length == 0 || movementStates.Length == 0)
				{
					UnityEngine.Debug.LogError($"{base.gameObject.name} has no idle or movement states, make sure you fill these out. See documentation for more details (4)");
					base.enabled = false;
					return;
				}
				if (idleStates.Length != 0)
				{
					for (int i = 0; i < idleStates.Length; i++)
					{
						if (idleStates[i].animationBool == "")
						{
							UnityEngine.Debug.LogError(string.Format("{0} has " + idleStates.Length + " Idle states, you need to make sure that each state has an animation boolean. See documentation for more details (4)", base.gameObject.name));
							base.enabled = false;
							return;
						}
					}
				}
				if (movementStates.Length != 0)
				{
					for (int j = 0; j < movementStates.Length; j++)
					{
						if (movementStates[j].animationBool == "")
						{
							UnityEngine.Debug.LogError(string.Format("{0} has " + movementStates.Length + " Movement states, you need to make sure that each state has an animation boolean to see the character walk. See documentation for more details (4)", base.gameObject.name));
							base.enabled = false;
							return;
						}
						if (movementStates[j].moveSpeed <= 0f)
						{
							UnityEngine.Debug.LogError($"{base.gameObject.name} has a movement state with a speed of 0 or less, you need to set the speed higher than 0 to see the character move. See documentation for more details (4)");
							base.enabled = false;
							return;
						}
						if (movementStates[j].turnSpeed <= 0f)
						{
							UnityEngine.Debug.LogError($"{base.gameObject.name} has a turn speed state with a speed of 0 or less, you need to set the speed higher than 0 to see the character turn. See documentation for more details (4)");
							base.enabled = false;
							return;
						}
					}
				}
				if (attackingStates.Length == 0)
				{
					UnityEngine.Debug.Log(string.Format("{0} has " + attackingStates.Length + " this character will not be able to attack. See documentation for more details (4)", base.gameObject.name));
				}
				if (attackingStates.Length != 0)
				{
					for (int k = 0; k < attackingStates.Length; k++)
					{
						if (attackingStates[k].animationBool == "")
						{
							UnityEngine.Debug.LogError(string.Format("{0} has " + attackingStates.Length + " attacking states, you need to make sure that each state has an animation boolean. See documentation for more details (4)", base.gameObject.name));
							base.enabled = false;
							return;
						}
					}
				}
				if (stats == null)
				{
					UnityEngine.Debug.LogError($"{base.gameObject.name} has no AI stats, make sure you assign one to the wander script. See documentation for more details (5)");
					base.enabled = false;
					return;
				}
			}
			IdleState[] array = idleStates;
			foreach (IdleState idleState in array)
			{
				totalIdleStateWeight += idleState.stateWeight;
			}
			origin = base.transform.position;
			animator.applyRootMotion = false;
			characterController = GetComponent<CharacterController>();
			navMeshAgent = GetComponent<NavMeshAgent>();
			originalDominance = stats.dominance;
			dominance = originalDominance;
			toughness = stats.toughness;
			territorial = stats.territorial;
			stamina = stats.stamina;
			originalAgression = stats.agression;
			agression = originalAgression;
			attackSpeed = stats.attackSpeed;
			stealthy = stats.stealthy;
			originalScent = scent;
			scent = originalScent;
			if ((bool)navMeshAgent)
			{
				useNavMesh = true;
				navMeshAgent.stoppingDistance = 1f;
			}
			if (matchSurfaceRotation && base.transform.childCount > 0)
			{
				base.transform.GetChild(0).gameObject.AddComponent<Common_SurfaceRotation>().SetRotationSpeed(surfaceRotationSpeed);
			}
			allAnimals.Add(this);
		}

		private void Start()
		{
			if (Common_WanderManager.Instance != null && Common_WanderManager.Instance.PeaceTime)
			{
				SetPeaceTime(peace: true);
			}
			StartCoroutine(InitYield());
		}

		private void OnDestroy()
		{
			allAnimals.Remove(this);
		}

		private IEnumerator InitYield()
		{
			yield return new WaitForSeconds(UnityEngine.Random.Range(0, 200) / 100);
			DecideNextState(wasIdle: false, firstState: true);
		}

		private void DecideNextState(bool wasIdle, bool firstState = false)
		{
			attacking = false;
			if (awareness > 0f)
			{
				for (int i = 0; i < allAnimals.Count; i++)
				{
					if (!allAnimals[i].dead && !(allAnimals[i] == this) && !(allAnimals[i].species == species) && allAnimals[i].dominance > dominance && !allAnimals[i].stealthy && allAnimals[i].gameObject.activeSelf && !(Vector3.Distance(base.transform.position, allAnimals[i].transform.position) > awareness))
					{
						if (useNavMesh)
						{
							RunAwayFromAnimal(allAnimals[i]);
						}
						else
						{
							NonNavMeshRunAwayFromAnimal(allAnimals[i]);
						}
						if (logChanges)
						{
							UnityEngine.Debug.Log($"{base.gameObject.name}: Found predator ({allAnimals[i].gameObject.name}), running away.");
						}
						return;
					}
				}
			}
			if (dominance > 0)
			{
				for (int j = 0; j < allAnimals.Count; j++)
				{
					if (!allAnimals[j].dead && !(allAnimals[j] == this) && (!(allAnimals[j].species == species) || territorial) && allAnimals[j].dominance <= dominance && !allAnimals[j].stealthy && Array.IndexOf(nonAgressiveTowards, allAnimals[j].species) <= -1 && !(Vector3.Distance(base.transform.position, allAnimals[j].transform.position) > scent) && !((float)UnityEngine.Random.Range(0, 99) > agression))
					{
						if (logChanges)
						{
							UnityEngine.Debug.Log($"{base.gameObject.name}: Found prey ({allAnimals[j].gameObject.name}), chasing.");
						}
						if (!(allAnimals[j] == null))
						{
							ChaseAnimal(allAnimals[j]);
							return;
						}
					}
				}
			}
			if (wasIdle && movementStates.Length != 0)
			{
				if (logChanges)
				{
					UnityEngine.Debug.Log($"{base.gameObject.name}: Wandering.");
				}
				BeginWanderState();
			}
			else if (idleStates.Length != 0)
			{
				if (logChanges)
				{
					UnityEngine.Debug.Log($"{base.gameObject.name}: Idling.");
				}
				BeginIdleState(firstState);
			}
			else if (idleStates.Length == 0)
			{
				BeginWanderState();
			}
			else if (movementStates.Length == 0)
			{
				BeginIdleState();
			}
		}

		private void BeginIdleState(bool firstState = false)
		{
			if (!firstState)
			{
				int num = UnityEngine.Random.Range(0, totalIdleStateWeight);
				for (int i = 0; i < idleStates.Length; i++)
				{
					if (num < idleStates[i].stateWeight)
					{
						currentState = i;
						break;
					}
					num -= idleStates[i].stateWeight;
				}
			}
			if (idleStates.Length == 0)
			{
				BeginWanderState();
				return;
			}
			if (!string.IsNullOrEmpty(idleStates[currentState].animationBool))
			{
				animator.SetBool(idleStates[currentState].animationBool, value: true);
			}
			float stateTime = (firstState ? (UnityEngine.Random.Range(50f, idleStates[currentState].minStateTime * 100f) / 100f) : (UnityEngine.Random.Range(idleStates[currentState].minStateTime * 100f, idleStates[currentState].maxStateTime * 100f) / 100f));
			StartCoroutine(IdleState(stateTime));
		}

		private IEnumerator IdleState(float stateTime)
		{
			moving = false;
			yield return new WaitForSeconds(stateTime);
			if ((idleStates[currentState] != null || idleStates.Length < currentState) && !string.IsNullOrEmpty(idleStates[currentState].animationBool))
			{
				animator.SetBool(idleStates[currentState].animationBool, value: false);
			}
			idleEvent.Invoke();
			DecideNextState(wasIdle: true);
		}

		private void BeginWanderState()
		{
			Vector3 target = RandonPointInRange();
			int num = 0;
			for (int i = 0; i < movementStates.Length; i++)
			{
				if (movementStates[i].moveSpeed < movementStates[num].moveSpeed)
				{
					num = i;
				}
			}
			currentState = num;
			if (!string.IsNullOrEmpty(movementStates[currentState].animationBool))
			{
				animator.SetBool(movementStates[currentState].animationBool, value: true);
			}
			movementEvent.Invoke();
			if (useNavMesh)
			{
				StartCoroutine(MovementState(target));
			}
			else
			{
				StartCoroutine(NonNavMeshMovementState(target));
			}
		}

		private IEnumerator MovementState(Vector3 target)
		{
			moving = true;
			navMeshAgent.speed = movementStates[currentState].moveSpeed;
			navMeshAgent.angularSpeed = movementStates[currentState].turnSpeed;
			navMeshAgent.SetDestination(target);
			float timeMoving = 0f;
			while ((navMeshAgent.remainingDistance > navMeshAgent.stoppingDistance || timeMoving < 0.1f) && timeMoving < movementStates[currentState].maxStateTime)
			{
				timeMoving += Time.deltaTime;
				yield return null;
			}
			navMeshAgent.SetDestination(base.transform.position);
			if (!string.IsNullOrEmpty(movementStates[currentState].animationBool))
			{
				animator.SetBool(movementStates[currentState].animationBool, value: false);
			}
			DecideNextState(wasIdle: false);
		}

		private IEnumerator NonNavMeshMovementState(Vector3 target)
		{
			moving = true;
			targetLocation = target;
			currentTurnSpeed = movementStates[currentState].turnSpeed;
			float walkTime = 0f;
			float timeUntilAbortWalk = Vector3.Distance(base.transform.position, target) / movementStates[currentState].moveSpeed;
			while (Vector3.Distance(base.transform.position, target) > 1f && walkTime < timeUntilAbortWalk)
			{
				characterController.SimpleMove(base.transform.TransformDirection(Vector3.forward) * movementStates[currentState].moveSpeed);
				Quaternion b = Quaternion.LookRotation(target - base.transform.position);
				base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, Time.deltaTime * (currentTurnSpeed / 10f));
				currentTurnSpeed += Time.deltaTime;
				walkTime += Time.deltaTime;
				yield return null;
			}
			targetLocation = Vector3.zero;
			if (!string.IsNullOrEmpty(movementStates[currentState].animationBool))
			{
				animator.SetBool(movementStates[currentState].animationBool, value: false);
			}
			DecideNextState(wasIdle: false);
		}

		private void RunAwayFromAnimal(Common_WanderScript predator)
		{
			moving = true;
			Quaternion rotation = base.transform.rotation;
			base.transform.rotation = Quaternion.LookRotation(base.transform.position - predator.transform.position);
			NavMesh.SamplePosition(base.transform.position + base.transform.forward * 5f, out var hit, 5f, 1 << NavMesh.GetAreaFromName("Walkable"));
			Vector3 vector = hit.position;
			base.transform.rotation = rotation;
			if (constainedToWanderZone && Vector3.Distance(vector, origin) > wanderZone)
			{
				vector = RandonPointInRange();
			}
			int num = 0;
			for (int i = 0; i < movementStates.Length; i++)
			{
				if (movementStates[i].moveSpeed > movementStates[num].moveSpeed)
				{
					num = i;
				}
			}
			currentState = num;
			if (!string.IsNullOrEmpty(movementStates[currentState].animationBool))
			{
				animator.SetBool(movementStates[currentState].animationBool, value: true);
			}
			StartCoroutine(RunAwayState(vector, predator));
		}

		private IEnumerator RunAwayState(Vector3 target, Common_WanderScript predator)
		{
			navMeshAgent.speed = movementStates[currentState].moveSpeed;
			navMeshAgent.angularSpeed = movementStates[currentState].turnSpeed;
			navMeshAgent.SetDestination(target);
			float timeMoving = 0f;
			while ((navMeshAgent.remainingDistance > navMeshAgent.stoppingDistance || timeMoving < 0.1f) && timeMoving < stamina)
			{
				timeMoving += Time.deltaTime;
				yield return null;
			}
			navMeshAgent.SetDestination(base.transform.position);
			if (!string.IsNullOrEmpty(movementStates[currentState].animationBool))
			{
				animator.SetBool(movementStates[currentState].animationBool, value: false);
			}
			if (timeMoving > stamina || predator.dead || Vector3.Distance(base.transform.position, predator.transform.position) > awareness)
			{
				BeginIdleState();
			}
			else
			{
				RunAwayFromAnimal(predator);
			}
		}

		private void NonNavMeshRunAwayFromAnimal(Common_WanderScript predator)
		{
			moving = true;
			Quaternion rotation = base.transform.rotation;
			base.transform.rotation = Quaternion.LookRotation(base.transform.position - predator.transform.position);
			targetLocation = base.transform.position + base.transform.forward * 5f;
			base.transform.rotation = rotation;
			if (constainedToWanderZone && Vector3.Distance(targetLocation, origin) > wanderZone)
			{
				targetLocation = RandonPointInRange();
			}
			int num = 0;
			for (int i = 0; i < movementStates.Length; i++)
			{
				if (movementStates[i].moveSpeed > movementStates[num].moveSpeed)
				{
					num = i;
				}
			}
			currentState = num;
			if (!string.IsNullOrEmpty(movementStates[currentState].animationBool))
			{
				animator.SetBool(movementStates[currentState].animationBool, value: true);
			}
			StartCoroutine(NonNavMeshRunAwayState(targetLocation, predator));
		}

		private IEnumerator NonNavMeshRunAwayState(Vector3 target, Common_WanderScript predator)
		{
			currentTurnSpeed = movementStates[currentState].turnSpeed;
			float walkTime = 0f;
			float timeUntilAbortWalk = Vector3.Distance(base.transform.position, target) / movementStates[currentState].moveSpeed;
			while (Vector3.Distance(base.transform.position, target) > 1f && walkTime < timeUntilAbortWalk && stamina > 0f)
			{
				characterController.SimpleMove(base.transform.TransformDirection(Vector3.forward) * movementStates[currentState].moveSpeed);
				Quaternion b = Quaternion.LookRotation(target - base.transform.position);
				base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, Time.deltaTime * (currentTurnSpeed / 10f));
				currentTurnSpeed += Time.deltaTime;
				walkTime += Time.deltaTime;
				stamina -= Time.deltaTime;
				yield return null;
			}
			targetLocation = Vector3.zero;
			if (!string.IsNullOrEmpty(movementStates[currentState].animationBool))
			{
				animator.SetBool(movementStates[currentState].animationBool, value: false);
			}
			if (stamina <= 0f || predator.dead || Vector3.Distance(base.transform.position, predator.transform.position) > awareness)
			{
				BeginIdleState();
			}
			else
			{
				NonNavMeshRunAwayFromAnimal(predator);
			}
		}

		private void ChaseAnimal(Common_WanderScript prey)
		{
			_ = prey.transform.position;
			prey.BeginChase(this);
			if (movementStates.Length == 0)
			{
				UnityEngine.Debug.Log("Movement states length is 0");
				base.enabled = false;
				return;
			}
			int num = 0;
			for (int i = 0; i < movementStates.Length; i++)
			{
				if (movementStates[i].moveSpeed > movementStates[num].moveSpeed)
				{
					num = i;
				}
			}
			currentState = num;
			if (!string.IsNullOrEmpty(movementStates[currentState].animationBool))
			{
				animator.SetBool(movementStates[currentState].animationBool, value: true);
			}
			if (useNavMesh)
			{
				StartCoroutine(ChaseState(prey));
			}
			else
			{
				StartCoroutine(NonNavMeshChaseState(prey));
			}
		}

		private IEnumerator ChaseState(Common_WanderScript prey)
		{
			moving = true;
			navMeshAgent.speed = movementStates[currentState].moveSpeed;
			navMeshAgent.angularSpeed = movementStates[currentState].turnSpeed;
			navMeshAgent.SetDestination(prey.transform.position);
			float timeMoving = 0f;
			bool gotAway = false;
			while ((navMeshAgent.remainingDistance > navMeshAgent.stoppingDistance || timeMoving < 0.1f) && timeMoving < stamina)
			{
				navMeshAgent.SetDestination(prey.transform.position);
				timeMoving += Time.deltaTime;
				if (Vector3.Distance(base.transform.position, prey.transform.position) < 2f)
				{
					if (logChanges)
					{
						UnityEngine.Debug.Log($"{base.gameObject.name}: Caught prey ({prey.gameObject.name})!");
					}
					if (!string.IsNullOrEmpty(movementStates[currentState].animationBool))
					{
						animator.SetBool(movementStates[currentState].animationBool, value: false);
					}
					AttackAnimal(prey);
					yield break;
				}
				if (constainedToWanderZone && Vector3.Distance(base.transform.position, origin) > wanderZone)
				{
					gotAway = true;
					navMeshAgent.SetDestination(base.transform.position);
					break;
				}
				yield return null;
			}
			navMeshAgent.SetDestination(base.transform.position);
			if (!string.IsNullOrEmpty(movementStates[currentState].animationBool))
			{
				animator.SetBool(movementStates[currentState].animationBool, value: false);
			}
			if (timeMoving > stamina || prey.dead || Vector3.Distance(base.transform.position, prey.transform.position) > scent || gotAway)
			{
				BeginIdleState();
			}
			else
			{
				ChaseAnimal(prey);
			}
		}

		private IEnumerator NonNavMeshChaseState(Common_WanderScript prey)
		{
			moving = true;
			targetLocation = prey.transform.position;
			currentTurnSpeed = movementStates[currentState].turnSpeed;
			float walkTime = 0f;
			bool gotAway = false;
			float timeUntilAbortWalk = Vector3.Distance(base.transform.position, targetLocation) / movementStates[currentState].moveSpeed;
			while (Vector3.Distance(base.transform.position, targetLocation) > 1f && walkTime < timeUntilAbortWalk && stamina > 0f)
			{
				characterController.SimpleMove(base.transform.TransformDirection(Vector3.forward) * movementStates[currentState].moveSpeed);
				targetLocation = prey.transform.position;
				Quaternion b = Quaternion.LookRotation(targetLocation - base.transform.position);
				base.transform.rotation = Quaternion.Slerp(base.transform.rotation, b, Time.deltaTime * (currentTurnSpeed / 10f));
				currentTurnSpeed += Time.deltaTime;
				walkTime += Time.deltaTime;
				stamina -= Time.deltaTime;
				if (Vector3.Distance(base.transform.position, prey.transform.position) < 2f)
				{
					if (logChanges)
					{
						UnityEngine.Debug.Log($"{base.gameObject.name}: Caught prey ({prey.gameObject.name})!");
					}
					if (!string.IsNullOrEmpty(movementStates[currentState].animationBool))
					{
						animator.SetBool(movementStates[currentState].animationBool, value: false);
					}
					AttackAnimal(prey);
					yield break;
				}
				if (constainedToWanderZone && Vector3.Distance(base.transform.position, origin) > wanderZone)
				{
					gotAway = true;
					targetLocation = base.transform.position;
					break;
				}
				yield return null;
			}
			targetLocation = Vector3.zero;
			if (!string.IsNullOrEmpty(movementStates[currentState].animationBool))
			{
				animator.SetBool(movementStates[currentState].animationBool, value: false);
			}
			if (stamina <= 0f || prey.dead || Vector3.Distance(base.transform.position, prey.transform.position) > scent || gotAway)
			{
				BeginIdleState();
			}
			else
			{
				ChaseAnimal(prey);
			}
		}

		private void AttackAnimal(Common_WanderScript target)
		{
			attacking = true;
			if (logChanges)
			{
				UnityEngine.Debug.Log($"{base.gameObject.name}: Attacking {target.gameObject.name}!");
			}
			if (useNavMesh)
			{
				navMeshAgent.SetDestination(base.transform.position);
			}
			else
			{
				targetLocation = base.transform.position;
			}
			currentState = UnityEngine.Random.Range(0, attackingStates.Length);
			if (attackingStates.Length != 0 && !string.IsNullOrEmpty(attackingStates[currentState].animationBool))
			{
				animator.SetBool(attackingStates[currentState].animationBool, value: true);
			}
			StartCoroutine(MakeAttack(target));
		}

		private IEnumerator MakeAttack(Common_WanderScript target)
		{
			target.GetAttacked(this);
			float timer = 0f;
			while (!target.dead)
			{
				timer += Time.deltaTime;
				if (timer > attackSpeed)
				{
					target.TakeDamage(power);
					timer = 0f;
				}
				yield return null;
			}
			if (attackingStates.Length != 0 && !string.IsNullOrEmpty(attackingStates[currentState].animationBool))
			{
				animator.SetBool(attackingStates[currentState].animationBool, value: false);
			}
			attackingEvent.Invoke();
			StopAllCoroutines();
			DecideNextState(wasIdle: false);
		}

		private void GetAttacked(Common_WanderScript attacker)
		{
			if (attacking)
			{
				return;
			}
			if (logChanges)
			{
				UnityEngine.Debug.Log($"{base.gameObject.name}: Getting attacked by {attacker.gameObject.name}!");
			}
			StopAllCoroutines();
			StartCoroutine(TurnToLookAtTarget(attacker.transform));
			if (agression > 0f)
			{
				if (!string.IsNullOrEmpty(movementStates[currentState].animationBool))
				{
					animator.SetBool(movementStates[currentState].animationBool, value: false);
				}
				AttackAnimal(attacker);
			}
			else if (moving)
			{
				if (useNavMesh)
				{
					navMeshAgent.SetDestination(base.transform.position);
				}
				else
				{
					targetLocation = base.transform.position;
				}
				if (!string.IsNullOrEmpty(movementStates[currentState].animationBool))
				{
					animator.SetBool(movementStates[currentState].animationBool, value: false);
				}
				moving = false;
			}
			else if (idleStates.Length != 0 && !string.IsNullOrEmpty(idleStates[currentState].animationBool))
			{
				animator.SetBool(idleStates[currentState].animationBool, value: false);
			}
		}

		private void TakeDamage(float damage)
		{
			toughness -= damage;
			if (toughness <= 0f)
			{
				Die();
			}
		}

		public void Die()
		{
			if (logChanges)
			{
				UnityEngine.Debug.Log($"{base.gameObject.name}: Died!");
			}
			StopAllCoroutines();
			dead = true;
			if (useNavMesh)
			{
				navMeshAgent.SetDestination(base.transform.position);
			}
			else
			{
				targetLocation = base.transform.position;
			}
			IdleState[] array = idleStates;
			foreach (AIState aIState in array)
			{
				if (!string.IsNullOrEmpty(aIState.animationBool))
				{
					animator.SetBool(aIState.animationBool, value: false);
				}
			}
			MovementState[] array2 = movementStates;
			foreach (AIState aIState2 in array2)
			{
				if (!string.IsNullOrEmpty(aIState2.animationBool))
				{
					animator.SetBool(aIState2.animationBool, value: false);
				}
			}
			AIState[] array3 = attackingStates;
			foreach (AIState aIState3 in array3)
			{
				if (!string.IsNullOrEmpty(aIState3.animationBool))
				{
					animator.SetBool(aIState3.animationBool, value: false);
				}
			}
			if (deathStates.Length != 0)
			{
				currentState = UnityEngine.Random.Range(0, deathStates.Length);
				if (!string.IsNullOrEmpty(deathStates[currentState].animationBool))
				{
					animator.SetBool(deathStates[currentState].animationBool, value: true);
				}
			}
			else
			{
				SkinnedMeshRenderer[] componentsInChildren = GetComponentsInChildren<SkinnedMeshRenderer>();
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					componentsInChildren[i].enabled = false;
				}
			}
			deathEvent.Invoke();
			base.enabled = false;
		}

		public void SetPeaceTime(bool peace)
		{
			if (peace)
			{
				dominance = 0;
				scent = 0f;
				agression = 0f;
			}
			else
			{
				dominance = originalDominance;
				scent = originalScent;
				agression = originalAgression;
			}
		}

		private Vector3 RandonPointInRange()
		{
			Vector3 vector = origin + UnityEngine.Random.insideUnitSphere * wanderZone;
			return new Vector3(vector.x, base.transform.position.y, vector.z);
		}

		private IEnumerator TurnToLookAtTarget(Transform target)
		{
			while (true)
			{
				Vector3 vector = target.position - base.transform.position;
				if (!(Vector3.Angle(vector, base.transform.forward) < 1f))
				{
					float maxRadiansDelta = 2f * Time.deltaTime;
					Vector3 forward = Vector3.RotateTowards(base.transform.forward, vector, maxRadiansDelta, 0f);
					base.transform.rotation = Quaternion.LookRotation(forward);
					yield return null;
					continue;
				}
				break;
			}
		}

		private void BeginChase(Common_WanderScript chasingAnimal)
		{
			if (!attacking)
			{
				StartCoroutine(ChaseCheck(chasingAnimal));
			}
		}

		private IEnumerator ChaseCheck(Common_WanderScript chasingAnimal)
		{
			while (Vector3.Distance(base.transform.position, chasingAnimal.transform.position) > awareness)
			{
				yield return new WaitForSeconds(0.5f);
			}
			StopAllCoroutines();
			if (moving)
			{
				if (useNavMesh)
				{
					navMeshAgent.SetDestination(base.transform.position);
				}
				else
				{
					targetLocation = base.transform.position;
				}
				if (!string.IsNullOrEmpty(movementStates[currentState].animationBool))
				{
					animator.SetBool(movementStates[currentState].animationBool, value: false);
				}
				moving = false;
			}
			else if (idleStates.Length - 1 >= currentState && idleStates.Length != 0 && !string.IsNullOrEmpty(idleStates[currentState].animationBool))
			{
				animator.SetBool(idleStates[currentState].animationBool, value: false);
			}
			DecideNextState(wasIdle: false);
		}
	}
	[Serializable]
	public class IdleState : AIState
	{
		public float minStateTime = 20f;

		public float maxStateTime = 40f;

		[Tooltip("Chance of it choosing this state, in comparion to other state weights.")]
		public int stateWeight = 20;
	}
	[Serializable]
	public class MovementState : AIState
	{
		public float maxStateTime = 40f;

		public float moveSpeed = 3f;

		public float turnSpeed = 120f;
	}
	public class People_AIStats : AIStats
	{
	}
	public class People_AudioManager : Common_AudioManager
	{
	}
	public class People_SurfaceRotation : Common_SurfaceRotation
	{
	}
	public class People_WanderManager : Common_WanderManager
	{
	}
	public class People_WanderScript : Common_WanderScript
	{
	}
}
namespace ParticleFX01
{
	public class Rotating : MonoBehaviour
	{
		public Vector3 rotationSpeed = Vector3.zero;

		public Space relativeTo = Space.Self;

		private void Update()
		{
			base.transform.Rotate(rotationSpeed * Time.deltaTime, relativeTo);
		}

		public void ForcedRotation(float time)
		{
			base.transform.Rotate(rotationSpeed * time, relativeTo);
		}
	}
}
namespace UnityTemplateProjects
{
	public class SimpleCameraController : MonoBehaviour
	{
		private class CameraState
		{
			public float yaw;

			public float pitch;

			public float roll;

			public float x;

			public float y;

			public float z;

			public void SetFromTransform(Transform t)
			{
				pitch = t.eulerAngles.x;
				yaw = t.eulerAngles.y;
				roll = t.eulerAngles.z;
				x = t.position.x;
				y = t.position.y;
				z = t.position.z;
			}

			public void Translate(Vector3 translation)
			{
				Vector3 vector = Quaternion.Euler(pitch, yaw, roll) * translation;
				x += vector.x;
				y += vector.y;
				z += vector.z;
			}

			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
				yaw = Mathf.Lerp(yaw, target.yaw, rotationLerpPct);
				pitch = Mathf.Lerp(pitch, target.pitch, rotationLerpPct);
				roll = Mathf.Lerp(roll, target.roll, rotationLerpPct);
				x = Mathf.Lerp(x, target.x, positionLerpPct);
				y = Mathf.Lerp(y, target.y, positionLerpPct);
				z = Mathf.Lerp(z, target.z, positionLerpPct);
			}

			public void UpdateTransform(Transform t)
			{
				t.eulerAngles = new Vector3(pitch, yaw, roll);
				t.position = new Vector3(x, y, z);
			}
		}

		private CameraState m_TargetCameraState = new CameraState();

		private CameraState m_InterpolatingCameraState = new CameraState();

		[Header("Movement Settings")]
		[Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		public float boost = 3.5f;

		[Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float positionLerpTime = 0.2f;

		[Header("Rotation Settings")]
		[Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		public AnimationCurve mouseSensitivityCurve = new AnimationCurve(new Keyframe(0f, 0.5f, 0f, 5f), new Keyframe(1f, 2.5f, 0f, 0f));

		[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime = 0.01f;

		[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		private void OnEnable()
		{
			m_TargetCameraState.SetFromTransform(base.transform);
			m_InterpolatingCameraState.SetFromTransform(base.transform);
		}

		private Vector3 GetInputTranslationDirection()
		{
			Vector3 result = default(Vector3);
			if (Input.GetKey(KeyCode.W))
			{
				result += Vector3.forward;
			}
			if (Input.GetKey(KeyCode.S))
			{
				result += Vector3.back;
			}
			if (Input.GetKey(KeyCode.A))
			{
				result += Vector3.left;
			}
			if (Input.GetKey(KeyCode.D))
			{
				result += Vector3.right;
			}
			if (Input.GetKey(KeyCode.Q))
			{
				result += Vector3.down;
			}
			if (Input.GetKey(KeyCode.E))
			{
				result += Vector3.up;
			}
			return result;
		}

		private void Update()
		{
			if (Input.GetKey(KeyCode.Escape))
			{
				Application.Quit();
			}
			if (Input.GetMouseButtonDown(1))
			{
				Cursor.lockState = CursorLockMode.Locked;
			}
			if (Input.GetMouseButtonUp(1))
			{
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
			}
			if (Input.GetMouseButton(1))
			{
				Vector2 vector = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y") * (float)(invertY ? 1 : (-1)));
				float num = mouseSensitivityCurve.Evaluate(vector.magnitude);
				m_TargetCameraState.yaw += vector.x * num;
				m_TargetCameraState.pitch += vector.y * num;
			}
			Vector3 translation = GetInputTranslationDirection() * Time.deltaTime;
			if (Input.GetKey(KeyCode.LeftShift))
			{
				translation *= 10f;
			}
			boost += Input.mouseScrollDelta.y * 0.2f;
			translation *= Mathf.Pow(2f, boost);
			m_TargetCameraState.Translate(translation);
			float positionLerpPct = 1f - Mathf.Exp(Mathf.Log(0.00999999f) / positionLerpTime * Time.deltaTime);
			float rotationLerpPct = 1f - Mathf.Exp(Mathf.Log(0.00999999f) / rotationLerpTime * Time.deltaTime);
			m_InterpolatingCameraState.LerpTowards(m_TargetCameraState, positionLerpPct, rotationLerpPct);
			m_InterpolatingCameraState.UpdateTransform(base.transform);
		}
	}
}
